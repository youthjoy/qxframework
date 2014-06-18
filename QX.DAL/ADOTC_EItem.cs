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
   public partial class ADOTC_EItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加TC_EItem对象(即:一条记录)
      /// </summary>
      public int Add(TC_EItem tC_EItem)
      {
         string sql = "INSERT INTO TC_EItem (TCEI_Code,TCEI_MainCode,TCEI_ICode,TCEI_IName,TCEI_IValue,TCEI_MVal,TCEI_RefVal,TCEI_Base,TCEI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCEI_Code,@TCEI_MainCode,@TCEI_ICode,@TCEI_IName,@TCEI_IValue,@TCEI_MVal,@TCEI_RefVal,@TCEI_Base,@TCEI_Conclusion,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Code))
         {
            idb.AddParameter("@TCEI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Code", tC_EItem.TCEI_Code);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_MainCode))
         {
            idb.AddParameter("@TCEI_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_MainCode", tC_EItem.TCEI_MainCode);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_ICode))
         {
            idb.AddParameter("@TCEI_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_ICode", tC_EItem.TCEI_ICode);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_IName))
         {
            idb.AddParameter("@TCEI_IName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_IName", tC_EItem.TCEI_IName);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_IValue))
         {
            idb.AddParameter("@TCEI_IValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_IValue", tC_EItem.TCEI_IValue);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_MVal))
         {
            idb.AddParameter("@TCEI_MVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_MVal", tC_EItem.TCEI_MVal);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_RefVal))
         {
            idb.AddParameter("@TCEI_RefVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_RefVal", tC_EItem.TCEI_RefVal);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Base))
         {
            idb.AddParameter("@TCEI_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Base", tC_EItem.TCEI_Base);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Conclusion))
         {
            idb.AddParameter("@TCEI_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Conclusion", tC_EItem.TCEI_Conclusion);
         }
         if (tC_EItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_EItem.Stat);
         }
         if (tC_EItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_EItem.CreateDate);
         }
         if (tC_EItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_EItem.UpdateDate);
         }
         if (tC_EItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_EItem.DeleteDate);
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
      /// 添加TC_EItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_EItem tC_EItem)
      {
         string sql = "INSERT INTO TC_EItem (TCEI_Code,TCEI_MainCode,TCEI_ICode,TCEI_IName,TCEI_IValue,TCEI_MVal,TCEI_RefVal,TCEI_Base,TCEI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCEI_Code,@TCEI_MainCode,@TCEI_ICode,@TCEI_IName,@TCEI_IValue,@TCEI_MVal,@TCEI_RefVal,@TCEI_Base,@TCEI_Conclusion,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Code))
         {
            idb.AddParameter("@TCEI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Code", tC_EItem.TCEI_Code);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_MainCode))
         {
            idb.AddParameter("@TCEI_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_MainCode", tC_EItem.TCEI_MainCode);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_ICode))
         {
            idb.AddParameter("@TCEI_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_ICode", tC_EItem.TCEI_ICode);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_IName))
         {
            idb.AddParameter("@TCEI_IName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_IName", tC_EItem.TCEI_IName);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_IValue))
         {
            idb.AddParameter("@TCEI_IValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_IValue", tC_EItem.TCEI_IValue);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_MVal))
         {
            idb.AddParameter("@TCEI_MVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_MVal", tC_EItem.TCEI_MVal);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_RefVal))
         {
            idb.AddParameter("@TCEI_RefVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_RefVal", tC_EItem.TCEI_RefVal);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Base))
         {
            idb.AddParameter("@TCEI_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Base", tC_EItem.TCEI_Base);
         }
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Conclusion))
         {
            idb.AddParameter("@TCEI_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Conclusion", tC_EItem.TCEI_Conclusion);
         }
         if (tC_EItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_EItem.Stat);
         }
         if (tC_EItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_EItem.CreateDate);
         }
         if (tC_EItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_EItem.UpdateDate);
         }
         if (tC_EItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_EItem.DeleteDate);
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
      /// 更新TC_EItem对象(即:一条记录
      /// </summary>
      public int Update(TC_EItem tC_EItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_EItem       SET ");
            if(tC_EItem.TCEI_Code_IsChanged){sbParameter.Append("TCEI_Code=@TCEI_Code, ");}
      if(tC_EItem.TCEI_MainCode_IsChanged){sbParameter.Append("TCEI_MainCode=@TCEI_MainCode, ");}
      if(tC_EItem.TCEI_ICode_IsChanged){sbParameter.Append("TCEI_ICode=@TCEI_ICode, ");}
      if(tC_EItem.TCEI_IName_IsChanged){sbParameter.Append("TCEI_IName=@TCEI_IName, ");}
      if(tC_EItem.TCEI_IValue_IsChanged){sbParameter.Append("TCEI_IValue=@TCEI_IValue, ");}
      if(tC_EItem.TCEI_MVal_IsChanged){sbParameter.Append("TCEI_MVal=@TCEI_MVal, ");}
      if(tC_EItem.TCEI_RefVal_IsChanged){sbParameter.Append("TCEI_RefVal=@TCEI_RefVal, ");}
      if(tC_EItem.TCEI_Base_IsChanged){sbParameter.Append("TCEI_Base=@TCEI_Base, ");}
      if(tC_EItem.TCEI_Conclusion_IsChanged){sbParameter.Append("TCEI_Conclusion=@TCEI_Conclusion, ");}
      if(tC_EItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_EItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_EItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_EItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCEI_ID=@TCEI_ID; " );
      string sql=sb.ToString();
         if(tC_EItem.TCEI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Code))
         {
            idb.AddParameter("@TCEI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Code", tC_EItem.TCEI_Code);
         }
          }
         if(tC_EItem.TCEI_MainCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_MainCode))
         {
            idb.AddParameter("@TCEI_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_MainCode", tC_EItem.TCEI_MainCode);
         }
          }
         if(tC_EItem.TCEI_ICode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_ICode))
         {
            idb.AddParameter("@TCEI_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_ICode", tC_EItem.TCEI_ICode);
         }
          }
         if(tC_EItem.TCEI_IName_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_IName))
         {
            idb.AddParameter("@TCEI_IName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_IName", tC_EItem.TCEI_IName);
         }
          }
         if(tC_EItem.TCEI_IValue_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_IValue))
         {
            idb.AddParameter("@TCEI_IValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_IValue", tC_EItem.TCEI_IValue);
         }
          }
         if(tC_EItem.TCEI_MVal_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_MVal))
         {
            idb.AddParameter("@TCEI_MVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_MVal", tC_EItem.TCEI_MVal);
         }
          }
         if(tC_EItem.TCEI_RefVal_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_RefVal))
         {
            idb.AddParameter("@TCEI_RefVal", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_RefVal", tC_EItem.TCEI_RefVal);
         }
          }
         if(tC_EItem.TCEI_Base_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Base))
         {
            idb.AddParameter("@TCEI_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Base", tC_EItem.TCEI_Base);
         }
          }
         if(tC_EItem.TCEI_Conclusion_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_EItem.TCEI_Conclusion))
         {
            idb.AddParameter("@TCEI_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCEI_Conclusion", tC_EItem.TCEI_Conclusion);
         }
          }
         if(tC_EItem.Stat_IsChanged)
         {
         if (tC_EItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_EItem.Stat);
         }
          }
         if(tC_EItem.CreateDate_IsChanged)
         {
         if (tC_EItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_EItem.CreateDate);
         }
          }
         if(tC_EItem.UpdateDate_IsChanged)
         {
         if (tC_EItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_EItem.UpdateDate);
         }
          }
         if(tC_EItem.DeleteDate_IsChanged)
         {
         if (tC_EItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_EItem.DeleteDate);
         }
          }

         idb.AddParameter("@TCEI_ID", tC_EItem.TCEI_ID);

           
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
      /// 删除TC_EItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCEI_ID)
      {
         string sql = "DELETE TC_EItem WHERE 1=1  AND TCEI_ID=@TCEI_ID ";
         idb.AddParameter("@TCEI_ID", tCEI_ID);

           
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
      /// 获取指定的TC_EItem对象(即:一条记录
      /// </summary>
      public TC_EItem GetByKey(decimal tCEI_ID)
      {
         TC_EItem tC_EItem = new TC_EItem();
         string sql = "SELECT  TCEI_ID,TCEI_Code,TCEI_MainCode,TCEI_ICode,TCEI_IName,TCEI_IValue,TCEI_MVal,TCEI_RefVal,TCEI_Base,TCEI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_EItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCEI_ID=@TCEI_ID ";
         idb.AddParameter("@TCEI_ID", tCEI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCEI_ID"] != DBNull.Value) tC_EItem.TCEI_ID = Convert.ToDecimal(dr["TCEI_ID"]);
            if (dr["TCEI_Code"] != DBNull.Value) tC_EItem.TCEI_Code = Convert.ToString(dr["TCEI_Code"]);
            if (dr["TCEI_MainCode"] != DBNull.Value) tC_EItem.TCEI_MainCode = Convert.ToString(dr["TCEI_MainCode"]);
            if (dr["TCEI_ICode"] != DBNull.Value) tC_EItem.TCEI_ICode = Convert.ToString(dr["TCEI_ICode"]);
            if (dr["TCEI_IName"] != DBNull.Value) tC_EItem.TCEI_IName = Convert.ToString(dr["TCEI_IName"]);
            if (dr["TCEI_IValue"] != DBNull.Value) tC_EItem.TCEI_IValue = Convert.ToString(dr["TCEI_IValue"]);
            if (dr["TCEI_MVal"] != DBNull.Value) tC_EItem.TCEI_MVal = Convert.ToString(dr["TCEI_MVal"]);
            if (dr["TCEI_RefVal"] != DBNull.Value) tC_EItem.TCEI_RefVal = Convert.ToString(dr["TCEI_RefVal"]);
            if (dr["TCEI_Base"] != DBNull.Value) tC_EItem.TCEI_Base = Convert.ToString(dr["TCEI_Base"]);
            if (dr["TCEI_Conclusion"] != DBNull.Value) tC_EItem.TCEI_Conclusion = Convert.ToString(dr["TCEI_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_EItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_EItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_EItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_EItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_EItem;
      }
      /// <summary>
      /// 获取指定的TC_EItem对象集合
      /// </summary>
      public List<TC_EItem> GetListByWhere(string strCondition)
      {
         List<TC_EItem> ret = new List<TC_EItem>();
         string sql = "SELECT  TCEI_ID,TCEI_Code,TCEI_MainCode,TCEI_ICode,TCEI_IName,TCEI_IValue,TCEI_MVal,TCEI_RefVal,TCEI_Base,TCEI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_EItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_EItem tC_EItem = new TC_EItem();
            if (dr["TCEI_ID"] != DBNull.Value) tC_EItem.TCEI_ID = Convert.ToDecimal(dr["TCEI_ID"]);
            if (dr["TCEI_Code"] != DBNull.Value) tC_EItem.TCEI_Code = Convert.ToString(dr["TCEI_Code"]);
            if (dr["TCEI_MainCode"] != DBNull.Value) tC_EItem.TCEI_MainCode = Convert.ToString(dr["TCEI_MainCode"]);
            if (dr["TCEI_ICode"] != DBNull.Value) tC_EItem.TCEI_ICode = Convert.ToString(dr["TCEI_ICode"]);
            if (dr["TCEI_IName"] != DBNull.Value) tC_EItem.TCEI_IName = Convert.ToString(dr["TCEI_IName"]);
            if (dr["TCEI_IValue"] != DBNull.Value) tC_EItem.TCEI_IValue = Convert.ToString(dr["TCEI_IValue"]);
            if (dr["TCEI_MVal"] != DBNull.Value) tC_EItem.TCEI_MVal = Convert.ToString(dr["TCEI_MVal"]);
            if (dr["TCEI_RefVal"] != DBNull.Value) tC_EItem.TCEI_RefVal = Convert.ToString(dr["TCEI_RefVal"]);
            if (dr["TCEI_Base"] != DBNull.Value) tC_EItem.TCEI_Base = Convert.ToString(dr["TCEI_Base"]);
            if (dr["TCEI_Conclusion"] != DBNull.Value) tC_EItem.TCEI_Conclusion = Convert.ToString(dr["TCEI_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_EItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_EItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_EItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_EItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_EItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的TC_EItem对象(即:一条记录
      /// </summary>
      public List<TC_EItem> GetAll()
      {
         List<TC_EItem> ret = new List<TC_EItem>();
         string sql = "SELECT  TCEI_ID,TCEI_Code,TCEI_MainCode,TCEI_ICode,TCEI_IName,TCEI_IValue,TCEI_MVal,TCEI_RefVal,TCEI_Base,TCEI_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_EItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCEI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_EItem tC_EItem = new TC_EItem();
            if (dr["TCEI_ID"] != DBNull.Value) tC_EItem.TCEI_ID = Convert.ToDecimal(dr["TCEI_ID"]);
            if (dr["TCEI_Code"] != DBNull.Value) tC_EItem.TCEI_Code = Convert.ToString(dr["TCEI_Code"]);
            if (dr["TCEI_MainCode"] != DBNull.Value) tC_EItem.TCEI_MainCode = Convert.ToString(dr["TCEI_MainCode"]);
            if (dr["TCEI_ICode"] != DBNull.Value) tC_EItem.TCEI_ICode = Convert.ToString(dr["TCEI_ICode"]);
            if (dr["TCEI_IName"] != DBNull.Value) tC_EItem.TCEI_IName = Convert.ToString(dr["TCEI_IName"]);
            if (dr["TCEI_IValue"] != DBNull.Value) tC_EItem.TCEI_IValue = Convert.ToString(dr["TCEI_IValue"]);
            if (dr["TCEI_MVal"] != DBNull.Value) tC_EItem.TCEI_MVal = Convert.ToString(dr["TCEI_MVal"]);
            if (dr["TCEI_RefVal"] != DBNull.Value) tC_EItem.TCEI_RefVal = Convert.ToString(dr["TCEI_RefVal"]);
            if (dr["TCEI_Base"] != DBNull.Value) tC_EItem.TCEI_Base = Convert.ToString(dr["TCEI_Base"]);
            if (dr["TCEI_Conclusion"] != DBNull.Value) tC_EItem.TCEI_Conclusion = Convert.ToString(dr["TCEI_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_EItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_EItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_EItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_EItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_EItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
