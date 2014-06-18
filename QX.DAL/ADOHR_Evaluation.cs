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
   /// 考评信息
   /// </summary>
   [Serializable]
   public partial class ADOHR_Evaluation
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加考评信息 HR_Evaluation对象(即:一条记录)
      /// </summary>
      public int Add(HR_Evaluation hR_Evaluation)
      {
         string sql = "INSERT INTO HR_Evaluation (Eva_Code,Eva_StuffCode,Eva_StuffName,Eva_Date,Eva_Records,Eva_Conclusion,Eva_Manager,Eva_Level,Eva_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Eva_Code,@Eva_StuffCode,@Eva_StuffName,@Eva_Date,@Eva_Records,@Eva_Conclusion,@Eva_Manager,@Eva_Level,@Eva_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Code))
         {
            idb.AddParameter("@Eva_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Code", hR_Evaluation.Eva_Code);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_StuffCode))
         {
            idb.AddParameter("@Eva_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_StuffCode", hR_Evaluation.Eva_StuffCode);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_StuffName))
         {
            idb.AddParameter("@Eva_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_StuffName", hR_Evaluation.Eva_StuffName);
         }
         if (hR_Evaluation.Eva_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Eva_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Date", hR_Evaluation.Eva_Date);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Records))
         {
            idb.AddParameter("@Eva_Records", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Records", hR_Evaluation.Eva_Records);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Conclusion))
         {
            idb.AddParameter("@Eva_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Conclusion", hR_Evaluation.Eva_Conclusion);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Manager))
         {
            idb.AddParameter("@Eva_Manager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Manager", hR_Evaluation.Eva_Manager);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Level))
         {
            idb.AddParameter("@Eva_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Level", hR_Evaluation.Eva_Level);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Bak))
         {
            idb.AddParameter("@Eva_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Bak", hR_Evaluation.Eva_Bak);
         }
         if (hR_Evaluation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Evaluation.Stat);
         }
         if (hR_Evaluation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Evaluation.CreateDate);
         }
         if (hR_Evaluation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Evaluation.UpdateDate);
         }
         if (hR_Evaluation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Evaluation.DeleteDate);
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
      /// 添加考评信息 HR_Evaluation对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_Evaluation hR_Evaluation)
      {
         string sql = "INSERT INTO HR_Evaluation (Eva_Code,Eva_StuffCode,Eva_StuffName,Eva_Date,Eva_Records,Eva_Conclusion,Eva_Manager,Eva_Level,Eva_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Eva_Code,@Eva_StuffCode,@Eva_StuffName,@Eva_Date,@Eva_Records,@Eva_Conclusion,@Eva_Manager,@Eva_Level,@Eva_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Code))
         {
            idb.AddParameter("@Eva_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Code", hR_Evaluation.Eva_Code);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_StuffCode))
         {
            idb.AddParameter("@Eva_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_StuffCode", hR_Evaluation.Eva_StuffCode);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_StuffName))
         {
            idb.AddParameter("@Eva_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_StuffName", hR_Evaluation.Eva_StuffName);
         }
         if (hR_Evaluation.Eva_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Eva_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Date", hR_Evaluation.Eva_Date);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Records))
         {
            idb.AddParameter("@Eva_Records", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Records", hR_Evaluation.Eva_Records);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Conclusion))
         {
            idb.AddParameter("@Eva_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Conclusion", hR_Evaluation.Eva_Conclusion);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Manager))
         {
            idb.AddParameter("@Eva_Manager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Manager", hR_Evaluation.Eva_Manager);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Level))
         {
            idb.AddParameter("@Eva_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Level", hR_Evaluation.Eva_Level);
         }
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Bak))
         {
            idb.AddParameter("@Eva_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Bak", hR_Evaluation.Eva_Bak);
         }
         if (hR_Evaluation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Evaluation.Stat);
         }
         if (hR_Evaluation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Evaluation.CreateDate);
         }
         if (hR_Evaluation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Evaluation.UpdateDate);
         }
         if (hR_Evaluation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Evaluation.DeleteDate);
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
      /// 更新考评信息 HR_Evaluation对象(即:一条记录
      /// </summary>
      public int Update(HR_Evaluation hR_Evaluation)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_Evaluation       SET ");
            if(hR_Evaluation.Eva_Code_IsChanged){sbParameter.Append("Eva_Code=@Eva_Code, ");}
      if(hR_Evaluation.Eva_StuffCode_IsChanged){sbParameter.Append("Eva_StuffCode=@Eva_StuffCode, ");}
      if(hR_Evaluation.Eva_StuffName_IsChanged){sbParameter.Append("Eva_StuffName=@Eva_StuffName, ");}
      if(hR_Evaluation.Eva_Date_IsChanged){sbParameter.Append("Eva_Date=@Eva_Date, ");}
      if(hR_Evaluation.Eva_Records_IsChanged){sbParameter.Append("Eva_Records=@Eva_Records, ");}
      if(hR_Evaluation.Eva_Conclusion_IsChanged){sbParameter.Append("Eva_Conclusion=@Eva_Conclusion, ");}
      if(hR_Evaluation.Eva_Manager_IsChanged){sbParameter.Append("Eva_Manager=@Eva_Manager, ");}
      if(hR_Evaluation.Eva_Level_IsChanged){sbParameter.Append("Eva_Level=@Eva_Level, ");}
      if(hR_Evaluation.Eva_Bak_IsChanged){sbParameter.Append("Eva_Bak=@Eva_Bak, ");}
      if(hR_Evaluation.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_Evaluation.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_Evaluation.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hR_Evaluation.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Eva_ID=@Eva_ID; " );
      string sql=sb.ToString();
         if(hR_Evaluation.Eva_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Code))
         {
            idb.AddParameter("@Eva_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Code", hR_Evaluation.Eva_Code);
         }
          }
         if(hR_Evaluation.Eva_StuffCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_StuffCode))
         {
            idb.AddParameter("@Eva_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_StuffCode", hR_Evaluation.Eva_StuffCode);
         }
          }
         if(hR_Evaluation.Eva_StuffName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_StuffName))
         {
            idb.AddParameter("@Eva_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_StuffName", hR_Evaluation.Eva_StuffName);
         }
          }
         if(hR_Evaluation.Eva_Date_IsChanged)
         {
         if (hR_Evaluation.Eva_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Eva_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Date", hR_Evaluation.Eva_Date);
         }
          }
         if(hR_Evaluation.Eva_Records_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Records))
         {
            idb.AddParameter("@Eva_Records", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Records", hR_Evaluation.Eva_Records);
         }
          }
         if(hR_Evaluation.Eva_Conclusion_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Conclusion))
         {
            idb.AddParameter("@Eva_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Conclusion", hR_Evaluation.Eva_Conclusion);
         }
          }
         if(hR_Evaluation.Eva_Manager_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Manager))
         {
            idb.AddParameter("@Eva_Manager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Manager", hR_Evaluation.Eva_Manager);
         }
          }
         if(hR_Evaluation.Eva_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Level))
         {
            idb.AddParameter("@Eva_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Level", hR_Evaluation.Eva_Level);
         }
          }
         if(hR_Evaluation.Eva_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Evaluation.Eva_Bak))
         {
            idb.AddParameter("@Eva_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Eva_Bak", hR_Evaluation.Eva_Bak);
         }
          }
         if(hR_Evaluation.Stat_IsChanged)
         {
         if (hR_Evaluation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Evaluation.Stat);
         }
          }
         if(hR_Evaluation.CreateDate_IsChanged)
         {
         if (hR_Evaluation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Evaluation.CreateDate);
         }
          }
         if(hR_Evaluation.UpdateDate_IsChanged)
         {
         if (hR_Evaluation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Evaluation.UpdateDate);
         }
          }
         if(hR_Evaluation.DeleteDate_IsChanged)
         {
         if (hR_Evaluation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Evaluation.DeleteDate);
         }
          }

         idb.AddParameter("@Eva_ID", hR_Evaluation.Eva_ID);

           
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
      /// 删除考评信息 HR_Evaluation对象(即:一条记录
      /// </summary>
      public int Delete(decimal eva_ID)
      {
         string sql = "DELETE HR_Evaluation WHERE 1=1  AND Eva_ID=@Eva_ID ";
         idb.AddParameter("@Eva_ID", eva_ID);

           
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
      /// 获取指定的考评信息 HR_Evaluation对象(即:一条记录
      /// </summary>
      public HR_Evaluation GetByKey(decimal eva_ID)
      {
         HR_Evaluation hR_Evaluation = new HR_Evaluation();
         string sql = "SELECT  Eva_ID,Eva_Code,Eva_StuffCode,Eva_StuffName,Eva_Date,Eva_Records,Eva_Conclusion,Eva_Manager,Eva_Level,Eva_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Evaluation WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Eva_ID=@Eva_ID ";
         idb.AddParameter("@Eva_ID", eva_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Eva_ID"] != DBNull.Value) hR_Evaluation.Eva_ID = Convert.ToDecimal(dr["Eva_ID"]);
            if (dr["Eva_Code"] != DBNull.Value) hR_Evaluation.Eva_Code = Convert.ToString(dr["Eva_Code"]);
            if (dr["Eva_StuffCode"] != DBNull.Value) hR_Evaluation.Eva_StuffCode = Convert.ToString(dr["Eva_StuffCode"]);
            if (dr["Eva_StuffName"] != DBNull.Value) hR_Evaluation.Eva_StuffName = Convert.ToString(dr["Eva_StuffName"]);
            if (dr["Eva_Date"] != DBNull.Value) hR_Evaluation.Eva_Date = Convert.ToDateTime(dr["Eva_Date"]);
            if (dr["Eva_Records"] != DBNull.Value) hR_Evaluation.Eva_Records = Convert.ToString(dr["Eva_Records"]);
            if (dr["Eva_Conclusion"] != DBNull.Value) hR_Evaluation.Eva_Conclusion = Convert.ToString(dr["Eva_Conclusion"]);
            if (dr["Eva_Manager"] != DBNull.Value) hR_Evaluation.Eva_Manager = Convert.ToString(dr["Eva_Manager"]);
            if (dr["Eva_Level"] != DBNull.Value) hR_Evaluation.Eva_Level = Convert.ToString(dr["Eva_Level"]);
            if (dr["Eva_Bak"] != DBNull.Value) hR_Evaluation.Eva_Bak = Convert.ToString(dr["Eva_Bak"]);
            if (dr["Stat"] != DBNull.Value) hR_Evaluation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Evaluation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Evaluation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Evaluation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_Evaluation;
      }
      /// <summary>
      /// 获取指定的考评信息 HR_Evaluation对象集合
      /// </summary>
      public List<HR_Evaluation> GetListByWhere(string strCondition)
      {
         List<HR_Evaluation> ret = new List<HR_Evaluation>();
         string sql = "SELECT  Eva_ID,Eva_Code,Eva_StuffCode,Eva_StuffName,Eva_Date,Eva_Records,Eva_Conclusion,Eva_Manager,Eva_Level,Eva_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Evaluation WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            HR_Evaluation hR_Evaluation = new HR_Evaluation();
            if (dr["Eva_ID"] != DBNull.Value) hR_Evaluation.Eva_ID = Convert.ToDecimal(dr["Eva_ID"]);
            if (dr["Eva_Code"] != DBNull.Value) hR_Evaluation.Eva_Code = Convert.ToString(dr["Eva_Code"]);
            if (dr["Eva_StuffCode"] != DBNull.Value) hR_Evaluation.Eva_StuffCode = Convert.ToString(dr["Eva_StuffCode"]);
            if (dr["Eva_StuffName"] != DBNull.Value) hR_Evaluation.Eva_StuffName = Convert.ToString(dr["Eva_StuffName"]);
            if (dr["Eva_Date"] != DBNull.Value) hR_Evaluation.Eva_Date = Convert.ToDateTime(dr["Eva_Date"]);
            if (dr["Eva_Records"] != DBNull.Value) hR_Evaluation.Eva_Records = Convert.ToString(dr["Eva_Records"]);
            if (dr["Eva_Conclusion"] != DBNull.Value) hR_Evaluation.Eva_Conclusion = Convert.ToString(dr["Eva_Conclusion"]);
            if (dr["Eva_Manager"] != DBNull.Value) hR_Evaluation.Eva_Manager = Convert.ToString(dr["Eva_Manager"]);
            if (dr["Eva_Level"] != DBNull.Value) hR_Evaluation.Eva_Level = Convert.ToString(dr["Eva_Level"]);
            if (dr["Eva_Bak"] != DBNull.Value) hR_Evaluation.Eva_Bak = Convert.ToString(dr["Eva_Bak"]);
            if (dr["Stat"] != DBNull.Value) hR_Evaluation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Evaluation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Evaluation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Evaluation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_Evaluation);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的考评信息 HR_Evaluation对象(即:一条记录
      /// </summary>
      public List<HR_Evaluation> GetAll()
      {
         List<HR_Evaluation> ret = new List<HR_Evaluation>();
         string sql = "SELECT  Eva_ID,Eva_Code,Eva_StuffCode,Eva_StuffName,Eva_Date,Eva_Records,Eva_Conclusion,Eva_Manager,Eva_Level,Eva_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Evaluation where 1=1 AND ((Stat is null) or (Stat=0) ) order by Eva_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_Evaluation hR_Evaluation = new HR_Evaluation();
            if (dr["Eva_ID"] != DBNull.Value) hR_Evaluation.Eva_ID = Convert.ToDecimal(dr["Eva_ID"]);
            if (dr["Eva_Code"] != DBNull.Value) hR_Evaluation.Eva_Code = Convert.ToString(dr["Eva_Code"]);
            if (dr["Eva_StuffCode"] != DBNull.Value) hR_Evaluation.Eva_StuffCode = Convert.ToString(dr["Eva_StuffCode"]);
            if (dr["Eva_StuffName"] != DBNull.Value) hR_Evaluation.Eva_StuffName = Convert.ToString(dr["Eva_StuffName"]);
            if (dr["Eva_Date"] != DBNull.Value) hR_Evaluation.Eva_Date = Convert.ToDateTime(dr["Eva_Date"]);
            if (dr["Eva_Records"] != DBNull.Value) hR_Evaluation.Eva_Records = Convert.ToString(dr["Eva_Records"]);
            if (dr["Eva_Conclusion"] != DBNull.Value) hR_Evaluation.Eva_Conclusion = Convert.ToString(dr["Eva_Conclusion"]);
            if (dr["Eva_Manager"] != DBNull.Value) hR_Evaluation.Eva_Manager = Convert.ToString(dr["Eva_Manager"]);
            if (dr["Eva_Level"] != DBNull.Value) hR_Evaluation.Eva_Level = Convert.ToString(dr["Eva_Level"]);
            if (dr["Eva_Bak"] != DBNull.Value) hR_Evaluation.Eva_Bak = Convert.ToString(dr["Eva_Bak"]);
            if (dr["Stat"] != DBNull.Value) hR_Evaluation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Evaluation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Evaluation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Evaluation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_Evaluation);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
