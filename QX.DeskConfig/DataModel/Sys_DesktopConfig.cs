using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DeskConfig.Model
{
   /// <summary>
   /// 桌面配置
   /// </summary>
   [Serializable]
   public partial class Sys_DesktopConfig
   {
      private decimal sC_ID;
      private bool sC_ID_IsChanged=false;
      public decimal SC_ID
      {
         get{ return sC_ID; }
         set{ sC_ID = value; sC_ID_IsChanged=true; }
      }
      public bool SC_ID_IsChanged
      {
         get{ return sC_ID_IsChanged; }
         set{ sC_ID_IsChanged = value; }
      }
      /// <summary>
      /// 桌面区域标识
      /// </summary>
      private string sC_AreaCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sC_AreaCode_IsChanged=false;
      /// <summary>
      /// 桌面区域标识
      /// </summary>
      public string SC_AreaCode
      {
         get{ return sC_AreaCode; }
         set{ sC_AreaCode = value; sC_AreaCode_IsChanged=true; }
      }
      /// <summary>
      /// 桌面区域标识
      /// </summary>
      public bool SC_AreaCode_IsChanged
      {
         get{ return sC_AreaCode_IsChanged; }
         set{ sC_AreaCode_IsChanged = value; }
      }
      private string sC_AreaName;
      private bool sC_AreaName_IsChanged=false;
      public string SC_AreaName
      {
         get{ return sC_AreaName; }
         set{ sC_AreaName = value; sC_AreaName_IsChanged=true; }
      }
      public bool SC_AreaName_IsChanged
      {
         get{ return sC_AreaName_IsChanged; }
         set{ sC_AreaName_IsChanged = value; }
      }
      private string sC_AreaPCode;
      private bool sC_AreaPCode_IsChanged=false;
      public string SC_AreaPCode
      {
         get{ return sC_AreaPCode; }
         set{ sC_AreaPCode = value; sC_AreaPCode_IsChanged=true; }
      }
      public bool SC_AreaPCode_IsChanged
      {
         get{ return sC_AreaPCode_IsChanged; }
         set{ sC_AreaPCode_IsChanged = value; }
      }
      private string sC_AreaPName;
      private bool sC_AreaPName_IsChanged=false;
      public string SC_AreaPName
      {
         get{ return sC_AreaPName; }
         set{ sC_AreaPName = value; sC_AreaPName_IsChanged=true; }
      }
      public bool SC_AreaPName_IsChanged
      {
         get{ return sC_AreaPName_IsChanged; }
         set{ sC_AreaPName_IsChanged = value; }
      }
      private string sC_SQL;
      private bool sC_SQL_IsChanged=false;
      public string SC_SQL
      {
         get{ return sC_SQL; }
         set{ sC_SQL = value; sC_SQL_IsChanged=true; }
      }
      public bool SC_SQL_IsChanged
      {
         get{ return sC_SQL_IsChanged; }
         set{ sC_SQL_IsChanged = value; }
      }
      /// <summary>
      /// 循环的内容
      /// </summary>
      private string sC_Loop;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sC_Loop_IsChanged=false;
      /// <summary>
      /// 循环的内容
      /// </summary>
      public string SC_Loop
      {
         get{ return sC_Loop; }
         set{ sC_Loop = value; sC_Loop_IsChanged=true; }
      }
      /// <summary>
      /// 循环的内容
      /// </summary>
      public bool SC_Loop_IsChanged
      {
         get{ return sC_Loop_IsChanged; }
         set{ sC_Loop_IsChanged = value; }
      }
      private string sC_URL;
      private bool sC_URL_IsChanged=false;
      public string SC_URL
      {
         get{ return sC_URL; }
         set{ sC_URL = value; sC_URL_IsChanged=true; }
      }
      public bool SC_URL_IsChanged
      {
         get{ return sC_URL_IsChanged; }
         set{ sC_URL_IsChanged = value; }
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
      private int sC_Order;
      private bool sC_Order_IsChanged=false;
      public int SC_Order
      {
         get{ return sC_Order; }
         set{ sC_Order = value; sC_Order_IsChanged=true; }
      }
      public bool SC_Order_IsChanged
      {
         get{ return sC_Order_IsChanged; }
         set{ sC_Order_IsChanged = value; }
      }
      /// <summary>
      /// 分组
      /// </summary>
      private string sC_Group;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sC_Group_IsChanged=false;
      /// <summary>
      /// 分组
      /// </summary>
      public string SC_Group
      {
         get{ return sC_Group; }
         set{ sC_Group = value; sC_Group_IsChanged=true; }
      }
      /// <summary>
      /// 分组
      /// </summary>
      public bool SC_Group_IsChanged
      {
         get{ return sC_Group_IsChanged; }
         set{ sC_Group_IsChanged = value; }
      }
      private string sC_Filter;
      private bool sC_Filter_IsChanged=false;
      public string SC_Filter
      {
         get{ return sC_Filter; }
         set{ sC_Filter = value; sC_Filter_IsChanged=true; }
      }
      public bool SC_Filter_IsChanged
      {
         get{ return sC_Filter_IsChanged; }
         set{ sC_Filter_IsChanged = value; }
      }
      private string sC_Color;
      private bool sC_Color_IsChanged=false;
      public string SC_Color
      {
         get{ return sC_Color; }
         set{ sC_Color = value; sC_Color_IsChanged=true; }
      }
      public bool SC_Color_IsChanged
      {
         get{ return sC_Color_IsChanged; }
         set{ sC_Color_IsChanged = value; }
      }
   }
}
