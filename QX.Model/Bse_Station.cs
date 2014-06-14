using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_Station
   {
      private decimal sN_ID;
      private bool sN_ID_IsChanged=false;
      public decimal SN_ID
      {
         get{ return sN_ID; }
         set{ sN_ID = value; sN_ID_IsChanged=true; }
      }
      public bool SN_ID_IsChanged
      {
         get{ return sN_ID_IsChanged; }
         set{ sN_ID_IsChanged = value; }
      }
      private string sN_Code;
      private bool sN_Code_IsChanged=false;
      public string SN_Code
      {
         get{ return sN_Code; }
         set{ sN_Code = value; sN_Code_IsChanged=true; }
      }
      public bool SN_Code_IsChanged
      {
         get{ return sN_Code_IsChanged; }
         set{ sN_Code_IsChanged = value; }
      }
      private string sN_Name;
      private bool sN_Name_IsChanged=false;
      public string SN_Name
      {
         get{ return sN_Name; }
         set{ sN_Name = value; sN_Name_IsChanged=true; }
      }
      public bool SN_Name_IsChanged
      {
         get{ return sN_Name_IsChanged; }
         set{ sN_Name_IsChanged = value; }
      }
      private string sN_AreaCode;
      private bool sN_AreaCode_IsChanged=false;
      public string SN_AreaCode
      {
         get{ return sN_AreaCode; }
         set{ sN_AreaCode = value; sN_AreaCode_IsChanged=true; }
      }
      public bool SN_AreaCode_IsChanged
      {
         get{ return sN_AreaCode_IsChanged; }
         set{ sN_AreaCode_IsChanged = value; }
      }
      private string sN_AreaName;
      private bool sN_AreaName_IsChanged=false;
      public string SN_AreaName
      {
         get{ return sN_AreaName; }
         set{ sN_AreaName = value; sN_AreaName_IsChanged=true; }
      }
      public bool SN_AreaName_IsChanged
      {
         get{ return sN_AreaName_IsChanged; }
         set{ sN_AreaName_IsChanged = value; }
      }
      private string sN_Mark;
      private bool sN_Mark_IsChanged=false;
      public string SN_Mark
      {
         get{ return sN_Mark; }
         set{ sN_Mark = value; sN_Mark_IsChanged=true; }
      }
      public bool SN_Mark_IsChanged
      {
         get{ return sN_Mark_IsChanged; }
         set{ sN_Mark_IsChanged = value; }
      }
      private string sN_Number;
      private bool sN_Number_IsChanged=false;
      public string SN_Number
      {
         get{ return sN_Number; }
         set{ sN_Number = value; sN_Number_IsChanged=true; }
      }
      public bool SN_Number_IsChanged
      {
         get{ return sN_Number_IsChanged; }
         set{ sN_Number_IsChanged = value; }
      }
      private string sN_Bak;
      private bool sN_Bak_IsChanged=false;
      public string SN_Bak
      {
         get{ return sN_Bak; }
         set{ sN_Bak = value; sN_Bak_IsChanged=true; }
      }
      public bool SN_Bak_IsChanged
      {
         get{ return sN_Bak_IsChanged; }
         set{ sN_Bak_IsChanged = value; }
      }
      private float sN_Interval;
      private bool sN_Interval_IsChanged=false;
      public float SN_Interval
      {
         get{ return sN_Interval; }
         set{ sN_Interval = value; sN_Interval_IsChanged=true; }
      }
      public bool SN_Interval_IsChanged
      {
         get{ return sN_Interval_IsChanged; }
         set{ sN_Interval_IsChanged = value; }
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
      private DateTime createTime;
      private bool createTime_IsChanged=false;
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
      private DateTime updateTime;
      private bool updateTime_IsChanged=false;
      public DateTime UpdateTime
      {
         get{ return updateTime; }
         set{ updateTime = value; updateTime_IsChanged=true; }
      }
      public bool UpdateTime_IsChanged
      {
         get{ return updateTime_IsChanged; }
         set{ updateTime_IsChanged = value; }
      }
      private DateTime deleteTime;
      private bool deleteTime_IsChanged=false;
      public DateTime DeleteTime
      {
         get{ return deleteTime; }
         set{ deleteTime = value; deleteTime_IsChanged=true; }
      }
      public bool DeleteTime_IsChanged
      {
         get{ return deleteTime_IsChanged; }
         set{ deleteTime_IsChanged = value; }
      }
   }
}
