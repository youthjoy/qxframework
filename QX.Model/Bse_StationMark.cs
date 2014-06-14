using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_StationMark
   {
      private decimal sta_ID;
      private bool sta_ID_IsChanged=false;
      public decimal Sta_ID
      {
         get{ return sta_ID; }
         set{ sta_ID = value; sta_ID_IsChanged=true; }
      }
      public bool Sta_ID_IsChanged
      {
         get{ return sta_ID_IsChanged; }
         set{ sta_ID_IsChanged = value; }
      }
      private string sta_Code;
      private bool sta_Code_IsChanged=false;
      public string Sta_Code
      {
         get{ return sta_Code; }
         set{ sta_Code = value; sta_Code_IsChanged=true; }
      }
      public bool Sta_Code_IsChanged
      {
         get{ return sta_Code_IsChanged; }
         set{ sta_Code_IsChanged = value; }
      }
      private string sta_StationCode;
      private bool sta_StationCode_IsChanged=false;
      public string Sta_StationCode
      {
         get{ return sta_StationCode; }
         set{ sta_StationCode = value; sta_StationCode_IsChanged=true; }
      }
      public bool Sta_StationCode_IsChanged
      {
         get{ return sta_StationCode_IsChanged; }
         set{ sta_StationCode_IsChanged = value; }
      }
      private string sta_Name;
      private bool sta_Name_IsChanged=false;
      public string Sta_Name
      {
         get{ return sta_Name; }
         set{ sta_Name = value; sta_Name_IsChanged=true; }
      }
      public bool Sta_Name_IsChanged
      {
         get{ return sta_Name_IsChanged; }
         set{ sta_Name_IsChanged = value; }
      }
      private decimal sta_X;
      private bool sta_X_IsChanged=false;
      public decimal Sta_X
      {
         get{ return sta_X; }
         set{ sta_X = value; sta_X_IsChanged=true; }
      }
      public bool Sta_X_IsChanged
      {
         get{ return sta_X_IsChanged; }
         set{ sta_X_IsChanged = value; }
      }
      private decimal sta_Y;
      private bool sta_Y_IsChanged=false;
      public decimal Sta_Y
      {
         get{ return sta_Y; }
         set{ sta_Y = value; sta_Y_IsChanged=true; }
      }
      public bool Sta_Y_IsChanged
      {
         get{ return sta_Y_IsChanged; }
         set{ sta_Y_IsChanged = value; }
      }
      private decimal sta_Width;
      private bool sta_Width_IsChanged=false;
      public decimal Sta_Width
      {
         get{ return sta_Width; }
         set{ sta_Width = value; sta_Width_IsChanged=true; }
      }
      public bool Sta_Width_IsChanged
      {
         get{ return sta_Width_IsChanged; }
         set{ sta_Width_IsChanged = value; }
      }
      private decimal sta_Height;
      private bool sta_Height_IsChanged=false;
      public decimal Sta_Height
      {
         get{ return sta_Height; }
         set{ sta_Height = value; sta_Height_IsChanged=true; }
      }
      public bool Sta_Height_IsChanged
      {
         get{ return sta_Height_IsChanged; }
         set{ sta_Height_IsChanged = value; }
      }
      private string sta_Background;
      private bool sta_Background_IsChanged=false;
      public string Sta_Background
      {
         get{ return sta_Background; }
         set{ sta_Background = value; sta_Background_IsChanged=true; }
      }
      public bool Sta_Background_IsChanged
      {
         get{ return sta_Background_IsChanged; }
         set{ sta_Background_IsChanged = value; }
      }
      private string sta_Color;
      private bool sta_Color_IsChanged=false;
      public string Sta_Color
      {
         get{ return sta_Color; }
         set{ sta_Color = value; sta_Color_IsChanged=true; }
      }
      public bool Sta_Color_IsChanged
      {
         get{ return sta_Color_IsChanged; }
         set{ sta_Color_IsChanged = value; }
      }
      private string sta_Stat;
      private bool sta_Stat_IsChanged=false;
      public string Sta_Stat
      {
         get{ return sta_Stat; }
         set{ sta_Stat = value; sta_Stat_IsChanged=true; }
      }
      public bool Sta_Stat_IsChanged
      {
         get{ return sta_Stat_IsChanged; }
         set{ sta_Stat_IsChanged = value; }
      }
      private string sta_Type;
      private bool sta_Type_IsChanged=false;
      public string Sta_Type
      {
         get{ return sta_Type; }
         set{ sta_Type = value; sta_Type_IsChanged=true; }
      }
      public bool Sta_Type_IsChanged
      {
         get{ return sta_Type_IsChanged; }
         set{ sta_Type_IsChanged = value; }
      }
      private string sta_Bak;
      private bool sta_Bak_IsChanged=false;
      public string Sta_Bak
      {
         get{ return sta_Bak; }
         set{ sta_Bak = value; sta_Bak_IsChanged=true; }
      }
      public bool Sta_Bak_IsChanged
      {
         get{ return sta_Bak_IsChanged; }
         set{ sta_Bak_IsChanged = value; }
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
