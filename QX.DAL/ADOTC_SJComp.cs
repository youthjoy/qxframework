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
   public partial class ADOTC_SJComp
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加TC_SJComp对象(即:一条记录)
      /// </summary>
      public int Add(TC_SJComp tC_SJComp)
      {
         string sql = "INSERT INTO TC_SJComp (TCJ_Code,TCJ_Name,TCJ_PLine,TCJ_Stat,Stat,CreateDate,UpdateDate,DeleteDate,TCJ_Udef1,TCJ_Udef2,TCJ_Udef3,TCJ_Udef4,TCJ_Udef5) VALUES (@TCJ_Code,@TCJ_Name,@TCJ_PLine,@TCJ_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@TCJ_Udef1,@TCJ_Udef2,@TCJ_Udef3,@TCJ_Udef4,@TCJ_Udef5)";
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Code))
         {
            idb.AddParameter("@TCJ_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Code", tC_SJComp.TCJ_Code);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Name))
         {
            idb.AddParameter("@TCJ_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Name", tC_SJComp.TCJ_Name);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_PLine))
         {
            idb.AddParameter("@TCJ_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_PLine", tC_SJComp.TCJ_PLine);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Stat))
         {
            idb.AddParameter("@TCJ_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Stat", tC_SJComp.TCJ_Stat);
         }
         if (tC_SJComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SJComp.Stat);
         }
         if (tC_SJComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SJComp.CreateDate);
         }
         if (tC_SJComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SJComp.UpdateDate);
         }
         if (tC_SJComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SJComp.DeleteDate);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef1))
         {
            idb.AddParameter("@TCJ_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef1", tC_SJComp.TCJ_Udef1);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef2))
         {
            idb.AddParameter("@TCJ_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef2", tC_SJComp.TCJ_Udef2);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef3))
         {
            idb.AddParameter("@TCJ_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef3", tC_SJComp.TCJ_Udef3);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef4))
         {
            idb.AddParameter("@TCJ_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef4", tC_SJComp.TCJ_Udef4);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef5))
         {
            idb.AddParameter("@TCJ_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef5", tC_SJComp.TCJ_Udef5);
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
      /// 添加TC_SJComp对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_SJComp tC_SJComp)
      {
         string sql = "INSERT INTO TC_SJComp (TCJ_Code,TCJ_Name,TCJ_PLine,TCJ_Stat,Stat,CreateDate,UpdateDate,DeleteDate,TCJ_Udef1,TCJ_Udef2,TCJ_Udef3,TCJ_Udef4,TCJ_Udef5) VALUES (@TCJ_Code,@TCJ_Name,@TCJ_PLine,@TCJ_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@TCJ_Udef1,@TCJ_Udef2,@TCJ_Udef3,@TCJ_Udef4,@TCJ_Udef5);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Code))
         {
            idb.AddParameter("@TCJ_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Code", tC_SJComp.TCJ_Code);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Name))
         {
            idb.AddParameter("@TCJ_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Name", tC_SJComp.TCJ_Name);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_PLine))
         {
            idb.AddParameter("@TCJ_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_PLine", tC_SJComp.TCJ_PLine);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Stat))
         {
            idb.AddParameter("@TCJ_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Stat", tC_SJComp.TCJ_Stat);
         }
         if (tC_SJComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SJComp.Stat);
         }
         if (tC_SJComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SJComp.CreateDate);
         }
         if (tC_SJComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SJComp.UpdateDate);
         }
         if (tC_SJComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SJComp.DeleteDate);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef1))
         {
            idb.AddParameter("@TCJ_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef1", tC_SJComp.TCJ_Udef1);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef2))
         {
            idb.AddParameter("@TCJ_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef2", tC_SJComp.TCJ_Udef2);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef3))
         {
            idb.AddParameter("@TCJ_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef3", tC_SJComp.TCJ_Udef3);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef4))
         {
            idb.AddParameter("@TCJ_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef4", tC_SJComp.TCJ_Udef4);
         }
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef5))
         {
            idb.AddParameter("@TCJ_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef5", tC_SJComp.TCJ_Udef5);
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
      /// 更新TC_SJComp对象(即:一条记录
      /// </summary>
      public int Update(TC_SJComp tC_SJComp)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_SJComp       SET ");
            if(tC_SJComp.TCJ_Code_IsChanged){sbParameter.Append("TCJ_Code=@TCJ_Code, ");}
      if(tC_SJComp.TCJ_Name_IsChanged){sbParameter.Append("TCJ_Name=@TCJ_Name, ");}
      if(tC_SJComp.TCJ_PLine_IsChanged){sbParameter.Append("TCJ_PLine=@TCJ_PLine, ");}
      if(tC_SJComp.TCJ_Stat_IsChanged){sbParameter.Append("TCJ_Stat=@TCJ_Stat, ");}
      if(tC_SJComp.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_SJComp.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_SJComp.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_SJComp.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(tC_SJComp.TCJ_Udef1_IsChanged){sbParameter.Append("TCJ_Udef1=@TCJ_Udef1, ");}
      if(tC_SJComp.TCJ_Udef2_IsChanged){sbParameter.Append("TCJ_Udef2=@TCJ_Udef2, ");}
      if(tC_SJComp.TCJ_Udef3_IsChanged){sbParameter.Append("TCJ_Udef3=@TCJ_Udef3, ");}
      if(tC_SJComp.TCJ_Udef4_IsChanged){sbParameter.Append("TCJ_Udef4=@TCJ_Udef4, ");}
      if(tC_SJComp.TCJ_Udef5_IsChanged){sbParameter.Append("TCJ_Udef5=@TCJ_Udef5 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCJ_ID=@TCJ_ID; " );
      string sql=sb.ToString();
         if(tC_SJComp.TCJ_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Code))
         {
            idb.AddParameter("@TCJ_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Code", tC_SJComp.TCJ_Code);
         }
          }
         if(tC_SJComp.TCJ_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Name))
         {
            idb.AddParameter("@TCJ_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Name", tC_SJComp.TCJ_Name);
         }
          }
         if(tC_SJComp.TCJ_PLine_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_PLine))
         {
            idb.AddParameter("@TCJ_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_PLine", tC_SJComp.TCJ_PLine);
         }
          }
         if(tC_SJComp.TCJ_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Stat))
         {
            idb.AddParameter("@TCJ_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Stat", tC_SJComp.TCJ_Stat);
         }
          }
         if(tC_SJComp.Stat_IsChanged)
         {
         if (tC_SJComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SJComp.Stat);
         }
          }
         if(tC_SJComp.CreateDate_IsChanged)
         {
         if (tC_SJComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SJComp.CreateDate);
         }
          }
         if(tC_SJComp.UpdateDate_IsChanged)
         {
         if (tC_SJComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SJComp.UpdateDate);
         }
          }
         if(tC_SJComp.DeleteDate_IsChanged)
         {
         if (tC_SJComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SJComp.DeleteDate);
         }
          }
         if(tC_SJComp.TCJ_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef1))
         {
            idb.AddParameter("@TCJ_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef1", tC_SJComp.TCJ_Udef1);
         }
          }
         if(tC_SJComp.TCJ_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef2))
         {
            idb.AddParameter("@TCJ_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef2", tC_SJComp.TCJ_Udef2);
         }
          }
         if(tC_SJComp.TCJ_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef3))
         {
            idb.AddParameter("@TCJ_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef3", tC_SJComp.TCJ_Udef3);
         }
          }
         if(tC_SJComp.TCJ_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef4))
         {
            idb.AddParameter("@TCJ_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef4", tC_SJComp.TCJ_Udef4);
         }
          }
         if(tC_SJComp.TCJ_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SJComp.TCJ_Udef5))
         {
            idb.AddParameter("@TCJ_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCJ_Udef5", tC_SJComp.TCJ_Udef5);
         }
          }

         idb.AddParameter("@TCJ_ID", tC_SJComp.TCJ_ID);

           
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
      /// 删除TC_SJComp对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCJ_ID)
      {
         string sql = "DELETE TC_SJComp WHERE 1=1  AND TCJ_ID=@TCJ_ID ";
         idb.AddParameter("@TCJ_ID", tCJ_ID);

           
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
      /// 获取指定的TC_SJComp对象(即:一条记录
      /// </summary>
      public TC_SJComp GetByKey(decimal tCJ_ID)
      {
         TC_SJComp tC_SJComp = new TC_SJComp();
         string sql = "SELECT  TCJ_ID,TCJ_Code,TCJ_Name,TCJ_PLine,TCJ_Stat,Stat,CreateDate,UpdateDate,DeleteDate,TCJ_Udef1,TCJ_Udef2,TCJ_Udef3,TCJ_Udef4,TCJ_Udef5 FROM TC_SJComp WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCJ_ID=@TCJ_ID ";
         idb.AddParameter("@TCJ_ID", tCJ_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCJ_ID"] != DBNull.Value) tC_SJComp.TCJ_ID = Convert.ToDecimal(dr["TCJ_ID"]);
            if (dr["TCJ_Code"] != DBNull.Value) tC_SJComp.TCJ_Code = Convert.ToString(dr["TCJ_Code"]);
            if (dr["TCJ_Name"] != DBNull.Value) tC_SJComp.TCJ_Name = Convert.ToString(dr["TCJ_Name"]);
            if (dr["TCJ_PLine"] != DBNull.Value) tC_SJComp.TCJ_PLine = Convert.ToString(dr["TCJ_PLine"]);
            if (dr["TCJ_Stat"] != DBNull.Value) tC_SJComp.TCJ_Stat = Convert.ToString(dr["TCJ_Stat"]);
            if (dr["Stat"] != DBNull.Value) tC_SJComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SJComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SJComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SJComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCJ_Udef1"] != DBNull.Value) tC_SJComp.TCJ_Udef1 = Convert.ToString(dr["TCJ_Udef1"]);
            if (dr["TCJ_Udef2"] != DBNull.Value) tC_SJComp.TCJ_Udef2 = Convert.ToString(dr["TCJ_Udef2"]);
            if (dr["TCJ_Udef3"] != DBNull.Value) tC_SJComp.TCJ_Udef3 = Convert.ToString(dr["TCJ_Udef3"]);
            if (dr["TCJ_Udef4"] != DBNull.Value) tC_SJComp.TCJ_Udef4 = Convert.ToString(dr["TCJ_Udef4"]);
            if (dr["TCJ_Udef5"] != DBNull.Value) tC_SJComp.TCJ_Udef5 = Convert.ToString(dr["TCJ_Udef5"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_SJComp;
      }
      /// <summary>
      /// 获取指定的TC_SJComp对象集合
      /// </summary>
      public List<TC_SJComp> GetListByWhere(string strCondition)
      {
         List<TC_SJComp> ret = new List<TC_SJComp>();
         string sql = "SELECT  TCJ_ID,TCJ_Code,TCJ_Name,TCJ_PLine,TCJ_Stat,Stat,CreateDate,UpdateDate,DeleteDate,TCJ_Udef1,TCJ_Udef2,TCJ_Udef3,TCJ_Udef4,TCJ_Udef5 FROM TC_SJComp WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_SJComp tC_SJComp = new TC_SJComp();
            if (dr["TCJ_ID"] != DBNull.Value) tC_SJComp.TCJ_ID = Convert.ToDecimal(dr["TCJ_ID"]);
            if (dr["TCJ_Code"] != DBNull.Value) tC_SJComp.TCJ_Code = Convert.ToString(dr["TCJ_Code"]);
            if (dr["TCJ_Name"] != DBNull.Value) tC_SJComp.TCJ_Name = Convert.ToString(dr["TCJ_Name"]);
            if (dr["TCJ_PLine"] != DBNull.Value) tC_SJComp.TCJ_PLine = Convert.ToString(dr["TCJ_PLine"]);
            if (dr["TCJ_Stat"] != DBNull.Value) tC_SJComp.TCJ_Stat = Convert.ToString(dr["TCJ_Stat"]);
            if (dr["Stat"] != DBNull.Value) tC_SJComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SJComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SJComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SJComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCJ_Udef1"] != DBNull.Value) tC_SJComp.TCJ_Udef1 = Convert.ToString(dr["TCJ_Udef1"]);
            if (dr["TCJ_Udef2"] != DBNull.Value) tC_SJComp.TCJ_Udef2 = Convert.ToString(dr["TCJ_Udef2"]);
            if (dr["TCJ_Udef3"] != DBNull.Value) tC_SJComp.TCJ_Udef3 = Convert.ToString(dr["TCJ_Udef3"]);
            if (dr["TCJ_Udef4"] != DBNull.Value) tC_SJComp.TCJ_Udef4 = Convert.ToString(dr["TCJ_Udef4"]);
            if (dr["TCJ_Udef5"] != DBNull.Value) tC_SJComp.TCJ_Udef5 = Convert.ToString(dr["TCJ_Udef5"]);
            ret.Add(tC_SJComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的TC_SJComp对象(即:一条记录
      /// </summary>
      public List<TC_SJComp> GetAll()
      {
         List<TC_SJComp> ret = new List<TC_SJComp>();
         string sql = "SELECT  TCJ_ID,TCJ_Code,TCJ_Name,TCJ_PLine,TCJ_Stat,Stat,CreateDate,UpdateDate,DeleteDate,TCJ_Udef1,TCJ_Udef2,TCJ_Udef3,TCJ_Udef4,TCJ_Udef5 FROM TC_SJComp where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCJ_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_SJComp tC_SJComp = new TC_SJComp();
            if (dr["TCJ_ID"] != DBNull.Value) tC_SJComp.TCJ_ID = Convert.ToDecimal(dr["TCJ_ID"]);
            if (dr["TCJ_Code"] != DBNull.Value) tC_SJComp.TCJ_Code = Convert.ToString(dr["TCJ_Code"]);
            if (dr["TCJ_Name"] != DBNull.Value) tC_SJComp.TCJ_Name = Convert.ToString(dr["TCJ_Name"]);
            if (dr["TCJ_PLine"] != DBNull.Value) tC_SJComp.TCJ_PLine = Convert.ToString(dr["TCJ_PLine"]);
            if (dr["TCJ_Stat"] != DBNull.Value) tC_SJComp.TCJ_Stat = Convert.ToString(dr["TCJ_Stat"]);
            if (dr["Stat"] != DBNull.Value) tC_SJComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SJComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SJComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SJComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCJ_Udef1"] != DBNull.Value) tC_SJComp.TCJ_Udef1 = Convert.ToString(dr["TCJ_Udef1"]);
            if (dr["TCJ_Udef2"] != DBNull.Value) tC_SJComp.TCJ_Udef2 = Convert.ToString(dr["TCJ_Udef2"]);
            if (dr["TCJ_Udef3"] != DBNull.Value) tC_SJComp.TCJ_Udef3 = Convert.ToString(dr["TCJ_Udef3"]);
            if (dr["TCJ_Udef4"] != DBNull.Value) tC_SJComp.TCJ_Udef4 = Convert.ToString(dr["TCJ_Udef4"]);
            if (dr["TCJ_Udef5"] != DBNull.Value) tC_SJComp.TCJ_Udef5 = Convert.ToString(dr["TCJ_Udef5"]);
            ret.Add(tC_SJComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
