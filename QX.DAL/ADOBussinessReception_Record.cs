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
   /// 常规业务招待信息
   /// </summary>
   [Serializable]
   public partial class ADOBussinessReception_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加常规业务招待信息 BussinessReception_Record对象(即:一条记录)
      /// </summary>
      public int Add(BussinessReception_Record bussinessReception_Record)
      {
         string sql = "INSERT INTO BussinessReception_Record (UpdateDate,BR_Code,BR_Type,BR_Date,BR_Position,BR_Content,BR_ObjectiveCompany,BR_ObjectivePerson,BR_PersonNumber,BR_Amount,BR_Reason,BR_Operator,BR_Creator,BR_CreateDate,BR_Company,BR_Dept,Stat,CreateDate,DeleteDate) VALUES (@UpdateDate,@BR_Code,@BR_Type,@BR_Date,@BR_Position,@BR_Content,@BR_ObjectiveCompany,@BR_ObjectivePerson,@BR_PersonNumber,@BR_Amount,@BR_Reason,@BR_Operator,@BR_Creator,@BR_CreateDate,@BR_Company,@BR_Dept,@Stat,@CreateDate,@DeleteDate)";
         if (bussinessReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bussinessReception_Record.UpdateDate);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Code))
         {
            idb.AddParameter("@BR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Code", bussinessReception_Record.BR_Code);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Type))
         {
            idb.AddParameter("@BR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Type", bussinessReception_Record.BR_Type);
         }
         if (bussinessReception_Record.BR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@BR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Date", bussinessReception_Record.BR_Date);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Position))
         {
            idb.AddParameter("@BR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Position", bussinessReception_Record.BR_Position);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Content))
         {
            idb.AddParameter("@BR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Content", bussinessReception_Record.BR_Content);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_ObjectiveCompany))
         {
            idb.AddParameter("@BR_ObjectiveCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_ObjectiveCompany", bussinessReception_Record.BR_ObjectiveCompany);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_ObjectivePerson))
         {
            idb.AddParameter("@BR_ObjectivePerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_ObjectivePerson", bussinessReception_Record.BR_ObjectivePerson);
         }
         if (bussinessReception_Record.BR_PersonNumber == 0)
         {
            idb.AddParameter("@BR_PersonNumber", 0);
         }
         else
         {
            idb.AddParameter("@BR_PersonNumber", bussinessReception_Record.BR_PersonNumber);
         }
         if (bussinessReception_Record.BR_Amount == 0)
         {
            idb.AddParameter("@BR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@BR_Amount", bussinessReception_Record.BR_Amount);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Reason))
         {
            idb.AddParameter("@BR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Reason", bussinessReception_Record.BR_Reason);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Operator))
         {
            idb.AddParameter("@BR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Operator", bussinessReception_Record.BR_Operator);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Creator))
         {
            idb.AddParameter("@BR_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Creator", bussinessReception_Record.BR_Creator);
         }
         if (bussinessReception_Record.BR_CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@BR_CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_CreateDate", bussinessReception_Record.BR_CreateDate);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Company))
         {
            idb.AddParameter("@BR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Company", bussinessReception_Record.BR_Company);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Dept))
         {
            idb.AddParameter("@BR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Dept", bussinessReception_Record.BR_Dept);
         }
         if (bussinessReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bussinessReception_Record.Stat);
         }
         if (bussinessReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bussinessReception_Record.CreateDate);
         }
         if (bussinessReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bussinessReception_Record.DeleteDate);
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
      /// 添加常规业务招待信息 BussinessReception_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(BussinessReception_Record bussinessReception_Record)
      {
         string sql = "INSERT INTO BussinessReception_Record (UpdateDate,BR_Code,BR_Type,BR_Date,BR_Position,BR_Content,BR_ObjectiveCompany,BR_ObjectivePerson,BR_PersonNumber,BR_Amount,BR_Reason,BR_Operator,BR_Creator,BR_CreateDate,BR_Company,BR_Dept,Stat,CreateDate,DeleteDate) VALUES (@UpdateDate,@BR_Code,@BR_Type,@BR_Date,@BR_Position,@BR_Content,@BR_ObjectiveCompany,@BR_ObjectivePerson,@BR_PersonNumber,@BR_Amount,@BR_Reason,@BR_Operator,@BR_Creator,@BR_CreateDate,@BR_Company,@BR_Dept,@Stat,@CreateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (bussinessReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bussinessReception_Record.UpdateDate);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Code))
         {
            idb.AddParameter("@BR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Code", bussinessReception_Record.BR_Code);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Type))
         {
            idb.AddParameter("@BR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Type", bussinessReception_Record.BR_Type);
         }
         if (bussinessReception_Record.BR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@BR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Date", bussinessReception_Record.BR_Date);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Position))
         {
            idb.AddParameter("@BR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Position", bussinessReception_Record.BR_Position);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Content))
         {
            idb.AddParameter("@BR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Content", bussinessReception_Record.BR_Content);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_ObjectiveCompany))
         {
            idb.AddParameter("@BR_ObjectiveCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_ObjectiveCompany", bussinessReception_Record.BR_ObjectiveCompany);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_ObjectivePerson))
         {
            idb.AddParameter("@BR_ObjectivePerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_ObjectivePerson", bussinessReception_Record.BR_ObjectivePerson);
         }
         if (bussinessReception_Record.BR_PersonNumber == 0)
         {
            idb.AddParameter("@BR_PersonNumber", 0);
         }
         else
         {
            idb.AddParameter("@BR_PersonNumber", bussinessReception_Record.BR_PersonNumber);
         }
         if (bussinessReception_Record.BR_Amount == 0)
         {
            idb.AddParameter("@BR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@BR_Amount", bussinessReception_Record.BR_Amount);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Reason))
         {
            idb.AddParameter("@BR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Reason", bussinessReception_Record.BR_Reason);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Operator))
         {
            idb.AddParameter("@BR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Operator", bussinessReception_Record.BR_Operator);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Creator))
         {
            idb.AddParameter("@BR_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Creator", bussinessReception_Record.BR_Creator);
         }
         if (bussinessReception_Record.BR_CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@BR_CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_CreateDate", bussinessReception_Record.BR_CreateDate);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Company))
         {
            idb.AddParameter("@BR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Company", bussinessReception_Record.BR_Company);
         }
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Dept))
         {
            idb.AddParameter("@BR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Dept", bussinessReception_Record.BR_Dept);
         }
         if (bussinessReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bussinessReception_Record.Stat);
         }
         if (bussinessReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bussinessReception_Record.CreateDate);
         }
         if (bussinessReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bussinessReception_Record.DeleteDate);
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
      /// 更新常规业务招待信息 BussinessReception_Record对象(即:一条记录
      /// </summary>
      public int Update(BussinessReception_Record bussinessReception_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       BussinessReception_Record       SET ");
            if(bussinessReception_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bussinessReception_Record.BR_Code_IsChanged){sbParameter.Append("BR_Code=@BR_Code, ");}
      if(bussinessReception_Record.BR_Type_IsChanged){sbParameter.Append("BR_Type=@BR_Type, ");}
      if(bussinessReception_Record.BR_Date_IsChanged){sbParameter.Append("BR_Date=@BR_Date, ");}
      if(bussinessReception_Record.BR_Position_IsChanged){sbParameter.Append("BR_Position=@BR_Position, ");}
      if(bussinessReception_Record.BR_Content_IsChanged){sbParameter.Append("BR_Content=@BR_Content, ");}
      if(bussinessReception_Record.BR_ObjectiveCompany_IsChanged){sbParameter.Append("BR_ObjectiveCompany=@BR_ObjectiveCompany, ");}
      if(bussinessReception_Record.BR_ObjectivePerson_IsChanged){sbParameter.Append("BR_ObjectivePerson=@BR_ObjectivePerson, ");}
      if(bussinessReception_Record.BR_PersonNumber_IsChanged){sbParameter.Append("BR_PersonNumber=@BR_PersonNumber, ");}
      if(bussinessReception_Record.BR_Amount_IsChanged){sbParameter.Append("BR_Amount=@BR_Amount, ");}
      if(bussinessReception_Record.BR_Reason_IsChanged){sbParameter.Append("BR_Reason=@BR_Reason, ");}
      if(bussinessReception_Record.BR_Operator_IsChanged){sbParameter.Append("BR_Operator=@BR_Operator, ");}
      if(bussinessReception_Record.BR_Creator_IsChanged){sbParameter.Append("BR_Creator=@BR_Creator, ");}
      if(bussinessReception_Record.BR_CreateDate_IsChanged){sbParameter.Append("BR_CreateDate=@BR_CreateDate, ");}
      if(bussinessReception_Record.BR_Company_IsChanged){sbParameter.Append("BR_Company=@BR_Company, ");}
      if(bussinessReception_Record.BR_Dept_IsChanged){sbParameter.Append("BR_Dept=@BR_Dept, ");}
      if(bussinessReception_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bussinessReception_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bussinessReception_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and BR_ID=@BR_ID; " );
      string sql=sb.ToString();
         if(bussinessReception_Record.UpdateDate_IsChanged)
         {
         if (bussinessReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bussinessReception_Record.UpdateDate);
         }
          }
         if(bussinessReception_Record.BR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Code))
         {
            idb.AddParameter("@BR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Code", bussinessReception_Record.BR_Code);
         }
          }
         if(bussinessReception_Record.BR_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Type))
         {
            idb.AddParameter("@BR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Type", bussinessReception_Record.BR_Type);
         }
          }
         if(bussinessReception_Record.BR_Date_IsChanged)
         {
         if (bussinessReception_Record.BR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@BR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Date", bussinessReception_Record.BR_Date);
         }
          }
         if(bussinessReception_Record.BR_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Position))
         {
            idb.AddParameter("@BR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Position", bussinessReception_Record.BR_Position);
         }
          }
         if(bussinessReception_Record.BR_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Content))
         {
            idb.AddParameter("@BR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Content", bussinessReception_Record.BR_Content);
         }
          }
         if(bussinessReception_Record.BR_ObjectiveCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_ObjectiveCompany))
         {
            idb.AddParameter("@BR_ObjectiveCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_ObjectiveCompany", bussinessReception_Record.BR_ObjectiveCompany);
         }
          }
         if(bussinessReception_Record.BR_ObjectivePerson_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_ObjectivePerson))
         {
            idb.AddParameter("@BR_ObjectivePerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_ObjectivePerson", bussinessReception_Record.BR_ObjectivePerson);
         }
          }
         if(bussinessReception_Record.BR_PersonNumber_IsChanged)
         {
         if (bussinessReception_Record.BR_PersonNumber == 0)
         {
            idb.AddParameter("@BR_PersonNumber", 0);
         }
         else
         {
            idb.AddParameter("@BR_PersonNumber", bussinessReception_Record.BR_PersonNumber);
         }
          }
         if(bussinessReception_Record.BR_Amount_IsChanged)
         {
         if (bussinessReception_Record.BR_Amount == 0)
         {
            idb.AddParameter("@BR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@BR_Amount", bussinessReception_Record.BR_Amount);
         }
          }
         if(bussinessReception_Record.BR_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Reason))
         {
            idb.AddParameter("@BR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Reason", bussinessReception_Record.BR_Reason);
         }
          }
         if(bussinessReception_Record.BR_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Operator))
         {
            idb.AddParameter("@BR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Operator", bussinessReception_Record.BR_Operator);
         }
          }
         if(bussinessReception_Record.BR_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Creator))
         {
            idb.AddParameter("@BR_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Creator", bussinessReception_Record.BR_Creator);
         }
          }
         if(bussinessReception_Record.BR_CreateDate_IsChanged)
         {
         if (bussinessReception_Record.BR_CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@BR_CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_CreateDate", bussinessReception_Record.BR_CreateDate);
         }
          }
         if(bussinessReception_Record.BR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Company))
         {
            idb.AddParameter("@BR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Company", bussinessReception_Record.BR_Company);
         }
          }
         if(bussinessReception_Record.BR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(bussinessReception_Record.BR_Dept))
         {
            idb.AddParameter("@BR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BR_Dept", bussinessReception_Record.BR_Dept);
         }
          }
         if(bussinessReception_Record.Stat_IsChanged)
         {
         if (bussinessReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bussinessReception_Record.Stat);
         }
          }
         if(bussinessReception_Record.CreateDate_IsChanged)
         {
         if (bussinessReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bussinessReception_Record.CreateDate);
         }
          }
         if(bussinessReception_Record.DeleteDate_IsChanged)
         {
         if (bussinessReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bussinessReception_Record.DeleteDate);
         }
          }

         idb.AddParameter("@BR_ID", bussinessReception_Record.BR_ID);

           
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
      /// 删除常规业务招待信息 BussinessReception_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal bR_ID)
      {
         string sql = "DELETE BussinessReception_Record WHERE 1=1  AND BR_ID=@BR_ID ";
         idb.AddParameter("@BR_ID", bR_ID);

           
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
      /// 获取指定的常规业务招待信息 BussinessReception_Record对象(即:一条记录
      /// </summary>
      public BussinessReception_Record GetByKey(decimal bR_ID)
      {
         BussinessReception_Record bussinessReception_Record = new BussinessReception_Record();
         string sql = "SELECT  UpdateDate,BR_ID,BR_Code,BR_Type,BR_Date,BR_Position,BR_Content,BR_ObjectiveCompany,BR_ObjectivePerson,BR_PersonNumber,BR_Amount,BR_Reason,BR_Operator,BR_Creator,BR_CreateDate,BR_Company,BR_Dept,Stat,CreateDate,DeleteDate FROM BussinessReception_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND BR_ID=@BR_ID ";
         idb.AddParameter("@BR_ID", bR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["UpdateDate"] != DBNull.Value) bussinessReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["BR_ID"] != DBNull.Value) bussinessReception_Record.BR_ID = Convert.ToDecimal(dr["BR_ID"]);
            if (dr["BR_Code"] != DBNull.Value) bussinessReception_Record.BR_Code = Convert.ToString(dr["BR_Code"]);
            if (dr["BR_Type"] != DBNull.Value) bussinessReception_Record.BR_Type = Convert.ToString(dr["BR_Type"]);
            if (dr["BR_Date"] != DBNull.Value) bussinessReception_Record.BR_Date = Convert.ToDateTime(dr["BR_Date"]);
            if (dr["BR_Position"] != DBNull.Value) bussinessReception_Record.BR_Position = Convert.ToString(dr["BR_Position"]);
            if (dr["BR_Content"] != DBNull.Value) bussinessReception_Record.BR_Content = Convert.ToString(dr["BR_Content"]);
            if (dr["BR_ObjectiveCompany"] != DBNull.Value) bussinessReception_Record.BR_ObjectiveCompany = Convert.ToString(dr["BR_ObjectiveCompany"]);
            if (dr["BR_ObjectivePerson"] != DBNull.Value) bussinessReception_Record.BR_ObjectivePerson = Convert.ToString(dr["BR_ObjectivePerson"]);
            if (dr["BR_PersonNumber"] != DBNull.Value) bussinessReception_Record.BR_PersonNumber = Convert.ToInt32(dr["BR_PersonNumber"]);
            if (dr["BR_Amount"] != DBNull.Value) bussinessReception_Record.BR_Amount = Convert.ToDecimal(dr["BR_Amount"]);
            if (dr["BR_Reason"] != DBNull.Value) bussinessReception_Record.BR_Reason = Convert.ToString(dr["BR_Reason"]);
            if (dr["BR_Operator"] != DBNull.Value) bussinessReception_Record.BR_Operator = Convert.ToString(dr["BR_Operator"]);
            if (dr["BR_Creator"] != DBNull.Value) bussinessReception_Record.BR_Creator = Convert.ToString(dr["BR_Creator"]);
            if (dr["BR_CreateDate"] != DBNull.Value) bussinessReception_Record.BR_CreateDate = Convert.ToDateTime(dr["BR_CreateDate"]);
            if (dr["BR_Company"] != DBNull.Value) bussinessReception_Record.BR_Company = Convert.ToString(dr["BR_Company"]);
            if (dr["BR_Dept"] != DBNull.Value) bussinessReception_Record.BR_Dept = Convert.ToString(dr["BR_Dept"]);
            if (dr["Stat"] != DBNull.Value) bussinessReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bussinessReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bussinessReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bussinessReception_Record;
      }
      /// <summary>
      /// 获取指定的常规业务招待信息 BussinessReception_Record对象集合
      /// </summary>
      public List<BussinessReception_Record> GetListByWhere(string strCondition)
      {
         List<BussinessReception_Record> ret = new List<BussinessReception_Record>();
         string sql = "SELECT  UpdateDate,BR_ID,BR_Code,BR_Type,BR_Date,BR_Position,BR_Content,BR_ObjectiveCompany,BR_ObjectivePerson,BR_PersonNumber,BR_Amount,BR_Reason,BR_Operator,BR_Creator,BR_CreateDate,BR_Company,BR_Dept,Stat,CreateDate,DeleteDate FROM BussinessReception_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            BussinessReception_Record bussinessReception_Record = new BussinessReception_Record();
            if (dr["UpdateDate"] != DBNull.Value) bussinessReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["BR_ID"] != DBNull.Value) bussinessReception_Record.BR_ID = Convert.ToDecimal(dr["BR_ID"]);
            if (dr["BR_Code"] != DBNull.Value) bussinessReception_Record.BR_Code = Convert.ToString(dr["BR_Code"]);
            if (dr["BR_Type"] != DBNull.Value) bussinessReception_Record.BR_Type = Convert.ToString(dr["BR_Type"]);
            if (dr["BR_Date"] != DBNull.Value) bussinessReception_Record.BR_Date = Convert.ToDateTime(dr["BR_Date"]);
            if (dr["BR_Position"] != DBNull.Value) bussinessReception_Record.BR_Position = Convert.ToString(dr["BR_Position"]);
            if (dr["BR_Content"] != DBNull.Value) bussinessReception_Record.BR_Content = Convert.ToString(dr["BR_Content"]);
            if (dr["BR_ObjectiveCompany"] != DBNull.Value) bussinessReception_Record.BR_ObjectiveCompany = Convert.ToString(dr["BR_ObjectiveCompany"]);
            if (dr["BR_ObjectivePerson"] != DBNull.Value) bussinessReception_Record.BR_ObjectivePerson = Convert.ToString(dr["BR_ObjectivePerson"]);
            if (dr["BR_PersonNumber"] != DBNull.Value) bussinessReception_Record.BR_PersonNumber = Convert.ToInt32(dr["BR_PersonNumber"]);
            if (dr["BR_Amount"] != DBNull.Value) bussinessReception_Record.BR_Amount = Convert.ToDecimal(dr["BR_Amount"]);
            if (dr["BR_Reason"] != DBNull.Value) bussinessReception_Record.BR_Reason = Convert.ToString(dr["BR_Reason"]);
            if (dr["BR_Operator"] != DBNull.Value) bussinessReception_Record.BR_Operator = Convert.ToString(dr["BR_Operator"]);
            if (dr["BR_Creator"] != DBNull.Value) bussinessReception_Record.BR_Creator = Convert.ToString(dr["BR_Creator"]);
            if (dr["BR_CreateDate"] != DBNull.Value) bussinessReception_Record.BR_CreateDate = Convert.ToDateTime(dr["BR_CreateDate"]);
            if (dr["BR_Company"] != DBNull.Value) bussinessReception_Record.BR_Company = Convert.ToString(dr["BR_Company"]);
            if (dr["BR_Dept"] != DBNull.Value) bussinessReception_Record.BR_Dept = Convert.ToString(dr["BR_Dept"]);
            if (dr["Stat"] != DBNull.Value) bussinessReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bussinessReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bussinessReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bussinessReception_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的常规业务招待信息 BussinessReception_Record对象(即:一条记录
      /// </summary>
      public List<BussinessReception_Record> GetAll()
      {
         List<BussinessReception_Record> ret = new List<BussinessReception_Record>();
         string sql = "SELECT  UpdateDate,BR_ID,BR_Code,BR_Type,BR_Date,BR_Position,BR_Content,BR_ObjectiveCompany,BR_ObjectivePerson,BR_PersonNumber,BR_Amount,BR_Reason,BR_Operator,BR_Creator,BR_CreateDate,BR_Company,BR_Dept,Stat,CreateDate,DeleteDate FROM BussinessReception_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by BR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            BussinessReception_Record bussinessReception_Record = new BussinessReception_Record();
            if (dr["UpdateDate"] != DBNull.Value) bussinessReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["BR_ID"] != DBNull.Value) bussinessReception_Record.BR_ID = Convert.ToDecimal(dr["BR_ID"]);
            if (dr["BR_Code"] != DBNull.Value) bussinessReception_Record.BR_Code = Convert.ToString(dr["BR_Code"]);
            if (dr["BR_Type"] != DBNull.Value) bussinessReception_Record.BR_Type = Convert.ToString(dr["BR_Type"]);
            if (dr["BR_Date"] != DBNull.Value) bussinessReception_Record.BR_Date = Convert.ToDateTime(dr["BR_Date"]);
            if (dr["BR_Position"] != DBNull.Value) bussinessReception_Record.BR_Position = Convert.ToString(dr["BR_Position"]);
            if (dr["BR_Content"] != DBNull.Value) bussinessReception_Record.BR_Content = Convert.ToString(dr["BR_Content"]);
            if (dr["BR_ObjectiveCompany"] != DBNull.Value) bussinessReception_Record.BR_ObjectiveCompany = Convert.ToString(dr["BR_ObjectiveCompany"]);
            if (dr["BR_ObjectivePerson"] != DBNull.Value) bussinessReception_Record.BR_ObjectivePerson = Convert.ToString(dr["BR_ObjectivePerson"]);
            if (dr["BR_PersonNumber"] != DBNull.Value) bussinessReception_Record.BR_PersonNumber = Convert.ToInt32(dr["BR_PersonNumber"]);
            if (dr["BR_Amount"] != DBNull.Value) bussinessReception_Record.BR_Amount = Convert.ToDecimal(dr["BR_Amount"]);
            if (dr["BR_Reason"] != DBNull.Value) bussinessReception_Record.BR_Reason = Convert.ToString(dr["BR_Reason"]);
            if (dr["BR_Operator"] != DBNull.Value) bussinessReception_Record.BR_Operator = Convert.ToString(dr["BR_Operator"]);
            if (dr["BR_Creator"] != DBNull.Value) bussinessReception_Record.BR_Creator = Convert.ToString(dr["BR_Creator"]);
            if (dr["BR_CreateDate"] != DBNull.Value) bussinessReception_Record.BR_CreateDate = Convert.ToDateTime(dr["BR_CreateDate"]);
            if (dr["BR_Company"] != DBNull.Value) bussinessReception_Record.BR_Company = Convert.ToString(dr["BR_Company"]);
            if (dr["BR_Dept"] != DBNull.Value) bussinessReception_Record.BR_Dept = Convert.ToString(dr["BR_Dept"]);
            if (dr["Stat"] != DBNull.Value) bussinessReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bussinessReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bussinessReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bussinessReception_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
