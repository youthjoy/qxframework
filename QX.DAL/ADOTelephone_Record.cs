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
   /// 电话登记记录
   /// </summary>
   [Serializable]
   public partial class ADOTelephone_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加电话登记记录 Telephone_Record对象(即:一条记录)
      /// </summary>
      public int Add(Telephone_Record telephone_Record)
      {
         string sql = "INSERT INTO Telephone_Record (TeleRecord_Code,TeleRecord_Date,TeleRecord_Category,TeleRecord_Content,TeleRecord_OpTarget,TeleRecord_Operator,TeleRecord_OpDate,TeleRecord_User,TeleRecord_UseDate,TeleRecord_Remark,TeleRecord_Company,TeleRecord_Dept,TeleRecord_iType,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TeleRecord_Code,@TeleRecord_Date,@TeleRecord_Category,@TeleRecord_Content,@TeleRecord_OpTarget,@TeleRecord_Operator,@TeleRecord_OpDate,@TeleRecord_User,@TeleRecord_UseDate,@TeleRecord_Remark,@TeleRecord_Company,@TeleRecord_Dept,@TeleRecord_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Code))
         {
            idb.AddParameter("@TeleRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Code", telephone_Record.TeleRecord_Code);
         }
         if (telephone_Record.TeleRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Date", telephone_Record.TeleRecord_Date);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Category))
         {
            idb.AddParameter("@TeleRecord_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Category", telephone_Record.TeleRecord_Category);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Content))
         {
            idb.AddParameter("@TeleRecord_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Content", telephone_Record.TeleRecord_Content);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_OpTarget))
         {
            idb.AddParameter("@TeleRecord_OpTarget", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_OpTarget", telephone_Record.TeleRecord_OpTarget);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Operator))
         {
            idb.AddParameter("@TeleRecord_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Operator", telephone_Record.TeleRecord_Operator);
         }
         if (telephone_Record.TeleRecord_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_OpDate", telephone_Record.TeleRecord_OpDate);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_User))
         {
            idb.AddParameter("@TeleRecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_User", telephone_Record.TeleRecord_User);
         }
         if (telephone_Record.TeleRecord_UseDate == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_UseDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_UseDate", telephone_Record.TeleRecord_UseDate);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Remark))
         {
            idb.AddParameter("@TeleRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Remark", telephone_Record.TeleRecord_Remark);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Company))
         {
            idb.AddParameter("@TeleRecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Company", telephone_Record.TeleRecord_Company);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Dept))
         {
            idb.AddParameter("@TeleRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Dept", telephone_Record.TeleRecord_Dept);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_iType))
         {
            idb.AddParameter("@TeleRecord_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_iType", telephone_Record.TeleRecord_iType);
         }
         if (telephone_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", telephone_Record.Stat);
         }
         if (telephone_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", telephone_Record.CreateDate);
         }
         if (telephone_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", telephone_Record.UpdateDate);
         }
         if (telephone_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", telephone_Record.DeleteDate);
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
      /// 添加电话登记记录 Telephone_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Telephone_Record telephone_Record)
      {
         string sql = "INSERT INTO Telephone_Record (TeleRecord_Code,TeleRecord_Date,TeleRecord_Category,TeleRecord_Content,TeleRecord_OpTarget,TeleRecord_Operator,TeleRecord_OpDate,TeleRecord_User,TeleRecord_UseDate,TeleRecord_Remark,TeleRecord_Company,TeleRecord_Dept,TeleRecord_iType,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TeleRecord_Code,@TeleRecord_Date,@TeleRecord_Category,@TeleRecord_Content,@TeleRecord_OpTarget,@TeleRecord_Operator,@TeleRecord_OpDate,@TeleRecord_User,@TeleRecord_UseDate,@TeleRecord_Remark,@TeleRecord_Company,@TeleRecord_Dept,@TeleRecord_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Code))
         {
            idb.AddParameter("@TeleRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Code", telephone_Record.TeleRecord_Code);
         }
         if (telephone_Record.TeleRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Date", telephone_Record.TeleRecord_Date);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Category))
         {
            idb.AddParameter("@TeleRecord_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Category", telephone_Record.TeleRecord_Category);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Content))
         {
            idb.AddParameter("@TeleRecord_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Content", telephone_Record.TeleRecord_Content);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_OpTarget))
         {
            idb.AddParameter("@TeleRecord_OpTarget", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_OpTarget", telephone_Record.TeleRecord_OpTarget);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Operator))
         {
            idb.AddParameter("@TeleRecord_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Operator", telephone_Record.TeleRecord_Operator);
         }
         if (telephone_Record.TeleRecord_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_OpDate", telephone_Record.TeleRecord_OpDate);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_User))
         {
            idb.AddParameter("@TeleRecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_User", telephone_Record.TeleRecord_User);
         }
         if (telephone_Record.TeleRecord_UseDate == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_UseDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_UseDate", telephone_Record.TeleRecord_UseDate);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Remark))
         {
            idb.AddParameter("@TeleRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Remark", telephone_Record.TeleRecord_Remark);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Company))
         {
            idb.AddParameter("@TeleRecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Company", telephone_Record.TeleRecord_Company);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Dept))
         {
            idb.AddParameter("@TeleRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Dept", telephone_Record.TeleRecord_Dept);
         }
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_iType))
         {
            idb.AddParameter("@TeleRecord_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_iType", telephone_Record.TeleRecord_iType);
         }
         if (telephone_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", telephone_Record.Stat);
         }
         if (telephone_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", telephone_Record.CreateDate);
         }
         if (telephone_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", telephone_Record.UpdateDate);
         }
         if (telephone_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", telephone_Record.DeleteDate);
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
      /// 更新电话登记记录 Telephone_Record对象(即:一条记录
      /// </summary>
      public int Update(Telephone_Record telephone_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Telephone_Record       SET ");
            if(telephone_Record.TeleRecord_Code_IsChanged){sbParameter.Append("TeleRecord_Code=@TeleRecord_Code, ");}
      if(telephone_Record.TeleRecord_Date_IsChanged){sbParameter.Append("TeleRecord_Date=@TeleRecord_Date, ");}
      if(telephone_Record.TeleRecord_Category_IsChanged){sbParameter.Append("TeleRecord_Category=@TeleRecord_Category, ");}
      if(telephone_Record.TeleRecord_Content_IsChanged){sbParameter.Append("TeleRecord_Content=@TeleRecord_Content, ");}
      if(telephone_Record.TeleRecord_OpTarget_IsChanged){sbParameter.Append("TeleRecord_OpTarget=@TeleRecord_OpTarget, ");}
      if(telephone_Record.TeleRecord_Operator_IsChanged){sbParameter.Append("TeleRecord_Operator=@TeleRecord_Operator, ");}
      if(telephone_Record.TeleRecord_OpDate_IsChanged){sbParameter.Append("TeleRecord_OpDate=@TeleRecord_OpDate, ");}
      if(telephone_Record.TeleRecord_User_IsChanged){sbParameter.Append("TeleRecord_User=@TeleRecord_User, ");}
      if(telephone_Record.TeleRecord_UseDate_IsChanged){sbParameter.Append("TeleRecord_UseDate=@TeleRecord_UseDate, ");}
      if(telephone_Record.TeleRecord_Remark_IsChanged){sbParameter.Append("TeleRecord_Remark=@TeleRecord_Remark, ");}
      if(telephone_Record.TeleRecord_Company_IsChanged){sbParameter.Append("TeleRecord_Company=@TeleRecord_Company, ");}
      if(telephone_Record.TeleRecord_Dept_IsChanged){sbParameter.Append("TeleRecord_Dept=@TeleRecord_Dept, ");}
      if(telephone_Record.TeleRecord_iType_IsChanged){sbParameter.Append("TeleRecord_iType=@TeleRecord_iType, ");}
      if(telephone_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(telephone_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(telephone_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(telephone_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TeleRecord_ID=@TeleRecord_ID; " );
      string sql=sb.ToString();
         if(telephone_Record.TeleRecord_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Code))
         {
            idb.AddParameter("@TeleRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Code", telephone_Record.TeleRecord_Code);
         }
          }
         if(telephone_Record.TeleRecord_Date_IsChanged)
         {
         if (telephone_Record.TeleRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Date", telephone_Record.TeleRecord_Date);
         }
          }
         if(telephone_Record.TeleRecord_Category_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Category))
         {
            idb.AddParameter("@TeleRecord_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Category", telephone_Record.TeleRecord_Category);
         }
          }
         if(telephone_Record.TeleRecord_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Content))
         {
            idb.AddParameter("@TeleRecord_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Content", telephone_Record.TeleRecord_Content);
         }
          }
         if(telephone_Record.TeleRecord_OpTarget_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_OpTarget))
         {
            idb.AddParameter("@TeleRecord_OpTarget", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_OpTarget", telephone_Record.TeleRecord_OpTarget);
         }
          }
         if(telephone_Record.TeleRecord_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Operator))
         {
            idb.AddParameter("@TeleRecord_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Operator", telephone_Record.TeleRecord_Operator);
         }
          }
         if(telephone_Record.TeleRecord_OpDate_IsChanged)
         {
         if (telephone_Record.TeleRecord_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_OpDate", telephone_Record.TeleRecord_OpDate);
         }
          }
         if(telephone_Record.TeleRecord_User_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_User))
         {
            idb.AddParameter("@TeleRecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_User", telephone_Record.TeleRecord_User);
         }
          }
         if(telephone_Record.TeleRecord_UseDate_IsChanged)
         {
         if (telephone_Record.TeleRecord_UseDate == DateTime.MinValue)
         {
            idb.AddParameter("@TeleRecord_UseDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_UseDate", telephone_Record.TeleRecord_UseDate);
         }
          }
         if(telephone_Record.TeleRecord_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Remark))
         {
            idb.AddParameter("@TeleRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Remark", telephone_Record.TeleRecord_Remark);
         }
          }
         if(telephone_Record.TeleRecord_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Company))
         {
            idb.AddParameter("@TeleRecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Company", telephone_Record.TeleRecord_Company);
         }
          }
         if(telephone_Record.TeleRecord_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_Dept))
         {
            idb.AddParameter("@TeleRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_Dept", telephone_Record.TeleRecord_Dept);
         }
          }
         if(telephone_Record.TeleRecord_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(telephone_Record.TeleRecord_iType))
         {
            idb.AddParameter("@TeleRecord_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TeleRecord_iType", telephone_Record.TeleRecord_iType);
         }
          }
         if(telephone_Record.Stat_IsChanged)
         {
         if (telephone_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", telephone_Record.Stat);
         }
          }
         if(telephone_Record.CreateDate_IsChanged)
         {
         if (telephone_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", telephone_Record.CreateDate);
         }
          }
         if(telephone_Record.UpdateDate_IsChanged)
         {
         if (telephone_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", telephone_Record.UpdateDate);
         }
          }
         if(telephone_Record.DeleteDate_IsChanged)
         {
         if (telephone_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", telephone_Record.DeleteDate);
         }
          }

         idb.AddParameter("@TeleRecord_ID", telephone_Record.TeleRecord_ID);

           
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
      /// 删除电话登记记录 Telephone_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal teleRecord_ID)
      {
         string sql = "DELETE Telephone_Record WHERE 1=1  AND TeleRecord_ID=@TeleRecord_ID ";
         idb.AddParameter("@TeleRecord_ID", teleRecord_ID);

           
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
      /// 获取指定的电话登记记录 Telephone_Record对象(即:一条记录
      /// </summary>
      public Telephone_Record GetByKey(decimal teleRecord_ID)
      {
         Telephone_Record telephone_Record = new Telephone_Record();
         string sql = "SELECT  TeleRecord_ID,TeleRecord_Code,TeleRecord_Date,TeleRecord_Category,TeleRecord_Content,TeleRecord_OpTarget,TeleRecord_Operator,TeleRecord_OpDate,TeleRecord_User,TeleRecord_UseDate,TeleRecord_Remark,TeleRecord_Company,TeleRecord_Dept,TeleRecord_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM Telephone_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TeleRecord_ID=@TeleRecord_ID ";
         idb.AddParameter("@TeleRecord_ID", teleRecord_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TeleRecord_ID"] != DBNull.Value) telephone_Record.TeleRecord_ID = Convert.ToDecimal(dr["TeleRecord_ID"]);
            if (dr["TeleRecord_Code"] != DBNull.Value) telephone_Record.TeleRecord_Code = Convert.ToString(dr["TeleRecord_Code"]);
            if (dr["TeleRecord_Date"] != DBNull.Value) telephone_Record.TeleRecord_Date = Convert.ToDateTime(dr["TeleRecord_Date"]);
            if (dr["TeleRecord_Category"] != DBNull.Value) telephone_Record.TeleRecord_Category = Convert.ToString(dr["TeleRecord_Category"]);
            if (dr["TeleRecord_Content"] != DBNull.Value) telephone_Record.TeleRecord_Content = Convert.ToString(dr["TeleRecord_Content"]);
            if (dr["TeleRecord_OpTarget"] != DBNull.Value) telephone_Record.TeleRecord_OpTarget = Convert.ToString(dr["TeleRecord_OpTarget"]);
            if (dr["TeleRecord_Operator"] != DBNull.Value) telephone_Record.TeleRecord_Operator = Convert.ToString(dr["TeleRecord_Operator"]);
            if (dr["TeleRecord_OpDate"] != DBNull.Value) telephone_Record.TeleRecord_OpDate = Convert.ToDateTime(dr["TeleRecord_OpDate"]);
            if (dr["TeleRecord_User"] != DBNull.Value) telephone_Record.TeleRecord_User = Convert.ToString(dr["TeleRecord_User"]);
            if (dr["TeleRecord_UseDate"] != DBNull.Value) telephone_Record.TeleRecord_UseDate = Convert.ToDateTime(dr["TeleRecord_UseDate"]);
            if (dr["TeleRecord_Remark"] != DBNull.Value) telephone_Record.TeleRecord_Remark = Convert.ToString(dr["TeleRecord_Remark"]);
            if (dr["TeleRecord_Company"] != DBNull.Value) telephone_Record.TeleRecord_Company = Convert.ToString(dr["TeleRecord_Company"]);
            if (dr["TeleRecord_Dept"] != DBNull.Value) telephone_Record.TeleRecord_Dept = Convert.ToString(dr["TeleRecord_Dept"]);
            if (dr["TeleRecord_iType"] != DBNull.Value) telephone_Record.TeleRecord_iType = Convert.ToString(dr["TeleRecord_iType"]);
            if (dr["Stat"] != DBNull.Value) telephone_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) telephone_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) telephone_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) telephone_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return telephone_Record;
      }
      /// <summary>
      /// 获取指定的电话登记记录 Telephone_Record对象集合
      /// </summary>
      public List<Telephone_Record> GetListByWhere(string strCondition)
      {
         List<Telephone_Record> ret = new List<Telephone_Record>();
         string sql = "SELECT  TeleRecord_ID,TeleRecord_Code,TeleRecord_Date,TeleRecord_Category,TeleRecord_Content,TeleRecord_OpTarget,TeleRecord_Operator,TeleRecord_OpDate,TeleRecord_User,TeleRecord_UseDate,TeleRecord_Remark,TeleRecord_Company,TeleRecord_Dept,TeleRecord_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM Telephone_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Telephone_Record telephone_Record = new Telephone_Record();
            if (dr["TeleRecord_ID"] != DBNull.Value) telephone_Record.TeleRecord_ID = Convert.ToDecimal(dr["TeleRecord_ID"]);
            if (dr["TeleRecord_Code"] != DBNull.Value) telephone_Record.TeleRecord_Code = Convert.ToString(dr["TeleRecord_Code"]);
            if (dr["TeleRecord_Date"] != DBNull.Value) telephone_Record.TeleRecord_Date = Convert.ToDateTime(dr["TeleRecord_Date"]);
            if (dr["TeleRecord_Category"] != DBNull.Value) telephone_Record.TeleRecord_Category = Convert.ToString(dr["TeleRecord_Category"]);
            if (dr["TeleRecord_Content"] != DBNull.Value) telephone_Record.TeleRecord_Content = Convert.ToString(dr["TeleRecord_Content"]);
            if (dr["TeleRecord_OpTarget"] != DBNull.Value) telephone_Record.TeleRecord_OpTarget = Convert.ToString(dr["TeleRecord_OpTarget"]);
            if (dr["TeleRecord_Operator"] != DBNull.Value) telephone_Record.TeleRecord_Operator = Convert.ToString(dr["TeleRecord_Operator"]);
            if (dr["TeleRecord_OpDate"] != DBNull.Value) telephone_Record.TeleRecord_OpDate = Convert.ToDateTime(dr["TeleRecord_OpDate"]);
            if (dr["TeleRecord_User"] != DBNull.Value) telephone_Record.TeleRecord_User = Convert.ToString(dr["TeleRecord_User"]);
            if (dr["TeleRecord_UseDate"] != DBNull.Value) telephone_Record.TeleRecord_UseDate = Convert.ToDateTime(dr["TeleRecord_UseDate"]);
            if (dr["TeleRecord_Remark"] != DBNull.Value) telephone_Record.TeleRecord_Remark = Convert.ToString(dr["TeleRecord_Remark"]);
            if (dr["TeleRecord_Company"] != DBNull.Value) telephone_Record.TeleRecord_Company = Convert.ToString(dr["TeleRecord_Company"]);
            if (dr["TeleRecord_Dept"] != DBNull.Value) telephone_Record.TeleRecord_Dept = Convert.ToString(dr["TeleRecord_Dept"]);
            if (dr["TeleRecord_iType"] != DBNull.Value) telephone_Record.TeleRecord_iType = Convert.ToString(dr["TeleRecord_iType"]);
            if (dr["Stat"] != DBNull.Value) telephone_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) telephone_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) telephone_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) telephone_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(telephone_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的电话登记记录 Telephone_Record对象(即:一条记录
      /// </summary>
      public List<Telephone_Record> GetAll()
      {
         List<Telephone_Record> ret = new List<Telephone_Record>();
         string sql = "SELECT  TeleRecord_ID,TeleRecord_Code,TeleRecord_Date,TeleRecord_Category,TeleRecord_Content,TeleRecord_OpTarget,TeleRecord_Operator,TeleRecord_OpDate,TeleRecord_User,TeleRecord_UseDate,TeleRecord_Remark,TeleRecord_Company,TeleRecord_Dept,TeleRecord_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM Telephone_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by TeleRecord_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Telephone_Record telephone_Record = new Telephone_Record();
            if (dr["TeleRecord_ID"] != DBNull.Value) telephone_Record.TeleRecord_ID = Convert.ToDecimal(dr["TeleRecord_ID"]);
            if (dr["TeleRecord_Code"] != DBNull.Value) telephone_Record.TeleRecord_Code = Convert.ToString(dr["TeleRecord_Code"]);
            if (dr["TeleRecord_Date"] != DBNull.Value) telephone_Record.TeleRecord_Date = Convert.ToDateTime(dr["TeleRecord_Date"]);
            if (dr["TeleRecord_Category"] != DBNull.Value) telephone_Record.TeleRecord_Category = Convert.ToString(dr["TeleRecord_Category"]);
            if (dr["TeleRecord_Content"] != DBNull.Value) telephone_Record.TeleRecord_Content = Convert.ToString(dr["TeleRecord_Content"]);
            if (dr["TeleRecord_OpTarget"] != DBNull.Value) telephone_Record.TeleRecord_OpTarget = Convert.ToString(dr["TeleRecord_OpTarget"]);
            if (dr["TeleRecord_Operator"] != DBNull.Value) telephone_Record.TeleRecord_Operator = Convert.ToString(dr["TeleRecord_Operator"]);
            if (dr["TeleRecord_OpDate"] != DBNull.Value) telephone_Record.TeleRecord_OpDate = Convert.ToDateTime(dr["TeleRecord_OpDate"]);
            if (dr["TeleRecord_User"] != DBNull.Value) telephone_Record.TeleRecord_User = Convert.ToString(dr["TeleRecord_User"]);
            if (dr["TeleRecord_UseDate"] != DBNull.Value) telephone_Record.TeleRecord_UseDate = Convert.ToDateTime(dr["TeleRecord_UseDate"]);
            if (dr["TeleRecord_Remark"] != DBNull.Value) telephone_Record.TeleRecord_Remark = Convert.ToString(dr["TeleRecord_Remark"]);
            if (dr["TeleRecord_Company"] != DBNull.Value) telephone_Record.TeleRecord_Company = Convert.ToString(dr["TeleRecord_Company"]);
            if (dr["TeleRecord_Dept"] != DBNull.Value) telephone_Record.TeleRecord_Dept = Convert.ToString(dr["TeleRecord_Dept"]);
            if (dr["TeleRecord_iType"] != DBNull.Value) telephone_Record.TeleRecord_iType = Convert.ToString(dr["TeleRecord_iType"]);
            if (dr["Stat"] != DBNull.Value) telephone_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) telephone_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) telephone_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) telephone_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(telephone_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
