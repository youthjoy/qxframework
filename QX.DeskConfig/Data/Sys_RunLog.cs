using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DeskConfig.Model;
using System.Collections;

namespace QX.DeskConfig.DAL
{
    public static class SysRunLog
    {
        public static void InsertRunSql(string Sql, Hashtable Params, string Fun,string Error)
        {
            try 
	        {
                StringBuilder strPara=new StringBuilder();
		        ADOSys_RunLog instance=new ADOSys_RunLog();
                Sys_RunLog model=new Sys_RunLog();
                model.Log_Date=DateTime.Now;
                model.Log_Fun=Fun;
                model.Log_Error = Error;               
                foreach (DictionaryEntry item in Params)
                {
                    strPara.Append(item.Key + "=" + item.Value);
                }
                model.Log_SQLParameter = strPara.ToString();
              //  model.Log_Author = SessionConfig.UserId()+","+SessionConfig.UserName();
                model.Log_SQL = Sql;
                instance.Add(model);
	        }
	        catch (Exception)
	        {
        		
	        }

        }
    }
}
