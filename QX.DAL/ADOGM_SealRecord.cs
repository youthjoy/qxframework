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
   /// 印章使用记录
   /// </summary>
   [Serializable]
   public partial class ADOGM_SealRecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加印章使用记录 GM_SealRecord对象(即:一条记录)
      /// </summary>
      public int Add(GM_SealRecord gM_SealRecord)
      {
         string sql = "INSERT INTO GM_SealRecord (GMSR_Code,GMSR_SCode,GMSR_SName,GMSR_Date,GMSR_Function,GMSR_Copy,GMSR_Employee,GMSR_Approve,GMSR_RDate,GMSR_UCat,GMSR_Company,GMSR_Dept,GMSR_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@GMSR_Code,@GMSR_SCode,@GMSR_SName,@GMSR_Date,@GMSR_Function,@GMSR_Copy,@GMSR_Employee,@GMSR_Approve,@GMSR_RDate,@GMSR_UCat,@GMSR_Company,@GMSR_Dept,@GMSR_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Code))
         {
            idb.AddParameter("@GMSR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Code", gM_SealRecord.GMSR_Code);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_SCode))
         {
            idb.AddParameter("@GMSR_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_SCode", gM_SealRecord.GMSR_SCode);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_SName))
         {
            idb.AddParameter("@GMSR_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_SName", gM_SealRecord.GMSR_SName);
         }
         if (gM_SealRecord.GMSR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@GMSR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Date", gM_SealRecord.GMSR_Date);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Function))
         {
            idb.AddParameter("@GMSR_Function", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Function", gM_SealRecord.GMSR_Function);
         }
         if (gM_SealRecord.GMSR_Copy == 0)
         {
            idb.AddParameter("@GMSR_Copy", 0);
         }
         else
         {
            idb.AddParameter("@GMSR_Copy", gM_SealRecord.GMSR_Copy);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Employee))
         {
            idb.AddParameter("@GMSR_Employee", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Employee", gM_SealRecord.GMSR_Employee);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Approve))
         {
            idb.AddParameter("@GMSR_Approve", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Approve", gM_SealRecord.GMSR_Approve);
         }
         if (gM_SealRecord.GMSR_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@GMSR_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_RDate", gM_SealRecord.GMSR_RDate);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_UCat))
         {
            idb.AddParameter("@GMSR_UCat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_UCat", gM_SealRecord.GMSR_UCat);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Company))
         {
            idb.AddParameter("@GMSR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Company", gM_SealRecord.GMSR_Company);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Dept))
         {
            idb.AddParameter("@GMSR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Dept", gM_SealRecord.GMSR_Dept);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Bak))
         {
            idb.AddParameter("@GMSR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Bak", gM_SealRecord.GMSR_Bak);
         }
         if (gM_SealRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gM_SealRecord.Stat);
         }
         if (gM_SealRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", gM_SealRecord.CreateDate);
         }
         if (gM_SealRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", gM_SealRecord.UpdateDate);
         }
         if (gM_SealRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", gM_SealRecord.DeleteDate);
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
      /// 添加印章使用记录 GM_SealRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(GM_SealRecord gM_SealRecord)
      {
         string sql = "INSERT INTO GM_SealRecord (GMSR_Code,GMSR_SCode,GMSR_SName,GMSR_Date,GMSR_Function,GMSR_Copy,GMSR_Employee,GMSR_Approve,GMSR_RDate,GMSR_UCat,GMSR_Company,GMSR_Dept,GMSR_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@GMSR_Code,@GMSR_SCode,@GMSR_SName,@GMSR_Date,@GMSR_Function,@GMSR_Copy,@GMSR_Employee,@GMSR_Approve,@GMSR_RDate,@GMSR_UCat,@GMSR_Company,@GMSR_Dept,@GMSR_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Code))
         {
            idb.AddParameter("@GMSR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Code", gM_SealRecord.GMSR_Code);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_SCode))
         {
            idb.AddParameter("@GMSR_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_SCode", gM_SealRecord.GMSR_SCode);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_SName))
         {
            idb.AddParameter("@GMSR_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_SName", gM_SealRecord.GMSR_SName);
         }
         if (gM_SealRecord.GMSR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@GMSR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Date", gM_SealRecord.GMSR_Date);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Function))
         {
            idb.AddParameter("@GMSR_Function", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Function", gM_SealRecord.GMSR_Function);
         }
         if (gM_SealRecord.GMSR_Copy == 0)
         {
            idb.AddParameter("@GMSR_Copy", 0);
         }
         else
         {
            idb.AddParameter("@GMSR_Copy", gM_SealRecord.GMSR_Copy);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Employee))
         {
            idb.AddParameter("@GMSR_Employee", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Employee", gM_SealRecord.GMSR_Employee);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Approve))
         {
            idb.AddParameter("@GMSR_Approve", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Approve", gM_SealRecord.GMSR_Approve);
         }
         if (gM_SealRecord.GMSR_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@GMSR_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_RDate", gM_SealRecord.GMSR_RDate);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_UCat))
         {
            idb.AddParameter("@GMSR_UCat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_UCat", gM_SealRecord.GMSR_UCat);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Company))
         {
            idb.AddParameter("@GMSR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Company", gM_SealRecord.GMSR_Company);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Dept))
         {
            idb.AddParameter("@GMSR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Dept", gM_SealRecord.GMSR_Dept);
         }
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Bak))
         {
            idb.AddParameter("@GMSR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Bak", gM_SealRecord.GMSR_Bak);
         }
         if (gM_SealRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gM_SealRecord.Stat);
         }
         if (gM_SealRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", gM_SealRecord.CreateDate);
         }
         if (gM_SealRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", gM_SealRecord.UpdateDate);
         }
         if (gM_SealRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", gM_SealRecord.DeleteDate);
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
      /// 更新印章使用记录 GM_SealRecord对象(即:一条记录
      /// </summary>
      public int Update(GM_SealRecord gM_SealRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       GM_SealRecord       SET ");
            if(gM_SealRecord.GMSR_Code_IsChanged){sbParameter.Append("GMSR_Code=@GMSR_Code, ");}
      if(gM_SealRecord.GMSR_SCode_IsChanged){sbParameter.Append("GMSR_SCode=@GMSR_SCode, ");}
      if(gM_SealRecord.GMSR_SName_IsChanged){sbParameter.Append("GMSR_SName=@GMSR_SName, ");}
      if(gM_SealRecord.GMSR_Date_IsChanged){sbParameter.Append("GMSR_Date=@GMSR_Date, ");}
      if(gM_SealRecord.GMSR_Function_IsChanged){sbParameter.Append("GMSR_Function=@GMSR_Function, ");}
      if(gM_SealRecord.GMSR_Copy_IsChanged){sbParameter.Append("GMSR_Copy=@GMSR_Copy, ");}
      if(gM_SealRecord.GMSR_Employee_IsChanged){sbParameter.Append("GMSR_Employee=@GMSR_Employee, ");}
      if(gM_SealRecord.GMSR_Approve_IsChanged){sbParameter.Append("GMSR_Approve=@GMSR_Approve, ");}
      if(gM_SealRecord.GMSR_RDate_IsChanged){sbParameter.Append("GMSR_RDate=@GMSR_RDate, ");}
      if(gM_SealRecord.GMSR_UCat_IsChanged){sbParameter.Append("GMSR_UCat=@GMSR_UCat, ");}
      if(gM_SealRecord.GMSR_Company_IsChanged){sbParameter.Append("GMSR_Company=@GMSR_Company, ");}
      if(gM_SealRecord.GMSR_Dept_IsChanged){sbParameter.Append("GMSR_Dept=@GMSR_Dept, ");}
      if(gM_SealRecord.GMSR_Bak_IsChanged){sbParameter.Append("GMSR_Bak=@GMSR_Bak, ");}
      if(gM_SealRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(gM_SealRecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(gM_SealRecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(gM_SealRecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and GMSR_ID=@GMSR_ID; " );
      string sql=sb.ToString();
         if(gM_SealRecord.GMSR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Code))
         {
            idb.AddParameter("@GMSR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Code", gM_SealRecord.GMSR_Code);
         }
          }
         if(gM_SealRecord.GMSR_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_SCode))
         {
            idb.AddParameter("@GMSR_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_SCode", gM_SealRecord.GMSR_SCode);
         }
          }
         if(gM_SealRecord.GMSR_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_SName))
         {
            idb.AddParameter("@GMSR_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_SName", gM_SealRecord.GMSR_SName);
         }
          }
         if(gM_SealRecord.GMSR_Date_IsChanged)
         {
         if (gM_SealRecord.GMSR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@GMSR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Date", gM_SealRecord.GMSR_Date);
         }
          }
         if(gM_SealRecord.GMSR_Function_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Function))
         {
            idb.AddParameter("@GMSR_Function", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Function", gM_SealRecord.GMSR_Function);
         }
          }
         if(gM_SealRecord.GMSR_Copy_IsChanged)
         {
         if (gM_SealRecord.GMSR_Copy == 0)
         {
            idb.AddParameter("@GMSR_Copy", 0);
         }
         else
         {
            idb.AddParameter("@GMSR_Copy", gM_SealRecord.GMSR_Copy);
         }
          }
         if(gM_SealRecord.GMSR_Employee_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Employee))
         {
            idb.AddParameter("@GMSR_Employee", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Employee", gM_SealRecord.GMSR_Employee);
         }
          }
         if(gM_SealRecord.GMSR_Approve_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Approve))
         {
            idb.AddParameter("@GMSR_Approve", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Approve", gM_SealRecord.GMSR_Approve);
         }
          }
         if(gM_SealRecord.GMSR_RDate_IsChanged)
         {
         if (gM_SealRecord.GMSR_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@GMSR_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_RDate", gM_SealRecord.GMSR_RDate);
         }
          }
         if(gM_SealRecord.GMSR_UCat_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_UCat))
         {
            idb.AddParameter("@GMSR_UCat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_UCat", gM_SealRecord.GMSR_UCat);
         }
          }
         if(gM_SealRecord.GMSR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Company))
         {
            idb.AddParameter("@GMSR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Company", gM_SealRecord.GMSR_Company);
         }
          }
         if(gM_SealRecord.GMSR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Dept))
         {
            idb.AddParameter("@GMSR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Dept", gM_SealRecord.GMSR_Dept);
         }
          }
         if(gM_SealRecord.GMSR_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_SealRecord.GMSR_Bak))
         {
            idb.AddParameter("@GMSR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSR_Bak", gM_SealRecord.GMSR_Bak);
         }
          }
         if(gM_SealRecord.Stat_IsChanged)
         {
         if (gM_SealRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gM_SealRecord.Stat);
         }
          }
         if(gM_SealRecord.CreateDate_IsChanged)
         {
         if (gM_SealRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", gM_SealRecord.CreateDate);
         }
          }
         if(gM_SealRecord.UpdateDate_IsChanged)
         {
         if (gM_SealRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", gM_SealRecord.UpdateDate);
         }
          }
         if(gM_SealRecord.DeleteDate_IsChanged)
         {
         if (gM_SealRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", gM_SealRecord.DeleteDate);
         }
          }

         idb.AddParameter("@GMSR_ID", gM_SealRecord.GMSR_ID);

           
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
      /// 删除印章使用记录 GM_SealRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal gMSR_ID)
      {
         string sql = "DELETE GM_SealRecord WHERE 1=1  AND GMSR_ID=@GMSR_ID ";
         idb.AddParameter("@GMSR_ID", gMSR_ID);

           
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
      /// 获取指定的印章使用记录 GM_SealRecord对象(即:一条记录
      /// </summary>
      public GM_SealRecord GetByKey(decimal gMSR_ID)
      {
         GM_SealRecord gM_SealRecord = new GM_SealRecord();
         string sql = "SELECT  GMSR_ID,GMSR_Code,GMSR_SCode,GMSR_SName,GMSR_Date,GMSR_Function,GMSR_Copy,GMSR_Employee,GMSR_Approve,GMSR_RDate,GMSR_UCat,GMSR_Company,GMSR_Dept,GMSR_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM GM_SealRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND GMSR_ID=@GMSR_ID ";
         idb.AddParameter("@GMSR_ID", gMSR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["GMSR_ID"] != DBNull.Value) gM_SealRecord.GMSR_ID = Convert.ToDecimal(dr["GMSR_ID"]);
            if (dr["GMSR_Code"] != DBNull.Value) gM_SealRecord.GMSR_Code = Convert.ToString(dr["GMSR_Code"]);
            if (dr["GMSR_SCode"] != DBNull.Value) gM_SealRecord.GMSR_SCode = Convert.ToString(dr["GMSR_SCode"]);
            if (dr["GMSR_SName"] != DBNull.Value) gM_SealRecord.GMSR_SName = Convert.ToString(dr["GMSR_SName"]);
            if (dr["GMSR_Date"] != DBNull.Value) gM_SealRecord.GMSR_Date = Convert.ToDateTime(dr["GMSR_Date"]);
            if (dr["GMSR_Function"] != DBNull.Value) gM_SealRecord.GMSR_Function = Convert.ToString(dr["GMSR_Function"]);
            if (dr["GMSR_Copy"] != DBNull.Value) gM_SealRecord.GMSR_Copy = Convert.ToInt32(dr["GMSR_Copy"]);
            if (dr["GMSR_Employee"] != DBNull.Value) gM_SealRecord.GMSR_Employee = Convert.ToString(dr["GMSR_Employee"]);
            if (dr["GMSR_Approve"] != DBNull.Value) gM_SealRecord.GMSR_Approve = Convert.ToString(dr["GMSR_Approve"]);
            if (dr["GMSR_RDate"] != DBNull.Value) gM_SealRecord.GMSR_RDate = Convert.ToDateTime(dr["GMSR_RDate"]);
            if (dr["GMSR_UCat"] != DBNull.Value) gM_SealRecord.GMSR_UCat = Convert.ToString(dr["GMSR_UCat"]);
            if (dr["GMSR_Company"] != DBNull.Value) gM_SealRecord.GMSR_Company = Convert.ToString(dr["GMSR_Company"]);
            if (dr["GMSR_Dept"] != DBNull.Value) gM_SealRecord.GMSR_Dept = Convert.ToString(dr["GMSR_Dept"]);
            if (dr["GMSR_Bak"] != DBNull.Value) gM_SealRecord.GMSR_Bak = Convert.ToString(dr["GMSR_Bak"]);
            if (dr["Stat"] != DBNull.Value) gM_SealRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) gM_SealRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) gM_SealRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) gM_SealRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return gM_SealRecord;
      }
      /// <summary>
      /// 获取指定的印章使用记录 GM_SealRecord对象集合
      /// </summary>
      public List<GM_SealRecord> GetListByWhere(string strCondition)
      {
         List<GM_SealRecord> ret = new List<GM_SealRecord>();
         string sql = "SELECT  GMSR_ID,GMSR_Code,GMSR_SCode,GMSR_SName,GMSR_Date,GMSR_Function,GMSR_Copy,GMSR_Employee,GMSR_Approve,GMSR_RDate,GMSR_UCat,GMSR_Company,GMSR_Dept,GMSR_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM GM_SealRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            GM_SealRecord gM_SealRecord = new GM_SealRecord();
            if (dr["GMSR_ID"] != DBNull.Value) gM_SealRecord.GMSR_ID = Convert.ToDecimal(dr["GMSR_ID"]);
            if (dr["GMSR_Code"] != DBNull.Value) gM_SealRecord.GMSR_Code = Convert.ToString(dr["GMSR_Code"]);
            if (dr["GMSR_SCode"] != DBNull.Value) gM_SealRecord.GMSR_SCode = Convert.ToString(dr["GMSR_SCode"]);
            if (dr["GMSR_SName"] != DBNull.Value) gM_SealRecord.GMSR_SName = Convert.ToString(dr["GMSR_SName"]);
            if (dr["GMSR_Date"] != DBNull.Value) gM_SealRecord.GMSR_Date = Convert.ToDateTime(dr["GMSR_Date"]);
            if (dr["GMSR_Function"] != DBNull.Value) gM_SealRecord.GMSR_Function = Convert.ToString(dr["GMSR_Function"]);
            if (dr["GMSR_Copy"] != DBNull.Value) gM_SealRecord.GMSR_Copy = Convert.ToInt32(dr["GMSR_Copy"]);
            if (dr["GMSR_Employee"] != DBNull.Value) gM_SealRecord.GMSR_Employee = Convert.ToString(dr["GMSR_Employee"]);
            if (dr["GMSR_Approve"] != DBNull.Value) gM_SealRecord.GMSR_Approve = Convert.ToString(dr["GMSR_Approve"]);
            if (dr["GMSR_RDate"] != DBNull.Value) gM_SealRecord.GMSR_RDate = Convert.ToDateTime(dr["GMSR_RDate"]);
            if (dr["GMSR_UCat"] != DBNull.Value) gM_SealRecord.GMSR_UCat = Convert.ToString(dr["GMSR_UCat"]);
            if (dr["GMSR_Company"] != DBNull.Value) gM_SealRecord.GMSR_Company = Convert.ToString(dr["GMSR_Company"]);
            if (dr["GMSR_Dept"] != DBNull.Value) gM_SealRecord.GMSR_Dept = Convert.ToString(dr["GMSR_Dept"]);
            if (dr["GMSR_Bak"] != DBNull.Value) gM_SealRecord.GMSR_Bak = Convert.ToString(dr["GMSR_Bak"]);
            if (dr["Stat"] != DBNull.Value) gM_SealRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) gM_SealRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) gM_SealRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) gM_SealRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(gM_SealRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的印章使用记录 GM_SealRecord对象(即:一条记录
      /// </summary>
      public List<GM_SealRecord> GetAll()
      {
         List<GM_SealRecord> ret = new List<GM_SealRecord>();
         string sql = "SELECT  GMSR_ID,GMSR_Code,GMSR_SCode,GMSR_SName,GMSR_Date,GMSR_Function,GMSR_Copy,GMSR_Employee,GMSR_Approve,GMSR_RDate,GMSR_UCat,GMSR_Company,GMSR_Dept,GMSR_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM GM_SealRecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by GMSR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            GM_SealRecord gM_SealRecord = new GM_SealRecord();
            if (dr["GMSR_ID"] != DBNull.Value) gM_SealRecord.GMSR_ID = Convert.ToDecimal(dr["GMSR_ID"]);
            if (dr["GMSR_Code"] != DBNull.Value) gM_SealRecord.GMSR_Code = Convert.ToString(dr["GMSR_Code"]);
            if (dr["GMSR_SCode"] != DBNull.Value) gM_SealRecord.GMSR_SCode = Convert.ToString(dr["GMSR_SCode"]);
            if (dr["GMSR_SName"] != DBNull.Value) gM_SealRecord.GMSR_SName = Convert.ToString(dr["GMSR_SName"]);
            if (dr["GMSR_Date"] != DBNull.Value) gM_SealRecord.GMSR_Date = Convert.ToDateTime(dr["GMSR_Date"]);
            if (dr["GMSR_Function"] != DBNull.Value) gM_SealRecord.GMSR_Function = Convert.ToString(dr["GMSR_Function"]);
            if (dr["GMSR_Copy"] != DBNull.Value) gM_SealRecord.GMSR_Copy = Convert.ToInt32(dr["GMSR_Copy"]);
            if (dr["GMSR_Employee"] != DBNull.Value) gM_SealRecord.GMSR_Employee = Convert.ToString(dr["GMSR_Employee"]);
            if (dr["GMSR_Approve"] != DBNull.Value) gM_SealRecord.GMSR_Approve = Convert.ToString(dr["GMSR_Approve"]);
            if (dr["GMSR_RDate"] != DBNull.Value) gM_SealRecord.GMSR_RDate = Convert.ToDateTime(dr["GMSR_RDate"]);
            if (dr["GMSR_UCat"] != DBNull.Value) gM_SealRecord.GMSR_UCat = Convert.ToString(dr["GMSR_UCat"]);
            if (dr["GMSR_Company"] != DBNull.Value) gM_SealRecord.GMSR_Company = Convert.ToString(dr["GMSR_Company"]);
            if (dr["GMSR_Dept"] != DBNull.Value) gM_SealRecord.GMSR_Dept = Convert.ToString(dr["GMSR_Dept"]);
            if (dr["GMSR_Bak"] != DBNull.Value) gM_SealRecord.GMSR_Bak = Convert.ToString(dr["GMSR_Bak"]);
            if (dr["Stat"] != DBNull.Value) gM_SealRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) gM_SealRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) gM_SealRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) gM_SealRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(gM_SealRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
