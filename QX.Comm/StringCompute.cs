using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace QX.Comm
{
    public class StringCompute
    {
        private const char EndChar = ';';
        private const char Inter_Minus = '#';//内部负号  
        private const char FlagChar = '$';
        private static readonly char[] InvalidChars = new char[] { EndChar, Inter_Minus, FlagChar };
        private static readonly char[] Symbols = new char[] { '*', '/', '+', '-', '(', ')' };
        private static readonly char[] Symbols_Simple = new char[] { '*', '/', '+', '-', EndChar };

        public static double EvaluateSimpleexpression_r(string expression)
        {
            double result = 0;//结果  
            double data = 0;//中间结果  
            string dataStr;
            char opera, topopera;
            int index;
            ArrayList NS = new ArrayList();     //数栈  
            ArrayList OS = new ArrayList();     //运算符栈  

            expression += EndChar;
            if (expression[0] == '-' || expression[0] == '+')
                expression = "0" + expression;

            while ((index = expression.IndexOfAny(Symbols_Simple)) != -1)
            {
                if (index != 0)     //数据  
                {
                    try
                    {
                        dataStr = expression.Substring(0, index);
                        if (dataStr[0] == Inter_Minus) dataStr = "-" + dataStr.Remove(0, 1);
                        data = double.Parse(dataStr);
                        NS.Add(data);
                        expression = expression.Substring(index, expression.Length - index);
                    }
                    catch (Exception ec)
                    {
                        throw new Exception("表达式中有不能识别的字符。", ec);
                    }
                }
                else   //运算符  
                {
                    try
                    {
                        opera = expression[index];
                        if (OS.Count == 0)
                        {
                            if (opera == EndChar)
                                result = (double)NS[NS.Count - 1];
                            else
                                OS.Add(opera);
                        }
                        else
                        {
                            topopera = (char)OS[OS.Count - 1];
                            while ((topopera == '*' || topopera == '/') ||
                            ((topopera == '+' || topopera == '-') && (opera != '*' && opera != '/')) ||
                            (opera == EndChar && topopera != FlagChar))
                            //当前运算符优先级低于栈顶运算符优先级  
                            {
                                switch (topopera)
                                {
                                    case '+':
                                        data = (double)NS[NS.Count - 2] + (double)NS[NS.Count - 1];
                                        break;
                                    case '-':
                                        data = (double)NS[NS.Count - 2] - (double)NS[NS.Count - 1];
                                        break;
                                    case '*':
                                        data = (double)NS[NS.Count - 2] * (double)NS[NS.Count - 1];
                                        break;
                                    case '/':
                                        data = (double)NS[NS.Count - 2] / (double)NS[NS.Count - 1];
                                        break;
                                }
                                NS.RemoveAt(NS.Count - 1);
                                NS.RemoveAt(NS.Count - 1);
                                NS.Add(data);
                                OS.RemoveAt(OS.Count - 1);
                                if (OS.Count == 0)
                                    topopera = FlagChar;
                                else
                                    topopera = (char)OS[OS.Count - 1];
                            }
                            if (opera == EndChar)
                            {
                                result = (double)NS[NS.Count - 1];
                            }
                            else
                            {
                                OS.Add(opera);
                            }
                        }
                        expression = expression.Substring(index + 1, expression.Length - index - 1);
                    }
                    catch (Exception ec)
                    {
                        throw new Exception("非法的表达式。", ec);
                    }
                }
            }
            return result;
        }
    }
}
