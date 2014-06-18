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
   /// 食堂物资记录
   /// </summary>
   [Serializable]
   public partial class ADOCanteenItem_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加食堂物资记录 CanteenItem_Record对象(即:一条记录)
      /// </summary>
      public int Add(CanteenItem_Record canteenItem_Record)
      {
         string sql = "INSERT INTO CanteenItem_Record (CIR_Code,CIR_Name,CIR_Model,CIR_CanteenItemCode,CIR_Date,CIR_Money,CIR_Remark,CIR_Company,CIR_Dept,CIR_Num,CIR_Price,CIR_Unit,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CIR_Code,@CIR_Name,@CIR_Model,@CIR_CanteenItemCode,@CIR_Date,@CIR_Money,@CIR_Remark,@CIR_Company,@CIR_Dept,@CIR_Num,@CIR_Price,@CIR_Unit,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Code))
         {
            idb.AddParameter("@CIR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Code", canteenItem_Record.CIR_Code);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Name))
         {
            idb.AddParameter("@CIR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Name", canteenItem_Record.CIR_Name);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Model))
         {
            idb.AddParameter("@CIR_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Model", canteenItem_Record.CIR_Model);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_CanteenItemCode))
         {
            idb.AddParameter("@CIR_CanteenItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_CanteenItemCode", canteenItem_Record.CIR_CanteenItemCode);
         }
         if (canteenItem_Record.CIR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CIR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Date", canteenItem_Record.CIR_Date);
         }
         if (canteenItem_Record.CIR_Money == 0)
         {
            idb.AddParameter("@CIR_Money", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Money", canteenItem_Record.CIR_Money);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Remark))
         {
            idb.AddParameter("@CIR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Remark", canteenItem_Record.CIR_Remark);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Company))
         {
            idb.AddParameter("@CIR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Company", canteenItem_Record.CIR_Company);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Dept))
         {
            idb.AddParameter("@CIR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Dept", canteenItem_Record.CIR_Dept);
         }
         if (canteenItem_Record.CIR_Num == 0)
         {
            idb.AddParameter("@CIR_Num", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Num", canteenItem_Record.CIR_Num);
         }
         if (canteenItem_Record.CIR_Price == 0)
         {
            idb.AddParameter("@CIR_Price", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Price", canteenItem_Record.CIR_Price);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Unit))
         {
            idb.AddParameter("@CIR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Unit", canteenItem_Record.CIR_Unit);
         }
         if (canteenItem_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", canteenItem_Record.Stat);
         }
         if (canteenItem_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", canteenItem_Record.CreateDate);
         }
         if (canteenItem_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", canteenItem_Record.UpdateDate);
         }
         if (canteenItem_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", canteenItem_Record.DeleteDate);
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
      /// 添加食堂物资记录 CanteenItem_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(CanteenItem_Record canteenItem_Record)
      {
         string sql = "INSERT INTO CanteenItem_Record (CIR_Code,CIR_Name,CIR_Model,CIR_CanteenItemCode,CIR_Date,CIR_Money,CIR_Remark,CIR_Company,CIR_Dept,CIR_Num,CIR_Price,CIR_Unit,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CIR_Code,@CIR_Name,@CIR_Model,@CIR_CanteenItemCode,@CIR_Date,@CIR_Money,@CIR_Remark,@CIR_Company,@CIR_Dept,@CIR_Num,@CIR_Price,@CIR_Unit,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Code))
         {
            idb.AddParameter("@CIR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Code", canteenItem_Record.CIR_Code);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Name))
         {
            idb.AddParameter("@CIR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Name", canteenItem_Record.CIR_Name);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Model))
         {
            idb.AddParameter("@CIR_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Model", canteenItem_Record.CIR_Model);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_CanteenItemCode))
         {
            idb.AddParameter("@CIR_CanteenItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_CanteenItemCode", canteenItem_Record.CIR_CanteenItemCode);
         }
         if (canteenItem_Record.CIR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CIR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Date", canteenItem_Record.CIR_Date);
         }
         if (canteenItem_Record.CIR_Money == 0)
         {
            idb.AddParameter("@CIR_Money", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Money", canteenItem_Record.CIR_Money);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Remark))
         {
            idb.AddParameter("@CIR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Remark", canteenItem_Record.CIR_Remark);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Company))
         {
            idb.AddParameter("@CIR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Company", canteenItem_Record.CIR_Company);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Dept))
         {
            idb.AddParameter("@CIR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Dept", canteenItem_Record.CIR_Dept);
         }
         if (canteenItem_Record.CIR_Num == 0)
         {
            idb.AddParameter("@CIR_Num", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Num", canteenItem_Record.CIR_Num);
         }
         if (canteenItem_Record.CIR_Price == 0)
         {
            idb.AddParameter("@CIR_Price", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Price", canteenItem_Record.CIR_Price);
         }
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Unit))
         {
            idb.AddParameter("@CIR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Unit", canteenItem_Record.CIR_Unit);
         }
         if (canteenItem_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", canteenItem_Record.Stat);
         }
         if (canteenItem_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", canteenItem_Record.CreateDate);
         }
         if (canteenItem_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", canteenItem_Record.UpdateDate);
         }
         if (canteenItem_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", canteenItem_Record.DeleteDate);
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
      /// 更新食堂物资记录 CanteenItem_Record对象(即:一条记录
      /// </summary>
      public int Update(CanteenItem_Record canteenItem_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       CanteenItem_Record       SET ");
            if(canteenItem_Record.CIR_Code_IsChanged){sbParameter.Append("CIR_Code=@CIR_Code, ");}
      if(canteenItem_Record.CIR_Name_IsChanged){sbParameter.Append("CIR_Name=@CIR_Name, ");}
      if(canteenItem_Record.CIR_Model_IsChanged){sbParameter.Append("CIR_Model=@CIR_Model, ");}
      if(canteenItem_Record.CIR_CanteenItemCode_IsChanged){sbParameter.Append("CIR_CanteenItemCode=@CIR_CanteenItemCode, ");}
      if(canteenItem_Record.CIR_Date_IsChanged){sbParameter.Append("CIR_Date=@CIR_Date, ");}
      if(canteenItem_Record.CIR_Money_IsChanged){sbParameter.Append("CIR_Money=@CIR_Money, ");}
      if(canteenItem_Record.CIR_Remark_IsChanged){sbParameter.Append("CIR_Remark=@CIR_Remark, ");}
      if(canteenItem_Record.CIR_Company_IsChanged){sbParameter.Append("CIR_Company=@CIR_Company, ");}
      if(canteenItem_Record.CIR_Dept_IsChanged){sbParameter.Append("CIR_Dept=@CIR_Dept, ");}
      if(canteenItem_Record.CIR_Num_IsChanged){sbParameter.Append("CIR_Num=@CIR_Num, ");}
      if(canteenItem_Record.CIR_Price_IsChanged){sbParameter.Append("CIR_Price=@CIR_Price, ");}
      if(canteenItem_Record.CIR_Unit_IsChanged){sbParameter.Append("CIR_Unit=@CIR_Unit, ");}
      if(canteenItem_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(canteenItem_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(canteenItem_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(canteenItem_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CIR_ID=@CIR_ID; " );
      string sql=sb.ToString();
         if(canteenItem_Record.CIR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Code))
         {
            idb.AddParameter("@CIR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Code", canteenItem_Record.CIR_Code);
         }
          }
         if(canteenItem_Record.CIR_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Name))
         {
            idb.AddParameter("@CIR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Name", canteenItem_Record.CIR_Name);
         }
          }
         if(canteenItem_Record.CIR_Model_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Model))
         {
            idb.AddParameter("@CIR_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Model", canteenItem_Record.CIR_Model);
         }
          }
         if(canteenItem_Record.CIR_CanteenItemCode_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_CanteenItemCode))
         {
            idb.AddParameter("@CIR_CanteenItemCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_CanteenItemCode", canteenItem_Record.CIR_CanteenItemCode);
         }
          }
         if(canteenItem_Record.CIR_Date_IsChanged)
         {
         if (canteenItem_Record.CIR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CIR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Date", canteenItem_Record.CIR_Date);
         }
          }
         if(canteenItem_Record.CIR_Money_IsChanged)
         {
         if (canteenItem_Record.CIR_Money == 0)
         {
            idb.AddParameter("@CIR_Money", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Money", canteenItem_Record.CIR_Money);
         }
          }
         if(canteenItem_Record.CIR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Remark))
         {
            idb.AddParameter("@CIR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Remark", canteenItem_Record.CIR_Remark);
         }
          }
         if(canteenItem_Record.CIR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Company))
         {
            idb.AddParameter("@CIR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Company", canteenItem_Record.CIR_Company);
         }
          }
         if(canteenItem_Record.CIR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Dept))
         {
            idb.AddParameter("@CIR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Dept", canteenItem_Record.CIR_Dept);
         }
          }
         if(canteenItem_Record.CIR_Num_IsChanged)
         {
         if (canteenItem_Record.CIR_Num == 0)
         {
            idb.AddParameter("@CIR_Num", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Num", canteenItem_Record.CIR_Num);
         }
          }
         if(canteenItem_Record.CIR_Price_IsChanged)
         {
         if (canteenItem_Record.CIR_Price == 0)
         {
            idb.AddParameter("@CIR_Price", 0);
         }
         else
         {
            idb.AddParameter("@CIR_Price", canteenItem_Record.CIR_Price);
         }
          }
         if(canteenItem_Record.CIR_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(canteenItem_Record.CIR_Unit))
         {
            idb.AddParameter("@CIR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CIR_Unit", canteenItem_Record.CIR_Unit);
         }
          }
         if(canteenItem_Record.Stat_IsChanged)
         {
         if (canteenItem_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", canteenItem_Record.Stat);
         }
          }
         if(canteenItem_Record.CreateDate_IsChanged)
         {
         if (canteenItem_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", canteenItem_Record.CreateDate);
         }
          }
         if(canteenItem_Record.UpdateDate_IsChanged)
         {
         if (canteenItem_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", canteenItem_Record.UpdateDate);
         }
          }
         if(canteenItem_Record.DeleteDate_IsChanged)
         {
         if (canteenItem_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", canteenItem_Record.DeleteDate);
         }
          }

         idb.AddParameter("@CIR_ID", canteenItem_Record.CIR_ID);

           
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
      /// 删除食堂物资记录 CanteenItem_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal cIR_ID)
      {
         string sql = "DELETE CanteenItem_Record WHERE 1=1  AND CIR_ID=@CIR_ID ";
         idb.AddParameter("@CIR_ID", cIR_ID);

           
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
      /// 获取指定的食堂物资记录 CanteenItem_Record对象(即:一条记录
      /// </summary>
      public CanteenItem_Record GetByKey(decimal cIR_ID)
      {
         CanteenItem_Record canteenItem_Record = new CanteenItem_Record();
         string sql = "SELECT  CIR_ID,CIR_Code,CIR_Name,CIR_Model,CIR_CanteenItemCode,CIR_Date,CIR_Money,CIR_Remark,CIR_Company,CIR_Dept,CIR_Num,CIR_Price,CIR_Unit,Stat,CreateDate,UpdateDate,DeleteDate FROM CanteenItem_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CIR_ID=@CIR_ID ";
         idb.AddParameter("@CIR_ID", cIR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CIR_ID"] != DBNull.Value) canteenItem_Record.CIR_ID = Convert.ToDecimal(dr["CIR_ID"]);
            if (dr["CIR_Code"] != DBNull.Value) canteenItem_Record.CIR_Code = Convert.ToString(dr["CIR_Code"]);
            if (dr["CIR_Name"] != DBNull.Value) canteenItem_Record.CIR_Name = Convert.ToString(dr["CIR_Name"]);
            if (dr["CIR_Model"] != DBNull.Value) canteenItem_Record.CIR_Model = Convert.ToString(dr["CIR_Model"]);
            if (dr["CIR_CanteenItemCode"] != DBNull.Value) canteenItem_Record.CIR_CanteenItemCode = Convert.ToString(dr["CIR_CanteenItemCode"]);
            if (dr["CIR_Date"] != DBNull.Value) canteenItem_Record.CIR_Date = Convert.ToDateTime(dr["CIR_Date"]);
            if (dr["CIR_Money"] != DBNull.Value) canteenItem_Record.CIR_Money = Convert.ToDecimal(dr["CIR_Money"]);
            if (dr["CIR_Remark"] != DBNull.Value) canteenItem_Record.CIR_Remark = Convert.ToString(dr["CIR_Remark"]);
            if (dr["CIR_Company"] != DBNull.Value) canteenItem_Record.CIR_Company = Convert.ToString(dr["CIR_Company"]);
            if (dr["CIR_Dept"] != DBNull.Value) canteenItem_Record.CIR_Dept = Convert.ToString(dr["CIR_Dept"]);
            if (dr["CIR_Num"] != DBNull.Value) canteenItem_Record.CIR_Num = Convert.ToDecimal(dr["CIR_Num"]);
            if (dr["CIR_Price"] != DBNull.Value) canteenItem_Record.CIR_Price = Convert.ToDecimal(dr["CIR_Price"]);
            if (dr["CIR_Unit"] != DBNull.Value) canteenItem_Record.CIR_Unit = Convert.ToString(dr["CIR_Unit"]);
            if (dr["Stat"] != DBNull.Value) canteenItem_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) canteenItem_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) canteenItem_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) canteenItem_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return canteenItem_Record;
      }
      /// <summary>
      /// 获取指定的食堂物资记录 CanteenItem_Record对象集合
      /// </summary>
      public List<CanteenItem_Record> GetListByWhere(string strCondition)
      {
         List<CanteenItem_Record> ret = new List<CanteenItem_Record>();
         string sql = "SELECT  CIR_ID,CIR_Code,CIR_Name,CIR_Model,CIR_CanteenItemCode,CIR_Date,CIR_Money,CIR_Remark,CIR_Company,CIR_Dept,CIR_Num,CIR_Price,CIR_Unit,Stat,CreateDate,UpdateDate,DeleteDate FROM CanteenItem_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            CanteenItem_Record canteenItem_Record = new CanteenItem_Record();
            if (dr["CIR_ID"] != DBNull.Value) canteenItem_Record.CIR_ID = Convert.ToDecimal(dr["CIR_ID"]);
            if (dr["CIR_Code"] != DBNull.Value) canteenItem_Record.CIR_Code = Convert.ToString(dr["CIR_Code"]);
            if (dr["CIR_Name"] != DBNull.Value) canteenItem_Record.CIR_Name = Convert.ToString(dr["CIR_Name"]);
            if (dr["CIR_Model"] != DBNull.Value) canteenItem_Record.CIR_Model = Convert.ToString(dr["CIR_Model"]);
            if (dr["CIR_CanteenItemCode"] != DBNull.Value) canteenItem_Record.CIR_CanteenItemCode = Convert.ToString(dr["CIR_CanteenItemCode"]);
            if (dr["CIR_Date"] != DBNull.Value) canteenItem_Record.CIR_Date = Convert.ToDateTime(dr["CIR_Date"]);
            if (dr["CIR_Money"] != DBNull.Value) canteenItem_Record.CIR_Money = Convert.ToDecimal(dr["CIR_Money"]);
            if (dr["CIR_Remark"] != DBNull.Value) canteenItem_Record.CIR_Remark = Convert.ToString(dr["CIR_Remark"]);
            if (dr["CIR_Company"] != DBNull.Value) canteenItem_Record.CIR_Company = Convert.ToString(dr["CIR_Company"]);
            if (dr["CIR_Dept"] != DBNull.Value) canteenItem_Record.CIR_Dept = Convert.ToString(dr["CIR_Dept"]);
            if (dr["CIR_Num"] != DBNull.Value) canteenItem_Record.CIR_Num = Convert.ToDecimal(dr["CIR_Num"]);
            if (dr["CIR_Price"] != DBNull.Value) canteenItem_Record.CIR_Price = Convert.ToDecimal(dr["CIR_Price"]);
            if (dr["CIR_Unit"] != DBNull.Value) canteenItem_Record.CIR_Unit = Convert.ToString(dr["CIR_Unit"]);
            if (dr["Stat"] != DBNull.Value) canteenItem_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) canteenItem_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) canteenItem_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) canteenItem_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(canteenItem_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的食堂物资记录 CanteenItem_Record对象(即:一条记录
      /// </summary>
      public List<CanteenItem_Record> GetAll()
      {
         List<CanteenItem_Record> ret = new List<CanteenItem_Record>();
         string sql = "SELECT  CIR_ID,CIR_Code,CIR_Name,CIR_Model,CIR_CanteenItemCode,CIR_Date,CIR_Money,CIR_Remark,CIR_Company,CIR_Dept,CIR_Num,CIR_Price,CIR_Unit,Stat,CreateDate,UpdateDate,DeleteDate FROM CanteenItem_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by CIR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            CanteenItem_Record canteenItem_Record = new CanteenItem_Record();
            if (dr["CIR_ID"] != DBNull.Value) canteenItem_Record.CIR_ID = Convert.ToDecimal(dr["CIR_ID"]);
            if (dr["CIR_Code"] != DBNull.Value) canteenItem_Record.CIR_Code = Convert.ToString(dr["CIR_Code"]);
            if (dr["CIR_Name"] != DBNull.Value) canteenItem_Record.CIR_Name = Convert.ToString(dr["CIR_Name"]);
            if (dr["CIR_Model"] != DBNull.Value) canteenItem_Record.CIR_Model = Convert.ToString(dr["CIR_Model"]);
            if (dr["CIR_CanteenItemCode"] != DBNull.Value) canteenItem_Record.CIR_CanteenItemCode = Convert.ToString(dr["CIR_CanteenItemCode"]);
            if (dr["CIR_Date"] != DBNull.Value) canteenItem_Record.CIR_Date = Convert.ToDateTime(dr["CIR_Date"]);
            if (dr["CIR_Money"] != DBNull.Value) canteenItem_Record.CIR_Money = Convert.ToDecimal(dr["CIR_Money"]);
            if (dr["CIR_Remark"] != DBNull.Value) canteenItem_Record.CIR_Remark = Convert.ToString(dr["CIR_Remark"]);
            if (dr["CIR_Company"] != DBNull.Value) canteenItem_Record.CIR_Company = Convert.ToString(dr["CIR_Company"]);
            if (dr["CIR_Dept"] != DBNull.Value) canteenItem_Record.CIR_Dept = Convert.ToString(dr["CIR_Dept"]);
            if (dr["CIR_Num"] != DBNull.Value) canteenItem_Record.CIR_Num = Convert.ToDecimal(dr["CIR_Num"]);
            if (dr["CIR_Price"] != DBNull.Value) canteenItem_Record.CIR_Price = Convert.ToDecimal(dr["CIR_Price"]);
            if (dr["CIR_Unit"] != DBNull.Value) canteenItem_Record.CIR_Unit = Convert.ToString(dr["CIR_Unit"]);
            if (dr["Stat"] != DBNull.Value) canteenItem_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) canteenItem_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) canteenItem_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) canteenItem_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(canteenItem_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
