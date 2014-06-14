using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_CheckValue
   {
      private decimal sC_ID;
      private bool sC_ID_IsChanged=false;
      public decimal SC_ID
      {
         get{ return sC_ID; }
         set{ sC_ID = value; sC_ID_IsChanged=true; }
      }
      public bool SC_ID_IsChanged
      {
         get{ return sC_ID_IsChanged; }
         set{ sC_ID_IsChanged = value; }
      }
      private string sC_Code;
      private bool sC_Code_IsChanged=false;
      public string SC_Code
      {
         get{ return sC_Code; }
         set{ sC_Code = value; sC_Code_IsChanged=true; }
      }
      public bool SC_Code_IsChanged
      {
         get{ return sC_Code_IsChanged; }
         set{ sC_Code_IsChanged = value; }
      }
      private string sC_StationCode;
      private bool sC_StationCode_IsChanged=false;
      public string SC_StationCode
      {
         get{ return sC_StationCode; }
         set{ sC_StationCode = value; sC_StationCode_IsChanged=true; }
      }
      public bool SC_StationCode_IsChanged
      {
         get{ return sC_StationCode_IsChanged; }
         set{ sC_StationCode_IsChanged = value; }
      }
      private string sC_StatName;
      private bool sC_StatName_IsChanged=false;
      public string SC_StatName
      {
         get{ return sC_StatName; }
         set{ sC_StatName = value; sC_StatName_IsChanged=true; }
      }
      public bool SC_StatName_IsChanged
      {
         get{ return sC_StatName_IsChanged; }
         set{ sC_StatName_IsChanged = value; }
      }
      private string sC_Source;
      private bool sC_Source_IsChanged=false;
      public string SC_Source
      {
         get{ return sC_Source; }
         set{ sC_Source = value; sC_Source_IsChanged=true; }
      }
      public bool SC_Source_IsChanged
      {
         get{ return sC_Source_IsChanged; }
         set{ sC_Source_IsChanged = value; }
      }
      private string sC_Position;
      private bool sC_Position_IsChanged=false;
      public string SC_Position
      {
         get{ return sC_Position; }
         set{ sC_Position = value; sC_Position_IsChanged=true; }
      }
      public bool SC_Position_IsChanged
      {
         get{ return sC_Position_IsChanged; }
         set{ sC_Position_IsChanged = value; }
      }
      private string sC_Alarm;
      private bool sC_Alarm_IsChanged=false;
      public string SC_Alarm
      {
         get{ return sC_Alarm; }
         set{ sC_Alarm = value; sC_Alarm_IsChanged=true; }
      }
      public bool SC_Alarm_IsChanged
      {
         get{ return sC_Alarm_IsChanged; }
         set{ sC_Alarm_IsChanged = value; }
      }
      private string sC_Warn;
      private bool sC_Warn_IsChanged=false;
      public string SC_Warn
      {
         get{ return sC_Warn; }
         set{ sC_Warn = value; sC_Warn_IsChanged=true; }
      }
      public bool SC_Warn_IsChanged
      {
         get{ return sC_Warn_IsChanged; }
         set{ sC_Warn_IsChanged = value; }
      }
      private string sC_Bak1;
      private bool sC_Bak1_IsChanged=false;
      public string SC_Bak1
      {
         get{ return sC_Bak1; }
         set{ sC_Bak1 = value; sC_Bak1_IsChanged=true; }
      }
      public bool SC_Bak1_IsChanged
      {
         get{ return sC_Bak1_IsChanged; }
         set{ sC_Bak1_IsChanged = value; }
      }
      private string sC_Bak2;
      private bool sC_Bak2_IsChanged=false;
      public string SC_Bak2
      {
         get{ return sC_Bak2; }
         set{ sC_Bak2 = value; sC_Bak2_IsChanged=true; }
      }
      public bool SC_Bak2_IsChanged
      {
         get{ return sC_Bak2_IsChanged; }
         set{ sC_Bak2_IsChanged = value; }
      }
      private string sC_iType;
      private bool sC_iType_IsChanged=false;
      public string SC_iType
      {
         get{ return sC_iType; }
         set{ sC_iType = value; sC_iType_IsChanged=true; }
      }
      public bool SC_iType_IsChanged
      {
         get{ return sC_iType_IsChanged; }
         set{ sC_iType_IsChanged = value; }
      }
      private string sC_Rate;
      private bool sC_Rate_IsChanged=false;
      public string SC_Rate
      {
         get{ return sC_Rate; }
         set{ sC_Rate = value; sC_Rate_IsChanged=true; }
      }
      public bool SC_Rate_IsChanged
      {
         get{ return sC_Rate_IsChanged; }
         set{ sC_Rate_IsChanged = value; }
      }
      private string sC_Stat;
      private bool sC_Stat_IsChanged=false;
      public string SC_Stat
      {
         get{ return sC_Stat; }
         set{ sC_Stat = value; sC_Stat_IsChanged=true; }
      }
      public bool SC_Stat_IsChanged
      {
         get{ return sC_Stat_IsChanged; }
         set{ sC_Stat_IsChanged = value; }
      }
      private string sC_StatNames;
      private bool sC_StatNames_IsChanged=false;
      public string SC_StatNames
      {
         get{ return sC_StatNames; }
         set{ sC_StatNames = value; sC_StatNames_IsChanged=true; }
      }
      public bool SC_StatNames_IsChanged
      {
         get{ return sC_StatNames_IsChanged; }
         set{ sC_StatNames_IsChanged = value; }
      }
      private string sC_RefCode;
      private bool sC_RefCode_IsChanged=false;
      public string SC_RefCode
      {
         get{ return sC_RefCode; }
         set{ sC_RefCode = value; sC_RefCode_IsChanged=true; }
      }
      public bool SC_RefCode_IsChanged
      {
         get{ return sC_RefCode_IsChanged; }
         set{ sC_RefCode_IsChanged = value; }
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
