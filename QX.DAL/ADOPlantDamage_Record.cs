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
   /// 摆放植物损坏列表
   /// </summary>
   [Serializable]
   public partial class ADOPlantDamage_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加摆放植物损坏列表 PlantDamage_Record对象(即:一条记录)
      /// </summary>
      public int Add(PlantDamage_Record plantDamage_Record)
      {
         string sql = "INSERT INTO PlantDamage_Record (PDR_Code,PDR_Date,PDR_Company,PDR_Dept,PDR_PlantName,PDR_Price,PDR_Count,PDR_Amount,PDR_Reason,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position,PDR_PlantCode) VALUES (@PDR_Code,@PDR_Date,@PDR_Company,@PDR_Dept,@PDR_PlantName,@PDR_Price,@PDR_Count,@PDR_Amount,@PDR_Reason,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PR_Position,@PDR_PlantCode)";
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Code))
         {
            idb.AddParameter("@PDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Code", plantDamage_Record.PDR_Code);
         }
         if (plantDamage_Record.PDR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PDR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Date", plantDamage_Record.PDR_Date);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Company))
         {
            idb.AddParameter("@PDR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Company", plantDamage_Record.PDR_Company);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Dept))
         {
            idb.AddParameter("@PDR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Dept", plantDamage_Record.PDR_Dept);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_PlantName))
         {
            idb.AddParameter("@PDR_PlantName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_PlantName", plantDamage_Record.PDR_PlantName);
         }
         if (plantDamage_Record.PDR_Price == 0)
         {
            idb.AddParameter("@PDR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Price", plantDamage_Record.PDR_Price);
         }
         if (plantDamage_Record.PDR_Count == 0)
         {
            idb.AddParameter("@PDR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Count", plantDamage_Record.PDR_Count);
         }
         if (plantDamage_Record.PDR_Amount == 0)
         {
            idb.AddParameter("@PDR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Amount", plantDamage_Record.PDR_Amount);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Reason))
         {
            idb.AddParameter("@PDR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Reason", plantDamage_Record.PDR_Reason);
         }
         if (plantDamage_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plantDamage_Record.Stat);
         }
         if (plantDamage_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plantDamage_Record.CreateDate);
         }
         if (plantDamage_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plantDamage_Record.UpdateDate);
         }
         if (plantDamage_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plantDamage_Record.DeleteDate);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plantDamage_Record.PR_Position);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_PlantCode))
         {
            idb.AddParameter("@PDR_PlantCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_PlantCode", plantDamage_Record.PDR_PlantCode);
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
      /// 添加摆放植物损坏列表 PlantDamage_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PlantDamage_Record plantDamage_Record)
      {
         string sql = "INSERT INTO PlantDamage_Record (PDR_Code,PDR_Date,PDR_Company,PDR_Dept,PDR_PlantName,PDR_Price,PDR_Count,PDR_Amount,PDR_Reason,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position,PDR_PlantCode) VALUES (@PDR_Code,@PDR_Date,@PDR_Company,@PDR_Dept,@PDR_PlantName,@PDR_Price,@PDR_Count,@PDR_Amount,@PDR_Reason,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PR_Position,@PDR_PlantCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Code))
         {
            idb.AddParameter("@PDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Code", plantDamage_Record.PDR_Code);
         }
         if (plantDamage_Record.PDR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PDR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Date", plantDamage_Record.PDR_Date);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Company))
         {
            idb.AddParameter("@PDR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Company", plantDamage_Record.PDR_Company);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Dept))
         {
            idb.AddParameter("@PDR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Dept", plantDamage_Record.PDR_Dept);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_PlantName))
         {
            idb.AddParameter("@PDR_PlantName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_PlantName", plantDamage_Record.PDR_PlantName);
         }
         if (plantDamage_Record.PDR_Price == 0)
         {
            idb.AddParameter("@PDR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Price", plantDamage_Record.PDR_Price);
         }
         if (plantDamage_Record.PDR_Count == 0)
         {
            idb.AddParameter("@PDR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Count", plantDamage_Record.PDR_Count);
         }
         if (plantDamage_Record.PDR_Amount == 0)
         {
            idb.AddParameter("@PDR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Amount", plantDamage_Record.PDR_Amount);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Reason))
         {
            idb.AddParameter("@PDR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Reason", plantDamage_Record.PDR_Reason);
         }
         if (plantDamage_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plantDamage_Record.Stat);
         }
         if (plantDamage_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plantDamage_Record.CreateDate);
         }
         if (plantDamage_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plantDamage_Record.UpdateDate);
         }
         if (plantDamage_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plantDamage_Record.DeleteDate);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plantDamage_Record.PR_Position);
         }
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_PlantCode))
         {
            idb.AddParameter("@PDR_PlantCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_PlantCode", plantDamage_Record.PDR_PlantCode);
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
      /// 更新摆放植物损坏列表 PlantDamage_Record对象(即:一条记录
      /// </summary>
      public int Update(PlantDamage_Record plantDamage_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PlantDamage_Record       SET ");
            if(plantDamage_Record.PDR_Code_IsChanged){sbParameter.Append("PDR_Code=@PDR_Code, ");}
      if(plantDamage_Record.PDR_Date_IsChanged){sbParameter.Append("PDR_Date=@PDR_Date, ");}
      if(plantDamage_Record.PDR_Company_IsChanged){sbParameter.Append("PDR_Company=@PDR_Company, ");}
      if(plantDamage_Record.PDR_Dept_IsChanged){sbParameter.Append("PDR_Dept=@PDR_Dept, ");}
      if(plantDamage_Record.PDR_PlantName_IsChanged){sbParameter.Append("PDR_PlantName=@PDR_PlantName, ");}
      if(plantDamage_Record.PDR_Price_IsChanged){sbParameter.Append("PDR_Price=@PDR_Price, ");}
      if(plantDamage_Record.PDR_Count_IsChanged){sbParameter.Append("PDR_Count=@PDR_Count, ");}
      if(plantDamage_Record.PDR_Amount_IsChanged){sbParameter.Append("PDR_Amount=@PDR_Amount, ");}
      if(plantDamage_Record.PDR_Reason_IsChanged){sbParameter.Append("PDR_Reason=@PDR_Reason, ");}
      if(plantDamage_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(plantDamage_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(plantDamage_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(plantDamage_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(plantDamage_Record.PR_Position_IsChanged){sbParameter.Append("PR_Position=@PR_Position, ");}
      if(plantDamage_Record.PDR_PlantCode_IsChanged){sbParameter.Append("PDR_PlantCode=@PDR_PlantCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PDR_ID=@PDR_ID; " );
      string sql=sb.ToString();
         if(plantDamage_Record.PDR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Code))
         {
            idb.AddParameter("@PDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Code", plantDamage_Record.PDR_Code);
         }
          }
         if(plantDamage_Record.PDR_Date_IsChanged)
         {
         if (plantDamage_Record.PDR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PDR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Date", plantDamage_Record.PDR_Date);
         }
          }
         if(plantDamage_Record.PDR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Company))
         {
            idb.AddParameter("@PDR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Company", plantDamage_Record.PDR_Company);
         }
          }
         if(plantDamage_Record.PDR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Dept))
         {
            idb.AddParameter("@PDR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Dept", plantDamage_Record.PDR_Dept);
         }
          }
         if(plantDamage_Record.PDR_PlantName_IsChanged)
         {
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_PlantName))
         {
            idb.AddParameter("@PDR_PlantName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_PlantName", plantDamage_Record.PDR_PlantName);
         }
          }
         if(plantDamage_Record.PDR_Price_IsChanged)
         {
         if (plantDamage_Record.PDR_Price == 0)
         {
            idb.AddParameter("@PDR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Price", plantDamage_Record.PDR_Price);
         }
          }
         if(plantDamage_Record.PDR_Count_IsChanged)
         {
         if (plantDamage_Record.PDR_Count == 0)
         {
            idb.AddParameter("@PDR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Count", plantDamage_Record.PDR_Count);
         }
          }
         if(plantDamage_Record.PDR_Amount_IsChanged)
         {
         if (plantDamage_Record.PDR_Amount == 0)
         {
            idb.AddParameter("@PDR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@PDR_Amount", plantDamage_Record.PDR_Amount);
         }
          }
         if(plantDamage_Record.PDR_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_Reason))
         {
            idb.AddParameter("@PDR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_Reason", plantDamage_Record.PDR_Reason);
         }
          }
         if(plantDamage_Record.Stat_IsChanged)
         {
         if (plantDamage_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plantDamage_Record.Stat);
         }
          }
         if(plantDamage_Record.CreateDate_IsChanged)
         {
         if (plantDamage_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plantDamage_Record.CreateDate);
         }
          }
         if(plantDamage_Record.UpdateDate_IsChanged)
         {
         if (plantDamage_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plantDamage_Record.UpdateDate);
         }
          }
         if(plantDamage_Record.DeleteDate_IsChanged)
         {
         if (plantDamage_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plantDamage_Record.DeleteDate);
         }
          }
         if(plantDamage_Record.PR_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(plantDamage_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plantDamage_Record.PR_Position);
         }
          }
         if(plantDamage_Record.PDR_PlantCode_IsChanged)
         {
         if (string.IsNullOrEmpty(plantDamage_Record.PDR_PlantCode))
         {
            idb.AddParameter("@PDR_PlantCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PDR_PlantCode", plantDamage_Record.PDR_PlantCode);
         }
          }

         idb.AddParameter("@PDR_ID", plantDamage_Record.PDR_ID);

           
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
      /// 删除摆放植物损坏列表 PlantDamage_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal pDR_ID)
      {
         string sql = "DELETE PlantDamage_Record WHERE 1=1  AND PDR_ID=@PDR_ID ";
         idb.AddParameter("@PDR_ID", pDR_ID);

           
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
      /// 获取指定的摆放植物损坏列表 PlantDamage_Record对象(即:一条记录
      /// </summary>
      public PlantDamage_Record GetByKey(decimal pDR_ID)
      {
         PlantDamage_Record plantDamage_Record = new PlantDamage_Record();
         string sql = "SELECT  PDR_ID,PDR_Code,PDR_Date,PDR_Company,PDR_Dept,PDR_PlantName,PDR_Price,PDR_Count,PDR_Amount,PDR_Reason,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position,PDR_PlantCode FROM PlantDamage_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PDR_ID=@PDR_ID ";
         idb.AddParameter("@PDR_ID", pDR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PDR_ID"] != DBNull.Value) plantDamage_Record.PDR_ID = Convert.ToDecimal(dr["PDR_ID"]);
            if (dr["PDR_Code"] != DBNull.Value) plantDamage_Record.PDR_Code = Convert.ToString(dr["PDR_Code"]);
            if (dr["PDR_Date"] != DBNull.Value) plantDamage_Record.PDR_Date = Convert.ToDateTime(dr["PDR_Date"]);
            if (dr["PDR_Company"] != DBNull.Value) plantDamage_Record.PDR_Company = Convert.ToString(dr["PDR_Company"]);
            if (dr["PDR_Dept"] != DBNull.Value) plantDamage_Record.PDR_Dept = Convert.ToString(dr["PDR_Dept"]);
            if (dr["PDR_PlantName"] != DBNull.Value) plantDamage_Record.PDR_PlantName = Convert.ToString(dr["PDR_PlantName"]);
            if (dr["PDR_Price"] != DBNull.Value) plantDamage_Record.PDR_Price = Convert.ToDecimal(dr["PDR_Price"]);
            if (dr["PDR_Count"] != DBNull.Value) plantDamage_Record.PDR_Count = Convert.ToInt32(dr["PDR_Count"]);
            if (dr["PDR_Amount"] != DBNull.Value) plantDamage_Record.PDR_Amount = Convert.ToDecimal(dr["PDR_Amount"]);
            if (dr["PDR_Reason"] != DBNull.Value) plantDamage_Record.PDR_Reason = Convert.ToString(dr["PDR_Reason"]);
            if (dr["Stat"] != DBNull.Value) plantDamage_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plantDamage_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plantDamage_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plantDamage_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PR_Position"] != DBNull.Value) plantDamage_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            if (dr["PDR_PlantCode"] != DBNull.Value) plantDamage_Record.PDR_PlantCode = Convert.ToString(dr["PDR_PlantCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return plantDamage_Record;
      }
      /// <summary>
      /// 获取指定的摆放植物损坏列表 PlantDamage_Record对象集合
      /// </summary>
      public List<PlantDamage_Record> GetListByWhere(string strCondition)
      {
         List<PlantDamage_Record> ret = new List<PlantDamage_Record>();
         string sql = "SELECT  PDR_ID,PDR_Code,PDR_Date,PDR_Company,PDR_Dept,PDR_PlantName,PDR_Price,PDR_Count,PDR_Amount,PDR_Reason,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position,PDR_PlantCode FROM PlantDamage_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PlantDamage_Record plantDamage_Record = new PlantDamage_Record();
            if (dr["PDR_ID"] != DBNull.Value) plantDamage_Record.PDR_ID = Convert.ToDecimal(dr["PDR_ID"]);
            if (dr["PDR_Code"] != DBNull.Value) plantDamage_Record.PDR_Code = Convert.ToString(dr["PDR_Code"]);
            if (dr["PDR_Date"] != DBNull.Value) plantDamage_Record.PDR_Date = Convert.ToDateTime(dr["PDR_Date"]);
            if (dr["PDR_Company"] != DBNull.Value) plantDamage_Record.PDR_Company = Convert.ToString(dr["PDR_Company"]);
            if (dr["PDR_Dept"] != DBNull.Value) plantDamage_Record.PDR_Dept = Convert.ToString(dr["PDR_Dept"]);
            if (dr["PDR_PlantName"] != DBNull.Value) plantDamage_Record.PDR_PlantName = Convert.ToString(dr["PDR_PlantName"]);
            if (dr["PDR_Price"] != DBNull.Value) plantDamage_Record.PDR_Price = Convert.ToDecimal(dr["PDR_Price"]);
            if (dr["PDR_Count"] != DBNull.Value) plantDamage_Record.PDR_Count = Convert.ToInt32(dr["PDR_Count"]);
            if (dr["PDR_Amount"] != DBNull.Value) plantDamage_Record.PDR_Amount = Convert.ToDecimal(dr["PDR_Amount"]);
            if (dr["PDR_Reason"] != DBNull.Value) plantDamage_Record.PDR_Reason = Convert.ToString(dr["PDR_Reason"]);
            if (dr["Stat"] != DBNull.Value) plantDamage_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plantDamage_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plantDamage_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plantDamage_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PR_Position"] != DBNull.Value) plantDamage_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            if (dr["PDR_PlantCode"] != DBNull.Value) plantDamage_Record.PDR_PlantCode = Convert.ToString(dr["PDR_PlantCode"]);
            ret.Add(plantDamage_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的摆放植物损坏列表 PlantDamage_Record对象(即:一条记录
      /// </summary>
      public List<PlantDamage_Record> GetAll()
      {
         List<PlantDamage_Record> ret = new List<PlantDamage_Record>();
         string sql = "SELECT  PDR_ID,PDR_Code,PDR_Date,PDR_Company,PDR_Dept,PDR_PlantName,PDR_Price,PDR_Count,PDR_Amount,PDR_Reason,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position,PDR_PlantCode FROM PlantDamage_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by PDR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PlantDamage_Record plantDamage_Record = new PlantDamage_Record();
            if (dr["PDR_ID"] != DBNull.Value) plantDamage_Record.PDR_ID = Convert.ToDecimal(dr["PDR_ID"]);
            if (dr["PDR_Code"] != DBNull.Value) plantDamage_Record.PDR_Code = Convert.ToString(dr["PDR_Code"]);
            if (dr["PDR_Date"] != DBNull.Value) plantDamage_Record.PDR_Date = Convert.ToDateTime(dr["PDR_Date"]);
            if (dr["PDR_Company"] != DBNull.Value) plantDamage_Record.PDR_Company = Convert.ToString(dr["PDR_Company"]);
            if (dr["PDR_Dept"] != DBNull.Value) plantDamage_Record.PDR_Dept = Convert.ToString(dr["PDR_Dept"]);
            if (dr["PDR_PlantName"] != DBNull.Value) plantDamage_Record.PDR_PlantName = Convert.ToString(dr["PDR_PlantName"]);
            if (dr["PDR_Price"] != DBNull.Value) plantDamage_Record.PDR_Price = Convert.ToDecimal(dr["PDR_Price"]);
            if (dr["PDR_Count"] != DBNull.Value) plantDamage_Record.PDR_Count = Convert.ToInt32(dr["PDR_Count"]);
            if (dr["PDR_Amount"] != DBNull.Value) plantDamage_Record.PDR_Amount = Convert.ToDecimal(dr["PDR_Amount"]);
            if (dr["PDR_Reason"] != DBNull.Value) plantDamage_Record.PDR_Reason = Convert.ToString(dr["PDR_Reason"]);
            if (dr["Stat"] != DBNull.Value) plantDamage_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plantDamage_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plantDamage_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plantDamage_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PR_Position"] != DBNull.Value) plantDamage_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            if (dr["PDR_PlantCode"] != DBNull.Value) plantDamage_Record.PDR_PlantCode = Convert.ToString(dr["PDR_PlantCode"]);
            ret.Add(plantDamage_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
