using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   /// <summary>
   /// 通用参考明细
   /// </summary>
   [Serializable]
   public partial class Sys_Config_Field_Refer
   {
      private decimal d_ID;
      private bool d_ID_IsChanged=false;
      public decimal D_ID
      {
         get{ return d_ID; }
         set{ d_ID = value; d_ID_IsChanged=true; }
      }
      public bool D_ID_IsChanged
      {
         get{ return d_ID_IsChanged; }
         set{ d_ID_IsChanged = value; }
      }
      private string d_ModuleName;
      private bool d_ModuleName_IsChanged=false;
      public string D_ModuleName
      {
         get{ return d_ModuleName; }
         set{ d_ModuleName = value; d_ModuleName_IsChanged=true; }
      }
      public bool D_ModuleName_IsChanged
      {
         get{ return d_ModuleName_IsChanged; }
         set{ d_ModuleName_IsChanged = value; }
      }
      private string d_NameSpace;
      private bool d_NameSpace_IsChanged=false;
      public string D_NameSpace
      {
         get{ return d_NameSpace; }
         set{ d_NameSpace = value; d_NameSpace_IsChanged=true; }
      }
      public bool D_NameSpace_IsChanged
      {
         get{ return d_NameSpace_IsChanged; }
         set{ d_NameSpace_IsChanged = value; }
      }
      private string d_Index;
      private bool d_Index_IsChanged=false;
      public string D_Index
      {
         get{ return d_Index; }
         set{ d_Index = value; d_Index_IsChanged=true; }
      }
      public bool D_Index_IsChanged
      {
         get{ return d_Index_IsChanged; }
         set{ d_Index_IsChanged = value; }
      }
      private string d_Name;
      private bool d_Name_IsChanged=false;
      public string D_Name
      {
         get{ return d_Name; }
         set{ d_Name = value; d_Name_IsChanged=true; }
      }
      public bool D_Name_IsChanged
      {
         get{ return d_Name_IsChanged; }
         set{ d_Name_IsChanged = value; }
      }
      private int d_Order;
      private bool d_Order_IsChanged=false;
      public int D_Order
      {
         get{ return d_Order; }
         set{ d_Order = value; d_Order_IsChanged=true; }
      }
      public bool D_Order_IsChanged
      {
         get{ return d_Order_IsChanged; }
         set{ d_Order_IsChanged = value; }
      }
      private string d_DictKey;
      private bool d_DictKey_IsChanged=false;
      public string D_DictKey
      {
         get{ return d_DictKey; }
         set{ d_DictKey = value; d_DictKey_IsChanged=true; }
      }
      public bool D_DictKey_IsChanged
      {
         get{ return d_DictKey_IsChanged; }
         set{ d_DictKey_IsChanged = value; }
      }
      private string d_Hidden;
      private bool d_Hidden_IsChanged=false;
      public string D_Hidden
      {
         get{ return d_Hidden; }
         set{ d_Hidden = value; d_Hidden_IsChanged=true; }
      }
      public bool D_Hidden_IsChanged
      {
         get{ return d_Hidden_IsChanged; }
         set{ d_Hidden_IsChanged = value; }
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
