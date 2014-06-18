using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOGPSRecord
   {
      public IDBOperator idb =  DBOperator.GetGPSInstance();
      /// <summary>
      /// 添加GPSRecord对象(即:一条记录)
      /// </summary>
      public int Add(GPSRecord gPSRecord)
      {
         string sql = "INSERT INTO GPSRecord (License_Plate,Terminal_ID,PlateColor,DataType,GPSTime,Longitude,Latitude,GPSFlag,Speed,Direction,Comm_Type,MDTStatus,MDTAlarm,Data_Length,DataContend,Stat,CreateTime) VALUES (@License_Plate,@Terminal_ID,@PlateColor,@DataType,@GPSTime,@Longitude,@Latitude,@GPSFlag,@Speed,@Direction,@Comm_Type,@MDTStatus,@MDTAlarm,@Data_Length,@DataContend,@Stat,@CreateTime)";
         if (string.IsNullOrEmpty(gPSRecord.License_Plate))
         {
            idb.AddParameter("@License_Plate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@License_Plate", gPSRecord.License_Plate);
         }
         if (string.IsNullOrEmpty(gPSRecord.Terminal_ID))
         {
            idb.AddParameter("@Terminal_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Terminal_ID", gPSRecord.Terminal_ID);
         }
         if (gPSRecord.PlateColor == 0)
         {
            idb.AddParameter("@PlateColor", 0);
         }
         else
         {
            idb.AddParameter("@PlateColor", gPSRecord.PlateColor);
         }
         if (gPSRecord.DataType == 0)
         {
            idb.AddParameter("@DataType", 0);
         }
         else
         {
            idb.AddParameter("@DataType", gPSRecord.DataType);
         }
         if (gPSRecord.GPSTime == DateTime.MinValue)
         {
            idb.AddParameter("@GPSTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GPSTime", gPSRecord.GPSTime);
         }
         if (gPSRecord.Longitude == 0)
         {
            idb.AddParameter("@Longitude", 0);
         }
         else
         {
            idb.AddParameter("@Longitude", gPSRecord.Longitude);
         }
         if (gPSRecord.Latitude == 0)
         {
            idb.AddParameter("@Latitude", 0);
         }
         else
         {
            idb.AddParameter("@Latitude", gPSRecord.Latitude);
         }
         if (gPSRecord.GPSFlag == 0)
         {
            idb.AddParameter("@GPSFlag", 0);
         }
         else
         {
            idb.AddParameter("@GPSFlag", gPSRecord.GPSFlag);
         }
         if (gPSRecord.Speed == 0)
         {
            idb.AddParameter("@Speed", 0);
         }
         else
         {
            idb.AddParameter("@Speed", gPSRecord.Speed);
         }
         if (gPSRecord.Direction == 0)
         {
            idb.AddParameter("@Direction", 0);
         }
         else
         {
            idb.AddParameter("@Direction", gPSRecord.Direction);
         }
         if (gPSRecord.Comm_Type == 0)
         {
            idb.AddParameter("@Comm_Type", 0);
         }
         else
         {
            idb.AddParameter("@Comm_Type", gPSRecord.Comm_Type);
         }
         if (gPSRecord.MDTStatus == 0)
         {
            idb.AddParameter("@MDTStatus", 0);
         }
         else
         {
            idb.AddParameter("@MDTStatus", gPSRecord.MDTStatus);
         }
         if (gPSRecord.MDTAlarm == 0)
         {
            idb.AddParameter("@MDTAlarm", 0);
         }
         else
         {
            idb.AddParameter("@MDTAlarm", gPSRecord.MDTAlarm);
         }
         if (gPSRecord.Data_Length == 0)
         {
            idb.AddParameter("@Data_Length", 0);
         }
         else
         {
            idb.AddParameter("@Data_Length", gPSRecord.Data_Length);
         }
         if (string.IsNullOrEmpty(gPSRecord.DataContend))
         {
            idb.AddParameter("@DataContend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DataContend", gPSRecord.DataContend);
         }
         if (gPSRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gPSRecord.Stat);
         }
         if (gPSRecord.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", gPSRecord.CreateTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加GPSRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(GPSRecord gPSRecord)
      {
         string sql = "INSERT INTO GPSRecord (License_Plate,Terminal_ID,PlateColor,DataType,GPSTime,Longitude,Latitude,GPSFlag,Speed,Direction,Comm_Type,MDTStatus,MDTAlarm,Data_Length,DataContend,Stat,CreateTime) VALUES (@License_Plate,@Terminal_ID,@PlateColor,@DataType,@GPSTime,@Longitude,@Latitude,@GPSFlag,@Speed,@Direction,@Comm_Type,@MDTStatus,@MDTAlarm,@Data_Length,@DataContend,@Stat,@CreateTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(gPSRecord.License_Plate))
         {
            idb.AddParameter("@License_Plate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@License_Plate", gPSRecord.License_Plate);
         }
         if (string.IsNullOrEmpty(gPSRecord.Terminal_ID))
         {
            idb.AddParameter("@Terminal_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Terminal_ID", gPSRecord.Terminal_ID);
         }
         if (gPSRecord.PlateColor == 0)
         {
            idb.AddParameter("@PlateColor", 0);
         }
         else
         {
            idb.AddParameter("@PlateColor", gPSRecord.PlateColor);
         }
         if (gPSRecord.DataType == 0)
         {
            idb.AddParameter("@DataType", 0);
         }
         else
         {
            idb.AddParameter("@DataType", gPSRecord.DataType);
         }
         if (gPSRecord.GPSTime == DateTime.MinValue)
         {
            idb.AddParameter("@GPSTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GPSTime", gPSRecord.GPSTime);
         }
         if (gPSRecord.Longitude == 0)
         {
            idb.AddParameter("@Longitude", 0);
         }
         else
         {
            idb.AddParameter("@Longitude", gPSRecord.Longitude);
         }
         if (gPSRecord.Latitude == 0)
         {
            idb.AddParameter("@Latitude", 0);
         }
         else
         {
            idb.AddParameter("@Latitude", gPSRecord.Latitude);
         }
         if (gPSRecord.GPSFlag == 0)
         {
            idb.AddParameter("@GPSFlag", 0);
         }
         else
         {
            idb.AddParameter("@GPSFlag", gPSRecord.GPSFlag);
         }
         if (gPSRecord.Speed == 0)
         {
            idb.AddParameter("@Speed", 0);
         }
         else
         {
            idb.AddParameter("@Speed", gPSRecord.Speed);
         }
         if (gPSRecord.Direction == 0)
         {
            idb.AddParameter("@Direction", 0);
         }
         else
         {
            idb.AddParameter("@Direction", gPSRecord.Direction);
         }
         if (gPSRecord.Comm_Type == 0)
         {
            idb.AddParameter("@Comm_Type", 0);
         }
         else
         {
            idb.AddParameter("@Comm_Type", gPSRecord.Comm_Type);
         }
         if (gPSRecord.MDTStatus == 0)
         {
            idb.AddParameter("@MDTStatus", 0);
         }
         else
         {
            idb.AddParameter("@MDTStatus", gPSRecord.MDTStatus);
         }
         if (gPSRecord.MDTAlarm == 0)
         {
            idb.AddParameter("@MDTAlarm", 0);
         }
         else
         {
            idb.AddParameter("@MDTAlarm", gPSRecord.MDTAlarm);
         }
         if (gPSRecord.Data_Length == 0)
         {
            idb.AddParameter("@Data_Length", 0);
         }
         else
         {
            idb.AddParameter("@Data_Length", gPSRecord.Data_Length);
         }
         if (string.IsNullOrEmpty(gPSRecord.DataContend))
         {
            idb.AddParameter("@DataContend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DataContend", gPSRecord.DataContend);
         }
         if (gPSRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gPSRecord.Stat);
         }
         if (gPSRecord.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", gPSRecord.CreateTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新GPSRecord对象(即:一条记录
      /// </summary>
      public int Update(GPSRecord gPSRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       GPSRecord       SET ");
            if(gPSRecord.License_Plate_IsChanged){sbParameter.Append("License_Plate=@License_Plate, ");}
      if(gPSRecord.Terminal_ID_IsChanged){sbParameter.Append("Terminal_ID=@Terminal_ID, ");}
      if(gPSRecord.PlateColor_IsChanged){sbParameter.Append("PlateColor=@PlateColor, ");}
      if(gPSRecord.DataType_IsChanged){sbParameter.Append("DataType=@DataType, ");}
      if(gPSRecord.GPSTime_IsChanged){sbParameter.Append("GPSTime=@GPSTime, ");}
      if(gPSRecord.Longitude_IsChanged){sbParameter.Append("Longitude=@Longitude, ");}
      if(gPSRecord.Latitude_IsChanged){sbParameter.Append("Latitude=@Latitude, ");}
      if(gPSRecord.GPSFlag_IsChanged){sbParameter.Append("GPSFlag=@GPSFlag, ");}
      if(gPSRecord.Speed_IsChanged){sbParameter.Append("Speed=@Speed, ");}
      if(gPSRecord.Direction_IsChanged){sbParameter.Append("Direction=@Direction, ");}
      if(gPSRecord.Comm_Type_IsChanged){sbParameter.Append("Comm_Type=@Comm_Type, ");}
      if(gPSRecord.MDTStatus_IsChanged){sbParameter.Append("MDTStatus=@MDTStatus, ");}
      if(gPSRecord.MDTAlarm_IsChanged){sbParameter.Append("MDTAlarm=@MDTAlarm, ");}
      if(gPSRecord.Data_Length_IsChanged){sbParameter.Append("Data_Length=@Data_Length, ");}
      if(gPSRecord.DataContend_IsChanged){sbParameter.Append("DataContend=@DataContend, ");}
      if(gPSRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(gPSRecord.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Record_ID=@Record_ID; " );
      string sql=sb.ToString();
         if(gPSRecord.License_Plate_IsChanged)
         {
         if (string.IsNullOrEmpty(gPSRecord.License_Plate))
         {
            idb.AddParameter("@License_Plate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@License_Plate", gPSRecord.License_Plate);
         }
          }
         if(gPSRecord.Terminal_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(gPSRecord.Terminal_ID))
         {
            idb.AddParameter("@Terminal_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Terminal_ID", gPSRecord.Terminal_ID);
         }
          }
         if(gPSRecord.PlateColor_IsChanged)
         {
         if (gPSRecord.PlateColor == 0)
         {
            idb.AddParameter("@PlateColor", 0);
         }
         else
         {
            idb.AddParameter("@PlateColor", gPSRecord.PlateColor);
         }
          }
         if(gPSRecord.DataType_IsChanged)
         {
         if (gPSRecord.DataType == 0)
         {
            idb.AddParameter("@DataType", 0);
         }
         else
         {
            idb.AddParameter("@DataType", gPSRecord.DataType);
         }
          }
         if(gPSRecord.GPSTime_IsChanged)
         {
         if (gPSRecord.GPSTime == DateTime.MinValue)
         {
            idb.AddParameter("@GPSTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GPSTime", gPSRecord.GPSTime);
         }
          }
         if(gPSRecord.Longitude_IsChanged)
         {
         if (gPSRecord.Longitude == 0)
         {
            idb.AddParameter("@Longitude", 0);
         }
         else
         {
            idb.AddParameter("@Longitude", gPSRecord.Longitude);
         }
          }
         if(gPSRecord.Latitude_IsChanged)
         {
         if (gPSRecord.Latitude == 0)
         {
            idb.AddParameter("@Latitude", 0);
         }
         else
         {
            idb.AddParameter("@Latitude", gPSRecord.Latitude);
         }
          }
         if(gPSRecord.GPSFlag_IsChanged)
         {
         if (gPSRecord.GPSFlag == 0)
         {
            idb.AddParameter("@GPSFlag", 0);
         }
         else
         {
            idb.AddParameter("@GPSFlag", gPSRecord.GPSFlag);
         }
          }
         if(gPSRecord.Speed_IsChanged)
         {
         if (gPSRecord.Speed == 0)
         {
            idb.AddParameter("@Speed", 0);
         }
         else
         {
            idb.AddParameter("@Speed", gPSRecord.Speed);
         }
          }
         if(gPSRecord.Direction_IsChanged)
         {
         if (gPSRecord.Direction == 0)
         {
            idb.AddParameter("@Direction", 0);
         }
         else
         {
            idb.AddParameter("@Direction", gPSRecord.Direction);
         }
          }
         if(gPSRecord.Comm_Type_IsChanged)
         {
         if (gPSRecord.Comm_Type == 0)
         {
            idb.AddParameter("@Comm_Type", 0);
         }
         else
         {
            idb.AddParameter("@Comm_Type", gPSRecord.Comm_Type);
         }
          }
         if(gPSRecord.MDTStatus_IsChanged)
         {
         if (gPSRecord.MDTStatus == 0)
         {
            idb.AddParameter("@MDTStatus", 0);
         }
         else
         {
            idb.AddParameter("@MDTStatus", gPSRecord.MDTStatus);
         }
          }
         if(gPSRecord.MDTAlarm_IsChanged)
         {
         if (gPSRecord.MDTAlarm == 0)
         {
            idb.AddParameter("@MDTAlarm", 0);
         }
         else
         {
            idb.AddParameter("@MDTAlarm", gPSRecord.MDTAlarm);
         }
          }
         if(gPSRecord.Data_Length_IsChanged)
         {
         if (gPSRecord.Data_Length == 0)
         {
            idb.AddParameter("@Data_Length", 0);
         }
         else
         {
            idb.AddParameter("@Data_Length", gPSRecord.Data_Length);
         }
          }
         if(gPSRecord.DataContend_IsChanged)
         {
         if (string.IsNullOrEmpty(gPSRecord.DataContend))
         {
            idb.AddParameter("@DataContend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DataContend", gPSRecord.DataContend);
         }
          }
         if(gPSRecord.Stat_IsChanged)
         {
         if (gPSRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gPSRecord.Stat);
         }
          }
         if(gPSRecord.CreateTime_IsChanged)
         {
         if (gPSRecord.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", gPSRecord.CreateTime);
         }
          }

         idb.AddParameter("@Record_ID", gPSRecord.Record_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除GPSRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal record_ID)
      {
         string sql = "DELETE GPSRecord WHERE 1=1  AND Record_ID=@Record_ID ";
         idb.AddParameter("@Record_ID", record_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的GPSRecord对象(即:一条记录
      /// </summary>
      public GPSRecord GetByKey(decimal record_ID)
      {
         GPSRecord gPSRecord = new GPSRecord();
         string sql = "SELECT  Record_ID,License_Plate,Terminal_ID,PlateColor,DataType,GPSTime,Longitude,Latitude,GPSFlag,Speed,Direction,Comm_Type,MDTStatus,MDTAlarm,Data_Length,DataContend,Stat,CreateTime FROM GPSRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Record_ID=@Record_ID ";
         idb.AddParameter("@Record_ID", record_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Record_ID"] != DBNull.Value) gPSRecord.Record_ID = Convert.ToDecimal(dr["Record_ID"]);
            if (dr["License_Plate"] != DBNull.Value) gPSRecord.License_Plate = Convert.ToString(dr["License_Plate"]);
            if (dr["Terminal_ID"] != DBNull.Value) gPSRecord.Terminal_ID = Convert.ToString(dr["Terminal_ID"]);
            if (dr["PlateColor"] != DBNull.Value) gPSRecord.PlateColor = Convert.ToInt32(dr["PlateColor"]);
            if (dr["DataType"] != DBNull.Value) gPSRecord.DataType = Convert.ToInt32(dr["DataType"]);
            if (dr["GPSTime"] != DBNull.Value) gPSRecord.GPSTime = Convert.ToDateTime(dr["GPSTime"]);
            if (dr["Longitude"] != DBNull.Value) gPSRecord.Longitude = Convert.ToDecimal(dr["Longitude"]);
            if (dr["Latitude"] != DBNull.Value) gPSRecord.Latitude = Convert.ToDecimal(dr["Latitude"]);
            if (dr["GPSFlag"] != DBNull.Value) gPSRecord.GPSFlag = Convert.ToInt32(dr["GPSFlag"]);
            if (dr["Speed"] != DBNull.Value) gPSRecord.Speed = Convert.ToInt32(dr["Speed"]);
            if (dr["Direction"] != DBNull.Value) gPSRecord.Direction = Convert.ToInt32(dr["Direction"]);
            if (dr["Comm_Type"] != DBNull.Value) gPSRecord.Comm_Type = Convert.ToInt32(dr["Comm_Type"]);
            if (dr["MDTStatus"] != DBNull.Value) gPSRecord.MDTStatus = Convert.ToInt32(dr["MDTStatus"]);
            if (dr["MDTAlarm"] != DBNull.Value) gPSRecord.MDTAlarm = Convert.ToInt32(dr["MDTAlarm"]);
            if (dr["Data_Length"] != DBNull.Value) gPSRecord.Data_Length = Convert.ToInt32(dr["Data_Length"]);
            if (dr["DataContend"] != DBNull.Value) gPSRecord.DataContend = Convert.ToString(dr["DataContend"]);
            if (dr["Stat"] != DBNull.Value) gPSRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) gPSRecord.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return gPSRecord;
      }
      /// <summary>
      /// 获取指定的GPSRecord对象集合
      /// </summary>
      public List<GPSRecord> GetListByWhere(string strCondition)
      {
         List<GPSRecord> ret = new List<GPSRecord>();
         string sql = "SELECT  Record_ID,License_Plate,Terminal_ID,PlateColor,DataType,GPSTime,Longitude,Latitude,GPSFlag,Speed,Direction,Comm_Type,MDTStatus,MDTAlarm,Data_Length,DataContend,Stat,CreateTime FROM GPSRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            GPSRecord gPSRecord = new GPSRecord();
            if (dr["Record_ID"] != DBNull.Value) gPSRecord.Record_ID = Convert.ToDecimal(dr["Record_ID"]);
            if (dr["License_Plate"] != DBNull.Value) gPSRecord.License_Plate = Convert.ToString(dr["License_Plate"]);
            if (dr["Terminal_ID"] != DBNull.Value) gPSRecord.Terminal_ID = Convert.ToString(dr["Terminal_ID"]);
            if (dr["PlateColor"] != DBNull.Value) gPSRecord.PlateColor = Convert.ToInt32(dr["PlateColor"]);
            if (dr["DataType"] != DBNull.Value) gPSRecord.DataType = Convert.ToInt32(dr["DataType"]);
            if (dr["GPSTime"] != DBNull.Value) gPSRecord.GPSTime = Convert.ToDateTime(dr["GPSTime"]);
            if (dr["Longitude"] != DBNull.Value) gPSRecord.Longitude = Convert.ToDecimal(dr["Longitude"]);
            if (dr["Latitude"] != DBNull.Value) gPSRecord.Latitude = Convert.ToDecimal(dr["Latitude"]);
            if (dr["GPSFlag"] != DBNull.Value) gPSRecord.GPSFlag = Convert.ToInt32(dr["GPSFlag"]);
            if (dr["Speed"] != DBNull.Value) gPSRecord.Speed = Convert.ToInt32(dr["Speed"]);
            if (dr["Direction"] != DBNull.Value) gPSRecord.Direction = Convert.ToInt32(dr["Direction"]);
            if (dr["Comm_Type"] != DBNull.Value) gPSRecord.Comm_Type = Convert.ToInt32(dr["Comm_Type"]);
            if (dr["MDTStatus"] != DBNull.Value) gPSRecord.MDTStatus = Convert.ToInt32(dr["MDTStatus"]);
            if (dr["MDTAlarm"] != DBNull.Value) gPSRecord.MDTAlarm = Convert.ToInt32(dr["MDTAlarm"]);
            if (dr["Data_Length"] != DBNull.Value) gPSRecord.Data_Length = Convert.ToInt32(dr["Data_Length"]);
            if (dr["DataContend"] != DBNull.Value) gPSRecord.DataContend = Convert.ToString(dr["DataContend"]);
            if (dr["Stat"] != DBNull.Value) gPSRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) gPSRecord.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(gPSRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的GPSRecord对象(即:一条记录
      /// </summary>
      public List<GPSRecord> GetAll()
      {
         List<GPSRecord> ret = new List<GPSRecord>();
         string sql = "SELECT  Record_ID,License_Plate,Terminal_ID,PlateColor,DataType,GPSTime,Longitude,Latitude,GPSFlag,Speed,Direction,Comm_Type,MDTStatus,MDTAlarm,Data_Length,DataContend,Stat,CreateTime FROM GPSRecord where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            GPSRecord gPSRecord = new GPSRecord();
            if (dr["Record_ID"] != DBNull.Value) gPSRecord.Record_ID = Convert.ToDecimal(dr["Record_ID"]);
            if (dr["License_Plate"] != DBNull.Value) gPSRecord.License_Plate = Convert.ToString(dr["License_Plate"]);
            if (dr["Terminal_ID"] != DBNull.Value) gPSRecord.Terminal_ID = Convert.ToString(dr["Terminal_ID"]);
            if (dr["PlateColor"] != DBNull.Value) gPSRecord.PlateColor = Convert.ToInt32(dr["PlateColor"]);
            if (dr["DataType"] != DBNull.Value) gPSRecord.DataType = Convert.ToInt32(dr["DataType"]);
            if (dr["GPSTime"] != DBNull.Value) gPSRecord.GPSTime = Convert.ToDateTime(dr["GPSTime"]);
            if (dr["Longitude"] != DBNull.Value) gPSRecord.Longitude = Convert.ToDecimal(dr["Longitude"]);
            if (dr["Latitude"] != DBNull.Value) gPSRecord.Latitude = Convert.ToDecimal(dr["Latitude"]);
            if (dr["GPSFlag"] != DBNull.Value) gPSRecord.GPSFlag = Convert.ToInt32(dr["GPSFlag"]);
            if (dr["Speed"] != DBNull.Value) gPSRecord.Speed = Convert.ToInt32(dr["Speed"]);
            if (dr["Direction"] != DBNull.Value) gPSRecord.Direction = Convert.ToInt32(dr["Direction"]);
            if (dr["Comm_Type"] != DBNull.Value) gPSRecord.Comm_Type = Convert.ToInt32(dr["Comm_Type"]);
            if (dr["MDTStatus"] != DBNull.Value) gPSRecord.MDTStatus = Convert.ToInt32(dr["MDTStatus"]);
            if (dr["MDTAlarm"] != DBNull.Value) gPSRecord.MDTAlarm = Convert.ToInt32(dr["MDTAlarm"]);
            if (dr["Data_Length"] != DBNull.Value) gPSRecord.Data_Length = Convert.ToInt32(dr["Data_Length"]);
            if (dr["DataContend"] != DBNull.Value) gPSRecord.DataContend = Convert.ToString(dr["DataContend"]);
            if (dr["Stat"] != DBNull.Value) gPSRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) gPSRecord.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(gPSRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }

      public List<GPSRecord> GetMax(string car)
      {
          List<GPSRecord> ret = new List<GPSRecord>();
          string sql = "SELECT top 1  Record_ID,License_Plate,Terminal_ID,PlateColor,DataType,GPSTime,Longitude,Latitude,GPSFlag,Speed,Direction,Comm_Type,MDTStatus,MDTAlarm,Data_Length,DataContend,Stat,CreateTime FROM GPSRecord where 1=1 AND ((Stat is null) or (Stat=0) ) and License_Plate='"+car+"'  ORDER BY Record_ID desc ";
          SqlDataReader dr = null;
          try
          {
              dr = (SqlDataReader)idb.ReturnReader(sql);
              while (dr.Read())
              {
                  GPSRecord gPSRecord = new GPSRecord();
                  if (dr["Record_ID"] != DBNull.Value) gPSRecord.Record_ID = Convert.ToDecimal(dr["Record_ID"]);
                  if (dr["License_Plate"] != DBNull.Value) gPSRecord.License_Plate = Convert.ToString(dr["License_Plate"]);
                  if (dr["Terminal_ID"] != DBNull.Value) gPSRecord.Terminal_ID = Convert.ToString(dr["Terminal_ID"]);
                  if (dr["PlateColor"] != DBNull.Value) gPSRecord.PlateColor = Convert.ToInt32(dr["PlateColor"]);
                  if (dr["DataType"] != DBNull.Value) gPSRecord.DataType = Convert.ToInt32(dr["DataType"]);
                  if (dr["GPSTime"] != DBNull.Value) gPSRecord.GPSTime = Convert.ToDateTime(dr["GPSTime"]);
                  if (dr["Longitude"] != DBNull.Value) gPSRecord.Longitude = Convert.ToDecimal(dr["Longitude"]);
                  if (dr["Latitude"] != DBNull.Value) gPSRecord.Latitude = Convert.ToDecimal(dr["Latitude"]);
                  if (dr["GPSFlag"] != DBNull.Value) gPSRecord.GPSFlag = Convert.ToInt32(dr["GPSFlag"]);
                  if (dr["Speed"] != DBNull.Value) gPSRecord.Speed = Convert.ToInt32(dr["Speed"]);
                  if (dr["Direction"] != DBNull.Value) gPSRecord.Direction = Convert.ToInt32(dr["Direction"]);
                  if (dr["Comm_Type"] != DBNull.Value) gPSRecord.Comm_Type = Convert.ToInt32(dr["Comm_Type"]);
                  if (dr["MDTStatus"] != DBNull.Value) gPSRecord.MDTStatus = Convert.ToInt32(dr["MDTStatus"]);
                  if (dr["MDTAlarm"] != DBNull.Value) gPSRecord.MDTAlarm = Convert.ToInt32(dr["MDTAlarm"]);
                  if (dr["Data_Length"] != DBNull.Value) gPSRecord.Data_Length = Convert.ToInt32(dr["Data_Length"]);
                  if (dr["DataContend"] != DBNull.Value) gPSRecord.DataContend = Convert.ToString(dr["DataContend"]);
                  if (dr["Stat"] != DBNull.Value) gPSRecord.Stat = Convert.ToInt32(dr["Stat"]);
                  if (dr["CreateTime"] != DBNull.Value) gPSRecord.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
                  ret.Add(gPSRecord);
              }
          }
          catch (System.Exception ex) { throw ex; }
          finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
          return ret;
      }
   }
}
