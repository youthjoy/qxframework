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
   /// 出差报销管理
   /// </summary>
   [Serializable]
   public partial class ADOTravel_Reimbursement
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加出差报销管理 Travel_Reimbursement对象(即:一条记录)
      /// </summary>
      public int Add(Travel_Reimbursement travel_Reimbursement)
      {
         string sql = "INSERT INTO Travel_Reimbursement (Reimbursement_Code,Reimbursement_TravelCode,Reimbursement_Name,Reimbursement_Abstract,Reimbursement_Cost,Reimbursement_ApplicantCode,Reimbursement__ApplicantName,Reimbursement_Dept,Reimbursement_Company,Reimbursement_Stat,Reimbursement_AuditStat,Reimbursement_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Reimbursement_Code,@Reimbursement_TravelCode,@Reimbursement_Name,@Reimbursement_Abstract,@Reimbursement_Cost,@Reimbursement_ApplicantCode,@Reimbursement__ApplicantName,@Reimbursement_Dept,@Reimbursement_Company,@Reimbursement_Stat,@Reimbursement_AuditStat,@Reimbursement_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Code))
         {
            idb.AddParameter("@Reimbursement_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Code", travel_Reimbursement.Reimbursement_Code);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_TravelCode))
         {
            idb.AddParameter("@Reimbursement_TravelCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_TravelCode", travel_Reimbursement.Reimbursement_TravelCode);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Name))
         {
            idb.AddParameter("@Reimbursement_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Name", travel_Reimbursement.Reimbursement_Name);
         }
         if (travel_Reimbursement.Reimbursement_Abstract == 0)
         {
            idb.AddParameter("@Reimbursement_Abstract", 0);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Abstract", travel_Reimbursement.Reimbursement_Abstract);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Cost))
         {
            idb.AddParameter("@Reimbursement_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Cost", travel_Reimbursement.Reimbursement_Cost);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_ApplicantCode))
         {
            idb.AddParameter("@Reimbursement_ApplicantCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_ApplicantCode", travel_Reimbursement.Reimbursement_ApplicantCode);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement__ApplicantName))
         {
            idb.AddParameter("@Reimbursement__ApplicantName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement__ApplicantName", travel_Reimbursement.Reimbursement__ApplicantName);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Dept))
         {
            idb.AddParameter("@Reimbursement_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Dept", travel_Reimbursement.Reimbursement_Dept);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Company))
         {
            idb.AddParameter("@Reimbursement_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Company", travel_Reimbursement.Reimbursement_Company);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Stat))
         {
            idb.AddParameter("@Reimbursement_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Stat", travel_Reimbursement.Reimbursement_Stat);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_AuditStat))
         {
            idb.AddParameter("@Reimbursement_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_AuditStat", travel_Reimbursement.Reimbursement_AuditStat);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Remark))
         {
            idb.AddParameter("@Reimbursement_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Remark", travel_Reimbursement.Reimbursement_Remark);
         }
         if (travel_Reimbursement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", travel_Reimbursement.Stat);
         }
         if (travel_Reimbursement.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", travel_Reimbursement.CreateDate);
         }
         if (travel_Reimbursement.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", travel_Reimbursement.UpdateDate);
         }
         if (travel_Reimbursement.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", travel_Reimbursement.DeleteDate);
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
      /// 添加出差报销管理 Travel_Reimbursement对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Travel_Reimbursement travel_Reimbursement)
      {
         string sql = "INSERT INTO Travel_Reimbursement (Reimbursement_Code,Reimbursement_TravelCode,Reimbursement_Name,Reimbursement_Abstract,Reimbursement_Cost,Reimbursement_ApplicantCode,Reimbursement__ApplicantName,Reimbursement_Dept,Reimbursement_Company,Reimbursement_Stat,Reimbursement_AuditStat,Reimbursement_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Reimbursement_Code,@Reimbursement_TravelCode,@Reimbursement_Name,@Reimbursement_Abstract,@Reimbursement_Cost,@Reimbursement_ApplicantCode,@Reimbursement__ApplicantName,@Reimbursement_Dept,@Reimbursement_Company,@Reimbursement_Stat,@Reimbursement_AuditStat,@Reimbursement_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Code))
         {
            idb.AddParameter("@Reimbursement_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Code", travel_Reimbursement.Reimbursement_Code);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_TravelCode))
         {
            idb.AddParameter("@Reimbursement_TravelCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_TravelCode", travel_Reimbursement.Reimbursement_TravelCode);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Name))
         {
            idb.AddParameter("@Reimbursement_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Name", travel_Reimbursement.Reimbursement_Name);
         }
         if (travel_Reimbursement.Reimbursement_Abstract == 0)
         {
            idb.AddParameter("@Reimbursement_Abstract", 0);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Abstract", travel_Reimbursement.Reimbursement_Abstract);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Cost))
         {
            idb.AddParameter("@Reimbursement_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Cost", travel_Reimbursement.Reimbursement_Cost);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_ApplicantCode))
         {
            idb.AddParameter("@Reimbursement_ApplicantCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_ApplicantCode", travel_Reimbursement.Reimbursement_ApplicantCode);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement__ApplicantName))
         {
            idb.AddParameter("@Reimbursement__ApplicantName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement__ApplicantName", travel_Reimbursement.Reimbursement__ApplicantName);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Dept))
         {
            idb.AddParameter("@Reimbursement_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Dept", travel_Reimbursement.Reimbursement_Dept);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Company))
         {
            idb.AddParameter("@Reimbursement_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Company", travel_Reimbursement.Reimbursement_Company);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Stat))
         {
            idb.AddParameter("@Reimbursement_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Stat", travel_Reimbursement.Reimbursement_Stat);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_AuditStat))
         {
            idb.AddParameter("@Reimbursement_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_AuditStat", travel_Reimbursement.Reimbursement_AuditStat);
         }
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Remark))
         {
            idb.AddParameter("@Reimbursement_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Remark", travel_Reimbursement.Reimbursement_Remark);
         }
         if (travel_Reimbursement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", travel_Reimbursement.Stat);
         }
         if (travel_Reimbursement.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", travel_Reimbursement.CreateDate);
         }
         if (travel_Reimbursement.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", travel_Reimbursement.UpdateDate);
         }
         if (travel_Reimbursement.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", travel_Reimbursement.DeleteDate);
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
      /// 更新出差报销管理 Travel_Reimbursement对象(即:一条记录
      /// </summary>
      public int Update(Travel_Reimbursement travel_Reimbursement)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Travel_Reimbursement       SET ");
            if(travel_Reimbursement.Reimbursement_Code_IsChanged){sbParameter.Append("Reimbursement_Code=@Reimbursement_Code, ");}
      if(travel_Reimbursement.Reimbursement_TravelCode_IsChanged){sbParameter.Append("Reimbursement_TravelCode=@Reimbursement_TravelCode, ");}
      if(travel_Reimbursement.Reimbursement_Name_IsChanged){sbParameter.Append("Reimbursement_Name=@Reimbursement_Name, ");}
      if(travel_Reimbursement.Reimbursement_Abstract_IsChanged){sbParameter.Append("Reimbursement_Abstract=@Reimbursement_Abstract, ");}
      if(travel_Reimbursement.Reimbursement_Cost_IsChanged){sbParameter.Append("Reimbursement_Cost=@Reimbursement_Cost, ");}
      if(travel_Reimbursement.Reimbursement_ApplicantCode_IsChanged){sbParameter.Append("Reimbursement_ApplicantCode=@Reimbursement_ApplicantCode, ");}
      if(travel_Reimbursement.Reimbursement__ApplicantName_IsChanged){sbParameter.Append("Reimbursement__ApplicantName=@Reimbursement__ApplicantName, ");}
      if(travel_Reimbursement.Reimbursement_Dept_IsChanged){sbParameter.Append("Reimbursement_Dept=@Reimbursement_Dept, ");}
      if(travel_Reimbursement.Reimbursement_Company_IsChanged){sbParameter.Append("Reimbursement_Company=@Reimbursement_Company, ");}
      if(travel_Reimbursement.Reimbursement_Stat_IsChanged){sbParameter.Append("Reimbursement_Stat=@Reimbursement_Stat, ");}
      if(travel_Reimbursement.Reimbursement_AuditStat_IsChanged){sbParameter.Append("Reimbursement_AuditStat=@Reimbursement_AuditStat, ");}
      if(travel_Reimbursement.Reimbursement_Remark_IsChanged){sbParameter.Append("Reimbursement_Remark=@Reimbursement_Remark, ");}
      if(travel_Reimbursement.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(travel_Reimbursement.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(travel_Reimbursement.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(travel_Reimbursement.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Reimbursement_ID=@Reimbursement_ID; " );
      string sql=sb.ToString();
         if(travel_Reimbursement.Reimbursement_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Code))
         {
            idb.AddParameter("@Reimbursement_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Code", travel_Reimbursement.Reimbursement_Code);
         }
          }
         if(travel_Reimbursement.Reimbursement_TravelCode_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_TravelCode))
         {
            idb.AddParameter("@Reimbursement_TravelCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_TravelCode", travel_Reimbursement.Reimbursement_TravelCode);
         }
          }
         if(travel_Reimbursement.Reimbursement_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Name))
         {
            idb.AddParameter("@Reimbursement_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Name", travel_Reimbursement.Reimbursement_Name);
         }
          }
         if(travel_Reimbursement.Reimbursement_Abstract_IsChanged)
         {
         if (travel_Reimbursement.Reimbursement_Abstract == 0)
         {
            idb.AddParameter("@Reimbursement_Abstract", 0);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Abstract", travel_Reimbursement.Reimbursement_Abstract);
         }
          }
         if(travel_Reimbursement.Reimbursement_Cost_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Cost))
         {
            idb.AddParameter("@Reimbursement_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Cost", travel_Reimbursement.Reimbursement_Cost);
         }
          }
         if(travel_Reimbursement.Reimbursement_ApplicantCode_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_ApplicantCode))
         {
            idb.AddParameter("@Reimbursement_ApplicantCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_ApplicantCode", travel_Reimbursement.Reimbursement_ApplicantCode);
         }
          }
         if(travel_Reimbursement.Reimbursement__ApplicantName_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement__ApplicantName))
         {
            idb.AddParameter("@Reimbursement__ApplicantName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement__ApplicantName", travel_Reimbursement.Reimbursement__ApplicantName);
         }
          }
         if(travel_Reimbursement.Reimbursement_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Dept))
         {
            idb.AddParameter("@Reimbursement_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Dept", travel_Reimbursement.Reimbursement_Dept);
         }
          }
         if(travel_Reimbursement.Reimbursement_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Company))
         {
            idb.AddParameter("@Reimbursement_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Company", travel_Reimbursement.Reimbursement_Company);
         }
          }
         if(travel_Reimbursement.Reimbursement_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Stat))
         {
            idb.AddParameter("@Reimbursement_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Stat", travel_Reimbursement.Reimbursement_Stat);
         }
          }
         if(travel_Reimbursement.Reimbursement_AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_AuditStat))
         {
            idb.AddParameter("@Reimbursement_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_AuditStat", travel_Reimbursement.Reimbursement_AuditStat);
         }
          }
         if(travel_Reimbursement.Reimbursement_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Reimbursement.Reimbursement_Remark))
         {
            idb.AddParameter("@Reimbursement_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Reimbursement_Remark", travel_Reimbursement.Reimbursement_Remark);
         }
          }
         if(travel_Reimbursement.Stat_IsChanged)
         {
         if (travel_Reimbursement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", travel_Reimbursement.Stat);
         }
          }
         if(travel_Reimbursement.CreateDate_IsChanged)
         {
         if (travel_Reimbursement.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", travel_Reimbursement.CreateDate);
         }
          }
         if(travel_Reimbursement.UpdateDate_IsChanged)
         {
         if (travel_Reimbursement.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", travel_Reimbursement.UpdateDate);
         }
          }
         if(travel_Reimbursement.DeleteDate_IsChanged)
         {
         if (travel_Reimbursement.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", travel_Reimbursement.DeleteDate);
         }
          }

         idb.AddParameter("@Reimbursement_ID", travel_Reimbursement.Reimbursement_ID);

           
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
      /// 删除出差报销管理 Travel_Reimbursement对象(即:一条记录
      /// </summary>
      public int Delete(decimal reimbursement_ID)
      {
         string sql = "DELETE Travel_Reimbursement WHERE 1=1  AND Reimbursement_ID=@Reimbursement_ID ";
         idb.AddParameter("@Reimbursement_ID", reimbursement_ID);

           
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
      /// 获取指定的出差报销管理 Travel_Reimbursement对象(即:一条记录
      /// </summary>
      public Travel_Reimbursement GetByKey(decimal reimbursement_ID)
      {
         Travel_Reimbursement travel_Reimbursement = new Travel_Reimbursement();
         string sql = "SELECT  Reimbursement_ID,Reimbursement_Code,Reimbursement_TravelCode,Reimbursement_Name,Reimbursement_Abstract,Reimbursement_Cost,Reimbursement_ApplicantCode,Reimbursement__ApplicantName,Reimbursement_Dept,Reimbursement_Company,Reimbursement_Stat,Reimbursement_AuditStat,Reimbursement_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Travel_Reimbursement WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Reimbursement_ID=@Reimbursement_ID ";
         idb.AddParameter("@Reimbursement_ID", reimbursement_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Reimbursement_ID"] != DBNull.Value) travel_Reimbursement.Reimbursement_ID = Convert.ToDecimal(dr["Reimbursement_ID"]);
            if (dr["Reimbursement_Code"] != DBNull.Value) travel_Reimbursement.Reimbursement_Code = Convert.ToString(dr["Reimbursement_Code"]);
            if (dr["Reimbursement_TravelCode"] != DBNull.Value) travel_Reimbursement.Reimbursement_TravelCode = Convert.ToString(dr["Reimbursement_TravelCode"]);
            if (dr["Reimbursement_Name"] != DBNull.Value) travel_Reimbursement.Reimbursement_Name = Convert.ToString(dr["Reimbursement_Name"]);
            if (dr["Reimbursement_Abstract"] != DBNull.Value) travel_Reimbursement.Reimbursement_Abstract = Convert.ToDecimal(dr["Reimbursement_Abstract"]);
            if (dr["Reimbursement_Cost"] != DBNull.Value) travel_Reimbursement.Reimbursement_Cost = Convert.ToString(dr["Reimbursement_Cost"]);
            if (dr["Reimbursement_ApplicantCode"] != DBNull.Value) travel_Reimbursement.Reimbursement_ApplicantCode = Convert.ToString(dr["Reimbursement_ApplicantCode"]);
            if (dr["Reimbursement__ApplicantName"] != DBNull.Value) travel_Reimbursement.Reimbursement__ApplicantName = Convert.ToString(dr["Reimbursement__ApplicantName"]);
            if (dr["Reimbursement_Dept"] != DBNull.Value) travel_Reimbursement.Reimbursement_Dept = Convert.ToString(dr["Reimbursement_Dept"]);
            if (dr["Reimbursement_Company"] != DBNull.Value) travel_Reimbursement.Reimbursement_Company = Convert.ToString(dr["Reimbursement_Company"]);
            if (dr["Reimbursement_Stat"] != DBNull.Value) travel_Reimbursement.Reimbursement_Stat = Convert.ToString(dr["Reimbursement_Stat"]);
            if (dr["Reimbursement_AuditStat"] != DBNull.Value) travel_Reimbursement.Reimbursement_AuditStat = Convert.ToString(dr["Reimbursement_AuditStat"]);
            if (dr["Reimbursement_Remark"] != DBNull.Value) travel_Reimbursement.Reimbursement_Remark = Convert.ToString(dr["Reimbursement_Remark"]);
            if (dr["Stat"] != DBNull.Value) travel_Reimbursement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) travel_Reimbursement.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) travel_Reimbursement.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) travel_Reimbursement.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return travel_Reimbursement;
      }
      /// <summary>
      /// 获取指定的出差报销管理 Travel_Reimbursement对象集合
      /// </summary>
      public List<Travel_Reimbursement> GetListByWhere(string strCondition)
      {
         List<Travel_Reimbursement> ret = new List<Travel_Reimbursement>();
         string sql = "SELECT  Reimbursement_ID,Reimbursement_Code,Reimbursement_TravelCode,Reimbursement_Name,Reimbursement_Abstract,Reimbursement_Cost,Reimbursement_ApplicantCode,Reimbursement__ApplicantName,Reimbursement_Dept,Reimbursement_Company,Reimbursement_Stat,Reimbursement_AuditStat,Reimbursement_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Travel_Reimbursement WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Travel_Reimbursement travel_Reimbursement = new Travel_Reimbursement();
            if (dr["Reimbursement_ID"] != DBNull.Value) travel_Reimbursement.Reimbursement_ID = Convert.ToDecimal(dr["Reimbursement_ID"]);
            if (dr["Reimbursement_Code"] != DBNull.Value) travel_Reimbursement.Reimbursement_Code = Convert.ToString(dr["Reimbursement_Code"]);
            if (dr["Reimbursement_TravelCode"] != DBNull.Value) travel_Reimbursement.Reimbursement_TravelCode = Convert.ToString(dr["Reimbursement_TravelCode"]);
            if (dr["Reimbursement_Name"] != DBNull.Value) travel_Reimbursement.Reimbursement_Name = Convert.ToString(dr["Reimbursement_Name"]);
            if (dr["Reimbursement_Abstract"] != DBNull.Value) travel_Reimbursement.Reimbursement_Abstract = Convert.ToDecimal(dr["Reimbursement_Abstract"]);
            if (dr["Reimbursement_Cost"] != DBNull.Value) travel_Reimbursement.Reimbursement_Cost = Convert.ToString(dr["Reimbursement_Cost"]);
            if (dr["Reimbursement_ApplicantCode"] != DBNull.Value) travel_Reimbursement.Reimbursement_ApplicantCode = Convert.ToString(dr["Reimbursement_ApplicantCode"]);
            if (dr["Reimbursement__ApplicantName"] != DBNull.Value) travel_Reimbursement.Reimbursement__ApplicantName = Convert.ToString(dr["Reimbursement__ApplicantName"]);
            if (dr["Reimbursement_Dept"] != DBNull.Value) travel_Reimbursement.Reimbursement_Dept = Convert.ToString(dr["Reimbursement_Dept"]);
            if (dr["Reimbursement_Company"] != DBNull.Value) travel_Reimbursement.Reimbursement_Company = Convert.ToString(dr["Reimbursement_Company"]);
            if (dr["Reimbursement_Stat"] != DBNull.Value) travel_Reimbursement.Reimbursement_Stat = Convert.ToString(dr["Reimbursement_Stat"]);
            if (dr["Reimbursement_AuditStat"] != DBNull.Value) travel_Reimbursement.Reimbursement_AuditStat = Convert.ToString(dr["Reimbursement_AuditStat"]);
            if (dr["Reimbursement_Remark"] != DBNull.Value) travel_Reimbursement.Reimbursement_Remark = Convert.ToString(dr["Reimbursement_Remark"]);
            if (dr["Stat"] != DBNull.Value) travel_Reimbursement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) travel_Reimbursement.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) travel_Reimbursement.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) travel_Reimbursement.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(travel_Reimbursement);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的出差报销管理 Travel_Reimbursement对象(即:一条记录
      /// </summary>
      public List<Travel_Reimbursement> GetAll()
      {
         List<Travel_Reimbursement> ret = new List<Travel_Reimbursement>();
         string sql = "SELECT  Reimbursement_ID,Reimbursement_Code,Reimbursement_TravelCode,Reimbursement_Name,Reimbursement_Abstract,Reimbursement_Cost,Reimbursement_ApplicantCode,Reimbursement__ApplicantName,Reimbursement_Dept,Reimbursement_Company,Reimbursement_Stat,Reimbursement_AuditStat,Reimbursement_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Travel_Reimbursement where 1=1 AND ((Stat is null) or (Stat=0) ) order by Reimbursement_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Travel_Reimbursement travel_Reimbursement = new Travel_Reimbursement();
            if (dr["Reimbursement_ID"] != DBNull.Value) travel_Reimbursement.Reimbursement_ID = Convert.ToDecimal(dr["Reimbursement_ID"]);
            if (dr["Reimbursement_Code"] != DBNull.Value) travel_Reimbursement.Reimbursement_Code = Convert.ToString(dr["Reimbursement_Code"]);
            if (dr["Reimbursement_TravelCode"] != DBNull.Value) travel_Reimbursement.Reimbursement_TravelCode = Convert.ToString(dr["Reimbursement_TravelCode"]);
            if (dr["Reimbursement_Name"] != DBNull.Value) travel_Reimbursement.Reimbursement_Name = Convert.ToString(dr["Reimbursement_Name"]);
            if (dr["Reimbursement_Abstract"] != DBNull.Value) travel_Reimbursement.Reimbursement_Abstract = Convert.ToDecimal(dr["Reimbursement_Abstract"]);
            if (dr["Reimbursement_Cost"] != DBNull.Value) travel_Reimbursement.Reimbursement_Cost = Convert.ToString(dr["Reimbursement_Cost"]);
            if (dr["Reimbursement_ApplicantCode"] != DBNull.Value) travel_Reimbursement.Reimbursement_ApplicantCode = Convert.ToString(dr["Reimbursement_ApplicantCode"]);
            if (dr["Reimbursement__ApplicantName"] != DBNull.Value) travel_Reimbursement.Reimbursement__ApplicantName = Convert.ToString(dr["Reimbursement__ApplicantName"]);
            if (dr["Reimbursement_Dept"] != DBNull.Value) travel_Reimbursement.Reimbursement_Dept = Convert.ToString(dr["Reimbursement_Dept"]);
            if (dr["Reimbursement_Company"] != DBNull.Value) travel_Reimbursement.Reimbursement_Company = Convert.ToString(dr["Reimbursement_Company"]);
            if (dr["Reimbursement_Stat"] != DBNull.Value) travel_Reimbursement.Reimbursement_Stat = Convert.ToString(dr["Reimbursement_Stat"]);
            if (dr["Reimbursement_AuditStat"] != DBNull.Value) travel_Reimbursement.Reimbursement_AuditStat = Convert.ToString(dr["Reimbursement_AuditStat"]);
            if (dr["Reimbursement_Remark"] != DBNull.Value) travel_Reimbursement.Reimbursement_Remark = Convert.ToString(dr["Reimbursement_Remark"]);
            if (dr["Stat"] != DBNull.Value) travel_Reimbursement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) travel_Reimbursement.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) travel_Reimbursement.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) travel_Reimbursement.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(travel_Reimbursement);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
