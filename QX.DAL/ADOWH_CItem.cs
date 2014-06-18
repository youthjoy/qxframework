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
   /// 合同细目信息
   /// </summary>
   [Serializable]
   public partial class ADOWH_CItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加合同细目信息 WH_CItem对象(即:一条记录)
      /// </summary>
      public int Add(WH_CItem wH_CItem)
      {
         string sql = "INSERT INTO WH_CItem (WHCI_CCode,WHCI_MCode,WHCI_Num,WHCI_Unit,WHCI_Manu,WHCI_MDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WHCI_CCode,@WHCI_MCode,@WHCI_Num,@WHCI_Unit,@WHCI_Manu,@WHCI_MDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(wH_CItem.WHCI_CCode))
         {
            idb.AddParameter("@WHCI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_CCode", wH_CItem.WHCI_CCode);
         }
         if (string.IsNullOrEmpty(wH_CItem.WHCI_MCode))
         {
            idb.AddParameter("@WHCI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_MCode", wH_CItem.WHCI_MCode);
         }
         if (wH_CItem.WHCI_Num == 0)
         {
            idb.AddParameter("@WHCI_Num", 0);
         }
         else
         {
            idb.AddParameter("@WHCI_Num", wH_CItem.WHCI_Num);
         }
         if (string.IsNullOrEmpty(wH_CItem.WHCI_Unit))
         {
            idb.AddParameter("@WHCI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_Unit", wH_CItem.WHCI_Unit);
         }
         if (string.IsNullOrEmpty(wH_CItem.WHCI_Manu))
         {
            idb.AddParameter("@WHCI_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_Manu", wH_CItem.WHCI_Manu);
         }
         if (wH_CItem.WHCI_MDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHCI_MDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_MDate", wH_CItem.WHCI_MDate);
         }
         if (wH_CItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CItem.Stat);
         }
         if (wH_CItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_CItem.CreateDate);
         }
         if (wH_CItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_CItem.UpdateDate);
         }
         if (wH_CItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_CItem.DeleteDate);
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
      /// 添加合同细目信息 WH_CItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_CItem wH_CItem)
      {
         string sql = "INSERT INTO WH_CItem (WHCI_CCode,WHCI_MCode,WHCI_Num,WHCI_Unit,WHCI_Manu,WHCI_MDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WHCI_CCode,@WHCI_MCode,@WHCI_Num,@WHCI_Unit,@WHCI_Manu,@WHCI_MDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_CItem.WHCI_CCode))
         {
            idb.AddParameter("@WHCI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_CCode", wH_CItem.WHCI_CCode);
         }
         if (string.IsNullOrEmpty(wH_CItem.WHCI_MCode))
         {
            idb.AddParameter("@WHCI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_MCode", wH_CItem.WHCI_MCode);
         }
         if (wH_CItem.WHCI_Num == 0)
         {
            idb.AddParameter("@WHCI_Num", 0);
         }
         else
         {
            idb.AddParameter("@WHCI_Num", wH_CItem.WHCI_Num);
         }
         if (string.IsNullOrEmpty(wH_CItem.WHCI_Unit))
         {
            idb.AddParameter("@WHCI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_Unit", wH_CItem.WHCI_Unit);
         }
         if (string.IsNullOrEmpty(wH_CItem.WHCI_Manu))
         {
            idb.AddParameter("@WHCI_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_Manu", wH_CItem.WHCI_Manu);
         }
         if (wH_CItem.WHCI_MDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHCI_MDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_MDate", wH_CItem.WHCI_MDate);
         }
         if (wH_CItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CItem.Stat);
         }
         if (wH_CItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_CItem.CreateDate);
         }
         if (wH_CItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_CItem.UpdateDate);
         }
         if (wH_CItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_CItem.DeleteDate);
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
      /// 更新合同细目信息 WH_CItem对象(即:一条记录
      /// </summary>
      public int Update(WH_CItem wH_CItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_CItem       SET ");
            if(wH_CItem.WHCI_CCode_IsChanged){sbParameter.Append("WHCI_CCode=@WHCI_CCode, ");}
      if(wH_CItem.WHCI_MCode_IsChanged){sbParameter.Append("WHCI_MCode=@WHCI_MCode, ");}
      if(wH_CItem.WHCI_Num_IsChanged){sbParameter.Append("WHCI_Num=@WHCI_Num, ");}
      if(wH_CItem.WHCI_Unit_IsChanged){sbParameter.Append("WHCI_Unit=@WHCI_Unit, ");}
      if(wH_CItem.WHCI_Manu_IsChanged){sbParameter.Append("WHCI_Manu=@WHCI_Manu, ");}
      if(wH_CItem.WHCI_MDate_IsChanged){sbParameter.Append("WHCI_MDate=@WHCI_MDate, ");}
      if(wH_CItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_CItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_CItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_CItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHCI_ID=@WHCI_ID; " );
      string sql=sb.ToString();
         if(wH_CItem.WHCI_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CItem.WHCI_CCode))
         {
            idb.AddParameter("@WHCI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_CCode", wH_CItem.WHCI_CCode);
         }
          }
         if(wH_CItem.WHCI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CItem.WHCI_MCode))
         {
            idb.AddParameter("@WHCI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_MCode", wH_CItem.WHCI_MCode);
         }
          }
         if(wH_CItem.WHCI_Num_IsChanged)
         {
         if (wH_CItem.WHCI_Num == 0)
         {
            idb.AddParameter("@WHCI_Num", 0);
         }
         else
         {
            idb.AddParameter("@WHCI_Num", wH_CItem.WHCI_Num);
         }
          }
         if(wH_CItem.WHCI_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CItem.WHCI_Unit))
         {
            idb.AddParameter("@WHCI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_Unit", wH_CItem.WHCI_Unit);
         }
          }
         if(wH_CItem.WHCI_Manu_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CItem.WHCI_Manu))
         {
            idb.AddParameter("@WHCI_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_Manu", wH_CItem.WHCI_Manu);
         }
          }
         if(wH_CItem.WHCI_MDate_IsChanged)
         {
         if (wH_CItem.WHCI_MDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHCI_MDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHCI_MDate", wH_CItem.WHCI_MDate);
         }
          }
         if(wH_CItem.Stat_IsChanged)
         {
         if (wH_CItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CItem.Stat);
         }
          }
         if(wH_CItem.CreateDate_IsChanged)
         {
         if (wH_CItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_CItem.CreateDate);
         }
          }
         if(wH_CItem.UpdateDate_IsChanged)
         {
         if (wH_CItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_CItem.UpdateDate);
         }
          }
         if(wH_CItem.DeleteDate_IsChanged)
         {
         if (wH_CItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_CItem.DeleteDate);
         }
          }

         idb.AddParameter("@WHCI_ID", wH_CItem.WHCI_ID);

           
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
      /// 删除合同细目信息 WH_CItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHCI_ID)
      {
         string sql = "DELETE WH_CItem WHERE 1=1  AND WHCI_ID=@WHCI_ID ";
         idb.AddParameter("@WHCI_ID", wHCI_ID);

           
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
      /// 获取指定的合同细目信息 WH_CItem对象(即:一条记录
      /// </summary>
      public WH_CItem GetByKey(decimal wHCI_ID)
      {
         WH_CItem wH_CItem = new WH_CItem();
         string sql = "SELECT  WHCI_ID,WHCI_CCode,WHCI_MCode,WHCI_Num,WHCI_Unit,WHCI_Manu,WHCI_MDate,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_CItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHCI_ID=@WHCI_ID ";
         idb.AddParameter("@WHCI_ID", wHCI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHCI_ID"] != DBNull.Value) wH_CItem.WHCI_ID = Convert.ToDecimal(dr["WHCI_ID"]);
            if (dr["WHCI_CCode"] != DBNull.Value) wH_CItem.WHCI_CCode = Convert.ToString(dr["WHCI_CCode"]);
            if (dr["WHCI_MCode"] != DBNull.Value) wH_CItem.WHCI_MCode = Convert.ToString(dr["WHCI_MCode"]);
            if (dr["WHCI_Num"] != DBNull.Value) wH_CItem.WHCI_Num = Convert.ToInt32(dr["WHCI_Num"]);
            if (dr["WHCI_Unit"] != DBNull.Value) wH_CItem.WHCI_Unit = Convert.ToString(dr["WHCI_Unit"]);
            if (dr["WHCI_Manu"] != DBNull.Value) wH_CItem.WHCI_Manu = Convert.ToString(dr["WHCI_Manu"]);
            if (dr["WHCI_MDate"] != DBNull.Value) wH_CItem.WHCI_MDate = Convert.ToDateTime(dr["WHCI_MDate"]);
            if (dr["Stat"] != DBNull.Value) wH_CItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_CItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_CItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_CItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_CItem;
      }
      /// <summary>
      /// 获取指定的合同细目信息 WH_CItem对象集合
      /// </summary>
      public List<WH_CItem> GetListByWhere(string strCondition)
      {
         List<WH_CItem> ret = new List<WH_CItem>();
         string sql = "SELECT  WHCI_ID,WHCI_CCode,WHCI_MCode,WHCI_Num,WHCI_Unit,WHCI_Manu,WHCI_MDate,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_CItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_CItem wH_CItem = new WH_CItem();
            if (dr["WHCI_ID"] != DBNull.Value) wH_CItem.WHCI_ID = Convert.ToDecimal(dr["WHCI_ID"]);
            if (dr["WHCI_CCode"] != DBNull.Value) wH_CItem.WHCI_CCode = Convert.ToString(dr["WHCI_CCode"]);
            if (dr["WHCI_MCode"] != DBNull.Value) wH_CItem.WHCI_MCode = Convert.ToString(dr["WHCI_MCode"]);
            if (dr["WHCI_Num"] != DBNull.Value) wH_CItem.WHCI_Num = Convert.ToInt32(dr["WHCI_Num"]);
            if (dr["WHCI_Unit"] != DBNull.Value) wH_CItem.WHCI_Unit = Convert.ToString(dr["WHCI_Unit"]);
            if (dr["WHCI_Manu"] != DBNull.Value) wH_CItem.WHCI_Manu = Convert.ToString(dr["WHCI_Manu"]);
            if (dr["WHCI_MDate"] != DBNull.Value) wH_CItem.WHCI_MDate = Convert.ToDateTime(dr["WHCI_MDate"]);
            if (dr["Stat"] != DBNull.Value) wH_CItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_CItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_CItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_CItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_CItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的合同细目信息 WH_CItem对象(即:一条记录
      /// </summary>
      public List<WH_CItem> GetAll()
      {
         List<WH_CItem> ret = new List<WH_CItem>();
         string sql = "SELECT  WHCI_ID,WHCI_CCode,WHCI_MCode,WHCI_Num,WHCI_Unit,WHCI_Manu,WHCI_MDate,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_CItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHCI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_CItem wH_CItem = new WH_CItem();
            if (dr["WHCI_ID"] != DBNull.Value) wH_CItem.WHCI_ID = Convert.ToDecimal(dr["WHCI_ID"]);
            if (dr["WHCI_CCode"] != DBNull.Value) wH_CItem.WHCI_CCode = Convert.ToString(dr["WHCI_CCode"]);
            if (dr["WHCI_MCode"] != DBNull.Value) wH_CItem.WHCI_MCode = Convert.ToString(dr["WHCI_MCode"]);
            if (dr["WHCI_Num"] != DBNull.Value) wH_CItem.WHCI_Num = Convert.ToInt32(dr["WHCI_Num"]);
            if (dr["WHCI_Unit"] != DBNull.Value) wH_CItem.WHCI_Unit = Convert.ToString(dr["WHCI_Unit"]);
            if (dr["WHCI_Manu"] != DBNull.Value) wH_CItem.WHCI_Manu = Convert.ToString(dr["WHCI_Manu"]);
            if (dr["WHCI_MDate"] != DBNull.Value) wH_CItem.WHCI_MDate = Convert.ToDateTime(dr["WHCI_MDate"]);
            if (dr["Stat"] != DBNull.Value) wH_CItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_CItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_CItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_CItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_CItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
