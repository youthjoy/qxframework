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
   /// 奖惩信息
   /// </summary>
   [Serializable]
   public partial class ADOHR_AA
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加奖惩信息 HR_AA对象(即:一条记录)
      /// </summary>
      public int Add(HR_AA hR_AA)
      {
         string sql = "INSERT INTO HR_AA (AA_ICode,AA_ECde,AA_EName,AA_Type,AA_Date,AA_Content,AA_Sum,VerifyStuff,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@AA_ICode,@AA_ECde,@AA_EName,@AA_Type,@AA_Date,@AA_Content,@AA_Sum,@VerifyStuff,@VerifyDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(hR_AA.AA_ICode))
         {
            idb.AddParameter("@AA_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_ICode", hR_AA.AA_ICode);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_ECde))
         {
            idb.AddParameter("@AA_ECde", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_ECde", hR_AA.AA_ECde);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_EName))
         {
            idb.AddParameter("@AA_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_EName", hR_AA.AA_EName);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_Type))
         {
            idb.AddParameter("@AA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Type", hR_AA.AA_Type);
         }
         if (hR_AA.AA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Date", hR_AA.AA_Date);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_Content))
         {
            idb.AddParameter("@AA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Content", hR_AA.AA_Content);
         }
         if (hR_AA.AA_Sum == 0)
         {
            idb.AddParameter("@AA_Sum", 0);
         }
         else
         {
            idb.AddParameter("@AA_Sum", hR_AA.AA_Sum);
         }
         if (string.IsNullOrEmpty(hR_AA.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", hR_AA.VerifyStuff);
         }
         if (hR_AA.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", hR_AA.VerifyDate);
         }
         if (hR_AA.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_AA.Stat);
         }
         if (hR_AA.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_AA.CreateDate);
         }
         if (hR_AA.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_AA.UpdateDate);
         }
         if (hR_AA.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_AA.DeleteDate);
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
      /// 添加奖惩信息 HR_AA对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_AA hR_AA)
      {
         string sql = "INSERT INTO HR_AA (AA_ICode,AA_ECde,AA_EName,AA_Type,AA_Date,AA_Content,AA_Sum,VerifyStuff,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@AA_ICode,@AA_ECde,@AA_EName,@AA_Type,@AA_Date,@AA_Content,@AA_Sum,@VerifyStuff,@VerifyDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_AA.AA_ICode))
         {
            idb.AddParameter("@AA_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_ICode", hR_AA.AA_ICode);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_ECde))
         {
            idb.AddParameter("@AA_ECde", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_ECde", hR_AA.AA_ECde);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_EName))
         {
            idb.AddParameter("@AA_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_EName", hR_AA.AA_EName);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_Type))
         {
            idb.AddParameter("@AA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Type", hR_AA.AA_Type);
         }
         if (hR_AA.AA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Date", hR_AA.AA_Date);
         }
         if (string.IsNullOrEmpty(hR_AA.AA_Content))
         {
            idb.AddParameter("@AA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Content", hR_AA.AA_Content);
         }
         if (hR_AA.AA_Sum == 0)
         {
            idb.AddParameter("@AA_Sum", 0);
         }
         else
         {
            idb.AddParameter("@AA_Sum", hR_AA.AA_Sum);
         }
         if (string.IsNullOrEmpty(hR_AA.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", hR_AA.VerifyStuff);
         }
         if (hR_AA.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", hR_AA.VerifyDate);
         }
         if (hR_AA.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_AA.Stat);
         }
         if (hR_AA.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_AA.CreateDate);
         }
         if (hR_AA.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_AA.UpdateDate);
         }
         if (hR_AA.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_AA.DeleteDate);
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
      /// 更新奖惩信息 HR_AA对象(即:一条记录
      /// </summary>
      public int Update(HR_AA hR_AA)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_AA       SET ");
            if(hR_AA.AA_ICode_IsChanged){sbParameter.Append("AA_ICode=@AA_ICode, ");}
      if(hR_AA.AA_ECde_IsChanged){sbParameter.Append("AA_ECde=@AA_ECde, ");}
      if(hR_AA.AA_EName_IsChanged){sbParameter.Append("AA_EName=@AA_EName, ");}
      if(hR_AA.AA_Type_IsChanged){sbParameter.Append("AA_Type=@AA_Type, ");}
      if(hR_AA.AA_Date_IsChanged){sbParameter.Append("AA_Date=@AA_Date, ");}
      if(hR_AA.AA_Content_IsChanged){sbParameter.Append("AA_Content=@AA_Content, ");}
      if(hR_AA.AA_Sum_IsChanged){sbParameter.Append("AA_Sum=@AA_Sum, ");}
      if(hR_AA.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(hR_AA.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(hR_AA.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_AA.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_AA.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hR_AA.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AA_ID=@AA_ID; " );
      string sql=sb.ToString();
         if(hR_AA.AA_ICode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_AA.AA_ICode))
         {
            idb.AddParameter("@AA_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_ICode", hR_AA.AA_ICode);
         }
          }
         if(hR_AA.AA_ECde_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_AA.AA_ECde))
         {
            idb.AddParameter("@AA_ECde", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_ECde", hR_AA.AA_ECde);
         }
          }
         if(hR_AA.AA_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_AA.AA_EName))
         {
            idb.AddParameter("@AA_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_EName", hR_AA.AA_EName);
         }
          }
         if(hR_AA.AA_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_AA.AA_Type))
         {
            idb.AddParameter("@AA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Type", hR_AA.AA_Type);
         }
          }
         if(hR_AA.AA_Date_IsChanged)
         {
         if (hR_AA.AA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Date", hR_AA.AA_Date);
         }
          }
         if(hR_AA.AA_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_AA.AA_Content))
         {
            idb.AddParameter("@AA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AA_Content", hR_AA.AA_Content);
         }
          }
         if(hR_AA.AA_Sum_IsChanged)
         {
         if (hR_AA.AA_Sum == 0)
         {
            idb.AddParameter("@AA_Sum", 0);
         }
         else
         {
            idb.AddParameter("@AA_Sum", hR_AA.AA_Sum);
         }
          }
         if(hR_AA.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_AA.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", hR_AA.VerifyStuff);
         }
          }
         if(hR_AA.VerifyDate_IsChanged)
         {
         if (hR_AA.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", hR_AA.VerifyDate);
         }
          }
         if(hR_AA.Stat_IsChanged)
         {
         if (hR_AA.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_AA.Stat);
         }
          }
         if(hR_AA.CreateDate_IsChanged)
         {
         if (hR_AA.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_AA.CreateDate);
         }
          }
         if(hR_AA.UpdateDate_IsChanged)
         {
         if (hR_AA.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_AA.UpdateDate);
         }
          }
         if(hR_AA.DeleteDate_IsChanged)
         {
         if (hR_AA.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_AA.DeleteDate);
         }
          }

         idb.AddParameter("@AA_ID", hR_AA.AA_ID);

           
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
      /// 删除奖惩信息 HR_AA对象(即:一条记录
      /// </summary>
      public int Delete(decimal aA_ID)
      {
         string sql = "DELETE HR_AA WHERE 1=1  AND AA_ID=@AA_ID ";
         idb.AddParameter("@AA_ID", aA_ID);

           
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
      /// 获取指定的奖惩信息 HR_AA对象(即:一条记录
      /// </summary>
      public HR_AA GetByKey(decimal aA_ID)
      {
         HR_AA hR_AA = new HR_AA();
         string sql = "SELECT  AA_ID,AA_ICode,AA_ECde,AA_EName,AA_Type,AA_Date,AA_Content,AA_Sum,VerifyStuff,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_AA WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AA_ID=@AA_ID ";
         idb.AddParameter("@AA_ID", aA_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AA_ID"] != DBNull.Value) hR_AA.AA_ID = Convert.ToDecimal(dr["AA_ID"]);
            if (dr["AA_ICode"] != DBNull.Value) hR_AA.AA_ICode = Convert.ToString(dr["AA_ICode"]);
            if (dr["AA_ECde"] != DBNull.Value) hR_AA.AA_ECde = Convert.ToString(dr["AA_ECde"]);
            if (dr["AA_EName"] != DBNull.Value) hR_AA.AA_EName = Convert.ToString(dr["AA_EName"]);
            if (dr["AA_Type"] != DBNull.Value) hR_AA.AA_Type = Convert.ToString(dr["AA_Type"]);
            if (dr["AA_Date"] != DBNull.Value) hR_AA.AA_Date = Convert.ToDateTime(dr["AA_Date"]);
            if (dr["AA_Content"] != DBNull.Value) hR_AA.AA_Content = Convert.ToString(dr["AA_Content"]);
            if (dr["AA_Sum"] != DBNull.Value) hR_AA.AA_Sum = Convert.ToDouble(dr["AA_Sum"]);
            if (dr["VerifyStuff"] != DBNull.Value) hR_AA.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) hR_AA.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) hR_AA.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_AA.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_AA.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_AA.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_AA;
      }
      /// <summary>
      /// 获取指定的奖惩信息 HR_AA对象集合
      /// </summary>
      public List<HR_AA> GetListByWhere(string strCondition)
      {
         List<HR_AA> ret = new List<HR_AA>();
         string sql = "SELECT  AA_ID,AA_ICode,AA_ECde,AA_EName,AA_Type,AA_Date,AA_Content,AA_Sum,VerifyStuff,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_AA WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            HR_AA hR_AA = new HR_AA();
            if (dr["AA_ID"] != DBNull.Value) hR_AA.AA_ID = Convert.ToDecimal(dr["AA_ID"]);
            if (dr["AA_ICode"] != DBNull.Value) hR_AA.AA_ICode = Convert.ToString(dr["AA_ICode"]);
            if (dr["AA_ECde"] != DBNull.Value) hR_AA.AA_ECde = Convert.ToString(dr["AA_ECde"]);
            if (dr["AA_EName"] != DBNull.Value) hR_AA.AA_EName = Convert.ToString(dr["AA_EName"]);
            if (dr["AA_Type"] != DBNull.Value) hR_AA.AA_Type = Convert.ToString(dr["AA_Type"]);
            if (dr["AA_Date"] != DBNull.Value) hR_AA.AA_Date = Convert.ToDateTime(dr["AA_Date"]);
            if (dr["AA_Content"] != DBNull.Value) hR_AA.AA_Content = Convert.ToString(dr["AA_Content"]);
            if (dr["AA_Sum"] != DBNull.Value) hR_AA.AA_Sum = Convert.ToDouble(dr["AA_Sum"]);
            if (dr["VerifyStuff"] != DBNull.Value) hR_AA.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) hR_AA.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) hR_AA.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_AA.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_AA.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_AA.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_AA);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的奖惩信息 HR_AA对象(即:一条记录
      /// </summary>
      public List<HR_AA> GetAll()
      {
         List<HR_AA> ret = new List<HR_AA>();
         string sql = "SELECT  AA_ID,AA_ICode,AA_ECde,AA_EName,AA_Type,AA_Date,AA_Content,AA_Sum,VerifyStuff,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_AA where 1=1 AND ((Stat is null) or (Stat=0) ) order by AA_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_AA hR_AA = new HR_AA();
            if (dr["AA_ID"] != DBNull.Value) hR_AA.AA_ID = Convert.ToDecimal(dr["AA_ID"]);
            if (dr["AA_ICode"] != DBNull.Value) hR_AA.AA_ICode = Convert.ToString(dr["AA_ICode"]);
            if (dr["AA_ECde"] != DBNull.Value) hR_AA.AA_ECde = Convert.ToString(dr["AA_ECde"]);
            if (dr["AA_EName"] != DBNull.Value) hR_AA.AA_EName = Convert.ToString(dr["AA_EName"]);
            if (dr["AA_Type"] != DBNull.Value) hR_AA.AA_Type = Convert.ToString(dr["AA_Type"]);
            if (dr["AA_Date"] != DBNull.Value) hR_AA.AA_Date = Convert.ToDateTime(dr["AA_Date"]);
            if (dr["AA_Content"] != DBNull.Value) hR_AA.AA_Content = Convert.ToString(dr["AA_Content"]);
            if (dr["AA_Sum"] != DBNull.Value) hR_AA.AA_Sum = Convert.ToDouble(dr["AA_Sum"]);
            if (dr["VerifyStuff"] != DBNull.Value) hR_AA.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) hR_AA.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) hR_AA.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_AA.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_AA.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_AA.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_AA);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
