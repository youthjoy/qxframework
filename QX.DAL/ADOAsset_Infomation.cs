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
   /// 固定资产信息表
   /// </summary>
   [Serializable]
   public partial class ADOAsset_Infomation
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加固定资产信息表 Asset_Infomation对象(即:一条记录)
      /// </summary>
      public int Add(Asset_Infomation asset_Infomation)
      {
         string sql = "INSERT INTO Asset_Infomation (AInfo_Code,AInfo_Name,AInfo_Spec,AInfo_Tech,AInfo_TAttach,AInfo_RefComp,AInfo_Manu,AInfo_Price,AInfo_BuyDate,AInfo_PDate,AInfo_SCode,AInfo_CCode,AInfo_Type,AInfo_Type_Temp,AInfo_iType,AInfo_CompanyCode,AInfo_Company,AInfo_DepartmentCode,AInfo_Department,AInfo_Status,AInfo_UCompanyCode,AInfo_UCompany,AInfo_UDepartmentCode,AInfo_UDepartment,AInfo_UOwnerCode,AInfo_UOwner,AInfo_UStart,Stat,CreateDate,UpdateDate,DeleteDate,AInfo_Unit,AInfo_BOwnerCode,AInfo_BOwner,AInfo_Value,AInfo_Addr) VALUES (@AInfo_Code,@AInfo_Name,@AInfo_Spec,@AInfo_Tech,@AInfo_TAttach,@AInfo_RefComp,@AInfo_Manu,@AInfo_Price,@AInfo_BuyDate,@AInfo_PDate,@AInfo_SCode,@AInfo_CCode,@AInfo_Type,@AInfo_Type_Temp,@AInfo_iType,@AInfo_CompanyCode,@AInfo_Company,@AInfo_DepartmentCode,@AInfo_Department,@AInfo_Status,@AInfo_UCompanyCode,@AInfo_UCompany,@AInfo_UDepartmentCode,@AInfo_UDepartment,@AInfo_UOwnerCode,@AInfo_UOwner,@AInfo_UStart,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AInfo_Unit,@AInfo_BOwnerCode,@AInfo_BOwner,@AInfo_Value,@AInfo_Addr)";
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Code))
         {
            idb.AddParameter("@AInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Code", asset_Infomation.AInfo_Code);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Name))
         {
            idb.AddParameter("@AInfo_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Name", asset_Infomation.AInfo_Name);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Spec))
         {
            idb.AddParameter("@AInfo_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Spec", asset_Infomation.AInfo_Spec);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Tech))
         {
            idb.AddParameter("@AInfo_Tech", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Tech", asset_Infomation.AInfo_Tech);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_TAttach))
         {
            idb.AddParameter("@AInfo_TAttach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_TAttach", asset_Infomation.AInfo_TAttach);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_RefComp))
         {
            idb.AddParameter("@AInfo_RefComp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_RefComp", asset_Infomation.AInfo_RefComp);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Manu))
         {
            idb.AddParameter("@AInfo_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Manu", asset_Infomation.AInfo_Manu);
         }
         if (asset_Infomation.AInfo_Price == 0)
         {
            idb.AddParameter("@AInfo_Price", 0);
         }
         else
         {
            idb.AddParameter("@AInfo_Price", asset_Infomation.AInfo_Price);
         }
         if (asset_Infomation.AInfo_BuyDate == DateTime.MinValue)
         {
            idb.AddParameter("@AInfo_BuyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BuyDate", asset_Infomation.AInfo_BuyDate);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_PDate))
         {
            idb.AddParameter("@AInfo_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_PDate", asset_Infomation.AInfo_PDate);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_SCode))
         {
            idb.AddParameter("@AInfo_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_SCode", asset_Infomation.AInfo_SCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_CCode))
         {
            idb.AddParameter("@AInfo_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_CCode", asset_Infomation.AInfo_CCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Type))
         {
            idb.AddParameter("@AInfo_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Type", asset_Infomation.AInfo_Type);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Type_Temp))
         {
            idb.AddParameter("@AInfo_Type_Temp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Type_Temp", asset_Infomation.AInfo_Type_Temp);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_iType))
         {
            idb.AddParameter("@AInfo_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_iType", asset_Infomation.AInfo_iType);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_CompanyCode))
         {
            idb.AddParameter("@AInfo_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_CompanyCode", asset_Infomation.AInfo_CompanyCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Company))
         {
            idb.AddParameter("@AInfo_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Company", asset_Infomation.AInfo_Company);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_DepartmentCode))
         {
            idb.AddParameter("@AInfo_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_DepartmentCode", asset_Infomation.AInfo_DepartmentCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Department))
         {
            idb.AddParameter("@AInfo_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Department", asset_Infomation.AInfo_Department);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Status))
         {
            idb.AddParameter("@AInfo_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Status", asset_Infomation.AInfo_Status);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UCompanyCode))
         {
            idb.AddParameter("@AInfo_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UCompanyCode", asset_Infomation.AInfo_UCompanyCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UCompany))
         {
            idb.AddParameter("@AInfo_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UCompany", asset_Infomation.AInfo_UCompany);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UDepartmentCode))
         {
            idb.AddParameter("@AInfo_UDepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UDepartmentCode", asset_Infomation.AInfo_UDepartmentCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UDepartment))
         {
            idb.AddParameter("@AInfo_UDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UDepartment", asset_Infomation.AInfo_UDepartment);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UOwnerCode))
         {
            idb.AddParameter("@AInfo_UOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UOwnerCode", asset_Infomation.AInfo_UOwnerCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UOwner))
         {
            idb.AddParameter("@AInfo_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UOwner", asset_Infomation.AInfo_UOwner);
         }
         if (asset_Infomation.AInfo_UStart == DateTime.MinValue)
         {
            idb.AddParameter("@AInfo_UStart", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UStart", asset_Infomation.AInfo_UStart);
         }
         if (asset_Infomation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_Infomation.Stat);
         }
         if (asset_Infomation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_Infomation.CreateDate);
         }
         if (asset_Infomation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_Infomation.UpdateDate);
         }
         if (asset_Infomation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_Infomation.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Unit))
         {
            idb.AddParameter("@AInfo_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Unit", asset_Infomation.AInfo_Unit);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_BOwnerCode))
         {
            idb.AddParameter("@AInfo_BOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BOwnerCode", asset_Infomation.AInfo_BOwnerCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_BOwner))
         {
            idb.AddParameter("@AInfo_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BOwner", asset_Infomation.AInfo_BOwner);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Value))
         {
            idb.AddParameter("@AInfo_Value", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Value", asset_Infomation.AInfo_Value);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Addr))
         {
            idb.AddParameter("@AInfo_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Addr", asset_Infomation.AInfo_Addr);
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
      /// 添加固定资产信息表 Asset_Infomation对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Asset_Infomation asset_Infomation)
      {
         string sql = "INSERT INTO Asset_Infomation (AInfo_Code,AInfo_Name,AInfo_Spec,AInfo_Tech,AInfo_TAttach,AInfo_RefComp,AInfo_Manu,AInfo_Price,AInfo_BuyDate,AInfo_PDate,AInfo_SCode,AInfo_CCode,AInfo_Type,AInfo_Type_Temp,AInfo_iType,AInfo_CompanyCode,AInfo_Company,AInfo_DepartmentCode,AInfo_Department,AInfo_Status,AInfo_UCompanyCode,AInfo_UCompany,AInfo_UDepartmentCode,AInfo_UDepartment,AInfo_UOwnerCode,AInfo_UOwner,AInfo_UStart,Stat,CreateDate,UpdateDate,DeleteDate,AInfo_Unit,AInfo_BOwnerCode,AInfo_BOwner,AInfo_Value,AInfo_Addr) VALUES (@AInfo_Code,@AInfo_Name,@AInfo_Spec,@AInfo_Tech,@AInfo_TAttach,@AInfo_RefComp,@AInfo_Manu,@AInfo_Price,@AInfo_BuyDate,@AInfo_PDate,@AInfo_SCode,@AInfo_CCode,@AInfo_Type,@AInfo_Type_Temp,@AInfo_iType,@AInfo_CompanyCode,@AInfo_Company,@AInfo_DepartmentCode,@AInfo_Department,@AInfo_Status,@AInfo_UCompanyCode,@AInfo_UCompany,@AInfo_UDepartmentCode,@AInfo_UDepartment,@AInfo_UOwnerCode,@AInfo_UOwner,@AInfo_UStart,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AInfo_Unit,@AInfo_BOwnerCode,@AInfo_BOwner,@AInfo_Value,@AInfo_Addr);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Code))
         {
            idb.AddParameter("@AInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Code", asset_Infomation.AInfo_Code);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Name))
         {
            idb.AddParameter("@AInfo_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Name", asset_Infomation.AInfo_Name);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Spec))
         {
            idb.AddParameter("@AInfo_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Spec", asset_Infomation.AInfo_Spec);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Tech))
         {
            idb.AddParameter("@AInfo_Tech", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Tech", asset_Infomation.AInfo_Tech);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_TAttach))
         {
            idb.AddParameter("@AInfo_TAttach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_TAttach", asset_Infomation.AInfo_TAttach);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_RefComp))
         {
            idb.AddParameter("@AInfo_RefComp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_RefComp", asset_Infomation.AInfo_RefComp);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Manu))
         {
            idb.AddParameter("@AInfo_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Manu", asset_Infomation.AInfo_Manu);
         }
         if (asset_Infomation.AInfo_Price == 0)
         {
            idb.AddParameter("@AInfo_Price", 0);
         }
         else
         {
            idb.AddParameter("@AInfo_Price", asset_Infomation.AInfo_Price);
         }
         if (asset_Infomation.AInfo_BuyDate == DateTime.MinValue)
         {
            idb.AddParameter("@AInfo_BuyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BuyDate", asset_Infomation.AInfo_BuyDate);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_PDate))
         {
            idb.AddParameter("@AInfo_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_PDate", asset_Infomation.AInfo_PDate);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_SCode))
         {
            idb.AddParameter("@AInfo_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_SCode", asset_Infomation.AInfo_SCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_CCode))
         {
            idb.AddParameter("@AInfo_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_CCode", asset_Infomation.AInfo_CCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Type))
         {
            idb.AddParameter("@AInfo_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Type", asset_Infomation.AInfo_Type);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Type_Temp))
         {
            idb.AddParameter("@AInfo_Type_Temp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Type_Temp", asset_Infomation.AInfo_Type_Temp);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_iType))
         {
            idb.AddParameter("@AInfo_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_iType", asset_Infomation.AInfo_iType);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_CompanyCode))
         {
            idb.AddParameter("@AInfo_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_CompanyCode", asset_Infomation.AInfo_CompanyCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Company))
         {
            idb.AddParameter("@AInfo_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Company", asset_Infomation.AInfo_Company);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_DepartmentCode))
         {
            idb.AddParameter("@AInfo_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_DepartmentCode", asset_Infomation.AInfo_DepartmentCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Department))
         {
            idb.AddParameter("@AInfo_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Department", asset_Infomation.AInfo_Department);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Status))
         {
            idb.AddParameter("@AInfo_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Status", asset_Infomation.AInfo_Status);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UCompanyCode))
         {
            idb.AddParameter("@AInfo_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UCompanyCode", asset_Infomation.AInfo_UCompanyCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UCompany))
         {
            idb.AddParameter("@AInfo_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UCompany", asset_Infomation.AInfo_UCompany);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UDepartmentCode))
         {
            idb.AddParameter("@AInfo_UDepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UDepartmentCode", asset_Infomation.AInfo_UDepartmentCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UDepartment))
         {
            idb.AddParameter("@AInfo_UDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UDepartment", asset_Infomation.AInfo_UDepartment);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UOwnerCode))
         {
            idb.AddParameter("@AInfo_UOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UOwnerCode", asset_Infomation.AInfo_UOwnerCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UOwner))
         {
            idb.AddParameter("@AInfo_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UOwner", asset_Infomation.AInfo_UOwner);
         }
         if (asset_Infomation.AInfo_UStart == DateTime.MinValue)
         {
            idb.AddParameter("@AInfo_UStart", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UStart", asset_Infomation.AInfo_UStart);
         }
         if (asset_Infomation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_Infomation.Stat);
         }
         if (asset_Infomation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_Infomation.CreateDate);
         }
         if (asset_Infomation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_Infomation.UpdateDate);
         }
         if (asset_Infomation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_Infomation.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Unit))
         {
            idb.AddParameter("@AInfo_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Unit", asset_Infomation.AInfo_Unit);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_BOwnerCode))
         {
            idb.AddParameter("@AInfo_BOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BOwnerCode", asset_Infomation.AInfo_BOwnerCode);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_BOwner))
         {
            idb.AddParameter("@AInfo_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BOwner", asset_Infomation.AInfo_BOwner);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Value))
         {
            idb.AddParameter("@AInfo_Value", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Value", asset_Infomation.AInfo_Value);
         }
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Addr))
         {
            idb.AddParameter("@AInfo_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Addr", asset_Infomation.AInfo_Addr);
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
      /// 更新固定资产信息表 Asset_Infomation对象(即:一条记录
      /// </summary>
      public int Update(Asset_Infomation asset_Infomation)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Asset_Infomation       SET ");
            if(asset_Infomation.AInfo_Code_IsChanged){sbParameter.Append("AInfo_Code=@AInfo_Code, ");}
      if(asset_Infomation.AInfo_Name_IsChanged){sbParameter.Append("AInfo_Name=@AInfo_Name, ");}
      if(asset_Infomation.AInfo_Spec_IsChanged){sbParameter.Append("AInfo_Spec=@AInfo_Spec, ");}
      if(asset_Infomation.AInfo_Tech_IsChanged){sbParameter.Append("AInfo_Tech=@AInfo_Tech, ");}
      if(asset_Infomation.AInfo_TAttach_IsChanged){sbParameter.Append("AInfo_TAttach=@AInfo_TAttach, ");}
      if(asset_Infomation.AInfo_RefComp_IsChanged){sbParameter.Append("AInfo_RefComp=@AInfo_RefComp, ");}
      if(asset_Infomation.AInfo_Manu_IsChanged){sbParameter.Append("AInfo_Manu=@AInfo_Manu, ");}
      if(asset_Infomation.AInfo_Price_IsChanged){sbParameter.Append("AInfo_Price=@AInfo_Price, ");}
      if(asset_Infomation.AInfo_BuyDate_IsChanged){sbParameter.Append("AInfo_BuyDate=@AInfo_BuyDate, ");}
      if(asset_Infomation.AInfo_PDate_IsChanged){sbParameter.Append("AInfo_PDate=@AInfo_PDate, ");}
      if(asset_Infomation.AInfo_SCode_IsChanged){sbParameter.Append("AInfo_SCode=@AInfo_SCode, ");}
      if(asset_Infomation.AInfo_CCode_IsChanged){sbParameter.Append("AInfo_CCode=@AInfo_CCode, ");}
      if(asset_Infomation.AInfo_Type_IsChanged){sbParameter.Append("AInfo_Type=@AInfo_Type, ");}
      if(asset_Infomation.AInfo_Type_Temp_IsChanged){sbParameter.Append("AInfo_Type_Temp=@AInfo_Type_Temp, ");}
      if(asset_Infomation.AInfo_iType_IsChanged){sbParameter.Append("AInfo_iType=@AInfo_iType, ");}
      if(asset_Infomation.AInfo_CompanyCode_IsChanged){sbParameter.Append("AInfo_CompanyCode=@AInfo_CompanyCode, ");}
      if(asset_Infomation.AInfo_Company_IsChanged){sbParameter.Append("AInfo_Company=@AInfo_Company, ");}
      if(asset_Infomation.AInfo_DepartmentCode_IsChanged){sbParameter.Append("AInfo_DepartmentCode=@AInfo_DepartmentCode, ");}
      if(asset_Infomation.AInfo_Department_IsChanged){sbParameter.Append("AInfo_Department=@AInfo_Department, ");}
      if(asset_Infomation.AInfo_Status_IsChanged){sbParameter.Append("AInfo_Status=@AInfo_Status, ");}
      if(asset_Infomation.AInfo_UCompanyCode_IsChanged){sbParameter.Append("AInfo_UCompanyCode=@AInfo_UCompanyCode, ");}
      if(asset_Infomation.AInfo_UCompany_IsChanged){sbParameter.Append("AInfo_UCompany=@AInfo_UCompany, ");}
      if(asset_Infomation.AInfo_UDepartmentCode_IsChanged){sbParameter.Append("AInfo_UDepartmentCode=@AInfo_UDepartmentCode, ");}
      if(asset_Infomation.AInfo_UDepartment_IsChanged){sbParameter.Append("AInfo_UDepartment=@AInfo_UDepartment, ");}
      if(asset_Infomation.AInfo_UOwnerCode_IsChanged){sbParameter.Append("AInfo_UOwnerCode=@AInfo_UOwnerCode, ");}
      if(asset_Infomation.AInfo_UOwner_IsChanged){sbParameter.Append("AInfo_UOwner=@AInfo_UOwner, ");}
      if(asset_Infomation.AInfo_UStart_IsChanged){sbParameter.Append("AInfo_UStart=@AInfo_UStart, ");}
      if(asset_Infomation.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(asset_Infomation.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(asset_Infomation.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(asset_Infomation.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(asset_Infomation.AInfo_Unit_IsChanged){sbParameter.Append("AInfo_Unit=@AInfo_Unit, ");}
      if(asset_Infomation.AInfo_BOwnerCode_IsChanged){sbParameter.Append("AInfo_BOwnerCode=@AInfo_BOwnerCode, ");}
      if(asset_Infomation.AInfo_BOwner_IsChanged){sbParameter.Append("AInfo_BOwner=@AInfo_BOwner, ");}
      if(asset_Infomation.AInfo_Value_IsChanged){sbParameter.Append("AInfo_Value=@AInfo_Value, ");}
      if(asset_Infomation.AInfo_Addr_IsChanged){sbParameter.Append("AInfo_Addr=@AInfo_Addr ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AInfo_ID=@AInfo_ID; " );
      string sql=sb.ToString();
         if(asset_Infomation.AInfo_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Code))
         {
            idb.AddParameter("@AInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Code", asset_Infomation.AInfo_Code);
         }
          }
         if(asset_Infomation.AInfo_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Name))
         {
            idb.AddParameter("@AInfo_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Name", asset_Infomation.AInfo_Name);
         }
          }
         if(asset_Infomation.AInfo_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Spec))
         {
            idb.AddParameter("@AInfo_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Spec", asset_Infomation.AInfo_Spec);
         }
          }
         if(asset_Infomation.AInfo_Tech_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Tech))
         {
            idb.AddParameter("@AInfo_Tech", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Tech", asset_Infomation.AInfo_Tech);
         }
          }
         if(asset_Infomation.AInfo_TAttach_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_TAttach))
         {
            idb.AddParameter("@AInfo_TAttach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_TAttach", asset_Infomation.AInfo_TAttach);
         }
          }
         if(asset_Infomation.AInfo_RefComp_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_RefComp))
         {
            idb.AddParameter("@AInfo_RefComp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_RefComp", asset_Infomation.AInfo_RefComp);
         }
          }
         if(asset_Infomation.AInfo_Manu_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Manu))
         {
            idb.AddParameter("@AInfo_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Manu", asset_Infomation.AInfo_Manu);
         }
          }
         if(asset_Infomation.AInfo_Price_IsChanged)
         {
         if (asset_Infomation.AInfo_Price == 0)
         {
            idb.AddParameter("@AInfo_Price", 0);
         }
         else
         {
            idb.AddParameter("@AInfo_Price", asset_Infomation.AInfo_Price);
         }
          }
         if(asset_Infomation.AInfo_BuyDate_IsChanged)
         {
         if (asset_Infomation.AInfo_BuyDate == DateTime.MinValue)
         {
            idb.AddParameter("@AInfo_BuyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BuyDate", asset_Infomation.AInfo_BuyDate);
         }
          }
         if(asset_Infomation.AInfo_PDate_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_PDate))
         {
            idb.AddParameter("@AInfo_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_PDate", asset_Infomation.AInfo_PDate);
         }
          }
         if(asset_Infomation.AInfo_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_SCode))
         {
            idb.AddParameter("@AInfo_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_SCode", asset_Infomation.AInfo_SCode);
         }
          }
         if(asset_Infomation.AInfo_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_CCode))
         {
            idb.AddParameter("@AInfo_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_CCode", asset_Infomation.AInfo_CCode);
         }
          }
         if(asset_Infomation.AInfo_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Type))
         {
            idb.AddParameter("@AInfo_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Type", asset_Infomation.AInfo_Type);
         }
          }
         if(asset_Infomation.AInfo_Type_Temp_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Type_Temp))
         {
            idb.AddParameter("@AInfo_Type_Temp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Type_Temp", asset_Infomation.AInfo_Type_Temp);
         }
          }
         if(asset_Infomation.AInfo_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_iType))
         {
            idb.AddParameter("@AInfo_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_iType", asset_Infomation.AInfo_iType);
         }
          }
         if(asset_Infomation.AInfo_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_CompanyCode))
         {
            idb.AddParameter("@AInfo_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_CompanyCode", asset_Infomation.AInfo_CompanyCode);
         }
          }
         if(asset_Infomation.AInfo_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Company))
         {
            idb.AddParameter("@AInfo_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Company", asset_Infomation.AInfo_Company);
         }
          }
         if(asset_Infomation.AInfo_DepartmentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_DepartmentCode))
         {
            idb.AddParameter("@AInfo_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_DepartmentCode", asset_Infomation.AInfo_DepartmentCode);
         }
          }
         if(asset_Infomation.AInfo_Department_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Department))
         {
            idb.AddParameter("@AInfo_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Department", asset_Infomation.AInfo_Department);
         }
          }
         if(asset_Infomation.AInfo_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Status))
         {
            idb.AddParameter("@AInfo_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Status", asset_Infomation.AInfo_Status);
         }
          }
         if(asset_Infomation.AInfo_UCompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UCompanyCode))
         {
            idb.AddParameter("@AInfo_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UCompanyCode", asset_Infomation.AInfo_UCompanyCode);
         }
          }
         if(asset_Infomation.AInfo_UCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UCompany))
         {
            idb.AddParameter("@AInfo_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UCompany", asset_Infomation.AInfo_UCompany);
         }
          }
         if(asset_Infomation.AInfo_UDepartmentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UDepartmentCode))
         {
            idb.AddParameter("@AInfo_UDepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UDepartmentCode", asset_Infomation.AInfo_UDepartmentCode);
         }
          }
         if(asset_Infomation.AInfo_UDepartment_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UDepartment))
         {
            idb.AddParameter("@AInfo_UDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UDepartment", asset_Infomation.AInfo_UDepartment);
         }
          }
         if(asset_Infomation.AInfo_UOwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UOwnerCode))
         {
            idb.AddParameter("@AInfo_UOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UOwnerCode", asset_Infomation.AInfo_UOwnerCode);
         }
          }
         if(asset_Infomation.AInfo_UOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_UOwner))
         {
            idb.AddParameter("@AInfo_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UOwner", asset_Infomation.AInfo_UOwner);
         }
          }
         if(asset_Infomation.AInfo_UStart_IsChanged)
         {
         if (asset_Infomation.AInfo_UStart == DateTime.MinValue)
         {
            idb.AddParameter("@AInfo_UStart", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_UStart", asset_Infomation.AInfo_UStart);
         }
          }
         if(asset_Infomation.Stat_IsChanged)
         {
         if (asset_Infomation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_Infomation.Stat);
         }
          }
         if(asset_Infomation.CreateDate_IsChanged)
         {
         if (asset_Infomation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_Infomation.CreateDate);
         }
          }
         if(asset_Infomation.UpdateDate_IsChanged)
         {
         if (asset_Infomation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_Infomation.UpdateDate);
         }
          }
         if(asset_Infomation.DeleteDate_IsChanged)
         {
         if (asset_Infomation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_Infomation.DeleteDate);
         }
          }
         if(asset_Infomation.AInfo_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Unit))
         {
            idb.AddParameter("@AInfo_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Unit", asset_Infomation.AInfo_Unit);
         }
          }
         if(asset_Infomation.AInfo_BOwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_BOwnerCode))
         {
            idb.AddParameter("@AInfo_BOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BOwnerCode", asset_Infomation.AInfo_BOwnerCode);
         }
          }
         if(asset_Infomation.AInfo_BOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_BOwner))
         {
            idb.AddParameter("@AInfo_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_BOwner", asset_Infomation.AInfo_BOwner);
         }
          }
         if(asset_Infomation.AInfo_Value_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Value))
         {
            idb.AddParameter("@AInfo_Value", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Value", asset_Infomation.AInfo_Value);
         }
          }
         if(asset_Infomation.AInfo_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Infomation.AInfo_Addr))
         {
            idb.AddParameter("@AInfo_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AInfo_Addr", asset_Infomation.AInfo_Addr);
         }
          }

         idb.AddParameter("@AInfo_ID", asset_Infomation.AInfo_ID);

           
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
      /// 删除固定资产信息表 Asset_Infomation对象(即:一条记录
      /// </summary>
      public int Delete(decimal aInfo_ID)
      {
         string sql = "DELETE Asset_Infomation WHERE 1=1  AND AInfo_ID=@AInfo_ID ";
         idb.AddParameter("@AInfo_ID", aInfo_ID);

           
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
      /// 获取指定的固定资产信息表 Asset_Infomation对象(即:一条记录
      /// </summary>
      public Asset_Infomation GetByKey(decimal aInfo_ID)
      {
         Asset_Infomation asset_Infomation = new Asset_Infomation();
         string sql = "SELECT  AInfo_ID,AInfo_Code,AInfo_Name,AInfo_Spec,AInfo_Tech,AInfo_TAttach,AInfo_RefComp,AInfo_Manu,AInfo_Price,AInfo_BuyDate,AInfo_PDate,AInfo_SCode,AInfo_CCode,AInfo_Type,AInfo_Type_Temp,AInfo_iType,AInfo_CompanyCode,AInfo_Company,AInfo_DepartmentCode,AInfo_Department,AInfo_Status,AInfo_UCompanyCode,AInfo_UCompany,AInfo_UDepartmentCode,AInfo_UDepartment,AInfo_UOwnerCode,AInfo_UOwner,AInfo_UStart,Stat,CreateDate,UpdateDate,DeleteDate,AInfo_Unit,AInfo_BOwnerCode,AInfo_BOwner,AInfo_Value,AInfo_Addr FROM Asset_Infomation WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AInfo_ID=@AInfo_ID ";
         idb.AddParameter("@AInfo_ID", aInfo_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AInfo_ID"] != DBNull.Value) asset_Infomation.AInfo_ID = Convert.ToDecimal(dr["AInfo_ID"]);
            if (dr["AInfo_Code"] != DBNull.Value) asset_Infomation.AInfo_Code = Convert.ToString(dr["AInfo_Code"]);
            if (dr["AInfo_Name"] != DBNull.Value) asset_Infomation.AInfo_Name = Convert.ToString(dr["AInfo_Name"]);
            if (dr["AInfo_Spec"] != DBNull.Value) asset_Infomation.AInfo_Spec = Convert.ToString(dr["AInfo_Spec"]);
            if (dr["AInfo_Tech"] != DBNull.Value) asset_Infomation.AInfo_Tech = Convert.ToString(dr["AInfo_Tech"]);
            if (dr["AInfo_TAttach"] != DBNull.Value) asset_Infomation.AInfo_TAttach = Convert.ToString(dr["AInfo_TAttach"]);
            if (dr["AInfo_RefComp"] != DBNull.Value) asset_Infomation.AInfo_RefComp = Convert.ToString(dr["AInfo_RefComp"]);
            if (dr["AInfo_Manu"] != DBNull.Value) asset_Infomation.AInfo_Manu = Convert.ToString(dr["AInfo_Manu"]);
            if (dr["AInfo_Price"] != DBNull.Value) asset_Infomation.AInfo_Price = Convert.ToDecimal(dr["AInfo_Price"]);
            if (dr["AInfo_BuyDate"] != DBNull.Value) asset_Infomation.AInfo_BuyDate = Convert.ToDateTime(dr["AInfo_BuyDate"]);
            if (dr["AInfo_PDate"] != DBNull.Value) asset_Infomation.AInfo_PDate = Convert.ToString(dr["AInfo_PDate"]);
            if (dr["AInfo_SCode"] != DBNull.Value) asset_Infomation.AInfo_SCode = Convert.ToString(dr["AInfo_SCode"]);
            if (dr["AInfo_CCode"] != DBNull.Value) asset_Infomation.AInfo_CCode = Convert.ToString(dr["AInfo_CCode"]);
            if (dr["AInfo_Type"] != DBNull.Value) asset_Infomation.AInfo_Type = Convert.ToString(dr["AInfo_Type"]);
            if (dr["AInfo_Type_Temp"] != DBNull.Value) asset_Infomation.AInfo_Type_Temp = Convert.ToString(dr["AInfo_Type_Temp"]);
            if (dr["AInfo_iType"] != DBNull.Value) asset_Infomation.AInfo_iType = Convert.ToString(dr["AInfo_iType"]);
            if (dr["AInfo_CompanyCode"] != DBNull.Value) asset_Infomation.AInfo_CompanyCode = Convert.ToString(dr["AInfo_CompanyCode"]);
            if (dr["AInfo_Company"] != DBNull.Value) asset_Infomation.AInfo_Company = Convert.ToString(dr["AInfo_Company"]);
            if (dr["AInfo_DepartmentCode"] != DBNull.Value) asset_Infomation.AInfo_DepartmentCode = Convert.ToString(dr["AInfo_DepartmentCode"]);
            if (dr["AInfo_Department"] != DBNull.Value) asset_Infomation.AInfo_Department = Convert.ToString(dr["AInfo_Department"]);
            if (dr["AInfo_Status"] != DBNull.Value) asset_Infomation.AInfo_Status = Convert.ToString(dr["AInfo_Status"]);
            if (dr["AInfo_UCompanyCode"] != DBNull.Value) asset_Infomation.AInfo_UCompanyCode = Convert.ToString(dr["AInfo_UCompanyCode"]);
            if (dr["AInfo_UCompany"] != DBNull.Value) asset_Infomation.AInfo_UCompany = Convert.ToString(dr["AInfo_UCompany"]);
            if (dr["AInfo_UDepartmentCode"] != DBNull.Value) asset_Infomation.AInfo_UDepartmentCode = Convert.ToString(dr["AInfo_UDepartmentCode"]);
            if (dr["AInfo_UDepartment"] != DBNull.Value) asset_Infomation.AInfo_UDepartment = Convert.ToString(dr["AInfo_UDepartment"]);
            if (dr["AInfo_UOwnerCode"] != DBNull.Value) asset_Infomation.AInfo_UOwnerCode = Convert.ToString(dr["AInfo_UOwnerCode"]);
            if (dr["AInfo_UOwner"] != DBNull.Value) asset_Infomation.AInfo_UOwner = Convert.ToString(dr["AInfo_UOwner"]);
            if (dr["AInfo_UStart"] != DBNull.Value) asset_Infomation.AInfo_UStart = Convert.ToDateTime(dr["AInfo_UStart"]);
            if (dr["Stat"] != DBNull.Value) asset_Infomation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_Infomation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_Infomation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_Infomation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AInfo_Unit"] != DBNull.Value) asset_Infomation.AInfo_Unit = Convert.ToString(dr["AInfo_Unit"]);
            if (dr["AInfo_BOwnerCode"] != DBNull.Value) asset_Infomation.AInfo_BOwnerCode = Convert.ToString(dr["AInfo_BOwnerCode"]);
            if (dr["AInfo_BOwner"] != DBNull.Value) asset_Infomation.AInfo_BOwner = Convert.ToString(dr["AInfo_BOwner"]);
            if (dr["AInfo_Value"] != DBNull.Value) asset_Infomation.AInfo_Value = Convert.ToString(dr["AInfo_Value"]);
            if (dr["AInfo_Addr"] != DBNull.Value) asset_Infomation.AInfo_Addr = Convert.ToString(dr["AInfo_Addr"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return asset_Infomation;
      }
      /// <summary>
      /// 获取指定的固定资产信息表 Asset_Infomation对象集合
      /// </summary>
      public List<Asset_Infomation> GetListByWhere(string strCondition)
      {
         List<Asset_Infomation> ret = new List<Asset_Infomation>();
         string sql = "SELECT  AInfo_ID,AInfo_Code,AInfo_Name,AInfo_Spec,AInfo_Tech,AInfo_TAttach,AInfo_RefComp,AInfo_Manu,AInfo_Price,AInfo_BuyDate,AInfo_PDate,AInfo_SCode,AInfo_CCode,AInfo_Type,AInfo_Type_Temp,AInfo_iType,AInfo_CompanyCode,AInfo_Company,AInfo_DepartmentCode,AInfo_Department,AInfo_Status,AInfo_UCompanyCode,AInfo_UCompany,AInfo_UDepartmentCode,AInfo_UDepartment,AInfo_UOwnerCode,AInfo_UOwner,AInfo_UStart,Stat,CreateDate,UpdateDate,DeleteDate,AInfo_Unit,AInfo_BOwnerCode,AInfo_BOwner,AInfo_Value,AInfo_Addr FROM Asset_Infomation WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Asset_Infomation asset_Infomation = new Asset_Infomation();
            if (dr["AInfo_ID"] != DBNull.Value) asset_Infomation.AInfo_ID = Convert.ToDecimal(dr["AInfo_ID"]);
            if (dr["AInfo_Code"] != DBNull.Value) asset_Infomation.AInfo_Code = Convert.ToString(dr["AInfo_Code"]);
            if (dr["AInfo_Name"] != DBNull.Value) asset_Infomation.AInfo_Name = Convert.ToString(dr["AInfo_Name"]);
            if (dr["AInfo_Spec"] != DBNull.Value) asset_Infomation.AInfo_Spec = Convert.ToString(dr["AInfo_Spec"]);
            if (dr["AInfo_Tech"] != DBNull.Value) asset_Infomation.AInfo_Tech = Convert.ToString(dr["AInfo_Tech"]);
            if (dr["AInfo_TAttach"] != DBNull.Value) asset_Infomation.AInfo_TAttach = Convert.ToString(dr["AInfo_TAttach"]);
            if (dr["AInfo_RefComp"] != DBNull.Value) asset_Infomation.AInfo_RefComp = Convert.ToString(dr["AInfo_RefComp"]);
            if (dr["AInfo_Manu"] != DBNull.Value) asset_Infomation.AInfo_Manu = Convert.ToString(dr["AInfo_Manu"]);
            if (dr["AInfo_Price"] != DBNull.Value) asset_Infomation.AInfo_Price = Convert.ToDecimal(dr["AInfo_Price"]);
            if (dr["AInfo_BuyDate"] != DBNull.Value) asset_Infomation.AInfo_BuyDate = Convert.ToDateTime(dr["AInfo_BuyDate"]);
            if (dr["AInfo_PDate"] != DBNull.Value) asset_Infomation.AInfo_PDate = Convert.ToString(dr["AInfo_PDate"]);
            if (dr["AInfo_SCode"] != DBNull.Value) asset_Infomation.AInfo_SCode = Convert.ToString(dr["AInfo_SCode"]);
            if (dr["AInfo_CCode"] != DBNull.Value) asset_Infomation.AInfo_CCode = Convert.ToString(dr["AInfo_CCode"]);
            if (dr["AInfo_Type"] != DBNull.Value) asset_Infomation.AInfo_Type = Convert.ToString(dr["AInfo_Type"]);
            if (dr["AInfo_Type_Temp"] != DBNull.Value) asset_Infomation.AInfo_Type_Temp = Convert.ToString(dr["AInfo_Type_Temp"]);
            if (dr["AInfo_iType"] != DBNull.Value) asset_Infomation.AInfo_iType = Convert.ToString(dr["AInfo_iType"]);
            if (dr["AInfo_CompanyCode"] != DBNull.Value) asset_Infomation.AInfo_CompanyCode = Convert.ToString(dr["AInfo_CompanyCode"]);
            if (dr["AInfo_Company"] != DBNull.Value) asset_Infomation.AInfo_Company = Convert.ToString(dr["AInfo_Company"]);
            if (dr["AInfo_DepartmentCode"] != DBNull.Value) asset_Infomation.AInfo_DepartmentCode = Convert.ToString(dr["AInfo_DepartmentCode"]);
            if (dr["AInfo_Department"] != DBNull.Value) asset_Infomation.AInfo_Department = Convert.ToString(dr["AInfo_Department"]);
            if (dr["AInfo_Status"] != DBNull.Value) asset_Infomation.AInfo_Status = Convert.ToString(dr["AInfo_Status"]);
            if (dr["AInfo_UCompanyCode"] != DBNull.Value) asset_Infomation.AInfo_UCompanyCode = Convert.ToString(dr["AInfo_UCompanyCode"]);
            if (dr["AInfo_UCompany"] != DBNull.Value) asset_Infomation.AInfo_UCompany = Convert.ToString(dr["AInfo_UCompany"]);
            if (dr["AInfo_UDepartmentCode"] != DBNull.Value) asset_Infomation.AInfo_UDepartmentCode = Convert.ToString(dr["AInfo_UDepartmentCode"]);
            if (dr["AInfo_UDepartment"] != DBNull.Value) asset_Infomation.AInfo_UDepartment = Convert.ToString(dr["AInfo_UDepartment"]);
            if (dr["AInfo_UOwnerCode"] != DBNull.Value) asset_Infomation.AInfo_UOwnerCode = Convert.ToString(dr["AInfo_UOwnerCode"]);
            if (dr["AInfo_UOwner"] != DBNull.Value) asset_Infomation.AInfo_UOwner = Convert.ToString(dr["AInfo_UOwner"]);
            if (dr["AInfo_UStart"] != DBNull.Value) asset_Infomation.AInfo_UStart = Convert.ToDateTime(dr["AInfo_UStart"]);
            if (dr["Stat"] != DBNull.Value) asset_Infomation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_Infomation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_Infomation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_Infomation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AInfo_Unit"] != DBNull.Value) asset_Infomation.AInfo_Unit = Convert.ToString(dr["AInfo_Unit"]);
            if (dr["AInfo_BOwnerCode"] != DBNull.Value) asset_Infomation.AInfo_BOwnerCode = Convert.ToString(dr["AInfo_BOwnerCode"]);
            if (dr["AInfo_BOwner"] != DBNull.Value) asset_Infomation.AInfo_BOwner = Convert.ToString(dr["AInfo_BOwner"]);
            if (dr["AInfo_Value"] != DBNull.Value) asset_Infomation.AInfo_Value = Convert.ToString(dr["AInfo_Value"]);
            if (dr["AInfo_Addr"] != DBNull.Value) asset_Infomation.AInfo_Addr = Convert.ToString(dr["AInfo_Addr"]);
            ret.Add(asset_Infomation);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的固定资产信息表 Asset_Infomation对象(即:一条记录
      /// </summary>
      public List<Asset_Infomation> GetAll()
      {
         List<Asset_Infomation> ret = new List<Asset_Infomation>();
         string sql = "SELECT  AInfo_ID,AInfo_Code,AInfo_Name,AInfo_Spec,AInfo_Tech,AInfo_TAttach,AInfo_RefComp,AInfo_Manu,AInfo_Price,AInfo_BuyDate,AInfo_PDate,AInfo_SCode,AInfo_CCode,AInfo_Type,AInfo_Type_Temp,AInfo_iType,AInfo_CompanyCode,AInfo_Company,AInfo_DepartmentCode,AInfo_Department,AInfo_Status,AInfo_UCompanyCode,AInfo_UCompany,AInfo_UDepartmentCode,AInfo_UDepartment,AInfo_UOwnerCode,AInfo_UOwner,AInfo_UStart,Stat,CreateDate,UpdateDate,DeleteDate,AInfo_Unit,AInfo_BOwnerCode,AInfo_BOwner,AInfo_Value,AInfo_Addr FROM Asset_Infomation where 1=1 AND ((Stat is null) or (Stat=0) ) order by AInfo_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Asset_Infomation asset_Infomation = new Asset_Infomation();
            if (dr["AInfo_ID"] != DBNull.Value) asset_Infomation.AInfo_ID = Convert.ToDecimal(dr["AInfo_ID"]);
            if (dr["AInfo_Code"] != DBNull.Value) asset_Infomation.AInfo_Code = Convert.ToString(dr["AInfo_Code"]);
            if (dr["AInfo_Name"] != DBNull.Value) asset_Infomation.AInfo_Name = Convert.ToString(dr["AInfo_Name"]);
            if (dr["AInfo_Spec"] != DBNull.Value) asset_Infomation.AInfo_Spec = Convert.ToString(dr["AInfo_Spec"]);
            if (dr["AInfo_Tech"] != DBNull.Value) asset_Infomation.AInfo_Tech = Convert.ToString(dr["AInfo_Tech"]);
            if (dr["AInfo_TAttach"] != DBNull.Value) asset_Infomation.AInfo_TAttach = Convert.ToString(dr["AInfo_TAttach"]);
            if (dr["AInfo_RefComp"] != DBNull.Value) asset_Infomation.AInfo_RefComp = Convert.ToString(dr["AInfo_RefComp"]);
            if (dr["AInfo_Manu"] != DBNull.Value) asset_Infomation.AInfo_Manu = Convert.ToString(dr["AInfo_Manu"]);
            if (dr["AInfo_Price"] != DBNull.Value) asset_Infomation.AInfo_Price = Convert.ToDecimal(dr["AInfo_Price"]);
            if (dr["AInfo_BuyDate"] != DBNull.Value) asset_Infomation.AInfo_BuyDate = Convert.ToDateTime(dr["AInfo_BuyDate"]);
            if (dr["AInfo_PDate"] != DBNull.Value) asset_Infomation.AInfo_PDate = Convert.ToString(dr["AInfo_PDate"]);
            if (dr["AInfo_SCode"] != DBNull.Value) asset_Infomation.AInfo_SCode = Convert.ToString(dr["AInfo_SCode"]);
            if (dr["AInfo_CCode"] != DBNull.Value) asset_Infomation.AInfo_CCode = Convert.ToString(dr["AInfo_CCode"]);
            if (dr["AInfo_Type"] != DBNull.Value) asset_Infomation.AInfo_Type = Convert.ToString(dr["AInfo_Type"]);
            if (dr["AInfo_Type_Temp"] != DBNull.Value) asset_Infomation.AInfo_Type_Temp = Convert.ToString(dr["AInfo_Type_Temp"]);
            if (dr["AInfo_iType"] != DBNull.Value) asset_Infomation.AInfo_iType = Convert.ToString(dr["AInfo_iType"]);
            if (dr["AInfo_CompanyCode"] != DBNull.Value) asset_Infomation.AInfo_CompanyCode = Convert.ToString(dr["AInfo_CompanyCode"]);
            if (dr["AInfo_Company"] != DBNull.Value) asset_Infomation.AInfo_Company = Convert.ToString(dr["AInfo_Company"]);
            if (dr["AInfo_DepartmentCode"] != DBNull.Value) asset_Infomation.AInfo_DepartmentCode = Convert.ToString(dr["AInfo_DepartmentCode"]);
            if (dr["AInfo_Department"] != DBNull.Value) asset_Infomation.AInfo_Department = Convert.ToString(dr["AInfo_Department"]);
            if (dr["AInfo_Status"] != DBNull.Value) asset_Infomation.AInfo_Status = Convert.ToString(dr["AInfo_Status"]);
            if (dr["AInfo_UCompanyCode"] != DBNull.Value) asset_Infomation.AInfo_UCompanyCode = Convert.ToString(dr["AInfo_UCompanyCode"]);
            if (dr["AInfo_UCompany"] != DBNull.Value) asset_Infomation.AInfo_UCompany = Convert.ToString(dr["AInfo_UCompany"]);
            if (dr["AInfo_UDepartmentCode"] != DBNull.Value) asset_Infomation.AInfo_UDepartmentCode = Convert.ToString(dr["AInfo_UDepartmentCode"]);
            if (dr["AInfo_UDepartment"] != DBNull.Value) asset_Infomation.AInfo_UDepartment = Convert.ToString(dr["AInfo_UDepartment"]);
            if (dr["AInfo_UOwnerCode"] != DBNull.Value) asset_Infomation.AInfo_UOwnerCode = Convert.ToString(dr["AInfo_UOwnerCode"]);
            if (dr["AInfo_UOwner"] != DBNull.Value) asset_Infomation.AInfo_UOwner = Convert.ToString(dr["AInfo_UOwner"]);
            if (dr["AInfo_UStart"] != DBNull.Value) asset_Infomation.AInfo_UStart = Convert.ToDateTime(dr["AInfo_UStart"]);
            if (dr["Stat"] != DBNull.Value) asset_Infomation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_Infomation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_Infomation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_Infomation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AInfo_Unit"] != DBNull.Value) asset_Infomation.AInfo_Unit = Convert.ToString(dr["AInfo_Unit"]);
            if (dr["AInfo_BOwnerCode"] != DBNull.Value) asset_Infomation.AInfo_BOwnerCode = Convert.ToString(dr["AInfo_BOwnerCode"]);
            if (dr["AInfo_BOwner"] != DBNull.Value) asset_Infomation.AInfo_BOwner = Convert.ToString(dr["AInfo_BOwner"]);
            if (dr["AInfo_Value"] != DBNull.Value) asset_Infomation.AInfo_Value = Convert.ToString(dr["AInfo_Value"]);
            if (dr["AInfo_Addr"] != DBNull.Value) asset_Infomation.AInfo_Addr = Convert.ToString(dr["AInfo_Addr"]);
            ret.Add(asset_Infomation);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
