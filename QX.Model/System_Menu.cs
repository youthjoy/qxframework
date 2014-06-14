using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 系统菜单
   /// </summary>
   [Serializable]
   public partial class System_Menu
   {
      /// <summary>
      /// 序列号
      /// </summary>
      private decimal menu_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_ID_IsChanged=false;
      /// <summary>
      /// 序列号
      /// </summary>
      public decimal Menu_ID
      {
         get{ return menu_ID; }
         set{ menu_ID = value; menu_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序列号
      /// </summary>
      public bool Menu_ID_IsChanged
      {
         get{ return menu_ID_IsChanged; }
         set{ menu_ID_IsChanged = value; }
      }
      /// <summary>
      /// 菜单编码
      /// </summary>
      private string menu_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_Code_IsChanged=false;
      /// <summary>
      /// 菜单编码
      /// </summary>
      public string Menu_Code
      {
         get{ return menu_Code; }
         set{ menu_Code = value; menu_Code_IsChanged=true; }
      }
      /// <summary>
      /// 菜单编码
      /// </summary>
      public bool Menu_Code_IsChanged
      {
         get{ return menu_Code_IsChanged; }
         set{ menu_Code_IsChanged = value; }
      }
      /// <summary>
      /// 菜单名称
      /// </summary>
      private string menu_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_Title_IsChanged=false;
      /// <summary>
      /// 菜单名称
      /// </summary>
      public string Menu_Title
      {
         get{ return menu_Title; }
         set{ menu_Title = value; menu_Title_IsChanged=true; }
      }
      /// <summary>
      /// 菜单名称
      /// </summary>
      public bool Menu_Title_IsChanged
      {
         get{ return menu_Title_IsChanged; }
         set{ menu_Title_IsChanged = value; }
      }
      /// <summary>
      /// 菜单位置
      /// </summary>
      private string menu_Location;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_Location_IsChanged=false;
      /// <summary>
      /// 菜单位置
      /// </summary>
      public string Menu_Location
      {
         get{ return menu_Location; }
         set{ menu_Location = value; menu_Location_IsChanged=true; }
      }
      /// <summary>
      /// 菜单位置
      /// </summary>
      public bool Menu_Location_IsChanged
      {
         get{ return menu_Location_IsChanged; }
         set{ menu_Location_IsChanged = value; }
      }
      /// <summary>
      /// 菜单父编码
      /// </summary>
      private string menu_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_PCode_IsChanged=false;
      /// <summary>
      /// 菜单父编码
      /// </summary>
      public string Menu_PCode
      {
         get{ return menu_PCode; }
         set{ menu_PCode = value; menu_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 菜单父编码
      /// </summary>
      public bool Menu_PCode_IsChanged
      {
         get{ return menu_PCode_IsChanged; }
         set{ menu_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 是否启用
      /// </summary>
      private string menu_Enable;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_Enable_IsChanged=false;
      /// <summary>
      /// 是否启用
      /// </summary>
      public string Menu_Enable
      {
         get{ return menu_Enable; }
         set{ menu_Enable = value; menu_Enable_IsChanged=true; }
      }
      /// <summary>
      /// 是否启用
      /// </summary>
      public bool Menu_Enable_IsChanged
      {
         get{ return menu_Enable_IsChanged; }
         set{ menu_Enable_IsChanged = value; }
      }
      /// <summary>
      /// 菜单URL
      /// </summary>
      private string menu_Url;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_Url_IsChanged=false;
      /// <summary>
      /// 菜单URL
      /// </summary>
      public string Menu_Url
      {
         get{ return menu_Url; }
         set{ menu_Url = value; menu_Url_IsChanged=true; }
      }
      /// <summary>
      /// 菜单URL
      /// </summary>
      public bool Menu_Url_IsChanged
      {
         get{ return menu_Url_IsChanged; }
         set{ menu_Url_IsChanged = value; }
      }
      /// <summary>
      /// 菜单排序
      /// </summary>
      private int menu_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_Order_IsChanged=false;
      /// <summary>
      /// 菜单排序
      /// </summary>
      public int Menu_Order
      {
         get{ return menu_Order; }
         set{ menu_Order = value; menu_Order_IsChanged=true; }
      }
      /// <summary>
      /// 菜单排序
      /// </summary>
      public bool Menu_Order_IsChanged
      {
         get{ return menu_Order_IsChanged; }
         set{ menu_Order_IsChanged = value; }
      }
      /// <summary>
      /// 图标
      /// </summary>
      private string menu_Icon;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool menu_Icon_IsChanged=false;
      /// <summary>
      /// 图标
      /// </summary>
      public string Menu_Icon
      {
         get{ return menu_Icon; }
         set{ menu_Icon = value; menu_Icon_IsChanged=true; }
      }
      /// <summary>
      /// 图标
      /// </summary>
      public bool Menu_Icon_IsChanged
      {
         get{ return menu_Icon_IsChanged; }
         set{ menu_Icon_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private int shortcut;
      private bool shortcut_IsChanged=false;
      public int Shortcut
      {
         get{ return shortcut; }
         set{ shortcut = value; shortcut_IsChanged=true; }
      }
      public bool Shortcut_IsChanged
      {
         get{ return shortcut_IsChanged; }
         set{ shortcut_IsChanged = value; }
      }
   }
}
