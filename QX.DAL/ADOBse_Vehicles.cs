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
   /// 后勤车辆基本信息
   /// </summary>
   [Serializable]
   public partial class ADOBse_Vehicles
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加后勤车辆基本信息 Bse_Vehicles对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Vehicles bse_Vehicles)
      {
         string sql = "INSERT INTO Bse_Vehicles (Vehicles_Code,Vehicles_No,Vehicles_Model,Vehicles_Color,Vehicles_Stable,Vehicles_Company,Vehicles_Dept,Vehicles_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Itype) VALUES (@Vehicles_Code,@Vehicles_No,@Vehicles_Model,@Vehicles_Color,@Vehicles_Stable,@Vehicles_Company,@Vehicles_Dept,@Vehicles_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Itype)";
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Code))
         {
            idb.AddParameter("@Vehicles_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Code", bse_Vehicles.Vehicles_Code);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_No))
         {
            idb.AddParameter("@Vehicles_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_No", bse_Vehicles.Vehicles_No);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Model))
         {
            idb.AddParameter("@Vehicles_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Model", bse_Vehicles.Vehicles_Model);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Color))
         {
            idb.AddParameter("@Vehicles_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Color", bse_Vehicles.Vehicles_Color);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Stable))
         {
            idb.AddParameter("@Vehicles_Stable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Stable", bse_Vehicles.Vehicles_Stable);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Company))
         {
            idb.AddParameter("@Vehicles_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Company", bse_Vehicles.Vehicles_Company);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Dept))
         {
            idb.AddParameter("@Vehicles_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Dept", bse_Vehicles.Vehicles_Dept);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Remark))
         {
            idb.AddParameter("@Vehicles_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Remark", bse_Vehicles.Vehicles_Remark);
         }
         if (bse_Vehicles.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Vehicles.Stat);
         }
         if (bse_Vehicles.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Vehicles.CreateDate);
         }
         if (bse_Vehicles.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Vehicles.UpdateDate);
         }
         if (bse_Vehicles.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Vehicles.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Itype))
         {
            idb.AddParameter("@Itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Itype", bse_Vehicles.Itype);
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
      /// 添加后勤车辆基本信息 Bse_Vehicles对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Vehicles bse_Vehicles)
      {
         string sql = "INSERT INTO Bse_Vehicles (Vehicles_Code,Vehicles_No,Vehicles_Model,Vehicles_Color,Vehicles_Stable,Vehicles_Company,Vehicles_Dept,Vehicles_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Itype) VALUES (@Vehicles_Code,@Vehicles_No,@Vehicles_Model,@Vehicles_Color,@Vehicles_Stable,@Vehicles_Company,@Vehicles_Dept,@Vehicles_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Itype);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Code))
         {
            idb.AddParameter("@Vehicles_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Code", bse_Vehicles.Vehicles_Code);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_No))
         {
            idb.AddParameter("@Vehicles_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_No", bse_Vehicles.Vehicles_No);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Model))
         {
            idb.AddParameter("@Vehicles_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Model", bse_Vehicles.Vehicles_Model);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Color))
         {
            idb.AddParameter("@Vehicles_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Color", bse_Vehicles.Vehicles_Color);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Stable))
         {
            idb.AddParameter("@Vehicles_Stable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Stable", bse_Vehicles.Vehicles_Stable);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Company))
         {
            idb.AddParameter("@Vehicles_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Company", bse_Vehicles.Vehicles_Company);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Dept))
         {
            idb.AddParameter("@Vehicles_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Dept", bse_Vehicles.Vehicles_Dept);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Remark))
         {
            idb.AddParameter("@Vehicles_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Remark", bse_Vehicles.Vehicles_Remark);
         }
         if (bse_Vehicles.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Vehicles.Stat);
         }
         if (bse_Vehicles.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Vehicles.CreateDate);
         }
         if (bse_Vehicles.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Vehicles.UpdateDate);
         }
         if (bse_Vehicles.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Vehicles.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_Vehicles.Itype))
         {
            idb.AddParameter("@Itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Itype", bse_Vehicles.Itype);
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
      /// 更新后勤车辆基本信息 Bse_Vehicles对象(即:一条记录
      /// </summary>
      public int Update(Bse_Vehicles bse_Vehicles)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Vehicles       SET ");
            if(bse_Vehicles.Vehicles_Code_IsChanged){sbParameter.Append("Vehicles_Code=@Vehicles_Code, ");}
      if(bse_Vehicles.Vehicles_No_IsChanged){sbParameter.Append("Vehicles_No=@Vehicles_No, ");}
      if(bse_Vehicles.Vehicles_Model_IsChanged){sbParameter.Append("Vehicles_Model=@Vehicles_Model, ");}
      if(bse_Vehicles.Vehicles_Color_IsChanged){sbParameter.Append("Vehicles_Color=@Vehicles_Color, ");}
      if(bse_Vehicles.Vehicles_Stable_IsChanged){sbParameter.Append("Vehicles_Stable=@Vehicles_Stable, ");}
      if(bse_Vehicles.Vehicles_Company_IsChanged){sbParameter.Append("Vehicles_Company=@Vehicles_Company, ");}
      if(bse_Vehicles.Vehicles_Dept_IsChanged){sbParameter.Append("Vehicles_Dept=@Vehicles_Dept, ");}
      if(bse_Vehicles.Vehicles_Remark_IsChanged){sbParameter.Append("Vehicles_Remark=@Vehicles_Remark, ");}
      if(bse_Vehicles.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Vehicles.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bse_Vehicles.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bse_Vehicles.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(bse_Vehicles.Itype_IsChanged){sbParameter.Append("Itype=@Itype ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Vehicles_ID=@Vehicles_ID; " );
      string sql=sb.ToString();
         if(bse_Vehicles.Vehicles_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Code))
         {
            idb.AddParameter("@Vehicles_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Code", bse_Vehicles.Vehicles_Code);
         }
          }
         if(bse_Vehicles.Vehicles_No_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_No))
         {
            idb.AddParameter("@Vehicles_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_No", bse_Vehicles.Vehicles_No);
         }
          }
         if(bse_Vehicles.Vehicles_Model_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Model))
         {
            idb.AddParameter("@Vehicles_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Model", bse_Vehicles.Vehicles_Model);
         }
          }
         if(bse_Vehicles.Vehicles_Color_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Color))
         {
            idb.AddParameter("@Vehicles_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Color", bse_Vehicles.Vehicles_Color);
         }
          }
         if(bse_Vehicles.Vehicles_Stable_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Stable))
         {
            idb.AddParameter("@Vehicles_Stable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Stable", bse_Vehicles.Vehicles_Stable);
         }
          }
         if(bse_Vehicles.Vehicles_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Company))
         {
            idb.AddParameter("@Vehicles_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Company", bse_Vehicles.Vehicles_Company);
         }
          }
         if(bse_Vehicles.Vehicles_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Dept))
         {
            idb.AddParameter("@Vehicles_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Dept", bse_Vehicles.Vehicles_Dept);
         }
          }
         if(bse_Vehicles.Vehicles_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Vehicles_Remark))
         {
            idb.AddParameter("@Vehicles_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Vehicles_Remark", bse_Vehicles.Vehicles_Remark);
         }
          }
         if(bse_Vehicles.Stat_IsChanged)
         {
         if (bse_Vehicles.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Vehicles.Stat);
         }
          }
         if(bse_Vehicles.CreateDate_IsChanged)
         {
         if (bse_Vehicles.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Vehicles.CreateDate);
         }
          }
         if(bse_Vehicles.UpdateDate_IsChanged)
         {
         if (bse_Vehicles.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Vehicles.UpdateDate);
         }
          }
         if(bse_Vehicles.DeleteDate_IsChanged)
         {
         if (bse_Vehicles.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Vehicles.DeleteDate);
         }
          }
         if(bse_Vehicles.Itype_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Vehicles.Itype))
         {
            idb.AddParameter("@Itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Itype", bse_Vehicles.Itype);
         }
          }

         idb.AddParameter("@Vehicles_ID", bse_Vehicles.Vehicles_ID);

           
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
      /// 删除后勤车辆基本信息 Bse_Vehicles对象(即:一条记录
      /// </summary>
      public int Delete(decimal vehicles_ID)
      {
         string sql = "DELETE Bse_Vehicles WHERE 1=1  AND Vehicles_ID=@Vehicles_ID ";
         idb.AddParameter("@Vehicles_ID", vehicles_ID);

           
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
      /// 获取指定的后勤车辆基本信息 Bse_Vehicles对象(即:一条记录
      /// </summary>
      public Bse_Vehicles GetByKey(decimal vehicles_ID)
      {
         Bse_Vehicles bse_Vehicles = new Bse_Vehicles();
         string sql = "SELECT  Vehicles_ID,Vehicles_Code,Vehicles_No,Vehicles_Model,Vehicles_Color,Vehicles_Stable,Vehicles_Company,Vehicles_Dept,Vehicles_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Itype FROM Bse_Vehicles WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Vehicles_ID=@Vehicles_ID ";
         idb.AddParameter("@Vehicles_ID", vehicles_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Vehicles_ID"] != DBNull.Value) bse_Vehicles.Vehicles_ID = Convert.ToDecimal(dr["Vehicles_ID"]);
            if (dr["Vehicles_Code"] != DBNull.Value) bse_Vehicles.Vehicles_Code = Convert.ToString(dr["Vehicles_Code"]);
            if (dr["Vehicles_No"] != DBNull.Value) bse_Vehicles.Vehicles_No = Convert.ToString(dr["Vehicles_No"]);
            if (dr["Vehicles_Model"] != DBNull.Value) bse_Vehicles.Vehicles_Model = Convert.ToString(dr["Vehicles_Model"]);
            if (dr["Vehicles_Color"] != DBNull.Value) bse_Vehicles.Vehicles_Color = Convert.ToString(dr["Vehicles_Color"]);
            if (dr["Vehicles_Stable"] != DBNull.Value) bse_Vehicles.Vehicles_Stable = Convert.ToString(dr["Vehicles_Stable"]);
            if (dr["Vehicles_Company"] != DBNull.Value) bse_Vehicles.Vehicles_Company = Convert.ToString(dr["Vehicles_Company"]);
            if (dr["Vehicles_Dept"] != DBNull.Value) bse_Vehicles.Vehicles_Dept = Convert.ToString(dr["Vehicles_Dept"]);
            if (dr["Vehicles_Remark"] != DBNull.Value) bse_Vehicles.Vehicles_Remark = Convert.ToString(dr["Vehicles_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_Vehicles.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Vehicles.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Vehicles.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Vehicles.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Itype"] != DBNull.Value) bse_Vehicles.Itype = Convert.ToString(dr["Itype"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Vehicles;
      }
      /// <summary>
      /// 获取指定的后勤车辆基本信息 Bse_Vehicles对象集合
      /// </summary>
      public List<Bse_Vehicles> GetListByWhere(string strCondition)
      {
         List<Bse_Vehicles> ret = new List<Bse_Vehicles>();
         string sql = "SELECT  Vehicles_ID,Vehicles_Code,Vehicles_No,Vehicles_Model,Vehicles_Color,Vehicles_Stable,Vehicles_Company,Vehicles_Dept,Vehicles_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Itype FROM Bse_Vehicles WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Vehicles bse_Vehicles = new Bse_Vehicles();
            if (dr["Vehicles_ID"] != DBNull.Value) bse_Vehicles.Vehicles_ID = Convert.ToDecimal(dr["Vehicles_ID"]);
            if (dr["Vehicles_Code"] != DBNull.Value) bse_Vehicles.Vehicles_Code = Convert.ToString(dr["Vehicles_Code"]);
            if (dr["Vehicles_No"] != DBNull.Value) bse_Vehicles.Vehicles_No = Convert.ToString(dr["Vehicles_No"]);
            if (dr["Vehicles_Model"] != DBNull.Value) bse_Vehicles.Vehicles_Model = Convert.ToString(dr["Vehicles_Model"]);
            if (dr["Vehicles_Color"] != DBNull.Value) bse_Vehicles.Vehicles_Color = Convert.ToString(dr["Vehicles_Color"]);
            if (dr["Vehicles_Stable"] != DBNull.Value) bse_Vehicles.Vehicles_Stable = Convert.ToString(dr["Vehicles_Stable"]);
            if (dr["Vehicles_Company"] != DBNull.Value) bse_Vehicles.Vehicles_Company = Convert.ToString(dr["Vehicles_Company"]);
            if (dr["Vehicles_Dept"] != DBNull.Value) bse_Vehicles.Vehicles_Dept = Convert.ToString(dr["Vehicles_Dept"]);
            if (dr["Vehicles_Remark"] != DBNull.Value) bse_Vehicles.Vehicles_Remark = Convert.ToString(dr["Vehicles_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_Vehicles.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Vehicles.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Vehicles.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Vehicles.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Itype"] != DBNull.Value) bse_Vehicles.Itype = Convert.ToString(dr["Itype"]);
            ret.Add(bse_Vehicles);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的后勤车辆基本信息 Bse_Vehicles对象(即:一条记录
      /// </summary>
      public List<Bse_Vehicles> GetAll()
      {
         List<Bse_Vehicles> ret = new List<Bse_Vehicles>();
         string sql = "SELECT  Vehicles_ID,Vehicles_Code,Vehicles_No,Vehicles_Model,Vehicles_Color,Vehicles_Stable,Vehicles_Company,Vehicles_Dept,Vehicles_Remark,Stat,CreateDate,UpdateDate,DeleteDate,Itype FROM Bse_Vehicles where 1=1 AND ((Stat is null) or (Stat=0) ) order by Vehicles_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Vehicles bse_Vehicles = new Bse_Vehicles();
            if (dr["Vehicles_ID"] != DBNull.Value) bse_Vehicles.Vehicles_ID = Convert.ToDecimal(dr["Vehicles_ID"]);
            if (dr["Vehicles_Code"] != DBNull.Value) bse_Vehicles.Vehicles_Code = Convert.ToString(dr["Vehicles_Code"]);
            if (dr["Vehicles_No"] != DBNull.Value) bse_Vehicles.Vehicles_No = Convert.ToString(dr["Vehicles_No"]);
            if (dr["Vehicles_Model"] != DBNull.Value) bse_Vehicles.Vehicles_Model = Convert.ToString(dr["Vehicles_Model"]);
            if (dr["Vehicles_Color"] != DBNull.Value) bse_Vehicles.Vehicles_Color = Convert.ToString(dr["Vehicles_Color"]);
            if (dr["Vehicles_Stable"] != DBNull.Value) bse_Vehicles.Vehicles_Stable = Convert.ToString(dr["Vehicles_Stable"]);
            if (dr["Vehicles_Company"] != DBNull.Value) bse_Vehicles.Vehicles_Company = Convert.ToString(dr["Vehicles_Company"]);
            if (dr["Vehicles_Dept"] != DBNull.Value) bse_Vehicles.Vehicles_Dept = Convert.ToString(dr["Vehicles_Dept"]);
            if (dr["Vehicles_Remark"] != DBNull.Value) bse_Vehicles.Vehicles_Remark = Convert.ToString(dr["Vehicles_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_Vehicles.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Vehicles.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Vehicles.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Vehicles.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Itype"] != DBNull.Value) bse_Vehicles.Itype = Convert.ToString(dr["Itype"]);
            ret.Add(bse_Vehicles);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
