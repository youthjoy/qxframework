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
   /// 库存量信息表
   /// </summary>
   [Serializable]
   public partial class ADOWH_Storage
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加库存量信息表 WH_Storage对象(即:一条记录)
      /// </summary>
      public int Add(WH_Storage wH_Storage)
      {
         string sql = "INSERT INTO WH_Storage (Storage_Code,Storage_MaterielCode,Storage_WarehouseCode,Storage_WarehouseNo,Storage_Count,Storage_PromiseCount,Storage_OrderCount,Storage_Available,Storage_TNum,Storage_LNum,Storage_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Storage_Warehouse,Storage_WarehouseNoName,Storage_Company,Storage_CompanyCode,Storage_Dvalue,Storage_Price,Storage_UDEF1,Storage_UDEF2,Storage_UDEF3,Storage_UDEF4,Storage_UDEF5) VALUES (@Storage_Code,@Storage_MaterielCode,@Storage_WarehouseCode,@Storage_WarehouseNo,@Storage_Count,@Storage_PromiseCount,@Storage_OrderCount,@Storage_Available,@Storage_TNum,@Storage_LNum,@Storage_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Storage_Warehouse,@Storage_WarehouseNoName,@Storage_Company,@Storage_CompanyCode,@Storage_Dvalue,@Storage_Price,@Storage_UDEF1,@Storage_UDEF2,@Storage_UDEF3,@Storage_UDEF4,@Storage_UDEF5)";
         if (string.IsNullOrEmpty(wH_Storage.Storage_Code))
         {
            idb.AddParameter("@Storage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Code", wH_Storage.Storage_Code);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_MaterielCode))
         {
            idb.AddParameter("@Storage_MaterielCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_MaterielCode", wH_Storage.Storage_MaterielCode);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseCode))
         {
            idb.AddParameter("@Storage_WarehouseCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseCode", wH_Storage.Storage_WarehouseCode);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseNo))
         {
            idb.AddParameter("@Storage_WarehouseNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseNo", wH_Storage.Storage_WarehouseNo);
         }
         if (wH_Storage.Storage_Count == 0)
         {
            idb.AddParameter("@Storage_Count", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Count", wH_Storage.Storage_Count);
         }
         if (wH_Storage.Storage_PromiseCount == 0)
         {
            idb.AddParameter("@Storage_PromiseCount", 0);
         }
         else
         {
            idb.AddParameter("@Storage_PromiseCount", wH_Storage.Storage_PromiseCount);
         }
         if (wH_Storage.Storage_OrderCount == 0)
         {
            idb.AddParameter("@Storage_OrderCount", 0);
         }
         else
         {
            idb.AddParameter("@Storage_OrderCount", wH_Storage.Storage_OrderCount);
         }
         if (wH_Storage.Storage_Available == 0)
         {
            idb.AddParameter("@Storage_Available", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Available", wH_Storage.Storage_Available);
         }
         if (wH_Storage.Storage_TNum == 0)
         {
            idb.AddParameter("@Storage_TNum", 0);
         }
         else
         {
            idb.AddParameter("@Storage_TNum", wH_Storage.Storage_TNum);
         }
         if (wH_Storage.Storage_LNum == 0)
         {
            idb.AddParameter("@Storage_LNum", 0);
         }
         else
         {
            idb.AddParameter("@Storage_LNum", wH_Storage.Storage_LNum);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_Remark))
         {
            idb.AddParameter("@Storage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Remark", wH_Storage.Storage_Remark);
         }
         if (wH_Storage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Storage.Stat);
         }
         if (wH_Storage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Storage.CreateDate);
         }
         if (wH_Storage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Storage.UpdateDate);
         }
         if (wH_Storage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Storage.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_Warehouse))
         {
            idb.AddParameter("@Storage_Warehouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Warehouse", wH_Storage.Storage_Warehouse);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseNoName))
         {
            idb.AddParameter("@Storage_WarehouseNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseNoName", wH_Storage.Storage_WarehouseNoName);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_Company))
         {
            idb.AddParameter("@Storage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Company", wH_Storage.Storage_Company);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_CompanyCode))
         {
            idb.AddParameter("@Storage_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_CompanyCode", wH_Storage.Storage_CompanyCode);
         }
         if (wH_Storage.Storage_Dvalue == 0)
         {
            idb.AddParameter("@Storage_Dvalue", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Dvalue", wH_Storage.Storage_Dvalue);
         }
         if (wH_Storage.Storage_Price == 0)
         {
            idb.AddParameter("@Storage_Price", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Price", wH_Storage.Storage_Price);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF1))
         {
            idb.AddParameter("@Storage_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF1", wH_Storage.Storage_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF2))
         {
            idb.AddParameter("@Storage_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF2", wH_Storage.Storage_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF3))
         {
            idb.AddParameter("@Storage_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF3", wH_Storage.Storage_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF4))
         {
            idb.AddParameter("@Storage_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF4", wH_Storage.Storage_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF5))
         {
            idb.AddParameter("@Storage_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF5", wH_Storage.Storage_UDEF5);
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
      /// 添加库存量信息表 WH_Storage对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Storage wH_Storage)
      {
         string sql = "INSERT INTO WH_Storage (Storage_Code,Storage_MaterielCode,Storage_WarehouseCode,Storage_WarehouseNo,Storage_Count,Storage_PromiseCount,Storage_OrderCount,Storage_Available,Storage_TNum,Storage_LNum,Storage_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Storage_Warehouse,Storage_WarehouseNoName,Storage_Company,Storage_CompanyCode,Storage_Dvalue,Storage_Price,Storage_UDEF1,Storage_UDEF2,Storage_UDEF3,Storage_UDEF4,Storage_UDEF5) VALUES (@Storage_Code,@Storage_MaterielCode,@Storage_WarehouseCode,@Storage_WarehouseNo,@Storage_Count,@Storage_PromiseCount,@Storage_OrderCount,@Storage_Available,@Storage_TNum,@Storage_LNum,@Storage_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Storage_Warehouse,@Storage_WarehouseNoName,@Storage_Company,@Storage_CompanyCode,@Storage_Dvalue,@Storage_Price,@Storage_UDEF1,@Storage_UDEF2,@Storage_UDEF3,@Storage_UDEF4,@Storage_UDEF5);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Storage.Storage_Code))
         {
            idb.AddParameter("@Storage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Code", wH_Storage.Storage_Code);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_MaterielCode))
         {
            idb.AddParameter("@Storage_MaterielCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_MaterielCode", wH_Storage.Storage_MaterielCode);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseCode))
         {
            idb.AddParameter("@Storage_WarehouseCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseCode", wH_Storage.Storage_WarehouseCode);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseNo))
         {
            idb.AddParameter("@Storage_WarehouseNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseNo", wH_Storage.Storage_WarehouseNo);
         }
         if (wH_Storage.Storage_Count == 0)
         {
            idb.AddParameter("@Storage_Count", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Count", wH_Storage.Storage_Count);
         }
         if (wH_Storage.Storage_PromiseCount == 0)
         {
            idb.AddParameter("@Storage_PromiseCount", 0);
         }
         else
         {
            idb.AddParameter("@Storage_PromiseCount", wH_Storage.Storage_PromiseCount);
         }
         if (wH_Storage.Storage_OrderCount == 0)
         {
            idb.AddParameter("@Storage_OrderCount", 0);
         }
         else
         {
            idb.AddParameter("@Storage_OrderCount", wH_Storage.Storage_OrderCount);
         }
         if (wH_Storage.Storage_Available == 0)
         {
            idb.AddParameter("@Storage_Available", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Available", wH_Storage.Storage_Available);
         }
         if (wH_Storage.Storage_TNum == 0)
         {
            idb.AddParameter("@Storage_TNum", 0);
         }
         else
         {
            idb.AddParameter("@Storage_TNum", wH_Storage.Storage_TNum);
         }
         if (wH_Storage.Storage_LNum == 0)
         {
            idb.AddParameter("@Storage_LNum", 0);
         }
         else
         {
            idb.AddParameter("@Storage_LNum", wH_Storage.Storage_LNum);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_Remark))
         {
            idb.AddParameter("@Storage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Remark", wH_Storage.Storage_Remark);
         }
         if (wH_Storage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Storage.Stat);
         }
         if (wH_Storage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Storage.CreateDate);
         }
         if (wH_Storage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Storage.UpdateDate);
         }
         if (wH_Storage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Storage.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_Warehouse))
         {
            idb.AddParameter("@Storage_Warehouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Warehouse", wH_Storage.Storage_Warehouse);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseNoName))
         {
            idb.AddParameter("@Storage_WarehouseNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseNoName", wH_Storage.Storage_WarehouseNoName);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_Company))
         {
            idb.AddParameter("@Storage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Company", wH_Storage.Storage_Company);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_CompanyCode))
         {
            idb.AddParameter("@Storage_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_CompanyCode", wH_Storage.Storage_CompanyCode);
         }
         if (wH_Storage.Storage_Dvalue == 0)
         {
            idb.AddParameter("@Storage_Dvalue", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Dvalue", wH_Storage.Storage_Dvalue);
         }
         if (wH_Storage.Storage_Price == 0)
         {
            idb.AddParameter("@Storage_Price", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Price", wH_Storage.Storage_Price);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF1))
         {
            idb.AddParameter("@Storage_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF1", wH_Storage.Storage_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF2))
         {
            idb.AddParameter("@Storage_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF2", wH_Storage.Storage_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF3))
         {
            idb.AddParameter("@Storage_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF3", wH_Storage.Storage_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF4))
         {
            idb.AddParameter("@Storage_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF4", wH_Storage.Storage_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF5))
         {
            idb.AddParameter("@Storage_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF5", wH_Storage.Storage_UDEF5);
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
      /// 更新库存量信息表 WH_Storage对象(即:一条记录
      /// </summary>
      public int Update(WH_Storage wH_Storage)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Storage       SET ");
            if(wH_Storage.Storage_Code_IsChanged){sbParameter.Append("Storage_Code=@Storage_Code, ");}
      if(wH_Storage.Storage_MaterielCode_IsChanged){sbParameter.Append("Storage_MaterielCode=@Storage_MaterielCode, ");}
      if(wH_Storage.Storage_WarehouseCode_IsChanged){sbParameter.Append("Storage_WarehouseCode=@Storage_WarehouseCode, ");}
      if(wH_Storage.Storage_WarehouseNo_IsChanged){sbParameter.Append("Storage_WarehouseNo=@Storage_WarehouseNo, ");}
      if(wH_Storage.Storage_Count_IsChanged){sbParameter.Append("Storage_Count=@Storage_Count, ");}
      if(wH_Storage.Storage_PromiseCount_IsChanged){sbParameter.Append("Storage_PromiseCount=@Storage_PromiseCount, ");}
      if(wH_Storage.Storage_OrderCount_IsChanged){sbParameter.Append("Storage_OrderCount=@Storage_OrderCount, ");}
      if(wH_Storage.Storage_Available_IsChanged){sbParameter.Append("Storage_Available=@Storage_Available, ");}
      if(wH_Storage.Storage_TNum_IsChanged){sbParameter.Append("Storage_TNum=@Storage_TNum, ");}
      if(wH_Storage.Storage_LNum_IsChanged){sbParameter.Append("Storage_LNum=@Storage_LNum, ");}
      if(wH_Storage.Storage_Remark_IsChanged){sbParameter.Append("Storage_Remark=@Storage_Remark, ");}
      if(wH_Storage.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Storage.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Storage.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Storage.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Storage.Storage_Warehouse_IsChanged){sbParameter.Append("Storage_Warehouse=@Storage_Warehouse, ");}
      if(wH_Storage.Storage_WarehouseNoName_IsChanged){sbParameter.Append("Storage_WarehouseNoName=@Storage_WarehouseNoName, ");}
      if(wH_Storage.Storage_Company_IsChanged){sbParameter.Append("Storage_Company=@Storage_Company, ");}
      if(wH_Storage.Storage_CompanyCode_IsChanged){sbParameter.Append("Storage_CompanyCode=@Storage_CompanyCode, ");}
      if(wH_Storage.Storage_Dvalue_IsChanged){sbParameter.Append("Storage_Dvalue=@Storage_Dvalue, ");}
      if(wH_Storage.Storage_Price_IsChanged){sbParameter.Append("Storage_Price=@Storage_Price, ");}
      if(wH_Storage.Storage_UDEF1_IsChanged){sbParameter.Append("Storage_UDEF1=@Storage_UDEF1, ");}
      if(wH_Storage.Storage_UDEF2_IsChanged){sbParameter.Append("Storage_UDEF2=@Storage_UDEF2, ");}
      if(wH_Storage.Storage_UDEF3_IsChanged){sbParameter.Append("Storage_UDEF3=@Storage_UDEF3, ");}
      if(wH_Storage.Storage_UDEF4_IsChanged){sbParameter.Append("Storage_UDEF4=@Storage_UDEF4, ");}
      if(wH_Storage.Storage_UDEF5_IsChanged){sbParameter.Append("Storage_UDEF5=@Storage_UDEF5 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Storage_ID=@Storage_ID; " );
      string sql=sb.ToString();
         if(wH_Storage.Storage_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_Code))
         {
            idb.AddParameter("@Storage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Code", wH_Storage.Storage_Code);
         }
          }
         if(wH_Storage.Storage_MaterielCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_MaterielCode))
         {
            idb.AddParameter("@Storage_MaterielCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_MaterielCode", wH_Storage.Storage_MaterielCode);
         }
          }
         if(wH_Storage.Storage_WarehouseCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseCode))
         {
            idb.AddParameter("@Storage_WarehouseCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseCode", wH_Storage.Storage_WarehouseCode);
         }
          }
         if(wH_Storage.Storage_WarehouseNo_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseNo))
         {
            idb.AddParameter("@Storage_WarehouseNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseNo", wH_Storage.Storage_WarehouseNo);
         }
          }
         if(wH_Storage.Storage_Count_IsChanged)
         {
         if (wH_Storage.Storage_Count == 0)
         {
            idb.AddParameter("@Storage_Count", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Count", wH_Storage.Storage_Count);
         }
          }
         if(wH_Storage.Storage_PromiseCount_IsChanged)
         {
         if (wH_Storage.Storage_PromiseCount == 0)
         {
            idb.AddParameter("@Storage_PromiseCount", 0);
         }
         else
         {
            idb.AddParameter("@Storage_PromiseCount", wH_Storage.Storage_PromiseCount);
         }
          }
         if(wH_Storage.Storage_OrderCount_IsChanged)
         {
         if (wH_Storage.Storage_OrderCount == 0)
         {
            idb.AddParameter("@Storage_OrderCount", 0);
         }
         else
         {
            idb.AddParameter("@Storage_OrderCount", wH_Storage.Storage_OrderCount);
         }
          }
         if(wH_Storage.Storage_Available_IsChanged)
         {
         if (wH_Storage.Storage_Available == 0)
         {
            idb.AddParameter("@Storage_Available", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Available", wH_Storage.Storage_Available);
         }
          }
         if(wH_Storage.Storage_TNum_IsChanged)
         {
         if (wH_Storage.Storage_TNum == 0)
         {
            idb.AddParameter("@Storage_TNum", 0);
         }
         else
         {
            idb.AddParameter("@Storage_TNum", wH_Storage.Storage_TNum);
         }
          }
         if(wH_Storage.Storage_LNum_IsChanged)
         {
         if (wH_Storage.Storage_LNum == 0)
         {
            idb.AddParameter("@Storage_LNum", 0);
         }
         else
         {
            idb.AddParameter("@Storage_LNum", wH_Storage.Storage_LNum);
         }
          }
         if(wH_Storage.Storage_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_Remark))
         {
            idb.AddParameter("@Storage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Remark", wH_Storage.Storage_Remark);
         }
          }
         if(wH_Storage.Stat_IsChanged)
         {
         if (wH_Storage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Storage.Stat);
         }
          }
         if(wH_Storage.CreateDate_IsChanged)
         {
         if (wH_Storage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Storage.CreateDate);
         }
          }
         if(wH_Storage.UpdateDate_IsChanged)
         {
         if (wH_Storage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Storage.UpdateDate);
         }
          }
         if(wH_Storage.DeleteDate_IsChanged)
         {
         if (wH_Storage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Storage.DeleteDate);
         }
          }
         if(wH_Storage.Storage_Warehouse_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_Warehouse))
         {
            idb.AddParameter("@Storage_Warehouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Warehouse", wH_Storage.Storage_Warehouse);
         }
          }
         if(wH_Storage.Storage_WarehouseNoName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_WarehouseNoName))
         {
            idb.AddParameter("@Storage_WarehouseNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_WarehouseNoName", wH_Storage.Storage_WarehouseNoName);
         }
          }
         if(wH_Storage.Storage_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_Company))
         {
            idb.AddParameter("@Storage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_Company", wH_Storage.Storage_Company);
         }
          }
         if(wH_Storage.Storage_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_CompanyCode))
         {
            idb.AddParameter("@Storage_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_CompanyCode", wH_Storage.Storage_CompanyCode);
         }
          }
         if(wH_Storage.Storage_Dvalue_IsChanged)
         {
         if (wH_Storage.Storage_Dvalue == 0)
         {
            idb.AddParameter("@Storage_Dvalue", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Dvalue", wH_Storage.Storage_Dvalue);
         }
          }
         if(wH_Storage.Storage_Price_IsChanged)
         {
         if (wH_Storage.Storage_Price == 0)
         {
            idb.AddParameter("@Storage_Price", 0);
         }
         else
         {
            idb.AddParameter("@Storage_Price", wH_Storage.Storage_Price);
         }
          }
         if(wH_Storage.Storage_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF1))
         {
            idb.AddParameter("@Storage_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF1", wH_Storage.Storage_UDEF1);
         }
          }
         if(wH_Storage.Storage_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF2))
         {
            idb.AddParameter("@Storage_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF2", wH_Storage.Storage_UDEF2);
         }
          }
         if(wH_Storage.Storage_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF3))
         {
            idb.AddParameter("@Storage_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF3", wH_Storage.Storage_UDEF3);
         }
          }
         if(wH_Storage.Storage_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF4))
         {
            idb.AddParameter("@Storage_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF4", wH_Storage.Storage_UDEF4);
         }
          }
         if(wH_Storage.Storage_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Storage.Storage_UDEF5))
         {
            idb.AddParameter("@Storage_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Storage_UDEF5", wH_Storage.Storage_UDEF5);
         }
          }

         idb.AddParameter("@Storage_ID", wH_Storage.Storage_ID);

           
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
      /// 删除库存量信息表 WH_Storage对象(即:一条记录
      /// </summary>
      public int Delete(decimal storage_ID)
      {
         string sql = "DELETE WH_Storage WHERE 1=1  AND Storage_ID=@Storage_ID ";
         idb.AddParameter("@Storage_ID", storage_ID);

           
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
      /// 获取指定的库存量信息表 WH_Storage对象(即:一条记录
      /// </summary>
      public WH_Storage GetByKey(decimal storage_ID)
      {
         WH_Storage wH_Storage = new WH_Storage();
         string sql = "SELECT  Storage_ID,Storage_Code,Storage_MaterielCode,Storage_WarehouseCode,Storage_WarehouseNo,Storage_Count,Storage_PromiseCount,Storage_OrderCount,Storage_Available,Storage_TNum,Storage_LNum,Storage_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Storage_Warehouse,Storage_WarehouseNoName,Storage_Company,Storage_CompanyCode,Storage_Dvalue,Storage_Price,Storage_UDEF1,Storage_UDEF2,Storage_UDEF3,Storage_UDEF4,Storage_UDEF5 FROM WH_Storage WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Storage_ID=@Storage_ID ";
         idb.AddParameter("@Storage_ID", storage_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Storage_ID"] != DBNull.Value) wH_Storage.Storage_ID = Convert.ToDecimal(dr["Storage_ID"]);
            if (dr["Storage_Code"] != DBNull.Value) wH_Storage.Storage_Code = Convert.ToString(dr["Storage_Code"]);
            if (dr["Storage_MaterielCode"] != DBNull.Value) wH_Storage.Storage_MaterielCode = Convert.ToString(dr["Storage_MaterielCode"]);
            if (dr["Storage_WarehouseCode"] != DBNull.Value) wH_Storage.Storage_WarehouseCode = Convert.ToString(dr["Storage_WarehouseCode"]);
            if (dr["Storage_WarehouseNo"] != DBNull.Value) wH_Storage.Storage_WarehouseNo = Convert.ToString(dr["Storage_WarehouseNo"]);
            if (dr["Storage_Count"] != DBNull.Value) wH_Storage.Storage_Count = Convert.ToDecimal(dr["Storage_Count"]);
            if (dr["Storage_PromiseCount"] != DBNull.Value) wH_Storage.Storage_PromiseCount = Convert.ToDecimal(dr["Storage_PromiseCount"]);
            if (dr["Storage_OrderCount"] != DBNull.Value) wH_Storage.Storage_OrderCount = Convert.ToDecimal(dr["Storage_OrderCount"]);
            if (dr["Storage_Available"] != DBNull.Value) wH_Storage.Storage_Available = Convert.ToDecimal(dr["Storage_Available"]);
            if (dr["Storage_TNum"] != DBNull.Value) wH_Storage.Storage_TNum = Convert.ToDecimal(dr["Storage_TNum"]);
            if (dr["Storage_LNum"] != DBNull.Value) wH_Storage.Storage_LNum = Convert.ToDecimal(dr["Storage_LNum"]);
            if (dr["Storage_Remark"] != DBNull.Value) wH_Storage.Storage_Remark = Convert.ToString(dr["Storage_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_Storage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Storage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Storage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Storage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Storage_Warehouse"] != DBNull.Value) wH_Storage.Storage_Warehouse = Convert.ToString(dr["Storage_Warehouse"]);
            if (dr["Storage_WarehouseNoName"] != DBNull.Value) wH_Storage.Storage_WarehouseNoName = Convert.ToString(dr["Storage_WarehouseNoName"]);
            if (dr["Storage_Company"] != DBNull.Value) wH_Storage.Storage_Company = Convert.ToString(dr["Storage_Company"]);
            if (dr["Storage_CompanyCode"] != DBNull.Value) wH_Storage.Storage_CompanyCode = Convert.ToString(dr["Storage_CompanyCode"]);
            if (dr["Storage_Dvalue"] != DBNull.Value) wH_Storage.Storage_Dvalue = Convert.ToDecimal(dr["Storage_Dvalue"]);
            if (dr["Storage_Price"] != DBNull.Value) wH_Storage.Storage_Price = Convert.ToDecimal(dr["Storage_Price"]);
            if (dr["Storage_UDEF1"] != DBNull.Value) wH_Storage.Storage_UDEF1 = Convert.ToString(dr["Storage_UDEF1"]);
            if (dr["Storage_UDEF2"] != DBNull.Value) wH_Storage.Storage_UDEF2 = Convert.ToString(dr["Storage_UDEF2"]);
            if (dr["Storage_UDEF3"] != DBNull.Value) wH_Storage.Storage_UDEF3 = Convert.ToString(dr["Storage_UDEF3"]);
            if (dr["Storage_UDEF4"] != DBNull.Value) wH_Storage.Storage_UDEF4 = Convert.ToString(dr["Storage_UDEF4"]);
            if (dr["Storage_UDEF5"] != DBNull.Value) wH_Storage.Storage_UDEF5 = Convert.ToString(dr["Storage_UDEF5"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Storage;
      }
      /// <summary>
      /// 获取指定的库存量信息表 WH_Storage对象集合
      /// </summary>
      public List<WH_Storage> GetListByWhere(string strCondition)
      {
         List<WH_Storage> ret = new List<WH_Storage>();
         string sql = "SELECT  Storage_ID,Storage_Code,Storage_MaterielCode,Storage_WarehouseCode,Storage_WarehouseNo,Storage_Count,Storage_PromiseCount,Storage_OrderCount,Storage_Available,Storage_TNum,Storage_LNum,Storage_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Storage_Warehouse,Storage_WarehouseNoName,Storage_Company,Storage_CompanyCode,Storage_Dvalue,Storage_Price,Storage_UDEF1,Storage_UDEF2,Storage_UDEF3,Storage_UDEF4,Storage_UDEF5 FROM WH_Storage WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Storage wH_Storage = new WH_Storage();
            if (dr["Storage_ID"] != DBNull.Value) wH_Storage.Storage_ID = Convert.ToDecimal(dr["Storage_ID"]);
            if (dr["Storage_Code"] != DBNull.Value) wH_Storage.Storage_Code = Convert.ToString(dr["Storage_Code"]);
            if (dr["Storage_MaterielCode"] != DBNull.Value) wH_Storage.Storage_MaterielCode = Convert.ToString(dr["Storage_MaterielCode"]);
            if (dr["Storage_WarehouseCode"] != DBNull.Value) wH_Storage.Storage_WarehouseCode = Convert.ToString(dr["Storage_WarehouseCode"]);
            if (dr["Storage_WarehouseNo"] != DBNull.Value) wH_Storage.Storage_WarehouseNo = Convert.ToString(dr["Storage_WarehouseNo"]);
            if (dr["Storage_Count"] != DBNull.Value) wH_Storage.Storage_Count = Convert.ToDecimal(dr["Storage_Count"]);
            if (dr["Storage_PromiseCount"] != DBNull.Value) wH_Storage.Storage_PromiseCount = Convert.ToDecimal(dr["Storage_PromiseCount"]);
            if (dr["Storage_OrderCount"] != DBNull.Value) wH_Storage.Storage_OrderCount = Convert.ToDecimal(dr["Storage_OrderCount"]);
            if (dr["Storage_Available"] != DBNull.Value) wH_Storage.Storage_Available = Convert.ToDecimal(dr["Storage_Available"]);
            if (dr["Storage_TNum"] != DBNull.Value) wH_Storage.Storage_TNum = Convert.ToDecimal(dr["Storage_TNum"]);
            if (dr["Storage_LNum"] != DBNull.Value) wH_Storage.Storage_LNum = Convert.ToDecimal(dr["Storage_LNum"]);
            if (dr["Storage_Remark"] != DBNull.Value) wH_Storage.Storage_Remark = Convert.ToString(dr["Storage_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_Storage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Storage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Storage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Storage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Storage_Warehouse"] != DBNull.Value) wH_Storage.Storage_Warehouse = Convert.ToString(dr["Storage_Warehouse"]);
            if (dr["Storage_WarehouseNoName"] != DBNull.Value) wH_Storage.Storage_WarehouseNoName = Convert.ToString(dr["Storage_WarehouseNoName"]);
            if (dr["Storage_Company"] != DBNull.Value) wH_Storage.Storage_Company = Convert.ToString(dr["Storage_Company"]);
            if (dr["Storage_CompanyCode"] != DBNull.Value) wH_Storage.Storage_CompanyCode = Convert.ToString(dr["Storage_CompanyCode"]);
            if (dr["Storage_Dvalue"] != DBNull.Value) wH_Storage.Storage_Dvalue = Convert.ToDecimal(dr["Storage_Dvalue"]);
            if (dr["Storage_Price"] != DBNull.Value) wH_Storage.Storage_Price = Convert.ToDecimal(dr["Storage_Price"]);
            if (dr["Storage_UDEF1"] != DBNull.Value) wH_Storage.Storage_UDEF1 = Convert.ToString(dr["Storage_UDEF1"]);
            if (dr["Storage_UDEF2"] != DBNull.Value) wH_Storage.Storage_UDEF2 = Convert.ToString(dr["Storage_UDEF2"]);
            if (dr["Storage_UDEF3"] != DBNull.Value) wH_Storage.Storage_UDEF3 = Convert.ToString(dr["Storage_UDEF3"]);
            if (dr["Storage_UDEF4"] != DBNull.Value) wH_Storage.Storage_UDEF4 = Convert.ToString(dr["Storage_UDEF4"]);
            if (dr["Storage_UDEF5"] != DBNull.Value) wH_Storage.Storage_UDEF5 = Convert.ToString(dr["Storage_UDEF5"]);
            ret.Add(wH_Storage);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的库存量信息表 WH_Storage对象(即:一条记录
      /// </summary>
      public List<WH_Storage> GetAll()
      {
         List<WH_Storage> ret = new List<WH_Storage>();
         string sql = "SELECT  Storage_ID,Storage_Code,Storage_MaterielCode,Storage_WarehouseCode,Storage_WarehouseNo,Storage_Count,Storage_PromiseCount,Storage_OrderCount,Storage_Available,Storage_TNum,Storage_LNum,Storage_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Storage_Warehouse,Storage_WarehouseNoName,Storage_Company,Storage_CompanyCode,Storage_Dvalue,Storage_Price,Storage_UDEF1,Storage_UDEF2,Storage_UDEF3,Storage_UDEF4,Storage_UDEF5 FROM WH_Storage where 1=1 AND ((Stat is null) or (Stat=0) ) order by Storage_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Storage wH_Storage = new WH_Storage();
            if (dr["Storage_ID"] != DBNull.Value) wH_Storage.Storage_ID = Convert.ToDecimal(dr["Storage_ID"]);
            if (dr["Storage_Code"] != DBNull.Value) wH_Storage.Storage_Code = Convert.ToString(dr["Storage_Code"]);
            if (dr["Storage_MaterielCode"] != DBNull.Value) wH_Storage.Storage_MaterielCode = Convert.ToString(dr["Storage_MaterielCode"]);
            if (dr["Storage_WarehouseCode"] != DBNull.Value) wH_Storage.Storage_WarehouseCode = Convert.ToString(dr["Storage_WarehouseCode"]);
            if (dr["Storage_WarehouseNo"] != DBNull.Value) wH_Storage.Storage_WarehouseNo = Convert.ToString(dr["Storage_WarehouseNo"]);
            if (dr["Storage_Count"] != DBNull.Value) wH_Storage.Storage_Count = Convert.ToDecimal(dr["Storage_Count"]);
            if (dr["Storage_PromiseCount"] != DBNull.Value) wH_Storage.Storage_PromiseCount = Convert.ToDecimal(dr["Storage_PromiseCount"]);
            if (dr["Storage_OrderCount"] != DBNull.Value) wH_Storage.Storage_OrderCount = Convert.ToDecimal(dr["Storage_OrderCount"]);
            if (dr["Storage_Available"] != DBNull.Value) wH_Storage.Storage_Available = Convert.ToDecimal(dr["Storage_Available"]);
            if (dr["Storage_TNum"] != DBNull.Value) wH_Storage.Storage_TNum = Convert.ToDecimal(dr["Storage_TNum"]);
            if (dr["Storage_LNum"] != DBNull.Value) wH_Storage.Storage_LNum = Convert.ToDecimal(dr["Storage_LNum"]);
            if (dr["Storage_Remark"] != DBNull.Value) wH_Storage.Storage_Remark = Convert.ToString(dr["Storage_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_Storage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Storage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Storage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Storage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Storage_Warehouse"] != DBNull.Value) wH_Storage.Storage_Warehouse = Convert.ToString(dr["Storage_Warehouse"]);
            if (dr["Storage_WarehouseNoName"] != DBNull.Value) wH_Storage.Storage_WarehouseNoName = Convert.ToString(dr["Storage_WarehouseNoName"]);
            if (dr["Storage_Company"] != DBNull.Value) wH_Storage.Storage_Company = Convert.ToString(dr["Storage_Company"]);
            if (dr["Storage_CompanyCode"] != DBNull.Value) wH_Storage.Storage_CompanyCode = Convert.ToString(dr["Storage_CompanyCode"]);
            if (dr["Storage_Dvalue"] != DBNull.Value) wH_Storage.Storage_Dvalue = Convert.ToDecimal(dr["Storage_Dvalue"]);
            if (dr["Storage_Price"] != DBNull.Value) wH_Storage.Storage_Price = Convert.ToDecimal(dr["Storage_Price"]);
            if (dr["Storage_UDEF1"] != DBNull.Value) wH_Storage.Storage_UDEF1 = Convert.ToString(dr["Storage_UDEF1"]);
            if (dr["Storage_UDEF2"] != DBNull.Value) wH_Storage.Storage_UDEF2 = Convert.ToString(dr["Storage_UDEF2"]);
            if (dr["Storage_UDEF3"] != DBNull.Value) wH_Storage.Storage_UDEF3 = Convert.ToString(dr["Storage_UDEF3"]);
            if (dr["Storage_UDEF4"] != DBNull.Value) wH_Storage.Storage_UDEF4 = Convert.ToString(dr["Storage_UDEF4"]);
            if (dr["Storage_UDEF5"] != DBNull.Value) wH_Storage.Storage_UDEF5 = Convert.ToString(dr["Storage_UDEF5"]);
            ret.Add(wH_Storage);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
