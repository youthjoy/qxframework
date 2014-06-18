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
   public partial class ADOSD_CTrans
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加SD_CTrans对象(即:一条记录)
      /// </summary>
      public int Add(SD_CTrans sD_CTrans)
      {
         string sql = "INSERT INTO SD_CTrans (SDT_PCode,SDT_Code,SDT_DName,SDT_DCode,SDT_Owner,SDT_Distance,SDT_RoadCode,SDT_CheckValue,SDT_Unit,SDT_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDT_CarNo,SDT_StartTime,SDT_EndTime,SDT_Pop,SDT_Lng,SDT_Lat) VALUES (@SDT_PCode,@SDT_Code,@SDT_DName,@SDT_DCode,@SDT_Owner,@SDT_Distance,@SDT_RoadCode,@SDT_CheckValue,@SDT_Unit,@SDT_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDT_CarNo,@SDT_StartTime,@SDT_EndTime,@SDT_Pop,@SDT_Lng,@SDT_Lat)";
         if (string.IsNullOrEmpty(sD_CTrans.SDT_PCode))
         {
            idb.AddParameter("@SDT_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PCode", sD_CTrans.SDT_PCode);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Code))
         {
            idb.AddParameter("@SDT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Code", sD_CTrans.SDT_Code);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_DName))
         {
            idb.AddParameter("@SDT_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_DName", sD_CTrans.SDT_DName);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_DCode))
         {
            idb.AddParameter("@SDT_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_DCode", sD_CTrans.SDT_DCode);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Owner))
         {
            idb.AddParameter("@SDT_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Owner", sD_CTrans.SDT_Owner);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Distance))
         {
            idb.AddParameter("@SDT_Distance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Distance", sD_CTrans.SDT_Distance);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_RoadCode))
         {
            idb.AddParameter("@SDT_RoadCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_RoadCode", sD_CTrans.SDT_RoadCode);
         }
         if (sD_CTrans.SDT_CheckValue == 0)
         {
            idb.AddParameter("@SDT_CheckValue", 0);
         }
         else
         {
            idb.AddParameter("@SDT_CheckValue", sD_CTrans.SDT_CheckValue);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Unit))
         {
            idb.AddParameter("@SDT_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Unit", sD_CTrans.SDT_Unit);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Bak))
         {
            idb.AddParameter("@SDT_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Bak", sD_CTrans.SDT_Bak);
         }
         if (sD_CTrans.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CTrans.Stat);
         }
         if (sD_CTrans.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_CTrans.CreateDate);
         }
         if (sD_CTrans.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_CTrans.UpdateDate);
         }
         if (sD_CTrans.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_CTrans.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_CarNo))
         {
            idb.AddParameter("@SDT_CarNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_CarNo", sD_CTrans.SDT_CarNo);
         }
         if (sD_CTrans.SDT_StartTime == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_StartTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_StartTime", sD_CTrans.SDT_StartTime);
         }
         if (sD_CTrans.SDT_EndTime == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_EndTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_EndTime", sD_CTrans.SDT_EndTime);
         }
         if (sD_CTrans.SDT_Pop == 0)
         {
            idb.AddParameter("@SDT_Pop", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Pop", sD_CTrans.SDT_Pop);
         }
         if (sD_CTrans.SDT_Lng == 0)
         {
            idb.AddParameter("@SDT_Lng", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Lng", sD_CTrans.SDT_Lng);
         }
         if (sD_CTrans.SDT_Lat == 0)
         {
            idb.AddParameter("@SDT_Lat", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Lat", sD_CTrans.SDT_Lat);
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
      /// 添加SD_CTrans对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_CTrans sD_CTrans)
      {
         string sql = "INSERT INTO SD_CTrans (SDT_PCode,SDT_Code,SDT_DName,SDT_DCode,SDT_Owner,SDT_Distance,SDT_RoadCode,SDT_CheckValue,SDT_Unit,SDT_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDT_CarNo,SDT_StartTime,SDT_EndTime,SDT_Pop,SDT_Lng,SDT_Lat) VALUES (@SDT_PCode,@SDT_Code,@SDT_DName,@SDT_DCode,@SDT_Owner,@SDT_Distance,@SDT_RoadCode,@SDT_CheckValue,@SDT_Unit,@SDT_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDT_CarNo,@SDT_StartTime,@SDT_EndTime,@SDT_Pop,@SDT_Lng,@SDT_Lat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_CTrans.SDT_PCode))
         {
            idb.AddParameter("@SDT_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PCode", sD_CTrans.SDT_PCode);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Code))
         {
            idb.AddParameter("@SDT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Code", sD_CTrans.SDT_Code);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_DName))
         {
            idb.AddParameter("@SDT_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_DName", sD_CTrans.SDT_DName);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_DCode))
         {
            idb.AddParameter("@SDT_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_DCode", sD_CTrans.SDT_DCode);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Owner))
         {
            idb.AddParameter("@SDT_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Owner", sD_CTrans.SDT_Owner);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Distance))
         {
            idb.AddParameter("@SDT_Distance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Distance", sD_CTrans.SDT_Distance);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_RoadCode))
         {
            idb.AddParameter("@SDT_RoadCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_RoadCode", sD_CTrans.SDT_RoadCode);
         }
         if (sD_CTrans.SDT_CheckValue == 0)
         {
            idb.AddParameter("@SDT_CheckValue", 0);
         }
         else
         {
            idb.AddParameter("@SDT_CheckValue", sD_CTrans.SDT_CheckValue);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Unit))
         {
            idb.AddParameter("@SDT_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Unit", sD_CTrans.SDT_Unit);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Bak))
         {
            idb.AddParameter("@SDT_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Bak", sD_CTrans.SDT_Bak);
         }
         if (sD_CTrans.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CTrans.Stat);
         }
         if (sD_CTrans.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_CTrans.CreateDate);
         }
         if (sD_CTrans.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_CTrans.UpdateDate);
         }
         if (sD_CTrans.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_CTrans.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_CTrans.SDT_CarNo))
         {
            idb.AddParameter("@SDT_CarNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_CarNo", sD_CTrans.SDT_CarNo);
         }
         if (sD_CTrans.SDT_StartTime == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_StartTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_StartTime", sD_CTrans.SDT_StartTime);
         }
         if (sD_CTrans.SDT_EndTime == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_EndTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_EndTime", sD_CTrans.SDT_EndTime);
         }
         if (sD_CTrans.SDT_Pop == 0)
         {
            idb.AddParameter("@SDT_Pop", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Pop", sD_CTrans.SDT_Pop);
         }
         if (sD_CTrans.SDT_Lng == 0)
         {
            idb.AddParameter("@SDT_Lng", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Lng", sD_CTrans.SDT_Lng);
         }
         if (sD_CTrans.SDT_Lat == 0)
         {
            idb.AddParameter("@SDT_Lat", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Lat", sD_CTrans.SDT_Lat);
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
      /// 更新SD_CTrans对象(即:一条记录
      /// </summary>
      public int Update(SD_CTrans sD_CTrans)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_CTrans       SET ");
            if(sD_CTrans.SDT_PCode_IsChanged){sbParameter.Append("SDT_PCode=@SDT_PCode, ");}
      if(sD_CTrans.SDT_Code_IsChanged){sbParameter.Append("SDT_Code=@SDT_Code, ");}
      if(sD_CTrans.SDT_DName_IsChanged){sbParameter.Append("SDT_DName=@SDT_DName, ");}
      if(sD_CTrans.SDT_DCode_IsChanged){sbParameter.Append("SDT_DCode=@SDT_DCode, ");}
      if(sD_CTrans.SDT_Owner_IsChanged){sbParameter.Append("SDT_Owner=@SDT_Owner, ");}
      if(sD_CTrans.SDT_Distance_IsChanged){sbParameter.Append("SDT_Distance=@SDT_Distance, ");}
      if(sD_CTrans.SDT_RoadCode_IsChanged){sbParameter.Append("SDT_RoadCode=@SDT_RoadCode, ");}
      if(sD_CTrans.SDT_CheckValue_IsChanged){sbParameter.Append("SDT_CheckValue=@SDT_CheckValue, ");}
      if(sD_CTrans.SDT_Unit_IsChanged){sbParameter.Append("SDT_Unit=@SDT_Unit, ");}
      if(sD_CTrans.SDT_Bak_IsChanged){sbParameter.Append("SDT_Bak=@SDT_Bak, ");}
      if(sD_CTrans.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_CTrans.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_CTrans.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_CTrans.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_CTrans.SDT_CarNo_IsChanged){sbParameter.Append("SDT_CarNo=@SDT_CarNo, ");}
      if(sD_CTrans.SDT_StartTime_IsChanged){sbParameter.Append("SDT_StartTime=@SDT_StartTime, ");}
      if(sD_CTrans.SDT_EndTime_IsChanged){sbParameter.Append("SDT_EndTime=@SDT_EndTime, ");}
      if(sD_CTrans.SDT_Pop_IsChanged){sbParameter.Append("SDT_Pop=@SDT_Pop, ");}
      if(sD_CTrans.SDT_Lng_IsChanged){sbParameter.Append("SDT_Lng=@SDT_Lng, ");}
      if(sD_CTrans.SDT_Lat_IsChanged){sbParameter.Append("SDT_Lat=@SDT_Lat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDT_ID=@SDT_ID; " );
      string sql=sb.ToString();
         if(sD_CTrans.SDT_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_PCode))
         {
            idb.AddParameter("@SDT_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PCode", sD_CTrans.SDT_PCode);
         }
          }
         if(sD_CTrans.SDT_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Code))
         {
            idb.AddParameter("@SDT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Code", sD_CTrans.SDT_Code);
         }
          }
         if(sD_CTrans.SDT_DName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_DName))
         {
            idb.AddParameter("@SDT_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_DName", sD_CTrans.SDT_DName);
         }
          }
         if(sD_CTrans.SDT_DCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_DCode))
         {
            idb.AddParameter("@SDT_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_DCode", sD_CTrans.SDT_DCode);
         }
          }
         if(sD_CTrans.SDT_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Owner))
         {
            idb.AddParameter("@SDT_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Owner", sD_CTrans.SDT_Owner);
         }
          }
         if(sD_CTrans.SDT_Distance_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Distance))
         {
            idb.AddParameter("@SDT_Distance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Distance", sD_CTrans.SDT_Distance);
         }
          }
         if(sD_CTrans.SDT_RoadCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_RoadCode))
         {
            idb.AddParameter("@SDT_RoadCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_RoadCode", sD_CTrans.SDT_RoadCode);
         }
          }
         if(sD_CTrans.SDT_CheckValue_IsChanged)
         {
         if (sD_CTrans.SDT_CheckValue == 0)
         {
            idb.AddParameter("@SDT_CheckValue", 0);
         }
         else
         {
            idb.AddParameter("@SDT_CheckValue", sD_CTrans.SDT_CheckValue);
         }
          }
         if(sD_CTrans.SDT_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Unit))
         {
            idb.AddParameter("@SDT_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Unit", sD_CTrans.SDT_Unit);
         }
          }
         if(sD_CTrans.SDT_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_Bak))
         {
            idb.AddParameter("@SDT_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Bak", sD_CTrans.SDT_Bak);
         }
          }
         if(sD_CTrans.Stat_IsChanged)
         {
         if (sD_CTrans.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CTrans.Stat);
         }
          }
         if(sD_CTrans.CreateDate_IsChanged)
         {
         if (sD_CTrans.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_CTrans.CreateDate);
         }
          }
         if(sD_CTrans.UpdateDate_IsChanged)
         {
         if (sD_CTrans.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_CTrans.UpdateDate);
         }
          }
         if(sD_CTrans.DeleteDate_IsChanged)
         {
         if (sD_CTrans.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_CTrans.DeleteDate);
         }
          }
         if(sD_CTrans.SDT_CarNo_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CTrans.SDT_CarNo))
         {
            idb.AddParameter("@SDT_CarNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_CarNo", sD_CTrans.SDT_CarNo);
         }
          }
         if(sD_CTrans.SDT_StartTime_IsChanged)
         {
         if (sD_CTrans.SDT_StartTime == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_StartTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_StartTime", sD_CTrans.SDT_StartTime);
         }
          }
         if(sD_CTrans.SDT_EndTime_IsChanged)
         {
         if (sD_CTrans.SDT_EndTime == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_EndTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_EndTime", sD_CTrans.SDT_EndTime);
         }
          }
         if(sD_CTrans.SDT_Pop_IsChanged)
         {
         if (sD_CTrans.SDT_Pop == 0)
         {
            idb.AddParameter("@SDT_Pop", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Pop", sD_CTrans.SDT_Pop);
         }
          }
         if(sD_CTrans.SDT_Lng_IsChanged)
         {
         if (sD_CTrans.SDT_Lng == 0)
         {
            idb.AddParameter("@SDT_Lng", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Lng", sD_CTrans.SDT_Lng);
         }
          }
         if(sD_CTrans.SDT_Lat_IsChanged)
         {
         if (sD_CTrans.SDT_Lat == 0)
         {
            idb.AddParameter("@SDT_Lat", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Lat", sD_CTrans.SDT_Lat);
         }
          }

         idb.AddParameter("@SDT_ID", sD_CTrans.SDT_ID);

           
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
      /// 删除SD_CTrans对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDT_ID)
      {
         string sql = "DELETE SD_CTrans WHERE 1=1  AND SDT_ID=@SDT_ID ";
         idb.AddParameter("@SDT_ID", sDT_ID);

           
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
      /// 获取指定的SD_CTrans对象(即:一条记录
      /// </summary>
      public SD_CTrans GetByKey(decimal sDT_ID)
      {
         SD_CTrans sD_CTrans = new SD_CTrans();
         string sql = "SELECT  SDT_ID,SDT_PCode,SDT_Code,SDT_DName,SDT_DCode,SDT_Owner,SDT_Distance,SDT_RoadCode,SDT_CheckValue,SDT_Unit,SDT_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDT_CarNo,SDT_StartTime,SDT_EndTime,SDT_Pop,SDT_Lng,SDT_Lat FROM SD_CTrans WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDT_ID=@SDT_ID ";
         idb.AddParameter("@SDT_ID", sDT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDT_ID"] != DBNull.Value) sD_CTrans.SDT_ID = Convert.ToDecimal(dr["SDT_ID"]);
            if (dr["SDT_PCode"] != DBNull.Value) sD_CTrans.SDT_PCode = Convert.ToString(dr["SDT_PCode"]);
            if (dr["SDT_Code"] != DBNull.Value) sD_CTrans.SDT_Code = Convert.ToString(dr["SDT_Code"]);
            if (dr["SDT_DName"] != DBNull.Value) sD_CTrans.SDT_DName = Convert.ToString(dr["SDT_DName"]);
            if (dr["SDT_DCode"] != DBNull.Value) sD_CTrans.SDT_DCode = Convert.ToString(dr["SDT_DCode"]);
            if (dr["SDT_Owner"] != DBNull.Value) sD_CTrans.SDT_Owner = Convert.ToString(dr["SDT_Owner"]);
            if (dr["SDT_Distance"] != DBNull.Value) sD_CTrans.SDT_Distance = Convert.ToString(dr["SDT_Distance"]);
            if (dr["SDT_RoadCode"] != DBNull.Value) sD_CTrans.SDT_RoadCode = Convert.ToString(dr["SDT_RoadCode"]);
            if (dr["SDT_CheckValue"] != DBNull.Value) sD_CTrans.SDT_CheckValue = Convert.ToDecimal(dr["SDT_CheckValue"]);
            if (dr["SDT_Unit"] != DBNull.Value) sD_CTrans.SDT_Unit = Convert.ToString(dr["SDT_Unit"]);
            if (dr["SDT_Bak"] != DBNull.Value) sD_CTrans.SDT_Bak = Convert.ToString(dr["SDT_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_CTrans.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_CTrans.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_CTrans.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_CTrans.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDT_CarNo"] != DBNull.Value) sD_CTrans.SDT_CarNo = Convert.ToString(dr["SDT_CarNo"]);
            if (dr["SDT_StartTime"] != DBNull.Value) sD_CTrans.SDT_StartTime = Convert.ToDateTime(dr["SDT_StartTime"]);
            if (dr["SDT_EndTime"] != DBNull.Value) sD_CTrans.SDT_EndTime = Convert.ToDateTime(dr["SDT_EndTime"]);
            if (dr["SDT_Pop"] != DBNull.Value) sD_CTrans.SDT_Pop = Convert.ToDecimal(dr["SDT_Pop"]);
            if (dr["SDT_Lng"] != DBNull.Value) sD_CTrans.SDT_Lng = Convert.ToDecimal(dr["SDT_Lng"]);
            if (dr["SDT_Lat"] != DBNull.Value) sD_CTrans.SDT_Lat = Convert.ToDecimal(dr["SDT_Lat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_CTrans;
      }
      /// <summary>
      /// 获取指定的SD_CTrans对象集合
      /// </summary>
      public List<SD_CTrans> GetListByWhere(string strCondition)
      {
         List<SD_CTrans> ret = new List<SD_CTrans>();
         string sql = "SELECT  SDT_ID,SDT_PCode,SDT_Code,SDT_DName,SDT_DCode,SDT_Owner,SDT_Distance,SDT_RoadCode,SDT_CheckValue,SDT_Unit,SDT_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDT_CarNo,SDT_StartTime,SDT_EndTime,SDT_Pop,SDT_Lng,SDT_Lat FROM SD_CTrans WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_CTrans sD_CTrans = new SD_CTrans();
            if (dr["SDT_ID"] != DBNull.Value) sD_CTrans.SDT_ID = Convert.ToDecimal(dr["SDT_ID"]);
            if (dr["SDT_PCode"] != DBNull.Value) sD_CTrans.SDT_PCode = Convert.ToString(dr["SDT_PCode"]);
            if (dr["SDT_Code"] != DBNull.Value) sD_CTrans.SDT_Code = Convert.ToString(dr["SDT_Code"]);
            if (dr["SDT_DName"] != DBNull.Value) sD_CTrans.SDT_DName = Convert.ToString(dr["SDT_DName"]);
            if (dr["SDT_DCode"] != DBNull.Value) sD_CTrans.SDT_DCode = Convert.ToString(dr["SDT_DCode"]);
            if (dr["SDT_Owner"] != DBNull.Value) sD_CTrans.SDT_Owner = Convert.ToString(dr["SDT_Owner"]);
            if (dr["SDT_Distance"] != DBNull.Value) sD_CTrans.SDT_Distance = Convert.ToString(dr["SDT_Distance"]);
            if (dr["SDT_RoadCode"] != DBNull.Value) sD_CTrans.SDT_RoadCode = Convert.ToString(dr["SDT_RoadCode"]);
            if (dr["SDT_CheckValue"] != DBNull.Value) sD_CTrans.SDT_CheckValue = Convert.ToDecimal(dr["SDT_CheckValue"]);
            if (dr["SDT_Unit"] != DBNull.Value) sD_CTrans.SDT_Unit = Convert.ToString(dr["SDT_Unit"]);
            if (dr["SDT_Bak"] != DBNull.Value) sD_CTrans.SDT_Bak = Convert.ToString(dr["SDT_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_CTrans.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_CTrans.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_CTrans.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_CTrans.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDT_CarNo"] != DBNull.Value) sD_CTrans.SDT_CarNo = Convert.ToString(dr["SDT_CarNo"]);
            if (dr["SDT_StartTime"] != DBNull.Value) sD_CTrans.SDT_StartTime = Convert.ToDateTime(dr["SDT_StartTime"]);
            if (dr["SDT_EndTime"] != DBNull.Value) sD_CTrans.SDT_EndTime = Convert.ToDateTime(dr["SDT_EndTime"]);
            if (dr["SDT_Pop"] != DBNull.Value) sD_CTrans.SDT_Pop = Convert.ToDecimal(dr["SDT_Pop"]);
            if (dr["SDT_Lng"] != DBNull.Value) sD_CTrans.SDT_Lng = Convert.ToDecimal(dr["SDT_Lng"]);
            if (dr["SDT_Lat"] != DBNull.Value) sD_CTrans.SDT_Lat = Convert.ToDecimal(dr["SDT_Lat"]);
            ret.Add(sD_CTrans);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的SD_CTrans对象(即:一条记录
      /// </summary>
      public List<SD_CTrans> GetAll()
      {
         List<SD_CTrans> ret = new List<SD_CTrans>();
         string sql = "SELECT  SDT_ID,SDT_PCode,SDT_Code,SDT_DName,SDT_DCode,SDT_Owner,SDT_Distance,SDT_RoadCode,SDT_CheckValue,SDT_Unit,SDT_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDT_CarNo,SDT_StartTime,SDT_EndTime,SDT_Pop,SDT_Lng,SDT_Lat FROM SD_CTrans where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDT_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_CTrans sD_CTrans = new SD_CTrans();
            if (dr["SDT_ID"] != DBNull.Value) sD_CTrans.SDT_ID = Convert.ToDecimal(dr["SDT_ID"]);
            if (dr["SDT_PCode"] != DBNull.Value) sD_CTrans.SDT_PCode = Convert.ToString(dr["SDT_PCode"]);
            if (dr["SDT_Code"] != DBNull.Value) sD_CTrans.SDT_Code = Convert.ToString(dr["SDT_Code"]);
            if (dr["SDT_DName"] != DBNull.Value) sD_CTrans.SDT_DName = Convert.ToString(dr["SDT_DName"]);
            if (dr["SDT_DCode"] != DBNull.Value) sD_CTrans.SDT_DCode = Convert.ToString(dr["SDT_DCode"]);
            if (dr["SDT_Owner"] != DBNull.Value) sD_CTrans.SDT_Owner = Convert.ToString(dr["SDT_Owner"]);
            if (dr["SDT_Distance"] != DBNull.Value) sD_CTrans.SDT_Distance = Convert.ToString(dr["SDT_Distance"]);
            if (dr["SDT_RoadCode"] != DBNull.Value) sD_CTrans.SDT_RoadCode = Convert.ToString(dr["SDT_RoadCode"]);
            if (dr["SDT_CheckValue"] != DBNull.Value) sD_CTrans.SDT_CheckValue = Convert.ToDecimal(dr["SDT_CheckValue"]);
            if (dr["SDT_Unit"] != DBNull.Value) sD_CTrans.SDT_Unit = Convert.ToString(dr["SDT_Unit"]);
            if (dr["SDT_Bak"] != DBNull.Value) sD_CTrans.SDT_Bak = Convert.ToString(dr["SDT_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_CTrans.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_CTrans.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_CTrans.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_CTrans.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDT_CarNo"] != DBNull.Value) sD_CTrans.SDT_CarNo = Convert.ToString(dr["SDT_CarNo"]);
            if (dr["SDT_StartTime"] != DBNull.Value) sD_CTrans.SDT_StartTime = Convert.ToDateTime(dr["SDT_StartTime"]);
            if (dr["SDT_EndTime"] != DBNull.Value) sD_CTrans.SDT_EndTime = Convert.ToDateTime(dr["SDT_EndTime"]);
            if (dr["SDT_Pop"] != DBNull.Value) sD_CTrans.SDT_Pop = Convert.ToDecimal(dr["SDT_Pop"]);
            if (dr["SDT_Lng"] != DBNull.Value) sD_CTrans.SDT_Lng = Convert.ToDecimal(dr["SDT_Lng"]);
            if (dr["SDT_Lat"] != DBNull.Value) sD_CTrans.SDT_Lat = Convert.ToDecimal(dr["SDT_Lat"]);
            ret.Add(sD_CTrans);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
