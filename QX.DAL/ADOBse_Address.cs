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
   public partial class ADOBse_Address
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_Address对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Address bse_Address)
      {
         string sql = "INSERT INTO Bse_Address (BAddress_Code,Module_Code,Record_ID,BAddress_Type,BAddress_Name,BAddress_Contactor,BAddress_Mobile,BAddress_Zip,BAddress_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@BAddress_Code,@Module_Code,@Record_ID,@BAddress_Type,@BAddress_Name,@BAddress_Contactor,@BAddress_Mobile,@BAddress_Zip,@BAddress_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(bse_Address.BAddress_Code))
         {
            idb.AddParameter("@BAddress_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Code", bse_Address.BAddress_Code);
         }
         if (string.IsNullOrEmpty(bse_Address.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Address.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Address.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Address.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Type))
         {
            idb.AddParameter("@BAddress_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Type", bse_Address.BAddress_Type);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Name))
         {
            idb.AddParameter("@BAddress_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Name", bse_Address.BAddress_Name);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Contactor))
         {
            idb.AddParameter("@BAddress_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Contactor", bse_Address.BAddress_Contactor);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Mobile))
         {
            idb.AddParameter("@BAddress_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Mobile", bse_Address.BAddress_Mobile);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Zip))
         {
            idb.AddParameter("@BAddress_Zip", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Zip", bse_Address.BAddress_Zip);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Remark))
         {
            idb.AddParameter("@BAddress_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Remark", bse_Address.BAddress_Remark);
         }
         if (bse_Address.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Address.Stat);
         }
         if (bse_Address.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Address.CreateDate);
         }
         if (bse_Address.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Address.UpdateDate);
         }
         if (bse_Address.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Address.DeleteDate);
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
      /// 添加Bse_Address对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Address bse_Address)
      {
         string sql = "INSERT INTO Bse_Address (BAddress_Code,Module_Code,Record_ID,BAddress_Type,BAddress_Name,BAddress_Contactor,BAddress_Mobile,BAddress_Zip,BAddress_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@BAddress_Code,@Module_Code,@Record_ID,@BAddress_Type,@BAddress_Name,@BAddress_Contactor,@BAddress_Mobile,@BAddress_Zip,@BAddress_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Address.BAddress_Code))
         {
            idb.AddParameter("@BAddress_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Code", bse_Address.BAddress_Code);
         }
         if (string.IsNullOrEmpty(bse_Address.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Address.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Address.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Address.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Type))
         {
            idb.AddParameter("@BAddress_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Type", bse_Address.BAddress_Type);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Name))
         {
            idb.AddParameter("@BAddress_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Name", bse_Address.BAddress_Name);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Contactor))
         {
            idb.AddParameter("@BAddress_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Contactor", bse_Address.BAddress_Contactor);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Mobile))
         {
            idb.AddParameter("@BAddress_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Mobile", bse_Address.BAddress_Mobile);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Zip))
         {
            idb.AddParameter("@BAddress_Zip", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Zip", bse_Address.BAddress_Zip);
         }
         if (string.IsNullOrEmpty(bse_Address.BAddress_Remark))
         {
            idb.AddParameter("@BAddress_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Remark", bse_Address.BAddress_Remark);
         }
         if (bse_Address.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Address.Stat);
         }
         if (bse_Address.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Address.CreateDate);
         }
         if (bse_Address.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Address.UpdateDate);
         }
         if (bse_Address.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Address.DeleteDate);
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
      /// 更新Bse_Address对象(即:一条记录
      /// </summary>
      public int Update(Bse_Address bse_Address)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Address       SET ");
            if(bse_Address.BAddress_Code_IsChanged){sbParameter.Append("BAddress_Code=@BAddress_Code, ");}
      if(bse_Address.Module_Code_IsChanged){sbParameter.Append("Module_Code=@Module_Code, ");}
      if(bse_Address.Record_ID_IsChanged){sbParameter.Append("Record_ID=@Record_ID, ");}
      if(bse_Address.BAddress_Type_IsChanged){sbParameter.Append("BAddress_Type=@BAddress_Type, ");}
      if(bse_Address.BAddress_Name_IsChanged){sbParameter.Append("BAddress_Name=@BAddress_Name, ");}
      if(bse_Address.BAddress_Contactor_IsChanged){sbParameter.Append("BAddress_Contactor=@BAddress_Contactor, ");}
      if(bse_Address.BAddress_Mobile_IsChanged){sbParameter.Append("BAddress_Mobile=@BAddress_Mobile, ");}
      if(bse_Address.BAddress_Zip_IsChanged){sbParameter.Append("BAddress_Zip=@BAddress_Zip, ");}
      if(bse_Address.BAddress_Remark_IsChanged){sbParameter.Append("BAddress_Remark=@BAddress_Remark, ");}
      if(bse_Address.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Address.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bse_Address.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bse_Address.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and BAddress_ID=@BAddress_ID; " );
      string sql=sb.ToString();
         if(bse_Address.BAddress_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.BAddress_Code))
         {
            idb.AddParameter("@BAddress_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Code", bse_Address.BAddress_Code);
         }
          }
         if(bse_Address.Module_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Address.Module_Code);
         }
          }
         if(bse_Address.Record_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Address.Record_ID);
         }
          }
         if(bse_Address.BAddress_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.BAddress_Type))
         {
            idb.AddParameter("@BAddress_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Type", bse_Address.BAddress_Type);
         }
          }
         if(bse_Address.BAddress_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.BAddress_Name))
         {
            idb.AddParameter("@BAddress_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Name", bse_Address.BAddress_Name);
         }
          }
         if(bse_Address.BAddress_Contactor_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.BAddress_Contactor))
         {
            idb.AddParameter("@BAddress_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Contactor", bse_Address.BAddress_Contactor);
         }
          }
         if(bse_Address.BAddress_Mobile_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.BAddress_Mobile))
         {
            idb.AddParameter("@BAddress_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Mobile", bse_Address.BAddress_Mobile);
         }
          }
         if(bse_Address.BAddress_Zip_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.BAddress_Zip))
         {
            idb.AddParameter("@BAddress_Zip", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Zip", bse_Address.BAddress_Zip);
         }
          }
         if(bse_Address.BAddress_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Address.BAddress_Remark))
         {
            idb.AddParameter("@BAddress_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAddress_Remark", bse_Address.BAddress_Remark);
         }
          }
         if(bse_Address.Stat_IsChanged)
         {
         if (bse_Address.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Address.Stat);
         }
          }
         if(bse_Address.CreateDate_IsChanged)
         {
         if (bse_Address.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Address.CreateDate);
         }
          }
         if(bse_Address.UpdateDate_IsChanged)
         {
         if (bse_Address.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Address.UpdateDate);
         }
          }
         if(bse_Address.DeleteDate_IsChanged)
         {
         if (bse_Address.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Address.DeleteDate);
         }
          }

         idb.AddParameter("@BAddress_ID", bse_Address.BAddress_ID);

           
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
      /// 删除Bse_Address对象(即:一条记录
      /// </summary>
      public int Delete(decimal bAddress_ID)
      {
         string sql = "DELETE Bse_Address WHERE 1=1  AND BAddress_ID=@BAddress_ID ";
         idb.AddParameter("@BAddress_ID", bAddress_ID);

           
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
      /// 获取指定的Bse_Address对象(即:一条记录
      /// </summary>
      public Bse_Address GetByKey(decimal bAddress_ID)
      {
         Bse_Address bse_Address = new Bse_Address();
         string sql = "SELECT  BAddress_ID,BAddress_Code,Module_Code,Record_ID,BAddress_Type,BAddress_Name,BAddress_Contactor,BAddress_Mobile,BAddress_Zip,BAddress_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Bse_Address WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND BAddress_ID=@BAddress_ID ";
         idb.AddParameter("@BAddress_ID", bAddress_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["BAddress_ID"] != DBNull.Value) bse_Address.BAddress_ID = Convert.ToDecimal(dr["BAddress_ID"]);
            if (dr["BAddress_Code"] != DBNull.Value) bse_Address.BAddress_Code = Convert.ToString(dr["BAddress_Code"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Address.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Address.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["BAddress_Type"] != DBNull.Value) bse_Address.BAddress_Type = Convert.ToString(dr["BAddress_Type"]);
            if (dr["BAddress_Name"] != DBNull.Value) bse_Address.BAddress_Name = Convert.ToString(dr["BAddress_Name"]);
            if (dr["BAddress_Contactor"] != DBNull.Value) bse_Address.BAddress_Contactor = Convert.ToString(dr["BAddress_Contactor"]);
            if (dr["BAddress_Mobile"] != DBNull.Value) bse_Address.BAddress_Mobile = Convert.ToString(dr["BAddress_Mobile"]);
            if (dr["BAddress_Zip"] != DBNull.Value) bse_Address.BAddress_Zip = Convert.ToString(dr["BAddress_Zip"]);
            if (dr["BAddress_Remark"] != DBNull.Value) bse_Address.BAddress_Remark = Convert.ToString(dr["BAddress_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_Address.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Address.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Address.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Address.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Address;
      }
      /// <summary>
      /// 获取指定的Bse_Address对象集合
      /// </summary>
      public List<Bse_Address> GetListByWhere(string strCondition)
      {
         List<Bse_Address> ret = new List<Bse_Address>();
         string sql = "SELECT  BAddress_ID,BAddress_Code,Module_Code,Record_ID,BAddress_Type,BAddress_Name,BAddress_Contactor,BAddress_Mobile,BAddress_Zip,BAddress_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Bse_Address WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Address bse_Address = new Bse_Address();
            if (dr["BAddress_ID"] != DBNull.Value) bse_Address.BAddress_ID = Convert.ToDecimal(dr["BAddress_ID"]);
            if (dr["BAddress_Code"] != DBNull.Value) bse_Address.BAddress_Code = Convert.ToString(dr["BAddress_Code"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Address.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Address.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["BAddress_Type"] != DBNull.Value) bse_Address.BAddress_Type = Convert.ToString(dr["BAddress_Type"]);
            if (dr["BAddress_Name"] != DBNull.Value) bse_Address.BAddress_Name = Convert.ToString(dr["BAddress_Name"]);
            if (dr["BAddress_Contactor"] != DBNull.Value) bse_Address.BAddress_Contactor = Convert.ToString(dr["BAddress_Contactor"]);
            if (dr["BAddress_Mobile"] != DBNull.Value) bse_Address.BAddress_Mobile = Convert.ToString(dr["BAddress_Mobile"]);
            if (dr["BAddress_Zip"] != DBNull.Value) bse_Address.BAddress_Zip = Convert.ToString(dr["BAddress_Zip"]);
            if (dr["BAddress_Remark"] != DBNull.Value) bse_Address.BAddress_Remark = Convert.ToString(dr["BAddress_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_Address.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Address.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Address.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Address.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bse_Address);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_Address对象(即:一条记录
      /// </summary>
      public List<Bse_Address> GetAll()
      {
         List<Bse_Address> ret = new List<Bse_Address>();
         string sql = "SELECT  BAddress_ID,BAddress_Code,Module_Code,Record_ID,BAddress_Type,BAddress_Name,BAddress_Contactor,BAddress_Mobile,BAddress_Zip,BAddress_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Bse_Address where 1=1 AND ((Stat is null) or (Stat=0) ) order by BAddress_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Address bse_Address = new Bse_Address();
            if (dr["BAddress_ID"] != DBNull.Value) bse_Address.BAddress_ID = Convert.ToDecimal(dr["BAddress_ID"]);
            if (dr["BAddress_Code"] != DBNull.Value) bse_Address.BAddress_Code = Convert.ToString(dr["BAddress_Code"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Address.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Address.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["BAddress_Type"] != DBNull.Value) bse_Address.BAddress_Type = Convert.ToString(dr["BAddress_Type"]);
            if (dr["BAddress_Name"] != DBNull.Value) bse_Address.BAddress_Name = Convert.ToString(dr["BAddress_Name"]);
            if (dr["BAddress_Contactor"] != DBNull.Value) bse_Address.BAddress_Contactor = Convert.ToString(dr["BAddress_Contactor"]);
            if (dr["BAddress_Mobile"] != DBNull.Value) bse_Address.BAddress_Mobile = Convert.ToString(dr["BAddress_Mobile"]);
            if (dr["BAddress_Zip"] != DBNull.Value) bse_Address.BAddress_Zip = Convert.ToString(dr["BAddress_Zip"]);
            if (dr["BAddress_Remark"] != DBNull.Value) bse_Address.BAddress_Remark = Convert.ToString(dr["BAddress_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_Address.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Address.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Address.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Address.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bse_Address);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
