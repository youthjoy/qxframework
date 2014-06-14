using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.ChartLib.Model;
using QX.DataAcess;

namespace QX.ChartLib.DAL
{
   /// <summary>
   /// 图表配置细表
   /// </summary>
   [Serializable]
   public partial class ADOChartDetail
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加图表配置细表 ChartDetail对象(即:一条记录)
      /// </summary>
      public int Add(ChartDetail chartDetail)
      {
         string sql = "INSERT INTO ChartDetail (CD_Module,CD_Areas,CD_ChartType,CD_DataSource,CD_Parmas,CD_BorderWidth,CD_BorderColor,CD_BorderDashStyle,CD_IsValueShownAsLabel,CD_LegendText,CD_MarkerSize,CD_MarkerColor,CD_MarkerStyle,Stat) VALUES (@CD_Module,@CD_Areas,@CD_ChartType,@CD_DataSource,@CD_Parmas,@CD_BorderWidth,@CD_BorderColor,@CD_BorderDashStyle,@CD_IsValueShownAsLabel,@CD_LegendText,@CD_MarkerSize,@CD_MarkerColor,@CD_MarkerStyle,@Stat)";
         if (string.IsNullOrEmpty(chartDetail.CD_Module))
         {
            idb.AddParameter("@CD_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Module", chartDetail.CD_Module);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_Areas))
         {
            idb.AddParameter("@CD_Areas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Areas", chartDetail.CD_Areas);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_ChartType))
         {
            idb.AddParameter("@CD_ChartType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_ChartType", chartDetail.CD_ChartType);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_DataSource))
         {
            idb.AddParameter("@CD_DataSource", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_DataSource", chartDetail.CD_DataSource);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_Parmas))
         {
            idb.AddParameter("@CD_Parmas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Parmas", chartDetail.CD_Parmas);
         }
         if (chartDetail.CD_BorderWidth == 0)
         {
            idb.AddParameter("@CD_BorderWidth", 0);
         }
         else
         {
            idb.AddParameter("@CD_BorderWidth", chartDetail.CD_BorderWidth);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_BorderColor))
         {
            idb.AddParameter("@CD_BorderColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_BorderColor", chartDetail.CD_BorderColor);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_BorderDashStyle))
         {
            idb.AddParameter("@CD_BorderDashStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_BorderDashStyle", chartDetail.CD_BorderDashStyle);
         }
         if (chartDetail.CD_IsValueShownAsLabel == false)
         {
            idb.AddParameter("@CD_IsValueShownAsLabel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_IsValueShownAsLabel", chartDetail.CD_IsValueShownAsLabel);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_LegendText))
         {
            idb.AddParameter("@CD_LegendText", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_LegendText", chartDetail.CD_LegendText);
         }
         if (chartDetail.CD_MarkerSize == 0)
         {
            idb.AddParameter("@CD_MarkerSize", 0);
         }
         else
         {
            idb.AddParameter("@CD_MarkerSize", chartDetail.CD_MarkerSize);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_MarkerColor))
         {
            idb.AddParameter("@CD_MarkerColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_MarkerColor", chartDetail.CD_MarkerColor);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_MarkerStyle))
         {
            idb.AddParameter("@CD_MarkerStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_MarkerStyle", chartDetail.CD_MarkerStyle);
         }
         if (chartDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartDetail.Stat);
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
      /// 添加图表配置细表 ChartDetail对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(ChartDetail chartDetail)
      {
         string sql = "INSERT INTO ChartDetail (CD_Module,CD_Areas,CD_ChartType,CD_DataSource,CD_Parmas,CD_BorderWidth,CD_BorderColor,CD_BorderDashStyle,CD_IsValueShownAsLabel,CD_LegendText,CD_MarkerSize,CD_MarkerColor,CD_MarkerStyle,Stat) VALUES (@CD_Module,@CD_Areas,@CD_ChartType,@CD_DataSource,@CD_Parmas,@CD_BorderWidth,@CD_BorderColor,@CD_BorderDashStyle,@CD_IsValueShownAsLabel,@CD_LegendText,@CD_MarkerSize,@CD_MarkerColor,@CD_MarkerStyle,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(chartDetail.CD_Module))
         {
            idb.AddParameter("@CD_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Module", chartDetail.CD_Module);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_Areas))
         {
            idb.AddParameter("@CD_Areas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Areas", chartDetail.CD_Areas);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_ChartType))
         {
            idb.AddParameter("@CD_ChartType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_ChartType", chartDetail.CD_ChartType);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_DataSource))
         {
            idb.AddParameter("@CD_DataSource", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_DataSource", chartDetail.CD_DataSource);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_Parmas))
         {
            idb.AddParameter("@CD_Parmas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Parmas", chartDetail.CD_Parmas);
         }
         if (chartDetail.CD_BorderWidth == 0)
         {
            idb.AddParameter("@CD_BorderWidth", 0);
         }
         else
         {
            idb.AddParameter("@CD_BorderWidth", chartDetail.CD_BorderWidth);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_BorderColor))
         {
            idb.AddParameter("@CD_BorderColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_BorderColor", chartDetail.CD_BorderColor);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_BorderDashStyle))
         {
            idb.AddParameter("@CD_BorderDashStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_BorderDashStyle", chartDetail.CD_BorderDashStyle);
         }
         if (chartDetail.CD_IsValueShownAsLabel == false)
         {
            idb.AddParameter("@CD_IsValueShownAsLabel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_IsValueShownAsLabel", chartDetail.CD_IsValueShownAsLabel);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_LegendText))
         {
            idb.AddParameter("@CD_LegendText", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_LegendText", chartDetail.CD_LegendText);
         }
         if (chartDetail.CD_MarkerSize == 0)
         {
            idb.AddParameter("@CD_MarkerSize", 0);
         }
         else
         {
            idb.AddParameter("@CD_MarkerSize", chartDetail.CD_MarkerSize);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_MarkerColor))
         {
            idb.AddParameter("@CD_MarkerColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_MarkerColor", chartDetail.CD_MarkerColor);
         }
         if (string.IsNullOrEmpty(chartDetail.CD_MarkerStyle))
         {
            idb.AddParameter("@CD_MarkerStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_MarkerStyle", chartDetail.CD_MarkerStyle);
         }
         if (chartDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartDetail.Stat);
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
      /// 更新图表配置细表 ChartDetail对象(即:一条记录
      /// </summary>
      public int Update(ChartDetail chartDetail)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       ChartDetail       SET ");
            if(chartDetail.CD_Module_IsChanged){sbParameter.Append("CD_Module=@CD_Module, ");}
      if(chartDetail.CD_Areas_IsChanged){sbParameter.Append("CD_Areas=@CD_Areas, ");}
      if(chartDetail.CD_ChartType_IsChanged){sbParameter.Append("CD_ChartType=@CD_ChartType, ");}
      if(chartDetail.CD_DataSource_IsChanged){sbParameter.Append("CD_DataSource=@CD_DataSource, ");}
      if(chartDetail.CD_Parmas_IsChanged){sbParameter.Append("CD_Parmas=@CD_Parmas, ");}
      if(chartDetail.CD_BorderWidth_IsChanged){sbParameter.Append("CD_BorderWidth=@CD_BorderWidth, ");}
      if(chartDetail.CD_BorderColor_IsChanged){sbParameter.Append("CD_BorderColor=@CD_BorderColor, ");}
      if(chartDetail.CD_BorderDashStyle_IsChanged){sbParameter.Append("CD_BorderDashStyle=@CD_BorderDashStyle, ");}
      if(chartDetail.CD_IsValueShownAsLabel_IsChanged){sbParameter.Append("CD_IsValueShownAsLabel=@CD_IsValueShownAsLabel, ");}
      if(chartDetail.CD_LegendText_IsChanged){sbParameter.Append("CD_LegendText=@CD_LegendText, ");}
      if(chartDetail.CD_MarkerSize_IsChanged){sbParameter.Append("CD_MarkerSize=@CD_MarkerSize, ");}
      if(chartDetail.CD_MarkerColor_IsChanged){sbParameter.Append("CD_MarkerColor=@CD_MarkerColor, ");}
      if(chartDetail.CD_MarkerStyle_IsChanged){sbParameter.Append("CD_MarkerStyle=@CD_MarkerStyle, ");}
      if(chartDetail.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CD_ID=@CD_ID; " );
      string sql=sb.ToString();
         if(chartDetail.CD_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_Module))
         {
            idb.AddParameter("@CD_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Module", chartDetail.CD_Module);
         }
          }
         if(chartDetail.CD_Areas_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_Areas))
         {
            idb.AddParameter("@CD_Areas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Areas", chartDetail.CD_Areas);
         }
          }
         if(chartDetail.CD_ChartType_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_ChartType))
         {
            idb.AddParameter("@CD_ChartType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_ChartType", chartDetail.CD_ChartType);
         }
          }
         if(chartDetail.CD_DataSource_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_DataSource))
         {
            idb.AddParameter("@CD_DataSource", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_DataSource", chartDetail.CD_DataSource);
         }
          }
         if(chartDetail.CD_Parmas_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_Parmas))
         {
            idb.AddParameter("@CD_Parmas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_Parmas", chartDetail.CD_Parmas);
         }
          }
         if(chartDetail.CD_BorderWidth_IsChanged)
         {
         if (chartDetail.CD_BorderWidth == 0)
         {
            idb.AddParameter("@CD_BorderWidth", 0);
         }
         else
         {
            idb.AddParameter("@CD_BorderWidth", chartDetail.CD_BorderWidth);
         }
          }
         if(chartDetail.CD_BorderColor_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_BorderColor))
         {
            idb.AddParameter("@CD_BorderColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_BorderColor", chartDetail.CD_BorderColor);
         }
          }
         if(chartDetail.CD_BorderDashStyle_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_BorderDashStyle))
         {
            idb.AddParameter("@CD_BorderDashStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_BorderDashStyle", chartDetail.CD_BorderDashStyle);
         }
          }
         if(chartDetail.CD_IsValueShownAsLabel_IsChanged)
         {
         if (chartDetail.CD_IsValueShownAsLabel == false)
         {
            idb.AddParameter("@CD_IsValueShownAsLabel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_IsValueShownAsLabel", chartDetail.CD_IsValueShownAsLabel);
         }
          }
         if(chartDetail.CD_LegendText_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_LegendText))
         {
            idb.AddParameter("@CD_LegendText", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_LegendText", chartDetail.CD_LegendText);
         }
          }
         if(chartDetail.CD_MarkerSize_IsChanged)
         {
         if (chartDetail.CD_MarkerSize == 0)
         {
            idb.AddParameter("@CD_MarkerSize", 0);
         }
         else
         {
            idb.AddParameter("@CD_MarkerSize", chartDetail.CD_MarkerSize);
         }
          }
         if(chartDetail.CD_MarkerColor_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_MarkerColor))
         {
            idb.AddParameter("@CD_MarkerColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_MarkerColor", chartDetail.CD_MarkerColor);
         }
          }
         if(chartDetail.CD_MarkerStyle_IsChanged)
         {
         if (string.IsNullOrEmpty(chartDetail.CD_MarkerStyle))
         {
            idb.AddParameter("@CD_MarkerStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CD_MarkerStyle", chartDetail.CD_MarkerStyle);
         }
          }
         if(chartDetail.Stat_IsChanged)
         {
         if (chartDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartDetail.Stat);
         }
          }

         idb.AddParameter("@CD_ID", chartDetail.CD_ID);

           
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
      /// 删除图表配置细表 ChartDetail对象(即:一条记录
      /// </summary>
      public int Delete(decimal cD_ID)
      {
         string sql = "DELETE ChartDetail WHERE 1=1  AND CD_ID=@CD_ID ";
         idb.AddParameter("@CD_ID", cD_ID);

           
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
      /// 获取指定的图表配置细表 ChartDetail对象(即:一条记录
      /// </summary>
      public ChartDetail GetByKey(decimal cD_ID)
      {
         ChartDetail chartDetail = new ChartDetail();
         string sql = "SELECT  CD_ID,CD_Module,CD_Areas,CD_ChartType,CD_DataSource,CD_Parmas,CD_BorderWidth,CD_BorderColor,CD_BorderDashStyle,CD_IsValueShownAsLabel,CD_LegendText,CD_MarkerSize,CD_MarkerColor,CD_MarkerStyle,Stat FROM ChartDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CD_ID=@CD_ID ";
         idb.AddParameter("@CD_ID", cD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CD_ID"] != DBNull.Value) chartDetail.CD_ID = Convert.ToDecimal(dr["CD_ID"]);
            if (dr["CD_Module"] != DBNull.Value) chartDetail.CD_Module = Convert.ToString(dr["CD_Module"]);
            if (dr["CD_Areas"] != DBNull.Value) chartDetail.CD_Areas = Convert.ToString(dr["CD_Areas"]);
            if (dr["CD_ChartType"] != DBNull.Value) chartDetail.CD_ChartType = Convert.ToString(dr["CD_ChartType"]);
            if (dr["CD_DataSource"] != DBNull.Value) chartDetail.CD_DataSource = Convert.ToString(dr["CD_DataSource"]);
            if (dr["CD_Parmas"] != DBNull.Value) chartDetail.CD_Parmas = Convert.ToString(dr["CD_Parmas"]);
            if (dr["CD_BorderWidth"] != DBNull.Value) chartDetail.CD_BorderWidth = Convert.ToDecimal(dr["CD_BorderWidth"]);
            if (dr["CD_BorderColor"] != DBNull.Value) chartDetail.CD_BorderColor = Convert.ToString(dr["CD_BorderColor"]);
            if (dr["CD_BorderDashStyle"] != DBNull.Value) chartDetail.CD_BorderDashStyle = Convert.ToString(dr["CD_BorderDashStyle"]);
            if (dr["CD_IsValueShownAsLabel"] != DBNull.Value) chartDetail.CD_IsValueShownAsLabel = Convert.ToBoolean(dr["CD_IsValueShownAsLabel"]);
            if (dr["CD_LegendText"] != DBNull.Value) chartDetail.CD_LegendText = Convert.ToString(dr["CD_LegendText"]);
            if (dr["CD_MarkerSize"] != DBNull.Value) chartDetail.CD_MarkerSize = Convert.ToDecimal(dr["CD_MarkerSize"]);
            if (dr["CD_MarkerColor"] != DBNull.Value) chartDetail.CD_MarkerColor = Convert.ToString(dr["CD_MarkerColor"]);
            if (dr["CD_MarkerStyle"] != DBNull.Value) chartDetail.CD_MarkerStyle = Convert.ToString(dr["CD_MarkerStyle"]);
            if (dr["Stat"] != DBNull.Value) chartDetail.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return chartDetail;
      }
      /// <summary>
      /// 获取指定的图表配置细表 ChartDetail对象集合
      /// </summary>
      public List<ChartDetail> GetListByWhere(string strCondition)
      {
         List<ChartDetail> ret = new List<ChartDetail>();
         string sql = "SELECT  CD_ID,CD_Module,CD_Areas,CD_ChartType,CD_DataSource,CD_Parmas,CD_BorderWidth,CD_BorderColor,CD_BorderDashStyle,CD_IsValueShownAsLabel,CD_LegendText,CD_MarkerSize,CD_MarkerColor,CD_MarkerStyle,Stat FROM ChartDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            ChartDetail chartDetail = new ChartDetail();
            if (dr["CD_ID"] != DBNull.Value) chartDetail.CD_ID = Convert.ToDecimal(dr["CD_ID"]);
            if (dr["CD_Module"] != DBNull.Value) chartDetail.CD_Module = Convert.ToString(dr["CD_Module"]);
            if (dr["CD_Areas"] != DBNull.Value) chartDetail.CD_Areas = Convert.ToString(dr["CD_Areas"]);
            if (dr["CD_ChartType"] != DBNull.Value) chartDetail.CD_ChartType = Convert.ToString(dr["CD_ChartType"]);
            if (dr["CD_DataSource"] != DBNull.Value) chartDetail.CD_DataSource = Convert.ToString(dr["CD_DataSource"]);
            if (dr["CD_Parmas"] != DBNull.Value) chartDetail.CD_Parmas = Convert.ToString(dr["CD_Parmas"]);
            if (dr["CD_BorderWidth"] != DBNull.Value) chartDetail.CD_BorderWidth = Convert.ToDecimal(dr["CD_BorderWidth"]);
            if (dr["CD_BorderColor"] != DBNull.Value) chartDetail.CD_BorderColor = Convert.ToString(dr["CD_BorderColor"]);
            if (dr["CD_BorderDashStyle"] != DBNull.Value) chartDetail.CD_BorderDashStyle = Convert.ToString(dr["CD_BorderDashStyle"]);
            if (dr["CD_IsValueShownAsLabel"] != DBNull.Value) chartDetail.CD_IsValueShownAsLabel = Convert.ToBoolean(dr["CD_IsValueShownAsLabel"]);
            if (dr["CD_LegendText"] != DBNull.Value) chartDetail.CD_LegendText = Convert.ToString(dr["CD_LegendText"]);
            if (dr["CD_MarkerSize"] != DBNull.Value) chartDetail.CD_MarkerSize = Convert.ToDecimal(dr["CD_MarkerSize"]);
            if (dr["CD_MarkerColor"] != DBNull.Value) chartDetail.CD_MarkerColor = Convert.ToString(dr["CD_MarkerColor"]);
            if (dr["CD_MarkerStyle"] != DBNull.Value) chartDetail.CD_MarkerStyle = Convert.ToString(dr["CD_MarkerStyle"]);
            if (dr["Stat"] != DBNull.Value) chartDetail.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(chartDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的图表配置细表 ChartDetail对象(即:一条记录
      /// </summary>
      public List<ChartDetail> GetAll()
      {
         List<ChartDetail> ret = new List<ChartDetail>();
         string sql = "SELECT  CD_ID,CD_Module,CD_Areas,CD_ChartType,CD_DataSource,CD_Parmas,CD_BorderWidth,CD_BorderColor,CD_BorderDashStyle,CD_IsValueShownAsLabel,CD_LegendText,CD_MarkerSize,CD_MarkerColor,CD_MarkerStyle,Stat FROM ChartDetail where 1=1 AND ((Stat is null) or (Stat=0) ) order by CD_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            ChartDetail chartDetail = new ChartDetail();
            if (dr["CD_ID"] != DBNull.Value) chartDetail.CD_ID = Convert.ToDecimal(dr["CD_ID"]);
            if (dr["CD_Module"] != DBNull.Value) chartDetail.CD_Module = Convert.ToString(dr["CD_Module"]);
            if (dr["CD_Areas"] != DBNull.Value) chartDetail.CD_Areas = Convert.ToString(dr["CD_Areas"]);
            if (dr["CD_ChartType"] != DBNull.Value) chartDetail.CD_ChartType = Convert.ToString(dr["CD_ChartType"]);
            if (dr["CD_DataSource"] != DBNull.Value) chartDetail.CD_DataSource = Convert.ToString(dr["CD_DataSource"]);
            if (dr["CD_Parmas"] != DBNull.Value) chartDetail.CD_Parmas = Convert.ToString(dr["CD_Parmas"]);
            if (dr["CD_BorderWidth"] != DBNull.Value) chartDetail.CD_BorderWidth = Convert.ToDecimal(dr["CD_BorderWidth"]);
            if (dr["CD_BorderColor"] != DBNull.Value) chartDetail.CD_BorderColor = Convert.ToString(dr["CD_BorderColor"]);
            if (dr["CD_BorderDashStyle"] != DBNull.Value) chartDetail.CD_BorderDashStyle = Convert.ToString(dr["CD_BorderDashStyle"]);
            if (dr["CD_IsValueShownAsLabel"] != DBNull.Value) chartDetail.CD_IsValueShownAsLabel = Convert.ToBoolean(dr["CD_IsValueShownAsLabel"]);
            if (dr["CD_LegendText"] != DBNull.Value) chartDetail.CD_LegendText = Convert.ToString(dr["CD_LegendText"]);
            if (dr["CD_MarkerSize"] != DBNull.Value) chartDetail.CD_MarkerSize = Convert.ToDecimal(dr["CD_MarkerSize"]);
            if (dr["CD_MarkerColor"] != DBNull.Value) chartDetail.CD_MarkerColor = Convert.ToString(dr["CD_MarkerColor"]);
            if (dr["CD_MarkerStyle"] != DBNull.Value) chartDetail.CD_MarkerStyle = Convert.ToString(dr["CD_MarkerStyle"]);
            if (dr["Stat"] != DBNull.Value) chartDetail.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(chartDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
