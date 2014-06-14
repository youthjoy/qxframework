using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Permission.Model
{
   [Serializable]
   public partial class Sys_Function
   {
      /// <summary>
      /// 权限功能序号
      /// </summary>
      private decimal fun_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_ID_IsChanged=false;
      /// <summary>
      /// 权限功能序号
      /// </summary>
      public decimal Fun_ID
      {
         get{ return fun_ID; }
         set{ fun_ID = value; fun_ID_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能序号
      /// </summary>
      public bool Fun_ID_IsChanged
      {
         get{ return fun_ID_IsChanged; }
         set{ fun_ID_IsChanged = value; }
      }
      /// <summary>
      /// 权限功能编码
      /// </summary>
      private string fun_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_RCode_IsChanged=false;
      /// <summary>
      /// 权限功能编码
      /// </summary>
      public string Fun_RCode
      {
         get{ return fun_RCode; }
         set{ fun_RCode = value; fun_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能编码
      /// </summary>
      public bool Fun_RCode_IsChanged
      {
         get{ return fun_RCode_IsChanged; }
         set{ fun_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 权限功能编码
      /// </summary>
      private string fun_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_Code_IsChanged=false;
      /// <summary>
      /// 权限功能编码
      /// </summary>
      public string Fun_Code
      {
         get{ return fun_Code; }
         set{ fun_Code = value; fun_Code_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能编码
      /// </summary>
      public bool Fun_Code_IsChanged
      {
         get{ return fun_Code_IsChanged; }
         set{ fun_Code_IsChanged = value; }
      }
      /// <summary>
      /// 权限功能名称
      /// </summary>
      private string fun_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_Name_IsChanged=false;
      /// <summary>
      /// 权限功能名称
      /// </summary>
      public string Fun_Name
      {
         get{ return fun_Name; }
         set{ fun_Name = value; fun_Name_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能名称
      /// </summary>
      public bool Fun_Name_IsChanged
      {
         get{ return fun_Name_IsChanged; }
         set{ fun_Name_IsChanged = value; }
      }
      /// <summary>
      /// 权限功能父级编码
      /// </summary>
      private string fun_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_PCode_IsChanged=false;
      /// <summary>
      /// 权限功能父级编码
      /// </summary>
      public string Fun_PCode
      {
         get{ return fun_PCode; }
         set{ fun_PCode = value; fun_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能父级编码
      /// </summary>
      public bool Fun_PCode_IsChanged
      {
         get{ return fun_PCode_IsChanged; }
         set{ fun_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 权限功能次序
      /// </summary>
      private int fun_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_Order_IsChanged=false;
      /// <summary>
      /// 权限功能次序
      /// </summary>
      public int Fun_Order
      {
         get{ return fun_Order; }
         set{ fun_Order = value; fun_Order_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能次序
      /// </summary>
      public bool Fun_Order_IsChanged
      {
         get{ return fun_Order_IsChanged; }
         set{ fun_Order_IsChanged = value; }
      }
      /// <summary>
      /// 权限功能内部类型
      /// </summary>
      private string fun_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_iType_IsChanged=false;
      /// <summary>
      /// 权限功能内部类型
      /// </summary>
      public string Fun_iType
      {
         get{ return fun_iType; }
         set{ fun_iType = value; fun_iType_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能内部类型
      /// </summary>
      public bool Fun_iType_IsChanged
      {
         get{ return fun_iType_IsChanged; }
         set{ fun_iType_IsChanged = value; }
      }
      private string fun_UDef1;
      private bool fun_UDef1_IsChanged=false;
      public string Fun_UDef1
      {
         get{ return fun_UDef1; }
         set{ fun_UDef1 = value; fun_UDef1_IsChanged=true; }
      }
      public bool Fun_UDef1_IsChanged
      {
         get{ return fun_UDef1_IsChanged; }
         set{ fun_UDef1_IsChanged = value; }
      }
      private string fun_UDef2;
      private bool fun_UDef2_IsChanged=false;
      public string Fun_UDef2
      {
         get{ return fun_UDef2; }
         set{ fun_UDef2 = value; fun_UDef2_IsChanged=true; }
      }
      public bool Fun_UDef2_IsChanged
      {
         get{ return fun_UDef2_IsChanged; }
         set{ fun_UDef2_IsChanged = value; }
      }
      private string fun_UDef3;
      private bool fun_UDef3_IsChanged=false;
      public string Fun_UDef3
      {
         get{ return fun_UDef3; }
         set{ fun_UDef3 = value; fun_UDef3_IsChanged=true; }
      }
      public bool Fun_UDef3_IsChanged
      {
         get{ return fun_UDef3_IsChanged; }
         set{ fun_UDef3_IsChanged = value; }
      }
      private string fun_UDef4;
      private bool fun_UDef4_IsChanged=false;
      public string Fun_UDef4
      {
         get{ return fun_UDef4; }
         set{ fun_UDef4 = value; fun_UDef4_IsChanged=true; }
      }
      public bool Fun_UDef4_IsChanged
      {
         get{ return fun_UDef4_IsChanged; }
         set{ fun_UDef4_IsChanged = value; }
      }
      private string fun_UDef5;
      private bool fun_UDef5_IsChanged=false;
      public string Fun_UDef5
      {
         get{ return fun_UDef5; }
         set{ fun_UDef5 = value; fun_UDef5_IsChanged=true; }
      }
      public bool Fun_UDef5_IsChanged
      {
         get{ return fun_UDef5_IsChanged; }
         set{ fun_UDef5_IsChanged = value; }
      }
      private string fun_UDef6;
      private bool fun_UDef6_IsChanged=false;
      public string Fun_UDef6
      {
         get{ return fun_UDef6; }
         set{ fun_UDef6 = value; fun_UDef6_IsChanged=true; }
      }
      public bool Fun_UDef6_IsChanged
      {
         get{ return fun_UDef6_IsChanged; }
         set{ fun_UDef6_IsChanged = value; }
      }
      /// <summary>
      /// 权限功能状态
      /// </summary>
      private string fun_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_Stat_IsChanged=false;
      /// <summary>
      /// 权限功能状态
      /// </summary>
      public string Fun_Stat
      {
         get{ return fun_Stat; }
         set{ fun_Stat = value; fun_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 权限功能状态
      /// </summary>
      public bool Fun_Stat_IsChanged
      {
         get{ return fun_Stat_IsChanged; }
         set{ fun_Stat_IsChanged = value; }
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
