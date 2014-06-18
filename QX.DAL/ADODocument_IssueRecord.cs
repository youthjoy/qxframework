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
   /// 文件下发记录
   /// </summary>
   [Serializable]
   public partial class ADODocument_IssueRecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加文件下发记录 Document_IssueRecord对象(即:一条记录)
      /// </summary>
      public int Add(Document_IssueRecord document_IssueRecord)
      {
         string sql = "INSERT INTO Document_IssueRecord (DIR_DocumentCode,DIR_DocumentName,DIR_Code,DIR_Date,DIR_FileCode,DIR_IssueObject,DIR_IssueObjectType,DIR_Operator,DIR_DocmentContent,DIR_Attachment,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@DIR_DocumentCode,@DIR_DocumentName,@DIR_Code,@DIR_Date,@DIR_FileCode,@DIR_IssueObject,@DIR_IssueObjectType,@DIR_Operator,@DIR_DocmentContent,@DIR_Attachment,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocumentCode))
         {
            idb.AddParameter("@DIR_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocumentCode", document_IssueRecord.DIR_DocumentCode);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocumentName))
         {
            idb.AddParameter("@DIR_DocumentName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocumentName", document_IssueRecord.DIR_DocumentName);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Code))
         {
            idb.AddParameter("@DIR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Code", document_IssueRecord.DIR_Code);
         }
         if (document_IssueRecord.DIR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DIR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Date", document_IssueRecord.DIR_Date);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_FileCode))
         {
            idb.AddParameter("@DIR_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_FileCode", document_IssueRecord.DIR_FileCode);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_IssueObject))
         {
            idb.AddParameter("@DIR_IssueObject", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_IssueObject", document_IssueRecord.DIR_IssueObject);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_IssueObjectType))
         {
            idb.AddParameter("@DIR_IssueObjectType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_IssueObjectType", document_IssueRecord.DIR_IssueObjectType);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Operator))
         {
            idb.AddParameter("@DIR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Operator", document_IssueRecord.DIR_Operator);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocmentContent))
         {
            idb.AddParameter("@DIR_DocmentContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocmentContent", document_IssueRecord.DIR_DocmentContent);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Attachment))
         {
            idb.AddParameter("@DIR_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Attachment", document_IssueRecord.DIR_Attachment);
         }
         if (document_IssueRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_IssueRecord.Stat);
         }
         if (document_IssueRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_IssueRecord.CreateDate);
         }
         if (document_IssueRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_IssueRecord.UpdateDate);
         }
         if (document_IssueRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_IssueRecord.DeleteDate);
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
      /// 添加文件下发记录 Document_IssueRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Document_IssueRecord document_IssueRecord)
      {
         string sql = "INSERT INTO Document_IssueRecord (DIR_DocumentCode,DIR_DocumentName,DIR_Code,DIR_Date,DIR_FileCode,DIR_IssueObject,DIR_IssueObjectType,DIR_Operator,DIR_DocmentContent,DIR_Attachment,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@DIR_DocumentCode,@DIR_DocumentName,@DIR_Code,@DIR_Date,@DIR_FileCode,@DIR_IssueObject,@DIR_IssueObjectType,@DIR_Operator,@DIR_DocmentContent,@DIR_Attachment,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocumentCode))
         {
            idb.AddParameter("@DIR_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocumentCode", document_IssueRecord.DIR_DocumentCode);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocumentName))
         {
            idb.AddParameter("@DIR_DocumentName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocumentName", document_IssueRecord.DIR_DocumentName);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Code))
         {
            idb.AddParameter("@DIR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Code", document_IssueRecord.DIR_Code);
         }
         if (document_IssueRecord.DIR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DIR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Date", document_IssueRecord.DIR_Date);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_FileCode))
         {
            idb.AddParameter("@DIR_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_FileCode", document_IssueRecord.DIR_FileCode);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_IssueObject))
         {
            idb.AddParameter("@DIR_IssueObject", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_IssueObject", document_IssueRecord.DIR_IssueObject);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_IssueObjectType))
         {
            idb.AddParameter("@DIR_IssueObjectType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_IssueObjectType", document_IssueRecord.DIR_IssueObjectType);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Operator))
         {
            idb.AddParameter("@DIR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Operator", document_IssueRecord.DIR_Operator);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocmentContent))
         {
            idb.AddParameter("@DIR_DocmentContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocmentContent", document_IssueRecord.DIR_DocmentContent);
         }
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Attachment))
         {
            idb.AddParameter("@DIR_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Attachment", document_IssueRecord.DIR_Attachment);
         }
         if (document_IssueRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_IssueRecord.Stat);
         }
         if (document_IssueRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_IssueRecord.CreateDate);
         }
         if (document_IssueRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_IssueRecord.UpdateDate);
         }
         if (document_IssueRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_IssueRecord.DeleteDate);
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
      /// 更新文件下发记录 Document_IssueRecord对象(即:一条记录
      /// </summary>
      public int Update(Document_IssueRecord document_IssueRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Document_IssueRecord       SET ");
            if(document_IssueRecord.DIR_DocumentCode_IsChanged){sbParameter.Append("DIR_DocumentCode=@DIR_DocumentCode, ");}
      if(document_IssueRecord.DIR_DocumentName_IsChanged){sbParameter.Append("DIR_DocumentName=@DIR_DocumentName, ");}
      if(document_IssueRecord.DIR_Code_IsChanged){sbParameter.Append("DIR_Code=@DIR_Code, ");}
      if(document_IssueRecord.DIR_Date_IsChanged){sbParameter.Append("DIR_Date=@DIR_Date, ");}
      if(document_IssueRecord.DIR_FileCode_IsChanged){sbParameter.Append("DIR_FileCode=@DIR_FileCode, ");}
      if(document_IssueRecord.DIR_IssueObject_IsChanged){sbParameter.Append("DIR_IssueObject=@DIR_IssueObject, ");}
      if(document_IssueRecord.DIR_IssueObjectType_IsChanged){sbParameter.Append("DIR_IssueObjectType=@DIR_IssueObjectType, ");}
      if(document_IssueRecord.DIR_Operator_IsChanged){sbParameter.Append("DIR_Operator=@DIR_Operator, ");}
      if(document_IssueRecord.DIR_DocmentContent_IsChanged){sbParameter.Append("DIR_DocmentContent=@DIR_DocmentContent, ");}
      if(document_IssueRecord.DIR_Attachment_IsChanged){sbParameter.Append("DIR_Attachment=@DIR_Attachment, ");}
      if(document_IssueRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(document_IssueRecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(document_IssueRecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(document_IssueRecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DIR_ID=@DIR_ID; " );
      string sql=sb.ToString();
         if(document_IssueRecord.DIR_DocumentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocumentCode))
         {
            idb.AddParameter("@DIR_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocumentCode", document_IssueRecord.DIR_DocumentCode);
         }
          }
         if(document_IssueRecord.DIR_DocumentName_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocumentName))
         {
            idb.AddParameter("@DIR_DocumentName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocumentName", document_IssueRecord.DIR_DocumentName);
         }
          }
         if(document_IssueRecord.DIR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Code))
         {
            idb.AddParameter("@DIR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Code", document_IssueRecord.DIR_Code);
         }
          }
         if(document_IssueRecord.DIR_Date_IsChanged)
         {
         if (document_IssueRecord.DIR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DIR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Date", document_IssueRecord.DIR_Date);
         }
          }
         if(document_IssueRecord.DIR_FileCode_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_FileCode))
         {
            idb.AddParameter("@DIR_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_FileCode", document_IssueRecord.DIR_FileCode);
         }
          }
         if(document_IssueRecord.DIR_IssueObject_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_IssueObject))
         {
            idb.AddParameter("@DIR_IssueObject", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_IssueObject", document_IssueRecord.DIR_IssueObject);
         }
          }
         if(document_IssueRecord.DIR_IssueObjectType_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_IssueObjectType))
         {
            idb.AddParameter("@DIR_IssueObjectType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_IssueObjectType", document_IssueRecord.DIR_IssueObjectType);
         }
          }
         if(document_IssueRecord.DIR_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Operator))
         {
            idb.AddParameter("@DIR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Operator", document_IssueRecord.DIR_Operator);
         }
          }
         if(document_IssueRecord.DIR_DocmentContent_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_DocmentContent))
         {
            idb.AddParameter("@DIR_DocmentContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_DocmentContent", document_IssueRecord.DIR_DocmentContent);
         }
          }
         if(document_IssueRecord.DIR_Attachment_IsChanged)
         {
         if (string.IsNullOrEmpty(document_IssueRecord.DIR_Attachment))
         {
            idb.AddParameter("@DIR_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DIR_Attachment", document_IssueRecord.DIR_Attachment);
         }
          }
         if(document_IssueRecord.Stat_IsChanged)
         {
         if (document_IssueRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_IssueRecord.Stat);
         }
          }
         if(document_IssueRecord.CreateDate_IsChanged)
         {
         if (document_IssueRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_IssueRecord.CreateDate);
         }
          }
         if(document_IssueRecord.UpdateDate_IsChanged)
         {
         if (document_IssueRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_IssueRecord.UpdateDate);
         }
          }
         if(document_IssueRecord.DeleteDate_IsChanged)
         {
         if (document_IssueRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_IssueRecord.DeleteDate);
         }
          }

         idb.AddParameter("@DIR_ID", document_IssueRecord.DIR_ID);

           
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
      /// 删除文件下发记录 Document_IssueRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal dIR_ID)
      {
         string sql = "DELETE Document_IssueRecord WHERE 1=1  AND DIR_ID=@DIR_ID ";
         idb.AddParameter("@DIR_ID", dIR_ID);

           
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
      /// 获取指定的文件下发记录 Document_IssueRecord对象(即:一条记录
      /// </summary>
      public Document_IssueRecord GetByKey(decimal dIR_ID)
      {
         Document_IssueRecord document_IssueRecord = new Document_IssueRecord();
         string sql = "SELECT  DIR_ID,DIR_DocumentCode,DIR_DocumentName,DIR_Code,DIR_Date,DIR_FileCode,DIR_IssueObject,DIR_IssueObjectType,DIR_Operator,DIR_DocmentContent,DIR_Attachment,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_IssueRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DIR_ID=@DIR_ID ";
         idb.AddParameter("@DIR_ID", dIR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DIR_ID"] != DBNull.Value) document_IssueRecord.DIR_ID = Convert.ToDecimal(dr["DIR_ID"]);
            if (dr["DIR_DocumentCode"] != DBNull.Value) document_IssueRecord.DIR_DocumentCode = Convert.ToString(dr["DIR_DocumentCode"]);
            if (dr["DIR_DocumentName"] != DBNull.Value) document_IssueRecord.DIR_DocumentName = Convert.ToString(dr["DIR_DocumentName"]);
            if (dr["DIR_Code"] != DBNull.Value) document_IssueRecord.DIR_Code = Convert.ToString(dr["DIR_Code"]);
            if (dr["DIR_Date"] != DBNull.Value) document_IssueRecord.DIR_Date = Convert.ToDateTime(dr["DIR_Date"]);
            if (dr["DIR_FileCode"] != DBNull.Value) document_IssueRecord.DIR_FileCode = Convert.ToString(dr["DIR_FileCode"]);
            if (dr["DIR_IssueObject"] != DBNull.Value) document_IssueRecord.DIR_IssueObject = Convert.ToString(dr["DIR_IssueObject"]);
            if (dr["DIR_IssueObjectType"] != DBNull.Value) document_IssueRecord.DIR_IssueObjectType = Convert.ToString(dr["DIR_IssueObjectType"]);
            if (dr["DIR_Operator"] != DBNull.Value) document_IssueRecord.DIR_Operator = Convert.ToString(dr["DIR_Operator"]);
            if (dr["DIR_DocmentContent"] != DBNull.Value) document_IssueRecord.DIR_DocmentContent = Convert.ToString(dr["DIR_DocmentContent"]);
            if (dr["DIR_Attachment"] != DBNull.Value) document_IssueRecord.DIR_Attachment = Convert.ToString(dr["DIR_Attachment"]);
            if (dr["Stat"] != DBNull.Value) document_IssueRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_IssueRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_IssueRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_IssueRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return document_IssueRecord;
      }
      /// <summary>
      /// 获取指定的文件下发记录 Document_IssueRecord对象集合
      /// </summary>
      public List<Document_IssueRecord> GetListByWhere(string strCondition)
      {
         List<Document_IssueRecord> ret = new List<Document_IssueRecord>();
         string sql = "SELECT  DIR_ID,DIR_DocumentCode,DIR_DocumentName,DIR_Code,DIR_Date,DIR_FileCode,DIR_IssueObject,DIR_IssueObjectType,DIR_Operator,DIR_DocmentContent,DIR_Attachment,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_IssueRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Document_IssueRecord document_IssueRecord = new Document_IssueRecord();
            if (dr["DIR_ID"] != DBNull.Value) document_IssueRecord.DIR_ID = Convert.ToDecimal(dr["DIR_ID"]);
            if (dr["DIR_DocumentCode"] != DBNull.Value) document_IssueRecord.DIR_DocumentCode = Convert.ToString(dr["DIR_DocumentCode"]);
            if (dr["DIR_DocumentName"] != DBNull.Value) document_IssueRecord.DIR_DocumentName = Convert.ToString(dr["DIR_DocumentName"]);
            if (dr["DIR_Code"] != DBNull.Value) document_IssueRecord.DIR_Code = Convert.ToString(dr["DIR_Code"]);
            if (dr["DIR_Date"] != DBNull.Value) document_IssueRecord.DIR_Date = Convert.ToDateTime(dr["DIR_Date"]);
            if (dr["DIR_FileCode"] != DBNull.Value) document_IssueRecord.DIR_FileCode = Convert.ToString(dr["DIR_FileCode"]);
            if (dr["DIR_IssueObject"] != DBNull.Value) document_IssueRecord.DIR_IssueObject = Convert.ToString(dr["DIR_IssueObject"]);
            if (dr["DIR_IssueObjectType"] != DBNull.Value) document_IssueRecord.DIR_IssueObjectType = Convert.ToString(dr["DIR_IssueObjectType"]);
            if (dr["DIR_Operator"] != DBNull.Value) document_IssueRecord.DIR_Operator = Convert.ToString(dr["DIR_Operator"]);
            if (dr["DIR_DocmentContent"] != DBNull.Value) document_IssueRecord.DIR_DocmentContent = Convert.ToString(dr["DIR_DocmentContent"]);
            if (dr["DIR_Attachment"] != DBNull.Value) document_IssueRecord.DIR_Attachment = Convert.ToString(dr["DIR_Attachment"]);
            if (dr["Stat"] != DBNull.Value) document_IssueRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_IssueRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_IssueRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_IssueRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_IssueRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的文件下发记录 Document_IssueRecord对象(即:一条记录
      /// </summary>
      public List<Document_IssueRecord> GetAll()
      {
         List<Document_IssueRecord> ret = new List<Document_IssueRecord>();
         string sql = "SELECT  DIR_ID,DIR_DocumentCode,DIR_DocumentName,DIR_Code,DIR_Date,DIR_FileCode,DIR_IssueObject,DIR_IssueObjectType,DIR_Operator,DIR_DocmentContent,DIR_Attachment,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_IssueRecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by DIR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Document_IssueRecord document_IssueRecord = new Document_IssueRecord();
            if (dr["DIR_ID"] != DBNull.Value) document_IssueRecord.DIR_ID = Convert.ToDecimal(dr["DIR_ID"]);
            if (dr["DIR_DocumentCode"] != DBNull.Value) document_IssueRecord.DIR_DocumentCode = Convert.ToString(dr["DIR_DocumentCode"]);
            if (dr["DIR_DocumentName"] != DBNull.Value) document_IssueRecord.DIR_DocumentName = Convert.ToString(dr["DIR_DocumentName"]);
            if (dr["DIR_Code"] != DBNull.Value) document_IssueRecord.DIR_Code = Convert.ToString(dr["DIR_Code"]);
            if (dr["DIR_Date"] != DBNull.Value) document_IssueRecord.DIR_Date = Convert.ToDateTime(dr["DIR_Date"]);
            if (dr["DIR_FileCode"] != DBNull.Value) document_IssueRecord.DIR_FileCode = Convert.ToString(dr["DIR_FileCode"]);
            if (dr["DIR_IssueObject"] != DBNull.Value) document_IssueRecord.DIR_IssueObject = Convert.ToString(dr["DIR_IssueObject"]);
            if (dr["DIR_IssueObjectType"] != DBNull.Value) document_IssueRecord.DIR_IssueObjectType = Convert.ToString(dr["DIR_IssueObjectType"]);
            if (dr["DIR_Operator"] != DBNull.Value) document_IssueRecord.DIR_Operator = Convert.ToString(dr["DIR_Operator"]);
            if (dr["DIR_DocmentContent"] != DBNull.Value) document_IssueRecord.DIR_DocmentContent = Convert.ToString(dr["DIR_DocmentContent"]);
            if (dr["DIR_Attachment"] != DBNull.Value) document_IssueRecord.DIR_Attachment = Convert.ToString(dr["DIR_Attachment"]);
            if (dr["Stat"] != DBNull.Value) document_IssueRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_IssueRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_IssueRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_IssueRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_IssueRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
