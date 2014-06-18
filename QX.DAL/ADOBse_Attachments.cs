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
   /// 附件信息
   /// </summary>
   [Serializable]
   public partial class ADOBse_Attachments
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加附件信息 Bse_Attachments对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Attachments bse_Attachments)
      {
         string sql = "INSERT INTO Bse_Attachments (Module_Code,Record_ID,AT_Name,AT_URL,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_Code,CreateDate,UpdateDate,DeleteDate,AT_Description) VALUES (@Module_Code,@Record_ID,@AT_Name,@AT_URL,@AT_CDate,@AT_UDate,@AT_Creator,@AT_Updator,@Stat,@AT_Code,@CreateDate,@UpdateDate,@DeleteDate,@AT_Description)";
         if (string.IsNullOrEmpty(bse_Attachments.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Attachments.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Attachments.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Attachments.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Name))
         {
            idb.AddParameter("@AT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Name", bse_Attachments.AT_Name);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_URL))
         {
            idb.AddParameter("@AT_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_URL", bse_Attachments.AT_URL);
         }
         if (bse_Attachments.AT_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_CDate", bse_Attachments.AT_CDate);
         }
         if (bse_Attachments.AT_UDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_UDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_UDate", bse_Attachments.AT_UDate);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Creator))
         {
            idb.AddParameter("@AT_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Creator", bse_Attachments.AT_Creator);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Updator))
         {
            idb.AddParameter("@AT_Updator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Updator", bse_Attachments.AT_Updator);
         }
         if (bse_Attachments.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Attachments.Stat);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Code))
         {
            idb.AddParameter("@AT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Code", bse_Attachments.AT_Code);
         }
         if (bse_Attachments.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Attachments.CreateDate);
         }
         if (bse_Attachments.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Attachments.UpdateDate);
         }
         if (bse_Attachments.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Attachments.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Description))
         {
            idb.AddParameter("@AT_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Description", bse_Attachments.AT_Description);
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
      /// 添加附件信息 Bse_Attachments对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Attachments bse_Attachments)
      {
         string sql = "INSERT INTO Bse_Attachments (Module_Code,Record_ID,AT_Name,AT_URL,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_Code,CreateDate,UpdateDate,DeleteDate,AT_Description) VALUES (@Module_Code,@Record_ID,@AT_Name,@AT_URL,@AT_CDate,@AT_UDate,@AT_Creator,@AT_Updator,@Stat,@AT_Code,@CreateDate,@UpdateDate,@DeleteDate,@AT_Description);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Attachments.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Attachments.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Attachments.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Attachments.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Name))
         {
            idb.AddParameter("@AT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Name", bse_Attachments.AT_Name);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_URL))
         {
            idb.AddParameter("@AT_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_URL", bse_Attachments.AT_URL);
         }
         if (bse_Attachments.AT_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_CDate", bse_Attachments.AT_CDate);
         }
         if (bse_Attachments.AT_UDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_UDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_UDate", bse_Attachments.AT_UDate);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Creator))
         {
            idb.AddParameter("@AT_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Creator", bse_Attachments.AT_Creator);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Updator))
         {
            idb.AddParameter("@AT_Updator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Updator", bse_Attachments.AT_Updator);
         }
         if (bse_Attachments.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Attachments.Stat);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Code))
         {
            idb.AddParameter("@AT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Code", bse_Attachments.AT_Code);
         }
         if (bse_Attachments.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Attachments.CreateDate);
         }
         if (bse_Attachments.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Attachments.UpdateDate);
         }
         if (bse_Attachments.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Attachments.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Description))
         {
            idb.AddParameter("@AT_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Description", bse_Attachments.AT_Description);
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
      /// 更新附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public int Update(Bse_Attachments bse_Attachments)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Attachments       SET ");
            if(bse_Attachments.Module_Code_IsChanged){sbParameter.Append("Module_Code=@Module_Code, ");}
      if(bse_Attachments.Record_ID_IsChanged){sbParameter.Append("Record_ID=@Record_ID, ");}
      if(bse_Attachments.AT_Name_IsChanged){sbParameter.Append("AT_Name=@AT_Name, ");}
      if(bse_Attachments.AT_URL_IsChanged){sbParameter.Append("AT_URL=@AT_URL, ");}
      if(bse_Attachments.AT_CDate_IsChanged){sbParameter.Append("AT_CDate=@AT_CDate, ");}
      if(bse_Attachments.AT_UDate_IsChanged){sbParameter.Append("AT_UDate=@AT_UDate, ");}
      if(bse_Attachments.AT_Creator_IsChanged){sbParameter.Append("AT_Creator=@AT_Creator, ");}
      if(bse_Attachments.AT_Updator_IsChanged){sbParameter.Append("AT_Updator=@AT_Updator, ");}
      if(bse_Attachments.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Attachments.AT_Code_IsChanged){sbParameter.Append("AT_Code=@AT_Code, ");}
      if(bse_Attachments.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bse_Attachments.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bse_Attachments.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(bse_Attachments.AT_Description_IsChanged){sbParameter.Append("AT_Description=@AT_Description ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AT_ID=@AT_ID; " );
      string sql=sb.ToString();
         if(bse_Attachments.Module_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Attachments.Module_Code);
         }
          }
         if(bse_Attachments.Record_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Attachments.Record_ID);
         }
          }
         if(bse_Attachments.AT_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Name))
         {
            idb.AddParameter("@AT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Name", bse_Attachments.AT_Name);
         }
          }
         if(bse_Attachments.AT_URL_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_URL))
         {
            idb.AddParameter("@AT_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_URL", bse_Attachments.AT_URL);
         }
          }
         if(bse_Attachments.AT_CDate_IsChanged)
         {
         if (bse_Attachments.AT_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_CDate", bse_Attachments.AT_CDate);
         }
          }
         if(bse_Attachments.AT_UDate_IsChanged)
         {
         if (bse_Attachments.AT_UDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_UDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_UDate", bse_Attachments.AT_UDate);
         }
          }
         if(bse_Attachments.AT_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Creator))
         {
            idb.AddParameter("@AT_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Creator", bse_Attachments.AT_Creator);
         }
          }
         if(bse_Attachments.AT_Updator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Updator))
         {
            idb.AddParameter("@AT_Updator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Updator", bse_Attachments.AT_Updator);
         }
          }
         if(bse_Attachments.Stat_IsChanged)
         {
         if (bse_Attachments.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Attachments.Stat);
         }
          }
         if(bse_Attachments.AT_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Code))
         {
            idb.AddParameter("@AT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Code", bse_Attachments.AT_Code);
         }
          }
         if(bse_Attachments.CreateDate_IsChanged)
         {
         if (bse_Attachments.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Attachments.CreateDate);
         }
          }
         if(bse_Attachments.UpdateDate_IsChanged)
         {
         if (bse_Attachments.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Attachments.UpdateDate);
         }
          }
         if(bse_Attachments.DeleteDate_IsChanged)
         {
         if (bse_Attachments.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Attachments.DeleteDate);
         }
          }
         if(bse_Attachments.AT_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Description))
         {
            idb.AddParameter("@AT_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Description", bse_Attachments.AT_Description);
         }
          }

         idb.AddParameter("@AT_ID", bse_Attachments.AT_ID);

           
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
      /// 删除附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public int Delete(decimal aT_ID)
      {
         string sql = "DELETE Bse_Attachments WHERE 1=1  AND AT_ID=@AT_ID ";
         idb.AddParameter("@AT_ID", aT_ID);

           
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
      /// 获取指定的附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public Bse_Attachments GetByKey(decimal aT_ID)
      {
         Bse_Attachments bse_Attachments = new Bse_Attachments();
         string sql = "SELECT  AT_ID,Module_Code,Record_ID,AT_Name,AT_URL,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_Code,CreateDate,UpdateDate,DeleteDate,AT_Description FROM Bse_Attachments WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AT_ID=@AT_ID ";
         idb.AddParameter("@AT_ID", aT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AT_ID"] != DBNull.Value) bse_Attachments.AT_ID = Convert.ToDecimal(dr["AT_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Attachments.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Attachments.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["AT_Name"] != DBNull.Value) bse_Attachments.AT_Name = Convert.ToString(dr["AT_Name"]);
            if (dr["AT_URL"] != DBNull.Value) bse_Attachments.AT_URL = Convert.ToString(dr["AT_URL"]);
            if (dr["AT_CDate"] != DBNull.Value) bse_Attachments.AT_CDate = Convert.ToDateTime(dr["AT_CDate"]);
            if (dr["AT_UDate"] != DBNull.Value) bse_Attachments.AT_UDate = Convert.ToDateTime(dr["AT_UDate"]);
            if (dr["AT_Creator"] != DBNull.Value) bse_Attachments.AT_Creator = Convert.ToString(dr["AT_Creator"]);
            if (dr["AT_Updator"] != DBNull.Value) bse_Attachments.AT_Updator = Convert.ToString(dr["AT_Updator"]);
            if (dr["Stat"] != DBNull.Value) bse_Attachments.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AT_Code"] != DBNull.Value) bse_Attachments.AT_Code = Convert.ToString(dr["AT_Code"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Attachments.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Attachments.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Attachments.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AT_Description"] != DBNull.Value) bse_Attachments.AT_Description = Convert.ToString(dr["AT_Description"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Attachments;
      }
      /// <summary>
      /// 获取指定的附件信息 Bse_Attachments对象集合
      /// </summary>
      public List<Bse_Attachments> GetListByWhere(string strCondition)
      {
         List<Bse_Attachments> ret = new List<Bse_Attachments>();
         string sql = "SELECT  AT_ID,Module_Code,Record_ID,AT_Name,AT_URL,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_Code,CreateDate,UpdateDate,DeleteDate,AT_Description FROM Bse_Attachments WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Attachments bse_Attachments = new Bse_Attachments();
            if (dr["AT_ID"] != DBNull.Value) bse_Attachments.AT_ID = Convert.ToDecimal(dr["AT_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Attachments.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Attachments.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["AT_Name"] != DBNull.Value) bse_Attachments.AT_Name = Convert.ToString(dr["AT_Name"]);
            if (dr["AT_URL"] != DBNull.Value) bse_Attachments.AT_URL = Convert.ToString(dr["AT_URL"]);
            if (dr["AT_CDate"] != DBNull.Value) bse_Attachments.AT_CDate = Convert.ToDateTime(dr["AT_CDate"]);
            if (dr["AT_UDate"] != DBNull.Value) bse_Attachments.AT_UDate = Convert.ToDateTime(dr["AT_UDate"]);
            if (dr["AT_Creator"] != DBNull.Value) bse_Attachments.AT_Creator = Convert.ToString(dr["AT_Creator"]);
            if (dr["AT_Updator"] != DBNull.Value) bse_Attachments.AT_Updator = Convert.ToString(dr["AT_Updator"]);
            if (dr["Stat"] != DBNull.Value) bse_Attachments.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AT_Code"] != DBNull.Value) bse_Attachments.AT_Code = Convert.ToString(dr["AT_Code"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Attachments.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Attachments.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Attachments.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AT_Description"] != DBNull.Value) bse_Attachments.AT_Description = Convert.ToString(dr["AT_Description"]);
            ret.Add(bse_Attachments);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public List<Bse_Attachments> GetAll()
      {
         List<Bse_Attachments> ret = new List<Bse_Attachments>();
         string sql = "SELECT  AT_ID,Module_Code,Record_ID,AT_Name,AT_URL,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_Code,CreateDate,UpdateDate,DeleteDate,AT_Description FROM Bse_Attachments where 1=1 AND ((Stat is null) or (Stat=0) ) order by AT_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Attachments bse_Attachments = new Bse_Attachments();
            if (dr["AT_ID"] != DBNull.Value) bse_Attachments.AT_ID = Convert.ToDecimal(dr["AT_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Attachments.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Attachments.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["AT_Name"] != DBNull.Value) bse_Attachments.AT_Name = Convert.ToString(dr["AT_Name"]);
            if (dr["AT_URL"] != DBNull.Value) bse_Attachments.AT_URL = Convert.ToString(dr["AT_URL"]);
            if (dr["AT_CDate"] != DBNull.Value) bse_Attachments.AT_CDate = Convert.ToDateTime(dr["AT_CDate"]);
            if (dr["AT_UDate"] != DBNull.Value) bse_Attachments.AT_UDate = Convert.ToDateTime(dr["AT_UDate"]);
            if (dr["AT_Creator"] != DBNull.Value) bse_Attachments.AT_Creator = Convert.ToString(dr["AT_Creator"]);
            if (dr["AT_Updator"] != DBNull.Value) bse_Attachments.AT_Updator = Convert.ToString(dr["AT_Updator"]);
            if (dr["Stat"] != DBNull.Value) bse_Attachments.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AT_Code"] != DBNull.Value) bse_Attachments.AT_Code = Convert.ToString(dr["AT_Code"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Attachments.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Attachments.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Attachments.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AT_Description"] != DBNull.Value) bse_Attachments.AT_Description = Convert.ToString(dr["AT_Description"]);
            ret.Add(bse_Attachments);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
