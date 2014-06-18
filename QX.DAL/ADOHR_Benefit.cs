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
   /// 员工福利情况
   /// </summary>
   [Serializable]
   public partial class ADOHR_Benefit
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加员工福利情况 HR_Benefit对象(即:一条记录)
      /// </summary>
      public int Add(HR_Benefit hR_Benefit)
      {
         string sql = "INSERT INTO HR_Benefit (HRB_Code,HRB_EName,HRB_ECode,HRB_Key,HRB_Name,HRB_Sum,HRB_IsDone,HRB_Date,HRB_NextDate,HRB_Bak1,HRB_Bak2,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HRB_Code,@HRB_EName,@HRB_ECode,@HRB_Key,@HRB_Name,@HRB_Sum,@HRB_IsDone,@HRB_Date,@HRB_NextDate,@HRB_Bak1,@HRB_Bak2,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Code))
         {
            idb.AddParameter("@HRB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Code", hR_Benefit.HRB_Code);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_EName))
         {
            idb.AddParameter("@HRB_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_EName", hR_Benefit.HRB_EName);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_ECode))
         {
            idb.AddParameter("@HRB_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_ECode", hR_Benefit.HRB_ECode);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Key))
         {
            idb.AddParameter("@HRB_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Key", hR_Benefit.HRB_Key);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Name))
         {
            idb.AddParameter("@HRB_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Name", hR_Benefit.HRB_Name);
         }
         if (hR_Benefit.HRB_Sum == 0)
         {
            idb.AddParameter("@HRB_Sum", 0);
         }
         else
         {
            idb.AddParameter("@HRB_Sum", hR_Benefit.HRB_Sum);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_IsDone))
         {
            idb.AddParameter("@HRB_IsDone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_IsDone", hR_Benefit.HRB_IsDone);
         }
         if (hR_Benefit.HRB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Date", hR_Benefit.HRB_Date);
         }
         if (hR_Benefit.HRB_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRB_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_NextDate", hR_Benefit.HRB_NextDate);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Bak1))
         {
            idb.AddParameter("@HRB_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Bak1", hR_Benefit.HRB_Bak1);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Bak2))
         {
            idb.AddParameter("@HRB_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Bak2", hR_Benefit.HRB_Bak2);
         }
         if (hR_Benefit.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Benefit.Stat);
         }
         if (hR_Benefit.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Benefit.CreateDate);
         }
         if (hR_Benefit.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Benefit.UpdateDate);
         }
         if (hR_Benefit.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Benefit.DeleteDate);
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
      /// 添加员工福利情况 HR_Benefit对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_Benefit hR_Benefit)
      {
         string sql = "INSERT INTO HR_Benefit (HRB_Code,HRB_EName,HRB_ECode,HRB_Key,HRB_Name,HRB_Sum,HRB_IsDone,HRB_Date,HRB_NextDate,HRB_Bak1,HRB_Bak2,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HRB_Code,@HRB_EName,@HRB_ECode,@HRB_Key,@HRB_Name,@HRB_Sum,@HRB_IsDone,@HRB_Date,@HRB_NextDate,@HRB_Bak1,@HRB_Bak2,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Code))
         {
            idb.AddParameter("@HRB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Code", hR_Benefit.HRB_Code);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_EName))
         {
            idb.AddParameter("@HRB_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_EName", hR_Benefit.HRB_EName);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_ECode))
         {
            idb.AddParameter("@HRB_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_ECode", hR_Benefit.HRB_ECode);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Key))
         {
            idb.AddParameter("@HRB_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Key", hR_Benefit.HRB_Key);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Name))
         {
            idb.AddParameter("@HRB_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Name", hR_Benefit.HRB_Name);
         }
         if (hR_Benefit.HRB_Sum == 0)
         {
            idb.AddParameter("@HRB_Sum", 0);
         }
         else
         {
            idb.AddParameter("@HRB_Sum", hR_Benefit.HRB_Sum);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_IsDone))
         {
            idb.AddParameter("@HRB_IsDone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_IsDone", hR_Benefit.HRB_IsDone);
         }
         if (hR_Benefit.HRB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Date", hR_Benefit.HRB_Date);
         }
         if (hR_Benefit.HRB_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRB_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_NextDate", hR_Benefit.HRB_NextDate);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Bak1))
         {
            idb.AddParameter("@HRB_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Bak1", hR_Benefit.HRB_Bak1);
         }
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Bak2))
         {
            idb.AddParameter("@HRB_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Bak2", hR_Benefit.HRB_Bak2);
         }
         if (hR_Benefit.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Benefit.Stat);
         }
         if (hR_Benefit.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Benefit.CreateDate);
         }
         if (hR_Benefit.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Benefit.UpdateDate);
         }
         if (hR_Benefit.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Benefit.DeleteDate);
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
      /// 更新员工福利情况 HR_Benefit对象(即:一条记录
      /// </summary>
      public int Update(HR_Benefit hR_Benefit)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_Benefit       SET ");
            if(hR_Benefit.HRB_Code_IsChanged){sbParameter.Append("HRB_Code=@HRB_Code, ");}
      if(hR_Benefit.HRB_EName_IsChanged){sbParameter.Append("HRB_EName=@HRB_EName, ");}
      if(hR_Benefit.HRB_ECode_IsChanged){sbParameter.Append("HRB_ECode=@HRB_ECode, ");}
      if(hR_Benefit.HRB_Key_IsChanged){sbParameter.Append("HRB_Key=@HRB_Key, ");}
      if(hR_Benefit.HRB_Name_IsChanged){sbParameter.Append("HRB_Name=@HRB_Name, ");}
      if(hR_Benefit.HRB_Sum_IsChanged){sbParameter.Append("HRB_Sum=@HRB_Sum, ");}
      if(hR_Benefit.HRB_IsDone_IsChanged){sbParameter.Append("HRB_IsDone=@HRB_IsDone, ");}
      if(hR_Benefit.HRB_Date_IsChanged){sbParameter.Append("HRB_Date=@HRB_Date, ");}
      if(hR_Benefit.HRB_NextDate_IsChanged){sbParameter.Append("HRB_NextDate=@HRB_NextDate, ");}
      if(hR_Benefit.HRB_Bak1_IsChanged){sbParameter.Append("HRB_Bak1=@HRB_Bak1, ");}
      if(hR_Benefit.HRB_Bak2_IsChanged){sbParameter.Append("HRB_Bak2=@HRB_Bak2, ");}
      if(hR_Benefit.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_Benefit.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_Benefit.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hR_Benefit.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and HRB_ID=@HRB_ID; " );
      string sql=sb.ToString();
         if(hR_Benefit.HRB_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Code))
         {
            idb.AddParameter("@HRB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Code", hR_Benefit.HRB_Code);
         }
          }
         if(hR_Benefit.HRB_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_EName))
         {
            idb.AddParameter("@HRB_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_EName", hR_Benefit.HRB_EName);
         }
          }
         if(hR_Benefit.HRB_ECode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_ECode))
         {
            idb.AddParameter("@HRB_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_ECode", hR_Benefit.HRB_ECode);
         }
          }
         if(hR_Benefit.HRB_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Key))
         {
            idb.AddParameter("@HRB_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Key", hR_Benefit.HRB_Key);
         }
          }
         if(hR_Benefit.HRB_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Name))
         {
            idb.AddParameter("@HRB_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Name", hR_Benefit.HRB_Name);
         }
          }
         if(hR_Benefit.HRB_Sum_IsChanged)
         {
         if (hR_Benefit.HRB_Sum == 0)
         {
            idb.AddParameter("@HRB_Sum", 0);
         }
         else
         {
            idb.AddParameter("@HRB_Sum", hR_Benefit.HRB_Sum);
         }
          }
         if(hR_Benefit.HRB_IsDone_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_IsDone))
         {
            idb.AddParameter("@HRB_IsDone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_IsDone", hR_Benefit.HRB_IsDone);
         }
          }
         if(hR_Benefit.HRB_Date_IsChanged)
         {
         if (hR_Benefit.HRB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Date", hR_Benefit.HRB_Date);
         }
          }
         if(hR_Benefit.HRB_NextDate_IsChanged)
         {
         if (hR_Benefit.HRB_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRB_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_NextDate", hR_Benefit.HRB_NextDate);
         }
          }
         if(hR_Benefit.HRB_Bak1_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Bak1))
         {
            idb.AddParameter("@HRB_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Bak1", hR_Benefit.HRB_Bak1);
         }
          }
         if(hR_Benefit.HRB_Bak2_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Benefit.HRB_Bak2))
         {
            idb.AddParameter("@HRB_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRB_Bak2", hR_Benefit.HRB_Bak2);
         }
          }
         if(hR_Benefit.Stat_IsChanged)
         {
         if (hR_Benefit.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Benefit.Stat);
         }
          }
         if(hR_Benefit.CreateDate_IsChanged)
         {
         if (hR_Benefit.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Benefit.CreateDate);
         }
          }
         if(hR_Benefit.UpdateDate_IsChanged)
         {
         if (hR_Benefit.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Benefit.UpdateDate);
         }
          }
         if(hR_Benefit.DeleteDate_IsChanged)
         {
         if (hR_Benefit.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Benefit.DeleteDate);
         }
          }

         idb.AddParameter("@HRB_ID", hR_Benefit.HRB_ID);

           
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
      /// 删除员工福利情况 HR_Benefit对象(即:一条记录
      /// </summary>
      public int Delete(decimal hRB_ID)
      {
         string sql = "DELETE HR_Benefit WHERE 1=1  AND HRB_ID=@HRB_ID ";
         idb.AddParameter("@HRB_ID", hRB_ID);

           
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
      /// 获取指定的员工福利情况 HR_Benefit对象(即:一条记录
      /// </summary>
      public HR_Benefit GetByKey(decimal hRB_ID)
      {
         HR_Benefit hR_Benefit = new HR_Benefit();
         string sql = "SELECT  HRB_ID,HRB_Code,HRB_EName,HRB_ECode,HRB_Key,HRB_Name,HRB_Sum,HRB_IsDone,HRB_Date,HRB_NextDate,HRB_Bak1,HRB_Bak2,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Benefit WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND HRB_ID=@HRB_ID ";
         idb.AddParameter("@HRB_ID", hRB_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["HRB_ID"] != DBNull.Value) hR_Benefit.HRB_ID = Convert.ToDecimal(dr["HRB_ID"]);
            if (dr["HRB_Code"] != DBNull.Value) hR_Benefit.HRB_Code = Convert.ToString(dr["HRB_Code"]);
            if (dr["HRB_EName"] != DBNull.Value) hR_Benefit.HRB_EName = Convert.ToString(dr["HRB_EName"]);
            if (dr["HRB_ECode"] != DBNull.Value) hR_Benefit.HRB_ECode = Convert.ToString(dr["HRB_ECode"]);
            if (dr["HRB_Key"] != DBNull.Value) hR_Benefit.HRB_Key = Convert.ToString(dr["HRB_Key"]);
            if (dr["HRB_Name"] != DBNull.Value) hR_Benefit.HRB_Name = Convert.ToString(dr["HRB_Name"]);
            if (dr["HRB_Sum"] != DBNull.Value) hR_Benefit.HRB_Sum = Convert.ToDouble(dr["HRB_Sum"]);
            if (dr["HRB_IsDone"] != DBNull.Value) hR_Benefit.HRB_IsDone = Convert.ToString(dr["HRB_IsDone"]);
            if (dr["HRB_Date"] != DBNull.Value) hR_Benefit.HRB_Date = Convert.ToDateTime(dr["HRB_Date"]);
            if (dr["HRB_NextDate"] != DBNull.Value) hR_Benefit.HRB_NextDate = Convert.ToDateTime(dr["HRB_NextDate"]);
            if (dr["HRB_Bak1"] != DBNull.Value) hR_Benefit.HRB_Bak1 = Convert.ToString(dr["HRB_Bak1"]);
            if (dr["HRB_Bak2"] != DBNull.Value) hR_Benefit.HRB_Bak2 = Convert.ToString(dr["HRB_Bak2"]);
            if (dr["Stat"] != DBNull.Value) hR_Benefit.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Benefit.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Benefit.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Benefit.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_Benefit;
      }
      /// <summary>
      /// 获取指定的员工福利情况 HR_Benefit对象集合
      /// </summary>
      public List<HR_Benefit> GetListByWhere(string strCondition)
      {
         List<HR_Benefit> ret = new List<HR_Benefit>();
         string sql = "SELECT  HRB_ID,HRB_Code,HRB_EName,HRB_ECode,HRB_Key,HRB_Name,HRB_Sum,HRB_IsDone,HRB_Date,HRB_NextDate,HRB_Bak1,HRB_Bak2,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Benefit WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            HR_Benefit hR_Benefit = new HR_Benefit();
            if (dr["HRB_ID"] != DBNull.Value) hR_Benefit.HRB_ID = Convert.ToDecimal(dr["HRB_ID"]);
            if (dr["HRB_Code"] != DBNull.Value) hR_Benefit.HRB_Code = Convert.ToString(dr["HRB_Code"]);
            if (dr["HRB_EName"] != DBNull.Value) hR_Benefit.HRB_EName = Convert.ToString(dr["HRB_EName"]);
            if (dr["HRB_ECode"] != DBNull.Value) hR_Benefit.HRB_ECode = Convert.ToString(dr["HRB_ECode"]);
            if (dr["HRB_Key"] != DBNull.Value) hR_Benefit.HRB_Key = Convert.ToString(dr["HRB_Key"]);
            if (dr["HRB_Name"] != DBNull.Value) hR_Benefit.HRB_Name = Convert.ToString(dr["HRB_Name"]);
            if (dr["HRB_Sum"] != DBNull.Value) hR_Benefit.HRB_Sum = Convert.ToDouble(dr["HRB_Sum"]);
            if (dr["HRB_IsDone"] != DBNull.Value) hR_Benefit.HRB_IsDone = Convert.ToString(dr["HRB_IsDone"]);
            if (dr["HRB_Date"] != DBNull.Value) hR_Benefit.HRB_Date = Convert.ToDateTime(dr["HRB_Date"]);
            if (dr["HRB_NextDate"] != DBNull.Value) hR_Benefit.HRB_NextDate = Convert.ToDateTime(dr["HRB_NextDate"]);
            if (dr["HRB_Bak1"] != DBNull.Value) hR_Benefit.HRB_Bak1 = Convert.ToString(dr["HRB_Bak1"]);
            if (dr["HRB_Bak2"] != DBNull.Value) hR_Benefit.HRB_Bak2 = Convert.ToString(dr["HRB_Bak2"]);
            if (dr["Stat"] != DBNull.Value) hR_Benefit.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Benefit.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Benefit.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Benefit.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_Benefit);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的员工福利情况 HR_Benefit对象(即:一条记录
      /// </summary>
      public List<HR_Benefit> GetAll()
      {
         List<HR_Benefit> ret = new List<HR_Benefit>();
         string sql = "SELECT  HRB_ID,HRB_Code,HRB_EName,HRB_ECode,HRB_Key,HRB_Name,HRB_Sum,HRB_IsDone,HRB_Date,HRB_NextDate,HRB_Bak1,HRB_Bak2,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_Benefit where 1=1 AND ((Stat is null) or (Stat=0) ) order by HRB_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_Benefit hR_Benefit = new HR_Benefit();
            if (dr["HRB_ID"] != DBNull.Value) hR_Benefit.HRB_ID = Convert.ToDecimal(dr["HRB_ID"]);
            if (dr["HRB_Code"] != DBNull.Value) hR_Benefit.HRB_Code = Convert.ToString(dr["HRB_Code"]);
            if (dr["HRB_EName"] != DBNull.Value) hR_Benefit.HRB_EName = Convert.ToString(dr["HRB_EName"]);
            if (dr["HRB_ECode"] != DBNull.Value) hR_Benefit.HRB_ECode = Convert.ToString(dr["HRB_ECode"]);
            if (dr["HRB_Key"] != DBNull.Value) hR_Benefit.HRB_Key = Convert.ToString(dr["HRB_Key"]);
            if (dr["HRB_Name"] != DBNull.Value) hR_Benefit.HRB_Name = Convert.ToString(dr["HRB_Name"]);
            if (dr["HRB_Sum"] != DBNull.Value) hR_Benefit.HRB_Sum = Convert.ToDouble(dr["HRB_Sum"]);
            if (dr["HRB_IsDone"] != DBNull.Value) hR_Benefit.HRB_IsDone = Convert.ToString(dr["HRB_IsDone"]);
            if (dr["HRB_Date"] != DBNull.Value) hR_Benefit.HRB_Date = Convert.ToDateTime(dr["HRB_Date"]);
            if (dr["HRB_NextDate"] != DBNull.Value) hR_Benefit.HRB_NextDate = Convert.ToDateTime(dr["HRB_NextDate"]);
            if (dr["HRB_Bak1"] != DBNull.Value) hR_Benefit.HRB_Bak1 = Convert.ToString(dr["HRB_Bak1"]);
            if (dr["HRB_Bak2"] != DBNull.Value) hR_Benefit.HRB_Bak2 = Convert.ToString(dr["HRB_Bak2"]);
            if (dr["Stat"] != DBNull.Value) hR_Benefit.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Benefit.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Benefit.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Benefit.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_Benefit);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
