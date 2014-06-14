using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 员工信息
   /// </summary>
   [Serializable]
   public partial class HR_Stuff
   {
      /// <summary>
      /// 员工序号
      /// </summary>
      private decimal stuff_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_ID_IsChanged=false;
      /// <summary>
      /// 员工序号
      /// </summary>
      public decimal Stuff_ID
      {
         get{ return stuff_ID; }
         set{ stuff_ID = value; stuff_ID_IsChanged=true; }
      }
      /// <summary>
      /// 员工序号
      /// </summary>
      public bool Stuff_ID_IsChanged
      {
         get{ return stuff_ID_IsChanged; }
         set{ stuff_ID_IsChanged = value; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      private string stuff_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Code_IsChanged=false;
      /// <summary>
      /// 员工编码
      /// </summary>
      public string Stuff_Code
      {
         get{ return stuff_Code; }
         set{ stuff_Code = value; stuff_Code_IsChanged=true; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      public bool Stuff_Code_IsChanged
      {
         get{ return stuff_Code_IsChanged; }
         set{ stuff_Code_IsChanged = value; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      private string stuff_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Name_IsChanged=false;
      /// <summary>
      /// 员工姓名
      /// </summary>
      public string Stuff_Name
      {
         get{ return stuff_Name; }
         set{ stuff_Name = value; stuff_Name_IsChanged=true; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      public bool Stuff_Name_IsChanged
      {
         get{ return stuff_Name_IsChanged; }
         set{ stuff_Name_IsChanged = value; }
      }
      /// <summary>
      /// 英文名
      /// </summary>
      private string stuff_ENName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_ENName_IsChanged=false;
      /// <summary>
      /// 英文名
      /// </summary>
      public string Stuff_ENName
      {
         get{ return stuff_ENName; }
         set{ stuff_ENName = value; stuff_ENName_IsChanged=true; }
      }
      /// <summary>
      /// 英文名
      /// </summary>
      public bool Stuff_ENName_IsChanged
      {
         get{ return stuff_ENName_IsChanged; }
         set{ stuff_ENName_IsChanged = value; }
      }
      /// <summary>
      /// 职位
      /// </summary>
      private string stuff_Duty;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Duty_IsChanged=false;
      /// <summary>
      /// 职位
      /// </summary>
      public string Stuff_Duty
      {
         get{ return stuff_Duty; }
         set{ stuff_Duty = value; stuff_Duty_IsChanged=true; }
      }
      /// <summary>
      /// 职位
      /// </summary>
      public bool Stuff_Duty_IsChanged
      {
         get{ return stuff_Duty_IsChanged; }
         set{ stuff_Duty_IsChanged = value; }
      }
      /// <summary>
      /// 职位
      /// </summary>
      private string stuff_DutyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_DutyCode_IsChanged=false;
      /// <summary>
      /// 职位
      /// </summary>
      public string Stuff_DutyCode
      {
         get{ return stuff_DutyCode; }
         set{ stuff_DutyCode = value; stuff_DutyCode_IsChanged=true; }
      }
      /// <summary>
      /// 职位
      /// </summary>
      public bool Stuff_DutyCode_IsChanged
      {
         get{ return stuff_DutyCode_IsChanged; }
         set{ stuff_DutyCode_IsChanged = value; }
      }
      /// <summary>
      /// 职称
      /// </summary>
      private string stuff_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Title_IsChanged=false;
      /// <summary>
      /// 职称
      /// </summary>
      public string Stuff_Title
      {
         get{ return stuff_Title; }
         set{ stuff_Title = value; stuff_Title_IsChanged=true; }
      }
      /// <summary>
      /// 职称
      /// </summary>
      public bool Stuff_Title_IsChanged
      {
         get{ return stuff_Title_IsChanged; }
         set{ stuff_Title_IsChanged = value; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      private string stuff_DepCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_DepCode_IsChanged=false;
      /// <summary>
      /// 部门编码
      /// </summary>
      public string Stuff_DepCode
      {
         get{ return stuff_DepCode; }
         set{ stuff_DepCode = value; stuff_DepCode_IsChanged=true; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      public bool Stuff_DepCode_IsChanged
      {
         get{ return stuff_DepCode_IsChanged; }
         set{ stuff_DepCode_IsChanged = value; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      private string stuff_DepName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_DepName_IsChanged=false;
      /// <summary>
      /// 部门名称
      /// </summary>
      public string Stuff_DepName
      {
         get{ return stuff_DepName; }
         set{ stuff_DepName = value; stuff_DepName_IsChanged=true; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      public bool Stuff_DepName_IsChanged
      {
         get{ return stuff_DepName_IsChanged; }
         set{ stuff_DepName_IsChanged = value; }
      }
      /// <summary>
      /// 直接上级
      /// </summary>
      private string stuff_Director;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Director_IsChanged=false;
      /// <summary>
      /// 直接上级
      /// </summary>
      public string Stuff_Director
      {
         get{ return stuff_Director; }
         set{ stuff_Director = value; stuff_Director_IsChanged=true; }
      }
      /// <summary>
      /// 直接上级
      /// </summary>
      public bool Stuff_Director_IsChanged
      {
         get{ return stuff_Director_IsChanged; }
         set{ stuff_Director_IsChanged = value; }
      }
      /// <summary>
      /// 直接上级
      /// </summary>
      private string stuff_DirectorCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_DirectorCode_IsChanged=false;
      /// <summary>
      /// 直接上级
      /// </summary>
      public string Stuff_DirectorCode
      {
         get{ return stuff_DirectorCode; }
         set{ stuff_DirectorCode = value; stuff_DirectorCode_IsChanged=true; }
      }
      /// <summary>
      /// 直接上级
      /// </summary>
      public bool Stuff_DirectorCode_IsChanged
      {
         get{ return stuff_DirectorCode_IsChanged; }
         set{ stuff_DirectorCode_IsChanged = value; }
      }
      /// <summary>
      /// 办公室电话
      /// </summary>
      private string stuff_OTel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_OTel_IsChanged=false;
      /// <summary>
      /// 办公室电话
      /// </summary>
      public string Stuff_OTel
      {
         get{ return stuff_OTel; }
         set{ stuff_OTel = value; stuff_OTel_IsChanged=true; }
      }
      /// <summary>
      /// 办公室电话
      /// </summary>
      public bool Stuff_OTel_IsChanged
      {
         get{ return stuff_OTel_IsChanged; }
         set{ stuff_OTel_IsChanged = value; }
      }
      /// <summary>
      /// 手机
      /// </summary>
      private string stuff_Mobile;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Mobile_IsChanged=false;
      /// <summary>
      /// 手机
      /// </summary>
      public string Stuff_Mobile
      {
         get{ return stuff_Mobile; }
         set{ stuff_Mobile = value; stuff_Mobile_IsChanged=true; }
      }
      /// <summary>
      /// 手机
      /// </summary>
      public bool Stuff_Mobile_IsChanged
      {
         get{ return stuff_Mobile_IsChanged; }
         set{ stuff_Mobile_IsChanged = value; }
      }
      /// <summary>
      /// 电子邮件
      /// </summary>
      private string stuff_Email;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Email_IsChanged=false;
      /// <summary>
      /// 电子邮件
      /// </summary>
      public string Stuff_Email
      {
         get{ return stuff_Email; }
         set{ stuff_Email = value; stuff_Email_IsChanged=true; }
      }
      /// <summary>
      /// 电子邮件
      /// </summary>
      public bool Stuff_Email_IsChanged
      {
         get{ return stuff_Email_IsChanged; }
         set{ stuff_Email_IsChanged = value; }
      }
      /// <summary>
      /// 传真
      /// </summary>
      private string stuff_Fax;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Fax_IsChanged=false;
      /// <summary>
      /// 传真
      /// </summary>
      public string Stuff_Fax
      {
         get{ return stuff_Fax; }
         set{ stuff_Fax = value; stuff_Fax_IsChanged=true; }
      }
      /// <summary>
      /// 传真
      /// </summary>
      public bool Stuff_Fax_IsChanged
      {
         get{ return stuff_Fax_IsChanged; }
         set{ stuff_Fax_IsChanged = value; }
      }
      /// <summary>
      /// 住宅电话
      /// </summary>
      private string stuff_HTel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_HTel_IsChanged=false;
      /// <summary>
      /// 住宅电话
      /// </summary>
      public string Stuff_HTel
      {
         get{ return stuff_HTel; }
         set{ stuff_HTel = value; stuff_HTel_IsChanged=true; }
      }
      /// <summary>
      /// 住宅电话
      /// </summary>
      public bool Stuff_HTel_IsChanged
      {
         get{ return stuff_HTel_IsChanged; }
         set{ stuff_HTel_IsChanged = value; }
      }
      /// <summary>
      /// 住址
      /// </summary>
      private string stuff_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Addr_IsChanged=false;
      /// <summary>
      /// 住址
      /// </summary>
      public string Stuff_Addr
      {
         get{ return stuff_Addr; }
         set{ stuff_Addr = value; stuff_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 住址
      /// </summary>
      public bool Stuff_Addr_IsChanged
      {
         get{ return stuff_Addr_IsChanged; }
         set{ stuff_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 入职日期
      /// </summary>
      private string stuff_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Start_IsChanged=false;
      /// <summary>
      /// 入职日期
      /// </summary>
      public string Stuff_Start
      {
         get{ return stuff_Start; }
         set{ stuff_Start = value; stuff_Start_IsChanged=true; }
      }
      /// <summary>
      /// 入职日期
      /// </summary>
      public bool Stuff_Start_IsChanged
      {
         get{ return stuff_Start_IsChanged; }
         set{ stuff_Start_IsChanged = value; }
      }
      /// <summary>
      /// 离职日期
      /// </summary>
      private string stuff_Left;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Left_IsChanged=false;
      /// <summary>
      /// 离职日期
      /// </summary>
      public string Stuff_Left
      {
         get{ return stuff_Left; }
         set{ stuff_Left = value; stuff_Left_IsChanged=true; }
      }
      /// <summary>
      /// 离职日期
      /// </summary>
      public bool Stuff_Left_IsChanged
      {
         get{ return stuff_Left_IsChanged; }
         set{ stuff_Left_IsChanged = value; }
      }
      /// <summary>
      /// 员工状态
      /// </summary>
      private string stuff_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Stat_IsChanged=false;
      /// <summary>
      /// 员工状态
      /// </summary>
      public string Stuff_Stat
      {
         get{ return stuff_Stat; }
         set{ stuff_Stat = value; stuff_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 员工状态
      /// </summary>
      public bool Stuff_Stat_IsChanged
      {
         get{ return stuff_Stat_IsChanged; }
         set{ stuff_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 性别
      /// </summary>
      private string stuff_Gender;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Gender_IsChanged=false;
      /// <summary>
      /// 性别
      /// </summary>
      public string Stuff_Gender
      {
         get{ return stuff_Gender; }
         set{ stuff_Gender = value; stuff_Gender_IsChanged=true; }
      }
      /// <summary>
      /// 性别
      /// </summary>
      public bool Stuff_Gender_IsChanged
      {
         get{ return stuff_Gender_IsChanged; }
         set{ stuff_Gender_IsChanged = value; }
      }
      /// <summary>
      /// 出生日期
      /// </summary>
      private string stuff_Birth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Birth_IsChanged=false;
      /// <summary>
      /// 出生日期
      /// </summary>
      public string Stuff_Birth
      {
         get{ return stuff_Birth; }
         set{ stuff_Birth = value; stuff_Birth_IsChanged=true; }
      }
      /// <summary>
      /// 出生日期
      /// </summary>
      public bool Stuff_Birth_IsChanged
      {
         get{ return stuff_Birth_IsChanged; }
         set{ stuff_Birth_IsChanged = value; }
      }
      /// <summary>
      /// 国籍
      /// </summary>
      private string stuff_Nation;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Nation_IsChanged=false;
      /// <summary>
      /// 国籍
      /// </summary>
      public string Stuff_Nation
      {
         get{ return stuff_Nation; }
         set{ stuff_Nation = value; stuff_Nation_IsChanged=true; }
      }
      /// <summary>
      /// 国籍
      /// </summary>
      public bool Stuff_Nation_IsChanged
      {
         get{ return stuff_Nation_IsChanged; }
         set{ stuff_Nation_IsChanged = value; }
      }
      /// <summary>
      /// 省份
      /// </summary>
      private string stuff_Province;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Province_IsChanged=false;
      /// <summary>
      /// 省份
      /// </summary>
      public string Stuff_Province
      {
         get{ return stuff_Province; }
         set{ stuff_Province = value; stuff_Province_IsChanged=true; }
      }
      /// <summary>
      /// 省份
      /// </summary>
      public bool Stuff_Province_IsChanged
      {
         get{ return stuff_Province_IsChanged; }
         set{ stuff_Province_IsChanged = value; }
      }
      /// <summary>
      /// 员工工资
      /// </summary>
      private Int64 stuff_Salary;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Salary_IsChanged=false;
      /// <summary>
      /// 员工工资
      /// </summary>
      public Int64 Stuff_Salary
      {
         get{ return stuff_Salary; }
         set{ stuff_Salary = value; stuff_Salary_IsChanged=true; }
      }
      /// <summary>
      /// 员工工资
      /// </summary>
      public bool Stuff_Salary_IsChanged
      {
         get{ return stuff_Salary_IsChanged; }
         set{ stuff_Salary_IsChanged = value; }
      }
      /// <summary>
      /// 员工成本
      /// </summary>
      private string stuff_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Cost_IsChanged=false;
      /// <summary>
      /// 员工成本
      /// </summary>
      public string Stuff_Cost
      {
         get{ return stuff_Cost; }
         set{ stuff_Cost = value; stuff_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 员工成本
      /// </summary>
      public bool Stuff_Cost_IsChanged
      {
         get{ return stuff_Cost_IsChanged; }
         set{ stuff_Cost_IsChanged = value; }
      }
      private string stuff_Type;
      private bool stuff_Type_IsChanged=false;
      public string Stuff_Type
      {
         get{ return stuff_Type; }
         set{ stuff_Type = value; stuff_Type_IsChanged=true; }
      }
      public bool Stuff_Type_IsChanged
      {
         get{ return stuff_Type_IsChanged; }
         set{ stuff_Type_IsChanged = value; }
      }
      /// <summary>
      /// 保险状态
      /// </summary>
      private string stuff_InsuraceStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_InsuraceStat_IsChanged=false;
      /// <summary>
      /// 保险状态
      /// </summary>
      public string Stuff_InsuraceStat
      {
         get{ return stuff_InsuraceStat; }
         set{ stuff_InsuraceStat = value; stuff_InsuraceStat_IsChanged=true; }
      }
      /// <summary>
      /// 保险状态
      /// </summary>
      public bool Stuff_InsuraceStat_IsChanged
      {
         get{ return stuff_InsuraceStat_IsChanged; }
         set{ stuff_InsuraceStat_IsChanged = value; }
      }
      /// <summary>
      /// 学历
      /// </summary>
      private string stuff_Edu;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Edu_IsChanged=false;
      /// <summary>
      /// 学历
      /// </summary>
      public string Stuff_Edu
      {
         get{ return stuff_Edu; }
         set{ stuff_Edu = value; stuff_Edu_IsChanged=true; }
      }
      /// <summary>
      /// 学历
      /// </summary>
      public bool Stuff_Edu_IsChanged
      {
         get{ return stuff_Edu_IsChanged; }
         set{ stuff_Edu_IsChanged = value; }
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
      /// <summary>
      /// 系统登录名
      /// </summary>
      private string stuff_UserName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_UserName_IsChanged=false;
      /// <summary>
      /// 系统登录名
      /// </summary>
      public string Stuff_UserName
      {
         get{ return stuff_UserName; }
         set{ stuff_UserName = value; stuff_UserName_IsChanged=true; }
      }
      /// <summary>
      /// 系统登录名
      /// </summary>
      public bool Stuff_UserName_IsChanged
      {
         get{ return stuff_UserName_IsChanged; }
         set{ stuff_UserName_IsChanged = value; }
      }
      /// <summary>
      /// 系统登录密码
      /// </summary>
      private string stuff_Password;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Password_IsChanged=false;
      /// <summary>
      /// 系统登录密码
      /// </summary>
      public string Stuff_Password
      {
         get{ return stuff_Password; }
         set{ stuff_Password = value; stuff_Password_IsChanged=true; }
      }
      /// <summary>
      /// 系统登录密码
      /// </summary>
      public bool Stuff_Password_IsChanged
      {
         get{ return stuff_Password_IsChanged; }
         set{ stuff_Password_IsChanged = value; }
      }
      /// <summary>
      /// 系统登录类型
      /// </summary>
      private string stuff_LoginType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_LoginType_IsChanged=false;
      /// <summary>
      /// 系统登录类型
      /// </summary>
      public string Stuff_LoginType
      {
         get{ return stuff_LoginType; }
         set{ stuff_LoginType = value; stuff_LoginType_IsChanged=true; }
      }
      /// <summary>
      /// 系统登录类型
      /// </summary>
      public bool Stuff_LoginType_IsChanged
      {
         get{ return stuff_LoginType_IsChanged; }
         set{ stuff_LoginType_IsChanged = value; }
      }
      /// <summary>
      /// 短号
      /// </summary>
      private string stuff_ShortTel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_ShortTel_IsChanged=false;
      /// <summary>
      /// 短号
      /// </summary>
      public string Stuff_ShortTel
      {
         get{ return stuff_ShortTel; }
         set{ stuff_ShortTel = value; stuff_ShortTel_IsChanged=true; }
      }
      /// <summary>
      /// 短号
      /// </summary>
      public bool Stuff_ShortTel_IsChanged
      {
         get{ return stuff_ShortTel_IsChanged; }
         set{ stuff_ShortTel_IsChanged = value; }
      }
      /// <summary>
      /// 工号,档案号
      /// </summary>
      private string stuff_WorkNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_WorkNo_IsChanged=false;
      /// <summary>
      /// 工号,档案号
      /// </summary>
      public string Stuff_WorkNo
      {
         get{ return stuff_WorkNo; }
         set{ stuff_WorkNo = value; stuff_WorkNo_IsChanged=true; }
      }
      /// <summary>
      /// 工号,档案号
      /// </summary>
      public bool Stuff_WorkNo_IsChanged
      {
         get{ return stuff_WorkNo_IsChanged; }
         set{ stuff_WorkNo_IsChanged = value; }
      }
      /// <summary>
      /// 文化程度
      /// </summary>
      private string stuff_TechLevel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_TechLevel_IsChanged=false;
      /// <summary>
      /// 文化程度
      /// </summary>
      public string Stuff_TechLevel
      {
         get{ return stuff_TechLevel; }
         set{ stuff_TechLevel = value; stuff_TechLevel_IsChanged=true; }
      }
      /// <summary>
      /// 文化程度
      /// </summary>
      public bool Stuff_TechLevel_IsChanged
      {
         get{ return stuff_TechLevel_IsChanged; }
         set{ stuff_TechLevel_IsChanged = value; }
      }
      /// <summary>
      /// 身体健康状态
      /// </summary>
      private string stuff_Heath;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Heath_IsChanged=false;
      /// <summary>
      /// 身体健康状态
      /// </summary>
      public string Stuff_Heath
      {
         get{ return stuff_Heath; }
         set{ stuff_Heath = value; stuff_Heath_IsChanged=true; }
      }
      /// <summary>
      /// 身体健康状态
      /// </summary>
      public bool Stuff_Heath_IsChanged
      {
         get{ return stuff_Heath_IsChanged; }
         set{ stuff_Heath_IsChanged = value; }
      }
      /// <summary>
      /// 进司时间
      /// </summary>
      private string stuff_InDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_InDate_IsChanged=false;
      /// <summary>
      /// 进司时间
      /// </summary>
      public string Stuff_InDate
      {
         get{ return stuff_InDate; }
         set{ stuff_InDate = value; stuff_InDate_IsChanged=true; }
      }
      /// <summary>
      /// 进司时间
      /// </summary>
      public bool Stuff_InDate_IsChanged
      {
         get{ return stuff_InDate_IsChanged; }
         set{ stuff_InDate_IsChanged = value; }
      }
      /// <summary>
      /// 转正时间
      /// </summary>
      private string stuff_TurnDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_TurnDate_IsChanged=false;
      /// <summary>
      /// 转正时间
      /// </summary>
      public string Stuff_TurnDate
      {
         get{ return stuff_TurnDate; }
         set{ stuff_TurnDate = value; stuff_TurnDate_IsChanged=true; }
      }
      /// <summary>
      /// 转正时间
      /// </summary>
      public bool Stuff_TurnDate_IsChanged
      {
         get{ return stuff_TurnDate_IsChanged; }
         set{ stuff_TurnDate_IsChanged = value; }
      }
      /// <summary>
      /// 入工会时间
      /// </summary>
      private string stuff_TradeDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_TradeDate_IsChanged=false;
      /// <summary>
      /// 入工会时间
      /// </summary>
      public string Stuff_TradeDate
      {
         get{ return stuff_TradeDate; }
         set{ stuff_TradeDate = value; stuff_TradeDate_IsChanged=true; }
      }
      /// <summary>
      /// 入工会时间
      /// </summary>
      public bool Stuff_TradeDate_IsChanged
      {
         get{ return stuff_TradeDate_IsChanged; }
         set{ stuff_TradeDate_IsChanged = value; }
      }
      /// <summary>
      /// 签定合同时间
      /// </summary>
      private string stuff_SignStartDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_SignStartDate_IsChanged=false;
      /// <summary>
      /// 签定合同时间
      /// </summary>
      public string Stuff_SignStartDate
      {
         get{ return stuff_SignStartDate; }
         set{ stuff_SignStartDate = value; stuff_SignStartDate_IsChanged=true; }
      }
      /// <summary>
      /// 签定合同时间
      /// </summary>
      public bool Stuff_SignStartDate_IsChanged
      {
         get{ return stuff_SignStartDate_IsChanged; }
         set{ stuff_SignStartDate_IsChanged = value; }
      }
      /// <summary>
      /// 合同到期时间
      /// </summary>
      private string stuff_SingEndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_SingEndDate_IsChanged=false;
      /// <summary>
      /// 合同到期时间
      /// </summary>
      public string Stuff_SingEndDate
      {
         get{ return stuff_SingEndDate; }
         set{ stuff_SingEndDate = value; stuff_SingEndDate_IsChanged=true; }
      }
      /// <summary>
      /// 合同到期时间
      /// </summary>
      public bool Stuff_SingEndDate_IsChanged
      {
         get{ return stuff_SingEndDate_IsChanged; }
         set{ stuff_SingEndDate_IsChanged = value; }
      }
      /// <summary>
      /// 特种作业操作证
      /// </summary>
      private string stuff_SpeicalCard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_SpeicalCard_IsChanged=false;
      /// <summary>
      /// 特种作业操作证
      /// </summary>
      public string Stuff_SpeicalCard
      {
         get{ return stuff_SpeicalCard; }
         set{ stuff_SpeicalCard = value; stuff_SpeicalCard_IsChanged=true; }
      }
      /// <summary>
      /// 特种作业操作证
      /// </summary>
      public bool Stuff_SpeicalCard_IsChanged
      {
         get{ return stuff_SpeicalCard_IsChanged; }
         set{ stuff_SpeicalCard_IsChanged = value; }
      }
      /// <summary>
      /// 毕业学校
      /// </summary>
      private string stuff_FinishSchool;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_FinishSchool_IsChanged=false;
      /// <summary>
      /// 毕业学校
      /// </summary>
      public string Stuff_FinishSchool
      {
         get{ return stuff_FinishSchool; }
         set{ stuff_FinishSchool = value; stuff_FinishSchool_IsChanged=true; }
      }
      /// <summary>
      /// 毕业学校
      /// </summary>
      public bool Stuff_FinishSchool_IsChanged
      {
         get{ return stuff_FinishSchool_IsChanged; }
         set{ stuff_FinishSchool_IsChanged = value; }
      }
      /// <summary>
      /// 专业
      /// </summary>
      private string stuff_Major;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Major_IsChanged=false;
      /// <summary>
      /// 专业
      /// </summary>
      public string Stuff_Major
      {
         get{ return stuff_Major; }
         set{ stuff_Major = value; stuff_Major_IsChanged=true; }
      }
      /// <summary>
      /// 专业
      /// </summary>
      public bool Stuff_Major_IsChanged
      {
         get{ return stuff_Major_IsChanged; }
         set{ stuff_Major_IsChanged = value; }
      }
      /// <summary>
      /// 收到简历
      /// </summary>
      private string stuff_IsResume;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_IsResume_IsChanged=false;
      /// <summary>
      /// 收到简历
      /// </summary>
      public string Stuff_IsResume
      {
         get{ return stuff_IsResume; }
         set{ stuff_IsResume = value; stuff_IsResume_IsChanged=true; }
      }
      /// <summary>
      /// 收到简历
      /// </summary>
      public bool Stuff_IsResume_IsChanged
      {
         get{ return stuff_IsResume_IsChanged; }
         set{ stuff_IsResume_IsChanged = value; }
      }
      /// <summary>
      /// 收到照片
      /// </summary>
      private string stuff_IsPic;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_IsPic_IsChanged=false;
      /// <summary>
      /// 收到照片
      /// </summary>
      public string Stuff_IsPic
      {
         get{ return stuff_IsPic; }
         set{ stuff_IsPic = value; stuff_IsPic_IsChanged=true; }
      }
      /// <summary>
      /// 收到照片
      /// </summary>
      public bool Stuff_IsPic_IsChanged
      {
         get{ return stuff_IsPic_IsChanged; }
         set{ stuff_IsPic_IsChanged = value; }
      }
      /// <summary>
      /// 收到身份证
      /// </summary>
      private string stuff_IsIDCard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_IsIDCard_IsChanged=false;
      /// <summary>
      /// 收到身份证
      /// </summary>
      public string Stuff_IsIDCard
      {
         get{ return stuff_IsIDCard; }
         set{ stuff_IsIDCard = value; stuff_IsIDCard_IsChanged=true; }
      }
      /// <summary>
      /// 收到身份证
      /// </summary>
      public bool Stuff_IsIDCard_IsChanged
      {
         get{ return stuff_IsIDCard_IsChanged; }
         set{ stuff_IsIDCard_IsChanged = value; }
      }
      /// <summary>
      /// 收到户口
      /// </summary>
      private string stuff_IsHouseHod;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_IsHouseHod_IsChanged=false;
      /// <summary>
      /// 收到户口
      /// </summary>
      public string Stuff_IsHouseHod
      {
         get{ return stuff_IsHouseHod; }
         set{ stuff_IsHouseHod = value; stuff_IsHouseHod_IsChanged=true; }
      }
      /// <summary>
      /// 收到户口
      /// </summary>
      public bool Stuff_IsHouseHod_IsChanged
      {
         get{ return stuff_IsHouseHod_IsChanged; }
         set{ stuff_IsHouseHod_IsChanged = value; }
      }
      /// <summary>
      /// 毕业证
      /// </summary>
      private string stuff_FinishCard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_FinishCard_IsChanged=false;
      /// <summary>
      /// 毕业证
      /// </summary>
      public string Stuff_FinishCard
      {
         get{ return stuff_FinishCard; }
         set{ stuff_FinishCard = value; stuff_FinishCard_IsChanged=true; }
      }
      /// <summary>
      /// 毕业证
      /// </summary>
      public bool Stuff_FinishCard_IsChanged
      {
         get{ return stuff_FinishCard_IsChanged; }
         set{ stuff_FinishCard_IsChanged = value; }
      }
      /// <summary>
      /// 职称证
      /// </summary>
      private string stuff_TechnicalCard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_TechnicalCard_IsChanged=false;
      /// <summary>
      /// 职称证
      /// </summary>
      public string Stuff_TechnicalCard
      {
         get{ return stuff_TechnicalCard; }
         set{ stuff_TechnicalCard = value; stuff_TechnicalCard_IsChanged=true; }
      }
      /// <summary>
      /// 职称证
      /// </summary>
      public bool Stuff_TechnicalCard_IsChanged
      {
         get{ return stuff_TechnicalCard_IsChanged; }
         set{ stuff_TechnicalCard_IsChanged = value; }
      }
      /// <summary>
      /// 操作证
      /// </summary>
      private string stuff_OperationCard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_OperationCard_IsChanged=false;
      /// <summary>
      /// 操作证
      /// </summary>
      public string Stuff_OperationCard
      {
         get{ return stuff_OperationCard; }
         set{ stuff_OperationCard = value; stuff_OperationCard_IsChanged=true; }
      }
      /// <summary>
      /// 操作证
      /// </summary>
      public bool Stuff_OperationCard_IsChanged
      {
         get{ return stuff_OperationCard_IsChanged; }
         set{ stuff_OperationCard_IsChanged = value; }
      }
      /// <summary>
      /// 从业资格证
      /// </summary>
      private string stuff_QualificationCard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_QualificationCard_IsChanged=false;
      /// <summary>
      /// 从业资格证
      /// </summary>
      public string Stuff_QualificationCard
      {
         get{ return stuff_QualificationCard; }
         set{ stuff_QualificationCard = value; stuff_QualificationCard_IsChanged=true; }
      }
      /// <summary>
      /// 从业资格证
      /// </summary>
      public bool Stuff_QualificationCard_IsChanged
      {
         get{ return stuff_QualificationCard_IsChanged; }
         set{ stuff_QualificationCard_IsChanged = value; }
      }
      /// <summary>
      /// 解除劳动合同证明
      /// </summary>
      private string stuff_RelaseContract;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_RelaseContract_IsChanged=false;
      /// <summary>
      /// 解除劳动合同证明
      /// </summary>
      public string Stuff_RelaseContract
      {
         get{ return stuff_RelaseContract; }
         set{ stuff_RelaseContract = value; stuff_RelaseContract_IsChanged=true; }
      }
      /// <summary>
      /// 解除劳动合同证明
      /// </summary>
      public bool Stuff_RelaseContract_IsChanged
      {
         get{ return stuff_RelaseContract_IsChanged; }
         set{ stuff_RelaseContract_IsChanged = value; }
      }
      /// <summary>
      /// 转正表
      /// </summary>
      private string stuff_TurnPaper;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_TurnPaper_IsChanged=false;
      /// <summary>
      /// 转正表
      /// </summary>
      public string Stuff_TurnPaper
      {
         get{ return stuff_TurnPaper; }
         set{ stuff_TurnPaper = value; stuff_TurnPaper_IsChanged=true; }
      }
      /// <summary>
      /// 转正表
      /// </summary>
      public bool Stuff_TurnPaper_IsChanged
      {
         get{ return stuff_TurnPaper_IsChanged; }
         set{ stuff_TurnPaper_IsChanged = value; }
      }
      /// <summary>
      /// 内部调动
      /// </summary>
      private string stuff_Trasfer;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_Trasfer_IsChanged=false;
      /// <summary>
      /// 内部调动
      /// </summary>
      public string Stuff_Trasfer
      {
         get{ return stuff_Trasfer; }
         set{ stuff_Trasfer = value; stuff_Trasfer_IsChanged=true; }
      }
      /// <summary>
      /// 内部调动
      /// </summary>
      public bool Stuff_Trasfer_IsChanged
      {
         get{ return stuff_Trasfer_IsChanged; }
         set{ stuff_Trasfer_IsChanged = value; }
      }
      /// <summary>
      /// 体检表
      /// </summary>
      private string stuff_HeathPaper;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_HeathPaper_IsChanged=false;
      /// <summary>
      /// 体检表
      /// </summary>
      public string Stuff_HeathPaper
      {
         get{ return stuff_HeathPaper; }
         set{ stuff_HeathPaper = value; stuff_HeathPaper_IsChanged=true; }
      }
      /// <summary>
      /// 体检表
      /// </summary>
      public bool Stuff_HeathPaper_IsChanged
      {
         get{ return stuff_HeathPaper_IsChanged; }
         set{ stuff_HeathPaper_IsChanged = value; }
      }
      /// <summary>
      /// 告之书
      /// </summary>
      private string stuff_AnnoucePaper;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_AnnoucePaper_IsChanged=false;
      /// <summary>
      /// 告之书
      /// </summary>
      public string Stuff_AnnoucePaper
      {
         get{ return stuff_AnnoucePaper; }
         set{ stuff_AnnoucePaper = value; stuff_AnnoucePaper_IsChanged=true; }
      }
      /// <summary>
      /// 告之书
      /// </summary>
      public bool Stuff_AnnoucePaper_IsChanged
      {
         get{ return stuff_AnnoucePaper_IsChanged; }
         set{ stuff_AnnoucePaper_IsChanged = value; }
      }
      /// <summary>
      /// 保证书
      /// </summary>
      private string stuff_AssurePaper;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_AssurePaper_IsChanged=false;
      /// <summary>
      /// 保证书
      /// </summary>
      public string Stuff_AssurePaper
      {
         get{ return stuff_AssurePaper; }
         set{ stuff_AssurePaper = value; stuff_AssurePaper_IsChanged=true; }
      }
      /// <summary>
      /// 保证书
      /// </summary>
      public bool Stuff_AssurePaper_IsChanged
      {
         get{ return stuff_AssurePaper_IsChanged; }
         set{ stuff_AssurePaper_IsChanged = value; }
      }
      /// <summary>
      /// 试用期劳动合同
      /// </summary>
      private string stuff_OnTrialContract;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_OnTrialContract_IsChanged=false;
      /// <summary>
      /// 试用期劳动合同
      /// </summary>
      public string Stuff_OnTrialContract
      {
         get{ return stuff_OnTrialContract; }
         set{ stuff_OnTrialContract = value; stuff_OnTrialContract_IsChanged=true; }
      }
      /// <summary>
      /// 试用期劳动合同
      /// </summary>
      public bool Stuff_OnTrialContract_IsChanged
      {
         get{ return stuff_OnTrialContract_IsChanged; }
         set{ stuff_OnTrialContract_IsChanged = value; }
      }
      /// <summary>
      /// 劳动合同变更主体
      /// </summary>
      private string stuff_ContractChangeBody;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_ContractChangeBody_IsChanged=false;
      /// <summary>
      /// 劳动合同变更主体
      /// </summary>
      public string Stuff_ContractChangeBody
      {
         get{ return stuff_ContractChangeBody; }
         set{ stuff_ContractChangeBody = value; stuff_ContractChangeBody_IsChanged=true; }
      }
      /// <summary>
      /// 劳动合同变更主体
      /// </summary>
      public bool Stuff_ContractChangeBody_IsChanged
      {
         get{ return stuff_ContractChangeBody_IsChanged; }
         set{ stuff_ContractChangeBody_IsChanged = value; }
      }
      /// <summary>
      /// 劳动合同所属公司
      /// </summary>
      private string stuff_ContractCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_ContractCompany_IsChanged=false;
      /// <summary>
      /// 劳动合同所属公司
      /// </summary>
      public string Stuff_ContractCompany
      {
         get{ return stuff_ContractCompany; }
         set{ stuff_ContractCompany = value; stuff_ContractCompany_IsChanged=true; }
      }
      /// <summary>
      /// 劳动合同所属公司
      /// </summary>
      public bool Stuff_ContractCompany_IsChanged
      {
         get{ return stuff_ContractCompany_IsChanged; }
         set{ stuff_ContractCompany_IsChanged = value; }
      }
      private string stuff_ContractCompanyCode;
      private bool stuff_ContractCompanyCode_IsChanged=false;
      public string Stuff_ContractCompanyCode
      {
         get{ return stuff_ContractCompanyCode; }
         set{ stuff_ContractCompanyCode = value; stuff_ContractCompanyCode_IsChanged=true; }
      }
      public bool Stuff_ContractCompanyCode_IsChanged
      {
         get{ return stuff_ContractCompanyCode_IsChanged; }
         set{ stuff_ContractCompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 档案柜
      /// </summary>
      private string stuff_FileRecord;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_FileRecord_IsChanged=false;
      /// <summary>
      /// 档案柜
      /// </summary>
      public string Stuff_FileRecord
      {
         get{ return stuff_FileRecord; }
         set{ stuff_FileRecord = value; stuff_FileRecord_IsChanged=true; }
      }
      /// <summary>
      /// 档案柜
      /// </summary>
      public bool Stuff_FileRecord_IsChanged
      {
         get{ return stuff_FileRecord_IsChanged; }
         set{ stuff_FileRecord_IsChanged = value; }
      }
      /// <summary>
      /// 转出档案柜
      /// </summary>
      private string stuff_FileRecordRemove;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stuff_FileRecordRemove_IsChanged=false;
      /// <summary>
      /// 转出档案柜
      /// </summary>
      public string Stuff_FileRecordRemove
      {
         get{ return stuff_FileRecordRemove; }
         set{ stuff_FileRecordRemove = value; stuff_FileRecordRemove_IsChanged=true; }
      }
      /// <summary>
      /// 转出档案柜
      /// </summary>
      public bool Stuff_FileRecordRemove_IsChanged
      {
         get{ return stuff_FileRecordRemove_IsChanged; }
         set{ stuff_FileRecordRemove_IsChanged = value; }
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
      private string stuff_Bak;
      private bool stuff_Bak_IsChanged=false;
      public string Stuff_Bak
      {
         get{ return stuff_Bak; }
         set{ stuff_Bak = value; stuff_Bak_IsChanged=true; }
      }
      public bool Stuff_Bak_IsChanged
      {
         get{ return stuff_Bak_IsChanged; }
         set{ stuff_Bak_IsChanged = value; }
      }
      private string stuff_Role;
      private bool stuff_Role_IsChanged=false;
      public string Stuff_Role
      {
         get{ return stuff_Role; }
         set{ stuff_Role = value; stuff_Role_IsChanged=true; }
      }
      public bool Stuff_Role_IsChanged
      {
         get{ return stuff_Role_IsChanged; }
         set{ stuff_Role_IsChanged = value; }
      }
      private string stuff_RoleName;
      private bool stuff_RoleName_IsChanged=false;
      public string Stuff_RoleName
      {
         get{ return stuff_RoleName; }
         set{ stuff_RoleName = value; stuff_RoleName_IsChanged=true; }
      }
      public bool Stuff_RoleName_IsChanged
      {
         get{ return stuff_RoleName_IsChanged; }
         set{ stuff_RoleName_IsChanged = value; }
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
   }
}
