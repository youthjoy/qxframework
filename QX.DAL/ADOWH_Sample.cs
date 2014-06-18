using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOWH_Sample
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加WH_Sample对象(即:一条记录)
      /// </summary>
      public int Add(WH_Sample wH_Sample)
      {
         string sql = "INSERT INTO WH_Sample (Sample_Code,Sample_Name,Sample_Count,Sample_Unit,Sample_Remark,Sample_SupplierName,Sample_SupplierCode,Sample_SupplierContactor,Sample_Contact,Sample_ComeDate,Sample_Operator,Sample_OpDate,Sample_Company,Sample_Dept,Sample_Responer,Sample_Feedback,Sample_FeedbackDate,Sample_IsRef,Sample_State,Sample_Type,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Sample_Code,@Sample_Name,@Sample_Count,@Sample_Unit,@Sample_Remark,@Sample_SupplierName,@Sample_SupplierCode,@Sample_SupplierContactor,@Sample_Contact,@Sample_ComeDate,@Sample_Operator,@Sample_OpDate,@Sample_Company,@Sample_Dept,@Sample_Responer,@Sample_Feedback,@Sample_FeedbackDate,@Sample_IsRef,@Sample_State,@Sample_Type,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(wH_Sample.Sample_Code))
         {
            idb.AddParameter("@Sample_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Code", wH_Sample.Sample_Code);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Name))
         {
            idb.AddParameter("@Sample_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Name", wH_Sample.Sample_Name);
         }
         if (wH_Sample.Sample_Count == 0)
         {
            idb.AddParameter("@Sample_Count", 0);
         }
         else
         {
            idb.AddParameter("@Sample_Count", wH_Sample.Sample_Count);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Unit))
         {
            idb.AddParameter("@Sample_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Unit", wH_Sample.Sample_Unit);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Remark))
         {
            idb.AddParameter("@Sample_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Remark", wH_Sample.Sample_Remark);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierName))
         {
            idb.AddParameter("@Sample_SupplierName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierName", wH_Sample.Sample_SupplierName);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierCode))
         {
            idb.AddParameter("@Sample_SupplierCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierCode", wH_Sample.Sample_SupplierCode);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierContactor))
         {
            idb.AddParameter("@Sample_SupplierContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierContactor", wH_Sample.Sample_SupplierContactor);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Contact))
         {
            idb.AddParameter("@Sample_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Contact", wH_Sample.Sample_Contact);
         }
         if (wH_Sample.Sample_ComeDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_ComeDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_ComeDate", wH_Sample.Sample_ComeDate);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Operator))
         {
            idb.AddParameter("@Sample_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Operator", wH_Sample.Sample_Operator);
         }
         if (wH_Sample.Sample_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_OpDate", wH_Sample.Sample_OpDate);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Company))
         {
            idb.AddParameter("@Sample_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Company", wH_Sample.Sample_Company);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Dept))
         {
            idb.AddParameter("@Sample_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Dept", wH_Sample.Sample_Dept);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Responer))
         {
            idb.AddParameter("@Sample_Responer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Responer", wH_Sample.Sample_Responer);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Feedback))
         {
            idb.AddParameter("@Sample_Feedback", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Feedback", wH_Sample.Sample_Feedback);
         }
         if (wH_Sample.Sample_FeedbackDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_FeedbackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_FeedbackDate", wH_Sample.Sample_FeedbackDate);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_IsRef))
         {
            idb.AddParameter("@Sample_IsRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_IsRef", wH_Sample.Sample_IsRef);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_State))
         {
            idb.AddParameter("@Sample_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_State", wH_Sample.Sample_State);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Type))
         {
            idb.AddParameter("@Sample_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Type", wH_Sample.Sample_Type);
         }
         if (wH_Sample.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Sample.Stat);
         }
         if (wH_Sample.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Sample.CreateDate);
         }
         if (wH_Sample.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Sample.UpdateDate);
         }
         if (wH_Sample.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Sample.DeleteDate);
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
      /// 添加WH_Sample对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Sample wH_Sample)
      {
         string sql = "INSERT INTO WH_Sample (Sample_Code,Sample_Name,Sample_Count,Sample_Unit,Sample_Remark,Sample_SupplierName,Sample_SupplierCode,Sample_SupplierContactor,Sample_Contact,Sample_ComeDate,Sample_Operator,Sample_OpDate,Sample_Company,Sample_Dept,Sample_Responer,Sample_Feedback,Sample_FeedbackDate,Sample_IsRef,Sample_State,Sample_Type,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Sample_Code,@Sample_Name,@Sample_Count,@Sample_Unit,@Sample_Remark,@Sample_SupplierName,@Sample_SupplierCode,@Sample_SupplierContactor,@Sample_Contact,@Sample_ComeDate,@Sample_Operator,@Sample_OpDate,@Sample_Company,@Sample_Dept,@Sample_Responer,@Sample_Feedback,@Sample_FeedbackDate,@Sample_IsRef,@Sample_State,@Sample_Type,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Sample.Sample_Code))
         {
            idb.AddParameter("@Sample_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Code", wH_Sample.Sample_Code);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Name))
         {
            idb.AddParameter("@Sample_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Name", wH_Sample.Sample_Name);
         }
         if (wH_Sample.Sample_Count == 0)
         {
            idb.AddParameter("@Sample_Count", 0);
         }
         else
         {
            idb.AddParameter("@Sample_Count", wH_Sample.Sample_Count);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Unit))
         {
            idb.AddParameter("@Sample_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Unit", wH_Sample.Sample_Unit);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Remark))
         {
            idb.AddParameter("@Sample_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Remark", wH_Sample.Sample_Remark);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierName))
         {
            idb.AddParameter("@Sample_SupplierName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierName", wH_Sample.Sample_SupplierName);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierCode))
         {
            idb.AddParameter("@Sample_SupplierCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierCode", wH_Sample.Sample_SupplierCode);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierContactor))
         {
            idb.AddParameter("@Sample_SupplierContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierContactor", wH_Sample.Sample_SupplierContactor);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Contact))
         {
            idb.AddParameter("@Sample_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Contact", wH_Sample.Sample_Contact);
         }
         if (wH_Sample.Sample_ComeDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_ComeDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_ComeDate", wH_Sample.Sample_ComeDate);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Operator))
         {
            idb.AddParameter("@Sample_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Operator", wH_Sample.Sample_Operator);
         }
         if (wH_Sample.Sample_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_OpDate", wH_Sample.Sample_OpDate);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Company))
         {
            idb.AddParameter("@Sample_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Company", wH_Sample.Sample_Company);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Dept))
         {
            idb.AddParameter("@Sample_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Dept", wH_Sample.Sample_Dept);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Responer))
         {
            idb.AddParameter("@Sample_Responer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Responer", wH_Sample.Sample_Responer);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Feedback))
         {
            idb.AddParameter("@Sample_Feedback", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Feedback", wH_Sample.Sample_Feedback);
         }
         if (wH_Sample.Sample_FeedbackDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_FeedbackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_FeedbackDate", wH_Sample.Sample_FeedbackDate);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_IsRef))
         {
            idb.AddParameter("@Sample_IsRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_IsRef", wH_Sample.Sample_IsRef);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_State))
         {
            idb.AddParameter("@Sample_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_State", wH_Sample.Sample_State);
         }
         if (string.IsNullOrEmpty(wH_Sample.Sample_Type))
         {
            idb.AddParameter("@Sample_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Type", wH_Sample.Sample_Type);
         }
         if (wH_Sample.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Sample.Stat);
         }
         if (wH_Sample.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Sample.CreateDate);
         }
         if (wH_Sample.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Sample.UpdateDate);
         }
         if (wH_Sample.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Sample.DeleteDate);
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
      /// 更新WH_Sample对象(即:一条记录
      /// </summary>
      public int Update(WH_Sample wH_Sample)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Sample       SET ");
            if(wH_Sample.Sample_Code_IsChanged){sbParameter.Append("Sample_Code=@Sample_Code, ");}
      if(wH_Sample.Sample_Name_IsChanged){sbParameter.Append("Sample_Name=@Sample_Name, ");}
      if(wH_Sample.Sample_Count_IsChanged){sbParameter.Append("Sample_Count=@Sample_Count, ");}
      if(wH_Sample.Sample_Unit_IsChanged){sbParameter.Append("Sample_Unit=@Sample_Unit, ");}
      if(wH_Sample.Sample_Remark_IsChanged){sbParameter.Append("Sample_Remark=@Sample_Remark, ");}
      if(wH_Sample.Sample_SupplierName_IsChanged){sbParameter.Append("Sample_SupplierName=@Sample_SupplierName, ");}
      if(wH_Sample.Sample_SupplierCode_IsChanged){sbParameter.Append("Sample_SupplierCode=@Sample_SupplierCode, ");}
      if(wH_Sample.Sample_SupplierContactor_IsChanged){sbParameter.Append("Sample_SupplierContactor=@Sample_SupplierContactor, ");}
      if(wH_Sample.Sample_Contact_IsChanged){sbParameter.Append("Sample_Contact=@Sample_Contact, ");}
      if(wH_Sample.Sample_ComeDate_IsChanged){sbParameter.Append("Sample_ComeDate=@Sample_ComeDate, ");}
      if(wH_Sample.Sample_Operator_IsChanged){sbParameter.Append("Sample_Operator=@Sample_Operator, ");}
      if(wH_Sample.Sample_OpDate_IsChanged){sbParameter.Append("Sample_OpDate=@Sample_OpDate, ");}
      if(wH_Sample.Sample_Company_IsChanged){sbParameter.Append("Sample_Company=@Sample_Company, ");}
      if(wH_Sample.Sample_Dept_IsChanged){sbParameter.Append("Sample_Dept=@Sample_Dept, ");}
      if(wH_Sample.Sample_Responer_IsChanged){sbParameter.Append("Sample_Responer=@Sample_Responer, ");}
      if(wH_Sample.Sample_Feedback_IsChanged){sbParameter.Append("Sample_Feedback=@Sample_Feedback, ");}
      if(wH_Sample.Sample_FeedbackDate_IsChanged){sbParameter.Append("Sample_FeedbackDate=@Sample_FeedbackDate, ");}
      if(wH_Sample.Sample_IsRef_IsChanged){sbParameter.Append("Sample_IsRef=@Sample_IsRef, ");}
      if(wH_Sample.Sample_State_IsChanged){sbParameter.Append("Sample_State=@Sample_State, ");}
      if(wH_Sample.Sample_Type_IsChanged){sbParameter.Append("Sample_Type=@Sample_Type, ");}
      if(wH_Sample.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Sample.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Sample.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Sample.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Sample_ID=@Sample_ID; " );
      string sql=sb.ToString();
         if(wH_Sample.Sample_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Code))
         {
            idb.AddParameter("@Sample_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Code", wH_Sample.Sample_Code);
         }
          }
         if(wH_Sample.Sample_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Name))
         {
            idb.AddParameter("@Sample_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Name", wH_Sample.Sample_Name);
         }
          }
         if(wH_Sample.Sample_Count_IsChanged)
         {
         if (wH_Sample.Sample_Count == 0)
         {
            idb.AddParameter("@Sample_Count", 0);
         }
         else
         {
            idb.AddParameter("@Sample_Count", wH_Sample.Sample_Count);
         }
          }
         if(wH_Sample.Sample_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Unit))
         {
            idb.AddParameter("@Sample_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Unit", wH_Sample.Sample_Unit);
         }
          }
         if(wH_Sample.Sample_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Remark))
         {
            idb.AddParameter("@Sample_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Remark", wH_Sample.Sample_Remark);
         }
          }
         if(wH_Sample.Sample_SupplierName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierName))
         {
            idb.AddParameter("@Sample_SupplierName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierName", wH_Sample.Sample_SupplierName);
         }
          }
         if(wH_Sample.Sample_SupplierCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierCode))
         {
            idb.AddParameter("@Sample_SupplierCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierCode", wH_Sample.Sample_SupplierCode);
         }
          }
         if(wH_Sample.Sample_SupplierContactor_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_SupplierContactor))
         {
            idb.AddParameter("@Sample_SupplierContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_SupplierContactor", wH_Sample.Sample_SupplierContactor);
         }
          }
         if(wH_Sample.Sample_Contact_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Contact))
         {
            idb.AddParameter("@Sample_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Contact", wH_Sample.Sample_Contact);
         }
          }
         if(wH_Sample.Sample_ComeDate_IsChanged)
         {
         if (wH_Sample.Sample_ComeDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_ComeDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_ComeDate", wH_Sample.Sample_ComeDate);
         }
          }
         if(wH_Sample.Sample_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Operator))
         {
            idb.AddParameter("@Sample_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Operator", wH_Sample.Sample_Operator);
         }
          }
         if(wH_Sample.Sample_OpDate_IsChanged)
         {
         if (wH_Sample.Sample_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_OpDate", wH_Sample.Sample_OpDate);
         }
          }
         if(wH_Sample.Sample_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Company))
         {
            idb.AddParameter("@Sample_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Company", wH_Sample.Sample_Company);
         }
          }
         if(wH_Sample.Sample_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Dept))
         {
            idb.AddParameter("@Sample_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Dept", wH_Sample.Sample_Dept);
         }
          }
         if(wH_Sample.Sample_Responer_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Responer))
         {
            idb.AddParameter("@Sample_Responer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Responer", wH_Sample.Sample_Responer);
         }
          }
         if(wH_Sample.Sample_Feedback_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Feedback))
         {
            idb.AddParameter("@Sample_Feedback", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Feedback", wH_Sample.Sample_Feedback);
         }
          }
         if(wH_Sample.Sample_FeedbackDate_IsChanged)
         {
         if (wH_Sample.Sample_FeedbackDate == DateTime.MinValue)
         {
            idb.AddParameter("@Sample_FeedbackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_FeedbackDate", wH_Sample.Sample_FeedbackDate);
         }
          }
         if(wH_Sample.Sample_IsRef_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_IsRef))
         {
            idb.AddParameter("@Sample_IsRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_IsRef", wH_Sample.Sample_IsRef);
         }
          }
         if(wH_Sample.Sample_State_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_State))
         {
            idb.AddParameter("@Sample_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_State", wH_Sample.Sample_State);
         }
          }
         if(wH_Sample.Sample_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Sample.Sample_Type))
         {
            idb.AddParameter("@Sample_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sample_Type", wH_Sample.Sample_Type);
         }
          }
         if(wH_Sample.Stat_IsChanged)
         {
         if (wH_Sample.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Sample.Stat);
         }
          }
         if(wH_Sample.CreateDate_IsChanged)
         {
         if (wH_Sample.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Sample.CreateDate);
         }
          }
         if(wH_Sample.UpdateDate_IsChanged)
         {
         if (wH_Sample.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Sample.UpdateDate);
         }
          }
         if(wH_Sample.DeleteDate_IsChanged)
         {
         if (wH_Sample.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Sample.DeleteDate);
         }
          }

         idb.AddParameter("@Sample_ID", wH_Sample.Sample_ID);

           
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
      /// 删除WH_Sample对象(即:一条记录
      /// </summary>
      public int Delete(decimal sample_ID)
      {
         string sql = "DELETE WH_Sample WHERE 1=1  AND Sample_ID=@Sample_ID ";
         idb.AddParameter("@Sample_ID", sample_ID);

           
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
      /// 获取指定的WH_Sample对象(即:一条记录
      /// </summary>
      public WH_Sample GetByKey(decimal sample_ID)
      {
         WH_Sample wH_Sample = new WH_Sample();
         string sql = "SELECT  Sample_ID,Sample_Code,Sample_Name,Sample_Count,Sample_Unit,Sample_Remark,Sample_SupplierName,Sample_SupplierCode,Sample_SupplierContactor,Sample_Contact,Sample_ComeDate,Sample_Operator,Sample_OpDate,Sample_Company,Sample_Dept,Sample_Responer,Sample_Feedback,Sample_FeedbackDate,Sample_IsRef,Sample_State,Sample_Type,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_Sample WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Sample_ID=@Sample_ID ";
         idb.AddParameter("@Sample_ID", sample_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Sample_ID"] != DBNull.Value) wH_Sample.Sample_ID = Convert.ToDecimal(dr["Sample_ID"]);
            if (dr["Sample_Code"] != DBNull.Value) wH_Sample.Sample_Code = Convert.ToString(dr["Sample_Code"]);
            if (dr["Sample_Name"] != DBNull.Value) wH_Sample.Sample_Name = Convert.ToString(dr["Sample_Name"]);
            if (dr["Sample_Count"] != DBNull.Value) wH_Sample.Sample_Count = Convert.ToInt32(dr["Sample_Count"]);
            if (dr["Sample_Unit"] != DBNull.Value) wH_Sample.Sample_Unit = Convert.ToString(dr["Sample_Unit"]);
            if (dr["Sample_Remark"] != DBNull.Value) wH_Sample.Sample_Remark = Convert.ToString(dr["Sample_Remark"]);
            if (dr["Sample_SupplierName"] != DBNull.Value) wH_Sample.Sample_SupplierName = Convert.ToString(dr["Sample_SupplierName"]);
            if (dr["Sample_SupplierCode"] != DBNull.Value) wH_Sample.Sample_SupplierCode = Convert.ToString(dr["Sample_SupplierCode"]);
            if (dr["Sample_SupplierContactor"] != DBNull.Value) wH_Sample.Sample_SupplierContactor = Convert.ToString(dr["Sample_SupplierContactor"]);
            if (dr["Sample_Contact"] != DBNull.Value) wH_Sample.Sample_Contact = Convert.ToString(dr["Sample_Contact"]);
            if (dr["Sample_ComeDate"] != DBNull.Value) wH_Sample.Sample_ComeDate = Convert.ToDateTime(dr["Sample_ComeDate"]);
            if (dr["Sample_Operator"] != DBNull.Value) wH_Sample.Sample_Operator = Convert.ToString(dr["Sample_Operator"]);
            if (dr["Sample_OpDate"] != DBNull.Value) wH_Sample.Sample_OpDate = Convert.ToDateTime(dr["Sample_OpDate"]);
            if (dr["Sample_Company"] != DBNull.Value) wH_Sample.Sample_Company = Convert.ToString(dr["Sample_Company"]);
            if (dr["Sample_Dept"] != DBNull.Value) wH_Sample.Sample_Dept = Convert.ToString(dr["Sample_Dept"]);
            if (dr["Sample_Responer"] != DBNull.Value) wH_Sample.Sample_Responer = Convert.ToString(dr["Sample_Responer"]);
            if (dr["Sample_Feedback"] != DBNull.Value) wH_Sample.Sample_Feedback = Convert.ToString(dr["Sample_Feedback"]);
            if (dr["Sample_FeedbackDate"] != DBNull.Value) wH_Sample.Sample_FeedbackDate = Convert.ToDateTime(dr["Sample_FeedbackDate"]);
            if (dr["Sample_IsRef"] != DBNull.Value) wH_Sample.Sample_IsRef = Convert.ToString(dr["Sample_IsRef"]);
            if (dr["Sample_State"] != DBNull.Value) wH_Sample.Sample_State = Convert.ToString(dr["Sample_State"]);
            if (dr["Sample_Type"] != DBNull.Value) wH_Sample.Sample_Type = Convert.ToString(dr["Sample_Type"]);
            if (dr["Stat"] != DBNull.Value) wH_Sample.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Sample.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Sample.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Sample.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Sample;
      }
      /// <summary>
      /// 获取指定的WH_Sample对象集合
      /// </summary>
      public List<WH_Sample> GetListByWhere(string strCondition)
      {
         List<WH_Sample> ret = new List<WH_Sample>();
         string sql = "SELECT  Sample_ID,Sample_Code,Sample_Name,Sample_Count,Sample_Unit,Sample_Remark,Sample_SupplierName,Sample_SupplierCode,Sample_SupplierContactor,Sample_Contact,Sample_ComeDate,Sample_Operator,Sample_OpDate,Sample_Company,Sample_Dept,Sample_Responer,Sample_Feedback,Sample_FeedbackDate,Sample_IsRef,Sample_State,Sample_Type,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_Sample WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Sample wH_Sample = new WH_Sample();
            if (dr["Sample_ID"] != DBNull.Value) wH_Sample.Sample_ID = Convert.ToDecimal(dr["Sample_ID"]);
            if (dr["Sample_Code"] != DBNull.Value) wH_Sample.Sample_Code = Convert.ToString(dr["Sample_Code"]);
            if (dr["Sample_Name"] != DBNull.Value) wH_Sample.Sample_Name = Convert.ToString(dr["Sample_Name"]);
            if (dr["Sample_Count"] != DBNull.Value) wH_Sample.Sample_Count = Convert.ToInt32(dr["Sample_Count"]);
            if (dr["Sample_Unit"] != DBNull.Value) wH_Sample.Sample_Unit = Convert.ToString(dr["Sample_Unit"]);
            if (dr["Sample_Remark"] != DBNull.Value) wH_Sample.Sample_Remark = Convert.ToString(dr["Sample_Remark"]);
            if (dr["Sample_SupplierName"] != DBNull.Value) wH_Sample.Sample_SupplierName = Convert.ToString(dr["Sample_SupplierName"]);
            if (dr["Sample_SupplierCode"] != DBNull.Value) wH_Sample.Sample_SupplierCode = Convert.ToString(dr["Sample_SupplierCode"]);
            if (dr["Sample_SupplierContactor"] != DBNull.Value) wH_Sample.Sample_SupplierContactor = Convert.ToString(dr["Sample_SupplierContactor"]);
            if (dr["Sample_Contact"] != DBNull.Value) wH_Sample.Sample_Contact = Convert.ToString(dr["Sample_Contact"]);
            if (dr["Sample_ComeDate"] != DBNull.Value) wH_Sample.Sample_ComeDate = Convert.ToDateTime(dr["Sample_ComeDate"]);
            if (dr["Sample_Operator"] != DBNull.Value) wH_Sample.Sample_Operator = Convert.ToString(dr["Sample_Operator"]);
            if (dr["Sample_OpDate"] != DBNull.Value) wH_Sample.Sample_OpDate = Convert.ToDateTime(dr["Sample_OpDate"]);
            if (dr["Sample_Company"] != DBNull.Value) wH_Sample.Sample_Company = Convert.ToString(dr["Sample_Company"]);
            if (dr["Sample_Dept"] != DBNull.Value) wH_Sample.Sample_Dept = Convert.ToString(dr["Sample_Dept"]);
            if (dr["Sample_Responer"] != DBNull.Value) wH_Sample.Sample_Responer = Convert.ToString(dr["Sample_Responer"]);
            if (dr["Sample_Feedback"] != DBNull.Value) wH_Sample.Sample_Feedback = Convert.ToString(dr["Sample_Feedback"]);
            if (dr["Sample_FeedbackDate"] != DBNull.Value) wH_Sample.Sample_FeedbackDate = Convert.ToDateTime(dr["Sample_FeedbackDate"]);
            if (dr["Sample_IsRef"] != DBNull.Value) wH_Sample.Sample_IsRef = Convert.ToString(dr["Sample_IsRef"]);
            if (dr["Sample_State"] != DBNull.Value) wH_Sample.Sample_State = Convert.ToString(dr["Sample_State"]);
            if (dr["Sample_Type"] != DBNull.Value) wH_Sample.Sample_Type = Convert.ToString(dr["Sample_Type"]);
            if (dr["Stat"] != DBNull.Value) wH_Sample.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Sample.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Sample.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Sample.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_Sample);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的WH_Sample对象(即:一条记录
      /// </summary>
      public List<WH_Sample> GetAll()
      {
         List<WH_Sample> ret = new List<WH_Sample>();
         string sql = "SELECT  Sample_ID,Sample_Code,Sample_Name,Sample_Count,Sample_Unit,Sample_Remark,Sample_SupplierName,Sample_SupplierCode,Sample_SupplierContactor,Sample_Contact,Sample_ComeDate,Sample_Operator,Sample_OpDate,Sample_Company,Sample_Dept,Sample_Responer,Sample_Feedback,Sample_FeedbackDate,Sample_IsRef,Sample_State,Sample_Type,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_Sample where 1=1 AND ((Stat is null) or (Stat=0) ) order by Sample_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Sample wH_Sample = new WH_Sample();
            if (dr["Sample_ID"] != DBNull.Value) wH_Sample.Sample_ID = Convert.ToDecimal(dr["Sample_ID"]);
            if (dr["Sample_Code"] != DBNull.Value) wH_Sample.Sample_Code = Convert.ToString(dr["Sample_Code"]);
            if (dr["Sample_Name"] != DBNull.Value) wH_Sample.Sample_Name = Convert.ToString(dr["Sample_Name"]);
            if (dr["Sample_Count"] != DBNull.Value) wH_Sample.Sample_Count = Convert.ToInt32(dr["Sample_Count"]);
            if (dr["Sample_Unit"] != DBNull.Value) wH_Sample.Sample_Unit = Convert.ToString(dr["Sample_Unit"]);
            if (dr["Sample_Remark"] != DBNull.Value) wH_Sample.Sample_Remark = Convert.ToString(dr["Sample_Remark"]);
            if (dr["Sample_SupplierName"] != DBNull.Value) wH_Sample.Sample_SupplierName = Convert.ToString(dr["Sample_SupplierName"]);
            if (dr["Sample_SupplierCode"] != DBNull.Value) wH_Sample.Sample_SupplierCode = Convert.ToString(dr["Sample_SupplierCode"]);
            if (dr["Sample_SupplierContactor"] != DBNull.Value) wH_Sample.Sample_SupplierContactor = Convert.ToString(dr["Sample_SupplierContactor"]);
            if (dr["Sample_Contact"] != DBNull.Value) wH_Sample.Sample_Contact = Convert.ToString(dr["Sample_Contact"]);
            if (dr["Sample_ComeDate"] != DBNull.Value) wH_Sample.Sample_ComeDate = Convert.ToDateTime(dr["Sample_ComeDate"]);
            if (dr["Sample_Operator"] != DBNull.Value) wH_Sample.Sample_Operator = Convert.ToString(dr["Sample_Operator"]);
            if (dr["Sample_OpDate"] != DBNull.Value) wH_Sample.Sample_OpDate = Convert.ToDateTime(dr["Sample_OpDate"]);
            if (dr["Sample_Company"] != DBNull.Value) wH_Sample.Sample_Company = Convert.ToString(dr["Sample_Company"]);
            if (dr["Sample_Dept"] != DBNull.Value) wH_Sample.Sample_Dept = Convert.ToString(dr["Sample_Dept"]);
            if (dr["Sample_Responer"] != DBNull.Value) wH_Sample.Sample_Responer = Convert.ToString(dr["Sample_Responer"]);
            if (dr["Sample_Feedback"] != DBNull.Value) wH_Sample.Sample_Feedback = Convert.ToString(dr["Sample_Feedback"]);
            if (dr["Sample_FeedbackDate"] != DBNull.Value) wH_Sample.Sample_FeedbackDate = Convert.ToDateTime(dr["Sample_FeedbackDate"]);
            if (dr["Sample_IsRef"] != DBNull.Value) wH_Sample.Sample_IsRef = Convert.ToString(dr["Sample_IsRef"]);
            if (dr["Sample_State"] != DBNull.Value) wH_Sample.Sample_State = Convert.ToString(dr["Sample_State"]);
            if (dr["Sample_Type"] != DBNull.Value) wH_Sample.Sample_Type = Convert.ToString(dr["Sample_Type"]);
            if (dr["Stat"] != DBNull.Value) wH_Sample.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Sample.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Sample.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Sample.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_Sample);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
