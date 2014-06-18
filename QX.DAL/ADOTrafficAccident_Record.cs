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
   /// 交通事故记录表
   /// </summary>
   [Serializable]
   public partial class ADOTrafficAccident_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加交通事故记录表 TrafficAccident_Record对象(即:一条记录)
      /// </summary>
      public int Add(TrafficAccident_Record trafficAccident_Record)
      {
         string sql = "INSERT INTO TrafficAccident_Record (TAR_Code,TAR_Date,TAR_Position,TAR_Pilot,TAR_VehiclesNo,TAR_Model,TAR_Abstract,TAR_ReportDate,TAR_InsuranceCompany,TAR_IsInsuranceCome,TAR_IsPoliceCome,TAR_ProceduresUpDate,TAR_CurrentPay,TAR_Reimbursementor,TAR_InsuranceMoney,TAR_ActualMoney,TAR_CompanyLoss,TAR_RepairFactory,TAR_Punish,TAR_InjureSituation,TAR_HandleResult,TAR_ResponsibleResult,TAR_AccidentResult,TAR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TAR_Code,@TAR_Date,@TAR_Position,@TAR_Pilot,@TAR_VehiclesNo,@TAR_Model,@TAR_Abstract,@TAR_ReportDate,@TAR_InsuranceCompany,@TAR_IsInsuranceCome,@TAR_IsPoliceCome,@TAR_ProceduresUpDate,@TAR_CurrentPay,@TAR_Reimbursementor,@TAR_InsuranceMoney,@TAR_ActualMoney,@TAR_CompanyLoss,@TAR_RepairFactory,@TAR_Punish,@TAR_InjureSituation,@TAR_HandleResult,@TAR_ResponsibleResult,@TAR_AccidentResult,@TAR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Code))
         {
            idb.AddParameter("@TAR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Code", trafficAccident_Record.TAR_Code);
         }
         if (trafficAccident_Record.TAR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Date", trafficAccident_Record.TAR_Date);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Position))
         {
            idb.AddParameter("@TAR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Position", trafficAccident_Record.TAR_Position);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Pilot))
         {
            idb.AddParameter("@TAR_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Pilot", trafficAccident_Record.TAR_Pilot);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_VehiclesNo))
         {
            idb.AddParameter("@TAR_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_VehiclesNo", trafficAccident_Record.TAR_VehiclesNo);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Model))
         {
            idb.AddParameter("@TAR_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Model", trafficAccident_Record.TAR_Model);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Abstract))
         {
            idb.AddParameter("@TAR_Abstract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Abstract", trafficAccident_Record.TAR_Abstract);
         }
         if (trafficAccident_Record.TAR_ReportDate == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_ReportDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ReportDate", trafficAccident_Record.TAR_ReportDate);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_InsuranceCompany))
         {
            idb.AddParameter("@TAR_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_InsuranceCompany", trafficAccident_Record.TAR_InsuranceCompany);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_IsInsuranceCome))
         {
            idb.AddParameter("@TAR_IsInsuranceCome", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_IsInsuranceCome", trafficAccident_Record.TAR_IsInsuranceCome);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_IsPoliceCome))
         {
            idb.AddParameter("@TAR_IsPoliceCome", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_IsPoliceCome", trafficAccident_Record.TAR_IsPoliceCome);
         }
         if (trafficAccident_Record.TAR_ProceduresUpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_ProceduresUpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ProceduresUpDate", trafficAccident_Record.TAR_ProceduresUpDate);
         }
         if (trafficAccident_Record.TAR_CurrentPay == 0)
         {
            idb.AddParameter("@TAR_CurrentPay", 0);
         }
         else
         {
            idb.AddParameter("@TAR_CurrentPay", trafficAccident_Record.TAR_CurrentPay);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Reimbursementor))
         {
            idb.AddParameter("@TAR_Reimbursementor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Reimbursementor", trafficAccident_Record.TAR_Reimbursementor);
         }
         if (trafficAccident_Record.TAR_InsuranceMoney == 0)
         {
            idb.AddParameter("@TAR_InsuranceMoney", 0);
         }
         else
         {
            idb.AddParameter("@TAR_InsuranceMoney", trafficAccident_Record.TAR_InsuranceMoney);
         }
         if (trafficAccident_Record.TAR_ActualMoney == 0)
         {
            idb.AddParameter("@TAR_ActualMoney", 0);
         }
         else
         {
            idb.AddParameter("@TAR_ActualMoney", trafficAccident_Record.TAR_ActualMoney);
         }
         if (trafficAccident_Record.TAR_CompanyLoss == 0)
         {
            idb.AddParameter("@TAR_CompanyLoss", 0);
         }
         else
         {
            idb.AddParameter("@TAR_CompanyLoss", trafficAccident_Record.TAR_CompanyLoss);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_RepairFactory))
         {
            idb.AddParameter("@TAR_RepairFactory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_RepairFactory", trafficAccident_Record.TAR_RepairFactory);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Punish))
         {
            idb.AddParameter("@TAR_Punish", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Punish", trafficAccident_Record.TAR_Punish);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_InjureSituation))
         {
            idb.AddParameter("@TAR_InjureSituation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_InjureSituation", trafficAccident_Record.TAR_InjureSituation);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_HandleResult))
         {
            idb.AddParameter("@TAR_HandleResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_HandleResult", trafficAccident_Record.TAR_HandleResult);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_ResponsibleResult))
         {
            idb.AddParameter("@TAR_ResponsibleResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ResponsibleResult", trafficAccident_Record.TAR_ResponsibleResult);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_AccidentResult))
         {
            idb.AddParameter("@TAR_AccidentResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_AccidentResult", trafficAccident_Record.TAR_AccidentResult);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Remark))
         {
            idb.AddParameter("@TAR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Remark", trafficAccident_Record.TAR_Remark);
         }
         if (trafficAccident_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", trafficAccident_Record.Stat);
         }
         if (trafficAccident_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", trafficAccident_Record.CreateDate);
         }
         if (trafficAccident_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", trafficAccident_Record.UpdateDate);
         }
         if (trafficAccident_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", trafficAccident_Record.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
         
      }
      /// <summary>
      /// 添加交通事故记录表 TrafficAccident_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TrafficAccident_Record trafficAccident_Record)
      {
         string sql = "INSERT INTO TrafficAccident_Record (TAR_Code,TAR_Date,TAR_Position,TAR_Pilot,TAR_VehiclesNo,TAR_Model,TAR_Abstract,TAR_ReportDate,TAR_InsuranceCompany,TAR_IsInsuranceCome,TAR_IsPoliceCome,TAR_ProceduresUpDate,TAR_CurrentPay,TAR_Reimbursementor,TAR_InsuranceMoney,TAR_ActualMoney,TAR_CompanyLoss,TAR_RepairFactory,TAR_Punish,TAR_InjureSituation,TAR_HandleResult,TAR_ResponsibleResult,TAR_AccidentResult,TAR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TAR_Code,@TAR_Date,@TAR_Position,@TAR_Pilot,@TAR_VehiclesNo,@TAR_Model,@TAR_Abstract,@TAR_ReportDate,@TAR_InsuranceCompany,@TAR_IsInsuranceCome,@TAR_IsPoliceCome,@TAR_ProceduresUpDate,@TAR_CurrentPay,@TAR_Reimbursementor,@TAR_InsuranceMoney,@TAR_ActualMoney,@TAR_CompanyLoss,@TAR_RepairFactory,@TAR_Punish,@TAR_InjureSituation,@TAR_HandleResult,@TAR_ResponsibleResult,@TAR_AccidentResult,@TAR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Code))
         {
            idb.AddParameter("@TAR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Code", trafficAccident_Record.TAR_Code);
         }
         if (trafficAccident_Record.TAR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Date", trafficAccident_Record.TAR_Date);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Position))
         {
            idb.AddParameter("@TAR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Position", trafficAccident_Record.TAR_Position);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Pilot))
         {
            idb.AddParameter("@TAR_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Pilot", trafficAccident_Record.TAR_Pilot);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_VehiclesNo))
         {
            idb.AddParameter("@TAR_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_VehiclesNo", trafficAccident_Record.TAR_VehiclesNo);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Model))
         {
            idb.AddParameter("@TAR_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Model", trafficAccident_Record.TAR_Model);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Abstract))
         {
            idb.AddParameter("@TAR_Abstract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Abstract", trafficAccident_Record.TAR_Abstract);
         }
         if (trafficAccident_Record.TAR_ReportDate == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_ReportDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ReportDate", trafficAccident_Record.TAR_ReportDate);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_InsuranceCompany))
         {
            idb.AddParameter("@TAR_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_InsuranceCompany", trafficAccident_Record.TAR_InsuranceCompany);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_IsInsuranceCome))
         {
            idb.AddParameter("@TAR_IsInsuranceCome", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_IsInsuranceCome", trafficAccident_Record.TAR_IsInsuranceCome);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_IsPoliceCome))
         {
            idb.AddParameter("@TAR_IsPoliceCome", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_IsPoliceCome", trafficAccident_Record.TAR_IsPoliceCome);
         }
         if (trafficAccident_Record.TAR_ProceduresUpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_ProceduresUpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ProceduresUpDate", trafficAccident_Record.TAR_ProceduresUpDate);
         }
         if (trafficAccident_Record.TAR_CurrentPay == 0)
         {
            idb.AddParameter("@TAR_CurrentPay", 0);
         }
         else
         {
            idb.AddParameter("@TAR_CurrentPay", trafficAccident_Record.TAR_CurrentPay);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Reimbursementor))
         {
            idb.AddParameter("@TAR_Reimbursementor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Reimbursementor", trafficAccident_Record.TAR_Reimbursementor);
         }
         if (trafficAccident_Record.TAR_InsuranceMoney == 0)
         {
            idb.AddParameter("@TAR_InsuranceMoney", 0);
         }
         else
         {
            idb.AddParameter("@TAR_InsuranceMoney", trafficAccident_Record.TAR_InsuranceMoney);
         }
         if (trafficAccident_Record.TAR_ActualMoney == 0)
         {
            idb.AddParameter("@TAR_ActualMoney", 0);
         }
         else
         {
            idb.AddParameter("@TAR_ActualMoney", trafficAccident_Record.TAR_ActualMoney);
         }
         if (trafficAccident_Record.TAR_CompanyLoss == 0)
         {
            idb.AddParameter("@TAR_CompanyLoss", 0);
         }
         else
         {
            idb.AddParameter("@TAR_CompanyLoss", trafficAccident_Record.TAR_CompanyLoss);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_RepairFactory))
         {
            idb.AddParameter("@TAR_RepairFactory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_RepairFactory", trafficAccident_Record.TAR_RepairFactory);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Punish))
         {
            idb.AddParameter("@TAR_Punish", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Punish", trafficAccident_Record.TAR_Punish);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_InjureSituation))
         {
            idb.AddParameter("@TAR_InjureSituation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_InjureSituation", trafficAccident_Record.TAR_InjureSituation);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_HandleResult))
         {
            idb.AddParameter("@TAR_HandleResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_HandleResult", trafficAccident_Record.TAR_HandleResult);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_ResponsibleResult))
         {
            idb.AddParameter("@TAR_ResponsibleResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ResponsibleResult", trafficAccident_Record.TAR_ResponsibleResult);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_AccidentResult))
         {
            idb.AddParameter("@TAR_AccidentResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_AccidentResult", trafficAccident_Record.TAR_AccidentResult);
         }
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Remark))
         {
            idb.AddParameter("@TAR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Remark", trafficAccident_Record.TAR_Remark);
         }
         if (trafficAccident_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", trafficAccident_Record.Stat);
         }
         if (trafficAccident_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", trafficAccident_Record.CreateDate);
         }
         if (trafficAccident_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", trafficAccident_Record.UpdateDate);
         }
         if (trafficAccident_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", trafficAccident_Record.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 var Return = idb.ReturnValue(sql);
                 Ex = Return.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 更新交通事故记录表 TrafficAccident_Record对象(即:一条记录
      /// </summary>
      public int Update(TrafficAccident_Record trafficAccident_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TrafficAccident_Record       SET ");
            if(trafficAccident_Record.TAR_Code_IsChanged){sbParameter.Append("TAR_Code=@TAR_Code, ");}
      if(trafficAccident_Record.TAR_Date_IsChanged){sbParameter.Append("TAR_Date=@TAR_Date, ");}
      if(trafficAccident_Record.TAR_Position_IsChanged){sbParameter.Append("TAR_Position=@TAR_Position, ");}
      if(trafficAccident_Record.TAR_Pilot_IsChanged){sbParameter.Append("TAR_Pilot=@TAR_Pilot, ");}
      if(trafficAccident_Record.TAR_VehiclesNo_IsChanged){sbParameter.Append("TAR_VehiclesNo=@TAR_VehiclesNo, ");}
      if(trafficAccident_Record.TAR_Model_IsChanged){sbParameter.Append("TAR_Model=@TAR_Model, ");}
      if(trafficAccident_Record.TAR_Abstract_IsChanged){sbParameter.Append("TAR_Abstract=@TAR_Abstract, ");}
      if(trafficAccident_Record.TAR_ReportDate_IsChanged){sbParameter.Append("TAR_ReportDate=@TAR_ReportDate, ");}
      if(trafficAccident_Record.TAR_InsuranceCompany_IsChanged){sbParameter.Append("TAR_InsuranceCompany=@TAR_InsuranceCompany, ");}
      if(trafficAccident_Record.TAR_IsInsuranceCome_IsChanged){sbParameter.Append("TAR_IsInsuranceCome=@TAR_IsInsuranceCome, ");}
      if(trafficAccident_Record.TAR_IsPoliceCome_IsChanged){sbParameter.Append("TAR_IsPoliceCome=@TAR_IsPoliceCome, ");}
      if(trafficAccident_Record.TAR_ProceduresUpDate_IsChanged){sbParameter.Append("TAR_ProceduresUpDate=@TAR_ProceduresUpDate, ");}
      if(trafficAccident_Record.TAR_CurrentPay_IsChanged){sbParameter.Append("TAR_CurrentPay=@TAR_CurrentPay, ");}
      if(trafficAccident_Record.TAR_Reimbursementor_IsChanged){sbParameter.Append("TAR_Reimbursementor=@TAR_Reimbursementor, ");}
      if(trafficAccident_Record.TAR_InsuranceMoney_IsChanged){sbParameter.Append("TAR_InsuranceMoney=@TAR_InsuranceMoney, ");}
      if(trafficAccident_Record.TAR_ActualMoney_IsChanged){sbParameter.Append("TAR_ActualMoney=@TAR_ActualMoney, ");}
      if(trafficAccident_Record.TAR_CompanyLoss_IsChanged){sbParameter.Append("TAR_CompanyLoss=@TAR_CompanyLoss, ");}
      if(trafficAccident_Record.TAR_RepairFactory_IsChanged){sbParameter.Append("TAR_RepairFactory=@TAR_RepairFactory, ");}
      if(trafficAccident_Record.TAR_Punish_IsChanged){sbParameter.Append("TAR_Punish=@TAR_Punish, ");}
      if(trafficAccident_Record.TAR_InjureSituation_IsChanged){sbParameter.Append("TAR_InjureSituation=@TAR_InjureSituation, ");}
      if(trafficAccident_Record.TAR_HandleResult_IsChanged){sbParameter.Append("TAR_HandleResult=@TAR_HandleResult, ");}
      if(trafficAccident_Record.TAR_ResponsibleResult_IsChanged){sbParameter.Append("TAR_ResponsibleResult=@TAR_ResponsibleResult, ");}
      if(trafficAccident_Record.TAR_AccidentResult_IsChanged){sbParameter.Append("TAR_AccidentResult=@TAR_AccidentResult, ");}
      if(trafficAccident_Record.TAR_Remark_IsChanged){sbParameter.Append("TAR_Remark=@TAR_Remark, ");}
      if(trafficAccident_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(trafficAccident_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(trafficAccident_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(trafficAccident_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TAR_ID=@TAR_ID; " );
      string sql=sb.ToString();
         if(trafficAccident_Record.TAR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Code))
         {
            idb.AddParameter("@TAR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Code", trafficAccident_Record.TAR_Code);
         }
          }
         if(trafficAccident_Record.TAR_Date_IsChanged)
         {
         if (trafficAccident_Record.TAR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Date", trafficAccident_Record.TAR_Date);
         }
          }
         if(trafficAccident_Record.TAR_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Position))
         {
            idb.AddParameter("@TAR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Position", trafficAccident_Record.TAR_Position);
         }
          }
         if(trafficAccident_Record.TAR_Pilot_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Pilot))
         {
            idb.AddParameter("@TAR_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Pilot", trafficAccident_Record.TAR_Pilot);
         }
          }
         if(trafficAccident_Record.TAR_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_VehiclesNo))
         {
            idb.AddParameter("@TAR_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_VehiclesNo", trafficAccident_Record.TAR_VehiclesNo);
         }
          }
         if(trafficAccident_Record.TAR_Model_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Model))
         {
            idb.AddParameter("@TAR_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Model", trafficAccident_Record.TAR_Model);
         }
          }
         if(trafficAccident_Record.TAR_Abstract_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Abstract))
         {
            idb.AddParameter("@TAR_Abstract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Abstract", trafficAccident_Record.TAR_Abstract);
         }
          }
         if(trafficAccident_Record.TAR_ReportDate_IsChanged)
         {
         if (trafficAccident_Record.TAR_ReportDate == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_ReportDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ReportDate", trafficAccident_Record.TAR_ReportDate);
         }
          }
         if(trafficAccident_Record.TAR_InsuranceCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_InsuranceCompany))
         {
            idb.AddParameter("@TAR_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_InsuranceCompany", trafficAccident_Record.TAR_InsuranceCompany);
         }
          }
         if(trafficAccident_Record.TAR_IsInsuranceCome_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_IsInsuranceCome))
         {
            idb.AddParameter("@TAR_IsInsuranceCome", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_IsInsuranceCome", trafficAccident_Record.TAR_IsInsuranceCome);
         }
          }
         if(trafficAccident_Record.TAR_IsPoliceCome_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_IsPoliceCome))
         {
            idb.AddParameter("@TAR_IsPoliceCome", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_IsPoliceCome", trafficAccident_Record.TAR_IsPoliceCome);
         }
          }
         if(trafficAccident_Record.TAR_ProceduresUpDate_IsChanged)
         {
         if (trafficAccident_Record.TAR_ProceduresUpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TAR_ProceduresUpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ProceduresUpDate", trafficAccident_Record.TAR_ProceduresUpDate);
         }
          }
         if(trafficAccident_Record.TAR_CurrentPay_IsChanged)
         {
         if (trafficAccident_Record.TAR_CurrentPay == 0)
         {
            idb.AddParameter("@TAR_CurrentPay", 0);
         }
         else
         {
            idb.AddParameter("@TAR_CurrentPay", trafficAccident_Record.TAR_CurrentPay);
         }
          }
         if(trafficAccident_Record.TAR_Reimbursementor_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Reimbursementor))
         {
            idb.AddParameter("@TAR_Reimbursementor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Reimbursementor", trafficAccident_Record.TAR_Reimbursementor);
         }
          }
         if(trafficAccident_Record.TAR_InsuranceMoney_IsChanged)
         {
         if (trafficAccident_Record.TAR_InsuranceMoney == 0)
         {
            idb.AddParameter("@TAR_InsuranceMoney", 0);
         }
         else
         {
            idb.AddParameter("@TAR_InsuranceMoney", trafficAccident_Record.TAR_InsuranceMoney);
         }
          }
         if(trafficAccident_Record.TAR_ActualMoney_IsChanged)
         {
         if (trafficAccident_Record.TAR_ActualMoney == 0)
         {
            idb.AddParameter("@TAR_ActualMoney", 0);
         }
         else
         {
            idb.AddParameter("@TAR_ActualMoney", trafficAccident_Record.TAR_ActualMoney);
         }
          }
         if(trafficAccident_Record.TAR_CompanyLoss_IsChanged)
         {
         if (trafficAccident_Record.TAR_CompanyLoss == 0)
         {
            idb.AddParameter("@TAR_CompanyLoss", 0);
         }
         else
         {
            idb.AddParameter("@TAR_CompanyLoss", trafficAccident_Record.TAR_CompanyLoss);
         }
          }
         if(trafficAccident_Record.TAR_RepairFactory_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_RepairFactory))
         {
            idb.AddParameter("@TAR_RepairFactory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_RepairFactory", trafficAccident_Record.TAR_RepairFactory);
         }
          }
         if(trafficAccident_Record.TAR_Punish_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Punish))
         {
            idb.AddParameter("@TAR_Punish", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Punish", trafficAccident_Record.TAR_Punish);
         }
          }
         if(trafficAccident_Record.TAR_InjureSituation_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_InjureSituation))
         {
            idb.AddParameter("@TAR_InjureSituation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_InjureSituation", trafficAccident_Record.TAR_InjureSituation);
         }
          }
         if(trafficAccident_Record.TAR_HandleResult_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_HandleResult))
         {
            idb.AddParameter("@TAR_HandleResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_HandleResult", trafficAccident_Record.TAR_HandleResult);
         }
          }
         if(trafficAccident_Record.TAR_ResponsibleResult_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_ResponsibleResult))
         {
            idb.AddParameter("@TAR_ResponsibleResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_ResponsibleResult", trafficAccident_Record.TAR_ResponsibleResult);
         }
          }
         if(trafficAccident_Record.TAR_AccidentResult_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_AccidentResult))
         {
            idb.AddParameter("@TAR_AccidentResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_AccidentResult", trafficAccident_Record.TAR_AccidentResult);
         }
          }
         if(trafficAccident_Record.TAR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(trafficAccident_Record.TAR_Remark))
         {
            idb.AddParameter("@TAR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TAR_Remark", trafficAccident_Record.TAR_Remark);
         }
          }
         if(trafficAccident_Record.Stat_IsChanged)
         {
         if (trafficAccident_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", trafficAccident_Record.Stat);
         }
          }
         if(trafficAccident_Record.CreateDate_IsChanged)
         {
         if (trafficAccident_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", trafficAccident_Record.CreateDate);
         }
          }
         if(trafficAccident_Record.UpdateDate_IsChanged)
         {
         if (trafficAccident_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", trafficAccident_Record.UpdateDate);
         }
          }
         if(trafficAccident_Record.DeleteDate_IsChanged)
         {
         if (trafficAccident_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", trafficAccident_Record.DeleteDate);
         }
          }

         idb.AddParameter("@TAR_ID", trafficAccident_Record.TAR_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 删除交通事故记录表 TrafficAccident_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal tAR_ID)
      {
         string sql = "DELETE TrafficAccident_Record WHERE 1=1  AND TAR_ID=@TAR_ID ";
         idb.AddParameter("@TAR_ID", tAR_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 获取指定的交通事故记录表 TrafficAccident_Record对象(即:一条记录
      /// </summary>
      public TrafficAccident_Record GetByKey(decimal tAR_ID)
      {
         TrafficAccident_Record trafficAccident_Record = new TrafficAccident_Record();
         string sql = "SELECT  TAR_ID,TAR_Code,TAR_Date,TAR_Position,TAR_Pilot,TAR_VehiclesNo,TAR_Model,TAR_Abstract,TAR_ReportDate,TAR_InsuranceCompany,TAR_IsInsuranceCome,TAR_IsPoliceCome,TAR_ProceduresUpDate,TAR_CurrentPay,TAR_Reimbursementor,TAR_InsuranceMoney,TAR_ActualMoney,TAR_CompanyLoss,TAR_RepairFactory,TAR_Punish,TAR_InjureSituation,TAR_HandleResult,TAR_ResponsibleResult,TAR_AccidentResult,TAR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TrafficAccident_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TAR_ID=@TAR_ID ";
         idb.AddParameter("@TAR_ID", tAR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TAR_ID"] != DBNull.Value) trafficAccident_Record.TAR_ID = Convert.ToDecimal(dr["TAR_ID"]);
            if (dr["TAR_Code"] != DBNull.Value) trafficAccident_Record.TAR_Code = Convert.ToString(dr["TAR_Code"]);
            if (dr["TAR_Date"] != DBNull.Value) trafficAccident_Record.TAR_Date = Convert.ToDateTime(dr["TAR_Date"]);
            if (dr["TAR_Position"] != DBNull.Value) trafficAccident_Record.TAR_Position = Convert.ToString(dr["TAR_Position"]);
            if (dr["TAR_Pilot"] != DBNull.Value) trafficAccident_Record.TAR_Pilot = Convert.ToString(dr["TAR_Pilot"]);
            if (dr["TAR_VehiclesNo"] != DBNull.Value) trafficAccident_Record.TAR_VehiclesNo = Convert.ToString(dr["TAR_VehiclesNo"]);
            if (dr["TAR_Model"] != DBNull.Value) trafficAccident_Record.TAR_Model = Convert.ToString(dr["TAR_Model"]);
            if (dr["TAR_Abstract"] != DBNull.Value) trafficAccident_Record.TAR_Abstract = Convert.ToString(dr["TAR_Abstract"]);
            if (dr["TAR_ReportDate"] != DBNull.Value) trafficAccident_Record.TAR_ReportDate = Convert.ToDateTime(dr["TAR_ReportDate"]);
            if (dr["TAR_InsuranceCompany"] != DBNull.Value) trafficAccident_Record.TAR_InsuranceCompany = Convert.ToString(dr["TAR_InsuranceCompany"]);
            if (dr["TAR_IsInsuranceCome"] != DBNull.Value) trafficAccident_Record.TAR_IsInsuranceCome = Convert.ToString(dr["TAR_IsInsuranceCome"]);
            if (dr["TAR_IsPoliceCome"] != DBNull.Value) trafficAccident_Record.TAR_IsPoliceCome = Convert.ToString(dr["TAR_IsPoliceCome"]);
            if (dr["TAR_ProceduresUpDate"] != DBNull.Value) trafficAccident_Record.TAR_ProceduresUpDate = Convert.ToDateTime(dr["TAR_ProceduresUpDate"]);
            if (dr["TAR_CurrentPay"] != DBNull.Value) trafficAccident_Record.TAR_CurrentPay = Convert.ToDecimal(dr["TAR_CurrentPay"]);
            if (dr["TAR_Reimbursementor"] != DBNull.Value) trafficAccident_Record.TAR_Reimbursementor = Convert.ToString(dr["TAR_Reimbursementor"]);
            if (dr["TAR_InsuranceMoney"] != DBNull.Value) trafficAccident_Record.TAR_InsuranceMoney = Convert.ToDecimal(dr["TAR_InsuranceMoney"]);
            if (dr["TAR_ActualMoney"] != DBNull.Value) trafficAccident_Record.TAR_ActualMoney = Convert.ToDecimal(dr["TAR_ActualMoney"]);
            if (dr["TAR_CompanyLoss"] != DBNull.Value) trafficAccident_Record.TAR_CompanyLoss = Convert.ToDecimal(dr["TAR_CompanyLoss"]);
            if (dr["TAR_RepairFactory"] != DBNull.Value) trafficAccident_Record.TAR_RepairFactory = Convert.ToString(dr["TAR_RepairFactory"]);
            if (dr["TAR_Punish"] != DBNull.Value) trafficAccident_Record.TAR_Punish = Convert.ToString(dr["TAR_Punish"]);
            if (dr["TAR_InjureSituation"] != DBNull.Value) trafficAccident_Record.TAR_InjureSituation = Convert.ToString(dr["TAR_InjureSituation"]);
            if (dr["TAR_HandleResult"] != DBNull.Value) trafficAccident_Record.TAR_HandleResult = Convert.ToString(dr["TAR_HandleResult"]);
            if (dr["TAR_ResponsibleResult"] != DBNull.Value) trafficAccident_Record.TAR_ResponsibleResult = Convert.ToString(dr["TAR_ResponsibleResult"]);
            if (dr["TAR_AccidentResult"] != DBNull.Value) trafficAccident_Record.TAR_AccidentResult = Convert.ToString(dr["TAR_AccidentResult"]);
            if (dr["TAR_Remark"] != DBNull.Value) trafficAccident_Record.TAR_Remark = Convert.ToString(dr["TAR_Remark"]);
            if (dr["Stat"] != DBNull.Value) trafficAccident_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) trafficAccident_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) trafficAccident_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) trafficAccident_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return trafficAccident_Record;
      }
      /// <summary>
      /// 获取指定的交通事故记录表 TrafficAccident_Record对象集合
      /// </summary>
      public List<TrafficAccident_Record> GetListByWhere(string strCondition)
      {
         List<TrafficAccident_Record> ret = new List<TrafficAccident_Record>();
         string sql = "SELECT  TAR_ID,TAR_Code,TAR_Date,TAR_Position,TAR_Pilot,TAR_VehiclesNo,TAR_Model,TAR_Abstract,TAR_ReportDate,TAR_InsuranceCompany,TAR_IsInsuranceCome,TAR_IsPoliceCome,TAR_ProceduresUpDate,TAR_CurrentPay,TAR_Reimbursementor,TAR_InsuranceMoney,TAR_ActualMoney,TAR_CompanyLoss,TAR_RepairFactory,TAR_Punish,TAR_InjureSituation,TAR_HandleResult,TAR_ResponsibleResult,TAR_AccidentResult,TAR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TrafficAccident_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TrafficAccident_Record trafficAccident_Record = new TrafficAccident_Record();
            if (dr["TAR_ID"] != DBNull.Value) trafficAccident_Record.TAR_ID = Convert.ToDecimal(dr["TAR_ID"]);
            if (dr["TAR_Code"] != DBNull.Value) trafficAccident_Record.TAR_Code = Convert.ToString(dr["TAR_Code"]);
            if (dr["TAR_Date"] != DBNull.Value) trafficAccident_Record.TAR_Date = Convert.ToDateTime(dr["TAR_Date"]);
            if (dr["TAR_Position"] != DBNull.Value) trafficAccident_Record.TAR_Position = Convert.ToString(dr["TAR_Position"]);
            if (dr["TAR_Pilot"] != DBNull.Value) trafficAccident_Record.TAR_Pilot = Convert.ToString(dr["TAR_Pilot"]);
            if (dr["TAR_VehiclesNo"] != DBNull.Value) trafficAccident_Record.TAR_VehiclesNo = Convert.ToString(dr["TAR_VehiclesNo"]);
            if (dr["TAR_Model"] != DBNull.Value) trafficAccident_Record.TAR_Model = Convert.ToString(dr["TAR_Model"]);
            if (dr["TAR_Abstract"] != DBNull.Value) trafficAccident_Record.TAR_Abstract = Convert.ToString(dr["TAR_Abstract"]);
            if (dr["TAR_ReportDate"] != DBNull.Value) trafficAccident_Record.TAR_ReportDate = Convert.ToDateTime(dr["TAR_ReportDate"]);
            if (dr["TAR_InsuranceCompany"] != DBNull.Value) trafficAccident_Record.TAR_InsuranceCompany = Convert.ToString(dr["TAR_InsuranceCompany"]);
            if (dr["TAR_IsInsuranceCome"] != DBNull.Value) trafficAccident_Record.TAR_IsInsuranceCome = Convert.ToString(dr["TAR_IsInsuranceCome"]);
            if (dr["TAR_IsPoliceCome"] != DBNull.Value) trafficAccident_Record.TAR_IsPoliceCome = Convert.ToString(dr["TAR_IsPoliceCome"]);
            if (dr["TAR_ProceduresUpDate"] != DBNull.Value) trafficAccident_Record.TAR_ProceduresUpDate = Convert.ToDateTime(dr["TAR_ProceduresUpDate"]);
            if (dr["TAR_CurrentPay"] != DBNull.Value) trafficAccident_Record.TAR_CurrentPay = Convert.ToDecimal(dr["TAR_CurrentPay"]);
            if (dr["TAR_Reimbursementor"] != DBNull.Value) trafficAccident_Record.TAR_Reimbursementor = Convert.ToString(dr["TAR_Reimbursementor"]);
            if (dr["TAR_InsuranceMoney"] != DBNull.Value) trafficAccident_Record.TAR_InsuranceMoney = Convert.ToDecimal(dr["TAR_InsuranceMoney"]);
            if (dr["TAR_ActualMoney"] != DBNull.Value) trafficAccident_Record.TAR_ActualMoney = Convert.ToDecimal(dr["TAR_ActualMoney"]);
            if (dr["TAR_CompanyLoss"] != DBNull.Value) trafficAccident_Record.TAR_CompanyLoss = Convert.ToDecimal(dr["TAR_CompanyLoss"]);
            if (dr["TAR_RepairFactory"] != DBNull.Value) trafficAccident_Record.TAR_RepairFactory = Convert.ToString(dr["TAR_RepairFactory"]);
            if (dr["TAR_Punish"] != DBNull.Value) trafficAccident_Record.TAR_Punish = Convert.ToString(dr["TAR_Punish"]);
            if (dr["TAR_InjureSituation"] != DBNull.Value) trafficAccident_Record.TAR_InjureSituation = Convert.ToString(dr["TAR_InjureSituation"]);
            if (dr["TAR_HandleResult"] != DBNull.Value) trafficAccident_Record.TAR_HandleResult = Convert.ToString(dr["TAR_HandleResult"]);
            if (dr["TAR_ResponsibleResult"] != DBNull.Value) trafficAccident_Record.TAR_ResponsibleResult = Convert.ToString(dr["TAR_ResponsibleResult"]);
            if (dr["TAR_AccidentResult"] != DBNull.Value) trafficAccident_Record.TAR_AccidentResult = Convert.ToString(dr["TAR_AccidentResult"]);
            if (dr["TAR_Remark"] != DBNull.Value) trafficAccident_Record.TAR_Remark = Convert.ToString(dr["TAR_Remark"]);
            if (dr["Stat"] != DBNull.Value) trafficAccident_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) trafficAccident_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) trafficAccident_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) trafficAccident_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(trafficAccident_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的交通事故记录表 TrafficAccident_Record对象(即:一条记录
      /// </summary>
      public List<TrafficAccident_Record> GetAll()
      {
         List<TrafficAccident_Record> ret = new List<TrafficAccident_Record>();
         string sql = "SELECT  TAR_ID,TAR_Code,TAR_Date,TAR_Position,TAR_Pilot,TAR_VehiclesNo,TAR_Model,TAR_Abstract,TAR_ReportDate,TAR_InsuranceCompany,TAR_IsInsuranceCome,TAR_IsPoliceCome,TAR_ProceduresUpDate,TAR_CurrentPay,TAR_Reimbursementor,TAR_InsuranceMoney,TAR_ActualMoney,TAR_CompanyLoss,TAR_RepairFactory,TAR_Punish,TAR_InjureSituation,TAR_HandleResult,TAR_ResponsibleResult,TAR_AccidentResult,TAR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TrafficAccident_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by TAR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TrafficAccident_Record trafficAccident_Record = new TrafficAccident_Record();
            if (dr["TAR_ID"] != DBNull.Value) trafficAccident_Record.TAR_ID = Convert.ToDecimal(dr["TAR_ID"]);
            if (dr["TAR_Code"] != DBNull.Value) trafficAccident_Record.TAR_Code = Convert.ToString(dr["TAR_Code"]);
            if (dr["TAR_Date"] != DBNull.Value) trafficAccident_Record.TAR_Date = Convert.ToDateTime(dr["TAR_Date"]);
            if (dr["TAR_Position"] != DBNull.Value) trafficAccident_Record.TAR_Position = Convert.ToString(dr["TAR_Position"]);
            if (dr["TAR_Pilot"] != DBNull.Value) trafficAccident_Record.TAR_Pilot = Convert.ToString(dr["TAR_Pilot"]);
            if (dr["TAR_VehiclesNo"] != DBNull.Value) trafficAccident_Record.TAR_VehiclesNo = Convert.ToString(dr["TAR_VehiclesNo"]);
            if (dr["TAR_Model"] != DBNull.Value) trafficAccident_Record.TAR_Model = Convert.ToString(dr["TAR_Model"]);
            if (dr["TAR_Abstract"] != DBNull.Value) trafficAccident_Record.TAR_Abstract = Convert.ToString(dr["TAR_Abstract"]);
            if (dr["TAR_ReportDate"] != DBNull.Value) trafficAccident_Record.TAR_ReportDate = Convert.ToDateTime(dr["TAR_ReportDate"]);
            if (dr["TAR_InsuranceCompany"] != DBNull.Value) trafficAccident_Record.TAR_InsuranceCompany = Convert.ToString(dr["TAR_InsuranceCompany"]);
            if (dr["TAR_IsInsuranceCome"] != DBNull.Value) trafficAccident_Record.TAR_IsInsuranceCome = Convert.ToString(dr["TAR_IsInsuranceCome"]);
            if (dr["TAR_IsPoliceCome"] != DBNull.Value) trafficAccident_Record.TAR_IsPoliceCome = Convert.ToString(dr["TAR_IsPoliceCome"]);
            if (dr["TAR_ProceduresUpDate"] != DBNull.Value) trafficAccident_Record.TAR_ProceduresUpDate = Convert.ToDateTime(dr["TAR_ProceduresUpDate"]);
            if (dr["TAR_CurrentPay"] != DBNull.Value) trafficAccident_Record.TAR_CurrentPay = Convert.ToDecimal(dr["TAR_CurrentPay"]);
            if (dr["TAR_Reimbursementor"] != DBNull.Value) trafficAccident_Record.TAR_Reimbursementor = Convert.ToString(dr["TAR_Reimbursementor"]);
            if (dr["TAR_InsuranceMoney"] != DBNull.Value) trafficAccident_Record.TAR_InsuranceMoney = Convert.ToDecimal(dr["TAR_InsuranceMoney"]);
            if (dr["TAR_ActualMoney"] != DBNull.Value) trafficAccident_Record.TAR_ActualMoney = Convert.ToDecimal(dr["TAR_ActualMoney"]);
            if (dr["TAR_CompanyLoss"] != DBNull.Value) trafficAccident_Record.TAR_CompanyLoss = Convert.ToDecimal(dr["TAR_CompanyLoss"]);
            if (dr["TAR_RepairFactory"] != DBNull.Value) trafficAccident_Record.TAR_RepairFactory = Convert.ToString(dr["TAR_RepairFactory"]);
            if (dr["TAR_Punish"] != DBNull.Value) trafficAccident_Record.TAR_Punish = Convert.ToString(dr["TAR_Punish"]);
            if (dr["TAR_InjureSituation"] != DBNull.Value) trafficAccident_Record.TAR_InjureSituation = Convert.ToString(dr["TAR_InjureSituation"]);
            if (dr["TAR_HandleResult"] != DBNull.Value) trafficAccident_Record.TAR_HandleResult = Convert.ToString(dr["TAR_HandleResult"]);
            if (dr["TAR_ResponsibleResult"] != DBNull.Value) trafficAccident_Record.TAR_ResponsibleResult = Convert.ToString(dr["TAR_ResponsibleResult"]);
            if (dr["TAR_AccidentResult"] != DBNull.Value) trafficAccident_Record.TAR_AccidentResult = Convert.ToString(dr["TAR_AccidentResult"]);
            if (dr["TAR_Remark"] != DBNull.Value) trafficAccident_Record.TAR_Remark = Convert.ToString(dr["TAR_Remark"]);
            if (dr["Stat"] != DBNull.Value) trafficAccident_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) trafficAccident_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) trafficAccident_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) trafficAccident_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(trafficAccident_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
