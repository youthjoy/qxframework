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
   /// 车辆配置表
   /// </summary>
   [Serializable]
   public partial class ADOGPS_CarConfig
   {
      public IDBOperator idb =  DBOperator.GetGPSInstance();
      /// <summary>
      /// 添加车辆配置表 GPS_CarConfig对象(即:一条记录)
      /// </summary>
      public int Add(GPS_CarConfig gPS_CarConfig)
      {
         string sql = "INSERT INTO GPS_CarConfig (Car_No,Car_Icon,Car_CurPerson,Car_CurPersonTel,Car_Address,Car_ShowTxtR,Car_ShowTxt,Car_Staus,Stat) VALUES (@Car_No,@Car_Icon,@Car_CurPerson,@Car_CurPersonTel,@Car_Address,@Car_ShowTxtR,@Car_ShowTxt,@Car_Staus,@Stat)";
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_No))
         {
            idb.AddParameter("@Car_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_No", gPS_CarConfig.Car_No);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Icon))
         {
            idb.AddParameter("@Car_Icon", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Icon", gPS_CarConfig.Car_Icon);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_CurPerson))
         {
            idb.AddParameter("@Car_CurPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_CurPerson", gPS_CarConfig.Car_CurPerson);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_CurPersonTel))
         {
            idb.AddParameter("@Car_CurPersonTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_CurPersonTel", gPS_CarConfig.Car_CurPersonTel);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Address))
         {
            idb.AddParameter("@Car_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Address", gPS_CarConfig.Car_Address);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_ShowTxtR))
         {
            idb.AddParameter("@Car_ShowTxtR", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_ShowTxtR", gPS_CarConfig.Car_ShowTxtR);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_ShowTxt))
         {
            idb.AddParameter("@Car_ShowTxt", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_ShowTxt", gPS_CarConfig.Car_ShowTxt);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Staus))
         {
            idb.AddParameter("@Car_Staus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Staus", gPS_CarConfig.Car_Staus);
         }
         if (gPS_CarConfig.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gPS_CarConfig.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加车辆配置表 GPS_CarConfig对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(GPS_CarConfig gPS_CarConfig)
      {
         string sql = "INSERT INTO GPS_CarConfig (Car_No,Car_Icon,Car_CurPerson,Car_CurPersonTel,Car_Address,Car_ShowTxtR,Car_ShowTxt,Car_Staus,Stat) VALUES (@Car_No,@Car_Icon,@Car_CurPerson,@Car_CurPersonTel,@Car_Address,@Car_ShowTxtR,@Car_ShowTxt,@Car_Staus,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_No))
         {
            idb.AddParameter("@Car_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_No", gPS_CarConfig.Car_No);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Icon))
         {
            idb.AddParameter("@Car_Icon", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Icon", gPS_CarConfig.Car_Icon);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_CurPerson))
         {
            idb.AddParameter("@Car_CurPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_CurPerson", gPS_CarConfig.Car_CurPerson);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_CurPersonTel))
         {
            idb.AddParameter("@Car_CurPersonTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_CurPersonTel", gPS_CarConfig.Car_CurPersonTel);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Address))
         {
            idb.AddParameter("@Car_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Address", gPS_CarConfig.Car_Address);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_ShowTxtR))
         {
            idb.AddParameter("@Car_ShowTxtR", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_ShowTxtR", gPS_CarConfig.Car_ShowTxtR);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_ShowTxt))
         {
            idb.AddParameter("@Car_ShowTxt", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_ShowTxt", gPS_CarConfig.Car_ShowTxt);
         }
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Staus))
         {
            idb.AddParameter("@Car_Staus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Staus", gPS_CarConfig.Car_Staus);
         }
         if (gPS_CarConfig.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gPS_CarConfig.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新车辆配置表 GPS_CarConfig对象(即:一条记录
      /// </summary>
      public int Update(GPS_CarConfig gPS_CarConfig)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       GPS_CarConfig       SET ");
            if(gPS_CarConfig.Car_No_IsChanged){sbParameter.Append("Car_No=@Car_No, ");}
      if(gPS_CarConfig.Car_Icon_IsChanged){sbParameter.Append("Car_Icon=@Car_Icon, ");}
      if(gPS_CarConfig.Car_CurPerson_IsChanged){sbParameter.Append("Car_CurPerson=@Car_CurPerson, ");}
      if(gPS_CarConfig.Car_CurPersonTel_IsChanged){sbParameter.Append("Car_CurPersonTel=@Car_CurPersonTel, ");}
      if(gPS_CarConfig.Car_Address_IsChanged){sbParameter.Append("Car_Address=@Car_Address, ");}
      if(gPS_CarConfig.Car_ShowTxtR_IsChanged){sbParameter.Append("Car_ShowTxtR=@Car_ShowTxtR, ");}
      if(gPS_CarConfig.Car_ShowTxt_IsChanged){sbParameter.Append("Car_ShowTxt=@Car_ShowTxt, ");}
      if(gPS_CarConfig.Car_Staus_IsChanged){sbParameter.Append("Car_Staus=@Car_Staus, ");}
      if(gPS_CarConfig.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and G_ID=@G_ID; " );
      string sql=sb.ToString();
         if(gPS_CarConfig.Car_No_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_No))
         {
            idb.AddParameter("@Car_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_No", gPS_CarConfig.Car_No);
         }
          }
         if(gPS_CarConfig.Car_Icon_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Icon))
         {
            idb.AddParameter("@Car_Icon", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Icon", gPS_CarConfig.Car_Icon);
         }
          }
         if(gPS_CarConfig.Car_CurPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_CurPerson))
         {
            idb.AddParameter("@Car_CurPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_CurPerson", gPS_CarConfig.Car_CurPerson);
         }
          }
         if(gPS_CarConfig.Car_CurPersonTel_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_CurPersonTel))
         {
            idb.AddParameter("@Car_CurPersonTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_CurPersonTel", gPS_CarConfig.Car_CurPersonTel);
         }
          }
         if(gPS_CarConfig.Car_Address_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Address))
         {
            idb.AddParameter("@Car_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Address", gPS_CarConfig.Car_Address);
         }
          }
         if(gPS_CarConfig.Car_ShowTxtR_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_ShowTxtR))
         {
            idb.AddParameter("@Car_ShowTxtR", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_ShowTxtR", gPS_CarConfig.Car_ShowTxtR);
         }
          }
         if(gPS_CarConfig.Car_ShowTxt_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_ShowTxt))
         {
            idb.AddParameter("@Car_ShowTxt", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_ShowTxt", gPS_CarConfig.Car_ShowTxt);
         }
          }
         if(gPS_CarConfig.Car_Staus_IsChanged)
         {
         if (string.IsNullOrEmpty(gPS_CarConfig.Car_Staus))
         {
            idb.AddParameter("@Car_Staus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Car_Staus", gPS_CarConfig.Car_Staus);
         }
          }
         if(gPS_CarConfig.Stat_IsChanged)
         {
         if (gPS_CarConfig.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gPS_CarConfig.Stat);
         }
          }

         idb.AddParameter("@G_ID", gPS_CarConfig.G_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除车辆配置表 GPS_CarConfig对象(即:一条记录
      /// </summary>
      public int Delete(decimal g_ID)
      {
         string sql = "DELETE GPS_CarConfig WHERE 1=1  AND G_ID=@G_ID ";
         idb.AddParameter("@G_ID", g_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的车辆配置表 GPS_CarConfig对象(即:一条记录
      /// </summary>
      public GPS_CarConfig GetByKey(decimal g_ID)
      {
         GPS_CarConfig gPS_CarConfig = new GPS_CarConfig();
         string sql = "SELECT  G_ID,Car_No,Car_Icon,Car_CurPerson,Car_CurPersonTel,Car_Address,Car_ShowTxtR,Car_ShowTxt,Car_Staus,Stat FROM GPS_CarConfig WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND G_ID=@G_ID ";
         idb.AddParameter("@G_ID", g_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["G_ID"] != DBNull.Value) gPS_CarConfig.G_ID = Convert.ToDecimal(dr["G_ID"]);
            if (dr["Car_No"] != DBNull.Value) gPS_CarConfig.Car_No = Convert.ToString(dr["Car_No"]);
            if (dr["Car_Icon"] != DBNull.Value) gPS_CarConfig.Car_Icon = Convert.ToString(dr["Car_Icon"]);
            if (dr["Car_CurPerson"] != DBNull.Value) gPS_CarConfig.Car_CurPerson = Convert.ToString(dr["Car_CurPerson"]);
            if (dr["Car_CurPersonTel"] != DBNull.Value) gPS_CarConfig.Car_CurPersonTel = Convert.ToString(dr["Car_CurPersonTel"]);
            if (dr["Car_Address"] != DBNull.Value) gPS_CarConfig.Car_Address = Convert.ToString(dr["Car_Address"]);
            if (dr["Car_ShowTxtR"] != DBNull.Value) gPS_CarConfig.Car_ShowTxtR = Convert.ToString(dr["Car_ShowTxtR"]);
            if (dr["Car_ShowTxt"] != DBNull.Value) gPS_CarConfig.Car_ShowTxt = Convert.ToString(dr["Car_ShowTxt"]);
            if (dr["Car_Staus"] != DBNull.Value) gPS_CarConfig.Car_Staus = Convert.ToString(dr["Car_Staus"]);
            if (dr["Stat"] != DBNull.Value) gPS_CarConfig.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return gPS_CarConfig;
      }
      /// <summary>
      /// 获取指定的车辆配置表 GPS_CarConfig对象集合
      /// </summary>
      public List<GPS_CarConfig> GetListByWhere(string strCondition)
      {
         List<GPS_CarConfig> ret = new List<GPS_CarConfig>();
         string sql = "SELECT  G_ID,Car_No,Car_Icon,Car_CurPerson,Car_CurPersonTel,Car_Address,Car_ShowTxtR,Car_ShowTxt,Car_Staus,Stat FROM GPS_CarConfig WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            GPS_CarConfig gPS_CarConfig = new GPS_CarConfig();
            if (dr["G_ID"] != DBNull.Value) gPS_CarConfig.G_ID = Convert.ToDecimal(dr["G_ID"]);
            if (dr["Car_No"] != DBNull.Value) gPS_CarConfig.Car_No = Convert.ToString(dr["Car_No"]);
            if (dr["Car_Icon"] != DBNull.Value) gPS_CarConfig.Car_Icon = Convert.ToString(dr["Car_Icon"]);
            if (dr["Car_CurPerson"] != DBNull.Value) gPS_CarConfig.Car_CurPerson = Convert.ToString(dr["Car_CurPerson"]);
            if (dr["Car_CurPersonTel"] != DBNull.Value) gPS_CarConfig.Car_CurPersonTel = Convert.ToString(dr["Car_CurPersonTel"]);
            if (dr["Car_Address"] != DBNull.Value) gPS_CarConfig.Car_Address = Convert.ToString(dr["Car_Address"]);
            if (dr["Car_ShowTxtR"] != DBNull.Value) gPS_CarConfig.Car_ShowTxtR = Convert.ToString(dr["Car_ShowTxtR"]);
            if (dr["Car_ShowTxt"] != DBNull.Value) gPS_CarConfig.Car_ShowTxt = Convert.ToString(dr["Car_ShowTxt"]);
            if (dr["Car_Staus"] != DBNull.Value) gPS_CarConfig.Car_Staus = Convert.ToString(dr["Car_Staus"]);
            if (dr["Stat"] != DBNull.Value) gPS_CarConfig.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(gPS_CarConfig);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的车辆配置表 GPS_CarConfig对象(即:一条记录
      /// </summary>
      public List<GPS_CarConfig> GetAll()
      {
         List<GPS_CarConfig> ret = new List<GPS_CarConfig>();
         string sql = "SELECT  G_ID,Car_No,Car_Icon,Car_CurPerson,Car_CurPersonTel,Car_Address,Car_ShowTxtR,Car_ShowTxt,Car_Staus,Stat FROM GPS_CarConfig where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            GPS_CarConfig gPS_CarConfig = new GPS_CarConfig();
            if (dr["G_ID"] != DBNull.Value) gPS_CarConfig.G_ID = Convert.ToDecimal(dr["G_ID"]);
            if (dr["Car_No"] != DBNull.Value) gPS_CarConfig.Car_No = Convert.ToString(dr["Car_No"]);
            if (dr["Car_Icon"] != DBNull.Value) gPS_CarConfig.Car_Icon = Convert.ToString(dr["Car_Icon"]);
            if (dr["Car_CurPerson"] != DBNull.Value) gPS_CarConfig.Car_CurPerson = Convert.ToString(dr["Car_CurPerson"]);
            if (dr["Car_CurPersonTel"] != DBNull.Value) gPS_CarConfig.Car_CurPersonTel = Convert.ToString(dr["Car_CurPersonTel"]);
            if (dr["Car_Address"] != DBNull.Value) gPS_CarConfig.Car_Address = Convert.ToString(dr["Car_Address"]);
            if (dr["Car_ShowTxtR"] != DBNull.Value) gPS_CarConfig.Car_ShowTxtR = Convert.ToString(dr["Car_ShowTxtR"]);
            if (dr["Car_ShowTxt"] != DBNull.Value) gPS_CarConfig.Car_ShowTxt = Convert.ToString(dr["Car_ShowTxt"]);
            if (dr["Car_Staus"] != DBNull.Value) gPS_CarConfig.Car_Staus = Convert.ToString(dr["Car_Staus"]);
            if (dr["Stat"] != DBNull.Value) gPS_CarConfig.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(gPS_CarConfig);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
