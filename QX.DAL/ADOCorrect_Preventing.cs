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
   /// 纠正预防措施
   /// </summary>
   [Serializable]
   public partial class ADOCorrect_Preventing
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加纠正预防措施 Correct_Preventing对象(即:一条记录)
      /// </summary>
      public int Add(Correct_Preventing correct_Preventing)
      {
         string sql = "INSERT INTO Correct_Preventing (Correct_Code,Correct_Item,Correct_Dept,Correct_Date,Correct_WrongAppearance,Correct_Reason,Correct_Plan,Correct_TrackResult,Correct_IsModifyFile,Correct_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Correct_Code,@Correct_Item,@Correct_Dept,@Correct_Date,@Correct_WrongAppearance,@Correct_Reason,@Correct_Plan,@Correct_TrackResult,@Correct_IsModifyFile,@Correct_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Code))
         {
            idb.AddParameter("@Correct_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Code", correct_Preventing.Correct_Code);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Item))
         {
            idb.AddParameter("@Correct_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Item", correct_Preventing.Correct_Item);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Dept))
         {
            idb.AddParameter("@Correct_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Dept", correct_Preventing.Correct_Dept);
         }
         if (correct_Preventing.Correct_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Correct_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Date", correct_Preventing.Correct_Date);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_WrongAppearance))
         {
            idb.AddParameter("@Correct_WrongAppearance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_WrongAppearance", correct_Preventing.Correct_WrongAppearance);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Reason))
         {
            idb.AddParameter("@Correct_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Reason", correct_Preventing.Correct_Reason);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Plan))
         {
            idb.AddParameter("@Correct_Plan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Plan", correct_Preventing.Correct_Plan);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_TrackResult))
         {
            idb.AddParameter("@Correct_TrackResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_TrackResult", correct_Preventing.Correct_TrackResult);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_IsModifyFile))
         {
            idb.AddParameter("@Correct_IsModifyFile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_IsModifyFile", correct_Preventing.Correct_IsModifyFile);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Remark))
         {
            idb.AddParameter("@Correct_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Remark", correct_Preventing.Correct_Remark);
         }
         if (correct_Preventing.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", correct_Preventing.Stat);
         }
         if (correct_Preventing.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", correct_Preventing.CreateDate);
         }
         if (correct_Preventing.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", correct_Preventing.UpdateDate);
         }
         if (correct_Preventing.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", correct_Preventing.DeleteDate);
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
      /// 添加纠正预防措施 Correct_Preventing对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Correct_Preventing correct_Preventing)
      {
         string sql = "INSERT INTO Correct_Preventing (Correct_Code,Correct_Item,Correct_Dept,Correct_Date,Correct_WrongAppearance,Correct_Reason,Correct_Plan,Correct_TrackResult,Correct_IsModifyFile,Correct_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Correct_Code,@Correct_Item,@Correct_Dept,@Correct_Date,@Correct_WrongAppearance,@Correct_Reason,@Correct_Plan,@Correct_TrackResult,@Correct_IsModifyFile,@Correct_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Code))
         {
            idb.AddParameter("@Correct_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Code", correct_Preventing.Correct_Code);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Item))
         {
            idb.AddParameter("@Correct_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Item", correct_Preventing.Correct_Item);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Dept))
         {
            idb.AddParameter("@Correct_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Dept", correct_Preventing.Correct_Dept);
         }
         if (correct_Preventing.Correct_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Correct_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Date", correct_Preventing.Correct_Date);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_WrongAppearance))
         {
            idb.AddParameter("@Correct_WrongAppearance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_WrongAppearance", correct_Preventing.Correct_WrongAppearance);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Reason))
         {
            idb.AddParameter("@Correct_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Reason", correct_Preventing.Correct_Reason);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Plan))
         {
            idb.AddParameter("@Correct_Plan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Plan", correct_Preventing.Correct_Plan);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_TrackResult))
         {
            idb.AddParameter("@Correct_TrackResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_TrackResult", correct_Preventing.Correct_TrackResult);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_IsModifyFile))
         {
            idb.AddParameter("@Correct_IsModifyFile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_IsModifyFile", correct_Preventing.Correct_IsModifyFile);
         }
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Remark))
         {
            idb.AddParameter("@Correct_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Remark", correct_Preventing.Correct_Remark);
         }
         if (correct_Preventing.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", correct_Preventing.Stat);
         }
         if (correct_Preventing.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", correct_Preventing.CreateDate);
         }
         if (correct_Preventing.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", correct_Preventing.UpdateDate);
         }
         if (correct_Preventing.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", correct_Preventing.DeleteDate);
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
      /// 更新纠正预防措施 Correct_Preventing对象(即:一条记录
      /// </summary>
      public int Update(Correct_Preventing correct_Preventing)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Correct_Preventing       SET ");
            if(correct_Preventing.Correct_Code_IsChanged){sbParameter.Append("Correct_Code=@Correct_Code, ");}
      if(correct_Preventing.Correct_Item_IsChanged){sbParameter.Append("Correct_Item=@Correct_Item, ");}
      if(correct_Preventing.Correct_Dept_IsChanged){sbParameter.Append("Correct_Dept=@Correct_Dept, ");}
      if(correct_Preventing.Correct_Date_IsChanged){sbParameter.Append("Correct_Date=@Correct_Date, ");}
      if(correct_Preventing.Correct_WrongAppearance_IsChanged){sbParameter.Append("Correct_WrongAppearance=@Correct_WrongAppearance, ");}
      if(correct_Preventing.Correct_Reason_IsChanged){sbParameter.Append("Correct_Reason=@Correct_Reason, ");}
      if(correct_Preventing.Correct_Plan_IsChanged){sbParameter.Append("Correct_Plan=@Correct_Plan, ");}
      if(correct_Preventing.Correct_TrackResult_IsChanged){sbParameter.Append("Correct_TrackResult=@Correct_TrackResult, ");}
      if(correct_Preventing.Correct_IsModifyFile_IsChanged){sbParameter.Append("Correct_IsModifyFile=@Correct_IsModifyFile, ");}
      if(correct_Preventing.Correct_Remark_IsChanged){sbParameter.Append("Correct_Remark=@Correct_Remark, ");}
      if(correct_Preventing.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(correct_Preventing.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(correct_Preventing.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(correct_Preventing.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Correct_ID=@Correct_ID; " );
      string sql=sb.ToString();
         if(correct_Preventing.Correct_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Code))
         {
            idb.AddParameter("@Correct_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Code", correct_Preventing.Correct_Code);
         }
          }
         if(correct_Preventing.Correct_Item_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Item))
         {
            idb.AddParameter("@Correct_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Item", correct_Preventing.Correct_Item);
         }
          }
         if(correct_Preventing.Correct_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Dept))
         {
            idb.AddParameter("@Correct_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Dept", correct_Preventing.Correct_Dept);
         }
          }
         if(correct_Preventing.Correct_Date_IsChanged)
         {
         if (correct_Preventing.Correct_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Correct_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Date", correct_Preventing.Correct_Date);
         }
          }
         if(correct_Preventing.Correct_WrongAppearance_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_WrongAppearance))
         {
            idb.AddParameter("@Correct_WrongAppearance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_WrongAppearance", correct_Preventing.Correct_WrongAppearance);
         }
          }
         if(correct_Preventing.Correct_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Reason))
         {
            idb.AddParameter("@Correct_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Reason", correct_Preventing.Correct_Reason);
         }
          }
         if(correct_Preventing.Correct_Plan_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Plan))
         {
            idb.AddParameter("@Correct_Plan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Plan", correct_Preventing.Correct_Plan);
         }
          }
         if(correct_Preventing.Correct_TrackResult_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_TrackResult))
         {
            idb.AddParameter("@Correct_TrackResult", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_TrackResult", correct_Preventing.Correct_TrackResult);
         }
          }
         if(correct_Preventing.Correct_IsModifyFile_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_IsModifyFile))
         {
            idb.AddParameter("@Correct_IsModifyFile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_IsModifyFile", correct_Preventing.Correct_IsModifyFile);
         }
          }
         if(correct_Preventing.Correct_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(correct_Preventing.Correct_Remark))
         {
            idb.AddParameter("@Correct_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Correct_Remark", correct_Preventing.Correct_Remark);
         }
          }
         if(correct_Preventing.Stat_IsChanged)
         {
         if (correct_Preventing.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", correct_Preventing.Stat);
         }
          }
         if(correct_Preventing.CreateDate_IsChanged)
         {
         if (correct_Preventing.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", correct_Preventing.CreateDate);
         }
          }
         if(correct_Preventing.UpdateDate_IsChanged)
         {
         if (correct_Preventing.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", correct_Preventing.UpdateDate);
         }
          }
         if(correct_Preventing.DeleteDate_IsChanged)
         {
         if (correct_Preventing.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", correct_Preventing.DeleteDate);
         }
          }

         idb.AddParameter("@Correct_ID", correct_Preventing.Correct_ID);

           
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
      /// 删除纠正预防措施 Correct_Preventing对象(即:一条记录
      /// </summary>
      public int Delete(decimal correct_ID)
      {
         string sql = "DELETE Correct_Preventing WHERE 1=1  AND Correct_ID=@Correct_ID ";
         idb.AddParameter("@Correct_ID", correct_ID);

           
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
      /// 获取指定的纠正预防措施 Correct_Preventing对象(即:一条记录
      /// </summary>
      public Correct_Preventing GetByKey(decimal correct_ID)
      {
         Correct_Preventing correct_Preventing = new Correct_Preventing();
         string sql = "SELECT  Correct_ID,Correct_Code,Correct_Item,Correct_Dept,Correct_Date,Correct_WrongAppearance,Correct_Reason,Correct_Plan,Correct_TrackResult,Correct_IsModifyFile,Correct_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Correct_Preventing WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Correct_ID=@Correct_ID ";
         idb.AddParameter("@Correct_ID", correct_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Correct_ID"] != DBNull.Value) correct_Preventing.Correct_ID = Convert.ToDecimal(dr["Correct_ID"]);
            if (dr["Correct_Code"] != DBNull.Value) correct_Preventing.Correct_Code = Convert.ToString(dr["Correct_Code"]);
            if (dr["Correct_Item"] != DBNull.Value) correct_Preventing.Correct_Item = Convert.ToString(dr["Correct_Item"]);
            if (dr["Correct_Dept"] != DBNull.Value) correct_Preventing.Correct_Dept = Convert.ToString(dr["Correct_Dept"]);
            if (dr["Correct_Date"] != DBNull.Value) correct_Preventing.Correct_Date = Convert.ToDateTime(dr["Correct_Date"]);
            if (dr["Correct_WrongAppearance"] != DBNull.Value) correct_Preventing.Correct_WrongAppearance = Convert.ToString(dr["Correct_WrongAppearance"]);
            if (dr["Correct_Reason"] != DBNull.Value) correct_Preventing.Correct_Reason = Convert.ToString(dr["Correct_Reason"]);
            if (dr["Correct_Plan"] != DBNull.Value) correct_Preventing.Correct_Plan = Convert.ToString(dr["Correct_Plan"]);
            if (dr["Correct_TrackResult"] != DBNull.Value) correct_Preventing.Correct_TrackResult = Convert.ToString(dr["Correct_TrackResult"]);
            if (dr["Correct_IsModifyFile"] != DBNull.Value) correct_Preventing.Correct_IsModifyFile = Convert.ToString(dr["Correct_IsModifyFile"]);
            if (dr["Correct_Remark"] != DBNull.Value) correct_Preventing.Correct_Remark = Convert.ToString(dr["Correct_Remark"]);
            if (dr["Stat"] != DBNull.Value) correct_Preventing.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) correct_Preventing.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) correct_Preventing.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) correct_Preventing.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return correct_Preventing;
      }
      /// <summary>
      /// 获取指定的纠正预防措施 Correct_Preventing对象集合
      /// </summary>
      public List<Correct_Preventing> GetListByWhere(string strCondition)
      {
         List<Correct_Preventing> ret = new List<Correct_Preventing>();
         string sql = "SELECT  Correct_ID,Correct_Code,Correct_Item,Correct_Dept,Correct_Date,Correct_WrongAppearance,Correct_Reason,Correct_Plan,Correct_TrackResult,Correct_IsModifyFile,Correct_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Correct_Preventing WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Correct_Preventing correct_Preventing = new Correct_Preventing();
            if (dr["Correct_ID"] != DBNull.Value) correct_Preventing.Correct_ID = Convert.ToDecimal(dr["Correct_ID"]);
            if (dr["Correct_Code"] != DBNull.Value) correct_Preventing.Correct_Code = Convert.ToString(dr["Correct_Code"]);
            if (dr["Correct_Item"] != DBNull.Value) correct_Preventing.Correct_Item = Convert.ToString(dr["Correct_Item"]);
            if (dr["Correct_Dept"] != DBNull.Value) correct_Preventing.Correct_Dept = Convert.ToString(dr["Correct_Dept"]);
            if (dr["Correct_Date"] != DBNull.Value) correct_Preventing.Correct_Date = Convert.ToDateTime(dr["Correct_Date"]);
            if (dr["Correct_WrongAppearance"] != DBNull.Value) correct_Preventing.Correct_WrongAppearance = Convert.ToString(dr["Correct_WrongAppearance"]);
            if (dr["Correct_Reason"] != DBNull.Value) correct_Preventing.Correct_Reason = Convert.ToString(dr["Correct_Reason"]);
            if (dr["Correct_Plan"] != DBNull.Value) correct_Preventing.Correct_Plan = Convert.ToString(dr["Correct_Plan"]);
            if (dr["Correct_TrackResult"] != DBNull.Value) correct_Preventing.Correct_TrackResult = Convert.ToString(dr["Correct_TrackResult"]);
            if (dr["Correct_IsModifyFile"] != DBNull.Value) correct_Preventing.Correct_IsModifyFile = Convert.ToString(dr["Correct_IsModifyFile"]);
            if (dr["Correct_Remark"] != DBNull.Value) correct_Preventing.Correct_Remark = Convert.ToString(dr["Correct_Remark"]);
            if (dr["Stat"] != DBNull.Value) correct_Preventing.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) correct_Preventing.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) correct_Preventing.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) correct_Preventing.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(correct_Preventing);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的纠正预防措施 Correct_Preventing对象(即:一条记录
      /// </summary>
      public List<Correct_Preventing> GetAll()
      {
         List<Correct_Preventing> ret = new List<Correct_Preventing>();
         string sql = "SELECT  Correct_ID,Correct_Code,Correct_Item,Correct_Dept,Correct_Date,Correct_WrongAppearance,Correct_Reason,Correct_Plan,Correct_TrackResult,Correct_IsModifyFile,Correct_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Correct_Preventing where 1=1 AND ((Stat is null) or (Stat=0) ) order by Correct_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Correct_Preventing correct_Preventing = new Correct_Preventing();
            if (dr["Correct_ID"] != DBNull.Value) correct_Preventing.Correct_ID = Convert.ToDecimal(dr["Correct_ID"]);
            if (dr["Correct_Code"] != DBNull.Value) correct_Preventing.Correct_Code = Convert.ToString(dr["Correct_Code"]);
            if (dr["Correct_Item"] != DBNull.Value) correct_Preventing.Correct_Item = Convert.ToString(dr["Correct_Item"]);
            if (dr["Correct_Dept"] != DBNull.Value) correct_Preventing.Correct_Dept = Convert.ToString(dr["Correct_Dept"]);
            if (dr["Correct_Date"] != DBNull.Value) correct_Preventing.Correct_Date = Convert.ToDateTime(dr["Correct_Date"]);
            if (dr["Correct_WrongAppearance"] != DBNull.Value) correct_Preventing.Correct_WrongAppearance = Convert.ToString(dr["Correct_WrongAppearance"]);
            if (dr["Correct_Reason"] != DBNull.Value) correct_Preventing.Correct_Reason = Convert.ToString(dr["Correct_Reason"]);
            if (dr["Correct_Plan"] != DBNull.Value) correct_Preventing.Correct_Plan = Convert.ToString(dr["Correct_Plan"]);
            if (dr["Correct_TrackResult"] != DBNull.Value) correct_Preventing.Correct_TrackResult = Convert.ToString(dr["Correct_TrackResult"]);
            if (dr["Correct_IsModifyFile"] != DBNull.Value) correct_Preventing.Correct_IsModifyFile = Convert.ToString(dr["Correct_IsModifyFile"]);
            if (dr["Correct_Remark"] != DBNull.Value) correct_Preventing.Correct_Remark = Convert.ToString(dr["Correct_Remark"]);
            if (dr["Stat"] != DBNull.Value) correct_Preventing.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) correct_Preventing.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) correct_Preventing.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) correct_Preventing.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(correct_Preventing);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
