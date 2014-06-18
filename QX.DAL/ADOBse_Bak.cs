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
   /// 备注信息
   /// </summary>
   [Serializable]
   public partial class ADOBse_Bak
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加备注信息 Bse_Bak对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Bak bse_Bak)
      {
         string sql = "INSERT INTO Bse_Bak (Module_Code,Record_ID,Bak_Content,Stat) VALUES (@Module_Code,@Record_ID,@Bak_Content,@Stat)";
         if (string.IsNullOrEmpty(bse_Bak.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Bak.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Bak.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Bak.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Bak.Bak_Content))
         {
            idb.AddParameter("@Bak_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bak_Content", bse_Bak.Bak_Content);
         }
         if (bse_Bak.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Bak.Stat);
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
      /// 添加备注信息 Bse_Bak对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Bak bse_Bak)
      {
         string sql = "INSERT INTO Bse_Bak (Module_Code,Record_ID,Bak_Content,Stat) VALUES (@Module_Code,@Record_ID,@Bak_Content,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Bak.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Bak.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Bak.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Bak.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Bak.Bak_Content))
         {
            idb.AddParameter("@Bak_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bak_Content", bse_Bak.Bak_Content);
         }
         if (bse_Bak.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Bak.Stat);
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
      /// 更新备注信息 Bse_Bak对象(即:一条记录
      /// </summary>
      public int Update(Bse_Bak bse_Bak)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Bak       SET ");
            if(bse_Bak.Module_Code_IsChanged){sbParameter.Append("Module_Code=@Module_Code, ");}
      if(bse_Bak.Record_ID_IsChanged){sbParameter.Append("Record_ID=@Record_ID, ");}
      if(bse_Bak.Bak_Content_IsChanged){sbParameter.Append("Bak_Content=@Bak_Content, ");}
      if(bse_Bak.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Bak_ID=@Bak_ID; " );
      string sql=sb.ToString();
         if(bse_Bak.Module_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bak.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Bak.Module_Code);
         }
          }
         if(bse_Bak.Record_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bak.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Bak.Record_ID);
         }
          }
         if(bse_Bak.Bak_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Bak.Bak_Content))
         {
            idb.AddParameter("@Bak_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Bak_Content", bse_Bak.Bak_Content);
         }
          }
         if(bse_Bak.Stat_IsChanged)
         {
         if (bse_Bak.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Bak.Stat);
         }
          }

         idb.AddParameter("@Bak_ID", bse_Bak.Bak_ID);

           
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
      /// 删除备注信息 Bse_Bak对象(即:一条记录
      /// </summary>
      public int Delete(decimal bak_ID)
      {
         string sql = "DELETE Bse_Bak WHERE 1=1  AND Bak_ID=@Bak_ID ";
         idb.AddParameter("@Bak_ID", bak_ID);

           
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
      /// 获取指定的备注信息 Bse_Bak对象(即:一条记录
      /// </summary>
      public Bse_Bak GetByKey(decimal bak_ID)
      {
         Bse_Bak bse_Bak = new Bse_Bak();
         string sql = "SELECT  Bak_ID,Module_Code,Record_ID,Bak_Content,Stat FROM Bse_Bak WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Bak_ID=@Bak_ID ";
         idb.AddParameter("@Bak_ID", bak_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Bak_ID"] != DBNull.Value) bse_Bak.Bak_ID = Convert.ToDecimal(dr["Bak_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Bak.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Bak.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["Bak_Content"] != DBNull.Value) bse_Bak.Bak_Content = Convert.ToString(dr["Bak_Content"]);
            if (dr["Stat"] != DBNull.Value) bse_Bak.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Bak;
      }
      /// <summary>
      /// 获取指定的备注信息 Bse_Bak对象集合
      /// </summary>
      public List<Bse_Bak> GetListByWhere(string strCondition)
      {
         List<Bse_Bak> ret = new List<Bse_Bak>();
         string sql = "SELECT  Bak_ID,Module_Code,Record_ID,Bak_Content,Stat FROM Bse_Bak WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Bak bse_Bak = new Bse_Bak();
            if (dr["Bak_ID"] != DBNull.Value) bse_Bak.Bak_ID = Convert.ToDecimal(dr["Bak_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Bak.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Bak.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["Bak_Content"] != DBNull.Value) bse_Bak.Bak_Content = Convert.ToString(dr["Bak_Content"]);
            if (dr["Stat"] != DBNull.Value) bse_Bak.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_Bak);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的备注信息 Bse_Bak对象(即:一条记录
      /// </summary>
      public List<Bse_Bak> GetAll()
      {
         List<Bse_Bak> ret = new List<Bse_Bak>();
         string sql = "SELECT  Bak_ID,Module_Code,Record_ID,Bak_Content,Stat FROM Bse_Bak where 1=1 AND ((Stat is null) or (Stat=0) ) order by Bak_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Bak bse_Bak = new Bse_Bak();
            if (dr["Bak_ID"] != DBNull.Value) bse_Bak.Bak_ID = Convert.ToDecimal(dr["Bak_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Bak.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Bak.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["Bak_Content"] != DBNull.Value) bse_Bak.Bak_Content = Convert.ToString(dr["Bak_Content"]);
            if (dr["Stat"] != DBNull.Value) bse_Bak.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_Bak);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
