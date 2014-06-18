using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   /// <summary>
   /// 员工信息
   /// </summary>
   [Serializable]
   public partial class ADOHR_Stuff
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加员工信息 HR_Stuff对象(即:一条记录)
      /// </summary>
      public int Add(HR_Stuff hR_Stuff)
      {
         string sql = "INSERT INTO HR_Stuff (Stuff_Code,Stuff_Name,Stuff_ENName,Stuff_Duty,Stuff_DutyCode,Stuff_Title,Stuff_DepCode,Stuff_DepName,Stuff_Director,Stuff_DirectorCode,Stuff_OTel,Stuff_Mobile,Stuff_Email,Stuff_Fax,Stuff_HTel,Stuff_Addr,Stuff_Start,Stuff_Left,Stuff_Stat,Stuff_Gender,Stuff_Birth,Stuff_Nation,Stuff_Province,Stuff_Salary,Stuff_Cost,Stuff_Type,Stuff_InsuraceStat,Stuff_Edu,Stat,CreateDate,Creator,Stuff_UserName,Stuff_Password,Stuff_LoginType,Stuff_ShortTel,Stuff_WorkNo,Stuff_TechLevel,Stuff_Heath,Stuff_InDate,Stuff_TurnDate,Stuff_TradeDate,Stuff_SignStartDate,Stuff_SingEndDate,Stuff_SpeicalCard,Stuff_FinishSchool,Stuff_Major,Stuff_IsResume,Stuff_IsPic,Stuff_IsIDCard,Stuff_IsHouseHod,Stuff_FinishCard,Stuff_TechnicalCard,Stuff_OperationCard,Stuff_QualificationCard,Stuff_RelaseContract,Stuff_TurnPaper,Stuff_Trasfer,Stuff_HeathPaper,Stuff_AnnoucePaper,Stuff_AssurePaper,Stuff_OnTrialContract,Stuff_ContractChangeBody,Stuff_ContractCompany,Stuff_ContractCompanyCode,Stuff_FileRecord,Stuff_FileRecordRemove,UpdateTime,DeleteTime,Stuff_Bak,Stuff_Role,Stuff_RoleName,CreateTime) VALUES (@Stuff_Code,@Stuff_Name,@Stuff_ENName,@Stuff_Duty,@Stuff_DutyCode,@Stuff_Title,@Stuff_DepCode,@Stuff_DepName,@Stuff_Director,@Stuff_DirectorCode,@Stuff_OTel,@Stuff_Mobile,@Stuff_Email,@Stuff_Fax,@Stuff_HTel,@Stuff_Addr,@Stuff_Start,@Stuff_Left,@Stuff_Stat,@Stuff_Gender,@Stuff_Birth,@Stuff_Nation,@Stuff_Province,@Stuff_Salary,@Stuff_Cost,@Stuff_Type,@Stuff_InsuraceStat,@Stuff_Edu,@Stat,@CreateDate,@Creator,@Stuff_UserName,@Stuff_Password,@Stuff_LoginType,@Stuff_ShortTel,@Stuff_WorkNo,@Stuff_TechLevel,@Stuff_Heath,@Stuff_InDate,@Stuff_TurnDate,@Stuff_TradeDate,@Stuff_SignStartDate,@Stuff_SingEndDate,@Stuff_SpeicalCard,@Stuff_FinishSchool,@Stuff_Major,@Stuff_IsResume,@Stuff_IsPic,@Stuff_IsIDCard,@Stuff_IsHouseHod,@Stuff_FinishCard,@Stuff_TechnicalCard,@Stuff_OperationCard,@Stuff_QualificationCard,@Stuff_RelaseContract,@Stuff_TurnPaper,@Stuff_Trasfer,@Stuff_HeathPaper,@Stuff_AnnoucePaper,@Stuff_AssurePaper,@Stuff_OnTrialContract,@Stuff_ContractChangeBody,@Stuff_ContractCompany,@Stuff_ContractCompanyCode,@Stuff_FileRecord,@Stuff_FileRecordRemove,@UpdateTime,@DeleteTime,@Stuff_Bak,@Stuff_Role,@Stuff_RoleName,@CreateTime)";
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Code))
         {
            idb.AddParameter("@Stuff_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Code", hR_Stuff.Stuff_Code);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Name))
         {
            idb.AddParameter("@Stuff_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Name", hR_Stuff.Stuff_Name);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ENName))
         {
            idb.AddParameter("@Stuff_ENName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ENName", hR_Stuff.Stuff_ENName);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Duty))
         {
            idb.AddParameter("@Stuff_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Duty", hR_Stuff.Stuff_Duty);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DutyCode))
         {
            idb.AddParameter("@Stuff_DutyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DutyCode", hR_Stuff.Stuff_DutyCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Title))
         {
            idb.AddParameter("@Stuff_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Title", hR_Stuff.Stuff_Title);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DepCode))
         {
            idb.AddParameter("@Stuff_DepCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DepCode", hR_Stuff.Stuff_DepCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DepName))
         {
            idb.AddParameter("@Stuff_DepName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DepName", hR_Stuff.Stuff_DepName);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Director))
         {
            idb.AddParameter("@Stuff_Director", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Director", hR_Stuff.Stuff_Director);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DirectorCode))
         {
            idb.AddParameter("@Stuff_DirectorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DirectorCode", hR_Stuff.Stuff_DirectorCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OTel))
         {
            idb.AddParameter("@Stuff_OTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OTel", hR_Stuff.Stuff_OTel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Mobile))
         {
            idb.AddParameter("@Stuff_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Mobile", hR_Stuff.Stuff_Mobile);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Email))
         {
            idb.AddParameter("@Stuff_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Email", hR_Stuff.Stuff_Email);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Fax))
         {
            idb.AddParameter("@Stuff_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Fax", hR_Stuff.Stuff_Fax);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_HTel))
         {
            idb.AddParameter("@Stuff_HTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_HTel", hR_Stuff.Stuff_HTel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Addr))
         {
            idb.AddParameter("@Stuff_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Addr", hR_Stuff.Stuff_Addr);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Start))
         {
            idb.AddParameter("@Stuff_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Start", hR_Stuff.Stuff_Start);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Left))
         {
            idb.AddParameter("@Stuff_Left", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Left", hR_Stuff.Stuff_Left);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Stat))
         {
            idb.AddParameter("@Stuff_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Stat", hR_Stuff.Stuff_Stat);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Gender))
         {
            idb.AddParameter("@Stuff_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Gender", hR_Stuff.Stuff_Gender);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Birth))
         {
            idb.AddParameter("@Stuff_Birth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Birth", hR_Stuff.Stuff_Birth);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Nation))
         {
            idb.AddParameter("@Stuff_Nation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Nation", hR_Stuff.Stuff_Nation);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Province))
         {
            idb.AddParameter("@Stuff_Province", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Province", hR_Stuff.Stuff_Province);
         }
         if (hR_Stuff.Stuff_Salary == 0)
         {
            idb.AddParameter("@Stuff_Salary", 0);
         }
         else
         {
            idb.AddParameter("@Stuff_Salary", hR_Stuff.Stuff_Salary);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Cost))
         {
            idb.AddParameter("@Stuff_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Cost", hR_Stuff.Stuff_Cost);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Type))
         {
            idb.AddParameter("@Stuff_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Type", hR_Stuff.Stuff_Type);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_InsuraceStat))
         {
            idb.AddParameter("@Stuff_InsuraceStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_InsuraceStat", hR_Stuff.Stuff_InsuraceStat);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Edu))
         {
            idb.AddParameter("@Stuff_Edu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Edu", hR_Stuff.Stuff_Edu);
         }
         if (hR_Stuff.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Stuff.Stat);
         }
         if (hR_Stuff.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Stuff.CreateDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_Stuff.Creator);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_UserName))
         {
            idb.AddParameter("@Stuff_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_UserName", hR_Stuff.Stuff_UserName);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Password))
         {
            idb.AddParameter("@Stuff_Password", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Password", hR_Stuff.Stuff_Password);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_LoginType))
         {
            idb.AddParameter("@Stuff_LoginType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_LoginType", hR_Stuff.Stuff_LoginType);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ShortTel))
         {
            idb.AddParameter("@Stuff_ShortTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ShortTel", hR_Stuff.Stuff_ShortTel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_WorkNo))
         {
            idb.AddParameter("@Stuff_WorkNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_WorkNo", hR_Stuff.Stuff_WorkNo);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TechLevel))
         {
            idb.AddParameter("@Stuff_TechLevel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TechLevel", hR_Stuff.Stuff_TechLevel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Heath))
         {
            idb.AddParameter("@Stuff_Heath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Heath", hR_Stuff.Stuff_Heath);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_InDate))
         {
            idb.AddParameter("@Stuff_InDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_InDate", hR_Stuff.Stuff_InDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TurnDate))
         {
            idb.AddParameter("@Stuff_TurnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TurnDate", hR_Stuff.Stuff_TurnDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TradeDate))
         {
            idb.AddParameter("@Stuff_TradeDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TradeDate", hR_Stuff.Stuff_TradeDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SignStartDate))
         {
            idb.AddParameter("@Stuff_SignStartDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SignStartDate", hR_Stuff.Stuff_SignStartDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SingEndDate))
         {
            idb.AddParameter("@Stuff_SingEndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SingEndDate", hR_Stuff.Stuff_SingEndDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SpeicalCard))
         {
            idb.AddParameter("@Stuff_SpeicalCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SpeicalCard", hR_Stuff.Stuff_SpeicalCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FinishSchool))
         {
            idb.AddParameter("@Stuff_FinishSchool", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FinishSchool", hR_Stuff.Stuff_FinishSchool);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Major))
         {
            idb.AddParameter("@Stuff_Major", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Major", hR_Stuff.Stuff_Major);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsResume))
         {
            idb.AddParameter("@Stuff_IsResume", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsResume", hR_Stuff.Stuff_IsResume);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsPic))
         {
            idb.AddParameter("@Stuff_IsPic", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsPic", hR_Stuff.Stuff_IsPic);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsIDCard))
         {
            idb.AddParameter("@Stuff_IsIDCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsIDCard", hR_Stuff.Stuff_IsIDCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsHouseHod))
         {
            idb.AddParameter("@Stuff_IsHouseHod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsHouseHod", hR_Stuff.Stuff_IsHouseHod);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FinishCard))
         {
            idb.AddParameter("@Stuff_FinishCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FinishCard", hR_Stuff.Stuff_FinishCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TechnicalCard))
         {
            idb.AddParameter("@Stuff_TechnicalCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TechnicalCard", hR_Stuff.Stuff_TechnicalCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OperationCard))
         {
            idb.AddParameter("@Stuff_OperationCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OperationCard", hR_Stuff.Stuff_OperationCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_QualificationCard))
         {
            idb.AddParameter("@Stuff_QualificationCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_QualificationCard", hR_Stuff.Stuff_QualificationCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_RelaseContract))
         {
            idb.AddParameter("@Stuff_RelaseContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_RelaseContract", hR_Stuff.Stuff_RelaseContract);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TurnPaper))
         {
            idb.AddParameter("@Stuff_TurnPaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TurnPaper", hR_Stuff.Stuff_TurnPaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Trasfer))
         {
            idb.AddParameter("@Stuff_Trasfer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Trasfer", hR_Stuff.Stuff_Trasfer);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_HeathPaper))
         {
            idb.AddParameter("@Stuff_HeathPaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_HeathPaper", hR_Stuff.Stuff_HeathPaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_AnnoucePaper))
         {
            idb.AddParameter("@Stuff_AnnoucePaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_AnnoucePaper", hR_Stuff.Stuff_AnnoucePaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_AssurePaper))
         {
            idb.AddParameter("@Stuff_AssurePaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_AssurePaper", hR_Stuff.Stuff_AssurePaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OnTrialContract))
         {
            idb.AddParameter("@Stuff_OnTrialContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OnTrialContract", hR_Stuff.Stuff_OnTrialContract);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractChangeBody))
         {
            idb.AddParameter("@Stuff_ContractChangeBody", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractChangeBody", hR_Stuff.Stuff_ContractChangeBody);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractCompany))
         {
            idb.AddParameter("@Stuff_ContractCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractCompany", hR_Stuff.Stuff_ContractCompany);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractCompanyCode))
         {
            idb.AddParameter("@Stuff_ContractCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractCompanyCode", hR_Stuff.Stuff_ContractCompanyCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FileRecord))
         {
            idb.AddParameter("@Stuff_FileRecord", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FileRecord", hR_Stuff.Stuff_FileRecord);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FileRecordRemove))
         {
            idb.AddParameter("@Stuff_FileRecordRemove", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FileRecordRemove", hR_Stuff.Stuff_FileRecordRemove);
         }
         if (hR_Stuff.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", hR_Stuff.UpdateTime);
         }
         if (hR_Stuff.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", hR_Stuff.DeleteTime);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Bak))
         {
            idb.AddParameter("@Stuff_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Bak", hR_Stuff.Stuff_Bak);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Role))
         {
            idb.AddParameter("@Stuff_Role", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Role", hR_Stuff.Stuff_Role);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_RoleName))
         {
            idb.AddParameter("@Stuff_RoleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_RoleName", hR_Stuff.Stuff_RoleName);
         }
         if (hR_Stuff.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_Stuff.CreateTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加员工信息 HR_Stuff对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_Stuff hR_Stuff)
      {
         string sql = "INSERT INTO HR_Stuff (Stuff_Code,Stuff_Name,Stuff_ENName,Stuff_Duty,Stuff_DutyCode,Stuff_Title,Stuff_DepCode,Stuff_DepName,Stuff_Director,Stuff_DirectorCode,Stuff_OTel,Stuff_Mobile,Stuff_Email,Stuff_Fax,Stuff_HTel,Stuff_Addr,Stuff_Start,Stuff_Left,Stuff_Stat,Stuff_Gender,Stuff_Birth,Stuff_Nation,Stuff_Province,Stuff_Salary,Stuff_Cost,Stuff_Type,Stuff_InsuraceStat,Stuff_Edu,Stat,CreateDate,Creator,Stuff_UserName,Stuff_Password,Stuff_LoginType,Stuff_ShortTel,Stuff_WorkNo,Stuff_TechLevel,Stuff_Heath,Stuff_InDate,Stuff_TurnDate,Stuff_TradeDate,Stuff_SignStartDate,Stuff_SingEndDate,Stuff_SpeicalCard,Stuff_FinishSchool,Stuff_Major,Stuff_IsResume,Stuff_IsPic,Stuff_IsIDCard,Stuff_IsHouseHod,Stuff_FinishCard,Stuff_TechnicalCard,Stuff_OperationCard,Stuff_QualificationCard,Stuff_RelaseContract,Stuff_TurnPaper,Stuff_Trasfer,Stuff_HeathPaper,Stuff_AnnoucePaper,Stuff_AssurePaper,Stuff_OnTrialContract,Stuff_ContractChangeBody,Stuff_ContractCompany,Stuff_ContractCompanyCode,Stuff_FileRecord,Stuff_FileRecordRemove,UpdateTime,DeleteTime,Stuff_Bak,Stuff_Role,Stuff_RoleName,CreateTime) VALUES (@Stuff_Code,@Stuff_Name,@Stuff_ENName,@Stuff_Duty,@Stuff_DutyCode,@Stuff_Title,@Stuff_DepCode,@Stuff_DepName,@Stuff_Director,@Stuff_DirectorCode,@Stuff_OTel,@Stuff_Mobile,@Stuff_Email,@Stuff_Fax,@Stuff_HTel,@Stuff_Addr,@Stuff_Start,@Stuff_Left,@Stuff_Stat,@Stuff_Gender,@Stuff_Birth,@Stuff_Nation,@Stuff_Province,@Stuff_Salary,@Stuff_Cost,@Stuff_Type,@Stuff_InsuraceStat,@Stuff_Edu,@Stat,@CreateDate,@Creator,@Stuff_UserName,@Stuff_Password,@Stuff_LoginType,@Stuff_ShortTel,@Stuff_WorkNo,@Stuff_TechLevel,@Stuff_Heath,@Stuff_InDate,@Stuff_TurnDate,@Stuff_TradeDate,@Stuff_SignStartDate,@Stuff_SingEndDate,@Stuff_SpeicalCard,@Stuff_FinishSchool,@Stuff_Major,@Stuff_IsResume,@Stuff_IsPic,@Stuff_IsIDCard,@Stuff_IsHouseHod,@Stuff_FinishCard,@Stuff_TechnicalCard,@Stuff_OperationCard,@Stuff_QualificationCard,@Stuff_RelaseContract,@Stuff_TurnPaper,@Stuff_Trasfer,@Stuff_HeathPaper,@Stuff_AnnoucePaper,@Stuff_AssurePaper,@Stuff_OnTrialContract,@Stuff_ContractChangeBody,@Stuff_ContractCompany,@Stuff_ContractCompanyCode,@Stuff_FileRecord,@Stuff_FileRecordRemove,@UpdateTime,@DeleteTime,@Stuff_Bak,@Stuff_Role,@Stuff_RoleName,@CreateTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Code))
         {
            idb.AddParameter("@Stuff_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Code", hR_Stuff.Stuff_Code);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Name))
         {
            idb.AddParameter("@Stuff_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Name", hR_Stuff.Stuff_Name);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ENName))
         {
            idb.AddParameter("@Stuff_ENName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ENName", hR_Stuff.Stuff_ENName);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Duty))
         {
            idb.AddParameter("@Stuff_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Duty", hR_Stuff.Stuff_Duty);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DutyCode))
         {
            idb.AddParameter("@Stuff_DutyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DutyCode", hR_Stuff.Stuff_DutyCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Title))
         {
            idb.AddParameter("@Stuff_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Title", hR_Stuff.Stuff_Title);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DepCode))
         {
            idb.AddParameter("@Stuff_DepCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DepCode", hR_Stuff.Stuff_DepCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DepName))
         {
            idb.AddParameter("@Stuff_DepName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DepName", hR_Stuff.Stuff_DepName);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Director))
         {
            idb.AddParameter("@Stuff_Director", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Director", hR_Stuff.Stuff_Director);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DirectorCode))
         {
            idb.AddParameter("@Stuff_DirectorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DirectorCode", hR_Stuff.Stuff_DirectorCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OTel))
         {
            idb.AddParameter("@Stuff_OTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OTel", hR_Stuff.Stuff_OTel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Mobile))
         {
            idb.AddParameter("@Stuff_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Mobile", hR_Stuff.Stuff_Mobile);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Email))
         {
            idb.AddParameter("@Stuff_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Email", hR_Stuff.Stuff_Email);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Fax))
         {
            idb.AddParameter("@Stuff_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Fax", hR_Stuff.Stuff_Fax);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_HTel))
         {
            idb.AddParameter("@Stuff_HTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_HTel", hR_Stuff.Stuff_HTel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Addr))
         {
            idb.AddParameter("@Stuff_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Addr", hR_Stuff.Stuff_Addr);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Start))
         {
            idb.AddParameter("@Stuff_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Start", hR_Stuff.Stuff_Start);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Left))
         {
            idb.AddParameter("@Stuff_Left", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Left", hR_Stuff.Stuff_Left);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Stat))
         {
            idb.AddParameter("@Stuff_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Stat", hR_Stuff.Stuff_Stat);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Gender))
         {
            idb.AddParameter("@Stuff_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Gender", hR_Stuff.Stuff_Gender);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Birth))
         {
            idb.AddParameter("@Stuff_Birth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Birth", hR_Stuff.Stuff_Birth);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Nation))
         {
            idb.AddParameter("@Stuff_Nation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Nation", hR_Stuff.Stuff_Nation);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Province))
         {
            idb.AddParameter("@Stuff_Province", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Province", hR_Stuff.Stuff_Province);
         }
         if (hR_Stuff.Stuff_Salary == 0)
         {
            idb.AddParameter("@Stuff_Salary", 0);
         }
         else
         {
            idb.AddParameter("@Stuff_Salary", hR_Stuff.Stuff_Salary);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Cost))
         {
            idb.AddParameter("@Stuff_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Cost", hR_Stuff.Stuff_Cost);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Type))
         {
            idb.AddParameter("@Stuff_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Type", hR_Stuff.Stuff_Type);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_InsuraceStat))
         {
            idb.AddParameter("@Stuff_InsuraceStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_InsuraceStat", hR_Stuff.Stuff_InsuraceStat);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Edu))
         {
            idb.AddParameter("@Stuff_Edu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Edu", hR_Stuff.Stuff_Edu);
         }
         if (hR_Stuff.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Stuff.Stat);
         }
         if (hR_Stuff.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Stuff.CreateDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_Stuff.Creator);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_UserName))
         {
            idb.AddParameter("@Stuff_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_UserName", hR_Stuff.Stuff_UserName);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Password))
         {
            idb.AddParameter("@Stuff_Password", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Password", hR_Stuff.Stuff_Password);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_LoginType))
         {
            idb.AddParameter("@Stuff_LoginType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_LoginType", hR_Stuff.Stuff_LoginType);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ShortTel))
         {
            idb.AddParameter("@Stuff_ShortTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ShortTel", hR_Stuff.Stuff_ShortTel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_WorkNo))
         {
            idb.AddParameter("@Stuff_WorkNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_WorkNo", hR_Stuff.Stuff_WorkNo);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TechLevel))
         {
            idb.AddParameter("@Stuff_TechLevel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TechLevel", hR_Stuff.Stuff_TechLevel);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Heath))
         {
            idb.AddParameter("@Stuff_Heath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Heath", hR_Stuff.Stuff_Heath);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_InDate))
         {
            idb.AddParameter("@Stuff_InDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_InDate", hR_Stuff.Stuff_InDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TurnDate))
         {
            idb.AddParameter("@Stuff_TurnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TurnDate", hR_Stuff.Stuff_TurnDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TradeDate))
         {
            idb.AddParameter("@Stuff_TradeDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TradeDate", hR_Stuff.Stuff_TradeDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SignStartDate))
         {
            idb.AddParameter("@Stuff_SignStartDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SignStartDate", hR_Stuff.Stuff_SignStartDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SingEndDate))
         {
            idb.AddParameter("@Stuff_SingEndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SingEndDate", hR_Stuff.Stuff_SingEndDate);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SpeicalCard))
         {
            idb.AddParameter("@Stuff_SpeicalCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SpeicalCard", hR_Stuff.Stuff_SpeicalCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FinishSchool))
         {
            idb.AddParameter("@Stuff_FinishSchool", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FinishSchool", hR_Stuff.Stuff_FinishSchool);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Major))
         {
            idb.AddParameter("@Stuff_Major", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Major", hR_Stuff.Stuff_Major);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsResume))
         {
            idb.AddParameter("@Stuff_IsResume", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsResume", hR_Stuff.Stuff_IsResume);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsPic))
         {
            idb.AddParameter("@Stuff_IsPic", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsPic", hR_Stuff.Stuff_IsPic);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsIDCard))
         {
            idb.AddParameter("@Stuff_IsIDCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsIDCard", hR_Stuff.Stuff_IsIDCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsHouseHod))
         {
            idb.AddParameter("@Stuff_IsHouseHod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsHouseHod", hR_Stuff.Stuff_IsHouseHod);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FinishCard))
         {
            idb.AddParameter("@Stuff_FinishCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FinishCard", hR_Stuff.Stuff_FinishCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TechnicalCard))
         {
            idb.AddParameter("@Stuff_TechnicalCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TechnicalCard", hR_Stuff.Stuff_TechnicalCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OperationCard))
         {
            idb.AddParameter("@Stuff_OperationCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OperationCard", hR_Stuff.Stuff_OperationCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_QualificationCard))
         {
            idb.AddParameter("@Stuff_QualificationCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_QualificationCard", hR_Stuff.Stuff_QualificationCard);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_RelaseContract))
         {
            idb.AddParameter("@Stuff_RelaseContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_RelaseContract", hR_Stuff.Stuff_RelaseContract);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TurnPaper))
         {
            idb.AddParameter("@Stuff_TurnPaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TurnPaper", hR_Stuff.Stuff_TurnPaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Trasfer))
         {
            idb.AddParameter("@Stuff_Trasfer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Trasfer", hR_Stuff.Stuff_Trasfer);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_HeathPaper))
         {
            idb.AddParameter("@Stuff_HeathPaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_HeathPaper", hR_Stuff.Stuff_HeathPaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_AnnoucePaper))
         {
            idb.AddParameter("@Stuff_AnnoucePaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_AnnoucePaper", hR_Stuff.Stuff_AnnoucePaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_AssurePaper))
         {
            idb.AddParameter("@Stuff_AssurePaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_AssurePaper", hR_Stuff.Stuff_AssurePaper);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OnTrialContract))
         {
            idb.AddParameter("@Stuff_OnTrialContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OnTrialContract", hR_Stuff.Stuff_OnTrialContract);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractChangeBody))
         {
            idb.AddParameter("@Stuff_ContractChangeBody", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractChangeBody", hR_Stuff.Stuff_ContractChangeBody);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractCompany))
         {
            idb.AddParameter("@Stuff_ContractCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractCompany", hR_Stuff.Stuff_ContractCompany);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractCompanyCode))
         {
            idb.AddParameter("@Stuff_ContractCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractCompanyCode", hR_Stuff.Stuff_ContractCompanyCode);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FileRecord))
         {
            idb.AddParameter("@Stuff_FileRecord", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FileRecord", hR_Stuff.Stuff_FileRecord);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FileRecordRemove))
         {
            idb.AddParameter("@Stuff_FileRecordRemove", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FileRecordRemove", hR_Stuff.Stuff_FileRecordRemove);
         }
         if (hR_Stuff.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", hR_Stuff.UpdateTime);
         }
         if (hR_Stuff.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", hR_Stuff.DeleteTime);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Bak))
         {
            idb.AddParameter("@Stuff_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Bak", hR_Stuff.Stuff_Bak);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Role))
         {
            idb.AddParameter("@Stuff_Role", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Role", hR_Stuff.Stuff_Role);
         }
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_RoleName))
         {
            idb.AddParameter("@Stuff_RoleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_RoleName", hR_Stuff.Stuff_RoleName);
         }
         if (hR_Stuff.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_Stuff.CreateTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新员工信息 HR_Stuff对象(即:一条记录
      /// </summary>
      public int Update(HR_Stuff hR_Stuff)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_Stuff       SET ");
            if(hR_Stuff.Stuff_Code_IsChanged){sbParameter.Append("Stuff_Code=@Stuff_Code, ");}
      if(hR_Stuff.Stuff_Name_IsChanged){sbParameter.Append("Stuff_Name=@Stuff_Name, ");}
      if(hR_Stuff.Stuff_ENName_IsChanged){sbParameter.Append("Stuff_ENName=@Stuff_ENName, ");}
      if(hR_Stuff.Stuff_Duty_IsChanged){sbParameter.Append("Stuff_Duty=@Stuff_Duty, ");}
      if(hR_Stuff.Stuff_DutyCode_IsChanged){sbParameter.Append("Stuff_DutyCode=@Stuff_DutyCode, ");}
      if(hR_Stuff.Stuff_Title_IsChanged){sbParameter.Append("Stuff_Title=@Stuff_Title, ");}
      if(hR_Stuff.Stuff_DepCode_IsChanged){sbParameter.Append("Stuff_DepCode=@Stuff_DepCode, ");}
      if(hR_Stuff.Stuff_DepName_IsChanged){sbParameter.Append("Stuff_DepName=@Stuff_DepName, ");}
      if(hR_Stuff.Stuff_Director_IsChanged){sbParameter.Append("Stuff_Director=@Stuff_Director, ");}
      if(hR_Stuff.Stuff_DirectorCode_IsChanged){sbParameter.Append("Stuff_DirectorCode=@Stuff_DirectorCode, ");}
      if(hR_Stuff.Stuff_OTel_IsChanged){sbParameter.Append("Stuff_OTel=@Stuff_OTel, ");}
      if(hR_Stuff.Stuff_Mobile_IsChanged){sbParameter.Append("Stuff_Mobile=@Stuff_Mobile, ");}
      if(hR_Stuff.Stuff_Email_IsChanged){sbParameter.Append("Stuff_Email=@Stuff_Email, ");}
      if(hR_Stuff.Stuff_Fax_IsChanged){sbParameter.Append("Stuff_Fax=@Stuff_Fax, ");}
      if(hR_Stuff.Stuff_HTel_IsChanged){sbParameter.Append("Stuff_HTel=@Stuff_HTel, ");}
      if(hR_Stuff.Stuff_Addr_IsChanged){sbParameter.Append("Stuff_Addr=@Stuff_Addr, ");}
      if(hR_Stuff.Stuff_Start_IsChanged){sbParameter.Append("Stuff_Start=@Stuff_Start, ");}
      if(hR_Stuff.Stuff_Left_IsChanged){sbParameter.Append("Stuff_Left=@Stuff_Left, ");}
      if(hR_Stuff.Stuff_Stat_IsChanged){sbParameter.Append("Stuff_Stat=@Stuff_Stat, ");}
      if(hR_Stuff.Stuff_Gender_IsChanged){sbParameter.Append("Stuff_Gender=@Stuff_Gender, ");}
      if(hR_Stuff.Stuff_Birth_IsChanged){sbParameter.Append("Stuff_Birth=@Stuff_Birth, ");}
      if(hR_Stuff.Stuff_Nation_IsChanged){sbParameter.Append("Stuff_Nation=@Stuff_Nation, ");}
      if(hR_Stuff.Stuff_Province_IsChanged){sbParameter.Append("Stuff_Province=@Stuff_Province, ");}
      if(hR_Stuff.Stuff_Salary_IsChanged){sbParameter.Append("Stuff_Salary=@Stuff_Salary, ");}
      if(hR_Stuff.Stuff_Cost_IsChanged){sbParameter.Append("Stuff_Cost=@Stuff_Cost, ");}
      if(hR_Stuff.Stuff_Type_IsChanged){sbParameter.Append("Stuff_Type=@Stuff_Type, ");}
      if(hR_Stuff.Stuff_InsuraceStat_IsChanged){sbParameter.Append("Stuff_InsuraceStat=@Stuff_InsuraceStat, ");}
      if(hR_Stuff.Stuff_Edu_IsChanged){sbParameter.Append("Stuff_Edu=@Stuff_Edu, ");}
      if(hR_Stuff.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_Stuff.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_Stuff.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(hR_Stuff.Stuff_UserName_IsChanged){sbParameter.Append("Stuff_UserName=@Stuff_UserName, ");}
      if(hR_Stuff.Stuff_Password_IsChanged){sbParameter.Append("Stuff_Password=@Stuff_Password, ");}
      if(hR_Stuff.Stuff_LoginType_IsChanged){sbParameter.Append("Stuff_LoginType=@Stuff_LoginType, ");}
      if(hR_Stuff.Stuff_ShortTel_IsChanged){sbParameter.Append("Stuff_ShortTel=@Stuff_ShortTel, ");}
      if(hR_Stuff.Stuff_WorkNo_IsChanged){sbParameter.Append("Stuff_WorkNo=@Stuff_WorkNo, ");}
      if(hR_Stuff.Stuff_TechLevel_IsChanged){sbParameter.Append("Stuff_TechLevel=@Stuff_TechLevel, ");}
      if(hR_Stuff.Stuff_Heath_IsChanged){sbParameter.Append("Stuff_Heath=@Stuff_Heath, ");}
      if(hR_Stuff.Stuff_InDate_IsChanged){sbParameter.Append("Stuff_InDate=@Stuff_InDate, ");}
      if(hR_Stuff.Stuff_TurnDate_IsChanged){sbParameter.Append("Stuff_TurnDate=@Stuff_TurnDate, ");}
      if(hR_Stuff.Stuff_TradeDate_IsChanged){sbParameter.Append("Stuff_TradeDate=@Stuff_TradeDate, ");}
      if(hR_Stuff.Stuff_SignStartDate_IsChanged){sbParameter.Append("Stuff_SignStartDate=@Stuff_SignStartDate, ");}
      if(hR_Stuff.Stuff_SingEndDate_IsChanged){sbParameter.Append("Stuff_SingEndDate=@Stuff_SingEndDate, ");}
      if(hR_Stuff.Stuff_SpeicalCard_IsChanged){sbParameter.Append("Stuff_SpeicalCard=@Stuff_SpeicalCard, ");}
      if(hR_Stuff.Stuff_FinishSchool_IsChanged){sbParameter.Append("Stuff_FinishSchool=@Stuff_FinishSchool, ");}
      if(hR_Stuff.Stuff_Major_IsChanged){sbParameter.Append("Stuff_Major=@Stuff_Major, ");}
      if(hR_Stuff.Stuff_IsResume_IsChanged){sbParameter.Append("Stuff_IsResume=@Stuff_IsResume, ");}
      if(hR_Stuff.Stuff_IsPic_IsChanged){sbParameter.Append("Stuff_IsPic=@Stuff_IsPic, ");}
      if(hR_Stuff.Stuff_IsIDCard_IsChanged){sbParameter.Append("Stuff_IsIDCard=@Stuff_IsIDCard, ");}
      if(hR_Stuff.Stuff_IsHouseHod_IsChanged){sbParameter.Append("Stuff_IsHouseHod=@Stuff_IsHouseHod, ");}
      if(hR_Stuff.Stuff_FinishCard_IsChanged){sbParameter.Append("Stuff_FinishCard=@Stuff_FinishCard, ");}
      if(hR_Stuff.Stuff_TechnicalCard_IsChanged){sbParameter.Append("Stuff_TechnicalCard=@Stuff_TechnicalCard, ");}
      if(hR_Stuff.Stuff_OperationCard_IsChanged){sbParameter.Append("Stuff_OperationCard=@Stuff_OperationCard, ");}
      if(hR_Stuff.Stuff_QualificationCard_IsChanged){sbParameter.Append("Stuff_QualificationCard=@Stuff_QualificationCard, ");}
      if(hR_Stuff.Stuff_RelaseContract_IsChanged){sbParameter.Append("Stuff_RelaseContract=@Stuff_RelaseContract, ");}
      if(hR_Stuff.Stuff_TurnPaper_IsChanged){sbParameter.Append("Stuff_TurnPaper=@Stuff_TurnPaper, ");}
      if(hR_Stuff.Stuff_Trasfer_IsChanged){sbParameter.Append("Stuff_Trasfer=@Stuff_Trasfer, ");}
      if(hR_Stuff.Stuff_HeathPaper_IsChanged){sbParameter.Append("Stuff_HeathPaper=@Stuff_HeathPaper, ");}
      if(hR_Stuff.Stuff_AnnoucePaper_IsChanged){sbParameter.Append("Stuff_AnnoucePaper=@Stuff_AnnoucePaper, ");}
      if(hR_Stuff.Stuff_AssurePaper_IsChanged){sbParameter.Append("Stuff_AssurePaper=@Stuff_AssurePaper, ");}
      if(hR_Stuff.Stuff_OnTrialContract_IsChanged){sbParameter.Append("Stuff_OnTrialContract=@Stuff_OnTrialContract, ");}
      if(hR_Stuff.Stuff_ContractChangeBody_IsChanged){sbParameter.Append("Stuff_ContractChangeBody=@Stuff_ContractChangeBody, ");}
      if(hR_Stuff.Stuff_ContractCompany_IsChanged){sbParameter.Append("Stuff_ContractCompany=@Stuff_ContractCompany, ");}
      if(hR_Stuff.Stuff_ContractCompanyCode_IsChanged){sbParameter.Append("Stuff_ContractCompanyCode=@Stuff_ContractCompanyCode, ");}
      if(hR_Stuff.Stuff_FileRecord_IsChanged){sbParameter.Append("Stuff_FileRecord=@Stuff_FileRecord, ");}
      if(hR_Stuff.Stuff_FileRecordRemove_IsChanged){sbParameter.Append("Stuff_FileRecordRemove=@Stuff_FileRecordRemove, ");}
      if(hR_Stuff.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(hR_Stuff.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime, ");}
      if(hR_Stuff.Stuff_Bak_IsChanged){sbParameter.Append("Stuff_Bak=@Stuff_Bak, ");}
      if(hR_Stuff.Stuff_Role_IsChanged){sbParameter.Append("Stuff_Role=@Stuff_Role, ");}
      if(hR_Stuff.Stuff_RoleName_IsChanged){sbParameter.Append("Stuff_RoleName=@Stuff_RoleName, ");}
      if(hR_Stuff.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Stuff_ID=@Stuff_ID; " );
      string sql=sb.ToString();
         if(hR_Stuff.Stuff_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Code))
         {
            idb.AddParameter("@Stuff_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Code", hR_Stuff.Stuff_Code);
         }
          }
         if(hR_Stuff.Stuff_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Name))
         {
            idb.AddParameter("@Stuff_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Name", hR_Stuff.Stuff_Name);
         }
          }
         if(hR_Stuff.Stuff_ENName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ENName))
         {
            idb.AddParameter("@Stuff_ENName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ENName", hR_Stuff.Stuff_ENName);
         }
          }
         if(hR_Stuff.Stuff_Duty_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Duty))
         {
            idb.AddParameter("@Stuff_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Duty", hR_Stuff.Stuff_Duty);
         }
          }
         if(hR_Stuff.Stuff_DutyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DutyCode))
         {
            idb.AddParameter("@Stuff_DutyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DutyCode", hR_Stuff.Stuff_DutyCode);
         }
          }
         if(hR_Stuff.Stuff_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Title))
         {
            idb.AddParameter("@Stuff_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Title", hR_Stuff.Stuff_Title);
         }
          }
         if(hR_Stuff.Stuff_DepCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DepCode))
         {
            idb.AddParameter("@Stuff_DepCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DepCode", hR_Stuff.Stuff_DepCode);
         }
          }
         if(hR_Stuff.Stuff_DepName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DepName))
         {
            idb.AddParameter("@Stuff_DepName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DepName", hR_Stuff.Stuff_DepName);
         }
          }
         if(hR_Stuff.Stuff_Director_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Director))
         {
            idb.AddParameter("@Stuff_Director", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Director", hR_Stuff.Stuff_Director);
         }
          }
         if(hR_Stuff.Stuff_DirectorCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_DirectorCode))
         {
            idb.AddParameter("@Stuff_DirectorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_DirectorCode", hR_Stuff.Stuff_DirectorCode);
         }
          }
         if(hR_Stuff.Stuff_OTel_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OTel))
         {
            idb.AddParameter("@Stuff_OTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OTel", hR_Stuff.Stuff_OTel);
         }
          }
         if(hR_Stuff.Stuff_Mobile_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Mobile))
         {
            idb.AddParameter("@Stuff_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Mobile", hR_Stuff.Stuff_Mobile);
         }
          }
         if(hR_Stuff.Stuff_Email_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Email))
         {
            idb.AddParameter("@Stuff_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Email", hR_Stuff.Stuff_Email);
         }
          }
         if(hR_Stuff.Stuff_Fax_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Fax))
         {
            idb.AddParameter("@Stuff_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Fax", hR_Stuff.Stuff_Fax);
         }
          }
         if(hR_Stuff.Stuff_HTel_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_HTel))
         {
            idb.AddParameter("@Stuff_HTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_HTel", hR_Stuff.Stuff_HTel);
         }
          }
         if(hR_Stuff.Stuff_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Addr))
         {
            idb.AddParameter("@Stuff_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Addr", hR_Stuff.Stuff_Addr);
         }
          }
         if(hR_Stuff.Stuff_Start_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Start))
         {
            idb.AddParameter("@Stuff_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Start", hR_Stuff.Stuff_Start);
         }
          }
         if(hR_Stuff.Stuff_Left_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Left))
         {
            idb.AddParameter("@Stuff_Left", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Left", hR_Stuff.Stuff_Left);
         }
          }
         if(hR_Stuff.Stuff_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Stat))
         {
            idb.AddParameter("@Stuff_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Stat", hR_Stuff.Stuff_Stat);
         }
          }
         if(hR_Stuff.Stuff_Gender_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Gender))
         {
            idb.AddParameter("@Stuff_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Gender", hR_Stuff.Stuff_Gender);
         }
          }
         if(hR_Stuff.Stuff_Birth_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Birth))
         {
            idb.AddParameter("@Stuff_Birth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Birth", hR_Stuff.Stuff_Birth);
         }
          }
         if(hR_Stuff.Stuff_Nation_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Nation))
         {
            idb.AddParameter("@Stuff_Nation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Nation", hR_Stuff.Stuff_Nation);
         }
          }
         if(hR_Stuff.Stuff_Province_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Province))
         {
            idb.AddParameter("@Stuff_Province", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Province", hR_Stuff.Stuff_Province);
         }
          }
         if(hR_Stuff.Stuff_Salary_IsChanged)
         {
         if (hR_Stuff.Stuff_Salary == 0)
         {
            idb.AddParameter("@Stuff_Salary", 0);
         }
         else
         {
            idb.AddParameter("@Stuff_Salary", hR_Stuff.Stuff_Salary);
         }
          }
         if(hR_Stuff.Stuff_Cost_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Cost))
         {
            idb.AddParameter("@Stuff_Cost", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Cost", hR_Stuff.Stuff_Cost);
         }
          }
         if(hR_Stuff.Stuff_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Type))
         {
            idb.AddParameter("@Stuff_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Type", hR_Stuff.Stuff_Type);
         }
          }
         if(hR_Stuff.Stuff_InsuraceStat_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_InsuraceStat))
         {
            idb.AddParameter("@Stuff_InsuraceStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_InsuraceStat", hR_Stuff.Stuff_InsuraceStat);
         }
          }
         if(hR_Stuff.Stuff_Edu_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Edu))
         {
            idb.AddParameter("@Stuff_Edu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Edu", hR_Stuff.Stuff_Edu);
         }
          }
         if(hR_Stuff.Stat_IsChanged)
         {
         if (hR_Stuff.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Stuff.Stat);
         }
          }
         if(hR_Stuff.CreateDate_IsChanged)
         {
         if (hR_Stuff.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Stuff.CreateDate);
         }
          }
         if(hR_Stuff.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_Stuff.Creator);
         }
          }
         if(hR_Stuff.Stuff_UserName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_UserName))
         {
            idb.AddParameter("@Stuff_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_UserName", hR_Stuff.Stuff_UserName);
         }
          }
         if(hR_Stuff.Stuff_Password_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Password))
         {
            idb.AddParameter("@Stuff_Password", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Password", hR_Stuff.Stuff_Password);
         }
          }
         if(hR_Stuff.Stuff_LoginType_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_LoginType))
         {
            idb.AddParameter("@Stuff_LoginType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_LoginType", hR_Stuff.Stuff_LoginType);
         }
          }
         if(hR_Stuff.Stuff_ShortTel_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ShortTel))
         {
            idb.AddParameter("@Stuff_ShortTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ShortTel", hR_Stuff.Stuff_ShortTel);
         }
          }
         if(hR_Stuff.Stuff_WorkNo_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_WorkNo))
         {
            idb.AddParameter("@Stuff_WorkNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_WorkNo", hR_Stuff.Stuff_WorkNo);
         }
          }
         if(hR_Stuff.Stuff_TechLevel_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TechLevel))
         {
            idb.AddParameter("@Stuff_TechLevel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TechLevel", hR_Stuff.Stuff_TechLevel);
         }
          }
         if(hR_Stuff.Stuff_Heath_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Heath))
         {
            idb.AddParameter("@Stuff_Heath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Heath", hR_Stuff.Stuff_Heath);
         }
          }
         if(hR_Stuff.Stuff_InDate_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_InDate))
         {
            idb.AddParameter("@Stuff_InDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_InDate", hR_Stuff.Stuff_InDate);
         }
          }
         if(hR_Stuff.Stuff_TurnDate_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TurnDate))
         {
            idb.AddParameter("@Stuff_TurnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TurnDate", hR_Stuff.Stuff_TurnDate);
         }
          }
         if(hR_Stuff.Stuff_TradeDate_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TradeDate))
         {
            idb.AddParameter("@Stuff_TradeDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TradeDate", hR_Stuff.Stuff_TradeDate);
         }
          }
         if(hR_Stuff.Stuff_SignStartDate_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SignStartDate))
         {
            idb.AddParameter("@Stuff_SignStartDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SignStartDate", hR_Stuff.Stuff_SignStartDate);
         }
          }
         if(hR_Stuff.Stuff_SingEndDate_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SingEndDate))
         {
            idb.AddParameter("@Stuff_SingEndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SingEndDate", hR_Stuff.Stuff_SingEndDate);
         }
          }
         if(hR_Stuff.Stuff_SpeicalCard_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_SpeicalCard))
         {
            idb.AddParameter("@Stuff_SpeicalCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_SpeicalCard", hR_Stuff.Stuff_SpeicalCard);
         }
          }
         if(hR_Stuff.Stuff_FinishSchool_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FinishSchool))
         {
            idb.AddParameter("@Stuff_FinishSchool", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FinishSchool", hR_Stuff.Stuff_FinishSchool);
         }
          }
         if(hR_Stuff.Stuff_Major_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Major))
         {
            idb.AddParameter("@Stuff_Major", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Major", hR_Stuff.Stuff_Major);
         }
          }
         if(hR_Stuff.Stuff_IsResume_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsResume))
         {
            idb.AddParameter("@Stuff_IsResume", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsResume", hR_Stuff.Stuff_IsResume);
         }
          }
         if(hR_Stuff.Stuff_IsPic_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsPic))
         {
            idb.AddParameter("@Stuff_IsPic", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsPic", hR_Stuff.Stuff_IsPic);
         }
          }
         if(hR_Stuff.Stuff_IsIDCard_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsIDCard))
         {
            idb.AddParameter("@Stuff_IsIDCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsIDCard", hR_Stuff.Stuff_IsIDCard);
         }
          }
         if(hR_Stuff.Stuff_IsHouseHod_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_IsHouseHod))
         {
            idb.AddParameter("@Stuff_IsHouseHod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_IsHouseHod", hR_Stuff.Stuff_IsHouseHod);
         }
          }
         if(hR_Stuff.Stuff_FinishCard_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FinishCard))
         {
            idb.AddParameter("@Stuff_FinishCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FinishCard", hR_Stuff.Stuff_FinishCard);
         }
          }
         if(hR_Stuff.Stuff_TechnicalCard_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TechnicalCard))
         {
            idb.AddParameter("@Stuff_TechnicalCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TechnicalCard", hR_Stuff.Stuff_TechnicalCard);
         }
          }
         if(hR_Stuff.Stuff_OperationCard_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OperationCard))
         {
            idb.AddParameter("@Stuff_OperationCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OperationCard", hR_Stuff.Stuff_OperationCard);
         }
          }
         if(hR_Stuff.Stuff_QualificationCard_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_QualificationCard))
         {
            idb.AddParameter("@Stuff_QualificationCard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_QualificationCard", hR_Stuff.Stuff_QualificationCard);
         }
          }
         if(hR_Stuff.Stuff_RelaseContract_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_RelaseContract))
         {
            idb.AddParameter("@Stuff_RelaseContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_RelaseContract", hR_Stuff.Stuff_RelaseContract);
         }
          }
         if(hR_Stuff.Stuff_TurnPaper_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_TurnPaper))
         {
            idb.AddParameter("@Stuff_TurnPaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_TurnPaper", hR_Stuff.Stuff_TurnPaper);
         }
          }
         if(hR_Stuff.Stuff_Trasfer_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Trasfer))
         {
            idb.AddParameter("@Stuff_Trasfer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Trasfer", hR_Stuff.Stuff_Trasfer);
         }
          }
         if(hR_Stuff.Stuff_HeathPaper_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_HeathPaper))
         {
            idb.AddParameter("@Stuff_HeathPaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_HeathPaper", hR_Stuff.Stuff_HeathPaper);
         }
          }
         if(hR_Stuff.Stuff_AnnoucePaper_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_AnnoucePaper))
         {
            idb.AddParameter("@Stuff_AnnoucePaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_AnnoucePaper", hR_Stuff.Stuff_AnnoucePaper);
         }
          }
         if(hR_Stuff.Stuff_AssurePaper_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_AssurePaper))
         {
            idb.AddParameter("@Stuff_AssurePaper", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_AssurePaper", hR_Stuff.Stuff_AssurePaper);
         }
          }
         if(hR_Stuff.Stuff_OnTrialContract_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_OnTrialContract))
         {
            idb.AddParameter("@Stuff_OnTrialContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_OnTrialContract", hR_Stuff.Stuff_OnTrialContract);
         }
          }
         if(hR_Stuff.Stuff_ContractChangeBody_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractChangeBody))
         {
            idb.AddParameter("@Stuff_ContractChangeBody", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractChangeBody", hR_Stuff.Stuff_ContractChangeBody);
         }
          }
         if(hR_Stuff.Stuff_ContractCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractCompany))
         {
            idb.AddParameter("@Stuff_ContractCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractCompany", hR_Stuff.Stuff_ContractCompany);
         }
          }
         if(hR_Stuff.Stuff_ContractCompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_ContractCompanyCode))
         {
            idb.AddParameter("@Stuff_ContractCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_ContractCompanyCode", hR_Stuff.Stuff_ContractCompanyCode);
         }
          }
         if(hR_Stuff.Stuff_FileRecord_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FileRecord))
         {
            idb.AddParameter("@Stuff_FileRecord", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FileRecord", hR_Stuff.Stuff_FileRecord);
         }
          }
         if(hR_Stuff.Stuff_FileRecordRemove_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_FileRecordRemove))
         {
            idb.AddParameter("@Stuff_FileRecordRemove", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_FileRecordRemove", hR_Stuff.Stuff_FileRecordRemove);
         }
          }
         if(hR_Stuff.UpdateTime_IsChanged)
         {
         if (hR_Stuff.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", hR_Stuff.UpdateTime);
         }
          }
         if(hR_Stuff.DeleteTime_IsChanged)
         {
         if (hR_Stuff.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", hR_Stuff.DeleteTime);
         }
          }
         if(hR_Stuff.Stuff_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Bak))
         {
            idb.AddParameter("@Stuff_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Bak", hR_Stuff.Stuff_Bak);
         }
          }
         if(hR_Stuff.Stuff_Role_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_Role))
         {
            idb.AddParameter("@Stuff_Role", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_Role", hR_Stuff.Stuff_Role);
         }
          }
         if(hR_Stuff.Stuff_RoleName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Stuff.Stuff_RoleName))
         {
            idb.AddParameter("@Stuff_RoleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stuff_RoleName", hR_Stuff.Stuff_RoleName);
         }
          }
         if(hR_Stuff.CreateTime_IsChanged)
         {
         if (hR_Stuff.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_Stuff.CreateTime);
         }
          }

         idb.AddParameter("@Stuff_ID", hR_Stuff.Stuff_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除员工信息 HR_Stuff对象(即:一条记录
      /// </summary>
      public int Delete(decimal stuff_ID)
      {
         string sql = "DELETE HR_Stuff WHERE 1=1  AND Stuff_ID=@Stuff_ID ";
         idb.AddParameter("@Stuff_ID", stuff_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的员工信息 HR_Stuff对象(即:一条记录
      /// </summary>
      public HR_Stuff GetByKey(decimal stuff_ID)
      {
         HR_Stuff hR_Stuff = new HR_Stuff();
         string sql = "SELECT  Stuff_ID,Stuff_Code,Stuff_Name,Stuff_ENName,Stuff_Duty,Stuff_DutyCode,Stuff_Title,Stuff_DepCode,Stuff_DepName,Stuff_Director,Stuff_DirectorCode,Stuff_OTel,Stuff_Mobile,Stuff_Email,Stuff_Fax,Stuff_HTel,Stuff_Addr,Stuff_Start,Stuff_Left,Stuff_Stat,Stuff_Gender,Stuff_Birth,Stuff_Nation,Stuff_Province,Stuff_Salary,Stuff_Cost,Stuff_Type,Stuff_InsuraceStat,Stuff_Edu,Stat,CreateDate,Creator,Stuff_UserName,Stuff_Password,Stuff_LoginType,Stuff_ShortTel,Stuff_WorkNo,Stuff_TechLevel,Stuff_Heath,Stuff_InDate,Stuff_TurnDate,Stuff_TradeDate,Stuff_SignStartDate,Stuff_SingEndDate,Stuff_SpeicalCard,Stuff_FinishSchool,Stuff_Major,Stuff_IsResume,Stuff_IsPic,Stuff_IsIDCard,Stuff_IsHouseHod,Stuff_FinishCard,Stuff_TechnicalCard,Stuff_OperationCard,Stuff_QualificationCard,Stuff_RelaseContract,Stuff_TurnPaper,Stuff_Trasfer,Stuff_HeathPaper,Stuff_AnnoucePaper,Stuff_AssurePaper,Stuff_OnTrialContract,Stuff_ContractChangeBody,Stuff_ContractCompany,Stuff_ContractCompanyCode,Stuff_FileRecord,Stuff_FileRecordRemove,UpdateTime,DeleteTime,Stuff_Bak,Stuff_Role,Stuff_RoleName,CreateTime FROM HR_Stuff WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Stuff_ID=@Stuff_ID ";
         idb.AddParameter("@Stuff_ID", stuff_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Stuff_ID"] != DBNull.Value) hR_Stuff.Stuff_ID = Convert.ToDecimal(dr["Stuff_ID"]);
            if (dr["Stuff_Code"] != DBNull.Value) hR_Stuff.Stuff_Code = Convert.ToString(dr["Stuff_Code"]);
            if (dr["Stuff_Name"] != DBNull.Value) hR_Stuff.Stuff_Name = Convert.ToString(dr["Stuff_Name"]);
            if (dr["Stuff_ENName"] != DBNull.Value) hR_Stuff.Stuff_ENName = Convert.ToString(dr["Stuff_ENName"]);
            if (dr["Stuff_Duty"] != DBNull.Value) hR_Stuff.Stuff_Duty = Convert.ToString(dr["Stuff_Duty"]);
            if (dr["Stuff_DutyCode"] != DBNull.Value) hR_Stuff.Stuff_DutyCode = Convert.ToString(dr["Stuff_DutyCode"]);
            if (dr["Stuff_Title"] != DBNull.Value) hR_Stuff.Stuff_Title = Convert.ToString(dr["Stuff_Title"]);
            if (dr["Stuff_DepCode"] != DBNull.Value) hR_Stuff.Stuff_DepCode = Convert.ToString(dr["Stuff_DepCode"]);
            if (dr["Stuff_DepName"] != DBNull.Value) hR_Stuff.Stuff_DepName = Convert.ToString(dr["Stuff_DepName"]);
            if (dr["Stuff_Director"] != DBNull.Value) hR_Stuff.Stuff_Director = Convert.ToString(dr["Stuff_Director"]);
            if (dr["Stuff_DirectorCode"] != DBNull.Value) hR_Stuff.Stuff_DirectorCode = Convert.ToString(dr["Stuff_DirectorCode"]);
            if (dr["Stuff_OTel"] != DBNull.Value) hR_Stuff.Stuff_OTel = Convert.ToString(dr["Stuff_OTel"]);
            if (dr["Stuff_Mobile"] != DBNull.Value) hR_Stuff.Stuff_Mobile = Convert.ToString(dr["Stuff_Mobile"]);
            if (dr["Stuff_Email"] != DBNull.Value) hR_Stuff.Stuff_Email = Convert.ToString(dr["Stuff_Email"]);
            if (dr["Stuff_Fax"] != DBNull.Value) hR_Stuff.Stuff_Fax = Convert.ToString(dr["Stuff_Fax"]);
            if (dr["Stuff_HTel"] != DBNull.Value) hR_Stuff.Stuff_HTel = Convert.ToString(dr["Stuff_HTel"]);
            if (dr["Stuff_Addr"] != DBNull.Value) hR_Stuff.Stuff_Addr = Convert.ToString(dr["Stuff_Addr"]);
            if (dr["Stuff_Start"] != DBNull.Value) hR_Stuff.Stuff_Start = Convert.ToString(dr["Stuff_Start"]);
            if (dr["Stuff_Left"] != DBNull.Value) hR_Stuff.Stuff_Left = Convert.ToString(dr["Stuff_Left"]);
            if (dr["Stuff_Stat"] != DBNull.Value) hR_Stuff.Stuff_Stat = Convert.ToString(dr["Stuff_Stat"]);
            if (dr["Stuff_Gender"] != DBNull.Value) hR_Stuff.Stuff_Gender = Convert.ToString(dr["Stuff_Gender"]);
            if (dr["Stuff_Birth"] != DBNull.Value) hR_Stuff.Stuff_Birth = Convert.ToString(dr["Stuff_Birth"]);
            if (dr["Stuff_Nation"] != DBNull.Value) hR_Stuff.Stuff_Nation = Convert.ToString(dr["Stuff_Nation"]);
            if (dr["Stuff_Province"] != DBNull.Value) hR_Stuff.Stuff_Province = Convert.ToString(dr["Stuff_Province"]);
            if (dr["Stuff_Salary"] != DBNull.Value) hR_Stuff.Stuff_Salary = Convert.ToInt64(dr["Stuff_Salary"]);
            if (dr["Stuff_Cost"] != DBNull.Value) hR_Stuff.Stuff_Cost = Convert.ToString(dr["Stuff_Cost"]);
            if (dr["Stuff_Type"] != DBNull.Value) hR_Stuff.Stuff_Type = Convert.ToString(dr["Stuff_Type"]);
            if (dr["Stuff_InsuraceStat"] != DBNull.Value) hR_Stuff.Stuff_InsuraceStat = Convert.ToString(dr["Stuff_InsuraceStat"]);
            if (dr["Stuff_Edu"] != DBNull.Value) hR_Stuff.Stuff_Edu = Convert.ToString(dr["Stuff_Edu"]);
            if (dr["Stat"] != DBNull.Value) hR_Stuff.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Stuff.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["Creator"] != DBNull.Value) hR_Stuff.Creator = Convert.ToString(dr["Creator"]);
            if (dr["Stuff_UserName"] != DBNull.Value) hR_Stuff.Stuff_UserName = Convert.ToString(dr["Stuff_UserName"]);
            if (dr["Stuff_Password"] != DBNull.Value) hR_Stuff.Stuff_Password = Convert.ToString(dr["Stuff_Password"]);
            if (dr["Stuff_LoginType"] != DBNull.Value) hR_Stuff.Stuff_LoginType = Convert.ToString(dr["Stuff_LoginType"]);
            if (dr["Stuff_ShortTel"] != DBNull.Value) hR_Stuff.Stuff_ShortTel = Convert.ToString(dr["Stuff_ShortTel"]);
            if (dr["Stuff_WorkNo"] != DBNull.Value) hR_Stuff.Stuff_WorkNo = Convert.ToString(dr["Stuff_WorkNo"]);
            if (dr["Stuff_TechLevel"] != DBNull.Value) hR_Stuff.Stuff_TechLevel = Convert.ToString(dr["Stuff_TechLevel"]);
            if (dr["Stuff_Heath"] != DBNull.Value) hR_Stuff.Stuff_Heath = Convert.ToString(dr["Stuff_Heath"]);
            if (dr["Stuff_InDate"] != DBNull.Value) hR_Stuff.Stuff_InDate = Convert.ToString(dr["Stuff_InDate"]);
            if (dr["Stuff_TurnDate"] != DBNull.Value) hR_Stuff.Stuff_TurnDate = Convert.ToString(dr["Stuff_TurnDate"]);
            if (dr["Stuff_TradeDate"] != DBNull.Value) hR_Stuff.Stuff_TradeDate = Convert.ToString(dr["Stuff_TradeDate"]);
            if (dr["Stuff_SignStartDate"] != DBNull.Value) hR_Stuff.Stuff_SignStartDate = Convert.ToString(dr["Stuff_SignStartDate"]);
            if (dr["Stuff_SingEndDate"] != DBNull.Value) hR_Stuff.Stuff_SingEndDate = Convert.ToString(dr["Stuff_SingEndDate"]);
            if (dr["Stuff_SpeicalCard"] != DBNull.Value) hR_Stuff.Stuff_SpeicalCard = Convert.ToString(dr["Stuff_SpeicalCard"]);
            if (dr["Stuff_FinishSchool"] != DBNull.Value) hR_Stuff.Stuff_FinishSchool = Convert.ToString(dr["Stuff_FinishSchool"]);
            if (dr["Stuff_Major"] != DBNull.Value) hR_Stuff.Stuff_Major = Convert.ToString(dr["Stuff_Major"]);
            if (dr["Stuff_IsResume"] != DBNull.Value) hR_Stuff.Stuff_IsResume = Convert.ToString(dr["Stuff_IsResume"]);
            if (dr["Stuff_IsPic"] != DBNull.Value) hR_Stuff.Stuff_IsPic = Convert.ToString(dr["Stuff_IsPic"]);
            if (dr["Stuff_IsIDCard"] != DBNull.Value) hR_Stuff.Stuff_IsIDCard = Convert.ToString(dr["Stuff_IsIDCard"]);
            if (dr["Stuff_IsHouseHod"] != DBNull.Value) hR_Stuff.Stuff_IsHouseHod = Convert.ToString(dr["Stuff_IsHouseHod"]);
            if (dr["Stuff_FinishCard"] != DBNull.Value) hR_Stuff.Stuff_FinishCard = Convert.ToString(dr["Stuff_FinishCard"]);
            if (dr["Stuff_TechnicalCard"] != DBNull.Value) hR_Stuff.Stuff_TechnicalCard = Convert.ToString(dr["Stuff_TechnicalCard"]);
            if (dr["Stuff_OperationCard"] != DBNull.Value) hR_Stuff.Stuff_OperationCard = Convert.ToString(dr["Stuff_OperationCard"]);
            if (dr["Stuff_QualificationCard"] != DBNull.Value) hR_Stuff.Stuff_QualificationCard = Convert.ToString(dr["Stuff_QualificationCard"]);
            if (dr["Stuff_RelaseContract"] != DBNull.Value) hR_Stuff.Stuff_RelaseContract = Convert.ToString(dr["Stuff_RelaseContract"]);
            if (dr["Stuff_TurnPaper"] != DBNull.Value) hR_Stuff.Stuff_TurnPaper = Convert.ToString(dr["Stuff_TurnPaper"]);
            if (dr["Stuff_Trasfer"] != DBNull.Value) hR_Stuff.Stuff_Trasfer = Convert.ToString(dr["Stuff_Trasfer"]);
            if (dr["Stuff_HeathPaper"] != DBNull.Value) hR_Stuff.Stuff_HeathPaper = Convert.ToString(dr["Stuff_HeathPaper"]);
            if (dr["Stuff_AnnoucePaper"] != DBNull.Value) hR_Stuff.Stuff_AnnoucePaper = Convert.ToString(dr["Stuff_AnnoucePaper"]);
            if (dr["Stuff_AssurePaper"] != DBNull.Value) hR_Stuff.Stuff_AssurePaper = Convert.ToString(dr["Stuff_AssurePaper"]);
            if (dr["Stuff_OnTrialContract"] != DBNull.Value) hR_Stuff.Stuff_OnTrialContract = Convert.ToString(dr["Stuff_OnTrialContract"]);
            if (dr["Stuff_ContractChangeBody"] != DBNull.Value) hR_Stuff.Stuff_ContractChangeBody = Convert.ToString(dr["Stuff_ContractChangeBody"]);
            if (dr["Stuff_ContractCompany"] != DBNull.Value) hR_Stuff.Stuff_ContractCompany = Convert.ToString(dr["Stuff_ContractCompany"]);
            if (dr["Stuff_ContractCompanyCode"] != DBNull.Value) hR_Stuff.Stuff_ContractCompanyCode = Convert.ToString(dr["Stuff_ContractCompanyCode"]);
            if (dr["Stuff_FileRecord"] != DBNull.Value) hR_Stuff.Stuff_FileRecord = Convert.ToString(dr["Stuff_FileRecord"]);
            if (dr["Stuff_FileRecordRemove"] != DBNull.Value) hR_Stuff.Stuff_FileRecordRemove = Convert.ToString(dr["Stuff_FileRecordRemove"]);
            if (dr["UpdateTime"] != DBNull.Value) hR_Stuff.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) hR_Stuff.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stuff_Bak"] != DBNull.Value) hR_Stuff.Stuff_Bak = Convert.ToString(dr["Stuff_Bak"]);
            if (dr["Stuff_Role"] != DBNull.Value) hR_Stuff.Stuff_Role = Convert.ToString(dr["Stuff_Role"]);
            if (dr["Stuff_RoleName"] != DBNull.Value) hR_Stuff.Stuff_RoleName = Convert.ToString(dr["Stuff_RoleName"]);
            if (dr["CreateTime"] != DBNull.Value) hR_Stuff.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_Stuff;
      }
      /// <summary>
      /// 获取指定的员工信息 HR_Stuff对象集合
      /// </summary>
      public List<HR_Stuff> GetListByWhere(string strCondition)
      {
         List<HR_Stuff> ret = new List<HR_Stuff>();
         string sql = "SELECT  Stuff_ID,Stuff_Code,Stuff_Name,Stuff_ENName,Stuff_Duty,Stuff_DutyCode,Stuff_Title,Stuff_DepCode,Stuff_DepName,Stuff_Director,Stuff_DirectorCode,Stuff_OTel,Stuff_Mobile,Stuff_Email,Stuff_Fax,Stuff_HTel,Stuff_Addr,Stuff_Start,Stuff_Left,Stuff_Stat,Stuff_Gender,Stuff_Birth,Stuff_Nation,Stuff_Province,Stuff_Salary,Stuff_Cost,Stuff_Type,Stuff_InsuraceStat,Stuff_Edu,Stat,CreateDate,Creator,Stuff_UserName,Stuff_Password,Stuff_LoginType,Stuff_ShortTel,Stuff_WorkNo,Stuff_TechLevel,Stuff_Heath,Stuff_InDate,Stuff_TurnDate,Stuff_TradeDate,Stuff_SignStartDate,Stuff_SingEndDate,Stuff_SpeicalCard,Stuff_FinishSchool,Stuff_Major,Stuff_IsResume,Stuff_IsPic,Stuff_IsIDCard,Stuff_IsHouseHod,Stuff_FinishCard,Stuff_TechnicalCard,Stuff_OperationCard,Stuff_QualificationCard,Stuff_RelaseContract,Stuff_TurnPaper,Stuff_Trasfer,Stuff_HeathPaper,Stuff_AnnoucePaper,Stuff_AssurePaper,Stuff_OnTrialContract,Stuff_ContractChangeBody,Stuff_ContractCompany,Stuff_ContractCompanyCode,Stuff_FileRecord,Stuff_FileRecordRemove,UpdateTime,DeleteTime,Stuff_Bak,Stuff_Role,Stuff_RoleName,CreateTime FROM HR_Stuff WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Stuff_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_Stuff hR_Stuff = new HR_Stuff();
            if (dr["Stuff_ID"] != DBNull.Value) hR_Stuff.Stuff_ID = Convert.ToDecimal(dr["Stuff_ID"]);
            if (dr["Stuff_Code"] != DBNull.Value) hR_Stuff.Stuff_Code = Convert.ToString(dr["Stuff_Code"]);
            if (dr["Stuff_Name"] != DBNull.Value) hR_Stuff.Stuff_Name = Convert.ToString(dr["Stuff_Name"]);
            if (dr["Stuff_ENName"] != DBNull.Value) hR_Stuff.Stuff_ENName = Convert.ToString(dr["Stuff_ENName"]);
            if (dr["Stuff_Duty"] != DBNull.Value) hR_Stuff.Stuff_Duty = Convert.ToString(dr["Stuff_Duty"]);
            if (dr["Stuff_DutyCode"] != DBNull.Value) hR_Stuff.Stuff_DutyCode = Convert.ToString(dr["Stuff_DutyCode"]);
            if (dr["Stuff_Title"] != DBNull.Value) hR_Stuff.Stuff_Title = Convert.ToString(dr["Stuff_Title"]);
            if (dr["Stuff_DepCode"] != DBNull.Value) hR_Stuff.Stuff_DepCode = Convert.ToString(dr["Stuff_DepCode"]);
            if (dr["Stuff_DepName"] != DBNull.Value) hR_Stuff.Stuff_DepName = Convert.ToString(dr["Stuff_DepName"]);
            if (dr["Stuff_Director"] != DBNull.Value) hR_Stuff.Stuff_Director = Convert.ToString(dr["Stuff_Director"]);
            if (dr["Stuff_DirectorCode"] != DBNull.Value) hR_Stuff.Stuff_DirectorCode = Convert.ToString(dr["Stuff_DirectorCode"]);
            if (dr["Stuff_OTel"] != DBNull.Value) hR_Stuff.Stuff_OTel = Convert.ToString(dr["Stuff_OTel"]);
            if (dr["Stuff_Mobile"] != DBNull.Value) hR_Stuff.Stuff_Mobile = Convert.ToString(dr["Stuff_Mobile"]);
            if (dr["Stuff_Email"] != DBNull.Value) hR_Stuff.Stuff_Email = Convert.ToString(dr["Stuff_Email"]);
            if (dr["Stuff_Fax"] != DBNull.Value) hR_Stuff.Stuff_Fax = Convert.ToString(dr["Stuff_Fax"]);
            if (dr["Stuff_HTel"] != DBNull.Value) hR_Stuff.Stuff_HTel = Convert.ToString(dr["Stuff_HTel"]);
            if (dr["Stuff_Addr"] != DBNull.Value) hR_Stuff.Stuff_Addr = Convert.ToString(dr["Stuff_Addr"]);
            if (dr["Stuff_Start"] != DBNull.Value) hR_Stuff.Stuff_Start = Convert.ToString(dr["Stuff_Start"]);
            if (dr["Stuff_Left"] != DBNull.Value) hR_Stuff.Stuff_Left = Convert.ToString(dr["Stuff_Left"]);
            if (dr["Stuff_Stat"] != DBNull.Value) hR_Stuff.Stuff_Stat = Convert.ToString(dr["Stuff_Stat"]);
            if (dr["Stuff_Gender"] != DBNull.Value) hR_Stuff.Stuff_Gender = Convert.ToString(dr["Stuff_Gender"]);
            if (dr["Stuff_Birth"] != DBNull.Value) hR_Stuff.Stuff_Birth = Convert.ToString(dr["Stuff_Birth"]);
            if (dr["Stuff_Nation"] != DBNull.Value) hR_Stuff.Stuff_Nation = Convert.ToString(dr["Stuff_Nation"]);
            if (dr["Stuff_Province"] != DBNull.Value) hR_Stuff.Stuff_Province = Convert.ToString(dr["Stuff_Province"]);
            if (dr["Stuff_Salary"] != DBNull.Value) hR_Stuff.Stuff_Salary = Convert.ToInt64(dr["Stuff_Salary"]);
            if (dr["Stuff_Cost"] != DBNull.Value) hR_Stuff.Stuff_Cost = Convert.ToString(dr["Stuff_Cost"]);
            if (dr["Stuff_Type"] != DBNull.Value) hR_Stuff.Stuff_Type = Convert.ToString(dr["Stuff_Type"]);
            if (dr["Stuff_InsuraceStat"] != DBNull.Value) hR_Stuff.Stuff_InsuraceStat = Convert.ToString(dr["Stuff_InsuraceStat"]);
            if (dr["Stuff_Edu"] != DBNull.Value) hR_Stuff.Stuff_Edu = Convert.ToString(dr["Stuff_Edu"]);
            if (dr["Stat"] != DBNull.Value) hR_Stuff.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Stuff.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["Creator"] != DBNull.Value) hR_Stuff.Creator = Convert.ToString(dr["Creator"]);
            if (dr["Stuff_UserName"] != DBNull.Value) hR_Stuff.Stuff_UserName = Convert.ToString(dr["Stuff_UserName"]);
            if (dr["Stuff_Password"] != DBNull.Value) hR_Stuff.Stuff_Password = Convert.ToString(dr["Stuff_Password"]);
            if (dr["Stuff_LoginType"] != DBNull.Value) hR_Stuff.Stuff_LoginType = Convert.ToString(dr["Stuff_LoginType"]);
            if (dr["Stuff_ShortTel"] != DBNull.Value) hR_Stuff.Stuff_ShortTel = Convert.ToString(dr["Stuff_ShortTel"]);
            if (dr["Stuff_WorkNo"] != DBNull.Value) hR_Stuff.Stuff_WorkNo = Convert.ToString(dr["Stuff_WorkNo"]);
            if (dr["Stuff_TechLevel"] != DBNull.Value) hR_Stuff.Stuff_TechLevel = Convert.ToString(dr["Stuff_TechLevel"]);
            if (dr["Stuff_Heath"] != DBNull.Value) hR_Stuff.Stuff_Heath = Convert.ToString(dr["Stuff_Heath"]);
            if (dr["Stuff_InDate"] != DBNull.Value) hR_Stuff.Stuff_InDate = Convert.ToString(dr["Stuff_InDate"]);
            if (dr["Stuff_TurnDate"] != DBNull.Value) hR_Stuff.Stuff_TurnDate = Convert.ToString(dr["Stuff_TurnDate"]);
            if (dr["Stuff_TradeDate"] != DBNull.Value) hR_Stuff.Stuff_TradeDate = Convert.ToString(dr["Stuff_TradeDate"]);
            if (dr["Stuff_SignStartDate"] != DBNull.Value) hR_Stuff.Stuff_SignStartDate = Convert.ToString(dr["Stuff_SignStartDate"]);
            if (dr["Stuff_SingEndDate"] != DBNull.Value) hR_Stuff.Stuff_SingEndDate = Convert.ToString(dr["Stuff_SingEndDate"]);
            if (dr["Stuff_SpeicalCard"] != DBNull.Value) hR_Stuff.Stuff_SpeicalCard = Convert.ToString(dr["Stuff_SpeicalCard"]);
            if (dr["Stuff_FinishSchool"] != DBNull.Value) hR_Stuff.Stuff_FinishSchool = Convert.ToString(dr["Stuff_FinishSchool"]);
            if (dr["Stuff_Major"] != DBNull.Value) hR_Stuff.Stuff_Major = Convert.ToString(dr["Stuff_Major"]);
            if (dr["Stuff_IsResume"] != DBNull.Value) hR_Stuff.Stuff_IsResume = Convert.ToString(dr["Stuff_IsResume"]);
            if (dr["Stuff_IsPic"] != DBNull.Value) hR_Stuff.Stuff_IsPic = Convert.ToString(dr["Stuff_IsPic"]);
            if (dr["Stuff_IsIDCard"] != DBNull.Value) hR_Stuff.Stuff_IsIDCard = Convert.ToString(dr["Stuff_IsIDCard"]);
            if (dr["Stuff_IsHouseHod"] != DBNull.Value) hR_Stuff.Stuff_IsHouseHod = Convert.ToString(dr["Stuff_IsHouseHod"]);
            if (dr["Stuff_FinishCard"] != DBNull.Value) hR_Stuff.Stuff_FinishCard = Convert.ToString(dr["Stuff_FinishCard"]);
            if (dr["Stuff_TechnicalCard"] != DBNull.Value) hR_Stuff.Stuff_TechnicalCard = Convert.ToString(dr["Stuff_TechnicalCard"]);
            if (dr["Stuff_OperationCard"] != DBNull.Value) hR_Stuff.Stuff_OperationCard = Convert.ToString(dr["Stuff_OperationCard"]);
            if (dr["Stuff_QualificationCard"] != DBNull.Value) hR_Stuff.Stuff_QualificationCard = Convert.ToString(dr["Stuff_QualificationCard"]);
            if (dr["Stuff_RelaseContract"] != DBNull.Value) hR_Stuff.Stuff_RelaseContract = Convert.ToString(dr["Stuff_RelaseContract"]);
            if (dr["Stuff_TurnPaper"] != DBNull.Value) hR_Stuff.Stuff_TurnPaper = Convert.ToString(dr["Stuff_TurnPaper"]);
            if (dr["Stuff_Trasfer"] != DBNull.Value) hR_Stuff.Stuff_Trasfer = Convert.ToString(dr["Stuff_Trasfer"]);
            if (dr["Stuff_HeathPaper"] != DBNull.Value) hR_Stuff.Stuff_HeathPaper = Convert.ToString(dr["Stuff_HeathPaper"]);
            if (dr["Stuff_AnnoucePaper"] != DBNull.Value) hR_Stuff.Stuff_AnnoucePaper = Convert.ToString(dr["Stuff_AnnoucePaper"]);
            if (dr["Stuff_AssurePaper"] != DBNull.Value) hR_Stuff.Stuff_AssurePaper = Convert.ToString(dr["Stuff_AssurePaper"]);
            if (dr["Stuff_OnTrialContract"] != DBNull.Value) hR_Stuff.Stuff_OnTrialContract = Convert.ToString(dr["Stuff_OnTrialContract"]);
            if (dr["Stuff_ContractChangeBody"] != DBNull.Value) hR_Stuff.Stuff_ContractChangeBody = Convert.ToString(dr["Stuff_ContractChangeBody"]);
            if (dr["Stuff_ContractCompany"] != DBNull.Value) hR_Stuff.Stuff_ContractCompany = Convert.ToString(dr["Stuff_ContractCompany"]);
            if (dr["Stuff_ContractCompanyCode"] != DBNull.Value) hR_Stuff.Stuff_ContractCompanyCode = Convert.ToString(dr["Stuff_ContractCompanyCode"]);
            if (dr["Stuff_FileRecord"] != DBNull.Value) hR_Stuff.Stuff_FileRecord = Convert.ToString(dr["Stuff_FileRecord"]);
            if (dr["Stuff_FileRecordRemove"] != DBNull.Value) hR_Stuff.Stuff_FileRecordRemove = Convert.ToString(dr["Stuff_FileRecordRemove"]);
            if (dr["UpdateTime"] != DBNull.Value) hR_Stuff.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) hR_Stuff.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stuff_Bak"] != DBNull.Value) hR_Stuff.Stuff_Bak = Convert.ToString(dr["Stuff_Bak"]);
            if (dr["Stuff_Role"] != DBNull.Value) hR_Stuff.Stuff_Role = Convert.ToString(dr["Stuff_Role"]);
            if (dr["Stuff_RoleName"] != DBNull.Value) hR_Stuff.Stuff_RoleName = Convert.ToString(dr["Stuff_RoleName"]);
            if (dr["CreateTime"] != DBNull.Value) hR_Stuff.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(hR_Stuff);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的员工信息 HR_Stuff对象(即:一条记录
      /// </summary>
      public List<HR_Stuff> GetAll()
      {
         List<HR_Stuff> ret = new List<HR_Stuff>();
         string sql = "SELECT  Stuff_ID,Stuff_Code,Stuff_Name,Stuff_ENName,Stuff_Duty,Stuff_DutyCode,Stuff_Title,Stuff_DepCode,Stuff_DepName,Stuff_Director,Stuff_DirectorCode,Stuff_OTel,Stuff_Mobile,Stuff_Email,Stuff_Fax,Stuff_HTel,Stuff_Addr,Stuff_Start,Stuff_Left,Stuff_Stat,Stuff_Gender,Stuff_Birth,Stuff_Nation,Stuff_Province,Stuff_Salary,Stuff_Cost,Stuff_Type,Stuff_InsuraceStat,Stuff_Edu,Stat,CreateDate,Creator,Stuff_UserName,Stuff_Password,Stuff_LoginType,Stuff_ShortTel,Stuff_WorkNo,Stuff_TechLevel,Stuff_Heath,Stuff_InDate,Stuff_TurnDate,Stuff_TradeDate,Stuff_SignStartDate,Stuff_SingEndDate,Stuff_SpeicalCard,Stuff_FinishSchool,Stuff_Major,Stuff_IsResume,Stuff_IsPic,Stuff_IsIDCard,Stuff_IsHouseHod,Stuff_FinishCard,Stuff_TechnicalCard,Stuff_OperationCard,Stuff_QualificationCard,Stuff_RelaseContract,Stuff_TurnPaper,Stuff_Trasfer,Stuff_HeathPaper,Stuff_AnnoucePaper,Stuff_AssurePaper,Stuff_OnTrialContract,Stuff_ContractChangeBody,Stuff_ContractCompany,Stuff_ContractCompanyCode,Stuff_FileRecord,Stuff_FileRecordRemove,UpdateTime,DeleteTime,Stuff_Bak,Stuff_Role,Stuff_RoleName,CreateTime FROM HR_Stuff where 1=1 AND ((Stat is null) or (Stat=0) ) order by Stuff_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_Stuff hR_Stuff = new HR_Stuff();
            if (dr["Stuff_ID"] != DBNull.Value) hR_Stuff.Stuff_ID = Convert.ToDecimal(dr["Stuff_ID"]);
            if (dr["Stuff_Code"] != DBNull.Value) hR_Stuff.Stuff_Code = Convert.ToString(dr["Stuff_Code"]);
            if (dr["Stuff_Name"] != DBNull.Value) hR_Stuff.Stuff_Name = Convert.ToString(dr["Stuff_Name"]);
            if (dr["Stuff_ENName"] != DBNull.Value) hR_Stuff.Stuff_ENName = Convert.ToString(dr["Stuff_ENName"]);
            if (dr["Stuff_Duty"] != DBNull.Value) hR_Stuff.Stuff_Duty = Convert.ToString(dr["Stuff_Duty"]);
            if (dr["Stuff_DutyCode"] != DBNull.Value) hR_Stuff.Stuff_DutyCode = Convert.ToString(dr["Stuff_DutyCode"]);
            if (dr["Stuff_Title"] != DBNull.Value) hR_Stuff.Stuff_Title = Convert.ToString(dr["Stuff_Title"]);
            if (dr["Stuff_DepCode"] != DBNull.Value) hR_Stuff.Stuff_DepCode = Convert.ToString(dr["Stuff_DepCode"]);
            if (dr["Stuff_DepName"] != DBNull.Value) hR_Stuff.Stuff_DepName = Convert.ToString(dr["Stuff_DepName"]);
            if (dr["Stuff_Director"] != DBNull.Value) hR_Stuff.Stuff_Director = Convert.ToString(dr["Stuff_Director"]);
            if (dr["Stuff_DirectorCode"] != DBNull.Value) hR_Stuff.Stuff_DirectorCode = Convert.ToString(dr["Stuff_DirectorCode"]);
            if (dr["Stuff_OTel"] != DBNull.Value) hR_Stuff.Stuff_OTel = Convert.ToString(dr["Stuff_OTel"]);
            if (dr["Stuff_Mobile"] != DBNull.Value) hR_Stuff.Stuff_Mobile = Convert.ToString(dr["Stuff_Mobile"]);
            if (dr["Stuff_Email"] != DBNull.Value) hR_Stuff.Stuff_Email = Convert.ToString(dr["Stuff_Email"]);
            if (dr["Stuff_Fax"] != DBNull.Value) hR_Stuff.Stuff_Fax = Convert.ToString(dr["Stuff_Fax"]);
            if (dr["Stuff_HTel"] != DBNull.Value) hR_Stuff.Stuff_HTel = Convert.ToString(dr["Stuff_HTel"]);
            if (dr["Stuff_Addr"] != DBNull.Value) hR_Stuff.Stuff_Addr = Convert.ToString(dr["Stuff_Addr"]);
            if (dr["Stuff_Start"] != DBNull.Value) hR_Stuff.Stuff_Start = Convert.ToString(dr["Stuff_Start"]);
            if (dr["Stuff_Left"] != DBNull.Value) hR_Stuff.Stuff_Left = Convert.ToString(dr["Stuff_Left"]);
            if (dr["Stuff_Stat"] != DBNull.Value) hR_Stuff.Stuff_Stat = Convert.ToString(dr["Stuff_Stat"]);
            if (dr["Stuff_Gender"] != DBNull.Value) hR_Stuff.Stuff_Gender = Convert.ToString(dr["Stuff_Gender"]);
            if (dr["Stuff_Birth"] != DBNull.Value) hR_Stuff.Stuff_Birth = Convert.ToString(dr["Stuff_Birth"]);
            if (dr["Stuff_Nation"] != DBNull.Value) hR_Stuff.Stuff_Nation = Convert.ToString(dr["Stuff_Nation"]);
            if (dr["Stuff_Province"] != DBNull.Value) hR_Stuff.Stuff_Province = Convert.ToString(dr["Stuff_Province"]);
            if (dr["Stuff_Salary"] != DBNull.Value) hR_Stuff.Stuff_Salary = Convert.ToInt64(dr["Stuff_Salary"]);
            if (dr["Stuff_Cost"] != DBNull.Value) hR_Stuff.Stuff_Cost = Convert.ToString(dr["Stuff_Cost"]);
            if (dr["Stuff_Type"] != DBNull.Value) hR_Stuff.Stuff_Type = Convert.ToString(dr["Stuff_Type"]);
            if (dr["Stuff_InsuraceStat"] != DBNull.Value) hR_Stuff.Stuff_InsuraceStat = Convert.ToString(dr["Stuff_InsuraceStat"]);
            if (dr["Stuff_Edu"] != DBNull.Value) hR_Stuff.Stuff_Edu = Convert.ToString(dr["Stuff_Edu"]);
            if (dr["Stat"] != DBNull.Value) hR_Stuff.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Stuff.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["Creator"] != DBNull.Value) hR_Stuff.Creator = Convert.ToString(dr["Creator"]);
            if (dr["Stuff_UserName"] != DBNull.Value) hR_Stuff.Stuff_UserName = Convert.ToString(dr["Stuff_UserName"]);
            if (dr["Stuff_Password"] != DBNull.Value) hR_Stuff.Stuff_Password = Convert.ToString(dr["Stuff_Password"]);
            if (dr["Stuff_LoginType"] != DBNull.Value) hR_Stuff.Stuff_LoginType = Convert.ToString(dr["Stuff_LoginType"]);
            if (dr["Stuff_ShortTel"] != DBNull.Value) hR_Stuff.Stuff_ShortTel = Convert.ToString(dr["Stuff_ShortTel"]);
            if (dr["Stuff_WorkNo"] != DBNull.Value) hR_Stuff.Stuff_WorkNo = Convert.ToString(dr["Stuff_WorkNo"]);
            if (dr["Stuff_TechLevel"] != DBNull.Value) hR_Stuff.Stuff_TechLevel = Convert.ToString(dr["Stuff_TechLevel"]);
            if (dr["Stuff_Heath"] != DBNull.Value) hR_Stuff.Stuff_Heath = Convert.ToString(dr["Stuff_Heath"]);
            if (dr["Stuff_InDate"] != DBNull.Value) hR_Stuff.Stuff_InDate = Convert.ToString(dr["Stuff_InDate"]);
            if (dr["Stuff_TurnDate"] != DBNull.Value) hR_Stuff.Stuff_TurnDate = Convert.ToString(dr["Stuff_TurnDate"]);
            if (dr["Stuff_TradeDate"] != DBNull.Value) hR_Stuff.Stuff_TradeDate = Convert.ToString(dr["Stuff_TradeDate"]);
            if (dr["Stuff_SignStartDate"] != DBNull.Value) hR_Stuff.Stuff_SignStartDate = Convert.ToString(dr["Stuff_SignStartDate"]);
            if (dr["Stuff_SingEndDate"] != DBNull.Value) hR_Stuff.Stuff_SingEndDate = Convert.ToString(dr["Stuff_SingEndDate"]);
            if (dr["Stuff_SpeicalCard"] != DBNull.Value) hR_Stuff.Stuff_SpeicalCard = Convert.ToString(dr["Stuff_SpeicalCard"]);
            if (dr["Stuff_FinishSchool"] != DBNull.Value) hR_Stuff.Stuff_FinishSchool = Convert.ToString(dr["Stuff_FinishSchool"]);
            if (dr["Stuff_Major"] != DBNull.Value) hR_Stuff.Stuff_Major = Convert.ToString(dr["Stuff_Major"]);
            if (dr["Stuff_IsResume"] != DBNull.Value) hR_Stuff.Stuff_IsResume = Convert.ToString(dr["Stuff_IsResume"]);
            if (dr["Stuff_IsPic"] != DBNull.Value) hR_Stuff.Stuff_IsPic = Convert.ToString(dr["Stuff_IsPic"]);
            if (dr["Stuff_IsIDCard"] != DBNull.Value) hR_Stuff.Stuff_IsIDCard = Convert.ToString(dr["Stuff_IsIDCard"]);
            if (dr["Stuff_IsHouseHod"] != DBNull.Value) hR_Stuff.Stuff_IsHouseHod = Convert.ToString(dr["Stuff_IsHouseHod"]);
            if (dr["Stuff_FinishCard"] != DBNull.Value) hR_Stuff.Stuff_FinishCard = Convert.ToString(dr["Stuff_FinishCard"]);
            if (dr["Stuff_TechnicalCard"] != DBNull.Value) hR_Stuff.Stuff_TechnicalCard = Convert.ToString(dr["Stuff_TechnicalCard"]);
            if (dr["Stuff_OperationCard"] != DBNull.Value) hR_Stuff.Stuff_OperationCard = Convert.ToString(dr["Stuff_OperationCard"]);
            if (dr["Stuff_QualificationCard"] != DBNull.Value) hR_Stuff.Stuff_QualificationCard = Convert.ToString(dr["Stuff_QualificationCard"]);
            if (dr["Stuff_RelaseContract"] != DBNull.Value) hR_Stuff.Stuff_RelaseContract = Convert.ToString(dr["Stuff_RelaseContract"]);
            if (dr["Stuff_TurnPaper"] != DBNull.Value) hR_Stuff.Stuff_TurnPaper = Convert.ToString(dr["Stuff_TurnPaper"]);
            if (dr["Stuff_Trasfer"] != DBNull.Value) hR_Stuff.Stuff_Trasfer = Convert.ToString(dr["Stuff_Trasfer"]);
            if (dr["Stuff_HeathPaper"] != DBNull.Value) hR_Stuff.Stuff_HeathPaper = Convert.ToString(dr["Stuff_HeathPaper"]);
            if (dr["Stuff_AnnoucePaper"] != DBNull.Value) hR_Stuff.Stuff_AnnoucePaper = Convert.ToString(dr["Stuff_AnnoucePaper"]);
            if (dr["Stuff_AssurePaper"] != DBNull.Value) hR_Stuff.Stuff_AssurePaper = Convert.ToString(dr["Stuff_AssurePaper"]);
            if (dr["Stuff_OnTrialContract"] != DBNull.Value) hR_Stuff.Stuff_OnTrialContract = Convert.ToString(dr["Stuff_OnTrialContract"]);
            if (dr["Stuff_ContractChangeBody"] != DBNull.Value) hR_Stuff.Stuff_ContractChangeBody = Convert.ToString(dr["Stuff_ContractChangeBody"]);
            if (dr["Stuff_ContractCompany"] != DBNull.Value) hR_Stuff.Stuff_ContractCompany = Convert.ToString(dr["Stuff_ContractCompany"]);
            if (dr["Stuff_ContractCompanyCode"] != DBNull.Value) hR_Stuff.Stuff_ContractCompanyCode = Convert.ToString(dr["Stuff_ContractCompanyCode"]);
            if (dr["Stuff_FileRecord"] != DBNull.Value) hR_Stuff.Stuff_FileRecord = Convert.ToString(dr["Stuff_FileRecord"]);
            if (dr["Stuff_FileRecordRemove"] != DBNull.Value) hR_Stuff.Stuff_FileRecordRemove = Convert.ToString(dr["Stuff_FileRecordRemove"]);
            if (dr["UpdateTime"] != DBNull.Value) hR_Stuff.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) hR_Stuff.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stuff_Bak"] != DBNull.Value) hR_Stuff.Stuff_Bak = Convert.ToString(dr["Stuff_Bak"]);
            if (dr["Stuff_Role"] != DBNull.Value) hR_Stuff.Stuff_Role = Convert.ToString(dr["Stuff_Role"]);
            if (dr["Stuff_RoleName"] != DBNull.Value) hR_Stuff.Stuff_RoleName = Convert.ToString(dr["Stuff_RoleName"]);
            if (dr["CreateTime"] != DBNull.Value) hR_Stuff.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(hR_Stuff);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
