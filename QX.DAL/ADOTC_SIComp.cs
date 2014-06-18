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
   /// 标准配合比细目信息
   /// </summary>
   [Serializable]
   public partial class ADOTC_SIComp
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加标准配合比细目信息 TC_SIComp对象(即:一条记录)
      /// </summary>
      public int Add(TC_SIComp tC_SIComp)
      {
         string sql = "INSERT INTO TC_SIComp (TCSI_Code,TCSI_SCode,TCSI_MCode,TCSI_Weight,TCSI_Order,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCSI_Code,@TCSI_SCode,@TCSI_MCode,@TCSI_Weight,@TCSI_Order,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_Code))
         {
            idb.AddParameter("@TCSI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_Code", tC_SIComp.TCSI_Code);
         }
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_SCode))
         {
            idb.AddParameter("@TCSI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_SCode", tC_SIComp.TCSI_SCode);
         }
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_MCode))
         {
            idb.AddParameter("@TCSI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_MCode", tC_SIComp.TCSI_MCode);
         }
         if (tC_SIComp.TCSI_Weight == 0)
         {
            idb.AddParameter("@TCSI_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCSI_Weight", tC_SIComp.TCSI_Weight);
         }
         if (tC_SIComp.TCSI_Order == 0)
         {
            idb.AddParameter("@TCSI_Order", 0);
         }
         else
         {
            idb.AddParameter("@TCSI_Order", tC_SIComp.TCSI_Order);
         }
         if (tC_SIComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SIComp.Stat);
         }
         if (tC_SIComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SIComp.CreateDate);
         }
         if (tC_SIComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SIComp.UpdateDate);
         }
         if (tC_SIComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SIComp.DeleteDate);
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
      /// 添加标准配合比细目信息 TC_SIComp对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_SIComp tC_SIComp)
      {
         string sql = "INSERT INTO TC_SIComp (TCSI_Code,TCSI_SCode,TCSI_MCode,TCSI_Weight,TCSI_Order,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCSI_Code,@TCSI_SCode,@TCSI_MCode,@TCSI_Weight,@TCSI_Order,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_Code))
         {
            idb.AddParameter("@TCSI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_Code", tC_SIComp.TCSI_Code);
         }
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_SCode))
         {
            idb.AddParameter("@TCSI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_SCode", tC_SIComp.TCSI_SCode);
         }
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_MCode))
         {
            idb.AddParameter("@TCSI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_MCode", tC_SIComp.TCSI_MCode);
         }
         if (tC_SIComp.TCSI_Weight == 0)
         {
            idb.AddParameter("@TCSI_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCSI_Weight", tC_SIComp.TCSI_Weight);
         }
         if (tC_SIComp.TCSI_Order == 0)
         {
            idb.AddParameter("@TCSI_Order", 0);
         }
         else
         {
            idb.AddParameter("@TCSI_Order", tC_SIComp.TCSI_Order);
         }
         if (tC_SIComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SIComp.Stat);
         }
         if (tC_SIComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SIComp.CreateDate);
         }
         if (tC_SIComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SIComp.UpdateDate);
         }
         if (tC_SIComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SIComp.DeleteDate);
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
      /// 更新标准配合比细目信息 TC_SIComp对象(即:一条记录
      /// </summary>
      public int Update(TC_SIComp tC_SIComp)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_SIComp       SET ");
            if(tC_SIComp.TCSI_Code_IsChanged){sbParameter.Append("TCSI_Code=@TCSI_Code, ");}
      if(tC_SIComp.TCSI_SCode_IsChanged){sbParameter.Append("TCSI_SCode=@TCSI_SCode, ");}
      if(tC_SIComp.TCSI_MCode_IsChanged){sbParameter.Append("TCSI_MCode=@TCSI_MCode, ");}
      if(tC_SIComp.TCSI_Weight_IsChanged){sbParameter.Append("TCSI_Weight=@TCSI_Weight, ");}
      if(tC_SIComp.TCSI_Order_IsChanged){sbParameter.Append("TCSI_Order=@TCSI_Order, ");}
      if(tC_SIComp.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_SIComp.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_SIComp.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_SIComp.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCSI_ID=@TCSI_ID; " );
      string sql=sb.ToString();
         if(tC_SIComp.TCSI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_Code))
         {
            idb.AddParameter("@TCSI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_Code", tC_SIComp.TCSI_Code);
         }
          }
         if(tC_SIComp.TCSI_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_SCode))
         {
            idb.AddParameter("@TCSI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_SCode", tC_SIComp.TCSI_SCode);
         }
          }
         if(tC_SIComp.TCSI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SIComp.TCSI_MCode))
         {
            idb.AddParameter("@TCSI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCSI_MCode", tC_SIComp.TCSI_MCode);
         }
          }
         if(tC_SIComp.TCSI_Weight_IsChanged)
         {
         if (tC_SIComp.TCSI_Weight == 0)
         {
            idb.AddParameter("@TCSI_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCSI_Weight", tC_SIComp.TCSI_Weight);
         }
          }
         if(tC_SIComp.TCSI_Order_IsChanged)
         {
         if (tC_SIComp.TCSI_Order == 0)
         {
            idb.AddParameter("@TCSI_Order", 0);
         }
         else
         {
            idb.AddParameter("@TCSI_Order", tC_SIComp.TCSI_Order);
         }
          }
         if(tC_SIComp.Stat_IsChanged)
         {
         if (tC_SIComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SIComp.Stat);
         }
          }
         if(tC_SIComp.CreateDate_IsChanged)
         {
         if (tC_SIComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SIComp.CreateDate);
         }
          }
         if(tC_SIComp.UpdateDate_IsChanged)
         {
         if (tC_SIComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SIComp.UpdateDate);
         }
          }
         if(tC_SIComp.DeleteDate_IsChanged)
         {
         if (tC_SIComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SIComp.DeleteDate);
         }
          }

         idb.AddParameter("@TCSI_ID", tC_SIComp.TCSI_ID);

           
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
      /// 删除标准配合比细目信息 TC_SIComp对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCSI_ID)
      {
         string sql = "DELETE TC_SIComp WHERE 1=1  AND TCSI_ID=@TCSI_ID ";
         idb.AddParameter("@TCSI_ID", tCSI_ID);

           
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
      /// 获取指定的标准配合比细目信息 TC_SIComp对象(即:一条记录
      /// </summary>
      public TC_SIComp GetByKey(decimal tCSI_ID)
      {
         TC_SIComp tC_SIComp = new TC_SIComp();
         string sql = "SELECT  TCSI_ID,TCSI_Code,TCSI_SCode,TCSI_MCode,TCSI_Weight,TCSI_Order,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_SIComp WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCSI_ID=@TCSI_ID ";
         idb.AddParameter("@TCSI_ID", tCSI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCSI_ID"] != DBNull.Value) tC_SIComp.TCSI_ID = Convert.ToDecimal(dr["TCSI_ID"]);
            if (dr["TCSI_Code"] != DBNull.Value) tC_SIComp.TCSI_Code = Convert.ToString(dr["TCSI_Code"]);
            if (dr["TCSI_SCode"] != DBNull.Value) tC_SIComp.TCSI_SCode = Convert.ToString(dr["TCSI_SCode"]);
            if (dr["TCSI_MCode"] != DBNull.Value) tC_SIComp.TCSI_MCode = Convert.ToString(dr["TCSI_MCode"]);
            if (dr["TCSI_Weight"] != DBNull.Value) tC_SIComp.TCSI_Weight = Convert.ToDecimal(dr["TCSI_Weight"]);
            if (dr["TCSI_Order"] != DBNull.Value) tC_SIComp.TCSI_Order = Convert.ToInt32(dr["TCSI_Order"]);
            if (dr["Stat"] != DBNull.Value) tC_SIComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SIComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SIComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SIComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_SIComp;
      }
      /// <summary>
      /// 获取指定的标准配合比细目信息 TC_SIComp对象集合
      /// </summary>
      public List<TC_SIComp> GetListByWhere(string strCondition)
      {
         List<TC_SIComp> ret = new List<TC_SIComp>();
         string sql = "SELECT  TCSI_ID,TCSI_Code,TCSI_SCode,TCSI_MCode,TCSI_Weight,TCSI_Order,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_SIComp WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_SIComp tC_SIComp = new TC_SIComp();
            if (dr["TCSI_ID"] != DBNull.Value) tC_SIComp.TCSI_ID = Convert.ToDecimal(dr["TCSI_ID"]);
            if (dr["TCSI_Code"] != DBNull.Value) tC_SIComp.TCSI_Code = Convert.ToString(dr["TCSI_Code"]);
            if (dr["TCSI_SCode"] != DBNull.Value) tC_SIComp.TCSI_SCode = Convert.ToString(dr["TCSI_SCode"]);
            if (dr["TCSI_MCode"] != DBNull.Value) tC_SIComp.TCSI_MCode = Convert.ToString(dr["TCSI_MCode"]);
            if (dr["TCSI_Weight"] != DBNull.Value) tC_SIComp.TCSI_Weight = Convert.ToDecimal(dr["TCSI_Weight"]);
            if (dr["TCSI_Order"] != DBNull.Value) tC_SIComp.TCSI_Order = Convert.ToInt32(dr["TCSI_Order"]);
            if (dr["Stat"] != DBNull.Value) tC_SIComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SIComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SIComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SIComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_SIComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的标准配合比细目信息 TC_SIComp对象(即:一条记录
      /// </summary>
      public List<TC_SIComp> GetAll()
      {
         List<TC_SIComp> ret = new List<TC_SIComp>();
         string sql = "SELECT  TCSI_ID,TCSI_Code,TCSI_SCode,TCSI_MCode,TCSI_Weight,TCSI_Order,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_SIComp where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCSI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_SIComp tC_SIComp = new TC_SIComp();
            if (dr["TCSI_ID"] != DBNull.Value) tC_SIComp.TCSI_ID = Convert.ToDecimal(dr["TCSI_ID"]);
            if (dr["TCSI_Code"] != DBNull.Value) tC_SIComp.TCSI_Code = Convert.ToString(dr["TCSI_Code"]);
            if (dr["TCSI_SCode"] != DBNull.Value) tC_SIComp.TCSI_SCode = Convert.ToString(dr["TCSI_SCode"]);
            if (dr["TCSI_MCode"] != DBNull.Value) tC_SIComp.TCSI_MCode = Convert.ToString(dr["TCSI_MCode"]);
            if (dr["TCSI_Weight"] != DBNull.Value) tC_SIComp.TCSI_Weight = Convert.ToDecimal(dr["TCSI_Weight"]);
            if (dr["TCSI_Order"] != DBNull.Value) tC_SIComp.TCSI_Order = Convert.ToInt32(dr["TCSI_Order"]);
            if (dr["Stat"] != DBNull.Value) tC_SIComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SIComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SIComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SIComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_SIComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
