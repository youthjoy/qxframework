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
   /// 固定资产检修计划
   /// </summary>
   [Serializable]
   public partial class ADOAsset_MPlan
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加固定资产检修计划 Asset_MPlan对象(即:一条记录)
      /// </summary>
      public int Add(Asset_MPlan asset_MPlan)
      {
         string sql = "INSERT INTO Asset_MPlan (AMP_Code,AMP_Name,AMP_Stuff,AMP_Start,AMP_End,VerifyStuff,AuditStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMP_Type,AMP_Company,AMP_Dept) VALUES (@AMP_Code,@AMP_Name,@AMP_Stuff,@AMP_Start,@AMP_End,@VerifyStuff,@AuditStat,@VerifyDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditCurAudit,@AMP_Type,@AMP_Company,@AMP_Dept)";
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Code))
         {
            idb.AddParameter("@AMP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Code", asset_MPlan.AMP_Code);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Name))
         {
            idb.AddParameter("@AMP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Name", asset_MPlan.AMP_Name);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Stuff))
         {
            idb.AddParameter("@AMP_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Stuff", asset_MPlan.AMP_Stuff);
         }
         if (asset_MPlan.AMP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@AMP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Start", asset_MPlan.AMP_Start);
         }
         if (asset_MPlan.AMP_End == DateTime.MinValue)
         {
            idb.AddParameter("@AMP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_End", asset_MPlan.AMP_End);
         }
         if (string.IsNullOrEmpty(asset_MPlan.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", asset_MPlan.VerifyStuff);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_MPlan.AuditStat);
         }
         if (asset_MPlan.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", asset_MPlan.VerifyDate);
         }
         if (asset_MPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_MPlan.Stat);
         }
         if (asset_MPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_MPlan.CreateDate);
         }
         if (asset_MPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_MPlan.UpdateDate);
         }
         if (asset_MPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_MPlan.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_MPlan.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Type))
         {
            idb.AddParameter("@AMP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Type", asset_MPlan.AMP_Type);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Company))
         {
            idb.AddParameter("@AMP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Company", asset_MPlan.AMP_Company);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Dept))
         {
            idb.AddParameter("@AMP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Dept", asset_MPlan.AMP_Dept);
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
      /// 添加固定资产检修计划 Asset_MPlan对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Asset_MPlan asset_MPlan)
      {
         string sql = "INSERT INTO Asset_MPlan (AMP_Code,AMP_Name,AMP_Stuff,AMP_Start,AMP_End,VerifyStuff,AuditStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMP_Type,AMP_Company,AMP_Dept) VALUES (@AMP_Code,@AMP_Name,@AMP_Stuff,@AMP_Start,@AMP_End,@VerifyStuff,@AuditStat,@VerifyDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditCurAudit,@AMP_Type,@AMP_Company,@AMP_Dept);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Code))
         {
            idb.AddParameter("@AMP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Code", asset_MPlan.AMP_Code);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Name))
         {
            idb.AddParameter("@AMP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Name", asset_MPlan.AMP_Name);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Stuff))
         {
            idb.AddParameter("@AMP_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Stuff", asset_MPlan.AMP_Stuff);
         }
         if (asset_MPlan.AMP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@AMP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Start", asset_MPlan.AMP_Start);
         }
         if (asset_MPlan.AMP_End == DateTime.MinValue)
         {
            idb.AddParameter("@AMP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_End", asset_MPlan.AMP_End);
         }
         if (string.IsNullOrEmpty(asset_MPlan.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", asset_MPlan.VerifyStuff);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_MPlan.AuditStat);
         }
         if (asset_MPlan.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", asset_MPlan.VerifyDate);
         }
         if (asset_MPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_MPlan.Stat);
         }
         if (asset_MPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_MPlan.CreateDate);
         }
         if (asset_MPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_MPlan.UpdateDate);
         }
         if (asset_MPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_MPlan.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_MPlan.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Type))
         {
            idb.AddParameter("@AMP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Type", asset_MPlan.AMP_Type);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Company))
         {
            idb.AddParameter("@AMP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Company", asset_MPlan.AMP_Company);
         }
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Dept))
         {
            idb.AddParameter("@AMP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Dept", asset_MPlan.AMP_Dept);
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
      /// 更新固定资产检修计划 Asset_MPlan对象(即:一条记录
      /// </summary>
      public int Update(Asset_MPlan asset_MPlan)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Asset_MPlan       SET ");
            if(asset_MPlan.AMP_Code_IsChanged){sbParameter.Append("AMP_Code=@AMP_Code, ");}
      if(asset_MPlan.AMP_Name_IsChanged){sbParameter.Append("AMP_Name=@AMP_Name, ");}
      if(asset_MPlan.AMP_Stuff_IsChanged){sbParameter.Append("AMP_Stuff=@AMP_Stuff, ");}
      if(asset_MPlan.AMP_Start_IsChanged){sbParameter.Append("AMP_Start=@AMP_Start, ");}
      if(asset_MPlan.AMP_End_IsChanged){sbParameter.Append("AMP_End=@AMP_End, ");}
      if(asset_MPlan.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(asset_MPlan.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(asset_MPlan.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(asset_MPlan.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(asset_MPlan.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(asset_MPlan.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(asset_MPlan.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(asset_MPlan.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(asset_MPlan.AMP_Type_IsChanged){sbParameter.Append("AMP_Type=@AMP_Type, ");}
      if(asset_MPlan.AMP_Company_IsChanged){sbParameter.Append("AMP_Company=@AMP_Company, ");}
      if(asset_MPlan.AMP_Dept_IsChanged){sbParameter.Append("AMP_Dept=@AMP_Dept ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AMP_ID=@AMP_ID; " );
      string sql=sb.ToString();
         if(asset_MPlan.AMP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Code))
         {
            idb.AddParameter("@AMP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Code", asset_MPlan.AMP_Code);
         }
          }
         if(asset_MPlan.AMP_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Name))
         {
            idb.AddParameter("@AMP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Name", asset_MPlan.AMP_Name);
         }
          }
         if(asset_MPlan.AMP_Stuff_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Stuff))
         {
            idb.AddParameter("@AMP_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Stuff", asset_MPlan.AMP_Stuff);
         }
          }
         if(asset_MPlan.AMP_Start_IsChanged)
         {
         if (asset_MPlan.AMP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@AMP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Start", asset_MPlan.AMP_Start);
         }
          }
         if(asset_MPlan.AMP_End_IsChanged)
         {
         if (asset_MPlan.AMP_End == DateTime.MinValue)
         {
            idb.AddParameter("@AMP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_End", asset_MPlan.AMP_End);
         }
          }
         if(asset_MPlan.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", asset_MPlan.VerifyStuff);
         }
          }
         if(asset_MPlan.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_MPlan.AuditStat);
         }
          }
         if(asset_MPlan.VerifyDate_IsChanged)
         {
         if (asset_MPlan.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", asset_MPlan.VerifyDate);
         }
          }
         if(asset_MPlan.Stat_IsChanged)
         {
         if (asset_MPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_MPlan.Stat);
         }
          }
         if(asset_MPlan.CreateDate_IsChanged)
         {
         if (asset_MPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_MPlan.CreateDate);
         }
          }
         if(asset_MPlan.UpdateDate_IsChanged)
         {
         if (asset_MPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_MPlan.UpdateDate);
         }
          }
         if(asset_MPlan.DeleteDate_IsChanged)
         {
         if (asset_MPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_MPlan.DeleteDate);
         }
          }
         if(asset_MPlan.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_MPlan.AuditCurAudit);
         }
          }
         if(asset_MPlan.AMP_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Type))
         {
            idb.AddParameter("@AMP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Type", asset_MPlan.AMP_Type);
         }
          }
         if(asset_MPlan.AMP_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Company))
         {
            idb.AddParameter("@AMP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Company", asset_MPlan.AMP_Company);
         }
          }
         if(asset_MPlan.AMP_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MPlan.AMP_Dept))
         {
            idb.AddParameter("@AMP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMP_Dept", asset_MPlan.AMP_Dept);
         }
          }

         idb.AddParameter("@AMP_ID", asset_MPlan.AMP_ID);

           
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
      /// 删除固定资产检修计划 Asset_MPlan对象(即:一条记录
      /// </summary>
      public int Delete(decimal aMP_ID)
      {
         string sql = "DELETE Asset_MPlan WHERE 1=1  AND AMP_ID=@AMP_ID ";
         idb.AddParameter("@AMP_ID", aMP_ID);

           
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
      /// 获取指定的固定资产检修计划 Asset_MPlan对象(即:一条记录
      /// </summary>
      public Asset_MPlan GetByKey(decimal aMP_ID)
      {
         Asset_MPlan asset_MPlan = new Asset_MPlan();
         string sql = "SELECT  AMP_ID,AMP_Code,AMP_Name,AMP_Stuff,AMP_Start,AMP_End,VerifyStuff,AuditStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMP_Type,AMP_Company,AMP_Dept FROM Asset_MPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AMP_ID=@AMP_ID ";
         idb.AddParameter("@AMP_ID", aMP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AMP_ID"] != DBNull.Value) asset_MPlan.AMP_ID = Convert.ToDecimal(dr["AMP_ID"]);
            if (dr["AMP_Code"] != DBNull.Value) asset_MPlan.AMP_Code = Convert.ToString(dr["AMP_Code"]);
            if (dr["AMP_Name"] != DBNull.Value) asset_MPlan.AMP_Name = Convert.ToString(dr["AMP_Name"]);
            if (dr["AMP_Stuff"] != DBNull.Value) asset_MPlan.AMP_Stuff = Convert.ToString(dr["AMP_Stuff"]);
            if (dr["AMP_Start"] != DBNull.Value) asset_MPlan.AMP_Start = Convert.ToDateTime(dr["AMP_Start"]);
            if (dr["AMP_End"] != DBNull.Value) asset_MPlan.AMP_End = Convert.ToDateTime(dr["AMP_End"]);
            if (dr["VerifyStuff"] != DBNull.Value) asset_MPlan.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["AuditStat"] != DBNull.Value) asset_MPlan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["VerifyDate"] != DBNull.Value) asset_MPlan.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) asset_MPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_MPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_MPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_MPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_MPlan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AMP_Type"] != DBNull.Value) asset_MPlan.AMP_Type = Convert.ToString(dr["AMP_Type"]);
            if (dr["AMP_Company"] != DBNull.Value) asset_MPlan.AMP_Company = Convert.ToString(dr["AMP_Company"]);
            if (dr["AMP_Dept"] != DBNull.Value) asset_MPlan.AMP_Dept = Convert.ToString(dr["AMP_Dept"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return asset_MPlan;
      }
      /// <summary>
      /// 获取指定的固定资产检修计划 Asset_MPlan对象集合
      /// </summary>
      public List<Asset_MPlan> GetListByWhere(string strCondition)
      {
         List<Asset_MPlan> ret = new List<Asset_MPlan>();
         string sql = "SELECT  AMP_ID,AMP_Code,AMP_Name,AMP_Stuff,AMP_Start,AMP_End,VerifyStuff,AuditStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMP_Type,AMP_Company,AMP_Dept FROM Asset_MPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Asset_MPlan asset_MPlan = new Asset_MPlan();
            if (dr["AMP_ID"] != DBNull.Value) asset_MPlan.AMP_ID = Convert.ToDecimal(dr["AMP_ID"]);
            if (dr["AMP_Code"] != DBNull.Value) asset_MPlan.AMP_Code = Convert.ToString(dr["AMP_Code"]);
            if (dr["AMP_Name"] != DBNull.Value) asset_MPlan.AMP_Name = Convert.ToString(dr["AMP_Name"]);
            if (dr["AMP_Stuff"] != DBNull.Value) asset_MPlan.AMP_Stuff = Convert.ToString(dr["AMP_Stuff"]);
            if (dr["AMP_Start"] != DBNull.Value) asset_MPlan.AMP_Start = Convert.ToDateTime(dr["AMP_Start"]);
            if (dr["AMP_End"] != DBNull.Value) asset_MPlan.AMP_End = Convert.ToDateTime(dr["AMP_End"]);
            if (dr["VerifyStuff"] != DBNull.Value) asset_MPlan.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["AuditStat"] != DBNull.Value) asset_MPlan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["VerifyDate"] != DBNull.Value) asset_MPlan.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) asset_MPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_MPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_MPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_MPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_MPlan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AMP_Type"] != DBNull.Value) asset_MPlan.AMP_Type = Convert.ToString(dr["AMP_Type"]);
            if (dr["AMP_Company"] != DBNull.Value) asset_MPlan.AMP_Company = Convert.ToString(dr["AMP_Company"]);
            if (dr["AMP_Dept"] != DBNull.Value) asset_MPlan.AMP_Dept = Convert.ToString(dr["AMP_Dept"]);
            ret.Add(asset_MPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的固定资产检修计划 Asset_MPlan对象(即:一条记录
      /// </summary>
      public List<Asset_MPlan> GetAll()
      {
         List<Asset_MPlan> ret = new List<Asset_MPlan>();
         string sql = "SELECT  AMP_ID,AMP_Code,AMP_Name,AMP_Stuff,AMP_Start,AMP_End,VerifyStuff,AuditStat,VerifyDate,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMP_Type,AMP_Company,AMP_Dept FROM Asset_MPlan where 1=1 AND ((Stat is null) or (Stat=0) ) order by AMP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Asset_MPlan asset_MPlan = new Asset_MPlan();
            if (dr["AMP_ID"] != DBNull.Value) asset_MPlan.AMP_ID = Convert.ToDecimal(dr["AMP_ID"]);
            if (dr["AMP_Code"] != DBNull.Value) asset_MPlan.AMP_Code = Convert.ToString(dr["AMP_Code"]);
            if (dr["AMP_Name"] != DBNull.Value) asset_MPlan.AMP_Name = Convert.ToString(dr["AMP_Name"]);
            if (dr["AMP_Stuff"] != DBNull.Value) asset_MPlan.AMP_Stuff = Convert.ToString(dr["AMP_Stuff"]);
            if (dr["AMP_Start"] != DBNull.Value) asset_MPlan.AMP_Start = Convert.ToDateTime(dr["AMP_Start"]);
            if (dr["AMP_End"] != DBNull.Value) asset_MPlan.AMP_End = Convert.ToDateTime(dr["AMP_End"]);
            if (dr["VerifyStuff"] != DBNull.Value) asset_MPlan.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["AuditStat"] != DBNull.Value) asset_MPlan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["VerifyDate"] != DBNull.Value) asset_MPlan.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) asset_MPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_MPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_MPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_MPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_MPlan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AMP_Type"] != DBNull.Value) asset_MPlan.AMP_Type = Convert.ToString(dr["AMP_Type"]);
            if (dr["AMP_Company"] != DBNull.Value) asset_MPlan.AMP_Company = Convert.ToString(dr["AMP_Company"]);
            if (dr["AMP_Dept"] != DBNull.Value) asset_MPlan.AMP_Dept = Convert.ToString(dr["AMP_Dept"]);
            ret.Add(asset_MPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
