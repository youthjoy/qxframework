using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QX.Comm
{
    /// <summary>
    /// 验证类型
    /// </summary>
    public class ValidationType{
        /// <summary>
        /// 不能为空
        /// </summary>
        public string required { get; set; }
        /// <summary>
        /// 远程验证是否通过
        /// </summary>
        public string remote { get; set; }
        /// <summary>
        ///  至少需要多少个字符数
        /// </summary>
        public string minlength { get; set; }
        /// <summary>
        /// 允许输入的最大字符数
        /// </summary>
        public string maxlength { get; set; }
        /// <summary>
        /// 允许输入的字符数范围
        /// </summary>
        public string rangelength { get; set; }
        /// <summary>
        /// 需要输入的最小整数
        /// </summary>
        public int min { get; set; }
        /// <summary>
        /// 给定的最大整数
        /// </summary>
        public int max { get; set; }
        /// <summary>
        /// 给定的整数范围
        /// </summary>
        public int range { get; set; }
        /// <summary>
        /// 确保表单元素的值为一个有效的email地址
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 确保表单元素的值为一个有效的URL地址(http://www.mydomain.com)。
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 用来验证有效的日期。这三个函数分别验证的日期格式为(mm/dd/yyyy)、(yyyy-mm-dd,yyyy/mm/dd)、(mm.dd.yyyy)。 
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 用来验证小数。number()的小数点为圆点( . )，numberDE()的小数点为英文逗号( , )。
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 确保文本框中的值为数字
        /// </summary>
        public string digits { get; set; }
        /// <summary>
        /// 确保表单元素接收给定的文件后缀名的文件
        /// </summary>
        public string accept { get; set; }
        /// <summary>
        /// 要与当前值比较的另一个表单元素  equalTo: "#password"
        /// </summary>
        public string equalTo { get; set; }
    }


    /// <summary>
    /// Jquery Validation 后台验证类
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool Required(string txt){
            if (!string.IsNullOrEmpty(txt.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 字符串最小的长度
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static bool minlength(this string txt, int min)
        {
            bool result = false;
            if (txt.Length>min)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 字符串的最大长度
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool maxlength(this string txt,int max)
        {
            bool result = false;
            if (txt.Length<=max)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 字符串的最小最大范围
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool rangelength(this string txt,int min,int max)
        {
            bool result = false;
            if (txt.Length>=min && txt.Length<=max)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 整形最小值
        /// </summary>
        /// <param name="input"></param>
        /// <param name="minvalue"></param>
        /// <returns></returns>
        public static bool min(this int input,int minvalue)
        {
            bool result = false;
            if (input>=minvalue)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 整形最大值
        /// </summary>
        /// <param name="input"></param>
        /// <param name="maxvalue"></param>
        /// <returns></returns>
        public static bool max(this int input,int maxvalue)
        {
            bool result = false;
            if (input<=maxvalue)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 整形最小最大值
        /// </summary>
        /// <param name="input"></param>
        /// <param name="minvalue"></param>
        /// <param name="maxvalue"></param>
        /// <returns></returns>
        public static bool range(this int input,int minvalue,int maxvalue)
        {
            bool result = false;
            if (input>=minvalue && input<=maxvalue)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 验证Email格式
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool email(this string txt)
        {
            Regex regex = new Regex(@"^\w+([-+.]\w+)*@(\w+([-.]\w+)*\.)+([a-zA-Z]+)+$", RegexOptions.IgnoreCase);
            return regex.Match(txt).Success;
        }

        /// <summary>
        /// 验证是否URL格式
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool url(this string txt)
        {
            Regex regex = new Regex(@"(http://)?([\w-]+\.)*[\w-]+(/[\w- ./?%&=]*)?", RegexOptions.IgnoreCase);
            return regex.Match(txt).Success;
        }

        /// <summary>
        /// 验证日期合法性
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool date(this string txt)
        {
            //判断是否为空输入
            if (!String.IsNullOrEmpty(txt))
            {
                return false;
            }
            //正则表达式
            string strregex = @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$
";
            Regex regex = new Regex(strregex, RegexOptions.IgnoreCase);
            //返回验证结果
            return regex.Match(txt).Success;
        }

        /// <summary>
        /// 验证小数的合法性【判断是否是数字，包括小数和整数】
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool number(this string val)
        {
            return Regex.IsMatch(val, @"[0].d{1,2}|[1]"); 
        }

        /// <summary>
        /// 验证数字的合法性
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool digits(this string val)
        {
            return QuickValidate("^(0|([1-9]+[0-9]*))(.[0-9]+)?$", val);
        }

        /// <summary>
        /// 快速验证一个字符串是否符合指定的正则表达式。
        /// </summary>
        /// <param name="_express">正则表达式的内容。</param>
        /// <param name="_value">需验证的字符串。</param>
        /// <returns>是否合法的bool值。</returns>
        private static bool QuickValidate(string _express, string _value)
        {
            Regex myRegex = new Regex(_express);
            if (_value.Length == 0)
            {
                return false;
            }
            return myRegex.IsMatch(_value);
        }

        public static bool accept(this string txt)
        {
            throw new NotImplementedException();
        }

    }
}
