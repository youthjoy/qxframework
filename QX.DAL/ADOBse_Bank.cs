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
   /// 银行信息
   /// </summary>
   [Serializable]
   public partial class ADOBse_Bank
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加银行信息 Bse_Bank对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Bank bse_Bank)
      {
         string sql = "INSERT INTO Bse_Bank (Module_Code,Record_ID,Bank_Code,Bank_Name,Bank_Branch,Bank_Card,Bank_User,Stat,CreateDate,UpdateDate,DeleteDate,Bank_BranchName) VALUES (@Module_Code,@Record_ID,@Bank_Code,@Bank_Name,@Bank_Branch,@Bank_Card,@Bank_User,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Bank_BranchName)";
         if (string.IsNullOrEmpty(bse_Bank.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Bank.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Bank.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Bank.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Code))
         {
            idb.AddParameter("@Bank_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Code", bse_Bank.Bank_Code);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Name))
         {
            idb.AddParameter("@Bank_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Name", bse_Bank.Bank_Name);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Branch))
         {
            idb.AddParameter("@Bank_Branch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Branch", bse_Bank.Bank_Branch);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Card))
         {
            idb.AddParameter("@Bank_Card", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Card", bse_Bank.Bank_Card);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_User))
         {
            idb.AddParameter("@Bank_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_User", bse_Bank.Bank_User);
         }
         if (bse_Bank.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Bank.Stat);
         }
         if (bse_Bank.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Bank.CreateDate);
         }
         if (bse_Bank.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Bank.UpdateDate);
         }
         if (bse_Bank.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Bank.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_BranchName))
         {
            idb.AddParameter("@Bank_BranchName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_BranchName", bse_Bank.Bank_BranchName);
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
      /// 添加银行信息 Bse_Bank对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Bank bse_Bank)
      {
         string sql = "INSERT INTO Bse_Bank (Module_Code,Record_ID,Bank_Code,Bank_Name,Bank_Branch,Bank_Card,Bank_User,Stat,CreateDate,UpdateDate,DeleteDate,Bank_BranchName) VALUES (@Module_Code,@Record_ID,@Bank_Code,@Bank_Name,@Bank_Branch,@Bank_Card,@Bank_User,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Bank_BranchName);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Bank.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Bank.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Bank.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Bank.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Code))
         {
            idb.AddParameter("@Bank_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Code", bse_Bank.Bank_Code);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Name))
         {
            idb.AddParameter("@Bank_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Name", bse_Bank.Bank_Name);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Branch))
         {
            idb.AddParameter("@Bank_Branch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Branch", bse_Bank.Bank_Branch);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_Card))
         {
            idb.AddParameter("@Bank_Card", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Card", bse_Bank.Bank_Card);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_User))
         {
            idb.AddParameter("@Bank_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_User", bse_Bank.Bank_User);
         }
         if (bse_Bank.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Bank.Stat);
         }
         if (bse_Bank.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Bank.CreateDate);
         }
         if (bse_Bank.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Bank.UpdateDate);
         }
         if (bse_Bank.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Bank.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_Bank.Bank_BranchName))
         {
            idb.AddParameter("@Bank_BranchName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_BranchName", bse_Bank.Bank_BranchName);
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
      /// 更新银行信息 Bse_Bank对象(即:一条记录
      /// </summary>
      public int Update(Bse_Bank bse_Bank)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Bank       SET ");
            if(bse_Bank.Module_Code_IsChanged){sbParameter.Append("Module_Code=@Module_Code, ");}
      if(bse_Bank.Record_ID_IsChanged){sbParameter.Append("Record_ID=@Record_ID, ");}
      if(bse_Bank.Bank_Code_IsChanged){sbParameter.Append("Bank_Code=@Bank_Code, ");}
      if(bse_Bank.Bank_Name_IsChanged){sbParameter.Append("Bank_Name=@Bank_Name, ");}
      if(bse_Bank.Bank_Branch_IsChanged){sbParameter.Append("Bank_Branch=@Bank_Branch, ");}
      if(bse_Bank.Bank_Card_IsChanged){sbParameter.Append("Bank_Card=@Bank_Card, ");}
      if(bse_Bank.Bank_User_IsChanged){sbParameter.Append("Bank_User=@Bank_User, ");}
      if(bse_Bank.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Bank.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bse_Bank.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bse_Bank.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(bse_Bank.Bank_BranchName_IsChanged){sbParameter.Append("Bank_BranchName=@Bank_BranchName ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Bank_ID=@Bank_ID; " );
      string sql=sb.ToString();
         if(bse_Bank.Module_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Bank.Module_Code);
         }
          }
         if(bse_Bank.Record_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Bank.Record_ID);
         }
          }
         if(bse_Bank.Bank_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Bank_Code))
         {
            idb.AddParameter("@Bank_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Code", bse_Bank.Bank_Code);
         }
          }
         if(bse_Bank.Bank_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Bank_Name))
         {
            idb.AddParameter("@Bank_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Name", bse_Bank.Bank_Name);
         }
          }
         if(bse_Bank.Bank_Branch_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Bank_Branch))
         {
            idb.AddParameter("@Bank_Branch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Branch", bse_Bank.Bank_Branch);
         }
          }
         if(bse_Bank.Bank_Card_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Bank_Card))
         {
            idb.AddParameter("@Bank_Card", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_Card", bse_Bank.Bank_Card);
         }
          }
         if(bse_Bank.Bank_User_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Bank_User))
         {
            idb.AddParameter("@Bank_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_User", bse_Bank.Bank_User);
         }
          }
         if(bse_Bank.Stat_IsChanged)
         {
         if (bse_Bank.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Bank.Stat);
         }
          }
         if(bse_Bank.CreateDate_IsChanged)
         {
         if (bse_Bank.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Bank.CreateDate);
         }
          }
         if(bse_Bank.UpdateDate_IsChanged)
         {
         if (bse_Bank.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Bank.UpdateDate);
         }
          }
         if(bse_Bank.DeleteDate_IsChanged)
         {
         if (bse_Bank.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Bank.DeleteDate);
         }
          }
         if(bse_Bank.Bank_BranchName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bank.Bank_BranchName))
         {
            idb.AddParameter("@Bank_BranchName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bank_BranchName", bse_Bank.Bank_BranchName);
         }
          }

         idb.AddParameter("@Bank_ID", bse_Bank.Bank_ID);

           
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
      /// 删除银行信息 Bse_Bank对象(即:一条记录
      /// </summary>
      public int Delete(decimal bank_ID)
      {
         string sql = "DELETE Bse_Bank WHERE 1=1  AND Bank_ID=@Bank_ID ";
         idb.AddParameter("@Bank_ID", bank_ID);

           
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
      /// 获取指定的银行信息 Bse_Bank对象(即:一条记录
      /// </summary>
      public Bse_Bank GetByKey(decimal bank_ID)
      {
         Bse_Bank bse_Bank = new Bse_Bank();
         string sql = "SELECT  Bank_ID,Module_Code,Record_ID,Bank_Code,Bank_Name,Bank_Branch,Bank_Card,Bank_User,Stat,CreateDate,UpdateDate,DeleteDate,Bank_BranchName FROM Bse_Bank WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Bank_ID=@Bank_ID ";
         idb.AddParameter("@Bank_ID", bank_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Bank_ID"] != DBNull.Value) bse_Bank.Bank_ID = Convert.ToDecimal(dr["Bank_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Bank.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Bank.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["Bank_Code"] != DBNull.Value) bse_Bank.Bank_Code = Convert.ToString(dr["Bank_Code"]);
            if (dr["Bank_Name"] != DBNull.Value) bse_Bank.Bank_Name = Convert.ToString(dr["Bank_Name"]);
            if (dr["Bank_Branch"] != DBNull.Value) bse_Bank.Bank_Branch = Convert.ToString(dr["Bank_Branch"]);
            if (dr["Bank_Card"] != DBNull.Value) bse_Bank.Bank_Card = Convert.ToString(dr["Bank_Card"]);
            if (dr["Bank_User"] != DBNull.Value) bse_Bank.Bank_User = Convert.ToString(dr["Bank_User"]);
            if (dr["Stat"] != DBNull.Value) bse_Bank.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Bank.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Bank.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Bank.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Bank_BranchName"] != DBNull.Value) bse_Bank.Bank_BranchName = Convert.ToString(dr["Bank_BranchName"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Bank;
      }
      /// <summary>
      /// 获取指定的银行信息 Bse_Bank对象集合
      /// </summary>
      public List<Bse_Bank> GetListByWhere(string strCondition)
      {
         List<Bse_Bank> ret = new List<Bse_Bank>();
         string sql = "SELECT  Bank_ID,Module_Code,Record_ID,Bank_Code,Bank_Name,Bank_Branch,Bank_Card,Bank_User,Stat,CreateDate,UpdateDate,DeleteDate,Bank_BranchName FROM Bse_Bank WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Bank bse_Bank = new Bse_Bank();
            if (dr["Bank_ID"] != DBNull.Value) bse_Bank.Bank_ID = Convert.ToDecimal(dr["Bank_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Bank.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Bank.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["Bank_Code"] != DBNull.Value) bse_Bank.Bank_Code = Convert.ToString(dr["Bank_Code"]);
            if (dr["Bank_Name"] != DBNull.Value) bse_Bank.Bank_Name = Convert.ToString(dr["Bank_Name"]);
            if (dr["Bank_Branch"] != DBNull.Value) bse_Bank.Bank_Branch = Convert.ToString(dr["Bank_Branch"]);
            if (dr["Bank_Card"] != DBNull.Value) bse_Bank.Bank_Card = Convert.ToString(dr["Bank_Card"]);
            if (dr["Bank_User"] != DBNull.Value) bse_Bank.Bank_User = Convert.ToString(dr["Bank_User"]);
            if (dr["Stat"] != DBNull.Value) bse_Bank.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Bank.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Bank.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Bank.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Bank_BranchName"] != DBNull.Value) bse_Bank.Bank_BranchName = Convert.ToString(dr["Bank_BranchName"]);
            ret.Add(bse_Bank);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的银行信息 Bse_Bank对象(即:一条记录
      /// </summary>
      public List<Bse_Bank> GetAll()
      {
         List<Bse_Bank> ret = new List<Bse_Bank>();
         string sql = "SELECT  Bank_ID,Module_Code,Record_ID,Bank_Code,Bank_Name,Bank_Branch,Bank_Card,Bank_User,Stat,CreateDate,UpdateDate,DeleteDate,Bank_BranchName FROM Bse_Bank where 1=1 AND ((Stat is null) or (Stat=0) ) order by Bank_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Bank bse_Bank = new Bse_Bank();
            if (dr["Bank_ID"] != DBNull.Value) bse_Bank.Bank_ID = Convert.ToDecimal(dr["Bank_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Bank.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Bank.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["Bank_Code"] != DBNull.Value) bse_Bank.Bank_Code = Convert.ToString(dr["Bank_Code"]);
            if (dr["Bank_Name"] != DBNull.Value) bse_Bank.Bank_Name = Convert.ToString(dr["Bank_Name"]);
            if (dr["Bank_Branch"] != DBNull.Value) bse_Bank.Bank_Branch = Convert.ToString(dr["Bank_Branch"]);
            if (dr["Bank_Card"] != DBNull.Value) bse_Bank.Bank_Card = Convert.ToString(dr["Bank_Card"]);
            if (dr["Bank_User"] != DBNull.Value) bse_Bank.Bank_User = Convert.ToString(dr["Bank_User"]);
            if (dr["Stat"] != DBNull.Value) bse_Bank.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Bank.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Bank.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Bank.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Bank_BranchName"] != DBNull.Value) bse_Bank.Bank_BranchName = Convert.ToString(dr["Bank_BranchName"]);
            ret.Add(bse_Bank);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
