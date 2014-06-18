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
   /// 员工财务信息
   /// </summary>
   [Serializable]
   public partial class ADOHR_In
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加员工财务信息 HR_In对象(即:一条记录)
      /// </summary>
      public int Add(HR_In hR_In)
      {
         string sql = "INSERT INTO HR_In (HM_InCode,HM_Type,HM_EName,HM_ECode,HM_OTitle,HM_OSalary,HM_CTitle,HM_CSalary,HM_Content,HM_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HM_InCode,@HM_Type,@HM_EName,@HM_ECode,@HM_OTitle,@HM_OSalary,@HM_CTitle,@HM_CSalary,@HM_Content,@HM_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(hR_In.HM_InCode))
         {
            idb.AddParameter("@HM_InCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_InCode", hR_In.HM_InCode);
         }
         if (string.IsNullOrEmpty(hR_In.HM_Type))
         {
            idb.AddParameter("@HM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Type", hR_In.HM_Type);
         }
         if (string.IsNullOrEmpty(hR_In.HM_EName))
         {
            idb.AddParameter("@HM_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_EName", hR_In.HM_EName);
         }
         if (string.IsNullOrEmpty(hR_In.HM_ECode))
         {
            idb.AddParameter("@HM_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_ECode", hR_In.HM_ECode);
         }
         if (string.IsNullOrEmpty(hR_In.HM_OTitle))
         {
            idb.AddParameter("@HM_OTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_OTitle", hR_In.HM_OTitle);
         }
         if (hR_In.HM_OSalary == 0)
         {
            idb.AddParameter("@HM_OSalary", 0);
         }
         else
         {
            idb.AddParameter("@HM_OSalary", hR_In.HM_OSalary);
         }
         if (string.IsNullOrEmpty(hR_In.HM_CTitle))
         {
            idb.AddParameter("@HM_CTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_CTitle", hR_In.HM_CTitle);
         }
         if (hR_In.HM_CSalary == 0)
         {
            idb.AddParameter("@HM_CSalary", 0);
         }
         else
         {
            idb.AddParameter("@HM_CSalary", hR_In.HM_CSalary);
         }
         if (string.IsNullOrEmpty(hR_In.HM_Content))
         {
            idb.AddParameter("@HM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Content", hR_In.HM_Content);
         }
         if (string.IsNullOrEmpty(hR_In.HM_Bak))
         {
            idb.AddParameter("@HM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Bak", hR_In.HM_Bak);
         }
         if (hR_In.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_In.Stat);
         }
         if (hR_In.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_In.CreateDate);
         }
         if (hR_In.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_In.UpdateDate);
         }
         if (hR_In.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_In.DeleteDate);
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
      /// 添加员工财务信息 HR_In对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_In hR_In)
      {
         string sql = "INSERT INTO HR_In (HM_InCode,HM_Type,HM_EName,HM_ECode,HM_OTitle,HM_OSalary,HM_CTitle,HM_CSalary,HM_Content,HM_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HM_InCode,@HM_Type,@HM_EName,@HM_ECode,@HM_OTitle,@HM_OSalary,@HM_CTitle,@HM_CSalary,@HM_Content,@HM_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_In.HM_InCode))
         {
            idb.AddParameter("@HM_InCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_InCode", hR_In.HM_InCode);
         }
         if (string.IsNullOrEmpty(hR_In.HM_Type))
         {
            idb.AddParameter("@HM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Type", hR_In.HM_Type);
         }
         if (string.IsNullOrEmpty(hR_In.HM_EName))
         {
            idb.AddParameter("@HM_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_EName", hR_In.HM_EName);
         }
         if (string.IsNullOrEmpty(hR_In.HM_ECode))
         {
            idb.AddParameter("@HM_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_ECode", hR_In.HM_ECode);
         }
         if (string.IsNullOrEmpty(hR_In.HM_OTitle))
         {
            idb.AddParameter("@HM_OTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_OTitle", hR_In.HM_OTitle);
         }
         if (hR_In.HM_OSalary == 0)
         {
            idb.AddParameter("@HM_OSalary", 0);
         }
         else
         {
            idb.AddParameter("@HM_OSalary", hR_In.HM_OSalary);
         }
         if (string.IsNullOrEmpty(hR_In.HM_CTitle))
         {
            idb.AddParameter("@HM_CTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_CTitle", hR_In.HM_CTitle);
         }
         if (hR_In.HM_CSalary == 0)
         {
            idb.AddParameter("@HM_CSalary", 0);
         }
         else
         {
            idb.AddParameter("@HM_CSalary", hR_In.HM_CSalary);
         }
         if (string.IsNullOrEmpty(hR_In.HM_Content))
         {
            idb.AddParameter("@HM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Content", hR_In.HM_Content);
         }
         if (string.IsNullOrEmpty(hR_In.HM_Bak))
         {
            idb.AddParameter("@HM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Bak", hR_In.HM_Bak);
         }
         if (hR_In.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_In.Stat);
         }
         if (hR_In.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_In.CreateDate);
         }
         if (hR_In.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_In.UpdateDate);
         }
         if (hR_In.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_In.DeleteDate);
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
      /// 更新员工财务信息 HR_In对象(即:一条记录
      /// </summary>
      public int Update(HR_In hR_In)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_In       SET ");
            if(hR_In.HM_InCode_IsChanged){sbParameter.Append("HM_InCode=@HM_InCode, ");}
      if(hR_In.HM_Type_IsChanged){sbParameter.Append("HM_Type=@HM_Type, ");}
      if(hR_In.HM_EName_IsChanged){sbParameter.Append("HM_EName=@HM_EName, ");}
      if(hR_In.HM_ECode_IsChanged){sbParameter.Append("HM_ECode=@HM_ECode, ");}
      if(hR_In.HM_OTitle_IsChanged){sbParameter.Append("HM_OTitle=@HM_OTitle, ");}
      if(hR_In.HM_OSalary_IsChanged){sbParameter.Append("HM_OSalary=@HM_OSalary, ");}
      if(hR_In.HM_CTitle_IsChanged){sbParameter.Append("HM_CTitle=@HM_CTitle, ");}
      if(hR_In.HM_CSalary_IsChanged){sbParameter.Append("HM_CSalary=@HM_CSalary, ");}
      if(hR_In.HM_Content_IsChanged){sbParameter.Append("HM_Content=@HM_Content, ");}
      if(hR_In.HM_Bak_IsChanged){sbParameter.Append("HM_Bak=@HM_Bak, ");}
      if(hR_In.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_In.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_In.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hR_In.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and HM_ID=@HM_ID; " );
      string sql=sb.ToString();
         if(hR_In.HM_InCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_InCode))
         {
            idb.AddParameter("@HM_InCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_InCode", hR_In.HM_InCode);
         }
          }
         if(hR_In.HM_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_Type))
         {
            idb.AddParameter("@HM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Type", hR_In.HM_Type);
         }
          }
         if(hR_In.HM_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_EName))
         {
            idb.AddParameter("@HM_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_EName", hR_In.HM_EName);
         }
          }
         if(hR_In.HM_ECode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_ECode))
         {
            idb.AddParameter("@HM_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_ECode", hR_In.HM_ECode);
         }
          }
         if(hR_In.HM_OTitle_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_OTitle))
         {
            idb.AddParameter("@HM_OTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_OTitle", hR_In.HM_OTitle);
         }
          }
         if(hR_In.HM_OSalary_IsChanged)
         {
         if (hR_In.HM_OSalary == 0)
         {
            idb.AddParameter("@HM_OSalary", 0);
         }
         else
         {
            idb.AddParameter("@HM_OSalary", hR_In.HM_OSalary);
         }
          }
         if(hR_In.HM_CTitle_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_CTitle))
         {
            idb.AddParameter("@HM_CTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_CTitle", hR_In.HM_CTitle);
         }
          }
         if(hR_In.HM_CSalary_IsChanged)
         {
         if (hR_In.HM_CSalary == 0)
         {
            idb.AddParameter("@HM_CSalary", 0);
         }
         else
         {
            idb.AddParameter("@HM_CSalary", hR_In.HM_CSalary);
         }
          }
         if(hR_In.HM_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_Content))
         {
            idb.AddParameter("@HM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Content", hR_In.HM_Content);
         }
          }
         if(hR_In.HM_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_In.HM_Bak))
         {
            idb.AddParameter("@HM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HM_Bak", hR_In.HM_Bak);
         }
          }
         if(hR_In.Stat_IsChanged)
         {
         if (hR_In.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_In.Stat);
         }
          }
         if(hR_In.CreateDate_IsChanged)
         {
         if (hR_In.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_In.CreateDate);
         }
          }
         if(hR_In.UpdateDate_IsChanged)
         {
         if (hR_In.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_In.UpdateDate);
         }
          }
         if(hR_In.DeleteDate_IsChanged)
         {
         if (hR_In.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_In.DeleteDate);
         }
          }

         idb.AddParameter("@HM_ID", hR_In.HM_ID);

           
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
      /// 删除员工财务信息 HR_In对象(即:一条记录
      /// </summary>
      public int Delete(decimal hM_ID)
      {
         string sql = "DELETE HR_In WHERE 1=1  AND HM_ID=@HM_ID ";
         idb.AddParameter("@HM_ID", hM_ID);

           
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
      /// 获取指定的员工财务信息 HR_In对象(即:一条记录
      /// </summary>
      public HR_In GetByKey(decimal hM_ID)
      {
         HR_In hR_In = new HR_In();
         string sql = "SELECT  HM_ID,HM_InCode,HM_Type,HM_EName,HM_ECode,HM_OTitle,HM_OSalary,HM_CTitle,HM_CSalary,HM_Content,HM_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_In WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND HM_ID=@HM_ID ";
         idb.AddParameter("@HM_ID", hM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["HM_ID"] != DBNull.Value) hR_In.HM_ID = Convert.ToDecimal(dr["HM_ID"]);
            if (dr["HM_InCode"] != DBNull.Value) hR_In.HM_InCode = Convert.ToString(dr["HM_InCode"]);
            if (dr["HM_Type"] != DBNull.Value) hR_In.HM_Type = Convert.ToString(dr["HM_Type"]);
            if (dr["HM_EName"] != DBNull.Value) hR_In.HM_EName = Convert.ToString(dr["HM_EName"]);
            if (dr["HM_ECode"] != DBNull.Value) hR_In.HM_ECode = Convert.ToString(dr["HM_ECode"]);
            if (dr["HM_OTitle"] != DBNull.Value) hR_In.HM_OTitle = Convert.ToString(dr["HM_OTitle"]);
            if (dr["HM_OSalary"] != DBNull.Value) hR_In.HM_OSalary = Convert.ToDouble(dr["HM_OSalary"]);
            if (dr["HM_CTitle"] != DBNull.Value) hR_In.HM_CTitle = Convert.ToString(dr["HM_CTitle"]);
            if (dr["HM_CSalary"] != DBNull.Value) hR_In.HM_CSalary = Convert.ToDouble(dr["HM_CSalary"]);
            if (dr["HM_Content"] != DBNull.Value) hR_In.HM_Content = Convert.ToString(dr["HM_Content"]);
            if (dr["HM_Bak"] != DBNull.Value) hR_In.HM_Bak = Convert.ToString(dr["HM_Bak"]);
            if (dr["Stat"] != DBNull.Value) hR_In.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_In.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_In.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_In.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_In;
      }
      /// <summary>
      /// 获取指定的员工财务信息 HR_In对象集合
      /// </summary>
      public List<HR_In> GetListByWhere(string strCondition)
      {
         List<HR_In> ret = new List<HR_In>();
         string sql = "SELECT  HM_ID,HM_InCode,HM_Type,HM_EName,HM_ECode,HM_OTitle,HM_OSalary,HM_CTitle,HM_CSalary,HM_Content,HM_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_In WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            HR_In hR_In = new HR_In();
            if (dr["HM_ID"] != DBNull.Value) hR_In.HM_ID = Convert.ToDecimal(dr["HM_ID"]);
            if (dr["HM_InCode"] != DBNull.Value) hR_In.HM_InCode = Convert.ToString(dr["HM_InCode"]);
            if (dr["HM_Type"] != DBNull.Value) hR_In.HM_Type = Convert.ToString(dr["HM_Type"]);
            if (dr["HM_EName"] != DBNull.Value) hR_In.HM_EName = Convert.ToString(dr["HM_EName"]);
            if (dr["HM_ECode"] != DBNull.Value) hR_In.HM_ECode = Convert.ToString(dr["HM_ECode"]);
            if (dr["HM_OTitle"] != DBNull.Value) hR_In.HM_OTitle = Convert.ToString(dr["HM_OTitle"]);
            if (dr["HM_OSalary"] != DBNull.Value) hR_In.HM_OSalary = Convert.ToDouble(dr["HM_OSalary"]);
            if (dr["HM_CTitle"] != DBNull.Value) hR_In.HM_CTitle = Convert.ToString(dr["HM_CTitle"]);
            if (dr["HM_CSalary"] != DBNull.Value) hR_In.HM_CSalary = Convert.ToDouble(dr["HM_CSalary"]);
            if (dr["HM_Content"] != DBNull.Value) hR_In.HM_Content = Convert.ToString(dr["HM_Content"]);
            if (dr["HM_Bak"] != DBNull.Value) hR_In.HM_Bak = Convert.ToString(dr["HM_Bak"]);
            if (dr["Stat"] != DBNull.Value) hR_In.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_In.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_In.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_In.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_In);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的员工财务信息 HR_In对象(即:一条记录
      /// </summary>
      public List<HR_In> GetAll()
      {
         List<HR_In> ret = new List<HR_In>();
         string sql = "SELECT  HM_ID,HM_InCode,HM_Type,HM_EName,HM_ECode,HM_OTitle,HM_OSalary,HM_CTitle,HM_CSalary,HM_Content,HM_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_In where 1=1 AND ((Stat is null) or (Stat=0) ) order by HM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_In hR_In = new HR_In();
            if (dr["HM_ID"] != DBNull.Value) hR_In.HM_ID = Convert.ToDecimal(dr["HM_ID"]);
            if (dr["HM_InCode"] != DBNull.Value) hR_In.HM_InCode = Convert.ToString(dr["HM_InCode"]);
            if (dr["HM_Type"] != DBNull.Value) hR_In.HM_Type = Convert.ToString(dr["HM_Type"]);
            if (dr["HM_EName"] != DBNull.Value) hR_In.HM_EName = Convert.ToString(dr["HM_EName"]);
            if (dr["HM_ECode"] != DBNull.Value) hR_In.HM_ECode = Convert.ToString(dr["HM_ECode"]);
            if (dr["HM_OTitle"] != DBNull.Value) hR_In.HM_OTitle = Convert.ToString(dr["HM_OTitle"]);
            if (dr["HM_OSalary"] != DBNull.Value) hR_In.HM_OSalary = Convert.ToDouble(dr["HM_OSalary"]);
            if (dr["HM_CTitle"] != DBNull.Value) hR_In.HM_CTitle = Convert.ToString(dr["HM_CTitle"]);
            if (dr["HM_CSalary"] != DBNull.Value) hR_In.HM_CSalary = Convert.ToDouble(dr["HM_CSalary"]);
            if (dr["HM_Content"] != DBNull.Value) hR_In.HM_Content = Convert.ToString(dr["HM_Content"]);
            if (dr["HM_Bak"] != DBNull.Value) hR_In.HM_Bak = Convert.ToString(dr["HM_Bak"]);
            if (dr["Stat"] != DBNull.Value) hR_In.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_In.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_In.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_In.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_In);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
