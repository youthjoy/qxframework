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
   public partial class ADOBse_Station
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_Station对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Station bse_Station)
      {
         string sql = "INSERT INTO Bse_Station (SN_Code,SN_Name,SN_AreaCode,SN_AreaName,SN_Mark,SN_Number,SN_Bak,SN_Interval,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@SN_Code,@SN_Name,@SN_AreaCode,@SN_AreaName,@SN_Mark,@SN_Number,@SN_Bak,@SN_Interval,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_Station.SN_Code))
         {
            idb.AddParameter("@SN_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Code", bse_Station.SN_Code);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Name))
         {
            idb.AddParameter("@SN_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Name", bse_Station.SN_Name);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_AreaCode))
         {
            idb.AddParameter("@SN_AreaCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_AreaCode", bse_Station.SN_AreaCode);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_AreaName))
         {
            idb.AddParameter("@SN_AreaName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_AreaName", bse_Station.SN_AreaName);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Mark))
         {
            idb.AddParameter("@SN_Mark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Mark", bse_Station.SN_Mark);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Number))
         {
            idb.AddParameter("@SN_Number", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Number", bse_Station.SN_Number);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Bak))
         {
            idb.AddParameter("@SN_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Bak", bse_Station.SN_Bak);
         }
         if (bse_Station.SN_Interval == 0)
         {
            idb.AddParameter("@SN_Interval", 0);
         }
         else
         {
            idb.AddParameter("@SN_Interval", bse_Station.SN_Interval);
         }
         if (bse_Station.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Station.Stat);
         }
         if (bse_Station.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Station.CreateTime);
         }
         if (bse_Station.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Station.UpdateTime);
         }
         if (bse_Station.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Station.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_Station对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Station bse_Station)
      {
         string sql = "INSERT INTO Bse_Station (SN_Code,SN_Name,SN_AreaCode,SN_AreaName,SN_Mark,SN_Number,SN_Bak,SN_Interval,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@SN_Code,@SN_Name,@SN_AreaCode,@SN_AreaName,@SN_Mark,@SN_Number,@SN_Bak,@SN_Interval,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Station.SN_Code))
         {
            idb.AddParameter("@SN_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Code", bse_Station.SN_Code);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Name))
         {
            idb.AddParameter("@SN_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Name", bse_Station.SN_Name);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_AreaCode))
         {
            idb.AddParameter("@SN_AreaCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_AreaCode", bse_Station.SN_AreaCode);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_AreaName))
         {
            idb.AddParameter("@SN_AreaName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_AreaName", bse_Station.SN_AreaName);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Mark))
         {
            idb.AddParameter("@SN_Mark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Mark", bse_Station.SN_Mark);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Number))
         {
            idb.AddParameter("@SN_Number", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Number", bse_Station.SN_Number);
         }
         if (string.IsNullOrEmpty(bse_Station.SN_Bak))
         {
            idb.AddParameter("@SN_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Bak", bse_Station.SN_Bak);
         }
         if (bse_Station.SN_Interval == 0)
         {
            idb.AddParameter("@SN_Interval", 0);
         }
         else
         {
            idb.AddParameter("@SN_Interval", bse_Station.SN_Interval);
         }
         if (bse_Station.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Station.Stat);
         }
         if (bse_Station.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Station.CreateTime);
         }
         if (bse_Station.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Station.UpdateTime);
         }
         if (bse_Station.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Station.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_Station对象(即:一条记录
      /// </summary>
      public int Update(Bse_Station bse_Station)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Station       SET ");
            if(bse_Station.SN_Code_IsChanged){sbParameter.Append("SN_Code=@SN_Code, ");}
      if(bse_Station.SN_Name_IsChanged){sbParameter.Append("SN_Name=@SN_Name, ");}
      if(bse_Station.SN_AreaCode_IsChanged){sbParameter.Append("SN_AreaCode=@SN_AreaCode, ");}
      if(bse_Station.SN_AreaName_IsChanged){sbParameter.Append("SN_AreaName=@SN_AreaName, ");}
      if(bse_Station.SN_Mark_IsChanged){sbParameter.Append("SN_Mark=@SN_Mark, ");}
      if(bse_Station.SN_Number_IsChanged){sbParameter.Append("SN_Number=@SN_Number, ");}
      if(bse_Station.SN_Bak_IsChanged){sbParameter.Append("SN_Bak=@SN_Bak, ");}
      if(bse_Station.SN_Interval_IsChanged){sbParameter.Append("SN_Interval=@SN_Interval, ");}
      if(bse_Station.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Station.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_Station.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_Station.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SN_ID=@SN_ID; " );
      string sql=sb.ToString();
         if(bse_Station.SN_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Station.SN_Code))
         {
            idb.AddParameter("@SN_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Code", bse_Station.SN_Code);
         }
          }
         if(bse_Station.SN_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Station.SN_Name))
         {
            idb.AddParameter("@SN_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Name", bse_Station.SN_Name);
         }
          }
         if(bse_Station.SN_AreaCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Station.SN_AreaCode))
         {
            idb.AddParameter("@SN_AreaCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_AreaCode", bse_Station.SN_AreaCode);
         }
          }
         if(bse_Station.SN_AreaName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Station.SN_AreaName))
         {
            idb.AddParameter("@SN_AreaName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_AreaName", bse_Station.SN_AreaName);
         }
          }
         if(bse_Station.SN_Mark_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Station.SN_Mark))
         {
            idb.AddParameter("@SN_Mark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Mark", bse_Station.SN_Mark);
         }
          }
         if(bse_Station.SN_Number_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Station.SN_Number))
         {
            idb.AddParameter("@SN_Number", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Number", bse_Station.SN_Number);
         }
          }
         if(bse_Station.SN_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Station.SN_Bak))
         {
            idb.AddParameter("@SN_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Bak", bse_Station.SN_Bak);
         }
          }
         if(bse_Station.SN_Interval_IsChanged)
         {
         if (bse_Station.SN_Interval == 0)
         {
            idb.AddParameter("@SN_Interval", 0);
         }
         else
         {
            idb.AddParameter("@SN_Interval", bse_Station.SN_Interval);
         }
          }
         if(bse_Station.Stat_IsChanged)
         {
         if (bse_Station.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Station.Stat);
         }
          }
         if(bse_Station.CreateTime_IsChanged)
         {
         if (bse_Station.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Station.CreateTime);
         }
          }
         if(bse_Station.UpdateTime_IsChanged)
         {
         if (bse_Station.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Station.UpdateTime);
         }
          }
         if(bse_Station.DeleteTime_IsChanged)
         {
         if (bse_Station.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Station.DeleteTime);
         }
          }

         idb.AddParameter("@SN_ID", bse_Station.SN_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_Station对象(即:一条记录
      /// </summary>
      public int Delete(decimal sN_ID)
      {
         string sql = "DELETE Bse_Station WHERE 1=1  AND SN_ID=@SN_ID ";
         idb.AddParameter("@SN_ID", sN_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_Station对象(即:一条记录
      /// </summary>
      public Bse_Station GetByKey(decimal sN_ID)
      {
         Bse_Station bse_Station = new Bse_Station();
         string sql = "SELECT  SN_ID,SN_Code,SN_Name,SN_AreaCode,SN_AreaName,SN_Mark,SN_Number,SN_Bak,SN_Interval,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Station WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SN_ID=@SN_ID ";
         idb.AddParameter("@SN_ID", sN_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SN_ID"] != DBNull.Value) bse_Station.SN_ID = Convert.ToDecimal(dr["SN_ID"]);
            if (dr["SN_Code"] != DBNull.Value) bse_Station.SN_Code = Convert.ToString(dr["SN_Code"]);
            if (dr["SN_Name"] != DBNull.Value) bse_Station.SN_Name = Convert.ToString(dr["SN_Name"]);
            if (dr["SN_AreaCode"] != DBNull.Value) bse_Station.SN_AreaCode = Convert.ToString(dr["SN_AreaCode"]);
            if (dr["SN_AreaName"] != DBNull.Value) bse_Station.SN_AreaName = Convert.ToString(dr["SN_AreaName"]);
            if (dr["SN_Mark"] != DBNull.Value) bse_Station.SN_Mark = Convert.ToString(dr["SN_Mark"]);
            if (dr["SN_Number"] != DBNull.Value) bse_Station.SN_Number = Convert.ToString(dr["SN_Number"]);
            if (dr["SN_Bak"] != DBNull.Value) bse_Station.SN_Bak = Convert.ToString(dr["SN_Bak"]);
            if (dr["SN_Interval"] != DBNull.Value) bse_Station.SN_Interval = Convert.ToSingle(dr["SN_Interval"]);
            if (dr["Stat"] != DBNull.Value) bse_Station.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Station.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Station.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Station.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Station;
      }
      /// <summary>
      /// 获取指定的Bse_Station对象集合
      /// </summary>
      public List<Bse_Station> GetListByWhere(string strCondition)
      {
         List<Bse_Station> ret = new List<Bse_Station>();
         string sql = "SELECT  SN_ID,SN_Code,SN_Name,SN_AreaCode,SN_AreaName,SN_Mark,SN_Number,SN_Bak,SN_Interval,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Station WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY SN_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Station bse_Station = new Bse_Station();
            if (dr["SN_ID"] != DBNull.Value) bse_Station.SN_ID = Convert.ToDecimal(dr["SN_ID"]);
            if (dr["SN_Code"] != DBNull.Value) bse_Station.SN_Code = Convert.ToString(dr["SN_Code"]);
            if (dr["SN_Name"] != DBNull.Value) bse_Station.SN_Name = Convert.ToString(dr["SN_Name"]);
            if (dr["SN_AreaCode"] != DBNull.Value) bse_Station.SN_AreaCode = Convert.ToString(dr["SN_AreaCode"]);
            if (dr["SN_AreaName"] != DBNull.Value) bse_Station.SN_AreaName = Convert.ToString(dr["SN_AreaName"]);
            if (dr["SN_Mark"] != DBNull.Value) bse_Station.SN_Mark = Convert.ToString(dr["SN_Mark"]);
            if (dr["SN_Number"] != DBNull.Value) bse_Station.SN_Number = Convert.ToString(dr["SN_Number"]);
            if (dr["SN_Bak"] != DBNull.Value) bse_Station.SN_Bak = Convert.ToString(dr["SN_Bak"]);
            if (dr["SN_Interval"] != DBNull.Value) bse_Station.SN_Interval = Convert.ToSingle(dr["SN_Interval"]);
            if (dr["Stat"] != DBNull.Value) bse_Station.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Station.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Station.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Station.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Station);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_Station对象(即:一条记录
      /// </summary>
      public List<Bse_Station> GetAll()
      {
         List<Bse_Station> ret = new List<Bse_Station>();
         string sql = "SELECT  SN_ID,SN_Code,SN_Name,SN_AreaCode,SN_AreaName,SN_Mark,SN_Number,SN_Bak,SN_Interval,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Station where 1=1 AND ((Stat is null) or (Stat=0) ) order by SN_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Station bse_Station = new Bse_Station();
            if (dr["SN_ID"] != DBNull.Value) bse_Station.SN_ID = Convert.ToDecimal(dr["SN_ID"]);
            if (dr["SN_Code"] != DBNull.Value) bse_Station.SN_Code = Convert.ToString(dr["SN_Code"]);
            if (dr["SN_Name"] != DBNull.Value) bse_Station.SN_Name = Convert.ToString(dr["SN_Name"]);
            if (dr["SN_AreaCode"] != DBNull.Value) bse_Station.SN_AreaCode = Convert.ToString(dr["SN_AreaCode"]);
            if (dr["SN_AreaName"] != DBNull.Value) bse_Station.SN_AreaName = Convert.ToString(dr["SN_AreaName"]);
            if (dr["SN_Mark"] != DBNull.Value) bse_Station.SN_Mark = Convert.ToString(dr["SN_Mark"]);
            if (dr["SN_Number"] != DBNull.Value) bse_Station.SN_Number = Convert.ToString(dr["SN_Number"]);
            if (dr["SN_Bak"] != DBNull.Value) bse_Station.SN_Bak = Convert.ToString(dr["SN_Bak"]);
            if (dr["SN_Interval"] != DBNull.Value) bse_Station.SN_Interval = Convert.ToSingle(dr["SN_Interval"]);
            if (dr["Stat"] != DBNull.Value) bse_Station.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Station.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Station.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Station.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Station);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
