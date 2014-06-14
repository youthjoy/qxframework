using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.ChartLib.Model
{
   /// <summary>
   /// 图表配置细表
   /// </summary>
   [Serializable]
   public partial class ChartDetail
   {
      private decimal cD_ID;
      private bool cD_ID_IsChanged=false;
      public decimal CD_ID
      {
         get{ return cD_ID; }
         set{ cD_ID = value; cD_ID_IsChanged=true; }
      }
      public bool CD_ID_IsChanged
      {
         get{ return cD_ID_IsChanged; }
         set{ cD_ID_IsChanged = value; }
      }
      private string cD_Module;
      private bool cD_Module_IsChanged=false;
      public string CD_Module
      {
         get{ return cD_Module; }
         set{ cD_Module = value; cD_Module_IsChanged=true; }
      }
      public bool CD_Module_IsChanged
      {
         get{ return cD_Module_IsChanged; }
         set{ cD_Module_IsChanged = value; }
      }
      private string cD_Areas;
      private bool cD_Areas_IsChanged=false;
      public string CD_Areas
      {
         get{ return cD_Areas; }
         set{ cD_Areas = value; cD_Areas_IsChanged=true; }
      }
      public bool CD_Areas_IsChanged
      {
         get{ return cD_Areas_IsChanged; }
         set{ cD_Areas_IsChanged = value; }
      }
      private string cD_ChartType;
      private bool cD_ChartType_IsChanged=false;
      public string CD_ChartType
      {
         get{ return cD_ChartType; }
         set{ cD_ChartType = value; cD_ChartType_IsChanged=true; }
      }
      public bool CD_ChartType_IsChanged
      {
         get{ return cD_ChartType_IsChanged; }
         set{ cD_ChartType_IsChanged = value; }
      }
      private string cD_DataSource;
      private bool cD_DataSource_IsChanged=false;
      public string CD_DataSource
      {
         get{ return cD_DataSource; }
         set{ cD_DataSource = value; cD_DataSource_IsChanged=true; }
      }
      public bool CD_DataSource_IsChanged
      {
         get{ return cD_DataSource_IsChanged; }
         set{ cD_DataSource_IsChanged = value; }
      }
      private string cD_Parmas;
      private bool cD_Parmas_IsChanged=false;
      public string CD_Parmas
      {
         get{ return cD_Parmas; }
         set{ cD_Parmas = value; cD_Parmas_IsChanged=true; }
      }
      public bool CD_Parmas_IsChanged
      {
         get{ return cD_Parmas_IsChanged; }
         set{ cD_Parmas_IsChanged = value; }
      }
      private decimal cD_BorderWidth;
      private bool cD_BorderWidth_IsChanged=false;
      public decimal CD_BorderWidth
      {
         get{ return cD_BorderWidth; }
         set{ cD_BorderWidth = value; cD_BorderWidth_IsChanged=true; }
      }
      public bool CD_BorderWidth_IsChanged
      {
         get{ return cD_BorderWidth_IsChanged; }
         set{ cD_BorderWidth_IsChanged = value; }
      }
      private string cD_BorderColor;
      private bool cD_BorderColor_IsChanged=false;
      public string CD_BorderColor
      {
         get{ return cD_BorderColor; }
         set{ cD_BorderColor = value; cD_BorderColor_IsChanged=true; }
      }
      public bool CD_BorderColor_IsChanged
      {
         get{ return cD_BorderColor_IsChanged; }
         set{ cD_BorderColor_IsChanged = value; }
      }
      private string cD_BorderDashStyle;
      private bool cD_BorderDashStyle_IsChanged=false;
      public string CD_BorderDashStyle
      {
         get{ return cD_BorderDashStyle; }
         set{ cD_BorderDashStyle = value; cD_BorderDashStyle_IsChanged=true; }
      }
      public bool CD_BorderDashStyle_IsChanged
      {
         get{ return cD_BorderDashStyle_IsChanged; }
         set{ cD_BorderDashStyle_IsChanged = value; }
      }
      private bool cD_IsValueShownAsLabel;
      private bool cD_IsValueShownAsLabel_IsChanged=false;
      public bool CD_IsValueShownAsLabel
      {
         get{ return cD_IsValueShownAsLabel; }
         set{ cD_IsValueShownAsLabel = value; cD_IsValueShownAsLabel_IsChanged=true; }
      }
      public bool CD_IsValueShownAsLabel_IsChanged
      {
         get{ return cD_IsValueShownAsLabel_IsChanged; }
         set{ cD_IsValueShownAsLabel_IsChanged = value; }
      }
      private string cD_LegendText;
      private bool cD_LegendText_IsChanged=false;
      public string CD_LegendText
      {
         get{ return cD_LegendText; }
         set{ cD_LegendText = value; cD_LegendText_IsChanged=true; }
      }
      public bool CD_LegendText_IsChanged
      {
         get{ return cD_LegendText_IsChanged; }
         set{ cD_LegendText_IsChanged = value; }
      }
      private decimal cD_MarkerSize;
      private bool cD_MarkerSize_IsChanged=false;
      public decimal CD_MarkerSize
      {
         get{ return cD_MarkerSize; }
         set{ cD_MarkerSize = value; cD_MarkerSize_IsChanged=true; }
      }
      public bool CD_MarkerSize_IsChanged
      {
         get{ return cD_MarkerSize_IsChanged; }
         set{ cD_MarkerSize_IsChanged = value; }
      }
      private string cD_MarkerColor;
      private bool cD_MarkerColor_IsChanged=false;
      public string CD_MarkerColor
      {
         get{ return cD_MarkerColor; }
         set{ cD_MarkerColor = value; cD_MarkerColor_IsChanged=true; }
      }
      public bool CD_MarkerColor_IsChanged
      {
         get{ return cD_MarkerColor_IsChanged; }
         set{ cD_MarkerColor_IsChanged = value; }
      }
      private string cD_MarkerStyle;
      private bool cD_MarkerStyle_IsChanged=false;
      public string CD_MarkerStyle
      {
         get{ return cD_MarkerStyle; }
         set{ cD_MarkerStyle = value; cD_MarkerStyle_IsChanged=true; }
      }
      public bool CD_MarkerStyle_IsChanged
      {
         get{ return cD_MarkerStyle_IsChanged; }
         set{ cD_MarkerStyle_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
