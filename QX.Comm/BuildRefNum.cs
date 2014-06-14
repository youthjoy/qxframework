using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace QX.Comm
{

    public class MathElement{

        public string Field { get; set; }
        public string Op { get; set; }
        public string MathStr { get; set; }

    }

    /// <summary>
    /// 构造Num检查字符串
    /// </summary>
    public static class BuildMathElement{

        public static MathElement build(string str)
        {
            MathElement element = new MathElement();
            try
            {
                element = JsonConvert.DeserializeObject<MathElement>("{"+str+"}");
            }
            catch (System.Exception ex)
            {
                element = null;  
            }
            return element;
        }
        
    }

    public class Arithmetic
    {
        public const string LEFT_BRACKET = "(";
        public const string RIGHT_BRACKET = ")";
        public const string PLUS = "+";
        public const string SUB = "-";
        public const string MULTI = "*";
        public const string DIV = "/";

        /// <summary>
        /// 动态计算数学表达式
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public double Eval(string expr)
        {
            List<string> wordTree = new List<string>();
            string tmp = "";
            //得到数字
            Action addNum = () =>
            {
                if (tmp.Length > 0)
                {
                    wordTree.Add(tmp);
                    tmp = "";
                }
            };
            #region 词法解析
            foreach (var c in expr)
            {
                if (c == ' ')
                {
                    addNum();
                    continue;
                }
                else if (c == '(')
                {
                    addNum();
                    wordTree.Add(LEFT_BRACKET);
                }
                else if (c == ')')
                {
                    addNum();
                    wordTree.Add(RIGHT_BRACKET);
                }
                else if (c == '+')
                {
                    addNum();
                    wordTree.Add(PLUS);
                }
                else if (c == '-')
                {
                    addNum();
                    wordTree.Add(SUB);
                }
                else if (c == '*')
                {
                    addNum();
                    wordTree.Add(MULTI);
                }
                else if (c == '/')
                {
                    addNum();
                    wordTree.Add(DIV);
                }
                else
                    tmp += c;
            }
            #endregion
            addNum();
            var pos = 0;
            return Parse(wordTree, ref pos).Compute().Number;
        }

        #region 语义解析
        private INode Parse(List<string> wordTree, ref int pos)
        {
            var assist = new ParseAssist();
            //计算中间结果
            Action priority_compute = () =>
            {
                //判断是否达到3数字，2操作符
                if (assist.CanCompute)
                    assist.Combinate();
            };
            for (; pos < wordTree.Count; ++pos, priority_compute())
            {
                var word = wordTree[pos];
                //遇到左边的小括号进入递归
                if (word == LEFT_BRACKET)
                {
                    ++pos;
                    assist.AddNum(Parse(wordTree, ref pos));
                    continue;
                }
                //遇到右边的小括号推出递归
                if (word == RIGHT_BRACKET)
                    break;
                if (this.IsOp(word))
                    assist.AddOp(word);
                else
                    assist.AddNum(word);
            }
            return assist.Combinate();
        }
        #endregion
        private bool IsOp(string op)
        {
            switch (op)
            {
                case PLUS:
                case SUB:
                case MULTI:
                case DIV:
                    return true;
                default:
                    return false;
            }
        }
    }

    #region 节点对象
    //语法树节点
    interface INode
    {
        Num Compute();
    }
    //数字
    class Num : INode
    {
        public double Number { get; set; }

        public Num(double number)
        {
            this.Number = number;
        }

        public Num Compute()
        {
            return this;
        }
    }
    //运算符
    abstract class Op : INode
    {
        INode _left;
        INode _right;

        public Op(INode left, INode right)
        {
            this._left = left;
            this._right = right;
        }

        public Num Compute()
        {
            return new Num(this.Operate(this._left.Compute().Number, this._right.Compute().Number));
        }

        protected abstract double Operate(double a, double b);
    }

    class Plus_Op : Op
    {
        public Plus_Op(INode left, INode right) : base(left, right) { }
        protected override double Operate(double a, double b)
        {
            return a + b;
        }
    }
    class Sub_Op : Op
    {
        public Sub_Op(INode left, INode right) : base(left, right) { }
        protected override double Operate(double a, double b)
        {
            return a - b;
        }
    }
    class Multi_Op : Op
    {
        public Multi_Op(INode left, INode right) : base(left, right) { }
        protected override double Operate(double a, double b)
        {
            return a * b;
        }
    }
    class Div_Op : Op
    {
        public Div_Op(INode left, INode right) : base(left, right) { }
        protected override double Operate(double a, double b)
        {
            return a / b;
        }
    }
    #endregion

    #region 运算符优先级判定辅助类
    //语义解析辅助类，处理 1 + 2 * 3这种式子的决断作用
    class ParseAssist
    {
        INode _n1;          //操作数1
        INode _n2;          //操作数2
        INode _n3;          //操作数3
        string _op1 = null; //运算符1
        string _op2 = null; //运算符2

        //当前是否num op num op num形式了
        public bool CanCompute { get; private set; }
        public void AddNum(string n)
        {
            var tmp = new Num(Convert.ToDouble(n));
            this.AddNum(tmp);
        }
        public void AddNum(INode n)
        {
            //判断op1为了处理正数负数情况
            if (this._n1 == null && this._op1 == null)
                this._n1 = n;
            else if (this._n2 == null)
            {
                this._n2 = n;
                //处理正数负数
                if (this._n1 == null)
                {
                    this._n1 = this.GetOp(this._op1, new Num(0), this._n2);
                    this._op1 = null;
                    this._n2 = null;
                }
            }
            else
            {
                this._n3 = n;
                this.CanCompute = true;
            }
        }
        public void AddOp(string op)
        {
            if (this._op1 == null)
                this._op1 = op;
            else
                this._op2 = op;
        }
        //组合出一个节点树
        public INode Combinate()
        {
            INode tmp = null;
            //判断优先级
            if (this.Priority(this._op1, this._op2))
            {
                //计算前二个数字
                tmp = GetOp(this._op1, this._n1, this._n2);
                this._n1 = tmp;
                this._n2 = this._n3;
                this._op1 = this._op2;
            }
            else
            {
                //计算后两个数字
                tmp = GetOp(this._op2, this._n2, this._n3);
                this._n2 = tmp;
                this._n3 = null;
                this._op2 = null;
                this.CanCompute = false;
            }
            return tmp;
        }
        //得到Op对象
        private INode GetOp(string op, INode a, INode b)
        {
            if (b == null)
                b = new Num(0);
            switch (op)
            {
                case Arithmetic.PLUS:
                    return new Plus_Op(a, b);
                case Arithmetic.SUB:
                    return new Sub_Op(a, b);
                case Arithmetic.MULTI:
                    return new Multi_Op(a, b);
                case Arithmetic.DIV:
                    return new Div_Op(a, b);
                default:
                    return null;
            }
        }
        //运算符优先级判断
        private bool Priority(string op1, string op2)
        {
            if (op1 == null)
            {
                this._op1 = Arithmetic.PLUS;
                return true;
            }
            if (op1 == Arithmetic.PLUS || op1 == Arithmetic.SUB)
            {
                if (op2 == null || op2 == Arithmetic.PLUS || op2 == Arithmetic.SUB)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }

    }
    #endregion


}
