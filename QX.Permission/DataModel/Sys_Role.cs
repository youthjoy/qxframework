using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Permission.Model
{
   [Serializable]
   public partial class Sys_Role
   {
      private decimal sRole_ID;
      private bool sRole_ID_IsChanged=false;
      public decimal SRole_ID
      {
         get{ return sRole_ID; }
         set{ sRole_ID = value; sRole_ID_IsChanged=true; }
      }
      public bool SRole_ID_IsChanged
      {
         get{ return sRole_ID_IsChanged; }
         set{ sRole_ID_IsChanged = value; }
      }
      private string sRole_Code;
      private bool sRole_Code_IsChanged=false;
      public string SRole_Code
      {
         get{ return sRole_Code; }
         set{ sRole_Code = value; sRole_Code_IsChanged=true; }
      }
      public bool SRole_Code_IsChanged
      {
         get{ return sRole_Code_IsChanged; }
         set{ sRole_Code_IsChanged = value; }
      }
      private string sRole_Name;
      private bool sRole_Name_IsChanged=false;
      public string SRole_Name
      {
         get{ return sRole_Name; }
         set{ sRole_Name = value; sRole_Name_IsChanged=true; }
      }
      public bool SRole_Name_IsChanged
      {
         get{ return sRole_Name_IsChanged; }
         set{ sRole_Name_IsChanged = value; }
      }
      private string sRole_Type;
      private bool sRole_Type_IsChanged=false;
      public string SRole_Type
      {
         get{ return sRole_Type; }
         set{ sRole_Type = value; sRole_Type_IsChanged=true; }
      }
      public bool SRole_Type_IsChanged
      {
         get{ return sRole_Type_IsChanged; }
         set{ sRole_Type_IsChanged = value; }
      }
      private string sRole_iType;
      private bool sRole_iType_IsChanged=false;
      public string SRole_iType
      {
         get{ return sRole_iType; }
         set{ sRole_iType = value; sRole_iType_IsChanged=true; }
      }
      public bool SRole_iType_IsChanged
      {
         get{ return sRole_iType_IsChanged; }
         set{ sRole_iType_IsChanged = value; }
      }
      private string sRole_Stat;
      private bool sRole_Stat_IsChanged=false;
      public string SRole_Stat
      {
         get{ return sRole_Stat; }
         set{ sRole_Stat = value; sRole_Stat_IsChanged=true; }
      }
      public bool SRole_Stat_IsChanged
      {
         get{ return sRole_Stat_IsChanged; }
         set{ sRole_Stat_IsChanged = value; }
      }
      private string sRole_UCode;
      private bool sRole_UCode_IsChanged=false;
      public string SRole_UCode
      {
         get{ return sRole_UCode; }
         set{ sRole_UCode = value; sRole_UCode_IsChanged=true; }
      }
      public bool SRole_UCode_IsChanged
      {
         get{ return sRole_UCode_IsChanged; }
         set{ sRole_UCode_IsChanged = value; }
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
   }
}
