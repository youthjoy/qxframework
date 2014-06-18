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
   /// 结算单关联表
   /// </summary>
   [Serializable]
   public partial class ADOWH_BanlanceRelate
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加结算单关联表 WH_BanlanceRelate对象(即:一条记录)
      /// </summary>
      public int Add(WH_BanlanceRelate wH_BanlanceRelate)
      {
         string sql = "INSERT INTO WH_BanlanceRelate (WHR_Code,WHR_Period,WHR_BCode,WHR_BType,WHR_BCurMonth,WHR_RefType,WHR_RefCode,WHR_RefDMoney,WHR_RefRMoney,WHR_Operator,CreateDate,UpdateDate,DeleteDate,Stat,WHR_UDEF1,WHR_UDEF2,WHR_UDEF3,WHR_UDEF4,WHR_UDEF5,WHR_UDEF6,WHR_UDEF7,WHR_UDEF8,WHR_UDEF9,WHR_UDEF10) VALUES (@WHR_Code,@WHR_Period,@WHR_BCode,@WHR_BType,@WHR_BCurMonth,@WHR_RefType,@WHR_RefCode,@WHR_RefDMoney,@WHR_RefRMoney,@WHR_Operator,@CreateDate,@UpdateDate,@DeleteDate,@Stat,@WHR_UDEF1,@WHR_UDEF2,@WHR_UDEF3,@WHR_UDEF4,@WHR_UDEF5,@WHR_UDEF6,@WHR_UDEF7,@WHR_UDEF8,@WHR_UDEF9,@WHR_UDEF10)";
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Code))
         {
            idb.AddParameter("@WHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Code", wH_BanlanceRelate.WHR_Code);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Period))
         {
            idb.AddParameter("@WHR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Period", wH_BanlanceRelate.WHR_Period);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_BCode))
         {
            idb.AddParameter("@WHR_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_BCode", wH_BanlanceRelate.WHR_BCode);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_BType))
         {
            idb.AddParameter("@WHR_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_BType", wH_BanlanceRelate.WHR_BType);
         }
         if (wH_BanlanceRelate.WHR_BCurMonth == 0)
         {
            idb.AddParameter("@WHR_BCurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHR_BCurMonth", wH_BanlanceRelate.WHR_BCurMonth);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_RefType))
         {
            idb.AddParameter("@WHR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_RefType", wH_BanlanceRelate.WHR_RefType);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_RefCode))
         {
            idb.AddParameter("@WHR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_RefCode", wH_BanlanceRelate.WHR_RefCode);
         }
         if (wH_BanlanceRelate.WHR_RefDMoney == 0)
         {
            idb.AddParameter("@WHR_RefDMoney", 0);
         }
         else
         {
            idb.AddParameter("@WHR_RefDMoney", wH_BanlanceRelate.WHR_RefDMoney);
         }
         if (wH_BanlanceRelate.WHR_RefRMoney == 0)
         {
            idb.AddParameter("@WHR_RefRMoney", 0);
         }
         else
         {
            idb.AddParameter("@WHR_RefRMoney", wH_BanlanceRelate.WHR_RefRMoney);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Operator))
         {
            idb.AddParameter("@WHR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Operator", wH_BanlanceRelate.WHR_Operator);
         }
         if (wH_BanlanceRelate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanlanceRelate.CreateDate);
         }
         if (wH_BanlanceRelate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanlanceRelate.UpdateDate);
         }
         if (wH_BanlanceRelate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanlanceRelate.DeleteDate);
         }
         if (wH_BanlanceRelate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanlanceRelate.Stat);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF1))
         {
            idb.AddParameter("@WHR_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF1", wH_BanlanceRelate.WHR_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF2))
         {
            idb.AddParameter("@WHR_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF2", wH_BanlanceRelate.WHR_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF3))
         {
            idb.AddParameter("@WHR_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF3", wH_BanlanceRelate.WHR_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF4))
         {
            idb.AddParameter("@WHR_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF4", wH_BanlanceRelate.WHR_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF5))
         {
            idb.AddParameter("@WHR_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF5", wH_BanlanceRelate.WHR_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF6))
         {
            idb.AddParameter("@WHR_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF6", wH_BanlanceRelate.WHR_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF7))
         {
            idb.AddParameter("@WHR_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF7", wH_BanlanceRelate.WHR_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF8))
         {
            idb.AddParameter("@WHR_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF8", wH_BanlanceRelate.WHR_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF9))
         {
            idb.AddParameter("@WHR_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF9", wH_BanlanceRelate.WHR_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF10))
         {
            idb.AddParameter("@WHR_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF10", wH_BanlanceRelate.WHR_UDEF10);
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
      /// 添加结算单关联表 WH_BanlanceRelate对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_BanlanceRelate wH_BanlanceRelate)
      {
         string sql = "INSERT INTO WH_BanlanceRelate (WHR_Code,WHR_Period,WHR_BCode,WHR_BType,WHR_BCurMonth,WHR_RefType,WHR_RefCode,WHR_RefDMoney,WHR_RefRMoney,WHR_Operator,CreateDate,UpdateDate,DeleteDate,Stat,WHR_UDEF1,WHR_UDEF2,WHR_UDEF3,WHR_UDEF4,WHR_UDEF5,WHR_UDEF6,WHR_UDEF7,WHR_UDEF8,WHR_UDEF9,WHR_UDEF10) VALUES (@WHR_Code,@WHR_Period,@WHR_BCode,@WHR_BType,@WHR_BCurMonth,@WHR_RefType,@WHR_RefCode,@WHR_RefDMoney,@WHR_RefRMoney,@WHR_Operator,@CreateDate,@UpdateDate,@DeleteDate,@Stat,@WHR_UDEF1,@WHR_UDEF2,@WHR_UDEF3,@WHR_UDEF4,@WHR_UDEF5,@WHR_UDEF6,@WHR_UDEF7,@WHR_UDEF8,@WHR_UDEF9,@WHR_UDEF10);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Code))
         {
            idb.AddParameter("@WHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Code", wH_BanlanceRelate.WHR_Code);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Period))
         {
            idb.AddParameter("@WHR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Period", wH_BanlanceRelate.WHR_Period);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_BCode))
         {
            idb.AddParameter("@WHR_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_BCode", wH_BanlanceRelate.WHR_BCode);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_BType))
         {
            idb.AddParameter("@WHR_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_BType", wH_BanlanceRelate.WHR_BType);
         }
         if (wH_BanlanceRelate.WHR_BCurMonth == 0)
         {
            idb.AddParameter("@WHR_BCurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHR_BCurMonth", wH_BanlanceRelate.WHR_BCurMonth);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_RefType))
         {
            idb.AddParameter("@WHR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_RefType", wH_BanlanceRelate.WHR_RefType);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_RefCode))
         {
            idb.AddParameter("@WHR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_RefCode", wH_BanlanceRelate.WHR_RefCode);
         }
         if (wH_BanlanceRelate.WHR_RefDMoney == 0)
         {
            idb.AddParameter("@WHR_RefDMoney", 0);
         }
         else
         {
            idb.AddParameter("@WHR_RefDMoney", wH_BanlanceRelate.WHR_RefDMoney);
         }
         if (wH_BanlanceRelate.WHR_RefRMoney == 0)
         {
            idb.AddParameter("@WHR_RefRMoney", 0);
         }
         else
         {
            idb.AddParameter("@WHR_RefRMoney", wH_BanlanceRelate.WHR_RefRMoney);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Operator))
         {
            idb.AddParameter("@WHR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Operator", wH_BanlanceRelate.WHR_Operator);
         }
         if (wH_BanlanceRelate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanlanceRelate.CreateDate);
         }
         if (wH_BanlanceRelate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanlanceRelate.UpdateDate);
         }
         if (wH_BanlanceRelate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanlanceRelate.DeleteDate);
         }
         if (wH_BanlanceRelate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanlanceRelate.Stat);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF1))
         {
            idb.AddParameter("@WHR_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF1", wH_BanlanceRelate.WHR_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF2))
         {
            idb.AddParameter("@WHR_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF2", wH_BanlanceRelate.WHR_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF3))
         {
            idb.AddParameter("@WHR_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF3", wH_BanlanceRelate.WHR_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF4))
         {
            idb.AddParameter("@WHR_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF4", wH_BanlanceRelate.WHR_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF5))
         {
            idb.AddParameter("@WHR_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF5", wH_BanlanceRelate.WHR_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF6))
         {
            idb.AddParameter("@WHR_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF6", wH_BanlanceRelate.WHR_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF7))
         {
            idb.AddParameter("@WHR_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF7", wH_BanlanceRelate.WHR_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF8))
         {
            idb.AddParameter("@WHR_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF8", wH_BanlanceRelate.WHR_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF9))
         {
            idb.AddParameter("@WHR_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF9", wH_BanlanceRelate.WHR_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF10))
         {
            idb.AddParameter("@WHR_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF10", wH_BanlanceRelate.WHR_UDEF10);
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
      /// 更新结算单关联表 WH_BanlanceRelate对象(即:一条记录
      /// </summary>
      public int Update(WH_BanlanceRelate wH_BanlanceRelate)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_BanlanceRelate       SET ");
            if(wH_BanlanceRelate.WHR_Code_IsChanged){sbParameter.Append("WHR_Code=@WHR_Code, ");}
      if(wH_BanlanceRelate.WHR_Period_IsChanged){sbParameter.Append("WHR_Period=@WHR_Period, ");}
      if(wH_BanlanceRelate.WHR_BCode_IsChanged){sbParameter.Append("WHR_BCode=@WHR_BCode, ");}
      if(wH_BanlanceRelate.WHR_BType_IsChanged){sbParameter.Append("WHR_BType=@WHR_BType, ");}
      if(wH_BanlanceRelate.WHR_BCurMonth_IsChanged){sbParameter.Append("WHR_BCurMonth=@WHR_BCurMonth, ");}
      if(wH_BanlanceRelate.WHR_RefType_IsChanged){sbParameter.Append("WHR_RefType=@WHR_RefType, ");}
      if(wH_BanlanceRelate.WHR_RefCode_IsChanged){sbParameter.Append("WHR_RefCode=@WHR_RefCode, ");}
      if(wH_BanlanceRelate.WHR_RefDMoney_IsChanged){sbParameter.Append("WHR_RefDMoney=@WHR_RefDMoney, ");}
      if(wH_BanlanceRelate.WHR_RefRMoney_IsChanged){sbParameter.Append("WHR_RefRMoney=@WHR_RefRMoney, ");}
      if(wH_BanlanceRelate.WHR_Operator_IsChanged){sbParameter.Append("WHR_Operator=@WHR_Operator, ");}
      if(wH_BanlanceRelate.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_BanlanceRelate.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_BanlanceRelate.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_BanlanceRelate.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_BanlanceRelate.WHR_UDEF1_IsChanged){sbParameter.Append("WHR_UDEF1=@WHR_UDEF1, ");}
      if(wH_BanlanceRelate.WHR_UDEF2_IsChanged){sbParameter.Append("WHR_UDEF2=@WHR_UDEF2, ");}
      if(wH_BanlanceRelate.WHR_UDEF3_IsChanged){sbParameter.Append("WHR_UDEF3=@WHR_UDEF3, ");}
      if(wH_BanlanceRelate.WHR_UDEF4_IsChanged){sbParameter.Append("WHR_UDEF4=@WHR_UDEF4, ");}
      if(wH_BanlanceRelate.WHR_UDEF5_IsChanged){sbParameter.Append("WHR_UDEF5=@WHR_UDEF5, ");}
      if(wH_BanlanceRelate.WHR_UDEF6_IsChanged){sbParameter.Append("WHR_UDEF6=@WHR_UDEF6, ");}
      if(wH_BanlanceRelate.WHR_UDEF7_IsChanged){sbParameter.Append("WHR_UDEF7=@WHR_UDEF7, ");}
      if(wH_BanlanceRelate.WHR_UDEF8_IsChanged){sbParameter.Append("WHR_UDEF8=@WHR_UDEF8, ");}
      if(wH_BanlanceRelate.WHR_UDEF9_IsChanged){sbParameter.Append("WHR_UDEF9=@WHR_UDEF9, ");}
      if(wH_BanlanceRelate.WHR_UDEF10_IsChanged){sbParameter.Append("WHR_UDEF10=@WHR_UDEF10 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHR_ID=@WHR_ID; " );
      string sql=sb.ToString();
         if(wH_BanlanceRelate.WHR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Code))
         {
            idb.AddParameter("@WHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Code", wH_BanlanceRelate.WHR_Code);
         }
          }
         if(wH_BanlanceRelate.WHR_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Period))
         {
            idb.AddParameter("@WHR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Period", wH_BanlanceRelate.WHR_Period);
         }
          }
         if(wH_BanlanceRelate.WHR_BCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_BCode))
         {
            idb.AddParameter("@WHR_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_BCode", wH_BanlanceRelate.WHR_BCode);
         }
          }
         if(wH_BanlanceRelate.WHR_BType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_BType))
         {
            idb.AddParameter("@WHR_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_BType", wH_BanlanceRelate.WHR_BType);
         }
          }
         if(wH_BanlanceRelate.WHR_BCurMonth_IsChanged)
         {
         if (wH_BanlanceRelate.WHR_BCurMonth == 0)
         {
            idb.AddParameter("@WHR_BCurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHR_BCurMonth", wH_BanlanceRelate.WHR_BCurMonth);
         }
          }
         if(wH_BanlanceRelate.WHR_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_RefType))
         {
            idb.AddParameter("@WHR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_RefType", wH_BanlanceRelate.WHR_RefType);
         }
          }
         if(wH_BanlanceRelate.WHR_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_RefCode))
         {
            idb.AddParameter("@WHR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_RefCode", wH_BanlanceRelate.WHR_RefCode);
         }
          }
         if(wH_BanlanceRelate.WHR_RefDMoney_IsChanged)
         {
         if (wH_BanlanceRelate.WHR_RefDMoney == 0)
         {
            idb.AddParameter("@WHR_RefDMoney", 0);
         }
         else
         {
            idb.AddParameter("@WHR_RefDMoney", wH_BanlanceRelate.WHR_RefDMoney);
         }
          }
         if(wH_BanlanceRelate.WHR_RefRMoney_IsChanged)
         {
         if (wH_BanlanceRelate.WHR_RefRMoney == 0)
         {
            idb.AddParameter("@WHR_RefRMoney", 0);
         }
         else
         {
            idb.AddParameter("@WHR_RefRMoney", wH_BanlanceRelate.WHR_RefRMoney);
         }
          }
         if(wH_BanlanceRelate.WHR_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_Operator))
         {
            idb.AddParameter("@WHR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Operator", wH_BanlanceRelate.WHR_Operator);
         }
          }
         if(wH_BanlanceRelate.CreateDate_IsChanged)
         {
         if (wH_BanlanceRelate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanlanceRelate.CreateDate);
         }
          }
         if(wH_BanlanceRelate.UpdateDate_IsChanged)
         {
         if (wH_BanlanceRelate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanlanceRelate.UpdateDate);
         }
          }
         if(wH_BanlanceRelate.DeleteDate_IsChanged)
         {
         if (wH_BanlanceRelate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanlanceRelate.DeleteDate);
         }
          }
         if(wH_BanlanceRelate.Stat_IsChanged)
         {
         if (wH_BanlanceRelate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanlanceRelate.Stat);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF1))
         {
            idb.AddParameter("@WHR_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF1", wH_BanlanceRelate.WHR_UDEF1);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF2))
         {
            idb.AddParameter("@WHR_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF2", wH_BanlanceRelate.WHR_UDEF2);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF3))
         {
            idb.AddParameter("@WHR_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF3", wH_BanlanceRelate.WHR_UDEF3);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF4))
         {
            idb.AddParameter("@WHR_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF4", wH_BanlanceRelate.WHR_UDEF4);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF5))
         {
            idb.AddParameter("@WHR_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF5", wH_BanlanceRelate.WHR_UDEF5);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF6))
         {
            idb.AddParameter("@WHR_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF6", wH_BanlanceRelate.WHR_UDEF6);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF7))
         {
            idb.AddParameter("@WHR_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF7", wH_BanlanceRelate.WHR_UDEF7);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF8))
         {
            idb.AddParameter("@WHR_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF8", wH_BanlanceRelate.WHR_UDEF8);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF9))
         {
            idb.AddParameter("@WHR_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF9", wH_BanlanceRelate.WHR_UDEF9);
         }
          }
         if(wH_BanlanceRelate.WHR_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanlanceRelate.WHR_UDEF10))
         {
            idb.AddParameter("@WHR_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_UDEF10", wH_BanlanceRelate.WHR_UDEF10);
         }
          }

         idb.AddParameter("@WHR_ID", wH_BanlanceRelate.WHR_ID);

           
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
      /// 删除结算单关联表 WH_BanlanceRelate对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHR_ID)
      {
         string sql = "DELETE WH_BanlanceRelate WHERE 1=1  AND WHR_ID=@WHR_ID ";
         idb.AddParameter("@WHR_ID", wHR_ID);

           
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
      /// 获取指定的结算单关联表 WH_BanlanceRelate对象(即:一条记录
      /// </summary>
      public WH_BanlanceRelate GetByKey(decimal wHR_ID)
      {
         WH_BanlanceRelate wH_BanlanceRelate = new WH_BanlanceRelate();
         string sql = "SELECT  WHR_ID,WHR_Code,WHR_Period,WHR_BCode,WHR_BType,WHR_BCurMonth,WHR_RefType,WHR_RefCode,WHR_RefDMoney,WHR_RefRMoney,WHR_Operator,CreateDate,UpdateDate,DeleteDate,Stat,WHR_UDEF1,WHR_UDEF2,WHR_UDEF3,WHR_UDEF4,WHR_UDEF5,WHR_UDEF6,WHR_UDEF7,WHR_UDEF8,WHR_UDEF9,WHR_UDEF10 FROM WH_BanlanceRelate WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHR_ID=@WHR_ID ";
         idb.AddParameter("@WHR_ID", wHR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHR_ID"] != DBNull.Value) wH_BanlanceRelate.WHR_ID = Convert.ToDecimal(dr["WHR_ID"]);
            if (dr["WHR_Code"] != DBNull.Value) wH_BanlanceRelate.WHR_Code = Convert.ToString(dr["WHR_Code"]);
            if (dr["WHR_Period"] != DBNull.Value) wH_BanlanceRelate.WHR_Period = Convert.ToString(dr["WHR_Period"]);
            if (dr["WHR_BCode"] != DBNull.Value) wH_BanlanceRelate.WHR_BCode = Convert.ToString(dr["WHR_BCode"]);
            if (dr["WHR_BType"] != DBNull.Value) wH_BanlanceRelate.WHR_BType = Convert.ToString(dr["WHR_BType"]);
            if (dr["WHR_BCurMonth"] != DBNull.Value) wH_BanlanceRelate.WHR_BCurMonth = Convert.ToDecimal(dr["WHR_BCurMonth"]);
            if (dr["WHR_RefType"] != DBNull.Value) wH_BanlanceRelate.WHR_RefType = Convert.ToString(dr["WHR_RefType"]);
            if (dr["WHR_RefCode"] != DBNull.Value) wH_BanlanceRelate.WHR_RefCode = Convert.ToString(dr["WHR_RefCode"]);
            if (dr["WHR_RefDMoney"] != DBNull.Value) wH_BanlanceRelate.WHR_RefDMoney = Convert.ToDecimal(dr["WHR_RefDMoney"]);
            if (dr["WHR_RefRMoney"] != DBNull.Value) wH_BanlanceRelate.WHR_RefRMoney = Convert.ToDecimal(dr["WHR_RefRMoney"]);
            if (dr["WHR_Operator"] != DBNull.Value) wH_BanlanceRelate.WHR_Operator = Convert.ToString(dr["WHR_Operator"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanlanceRelate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanlanceRelate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanlanceRelate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) wH_BanlanceRelate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHR_UDEF1"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF1 = Convert.ToString(dr["WHR_UDEF1"]);
            if (dr["WHR_UDEF2"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF2 = Convert.ToString(dr["WHR_UDEF2"]);
            if (dr["WHR_UDEF3"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF3 = Convert.ToString(dr["WHR_UDEF3"]);
            if (dr["WHR_UDEF4"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF4 = Convert.ToString(dr["WHR_UDEF4"]);
            if (dr["WHR_UDEF5"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF5 = Convert.ToString(dr["WHR_UDEF5"]);
            if (dr["WHR_UDEF6"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF6 = Convert.ToString(dr["WHR_UDEF6"]);
            if (dr["WHR_UDEF7"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF7 = Convert.ToString(dr["WHR_UDEF7"]);
            if (dr["WHR_UDEF8"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF8 = Convert.ToString(dr["WHR_UDEF8"]);
            if (dr["WHR_UDEF9"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF9 = Convert.ToString(dr["WHR_UDEF9"]);
            if (dr["WHR_UDEF10"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF10 = Convert.ToString(dr["WHR_UDEF10"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_BanlanceRelate;
      }
      /// <summary>
      /// 获取指定的结算单关联表 WH_BanlanceRelate对象集合
      /// </summary>
      public List<WH_BanlanceRelate> GetListByWhere(string strCondition)
      {
         List<WH_BanlanceRelate> ret = new List<WH_BanlanceRelate>();
         string sql = "SELECT  WHR_ID,WHR_Code,WHR_Period,WHR_BCode,WHR_BType,WHR_BCurMonth,WHR_RefType,WHR_RefCode,WHR_RefDMoney,WHR_RefRMoney,WHR_Operator,CreateDate,UpdateDate,DeleteDate,Stat,WHR_UDEF1,WHR_UDEF2,WHR_UDEF3,WHR_UDEF4,WHR_UDEF5,WHR_UDEF6,WHR_UDEF7,WHR_UDEF8,WHR_UDEF9,WHR_UDEF10 FROM WH_BanlanceRelate WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_BanlanceRelate wH_BanlanceRelate = new WH_BanlanceRelate();
            if (dr["WHR_ID"] != DBNull.Value) wH_BanlanceRelate.WHR_ID = Convert.ToDecimal(dr["WHR_ID"]);
            if (dr["WHR_Code"] != DBNull.Value) wH_BanlanceRelate.WHR_Code = Convert.ToString(dr["WHR_Code"]);
            if (dr["WHR_Period"] != DBNull.Value) wH_BanlanceRelate.WHR_Period = Convert.ToString(dr["WHR_Period"]);
            if (dr["WHR_BCode"] != DBNull.Value) wH_BanlanceRelate.WHR_BCode = Convert.ToString(dr["WHR_BCode"]);
            if (dr["WHR_BType"] != DBNull.Value) wH_BanlanceRelate.WHR_BType = Convert.ToString(dr["WHR_BType"]);
            if (dr["WHR_BCurMonth"] != DBNull.Value) wH_BanlanceRelate.WHR_BCurMonth = Convert.ToDecimal(dr["WHR_BCurMonth"]);
            if (dr["WHR_RefType"] != DBNull.Value) wH_BanlanceRelate.WHR_RefType = Convert.ToString(dr["WHR_RefType"]);
            if (dr["WHR_RefCode"] != DBNull.Value) wH_BanlanceRelate.WHR_RefCode = Convert.ToString(dr["WHR_RefCode"]);
            if (dr["WHR_RefDMoney"] != DBNull.Value) wH_BanlanceRelate.WHR_RefDMoney = Convert.ToDecimal(dr["WHR_RefDMoney"]);
            if (dr["WHR_RefRMoney"] != DBNull.Value) wH_BanlanceRelate.WHR_RefRMoney = Convert.ToDecimal(dr["WHR_RefRMoney"]);
            if (dr["WHR_Operator"] != DBNull.Value) wH_BanlanceRelate.WHR_Operator = Convert.ToString(dr["WHR_Operator"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanlanceRelate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanlanceRelate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanlanceRelate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) wH_BanlanceRelate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHR_UDEF1"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF1 = Convert.ToString(dr["WHR_UDEF1"]);
            if (dr["WHR_UDEF2"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF2 = Convert.ToString(dr["WHR_UDEF2"]);
            if (dr["WHR_UDEF3"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF3 = Convert.ToString(dr["WHR_UDEF3"]);
            if (dr["WHR_UDEF4"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF4 = Convert.ToString(dr["WHR_UDEF4"]);
            if (dr["WHR_UDEF5"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF5 = Convert.ToString(dr["WHR_UDEF5"]);
            if (dr["WHR_UDEF6"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF6 = Convert.ToString(dr["WHR_UDEF6"]);
            if (dr["WHR_UDEF7"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF7 = Convert.ToString(dr["WHR_UDEF7"]);
            if (dr["WHR_UDEF8"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF8 = Convert.ToString(dr["WHR_UDEF8"]);
            if (dr["WHR_UDEF9"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF9 = Convert.ToString(dr["WHR_UDEF9"]);
            if (dr["WHR_UDEF10"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF10 = Convert.ToString(dr["WHR_UDEF10"]);
            ret.Add(wH_BanlanceRelate);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的结算单关联表 WH_BanlanceRelate对象(即:一条记录
      /// </summary>
      public List<WH_BanlanceRelate> GetAll()
      {
         List<WH_BanlanceRelate> ret = new List<WH_BanlanceRelate>();
         string sql = "SELECT  WHR_ID,WHR_Code,WHR_Period,WHR_BCode,WHR_BType,WHR_BCurMonth,WHR_RefType,WHR_RefCode,WHR_RefDMoney,WHR_RefRMoney,WHR_Operator,CreateDate,UpdateDate,DeleteDate,Stat,WHR_UDEF1,WHR_UDEF2,WHR_UDEF3,WHR_UDEF4,WHR_UDEF5,WHR_UDEF6,WHR_UDEF7,WHR_UDEF8,WHR_UDEF9,WHR_UDEF10 FROM WH_BanlanceRelate where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_BanlanceRelate wH_BanlanceRelate = new WH_BanlanceRelate();
            if (dr["WHR_ID"] != DBNull.Value) wH_BanlanceRelate.WHR_ID = Convert.ToDecimal(dr["WHR_ID"]);
            if (dr["WHR_Code"] != DBNull.Value) wH_BanlanceRelate.WHR_Code = Convert.ToString(dr["WHR_Code"]);
            if (dr["WHR_Period"] != DBNull.Value) wH_BanlanceRelate.WHR_Period = Convert.ToString(dr["WHR_Period"]);
            if (dr["WHR_BCode"] != DBNull.Value) wH_BanlanceRelate.WHR_BCode = Convert.ToString(dr["WHR_BCode"]);
            if (dr["WHR_BType"] != DBNull.Value) wH_BanlanceRelate.WHR_BType = Convert.ToString(dr["WHR_BType"]);
            if (dr["WHR_BCurMonth"] != DBNull.Value) wH_BanlanceRelate.WHR_BCurMonth = Convert.ToDecimal(dr["WHR_BCurMonth"]);
            if (dr["WHR_RefType"] != DBNull.Value) wH_BanlanceRelate.WHR_RefType = Convert.ToString(dr["WHR_RefType"]);
            if (dr["WHR_RefCode"] != DBNull.Value) wH_BanlanceRelate.WHR_RefCode = Convert.ToString(dr["WHR_RefCode"]);
            if (dr["WHR_RefDMoney"] != DBNull.Value) wH_BanlanceRelate.WHR_RefDMoney = Convert.ToDecimal(dr["WHR_RefDMoney"]);
            if (dr["WHR_RefRMoney"] != DBNull.Value) wH_BanlanceRelate.WHR_RefRMoney = Convert.ToDecimal(dr["WHR_RefRMoney"]);
            if (dr["WHR_Operator"] != DBNull.Value) wH_BanlanceRelate.WHR_Operator = Convert.ToString(dr["WHR_Operator"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanlanceRelate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanlanceRelate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanlanceRelate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) wH_BanlanceRelate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHR_UDEF1"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF1 = Convert.ToString(dr["WHR_UDEF1"]);
            if (dr["WHR_UDEF2"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF2 = Convert.ToString(dr["WHR_UDEF2"]);
            if (dr["WHR_UDEF3"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF3 = Convert.ToString(dr["WHR_UDEF3"]);
            if (dr["WHR_UDEF4"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF4 = Convert.ToString(dr["WHR_UDEF4"]);
            if (dr["WHR_UDEF5"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF5 = Convert.ToString(dr["WHR_UDEF5"]);
            if (dr["WHR_UDEF6"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF6 = Convert.ToString(dr["WHR_UDEF6"]);
            if (dr["WHR_UDEF7"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF7 = Convert.ToString(dr["WHR_UDEF7"]);
            if (dr["WHR_UDEF8"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF8 = Convert.ToString(dr["WHR_UDEF8"]);
            if (dr["WHR_UDEF9"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF9 = Convert.ToString(dr["WHR_UDEF9"]);
            if (dr["WHR_UDEF10"] != DBNull.Value) wH_BanlanceRelate.WHR_UDEF10 = Convert.ToString(dr["WHR_UDEF10"]);
            ret.Add(wH_BanlanceRelate);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
