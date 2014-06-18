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
   /// 纯净水空桶管理
   /// </summary>
   [Serializable]
   public partial class ADOEmptyPureWater_Manage
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加纯净水空桶管理 EmptyPureWater_Manage对象(即:一条记录)
      /// </summary>
      public int Add(EmptyPureWater_Manage emptyPureWater_Manage)
      {
         string sql = "INSERT INTO EmptyPureWater_Manage (EPW_Code,EPW_Duty,EPW_EmptyPosition,EPW_Count,EPW_Remark,Stat,CreateDate,UpdateDate,DeleteDate,EPW_Company,EPW_Dept) VALUES (@EPW_Code,@EPW_Duty,@EPW_EmptyPosition,@EPW_Count,@EPW_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@EPW_Company,@EPW_Dept)";
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Code))
         {
            idb.AddParameter("@EPW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Code", emptyPureWater_Manage.EPW_Code);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Duty))
         {
            idb.AddParameter("@EPW_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Duty", emptyPureWater_Manage.EPW_Duty);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_EmptyPosition))
         {
            idb.AddParameter("@EPW_EmptyPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_EmptyPosition", emptyPureWater_Manage.EPW_EmptyPosition);
         }
         if (emptyPureWater_Manage.EPW_Count == 0)
         {
            idb.AddParameter("@EPW_Count", 0);
         }
         else
         {
            idb.AddParameter("@EPW_Count", emptyPureWater_Manage.EPW_Count);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Remark))
         {
            idb.AddParameter("@EPW_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Remark", emptyPureWater_Manage.EPW_Remark);
         }
         if (emptyPureWater_Manage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", emptyPureWater_Manage.Stat);
         }
         if (emptyPureWater_Manage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", emptyPureWater_Manage.CreateDate);
         }
         if (emptyPureWater_Manage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", emptyPureWater_Manage.UpdateDate);
         }
         if (emptyPureWater_Manage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", emptyPureWater_Manage.DeleteDate);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Company))
         {
            idb.AddParameter("@EPW_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Company", emptyPureWater_Manage.EPW_Company);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Dept))
         {
            idb.AddParameter("@EPW_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Dept", emptyPureWater_Manage.EPW_Dept);
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
      /// 添加纯净水空桶管理 EmptyPureWater_Manage对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(EmptyPureWater_Manage emptyPureWater_Manage)
      {
         string sql = "INSERT INTO EmptyPureWater_Manage (EPW_Code,EPW_Duty,EPW_EmptyPosition,EPW_Count,EPW_Remark,Stat,CreateDate,UpdateDate,DeleteDate,EPW_Company,EPW_Dept) VALUES (@EPW_Code,@EPW_Duty,@EPW_EmptyPosition,@EPW_Count,@EPW_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@EPW_Company,@EPW_Dept);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Code))
         {
            idb.AddParameter("@EPW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Code", emptyPureWater_Manage.EPW_Code);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Duty))
         {
            idb.AddParameter("@EPW_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Duty", emptyPureWater_Manage.EPW_Duty);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_EmptyPosition))
         {
            idb.AddParameter("@EPW_EmptyPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_EmptyPosition", emptyPureWater_Manage.EPW_EmptyPosition);
         }
         if (emptyPureWater_Manage.EPW_Count == 0)
         {
            idb.AddParameter("@EPW_Count", 0);
         }
         else
         {
            idb.AddParameter("@EPW_Count", emptyPureWater_Manage.EPW_Count);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Remark))
         {
            idb.AddParameter("@EPW_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Remark", emptyPureWater_Manage.EPW_Remark);
         }
         if (emptyPureWater_Manage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", emptyPureWater_Manage.Stat);
         }
         if (emptyPureWater_Manage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", emptyPureWater_Manage.CreateDate);
         }
         if (emptyPureWater_Manage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", emptyPureWater_Manage.UpdateDate);
         }
         if (emptyPureWater_Manage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", emptyPureWater_Manage.DeleteDate);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Company))
         {
            idb.AddParameter("@EPW_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Company", emptyPureWater_Manage.EPW_Company);
         }
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Dept))
         {
            idb.AddParameter("@EPW_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Dept", emptyPureWater_Manage.EPW_Dept);
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
      /// 更新纯净水空桶管理 EmptyPureWater_Manage对象(即:一条记录
      /// </summary>
      public int Update(EmptyPureWater_Manage emptyPureWater_Manage)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       EmptyPureWater_Manage       SET ");
            if(emptyPureWater_Manage.EPW_Code_IsChanged){sbParameter.Append("EPW_Code=@EPW_Code, ");}
      if(emptyPureWater_Manage.EPW_Duty_IsChanged){sbParameter.Append("EPW_Duty=@EPW_Duty, ");}
      if(emptyPureWater_Manage.EPW_EmptyPosition_IsChanged){sbParameter.Append("EPW_EmptyPosition=@EPW_EmptyPosition, ");}
      if(emptyPureWater_Manage.EPW_Count_IsChanged){sbParameter.Append("EPW_Count=@EPW_Count, ");}
      if(emptyPureWater_Manage.EPW_Remark_IsChanged){sbParameter.Append("EPW_Remark=@EPW_Remark, ");}
      if(emptyPureWater_Manage.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(emptyPureWater_Manage.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(emptyPureWater_Manage.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(emptyPureWater_Manage.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(emptyPureWater_Manage.EPW_Company_IsChanged){sbParameter.Append("EPW_Company=@EPW_Company, ");}
      if(emptyPureWater_Manage.EPW_Dept_IsChanged){sbParameter.Append("EPW_Dept=@EPW_Dept ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EPW_ID=@EPW_ID; " );
      string sql=sb.ToString();
         if(emptyPureWater_Manage.EPW_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Code))
         {
            idb.AddParameter("@EPW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Code", emptyPureWater_Manage.EPW_Code);
         }
          }
         if(emptyPureWater_Manage.EPW_Duty_IsChanged)
         {
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Duty))
         {
            idb.AddParameter("@EPW_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Duty", emptyPureWater_Manage.EPW_Duty);
         }
          }
         if(emptyPureWater_Manage.EPW_EmptyPosition_IsChanged)
         {
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_EmptyPosition))
         {
            idb.AddParameter("@EPW_EmptyPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_EmptyPosition", emptyPureWater_Manage.EPW_EmptyPosition);
         }
          }
         if(emptyPureWater_Manage.EPW_Count_IsChanged)
         {
         if (emptyPureWater_Manage.EPW_Count == 0)
         {
            idb.AddParameter("@EPW_Count", 0);
         }
         else
         {
            idb.AddParameter("@EPW_Count", emptyPureWater_Manage.EPW_Count);
         }
          }
         if(emptyPureWater_Manage.EPW_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Remark))
         {
            idb.AddParameter("@EPW_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Remark", emptyPureWater_Manage.EPW_Remark);
         }
          }
         if(emptyPureWater_Manage.Stat_IsChanged)
         {
         if (emptyPureWater_Manage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", emptyPureWater_Manage.Stat);
         }
          }
         if(emptyPureWater_Manage.CreateDate_IsChanged)
         {
         if (emptyPureWater_Manage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", emptyPureWater_Manage.CreateDate);
         }
          }
         if(emptyPureWater_Manage.UpdateDate_IsChanged)
         {
         if (emptyPureWater_Manage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", emptyPureWater_Manage.UpdateDate);
         }
          }
         if(emptyPureWater_Manage.DeleteDate_IsChanged)
         {
         if (emptyPureWater_Manage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", emptyPureWater_Manage.DeleteDate);
         }
          }
         if(emptyPureWater_Manage.EPW_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Company))
         {
            idb.AddParameter("@EPW_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Company", emptyPureWater_Manage.EPW_Company);
         }
          }
         if(emptyPureWater_Manage.EPW_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(emptyPureWater_Manage.EPW_Dept))
         {
            idb.AddParameter("@EPW_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EPW_Dept", emptyPureWater_Manage.EPW_Dept);
         }
          }

         idb.AddParameter("@EPW_ID", emptyPureWater_Manage.EPW_ID);

           
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
      /// 删除纯净水空桶管理 EmptyPureWater_Manage对象(即:一条记录
      /// </summary>
      public int Delete(decimal ePW_ID)
      {
         string sql = "DELETE EmptyPureWater_Manage WHERE 1=1  AND EPW_ID=@EPW_ID ";
         idb.AddParameter("@EPW_ID", ePW_ID);

           
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
      /// 获取指定的纯净水空桶管理 EmptyPureWater_Manage对象(即:一条记录
      /// </summary>
      public EmptyPureWater_Manage GetByKey(decimal ePW_ID)
      {
         EmptyPureWater_Manage emptyPureWater_Manage = new EmptyPureWater_Manage();
         string sql = "SELECT  EPW_ID,EPW_Code,EPW_Duty,EPW_EmptyPosition,EPW_Count,EPW_Remark,Stat,CreateDate,UpdateDate,DeleteDate,EPW_Company,EPW_Dept FROM EmptyPureWater_Manage WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EPW_ID=@EPW_ID ";
         idb.AddParameter("@EPW_ID", ePW_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EPW_ID"] != DBNull.Value) emptyPureWater_Manage.EPW_ID = Convert.ToDecimal(dr["EPW_ID"]);
            if (dr["EPW_Code"] != DBNull.Value) emptyPureWater_Manage.EPW_Code = Convert.ToString(dr["EPW_Code"]);
            if (dr["EPW_Duty"] != DBNull.Value) emptyPureWater_Manage.EPW_Duty = Convert.ToString(dr["EPW_Duty"]);
            if (dr["EPW_EmptyPosition"] != DBNull.Value) emptyPureWater_Manage.EPW_EmptyPosition = Convert.ToString(dr["EPW_EmptyPosition"]);
            if (dr["EPW_Count"] != DBNull.Value) emptyPureWater_Manage.EPW_Count = Convert.ToInt32(dr["EPW_Count"]);
            if (dr["EPW_Remark"] != DBNull.Value) emptyPureWater_Manage.EPW_Remark = Convert.ToString(dr["EPW_Remark"]);
            if (dr["Stat"] != DBNull.Value) emptyPureWater_Manage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) emptyPureWater_Manage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) emptyPureWater_Manage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) emptyPureWater_Manage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["EPW_Company"] != DBNull.Value) emptyPureWater_Manage.EPW_Company = Convert.ToString(dr["EPW_Company"]);
            if (dr["EPW_Dept"] != DBNull.Value) emptyPureWater_Manage.EPW_Dept = Convert.ToString(dr["EPW_Dept"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return emptyPureWater_Manage;
      }
      /// <summary>
      /// 获取指定的纯净水空桶管理 EmptyPureWater_Manage对象集合
      /// </summary>
      public List<EmptyPureWater_Manage> GetListByWhere(string strCondition)
      {
         List<EmptyPureWater_Manage> ret = new List<EmptyPureWater_Manage>();
         string sql = "SELECT  EPW_ID,EPW_Code,EPW_Duty,EPW_EmptyPosition,EPW_Count,EPW_Remark,Stat,CreateDate,UpdateDate,DeleteDate,EPW_Company,EPW_Dept FROM EmptyPureWater_Manage WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            EmptyPureWater_Manage emptyPureWater_Manage = new EmptyPureWater_Manage();
            if (dr["EPW_ID"] != DBNull.Value) emptyPureWater_Manage.EPW_ID = Convert.ToDecimal(dr["EPW_ID"]);
            if (dr["EPW_Code"] != DBNull.Value) emptyPureWater_Manage.EPW_Code = Convert.ToString(dr["EPW_Code"]);
            if (dr["EPW_Duty"] != DBNull.Value) emptyPureWater_Manage.EPW_Duty = Convert.ToString(dr["EPW_Duty"]);
            if (dr["EPW_EmptyPosition"] != DBNull.Value) emptyPureWater_Manage.EPW_EmptyPosition = Convert.ToString(dr["EPW_EmptyPosition"]);
            if (dr["EPW_Count"] != DBNull.Value) emptyPureWater_Manage.EPW_Count = Convert.ToInt32(dr["EPW_Count"]);
            if (dr["EPW_Remark"] != DBNull.Value) emptyPureWater_Manage.EPW_Remark = Convert.ToString(dr["EPW_Remark"]);
            if (dr["Stat"] != DBNull.Value) emptyPureWater_Manage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) emptyPureWater_Manage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) emptyPureWater_Manage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) emptyPureWater_Manage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["EPW_Company"] != DBNull.Value) emptyPureWater_Manage.EPW_Company = Convert.ToString(dr["EPW_Company"]);
            if (dr["EPW_Dept"] != DBNull.Value) emptyPureWater_Manage.EPW_Dept = Convert.ToString(dr["EPW_Dept"]);
            ret.Add(emptyPureWater_Manage);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的纯净水空桶管理 EmptyPureWater_Manage对象(即:一条记录
      /// </summary>
      public List<EmptyPureWater_Manage> GetAll()
      {
         List<EmptyPureWater_Manage> ret = new List<EmptyPureWater_Manage>();
         string sql = "SELECT  EPW_ID,EPW_Code,EPW_Duty,EPW_EmptyPosition,EPW_Count,EPW_Remark,Stat,CreateDate,UpdateDate,DeleteDate,EPW_Company,EPW_Dept FROM EmptyPureWater_Manage where 1=1 AND ((Stat is null) or (Stat=0) ) order by EPW_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            EmptyPureWater_Manage emptyPureWater_Manage = new EmptyPureWater_Manage();
            if (dr["EPW_ID"] != DBNull.Value) emptyPureWater_Manage.EPW_ID = Convert.ToDecimal(dr["EPW_ID"]);
            if (dr["EPW_Code"] != DBNull.Value) emptyPureWater_Manage.EPW_Code = Convert.ToString(dr["EPW_Code"]);
            if (dr["EPW_Duty"] != DBNull.Value) emptyPureWater_Manage.EPW_Duty = Convert.ToString(dr["EPW_Duty"]);
            if (dr["EPW_EmptyPosition"] != DBNull.Value) emptyPureWater_Manage.EPW_EmptyPosition = Convert.ToString(dr["EPW_EmptyPosition"]);
            if (dr["EPW_Count"] != DBNull.Value) emptyPureWater_Manage.EPW_Count = Convert.ToInt32(dr["EPW_Count"]);
            if (dr["EPW_Remark"] != DBNull.Value) emptyPureWater_Manage.EPW_Remark = Convert.ToString(dr["EPW_Remark"]);
            if (dr["Stat"] != DBNull.Value) emptyPureWater_Manage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) emptyPureWater_Manage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) emptyPureWater_Manage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) emptyPureWater_Manage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["EPW_Company"] != DBNull.Value) emptyPureWater_Manage.EPW_Company = Convert.ToString(dr["EPW_Company"]);
            if (dr["EPW_Dept"] != DBNull.Value) emptyPureWater_Manage.EPW_Dept = Convert.ToString(dr["EPW_Dept"]);
            ret.Add(emptyPureWater_Manage);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
