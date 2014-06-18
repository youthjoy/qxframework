using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   /// <summary>
   /// List报表类型配置表
   /// </summary>
   [Serializable]
   public partial class ADOSys_Config_ListPage
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加List报表类型配置表 Sys_Config_ListPage对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Config_ListPage sys_Config_ListPage)
      {
         string sql = "INSERT INTO Sys_Config_ListPage (M_ModuleCode,M_TableName,M_NameSpace,M_SQL,M_Type,M_Title,M_AutoWidth,M_Width,M_Height,M_URL,M_MType,M_GetDataType,M_SQLParameter,M_RowNum,M_RowList,M_FooterRow,M_ViewURL,M_ViewType,M_Edit,M_EditUrl,M_EditSubmitUrl,M_OnSelectRow,M_GridComplete,M_InlineEditing,M_ImportURL,M_ImportTable,M_ImportExport,M_AltRows,M_Altclass,M_emptyrecords,M_Gridstate,M_EditCloumNum,M_ToolBar,M_ToolBarExtend,Stat,M_ExtendsJs,M_ExtendsControl,M_EditTitle,M_MSelect,M_Parameters,M_GroupingView,M_FormEditing,M_FormMethod,M_IsAdd,M_IsEdit,M_IsDelete,M_IsView) VALUES (@M_ModuleCode,@M_TableName,@M_NameSpace,@M_SQL,@M_Type,@M_Title,@M_AutoWidth,@M_Width,@M_Height,@M_URL,@M_MType,@M_GetDataType,@M_SQLParameter,@M_RowNum,@M_RowList,@M_FooterRow,@M_ViewURL,@M_ViewType,@M_Edit,@M_EditUrl,@M_EditSubmitUrl,@M_OnSelectRow,@M_GridComplete,@M_InlineEditing,@M_ImportURL,@M_ImportTable,@M_ImportExport,@M_AltRows,@M_Altclass,@M_emptyrecords,@M_Gridstate,@M_EditCloumNum,@M_ToolBar,@M_ToolBarExtend,@Stat,@M_ExtendsJs,@M_ExtendsControl,@M_EditTitle,@M_MSelect,@M_Parameters,@M_GroupingView,@M_FormEditing,@M_FormMethod,@M_IsAdd,@M_IsEdit,@M_IsDelete,@M_IsView)";
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ModuleCode))
         {
            idb.AddParameter("@M_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ModuleCode", sys_Config_ListPage.M_ModuleCode);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_TableName))
         {
            idb.AddParameter("@M_TableName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_TableName", sys_Config_ListPage.M_TableName);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_NameSpace))
         {
            idb.AddParameter("@M_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_NameSpace", sys_Config_ListPage.M_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_SQL))
         {
            idb.AddParameter("@M_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_SQL", sys_Config_ListPage.M_SQL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Type))
         {
            idb.AddParameter("@M_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Type", sys_Config_ListPage.M_Type);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Title))
         {
            idb.AddParameter("@M_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Title", sys_Config_ListPage.M_Title);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_AutoWidth))
         {
            idb.AddParameter("@M_AutoWidth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_AutoWidth", sys_Config_ListPage.M_AutoWidth);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Width))
         {
            idb.AddParameter("@M_Width", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Width", sys_Config_ListPage.M_Width);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Height))
         {
            idb.AddParameter("@M_Height", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Height", sys_Config_ListPage.M_Height);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_URL))
         {
            idb.AddParameter("@M_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_URL", sys_Config_ListPage.M_URL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_MType))
         {
            idb.AddParameter("@M_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_MType", sys_Config_ListPage.M_MType);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GetDataType))
         {
            idb.AddParameter("@M_GetDataType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GetDataType", sys_Config_ListPage.M_GetDataType);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_SQLParameter))
         {
            idb.AddParameter("@M_SQLParameter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_SQLParameter", sys_Config_ListPage.M_SQLParameter);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_RowNum))
         {
            idb.AddParameter("@M_RowNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_RowNum", sys_Config_ListPage.M_RowNum);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_RowList))
         {
            idb.AddParameter("@M_RowList", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_RowList", sys_Config_ListPage.M_RowList);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FooterRow))
         {
            idb.AddParameter("@M_FooterRow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FooterRow", sys_Config_ListPage.M_FooterRow);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ViewURL))
         {
            idb.AddParameter("@M_ViewURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ViewURL", sys_Config_ListPage.M_ViewURL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ViewType))
         {
            idb.AddParameter("@M_ViewType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ViewType", sys_Config_ListPage.M_ViewType);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Edit))
         {
            idb.AddParameter("@M_Edit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Edit", sys_Config_ListPage.M_Edit);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditUrl))
         {
            idb.AddParameter("@M_EditUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditUrl", sys_Config_ListPage.M_EditUrl);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditSubmitUrl))
         {
            idb.AddParameter("@M_EditSubmitUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditSubmitUrl", sys_Config_ListPage.M_EditSubmitUrl);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_OnSelectRow))
         {
            idb.AddParameter("@M_OnSelectRow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_OnSelectRow", sys_Config_ListPage.M_OnSelectRow);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GridComplete))
         {
            idb.AddParameter("@M_GridComplete", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GridComplete", sys_Config_ListPage.M_GridComplete);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_InlineEditing))
         {
            idb.AddParameter("@M_InlineEditing", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_InlineEditing", sys_Config_ListPage.M_InlineEditing);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportURL))
         {
            idb.AddParameter("@M_ImportURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportURL", sys_Config_ListPage.M_ImportURL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportTable))
         {
            idb.AddParameter("@M_ImportTable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportTable", sys_Config_ListPage.M_ImportTable);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportExport))
         {
            idb.AddParameter("@M_ImportExport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportExport", sys_Config_ListPage.M_ImportExport);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_AltRows))
         {
            idb.AddParameter("@M_AltRows", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_AltRows", sys_Config_ListPage.M_AltRows);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Altclass))
         {
            idb.AddParameter("@M_Altclass", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Altclass", sys_Config_ListPage.M_Altclass);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_emptyrecords))
         {
            idb.AddParameter("@M_emptyrecords", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_emptyrecords", sys_Config_ListPage.M_emptyrecords);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Gridstate))
         {
            idb.AddParameter("@M_Gridstate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Gridstate", sys_Config_ListPage.M_Gridstate);
         }
         if (sys_Config_ListPage.M_EditCloumNum == 0)
         {
            idb.AddParameter("@M_EditCloumNum", 0);
         }
         else
         {
            idb.AddParameter("@M_EditCloumNum", sys_Config_ListPage.M_EditCloumNum);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ToolBar))
         {
            idb.AddParameter("@M_ToolBar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ToolBar", sys_Config_ListPage.M_ToolBar);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ToolBarExtend))
         {
            idb.AddParameter("@M_ToolBarExtend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ToolBarExtend", sys_Config_ListPage.M_ToolBarExtend);
         }
         if (sys_Config_ListPage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_ListPage.Stat);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ExtendsJs))
         {
            idb.AddParameter("@M_ExtendsJs", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ExtendsJs", sys_Config_ListPage.M_ExtendsJs);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ExtendsControl))
         {
            idb.AddParameter("@M_ExtendsControl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ExtendsControl", sys_Config_ListPage.M_ExtendsControl);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditTitle))
         {
            idb.AddParameter("@M_EditTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditTitle", sys_Config_ListPage.M_EditTitle);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_MSelect))
         {
            idb.AddParameter("@M_MSelect", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_MSelect", sys_Config_ListPage.M_MSelect);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Parameters))
         {
            idb.AddParameter("@M_Parameters", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Parameters", sys_Config_ListPage.M_Parameters);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GroupingView))
         {
            idb.AddParameter("@M_GroupingView", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GroupingView", sys_Config_ListPage.M_GroupingView);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FormEditing))
         {
            idb.AddParameter("@M_FormEditing", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FormEditing", sys_Config_ListPage.M_FormEditing);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FormMethod))
         {
            idb.AddParameter("@M_FormMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FormMethod", sys_Config_ListPage.M_FormMethod);
         }
         if (sys_Config_ListPage.M_IsAdd == 0)
         {
            idb.AddParameter("@M_IsAdd", 0);
         }
         else
         {
            idb.AddParameter("@M_IsAdd", sys_Config_ListPage.M_IsAdd);
         }
         if (sys_Config_ListPage.M_IsEdit == 0)
         {
            idb.AddParameter("@M_IsEdit", 0);
         }
         else
         {
            idb.AddParameter("@M_IsEdit", sys_Config_ListPage.M_IsEdit);
         }
         if (sys_Config_ListPage.M_IsDelete == 0)
         {
            idb.AddParameter("@M_IsDelete", 0);
         }
         else
         {
            idb.AddParameter("@M_IsDelete", sys_Config_ListPage.M_IsDelete);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_IsView))
         {
            idb.AddParameter("@M_IsView", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_IsView", sys_Config_ListPage.M_IsView);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加List报表类型配置表 Sys_Config_ListPage对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Config_ListPage sys_Config_ListPage)
      {
         string sql = "INSERT INTO Sys_Config_ListPage (M_ModuleCode,M_TableName,M_NameSpace,M_SQL,M_Type,M_Title,M_AutoWidth,M_Width,M_Height,M_URL,M_MType,M_GetDataType,M_SQLParameter,M_RowNum,M_RowList,M_FooterRow,M_ViewURL,M_ViewType,M_Edit,M_EditUrl,M_EditSubmitUrl,M_OnSelectRow,M_GridComplete,M_InlineEditing,M_ImportURL,M_ImportTable,M_ImportExport,M_AltRows,M_Altclass,M_emptyrecords,M_Gridstate,M_EditCloumNum,M_ToolBar,M_ToolBarExtend,Stat,M_ExtendsJs,M_ExtendsControl,M_EditTitle,M_MSelect,M_Parameters,M_GroupingView,M_FormEditing,M_FormMethod,M_IsAdd,M_IsEdit,M_IsDelete,M_IsView) VALUES (@M_ModuleCode,@M_TableName,@M_NameSpace,@M_SQL,@M_Type,@M_Title,@M_AutoWidth,@M_Width,@M_Height,@M_URL,@M_MType,@M_GetDataType,@M_SQLParameter,@M_RowNum,@M_RowList,@M_FooterRow,@M_ViewURL,@M_ViewType,@M_Edit,@M_EditUrl,@M_EditSubmitUrl,@M_OnSelectRow,@M_GridComplete,@M_InlineEditing,@M_ImportURL,@M_ImportTable,@M_ImportExport,@M_AltRows,@M_Altclass,@M_emptyrecords,@M_Gridstate,@M_EditCloumNum,@M_ToolBar,@M_ToolBarExtend,@Stat,@M_ExtendsJs,@M_ExtendsControl,@M_EditTitle,@M_MSelect,@M_Parameters,@M_GroupingView,@M_FormEditing,@M_FormMethod,@M_IsAdd,@M_IsEdit,@M_IsDelete,@M_IsView);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ModuleCode))
         {
            idb.AddParameter("@M_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ModuleCode", sys_Config_ListPage.M_ModuleCode);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_TableName))
         {
            idb.AddParameter("@M_TableName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_TableName", sys_Config_ListPage.M_TableName);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_NameSpace))
         {
            idb.AddParameter("@M_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_NameSpace", sys_Config_ListPage.M_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_SQL))
         {
            idb.AddParameter("@M_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_SQL", sys_Config_ListPage.M_SQL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Type))
         {
            idb.AddParameter("@M_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Type", sys_Config_ListPage.M_Type);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Title))
         {
            idb.AddParameter("@M_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Title", sys_Config_ListPage.M_Title);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_AutoWidth))
         {
            idb.AddParameter("@M_AutoWidth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_AutoWidth", sys_Config_ListPage.M_AutoWidth);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Width))
         {
            idb.AddParameter("@M_Width", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Width", sys_Config_ListPage.M_Width);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Height))
         {
            idb.AddParameter("@M_Height", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Height", sys_Config_ListPage.M_Height);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_URL))
         {
            idb.AddParameter("@M_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_URL", sys_Config_ListPage.M_URL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_MType))
         {
            idb.AddParameter("@M_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_MType", sys_Config_ListPage.M_MType);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GetDataType))
         {
            idb.AddParameter("@M_GetDataType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GetDataType", sys_Config_ListPage.M_GetDataType);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_SQLParameter))
         {
            idb.AddParameter("@M_SQLParameter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_SQLParameter", sys_Config_ListPage.M_SQLParameter);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_RowNum))
         {
            idb.AddParameter("@M_RowNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_RowNum", sys_Config_ListPage.M_RowNum);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_RowList))
         {
            idb.AddParameter("@M_RowList", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_RowList", sys_Config_ListPage.M_RowList);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FooterRow))
         {
            idb.AddParameter("@M_FooterRow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FooterRow", sys_Config_ListPage.M_FooterRow);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ViewURL))
         {
            idb.AddParameter("@M_ViewURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ViewURL", sys_Config_ListPage.M_ViewURL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ViewType))
         {
            idb.AddParameter("@M_ViewType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ViewType", sys_Config_ListPage.M_ViewType);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Edit))
         {
            idb.AddParameter("@M_Edit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Edit", sys_Config_ListPage.M_Edit);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditUrl))
         {
            idb.AddParameter("@M_EditUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditUrl", sys_Config_ListPage.M_EditUrl);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditSubmitUrl))
         {
            idb.AddParameter("@M_EditSubmitUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditSubmitUrl", sys_Config_ListPage.M_EditSubmitUrl);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_OnSelectRow))
         {
            idb.AddParameter("@M_OnSelectRow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_OnSelectRow", sys_Config_ListPage.M_OnSelectRow);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GridComplete))
         {
            idb.AddParameter("@M_GridComplete", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GridComplete", sys_Config_ListPage.M_GridComplete);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_InlineEditing))
         {
            idb.AddParameter("@M_InlineEditing", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_InlineEditing", sys_Config_ListPage.M_InlineEditing);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportURL))
         {
            idb.AddParameter("@M_ImportURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportURL", sys_Config_ListPage.M_ImportURL);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportTable))
         {
            idb.AddParameter("@M_ImportTable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportTable", sys_Config_ListPage.M_ImportTable);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportExport))
         {
            idb.AddParameter("@M_ImportExport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportExport", sys_Config_ListPage.M_ImportExport);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_AltRows))
         {
            idb.AddParameter("@M_AltRows", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_AltRows", sys_Config_ListPage.M_AltRows);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Altclass))
         {
            idb.AddParameter("@M_Altclass", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Altclass", sys_Config_ListPage.M_Altclass);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_emptyrecords))
         {
            idb.AddParameter("@M_emptyrecords", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_emptyrecords", sys_Config_ListPage.M_emptyrecords);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Gridstate))
         {
            idb.AddParameter("@M_Gridstate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Gridstate", sys_Config_ListPage.M_Gridstate);
         }
         if (sys_Config_ListPage.M_EditCloumNum == 0)
         {
            idb.AddParameter("@M_EditCloumNum", 0);
         }
         else
         {
            idb.AddParameter("@M_EditCloumNum", sys_Config_ListPage.M_EditCloumNum);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ToolBar))
         {
            idb.AddParameter("@M_ToolBar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ToolBar", sys_Config_ListPage.M_ToolBar);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ToolBarExtend))
         {
            idb.AddParameter("@M_ToolBarExtend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ToolBarExtend", sys_Config_ListPage.M_ToolBarExtend);
         }
         if (sys_Config_ListPage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_ListPage.Stat);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ExtendsJs))
         {
            idb.AddParameter("@M_ExtendsJs", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ExtendsJs", sys_Config_ListPage.M_ExtendsJs);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ExtendsControl))
         {
            idb.AddParameter("@M_ExtendsControl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ExtendsControl", sys_Config_ListPage.M_ExtendsControl);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditTitle))
         {
            idb.AddParameter("@M_EditTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditTitle", sys_Config_ListPage.M_EditTitle);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_MSelect))
         {
            idb.AddParameter("@M_MSelect", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_MSelect", sys_Config_ListPage.M_MSelect);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Parameters))
         {
            idb.AddParameter("@M_Parameters", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Parameters", sys_Config_ListPage.M_Parameters);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GroupingView))
         {
            idb.AddParameter("@M_GroupingView", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GroupingView", sys_Config_ListPage.M_GroupingView);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FormEditing))
         {
            idb.AddParameter("@M_FormEditing", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FormEditing", sys_Config_ListPage.M_FormEditing);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FormMethod))
         {
            idb.AddParameter("@M_FormMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FormMethod", sys_Config_ListPage.M_FormMethod);
         }
         if (sys_Config_ListPage.M_IsAdd == 0)
         {
            idb.AddParameter("@M_IsAdd", 0);
         }
         else
         {
            idb.AddParameter("@M_IsAdd", sys_Config_ListPage.M_IsAdd);
         }
         if (sys_Config_ListPage.M_IsEdit == 0)
         {
            idb.AddParameter("@M_IsEdit", 0);
         }
         else
         {
            idb.AddParameter("@M_IsEdit", sys_Config_ListPage.M_IsEdit);
         }
         if (sys_Config_ListPage.M_IsDelete == 0)
         {
            idb.AddParameter("@M_IsDelete", 0);
         }
         else
         {
            idb.AddParameter("@M_IsDelete", sys_Config_ListPage.M_IsDelete);
         }
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_IsView))
         {
            idb.AddParameter("@M_IsView", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_IsView", sys_Config_ListPage.M_IsView);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新List报表类型配置表 Sys_Config_ListPage对象(即:一条记录
      /// </summary>
      public int Update(Sys_Config_ListPage sys_Config_ListPage)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Config_ListPage       SET ");
            if(sys_Config_ListPage.M_ModuleCode_IsChanged){sbParameter.Append("M_ModuleCode=@M_ModuleCode, ");}
      if(sys_Config_ListPage.M_TableName_IsChanged){sbParameter.Append("M_TableName=@M_TableName, ");}
      if(sys_Config_ListPage.M_NameSpace_IsChanged){sbParameter.Append("M_NameSpace=@M_NameSpace, ");}
      if(sys_Config_ListPage.M_SQL_IsChanged){sbParameter.Append("M_SQL=@M_SQL, ");}
      if(sys_Config_ListPage.M_Type_IsChanged){sbParameter.Append("M_Type=@M_Type, ");}
      if(sys_Config_ListPage.M_Title_IsChanged){sbParameter.Append("M_Title=@M_Title, ");}
      if(sys_Config_ListPage.M_AutoWidth_IsChanged){sbParameter.Append("M_AutoWidth=@M_AutoWidth, ");}
      if(sys_Config_ListPage.M_Width_IsChanged){sbParameter.Append("M_Width=@M_Width, ");}
      if(sys_Config_ListPage.M_Height_IsChanged){sbParameter.Append("M_Height=@M_Height, ");}
      if(sys_Config_ListPage.M_URL_IsChanged){sbParameter.Append("M_URL=@M_URL, ");}
      if(sys_Config_ListPage.M_MType_IsChanged){sbParameter.Append("M_MType=@M_MType, ");}
      if(sys_Config_ListPage.M_GetDataType_IsChanged){sbParameter.Append("M_GetDataType=@M_GetDataType, ");}
      if(sys_Config_ListPage.M_SQLParameter_IsChanged){sbParameter.Append("M_SQLParameter=@M_SQLParameter, ");}
      if(sys_Config_ListPage.M_RowNum_IsChanged){sbParameter.Append("M_RowNum=@M_RowNum, ");}
      if(sys_Config_ListPage.M_RowList_IsChanged){sbParameter.Append("M_RowList=@M_RowList, ");}
      if(sys_Config_ListPage.M_FooterRow_IsChanged){sbParameter.Append("M_FooterRow=@M_FooterRow, ");}
      if(sys_Config_ListPage.M_ViewURL_IsChanged){sbParameter.Append("M_ViewURL=@M_ViewURL, ");}
      if(sys_Config_ListPage.M_ViewType_IsChanged){sbParameter.Append("M_ViewType=@M_ViewType, ");}
      if(sys_Config_ListPage.M_Edit_IsChanged){sbParameter.Append("M_Edit=@M_Edit, ");}
      if(sys_Config_ListPage.M_EditUrl_IsChanged){sbParameter.Append("M_EditUrl=@M_EditUrl, ");}
      if(sys_Config_ListPage.M_EditSubmitUrl_IsChanged){sbParameter.Append("M_EditSubmitUrl=@M_EditSubmitUrl, ");}
      if(sys_Config_ListPage.M_OnSelectRow_IsChanged){sbParameter.Append("M_OnSelectRow=@M_OnSelectRow, ");}
      if(sys_Config_ListPage.M_GridComplete_IsChanged){sbParameter.Append("M_GridComplete=@M_GridComplete, ");}
      if(sys_Config_ListPage.M_InlineEditing_IsChanged){sbParameter.Append("M_InlineEditing=@M_InlineEditing, ");}
      if(sys_Config_ListPage.M_ImportURL_IsChanged){sbParameter.Append("M_ImportURL=@M_ImportURL, ");}
      if(sys_Config_ListPage.M_ImportTable_IsChanged){sbParameter.Append("M_ImportTable=@M_ImportTable, ");}
      if(sys_Config_ListPage.M_ImportExport_IsChanged){sbParameter.Append("M_ImportExport=@M_ImportExport, ");}
      if(sys_Config_ListPage.M_AltRows_IsChanged){sbParameter.Append("M_AltRows=@M_AltRows, ");}
      if(sys_Config_ListPage.M_Altclass_IsChanged){sbParameter.Append("M_Altclass=@M_Altclass, ");}
      if(sys_Config_ListPage.M_emptyrecords_IsChanged){sbParameter.Append("M_emptyrecords=@M_emptyrecords, ");}
      if(sys_Config_ListPage.M_Gridstate_IsChanged){sbParameter.Append("M_Gridstate=@M_Gridstate, ");}
      if(sys_Config_ListPage.M_EditCloumNum_IsChanged){sbParameter.Append("M_EditCloumNum=@M_EditCloumNum, ");}
      if(sys_Config_ListPage.M_ToolBar_IsChanged){sbParameter.Append("M_ToolBar=@M_ToolBar, ");}
      if(sys_Config_ListPage.M_ToolBarExtend_IsChanged){sbParameter.Append("M_ToolBarExtend=@M_ToolBarExtend, ");}
      if(sys_Config_ListPage.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_Config_ListPage.M_ExtendsJs_IsChanged){sbParameter.Append("M_ExtendsJs=@M_ExtendsJs, ");}
      if(sys_Config_ListPage.M_ExtendsControl_IsChanged){sbParameter.Append("M_ExtendsControl=@M_ExtendsControl, ");}
      if(sys_Config_ListPage.M_EditTitle_IsChanged){sbParameter.Append("M_EditTitle=@M_EditTitle, ");}
      if(sys_Config_ListPage.M_MSelect_IsChanged){sbParameter.Append("M_MSelect=@M_MSelect, ");}
      if(sys_Config_ListPage.M_Parameters_IsChanged){sbParameter.Append("M_Parameters=@M_Parameters, ");}
      if(sys_Config_ListPage.M_GroupingView_IsChanged){sbParameter.Append("M_GroupingView=@M_GroupingView, ");}
      if(sys_Config_ListPage.M_FormEditing_IsChanged){sbParameter.Append("M_FormEditing=@M_FormEditing, ");}
      if(sys_Config_ListPage.M_FormMethod_IsChanged){sbParameter.Append("M_FormMethod=@M_FormMethod, ");}
      if(sys_Config_ListPage.M_IsAdd_IsChanged){sbParameter.Append("M_IsAdd=@M_IsAdd, ");}
      if(sys_Config_ListPage.M_IsEdit_IsChanged){sbParameter.Append("M_IsEdit=@M_IsEdit, ");}
      if(sys_Config_ListPage.M_IsDelete_IsChanged){sbParameter.Append("M_IsDelete=@M_IsDelete, ");}
      if(sys_Config_ListPage.M_IsView_IsChanged){sbParameter.Append("M_IsView=@M_IsView ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and M_ID=@M_ID; " );
      string sql=sb.ToString();
         if(sys_Config_ListPage.M_ModuleCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ModuleCode))
         {
            idb.AddParameter("@M_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ModuleCode", sys_Config_ListPage.M_ModuleCode);
         }
          }
         if(sys_Config_ListPage.M_TableName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_TableName))
         {
            idb.AddParameter("@M_TableName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_TableName", sys_Config_ListPage.M_TableName);
         }
          }
         if(sys_Config_ListPage.M_NameSpace_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_NameSpace))
         {
            idb.AddParameter("@M_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_NameSpace", sys_Config_ListPage.M_NameSpace);
         }
          }
         if(sys_Config_ListPage.M_SQL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_SQL))
         {
            idb.AddParameter("@M_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_SQL", sys_Config_ListPage.M_SQL);
         }
          }
         if(sys_Config_ListPage.M_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Type))
         {
            idb.AddParameter("@M_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Type", sys_Config_ListPage.M_Type);
         }
          }
         if(sys_Config_ListPage.M_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Title))
         {
            idb.AddParameter("@M_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Title", sys_Config_ListPage.M_Title);
         }
          }
         if(sys_Config_ListPage.M_AutoWidth_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_AutoWidth))
         {
            idb.AddParameter("@M_AutoWidth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_AutoWidth", sys_Config_ListPage.M_AutoWidth);
         }
          }
         if(sys_Config_ListPage.M_Width_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Width))
         {
            idb.AddParameter("@M_Width", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Width", sys_Config_ListPage.M_Width);
         }
          }
         if(sys_Config_ListPage.M_Height_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Height))
         {
            idb.AddParameter("@M_Height", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Height", sys_Config_ListPage.M_Height);
         }
          }
         if(sys_Config_ListPage.M_URL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_URL))
         {
            idb.AddParameter("@M_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_URL", sys_Config_ListPage.M_URL);
         }
          }
         if(sys_Config_ListPage.M_MType_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_MType))
         {
            idb.AddParameter("@M_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_MType", sys_Config_ListPage.M_MType);
         }
          }
         if(sys_Config_ListPage.M_GetDataType_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GetDataType))
         {
            idb.AddParameter("@M_GetDataType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GetDataType", sys_Config_ListPage.M_GetDataType);
         }
          }
         if(sys_Config_ListPage.M_SQLParameter_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_SQLParameter))
         {
            idb.AddParameter("@M_SQLParameter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_SQLParameter", sys_Config_ListPage.M_SQLParameter);
         }
          }
         if(sys_Config_ListPage.M_RowNum_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_RowNum))
         {
            idb.AddParameter("@M_RowNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_RowNum", sys_Config_ListPage.M_RowNum);
         }
          }
         if(sys_Config_ListPage.M_RowList_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_RowList))
         {
            idb.AddParameter("@M_RowList", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_RowList", sys_Config_ListPage.M_RowList);
         }
          }
         if(sys_Config_ListPage.M_FooterRow_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FooterRow))
         {
            idb.AddParameter("@M_FooterRow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FooterRow", sys_Config_ListPage.M_FooterRow);
         }
          }
         if(sys_Config_ListPage.M_ViewURL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ViewURL))
         {
            idb.AddParameter("@M_ViewURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ViewURL", sys_Config_ListPage.M_ViewURL);
         }
          }
         if(sys_Config_ListPage.M_ViewType_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ViewType))
         {
            idb.AddParameter("@M_ViewType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ViewType", sys_Config_ListPage.M_ViewType);
         }
          }
         if(sys_Config_ListPage.M_Edit_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Edit))
         {
            idb.AddParameter("@M_Edit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Edit", sys_Config_ListPage.M_Edit);
         }
          }
         if(sys_Config_ListPage.M_EditUrl_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditUrl))
         {
            idb.AddParameter("@M_EditUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditUrl", sys_Config_ListPage.M_EditUrl);
         }
          }
         if(sys_Config_ListPage.M_EditSubmitUrl_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditSubmitUrl))
         {
            idb.AddParameter("@M_EditSubmitUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditSubmitUrl", sys_Config_ListPage.M_EditSubmitUrl);
         }
          }
         if(sys_Config_ListPage.M_OnSelectRow_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_OnSelectRow))
         {
            idb.AddParameter("@M_OnSelectRow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_OnSelectRow", sys_Config_ListPage.M_OnSelectRow);
         }
          }
         if(sys_Config_ListPage.M_GridComplete_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GridComplete))
         {
            idb.AddParameter("@M_GridComplete", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GridComplete", sys_Config_ListPage.M_GridComplete);
         }
          }
         if(sys_Config_ListPage.M_InlineEditing_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_InlineEditing))
         {
            idb.AddParameter("@M_InlineEditing", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_InlineEditing", sys_Config_ListPage.M_InlineEditing);
         }
          }
         if(sys_Config_ListPage.M_ImportURL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportURL))
         {
            idb.AddParameter("@M_ImportURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportURL", sys_Config_ListPage.M_ImportURL);
         }
          }
         if(sys_Config_ListPage.M_ImportTable_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportTable))
         {
            idb.AddParameter("@M_ImportTable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportTable", sys_Config_ListPage.M_ImportTable);
         }
          }
         if(sys_Config_ListPage.M_ImportExport_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ImportExport))
         {
            idb.AddParameter("@M_ImportExport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ImportExport", sys_Config_ListPage.M_ImportExport);
         }
          }
         if(sys_Config_ListPage.M_AltRows_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_AltRows))
         {
            idb.AddParameter("@M_AltRows", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_AltRows", sys_Config_ListPage.M_AltRows);
         }
          }
         if(sys_Config_ListPage.M_Altclass_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Altclass))
         {
            idb.AddParameter("@M_Altclass", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Altclass", sys_Config_ListPage.M_Altclass);
         }
          }
         if(sys_Config_ListPage.M_emptyrecords_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_emptyrecords))
         {
            idb.AddParameter("@M_emptyrecords", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_emptyrecords", sys_Config_ListPage.M_emptyrecords);
         }
          }
         if(sys_Config_ListPage.M_Gridstate_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Gridstate))
         {
            idb.AddParameter("@M_Gridstate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Gridstate", sys_Config_ListPage.M_Gridstate);
         }
          }
         if(sys_Config_ListPage.M_EditCloumNum_IsChanged)
         {
         if (sys_Config_ListPage.M_EditCloumNum == 0)
         {
            idb.AddParameter("@M_EditCloumNum", 0);
         }
         else
         {
            idb.AddParameter("@M_EditCloumNum", sys_Config_ListPage.M_EditCloumNum);
         }
          }
         if(sys_Config_ListPage.M_ToolBar_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ToolBar))
         {
            idb.AddParameter("@M_ToolBar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ToolBar", sys_Config_ListPage.M_ToolBar);
         }
          }
         if(sys_Config_ListPage.M_ToolBarExtend_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ToolBarExtend))
         {
            idb.AddParameter("@M_ToolBarExtend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ToolBarExtend", sys_Config_ListPage.M_ToolBarExtend);
         }
          }
         if(sys_Config_ListPage.Stat_IsChanged)
         {
         if (sys_Config_ListPage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_ListPage.Stat);
         }
          }
         if(sys_Config_ListPage.M_ExtendsJs_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ExtendsJs))
         {
            idb.AddParameter("@M_ExtendsJs", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ExtendsJs", sys_Config_ListPage.M_ExtendsJs);
         }
          }
         if(sys_Config_ListPage.M_ExtendsControl_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_ExtendsControl))
         {
            idb.AddParameter("@M_ExtendsControl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_ExtendsControl", sys_Config_ListPage.M_ExtendsControl);
         }
          }
         if(sys_Config_ListPage.M_EditTitle_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_EditTitle))
         {
            idb.AddParameter("@M_EditTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_EditTitle", sys_Config_ListPage.M_EditTitle);
         }
          }
         if(sys_Config_ListPage.M_MSelect_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_MSelect))
         {
            idb.AddParameter("@M_MSelect", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_MSelect", sys_Config_ListPage.M_MSelect);
         }
          }
         if(sys_Config_ListPage.M_Parameters_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_Parameters))
         {
            idb.AddParameter("@M_Parameters", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_Parameters", sys_Config_ListPage.M_Parameters);
         }
          }
         if(sys_Config_ListPage.M_GroupingView_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_GroupingView))
         {
            idb.AddParameter("@M_GroupingView", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_GroupingView", sys_Config_ListPage.M_GroupingView);
         }
          }
         if(sys_Config_ListPage.M_FormEditing_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FormEditing))
         {
            idb.AddParameter("@M_FormEditing", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FormEditing", sys_Config_ListPage.M_FormEditing);
         }
          }
         if(sys_Config_ListPage.M_FormMethod_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_FormMethod))
         {
            idb.AddParameter("@M_FormMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_FormMethod", sys_Config_ListPage.M_FormMethod);
         }
          }
         if(sys_Config_ListPage.M_IsAdd_IsChanged)
         {
         if (sys_Config_ListPage.M_IsAdd == 0)
         {
            idb.AddParameter("@M_IsAdd", 0);
         }
         else
         {
            idb.AddParameter("@M_IsAdd", sys_Config_ListPage.M_IsAdd);
         }
          }
         if(sys_Config_ListPage.M_IsEdit_IsChanged)
         {
         if (sys_Config_ListPage.M_IsEdit == 0)
         {
            idb.AddParameter("@M_IsEdit", 0);
         }
         else
         {
            idb.AddParameter("@M_IsEdit", sys_Config_ListPage.M_IsEdit);
         }
          }
         if(sys_Config_ListPage.M_IsDelete_IsChanged)
         {
         if (sys_Config_ListPage.M_IsDelete == 0)
         {
            idb.AddParameter("@M_IsDelete", 0);
         }
         else
         {
            idb.AddParameter("@M_IsDelete", sys_Config_ListPage.M_IsDelete);
         }
          }
         if(sys_Config_ListPage.M_IsView_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_ListPage.M_IsView))
         {
            idb.AddParameter("@M_IsView", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@M_IsView", sys_Config_ListPage.M_IsView);
         }
          }

         idb.AddParameter("@M_ID", sys_Config_ListPage.M_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除List报表类型配置表 Sys_Config_ListPage对象(即:一条记录
      /// </summary>
      public int Delete(int m_ID)
      {
         string sql = "DELETE Sys_Config_ListPage WHERE 1=1  AND M_ID=@M_ID ";
         idb.AddParameter("@M_ID", m_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的List报表类型配置表 Sys_Config_ListPage对象(即:一条记录
      /// </summary>
      public Sys_Config_ListPage GetByKey(int m_ID)
      {
         Sys_Config_ListPage sys_Config_ListPage = new Sys_Config_ListPage();
         string sql = "SELECT  M_ID,M_ModuleCode,M_TableName,M_NameSpace,M_SQL,M_Type,M_Title,M_AutoWidth,M_Width,M_Height,M_URL,M_MType,M_GetDataType,M_SQLParameter,M_RowNum,M_RowList,M_FooterRow,M_ViewURL,M_ViewType,M_Edit,M_EditUrl,M_EditSubmitUrl,M_OnSelectRow,M_GridComplete,M_InlineEditing,M_ImportURL,M_ImportTable,M_ImportExport,M_AltRows,M_Altclass,M_emptyrecords,M_Gridstate,M_EditCloumNum,M_ToolBar,M_ToolBarExtend,Stat,M_ExtendsJs,M_ExtendsControl,M_EditTitle,M_MSelect,M_Parameters,M_GroupingView,M_FormEditing,M_FormMethod,M_IsAdd,M_IsEdit,M_IsDelete,M_IsView FROM Sys_Config_ListPage WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND M_ID=@M_ID ";
         idb.AddParameter("@M_ID", m_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["M_ID"] != DBNull.Value) sys_Config_ListPage.M_ID = Convert.ToInt32(dr["M_ID"]);
            if (dr["M_ModuleCode"] != DBNull.Value) sys_Config_ListPage.M_ModuleCode = Convert.ToString(dr["M_ModuleCode"]);
            if (dr["M_TableName"] != DBNull.Value) sys_Config_ListPage.M_TableName = Convert.ToString(dr["M_TableName"]);
            if (dr["M_NameSpace"] != DBNull.Value) sys_Config_ListPage.M_NameSpace = Convert.ToString(dr["M_NameSpace"]);
            if (dr["M_SQL"] != DBNull.Value) sys_Config_ListPage.M_SQL = Convert.ToString(dr["M_SQL"]);
            if (dr["M_Type"] != DBNull.Value) sys_Config_ListPage.M_Type = Convert.ToString(dr["M_Type"]);
            if (dr["M_Title"] != DBNull.Value) sys_Config_ListPage.M_Title = Convert.ToString(dr["M_Title"]);
            if (dr["M_AutoWidth"] != DBNull.Value) sys_Config_ListPage.M_AutoWidth = Convert.ToString(dr["M_AutoWidth"]);
            if (dr["M_Width"] != DBNull.Value) sys_Config_ListPage.M_Width = Convert.ToString(dr["M_Width"]);
            if (dr["M_Height"] != DBNull.Value) sys_Config_ListPage.M_Height = Convert.ToString(dr["M_Height"]);
            if (dr["M_URL"] != DBNull.Value) sys_Config_ListPage.M_URL = Convert.ToString(dr["M_URL"]);
            if (dr["M_MType"] != DBNull.Value) sys_Config_ListPage.M_MType = Convert.ToString(dr["M_MType"]);
            if (dr["M_GetDataType"] != DBNull.Value) sys_Config_ListPage.M_GetDataType = Convert.ToString(dr["M_GetDataType"]);
            if (dr["M_SQLParameter"] != DBNull.Value) sys_Config_ListPage.M_SQLParameter = Convert.ToString(dr["M_SQLParameter"]);
            if (dr["M_RowNum"] != DBNull.Value) sys_Config_ListPage.M_RowNum = Convert.ToString(dr["M_RowNum"]);
            if (dr["M_RowList"] != DBNull.Value) sys_Config_ListPage.M_RowList = Convert.ToString(dr["M_RowList"]);
            if (dr["M_FooterRow"] != DBNull.Value) sys_Config_ListPage.M_FooterRow = Convert.ToString(dr["M_FooterRow"]);
            if (dr["M_ViewURL"] != DBNull.Value) sys_Config_ListPage.M_ViewURL = Convert.ToString(dr["M_ViewURL"]);
            if (dr["M_ViewType"] != DBNull.Value) sys_Config_ListPage.M_ViewType = Convert.ToString(dr["M_ViewType"]);
            if (dr["M_Edit"] != DBNull.Value) sys_Config_ListPage.M_Edit = Convert.ToString(dr["M_Edit"]);
            if (dr["M_EditUrl"] != DBNull.Value) sys_Config_ListPage.M_EditUrl = Convert.ToString(dr["M_EditUrl"]);
            if (dr["M_EditSubmitUrl"] != DBNull.Value) sys_Config_ListPage.M_EditSubmitUrl = Convert.ToString(dr["M_EditSubmitUrl"]);
            if (dr["M_OnSelectRow"] != DBNull.Value) sys_Config_ListPage.M_OnSelectRow = Convert.ToString(dr["M_OnSelectRow"]);
            if (dr["M_GridComplete"] != DBNull.Value) sys_Config_ListPage.M_GridComplete = Convert.ToString(dr["M_GridComplete"]);
            if (dr["M_InlineEditing"] != DBNull.Value) sys_Config_ListPage.M_InlineEditing = Convert.ToString(dr["M_InlineEditing"]);
            if (dr["M_ImportURL"] != DBNull.Value) sys_Config_ListPage.M_ImportURL = Convert.ToString(dr["M_ImportURL"]);
            if (dr["M_ImportTable"] != DBNull.Value) sys_Config_ListPage.M_ImportTable = Convert.ToString(dr["M_ImportTable"]);
            if (dr["M_ImportExport"] != DBNull.Value) sys_Config_ListPage.M_ImportExport = Convert.ToString(dr["M_ImportExport"]);
            if (dr["M_AltRows"] != DBNull.Value) sys_Config_ListPage.M_AltRows = Convert.ToString(dr["M_AltRows"]);
            if (dr["M_Altclass"] != DBNull.Value) sys_Config_ListPage.M_Altclass = Convert.ToString(dr["M_Altclass"]);
            if (dr["M_emptyrecords"] != DBNull.Value) sys_Config_ListPage.M_emptyrecords = Convert.ToString(dr["M_emptyrecords"]);
            if (dr["M_Gridstate"] != DBNull.Value) sys_Config_ListPage.M_Gridstate = Convert.ToString(dr["M_Gridstate"]);
            if (dr["M_EditCloumNum"] != DBNull.Value) sys_Config_ListPage.M_EditCloumNum = Convert.ToInt32(dr["M_EditCloumNum"]);
            if (dr["M_ToolBar"] != DBNull.Value) sys_Config_ListPage.M_ToolBar = Convert.ToString(dr["M_ToolBar"]);
            if (dr["M_ToolBarExtend"] != DBNull.Value) sys_Config_ListPage.M_ToolBarExtend = Convert.ToString(dr["M_ToolBarExtend"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_ListPage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["M_ExtendsJs"] != DBNull.Value) sys_Config_ListPage.M_ExtendsJs = Convert.ToString(dr["M_ExtendsJs"]);
            if (dr["M_ExtendsControl"] != DBNull.Value) sys_Config_ListPage.M_ExtendsControl = Convert.ToString(dr["M_ExtendsControl"]);
            if (dr["M_EditTitle"] != DBNull.Value) sys_Config_ListPage.M_EditTitle = Convert.ToString(dr["M_EditTitle"]);
            if (dr["M_MSelect"] != DBNull.Value) sys_Config_ListPage.M_MSelect = Convert.ToString(dr["M_MSelect"]);
            if (dr["M_Parameters"] != DBNull.Value) sys_Config_ListPage.M_Parameters = Convert.ToString(dr["M_Parameters"]);
            if (dr["M_GroupingView"] != DBNull.Value) sys_Config_ListPage.M_GroupingView = Convert.ToString(dr["M_GroupingView"]);
            if (dr["M_FormEditing"] != DBNull.Value) sys_Config_ListPage.M_FormEditing = Convert.ToString(dr["M_FormEditing"]);
            if (dr["M_FormMethod"] != DBNull.Value) sys_Config_ListPage.M_FormMethod = Convert.ToString(dr["M_FormMethod"]);
            if (dr["M_IsAdd"] != DBNull.Value) sys_Config_ListPage.M_IsAdd = Convert.ToInt32(dr["M_IsAdd"]);
            if (dr["M_IsEdit"] != DBNull.Value) sys_Config_ListPage.M_IsEdit = Convert.ToInt32(dr["M_IsEdit"]);
            if (dr["M_IsDelete"] != DBNull.Value) sys_Config_ListPage.M_IsDelete = Convert.ToInt32(dr["M_IsDelete"]);
            if (dr["M_IsView"] != DBNull.Value) sys_Config_ListPage.M_IsView = Convert.ToString(dr["M_IsView"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Config_ListPage;
      }
      /// <summary>
      /// 获取指定的List报表类型配置表 Sys_Config_ListPage对象集合
      /// </summary>
      public List<Sys_Config_ListPage> GetListByWhere(string strCondition)
      {
         List<Sys_Config_ListPage> ret = new List<Sys_Config_ListPage>();
         string sql = "SELECT  M_ID,M_ModuleCode,M_TableName,M_NameSpace,M_SQL,M_Type,M_Title,M_AutoWidth,M_Width,M_Height,M_URL,M_MType,M_GetDataType,M_SQLParameter,M_RowNum,M_RowList,M_FooterRow,M_ViewURL,M_ViewType,M_Edit,M_EditUrl,M_EditSubmitUrl,M_OnSelectRow,M_GridComplete,M_InlineEditing,M_ImportURL,M_ImportTable,M_ImportExport,M_AltRows,M_Altclass,M_emptyrecords,M_Gridstate,M_EditCloumNum,M_ToolBar,M_ToolBarExtend,Stat,M_ExtendsJs,M_ExtendsControl,M_EditTitle,M_MSelect,M_Parameters,M_GroupingView,M_FormEditing,M_FormMethod,M_IsAdd,M_IsEdit,M_IsDelete,M_IsView FROM Sys_Config_ListPage WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY M_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_ListPage sys_Config_ListPage = new Sys_Config_ListPage();
            if (dr["M_ID"] != DBNull.Value) sys_Config_ListPage.M_ID = Convert.ToInt32(dr["M_ID"]);
            if (dr["M_ModuleCode"] != DBNull.Value) sys_Config_ListPage.M_ModuleCode = Convert.ToString(dr["M_ModuleCode"]);
            if (dr["M_TableName"] != DBNull.Value) sys_Config_ListPage.M_TableName = Convert.ToString(dr["M_TableName"]);
            if (dr["M_NameSpace"] != DBNull.Value) sys_Config_ListPage.M_NameSpace = Convert.ToString(dr["M_NameSpace"]);
            if (dr["M_SQL"] != DBNull.Value) sys_Config_ListPage.M_SQL = Convert.ToString(dr["M_SQL"]);
            if (dr["M_Type"] != DBNull.Value) sys_Config_ListPage.M_Type = Convert.ToString(dr["M_Type"]);
            if (dr["M_Title"] != DBNull.Value) sys_Config_ListPage.M_Title = Convert.ToString(dr["M_Title"]);
            if (dr["M_AutoWidth"] != DBNull.Value) sys_Config_ListPage.M_AutoWidth = Convert.ToString(dr["M_AutoWidth"]);
            if (dr["M_Width"] != DBNull.Value) sys_Config_ListPage.M_Width = Convert.ToString(dr["M_Width"]);
            if (dr["M_Height"] != DBNull.Value) sys_Config_ListPage.M_Height = Convert.ToString(dr["M_Height"]);
            if (dr["M_URL"] != DBNull.Value) sys_Config_ListPage.M_URL = Convert.ToString(dr["M_URL"]);
            if (dr["M_MType"] != DBNull.Value) sys_Config_ListPage.M_MType = Convert.ToString(dr["M_MType"]);
            if (dr["M_GetDataType"] != DBNull.Value) sys_Config_ListPage.M_GetDataType = Convert.ToString(dr["M_GetDataType"]);
            if (dr["M_SQLParameter"] != DBNull.Value) sys_Config_ListPage.M_SQLParameter = Convert.ToString(dr["M_SQLParameter"]);
            if (dr["M_RowNum"] != DBNull.Value) sys_Config_ListPage.M_RowNum = Convert.ToString(dr["M_RowNum"]);
            if (dr["M_RowList"] != DBNull.Value) sys_Config_ListPage.M_RowList = Convert.ToString(dr["M_RowList"]);
            if (dr["M_FooterRow"] != DBNull.Value) sys_Config_ListPage.M_FooterRow = Convert.ToString(dr["M_FooterRow"]);
            if (dr["M_ViewURL"] != DBNull.Value) sys_Config_ListPage.M_ViewURL = Convert.ToString(dr["M_ViewURL"]);
            if (dr["M_ViewType"] != DBNull.Value) sys_Config_ListPage.M_ViewType = Convert.ToString(dr["M_ViewType"]);
            if (dr["M_Edit"] != DBNull.Value) sys_Config_ListPage.M_Edit = Convert.ToString(dr["M_Edit"]);
            if (dr["M_EditUrl"] != DBNull.Value) sys_Config_ListPage.M_EditUrl = Convert.ToString(dr["M_EditUrl"]);
            if (dr["M_EditSubmitUrl"] != DBNull.Value) sys_Config_ListPage.M_EditSubmitUrl = Convert.ToString(dr["M_EditSubmitUrl"]);
            if (dr["M_OnSelectRow"] != DBNull.Value) sys_Config_ListPage.M_OnSelectRow = Convert.ToString(dr["M_OnSelectRow"]);
            if (dr["M_GridComplete"] != DBNull.Value) sys_Config_ListPage.M_GridComplete = Convert.ToString(dr["M_GridComplete"]);
            if (dr["M_InlineEditing"] != DBNull.Value) sys_Config_ListPage.M_InlineEditing = Convert.ToString(dr["M_InlineEditing"]);
            if (dr["M_ImportURL"] != DBNull.Value) sys_Config_ListPage.M_ImportURL = Convert.ToString(dr["M_ImportURL"]);
            if (dr["M_ImportTable"] != DBNull.Value) sys_Config_ListPage.M_ImportTable = Convert.ToString(dr["M_ImportTable"]);
            if (dr["M_ImportExport"] != DBNull.Value) sys_Config_ListPage.M_ImportExport = Convert.ToString(dr["M_ImportExport"]);
            if (dr["M_AltRows"] != DBNull.Value) sys_Config_ListPage.M_AltRows = Convert.ToString(dr["M_AltRows"]);
            if (dr["M_Altclass"] != DBNull.Value) sys_Config_ListPage.M_Altclass = Convert.ToString(dr["M_Altclass"]);
            if (dr["M_emptyrecords"] != DBNull.Value) sys_Config_ListPage.M_emptyrecords = Convert.ToString(dr["M_emptyrecords"]);
            if (dr["M_Gridstate"] != DBNull.Value) sys_Config_ListPage.M_Gridstate = Convert.ToString(dr["M_Gridstate"]);
            if (dr["M_EditCloumNum"] != DBNull.Value) sys_Config_ListPage.M_EditCloumNum = Convert.ToInt32(dr["M_EditCloumNum"]);
            if (dr["M_ToolBar"] != DBNull.Value) sys_Config_ListPage.M_ToolBar = Convert.ToString(dr["M_ToolBar"]);
            if (dr["M_ToolBarExtend"] != DBNull.Value) sys_Config_ListPage.M_ToolBarExtend = Convert.ToString(dr["M_ToolBarExtend"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_ListPage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["M_ExtendsJs"] != DBNull.Value) sys_Config_ListPage.M_ExtendsJs = Convert.ToString(dr["M_ExtendsJs"]);
            if (dr["M_ExtendsControl"] != DBNull.Value) sys_Config_ListPage.M_ExtendsControl = Convert.ToString(dr["M_ExtendsControl"]);
            if (dr["M_EditTitle"] != DBNull.Value) sys_Config_ListPage.M_EditTitle = Convert.ToString(dr["M_EditTitle"]);
            if (dr["M_MSelect"] != DBNull.Value) sys_Config_ListPage.M_MSelect = Convert.ToString(dr["M_MSelect"]);
            if (dr["M_Parameters"] != DBNull.Value) sys_Config_ListPage.M_Parameters = Convert.ToString(dr["M_Parameters"]);
            if (dr["M_GroupingView"] != DBNull.Value) sys_Config_ListPage.M_GroupingView = Convert.ToString(dr["M_GroupingView"]);
            if (dr["M_FormEditing"] != DBNull.Value) sys_Config_ListPage.M_FormEditing = Convert.ToString(dr["M_FormEditing"]);
            if (dr["M_FormMethod"] != DBNull.Value) sys_Config_ListPage.M_FormMethod = Convert.ToString(dr["M_FormMethod"]);
            if (dr["M_IsAdd"] != DBNull.Value) sys_Config_ListPage.M_IsAdd = Convert.ToInt32(dr["M_IsAdd"]);
            if (dr["M_IsEdit"] != DBNull.Value) sys_Config_ListPage.M_IsEdit = Convert.ToInt32(dr["M_IsEdit"]);
            if (dr["M_IsDelete"] != DBNull.Value) sys_Config_ListPage.M_IsDelete = Convert.ToInt32(dr["M_IsDelete"]);
            if (dr["M_IsView"] != DBNull.Value) sys_Config_ListPage.M_IsView = Convert.ToString(dr["M_IsView"]);
            ret.Add(sys_Config_ListPage);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的List报表类型配置表 Sys_Config_ListPage对象(即:一条记录
      /// </summary>
      public List<Sys_Config_ListPage> GetAll()
      {
         List<Sys_Config_ListPage> ret = new List<Sys_Config_ListPage>();
         string sql = "SELECT  M_ID,M_ModuleCode,M_TableName,M_NameSpace,M_SQL,M_Type,M_Title,M_AutoWidth,M_Width,M_Height,M_URL,M_MType,M_GetDataType,M_SQLParameter,M_RowNum,M_RowList,M_FooterRow,M_ViewURL,M_ViewType,M_Edit,M_EditUrl,M_EditSubmitUrl,M_OnSelectRow,M_GridComplete,M_InlineEditing,M_ImportURL,M_ImportTable,M_ImportExport,M_AltRows,M_Altclass,M_emptyrecords,M_Gridstate,M_EditCloumNum,M_ToolBar,M_ToolBarExtend,Stat,M_ExtendsJs,M_ExtendsControl,M_EditTitle,M_MSelect,M_Parameters,M_GroupingView,M_FormEditing,M_FormMethod,M_IsAdd,M_IsEdit,M_IsDelete,M_IsView FROM Sys_Config_ListPage where 1=1 AND ((Stat is null) or (Stat=0) ) order by M_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_ListPage sys_Config_ListPage = new Sys_Config_ListPage();
            if (dr["M_ID"] != DBNull.Value) sys_Config_ListPage.M_ID = Convert.ToInt32(dr["M_ID"]);
            if (dr["M_ModuleCode"] != DBNull.Value) sys_Config_ListPage.M_ModuleCode = Convert.ToString(dr["M_ModuleCode"]);
            if (dr["M_TableName"] != DBNull.Value) sys_Config_ListPage.M_TableName = Convert.ToString(dr["M_TableName"]);
            if (dr["M_NameSpace"] != DBNull.Value) sys_Config_ListPage.M_NameSpace = Convert.ToString(dr["M_NameSpace"]);
            if (dr["M_SQL"] != DBNull.Value) sys_Config_ListPage.M_SQL = Convert.ToString(dr["M_SQL"]);
            if (dr["M_Type"] != DBNull.Value) sys_Config_ListPage.M_Type = Convert.ToString(dr["M_Type"]);
            if (dr["M_Title"] != DBNull.Value) sys_Config_ListPage.M_Title = Convert.ToString(dr["M_Title"]);
            if (dr["M_AutoWidth"] != DBNull.Value) sys_Config_ListPage.M_AutoWidth = Convert.ToString(dr["M_AutoWidth"]);
            if (dr["M_Width"] != DBNull.Value) sys_Config_ListPage.M_Width = Convert.ToString(dr["M_Width"]);
            if (dr["M_Height"] != DBNull.Value) sys_Config_ListPage.M_Height = Convert.ToString(dr["M_Height"]);
            if (dr["M_URL"] != DBNull.Value) sys_Config_ListPage.M_URL = Convert.ToString(dr["M_URL"]);
            if (dr["M_MType"] != DBNull.Value) sys_Config_ListPage.M_MType = Convert.ToString(dr["M_MType"]);
            if (dr["M_GetDataType"] != DBNull.Value) sys_Config_ListPage.M_GetDataType = Convert.ToString(dr["M_GetDataType"]);
            if (dr["M_SQLParameter"] != DBNull.Value) sys_Config_ListPage.M_SQLParameter = Convert.ToString(dr["M_SQLParameter"]);
            if (dr["M_RowNum"] != DBNull.Value) sys_Config_ListPage.M_RowNum = Convert.ToString(dr["M_RowNum"]);
            if (dr["M_RowList"] != DBNull.Value) sys_Config_ListPage.M_RowList = Convert.ToString(dr["M_RowList"]);
            if (dr["M_FooterRow"] != DBNull.Value) sys_Config_ListPage.M_FooterRow = Convert.ToString(dr["M_FooterRow"]);
            if (dr["M_ViewURL"] != DBNull.Value) sys_Config_ListPage.M_ViewURL = Convert.ToString(dr["M_ViewURL"]);
            if (dr["M_ViewType"] != DBNull.Value) sys_Config_ListPage.M_ViewType = Convert.ToString(dr["M_ViewType"]);
            if (dr["M_Edit"] != DBNull.Value) sys_Config_ListPage.M_Edit = Convert.ToString(dr["M_Edit"]);
            if (dr["M_EditUrl"] != DBNull.Value) sys_Config_ListPage.M_EditUrl = Convert.ToString(dr["M_EditUrl"]);
            if (dr["M_EditSubmitUrl"] != DBNull.Value) sys_Config_ListPage.M_EditSubmitUrl = Convert.ToString(dr["M_EditSubmitUrl"]);
            if (dr["M_OnSelectRow"] != DBNull.Value) sys_Config_ListPage.M_OnSelectRow = Convert.ToString(dr["M_OnSelectRow"]);
            if (dr["M_GridComplete"] != DBNull.Value) sys_Config_ListPage.M_GridComplete = Convert.ToString(dr["M_GridComplete"]);
            if (dr["M_InlineEditing"] != DBNull.Value) sys_Config_ListPage.M_InlineEditing = Convert.ToString(dr["M_InlineEditing"]);
            if (dr["M_ImportURL"] != DBNull.Value) sys_Config_ListPage.M_ImportURL = Convert.ToString(dr["M_ImportURL"]);
            if (dr["M_ImportTable"] != DBNull.Value) sys_Config_ListPage.M_ImportTable = Convert.ToString(dr["M_ImportTable"]);
            if (dr["M_ImportExport"] != DBNull.Value) sys_Config_ListPage.M_ImportExport = Convert.ToString(dr["M_ImportExport"]);
            if (dr["M_AltRows"] != DBNull.Value) sys_Config_ListPage.M_AltRows = Convert.ToString(dr["M_AltRows"]);
            if (dr["M_Altclass"] != DBNull.Value) sys_Config_ListPage.M_Altclass = Convert.ToString(dr["M_Altclass"]);
            if (dr["M_emptyrecords"] != DBNull.Value) sys_Config_ListPage.M_emptyrecords = Convert.ToString(dr["M_emptyrecords"]);
            if (dr["M_Gridstate"] != DBNull.Value) sys_Config_ListPage.M_Gridstate = Convert.ToString(dr["M_Gridstate"]);
            if (dr["M_EditCloumNum"] != DBNull.Value) sys_Config_ListPage.M_EditCloumNum = Convert.ToInt32(dr["M_EditCloumNum"]);
            if (dr["M_ToolBar"] != DBNull.Value) sys_Config_ListPage.M_ToolBar = Convert.ToString(dr["M_ToolBar"]);
            if (dr["M_ToolBarExtend"] != DBNull.Value) sys_Config_ListPage.M_ToolBarExtend = Convert.ToString(dr["M_ToolBarExtend"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_ListPage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["M_ExtendsJs"] != DBNull.Value) sys_Config_ListPage.M_ExtendsJs = Convert.ToString(dr["M_ExtendsJs"]);
            if (dr["M_ExtendsControl"] != DBNull.Value) sys_Config_ListPage.M_ExtendsControl = Convert.ToString(dr["M_ExtendsControl"]);
            if (dr["M_EditTitle"] != DBNull.Value) sys_Config_ListPage.M_EditTitle = Convert.ToString(dr["M_EditTitle"]);
            if (dr["M_MSelect"] != DBNull.Value) sys_Config_ListPage.M_MSelect = Convert.ToString(dr["M_MSelect"]);
            if (dr["M_Parameters"] != DBNull.Value) sys_Config_ListPage.M_Parameters = Convert.ToString(dr["M_Parameters"]);
            if (dr["M_GroupingView"] != DBNull.Value) sys_Config_ListPage.M_GroupingView = Convert.ToString(dr["M_GroupingView"]);
            if (dr["M_FormEditing"] != DBNull.Value) sys_Config_ListPage.M_FormEditing = Convert.ToString(dr["M_FormEditing"]);
            if (dr["M_FormMethod"] != DBNull.Value) sys_Config_ListPage.M_FormMethod = Convert.ToString(dr["M_FormMethod"]);
            if (dr["M_IsAdd"] != DBNull.Value) sys_Config_ListPage.M_IsAdd = Convert.ToInt32(dr["M_IsAdd"]);
            if (dr["M_IsEdit"] != DBNull.Value) sys_Config_ListPage.M_IsEdit = Convert.ToInt32(dr["M_IsEdit"]);
            if (dr["M_IsDelete"] != DBNull.Value) sys_Config_ListPage.M_IsDelete = Convert.ToInt32(dr["M_IsDelete"]);
            if (dr["M_IsView"] != DBNull.Value) sys_Config_ListPage.M_IsView = Convert.ToString(dr["M_IsView"]);
            ret.Add(sys_Config_ListPage);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
