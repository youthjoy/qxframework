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
   /// 快件收发表
   /// </summary>
   [Serializable]
   public partial class ADOExpress_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加快件收发表 Express_Record对象(即:一条记录)
      /// </summary>
      public int Add(Express_Record express_Record)
      {
         string sql = "INSERT INTO Express_Record (ERecord_Code,ERecord_Name,ERecord_Count,ERecord_Unit,ERecord_Date,ERecord_Person,ERecord_Remark,ERecord_Dept,ERecord_Company,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@ERecord_Code,@ERecord_Name,@ERecord_Count,@ERecord_Unit,@ERecord_Date,@ERecord_Person,@ERecord_Remark,@ERecord_Dept,@ERecord_Company,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(express_Record.ERecord_Code))
         {
            idb.AddParameter("@ERecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Code", express_Record.ERecord_Code);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Name))
         {
            idb.AddParameter("@ERecord_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Name", express_Record.ERecord_Name);
         }
         if (express_Record.ERecord_Count == 0)
         {
            idb.AddParameter("@ERecord_Count", 0);
         }
         else
         {
            idb.AddParameter("@ERecord_Count", express_Record.ERecord_Count);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Unit))
         {
            idb.AddParameter("@ERecord_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Unit", express_Record.ERecord_Unit);
         }
         if (express_Record.ERecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@ERecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Date", express_Record.ERecord_Date);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Person))
         {
            idb.AddParameter("@ERecord_Person", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Person", express_Record.ERecord_Person);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Remark))
         {
            idb.AddParameter("@ERecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Remark", express_Record.ERecord_Remark);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Dept))
         {
            idb.AddParameter("@ERecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Dept", express_Record.ERecord_Dept);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Company))
         {
            idb.AddParameter("@ERecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Company", express_Record.ERecord_Company);
         }
         if (express_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", express_Record.Stat);
         }
         if (express_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", express_Record.CreateDate);
         }
         if (express_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", express_Record.UpdateDate);
         }
         if (express_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", express_Record.DeleteDate);
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
      /// 添加快件收发表 Express_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Express_Record express_Record)
      {
         string sql = "INSERT INTO Express_Record (ERecord_Code,ERecord_Name,ERecord_Count,ERecord_Unit,ERecord_Date,ERecord_Person,ERecord_Remark,ERecord_Dept,ERecord_Company,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@ERecord_Code,@ERecord_Name,@ERecord_Count,@ERecord_Unit,@ERecord_Date,@ERecord_Person,@ERecord_Remark,@ERecord_Dept,@ERecord_Company,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(express_Record.ERecord_Code))
         {
            idb.AddParameter("@ERecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Code", express_Record.ERecord_Code);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Name))
         {
            idb.AddParameter("@ERecord_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Name", express_Record.ERecord_Name);
         }
         if (express_Record.ERecord_Count == 0)
         {
            idb.AddParameter("@ERecord_Count", 0);
         }
         else
         {
            idb.AddParameter("@ERecord_Count", express_Record.ERecord_Count);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Unit))
         {
            idb.AddParameter("@ERecord_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Unit", express_Record.ERecord_Unit);
         }
         if (express_Record.ERecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@ERecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Date", express_Record.ERecord_Date);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Person))
         {
            idb.AddParameter("@ERecord_Person", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Person", express_Record.ERecord_Person);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Remark))
         {
            idb.AddParameter("@ERecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Remark", express_Record.ERecord_Remark);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Dept))
         {
            idb.AddParameter("@ERecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Dept", express_Record.ERecord_Dept);
         }
         if (string.IsNullOrEmpty(express_Record.ERecord_Company))
         {
            idb.AddParameter("@ERecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Company", express_Record.ERecord_Company);
         }
         if (express_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", express_Record.Stat);
         }
         if (express_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", express_Record.CreateDate);
         }
         if (express_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", express_Record.UpdateDate);
         }
         if (express_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", express_Record.DeleteDate);
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
      /// 更新快件收发表 Express_Record对象(即:一条记录
      /// </summary>
      public int Update(Express_Record express_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Express_Record       SET ");
            if(express_Record.ERecord_Code_IsChanged){sbParameter.Append("ERecord_Code=@ERecord_Code, ");}
      if(express_Record.ERecord_Name_IsChanged){sbParameter.Append("ERecord_Name=@ERecord_Name, ");}
      if(express_Record.ERecord_Count_IsChanged){sbParameter.Append("ERecord_Count=@ERecord_Count, ");}
      if(express_Record.ERecord_Unit_IsChanged){sbParameter.Append("ERecord_Unit=@ERecord_Unit, ");}
      if(express_Record.ERecord_Date_IsChanged){sbParameter.Append("ERecord_Date=@ERecord_Date, ");}
      if(express_Record.ERecord_Person_IsChanged){sbParameter.Append("ERecord_Person=@ERecord_Person, ");}
      if(express_Record.ERecord_Remark_IsChanged){sbParameter.Append("ERecord_Remark=@ERecord_Remark, ");}
      if(express_Record.ERecord_Dept_IsChanged){sbParameter.Append("ERecord_Dept=@ERecord_Dept, ");}
      if(express_Record.ERecord_Company_IsChanged){sbParameter.Append("ERecord_Company=@ERecord_Company, ");}
      if(express_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(express_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(express_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(express_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and ERecord_ID=@ERecord_ID; " );
      string sql=sb.ToString();
         if(express_Record.ERecord_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(express_Record.ERecord_Code))
         {
            idb.AddParameter("@ERecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Code", express_Record.ERecord_Code);
         }
          }
         if(express_Record.ERecord_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(express_Record.ERecord_Name))
         {
            idb.AddParameter("@ERecord_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Name", express_Record.ERecord_Name);
         }
          }
         if(express_Record.ERecord_Count_IsChanged)
         {
         if (express_Record.ERecord_Count == 0)
         {
            idb.AddParameter("@ERecord_Count", 0);
         }
         else
         {
            idb.AddParameter("@ERecord_Count", express_Record.ERecord_Count);
         }
          }
         if(express_Record.ERecord_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(express_Record.ERecord_Unit))
         {
            idb.AddParameter("@ERecord_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Unit", express_Record.ERecord_Unit);
         }
          }
         if(express_Record.ERecord_Date_IsChanged)
         {
         if (express_Record.ERecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@ERecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Date", express_Record.ERecord_Date);
         }
          }
         if(express_Record.ERecord_Person_IsChanged)
         {
         if (string.IsNullOrEmpty(express_Record.ERecord_Person))
         {
            idb.AddParameter("@ERecord_Person", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Person", express_Record.ERecord_Person);
         }
          }
         if(express_Record.ERecord_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(express_Record.ERecord_Remark))
         {
            idb.AddParameter("@ERecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Remark", express_Record.ERecord_Remark);
         }
          }
         if(express_Record.ERecord_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(express_Record.ERecord_Dept))
         {
            idb.AddParameter("@ERecord_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Dept", express_Record.ERecord_Dept);
         }
          }
         if(express_Record.ERecord_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(express_Record.ERecord_Company))
         {
            idb.AddParameter("@ERecord_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ERecord_Company", express_Record.ERecord_Company);
         }
          }
         if(express_Record.Stat_IsChanged)
         {
         if (express_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", express_Record.Stat);
         }
          }
         if(express_Record.CreateDate_IsChanged)
         {
         if (express_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", express_Record.CreateDate);
         }
          }
         if(express_Record.UpdateDate_IsChanged)
         {
         if (express_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", express_Record.UpdateDate);
         }
          }
         if(express_Record.DeleteDate_IsChanged)
         {
         if (express_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", express_Record.DeleteDate);
         }
          }

         idb.AddParameter("@ERecord_ID", express_Record.ERecord_ID);

           
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
      /// 删除快件收发表 Express_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal eRecord_ID)
      {
         string sql = "DELETE Express_Record WHERE 1=1  AND ERecord_ID=@ERecord_ID ";
         idb.AddParameter("@ERecord_ID", eRecord_ID);

           
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
      /// 获取指定的快件收发表 Express_Record对象(即:一条记录
      /// </summary>
      public Express_Record GetByKey(decimal eRecord_ID)
      {
         Express_Record express_Record = new Express_Record();
         string sql = "SELECT  ERecord_ID,ERecord_Code,ERecord_Name,ERecord_Count,ERecord_Unit,ERecord_Date,ERecord_Person,ERecord_Remark,ERecord_Dept,ERecord_Company,Stat,CreateDate,UpdateDate,DeleteDate FROM Express_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND ERecord_ID=@ERecord_ID ";
         idb.AddParameter("@ERecord_ID", eRecord_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["ERecord_ID"] != DBNull.Value) express_Record.ERecord_ID = Convert.ToDecimal(dr["ERecord_ID"]);
            if (dr["ERecord_Code"] != DBNull.Value) express_Record.ERecord_Code = Convert.ToString(dr["ERecord_Code"]);
            if (dr["ERecord_Name"] != DBNull.Value) express_Record.ERecord_Name = Convert.ToString(dr["ERecord_Name"]);
            if (dr["ERecord_Count"] != DBNull.Value) express_Record.ERecord_Count = Convert.ToInt32(dr["ERecord_Count"]);
            if (dr["ERecord_Unit"] != DBNull.Value) express_Record.ERecord_Unit = Convert.ToString(dr["ERecord_Unit"]);
            if (dr["ERecord_Date"] != DBNull.Value) express_Record.ERecord_Date = Convert.ToDateTime(dr["ERecord_Date"]);
            if (dr["ERecord_Person"] != DBNull.Value) express_Record.ERecord_Person = Convert.ToString(dr["ERecord_Person"]);
            if (dr["ERecord_Remark"] != DBNull.Value) express_Record.ERecord_Remark = Convert.ToString(dr["ERecord_Remark"]);
            if (dr["ERecord_Dept"] != DBNull.Value) express_Record.ERecord_Dept = Convert.ToString(dr["ERecord_Dept"]);
            if (dr["ERecord_Company"] != DBNull.Value) express_Record.ERecord_Company = Convert.ToString(dr["ERecord_Company"]);
            if (dr["Stat"] != DBNull.Value) express_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) express_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) express_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) express_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return express_Record;
      }
      /// <summary>
      /// 获取指定的快件收发表 Express_Record对象集合
      /// </summary>
      public List<Express_Record> GetListByWhere(string strCondition)
      {
         List<Express_Record> ret = new List<Express_Record>();
         string sql = "SELECT  ERecord_ID,ERecord_Code,ERecord_Name,ERecord_Count,ERecord_Unit,ERecord_Date,ERecord_Person,ERecord_Remark,ERecord_Dept,ERecord_Company,Stat,CreateDate,UpdateDate,DeleteDate FROM Express_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Express_Record express_Record = new Express_Record();
            if (dr["ERecord_ID"] != DBNull.Value) express_Record.ERecord_ID = Convert.ToDecimal(dr["ERecord_ID"]);
            if (dr["ERecord_Code"] != DBNull.Value) express_Record.ERecord_Code = Convert.ToString(dr["ERecord_Code"]);
            if (dr["ERecord_Name"] != DBNull.Value) express_Record.ERecord_Name = Convert.ToString(dr["ERecord_Name"]);
            if (dr["ERecord_Count"] != DBNull.Value) express_Record.ERecord_Count = Convert.ToInt32(dr["ERecord_Count"]);
            if (dr["ERecord_Unit"] != DBNull.Value) express_Record.ERecord_Unit = Convert.ToString(dr["ERecord_Unit"]);
            if (dr["ERecord_Date"] != DBNull.Value) express_Record.ERecord_Date = Convert.ToDateTime(dr["ERecord_Date"]);
            if (dr["ERecord_Person"] != DBNull.Value) express_Record.ERecord_Person = Convert.ToString(dr["ERecord_Person"]);
            if (dr["ERecord_Remark"] != DBNull.Value) express_Record.ERecord_Remark = Convert.ToString(dr["ERecord_Remark"]);
            if (dr["ERecord_Dept"] != DBNull.Value) express_Record.ERecord_Dept = Convert.ToString(dr["ERecord_Dept"]);
            if (dr["ERecord_Company"] != DBNull.Value) express_Record.ERecord_Company = Convert.ToString(dr["ERecord_Company"]);
            if (dr["Stat"] != DBNull.Value) express_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) express_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) express_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) express_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(express_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的快件收发表 Express_Record对象(即:一条记录
      /// </summary>
      public List<Express_Record> GetAll()
      {
         List<Express_Record> ret = new List<Express_Record>();
         string sql = "SELECT  ERecord_ID,ERecord_Code,ERecord_Name,ERecord_Count,ERecord_Unit,ERecord_Date,ERecord_Person,ERecord_Remark,ERecord_Dept,ERecord_Company,Stat,CreateDate,UpdateDate,DeleteDate FROM Express_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by ERecord_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Express_Record express_Record = new Express_Record();
            if (dr["ERecord_ID"] != DBNull.Value) express_Record.ERecord_ID = Convert.ToDecimal(dr["ERecord_ID"]);
            if (dr["ERecord_Code"] != DBNull.Value) express_Record.ERecord_Code = Convert.ToString(dr["ERecord_Code"]);
            if (dr["ERecord_Name"] != DBNull.Value) express_Record.ERecord_Name = Convert.ToString(dr["ERecord_Name"]);
            if (dr["ERecord_Count"] != DBNull.Value) express_Record.ERecord_Count = Convert.ToInt32(dr["ERecord_Count"]);
            if (dr["ERecord_Unit"] != DBNull.Value) express_Record.ERecord_Unit = Convert.ToString(dr["ERecord_Unit"]);
            if (dr["ERecord_Date"] != DBNull.Value) express_Record.ERecord_Date = Convert.ToDateTime(dr["ERecord_Date"]);
            if (dr["ERecord_Person"] != DBNull.Value) express_Record.ERecord_Person = Convert.ToString(dr["ERecord_Person"]);
            if (dr["ERecord_Remark"] != DBNull.Value) express_Record.ERecord_Remark = Convert.ToString(dr["ERecord_Remark"]);
            if (dr["ERecord_Dept"] != DBNull.Value) express_Record.ERecord_Dept = Convert.ToString(dr["ERecord_Dept"]);
            if (dr["ERecord_Company"] != DBNull.Value) express_Record.ERecord_Company = Convert.ToString(dr["ERecord_Company"]);
            if (dr["Stat"] != DBNull.Value) express_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) express_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) express_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) express_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(express_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
