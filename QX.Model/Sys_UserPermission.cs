using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Sys_UserPermission
   {
      private decimal pU_ID;
      private bool pU_ID_IsChanged=false;
      public decimal PU_ID
      {
         get{ return pU_ID; }
         set{ pU_ID = value; pU_ID_IsChanged=true; }
      }
      public bool PU_ID_IsChanged
      {
         get{ return pU_ID_IsChanged; }
         set{ pU_ID_IsChanged = value; }
      }
      private string pU_Code;
      private bool pU_Code_IsChanged=false;
      public string PU_Code
      {
         get{ return pU_Code; }
         set{ pU_Code = value; pU_Code_IsChanged=true; }
      }
      public bool PU_Code_IsChanged
      {
         get{ return pU_Code_IsChanged; }
         set{ pU_Code_IsChanged = value; }
      }
      private string pU_UserCode;
      private bool pU_UserCode_IsChanged=false;
      public string PU_UserCode
      {
         get{ return pU_UserCode; }
         set{ pU_UserCode = value; pU_UserCode_IsChanged=true; }
      }
      public bool PU_UserCode_IsChanged
      {
         get{ return pU_UserCode_IsChanged; }
         set{ pU_UserCode_IsChanged = value; }
      }
      private string pU_FunName;
      private bool pU_FunName_IsChanged=false;
      public string PU_FunName
      {
         get{ return pU_FunName; }
         set{ pU_FunName = value; pU_FunName_IsChanged=true; }
      }
      public bool PU_FunName_IsChanged
      {
         get{ return pU_FunName_IsChanged; }
         set{ pU_FunName_IsChanged = value; }
      }
      private string pU_FunCode;
      private bool pU_FunCode_IsChanged=false;
      public string PU_FunCode
      {
         get{ return pU_FunCode; }
         set{ pU_FunCode = value; pU_FunCode_IsChanged=true; }
      }
      public bool PU_FunCode_IsChanged
      {
         get{ return pU_FunCode_IsChanged; }
         set{ pU_FunCode_IsChanged = value; }
      }
      /// <summary>
      /// 功能父级编码
      /// </summary>
      private string pU_FunPCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pU_FunPCode_IsChanged=false;
      /// <summary>
      /// 功能父级编码
      /// </summary>
      public string PU_FunPCode
      {
         get{ return pU_FunPCode; }
         set{ pU_FunPCode = value; pU_FunPCode_IsChanged=true; }
      }
      /// <summary>
      /// 功能父级编码
      /// </summary>
      public bool PU_FunPCode_IsChanged
      {
         get{ return pU_FunPCode_IsChanged; }
         set{ pU_FunPCode_IsChanged = value; }
      }
      private string pU_UDef1;
      private bool pU_UDef1_IsChanged=false;
      public string PU_UDef1
      {
         get{ return pU_UDef1; }
         set{ pU_UDef1 = value; pU_UDef1_IsChanged=true; }
      }
      public bool PU_UDef1_IsChanged
      {
         get{ return pU_UDef1_IsChanged; }
         set{ pU_UDef1_IsChanged = value; }
      }
      private string pU_UDef2;
      private bool pU_UDef2_IsChanged=false;
      public string PU_UDef2
      {
         get{ return pU_UDef2; }
         set{ pU_UDef2 = value; pU_UDef2_IsChanged=true; }
      }
      public bool PU_UDef2_IsChanged
      {
         get{ return pU_UDef2_IsChanged; }
         set{ pU_UDef2_IsChanged = value; }
      }
      private string pU_UDef3;
      private bool pU_UDef3_IsChanged=false;
      public string PU_UDef3
      {
         get{ return pU_UDef3; }
         set{ pU_UDef3 = value; pU_UDef3_IsChanged=true; }
      }
      public bool PU_UDef3_IsChanged
      {
         get{ return pU_UDef3_IsChanged; }
         set{ pU_UDef3_IsChanged = value; }
      }
      private string pU_IsCheck;
      private bool pU_IsCheck_IsChanged=false;
      public string PU_IsCheck
      {
         get{ return pU_IsCheck; }
         set{ pU_IsCheck = value; pU_IsCheck_IsChanged=true; }
      }
      public bool PU_IsCheck_IsChanged
      {
         get{ return pU_IsCheck_IsChanged; }
         set{ pU_IsCheck_IsChanged = value; }
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
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createDate_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      private DateTime updateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool updateDate_IsChanged=false;
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      private DateTime deleteDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool deleteDate_IsChanged=false;
      /// <summary>
      /// 删除时间
      /// </summary>
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
   }
}
