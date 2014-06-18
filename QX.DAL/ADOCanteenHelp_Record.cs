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
   /// 食堂贴补记录
   /// </summary>
   [Serializable]
   public partial class ADOCanteenHelp_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加食堂贴补记录 CanteenHelp_Record对象(即:一条记录)
      /// </summary>
      public int Add(CanteenHelp_Record canteenHelp_Record)
      {
         string sql = "INSERT INTO CanteenHelp_Record (CHR_Code,CHR_CanteenItemCode,CHR_Item,CHR_Standard,CHR_Cost,CHR_Date,CHR_Period,CHR_Company,CHR_Dept,CHR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CHR_Code,@CHR_CanteenItemCode,@CHR_Item,@CHR_Standard,@CHR_Cost,@CHR_Date,@CHR_Period,@CHR_Company,@CHR_Dept,@CHR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Code))
         {
            idb.AddParameter("@CHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Code", canteenHelp_Record.CHR_Code);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_CanteenItemCode))
         {
            idb.AddParameter("@CHR_CanteenItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_CanteenItemCode", canteenHelp_Record.CHR_CanteenItemCode);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Item))
         {
            idb.AddParameter("@CHR_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Item", canteenHelp_Record.CHR_Item);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Standard))
         {
            idb.AddParameter("@CHR_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Standard", canteenHelp_Record.CHR_Standard);
         }
         if (canteenHelp_Record.CHR_Cost == 0)
         {
            idb.AddParameter("@CHR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@CHR_Cost", canteenHelp_Record.CHR_Cost);
         }
         if (canteenHelp_Record.CHR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CHR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Date", canteenHelp_Record.CHR_Date);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Period))
         {
            idb.AddParameter("@CHR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Period", canteenHelp_Record.CHR_Period);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Company))
         {
            idb.AddParameter("@CHR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Company", canteenHelp_Record.CHR_Company);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Dept))
         {
            idb.AddParameter("@CHR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Dept", canteenHelp_Record.CHR_Dept);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Remark))
         {
            idb.AddParameter("@CHR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Remark", canteenHelp_Record.CHR_Remark);
         }
         if (canteenHelp_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", canteenHelp_Record.Stat);
         }
         if (canteenHelp_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", canteenHelp_Record.CreateDate);
         }
         if (canteenHelp_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", canteenHelp_Record.UpdateDate);
         }
         if (canteenHelp_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", canteenHelp_Record.DeleteDate);
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
      /// 添加食堂贴补记录 CanteenHelp_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(CanteenHelp_Record canteenHelp_Record)
      {
         string sql = "INSERT INTO CanteenHelp_Record (CHR_Code,CHR_CanteenItemCode,CHR_Item,CHR_Standard,CHR_Cost,CHR_Date,CHR_Period,CHR_Company,CHR_Dept,CHR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CHR_Code,@CHR_CanteenItemCode,@CHR_Item,@CHR_Standard,@CHR_Cost,@CHR_Date,@CHR_Period,@CHR_Company,@CHR_Dept,@CHR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Code))
         {
            idb.AddParameter("@CHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Code", canteenHelp_Record.CHR_Code);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_CanteenItemCode))
         {
            idb.AddParameter("@CHR_CanteenItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_CanteenItemCode", canteenHelp_Record.CHR_CanteenItemCode);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Item))
         {
            idb.AddParameter("@CHR_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Item", canteenHelp_Record.CHR_Item);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Standard))
         {
            idb.AddParameter("@CHR_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Standard", canteenHelp_Record.CHR_Standard);
         }
         if (canteenHelp_Record.CHR_Cost == 0)
         {
            idb.AddParameter("@CHR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@CHR_Cost", canteenHelp_Record.CHR_Cost);
         }
         if (canteenHelp_Record.CHR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CHR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Date", canteenHelp_Record.CHR_Date);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Period))
         {
            idb.AddParameter("@CHR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Period", canteenHelp_Record.CHR_Period);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Company))
         {
            idb.AddParameter("@CHR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Company", canteenHelp_Record.CHR_Company);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Dept))
         {
            idb.AddParameter("@CHR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Dept", canteenHelp_Record.CHR_Dept);
         }
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Remark))
         {
            idb.AddParameter("@CHR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Remark", canteenHelp_Record.CHR_Remark);
         }
         if (canteenHelp_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", canteenHelp_Record.Stat);
         }
         if (canteenHelp_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", canteenHelp_Record.CreateDate);
         }
         if (canteenHelp_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", canteenHelp_Record.UpdateDate);
         }
         if (canteenHelp_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", canteenHelp_Record.DeleteDate);
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
      /// 更新食堂贴补记录 CanteenHelp_Record对象(即:一条记录
      /// </summary>
      public int Update(CanteenHelp_Record canteenHelp_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       CanteenHelp_Record       SET ");
            if(canteenHelp_Record.CHR_Code_IsChanged){sbParameter.Append("CHR_Code=@CHR_Code, ");}
      if(canteenHelp_Record.CHR_CanteenItemCode_IsChanged){sbParameter.Append("CHR_CanteenItemCode=@CHR_CanteenItemCode, ");}
      if(canteenHelp_Record.CHR_Item_IsChanged){sbParameter.Append("CHR_Item=@CHR_Item, ");}
      if(canteenHelp_Record.CHR_Standard_IsChanged){sbParameter.Append("CHR_Standard=@CHR_Standard, ");}
      if(canteenHelp_Record.CHR_Cost_IsChanged){sbParameter.Append("CHR_Cost=@CHR_Cost, ");}
      if(canteenHelp_Record.CHR_Date_IsChanged){sbParameter.Append("CHR_Date=@CHR_Date, ");}
      if(canteenHelp_Record.CHR_Period_IsChanged){sbParameter.Append("CHR_Period=@CHR_Period, ");}
      if(canteenHelp_Record.CHR_Company_IsChanged){sbParameter.Append("CHR_Company=@CHR_Company, ");}
      if(canteenHelp_Record.CHR_Dept_IsChanged){sbParameter.Append("CHR_Dept=@CHR_Dept, ");}
      if(canteenHelp_Record.CHR_Remark_IsChanged){sbParameter.Append("CHR_Remark=@CHR_Remark, ");}
      if(canteenHelp_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(canteenHelp_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(canteenHelp_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(canteenHelp_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CHR_ID=@CHR_ID; " );
      string sql=sb.ToString();
         if(canteenHelp_Record.CHR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Code))
         {
            idb.AddParameter("@CHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Code", canteenHelp_Record.CHR_Code);
         }
          }
         if(canteenHelp_Record.CHR_CanteenItemCode_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_CanteenItemCode))
         {
            idb.AddParameter("@CHR_CanteenItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_CanteenItemCode", canteenHelp_Record.CHR_CanteenItemCode);
         }
          }
         if(canteenHelp_Record.CHR_Item_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Item))
         {
            idb.AddParameter("@CHR_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Item", canteenHelp_Record.CHR_Item);
         }
          }
         if(canteenHelp_Record.CHR_Standard_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Standard))
         {
            idb.AddParameter("@CHR_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Standard", canteenHelp_Record.CHR_Standard);
         }
          }
         if(canteenHelp_Record.CHR_Cost_IsChanged)
         {
         if (canteenHelp_Record.CHR_Cost == 0)
         {
            idb.AddParameter("@CHR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@CHR_Cost", canteenHelp_Record.CHR_Cost);
         }
          }
         if(canteenHelp_Record.CHR_Date_IsChanged)
         {
         if (canteenHelp_Record.CHR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CHR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Date", canteenHelp_Record.CHR_Date);
         }
          }
         if(canteenHelp_Record.CHR_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Period))
         {
            idb.AddParameter("@CHR_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Period", canteenHelp_Record.CHR_Period);
         }
          }
         if(canteenHelp_Record.CHR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Company))
         {
            idb.AddParameter("@CHR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Company", canteenHelp_Record.CHR_Company);
         }
          }
         if(canteenHelp_Record.CHR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Dept))
         {
            idb.AddParameter("@CHR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Dept", canteenHelp_Record.CHR_Dept);
         }
          }
         if(canteenHelp_Record.CHR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenHelp_Record.CHR_Remark))
         {
            idb.AddParameter("@CHR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CHR_Remark", canteenHelp_Record.CHR_Remark);
         }
          }
         if(canteenHelp_Record.Stat_IsChanged)
         {
         if (canteenHelp_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", canteenHelp_Record.Stat);
         }
          }
         if(canteenHelp_Record.CreateDate_IsChanged)
         {
         if (canteenHelp_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", canteenHelp_Record.CreateDate);
         }
          }
         if(canteenHelp_Record.UpdateDate_IsChanged)
         {
         if (canteenHelp_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", canteenHelp_Record.UpdateDate);
         }
          }
         if(canteenHelp_Record.DeleteDate_IsChanged)
         {
         if (canteenHelp_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", canteenHelp_Record.DeleteDate);
         }
          }

         idb.AddParameter("@CHR_ID", canteenHelp_Record.CHR_ID);

           
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
      /// 删除食堂贴补记录 CanteenHelp_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal cHR_ID)
      {
         string sql = "DELETE CanteenHelp_Record WHERE 1=1  AND CHR_ID=@CHR_ID ";
         idb.AddParameter("@CHR_ID", cHR_ID);

           
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
      /// 获取指定的食堂贴补记录 CanteenHelp_Record对象(即:一条记录
      /// </summary>
      public CanteenHelp_Record GetByKey(decimal cHR_ID)
      {
         CanteenHelp_Record canteenHelp_Record = new CanteenHelp_Record();
         string sql = "SELECT  CHR_ID,CHR_Code,CHR_CanteenItemCode,CHR_Item,CHR_Standard,CHR_Cost,CHR_Date,CHR_Period,CHR_Company,CHR_Dept,CHR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM CanteenHelp_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CHR_ID=@CHR_ID ";
         idb.AddParameter("@CHR_ID", cHR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CHR_ID"] != DBNull.Value) canteenHelp_Record.CHR_ID = Convert.ToDecimal(dr["CHR_ID"]);
            if (dr["CHR_Code"] != DBNull.Value) canteenHelp_Record.CHR_Code = Convert.ToString(dr["CHR_Code"]);
            if (dr["CHR_CanteenItemCode"] != DBNull.Value) canteenHelp_Record.CHR_CanteenItemCode = Convert.ToString(dr["CHR_CanteenItemCode"]);
            if (dr["CHR_Item"] != DBNull.Value) canteenHelp_Record.CHR_Item = Convert.ToString(dr["CHR_Item"]);
            if (dr["CHR_Standard"] != DBNull.Value) canteenHelp_Record.CHR_Standard = Convert.ToString(dr["CHR_Standard"]);
            if (dr["CHR_Cost"] != DBNull.Value) canteenHelp_Record.CHR_Cost = Convert.ToDecimal(dr["CHR_Cost"]);
            if (dr["CHR_Date"] != DBNull.Value) canteenHelp_Record.CHR_Date = Convert.ToDateTime(dr["CHR_Date"]);
            if (dr["CHR_Period"] != DBNull.Value) canteenHelp_Record.CHR_Period = Convert.ToString(dr["CHR_Period"]);
            if (dr["CHR_Company"] != DBNull.Value) canteenHelp_Record.CHR_Company = Convert.ToString(dr["CHR_Company"]);
            if (dr["CHR_Dept"] != DBNull.Value) canteenHelp_Record.CHR_Dept = Convert.ToString(dr["CHR_Dept"]);
            if (dr["CHR_Remark"] != DBNull.Value) canteenHelp_Record.CHR_Remark = Convert.ToString(dr["CHR_Remark"]);
            if (dr["Stat"] != DBNull.Value) canteenHelp_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) canteenHelp_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) canteenHelp_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) canteenHelp_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return canteenHelp_Record;
      }
      /// <summary>
      /// 获取指定的食堂贴补记录 CanteenHelp_Record对象集合
      /// </summary>
      public List<CanteenHelp_Record> GetListByWhere(string strCondition)
      {
         List<CanteenHelp_Record> ret = new List<CanteenHelp_Record>();
         string sql = "SELECT  CHR_ID,CHR_Code,CHR_CanteenItemCode,CHR_Item,CHR_Standard,CHR_Cost,CHR_Date,CHR_Period,CHR_Company,CHR_Dept,CHR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM CanteenHelp_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            CanteenHelp_Record canteenHelp_Record = new CanteenHelp_Record();
            if (dr["CHR_ID"] != DBNull.Value) canteenHelp_Record.CHR_ID = Convert.ToDecimal(dr["CHR_ID"]);
            if (dr["CHR_Code"] != DBNull.Value) canteenHelp_Record.CHR_Code = Convert.ToString(dr["CHR_Code"]);
            if (dr["CHR_CanteenItemCode"] != DBNull.Value) canteenHelp_Record.CHR_CanteenItemCode = Convert.ToString(dr["CHR_CanteenItemCode"]);
            if (dr["CHR_Item"] != DBNull.Value) canteenHelp_Record.CHR_Item = Convert.ToString(dr["CHR_Item"]);
            if (dr["CHR_Standard"] != DBNull.Value) canteenHelp_Record.CHR_Standard = Convert.ToString(dr["CHR_Standard"]);
            if (dr["CHR_Cost"] != DBNull.Value) canteenHelp_Record.CHR_Cost = Convert.ToDecimal(dr["CHR_Cost"]);
            if (dr["CHR_Date"] != DBNull.Value) canteenHelp_Record.CHR_Date = Convert.ToDateTime(dr["CHR_Date"]);
            if (dr["CHR_Period"] != DBNull.Value) canteenHelp_Record.CHR_Period = Convert.ToString(dr["CHR_Period"]);
            if (dr["CHR_Company"] != DBNull.Value) canteenHelp_Record.CHR_Company = Convert.ToString(dr["CHR_Company"]);
            if (dr["CHR_Dept"] != DBNull.Value) canteenHelp_Record.CHR_Dept = Convert.ToString(dr["CHR_Dept"]);
            if (dr["CHR_Remark"] != DBNull.Value) canteenHelp_Record.CHR_Remark = Convert.ToString(dr["CHR_Remark"]);
            if (dr["Stat"] != DBNull.Value) canteenHelp_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) canteenHelp_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) canteenHelp_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) canteenHelp_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(canteenHelp_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的食堂贴补记录 CanteenHelp_Record对象(即:一条记录
      /// </summary>
      public List<CanteenHelp_Record> GetAll()
      {
         List<CanteenHelp_Record> ret = new List<CanteenHelp_Record>();
         string sql = "SELECT  CHR_ID,CHR_Code,CHR_CanteenItemCode,CHR_Item,CHR_Standard,CHR_Cost,CHR_Date,CHR_Period,CHR_Company,CHR_Dept,CHR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM CanteenHelp_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by CHR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            CanteenHelp_Record canteenHelp_Record = new CanteenHelp_Record();
            if (dr["CHR_ID"] != DBNull.Value) canteenHelp_Record.CHR_ID = Convert.ToDecimal(dr["CHR_ID"]);
            if (dr["CHR_Code"] != DBNull.Value) canteenHelp_Record.CHR_Code = Convert.ToString(dr["CHR_Code"]);
            if (dr["CHR_CanteenItemCode"] != DBNull.Value) canteenHelp_Record.CHR_CanteenItemCode = Convert.ToString(dr["CHR_CanteenItemCode"]);
            if (dr["CHR_Item"] != DBNull.Value) canteenHelp_Record.CHR_Item = Convert.ToString(dr["CHR_Item"]);
            if (dr["CHR_Standard"] != DBNull.Value) canteenHelp_Record.CHR_Standard = Convert.ToString(dr["CHR_Standard"]);
            if (dr["CHR_Cost"] != DBNull.Value) canteenHelp_Record.CHR_Cost = Convert.ToDecimal(dr["CHR_Cost"]);
            if (dr["CHR_Date"] != DBNull.Value) canteenHelp_Record.CHR_Date = Convert.ToDateTime(dr["CHR_Date"]);
            if (dr["CHR_Period"] != DBNull.Value) canteenHelp_Record.CHR_Period = Convert.ToString(dr["CHR_Period"]);
            if (dr["CHR_Company"] != DBNull.Value) canteenHelp_Record.CHR_Company = Convert.ToString(dr["CHR_Company"]);
            if (dr["CHR_Dept"] != DBNull.Value) canteenHelp_Record.CHR_Dept = Convert.ToString(dr["CHR_Dept"]);
            if (dr["CHR_Remark"] != DBNull.Value) canteenHelp_Record.CHR_Remark = Convert.ToString(dr["CHR_Remark"]);
            if (dr["Stat"] != DBNull.Value) canteenHelp_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) canteenHelp_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) canteenHelp_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) canteenHelp_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(canteenHelp_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
