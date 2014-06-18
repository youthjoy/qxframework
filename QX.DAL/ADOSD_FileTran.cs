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
   /// 合同资料交接
   /// </summary>
   [Serializable]
   public partial class ADOSD_FileTran
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加合同资料交接 SD_FileTran对象(即:一条记录)
      /// </summary>
      public int Add(SD_FileTran sD_FileTran)
      {
         string sql = "INSERT INTO SD_FileTran (SDF_Code,SDF_CCode,SDF_BCode,SDF_BContact,SDF_Status,SDF_Type,SDF_FileName,SDF_Description,SDF_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@SDF_Code,@SDF_CCode,@SDF_BCode,@SDF_BContact,@SDF_Status,@SDF_Type,@SDF_FileName,@SDF_Description,@SDF_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Code))
         {
            idb.AddParameter("@SDF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Code", sD_FileTran.SDF_Code);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_CCode))
         {
            idb.AddParameter("@SDF_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CCode", sD_FileTran.SDF_CCode);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_BCode))
         {
            idb.AddParameter("@SDF_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_BCode", sD_FileTran.SDF_BCode);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_BContact))
         {
            idb.AddParameter("@SDF_BContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_BContact", sD_FileTran.SDF_BContact);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Status))
         {
            idb.AddParameter("@SDF_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Status", sD_FileTran.SDF_Status);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Type))
         {
            idb.AddParameter("@SDF_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Type", sD_FileTran.SDF_Type);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_FileName))
         {
            idb.AddParameter("@SDF_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_FileName", sD_FileTran.SDF_FileName);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Description))
         {
            idb.AddParameter("@SDF_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Description", sD_FileTran.SDF_Description);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Bak))
         {
            idb.AddParameter("@SDF_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Bak", sD_FileTran.SDF_Bak);
         }
         if (sD_FileTran.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_FileTran.Stat);
         }
         if (sD_FileTran.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_FileTran.CreateDate);
         }
         if (sD_FileTran.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_FileTran.UpdateDate);
         }
         if (sD_FileTran.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_FileTran.DeleteDate);
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
      /// 添加合同资料交接 SD_FileTran对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_FileTran sD_FileTran)
      {
         string sql = "INSERT INTO SD_FileTran (SDF_Code,SDF_CCode,SDF_BCode,SDF_BContact,SDF_Status,SDF_Type,SDF_FileName,SDF_Description,SDF_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@SDF_Code,@SDF_CCode,@SDF_BCode,@SDF_BContact,@SDF_Status,@SDF_Type,@SDF_FileName,@SDF_Description,@SDF_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Code))
         {
            idb.AddParameter("@SDF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Code", sD_FileTran.SDF_Code);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_CCode))
         {
            idb.AddParameter("@SDF_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CCode", sD_FileTran.SDF_CCode);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_BCode))
         {
            idb.AddParameter("@SDF_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_BCode", sD_FileTran.SDF_BCode);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_BContact))
         {
            idb.AddParameter("@SDF_BContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_BContact", sD_FileTran.SDF_BContact);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Status))
         {
            idb.AddParameter("@SDF_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Status", sD_FileTran.SDF_Status);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Type))
         {
            idb.AddParameter("@SDF_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Type", sD_FileTran.SDF_Type);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_FileName))
         {
            idb.AddParameter("@SDF_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_FileName", sD_FileTran.SDF_FileName);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Description))
         {
            idb.AddParameter("@SDF_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Description", sD_FileTran.SDF_Description);
         }
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Bak))
         {
            idb.AddParameter("@SDF_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Bak", sD_FileTran.SDF_Bak);
         }
         if (sD_FileTran.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_FileTran.Stat);
         }
         if (sD_FileTran.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_FileTran.CreateDate);
         }
         if (sD_FileTran.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_FileTran.UpdateDate);
         }
         if (sD_FileTran.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_FileTran.DeleteDate);
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
      /// 更新合同资料交接 SD_FileTran对象(即:一条记录
      /// </summary>
      public int Update(SD_FileTran sD_FileTran)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_FileTran       SET ");
            if(sD_FileTran.SDF_Code_IsChanged){sbParameter.Append("SDF_Code=@SDF_Code, ");}
      if(sD_FileTran.SDF_CCode_IsChanged){sbParameter.Append("SDF_CCode=@SDF_CCode, ");}
      if(sD_FileTran.SDF_BCode_IsChanged){sbParameter.Append("SDF_BCode=@SDF_BCode, ");}
      if(sD_FileTran.SDF_BContact_IsChanged){sbParameter.Append("SDF_BContact=@SDF_BContact, ");}
      if(sD_FileTran.SDF_Status_IsChanged){sbParameter.Append("SDF_Status=@SDF_Status, ");}
      if(sD_FileTran.SDF_Type_IsChanged){sbParameter.Append("SDF_Type=@SDF_Type, ");}
      if(sD_FileTran.SDF_FileName_IsChanged){sbParameter.Append("SDF_FileName=@SDF_FileName, ");}
      if(sD_FileTran.SDF_Description_IsChanged){sbParameter.Append("SDF_Description=@SDF_Description, ");}
      if(sD_FileTran.SDF_Bak_IsChanged){sbParameter.Append("SDF_Bak=@SDF_Bak, ");}
      if(sD_FileTran.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_FileTran.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_FileTran.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_FileTran.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDF_ID=@SDF_ID; " );
      string sql=sb.ToString();
         if(sD_FileTran.SDF_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Code))
         {
            idb.AddParameter("@SDF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Code", sD_FileTran.SDF_Code);
         }
          }
         if(sD_FileTran.SDF_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_CCode))
         {
            idb.AddParameter("@SDF_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CCode", sD_FileTran.SDF_CCode);
         }
          }
         if(sD_FileTran.SDF_BCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_BCode))
         {
            idb.AddParameter("@SDF_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_BCode", sD_FileTran.SDF_BCode);
         }
          }
         if(sD_FileTran.SDF_BContact_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_BContact))
         {
            idb.AddParameter("@SDF_BContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_BContact", sD_FileTran.SDF_BContact);
         }
          }
         if(sD_FileTran.SDF_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Status))
         {
            idb.AddParameter("@SDF_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Status", sD_FileTran.SDF_Status);
         }
          }
         if(sD_FileTran.SDF_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Type))
         {
            idb.AddParameter("@SDF_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Type", sD_FileTran.SDF_Type);
         }
          }
         if(sD_FileTran.SDF_FileName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_FileName))
         {
            idb.AddParameter("@SDF_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_FileName", sD_FileTran.SDF_FileName);
         }
          }
         if(sD_FileTran.SDF_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Description))
         {
            idb.AddParameter("@SDF_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Description", sD_FileTran.SDF_Description);
         }
          }
         if(sD_FileTran.SDF_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_FileTran.SDF_Bak))
         {
            idb.AddParameter("@SDF_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Bak", sD_FileTran.SDF_Bak);
         }
          }
         if(sD_FileTran.Stat_IsChanged)
         {
         if (sD_FileTran.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_FileTran.Stat);
         }
          }
         if(sD_FileTran.CreateDate_IsChanged)
         {
         if (sD_FileTran.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_FileTran.CreateDate);
         }
          }
         if(sD_FileTran.UpdateDate_IsChanged)
         {
         if (sD_FileTran.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_FileTran.UpdateDate);
         }
          }
         if(sD_FileTran.DeleteDate_IsChanged)
         {
         if (sD_FileTran.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_FileTran.DeleteDate);
         }
          }

         idb.AddParameter("@SDF_ID", sD_FileTran.SDF_ID);

           
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
      /// 删除合同资料交接 SD_FileTran对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDF_ID)
      {
         string sql = "DELETE SD_FileTran WHERE 1=1  AND SDF_ID=@SDF_ID ";
         idb.AddParameter("@SDF_ID", sDF_ID);

           
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
      /// 获取指定的合同资料交接 SD_FileTran对象(即:一条记录
      /// </summary>
      public SD_FileTran GetByKey(decimal sDF_ID)
      {
         SD_FileTran sD_FileTran = new SD_FileTran();
         string sql = "SELECT  SDF_ID,SDF_Code,SDF_CCode,SDF_BCode,SDF_BContact,SDF_Status,SDF_Type,SDF_FileName,SDF_Description,SDF_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM SD_FileTran WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDF_ID=@SDF_ID ";
         idb.AddParameter("@SDF_ID", sDF_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDF_ID"] != DBNull.Value) sD_FileTran.SDF_ID = Convert.ToDecimal(dr["SDF_ID"]);
            if (dr["SDF_Code"] != DBNull.Value) sD_FileTran.SDF_Code = Convert.ToString(dr["SDF_Code"]);
            if (dr["SDF_CCode"] != DBNull.Value) sD_FileTran.SDF_CCode = Convert.ToString(dr["SDF_CCode"]);
            if (dr["SDF_BCode"] != DBNull.Value) sD_FileTran.SDF_BCode = Convert.ToString(dr["SDF_BCode"]);
            if (dr["SDF_BContact"] != DBNull.Value) sD_FileTran.SDF_BContact = Convert.ToString(dr["SDF_BContact"]);
            if (dr["SDF_Status"] != DBNull.Value) sD_FileTran.SDF_Status = Convert.ToString(dr["SDF_Status"]);
            if (dr["SDF_Type"] != DBNull.Value) sD_FileTran.SDF_Type = Convert.ToString(dr["SDF_Type"]);
            if (dr["SDF_FileName"] != DBNull.Value) sD_FileTran.SDF_FileName = Convert.ToString(dr["SDF_FileName"]);
            if (dr["SDF_Description"] != DBNull.Value) sD_FileTran.SDF_Description = Convert.ToString(dr["SDF_Description"]);
            if (dr["SDF_Bak"] != DBNull.Value) sD_FileTran.SDF_Bak = Convert.ToString(dr["SDF_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_FileTran.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_FileTran.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_FileTran.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_FileTran.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_FileTran;
      }
      /// <summary>
      /// 获取指定的合同资料交接 SD_FileTran对象集合
      /// </summary>
      public List<SD_FileTran> GetListByWhere(string strCondition)
      {
         List<SD_FileTran> ret = new List<SD_FileTran>();
         string sql = "SELECT  SDF_ID,SDF_Code,SDF_CCode,SDF_BCode,SDF_BContact,SDF_Status,SDF_Type,SDF_FileName,SDF_Description,SDF_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM SD_FileTran WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_FileTran sD_FileTran = new SD_FileTran();
            if (dr["SDF_ID"] != DBNull.Value) sD_FileTran.SDF_ID = Convert.ToDecimal(dr["SDF_ID"]);
            if (dr["SDF_Code"] != DBNull.Value) sD_FileTran.SDF_Code = Convert.ToString(dr["SDF_Code"]);
            if (dr["SDF_CCode"] != DBNull.Value) sD_FileTran.SDF_CCode = Convert.ToString(dr["SDF_CCode"]);
            if (dr["SDF_BCode"] != DBNull.Value) sD_FileTran.SDF_BCode = Convert.ToString(dr["SDF_BCode"]);
            if (dr["SDF_BContact"] != DBNull.Value) sD_FileTran.SDF_BContact = Convert.ToString(dr["SDF_BContact"]);
            if (dr["SDF_Status"] != DBNull.Value) sD_FileTran.SDF_Status = Convert.ToString(dr["SDF_Status"]);
            if (dr["SDF_Type"] != DBNull.Value) sD_FileTran.SDF_Type = Convert.ToString(dr["SDF_Type"]);
            if (dr["SDF_FileName"] != DBNull.Value) sD_FileTran.SDF_FileName = Convert.ToString(dr["SDF_FileName"]);
            if (dr["SDF_Description"] != DBNull.Value) sD_FileTran.SDF_Description = Convert.ToString(dr["SDF_Description"]);
            if (dr["SDF_Bak"] != DBNull.Value) sD_FileTran.SDF_Bak = Convert.ToString(dr["SDF_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_FileTran.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_FileTran.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_FileTran.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_FileTran.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sD_FileTran);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的合同资料交接 SD_FileTran对象(即:一条记录
      /// </summary>
      public List<SD_FileTran> GetAll()
      {
         List<SD_FileTran> ret = new List<SD_FileTran>();
         string sql = "SELECT  SDF_ID,SDF_Code,SDF_CCode,SDF_BCode,SDF_BContact,SDF_Status,SDF_Type,SDF_FileName,SDF_Description,SDF_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM SD_FileTran where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDF_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_FileTran sD_FileTran = new SD_FileTran();
            if (dr["SDF_ID"] != DBNull.Value) sD_FileTran.SDF_ID = Convert.ToDecimal(dr["SDF_ID"]);
            if (dr["SDF_Code"] != DBNull.Value) sD_FileTran.SDF_Code = Convert.ToString(dr["SDF_Code"]);
            if (dr["SDF_CCode"] != DBNull.Value) sD_FileTran.SDF_CCode = Convert.ToString(dr["SDF_CCode"]);
            if (dr["SDF_BCode"] != DBNull.Value) sD_FileTran.SDF_BCode = Convert.ToString(dr["SDF_BCode"]);
            if (dr["SDF_BContact"] != DBNull.Value) sD_FileTran.SDF_BContact = Convert.ToString(dr["SDF_BContact"]);
            if (dr["SDF_Status"] != DBNull.Value) sD_FileTran.SDF_Status = Convert.ToString(dr["SDF_Status"]);
            if (dr["SDF_Type"] != DBNull.Value) sD_FileTran.SDF_Type = Convert.ToString(dr["SDF_Type"]);
            if (dr["SDF_FileName"] != DBNull.Value) sD_FileTran.SDF_FileName = Convert.ToString(dr["SDF_FileName"]);
            if (dr["SDF_Description"] != DBNull.Value) sD_FileTran.SDF_Description = Convert.ToString(dr["SDF_Description"]);
            if (dr["SDF_Bak"] != DBNull.Value) sD_FileTran.SDF_Bak = Convert.ToString(dr["SDF_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_FileTran.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_FileTran.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_FileTran.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_FileTran.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sD_FileTran);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
