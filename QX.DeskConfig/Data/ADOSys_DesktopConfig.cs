using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DeskConfig.Model;
using QX.DataAcess;

namespace QX.DeskConfig.DAL
{
   /// <summary>
   /// 桌面配置
   /// </summary>
   [Serializable]
   public partial class ADOSys_DesktopConfig
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加桌面配置 Sys_DesktopConfig对象(即:一条记录)
      /// </summary>
      public int Add(Sys_DesktopConfig sys_DesktopConfig)
      {
         string sql = "INSERT INTO Sys_DesktopConfig (SC_AreaCode,SC_AreaName,SC_AreaPCode,SC_AreaPName,SC_SQL,SC_Loop,SC_URL,Stat,SC_Order,SC_Group,SC_Filter,SC_Color) VALUES (@SC_AreaCode,@SC_AreaName,@SC_AreaPCode,@SC_AreaPName,@SC_SQL,@SC_Loop,@SC_URL,@Stat,@SC_Order,@SC_Group,@SC_Filter,@SC_Color)";
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaCode))
         {
            idb.AddParameter("@SC_AreaCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaCode", sys_DesktopConfig.SC_AreaCode);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaName))
         {
            idb.AddParameter("@SC_AreaName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaName", sys_DesktopConfig.SC_AreaName);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaPCode))
         {
            idb.AddParameter("@SC_AreaPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaPCode", sys_DesktopConfig.SC_AreaPCode);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaPName))
         {
            idb.AddParameter("@SC_AreaPName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaPName", sys_DesktopConfig.SC_AreaPName);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_SQL))
         {
            idb.AddParameter("@SC_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_SQL", sys_DesktopConfig.SC_SQL);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Loop))
         {
            idb.AddParameter("@SC_Loop", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Loop", sys_DesktopConfig.SC_Loop);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_URL))
         {
            idb.AddParameter("@SC_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_URL", sys_DesktopConfig.SC_URL);
         }
         if (sys_DesktopConfig.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_DesktopConfig.Stat);
         }
         if (sys_DesktopConfig.SC_Order == 0)
         {
            idb.AddParameter("@SC_Order", 0);
         }
         else
         {
            idb.AddParameter("@SC_Order", sys_DesktopConfig.SC_Order);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Group))
         {
            idb.AddParameter("@SC_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Group", sys_DesktopConfig.SC_Group);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Filter))
         {
            idb.AddParameter("@SC_Filter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Filter", sys_DesktopConfig.SC_Filter);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Color))
         {
            idb.AddParameter("@SC_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Color", sys_DesktopConfig.SC_Color);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加桌面配置 Sys_DesktopConfig对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_DesktopConfig sys_DesktopConfig)
      {
         string sql = "INSERT INTO Sys_DesktopConfig (SC_AreaCode,SC_AreaName,SC_AreaPCode,SC_AreaPName,SC_SQL,SC_Loop,SC_URL,Stat,SC_Order,SC_Group,SC_Filter,SC_Color) VALUES (@SC_AreaCode,@SC_AreaName,@SC_AreaPCode,@SC_AreaPName,@SC_SQL,@SC_Loop,@SC_URL,@Stat,@SC_Order,@SC_Group,@SC_Filter,@SC_Color);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaCode))
         {
            idb.AddParameter("@SC_AreaCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaCode", sys_DesktopConfig.SC_AreaCode);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaName))
         {
            idb.AddParameter("@SC_AreaName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaName", sys_DesktopConfig.SC_AreaName);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaPCode))
         {
            idb.AddParameter("@SC_AreaPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaPCode", sys_DesktopConfig.SC_AreaPCode);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaPName))
         {
            idb.AddParameter("@SC_AreaPName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaPName", sys_DesktopConfig.SC_AreaPName);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_SQL))
         {
            idb.AddParameter("@SC_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_SQL", sys_DesktopConfig.SC_SQL);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Loop))
         {
            idb.AddParameter("@SC_Loop", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Loop", sys_DesktopConfig.SC_Loop);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_URL))
         {
            idb.AddParameter("@SC_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_URL", sys_DesktopConfig.SC_URL);
         }
         if (sys_DesktopConfig.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_DesktopConfig.Stat);
         }
         if (sys_DesktopConfig.SC_Order == 0)
         {
            idb.AddParameter("@SC_Order", 0);
         }
         else
         {
            idb.AddParameter("@SC_Order", sys_DesktopConfig.SC_Order);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Group))
         {
            idb.AddParameter("@SC_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Group", sys_DesktopConfig.SC_Group);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Filter))
         {
            idb.AddParameter("@SC_Filter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Filter", sys_DesktopConfig.SC_Filter);
         }
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Color))
         {
            idb.AddParameter("@SC_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Color", sys_DesktopConfig.SC_Color);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新桌面配置 Sys_DesktopConfig对象(即:一条记录
      /// </summary>
      public int Update(Sys_DesktopConfig sys_DesktopConfig)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_DesktopConfig       SET ");
            if(sys_DesktopConfig.SC_AreaCode_IsChanged){sbParameter.Append("SC_AreaCode=@SC_AreaCode, ");}
      if(sys_DesktopConfig.SC_AreaName_IsChanged){sbParameter.Append("SC_AreaName=@SC_AreaName, ");}
      if(sys_DesktopConfig.SC_AreaPCode_IsChanged){sbParameter.Append("SC_AreaPCode=@SC_AreaPCode, ");}
      if(sys_DesktopConfig.SC_AreaPName_IsChanged){sbParameter.Append("SC_AreaPName=@SC_AreaPName, ");}
      if(sys_DesktopConfig.SC_SQL_IsChanged){sbParameter.Append("SC_SQL=@SC_SQL, ");}
      if(sys_DesktopConfig.SC_Loop_IsChanged){sbParameter.Append("SC_Loop=@SC_Loop, ");}
      if(sys_DesktopConfig.SC_URL_IsChanged){sbParameter.Append("SC_URL=@SC_URL, ");}
      if(sys_DesktopConfig.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_DesktopConfig.SC_Order_IsChanged){sbParameter.Append("SC_Order=@SC_Order, ");}
      if(sys_DesktopConfig.SC_Group_IsChanged){sbParameter.Append("SC_Group=@SC_Group, ");}
      if(sys_DesktopConfig.SC_Filter_IsChanged){sbParameter.Append("SC_Filter=@SC_Filter, ");}
      if(sys_DesktopConfig.SC_Color_IsChanged){sbParameter.Append("SC_Color=@SC_Color ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SC_ID=@SC_ID; " );
      string sql=sb.ToString();
         if(sys_DesktopConfig.SC_AreaCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaCode))
         {
            idb.AddParameter("@SC_AreaCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaCode", sys_DesktopConfig.SC_AreaCode);
         }
          }
         if(sys_DesktopConfig.SC_AreaName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaName))
         {
            idb.AddParameter("@SC_AreaName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaName", sys_DesktopConfig.SC_AreaName);
         }
          }
         if(sys_DesktopConfig.SC_AreaPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaPCode))
         {
            idb.AddParameter("@SC_AreaPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaPCode", sys_DesktopConfig.SC_AreaPCode);
         }
          }
         if(sys_DesktopConfig.SC_AreaPName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_AreaPName))
         {
            idb.AddParameter("@SC_AreaPName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_AreaPName", sys_DesktopConfig.SC_AreaPName);
         }
          }
         if(sys_DesktopConfig.SC_SQL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_SQL))
         {
            idb.AddParameter("@SC_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_SQL", sys_DesktopConfig.SC_SQL);
         }
          }
         if(sys_DesktopConfig.SC_Loop_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Loop))
         {
            idb.AddParameter("@SC_Loop", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Loop", sys_DesktopConfig.SC_Loop);
         }
          }
         if(sys_DesktopConfig.SC_URL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_URL))
         {
            idb.AddParameter("@SC_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_URL", sys_DesktopConfig.SC_URL);
         }
          }
         if(sys_DesktopConfig.Stat_IsChanged)
         {
         if (sys_DesktopConfig.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_DesktopConfig.Stat);
         }
          }
         if(sys_DesktopConfig.SC_Order_IsChanged)
         {
         if (sys_DesktopConfig.SC_Order == 0)
         {
            idb.AddParameter("@SC_Order", 0);
         }
         else
         {
            idb.AddParameter("@SC_Order", sys_DesktopConfig.SC_Order);
         }
          }
         if(sys_DesktopConfig.SC_Group_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Group))
         {
            idb.AddParameter("@SC_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Group", sys_DesktopConfig.SC_Group);
         }
          }
         if(sys_DesktopConfig.SC_Filter_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Filter))
         {
            idb.AddParameter("@SC_Filter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Filter", sys_DesktopConfig.SC_Filter);
         }
          }
         if(sys_DesktopConfig.SC_Color_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_DesktopConfig.SC_Color))
         {
            idb.AddParameter("@SC_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_Color", sys_DesktopConfig.SC_Color);
         }
          }

         idb.AddParameter("@SC_ID", sys_DesktopConfig.SC_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除桌面配置 Sys_DesktopConfig对象(即:一条记录
      /// </summary>
      public int Delete(decimal sC_ID)
      {
         string sql = "DELETE Sys_DesktopConfig WHERE 1=1  AND SC_ID=@SC_ID ";
         idb.AddParameter("@SC_ID", sC_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的桌面配置 Sys_DesktopConfig对象(即:一条记录
      /// </summary>
      public Sys_DesktopConfig GetByKey(decimal sC_ID)
      {
         Sys_DesktopConfig sys_DesktopConfig = new Sys_DesktopConfig();
         string sql = "SELECT  SC_ID,SC_AreaCode,SC_AreaName,SC_AreaPCode,SC_AreaPName,SC_SQL,SC_Loop,SC_URL,Stat,SC_Order,SC_Group,SC_Filter,SC_Color FROM Sys_DesktopConfig WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SC_ID=@SC_ID ";
         idb.AddParameter("@SC_ID", sC_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SC_ID"] != DBNull.Value) sys_DesktopConfig.SC_ID = Convert.ToDecimal(dr["SC_ID"]);
            if (dr["SC_AreaCode"] != DBNull.Value) sys_DesktopConfig.SC_AreaCode = Convert.ToString(dr["SC_AreaCode"]);
            if (dr["SC_AreaName"] != DBNull.Value) sys_DesktopConfig.SC_AreaName = Convert.ToString(dr["SC_AreaName"]);
            if (dr["SC_AreaPCode"] != DBNull.Value) sys_DesktopConfig.SC_AreaPCode = Convert.ToString(dr["SC_AreaPCode"]);
            if (dr["SC_AreaPName"] != DBNull.Value) sys_DesktopConfig.SC_AreaPName = Convert.ToString(dr["SC_AreaPName"]);
            if (dr["SC_SQL"] != DBNull.Value) sys_DesktopConfig.SC_SQL = Convert.ToString(dr["SC_SQL"]);
            if (dr["SC_Loop"] != DBNull.Value) sys_DesktopConfig.SC_Loop = Convert.ToString(dr["SC_Loop"]);
            if (dr["SC_URL"] != DBNull.Value) sys_DesktopConfig.SC_URL = Convert.ToString(dr["SC_URL"]);
            if (dr["Stat"] != DBNull.Value) sys_DesktopConfig.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SC_Order"] != DBNull.Value) sys_DesktopConfig.SC_Order = Convert.ToInt32(dr["SC_Order"]);
            if (dr["SC_Group"] != DBNull.Value) sys_DesktopConfig.SC_Group = Convert.ToString(dr["SC_Group"]);
            if (dr["SC_Filter"] != DBNull.Value) sys_DesktopConfig.SC_Filter = Convert.ToString(dr["SC_Filter"]);
            if (dr["SC_Color"] != DBNull.Value) sys_DesktopConfig.SC_Color = Convert.ToString(dr["SC_Color"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_DesktopConfig;
      }
      /// <summary>
      /// 获取指定的桌面配置 Sys_DesktopConfig对象集合
      /// </summary>
      public List<Sys_DesktopConfig> GetListByWhere(string strCondition)
      {
         List<Sys_DesktopConfig> ret = new List<Sys_DesktopConfig>();
         string sql = "SELECT  SC_ID,SC_AreaCode,SC_AreaName,SC_AreaPCode,SC_AreaPName,SC_SQL,SC_Loop,SC_URL,Stat,SC_Order,SC_Group,SC_Filter,SC_Color FROM Sys_DesktopConfig WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_DesktopConfig sys_DesktopConfig = new Sys_DesktopConfig();
            if (dr["SC_ID"] != DBNull.Value) sys_DesktopConfig.SC_ID = Convert.ToDecimal(dr["SC_ID"]);
            if (dr["SC_AreaCode"] != DBNull.Value) sys_DesktopConfig.SC_AreaCode = Convert.ToString(dr["SC_AreaCode"]);
            if (dr["SC_AreaName"] != DBNull.Value) sys_DesktopConfig.SC_AreaName = Convert.ToString(dr["SC_AreaName"]);
            if (dr["SC_AreaPCode"] != DBNull.Value) sys_DesktopConfig.SC_AreaPCode = Convert.ToString(dr["SC_AreaPCode"]);
            if (dr["SC_AreaPName"] != DBNull.Value) sys_DesktopConfig.SC_AreaPName = Convert.ToString(dr["SC_AreaPName"]);
            if (dr["SC_SQL"] != DBNull.Value) sys_DesktopConfig.SC_SQL = Convert.ToString(dr["SC_SQL"]);
            if (dr["SC_Loop"] != DBNull.Value) sys_DesktopConfig.SC_Loop = Convert.ToString(dr["SC_Loop"]);
            if (dr["SC_URL"] != DBNull.Value) sys_DesktopConfig.SC_URL = Convert.ToString(dr["SC_URL"]);
            if (dr["Stat"] != DBNull.Value) sys_DesktopConfig.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SC_Order"] != DBNull.Value) sys_DesktopConfig.SC_Order = Convert.ToInt32(dr["SC_Order"]);
            if (dr["SC_Group"] != DBNull.Value) sys_DesktopConfig.SC_Group = Convert.ToString(dr["SC_Group"]);
            if (dr["SC_Filter"] != DBNull.Value) sys_DesktopConfig.SC_Filter = Convert.ToString(dr["SC_Filter"]);
            if (dr["SC_Color"] != DBNull.Value) sys_DesktopConfig.SC_Color = Convert.ToString(dr["SC_Color"]);
            ret.Add(sys_DesktopConfig);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的桌面配置 Sys_DesktopConfig对象(即:一条记录
      /// </summary>
      public List<Sys_DesktopConfig> GetAll()
      {
         List<Sys_DesktopConfig> ret = new List<Sys_DesktopConfig>();
         string sql = "SELECT  SC_ID,SC_AreaCode,SC_AreaName,SC_AreaPCode,SC_AreaPName,SC_SQL,SC_Loop,SC_URL,Stat,SC_Order,SC_Group,SC_Filter,SC_Color FROM Sys_DesktopConfig where 1=1 AND ((Stat is null) or (Stat=0) ) order by SC_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_DesktopConfig sys_DesktopConfig = new Sys_DesktopConfig();
            if (dr["SC_ID"] != DBNull.Value) sys_DesktopConfig.SC_ID = Convert.ToDecimal(dr["SC_ID"]);
            if (dr["SC_AreaCode"] != DBNull.Value) sys_DesktopConfig.SC_AreaCode = Convert.ToString(dr["SC_AreaCode"]);
            if (dr["SC_AreaName"] != DBNull.Value) sys_DesktopConfig.SC_AreaName = Convert.ToString(dr["SC_AreaName"]);
            if (dr["SC_AreaPCode"] != DBNull.Value) sys_DesktopConfig.SC_AreaPCode = Convert.ToString(dr["SC_AreaPCode"]);
            if (dr["SC_AreaPName"] != DBNull.Value) sys_DesktopConfig.SC_AreaPName = Convert.ToString(dr["SC_AreaPName"]);
            if (dr["SC_SQL"] != DBNull.Value) sys_DesktopConfig.SC_SQL = Convert.ToString(dr["SC_SQL"]);
            if (dr["SC_Loop"] != DBNull.Value) sys_DesktopConfig.SC_Loop = Convert.ToString(dr["SC_Loop"]);
            if (dr["SC_URL"] != DBNull.Value) sys_DesktopConfig.SC_URL = Convert.ToString(dr["SC_URL"]);
            if (dr["Stat"] != DBNull.Value) sys_DesktopConfig.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SC_Order"] != DBNull.Value) sys_DesktopConfig.SC_Order = Convert.ToInt32(dr["SC_Order"]);
            if (dr["SC_Group"] != DBNull.Value) sys_DesktopConfig.SC_Group = Convert.ToString(dr["SC_Group"]);
            if (dr["SC_Filter"] != DBNull.Value) sys_DesktopConfig.SC_Filter = Convert.ToString(dr["SC_Filter"]);
            if (dr["SC_Color"] != DBNull.Value) sys_DesktopConfig.SC_Color = Convert.ToString(dr["SC_Color"]);
            ret.Add(sys_DesktopConfig);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
