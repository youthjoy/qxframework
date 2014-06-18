using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   /// <summary>
   /// 个人经历
   /// </summary>
   [Serializable]
   public partial class ADOHR_Experience
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加个人经历 HR_Experience对象(即:一条记录)
      /// </summary>
      public int Add(HR_Experience hR_Experience)
      {
         string sql = "INSERT INTO HR_Experience (EX_Code,EX_StuffCode,EX_StuffName,EX_Type,EX_Corrp,EX_Title,EX_Intro,EX_Bak,EX_Start,EX_End,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@EX_Code,@EX_StuffCode,@EX_StuffName,@EX_Type,@EX_Corrp,@EX_Title,@EX_Intro,@EX_Bak,@EX_Start,@EX_End,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(hR_Experience.EX_Code))
         {
            idb.AddParameter("@EX_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Code", hR_Experience.EX_Code);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_StuffCode))
         {
            idb.AddParameter("@EX_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_StuffCode", hR_Experience.EX_StuffCode);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_StuffName))
         {
            idb.AddParameter("@EX_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_StuffName", hR_Experience.EX_StuffName);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Type))
         {
            idb.AddParameter("@EX_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Type", hR_Experience.EX_Type);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Corrp))
         {
            idb.AddParameter("@EX_Corrp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Corrp", hR_Experience.EX_Corrp);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Title))
         {
            idb.AddParameter("@EX_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Title", hR_Experience.EX_Title);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Intro))
         {
            idb.AddParameter("@EX_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Intro", hR_Experience.EX_Intro);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Bak))
         {
            idb.AddParameter("@EX_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Bak", hR_Experience.EX_Bak);
         }
         if (hR_Experience.EX_Start == DateTime.MinValue)
         {
            idb.AddParameter("@EX_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Start", hR_Experience.EX_Start);
         }
         if (hR_Experience.EX_End == DateTime.MinValue)
         {
            idb.AddParameter("@EX_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_End", hR_Experience.EX_End);
         }
         if (hR_Experience.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Experience.Stat);
         }
         if (hR_Experience.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Experience.CreateDate);
         }
         if (hR_Experience.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Experience.UpdateDate);
         }
         if (hR_Experience.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Experience.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
         
      }
      /// <summary>
      /// 添加个人经历 HR_Experience对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_Experience hR_Experience)
      {
         string sql = "INSERT INTO HR_Experience (EX_Code,EX_StuffCode,EX_StuffName,EX_Type,EX_Corrp,EX_Title,EX_Intro,EX_Bak,EX_Start,EX_End,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@EX_Code,@EX_StuffCode,@EX_StuffName,@EX_Type,@EX_Corrp,@EX_Title,@EX_Intro,@EX_Bak,@EX_Start,@EX_End,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_Experience.EX_Code))
         {
            idb.AddParameter("@EX_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Code", hR_Experience.EX_Code);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_StuffCode))
         {
            idb.AddParameter("@EX_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_StuffCode", hR_Experience.EX_StuffCode);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_StuffName))
         {
            idb.AddParameter("@EX_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_StuffName", hR_Experience.EX_StuffName);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Type))
         {
            idb.AddParameter("@EX_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Type", hR_Experience.EX_Type);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Corrp))
         {
            idb.AddParameter("@EX_Corrp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Corrp", hR_Experience.EX_Corrp);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Title))
         {
            idb.AddParameter("@EX_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Title", hR_Experience.EX_Title);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Intro))
         {
            idb.AddParameter("@EX_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Intro", hR_Experience.EX_Intro);
         }
         if (string.IsNullOrEmpty(hR_Experience.EX_Bak))
         {
            idb.AddParameter("@EX_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Bak", hR_Experience.EX_Bak);
         }
         if (hR_Experience.EX_Start == DateTime.MinValue)
         {
            idb.AddParameter("@EX_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Start", hR_Experience.EX_Start);
         }
         if (hR_Experience.EX_End == DateTime.MinValue)
         {
            idb.AddParameter("@EX_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_End", hR_Experience.EX_End);
         }
         if (hR_Experience.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Experience.Stat);
         }
         if (hR_Experience.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Experience.CreateDate);
         }
         if (hR_Experience.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Experience.UpdateDate);
         }
         if (hR_Experience.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Experience.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 var Return = idb.ReturnValue(sql);
                 Ex = Return.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 更新个人经历 HR_Experience对象(即:一条记录
      /// </summary>
      public int Update(HR_Experience hR_Experience)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_Experience       SET ");
            if(hR_Experience.EX_Code_IsChanged){sbParameter.Append("EX_Code=@EX_Code, ");}
      if(hR_Experience.EX_StuffCode_IsChanged){sbParameter.Append("EX_StuffCode=@EX_StuffCode, ");}
      if(hR_Experience.EX_StuffName_IsChanged){sbParameter.Append("EX_StuffName=@EX_StuffName, ");}
      if(hR_Experience.EX_Type_IsChanged){sbParameter.Append("EX_Type=@EX_Type, ");}
      if(hR_Experience.EX_Corrp_IsChanged){sbParameter.Append("EX_Corrp=@EX_Corrp, ");}
      if(hR_Experience.EX_Title_IsChanged){sbParameter.Append("EX_Title=@EX_Title, ");}
      if(hR_Experience.EX_Intro_IsChanged){sbParameter.Append("EX_Intro=@EX_Intro, ");}
      if(hR_Experience.EX_Bak_IsChanged){sbParameter.Append("EX_Bak=@EX_Bak, ");}
      if(hR_Experience.EX_Start_IsChanged){sbParameter.Append("EX_Start=@EX_Start, ");}
      if(hR_Experience.EX_End_IsChanged){sbParameter.Append("EX_End=@EX_End, ");}
      if(hR_Experience.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_Experience.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_Experience.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hR_Experience.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EX_ID=@EX_ID; " );
      string sql=sb.ToString();
         if(hR_Experience.EX_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_Code))
         {
            idb.AddParameter("@EX_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Code", hR_Experience.EX_Code);
         }
          }
         if(hR_Experience.EX_StuffCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_StuffCode))
         {
            idb.AddParameter("@EX_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_StuffCode", hR_Experience.EX_StuffCode);
         }
          }
         if(hR_Experience.EX_StuffName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_StuffName))
         {
            idb.AddParameter("@EX_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_StuffName", hR_Experience.EX_StuffName);
         }
          }
         if(hR_Experience.EX_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_Type))
         {
            idb.AddParameter("@EX_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Type", hR_Experience.EX_Type);
         }
          }
         if(hR_Experience.EX_Corrp_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_Corrp))
         {
            idb.AddParameter("@EX_Corrp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Corrp", hR_Experience.EX_Corrp);
         }
          }
         if(hR_Experience.EX_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_Title))
         {
            idb.AddParameter("@EX_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Title", hR_Experience.EX_Title);
         }
          }
         if(hR_Experience.EX_Intro_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_Intro))
         {
            idb.AddParameter("@EX_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Intro", hR_Experience.EX_Intro);
         }
          }
         if(hR_Experience.EX_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Experience.EX_Bak))
         {
            idb.AddParameter("@EX_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Bak", hR_Experience.EX_Bak);
         }
          }
         if(hR_Experience.EX_Start_IsChanged)
         {
         if (hR_Experience.EX_Start == DateTime.MinValue)
         {
            idb.AddParameter("@EX_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_Start", hR_Experience.EX_Start);
         }
          }
         if(hR_Experience.EX_End_IsChanged)
         {
         if (hR_Experience.EX_End == DateTime.MinValue)
         {
            idb.AddParameter("@EX_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EX_End", hR_Experience.EX_End);
         }
          }
         if(hR_Experience.Stat_IsChanged)
         {
         if (hR_Experience.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Experience.Stat);
         }
          }
         if(hR_Experience.CreateDate_IsChanged)
         {
         if (hR_Experience.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Experience.CreateDate);
         }
          }
         if(hR_Experience.UpdateDate_IsChanged)
         {
         if (hR_Experience.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Experience.UpdateDate);
         }
          }
         if(hR_Experience.DeleteDate_IsChanged)
         {
         if (hR_Experience.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Experience.DeleteDate);
         }
          }

         idb.AddParameter("@EX_ID", hR_Experience.EX_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 删除个人经历 HR_Experience对象(即:一条记录
      /// </summary>
      public int Delete(decimal eX_ID)
      {
         string sql = "DELETE HR_Experience WHERE 1=1  AND EX_ID=@EX_ID ";
         idb.AddParameter("@EX_ID", eX_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 获取指定的个人经历 HR_Experience对象(即:一条记录
      /// </summary>
      public HR_Experience GetByKey(decimal eX_ID)
      {
         HR_Experience hR_Experience = new HR_Experience();
         string sql = "SELECT  EX_ID,EX_Code,EX_StuffCode,EX_StuffName,EX_Type,EX_Corrp,EX_Title,EX_Intro,EX_Bak,EX_Start,EX_End,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Experience WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EX_ID=@EX_ID ";
         idb.AddParameter("@EX_ID", eX_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EX_ID"] != DBNull.Value) hR_Experience.EX_ID = Convert.ToDecimal(dr["EX_ID"]);
            if (dr["EX_Code"] != DBNull.Value) hR_Experience.EX_Code = Convert.ToString(dr["EX_Code"]);
            if (dr["EX_StuffCode"] != DBNull.Value) hR_Experience.EX_StuffCode = Convert.ToString(dr["EX_StuffCode"]);
            if (dr["EX_StuffName"] != DBNull.Value) hR_Experience.EX_StuffName = Convert.ToString(dr["EX_StuffName"]);
            if (dr["EX_Type"] != DBNull.Value) hR_Experience.EX_Type = Convert.ToString(dr["EX_Type"]);
            if (dr["EX_Corrp"] != DBNull.Value) hR_Experience.EX_Corrp = Convert.ToString(dr["EX_Corrp"]);
            if (dr["EX_Title"] != DBNull.Value) hR_Experience.EX_Title = Convert.ToString(dr["EX_Title"]);
            if (dr["EX_Intro"] != DBNull.Value) hR_Experience.EX_Intro = Convert.ToString(dr["EX_Intro"]);
            if (dr["EX_Bak"] != DBNull.Value) hR_Experience.EX_Bak = Convert.ToString(dr["EX_Bak"]);
            if (dr["EX_Start"] != DBNull.Value) hR_Experience.EX_Start = Convert.ToDateTime(dr["EX_Start"]);
            if (dr["EX_End"] != DBNull.Value) hR_Experience.EX_End = Convert.ToDateTime(dr["EX_End"]);
            if (dr["Stat"] != DBNull.Value) hR_Experience.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Experience.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Experience.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Experience.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_Experience;
      }
      /// <summary>
      /// 获取指定的个人经历 HR_Experience对象集合
      /// </summary>
      public List<HR_Experience> GetListByWhere(string strCondition)
      {
         List<HR_Experience> ret = new List<HR_Experience>();
         string sql = "SELECT  EX_ID,EX_Code,EX_StuffCode,EX_StuffName,EX_Type,EX_Corrp,EX_Title,EX_Intro,EX_Bak,EX_Start,EX_End,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Experience WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_Experience hR_Experience = new HR_Experience();
            if (dr["EX_ID"] != DBNull.Value) hR_Experience.EX_ID = Convert.ToDecimal(dr["EX_ID"]);
            if (dr["EX_Code"] != DBNull.Value) hR_Experience.EX_Code = Convert.ToString(dr["EX_Code"]);
            if (dr["EX_StuffCode"] != DBNull.Value) hR_Experience.EX_StuffCode = Convert.ToString(dr["EX_StuffCode"]);
            if (dr["EX_StuffName"] != DBNull.Value) hR_Experience.EX_StuffName = Convert.ToString(dr["EX_StuffName"]);
            if (dr["EX_Type"] != DBNull.Value) hR_Experience.EX_Type = Convert.ToString(dr["EX_Type"]);
            if (dr["EX_Corrp"] != DBNull.Value) hR_Experience.EX_Corrp = Convert.ToString(dr["EX_Corrp"]);
            if (dr["EX_Title"] != DBNull.Value) hR_Experience.EX_Title = Convert.ToString(dr["EX_Title"]);
            if (dr["EX_Intro"] != DBNull.Value) hR_Experience.EX_Intro = Convert.ToString(dr["EX_Intro"]);
            if (dr["EX_Bak"] != DBNull.Value) hR_Experience.EX_Bak = Convert.ToString(dr["EX_Bak"]);
            if (dr["EX_Start"] != DBNull.Value) hR_Experience.EX_Start = Convert.ToDateTime(dr["EX_Start"]);
            if (dr["EX_End"] != DBNull.Value) hR_Experience.EX_End = Convert.ToDateTime(dr["EX_End"]);
            if (dr["Stat"] != DBNull.Value) hR_Experience.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Experience.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Experience.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Experience.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_Experience);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的个人经历 HR_Experience对象(即:一条记录
      /// </summary>
      public List<HR_Experience> GetAll()
      {
         List<HR_Experience> ret = new List<HR_Experience>();
         string sql = "SELECT  EX_ID,EX_Code,EX_StuffCode,EX_StuffName,EX_Type,EX_Corrp,EX_Title,EX_Intro,EX_Bak,EX_Start,EX_End,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Experience where 1=1 AND ((Stat is null) or (Stat=0) ) order by EX_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_Experience hR_Experience = new HR_Experience();
            if (dr["EX_ID"] != DBNull.Value) hR_Experience.EX_ID = Convert.ToDecimal(dr["EX_ID"]);
            if (dr["EX_Code"] != DBNull.Value) hR_Experience.EX_Code = Convert.ToString(dr["EX_Code"]);
            if (dr["EX_StuffCode"] != DBNull.Value) hR_Experience.EX_StuffCode = Convert.ToString(dr["EX_StuffCode"]);
            if (dr["EX_StuffName"] != DBNull.Value) hR_Experience.EX_StuffName = Convert.ToString(dr["EX_StuffName"]);
            if (dr["EX_Type"] != DBNull.Value) hR_Experience.EX_Type = Convert.ToString(dr["EX_Type"]);
            if (dr["EX_Corrp"] != DBNull.Value) hR_Experience.EX_Corrp = Convert.ToString(dr["EX_Corrp"]);
            if (dr["EX_Title"] != DBNull.Value) hR_Experience.EX_Title = Convert.ToString(dr["EX_Title"]);
            if (dr["EX_Intro"] != DBNull.Value) hR_Experience.EX_Intro = Convert.ToString(dr["EX_Intro"]);
            if (dr["EX_Bak"] != DBNull.Value) hR_Experience.EX_Bak = Convert.ToString(dr["EX_Bak"]);
            if (dr["EX_Start"] != DBNull.Value) hR_Experience.EX_Start = Convert.ToDateTime(dr["EX_Start"]);
            if (dr["EX_End"] != DBNull.Value) hR_Experience.EX_End = Convert.ToDateTime(dr["EX_End"]);
            if (dr["Stat"] != DBNull.Value) hR_Experience.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Experience.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Experience.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Experience.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_Experience);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
