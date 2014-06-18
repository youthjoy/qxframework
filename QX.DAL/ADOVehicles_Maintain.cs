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
   public partial class ADOVehicles_Maintain
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Vehicles_Maintain对象(即:一条记录)
      /// </summary>
      public int Add(Vehicles_Maintain vehicles_Maintain)
      {
         string sql = "INSERT INTO Vehicles_Maintain (VM_Code,VM_VehiclesCode,VM_VehiclesNo,VM_Standard,VM_LastDate,VM_NextDate,VM_NextMileage,VM_Company,VM_Dept,VM_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@VM_Code,@VM_VehiclesCode,@VM_VehiclesNo,@VM_Standard,@VM_LastDate,@VM_NextDate,@VM_NextMileage,@VM_Company,@VM_Dept,@VM_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Code))
         {
            idb.AddParameter("@VM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Code", vehicles_Maintain.VM_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_VehiclesCode))
         {
            idb.AddParameter("@VM_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_VehiclesCode", vehicles_Maintain.VM_VehiclesCode);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_VehiclesNo))
         {
            idb.AddParameter("@VM_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_VehiclesNo", vehicles_Maintain.VM_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Standard))
         {
            idb.AddParameter("@VM_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Standard", vehicles_Maintain.VM_Standard);
         }
         if (vehicles_Maintain.VM_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@VM_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_LastDate", vehicles_Maintain.VM_LastDate);
         }
         if (vehicles_Maintain.VM_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@VM_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_NextDate", vehicles_Maintain.VM_NextDate);
         }
         if (vehicles_Maintain.VM_NextMileage == 0)
         {
            idb.AddParameter("@VM_NextMileage", 0);
         }
         else
         {
            idb.AddParameter("@VM_NextMileage", vehicles_Maintain.VM_NextMileage);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Company))
         {
            idb.AddParameter("@VM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Company", vehicles_Maintain.VM_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Dept))
         {
            idb.AddParameter("@VM_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Dept", vehicles_Maintain.VM_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Remark))
         {
            idb.AddParameter("@VM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Remark", vehicles_Maintain.VM_Remark);
         }
         if (vehicles_Maintain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Maintain.Stat);
         }
         if (vehicles_Maintain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Maintain.CreateDate);
         }
         if (vehicles_Maintain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Maintain.UpdateDate);
         }
         if (vehicles_Maintain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Maintain.DeleteDate);
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
      /// 添加Vehicles_Maintain对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Vehicles_Maintain vehicles_Maintain)
      {
         string sql = "INSERT INTO Vehicles_Maintain (VM_Code,VM_VehiclesCode,VM_VehiclesNo,VM_Standard,VM_LastDate,VM_NextDate,VM_NextMileage,VM_Company,VM_Dept,VM_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@VM_Code,@VM_VehiclesCode,@VM_VehiclesNo,@VM_Standard,@VM_LastDate,@VM_NextDate,@VM_NextMileage,@VM_Company,@VM_Dept,@VM_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Code))
         {
            idb.AddParameter("@VM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Code", vehicles_Maintain.VM_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_VehiclesCode))
         {
            idb.AddParameter("@VM_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_VehiclesCode", vehicles_Maintain.VM_VehiclesCode);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_VehiclesNo))
         {
            idb.AddParameter("@VM_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_VehiclesNo", vehicles_Maintain.VM_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Standard))
         {
            idb.AddParameter("@VM_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Standard", vehicles_Maintain.VM_Standard);
         }
         if (vehicles_Maintain.VM_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@VM_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_LastDate", vehicles_Maintain.VM_LastDate);
         }
         if (vehicles_Maintain.VM_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@VM_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_NextDate", vehicles_Maintain.VM_NextDate);
         }
         if (vehicles_Maintain.VM_NextMileage == 0)
         {
            idb.AddParameter("@VM_NextMileage", 0);
         }
         else
         {
            idb.AddParameter("@VM_NextMileage", vehicles_Maintain.VM_NextMileage);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Company))
         {
            idb.AddParameter("@VM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Company", vehicles_Maintain.VM_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Dept))
         {
            idb.AddParameter("@VM_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Dept", vehicles_Maintain.VM_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Remark))
         {
            idb.AddParameter("@VM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Remark", vehicles_Maintain.VM_Remark);
         }
         if (vehicles_Maintain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Maintain.Stat);
         }
         if (vehicles_Maintain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Maintain.CreateDate);
         }
         if (vehicles_Maintain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Maintain.UpdateDate);
         }
         if (vehicles_Maintain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Maintain.DeleteDate);
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
      /// 更新Vehicles_Maintain对象(即:一条记录
      /// </summary>
      public int Update(Vehicles_Maintain vehicles_Maintain)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Vehicles_Maintain       SET ");
            if(vehicles_Maintain.VM_Code_IsChanged){sbParameter.Append("VM_Code=@VM_Code, ");}
      if(vehicles_Maintain.VM_VehiclesCode_IsChanged){sbParameter.Append("VM_VehiclesCode=@VM_VehiclesCode, ");}
      if(vehicles_Maintain.VM_VehiclesNo_IsChanged){sbParameter.Append("VM_VehiclesNo=@VM_VehiclesNo, ");}
      if(vehicles_Maintain.VM_Standard_IsChanged){sbParameter.Append("VM_Standard=@VM_Standard, ");}
      if(vehicles_Maintain.VM_LastDate_IsChanged){sbParameter.Append("VM_LastDate=@VM_LastDate, ");}
      if(vehicles_Maintain.VM_NextDate_IsChanged){sbParameter.Append("VM_NextDate=@VM_NextDate, ");}
      if(vehicles_Maintain.VM_NextMileage_IsChanged){sbParameter.Append("VM_NextMileage=@VM_NextMileage, ");}
      if(vehicles_Maintain.VM_Company_IsChanged){sbParameter.Append("VM_Company=@VM_Company, ");}
      if(vehicles_Maintain.VM_Dept_IsChanged){sbParameter.Append("VM_Dept=@VM_Dept, ");}
      if(vehicles_Maintain.VM_Remark_IsChanged){sbParameter.Append("VM_Remark=@VM_Remark, ");}
      if(vehicles_Maintain.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(vehicles_Maintain.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(vehicles_Maintain.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(vehicles_Maintain.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and VM_ID=@VM_ID; " );
      string sql=sb.ToString();
         if(vehicles_Maintain.VM_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Code))
         {
            idb.AddParameter("@VM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Code", vehicles_Maintain.VM_Code);
         }
          }
         if(vehicles_Maintain.VM_VehiclesCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_VehiclesCode))
         {
            idb.AddParameter("@VM_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_VehiclesCode", vehicles_Maintain.VM_VehiclesCode);
         }
          }
         if(vehicles_Maintain.VM_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_VehiclesNo))
         {
            idb.AddParameter("@VM_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_VehiclesNo", vehicles_Maintain.VM_VehiclesNo);
         }
          }
         if(vehicles_Maintain.VM_Standard_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Standard))
         {
            idb.AddParameter("@VM_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Standard", vehicles_Maintain.VM_Standard);
         }
          }
         if(vehicles_Maintain.VM_LastDate_IsChanged)
         {
         if (vehicles_Maintain.VM_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@VM_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_LastDate", vehicles_Maintain.VM_LastDate);
         }
          }
         if(vehicles_Maintain.VM_NextDate_IsChanged)
         {
         if (vehicles_Maintain.VM_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@VM_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_NextDate", vehicles_Maintain.VM_NextDate);
         }
          }
         if(vehicles_Maintain.VM_NextMileage_IsChanged)
         {
         if (vehicles_Maintain.VM_NextMileage == 0)
         {
            idb.AddParameter("@VM_NextMileage", 0);
         }
         else
         {
            idb.AddParameter("@VM_NextMileage", vehicles_Maintain.VM_NextMileage);
         }
          }
         if(vehicles_Maintain.VM_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Company))
         {
            idb.AddParameter("@VM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Company", vehicles_Maintain.VM_Company);
         }
          }
         if(vehicles_Maintain.VM_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Dept))
         {
            idb.AddParameter("@VM_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Dept", vehicles_Maintain.VM_Dept);
         }
          }
         if(vehicles_Maintain.VM_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Maintain.VM_Remark))
         {
            idb.AddParameter("@VM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VM_Remark", vehicles_Maintain.VM_Remark);
         }
          }
         if(vehicles_Maintain.Stat_IsChanged)
         {
         if (vehicles_Maintain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Maintain.Stat);
         }
          }
         if(vehicles_Maintain.CreateDate_IsChanged)
         {
         if (vehicles_Maintain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Maintain.CreateDate);
         }
          }
         if(vehicles_Maintain.UpdateDate_IsChanged)
         {
         if (vehicles_Maintain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Maintain.UpdateDate);
         }
          }
         if(vehicles_Maintain.DeleteDate_IsChanged)
         {
         if (vehicles_Maintain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Maintain.DeleteDate);
         }
          }

         idb.AddParameter("@VM_ID", vehicles_Maintain.VM_ID);

           
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
      /// 删除Vehicles_Maintain对象(即:一条记录
      /// </summary>
      public int Delete(decimal vM_ID)
      {
         string sql = "DELETE Vehicles_Maintain WHERE 1=1  AND VM_ID=@VM_ID ";
         idb.AddParameter("@VM_ID", vM_ID);

           
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
      /// 获取指定的Vehicles_Maintain对象(即:一条记录
      /// </summary>
      public Vehicles_Maintain GetByKey(decimal vM_ID)
      {
         Vehicles_Maintain vehicles_Maintain = new Vehicles_Maintain();
         string sql = "SELECT  VM_ID,VM_Code,VM_VehiclesCode,VM_VehiclesNo,VM_Standard,VM_LastDate,VM_NextDate,VM_NextMileage,VM_Company,VM_Dept,VM_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Vehicles_Maintain WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND VM_ID=@VM_ID ";
         idb.AddParameter("@VM_ID", vM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["VM_ID"] != DBNull.Value) vehicles_Maintain.VM_ID = Convert.ToDecimal(dr["VM_ID"]);
            if (dr["VM_Code"] != DBNull.Value) vehicles_Maintain.VM_Code = Convert.ToString(dr["VM_Code"]);
            if (dr["VM_VehiclesCode"] != DBNull.Value) vehicles_Maintain.VM_VehiclesCode = Convert.ToString(dr["VM_VehiclesCode"]);
            if (dr["VM_VehiclesNo"] != DBNull.Value) vehicles_Maintain.VM_VehiclesNo = Convert.ToString(dr["VM_VehiclesNo"]);
            if (dr["VM_Standard"] != DBNull.Value) vehicles_Maintain.VM_Standard = Convert.ToString(dr["VM_Standard"]);
            if (dr["VM_LastDate"] != DBNull.Value) vehicles_Maintain.VM_LastDate = Convert.ToDateTime(dr["VM_LastDate"]);
            if (dr["VM_NextDate"] != DBNull.Value) vehicles_Maintain.VM_NextDate = Convert.ToDateTime(dr["VM_NextDate"]);
            if (dr["VM_NextMileage"] != DBNull.Value) vehicles_Maintain.VM_NextMileage = Convert.ToSingle(dr["VM_NextMileage"]);
            if (dr["VM_Company"] != DBNull.Value) vehicles_Maintain.VM_Company = Convert.ToString(dr["VM_Company"]);
            if (dr["VM_Dept"] != DBNull.Value) vehicles_Maintain.VM_Dept = Convert.ToString(dr["VM_Dept"]);
            if (dr["VM_Remark"] != DBNull.Value) vehicles_Maintain.VM_Remark = Convert.ToString(dr["VM_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Maintain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Maintain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Maintain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Maintain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return vehicles_Maintain;
      }
      /// <summary>
      /// 获取指定的Vehicles_Maintain对象集合
      /// </summary>
      public List<Vehicles_Maintain> GetListByWhere(string strCondition)
      {
         List<Vehicles_Maintain> ret = new List<Vehicles_Maintain>();
         string sql = "SELECT  VM_ID,VM_Code,VM_VehiclesCode,VM_VehiclesNo,VM_Standard,VM_LastDate,VM_NextDate,VM_NextMileage,VM_Company,VM_Dept,VM_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Vehicles_Maintain WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Vehicles_Maintain vehicles_Maintain = new Vehicles_Maintain();
            if (dr["VM_ID"] != DBNull.Value) vehicles_Maintain.VM_ID = Convert.ToDecimal(dr["VM_ID"]);
            if (dr["VM_Code"] != DBNull.Value) vehicles_Maintain.VM_Code = Convert.ToString(dr["VM_Code"]);
            if (dr["VM_VehiclesCode"] != DBNull.Value) vehicles_Maintain.VM_VehiclesCode = Convert.ToString(dr["VM_VehiclesCode"]);
            if (dr["VM_VehiclesNo"] != DBNull.Value) vehicles_Maintain.VM_VehiclesNo = Convert.ToString(dr["VM_VehiclesNo"]);
            if (dr["VM_Standard"] != DBNull.Value) vehicles_Maintain.VM_Standard = Convert.ToString(dr["VM_Standard"]);
            if (dr["VM_LastDate"] != DBNull.Value) vehicles_Maintain.VM_LastDate = Convert.ToDateTime(dr["VM_LastDate"]);
            if (dr["VM_NextDate"] != DBNull.Value) vehicles_Maintain.VM_NextDate = Convert.ToDateTime(dr["VM_NextDate"]);
            if (dr["VM_NextMileage"] != DBNull.Value) vehicles_Maintain.VM_NextMileage = Convert.ToSingle(dr["VM_NextMileage"]);
            if (dr["VM_Company"] != DBNull.Value) vehicles_Maintain.VM_Company = Convert.ToString(dr["VM_Company"]);
            if (dr["VM_Dept"] != DBNull.Value) vehicles_Maintain.VM_Dept = Convert.ToString(dr["VM_Dept"]);
            if (dr["VM_Remark"] != DBNull.Value) vehicles_Maintain.VM_Remark = Convert.ToString(dr["VM_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Maintain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Maintain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Maintain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Maintain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(vehicles_Maintain);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Vehicles_Maintain对象(即:一条记录
      /// </summary>
      public List<Vehicles_Maintain> GetAll()
      {
         List<Vehicles_Maintain> ret = new List<Vehicles_Maintain>();
         string sql = "SELECT  VM_ID,VM_Code,VM_VehiclesCode,VM_VehiclesNo,VM_Standard,VM_LastDate,VM_NextDate,VM_NextMileage,VM_Company,VM_Dept,VM_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Vehicles_Maintain where 1=1 AND ((Stat is null) or (Stat=0) ) order by VM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Vehicles_Maintain vehicles_Maintain = new Vehicles_Maintain();
            if (dr["VM_ID"] != DBNull.Value) vehicles_Maintain.VM_ID = Convert.ToDecimal(dr["VM_ID"]);
            if (dr["VM_Code"] != DBNull.Value) vehicles_Maintain.VM_Code = Convert.ToString(dr["VM_Code"]);
            if (dr["VM_VehiclesCode"] != DBNull.Value) vehicles_Maintain.VM_VehiclesCode = Convert.ToString(dr["VM_VehiclesCode"]);
            if (dr["VM_VehiclesNo"] != DBNull.Value) vehicles_Maintain.VM_VehiclesNo = Convert.ToString(dr["VM_VehiclesNo"]);
            if (dr["VM_Standard"] != DBNull.Value) vehicles_Maintain.VM_Standard = Convert.ToString(dr["VM_Standard"]);
            if (dr["VM_LastDate"] != DBNull.Value) vehicles_Maintain.VM_LastDate = Convert.ToDateTime(dr["VM_LastDate"]);
            if (dr["VM_NextDate"] != DBNull.Value) vehicles_Maintain.VM_NextDate = Convert.ToDateTime(dr["VM_NextDate"]);
            if (dr["VM_NextMileage"] != DBNull.Value) vehicles_Maintain.VM_NextMileage = Convert.ToSingle(dr["VM_NextMileage"]);
            if (dr["VM_Company"] != DBNull.Value) vehicles_Maintain.VM_Company = Convert.ToString(dr["VM_Company"]);
            if (dr["VM_Dept"] != DBNull.Value) vehicles_Maintain.VM_Dept = Convert.ToString(dr["VM_Dept"]);
            if (dr["VM_Remark"] != DBNull.Value) vehicles_Maintain.VM_Remark = Convert.ToString(dr["VM_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Maintain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Maintain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Maintain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Maintain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(vehicles_Maintain);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
