using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOTC_Equ
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加TC_Equ对象(即:一条记录)
      /// </summary>
      public int Add(TC_Equ tC_Equ)
      {
         string sql = "INSERT INTO TC_Equ (TCE_Code,TCE_ECode,TCE_Spec,TCE_Date,TCE_Checker,TCE_CheckDate,TCE_Operator,TCE_OpDate,TCE_Company,TCE_Dept,TCE_Description,TCE_Remark,TCE_UDef1,TCE_UDef2,TCE_UDef3,TCE_UDef4,TCE_UDef5,TCE_UDef6,TCE_TCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCE_Code,@TCE_ECode,@TCE_Spec,@TCE_Date,@TCE_Checker,@TCE_CheckDate,@TCE_Operator,@TCE_OpDate,@TCE_Company,@TCE_Dept,@TCE_Description,@TCE_Remark,@TCE_UDef1,@TCE_UDef2,@TCE_UDef3,@TCE_UDef4,@TCE_UDef5,@TCE_UDef6,@TCE_TCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_Equ.TCE_Code))
         {
            idb.AddParameter("@TCE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Code", tC_Equ.TCE_Code);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_ECode))
         {
            idb.AddParameter("@TCE_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_ECode", tC_Equ.TCE_ECode);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Spec))
         {
            idb.AddParameter("@TCE_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Spec", tC_Equ.TCE_Spec);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Date))
         {
            idb.AddParameter("@TCE_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Date", tC_Equ.TCE_Date);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Checker))
         {
            idb.AddParameter("@TCE_Checker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Checker", tC_Equ.TCE_Checker);
         }
         if (tC_Equ.TCE_CheckDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCE_CheckDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_CheckDate", tC_Equ.TCE_CheckDate);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Operator))
         {
            idb.AddParameter("@TCE_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Operator", tC_Equ.TCE_Operator);
         }
         if (tC_Equ.TCE_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCE_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_OpDate", tC_Equ.TCE_OpDate);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Company))
         {
            idb.AddParameter("@TCE_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Company", tC_Equ.TCE_Company);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Dept))
         {
            idb.AddParameter("@TCE_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Dept", tC_Equ.TCE_Dept);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Description))
         {
            idb.AddParameter("@TCE_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Description", tC_Equ.TCE_Description);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Remark))
         {
            idb.AddParameter("@TCE_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Remark", tC_Equ.TCE_Remark);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef1))
         {
            idb.AddParameter("@TCE_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef1", tC_Equ.TCE_UDef1);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef2))
         {
            idb.AddParameter("@TCE_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef2", tC_Equ.TCE_UDef2);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef3))
         {
            idb.AddParameter("@TCE_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef3", tC_Equ.TCE_UDef3);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef4))
         {
            idb.AddParameter("@TCE_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef4", tC_Equ.TCE_UDef4);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef5))
         {
            idb.AddParameter("@TCE_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef5", tC_Equ.TCE_UDef5);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef6))
         {
            idb.AddParameter("@TCE_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef6", tC_Equ.TCE_UDef6);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_TCode))
         {
            idb.AddParameter("@TCE_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_TCode", tC_Equ.TCE_TCode);
         }
         if (tC_Equ.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Equ.Stat);
         }
         if (tC_Equ.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Equ.CreateDate);
         }
         if (tC_Equ.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Equ.UpdateDate);
         }
         if (tC_Equ.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Equ.DeleteDate);
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
      /// 添加TC_Equ对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_Equ tC_Equ)
      {
         string sql = "INSERT INTO TC_Equ (TCE_Code,TCE_ECode,TCE_Spec,TCE_Date,TCE_Checker,TCE_CheckDate,TCE_Operator,TCE_OpDate,TCE_Company,TCE_Dept,TCE_Description,TCE_Remark,TCE_UDef1,TCE_UDef2,TCE_UDef3,TCE_UDef4,TCE_UDef5,TCE_UDef6,TCE_TCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCE_Code,@TCE_ECode,@TCE_Spec,@TCE_Date,@TCE_Checker,@TCE_CheckDate,@TCE_Operator,@TCE_OpDate,@TCE_Company,@TCE_Dept,@TCE_Description,@TCE_Remark,@TCE_UDef1,@TCE_UDef2,@TCE_UDef3,@TCE_UDef4,@TCE_UDef5,@TCE_UDef6,@TCE_TCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_Equ.TCE_Code))
         {
            idb.AddParameter("@TCE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Code", tC_Equ.TCE_Code);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_ECode))
         {
            idb.AddParameter("@TCE_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_ECode", tC_Equ.TCE_ECode);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Spec))
         {
            idb.AddParameter("@TCE_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Spec", tC_Equ.TCE_Spec);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Date))
         {
            idb.AddParameter("@TCE_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Date", tC_Equ.TCE_Date);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Checker))
         {
            idb.AddParameter("@TCE_Checker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Checker", tC_Equ.TCE_Checker);
         }
         if (tC_Equ.TCE_CheckDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCE_CheckDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_CheckDate", tC_Equ.TCE_CheckDate);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Operator))
         {
            idb.AddParameter("@TCE_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Operator", tC_Equ.TCE_Operator);
         }
         if (tC_Equ.TCE_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCE_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_OpDate", tC_Equ.TCE_OpDate);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Company))
         {
            idb.AddParameter("@TCE_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Company", tC_Equ.TCE_Company);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Dept))
         {
            idb.AddParameter("@TCE_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Dept", tC_Equ.TCE_Dept);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Description))
         {
            idb.AddParameter("@TCE_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Description", tC_Equ.TCE_Description);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_Remark))
         {
            idb.AddParameter("@TCE_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Remark", tC_Equ.TCE_Remark);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef1))
         {
            idb.AddParameter("@TCE_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef1", tC_Equ.TCE_UDef1);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef2))
         {
            idb.AddParameter("@TCE_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef2", tC_Equ.TCE_UDef2);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef3))
         {
            idb.AddParameter("@TCE_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef3", tC_Equ.TCE_UDef3);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef4))
         {
            idb.AddParameter("@TCE_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef4", tC_Equ.TCE_UDef4);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef5))
         {
            idb.AddParameter("@TCE_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef5", tC_Equ.TCE_UDef5);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef6))
         {
            idb.AddParameter("@TCE_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef6", tC_Equ.TCE_UDef6);
         }
         if (string.IsNullOrEmpty(tC_Equ.TCE_TCode))
         {
            idb.AddParameter("@TCE_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_TCode", tC_Equ.TCE_TCode);
         }
         if (tC_Equ.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Equ.Stat);
         }
         if (tC_Equ.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Equ.CreateDate);
         }
         if (tC_Equ.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Equ.UpdateDate);
         }
         if (tC_Equ.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Equ.DeleteDate);
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
      /// 更新TC_Equ对象(即:一条记录
      /// </summary>
      public int Update(TC_Equ tC_Equ)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_Equ       SET ");
            if(tC_Equ.TCE_Code_IsChanged){sbParameter.Append("TCE_Code=@TCE_Code, ");}
      if(tC_Equ.TCE_ECode_IsChanged){sbParameter.Append("TCE_ECode=@TCE_ECode, ");}
      if(tC_Equ.TCE_Spec_IsChanged){sbParameter.Append("TCE_Spec=@TCE_Spec, ");}
      if(tC_Equ.TCE_Date_IsChanged){sbParameter.Append("TCE_Date=@TCE_Date, ");}
      if(tC_Equ.TCE_Checker_IsChanged){sbParameter.Append("TCE_Checker=@TCE_Checker, ");}
      if(tC_Equ.TCE_CheckDate_IsChanged){sbParameter.Append("TCE_CheckDate=@TCE_CheckDate, ");}
      if(tC_Equ.TCE_Operator_IsChanged){sbParameter.Append("TCE_Operator=@TCE_Operator, ");}
      if(tC_Equ.TCE_OpDate_IsChanged){sbParameter.Append("TCE_OpDate=@TCE_OpDate, ");}
      if(tC_Equ.TCE_Company_IsChanged){sbParameter.Append("TCE_Company=@TCE_Company, ");}
      if(tC_Equ.TCE_Dept_IsChanged){sbParameter.Append("TCE_Dept=@TCE_Dept, ");}
      if(tC_Equ.TCE_Description_IsChanged){sbParameter.Append("TCE_Description=@TCE_Description, ");}
      if(tC_Equ.TCE_Remark_IsChanged){sbParameter.Append("TCE_Remark=@TCE_Remark, ");}
      if(tC_Equ.TCE_UDef1_IsChanged){sbParameter.Append("TCE_UDef1=@TCE_UDef1, ");}
      if(tC_Equ.TCE_UDef2_IsChanged){sbParameter.Append("TCE_UDef2=@TCE_UDef2, ");}
      if(tC_Equ.TCE_UDef3_IsChanged){sbParameter.Append("TCE_UDef3=@TCE_UDef3, ");}
      if(tC_Equ.TCE_UDef4_IsChanged){sbParameter.Append("TCE_UDef4=@TCE_UDef4, ");}
      if(tC_Equ.TCE_UDef5_IsChanged){sbParameter.Append("TCE_UDef5=@TCE_UDef5, ");}
      if(tC_Equ.TCE_UDef6_IsChanged){sbParameter.Append("TCE_UDef6=@TCE_UDef6, ");}
      if(tC_Equ.TCE_TCode_IsChanged){sbParameter.Append("TCE_TCode=@TCE_TCode, ");}
      if(tC_Equ.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_Equ.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_Equ.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_Equ.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCE_ID=@TCE_ID; " );
      string sql=sb.ToString();
         if(tC_Equ.TCE_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Code))
         {
            idb.AddParameter("@TCE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Code", tC_Equ.TCE_Code);
         }
          }
         if(tC_Equ.TCE_ECode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_ECode))
         {
            idb.AddParameter("@TCE_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_ECode", tC_Equ.TCE_ECode);
         }
          }
         if(tC_Equ.TCE_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Spec))
         {
            idb.AddParameter("@TCE_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Spec", tC_Equ.TCE_Spec);
         }
          }
         if(tC_Equ.TCE_Date_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Date))
         {
            idb.AddParameter("@TCE_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Date", tC_Equ.TCE_Date);
         }
          }
         if(tC_Equ.TCE_Checker_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Checker))
         {
            idb.AddParameter("@TCE_Checker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Checker", tC_Equ.TCE_Checker);
         }
          }
         if(tC_Equ.TCE_CheckDate_IsChanged)
         {
         if (tC_Equ.TCE_CheckDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCE_CheckDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_CheckDate", tC_Equ.TCE_CheckDate);
         }
          }
         if(tC_Equ.TCE_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Operator))
         {
            idb.AddParameter("@TCE_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Operator", tC_Equ.TCE_Operator);
         }
          }
         if(tC_Equ.TCE_OpDate_IsChanged)
         {
         if (tC_Equ.TCE_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCE_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_OpDate", tC_Equ.TCE_OpDate);
         }
          }
         if(tC_Equ.TCE_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Company))
         {
            idb.AddParameter("@TCE_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Company", tC_Equ.TCE_Company);
         }
          }
         if(tC_Equ.TCE_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Dept))
         {
            idb.AddParameter("@TCE_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Dept", tC_Equ.TCE_Dept);
         }
          }
         if(tC_Equ.TCE_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Description))
         {
            idb.AddParameter("@TCE_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Description", tC_Equ.TCE_Description);
         }
          }
         if(tC_Equ.TCE_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_Remark))
         {
            idb.AddParameter("@TCE_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_Remark", tC_Equ.TCE_Remark);
         }
          }
         if(tC_Equ.TCE_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef1))
         {
            idb.AddParameter("@TCE_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef1", tC_Equ.TCE_UDef1);
         }
          }
         if(tC_Equ.TCE_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef2))
         {
            idb.AddParameter("@TCE_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef2", tC_Equ.TCE_UDef2);
         }
          }
         if(tC_Equ.TCE_UDef3_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef3))
         {
            idb.AddParameter("@TCE_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef3", tC_Equ.TCE_UDef3);
         }
          }
         if(tC_Equ.TCE_UDef4_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef4))
         {
            idb.AddParameter("@TCE_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef4", tC_Equ.TCE_UDef4);
         }
          }
         if(tC_Equ.TCE_UDef5_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef5))
         {
            idb.AddParameter("@TCE_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef5", tC_Equ.TCE_UDef5);
         }
          }
         if(tC_Equ.TCE_UDef6_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_UDef6))
         {
            idb.AddParameter("@TCE_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_UDef6", tC_Equ.TCE_UDef6);
         }
          }
         if(tC_Equ.TCE_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Equ.TCE_TCode))
         {
            idb.AddParameter("@TCE_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCE_TCode", tC_Equ.TCE_TCode);
         }
          }
         if(tC_Equ.Stat_IsChanged)
         {
         if (tC_Equ.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Equ.Stat);
         }
          }
         if(tC_Equ.CreateDate_IsChanged)
         {
         if (tC_Equ.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Equ.CreateDate);
         }
          }
         if(tC_Equ.UpdateDate_IsChanged)
         {
         if (tC_Equ.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Equ.UpdateDate);
         }
          }
         if(tC_Equ.DeleteDate_IsChanged)
         {
         if (tC_Equ.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Equ.DeleteDate);
         }
          }

         idb.AddParameter("@TCE_ID", tC_Equ.TCE_ID);

           
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
      /// 删除TC_Equ对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCE_ID)
      {
         string sql = "DELETE TC_Equ WHERE 1=1  AND TCE_ID=@TCE_ID ";
         idb.AddParameter("@TCE_ID", tCE_ID);

           
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
      /// 获取指定的TC_Equ对象(即:一条记录
      /// </summary>
      public TC_Equ GetByKey(decimal tCE_ID)
      {
         TC_Equ tC_Equ = new TC_Equ();
         string sql = "SELECT  TCE_ID,TCE_Code,TCE_ECode,TCE_Spec,TCE_Date,TCE_Checker,TCE_CheckDate,TCE_Operator,TCE_OpDate,TCE_Company,TCE_Dept,TCE_Description,TCE_Remark,TCE_UDef1,TCE_UDef2,TCE_UDef3,TCE_UDef4,TCE_UDef5,TCE_UDef6,TCE_TCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Equ WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCE_ID=@TCE_ID ";
         idb.AddParameter("@TCE_ID", tCE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCE_ID"] != DBNull.Value) tC_Equ.TCE_ID = Convert.ToDecimal(dr["TCE_ID"]);
            if (dr["TCE_Code"] != DBNull.Value) tC_Equ.TCE_Code = Convert.ToString(dr["TCE_Code"]);
            if (dr["TCE_ECode"] != DBNull.Value) tC_Equ.TCE_ECode = Convert.ToString(dr["TCE_ECode"]);
            if (dr["TCE_Spec"] != DBNull.Value) tC_Equ.TCE_Spec = Convert.ToString(dr["TCE_Spec"]);
            if (dr["TCE_Date"] != DBNull.Value) tC_Equ.TCE_Date = Convert.ToString(dr["TCE_Date"]);
            if (dr["TCE_Checker"] != DBNull.Value) tC_Equ.TCE_Checker = Convert.ToString(dr["TCE_Checker"]);
            if (dr["TCE_CheckDate"] != DBNull.Value) tC_Equ.TCE_CheckDate = Convert.ToDateTime(dr["TCE_CheckDate"]);
            if (dr["TCE_Operator"] != DBNull.Value) tC_Equ.TCE_Operator = Convert.ToString(dr["TCE_Operator"]);
            if (dr["TCE_OpDate"] != DBNull.Value) tC_Equ.TCE_OpDate = Convert.ToDateTime(dr["TCE_OpDate"]);
            if (dr["TCE_Company"] != DBNull.Value) tC_Equ.TCE_Company = Convert.ToString(dr["TCE_Company"]);
            if (dr["TCE_Dept"] != DBNull.Value) tC_Equ.TCE_Dept = Convert.ToString(dr["TCE_Dept"]);
            if (dr["TCE_Description"] != DBNull.Value) tC_Equ.TCE_Description = Convert.ToString(dr["TCE_Description"]);
            if (dr["TCE_Remark"] != DBNull.Value) tC_Equ.TCE_Remark = Convert.ToString(dr["TCE_Remark"]);
            if (dr["TCE_UDef1"] != DBNull.Value) tC_Equ.TCE_UDef1 = Convert.ToString(dr["TCE_UDef1"]);
            if (dr["TCE_UDef2"] != DBNull.Value) tC_Equ.TCE_UDef2 = Convert.ToString(dr["TCE_UDef2"]);
            if (dr["TCE_UDef3"] != DBNull.Value) tC_Equ.TCE_UDef3 = Convert.ToString(dr["TCE_UDef3"]);
            if (dr["TCE_UDef4"] != DBNull.Value) tC_Equ.TCE_UDef4 = Convert.ToString(dr["TCE_UDef4"]);
            if (dr["TCE_UDef5"] != DBNull.Value) tC_Equ.TCE_UDef5 = Convert.ToString(dr["TCE_UDef5"]);
            if (dr["TCE_UDef6"] != DBNull.Value) tC_Equ.TCE_UDef6 = Convert.ToString(dr["TCE_UDef6"]);
            if (dr["TCE_TCode"] != DBNull.Value) tC_Equ.TCE_TCode = Convert.ToString(dr["TCE_TCode"]);
            if (dr["Stat"] != DBNull.Value) tC_Equ.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Equ.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Equ.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Equ.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_Equ;
      }
      /// <summary>
      /// 获取指定的TC_Equ对象集合
      /// </summary>
      public List<TC_Equ> GetListByWhere(string strCondition)
      {
         List<TC_Equ> ret = new List<TC_Equ>();
         string sql = "SELECT  TCE_ID,TCE_Code,TCE_ECode,TCE_Spec,TCE_Date,TCE_Checker,TCE_CheckDate,TCE_Operator,TCE_OpDate,TCE_Company,TCE_Dept,TCE_Description,TCE_Remark,TCE_UDef1,TCE_UDef2,TCE_UDef3,TCE_UDef4,TCE_UDef5,TCE_UDef6,TCE_TCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Equ WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_Equ tC_Equ = new TC_Equ();
            if (dr["TCE_ID"] != DBNull.Value) tC_Equ.TCE_ID = Convert.ToDecimal(dr["TCE_ID"]);
            if (dr["TCE_Code"] != DBNull.Value) tC_Equ.TCE_Code = Convert.ToString(dr["TCE_Code"]);
            if (dr["TCE_ECode"] != DBNull.Value) tC_Equ.TCE_ECode = Convert.ToString(dr["TCE_ECode"]);
            if (dr["TCE_Spec"] != DBNull.Value) tC_Equ.TCE_Spec = Convert.ToString(dr["TCE_Spec"]);
            if (dr["TCE_Date"] != DBNull.Value) tC_Equ.TCE_Date = Convert.ToString(dr["TCE_Date"]);
            if (dr["TCE_Checker"] != DBNull.Value) tC_Equ.TCE_Checker = Convert.ToString(dr["TCE_Checker"]);
            if (dr["TCE_CheckDate"] != DBNull.Value) tC_Equ.TCE_CheckDate = Convert.ToDateTime(dr["TCE_CheckDate"]);
            if (dr["TCE_Operator"] != DBNull.Value) tC_Equ.TCE_Operator = Convert.ToString(dr["TCE_Operator"]);
            if (dr["TCE_OpDate"] != DBNull.Value) tC_Equ.TCE_OpDate = Convert.ToDateTime(dr["TCE_OpDate"]);
            if (dr["TCE_Company"] != DBNull.Value) tC_Equ.TCE_Company = Convert.ToString(dr["TCE_Company"]);
            if (dr["TCE_Dept"] != DBNull.Value) tC_Equ.TCE_Dept = Convert.ToString(dr["TCE_Dept"]);
            if (dr["TCE_Description"] != DBNull.Value) tC_Equ.TCE_Description = Convert.ToString(dr["TCE_Description"]);
            if (dr["TCE_Remark"] != DBNull.Value) tC_Equ.TCE_Remark = Convert.ToString(dr["TCE_Remark"]);
            if (dr["TCE_UDef1"] != DBNull.Value) tC_Equ.TCE_UDef1 = Convert.ToString(dr["TCE_UDef1"]);
            if (dr["TCE_UDef2"] != DBNull.Value) tC_Equ.TCE_UDef2 = Convert.ToString(dr["TCE_UDef2"]);
            if (dr["TCE_UDef3"] != DBNull.Value) tC_Equ.TCE_UDef3 = Convert.ToString(dr["TCE_UDef3"]);
            if (dr["TCE_UDef4"] != DBNull.Value) tC_Equ.TCE_UDef4 = Convert.ToString(dr["TCE_UDef4"]);
            if (dr["TCE_UDef5"] != DBNull.Value) tC_Equ.TCE_UDef5 = Convert.ToString(dr["TCE_UDef5"]);
            if (dr["TCE_UDef6"] != DBNull.Value) tC_Equ.TCE_UDef6 = Convert.ToString(dr["TCE_UDef6"]);
            if (dr["TCE_TCode"] != DBNull.Value) tC_Equ.TCE_TCode = Convert.ToString(dr["TCE_TCode"]);
            if (dr["Stat"] != DBNull.Value) tC_Equ.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Equ.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Equ.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Equ.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_Equ);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的TC_Equ对象(即:一条记录
      /// </summary>
      public List<TC_Equ> GetAll()
      {
         List<TC_Equ> ret = new List<TC_Equ>();
         string sql = "SELECT  TCE_ID,TCE_Code,TCE_ECode,TCE_Spec,TCE_Date,TCE_Checker,TCE_CheckDate,TCE_Operator,TCE_OpDate,TCE_Company,TCE_Dept,TCE_Description,TCE_Remark,TCE_UDef1,TCE_UDef2,TCE_UDef3,TCE_UDef4,TCE_UDef5,TCE_UDef6,TCE_TCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Equ where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCE_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_Equ tC_Equ = new TC_Equ();
            if (dr["TCE_ID"] != DBNull.Value) tC_Equ.TCE_ID = Convert.ToDecimal(dr["TCE_ID"]);
            if (dr["TCE_Code"] != DBNull.Value) tC_Equ.TCE_Code = Convert.ToString(dr["TCE_Code"]);
            if (dr["TCE_ECode"] != DBNull.Value) tC_Equ.TCE_ECode = Convert.ToString(dr["TCE_ECode"]);
            if (dr["TCE_Spec"] != DBNull.Value) tC_Equ.TCE_Spec = Convert.ToString(dr["TCE_Spec"]);
            if (dr["TCE_Date"] != DBNull.Value) tC_Equ.TCE_Date = Convert.ToString(dr["TCE_Date"]);
            if (dr["TCE_Checker"] != DBNull.Value) tC_Equ.TCE_Checker = Convert.ToString(dr["TCE_Checker"]);
            if (dr["TCE_CheckDate"] != DBNull.Value) tC_Equ.TCE_CheckDate = Convert.ToDateTime(dr["TCE_CheckDate"]);
            if (dr["TCE_Operator"] != DBNull.Value) tC_Equ.TCE_Operator = Convert.ToString(dr["TCE_Operator"]);
            if (dr["TCE_OpDate"] != DBNull.Value) tC_Equ.TCE_OpDate = Convert.ToDateTime(dr["TCE_OpDate"]);
            if (dr["TCE_Company"] != DBNull.Value) tC_Equ.TCE_Company = Convert.ToString(dr["TCE_Company"]);
            if (dr["TCE_Dept"] != DBNull.Value) tC_Equ.TCE_Dept = Convert.ToString(dr["TCE_Dept"]);
            if (dr["TCE_Description"] != DBNull.Value) tC_Equ.TCE_Description = Convert.ToString(dr["TCE_Description"]);
            if (dr["TCE_Remark"] != DBNull.Value) tC_Equ.TCE_Remark = Convert.ToString(dr["TCE_Remark"]);
            if (dr["TCE_UDef1"] != DBNull.Value) tC_Equ.TCE_UDef1 = Convert.ToString(dr["TCE_UDef1"]);
            if (dr["TCE_UDef2"] != DBNull.Value) tC_Equ.TCE_UDef2 = Convert.ToString(dr["TCE_UDef2"]);
            if (dr["TCE_UDef3"] != DBNull.Value) tC_Equ.TCE_UDef3 = Convert.ToString(dr["TCE_UDef3"]);
            if (dr["TCE_UDef4"] != DBNull.Value) tC_Equ.TCE_UDef4 = Convert.ToString(dr["TCE_UDef4"]);
            if (dr["TCE_UDef5"] != DBNull.Value) tC_Equ.TCE_UDef5 = Convert.ToString(dr["TCE_UDef5"]);
            if (dr["TCE_UDef6"] != DBNull.Value) tC_Equ.TCE_UDef6 = Convert.ToString(dr["TCE_UDef6"]);
            if (dr["TCE_TCode"] != DBNull.Value) tC_Equ.TCE_TCode = Convert.ToString(dr["TCE_TCode"]);
            if (dr["Stat"] != DBNull.Value) tC_Equ.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Equ.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Equ.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Equ.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_Equ);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
