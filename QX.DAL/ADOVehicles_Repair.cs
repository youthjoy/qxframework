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
   /// 后勤车辆维修记录
   /// </summary>
   [Serializable]
   public partial class ADOVehicles_Repair
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加后勤车辆维修记录 Vehicles_Repair对象(即:一条记录)
      /// </summary>
      public int Add(Vehicles_Repair vehicles_Repair)
      {
         string sql = "INSERT INTO Vehicles_Repair (VRepair_Code,VRepair_VehiclesNo,VRepair_VehiclesCode,VRepair_Date,VRepair_Object,VRepair_Material,VRepair_TimeCost,VRepair_Cost,VRepair_Position,VRepair_Operator,VRepair_Company,VRepair_Dept,VRepair_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VRepair_itype) VALUES (@VRepair_Code,@VRepair_VehiclesNo,@VRepair_VehiclesCode,@VRepair_Date,@VRepair_Object,@VRepair_Material,@VRepair_TimeCost,@VRepair_Cost,@VRepair_Position,@VRepair_Operator,@VRepair_Company,@VRepair_Dept,@VRepair_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VRepair_itype)";
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Code))
         {
            idb.AddParameter("@VRepair_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Code", vehicles_Repair.VRepair_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_VehiclesNo))
         {
            idb.AddParameter("@VRepair_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_VehiclesNo", vehicles_Repair.VRepair_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_VehiclesCode))
         {
            idb.AddParameter("@VRepair_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_VehiclesCode", vehicles_Repair.VRepair_VehiclesCode);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Date))
         {
            idb.AddParameter("@VRepair_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Date", vehicles_Repair.VRepair_Date);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Object))
         {
            idb.AddParameter("@VRepair_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Object", vehicles_Repair.VRepair_Object);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Material))
         {
            idb.AddParameter("@VRepair_Material", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Material", vehicles_Repair.VRepair_Material);
         }
         if (vehicles_Repair.VRepair_TimeCost == 0)
         {
            idb.AddParameter("@VRepair_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@VRepair_TimeCost", vehicles_Repair.VRepair_TimeCost);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Cost))
         {
            idb.AddParameter("@VRepair_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Cost", vehicles_Repair.VRepair_Cost);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Position))
         {
            idb.AddParameter("@VRepair_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Position", vehicles_Repair.VRepair_Position);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Operator))
         {
            idb.AddParameter("@VRepair_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Operator", vehicles_Repair.VRepair_Operator);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Company))
         {
            idb.AddParameter("@VRepair_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Company", vehicles_Repair.VRepair_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Dept))
         {
            idb.AddParameter("@VRepair_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Dept", vehicles_Repair.VRepair_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Remark))
         {
            idb.AddParameter("@VRepair_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Remark", vehicles_Repair.VRepair_Remark);
         }
         if (vehicles_Repair.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Repair.Stat);
         }
         if (vehicles_Repair.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Repair.CreateDate);
         }
         if (vehicles_Repair.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Repair.UpdateDate);
         }
         if (vehicles_Repair.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Repair.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_itype))
         {
            idb.AddParameter("@VRepair_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_itype", vehicles_Repair.VRepair_itype);
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
      /// 添加后勤车辆维修记录 Vehicles_Repair对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Vehicles_Repair vehicles_Repair)
      {
         string sql = "INSERT INTO Vehicles_Repair (VRepair_Code,VRepair_VehiclesNo,VRepair_VehiclesCode,VRepair_Date,VRepair_Object,VRepair_Material,VRepair_TimeCost,VRepair_Cost,VRepair_Position,VRepair_Operator,VRepair_Company,VRepair_Dept,VRepair_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VRepair_itype) VALUES (@VRepair_Code,@VRepair_VehiclesNo,@VRepair_VehiclesCode,@VRepair_Date,@VRepair_Object,@VRepair_Material,@VRepair_TimeCost,@VRepair_Cost,@VRepair_Position,@VRepair_Operator,@VRepair_Company,@VRepair_Dept,@VRepair_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VRepair_itype);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Code))
         {
            idb.AddParameter("@VRepair_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Code", vehicles_Repair.VRepair_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_VehiclesNo))
         {
            idb.AddParameter("@VRepair_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_VehiclesNo", vehicles_Repair.VRepair_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_VehiclesCode))
         {
            idb.AddParameter("@VRepair_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_VehiclesCode", vehicles_Repair.VRepair_VehiclesCode);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Date))
         {
            idb.AddParameter("@VRepair_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Date", vehicles_Repair.VRepair_Date);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Object))
         {
            idb.AddParameter("@VRepair_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Object", vehicles_Repair.VRepair_Object);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Material))
         {
            idb.AddParameter("@VRepair_Material", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Material", vehicles_Repair.VRepair_Material);
         }
         if (vehicles_Repair.VRepair_TimeCost == 0)
         {
            idb.AddParameter("@VRepair_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@VRepair_TimeCost", vehicles_Repair.VRepair_TimeCost);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Cost))
         {
            idb.AddParameter("@VRepair_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Cost", vehicles_Repair.VRepair_Cost);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Position))
         {
            idb.AddParameter("@VRepair_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Position", vehicles_Repair.VRepair_Position);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Operator))
         {
            idb.AddParameter("@VRepair_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Operator", vehicles_Repair.VRepair_Operator);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Company))
         {
            idb.AddParameter("@VRepair_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Company", vehicles_Repair.VRepair_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Dept))
         {
            idb.AddParameter("@VRepair_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Dept", vehicles_Repair.VRepair_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Remark))
         {
            idb.AddParameter("@VRepair_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Remark", vehicles_Repair.VRepair_Remark);
         }
         if (vehicles_Repair.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Repair.Stat);
         }
         if (vehicles_Repair.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Repair.CreateDate);
         }
         if (vehicles_Repair.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Repair.UpdateDate);
         }
         if (vehicles_Repair.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Repair.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_itype))
         {
            idb.AddParameter("@VRepair_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_itype", vehicles_Repair.VRepair_itype);
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
      /// 更新后勤车辆维修记录 Vehicles_Repair对象(即:一条记录
      /// </summary>
      public int Update(Vehicles_Repair vehicles_Repair)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Vehicles_Repair       SET ");
            if(vehicles_Repair.VRepair_Code_IsChanged){sbParameter.Append("VRepair_Code=@VRepair_Code, ");}
      if(vehicles_Repair.VRepair_VehiclesNo_IsChanged){sbParameter.Append("VRepair_VehiclesNo=@VRepair_VehiclesNo, ");}
      if(vehicles_Repair.VRepair_VehiclesCode_IsChanged){sbParameter.Append("VRepair_VehiclesCode=@VRepair_VehiclesCode, ");}
      if(vehicles_Repair.VRepair_Date_IsChanged){sbParameter.Append("VRepair_Date=@VRepair_Date, ");}
      if(vehicles_Repair.VRepair_Object_IsChanged){sbParameter.Append("VRepair_Object=@VRepair_Object, ");}
      if(vehicles_Repair.VRepair_Material_IsChanged){sbParameter.Append("VRepair_Material=@VRepair_Material, ");}
      if(vehicles_Repair.VRepair_TimeCost_IsChanged){sbParameter.Append("VRepair_TimeCost=@VRepair_TimeCost, ");}
      if(vehicles_Repair.VRepair_Cost_IsChanged){sbParameter.Append("VRepair_Cost=@VRepair_Cost, ");}
      if(vehicles_Repair.VRepair_Position_IsChanged){sbParameter.Append("VRepair_Position=@VRepair_Position, ");}
      if(vehicles_Repair.VRepair_Operator_IsChanged){sbParameter.Append("VRepair_Operator=@VRepair_Operator, ");}
      if(vehicles_Repair.VRepair_Company_IsChanged){sbParameter.Append("VRepair_Company=@VRepair_Company, ");}
      if(vehicles_Repair.VRepair_Dept_IsChanged){sbParameter.Append("VRepair_Dept=@VRepair_Dept, ");}
      if(vehicles_Repair.VRepair_Remark_IsChanged){sbParameter.Append("VRepair_Remark=@VRepair_Remark, ");}
      if(vehicles_Repair.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(vehicles_Repair.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(vehicles_Repair.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(vehicles_Repair.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(vehicles_Repair.VRepair_itype_IsChanged){sbParameter.Append("VRepair_itype=@VRepair_itype ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and VRepair_ID=@VRepair_ID; " );
      string sql=sb.ToString();
         if(vehicles_Repair.VRepair_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Code))
         {
            idb.AddParameter("@VRepair_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Code", vehicles_Repair.VRepair_Code);
         }
          }
         if(vehicles_Repair.VRepair_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_VehiclesNo))
         {
            idb.AddParameter("@VRepair_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_VehiclesNo", vehicles_Repair.VRepair_VehiclesNo);
         }
          }
         if(vehicles_Repair.VRepair_VehiclesCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_VehiclesCode))
         {
            idb.AddParameter("@VRepair_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_VehiclesCode", vehicles_Repair.VRepair_VehiclesCode);
         }
          }
         if(vehicles_Repair.VRepair_Date_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Date))
         {
            idb.AddParameter("@VRepair_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Date", vehicles_Repair.VRepair_Date);
         }
          }
         if(vehicles_Repair.VRepair_Object_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Object))
         {
            idb.AddParameter("@VRepair_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Object", vehicles_Repair.VRepair_Object);
         }
          }
         if(vehicles_Repair.VRepair_Material_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Material))
         {
            idb.AddParameter("@VRepair_Material", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Material", vehicles_Repair.VRepair_Material);
         }
          }
         if(vehicles_Repair.VRepair_TimeCost_IsChanged)
         {
         if (vehicles_Repair.VRepair_TimeCost == 0)
         {
            idb.AddParameter("@VRepair_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@VRepair_TimeCost", vehicles_Repair.VRepair_TimeCost);
         }
          }
         if(vehicles_Repair.VRepair_Cost_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Cost))
         {
            idb.AddParameter("@VRepair_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Cost", vehicles_Repair.VRepair_Cost);
         }
          }
         if(vehicles_Repair.VRepair_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Position))
         {
            idb.AddParameter("@VRepair_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Position", vehicles_Repair.VRepair_Position);
         }
          }
         if(vehicles_Repair.VRepair_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Operator))
         {
            idb.AddParameter("@VRepair_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Operator", vehicles_Repair.VRepair_Operator);
         }
          }
         if(vehicles_Repair.VRepair_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Company))
         {
            idb.AddParameter("@VRepair_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Company", vehicles_Repair.VRepair_Company);
         }
          }
         if(vehicles_Repair.VRepair_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Dept))
         {
            idb.AddParameter("@VRepair_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Dept", vehicles_Repair.VRepair_Dept);
         }
          }
         if(vehicles_Repair.VRepair_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_Remark))
         {
            idb.AddParameter("@VRepair_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_Remark", vehicles_Repair.VRepair_Remark);
         }
          }
         if(vehicles_Repair.Stat_IsChanged)
         {
         if (vehicles_Repair.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Repair.Stat);
         }
          }
         if(vehicles_Repair.CreateDate_IsChanged)
         {
         if (vehicles_Repair.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Repair.CreateDate);
         }
          }
         if(vehicles_Repair.UpdateDate_IsChanged)
         {
         if (vehicles_Repair.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Repair.UpdateDate);
         }
          }
         if(vehicles_Repair.DeleteDate_IsChanged)
         {
         if (vehicles_Repair.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Repair.DeleteDate);
         }
          }
         if(vehicles_Repair.VRepair_itype_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Repair.VRepair_itype))
         {
            idb.AddParameter("@VRepair_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VRepair_itype", vehicles_Repair.VRepair_itype);
         }
          }

         idb.AddParameter("@VRepair_ID", vehicles_Repair.VRepair_ID);

           
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
      /// 删除后勤车辆维修记录 Vehicles_Repair对象(即:一条记录
      /// </summary>
      public int Delete(decimal vRepair_ID)
      {
         string sql = "DELETE Vehicles_Repair WHERE 1=1  AND VRepair_ID=@VRepair_ID ";
         idb.AddParameter("@VRepair_ID", vRepair_ID);

           
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
      /// 获取指定的后勤车辆维修记录 Vehicles_Repair对象(即:一条记录
      /// </summary>
      public Vehicles_Repair GetByKey(decimal vRepair_ID)
      {
         Vehicles_Repair vehicles_Repair = new Vehicles_Repair();
         string sql = "SELECT  VRepair_ID,VRepair_Code,VRepair_VehiclesNo,VRepair_VehiclesCode,VRepair_Date,VRepair_Object,VRepair_Material,VRepair_TimeCost,VRepair_Cost,VRepair_Position,VRepair_Operator,VRepair_Company,VRepair_Dept,VRepair_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VRepair_itype FROM Vehicles_Repair WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND VRepair_ID=@VRepair_ID ";
         idb.AddParameter("@VRepair_ID", vRepair_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["VRepair_ID"] != DBNull.Value) vehicles_Repair.VRepair_ID = Convert.ToDecimal(dr["VRepair_ID"]);
            if (dr["VRepair_Code"] != DBNull.Value) vehicles_Repair.VRepair_Code = Convert.ToString(dr["VRepair_Code"]);
            if (dr["VRepair_VehiclesNo"] != DBNull.Value) vehicles_Repair.VRepair_VehiclesNo = Convert.ToString(dr["VRepair_VehiclesNo"]);
            if (dr["VRepair_VehiclesCode"] != DBNull.Value) vehicles_Repair.VRepair_VehiclesCode = Convert.ToString(dr["VRepair_VehiclesCode"]);
            if (dr["VRepair_Date"] != DBNull.Value) vehicles_Repair.VRepair_Date = Convert.ToString(dr["VRepair_Date"]);
            if (dr["VRepair_Object"] != DBNull.Value) vehicles_Repair.VRepair_Object = Convert.ToString(dr["VRepair_Object"]);
            if (dr["VRepair_Material"] != DBNull.Value) vehicles_Repair.VRepair_Material = Convert.ToString(dr["VRepair_Material"]);
            if (dr["VRepair_TimeCost"] != DBNull.Value) vehicles_Repair.VRepair_TimeCost = Convert.ToSingle(dr["VRepair_TimeCost"]);
            if (dr["VRepair_Cost"] != DBNull.Value) vehicles_Repair.VRepair_Cost = Convert.ToString(dr["VRepair_Cost"]);
            if (dr["VRepair_Position"] != DBNull.Value) vehicles_Repair.VRepair_Position = Convert.ToString(dr["VRepair_Position"]);
            if (dr["VRepair_Operator"] != DBNull.Value) vehicles_Repair.VRepair_Operator = Convert.ToString(dr["VRepair_Operator"]);
            if (dr["VRepair_Company"] != DBNull.Value) vehicles_Repair.VRepair_Company = Convert.ToString(dr["VRepair_Company"]);
            if (dr["VRepair_Dept"] != DBNull.Value) vehicles_Repair.VRepair_Dept = Convert.ToString(dr["VRepair_Dept"]);
            if (dr["VRepair_Remark"] != DBNull.Value) vehicles_Repair.VRepair_Remark = Convert.ToString(dr["VRepair_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Repair.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Repair.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Repair.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Repair.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VRepair_itype"] != DBNull.Value) vehicles_Repair.VRepair_itype = Convert.ToString(dr["VRepair_itype"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return vehicles_Repair;
      }
      /// <summary>
      /// 获取指定的后勤车辆维修记录 Vehicles_Repair对象集合
      /// </summary>
      public List<Vehicles_Repair> GetListByWhere(string strCondition)
      {
         List<Vehicles_Repair> ret = new List<Vehicles_Repair>();
         string sql = "SELECT  VRepair_ID,VRepair_Code,VRepair_VehiclesNo,VRepair_VehiclesCode,VRepair_Date,VRepair_Object,VRepair_Material,VRepair_TimeCost,VRepair_Cost,VRepair_Position,VRepair_Operator,VRepair_Company,VRepair_Dept,VRepair_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VRepair_itype FROM Vehicles_Repair WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Vehicles_Repair vehicles_Repair = new Vehicles_Repair();
            if (dr["VRepair_ID"] != DBNull.Value) vehicles_Repair.VRepair_ID = Convert.ToDecimal(dr["VRepair_ID"]);
            if (dr["VRepair_Code"] != DBNull.Value) vehicles_Repair.VRepair_Code = Convert.ToString(dr["VRepair_Code"]);
            if (dr["VRepair_VehiclesNo"] != DBNull.Value) vehicles_Repair.VRepair_VehiclesNo = Convert.ToString(dr["VRepair_VehiclesNo"]);
            if (dr["VRepair_VehiclesCode"] != DBNull.Value) vehicles_Repair.VRepair_VehiclesCode = Convert.ToString(dr["VRepair_VehiclesCode"]);
            if (dr["VRepair_Date"] != DBNull.Value) vehicles_Repair.VRepair_Date = Convert.ToString(dr["VRepair_Date"]);
            if (dr["VRepair_Object"] != DBNull.Value) vehicles_Repair.VRepair_Object = Convert.ToString(dr["VRepair_Object"]);
            if (dr["VRepair_Material"] != DBNull.Value) vehicles_Repair.VRepair_Material = Convert.ToString(dr["VRepair_Material"]);
            if (dr["VRepair_TimeCost"] != DBNull.Value) vehicles_Repair.VRepair_TimeCost = Convert.ToSingle(dr["VRepair_TimeCost"]);
            if (dr["VRepair_Cost"] != DBNull.Value) vehicles_Repair.VRepair_Cost = Convert.ToString(dr["VRepair_Cost"]);
            if (dr["VRepair_Position"] != DBNull.Value) vehicles_Repair.VRepair_Position = Convert.ToString(dr["VRepair_Position"]);
            if (dr["VRepair_Operator"] != DBNull.Value) vehicles_Repair.VRepair_Operator = Convert.ToString(dr["VRepair_Operator"]);
            if (dr["VRepair_Company"] != DBNull.Value) vehicles_Repair.VRepair_Company = Convert.ToString(dr["VRepair_Company"]);
            if (dr["VRepair_Dept"] != DBNull.Value) vehicles_Repair.VRepair_Dept = Convert.ToString(dr["VRepair_Dept"]);
            if (dr["VRepair_Remark"] != DBNull.Value) vehicles_Repair.VRepair_Remark = Convert.ToString(dr["VRepair_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Repair.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Repair.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Repair.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Repair.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VRepair_itype"] != DBNull.Value) vehicles_Repair.VRepair_itype = Convert.ToString(dr["VRepair_itype"]);
            ret.Add(vehicles_Repair);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的后勤车辆维修记录 Vehicles_Repair对象(即:一条记录
      /// </summary>
      public List<Vehicles_Repair> GetAll()
      {
         List<Vehicles_Repair> ret = new List<Vehicles_Repair>();
         string sql = "SELECT  VRepair_ID,VRepair_Code,VRepair_VehiclesNo,VRepair_VehiclesCode,VRepair_Date,VRepair_Object,VRepair_Material,VRepair_TimeCost,VRepair_Cost,VRepair_Position,VRepair_Operator,VRepair_Company,VRepair_Dept,VRepair_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VRepair_itype FROM Vehicles_Repair where 1=1 AND ((Stat is null) or (Stat=0) ) order by VRepair_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Vehicles_Repair vehicles_Repair = new Vehicles_Repair();
            if (dr["VRepair_ID"] != DBNull.Value) vehicles_Repair.VRepair_ID = Convert.ToDecimal(dr["VRepair_ID"]);
            if (dr["VRepair_Code"] != DBNull.Value) vehicles_Repair.VRepair_Code = Convert.ToString(dr["VRepair_Code"]);
            if (dr["VRepair_VehiclesNo"] != DBNull.Value) vehicles_Repair.VRepair_VehiclesNo = Convert.ToString(dr["VRepair_VehiclesNo"]);
            if (dr["VRepair_VehiclesCode"] != DBNull.Value) vehicles_Repair.VRepair_VehiclesCode = Convert.ToString(dr["VRepair_VehiclesCode"]);
            if (dr["VRepair_Date"] != DBNull.Value) vehicles_Repair.VRepair_Date = Convert.ToString(dr["VRepair_Date"]);
            if (dr["VRepair_Object"] != DBNull.Value) vehicles_Repair.VRepair_Object = Convert.ToString(dr["VRepair_Object"]);
            if (dr["VRepair_Material"] != DBNull.Value) vehicles_Repair.VRepair_Material = Convert.ToString(dr["VRepair_Material"]);
            if (dr["VRepair_TimeCost"] != DBNull.Value) vehicles_Repair.VRepair_TimeCost = Convert.ToSingle(dr["VRepair_TimeCost"]);
            if (dr["VRepair_Cost"] != DBNull.Value) vehicles_Repair.VRepair_Cost = Convert.ToString(dr["VRepair_Cost"]);
            if (dr["VRepair_Position"] != DBNull.Value) vehicles_Repair.VRepair_Position = Convert.ToString(dr["VRepair_Position"]);
            if (dr["VRepair_Operator"] != DBNull.Value) vehicles_Repair.VRepair_Operator = Convert.ToString(dr["VRepair_Operator"]);
            if (dr["VRepair_Company"] != DBNull.Value) vehicles_Repair.VRepair_Company = Convert.ToString(dr["VRepair_Company"]);
            if (dr["VRepair_Dept"] != DBNull.Value) vehicles_Repair.VRepair_Dept = Convert.ToString(dr["VRepair_Dept"]);
            if (dr["VRepair_Remark"] != DBNull.Value) vehicles_Repair.VRepair_Remark = Convert.ToString(dr["VRepair_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Repair.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Repair.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Repair.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Repair.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VRepair_itype"] != DBNull.Value) vehicles_Repair.VRepair_itype = Convert.ToString(dr["VRepair_itype"]);
            ret.Add(vehicles_Repair);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
