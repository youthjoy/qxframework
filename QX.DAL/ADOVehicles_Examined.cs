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
   /// 后勤车辆年审记录
   /// </summary>
   [Serializable]
   public partial class ADOVehicles_Examined
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加后勤车辆年审记录 Vehicles_Examined对象(即:一条记录)
      /// </summary>
      public int Add(Vehicles_Examined vehicles_Examined)
      {
         string sql = "INSERT INTO Vehicles_Examined (VExamined_Code,VExamined_VehiclesNo,VExamined_VehiclesCode,VExamined_Cycle,VExamined_Date,VExamined_NextDate,VExamined_Company,VExamined_Dept,VExamined_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VExamined_itype) VALUES (@VExamined_Code,@VExamined_VehiclesNo,@VExamined_VehiclesCode,@VExamined_Cycle,@VExamined_Date,@VExamined_NextDate,@VExamined_Company,@VExamined_Dept,@VExamined_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VExamined_itype)";
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Code))
         {
            idb.AddParameter("@VExamined_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Code", vehicles_Examined.VExamined_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_VehiclesNo))
         {
            idb.AddParameter("@VExamined_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_VehiclesNo", vehicles_Examined.VExamined_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_VehiclesCode))
         {
            idb.AddParameter("@VExamined_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_VehiclesCode", vehicles_Examined.VExamined_VehiclesCode);
         }
         if (vehicles_Examined.VExamined_Cycle == 0)
         {
            idb.AddParameter("@VExamined_Cycle", 0);
         }
         else
         {
            idb.AddParameter("@VExamined_Cycle", vehicles_Examined.VExamined_Cycle);
         }
         if (vehicles_Examined.VExamined_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VExamined_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Date", vehicles_Examined.VExamined_Date);
         }
         if (vehicles_Examined.VExamined_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@VExamined_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_NextDate", vehicles_Examined.VExamined_NextDate);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Company))
         {
            idb.AddParameter("@VExamined_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Company", vehicles_Examined.VExamined_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Dept))
         {
            idb.AddParameter("@VExamined_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Dept", vehicles_Examined.VExamined_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Remark))
         {
            idb.AddParameter("@VExamined_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Remark", vehicles_Examined.VExamined_Remark);
         }
         if (vehicles_Examined.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Examined.Stat);
         }
         if (vehicles_Examined.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Examined.CreateDate);
         }
         if (vehicles_Examined.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Examined.UpdateDate);
         }
         if (vehicles_Examined.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Examined.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_itype))
         {
            idb.AddParameter("@VExamined_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_itype", vehicles_Examined.VExamined_itype);
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
      /// 添加后勤车辆年审记录 Vehicles_Examined对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Vehicles_Examined vehicles_Examined)
      {
         string sql = "INSERT INTO Vehicles_Examined (VExamined_Code,VExamined_VehiclesNo,VExamined_VehiclesCode,VExamined_Cycle,VExamined_Date,VExamined_NextDate,VExamined_Company,VExamined_Dept,VExamined_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VExamined_itype) VALUES (@VExamined_Code,@VExamined_VehiclesNo,@VExamined_VehiclesCode,@VExamined_Cycle,@VExamined_Date,@VExamined_NextDate,@VExamined_Company,@VExamined_Dept,@VExamined_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VExamined_itype);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Code))
         {
            idb.AddParameter("@VExamined_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Code", vehicles_Examined.VExamined_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_VehiclesNo))
         {
            idb.AddParameter("@VExamined_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_VehiclesNo", vehicles_Examined.VExamined_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_VehiclesCode))
         {
            idb.AddParameter("@VExamined_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_VehiclesCode", vehicles_Examined.VExamined_VehiclesCode);
         }
         if (vehicles_Examined.VExamined_Cycle == 0)
         {
            idb.AddParameter("@VExamined_Cycle", 0);
         }
         else
         {
            idb.AddParameter("@VExamined_Cycle", vehicles_Examined.VExamined_Cycle);
         }
         if (vehicles_Examined.VExamined_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VExamined_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Date", vehicles_Examined.VExamined_Date);
         }
         if (vehicles_Examined.VExamined_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@VExamined_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_NextDate", vehicles_Examined.VExamined_NextDate);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Company))
         {
            idb.AddParameter("@VExamined_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Company", vehicles_Examined.VExamined_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Dept))
         {
            idb.AddParameter("@VExamined_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Dept", vehicles_Examined.VExamined_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Remark))
         {
            idb.AddParameter("@VExamined_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Remark", vehicles_Examined.VExamined_Remark);
         }
         if (vehicles_Examined.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Examined.Stat);
         }
         if (vehicles_Examined.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Examined.CreateDate);
         }
         if (vehicles_Examined.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Examined.UpdateDate);
         }
         if (vehicles_Examined.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Examined.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_itype))
         {
            idb.AddParameter("@VExamined_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_itype", vehicles_Examined.VExamined_itype);
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
      /// 更新后勤车辆年审记录 Vehicles_Examined对象(即:一条记录
      /// </summary>
      public int Update(Vehicles_Examined vehicles_Examined)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Vehicles_Examined       SET ");
            if(vehicles_Examined.VExamined_Code_IsChanged){sbParameter.Append("VExamined_Code=@VExamined_Code, ");}
      if(vehicles_Examined.VExamined_VehiclesNo_IsChanged){sbParameter.Append("VExamined_VehiclesNo=@VExamined_VehiclesNo, ");}
      if(vehicles_Examined.VExamined_VehiclesCode_IsChanged){sbParameter.Append("VExamined_VehiclesCode=@VExamined_VehiclesCode, ");}
      if(vehicles_Examined.VExamined_Cycle_IsChanged){sbParameter.Append("VExamined_Cycle=@VExamined_Cycle, ");}
      if(vehicles_Examined.VExamined_Date_IsChanged){sbParameter.Append("VExamined_Date=@VExamined_Date, ");}
      if(vehicles_Examined.VExamined_NextDate_IsChanged){sbParameter.Append("VExamined_NextDate=@VExamined_NextDate, ");}
      if(vehicles_Examined.VExamined_Company_IsChanged){sbParameter.Append("VExamined_Company=@VExamined_Company, ");}
      if(vehicles_Examined.VExamined_Dept_IsChanged){sbParameter.Append("VExamined_Dept=@VExamined_Dept, ");}
      if(vehicles_Examined.VExamined_Remark_IsChanged){sbParameter.Append("VExamined_Remark=@VExamined_Remark, ");}
      if(vehicles_Examined.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(vehicles_Examined.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(vehicles_Examined.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(vehicles_Examined.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(vehicles_Examined.VExamined_itype_IsChanged){sbParameter.Append("VExamined_itype=@VExamined_itype ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and VExamined_ID=@VExamined_ID; " );
      string sql=sb.ToString();
         if(vehicles_Examined.VExamined_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Code))
         {
            idb.AddParameter("@VExamined_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Code", vehicles_Examined.VExamined_Code);
         }
          }
         if(vehicles_Examined.VExamined_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_VehiclesNo))
         {
            idb.AddParameter("@VExamined_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_VehiclesNo", vehicles_Examined.VExamined_VehiclesNo);
         }
          }
         if(vehicles_Examined.VExamined_VehiclesCode_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_VehiclesCode))
         {
            idb.AddParameter("@VExamined_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_VehiclesCode", vehicles_Examined.VExamined_VehiclesCode);
         }
          }
         if(vehicles_Examined.VExamined_Cycle_IsChanged)
         {
         if (vehicles_Examined.VExamined_Cycle == 0)
         {
            idb.AddParameter("@VExamined_Cycle", 0);
         }
         else
         {
            idb.AddParameter("@VExamined_Cycle", vehicles_Examined.VExamined_Cycle);
         }
          }
         if(vehicles_Examined.VExamined_Date_IsChanged)
         {
         if (vehicles_Examined.VExamined_Date == DateTime.MinValue)
         {
            idb.AddParameter("@VExamined_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Date", vehicles_Examined.VExamined_Date);
         }
          }
         if(vehicles_Examined.VExamined_NextDate_IsChanged)
         {
         if (vehicles_Examined.VExamined_NextDate == DateTime.MinValue)
         {
            idb.AddParameter("@VExamined_NextDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_NextDate", vehicles_Examined.VExamined_NextDate);
         }
          }
         if(vehicles_Examined.VExamined_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Company))
         {
            idb.AddParameter("@VExamined_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Company", vehicles_Examined.VExamined_Company);
         }
          }
         if(vehicles_Examined.VExamined_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Dept))
         {
            idb.AddParameter("@VExamined_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Dept", vehicles_Examined.VExamined_Dept);
         }
          }
         if(vehicles_Examined.VExamined_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_Remark))
         {
            idb.AddParameter("@VExamined_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_Remark", vehicles_Examined.VExamined_Remark);
         }
          }
         if(vehicles_Examined.Stat_IsChanged)
         {
         if (vehicles_Examined.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Examined.Stat);
         }
          }
         if(vehicles_Examined.CreateDate_IsChanged)
         {
         if (vehicles_Examined.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Examined.CreateDate);
         }
          }
         if(vehicles_Examined.UpdateDate_IsChanged)
         {
         if (vehicles_Examined.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Examined.UpdateDate);
         }
          }
         if(vehicles_Examined.DeleteDate_IsChanged)
         {
         if (vehicles_Examined.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Examined.DeleteDate);
         }
          }
         if(vehicles_Examined.VExamined_itype_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Examined.VExamined_itype))
         {
            idb.AddParameter("@VExamined_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VExamined_itype", vehicles_Examined.VExamined_itype);
         }
          }

         idb.AddParameter("@VExamined_ID", vehicles_Examined.VExamined_ID);

           
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
      /// 删除后勤车辆年审记录 Vehicles_Examined对象(即:一条记录
      /// </summary>
      public int Delete(decimal vExamined_ID)
      {
         string sql = "DELETE Vehicles_Examined WHERE 1=1  AND VExamined_ID=@VExamined_ID ";
         idb.AddParameter("@VExamined_ID", vExamined_ID);

           
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
      /// 获取指定的后勤车辆年审记录 Vehicles_Examined对象(即:一条记录
      /// </summary>
      public Vehicles_Examined GetByKey(decimal vExamined_ID)
      {
         Vehicles_Examined vehicles_Examined = new Vehicles_Examined();
         string sql = "SELECT  VExamined_ID,VExamined_Code,VExamined_VehiclesNo,VExamined_VehiclesCode,VExamined_Cycle,VExamined_Date,VExamined_NextDate,VExamined_Company,VExamined_Dept,VExamined_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VExamined_itype FROM Vehicles_Examined WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND VExamined_ID=@VExamined_ID ";
         idb.AddParameter("@VExamined_ID", vExamined_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["VExamined_ID"] != DBNull.Value) vehicles_Examined.VExamined_ID = Convert.ToDecimal(dr["VExamined_ID"]);
            if (dr["VExamined_Code"] != DBNull.Value) vehicles_Examined.VExamined_Code = Convert.ToString(dr["VExamined_Code"]);
            if (dr["VExamined_VehiclesNo"] != DBNull.Value) vehicles_Examined.VExamined_VehiclesNo = Convert.ToString(dr["VExamined_VehiclesNo"]);
            if (dr["VExamined_VehiclesCode"] != DBNull.Value) vehicles_Examined.VExamined_VehiclesCode = Convert.ToString(dr["VExamined_VehiclesCode"]);
            if (dr["VExamined_Cycle"] != DBNull.Value) vehicles_Examined.VExamined_Cycle = Convert.ToInt64(dr["VExamined_Cycle"]);
            if (dr["VExamined_Date"] != DBNull.Value) vehicles_Examined.VExamined_Date = Convert.ToDateTime(dr["VExamined_Date"]);
            if (dr["VExamined_NextDate"] != DBNull.Value) vehicles_Examined.VExamined_NextDate = Convert.ToDateTime(dr["VExamined_NextDate"]);
            if (dr["VExamined_Company"] != DBNull.Value) vehicles_Examined.VExamined_Company = Convert.ToString(dr["VExamined_Company"]);
            if (dr["VExamined_Dept"] != DBNull.Value) vehicles_Examined.VExamined_Dept = Convert.ToString(dr["VExamined_Dept"]);
            if (dr["VExamined_Remark"] != DBNull.Value) vehicles_Examined.VExamined_Remark = Convert.ToString(dr["VExamined_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Examined.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Examined.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Examined.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Examined.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VExamined_itype"] != DBNull.Value) vehicles_Examined.VExamined_itype = Convert.ToString(dr["VExamined_itype"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return vehicles_Examined;
      }
      /// <summary>
      /// 获取指定的后勤车辆年审记录 Vehicles_Examined对象集合
      /// </summary>
      public List<Vehicles_Examined> GetListByWhere(string strCondition)
      {
         List<Vehicles_Examined> ret = new List<Vehicles_Examined>();
         string sql = "SELECT  VExamined_ID,VExamined_Code,VExamined_VehiclesNo,VExamined_VehiclesCode,VExamined_Cycle,VExamined_Date,VExamined_NextDate,VExamined_Company,VExamined_Dept,VExamined_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VExamined_itype FROM Vehicles_Examined WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Vehicles_Examined vehicles_Examined = new Vehicles_Examined();
            if (dr["VExamined_ID"] != DBNull.Value) vehicles_Examined.VExamined_ID = Convert.ToDecimal(dr["VExamined_ID"]);
            if (dr["VExamined_Code"] != DBNull.Value) vehicles_Examined.VExamined_Code = Convert.ToString(dr["VExamined_Code"]);
            if (dr["VExamined_VehiclesNo"] != DBNull.Value) vehicles_Examined.VExamined_VehiclesNo = Convert.ToString(dr["VExamined_VehiclesNo"]);
            if (dr["VExamined_VehiclesCode"] != DBNull.Value) vehicles_Examined.VExamined_VehiclesCode = Convert.ToString(dr["VExamined_VehiclesCode"]);
            if (dr["VExamined_Cycle"] != DBNull.Value) vehicles_Examined.VExamined_Cycle = Convert.ToInt64(dr["VExamined_Cycle"]);
            if (dr["VExamined_Date"] != DBNull.Value) vehicles_Examined.VExamined_Date = Convert.ToDateTime(dr["VExamined_Date"]);
            if (dr["VExamined_NextDate"] != DBNull.Value) vehicles_Examined.VExamined_NextDate = Convert.ToDateTime(dr["VExamined_NextDate"]);
            if (dr["VExamined_Company"] != DBNull.Value) vehicles_Examined.VExamined_Company = Convert.ToString(dr["VExamined_Company"]);
            if (dr["VExamined_Dept"] != DBNull.Value) vehicles_Examined.VExamined_Dept = Convert.ToString(dr["VExamined_Dept"]);
            if (dr["VExamined_Remark"] != DBNull.Value) vehicles_Examined.VExamined_Remark = Convert.ToString(dr["VExamined_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Examined.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Examined.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Examined.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Examined.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VExamined_itype"] != DBNull.Value) vehicles_Examined.VExamined_itype = Convert.ToString(dr["VExamined_itype"]);
            ret.Add(vehicles_Examined);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的后勤车辆年审记录 Vehicles_Examined对象(即:一条记录
      /// </summary>
      public List<Vehicles_Examined> GetAll()
      {
         List<Vehicles_Examined> ret = new List<Vehicles_Examined>();
         string sql = "SELECT  VExamined_ID,VExamined_Code,VExamined_VehiclesNo,VExamined_VehiclesCode,VExamined_Cycle,VExamined_Date,VExamined_NextDate,VExamined_Company,VExamined_Dept,VExamined_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VExamined_itype FROM Vehicles_Examined where 1=1 AND ((Stat is null) or (Stat=0) ) order by VExamined_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Vehicles_Examined vehicles_Examined = new Vehicles_Examined();
            if (dr["VExamined_ID"] != DBNull.Value) vehicles_Examined.VExamined_ID = Convert.ToDecimal(dr["VExamined_ID"]);
            if (dr["VExamined_Code"] != DBNull.Value) vehicles_Examined.VExamined_Code = Convert.ToString(dr["VExamined_Code"]);
            if (dr["VExamined_VehiclesNo"] != DBNull.Value) vehicles_Examined.VExamined_VehiclesNo = Convert.ToString(dr["VExamined_VehiclesNo"]);
            if (dr["VExamined_VehiclesCode"] != DBNull.Value) vehicles_Examined.VExamined_VehiclesCode = Convert.ToString(dr["VExamined_VehiclesCode"]);
            if (dr["VExamined_Cycle"] != DBNull.Value) vehicles_Examined.VExamined_Cycle = Convert.ToInt64(dr["VExamined_Cycle"]);
            if (dr["VExamined_Date"] != DBNull.Value) vehicles_Examined.VExamined_Date = Convert.ToDateTime(dr["VExamined_Date"]);
            if (dr["VExamined_NextDate"] != DBNull.Value) vehicles_Examined.VExamined_NextDate = Convert.ToDateTime(dr["VExamined_NextDate"]);
            if (dr["VExamined_Company"] != DBNull.Value) vehicles_Examined.VExamined_Company = Convert.ToString(dr["VExamined_Company"]);
            if (dr["VExamined_Dept"] != DBNull.Value) vehicles_Examined.VExamined_Dept = Convert.ToString(dr["VExamined_Dept"]);
            if (dr["VExamined_Remark"] != DBNull.Value) vehicles_Examined.VExamined_Remark = Convert.ToString(dr["VExamined_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Examined.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Examined.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Examined.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Examined.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VExamined_itype"] != DBNull.Value) vehicles_Examined.VExamined_itype = Convert.ToString(dr["VExamined_itype"]);
            ret.Add(vehicles_Examined);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
