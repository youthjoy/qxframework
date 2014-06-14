using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.HtmlHelperLib.Model
{
   /// <summary>
   /// Sys_LoginLog
   /// </summary>
   [Serializable]
   public partial class Sys_LoginLog
   {
      private decimal eL_ID;
      private bool eL_ID_IsChanged=false;
      public decimal EL_ID
      {
         get{ return eL_ID; }
         set{ eL_ID = value; eL_ID_IsChanged=true; }
      }
      public bool EL_ID_IsChanged
      {
         get{ return eL_ID_IsChanged; }
         set{ eL_ID_IsChanged = value; }
      }
      private DateTime eL_Date;
      private bool eL_Date_IsChanged=false;
      public DateTime EL_Date
      {
         get{ return eL_Date; }
         set{ eL_Date = value; eL_Date_IsChanged=true; }
      }
      public bool EL_Date_IsChanged
      {
         get{ return eL_Date_IsChanged; }
         set{ eL_Date_IsChanged = value; }
      }
      private string eL_IP;
      private bool eL_IP_IsChanged=false;
      public string EL_IP
      {
         get{ return eL_IP; }
         set{ eL_IP = value; eL_IP_IsChanged=true; }
      }
      public bool EL_IP_IsChanged
      {
         get{ return eL_IP_IsChanged; }
         set{ eL_IP_IsChanged = value; }
      }
      private string eL_Mac;
      private bool eL_Mac_IsChanged=false;
      public string EL_Mac
      {
         get{ return eL_Mac; }
         set{ eL_Mac = value; eL_Mac_IsChanged=true; }
      }
      public bool EL_Mac_IsChanged
      {
         get{ return eL_Mac_IsChanged; }
         set{ eL_Mac_IsChanged = value; }
      }
      private string eL_Success;
      private bool eL_Success_IsChanged=false;
      public string EL_Success
      {
         get{ return eL_Success; }
         set{ eL_Success = value; eL_Success_IsChanged=true; }
      }
      public bool EL_Success_IsChanged
      {
         get{ return eL_Success_IsChanged; }
         set{ eL_Success_IsChanged = value; }
      }
      private string eL_UserCode;
      private bool eL_UserCode_IsChanged=false;
      public string EL_UserCode
      {
         get{ return eL_UserCode; }
         set{ eL_UserCode = value; eL_UserCode_IsChanged=true; }
      }
      public bool EL_UserCode_IsChanged
      {
         get{ return eL_UserCode_IsChanged; }
         set{ eL_UserCode_IsChanged = value; }
      }
      private string eL_UserName;
      private bool eL_UserName_IsChanged=false;
      public string EL_UserName
      {
         get{ return eL_UserName; }
         set{ eL_UserName = value; eL_UserName_IsChanged=true; }
      }
      public bool EL_UserName_IsChanged
      {
         get{ return eL_UserName_IsChanged; }
         set{ eL_UserName_IsChanged = value; }
      }
      private string eL_Dept;
      private bool eL_Dept_IsChanged=false;
      public string EL_Dept
      {
         get{ return eL_Dept; }
         set{ eL_Dept = value; eL_Dept_IsChanged=true; }
      }
      public bool EL_Dept_IsChanged
      {
         get{ return eL_Dept_IsChanged; }
         set{ eL_Dept_IsChanged = value; }
      }
      private string eL_Company;
      private bool eL_Company_IsChanged=false;
      public string EL_Company
      {
         get{ return eL_Company; }
         set{ eL_Company = value; eL_Company_IsChanged=true; }
      }
      public bool EL_Company_IsChanged
      {
         get{ return eL_Company_IsChanged; }
         set{ eL_Company_IsChanged = value; }
      }
      private DateTime eL_CancleDate;
      private bool eL_CancleDate_IsChanged=false;
      public DateTime EL_CancleDate
      {
         get{ return eL_CancleDate; }
         set{ eL_CancleDate = value; eL_CancleDate_IsChanged=true; }
      }
      public bool EL_CancleDate_IsChanged
      {
         get{ return eL_CancleDate_IsChanged; }
         set{ eL_CancleDate_IsChanged = value; }
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
