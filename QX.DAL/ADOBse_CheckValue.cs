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
   public partial class ADOBse_CheckValue
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_CheckValue对象(即:一条记录)
      /// </summary>
      public int Add(Bse_CheckValue bse_CheckValue)
      {
         string sql = "INSERT INTO Bse_CheckValue (SC_Code,SC_StationCode,SC_StatName,SC_Source,SC_Position,SC_Alarm,SC_Warn,SC_Bak1,SC_Bak2,SC_iType,SC_Rate,SC_Stat,SC_StatNames,SC_RefCode,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@SC_Code,@SC_StationCode,@SC_StatName,@SC_Source,@SC_Position,@SC_Alarm,@SC_Warn,@SC_Bak1,@SC_Bak2,@SC_iType,@SC_Rate,@SC_Stat,@SC_StatNames,@SC_RefCode,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Code))
         {
            idb.AddParameter("@SC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Code", bse_CheckValue.SC_Code);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StationCode))
         {
            idb.AddParameter("@SC_StationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StationCode", bse_CheckValue.SC_StationCode);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StatName))
         {
            idb.AddParameter("@SC_StatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StatName", bse_CheckValue.SC_StatName);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Source))
         {
            idb.AddParameter("@SC_Source", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Source", bse_CheckValue.SC_Source);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Position))
         {
            idb.AddParameter("@SC_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Position", bse_CheckValue.SC_Position);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Alarm))
         {
            idb.AddParameter("@SC_Alarm", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Alarm", bse_CheckValue.SC_Alarm);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Warn))
         {
            idb.AddParameter("@SC_Warn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Warn", bse_CheckValue.SC_Warn);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Bak1))
         {
            idb.AddParameter("@SC_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Bak1", bse_CheckValue.SC_Bak1);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Bak2))
         {
            idb.AddParameter("@SC_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Bak2", bse_CheckValue.SC_Bak2);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_iType))
         {
            idb.AddParameter("@SC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_iType", bse_CheckValue.SC_iType);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Rate))
         {
            idb.AddParameter("@SC_Rate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Rate", bse_CheckValue.SC_Rate);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Stat))
         {
            idb.AddParameter("@SC_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Stat", bse_CheckValue.SC_Stat);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StatNames))
         {
            idb.AddParameter("@SC_StatNames", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StatNames", bse_CheckValue.SC_StatNames);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_RefCode))
         {
            idb.AddParameter("@SC_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_RefCode", bse_CheckValue.SC_RefCode);
         }
         if (bse_CheckValue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CheckValue.Stat);
         }
         if (bse_CheckValue.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_CheckValue.CreateTime);
         }
         if (bse_CheckValue.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_CheckValue.UpdateTime);
         }
         if (bse_CheckValue.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_CheckValue.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_CheckValue对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_CheckValue bse_CheckValue)
      {
         string sql = "INSERT INTO Bse_CheckValue (SC_Code,SC_StationCode,SC_StatName,SC_Source,SC_Position,SC_Alarm,SC_Warn,SC_Bak1,SC_Bak2,SC_iType,SC_Rate,SC_Stat,SC_StatNames,SC_RefCode,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@SC_Code,@SC_StationCode,@SC_StatName,@SC_Source,@SC_Position,@SC_Alarm,@SC_Warn,@SC_Bak1,@SC_Bak2,@SC_iType,@SC_Rate,@SC_Stat,@SC_StatNames,@SC_RefCode,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Code))
         {
            idb.AddParameter("@SC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Code", bse_CheckValue.SC_Code);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StationCode))
         {
            idb.AddParameter("@SC_StationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StationCode", bse_CheckValue.SC_StationCode);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StatName))
         {
            idb.AddParameter("@SC_StatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StatName", bse_CheckValue.SC_StatName);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Source))
         {
            idb.AddParameter("@SC_Source", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Source", bse_CheckValue.SC_Source);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Position))
         {
            idb.AddParameter("@SC_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Position", bse_CheckValue.SC_Position);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Alarm))
         {
            idb.AddParameter("@SC_Alarm", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Alarm", bse_CheckValue.SC_Alarm);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Warn))
         {
            idb.AddParameter("@SC_Warn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Warn", bse_CheckValue.SC_Warn);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Bak1))
         {
            idb.AddParameter("@SC_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Bak1", bse_CheckValue.SC_Bak1);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Bak2))
         {
            idb.AddParameter("@SC_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Bak2", bse_CheckValue.SC_Bak2);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_iType))
         {
            idb.AddParameter("@SC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_iType", bse_CheckValue.SC_iType);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Rate))
         {
            idb.AddParameter("@SC_Rate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Rate", bse_CheckValue.SC_Rate);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Stat))
         {
            idb.AddParameter("@SC_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Stat", bse_CheckValue.SC_Stat);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StatNames))
         {
            idb.AddParameter("@SC_StatNames", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StatNames", bse_CheckValue.SC_StatNames);
         }
         if (string.IsNullOrEmpty(bse_CheckValue.SC_RefCode))
         {
            idb.AddParameter("@SC_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_RefCode", bse_CheckValue.SC_RefCode);
         }
         if (bse_CheckValue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CheckValue.Stat);
         }
         if (bse_CheckValue.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_CheckValue.CreateTime);
         }
         if (bse_CheckValue.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_CheckValue.UpdateTime);
         }
         if (bse_CheckValue.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_CheckValue.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_CheckValue对象(即:一条记录
      /// </summary>
      public int Update(Bse_CheckValue bse_CheckValue)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_CheckValue       SET ");
            if(bse_CheckValue.SC_Code_IsChanged){sbParameter.Append("SC_Code=@SC_Code, ");}
      if(bse_CheckValue.SC_StationCode_IsChanged){sbParameter.Append("SC_StationCode=@SC_StationCode, ");}
      if(bse_CheckValue.SC_StatName_IsChanged){sbParameter.Append("SC_StatName=@SC_StatName, ");}
      if(bse_CheckValue.SC_Source_IsChanged){sbParameter.Append("SC_Source=@SC_Source, ");}
      if(bse_CheckValue.SC_Position_IsChanged){sbParameter.Append("SC_Position=@SC_Position, ");}
      if(bse_CheckValue.SC_Alarm_IsChanged){sbParameter.Append("SC_Alarm=@SC_Alarm, ");}
      if(bse_CheckValue.SC_Warn_IsChanged){sbParameter.Append("SC_Warn=@SC_Warn, ");}
      if(bse_CheckValue.SC_Bak1_IsChanged){sbParameter.Append("SC_Bak1=@SC_Bak1, ");}
      if(bse_CheckValue.SC_Bak2_IsChanged){sbParameter.Append("SC_Bak2=@SC_Bak2, ");}
      if(bse_CheckValue.SC_iType_IsChanged){sbParameter.Append("SC_iType=@SC_iType, ");}
      if(bse_CheckValue.SC_Rate_IsChanged){sbParameter.Append("SC_Rate=@SC_Rate, ");}
      if(bse_CheckValue.SC_Stat_IsChanged){sbParameter.Append("SC_Stat=@SC_Stat, ");}
      if(bse_CheckValue.SC_StatNames_IsChanged){sbParameter.Append("SC_StatNames=@SC_StatNames, ");}
      if(bse_CheckValue.SC_RefCode_IsChanged){sbParameter.Append("SC_RefCode=@SC_RefCode, ");}
      if(bse_CheckValue.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_CheckValue.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_CheckValue.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_CheckValue.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SC_ID=@SC_ID; " );
      string sql=sb.ToString();
         if(bse_CheckValue.SC_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Code))
         {
            idb.AddParameter("@SC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Code", bse_CheckValue.SC_Code);
         }
          }
         if(bse_CheckValue.SC_StationCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StationCode))
         {
            idb.AddParameter("@SC_StationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StationCode", bse_CheckValue.SC_StationCode);
         }
          }
         if(bse_CheckValue.SC_StatName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StatName))
         {
            idb.AddParameter("@SC_StatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StatName", bse_CheckValue.SC_StatName);
         }
          }
         if(bse_CheckValue.SC_Source_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Source))
         {
            idb.AddParameter("@SC_Source", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Source", bse_CheckValue.SC_Source);
         }
          }
         if(bse_CheckValue.SC_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Position))
         {
            idb.AddParameter("@SC_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Position", bse_CheckValue.SC_Position);
         }
          }
         if(bse_CheckValue.SC_Alarm_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Alarm))
         {
            idb.AddParameter("@SC_Alarm", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Alarm", bse_CheckValue.SC_Alarm);
         }
          }
         if(bse_CheckValue.SC_Warn_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Warn))
         {
            idb.AddParameter("@SC_Warn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Warn", bse_CheckValue.SC_Warn);
         }
          }
         if(bse_CheckValue.SC_Bak1_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Bak1))
         {
            idb.AddParameter("@SC_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Bak1", bse_CheckValue.SC_Bak1);
         }
          }
         if(bse_CheckValue.SC_Bak2_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Bak2))
         {
            idb.AddParameter("@SC_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Bak2", bse_CheckValue.SC_Bak2);
         }
          }
         if(bse_CheckValue.SC_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_iType))
         {
            idb.AddParameter("@SC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_iType", bse_CheckValue.SC_iType);
         }
          }
         if(bse_CheckValue.SC_Rate_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Rate))
         {
            idb.AddParameter("@SC_Rate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Rate", bse_CheckValue.SC_Rate);
         }
          }
         if(bse_CheckValue.SC_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_Stat))
         {
            idb.AddParameter("@SC_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Stat", bse_CheckValue.SC_Stat);
         }
          }
         if(bse_CheckValue.SC_StatNames_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_StatNames))
         {
            idb.AddParameter("@SC_StatNames", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_StatNames", bse_CheckValue.SC_StatNames);
         }
          }
         if(bse_CheckValue.SC_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CheckValue.SC_RefCode))
         {
            idb.AddParameter("@SC_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_RefCode", bse_CheckValue.SC_RefCode);
         }
          }
         if(bse_CheckValue.Stat_IsChanged)
         {
         if (bse_CheckValue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CheckValue.Stat);
         }
          }
         if(bse_CheckValue.CreateTime_IsChanged)
         {
         if (bse_CheckValue.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_CheckValue.CreateTime);
         }
          }
         if(bse_CheckValue.UpdateTime_IsChanged)
         {
         if (bse_CheckValue.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_CheckValue.UpdateTime);
         }
          }
         if(bse_CheckValue.DeleteTime_IsChanged)
         {
         if (bse_CheckValue.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_CheckValue.DeleteTime);
         }
          }

         idb.AddParameter("@SC_ID", bse_CheckValue.SC_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_CheckValue对象(即:一条记录
      /// </summary>
      public int Delete(decimal sC_ID)
      {
         string sql = "DELETE Bse_CheckValue WHERE 1=1  AND SC_ID=@SC_ID ";
         idb.AddParameter("@SC_ID", sC_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_CheckValue对象(即:一条记录
      /// </summary>
      public Bse_CheckValue GetByKey(decimal sC_ID)
      {
         Bse_CheckValue bse_CheckValue = new Bse_CheckValue();
         string sql = "SELECT  SC_ID,SC_Code,SC_StationCode,SC_StatName,SC_Source,SC_Position,SC_Alarm,SC_Warn,SC_Bak1,SC_Bak2,SC_iType,SC_Rate,SC_Stat,SC_StatNames,SC_RefCode,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_CheckValue WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SC_ID=@SC_ID ";
         idb.AddParameter("@SC_ID", sC_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SC_ID"] != DBNull.Value) bse_CheckValue.SC_ID = Convert.ToDecimal(dr["SC_ID"]);
            if (dr["SC_Code"] != DBNull.Value) bse_CheckValue.SC_Code = Convert.ToString(dr["SC_Code"]);
            if (dr["SC_StationCode"] != DBNull.Value) bse_CheckValue.SC_StationCode = Convert.ToString(dr["SC_StationCode"]);
            if (dr["SC_StatName"] != DBNull.Value) bse_CheckValue.SC_StatName = Convert.ToString(dr["SC_StatName"]);
            if (dr["SC_Source"] != DBNull.Value) bse_CheckValue.SC_Source = Convert.ToString(dr["SC_Source"]);
            if (dr["SC_Position"] != DBNull.Value) bse_CheckValue.SC_Position = Convert.ToString(dr["SC_Position"]);
            if (dr["SC_Alarm"] != DBNull.Value) bse_CheckValue.SC_Alarm = Convert.ToString(dr["SC_Alarm"]);
            if (dr["SC_Warn"] != DBNull.Value) bse_CheckValue.SC_Warn = Convert.ToString(dr["SC_Warn"]);
            if (dr["SC_Bak1"] != DBNull.Value) bse_CheckValue.SC_Bak1 = Convert.ToString(dr["SC_Bak1"]);
            if (dr["SC_Bak2"] != DBNull.Value) bse_CheckValue.SC_Bak2 = Convert.ToString(dr["SC_Bak2"]);
            if (dr["SC_iType"] != DBNull.Value) bse_CheckValue.SC_iType = Convert.ToString(dr["SC_iType"]);
            if (dr["SC_Rate"] != DBNull.Value) bse_CheckValue.SC_Rate = Convert.ToString(dr["SC_Rate"]);
            if (dr["SC_Stat"] != DBNull.Value) bse_CheckValue.SC_Stat = Convert.ToString(dr["SC_Stat"]);
            if (dr["SC_StatNames"] != DBNull.Value) bse_CheckValue.SC_StatNames = Convert.ToString(dr["SC_StatNames"]);
            if (dr["SC_RefCode"] != DBNull.Value) bse_CheckValue.SC_RefCode = Convert.ToString(dr["SC_RefCode"]);
            if (dr["Stat"] != DBNull.Value) bse_CheckValue.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_CheckValue.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_CheckValue.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_CheckValue.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_CheckValue;
      }
      /// <summary>
      /// 获取指定的Bse_CheckValue对象集合
      /// </summary>
      public List<Bse_CheckValue> GetListByWhere(string strCondition)
      {
         List<Bse_CheckValue> ret = new List<Bse_CheckValue>();
         string sql = "SELECT  SC_ID,SC_Code,SC_StationCode,SC_StatName,SC_Source,SC_Position,SC_Alarm,SC_Warn,SC_Bak1,SC_Bak2,SC_iType,SC_Rate,SC_Stat,SC_StatNames,SC_RefCode,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_CheckValue WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY SC_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_CheckValue bse_CheckValue = new Bse_CheckValue();
            if (dr["SC_ID"] != DBNull.Value) bse_CheckValue.SC_ID = Convert.ToDecimal(dr["SC_ID"]);
            if (dr["SC_Code"] != DBNull.Value) bse_CheckValue.SC_Code = Convert.ToString(dr["SC_Code"]);
            if (dr["SC_StationCode"] != DBNull.Value) bse_CheckValue.SC_StationCode = Convert.ToString(dr["SC_StationCode"]);
            if (dr["SC_StatName"] != DBNull.Value) bse_CheckValue.SC_StatName = Convert.ToString(dr["SC_StatName"]);
            if (dr["SC_Source"] != DBNull.Value) bse_CheckValue.SC_Source = Convert.ToString(dr["SC_Source"]);
            if (dr["SC_Position"] != DBNull.Value) bse_CheckValue.SC_Position = Convert.ToString(dr["SC_Position"]);
            if (dr["SC_Alarm"] != DBNull.Value) bse_CheckValue.SC_Alarm = Convert.ToString(dr["SC_Alarm"]);
            if (dr["SC_Warn"] != DBNull.Value) bse_CheckValue.SC_Warn = Convert.ToString(dr["SC_Warn"]);
            if (dr["SC_Bak1"] != DBNull.Value) bse_CheckValue.SC_Bak1 = Convert.ToString(dr["SC_Bak1"]);
            if (dr["SC_Bak2"] != DBNull.Value) bse_CheckValue.SC_Bak2 = Convert.ToString(dr["SC_Bak2"]);
            if (dr["SC_iType"] != DBNull.Value) bse_CheckValue.SC_iType = Convert.ToString(dr["SC_iType"]);
            if (dr["SC_Rate"] != DBNull.Value) bse_CheckValue.SC_Rate = Convert.ToString(dr["SC_Rate"]);
            if (dr["SC_Stat"] != DBNull.Value) bse_CheckValue.SC_Stat = Convert.ToString(dr["SC_Stat"]);
            if (dr["SC_StatNames"] != DBNull.Value) bse_CheckValue.SC_StatNames = Convert.ToString(dr["SC_StatNames"]);
            if (dr["SC_RefCode"] != DBNull.Value) bse_CheckValue.SC_RefCode = Convert.ToString(dr["SC_RefCode"]);
            if (dr["Stat"] != DBNull.Value) bse_CheckValue.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_CheckValue.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_CheckValue.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_CheckValue.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_CheckValue);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_CheckValue对象(即:一条记录
      /// </summary>
      public List<Bse_CheckValue> GetAll()
      {
         List<Bse_CheckValue> ret = new List<Bse_CheckValue>();
         string sql = "SELECT  SC_ID,SC_Code,SC_StationCode,SC_StatName,SC_Source,SC_Position,SC_Alarm,SC_Warn,SC_Bak1,SC_Bak2,SC_iType,SC_Rate,SC_Stat,SC_StatNames,SC_RefCode,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_CheckValue where 1=1 AND ((Stat is null) or (Stat=0) ) order by SC_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_CheckValue bse_CheckValue = new Bse_CheckValue();
            if (dr["SC_ID"] != DBNull.Value) bse_CheckValue.SC_ID = Convert.ToDecimal(dr["SC_ID"]);
            if (dr["SC_Code"] != DBNull.Value) bse_CheckValue.SC_Code = Convert.ToString(dr["SC_Code"]);
            if (dr["SC_StationCode"] != DBNull.Value) bse_CheckValue.SC_StationCode = Convert.ToString(dr["SC_StationCode"]);
            if (dr["SC_StatName"] != DBNull.Value) bse_CheckValue.SC_StatName = Convert.ToString(dr["SC_StatName"]);
            if (dr["SC_Source"] != DBNull.Value) bse_CheckValue.SC_Source = Convert.ToString(dr["SC_Source"]);
            if (dr["SC_Position"] != DBNull.Value) bse_CheckValue.SC_Position = Convert.ToString(dr["SC_Position"]);
            if (dr["SC_Alarm"] != DBNull.Value) bse_CheckValue.SC_Alarm = Convert.ToString(dr["SC_Alarm"]);
            if (dr["SC_Warn"] != DBNull.Value) bse_CheckValue.SC_Warn = Convert.ToString(dr["SC_Warn"]);
            if (dr["SC_Bak1"] != DBNull.Value) bse_CheckValue.SC_Bak1 = Convert.ToString(dr["SC_Bak1"]);
            if (dr["SC_Bak2"] != DBNull.Value) bse_CheckValue.SC_Bak2 = Convert.ToString(dr["SC_Bak2"]);
            if (dr["SC_iType"] != DBNull.Value) bse_CheckValue.SC_iType = Convert.ToString(dr["SC_iType"]);
            if (dr["SC_Rate"] != DBNull.Value) bse_CheckValue.SC_Rate = Convert.ToString(dr["SC_Rate"]);
            if (dr["SC_Stat"] != DBNull.Value) bse_CheckValue.SC_Stat = Convert.ToString(dr["SC_Stat"]);
            if (dr["SC_StatNames"] != DBNull.Value) bse_CheckValue.SC_StatNames = Convert.ToString(dr["SC_StatNames"]);
            if (dr["SC_RefCode"] != DBNull.Value) bse_CheckValue.SC_RefCode = Convert.ToString(dr["SC_RefCode"]);
            if (dr["Stat"] != DBNull.Value) bse_CheckValue.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_CheckValue.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_CheckValue.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_CheckValue.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_CheckValue);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
