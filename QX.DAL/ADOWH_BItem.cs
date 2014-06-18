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
   /// 结算单物料明细
   /// </summary>
   [Serializable]
   public partial class ADOWH_BItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加结算单物料明细 WH_BItem对象(即:一条记录)
      /// </summary>
      public int Add(WH_BItem wH_BItem)
      {
         string sql = "INSERT INTO WH_BItem (SBI_SCode,SBI_MCode,SBI_Period,SBI_MName,SBI_MSpec,SBI_Sum,SBI_Num,SBI_RNum,SBI_RSum,SBI_Unit,Stat,SBI_WHBCode,CreateDate,UpdateDate,DeleteDate,SBI_Tranfee,SBI_CompanyName,SBI_Company) VALUES (@SBI_SCode,@SBI_MCode,@SBI_Period,@SBI_MName,@SBI_MSpec,@SBI_Sum,@SBI_Num,@SBI_RNum,@SBI_RSum,@SBI_Unit,@Stat,@SBI_WHBCode,@CreateDate,@UpdateDate,@DeleteDate,@SBI_Tranfee,@SBI_CompanyName,@SBI_Company)";
         if (string.IsNullOrEmpty(wH_BItem.SBI_SCode))
         {
            idb.AddParameter("@SBI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_SCode", wH_BItem.SBI_SCode);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_MCode))
         {
            idb.AddParameter("@SBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MCode", wH_BItem.SBI_MCode);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_Period))
         {
            idb.AddParameter("@SBI_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Period", wH_BItem.SBI_Period);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_MName))
         {
            idb.AddParameter("@SBI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MName", wH_BItem.SBI_MName);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_MSpec))
         {
            idb.AddParameter("@SBI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MSpec", wH_BItem.SBI_MSpec);
         }
         if (wH_BItem.SBI_Sum == 0)
         {
            idb.AddParameter("@SBI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Sum", wH_BItem.SBI_Sum);
         }
         if (wH_BItem.SBI_Num == 0)
         {
            idb.AddParameter("@SBI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Num", wH_BItem.SBI_Num);
         }
         if (wH_BItem.SBI_RNum == 0)
         {
            idb.AddParameter("@SBI_RNum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_RNum", wH_BItem.SBI_RNum);
         }
         if (wH_BItem.SBI_RSum == 0)
         {
            idb.AddParameter("@SBI_RSum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_RSum", wH_BItem.SBI_RSum);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_Unit))
         {
            idb.AddParameter("@SBI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Unit", wH_BItem.SBI_Unit);
         }
         if (wH_BItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BItem.Stat);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_WHBCode))
         {
            idb.AddParameter("@SBI_WHBCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_WHBCode", wH_BItem.SBI_WHBCode);
         }
         if (wH_BItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BItem.CreateDate);
         }
         if (wH_BItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BItem.UpdateDate);
         }
         if (wH_BItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BItem.DeleteDate);
         }
         if (wH_BItem.SBI_Tranfee == 0)
         {
            idb.AddParameter("@SBI_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Tranfee", wH_BItem.SBI_Tranfee);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_CompanyName))
         {
            idb.AddParameter("@SBI_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_CompanyName", wH_BItem.SBI_CompanyName);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_Company))
         {
            idb.AddParameter("@SBI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Company", wH_BItem.SBI_Company);
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
      /// 添加结算单物料明细 WH_BItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_BItem wH_BItem)
      {
         string sql = "INSERT INTO WH_BItem (SBI_SCode,SBI_MCode,SBI_Period,SBI_MName,SBI_MSpec,SBI_Sum,SBI_Num,SBI_RNum,SBI_RSum,SBI_Unit,Stat,SBI_WHBCode,CreateDate,UpdateDate,DeleteDate,SBI_Tranfee,SBI_CompanyName,SBI_Company) VALUES (@SBI_SCode,@SBI_MCode,@SBI_Period,@SBI_MName,@SBI_MSpec,@SBI_Sum,@SBI_Num,@SBI_RNum,@SBI_RSum,@SBI_Unit,@Stat,@SBI_WHBCode,@CreateDate,@UpdateDate,@DeleteDate,@SBI_Tranfee,@SBI_CompanyName,@SBI_Company);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_BItem.SBI_SCode))
         {
            idb.AddParameter("@SBI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_SCode", wH_BItem.SBI_SCode);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_MCode))
         {
            idb.AddParameter("@SBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MCode", wH_BItem.SBI_MCode);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_Period))
         {
            idb.AddParameter("@SBI_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Period", wH_BItem.SBI_Period);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_MName))
         {
            idb.AddParameter("@SBI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MName", wH_BItem.SBI_MName);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_MSpec))
         {
            idb.AddParameter("@SBI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MSpec", wH_BItem.SBI_MSpec);
         }
         if (wH_BItem.SBI_Sum == 0)
         {
            idb.AddParameter("@SBI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Sum", wH_BItem.SBI_Sum);
         }
         if (wH_BItem.SBI_Num == 0)
         {
            idb.AddParameter("@SBI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Num", wH_BItem.SBI_Num);
         }
         if (wH_BItem.SBI_RNum == 0)
         {
            idb.AddParameter("@SBI_RNum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_RNum", wH_BItem.SBI_RNum);
         }
         if (wH_BItem.SBI_RSum == 0)
         {
            idb.AddParameter("@SBI_RSum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_RSum", wH_BItem.SBI_RSum);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_Unit))
         {
            idb.AddParameter("@SBI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Unit", wH_BItem.SBI_Unit);
         }
         if (wH_BItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BItem.Stat);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_WHBCode))
         {
            idb.AddParameter("@SBI_WHBCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_WHBCode", wH_BItem.SBI_WHBCode);
         }
         if (wH_BItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BItem.CreateDate);
         }
         if (wH_BItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BItem.UpdateDate);
         }
         if (wH_BItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BItem.DeleteDate);
         }
         if (wH_BItem.SBI_Tranfee == 0)
         {
            idb.AddParameter("@SBI_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Tranfee", wH_BItem.SBI_Tranfee);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_CompanyName))
         {
            idb.AddParameter("@SBI_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_CompanyName", wH_BItem.SBI_CompanyName);
         }
         if (string.IsNullOrEmpty(wH_BItem.SBI_Company))
         {
            idb.AddParameter("@SBI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Company", wH_BItem.SBI_Company);
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
      /// 更新结算单物料明细 WH_BItem对象(即:一条记录
      /// </summary>
      public int Update(WH_BItem wH_BItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_BItem       SET ");
            if(wH_BItem.SBI_SCode_IsChanged){sbParameter.Append("SBI_SCode=@SBI_SCode, ");}
      if(wH_BItem.SBI_MCode_IsChanged){sbParameter.Append("SBI_MCode=@SBI_MCode, ");}
      if(wH_BItem.SBI_Period_IsChanged){sbParameter.Append("SBI_Period=@SBI_Period, ");}
      if(wH_BItem.SBI_MName_IsChanged){sbParameter.Append("SBI_MName=@SBI_MName, ");}
      if(wH_BItem.SBI_MSpec_IsChanged){sbParameter.Append("SBI_MSpec=@SBI_MSpec, ");}
      if(wH_BItem.SBI_Sum_IsChanged){sbParameter.Append("SBI_Sum=@SBI_Sum, ");}
      if(wH_BItem.SBI_Num_IsChanged){sbParameter.Append("SBI_Num=@SBI_Num, ");}
      if(wH_BItem.SBI_RNum_IsChanged){sbParameter.Append("SBI_RNum=@SBI_RNum, ");}
      if(wH_BItem.SBI_RSum_IsChanged){sbParameter.Append("SBI_RSum=@SBI_RSum, ");}
      if(wH_BItem.SBI_Unit_IsChanged){sbParameter.Append("SBI_Unit=@SBI_Unit, ");}
      if(wH_BItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_BItem.SBI_WHBCode_IsChanged){sbParameter.Append("SBI_WHBCode=@SBI_WHBCode, ");}
      if(wH_BItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_BItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_BItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_BItem.SBI_Tranfee_IsChanged){sbParameter.Append("SBI_Tranfee=@SBI_Tranfee, ");}
      if(wH_BItem.SBI_CompanyName_IsChanged){sbParameter.Append("SBI_CompanyName=@SBI_CompanyName, ");}
      if(wH_BItem.SBI_Company_IsChanged){sbParameter.Append("SBI_Company=@SBI_Company ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SBI_ID=@SBI_ID; " );
      string sql=sb.ToString();
         if(wH_BItem.SBI_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_SCode))
         {
            idb.AddParameter("@SBI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_SCode", wH_BItem.SBI_SCode);
         }
          }
         if(wH_BItem.SBI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_MCode))
         {
            idb.AddParameter("@SBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MCode", wH_BItem.SBI_MCode);
         }
          }
         if(wH_BItem.SBI_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_Period))
         {
            idb.AddParameter("@SBI_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Period", wH_BItem.SBI_Period);
         }
          }
         if(wH_BItem.SBI_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_MName))
         {
            idb.AddParameter("@SBI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MName", wH_BItem.SBI_MName);
         }
          }
         if(wH_BItem.SBI_MSpec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_MSpec))
         {
            idb.AddParameter("@SBI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_MSpec", wH_BItem.SBI_MSpec);
         }
          }
         if(wH_BItem.SBI_Sum_IsChanged)
         {
         if (wH_BItem.SBI_Sum == 0)
         {
            idb.AddParameter("@SBI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Sum", wH_BItem.SBI_Sum);
         }
          }
         if(wH_BItem.SBI_Num_IsChanged)
         {
         if (wH_BItem.SBI_Num == 0)
         {
            idb.AddParameter("@SBI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Num", wH_BItem.SBI_Num);
         }
          }
         if(wH_BItem.SBI_RNum_IsChanged)
         {
         if (wH_BItem.SBI_RNum == 0)
         {
            idb.AddParameter("@SBI_RNum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_RNum", wH_BItem.SBI_RNum);
         }
          }
         if(wH_BItem.SBI_RSum_IsChanged)
         {
         if (wH_BItem.SBI_RSum == 0)
         {
            idb.AddParameter("@SBI_RSum", 0);
         }
         else
         {
            idb.AddParameter("@SBI_RSum", wH_BItem.SBI_RSum);
         }
          }
         if(wH_BItem.SBI_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_Unit))
         {
            idb.AddParameter("@SBI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Unit", wH_BItem.SBI_Unit);
         }
          }
         if(wH_BItem.Stat_IsChanged)
         {
         if (wH_BItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BItem.Stat);
         }
          }
         if(wH_BItem.SBI_WHBCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_WHBCode))
         {
            idb.AddParameter("@SBI_WHBCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_WHBCode", wH_BItem.SBI_WHBCode);
         }
          }
         if(wH_BItem.CreateDate_IsChanged)
         {
         if (wH_BItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BItem.CreateDate);
         }
          }
         if(wH_BItem.UpdateDate_IsChanged)
         {
         if (wH_BItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BItem.UpdateDate);
         }
          }
         if(wH_BItem.DeleteDate_IsChanged)
         {
         if (wH_BItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BItem.DeleteDate);
         }
          }
         if(wH_BItem.SBI_Tranfee_IsChanged)
         {
         if (wH_BItem.SBI_Tranfee == 0)
         {
            idb.AddParameter("@SBI_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@SBI_Tranfee", wH_BItem.SBI_Tranfee);
         }
          }
         if(wH_BItem.SBI_CompanyName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_CompanyName))
         {
            idb.AddParameter("@SBI_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_CompanyName", wH_BItem.SBI_CompanyName);
         }
          }
         if(wH_BItem.SBI_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BItem.SBI_Company))
         {
            idb.AddParameter("@SBI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SBI_Company", wH_BItem.SBI_Company);
         }
          }

         idb.AddParameter("@SBI_ID", wH_BItem.SBI_ID);

           
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
      /// 删除结算单物料明细 WH_BItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal sBI_ID)
      {
         string sql = "DELETE WH_BItem WHERE 1=1  AND SBI_ID=@SBI_ID ";
         idb.AddParameter("@SBI_ID", sBI_ID);

           
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
      /// 获取指定的结算单物料明细 WH_BItem对象(即:一条记录
      /// </summary>
      public WH_BItem GetByKey(decimal sBI_ID)
      {
         WH_BItem wH_BItem = new WH_BItem();
         string sql = "SELECT  SBI_ID,SBI_SCode,SBI_MCode,SBI_Period,SBI_MName,SBI_MSpec,SBI_Sum,SBI_Num,SBI_RNum,SBI_RSum,SBI_Unit,Stat,SBI_WHBCode,CreateDate,UpdateDate,DeleteDate,SBI_Tranfee,SBI_CompanyName,SBI_Company FROM WH_BItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SBI_ID=@SBI_ID ";
         idb.AddParameter("@SBI_ID", sBI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SBI_ID"] != DBNull.Value) wH_BItem.SBI_ID = Convert.ToDecimal(dr["SBI_ID"]);
            if (dr["SBI_SCode"] != DBNull.Value) wH_BItem.SBI_SCode = Convert.ToString(dr["SBI_SCode"]);
            if (dr["SBI_MCode"] != DBNull.Value) wH_BItem.SBI_MCode = Convert.ToString(dr["SBI_MCode"]);
            if (dr["SBI_Period"] != DBNull.Value) wH_BItem.SBI_Period = Convert.ToString(dr["SBI_Period"]);
            if (dr["SBI_MName"] != DBNull.Value) wH_BItem.SBI_MName = Convert.ToString(dr["SBI_MName"]);
            if (dr["SBI_MSpec"] != DBNull.Value) wH_BItem.SBI_MSpec = Convert.ToString(dr["SBI_MSpec"]);
            if (dr["SBI_Sum"] != DBNull.Value) wH_BItem.SBI_Sum = Convert.ToDecimal(dr["SBI_Sum"]);
            if (dr["SBI_Num"] != DBNull.Value) wH_BItem.SBI_Num = Convert.ToDecimal(dr["SBI_Num"]);
            if (dr["SBI_RNum"] != DBNull.Value) wH_BItem.SBI_RNum = Convert.ToDecimal(dr["SBI_RNum"]);
            if (dr["SBI_RSum"] != DBNull.Value) wH_BItem.SBI_RSum = Convert.ToDecimal(dr["SBI_RSum"]);
            if (dr["SBI_Unit"] != DBNull.Value) wH_BItem.SBI_Unit = Convert.ToString(dr["SBI_Unit"]);
            if (dr["Stat"] != DBNull.Value) wH_BItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SBI_WHBCode"] != DBNull.Value) wH_BItem.SBI_WHBCode = Convert.ToString(dr["SBI_WHBCode"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SBI_Tranfee"] != DBNull.Value) wH_BItem.SBI_Tranfee = Convert.ToDecimal(dr["SBI_Tranfee"]);
            if (dr["SBI_CompanyName"] != DBNull.Value) wH_BItem.SBI_CompanyName = Convert.ToString(dr["SBI_CompanyName"]);
            if (dr["SBI_Company"] != DBNull.Value) wH_BItem.SBI_Company = Convert.ToString(dr["SBI_Company"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_BItem;
      }
      /// <summary>
      /// 获取指定的结算单物料明细 WH_BItem对象集合
      /// </summary>
      public List<WH_BItem> GetListByWhere(string strCondition)
      {
         List<WH_BItem> ret = new List<WH_BItem>();
         string sql = "SELECT  SBI_ID,SBI_SCode,SBI_MCode,SBI_Period,SBI_MName,SBI_MSpec,SBI_Sum,SBI_Num,SBI_RNum,SBI_RSum,SBI_Unit,Stat,SBI_WHBCode,CreateDate,UpdateDate,DeleteDate,SBI_Tranfee,SBI_CompanyName,SBI_Company FROM WH_BItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_BItem wH_BItem = new WH_BItem();
            if (dr["SBI_ID"] != DBNull.Value) wH_BItem.SBI_ID = Convert.ToDecimal(dr["SBI_ID"]);
            if (dr["SBI_SCode"] != DBNull.Value) wH_BItem.SBI_SCode = Convert.ToString(dr["SBI_SCode"]);
            if (dr["SBI_MCode"] != DBNull.Value) wH_BItem.SBI_MCode = Convert.ToString(dr["SBI_MCode"]);
            if (dr["SBI_Period"] != DBNull.Value) wH_BItem.SBI_Period = Convert.ToString(dr["SBI_Period"]);
            if (dr["SBI_MName"] != DBNull.Value) wH_BItem.SBI_MName = Convert.ToString(dr["SBI_MName"]);
            if (dr["SBI_MSpec"] != DBNull.Value) wH_BItem.SBI_MSpec = Convert.ToString(dr["SBI_MSpec"]);
            if (dr["SBI_Sum"] != DBNull.Value) wH_BItem.SBI_Sum = Convert.ToDecimal(dr["SBI_Sum"]);
            if (dr["SBI_Num"] != DBNull.Value) wH_BItem.SBI_Num = Convert.ToDecimal(dr["SBI_Num"]);
            if (dr["SBI_RNum"] != DBNull.Value) wH_BItem.SBI_RNum = Convert.ToDecimal(dr["SBI_RNum"]);
            if (dr["SBI_RSum"] != DBNull.Value) wH_BItem.SBI_RSum = Convert.ToDecimal(dr["SBI_RSum"]);
            if (dr["SBI_Unit"] != DBNull.Value) wH_BItem.SBI_Unit = Convert.ToString(dr["SBI_Unit"]);
            if (dr["Stat"] != DBNull.Value) wH_BItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SBI_WHBCode"] != DBNull.Value) wH_BItem.SBI_WHBCode = Convert.ToString(dr["SBI_WHBCode"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SBI_Tranfee"] != DBNull.Value) wH_BItem.SBI_Tranfee = Convert.ToDecimal(dr["SBI_Tranfee"]);
            if (dr["SBI_CompanyName"] != DBNull.Value) wH_BItem.SBI_CompanyName = Convert.ToString(dr["SBI_CompanyName"]);
            if (dr["SBI_Company"] != DBNull.Value) wH_BItem.SBI_Company = Convert.ToString(dr["SBI_Company"]);
            ret.Add(wH_BItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的结算单物料明细 WH_BItem对象(即:一条记录
      /// </summary>
      public List<WH_BItem> GetAll()
      {
         List<WH_BItem> ret = new List<WH_BItem>();
         string sql = "SELECT  SBI_ID,SBI_SCode,SBI_MCode,SBI_Period,SBI_MName,SBI_MSpec,SBI_Sum,SBI_Num,SBI_RNum,SBI_RSum,SBI_Unit,Stat,SBI_WHBCode,CreateDate,UpdateDate,DeleteDate,SBI_Tranfee,SBI_CompanyName,SBI_Company FROM WH_BItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by SBI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_BItem wH_BItem = new WH_BItem();
            if (dr["SBI_ID"] != DBNull.Value) wH_BItem.SBI_ID = Convert.ToDecimal(dr["SBI_ID"]);
            if (dr["SBI_SCode"] != DBNull.Value) wH_BItem.SBI_SCode = Convert.ToString(dr["SBI_SCode"]);
            if (dr["SBI_MCode"] != DBNull.Value) wH_BItem.SBI_MCode = Convert.ToString(dr["SBI_MCode"]);
            if (dr["SBI_Period"] != DBNull.Value) wH_BItem.SBI_Period = Convert.ToString(dr["SBI_Period"]);
            if (dr["SBI_MName"] != DBNull.Value) wH_BItem.SBI_MName = Convert.ToString(dr["SBI_MName"]);
            if (dr["SBI_MSpec"] != DBNull.Value) wH_BItem.SBI_MSpec = Convert.ToString(dr["SBI_MSpec"]);
            if (dr["SBI_Sum"] != DBNull.Value) wH_BItem.SBI_Sum = Convert.ToDecimal(dr["SBI_Sum"]);
            if (dr["SBI_Num"] != DBNull.Value) wH_BItem.SBI_Num = Convert.ToDecimal(dr["SBI_Num"]);
            if (dr["SBI_RNum"] != DBNull.Value) wH_BItem.SBI_RNum = Convert.ToDecimal(dr["SBI_RNum"]);
            if (dr["SBI_RSum"] != DBNull.Value) wH_BItem.SBI_RSum = Convert.ToDecimal(dr["SBI_RSum"]);
            if (dr["SBI_Unit"] != DBNull.Value) wH_BItem.SBI_Unit = Convert.ToString(dr["SBI_Unit"]);
            if (dr["Stat"] != DBNull.Value) wH_BItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SBI_WHBCode"] != DBNull.Value) wH_BItem.SBI_WHBCode = Convert.ToString(dr["SBI_WHBCode"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SBI_Tranfee"] != DBNull.Value) wH_BItem.SBI_Tranfee = Convert.ToDecimal(dr["SBI_Tranfee"]);
            if (dr["SBI_CompanyName"] != DBNull.Value) wH_BItem.SBI_CompanyName = Convert.ToString(dr["SBI_CompanyName"]);
            if (dr["SBI_Company"] != DBNull.Value) wH_BItem.SBI_Company = Convert.ToString(dr["SBI_Company"]);
            ret.Add(wH_BItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
