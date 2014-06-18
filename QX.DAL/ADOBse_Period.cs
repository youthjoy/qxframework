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
   /// 系统账期
   /// </summary>
   [Serializable]
   public partial class ADOBse_Period
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加系统账期 Bse_Period对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Period bse_Period)
      {
         string sql = "INSERT INTO Bse_Period (BP_Year,BP_Month,BP_Code,BP_Start,BP_End,BP_IsCurrent,BP_Company,Stat,BP_CompanyCode,CreateDate,UpdateDate,DeleteDate) VALUES (@BP_Year,@BP_Month,@BP_Code,@BP_Start,@BP_End,@BP_IsCurrent,@BP_Company,@Stat,@BP_CompanyCode,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(bse_Period.BP_Year))
         {
            idb.AddParameter("@BP_Year", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Year", bse_Period.BP_Year);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_Month))
         {
            idb.AddParameter("@BP_Month", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Month", bse_Period.BP_Month);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_Code))
         {
            idb.AddParameter("@BP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Code", bse_Period.BP_Code);
         }
         if (bse_Period.BP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@BP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Start", bse_Period.BP_Start);
         }
         if (bse_Period.BP_End == DateTime.MinValue)
         {
            idb.AddParameter("@BP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_End", bse_Period.BP_End);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_IsCurrent))
         {
            idb.AddParameter("@BP_IsCurrent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_IsCurrent", bse_Period.BP_IsCurrent);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_Company))
         {
            idb.AddParameter("@BP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Company", bse_Period.BP_Company);
         }
         if (bse_Period.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Period.Stat);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_CompanyCode))
         {
            idb.AddParameter("@BP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_CompanyCode", bse_Period.BP_CompanyCode);
         }
         if (bse_Period.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Period.CreateDate);
         }
         if (bse_Period.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Period.UpdateDate);
         }
         if (bse_Period.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Period.DeleteDate);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加系统账期 Bse_Period对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Period bse_Period)
      {
         string sql = "INSERT INTO Bse_Period (BP_Year,BP_Month,BP_Code,BP_Start,BP_End,BP_IsCurrent,BP_Company,Stat,BP_CompanyCode,CreateDate,UpdateDate,DeleteDate) VALUES (@BP_Year,@BP_Month,@BP_Code,@BP_Start,@BP_End,@BP_IsCurrent,@BP_Company,@Stat,@BP_CompanyCode,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Period.BP_Year))
         {
            idb.AddParameter("@BP_Year", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Year", bse_Period.BP_Year);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_Month))
         {
            idb.AddParameter("@BP_Month", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Month", bse_Period.BP_Month);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_Code))
         {
            idb.AddParameter("@BP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Code", bse_Period.BP_Code);
         }
         if (bse_Period.BP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@BP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Start", bse_Period.BP_Start);
         }
         if (bse_Period.BP_End == DateTime.MinValue)
         {
            idb.AddParameter("@BP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_End", bse_Period.BP_End);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_IsCurrent))
         {
            idb.AddParameter("@BP_IsCurrent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_IsCurrent", bse_Period.BP_IsCurrent);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_Company))
         {
            idb.AddParameter("@BP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Company", bse_Period.BP_Company);
         }
         if (bse_Period.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Period.Stat);
         }
         if (string.IsNullOrEmpty(bse_Period.BP_CompanyCode))
         {
            idb.AddParameter("@BP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_CompanyCode", bse_Period.BP_CompanyCode);
         }
         if (bse_Period.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Period.CreateDate);
         }
         if (bse_Period.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Period.UpdateDate);
         }
         if (bse_Period.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Period.DeleteDate);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新系统账期 Bse_Period对象(即:一条记录
      /// </summary>
      public int Update(Bse_Period bse_Period)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Period       SET ");
            if(bse_Period.BP_Year_IsChanged){sbParameter.Append("BP_Year=@BP_Year, ");}
      if(bse_Period.BP_Month_IsChanged){sbParameter.Append("BP_Month=@BP_Month, ");}
      if(bse_Period.BP_Code_IsChanged){sbParameter.Append("BP_Code=@BP_Code, ");}
      if(bse_Period.BP_Start_IsChanged){sbParameter.Append("BP_Start=@BP_Start, ");}
      if(bse_Period.BP_End_IsChanged){sbParameter.Append("BP_End=@BP_End, ");}
      if(bse_Period.BP_IsCurrent_IsChanged){sbParameter.Append("BP_IsCurrent=@BP_IsCurrent, ");}
      if(bse_Period.BP_Company_IsChanged){sbParameter.Append("BP_Company=@BP_Company, ");}
      if(bse_Period.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Period.BP_CompanyCode_IsChanged){sbParameter.Append("BP_CompanyCode=@BP_CompanyCode, ");}
      if(bse_Period.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bse_Period.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bse_Period.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and BP_ID=@BP_ID; " );
      string sql=sb.ToString();
         if(bse_Period.BP_Year_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Period.BP_Year))
         {
            idb.AddParameter("@BP_Year", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Year", bse_Period.BP_Year);
         }
          }
         if(bse_Period.BP_Month_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Period.BP_Month))
         {
            idb.AddParameter("@BP_Month", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Month", bse_Period.BP_Month);
         }
          }
         if(bse_Period.BP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Period.BP_Code))
         {
            idb.AddParameter("@BP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Code", bse_Period.BP_Code);
         }
          }
         if(bse_Period.BP_Start_IsChanged)
         {
         if (bse_Period.BP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@BP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Start", bse_Period.BP_Start);
         }
          }
         if(bse_Period.BP_End_IsChanged)
         {
         if (bse_Period.BP_End == DateTime.MinValue)
         {
            idb.AddParameter("@BP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_End", bse_Period.BP_End);
         }
          }
         if(bse_Period.BP_IsCurrent_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Period.BP_IsCurrent))
         {
            idb.AddParameter("@BP_IsCurrent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_IsCurrent", bse_Period.BP_IsCurrent);
         }
          }
         if(bse_Period.BP_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Period.BP_Company))
         {
            idb.AddParameter("@BP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_Company", bse_Period.BP_Company);
         }
          }
         if(bse_Period.Stat_IsChanged)
         {
         if (bse_Period.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Period.Stat);
         }
          }
         if(bse_Period.BP_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Period.BP_CompanyCode))
         {
            idb.AddParameter("@BP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BP_CompanyCode", bse_Period.BP_CompanyCode);
         }
          }
         if(bse_Period.CreateDate_IsChanged)
         {
         if (bse_Period.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Period.CreateDate);
         }
          }
         if(bse_Period.UpdateDate_IsChanged)
         {
         if (bse_Period.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Period.UpdateDate);
         }
          }
         if(bse_Period.DeleteDate_IsChanged)
         {
         if (bse_Period.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Period.DeleteDate);
         }
          }

         idb.AddParameter("@BP_ID", bse_Period.BP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除系统账期 Bse_Period对象(即:一条记录
      /// </summary>
      public int Delete(decimal bP_ID)
      {
         string sql = "DELETE Bse_Period WHERE 1=1  AND BP_ID=@BP_ID ";
         idb.AddParameter("@BP_ID", bP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的系统账期 Bse_Period对象(即:一条记录
      /// </summary>
      public Bse_Period GetByKey(decimal bP_ID)
      {
         Bse_Period bse_Period = new Bse_Period();
         string sql = "SELECT  BP_ID,BP_Year,BP_Month,BP_Code,BP_Start,BP_End,BP_IsCurrent,BP_Company,Stat,BP_CompanyCode,CreateDate,UpdateDate,DeleteDate FROM Bse_Period WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND BP_ID=@BP_ID ";
         idb.AddParameter("@BP_ID", bP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["BP_ID"] != DBNull.Value) bse_Period.BP_ID = Convert.ToDecimal(dr["BP_ID"]);
            if (dr["BP_Year"] != DBNull.Value) bse_Period.BP_Year = Convert.ToString(dr["BP_Year"]);
            if (dr["BP_Month"] != DBNull.Value) bse_Period.BP_Month = Convert.ToString(dr["BP_Month"]);
            if (dr["BP_Code"] != DBNull.Value) bse_Period.BP_Code = Convert.ToString(dr["BP_Code"]);
            if (dr["BP_Start"] != DBNull.Value) bse_Period.BP_Start = Convert.ToDateTime(dr["BP_Start"]);
            if (dr["BP_End"] != DBNull.Value) bse_Period.BP_End = Convert.ToDateTime(dr["BP_End"]);
            if (dr["BP_IsCurrent"] != DBNull.Value) bse_Period.BP_IsCurrent = Convert.ToString(dr["BP_IsCurrent"]);
            if (dr["BP_Company"] != DBNull.Value) bse_Period.BP_Company = Convert.ToString(dr["BP_Company"]);
            if (dr["Stat"] != DBNull.Value) bse_Period.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["BP_CompanyCode"] != DBNull.Value) bse_Period.BP_CompanyCode = Convert.ToString(dr["BP_CompanyCode"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Period.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Period.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Period.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Period;
      }
      /// <summary>
      /// 获取指定的系统账期 Bse_Period对象集合
      /// </summary>
      public List<Bse_Period> GetListByWhere(string strCondition)
      {
         List<Bse_Period> ret = new List<Bse_Period>();
         string sql = "SELECT  BP_ID,BP_Year,BP_Month,BP_Code,BP_Start,BP_End,BP_IsCurrent,BP_Company,Stat,BP_CompanyCode,CreateDate,UpdateDate,DeleteDate FROM Bse_Period WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY BP_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Period bse_Period = new Bse_Period();
            if (dr["BP_ID"] != DBNull.Value) bse_Period.BP_ID = Convert.ToDecimal(dr["BP_ID"]);
            if (dr["BP_Year"] != DBNull.Value) bse_Period.BP_Year = Convert.ToString(dr["BP_Year"]);
            if (dr["BP_Month"] != DBNull.Value) bse_Period.BP_Month = Convert.ToString(dr["BP_Month"]);
            if (dr["BP_Code"] != DBNull.Value) bse_Period.BP_Code = Convert.ToString(dr["BP_Code"]);
            if (dr["BP_Start"] != DBNull.Value) bse_Period.BP_Start = Convert.ToDateTime(dr["BP_Start"]);
            if (dr["BP_End"] != DBNull.Value) bse_Period.BP_End = Convert.ToDateTime(dr["BP_End"]);
            if (dr["BP_IsCurrent"] != DBNull.Value) bse_Period.BP_IsCurrent = Convert.ToString(dr["BP_IsCurrent"]);
            if (dr["BP_Company"] != DBNull.Value) bse_Period.BP_Company = Convert.ToString(dr["BP_Company"]);
            if (dr["Stat"] != DBNull.Value) bse_Period.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["BP_CompanyCode"] != DBNull.Value) bse_Period.BP_CompanyCode = Convert.ToString(dr["BP_CompanyCode"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Period.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Period.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Period.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bse_Period);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的系统账期 Bse_Period对象(即:一条记录
      /// </summary>
      public List<Bse_Period> GetAll()
      {
         List<Bse_Period> ret = new List<Bse_Period>();
         string sql = "SELECT  BP_ID,BP_Year,BP_Month,BP_Code,BP_Start,BP_End,BP_IsCurrent,BP_Company,Stat,BP_CompanyCode,CreateDate,UpdateDate,DeleteDate FROM Bse_Period where 1=1 AND ((Stat is null) or (Stat=0) ) order by BP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Period bse_Period = new Bse_Period();
            if (dr["BP_ID"] != DBNull.Value) bse_Period.BP_ID = Convert.ToDecimal(dr["BP_ID"]);
            if (dr["BP_Year"] != DBNull.Value) bse_Period.BP_Year = Convert.ToString(dr["BP_Year"]);
            if (dr["BP_Month"] != DBNull.Value) bse_Period.BP_Month = Convert.ToString(dr["BP_Month"]);
            if (dr["BP_Code"] != DBNull.Value) bse_Period.BP_Code = Convert.ToString(dr["BP_Code"]);
            if (dr["BP_Start"] != DBNull.Value) bse_Period.BP_Start = Convert.ToDateTime(dr["BP_Start"]);
            if (dr["BP_End"] != DBNull.Value) bse_Period.BP_End = Convert.ToDateTime(dr["BP_End"]);
            if (dr["BP_IsCurrent"] != DBNull.Value) bse_Period.BP_IsCurrent = Convert.ToString(dr["BP_IsCurrent"]);
            if (dr["BP_Company"] != DBNull.Value) bse_Period.BP_Company = Convert.ToString(dr["BP_Company"]);
            if (dr["Stat"] != DBNull.Value) bse_Period.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["BP_CompanyCode"] != DBNull.Value) bse_Period.BP_CompanyCode = Convert.ToString(dr["BP_CompanyCode"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Period.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Period.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Period.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bse_Period);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
