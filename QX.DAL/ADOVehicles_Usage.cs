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
   /// 后勤车辆外派记录
   /// </summary>
   [Serializable]
   public partial class ADOVehicles_Usage
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加后勤车辆外派记录 Vehicles_Usage对象(即:一条记录)
      /// </summary>
      public int Add(Vehicles_Usage vehicles_Usage)
      {
         string sql = "INSERT INTO Vehicles_Usage (Usage_Code,Usage_VehiclesNo,Usage_VehiclesCode,Usage_Date,Usage_UseDept,Usage_User,Usage_Company,Usage_Dept,Usage_Reason,Usage_RoadCost,Usage_ParkingCost,Usage_TravelCost,Usage_Pilot,Usage_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Usage_Code,@Usage_VehiclesNo,@Usage_VehiclesCode,@Usage_Date,@Usage_UseDept,@Usage_User,@Usage_Company,@Usage_Dept,@Usage_Reason,@Usage_RoadCost,@Usage_ParkingCost,@Usage_TravelCost,@Usage_Pilot,@Usage_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Code))
         {
            idb.AddParameter("@Usage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Code", vehicles_Usage.Usage_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_VehiclesNo))
         {
            idb.AddParameter("@Usage_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_VehiclesNo", vehicles_Usage.Usage_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_VehiclesCode))
         {
            idb.AddParameter("@Usage_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_VehiclesCode", vehicles_Usage.Usage_VehiclesCode);
         }
         if (vehicles_Usage.Usage_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Usage_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Date", vehicles_Usage.Usage_Date);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_UseDept))
         {
            idb.AddParameter("@Usage_UseDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_UseDept", vehicles_Usage.Usage_UseDept);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_User))
         {
            idb.AddParameter("@Usage_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_User", vehicles_Usage.Usage_User);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Company))
         {
            idb.AddParameter("@Usage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Company", vehicles_Usage.Usage_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Dept))
         {
            idb.AddParameter("@Usage_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Dept", vehicles_Usage.Usage_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Reason))
         {
            idb.AddParameter("@Usage_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Reason", vehicles_Usage.Usage_Reason);
         }
         if (vehicles_Usage.Usage_RoadCost == 0)
         {
            idb.AddParameter("@Usage_RoadCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_RoadCost", vehicles_Usage.Usage_RoadCost);
         }
         if (vehicles_Usage.Usage_ParkingCost == 0)
         {
            idb.AddParameter("@Usage_ParkingCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_ParkingCost", vehicles_Usage.Usage_ParkingCost);
         }
         if (vehicles_Usage.Usage_TravelCost == 0)
         {
            idb.AddParameter("@Usage_TravelCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_TravelCost", vehicles_Usage.Usage_TravelCost);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Pilot))
         {
            idb.AddParameter("@Usage_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Pilot", vehicles_Usage.Usage_Pilot);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Remark))
         {
            idb.AddParameter("@Usage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Remark", vehicles_Usage.Usage_Remark);
         }
         if (vehicles_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Usage.Stat);
         }
         if (vehicles_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Usage.CreateDate);
         }
         if (vehicles_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Usage.UpdateDate);
         }
         if (vehicles_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Usage.DeleteDate);
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
      /// 添加后勤车辆外派记录 Vehicles_Usage对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Vehicles_Usage vehicles_Usage)
      {
         string sql = "INSERT INTO Vehicles_Usage (Usage_Code,Usage_VehiclesNo,Usage_VehiclesCode,Usage_Date,Usage_UseDept,Usage_User,Usage_Company,Usage_Dept,Usage_Reason,Usage_RoadCost,Usage_ParkingCost,Usage_TravelCost,Usage_Pilot,Usage_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Usage_Code,@Usage_VehiclesNo,@Usage_VehiclesCode,@Usage_Date,@Usage_UseDept,@Usage_User,@Usage_Company,@Usage_Dept,@Usage_Reason,@Usage_RoadCost,@Usage_ParkingCost,@Usage_TravelCost,@Usage_Pilot,@Usage_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Code))
         {
            idb.AddParameter("@Usage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Code", vehicles_Usage.Usage_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_VehiclesNo))
         {
            idb.AddParameter("@Usage_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_VehiclesNo", vehicles_Usage.Usage_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_VehiclesCode))
         {
            idb.AddParameter("@Usage_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_VehiclesCode", vehicles_Usage.Usage_VehiclesCode);
         }
         if (vehicles_Usage.Usage_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Usage_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Date", vehicles_Usage.Usage_Date);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_UseDept))
         {
            idb.AddParameter("@Usage_UseDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_UseDept", vehicles_Usage.Usage_UseDept);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_User))
         {
            idb.AddParameter("@Usage_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_User", vehicles_Usage.Usage_User);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Company))
         {
            idb.AddParameter("@Usage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Company", vehicles_Usage.Usage_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Dept))
         {
            idb.AddParameter("@Usage_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Dept", vehicles_Usage.Usage_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Reason))
         {
            idb.AddParameter("@Usage_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Reason", vehicles_Usage.Usage_Reason);
         }
         if (vehicles_Usage.Usage_RoadCost == 0)
         {
            idb.AddParameter("@Usage_RoadCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_RoadCost", vehicles_Usage.Usage_RoadCost);
         }
         if (vehicles_Usage.Usage_ParkingCost == 0)
         {
            idb.AddParameter("@Usage_ParkingCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_ParkingCost", vehicles_Usage.Usage_ParkingCost);
         }
         if (vehicles_Usage.Usage_TravelCost == 0)
         {
            idb.AddParameter("@Usage_TravelCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_TravelCost", vehicles_Usage.Usage_TravelCost);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Pilot))
         {
            idb.AddParameter("@Usage_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Pilot", vehicles_Usage.Usage_Pilot);
         }
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Remark))
         {
            idb.AddParameter("@Usage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Remark", vehicles_Usage.Usage_Remark);
         }
         if (vehicles_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Usage.Stat);
         }
         if (vehicles_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Usage.CreateDate);
         }
         if (vehicles_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Usage.UpdateDate);
         }
         if (vehicles_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Usage.DeleteDate);
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
      /// 更新后勤车辆外派记录 Vehicles_Usage对象(即:一条记录
      /// </summary>
      public int Update(Vehicles_Usage vehicles_Usage)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Vehicles_Usage       SET ");
            if(vehicles_Usage.Usage_Code_IsChanged){sbParameter.Append("Usage_Code=@Usage_Code, ");}
      if(vehicles_Usage.Usage_VehiclesNo_IsChanged){sbParameter.Append("Usage_VehiclesNo=@Usage_VehiclesNo, ");}
      if(vehicles_Usage.Usage_VehiclesCode_IsChanged){sbParameter.Append("Usage_VehiclesCode=@Usage_VehiclesCode, ");}
      if(vehicles_Usage.Usage_Date_IsChanged){sbParameter.Append("Usage_Date=@Usage_Date, ");}
      if(vehicles_Usage.Usage_UseDept_IsChanged){sbParameter.Append("Usage_UseDept=@Usage_UseDept, ");}
      if(vehicles_Usage.Usage_User_IsChanged){sbParameter.Append("Usage_User=@Usage_User, ");}
      if(vehicles_Usage.Usage_Company_IsChanged){sbParameter.Append("Usage_Company=@Usage_Company, ");}
      if(vehicles_Usage.Usage_Dept_IsChanged){sbParameter.Append("Usage_Dept=@Usage_Dept, ");}
      if(vehicles_Usage.Usage_Reason_IsChanged){sbParameter.Append("Usage_Reason=@Usage_Reason, ");}
      if(vehicles_Usage.Usage_RoadCost_IsChanged){sbParameter.Append("Usage_RoadCost=@Usage_RoadCost, ");}
      if(vehicles_Usage.Usage_ParkingCost_IsChanged){sbParameter.Append("Usage_ParkingCost=@Usage_ParkingCost, ");}
      if(vehicles_Usage.Usage_TravelCost_IsChanged){sbParameter.Append("Usage_TravelCost=@Usage_TravelCost, ");}
      if(vehicles_Usage.Usage_Pilot_IsChanged){sbParameter.Append("Usage_Pilot=@Usage_Pilot, ");}
      if(vehicles_Usage.Usage_Remark_IsChanged){sbParameter.Append("Usage_Remark=@Usage_Remark, ");}
      if(vehicles_Usage.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(vehicles_Usage.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(vehicles_Usage.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(vehicles_Usage.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Usage_ID=@Usage_ID; " );
      string sql=sb.ToString();
         if(vehicles_Usage.Usage_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Code))
         {
            idb.AddParameter("@Usage_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Code", vehicles_Usage.Usage_Code);
         }
          }
         if(vehicles_Usage.Usage_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_VehiclesNo))
         {
            idb.AddParameter("@Usage_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_VehiclesNo", vehicles_Usage.Usage_VehiclesNo);
         }
          }
         if(vehicles_Usage.Usage_VehiclesCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_VehiclesCode))
         {
            idb.AddParameter("@Usage_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_VehiclesCode", vehicles_Usage.Usage_VehiclesCode);
         }
          }
         if(vehicles_Usage.Usage_Date_IsChanged)
         {
         if (vehicles_Usage.Usage_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Usage_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Date", vehicles_Usage.Usage_Date);
         }
          }
         if(vehicles_Usage.Usage_UseDept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_UseDept))
         {
            idb.AddParameter("@Usage_UseDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_UseDept", vehicles_Usage.Usage_UseDept);
         }
          }
         if(vehicles_Usage.Usage_User_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_User))
         {
            idb.AddParameter("@Usage_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_User", vehicles_Usage.Usage_User);
         }
          }
         if(vehicles_Usage.Usage_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Company))
         {
            idb.AddParameter("@Usage_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Company", vehicles_Usage.Usage_Company);
         }
          }
         if(vehicles_Usage.Usage_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Dept))
         {
            idb.AddParameter("@Usage_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Dept", vehicles_Usage.Usage_Dept);
         }
          }
         if(vehicles_Usage.Usage_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Reason))
         {
            idb.AddParameter("@Usage_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Reason", vehicles_Usage.Usage_Reason);
         }
          }
         if(vehicles_Usage.Usage_RoadCost_IsChanged)
         {
         if (vehicles_Usage.Usage_RoadCost == 0)
         {
            idb.AddParameter("@Usage_RoadCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_RoadCost", vehicles_Usage.Usage_RoadCost);
         }
          }
         if(vehicles_Usage.Usage_ParkingCost_IsChanged)
         {
         if (vehicles_Usage.Usage_ParkingCost == 0)
         {
            idb.AddParameter("@Usage_ParkingCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_ParkingCost", vehicles_Usage.Usage_ParkingCost);
         }
          }
         if(vehicles_Usage.Usage_TravelCost_IsChanged)
         {
         if (vehicles_Usage.Usage_TravelCost == 0)
         {
            idb.AddParameter("@Usage_TravelCost", 0);
         }
         else
         {
            idb.AddParameter("@Usage_TravelCost", vehicles_Usage.Usage_TravelCost);
         }
          }
         if(vehicles_Usage.Usage_Pilot_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Pilot))
         {
            idb.AddParameter("@Usage_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Pilot", vehicles_Usage.Usage_Pilot);
         }
          }
         if(vehicles_Usage.Usage_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Usage.Usage_Remark))
         {
            idb.AddParameter("@Usage_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Usage_Remark", vehicles_Usage.Usage_Remark);
         }
          }
         if(vehicles_Usage.Stat_IsChanged)
         {
         if (vehicles_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Usage.Stat);
         }
          }
         if(vehicles_Usage.CreateDate_IsChanged)
         {
         if (vehicles_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Usage.CreateDate);
         }
          }
         if(vehicles_Usage.UpdateDate_IsChanged)
         {
         if (vehicles_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Usage.UpdateDate);
         }
          }
         if(vehicles_Usage.DeleteDate_IsChanged)
         {
         if (vehicles_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Usage.DeleteDate);
         }
          }

         idb.AddParameter("@Usage_ID", vehicles_Usage.Usage_ID);

           
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
      /// 删除后勤车辆外派记录 Vehicles_Usage对象(即:一条记录
      /// </summary>
      public int Delete(decimal usage_ID)
      {
         string sql = "DELETE Vehicles_Usage WHERE 1=1  AND Usage_ID=@Usage_ID ";
         idb.AddParameter("@Usage_ID", usage_ID);

           
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
      /// 获取指定的后勤车辆外派记录 Vehicles_Usage对象(即:一条记录
      /// </summary>
      public Vehicles_Usage GetByKey(decimal usage_ID)
      {
         Vehicles_Usage vehicles_Usage = new Vehicles_Usage();
         string sql = "SELECT  Usage_ID,Usage_Code,Usage_VehiclesNo,Usage_VehiclesCode,Usage_Date,Usage_UseDept,Usage_User,Usage_Company,Usage_Dept,Usage_Reason,Usage_RoadCost,Usage_ParkingCost,Usage_TravelCost,Usage_Pilot,Usage_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Vehicles_Usage WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Usage_ID=@Usage_ID ";
         idb.AddParameter("@Usage_ID", usage_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Usage_ID"] != DBNull.Value) vehicles_Usage.Usage_ID = Convert.ToDecimal(dr["Usage_ID"]);
            if (dr["Usage_Code"] != DBNull.Value) vehicles_Usage.Usage_Code = Convert.ToString(dr["Usage_Code"]);
            if (dr["Usage_VehiclesNo"] != DBNull.Value) vehicles_Usage.Usage_VehiclesNo = Convert.ToString(dr["Usage_VehiclesNo"]);
            if (dr["Usage_VehiclesCode"] != DBNull.Value) vehicles_Usage.Usage_VehiclesCode = Convert.ToString(dr["Usage_VehiclesCode"]);
            if (dr["Usage_Date"] != DBNull.Value) vehicles_Usage.Usage_Date = Convert.ToDateTime(dr["Usage_Date"]);
            if (dr["Usage_UseDept"] != DBNull.Value) vehicles_Usage.Usage_UseDept = Convert.ToString(dr["Usage_UseDept"]);
            if (dr["Usage_User"] != DBNull.Value) vehicles_Usage.Usage_User = Convert.ToString(dr["Usage_User"]);
            if (dr["Usage_Company"] != DBNull.Value) vehicles_Usage.Usage_Company = Convert.ToString(dr["Usage_Company"]);
            if (dr["Usage_Dept"] != DBNull.Value) vehicles_Usage.Usage_Dept = Convert.ToString(dr["Usage_Dept"]);
            if (dr["Usage_Reason"] != DBNull.Value) vehicles_Usage.Usage_Reason = Convert.ToString(dr["Usage_Reason"]);
            if (dr["Usage_RoadCost"] != DBNull.Value) vehicles_Usage.Usage_RoadCost = Convert.ToDecimal(dr["Usage_RoadCost"]);
            if (dr["Usage_ParkingCost"] != DBNull.Value) vehicles_Usage.Usage_ParkingCost = Convert.ToDecimal(dr["Usage_ParkingCost"]);
            if (dr["Usage_TravelCost"] != DBNull.Value) vehicles_Usage.Usage_TravelCost = Convert.ToDecimal(dr["Usage_TravelCost"]);
            if (dr["Usage_Pilot"] != DBNull.Value) vehicles_Usage.Usage_Pilot = Convert.ToString(dr["Usage_Pilot"]);
            if (dr["Usage_Remark"] != DBNull.Value) vehicles_Usage.Usage_Remark = Convert.ToString(dr["Usage_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return vehicles_Usage;
      }
      /// <summary>
      /// 获取指定的后勤车辆外派记录 Vehicles_Usage对象集合
      /// </summary>
      public List<Vehicles_Usage> GetListByWhere(string strCondition)
      {
         List<Vehicles_Usage> ret = new List<Vehicles_Usage>();
         string sql = "SELECT  Usage_ID,Usage_Code,Usage_VehiclesNo,Usage_VehiclesCode,Usage_Date,Usage_UseDept,Usage_User,Usage_Company,Usage_Dept,Usage_Reason,Usage_RoadCost,Usage_ParkingCost,Usage_TravelCost,Usage_Pilot,Usage_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Vehicles_Usage WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Vehicles_Usage vehicles_Usage = new Vehicles_Usage();
            if (dr["Usage_ID"] != DBNull.Value) vehicles_Usage.Usage_ID = Convert.ToDecimal(dr["Usage_ID"]);
            if (dr["Usage_Code"] != DBNull.Value) vehicles_Usage.Usage_Code = Convert.ToString(dr["Usage_Code"]);
            if (dr["Usage_VehiclesNo"] != DBNull.Value) vehicles_Usage.Usage_VehiclesNo = Convert.ToString(dr["Usage_VehiclesNo"]);
            if (dr["Usage_VehiclesCode"] != DBNull.Value) vehicles_Usage.Usage_VehiclesCode = Convert.ToString(dr["Usage_VehiclesCode"]);
            if (dr["Usage_Date"] != DBNull.Value) vehicles_Usage.Usage_Date = Convert.ToDateTime(dr["Usage_Date"]);
            if (dr["Usage_UseDept"] != DBNull.Value) vehicles_Usage.Usage_UseDept = Convert.ToString(dr["Usage_UseDept"]);
            if (dr["Usage_User"] != DBNull.Value) vehicles_Usage.Usage_User = Convert.ToString(dr["Usage_User"]);
            if (dr["Usage_Company"] != DBNull.Value) vehicles_Usage.Usage_Company = Convert.ToString(dr["Usage_Company"]);
            if (dr["Usage_Dept"] != DBNull.Value) vehicles_Usage.Usage_Dept = Convert.ToString(dr["Usage_Dept"]);
            if (dr["Usage_Reason"] != DBNull.Value) vehicles_Usage.Usage_Reason = Convert.ToString(dr["Usage_Reason"]);
            if (dr["Usage_RoadCost"] != DBNull.Value) vehicles_Usage.Usage_RoadCost = Convert.ToDecimal(dr["Usage_RoadCost"]);
            if (dr["Usage_ParkingCost"] != DBNull.Value) vehicles_Usage.Usage_ParkingCost = Convert.ToDecimal(dr["Usage_ParkingCost"]);
            if (dr["Usage_TravelCost"] != DBNull.Value) vehicles_Usage.Usage_TravelCost = Convert.ToDecimal(dr["Usage_TravelCost"]);
            if (dr["Usage_Pilot"] != DBNull.Value) vehicles_Usage.Usage_Pilot = Convert.ToString(dr["Usage_Pilot"]);
            if (dr["Usage_Remark"] != DBNull.Value) vehicles_Usage.Usage_Remark = Convert.ToString(dr["Usage_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(vehicles_Usage);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的后勤车辆外派记录 Vehicles_Usage对象(即:一条记录
      /// </summary>
      public List<Vehicles_Usage> GetAll()
      {
         List<Vehicles_Usage> ret = new List<Vehicles_Usage>();
         string sql = "SELECT  Usage_ID,Usage_Code,Usage_VehiclesNo,Usage_VehiclesCode,Usage_Date,Usage_UseDept,Usage_User,Usage_Company,Usage_Dept,Usage_Reason,Usage_RoadCost,Usage_ParkingCost,Usage_TravelCost,Usage_Pilot,Usage_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Vehicles_Usage where 1=1 AND ((Stat is null) or (Stat=0) ) order by Usage_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Vehicles_Usage vehicles_Usage = new Vehicles_Usage();
            if (dr["Usage_ID"] != DBNull.Value) vehicles_Usage.Usage_ID = Convert.ToDecimal(dr["Usage_ID"]);
            if (dr["Usage_Code"] != DBNull.Value) vehicles_Usage.Usage_Code = Convert.ToString(dr["Usage_Code"]);
            if (dr["Usage_VehiclesNo"] != DBNull.Value) vehicles_Usage.Usage_VehiclesNo = Convert.ToString(dr["Usage_VehiclesNo"]);
            if (dr["Usage_VehiclesCode"] != DBNull.Value) vehicles_Usage.Usage_VehiclesCode = Convert.ToString(dr["Usage_VehiclesCode"]);
            if (dr["Usage_Date"] != DBNull.Value) vehicles_Usage.Usage_Date = Convert.ToDateTime(dr["Usage_Date"]);
            if (dr["Usage_UseDept"] != DBNull.Value) vehicles_Usage.Usage_UseDept = Convert.ToString(dr["Usage_UseDept"]);
            if (dr["Usage_User"] != DBNull.Value) vehicles_Usage.Usage_User = Convert.ToString(dr["Usage_User"]);
            if (dr["Usage_Company"] != DBNull.Value) vehicles_Usage.Usage_Company = Convert.ToString(dr["Usage_Company"]);
            if (dr["Usage_Dept"] != DBNull.Value) vehicles_Usage.Usage_Dept = Convert.ToString(dr["Usage_Dept"]);
            if (dr["Usage_Reason"] != DBNull.Value) vehicles_Usage.Usage_Reason = Convert.ToString(dr["Usage_Reason"]);
            if (dr["Usage_RoadCost"] != DBNull.Value) vehicles_Usage.Usage_RoadCost = Convert.ToDecimal(dr["Usage_RoadCost"]);
            if (dr["Usage_ParkingCost"] != DBNull.Value) vehicles_Usage.Usage_ParkingCost = Convert.ToDecimal(dr["Usage_ParkingCost"]);
            if (dr["Usage_TravelCost"] != DBNull.Value) vehicles_Usage.Usage_TravelCost = Convert.ToDecimal(dr["Usage_TravelCost"]);
            if (dr["Usage_Pilot"] != DBNull.Value) vehicles_Usage.Usage_Pilot = Convert.ToString(dr["Usage_Pilot"]);
            if (dr["Usage_Remark"] != DBNull.Value) vehicles_Usage.Usage_Remark = Convert.ToString(dr["Usage_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(vehicles_Usage);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
