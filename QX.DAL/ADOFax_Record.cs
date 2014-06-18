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
   /// 传真登记信息
   /// </summary>
   [Serializable]
   public partial class ADOFax_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加传真登记信息 Fax_Record对象(即:一条记录)
      /// </summary>
      public int Add(Fax_Record fax_Record)
      {
         string sql = "INSERT INTO Fax_Record (FR_Code,FR_Date,FR_Content,FR_Category,FR_Num,FR_PageNum,FR_Amount,FR_Operator,FR_OpDate,FR_OpRemark,FR_TranferCompany,FR_TranferDept,FR_TranferRemark,FR_TranferDate,FR_Company,FR_Dept,FR_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@FR_Code,@FR_Date,@FR_Content,@FR_Category,@FR_Num,@FR_PageNum,@FR_Amount,@FR_Operator,@FR_OpDate,@FR_OpRemark,@FR_TranferCompany,@FR_TranferDept,@FR_TranferRemark,@FR_TranferDate,@FR_Company,@FR_Dept,@FR_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(fax_Record.FR_Code))
         {
            idb.AddParameter("@FR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Code", fax_Record.FR_Code);
         }
         if (fax_Record.FR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Date", fax_Record.FR_Date);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Content))
         {
            idb.AddParameter("@FR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Content", fax_Record.FR_Content);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Category))
         {
            idb.AddParameter("@FR_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Category", fax_Record.FR_Category);
         }
         if (fax_Record.FR_Num == 0)
         {
            idb.AddParameter("@FR_Num", 0);
         }
         else
         {
            idb.AddParameter("@FR_Num", fax_Record.FR_Num);
         }
         if (fax_Record.FR_PageNum == 0)
         {
            idb.AddParameter("@FR_PageNum", 0);
         }
         else
         {
            idb.AddParameter("@FR_PageNum", fax_Record.FR_PageNum);
         }
         if (fax_Record.FR_Amount == 0)
         {
            idb.AddParameter("@FR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@FR_Amount", fax_Record.FR_Amount);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Operator))
         {
            idb.AddParameter("@FR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Operator", fax_Record.FR_Operator);
         }
         if (fax_Record.FR_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@FR_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_OpDate", fax_Record.FR_OpDate);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_OpRemark))
         {
            idb.AddParameter("@FR_OpRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_OpRemark", fax_Record.FR_OpRemark);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferCompany))
         {
            idb.AddParameter("@FR_TranferCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferCompany", fax_Record.FR_TranferCompany);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferDept))
         {
            idb.AddParameter("@FR_TranferDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferDept", fax_Record.FR_TranferDept);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferRemark))
         {
            idb.AddParameter("@FR_TranferRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferRemark", fax_Record.FR_TranferRemark);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferDate))
         {
            idb.AddParameter("@FR_TranferDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferDate", fax_Record.FR_TranferDate);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Company))
         {
            idb.AddParameter("@FR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Company", fax_Record.FR_Company);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Dept))
         {
            idb.AddParameter("@FR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Dept", fax_Record.FR_Dept);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Stat))
         {
            idb.AddParameter("@FR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Stat", fax_Record.FR_Stat);
         }
         if (fax_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fax_Record.Stat);
         }
         if (fax_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", fax_Record.CreateDate);
         }
         if (fax_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", fax_Record.UpdateDate);
         }
         if (fax_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", fax_Record.DeleteDate);
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
      /// 添加传真登记信息 Fax_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Fax_Record fax_Record)
      {
         string sql = "INSERT INTO Fax_Record (FR_Code,FR_Date,FR_Content,FR_Category,FR_Num,FR_PageNum,FR_Amount,FR_Operator,FR_OpDate,FR_OpRemark,FR_TranferCompany,FR_TranferDept,FR_TranferRemark,FR_TranferDate,FR_Company,FR_Dept,FR_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@FR_Code,@FR_Date,@FR_Content,@FR_Category,@FR_Num,@FR_PageNum,@FR_Amount,@FR_Operator,@FR_OpDate,@FR_OpRemark,@FR_TranferCompany,@FR_TranferDept,@FR_TranferRemark,@FR_TranferDate,@FR_Company,@FR_Dept,@FR_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(fax_Record.FR_Code))
         {
            idb.AddParameter("@FR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Code", fax_Record.FR_Code);
         }
         if (fax_Record.FR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Date", fax_Record.FR_Date);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Content))
         {
            idb.AddParameter("@FR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Content", fax_Record.FR_Content);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Category))
         {
            idb.AddParameter("@FR_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Category", fax_Record.FR_Category);
         }
         if (fax_Record.FR_Num == 0)
         {
            idb.AddParameter("@FR_Num", 0);
         }
         else
         {
            idb.AddParameter("@FR_Num", fax_Record.FR_Num);
         }
         if (fax_Record.FR_PageNum == 0)
         {
            idb.AddParameter("@FR_PageNum", 0);
         }
         else
         {
            idb.AddParameter("@FR_PageNum", fax_Record.FR_PageNum);
         }
         if (fax_Record.FR_Amount == 0)
         {
            idb.AddParameter("@FR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@FR_Amount", fax_Record.FR_Amount);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Operator))
         {
            idb.AddParameter("@FR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Operator", fax_Record.FR_Operator);
         }
         if (fax_Record.FR_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@FR_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_OpDate", fax_Record.FR_OpDate);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_OpRemark))
         {
            idb.AddParameter("@FR_OpRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_OpRemark", fax_Record.FR_OpRemark);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferCompany))
         {
            idb.AddParameter("@FR_TranferCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferCompany", fax_Record.FR_TranferCompany);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferDept))
         {
            idb.AddParameter("@FR_TranferDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferDept", fax_Record.FR_TranferDept);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferRemark))
         {
            idb.AddParameter("@FR_TranferRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferRemark", fax_Record.FR_TranferRemark);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_TranferDate))
         {
            idb.AddParameter("@FR_TranferDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferDate", fax_Record.FR_TranferDate);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Company))
         {
            idb.AddParameter("@FR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Company", fax_Record.FR_Company);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Dept))
         {
            idb.AddParameter("@FR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Dept", fax_Record.FR_Dept);
         }
         if (string.IsNullOrEmpty(fax_Record.FR_Stat))
         {
            idb.AddParameter("@FR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Stat", fax_Record.FR_Stat);
         }
         if (fax_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fax_Record.Stat);
         }
         if (fax_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", fax_Record.CreateDate);
         }
         if (fax_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", fax_Record.UpdateDate);
         }
         if (fax_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", fax_Record.DeleteDate);
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
      /// 更新传真登记信息 Fax_Record对象(即:一条记录
      /// </summary>
      public int Update(Fax_Record fax_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Fax_Record       SET ");
            if(fax_Record.FR_Code_IsChanged){sbParameter.Append("FR_Code=@FR_Code, ");}
      if(fax_Record.FR_Date_IsChanged){sbParameter.Append("FR_Date=@FR_Date, ");}
      if(fax_Record.FR_Content_IsChanged){sbParameter.Append("FR_Content=@FR_Content, ");}
      if(fax_Record.FR_Category_IsChanged){sbParameter.Append("FR_Category=@FR_Category, ");}
      if(fax_Record.FR_Num_IsChanged){sbParameter.Append("FR_Num=@FR_Num, ");}
      if(fax_Record.FR_PageNum_IsChanged){sbParameter.Append("FR_PageNum=@FR_PageNum, ");}
      if(fax_Record.FR_Amount_IsChanged){sbParameter.Append("FR_Amount=@FR_Amount, ");}
      if(fax_Record.FR_Operator_IsChanged){sbParameter.Append("FR_Operator=@FR_Operator, ");}
      if(fax_Record.FR_OpDate_IsChanged){sbParameter.Append("FR_OpDate=@FR_OpDate, ");}
      if(fax_Record.FR_OpRemark_IsChanged){sbParameter.Append("FR_OpRemark=@FR_OpRemark, ");}
      if(fax_Record.FR_TranferCompany_IsChanged){sbParameter.Append("FR_TranferCompany=@FR_TranferCompany, ");}
      if(fax_Record.FR_TranferDept_IsChanged){sbParameter.Append("FR_TranferDept=@FR_TranferDept, ");}
      if(fax_Record.FR_TranferRemark_IsChanged){sbParameter.Append("FR_TranferRemark=@FR_TranferRemark, ");}
      if(fax_Record.FR_TranferDate_IsChanged){sbParameter.Append("FR_TranferDate=@FR_TranferDate, ");}
      if(fax_Record.FR_Company_IsChanged){sbParameter.Append("FR_Company=@FR_Company, ");}
      if(fax_Record.FR_Dept_IsChanged){sbParameter.Append("FR_Dept=@FR_Dept, ");}
      if(fax_Record.FR_Stat_IsChanged){sbParameter.Append("FR_Stat=@FR_Stat, ");}
      if(fax_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(fax_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(fax_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(fax_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FR_ID=@FR_ID; " );
      string sql=sb.ToString();
         if(fax_Record.FR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_Code))
         {
            idb.AddParameter("@FR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Code", fax_Record.FR_Code);
         }
          }
         if(fax_Record.FR_Date_IsChanged)
         {
         if (fax_Record.FR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Date", fax_Record.FR_Date);
         }
          }
         if(fax_Record.FR_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_Content))
         {
            idb.AddParameter("@FR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Content", fax_Record.FR_Content);
         }
          }
         if(fax_Record.FR_Category_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_Category))
         {
            idb.AddParameter("@FR_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Category", fax_Record.FR_Category);
         }
          }
         if(fax_Record.FR_Num_IsChanged)
         {
         if (fax_Record.FR_Num == 0)
         {
            idb.AddParameter("@FR_Num", 0);
         }
         else
         {
            idb.AddParameter("@FR_Num", fax_Record.FR_Num);
         }
          }
         if(fax_Record.FR_PageNum_IsChanged)
         {
         if (fax_Record.FR_PageNum == 0)
         {
            idb.AddParameter("@FR_PageNum", 0);
         }
         else
         {
            idb.AddParameter("@FR_PageNum", fax_Record.FR_PageNum);
         }
          }
         if(fax_Record.FR_Amount_IsChanged)
         {
         if (fax_Record.FR_Amount == 0)
         {
            idb.AddParameter("@FR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@FR_Amount", fax_Record.FR_Amount);
         }
          }
         if(fax_Record.FR_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_Operator))
         {
            idb.AddParameter("@FR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Operator", fax_Record.FR_Operator);
         }
          }
         if(fax_Record.FR_OpDate_IsChanged)
         {
         if (fax_Record.FR_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@FR_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_OpDate", fax_Record.FR_OpDate);
         }
          }
         if(fax_Record.FR_OpRemark_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_OpRemark))
         {
            idb.AddParameter("@FR_OpRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_OpRemark", fax_Record.FR_OpRemark);
         }
          }
         if(fax_Record.FR_TranferCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_TranferCompany))
         {
            idb.AddParameter("@FR_TranferCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferCompany", fax_Record.FR_TranferCompany);
         }
          }
         if(fax_Record.FR_TranferDept_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_TranferDept))
         {
            idb.AddParameter("@FR_TranferDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferDept", fax_Record.FR_TranferDept);
         }
          }
         if(fax_Record.FR_TranferRemark_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_TranferRemark))
         {
            idb.AddParameter("@FR_TranferRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferRemark", fax_Record.FR_TranferRemark);
         }
          }
         if(fax_Record.FR_TranferDate_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_TranferDate))
         {
            idb.AddParameter("@FR_TranferDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_TranferDate", fax_Record.FR_TranferDate);
         }
          }
         if(fax_Record.FR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_Company))
         {
            idb.AddParameter("@FR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Company", fax_Record.FR_Company);
         }
          }
         if(fax_Record.FR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_Dept))
         {
            idb.AddParameter("@FR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Dept", fax_Record.FR_Dept);
         }
          }
         if(fax_Record.FR_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(fax_Record.FR_Stat))
         {
            idb.AddParameter("@FR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Stat", fax_Record.FR_Stat);
         }
          }
         if(fax_Record.Stat_IsChanged)
         {
         if (fax_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fax_Record.Stat);
         }
          }
         if(fax_Record.CreateDate_IsChanged)
         {
         if (fax_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", fax_Record.CreateDate);
         }
          }
         if(fax_Record.UpdateDate_IsChanged)
         {
         if (fax_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", fax_Record.UpdateDate);
         }
          }
         if(fax_Record.DeleteDate_IsChanged)
         {
         if (fax_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", fax_Record.DeleteDate);
         }
          }

         idb.AddParameter("@FR_ID", fax_Record.FR_ID);

           
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
      /// 删除传真登记信息 Fax_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal fR_ID)
      {
         string sql = "DELETE Fax_Record WHERE 1=1  AND FR_ID=@FR_ID ";
         idb.AddParameter("@FR_ID", fR_ID);

           
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
      /// 获取指定的传真登记信息 Fax_Record对象(即:一条记录
      /// </summary>
      public Fax_Record GetByKey(decimal fR_ID)
      {
         Fax_Record fax_Record = new Fax_Record();
         string sql = "SELECT  FR_ID,FR_Code,FR_Date,FR_Content,FR_Category,FR_Num,FR_PageNum,FR_Amount,FR_Operator,FR_OpDate,FR_OpRemark,FR_TranferCompany,FR_TranferDept,FR_TranferRemark,FR_TranferDate,FR_Company,FR_Dept,FR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM Fax_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FR_ID=@FR_ID ";
         idb.AddParameter("@FR_ID", fR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FR_ID"] != DBNull.Value) fax_Record.FR_ID = Convert.ToDecimal(dr["FR_ID"]);
            if (dr["FR_Code"] != DBNull.Value) fax_Record.FR_Code = Convert.ToString(dr["FR_Code"]);
            if (dr["FR_Date"] != DBNull.Value) fax_Record.FR_Date = Convert.ToDateTime(dr["FR_Date"]);
            if (dr["FR_Content"] != DBNull.Value) fax_Record.FR_Content = Convert.ToString(dr["FR_Content"]);
            if (dr["FR_Category"] != DBNull.Value) fax_Record.FR_Category = Convert.ToString(dr["FR_Category"]);
            if (dr["FR_Num"] != DBNull.Value) fax_Record.FR_Num = Convert.ToInt32(dr["FR_Num"]);
            if (dr["FR_PageNum"] != DBNull.Value) fax_Record.FR_PageNum = Convert.ToInt32(dr["FR_PageNum"]);
            if (dr["FR_Amount"] != DBNull.Value) fax_Record.FR_Amount = Convert.ToDecimal(dr["FR_Amount"]);
            if (dr["FR_Operator"] != DBNull.Value) fax_Record.FR_Operator = Convert.ToString(dr["FR_Operator"]);
            if (dr["FR_OpDate"] != DBNull.Value) fax_Record.FR_OpDate = Convert.ToDateTime(dr["FR_OpDate"]);
            if (dr["FR_OpRemark"] != DBNull.Value) fax_Record.FR_OpRemark = Convert.ToString(dr["FR_OpRemark"]);
            if (dr["FR_TranferCompany"] != DBNull.Value) fax_Record.FR_TranferCompany = Convert.ToString(dr["FR_TranferCompany"]);
            if (dr["FR_TranferDept"] != DBNull.Value) fax_Record.FR_TranferDept = Convert.ToString(dr["FR_TranferDept"]);
            if (dr["FR_TranferRemark"] != DBNull.Value) fax_Record.FR_TranferRemark = Convert.ToString(dr["FR_TranferRemark"]);
            if (dr["FR_TranferDate"] != DBNull.Value) fax_Record.FR_TranferDate = Convert.ToString(dr["FR_TranferDate"]);
            if (dr["FR_Company"] != DBNull.Value) fax_Record.FR_Company = Convert.ToString(dr["FR_Company"]);
            if (dr["FR_Dept"] != DBNull.Value) fax_Record.FR_Dept = Convert.ToString(dr["FR_Dept"]);
            if (dr["FR_Stat"] != DBNull.Value) fax_Record.FR_Stat = Convert.ToString(dr["FR_Stat"]);
            if (dr["Stat"] != DBNull.Value) fax_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) fax_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) fax_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) fax_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return fax_Record;
      }
      /// <summary>
      /// 获取指定的传真登记信息 Fax_Record对象集合
      /// </summary>
      public List<Fax_Record> GetListByWhere(string strCondition)
      {
         List<Fax_Record> ret = new List<Fax_Record>();
         string sql = "SELECT  FR_ID,FR_Code,FR_Date,FR_Content,FR_Category,FR_Num,FR_PageNum,FR_Amount,FR_Operator,FR_OpDate,FR_OpRemark,FR_TranferCompany,FR_TranferDept,FR_TranferRemark,FR_TranferDate,FR_Company,FR_Dept,FR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM Fax_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Fax_Record fax_Record = new Fax_Record();
            if (dr["FR_ID"] != DBNull.Value) fax_Record.FR_ID = Convert.ToDecimal(dr["FR_ID"]);
            if (dr["FR_Code"] != DBNull.Value) fax_Record.FR_Code = Convert.ToString(dr["FR_Code"]);
            if (dr["FR_Date"] != DBNull.Value) fax_Record.FR_Date = Convert.ToDateTime(dr["FR_Date"]);
            if (dr["FR_Content"] != DBNull.Value) fax_Record.FR_Content = Convert.ToString(dr["FR_Content"]);
            if (dr["FR_Category"] != DBNull.Value) fax_Record.FR_Category = Convert.ToString(dr["FR_Category"]);
            if (dr["FR_Num"] != DBNull.Value) fax_Record.FR_Num = Convert.ToInt32(dr["FR_Num"]);
            if (dr["FR_PageNum"] != DBNull.Value) fax_Record.FR_PageNum = Convert.ToInt32(dr["FR_PageNum"]);
            if (dr["FR_Amount"] != DBNull.Value) fax_Record.FR_Amount = Convert.ToDecimal(dr["FR_Amount"]);
            if (dr["FR_Operator"] != DBNull.Value) fax_Record.FR_Operator = Convert.ToString(dr["FR_Operator"]);
            if (dr["FR_OpDate"] != DBNull.Value) fax_Record.FR_OpDate = Convert.ToDateTime(dr["FR_OpDate"]);
            if (dr["FR_OpRemark"] != DBNull.Value) fax_Record.FR_OpRemark = Convert.ToString(dr["FR_OpRemark"]);
            if (dr["FR_TranferCompany"] != DBNull.Value) fax_Record.FR_TranferCompany = Convert.ToString(dr["FR_TranferCompany"]);
            if (dr["FR_TranferDept"] != DBNull.Value) fax_Record.FR_TranferDept = Convert.ToString(dr["FR_TranferDept"]);
            if (dr["FR_TranferRemark"] != DBNull.Value) fax_Record.FR_TranferRemark = Convert.ToString(dr["FR_TranferRemark"]);
            if (dr["FR_TranferDate"] != DBNull.Value) fax_Record.FR_TranferDate = Convert.ToString(dr["FR_TranferDate"]);
            if (dr["FR_Company"] != DBNull.Value) fax_Record.FR_Company = Convert.ToString(dr["FR_Company"]);
            if (dr["FR_Dept"] != DBNull.Value) fax_Record.FR_Dept = Convert.ToString(dr["FR_Dept"]);
            if (dr["FR_Stat"] != DBNull.Value) fax_Record.FR_Stat = Convert.ToString(dr["FR_Stat"]);
            if (dr["Stat"] != DBNull.Value) fax_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) fax_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) fax_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) fax_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(fax_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的传真登记信息 Fax_Record对象(即:一条记录
      /// </summary>
      public List<Fax_Record> GetAll()
      {
         List<Fax_Record> ret = new List<Fax_Record>();
         string sql = "SELECT  FR_ID,FR_Code,FR_Date,FR_Content,FR_Category,FR_Num,FR_PageNum,FR_Amount,FR_Operator,FR_OpDate,FR_OpRemark,FR_TranferCompany,FR_TranferDept,FR_TranferRemark,FR_TranferDate,FR_Company,FR_Dept,FR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM Fax_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by FR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Fax_Record fax_Record = new Fax_Record();
            if (dr["FR_ID"] != DBNull.Value) fax_Record.FR_ID = Convert.ToDecimal(dr["FR_ID"]);
            if (dr["FR_Code"] != DBNull.Value) fax_Record.FR_Code = Convert.ToString(dr["FR_Code"]);
            if (dr["FR_Date"] != DBNull.Value) fax_Record.FR_Date = Convert.ToDateTime(dr["FR_Date"]);
            if (dr["FR_Content"] != DBNull.Value) fax_Record.FR_Content = Convert.ToString(dr["FR_Content"]);
            if (dr["FR_Category"] != DBNull.Value) fax_Record.FR_Category = Convert.ToString(dr["FR_Category"]);
            if (dr["FR_Num"] != DBNull.Value) fax_Record.FR_Num = Convert.ToInt32(dr["FR_Num"]);
            if (dr["FR_PageNum"] != DBNull.Value) fax_Record.FR_PageNum = Convert.ToInt32(dr["FR_PageNum"]);
            if (dr["FR_Amount"] != DBNull.Value) fax_Record.FR_Amount = Convert.ToDecimal(dr["FR_Amount"]);
            if (dr["FR_Operator"] != DBNull.Value) fax_Record.FR_Operator = Convert.ToString(dr["FR_Operator"]);
            if (dr["FR_OpDate"] != DBNull.Value) fax_Record.FR_OpDate = Convert.ToDateTime(dr["FR_OpDate"]);
            if (dr["FR_OpRemark"] != DBNull.Value) fax_Record.FR_OpRemark = Convert.ToString(dr["FR_OpRemark"]);
            if (dr["FR_TranferCompany"] != DBNull.Value) fax_Record.FR_TranferCompany = Convert.ToString(dr["FR_TranferCompany"]);
            if (dr["FR_TranferDept"] != DBNull.Value) fax_Record.FR_TranferDept = Convert.ToString(dr["FR_TranferDept"]);
            if (dr["FR_TranferRemark"] != DBNull.Value) fax_Record.FR_TranferRemark = Convert.ToString(dr["FR_TranferRemark"]);
            if (dr["FR_TranferDate"] != DBNull.Value) fax_Record.FR_TranferDate = Convert.ToString(dr["FR_TranferDate"]);
            if (dr["FR_Company"] != DBNull.Value) fax_Record.FR_Company = Convert.ToString(dr["FR_Company"]);
            if (dr["FR_Dept"] != DBNull.Value) fax_Record.FR_Dept = Convert.ToString(dr["FR_Dept"]);
            if (dr["FR_Stat"] != DBNull.Value) fax_Record.FR_Stat = Convert.ToString(dr["FR_Stat"]);
            if (dr["Stat"] != DBNull.Value) fax_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) fax_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) fax_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) fax_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(fax_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
