using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   ///    
   /// </summary>
   [Serializable]
   public partial class Bse_Area
   {
      private decimal area_ID;
      private bool area_ID_IsChanged=false;
      public decimal Area_ID
      {
         get{ return area_ID; }
         set{ area_ID = value; area_ID_IsChanged=true; }
      }
      public bool Area_ID_IsChanged
      {
         get{ return area_ID_IsChanged; }
         set{ area_ID_IsChanged = value; }
      }
      private string area_Code;
      private bool area_Code_IsChanged=false;
      public string Area_Code
      {
         get{ return area_Code; }
         set{ area_Code = value; area_Code_IsChanged=true; }
      }
      public bool Area_Code_IsChanged
      {
         get{ return area_Code_IsChanged; }
         set{ area_Code_IsChanged = value; }
      }
      private string area_Mark;
      private bool area_Mark_IsChanged=false;
      public string Area_Mark
      {
         get{ return area_Mark; }
         set{ area_Mark = value; area_Mark_IsChanged=true; }
      }
      public bool Area_Mark_IsChanged
      {
         get{ return area_Mark_IsChanged; }
         set{ area_Mark_IsChanged = value; }
      }
      private string area_Name;
      private bool area_Name_IsChanged=false;
      public string Area_Name
      {
         get{ return area_Name; }
         set{ area_Name = value; area_Name_IsChanged=true; }
      }
      public bool Area_Name_IsChanged
      {
         get{ return area_Name_IsChanged; }
         set{ area_Name_IsChanged = value; }
      }
      private string area_Addr;
      private bool area_Addr_IsChanged=false;
      public string Area_Addr
      {
         get{ return area_Addr; }
         set{ area_Addr = value; area_Addr_IsChanged=true; }
      }
      public bool Area_Addr_IsChanged
      {
         get{ return area_Addr_IsChanged; }
         set{ area_Addr_IsChanged = value; }
      }
      private string area_PCode;
      private bool area_PCode_IsChanged=false;
      public string Area_PCode
      {
         get{ return area_PCode; }
         set{ area_PCode = value; area_PCode_IsChanged=true; }
      }
      public bool Area_PCode_IsChanged
      {
         get{ return area_PCode_IsChanged; }
         set{ area_PCode_IsChanged = value; }
      }
      private string area_PName;
      private bool area_PName_IsChanged=false;
      public string Area_PName
      {
         get{ return area_PName; }
         set{ area_PName = value; area_PName_IsChanged=true; }
      }
      public bool Area_PName_IsChanged
      {
         get{ return area_PName_IsChanged; }
         set{ area_PName_IsChanged = value; }
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
