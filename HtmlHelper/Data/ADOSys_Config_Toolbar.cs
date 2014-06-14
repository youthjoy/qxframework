using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.HtmlHelperLib.Model;
using QX.DataAcess;

namespace QX.HtmlHelperLib.DAL
{
   [Serializable]
   public partial class ADOSys_Config_Toolbar
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_Config_Toolbar对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Config_Toolbar sys_Config_Toolbar)
      {
         string sql = "INSERT INTO Sys_Config_Toolbar (CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,CT_Attr,CT_Class,CT_Event,CT_Udef1,CT_Udef2,Stat) VALUES (@CT_Module,@CT_Field,@CT_Name,@CT_Order,@CT_Type,@CT_DictKey,@CT_JS,@CT_Default,@CT_Show,@CT_Attr,@CT_Class,@CT_Event,@CT_Udef1,@CT_Udef2,@Stat)";
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Module))
         {
            idb.AddParameter("@CT_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Module", sys_Config_Toolbar.CT_Module);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Field))
         {
            idb.AddParameter("@CT_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Field", sys_Config_Toolbar.CT_Field);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Name))
         {
            idb.AddParameter("@CT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Name", sys_Config_Toolbar.CT_Name);
         }
         if (sys_Config_Toolbar.CT_Order == 0)
         {
            idb.AddParameter("@CT_Order", 0);
         }
         else
         {
            idb.AddParameter("@CT_Order", sys_Config_Toolbar.CT_Order);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Type))
         {
            idb.AddParameter("@CT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Type", sys_Config_Toolbar.CT_Type);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_DictKey))
         {
            idb.AddParameter("@CT_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_DictKey", sys_Config_Toolbar.CT_DictKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_JS))
         {
            idb.AddParameter("@CT_JS", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_JS", sys_Config_Toolbar.CT_JS);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Default))
         {
            idb.AddParameter("@CT_Default", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Default", sys_Config_Toolbar.CT_Default);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Show))
         {
            idb.AddParameter("@CT_Show", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Show", sys_Config_Toolbar.CT_Show);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Attr))
         {
            idb.AddParameter("@CT_Attr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Attr", sys_Config_Toolbar.CT_Attr);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Class))
         {
            idb.AddParameter("@CT_Class", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Class", sys_Config_Toolbar.CT_Class);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Event))
         {
            idb.AddParameter("@CT_Event", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Event", sys_Config_Toolbar.CT_Event);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Udef1))
         {
            idb.AddParameter("@CT_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Udef1", sys_Config_Toolbar.CT_Udef1);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Udef2))
         {
            idb.AddParameter("@CT_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Udef2", sys_Config_Toolbar.CT_Udef2);
         }
         if (sys_Config_Toolbar.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Toolbar.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_Config_Toolbar对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Config_Toolbar sys_Config_Toolbar)
      {
         string sql = "INSERT INTO Sys_Config_Toolbar (CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,CT_Attr,CT_Class,CT_Event,CT_Udef1,CT_Udef2,Stat) VALUES (@CT_Module,@CT_Field,@CT_Name,@CT_Order,@CT_Type,@CT_DictKey,@CT_JS,@CT_Default,@CT_Show,@CT_Attr,@CT_Class,@CT_Event,@CT_Udef1,@CT_Udef2,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Module))
         {
            idb.AddParameter("@CT_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Module", sys_Config_Toolbar.CT_Module);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Field))
         {
            idb.AddParameter("@CT_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Field", sys_Config_Toolbar.CT_Field);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Name))
         {
            idb.AddParameter("@CT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Name", sys_Config_Toolbar.CT_Name);
         }
         if (sys_Config_Toolbar.CT_Order == 0)
         {
            idb.AddParameter("@CT_Order", 0);
         }
         else
         {
            idb.AddParameter("@CT_Order", sys_Config_Toolbar.CT_Order);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Type))
         {
            idb.AddParameter("@CT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Type", sys_Config_Toolbar.CT_Type);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_DictKey))
         {
            idb.AddParameter("@CT_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_DictKey", sys_Config_Toolbar.CT_DictKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_JS))
         {
            idb.AddParameter("@CT_JS", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_JS", sys_Config_Toolbar.CT_JS);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Default))
         {
            idb.AddParameter("@CT_Default", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Default", sys_Config_Toolbar.CT_Default);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Show))
         {
            idb.AddParameter("@CT_Show", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Show", sys_Config_Toolbar.CT_Show);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Attr))
         {
            idb.AddParameter("@CT_Attr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Attr", sys_Config_Toolbar.CT_Attr);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Class))
         {
            idb.AddParameter("@CT_Class", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Class", sys_Config_Toolbar.CT_Class);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Event))
         {
            idb.AddParameter("@CT_Event", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Event", sys_Config_Toolbar.CT_Event);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Udef1))
         {
            idb.AddParameter("@CT_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Udef1", sys_Config_Toolbar.CT_Udef1);
         }
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Udef2))
         {
            idb.AddParameter("@CT_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Udef2", sys_Config_Toolbar.CT_Udef2);
         }
         if (sys_Config_Toolbar.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Toolbar.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_Config_Toolbar对象(即:一条记录
      /// </summary>
      public int Update(Sys_Config_Toolbar sys_Config_Toolbar)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Config_Toolbar       SET ");
            if(sys_Config_Toolbar.CT_Module_IsChanged){sbParameter.Append("CT_Module=@CT_Module, ");}
      if(sys_Config_Toolbar.CT_Field_IsChanged){sbParameter.Append("CT_Field=@CT_Field, ");}
      if(sys_Config_Toolbar.CT_Name_IsChanged){sbParameter.Append("CT_Name=@CT_Name, ");}
      if(sys_Config_Toolbar.CT_Order_IsChanged){sbParameter.Append("CT_Order=@CT_Order, ");}
      if(sys_Config_Toolbar.CT_Type_IsChanged){sbParameter.Append("CT_Type=@CT_Type, ");}
      if(sys_Config_Toolbar.CT_DictKey_IsChanged){sbParameter.Append("CT_DictKey=@CT_DictKey, ");}
      if(sys_Config_Toolbar.CT_JS_IsChanged){sbParameter.Append("CT_JS=@CT_JS, ");}
      if(sys_Config_Toolbar.CT_Default_IsChanged){sbParameter.Append("CT_Default=@CT_Default, ");}
      if(sys_Config_Toolbar.CT_Show_IsChanged){sbParameter.Append("CT_Show=@CT_Show, ");}
      if(sys_Config_Toolbar.CT_Attr_IsChanged){sbParameter.Append("CT_Attr=@CT_Attr, ");}
      if(sys_Config_Toolbar.CT_Class_IsChanged){sbParameter.Append("CT_Class=@CT_Class, ");}
      if(sys_Config_Toolbar.CT_Event_IsChanged){sbParameter.Append("CT_Event=@CT_Event, ");}
      if(sys_Config_Toolbar.CT_Udef1_IsChanged){sbParameter.Append("CT_Udef1=@CT_Udef1, ");}
      if(sys_Config_Toolbar.CT_Udef2_IsChanged){sbParameter.Append("CT_Udef2=@CT_Udef2, ");}
      if(sys_Config_Toolbar.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CT_ID=@CT_ID; " );
      string sql=sb.ToString();
         if(sys_Config_Toolbar.CT_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Module))
         {
            idb.AddParameter("@CT_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Module", sys_Config_Toolbar.CT_Module);
         }
          }
         if(sys_Config_Toolbar.CT_Field_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Field))
         {
            idb.AddParameter("@CT_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Field", sys_Config_Toolbar.CT_Field);
         }
          }
         if(sys_Config_Toolbar.CT_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Name))
         {
            idb.AddParameter("@CT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Name", sys_Config_Toolbar.CT_Name);
         }
          }
         if(sys_Config_Toolbar.CT_Order_IsChanged)
         {
         if (sys_Config_Toolbar.CT_Order == 0)
         {
            idb.AddParameter("@CT_Order", 0);
         }
         else
         {
            idb.AddParameter("@CT_Order", sys_Config_Toolbar.CT_Order);
         }
          }
         if(sys_Config_Toolbar.CT_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Type))
         {
            idb.AddParameter("@CT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Type", sys_Config_Toolbar.CT_Type);
         }
          }
         if(sys_Config_Toolbar.CT_DictKey_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_DictKey))
         {
            idb.AddParameter("@CT_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_DictKey", sys_Config_Toolbar.CT_DictKey);
         }
          }
         if(sys_Config_Toolbar.CT_JS_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_JS))
         {
            idb.AddParameter("@CT_JS", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_JS", sys_Config_Toolbar.CT_JS);
         }
          }
         if(sys_Config_Toolbar.CT_Default_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Default))
         {
            idb.AddParameter("@CT_Default", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Default", sys_Config_Toolbar.CT_Default);
         }
          }
         if(sys_Config_Toolbar.CT_Show_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Show))
         {
            idb.AddParameter("@CT_Show", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Show", sys_Config_Toolbar.CT_Show);
         }
          }
         if(sys_Config_Toolbar.CT_Attr_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Attr))
         {
            idb.AddParameter("@CT_Attr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Attr", sys_Config_Toolbar.CT_Attr);
         }
          }
         if(sys_Config_Toolbar.CT_Class_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Class))
         {
            idb.AddParameter("@CT_Class", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Class", sys_Config_Toolbar.CT_Class);
         }
          }
         if(sys_Config_Toolbar.CT_Event_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Event))
         {
            idb.AddParameter("@CT_Event", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Event", sys_Config_Toolbar.CT_Event);
         }
          }
         if(sys_Config_Toolbar.CT_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Udef1))
         {
            idb.AddParameter("@CT_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Udef1", sys_Config_Toolbar.CT_Udef1);
         }
          }
         if(sys_Config_Toolbar.CT_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Toolbar.CT_Udef2))
         {
            idb.AddParameter("@CT_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Udef2", sys_Config_Toolbar.CT_Udef2);
         }
          }
         if(sys_Config_Toolbar.Stat_IsChanged)
         {
         if (sys_Config_Toolbar.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Toolbar.Stat);
         }
          }

         idb.AddParameter("@CT_ID", sys_Config_Toolbar.CT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_Config_Toolbar对象(即:一条记录
      /// </summary>
      public int Delete(decimal cT_ID)
      {
         string sql = "DELETE Sys_Config_Toolbar WHERE 1=1  AND CT_ID=@CT_ID ";
         idb.AddParameter("@CT_ID", cT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_Config_Toolbar对象(即:一条记录
      /// </summary>
      public Sys_Config_Toolbar GetByKey(decimal cT_ID)
      {
         Sys_Config_Toolbar sys_Config_Toolbar = new Sys_Config_Toolbar();
         string sql = "SELECT  CT_ID,CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,CT_Attr,CT_Class,CT_Event,CT_Udef1,CT_Udef2,Stat FROM Sys_Config_Toolbar WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CT_ID=@CT_ID ";
         idb.AddParameter("@CT_ID", cT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CT_ID"] != DBNull.Value) sys_Config_Toolbar.CT_ID = Convert.ToDecimal(dr["CT_ID"]);
            if (dr["CT_Module"] != DBNull.Value) sys_Config_Toolbar.CT_Module = Convert.ToString(dr["CT_Module"]);
            if (dr["CT_Field"] != DBNull.Value) sys_Config_Toolbar.CT_Field = Convert.ToString(dr["CT_Field"]);
            if (dr["CT_Name"] != DBNull.Value) sys_Config_Toolbar.CT_Name = Convert.ToString(dr["CT_Name"]);
            if (dr["CT_Order"] != DBNull.Value) sys_Config_Toolbar.CT_Order = Convert.ToInt32(dr["CT_Order"]);
            if (dr["CT_Type"] != DBNull.Value) sys_Config_Toolbar.CT_Type = Convert.ToString(dr["CT_Type"]);
            if (dr["CT_DictKey"] != DBNull.Value) sys_Config_Toolbar.CT_DictKey = Convert.ToString(dr["CT_DictKey"]);
            if (dr["CT_JS"] != DBNull.Value) sys_Config_Toolbar.CT_JS = Convert.ToString(dr["CT_JS"]);
            if (dr["CT_Default"] != DBNull.Value) sys_Config_Toolbar.CT_Default = Convert.ToString(dr["CT_Default"]);
            if (dr["CT_Show"] != DBNull.Value) sys_Config_Toolbar.CT_Show = Convert.ToString(dr["CT_Show"]);
            if (dr["CT_Attr"] != DBNull.Value) sys_Config_Toolbar.CT_Attr = Convert.ToString(dr["CT_Attr"]);
            if (dr["CT_Class"] != DBNull.Value) sys_Config_Toolbar.CT_Class = Convert.ToString(dr["CT_Class"]);
            if (dr["CT_Event"] != DBNull.Value) sys_Config_Toolbar.CT_Event = Convert.ToString(dr["CT_Event"]);
            if (dr["CT_Udef1"] != DBNull.Value) sys_Config_Toolbar.CT_Udef1 = Convert.ToString(dr["CT_Udef1"]);
            if (dr["CT_Udef2"] != DBNull.Value) sys_Config_Toolbar.CT_Udef2 = Convert.ToString(dr["CT_Udef2"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Toolbar.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Config_Toolbar;
      }
      /// <summary>
      /// 获取指定的Sys_Config_Toolbar对象集合
      /// </summary>
      public List<Sys_Config_Toolbar> GetListByWhere(string strCondition)
      {
         List<Sys_Config_Toolbar> ret = new List<Sys_Config_Toolbar>();
         string sql = "SELECT  CT_ID,CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,CT_Attr,CT_Class,CT_Event,CT_Udef1,CT_Udef2,Stat FROM Sys_Config_Toolbar WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY CT_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_Toolbar sys_Config_Toolbar = new Sys_Config_Toolbar();
            if (dr["CT_ID"] != DBNull.Value) sys_Config_Toolbar.CT_ID = Convert.ToDecimal(dr["CT_ID"]);
            if (dr["CT_Module"] != DBNull.Value) sys_Config_Toolbar.CT_Module = Convert.ToString(dr["CT_Module"]);
            if (dr["CT_Field"] != DBNull.Value) sys_Config_Toolbar.CT_Field = Convert.ToString(dr["CT_Field"]);
            if (dr["CT_Name"] != DBNull.Value) sys_Config_Toolbar.CT_Name = Convert.ToString(dr["CT_Name"]);
            if (dr["CT_Order"] != DBNull.Value) sys_Config_Toolbar.CT_Order = Convert.ToInt32(dr["CT_Order"]);
            if (dr["CT_Type"] != DBNull.Value) sys_Config_Toolbar.CT_Type = Convert.ToString(dr["CT_Type"]);
            if (dr["CT_DictKey"] != DBNull.Value) sys_Config_Toolbar.CT_DictKey = Convert.ToString(dr["CT_DictKey"]);
            if (dr["CT_JS"] != DBNull.Value) sys_Config_Toolbar.CT_JS = Convert.ToString(dr["CT_JS"]);
            if (dr["CT_Default"] != DBNull.Value) sys_Config_Toolbar.CT_Default = Convert.ToString(dr["CT_Default"]);
            if (dr["CT_Show"] != DBNull.Value) sys_Config_Toolbar.CT_Show = Convert.ToString(dr["CT_Show"]);
            if (dr["CT_Attr"] != DBNull.Value) sys_Config_Toolbar.CT_Attr = Convert.ToString(dr["CT_Attr"]);
            if (dr["CT_Class"] != DBNull.Value) sys_Config_Toolbar.CT_Class = Convert.ToString(dr["CT_Class"]);
            if (dr["CT_Event"] != DBNull.Value) sys_Config_Toolbar.CT_Event = Convert.ToString(dr["CT_Event"]);
            if (dr["CT_Udef1"] != DBNull.Value) sys_Config_Toolbar.CT_Udef1 = Convert.ToString(dr["CT_Udef1"]);
            if (dr["CT_Udef2"] != DBNull.Value) sys_Config_Toolbar.CT_Udef2 = Convert.ToString(dr["CT_Udef2"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Toolbar.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Config_Toolbar);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_Config_Toolbar对象(即:一条记录
      /// </summary>
      public List<Sys_Config_Toolbar> GetAll()
      {
         List<Sys_Config_Toolbar> ret = new List<Sys_Config_Toolbar>();
         string sql = "SELECT  CT_ID,CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,CT_Attr,CT_Class,CT_Event,CT_Udef1,CT_Udef2,Stat FROM Sys_Config_Toolbar where 1=1 AND ((Stat is null) or (Stat=0) ) order by CT_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_Toolbar sys_Config_Toolbar = new Sys_Config_Toolbar();
            if (dr["CT_ID"] != DBNull.Value) sys_Config_Toolbar.CT_ID = Convert.ToDecimal(dr["CT_ID"]);
            if (dr["CT_Module"] != DBNull.Value) sys_Config_Toolbar.CT_Module = Convert.ToString(dr["CT_Module"]);
            if (dr["CT_Field"] != DBNull.Value) sys_Config_Toolbar.CT_Field = Convert.ToString(dr["CT_Field"]);
            if (dr["CT_Name"] != DBNull.Value) sys_Config_Toolbar.CT_Name = Convert.ToString(dr["CT_Name"]);
            if (dr["CT_Order"] != DBNull.Value) sys_Config_Toolbar.CT_Order = Convert.ToInt32(dr["CT_Order"]);
            if (dr["CT_Type"] != DBNull.Value) sys_Config_Toolbar.CT_Type = Convert.ToString(dr["CT_Type"]);
            if (dr["CT_DictKey"] != DBNull.Value) sys_Config_Toolbar.CT_DictKey = Convert.ToString(dr["CT_DictKey"]);
            if (dr["CT_JS"] != DBNull.Value) sys_Config_Toolbar.CT_JS = Convert.ToString(dr["CT_JS"]);
            if (dr["CT_Default"] != DBNull.Value) sys_Config_Toolbar.CT_Default = Convert.ToString(dr["CT_Default"]);
            if (dr["CT_Show"] != DBNull.Value) sys_Config_Toolbar.CT_Show = Convert.ToString(dr["CT_Show"]);
            if (dr["CT_Attr"] != DBNull.Value) sys_Config_Toolbar.CT_Attr = Convert.ToString(dr["CT_Attr"]);
            if (dr["CT_Class"] != DBNull.Value) sys_Config_Toolbar.CT_Class = Convert.ToString(dr["CT_Class"]);
            if (dr["CT_Event"] != DBNull.Value) sys_Config_Toolbar.CT_Event = Convert.ToString(dr["CT_Event"]);
            if (dr["CT_Udef1"] != DBNull.Value) sys_Config_Toolbar.CT_Udef1 = Convert.ToString(dr["CT_Udef1"]);
            if (dr["CT_Udef2"] != DBNull.Value) sys_Config_Toolbar.CT_Udef2 = Convert.ToString(dr["CT_Udef2"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Toolbar.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Config_Toolbar);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
