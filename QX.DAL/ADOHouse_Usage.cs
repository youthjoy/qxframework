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
   /// 租赁房屋使用明细
   /// </summary>
   [Serializable]
   public partial class ADOHouse_Usage
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加租赁房屋使用明细 House_Usage对象(即:一条记录)
      /// </summary>
      public int Add(House_Usage house_Usage)
      {
         string sql = "INSERT INTO House_Usage (HUsage_Code,HUsage_HRentalCode,HUsage_User,HUsage_Type,HUsage_BeginDate,HUsage_EndDate,HUsage_Company,HUsage_Dept,HUsage_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HUsage_Code,@HUsage_HRentalCode,@HUsage_User,@HUsage_Type,@HUsage_BeginDate,@HUsage_EndDate,@HUsage_Company,@HUsage_Dept,@HUsage_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(house_Usage.HUsage_Code))
         {
            idb.AddParameter("@HUsage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Code", house_Usage.HUsage_Code);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_HRentalCode))
         {
            idb.AddParameter("@HUsage_HRentalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_HRentalCode", house_Usage.HUsage_HRentalCode);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_User))
         {
            idb.AddParameter("@HUsage_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_User", house_Usage.HUsage_User);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Type))
         {
            idb.AddParameter("@HUsage_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Type", house_Usage.HUsage_Type);
         }
         if (house_Usage.HUsage_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HUsage_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_BeginDate", house_Usage.HUsage_BeginDate);
         }
         if (house_Usage.HUsage_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HUsage_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_EndDate", house_Usage.HUsage_EndDate);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Company))
         {
            idb.AddParameter("@HUsage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Company", house_Usage.HUsage_Company);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Dept))
         {
            idb.AddParameter("@HUsage_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Dept", house_Usage.HUsage_Dept);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Remark))
         {
            idb.AddParameter("@HUsage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Remark", house_Usage.HUsage_Remark);
         }
         if (house_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Usage.Stat);
         }
         if (house_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Usage.CreateDate);
         }
         if (house_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Usage.UpdateDate);
         }
         if (house_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Usage.DeleteDate);
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
      /// 添加租赁房屋使用明细 House_Usage对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(House_Usage house_Usage)
      {
         string sql = "INSERT INTO House_Usage (HUsage_Code,HUsage_HRentalCode,HUsage_User,HUsage_Type,HUsage_BeginDate,HUsage_EndDate,HUsage_Company,HUsage_Dept,HUsage_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HUsage_Code,@HUsage_HRentalCode,@HUsage_User,@HUsage_Type,@HUsage_BeginDate,@HUsage_EndDate,@HUsage_Company,@HUsage_Dept,@HUsage_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(house_Usage.HUsage_Code))
         {
            idb.AddParameter("@HUsage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Code", house_Usage.HUsage_Code);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_HRentalCode))
         {
            idb.AddParameter("@HUsage_HRentalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_HRentalCode", house_Usage.HUsage_HRentalCode);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_User))
         {
            idb.AddParameter("@HUsage_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_User", house_Usage.HUsage_User);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Type))
         {
            idb.AddParameter("@HUsage_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Type", house_Usage.HUsage_Type);
         }
         if (house_Usage.HUsage_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HUsage_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_BeginDate", house_Usage.HUsage_BeginDate);
         }
         if (house_Usage.HUsage_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HUsage_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_EndDate", house_Usage.HUsage_EndDate);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Company))
         {
            idb.AddParameter("@HUsage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Company", house_Usage.HUsage_Company);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Dept))
         {
            idb.AddParameter("@HUsage_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Dept", house_Usage.HUsage_Dept);
         }
         if (string.IsNullOrEmpty(house_Usage.HUsage_Remark))
         {
            idb.AddParameter("@HUsage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Remark", house_Usage.HUsage_Remark);
         }
         if (house_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Usage.Stat);
         }
         if (house_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Usage.CreateDate);
         }
         if (house_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Usage.UpdateDate);
         }
         if (house_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Usage.DeleteDate);
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
      /// 更新租赁房屋使用明细 House_Usage对象(即:一条记录
      /// </summary>
      public int Update(House_Usage house_Usage)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       House_Usage       SET ");
            if(house_Usage.HUsage_Code_IsChanged){sbParameter.Append("HUsage_Code=@HUsage_Code, ");}
      if(house_Usage.HUsage_HRentalCode_IsChanged){sbParameter.Append("HUsage_HRentalCode=@HUsage_HRentalCode, ");}
      if(house_Usage.HUsage_User_IsChanged){sbParameter.Append("HUsage_User=@HUsage_User, ");}
      if(house_Usage.HUsage_Type_IsChanged){sbParameter.Append("HUsage_Type=@HUsage_Type, ");}
      if(house_Usage.HUsage_BeginDate_IsChanged){sbParameter.Append("HUsage_BeginDate=@HUsage_BeginDate, ");}
      if(house_Usage.HUsage_EndDate_IsChanged){sbParameter.Append("HUsage_EndDate=@HUsage_EndDate, ");}
      if(house_Usage.HUsage_Company_IsChanged){sbParameter.Append("HUsage_Company=@HUsage_Company, ");}
      if(house_Usage.HUsage_Dept_IsChanged){sbParameter.Append("HUsage_Dept=@HUsage_Dept, ");}
      if(house_Usage.HUsage_Remark_IsChanged){sbParameter.Append("HUsage_Remark=@HUsage_Remark, ");}
      if(house_Usage.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(house_Usage.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(house_Usage.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(house_Usage.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and HUsage_ID=@HUsage_ID; " );
      string sql=sb.ToString();
         if(house_Usage.HUsage_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Usage.HUsage_Code))
         {
            idb.AddParameter("@HUsage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Code", house_Usage.HUsage_Code);
         }
          }
         if(house_Usage.HUsage_HRentalCode_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Usage.HUsage_HRentalCode))
         {
            idb.AddParameter("@HUsage_HRentalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_HRentalCode", house_Usage.HUsage_HRentalCode);
         }
          }
         if(house_Usage.HUsage_User_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Usage.HUsage_User))
         {
            idb.AddParameter("@HUsage_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_User", house_Usage.HUsage_User);
         }
          }
         if(house_Usage.HUsage_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Usage.HUsage_Type))
         {
            idb.AddParameter("@HUsage_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Type", house_Usage.HUsage_Type);
         }
          }
         if(house_Usage.HUsage_BeginDate_IsChanged)
         {
         if (house_Usage.HUsage_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HUsage_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_BeginDate", house_Usage.HUsage_BeginDate);
         }
          }
         if(house_Usage.HUsage_EndDate_IsChanged)
         {
         if (house_Usage.HUsage_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HUsage_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_EndDate", house_Usage.HUsage_EndDate);
         }
          }
         if(house_Usage.HUsage_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Usage.HUsage_Company))
         {
            idb.AddParameter("@HUsage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Company", house_Usage.HUsage_Company);
         }
          }
         if(house_Usage.HUsage_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Usage.HUsage_Dept))
         {
            idb.AddParameter("@HUsage_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Dept", house_Usage.HUsage_Dept);
         }
          }
         if(house_Usage.HUsage_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Usage.HUsage_Remark))
         {
            idb.AddParameter("@HUsage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HUsage_Remark", house_Usage.HUsage_Remark);
         }
          }
         if(house_Usage.Stat_IsChanged)
         {
         if (house_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Usage.Stat);
         }
          }
         if(house_Usage.CreateDate_IsChanged)
         {
         if (house_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Usage.CreateDate);
         }
          }
         if(house_Usage.UpdateDate_IsChanged)
         {
         if (house_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Usage.UpdateDate);
         }
          }
         if(house_Usage.DeleteDate_IsChanged)
         {
         if (house_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Usage.DeleteDate);
         }
          }

         idb.AddParameter("@HUsage_ID", house_Usage.HUsage_ID);

           
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
      /// 删除租赁房屋使用明细 House_Usage对象(即:一条记录
      /// </summary>
      public int Delete(decimal hUsage_ID)
      {
         string sql = "DELETE House_Usage WHERE 1=1  AND HUsage_ID=@HUsage_ID ";
         idb.AddParameter("@HUsage_ID", hUsage_ID);

           
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
      /// 获取指定的租赁房屋使用明细 House_Usage对象(即:一条记录
      /// </summary>
      public House_Usage GetByKey(decimal hUsage_ID)
      {
         House_Usage house_Usage = new House_Usage();
         string sql = "SELECT  HUsage_ID,HUsage_Code,HUsage_HRentalCode,HUsage_User,HUsage_Type,HUsage_BeginDate,HUsage_EndDate,HUsage_Company,HUsage_Dept,HUsage_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM House_Usage WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND HUsage_ID=@HUsage_ID ";
         idb.AddParameter("@HUsage_ID", hUsage_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["HUsage_ID"] != DBNull.Value) house_Usage.HUsage_ID = Convert.ToDecimal(dr["HUsage_ID"]);
            if (dr["HUsage_Code"] != DBNull.Value) house_Usage.HUsage_Code = Convert.ToString(dr["HUsage_Code"]);
            if (dr["HUsage_HRentalCode"] != DBNull.Value) house_Usage.HUsage_HRentalCode = Convert.ToString(dr["HUsage_HRentalCode"]);
            if (dr["HUsage_User"] != DBNull.Value) house_Usage.HUsage_User = Convert.ToString(dr["HUsage_User"]);
            if (dr["HUsage_Type"] != DBNull.Value) house_Usage.HUsage_Type = Convert.ToString(dr["HUsage_Type"]);
            if (dr["HUsage_BeginDate"] != DBNull.Value) house_Usage.HUsage_BeginDate = Convert.ToDateTime(dr["HUsage_BeginDate"]);
            if (dr["HUsage_EndDate"] != DBNull.Value) house_Usage.HUsage_EndDate = Convert.ToDateTime(dr["HUsage_EndDate"]);
            if (dr["HUsage_Company"] != DBNull.Value) house_Usage.HUsage_Company = Convert.ToString(dr["HUsage_Company"]);
            if (dr["HUsage_Dept"] != DBNull.Value) house_Usage.HUsage_Dept = Convert.ToString(dr["HUsage_Dept"]);
            if (dr["HUsage_Remark"] != DBNull.Value) house_Usage.HUsage_Remark = Convert.ToString(dr["HUsage_Remark"]);
            if (dr["Stat"] != DBNull.Value) house_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) house_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return house_Usage;
      }
      /// <summary>
      /// 获取指定的租赁房屋使用明细 House_Usage对象集合
      /// </summary>
      public List<House_Usage> GetListByWhere(string strCondition)
      {
         List<House_Usage> ret = new List<House_Usage>();
         string sql = "SELECT  HUsage_ID,HUsage_Code,HUsage_HRentalCode,HUsage_User,HUsage_Type,HUsage_BeginDate,HUsage_EndDate,HUsage_Company,HUsage_Dept,HUsage_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM House_Usage WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            House_Usage house_Usage = new House_Usage();
            if (dr["HUsage_ID"] != DBNull.Value) house_Usage.HUsage_ID = Convert.ToDecimal(dr["HUsage_ID"]);
            if (dr["HUsage_Code"] != DBNull.Value) house_Usage.HUsage_Code = Convert.ToString(dr["HUsage_Code"]);
            if (dr["HUsage_HRentalCode"] != DBNull.Value) house_Usage.HUsage_HRentalCode = Convert.ToString(dr["HUsage_HRentalCode"]);
            if (dr["HUsage_User"] != DBNull.Value) house_Usage.HUsage_User = Convert.ToString(dr["HUsage_User"]);
            if (dr["HUsage_Type"] != DBNull.Value) house_Usage.HUsage_Type = Convert.ToString(dr["HUsage_Type"]);
            if (dr["HUsage_BeginDate"] != DBNull.Value) house_Usage.HUsage_BeginDate = Convert.ToDateTime(dr["HUsage_BeginDate"]);
            if (dr["HUsage_EndDate"] != DBNull.Value) house_Usage.HUsage_EndDate = Convert.ToDateTime(dr["HUsage_EndDate"]);
            if (dr["HUsage_Company"] != DBNull.Value) house_Usage.HUsage_Company = Convert.ToString(dr["HUsage_Company"]);
            if (dr["HUsage_Dept"] != DBNull.Value) house_Usage.HUsage_Dept = Convert.ToString(dr["HUsage_Dept"]);
            if (dr["HUsage_Remark"] != DBNull.Value) house_Usage.HUsage_Remark = Convert.ToString(dr["HUsage_Remark"]);
            if (dr["Stat"] != DBNull.Value) house_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) house_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(house_Usage);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的租赁房屋使用明细 House_Usage对象(即:一条记录
      /// </summary>
      public List<House_Usage> GetAll()
      {
         List<House_Usage> ret = new List<House_Usage>();
         string sql = "SELECT  HUsage_ID,HUsage_Code,HUsage_HRentalCode,HUsage_User,HUsage_Type,HUsage_BeginDate,HUsage_EndDate,HUsage_Company,HUsage_Dept,HUsage_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM House_Usage where 1=1 AND ((Stat is null) or (Stat=0) ) order by HUsage_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            House_Usage house_Usage = new House_Usage();
            if (dr["HUsage_ID"] != DBNull.Value) house_Usage.HUsage_ID = Convert.ToDecimal(dr["HUsage_ID"]);
            if (dr["HUsage_Code"] != DBNull.Value) house_Usage.HUsage_Code = Convert.ToString(dr["HUsage_Code"]);
            if (dr["HUsage_HRentalCode"] != DBNull.Value) house_Usage.HUsage_HRentalCode = Convert.ToString(dr["HUsage_HRentalCode"]);
            if (dr["HUsage_User"] != DBNull.Value) house_Usage.HUsage_User = Convert.ToString(dr["HUsage_User"]);
            if (dr["HUsage_Type"] != DBNull.Value) house_Usage.HUsage_Type = Convert.ToString(dr["HUsage_Type"]);
            if (dr["HUsage_BeginDate"] != DBNull.Value) house_Usage.HUsage_BeginDate = Convert.ToDateTime(dr["HUsage_BeginDate"]);
            if (dr["HUsage_EndDate"] != DBNull.Value) house_Usage.HUsage_EndDate = Convert.ToDateTime(dr["HUsage_EndDate"]);
            if (dr["HUsage_Company"] != DBNull.Value) house_Usage.HUsage_Company = Convert.ToString(dr["HUsage_Company"]);
            if (dr["HUsage_Dept"] != DBNull.Value) house_Usage.HUsage_Dept = Convert.ToString(dr["HUsage_Dept"]);
            if (dr["HUsage_Remark"] != DBNull.Value) house_Usage.HUsage_Remark = Convert.ToString(dr["HUsage_Remark"]);
            if (dr["Stat"] != DBNull.Value) house_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) house_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(house_Usage);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
