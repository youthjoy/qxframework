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
   /// 印刷品明细表
   /// </summary>
   [Serializable]
   public partial class ADOPrint_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加印刷品明细表 Print_Record对象(即:一条记录)
      /// </summary>
      public int Add(Print_Record print_Record)
      {
         string sql = "INSERT INTO Print_Record (Print_Code,Print_Date,Print_Company,Print_Dept,Print_Name,Print_Count,Print_Unit,Print_Cost,Print_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Print_Code,@Print_Date,@Print_Company,@Print_Dept,@Print_Name,@Print_Count,@Print_Unit,@Print_Cost,@Print_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(print_Record.Print_Code))
         {
            idb.AddParameter("@Print_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Code", print_Record.Print_Code);
         }
         if (print_Record.Print_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Print_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Date", print_Record.Print_Date);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Company))
         {
            idb.AddParameter("@Print_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Company", print_Record.Print_Company);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Dept))
         {
            idb.AddParameter("@Print_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Dept", print_Record.Print_Dept);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Name))
         {
            idb.AddParameter("@Print_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Name", print_Record.Print_Name);
         }
         if (print_Record.Print_Count == 0)
         {
            idb.AddParameter("@Print_Count", 0);
         }
         else
         {
            idb.AddParameter("@Print_Count", print_Record.Print_Count);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Unit))
         {
            idb.AddParameter("@Print_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Unit", print_Record.Print_Unit);
         }
         if (print_Record.Print_Cost == 0)
         {
            idb.AddParameter("@Print_Cost", 0);
         }
         else
         {
            idb.AddParameter("@Print_Cost", print_Record.Print_Cost);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Remark))
         {
            idb.AddParameter("@Print_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Remark", print_Record.Print_Remark);
         }
         if (print_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", print_Record.Stat);
         }
         if (print_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", print_Record.CreateDate);
         }
         if (print_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", print_Record.UpdateDate);
         }
         if (print_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", print_Record.DeleteDate);
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
      /// 添加印刷品明细表 Print_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Print_Record print_Record)
      {
         string sql = "INSERT INTO Print_Record (Print_Code,Print_Date,Print_Company,Print_Dept,Print_Name,Print_Count,Print_Unit,Print_Cost,Print_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Print_Code,@Print_Date,@Print_Company,@Print_Dept,@Print_Name,@Print_Count,@Print_Unit,@Print_Cost,@Print_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(print_Record.Print_Code))
         {
            idb.AddParameter("@Print_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Code", print_Record.Print_Code);
         }
         if (print_Record.Print_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Print_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Date", print_Record.Print_Date);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Company))
         {
            idb.AddParameter("@Print_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Company", print_Record.Print_Company);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Dept))
         {
            idb.AddParameter("@Print_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Dept", print_Record.Print_Dept);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Name))
         {
            idb.AddParameter("@Print_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Name", print_Record.Print_Name);
         }
         if (print_Record.Print_Count == 0)
         {
            idb.AddParameter("@Print_Count", 0);
         }
         else
         {
            idb.AddParameter("@Print_Count", print_Record.Print_Count);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Unit))
         {
            idb.AddParameter("@Print_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Unit", print_Record.Print_Unit);
         }
         if (print_Record.Print_Cost == 0)
         {
            idb.AddParameter("@Print_Cost", 0);
         }
         else
         {
            idb.AddParameter("@Print_Cost", print_Record.Print_Cost);
         }
         if (string.IsNullOrEmpty(print_Record.Print_Remark))
         {
            idb.AddParameter("@Print_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Remark", print_Record.Print_Remark);
         }
         if (print_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", print_Record.Stat);
         }
         if (print_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", print_Record.CreateDate);
         }
         if (print_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", print_Record.UpdateDate);
         }
         if (print_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", print_Record.DeleteDate);
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
      /// 更新印刷品明细表 Print_Record对象(即:一条记录
      /// </summary>
      public int Update(Print_Record print_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Print_Record       SET ");
            if(print_Record.Print_Code_IsChanged){sbParameter.Append("Print_Code=@Print_Code, ");}
      if(print_Record.Print_Date_IsChanged){sbParameter.Append("Print_Date=@Print_Date, ");}
      if(print_Record.Print_Company_IsChanged){sbParameter.Append("Print_Company=@Print_Company, ");}
      if(print_Record.Print_Dept_IsChanged){sbParameter.Append("Print_Dept=@Print_Dept, ");}
      if(print_Record.Print_Name_IsChanged){sbParameter.Append("Print_Name=@Print_Name, ");}
      if(print_Record.Print_Count_IsChanged){sbParameter.Append("Print_Count=@Print_Count, ");}
      if(print_Record.Print_Unit_IsChanged){sbParameter.Append("Print_Unit=@Print_Unit, ");}
      if(print_Record.Print_Cost_IsChanged){sbParameter.Append("Print_Cost=@Print_Cost, ");}
      if(print_Record.Print_Remark_IsChanged){sbParameter.Append("Print_Remark=@Print_Remark, ");}
      if(print_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(print_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(print_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(print_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Print_ID=@Print_ID; " );
      string sql=sb.ToString();
         if(print_Record.Print_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(print_Record.Print_Code))
         {
            idb.AddParameter("@Print_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Code", print_Record.Print_Code);
         }
          }
         if(print_Record.Print_Date_IsChanged)
         {
         if (print_Record.Print_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Print_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Date", print_Record.Print_Date);
         }
          }
         if(print_Record.Print_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(print_Record.Print_Company))
         {
            idb.AddParameter("@Print_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Company", print_Record.Print_Company);
         }
          }
         if(print_Record.Print_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(print_Record.Print_Dept))
         {
            idb.AddParameter("@Print_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Dept", print_Record.Print_Dept);
         }
          }
         if(print_Record.Print_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(print_Record.Print_Name))
         {
            idb.AddParameter("@Print_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Name", print_Record.Print_Name);
         }
          }
         if(print_Record.Print_Count_IsChanged)
         {
         if (print_Record.Print_Count == 0)
         {
            idb.AddParameter("@Print_Count", 0);
         }
         else
         {
            idb.AddParameter("@Print_Count", print_Record.Print_Count);
         }
          }
         if(print_Record.Print_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(print_Record.Print_Unit))
         {
            idb.AddParameter("@Print_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Unit", print_Record.Print_Unit);
         }
          }
         if(print_Record.Print_Cost_IsChanged)
         {
         if (print_Record.Print_Cost == 0)
         {
            idb.AddParameter("@Print_Cost", 0);
         }
         else
         {
            idb.AddParameter("@Print_Cost", print_Record.Print_Cost);
         }
          }
         if(print_Record.Print_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(print_Record.Print_Remark))
         {
            idb.AddParameter("@Print_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Print_Remark", print_Record.Print_Remark);
         }
          }
         if(print_Record.Stat_IsChanged)
         {
         if (print_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", print_Record.Stat);
         }
          }
         if(print_Record.CreateDate_IsChanged)
         {
         if (print_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", print_Record.CreateDate);
         }
          }
         if(print_Record.UpdateDate_IsChanged)
         {
         if (print_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", print_Record.UpdateDate);
         }
          }
         if(print_Record.DeleteDate_IsChanged)
         {
         if (print_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", print_Record.DeleteDate);
         }
          }

         idb.AddParameter("@Print_ID", print_Record.Print_ID);

           
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
      /// 删除印刷品明细表 Print_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal print_ID)
      {
         string sql = "DELETE Print_Record WHERE 1=1  AND Print_ID=@Print_ID ";
         idb.AddParameter("@Print_ID", print_ID);

           
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
      /// 获取指定的印刷品明细表 Print_Record对象(即:一条记录
      /// </summary>
      public Print_Record GetByKey(decimal print_ID)
      {
         Print_Record print_Record = new Print_Record();
         string sql = "SELECT  Print_ID,Print_Code,Print_Date,Print_Company,Print_Dept,Print_Name,Print_Count,Print_Unit,Print_Cost,Print_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Print_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Print_ID=@Print_ID ";
         idb.AddParameter("@Print_ID", print_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Print_ID"] != DBNull.Value) print_Record.Print_ID = Convert.ToDecimal(dr["Print_ID"]);
            if (dr["Print_Code"] != DBNull.Value) print_Record.Print_Code = Convert.ToString(dr["Print_Code"]);
            if (dr["Print_Date"] != DBNull.Value) print_Record.Print_Date = Convert.ToDateTime(dr["Print_Date"]);
            if (dr["Print_Company"] != DBNull.Value) print_Record.Print_Company = Convert.ToString(dr["Print_Company"]);
            if (dr["Print_Dept"] != DBNull.Value) print_Record.Print_Dept = Convert.ToString(dr["Print_Dept"]);
            if (dr["Print_Name"] != DBNull.Value) print_Record.Print_Name = Convert.ToString(dr["Print_Name"]);
            if (dr["Print_Count"] != DBNull.Value) print_Record.Print_Count = Convert.ToInt32(dr["Print_Count"]);
            if (dr["Print_Unit"] != DBNull.Value) print_Record.Print_Unit = Convert.ToString(dr["Print_Unit"]);
            if (dr["Print_Cost"] != DBNull.Value) print_Record.Print_Cost = Convert.ToDecimal(dr["Print_Cost"]);
            if (dr["Print_Remark"] != DBNull.Value) print_Record.Print_Remark = Convert.ToString(dr["Print_Remark"]);
            if (dr["Stat"] != DBNull.Value) print_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) print_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) print_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) print_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return print_Record;
      }
      /// <summary>
      /// 获取指定的印刷品明细表 Print_Record对象集合
      /// </summary>
      public List<Print_Record> GetListByWhere(string strCondition)
      {
         List<Print_Record> ret = new List<Print_Record>();
         string sql = "SELECT  Print_ID,Print_Code,Print_Date,Print_Company,Print_Dept,Print_Name,Print_Count,Print_Unit,Print_Cost,Print_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Print_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Print_Record print_Record = new Print_Record();
            if (dr["Print_ID"] != DBNull.Value) print_Record.Print_ID = Convert.ToDecimal(dr["Print_ID"]);
            if (dr["Print_Code"] != DBNull.Value) print_Record.Print_Code = Convert.ToString(dr["Print_Code"]);
            if (dr["Print_Date"] != DBNull.Value) print_Record.Print_Date = Convert.ToDateTime(dr["Print_Date"]);
            if (dr["Print_Company"] != DBNull.Value) print_Record.Print_Company = Convert.ToString(dr["Print_Company"]);
            if (dr["Print_Dept"] != DBNull.Value) print_Record.Print_Dept = Convert.ToString(dr["Print_Dept"]);
            if (dr["Print_Name"] != DBNull.Value) print_Record.Print_Name = Convert.ToString(dr["Print_Name"]);
            if (dr["Print_Count"] != DBNull.Value) print_Record.Print_Count = Convert.ToInt32(dr["Print_Count"]);
            if (dr["Print_Unit"] != DBNull.Value) print_Record.Print_Unit = Convert.ToString(dr["Print_Unit"]);
            if (dr["Print_Cost"] != DBNull.Value) print_Record.Print_Cost = Convert.ToDecimal(dr["Print_Cost"]);
            if (dr["Print_Remark"] != DBNull.Value) print_Record.Print_Remark = Convert.ToString(dr["Print_Remark"]);
            if (dr["Stat"] != DBNull.Value) print_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) print_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) print_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) print_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(print_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的印刷品明细表 Print_Record对象(即:一条记录
      /// </summary>
      public List<Print_Record> GetAll()
      {
         List<Print_Record> ret = new List<Print_Record>();
         string sql = "SELECT  Print_ID,Print_Code,Print_Date,Print_Company,Print_Dept,Print_Name,Print_Count,Print_Unit,Print_Cost,Print_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Print_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by Print_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Print_Record print_Record = new Print_Record();
            if (dr["Print_ID"] != DBNull.Value) print_Record.Print_ID = Convert.ToDecimal(dr["Print_ID"]);
            if (dr["Print_Code"] != DBNull.Value) print_Record.Print_Code = Convert.ToString(dr["Print_Code"]);
            if (dr["Print_Date"] != DBNull.Value) print_Record.Print_Date = Convert.ToDateTime(dr["Print_Date"]);
            if (dr["Print_Company"] != DBNull.Value) print_Record.Print_Company = Convert.ToString(dr["Print_Company"]);
            if (dr["Print_Dept"] != DBNull.Value) print_Record.Print_Dept = Convert.ToString(dr["Print_Dept"]);
            if (dr["Print_Name"] != DBNull.Value) print_Record.Print_Name = Convert.ToString(dr["Print_Name"]);
            if (dr["Print_Count"] != DBNull.Value) print_Record.Print_Count = Convert.ToInt32(dr["Print_Count"]);
            if (dr["Print_Unit"] != DBNull.Value) print_Record.Print_Unit = Convert.ToString(dr["Print_Unit"]);
            if (dr["Print_Cost"] != DBNull.Value) print_Record.Print_Cost = Convert.ToDecimal(dr["Print_Cost"]);
            if (dr["Print_Remark"] != DBNull.Value) print_Record.Print_Remark = Convert.ToString(dr["Print_Remark"]);
            if (dr["Stat"] != DBNull.Value) print_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) print_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) print_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) print_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(print_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
