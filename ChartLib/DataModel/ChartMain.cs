using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.ChartLib.Model
{
   /// <summary>
   /// 图表配置主表
   /// </summary>
   [Serializable]
   public partial class ChartMain
   {
      private decimal cM_ID;
      private bool cM_ID_IsChanged=false;
      public decimal CM_ID
      {
         get{ return cM_ID; }
         set{ cM_ID = value; cM_ID_IsChanged=true; }
      }
      public bool CM_ID_IsChanged
      {
         get{ return cM_ID_IsChanged; }
         set{ cM_ID_IsChanged = value; }
      }
      private string cM_Module;
      private bool cM_Module_IsChanged=false;
      public string CM_Module
      {
         get{ return cM_Module; }
         set{ cM_Module = value; cM_Module_IsChanged=true; }
      }
      public bool CM_Module_IsChanged
      {
         get{ return cM_Module_IsChanged; }
         set{ cM_Module_IsChanged = value; }
      }
      private string cM_Title;
      private bool cM_Title_IsChanged=false;
      public string CM_Title
      {
         get{ return cM_Title; }
         set{ cM_Title = value; cM_Title_IsChanged=true; }
      }
      public bool CM_Title_IsChanged
      {
         get{ return cM_Title_IsChanged; }
         set{ cM_Title_IsChanged = value; }
      }
      private string cM_TitleLocation;
      private bool cM_TitleLocation_IsChanged=false;
      public string CM_TitleLocation
      {
         get{ return cM_TitleLocation; }
         set{ cM_TitleLocation = value; cM_TitleLocation_IsChanged=true; }
      }
      public bool CM_TitleLocation_IsChanged
      {
         get{ return cM_TitleLocation_IsChanged; }
         set{ cM_TitleLocation_IsChanged = value; }
      }
      private string cM_ChartAreas;
      private bool cM_ChartAreas_IsChanged=false;
      public string CM_ChartAreas
      {
         get{ return cM_ChartAreas; }
         set{ cM_ChartAreas = value; cM_ChartAreas_IsChanged=true; }
      }
      public bool CM_ChartAreas_IsChanged
      {
         get{ return cM_ChartAreas_IsChanged; }
         set{ cM_ChartAreas_IsChanged = value; }
      }
      private bool cM_Legend;
      private bool cM_Legend_IsChanged=false;
      public bool CM_Legend
      {
         get{ return cM_Legend; }
         set{ cM_Legend = value; cM_Legend_IsChanged=true; }
      }
      public bool CM_Legend_IsChanged
      {
         get{ return cM_Legend_IsChanged; }
         set{ cM_Legend_IsChanged = value; }
      }
      private string cM_LegendDock;
      private bool cM_LegendDock_IsChanged=false;
      public string CM_LegendDock
      {
         get{ return cM_LegendDock; }
         set{ cM_LegendDock = value; cM_LegendDock_IsChanged=true; }
      }
      public bool CM_LegendDock_IsChanged
      {
         get{ return cM_LegendDock_IsChanged; }
         set{ cM_LegendDock_IsChanged = value; }
      }
      private string cM_LegendLocation;
      private bool cM_LegendLocation_IsChanged=false;
      public string CM_LegendLocation
      {
         get{ return cM_LegendLocation; }
         set{ cM_LegendLocation = value; cM_LegendLocation_IsChanged=true; }
      }
      public bool CM_LegendLocation_IsChanged
      {
         get{ return cM_LegendLocation_IsChanged; }
         set{ cM_LegendLocation_IsChanged = value; }
      }
      private string cM_Series;
      private bool cM_Series_IsChanged=false;
      public string CM_Series
      {
         get{ return cM_Series; }
         set{ cM_Series = value; cM_Series_IsChanged=true; }
      }
      public bool CM_Series_IsChanged
      {
         get{ return cM_Series_IsChanged; }
         set{ cM_Series_IsChanged = value; }
      }
      private int cM_Width;
      private bool cM_Width_IsChanged=false;
      public int CM_Width
      {
         get{ return cM_Width; }
         set{ cM_Width = value; cM_Width_IsChanged=true; }
      }
      public bool CM_Width_IsChanged
      {
         get{ return cM_Width_IsChanged; }
         set{ cM_Width_IsChanged = value; }
      }
      private int cM_Height;
      private bool cM_Height_IsChanged=false;
      public int CM_Height
      {
         get{ return cM_Height; }
         set{ cM_Height = value; cM_Height_IsChanged=true; }
      }
      public bool CM_Height_IsChanged
      {
         get{ return cM_Height_IsChanged; }
         set{ cM_Height_IsChanged = value; }
      }
      private string cM_XLineColor;
      private bool cM_XLineColor_IsChanged=false;
      public string CM_XLineColor
      {
         get{ return cM_XLineColor; }
         set{ cM_XLineColor = value; cM_XLineColor_IsChanged=true; }
      }
      public bool CM_XLineColor_IsChanged
      {
         get{ return cM_XLineColor_IsChanged; }
         set{ cM_XLineColor_IsChanged = value; }
      }
      private string cM_XMininum;
      private bool cM_XMininum_IsChanged=false;
      public string CM_XMininum
      {
         get{ return cM_XMininum; }
         set{ cM_XMininum = value; cM_XMininum_IsChanged=true; }
      }
      public bool CM_XMininum_IsChanged
      {
         get{ return cM_XMininum_IsChanged; }
         set{ cM_XMininum_IsChanged = value; }
      }
      private string cM_XMaxinum;
      private bool cM_XMaxinum_IsChanged=false;
      public string CM_XMaxinum
      {
         get{ return cM_XMaxinum; }
         set{ cM_XMaxinum = value; cM_XMaxinum_IsChanged=true; }
      }
      public bool CM_XMaxinum_IsChanged
      {
         get{ return cM_XMaxinum_IsChanged; }
         set{ cM_XMaxinum_IsChanged = value; }
      }
      private string cM_XIntervalOffset;
      private bool cM_XIntervalOffset_IsChanged=false;
      public string CM_XIntervalOffset
      {
         get{ return cM_XIntervalOffset; }
         set{ cM_XIntervalOffset = value; cM_XIntervalOffset_IsChanged=true; }
      }
      public bool CM_XIntervalOffset_IsChanged
      {
         get{ return cM_XIntervalOffset_IsChanged; }
         set{ cM_XIntervalOffset_IsChanged = value; }
      }
      private string cM_XInterval;
      private bool cM_XInterval_IsChanged=false;
      public string CM_XInterval
      {
         get{ return cM_XInterval; }
         set{ cM_XInterval = value; cM_XInterval_IsChanged=true; }
      }
      public bool CM_XInterval_IsChanged
      {
         get{ return cM_XInterval_IsChanged; }
         set{ cM_XInterval_IsChanged = value; }
      }
      private string cM_XIntervalType;
      private bool cM_XIntervalType_IsChanged=false;
      public string CM_XIntervalType
      {
         get{ return cM_XIntervalType; }
         set{ cM_XIntervalType = value; cM_XIntervalType_IsChanged=true; }
      }
      public bool CM_XIntervalType_IsChanged
      {
         get{ return cM_XIntervalType_IsChanged; }
         set{ cM_XIntervalType_IsChanged = value; }
      }
      private string cM_XArrowStyle;
      private bool cM_XArrowStyle_IsChanged=false;
      public string CM_XArrowStyle
      {
         get{ return cM_XArrowStyle; }
         set{ cM_XArrowStyle = value; cM_XArrowStyle_IsChanged=true; }
      }
      public bool CM_XArrowStyle_IsChanged
      {
         get{ return cM_XArrowStyle_IsChanged; }
         set{ cM_XArrowStyle_IsChanged = value; }
      }
      private string cM_XTitle;
      private bool cM_XTitle_IsChanged=false;
      public string CM_XTitle
      {
         get{ return cM_XTitle; }
         set{ cM_XTitle = value; cM_XTitle_IsChanged=true; }
      }
      public bool CM_XTitle_IsChanged
      {
         get{ return cM_XTitle_IsChanged; }
         set{ cM_XTitle_IsChanged = value; }
      }
      private string cM_XTitleAlignment;
      private bool cM_XTitleAlignment_IsChanged=false;
      public string CM_XTitleAlignment
      {
         get{ return cM_XTitleAlignment; }
         set{ cM_XTitleAlignment = value; cM_XTitleAlignment_IsChanged=true; }
      }
      public bool CM_XTitleAlignment_IsChanged
      {
         get{ return cM_XTitleAlignment_IsChanged; }
         set{ cM_XTitleAlignment_IsChanged = value; }
      }
      private int cM_XMajorGrid;
      private bool cM_XMajorGrid_IsChanged=false;
      public int CM_XMajorGrid
      {
         get{ return cM_XMajorGrid; }
         set{ cM_XMajorGrid = value; cM_XMajorGrid_IsChanged=true; }
      }
      public bool CM_XMajorGrid_IsChanged
      {
         get{ return cM_XMajorGrid_IsChanged; }
         set{ cM_XMajorGrid_IsChanged = value; }
      }
      private string cM_XMajorGridLineColor;
      private bool cM_XMajorGridLineColor_IsChanged=false;
      public string CM_XMajorGridLineColor
      {
         get{ return cM_XMajorGridLineColor; }
         set{ cM_XMajorGridLineColor = value; cM_XMajorGridLineColor_IsChanged=true; }
      }
      public bool CM_XMajorGridLineColor_IsChanged
      {
         get{ return cM_XMajorGridLineColor_IsChanged; }
         set{ cM_XMajorGridLineColor_IsChanged = value; }
      }
      private string cM_YLineColor;
      private bool cM_YLineColor_IsChanged=false;
      public string CM_YLineColor
      {
         get{ return cM_YLineColor; }
         set{ cM_YLineColor = value; cM_YLineColor_IsChanged=true; }
      }
      public bool CM_YLineColor_IsChanged
      {
         get{ return cM_YLineColor_IsChanged; }
         set{ cM_YLineColor_IsChanged = value; }
      }
      private string cM_YMininum;
      private bool cM_YMininum_IsChanged=false;
      public string CM_YMininum
      {
         get{ return cM_YMininum; }
         set{ cM_YMininum = value; cM_YMininum_IsChanged=true; }
      }
      public bool CM_YMininum_IsChanged
      {
         get{ return cM_YMininum_IsChanged; }
         set{ cM_YMininum_IsChanged = value; }
      }
      private string cM_YMaxinum;
      private bool cM_YMaxinum_IsChanged=false;
      public string CM_YMaxinum
      {
         get{ return cM_YMaxinum; }
         set{ cM_YMaxinum = value; cM_YMaxinum_IsChanged=true; }
      }
      public bool CM_YMaxinum_IsChanged
      {
         get{ return cM_YMaxinum_IsChanged; }
         set{ cM_YMaxinum_IsChanged = value; }
      }
      private string cM_YIntervalOffset;
      private bool cM_YIntervalOffset_IsChanged=false;
      public string CM_YIntervalOffset
      {
         get{ return cM_YIntervalOffset; }
         set{ cM_YIntervalOffset = value; cM_YIntervalOffset_IsChanged=true; }
      }
      public bool CM_YIntervalOffset_IsChanged
      {
         get{ return cM_YIntervalOffset_IsChanged; }
         set{ cM_YIntervalOffset_IsChanged = value; }
      }
      private string cM_YInterval;
      private bool cM_YInterval_IsChanged=false;
      public string CM_YInterval
      {
         get{ return cM_YInterval; }
         set{ cM_YInterval = value; cM_YInterval_IsChanged=true; }
      }
      public bool CM_YInterval_IsChanged
      {
         get{ return cM_YInterval_IsChanged; }
         set{ cM_YInterval_IsChanged = value; }
      }
      private string cM_YIntervalType;
      private bool cM_YIntervalType_IsChanged=false;
      public string CM_YIntervalType
      {
         get{ return cM_YIntervalType; }
         set{ cM_YIntervalType = value; cM_YIntervalType_IsChanged=true; }
      }
      public bool CM_YIntervalType_IsChanged
      {
         get{ return cM_YIntervalType_IsChanged; }
         set{ cM_YIntervalType_IsChanged = value; }
      }
      private string cM_YArrowStyle;
      private bool cM_YArrowStyle_IsChanged=false;
      public string CM_YArrowStyle
      {
         get{ return cM_YArrowStyle; }
         set{ cM_YArrowStyle = value; cM_YArrowStyle_IsChanged=true; }
      }
      public bool CM_YArrowStyle_IsChanged
      {
         get{ return cM_YArrowStyle_IsChanged; }
         set{ cM_YArrowStyle_IsChanged = value; }
      }
      private string cM_YTitle;
      private bool cM_YTitle_IsChanged=false;
      public string CM_YTitle
      {
         get{ return cM_YTitle; }
         set{ cM_YTitle = value; cM_YTitle_IsChanged=true; }
      }
      public bool CM_YTitle_IsChanged
      {
         get{ return cM_YTitle_IsChanged; }
         set{ cM_YTitle_IsChanged = value; }
      }
      private string cM_YTitleAlignment;
      private bool cM_YTitleAlignment_IsChanged=false;
      public string CM_YTitleAlignment
      {
         get{ return cM_YTitleAlignment; }
         set{ cM_YTitleAlignment = value; cM_YTitleAlignment_IsChanged=true; }
      }
      public bool CM_YTitleAlignment_IsChanged
      {
         get{ return cM_YTitleAlignment_IsChanged; }
         set{ cM_YTitleAlignment_IsChanged = value; }
      }
      private string cM_YMajorGrid;
      private bool cM_YMajorGrid_IsChanged=false;
      public string CM_YMajorGrid
      {
         get{ return cM_YMajorGrid; }
         set{ cM_YMajorGrid = value; cM_YMajorGrid_IsChanged=true; }
      }
      public bool CM_YMajorGrid_IsChanged
      {
         get{ return cM_YMajorGrid_IsChanged; }
         set{ cM_YMajorGrid_IsChanged = value; }
      }
      private string cM_YMajorGridLineColor;
      private bool cM_YMajorGridLineColor_IsChanged=false;
      public string CM_YMajorGridLineColor
      {
         get{ return cM_YMajorGridLineColor; }
         set{ cM_YMajorGridLineColor = value; cM_YMajorGridLineColor_IsChanged=true; }
      }
      public bool CM_YMajorGridLineColor_IsChanged
      {
         get{ return cM_YMajorGridLineColor_IsChanged; }
         set{ cM_YMajorGridLineColor_IsChanged = value; }
      }
      private string cM_UDEF1;
      private bool cM_UDEF1_IsChanged=false;
      public string CM_UDEF1
      {
         get{ return cM_UDEF1; }
         set{ cM_UDEF1 = value; cM_UDEF1_IsChanged=true; }
      }
      public bool CM_UDEF1_IsChanged
      {
         get{ return cM_UDEF1_IsChanged; }
         set{ cM_UDEF1_IsChanged = value; }
      }
      private string cM_UDEF2;
      private bool cM_UDEF2_IsChanged=false;
      public string CM_UDEF2
      {
         get{ return cM_UDEF2; }
         set{ cM_UDEF2 = value; cM_UDEF2_IsChanged=true; }
      }
      public bool CM_UDEF2_IsChanged
      {
         get{ return cM_UDEF2_IsChanged; }
         set{ cM_UDEF2_IsChanged = value; }
      }
      private string cM_UDEF3;
      private bool cM_UDEF3_IsChanged=false;
      public string CM_UDEF3
      {
         get{ return cM_UDEF3; }
         set{ cM_UDEF3 = value; cM_UDEF3_IsChanged=true; }
      }
      public bool CM_UDEF3_IsChanged
      {
         get{ return cM_UDEF3_IsChanged; }
         set{ cM_UDEF3_IsChanged = value; }
      }
      private string cM_UDEF4;
      private bool cM_UDEF4_IsChanged=false;
      public string CM_UDEF4
      {
         get{ return cM_UDEF4; }
         set{ cM_UDEF4 = value; cM_UDEF4_IsChanged=true; }
      }
      public bool CM_UDEF4_IsChanged
      {
         get{ return cM_UDEF4_IsChanged; }
         set{ cM_UDEF4_IsChanged = value; }
      }
      private string cM_UDEF5;
      private bool cM_UDEF5_IsChanged=false;
      public string CM_UDEF5
      {
         get{ return cM_UDEF5; }
         set{ cM_UDEF5 = value; cM_UDEF5_IsChanged=true; }
      }
      public bool CM_UDEF5_IsChanged
      {
         get{ return cM_UDEF5_IsChanged; }
         set{ cM_UDEF5_IsChanged = value; }
      }
      private string cM_UDEF6;
      private bool cM_UDEF6_IsChanged=false;
      public string CM_UDEF6
      {
         get{ return cM_UDEF6; }
         set{ cM_UDEF6 = value; cM_UDEF6_IsChanged=true; }
      }
      public bool CM_UDEF6_IsChanged
      {
         get{ return cM_UDEF6_IsChanged; }
         set{ cM_UDEF6_IsChanged = value; }
      }
      private string cM_UDEF7;
      private bool cM_UDEF7_IsChanged=false;
      public string CM_UDEF7
      {
         get{ return cM_UDEF7; }
         set{ cM_UDEF7 = value; cM_UDEF7_IsChanged=true; }
      }
      public bool CM_UDEF7_IsChanged
      {
         get{ return cM_UDEF7_IsChanged; }
         set{ cM_UDEF7_IsChanged = value; }
      }
      private string cM_UDEF8;
      private bool cM_UDEF8_IsChanged=false;
      public string CM_UDEF8
      {
         get{ return cM_UDEF8; }
         set{ cM_UDEF8 = value; cM_UDEF8_IsChanged=true; }
      }
      public bool CM_UDEF8_IsChanged
      {
         get{ return cM_UDEF8_IsChanged; }
         set{ cM_UDEF8_IsChanged = value; }
      }
      private string cM_UDEF9;
      private bool cM_UDEF9_IsChanged=false;
      public string CM_UDEF9
      {
         get{ return cM_UDEF9; }
         set{ cM_UDEF9 = value; cM_UDEF9_IsChanged=true; }
      }
      public bool CM_UDEF9_IsChanged
      {
         get{ return cM_UDEF9_IsChanged; }
         set{ cM_UDEF9_IsChanged = value; }
      }
      private string cM_UDEF10;
      private bool cM_UDEF10_IsChanged=false;
      public string CM_UDEF10
      {
         get{ return cM_UDEF10; }
         set{ cM_UDEF10 = value; cM_UDEF10_IsChanged=true; }
      }
      public bool CM_UDEF10_IsChanged
      {
         get{ return cM_UDEF10_IsChanged; }
         set{ cM_UDEF10_IsChanged = value; }
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
