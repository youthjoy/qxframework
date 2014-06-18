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
   /// 摆放植物列表
   /// </summary>
   [Serializable]
   public partial class ADOPlant_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加摆放植物列表 Plant_Record对象(即:一条记录)
      /// </summary>
      public int Add(Plant_Record plant_Record)
      {
         string sql = "INSERT INTO Plant_Record (PR_Code,PR_Company,PR_Dept,PR_Floor,PR_Position,PR_Category,PR_Count,PR_Price,PR_Amount,PR_Date,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PR_Code,@PR_Company,@PR_Dept,@PR_Floor,@PR_Position,@PR_Category,@PR_Count,@PR_Price,@PR_Amount,@PR_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(plant_Record.PR_Code))
         {
            idb.AddParameter("@PR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Code", plant_Record.PR_Code);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Company))
         {
            idb.AddParameter("@PR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Company", plant_Record.PR_Company);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Dept))
         {
            idb.AddParameter("@PR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Dept", plant_Record.PR_Dept);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Floor))
         {
            idb.AddParameter("@PR_Floor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Floor", plant_Record.PR_Floor);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plant_Record.PR_Position);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Category))
         {
            idb.AddParameter("@PR_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Category", plant_Record.PR_Category);
         }
         if (plant_Record.PR_Count == 0)
         {
            idb.AddParameter("@PR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PR_Count", plant_Record.PR_Count);
         }
         if (plant_Record.PR_Price == 0)
         {
            idb.AddParameter("@PR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PR_Price", plant_Record.PR_Price);
         }
         if (plant_Record.PR_Amount == 0)
         {
            idb.AddParameter("@PR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@PR_Amount", plant_Record.PR_Amount);
         }
         if (plant_Record.PR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Date", plant_Record.PR_Date);
         }
         if (plant_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plant_Record.Stat);
         }
         if (plant_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plant_Record.CreateDate);
         }
         if (plant_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plant_Record.UpdateDate);
         }
         if (plant_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plant_Record.DeleteDate);
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
      /// 添加摆放植物列表 Plant_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Plant_Record plant_Record)
      {
         string sql = "INSERT INTO Plant_Record (PR_Code,PR_Company,PR_Dept,PR_Floor,PR_Position,PR_Category,PR_Count,PR_Price,PR_Amount,PR_Date,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PR_Code,@PR_Company,@PR_Dept,@PR_Floor,@PR_Position,@PR_Category,@PR_Count,@PR_Price,@PR_Amount,@PR_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(plant_Record.PR_Code))
         {
            idb.AddParameter("@PR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Code", plant_Record.PR_Code);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Company))
         {
            idb.AddParameter("@PR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Company", plant_Record.PR_Company);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Dept))
         {
            idb.AddParameter("@PR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Dept", plant_Record.PR_Dept);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Floor))
         {
            idb.AddParameter("@PR_Floor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Floor", plant_Record.PR_Floor);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plant_Record.PR_Position);
         }
         if (string.IsNullOrEmpty(plant_Record.PR_Category))
         {
            idb.AddParameter("@PR_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Category", plant_Record.PR_Category);
         }
         if (plant_Record.PR_Count == 0)
         {
            idb.AddParameter("@PR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PR_Count", plant_Record.PR_Count);
         }
         if (plant_Record.PR_Price == 0)
         {
            idb.AddParameter("@PR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PR_Price", plant_Record.PR_Price);
         }
         if (plant_Record.PR_Amount == 0)
         {
            idb.AddParameter("@PR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@PR_Amount", plant_Record.PR_Amount);
         }
         if (plant_Record.PR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Date", plant_Record.PR_Date);
         }
         if (plant_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plant_Record.Stat);
         }
         if (plant_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plant_Record.CreateDate);
         }
         if (plant_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plant_Record.UpdateDate);
         }
         if (plant_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plant_Record.DeleteDate);
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
      /// 更新摆放植物列表 Plant_Record对象(即:一条记录
      /// </summary>
      public int Update(Plant_Record plant_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Plant_Record       SET ");
            if(plant_Record.PR_Code_IsChanged){sbParameter.Append("PR_Code=@PR_Code, ");}
      if(plant_Record.PR_Company_IsChanged){sbParameter.Append("PR_Company=@PR_Company, ");}
      if(plant_Record.PR_Dept_IsChanged){sbParameter.Append("PR_Dept=@PR_Dept, ");}
      if(plant_Record.PR_Floor_IsChanged){sbParameter.Append("PR_Floor=@PR_Floor, ");}
      if(plant_Record.PR_Position_IsChanged){sbParameter.Append("PR_Position=@PR_Position, ");}
      if(plant_Record.PR_Category_IsChanged){sbParameter.Append("PR_Category=@PR_Category, ");}
      if(plant_Record.PR_Count_IsChanged){sbParameter.Append("PR_Count=@PR_Count, ");}
      if(plant_Record.PR_Price_IsChanged){sbParameter.Append("PR_Price=@PR_Price, ");}
      if(plant_Record.PR_Amount_IsChanged){sbParameter.Append("PR_Amount=@PR_Amount, ");}
      if(plant_Record.PR_Date_IsChanged){sbParameter.Append("PR_Date=@PR_Date, ");}
      if(plant_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(plant_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(plant_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(plant_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PR_ID=@PR_ID; " );
      string sql=sb.ToString();
         if(plant_Record.PR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Record.PR_Code))
         {
            idb.AddParameter("@PR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Code", plant_Record.PR_Code);
         }
          }
         if(plant_Record.PR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Record.PR_Company))
         {
            idb.AddParameter("@PR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Company", plant_Record.PR_Company);
         }
          }
         if(plant_Record.PR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Record.PR_Dept))
         {
            idb.AddParameter("@PR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Dept", plant_Record.PR_Dept);
         }
          }
         if(plant_Record.PR_Floor_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Record.PR_Floor))
         {
            idb.AddParameter("@PR_Floor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Floor", plant_Record.PR_Floor);
         }
          }
         if(plant_Record.PR_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Record.PR_Position))
         {
            idb.AddParameter("@PR_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Position", plant_Record.PR_Position);
         }
          }
         if(plant_Record.PR_Category_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Record.PR_Category))
         {
            idb.AddParameter("@PR_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Category", plant_Record.PR_Category);
         }
          }
         if(plant_Record.PR_Count_IsChanged)
         {
         if (plant_Record.PR_Count == 0)
         {
            idb.AddParameter("@PR_Count", 0);
         }
         else
         {
            idb.AddParameter("@PR_Count", plant_Record.PR_Count);
         }
          }
         if(plant_Record.PR_Price_IsChanged)
         {
         if (plant_Record.PR_Price == 0)
         {
            idb.AddParameter("@PR_Price", 0);
         }
         else
         {
            idb.AddParameter("@PR_Price", plant_Record.PR_Price);
         }
          }
         if(plant_Record.PR_Amount_IsChanged)
         {
         if (plant_Record.PR_Amount == 0)
         {
            idb.AddParameter("@PR_Amount", 0);
         }
         else
         {
            idb.AddParameter("@PR_Amount", plant_Record.PR_Amount);
         }
          }
         if(plant_Record.PR_Date_IsChanged)
         {
         if (plant_Record.PR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PR_Date", plant_Record.PR_Date);
         }
          }
         if(plant_Record.Stat_IsChanged)
         {
         if (plant_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plant_Record.Stat);
         }
          }
         if(plant_Record.CreateDate_IsChanged)
         {
         if (plant_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plant_Record.CreateDate);
         }
          }
         if(plant_Record.UpdateDate_IsChanged)
         {
         if (plant_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plant_Record.UpdateDate);
         }
          }
         if(plant_Record.DeleteDate_IsChanged)
         {
         if (plant_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plant_Record.DeleteDate);
         }
          }

         idb.AddParameter("@PR_ID", plant_Record.PR_ID);

           
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
      /// 删除摆放植物列表 Plant_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal pR_ID)
      {
         string sql = "DELETE Plant_Record WHERE 1=1  AND PR_ID=@PR_ID ";
         idb.AddParameter("@PR_ID", pR_ID);

           
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
      /// 获取指定的摆放植物列表 Plant_Record对象(即:一条记录
      /// </summary>
      public Plant_Record GetByKey(decimal pR_ID)
      {
         Plant_Record plant_Record = new Plant_Record();
         string sql = "SELECT  PR_ID,PR_Code,PR_Company,PR_Dept,PR_Floor,PR_Position,PR_Category,PR_Count,PR_Price,PR_Amount,PR_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM Plant_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PR_ID=@PR_ID ";
         idb.AddParameter("@PR_ID", pR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PR_ID"] != DBNull.Value) plant_Record.PR_ID = Convert.ToDecimal(dr["PR_ID"]);
            if (dr["PR_Code"] != DBNull.Value) plant_Record.PR_Code = Convert.ToString(dr["PR_Code"]);
            if (dr["PR_Company"] != DBNull.Value) plant_Record.PR_Company = Convert.ToString(dr["PR_Company"]);
            if (dr["PR_Dept"] != DBNull.Value) plant_Record.PR_Dept = Convert.ToString(dr["PR_Dept"]);
            if (dr["PR_Floor"] != DBNull.Value) plant_Record.PR_Floor = Convert.ToString(dr["PR_Floor"]);
            if (dr["PR_Position"] != DBNull.Value) plant_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            if (dr["PR_Category"] != DBNull.Value) plant_Record.PR_Category = Convert.ToString(dr["PR_Category"]);
            if (dr["PR_Count"] != DBNull.Value) plant_Record.PR_Count = Convert.ToInt32(dr["PR_Count"]);
            if (dr["PR_Price"] != DBNull.Value) plant_Record.PR_Price = Convert.ToDecimal(dr["PR_Price"]);
            if (dr["PR_Amount"] != DBNull.Value) plant_Record.PR_Amount = Convert.ToDecimal(dr["PR_Amount"]);
            if (dr["PR_Date"] != DBNull.Value) plant_Record.PR_Date = Convert.ToDateTime(dr["PR_Date"]);
            if (dr["Stat"] != DBNull.Value) plant_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plant_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plant_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plant_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return plant_Record;
      }
      /// <summary>
      /// 获取指定的摆放植物列表 Plant_Record对象集合
      /// </summary>
      public List<Plant_Record> GetListByWhere(string strCondition)
      {
         List<Plant_Record> ret = new List<Plant_Record>();
         string sql = "SELECT  PR_ID,PR_Code,PR_Company,PR_Dept,PR_Floor,PR_Position,PR_Category,PR_Count,PR_Price,PR_Amount,PR_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM Plant_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Plant_Record plant_Record = new Plant_Record();
            if (dr["PR_ID"] != DBNull.Value) plant_Record.PR_ID = Convert.ToDecimal(dr["PR_ID"]);
            if (dr["PR_Code"] != DBNull.Value) plant_Record.PR_Code = Convert.ToString(dr["PR_Code"]);
            if (dr["PR_Company"] != DBNull.Value) plant_Record.PR_Company = Convert.ToString(dr["PR_Company"]);
            if (dr["PR_Dept"] != DBNull.Value) plant_Record.PR_Dept = Convert.ToString(dr["PR_Dept"]);
            if (dr["PR_Floor"] != DBNull.Value) plant_Record.PR_Floor = Convert.ToString(dr["PR_Floor"]);
            if (dr["PR_Position"] != DBNull.Value) plant_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            if (dr["PR_Category"] != DBNull.Value) plant_Record.PR_Category = Convert.ToString(dr["PR_Category"]);
            if (dr["PR_Count"] != DBNull.Value) plant_Record.PR_Count = Convert.ToInt32(dr["PR_Count"]);
            if (dr["PR_Price"] != DBNull.Value) plant_Record.PR_Price = Convert.ToDecimal(dr["PR_Price"]);
            if (dr["PR_Amount"] != DBNull.Value) plant_Record.PR_Amount = Convert.ToDecimal(dr["PR_Amount"]);
            if (dr["PR_Date"] != DBNull.Value) plant_Record.PR_Date = Convert.ToDateTime(dr["PR_Date"]);
            if (dr["Stat"] != DBNull.Value) plant_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plant_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plant_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plant_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(plant_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的摆放植物列表 Plant_Record对象(即:一条记录
      /// </summary>
      public List<Plant_Record> GetAll()
      {
         List<Plant_Record> ret = new List<Plant_Record>();
         string sql = "SELECT  PR_ID,PR_Code,PR_Company,PR_Dept,PR_Floor,PR_Position,PR_Category,PR_Count,PR_Price,PR_Amount,PR_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM Plant_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by PR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Plant_Record plant_Record = new Plant_Record();
            if (dr["PR_ID"] != DBNull.Value) plant_Record.PR_ID = Convert.ToDecimal(dr["PR_ID"]);
            if (dr["PR_Code"] != DBNull.Value) plant_Record.PR_Code = Convert.ToString(dr["PR_Code"]);
            if (dr["PR_Company"] != DBNull.Value) plant_Record.PR_Company = Convert.ToString(dr["PR_Company"]);
            if (dr["PR_Dept"] != DBNull.Value) plant_Record.PR_Dept = Convert.ToString(dr["PR_Dept"]);
            if (dr["PR_Floor"] != DBNull.Value) plant_Record.PR_Floor = Convert.ToString(dr["PR_Floor"]);
            if (dr["PR_Position"] != DBNull.Value) plant_Record.PR_Position = Convert.ToString(dr["PR_Position"]);
            if (dr["PR_Category"] != DBNull.Value) plant_Record.PR_Category = Convert.ToString(dr["PR_Category"]);
            if (dr["PR_Count"] != DBNull.Value) plant_Record.PR_Count = Convert.ToInt32(dr["PR_Count"]);
            if (dr["PR_Price"] != DBNull.Value) plant_Record.PR_Price = Convert.ToDecimal(dr["PR_Price"]);
            if (dr["PR_Amount"] != DBNull.Value) plant_Record.PR_Amount = Convert.ToDecimal(dr["PR_Amount"]);
            if (dr["PR_Date"] != DBNull.Value) plant_Record.PR_Date = Convert.ToDateTime(dr["PR_Date"]);
            if (dr["Stat"] != DBNull.Value) plant_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plant_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plant_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plant_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(plant_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
