using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   /// <summary>
   /// List报表类型配置表
   /// </summary>
   [Serializable]
   public partial class Sys_Config_ListPage
   {
      /// <summary>
      /// 模块序列号
      /// </summary>
      private int m_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool m_ID_IsChanged=false;
      /// <summary>
      /// 模块序列号
      /// </summary>
      public int M_ID
      {
         get{ return m_ID; }
         set{ m_ID = value; m_ID_IsChanged=true; }
      }
      /// <summary>
      /// 模块序列号
      /// </summary>
      public bool M_ID_IsChanged
      {
         get{ return m_ID_IsChanged; }
         set{ m_ID_IsChanged = value; }
      }
      /// <summary>
      /// 模块名称 
      /// </summary>
      private string m_ModuleCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool m_ModuleCode_IsChanged=false;
      /// <summary>
      /// 模块名称 
      /// </summary>
      public string M_ModuleCode
      {
         get{ return m_ModuleCode; }
         set{ m_ModuleCode = value; m_ModuleCode_IsChanged=true; }
      }
      /// <summary>
      /// 模块名称 
      /// </summary>
      public bool M_ModuleCode_IsChanged
      {
         get{ return m_ModuleCode_IsChanged; }
         set{ m_ModuleCode_IsChanged = value; }
      }
      private string m_TableName;
      private bool m_TableName_IsChanged=false;
      public string M_TableName
      {
         get{ return m_TableName; }
         set{ m_TableName = value; m_TableName_IsChanged=true; }
      }
      public bool M_TableName_IsChanged
      {
         get{ return m_TableName_IsChanged; }
         set{ m_TableName_IsChanged = value; }
      }
      private string m_NameSpace;
      private bool m_NameSpace_IsChanged=false;
      public string M_NameSpace
      {
         get{ return m_NameSpace; }
         set{ m_NameSpace = value; m_NameSpace_IsChanged=true; }
      }
      public bool M_NameSpace_IsChanged
      {
         get{ return m_NameSpace_IsChanged; }
         set{ m_NameSpace_IsChanged = value; }
      }
      private string m_SQL;
      private bool m_SQL_IsChanged=false;
      public string M_SQL
      {
         get{ return m_SQL; }
         set{ m_SQL = value; m_SQL_IsChanged=true; }
      }
      public bool M_SQL_IsChanged
      {
         get{ return m_SQL_IsChanged; }
         set{ m_SQL_IsChanged = value; }
      }
      /// <summary>
      /// 分类
      /// </summary>
      private string m_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool m_Type_IsChanged=false;
      /// <summary>
      /// 分类
      /// </summary>
      public string M_Type
      {
         get{ return m_Type; }
         set{ m_Type = value; m_Type_IsChanged=true; }
      }
      /// <summary>
      /// 分类
      /// </summary>
      public bool M_Type_IsChanged
      {
         get{ return m_Type_IsChanged; }
         set{ m_Type_IsChanged = value; }
      }
      /// <summary>
      /// 显示标题
      /// </summary>
      private string m_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool m_Title_IsChanged=false;
      /// <summary>
      /// 显示标题
      /// </summary>
      public string M_Title
      {
         get{ return m_Title; }
         set{ m_Title = value; m_Title_IsChanged=true; }
      }
      /// <summary>
      /// 显示标题
      /// </summary>
      public bool M_Title_IsChanged
      {
         get{ return m_Title_IsChanged; }
         set{ m_Title_IsChanged = value; }
      }
      private string m_AutoWidth;
      private bool m_AutoWidth_IsChanged=false;
      public string M_AutoWidth
      {
         get{ return m_AutoWidth; }
         set{ m_AutoWidth = value; m_AutoWidth_IsChanged=true; }
      }
      public bool M_AutoWidth_IsChanged
      {
         get{ return m_AutoWidth_IsChanged; }
         set{ m_AutoWidth_IsChanged = value; }
      }
      private string m_Width;
      private bool m_Width_IsChanged=false;
      public string M_Width
      {
         get{ return m_Width; }
         set{ m_Width = value; m_Width_IsChanged=true; }
      }
      public bool M_Width_IsChanged
      {
         get{ return m_Width_IsChanged; }
         set{ m_Width_IsChanged = value; }
      }
      private string m_Height;
      private bool m_Height_IsChanged=false;
      public string M_Height
      {
         get{ return m_Height; }
         set{ m_Height = value; m_Height_IsChanged=true; }
      }
      public bool M_Height_IsChanged
      {
         get{ return m_Height_IsChanged; }
         set{ m_Height_IsChanged = value; }
      }
      private string m_URL;
      private bool m_URL_IsChanged=false;
      public string M_URL
      {
         get{ return m_URL; }
         set{ m_URL = value; m_URL_IsChanged=true; }
      }
      public bool M_URL_IsChanged
      {
         get{ return m_URL_IsChanged; }
         set{ m_URL_IsChanged = value; }
      }
      private string m_MType;
      private bool m_MType_IsChanged=false;
      public string M_MType
      {
         get{ return m_MType; }
         set{ m_MType = value; m_MType_IsChanged=true; }
      }
      public bool M_MType_IsChanged
      {
         get{ return m_MType_IsChanged; }
         set{ m_MType_IsChanged = value; }
      }
      private string m_GetDataType;
      private bool m_GetDataType_IsChanged=false;
      public string M_GetDataType
      {
         get{ return m_GetDataType; }
         set{ m_GetDataType = value; m_GetDataType_IsChanged=true; }
      }
      public bool M_GetDataType_IsChanged
      {
         get{ return m_GetDataType_IsChanged; }
         set{ m_GetDataType_IsChanged = value; }
      }
      private string m_SQLParameter;
      private bool m_SQLParameter_IsChanged=false;
      public string M_SQLParameter
      {
         get{ return m_SQLParameter; }
         set{ m_SQLParameter = value; m_SQLParameter_IsChanged=true; }
      }
      public bool M_SQLParameter_IsChanged
      {
         get{ return m_SQLParameter_IsChanged; }
         set{ m_SQLParameter_IsChanged = value; }
      }
      private string m_RowNum;
      private bool m_RowNum_IsChanged=false;
      public string M_RowNum
      {
         get{ return m_RowNum; }
         set{ m_RowNum = value; m_RowNum_IsChanged=true; }
      }
      public bool M_RowNum_IsChanged
      {
         get{ return m_RowNum_IsChanged; }
         set{ m_RowNum_IsChanged = value; }
      }
      private string m_RowList;
      private bool m_RowList_IsChanged=false;
      public string M_RowList
      {
         get{ return m_RowList; }
         set{ m_RowList = value; m_RowList_IsChanged=true; }
      }
      public bool M_RowList_IsChanged
      {
         get{ return m_RowList_IsChanged; }
         set{ m_RowList_IsChanged = value; }
      }
      private string m_FooterRow;
      private bool m_FooterRow_IsChanged=false;
      public string M_FooterRow
      {
         get{ return m_FooterRow; }
         set{ m_FooterRow = value; m_FooterRow_IsChanged=true; }
      }
      public bool M_FooterRow_IsChanged
      {
         get{ return m_FooterRow_IsChanged; }
         set{ m_FooterRow_IsChanged = value; }
      }
      private string m_ViewURL;
      private bool m_ViewURL_IsChanged=false;
      public string M_ViewURL
      {
         get{ return m_ViewURL; }
         set{ m_ViewURL = value; m_ViewURL_IsChanged=true; }
      }
      public bool M_ViewURL_IsChanged
      {
         get{ return m_ViewURL_IsChanged; }
         set{ m_ViewURL_IsChanged = value; }
      }
      /// <summary>
      /// 弹出层或新开窗口
      /// </summary>
      private string m_ViewType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool m_ViewType_IsChanged=false;
      /// <summary>
      /// 弹出层或新开窗口
      /// </summary>
      public string M_ViewType
      {
         get{ return m_ViewType; }
         set{ m_ViewType = value; m_ViewType_IsChanged=true; }
      }
      /// <summary>
      /// 弹出层或新开窗口
      /// </summary>
      public bool M_ViewType_IsChanged
      {
         get{ return m_ViewType_IsChanged; }
         set{ m_ViewType_IsChanged = value; }
      }
      private string m_Edit;
      private bool m_Edit_IsChanged=false;
      public string M_Edit
      {
         get{ return m_Edit; }
         set{ m_Edit = value; m_Edit_IsChanged=true; }
      }
      public bool M_Edit_IsChanged
      {
         get{ return m_Edit_IsChanged; }
         set{ m_Edit_IsChanged = value; }
      }
      private string m_EditUrl;
      private bool m_EditUrl_IsChanged=false;
      public string M_EditUrl
      {
         get{ return m_EditUrl; }
         set{ m_EditUrl = value; m_EditUrl_IsChanged=true; }
      }
      public bool M_EditUrl_IsChanged
      {
         get{ return m_EditUrl_IsChanged; }
         set{ m_EditUrl_IsChanged = value; }
      }
      private string m_EditSubmitUrl;
      private bool m_EditSubmitUrl_IsChanged=false;
      public string M_EditSubmitUrl
      {
         get{ return m_EditSubmitUrl; }
         set{ m_EditSubmitUrl = value; m_EditSubmitUrl_IsChanged=true; }
      }
      public bool M_EditSubmitUrl_IsChanged
      {
         get{ return m_EditSubmitUrl_IsChanged; }
         set{ m_EditSubmitUrl_IsChanged = value; }
      }
      private string m_OnSelectRow;
      private bool m_OnSelectRow_IsChanged=false;
      public string M_OnSelectRow
      {
         get{ return m_OnSelectRow; }
         set{ m_OnSelectRow = value; m_OnSelectRow_IsChanged=true; }
      }
      public bool M_OnSelectRow_IsChanged
      {
         get{ return m_OnSelectRow_IsChanged; }
         set{ m_OnSelectRow_IsChanged = value; }
      }
      private string m_GridComplete;
      private bool m_GridComplete_IsChanged=false;
      public string M_GridComplete
      {
         get{ return m_GridComplete; }
         set{ m_GridComplete = value; m_GridComplete_IsChanged=true; }
      }
      public bool M_GridComplete_IsChanged
      {
         get{ return m_GridComplete_IsChanged; }
         set{ m_GridComplete_IsChanged = value; }
      }
      private string m_InlineEditing;
      private bool m_InlineEditing_IsChanged=false;
      public string M_InlineEditing
      {
         get{ return m_InlineEditing; }
         set{ m_InlineEditing = value; m_InlineEditing_IsChanged=true; }
      }
      public bool M_InlineEditing_IsChanged
      {
         get{ return m_InlineEditing_IsChanged; }
         set{ m_InlineEditing_IsChanged = value; }
      }
      private string m_ImportURL;
      private bool m_ImportURL_IsChanged=false;
      public string M_ImportURL
      {
         get{ return m_ImportURL; }
         set{ m_ImportURL = value; m_ImportURL_IsChanged=true; }
      }
      public bool M_ImportURL_IsChanged
      {
         get{ return m_ImportURL_IsChanged; }
         set{ m_ImportURL_IsChanged = value; }
      }
      private string m_ImportTable;
      private bool m_ImportTable_IsChanged=false;
      public string M_ImportTable
      {
         get{ return m_ImportTable; }
         set{ m_ImportTable = value; m_ImportTable_IsChanged=true; }
      }
      public bool M_ImportTable_IsChanged
      {
         get{ return m_ImportTable_IsChanged; }
         set{ m_ImportTable_IsChanged = value; }
      }
      private string m_ImportExport;
      private bool m_ImportExport_IsChanged=false;
      public string M_ImportExport
      {
         get{ return m_ImportExport; }
         set{ m_ImportExport = value; m_ImportExport_IsChanged=true; }
      }
      public bool M_ImportExport_IsChanged
      {
         get{ return m_ImportExport_IsChanged; }
         set{ m_ImportExport_IsChanged = value; }
      }
      private string m_AltRows;
      private bool m_AltRows_IsChanged=false;
      public string M_AltRows
      {
         get{ return m_AltRows; }
         set{ m_AltRows = value; m_AltRows_IsChanged=true; }
      }
      public bool M_AltRows_IsChanged
      {
         get{ return m_AltRows_IsChanged; }
         set{ m_AltRows_IsChanged = value; }
      }
      private string m_Altclass;
      private bool m_Altclass_IsChanged=false;
      public string M_Altclass
      {
         get{ return m_Altclass; }
         set{ m_Altclass = value; m_Altclass_IsChanged=true; }
      }
      public bool M_Altclass_IsChanged
      {
         get{ return m_Altclass_IsChanged; }
         set{ m_Altclass_IsChanged = value; }
      }
      private string m_emptyrecords;
      private bool m_emptyrecords_IsChanged=false;
      public string M_emptyrecords
      {
         get{ return m_emptyrecords; }
         set{ m_emptyrecords = value; m_emptyrecords_IsChanged=true; }
      }
      public bool M_emptyrecords_IsChanged
      {
         get{ return m_emptyrecords_IsChanged; }
         set{ m_emptyrecords_IsChanged = value; }
      }
      private string m_Gridstate;
      private bool m_Gridstate_IsChanged=false;
      public string M_Gridstate
      {
         get{ return m_Gridstate; }
         set{ m_Gridstate = value; m_Gridstate_IsChanged=true; }
      }
      public bool M_Gridstate_IsChanged
      {
         get{ return m_Gridstate_IsChanged; }
         set{ m_Gridstate_IsChanged = value; }
      }
      private int m_EditCloumNum;
      private bool m_EditCloumNum_IsChanged=false;
      public int M_EditCloumNum
      {
         get{ return m_EditCloumNum; }
         set{ m_EditCloumNum = value; m_EditCloumNum_IsChanged=true; }
      }
      public bool M_EditCloumNum_IsChanged
      {
         get{ return m_EditCloumNum_IsChanged; }
         set{ m_EditCloumNum_IsChanged = value; }
      }
      private string m_ToolBar;
      private bool m_ToolBar_IsChanged=false;
      public string M_ToolBar
      {
         get{ return m_ToolBar; }
         set{ m_ToolBar = value; m_ToolBar_IsChanged=true; }
      }
      public bool M_ToolBar_IsChanged
      {
         get{ return m_ToolBar_IsChanged; }
         set{ m_ToolBar_IsChanged = value; }
      }
      private string m_ToolBarExtend;
      private bool m_ToolBarExtend_IsChanged=false;
      public string M_ToolBarExtend
      {
         get{ return m_ToolBarExtend; }
         set{ m_ToolBarExtend = value; m_ToolBarExtend_IsChanged=true; }
      }
      public bool M_ToolBarExtend_IsChanged
      {
         get{ return m_ToolBarExtend_IsChanged; }
         set{ m_ToolBarExtend_IsChanged = value; }
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
      private string m_ExtendsJs;
      private bool m_ExtendsJs_IsChanged=false;
      public string M_ExtendsJs
      {
         get{ return m_ExtendsJs; }
         set{ m_ExtendsJs = value; m_ExtendsJs_IsChanged=true; }
      }
      public bool M_ExtendsJs_IsChanged
      {
         get{ return m_ExtendsJs_IsChanged; }
         set{ m_ExtendsJs_IsChanged = value; }
      }
      private string m_ExtendsControl;
      private bool m_ExtendsControl_IsChanged=false;
      public string M_ExtendsControl
      {
         get{ return m_ExtendsControl; }
         set{ m_ExtendsControl = value; m_ExtendsControl_IsChanged=true; }
      }
      public bool M_ExtendsControl_IsChanged
      {
         get{ return m_ExtendsControl_IsChanged; }
         set{ m_ExtendsControl_IsChanged = value; }
      }
      private string m_EditTitle;
      private bool m_EditTitle_IsChanged=false;
      public string M_EditTitle
      {
         get{ return m_EditTitle; }
         set{ m_EditTitle = value; m_EditTitle_IsChanged=true; }
      }
      public bool M_EditTitle_IsChanged
      {
         get{ return m_EditTitle_IsChanged; }
         set{ m_EditTitle_IsChanged = value; }
      }
      /// <summary>
      /// 允许多远 true false
      /// </summary>
      private string m_MSelect;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool m_MSelect_IsChanged=false;
      /// <summary>
      /// 允许多远 true false
      /// </summary>
      public string M_MSelect
      {
         get{ return m_MSelect; }
         set{ m_MSelect = value; m_MSelect_IsChanged=true; }
      }
      /// <summary>
      /// 允许多远 true false
      /// </summary>
      public bool M_MSelect_IsChanged
      {
         get{ return m_MSelect_IsChanged; }
         set{ m_MSelect_IsChanged = value; }
      }
      /// <summary>
      /// 存储过程参数
      /// </summary>
      private string m_Parameters;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool m_Parameters_IsChanged=false;
      /// <summary>
      /// 存储过程参数
      /// </summary>
      public string M_Parameters
      {
         get{ return m_Parameters; }
         set{ m_Parameters = value; m_Parameters_IsChanged=true; }
      }
      /// <summary>
      /// 存储过程参数
      /// </summary>
      public bool M_Parameters_IsChanged
      {
         get{ return m_Parameters_IsChanged; }
         set{ m_Parameters_IsChanged = value; }
      }
      private string m_GroupingView;
      private bool m_GroupingView_IsChanged=false;
      public string M_GroupingView
      {
         get{ return m_GroupingView; }
         set{ m_GroupingView = value; m_GroupingView_IsChanged=true; }
      }
      public bool M_GroupingView_IsChanged
      {
         get{ return m_GroupingView_IsChanged; }
         set{ m_GroupingView_IsChanged = value; }
      }
      private string m_FormEditing;
      private bool m_FormEditing_IsChanged=false;
      public string M_FormEditing
      {
         get{ return m_FormEditing; }
         set{ m_FormEditing = value; m_FormEditing_IsChanged=true; }
      }
      public bool M_FormEditing_IsChanged
      {
         get{ return m_FormEditing_IsChanged; }
         set{ m_FormEditing_IsChanged = value; }
      }
      private string m_FormMethod;
      private bool m_FormMethod_IsChanged=false;
      public string M_FormMethod
      {
         get{ return m_FormMethod; }
         set{ m_FormMethod = value; m_FormMethod_IsChanged=true; }
      }
      public bool M_FormMethod_IsChanged
      {
         get{ return m_FormMethod_IsChanged; }
         set{ m_FormMethod_IsChanged = value; }
      }
      private int m_IsAdd;
      private bool m_IsAdd_IsChanged=false;
      public int M_IsAdd
      {
         get{ return m_IsAdd; }
         set{ m_IsAdd = value; m_IsAdd_IsChanged=true; }
      }
      public bool M_IsAdd_IsChanged
      {
         get{ return m_IsAdd_IsChanged; }
         set{ m_IsAdd_IsChanged = value; }
      }
      private int m_IsEdit;
      private bool m_IsEdit_IsChanged=false;
      public int M_IsEdit
      {
         get{ return m_IsEdit; }
         set{ m_IsEdit = value; m_IsEdit_IsChanged=true; }
      }
      public bool M_IsEdit_IsChanged
      {
         get{ return m_IsEdit_IsChanged; }
         set{ m_IsEdit_IsChanged = value; }
      }
      private int m_IsDelete;
      private bool m_IsDelete_IsChanged=false;
      public int M_IsDelete
      {
         get{ return m_IsDelete; }
         set{ m_IsDelete = value; m_IsDelete_IsChanged=true; }
      }
      public bool M_IsDelete_IsChanged
      {
         get{ return m_IsDelete_IsChanged; }
         set{ m_IsDelete_IsChanged = value; }
      }
      private string m_IsView;
      private bool m_IsView_IsChanged=false;
      public string M_IsView
      {
         get{ return m_IsView; }
         set{ m_IsView = value; m_IsView_IsChanged=true; }
      }
      public bool M_IsView_IsChanged
      {
         get{ return m_IsView_IsChanged; }
         set{ m_IsView_IsChanged = value; }
      }
   }
}
