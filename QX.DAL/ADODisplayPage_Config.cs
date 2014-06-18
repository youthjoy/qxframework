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
   public partial class ADODisplayPage_Config
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加DisplayPage_Config对象(即:一条记录)
      /// </summary>
      public int Add(DisplayPage_Config displayPage_Config)
      {
         string sql = "INSERT INTO DisplayPage_Config (DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat) VALUES (@DCP_ModuleName,@DCP_ControlID,@DCP_Label,@DCP_ControlType,@DCP_Type,@DCP_Style,@DCP_Order,@DCP_IsHidden,@DCP_IsReadonly,@DCP_UDef1,@DCP_UDef2,@DCP_PageName,@DCP_CreateTime,@DCP_Model,@Stat)";
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ModuleName))
         {
            idb.AddParameter("@DCP_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ModuleName", displayPage_Config.DCP_ModuleName);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ControlID))
         {
            idb.AddParameter("@DCP_ControlID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlID", displayPage_Config.DCP_ControlID);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Label))
         {
            idb.AddParameter("@DCP_Label", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Label", displayPage_Config.DCP_Label);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ControlType))
         {
            idb.AddParameter("@DCP_ControlType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlType", displayPage_Config.DCP_ControlType);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Type))
         {
            idb.AddParameter("@DCP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Type", displayPage_Config.DCP_Type);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Style))
         {
            idb.AddParameter("@DCP_Style", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Style", displayPage_Config.DCP_Style);
         }
         if (displayPage_Config.DCP_Order == 0)
         {
            idb.AddParameter("@DCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@DCP_Order", displayPage_Config.DCP_Order);
         }
         if (displayPage_Config.DCP_IsHidden == 0)
         {
            idb.AddParameter("@DCP_IsHidden", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsHidden", displayPage_Config.DCP_IsHidden);
         }
         if (displayPage_Config.DCP_IsReadonly == 0)
         {
            idb.AddParameter("@DCP_IsReadonly", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsReadonly", displayPage_Config.DCP_IsReadonly);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_UDef1))
         {
            idb.AddParameter("@DCP_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef1", displayPage_Config.DCP_UDef1);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_UDef2))
         {
            idb.AddParameter("@DCP_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef2", displayPage_Config.DCP_UDef2);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_PageName))
         {
            idb.AddParameter("@DCP_PageName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_PageName", displayPage_Config.DCP_PageName);
         }
         if (displayPage_Config.DCP_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@DCP_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_CreateTime", displayPage_Config.DCP_CreateTime);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Model))
         {
            idb.AddParameter("@DCP_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Model", displayPage_Config.DCP_Model);
         }
         if (displayPage_Config.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", displayPage_Config.Stat);
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
      /// 添加DisplayPage_Config对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(DisplayPage_Config displayPage_Config)
      {
         string sql = "INSERT INTO DisplayPage_Config (DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat) VALUES (@DCP_ModuleName,@DCP_ControlID,@DCP_Label,@DCP_ControlType,@DCP_Type,@DCP_Style,@DCP_Order,@DCP_IsHidden,@DCP_IsReadonly,@DCP_UDef1,@DCP_UDef2,@DCP_PageName,@DCP_CreateTime,@DCP_Model,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ModuleName))
         {
            idb.AddParameter("@DCP_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ModuleName", displayPage_Config.DCP_ModuleName);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ControlID))
         {
            idb.AddParameter("@DCP_ControlID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlID", displayPage_Config.DCP_ControlID);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Label))
         {
            idb.AddParameter("@DCP_Label", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Label", displayPage_Config.DCP_Label);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ControlType))
         {
            idb.AddParameter("@DCP_ControlType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlType", displayPage_Config.DCP_ControlType);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Type))
         {
            idb.AddParameter("@DCP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Type", displayPage_Config.DCP_Type);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Style))
         {
            idb.AddParameter("@DCP_Style", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Style", displayPage_Config.DCP_Style);
         }
         if (displayPage_Config.DCP_Order == 0)
         {
            idb.AddParameter("@DCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@DCP_Order", displayPage_Config.DCP_Order);
         }
         if (displayPage_Config.DCP_IsHidden == 0)
         {
            idb.AddParameter("@DCP_IsHidden", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsHidden", displayPage_Config.DCP_IsHidden);
         }
         if (displayPage_Config.DCP_IsReadonly == 0)
         {
            idb.AddParameter("@DCP_IsReadonly", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsReadonly", displayPage_Config.DCP_IsReadonly);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_UDef1))
         {
            idb.AddParameter("@DCP_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef1", displayPage_Config.DCP_UDef1);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_UDef2))
         {
            idb.AddParameter("@DCP_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef2", displayPage_Config.DCP_UDef2);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_PageName))
         {
            idb.AddParameter("@DCP_PageName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_PageName", displayPage_Config.DCP_PageName);
         }
         if (displayPage_Config.DCP_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@DCP_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_CreateTime", displayPage_Config.DCP_CreateTime);
         }
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Model))
         {
            idb.AddParameter("@DCP_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Model", displayPage_Config.DCP_Model);
         }
         if (displayPage_Config.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", displayPage_Config.Stat);
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
      /// 更新DisplayPage_Config对象(即:一条记录
      /// </summary>
      public int Update(DisplayPage_Config displayPage_Config)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       DisplayPage_Config       SET ");
            if(displayPage_Config.DCP_ModuleName_IsChanged){sbParameter.Append("DCP_ModuleName=@DCP_ModuleName, ");}
      if(displayPage_Config.DCP_ControlID_IsChanged){sbParameter.Append("DCP_ControlID=@DCP_ControlID, ");}
      if(displayPage_Config.DCP_Label_IsChanged){sbParameter.Append("DCP_Label=@DCP_Label, ");}
      if(displayPage_Config.DCP_ControlType_IsChanged){sbParameter.Append("DCP_ControlType=@DCP_ControlType, ");}
      if(displayPage_Config.DCP_Type_IsChanged){sbParameter.Append("DCP_Type=@DCP_Type, ");}
      if(displayPage_Config.DCP_Style_IsChanged){sbParameter.Append("DCP_Style=@DCP_Style, ");}
      if(displayPage_Config.DCP_Order_IsChanged){sbParameter.Append("DCP_Order=@DCP_Order, ");}
      if(displayPage_Config.DCP_IsHidden_IsChanged){sbParameter.Append("DCP_IsHidden=@DCP_IsHidden, ");}
      if(displayPage_Config.DCP_IsReadonly_IsChanged){sbParameter.Append("DCP_IsReadonly=@DCP_IsReadonly, ");}
      if(displayPage_Config.DCP_UDef1_IsChanged){sbParameter.Append("DCP_UDef1=@DCP_UDef1, ");}
      if(displayPage_Config.DCP_UDef2_IsChanged){sbParameter.Append("DCP_UDef2=@DCP_UDef2, ");}
      if(displayPage_Config.DCP_PageName_IsChanged){sbParameter.Append("DCP_PageName=@DCP_PageName, ");}
      if(displayPage_Config.DCP_CreateTime_IsChanged){sbParameter.Append("DCP_CreateTime=@DCP_CreateTime, ");}
      if(displayPage_Config.DCP_Model_IsChanged){sbParameter.Append("DCP_Model=@DCP_Model, ");}
      if(displayPage_Config.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DCP_ID=@DCP_ID; " );
      string sql=sb.ToString();
         if(displayPage_Config.DCP_ModuleName_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ModuleName))
         {
            idb.AddParameter("@DCP_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ModuleName", displayPage_Config.DCP_ModuleName);
         }
          }
         if(displayPage_Config.DCP_ControlID_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ControlID))
         {
            idb.AddParameter("@DCP_ControlID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlID", displayPage_Config.DCP_ControlID);
         }
          }
         if(displayPage_Config.DCP_Label_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Label))
         {
            idb.AddParameter("@DCP_Label", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Label", displayPage_Config.DCP_Label);
         }
          }
         if(displayPage_Config.DCP_ControlType_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_ControlType))
         {
            idb.AddParameter("@DCP_ControlType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_ControlType", displayPage_Config.DCP_ControlType);
         }
          }
         if(displayPage_Config.DCP_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Type))
         {
            idb.AddParameter("@DCP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Type", displayPage_Config.DCP_Type);
         }
          }
         if(displayPage_Config.DCP_Style_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Style))
         {
            idb.AddParameter("@DCP_Style", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Style", displayPage_Config.DCP_Style);
         }
          }
         if(displayPage_Config.DCP_Order_IsChanged)
         {
         if (displayPage_Config.DCP_Order == 0)
         {
            idb.AddParameter("@DCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@DCP_Order", displayPage_Config.DCP_Order);
         }
          }
         if(displayPage_Config.DCP_IsHidden_IsChanged)
         {
         if (displayPage_Config.DCP_IsHidden == 0)
         {
            idb.AddParameter("@DCP_IsHidden", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsHidden", displayPage_Config.DCP_IsHidden);
         }
          }
         if(displayPage_Config.DCP_IsReadonly_IsChanged)
         {
         if (displayPage_Config.DCP_IsReadonly == 0)
         {
            idb.AddParameter("@DCP_IsReadonly", 0);
         }
         else
         {
            idb.AddParameter("@DCP_IsReadonly", displayPage_Config.DCP_IsReadonly);
         }
          }
         if(displayPage_Config.DCP_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_UDef1))
         {
            idb.AddParameter("@DCP_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef1", displayPage_Config.DCP_UDef1);
         }
          }
         if(displayPage_Config.DCP_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_UDef2))
         {
            idb.AddParameter("@DCP_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_UDef2", displayPage_Config.DCP_UDef2);
         }
          }
         if(displayPage_Config.DCP_PageName_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_PageName))
         {
            idb.AddParameter("@DCP_PageName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_PageName", displayPage_Config.DCP_PageName);
         }
          }
         if(displayPage_Config.DCP_CreateTime_IsChanged)
         {
         if (displayPage_Config.DCP_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@DCP_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_CreateTime", displayPage_Config.DCP_CreateTime);
         }
          }
         if(displayPage_Config.DCP_Model_IsChanged)
         {
         if (string.IsNullOrEmpty(displayPage_Config.DCP_Model))
         {
            idb.AddParameter("@DCP_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DCP_Model", displayPage_Config.DCP_Model);
         }
          }
         if(displayPage_Config.Stat_IsChanged)
         {
         if (displayPage_Config.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", displayPage_Config.Stat);
         }
          }

         idb.AddParameter("@DCP_ID", displayPage_Config.DCP_ID);

           
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
      /// 删除DisplayPage_Config对象(即:一条记录
      /// </summary>
      public int Delete(decimal dCP_ID)
      {
         string sql = "DELETE DisplayPage_Config WHERE 1=1  AND DCP_ID=@DCP_ID ";
         idb.AddParameter("@DCP_ID", dCP_ID);

           
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
      /// 获取指定的DisplayPage_Config对象(即:一条记录
      /// </summary>
      public DisplayPage_Config GetByKey(decimal dCP_ID)
      {
         DisplayPage_Config displayPage_Config = new DisplayPage_Config();
         string sql = "SELECT  DCP_ID,DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat FROM DisplayPage_Config WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DCP_ID=@DCP_ID ";
         idb.AddParameter("@DCP_ID", dCP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DCP_ID"] != DBNull.Value) displayPage_Config.DCP_ID = Convert.ToDecimal(dr["DCP_ID"]);
            if (dr["DCP_ModuleName"] != DBNull.Value) displayPage_Config.DCP_ModuleName = Convert.ToString(dr["DCP_ModuleName"]);
            if (dr["DCP_ControlID"] != DBNull.Value) displayPage_Config.DCP_ControlID = Convert.ToString(dr["DCP_ControlID"]);
            if (dr["DCP_Label"] != DBNull.Value) displayPage_Config.DCP_Label = Convert.ToString(dr["DCP_Label"]);
            if (dr["DCP_ControlType"] != DBNull.Value) displayPage_Config.DCP_ControlType = Convert.ToString(dr["DCP_ControlType"]);
            if (dr["DCP_Type"] != DBNull.Value) displayPage_Config.DCP_Type = Convert.ToString(dr["DCP_Type"]);
            if (dr["DCP_Style"] != DBNull.Value) displayPage_Config.DCP_Style = Convert.ToString(dr["DCP_Style"]);
            if (dr["DCP_Order"] != DBNull.Value) displayPage_Config.DCP_Order = Convert.ToInt32(dr["DCP_Order"]);
            if (dr["DCP_IsHidden"] != DBNull.Value) displayPage_Config.DCP_IsHidden = Convert.ToInt32(dr["DCP_IsHidden"]);
            if (dr["DCP_IsReadonly"] != DBNull.Value) displayPage_Config.DCP_IsReadonly = Convert.ToInt32(dr["DCP_IsReadonly"]);
            if (dr["DCP_UDef1"] != DBNull.Value) displayPage_Config.DCP_UDef1 = Convert.ToString(dr["DCP_UDef1"]);
            if (dr["DCP_UDef2"] != DBNull.Value) displayPage_Config.DCP_UDef2 = Convert.ToString(dr["DCP_UDef2"]);
            if (dr["DCP_PageName"] != DBNull.Value) displayPage_Config.DCP_PageName = Convert.ToString(dr["DCP_PageName"]);
            if (dr["DCP_CreateTime"] != DBNull.Value) displayPage_Config.DCP_CreateTime = Convert.ToDateTime(dr["DCP_CreateTime"]);
            if (dr["DCP_Model"] != DBNull.Value) displayPage_Config.DCP_Model = Convert.ToString(dr["DCP_Model"]);
            if (dr["Stat"] != DBNull.Value) displayPage_Config.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return displayPage_Config;
      }
      /// <summary>
      /// 获取指定的DisplayPage_Config对象集合
      /// </summary>
      public List<DisplayPage_Config> GetListByWhere(string strCondition)
      {
         List<DisplayPage_Config> ret = new List<DisplayPage_Config>();
         string sql = "SELECT  DCP_ID,DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat FROM DisplayPage_Config WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            DisplayPage_Config displayPage_Config = new DisplayPage_Config();
            if (dr["DCP_ID"] != DBNull.Value) displayPage_Config.DCP_ID = Convert.ToDecimal(dr["DCP_ID"]);
            if (dr["DCP_ModuleName"] != DBNull.Value) displayPage_Config.DCP_ModuleName = Convert.ToString(dr["DCP_ModuleName"]);
            if (dr["DCP_ControlID"] != DBNull.Value) displayPage_Config.DCP_ControlID = Convert.ToString(dr["DCP_ControlID"]);
            if (dr["DCP_Label"] != DBNull.Value) displayPage_Config.DCP_Label = Convert.ToString(dr["DCP_Label"]);
            if (dr["DCP_ControlType"] != DBNull.Value) displayPage_Config.DCP_ControlType = Convert.ToString(dr["DCP_ControlType"]);
            if (dr["DCP_Type"] != DBNull.Value) displayPage_Config.DCP_Type = Convert.ToString(dr["DCP_Type"]);
            if (dr["DCP_Style"] != DBNull.Value) displayPage_Config.DCP_Style = Convert.ToString(dr["DCP_Style"]);
            if (dr["DCP_Order"] != DBNull.Value) displayPage_Config.DCP_Order = Convert.ToInt32(dr["DCP_Order"]);
            if (dr["DCP_IsHidden"] != DBNull.Value) displayPage_Config.DCP_IsHidden = Convert.ToInt32(dr["DCP_IsHidden"]);
            if (dr["DCP_IsReadonly"] != DBNull.Value) displayPage_Config.DCP_IsReadonly = Convert.ToInt32(dr["DCP_IsReadonly"]);
            if (dr["DCP_UDef1"] != DBNull.Value) displayPage_Config.DCP_UDef1 = Convert.ToString(dr["DCP_UDef1"]);
            if (dr["DCP_UDef2"] != DBNull.Value) displayPage_Config.DCP_UDef2 = Convert.ToString(dr["DCP_UDef2"]);
            if (dr["DCP_PageName"] != DBNull.Value) displayPage_Config.DCP_PageName = Convert.ToString(dr["DCP_PageName"]);
            if (dr["DCP_CreateTime"] != DBNull.Value) displayPage_Config.DCP_CreateTime = Convert.ToDateTime(dr["DCP_CreateTime"]);
            if (dr["DCP_Model"] != DBNull.Value) displayPage_Config.DCP_Model = Convert.ToString(dr["DCP_Model"]);
            if (dr["Stat"] != DBNull.Value) displayPage_Config.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(displayPage_Config);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的DisplayPage_Config对象(即:一条记录
      /// </summary>
      public List<DisplayPage_Config> GetAll()
      {
         List<DisplayPage_Config> ret = new List<DisplayPage_Config>();
         string sql = "SELECT  DCP_ID,DCP_ModuleName,DCP_ControlID,DCP_Label,DCP_ControlType,DCP_Type,DCP_Style,DCP_Order,DCP_IsHidden,DCP_IsReadonly,DCP_UDef1,DCP_UDef2,DCP_PageName,DCP_CreateTime,DCP_Model,Stat FROM DisplayPage_Config where 1=1 AND ((Stat is null) or (Stat=0) ) order by DCP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            DisplayPage_Config displayPage_Config = new DisplayPage_Config();
            if (dr["DCP_ID"] != DBNull.Value) displayPage_Config.DCP_ID = Convert.ToDecimal(dr["DCP_ID"]);
            if (dr["DCP_ModuleName"] != DBNull.Value) displayPage_Config.DCP_ModuleName = Convert.ToString(dr["DCP_ModuleName"]);
            if (dr["DCP_ControlID"] != DBNull.Value) displayPage_Config.DCP_ControlID = Convert.ToString(dr["DCP_ControlID"]);
            if (dr["DCP_Label"] != DBNull.Value) displayPage_Config.DCP_Label = Convert.ToString(dr["DCP_Label"]);
            if (dr["DCP_ControlType"] != DBNull.Value) displayPage_Config.DCP_ControlType = Convert.ToString(dr["DCP_ControlType"]);
            if (dr["DCP_Type"] != DBNull.Value) displayPage_Config.DCP_Type = Convert.ToString(dr["DCP_Type"]);
            if (dr["DCP_Style"] != DBNull.Value) displayPage_Config.DCP_Style = Convert.ToString(dr["DCP_Style"]);
            if (dr["DCP_Order"] != DBNull.Value) displayPage_Config.DCP_Order = Convert.ToInt32(dr["DCP_Order"]);
            if (dr["DCP_IsHidden"] != DBNull.Value) displayPage_Config.DCP_IsHidden = Convert.ToInt32(dr["DCP_IsHidden"]);
            if (dr["DCP_IsReadonly"] != DBNull.Value) displayPage_Config.DCP_IsReadonly = Convert.ToInt32(dr["DCP_IsReadonly"]);
            if (dr["DCP_UDef1"] != DBNull.Value) displayPage_Config.DCP_UDef1 = Convert.ToString(dr["DCP_UDef1"]);
            if (dr["DCP_UDef2"] != DBNull.Value) displayPage_Config.DCP_UDef2 = Convert.ToString(dr["DCP_UDef2"]);
            if (dr["DCP_PageName"] != DBNull.Value) displayPage_Config.DCP_PageName = Convert.ToString(dr["DCP_PageName"]);
            if (dr["DCP_CreateTime"] != DBNull.Value) displayPage_Config.DCP_CreateTime = Convert.ToDateTime(dr["DCP_CreateTime"]);
            if (dr["DCP_Model"] != DBNull.Value) displayPage_Config.DCP_Model = Convert.ToString(dr["DCP_Model"]);
            if (dr["Stat"] != DBNull.Value) displayPage_Config.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(displayPage_Config);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
