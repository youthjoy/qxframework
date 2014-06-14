using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   [Serializable]
   public partial class Sys_Config_Toolbar
   {
      private decimal cT_ID;
      private bool cT_ID_IsChanged=false;
      public decimal CT_ID
      {
         get{ return cT_ID; }
         set{ cT_ID = value; cT_ID_IsChanged=true; }
      }
      public bool CT_ID_IsChanged
      {
         get{ return cT_ID_IsChanged; }
         set{ cT_ID_IsChanged = value; }
      }
      private string cT_Module;
      private bool cT_Module_IsChanged=false;
      public string CT_Module
      {
         get{ return cT_Module; }
         set{ cT_Module = value; cT_Module_IsChanged=true; }
      }
      public bool CT_Module_IsChanged
      {
         get{ return cT_Module_IsChanged; }
         set{ cT_Module_IsChanged = value; }
      }
      private string cT_Field;
      private bool cT_Field_IsChanged=false;
      public string CT_Field
      {
         get{ return cT_Field; }
         set{ cT_Field = value; cT_Field_IsChanged=true; }
      }
      public bool CT_Field_IsChanged
      {
         get{ return cT_Field_IsChanged; }
         set{ cT_Field_IsChanged = value; }
      }
      private string cT_Name;
      private bool cT_Name_IsChanged=false;
      public string CT_Name
      {
         get{ return cT_Name; }
         set{ cT_Name = value; cT_Name_IsChanged=true; }
      }
      public bool CT_Name_IsChanged
      {
         get{ return cT_Name_IsChanged; }
         set{ cT_Name_IsChanged = value; }
      }
      private int cT_Order;
      private bool cT_Order_IsChanged=false;
      public int CT_Order
      {
         get{ return cT_Order; }
         set{ cT_Order = value; cT_Order_IsChanged=true; }
      }
      public bool CT_Order_IsChanged
      {
         get{ return cT_Order_IsChanged; }
         set{ cT_Order_IsChanged = value; }
      }
      private string cT_Type;
      private bool cT_Type_IsChanged=false;
      public string CT_Type
      {
         get{ return cT_Type; }
         set{ cT_Type = value; cT_Type_IsChanged=true; }
      }
      public bool CT_Type_IsChanged
      {
         get{ return cT_Type_IsChanged; }
         set{ cT_Type_IsChanged = value; }
      }
      private string cT_DictKey;
      private bool cT_DictKey_IsChanged=false;
      public string CT_DictKey
      {
         get{ return cT_DictKey; }
         set{ cT_DictKey = value; cT_DictKey_IsChanged=true; }
      }
      public bool CT_DictKey_IsChanged
      {
         get{ return cT_DictKey_IsChanged; }
         set{ cT_DictKey_IsChanged = value; }
      }
      private string cT_JS;
      private bool cT_JS_IsChanged=false;
      public string CT_JS
      {
         get{ return cT_JS; }
         set{ cT_JS = value; cT_JS_IsChanged=true; }
      }
      public bool CT_JS_IsChanged
      {
         get{ return cT_JS_IsChanged; }
         set{ cT_JS_IsChanged = value; }
      }
      private string cT_Default;
      private bool cT_Default_IsChanged=false;
      public string CT_Default
      {
         get{ return cT_Default; }
         set{ cT_Default = value; cT_Default_IsChanged=true; }
      }
      public bool CT_Default_IsChanged
      {
         get{ return cT_Default_IsChanged; }
         set{ cT_Default_IsChanged = value; }
      }
      private string cT_Show;
      private bool cT_Show_IsChanged=false;
      public string CT_Show
      {
         get{ return cT_Show; }
         set{ cT_Show = value; cT_Show_IsChanged=true; }
      }
      public bool CT_Show_IsChanged
      {
         get{ return cT_Show_IsChanged; }
         set{ cT_Show_IsChanged = value; }
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
      private string cT_Class;
      private bool cT_Class_IsChanged=false;
      public string CT_Class
      {
         get{ return cT_Class; }
         set{ cT_Class = value; cT_Class_IsChanged=true; }
      }
      public bool CT_Class_IsChanged
      {
         get{ return cT_Class_IsChanged; }
         set{ cT_Class_IsChanged = value; }
      }
      private string cT_Event;
      private bool cT_Event_IsChanged=false;
      public string CT_Event
      {
         get{ return cT_Event; }
         set{ cT_Event = value; cT_Event_IsChanged=true; }
      }
      public bool CT_Event_IsChanged
      {
         get{ return cT_Event_IsChanged; }
         set{ cT_Event_IsChanged = value; }
      }
      private string cT_Udef1;
      private bool cT_Udef1_IsChanged=false;
      public string CT_Udef1
      {
         get{ return cT_Udef1; }
         set{ cT_Udef1 = value; cT_Udef1_IsChanged=true; }
      }
      public bool CT_Udef1_IsChanged
      {
         get{ return cT_Udef1_IsChanged; }
         set{ cT_Udef1_IsChanged = value; }
      }
      private string cT_Udef2;
      private bool cT_Udef2_IsChanged=false;
      public string CT_Udef2
      {
         get{ return cT_Udef2; }
         set{ cT_Udef2 = value; cT_Udef2_IsChanged=true; }
      }
      public bool CT_Udef2_IsChanged
      {
         get{ return cT_Udef2_IsChanged; }
         set{ cT_Udef2_IsChanged = value; }
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
