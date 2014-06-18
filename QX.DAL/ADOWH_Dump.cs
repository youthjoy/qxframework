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
   /// 库存转储信息
   /// </summary>
   [Serializable]
   public partial class ADOWH_Dump
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加库存转储信息 WH_Dump对象(即:一条记录)
      /// </summary>
      public int Add(WH_Dump wH_Dump)
      {
         string sql = "INSERT INTO WH_Dump (MDump_Code,MDump_MCode,MDump_MName,MDump_Description,MDump_OldWarehouseName,MDump_OldWarehouse,MDump_OldWNoName,MDump_OldWNo,MDump_WarehouseName,MDump_Warehourse,MDump_WNoName,MDump_WNo,MDump_Count,MDump_Unit,MDump_Date,MDump_Operator,MDump_Remark,Stat,CreateDate,UpdateDate,DeleteDate,MDump_OldCount,MDump_Company,MDump_CompanyCode) VALUES (@MDump_Code,@MDump_MCode,@MDump_MName,@MDump_Description,@MDump_OldWarehouseName,@MDump_OldWarehouse,@MDump_OldWNoName,@MDump_OldWNo,@MDump_WarehouseName,@MDump_Warehourse,@MDump_WNoName,@MDump_WNo,@MDump_Count,@MDump_Unit,@MDump_Date,@MDump_Operator,@MDump_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@MDump_OldCount,@MDump_Company,@MDump_CompanyCode)";
         if (string.IsNullOrEmpty(wH_Dump.MDump_Code))
         {
            idb.AddParameter("@MDump_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Code", wH_Dump.MDump_Code);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_MCode))
         {
            idb.AddParameter("@MDump_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_MCode", wH_Dump.MDump_MCode);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_MName))
         {
            idb.AddParameter("@MDump_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_MName", wH_Dump.MDump_MName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Description))
         {
            idb.AddParameter("@MDump_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Description", wH_Dump.MDump_Description);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWarehouseName))
         {
            idb.AddParameter("@MDump_OldWarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWarehouseName", wH_Dump.MDump_OldWarehouseName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWarehouse))
         {
            idb.AddParameter("@MDump_OldWarehouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWarehouse", wH_Dump.MDump_OldWarehouse);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWNoName))
         {
            idb.AddParameter("@MDump_OldWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWNoName", wH_Dump.MDump_OldWNoName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWNo))
         {
            idb.AddParameter("@MDump_OldWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWNo", wH_Dump.MDump_OldWNo);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_WarehouseName))
         {
            idb.AddParameter("@MDump_WarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WarehouseName", wH_Dump.MDump_WarehouseName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Warehourse))
         {
            idb.AddParameter("@MDump_Warehourse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Warehourse", wH_Dump.MDump_Warehourse);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_WNoName))
         {
            idb.AddParameter("@MDump_WNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WNoName", wH_Dump.MDump_WNoName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_WNo))
         {
            idb.AddParameter("@MDump_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WNo", wH_Dump.MDump_WNo);
         }
         if (wH_Dump.MDump_Count == 0)
         {
            idb.AddParameter("@MDump_Count", 0);
         }
         else
         {
            idb.AddParameter("@MDump_Count", wH_Dump.MDump_Count);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Unit))
         {
            idb.AddParameter("@MDump_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Unit", wH_Dump.MDump_Unit);
         }
         if (wH_Dump.MDump_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MDump_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Date", wH_Dump.MDump_Date);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Operator))
         {
            idb.AddParameter("@MDump_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Operator", wH_Dump.MDump_Operator);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Remark))
         {
            idb.AddParameter("@MDump_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Remark", wH_Dump.MDump_Remark);
         }
         if (wH_Dump.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Dump.Stat);
         }
         if (wH_Dump.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Dump.CreateDate);
         }
         if (wH_Dump.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Dump.UpdateDate);
         }
         if (wH_Dump.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Dump.DeleteDate);
         }
         if (wH_Dump.MDump_OldCount == 0)
         {
            idb.AddParameter("@MDump_OldCount", 0);
         }
         else
         {
            idb.AddParameter("@MDump_OldCount", wH_Dump.MDump_OldCount);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Company))
         {
            idb.AddParameter("@MDump_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Company", wH_Dump.MDump_Company);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_CompanyCode))
         {
            idb.AddParameter("@MDump_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_CompanyCode", wH_Dump.MDump_CompanyCode);
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
      /// 添加库存转储信息 WH_Dump对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Dump wH_Dump)
      {
         string sql = "INSERT INTO WH_Dump (MDump_Code,MDump_MCode,MDump_MName,MDump_Description,MDump_OldWarehouseName,MDump_OldWarehouse,MDump_OldWNoName,MDump_OldWNo,MDump_WarehouseName,MDump_Warehourse,MDump_WNoName,MDump_WNo,MDump_Count,MDump_Unit,MDump_Date,MDump_Operator,MDump_Remark,Stat,CreateDate,UpdateDate,DeleteDate,MDump_OldCount,MDump_Company,MDump_CompanyCode) VALUES (@MDump_Code,@MDump_MCode,@MDump_MName,@MDump_Description,@MDump_OldWarehouseName,@MDump_OldWarehouse,@MDump_OldWNoName,@MDump_OldWNo,@MDump_WarehouseName,@MDump_Warehourse,@MDump_WNoName,@MDump_WNo,@MDump_Count,@MDump_Unit,@MDump_Date,@MDump_Operator,@MDump_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@MDump_OldCount,@MDump_Company,@MDump_CompanyCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Dump.MDump_Code))
         {
            idb.AddParameter("@MDump_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Code", wH_Dump.MDump_Code);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_MCode))
         {
            idb.AddParameter("@MDump_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_MCode", wH_Dump.MDump_MCode);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_MName))
         {
            idb.AddParameter("@MDump_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_MName", wH_Dump.MDump_MName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Description))
         {
            idb.AddParameter("@MDump_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Description", wH_Dump.MDump_Description);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWarehouseName))
         {
            idb.AddParameter("@MDump_OldWarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWarehouseName", wH_Dump.MDump_OldWarehouseName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWarehouse))
         {
            idb.AddParameter("@MDump_OldWarehouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWarehouse", wH_Dump.MDump_OldWarehouse);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWNoName))
         {
            idb.AddParameter("@MDump_OldWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWNoName", wH_Dump.MDump_OldWNoName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWNo))
         {
            idb.AddParameter("@MDump_OldWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWNo", wH_Dump.MDump_OldWNo);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_WarehouseName))
         {
            idb.AddParameter("@MDump_WarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WarehouseName", wH_Dump.MDump_WarehouseName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Warehourse))
         {
            idb.AddParameter("@MDump_Warehourse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Warehourse", wH_Dump.MDump_Warehourse);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_WNoName))
         {
            idb.AddParameter("@MDump_WNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WNoName", wH_Dump.MDump_WNoName);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_WNo))
         {
            idb.AddParameter("@MDump_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WNo", wH_Dump.MDump_WNo);
         }
         if (wH_Dump.MDump_Count == 0)
         {
            idb.AddParameter("@MDump_Count", 0);
         }
         else
         {
            idb.AddParameter("@MDump_Count", wH_Dump.MDump_Count);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Unit))
         {
            idb.AddParameter("@MDump_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Unit", wH_Dump.MDump_Unit);
         }
         if (wH_Dump.MDump_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MDump_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Date", wH_Dump.MDump_Date);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Operator))
         {
            idb.AddParameter("@MDump_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Operator", wH_Dump.MDump_Operator);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Remark))
         {
            idb.AddParameter("@MDump_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Remark", wH_Dump.MDump_Remark);
         }
         if (wH_Dump.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Dump.Stat);
         }
         if (wH_Dump.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Dump.CreateDate);
         }
         if (wH_Dump.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Dump.UpdateDate);
         }
         if (wH_Dump.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Dump.DeleteDate);
         }
         if (wH_Dump.MDump_OldCount == 0)
         {
            idb.AddParameter("@MDump_OldCount", 0);
         }
         else
         {
            idb.AddParameter("@MDump_OldCount", wH_Dump.MDump_OldCount);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_Company))
         {
            idb.AddParameter("@MDump_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Company", wH_Dump.MDump_Company);
         }
         if (string.IsNullOrEmpty(wH_Dump.MDump_CompanyCode))
         {
            idb.AddParameter("@MDump_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_CompanyCode", wH_Dump.MDump_CompanyCode);
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
      /// 更新库存转储信息 WH_Dump对象(即:一条记录
      /// </summary>
      public int Update(WH_Dump wH_Dump)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Dump       SET ");
            if(wH_Dump.MDump_Code_IsChanged){sbParameter.Append("MDump_Code=@MDump_Code, ");}
      if(wH_Dump.MDump_MCode_IsChanged){sbParameter.Append("MDump_MCode=@MDump_MCode, ");}
      if(wH_Dump.MDump_MName_IsChanged){sbParameter.Append("MDump_MName=@MDump_MName, ");}
      if(wH_Dump.MDump_Description_IsChanged){sbParameter.Append("MDump_Description=@MDump_Description, ");}
      if(wH_Dump.MDump_OldWarehouseName_IsChanged){sbParameter.Append("MDump_OldWarehouseName=@MDump_OldWarehouseName, ");}
      if(wH_Dump.MDump_OldWarehouse_IsChanged){sbParameter.Append("MDump_OldWarehouse=@MDump_OldWarehouse, ");}
      if(wH_Dump.MDump_OldWNoName_IsChanged){sbParameter.Append("MDump_OldWNoName=@MDump_OldWNoName, ");}
      if(wH_Dump.MDump_OldWNo_IsChanged){sbParameter.Append("MDump_OldWNo=@MDump_OldWNo, ");}
      if(wH_Dump.MDump_WarehouseName_IsChanged){sbParameter.Append("MDump_WarehouseName=@MDump_WarehouseName, ");}
      if(wH_Dump.MDump_Warehourse_IsChanged){sbParameter.Append("MDump_Warehourse=@MDump_Warehourse, ");}
      if(wH_Dump.MDump_WNoName_IsChanged){sbParameter.Append("MDump_WNoName=@MDump_WNoName, ");}
      if(wH_Dump.MDump_WNo_IsChanged){sbParameter.Append("MDump_WNo=@MDump_WNo, ");}
      if(wH_Dump.MDump_Count_IsChanged){sbParameter.Append("MDump_Count=@MDump_Count, ");}
      if(wH_Dump.MDump_Unit_IsChanged){sbParameter.Append("MDump_Unit=@MDump_Unit, ");}
      if(wH_Dump.MDump_Date_IsChanged){sbParameter.Append("MDump_Date=@MDump_Date, ");}
      if(wH_Dump.MDump_Operator_IsChanged){sbParameter.Append("MDump_Operator=@MDump_Operator, ");}
      if(wH_Dump.MDump_Remark_IsChanged){sbParameter.Append("MDump_Remark=@MDump_Remark, ");}
      if(wH_Dump.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Dump.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Dump.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Dump.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Dump.MDump_OldCount_IsChanged){sbParameter.Append("MDump_OldCount=@MDump_OldCount, ");}
      if(wH_Dump.MDump_Company_IsChanged){sbParameter.Append("MDump_Company=@MDump_Company, ");}
      if(wH_Dump.MDump_CompanyCode_IsChanged){sbParameter.Append("MDump_CompanyCode=@MDump_CompanyCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MDump_ID=@MDump_ID; " );
      string sql=sb.ToString();
         if(wH_Dump.MDump_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_Code))
         {
            idb.AddParameter("@MDump_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Code", wH_Dump.MDump_Code);
         }
          }
         if(wH_Dump.MDump_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_MCode))
         {
            idb.AddParameter("@MDump_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_MCode", wH_Dump.MDump_MCode);
         }
          }
         if(wH_Dump.MDump_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_MName))
         {
            idb.AddParameter("@MDump_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_MName", wH_Dump.MDump_MName);
         }
          }
         if(wH_Dump.MDump_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_Description))
         {
            idb.AddParameter("@MDump_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Description", wH_Dump.MDump_Description);
         }
          }
         if(wH_Dump.MDump_OldWarehouseName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWarehouseName))
         {
            idb.AddParameter("@MDump_OldWarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWarehouseName", wH_Dump.MDump_OldWarehouseName);
         }
          }
         if(wH_Dump.MDump_OldWarehouse_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWarehouse))
         {
            idb.AddParameter("@MDump_OldWarehouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWarehouse", wH_Dump.MDump_OldWarehouse);
         }
          }
         if(wH_Dump.MDump_OldWNoName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWNoName))
         {
            idb.AddParameter("@MDump_OldWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWNoName", wH_Dump.MDump_OldWNoName);
         }
          }
         if(wH_Dump.MDump_OldWNo_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_OldWNo))
         {
            idb.AddParameter("@MDump_OldWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_OldWNo", wH_Dump.MDump_OldWNo);
         }
          }
         if(wH_Dump.MDump_WarehouseName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_WarehouseName))
         {
            idb.AddParameter("@MDump_WarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WarehouseName", wH_Dump.MDump_WarehouseName);
         }
          }
         if(wH_Dump.MDump_Warehourse_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_Warehourse))
         {
            idb.AddParameter("@MDump_Warehourse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Warehourse", wH_Dump.MDump_Warehourse);
         }
          }
         if(wH_Dump.MDump_WNoName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_WNoName))
         {
            idb.AddParameter("@MDump_WNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WNoName", wH_Dump.MDump_WNoName);
         }
          }
         if(wH_Dump.MDump_WNo_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_WNo))
         {
            idb.AddParameter("@MDump_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_WNo", wH_Dump.MDump_WNo);
         }
          }
         if(wH_Dump.MDump_Count_IsChanged)
         {
         if (wH_Dump.MDump_Count == 0)
         {
            idb.AddParameter("@MDump_Count", 0);
         }
         else
         {
            idb.AddParameter("@MDump_Count", wH_Dump.MDump_Count);
         }
          }
         if(wH_Dump.MDump_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_Unit))
         {
            idb.AddParameter("@MDump_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Unit", wH_Dump.MDump_Unit);
         }
          }
         if(wH_Dump.MDump_Date_IsChanged)
         {
         if (wH_Dump.MDump_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MDump_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Date", wH_Dump.MDump_Date);
         }
          }
         if(wH_Dump.MDump_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_Operator))
         {
            idb.AddParameter("@MDump_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Operator", wH_Dump.MDump_Operator);
         }
          }
         if(wH_Dump.MDump_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_Remark))
         {
            idb.AddParameter("@MDump_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Remark", wH_Dump.MDump_Remark);
         }
          }
         if(wH_Dump.Stat_IsChanged)
         {
         if (wH_Dump.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Dump.Stat);
         }
          }
         if(wH_Dump.CreateDate_IsChanged)
         {
         if (wH_Dump.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Dump.CreateDate);
         }
          }
         if(wH_Dump.UpdateDate_IsChanged)
         {
         if (wH_Dump.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Dump.UpdateDate);
         }
          }
         if(wH_Dump.DeleteDate_IsChanged)
         {
         if (wH_Dump.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Dump.DeleteDate);
         }
          }
         if(wH_Dump.MDump_OldCount_IsChanged)
         {
         if (wH_Dump.MDump_OldCount == 0)
         {
            idb.AddParameter("@MDump_OldCount", 0);
         }
         else
         {
            idb.AddParameter("@MDump_OldCount", wH_Dump.MDump_OldCount);
         }
          }
         if(wH_Dump.MDump_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_Company))
         {
            idb.AddParameter("@MDump_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_Company", wH_Dump.MDump_Company);
         }
          }
         if(wH_Dump.MDump_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Dump.MDump_CompanyCode))
         {
            idb.AddParameter("@MDump_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDump_CompanyCode", wH_Dump.MDump_CompanyCode);
         }
          }

         idb.AddParameter("@MDump_ID", wH_Dump.MDump_ID);

           
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
      /// 删除库存转储信息 WH_Dump对象(即:一条记录
      /// </summary>
      public int Delete(decimal mDump_ID)
      {
         string sql = "DELETE WH_Dump WHERE 1=1  AND MDump_ID=@MDump_ID ";
         idb.AddParameter("@MDump_ID", mDump_ID);

           
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
      /// 获取指定的库存转储信息 WH_Dump对象(即:一条记录
      /// </summary>
      public WH_Dump GetByKey(decimal mDump_ID)
      {
         WH_Dump wH_Dump = new WH_Dump();
         string sql = "SELECT  MDump_ID,MDump_Code,MDump_MCode,MDump_MName,MDump_Description,MDump_OldWarehouseName,MDump_OldWarehouse,MDump_OldWNoName,MDump_OldWNo,MDump_WarehouseName,MDump_Warehourse,MDump_WNoName,MDump_WNo,MDump_Count,MDump_Unit,MDump_Date,MDump_Operator,MDump_Remark,Stat,CreateDate,UpdateDate,DeleteDate,MDump_OldCount,MDump_Company,MDump_CompanyCode FROM WH_Dump WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MDump_ID=@MDump_ID ";
         idb.AddParameter("@MDump_ID", mDump_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MDump_ID"] != DBNull.Value) wH_Dump.MDump_ID = Convert.ToDecimal(dr["MDump_ID"]);
            if (dr["MDump_Code"] != DBNull.Value) wH_Dump.MDump_Code = Convert.ToString(dr["MDump_Code"]);
            if (dr["MDump_MCode"] != DBNull.Value) wH_Dump.MDump_MCode = Convert.ToString(dr["MDump_MCode"]);
            if (dr["MDump_MName"] != DBNull.Value) wH_Dump.MDump_MName = Convert.ToString(dr["MDump_MName"]);
            if (dr["MDump_Description"] != DBNull.Value) wH_Dump.MDump_Description = Convert.ToString(dr["MDump_Description"]);
            if (dr["MDump_OldWarehouseName"] != DBNull.Value) wH_Dump.MDump_OldWarehouseName = Convert.ToString(dr["MDump_OldWarehouseName"]);
            if (dr["MDump_OldWarehouse"] != DBNull.Value) wH_Dump.MDump_OldWarehouse = Convert.ToString(dr["MDump_OldWarehouse"]);
            if (dr["MDump_OldWNoName"] != DBNull.Value) wH_Dump.MDump_OldWNoName = Convert.ToString(dr["MDump_OldWNoName"]);
            if (dr["MDump_OldWNo"] != DBNull.Value) wH_Dump.MDump_OldWNo = Convert.ToString(dr["MDump_OldWNo"]);
            if (dr["MDump_WarehouseName"] != DBNull.Value) wH_Dump.MDump_WarehouseName = Convert.ToString(dr["MDump_WarehouseName"]);
            if (dr["MDump_Warehourse"] != DBNull.Value) wH_Dump.MDump_Warehourse = Convert.ToString(dr["MDump_Warehourse"]);
            if (dr["MDump_WNoName"] != DBNull.Value) wH_Dump.MDump_WNoName = Convert.ToString(dr["MDump_WNoName"]);
            if (dr["MDump_WNo"] != DBNull.Value) wH_Dump.MDump_WNo = Convert.ToString(dr["MDump_WNo"]);
            if (dr["MDump_Count"] != DBNull.Value) wH_Dump.MDump_Count = Convert.ToDecimal(dr["MDump_Count"]);
            if (dr["MDump_Unit"] != DBNull.Value) wH_Dump.MDump_Unit = Convert.ToString(dr["MDump_Unit"]);
            if (dr["MDump_Date"] != DBNull.Value) wH_Dump.MDump_Date = Convert.ToDateTime(dr["MDump_Date"]);
            if (dr["MDump_Operator"] != DBNull.Value) wH_Dump.MDump_Operator = Convert.ToString(dr["MDump_Operator"]);
            if (dr["MDump_Remark"] != DBNull.Value) wH_Dump.MDump_Remark = Convert.ToString(dr["MDump_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_Dump.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Dump.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Dump.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Dump.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MDump_OldCount"] != DBNull.Value) wH_Dump.MDump_OldCount = Convert.ToDecimal(dr["MDump_OldCount"]);
            if (dr["MDump_Company"] != DBNull.Value) wH_Dump.MDump_Company = Convert.ToString(dr["MDump_Company"]);
            if (dr["MDump_CompanyCode"] != DBNull.Value) wH_Dump.MDump_CompanyCode = Convert.ToString(dr["MDump_CompanyCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Dump;
      }
      /// <summary>
      /// 获取指定的库存转储信息 WH_Dump对象集合
      /// </summary>
      public List<WH_Dump> GetListByWhere(string strCondition)
      {
         List<WH_Dump> ret = new List<WH_Dump>();
         string sql = "SELECT  MDump_ID,MDump_Code,MDump_MCode,MDump_MName,MDump_Description,MDump_OldWarehouseName,MDump_OldWarehouse,MDump_OldWNoName,MDump_OldWNo,MDump_WarehouseName,MDump_Warehourse,MDump_WNoName,MDump_WNo,MDump_Count,MDump_Unit,MDump_Date,MDump_Operator,MDump_Remark,Stat,CreateDate,UpdateDate,DeleteDate,MDump_OldCount,MDump_Company,MDump_CompanyCode FROM WH_Dump WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Dump wH_Dump = new WH_Dump();
            if (dr["MDump_ID"] != DBNull.Value) wH_Dump.MDump_ID = Convert.ToDecimal(dr["MDump_ID"]);
            if (dr["MDump_Code"] != DBNull.Value) wH_Dump.MDump_Code = Convert.ToString(dr["MDump_Code"]);
            if (dr["MDump_MCode"] != DBNull.Value) wH_Dump.MDump_MCode = Convert.ToString(dr["MDump_MCode"]);
            if (dr["MDump_MName"] != DBNull.Value) wH_Dump.MDump_MName = Convert.ToString(dr["MDump_MName"]);
            if (dr["MDump_Description"] != DBNull.Value) wH_Dump.MDump_Description = Convert.ToString(dr["MDump_Description"]);
            if (dr["MDump_OldWarehouseName"] != DBNull.Value) wH_Dump.MDump_OldWarehouseName = Convert.ToString(dr["MDump_OldWarehouseName"]);
            if (dr["MDump_OldWarehouse"] != DBNull.Value) wH_Dump.MDump_OldWarehouse = Convert.ToString(dr["MDump_OldWarehouse"]);
            if (dr["MDump_OldWNoName"] != DBNull.Value) wH_Dump.MDump_OldWNoName = Convert.ToString(dr["MDump_OldWNoName"]);
            if (dr["MDump_OldWNo"] != DBNull.Value) wH_Dump.MDump_OldWNo = Convert.ToString(dr["MDump_OldWNo"]);
            if (dr["MDump_WarehouseName"] != DBNull.Value) wH_Dump.MDump_WarehouseName = Convert.ToString(dr["MDump_WarehouseName"]);
            if (dr["MDump_Warehourse"] != DBNull.Value) wH_Dump.MDump_Warehourse = Convert.ToString(dr["MDump_Warehourse"]);
            if (dr["MDump_WNoName"] != DBNull.Value) wH_Dump.MDump_WNoName = Convert.ToString(dr["MDump_WNoName"]);
            if (dr["MDump_WNo"] != DBNull.Value) wH_Dump.MDump_WNo = Convert.ToString(dr["MDump_WNo"]);
            if (dr["MDump_Count"] != DBNull.Value) wH_Dump.MDump_Count = Convert.ToDecimal(dr["MDump_Count"]);
            if (dr["MDump_Unit"] != DBNull.Value) wH_Dump.MDump_Unit = Convert.ToString(dr["MDump_Unit"]);
            if (dr["MDump_Date"] != DBNull.Value) wH_Dump.MDump_Date = Convert.ToDateTime(dr["MDump_Date"]);
            if (dr["MDump_Operator"] != DBNull.Value) wH_Dump.MDump_Operator = Convert.ToString(dr["MDump_Operator"]);
            if (dr["MDump_Remark"] != DBNull.Value) wH_Dump.MDump_Remark = Convert.ToString(dr["MDump_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_Dump.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Dump.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Dump.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Dump.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MDump_OldCount"] != DBNull.Value) wH_Dump.MDump_OldCount = Convert.ToDecimal(dr["MDump_OldCount"]);
            if (dr["MDump_Company"] != DBNull.Value) wH_Dump.MDump_Company = Convert.ToString(dr["MDump_Company"]);
            if (dr["MDump_CompanyCode"] != DBNull.Value) wH_Dump.MDump_CompanyCode = Convert.ToString(dr["MDump_CompanyCode"]);
            ret.Add(wH_Dump);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的库存转储信息 WH_Dump对象(即:一条记录
      /// </summary>
      public List<WH_Dump> GetAll()
      {
         List<WH_Dump> ret = new List<WH_Dump>();
         string sql = "SELECT  MDump_ID,MDump_Code,MDump_MCode,MDump_MName,MDump_Description,MDump_OldWarehouseName,MDump_OldWarehouse,MDump_OldWNoName,MDump_OldWNo,MDump_WarehouseName,MDump_Warehourse,MDump_WNoName,MDump_WNo,MDump_Count,MDump_Unit,MDump_Date,MDump_Operator,MDump_Remark,Stat,CreateDate,UpdateDate,DeleteDate,MDump_OldCount,MDump_Company,MDump_CompanyCode FROM WH_Dump where 1=1 AND ((Stat is null) or (Stat=0) ) order by MDump_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Dump wH_Dump = new WH_Dump();
            if (dr["MDump_ID"] != DBNull.Value) wH_Dump.MDump_ID = Convert.ToDecimal(dr["MDump_ID"]);
            if (dr["MDump_Code"] != DBNull.Value) wH_Dump.MDump_Code = Convert.ToString(dr["MDump_Code"]);
            if (dr["MDump_MCode"] != DBNull.Value) wH_Dump.MDump_MCode = Convert.ToString(dr["MDump_MCode"]);
            if (dr["MDump_MName"] != DBNull.Value) wH_Dump.MDump_MName = Convert.ToString(dr["MDump_MName"]);
            if (dr["MDump_Description"] != DBNull.Value) wH_Dump.MDump_Description = Convert.ToString(dr["MDump_Description"]);
            if (dr["MDump_OldWarehouseName"] != DBNull.Value) wH_Dump.MDump_OldWarehouseName = Convert.ToString(dr["MDump_OldWarehouseName"]);
            if (dr["MDump_OldWarehouse"] != DBNull.Value) wH_Dump.MDump_OldWarehouse = Convert.ToString(dr["MDump_OldWarehouse"]);
            if (dr["MDump_OldWNoName"] != DBNull.Value) wH_Dump.MDump_OldWNoName = Convert.ToString(dr["MDump_OldWNoName"]);
            if (dr["MDump_OldWNo"] != DBNull.Value) wH_Dump.MDump_OldWNo = Convert.ToString(dr["MDump_OldWNo"]);
            if (dr["MDump_WarehouseName"] != DBNull.Value) wH_Dump.MDump_WarehouseName = Convert.ToString(dr["MDump_WarehouseName"]);
            if (dr["MDump_Warehourse"] != DBNull.Value) wH_Dump.MDump_Warehourse = Convert.ToString(dr["MDump_Warehourse"]);
            if (dr["MDump_WNoName"] != DBNull.Value) wH_Dump.MDump_WNoName = Convert.ToString(dr["MDump_WNoName"]);
            if (dr["MDump_WNo"] != DBNull.Value) wH_Dump.MDump_WNo = Convert.ToString(dr["MDump_WNo"]);
            if (dr["MDump_Count"] != DBNull.Value) wH_Dump.MDump_Count = Convert.ToDecimal(dr["MDump_Count"]);
            if (dr["MDump_Unit"] != DBNull.Value) wH_Dump.MDump_Unit = Convert.ToString(dr["MDump_Unit"]);
            if (dr["MDump_Date"] != DBNull.Value) wH_Dump.MDump_Date = Convert.ToDateTime(dr["MDump_Date"]);
            if (dr["MDump_Operator"] != DBNull.Value) wH_Dump.MDump_Operator = Convert.ToString(dr["MDump_Operator"]);
            if (dr["MDump_Remark"] != DBNull.Value) wH_Dump.MDump_Remark = Convert.ToString(dr["MDump_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_Dump.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Dump.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Dump.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Dump.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MDump_OldCount"] != DBNull.Value) wH_Dump.MDump_OldCount = Convert.ToDecimal(dr["MDump_OldCount"]);
            if (dr["MDump_Company"] != DBNull.Value) wH_Dump.MDump_Company = Convert.ToString(dr["MDump_Company"]);
            if (dr["MDump_CompanyCode"] != DBNull.Value) wH_Dump.MDump_CompanyCode = Convert.ToString(dr["MDump_CompanyCode"]);
            ret.Add(wH_Dump);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
