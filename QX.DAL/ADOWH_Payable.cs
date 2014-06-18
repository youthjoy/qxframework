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
   /// 应付单
   /// </summary>
   [Serializable]
   public partial class ADOWH_Payable
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加应付单 WH_Payable对象(即:一条记录)
      /// </summary>
      public int Add(WH_Payable wH_Payable)
      {
         string sql = "INSERT INTO WH_Payable (WHP_Code,WHP_SCode,WHP_SName,WHP_Period,WHP_LSum,WHP_CSum,WHP_CLeft,WHP_IsDone,Stat,WHP_IsDate,CreateDate,UpdateDate,DeleteDate,WHP_UCompany,WHP_UCompanyCode,WHP_broom) VALUES (@WHP_Code,@WHP_SCode,@WHP_SName,@WHP_Period,@WHP_LSum,@WHP_CSum,@WHP_CLeft,@WHP_IsDone,@Stat,@WHP_IsDate,@CreateDate,@UpdateDate,@DeleteDate,@WHP_UCompany,@WHP_UCompanyCode,@WHP_broom)";
         if (string.IsNullOrEmpty(wH_Payable.WHP_Code))
         {
            idb.AddParameter("@WHP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_Code", wH_Payable.WHP_Code);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_SCode))
         {
            idb.AddParameter("@WHP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_SCode", wH_Payable.WHP_SCode);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_SName))
         {
            idb.AddParameter("@WHP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_SName", wH_Payable.WHP_SName);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_Period))
         {
            idb.AddParameter("@WHP_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_Period", wH_Payable.WHP_Period);
         }
         if (wH_Payable.WHP_LSum == 0)
         {
            idb.AddParameter("@WHP_LSum", 0);
         }
         else
         {
            idb.AddParameter("@WHP_LSum", wH_Payable.WHP_LSum);
         }
         if (wH_Payable.WHP_CSum == 0)
         {
            idb.AddParameter("@WHP_CSum", 0);
         }
         else
         {
            idb.AddParameter("@WHP_CSum", wH_Payable.WHP_CSum);
         }
         if (wH_Payable.WHP_CLeft == 0)
         {
            idb.AddParameter("@WHP_CLeft", 0);
         }
         else
         {
            idb.AddParameter("@WHP_CLeft", wH_Payable.WHP_CLeft);
         }
         if (wH_Payable.WHP_IsDone == 0)
         {
            idb.AddParameter("@WHP_IsDone", 0);
         }
         else
         {
            idb.AddParameter("@WHP_IsDone", wH_Payable.WHP_IsDone);
         }
         if (wH_Payable.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Payable.Stat);
         }
         if (wH_Payable.WHP_IsDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHP_IsDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_IsDate", wH_Payable.WHP_IsDate);
         }
         if (wH_Payable.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Payable.CreateDate);
         }
         if (wH_Payable.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Payable.UpdateDate);
         }
         if (wH_Payable.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Payable.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_UCompany))
         {
            idb.AddParameter("@WHP_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_UCompany", wH_Payable.WHP_UCompany);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_UCompanyCode))
         {
            idb.AddParameter("@WHP_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_UCompanyCode", wH_Payable.WHP_UCompanyCode);
         }
         if (wH_Payable.WHP_broom == 0)
         {
            idb.AddParameter("@WHP_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHP_broom", wH_Payable.WHP_broom);
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
      /// 添加应付单 WH_Payable对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Payable wH_Payable)
      {
         string sql = "INSERT INTO WH_Payable (WHP_Code,WHP_SCode,WHP_SName,WHP_Period,WHP_LSum,WHP_CSum,WHP_CLeft,WHP_IsDone,Stat,WHP_IsDate,CreateDate,UpdateDate,DeleteDate,WHP_UCompany,WHP_UCompanyCode,WHP_broom) VALUES (@WHP_Code,@WHP_SCode,@WHP_SName,@WHP_Period,@WHP_LSum,@WHP_CSum,@WHP_CLeft,@WHP_IsDone,@Stat,@WHP_IsDate,@CreateDate,@UpdateDate,@DeleteDate,@WHP_UCompany,@WHP_UCompanyCode,@WHP_broom);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Payable.WHP_Code))
         {
            idb.AddParameter("@WHP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_Code", wH_Payable.WHP_Code);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_SCode))
         {
            idb.AddParameter("@WHP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_SCode", wH_Payable.WHP_SCode);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_SName))
         {
            idb.AddParameter("@WHP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_SName", wH_Payable.WHP_SName);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_Period))
         {
            idb.AddParameter("@WHP_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_Period", wH_Payable.WHP_Period);
         }
         if (wH_Payable.WHP_LSum == 0)
         {
            idb.AddParameter("@WHP_LSum", 0);
         }
         else
         {
            idb.AddParameter("@WHP_LSum", wH_Payable.WHP_LSum);
         }
         if (wH_Payable.WHP_CSum == 0)
         {
            idb.AddParameter("@WHP_CSum", 0);
         }
         else
         {
            idb.AddParameter("@WHP_CSum", wH_Payable.WHP_CSum);
         }
         if (wH_Payable.WHP_CLeft == 0)
         {
            idb.AddParameter("@WHP_CLeft", 0);
         }
         else
         {
            idb.AddParameter("@WHP_CLeft", wH_Payable.WHP_CLeft);
         }
         if (wH_Payable.WHP_IsDone == 0)
         {
            idb.AddParameter("@WHP_IsDone", 0);
         }
         else
         {
            idb.AddParameter("@WHP_IsDone", wH_Payable.WHP_IsDone);
         }
         if (wH_Payable.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Payable.Stat);
         }
         if (wH_Payable.WHP_IsDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHP_IsDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_IsDate", wH_Payable.WHP_IsDate);
         }
         if (wH_Payable.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Payable.CreateDate);
         }
         if (wH_Payable.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Payable.UpdateDate);
         }
         if (wH_Payable.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Payable.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_UCompany))
         {
            idb.AddParameter("@WHP_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_UCompany", wH_Payable.WHP_UCompany);
         }
         if (string.IsNullOrEmpty(wH_Payable.WHP_UCompanyCode))
         {
            idb.AddParameter("@WHP_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_UCompanyCode", wH_Payable.WHP_UCompanyCode);
         }
         if (wH_Payable.WHP_broom == 0)
         {
            idb.AddParameter("@WHP_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHP_broom", wH_Payable.WHP_broom);
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
      /// 更新应付单 WH_Payable对象(即:一条记录
      /// </summary>
      public int Update(WH_Payable wH_Payable)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Payable       SET ");
            if(wH_Payable.WHP_Code_IsChanged){sbParameter.Append("WHP_Code=@WHP_Code, ");}
      if(wH_Payable.WHP_SCode_IsChanged){sbParameter.Append("WHP_SCode=@WHP_SCode, ");}
      if(wH_Payable.WHP_SName_IsChanged){sbParameter.Append("WHP_SName=@WHP_SName, ");}
      if(wH_Payable.WHP_Period_IsChanged){sbParameter.Append("WHP_Period=@WHP_Period, ");}
      if(wH_Payable.WHP_LSum_IsChanged){sbParameter.Append("WHP_LSum=@WHP_LSum, ");}
      if(wH_Payable.WHP_CSum_IsChanged){sbParameter.Append("WHP_CSum=@WHP_CSum, ");}
      if(wH_Payable.WHP_CLeft_IsChanged){sbParameter.Append("WHP_CLeft=@WHP_CLeft, ");}
      if(wH_Payable.WHP_IsDone_IsChanged){sbParameter.Append("WHP_IsDone=@WHP_IsDone, ");}
      if(wH_Payable.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Payable.WHP_IsDate_IsChanged){sbParameter.Append("WHP_IsDate=@WHP_IsDate, ");}
      if(wH_Payable.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Payable.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Payable.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Payable.WHP_UCompany_IsChanged){sbParameter.Append("WHP_UCompany=@WHP_UCompany, ");}
      if(wH_Payable.WHP_UCompanyCode_IsChanged){sbParameter.Append("WHP_UCompanyCode=@WHP_UCompanyCode, ");}
      if(wH_Payable.WHP_broom_IsChanged){sbParameter.Append("WHP_broom=@WHP_broom ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHP_ID=@WHP_ID; " );
      string sql=sb.ToString();
         if(wH_Payable.WHP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Payable.WHP_Code))
         {
            idb.AddParameter("@WHP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_Code", wH_Payable.WHP_Code);
         }
          }
         if(wH_Payable.WHP_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Payable.WHP_SCode))
         {
            idb.AddParameter("@WHP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_SCode", wH_Payable.WHP_SCode);
         }
          }
         if(wH_Payable.WHP_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Payable.WHP_SName))
         {
            idb.AddParameter("@WHP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_SName", wH_Payable.WHP_SName);
         }
          }
         if(wH_Payable.WHP_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Payable.WHP_Period))
         {
            idb.AddParameter("@WHP_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_Period", wH_Payable.WHP_Period);
         }
          }
         if(wH_Payable.WHP_LSum_IsChanged)
         {
         if (wH_Payable.WHP_LSum == 0)
         {
            idb.AddParameter("@WHP_LSum", 0);
         }
         else
         {
            idb.AddParameter("@WHP_LSum", wH_Payable.WHP_LSum);
         }
          }
         if(wH_Payable.WHP_CSum_IsChanged)
         {
         if (wH_Payable.WHP_CSum == 0)
         {
            idb.AddParameter("@WHP_CSum", 0);
         }
         else
         {
            idb.AddParameter("@WHP_CSum", wH_Payable.WHP_CSum);
         }
          }
         if(wH_Payable.WHP_CLeft_IsChanged)
         {
         if (wH_Payable.WHP_CLeft == 0)
         {
            idb.AddParameter("@WHP_CLeft", 0);
         }
         else
         {
            idb.AddParameter("@WHP_CLeft", wH_Payable.WHP_CLeft);
         }
          }
         if(wH_Payable.WHP_IsDone_IsChanged)
         {
         if (wH_Payable.WHP_IsDone == 0)
         {
            idb.AddParameter("@WHP_IsDone", 0);
         }
         else
         {
            idb.AddParameter("@WHP_IsDone", wH_Payable.WHP_IsDone);
         }
          }
         if(wH_Payable.Stat_IsChanged)
         {
         if (wH_Payable.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Payable.Stat);
         }
          }
         if(wH_Payable.WHP_IsDate_IsChanged)
         {
         if (wH_Payable.WHP_IsDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHP_IsDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_IsDate", wH_Payable.WHP_IsDate);
         }
          }
         if(wH_Payable.CreateDate_IsChanged)
         {
         if (wH_Payable.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Payable.CreateDate);
         }
          }
         if(wH_Payable.UpdateDate_IsChanged)
         {
         if (wH_Payable.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Payable.UpdateDate);
         }
          }
         if(wH_Payable.DeleteDate_IsChanged)
         {
         if (wH_Payable.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Payable.DeleteDate);
         }
          }
         if(wH_Payable.WHP_UCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Payable.WHP_UCompany))
         {
            idb.AddParameter("@WHP_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_UCompany", wH_Payable.WHP_UCompany);
         }
          }
         if(wH_Payable.WHP_UCompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Payable.WHP_UCompanyCode))
         {
            idb.AddParameter("@WHP_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHP_UCompanyCode", wH_Payable.WHP_UCompanyCode);
         }
          }
         if(wH_Payable.WHP_broom_IsChanged)
         {
         if (wH_Payable.WHP_broom == 0)
         {
            idb.AddParameter("@WHP_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHP_broom", wH_Payable.WHP_broom);
         }
          }

         idb.AddParameter("@WHP_ID", wH_Payable.WHP_ID);

           
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
      /// 删除应付单 WH_Payable对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHP_ID)
      {
         string sql = "DELETE WH_Payable WHERE 1=1  AND WHP_ID=@WHP_ID ";
         idb.AddParameter("@WHP_ID", wHP_ID);

           
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
      /// 获取指定的应付单 WH_Payable对象(即:一条记录
      /// </summary>
      public WH_Payable GetByKey(decimal wHP_ID)
      {
         WH_Payable wH_Payable = new WH_Payable();
         string sql = "SELECT  WHP_ID,WHP_Code,WHP_SCode,WHP_SName,WHP_Period,WHP_LSum,WHP_CSum,WHP_CLeft,WHP_IsDone,Stat,WHP_IsDate,CreateDate,UpdateDate,DeleteDate,WHP_UCompany,WHP_UCompanyCode,WHP_broom FROM WH_Payable WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHP_ID=@WHP_ID ";
         idb.AddParameter("@WHP_ID", wHP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHP_ID"] != DBNull.Value) wH_Payable.WHP_ID = Convert.ToDecimal(dr["WHP_ID"]);
            if (dr["WHP_Code"] != DBNull.Value) wH_Payable.WHP_Code = Convert.ToString(dr["WHP_Code"]);
            if (dr["WHP_SCode"] != DBNull.Value) wH_Payable.WHP_SCode = Convert.ToString(dr["WHP_SCode"]);
            if (dr["WHP_SName"] != DBNull.Value) wH_Payable.WHP_SName = Convert.ToString(dr["WHP_SName"]);
            if (dr["WHP_Period"] != DBNull.Value) wH_Payable.WHP_Period = Convert.ToString(dr["WHP_Period"]);
            if (dr["WHP_LSum"] != DBNull.Value) wH_Payable.WHP_LSum = Convert.ToDecimal(dr["WHP_LSum"]);
            if (dr["WHP_CSum"] != DBNull.Value) wH_Payable.WHP_CSum = Convert.ToDecimal(dr["WHP_CSum"]);
            if (dr["WHP_CLeft"] != DBNull.Value) wH_Payable.WHP_CLeft = Convert.ToDecimal(dr["WHP_CLeft"]);
            if (dr["WHP_IsDone"] != DBNull.Value) wH_Payable.WHP_IsDone = Convert.ToInt32(dr["WHP_IsDone"]);
            if (dr["Stat"] != DBNull.Value) wH_Payable.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHP_IsDate"] != DBNull.Value) wH_Payable.WHP_IsDate = Convert.ToDateTime(dr["WHP_IsDate"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Payable.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Payable.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Payable.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHP_UCompany"] != DBNull.Value) wH_Payable.WHP_UCompany = Convert.ToString(dr["WHP_UCompany"]);
            if (dr["WHP_UCompanyCode"] != DBNull.Value) wH_Payable.WHP_UCompanyCode = Convert.ToString(dr["WHP_UCompanyCode"]);
            if (dr["WHP_broom"] != DBNull.Value) wH_Payable.WHP_broom = Convert.ToDecimal(dr["WHP_broom"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Payable;
      }
      /// <summary>
      /// 获取指定的应付单 WH_Payable对象集合
      /// </summary>
      public List<WH_Payable> GetListByWhere(string strCondition)
      {
         List<WH_Payable> ret = new List<WH_Payable>();
         string sql = "SELECT  WHP_ID,WHP_Code,WHP_SCode,WHP_SName,WHP_Period,WHP_LSum,WHP_CSum,WHP_CLeft,WHP_IsDone,Stat,WHP_IsDate,CreateDate,UpdateDate,DeleteDate,WHP_UCompany,WHP_UCompanyCode,WHP_broom FROM WH_Payable WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Payable wH_Payable = new WH_Payable();
            if (dr["WHP_ID"] != DBNull.Value) wH_Payable.WHP_ID = Convert.ToDecimal(dr["WHP_ID"]);
            if (dr["WHP_Code"] != DBNull.Value) wH_Payable.WHP_Code = Convert.ToString(dr["WHP_Code"]);
            if (dr["WHP_SCode"] != DBNull.Value) wH_Payable.WHP_SCode = Convert.ToString(dr["WHP_SCode"]);
            if (dr["WHP_SName"] != DBNull.Value) wH_Payable.WHP_SName = Convert.ToString(dr["WHP_SName"]);
            if (dr["WHP_Period"] != DBNull.Value) wH_Payable.WHP_Period = Convert.ToString(dr["WHP_Period"]);
            if (dr["WHP_LSum"] != DBNull.Value) wH_Payable.WHP_LSum = Convert.ToDecimal(dr["WHP_LSum"]);
            if (dr["WHP_CSum"] != DBNull.Value) wH_Payable.WHP_CSum = Convert.ToDecimal(dr["WHP_CSum"]);
            if (dr["WHP_CLeft"] != DBNull.Value) wH_Payable.WHP_CLeft = Convert.ToDecimal(dr["WHP_CLeft"]);
            if (dr["WHP_IsDone"] != DBNull.Value) wH_Payable.WHP_IsDone = Convert.ToInt32(dr["WHP_IsDone"]);
            if (dr["Stat"] != DBNull.Value) wH_Payable.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHP_IsDate"] != DBNull.Value) wH_Payable.WHP_IsDate = Convert.ToDateTime(dr["WHP_IsDate"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Payable.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Payable.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Payable.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHP_UCompany"] != DBNull.Value) wH_Payable.WHP_UCompany = Convert.ToString(dr["WHP_UCompany"]);
            if (dr["WHP_UCompanyCode"] != DBNull.Value) wH_Payable.WHP_UCompanyCode = Convert.ToString(dr["WHP_UCompanyCode"]);
            if (dr["WHP_broom"] != DBNull.Value) wH_Payable.WHP_broom = Convert.ToDecimal(dr["WHP_broom"]);
            ret.Add(wH_Payable);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的应付单 WH_Payable对象(即:一条记录
      /// </summary>
      public List<WH_Payable> GetAll()
      {
         List<WH_Payable> ret = new List<WH_Payable>();
         string sql = "SELECT  WHP_ID,WHP_Code,WHP_SCode,WHP_SName,WHP_Period,WHP_LSum,WHP_CSum,WHP_CLeft,WHP_IsDone,Stat,WHP_IsDate,CreateDate,UpdateDate,DeleteDate,WHP_UCompany,WHP_UCompanyCode,WHP_broom FROM WH_Payable where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Payable wH_Payable = new WH_Payable();
            if (dr["WHP_ID"] != DBNull.Value) wH_Payable.WHP_ID = Convert.ToDecimal(dr["WHP_ID"]);
            if (dr["WHP_Code"] != DBNull.Value) wH_Payable.WHP_Code = Convert.ToString(dr["WHP_Code"]);
            if (dr["WHP_SCode"] != DBNull.Value) wH_Payable.WHP_SCode = Convert.ToString(dr["WHP_SCode"]);
            if (dr["WHP_SName"] != DBNull.Value) wH_Payable.WHP_SName = Convert.ToString(dr["WHP_SName"]);
            if (dr["WHP_Period"] != DBNull.Value) wH_Payable.WHP_Period = Convert.ToString(dr["WHP_Period"]);
            if (dr["WHP_LSum"] != DBNull.Value) wH_Payable.WHP_LSum = Convert.ToDecimal(dr["WHP_LSum"]);
            if (dr["WHP_CSum"] != DBNull.Value) wH_Payable.WHP_CSum = Convert.ToDecimal(dr["WHP_CSum"]);
            if (dr["WHP_CLeft"] != DBNull.Value) wH_Payable.WHP_CLeft = Convert.ToDecimal(dr["WHP_CLeft"]);
            if (dr["WHP_IsDone"] != DBNull.Value) wH_Payable.WHP_IsDone = Convert.ToInt32(dr["WHP_IsDone"]);
            if (dr["Stat"] != DBNull.Value) wH_Payable.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHP_IsDate"] != DBNull.Value) wH_Payable.WHP_IsDate = Convert.ToDateTime(dr["WHP_IsDate"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Payable.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Payable.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Payable.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHP_UCompany"] != DBNull.Value) wH_Payable.WHP_UCompany = Convert.ToString(dr["WHP_UCompany"]);
            if (dr["WHP_UCompanyCode"] != DBNull.Value) wH_Payable.WHP_UCompanyCode = Convert.ToString(dr["WHP_UCompanyCode"]);
            if (dr["WHP_broom"] != DBNull.Value) wH_Payable.WHP_broom = Convert.ToDecimal(dr["WHP_broom"]);
            ret.Add(wH_Payable);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
