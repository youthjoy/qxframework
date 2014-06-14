using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   /// <summary>
   /// Bug管理系统
   /// </summary>
   [Serializable]
   public partial class Sys_Bug
   {
      private decimal sys_ID;
      private bool sys_ID_IsChanged=false;
      public decimal Sys_ID
      {
         get{ return sys_ID; }
         set{ sys_ID = value; sys_ID_IsChanged=true; }
      }
      public bool Sys_ID_IsChanged
      {
         get{ return sys_ID_IsChanged; }
         set{ sys_ID_IsChanged = value; }
      }
      /// <summary>
      /// Bug编码
      /// </summary>
      private string sys_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Code_IsChanged=false;
      /// <summary>
      /// Bug编码
      /// </summary>
      public string Sys_Code
      {
         get{ return sys_Code; }
         set{ sys_Code = value; sys_Code_IsChanged=true; }
      }
      /// <summary>
      /// Bug编码
      /// </summary>
      public bool Sys_Code_IsChanged
      {
         get{ return sys_Code_IsChanged; }
         set{ sys_Code_IsChanged = value; }
      }
      /// <summary>
      /// Bug日期
      /// </summary>
      private DateTime sys_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Date_IsChanged=false;
      /// <summary>
      /// Bug日期
      /// </summary>
      public DateTime Sys_Date
      {
         get{ return sys_Date; }
         set{ sys_Date = value; sys_Date_IsChanged=true; }
      }
      /// <summary>
      /// Bug日期
      /// </summary>
      public bool Sys_Date_IsChanged
      {
         get{ return sys_Date_IsChanged; }
         set{ sys_Date_IsChanged = value; }
      }
      /// <summary>
      /// Bug标题
      /// </summary>
      private string sys_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Title_IsChanged=false;
      /// <summary>
      /// Bug标题
      /// </summary>
      public string Sys_Title
      {
         get{ return sys_Title; }
         set{ sys_Title = value; sys_Title_IsChanged=true; }
      }
      /// <summary>
      /// Bug标题
      /// </summary>
      public bool Sys_Title_IsChanged
      {
         get{ return sys_Title_IsChanged; }
         set{ sys_Title_IsChanged = value; }
      }
      /// <summary>
      /// Bug描述
      /// </summary>
      private string sys_Des;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Des_IsChanged=false;
      /// <summary>
      /// Bug描述
      /// </summary>
      public string Sys_Des
      {
         get{ return sys_Des; }
         set{ sys_Des = value; sys_Des_IsChanged=true; }
      }
      /// <summary>
      /// Bug描述
      /// </summary>
      public bool Sys_Des_IsChanged
      {
         get{ return sys_Des_IsChanged; }
         set{ sys_Des_IsChanged = value; }
      }
      private string sys_Project;
      private bool sys_Project_IsChanged=false;
      public string Sys_Project
      {
         get{ return sys_Project; }
         set{ sys_Project = value; sys_Project_IsChanged=true; }
      }
      public bool Sys_Project_IsChanged
      {
         get{ return sys_Project_IsChanged; }
         set{ sys_Project_IsChanged = value; }
      }
      /// <summary>
      /// Bug模块
      /// </summary>
      private string sys_Module;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Module_IsChanged=false;
      /// <summary>
      /// Bug模块
      /// </summary>
      public string Sys_Module
      {
         get{ return sys_Module; }
         set{ sys_Module = value; sys_Module_IsChanged=true; }
      }
      /// <summary>
      /// Bug模块
      /// </summary>
      public bool Sys_Module_IsChanged
      {
         get{ return sys_Module_IsChanged; }
         set{ sys_Module_IsChanged = value; }
      }
      /// <summary>
      /// 用户编码
      /// </summary>
      private string sys_UserCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_UserCode_IsChanged=false;
      /// <summary>
      /// 用户编码
      /// </summary>
      public string Sys_UserCode
      {
         get{ return sys_UserCode; }
         set{ sys_UserCode = value; sys_UserCode_IsChanged=true; }
      }
      /// <summary>
      /// 用户编码
      /// </summary>
      public bool Sys_UserCode_IsChanged
      {
         get{ return sys_UserCode_IsChanged; }
         set{ sys_UserCode_IsChanged = value; }
      }
      /// <summary>
      /// 用户名称
      /// </summary>
      private string sys_UserName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_UserName_IsChanged=false;
      /// <summary>
      /// 用户名称
      /// </summary>
      public string Sys_UserName
      {
         get{ return sys_UserName; }
         set{ sys_UserName = value; sys_UserName_IsChanged=true; }
      }
      /// <summary>
      /// 用户名称
      /// </summary>
      public bool Sys_UserName_IsChanged
      {
         get{ return sys_UserName_IsChanged; }
         set{ sys_UserName_IsChanged = value; }
      }
      /// <summary>
      /// 负责人
      /// </summary>
      private string sys_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Owner_IsChanged=false;
      /// <summary>
      /// 负责人
      /// </summary>
      public string Sys_Owner
      {
         get{ return sys_Owner; }
         set{ sys_Owner = value; sys_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 负责人
      /// </summary>
      public bool Sys_Owner_IsChanged
      {
         get{ return sys_Owner_IsChanged; }
         set{ sys_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 解决人
      /// </summary>
      private string sys_OpUser;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_OpUser_IsChanged=false;
      /// <summary>
      /// 解决人
      /// </summary>
      public string Sys_OpUser
      {
         get{ return sys_OpUser; }
         set{ sys_OpUser = value; sys_OpUser_IsChanged=true; }
      }
      /// <summary>
      /// 解决人
      /// </summary>
      public bool Sys_OpUser_IsChanged
      {
         get{ return sys_OpUser_IsChanged; }
         set{ sys_OpUser_IsChanged = value; }
      }
      /// <summary>
      /// Bug状态
      /// </summary>
      private string sys_Status;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Status_IsChanged=false;
      /// <summary>
      /// Bug状态
      /// </summary>
      public string Sys_Status
      {
         get{ return sys_Status; }
         set{ sys_Status = value; sys_Status_IsChanged=true; }
      }
      /// <summary>
      /// Bug状态
      /// </summary>
      public bool Sys_Status_IsChanged
      {
         get{ return sys_Status_IsChanged; }
         set{ sys_Status_IsChanged = value; }
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
