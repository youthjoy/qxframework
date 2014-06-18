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
   /// 应收账款
   /// </summary>
   [Serializable]
   public partial class ADOSD_Receivable
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加应收账款 SD_Receivable对象(即:一条记录)
      /// </summary>
      public int Add(SD_Receivable sD_Receivable)
      {
         string sql = "INSERT INTO SD_Receivable (SDR_Code,SDR_CCode,SDR_CName,SDR_Period,SDR_Last,SDR_Current,SDR_Left,SDR_IsDone,SDR_Done,SDR_LeftDone,SDR_Remark,Stat,SDR_Date,CreateDate,UpdateDate,DeleteDate,SDR_CompanyCode,SDR_Company,SDR_broom) VALUES (@SDR_Code,@SDR_CCode,@SDR_CName,@SDR_Period,@SDR_Last,@SDR_Current,@SDR_Left,@SDR_IsDone,@SDR_Done,@SDR_LeftDone,@SDR_Remark,@Stat,@SDR_Date,@CreateDate,@UpdateDate,@DeleteDate,@SDR_CompanyCode,@SDR_Company,@SDR_broom)";
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Code))
         {
            idb.AddParameter("@SDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Code", sD_Receivable.SDR_Code);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CCode))
         {
            idb.AddParameter("@SDR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CCode", sD_Receivable.SDR_CCode);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CName))
         {
            idb.AddParameter("@SDR_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CName", sD_Receivable.SDR_CName);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Period))
         {
            idb.AddParameter("@SDR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Period", sD_Receivable.SDR_Period);
         }
         if (sD_Receivable.SDR_Last == 0)
         {
            idb.AddParameter("@SDR_Last", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Last", sD_Receivable.SDR_Last);
         }
         if (sD_Receivable.SDR_Current == 0)
         {
            idb.AddParameter("@SDR_Current", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Current", sD_Receivable.SDR_Current);
         }
         if (sD_Receivable.SDR_Left == 0)
         {
            idb.AddParameter("@SDR_Left", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Left", sD_Receivable.SDR_Left);
         }
         if (sD_Receivable.SDR_IsDone == 0)
         {
            idb.AddParameter("@SDR_IsDone", 0);
         }
         else
         {
            idb.AddParameter("@SDR_IsDone", sD_Receivable.SDR_IsDone);
         }
         if (sD_Receivable.SDR_Done == 0)
         {
            idb.AddParameter("@SDR_Done", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Done", sD_Receivable.SDR_Done);
         }
         if (sD_Receivable.SDR_LeftDone == 0)
         {
            idb.AddParameter("@SDR_LeftDone", 0);
         }
         else
         {
            idb.AddParameter("@SDR_LeftDone", sD_Receivable.SDR_LeftDone);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Remark))
         {
            idb.AddParameter("@SDR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Remark", sD_Receivable.SDR_Remark);
         }
         if (sD_Receivable.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Receivable.Stat);
         }
         if (sD_Receivable.SDR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Date", sD_Receivable.SDR_Date);
         }
         if (sD_Receivable.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Receivable.CreateDate);
         }
         if (sD_Receivable.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Receivable.UpdateDate);
         }
         if (sD_Receivable.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Receivable.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CompanyCode))
         {
            idb.AddParameter("@SDR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CompanyCode", sD_Receivable.SDR_CompanyCode);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Company))
         {
            idb.AddParameter("@SDR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Company", sD_Receivable.SDR_Company);
         }
         if (sD_Receivable.SDR_broom == 0)
         {
            idb.AddParameter("@SDR_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDR_broom", sD_Receivable.SDR_broom);
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
      /// 添加应收账款 SD_Receivable对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Receivable sD_Receivable)
      {
         string sql = "INSERT INTO SD_Receivable (SDR_Code,SDR_CCode,SDR_CName,SDR_Period,SDR_Last,SDR_Current,SDR_Left,SDR_IsDone,SDR_Done,SDR_LeftDone,SDR_Remark,Stat,SDR_Date,CreateDate,UpdateDate,DeleteDate,SDR_CompanyCode,SDR_Company,SDR_broom) VALUES (@SDR_Code,@SDR_CCode,@SDR_CName,@SDR_Period,@SDR_Last,@SDR_Current,@SDR_Left,@SDR_IsDone,@SDR_Done,@SDR_LeftDone,@SDR_Remark,@Stat,@SDR_Date,@CreateDate,@UpdateDate,@DeleteDate,@SDR_CompanyCode,@SDR_Company,@SDR_broom);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Code))
         {
            idb.AddParameter("@SDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Code", sD_Receivable.SDR_Code);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CCode))
         {
            idb.AddParameter("@SDR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CCode", sD_Receivable.SDR_CCode);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CName))
         {
            idb.AddParameter("@SDR_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CName", sD_Receivable.SDR_CName);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Period))
         {
            idb.AddParameter("@SDR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Period", sD_Receivable.SDR_Period);
         }
         if (sD_Receivable.SDR_Last == 0)
         {
            idb.AddParameter("@SDR_Last", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Last", sD_Receivable.SDR_Last);
         }
         if (sD_Receivable.SDR_Current == 0)
         {
            idb.AddParameter("@SDR_Current", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Current", sD_Receivable.SDR_Current);
         }
         if (sD_Receivable.SDR_Left == 0)
         {
            idb.AddParameter("@SDR_Left", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Left", sD_Receivable.SDR_Left);
         }
         if (sD_Receivable.SDR_IsDone == 0)
         {
            idb.AddParameter("@SDR_IsDone", 0);
         }
         else
         {
            idb.AddParameter("@SDR_IsDone", sD_Receivable.SDR_IsDone);
         }
         if (sD_Receivable.SDR_Done == 0)
         {
            idb.AddParameter("@SDR_Done", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Done", sD_Receivable.SDR_Done);
         }
         if (sD_Receivable.SDR_LeftDone == 0)
         {
            idb.AddParameter("@SDR_LeftDone", 0);
         }
         else
         {
            idb.AddParameter("@SDR_LeftDone", sD_Receivable.SDR_LeftDone);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Remark))
         {
            idb.AddParameter("@SDR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Remark", sD_Receivable.SDR_Remark);
         }
         if (sD_Receivable.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Receivable.Stat);
         }
         if (sD_Receivable.SDR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Date", sD_Receivable.SDR_Date);
         }
         if (sD_Receivable.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Receivable.CreateDate);
         }
         if (sD_Receivable.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Receivable.UpdateDate);
         }
         if (sD_Receivable.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Receivable.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CompanyCode))
         {
            idb.AddParameter("@SDR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CompanyCode", sD_Receivable.SDR_CompanyCode);
         }
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Company))
         {
            idb.AddParameter("@SDR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Company", sD_Receivable.SDR_Company);
         }
         if (sD_Receivable.SDR_broom == 0)
         {
            idb.AddParameter("@SDR_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDR_broom", sD_Receivable.SDR_broom);
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
      /// 更新应收账款 SD_Receivable对象(即:一条记录
      /// </summary>
      public int Update(SD_Receivable sD_Receivable)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Receivable       SET ");
            if(sD_Receivable.SDR_Code_IsChanged){sbParameter.Append("SDR_Code=@SDR_Code, ");}
      if(sD_Receivable.SDR_CCode_IsChanged){sbParameter.Append("SDR_CCode=@SDR_CCode, ");}
      if(sD_Receivable.SDR_CName_IsChanged){sbParameter.Append("SDR_CName=@SDR_CName, ");}
      if(sD_Receivable.SDR_Period_IsChanged){sbParameter.Append("SDR_Period=@SDR_Period, ");}
      if(sD_Receivable.SDR_Last_IsChanged){sbParameter.Append("SDR_Last=@SDR_Last, ");}
      if(sD_Receivable.SDR_Current_IsChanged){sbParameter.Append("SDR_Current=@SDR_Current, ");}
      if(sD_Receivable.SDR_Left_IsChanged){sbParameter.Append("SDR_Left=@SDR_Left, ");}
      if(sD_Receivable.SDR_IsDone_IsChanged){sbParameter.Append("SDR_IsDone=@SDR_IsDone, ");}
      if(sD_Receivable.SDR_Done_IsChanged){sbParameter.Append("SDR_Done=@SDR_Done, ");}
      if(sD_Receivable.SDR_LeftDone_IsChanged){sbParameter.Append("SDR_LeftDone=@SDR_LeftDone, ");}
      if(sD_Receivable.SDR_Remark_IsChanged){sbParameter.Append("SDR_Remark=@SDR_Remark, ");}
      if(sD_Receivable.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Receivable.SDR_Date_IsChanged){sbParameter.Append("SDR_Date=@SDR_Date, ");}
      if(sD_Receivable.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_Receivable.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_Receivable.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_Receivable.SDR_CompanyCode_IsChanged){sbParameter.Append("SDR_CompanyCode=@SDR_CompanyCode, ");}
      if(sD_Receivable.SDR_Company_IsChanged){sbParameter.Append("SDR_Company=@SDR_Company, ");}
      if(sD_Receivable.SDR_broom_IsChanged){sbParameter.Append("SDR_broom=@SDR_broom ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDR_ID=@SDR_ID; " );
      string sql=sb.ToString();
         if(sD_Receivable.SDR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Code))
         {
            idb.AddParameter("@SDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Code", sD_Receivable.SDR_Code);
         }
          }
         if(sD_Receivable.SDR_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CCode))
         {
            idb.AddParameter("@SDR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CCode", sD_Receivable.SDR_CCode);
         }
          }
         if(sD_Receivable.SDR_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CName))
         {
            idb.AddParameter("@SDR_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CName", sD_Receivable.SDR_CName);
         }
          }
         if(sD_Receivable.SDR_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Period))
         {
            idb.AddParameter("@SDR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Period", sD_Receivable.SDR_Period);
         }
          }
         if(sD_Receivable.SDR_Last_IsChanged)
         {
         if (sD_Receivable.SDR_Last == 0)
         {
            idb.AddParameter("@SDR_Last", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Last", sD_Receivable.SDR_Last);
         }
          }
         if(sD_Receivable.SDR_Current_IsChanged)
         {
         if (sD_Receivable.SDR_Current == 0)
         {
            idb.AddParameter("@SDR_Current", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Current", sD_Receivable.SDR_Current);
         }
          }
         if(sD_Receivable.SDR_Left_IsChanged)
         {
         if (sD_Receivable.SDR_Left == 0)
         {
            idb.AddParameter("@SDR_Left", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Left", sD_Receivable.SDR_Left);
         }
          }
         if(sD_Receivable.SDR_IsDone_IsChanged)
         {
         if (sD_Receivable.SDR_IsDone == 0)
         {
            idb.AddParameter("@SDR_IsDone", 0);
         }
         else
         {
            idb.AddParameter("@SDR_IsDone", sD_Receivable.SDR_IsDone);
         }
          }
         if(sD_Receivable.SDR_Done_IsChanged)
         {
         if (sD_Receivable.SDR_Done == 0)
         {
            idb.AddParameter("@SDR_Done", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Done", sD_Receivable.SDR_Done);
         }
          }
         if(sD_Receivable.SDR_LeftDone_IsChanged)
         {
         if (sD_Receivable.SDR_LeftDone == 0)
         {
            idb.AddParameter("@SDR_LeftDone", 0);
         }
         else
         {
            idb.AddParameter("@SDR_LeftDone", sD_Receivable.SDR_LeftDone);
         }
          }
         if(sD_Receivable.SDR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Remark))
         {
            idb.AddParameter("@SDR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Remark", sD_Receivable.SDR_Remark);
         }
          }
         if(sD_Receivable.Stat_IsChanged)
         {
         if (sD_Receivable.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Receivable.Stat);
         }
          }
         if(sD_Receivable.SDR_Date_IsChanged)
         {
         if (sD_Receivable.SDR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Date", sD_Receivable.SDR_Date);
         }
          }
         if(sD_Receivable.CreateDate_IsChanged)
         {
         if (sD_Receivable.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Receivable.CreateDate);
         }
          }
         if(sD_Receivable.UpdateDate_IsChanged)
         {
         if (sD_Receivable.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Receivable.UpdateDate);
         }
          }
         if(sD_Receivable.DeleteDate_IsChanged)
         {
         if (sD_Receivable.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Receivable.DeleteDate);
         }
          }
         if(sD_Receivable.SDR_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receivable.SDR_CompanyCode))
         {
            idb.AddParameter("@SDR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CompanyCode", sD_Receivable.SDR_CompanyCode);
         }
          }
         if(sD_Receivable.SDR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receivable.SDR_Company))
         {
            idb.AddParameter("@SDR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Company", sD_Receivable.SDR_Company);
         }
          }
         if(sD_Receivable.SDR_broom_IsChanged)
         {
         if (sD_Receivable.SDR_broom == 0)
         {
            idb.AddParameter("@SDR_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDR_broom", sD_Receivable.SDR_broom);
         }
          }

         idb.AddParameter("@SDR_ID", sD_Receivable.SDR_ID);

           
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
      /// 删除应收账款 SD_Receivable对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDR_ID)
      {
         string sql = "DELETE SD_Receivable WHERE 1=1  AND SDR_ID=@SDR_ID ";
         idb.AddParameter("@SDR_ID", sDR_ID);

           
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
      /// 获取指定的应收账款 SD_Receivable对象(即:一条记录
      /// </summary>
      public SD_Receivable GetByKey(decimal sDR_ID)
      {
         SD_Receivable sD_Receivable = new SD_Receivable();
         string sql = "SELECT  SDR_ID,SDR_Code,SDR_CCode,SDR_CName,SDR_Period,SDR_Last,SDR_Current,SDR_Left,SDR_IsDone,SDR_Done,SDR_LeftDone,SDR_Remark,Stat,SDR_Date,CreateDate,UpdateDate,DeleteDate,SDR_CompanyCode,SDR_Company,SDR_broom FROM SD_Receivable WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDR_ID=@SDR_ID ";
         idb.AddParameter("@SDR_ID", sDR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDR_ID"] != DBNull.Value) sD_Receivable.SDR_ID = Convert.ToDecimal(dr["SDR_ID"]);
            if (dr["SDR_Code"] != DBNull.Value) sD_Receivable.SDR_Code = Convert.ToString(dr["SDR_Code"]);
            if (dr["SDR_CCode"] != DBNull.Value) sD_Receivable.SDR_CCode = Convert.ToString(dr["SDR_CCode"]);
            if (dr["SDR_CName"] != DBNull.Value) sD_Receivable.SDR_CName = Convert.ToString(dr["SDR_CName"]);
            if (dr["SDR_Period"] != DBNull.Value) sD_Receivable.SDR_Period = Convert.ToString(dr["SDR_Period"]);
            if (dr["SDR_Last"] != DBNull.Value) sD_Receivable.SDR_Last = Convert.ToDecimal(dr["SDR_Last"]);
            if (dr["SDR_Current"] != DBNull.Value) sD_Receivable.SDR_Current = Convert.ToDecimal(dr["SDR_Current"]);
            if (dr["SDR_Left"] != DBNull.Value) sD_Receivable.SDR_Left = Convert.ToDecimal(dr["SDR_Left"]);
            if (dr["SDR_IsDone"] != DBNull.Value) sD_Receivable.SDR_IsDone = Convert.ToInt32(dr["SDR_IsDone"]);
            if (dr["SDR_Done"] != DBNull.Value) sD_Receivable.SDR_Done = Convert.ToDecimal(dr["SDR_Done"]);
            if (dr["SDR_LeftDone"] != DBNull.Value) sD_Receivable.SDR_LeftDone = Convert.ToDecimal(dr["SDR_LeftDone"]);
            if (dr["SDR_Remark"] != DBNull.Value) sD_Receivable.SDR_Remark = Convert.ToString(dr["SDR_Remark"]);
            if (dr["Stat"] != DBNull.Value) sD_Receivable.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDR_Date"] != DBNull.Value) sD_Receivable.SDR_Date = Convert.ToDateTime(dr["SDR_Date"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Receivable.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Receivable.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Receivable.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDR_CompanyCode"] != DBNull.Value) sD_Receivable.SDR_CompanyCode = Convert.ToString(dr["SDR_CompanyCode"]);
            if (dr["SDR_Company"] != DBNull.Value) sD_Receivable.SDR_Company = Convert.ToString(dr["SDR_Company"]);
            if (dr["SDR_broom"] != DBNull.Value) sD_Receivable.SDR_broom = Convert.ToDecimal(dr["SDR_broom"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Receivable;
      }
      /// <summary>
      /// 获取指定的应收账款 SD_Receivable对象集合
      /// </summary>
      public List<SD_Receivable> GetListByWhere(string strCondition)
      {
         List<SD_Receivable> ret = new List<SD_Receivable>();
         string sql = "SELECT  SDR_ID,SDR_Code,SDR_CCode,SDR_CName,SDR_Period,SDR_Last,SDR_Current,SDR_Left,SDR_IsDone,SDR_Done,SDR_LeftDone,SDR_Remark,Stat,SDR_Date,CreateDate,UpdateDate,DeleteDate,SDR_CompanyCode,SDR_Company,SDR_broom FROM SD_Receivable WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Receivable sD_Receivable = new SD_Receivable();
            if (dr["SDR_ID"] != DBNull.Value) sD_Receivable.SDR_ID = Convert.ToDecimal(dr["SDR_ID"]);
            if (dr["SDR_Code"] != DBNull.Value) sD_Receivable.SDR_Code = Convert.ToString(dr["SDR_Code"]);
            if (dr["SDR_CCode"] != DBNull.Value) sD_Receivable.SDR_CCode = Convert.ToString(dr["SDR_CCode"]);
            if (dr["SDR_CName"] != DBNull.Value) sD_Receivable.SDR_CName = Convert.ToString(dr["SDR_CName"]);
            if (dr["SDR_Period"] != DBNull.Value) sD_Receivable.SDR_Period = Convert.ToString(dr["SDR_Period"]);
            if (dr["SDR_Last"] != DBNull.Value) sD_Receivable.SDR_Last = Convert.ToDecimal(dr["SDR_Last"]);
            if (dr["SDR_Current"] != DBNull.Value) sD_Receivable.SDR_Current = Convert.ToDecimal(dr["SDR_Current"]);
            if (dr["SDR_Left"] != DBNull.Value) sD_Receivable.SDR_Left = Convert.ToDecimal(dr["SDR_Left"]);
            if (dr["SDR_IsDone"] != DBNull.Value) sD_Receivable.SDR_IsDone = Convert.ToInt32(dr["SDR_IsDone"]);
            if (dr["SDR_Done"] != DBNull.Value) sD_Receivable.SDR_Done = Convert.ToDecimal(dr["SDR_Done"]);
            if (dr["SDR_LeftDone"] != DBNull.Value) sD_Receivable.SDR_LeftDone = Convert.ToDecimal(dr["SDR_LeftDone"]);
            if (dr["SDR_Remark"] != DBNull.Value) sD_Receivable.SDR_Remark = Convert.ToString(dr["SDR_Remark"]);
            if (dr["Stat"] != DBNull.Value) sD_Receivable.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDR_Date"] != DBNull.Value) sD_Receivable.SDR_Date = Convert.ToDateTime(dr["SDR_Date"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Receivable.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Receivable.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Receivable.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDR_CompanyCode"] != DBNull.Value) sD_Receivable.SDR_CompanyCode = Convert.ToString(dr["SDR_CompanyCode"]);
            if (dr["SDR_Company"] != DBNull.Value) sD_Receivable.SDR_Company = Convert.ToString(dr["SDR_Company"]);
            if (dr["SDR_broom"] != DBNull.Value) sD_Receivable.SDR_broom = Convert.ToDecimal(dr["SDR_broom"]);
            ret.Add(sD_Receivable);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的应收账款 SD_Receivable对象(即:一条记录
      /// </summary>
      public List<SD_Receivable> GetAll()
      {
         List<SD_Receivable> ret = new List<SD_Receivable>();
         string sql = "SELECT  SDR_ID,SDR_Code,SDR_CCode,SDR_CName,SDR_Period,SDR_Last,SDR_Current,SDR_Left,SDR_IsDone,SDR_Done,SDR_LeftDone,SDR_Remark,Stat,SDR_Date,CreateDate,UpdateDate,DeleteDate,SDR_CompanyCode,SDR_Company,SDR_broom FROM SD_Receivable where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Receivable sD_Receivable = new SD_Receivable();
            if (dr["SDR_ID"] != DBNull.Value) sD_Receivable.SDR_ID = Convert.ToDecimal(dr["SDR_ID"]);
            if (dr["SDR_Code"] != DBNull.Value) sD_Receivable.SDR_Code = Convert.ToString(dr["SDR_Code"]);
            if (dr["SDR_CCode"] != DBNull.Value) sD_Receivable.SDR_CCode = Convert.ToString(dr["SDR_CCode"]);
            if (dr["SDR_CName"] != DBNull.Value) sD_Receivable.SDR_CName = Convert.ToString(dr["SDR_CName"]);
            if (dr["SDR_Period"] != DBNull.Value) sD_Receivable.SDR_Period = Convert.ToString(dr["SDR_Period"]);
            if (dr["SDR_Last"] != DBNull.Value) sD_Receivable.SDR_Last = Convert.ToDecimal(dr["SDR_Last"]);
            if (dr["SDR_Current"] != DBNull.Value) sD_Receivable.SDR_Current = Convert.ToDecimal(dr["SDR_Current"]);
            if (dr["SDR_Left"] != DBNull.Value) sD_Receivable.SDR_Left = Convert.ToDecimal(dr["SDR_Left"]);
            if (dr["SDR_IsDone"] != DBNull.Value) sD_Receivable.SDR_IsDone = Convert.ToInt32(dr["SDR_IsDone"]);
            if (dr["SDR_Done"] != DBNull.Value) sD_Receivable.SDR_Done = Convert.ToDecimal(dr["SDR_Done"]);
            if (dr["SDR_LeftDone"] != DBNull.Value) sD_Receivable.SDR_LeftDone = Convert.ToDecimal(dr["SDR_LeftDone"]);
            if (dr["SDR_Remark"] != DBNull.Value) sD_Receivable.SDR_Remark = Convert.ToString(dr["SDR_Remark"]);
            if (dr["Stat"] != DBNull.Value) sD_Receivable.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDR_Date"] != DBNull.Value) sD_Receivable.SDR_Date = Convert.ToDateTime(dr["SDR_Date"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Receivable.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Receivable.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Receivable.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDR_CompanyCode"] != DBNull.Value) sD_Receivable.SDR_CompanyCode = Convert.ToString(dr["SDR_CompanyCode"]);
            if (dr["SDR_Company"] != DBNull.Value) sD_Receivable.SDR_Company = Convert.ToString(dr["SDR_Company"]);
            if (dr["SDR_broom"] != DBNull.Value) sD_Receivable.SDR_broom = Convert.ToDecimal(dr["SDR_broom"]);
            ret.Add(sD_Receivable);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
