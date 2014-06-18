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
   /// 物料库存信息
   /// </summary>
   [Serializable]
   public partial class ADOWH_WMaterial
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加物料库存信息 WH_WMaterial对象(即:一条记录)
      /// </summary>
      public int Add(WH_WMaterial wH_WMaterial)
      {
         string sql = "INSERT INTO WH_WMaterial (MW_WarehouseCode,MW_WarehouseName,MW_MCode,MW_IsLock,MW_StockNum,MW_IsPromise,MW_IsOrder,MW_IsAble,Stat,MW_High,MW_Low) VALUES (@MW_WarehouseCode,@MW_WarehouseName,@MW_MCode,@MW_IsLock,@MW_StockNum,@MW_IsPromise,@MW_IsOrder,@MW_IsAble,@Stat,@MW_High,@MW_Low)";
         if (string.IsNullOrEmpty(wH_WMaterial.MW_WarehouseCode))
         {
            idb.AddParameter("@MW_WarehouseCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_WarehouseCode", wH_WMaterial.MW_WarehouseCode);
         }
         if (string.IsNullOrEmpty(wH_WMaterial.MW_WarehouseName))
         {
            idb.AddParameter("@MW_WarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_WarehouseName", wH_WMaterial.MW_WarehouseName);
         }
         if (string.IsNullOrEmpty(wH_WMaterial.MW_MCode))
         {
            idb.AddParameter("@MW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_MCode", wH_WMaterial.MW_MCode);
         }
         if (string.IsNullOrEmpty(wH_WMaterial.MW_IsLock))
         {
            idb.AddParameter("@MW_IsLock", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_IsLock", wH_WMaterial.MW_IsLock);
         }
         if (wH_WMaterial.MW_StockNum == 0)
         {
            idb.AddParameter("@MW_StockNum", 0);
         }
         else
         {
            idb.AddParameter("@MW_StockNum", wH_WMaterial.MW_StockNum);
         }
         if (wH_WMaterial.MW_IsPromise == 0)
         {
            idb.AddParameter("@MW_IsPromise", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsPromise", wH_WMaterial.MW_IsPromise);
         }
         if (wH_WMaterial.MW_IsOrder == 0)
         {
            idb.AddParameter("@MW_IsOrder", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsOrder", wH_WMaterial.MW_IsOrder);
         }
         if (wH_WMaterial.MW_IsAble == 0)
         {
            idb.AddParameter("@MW_IsAble", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsAble", wH_WMaterial.MW_IsAble);
         }
         if (wH_WMaterial.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_WMaterial.Stat);
         }
         if (wH_WMaterial.MW_High == 0)
         {
            idb.AddParameter("@MW_High", 0);
         }
         else
         {
            idb.AddParameter("@MW_High", wH_WMaterial.MW_High);
         }
         if (wH_WMaterial.MW_Low == 0)
         {
            idb.AddParameter("@MW_Low", 0);
         }
         else
         {
            idb.AddParameter("@MW_Low", wH_WMaterial.MW_Low);
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
      /// 添加物料库存信息 WH_WMaterial对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_WMaterial wH_WMaterial)
      {
         string sql = "INSERT INTO WH_WMaterial (MW_WarehouseCode,MW_WarehouseName,MW_MCode,MW_IsLock,MW_StockNum,MW_IsPromise,MW_IsOrder,MW_IsAble,Stat,MW_High,MW_Low) VALUES (@MW_WarehouseCode,@MW_WarehouseName,@MW_MCode,@MW_IsLock,@MW_StockNum,@MW_IsPromise,@MW_IsOrder,@MW_IsAble,@Stat,@MW_High,@MW_Low);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_WMaterial.MW_WarehouseCode))
         {
            idb.AddParameter("@MW_WarehouseCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_WarehouseCode", wH_WMaterial.MW_WarehouseCode);
         }
         if (string.IsNullOrEmpty(wH_WMaterial.MW_WarehouseName))
         {
            idb.AddParameter("@MW_WarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_WarehouseName", wH_WMaterial.MW_WarehouseName);
         }
         if (string.IsNullOrEmpty(wH_WMaterial.MW_MCode))
         {
            idb.AddParameter("@MW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_MCode", wH_WMaterial.MW_MCode);
         }
         if (string.IsNullOrEmpty(wH_WMaterial.MW_IsLock))
         {
            idb.AddParameter("@MW_IsLock", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_IsLock", wH_WMaterial.MW_IsLock);
         }
         if (wH_WMaterial.MW_StockNum == 0)
         {
            idb.AddParameter("@MW_StockNum", 0);
         }
         else
         {
            idb.AddParameter("@MW_StockNum", wH_WMaterial.MW_StockNum);
         }
         if (wH_WMaterial.MW_IsPromise == 0)
         {
            idb.AddParameter("@MW_IsPromise", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsPromise", wH_WMaterial.MW_IsPromise);
         }
         if (wH_WMaterial.MW_IsOrder == 0)
         {
            idb.AddParameter("@MW_IsOrder", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsOrder", wH_WMaterial.MW_IsOrder);
         }
         if (wH_WMaterial.MW_IsAble == 0)
         {
            idb.AddParameter("@MW_IsAble", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsAble", wH_WMaterial.MW_IsAble);
         }
         if (wH_WMaterial.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_WMaterial.Stat);
         }
         if (wH_WMaterial.MW_High == 0)
         {
            idb.AddParameter("@MW_High", 0);
         }
         else
         {
            idb.AddParameter("@MW_High", wH_WMaterial.MW_High);
         }
         if (wH_WMaterial.MW_Low == 0)
         {
            idb.AddParameter("@MW_Low", 0);
         }
         else
         {
            idb.AddParameter("@MW_Low", wH_WMaterial.MW_Low);
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
      /// 更新物料库存信息 WH_WMaterial对象(即:一条记录
      /// </summary>
      public int Update(WH_WMaterial wH_WMaterial)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_WMaterial       SET ");
            if(wH_WMaterial.MW_WarehouseCode_IsChanged){sbParameter.Append("MW_WarehouseCode=@MW_WarehouseCode, ");}
      if(wH_WMaterial.MW_WarehouseName_IsChanged){sbParameter.Append("MW_WarehouseName=@MW_WarehouseName, ");}
      if(wH_WMaterial.MW_MCode_IsChanged){sbParameter.Append("MW_MCode=@MW_MCode, ");}
      if(wH_WMaterial.MW_IsLock_IsChanged){sbParameter.Append("MW_IsLock=@MW_IsLock, ");}
      if(wH_WMaterial.MW_StockNum_IsChanged){sbParameter.Append("MW_StockNum=@MW_StockNum, ");}
      if(wH_WMaterial.MW_IsPromise_IsChanged){sbParameter.Append("MW_IsPromise=@MW_IsPromise, ");}
      if(wH_WMaterial.MW_IsOrder_IsChanged){sbParameter.Append("MW_IsOrder=@MW_IsOrder, ");}
      if(wH_WMaterial.MW_IsAble_IsChanged){sbParameter.Append("MW_IsAble=@MW_IsAble, ");}
      if(wH_WMaterial.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_WMaterial.MW_High_IsChanged){sbParameter.Append("MW_High=@MW_High, ");}
      if(wH_WMaterial.MW_Low_IsChanged){sbParameter.Append("MW_Low=@MW_Low ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MW_ID=@MW_ID; " );
      string sql=sb.ToString();
         if(wH_WMaterial.MW_WarehouseCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_WMaterial.MW_WarehouseCode))
         {
            idb.AddParameter("@MW_WarehouseCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_WarehouseCode", wH_WMaterial.MW_WarehouseCode);
         }
          }
         if(wH_WMaterial.MW_WarehouseName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_WMaterial.MW_WarehouseName))
         {
            idb.AddParameter("@MW_WarehouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_WarehouseName", wH_WMaterial.MW_WarehouseName);
         }
          }
         if(wH_WMaterial.MW_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_WMaterial.MW_MCode))
         {
            idb.AddParameter("@MW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_MCode", wH_WMaterial.MW_MCode);
         }
          }
         if(wH_WMaterial.MW_IsLock_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_WMaterial.MW_IsLock))
         {
            idb.AddParameter("@MW_IsLock", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MW_IsLock", wH_WMaterial.MW_IsLock);
         }
          }
         if(wH_WMaterial.MW_StockNum_IsChanged)
         {
         if (wH_WMaterial.MW_StockNum == 0)
         {
            idb.AddParameter("@MW_StockNum", 0);
         }
         else
         {
            idb.AddParameter("@MW_StockNum", wH_WMaterial.MW_StockNum);
         }
          }
         if(wH_WMaterial.MW_IsPromise_IsChanged)
         {
         if (wH_WMaterial.MW_IsPromise == 0)
         {
            idb.AddParameter("@MW_IsPromise", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsPromise", wH_WMaterial.MW_IsPromise);
         }
          }
         if(wH_WMaterial.MW_IsOrder_IsChanged)
         {
         if (wH_WMaterial.MW_IsOrder == 0)
         {
            idb.AddParameter("@MW_IsOrder", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsOrder", wH_WMaterial.MW_IsOrder);
         }
          }
         if(wH_WMaterial.MW_IsAble_IsChanged)
         {
         if (wH_WMaterial.MW_IsAble == 0)
         {
            idb.AddParameter("@MW_IsAble", 0);
         }
         else
         {
            idb.AddParameter("@MW_IsAble", wH_WMaterial.MW_IsAble);
         }
          }
         if(wH_WMaterial.Stat_IsChanged)
         {
         if (wH_WMaterial.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_WMaterial.Stat);
         }
          }
         if(wH_WMaterial.MW_High_IsChanged)
         {
         if (wH_WMaterial.MW_High == 0)
         {
            idb.AddParameter("@MW_High", 0);
         }
         else
         {
            idb.AddParameter("@MW_High", wH_WMaterial.MW_High);
         }
          }
         if(wH_WMaterial.MW_Low_IsChanged)
         {
         if (wH_WMaterial.MW_Low == 0)
         {
            idb.AddParameter("@MW_Low", 0);
         }
         else
         {
            idb.AddParameter("@MW_Low", wH_WMaterial.MW_Low);
         }
          }

         idb.AddParameter("@MW_ID", wH_WMaterial.MW_ID);

           
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
      /// 删除物料库存信息 WH_WMaterial对象(即:一条记录
      /// </summary>
      public int Delete(decimal mW_ID)
      {
         string sql = "DELETE WH_WMaterial WHERE 1=1  AND MW_ID=@MW_ID ";
         idb.AddParameter("@MW_ID", mW_ID);

           
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
      /// 获取指定的物料库存信息 WH_WMaterial对象(即:一条记录
      /// </summary>
      public WH_WMaterial GetByKey(decimal mW_ID)
      {
         WH_WMaterial wH_WMaterial = new WH_WMaterial();
         string sql = "SELECT  MW_ID,MW_WarehouseCode,MW_WarehouseName,MW_MCode,MW_IsLock,MW_StockNum,MW_IsPromise,MW_IsOrder,MW_IsAble,Stat,MW_High,MW_Low FROM WH_WMaterial WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MW_ID=@MW_ID ";
         idb.AddParameter("@MW_ID", mW_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MW_ID"] != DBNull.Value) wH_WMaterial.MW_ID = Convert.ToDecimal(dr["MW_ID"]);
            if (dr["MW_WarehouseCode"] != DBNull.Value) wH_WMaterial.MW_WarehouseCode = Convert.ToString(dr["MW_WarehouseCode"]);
            if (dr["MW_WarehouseName"] != DBNull.Value) wH_WMaterial.MW_WarehouseName = Convert.ToString(dr["MW_WarehouseName"]);
            if (dr["MW_MCode"] != DBNull.Value) wH_WMaterial.MW_MCode = Convert.ToString(dr["MW_MCode"]);
            if (dr["MW_IsLock"] != DBNull.Value) wH_WMaterial.MW_IsLock = Convert.ToString(dr["MW_IsLock"]);
            if (dr["MW_StockNum"] != DBNull.Value) wH_WMaterial.MW_StockNum = Convert.ToInt32(dr["MW_StockNum"]);
            if (dr["MW_IsPromise"] != DBNull.Value) wH_WMaterial.MW_IsPromise = Convert.ToInt32(dr["MW_IsPromise"]);
            if (dr["MW_IsOrder"] != DBNull.Value) wH_WMaterial.MW_IsOrder = Convert.ToInt32(dr["MW_IsOrder"]);
            if (dr["MW_IsAble"] != DBNull.Value) wH_WMaterial.MW_IsAble = Convert.ToInt32(dr["MW_IsAble"]);
            if (dr["Stat"] != DBNull.Value) wH_WMaterial.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MW_High"] != DBNull.Value) wH_WMaterial.MW_High = Convert.ToInt32(dr["MW_High"]);
            if (dr["MW_Low"] != DBNull.Value) wH_WMaterial.MW_Low = Convert.ToInt32(dr["MW_Low"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_WMaterial;
      }
      /// <summary>
      /// 获取指定的物料库存信息 WH_WMaterial对象集合
      /// </summary>
      public List<WH_WMaterial> GetListByWhere(string strCondition)
      {
         List<WH_WMaterial> ret = new List<WH_WMaterial>();
         string sql = "SELECT  MW_ID,MW_WarehouseCode,MW_WarehouseName,MW_MCode,MW_IsLock,MW_StockNum,MW_IsPromise,MW_IsOrder,MW_IsAble,Stat,MW_High,MW_Low FROM WH_WMaterial WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_WMaterial wH_WMaterial = new WH_WMaterial();
            if (dr["MW_ID"] != DBNull.Value) wH_WMaterial.MW_ID = Convert.ToDecimal(dr["MW_ID"]);
            if (dr["MW_WarehouseCode"] != DBNull.Value) wH_WMaterial.MW_WarehouseCode = Convert.ToString(dr["MW_WarehouseCode"]);
            if (dr["MW_WarehouseName"] != DBNull.Value) wH_WMaterial.MW_WarehouseName = Convert.ToString(dr["MW_WarehouseName"]);
            if (dr["MW_MCode"] != DBNull.Value) wH_WMaterial.MW_MCode = Convert.ToString(dr["MW_MCode"]);
            if (dr["MW_IsLock"] != DBNull.Value) wH_WMaterial.MW_IsLock = Convert.ToString(dr["MW_IsLock"]);
            if (dr["MW_StockNum"] != DBNull.Value) wH_WMaterial.MW_StockNum = Convert.ToInt32(dr["MW_StockNum"]);
            if (dr["MW_IsPromise"] != DBNull.Value) wH_WMaterial.MW_IsPromise = Convert.ToInt32(dr["MW_IsPromise"]);
            if (dr["MW_IsOrder"] != DBNull.Value) wH_WMaterial.MW_IsOrder = Convert.ToInt32(dr["MW_IsOrder"]);
            if (dr["MW_IsAble"] != DBNull.Value) wH_WMaterial.MW_IsAble = Convert.ToInt32(dr["MW_IsAble"]);
            if (dr["Stat"] != DBNull.Value) wH_WMaterial.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MW_High"] != DBNull.Value) wH_WMaterial.MW_High = Convert.ToInt32(dr["MW_High"]);
            if (dr["MW_Low"] != DBNull.Value) wH_WMaterial.MW_Low = Convert.ToInt32(dr["MW_Low"]);
            ret.Add(wH_WMaterial);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的物料库存信息 WH_WMaterial对象(即:一条记录
      /// </summary>
      public List<WH_WMaterial> GetAll()
      {
         List<WH_WMaterial> ret = new List<WH_WMaterial>();
         string sql = "SELECT  MW_ID,MW_WarehouseCode,MW_WarehouseName,MW_MCode,MW_IsLock,MW_StockNum,MW_IsPromise,MW_IsOrder,MW_IsAble,Stat,MW_High,MW_Low FROM WH_WMaterial where 1=1 AND ((Stat is null) or (Stat=0) ) order by MW_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_WMaterial wH_WMaterial = new WH_WMaterial();
            if (dr["MW_ID"] != DBNull.Value) wH_WMaterial.MW_ID = Convert.ToDecimal(dr["MW_ID"]);
            if (dr["MW_WarehouseCode"] != DBNull.Value) wH_WMaterial.MW_WarehouseCode = Convert.ToString(dr["MW_WarehouseCode"]);
            if (dr["MW_WarehouseName"] != DBNull.Value) wH_WMaterial.MW_WarehouseName = Convert.ToString(dr["MW_WarehouseName"]);
            if (dr["MW_MCode"] != DBNull.Value) wH_WMaterial.MW_MCode = Convert.ToString(dr["MW_MCode"]);
            if (dr["MW_IsLock"] != DBNull.Value) wH_WMaterial.MW_IsLock = Convert.ToString(dr["MW_IsLock"]);
            if (dr["MW_StockNum"] != DBNull.Value) wH_WMaterial.MW_StockNum = Convert.ToInt32(dr["MW_StockNum"]);
            if (dr["MW_IsPromise"] != DBNull.Value) wH_WMaterial.MW_IsPromise = Convert.ToInt32(dr["MW_IsPromise"]);
            if (dr["MW_IsOrder"] != DBNull.Value) wH_WMaterial.MW_IsOrder = Convert.ToInt32(dr["MW_IsOrder"]);
            if (dr["MW_IsAble"] != DBNull.Value) wH_WMaterial.MW_IsAble = Convert.ToInt32(dr["MW_IsAble"]);
            if (dr["Stat"] != DBNull.Value) wH_WMaterial.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MW_High"] != DBNull.Value) wH_WMaterial.MW_High = Convert.ToInt32(dr["MW_High"]);
            if (dr["MW_Low"] != DBNull.Value) wH_WMaterial.MW_Low = Convert.ToInt32(dr["MW_Low"]);
            ret.Add(wH_WMaterial);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
