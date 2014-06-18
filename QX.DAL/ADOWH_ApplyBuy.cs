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
   /// 请购单
   /// </summary>
   [Serializable]
   public partial class ADOWH_ApplyBuy
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加请购单 WH_ApplyBuy对象(即:一条记录)
      /// </summary>
      public int Add(WH_ApplyBuy wH_ApplyBuy)
      {
         string sql = "INSERT INTO WH_ApplyBuy (MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,Stat,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo) VALUES (@MVI_Code,@MVI_RCode,@MVI_Type,@MVI_MCode,@MVI_Spec,@MVI_Sup,@MVI_Num,@MVI_Unit,@MVI_MDPrice,@Stat,@MV_CustCode,@MV_CustName,@MV_CustRef,@MV_CustDate,@MV_VerifyStep,@MV_VerifyStuff,@MV_VerifyDate,@MV_VerifyStat,@MV_ContractNo)";
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Code))
         {
            idb.AddParameter("@MVI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Code", wH_ApplyBuy.MVI_Code);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_RCode))
         {
            idb.AddParameter("@MVI_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_RCode", wH_ApplyBuy.MVI_RCode);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Type))
         {
            idb.AddParameter("@MVI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Type", wH_ApplyBuy.MVI_Type);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_MCode))
         {
            idb.AddParameter("@MVI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_MCode", wH_ApplyBuy.MVI_MCode);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Spec))
         {
            idb.AddParameter("@MVI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Spec", wH_ApplyBuy.MVI_Spec);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Sup))
         {
            idb.AddParameter("@MVI_Sup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Sup", wH_ApplyBuy.MVI_Sup);
         }
         if (wH_ApplyBuy.MVI_Num == 0)
         {
            idb.AddParameter("@MVI_Num", 0);
         }
         else
         {
            idb.AddParameter("@MVI_Num", wH_ApplyBuy.MVI_Num);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Unit))
         {
            idb.AddParameter("@MVI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Unit", wH_ApplyBuy.MVI_Unit);
         }
         if (wH_ApplyBuy.MVI_MDPrice == 0)
         {
            idb.AddParameter("@MVI_MDPrice", 0);
         }
         else
         {
            idb.AddParameter("@MVI_MDPrice", wH_ApplyBuy.MVI_MDPrice);
         }
         if (wH_ApplyBuy.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_ApplyBuy.Stat);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustCode))
         {
            idb.AddParameter("@MV_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustCode", wH_ApplyBuy.MV_CustCode);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustName))
         {
            idb.AddParameter("@MV_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustName", wH_ApplyBuy.MV_CustName);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustRef))
         {
            idb.AddParameter("@MV_CustRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustRef", wH_ApplyBuy.MV_CustRef);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustDate))
         {
            idb.AddParameter("@MV_CustDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustDate", wH_ApplyBuy.MV_CustDate);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStep))
         {
            idb.AddParameter("@MV_VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStep", wH_ApplyBuy.MV_VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStuff))
         {
            idb.AddParameter("@MV_VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStuff", wH_ApplyBuy.MV_VerifyStuff);
         }
         if (wH_ApplyBuy.MV_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyDate", wH_ApplyBuy.MV_VerifyDate);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStat))
         {
            idb.AddParameter("@MV_VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStat", wH_ApplyBuy.MV_VerifyStat);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_ContractNo))
         {
            idb.AddParameter("@MV_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ContractNo", wH_ApplyBuy.MV_ContractNo);
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
      /// 添加请购单 WH_ApplyBuy对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_ApplyBuy wH_ApplyBuy)
      {
         string sql = "INSERT INTO WH_ApplyBuy (MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,Stat,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo) VALUES (@MVI_Code,@MVI_RCode,@MVI_Type,@MVI_MCode,@MVI_Spec,@MVI_Sup,@MVI_Num,@MVI_Unit,@MVI_MDPrice,@Stat,@MV_CustCode,@MV_CustName,@MV_CustRef,@MV_CustDate,@MV_VerifyStep,@MV_VerifyStuff,@MV_VerifyDate,@MV_VerifyStat,@MV_ContractNo);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Code))
         {
            idb.AddParameter("@MVI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Code", wH_ApplyBuy.MVI_Code);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_RCode))
         {
            idb.AddParameter("@MVI_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_RCode", wH_ApplyBuy.MVI_RCode);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Type))
         {
            idb.AddParameter("@MVI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Type", wH_ApplyBuy.MVI_Type);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_MCode))
         {
            idb.AddParameter("@MVI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_MCode", wH_ApplyBuy.MVI_MCode);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Spec))
         {
            idb.AddParameter("@MVI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Spec", wH_ApplyBuy.MVI_Spec);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Sup))
         {
            idb.AddParameter("@MVI_Sup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Sup", wH_ApplyBuy.MVI_Sup);
         }
         if (wH_ApplyBuy.MVI_Num == 0)
         {
            idb.AddParameter("@MVI_Num", 0);
         }
         else
         {
            idb.AddParameter("@MVI_Num", wH_ApplyBuy.MVI_Num);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Unit))
         {
            idb.AddParameter("@MVI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Unit", wH_ApplyBuy.MVI_Unit);
         }
         if (wH_ApplyBuy.MVI_MDPrice == 0)
         {
            idb.AddParameter("@MVI_MDPrice", 0);
         }
         else
         {
            idb.AddParameter("@MVI_MDPrice", wH_ApplyBuy.MVI_MDPrice);
         }
         if (wH_ApplyBuy.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_ApplyBuy.Stat);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustCode))
         {
            idb.AddParameter("@MV_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustCode", wH_ApplyBuy.MV_CustCode);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustName))
         {
            idb.AddParameter("@MV_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustName", wH_ApplyBuy.MV_CustName);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustRef))
         {
            idb.AddParameter("@MV_CustRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustRef", wH_ApplyBuy.MV_CustRef);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustDate))
         {
            idb.AddParameter("@MV_CustDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustDate", wH_ApplyBuy.MV_CustDate);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStep))
         {
            idb.AddParameter("@MV_VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStep", wH_ApplyBuy.MV_VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStuff))
         {
            idb.AddParameter("@MV_VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStuff", wH_ApplyBuy.MV_VerifyStuff);
         }
         if (wH_ApplyBuy.MV_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyDate", wH_ApplyBuy.MV_VerifyDate);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStat))
         {
            idb.AddParameter("@MV_VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStat", wH_ApplyBuy.MV_VerifyStat);
         }
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_ContractNo))
         {
            idb.AddParameter("@MV_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ContractNo", wH_ApplyBuy.MV_ContractNo);
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
      /// 更新请购单 WH_ApplyBuy对象(即:一条记录
      /// </summary>
      public int Update(WH_ApplyBuy wH_ApplyBuy)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_ApplyBuy       SET ");
            if(wH_ApplyBuy.MVI_Code_IsChanged){sbParameter.Append("MVI_Code=@MVI_Code, ");}
      if(wH_ApplyBuy.MVI_RCode_IsChanged){sbParameter.Append("MVI_RCode=@MVI_RCode, ");}
      if(wH_ApplyBuy.MVI_Type_IsChanged){sbParameter.Append("MVI_Type=@MVI_Type, ");}
      if(wH_ApplyBuy.MVI_MCode_IsChanged){sbParameter.Append("MVI_MCode=@MVI_MCode, ");}
      if(wH_ApplyBuy.MVI_Spec_IsChanged){sbParameter.Append("MVI_Spec=@MVI_Spec, ");}
      if(wH_ApplyBuy.MVI_Sup_IsChanged){sbParameter.Append("MVI_Sup=@MVI_Sup, ");}
      if(wH_ApplyBuy.MVI_Num_IsChanged){sbParameter.Append("MVI_Num=@MVI_Num, ");}
      if(wH_ApplyBuy.MVI_Unit_IsChanged){sbParameter.Append("MVI_Unit=@MVI_Unit, ");}
      if(wH_ApplyBuy.MVI_MDPrice_IsChanged){sbParameter.Append("MVI_MDPrice=@MVI_MDPrice, ");}
      if(wH_ApplyBuy.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_ApplyBuy.MV_CustCode_IsChanged){sbParameter.Append("MV_CustCode=@MV_CustCode, ");}
      if(wH_ApplyBuy.MV_CustName_IsChanged){sbParameter.Append("MV_CustName=@MV_CustName, ");}
      if(wH_ApplyBuy.MV_CustRef_IsChanged){sbParameter.Append("MV_CustRef=@MV_CustRef, ");}
      if(wH_ApplyBuy.MV_CustDate_IsChanged){sbParameter.Append("MV_CustDate=@MV_CustDate, ");}
      if(wH_ApplyBuy.MV_VerifyStep_IsChanged){sbParameter.Append("MV_VerifyStep=@MV_VerifyStep, ");}
      if(wH_ApplyBuy.MV_VerifyStuff_IsChanged){sbParameter.Append("MV_VerifyStuff=@MV_VerifyStuff, ");}
      if(wH_ApplyBuy.MV_VerifyDate_IsChanged){sbParameter.Append("MV_VerifyDate=@MV_VerifyDate, ");}
      if(wH_ApplyBuy.MV_VerifyStat_IsChanged){sbParameter.Append("MV_VerifyStat=@MV_VerifyStat, ");}
      if(wH_ApplyBuy.MV_ContractNo_IsChanged){sbParameter.Append("MV_ContractNo=@MV_ContractNo ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MVI_ID=@MVI_ID; " );
      string sql=sb.ToString();
         if(wH_ApplyBuy.MVI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Code))
         {
            idb.AddParameter("@MVI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Code", wH_ApplyBuy.MVI_Code);
         }
          }
         if(wH_ApplyBuy.MVI_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_RCode))
         {
            idb.AddParameter("@MVI_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_RCode", wH_ApplyBuy.MVI_RCode);
         }
          }
         if(wH_ApplyBuy.MVI_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Type))
         {
            idb.AddParameter("@MVI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Type", wH_ApplyBuy.MVI_Type);
         }
          }
         if(wH_ApplyBuy.MVI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_MCode))
         {
            idb.AddParameter("@MVI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_MCode", wH_ApplyBuy.MVI_MCode);
         }
          }
         if(wH_ApplyBuy.MVI_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Spec))
         {
            idb.AddParameter("@MVI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Spec", wH_ApplyBuy.MVI_Spec);
         }
          }
         if(wH_ApplyBuy.MVI_Sup_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Sup))
         {
            idb.AddParameter("@MVI_Sup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Sup", wH_ApplyBuy.MVI_Sup);
         }
          }
         if(wH_ApplyBuy.MVI_Num_IsChanged)
         {
         if (wH_ApplyBuy.MVI_Num == 0)
         {
            idb.AddParameter("@MVI_Num", 0);
         }
         else
         {
            idb.AddParameter("@MVI_Num", wH_ApplyBuy.MVI_Num);
         }
          }
         if(wH_ApplyBuy.MVI_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MVI_Unit))
         {
            idb.AddParameter("@MVI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Unit", wH_ApplyBuy.MVI_Unit);
         }
          }
         if(wH_ApplyBuy.MVI_MDPrice_IsChanged)
         {
         if (wH_ApplyBuy.MVI_MDPrice == 0)
         {
            idb.AddParameter("@MVI_MDPrice", 0);
         }
         else
         {
            idb.AddParameter("@MVI_MDPrice", wH_ApplyBuy.MVI_MDPrice);
         }
          }
         if(wH_ApplyBuy.Stat_IsChanged)
         {
         if (wH_ApplyBuy.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_ApplyBuy.Stat);
         }
          }
         if(wH_ApplyBuy.MV_CustCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustCode))
         {
            idb.AddParameter("@MV_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustCode", wH_ApplyBuy.MV_CustCode);
         }
          }
         if(wH_ApplyBuy.MV_CustName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustName))
         {
            idb.AddParameter("@MV_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustName", wH_ApplyBuy.MV_CustName);
         }
          }
         if(wH_ApplyBuy.MV_CustRef_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustRef))
         {
            idb.AddParameter("@MV_CustRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustRef", wH_ApplyBuy.MV_CustRef);
         }
          }
         if(wH_ApplyBuy.MV_CustDate_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_CustDate))
         {
            idb.AddParameter("@MV_CustDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustDate", wH_ApplyBuy.MV_CustDate);
         }
          }
         if(wH_ApplyBuy.MV_VerifyStep_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStep))
         {
            idb.AddParameter("@MV_VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStep", wH_ApplyBuy.MV_VerifyStep);
         }
          }
         if(wH_ApplyBuy.MV_VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStuff))
         {
            idb.AddParameter("@MV_VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStuff", wH_ApplyBuy.MV_VerifyStuff);
         }
          }
         if(wH_ApplyBuy.MV_VerifyDate_IsChanged)
         {
         if (wH_ApplyBuy.MV_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyDate", wH_ApplyBuy.MV_VerifyDate);
         }
          }
         if(wH_ApplyBuy.MV_VerifyStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_VerifyStat))
         {
            idb.AddParameter("@MV_VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStat", wH_ApplyBuy.MV_VerifyStat);
         }
          }
         if(wH_ApplyBuy.MV_ContractNo_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_ApplyBuy.MV_ContractNo))
         {
            idb.AddParameter("@MV_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ContractNo", wH_ApplyBuy.MV_ContractNo);
         }
          }

         idb.AddParameter("@MVI_ID", wH_ApplyBuy.MVI_ID);

           
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
      /// 删除请购单 WH_ApplyBuy对象(即:一条记录
      /// </summary>
      public int Delete(decimal mVI_ID)
      {
         string sql = "DELETE WH_ApplyBuy WHERE 1=1  AND MVI_ID=@MVI_ID ";
         idb.AddParameter("@MVI_ID", mVI_ID);

           
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
      /// 获取指定的请购单 WH_ApplyBuy对象(即:一条记录
      /// </summary>
      public WH_ApplyBuy GetByKey(decimal mVI_ID)
      {
         WH_ApplyBuy wH_ApplyBuy = new WH_ApplyBuy();
         string sql = "SELECT  MVI_ID,MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,Stat,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo FROM WH_ApplyBuy WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MVI_ID=@MVI_ID ";
         idb.AddParameter("@MVI_ID", mVI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MVI_ID"] != DBNull.Value) wH_ApplyBuy.MVI_ID = Convert.ToDecimal(dr["MVI_ID"]);
            if (dr["MVI_Code"] != DBNull.Value) wH_ApplyBuy.MVI_Code = Convert.ToString(dr["MVI_Code"]);
            if (dr["MVI_RCode"] != DBNull.Value) wH_ApplyBuy.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
            if (dr["MVI_Type"] != DBNull.Value) wH_ApplyBuy.MVI_Type = Convert.ToString(dr["MVI_Type"]);
            if (dr["MVI_MCode"] != DBNull.Value) wH_ApplyBuy.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
            if (dr["MVI_Spec"] != DBNull.Value) wH_ApplyBuy.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
            if (dr["MVI_Sup"] != DBNull.Value) wH_ApplyBuy.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
            if (dr["MVI_Num"] != DBNull.Value) wH_ApplyBuy.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
            if (dr["MVI_Unit"] != DBNull.Value) wH_ApplyBuy.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
            if (dr["MVI_MDPrice"] != DBNull.Value) wH_ApplyBuy.MVI_MDPrice = Convert.ToDouble(dr["MVI_MDPrice"]);
            if (dr["Stat"] != DBNull.Value) wH_ApplyBuy.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_CustCode"] != DBNull.Value) wH_ApplyBuy.MV_CustCode = Convert.ToString(dr["MV_CustCode"]);
            if (dr["MV_CustName"] != DBNull.Value) wH_ApplyBuy.MV_CustName = Convert.ToString(dr["MV_CustName"]);
            if (dr["MV_CustRef"] != DBNull.Value) wH_ApplyBuy.MV_CustRef = Convert.ToString(dr["MV_CustRef"]);
            if (dr["MV_CustDate"] != DBNull.Value) wH_ApplyBuy.MV_CustDate = Convert.ToString(dr["MV_CustDate"]);
            if (dr["MV_VerifyStep"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStep = Convert.ToString(dr["MV_VerifyStep"]);
            if (dr["MV_VerifyStuff"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStuff = Convert.ToString(dr["MV_VerifyStuff"]);
            if (dr["MV_VerifyDate"] != DBNull.Value) wH_ApplyBuy.MV_VerifyDate = Convert.ToDateTime(dr["MV_VerifyDate"]);
            if (dr["MV_VerifyStat"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStat = Convert.ToString(dr["MV_VerifyStat"]);
            if (dr["MV_ContractNo"] != DBNull.Value) wH_ApplyBuy.MV_ContractNo = Convert.ToString(dr["MV_ContractNo"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_ApplyBuy;
      }
      /// <summary>
      /// 获取指定的请购单 WH_ApplyBuy对象集合
      /// </summary>
      public List<WH_ApplyBuy> GetListByWhere(string strCondition)
      {
         List<WH_ApplyBuy> ret = new List<WH_ApplyBuy>();
         string sql = "SELECT  MVI_ID,MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,Stat,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo FROM WH_ApplyBuy WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_ApplyBuy wH_ApplyBuy = new WH_ApplyBuy();
            if (dr["MVI_ID"] != DBNull.Value) wH_ApplyBuy.MVI_ID = Convert.ToDecimal(dr["MVI_ID"]);
            if (dr["MVI_Code"] != DBNull.Value) wH_ApplyBuy.MVI_Code = Convert.ToString(dr["MVI_Code"]);
            if (dr["MVI_RCode"] != DBNull.Value) wH_ApplyBuy.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
            if (dr["MVI_Type"] != DBNull.Value) wH_ApplyBuy.MVI_Type = Convert.ToString(dr["MVI_Type"]);
            if (dr["MVI_MCode"] != DBNull.Value) wH_ApplyBuy.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
            if (dr["MVI_Spec"] != DBNull.Value) wH_ApplyBuy.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
            if (dr["MVI_Sup"] != DBNull.Value) wH_ApplyBuy.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
            if (dr["MVI_Num"] != DBNull.Value) wH_ApplyBuy.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
            if (dr["MVI_Unit"] != DBNull.Value) wH_ApplyBuy.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
            if (dr["MVI_MDPrice"] != DBNull.Value) wH_ApplyBuy.MVI_MDPrice = Convert.ToDouble(dr["MVI_MDPrice"]);
            if (dr["Stat"] != DBNull.Value) wH_ApplyBuy.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_CustCode"] != DBNull.Value) wH_ApplyBuy.MV_CustCode = Convert.ToString(dr["MV_CustCode"]);
            if (dr["MV_CustName"] != DBNull.Value) wH_ApplyBuy.MV_CustName = Convert.ToString(dr["MV_CustName"]);
            if (dr["MV_CustRef"] != DBNull.Value) wH_ApplyBuy.MV_CustRef = Convert.ToString(dr["MV_CustRef"]);
            if (dr["MV_CustDate"] != DBNull.Value) wH_ApplyBuy.MV_CustDate = Convert.ToString(dr["MV_CustDate"]);
            if (dr["MV_VerifyStep"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStep = Convert.ToString(dr["MV_VerifyStep"]);
            if (dr["MV_VerifyStuff"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStuff = Convert.ToString(dr["MV_VerifyStuff"]);
            if (dr["MV_VerifyDate"] != DBNull.Value) wH_ApplyBuy.MV_VerifyDate = Convert.ToDateTime(dr["MV_VerifyDate"]);
            if (dr["MV_VerifyStat"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStat = Convert.ToString(dr["MV_VerifyStat"]);
            if (dr["MV_ContractNo"] != DBNull.Value) wH_ApplyBuy.MV_ContractNo = Convert.ToString(dr["MV_ContractNo"]);
            ret.Add(wH_ApplyBuy);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的请购单 WH_ApplyBuy对象(即:一条记录
      /// </summary>
      public List<WH_ApplyBuy> GetAll()
      {
         List<WH_ApplyBuy> ret = new List<WH_ApplyBuy>();
         string sql = "SELECT  MVI_ID,MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,Stat,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo FROM WH_ApplyBuy where 1=1 AND ((Stat is null) or (Stat=0) ) order by MVI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_ApplyBuy wH_ApplyBuy = new WH_ApplyBuy();
            if (dr["MVI_ID"] != DBNull.Value) wH_ApplyBuy.MVI_ID = Convert.ToDecimal(dr["MVI_ID"]);
            if (dr["MVI_Code"] != DBNull.Value) wH_ApplyBuy.MVI_Code = Convert.ToString(dr["MVI_Code"]);
            if (dr["MVI_RCode"] != DBNull.Value) wH_ApplyBuy.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
            if (dr["MVI_Type"] != DBNull.Value) wH_ApplyBuy.MVI_Type = Convert.ToString(dr["MVI_Type"]);
            if (dr["MVI_MCode"] != DBNull.Value) wH_ApplyBuy.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
            if (dr["MVI_Spec"] != DBNull.Value) wH_ApplyBuy.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
            if (dr["MVI_Sup"] != DBNull.Value) wH_ApplyBuy.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
            if (dr["MVI_Num"] != DBNull.Value) wH_ApplyBuy.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
            if (dr["MVI_Unit"] != DBNull.Value) wH_ApplyBuy.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
            if (dr["MVI_MDPrice"] != DBNull.Value) wH_ApplyBuy.MVI_MDPrice = Convert.ToDouble(dr["MVI_MDPrice"]);
            if (dr["Stat"] != DBNull.Value) wH_ApplyBuy.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_CustCode"] != DBNull.Value) wH_ApplyBuy.MV_CustCode = Convert.ToString(dr["MV_CustCode"]);
            if (dr["MV_CustName"] != DBNull.Value) wH_ApplyBuy.MV_CustName = Convert.ToString(dr["MV_CustName"]);
            if (dr["MV_CustRef"] != DBNull.Value) wH_ApplyBuy.MV_CustRef = Convert.ToString(dr["MV_CustRef"]);
            if (dr["MV_CustDate"] != DBNull.Value) wH_ApplyBuy.MV_CustDate = Convert.ToString(dr["MV_CustDate"]);
            if (dr["MV_VerifyStep"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStep = Convert.ToString(dr["MV_VerifyStep"]);
            if (dr["MV_VerifyStuff"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStuff = Convert.ToString(dr["MV_VerifyStuff"]);
            if (dr["MV_VerifyDate"] != DBNull.Value) wH_ApplyBuy.MV_VerifyDate = Convert.ToDateTime(dr["MV_VerifyDate"]);
            if (dr["MV_VerifyStat"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStat = Convert.ToString(dr["MV_VerifyStat"]);
            if (dr["MV_ContractNo"] != DBNull.Value) wH_ApplyBuy.MV_ContractNo = Convert.ToString(dr["MV_ContractNo"]);
            ret.Add(wH_ApplyBuy);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
