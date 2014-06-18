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
   /// 后勤车辆交接记录
   /// </summary>
   [Serializable]
   public partial class ADOVehicles_ChangedRecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加后勤车辆交接记录 Vehicles_ChangedRecord对象(即:一条记录)
      /// </summary>
      public int Add(Vehicles_ChangedRecord vehicles_ChangedRecord)
      {
         string sql = "INSERT INTO Vehicles_ChangedRecord (VCRecord_Code,VCRecord_VehiclesNo,VCRecord_VehiclesCode,VCRecord_Date,VCRecord_CheckPosition,VCRecord_WrongPosition,VCRecord_HandleMethod,VCRecord_Changer,VCRecord_Receiver,VCRecord_Remark,VCRecord_Company,VCRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate,VCRecord_itype) VALUES (@VCRecord_Code,@VCRecord_VehiclesNo,@VCRecord_VehiclesCode,@VCRecord_Date,@VCRecord_CheckPosition,@VCRecord_WrongPosition,@VCRecord_HandleMethod,@VCRecord_Changer,@VCRecord_Receiver,@VCRecord_Remark,@VCRecord_Company,@VCRecord_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VCRecord_itype)";
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Code))
         {
            idb.AddParameter("@VCRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Code", vehicles_ChangedRecord.VCRecord_Code);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_VehiclesNo))
         {
            idb.AddParameter("@VCRecord_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_VehiclesNo", vehicles_ChangedRecord.VCRecord_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_VehiclesCode))
         {
            idb.AddParameter("@VCRecord_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_VehiclesCode", vehicles_ChangedRecord.VCRecord_VehiclesCode);
         }
         if (vehicles_ChangedRecord.VCRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VCRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Date", vehicles_ChangedRecord.VCRecord_Date);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_CheckPosition))
         {
            idb.AddParameter("@VCRecord_CheckPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_CheckPosition", vehicles_ChangedRecord.VCRecord_CheckPosition);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_WrongPosition))
         {
            idb.AddParameter("@VCRecord_WrongPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_WrongPosition", vehicles_ChangedRecord.VCRecord_WrongPosition);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_HandleMethod))
         {
            idb.AddParameter("@VCRecord_HandleMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_HandleMethod", vehicles_ChangedRecord.VCRecord_HandleMethod);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Changer))
         {
            idb.AddParameter("@VCRecord_Changer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Changer", vehicles_ChangedRecord.VCRecord_Changer);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Receiver))
         {
            idb.AddParameter("@VCRecord_Receiver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Receiver", vehicles_ChangedRecord.VCRecord_Receiver);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Remark))
         {
            idb.AddParameter("@VCRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Remark", vehicles_ChangedRecord.VCRecord_Remark);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Company))
         {
            idb.AddParameter("@VCRecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Company", vehicles_ChangedRecord.VCRecord_Company);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Dept))
         {
            idb.AddParameter("@VCRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Dept", vehicles_ChangedRecord.VCRecord_Dept);
         }
         if (vehicles_ChangedRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_ChangedRecord.Stat);
         }
         if (vehicles_ChangedRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_ChangedRecord.CreateDate);
         }
         if (vehicles_ChangedRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_ChangedRecord.UpdateDate);
         }
         if (vehicles_ChangedRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_ChangedRecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_itype))
         {
            idb.AddParameter("@VCRecord_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_itype", vehicles_ChangedRecord.VCRecord_itype);
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
      /// 添加后勤车辆交接记录 Vehicles_ChangedRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Vehicles_ChangedRecord vehicles_ChangedRecord)
      {
         string sql = "INSERT INTO Vehicles_ChangedRecord (VCRecord_Code,VCRecord_VehiclesNo,VCRecord_VehiclesCode,VCRecord_Date,VCRecord_CheckPosition,VCRecord_WrongPosition,VCRecord_HandleMethod,VCRecord_Changer,VCRecord_Receiver,VCRecord_Remark,VCRecord_Company,VCRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate,VCRecord_itype) VALUES (@VCRecord_Code,@VCRecord_VehiclesNo,@VCRecord_VehiclesCode,@VCRecord_Date,@VCRecord_CheckPosition,@VCRecord_WrongPosition,@VCRecord_HandleMethod,@VCRecord_Changer,@VCRecord_Receiver,@VCRecord_Remark,@VCRecord_Company,@VCRecord_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VCRecord_itype);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Code))
         {
            idb.AddParameter("@VCRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Code", vehicles_ChangedRecord.VCRecord_Code);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_VehiclesNo))
         {
            idb.AddParameter("@VCRecord_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_VehiclesNo", vehicles_ChangedRecord.VCRecord_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_VehiclesCode))
         {
            idb.AddParameter("@VCRecord_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_VehiclesCode", vehicles_ChangedRecord.VCRecord_VehiclesCode);
         }
         if (vehicles_ChangedRecord.VCRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VCRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Date", vehicles_ChangedRecord.VCRecord_Date);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_CheckPosition))
         {
            idb.AddParameter("@VCRecord_CheckPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_CheckPosition", vehicles_ChangedRecord.VCRecord_CheckPosition);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_WrongPosition))
         {
            idb.AddParameter("@VCRecord_WrongPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_WrongPosition", vehicles_ChangedRecord.VCRecord_WrongPosition);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_HandleMethod))
         {
            idb.AddParameter("@VCRecord_HandleMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_HandleMethod", vehicles_ChangedRecord.VCRecord_HandleMethod);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Changer))
         {
            idb.AddParameter("@VCRecord_Changer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Changer", vehicles_ChangedRecord.VCRecord_Changer);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Receiver))
         {
            idb.AddParameter("@VCRecord_Receiver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Receiver", vehicles_ChangedRecord.VCRecord_Receiver);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Remark))
         {
            idb.AddParameter("@VCRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Remark", vehicles_ChangedRecord.VCRecord_Remark);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Company))
         {
            idb.AddParameter("@VCRecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Company", vehicles_ChangedRecord.VCRecord_Company);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Dept))
         {
            idb.AddParameter("@VCRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Dept", vehicles_ChangedRecord.VCRecord_Dept);
         }
         if (vehicles_ChangedRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_ChangedRecord.Stat);
         }
         if (vehicles_ChangedRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_ChangedRecord.CreateDate);
         }
         if (vehicles_ChangedRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_ChangedRecord.UpdateDate);
         }
         if (vehicles_ChangedRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_ChangedRecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_itype))
         {
            idb.AddParameter("@VCRecord_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_itype", vehicles_ChangedRecord.VCRecord_itype);
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
      /// 更新后勤车辆交接记录 Vehicles_ChangedRecord对象(即:一条记录
      /// </summary>
      public int Update(Vehicles_ChangedRecord vehicles_ChangedRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Vehicles_ChangedRecord       SET ");
            if(vehicles_ChangedRecord.VCRecord_Code_IsChanged){sbParameter.Append("VCRecord_Code=@VCRecord_Code, ");}
      if(vehicles_ChangedRecord.VCRecord_VehiclesNo_IsChanged){sbParameter.Append("VCRecord_VehiclesNo=@VCRecord_VehiclesNo, ");}
      if(vehicles_ChangedRecord.VCRecord_VehiclesCode_IsChanged){sbParameter.Append("VCRecord_VehiclesCode=@VCRecord_VehiclesCode, ");}
      if(vehicles_ChangedRecord.VCRecord_Date_IsChanged){sbParameter.Append("VCRecord_Date=@VCRecord_Date, ");}
      if(vehicles_ChangedRecord.VCRecord_CheckPosition_IsChanged){sbParameter.Append("VCRecord_CheckPosition=@VCRecord_CheckPosition, ");}
      if(vehicles_ChangedRecord.VCRecord_WrongPosition_IsChanged){sbParameter.Append("VCRecord_WrongPosition=@VCRecord_WrongPosition, ");}
      if(vehicles_ChangedRecord.VCRecord_HandleMethod_IsChanged){sbParameter.Append("VCRecord_HandleMethod=@VCRecord_HandleMethod, ");}
      if(vehicles_ChangedRecord.VCRecord_Changer_IsChanged){sbParameter.Append("VCRecord_Changer=@VCRecord_Changer, ");}
      if(vehicles_ChangedRecord.VCRecord_Receiver_IsChanged){sbParameter.Append("VCRecord_Receiver=@VCRecord_Receiver, ");}
      if(vehicles_ChangedRecord.VCRecord_Remark_IsChanged){sbParameter.Append("VCRecord_Remark=@VCRecord_Remark, ");}
      if(vehicles_ChangedRecord.VCRecord_Company_IsChanged){sbParameter.Append("VCRecord_Company=@VCRecord_Company, ");}
      if(vehicles_ChangedRecord.VCRecord_Dept_IsChanged){sbParameter.Append("VCRecord_Dept=@VCRecord_Dept, ");}
      if(vehicles_ChangedRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(vehicles_ChangedRecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(vehicles_ChangedRecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(vehicles_ChangedRecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(vehicles_ChangedRecord.VCRecord_itype_IsChanged){sbParameter.Append("VCRecord_itype=@VCRecord_itype ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and VCRecord_ID=@VCRecord_ID; " );
      string sql=sb.ToString();
         if(vehicles_ChangedRecord.VCRecord_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Code))
         {
            idb.AddParameter("@VCRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Code", vehicles_ChangedRecord.VCRecord_Code);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_VehiclesNo))
         {
            idb.AddParameter("@VCRecord_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_VehiclesNo", vehicles_ChangedRecord.VCRecord_VehiclesNo);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_VehiclesCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_VehiclesCode))
         {
            idb.AddParameter("@VCRecord_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_VehiclesCode", vehicles_ChangedRecord.VCRecord_VehiclesCode);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_Date_IsChanged)
         {
         if (vehicles_ChangedRecord.VCRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VCRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Date", vehicles_ChangedRecord.VCRecord_Date);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_CheckPosition_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_CheckPosition))
         {
            idb.AddParameter("@VCRecord_CheckPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_CheckPosition", vehicles_ChangedRecord.VCRecord_CheckPosition);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_WrongPosition_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_WrongPosition))
         {
            idb.AddParameter("@VCRecord_WrongPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_WrongPosition", vehicles_ChangedRecord.VCRecord_WrongPosition);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_HandleMethod_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_HandleMethod))
         {
            idb.AddParameter("@VCRecord_HandleMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_HandleMethod", vehicles_ChangedRecord.VCRecord_HandleMethod);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_Changer_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Changer))
         {
            idb.AddParameter("@VCRecord_Changer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Changer", vehicles_ChangedRecord.VCRecord_Changer);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_Receiver_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Receiver))
         {
            idb.AddParameter("@VCRecord_Receiver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Receiver", vehicles_ChangedRecord.VCRecord_Receiver);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Remark))
         {
            idb.AddParameter("@VCRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Remark", vehicles_ChangedRecord.VCRecord_Remark);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Company))
         {
            idb.AddParameter("@VCRecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Company", vehicles_ChangedRecord.VCRecord_Company);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_Dept))
         {
            idb.AddParameter("@VCRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_Dept", vehicles_ChangedRecord.VCRecord_Dept);
         }
          }
         if(vehicles_ChangedRecord.Stat_IsChanged)
         {
         if (vehicles_ChangedRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_ChangedRecord.Stat);
         }
          }
         if(vehicles_ChangedRecord.CreateDate_IsChanged)
         {
         if (vehicles_ChangedRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_ChangedRecord.CreateDate);
         }
          }
         if(vehicles_ChangedRecord.UpdateDate_IsChanged)
         {
         if (vehicles_ChangedRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_ChangedRecord.UpdateDate);
         }
          }
         if(vehicles_ChangedRecord.DeleteDate_IsChanged)
         {
         if (vehicles_ChangedRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_ChangedRecord.DeleteDate);
         }
          }
         if(vehicles_ChangedRecord.VCRecord_itype_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_ChangedRecord.VCRecord_itype))
         {
            idb.AddParameter("@VCRecord_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VCRecord_itype", vehicles_ChangedRecord.VCRecord_itype);
         }
          }

         idb.AddParameter("@VCRecord_ID", vehicles_ChangedRecord.VCRecord_ID);

           
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
      /// 删除后勤车辆交接记录 Vehicles_ChangedRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal vCRecord_ID)
      {
         string sql = "DELETE Vehicles_ChangedRecord WHERE 1=1  AND VCRecord_ID=@VCRecord_ID ";
         idb.AddParameter("@VCRecord_ID", vCRecord_ID);

           
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
      /// 获取指定的后勤车辆交接记录 Vehicles_ChangedRecord对象(即:一条记录
      /// </summary>
      public Vehicles_ChangedRecord GetByKey(decimal vCRecord_ID)
      {
         Vehicles_ChangedRecord vehicles_ChangedRecord = new Vehicles_ChangedRecord();
         string sql = "SELECT  VCRecord_ID,VCRecord_Code,VCRecord_VehiclesNo,VCRecord_VehiclesCode,VCRecord_Date,VCRecord_CheckPosition,VCRecord_WrongPosition,VCRecord_HandleMethod,VCRecord_Changer,VCRecord_Receiver,VCRecord_Remark,VCRecord_Company,VCRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate,VCRecord_itype FROM Vehicles_ChangedRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND VCRecord_ID=@VCRecord_ID ";
         idb.AddParameter("@VCRecord_ID", vCRecord_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["VCRecord_ID"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_ID = Convert.ToDecimal(dr["VCRecord_ID"]);
            if (dr["VCRecord_Code"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Code = Convert.ToString(dr["VCRecord_Code"]);
            if (dr["VCRecord_VehiclesNo"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_VehiclesNo = Convert.ToString(dr["VCRecord_VehiclesNo"]);
            if (dr["VCRecord_VehiclesCode"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_VehiclesCode = Convert.ToString(dr["VCRecord_VehiclesCode"]);
            if (dr["VCRecord_Date"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Date = Convert.ToDateTime(dr["VCRecord_Date"]);
            if (dr["VCRecord_CheckPosition"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_CheckPosition = Convert.ToString(dr["VCRecord_CheckPosition"]);
            if (dr["VCRecord_WrongPosition"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_WrongPosition = Convert.ToString(dr["VCRecord_WrongPosition"]);
            if (dr["VCRecord_HandleMethod"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_HandleMethod = Convert.ToString(dr["VCRecord_HandleMethod"]);
            if (dr["VCRecord_Changer"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Changer = Convert.ToString(dr["VCRecord_Changer"]);
            if (dr["VCRecord_Receiver"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Receiver = Convert.ToString(dr["VCRecord_Receiver"]);
            if (dr["VCRecord_Remark"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Remark = Convert.ToString(dr["VCRecord_Remark"]);
            if (dr["VCRecord_Company"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Company = Convert.ToString(dr["VCRecord_Company"]);
            if (dr["VCRecord_Dept"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Dept = Convert.ToString(dr["VCRecord_Dept"]);
            if (dr["Stat"] != DBNull.Value) vehicles_ChangedRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_ChangedRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_ChangedRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_ChangedRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VCRecord_itype"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_itype = Convert.ToString(dr["VCRecord_itype"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return vehicles_ChangedRecord;
      }
      /// <summary>
      /// 获取指定的后勤车辆交接记录 Vehicles_ChangedRecord对象集合
      /// </summary>
      public List<Vehicles_ChangedRecord> GetListByWhere(string strCondition)
      {
         List<Vehicles_ChangedRecord> ret = new List<Vehicles_ChangedRecord>();
         string sql = "SELECT  VCRecord_ID,VCRecord_Code,VCRecord_VehiclesNo,VCRecord_VehiclesCode,VCRecord_Date,VCRecord_CheckPosition,VCRecord_WrongPosition,VCRecord_HandleMethod,VCRecord_Changer,VCRecord_Receiver,VCRecord_Remark,VCRecord_Company,VCRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate,VCRecord_itype FROM Vehicles_ChangedRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Vehicles_ChangedRecord vehicles_ChangedRecord = new Vehicles_ChangedRecord();
            if (dr["VCRecord_ID"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_ID = Convert.ToDecimal(dr["VCRecord_ID"]);
            if (dr["VCRecord_Code"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Code = Convert.ToString(dr["VCRecord_Code"]);
            if (dr["VCRecord_VehiclesNo"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_VehiclesNo = Convert.ToString(dr["VCRecord_VehiclesNo"]);
            if (dr["VCRecord_VehiclesCode"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_VehiclesCode = Convert.ToString(dr["VCRecord_VehiclesCode"]);
            if (dr["VCRecord_Date"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Date = Convert.ToDateTime(dr["VCRecord_Date"]);
            if (dr["VCRecord_CheckPosition"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_CheckPosition = Convert.ToString(dr["VCRecord_CheckPosition"]);
            if (dr["VCRecord_WrongPosition"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_WrongPosition = Convert.ToString(dr["VCRecord_WrongPosition"]);
            if (dr["VCRecord_HandleMethod"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_HandleMethod = Convert.ToString(dr["VCRecord_HandleMethod"]);
            if (dr["VCRecord_Changer"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Changer = Convert.ToString(dr["VCRecord_Changer"]);
            if (dr["VCRecord_Receiver"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Receiver = Convert.ToString(dr["VCRecord_Receiver"]);
            if (dr["VCRecord_Remark"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Remark = Convert.ToString(dr["VCRecord_Remark"]);
            if (dr["VCRecord_Company"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Company = Convert.ToString(dr["VCRecord_Company"]);
            if (dr["VCRecord_Dept"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Dept = Convert.ToString(dr["VCRecord_Dept"]);
            if (dr["Stat"] != DBNull.Value) vehicles_ChangedRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_ChangedRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_ChangedRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_ChangedRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VCRecord_itype"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_itype = Convert.ToString(dr["VCRecord_itype"]);
            ret.Add(vehicles_ChangedRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的后勤车辆交接记录 Vehicles_ChangedRecord对象(即:一条记录
      /// </summary>
      public List<Vehicles_ChangedRecord> GetAll()
      {
         List<Vehicles_ChangedRecord> ret = new List<Vehicles_ChangedRecord>();
         string sql = "SELECT  VCRecord_ID,VCRecord_Code,VCRecord_VehiclesNo,VCRecord_VehiclesCode,VCRecord_Date,VCRecord_CheckPosition,VCRecord_WrongPosition,VCRecord_HandleMethod,VCRecord_Changer,VCRecord_Receiver,VCRecord_Remark,VCRecord_Company,VCRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate,VCRecord_itype FROM Vehicles_ChangedRecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by VCRecord_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Vehicles_ChangedRecord vehicles_ChangedRecord = new Vehicles_ChangedRecord();
            if (dr["VCRecord_ID"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_ID = Convert.ToDecimal(dr["VCRecord_ID"]);
            if (dr["VCRecord_Code"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Code = Convert.ToString(dr["VCRecord_Code"]);
            if (dr["VCRecord_VehiclesNo"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_VehiclesNo = Convert.ToString(dr["VCRecord_VehiclesNo"]);
            if (dr["VCRecord_VehiclesCode"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_VehiclesCode = Convert.ToString(dr["VCRecord_VehiclesCode"]);
            if (dr["VCRecord_Date"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Date = Convert.ToDateTime(dr["VCRecord_Date"]);
            if (dr["VCRecord_CheckPosition"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_CheckPosition = Convert.ToString(dr["VCRecord_CheckPosition"]);
            if (dr["VCRecord_WrongPosition"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_WrongPosition = Convert.ToString(dr["VCRecord_WrongPosition"]);
            if (dr["VCRecord_HandleMethod"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_HandleMethod = Convert.ToString(dr["VCRecord_HandleMethod"]);
            if (dr["VCRecord_Changer"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Changer = Convert.ToString(dr["VCRecord_Changer"]);
            if (dr["VCRecord_Receiver"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Receiver = Convert.ToString(dr["VCRecord_Receiver"]);
            if (dr["VCRecord_Remark"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Remark = Convert.ToString(dr["VCRecord_Remark"]);
            if (dr["VCRecord_Company"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Company = Convert.ToString(dr["VCRecord_Company"]);
            if (dr["VCRecord_Dept"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_Dept = Convert.ToString(dr["VCRecord_Dept"]);
            if (dr["Stat"] != DBNull.Value) vehicles_ChangedRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_ChangedRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_ChangedRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_ChangedRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VCRecord_itype"] != DBNull.Value) vehicles_ChangedRecord.VCRecord_itype = Convert.ToString(dr["VCRecord_itype"]);
            ret.Add(vehicles_ChangedRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
