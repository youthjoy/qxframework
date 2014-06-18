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
   public partial class ADOBse_OpLog
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_OpLog对象(即:一条记录)
      /// </summary>
      public int Add(Bse_OpLog bse_OpLog)
      {
         string sql = "INSERT INTO Bse_OpLog (BOL_Code,BOL_Module,BOL_Type,BOL_Operation,BOL_Operator,BOL_OpDate,BOL_Udef1,BOL_Udef2,BOL_Udef3,BOL_Udef4,BOL_Udef5,Stat) VALUES (@BOL_Code,@BOL_Module,@BOL_Type,@BOL_Operation,@BOL_Operator,@BOL_OpDate,@BOL_Udef1,@BOL_Udef2,@BOL_Udef3,@BOL_Udef4,@BOL_Udef5,@Stat)";
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Code))
         {
            idb.AddParameter("@BOL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Code", bse_OpLog.BOL_Code);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Module))
         {
            idb.AddParameter("@BOL_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Module", bse_OpLog.BOL_Module);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Type))
         {
            idb.AddParameter("@BOL_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Type", bse_OpLog.BOL_Type);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Operation))
         {
            idb.AddParameter("@BOL_Operation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Operation", bse_OpLog.BOL_Operation);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Operator))
         {
            idb.AddParameter("@BOL_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Operator", bse_OpLog.BOL_Operator);
         }
         if (bse_OpLog.BOL_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@BOL_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_OpDate", bse_OpLog.BOL_OpDate);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef1))
         {
            idb.AddParameter("@BOL_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef1", bse_OpLog.BOL_Udef1);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef2))
         {
            idb.AddParameter("@BOL_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef2", bse_OpLog.BOL_Udef2);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef3))
         {
            idb.AddParameter("@BOL_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef3", bse_OpLog.BOL_Udef3);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef4))
         {
            idb.AddParameter("@BOL_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef4", bse_OpLog.BOL_Udef4);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef5))
         {
            idb.AddParameter("@BOL_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef5", bse_OpLog.BOL_Udef5);
         }
         if (bse_OpLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_OpLog.Stat);
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
      /// 添加Bse_OpLog对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_OpLog bse_OpLog)
      {
         string sql = "INSERT INTO Bse_OpLog (BOL_Code,BOL_Module,BOL_Type,BOL_Operation,BOL_Operator,BOL_OpDate,BOL_Udef1,BOL_Udef2,BOL_Udef3,BOL_Udef4,BOL_Udef5,Stat) VALUES (@BOL_Code,@BOL_Module,@BOL_Type,@BOL_Operation,@BOL_Operator,@BOL_OpDate,@BOL_Udef1,@BOL_Udef2,@BOL_Udef3,@BOL_Udef4,@BOL_Udef5,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Code))
         {
            idb.AddParameter("@BOL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Code", bse_OpLog.BOL_Code);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Module))
         {
            idb.AddParameter("@BOL_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Module", bse_OpLog.BOL_Module);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Type))
         {
            idb.AddParameter("@BOL_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Type", bse_OpLog.BOL_Type);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Operation))
         {
            idb.AddParameter("@BOL_Operation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Operation", bse_OpLog.BOL_Operation);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Operator))
         {
            idb.AddParameter("@BOL_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Operator", bse_OpLog.BOL_Operator);
         }
         if (bse_OpLog.BOL_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@BOL_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_OpDate", bse_OpLog.BOL_OpDate);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef1))
         {
            idb.AddParameter("@BOL_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef1", bse_OpLog.BOL_Udef1);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef2))
         {
            idb.AddParameter("@BOL_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef2", bse_OpLog.BOL_Udef2);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef3))
         {
            idb.AddParameter("@BOL_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef3", bse_OpLog.BOL_Udef3);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef4))
         {
            idb.AddParameter("@BOL_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef4", bse_OpLog.BOL_Udef4);
         }
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef5))
         {
            idb.AddParameter("@BOL_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef5", bse_OpLog.BOL_Udef5);
         }
         if (bse_OpLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_OpLog.Stat);
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
      /// 更新Bse_OpLog对象(即:一条记录
      /// </summary>
      public int Update(Bse_OpLog bse_OpLog)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_OpLog       SET ");
            if(bse_OpLog.BOL_Code_IsChanged){sbParameter.Append("BOL_Code=@BOL_Code, ");}
      if(bse_OpLog.BOL_Module_IsChanged){sbParameter.Append("BOL_Module=@BOL_Module, ");}
      if(bse_OpLog.BOL_Type_IsChanged){sbParameter.Append("BOL_Type=@BOL_Type, ");}
      if(bse_OpLog.BOL_Operation_IsChanged){sbParameter.Append("BOL_Operation=@BOL_Operation, ");}
      if(bse_OpLog.BOL_Operator_IsChanged){sbParameter.Append("BOL_Operator=@BOL_Operator, ");}
      if(bse_OpLog.BOL_OpDate_IsChanged){sbParameter.Append("BOL_OpDate=@BOL_OpDate, ");}
      if(bse_OpLog.BOL_Udef1_IsChanged){sbParameter.Append("BOL_Udef1=@BOL_Udef1, ");}
      if(bse_OpLog.BOL_Udef2_IsChanged){sbParameter.Append("BOL_Udef2=@BOL_Udef2, ");}
      if(bse_OpLog.BOL_Udef3_IsChanged){sbParameter.Append("BOL_Udef3=@BOL_Udef3, ");}
      if(bse_OpLog.BOL_Udef4_IsChanged){sbParameter.Append("BOL_Udef4=@BOL_Udef4, ");}
      if(bse_OpLog.BOL_Udef5_IsChanged){sbParameter.Append("BOL_Udef5=@BOL_Udef5, ");}
      if(bse_OpLog.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and BOL_ID=@BOL_ID; " );
      string sql=sb.ToString();
         if(bse_OpLog.BOL_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Code))
         {
            idb.AddParameter("@BOL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Code", bse_OpLog.BOL_Code);
         }
          }
         if(bse_OpLog.BOL_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Module))
         {
            idb.AddParameter("@BOL_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Module", bse_OpLog.BOL_Module);
         }
          }
         if(bse_OpLog.BOL_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Type))
         {
            idb.AddParameter("@BOL_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Type", bse_OpLog.BOL_Type);
         }
          }
         if(bse_OpLog.BOL_Operation_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Operation))
         {
            idb.AddParameter("@BOL_Operation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Operation", bse_OpLog.BOL_Operation);
         }
          }
         if(bse_OpLog.BOL_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Operator))
         {
            idb.AddParameter("@BOL_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Operator", bse_OpLog.BOL_Operator);
         }
          }
         if(bse_OpLog.BOL_OpDate_IsChanged)
         {
         if (bse_OpLog.BOL_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@BOL_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_OpDate", bse_OpLog.BOL_OpDate);
         }
          }
         if(bse_OpLog.BOL_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef1))
         {
            idb.AddParameter("@BOL_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef1", bse_OpLog.BOL_Udef1);
         }
          }
         if(bse_OpLog.BOL_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef2))
         {
            idb.AddParameter("@BOL_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef2", bse_OpLog.BOL_Udef2);
         }
          }
         if(bse_OpLog.BOL_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef3))
         {
            idb.AddParameter("@BOL_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef3", bse_OpLog.BOL_Udef3);
         }
          }
         if(bse_OpLog.BOL_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef4))
         {
            idb.AddParameter("@BOL_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef4", bse_OpLog.BOL_Udef4);
         }
          }
         if(bse_OpLog.BOL_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_OpLog.BOL_Udef5))
         {
            idb.AddParameter("@BOL_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BOL_Udef5", bse_OpLog.BOL_Udef5);
         }
          }
         if(bse_OpLog.Stat_IsChanged)
         {
         if (bse_OpLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_OpLog.Stat);
         }
          }

         idb.AddParameter("@BOL_ID", bse_OpLog.BOL_ID);

           
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
      /// 删除Bse_OpLog对象(即:一条记录
      /// </summary>
      public int Delete(decimal bOL_ID)
      {
         string sql = "DELETE Bse_OpLog WHERE 1=1  AND BOL_ID=@BOL_ID ";
         idb.AddParameter("@BOL_ID", bOL_ID);

           
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
      /// 获取指定的Bse_OpLog对象(即:一条记录
      /// </summary>
      public Bse_OpLog GetByKey(decimal bOL_ID)
      {
         Bse_OpLog bse_OpLog = new Bse_OpLog();
         string sql = "SELECT  BOL_ID,BOL_Code,BOL_Module,BOL_Type,BOL_Operation,BOL_Operator,BOL_OpDate,BOL_Udef1,BOL_Udef2,BOL_Udef3,BOL_Udef4,BOL_Udef5,Stat FROM Bse_OpLog WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND BOL_ID=@BOL_ID ";
         idb.AddParameter("@BOL_ID", bOL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["BOL_ID"] != DBNull.Value) bse_OpLog.BOL_ID = Convert.ToDecimal(dr["BOL_ID"]);
            if (dr["BOL_Code"] != DBNull.Value) bse_OpLog.BOL_Code = Convert.ToString(dr["BOL_Code"]);
            if (dr["BOL_Module"] != DBNull.Value) bse_OpLog.BOL_Module = Convert.ToString(dr["BOL_Module"]);
            if (dr["BOL_Type"] != DBNull.Value) bse_OpLog.BOL_Type = Convert.ToString(dr["BOL_Type"]);
            if (dr["BOL_Operation"] != DBNull.Value) bse_OpLog.BOL_Operation = Convert.ToString(dr["BOL_Operation"]);
            if (dr["BOL_Operator"] != DBNull.Value) bse_OpLog.BOL_Operator = Convert.ToString(dr["BOL_Operator"]);
            if (dr["BOL_OpDate"] != DBNull.Value) bse_OpLog.BOL_OpDate = Convert.ToDateTime(dr["BOL_OpDate"]);
            if (dr["BOL_Udef1"] != DBNull.Value) bse_OpLog.BOL_Udef1 = Convert.ToString(dr["BOL_Udef1"]);
            if (dr["BOL_Udef2"] != DBNull.Value) bse_OpLog.BOL_Udef2 = Convert.ToString(dr["BOL_Udef2"]);
            if (dr["BOL_Udef3"] != DBNull.Value) bse_OpLog.BOL_Udef3 = Convert.ToString(dr["BOL_Udef3"]);
            if (dr["BOL_Udef4"] != DBNull.Value) bse_OpLog.BOL_Udef4 = Convert.ToString(dr["BOL_Udef4"]);
            if (dr["BOL_Udef5"] != DBNull.Value) bse_OpLog.BOL_Udef5 = Convert.ToString(dr["BOL_Udef5"]);
            if (dr["Stat"] != DBNull.Value) bse_OpLog.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_OpLog;
      }
      /// <summary>
      /// 获取指定的Bse_OpLog对象集合
      /// </summary>
      public List<Bse_OpLog> GetListByWhere(string strCondition)
      {
         List<Bse_OpLog> ret = new List<Bse_OpLog>();
         string sql = "SELECT  BOL_ID,BOL_Code,BOL_Module,BOL_Type,BOL_Operation,BOL_Operator,BOL_OpDate,BOL_Udef1,BOL_Udef2,BOL_Udef3,BOL_Udef4,BOL_Udef5,Stat FROM Bse_OpLog WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_OpLog bse_OpLog = new Bse_OpLog();
            if (dr["BOL_ID"] != DBNull.Value) bse_OpLog.BOL_ID = Convert.ToDecimal(dr["BOL_ID"]);
            if (dr["BOL_Code"] != DBNull.Value) bse_OpLog.BOL_Code = Convert.ToString(dr["BOL_Code"]);
            if (dr["BOL_Module"] != DBNull.Value) bse_OpLog.BOL_Module = Convert.ToString(dr["BOL_Module"]);
            if (dr["BOL_Type"] != DBNull.Value) bse_OpLog.BOL_Type = Convert.ToString(dr["BOL_Type"]);
            if (dr["BOL_Operation"] != DBNull.Value) bse_OpLog.BOL_Operation = Convert.ToString(dr["BOL_Operation"]);
            if (dr["BOL_Operator"] != DBNull.Value) bse_OpLog.BOL_Operator = Convert.ToString(dr["BOL_Operator"]);
            if (dr["BOL_OpDate"] != DBNull.Value) bse_OpLog.BOL_OpDate = Convert.ToDateTime(dr["BOL_OpDate"]);
            if (dr["BOL_Udef1"] != DBNull.Value) bse_OpLog.BOL_Udef1 = Convert.ToString(dr["BOL_Udef1"]);
            if (dr["BOL_Udef2"] != DBNull.Value) bse_OpLog.BOL_Udef2 = Convert.ToString(dr["BOL_Udef2"]);
            if (dr["BOL_Udef3"] != DBNull.Value) bse_OpLog.BOL_Udef3 = Convert.ToString(dr["BOL_Udef3"]);
            if (dr["BOL_Udef4"] != DBNull.Value) bse_OpLog.BOL_Udef4 = Convert.ToString(dr["BOL_Udef4"]);
            if (dr["BOL_Udef5"] != DBNull.Value) bse_OpLog.BOL_Udef5 = Convert.ToString(dr["BOL_Udef5"]);
            if (dr["Stat"] != DBNull.Value) bse_OpLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_OpLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_OpLog对象(即:一条记录
      /// </summary>
      public List<Bse_OpLog> GetAll()
      {
         List<Bse_OpLog> ret = new List<Bse_OpLog>();
         string sql = "SELECT  BOL_ID,BOL_Code,BOL_Module,BOL_Type,BOL_Operation,BOL_Operator,BOL_OpDate,BOL_Udef1,BOL_Udef2,BOL_Udef3,BOL_Udef4,BOL_Udef5,Stat FROM Bse_OpLog where 1=1 AND ((Stat is null) or (Stat=0) ) order by BOL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_OpLog bse_OpLog = new Bse_OpLog();
            if (dr["BOL_ID"] != DBNull.Value) bse_OpLog.BOL_ID = Convert.ToDecimal(dr["BOL_ID"]);
            if (dr["BOL_Code"] != DBNull.Value) bse_OpLog.BOL_Code = Convert.ToString(dr["BOL_Code"]);
            if (dr["BOL_Module"] != DBNull.Value) bse_OpLog.BOL_Module = Convert.ToString(dr["BOL_Module"]);
            if (dr["BOL_Type"] != DBNull.Value) bse_OpLog.BOL_Type = Convert.ToString(dr["BOL_Type"]);
            if (dr["BOL_Operation"] != DBNull.Value) bse_OpLog.BOL_Operation = Convert.ToString(dr["BOL_Operation"]);
            if (dr["BOL_Operator"] != DBNull.Value) bse_OpLog.BOL_Operator = Convert.ToString(dr["BOL_Operator"]);
            if (dr["BOL_OpDate"] != DBNull.Value) bse_OpLog.BOL_OpDate = Convert.ToDateTime(dr["BOL_OpDate"]);
            if (dr["BOL_Udef1"] != DBNull.Value) bse_OpLog.BOL_Udef1 = Convert.ToString(dr["BOL_Udef1"]);
            if (dr["BOL_Udef2"] != DBNull.Value) bse_OpLog.BOL_Udef2 = Convert.ToString(dr["BOL_Udef2"]);
            if (dr["BOL_Udef3"] != DBNull.Value) bse_OpLog.BOL_Udef3 = Convert.ToString(dr["BOL_Udef3"]);
            if (dr["BOL_Udef4"] != DBNull.Value) bse_OpLog.BOL_Udef4 = Convert.ToString(dr["BOL_Udef4"]);
            if (dr["BOL_Udef5"] != DBNull.Value) bse_OpLog.BOL_Udef5 = Convert.ToString(dr["BOL_Udef5"]);
            if (dr["Stat"] != DBNull.Value) bse_OpLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_OpLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
