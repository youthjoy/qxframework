using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 部门信息
   /// </summary>
   [Serializable]
   public partial class HR_Department
   {
      /// <summary>
      /// 部门序号
      /// </summary>
      private decimal dept_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dept_ID_IsChanged=false;
      /// <summary>
      /// 部门序号
      /// </summary>
      public decimal Dept_ID
      {
         get{ return dept_ID; }
         set{ dept_ID = value; dept_ID_IsChanged=true; }
      }
      /// <summary>
      /// 部门序号
      /// </summary>
      public bool Dept_ID_IsChanged
      {
         get{ return dept_ID_IsChanged; }
         set{ dept_ID_IsChanged = value; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      private string dept_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dept_Code_IsChanged=false;
      /// <summary>
      /// 部门编码
      /// </summary>
      public string Dept_Code
      {
         get{ return dept_Code; }
         set{ dept_Code = value; dept_Code_IsChanged=true; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      public bool Dept_Code_IsChanged
      {
         get{ return dept_Code_IsChanged; }
         set{ dept_Code_IsChanged = value; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      private string dept_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dept_Name_IsChanged=false;
      /// <summary>
      /// 部门名称
      /// </summary>
      public string Dept_Name
      {
         get{ return dept_Name; }
         set{ dept_Name = value; dept_Name_IsChanged=true; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      public bool Dept_Name_IsChanged
      {
         get{ return dept_Name_IsChanged; }
         set{ dept_Name_IsChanged = value; }
      }
      /// <summary>
      /// 部门地址
      /// </summary>
      private string dept_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dept_Addr_IsChanged=false;
      /// <summary>
      /// 部门地址
      /// </summary>
      public string Dept_Addr
      {
         get{ return dept_Addr; }
         set{ dept_Addr = value; dept_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 部门地址
      /// </summary>
      public bool Dept_Addr_IsChanged
      {
         get{ return dept_Addr_IsChanged; }
         set{ dept_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 部门电话
      /// </summary>
      private string dept_Tel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dept_Tel_IsChanged=false;
      /// <summary>
      /// 部门电话
      /// </summary>
      public string Dept_Tel
      {
         get{ return dept_Tel; }
         set{ dept_Tel = value; dept_Tel_IsChanged=true; }
      }
      /// <summary>
      /// 部门电话
      /// </summary>
      public bool Dept_Tel_IsChanged
      {
         get{ return dept_Tel_IsChanged; }
         set{ dept_Tel_IsChanged = value; }
      }
      /// <summary>
      /// 部门负责人
      /// </summary>
      private string dept_Manager;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dept_Manager_IsChanged=false;
      /// <summary>
      /// 部门负责人
      /// </summary>
      public string Dept_Manager
      {
         get{ return dept_Manager; }
         set{ dept_Manager = value; dept_Manager_IsChanged=true; }
      }
      /// <summary>
      /// 部门负责人
      /// </summary>
      public bool Dept_Manager_IsChanged
      {
         get{ return dept_Manager_IsChanged; }
         set{ dept_Manager_IsChanged = value; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createTime_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      private string creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool creator_IsChanged=false;
      /// <summary>
      /// 创建人
      /// </summary>
      public string Creator
      {
         get{ return creator; }
         set{ creator = value; creator_IsChanged=true; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      public bool Creator_IsChanged
      {
         get{ return creator_IsChanged; }
         set{ creator_IsChanged = value; }
      }
      private string dept_PCode;
      private bool dept_PCode_IsChanged=false;
      public string Dept_PCode
      {
         get{ return dept_PCode; }
         set{ dept_PCode = value; dept_PCode_IsChanged=true; }
      }
      public bool Dept_PCode_IsChanged
      {
         get{ return dept_PCode_IsChanged; }
         set{ dept_PCode_IsChanged = value; }
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
      private string dept_Udef1;
      private bool dept_Udef1_IsChanged=false;
      public string Dept_Udef1
      {
         get{ return dept_Udef1; }
         set{ dept_Udef1 = value; dept_Udef1_IsChanged=true; }
      }
      public bool Dept_Udef1_IsChanged
      {
         get{ return dept_Udef1_IsChanged; }
         set{ dept_Udef1_IsChanged = value; }
      }
      private string dept_Udef2;
      private bool dept_Udef2_IsChanged=false;
      public string Dept_Udef2
      {
         get{ return dept_Udef2; }
         set{ dept_Udef2 = value; dept_Udef2_IsChanged=true; }
      }
      public bool Dept_Udef2_IsChanged
      {
         get{ return dept_Udef2_IsChanged; }
         set{ dept_Udef2_IsChanged = value; }
      }
      private string dept_Udef3;
      private bool dept_Udef3_IsChanged=false;
      public string Dept_Udef3
      {
         get{ return dept_Udef3; }
         set{ dept_Udef3 = value; dept_Udef3_IsChanged=true; }
      }
      public bool Dept_Udef3_IsChanged
      {
         get{ return dept_Udef3_IsChanged; }
         set{ dept_Udef3_IsChanged = value; }
      }
      private string dept_Udef5;
      private bool dept_Udef5_IsChanged=false;
      public string Dept_Udef5
      {
         get{ return dept_Udef5; }
         set{ dept_Udef5 = value; dept_Udef5_IsChanged=true; }
      }
      public bool Dept_Udef5_IsChanged
      {
         get{ return dept_Udef5_IsChanged; }
         set{ dept_Udef5_IsChanged = value; }
      }
      private string dept_Udef6;
      private bool dept_Udef6_IsChanged=false;
      public string Dept_Udef6
      {
         get{ return dept_Udef6; }
         set{ dept_Udef6 = value; dept_Udef6_IsChanged=true; }
      }
      public bool Dept_Udef6_IsChanged
      {
         get{ return dept_Udef6_IsChanged; }
         set{ dept_Udef6_IsChanged = value; }
      }
      private string dept_Udef7;
      private bool dept_Udef7_IsChanged=false;
      public string Dept_Udef7
      {
         get{ return dept_Udef7; }
         set{ dept_Udef7 = value; dept_Udef7_IsChanged=true; }
      }
      public bool Dept_Udef7_IsChanged
      {
         get{ return dept_Udef7_IsChanged; }
         set{ dept_Udef7_IsChanged = value; }
      }
      private string dept_Udef8;
      private bool dept_Udef8_IsChanged=false;
      public string Dept_Udef8
      {
         get{ return dept_Udef8; }
         set{ dept_Udef8 = value; dept_Udef8_IsChanged=true; }
      }
      public bool Dept_Udef8_IsChanged
      {
         get{ return dept_Udef8_IsChanged; }
         set{ dept_Udef8_IsChanged = value; }
      }
      private string dept_Udef9;
      private bool dept_Udef9_IsChanged=false;
      public string Dept_Udef9
      {
         get{ return dept_Udef9; }
         set{ dept_Udef9 = value; dept_Udef9_IsChanged=true; }
      }
      public bool Dept_Udef9_IsChanged
      {
         get{ return dept_Udef9_IsChanged; }
         set{ dept_Udef9_IsChanged = value; }
      }
      private string dept_Udef10;
      private bool dept_Udef10_IsChanged=false;
      public string Dept_Udef10
      {
         get{ return dept_Udef10; }
         set{ dept_Udef10 = value; dept_Udef10_IsChanged=true; }
      }
      public bool Dept_Udef10_IsChanged
      {
         get{ return dept_Udef10_IsChanged; }
         set{ dept_Udef10_IsChanged = value; }
      }
   }
}
