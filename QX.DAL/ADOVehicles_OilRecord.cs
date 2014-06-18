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
   /// 后勤车辆加油记录
   /// </summary>
   [Serializable]
   public partial class ADOVehicles_OilRecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加后勤车辆加油记录 Vehicles_OilRecord对象(即:一条记录)
      /// </summary>
      public int Add(Vehicles_OilRecord vehicles_OilRecord)
      {
         string sql = "INSERT INTO Vehicles_OilRecord (VOR_Code,VOR_VehiclesNo,VOR_VehiclesCode,VOR_RealCost,VOR_Cost,VOR_Count,VOR_ReturnMoney,VOR_Unit,VOR_Mile,VOR_Date,VOR_Company,VOR_Dept,VOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VOR_itype,VOR_TCode,VOR_CompanyCode,VOR_DeptCode) VALUES (@VOR_Code,@VOR_VehiclesNo,@VOR_VehiclesCode,@VOR_RealCost,@VOR_Cost,@VOR_Count,@VOR_ReturnMoney,@VOR_Unit,@VOR_Mile,@VOR_Date,@VOR_Company,@VOR_Dept,@VOR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VOR_itype,@VOR_TCode,@VOR_CompanyCode,@VOR_DeptCode)";
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Code))
         {
            idb.AddParameter("@VOR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Code", vehicles_OilRecord.VOR_Code);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_VehiclesNo))
         {
            idb.AddParameter("@VOR_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_VehiclesNo", vehicles_OilRecord.VOR_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_VehiclesCode))
         {
            idb.AddParameter("@VOR_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_VehiclesCode", vehicles_OilRecord.VOR_VehiclesCode);
         }
         if (vehicles_OilRecord.VOR_RealCost == 0)
         {
            idb.AddParameter("@VOR_RealCost", 0);
         }
         else
         {
            idb.AddParameter("@VOR_RealCost", vehicles_OilRecord.VOR_RealCost);
         }
         if (vehicles_OilRecord.VOR_Cost == 0)
         {
            idb.AddParameter("@VOR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Cost", vehicles_OilRecord.VOR_Cost);
         }
         if (vehicles_OilRecord.VOR_Count == 0)
         {
            idb.AddParameter("@VOR_Count", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Count", vehicles_OilRecord.VOR_Count);
         }
         if (vehicles_OilRecord.VOR_ReturnMoney == 0)
         {
            idb.AddParameter("@VOR_ReturnMoney", 0);
         }
         else
         {
            idb.AddParameter("@VOR_ReturnMoney", vehicles_OilRecord.VOR_ReturnMoney);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Unit))
         {
            idb.AddParameter("@VOR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Unit", vehicles_OilRecord.VOR_Unit);
         }
         if (vehicles_OilRecord.VOR_Mile == 0)
         {
            idb.AddParameter("@VOR_Mile", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Mile", vehicles_OilRecord.VOR_Mile);
         }
         if (vehicles_OilRecord.VOR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VOR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Date", vehicles_OilRecord.VOR_Date);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Company))
         {
            idb.AddParameter("@VOR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Company", vehicles_OilRecord.VOR_Company);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Dept))
         {
            idb.AddParameter("@VOR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Dept", vehicles_OilRecord.VOR_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Remark))
         {
            idb.AddParameter("@VOR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Remark", vehicles_OilRecord.VOR_Remark);
         }
         if (vehicles_OilRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_OilRecord.Stat);
         }
         if (vehicles_OilRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_OilRecord.CreateDate);
         }
         if (vehicles_OilRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_OilRecord.UpdateDate);
         }
         if (vehicles_OilRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_OilRecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_itype))
         {
            idb.AddParameter("@VOR_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_itype", vehicles_OilRecord.VOR_itype);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_TCode))
         {
            idb.AddParameter("@VOR_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_TCode", vehicles_OilRecord.VOR_TCode);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_CompanyCode))
         {
            idb.AddParameter("@VOR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_CompanyCode", vehicles_OilRecord.VOR_CompanyCode);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_DeptCode))
         {
            idb.AddParameter("@VOR_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_DeptCode", vehicles_OilRecord.VOR_DeptCode);
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
      /// 添加后勤车辆加油记录 Vehicles_OilRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Vehicles_OilRecord vehicles_OilRecord)
      {
         string sql = "INSERT INTO Vehicles_OilRecord (VOR_Code,VOR_VehiclesNo,VOR_VehiclesCode,VOR_RealCost,VOR_Cost,VOR_Count,VOR_ReturnMoney,VOR_Unit,VOR_Mile,VOR_Date,VOR_Company,VOR_Dept,VOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VOR_itype,VOR_TCode,VOR_CompanyCode,VOR_DeptCode) VALUES (@VOR_Code,@VOR_VehiclesNo,@VOR_VehiclesCode,@VOR_RealCost,@VOR_Cost,@VOR_Count,@VOR_ReturnMoney,@VOR_Unit,@VOR_Mile,@VOR_Date,@VOR_Company,@VOR_Dept,@VOR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VOR_itype,@VOR_TCode,@VOR_CompanyCode,@VOR_DeptCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Code))
         {
            idb.AddParameter("@VOR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Code", vehicles_OilRecord.VOR_Code);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_VehiclesNo))
         {
            idb.AddParameter("@VOR_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_VehiclesNo", vehicles_OilRecord.VOR_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_VehiclesCode))
         {
            idb.AddParameter("@VOR_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_VehiclesCode", vehicles_OilRecord.VOR_VehiclesCode);
         }
         if (vehicles_OilRecord.VOR_RealCost == 0)
         {
            idb.AddParameter("@VOR_RealCost", 0);
         }
         else
         {
            idb.AddParameter("@VOR_RealCost", vehicles_OilRecord.VOR_RealCost);
         }
         if (vehicles_OilRecord.VOR_Cost == 0)
         {
            idb.AddParameter("@VOR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Cost", vehicles_OilRecord.VOR_Cost);
         }
         if (vehicles_OilRecord.VOR_Count == 0)
         {
            idb.AddParameter("@VOR_Count", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Count", vehicles_OilRecord.VOR_Count);
         }
         if (vehicles_OilRecord.VOR_ReturnMoney == 0)
         {
            idb.AddParameter("@VOR_ReturnMoney", 0);
         }
         else
         {
            idb.AddParameter("@VOR_ReturnMoney", vehicles_OilRecord.VOR_ReturnMoney);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Unit))
         {
            idb.AddParameter("@VOR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Unit", vehicles_OilRecord.VOR_Unit);
         }
         if (vehicles_OilRecord.VOR_Mile == 0)
         {
            idb.AddParameter("@VOR_Mile", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Mile", vehicles_OilRecord.VOR_Mile);
         }
         if (vehicles_OilRecord.VOR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VOR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Date", vehicles_OilRecord.VOR_Date);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Company))
         {
            idb.AddParameter("@VOR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Company", vehicles_OilRecord.VOR_Company);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Dept))
         {
            idb.AddParameter("@VOR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Dept", vehicles_OilRecord.VOR_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Remark))
         {
            idb.AddParameter("@VOR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Remark", vehicles_OilRecord.VOR_Remark);
         }
         if (vehicles_OilRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_OilRecord.Stat);
         }
         if (vehicles_OilRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_OilRecord.CreateDate);
         }
         if (vehicles_OilRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_OilRecord.UpdateDate);
         }
         if (vehicles_OilRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_OilRecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_itype))
         {
            idb.AddParameter("@VOR_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_itype", vehicles_OilRecord.VOR_itype);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_TCode))
         {
            idb.AddParameter("@VOR_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_TCode", vehicles_OilRecord.VOR_TCode);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_CompanyCode))
         {
            idb.AddParameter("@VOR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_CompanyCode", vehicles_OilRecord.VOR_CompanyCode);
         }
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_DeptCode))
         {
            idb.AddParameter("@VOR_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_DeptCode", vehicles_OilRecord.VOR_DeptCode);
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
      /// 更新后勤车辆加油记录 Vehicles_OilRecord对象(即:一条记录
      /// </summary>
      public int Update(Vehicles_OilRecord vehicles_OilRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Vehicles_OilRecord       SET ");
            if(vehicles_OilRecord.VOR_Code_IsChanged){sbParameter.Append("VOR_Code=@VOR_Code, ");}
      if(vehicles_OilRecord.VOR_VehiclesNo_IsChanged){sbParameter.Append("VOR_VehiclesNo=@VOR_VehiclesNo, ");}
      if(vehicles_OilRecord.VOR_VehiclesCode_IsChanged){sbParameter.Append("VOR_VehiclesCode=@VOR_VehiclesCode, ");}
      if(vehicles_OilRecord.VOR_RealCost_IsChanged){sbParameter.Append("VOR_RealCost=@VOR_RealCost, ");}
      if(vehicles_OilRecord.VOR_Cost_IsChanged){sbParameter.Append("VOR_Cost=@VOR_Cost, ");}
      if(vehicles_OilRecord.VOR_Count_IsChanged){sbParameter.Append("VOR_Count=@VOR_Count, ");}
      if(vehicles_OilRecord.VOR_ReturnMoney_IsChanged){sbParameter.Append("VOR_ReturnMoney=@VOR_ReturnMoney, ");}
      if(vehicles_OilRecord.VOR_Unit_IsChanged){sbParameter.Append("VOR_Unit=@VOR_Unit, ");}
      if(vehicles_OilRecord.VOR_Mile_IsChanged){sbParameter.Append("VOR_Mile=@VOR_Mile, ");}
      if(vehicles_OilRecord.VOR_Date_IsChanged){sbParameter.Append("VOR_Date=@VOR_Date, ");}
      if(vehicles_OilRecord.VOR_Company_IsChanged){sbParameter.Append("VOR_Company=@VOR_Company, ");}
      if(vehicles_OilRecord.VOR_Dept_IsChanged){sbParameter.Append("VOR_Dept=@VOR_Dept, ");}
      if(vehicles_OilRecord.VOR_Remark_IsChanged){sbParameter.Append("VOR_Remark=@VOR_Remark, ");}
      if(vehicles_OilRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(vehicles_OilRecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(vehicles_OilRecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(vehicles_OilRecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(vehicles_OilRecord.VOR_itype_IsChanged){sbParameter.Append("VOR_itype=@VOR_itype, ");}
      if(vehicles_OilRecord.VOR_TCode_IsChanged){sbParameter.Append("VOR_TCode=@VOR_TCode, ");}
      if(vehicles_OilRecord.VOR_CompanyCode_IsChanged){sbParameter.Append("VOR_CompanyCode=@VOR_CompanyCode, ");}
      if(vehicles_OilRecord.VOR_DeptCode_IsChanged){sbParameter.Append("VOR_DeptCode=@VOR_DeptCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and VOR_ID=@VOR_ID; " );
      string sql=sb.ToString();
         if(vehicles_OilRecord.VOR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Code))
         {
            idb.AddParameter("@VOR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Code", vehicles_OilRecord.VOR_Code);
         }
          }
         if(vehicles_OilRecord.VOR_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_VehiclesNo))
         {
            idb.AddParameter("@VOR_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_VehiclesNo", vehicles_OilRecord.VOR_VehiclesNo);
         }
          }
         if(vehicles_OilRecord.VOR_VehiclesCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_VehiclesCode))
         {
            idb.AddParameter("@VOR_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_VehiclesCode", vehicles_OilRecord.VOR_VehiclesCode);
         }
          }
         if(vehicles_OilRecord.VOR_RealCost_IsChanged)
         {
         if (vehicles_OilRecord.VOR_RealCost == 0)
         {
            idb.AddParameter("@VOR_RealCost", 0);
         }
         else
         {
            idb.AddParameter("@VOR_RealCost", vehicles_OilRecord.VOR_RealCost);
         }
          }
         if(vehicles_OilRecord.VOR_Cost_IsChanged)
         {
         if (vehicles_OilRecord.VOR_Cost == 0)
         {
            idb.AddParameter("@VOR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Cost", vehicles_OilRecord.VOR_Cost);
         }
          }
         if(vehicles_OilRecord.VOR_Count_IsChanged)
         {
         if (vehicles_OilRecord.VOR_Count == 0)
         {
            idb.AddParameter("@VOR_Count", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Count", vehicles_OilRecord.VOR_Count);
         }
          }
         if(vehicles_OilRecord.VOR_ReturnMoney_IsChanged)
         {
         if (vehicles_OilRecord.VOR_ReturnMoney == 0)
         {
            idb.AddParameter("@VOR_ReturnMoney", 0);
         }
         else
         {
            idb.AddParameter("@VOR_ReturnMoney", vehicles_OilRecord.VOR_ReturnMoney);
         }
          }
         if(vehicles_OilRecord.VOR_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Unit))
         {
            idb.AddParameter("@VOR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Unit", vehicles_OilRecord.VOR_Unit);
         }
          }
         if(vehicles_OilRecord.VOR_Mile_IsChanged)
         {
         if (vehicles_OilRecord.VOR_Mile == 0)
         {
            idb.AddParameter("@VOR_Mile", 0);
         }
         else
         {
            idb.AddParameter("@VOR_Mile", vehicles_OilRecord.VOR_Mile);
         }
          }
         if(vehicles_OilRecord.VOR_Date_IsChanged)
         {
         if (vehicles_OilRecord.VOR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VOR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Date", vehicles_OilRecord.VOR_Date);
         }
          }
         if(vehicles_OilRecord.VOR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Company))
         {
            idb.AddParameter("@VOR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Company", vehicles_OilRecord.VOR_Company);
         }
          }
         if(vehicles_OilRecord.VOR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Dept))
         {
            idb.AddParameter("@VOR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Dept", vehicles_OilRecord.VOR_Dept);
         }
          }
         if(vehicles_OilRecord.VOR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_Remark))
         {
            idb.AddParameter("@VOR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_Remark", vehicles_OilRecord.VOR_Remark);
         }
          }
         if(vehicles_OilRecord.Stat_IsChanged)
         {
         if (vehicles_OilRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_OilRecord.Stat);
         }
          }
         if(vehicles_OilRecord.CreateDate_IsChanged)
         {
         if (vehicles_OilRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_OilRecord.CreateDate);
         }
          }
         if(vehicles_OilRecord.UpdateDate_IsChanged)
         {
         if (vehicles_OilRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_OilRecord.UpdateDate);
         }
          }
         if(vehicles_OilRecord.DeleteDate_IsChanged)
         {
         if (vehicles_OilRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_OilRecord.DeleteDate);
         }
          }
         if(vehicles_OilRecord.VOR_itype_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_itype))
         {
            idb.AddParameter("@VOR_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_itype", vehicles_OilRecord.VOR_itype);
         }
          }
         if(vehicles_OilRecord.VOR_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_TCode))
         {
            idb.AddParameter("@VOR_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_TCode", vehicles_OilRecord.VOR_TCode);
         }
          }
         if(vehicles_OilRecord.VOR_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_CompanyCode))
         {
            idb.AddParameter("@VOR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_CompanyCode", vehicles_OilRecord.VOR_CompanyCode);
         }
          }
         if(vehicles_OilRecord.VOR_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_OilRecord.VOR_DeptCode))
         {
            idb.AddParameter("@VOR_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VOR_DeptCode", vehicles_OilRecord.VOR_DeptCode);
         }
          }

         idb.AddParameter("@VOR_ID", vehicles_OilRecord.VOR_ID);

           
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
      /// 删除后勤车辆加油记录 Vehicles_OilRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal vOR_ID)
      {
         string sql = "DELETE Vehicles_OilRecord WHERE 1=1  AND VOR_ID=@VOR_ID ";
         idb.AddParameter("@VOR_ID", vOR_ID);

           
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
      /// 获取指定的后勤车辆加油记录 Vehicles_OilRecord对象(即:一条记录
      /// </summary>
      public Vehicles_OilRecord GetByKey(decimal vOR_ID)
      {
         Vehicles_OilRecord vehicles_OilRecord = new Vehicles_OilRecord();
         string sql = "SELECT  VOR_ID,VOR_Code,VOR_VehiclesNo,VOR_VehiclesCode,VOR_RealCost,VOR_Cost,VOR_Count,VOR_ReturnMoney,VOR_Unit,VOR_Mile,VOR_Date,VOR_Company,VOR_Dept,VOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VOR_itype,VOR_TCode,VOR_CompanyCode,VOR_DeptCode FROM Vehicles_OilRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND VOR_ID=@VOR_ID ";
         idb.AddParameter("@VOR_ID", vOR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["VOR_ID"] != DBNull.Value) vehicles_OilRecord.VOR_ID = Convert.ToDecimal(dr["VOR_ID"]);
            if (dr["VOR_Code"] != DBNull.Value) vehicles_OilRecord.VOR_Code = Convert.ToString(dr["VOR_Code"]);
            if (dr["VOR_VehiclesNo"] != DBNull.Value) vehicles_OilRecord.VOR_VehiclesNo = Convert.ToString(dr["VOR_VehiclesNo"]);
            if (dr["VOR_VehiclesCode"] != DBNull.Value) vehicles_OilRecord.VOR_VehiclesCode = Convert.ToString(dr["VOR_VehiclesCode"]);
            if (dr["VOR_RealCost"] != DBNull.Value) vehicles_OilRecord.VOR_RealCost = Convert.ToDecimal(dr["VOR_RealCost"]);
            if (dr["VOR_Cost"] != DBNull.Value) vehicles_OilRecord.VOR_Cost = Convert.ToDecimal(dr["VOR_Cost"]);
            if (dr["VOR_Count"] != DBNull.Value) vehicles_OilRecord.VOR_Count = Convert.ToDecimal(dr["VOR_Count"]);
            if (dr["VOR_ReturnMoney"] != DBNull.Value) vehicles_OilRecord.VOR_ReturnMoney = Convert.ToDecimal(dr["VOR_ReturnMoney"]);
            if (dr["VOR_Unit"] != DBNull.Value) vehicles_OilRecord.VOR_Unit = Convert.ToString(dr["VOR_Unit"]);
            if (dr["VOR_Mile"] != DBNull.Value) vehicles_OilRecord.VOR_Mile = Convert.ToDecimal(dr["VOR_Mile"]);
            if (dr["VOR_Date"] != DBNull.Value) vehicles_OilRecord.VOR_Date = Convert.ToDateTime(dr["VOR_Date"]);
            if (dr["VOR_Company"] != DBNull.Value) vehicles_OilRecord.VOR_Company = Convert.ToString(dr["VOR_Company"]);
            if (dr["VOR_Dept"] != DBNull.Value) vehicles_OilRecord.VOR_Dept = Convert.ToString(dr["VOR_Dept"]);
            if (dr["VOR_Remark"] != DBNull.Value) vehicles_OilRecord.VOR_Remark = Convert.ToString(dr["VOR_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_OilRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_OilRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_OilRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_OilRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VOR_itype"] != DBNull.Value) vehicles_OilRecord.VOR_itype = Convert.ToString(dr["VOR_itype"]);
            if (dr["VOR_TCode"] != DBNull.Value) vehicles_OilRecord.VOR_TCode = Convert.ToString(dr["VOR_TCode"]);
            if (dr["VOR_CompanyCode"] != DBNull.Value) vehicles_OilRecord.VOR_CompanyCode = Convert.ToString(dr["VOR_CompanyCode"]);
            if (dr["VOR_DeptCode"] != DBNull.Value) vehicles_OilRecord.VOR_DeptCode = Convert.ToString(dr["VOR_DeptCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return vehicles_OilRecord;
      }
      /// <summary>
      /// 获取指定的后勤车辆加油记录 Vehicles_OilRecord对象集合
      /// </summary>
      public List<Vehicles_OilRecord> GetListByWhere(string strCondition)
      {
         List<Vehicles_OilRecord> ret = new List<Vehicles_OilRecord>();
         string sql = "SELECT  VOR_ID,VOR_Code,VOR_VehiclesNo,VOR_VehiclesCode,VOR_RealCost,VOR_Cost,VOR_Count,VOR_ReturnMoney,VOR_Unit,VOR_Mile,VOR_Date,VOR_Company,VOR_Dept,VOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VOR_itype,VOR_TCode,VOR_CompanyCode,VOR_DeptCode FROM Vehicles_OilRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Vehicles_OilRecord vehicles_OilRecord = new Vehicles_OilRecord();
            if (dr["VOR_ID"] != DBNull.Value) vehicles_OilRecord.VOR_ID = Convert.ToDecimal(dr["VOR_ID"]);
            if (dr["VOR_Code"] != DBNull.Value) vehicles_OilRecord.VOR_Code = Convert.ToString(dr["VOR_Code"]);
            if (dr["VOR_VehiclesNo"] != DBNull.Value) vehicles_OilRecord.VOR_VehiclesNo = Convert.ToString(dr["VOR_VehiclesNo"]);
            if (dr["VOR_VehiclesCode"] != DBNull.Value) vehicles_OilRecord.VOR_VehiclesCode = Convert.ToString(dr["VOR_VehiclesCode"]);
            if (dr["VOR_RealCost"] != DBNull.Value) vehicles_OilRecord.VOR_RealCost = Convert.ToDecimal(dr["VOR_RealCost"]);
            if (dr["VOR_Cost"] != DBNull.Value) vehicles_OilRecord.VOR_Cost = Convert.ToDecimal(dr["VOR_Cost"]);
            if (dr["VOR_Count"] != DBNull.Value) vehicles_OilRecord.VOR_Count = Convert.ToDecimal(dr["VOR_Count"]);
            if (dr["VOR_ReturnMoney"] != DBNull.Value) vehicles_OilRecord.VOR_ReturnMoney = Convert.ToDecimal(dr["VOR_ReturnMoney"]);
            if (dr["VOR_Unit"] != DBNull.Value) vehicles_OilRecord.VOR_Unit = Convert.ToString(dr["VOR_Unit"]);
            if (dr["VOR_Mile"] != DBNull.Value) vehicles_OilRecord.VOR_Mile = Convert.ToDecimal(dr["VOR_Mile"]);
            if (dr["VOR_Date"] != DBNull.Value) vehicles_OilRecord.VOR_Date = Convert.ToDateTime(dr["VOR_Date"]);
            if (dr["VOR_Company"] != DBNull.Value) vehicles_OilRecord.VOR_Company = Convert.ToString(dr["VOR_Company"]);
            if (dr["VOR_Dept"] != DBNull.Value) vehicles_OilRecord.VOR_Dept = Convert.ToString(dr["VOR_Dept"]);
            if (dr["VOR_Remark"] != DBNull.Value) vehicles_OilRecord.VOR_Remark = Convert.ToString(dr["VOR_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_OilRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_OilRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_OilRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_OilRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VOR_itype"] != DBNull.Value) vehicles_OilRecord.VOR_itype = Convert.ToString(dr["VOR_itype"]);
            if (dr["VOR_TCode"] != DBNull.Value) vehicles_OilRecord.VOR_TCode = Convert.ToString(dr["VOR_TCode"]);
            if (dr["VOR_CompanyCode"] != DBNull.Value) vehicles_OilRecord.VOR_CompanyCode = Convert.ToString(dr["VOR_CompanyCode"]);
            if (dr["VOR_DeptCode"] != DBNull.Value) vehicles_OilRecord.VOR_DeptCode = Convert.ToString(dr["VOR_DeptCode"]);
            ret.Add(vehicles_OilRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的后勤车辆加油记录 Vehicles_OilRecord对象(即:一条记录
      /// </summary>
      public List<Vehicles_OilRecord> GetAll()
      {
         List<Vehicles_OilRecord> ret = new List<Vehicles_OilRecord>();
         string sql = "SELECT  VOR_ID,VOR_Code,VOR_VehiclesNo,VOR_VehiclesCode,VOR_RealCost,VOR_Cost,VOR_Count,VOR_ReturnMoney,VOR_Unit,VOR_Mile,VOR_Date,VOR_Company,VOR_Dept,VOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VOR_itype,VOR_TCode,VOR_CompanyCode,VOR_DeptCode FROM Vehicles_OilRecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by VOR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Vehicles_OilRecord vehicles_OilRecord = new Vehicles_OilRecord();
            if (dr["VOR_ID"] != DBNull.Value) vehicles_OilRecord.VOR_ID = Convert.ToDecimal(dr["VOR_ID"]);
            if (dr["VOR_Code"] != DBNull.Value) vehicles_OilRecord.VOR_Code = Convert.ToString(dr["VOR_Code"]);
            if (dr["VOR_VehiclesNo"] != DBNull.Value) vehicles_OilRecord.VOR_VehiclesNo = Convert.ToString(dr["VOR_VehiclesNo"]);
            if (dr["VOR_VehiclesCode"] != DBNull.Value) vehicles_OilRecord.VOR_VehiclesCode = Convert.ToString(dr["VOR_VehiclesCode"]);
            if (dr["VOR_RealCost"] != DBNull.Value) vehicles_OilRecord.VOR_RealCost = Convert.ToDecimal(dr["VOR_RealCost"]);
            if (dr["VOR_Cost"] != DBNull.Value) vehicles_OilRecord.VOR_Cost = Convert.ToDecimal(dr["VOR_Cost"]);
            if (dr["VOR_Count"] != DBNull.Value) vehicles_OilRecord.VOR_Count = Convert.ToDecimal(dr["VOR_Count"]);
            if (dr["VOR_ReturnMoney"] != DBNull.Value) vehicles_OilRecord.VOR_ReturnMoney = Convert.ToDecimal(dr["VOR_ReturnMoney"]);
            if (dr["VOR_Unit"] != DBNull.Value) vehicles_OilRecord.VOR_Unit = Convert.ToString(dr["VOR_Unit"]);
            if (dr["VOR_Mile"] != DBNull.Value) vehicles_OilRecord.VOR_Mile = Convert.ToDecimal(dr["VOR_Mile"]);
            if (dr["VOR_Date"] != DBNull.Value) vehicles_OilRecord.VOR_Date = Convert.ToDateTime(dr["VOR_Date"]);
            if (dr["VOR_Company"] != DBNull.Value) vehicles_OilRecord.VOR_Company = Convert.ToString(dr["VOR_Company"]);
            if (dr["VOR_Dept"] != DBNull.Value) vehicles_OilRecord.VOR_Dept = Convert.ToString(dr["VOR_Dept"]);
            if (dr["VOR_Remark"] != DBNull.Value) vehicles_OilRecord.VOR_Remark = Convert.ToString(dr["VOR_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_OilRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_OilRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_OilRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_OilRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VOR_itype"] != DBNull.Value) vehicles_OilRecord.VOR_itype = Convert.ToString(dr["VOR_itype"]);
            if (dr["VOR_TCode"] != DBNull.Value) vehicles_OilRecord.VOR_TCode = Convert.ToString(dr["VOR_TCode"]);
            if (dr["VOR_CompanyCode"] != DBNull.Value) vehicles_OilRecord.VOR_CompanyCode = Convert.ToString(dr["VOR_CompanyCode"]);
            if (dr["VOR_DeptCode"] != DBNull.Value) vehicles_OilRecord.VOR_DeptCode = Convert.ToString(dr["VOR_DeptCode"]);
            ret.Add(vehicles_OilRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
