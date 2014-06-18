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
   /// 试块信息
   /// </summary>
   [Serializable]
   public partial class ADOTC_Item
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加试块信息 TC_Item对象(即:一条记录)
      /// </summary>
      public int Add(TC_Item tC_Item)
      {
         string sql = "INSERT INTO TC_Item (TCI_Code,TCI_GroupCode,TCI_No,TCI_VCode,TCI_VName,TCI_Val,TCI_MVal,TCI_Base,TCI_RefValue,TCI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCI_Code,@TCI_GroupCode,@TCI_No,@TCI_VCode,@TCI_VName,@TCI_Val,@TCI_MVal,@TCI_Base,@TCI_RefValue,@TCI_Conclusion,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_Item.TCI_Code))
         {
            idb.AddParameter("@TCI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Code", tC_Item.TCI_Code);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_GroupCode))
         {
            idb.AddParameter("@TCI_GroupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_GroupCode", tC_Item.TCI_GroupCode);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_No))
         {
            idb.AddParameter("@TCI_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_No", tC_Item.TCI_No);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_VCode))
         {
            idb.AddParameter("@TCI_VCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_VCode", tC_Item.TCI_VCode);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_VName))
         {
            idb.AddParameter("@TCI_VName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_VName", tC_Item.TCI_VName);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_Val))
         {
            idb.AddParameter("@TCI_Val", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Val", tC_Item.TCI_Val);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_MVal))
         {
            idb.AddParameter("@TCI_MVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_MVal", tC_Item.TCI_MVal);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_Base))
         {
            idb.AddParameter("@TCI_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Base", tC_Item.TCI_Base);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_RefValue))
         {
            idb.AddParameter("@TCI_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_RefValue", tC_Item.TCI_RefValue);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_Conclusion))
         {
            idb.AddParameter("@TCI_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Conclusion", tC_Item.TCI_Conclusion);
         }
         if (tC_Item.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Item.Stat);
         }
         if (tC_Item.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Item.CreateDate);
         }
         if (tC_Item.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Item.UpdateDate);
         }
         if (tC_Item.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Item.DeleteDate);
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
      /// 添加试块信息 TC_Item对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_Item tC_Item)
      {
         string sql = "INSERT INTO TC_Item (TCI_Code,TCI_GroupCode,TCI_No,TCI_VCode,TCI_VName,TCI_Val,TCI_MVal,TCI_Base,TCI_RefValue,TCI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCI_Code,@TCI_GroupCode,@TCI_No,@TCI_VCode,@TCI_VName,@TCI_Val,@TCI_MVal,@TCI_Base,@TCI_RefValue,@TCI_Conclusion,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_Item.TCI_Code))
         {
            idb.AddParameter("@TCI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Code", tC_Item.TCI_Code);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_GroupCode))
         {
            idb.AddParameter("@TCI_GroupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_GroupCode", tC_Item.TCI_GroupCode);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_No))
         {
            idb.AddParameter("@TCI_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_No", tC_Item.TCI_No);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_VCode))
         {
            idb.AddParameter("@TCI_VCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_VCode", tC_Item.TCI_VCode);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_VName))
         {
            idb.AddParameter("@TCI_VName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_VName", tC_Item.TCI_VName);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_Val))
         {
            idb.AddParameter("@TCI_Val", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Val", tC_Item.TCI_Val);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_MVal))
         {
            idb.AddParameter("@TCI_MVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_MVal", tC_Item.TCI_MVal);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_Base))
         {
            idb.AddParameter("@TCI_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Base", tC_Item.TCI_Base);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_RefValue))
         {
            idb.AddParameter("@TCI_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_RefValue", tC_Item.TCI_RefValue);
         }
         if (string.IsNullOrEmpty(tC_Item.TCI_Conclusion))
         {
            idb.AddParameter("@TCI_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Conclusion", tC_Item.TCI_Conclusion);
         }
         if (tC_Item.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Item.Stat);
         }
         if (tC_Item.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Item.CreateDate);
         }
         if (tC_Item.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Item.UpdateDate);
         }
         if (tC_Item.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Item.DeleteDate);
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
      /// 更新试块信息 TC_Item对象(即:一条记录
      /// </summary>
      public int Update(TC_Item tC_Item)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_Item       SET ");
            if(tC_Item.TCI_Code_IsChanged){sbParameter.Append("TCI_Code=@TCI_Code, ");}
      if(tC_Item.TCI_GroupCode_IsChanged){sbParameter.Append("TCI_GroupCode=@TCI_GroupCode, ");}
      if(tC_Item.TCI_No_IsChanged){sbParameter.Append("TCI_No=@TCI_No, ");}
      if(tC_Item.TCI_VCode_IsChanged){sbParameter.Append("TCI_VCode=@TCI_VCode, ");}
      if(tC_Item.TCI_VName_IsChanged){sbParameter.Append("TCI_VName=@TCI_VName, ");}
      if(tC_Item.TCI_Val_IsChanged){sbParameter.Append("TCI_Val=@TCI_Val, ");}
      if(tC_Item.TCI_MVal_IsChanged){sbParameter.Append("TCI_MVal=@TCI_MVal, ");}
      if(tC_Item.TCI_Base_IsChanged){sbParameter.Append("TCI_Base=@TCI_Base, ");}
      if(tC_Item.TCI_RefValue_IsChanged){sbParameter.Append("TCI_RefValue=@TCI_RefValue, ");}
      if(tC_Item.TCI_Conclusion_IsChanged){sbParameter.Append("TCI_Conclusion=@TCI_Conclusion, ");}
      if(tC_Item.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_Item.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_Item.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_Item.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCI_ID=@TCI_ID; " );
      string sql=sb.ToString();
         if(tC_Item.TCI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_Code))
         {
            idb.AddParameter("@TCI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Code", tC_Item.TCI_Code);
         }
          }
         if(tC_Item.TCI_GroupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_GroupCode))
         {
            idb.AddParameter("@TCI_GroupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_GroupCode", tC_Item.TCI_GroupCode);
         }
          }
         if(tC_Item.TCI_No_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_No))
         {
            idb.AddParameter("@TCI_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_No", tC_Item.TCI_No);
         }
          }
         if(tC_Item.TCI_VCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_VCode))
         {
            idb.AddParameter("@TCI_VCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_VCode", tC_Item.TCI_VCode);
         }
          }
         if(tC_Item.TCI_VName_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_VName))
         {
            idb.AddParameter("@TCI_VName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_VName", tC_Item.TCI_VName);
         }
          }
         if(tC_Item.TCI_Val_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_Val))
         {
            idb.AddParameter("@TCI_Val", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Val", tC_Item.TCI_Val);
         }
          }
         if(tC_Item.TCI_MVal_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_MVal))
         {
            idb.AddParameter("@TCI_MVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_MVal", tC_Item.TCI_MVal);
         }
          }
         if(tC_Item.TCI_Base_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_Base))
         {
            idb.AddParameter("@TCI_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Base", tC_Item.TCI_Base);
         }
          }
         if(tC_Item.TCI_RefValue_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_RefValue))
         {
            idb.AddParameter("@TCI_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_RefValue", tC_Item.TCI_RefValue);
         }
          }
         if(tC_Item.TCI_Conclusion_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Item.TCI_Conclusion))
         {
            idb.AddParameter("@TCI_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCI_Conclusion", tC_Item.TCI_Conclusion);
         }
          }
         if(tC_Item.Stat_IsChanged)
         {
         if (tC_Item.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Item.Stat);
         }
          }
         if(tC_Item.CreateDate_IsChanged)
         {
         if (tC_Item.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Item.CreateDate);
         }
          }
         if(tC_Item.UpdateDate_IsChanged)
         {
         if (tC_Item.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Item.UpdateDate);
         }
          }
         if(tC_Item.DeleteDate_IsChanged)
         {
         if (tC_Item.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Item.DeleteDate);
         }
          }

         idb.AddParameter("@TCI_ID", tC_Item.TCI_ID);

           
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
      /// 删除试块信息 TC_Item对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCI_ID)
      {
         string sql = "DELETE TC_Item WHERE 1=1  AND TCI_ID=@TCI_ID ";
         idb.AddParameter("@TCI_ID", tCI_ID);

           
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
      /// 获取指定的试块信息 TC_Item对象(即:一条记录
      /// </summary>
      public TC_Item GetByKey(decimal tCI_ID)
      {
         TC_Item tC_Item = new TC_Item();
         string sql = "SELECT  TCI_ID,TCI_Code,TCI_GroupCode,TCI_No,TCI_VCode,TCI_VName,TCI_Val,TCI_MVal,TCI_Base,TCI_RefValue,TCI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Item WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCI_ID=@TCI_ID ";
         idb.AddParameter("@TCI_ID", tCI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCI_ID"] != DBNull.Value) tC_Item.TCI_ID = Convert.ToDecimal(dr["TCI_ID"]);
            if (dr["TCI_Code"] != DBNull.Value) tC_Item.TCI_Code = Convert.ToString(dr["TCI_Code"]);
            if (dr["TCI_GroupCode"] != DBNull.Value) tC_Item.TCI_GroupCode = Convert.ToString(dr["TCI_GroupCode"]);
            if (dr["TCI_No"] != DBNull.Value) tC_Item.TCI_No = Convert.ToString(dr["TCI_No"]);
            if (dr["TCI_VCode"] != DBNull.Value) tC_Item.TCI_VCode = Convert.ToString(dr["TCI_VCode"]);
            if (dr["TCI_VName"] != DBNull.Value) tC_Item.TCI_VName = Convert.ToString(dr["TCI_VName"]);
            if (dr["TCI_Val"] != DBNull.Value) tC_Item.TCI_Val = Convert.ToString(dr["TCI_Val"]);
            if (dr["TCI_MVal"] != DBNull.Value) tC_Item.TCI_MVal = Convert.ToString(dr["TCI_MVal"]);
            if (dr["TCI_Base"] != DBNull.Value) tC_Item.TCI_Base = Convert.ToString(dr["TCI_Base"]);
            if (dr["TCI_RefValue"] != DBNull.Value) tC_Item.TCI_RefValue = Convert.ToString(dr["TCI_RefValue"]);
            if (dr["TCI_Conclusion"] != DBNull.Value) tC_Item.TCI_Conclusion = Convert.ToString(dr["TCI_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_Item.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Item.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_Item;
      }
      /// <summary>
      /// 获取指定的试块信息 TC_Item对象集合
      /// </summary>
      public List<TC_Item> GetListByWhere(string strCondition)
      {
         List<TC_Item> ret = new List<TC_Item>();
         string sql = "SELECT  TCI_ID,TCI_Code,TCI_GroupCode,TCI_No,TCI_VCode,TCI_VName,TCI_Val,TCI_MVal,TCI_Base,TCI_RefValue,TCI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Item WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_Item tC_Item = new TC_Item();
            if (dr["TCI_ID"] != DBNull.Value) tC_Item.TCI_ID = Convert.ToDecimal(dr["TCI_ID"]);
            if (dr["TCI_Code"] != DBNull.Value) tC_Item.TCI_Code = Convert.ToString(dr["TCI_Code"]);
            if (dr["TCI_GroupCode"] != DBNull.Value) tC_Item.TCI_GroupCode = Convert.ToString(dr["TCI_GroupCode"]);
            if (dr["TCI_No"] != DBNull.Value) tC_Item.TCI_No = Convert.ToString(dr["TCI_No"]);
            if (dr["TCI_VCode"] != DBNull.Value) tC_Item.TCI_VCode = Convert.ToString(dr["TCI_VCode"]);
            if (dr["TCI_VName"] != DBNull.Value) tC_Item.TCI_VName = Convert.ToString(dr["TCI_VName"]);
            if (dr["TCI_Val"] != DBNull.Value) tC_Item.TCI_Val = Convert.ToString(dr["TCI_Val"]);
            if (dr["TCI_MVal"] != DBNull.Value) tC_Item.TCI_MVal = Convert.ToString(dr["TCI_MVal"]);
            if (dr["TCI_Base"] != DBNull.Value) tC_Item.TCI_Base = Convert.ToString(dr["TCI_Base"]);
            if (dr["TCI_RefValue"] != DBNull.Value) tC_Item.TCI_RefValue = Convert.ToString(dr["TCI_RefValue"]);
            if (dr["TCI_Conclusion"] != DBNull.Value) tC_Item.TCI_Conclusion = Convert.ToString(dr["TCI_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_Item.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Item.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_Item);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的试块信息 TC_Item对象(即:一条记录
      /// </summary>
      public List<TC_Item> GetAll()
      {
         List<TC_Item> ret = new List<TC_Item>();
         string sql = "SELECT  TCI_ID,TCI_Code,TCI_GroupCode,TCI_No,TCI_VCode,TCI_VName,TCI_Val,TCI_MVal,TCI_Base,TCI_RefValue,TCI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Item where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_Item tC_Item = new TC_Item();
            if (dr["TCI_ID"] != DBNull.Value) tC_Item.TCI_ID = Convert.ToDecimal(dr["TCI_ID"]);
            if (dr["TCI_Code"] != DBNull.Value) tC_Item.TCI_Code = Convert.ToString(dr["TCI_Code"]);
            if (dr["TCI_GroupCode"] != DBNull.Value) tC_Item.TCI_GroupCode = Convert.ToString(dr["TCI_GroupCode"]);
            if (dr["TCI_No"] != DBNull.Value) tC_Item.TCI_No = Convert.ToString(dr["TCI_No"]);
            if (dr["TCI_VCode"] != DBNull.Value) tC_Item.TCI_VCode = Convert.ToString(dr["TCI_VCode"]);
            if (dr["TCI_VName"] != DBNull.Value) tC_Item.TCI_VName = Convert.ToString(dr["TCI_VName"]);
            if (dr["TCI_Val"] != DBNull.Value) tC_Item.TCI_Val = Convert.ToString(dr["TCI_Val"]);
            if (dr["TCI_MVal"] != DBNull.Value) tC_Item.TCI_MVal = Convert.ToString(dr["TCI_MVal"]);
            if (dr["TCI_Base"] != DBNull.Value) tC_Item.TCI_Base = Convert.ToString(dr["TCI_Base"]);
            if (dr["TCI_RefValue"] != DBNull.Value) tC_Item.TCI_RefValue = Convert.ToString(dr["TCI_RefValue"]);
            if (dr["TCI_Conclusion"] != DBNull.Value) tC_Item.TCI_Conclusion = Convert.ToString(dr["TCI_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_Item.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Item.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_Item);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
