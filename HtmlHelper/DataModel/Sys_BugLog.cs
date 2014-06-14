using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   /// <summary>
   /// Bug日志
   /// </summary>
   [Serializable]
   public partial class Sys_BugLog
   {
      private decimal sL_ID;
      private bool sL_ID_IsChanged=false;
      public decimal SL_ID
      {
         get{ return sL_ID; }
         set{ sL_ID = value; sL_ID_IsChanged=true; }
      }
      public bool SL_ID_IsChanged
      {
         get{ return sL_ID_IsChanged; }
         set{ sL_ID_IsChanged = value; }
      }
      /// <summary>
      /// Bug编码
      /// </summary>
      private string sL_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sL_Code_IsChanged=false;
      /// <summary>
      /// Bug编码
      /// </summary>
      public string SL_Code
      {
         get{ return sL_Code; }
         set{ sL_Code = value; sL_Code_IsChanged=true; }
      }
      /// <summary>
      /// Bug编码
      /// </summary>
      public bool SL_Code_IsChanged
      {
         get{ return sL_Code_IsChanged; }
         set{ sL_Code_IsChanged = value; }
      }
      /// <summary>
      /// 解决人
      /// </summary>
      private string sL_OpUser;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sL_OpUser_IsChanged=false;
      /// <summary>
      /// 解决人
      /// </summary>
      public string SL_OpUser
      {
         get{ return sL_OpUser; }
         set{ sL_OpUser = value; sL_OpUser_IsChanged=true; }
      }
      /// <summary>
      /// 解决人
      /// </summary>
      public bool SL_OpUser_IsChanged
      {
         get{ return sL_OpUser_IsChanged; }
         set{ sL_OpUser_IsChanged = value; }
      }
      /// <summary>
      /// 解决日期
      /// </summary>
      private DateTime sL_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sL_Date_IsChanged=false;
      /// <summary>
      /// 解决日期
      /// </summary>
      public DateTime SL_Date
      {
         get{ return sL_Date; }
         set{ sL_Date = value; sL_Date_IsChanged=true; }
      }
      /// <summary>
      /// 解决日期
      /// </summary>
      public bool SL_Date_IsChanged
      {
         get{ return sL_Date_IsChanged; }
         set{ sL_Date_IsChanged = value; }
      }
      /// <summary>
      /// Bug操作状态
      /// </summary>
      private string sL_Status;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sL_Status_IsChanged=false;
      /// <summary>
      /// Bug操作状态
      /// </summary>
      public string SL_Status
      {
         get{ return sL_Status; }
         set{ sL_Status = value; sL_Status_IsChanged=true; }
      }
      /// <summary>
      /// Bug操作状态
      /// </summary>
      public bool SL_Status_IsChanged
      {
         get{ return sL_Status_IsChanged; }
         set{ sL_Status_IsChanged = value; }
      }
      /// <summary>
      /// 转指派人
      /// </summary>
      private string sL_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sL_Owner_IsChanged=false;
      /// <summary>
      /// 转指派人
      /// </summary>
      public string SL_Owner
      {
         get{ return sL_Owner; }
         set{ sL_Owner = value; sL_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 转指派人
      /// </summary>
      public bool SL_Owner_IsChanged
      {
         get{ return sL_Owner_IsChanged; }
         set{ sL_Owner_IsChanged = value; }
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
