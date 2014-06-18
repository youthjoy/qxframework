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
   /// 供应商评分
   /// </summary>
   [Serializable]
   public partial class ADOWH_CEItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加供应商评分 WH_CEItem对象(即:一条记录)
      /// </summary>
      public int Add(WH_CEItem wH_CEItem)
      {
         string sql = "INSERT INTO WH_CEItem (CEI_Code,CEI_CustCode,CEI_Key,CEI_Name,CEI_Value,CEI_Content,CEI_Stuff,CEI_Dept,CEI_Date,Stat,CEI_Order,CreateDate,UpdateDate,DeleteDate) VALUES (@CEI_Code,@CEI_CustCode,@CEI_Key,@CEI_Name,@CEI_Value,@CEI_Content,@CEI_Stuff,@CEI_Dept,@CEI_Date,@Stat,@CEI_Order,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Code))
         {
            idb.AddParameter("@CEI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Code", wH_CEItem.CEI_Code);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_CustCode))
         {
            idb.AddParameter("@CEI_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_CustCode", wH_CEItem.CEI_CustCode);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Key))
         {
            idb.AddParameter("@CEI_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Key", wH_CEItem.CEI_Key);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Name))
         {
            idb.AddParameter("@CEI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Name", wH_CEItem.CEI_Name);
         }
         if (wH_CEItem.CEI_Value == 0)
         {
            idb.AddParameter("@CEI_Value", 0);
         }
         else
         {
            idb.AddParameter("@CEI_Value", wH_CEItem.CEI_Value);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Content))
         {
            idb.AddParameter("@CEI_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Content", wH_CEItem.CEI_Content);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Stuff))
         {
            idb.AddParameter("@CEI_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Stuff", wH_CEItem.CEI_Stuff);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Dept))
         {
            idb.AddParameter("@CEI_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Dept", wH_CEItem.CEI_Dept);
         }
         if (wH_CEItem.CEI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CEI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Date", wH_CEItem.CEI_Date);
         }
         if (wH_CEItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CEItem.Stat);
         }
         if (wH_CEItem.CEI_Order == 0)
         {
            idb.AddParameter("@CEI_Order", 0);
         }
         else
         {
            idb.AddParameter("@CEI_Order", wH_CEItem.CEI_Order);
         }
         if (wH_CEItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_CEItem.CreateDate);
         }
         if (wH_CEItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_CEItem.UpdateDate);
         }
         if (wH_CEItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_CEItem.DeleteDate);
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
      /// 添加供应商评分 WH_CEItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_CEItem wH_CEItem)
      {
         string sql = "INSERT INTO WH_CEItem (CEI_Code,CEI_CustCode,CEI_Key,CEI_Name,CEI_Value,CEI_Content,CEI_Stuff,CEI_Dept,CEI_Date,Stat,CEI_Order,CreateDate,UpdateDate,DeleteDate) VALUES (@CEI_Code,@CEI_CustCode,@CEI_Key,@CEI_Name,@CEI_Value,@CEI_Content,@CEI_Stuff,@CEI_Dept,@CEI_Date,@Stat,@CEI_Order,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Code))
         {
            idb.AddParameter("@CEI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Code", wH_CEItem.CEI_Code);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_CustCode))
         {
            idb.AddParameter("@CEI_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_CustCode", wH_CEItem.CEI_CustCode);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Key))
         {
            idb.AddParameter("@CEI_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Key", wH_CEItem.CEI_Key);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Name))
         {
            idb.AddParameter("@CEI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Name", wH_CEItem.CEI_Name);
         }
         if (wH_CEItem.CEI_Value == 0)
         {
            idb.AddParameter("@CEI_Value", 0);
         }
         else
         {
            idb.AddParameter("@CEI_Value", wH_CEItem.CEI_Value);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Content))
         {
            idb.AddParameter("@CEI_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Content", wH_CEItem.CEI_Content);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Stuff))
         {
            idb.AddParameter("@CEI_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Stuff", wH_CEItem.CEI_Stuff);
         }
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Dept))
         {
            idb.AddParameter("@CEI_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Dept", wH_CEItem.CEI_Dept);
         }
         if (wH_CEItem.CEI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CEI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Date", wH_CEItem.CEI_Date);
         }
         if (wH_CEItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CEItem.Stat);
         }
         if (wH_CEItem.CEI_Order == 0)
         {
            idb.AddParameter("@CEI_Order", 0);
         }
         else
         {
            idb.AddParameter("@CEI_Order", wH_CEItem.CEI_Order);
         }
         if (wH_CEItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_CEItem.CreateDate);
         }
         if (wH_CEItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_CEItem.UpdateDate);
         }
         if (wH_CEItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_CEItem.DeleteDate);
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
      /// 更新供应商评分 WH_CEItem对象(即:一条记录
      /// </summary>
      public int Update(WH_CEItem wH_CEItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_CEItem       SET ");
            if(wH_CEItem.CEI_Code_IsChanged){sbParameter.Append("CEI_Code=@CEI_Code, ");}
      if(wH_CEItem.CEI_CustCode_IsChanged){sbParameter.Append("CEI_CustCode=@CEI_CustCode, ");}
      if(wH_CEItem.CEI_Key_IsChanged){sbParameter.Append("CEI_Key=@CEI_Key, ");}
      if(wH_CEItem.CEI_Name_IsChanged){sbParameter.Append("CEI_Name=@CEI_Name, ");}
      if(wH_CEItem.CEI_Value_IsChanged){sbParameter.Append("CEI_Value=@CEI_Value, ");}
      if(wH_CEItem.CEI_Content_IsChanged){sbParameter.Append("CEI_Content=@CEI_Content, ");}
      if(wH_CEItem.CEI_Stuff_IsChanged){sbParameter.Append("CEI_Stuff=@CEI_Stuff, ");}
      if(wH_CEItem.CEI_Dept_IsChanged){sbParameter.Append("CEI_Dept=@CEI_Dept, ");}
      if(wH_CEItem.CEI_Date_IsChanged){sbParameter.Append("CEI_Date=@CEI_Date, ");}
      if(wH_CEItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_CEItem.CEI_Order_IsChanged){sbParameter.Append("CEI_Order=@CEI_Order, ");}
      if(wH_CEItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_CEItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_CEItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CEI_ID=@CEI_ID; " );
      string sql=sb.ToString();
         if(wH_CEItem.CEI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Code))
         {
            idb.AddParameter("@CEI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Code", wH_CEItem.CEI_Code);
         }
          }
         if(wH_CEItem.CEI_CustCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CEItem.CEI_CustCode))
         {
            idb.AddParameter("@CEI_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_CustCode", wH_CEItem.CEI_CustCode);
         }
          }
         if(wH_CEItem.CEI_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Key))
         {
            idb.AddParameter("@CEI_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Key", wH_CEItem.CEI_Key);
         }
          }
         if(wH_CEItem.CEI_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Name))
         {
            idb.AddParameter("@CEI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Name", wH_CEItem.CEI_Name);
         }
          }
         if(wH_CEItem.CEI_Value_IsChanged)
         {
         if (wH_CEItem.CEI_Value == 0)
         {
            idb.AddParameter("@CEI_Value", 0);
         }
         else
         {
            idb.AddParameter("@CEI_Value", wH_CEItem.CEI_Value);
         }
          }
         if(wH_CEItem.CEI_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Content))
         {
            idb.AddParameter("@CEI_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Content", wH_CEItem.CEI_Content);
         }
          }
         if(wH_CEItem.CEI_Stuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Stuff))
         {
            idb.AddParameter("@CEI_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Stuff", wH_CEItem.CEI_Stuff);
         }
          }
         if(wH_CEItem.CEI_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CEItem.CEI_Dept))
         {
            idb.AddParameter("@CEI_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Dept", wH_CEItem.CEI_Dept);
         }
          }
         if(wH_CEItem.CEI_Date_IsChanged)
         {
         if (wH_CEItem.CEI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CEI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CEI_Date", wH_CEItem.CEI_Date);
         }
          }
         if(wH_CEItem.Stat_IsChanged)
         {
         if (wH_CEItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CEItem.Stat);
         }
          }
         if(wH_CEItem.CEI_Order_IsChanged)
         {
         if (wH_CEItem.CEI_Order == 0)
         {
            idb.AddParameter("@CEI_Order", 0);
         }
         else
         {
            idb.AddParameter("@CEI_Order", wH_CEItem.CEI_Order);
         }
          }
         if(wH_CEItem.CreateDate_IsChanged)
         {
         if (wH_CEItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_CEItem.CreateDate);
         }
          }
         if(wH_CEItem.UpdateDate_IsChanged)
         {
         if (wH_CEItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_CEItem.UpdateDate);
         }
          }
         if(wH_CEItem.DeleteDate_IsChanged)
         {
         if (wH_CEItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_CEItem.DeleteDate);
         }
          }

         idb.AddParameter("@CEI_ID", wH_CEItem.CEI_ID);

           
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
      /// 删除供应商评分 WH_CEItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal cEI_ID)
      {
         string sql = "DELETE WH_CEItem WHERE 1=1  AND CEI_ID=@CEI_ID ";
         idb.AddParameter("@CEI_ID", cEI_ID);

           
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
      /// 获取指定的供应商评分 WH_CEItem对象(即:一条记录
      /// </summary>
      public WH_CEItem GetByKey(decimal cEI_ID)
      {
         WH_CEItem wH_CEItem = new WH_CEItem();
         string sql = "SELECT  CEI_ID,CEI_Code,CEI_CustCode,CEI_Key,CEI_Name,CEI_Value,CEI_Content,CEI_Stuff,CEI_Dept,CEI_Date,Stat,CEI_Order,CreateDate,UpdateDate,DeleteDate FROM WH_CEItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CEI_ID=@CEI_ID ";
         idb.AddParameter("@CEI_ID", cEI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CEI_ID"] != DBNull.Value) wH_CEItem.CEI_ID = Convert.ToDecimal(dr["CEI_ID"]);
            if (dr["CEI_Code"] != DBNull.Value) wH_CEItem.CEI_Code = Convert.ToString(dr["CEI_Code"]);
            if (dr["CEI_CustCode"] != DBNull.Value) wH_CEItem.CEI_CustCode = Convert.ToString(dr["CEI_CustCode"]);
            if (dr["CEI_Key"] != DBNull.Value) wH_CEItem.CEI_Key = Convert.ToString(dr["CEI_Key"]);
            if (dr["CEI_Name"] != DBNull.Value) wH_CEItem.CEI_Name = Convert.ToString(dr["CEI_Name"]);
            if (dr["CEI_Value"] != DBNull.Value) wH_CEItem.CEI_Value = Convert.ToInt32(dr["CEI_Value"]);
            if (dr["CEI_Content"] != DBNull.Value) wH_CEItem.CEI_Content = Convert.ToString(dr["CEI_Content"]);
            if (dr["CEI_Stuff"] != DBNull.Value) wH_CEItem.CEI_Stuff = Convert.ToString(dr["CEI_Stuff"]);
            if (dr["CEI_Dept"] != DBNull.Value) wH_CEItem.CEI_Dept = Convert.ToString(dr["CEI_Dept"]);
            if (dr["CEI_Date"] != DBNull.Value) wH_CEItem.CEI_Date = Convert.ToDateTime(dr["CEI_Date"]);
            if (dr["Stat"] != DBNull.Value) wH_CEItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CEI_Order"] != DBNull.Value) wH_CEItem.CEI_Order = Convert.ToInt32(dr["CEI_Order"]);
            if (dr["CreateDate"] != DBNull.Value) wH_CEItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_CEItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_CEItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_CEItem;
      }
      /// <summary>
      /// 获取指定的供应商评分 WH_CEItem对象集合
      /// </summary>
      public List<WH_CEItem> GetListByWhere(string strCondition)
      {
         List<WH_CEItem> ret = new List<WH_CEItem>();
         string sql = "SELECT  CEI_ID,CEI_Code,CEI_CustCode,CEI_Key,CEI_Name,CEI_Value,CEI_Content,CEI_Stuff,CEI_Dept,CEI_Date,Stat,CEI_Order,CreateDate,UpdateDate,DeleteDate FROM WH_CEItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_CEItem wH_CEItem = new WH_CEItem();
            if (dr["CEI_ID"] != DBNull.Value) wH_CEItem.CEI_ID = Convert.ToDecimal(dr["CEI_ID"]);
            if (dr["CEI_Code"] != DBNull.Value) wH_CEItem.CEI_Code = Convert.ToString(dr["CEI_Code"]);
            if (dr["CEI_CustCode"] != DBNull.Value) wH_CEItem.CEI_CustCode = Convert.ToString(dr["CEI_CustCode"]);
            if (dr["CEI_Key"] != DBNull.Value) wH_CEItem.CEI_Key = Convert.ToString(dr["CEI_Key"]);
            if (dr["CEI_Name"] != DBNull.Value) wH_CEItem.CEI_Name = Convert.ToString(dr["CEI_Name"]);
            if (dr["CEI_Value"] != DBNull.Value) wH_CEItem.CEI_Value = Convert.ToInt32(dr["CEI_Value"]);
            if (dr["CEI_Content"] != DBNull.Value) wH_CEItem.CEI_Content = Convert.ToString(dr["CEI_Content"]);
            if (dr["CEI_Stuff"] != DBNull.Value) wH_CEItem.CEI_Stuff = Convert.ToString(dr["CEI_Stuff"]);
            if (dr["CEI_Dept"] != DBNull.Value) wH_CEItem.CEI_Dept = Convert.ToString(dr["CEI_Dept"]);
            if (dr["CEI_Date"] != DBNull.Value) wH_CEItem.CEI_Date = Convert.ToDateTime(dr["CEI_Date"]);
            if (dr["Stat"] != DBNull.Value) wH_CEItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CEI_Order"] != DBNull.Value) wH_CEItem.CEI_Order = Convert.ToInt32(dr["CEI_Order"]);
            if (dr["CreateDate"] != DBNull.Value) wH_CEItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_CEItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_CEItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_CEItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的供应商评分 WH_CEItem对象(即:一条记录
      /// </summary>
      public List<WH_CEItem> GetAll()
      {
         List<WH_CEItem> ret = new List<WH_CEItem>();
         string sql = "SELECT  CEI_ID,CEI_Code,CEI_CustCode,CEI_Key,CEI_Name,CEI_Value,CEI_Content,CEI_Stuff,CEI_Dept,CEI_Date,Stat,CEI_Order,CreateDate,UpdateDate,DeleteDate FROM WH_CEItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by CEI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_CEItem wH_CEItem = new WH_CEItem();
            if (dr["CEI_ID"] != DBNull.Value) wH_CEItem.CEI_ID = Convert.ToDecimal(dr["CEI_ID"]);
            if (dr["CEI_Code"] != DBNull.Value) wH_CEItem.CEI_Code = Convert.ToString(dr["CEI_Code"]);
            if (dr["CEI_CustCode"] != DBNull.Value) wH_CEItem.CEI_CustCode = Convert.ToString(dr["CEI_CustCode"]);
            if (dr["CEI_Key"] != DBNull.Value) wH_CEItem.CEI_Key = Convert.ToString(dr["CEI_Key"]);
            if (dr["CEI_Name"] != DBNull.Value) wH_CEItem.CEI_Name = Convert.ToString(dr["CEI_Name"]);
            if (dr["CEI_Value"] != DBNull.Value) wH_CEItem.CEI_Value = Convert.ToInt32(dr["CEI_Value"]);
            if (dr["CEI_Content"] != DBNull.Value) wH_CEItem.CEI_Content = Convert.ToString(dr["CEI_Content"]);
            if (dr["CEI_Stuff"] != DBNull.Value) wH_CEItem.CEI_Stuff = Convert.ToString(dr["CEI_Stuff"]);
            if (dr["CEI_Dept"] != DBNull.Value) wH_CEItem.CEI_Dept = Convert.ToString(dr["CEI_Dept"]);
            if (dr["CEI_Date"] != DBNull.Value) wH_CEItem.CEI_Date = Convert.ToDateTime(dr["CEI_Date"]);
            if (dr["Stat"] != DBNull.Value) wH_CEItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CEI_Order"] != DBNull.Value) wH_CEItem.CEI_Order = Convert.ToInt32(dr["CEI_Order"]);
            if (dr["CreateDate"] != DBNull.Value) wH_CEItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_CEItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_CEItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_CEItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
