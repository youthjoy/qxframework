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
   public partial class ADOSys_PU_Config
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_PU_Config对象(即:一条记录)
      /// </summary>
      public int Add(Sys_PU_Config sys_PU_Config)
      {
         string sql = "INSERT INTO Sys_PU_Config (DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat) VALUES (@DCP_ModuleName,@DCP_ControlID,@DCP_Label,@DCP_ControlType,@DCP_Type,@DCP_Style,@DCP_Order,@DCP_IsHidden,@DCP_IsReadonly,@DCP_UDef1,@DCP_UDef2,@DCP_PageName,@DCP_CreateTime,@DCP_Model,@Stat)";
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ModuleName))
         {
            idb.AddParameter("@DCP_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ModuleName", sys_PU_Config.DCP_ModuleName);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ControlID))
         {
            idb.AddParameter("@DCP_ControlID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlID", sys_PU_Config.DCP_ControlID);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Label))
         {
            idb.AddParameter("@DCP_Label", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Label", sys_PU_Config.DCP_Label);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ControlType))
         {
            idb.AddParameter("@DCP_ControlType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlType", sys_PU_Config.DCP_ControlType);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Type))
         {
            idb.AddParameter("@DCP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Type", sys_PU_Config.DCP_Type);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Style))
         {
            idb.AddParameter("@DCP_Style", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Style", sys_PU_Config.DCP_Style);
         }
         if (sys_PU_Config.DCP_Order == 0)
         {
            idb.AddParameter("@DCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@DCP_Order", sys_PU_Config.DCP_Order);
         }
         if (sys_PU_Config.DCP_IsHidden == 0)
         {
            idb.AddParameter("@DCP_IsHidden", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsHidden", sys_PU_Config.DCP_IsHidden);
         }
         if (sys_PU_Config.DCP_IsReadonly == 0)
         {
            idb.AddParameter("@DCP_IsReadonly", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsReadonly", sys_PU_Config.DCP_IsReadonly);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_UDef1))
         {
            idb.AddParameter("@DCP_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef1", sys_PU_Config.DCP_UDef1);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_UDef2))
         {
            idb.AddParameter("@DCP_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef2", sys_PU_Config.DCP_UDef2);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_PageName))
         {
            idb.AddParameter("@DCP_PageName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_PageName", sys_PU_Config.DCP_PageName);
         }
         if (sys_PU_Config.DCP_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@DCP_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_CreateTime", sys_PU_Config.DCP_CreateTime);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Model))
         {
            idb.AddParameter("@DCP_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Model", sys_PU_Config.DCP_Model);
         }
         if (sys_PU_Config.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_PU_Config.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_PU_Config对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_PU_Config sys_PU_Config)
      {
         string sql = "INSERT INTO Sys_PU_Config (DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat) VALUES (@DCP_ModuleName,@DCP_ControlID,@DCP_Label,@DCP_ControlType,@DCP_Type,@DCP_Style,@DCP_Order,@DCP_IsHidden,@DCP_IsReadonly,@DCP_UDef1,@DCP_UDef2,@DCP_PageName,@DCP_CreateTime,@DCP_Model,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ModuleName))
         {
            idb.AddParameter("@DCP_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ModuleName", sys_PU_Config.DCP_ModuleName);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ControlID))
         {
            idb.AddParameter("@DCP_ControlID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlID", sys_PU_Config.DCP_ControlID);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Label))
         {
            idb.AddParameter("@DCP_Label", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Label", sys_PU_Config.DCP_Label);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ControlType))
         {
            idb.AddParameter("@DCP_ControlType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlType", sys_PU_Config.DCP_ControlType);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Type))
         {
            idb.AddParameter("@DCP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Type", sys_PU_Config.DCP_Type);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Style))
         {
            idb.AddParameter("@DCP_Style", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Style", sys_PU_Config.DCP_Style);
         }
         if (sys_PU_Config.DCP_Order == 0)
         {
            idb.AddParameter("@DCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@DCP_Order", sys_PU_Config.DCP_Order);
         }
         if (sys_PU_Config.DCP_IsHidden == 0)
         {
            idb.AddParameter("@DCP_IsHidden", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsHidden", sys_PU_Config.DCP_IsHidden);
         }
         if (sys_PU_Config.DCP_IsReadonly == 0)
         {
            idb.AddParameter("@DCP_IsReadonly", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsReadonly", sys_PU_Config.DCP_IsReadonly);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_UDef1))
         {
            idb.AddParameter("@DCP_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef1", sys_PU_Config.DCP_UDef1);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_UDef2))
         {
            idb.AddParameter("@DCP_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef2", sys_PU_Config.DCP_UDef2);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_PageName))
         {
            idb.AddParameter("@DCP_PageName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_PageName", sys_PU_Config.DCP_PageName);
         }
         if (sys_PU_Config.DCP_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@DCP_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_CreateTime", sys_PU_Config.DCP_CreateTime);
         }
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Model))
         {
            idb.AddParameter("@DCP_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Model", sys_PU_Config.DCP_Model);
         }
         if (sys_PU_Config.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_PU_Config.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 更新Sys_PU_Config对象(即:一条记录
      /// </summary>
      public int Update(Sys_PU_Config sys_PU_Config)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_PU_Config       SET ");
            if(sys_PU_Config.DCP_ModuleName_IsChanged){sbParameter.Append("DCP_ModuleName=@DCP_ModuleName, ");}
      if(sys_PU_Config.DCP_ControlID_IsChanged){sbParameter.Append("DCP_ControlID=@DCP_ControlID, ");}
      if(sys_PU_Config.DCP_Label_IsChanged){sbParameter.Append("DCP_Label=@DCP_Label, ");}
      if(sys_PU_Config.DCP_ControlType_IsChanged){sbParameter.Append("DCP_ControlType=@DCP_ControlType, ");}
      if(sys_PU_Config.DCP_Type_IsChanged){sbParameter.Append("DCP_Type=@DCP_Type, ");}
      if(sys_PU_Config.DCP_Style_IsChanged){sbParameter.Append("DCP_Style=@DCP_Style, ");}
      if(sys_PU_Config.DCP_Order_IsChanged){sbParameter.Append("DCP_Order=@DCP_Order, ");}
      if(sys_PU_Config.DCP_IsHidden_IsChanged){sbParameter.Append("DCP_IsHidden=@DCP_IsHidden, ");}
      if(sys_PU_Config.DCP_IsReadonly_IsChanged){sbParameter.Append("DCP_IsReadonly=@DCP_IsReadonly, ");}
      if(sys_PU_Config.DCP_UDef1_IsChanged){sbParameter.Append("DCP_UDef1=@DCP_UDef1, ");}
      if(sys_PU_Config.DCP_UDef2_IsChanged){sbParameter.Append("DCP_UDef2=@DCP_UDef2, ");}
      if(sys_PU_Config.DCP_PageName_IsChanged){sbParameter.Append("DCP_PageName=@DCP_PageName, ");}
      if(sys_PU_Config.DCP_CreateTime_IsChanged){sbParameter.Append("DCP_CreateTime=@DCP_CreateTime, ");}
      if(sys_PU_Config.DCP_Model_IsChanged){sbParameter.Append("DCP_Model=@DCP_Model, ");}
      if(sys_PU_Config.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DCP_ID=@DCP_ID; " );
      string sql=sb.ToString();
         if(sys_PU_Config.DCP_ModuleName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ModuleName))
         {
            idb.AddParameter("@DCP_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ModuleName", sys_PU_Config.DCP_ModuleName);
         }
          }
         if(sys_PU_Config.DCP_ControlID_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ControlID))
         {
            idb.AddParameter("@DCP_ControlID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlID", sys_PU_Config.DCP_ControlID);
         }
          }
         if(sys_PU_Config.DCP_Label_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Label))
         {
            idb.AddParameter("@DCP_Label", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Label", sys_PU_Config.DCP_Label);
         }
          }
         if(sys_PU_Config.DCP_ControlType_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_ControlType))
         {
            idb.AddParameter("@DCP_ControlType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlType", sys_PU_Config.DCP_ControlType);
         }
          }
         if(sys_PU_Config.DCP_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Type))
         {
            idb.AddParameter("@DCP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Type", sys_PU_Config.DCP_Type);
         }
          }
         if(sys_PU_Config.DCP_Style_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Style))
         {
            idb.AddParameter("@DCP_Style", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Style", sys_PU_Config.DCP_Style);
         }
          }
         if(sys_PU_Config.DCP_Order_IsChanged)
         {
         if (sys_PU_Config.DCP_Order == 0)
         {
            idb.AddParameter("@DCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@DCP_Order", sys_PU_Config.DCP_Order);
         }
          }
         if(sys_PU_Config.DCP_IsHidden_IsChanged)
         {
         if (sys_PU_Config.DCP_IsHidden == 0)
         {
            idb.AddParameter("@DCP_IsHidden", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsHidden", sys_PU_Config.DCP_IsHidden);
         }
          }
         if(sys_PU_Config.DCP_IsReadonly_IsChanged)
         {
         if (sys_PU_Config.DCP_IsReadonly == 0)
         {
            idb.AddParameter("@DCP_IsReadonly", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsReadonly", sys_PU_Config.DCP_IsReadonly);
         }
          }
         if(sys_PU_Config.DCP_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_UDef1))
         {
            idb.AddParameter("@DCP_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef1", sys_PU_Config.DCP_UDef1);
         }
          }
         if(sys_PU_Config.DCP_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_UDef2))
         {
            idb.AddParameter("@DCP_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef2", sys_PU_Config.DCP_UDef2);
         }
          }
         if(sys_PU_Config.DCP_PageName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_PageName))
         {
            idb.AddParameter("@DCP_PageName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_PageName", sys_PU_Config.DCP_PageName);
         }
          }
         if(sys_PU_Config.DCP_CreateTime_IsChanged)
         {
         if (sys_PU_Config.DCP_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@DCP_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_CreateTime", sys_PU_Config.DCP_CreateTime);
         }
          }
         if(sys_PU_Config.DCP_Model_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_PU_Config.DCP_Model))
         {
            idb.AddParameter("@DCP_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Model", sys_PU_Config.DCP_Model);
         }
          }
         if(sys_PU_Config.Stat_IsChanged)
         {
         if (sys_PU_Config.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_PU_Config.Stat);
         }
          }

         idb.AddParameter("@DCP_ID", sys_PU_Config.DCP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_PU_Config对象(即:一条记录
      /// </summary>
      public int Delete(decimal dCP_ID)
      {
         string sql = "DELETE Sys_PU_Config WHERE 1=1  AND DCP_ID=@DCP_ID ";
         idb.AddParameter("@DCP_ID", dCP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_PU_Config对象(即:一条记录
      /// </summary>
      public Sys_PU_Config GetByKey(decimal dCP_ID)
      {
         Sys_PU_Config sys_PU_Config = new Sys_PU_Config();
         string sql = "SELECT  DCP_ID,DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat FROM Sys_PU_Config WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DCP_ID=@DCP_ID ";
         idb.AddParameter("@DCP_ID", dCP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DCP_ID"] != DBNull.Value) sys_PU_Config.DCP_ID = Convert.ToDecimal(dr["DCP_ID"]);
            if (dr["DCP_ModuleName"] != DBNull.Value) sys_PU_Config.DCP_ModuleName = Convert.ToString(dr["DCP_ModuleName"]);
            if (dr["DCP_ControlID"] != DBNull.Value) sys_PU_Config.DCP_ControlID = Convert.ToString(dr["DCP_ControlID"]);
            if (dr["DCP_Label"] != DBNull.Value) sys_PU_Config.DCP_Label = Convert.ToString(dr["DCP_Label"]);
            if (dr["DCP_ControlType"] != DBNull.Value) sys_PU_Config.DCP_ControlType = Convert.ToString(dr["DCP_ControlType"]);
            if (dr["DCP_Type"] != DBNull.Value) sys_PU_Config.DCP_Type = Convert.ToString(dr["DCP_Type"]);
            if (dr["DCP_Style"] != DBNull.Value) sys_PU_Config.DCP_Style = Convert.ToString(dr["DCP_Style"]);
            if (dr["DCP_Order"] != DBNull.Value) sys_PU_Config.DCP_Order = Convert.ToInt32(dr["DCP_Order"]);
            if (dr["DCP_IsHidden"] != DBNull.Value) sys_PU_Config.DCP_IsHidden = Convert.ToInt32(dr["DCP_IsHidden"]);
            if (dr["DCP_IsReadonly"] != DBNull.Value) sys_PU_Config.DCP_IsReadonly = Convert.ToInt32(dr["DCP_IsReadonly"]);
            if (dr["DCP_UDef1"] != DBNull.Value) sys_PU_Config.DCP_UDef1 = Convert.ToString(dr["DCP_UDef1"]);
            if (dr["DCP_UDef2"] != DBNull.Value) sys_PU_Config.DCP_UDef2 = Convert.ToString(dr["DCP_UDef2"]);
            if (dr["DCP_PageName"] != DBNull.Value) sys_PU_Config.DCP_PageName = Convert.ToString(dr["DCP_PageName"]);
            if (dr["DCP_CreateTime"] != DBNull.Value) sys_PU_Config.DCP_CreateTime = Convert.ToDateTime(dr["DCP_CreateTime"]);
            if (dr["DCP_Model"] != DBNull.Value) sys_PU_Config.DCP_Model = Convert.ToString(dr["DCP_Model"]);
            if (dr["Stat"] != DBNull.Value) sys_PU_Config.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return sys_PU_Config;
      }
      /// <summary>
      /// 获取指定的Sys_PU_Config对象集合
      /// </summary>
      public List<Sys_PU_Config> GetListByWhere(string strCondition)
      {
         List<Sys_PU_Config> ret = new List<Sys_PU_Config>();
         string sql = "SELECT  DCP_ID,DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat FROM Sys_PU_Config WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_PU_Config sys_PU_Config = new Sys_PU_Config();
            if (dr["DCP_ID"] != DBNull.Value) sys_PU_Config.DCP_ID = Convert.ToDecimal(dr["DCP_ID"]);
            if (dr["DCP_ModuleName"] != DBNull.Value) sys_PU_Config.DCP_ModuleName = Convert.ToString(dr["DCP_ModuleName"]);
            if (dr["DCP_ControlID"] != DBNull.Value) sys_PU_Config.DCP_ControlID = Convert.ToString(dr["DCP_ControlID"]);
            if (dr["DCP_Label"] != DBNull.Value) sys_PU_Config.DCP_Label = Convert.ToString(dr["DCP_Label"]);
            if (dr["DCP_ControlType"] != DBNull.Value) sys_PU_Config.DCP_ControlType = Convert.ToString(dr["DCP_ControlType"]);
            if (dr["DCP_Type"] != DBNull.Value) sys_PU_Config.DCP_Type = Convert.ToString(dr["DCP_Type"]);
            if (dr["DCP_Style"] != DBNull.Value) sys_PU_Config.DCP_Style = Convert.ToString(dr["DCP_Style"]);
            if (dr["DCP_Order"] != DBNull.Value) sys_PU_Config.DCP_Order = Convert.ToInt32(dr["DCP_Order"]);
            if (dr["DCP_IsHidden"] != DBNull.Value) sys_PU_Config.DCP_IsHidden = Convert.ToInt32(dr["DCP_IsHidden"]);
            if (dr["DCP_IsReadonly"] != DBNull.Value) sys_PU_Config.DCP_IsReadonly = Convert.ToInt32(dr["DCP_IsReadonly"]);
            if (dr["DCP_UDef1"] != DBNull.Value) sys_PU_Config.DCP_UDef1 = Convert.ToString(dr["DCP_UDef1"]);
            if (dr["DCP_UDef2"] != DBNull.Value) sys_PU_Config.DCP_UDef2 = Convert.ToString(dr["DCP_UDef2"]);
            if (dr["DCP_PageName"] != DBNull.Value) sys_PU_Config.DCP_PageName = Convert.ToString(dr["DCP_PageName"]);
            if (dr["DCP_CreateTime"] != DBNull.Value) sys_PU_Config.DCP_CreateTime = Convert.ToDateTime(dr["DCP_CreateTime"]);
            if (dr["DCP_Model"] != DBNull.Value) sys_PU_Config.DCP_Model = Convert.ToString(dr["DCP_Model"]);
            if (dr["Stat"] != DBNull.Value) sys_PU_Config.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_PU_Config);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_PU_Config对象(即:一条记录
      /// </summary>
      public List<Sys_PU_Config> GetAll()
      {
         List<Sys_PU_Config> ret = new List<Sys_PU_Config>();
         string sql = "SELECT  DCP_ID,DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat FROM Sys_PU_Config where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_PU_Config sys_PU_Config = new Sys_PU_Config();
            if (dr["DCP_ID"] != DBNull.Value) sys_PU_Config.DCP_ID = Convert.ToDecimal(dr["DCP_ID"]);
            if (dr["DCP_ModuleName"] != DBNull.Value) sys_PU_Config.DCP_ModuleName = Convert.ToString(dr["DCP_ModuleName"]);
            if (dr["DCP_ControlID"] != DBNull.Value) sys_PU_Config.DCP_ControlID = Convert.ToString(dr["DCP_ControlID"]);
            if (dr["DCP_Label"] != DBNull.Value) sys_PU_Config.DCP_Label = Convert.ToString(dr["DCP_Label"]);
            if (dr["DCP_ControlType"] != DBNull.Value) sys_PU_Config.DCP_ControlType = Convert.ToString(dr["DCP_ControlType"]);
            if (dr["DCP_Type"] != DBNull.Value) sys_PU_Config.DCP_Type = Convert.ToString(dr["DCP_Type"]);
            if (dr["DCP_Style"] != DBNull.Value) sys_PU_Config.DCP_Style = Convert.ToString(dr["DCP_Style"]);
            if (dr["DCP_Order"] != DBNull.Value) sys_PU_Config.DCP_Order = Convert.ToInt32(dr["DCP_Order"]);
            if (dr["DCP_IsHidden"] != DBNull.Value) sys_PU_Config.DCP_IsHidden = Convert.ToInt32(dr["DCP_IsHidden"]);
            if (dr["DCP_IsReadonly"] != DBNull.Value) sys_PU_Config.DCP_IsReadonly = Convert.ToInt32(dr["DCP_IsReadonly"]);
            if (dr["DCP_UDef1"] != DBNull.Value) sys_PU_Config.DCP_UDef1 = Convert.ToString(dr["DCP_UDef1"]);
            if (dr["DCP_UDef2"] != DBNull.Value) sys_PU_Config.DCP_UDef2 = Convert.ToString(dr["DCP_UDef2"]);
            if (dr["DCP_PageName"] != DBNull.Value) sys_PU_Config.DCP_PageName = Convert.ToString(dr["DCP_PageName"]);
            if (dr["DCP_CreateTime"] != DBNull.Value) sys_PU_Config.DCP_CreateTime = Convert.ToDateTime(dr["DCP_CreateTime"]);
            if (dr["DCP_Model"] != DBNull.Value) sys_PU_Config.DCP_Model = Convert.ToString(dr["DCP_Model"]);
            if (dr["Stat"] != DBNull.Value) sys_PU_Config.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_PU_Config);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
