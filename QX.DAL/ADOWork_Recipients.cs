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
   /// 工作服领用记录
   /// </summary>
   [Serializable]
   public partial class ADOWork_Recipients
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加工作服领用记录 Work_Recipients对象(即:一条记录)
      /// </summary>
      public int Add(Work_Recipients work_Recipients)
      {
         string sql = "INSERT INTO Work_Recipients (WRecipients_Code,WRecipients_Date,WRecipients_Duty,WRecipients_Name,WRecipients_Gender,WRecipients_Model,WRecipients_Num,WRecipients_Company,WRecipients_Dept,WRecipients_Operator,WRecipients_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WRecipients_Code,@WRecipients_Date,@WRecipients_Duty,@WRecipients_Name,@WRecipients_Gender,@WRecipients_Model,@WRecipients_Num,@WRecipients_Company,@WRecipients_Dept,@WRecipients_Operator,@WRecipients_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Code))
         {
            idb.AddParameter("@WRecipients_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Code", work_Recipients.WRecipients_Code);
         }
         if (work_Recipients.WRecipients_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WRecipients_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Date", work_Recipients.WRecipients_Date);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Duty))
         {
            idb.AddParameter("@WRecipients_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Duty", work_Recipients.WRecipients_Duty);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Name))
         {
            idb.AddParameter("@WRecipients_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Name", work_Recipients.WRecipients_Name);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Gender))
         {
            idb.AddParameter("@WRecipients_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Gender", work_Recipients.WRecipients_Gender);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Model))
         {
            idb.AddParameter("@WRecipients_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Model", work_Recipients.WRecipients_Model);
         }
         if (work_Recipients.WRecipients_Num == 0)
         {
            idb.AddParameter("@WRecipients_Num", 0);
         }
         else
         {
            idb.AddParameter("@WRecipients_Num", work_Recipients.WRecipients_Num);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Company))
         {
            idb.AddParameter("@WRecipients_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Company", work_Recipients.WRecipients_Company);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Dept))
         {
            idb.AddParameter("@WRecipients_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Dept", work_Recipients.WRecipients_Dept);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Operator))
         {
            idb.AddParameter("@WRecipients_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Operator", work_Recipients.WRecipients_Operator);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Remark))
         {
            idb.AddParameter("@WRecipients_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Remark", work_Recipients.WRecipients_Remark);
         }
         if (work_Recipients.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", work_Recipients.Stat);
         }
         if (work_Recipients.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", work_Recipients.CreateDate);
         }
         if (work_Recipients.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", work_Recipients.UpdateDate);
         }
         if (work_Recipients.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", work_Recipients.DeleteDate);
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
      /// 添加工作服领用记录 Work_Recipients对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Work_Recipients work_Recipients)
      {
         string sql = "INSERT INTO Work_Recipients (WRecipients_Code,WRecipients_Date,WRecipients_Duty,WRecipients_Name,WRecipients_Gender,WRecipients_Model,WRecipients_Num,WRecipients_Company,WRecipients_Dept,WRecipients_Operator,WRecipients_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WRecipients_Code,@WRecipients_Date,@WRecipients_Duty,@WRecipients_Name,@WRecipients_Gender,@WRecipients_Model,@WRecipients_Num,@WRecipients_Company,@WRecipients_Dept,@WRecipients_Operator,@WRecipients_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Code))
         {
            idb.AddParameter("@WRecipients_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Code", work_Recipients.WRecipients_Code);
         }
         if (work_Recipients.WRecipients_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WRecipients_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Date", work_Recipients.WRecipients_Date);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Duty))
         {
            idb.AddParameter("@WRecipients_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Duty", work_Recipients.WRecipients_Duty);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Name))
         {
            idb.AddParameter("@WRecipients_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Name", work_Recipients.WRecipients_Name);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Gender))
         {
            idb.AddParameter("@WRecipients_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Gender", work_Recipients.WRecipients_Gender);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Model))
         {
            idb.AddParameter("@WRecipients_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Model", work_Recipients.WRecipients_Model);
         }
         if (work_Recipients.WRecipients_Num == 0)
         {
            idb.AddParameter("@WRecipients_Num", 0);
         }
         else
         {
            idb.AddParameter("@WRecipients_Num", work_Recipients.WRecipients_Num);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Company))
         {
            idb.AddParameter("@WRecipients_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Company", work_Recipients.WRecipients_Company);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Dept))
         {
            idb.AddParameter("@WRecipients_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Dept", work_Recipients.WRecipients_Dept);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Operator))
         {
            idb.AddParameter("@WRecipients_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Operator", work_Recipients.WRecipients_Operator);
         }
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Remark))
         {
            idb.AddParameter("@WRecipients_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Remark", work_Recipients.WRecipients_Remark);
         }
         if (work_Recipients.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", work_Recipients.Stat);
         }
         if (work_Recipients.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", work_Recipients.CreateDate);
         }
         if (work_Recipients.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", work_Recipients.UpdateDate);
         }
         if (work_Recipients.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", work_Recipients.DeleteDate);
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
      /// 更新工作服领用记录 Work_Recipients对象(即:一条记录
      /// </summary>
      public int Update(Work_Recipients work_Recipients)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Work_Recipients       SET ");
            if(work_Recipients.WRecipients_Code_IsChanged){sbParameter.Append("WRecipients_Code=@WRecipients_Code, ");}
      if(work_Recipients.WRecipients_Date_IsChanged){sbParameter.Append("WRecipients_Date=@WRecipients_Date, ");}
      if(work_Recipients.WRecipients_Duty_IsChanged){sbParameter.Append("WRecipients_Duty=@WRecipients_Duty, ");}
      if(work_Recipients.WRecipients_Name_IsChanged){sbParameter.Append("WRecipients_Name=@WRecipients_Name, ");}
      if(work_Recipients.WRecipients_Gender_IsChanged){sbParameter.Append("WRecipients_Gender=@WRecipients_Gender, ");}
      if(work_Recipients.WRecipients_Model_IsChanged){sbParameter.Append("WRecipients_Model=@WRecipients_Model, ");}
      if(work_Recipients.WRecipients_Num_IsChanged){sbParameter.Append("WRecipients_Num=@WRecipients_Num, ");}
      if(work_Recipients.WRecipients_Company_IsChanged){sbParameter.Append("WRecipients_Company=@WRecipients_Company, ");}
      if(work_Recipients.WRecipients_Dept_IsChanged){sbParameter.Append("WRecipients_Dept=@WRecipients_Dept, ");}
      if(work_Recipients.WRecipients_Operator_IsChanged){sbParameter.Append("WRecipients_Operator=@WRecipients_Operator, ");}
      if(work_Recipients.WRecipients_Remark_IsChanged){sbParameter.Append("WRecipients_Remark=@WRecipients_Remark, ");}
      if(work_Recipients.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(work_Recipients.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(work_Recipients.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(work_Recipients.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WRecipients_ID=@WRecipients_ID; " );
      string sql=sb.ToString();
         if(work_Recipients.WRecipients_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Code))
         {
            idb.AddParameter("@WRecipients_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Code", work_Recipients.WRecipients_Code);
         }
          }
         if(work_Recipients.WRecipients_Date_IsChanged)
         {
         if (work_Recipients.WRecipients_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WRecipients_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Date", work_Recipients.WRecipients_Date);
         }
          }
         if(work_Recipients.WRecipients_Duty_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Duty))
         {
            idb.AddParameter("@WRecipients_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Duty", work_Recipients.WRecipients_Duty);
         }
          }
         if(work_Recipients.WRecipients_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Name))
         {
            idb.AddParameter("@WRecipients_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Name", work_Recipients.WRecipients_Name);
         }
          }
         if(work_Recipients.WRecipients_Gender_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Gender))
         {
            idb.AddParameter("@WRecipients_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Gender", work_Recipients.WRecipients_Gender);
         }
          }
         if(work_Recipients.WRecipients_Model_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Model))
         {
            idb.AddParameter("@WRecipients_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Model", work_Recipients.WRecipients_Model);
         }
          }
         if(work_Recipients.WRecipients_Num_IsChanged)
         {
         if (work_Recipients.WRecipients_Num == 0)
         {
            idb.AddParameter("@WRecipients_Num", 0);
         }
         else
         {
            idb.AddParameter("@WRecipients_Num", work_Recipients.WRecipients_Num);
         }
          }
         if(work_Recipients.WRecipients_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Company))
         {
            idb.AddParameter("@WRecipients_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Company", work_Recipients.WRecipients_Company);
         }
          }
         if(work_Recipients.WRecipients_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Dept))
         {
            idb.AddParameter("@WRecipients_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Dept", work_Recipients.WRecipients_Dept);
         }
          }
         if(work_Recipients.WRecipients_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Operator))
         {
            idb.AddParameter("@WRecipients_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Operator", work_Recipients.WRecipients_Operator);
         }
          }
         if(work_Recipients.WRecipients_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(work_Recipients.WRecipients_Remark))
         {
            idb.AddParameter("@WRecipients_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WRecipients_Remark", work_Recipients.WRecipients_Remark);
         }
          }
         if(work_Recipients.Stat_IsChanged)
         {
         if (work_Recipients.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", work_Recipients.Stat);
         }
          }
         if(work_Recipients.CreateDate_IsChanged)
         {
         if (work_Recipients.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", work_Recipients.CreateDate);
         }
          }
         if(work_Recipients.UpdateDate_IsChanged)
         {
         if (work_Recipients.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", work_Recipients.UpdateDate);
         }
          }
         if(work_Recipients.DeleteDate_IsChanged)
         {
         if (work_Recipients.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", work_Recipients.DeleteDate);
         }
          }

         idb.AddParameter("@WRecipients_ID", work_Recipients.WRecipients_ID);

           
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
      /// 删除工作服领用记录 Work_Recipients对象(即:一条记录
      /// </summary>
      public int Delete(decimal wRecipients_ID)
      {
         string sql = "DELETE Work_Recipients WHERE 1=1  AND WRecipients_ID=@WRecipients_ID ";
         idb.AddParameter("@WRecipients_ID", wRecipients_ID);

           
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
      /// 获取指定的工作服领用记录 Work_Recipients对象(即:一条记录
      /// </summary>
      public Work_Recipients GetByKey(decimal wRecipients_ID)
      {
         Work_Recipients work_Recipients = new Work_Recipients();
         string sql = "SELECT  WRecipients_ID,WRecipients_Code,WRecipients_Date,WRecipients_Duty,WRecipients_Name,WRecipients_Gender,WRecipients_Model,WRecipients_Num,WRecipients_Company,WRecipients_Dept,WRecipients_Operator,WRecipients_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Work_Recipients WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WRecipients_ID=@WRecipients_ID ";
         idb.AddParameter("@WRecipients_ID", wRecipients_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WRecipients_ID"] != DBNull.Value) work_Recipients.WRecipients_ID = Convert.ToDecimal(dr["WRecipients_ID"]);
            if (dr["WRecipients_Code"] != DBNull.Value) work_Recipients.WRecipients_Code = Convert.ToString(dr["WRecipients_Code"]);
            if (dr["WRecipients_Date"] != DBNull.Value) work_Recipients.WRecipients_Date = Convert.ToDateTime(dr["WRecipients_Date"]);
            if (dr["WRecipients_Duty"] != DBNull.Value) work_Recipients.WRecipients_Duty = Convert.ToString(dr["WRecipients_Duty"]);
            if (dr["WRecipients_Name"] != DBNull.Value) work_Recipients.WRecipients_Name = Convert.ToString(dr["WRecipients_Name"]);
            if (dr["WRecipients_Gender"] != DBNull.Value) work_Recipients.WRecipients_Gender = Convert.ToString(dr["WRecipients_Gender"]);
            if (dr["WRecipients_Model"] != DBNull.Value) work_Recipients.WRecipients_Model = Convert.ToString(dr["WRecipients_Model"]);
            if (dr["WRecipients_Num"] != DBNull.Value) work_Recipients.WRecipients_Num = Convert.ToInt32(dr["WRecipients_Num"]);
            if (dr["WRecipients_Company"] != DBNull.Value) work_Recipients.WRecipients_Company = Convert.ToString(dr["WRecipients_Company"]);
            if (dr["WRecipients_Dept"] != DBNull.Value) work_Recipients.WRecipients_Dept = Convert.ToString(dr["WRecipients_Dept"]);
            if (dr["WRecipients_Operator"] != DBNull.Value) work_Recipients.WRecipients_Operator = Convert.ToString(dr["WRecipients_Operator"]);
            if (dr["WRecipients_Remark"] != DBNull.Value) work_Recipients.WRecipients_Remark = Convert.ToString(dr["WRecipients_Remark"]);
            if (dr["Stat"] != DBNull.Value) work_Recipients.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) work_Recipients.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) work_Recipients.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) work_Recipients.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return work_Recipients;
      }
      /// <summary>
      /// 获取指定的工作服领用记录 Work_Recipients对象集合
      /// </summary>
      public List<Work_Recipients> GetListByWhere(string strCondition)
      {
         List<Work_Recipients> ret = new List<Work_Recipients>();
         string sql = "SELECT  WRecipients_ID,WRecipients_Code,WRecipients_Date,WRecipients_Duty,WRecipients_Name,WRecipients_Gender,WRecipients_Model,WRecipients_Num,WRecipients_Company,WRecipients_Dept,WRecipients_Operator,WRecipients_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Work_Recipients WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Work_Recipients work_Recipients = new Work_Recipients();
            if (dr["WRecipients_ID"] != DBNull.Value) work_Recipients.WRecipients_ID = Convert.ToDecimal(dr["WRecipients_ID"]);
            if (dr["WRecipients_Code"] != DBNull.Value) work_Recipients.WRecipients_Code = Convert.ToString(dr["WRecipients_Code"]);
            if (dr["WRecipients_Date"] != DBNull.Value) work_Recipients.WRecipients_Date = Convert.ToDateTime(dr["WRecipients_Date"]);
            if (dr["WRecipients_Duty"] != DBNull.Value) work_Recipients.WRecipients_Duty = Convert.ToString(dr["WRecipients_Duty"]);
            if (dr["WRecipients_Name"] != DBNull.Value) work_Recipients.WRecipients_Name = Convert.ToString(dr["WRecipients_Name"]);
            if (dr["WRecipients_Gender"] != DBNull.Value) work_Recipients.WRecipients_Gender = Convert.ToString(dr["WRecipients_Gender"]);
            if (dr["WRecipients_Model"] != DBNull.Value) work_Recipients.WRecipients_Model = Convert.ToString(dr["WRecipients_Model"]);
            if (dr["WRecipients_Num"] != DBNull.Value) work_Recipients.WRecipients_Num = Convert.ToInt32(dr["WRecipients_Num"]);
            if (dr["WRecipients_Company"] != DBNull.Value) work_Recipients.WRecipients_Company = Convert.ToString(dr["WRecipients_Company"]);
            if (dr["WRecipients_Dept"] != DBNull.Value) work_Recipients.WRecipients_Dept = Convert.ToString(dr["WRecipients_Dept"]);
            if (dr["WRecipients_Operator"] != DBNull.Value) work_Recipients.WRecipients_Operator = Convert.ToString(dr["WRecipients_Operator"]);
            if (dr["WRecipients_Remark"] != DBNull.Value) work_Recipients.WRecipients_Remark = Convert.ToString(dr["WRecipients_Remark"]);
            if (dr["Stat"] != DBNull.Value) work_Recipients.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) work_Recipients.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) work_Recipients.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) work_Recipients.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(work_Recipients);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的工作服领用记录 Work_Recipients对象(即:一条记录
      /// </summary>
      public List<Work_Recipients> GetAll()
      {
         List<Work_Recipients> ret = new List<Work_Recipients>();
         string sql = "SELECT  WRecipients_ID,WRecipients_Code,WRecipients_Date,WRecipients_Duty,WRecipients_Name,WRecipients_Gender,WRecipients_Model,WRecipients_Num,WRecipients_Company,WRecipients_Dept,WRecipients_Operator,WRecipients_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Work_Recipients where 1=1 AND ((Stat is null) or (Stat=0) ) order by WRecipients_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Work_Recipients work_Recipients = new Work_Recipients();
            if (dr["WRecipients_ID"] != DBNull.Value) work_Recipients.WRecipients_ID = Convert.ToDecimal(dr["WRecipients_ID"]);
            if (dr["WRecipients_Code"] != DBNull.Value) work_Recipients.WRecipients_Code = Convert.ToString(dr["WRecipients_Code"]);
            if (dr["WRecipients_Date"] != DBNull.Value) work_Recipients.WRecipients_Date = Convert.ToDateTime(dr["WRecipients_Date"]);
            if (dr["WRecipients_Duty"] != DBNull.Value) work_Recipients.WRecipients_Duty = Convert.ToString(dr["WRecipients_Duty"]);
            if (dr["WRecipients_Name"] != DBNull.Value) work_Recipients.WRecipients_Name = Convert.ToString(dr["WRecipients_Name"]);
            if (dr["WRecipients_Gender"] != DBNull.Value) work_Recipients.WRecipients_Gender = Convert.ToString(dr["WRecipients_Gender"]);
            if (dr["WRecipients_Model"] != DBNull.Value) work_Recipients.WRecipients_Model = Convert.ToString(dr["WRecipients_Model"]);
            if (dr["WRecipients_Num"] != DBNull.Value) work_Recipients.WRecipients_Num = Convert.ToInt32(dr["WRecipients_Num"]);
            if (dr["WRecipients_Company"] != DBNull.Value) work_Recipients.WRecipients_Company = Convert.ToString(dr["WRecipients_Company"]);
            if (dr["WRecipients_Dept"] != DBNull.Value) work_Recipients.WRecipients_Dept = Convert.ToString(dr["WRecipients_Dept"]);
            if (dr["WRecipients_Operator"] != DBNull.Value) work_Recipients.WRecipients_Operator = Convert.ToString(dr["WRecipients_Operator"]);
            if (dr["WRecipients_Remark"] != DBNull.Value) work_Recipients.WRecipients_Remark = Convert.ToString(dr["WRecipients_Remark"]);
            if (dr["Stat"] != DBNull.Value) work_Recipients.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) work_Recipients.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) work_Recipients.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) work_Recipients.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(work_Recipients);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
