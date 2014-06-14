using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Permission.Model
{
   [Serializable]
   public partial class Sys_UserPermission_Method
   {
      private decimal fP_ID;
      private bool fP_ID_IsChanged=false;
      public decimal FP_ID
      {
         get{ return fP_ID; }
         set{ fP_ID = value; fP_ID_IsChanged=true; }
      }
      public bool FP_ID_IsChanged
      {
         get{ return fP_ID_IsChanged; }
         set{ fP_ID_IsChanged = value; }
      }
      private string fP_Code;
      private bool fP_Code_IsChanged=false;
      public string FP_Code
      {
         get{ return fP_Code; }
         set{ fP_Code = value; fP_Code_IsChanged=true; }
      }
      public bool FP_Code_IsChanged
      {
         get{ return fP_Code_IsChanged; }
         set{ fP_Code_IsChanged = value; }
      }
      private string fP_FunCode;
      private bool fP_FunCode_IsChanged=false;
      public string FP_FunCode
      {
         get{ return fP_FunCode; }
         set{ fP_FunCode = value; fP_FunCode_IsChanged=true; }
      }
      public bool FP_FunCode_IsChanged
      {
         get{ return fP_FunCode_IsChanged; }
         set{ fP_FunCode_IsChanged = value; }
      }
      private string fP_Method;
      private bool fP_Method_IsChanged=false;
      public string FP_Method
      {
         get{ return fP_Method; }
         set{ fP_Method = value; fP_Method_IsChanged=true; }
      }
      public bool FP_Method_IsChanged
      {
         get{ return fP_Method_IsChanged; }
         set{ fP_Method_IsChanged = value; }
      }
      private string fP_Udef1;
      private bool fP_Udef1_IsChanged=false;
      public string FP_Udef1
      {
         get{ return fP_Udef1; }
         set{ fP_Udef1 = value; fP_Udef1_IsChanged=true; }
      }
      public bool FP_Udef1_IsChanged
      {
         get{ return fP_Udef1_IsChanged; }
         set{ fP_Udef1_IsChanged = value; }
      }
      private string fP_Udef2;
      private bool fP_Udef2_IsChanged=false;
      public string FP_Udef2
      {
         get{ return fP_Udef2; }
         set{ fP_Udef2 = value; fP_Udef2_IsChanged=true; }
      }
      public bool FP_Udef2_IsChanged
      {
         get{ return fP_Udef2_IsChanged; }
         set{ fP_Udef2_IsChanged = value; }
      }
      private string fP_Udef3;
      private bool fP_Udef3_IsChanged=false;
      public string FP_Udef3
      {
         get{ return fP_Udef3; }
         set{ fP_Udef3 = value; fP_Udef3_IsChanged=true; }
      }
      public bool FP_Udef3_IsChanged
      {
         get{ return fP_Udef3_IsChanged; }
         set{ fP_Udef3_IsChanged = value; }
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
