using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   /// <summary>
   /// 通用参考主表
   /// </summary>
   [Serializable]
   public partial class Sys_Config_Refer
   {
      private decimal r_ID;
      private bool r_ID_IsChanged=false;
      public decimal R_ID
      {
         get{ return r_ID; }
         set{ r_ID = value; r_ID_IsChanged=true; }
      }
      public bool R_ID_IsChanged
      {
         get{ return r_ID_IsChanged; }
         set{ r_ID_IsChanged = value; }
      }
      private string r_ModuleName;
      private bool r_ModuleName_IsChanged=false;
      public string R_ModuleName
      {
         get{ return r_ModuleName; }
         set{ r_ModuleName = value; r_ModuleName_IsChanged=true; }
      }
      public bool R_ModuleName_IsChanged
      {
         get{ return r_ModuleName_IsChanged; }
         set{ r_ModuleName_IsChanged = value; }
      }
      private string r_NameSpace;
      private bool r_NameSpace_IsChanged=false;
      public string R_NameSpace
      {
         get{ return r_NameSpace; }
         set{ r_NameSpace = value; r_NameSpace_IsChanged=true; }
      }
      public bool R_NameSpace_IsChanged
      {
         get{ return r_NameSpace_IsChanged; }
         set{ r_NameSpace_IsChanged = value; }
      }
      private string r_Title;
      private bool r_Title_IsChanged=false;
      public string R_Title
      {
         get{ return r_Title; }
         set{ r_Title = value; r_Title_IsChanged=true; }
      }
      public bool R_Title_IsChanged
      {
         get{ return r_Title_IsChanged; }
         set{ r_Title_IsChanged = value; }
      }
      private int r_Width;
      private bool r_Width_IsChanged=false;
      public int R_Width
      {
         get{ return r_Width; }
         set{ r_Width = value; r_Width_IsChanged=true; }
      }
      public bool R_Width_IsChanged
      {
         get{ return r_Width_IsChanged; }
         set{ r_Width_IsChanged = value; }
      }
      private int r_Height;
      private bool r_Height_IsChanged=false;
      public int R_Height
      {
         get{ return r_Height; }
         set{ r_Height = value; r_Height_IsChanged=true; }
      }
      public bool R_Height_IsChanged
      {
         get{ return r_Height_IsChanged; }
         set{ r_Height_IsChanged = value; }
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
      private string r_TableName;
      private bool r_TableName_IsChanged=false;
      public string R_TableName
      {
         get{ return r_TableName; }
         set{ r_TableName = value; r_TableName_IsChanged=true; }
      }
      public bool R_TableName_IsChanged
      {
         get{ return r_TableName_IsChanged; }
         set{ r_TableName_IsChanged = value; }
      }
      private string r_FilterSql;
      private bool r_FilterSql_IsChanged=false;
      public string R_FilterSql
      {
         get{ return r_FilterSql; }
         set{ r_FilterSql = value; r_FilterSql_IsChanged=true; }
      }
      public bool R_FilterSql_IsChanged
      {
         get{ return r_FilterSql_IsChanged; }
         set{ r_FilterSql_IsChanged = value; }
      }
      private string r_SQL;
      private bool r_SQL_IsChanged=false;
      public string R_SQL
      {
         get{ return r_SQL; }
         set{ r_SQL = value; r_SQL_IsChanged=true; }
      }
      public bool R_SQL_IsChanged
      {
         get{ return r_SQL_IsChanged; }
         set{ r_SQL_IsChanged = value; }
      }
      private string r_Url;
      private bool r_Url_IsChanged=false;
      public string R_Url
      {
         get{ return r_Url; }
         set{ r_Url = value; r_Url_IsChanged=true; }
      }
      public bool R_Url_IsChanged
      {
         get{ return r_Url_IsChanged; }
         set{ r_Url_IsChanged = value; }
      }
      private string r_Tool;
      private bool r_Tool_IsChanged=false;
      public string R_Tool
      {
         get{ return r_Tool; }
         set{ r_Tool = value; r_Tool_IsChanged=true; }
      }
      public bool R_Tool_IsChanged
      {
         get{ return r_Tool_IsChanged; }
         set{ r_Tool_IsChanged = value; }
      }
   }
}
