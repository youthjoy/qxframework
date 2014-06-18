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
   /// 摆饰植物更换列表
   /// </summary>
   [Serializable]
   public partial class ADOPlantChanged_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加摆饰植物更换列表 PlantChanged_Record对象(即:一条记录)
      /// </summary>
      public int Add(PlantChanged_Record plantChanged_Record)
      {
         string sql = "INSERT INTO PlantChanged_Record (PCR_Code,PCR_Date,PCR_Dept,PCR_Company,PCR_OldName,PCR_NewName,PCR_Price,PCR_Count,PCR_Cost,PCR_Operator,PCR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position) VALUES (@PCR_Code,@PCR_Date,@PCR_Dept,@PCR_Company,@PCR_OldName,@PCR_NewName,@PCR_Price,@PCR_Count,@PCR_Cost,@PCR_Operator,@PCR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PR_Position)";
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Code))
         {
            idb.AddParameter("@PCR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Code", plantChanged_Record.PCR_Code);
         }
         if (plantChanged_Record.PCR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Date", plantChanged_Record.PCR_Date);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Dept))
         {
            idb.AddParameter("@PCR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Dept", plantChanged_Record.PCR_Dept);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Company))
         {
            idb.AddParameter("@PCR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Company", plantChanged_Record.PCR_Company);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_OldName))
         {
            idb.AddParameter("@PCR_OldName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_OldName", plantChanged_Record.PCR_OldName);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_NewName))
         {
            idb.AddParameter("@PCR_NewName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_NewName", plantChanged_Record.PCR_NewName);
         }
         if (plantChanged_Record.PCR_Price == 0)
         {
            idb.AddParameter("@PCR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Price", plantChanged_Record.PCR_Price);
         }
         if (plantChanged_Record.PCR_Count == 0)
         {
            idb.AddParameter("@PCR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Count", plantChanged_Record.PCR_Count);
         }
         if (plantChanged_Record.PCR_Cost == 0)
         {
            idb.AddParameter("@PCR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Cost", plantChanged_Record.PCR_Cost);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Operator))
         {
            idb.AddParameter("@PCR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Operator", plantChanged_Record.PCR_Operator);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Remark))
         {
            idb.AddParameter("@PCR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Remark", plantChanged_Record.PCR_Remark);
         }
         if (plantChanged_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plantChanged_Record.Stat);
         }
         if (plantChanged_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plantChanged_Record.CreateDate);
         }
         if (plantChanged_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plantChanged_Record.UpdateDate);
         }
         if (plantChanged_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plantChanged_Record.DeleteDate);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plantChanged_Record.PR_Position);
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
      /// 添加摆饰植物更换列表 PlantChanged_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PlantChanged_Record plantChanged_Record)
      {
         string sql = "INSERT INTO PlantChanged_Record (PCR_Code,PCR_Date,PCR_Dept,PCR_Company,PCR_OldName,PCR_NewName,PCR_Price,PCR_Count,PCR_Cost,PCR_Operator,PCR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position) VALUES (@PCR_Code,@PCR_Date,@PCR_Dept,@PCR_Company,@PCR_OldName,@PCR_NewName,@PCR_Price,@PCR_Count,@PCR_Cost,@PCR_Operator,@PCR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PR_Position);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Code))
         {
            idb.AddParameter("@PCR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Code", plantChanged_Record.PCR_Code);
         }
         if (plantChanged_Record.PCR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Date", plantChanged_Record.PCR_Date);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Dept))
         {
            idb.AddParameter("@PCR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Dept", plantChanged_Record.PCR_Dept);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Company))
         {
            idb.AddParameter("@PCR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Company", plantChanged_Record.PCR_Company);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_OldName))
         {
            idb.AddParameter("@PCR_OldName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_OldName", plantChanged_Record.PCR_OldName);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_NewName))
         {
            idb.AddParameter("@PCR_NewName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_NewName", plantChanged_Record.PCR_NewName);
         }
         if (plantChanged_Record.PCR_Price == 0)
         {
            idb.AddParameter("@PCR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Price", plantChanged_Record.PCR_Price);
         }
         if (plantChanged_Record.PCR_Count == 0)
         {
            idb.AddParameter("@PCR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Count", plantChanged_Record.PCR_Count);
         }
         if (plantChanged_Record.PCR_Cost == 0)
         {
            idb.AddParameter("@PCR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Cost", plantChanged_Record.PCR_Cost);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Operator))
         {
            idb.AddParameter("@PCR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Operator", plantChanged_Record.PCR_Operator);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Remark))
         {
            idb.AddParameter("@PCR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Remark", plantChanged_Record.PCR_Remark);
         }
         if (plantChanged_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plantChanged_Record.Stat);
         }
         if (plantChanged_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plantChanged_Record.CreateDate);
         }
         if (plantChanged_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plantChanged_Record.UpdateDate);
         }
         if (plantChanged_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plantChanged_Record.DeleteDate);
         }
         if (string.IsNullOrEmpty(plantChanged_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plantChanged_Record.PR_Position);
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
      /// 更新摆饰植物更换列表 PlantChanged_Record对象(即:一条记录
      /// </summary>
      public int Update(PlantChanged_Record plantChanged_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PlantChanged_Record       SET ");
            if(plantChanged_Record.PCR_Code_IsChanged){sbParameter.Append("PCR_Code=@PCR_Code, ");}
      if(plantChanged_Record.PCR_Date_IsChanged){sbParameter.Append("PCR_Date=@PCR_Date, ");}
      if(plantChanged_Record.PCR_Dept_IsChanged){sbParameter.Append("PCR_Dept=@PCR_Dept, ");}
      if(plantChanged_Record.PCR_Company_IsChanged){sbParameter.Append("PCR_Company=@PCR_Company, ");}
      if(plantChanged_Record.PCR_OldName_IsChanged){sbParameter.Append("PCR_OldName=@PCR_OldName, ");}
      if(plantChanged_Record.PCR_NewName_IsChanged){sbParameter.Append("PCR_NewName=@PCR_NewName, ");}
      if(plantChanged_Record.PCR_Price_IsChanged){sbParameter.Append("PCR_Price=@PCR_Price, ");}
      if(plantChanged_Record.PCR_Count_IsChanged){sbParameter.Append("PCR_Count=@PCR_Count, ");}
      if(plantChanged_Record.PCR_Cost_IsChanged){sbParameter.Append("PCR_Cost=@PCR_Cost, ");}
      if(plantChanged_Record.PCR_Operator_IsChanged){sbParameter.Append("PCR_Operator=@PCR_Operator, ");}
      if(plantChanged_Record.PCR_Remark_IsChanged){sbParameter.Append("PCR_Remark=@PCR_Remark, ");}
      if(plantChanged_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(plantChanged_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(plantChanged_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(plantChanged_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(plantChanged_Record.PR_Position_IsChanged){sbParameter.Append("PR_Position=@PR_Position ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCR_ID=@PCR_ID; " );
      string sql=sb.ToString();
         if(plantChanged_Record.PCR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Code))
         {
            idb.AddParameter("@PCR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Code", plantChanged_Record.PCR_Code);
         }
          }
         if(plantChanged_Record.PCR_Date_IsChanged)
         {
         if (plantChanged_Record.PCR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Date", plantChanged_Record.PCR_Date);
         }
          }
         if(plantChanged_Record.PCR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Dept))
         {
            idb.AddParameter("@PCR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Dept", plantChanged_Record.PCR_Dept);
         }
          }
         if(plantChanged_Record.PCR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Company))
         {
            idb.AddParameter("@PCR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Company", plantChanged_Record.PCR_Company);
         }
          }
         if(plantChanged_Record.PCR_OldName_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_OldName))
         {
            idb.AddParameter("@PCR_OldName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_OldName", plantChanged_Record.PCR_OldName);
         }
          }
         if(plantChanged_Record.PCR_NewName_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_NewName))
         {
            idb.AddParameter("@PCR_NewName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_NewName", plantChanged_Record.PCR_NewName);
         }
          }
         if(plantChanged_Record.PCR_Price_IsChanged)
         {
         if (plantChanged_Record.PCR_Price == 0)
         {
            idb.AddParameter("@PCR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Price", plantChanged_Record.PCR_Price);
         }
          }
         if(plantChanged_Record.PCR_Count_IsChanged)
         {
         if (plantChanged_Record.PCR_Count == 0)
         {
            idb.AddParameter("@PCR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Count", plantChanged_Record.PCR_Count);
         }
          }
         if(plantChanged_Record.PCR_Cost_IsChanged)
         {
         if (plantChanged_Record.PCR_Cost == 0)
         {
            idb.AddParameter("@PCR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@PCR_Cost", plantChanged_Record.PCR_Cost);
         }
          }
         if(plantChanged_Record.PCR_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Operator))
         {
            idb.AddParameter("@PCR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Operator", plantChanged_Record.PCR_Operator);
         }
          }
         if(plantChanged_Record.PCR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PCR_Remark))
         {
            idb.AddParameter("@PCR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCR_Remark", plantChanged_Record.PCR_Remark);
         }
          }
         if(plantChanged_Record.Stat_IsChanged)
         {
         if (plantChanged_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plantChanged_Record.Stat);
         }
          }
         if(plantChanged_Record.CreateDate_IsChanged)
         {
         if (plantChanged_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plantChanged_Record.CreateDate);
         }
          }
         if(plantChanged_Record.UpdateDate_IsChanged)
         {
         if (plantChanged_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plantChanged_Record.UpdateDate);
         }
          }
         if(plantChanged_Record.DeleteDate_IsChanged)
         {
         if (plantChanged_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plantChanged_Record.DeleteDate);
         }
          }
         if(plantChanged_Record.PR_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(plantChanged_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plantChanged_Record.PR_Position);
         }
          }

         idb.AddParameter("@PCR_ID", plantChanged_Record.PCR_ID);

           
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
      /// 删除摆饰植物更换列表 PlantChanged_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCR_ID)
      {
         string sql = "DELETE PlantChanged_Record WHERE 1=1  AND PCR_ID=@PCR_ID ";
         idb.AddParameter("@PCR_ID", pCR_ID);

           
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
      /// 获取指定的摆饰植物更换列表 PlantChanged_Record对象(即:一条记录
      /// </summary>
      public PlantChanged_Record GetByKey(decimal pCR_ID)
      {
         PlantChanged_Record plantChanged_Record = new PlantChanged_Record();
         string sql = "SELECT  PCR_ID,PCR_Code,PCR_Date,PCR_Dept,PCR_Company,PCR_OldName,PCR_NewName,PCR_Price,PCR_Count,PCR_Cost,PCR_Operator,PCR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position FROM PlantChanged_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCR_ID=@PCR_ID ";
         idb.AddParameter("@PCR_ID", pCR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCR_ID"] != DBNull.Value) plantChanged_Record.PCR_ID = Convert.ToDecimal(dr["PCR_ID"]);
            if (dr["PCR_Code"] != DBNull.Value) plantChanged_Record.PCR_Code = Convert.ToString(dr["PCR_Code"]);
            if (dr["PCR_Date"] != DBNull.Value) plantChanged_Record.PCR_Date = Convert.ToDateTime(dr["PCR_Date"]);
            if (dr["PCR_Dept"] != DBNull.Value) plantChanged_Record.PCR_Dept = Convert.ToString(dr["PCR_Dept"]);
            if (dr["PCR_Company"] != DBNull.Value) plantChanged_Record.PCR_Company = Convert.ToString(dr["PCR_Company"]);
            if (dr["PCR_OldName"] != DBNull.Value) plantChanged_Record.PCR_OldName = Convert.ToString(dr["PCR_OldName"]);
            if (dr["PCR_NewName"] != DBNull.Value) plantChanged_Record.PCR_NewName = Convert.ToString(dr["PCR_NewName"]);
            if (dr["PCR_Price"] != DBNull.Value) plantChanged_Record.PCR_Price = Convert.ToDecimal(dr["PCR_Price"]);
            if (dr["PCR_Count"] != DBNull.Value) plantChanged_Record.PCR_Count = Convert.ToInt32(dr["PCR_Count"]);
            if (dr["PCR_Cost"] != DBNull.Value) plantChanged_Record.PCR_Cost = Convert.ToDecimal(dr["PCR_Cost"]);
            if (dr["PCR_Operator"] != DBNull.Value) plantChanged_Record.PCR_Operator = Convert.ToString(dr["PCR_Operator"]);
            if (dr["PCR_Remark"] != DBNull.Value) plantChanged_Record.PCR_Remark = Convert.ToString(dr["PCR_Remark"]);
            if (dr["Stat"] != DBNull.Value) plantChanged_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plantChanged_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plantChanged_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plantChanged_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PR_Position"] != DBNull.Value) plantChanged_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return plantChanged_Record;
      }
      /// <summary>
      /// 获取指定的摆饰植物更换列表 PlantChanged_Record对象集合
      /// </summary>
      public List<PlantChanged_Record> GetListByWhere(string strCondition)
      {
         List<PlantChanged_Record> ret = new List<PlantChanged_Record>();
         string sql = "SELECT  PCR_ID,PCR_Code,PCR_Date,PCR_Dept,PCR_Company,PCR_OldName,PCR_NewName,PCR_Price,PCR_Count,PCR_Cost,PCR_Operator,PCR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position FROM PlantChanged_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PlantChanged_Record plantChanged_Record = new PlantChanged_Record();
            if (dr["PCR_ID"] != DBNull.Value) plantChanged_Record.PCR_ID = Convert.ToDecimal(dr["PCR_ID"]);
            if (dr["PCR_Code"] != DBNull.Value) plantChanged_Record.PCR_Code = Convert.ToString(dr["PCR_Code"]);
            if (dr["PCR_Date"] != DBNull.Value) plantChanged_Record.PCR_Date = Convert.ToDateTime(dr["PCR_Date"]);
            if (dr["PCR_Dept"] != DBNull.Value) plantChanged_Record.PCR_Dept = Convert.ToString(dr["PCR_Dept"]);
            if (dr["PCR_Company"] != DBNull.Value) plantChanged_Record.PCR_Company = Convert.ToString(dr["PCR_Company"]);
            if (dr["PCR_OldName"] != DBNull.Value) plantChanged_Record.PCR_OldName = Convert.ToString(dr["PCR_OldName"]);
            if (dr["PCR_NewName"] != DBNull.Value) plantChanged_Record.PCR_NewName = Convert.ToString(dr["PCR_NewName"]);
            if (dr["PCR_Price"] != DBNull.Value) plantChanged_Record.PCR_Price = Convert.ToDecimal(dr["PCR_Price"]);
            if (dr["PCR_Count"] != DBNull.Value) plantChanged_Record.PCR_Count = Convert.ToInt32(dr["PCR_Count"]);
            if (dr["PCR_Cost"] != DBNull.Value) plantChanged_Record.PCR_Cost = Convert.ToDecimal(dr["PCR_Cost"]);
            if (dr["PCR_Operator"] != DBNull.Value) plantChanged_Record.PCR_Operator = Convert.ToString(dr["PCR_Operator"]);
            if (dr["PCR_Remark"] != DBNull.Value) plantChanged_Record.PCR_Remark = Convert.ToString(dr["PCR_Remark"]);
            if (dr["Stat"] != DBNull.Value) plantChanged_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plantChanged_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plantChanged_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plantChanged_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PR_Position"] != DBNull.Value) plantChanged_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            ret.Add(plantChanged_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的摆饰植物更换列表 PlantChanged_Record对象(即:一条记录
      /// </summary>
      public List<PlantChanged_Record> GetAll()
      {
         List<PlantChanged_Record> ret = new List<PlantChanged_Record>();
         string sql = "SELECT  PCR_ID,PCR_Code,PCR_Date,PCR_Dept,PCR_Company,PCR_OldName,PCR_NewName,PCR_Price,PCR_Count,PCR_Cost,PCR_Operator,PCR_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PR_Position FROM PlantChanged_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PlantChanged_Record plantChanged_Record = new PlantChanged_Record();
            if (dr["PCR_ID"] != DBNull.Value) plantChanged_Record.PCR_ID = Convert.ToDecimal(dr["PCR_ID"]);
            if (dr["PCR_Code"] != DBNull.Value) plantChanged_Record.PCR_Code = Convert.ToString(dr["PCR_Code"]);
            if (dr["PCR_Date"] != DBNull.Value) plantChanged_Record.PCR_Date = Convert.ToDateTime(dr["PCR_Date"]);
            if (dr["PCR_Dept"] != DBNull.Value) plantChanged_Record.PCR_Dept = Convert.ToString(dr["PCR_Dept"]);
            if (dr["PCR_Company"] != DBNull.Value) plantChanged_Record.PCR_Company = Convert.ToString(dr["PCR_Company"]);
            if (dr["PCR_OldName"] != DBNull.Value) plantChanged_Record.PCR_OldName = Convert.ToString(dr["PCR_OldName"]);
            if (dr["PCR_NewName"] != DBNull.Value) plantChanged_Record.PCR_NewName = Convert.ToString(dr["PCR_NewName"]);
            if (dr["PCR_Price"] != DBNull.Value) plantChanged_Record.PCR_Price = Convert.ToDecimal(dr["PCR_Price"]);
            if (dr["PCR_Count"] != DBNull.Value) plantChanged_Record.PCR_Count = Convert.ToInt32(dr["PCR_Count"]);
            if (dr["PCR_Cost"] != DBNull.Value) plantChanged_Record.PCR_Cost = Convert.ToDecimal(dr["PCR_Cost"]);
            if (dr["PCR_Operator"] != DBNull.Value) plantChanged_Record.PCR_Operator = Convert.ToString(dr["PCR_Operator"]);
            if (dr["PCR_Remark"] != DBNull.Value) plantChanged_Record.PCR_Remark = Convert.ToString(dr["PCR_Remark"]);
            if (dr["Stat"] != DBNull.Value) plantChanged_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plantChanged_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plantChanged_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plantChanged_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PR_Position"] != DBNull.Value) plantChanged_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            ret.Add(plantChanged_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
