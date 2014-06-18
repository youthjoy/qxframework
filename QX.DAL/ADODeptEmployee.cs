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
   /// 部门人员关系表
   /// </summary>
   [Serializable]
   public partial class ADODeptEmployee
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加部门人员关系表 DeptEmployee对象(即:一条记录)
      /// </summary>
      public int Add(DeptEmployee deptEmployee)
      {
         string sql = "INSERT INTO DeptEmployee (DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat) VALUES (@DE_Dept_Code,@DE_Empoyee_Code,@DE_Type,@Stat)";
         if (string.IsNullOrEmpty(deptEmployee.DE_Dept_Code))
         {
            idb.AddParameter("@DE_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Dept_Code", deptEmployee.DE_Dept_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee.DE_Empoyee_Code))
         {
            idb.AddParameter("@DE_Empoyee_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Empoyee_Code", deptEmployee.DE_Empoyee_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee.DE_Type))
         {
            idb.AddParameter("@DE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Type", deptEmployee.DE_Type);
         }
         if (deptEmployee.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", deptEmployee.Stat);
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
      /// 添加部门人员关系表 DeptEmployee对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(DeptEmployee deptEmployee)
      {
         string sql = "INSERT INTO DeptEmployee (DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat) VALUES (@DE_Dept_Code,@DE_Empoyee_Code,@DE_Type,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(deptEmployee.DE_Dept_Code))
         {
            idb.AddParameter("@DE_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Dept_Code", deptEmployee.DE_Dept_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee.DE_Empoyee_Code))
         {
            idb.AddParameter("@DE_Empoyee_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Empoyee_Code", deptEmployee.DE_Empoyee_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee.DE_Type))
         {
            idb.AddParameter("@DE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Type", deptEmployee.DE_Type);
         }
         if (deptEmployee.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", deptEmployee.Stat);
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
      /// 更新部门人员关系表 DeptEmployee对象(即:一条记录
      /// </summary>
      public int Update(DeptEmployee deptEmployee)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       DeptEmployee       SET ");
            if(deptEmployee.DE_Dept_Code_IsChanged){sbParameter.Append("DE_Dept_Code=@DE_Dept_Code, ");}
      if(deptEmployee.DE_Empoyee_Code_IsChanged){sbParameter.Append("DE_Empoyee_Code=@DE_Empoyee_Code, ");}
      if(deptEmployee.DE_Type_IsChanged){sbParameter.Append("DE_Type=@DE_Type, ");}
      if(deptEmployee.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DE_ID=@DE_ID; " );
      string sql=sb.ToString();
         if(deptEmployee.DE_Dept_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(deptEmployee.DE_Dept_Code))
         {
            idb.AddParameter("@DE_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Dept_Code", deptEmployee.DE_Dept_Code);
         }
          }
         if(deptEmployee.DE_Empoyee_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(deptEmployee.DE_Empoyee_Code))
         {
            idb.AddParameter("@DE_Empoyee_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Empoyee_Code", deptEmployee.DE_Empoyee_Code);
         }
          }
         if(deptEmployee.DE_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(deptEmployee.DE_Type))
         {
            idb.AddParameter("@DE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Type", deptEmployee.DE_Type);
         }
          }
         if(deptEmployee.Stat_IsChanged)
         {
         if (deptEmployee.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", deptEmployee.Stat);
         }
          }

         idb.AddParameter("@DE_ID", deptEmployee.DE_ID);

           
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
      /// 删除部门人员关系表 DeptEmployee对象(即:一条记录
      /// </summary>
      public int Delete(decimal dE_ID)
      {
         string sql = "DELETE DeptEmployee WHERE 1=1  AND DE_ID=@DE_ID ";
         idb.AddParameter("@DE_ID", dE_ID);

           
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
      /// 获取指定的部门人员关系表 DeptEmployee对象(即:一条记录
      /// </summary>
      public DeptEmployee GetByKey(decimal dE_ID)
      {
         DeptEmployee deptEmployee = new DeptEmployee();
         string sql = "SELECT  DE_ID,DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat FROM DeptEmployee WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DE_ID=@DE_ID ";
         idb.AddParameter("@DE_ID", dE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DE_ID"] != DBNull.Value) deptEmployee.DE_ID = Convert.ToDecimal(dr["DE_ID"]);
            if (dr["DE_Dept_Code"] != DBNull.Value) deptEmployee.DE_Dept_Code = Convert.ToString(dr["DE_Dept_Code"]);
            if (dr["DE_Empoyee_Code"] != DBNull.Value) deptEmployee.DE_Empoyee_Code = Convert.ToString(dr["DE_Empoyee_Code"]);
            if (dr["DE_Type"] != DBNull.Value) deptEmployee.DE_Type = Convert.ToString(dr["DE_Type"]);
            if (dr["Stat"] != DBNull.Value) deptEmployee.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return deptEmployee;
      }
      /// <summary>
      /// 获取指定的部门人员关系表 DeptEmployee对象集合
      /// </summary>
      public List<DeptEmployee> GetListByWhere(string strCondition)
      {
         List<DeptEmployee> ret = new List<DeptEmployee>();
         string sql = "SELECT  DE_ID,DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat FROM DeptEmployee WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            DeptEmployee deptEmployee = new DeptEmployee();
            if (dr["DE_ID"] != DBNull.Value) deptEmployee.DE_ID = Convert.ToDecimal(dr["DE_ID"]);
            if (dr["DE_Dept_Code"] != DBNull.Value) deptEmployee.DE_Dept_Code = Convert.ToString(dr["DE_Dept_Code"]);
            if (dr["DE_Empoyee_Code"] != DBNull.Value) deptEmployee.DE_Empoyee_Code = Convert.ToString(dr["DE_Empoyee_Code"]);
            if (dr["DE_Type"] != DBNull.Value) deptEmployee.DE_Type = Convert.ToString(dr["DE_Type"]);
            if (dr["Stat"] != DBNull.Value) deptEmployee.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(deptEmployee);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的部门人员关系表 DeptEmployee对象(即:一条记录
      /// </summary>
      public List<DeptEmployee> GetAll()
      {
         List<DeptEmployee> ret = new List<DeptEmployee>();
         string sql = "SELECT  DE_ID,DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat FROM DeptEmployee where 1=1 AND ((Stat is null) or (Stat=0) ) order by DE_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            DeptEmployee deptEmployee = new DeptEmployee();
            if (dr["DE_ID"] != DBNull.Value) deptEmployee.DE_ID = Convert.ToDecimal(dr["DE_ID"]);
            if (dr["DE_Dept_Code"] != DBNull.Value) deptEmployee.DE_Dept_Code = Convert.ToString(dr["DE_Dept_Code"]);
            if (dr["DE_Empoyee_Code"] != DBNull.Value) deptEmployee.DE_Empoyee_Code = Convert.ToString(dr["DE_Empoyee_Code"]);
            if (dr["DE_Type"] != DBNull.Value) deptEmployee.DE_Type = Convert.ToString(dr["DE_Type"]);
            if (dr["Stat"] != DBNull.Value) deptEmployee.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(deptEmployee);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
