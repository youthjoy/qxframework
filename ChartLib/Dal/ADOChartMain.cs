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
   /// 图表配置主表
   /// </summary>
   [Serializable]
   public partial class ADOChartMain
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加图表配置主表 ChartMain对象(即:一条记录)
      /// </summary>
      public int Add(ChartMain chartMain)
      {
         string sql = "INSERT INTO ChartMain (CM_Module,CM_Title,CM_TitleLocation,CM_ChartAreas,CM_Legend,CM_LegendDock,CM_LegendLocation,CM_Series,CM_Width,CM_Height,CM_XLineColor,CM_XMininum,CM_XMaxinum,CM_XIntervalOffset,CM_XInterval,CM_XIntervalType,CM_XArrowStyle,CM_XTitle,CM_XTitleAlignment,CM_XMajorGrid,CM_XMajorGridLineColor,CM_YLineColor,CM_YMininum,CM_YMaxinum,CM_YIntervalOffset,CM_YInterval,CM_YIntervalType,CM_YArrowStyle,CM_YTitle,CM_YTitleAlignment,CM_YMajorGrid,CM_YMajorGridLineColor,CM_UDEF1,CM_UDEF2,CM_UDEF3,CM_UDEF4,CM_UDEF5,CM_UDEF6,CM_UDEF7,CM_UDEF8,CM_UDEF9,CM_UDEF10,Stat) VALUES (@CM_Module,@CM_Title,@CM_TitleLocation,@CM_ChartAreas,@CM_Legend,@CM_LegendDock,@CM_LegendLocation,@CM_Series,@CM_Width,@CM_Height,@CM_XLineColor,@CM_XMininum,@CM_XMaxinum,@CM_XIntervalOffset,@CM_XInterval,@CM_XIntervalType,@CM_XArrowStyle,@CM_XTitle,@CM_XTitleAlignment,@CM_XMajorGrid,@CM_XMajorGridLineColor,@CM_YLineColor,@CM_YMininum,@CM_YMaxinum,@CM_YIntervalOffset,@CM_YInterval,@CM_YIntervalType,@CM_YArrowStyle,@CM_YTitle,@CM_YTitleAlignment,@CM_YMajorGrid,@CM_YMajorGridLineColor,@CM_UDEF1,@CM_UDEF2,@CM_UDEF3,@CM_UDEF4,@CM_UDEF5,@CM_UDEF6,@CM_UDEF7,@CM_UDEF8,@CM_UDEF9,@CM_UDEF10,@Stat)";
         if (string.IsNullOrEmpty(chartMain.CM_Module))
         {
            idb.AddParameter("@CM_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Module", chartMain.CM_Module);
         }
         if (string.IsNullOrEmpty(chartMain.CM_Title))
         {
            idb.AddParameter("@CM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Title", chartMain.CM_Title);
         }
         if (string.IsNullOrEmpty(chartMain.CM_TitleLocation))
         {
            idb.AddParameter("@CM_TitleLocation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_TitleLocation", chartMain.CM_TitleLocation);
         }
         if (string.IsNullOrEmpty(chartMain.CM_ChartAreas))
         {
            idb.AddParameter("@CM_ChartAreas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_ChartAreas", chartMain.CM_ChartAreas);
         }
         if (chartMain.CM_Legend == false)
         {
            idb.AddParameter("@CM_Legend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Legend", chartMain.CM_Legend);
         }
         if (string.IsNullOrEmpty(chartMain.CM_LegendDock))
         {
            idb.AddParameter("@CM_LegendDock", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_LegendDock", chartMain.CM_LegendDock);
         }
         if (string.IsNullOrEmpty(chartMain.CM_LegendLocation))
         {
            idb.AddParameter("@CM_LegendLocation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_LegendLocation", chartMain.CM_LegendLocation);
         }
         if (string.IsNullOrEmpty(chartMain.CM_Series))
         {
            idb.AddParameter("@CM_Series", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Series", chartMain.CM_Series);
         }
         if (chartMain.CM_Width == 0)
         {
            idb.AddParameter("@CM_Width", 0);
         }
         else
         {
            idb.AddParameter("@CM_Width", chartMain.CM_Width);
         }
         if (chartMain.CM_Height == 0)
         {
            idb.AddParameter("@CM_Height", 0);
         }
         else
         {
            idb.AddParameter("@CM_Height", chartMain.CM_Height);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XLineColor))
         {
            idb.AddParameter("@CM_XLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XLineColor", chartMain.CM_XLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XMininum))
         {
            idb.AddParameter("@CM_XMininum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMininum", chartMain.CM_XMininum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XMaxinum))
         {
            idb.AddParameter("@CM_XMaxinum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMaxinum", chartMain.CM_XMaxinum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XIntervalOffset))
         {
            idb.AddParameter("@CM_XIntervalOffset", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XIntervalOffset", chartMain.CM_XIntervalOffset);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XInterval))
         {
            idb.AddParameter("@CM_XInterval", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XInterval", chartMain.CM_XInterval);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XIntervalType))
         {
            idb.AddParameter("@CM_XIntervalType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XIntervalType", chartMain.CM_XIntervalType);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XArrowStyle))
         {
            idb.AddParameter("@CM_XArrowStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XArrowStyle", chartMain.CM_XArrowStyle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XTitle))
         {
            idb.AddParameter("@CM_XTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XTitle", chartMain.CM_XTitle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XTitleAlignment))
         {
            idb.AddParameter("@CM_XTitleAlignment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XTitleAlignment", chartMain.CM_XTitleAlignment);
         }
         if (chartMain.CM_XMajorGrid == 0)
         {
            idb.AddParameter("@CM_XMajorGrid", 0);
         }
         else
         {
            idb.AddParameter("@CM_XMajorGrid", chartMain.CM_XMajorGrid);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XMajorGridLineColor))
         {
            idb.AddParameter("@CM_XMajorGridLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMajorGridLineColor", chartMain.CM_XMajorGridLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YLineColor))
         {
            idb.AddParameter("@CM_YLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YLineColor", chartMain.CM_YLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMininum))
         {
            idb.AddParameter("@CM_YMininum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMininum", chartMain.CM_YMininum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMaxinum))
         {
            idb.AddParameter("@CM_YMaxinum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMaxinum", chartMain.CM_YMaxinum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YIntervalOffset))
         {
            idb.AddParameter("@CM_YIntervalOffset", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YIntervalOffset", chartMain.CM_YIntervalOffset);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YInterval))
         {
            idb.AddParameter("@CM_YInterval", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YInterval", chartMain.CM_YInterval);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YIntervalType))
         {
            idb.AddParameter("@CM_YIntervalType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YIntervalType", chartMain.CM_YIntervalType);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YArrowStyle))
         {
            idb.AddParameter("@CM_YArrowStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YArrowStyle", chartMain.CM_YArrowStyle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YTitle))
         {
            idb.AddParameter("@CM_YTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YTitle", chartMain.CM_YTitle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YTitleAlignment))
         {
            idb.AddParameter("@CM_YTitleAlignment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YTitleAlignment", chartMain.CM_YTitleAlignment);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMajorGrid))
         {
            idb.AddParameter("@CM_YMajorGrid", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMajorGrid", chartMain.CM_YMajorGrid);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMajorGridLineColor))
         {
            idb.AddParameter("@CM_YMajorGridLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMajorGridLineColor", chartMain.CM_YMajorGridLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF1))
         {
            idb.AddParameter("@CM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF1", chartMain.CM_UDEF1);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF2))
         {
            idb.AddParameter("@CM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF2", chartMain.CM_UDEF2);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF3))
         {
            idb.AddParameter("@CM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF3", chartMain.CM_UDEF3);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF4))
         {
            idb.AddParameter("@CM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF4", chartMain.CM_UDEF4);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF5))
         {
            idb.AddParameter("@CM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF5", chartMain.CM_UDEF5);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF6))
         {
            idb.AddParameter("@CM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF6", chartMain.CM_UDEF6);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF7))
         {
            idb.AddParameter("@CM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF7", chartMain.CM_UDEF7);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF8))
         {
            idb.AddParameter("@CM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF8", chartMain.CM_UDEF8);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF9))
         {
            idb.AddParameter("@CM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF9", chartMain.CM_UDEF9);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF10))
         {
            idb.AddParameter("@CM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF10", chartMain.CM_UDEF10);
         }
         if (chartMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartMain.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加图表配置主表 ChartMain对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(ChartMain chartMain)
      {
         string sql = "INSERT INTO ChartMain (CM_Module,CM_Title,CM_TitleLocation,CM_ChartAreas,CM_Legend,CM_LegendDock,CM_LegendLocation,CM_Series,CM_Width,CM_Height,CM_XLineColor,CM_XMininum,CM_XMaxinum,CM_XIntervalOffset,CM_XInterval,CM_XIntervalType,CM_XArrowStyle,CM_XTitle,CM_XTitleAlignment,CM_XMajorGrid,CM_XMajorGridLineColor,CM_YLineColor,CM_YMininum,CM_YMaxinum,CM_YIntervalOffset,CM_YInterval,CM_YIntervalType,CM_YArrowStyle,CM_YTitle,CM_YTitleAlignment,CM_YMajorGrid,CM_YMajorGridLineColor,CM_UDEF1,CM_UDEF2,CM_UDEF3,CM_UDEF4,CM_UDEF5,CM_UDEF6,CM_UDEF7,CM_UDEF8,CM_UDEF9,CM_UDEF10,Stat) VALUES (@CM_Module,@CM_Title,@CM_TitleLocation,@CM_ChartAreas,@CM_Legend,@CM_LegendDock,@CM_LegendLocation,@CM_Series,@CM_Width,@CM_Height,@CM_XLineColor,@CM_XMininum,@CM_XMaxinum,@CM_XIntervalOffset,@CM_XInterval,@CM_XIntervalType,@CM_XArrowStyle,@CM_XTitle,@CM_XTitleAlignment,@CM_XMajorGrid,@CM_XMajorGridLineColor,@CM_YLineColor,@CM_YMininum,@CM_YMaxinum,@CM_YIntervalOffset,@CM_YInterval,@CM_YIntervalType,@CM_YArrowStyle,@CM_YTitle,@CM_YTitleAlignment,@CM_YMajorGrid,@CM_YMajorGridLineColor,@CM_UDEF1,@CM_UDEF2,@CM_UDEF3,@CM_UDEF4,@CM_UDEF5,@CM_UDEF6,@CM_UDEF7,@CM_UDEF8,@CM_UDEF9,@CM_UDEF10,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(chartMain.CM_Module))
         {
            idb.AddParameter("@CM_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Module", chartMain.CM_Module);
         }
         if (string.IsNullOrEmpty(chartMain.CM_Title))
         {
            idb.AddParameter("@CM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Title", chartMain.CM_Title);
         }
         if (string.IsNullOrEmpty(chartMain.CM_TitleLocation))
         {
            idb.AddParameter("@CM_TitleLocation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_TitleLocation", chartMain.CM_TitleLocation);
         }
         if (string.IsNullOrEmpty(chartMain.CM_ChartAreas))
         {
            idb.AddParameter("@CM_ChartAreas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_ChartAreas", chartMain.CM_ChartAreas);
         }
         if (chartMain.CM_Legend == false)
         {
            idb.AddParameter("@CM_Legend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Legend", chartMain.CM_Legend);
         }
         if (string.IsNullOrEmpty(chartMain.CM_LegendDock))
         {
            idb.AddParameter("@CM_LegendDock", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_LegendDock", chartMain.CM_LegendDock);
         }
         if (string.IsNullOrEmpty(chartMain.CM_LegendLocation))
         {
            idb.AddParameter("@CM_LegendLocation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_LegendLocation", chartMain.CM_LegendLocation);
         }
         if (string.IsNullOrEmpty(chartMain.CM_Series))
         {
            idb.AddParameter("@CM_Series", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Series", chartMain.CM_Series);
         }
         if (chartMain.CM_Width == 0)
         {
            idb.AddParameter("@CM_Width", 0);
         }
         else
         {
            idb.AddParameter("@CM_Width", chartMain.CM_Width);
         }
         if (chartMain.CM_Height == 0)
         {
            idb.AddParameter("@CM_Height", 0);
         }
         else
         {
            idb.AddParameter("@CM_Height", chartMain.CM_Height);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XLineColor))
         {
            idb.AddParameter("@CM_XLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XLineColor", chartMain.CM_XLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XMininum))
         {
            idb.AddParameter("@CM_XMininum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMininum", chartMain.CM_XMininum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XMaxinum))
         {
            idb.AddParameter("@CM_XMaxinum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMaxinum", chartMain.CM_XMaxinum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XIntervalOffset))
         {
            idb.AddParameter("@CM_XIntervalOffset", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XIntervalOffset", chartMain.CM_XIntervalOffset);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XInterval))
         {
            idb.AddParameter("@CM_XInterval", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XInterval", chartMain.CM_XInterval);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XIntervalType))
         {
            idb.AddParameter("@CM_XIntervalType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XIntervalType", chartMain.CM_XIntervalType);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XArrowStyle))
         {
            idb.AddParameter("@CM_XArrowStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XArrowStyle", chartMain.CM_XArrowStyle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XTitle))
         {
            idb.AddParameter("@CM_XTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XTitle", chartMain.CM_XTitle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XTitleAlignment))
         {
            idb.AddParameter("@CM_XTitleAlignment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XTitleAlignment", chartMain.CM_XTitleAlignment);
         }
         if (chartMain.CM_XMajorGrid == 0)
         {
            idb.AddParameter("@CM_XMajorGrid", 0);
         }
         else
         {
            idb.AddParameter("@CM_XMajorGrid", chartMain.CM_XMajorGrid);
         }
         if (string.IsNullOrEmpty(chartMain.CM_XMajorGridLineColor))
         {
            idb.AddParameter("@CM_XMajorGridLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMajorGridLineColor", chartMain.CM_XMajorGridLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YLineColor))
         {
            idb.AddParameter("@CM_YLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YLineColor", chartMain.CM_YLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMininum))
         {
            idb.AddParameter("@CM_YMininum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMininum", chartMain.CM_YMininum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMaxinum))
         {
            idb.AddParameter("@CM_YMaxinum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMaxinum", chartMain.CM_YMaxinum);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YIntervalOffset))
         {
            idb.AddParameter("@CM_YIntervalOffset", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YIntervalOffset", chartMain.CM_YIntervalOffset);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YInterval))
         {
            idb.AddParameter("@CM_YInterval", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YInterval", chartMain.CM_YInterval);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YIntervalType))
         {
            idb.AddParameter("@CM_YIntervalType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YIntervalType", chartMain.CM_YIntervalType);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YArrowStyle))
         {
            idb.AddParameter("@CM_YArrowStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YArrowStyle", chartMain.CM_YArrowStyle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YTitle))
         {
            idb.AddParameter("@CM_YTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YTitle", chartMain.CM_YTitle);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YTitleAlignment))
         {
            idb.AddParameter("@CM_YTitleAlignment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YTitleAlignment", chartMain.CM_YTitleAlignment);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMajorGrid))
         {
            idb.AddParameter("@CM_YMajorGrid", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMajorGrid", chartMain.CM_YMajorGrid);
         }
         if (string.IsNullOrEmpty(chartMain.CM_YMajorGridLineColor))
         {
            idb.AddParameter("@CM_YMajorGridLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMajorGridLineColor", chartMain.CM_YMajorGridLineColor);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF1))
         {
            idb.AddParameter("@CM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF1", chartMain.CM_UDEF1);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF2))
         {
            idb.AddParameter("@CM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF2", chartMain.CM_UDEF2);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF3))
         {
            idb.AddParameter("@CM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF3", chartMain.CM_UDEF3);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF4))
         {
            idb.AddParameter("@CM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF4", chartMain.CM_UDEF4);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF5))
         {
            idb.AddParameter("@CM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF5", chartMain.CM_UDEF5);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF6))
         {
            idb.AddParameter("@CM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF6", chartMain.CM_UDEF6);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF7))
         {
            idb.AddParameter("@CM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF7", chartMain.CM_UDEF7);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF8))
         {
            idb.AddParameter("@CM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF8", chartMain.CM_UDEF8);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF9))
         {
            idb.AddParameter("@CM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF9", chartMain.CM_UDEF9);
         }
         if (string.IsNullOrEmpty(chartMain.CM_UDEF10))
         {
            idb.AddParameter("@CM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF10", chartMain.CM_UDEF10);
         }
         if (chartMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartMain.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新图表配置主表 ChartMain对象(即:一条记录
      /// </summary>
      public int Update(ChartMain chartMain)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       ChartMain       SET ");
            if(chartMain.CM_Module_IsChanged){sbParameter.Append("CM_Module=@CM_Module, ");}
      if(chartMain.CM_Title_IsChanged){sbParameter.Append("CM_Title=@CM_Title, ");}
      if(chartMain.CM_TitleLocation_IsChanged){sbParameter.Append("CM_TitleLocation=@CM_TitleLocation, ");}
      if(chartMain.CM_ChartAreas_IsChanged){sbParameter.Append("CM_ChartAreas=@CM_ChartAreas, ");}
      if(chartMain.CM_Legend_IsChanged){sbParameter.Append("CM_Legend=@CM_Legend, ");}
      if(chartMain.CM_LegendDock_IsChanged){sbParameter.Append("CM_LegendDock=@CM_LegendDock, ");}
      if(chartMain.CM_LegendLocation_IsChanged){sbParameter.Append("CM_LegendLocation=@CM_LegendLocation, ");}
      if(chartMain.CM_Series_IsChanged){sbParameter.Append("CM_Series=@CM_Series, ");}
      if(chartMain.CM_Width_IsChanged){sbParameter.Append("CM_Width=@CM_Width, ");}
      if(chartMain.CM_Height_IsChanged){sbParameter.Append("CM_Height=@CM_Height, ");}
      if(chartMain.CM_XLineColor_IsChanged){sbParameter.Append("CM_XLineColor=@CM_XLineColor, ");}
      if(chartMain.CM_XMininum_IsChanged){sbParameter.Append("CM_XMininum=@CM_XMininum, ");}
      if(chartMain.CM_XMaxinum_IsChanged){sbParameter.Append("CM_XMaxinum=@CM_XMaxinum, ");}
      if(chartMain.CM_XIntervalOffset_IsChanged){sbParameter.Append("CM_XIntervalOffset=@CM_XIntervalOffset, ");}
      if(chartMain.CM_XInterval_IsChanged){sbParameter.Append("CM_XInterval=@CM_XInterval, ");}
      if(chartMain.CM_XIntervalType_IsChanged){sbParameter.Append("CM_XIntervalType=@CM_XIntervalType, ");}
      if(chartMain.CM_XArrowStyle_IsChanged){sbParameter.Append("CM_XArrowStyle=@CM_XArrowStyle, ");}
      if(chartMain.CM_XTitle_IsChanged){sbParameter.Append("CM_XTitle=@CM_XTitle, ");}
      if(chartMain.CM_XTitleAlignment_IsChanged){sbParameter.Append("CM_XTitleAlignment=@CM_XTitleAlignment, ");}
      if(chartMain.CM_XMajorGrid_IsChanged){sbParameter.Append("CM_XMajorGrid=@CM_XMajorGrid, ");}
      if(chartMain.CM_XMajorGridLineColor_IsChanged){sbParameter.Append("CM_XMajorGridLineColor=@CM_XMajorGridLineColor, ");}
      if(chartMain.CM_YLineColor_IsChanged){sbParameter.Append("CM_YLineColor=@CM_YLineColor, ");}
      if(chartMain.CM_YMininum_IsChanged){sbParameter.Append("CM_YMininum=@CM_YMininum, ");}
      if(chartMain.CM_YMaxinum_IsChanged){sbParameter.Append("CM_YMaxinum=@CM_YMaxinum, ");}
      if(chartMain.CM_YIntervalOffset_IsChanged){sbParameter.Append("CM_YIntervalOffset=@CM_YIntervalOffset, ");}
      if(chartMain.CM_YInterval_IsChanged){sbParameter.Append("CM_YInterval=@CM_YInterval, ");}
      if(chartMain.CM_YIntervalType_IsChanged){sbParameter.Append("CM_YIntervalType=@CM_YIntervalType, ");}
      if(chartMain.CM_YArrowStyle_IsChanged){sbParameter.Append("CM_YArrowStyle=@CM_YArrowStyle, ");}
      if(chartMain.CM_YTitle_IsChanged){sbParameter.Append("CM_YTitle=@CM_YTitle, ");}
      if(chartMain.CM_YTitleAlignment_IsChanged){sbParameter.Append("CM_YTitleAlignment=@CM_YTitleAlignment, ");}
      if(chartMain.CM_YMajorGrid_IsChanged){sbParameter.Append("CM_YMajorGrid=@CM_YMajorGrid, ");}
      if(chartMain.CM_YMajorGridLineColor_IsChanged){sbParameter.Append("CM_YMajorGridLineColor=@CM_YMajorGridLineColor, ");}
      if(chartMain.CM_UDEF1_IsChanged){sbParameter.Append("CM_UDEF1=@CM_UDEF1, ");}
      if(chartMain.CM_UDEF2_IsChanged){sbParameter.Append("CM_UDEF2=@CM_UDEF2, ");}
      if(chartMain.CM_UDEF3_IsChanged){sbParameter.Append("CM_UDEF3=@CM_UDEF3, ");}
      if(chartMain.CM_UDEF4_IsChanged){sbParameter.Append("CM_UDEF4=@CM_UDEF4, ");}
      if(chartMain.CM_UDEF5_IsChanged){sbParameter.Append("CM_UDEF5=@CM_UDEF5, ");}
      if(chartMain.CM_UDEF6_IsChanged){sbParameter.Append("CM_UDEF6=@CM_UDEF6, ");}
      if(chartMain.CM_UDEF7_IsChanged){sbParameter.Append("CM_UDEF7=@CM_UDEF7, ");}
      if(chartMain.CM_UDEF8_IsChanged){sbParameter.Append("CM_UDEF8=@CM_UDEF8, ");}
      if(chartMain.CM_UDEF9_IsChanged){sbParameter.Append("CM_UDEF9=@CM_UDEF9, ");}
      if(chartMain.CM_UDEF10_IsChanged){sbParameter.Append("CM_UDEF10=@CM_UDEF10, ");}
      if(chartMain.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CM_ID=@CM_ID; " );
      string sql=sb.ToString();
         if(chartMain.CM_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_Module))
         {
            idb.AddParameter("@CM_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Module", chartMain.CM_Module);
         }
          }
         if(chartMain.CM_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_Title))
         {
            idb.AddParameter("@CM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Title", chartMain.CM_Title);
         }
          }
         if(chartMain.CM_TitleLocation_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_TitleLocation))
         {
            idb.AddParameter("@CM_TitleLocation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_TitleLocation", chartMain.CM_TitleLocation);
         }
          }
         if(chartMain.CM_ChartAreas_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_ChartAreas))
         {
            idb.AddParameter("@CM_ChartAreas", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_ChartAreas", chartMain.CM_ChartAreas);
         }
          }
         if(chartMain.CM_Legend_IsChanged)
         {
         if (chartMain.CM_Legend == false)
         {
            idb.AddParameter("@CM_Legend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Legend", chartMain.CM_Legend);
         }
          }
         if(chartMain.CM_LegendDock_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_LegendDock))
         {
            idb.AddParameter("@CM_LegendDock", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_LegendDock", chartMain.CM_LegendDock);
         }
          }
         if(chartMain.CM_LegendLocation_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_LegendLocation))
         {
            idb.AddParameter("@CM_LegendLocation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_LegendLocation", chartMain.CM_LegendLocation);
         }
          }
         if(chartMain.CM_Series_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_Series))
         {
            idb.AddParameter("@CM_Series", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_Series", chartMain.CM_Series);
         }
          }
         if(chartMain.CM_Width_IsChanged)
         {
         if (chartMain.CM_Width == 0)
         {
            idb.AddParameter("@CM_Width", 0);
         }
         else
         {
            idb.AddParameter("@CM_Width", chartMain.CM_Width);
         }
          }
         if(chartMain.CM_Height_IsChanged)
         {
         if (chartMain.CM_Height == 0)
         {
            idb.AddParameter("@CM_Height", 0);
         }
         else
         {
            idb.AddParameter("@CM_Height", chartMain.CM_Height);
         }
          }
         if(chartMain.CM_XLineColor_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XLineColor))
         {
            idb.AddParameter("@CM_XLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XLineColor", chartMain.CM_XLineColor);
         }
          }
         if(chartMain.CM_XMininum_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XMininum))
         {
            idb.AddParameter("@CM_XMininum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMininum", chartMain.CM_XMininum);
         }
          }
         if(chartMain.CM_XMaxinum_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XMaxinum))
         {
            idb.AddParameter("@CM_XMaxinum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMaxinum", chartMain.CM_XMaxinum);
         }
          }
         if(chartMain.CM_XIntervalOffset_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XIntervalOffset))
         {
            idb.AddParameter("@CM_XIntervalOffset", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XIntervalOffset", chartMain.CM_XIntervalOffset);
         }
          }
         if(chartMain.CM_XInterval_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XInterval))
         {
            idb.AddParameter("@CM_XInterval", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XInterval", chartMain.CM_XInterval);
         }
          }
         if(chartMain.CM_XIntervalType_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XIntervalType))
         {
            idb.AddParameter("@CM_XIntervalType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XIntervalType", chartMain.CM_XIntervalType);
         }
          }
         if(chartMain.CM_XArrowStyle_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XArrowStyle))
         {
            idb.AddParameter("@CM_XArrowStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XArrowStyle", chartMain.CM_XArrowStyle);
         }
          }
         if(chartMain.CM_XTitle_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XTitle))
         {
            idb.AddParameter("@CM_XTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XTitle", chartMain.CM_XTitle);
         }
          }
         if(chartMain.CM_XTitleAlignment_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XTitleAlignment))
         {
            idb.AddParameter("@CM_XTitleAlignment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XTitleAlignment", chartMain.CM_XTitleAlignment);
         }
          }
         if(chartMain.CM_XMajorGrid_IsChanged)
         {
         if (chartMain.CM_XMajorGrid == 0)
         {
            idb.AddParameter("@CM_XMajorGrid", 0);
         }
         else
         {
            idb.AddParameter("@CM_XMajorGrid", chartMain.CM_XMajorGrid);
         }
          }
         if(chartMain.CM_XMajorGridLineColor_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_XMajorGridLineColor))
         {
            idb.AddParameter("@CM_XMajorGridLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_XMajorGridLineColor", chartMain.CM_XMajorGridLineColor);
         }
          }
         if(chartMain.CM_YLineColor_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YLineColor))
         {
            idb.AddParameter("@CM_YLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YLineColor", chartMain.CM_YLineColor);
         }
          }
         if(chartMain.CM_YMininum_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YMininum))
         {
            idb.AddParameter("@CM_YMininum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMininum", chartMain.CM_YMininum);
         }
          }
         if(chartMain.CM_YMaxinum_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YMaxinum))
         {
            idb.AddParameter("@CM_YMaxinum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMaxinum", chartMain.CM_YMaxinum);
         }
          }
         if(chartMain.CM_YIntervalOffset_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YIntervalOffset))
         {
            idb.AddParameter("@CM_YIntervalOffset", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YIntervalOffset", chartMain.CM_YIntervalOffset);
         }
          }
         if(chartMain.CM_YInterval_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YInterval))
         {
            idb.AddParameter("@CM_YInterval", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YInterval", chartMain.CM_YInterval);
         }
          }
         if(chartMain.CM_YIntervalType_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YIntervalType))
         {
            idb.AddParameter("@CM_YIntervalType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YIntervalType", chartMain.CM_YIntervalType);
         }
          }
         if(chartMain.CM_YArrowStyle_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YArrowStyle))
         {
            idb.AddParameter("@CM_YArrowStyle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YArrowStyle", chartMain.CM_YArrowStyle);
         }
          }
         if(chartMain.CM_YTitle_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YTitle))
         {
            idb.AddParameter("@CM_YTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YTitle", chartMain.CM_YTitle);
         }
          }
         if(chartMain.CM_YTitleAlignment_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YTitleAlignment))
         {
            idb.AddParameter("@CM_YTitleAlignment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YTitleAlignment", chartMain.CM_YTitleAlignment);
         }
          }
         if(chartMain.CM_YMajorGrid_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YMajorGrid))
         {
            idb.AddParameter("@CM_YMajorGrid", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMajorGrid", chartMain.CM_YMajorGrid);
         }
          }
         if(chartMain.CM_YMajorGridLineColor_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_YMajorGridLineColor))
         {
            idb.AddParameter("@CM_YMajorGridLineColor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_YMajorGridLineColor", chartMain.CM_YMajorGridLineColor);
         }
          }
         if(chartMain.CM_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF1))
         {
            idb.AddParameter("@CM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF1", chartMain.CM_UDEF1);
         }
          }
         if(chartMain.CM_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF2))
         {
            idb.AddParameter("@CM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF2", chartMain.CM_UDEF2);
         }
          }
         if(chartMain.CM_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF3))
         {
            idb.AddParameter("@CM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF3", chartMain.CM_UDEF3);
         }
          }
         if(chartMain.CM_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF4))
         {
            idb.AddParameter("@CM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF4", chartMain.CM_UDEF4);
         }
          }
         if(chartMain.CM_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF5))
         {
            idb.AddParameter("@CM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF5", chartMain.CM_UDEF5);
         }
          }
         if(chartMain.CM_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF6))
         {
            idb.AddParameter("@CM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF6", chartMain.CM_UDEF6);
         }
          }
         if(chartMain.CM_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF7))
         {
            idb.AddParameter("@CM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF7", chartMain.CM_UDEF7);
         }
          }
         if(chartMain.CM_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF8))
         {
            idb.AddParameter("@CM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF8", chartMain.CM_UDEF8);
         }
          }
         if(chartMain.CM_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF9))
         {
            idb.AddParameter("@CM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF9", chartMain.CM_UDEF9);
         }
          }
         if(chartMain.CM_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(chartMain.CM_UDEF10))
         {
            idb.AddParameter("@CM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CM_UDEF10", chartMain.CM_UDEF10);
         }
          }
         if(chartMain.Stat_IsChanged)
         {
         if (chartMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", chartMain.Stat);
         }
          }

         idb.AddParameter("@CM_ID", chartMain.CM_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除图表配置主表 ChartMain对象(即:一条记录
      /// </summary>
      public int Delete(decimal cM_ID)
      {
         string sql = "DELETE ChartMain WHERE 1=1  AND CM_ID=@CM_ID ";
         idb.AddParameter("@CM_ID", cM_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的图表配置主表 ChartMain对象(即:一条记录
      /// </summary>
      public ChartMain GetByKey(decimal cM_ID)
      {
         ChartMain chartMain = new ChartMain();
         string sql = "SELECT  CM_ID,CM_Module,CM_Title,CM_TitleLocation,CM_ChartAreas,CM_Legend,CM_LegendDock,CM_LegendLocation,CM_Series,CM_Width,CM_Height,CM_XLineColor,CM_XMininum,CM_XMaxinum,CM_XIntervalOffset,CM_XInterval,CM_XIntervalType,CM_XArrowStyle,CM_XTitle,CM_XTitleAlignment,CM_XMajorGrid,CM_XMajorGridLineColor,CM_YLineColor,CM_YMininum,CM_YMaxinum,CM_YIntervalOffset,CM_YInterval,CM_YIntervalType,CM_YArrowStyle,CM_YTitle,CM_YTitleAlignment,CM_YMajorGrid,CM_YMajorGridLineColor,CM_UDEF1,CM_UDEF2,CM_UDEF3,CM_UDEF4,CM_UDEF5,CM_UDEF6,CM_UDEF7,CM_UDEF8,CM_UDEF9,CM_UDEF10,Stat FROM ChartMain WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CM_ID=@CM_ID ";
         idb.AddParameter("@CM_ID", cM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CM_ID"] != DBNull.Value) chartMain.CM_ID = Convert.ToDecimal(dr["CM_ID"]);
            if (dr["CM_Module"] != DBNull.Value) chartMain.CM_Module = Convert.ToString(dr["CM_Module"]);
            if (dr["CM_Title"] != DBNull.Value) chartMain.CM_Title = Convert.ToString(dr["CM_Title"]);
            if (dr["CM_TitleLocation"] != DBNull.Value) chartMain.CM_TitleLocation = Convert.ToString(dr["CM_TitleLocation"]);
            if (dr["CM_ChartAreas"] != DBNull.Value) chartMain.CM_ChartAreas = Convert.ToString(dr["CM_ChartAreas"]);
            if (dr["CM_Legend"] != DBNull.Value) chartMain.CM_Legend = Convert.ToBoolean(dr["CM_Legend"]);
            if (dr["CM_LegendDock"] != DBNull.Value) chartMain.CM_LegendDock = Convert.ToString(dr["CM_LegendDock"]);
            if (dr["CM_LegendLocation"] != DBNull.Value) chartMain.CM_LegendLocation = Convert.ToString(dr["CM_LegendLocation"]);
            if (dr["CM_Series"] != DBNull.Value) chartMain.CM_Series = Convert.ToString(dr["CM_Series"]);
            if (dr["CM_Width"] != DBNull.Value) chartMain.CM_Width = Convert.ToInt32(dr["CM_Width"]);
            if (dr["CM_Height"] != DBNull.Value) chartMain.CM_Height = Convert.ToInt32(dr["CM_Height"]);
            if (dr["CM_XLineColor"] != DBNull.Value) chartMain.CM_XLineColor = Convert.ToString(dr["CM_XLineColor"]);
            if (dr["CM_XMininum"] != DBNull.Value) chartMain.CM_XMininum = Convert.ToString(dr["CM_XMininum"]);
            if (dr["CM_XMaxinum"] != DBNull.Value) chartMain.CM_XMaxinum = Convert.ToString(dr["CM_XMaxinum"]);
            if (dr["CM_XIntervalOffset"] != DBNull.Value) chartMain.CM_XIntervalOffset = Convert.ToString(dr["CM_XIntervalOffset"]);
            if (dr["CM_XInterval"] != DBNull.Value) chartMain.CM_XInterval = Convert.ToString(dr["CM_XInterval"]);
            if (dr["CM_XIntervalType"] != DBNull.Value) chartMain.CM_XIntervalType = Convert.ToString(dr["CM_XIntervalType"]);
            if (dr["CM_XArrowStyle"] != DBNull.Value) chartMain.CM_XArrowStyle = Convert.ToString(dr["CM_XArrowStyle"]);
            if (dr["CM_XTitle"] != DBNull.Value) chartMain.CM_XTitle = Convert.ToString(dr["CM_XTitle"]);
            if (dr["CM_XTitleAlignment"] != DBNull.Value) chartMain.CM_XTitleAlignment = Convert.ToString(dr["CM_XTitleAlignment"]);
            if (dr["CM_XMajorGrid"] != DBNull.Value) chartMain.CM_XMajorGrid = Convert.ToInt32(dr["CM_XMajorGrid"]);
            if (dr["CM_XMajorGridLineColor"] != DBNull.Value) chartMain.CM_XMajorGridLineColor = Convert.ToString(dr["CM_XMajorGridLineColor"]);
            if (dr["CM_YLineColor"] != DBNull.Value) chartMain.CM_YLineColor = Convert.ToString(dr["CM_YLineColor"]);
            if (dr["CM_YMininum"] != DBNull.Value) chartMain.CM_YMininum = Convert.ToString(dr["CM_YMininum"]);
            if (dr["CM_YMaxinum"] != DBNull.Value) chartMain.CM_YMaxinum = Convert.ToString(dr["CM_YMaxinum"]);
            if (dr["CM_YIntervalOffset"] != DBNull.Value) chartMain.CM_YIntervalOffset = Convert.ToString(dr["CM_YIntervalOffset"]);
            if (dr["CM_YInterval"] != DBNull.Value) chartMain.CM_YInterval = Convert.ToString(dr["CM_YInterval"]);
            if (dr["CM_YIntervalType"] != DBNull.Value) chartMain.CM_YIntervalType = Convert.ToString(dr["CM_YIntervalType"]);
            if (dr["CM_YArrowStyle"] != DBNull.Value) chartMain.CM_YArrowStyle = Convert.ToString(dr["CM_YArrowStyle"]);
            if (dr["CM_YTitle"] != DBNull.Value) chartMain.CM_YTitle = Convert.ToString(dr["CM_YTitle"]);
            if (dr["CM_YTitleAlignment"] != DBNull.Value) chartMain.CM_YTitleAlignment = Convert.ToString(dr["CM_YTitleAlignment"]);
            if (dr["CM_YMajorGrid"] != DBNull.Value) chartMain.CM_YMajorGrid = Convert.ToString(dr["CM_YMajorGrid"]);
            if (dr["CM_YMajorGridLineColor"] != DBNull.Value) chartMain.CM_YMajorGridLineColor = Convert.ToString(dr["CM_YMajorGridLineColor"]);
            if (dr["CM_UDEF1"] != DBNull.Value) chartMain.CM_UDEF1 = Convert.ToString(dr["CM_UDEF1"]);
            if (dr["CM_UDEF2"] != DBNull.Value) chartMain.CM_UDEF2 = Convert.ToString(dr["CM_UDEF2"]);
            if (dr["CM_UDEF3"] != DBNull.Value) chartMain.CM_UDEF3 = Convert.ToString(dr["CM_UDEF3"]);
            if (dr["CM_UDEF4"] != DBNull.Value) chartMain.CM_UDEF4 = Convert.ToString(dr["CM_UDEF4"]);
            if (dr["CM_UDEF5"] != DBNull.Value) chartMain.CM_UDEF5 = Convert.ToString(dr["CM_UDEF5"]);
            if (dr["CM_UDEF6"] != DBNull.Value) chartMain.CM_UDEF6 = Convert.ToString(dr["CM_UDEF6"]);
            if (dr["CM_UDEF7"] != DBNull.Value) chartMain.CM_UDEF7 = Convert.ToString(dr["CM_UDEF7"]);
            if (dr["CM_UDEF8"] != DBNull.Value) chartMain.CM_UDEF8 = Convert.ToString(dr["CM_UDEF8"]);
            if (dr["CM_UDEF9"] != DBNull.Value) chartMain.CM_UDEF9 = Convert.ToString(dr["CM_UDEF9"]);
            if (dr["CM_UDEF10"] != DBNull.Value) chartMain.CM_UDEF10 = Convert.ToString(dr["CM_UDEF10"]);
            if (dr["Stat"] != DBNull.Value) chartMain.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return chartMain;
      }
      /// <summary>
      /// 获取指定的图表配置主表 ChartMain对象集合
      /// </summary>
      public List<ChartMain> GetListByWhere(string strCondition)
      {
         List<ChartMain> ret = new List<ChartMain>();
         string sql = "SELECT  CM_ID,CM_Module,CM_Title,CM_TitleLocation,CM_ChartAreas,CM_Legend,CM_LegendDock,CM_LegendLocation,CM_Series,CM_Width,CM_Height,CM_XLineColor,CM_XMininum,CM_XMaxinum,CM_XIntervalOffset,CM_XInterval,CM_XIntervalType,CM_XArrowStyle,CM_XTitle,CM_XTitleAlignment,CM_XMajorGrid,CM_XMajorGridLineColor,CM_YLineColor,CM_YMininum,CM_YMaxinum,CM_YIntervalOffset,CM_YInterval,CM_YIntervalType,CM_YArrowStyle,CM_YTitle,CM_YTitleAlignment,CM_YMajorGrid,CM_YMajorGridLineColor,CM_UDEF1,CM_UDEF2,CM_UDEF3,CM_UDEF4,CM_UDEF5,CM_UDEF6,CM_UDEF7,CM_UDEF8,CM_UDEF9,CM_UDEF10,Stat FROM ChartMain WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY CM_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            ChartMain chartMain = new ChartMain();
            if (dr["CM_ID"] != DBNull.Value) chartMain.CM_ID = Convert.ToDecimal(dr["CM_ID"]);
            if (dr["CM_Module"] != DBNull.Value) chartMain.CM_Module = Convert.ToString(dr["CM_Module"]);
            if (dr["CM_Title"] != DBNull.Value) chartMain.CM_Title = Convert.ToString(dr["CM_Title"]);
            if (dr["CM_TitleLocation"] != DBNull.Value) chartMain.CM_TitleLocation = Convert.ToString(dr["CM_TitleLocation"]);
            if (dr["CM_ChartAreas"] != DBNull.Value) chartMain.CM_ChartAreas = Convert.ToString(dr["CM_ChartAreas"]);
            if (dr["CM_Legend"] != DBNull.Value) chartMain.CM_Legend = Convert.ToBoolean(dr["CM_Legend"]);
            if (dr["CM_LegendDock"] != DBNull.Value) chartMain.CM_LegendDock = Convert.ToString(dr["CM_LegendDock"]);
            if (dr["CM_LegendLocation"] != DBNull.Value) chartMain.CM_LegendLocation = Convert.ToString(dr["CM_LegendLocation"]);
            if (dr["CM_Series"] != DBNull.Value) chartMain.CM_Series = Convert.ToString(dr["CM_Series"]);
            if (dr["CM_Width"] != DBNull.Value) chartMain.CM_Width = Convert.ToInt32(dr["CM_Width"]);
            if (dr["CM_Height"] != DBNull.Value) chartMain.CM_Height = Convert.ToInt32(dr["CM_Height"]);
            if (dr["CM_XLineColor"] != DBNull.Value) chartMain.CM_XLineColor = Convert.ToString(dr["CM_XLineColor"]);
            if (dr["CM_XMininum"] != DBNull.Value) chartMain.CM_XMininum = Convert.ToString(dr["CM_XMininum"]);
            if (dr["CM_XMaxinum"] != DBNull.Value) chartMain.CM_XMaxinum = Convert.ToString(dr["CM_XMaxinum"]);
            if (dr["CM_XIntervalOffset"] != DBNull.Value) chartMain.CM_XIntervalOffset = Convert.ToString(dr["CM_XIntervalOffset"]);
            if (dr["CM_XInterval"] != DBNull.Value) chartMain.CM_XInterval = Convert.ToString(dr["CM_XInterval"]);
            if (dr["CM_XIntervalType"] != DBNull.Value) chartMain.CM_XIntervalType = Convert.ToString(dr["CM_XIntervalType"]);
            if (dr["CM_XArrowStyle"] != DBNull.Value) chartMain.CM_XArrowStyle = Convert.ToString(dr["CM_XArrowStyle"]);
            if (dr["CM_XTitle"] != DBNull.Value) chartMain.CM_XTitle = Convert.ToString(dr["CM_XTitle"]);
            if (dr["CM_XTitleAlignment"] != DBNull.Value) chartMain.CM_XTitleAlignment = Convert.ToString(dr["CM_XTitleAlignment"]);
            if (dr["CM_XMajorGrid"] != DBNull.Value) chartMain.CM_XMajorGrid = Convert.ToInt32(dr["CM_XMajorGrid"]);
            if (dr["CM_XMajorGridLineColor"] != DBNull.Value) chartMain.CM_XMajorGridLineColor = Convert.ToString(dr["CM_XMajorGridLineColor"]);
            if (dr["CM_YLineColor"] != DBNull.Value) chartMain.CM_YLineColor = Convert.ToString(dr["CM_YLineColor"]);
            if (dr["CM_YMininum"] != DBNull.Value) chartMain.CM_YMininum = Convert.ToString(dr["CM_YMininum"]);
            if (dr["CM_YMaxinum"] != DBNull.Value) chartMain.CM_YMaxinum = Convert.ToString(dr["CM_YMaxinum"]);
            if (dr["CM_YIntervalOffset"] != DBNull.Value) chartMain.CM_YIntervalOffset = Convert.ToString(dr["CM_YIntervalOffset"]);
            if (dr["CM_YInterval"] != DBNull.Value) chartMain.CM_YInterval = Convert.ToString(dr["CM_YInterval"]);
            if (dr["CM_YIntervalType"] != DBNull.Value) chartMain.CM_YIntervalType = Convert.ToString(dr["CM_YIntervalType"]);
            if (dr["CM_YArrowStyle"] != DBNull.Value) chartMain.CM_YArrowStyle = Convert.ToString(dr["CM_YArrowStyle"]);
            if (dr["CM_YTitle"] != DBNull.Value) chartMain.CM_YTitle = Convert.ToString(dr["CM_YTitle"]);
            if (dr["CM_YTitleAlignment"] != DBNull.Value) chartMain.CM_YTitleAlignment = Convert.ToString(dr["CM_YTitleAlignment"]);
            if (dr["CM_YMajorGrid"] != DBNull.Value) chartMain.CM_YMajorGrid = Convert.ToString(dr["CM_YMajorGrid"]);
            if (dr["CM_YMajorGridLineColor"] != DBNull.Value) chartMain.CM_YMajorGridLineColor = Convert.ToString(dr["CM_YMajorGridLineColor"]);
            if (dr["CM_UDEF1"] != DBNull.Value) chartMain.CM_UDEF1 = Convert.ToString(dr["CM_UDEF1"]);
            if (dr["CM_UDEF2"] != DBNull.Value) chartMain.CM_UDEF2 = Convert.ToString(dr["CM_UDEF2"]);
            if (dr["CM_UDEF3"] != DBNull.Value) chartMain.CM_UDEF3 = Convert.ToString(dr["CM_UDEF3"]);
            if (dr["CM_UDEF4"] != DBNull.Value) chartMain.CM_UDEF4 = Convert.ToString(dr["CM_UDEF4"]);
            if (dr["CM_UDEF5"] != DBNull.Value) chartMain.CM_UDEF5 = Convert.ToString(dr["CM_UDEF5"]);
            if (dr["CM_UDEF6"] != DBNull.Value) chartMain.CM_UDEF6 = Convert.ToString(dr["CM_UDEF6"]);
            if (dr["CM_UDEF7"] != DBNull.Value) chartMain.CM_UDEF7 = Convert.ToString(dr["CM_UDEF7"]);
            if (dr["CM_UDEF8"] != DBNull.Value) chartMain.CM_UDEF8 = Convert.ToString(dr["CM_UDEF8"]);
            if (dr["CM_UDEF9"] != DBNull.Value) chartMain.CM_UDEF9 = Convert.ToString(dr["CM_UDEF9"]);
            if (dr["CM_UDEF10"] != DBNull.Value) chartMain.CM_UDEF10 = Convert.ToString(dr["CM_UDEF10"]);
            if (dr["Stat"] != DBNull.Value) chartMain.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(chartMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的图表配置主表 ChartMain对象(即:一条记录
      /// </summary>
      public List<ChartMain> GetAll()
      {
         List<ChartMain> ret = new List<ChartMain>();
         string sql = "SELECT  CM_ID,CM_Module,CM_Title,CM_TitleLocation,CM_ChartAreas,CM_Legend,CM_LegendDock,CM_LegendLocation,CM_Series,CM_Width,CM_Height,CM_XLineColor,CM_XMininum,CM_XMaxinum,CM_XIntervalOffset,CM_XInterval,CM_XIntervalType,CM_XArrowStyle,CM_XTitle,CM_XTitleAlignment,CM_XMajorGrid,CM_XMajorGridLineColor,CM_YLineColor,CM_YMininum,CM_YMaxinum,CM_YIntervalOffset,CM_YInterval,CM_YIntervalType,CM_YArrowStyle,CM_YTitle,CM_YTitleAlignment,CM_YMajorGrid,CM_YMajorGridLineColor,CM_UDEF1,CM_UDEF2,CM_UDEF3,CM_UDEF4,CM_UDEF5,CM_UDEF6,CM_UDEF7,CM_UDEF8,CM_UDEF9,CM_UDEF10,Stat FROM ChartMain where 1=1 AND ((Stat is null) or (Stat=0) ) order by CM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            ChartMain chartMain = new ChartMain();
            if (dr["CM_ID"] != DBNull.Value) chartMain.CM_ID = Convert.ToDecimal(dr["CM_ID"]);
            if (dr["CM_Module"] != DBNull.Value) chartMain.CM_Module = Convert.ToString(dr["CM_Module"]);
            if (dr["CM_Title"] != DBNull.Value) chartMain.CM_Title = Convert.ToString(dr["CM_Title"]);
            if (dr["CM_TitleLocation"] != DBNull.Value) chartMain.CM_TitleLocation = Convert.ToString(dr["CM_TitleLocation"]);
            if (dr["CM_ChartAreas"] != DBNull.Value) chartMain.CM_ChartAreas = Convert.ToString(dr["CM_ChartAreas"]);
            if (dr["CM_Legend"] != DBNull.Value) chartMain.CM_Legend = Convert.ToBoolean(dr["CM_Legend"]);
            if (dr["CM_LegendDock"] != DBNull.Value) chartMain.CM_LegendDock = Convert.ToString(dr["CM_LegendDock"]);
            if (dr["CM_LegendLocation"] != DBNull.Value) chartMain.CM_LegendLocation = Convert.ToString(dr["CM_LegendLocation"]);
            if (dr["CM_Series"] != DBNull.Value) chartMain.CM_Series = Convert.ToString(dr["CM_Series"]);
            if (dr["CM_Width"] != DBNull.Value) chartMain.CM_Width = Convert.ToInt32(dr["CM_Width"]);
            if (dr["CM_Height"] != DBNull.Value) chartMain.CM_Height = Convert.ToInt32(dr["CM_Height"]);
            if (dr["CM_XLineColor"] != DBNull.Value) chartMain.CM_XLineColor = Convert.ToString(dr["CM_XLineColor"]);
            if (dr["CM_XMininum"] != DBNull.Value) chartMain.CM_XMininum = Convert.ToString(dr["CM_XMininum"]);
            if (dr["CM_XMaxinum"] != DBNull.Value) chartMain.CM_XMaxinum = Convert.ToString(dr["CM_XMaxinum"]);
            if (dr["CM_XIntervalOffset"] != DBNull.Value) chartMain.CM_XIntervalOffset = Convert.ToString(dr["CM_XIntervalOffset"]);
            if (dr["CM_XInterval"] != DBNull.Value) chartMain.CM_XInterval = Convert.ToString(dr["CM_XInterval"]);
            if (dr["CM_XIntervalType"] != DBNull.Value) chartMain.CM_XIntervalType = Convert.ToString(dr["CM_XIntervalType"]);
            if (dr["CM_XArrowStyle"] != DBNull.Value) chartMain.CM_XArrowStyle = Convert.ToString(dr["CM_XArrowStyle"]);
            if (dr["CM_XTitle"] != DBNull.Value) chartMain.CM_XTitle = Convert.ToString(dr["CM_XTitle"]);
            if (dr["CM_XTitleAlignment"] != DBNull.Value) chartMain.CM_XTitleAlignment = Convert.ToString(dr["CM_XTitleAlignment"]);
            if (dr["CM_XMajorGrid"] != DBNull.Value) chartMain.CM_XMajorGrid = Convert.ToInt32(dr["CM_XMajorGrid"]);
            if (dr["CM_XMajorGridLineColor"] != DBNull.Value) chartMain.CM_XMajorGridLineColor = Convert.ToString(dr["CM_XMajorGridLineColor"]);
            if (dr["CM_YLineColor"] != DBNull.Value) chartMain.CM_YLineColor = Convert.ToString(dr["CM_YLineColor"]);
            if (dr["CM_YMininum"] != DBNull.Value) chartMain.CM_YMininum = Convert.ToString(dr["CM_YMininum"]);
            if (dr["CM_YMaxinum"] != DBNull.Value) chartMain.CM_YMaxinum = Convert.ToString(dr["CM_YMaxinum"]);
            if (dr["CM_YIntervalOffset"] != DBNull.Value) chartMain.CM_YIntervalOffset = Convert.ToString(dr["CM_YIntervalOffset"]);
            if (dr["CM_YInterval"] != DBNull.Value) chartMain.CM_YInterval = Convert.ToString(dr["CM_YInterval"]);
            if (dr["CM_YIntervalType"] != DBNull.Value) chartMain.CM_YIntervalType = Convert.ToString(dr["CM_YIntervalType"]);
            if (dr["CM_YArrowStyle"] != DBNull.Value) chartMain.CM_YArrowStyle = Convert.ToString(dr["CM_YArrowStyle"]);
            if (dr["CM_YTitle"] != DBNull.Value) chartMain.CM_YTitle = Convert.ToString(dr["CM_YTitle"]);
            if (dr["CM_YTitleAlignment"] != DBNull.Value) chartMain.CM_YTitleAlignment = Convert.ToString(dr["CM_YTitleAlignment"]);
            if (dr["CM_YMajorGrid"] != DBNull.Value) chartMain.CM_YMajorGrid = Convert.ToString(dr["CM_YMajorGrid"]);
            if (dr["CM_YMajorGridLineColor"] != DBNull.Value) chartMain.CM_YMajorGridLineColor = Convert.ToString(dr["CM_YMajorGridLineColor"]);
            if (dr["CM_UDEF1"] != DBNull.Value) chartMain.CM_UDEF1 = Convert.ToString(dr["CM_UDEF1"]);
            if (dr["CM_UDEF2"] != DBNull.Value) chartMain.CM_UDEF2 = Convert.ToString(dr["CM_UDEF2"]);
            if (dr["CM_UDEF3"] != DBNull.Value) chartMain.CM_UDEF3 = Convert.ToString(dr["CM_UDEF3"]);
            if (dr["CM_UDEF4"] != DBNull.Value) chartMain.CM_UDEF4 = Convert.ToString(dr["CM_UDEF4"]);
            if (dr["CM_UDEF5"] != DBNull.Value) chartMain.CM_UDEF5 = Convert.ToString(dr["CM_UDEF5"]);
            if (dr["CM_UDEF6"] != DBNull.Value) chartMain.CM_UDEF6 = Convert.ToString(dr["CM_UDEF6"]);
            if (dr["CM_UDEF7"] != DBNull.Value) chartMain.CM_UDEF7 = Convert.ToString(dr["CM_UDEF7"]);
            if (dr["CM_UDEF8"] != DBNull.Value) chartMain.CM_UDEF8 = Convert.ToString(dr["CM_UDEF8"]);
            if (dr["CM_UDEF9"] != DBNull.Value) chartMain.CM_UDEF9 = Convert.ToString(dr["CM_UDEF9"]);
            if (dr["CM_UDEF10"] != DBNull.Value) chartMain.CM_UDEF10 = Convert.ToString(dr["CM_UDEF10"]);
            if (dr["Stat"] != DBNull.Value) chartMain.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(chartMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
