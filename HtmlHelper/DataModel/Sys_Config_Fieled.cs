using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   /// <summary>
   /// 字段配置表
   /// </summary>
   [Serializable]
   public partial class Sys_Config_Fieled
   {
      /// <summary>
      /// 序列号
      /// </summary>
      private int d_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool d_ID_IsChanged=false;
      /// <summary>
      /// 序列号
      /// </summary>
      public int D_ID
      {
         get{ return d_ID; }
         set{ d_ID = value; d_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序列号
      /// </summary>
      public bool D_ID_IsChanged
      {
         get{ return d_ID_IsChanged; }
         set{ d_ID_IsChanged = value; }
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
      private string d_ModuleCode;
      private bool d_ModuleCode_IsChanged=false;
      public string D_ModuleCode
      {
         get{ return d_ModuleCode; }
         set{ d_ModuleCode = value; d_ModuleCode_IsChanged=true; }
      }
      public bool D_ModuleCode_IsChanged
      {
         get{ return d_ModuleCode_IsChanged; }
         set{ d_ModuleCode_IsChanged = value; }
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
      private string d_Type;
      private bool d_Type_IsChanged=false;
      public string D_Type
      {
         get{ return d_Type; }
         set{ d_Type = value; d_Type_IsChanged=true; }
      }
      public bool D_Type_IsChanged
      {
         get{ return d_Type_IsChanged; }
         set{ d_Type_IsChanged = value; }
      }
      private string d_EditHidden;
      private bool d_EditHidden_IsChanged=false;
      public string D_EditHidden
      {
         get{ return d_EditHidden; }
         set{ d_EditHidden = value; d_EditHidden_IsChanged=true; }
      }
      public bool D_EditHidden_IsChanged
      {
         get{ return d_EditHidden_IsChanged; }
         set{ d_EditHidden_IsChanged = value; }
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
      private string d_EditReadOnly;
      private bool d_EditReadOnly_IsChanged=false;
      public string D_EditReadOnly
      {
         get{ return d_EditReadOnly; }
         set{ d_EditReadOnly = value; d_EditReadOnly_IsChanged=true; }
      }
      public bool D_EditReadOnly_IsChanged
      {
         get{ return d_EditReadOnly_IsChanged; }
         set{ d_EditReadOnly_IsChanged = value; }
      }
      private int d_IsKey;
      private bool d_IsKey_IsChanged=false;
      public int D_IsKey
      {
         get{ return d_IsKey; }
         set{ d_IsKey = value; d_IsKey_IsChanged=true; }
      }
      public bool D_IsKey_IsChanged
      {
         get{ return d_IsKey_IsChanged; }
         set{ d_IsKey_IsChanged = value; }
      }
      private string d_DefaultValue;
      private bool d_DefaultValue_IsChanged=false;
      public string D_DefaultValue
      {
         get{ return d_DefaultValue; }
         set{ d_DefaultValue = value; d_DefaultValue_IsChanged=true; }
      }
      public bool D_DefaultValue_IsChanged
      {
         get{ return d_DefaultValue_IsChanged; }
         set{ d_DefaultValue_IsChanged = value; }
      }
      /// <summary>
      /// text,select,open,layer,date
      /// </summary>
      private string d_EditType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool d_EditType_IsChanged=false;
      /// <summary>
      /// text,select,open,layer,date
      /// </summary>
      public string D_EditType
      {
         get{ return d_EditType; }
         set{ d_EditType = value; d_EditType_IsChanged=true; }
      }
      /// <summary>
      /// text,select,open,layer,date
      /// </summary>
      public bool D_EditType_IsChanged
      {
         get{ return d_EditType_IsChanged; }
         set{ d_EditType_IsChanged = value; }
      }
      private string d_OpenLayer;
      private bool d_OpenLayer_IsChanged=false;
      public string D_OpenLayer
      {
         get{ return d_OpenLayer; }
         set{ d_OpenLayer = value; d_OpenLayer_IsChanged=true; }
      }
      public bool D_OpenLayer_IsChanged
      {
         get{ return d_OpenLayer_IsChanged; }
         set{ d_OpenLayer_IsChanged = value; }
      }
      private int d_Length;
      private bool d_Length_IsChanged=false;
      public int D_Length
      {
         get{ return d_Length; }
         set{ d_Length = value; d_Length_IsChanged=true; }
      }
      public bool D_Length_IsChanged
      {
         get{ return d_Length_IsChanged; }
         set{ d_Length_IsChanged = value; }
      }
      private string d_Width;
      private bool d_Width_IsChanged=false;
      public string D_Width
      {
         get{ return d_Width; }
         set{ d_Width = value; d_Width_IsChanged=true; }
      }
      public bool D_Width_IsChanged
      {
         get{ return d_Width_IsChanged; }
         set{ d_Width_IsChanged = value; }
      }
      private string d_Height;
      private bool d_Height_IsChanged=false;
      public string D_Height
      {
         get{ return d_Height; }
         set{ d_Height = value; d_Height_IsChanged=true; }
      }
      public bool D_Height_IsChanged
      {
         get{ return d_Height_IsChanged; }
         set{ d_Height_IsChanged = value; }
      }
      private string d_Align;
      private bool d_Align_IsChanged=false;
      public string D_Align
      {
         get{ return d_Align; }
         set{ d_Align = value; d_Align_IsChanged=true; }
      }
      public bool D_Align_IsChanged
      {
         get{ return d_Align_IsChanged; }
         set{ d_Align_IsChanged = value; }
      }
      private string d_Sortable;
      private bool d_Sortable_IsChanged=false;
      public string D_Sortable
      {
         get{ return d_Sortable; }
         set{ d_Sortable = value; d_Sortable_IsChanged=true; }
      }
      public bool D_Sortable_IsChanged
      {
         get{ return d_Sortable_IsChanged; }
         set{ d_Sortable_IsChanged = value; }
      }
      private string d_Editable;
      private bool d_Editable_IsChanged=false;
      public string D_Editable
      {
         get{ return d_Editable; }
         set{ d_Editable = value; d_Editable_IsChanged=true; }
      }
      public bool D_Editable_IsChanged
      {
         get{ return d_Editable_IsChanged; }
         set{ d_Editable_IsChanged = value; }
      }
      private string d_Editoptions;
      private bool d_Editoptions_IsChanged=false;
      public string D_Editoptions
      {
         get{ return d_Editoptions; }
         set{ d_Editoptions = value; d_Editoptions_IsChanged=true; }
      }
      public bool D_Editoptions_IsChanged
      {
         get{ return d_Editoptions_IsChanged; }
         set{ d_Editoptions_IsChanged = value; }
      }
      private string d_EditRules;
      private bool d_EditRules_IsChanged=false;
      public string D_EditRules
      {
         get{ return d_EditRules; }
         set{ d_EditRules = value; d_EditRules_IsChanged=true; }
      }
      public bool D_EditRules_IsChanged
      {
         get{ return d_EditRules_IsChanged; }
         set{ d_EditRules_IsChanged = value; }
      }
      private string d_FormOptions;
      private bool d_FormOptions_IsChanged=false;
      public string D_FormOptions
      {
         get{ return d_FormOptions; }
         set{ d_FormOptions = value; d_FormOptions_IsChanged=true; }
      }
      public bool D_FormOptions_IsChanged
      {
         get{ return d_FormOptions_IsChanged; }
         set{ d_FormOptions_IsChanged = value; }
      }
      private string d_Formatter;
      private bool d_Formatter_IsChanged=false;
      public string D_Formatter
      {
         get{ return d_Formatter; }
         set{ d_Formatter = value; d_Formatter_IsChanged=true; }
      }
      public bool D_Formatter_IsChanged
      {
         get{ return d_Formatter_IsChanged; }
         set{ d_Formatter_IsChanged = value; }
      }
      private string d_Searchoptions;
      private bool d_Searchoptions_IsChanged=false;
      public string D_Searchoptions
      {
         get{ return d_Searchoptions; }
         set{ d_Searchoptions = value; d_Searchoptions_IsChanged=true; }
      }
      public bool D_Searchoptions_IsChanged
      {
         get{ return d_Searchoptions_IsChanged; }
         set{ d_Searchoptions_IsChanged = value; }
      }
      private int d_ShowOrder;
      private bool d_ShowOrder_IsChanged=false;
      public int D_ShowOrder
      {
         get{ return d_ShowOrder; }
         set{ d_ShowOrder = value; d_ShowOrder_IsChanged=true; }
      }
      public bool D_ShowOrder_IsChanged
      {
         get{ return d_ShowOrder_IsChanged; }
         set{ d_ShowOrder_IsChanged = value; }
      }
      private int d_EditOrder;
      private bool d_EditOrder_IsChanged=false;
      public int D_EditOrder
      {
         get{ return d_EditOrder; }
         set{ d_EditOrder = value; d_EditOrder_IsChanged=true; }
      }
      public bool D_EditOrder_IsChanged
      {
         get{ return d_EditOrder_IsChanged; }
         set{ d_EditOrder_IsChanged = value; }
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
      private string d_DoEvent;
      private bool d_DoEvent_IsChanged=false;
      public string D_DoEvent
      {
         get{ return d_DoEvent; }
         set{ d_DoEvent = value; d_DoEvent_IsChanged=true; }
      }
      public bool D_DoEvent_IsChanged
      {
         get{ return d_DoEvent_IsChanged; }
         set{ d_DoEvent_IsChanged = value; }
      }
      private string d_EditMessage;
      private bool d_EditMessage_IsChanged=false;
      public string D_EditMessage
      {
         get{ return d_EditMessage; }
         set{ d_EditMessage = value; d_EditMessage_IsChanged=true; }
      }
      public bool D_EditMessage_IsChanged
      {
         get{ return d_EditMessage_IsChanged; }
         set{ d_EditMessage_IsChanged = value; }
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
      private string d_UDEF1;
      private bool d_UDEF1_IsChanged=false;
      public string D_UDEF1
      {
         get{ return d_UDEF1; }
         set{ d_UDEF1 = value; d_UDEF1_IsChanged=true; }
      }
      public bool D_UDEF1_IsChanged
      {
         get{ return d_UDEF1_IsChanged; }
         set{ d_UDEF1_IsChanged = value; }
      }
      private string d_UDEF2;
      private bool d_UDEF2_IsChanged=false;
      public string D_UDEF2
      {
         get{ return d_UDEF2; }
         set{ d_UDEF2 = value; d_UDEF2_IsChanged=true; }
      }
      public bool D_UDEF2_IsChanged
      {
         get{ return d_UDEF2_IsChanged; }
         set{ d_UDEF2_IsChanged = value; }
      }
      private string d_UDEF3;
      private bool d_UDEF3_IsChanged=false;
      public string D_UDEF3
      {
         get{ return d_UDEF3; }
         set{ d_UDEF3 = value; d_UDEF3_IsChanged=true; }
      }
      public bool D_UDEF3_IsChanged
      {
         get{ return d_UDEF3_IsChanged; }
         set{ d_UDEF3_IsChanged = value; }
      }
      private string d_UDEF4;
      private bool d_UDEF4_IsChanged=false;
      public string D_UDEF4
      {
         get{ return d_UDEF4; }
         set{ d_UDEF4 = value; d_UDEF4_IsChanged=true; }
      }
      public bool D_UDEF4_IsChanged
      {
         get{ return d_UDEF4_IsChanged; }
         set{ d_UDEF4_IsChanged = value; }
      }
      private string d_EditTab;
      private bool d_EditTab_IsChanged=false;
      public string D_EditTab
      {
         get{ return d_EditTab; }
         set{ d_EditTab = value; d_EditTab_IsChanged=true; }
      }
      public bool D_EditTab_IsChanged
      {
         get{ return d_EditTab_IsChanged; }
         set{ d_EditTab_IsChanged = value; }
      }
      private string d_DBField;
      private bool d_DBField_IsChanged=false;
      public string D_DBField
      {
         get{ return d_DBField; }
         set{ d_DBField = value; d_DBField_IsChanged=true; }
      }
      public bool D_DBField_IsChanged
      {
         get{ return d_DBField_IsChanged; }
         set{ d_DBField_IsChanged = value; }
      }
      private string d_Summary;
      private bool d_Summary_IsChanged=false;
      public string D_Summary
      {
         get{ return d_Summary; }
         set{ d_Summary = value; d_Summary_IsChanged=true; }
      }
      public bool D_Summary_IsChanged
      {
         get{ return d_Summary_IsChanged; }
         set{ d_Summary_IsChanged = value; }
      }
      private string d_LinkUrl;
      private bool d_LinkUrl_IsChanged=false;
      public string D_LinkUrl
      {
         get{ return d_LinkUrl; }
         set{ d_LinkUrl = value; d_LinkUrl_IsChanged=true; }
      }
      public bool D_LinkUrl_IsChanged
      {
         get{ return d_LinkUrl_IsChanged; }
         set{ d_LinkUrl_IsChanged = value; }
      }
      private string d_LinkParam;
      private bool d_LinkParam_IsChanged=false;
      public string D_LinkParam
      {
         get{ return d_LinkParam; }
         set{ d_LinkParam = value; d_LinkParam_IsChanged=true; }
      }
      public bool D_LinkParam_IsChanged
      {
         get{ return d_LinkParam_IsChanged; }
         set{ d_LinkParam_IsChanged = value; }
      }
   }
}
