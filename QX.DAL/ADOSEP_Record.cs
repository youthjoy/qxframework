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
   /// 5S环保处罚记录
   /// </summary>
   [Serializable]
   public partial class ADOSEP_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加5S环保处罚记录 SEP_Record对象(即:一条记录)
      /// </summary>
      public int Add(SEP_Record sEP_Record)
      {
         string sql = "INSERT INTO SEP_Record (SEPRecord_Code,SEPRecord_Date,SEPRecord_Event,SEPRecord_Content,SEPRecord_Result,SEPRecord_Type,SEPRecord_Remark,SEPRecordCompany,SEPRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@SEPRecord_Code,@SEPRecord_Date,@SEPRecord_Event,@SEPRecord_Content,@SEPRecord_Result,@SEPRecord_Type,@SEPRecord_Remark,@SEPRecordCompany,@SEPRecord_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Code))
         {
            idb.AddParameter("@SEPRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Code", sEP_Record.SEPRecord_Code);
         }
         if (sEP_Record.SEPRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SEPRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Date", sEP_Record.SEPRecord_Date);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Event))
         {
            idb.AddParameter("@SEPRecord_Event", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Event", sEP_Record.SEPRecord_Event);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Content))
         {
            idb.AddParameter("@SEPRecord_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Content", sEP_Record.SEPRecord_Content);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Result))
         {
            idb.AddParameter("@SEPRecord_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Result", sEP_Record.SEPRecord_Result);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Type))
         {
            idb.AddParameter("@SEPRecord_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Type", sEP_Record.SEPRecord_Type);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Remark))
         {
            idb.AddParameter("@SEPRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Remark", sEP_Record.SEPRecord_Remark);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecordCompany))
         {
            idb.AddParameter("@SEPRecordCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecordCompany", sEP_Record.SEPRecordCompany);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Dept))
         {
            idb.AddParameter("@SEPRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Dept", sEP_Record.SEPRecord_Dept);
         }
         if (sEP_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sEP_Record.Stat);
         }
         if (sEP_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sEP_Record.CreateDate);
         }
         if (sEP_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sEP_Record.UpdateDate);
         }
         if (sEP_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sEP_Record.DeleteDate);
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
      /// 添加5S环保处罚记录 SEP_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SEP_Record sEP_Record)
      {
         string sql = "INSERT INTO SEP_Record (SEPRecord_Code,SEPRecord_Date,SEPRecord_Event,SEPRecord_Content,SEPRecord_Result,SEPRecord_Type,SEPRecord_Remark,SEPRecordCompany,SEPRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@SEPRecord_Code,@SEPRecord_Date,@SEPRecord_Event,@SEPRecord_Content,@SEPRecord_Result,@SEPRecord_Type,@SEPRecord_Remark,@SEPRecordCompany,@SEPRecord_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Code))
         {
            idb.AddParameter("@SEPRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Code", sEP_Record.SEPRecord_Code);
         }
         if (sEP_Record.SEPRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SEPRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Date", sEP_Record.SEPRecord_Date);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Event))
         {
            idb.AddParameter("@SEPRecord_Event", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Event", sEP_Record.SEPRecord_Event);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Content))
         {
            idb.AddParameter("@SEPRecord_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Content", sEP_Record.SEPRecord_Content);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Result))
         {
            idb.AddParameter("@SEPRecord_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Result", sEP_Record.SEPRecord_Result);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Type))
         {
            idb.AddParameter("@SEPRecord_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Type", sEP_Record.SEPRecord_Type);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Remark))
         {
            idb.AddParameter("@SEPRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Remark", sEP_Record.SEPRecord_Remark);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecordCompany))
         {
            idb.AddParameter("@SEPRecordCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecordCompany", sEP_Record.SEPRecordCompany);
         }
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Dept))
         {
            idb.AddParameter("@SEPRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Dept", sEP_Record.SEPRecord_Dept);
         }
         if (sEP_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sEP_Record.Stat);
         }
         if (sEP_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sEP_Record.CreateDate);
         }
         if (sEP_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sEP_Record.UpdateDate);
         }
         if (sEP_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sEP_Record.DeleteDate);
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
      /// 更新5S环保处罚记录 SEP_Record对象(即:一条记录
      /// </summary>
      public int Update(SEP_Record sEP_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SEP_Record       SET ");
            if(sEP_Record.SEPRecord_Code_IsChanged){sbParameter.Append("SEPRecord_Code=@SEPRecord_Code, ");}
      if(sEP_Record.SEPRecord_Date_IsChanged){sbParameter.Append("SEPRecord_Date=@SEPRecord_Date, ");}
      if(sEP_Record.SEPRecord_Event_IsChanged){sbParameter.Append("SEPRecord_Event=@SEPRecord_Event, ");}
      if(sEP_Record.SEPRecord_Content_IsChanged){sbParameter.Append("SEPRecord_Content=@SEPRecord_Content, ");}
      if(sEP_Record.SEPRecord_Result_IsChanged){sbParameter.Append("SEPRecord_Result=@SEPRecord_Result, ");}
      if(sEP_Record.SEPRecord_Type_IsChanged){sbParameter.Append("SEPRecord_Type=@SEPRecord_Type, ");}
      if(sEP_Record.SEPRecord_Remark_IsChanged){sbParameter.Append("SEPRecord_Remark=@SEPRecord_Remark, ");}
      if(sEP_Record.SEPRecordCompany_IsChanged){sbParameter.Append("SEPRecordCompany=@SEPRecordCompany, ");}
      if(sEP_Record.SEPRecord_Dept_IsChanged){sbParameter.Append("SEPRecord_Dept=@SEPRecord_Dept, ");}
      if(sEP_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sEP_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sEP_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sEP_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SEPRecord_ID=@SEPRecord_ID; " );
      string sql=sb.ToString();
         if(sEP_Record.SEPRecord_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Code))
         {
            idb.AddParameter("@SEPRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Code", sEP_Record.SEPRecord_Code);
         }
          }
         if(sEP_Record.SEPRecord_Date_IsChanged)
         {
         if (sEP_Record.SEPRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SEPRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Date", sEP_Record.SEPRecord_Date);
         }
          }
         if(sEP_Record.SEPRecord_Event_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Event))
         {
            idb.AddParameter("@SEPRecord_Event", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Event", sEP_Record.SEPRecord_Event);
         }
          }
         if(sEP_Record.SEPRecord_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Content))
         {
            idb.AddParameter("@SEPRecord_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Content", sEP_Record.SEPRecord_Content);
         }
          }
         if(sEP_Record.SEPRecord_Result_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Result))
         {
            idb.AddParameter("@SEPRecord_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Result", sEP_Record.SEPRecord_Result);
         }
          }
         if(sEP_Record.SEPRecord_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Type))
         {
            idb.AddParameter("@SEPRecord_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Type", sEP_Record.SEPRecord_Type);
         }
          }
         if(sEP_Record.SEPRecord_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Remark))
         {
            idb.AddParameter("@SEPRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Remark", sEP_Record.SEPRecord_Remark);
         }
          }
         if(sEP_Record.SEPRecordCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecordCompany))
         {
            idb.AddParameter("@SEPRecordCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecordCompany", sEP_Record.SEPRecordCompany);
         }
          }
         if(sEP_Record.SEPRecord_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(sEP_Record.SEPRecord_Dept))
         {
            idb.AddParameter("@SEPRecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SEPRecord_Dept", sEP_Record.SEPRecord_Dept);
         }
          }
         if(sEP_Record.Stat_IsChanged)
         {
         if (sEP_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sEP_Record.Stat);
         }
          }
         if(sEP_Record.CreateDate_IsChanged)
         {
         if (sEP_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sEP_Record.CreateDate);
         }
          }
         if(sEP_Record.UpdateDate_IsChanged)
         {
         if (sEP_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sEP_Record.UpdateDate);
         }
          }
         if(sEP_Record.DeleteDate_IsChanged)
         {
         if (sEP_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sEP_Record.DeleteDate);
         }
          }

         idb.AddParameter("@SEPRecord_ID", sEP_Record.SEPRecord_ID);

           
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
      /// 删除5S环保处罚记录 SEP_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal sEPRecord_ID)
      {
         string sql = "DELETE SEP_Record WHERE 1=1  AND SEPRecord_ID=@SEPRecord_ID ";
         idb.AddParameter("@SEPRecord_ID", sEPRecord_ID);

           
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
      /// 获取指定的5S环保处罚记录 SEP_Record对象(即:一条记录
      /// </summary>
      public SEP_Record GetByKey(decimal sEPRecord_ID)
      {
         SEP_Record sEP_Record = new SEP_Record();
         string sql = "SELECT  SEPRecord_ID,SEPRecord_Code,SEPRecord_Date,SEPRecord_Event,SEPRecord_Content,SEPRecord_Result,SEPRecord_Type,SEPRecord_Remark,SEPRecordCompany,SEPRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM SEP_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SEPRecord_ID=@SEPRecord_ID ";
         idb.AddParameter("@SEPRecord_ID", sEPRecord_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SEPRecord_ID"] != DBNull.Value) sEP_Record.SEPRecord_ID = Convert.ToDecimal(dr["SEPRecord_ID"]);
            if (dr["SEPRecord_Code"] != DBNull.Value) sEP_Record.SEPRecord_Code = Convert.ToString(dr["SEPRecord_Code"]);
            if (dr["SEPRecord_Date"] != DBNull.Value) sEP_Record.SEPRecord_Date = Convert.ToDateTime(dr["SEPRecord_Date"]);
            if (dr["SEPRecord_Event"] != DBNull.Value) sEP_Record.SEPRecord_Event = Convert.ToString(dr["SEPRecord_Event"]);
            if (dr["SEPRecord_Content"] != DBNull.Value) sEP_Record.SEPRecord_Content = Convert.ToString(dr["SEPRecord_Content"]);
            if (dr["SEPRecord_Result"] != DBNull.Value) sEP_Record.SEPRecord_Result = Convert.ToString(dr["SEPRecord_Result"]);
            if (dr["SEPRecord_Type"] != DBNull.Value) sEP_Record.SEPRecord_Type = Convert.ToString(dr["SEPRecord_Type"]);
            if (dr["SEPRecord_Remark"] != DBNull.Value) sEP_Record.SEPRecord_Remark = Convert.ToString(dr["SEPRecord_Remark"]);
            if (dr["SEPRecordCompany"] != DBNull.Value) sEP_Record.SEPRecordCompany = Convert.ToString(dr["SEPRecordCompany"]);
            if (dr["SEPRecord_Dept"] != DBNull.Value) sEP_Record.SEPRecord_Dept = Convert.ToString(dr["SEPRecord_Dept"]);
            if (dr["Stat"] != DBNull.Value) sEP_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sEP_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sEP_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sEP_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sEP_Record;
      }
      /// <summary>
      /// 获取指定的5S环保处罚记录 SEP_Record对象集合
      /// </summary>
      public List<SEP_Record> GetListByWhere(string strCondition)
      {
         List<SEP_Record> ret = new List<SEP_Record>();
         string sql = "SELECT  SEPRecord_ID,SEPRecord_Code,SEPRecord_Date,SEPRecord_Event,SEPRecord_Content,SEPRecord_Result,SEPRecord_Type,SEPRecord_Remark,SEPRecordCompany,SEPRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM SEP_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SEP_Record sEP_Record = new SEP_Record();
            if (dr["SEPRecord_ID"] != DBNull.Value) sEP_Record.SEPRecord_ID = Convert.ToDecimal(dr["SEPRecord_ID"]);
            if (dr["SEPRecord_Code"] != DBNull.Value) sEP_Record.SEPRecord_Code = Convert.ToString(dr["SEPRecord_Code"]);
            if (dr["SEPRecord_Date"] != DBNull.Value) sEP_Record.SEPRecord_Date = Convert.ToDateTime(dr["SEPRecord_Date"]);
            if (dr["SEPRecord_Event"] != DBNull.Value) sEP_Record.SEPRecord_Event = Convert.ToString(dr["SEPRecord_Event"]);
            if (dr["SEPRecord_Content"] != DBNull.Value) sEP_Record.SEPRecord_Content = Convert.ToString(dr["SEPRecord_Content"]);
            if (dr["SEPRecord_Result"] != DBNull.Value) sEP_Record.SEPRecord_Result = Convert.ToString(dr["SEPRecord_Result"]);
            if (dr["SEPRecord_Type"] != DBNull.Value) sEP_Record.SEPRecord_Type = Convert.ToString(dr["SEPRecord_Type"]);
            if (dr["SEPRecord_Remark"] != DBNull.Value) sEP_Record.SEPRecord_Remark = Convert.ToString(dr["SEPRecord_Remark"]);
            if (dr["SEPRecordCompany"] != DBNull.Value) sEP_Record.SEPRecordCompany = Convert.ToString(dr["SEPRecordCompany"]);
            if (dr["SEPRecord_Dept"] != DBNull.Value) sEP_Record.SEPRecord_Dept = Convert.ToString(dr["SEPRecord_Dept"]);
            if (dr["Stat"] != DBNull.Value) sEP_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sEP_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sEP_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sEP_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sEP_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的5S环保处罚记录 SEP_Record对象(即:一条记录
      /// </summary>
      public List<SEP_Record> GetAll()
      {
         List<SEP_Record> ret = new List<SEP_Record>();
         string sql = "SELECT  SEPRecord_ID,SEPRecord_Code,SEPRecord_Date,SEPRecord_Event,SEPRecord_Content,SEPRecord_Result,SEPRecord_Type,SEPRecord_Remark,SEPRecordCompany,SEPRecord_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM SEP_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by SEPRecord_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SEP_Record sEP_Record = new SEP_Record();
            if (dr["SEPRecord_ID"] != DBNull.Value) sEP_Record.SEPRecord_ID = Convert.ToDecimal(dr["SEPRecord_ID"]);
            if (dr["SEPRecord_Code"] != DBNull.Value) sEP_Record.SEPRecord_Code = Convert.ToString(dr["SEPRecord_Code"]);
            if (dr["SEPRecord_Date"] != DBNull.Value) sEP_Record.SEPRecord_Date = Convert.ToDateTime(dr["SEPRecord_Date"]);
            if (dr["SEPRecord_Event"] != DBNull.Value) sEP_Record.SEPRecord_Event = Convert.ToString(dr["SEPRecord_Event"]);
            if (dr["SEPRecord_Content"] != DBNull.Value) sEP_Record.SEPRecord_Content = Convert.ToString(dr["SEPRecord_Content"]);
            if (dr["SEPRecord_Result"] != DBNull.Value) sEP_Record.SEPRecord_Result = Convert.ToString(dr["SEPRecord_Result"]);
            if (dr["SEPRecord_Type"] != DBNull.Value) sEP_Record.SEPRecord_Type = Convert.ToString(dr["SEPRecord_Type"]);
            if (dr["SEPRecord_Remark"] != DBNull.Value) sEP_Record.SEPRecord_Remark = Convert.ToString(dr["SEPRecord_Remark"]);
            if (dr["SEPRecordCompany"] != DBNull.Value) sEP_Record.SEPRecordCompany = Convert.ToString(dr["SEPRecordCompany"]);
            if (dr["SEPRecord_Dept"] != DBNull.Value) sEP_Record.SEPRecord_Dept = Convert.ToString(dr["SEPRecord_Dept"]);
            if (dr["Stat"] != DBNull.Value) sEP_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sEP_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sEP_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sEP_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sEP_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
