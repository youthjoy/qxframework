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
   /// 公司物料类别
   /// </summary>
   [Serializable]
   public partial class ADOWH_MaterialType
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加公司物料类别 WH_MaterialType对象(即:一条记录)
      /// </summary>
      public int Add(WH_MaterialType wH_MaterialType)
      {
         string sql = "INSERT INTO WH_MaterialType (MT_Code,MT_TCode,MT_TName,MT_Company,MT_CompanyCode,MT_Dept,MT_DeptCode,Stat,MT_Status,CreateDate,UpdateDate,DeleteDate,MT_Itype,MT_Type,MT_Employee,MT_EmployeeName,MT_TPCode,MT_Order) VALUES (@MT_Code,@MT_TCode,@MT_TName,@MT_Company,@MT_CompanyCode,@MT_Dept,@MT_DeptCode,@Stat,@MT_Status,@CreateDate,@UpdateDate,@DeleteDate,@MT_Itype,@MT_Type,@MT_Employee,@MT_EmployeeName,@MT_TPCode,@MT_Order)";
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Code))
         {
            idb.AddParameter("@MT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Code", wH_MaterialType.MT_Code);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TCode))
         {
            idb.AddParameter("@MT_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TCode", wH_MaterialType.MT_TCode);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TName))
         {
            idb.AddParameter("@MT_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TName", wH_MaterialType.MT_TName);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Company))
         {
            idb.AddParameter("@MT_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Company", wH_MaterialType.MT_Company);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_CompanyCode))
         {
            idb.AddParameter("@MT_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_CompanyCode", wH_MaterialType.MT_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Dept))
         {
            idb.AddParameter("@MT_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Dept", wH_MaterialType.MT_Dept);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_DeptCode))
         {
            idb.AddParameter("@MT_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_DeptCode", wH_MaterialType.MT_DeptCode);
         }
         if (wH_MaterialType.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_MaterialType.Stat);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Status))
         {
            idb.AddParameter("@MT_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Status", wH_MaterialType.MT_Status);
         }
         if (wH_MaterialType.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_MaterialType.CreateDate);
         }
         if (wH_MaterialType.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_MaterialType.UpdateDate);
         }
         if (wH_MaterialType.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_MaterialType.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Itype))
         {
            idb.AddParameter("@MT_Itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Itype", wH_MaterialType.MT_Itype);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Type))
         {
            idb.AddParameter("@MT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Type", wH_MaterialType.MT_Type);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Employee))
         {
            idb.AddParameter("@MT_Employee", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Employee", wH_MaterialType.MT_Employee);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_EmployeeName))
         {
            idb.AddParameter("@MT_EmployeeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_EmployeeName", wH_MaterialType.MT_EmployeeName);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TPCode))
         {
            idb.AddParameter("@MT_TPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TPCode", wH_MaterialType.MT_TPCode);
         }
         if (wH_MaterialType.MT_Order == 0)
         {
            idb.AddParameter("@MT_Order", 0);
         }
         else
         {
            idb.AddParameter("@MT_Order", wH_MaterialType.MT_Order);
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
      /// 添加公司物料类别 WH_MaterialType对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_MaterialType wH_MaterialType)
      {
         string sql = "INSERT INTO WH_MaterialType (MT_Code,MT_TCode,MT_TName,MT_Company,MT_CompanyCode,MT_Dept,MT_DeptCode,Stat,MT_Status,CreateDate,UpdateDate,DeleteDate,MT_Itype,MT_Type,MT_Employee,MT_EmployeeName,MT_TPCode,MT_Order) VALUES (@MT_Code,@MT_TCode,@MT_TName,@MT_Company,@MT_CompanyCode,@MT_Dept,@MT_DeptCode,@Stat,@MT_Status,@CreateDate,@UpdateDate,@DeleteDate,@MT_Itype,@MT_Type,@MT_Employee,@MT_EmployeeName,@MT_TPCode,@MT_Order);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Code))
         {
            idb.AddParameter("@MT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Code", wH_MaterialType.MT_Code);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TCode))
         {
            idb.AddParameter("@MT_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TCode", wH_MaterialType.MT_TCode);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TName))
         {
            idb.AddParameter("@MT_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TName", wH_MaterialType.MT_TName);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Company))
         {
            idb.AddParameter("@MT_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Company", wH_MaterialType.MT_Company);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_CompanyCode))
         {
            idb.AddParameter("@MT_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_CompanyCode", wH_MaterialType.MT_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Dept))
         {
            idb.AddParameter("@MT_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Dept", wH_MaterialType.MT_Dept);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_DeptCode))
         {
            idb.AddParameter("@MT_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_DeptCode", wH_MaterialType.MT_DeptCode);
         }
         if (wH_MaterialType.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_MaterialType.Stat);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Status))
         {
            idb.AddParameter("@MT_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Status", wH_MaterialType.MT_Status);
         }
         if (wH_MaterialType.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_MaterialType.CreateDate);
         }
         if (wH_MaterialType.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_MaterialType.UpdateDate);
         }
         if (wH_MaterialType.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_MaterialType.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Itype))
         {
            idb.AddParameter("@MT_Itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Itype", wH_MaterialType.MT_Itype);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Type))
         {
            idb.AddParameter("@MT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Type", wH_MaterialType.MT_Type);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Employee))
         {
            idb.AddParameter("@MT_Employee", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Employee", wH_MaterialType.MT_Employee);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_EmployeeName))
         {
            idb.AddParameter("@MT_EmployeeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_EmployeeName", wH_MaterialType.MT_EmployeeName);
         }
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TPCode))
         {
            idb.AddParameter("@MT_TPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TPCode", wH_MaterialType.MT_TPCode);
         }
         if (wH_MaterialType.MT_Order == 0)
         {
            idb.AddParameter("@MT_Order", 0);
         }
         else
         {
            idb.AddParameter("@MT_Order", wH_MaterialType.MT_Order);
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
      /// 更新公司物料类别 WH_MaterialType对象(即:一条记录
      /// </summary>
      public int Update(WH_MaterialType wH_MaterialType)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_MaterialType       SET ");
            if(wH_MaterialType.MT_Code_IsChanged){sbParameter.Append("MT_Code=@MT_Code, ");}
      if(wH_MaterialType.MT_TCode_IsChanged){sbParameter.Append("MT_TCode=@MT_TCode, ");}
      if(wH_MaterialType.MT_TName_IsChanged){sbParameter.Append("MT_TName=@MT_TName, ");}
      if(wH_MaterialType.MT_Company_IsChanged){sbParameter.Append("MT_Company=@MT_Company, ");}
      if(wH_MaterialType.MT_CompanyCode_IsChanged){sbParameter.Append("MT_CompanyCode=@MT_CompanyCode, ");}
      if(wH_MaterialType.MT_Dept_IsChanged){sbParameter.Append("MT_Dept=@MT_Dept, ");}
      if(wH_MaterialType.MT_DeptCode_IsChanged){sbParameter.Append("MT_DeptCode=@MT_DeptCode, ");}
      if(wH_MaterialType.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_MaterialType.MT_Status_IsChanged){sbParameter.Append("MT_Status=@MT_Status, ");}
      if(wH_MaterialType.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_MaterialType.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_MaterialType.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_MaterialType.MT_Itype_IsChanged){sbParameter.Append("MT_Itype=@MT_Itype, ");}
      if(wH_MaterialType.MT_Type_IsChanged){sbParameter.Append("MT_Type=@MT_Type, ");}
      if(wH_MaterialType.MT_Employee_IsChanged){sbParameter.Append("MT_Employee=@MT_Employee, ");}
      if(wH_MaterialType.MT_EmployeeName_IsChanged){sbParameter.Append("MT_EmployeeName=@MT_EmployeeName, ");}
      if(wH_MaterialType.MT_TPCode_IsChanged){sbParameter.Append("MT_TPCode=@MT_TPCode, ");}
      if(wH_MaterialType.MT_Order_IsChanged){sbParameter.Append("MT_Order=@MT_Order ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MT_ID=@MT_ID; " );
      string sql=sb.ToString();
         if(wH_MaterialType.MT_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Code))
         {
            idb.AddParameter("@MT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Code", wH_MaterialType.MT_Code);
         }
          }
         if(wH_MaterialType.MT_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TCode))
         {
            idb.AddParameter("@MT_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TCode", wH_MaterialType.MT_TCode);
         }
          }
         if(wH_MaterialType.MT_TName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TName))
         {
            idb.AddParameter("@MT_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TName", wH_MaterialType.MT_TName);
         }
          }
         if(wH_MaterialType.MT_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Company))
         {
            idb.AddParameter("@MT_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Company", wH_MaterialType.MT_Company);
         }
          }
         if(wH_MaterialType.MT_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_CompanyCode))
         {
            idb.AddParameter("@MT_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_CompanyCode", wH_MaterialType.MT_CompanyCode);
         }
          }
         if(wH_MaterialType.MT_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Dept))
         {
            idb.AddParameter("@MT_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Dept", wH_MaterialType.MT_Dept);
         }
          }
         if(wH_MaterialType.MT_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_DeptCode))
         {
            idb.AddParameter("@MT_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_DeptCode", wH_MaterialType.MT_DeptCode);
         }
          }
         if(wH_MaterialType.Stat_IsChanged)
         {
         if (wH_MaterialType.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_MaterialType.Stat);
         }
          }
         if(wH_MaterialType.MT_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Status))
         {
            idb.AddParameter("@MT_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Status", wH_MaterialType.MT_Status);
         }
          }
         if(wH_MaterialType.CreateDate_IsChanged)
         {
         if (wH_MaterialType.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_MaterialType.CreateDate);
         }
          }
         if(wH_MaterialType.UpdateDate_IsChanged)
         {
         if (wH_MaterialType.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_MaterialType.UpdateDate);
         }
          }
         if(wH_MaterialType.DeleteDate_IsChanged)
         {
         if (wH_MaterialType.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_MaterialType.DeleteDate);
         }
          }
         if(wH_MaterialType.MT_Itype_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Itype))
         {
            idb.AddParameter("@MT_Itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Itype", wH_MaterialType.MT_Itype);
         }
          }
         if(wH_MaterialType.MT_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Type))
         {
            idb.AddParameter("@MT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Type", wH_MaterialType.MT_Type);
         }
          }
         if(wH_MaterialType.MT_Employee_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_Employee))
         {
            idb.AddParameter("@MT_Employee", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_Employee", wH_MaterialType.MT_Employee);
         }
          }
         if(wH_MaterialType.MT_EmployeeName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_EmployeeName))
         {
            idb.AddParameter("@MT_EmployeeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_EmployeeName", wH_MaterialType.MT_EmployeeName);
         }
          }
         if(wH_MaterialType.MT_TPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MaterialType.MT_TPCode))
         {
            idb.AddParameter("@MT_TPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MT_TPCode", wH_MaterialType.MT_TPCode);
         }
          }
         if(wH_MaterialType.MT_Order_IsChanged)
         {
         if (wH_MaterialType.MT_Order == 0)
         {
            idb.AddParameter("@MT_Order", 0);
         }
         else
         {
            idb.AddParameter("@MT_Order", wH_MaterialType.MT_Order);
         }
          }

         idb.AddParameter("@MT_ID", wH_MaterialType.MT_ID);

           
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
      /// 删除公司物料类别 WH_MaterialType对象(即:一条记录
      /// </summary>
      public int Delete(decimal mT_ID)
      {
         string sql = "DELETE WH_MaterialType WHERE 1=1  AND MT_ID=@MT_ID ";
         idb.AddParameter("@MT_ID", mT_ID);

           
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
      /// 获取指定的公司物料类别 WH_MaterialType对象(即:一条记录
      /// </summary>
      public WH_MaterialType GetByKey(decimal mT_ID)
      {
         WH_MaterialType wH_MaterialType = new WH_MaterialType();
         string sql = "SELECT  MT_ID,MT_Code,MT_TCode,MT_TName,MT_Company,MT_CompanyCode,MT_Dept,MT_DeptCode,Stat,MT_Status,CreateDate,UpdateDate,DeleteDate,MT_Itype,MT_Type,MT_Employee,MT_EmployeeName,MT_TPCode,MT_Order FROM WH_MaterialType WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MT_ID=@MT_ID ";
         idb.AddParameter("@MT_ID", mT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MT_ID"] != DBNull.Value) wH_MaterialType.MT_ID = Convert.ToDecimal(dr["MT_ID"]);
            if (dr["MT_Code"] != DBNull.Value) wH_MaterialType.MT_Code = Convert.ToString(dr["MT_Code"]);
            if (dr["MT_TCode"] != DBNull.Value) wH_MaterialType.MT_TCode = Convert.ToString(dr["MT_TCode"]);
            if (dr["MT_TName"] != DBNull.Value) wH_MaterialType.MT_TName = Convert.ToString(dr["MT_TName"]);
            if (dr["MT_Company"] != DBNull.Value) wH_MaterialType.MT_Company = Convert.ToString(dr["MT_Company"]);
            if (dr["MT_CompanyCode"] != DBNull.Value) wH_MaterialType.MT_CompanyCode = Convert.ToString(dr["MT_CompanyCode"]);
            if (dr["MT_Dept"] != DBNull.Value) wH_MaterialType.MT_Dept = Convert.ToString(dr["MT_Dept"]);
            if (dr["MT_DeptCode"] != DBNull.Value) wH_MaterialType.MT_DeptCode = Convert.ToString(dr["MT_DeptCode"]);
            if (dr["Stat"] != DBNull.Value) wH_MaterialType.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MT_Status"] != DBNull.Value) wH_MaterialType.MT_Status = Convert.ToString(dr["MT_Status"]);
            if (dr["CreateDate"] != DBNull.Value) wH_MaterialType.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_MaterialType.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_MaterialType.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MT_Itype"] != DBNull.Value) wH_MaterialType.MT_Itype = Convert.ToString(dr["MT_Itype"]);
            if (dr["MT_Type"] != DBNull.Value) wH_MaterialType.MT_Type = Convert.ToString(dr["MT_Type"]);
            if (dr["MT_Employee"] != DBNull.Value) wH_MaterialType.MT_Employee = Convert.ToString(dr["MT_Employee"]);
            if (dr["MT_EmployeeName"] != DBNull.Value) wH_MaterialType.MT_EmployeeName = Convert.ToString(dr["MT_EmployeeName"]);
            if (dr["MT_TPCode"] != DBNull.Value) wH_MaterialType.MT_TPCode = Convert.ToString(dr["MT_TPCode"]);
            if (dr["MT_Order"] != DBNull.Value) wH_MaterialType.MT_Order = Convert.ToInt32(dr["MT_Order"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_MaterialType;
      }
      /// <summary>
      /// 获取指定的公司物料类别 WH_MaterialType对象集合
      /// </summary>
      public List<WH_MaterialType> GetListByWhere(string strCondition)
      {
         List<WH_MaterialType> ret = new List<WH_MaterialType>();
         string sql = "SELECT  MT_ID,MT_Code,MT_TCode,MT_TName,MT_Company,MT_CompanyCode,MT_Dept,MT_DeptCode,Stat,MT_Status,CreateDate,UpdateDate,DeleteDate,MT_Itype,MT_Type,MT_Employee,MT_EmployeeName,MT_TPCode,MT_Order FROM WH_MaterialType WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_MaterialType wH_MaterialType = new WH_MaterialType();
            if (dr["MT_ID"] != DBNull.Value) wH_MaterialType.MT_ID = Convert.ToDecimal(dr["MT_ID"]);
            if (dr["MT_Code"] != DBNull.Value) wH_MaterialType.MT_Code = Convert.ToString(dr["MT_Code"]);
            if (dr["MT_TCode"] != DBNull.Value) wH_MaterialType.MT_TCode = Convert.ToString(dr["MT_TCode"]);
            if (dr["MT_TName"] != DBNull.Value) wH_MaterialType.MT_TName = Convert.ToString(dr["MT_TName"]);
            if (dr["MT_Company"] != DBNull.Value) wH_MaterialType.MT_Company = Convert.ToString(dr["MT_Company"]);
            if (dr["MT_CompanyCode"] != DBNull.Value) wH_MaterialType.MT_CompanyCode = Convert.ToString(dr["MT_CompanyCode"]);
            if (dr["MT_Dept"] != DBNull.Value) wH_MaterialType.MT_Dept = Convert.ToString(dr["MT_Dept"]);
            if (dr["MT_DeptCode"] != DBNull.Value) wH_MaterialType.MT_DeptCode = Convert.ToString(dr["MT_DeptCode"]);
            if (dr["Stat"] != DBNull.Value) wH_MaterialType.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MT_Status"] != DBNull.Value) wH_MaterialType.MT_Status = Convert.ToString(dr["MT_Status"]);
            if (dr["CreateDate"] != DBNull.Value) wH_MaterialType.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_MaterialType.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_MaterialType.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MT_Itype"] != DBNull.Value) wH_MaterialType.MT_Itype = Convert.ToString(dr["MT_Itype"]);
            if (dr["MT_Type"] != DBNull.Value) wH_MaterialType.MT_Type = Convert.ToString(dr["MT_Type"]);
            if (dr["MT_Employee"] != DBNull.Value) wH_MaterialType.MT_Employee = Convert.ToString(dr["MT_Employee"]);
            if (dr["MT_EmployeeName"] != DBNull.Value) wH_MaterialType.MT_EmployeeName = Convert.ToString(dr["MT_EmployeeName"]);
            if (dr["MT_TPCode"] != DBNull.Value) wH_MaterialType.MT_TPCode = Convert.ToString(dr["MT_TPCode"]);
            if (dr["MT_Order"] != DBNull.Value) wH_MaterialType.MT_Order = Convert.ToInt32(dr["MT_Order"]);
            ret.Add(wH_MaterialType);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的公司物料类别 WH_MaterialType对象(即:一条记录
      /// </summary>
      public List<WH_MaterialType> GetAll()
      {
         List<WH_MaterialType> ret = new List<WH_MaterialType>();
         string sql = "SELECT  MT_ID,MT_Code,MT_TCode,MT_TName,MT_Company,MT_CompanyCode,MT_Dept,MT_DeptCode,Stat,MT_Status,CreateDate,UpdateDate,DeleteDate,MT_Itype,MT_Type,MT_Employee,MT_EmployeeName,MT_TPCode,MT_Order FROM WH_MaterialType where 1=1 AND ((Stat is null) or (Stat=0) ) order by MT_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_MaterialType wH_MaterialType = new WH_MaterialType();
            if (dr["MT_ID"] != DBNull.Value) wH_MaterialType.MT_ID = Convert.ToDecimal(dr["MT_ID"]);
            if (dr["MT_Code"] != DBNull.Value) wH_MaterialType.MT_Code = Convert.ToString(dr["MT_Code"]);
            if (dr["MT_TCode"] != DBNull.Value) wH_MaterialType.MT_TCode = Convert.ToString(dr["MT_TCode"]);
            if (dr["MT_TName"] != DBNull.Value) wH_MaterialType.MT_TName = Convert.ToString(dr["MT_TName"]);
            if (dr["MT_Company"] != DBNull.Value) wH_MaterialType.MT_Company = Convert.ToString(dr["MT_Company"]);
            if (dr["MT_CompanyCode"] != DBNull.Value) wH_MaterialType.MT_CompanyCode = Convert.ToString(dr["MT_CompanyCode"]);
            if (dr["MT_Dept"] != DBNull.Value) wH_MaterialType.MT_Dept = Convert.ToString(dr["MT_Dept"]);
            if (dr["MT_DeptCode"] != DBNull.Value) wH_MaterialType.MT_DeptCode = Convert.ToString(dr["MT_DeptCode"]);
            if (dr["Stat"] != DBNull.Value) wH_MaterialType.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MT_Status"] != DBNull.Value) wH_MaterialType.MT_Status = Convert.ToString(dr["MT_Status"]);
            if (dr["CreateDate"] != DBNull.Value) wH_MaterialType.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_MaterialType.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_MaterialType.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MT_Itype"] != DBNull.Value) wH_MaterialType.MT_Itype = Convert.ToString(dr["MT_Itype"]);
            if (dr["MT_Type"] != DBNull.Value) wH_MaterialType.MT_Type = Convert.ToString(dr["MT_Type"]);
            if (dr["MT_Employee"] != DBNull.Value) wH_MaterialType.MT_Employee = Convert.ToString(dr["MT_Employee"]);
            if (dr["MT_EmployeeName"] != DBNull.Value) wH_MaterialType.MT_EmployeeName = Convert.ToString(dr["MT_EmployeeName"]);
            if (dr["MT_TPCode"] != DBNull.Value) wH_MaterialType.MT_TPCode = Convert.ToString(dr["MT_TPCode"]);
            if (dr["MT_Order"] != DBNull.Value) wH_MaterialType.MT_Order = Convert.ToInt32(dr["MT_Order"]);
            ret.Add(wH_MaterialType);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
