using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADODoc_Attachment
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Doc_Attachment对象(即:一条记录)
      /// </summary>
      public int Add(Doc_Attachment doc_Attachment)
      {
         string sql = "INSERT INTO Doc_Attachment (Dat_Code,Dat_Name,Dat_Path,Dat_Module,Dat_RefCode,Dat_Type,Dat_Stat,CreateTime,UpdateTime,DeleteTime,Stat) VALUES (@Dat_Code,@Dat_Name,@Dat_Path,@Dat_Module,@Dat_RefCode,@Dat_Type,@Dat_Stat,@CreateTime,@UpdateTime,@DeleteTime,@Stat)";
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Code))
         {
            idb.AddParameter("@Dat_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Code", doc_Attachment.Dat_Code);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Name))
         {
            idb.AddParameter("@Dat_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Name", doc_Attachment.Dat_Name);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Path))
         {
            idb.AddParameter("@Dat_Path", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Path", doc_Attachment.Dat_Path);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Module))
         {
            idb.AddParameter("@Dat_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Module", doc_Attachment.Dat_Module);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_RefCode))
         {
            idb.AddParameter("@Dat_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_RefCode", doc_Attachment.Dat_RefCode);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Type))
         {
            idb.AddParameter("@Dat_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Type", doc_Attachment.Dat_Type);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Stat))
         {
            idb.AddParameter("@Dat_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Stat", doc_Attachment.Dat_Stat);
         }
         if (doc_Attachment.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Attachment.CreateTime);
         }
         if (doc_Attachment.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Attachment.UpdateTime);
         }
         if (doc_Attachment.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Attachment.DeleteTime);
         }
         if (doc_Attachment.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Attachment.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Doc_Attachment对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Doc_Attachment doc_Attachment)
      {
         string sql = "INSERT INTO Doc_Attachment (Dat_Code,Dat_Name,Dat_Path,Dat_Module,Dat_RefCode,Dat_Type,Dat_Stat,CreateTime,UpdateTime,DeleteTime,Stat) VALUES (@Dat_Code,@Dat_Name,@Dat_Path,@Dat_Module,@Dat_RefCode,@Dat_Type,@Dat_Stat,@CreateTime,@UpdateTime,@DeleteTime,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Code))
         {
            idb.AddParameter("@Dat_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Code", doc_Attachment.Dat_Code);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Name))
         {
            idb.AddParameter("@Dat_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Name", doc_Attachment.Dat_Name);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Path))
         {
            idb.AddParameter("@Dat_Path", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Path", doc_Attachment.Dat_Path);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Module))
         {
            idb.AddParameter("@Dat_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Module", doc_Attachment.Dat_Module);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_RefCode))
         {
            idb.AddParameter("@Dat_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_RefCode", doc_Attachment.Dat_RefCode);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Type))
         {
            idb.AddParameter("@Dat_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Type", doc_Attachment.Dat_Type);
         }
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Stat))
         {
            idb.AddParameter("@Dat_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Stat", doc_Attachment.Dat_Stat);
         }
         if (doc_Attachment.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Attachment.CreateTime);
         }
         if (doc_Attachment.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Attachment.UpdateTime);
         }
         if (doc_Attachment.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Attachment.DeleteTime);
         }
         if (doc_Attachment.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Attachment.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Doc_Attachment对象(即:一条记录
      /// </summary>
      public int Update(Doc_Attachment doc_Attachment)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Doc_Attachment       SET ");
            if(doc_Attachment.Dat_Code_IsChanged){sbParameter.Append("Dat_Code=@Dat_Code, ");}
      if(doc_Attachment.Dat_Name_IsChanged){sbParameter.Append("Dat_Name=@Dat_Name, ");}
      if(doc_Attachment.Dat_Path_IsChanged){sbParameter.Append("Dat_Path=@Dat_Path, ");}
      if(doc_Attachment.Dat_Module_IsChanged){sbParameter.Append("Dat_Module=@Dat_Module, ");}
      if(doc_Attachment.Dat_RefCode_IsChanged){sbParameter.Append("Dat_RefCode=@Dat_RefCode, ");}
      if(doc_Attachment.Dat_Type_IsChanged){sbParameter.Append("Dat_Type=@Dat_Type, ");}
      if(doc_Attachment.Dat_Stat_IsChanged){sbParameter.Append("Dat_Stat=@Dat_Stat, ");}
      if(doc_Attachment.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(doc_Attachment.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(doc_Attachment.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime, ");}
      if(doc_Attachment.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Dat_ID=@Dat_ID; " );
      string sql=sb.ToString();
         if(doc_Attachment.Dat_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Code))
         {
            idb.AddParameter("@Dat_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Code", doc_Attachment.Dat_Code);
         }
          }
         if(doc_Attachment.Dat_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Name))
         {
            idb.AddParameter("@Dat_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Name", doc_Attachment.Dat_Name);
         }
          }
         if(doc_Attachment.Dat_Path_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Path))
         {
            idb.AddParameter("@Dat_Path", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Path", doc_Attachment.Dat_Path);
         }
          }
         if(doc_Attachment.Dat_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Module))
         {
            idb.AddParameter("@Dat_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Module", doc_Attachment.Dat_Module);
         }
          }
         if(doc_Attachment.Dat_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Attachment.Dat_RefCode))
         {
            idb.AddParameter("@Dat_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_RefCode", doc_Attachment.Dat_RefCode);
         }
          }
         if(doc_Attachment.Dat_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Type))
         {
            idb.AddParameter("@Dat_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Type", doc_Attachment.Dat_Type);
         }
          }
         if(doc_Attachment.Dat_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Attachment.Dat_Stat))
         {
            idb.AddParameter("@Dat_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dat_Stat", doc_Attachment.Dat_Stat);
         }
          }
         if(doc_Attachment.CreateTime_IsChanged)
         {
         if (doc_Attachment.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Attachment.CreateTime);
         }
          }
         if(doc_Attachment.UpdateTime_IsChanged)
         {
         if (doc_Attachment.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Attachment.UpdateTime);
         }
          }
         if(doc_Attachment.DeleteTime_IsChanged)
         {
         if (doc_Attachment.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Attachment.DeleteTime);
         }
          }
         if(doc_Attachment.Stat_IsChanged)
         {
         if (doc_Attachment.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Attachment.Stat);
         }
          }

         idb.AddParameter("@Dat_ID", doc_Attachment.Dat_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Doc_Attachment对象(即:一条记录
      /// </summary>
      public int Delete(decimal dat_ID)
      {
         string sql = "DELETE Doc_Attachment WHERE 1=1  AND Dat_ID=@Dat_ID ";
         idb.AddParameter("@Dat_ID", dat_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Doc_Attachment对象(即:一条记录
      /// </summary>
      public Doc_Attachment GetByKey(decimal dat_ID)
      {
         Doc_Attachment doc_Attachment = new Doc_Attachment();
         string sql = "SELECT  Dat_ID,Dat_Code,Dat_Name,Dat_Path,Dat_Module,Dat_RefCode,Dat_Type,Dat_Stat,CreateTime,UpdateTime,DeleteTime,Stat FROM Doc_Attachment WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Dat_ID=@Dat_ID ";
         idb.AddParameter("@Dat_ID", dat_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Dat_ID"] != DBNull.Value) doc_Attachment.Dat_ID = Convert.ToDecimal(dr["Dat_ID"]);
            if (dr["Dat_Code"] != DBNull.Value) doc_Attachment.Dat_Code = Convert.ToString(dr["Dat_Code"]);
            if (dr["Dat_Name"] != DBNull.Value) doc_Attachment.Dat_Name = Convert.ToString(dr["Dat_Name"]);
            if (dr["Dat_Path"] != DBNull.Value) doc_Attachment.Dat_Path = Convert.ToString(dr["Dat_Path"]);
            if (dr["Dat_Module"] != DBNull.Value) doc_Attachment.Dat_Module = Convert.ToString(dr["Dat_Module"]);
            if (dr["Dat_RefCode"] != DBNull.Value) doc_Attachment.Dat_RefCode = Convert.ToString(dr["Dat_RefCode"]);
            if (dr["Dat_Type"] != DBNull.Value) doc_Attachment.Dat_Type = Convert.ToString(dr["Dat_Type"]);
            if (dr["Dat_Stat"] != DBNull.Value) doc_Attachment.Dat_Stat = Convert.ToString(dr["Dat_Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Attachment.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Attachment.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Attachment.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stat"] != DBNull.Value) doc_Attachment.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return doc_Attachment;
      }
      /// <summary>
      /// 获取指定的Doc_Attachment对象集合
      /// </summary>
      public List<Doc_Attachment> GetListByWhere(string strCondition)
      {
         List<Doc_Attachment> ret = new List<Doc_Attachment>();
         string sql = "SELECT  Dat_ID,Dat_Code,Dat_Name,Dat_Path,Dat_Module,Dat_RefCode,Dat_Type,Dat_Stat,CreateTime,UpdateTime,DeleteTime,Stat FROM Doc_Attachment WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Dat_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Doc_Attachment doc_Attachment = new Doc_Attachment();
            if (dr["Dat_ID"] != DBNull.Value) doc_Attachment.Dat_ID = Convert.ToDecimal(dr["Dat_ID"]);
            if (dr["Dat_Code"] != DBNull.Value) doc_Attachment.Dat_Code = Convert.ToString(dr["Dat_Code"]);
            if (dr["Dat_Name"] != DBNull.Value) doc_Attachment.Dat_Name = Convert.ToString(dr["Dat_Name"]);
            if (dr["Dat_Path"] != DBNull.Value) doc_Attachment.Dat_Path = Convert.ToString(dr["Dat_Path"]);
            if (dr["Dat_Module"] != DBNull.Value) doc_Attachment.Dat_Module = Convert.ToString(dr["Dat_Module"]);
            if (dr["Dat_RefCode"] != DBNull.Value) doc_Attachment.Dat_RefCode = Convert.ToString(dr["Dat_RefCode"]);
            if (dr["Dat_Type"] != DBNull.Value) doc_Attachment.Dat_Type = Convert.ToString(dr["Dat_Type"]);
            if (dr["Dat_Stat"] != DBNull.Value) doc_Attachment.Dat_Stat = Convert.ToString(dr["Dat_Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Attachment.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Attachment.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Attachment.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stat"] != DBNull.Value) doc_Attachment.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(doc_Attachment);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Doc_Attachment对象(即:一条记录
      /// </summary>
      public List<Doc_Attachment> GetAll()
      {
         List<Doc_Attachment> ret = new List<Doc_Attachment>();
         string sql = "SELECT  Dat_ID,Dat_Code,Dat_Name,Dat_Path,Dat_Module,Dat_RefCode,Dat_Type,Dat_Stat,CreateTime,UpdateTime,DeleteTime,Stat FROM Doc_Attachment where 1=1 AND ((Stat is null) or (Stat=0) ) order by Dat_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Doc_Attachment doc_Attachment = new Doc_Attachment();
            if (dr["Dat_ID"] != DBNull.Value) doc_Attachment.Dat_ID = Convert.ToDecimal(dr["Dat_ID"]);
            if (dr["Dat_Code"] != DBNull.Value) doc_Attachment.Dat_Code = Convert.ToString(dr["Dat_Code"]);
            if (dr["Dat_Name"] != DBNull.Value) doc_Attachment.Dat_Name = Convert.ToString(dr["Dat_Name"]);
            if (dr["Dat_Path"] != DBNull.Value) doc_Attachment.Dat_Path = Convert.ToString(dr["Dat_Path"]);
            if (dr["Dat_Module"] != DBNull.Value) doc_Attachment.Dat_Module = Convert.ToString(dr["Dat_Module"]);
            if (dr["Dat_RefCode"] != DBNull.Value) doc_Attachment.Dat_RefCode = Convert.ToString(dr["Dat_RefCode"]);
            if (dr["Dat_Type"] != DBNull.Value) doc_Attachment.Dat_Type = Convert.ToString(dr["Dat_Type"]);
            if (dr["Dat_Stat"] != DBNull.Value) doc_Attachment.Dat_Stat = Convert.ToString(dr["Dat_Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Attachment.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Attachment.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Attachment.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stat"] != DBNull.Value) doc_Attachment.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(doc_Attachment);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
