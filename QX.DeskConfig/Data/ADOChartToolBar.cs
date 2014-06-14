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
   /// 报表工具条配置表
   /// </summary>
   [Serializable]
   public partial class ADOChartToolBar
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加报表工具条配置表 ChartToolBar对象(即:一条记录)
      /// </summary>
      public int Add(ChartToolBar chartToolBar)
      {
         string sql = "INSERT INTO ChartToolBar (CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,Stat,CT_Attr) VALUES (@CT_Module,@CT_Field,@CT_Name,@CT_Order,@CT_Type,@CT_DictKey,@CT_JS,@CT_Default,@CT_Show,@Stat,@CT_Attr)";
         if (string.IsNullOrEmpty(chartToolBar.CT_Module))
         {
            idb.AddParameter("@CT_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Module", chartToolBar.CT_Module);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Field))
         {
            idb.AddParameter("@CT_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Field", chartToolBar.CT_Field);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Name))
         {
            idb.AddParameter("@CT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Name", chartToolBar.CT_Name);
         }
         if (chartToolBar.CT_Order == 0)
         {
            idb.AddParameter("@CT_Order", 0);
         }
         else
         {
            idb.AddParameter("@CT_Order", chartToolBar.CT_Order);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Type))
         {
            idb.AddParameter("@CT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Type", chartToolBar.CT_Type);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_DictKey))
         {
            idb.AddParameter("@CT_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_DictKey", chartToolBar.CT_DictKey);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_JS))
         {
            idb.AddParameter("@CT_JS", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_JS", chartToolBar.CT_JS);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Default))
         {
            idb.AddParameter("@CT_Default", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Default", chartToolBar.CT_Default);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Show))
         {
            idb.AddParameter("@CT_Show", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Show", chartToolBar.CT_Show);
         }
         if (chartToolBar.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartToolBar.Stat);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Attr))
         {
            idb.AddParameter("@CT_Attr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Attr", chartToolBar.CT_Attr);
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
      /// 添加报表工具条配置表 ChartToolBar对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(ChartToolBar chartToolBar)
      {
         string sql = "INSERT INTO ChartToolBar (CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,Stat,CT_Attr) VALUES (@CT_Module,@CT_Field,@CT_Name,@CT_Order,@CT_Type,@CT_DictKey,@CT_JS,@CT_Default,@CT_Show,@Stat,@CT_Attr);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(chartToolBar.CT_Module))
         {
            idb.AddParameter("@CT_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Module", chartToolBar.CT_Module);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Field))
         {
            idb.AddParameter("@CT_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Field", chartToolBar.CT_Field);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Name))
         {
            idb.AddParameter("@CT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Name", chartToolBar.CT_Name);
         }
         if (chartToolBar.CT_Order == 0)
         {
            idb.AddParameter("@CT_Order", 0);
         }
         else
         {
            idb.AddParameter("@CT_Order", chartToolBar.CT_Order);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Type))
         {
            idb.AddParameter("@CT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Type", chartToolBar.CT_Type);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_DictKey))
         {
            idb.AddParameter("@CT_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_DictKey", chartToolBar.CT_DictKey);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_JS))
         {
            idb.AddParameter("@CT_JS", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_JS", chartToolBar.CT_JS);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Default))
         {
            idb.AddParameter("@CT_Default", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Default", chartToolBar.CT_Default);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Show))
         {
            idb.AddParameter("@CT_Show", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Show", chartToolBar.CT_Show);
         }
         if (chartToolBar.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartToolBar.Stat);
         }
         if (string.IsNullOrEmpty(chartToolBar.CT_Attr))
         {
            idb.AddParameter("@CT_Attr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Attr", chartToolBar.CT_Attr);
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
      /// 更新报表工具条配置表 ChartToolBar对象(即:一条记录
      /// </summary>
      public int Update(ChartToolBar chartToolBar)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       ChartToolBar       SET ");
            if(chartToolBar.CT_Module_IsChanged){sbParameter.Append("CT_Module=@CT_Module, ");}
      if(chartToolBar.CT_Field_IsChanged){sbParameter.Append("CT_Field=@CT_Field, ");}
      if(chartToolBar.CT_Name_IsChanged){sbParameter.Append("CT_Name=@CT_Name, ");}
      if(chartToolBar.CT_Order_IsChanged){sbParameter.Append("CT_Order=@CT_Order, ");}
      if(chartToolBar.CT_Type_IsChanged){sbParameter.Append("CT_Type=@CT_Type, ");}
      if(chartToolBar.CT_DictKey_IsChanged){sbParameter.Append("CT_DictKey=@CT_DictKey, ");}
      if(chartToolBar.CT_JS_IsChanged){sbParameter.Append("CT_JS=@CT_JS, ");}
      if(chartToolBar.CT_Default_IsChanged){sbParameter.Append("CT_Default=@CT_Default, ");}
      if(chartToolBar.CT_Show_IsChanged){sbParameter.Append("CT_Show=@CT_Show, ");}
      if(chartToolBar.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(chartToolBar.CT_Attr_IsChanged){sbParameter.Append("CT_Attr=@CT_Attr ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CT_ID=@CT_ID; " );
      string sql=sb.ToString();
         if(chartToolBar.CT_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_Module))
         {
            idb.AddParameter("@CT_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Module", chartToolBar.CT_Module);
         }
          }
         if(chartToolBar.CT_Field_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_Field))
         {
            idb.AddParameter("@CT_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Field", chartToolBar.CT_Field);
         }
          }
         if(chartToolBar.CT_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_Name))
         {
            idb.AddParameter("@CT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Name", chartToolBar.CT_Name);
         }
          }
         if(chartToolBar.CT_Order_IsChanged)
         {
         if (chartToolBar.CT_Order == 0)
         {
            idb.AddParameter("@CT_Order", 0);
         }
         else
         {
            idb.AddParameter("@CT_Order", chartToolBar.CT_Order);
         }
          }
         if(chartToolBar.CT_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_Type))
         {
            idb.AddParameter("@CT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Type", chartToolBar.CT_Type);
         }
          }
         if(chartToolBar.CT_DictKey_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_DictKey))
         {
            idb.AddParameter("@CT_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_DictKey", chartToolBar.CT_DictKey);
         }
          }
         if(chartToolBar.CT_JS_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_JS))
         {
            idb.AddParameter("@CT_JS", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_JS", chartToolBar.CT_JS);
         }
          }
         if(chartToolBar.CT_Default_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_Default))
         {
            idb.AddParameter("@CT_Default", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Default", chartToolBar.CT_Default);
         }
          }
         if(chartToolBar.CT_Show_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_Show))
         {
            idb.AddParameter("@CT_Show", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Show", chartToolBar.CT_Show);
         }
          }
         if(chartToolBar.Stat_IsChanged)
         {
         if (chartToolBar.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartToolBar.Stat);
         }
          }
         if(chartToolBar.CT_Attr_IsChanged)
         {
         if (string.IsNullOrEmpty(chartToolBar.CT_Attr))
         {
            idb.AddParameter("@CT_Attr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CT_Attr", chartToolBar.CT_Attr);
         }
          }

         idb.AddParameter("@CT_ID", chartToolBar.CT_ID);

           
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
      /// 删除报表工具条配置表 ChartToolBar对象(即:一条记录
      /// </summary>
      public int Delete(decimal cT_ID)
      {
         string sql = "DELETE ChartToolBar WHERE 1=1  AND CT_ID=@CT_ID ";
         idb.AddParameter("@CT_ID", cT_ID);

           
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
      /// 获取指定的报表工具条配置表 ChartToolBar对象(即:一条记录
      /// </summary>
      public ChartToolBar GetByKey(decimal cT_ID)
      {
         ChartToolBar chartToolBar = new ChartToolBar();
         string sql = "SELECT  CT_ID,CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,Stat,CT_Attr FROM ChartToolBar WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CT_ID=@CT_ID ";
         idb.AddParameter("@CT_ID", cT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CT_ID"] != DBNull.Value) chartToolBar.CT_ID = Convert.ToDecimal(dr["CT_ID"]);
            if (dr["CT_Module"] != DBNull.Value) chartToolBar.CT_Module = Convert.ToString(dr["CT_Module"]);
            if (dr["CT_Field"] != DBNull.Value) chartToolBar.CT_Field = Convert.ToString(dr["CT_Field"]);
            if (dr["CT_Name"] != DBNull.Value) chartToolBar.CT_Name = Convert.ToString(dr["CT_Name"]);
            if (dr["CT_Order"] != DBNull.Value) chartToolBar.CT_Order = Convert.ToInt32(dr["CT_Order"]);
            if (dr["CT_Type"] != DBNull.Value) chartToolBar.CT_Type = Convert.ToString(dr["CT_Type"]);
            if (dr["CT_DictKey"] != DBNull.Value) chartToolBar.CT_DictKey = Convert.ToString(dr["CT_DictKey"]);
            if (dr["CT_JS"] != DBNull.Value) chartToolBar.CT_JS = Convert.ToString(dr["CT_JS"]);
            if (dr["CT_Default"] != DBNull.Value) chartToolBar.CT_Default = Convert.ToString(dr["CT_Default"]);
            if (dr["CT_Show"] != DBNull.Value) chartToolBar.CT_Show = Convert.ToString(dr["CT_Show"]);
            if (dr["Stat"] != DBNull.Value) chartToolBar.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CT_Attr"] != DBNull.Value) chartToolBar.CT_Attr = Convert.ToString(dr["CT_Attr"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return chartToolBar;
      }
      /// <summary>
      /// 获取指定的报表工具条配置表 ChartToolBar对象集合
      /// </summary>
      public List<ChartToolBar> GetListByWhere(string strCondition)
      {
         List<ChartToolBar> ret = new List<ChartToolBar>();
         string sql = "SELECT  CT_ID,CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,Stat,CT_Attr FROM ChartToolBar WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            ChartToolBar chartToolBar = new ChartToolBar();
            if (dr["CT_ID"] != DBNull.Value) chartToolBar.CT_ID = Convert.ToDecimal(dr["CT_ID"]);
            if (dr["CT_Module"] != DBNull.Value) chartToolBar.CT_Module = Convert.ToString(dr["CT_Module"]);
            if (dr["CT_Field"] != DBNull.Value) chartToolBar.CT_Field = Convert.ToString(dr["CT_Field"]);
            if (dr["CT_Name"] != DBNull.Value) chartToolBar.CT_Name = Convert.ToString(dr["CT_Name"]);
            if (dr["CT_Order"] != DBNull.Value) chartToolBar.CT_Order = Convert.ToInt32(dr["CT_Order"]);
            if (dr["CT_Type"] != DBNull.Value) chartToolBar.CT_Type = Convert.ToString(dr["CT_Type"]);
            if (dr["CT_DictKey"] != DBNull.Value) chartToolBar.CT_DictKey = Convert.ToString(dr["CT_DictKey"]);
            if (dr["CT_JS"] != DBNull.Value) chartToolBar.CT_JS = Convert.ToString(dr["CT_JS"]);
            if (dr["CT_Default"] != DBNull.Value) chartToolBar.CT_Default = Convert.ToString(dr["CT_Default"]);
            if (dr["CT_Show"] != DBNull.Value) chartToolBar.CT_Show = Convert.ToString(dr["CT_Show"]);
            if (dr["Stat"] != DBNull.Value) chartToolBar.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CT_Attr"] != DBNull.Value) chartToolBar.CT_Attr = Convert.ToString(dr["CT_Attr"]);
            ret.Add(chartToolBar);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的报表工具条配置表 ChartToolBar对象(即:一条记录
      /// </summary>
      public List<ChartToolBar> GetAll()
      {
         List<ChartToolBar> ret = new List<ChartToolBar>();
         string sql = "SELECT  CT_ID,CT_Module,CT_Field,CT_Name,CT_Order,CT_Type,CT_DictKey,CT_JS,CT_Default,CT_Show,Stat,CT_Attr FROM ChartToolBar where 1=1 AND ((Stat is null) or (Stat=0) ) order by CT_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            ChartToolBar chartToolBar = new ChartToolBar();
            if (dr["CT_ID"] != DBNull.Value) chartToolBar.CT_ID = Convert.ToDecimal(dr["CT_ID"]);
            if (dr["CT_Module"] != DBNull.Value) chartToolBar.CT_Module = Convert.ToString(dr["CT_Module"]);
            if (dr["CT_Field"] != DBNull.Value) chartToolBar.CT_Field = Convert.ToString(dr["CT_Field"]);
            if (dr["CT_Name"] != DBNull.Value) chartToolBar.CT_Name = Convert.ToString(dr["CT_Name"]);
            if (dr["CT_Order"] != DBNull.Value) chartToolBar.CT_Order = Convert.ToInt32(dr["CT_Order"]);
            if (dr["CT_Type"] != DBNull.Value) chartToolBar.CT_Type = Convert.ToString(dr["CT_Type"]);
            if (dr["CT_DictKey"] != DBNull.Value) chartToolBar.CT_DictKey = Convert.ToString(dr["CT_DictKey"]);
            if (dr["CT_JS"] != DBNull.Value) chartToolBar.CT_JS = Convert.ToString(dr["CT_JS"]);
            if (dr["CT_Default"] != DBNull.Value) chartToolBar.CT_Default = Convert.ToString(dr["CT_Default"]);
            if (dr["CT_Show"] != DBNull.Value) chartToolBar.CT_Show = Convert.ToString(dr["CT_Show"]);
            if (dr["Stat"] != DBNull.Value) chartToolBar.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CT_Attr"] != DBNull.Value) chartToolBar.CT_Attr = Convert.ToString(dr["CT_Attr"]);
            ret.Add(chartToolBar);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
