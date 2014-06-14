using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 报表工具条配置表
   /// </summary>
   [Serializable]
   public partial class ChartToolBar
   {
      /// <summary>
      /// 序列号
      /// </summary>
      private decimal cT_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_ID_IsChanged=false;
      /// <summary>
      /// 序列号
      /// </summary>
      public decimal CT_ID
      {
         get{ return cT_ID; }
         set{ cT_ID = value; cT_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序列号
      /// </summary>
      public bool CT_ID_IsChanged
      {
         get{ return cT_ID_IsChanged; }
         set{ cT_ID_IsChanged = value; }
      }
      /// <summary>
      /// 模块
      /// </summary>
      private string cT_Module;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_Module_IsChanged=false;
      /// <summary>
      /// 模块
      /// </summary>
      public string CT_Module
      {
         get{ return cT_Module; }
         set{ cT_Module = value; cT_Module_IsChanged=true; }
      }
      /// <summary>
      /// 模块
      /// </summary>
      public bool CT_Module_IsChanged
      {
         get{ return cT_Module_IsChanged; }
         set{ cT_Module_IsChanged = value; }
      }
      /// <summary>
      /// 字段
      /// </summary>
      private string cT_Field;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_Field_IsChanged=false;
      /// <summary>
      /// 字段
      /// </summary>
      public string CT_Field
      {
         get{ return cT_Field; }
         set{ cT_Field = value; cT_Field_IsChanged=true; }
      }
      /// <summary>
      /// 字段
      /// </summary>
      public bool CT_Field_IsChanged
      {
         get{ return cT_Field_IsChanged; }
         set{ cT_Field_IsChanged = value; }
      }
      /// <summary>
      /// 名称
      /// </summary>
      private string cT_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_Name_IsChanged=false;
      /// <summary>
      /// 名称
      /// </summary>
      public string CT_Name
      {
         get{ return cT_Name; }
         set{ cT_Name = value; cT_Name_IsChanged=true; }
      }
      /// <summary>
      /// 名称
      /// </summary>
      public bool CT_Name_IsChanged
      {
         get{ return cT_Name_IsChanged; }
         set{ cT_Name_IsChanged = value; }
      }
      /// <summary>
      /// 排序
      /// </summary>
      private int cT_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_Order_IsChanged=false;
      /// <summary>
      /// 排序
      /// </summary>
      public int CT_Order
      {
         get{ return cT_Order; }
         set{ cT_Order = value; cT_Order_IsChanged=true; }
      }
      /// <summary>
      /// 排序
      /// </summary>
      public bool CT_Order_IsChanged
      {
         get{ return cT_Order_IsChanged; }
         set{ cT_Order_IsChanged = value; }
      }
      /// <summary>
      /// 类型
      /// </summary>
      private string cT_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_Type_IsChanged=false;
      /// <summary>
      /// 类型
      /// </summary>
      public string CT_Type
      {
         get{ return cT_Type; }
         set{ cT_Type = value; cT_Type_IsChanged=true; }
      }
      /// <summary>
      /// 类型
      /// </summary>
      public bool CT_Type_IsChanged
      {
         get{ return cT_Type_IsChanged; }
         set{ cT_Type_IsChanged = value; }
      }
      /// <summary>
      /// 字典Key
      /// </summary>
      private string cT_DictKey;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_DictKey_IsChanged=false;
      /// <summary>
      /// 字典Key
      /// </summary>
      public string CT_DictKey
      {
         get{ return cT_DictKey; }
         set{ cT_DictKey = value; cT_DictKey_IsChanged=true; }
      }
      /// <summary>
      /// 字典Key
      /// </summary>
      public bool CT_DictKey_IsChanged
      {
         get{ return cT_DictKey_IsChanged; }
         set{ cT_DictKey_IsChanged = value; }
      }
      /// <summary>
      /// JS
      /// </summary>
      private string cT_JS;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_JS_IsChanged=false;
      /// <summary>
      /// JS
      /// </summary>
      public string CT_JS
      {
         get{ return cT_JS; }
         set{ cT_JS = value; cT_JS_IsChanged=true; }
      }
      /// <summary>
      /// JS
      /// </summary>
      public bool CT_JS_IsChanged
      {
         get{ return cT_JS_IsChanged; }
         set{ cT_JS_IsChanged = value; }
      }
      /// <summary>
      /// 默认值
      /// </summary>
      private string cT_Default;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_Default_IsChanged=false;
      /// <summary>
      /// 默认值
      /// </summary>
      public string CT_Default
      {
         get{ return cT_Default; }
         set{ cT_Default = value; cT_Default_IsChanged=true; }
      }
      /// <summary>
      /// 默认值
      /// </summary>
      public bool CT_Default_IsChanged
      {
         get{ return cT_Default_IsChanged; }
         set{ cT_Default_IsChanged = value; }
      }
      /// <summary>
      /// 显示
      /// </summary>
      private string cT_Show;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cT_Show_IsChanged=false;
      /// <summary>
      /// 显示
      /// </summary>
      public string CT_Show
      {
         get{ return cT_Show; }
         set{ cT_Show = value; cT_Show_IsChanged=true; }
      }
      /// <summary>
      /// 显示
      /// </summary>
      public bool CT_Show_IsChanged
      {
         get{ return cT_Show_IsChanged; }
         set{ cT_Show_IsChanged = value; }
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
      private string cT_Attr;
      private bool cT_Attr_IsChanged=false;
      public string CT_Attr
      {
         get{ return cT_Attr; }
         set{ cT_Attr = value; cT_Attr_IsChanged=true; }
      }
      public bool CT_Attr_IsChanged
      {
         get{ return cT_Attr_IsChanged; }
         set{ cT_Attr_IsChanged = value; }
      }
   }
}
