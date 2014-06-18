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
   /// 客户回访
   /// </summary>
   [Serializable]
   public partial class ADOCustomer_Visit
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加客户回访 Customer_Visit对象(即:一条记录)
      /// </summary>
      public int Add(Customer_Visit customer_Visit)
      {
         string sql = "INSERT INTO Customer_Visit (CV_Code,CV_PJCode,CV_PJName,CV_PJType,CV_CCode,CV_CName,CV_Place,CV_Level,CV_Count,CV_SupDate,CV_CustAdvice,CV_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CV_Code,@CV_PJCode,@CV_PJName,@CV_PJType,@CV_CCode,@CV_CName,@CV_Place,@CV_Level,@CV_Count,@CV_SupDate,@CV_CustAdvice,@CV_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(customer_Visit.CV_Code))
         {
            idb.AddParameter("@CV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Code", customer_Visit.CV_Code);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_PJCode))
         {
            idb.AddParameter("@CV_PJCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJCode", customer_Visit.CV_PJCode);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_PJName))
         {
            idb.AddParameter("@CV_PJName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJName", customer_Visit.CV_PJName);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_PJType))
         {
            idb.AddParameter("@CV_PJType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJType", customer_Visit.CV_PJType);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_CCode))
         {
            idb.AddParameter("@CV_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CCode", customer_Visit.CV_CCode);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_CName))
         {
            idb.AddParameter("@CV_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CName", customer_Visit.CV_CName);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Place))
         {
            idb.AddParameter("@CV_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Place", customer_Visit.CV_Place);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Level))
         {
            idb.AddParameter("@CV_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Level", customer_Visit.CV_Level);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Count))
         {
            idb.AddParameter("@CV_Count", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Count", customer_Visit.CV_Count);
         }
         if (customer_Visit.CV_SupDate == DateTime.MinValue)
         {
            idb.AddParameter("@CV_SupDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_SupDate", customer_Visit.CV_SupDate);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_CustAdvice))
         {
            idb.AddParameter("@CV_CustAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CustAdvice", customer_Visit.CV_CustAdvice);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Remark))
         {
            idb.AddParameter("@CV_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Remark", customer_Visit.CV_Remark);
         }
         if (customer_Visit.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", customer_Visit.Stat);
         }
         if (customer_Visit.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", customer_Visit.CreateDate);
         }
         if (customer_Visit.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", customer_Visit.UpdateDate);
         }
         if (customer_Visit.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", customer_Visit.DeleteDate);
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
      /// 添加客户回访 Customer_Visit对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Customer_Visit customer_Visit)
      {
         string sql = "INSERT INTO Customer_Visit (CV_Code,CV_PJCode,CV_PJName,CV_PJType,CV_CCode,CV_CName,CV_Place,CV_Level,CV_Count,CV_SupDate,CV_CustAdvice,CV_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@CV_Code,@CV_PJCode,@CV_PJName,@CV_PJType,@CV_CCode,@CV_CName,@CV_Place,@CV_Level,@CV_Count,@CV_SupDate,@CV_CustAdvice,@CV_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(customer_Visit.CV_Code))
         {
            idb.AddParameter("@CV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Code", customer_Visit.CV_Code);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_PJCode))
         {
            idb.AddParameter("@CV_PJCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJCode", customer_Visit.CV_PJCode);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_PJName))
         {
            idb.AddParameter("@CV_PJName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJName", customer_Visit.CV_PJName);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_PJType))
         {
            idb.AddParameter("@CV_PJType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJType", customer_Visit.CV_PJType);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_CCode))
         {
            idb.AddParameter("@CV_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CCode", customer_Visit.CV_CCode);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_CName))
         {
            idb.AddParameter("@CV_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CName", customer_Visit.CV_CName);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Place))
         {
            idb.AddParameter("@CV_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Place", customer_Visit.CV_Place);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Level))
         {
            idb.AddParameter("@CV_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Level", customer_Visit.CV_Level);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Count))
         {
            idb.AddParameter("@CV_Count", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Count", customer_Visit.CV_Count);
         }
         if (customer_Visit.CV_SupDate == DateTime.MinValue)
         {
            idb.AddParameter("@CV_SupDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_SupDate", customer_Visit.CV_SupDate);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_CustAdvice))
         {
            idb.AddParameter("@CV_CustAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CustAdvice", customer_Visit.CV_CustAdvice);
         }
         if (string.IsNullOrEmpty(customer_Visit.CV_Remark))
         {
            idb.AddParameter("@CV_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Remark", customer_Visit.CV_Remark);
         }
         if (customer_Visit.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", customer_Visit.Stat);
         }
         if (customer_Visit.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", customer_Visit.CreateDate);
         }
         if (customer_Visit.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", customer_Visit.UpdateDate);
         }
         if (customer_Visit.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", customer_Visit.DeleteDate);
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
      /// 更新客户回访 Customer_Visit对象(即:一条记录
      /// </summary>
      public int Update(Customer_Visit customer_Visit)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Customer_Visit       SET ");
            if(customer_Visit.CV_Code_IsChanged){sbParameter.Append("CV_Code=@CV_Code, ");}
      if(customer_Visit.CV_PJCode_IsChanged){sbParameter.Append("CV_PJCode=@CV_PJCode, ");}
      if(customer_Visit.CV_PJName_IsChanged){sbParameter.Append("CV_PJName=@CV_PJName, ");}
      if(customer_Visit.CV_PJType_IsChanged){sbParameter.Append("CV_PJType=@CV_PJType, ");}
      if(customer_Visit.CV_CCode_IsChanged){sbParameter.Append("CV_CCode=@CV_CCode, ");}
      if(customer_Visit.CV_CName_IsChanged){sbParameter.Append("CV_CName=@CV_CName, ");}
      if(customer_Visit.CV_Place_IsChanged){sbParameter.Append("CV_Place=@CV_Place, ");}
      if(customer_Visit.CV_Level_IsChanged){sbParameter.Append("CV_Level=@CV_Level, ");}
      if(customer_Visit.CV_Count_IsChanged){sbParameter.Append("CV_Count=@CV_Count, ");}
      if(customer_Visit.CV_SupDate_IsChanged){sbParameter.Append("CV_SupDate=@CV_SupDate, ");}
      if(customer_Visit.CV_CustAdvice_IsChanged){sbParameter.Append("CV_CustAdvice=@CV_CustAdvice, ");}
      if(customer_Visit.CV_Remark_IsChanged){sbParameter.Append("CV_Remark=@CV_Remark, ");}
      if(customer_Visit.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(customer_Visit.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(customer_Visit.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(customer_Visit.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CV_ID=@CV_ID; " );
      string sql=sb.ToString();
         if(customer_Visit.CV_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_Code))
         {
            idb.AddParameter("@CV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Code", customer_Visit.CV_Code);
         }
          }
         if(customer_Visit.CV_PJCode_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_PJCode))
         {
            idb.AddParameter("@CV_PJCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJCode", customer_Visit.CV_PJCode);
         }
          }
         if(customer_Visit.CV_PJName_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_PJName))
         {
            idb.AddParameter("@CV_PJName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJName", customer_Visit.CV_PJName);
         }
          }
         if(customer_Visit.CV_PJType_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_PJType))
         {
            idb.AddParameter("@CV_PJType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_PJType", customer_Visit.CV_PJType);
         }
          }
         if(customer_Visit.CV_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_CCode))
         {
            idb.AddParameter("@CV_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CCode", customer_Visit.CV_CCode);
         }
          }
         if(customer_Visit.CV_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_CName))
         {
            idb.AddParameter("@CV_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CName", customer_Visit.CV_CName);
         }
          }
         if(customer_Visit.CV_Place_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_Place))
         {
            idb.AddParameter("@CV_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Place", customer_Visit.CV_Place);
         }
          }
         if(customer_Visit.CV_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_Level))
         {
            idb.AddParameter("@CV_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Level", customer_Visit.CV_Level);
         }
          }
         if(customer_Visit.CV_Count_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_Count))
         {
            idb.AddParameter("@CV_Count", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Count", customer_Visit.CV_Count);
         }
          }
         if(customer_Visit.CV_SupDate_IsChanged)
         {
         if (customer_Visit.CV_SupDate == DateTime.MinValue)
         {
            idb.AddParameter("@CV_SupDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_SupDate", customer_Visit.CV_SupDate);
         }
          }
         if(customer_Visit.CV_CustAdvice_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_CustAdvice))
         {
            idb.AddParameter("@CV_CustAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_CustAdvice", customer_Visit.CV_CustAdvice);
         }
          }
         if(customer_Visit.CV_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(customer_Visit.CV_Remark))
         {
            idb.AddParameter("@CV_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CV_Remark", customer_Visit.CV_Remark);
         }
          }
         if(customer_Visit.Stat_IsChanged)
         {
         if (customer_Visit.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", customer_Visit.Stat);
         }
          }
         if(customer_Visit.CreateDate_IsChanged)
         {
         if (customer_Visit.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", customer_Visit.CreateDate);
         }
          }
         if(customer_Visit.UpdateDate_IsChanged)
         {
         if (customer_Visit.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", customer_Visit.UpdateDate);
         }
          }
         if(customer_Visit.DeleteDate_IsChanged)
         {
         if (customer_Visit.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", customer_Visit.DeleteDate);
         }
          }

         idb.AddParameter("@CV_ID", customer_Visit.CV_ID);

           
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
      /// 删除客户回访 Customer_Visit对象(即:一条记录
      /// </summary>
      public int Delete(decimal cV_ID)
      {
         string sql = "DELETE Customer_Visit WHERE 1=1  AND CV_ID=@CV_ID ";
         idb.AddParameter("@CV_ID", cV_ID);

           
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
      /// 获取指定的客户回访 Customer_Visit对象(即:一条记录
      /// </summary>
      public Customer_Visit GetByKey(decimal cV_ID)
      {
         Customer_Visit customer_Visit = new Customer_Visit();
         string sql = "SELECT  CV_ID,CV_Code,CV_PJCode,CV_PJName,CV_PJType,CV_CCode,CV_CName,CV_Place,CV_Level,CV_Count,CV_SupDate,CV_CustAdvice,CV_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Customer_Visit WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CV_ID=@CV_ID ";
         idb.AddParameter("@CV_ID", cV_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CV_ID"] != DBNull.Value) customer_Visit.CV_ID = Convert.ToDecimal(dr["CV_ID"]);
            if (dr["CV_Code"] != DBNull.Value) customer_Visit.CV_Code = Convert.ToString(dr["CV_Code"]);
            if (dr["CV_PJCode"] != DBNull.Value) customer_Visit.CV_PJCode = Convert.ToString(dr["CV_PJCode"]);
            if (dr["CV_PJName"] != DBNull.Value) customer_Visit.CV_PJName = Convert.ToString(dr["CV_PJName"]);
            if (dr["CV_PJType"] != DBNull.Value) customer_Visit.CV_PJType = Convert.ToString(dr["CV_PJType"]);
            if (dr["CV_CCode"] != DBNull.Value) customer_Visit.CV_CCode = Convert.ToString(dr["CV_CCode"]);
            if (dr["CV_CName"] != DBNull.Value) customer_Visit.CV_CName = Convert.ToString(dr["CV_CName"]);
            if (dr["CV_Place"] != DBNull.Value) customer_Visit.CV_Place = Convert.ToString(dr["CV_Place"]);
            if (dr["CV_Level"] != DBNull.Value) customer_Visit.CV_Level = Convert.ToString(dr["CV_Level"]);
            if (dr["CV_Count"] != DBNull.Value) customer_Visit.CV_Count = Convert.ToString(dr["CV_Count"]);
            if (dr["CV_SupDate"] != DBNull.Value) customer_Visit.CV_SupDate = Convert.ToDateTime(dr["CV_SupDate"]);
            if (dr["CV_CustAdvice"] != DBNull.Value) customer_Visit.CV_CustAdvice = Convert.ToString(dr["CV_CustAdvice"]);
            if (dr["CV_Remark"] != DBNull.Value) customer_Visit.CV_Remark = Convert.ToString(dr["CV_Remark"]);
            if (dr["Stat"] != DBNull.Value) customer_Visit.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) customer_Visit.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) customer_Visit.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) customer_Visit.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return customer_Visit;
      }
      /// <summary>
      /// 获取指定的客户回访 Customer_Visit对象集合
      /// </summary>
      public List<Customer_Visit> GetListByWhere(string strCondition)
      {
         List<Customer_Visit> ret = new List<Customer_Visit>();
         string sql = "SELECT  CV_ID,CV_Code,CV_PJCode,CV_PJName,CV_PJType,CV_CCode,CV_CName,CV_Place,CV_Level,CV_Count,CV_SupDate,CV_CustAdvice,CV_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Customer_Visit WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Customer_Visit customer_Visit = new Customer_Visit();
            if (dr["CV_ID"] != DBNull.Value) customer_Visit.CV_ID = Convert.ToDecimal(dr["CV_ID"]);
            if (dr["CV_Code"] != DBNull.Value) customer_Visit.CV_Code = Convert.ToString(dr["CV_Code"]);
            if (dr["CV_PJCode"] != DBNull.Value) customer_Visit.CV_PJCode = Convert.ToString(dr["CV_PJCode"]);
            if (dr["CV_PJName"] != DBNull.Value) customer_Visit.CV_PJName = Convert.ToString(dr["CV_PJName"]);
            if (dr["CV_PJType"] != DBNull.Value) customer_Visit.CV_PJType = Convert.ToString(dr["CV_PJType"]);
            if (dr["CV_CCode"] != DBNull.Value) customer_Visit.CV_CCode = Convert.ToString(dr["CV_CCode"]);
            if (dr["CV_CName"] != DBNull.Value) customer_Visit.CV_CName = Convert.ToString(dr["CV_CName"]);
            if (dr["CV_Place"] != DBNull.Value) customer_Visit.CV_Place = Convert.ToString(dr["CV_Place"]);
            if (dr["CV_Level"] != DBNull.Value) customer_Visit.CV_Level = Convert.ToString(dr["CV_Level"]);
            if (dr["CV_Count"] != DBNull.Value) customer_Visit.CV_Count = Convert.ToString(dr["CV_Count"]);
            if (dr["CV_SupDate"] != DBNull.Value) customer_Visit.CV_SupDate = Convert.ToDateTime(dr["CV_SupDate"]);
            if (dr["CV_CustAdvice"] != DBNull.Value) customer_Visit.CV_CustAdvice = Convert.ToString(dr["CV_CustAdvice"]);
            if (dr["CV_Remark"] != DBNull.Value) customer_Visit.CV_Remark = Convert.ToString(dr["CV_Remark"]);
            if (dr["Stat"] != DBNull.Value) customer_Visit.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) customer_Visit.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) customer_Visit.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) customer_Visit.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(customer_Visit);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的客户回访 Customer_Visit对象(即:一条记录
      /// </summary>
      public List<Customer_Visit> GetAll()
      {
         List<Customer_Visit> ret = new List<Customer_Visit>();
         string sql = "SELECT  CV_ID,CV_Code,CV_PJCode,CV_PJName,CV_PJType,CV_CCode,CV_CName,CV_Place,CV_Level,CV_Count,CV_SupDate,CV_CustAdvice,CV_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Customer_Visit where 1=1 AND ((Stat is null) or (Stat=0) ) order by CV_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Customer_Visit customer_Visit = new Customer_Visit();
            if (dr["CV_ID"] != DBNull.Value) customer_Visit.CV_ID = Convert.ToDecimal(dr["CV_ID"]);
            if (dr["CV_Code"] != DBNull.Value) customer_Visit.CV_Code = Convert.ToString(dr["CV_Code"]);
            if (dr["CV_PJCode"] != DBNull.Value) customer_Visit.CV_PJCode = Convert.ToString(dr["CV_PJCode"]);
            if (dr["CV_PJName"] != DBNull.Value) customer_Visit.CV_PJName = Convert.ToString(dr["CV_PJName"]);
            if (dr["CV_PJType"] != DBNull.Value) customer_Visit.CV_PJType = Convert.ToString(dr["CV_PJType"]);
            if (dr["CV_CCode"] != DBNull.Value) customer_Visit.CV_CCode = Convert.ToString(dr["CV_CCode"]);
            if (dr["CV_CName"] != DBNull.Value) customer_Visit.CV_CName = Convert.ToString(dr["CV_CName"]);
            if (dr["CV_Place"] != DBNull.Value) customer_Visit.CV_Place = Convert.ToString(dr["CV_Place"]);
            if (dr["CV_Level"] != DBNull.Value) customer_Visit.CV_Level = Convert.ToString(dr["CV_Level"]);
            if (dr["CV_Count"] != DBNull.Value) customer_Visit.CV_Count = Convert.ToString(dr["CV_Count"]);
            if (dr["CV_SupDate"] != DBNull.Value) customer_Visit.CV_SupDate = Convert.ToDateTime(dr["CV_SupDate"]);
            if (dr["CV_CustAdvice"] != DBNull.Value) customer_Visit.CV_CustAdvice = Convert.ToString(dr["CV_CustAdvice"]);
            if (dr["CV_Remark"] != DBNull.Value) customer_Visit.CV_Remark = Convert.ToString(dr["CV_Remark"]);
            if (dr["Stat"] != DBNull.Value) customer_Visit.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) customer_Visit.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) customer_Visit.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) customer_Visit.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(customer_Visit);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
