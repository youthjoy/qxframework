using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace QX.Comm
{
    public class StringHelper
    {
        public static string CONRESULT_OK = "OK";
        public static string CONRESULT_CANCEL = "CANCEL";

        /// <summary>
        /// 将金额转化为大写繁体金额， 目前输入的是以万元为单位的
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public static string ChangeToChineseMoney(double money)
        {
            string cm = "";
            string[] temp = money.ToString().Split('.');
            if (temp[0] != "0")
            {
                cm += ConvertToChinese(temp[0].Trim()) + "万";
            }
            if (temp.Length <= 1 || Convert.ToInt32(temp[1].Trim()) == 0)
            {
                return cm;
            }
            int len = temp[1].Trim().Length;
            if (len > 5)
            {
                temp[1] = temp[1].Substring(0, 5);
            }
            if (temp[1].StartsWith("0"))
            {
                cm += "零";
            }
            int yy = Convert.ToInt32(temp[1].Trim());
            for (int i = 0; i < 4 - len; i++)
            {
                yy *= 10;
            }
            cm += ConvertToChinese(yy.ToString());
            char[] c = { '零' };
            cm = cm.TrimStart(c);
            return cm;
        }

        private static string ConvertToChinese(string temp)
        {
            string cm = "";
            int[] y = { 1, 10, 100, 1000, 10000 };
            string[] s = { "", "拾", "佰", "仟", "万" };
            int i = 0;
            int j = Convert.ToInt32(temp);
            while (i < 5 && (j / y[i]) >= 1)
            {
                int yy = j / y[i];
                string t = yy.ToString();
                int m = Convert.ToInt32(t.Substring(t.Length - 1, 1));
                string mm = NumberToMoney(m);
                if (mm == "")
                {
                    i++;
                    continue;
                }
                if (mm == "零")
                {
                    if (cm != "" && cm.Substring(0, 1) != "零")
                    {
                        cm = mm + cm;
                    }
                    i++;
                    continue;
                }
                cm = mm + s[i] + cm;
                i++;
            }
            return cm;
        }

        private static string NumberToMoney(int i)
        {
            switch (i)
            {
                case 0:
                    return "零";
                case 1:
                    return "壹";
                case 2:
                    return "贰";
                case 3:
                    return "叁";
                case 4:
                    return "肆";
                case 5:
                    return "伍";
                case 6:
                    return "陆";
                case 7:
                    return "柒";
                case 8:
                    return "捌";
                case 9:
                    return "玖";
                default:
                    return "";
            }
        }

        public static Dictionary<string, string> FormParse(string Keys)
        {
            Dictionary<string, string> KeyPaire = new Dictionary<string, string>();
            string[] Key = Keys.Split('&');
            for (var i = 0; i < Key.Length; i++)
            {
                string[] val = Key[i].Split('=');
                if (!KeyPaire.ContainsKey(val[0]))
                {
                    KeyPaire.Add(val[0], val[1]);
                }
            }
            return KeyPaire;
        }

        public static Dictionary<string, string> FormParse(FormCollection data)
        {
            Dictionary<string, string> KeyPaire = new Dictionary<string, string>();
            foreach (var item in data.AllKeys)
            {
                KeyPaire.Add(item, data[item]);
            }
            return KeyPaire;
        }
    }
}
