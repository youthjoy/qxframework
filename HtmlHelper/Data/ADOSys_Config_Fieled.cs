using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.HtmlHelperLib.Model;
using QX.DataAcess;

namespace QX.HtmlHelperLib.DAL
{
   /// <summary>
   /// 字段配置表
   /// </summary>
   [Serializable]
   public partial class ADOSys_Config_Fieled
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加字段配置表 Sys_Config_Fieled对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Config_Fieled sys_Config_Fieled)
      {
         string sql = "INSERT INTO Sys_Config_Fieled (D_Name,D_ModuleCode,D_NameSpace,D_Index,D_Type,D_EditHidden,D_Hidden,D_EditReadOnly,D_IsKey,D_DefaultValue,D_EditType,D_OpenLayer,D_Length,D_Width,D_Height,D_Align,D_Sortable,D_Editable,D_Editoptions,D_EditRules,D_FormOptions,D_Formatter,D_Searchoptions,D_ShowOrder,D_EditOrder,D_DictKey,D_DoEvent,D_EditMessage,Stat,D_UDEF1,D_UDEF2,D_UDEF3,D_UDEF4,D_EditTab,D_DBField,D_Summary,D_LinkUrl,D_LinkParam) VALUES (@D_Name,@D_ModuleCode,@D_NameSpace,@D_Index,@D_Type,@D_EditHidden,@D_Hidden,@D_EditReadOnly,@D_IsKey,@D_DefaultValue,@D_EditType,@D_OpenLayer,@D_Length,@D_Width,@D_Height,@D_Align,@D_Sortable,@D_Editable,@D_Editoptions,@D_EditRules,@D_FormOptions,@D_Formatter,@D_Searchoptions,@D_ShowOrder,@D_EditOrder,@D_DictKey,@D_DoEvent,@D_EditMessage,@Stat,@D_UDEF1,@D_UDEF2,@D_UDEF3,@D_UDEF4,@D_EditTab,@D_DBField,@D_Summary,@D_LinkUrl,@D_LinkParam)";
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Name))
         {
            idb.AddParameter("@D_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Name", sys_Config_Fieled.D_Name);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_ModuleCode))
         {
            idb.AddParameter("@D_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_ModuleCode", sys_Config_Fieled.D_ModuleCode);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_NameSpace))
         {
            idb.AddParameter("@D_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_NameSpace", sys_Config_Fieled.D_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Index))
         {
            idb.AddParameter("@D_Index", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Index", sys_Config_Fieled.D_Index);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Type))
         {
            idb.AddParameter("@D_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Type", sys_Config_Fieled.D_Type);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditHidden))
         {
            idb.AddParameter("@D_EditHidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditHidden", sys_Config_Fieled.D_EditHidden);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Hidden))
         {
            idb.AddParameter("@D_Hidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Hidden", sys_Config_Fieled.D_Hidden);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditReadOnly))
         {
            idb.AddParameter("@D_EditReadOnly", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditReadOnly", sys_Config_Fieled.D_EditReadOnly);
         }
         if (sys_Config_Fieled.D_IsKey == 0)
         {
            idb.AddParameter("@D_IsKey", 0);
         }
         else
         {
            idb.AddParameter("@D_IsKey", sys_Config_Fieled.D_IsKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DefaultValue))
         {
            idb.AddParameter("@D_DefaultValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DefaultValue", sys_Config_Fieled.D_DefaultValue);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditType))
         {
            idb.AddParameter("@D_EditType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditType", sys_Config_Fieled.D_EditType);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_OpenLayer))
         {
            idb.AddParameter("@D_OpenLayer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_OpenLayer", sys_Config_Fieled.D_OpenLayer);
         }
         if (sys_Config_Fieled.D_Length == 0)
         {
            idb.AddParameter("@D_Length", 0);
         }
         else
         {
            idb.AddParameter("@D_Length", sys_Config_Fieled.D_Length);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Width))
         {
            idb.AddParameter("@D_Width", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Width", sys_Config_Fieled.D_Width);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Height))
         {
            idb.AddParameter("@D_Height", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Height", sys_Config_Fieled.D_Height);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Align))
         {
            idb.AddParameter("@D_Align", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Align", sys_Config_Fieled.D_Align);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Sortable))
         {
            idb.AddParameter("@D_Sortable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Sortable", sys_Config_Fieled.D_Sortable);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Editable))
         {
            idb.AddParameter("@D_Editable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Editable", sys_Config_Fieled.D_Editable);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Editoptions))
         {
            idb.AddParameter("@D_Editoptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Editoptions", sys_Config_Fieled.D_Editoptions);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditRules))
         {
            idb.AddParameter("@D_EditRules", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditRules", sys_Config_Fieled.D_EditRules);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_FormOptions))
         {
            idb.AddParameter("@D_FormOptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_FormOptions", sys_Config_Fieled.D_FormOptions);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Formatter))
         {
            idb.AddParameter("@D_Formatter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Formatter", sys_Config_Fieled.D_Formatter);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Searchoptions))
         {
            idb.AddParameter("@D_Searchoptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Searchoptions", sys_Config_Fieled.D_Searchoptions);
         }
         if (sys_Config_Fieled.D_ShowOrder == 0)
         {
            idb.AddParameter("@D_ShowOrder", 0);
         }
         else
         {
            idb.AddParameter("@D_ShowOrder", sys_Config_Fieled.D_ShowOrder);
         }
         if (sys_Config_Fieled.D_EditOrder == 0)
         {
            idb.AddParameter("@D_EditOrder", 0);
         }
         else
         {
            idb.AddParameter("@D_EditOrder", sys_Config_Fieled.D_EditOrder);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DictKey))
         {
            idb.AddParameter("@D_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DictKey", sys_Config_Fieled.D_DictKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DoEvent))
         {
            idb.AddParameter("@D_DoEvent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DoEvent", sys_Config_Fieled.D_DoEvent);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditMessage))
         {
            idb.AddParameter("@D_EditMessage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditMessage", sys_Config_Fieled.D_EditMessage);
         }
         if (sys_Config_Fieled.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Fieled.Stat);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF1))
         {
            idb.AddParameter("@D_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF1", sys_Config_Fieled.D_UDEF1);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF2))
         {
            idb.AddParameter("@D_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF2", sys_Config_Fieled.D_UDEF2);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF3))
         {
            idb.AddParameter("@D_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF3", sys_Config_Fieled.D_UDEF3);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF4))
         {
            idb.AddParameter("@D_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF4", sys_Config_Fieled.D_UDEF4);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditTab))
         {
            idb.AddParameter("@D_EditTab", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditTab", sys_Config_Fieled.D_EditTab);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DBField))
         {
            idb.AddParameter("@D_DBField", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DBField", sys_Config_Fieled.D_DBField);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Summary))
         {
            idb.AddParameter("@D_Summary", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Summary", sys_Config_Fieled.D_Summary);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_LinkUrl))
         {
            idb.AddParameter("@D_LinkUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_LinkUrl", sys_Config_Fieled.D_LinkUrl);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_LinkParam))
         {
            idb.AddParameter("@D_LinkParam", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_LinkParam", sys_Config_Fieled.D_LinkParam);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加字段配置表 Sys_Config_Fieled对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Config_Fieled sys_Config_Fieled)
      {
         string sql = "INSERT INTO Sys_Config_Fieled (D_Name,D_ModuleCode,D_NameSpace,D_Index,D_Type,D_EditHidden,D_Hidden,D_EditReadOnly,D_IsKey,D_DefaultValue,D_EditType,D_OpenLayer,D_Length,D_Width,D_Height,D_Align,D_Sortable,D_Editable,D_Editoptions,D_EditRules,D_FormOptions,D_Formatter,D_Searchoptions,D_ShowOrder,D_EditOrder,D_DictKey,D_DoEvent,D_EditMessage,Stat,D_UDEF1,D_UDEF2,D_UDEF3,D_UDEF4,D_EditTab,D_DBField,D_Summary,D_LinkUrl,D_LinkParam) VALUES (@D_Name,@D_ModuleCode,@D_NameSpace,@D_Index,@D_Type,@D_EditHidden,@D_Hidden,@D_EditReadOnly,@D_IsKey,@D_DefaultValue,@D_EditType,@D_OpenLayer,@D_Length,@D_Width,@D_Height,@D_Align,@D_Sortable,@D_Editable,@D_Editoptions,@D_EditRules,@D_FormOptions,@D_Formatter,@D_Searchoptions,@D_ShowOrder,@D_EditOrder,@D_DictKey,@D_DoEvent,@D_EditMessage,@Stat,@D_UDEF1,@D_UDEF2,@D_UDEF3,@D_UDEF4,@D_EditTab,@D_DBField,@D_Summary,@D_LinkUrl,@D_LinkParam);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Name))
         {
            idb.AddParameter("@D_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Name", sys_Config_Fieled.D_Name);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_ModuleCode))
         {
            idb.AddParameter("@D_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_ModuleCode", sys_Config_Fieled.D_ModuleCode);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_NameSpace))
         {
            idb.AddParameter("@D_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_NameSpace", sys_Config_Fieled.D_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Index))
         {
            idb.AddParameter("@D_Index", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Index", sys_Config_Fieled.D_Index);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Type))
         {
            idb.AddParameter("@D_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Type", sys_Config_Fieled.D_Type);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditHidden))
         {
            idb.AddParameter("@D_EditHidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditHidden", sys_Config_Fieled.D_EditHidden);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Hidden))
         {
            idb.AddParameter("@D_Hidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Hidden", sys_Config_Fieled.D_Hidden);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditReadOnly))
         {
            idb.AddParameter("@D_EditReadOnly", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditReadOnly", sys_Config_Fieled.D_EditReadOnly);
         }
         if (sys_Config_Fieled.D_IsKey == 0)
         {
            idb.AddParameter("@D_IsKey", 0);
         }
         else
         {
            idb.AddParameter("@D_IsKey", sys_Config_Fieled.D_IsKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DefaultValue))
         {
            idb.AddParameter("@D_DefaultValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DefaultValue", sys_Config_Fieled.D_DefaultValue);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditType))
         {
            idb.AddParameter("@D_EditType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditType", sys_Config_Fieled.D_EditType);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_OpenLayer))
         {
            idb.AddParameter("@D_OpenLayer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_OpenLayer", sys_Config_Fieled.D_OpenLayer);
         }
         if (sys_Config_Fieled.D_Length == 0)
         {
            idb.AddParameter("@D_Length", 0);
         }
         else
         {
            idb.AddParameter("@D_Length", sys_Config_Fieled.D_Length);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Width))
         {
            idb.AddParameter("@D_Width", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Width", sys_Config_Fieled.D_Width);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Height))
         {
            idb.AddParameter("@D_Height", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Height", sys_Config_Fieled.D_Height);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Align))
         {
            idb.AddParameter("@D_Align", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Align", sys_Config_Fieled.D_Align);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Sortable))
         {
            idb.AddParameter("@D_Sortable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Sortable", sys_Config_Fieled.D_Sortable);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Editable))
         {
            idb.AddParameter("@D_Editable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Editable", sys_Config_Fieled.D_Editable);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Editoptions))
         {
            idb.AddParameter("@D_Editoptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Editoptions", sys_Config_Fieled.D_Editoptions);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditRules))
         {
            idb.AddParameter("@D_EditRules", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditRules", sys_Config_Fieled.D_EditRules);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_FormOptions))
         {
            idb.AddParameter("@D_FormOptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_FormOptions", sys_Config_Fieled.D_FormOptions);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Formatter))
         {
            idb.AddParameter("@D_Formatter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Formatter", sys_Config_Fieled.D_Formatter);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Searchoptions))
         {
            idb.AddParameter("@D_Searchoptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Searchoptions", sys_Config_Fieled.D_Searchoptions);
         }
         if (sys_Config_Fieled.D_ShowOrder == 0)
         {
            idb.AddParameter("@D_ShowOrder", 0);
         }
         else
         {
            idb.AddParameter("@D_ShowOrder", sys_Config_Fieled.D_ShowOrder);
         }
         if (sys_Config_Fieled.D_EditOrder == 0)
         {
            idb.AddParameter("@D_EditOrder", 0);
         }
         else
         {
            idb.AddParameter("@D_EditOrder", sys_Config_Fieled.D_EditOrder);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DictKey))
         {
            idb.AddParameter("@D_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DictKey", sys_Config_Fieled.D_DictKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DoEvent))
         {
            idb.AddParameter("@D_DoEvent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DoEvent", sys_Config_Fieled.D_DoEvent);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditMessage))
         {
            idb.AddParameter("@D_EditMessage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditMessage", sys_Config_Fieled.D_EditMessage);
         }
         if (sys_Config_Fieled.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Fieled.Stat);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF1))
         {
            idb.AddParameter("@D_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF1", sys_Config_Fieled.D_UDEF1);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF2))
         {
            idb.AddParameter("@D_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF2", sys_Config_Fieled.D_UDEF2);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF3))
         {
            idb.AddParameter("@D_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF3", sys_Config_Fieled.D_UDEF3);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF4))
         {
            idb.AddParameter("@D_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF4", sys_Config_Fieled.D_UDEF4);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditTab))
         {
            idb.AddParameter("@D_EditTab", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditTab", sys_Config_Fieled.D_EditTab);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DBField))
         {
            idb.AddParameter("@D_DBField", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DBField", sys_Config_Fieled.D_DBField);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Summary))
         {
            idb.AddParameter("@D_Summary", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Summary", sys_Config_Fieled.D_Summary);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_LinkUrl))
         {
            idb.AddParameter("@D_LinkUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_LinkUrl", sys_Config_Fieled.D_LinkUrl);
         }
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_LinkParam))
         {
            idb.AddParameter("@D_LinkParam", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_LinkParam", sys_Config_Fieled.D_LinkParam);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新字段配置表 Sys_Config_Fieled对象(即:一条记录
      /// </summary>
      public int Update(Sys_Config_Fieled sys_Config_Fieled)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Config_Fieled       SET ");
            if(sys_Config_Fieled.D_Name_IsChanged){sbParameter.Append("D_Name=@D_Name, ");}
      if(sys_Config_Fieled.D_ModuleCode_IsChanged){sbParameter.Append("D_ModuleCode=@D_ModuleCode, ");}
      if(sys_Config_Fieled.D_NameSpace_IsChanged){sbParameter.Append("D_NameSpace=@D_NameSpace, ");}
      if(sys_Config_Fieled.D_Index_IsChanged){sbParameter.Append("D_Index=@D_Index, ");}
      if(sys_Config_Fieled.D_Type_IsChanged){sbParameter.Append("D_Type=@D_Type, ");}
      if(sys_Config_Fieled.D_EditHidden_IsChanged){sbParameter.Append("D_EditHidden=@D_EditHidden, ");}
      if(sys_Config_Fieled.D_Hidden_IsChanged){sbParameter.Append("D_Hidden=@D_Hidden, ");}
      if(sys_Config_Fieled.D_EditReadOnly_IsChanged){sbParameter.Append("D_EditReadOnly=@D_EditReadOnly, ");}
      if(sys_Config_Fieled.D_IsKey_IsChanged){sbParameter.Append("D_IsKey=@D_IsKey, ");}
      if(sys_Config_Fieled.D_DefaultValue_IsChanged){sbParameter.Append("D_DefaultValue=@D_DefaultValue, ");}
      if(sys_Config_Fieled.D_EditType_IsChanged){sbParameter.Append("D_EditType=@D_EditType, ");}
      if(sys_Config_Fieled.D_OpenLayer_IsChanged){sbParameter.Append("D_OpenLayer=@D_OpenLayer, ");}
      if(sys_Config_Fieled.D_Length_IsChanged){sbParameter.Append("D_Length=@D_Length, ");}
      if(sys_Config_Fieled.D_Width_IsChanged){sbParameter.Append("D_Width=@D_Width, ");}
      if(sys_Config_Fieled.D_Height_IsChanged){sbParameter.Append("D_Height=@D_Height, ");}
      if(sys_Config_Fieled.D_Align_IsChanged){sbParameter.Append("D_Align=@D_Align, ");}
      if(sys_Config_Fieled.D_Sortable_IsChanged){sbParameter.Append("D_Sortable=@D_Sortable, ");}
      if(sys_Config_Fieled.D_Editable_IsChanged){sbParameter.Append("D_Editable=@D_Editable, ");}
      if(sys_Config_Fieled.D_Editoptions_IsChanged){sbParameter.Append("D_Editoptions=@D_Editoptions, ");}
      if(sys_Config_Fieled.D_EditRules_IsChanged){sbParameter.Append("D_EditRules=@D_EditRules, ");}
      if(sys_Config_Fieled.D_FormOptions_IsChanged){sbParameter.Append("D_FormOptions=@D_FormOptions, ");}
      if(sys_Config_Fieled.D_Formatter_IsChanged){sbParameter.Append("D_Formatter=@D_Formatter, ");}
      if(sys_Config_Fieled.D_Searchoptions_IsChanged){sbParameter.Append("D_Searchoptions=@D_Searchoptions, ");}
      if(sys_Config_Fieled.D_ShowOrder_IsChanged){sbParameter.Append("D_ShowOrder=@D_ShowOrder, ");}
      if(sys_Config_Fieled.D_EditOrder_IsChanged){sbParameter.Append("D_EditOrder=@D_EditOrder, ");}
      if(sys_Config_Fieled.D_DictKey_IsChanged){sbParameter.Append("D_DictKey=@D_DictKey, ");}
      if(sys_Config_Fieled.D_DoEvent_IsChanged){sbParameter.Append("D_DoEvent=@D_DoEvent, ");}
      if(sys_Config_Fieled.D_EditMessage_IsChanged){sbParameter.Append("D_EditMessage=@D_EditMessage, ");}
      if(sys_Config_Fieled.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_Config_Fieled.D_UDEF1_IsChanged){sbParameter.Append("D_UDEF1=@D_UDEF1, ");}
      if(sys_Config_Fieled.D_UDEF2_IsChanged){sbParameter.Append("D_UDEF2=@D_UDEF2, ");}
      if(sys_Config_Fieled.D_UDEF3_IsChanged){sbParameter.Append("D_UDEF3=@D_UDEF3, ");}
      if(sys_Config_Fieled.D_UDEF4_IsChanged){sbParameter.Append("D_UDEF4=@D_UDEF4, ");}
      if(sys_Config_Fieled.D_EditTab_IsChanged){sbParameter.Append("D_EditTab=@D_EditTab, ");}
      if(sys_Config_Fieled.D_DBField_IsChanged){sbParameter.Append("D_DBField=@D_DBField, ");}
      if(sys_Config_Fieled.D_Summary_IsChanged){sbParameter.Append("D_Summary=@D_Summary, ");}
      if(sys_Config_Fieled.D_LinkUrl_IsChanged){sbParameter.Append("D_LinkUrl=@D_LinkUrl, ");}
      if(sys_Config_Fieled.D_LinkParam_IsChanged){sbParameter.Append("D_LinkParam=@D_LinkParam ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and D_ID=@D_ID; " );
      string sql=sb.ToString();
         if(sys_Config_Fieled.D_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Name))
         {
            idb.AddParameter("@D_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Name", sys_Config_Fieled.D_Name);
         }
          }
         if(sys_Config_Fieled.D_ModuleCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_ModuleCode))
         {
            idb.AddParameter("@D_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_ModuleCode", sys_Config_Fieled.D_ModuleCode);
         }
          }
         if(sys_Config_Fieled.D_NameSpace_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_NameSpace))
         {
            idb.AddParameter("@D_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_NameSpace", sys_Config_Fieled.D_NameSpace);
         }
          }
         if(sys_Config_Fieled.D_Index_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Index))
         {
            idb.AddParameter("@D_Index", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Index", sys_Config_Fieled.D_Index);
         }
          }
         if(sys_Config_Fieled.D_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Type))
         {
            idb.AddParameter("@D_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Type", sys_Config_Fieled.D_Type);
         }
          }
         if(sys_Config_Fieled.D_EditHidden_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditHidden))
         {
            idb.AddParameter("@D_EditHidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditHidden", sys_Config_Fieled.D_EditHidden);
         }
          }
         if(sys_Config_Fieled.D_Hidden_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Hidden))
         {
            idb.AddParameter("@D_Hidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Hidden", sys_Config_Fieled.D_Hidden);
         }
          }
         if(sys_Config_Fieled.D_EditReadOnly_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditReadOnly))
         {
            idb.AddParameter("@D_EditReadOnly", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditReadOnly", sys_Config_Fieled.D_EditReadOnly);
         }
          }
         if(sys_Config_Fieled.D_IsKey_IsChanged)
         {
         if (sys_Config_Fieled.D_IsKey == 0)
         {
            idb.AddParameter("@D_IsKey", 0);
         }
         else
         {
            idb.AddParameter("@D_IsKey", sys_Config_Fieled.D_IsKey);
         }
          }
         if(sys_Config_Fieled.D_DefaultValue_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DefaultValue))
         {
            idb.AddParameter("@D_DefaultValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DefaultValue", sys_Config_Fieled.D_DefaultValue);
         }
          }
         if(sys_Config_Fieled.D_EditType_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditType))
         {
            idb.AddParameter("@D_EditType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditType", sys_Config_Fieled.D_EditType);
         }
          }
         if(sys_Config_Fieled.D_OpenLayer_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_OpenLayer))
         {
            idb.AddParameter("@D_OpenLayer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_OpenLayer", sys_Config_Fieled.D_OpenLayer);
         }
          }
         if(sys_Config_Fieled.D_Length_IsChanged)
         {
         if (sys_Config_Fieled.D_Length == 0)
         {
            idb.AddParameter("@D_Length", 0);
         }
         else
         {
            idb.AddParameter("@D_Length", sys_Config_Fieled.D_Length);
         }
          }
         if(sys_Config_Fieled.D_Width_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Width))
         {
            idb.AddParameter("@D_Width", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Width", sys_Config_Fieled.D_Width);
         }
          }
         if(sys_Config_Fieled.D_Height_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Height))
         {
            idb.AddParameter("@D_Height", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Height", sys_Config_Fieled.D_Height);
         }
          }
         if(sys_Config_Fieled.D_Align_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Align))
         {
            idb.AddParameter("@D_Align", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Align", sys_Config_Fieled.D_Align);
         }
          }
         if(sys_Config_Fieled.D_Sortable_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Sortable))
         {
            idb.AddParameter("@D_Sortable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Sortable", sys_Config_Fieled.D_Sortable);
         }
          }
         if(sys_Config_Fieled.D_Editable_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Editable))
         {
            idb.AddParameter("@D_Editable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Editable", sys_Config_Fieled.D_Editable);
         }
          }
         if(sys_Config_Fieled.D_Editoptions_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Editoptions))
         {
            idb.AddParameter("@D_Editoptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Editoptions", sys_Config_Fieled.D_Editoptions);
         }
          }
         if(sys_Config_Fieled.D_EditRules_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditRules))
         {
            idb.AddParameter("@D_EditRules", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditRules", sys_Config_Fieled.D_EditRules);
         }
          }
         if(sys_Config_Fieled.D_FormOptions_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_FormOptions))
         {
            idb.AddParameter("@D_FormOptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_FormOptions", sys_Config_Fieled.D_FormOptions);
         }
          }
         if(sys_Config_Fieled.D_Formatter_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Formatter))
         {
            idb.AddParameter("@D_Formatter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Formatter", sys_Config_Fieled.D_Formatter);
         }
          }
         if(sys_Config_Fieled.D_Searchoptions_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Searchoptions))
         {
            idb.AddParameter("@D_Searchoptions", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Searchoptions", sys_Config_Fieled.D_Searchoptions);
         }
          }
         if(sys_Config_Fieled.D_ShowOrder_IsChanged)
         {
         if (sys_Config_Fieled.D_ShowOrder == 0)
         {
            idb.AddParameter("@D_ShowOrder", 0);
         }
         else
         {
            idb.AddParameter("@D_ShowOrder", sys_Config_Fieled.D_ShowOrder);
         }
          }
         if(sys_Config_Fieled.D_EditOrder_IsChanged)
         {
         if (sys_Config_Fieled.D_EditOrder == 0)
         {
            idb.AddParameter("@D_EditOrder", 0);
         }
         else
         {
            idb.AddParameter("@D_EditOrder", sys_Config_Fieled.D_EditOrder);
         }
          }
         if(sys_Config_Fieled.D_DictKey_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DictKey))
         {
            idb.AddParameter("@D_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DictKey", sys_Config_Fieled.D_DictKey);
         }
          }
         if(sys_Config_Fieled.D_DoEvent_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DoEvent))
         {
            idb.AddParameter("@D_DoEvent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DoEvent", sys_Config_Fieled.D_DoEvent);
         }
          }
         if(sys_Config_Fieled.D_EditMessage_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditMessage))
         {
            idb.AddParameter("@D_EditMessage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditMessage", sys_Config_Fieled.D_EditMessage);
         }
          }
         if(sys_Config_Fieled.Stat_IsChanged)
         {
         if (sys_Config_Fieled.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Fieled.Stat);
         }
          }
         if(sys_Config_Fieled.D_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF1))
         {
            idb.AddParameter("@D_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF1", sys_Config_Fieled.D_UDEF1);
         }
          }
         if(sys_Config_Fieled.D_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF2))
         {
            idb.AddParameter("@D_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF2", sys_Config_Fieled.D_UDEF2);
         }
          }
         if(sys_Config_Fieled.D_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF3))
         {
            idb.AddParameter("@D_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF3", sys_Config_Fieled.D_UDEF3);
         }
          }
         if(sys_Config_Fieled.D_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_UDEF4))
         {
            idb.AddParameter("@D_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_UDEF4", sys_Config_Fieled.D_UDEF4);
         }
          }
         if(sys_Config_Fieled.D_EditTab_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_EditTab))
         {
            idb.AddParameter("@D_EditTab", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_EditTab", sys_Config_Fieled.D_EditTab);
         }
          }
         if(sys_Config_Fieled.D_DBField_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_DBField))
         {
            idb.AddParameter("@D_DBField", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DBField", sys_Config_Fieled.D_DBField);
         }
          }
         if(sys_Config_Fieled.D_Summary_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_Summary))
         {
            idb.AddParameter("@D_Summary", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Summary", sys_Config_Fieled.D_Summary);
         }
          }
         if(sys_Config_Fieled.D_LinkUrl_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_LinkUrl))
         {
            idb.AddParameter("@D_LinkUrl", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_LinkUrl", sys_Config_Fieled.D_LinkUrl);
         }
          }
         if(sys_Config_Fieled.D_LinkParam_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Fieled.D_LinkParam))
         {
            idb.AddParameter("@D_LinkParam", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_LinkParam", sys_Config_Fieled.D_LinkParam);
         }
          }

         idb.AddParameter("@D_ID", sys_Config_Fieled.D_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除字段配置表 Sys_Config_Fieled对象(即:一条记录
      /// </summary>
      public int Delete(int d_ID)
      {
         string sql = "DELETE Sys_Config_Fieled WHERE 1=1  AND D_ID=@D_ID ";
         idb.AddParameter("@D_ID", d_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的字段配置表 Sys_Config_Fieled对象(即:一条记录
      /// </summary>
      public Sys_Config_Fieled GetByKey(int d_ID)
      {
         Sys_Config_Fieled sys_Config_Fieled = new Sys_Config_Fieled();
         string sql = "SELECT  D_ID,D_Name,D_ModuleCode,D_NameSpace,D_Index,D_Type,D_EditHidden,D_Hidden,D_EditReadOnly,D_IsKey,D_DefaultValue,D_EditType,D_OpenLayer,D_Length,D_Width,D_Height,D_Align,D_Sortable,D_Editable,D_Editoptions,D_EditRules,D_FormOptions,D_Formatter,D_Searchoptions,D_ShowOrder,D_EditOrder,D_DictKey,D_DoEvent,D_EditMessage,Stat,D_UDEF1,D_UDEF2,D_UDEF3,D_UDEF4,D_EditTab,D_DBField,D_Summary,D_LinkUrl,D_LinkParam FROM Sys_Config_Fieled WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND D_ID=@D_ID ";
         idb.AddParameter("@D_ID", d_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["D_ID"] != DBNull.Value) sys_Config_Fieled.D_ID = Convert.ToInt32(dr["D_ID"]);
            if (dr["D_Name"] != DBNull.Value) sys_Config_Fieled.D_Name = Convert.ToString(dr["D_Name"]);
            if (dr["D_ModuleCode"] != DBNull.Value) sys_Config_Fieled.D_ModuleCode = Convert.ToString(dr["D_ModuleCode"]);
            if (dr["D_NameSpace"] != DBNull.Value) sys_Config_Fieled.D_NameSpace = Convert.ToString(dr["D_NameSpace"]);
            if (dr["D_Index"] != DBNull.Value) sys_Config_Fieled.D_Index = Convert.ToString(dr["D_Index"]);
            if (dr["D_Type"] != DBNull.Value) sys_Config_Fieled.D_Type = Convert.ToString(dr["D_Type"]);
            if (dr["D_EditHidden"] != DBNull.Value) sys_Config_Fieled.D_EditHidden = Convert.ToString(dr["D_EditHidden"]);
            if (dr["D_Hidden"] != DBNull.Value) sys_Config_Fieled.D_Hidden = Convert.ToString(dr["D_Hidden"]);
            if (dr["D_EditReadOnly"] != DBNull.Value) sys_Config_Fieled.D_EditReadOnly = Convert.ToString(dr["D_EditReadOnly"]);
            if (dr["D_IsKey"] != DBNull.Value) sys_Config_Fieled.D_IsKey = Convert.ToInt32(dr["D_IsKey"]);
            if (dr["D_DefaultValue"] != DBNull.Value) sys_Config_Fieled.D_DefaultValue = Convert.ToString(dr["D_DefaultValue"]);
            if (dr["D_EditType"] != DBNull.Value) sys_Config_Fieled.D_EditType = Convert.ToString(dr["D_EditType"]);
            if (dr["D_OpenLayer"] != DBNull.Value) sys_Config_Fieled.D_OpenLayer = Convert.ToString(dr["D_OpenLayer"]);
            if (dr["D_Length"] != DBNull.Value) sys_Config_Fieled.D_Length = Convert.ToInt32(dr["D_Length"]);
            if (dr["D_Width"] != DBNull.Value) sys_Config_Fieled.D_Width = Convert.ToString(dr["D_Width"]);
            if (dr["D_Height"] != DBNull.Value) sys_Config_Fieled.D_Height = Convert.ToString(dr["D_Height"]);
            if (dr["D_Align"] != DBNull.Value) sys_Config_Fieled.D_Align = Convert.ToString(dr["D_Align"]);
            if (dr["D_Sortable"] != DBNull.Value) sys_Config_Fieled.D_Sortable = Convert.ToString(dr["D_Sortable"]);
            if (dr["D_Editable"] != DBNull.Value) sys_Config_Fieled.D_Editable = Convert.ToString(dr["D_Editable"]);
            if (dr["D_Editoptions"] != DBNull.Value) sys_Config_Fieled.D_Editoptions = Convert.ToString(dr["D_Editoptions"]);
            if (dr["D_EditRules"] != DBNull.Value) sys_Config_Fieled.D_EditRules = Convert.ToString(dr["D_EditRules"]);
            if (dr["D_FormOptions"] != DBNull.Value) sys_Config_Fieled.D_FormOptions = Convert.ToString(dr["D_FormOptions"]);
            if (dr["D_Formatter"] != DBNull.Value) sys_Config_Fieled.D_Formatter = Convert.ToString(dr["D_Formatter"]);
            if (dr["D_Searchoptions"] != DBNull.Value) sys_Config_Fieled.D_Searchoptions = Convert.ToString(dr["D_Searchoptions"]);
            if (dr["D_ShowOrder"] != DBNull.Value) sys_Config_Fieled.D_ShowOrder = Convert.ToInt32(dr["D_ShowOrder"]);
            if (dr["D_EditOrder"] != DBNull.Value) sys_Config_Fieled.D_EditOrder = Convert.ToInt32(dr["D_EditOrder"]);
            if (dr["D_DictKey"] != DBNull.Value) sys_Config_Fieled.D_DictKey = Convert.ToString(dr["D_DictKey"]);
            if (dr["D_DoEvent"] != DBNull.Value) sys_Config_Fieled.D_DoEvent = Convert.ToString(dr["D_DoEvent"]);
            if (dr["D_EditMessage"] != DBNull.Value) sys_Config_Fieled.D_EditMessage = Convert.ToString(dr["D_EditMessage"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Fieled.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["D_UDEF1"] != DBNull.Value) sys_Config_Fieled.D_UDEF1 = Convert.ToString(dr["D_UDEF1"]);
            if (dr["D_UDEF2"] != DBNull.Value) sys_Config_Fieled.D_UDEF2 = Convert.ToString(dr["D_UDEF2"]);
            if (dr["D_UDEF3"] != DBNull.Value) sys_Config_Fieled.D_UDEF3 = Convert.ToString(dr["D_UDEF3"]);
            if (dr["D_UDEF4"] != DBNull.Value) sys_Config_Fieled.D_UDEF4 = Convert.ToString(dr["D_UDEF4"]);
            if (dr["D_EditTab"] != DBNull.Value) sys_Config_Fieled.D_EditTab = Convert.ToString(dr["D_EditTab"]);
            if (dr["D_DBField"] != DBNull.Value) sys_Config_Fieled.D_DBField = Convert.ToString(dr["D_DBField"]);
            if (dr["D_Summary"] != DBNull.Value) sys_Config_Fieled.D_Summary = Convert.ToString(dr["D_Summary"]);
            if (dr["D_LinkUrl"] != DBNull.Value) sys_Config_Fieled.D_LinkUrl = Convert.ToString(dr["D_LinkUrl"]);
            if (dr["D_LinkParam"] != DBNull.Value) sys_Config_Fieled.D_LinkParam = Convert.ToString(dr["D_LinkParam"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Config_Fieled;
      }
      /// <summary>
      /// 获取指定的字段配置表 Sys_Config_Fieled对象集合
      /// </summary>
      public List<Sys_Config_Fieled> GetListByWhere(string strCondition)
      {
         List<Sys_Config_Fieled> ret = new List<Sys_Config_Fieled>();
         string sql = "SELECT  D_ID,D_Name,D_ModuleCode,D_NameSpace,D_Index,D_Type,D_EditHidden,D_Hidden,D_EditReadOnly,D_IsKey,D_DefaultValue,D_EditType,D_OpenLayer,D_Length,D_Width,D_Height,D_Align,D_Sortable,D_Editable,D_Editoptions,D_EditRules,D_FormOptions,D_Formatter,D_Searchoptions,D_ShowOrder,D_EditOrder,D_DictKey,D_DoEvent,D_EditMessage,Stat,D_UDEF1,D_UDEF2,D_UDEF3,D_UDEF4,D_EditTab,D_DBField,D_Summary,D_LinkUrl,D_LinkParam FROM Sys_Config_Fieled WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
         // sql += " ORDER BY D_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_Fieled sys_Config_Fieled = new Sys_Config_Fieled();
            if (dr["D_ID"] != DBNull.Value) sys_Config_Fieled.D_ID = Convert.ToInt32(dr["D_ID"]);
            if (dr["D_Name"] != DBNull.Value) sys_Config_Fieled.D_Name = Convert.ToString(dr["D_Name"]);
            if (dr["D_ModuleCode"] != DBNull.Value) sys_Config_Fieled.D_ModuleCode = Convert.ToString(dr["D_ModuleCode"]);
            if (dr["D_NameSpace"] != DBNull.Value) sys_Config_Fieled.D_NameSpace = Convert.ToString(dr["D_NameSpace"]);
            if (dr["D_Index"] != DBNull.Value) sys_Config_Fieled.D_Index = Convert.ToString(dr["D_Index"]);
            if (dr["D_Type"] != DBNull.Value) sys_Config_Fieled.D_Type = Convert.ToString(dr["D_Type"]);
            if (dr["D_EditHidden"] != DBNull.Value) sys_Config_Fieled.D_EditHidden = Convert.ToString(dr["D_EditHidden"]);
            if (dr["D_Hidden"] != DBNull.Value) sys_Config_Fieled.D_Hidden = Convert.ToString(dr["D_Hidden"]);
            if (dr["D_EditReadOnly"] != DBNull.Value) sys_Config_Fieled.D_EditReadOnly = Convert.ToString(dr["D_EditReadOnly"]);
            if (dr["D_IsKey"] != DBNull.Value) sys_Config_Fieled.D_IsKey = Convert.ToInt32(dr["D_IsKey"]);
            if (dr["D_DefaultValue"] != DBNull.Value) sys_Config_Fieled.D_DefaultValue = Convert.ToString(dr["D_DefaultValue"]);
            if (dr["D_EditType"] != DBNull.Value) sys_Config_Fieled.D_EditType = Convert.ToString(dr["D_EditType"]);
            if (dr["D_OpenLayer"] != DBNull.Value) sys_Config_Fieled.D_OpenLayer = Convert.ToString(dr["D_OpenLayer"]);
            if (dr["D_Length"] != DBNull.Value) sys_Config_Fieled.D_Length = Convert.ToInt32(dr["D_Length"]);
            if (dr["D_Width"] != DBNull.Value) sys_Config_Fieled.D_Width = Convert.ToString(dr["D_Width"]);
            if (dr["D_Height"] != DBNull.Value) sys_Config_Fieled.D_Height = Convert.ToString(dr["D_Height"]);
            if (dr["D_Align"] != DBNull.Value) sys_Config_Fieled.D_Align = Convert.ToString(dr["D_Align"]);
            if (dr["D_Sortable"] != DBNull.Value) sys_Config_Fieled.D_Sortable = Convert.ToString(dr["D_Sortable"]);
            if (dr["D_Editable"] != DBNull.Value) sys_Config_Fieled.D_Editable = Convert.ToString(dr["D_Editable"]);
            if (dr["D_Editoptions"] != DBNull.Value) sys_Config_Fieled.D_Editoptions = Convert.ToString(dr["D_Editoptions"]);
            if (dr["D_EditRules"] != DBNull.Value) sys_Config_Fieled.D_EditRules = Convert.ToString(dr["D_EditRules"]);
            if (dr["D_FormOptions"] != DBNull.Value) sys_Config_Fieled.D_FormOptions = Convert.ToString(dr["D_FormOptions"]);
            if (dr["D_Formatter"] != DBNull.Value) sys_Config_Fieled.D_Formatter = Convert.ToString(dr["D_Formatter"]);
            if (dr["D_Searchoptions"] != DBNull.Value) sys_Config_Fieled.D_Searchoptions = Convert.ToString(dr["D_Searchoptions"]);
            if (dr["D_ShowOrder"] != DBNull.Value) sys_Config_Fieled.D_ShowOrder = Convert.ToInt32(dr["D_ShowOrder"]);
            if (dr["D_EditOrder"] != DBNull.Value) sys_Config_Fieled.D_EditOrder = Convert.ToInt32(dr["D_EditOrder"]);
            if (dr["D_DictKey"] != DBNull.Value) sys_Config_Fieled.D_DictKey = Convert.ToString(dr["D_DictKey"]);
            if (dr["D_DoEvent"] != DBNull.Value) sys_Config_Fieled.D_DoEvent = Convert.ToString(dr["D_DoEvent"]);
            if (dr["D_EditMessage"] != DBNull.Value) sys_Config_Fieled.D_EditMessage = Convert.ToString(dr["D_EditMessage"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Fieled.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["D_UDEF1"] != DBNull.Value) sys_Config_Fieled.D_UDEF1 = Convert.ToString(dr["D_UDEF1"]);
            if (dr["D_UDEF2"] != DBNull.Value) sys_Config_Fieled.D_UDEF2 = Convert.ToString(dr["D_UDEF2"]);
            if (dr["D_UDEF3"] != DBNull.Value) sys_Config_Fieled.D_UDEF3 = Convert.ToString(dr["D_UDEF3"]);
            if (dr["D_UDEF4"] != DBNull.Value) sys_Config_Fieled.D_UDEF4 = Convert.ToString(dr["D_UDEF4"]);
            if (dr["D_EditTab"] != DBNull.Value) sys_Config_Fieled.D_EditTab = Convert.ToString(dr["D_EditTab"]);
            if (dr["D_DBField"] != DBNull.Value) sys_Config_Fieled.D_DBField = Convert.ToString(dr["D_DBField"]);
            if (dr["D_Summary"] != DBNull.Value) sys_Config_Fieled.D_Summary = Convert.ToString(dr["D_Summary"]);
            if (dr["D_LinkUrl"] != DBNull.Value) sys_Config_Fieled.D_LinkUrl = Convert.ToString(dr["D_LinkUrl"]);
            if (dr["D_LinkParam"] != DBNull.Value) sys_Config_Fieled.D_LinkParam = Convert.ToString(dr["D_LinkParam"]);
            ret.Add(sys_Config_Fieled);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的字段配置表 Sys_Config_Fieled对象(即:一条记录
      /// </summary>
      public List<Sys_Config_Fieled> GetAll()
      {
         List<Sys_Config_Fieled> ret = new List<Sys_Config_Fieled>();
         string sql = "SELECT  D_ID,D_Name,D_ModuleCode,D_NameSpace,D_Index,D_Type,D_EditHidden,D_Hidden,D_EditReadOnly,D_IsKey,D_DefaultValue,D_EditType,D_OpenLayer,D_Length,D_Width,D_Height,D_Align,D_Sortable,D_Editable,D_Editoptions,D_EditRules,D_FormOptions,D_Formatter,D_Searchoptions,D_ShowOrder,D_EditOrder,D_DictKey,D_DoEvent,D_EditMessage,Stat,D_UDEF1,D_UDEF2,D_UDEF3,D_UDEF4,D_EditTab,D_DBField,D_Summary,D_LinkUrl,D_LinkParam FROM Sys_Config_Fieled where 1=1 AND ((Stat is null) or (Stat=0) ) order by D_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_Fieled sys_Config_Fieled = new Sys_Config_Fieled();
            if (dr["D_ID"] != DBNull.Value) sys_Config_Fieled.D_ID = Convert.ToInt32(dr["D_ID"]);
            if (dr["D_Name"] != DBNull.Value) sys_Config_Fieled.D_Name = Convert.ToString(dr["D_Name"]);
            if (dr["D_ModuleCode"] != DBNull.Value) sys_Config_Fieled.D_ModuleCode = Convert.ToString(dr["D_ModuleCode"]);
            if (dr["D_NameSpace"] != DBNull.Value) sys_Config_Fieled.D_NameSpace = Convert.ToString(dr["D_NameSpace"]);
            if (dr["D_Index"] != DBNull.Value) sys_Config_Fieled.D_Index = Convert.ToString(dr["D_Index"]);
            if (dr["D_Type"] != DBNull.Value) sys_Config_Fieled.D_Type = Convert.ToString(dr["D_Type"]);
            if (dr["D_EditHidden"] != DBNull.Value) sys_Config_Fieled.D_EditHidden = Convert.ToString(dr["D_EditHidden"]);
            if (dr["D_Hidden"] != DBNull.Value) sys_Config_Fieled.D_Hidden = Convert.ToString(dr["D_Hidden"]);
            if (dr["D_EditReadOnly"] != DBNull.Value) sys_Config_Fieled.D_EditReadOnly = Convert.ToString(dr["D_EditReadOnly"]);
            if (dr["D_IsKey"] != DBNull.Value) sys_Config_Fieled.D_IsKey = Convert.ToInt32(dr["D_IsKey"]);
            if (dr["D_DefaultValue"] != DBNull.Value) sys_Config_Fieled.D_DefaultValue = Convert.ToString(dr["D_DefaultValue"]);
            if (dr["D_EditType"] != DBNull.Value) sys_Config_Fieled.D_EditType = Convert.ToString(dr["D_EditType"]);
            if (dr["D_OpenLayer"] != DBNull.Value) sys_Config_Fieled.D_OpenLayer = Convert.ToString(dr["D_OpenLayer"]);
            if (dr["D_Length"] != DBNull.Value) sys_Config_Fieled.D_Length = Convert.ToInt32(dr["D_Length"]);
            if (dr["D_Width"] != DBNull.Value) sys_Config_Fieled.D_Width = Convert.ToString(dr["D_Width"]);
            if (dr["D_Height"] != DBNull.Value) sys_Config_Fieled.D_Height = Convert.ToString(dr["D_Height"]);
            if (dr["D_Align"] != DBNull.Value) sys_Config_Fieled.D_Align = Convert.ToString(dr["D_Align"]);
            if (dr["D_Sortable"] != DBNull.Value) sys_Config_Fieled.D_Sortable = Convert.ToString(dr["D_Sortable"]);
            if (dr["D_Editable"] != DBNull.Value) sys_Config_Fieled.D_Editable = Convert.ToString(dr["D_Editable"]);
            if (dr["D_Editoptions"] != DBNull.Value) sys_Config_Fieled.D_Editoptions = Convert.ToString(dr["D_Editoptions"]);
            if (dr["D_EditRules"] != DBNull.Value) sys_Config_Fieled.D_EditRules = Convert.ToString(dr["D_EditRules"]);
            if (dr["D_FormOptions"] != DBNull.Value) sys_Config_Fieled.D_FormOptions = Convert.ToString(dr["D_FormOptions"]);
            if (dr["D_Formatter"] != DBNull.Value) sys_Config_Fieled.D_Formatter = Convert.ToString(dr["D_Formatter"]);
            if (dr["D_Searchoptions"] != DBNull.Value) sys_Config_Fieled.D_Searchoptions = Convert.ToString(dr["D_Searchoptions"]);
            if (dr["D_ShowOrder"] != DBNull.Value) sys_Config_Fieled.D_ShowOrder = Convert.ToInt32(dr["D_ShowOrder"]);
            if (dr["D_EditOrder"] != DBNull.Value) sys_Config_Fieled.D_EditOrder = Convert.ToInt32(dr["D_EditOrder"]);
            if (dr["D_DictKey"] != DBNull.Value) sys_Config_Fieled.D_DictKey = Convert.ToString(dr["D_DictKey"]);
            if (dr["D_DoEvent"] != DBNull.Value) sys_Config_Fieled.D_DoEvent = Convert.ToString(dr["D_DoEvent"]);
            if (dr["D_EditMessage"] != DBNull.Value) sys_Config_Fieled.D_EditMessage = Convert.ToString(dr["D_EditMessage"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Fieled.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["D_UDEF1"] != DBNull.Value) sys_Config_Fieled.D_UDEF1 = Convert.ToString(dr["D_UDEF1"]);
            if (dr["D_UDEF2"] != DBNull.Value) sys_Config_Fieled.D_UDEF2 = Convert.ToString(dr["D_UDEF2"]);
            if (dr["D_UDEF3"] != DBNull.Value) sys_Config_Fieled.D_UDEF3 = Convert.ToString(dr["D_UDEF3"]);
            if (dr["D_UDEF4"] != DBNull.Value) sys_Config_Fieled.D_UDEF4 = Convert.ToString(dr["D_UDEF4"]);
            if (dr["D_EditTab"] != DBNull.Value) sys_Config_Fieled.D_EditTab = Convert.ToString(dr["D_EditTab"]);
            if (dr["D_DBField"] != DBNull.Value) sys_Config_Fieled.D_DBField = Convert.ToString(dr["D_DBField"]);
            if (dr["D_Summary"] != DBNull.Value) sys_Config_Fieled.D_Summary = Convert.ToString(dr["D_Summary"]);
            if (dr["D_LinkUrl"] != DBNull.Value) sys_Config_Fieled.D_LinkUrl = Convert.ToString(dr["D_LinkUrl"]);
            if (dr["D_LinkParam"] != DBNull.Value) sys_Config_Fieled.D_LinkParam = Convert.ToString(dr["D_LinkParam"]);
            ret.Add(sys_Config_Fieled);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
