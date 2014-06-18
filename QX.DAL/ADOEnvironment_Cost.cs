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
   /// 环保费用记录
   /// </summary>
   [Serializable]
   public partial class ADOEnvironment_Cost
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加环保费用记录 Environment_Cost对象(即:一条记录)
      /// </summary>
      public int Add(Environment_Cost environment_Cost)
      {
         string sql = "INSERT INTO Environment_Cost (EP_Code,EP_Company,EP_Dept,EP_BeginDate,EP_EndDate,EP_CostName,EP_Cost,EP_Operator,EP_Auditor,EP_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@EP_Code,@EP_Company,@EP_Dept,@EP_BeginDate,@EP_EndDate,@EP_CostName,@EP_Cost,@EP_Operator,@EP_Auditor,@EP_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(environment_Cost.EP_Code))
         {
            idb.AddParameter("@EP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Code", environment_Cost.EP_Code);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Company))
         {
            idb.AddParameter("@EP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Company", environment_Cost.EP_Company);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Dept))
         {
            idb.AddParameter("@EP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Dept", environment_Cost.EP_Dept);
         }
         if (environment_Cost.EP_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@EP_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_BeginDate", environment_Cost.EP_BeginDate);
         }
         if (environment_Cost.EP_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@EP_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_EndDate", environment_Cost.EP_EndDate);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_CostName))
         {
            idb.AddParameter("@EP_CostName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_CostName", environment_Cost.EP_CostName);
         }
         if (environment_Cost.EP_Cost == 0)
         {
            idb.AddParameter("@EP_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Cost", environment_Cost.EP_Cost);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Operator))
         {
            idb.AddParameter("@EP_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Operator", environment_Cost.EP_Operator);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Auditor))
         {
            idb.AddParameter("@EP_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Auditor", environment_Cost.EP_Auditor);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Remark))
         {
            idb.AddParameter("@EP_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Remark", environment_Cost.EP_Remark);
         }
         if (environment_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", environment_Cost.Stat);
         }
         if (environment_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", environment_Cost.CreateDate);
         }
         if (environment_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", environment_Cost.UpdateDate);
         }
         if (environment_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", environment_Cost.DeleteDate);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加环保费用记录 Environment_Cost对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Environment_Cost environment_Cost)
      {
         string sql = "INSERT INTO Environment_Cost (EP_Code,EP_Company,EP_Dept,EP_BeginDate,EP_EndDate,EP_CostName,EP_Cost,EP_Operator,EP_Auditor,EP_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@EP_Code,@EP_Company,@EP_Dept,@EP_BeginDate,@EP_EndDate,@EP_CostName,@EP_Cost,@EP_Operator,@EP_Auditor,@EP_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(environment_Cost.EP_Code))
         {
            idb.AddParameter("@EP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Code", environment_Cost.EP_Code);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Company))
         {
            idb.AddParameter("@EP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Company", environment_Cost.EP_Company);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Dept))
         {
            idb.AddParameter("@EP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Dept", environment_Cost.EP_Dept);
         }
         if (environment_Cost.EP_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@EP_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_BeginDate", environment_Cost.EP_BeginDate);
         }
         if (environment_Cost.EP_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@EP_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_EndDate", environment_Cost.EP_EndDate);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_CostName))
         {
            idb.AddParameter("@EP_CostName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_CostName", environment_Cost.EP_CostName);
         }
         if (environment_Cost.EP_Cost == 0)
         {
            idb.AddParameter("@EP_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Cost", environment_Cost.EP_Cost);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Operator))
         {
            idb.AddParameter("@EP_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Operator", environment_Cost.EP_Operator);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Auditor))
         {
            idb.AddParameter("@EP_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Auditor", environment_Cost.EP_Auditor);
         }
         if (string.IsNullOrEmpty(environment_Cost.EP_Remark))
         {
            idb.AddParameter("@EP_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Remark", environment_Cost.EP_Remark);
         }
         if (environment_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", environment_Cost.Stat);
         }
         if (environment_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", environment_Cost.CreateDate);
         }
         if (environment_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", environment_Cost.UpdateDate);
         }
         if (environment_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", environment_Cost.DeleteDate);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 更新环保费用记录 Environment_Cost对象(即:一条记录
      /// </summary>
      public int Update(Environment_Cost environment_Cost)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Environment_Cost       SET ");
            if(environment_Cost.EP_Code_IsChanged){sbParameter.Append("EP_Code=@EP_Code, ");}
      if(environment_Cost.EP_Company_IsChanged){sbParameter.Append("EP_Company=@EP_Company, ");}
      if(environment_Cost.EP_Dept_IsChanged){sbParameter.Append("EP_Dept=@EP_Dept, ");}
      if(environment_Cost.EP_BeginDate_IsChanged){sbParameter.Append("EP_BeginDate=@EP_BeginDate, ");}
      if(environment_Cost.EP_EndDate_IsChanged){sbParameter.Append("EP_EndDate=@EP_EndDate, ");}
      if(environment_Cost.EP_CostName_IsChanged){sbParameter.Append("EP_CostName=@EP_CostName, ");}
      if(environment_Cost.EP_Cost_IsChanged){sbParameter.Append("EP_Cost=@EP_Cost, ");}
      if(environment_Cost.EP_Operator_IsChanged){sbParameter.Append("EP_Operator=@EP_Operator, ");}
      if(environment_Cost.EP_Auditor_IsChanged){sbParameter.Append("EP_Auditor=@EP_Auditor, ");}
      if(environment_Cost.EP_Remark_IsChanged){sbParameter.Append("EP_Remark=@EP_Remark, ");}
      if(environment_Cost.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(environment_Cost.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(environment_Cost.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(environment_Cost.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EP_ID=@EP_ID; " );
      string sql=sb.ToString();
         if(environment_Cost.EP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(environment_Cost.EP_Code))
         {
            idb.AddParameter("@EP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Code", environment_Cost.EP_Code);
         }
          }
         if(environment_Cost.EP_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(environment_Cost.EP_Company))
         {
            idb.AddParameter("@EP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Company", environment_Cost.EP_Company);
         }
          }
         if(environment_Cost.EP_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(environment_Cost.EP_Dept))
         {
            idb.AddParameter("@EP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Dept", environment_Cost.EP_Dept);
         }
          }
         if(environment_Cost.EP_BeginDate_IsChanged)
         {
         if (environment_Cost.EP_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@EP_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_BeginDate", environment_Cost.EP_BeginDate);
         }
          }
         if(environment_Cost.EP_EndDate_IsChanged)
         {
         if (environment_Cost.EP_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@EP_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_EndDate", environment_Cost.EP_EndDate);
         }
          }
         if(environment_Cost.EP_CostName_IsChanged)
         {
         if (string.IsNullOrEmpty(environment_Cost.EP_CostName))
         {
            idb.AddParameter("@EP_CostName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_CostName", environment_Cost.EP_CostName);
         }
          }
         if(environment_Cost.EP_Cost_IsChanged)
         {
         if (environment_Cost.EP_Cost == 0)
         {
            idb.AddParameter("@EP_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Cost", environment_Cost.EP_Cost);
         }
          }
         if(environment_Cost.EP_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(environment_Cost.EP_Operator))
         {
            idb.AddParameter("@EP_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Operator", environment_Cost.EP_Operator);
         }
          }
         if(environment_Cost.EP_Auditor_IsChanged)
         {
         if (string.IsNullOrEmpty(environment_Cost.EP_Auditor))
         {
            idb.AddParameter("@EP_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Auditor", environment_Cost.EP_Auditor);
         }
          }
         if(environment_Cost.EP_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(environment_Cost.EP_Remark))
         {
            idb.AddParameter("@EP_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EP_Remark", environment_Cost.EP_Remark);
         }
          }
         if(environment_Cost.Stat_IsChanged)
         {
         if (environment_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", environment_Cost.Stat);
         }
          }
         if(environment_Cost.CreateDate_IsChanged)
         {
         if (environment_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", environment_Cost.CreateDate);
         }
          }
         if(environment_Cost.UpdateDate_IsChanged)
         {
         if (environment_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", environment_Cost.UpdateDate);
         }
          }
         if(environment_Cost.DeleteDate_IsChanged)
         {
         if (environment_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", environment_Cost.DeleteDate);
         }
          }

         idb.AddParameter("@EP_ID", environment_Cost.EP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除环保费用记录 Environment_Cost对象(即:一条记录
      /// </summary>
      public int Delete(decimal eP_ID)
      {
         string sql = "DELETE Environment_Cost WHERE 1=1  AND EP_ID=@EP_ID ";
         idb.AddParameter("@EP_ID", eP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的环保费用记录 Environment_Cost对象(即:一条记录
      /// </summary>
      public Environment_Cost GetByKey(decimal eP_ID)
      {
         Environment_Cost environment_Cost = new Environment_Cost();
         string sql = "SELECT  EP_ID,EP_Code,EP_Company,EP_Dept,EP_BeginDate,EP_EndDate,EP_CostName,EP_Cost,EP_Operator,EP_Auditor,EP_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Environment_Cost WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EP_ID=@EP_ID ";
         idb.AddParameter("@EP_ID", eP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EP_ID"] != DBNull.Value) environment_Cost.EP_ID = Convert.ToDecimal(dr["EP_ID"]);
            if (dr["EP_Code"] != DBNull.Value) environment_Cost.EP_Code = Convert.ToString(dr["EP_Code"]);
            if (dr["EP_Company"] != DBNull.Value) environment_Cost.EP_Company = Convert.ToString(dr["EP_Company"]);
            if (dr["EP_Dept"] != DBNull.Value) environment_Cost.EP_Dept = Convert.ToString(dr["EP_Dept"]);
            if (dr["EP_BeginDate"] != DBNull.Value) environment_Cost.EP_BeginDate = Convert.ToDateTime(dr["EP_BeginDate"]);
            if (dr["EP_EndDate"] != DBNull.Value) environment_Cost.EP_EndDate = Convert.ToDateTime(dr["EP_EndDate"]);
            if (dr["EP_CostName"] != DBNull.Value) environment_Cost.EP_CostName = Convert.ToString(dr["EP_CostName"]);
            if (dr["EP_Cost"] != DBNull.Value) environment_Cost.EP_Cost = Convert.ToDecimal(dr["EP_Cost"]);
            if (dr["EP_Operator"] != DBNull.Value) environment_Cost.EP_Operator = Convert.ToString(dr["EP_Operator"]);
            if (dr["EP_Auditor"] != DBNull.Value) environment_Cost.EP_Auditor = Convert.ToString(dr["EP_Auditor"]);
            if (dr["EP_Remark"] != DBNull.Value) environment_Cost.EP_Remark = Convert.ToString(dr["EP_Remark"]);
            if (dr["Stat"] != DBNull.Value) environment_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) environment_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) environment_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) environment_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return environment_Cost;
      }
      /// <summary>
      /// 获取指定的环保费用记录 Environment_Cost对象集合
      /// </summary>
      public List<Environment_Cost> GetListByWhere(string strCondition)
      {
         List<Environment_Cost> ret = new List<Environment_Cost>();
         string sql = "SELECT  EP_ID,EP_Code,EP_Company,EP_Dept,EP_BeginDate,EP_EndDate,EP_CostName,EP_Cost,EP_Operator,EP_Auditor,EP_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Environment_Cost WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Environment_Cost environment_Cost = new Environment_Cost();
            if (dr["EP_ID"] != DBNull.Value) environment_Cost.EP_ID = Convert.ToDecimal(dr["EP_ID"]);
            if (dr["EP_Code"] != DBNull.Value) environment_Cost.EP_Code = Convert.ToString(dr["EP_Code"]);
            if (dr["EP_Company"] != DBNull.Value) environment_Cost.EP_Company = Convert.ToString(dr["EP_Company"]);
            if (dr["EP_Dept"] != DBNull.Value) environment_Cost.EP_Dept = Convert.ToString(dr["EP_Dept"]);
            if (dr["EP_BeginDate"] != DBNull.Value) environment_Cost.EP_BeginDate = Convert.ToDateTime(dr["EP_BeginDate"]);
            if (dr["EP_EndDate"] != DBNull.Value) environment_Cost.EP_EndDate = Convert.ToDateTime(dr["EP_EndDate"]);
            if (dr["EP_CostName"] != DBNull.Value) environment_Cost.EP_CostName = Convert.ToString(dr["EP_CostName"]);
            if (dr["EP_Cost"] != DBNull.Value) environment_Cost.EP_Cost = Convert.ToDecimal(dr["EP_Cost"]);
            if (dr["EP_Operator"] != DBNull.Value) environment_Cost.EP_Operator = Convert.ToString(dr["EP_Operator"]);
            if (dr["EP_Auditor"] != DBNull.Value) environment_Cost.EP_Auditor = Convert.ToString(dr["EP_Auditor"]);
            if (dr["EP_Remark"] != DBNull.Value) environment_Cost.EP_Remark = Convert.ToString(dr["EP_Remark"]);
            if (dr["Stat"] != DBNull.Value) environment_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) environment_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) environment_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) environment_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(environment_Cost);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的环保费用记录 Environment_Cost对象(即:一条记录
      /// </summary>
      public List<Environment_Cost> GetAll()
      {
         List<Environment_Cost> ret = new List<Environment_Cost>();
         string sql = "SELECT  EP_ID,EP_Code,EP_Company,EP_Dept,EP_BeginDate,EP_EndDate,EP_CostName,EP_Cost,EP_Operator,EP_Auditor,EP_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Environment_Cost where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Environment_Cost environment_Cost = new Environment_Cost();
            if (dr["EP_ID"] != DBNull.Value) environment_Cost.EP_ID = Convert.ToDecimal(dr["EP_ID"]);
            if (dr["EP_Code"] != DBNull.Value) environment_Cost.EP_Code = Convert.ToString(dr["EP_Code"]);
            if (dr["EP_Company"] != DBNull.Value) environment_Cost.EP_Company = Convert.ToString(dr["EP_Company"]);
            if (dr["EP_Dept"] != DBNull.Value) environment_Cost.EP_Dept = Convert.ToString(dr["EP_Dept"]);
            if (dr["EP_BeginDate"] != DBNull.Value) environment_Cost.EP_BeginDate = Convert.ToDateTime(dr["EP_BeginDate"]);
            if (dr["EP_EndDate"] != DBNull.Value) environment_Cost.EP_EndDate = Convert.ToDateTime(dr["EP_EndDate"]);
            if (dr["EP_CostName"] != DBNull.Value) environment_Cost.EP_CostName = Convert.ToString(dr["EP_CostName"]);
            if (dr["EP_Cost"] != DBNull.Value) environment_Cost.EP_Cost = Convert.ToDecimal(dr["EP_Cost"]);
            if (dr["EP_Operator"] != DBNull.Value) environment_Cost.EP_Operator = Convert.ToString(dr["EP_Operator"]);
            if (dr["EP_Auditor"] != DBNull.Value) environment_Cost.EP_Auditor = Convert.ToString(dr["EP_Auditor"]);
            if (dr["EP_Remark"] != DBNull.Value) environment_Cost.EP_Remark = Convert.ToString(dr["EP_Remark"]);
            if (dr["Stat"] != DBNull.Value) environment_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) environment_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) environment_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) environment_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(environment_Cost);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
