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
   /// 原料检验参数
   /// </summary>
   [Serializable]
   public partial class ADOTC_RItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加原料检验参数 TC_RItem对象(即:一条记录)
      /// </summary>
      public int Add(TC_RItem tC_RItem)
      {
         string sql = "INSERT INTO TC_RItem (RMCD_Code,RMCD_RMCode,RMCD_ItemValue,RMCD_ItemName,RMCD_ItemCode,RMCD_Result,RMCD_Remark,RMCD_XValue,RMCD_Base,RMCD_RefValue,RMCD_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@RMCD_Code,@RMCD_RMCode,@RMCD_ItemValue,@RMCD_ItemName,@RMCD_ItemCode,@RMCD_Result,@RMCD_Remark,@RMCD_XValue,@RMCD_Base,@RMCD_RefValue,@RMCD_Conclusion,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Code))
         {
            idb.AddParameter("@RMCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Code", tC_RItem.RMCD_Code);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_RMCode))
         {
            idb.AddParameter("@RMCD_RMCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_RMCode", tC_RItem.RMCD_RMCode);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemValue))
         {
            idb.AddParameter("@RMCD_ItemValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemValue", tC_RItem.RMCD_ItemValue);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemName))
         {
            idb.AddParameter("@RMCD_ItemName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemName", tC_RItem.RMCD_ItemName);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemCode))
         {
            idb.AddParameter("@RMCD_ItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemCode", tC_RItem.RMCD_ItemCode);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Result))
         {
            idb.AddParameter("@RMCD_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Result", tC_RItem.RMCD_Result);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Remark))
         {
            idb.AddParameter("@RMCD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Remark", tC_RItem.RMCD_Remark);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_XValue))
         {
            idb.AddParameter("@RMCD_XValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_XValue", tC_RItem.RMCD_XValue);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Base))
         {
            idb.AddParameter("@RMCD_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Base", tC_RItem.RMCD_Base);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_RefValue))
         {
            idb.AddParameter("@RMCD_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_RefValue", tC_RItem.RMCD_RefValue);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Conclusion))
         {
            idb.AddParameter("@RMCD_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Conclusion", tC_RItem.RMCD_Conclusion);
         }
         if (tC_RItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RItem.Stat);
         }
         if (tC_RItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RItem.CreateDate);
         }
         if (tC_RItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RItem.UpdateDate);
         }
         if (tC_RItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RItem.DeleteDate);
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
      /// 添加原料检验参数 TC_RItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_RItem tC_RItem)
      {
         string sql = "INSERT INTO TC_RItem (RMCD_Code,RMCD_RMCode,RMCD_ItemValue,RMCD_ItemName,RMCD_ItemCode,RMCD_Result,RMCD_Remark,RMCD_XValue,RMCD_Base,RMCD_RefValue,RMCD_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@RMCD_Code,@RMCD_RMCode,@RMCD_ItemValue,@RMCD_ItemName,@RMCD_ItemCode,@RMCD_Result,@RMCD_Remark,@RMCD_XValue,@RMCD_Base,@RMCD_RefValue,@RMCD_Conclusion,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Code))
         {
            idb.AddParameter("@RMCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Code", tC_RItem.RMCD_Code);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_RMCode))
         {
            idb.AddParameter("@RMCD_RMCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_RMCode", tC_RItem.RMCD_RMCode);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemValue))
         {
            idb.AddParameter("@RMCD_ItemValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemValue", tC_RItem.RMCD_ItemValue);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemName))
         {
            idb.AddParameter("@RMCD_ItemName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemName", tC_RItem.RMCD_ItemName);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemCode))
         {
            idb.AddParameter("@RMCD_ItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemCode", tC_RItem.RMCD_ItemCode);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Result))
         {
            idb.AddParameter("@RMCD_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Result", tC_RItem.RMCD_Result);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Remark))
         {
            idb.AddParameter("@RMCD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Remark", tC_RItem.RMCD_Remark);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_XValue))
         {
            idb.AddParameter("@RMCD_XValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_XValue", tC_RItem.RMCD_XValue);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Base))
         {
            idb.AddParameter("@RMCD_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Base", tC_RItem.RMCD_Base);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_RefValue))
         {
            idb.AddParameter("@RMCD_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_RefValue", tC_RItem.RMCD_RefValue);
         }
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Conclusion))
         {
            idb.AddParameter("@RMCD_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Conclusion", tC_RItem.RMCD_Conclusion);
         }
         if (tC_RItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RItem.Stat);
         }
         if (tC_RItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RItem.CreateDate);
         }
         if (tC_RItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RItem.UpdateDate);
         }
         if (tC_RItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RItem.DeleteDate);
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
      /// 更新原料检验参数 TC_RItem对象(即:一条记录
      /// </summary>
      public int Update(TC_RItem tC_RItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_RItem       SET ");
            if(tC_RItem.RMCD_Code_IsChanged){sbParameter.Append("RMCD_Code=@RMCD_Code, ");}
      if(tC_RItem.RMCD_RMCode_IsChanged){sbParameter.Append("RMCD_RMCode=@RMCD_RMCode, ");}
      if(tC_RItem.RMCD_ItemValue_IsChanged){sbParameter.Append("RMCD_ItemValue=@RMCD_ItemValue, ");}
      if(tC_RItem.RMCD_ItemName_IsChanged){sbParameter.Append("RMCD_ItemName=@RMCD_ItemName, ");}
      if(tC_RItem.RMCD_ItemCode_IsChanged){sbParameter.Append("RMCD_ItemCode=@RMCD_ItemCode, ");}
      if(tC_RItem.RMCD_Result_IsChanged){sbParameter.Append("RMCD_Result=@RMCD_Result, ");}
      if(tC_RItem.RMCD_Remark_IsChanged){sbParameter.Append("RMCD_Remark=@RMCD_Remark, ");}
      if(tC_RItem.RMCD_XValue_IsChanged){sbParameter.Append("RMCD_XValue=@RMCD_XValue, ");}
      if(tC_RItem.RMCD_Base_IsChanged){sbParameter.Append("RMCD_Base=@RMCD_Base, ");}
      if(tC_RItem.RMCD_RefValue_IsChanged){sbParameter.Append("RMCD_RefValue=@RMCD_RefValue, ");}
      if(tC_RItem.RMCD_Conclusion_IsChanged){sbParameter.Append("RMCD_Conclusion=@RMCD_Conclusion, ");}
      if(tC_RItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_RItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_RItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_RItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RMCD_ID=@RMCD_ID; " );
      string sql=sb.ToString();
         if(tC_RItem.RMCD_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Code))
         {
            idb.AddParameter("@RMCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Code", tC_RItem.RMCD_Code);
         }
          }
         if(tC_RItem.RMCD_RMCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_RMCode))
         {
            idb.AddParameter("@RMCD_RMCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_RMCode", tC_RItem.RMCD_RMCode);
         }
          }
         if(tC_RItem.RMCD_ItemValue_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemValue))
         {
            idb.AddParameter("@RMCD_ItemValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemValue", tC_RItem.RMCD_ItemValue);
         }
          }
         if(tC_RItem.RMCD_ItemName_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemName))
         {
            idb.AddParameter("@RMCD_ItemName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemName", tC_RItem.RMCD_ItemName);
         }
          }
         if(tC_RItem.RMCD_ItemCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_ItemCode))
         {
            idb.AddParameter("@RMCD_ItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_ItemCode", tC_RItem.RMCD_ItemCode);
         }
          }
         if(tC_RItem.RMCD_Result_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Result))
         {
            idb.AddParameter("@RMCD_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Result", tC_RItem.RMCD_Result);
         }
          }
         if(tC_RItem.RMCD_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Remark))
         {
            idb.AddParameter("@RMCD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Remark", tC_RItem.RMCD_Remark);
         }
          }
         if(tC_RItem.RMCD_XValue_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_XValue))
         {
            idb.AddParameter("@RMCD_XValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_XValue", tC_RItem.RMCD_XValue);
         }
          }
         if(tC_RItem.RMCD_Base_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Base))
         {
            idb.AddParameter("@RMCD_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Base", tC_RItem.RMCD_Base);
         }
          }
         if(tC_RItem.RMCD_RefValue_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_RefValue))
         {
            idb.AddParameter("@RMCD_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_RefValue", tC_RItem.RMCD_RefValue);
         }
          }
         if(tC_RItem.RMCD_Conclusion_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RItem.RMCD_Conclusion))
         {
            idb.AddParameter("@RMCD_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RMCD_Conclusion", tC_RItem.RMCD_Conclusion);
         }
          }
         if(tC_RItem.Stat_IsChanged)
         {
         if (tC_RItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RItem.Stat);
         }
          }
         if(tC_RItem.CreateDate_IsChanged)
         {
         if (tC_RItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RItem.CreateDate);
         }
          }
         if(tC_RItem.UpdateDate_IsChanged)
         {
         if (tC_RItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RItem.UpdateDate);
         }
          }
         if(tC_RItem.DeleteDate_IsChanged)
         {
         if (tC_RItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RItem.DeleteDate);
         }
          }

         idb.AddParameter("@RMCD_ID", tC_RItem.RMCD_ID);

           
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
      /// 删除原料检验参数 TC_RItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal rMCD_ID)
      {
         string sql = "DELETE TC_RItem WHERE 1=1  AND RMCD_ID=@RMCD_ID ";
         idb.AddParameter("@RMCD_ID", rMCD_ID);

           
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
      /// 获取指定的原料检验参数 TC_RItem对象(即:一条记录
      /// </summary>
      public TC_RItem GetByKey(decimal rMCD_ID)
      {
         TC_RItem tC_RItem = new TC_RItem();
         string sql = "SELECT  RMCD_ID,RMCD_Code,RMCD_RMCode,RMCD_ItemValue,RMCD_ItemName,RMCD_ItemCode,RMCD_Result,RMCD_Remark,RMCD_XValue,RMCD_Base,RMCD_RefValue,RMCD_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RMCD_ID=@RMCD_ID ";
         idb.AddParameter("@RMCD_ID", rMCD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RMCD_ID"] != DBNull.Value) tC_RItem.RMCD_ID = Convert.ToDecimal(dr["RMCD_ID"]);
            if (dr["RMCD_Code"] != DBNull.Value) tC_RItem.RMCD_Code = Convert.ToString(dr["RMCD_Code"]);
            if (dr["RMCD_RMCode"] != DBNull.Value) tC_RItem.RMCD_RMCode = Convert.ToString(dr["RMCD_RMCode"]);
            if (dr["RMCD_ItemValue"] != DBNull.Value) tC_RItem.RMCD_ItemValue = Convert.ToString(dr["RMCD_ItemValue"]);
            if (dr["RMCD_ItemName"] != DBNull.Value) tC_RItem.RMCD_ItemName = Convert.ToString(dr["RMCD_ItemName"]);
            if (dr["RMCD_ItemCode"] != DBNull.Value) tC_RItem.RMCD_ItemCode = Convert.ToString(dr["RMCD_ItemCode"]);
            if (dr["RMCD_Result"] != DBNull.Value) tC_RItem.RMCD_Result = Convert.ToString(dr["RMCD_Result"]);
            if (dr["RMCD_Remark"] != DBNull.Value) tC_RItem.RMCD_Remark = Convert.ToString(dr["RMCD_Remark"]);
            if (dr["RMCD_XValue"] != DBNull.Value) tC_RItem.RMCD_XValue = Convert.ToString(dr["RMCD_XValue"]);
            if (dr["RMCD_Base"] != DBNull.Value) tC_RItem.RMCD_Base = Convert.ToString(dr["RMCD_Base"]);
            if (dr["RMCD_RefValue"] != DBNull.Value) tC_RItem.RMCD_RefValue = Convert.ToString(dr["RMCD_RefValue"]);
            if (dr["RMCD_Conclusion"] != DBNull.Value) tC_RItem.RMCD_Conclusion = Convert.ToString(dr["RMCD_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_RItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_RItem;
      }
      /// <summary>
      /// 获取指定的原料检验参数 TC_RItem对象集合
      /// </summary>
      public List<TC_RItem> GetListByWhere(string strCondition)
      {
         List<TC_RItem> ret = new List<TC_RItem>();
         string sql = "SELECT  RMCD_ID,RMCD_Code,RMCD_RMCode,RMCD_ItemValue,RMCD_ItemName,RMCD_ItemCode,RMCD_Result,RMCD_Remark,RMCD_XValue,RMCD_Base,RMCD_RefValue,RMCD_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_RItem tC_RItem = new TC_RItem();
            if (dr["RMCD_ID"] != DBNull.Value) tC_RItem.RMCD_ID = Convert.ToDecimal(dr["RMCD_ID"]);
            if (dr["RMCD_Code"] != DBNull.Value) tC_RItem.RMCD_Code = Convert.ToString(dr["RMCD_Code"]);
            if (dr["RMCD_RMCode"] != DBNull.Value) tC_RItem.RMCD_RMCode = Convert.ToString(dr["RMCD_RMCode"]);
            if (dr["RMCD_ItemValue"] != DBNull.Value) tC_RItem.RMCD_ItemValue = Convert.ToString(dr["RMCD_ItemValue"]);
            if (dr["RMCD_ItemName"] != DBNull.Value) tC_RItem.RMCD_ItemName = Convert.ToString(dr["RMCD_ItemName"]);
            if (dr["RMCD_ItemCode"] != DBNull.Value) tC_RItem.RMCD_ItemCode = Convert.ToString(dr["RMCD_ItemCode"]);
            if (dr["RMCD_Result"] != DBNull.Value) tC_RItem.RMCD_Result = Convert.ToString(dr["RMCD_Result"]);
            if (dr["RMCD_Remark"] != DBNull.Value) tC_RItem.RMCD_Remark = Convert.ToString(dr["RMCD_Remark"]);
            if (dr["RMCD_XValue"] != DBNull.Value) tC_RItem.RMCD_XValue = Convert.ToString(dr["RMCD_XValue"]);
            if (dr["RMCD_Base"] != DBNull.Value) tC_RItem.RMCD_Base = Convert.ToString(dr["RMCD_Base"]);
            if (dr["RMCD_RefValue"] != DBNull.Value) tC_RItem.RMCD_RefValue = Convert.ToString(dr["RMCD_RefValue"]);
            if (dr["RMCD_Conclusion"] != DBNull.Value) tC_RItem.RMCD_Conclusion = Convert.ToString(dr["RMCD_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_RItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的原料检验参数 TC_RItem对象(即:一条记录
      /// </summary>
      public List<TC_RItem> GetAll()
      {
         List<TC_RItem> ret = new List<TC_RItem>();
         string sql = "SELECT  RMCD_ID,RMCD_Code,RMCD_RMCode,RMCD_ItemValue,RMCD_ItemName,RMCD_ItemCode,RMCD_Result,RMCD_Remark,RMCD_XValue,RMCD_Base,RMCD_RefValue,RMCD_Conclusion,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by RMCD_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_RItem tC_RItem = new TC_RItem();
            if (dr["RMCD_ID"] != DBNull.Value) tC_RItem.RMCD_ID = Convert.ToDecimal(dr["RMCD_ID"]);
            if (dr["RMCD_Code"] != DBNull.Value) tC_RItem.RMCD_Code = Convert.ToString(dr["RMCD_Code"]);
            if (dr["RMCD_RMCode"] != DBNull.Value) tC_RItem.RMCD_RMCode = Convert.ToString(dr["RMCD_RMCode"]);
            if (dr["RMCD_ItemValue"] != DBNull.Value) tC_RItem.RMCD_ItemValue = Convert.ToString(dr["RMCD_ItemValue"]);
            if (dr["RMCD_ItemName"] != DBNull.Value) tC_RItem.RMCD_ItemName = Convert.ToString(dr["RMCD_ItemName"]);
            if (dr["RMCD_ItemCode"] != DBNull.Value) tC_RItem.RMCD_ItemCode = Convert.ToString(dr["RMCD_ItemCode"]);
            if (dr["RMCD_Result"] != DBNull.Value) tC_RItem.RMCD_Result = Convert.ToString(dr["RMCD_Result"]);
            if (dr["RMCD_Remark"] != DBNull.Value) tC_RItem.RMCD_Remark = Convert.ToString(dr["RMCD_Remark"]);
            if (dr["RMCD_XValue"] != DBNull.Value) tC_RItem.RMCD_XValue = Convert.ToString(dr["RMCD_XValue"]);
            if (dr["RMCD_Base"] != DBNull.Value) tC_RItem.RMCD_Base = Convert.ToString(dr["RMCD_Base"]);
            if (dr["RMCD_RefValue"] != DBNull.Value) tC_RItem.RMCD_RefValue = Convert.ToString(dr["RMCD_RefValue"]);
            if (dr["RMCD_Conclusion"] != DBNull.Value) tC_RItem.RMCD_Conclusion = Convert.ToString(dr["RMCD_Conclusion"]);
            if (dr["Stat"] != DBNull.Value) tC_RItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
