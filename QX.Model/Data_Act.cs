using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Data_Act
   {
      private decimal data_ID;
      private bool data_ID_IsChanged=false;
      public decimal Data_ID
      {
         get{ return data_ID; }
         set{ data_ID = value; data_ID_IsChanged=true; }
      }
      public bool Data_ID_IsChanged
      {
         get{ return data_ID_IsChanged; }
         set{ data_ID_IsChanged = value; }
      }
      private string data_StationCode;
      private bool data_StationCode_IsChanged=false;
      public string Data_StationCode
      {
         get{ return data_StationCode; }
         set{ data_StationCode = value; data_StationCode_IsChanged=true; }
      }
      public bool Data_StationCode_IsChanged
      {
         get{ return data_StationCode_IsChanged; }
         set{ data_StationCode_IsChanged = value; }
      }
      private string data_Val1;
      private bool data_Val1_IsChanged=false;
      public string Data_Val1
      {
         get{ return data_Val1; }
         set{ data_Val1 = value; data_Val1_IsChanged=true; }
      }
      public bool Data_Val1_IsChanged
      {
         get{ return data_Val1_IsChanged; }
         set{ data_Val1_IsChanged = value; }
      }
      private string data_Val2;
      private bool data_Val2_IsChanged=false;
      public string Data_Val2
      {
         get{ return data_Val2; }
         set{ data_Val2 = value; data_Val2_IsChanged=true; }
      }
      public bool Data_Val2_IsChanged
      {
         get{ return data_Val2_IsChanged; }
         set{ data_Val2_IsChanged = value; }
      }
      private string data_Val3;
      private bool data_Val3_IsChanged=false;
      public string Data_Val3
      {
         get{ return data_Val3; }
         set{ data_Val3 = value; data_Val3_IsChanged=true; }
      }
      public bool Data_Val3_IsChanged
      {
         get{ return data_Val3_IsChanged; }
         set{ data_Val3_IsChanged = value; }
      }
      private string data_Val4;
      private bool data_Val4_IsChanged=false;
      public string Data_Val4
      {
         get{ return data_Val4; }
         set{ data_Val4 = value; data_Val4_IsChanged=true; }
      }
      public bool Data_Val4_IsChanged
      {
         get{ return data_Val4_IsChanged; }
         set{ data_Val4_IsChanged = value; }
      }
      private string data_Val5;
      private bool data_Val5_IsChanged=false;
      public string Data_Val5
      {
         get{ return data_Val5; }
         set{ data_Val5 = value; data_Val5_IsChanged=true; }
      }
      public bool Data_Val5_IsChanged
      {
         get{ return data_Val5_IsChanged; }
         set{ data_Val5_IsChanged = value; }
      }
      private string data_Val6;
      private bool data_Val6_IsChanged=false;
      public string Data_Val6
      {
         get{ return data_Val6; }
         set{ data_Val6 = value; data_Val6_IsChanged=true; }
      }
      public bool Data_Val6_IsChanged
      {
         get{ return data_Val6_IsChanged; }
         set{ data_Val6_IsChanged = value; }
      }
      private string data_Val7;
      private bool data_Val7_IsChanged=false;
      public string Data_Val7
      {
         get{ return data_Val7; }
         set{ data_Val7 = value; data_Val7_IsChanged=true; }
      }
      public bool Data_Val7_IsChanged
      {
         get{ return data_Val7_IsChanged; }
         set{ data_Val7_IsChanged = value; }
      }
      private string data_Val8;
      private bool data_Val8_IsChanged=false;
      public string Data_Val8
      {
         get{ return data_Val8; }
         set{ data_Val8 = value; data_Val8_IsChanged=true; }
      }
      public bool Data_Val8_IsChanged
      {
         get{ return data_Val8_IsChanged; }
         set{ data_Val8_IsChanged = value; }
      }
      private string data_Val9;
      private bool data_Val9_IsChanged=false;
      public string Data_Val9
      {
         get{ return data_Val9; }
         set{ data_Val9 = value; data_Val9_IsChanged=true; }
      }
      public bool Data_Val9_IsChanged
      {
         get{ return data_Val9_IsChanged; }
         set{ data_Val9_IsChanged = value; }
      }
      private string data_Val10;
      private bool data_Val10_IsChanged=false;
      public string Data_Val10
      {
         get{ return data_Val10; }
         set{ data_Val10 = value; data_Val10_IsChanged=true; }
      }
      public bool Data_Val10_IsChanged
      {
         get{ return data_Val10_IsChanged; }
         set{ data_Val10_IsChanged = value; }
      }
      private string data_Val11;
      private bool data_Val11_IsChanged=false;
      public string Data_Val11
      {
         get{ return data_Val11; }
         set{ data_Val11 = value; data_Val11_IsChanged=true; }
      }
      public bool Data_Val11_IsChanged
      {
         get{ return data_Val11_IsChanged; }
         set{ data_Val11_IsChanged = value; }
      }
      private string data_Val12;
      private bool data_Val12_IsChanged=false;
      public string Data_Val12
      {
         get{ return data_Val12; }
         set{ data_Val12 = value; data_Val12_IsChanged=true; }
      }
      public bool Data_Val12_IsChanged
      {
         get{ return data_Val12_IsChanged; }
         set{ data_Val12_IsChanged = value; }
      }
      private string data_Val13;
      private bool data_Val13_IsChanged=false;
      public string Data_Val13
      {
         get{ return data_Val13; }
         set{ data_Val13 = value; data_Val13_IsChanged=true; }
      }
      public bool Data_Val13_IsChanged
      {
         get{ return data_Val13_IsChanged; }
         set{ data_Val13_IsChanged = value; }
      }
      private string data_Val14;
      private bool data_Val14_IsChanged=false;
      public string Data_Val14
      {
         get{ return data_Val14; }
         set{ data_Val14 = value; data_Val14_IsChanged=true; }
      }
      public bool Data_Val14_IsChanged
      {
         get{ return data_Val14_IsChanged; }
         set{ data_Val14_IsChanged = value; }
      }
      private string data_Val15;
      private bool data_Val15_IsChanged=false;
      public string Data_Val15
      {
         get{ return data_Val15; }
         set{ data_Val15 = value; data_Val15_IsChanged=true; }
      }
      public bool Data_Val15_IsChanged
      {
         get{ return data_Val15_IsChanged; }
         set{ data_Val15_IsChanged = value; }
      }
      private string data_Val16;
      private bool data_Val16_IsChanged=false;
      public string Data_Val16
      {
         get{ return data_Val16; }
         set{ data_Val16 = value; data_Val16_IsChanged=true; }
      }
      public bool Data_Val16_IsChanged
      {
         get{ return data_Val16_IsChanged; }
         set{ data_Val16_IsChanged = value; }
      }
      private string data_Val17;
      private bool data_Val17_IsChanged=false;
      public string Data_Val17
      {
         get{ return data_Val17; }
         set{ data_Val17 = value; data_Val17_IsChanged=true; }
      }
      public bool Data_Val17_IsChanged
      {
         get{ return data_Val17_IsChanged; }
         set{ data_Val17_IsChanged = value; }
      }
      private string data_Val18;
      private bool data_Val18_IsChanged=false;
      public string Data_Val18
      {
         get{ return data_Val18; }
         set{ data_Val18 = value; data_Val18_IsChanged=true; }
      }
      public bool Data_Val18_IsChanged
      {
         get{ return data_Val18_IsChanged; }
         set{ data_Val18_IsChanged = value; }
      }
      private string data_Val19;
      private bool data_Val19_IsChanged=false;
      public string Data_Val19
      {
         get{ return data_Val19; }
         set{ data_Val19 = value; data_Val19_IsChanged=true; }
      }
      public bool Data_Val19_IsChanged
      {
         get{ return data_Val19_IsChanged; }
         set{ data_Val19_IsChanged = value; }
      }
      private string data_Val20;
      private bool data_Val20_IsChanged=false;
      public string Data_Val20
      {
         get{ return data_Val20; }
         set{ data_Val20 = value; data_Val20_IsChanged=true; }
      }
      public bool Data_Val20_IsChanged
      {
         get{ return data_Val20_IsChanged; }
         set{ data_Val20_IsChanged = value; }
      }
      private DateTime data_Date;
      private bool data_Date_IsChanged=false;
      public DateTime Data_Date
      {
         get{ return data_Date; }
         set{ data_Date = value; data_Date_IsChanged=true; }
      }
      public bool Data_Date_IsChanged
      {
         get{ return data_Date_IsChanged; }
         set{ data_Date_IsChanged = value; }
      }
      private string data_Udef1;
      private bool data_Udef1_IsChanged=false;
      public string Data_Udef1
      {
         get{ return data_Udef1; }
         set{ data_Udef1 = value; data_Udef1_IsChanged=true; }
      }
      public bool Data_Udef1_IsChanged
      {
         get{ return data_Udef1_IsChanged; }
         set{ data_Udef1_IsChanged = value; }
      }
      private string data_Udef2;
      private bool data_Udef2_IsChanged=false;
      public string Data_Udef2
      {
         get{ return data_Udef2; }
         set{ data_Udef2 = value; data_Udef2_IsChanged=true; }
      }
      public bool Data_Udef2_IsChanged
      {
         get{ return data_Udef2_IsChanged; }
         set{ data_Udef2_IsChanged = value; }
      }
      private string data_Udef3;
      private bool data_Udef3_IsChanged=false;
      public string Data_Udef3
      {
         get{ return data_Udef3; }
         set{ data_Udef3 = value; data_Udef3_IsChanged=true; }
      }
      public bool Data_Udef3_IsChanged
      {
         get{ return data_Udef3_IsChanged; }
         set{ data_Udef3_IsChanged = value; }
      }
      private string data_Udef4;
      private bool data_Udef4_IsChanged=false;
      public string Data_Udef4
      {
         get{ return data_Udef4; }
         set{ data_Udef4 = value; data_Udef4_IsChanged=true; }
      }
      public bool Data_Udef4_IsChanged
      {
         get{ return data_Udef4_IsChanged; }
         set{ data_Udef4_IsChanged = value; }
      }
      private string data_Udef5;
      private bool data_Udef5_IsChanged=false;
      public string Data_Udef5
      {
         get{ return data_Udef5; }
         set{ data_Udef5 = value; data_Udef5_IsChanged=true; }
      }
      public bool Data_Udef5_IsChanged
      {
         get{ return data_Udef5_IsChanged; }
         set{ data_Udef5_IsChanged = value; }
      }
      private string data_Udef6;
      private bool data_Udef6_IsChanged=false;
      public string Data_Udef6
      {
         get{ return data_Udef6; }
         set{ data_Udef6 = value; data_Udef6_IsChanged=true; }
      }
      public bool Data_Udef6_IsChanged
      {
         get{ return data_Udef6_IsChanged; }
         set{ data_Udef6_IsChanged = value; }
      }
      private string data_Udef7;
      private bool data_Udef7_IsChanged=false;
      public string Data_Udef7
      {
         get{ return data_Udef7; }
         set{ data_Udef7 = value; data_Udef7_IsChanged=true; }
      }
      public bool Data_Udef7_IsChanged
      {
         get{ return data_Udef7_IsChanged; }
         set{ data_Udef7_IsChanged = value; }
      }
      private string data_Udef8;
      private bool data_Udef8_IsChanged=false;
      public string Data_Udef8
      {
         get{ return data_Udef8; }
         set{ data_Udef8 = value; data_Udef8_IsChanged=true; }
      }
      public bool Data_Udef8_IsChanged
      {
         get{ return data_Udef8_IsChanged; }
         set{ data_Udef8_IsChanged = value; }
      }
      private string data_Udef9;
      private bool data_Udef9_IsChanged=false;
      public string Data_Udef9
      {
         get{ return data_Udef9; }
         set{ data_Udef9 = value; data_Udef9_IsChanged=true; }
      }
      public bool Data_Udef9_IsChanged
      {
         get{ return data_Udef9_IsChanged; }
         set{ data_Udef9_IsChanged = value; }
      }
      private string data_Udef10;
      private bool data_Udef10_IsChanged=false;
      public string Data_Udef10
      {
         get{ return data_Udef10; }
         set{ data_Udef10 = value; data_Udef10_IsChanged=true; }
      }
      public bool Data_Udef10_IsChanged
      {
         get{ return data_Udef10_IsChanged; }
         set{ data_Udef10_IsChanged = value; }
      }
   }
}
