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
   /// 客户回访明细
   /// </summary>
   [Serializable]
   public partial class ADOVisit_Details
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加客户回访明细 Visit_Details对象(即:一条记录)
      /// </summary>
      public int Add(Visit_Details visit_Details)
      {
         string sql = "INSERT INTO Visit_Details (CVDetails_Code,CVDetails_CVCode,CVDetails_Item,CVDetails_Rating,CVDetails_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CVDetails_Code,@CVDetails_CVCode,@CVDetails_Item,@CVDetails_Rating,@CVDetails_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Code))
         {
            idb.AddParameter("@CVDetails_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Code", visit_Details.CVDetails_Code);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_CVCode))
         {
            idb.AddParameter("@CVDetails_CVCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_CVCode", visit_Details.CVDetails_CVCode);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Item))
         {
            idb.AddParameter("@CVDetails_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Item", visit_Details.CVDetails_Item);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Rating))
         {
            idb.AddParameter("@CVDetails_Rating", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Rating", visit_Details.CVDetails_Rating);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Remark))
         {
            idb.AddParameter("@CVDetails_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Remark", visit_Details.CVDetails_Remark);
         }
         if (visit_Details.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", visit_Details.Stat);
         }
         if (visit_Details.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", visit_Details.CreateDate);
         }
         if (visit_Details.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", visit_Details.UpdateDate);
         }
         if (visit_Details.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", visit_Details.DeleteDate);
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
      /// 添加客户回访明细 Visit_Details对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Visit_Details visit_Details)
      {
         string sql = "INSERT INTO Visit_Details (CVDetails_Code,CVDetails_CVCode,CVDetails_Item,CVDetails_Rating,CVDetails_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CVDetails_Code,@CVDetails_CVCode,@CVDetails_Item,@CVDetails_Rating,@CVDetails_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Code))
         {
            idb.AddParameter("@CVDetails_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Code", visit_Details.CVDetails_Code);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_CVCode))
         {
            idb.AddParameter("@CVDetails_CVCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_CVCode", visit_Details.CVDetails_CVCode);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Item))
         {
            idb.AddParameter("@CVDetails_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Item", visit_Details.CVDetails_Item);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Rating))
         {
            idb.AddParameter("@CVDetails_Rating", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Rating", visit_Details.CVDetails_Rating);
         }
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Remark))
         {
            idb.AddParameter("@CVDetails_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Remark", visit_Details.CVDetails_Remark);
         }
         if (visit_Details.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", visit_Details.Stat);
         }
         if (visit_Details.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", visit_Details.CreateDate);
         }
         if (visit_Details.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", visit_Details.UpdateDate);
         }
         if (visit_Details.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", visit_Details.DeleteDate);
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
      /// 更新客户回访明细 Visit_Details对象(即:一条记录
      /// </summary>
      public int Update(Visit_Details visit_Details)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Visit_Details       SET ");
            if(visit_Details.CVDetails_Code_IsChanged){sbParameter.Append("CVDetails_Code=@CVDetails_Code, ");}
      if(visit_Details.CVDetails_CVCode_IsChanged){sbParameter.Append("CVDetails_CVCode=@CVDetails_CVCode, ");}
      if(visit_Details.CVDetails_Item_IsChanged){sbParameter.Append("CVDetails_Item=@CVDetails_Item, ");}
      if(visit_Details.CVDetails_Rating_IsChanged){sbParameter.Append("CVDetails_Rating=@CVDetails_Rating, ");}
      if(visit_Details.CVDetails_Remark_IsChanged){sbParameter.Append("CVDetails_Remark=@CVDetails_Remark, ");}
      if(visit_Details.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(visit_Details.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(visit_Details.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(visit_Details.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CVDetails_ID=@CVDetails_ID; " );
      string sql=sb.ToString();
         if(visit_Details.CVDetails_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Code))
         {
            idb.AddParameter("@CVDetails_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Code", visit_Details.CVDetails_Code);
         }
          }
         if(visit_Details.CVDetails_CVCode_IsChanged)
         {
         if (string.IsNullOrEmpty(visit_Details.CVDetails_CVCode))
         {
            idb.AddParameter("@CVDetails_CVCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_CVCode", visit_Details.CVDetails_CVCode);
         }
          }
         if(visit_Details.CVDetails_Item_IsChanged)
         {
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Item))
         {
            idb.AddParameter("@CVDetails_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Item", visit_Details.CVDetails_Item);
         }
          }
         if(visit_Details.CVDetails_Rating_IsChanged)
         {
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Rating))
         {
            idb.AddParameter("@CVDetails_Rating", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Rating", visit_Details.CVDetails_Rating);
         }
          }
         if(visit_Details.CVDetails_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(visit_Details.CVDetails_Remark))
         {
            idb.AddParameter("@CVDetails_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CVDetails_Remark", visit_Details.CVDetails_Remark);
         }
          }
         if(visit_Details.Stat_IsChanged)
         {
         if (visit_Details.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", visit_Details.Stat);
         }
          }
         if(visit_Details.CreateDate_IsChanged)
         {
         if (visit_Details.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", visit_Details.CreateDate);
         }
          }
         if(visit_Details.UpdateDate_IsChanged)
         {
         if (visit_Details.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", visit_Details.UpdateDate);
         }
          }
         if(visit_Details.DeleteDate_IsChanged)
         {
         if (visit_Details.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", visit_Details.DeleteDate);
         }
          }

         idb.AddParameter("@CVDetails_ID", visit_Details.CVDetails_ID);

           
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
      /// 删除客户回访明细 Visit_Details对象(即:一条记录
      /// </summary>
      public int Delete(decimal cVDetails_ID)
      {
         string sql = "DELETE Visit_Details WHERE 1=1  AND CVDetails_ID=@CVDetails_ID ";
         idb.AddParameter("@CVDetails_ID", cVDetails_ID);

           
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
      /// 获取指定的客户回访明细 Visit_Details对象(即:一条记录
      /// </summary>
      public Visit_Details GetByKey(decimal cVDetails_ID)
      {
         Visit_Details visit_Details = new Visit_Details();
         string sql = "SELECT  CVDetails_ID,CVDetails_Code,CVDetails_CVCode,CVDetails_Item,CVDetails_Rating,CVDetails_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Visit_Details WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CVDetails_ID=@CVDetails_ID ";
         idb.AddParameter("@CVDetails_ID", cVDetails_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CVDetails_ID"] != DBNull.Value) visit_Details.CVDetails_ID = Convert.ToDecimal(dr["CVDetails_ID"]);
            if (dr["CVDetails_Code"] != DBNull.Value) visit_Details.CVDetails_Code = Convert.ToString(dr["CVDetails_Code"]);
            if (dr["CVDetails_CVCode"] != DBNull.Value) visit_Details.CVDetails_CVCode = Convert.ToString(dr["CVDetails_CVCode"]);
            if (dr["CVDetails_Item"] != DBNull.Value) visit_Details.CVDetails_Item = Convert.ToString(dr["CVDetails_Item"]);
            if (dr["CVDetails_Rating"] != DBNull.Value) visit_Details.CVDetails_Rating = Convert.ToString(dr["CVDetails_Rating"]);
            if (dr["CVDetails_Remark"] != DBNull.Value) visit_Details.CVDetails_Remark = Convert.ToString(dr["CVDetails_Remark"]);
            if (dr["Stat"] != DBNull.Value) visit_Details.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) visit_Details.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) visit_Details.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) visit_Details.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return visit_Details;
      }
      /// <summary>
      /// 获取指定的客户回访明细 Visit_Details对象集合
      /// </summary>
      public List<Visit_Details> GetListByWhere(string strCondition)
      {
         List<Visit_Details> ret = new List<Visit_Details>();
         string sql = "SELECT  CVDetails_ID,CVDetails_Code,CVDetails_CVCode,CVDetails_Item,CVDetails_Rating,CVDetails_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Visit_Details WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Visit_Details visit_Details = new Visit_Details();
            if (dr["CVDetails_ID"] != DBNull.Value) visit_Details.CVDetails_ID = Convert.ToDecimal(dr["CVDetails_ID"]);
            if (dr["CVDetails_Code"] != DBNull.Value) visit_Details.CVDetails_Code = Convert.ToString(dr["CVDetails_Code"]);
            if (dr["CVDetails_CVCode"] != DBNull.Value) visit_Details.CVDetails_CVCode = Convert.ToString(dr["CVDetails_CVCode"]);
            if (dr["CVDetails_Item"] != DBNull.Value) visit_Details.CVDetails_Item = Convert.ToString(dr["CVDetails_Item"]);
            if (dr["CVDetails_Rating"] != DBNull.Value) visit_Details.CVDetails_Rating = Convert.ToString(dr["CVDetails_Rating"]);
            if (dr["CVDetails_Remark"] != DBNull.Value) visit_Details.CVDetails_Remark = Convert.ToString(dr["CVDetails_Remark"]);
            if (dr["Stat"] != DBNull.Value) visit_Details.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) visit_Details.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) visit_Details.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) visit_Details.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(visit_Details);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的客户回访明细 Visit_Details对象(即:一条记录
      /// </summary>
      public List<Visit_Details> GetAll()
      {
         List<Visit_Details> ret = new List<Visit_Details>();
         string sql = "SELECT  CVDetails_ID,CVDetails_Code,CVDetails_CVCode,CVDetails_Item,CVDetails_Rating,CVDetails_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Visit_Details where 1=1 AND ((Stat is null) or (Stat=0) ) order by CVDetails_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Visit_Details visit_Details = new Visit_Details();
            if (dr["CVDetails_ID"] != DBNull.Value) visit_Details.CVDetails_ID = Convert.ToDecimal(dr["CVDetails_ID"]);
            if (dr["CVDetails_Code"] != DBNull.Value) visit_Details.CVDetails_Code = Convert.ToString(dr["CVDetails_Code"]);
            if (dr["CVDetails_CVCode"] != DBNull.Value) visit_Details.CVDetails_CVCode = Convert.ToString(dr["CVDetails_CVCode"]);
            if (dr["CVDetails_Item"] != DBNull.Value) visit_Details.CVDetails_Item = Convert.ToString(dr["CVDetails_Item"]);
            if (dr["CVDetails_Rating"] != DBNull.Value) visit_Details.CVDetails_Rating = Convert.ToString(dr["CVDetails_Rating"]);
            if (dr["CVDetails_Remark"] != DBNull.Value) visit_Details.CVDetails_Remark = Convert.ToString(dr["CVDetails_Remark"]);
            if (dr["Stat"] != DBNull.Value) visit_Details.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) visit_Details.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) visit_Details.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) visit_Details.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(visit_Details);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
