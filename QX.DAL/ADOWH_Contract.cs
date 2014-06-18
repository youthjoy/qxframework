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
   /// 合同主数据
   /// </summary>
   [Serializable]
   public partial class ADOWH_Contract
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加合同主数据 WH_Contract对象(即:一条记录)
      /// </summary>
      public int Add(WH_Contract wH_Contract)
      {
         string sql = "INSERT INTO WH_Contract (Contract_Code,Contract_Name,Contract_Func,Contract_CustCode,Contract_CustName,Contract_Type,Contract_Abs,Contract_Start,Contract_End,Contract_Sum,VerifyStep,Contract_RefType,Contract_RefCode,VerifyStuff,VerifyStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Contract_Code,@Contract_Name,@Contract_Func,@Contract_CustCode,@Contract_CustName,@Contract_Type,@Contract_Abs,@Contract_Start,@Contract_End,@Contract_Sum,@VerifyStep,@Contract_RefType,@Contract_RefCode,@VerifyStuff,@VerifyStat,@VerifyDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(wH_Contract.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", wH_Contract.Contract_Code);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Name))
         {
            idb.AddParameter("@Contract_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Name", wH_Contract.Contract_Name);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Func))
         {
            idb.AddParameter("@Contract_Func", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Func", wH_Contract.Contract_Func);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_CustCode))
         {
            idb.AddParameter("@Contract_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustCode", wH_Contract.Contract_CustCode);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_CustName))
         {
            idb.AddParameter("@Contract_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustName", wH_Contract.Contract_CustName);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Type))
         {
            idb.AddParameter("@Contract_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Type", wH_Contract.Contract_Type);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Abs))
         {
            idb.AddParameter("@Contract_Abs", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Abs", wH_Contract.Contract_Abs);
         }
         if (wH_Contract.Contract_Start == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Start", wH_Contract.Contract_Start);
         }
         if (wH_Contract.Contract_End == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_End", wH_Contract.Contract_End);
         }
         if (wH_Contract.Contract_Sum == 0)
         {
            idb.AddParameter("@Contract_Sum", 0);
         }
         else
         {
            idb.AddParameter("@Contract_Sum", wH_Contract.Contract_Sum);
         }
         if (string.IsNullOrEmpty(wH_Contract.VerifyStep))
         {
            idb.AddParameter("@VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStep", wH_Contract.VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_RefType))
         {
            idb.AddParameter("@Contract_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_RefType", wH_Contract.Contract_RefType);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_RefCode))
         {
            idb.AddParameter("@Contract_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_RefCode", wH_Contract.Contract_RefCode);
         }
         if (string.IsNullOrEmpty(wH_Contract.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", wH_Contract.VerifyStuff);
         }
         if (string.IsNullOrEmpty(wH_Contract.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", wH_Contract.VerifyStat);
         }
         if (wH_Contract.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", wH_Contract.VerifyDate);
         }
         if (wH_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Contract.Stat);
         }
         if (wH_Contract.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Contract.CreateDate);
         }
         if (wH_Contract.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Contract.UpdateDate);
         }
         if (wH_Contract.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Contract.DeleteDate);
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
      /// 添加合同主数据 WH_Contract对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Contract wH_Contract)
      {
         string sql = "INSERT INTO WH_Contract (Contract_Code,Contract_Name,Contract_Func,Contract_CustCode,Contract_CustName,Contract_Type,Contract_Abs,Contract_Start,Contract_End,Contract_Sum,VerifyStep,Contract_RefType,Contract_RefCode,VerifyStuff,VerifyStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Contract_Code,@Contract_Name,@Contract_Func,@Contract_CustCode,@Contract_CustName,@Contract_Type,@Contract_Abs,@Contract_Start,@Contract_End,@Contract_Sum,@VerifyStep,@Contract_RefType,@Contract_RefCode,@VerifyStuff,@VerifyStat,@VerifyDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Contract.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", wH_Contract.Contract_Code);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Name))
         {
            idb.AddParameter("@Contract_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Name", wH_Contract.Contract_Name);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Func))
         {
            idb.AddParameter("@Contract_Func", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Func", wH_Contract.Contract_Func);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_CustCode))
         {
            idb.AddParameter("@Contract_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustCode", wH_Contract.Contract_CustCode);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_CustName))
         {
            idb.AddParameter("@Contract_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustName", wH_Contract.Contract_CustName);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Type))
         {
            idb.AddParameter("@Contract_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Type", wH_Contract.Contract_Type);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_Abs))
         {
            idb.AddParameter("@Contract_Abs", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Abs", wH_Contract.Contract_Abs);
         }
         if (wH_Contract.Contract_Start == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Start", wH_Contract.Contract_Start);
         }
         if (wH_Contract.Contract_End == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_End", wH_Contract.Contract_End);
         }
         if (wH_Contract.Contract_Sum == 0)
         {
            idb.AddParameter("@Contract_Sum", 0);
         }
         else
         {
            idb.AddParameter("@Contract_Sum", wH_Contract.Contract_Sum);
         }
         if (string.IsNullOrEmpty(wH_Contract.VerifyStep))
         {
            idb.AddParameter("@VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStep", wH_Contract.VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_RefType))
         {
            idb.AddParameter("@Contract_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_RefType", wH_Contract.Contract_RefType);
         }
         if (string.IsNullOrEmpty(wH_Contract.Contract_RefCode))
         {
            idb.AddParameter("@Contract_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_RefCode", wH_Contract.Contract_RefCode);
         }
         if (string.IsNullOrEmpty(wH_Contract.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", wH_Contract.VerifyStuff);
         }
         if (string.IsNullOrEmpty(wH_Contract.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", wH_Contract.VerifyStat);
         }
         if (wH_Contract.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", wH_Contract.VerifyDate);
         }
         if (wH_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Contract.Stat);
         }
         if (wH_Contract.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Contract.CreateDate);
         }
         if (wH_Contract.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Contract.UpdateDate);
         }
         if (wH_Contract.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Contract.DeleteDate);
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
      /// 更新合同主数据 WH_Contract对象(即:一条记录
      /// </summary>
      public int Update(WH_Contract wH_Contract)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Contract       SET ");
            if(wH_Contract.Contract_Code_IsChanged){sbParameter.Append("Contract_Code=@Contract_Code, ");}
      if(wH_Contract.Contract_Name_IsChanged){sbParameter.Append("Contract_Name=@Contract_Name, ");}
      if(wH_Contract.Contract_Func_IsChanged){sbParameter.Append("Contract_Func=@Contract_Func, ");}
      if(wH_Contract.Contract_CustCode_IsChanged){sbParameter.Append("Contract_CustCode=@Contract_CustCode, ");}
      if(wH_Contract.Contract_CustName_IsChanged){sbParameter.Append("Contract_CustName=@Contract_CustName, ");}
      if(wH_Contract.Contract_Type_IsChanged){sbParameter.Append("Contract_Type=@Contract_Type, ");}
      if(wH_Contract.Contract_Abs_IsChanged){sbParameter.Append("Contract_Abs=@Contract_Abs, ");}
      if(wH_Contract.Contract_Start_IsChanged){sbParameter.Append("Contract_Start=@Contract_Start, ");}
      if(wH_Contract.Contract_End_IsChanged){sbParameter.Append("Contract_End=@Contract_End, ");}
      if(wH_Contract.Contract_Sum_IsChanged){sbParameter.Append("Contract_Sum=@Contract_Sum, ");}
      if(wH_Contract.VerifyStep_IsChanged){sbParameter.Append("VerifyStep=@VerifyStep, ");}
      if(wH_Contract.Contract_RefType_IsChanged){sbParameter.Append("Contract_RefType=@Contract_RefType, ");}
      if(wH_Contract.Contract_RefCode_IsChanged){sbParameter.Append("Contract_RefCode=@Contract_RefCode, ");}
      if(wH_Contract.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(wH_Contract.VerifyStat_IsChanged){sbParameter.Append("VerifyStat=@VerifyStat, ");}
      if(wH_Contract.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(wH_Contract.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Contract.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Contract.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Contract.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Contract_ID=@Contract_ID; " );
      string sql=sb.ToString();
         if(wH_Contract.Contract_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", wH_Contract.Contract_Code);
         }
          }
         if(wH_Contract.Contract_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_Name))
         {
            idb.AddParameter("@Contract_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Name", wH_Contract.Contract_Name);
         }
          }
         if(wH_Contract.Contract_Func_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_Func))
         {
            idb.AddParameter("@Contract_Func", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Func", wH_Contract.Contract_Func);
         }
          }
         if(wH_Contract.Contract_CustCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_CustCode))
         {
            idb.AddParameter("@Contract_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustCode", wH_Contract.Contract_CustCode);
         }
          }
         if(wH_Contract.Contract_CustName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_CustName))
         {
            idb.AddParameter("@Contract_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustName", wH_Contract.Contract_CustName);
         }
          }
         if(wH_Contract.Contract_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_Type))
         {
            idb.AddParameter("@Contract_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Type", wH_Contract.Contract_Type);
         }
          }
         if(wH_Contract.Contract_Abs_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_Abs))
         {
            idb.AddParameter("@Contract_Abs", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Abs", wH_Contract.Contract_Abs);
         }
          }
         if(wH_Contract.Contract_Start_IsChanged)
         {
         if (wH_Contract.Contract_Start == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Start", wH_Contract.Contract_Start);
         }
          }
         if(wH_Contract.Contract_End_IsChanged)
         {
         if (wH_Contract.Contract_End == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_End", wH_Contract.Contract_End);
         }
          }
         if(wH_Contract.Contract_Sum_IsChanged)
         {
         if (wH_Contract.Contract_Sum == 0)
         {
            idb.AddParameter("@Contract_Sum", 0);
         }
         else
         {
            idb.AddParameter("@Contract_Sum", wH_Contract.Contract_Sum);
         }
          }
         if(wH_Contract.VerifyStep_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.VerifyStep))
         {
            idb.AddParameter("@VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStep", wH_Contract.VerifyStep);
         }
          }
         if(wH_Contract.Contract_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_RefType))
         {
            idb.AddParameter("@Contract_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_RefType", wH_Contract.Contract_RefType);
         }
          }
         if(wH_Contract.Contract_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.Contract_RefCode))
         {
            idb.AddParameter("@Contract_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_RefCode", wH_Contract.Contract_RefCode);
         }
          }
         if(wH_Contract.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", wH_Contract.VerifyStuff);
         }
          }
         if(wH_Contract.VerifyStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Contract.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", wH_Contract.VerifyStat);
         }
          }
         if(wH_Contract.VerifyDate_IsChanged)
         {
         if (wH_Contract.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", wH_Contract.VerifyDate);
         }
          }
         if(wH_Contract.Stat_IsChanged)
         {
         if (wH_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Contract.Stat);
         }
          }
         if(wH_Contract.CreateDate_IsChanged)
         {
         if (wH_Contract.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Contract.CreateDate);
         }
          }
         if(wH_Contract.UpdateDate_IsChanged)
         {
         if (wH_Contract.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Contract.UpdateDate);
         }
          }
         if(wH_Contract.DeleteDate_IsChanged)
         {
         if (wH_Contract.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Contract.DeleteDate);
         }
          }

         idb.AddParameter("@Contract_ID", wH_Contract.Contract_ID);

           
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
      /// 删除合同主数据 WH_Contract对象(即:一条记录
      /// </summary>
      public int Delete(decimal contract_ID)
      {
         string sql = "DELETE WH_Contract WHERE 1=1  AND Contract_ID=@Contract_ID ";
         idb.AddParameter("@Contract_ID", contract_ID);

           
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
      /// 获取指定的合同主数据 WH_Contract对象(即:一条记录
      /// </summary>
      public WH_Contract GetByKey(decimal contract_ID)
      {
         WH_Contract wH_Contract = new WH_Contract();
         string sql = "SELECT  Contract_ID,Contract_Code,Contract_Name,Contract_Func,Contract_CustCode,Contract_CustName,Contract_Type,Contract_Abs,Contract_Start,Contract_End,Contract_Sum,VerifyStep,Contract_RefType,Contract_RefCode,VerifyStuff,VerifyStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_Contract WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Contract_ID=@Contract_ID ";
         idb.AddParameter("@Contract_ID", contract_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Contract_ID"] != DBNull.Value) wH_Contract.Contract_ID = Convert.ToDecimal(dr["Contract_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) wH_Contract.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Contract_Name"] != DBNull.Value) wH_Contract.Contract_Name = Convert.ToString(dr["Contract_Name"]);
            if (dr["Contract_Func"] != DBNull.Value) wH_Contract.Contract_Func = Convert.ToString(dr["Contract_Func"]);
            if (dr["Contract_CustCode"] != DBNull.Value) wH_Contract.Contract_CustCode = Convert.ToString(dr["Contract_CustCode"]);
            if (dr["Contract_CustName"] != DBNull.Value) wH_Contract.Contract_CustName = Convert.ToString(dr["Contract_CustName"]);
            if (dr["Contract_Type"] != DBNull.Value) wH_Contract.Contract_Type = Convert.ToString(dr["Contract_Type"]);
            if (dr["Contract_Abs"] != DBNull.Value) wH_Contract.Contract_Abs = Convert.ToString(dr["Contract_Abs"]);
            if (dr["Contract_Start"] != DBNull.Value) wH_Contract.Contract_Start = Convert.ToDateTime(dr["Contract_Start"]);
            if (dr["Contract_End"] != DBNull.Value) wH_Contract.Contract_End = Convert.ToDateTime(dr["Contract_End"]);
            if (dr["Contract_Sum"] != DBNull.Value) wH_Contract.Contract_Sum = Convert.ToDecimal(dr["Contract_Sum"]);
            if (dr["VerifyStep"] != DBNull.Value) wH_Contract.VerifyStep = Convert.ToString(dr["VerifyStep"]);
            if (dr["Contract_RefType"] != DBNull.Value) wH_Contract.Contract_RefType = Convert.ToString(dr["Contract_RefType"]);
            if (dr["Contract_RefCode"] != DBNull.Value) wH_Contract.Contract_RefCode = Convert.ToString(dr["Contract_RefCode"]);
            if (dr["VerifyStuff"] != DBNull.Value) wH_Contract.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyStat"] != DBNull.Value) wH_Contract.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) wH_Contract.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) wH_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Contract.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Contract.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Contract.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Contract;
      }
      /// <summary>
      /// 获取指定的合同主数据 WH_Contract对象集合
      /// </summary>
      public List<WH_Contract> GetListByWhere(string strCondition)
      {
         List<WH_Contract> ret = new List<WH_Contract>();
         string sql = "SELECT  Contract_ID,Contract_Code,Contract_Name,Contract_Func,Contract_CustCode,Contract_CustName,Contract_Type,Contract_Abs,Contract_Start,Contract_End,Contract_Sum,VerifyStep,Contract_RefType,Contract_RefCode,VerifyStuff,VerifyStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_Contract WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Contract wH_Contract = new WH_Contract();
            if (dr["Contract_ID"] != DBNull.Value) wH_Contract.Contract_ID = Convert.ToDecimal(dr["Contract_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) wH_Contract.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Contract_Name"] != DBNull.Value) wH_Contract.Contract_Name = Convert.ToString(dr["Contract_Name"]);
            if (dr["Contract_Func"] != DBNull.Value) wH_Contract.Contract_Func = Convert.ToString(dr["Contract_Func"]);
            if (dr["Contract_CustCode"] != DBNull.Value) wH_Contract.Contract_CustCode = Convert.ToString(dr["Contract_CustCode"]);
            if (dr["Contract_CustName"] != DBNull.Value) wH_Contract.Contract_CustName = Convert.ToString(dr["Contract_CustName"]);
            if (dr["Contract_Type"] != DBNull.Value) wH_Contract.Contract_Type = Convert.ToString(dr["Contract_Type"]);
            if (dr["Contract_Abs"] != DBNull.Value) wH_Contract.Contract_Abs = Convert.ToString(dr["Contract_Abs"]);
            if (dr["Contract_Start"] != DBNull.Value) wH_Contract.Contract_Start = Convert.ToDateTime(dr["Contract_Start"]);
            if (dr["Contract_End"] != DBNull.Value) wH_Contract.Contract_End = Convert.ToDateTime(dr["Contract_End"]);
            if (dr["Contract_Sum"] != DBNull.Value) wH_Contract.Contract_Sum = Convert.ToDecimal(dr["Contract_Sum"]);
            if (dr["VerifyStep"] != DBNull.Value) wH_Contract.VerifyStep = Convert.ToString(dr["VerifyStep"]);
            if (dr["Contract_RefType"] != DBNull.Value) wH_Contract.Contract_RefType = Convert.ToString(dr["Contract_RefType"]);
            if (dr["Contract_RefCode"] != DBNull.Value) wH_Contract.Contract_RefCode = Convert.ToString(dr["Contract_RefCode"]);
            if (dr["VerifyStuff"] != DBNull.Value) wH_Contract.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyStat"] != DBNull.Value) wH_Contract.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) wH_Contract.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) wH_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Contract.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Contract.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Contract.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_Contract);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的合同主数据 WH_Contract对象(即:一条记录
      /// </summary>
      public List<WH_Contract> GetAll()
      {
         List<WH_Contract> ret = new List<WH_Contract>();
         string sql = "SELECT  Contract_ID,Contract_Code,Contract_Name,Contract_Func,Contract_CustCode,Contract_CustName,Contract_Type,Contract_Abs,Contract_Start,Contract_End,Contract_Sum,VerifyStep,Contract_RefType,Contract_RefCode,VerifyStuff,VerifyStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_Contract where 1=1 AND ((Stat is null) or (Stat=0) ) order by Contract_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Contract wH_Contract = new WH_Contract();
            if (dr["Contract_ID"] != DBNull.Value) wH_Contract.Contract_ID = Convert.ToDecimal(dr["Contract_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) wH_Contract.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Contract_Name"] != DBNull.Value) wH_Contract.Contract_Name = Convert.ToString(dr["Contract_Name"]);
            if (dr["Contract_Func"] != DBNull.Value) wH_Contract.Contract_Func = Convert.ToString(dr["Contract_Func"]);
            if (dr["Contract_CustCode"] != DBNull.Value) wH_Contract.Contract_CustCode = Convert.ToString(dr["Contract_CustCode"]);
            if (dr["Contract_CustName"] != DBNull.Value) wH_Contract.Contract_CustName = Convert.ToString(dr["Contract_CustName"]);
            if (dr["Contract_Type"] != DBNull.Value) wH_Contract.Contract_Type = Convert.ToString(dr["Contract_Type"]);
            if (dr["Contract_Abs"] != DBNull.Value) wH_Contract.Contract_Abs = Convert.ToString(dr["Contract_Abs"]);
            if (dr["Contract_Start"] != DBNull.Value) wH_Contract.Contract_Start = Convert.ToDateTime(dr["Contract_Start"]);
            if (dr["Contract_End"] != DBNull.Value) wH_Contract.Contract_End = Convert.ToDateTime(dr["Contract_End"]);
            if (dr["Contract_Sum"] != DBNull.Value) wH_Contract.Contract_Sum = Convert.ToDecimal(dr["Contract_Sum"]);
            if (dr["VerifyStep"] != DBNull.Value) wH_Contract.VerifyStep = Convert.ToString(dr["VerifyStep"]);
            if (dr["Contract_RefType"] != DBNull.Value) wH_Contract.Contract_RefType = Convert.ToString(dr["Contract_RefType"]);
            if (dr["Contract_RefCode"] != DBNull.Value) wH_Contract.Contract_RefCode = Convert.ToString(dr["Contract_RefCode"]);
            if (dr["VerifyStuff"] != DBNull.Value) wH_Contract.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyStat"] != DBNull.Value) wH_Contract.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) wH_Contract.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) wH_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Contract.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Contract.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Contract.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_Contract);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
