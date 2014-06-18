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
   /// 客户发票
   /// </summary>
   [Serializable]
   public partial class ADOSD_Invoice
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加客户发票 SD_Invoice对象(即:一条记录)
      /// </summary>
      public int Add(SD_Invoice sD_Invoice)
      {
         string sql = "INSERT INTO SD_Invoice (SDCI_Code,SDCI_Type,SDCI_Date,SDCI_IName,SDCI_CCode,SDCI_CName,SDCI_TaxNo,SDCI_SOwner,SDCI_FOwner,SDCI_IsInvoice,SDCI_RefContract,SDCI_Num,SDCI_Bak,SDCI_RefType,SDCI_RefCode,SDCI_Status,CreateDate,UpdateDate,DeleteDate,Stat,SDCI_Company,SDCI_CompanyCode) VALUES (@SDCI_Code,@SDCI_Type,@SDCI_Date,@SDCI_IName,@SDCI_CCode,@SDCI_CName,@SDCI_TaxNo,@SDCI_SOwner,@SDCI_FOwner,@SDCI_IsInvoice,@SDCI_RefContract,@SDCI_Num,@SDCI_Bak,@SDCI_RefType,@SDCI_RefCode,@SDCI_Status,@CreateDate,@UpdateDate,@DeleteDate,@Stat,@SDCI_Company,@SDCI_CompanyCode)";
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Code))
         {
            idb.AddParameter("@SDCI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Code", sD_Invoice.SDCI_Code);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Type))
         {
            idb.AddParameter("@SDCI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Type", sD_Invoice.SDCI_Type);
         }
         if (sD_Invoice.SDCI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDCI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Date", sD_Invoice.SDCI_Date);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_IName))
         {
            idb.AddParameter("@SDCI_IName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_IName", sD_Invoice.SDCI_IName);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CCode))
         {
            idb.AddParameter("@SDCI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CCode", sD_Invoice.SDCI_CCode);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CName))
         {
            idb.AddParameter("@SDCI_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CName", sD_Invoice.SDCI_CName);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_TaxNo))
         {
            idb.AddParameter("@SDCI_TaxNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_TaxNo", sD_Invoice.SDCI_TaxNo);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_SOwner))
         {
            idb.AddParameter("@SDCI_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_SOwner", sD_Invoice.SDCI_SOwner);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_FOwner))
         {
            idb.AddParameter("@SDCI_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_FOwner", sD_Invoice.SDCI_FOwner);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_IsInvoice))
         {
            idb.AddParameter("@SDCI_IsInvoice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_IsInvoice", sD_Invoice.SDCI_IsInvoice);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefContract))
         {
            idb.AddParameter("@SDCI_RefContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefContract", sD_Invoice.SDCI_RefContract);
         }
         if (sD_Invoice.SDCI_Num == 0)
         {
            idb.AddParameter("@SDCI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDCI_Num", sD_Invoice.SDCI_Num);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Bak))
         {
            idb.AddParameter("@SDCI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Bak", sD_Invoice.SDCI_Bak);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefType))
         {
            idb.AddParameter("@SDCI_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefType", sD_Invoice.SDCI_RefType);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefCode))
         {
            idb.AddParameter("@SDCI_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefCode", sD_Invoice.SDCI_RefCode);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Status))
         {
            idb.AddParameter("@SDCI_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Status", sD_Invoice.SDCI_Status);
         }
         if (sD_Invoice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Invoice.CreateDate);
         }
         if (sD_Invoice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Invoice.UpdateDate);
         }
         if (sD_Invoice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Invoice.DeleteDate);
         }
         if (sD_Invoice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Invoice.Stat);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Company))
         {
            idb.AddParameter("@SDCI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Company", sD_Invoice.SDCI_Company);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CompanyCode))
         {
            idb.AddParameter("@SDCI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CompanyCode", sD_Invoice.SDCI_CompanyCode);
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
      /// 添加客户发票 SD_Invoice对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Invoice sD_Invoice)
      {
         string sql = "INSERT INTO SD_Invoice (SDCI_Code,SDCI_Type,SDCI_Date,SDCI_IName,SDCI_CCode,SDCI_CName,SDCI_TaxNo,SDCI_SOwner,SDCI_FOwner,SDCI_IsInvoice,SDCI_RefContract,SDCI_Num,SDCI_Bak,SDCI_RefType,SDCI_RefCode,SDCI_Status,CreateDate,UpdateDate,DeleteDate,Stat,SDCI_Company,SDCI_CompanyCode) VALUES (@SDCI_Code,@SDCI_Type,@SDCI_Date,@SDCI_IName,@SDCI_CCode,@SDCI_CName,@SDCI_TaxNo,@SDCI_SOwner,@SDCI_FOwner,@SDCI_IsInvoice,@SDCI_RefContract,@SDCI_Num,@SDCI_Bak,@SDCI_RefType,@SDCI_RefCode,@SDCI_Status,@CreateDate,@UpdateDate,@DeleteDate,@Stat,@SDCI_Company,@SDCI_CompanyCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Code))
         {
            idb.AddParameter("@SDCI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Code", sD_Invoice.SDCI_Code);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Type))
         {
            idb.AddParameter("@SDCI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Type", sD_Invoice.SDCI_Type);
         }
         if (sD_Invoice.SDCI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDCI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Date", sD_Invoice.SDCI_Date);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_IName))
         {
            idb.AddParameter("@SDCI_IName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_IName", sD_Invoice.SDCI_IName);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CCode))
         {
            idb.AddParameter("@SDCI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CCode", sD_Invoice.SDCI_CCode);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CName))
         {
            idb.AddParameter("@SDCI_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CName", sD_Invoice.SDCI_CName);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_TaxNo))
         {
            idb.AddParameter("@SDCI_TaxNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_TaxNo", sD_Invoice.SDCI_TaxNo);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_SOwner))
         {
            idb.AddParameter("@SDCI_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_SOwner", sD_Invoice.SDCI_SOwner);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_FOwner))
         {
            idb.AddParameter("@SDCI_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_FOwner", sD_Invoice.SDCI_FOwner);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_IsInvoice))
         {
            idb.AddParameter("@SDCI_IsInvoice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_IsInvoice", sD_Invoice.SDCI_IsInvoice);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefContract))
         {
            idb.AddParameter("@SDCI_RefContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefContract", sD_Invoice.SDCI_RefContract);
         }
         if (sD_Invoice.SDCI_Num == 0)
         {
            idb.AddParameter("@SDCI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDCI_Num", sD_Invoice.SDCI_Num);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Bak))
         {
            idb.AddParameter("@SDCI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Bak", sD_Invoice.SDCI_Bak);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefType))
         {
            idb.AddParameter("@SDCI_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefType", sD_Invoice.SDCI_RefType);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefCode))
         {
            idb.AddParameter("@SDCI_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefCode", sD_Invoice.SDCI_RefCode);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Status))
         {
            idb.AddParameter("@SDCI_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Status", sD_Invoice.SDCI_Status);
         }
         if (sD_Invoice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Invoice.CreateDate);
         }
         if (sD_Invoice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Invoice.UpdateDate);
         }
         if (sD_Invoice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Invoice.DeleteDate);
         }
         if (sD_Invoice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Invoice.Stat);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Company))
         {
            idb.AddParameter("@SDCI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Company", sD_Invoice.SDCI_Company);
         }
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CompanyCode))
         {
            idb.AddParameter("@SDCI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CompanyCode", sD_Invoice.SDCI_CompanyCode);
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
      /// 更新客户发票 SD_Invoice对象(即:一条记录
      /// </summary>
      public int Update(SD_Invoice sD_Invoice)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Invoice       SET ");
            if(sD_Invoice.SDCI_Code_IsChanged){sbParameter.Append("SDCI_Code=@SDCI_Code, ");}
      if(sD_Invoice.SDCI_Type_IsChanged){sbParameter.Append("SDCI_Type=@SDCI_Type, ");}
      if(sD_Invoice.SDCI_Date_IsChanged){sbParameter.Append("SDCI_Date=@SDCI_Date, ");}
      if(sD_Invoice.SDCI_IName_IsChanged){sbParameter.Append("SDCI_IName=@SDCI_IName, ");}
      if(sD_Invoice.SDCI_CCode_IsChanged){sbParameter.Append("SDCI_CCode=@SDCI_CCode, ");}
      if(sD_Invoice.SDCI_CName_IsChanged){sbParameter.Append("SDCI_CName=@SDCI_CName, ");}
      if(sD_Invoice.SDCI_TaxNo_IsChanged){sbParameter.Append("SDCI_TaxNo=@SDCI_TaxNo, ");}
      if(sD_Invoice.SDCI_SOwner_IsChanged){sbParameter.Append("SDCI_SOwner=@SDCI_SOwner, ");}
      if(sD_Invoice.SDCI_FOwner_IsChanged){sbParameter.Append("SDCI_FOwner=@SDCI_FOwner, ");}
      if(sD_Invoice.SDCI_IsInvoice_IsChanged){sbParameter.Append("SDCI_IsInvoice=@SDCI_IsInvoice, ");}
      if(sD_Invoice.SDCI_RefContract_IsChanged){sbParameter.Append("SDCI_RefContract=@SDCI_RefContract, ");}
      if(sD_Invoice.SDCI_Num_IsChanged){sbParameter.Append("SDCI_Num=@SDCI_Num, ");}
      if(sD_Invoice.SDCI_Bak_IsChanged){sbParameter.Append("SDCI_Bak=@SDCI_Bak, ");}
      if(sD_Invoice.SDCI_RefType_IsChanged){sbParameter.Append("SDCI_RefType=@SDCI_RefType, ");}
      if(sD_Invoice.SDCI_RefCode_IsChanged){sbParameter.Append("SDCI_RefCode=@SDCI_RefCode, ");}
      if(sD_Invoice.SDCI_Status_IsChanged){sbParameter.Append("SDCI_Status=@SDCI_Status, ");}
      if(sD_Invoice.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_Invoice.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_Invoice.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_Invoice.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Invoice.SDCI_Company_IsChanged){sbParameter.Append("SDCI_Company=@SDCI_Company, ");}
      if(sD_Invoice.SDCI_CompanyCode_IsChanged){sbParameter.Append("SDCI_CompanyCode=@SDCI_CompanyCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDCI_ID=@SDCI_ID; " );
      string sql=sb.ToString();
         if(sD_Invoice.SDCI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Code))
         {
            idb.AddParameter("@SDCI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Code", sD_Invoice.SDCI_Code);
         }
          }
         if(sD_Invoice.SDCI_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Type))
         {
            idb.AddParameter("@SDCI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Type", sD_Invoice.SDCI_Type);
         }
          }
         if(sD_Invoice.SDCI_Date_IsChanged)
         {
         if (sD_Invoice.SDCI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDCI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Date", sD_Invoice.SDCI_Date);
         }
          }
         if(sD_Invoice.SDCI_IName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_IName))
         {
            idb.AddParameter("@SDCI_IName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_IName", sD_Invoice.SDCI_IName);
         }
          }
         if(sD_Invoice.SDCI_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CCode))
         {
            idb.AddParameter("@SDCI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CCode", sD_Invoice.SDCI_CCode);
         }
          }
         if(sD_Invoice.SDCI_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CName))
         {
            idb.AddParameter("@SDCI_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CName", sD_Invoice.SDCI_CName);
         }
          }
         if(sD_Invoice.SDCI_TaxNo_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_TaxNo))
         {
            idb.AddParameter("@SDCI_TaxNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_TaxNo", sD_Invoice.SDCI_TaxNo);
         }
          }
         if(sD_Invoice.SDCI_SOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_SOwner))
         {
            idb.AddParameter("@SDCI_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_SOwner", sD_Invoice.SDCI_SOwner);
         }
          }
         if(sD_Invoice.SDCI_FOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_FOwner))
         {
            idb.AddParameter("@SDCI_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_FOwner", sD_Invoice.SDCI_FOwner);
         }
          }
         if(sD_Invoice.SDCI_IsInvoice_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_IsInvoice))
         {
            idb.AddParameter("@SDCI_IsInvoice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_IsInvoice", sD_Invoice.SDCI_IsInvoice);
         }
          }
         if(sD_Invoice.SDCI_RefContract_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefContract))
         {
            idb.AddParameter("@SDCI_RefContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefContract", sD_Invoice.SDCI_RefContract);
         }
          }
         if(sD_Invoice.SDCI_Num_IsChanged)
         {
         if (sD_Invoice.SDCI_Num == 0)
         {
            idb.AddParameter("@SDCI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDCI_Num", sD_Invoice.SDCI_Num);
         }
          }
         if(sD_Invoice.SDCI_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Bak))
         {
            idb.AddParameter("@SDCI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Bak", sD_Invoice.SDCI_Bak);
         }
          }
         if(sD_Invoice.SDCI_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefType))
         {
            idb.AddParameter("@SDCI_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefType", sD_Invoice.SDCI_RefType);
         }
          }
         if(sD_Invoice.SDCI_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_RefCode))
         {
            idb.AddParameter("@SDCI_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_RefCode", sD_Invoice.SDCI_RefCode);
         }
          }
         if(sD_Invoice.SDCI_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Status))
         {
            idb.AddParameter("@SDCI_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Status", sD_Invoice.SDCI_Status);
         }
          }
         if(sD_Invoice.CreateDate_IsChanged)
         {
         if (sD_Invoice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Invoice.CreateDate);
         }
          }
         if(sD_Invoice.UpdateDate_IsChanged)
         {
         if (sD_Invoice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Invoice.UpdateDate);
         }
          }
         if(sD_Invoice.DeleteDate_IsChanged)
         {
         if (sD_Invoice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Invoice.DeleteDate);
         }
          }
         if(sD_Invoice.Stat_IsChanged)
         {
         if (sD_Invoice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Invoice.Stat);
         }
          }
         if(sD_Invoice.SDCI_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_Company))
         {
            idb.AddParameter("@SDCI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_Company", sD_Invoice.SDCI_Company);
         }
          }
         if(sD_Invoice.SDCI_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Invoice.SDCI_CompanyCode))
         {
            idb.AddParameter("@SDCI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDCI_CompanyCode", sD_Invoice.SDCI_CompanyCode);
         }
          }

         idb.AddParameter("@SDCI_ID", sD_Invoice.SDCI_ID);

           
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
      /// 删除客户发票 SD_Invoice对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDCI_ID)
      {
         string sql = "DELETE SD_Invoice WHERE 1=1  AND SDCI_ID=@SDCI_ID ";
         idb.AddParameter("@SDCI_ID", sDCI_ID);

           
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
      /// 获取指定的客户发票 SD_Invoice对象(即:一条记录
      /// </summary>
      public SD_Invoice GetByKey(decimal sDCI_ID)
      {
         SD_Invoice sD_Invoice = new SD_Invoice();
         string sql = "SELECT  SDCI_ID,SDCI_Code,SDCI_Type,SDCI_Date,SDCI_IName,SDCI_CCode,SDCI_CName,SDCI_TaxNo,SDCI_SOwner,SDCI_FOwner,SDCI_IsInvoice,SDCI_RefContract,SDCI_Num,SDCI_Bak,SDCI_RefType,SDCI_RefCode,SDCI_Status,CreateDate,UpdateDate,DeleteDate,Stat,SDCI_Company,SDCI_CompanyCode FROM SD_Invoice WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDCI_ID=@SDCI_ID ";
         idb.AddParameter("@SDCI_ID", sDCI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDCI_ID"] != DBNull.Value) sD_Invoice.SDCI_ID = Convert.ToDecimal(dr["SDCI_ID"]);
            if (dr["SDCI_Code"] != DBNull.Value) sD_Invoice.SDCI_Code = Convert.ToString(dr["SDCI_Code"]);
            if (dr["SDCI_Type"] != DBNull.Value) sD_Invoice.SDCI_Type = Convert.ToString(dr["SDCI_Type"]);
            if (dr["SDCI_Date"] != DBNull.Value) sD_Invoice.SDCI_Date = Convert.ToDateTime(dr["SDCI_Date"]);
            if (dr["SDCI_IName"] != DBNull.Value) sD_Invoice.SDCI_IName = Convert.ToString(dr["SDCI_IName"]);
            if (dr["SDCI_CCode"] != DBNull.Value) sD_Invoice.SDCI_CCode = Convert.ToString(dr["SDCI_CCode"]);
            if (dr["SDCI_CName"] != DBNull.Value) sD_Invoice.SDCI_CName = Convert.ToString(dr["SDCI_CName"]);
            if (dr["SDCI_TaxNo"] != DBNull.Value) sD_Invoice.SDCI_TaxNo = Convert.ToString(dr["SDCI_TaxNo"]);
            if (dr["SDCI_SOwner"] != DBNull.Value) sD_Invoice.SDCI_SOwner = Convert.ToString(dr["SDCI_SOwner"]);
            if (dr["SDCI_FOwner"] != DBNull.Value) sD_Invoice.SDCI_FOwner = Convert.ToString(dr["SDCI_FOwner"]);
            if (dr["SDCI_IsInvoice"] != DBNull.Value) sD_Invoice.SDCI_IsInvoice = Convert.ToString(dr["SDCI_IsInvoice"]);
            if (dr["SDCI_RefContract"] != DBNull.Value) sD_Invoice.SDCI_RefContract = Convert.ToString(dr["SDCI_RefContract"]);
            if (dr["SDCI_Num"] != DBNull.Value) sD_Invoice.SDCI_Num = Convert.ToDecimal(dr["SDCI_Num"]);
            if (dr["SDCI_Bak"] != DBNull.Value) sD_Invoice.SDCI_Bak = Convert.ToString(dr["SDCI_Bak"]);
            if (dr["SDCI_RefType"] != DBNull.Value) sD_Invoice.SDCI_RefType = Convert.ToString(dr["SDCI_RefType"]);
            if (dr["SDCI_RefCode"] != DBNull.Value) sD_Invoice.SDCI_RefCode = Convert.ToString(dr["SDCI_RefCode"]);
            if (dr["SDCI_Status"] != DBNull.Value) sD_Invoice.SDCI_Status = Convert.ToString(dr["SDCI_Status"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Invoice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Invoice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Invoice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) sD_Invoice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDCI_Company"] != DBNull.Value) sD_Invoice.SDCI_Company = Convert.ToString(dr["SDCI_Company"]);
            if (dr["SDCI_CompanyCode"] != DBNull.Value) sD_Invoice.SDCI_CompanyCode = Convert.ToString(dr["SDCI_CompanyCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Invoice;
      }
      /// <summary>
      /// 获取指定的客户发票 SD_Invoice对象集合
      /// </summary>
      public List<SD_Invoice> GetListByWhere(string strCondition)
      {
         List<SD_Invoice> ret = new List<SD_Invoice>();
         string sql = "SELECT  SDCI_ID,SDCI_Code,SDCI_Type,SDCI_Date,SDCI_IName,SDCI_CCode,SDCI_CName,SDCI_TaxNo,SDCI_SOwner,SDCI_FOwner,SDCI_IsInvoice,SDCI_RefContract,SDCI_Num,SDCI_Bak,SDCI_RefType,SDCI_RefCode,SDCI_Status,CreateDate,UpdateDate,DeleteDate,Stat,SDCI_Company,SDCI_CompanyCode FROM SD_Invoice WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Invoice sD_Invoice = new SD_Invoice();
            if (dr["SDCI_ID"] != DBNull.Value) sD_Invoice.SDCI_ID = Convert.ToDecimal(dr["SDCI_ID"]);
            if (dr["SDCI_Code"] != DBNull.Value) sD_Invoice.SDCI_Code = Convert.ToString(dr["SDCI_Code"]);
            if (dr["SDCI_Type"] != DBNull.Value) sD_Invoice.SDCI_Type = Convert.ToString(dr["SDCI_Type"]);
            if (dr["SDCI_Date"] != DBNull.Value) sD_Invoice.SDCI_Date = Convert.ToDateTime(dr["SDCI_Date"]);
            if (dr["SDCI_IName"] != DBNull.Value) sD_Invoice.SDCI_IName = Convert.ToString(dr["SDCI_IName"]);
            if (dr["SDCI_CCode"] != DBNull.Value) sD_Invoice.SDCI_CCode = Convert.ToString(dr["SDCI_CCode"]);
            if (dr["SDCI_CName"] != DBNull.Value) sD_Invoice.SDCI_CName = Convert.ToString(dr["SDCI_CName"]);
            if (dr["SDCI_TaxNo"] != DBNull.Value) sD_Invoice.SDCI_TaxNo = Convert.ToString(dr["SDCI_TaxNo"]);
            if (dr["SDCI_SOwner"] != DBNull.Value) sD_Invoice.SDCI_SOwner = Convert.ToString(dr["SDCI_SOwner"]);
            if (dr["SDCI_FOwner"] != DBNull.Value) sD_Invoice.SDCI_FOwner = Convert.ToString(dr["SDCI_FOwner"]);
            if (dr["SDCI_IsInvoice"] != DBNull.Value) sD_Invoice.SDCI_IsInvoice = Convert.ToString(dr["SDCI_IsInvoice"]);
            if (dr["SDCI_RefContract"] != DBNull.Value) sD_Invoice.SDCI_RefContract = Convert.ToString(dr["SDCI_RefContract"]);
            if (dr["SDCI_Num"] != DBNull.Value) sD_Invoice.SDCI_Num = Convert.ToDecimal(dr["SDCI_Num"]);
            if (dr["SDCI_Bak"] != DBNull.Value) sD_Invoice.SDCI_Bak = Convert.ToString(dr["SDCI_Bak"]);
            if (dr["SDCI_RefType"] != DBNull.Value) sD_Invoice.SDCI_RefType = Convert.ToString(dr["SDCI_RefType"]);
            if (dr["SDCI_RefCode"] != DBNull.Value) sD_Invoice.SDCI_RefCode = Convert.ToString(dr["SDCI_RefCode"]);
            if (dr["SDCI_Status"] != DBNull.Value) sD_Invoice.SDCI_Status = Convert.ToString(dr["SDCI_Status"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Invoice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Invoice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Invoice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) sD_Invoice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDCI_Company"] != DBNull.Value) sD_Invoice.SDCI_Company = Convert.ToString(dr["SDCI_Company"]);
            if (dr["SDCI_CompanyCode"] != DBNull.Value) sD_Invoice.SDCI_CompanyCode = Convert.ToString(dr["SDCI_CompanyCode"]);
            ret.Add(sD_Invoice);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的客户发票 SD_Invoice对象(即:一条记录
      /// </summary>
      public List<SD_Invoice> GetAll()
      {
         List<SD_Invoice> ret = new List<SD_Invoice>();
         string sql = "SELECT  SDCI_ID,SDCI_Code,SDCI_Type,SDCI_Date,SDCI_IName,SDCI_CCode,SDCI_CName,SDCI_TaxNo,SDCI_SOwner,SDCI_FOwner,SDCI_IsInvoice,SDCI_RefContract,SDCI_Num,SDCI_Bak,SDCI_RefType,SDCI_RefCode,SDCI_Status,CreateDate,UpdateDate,DeleteDate,Stat,SDCI_Company,SDCI_CompanyCode FROM SD_Invoice where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDCI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Invoice sD_Invoice = new SD_Invoice();
            if (dr["SDCI_ID"] != DBNull.Value) sD_Invoice.SDCI_ID = Convert.ToDecimal(dr["SDCI_ID"]);
            if (dr["SDCI_Code"] != DBNull.Value) sD_Invoice.SDCI_Code = Convert.ToString(dr["SDCI_Code"]);
            if (dr["SDCI_Type"] != DBNull.Value) sD_Invoice.SDCI_Type = Convert.ToString(dr["SDCI_Type"]);
            if (dr["SDCI_Date"] != DBNull.Value) sD_Invoice.SDCI_Date = Convert.ToDateTime(dr["SDCI_Date"]);
            if (dr["SDCI_IName"] != DBNull.Value) sD_Invoice.SDCI_IName = Convert.ToString(dr["SDCI_IName"]);
            if (dr["SDCI_CCode"] != DBNull.Value) sD_Invoice.SDCI_CCode = Convert.ToString(dr["SDCI_CCode"]);
            if (dr["SDCI_CName"] != DBNull.Value) sD_Invoice.SDCI_CName = Convert.ToString(dr["SDCI_CName"]);
            if (dr["SDCI_TaxNo"] != DBNull.Value) sD_Invoice.SDCI_TaxNo = Convert.ToString(dr["SDCI_TaxNo"]);
            if (dr["SDCI_SOwner"] != DBNull.Value) sD_Invoice.SDCI_SOwner = Convert.ToString(dr["SDCI_SOwner"]);
            if (dr["SDCI_FOwner"] != DBNull.Value) sD_Invoice.SDCI_FOwner = Convert.ToString(dr["SDCI_FOwner"]);
            if (dr["SDCI_IsInvoice"] != DBNull.Value) sD_Invoice.SDCI_IsInvoice = Convert.ToString(dr["SDCI_IsInvoice"]);
            if (dr["SDCI_RefContract"] != DBNull.Value) sD_Invoice.SDCI_RefContract = Convert.ToString(dr["SDCI_RefContract"]);
            if (dr["SDCI_Num"] != DBNull.Value) sD_Invoice.SDCI_Num = Convert.ToDecimal(dr["SDCI_Num"]);
            if (dr["SDCI_Bak"] != DBNull.Value) sD_Invoice.SDCI_Bak = Convert.ToString(dr["SDCI_Bak"]);
            if (dr["SDCI_RefType"] != DBNull.Value) sD_Invoice.SDCI_RefType = Convert.ToString(dr["SDCI_RefType"]);
            if (dr["SDCI_RefCode"] != DBNull.Value) sD_Invoice.SDCI_RefCode = Convert.ToString(dr["SDCI_RefCode"]);
            if (dr["SDCI_Status"] != DBNull.Value) sD_Invoice.SDCI_Status = Convert.ToString(dr["SDCI_Status"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Invoice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Invoice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Invoice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) sD_Invoice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDCI_Company"] != DBNull.Value) sD_Invoice.SDCI_Company = Convert.ToString(dr["SDCI_Company"]);
            if (dr["SDCI_CompanyCode"] != DBNull.Value) sD_Invoice.SDCI_CompanyCode = Convert.ToString(dr["SDCI_CompanyCode"]);
            ret.Add(sD_Invoice);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
