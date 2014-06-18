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
   /// 单据主表      没有申请人，部门，时间
   /// </summary>
   [Serializable]
   public partial class ADORec_Main
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加单据主表      没有申请人，部门，时间 Rec_Main对象(即:一条记录)
      /// </summary>
      public int Add(Rec_Main rec_Main)
      {
         string sql = "INSERT INTO Rec_Main (RM_Code,Module_Code,Module_Name,RM_Name,RM_RefCode,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStat,Stat) VALUES (@RM_Code,@Module_Code,@Module_Name,@RM_Name,@RM_RefCode,@Creator,@CreateTime,@VerifyStuff,@VerifyDate,@VerifyStat,@Stat)";
         if (string.IsNullOrEmpty(rec_Main.RM_Code))
         {
            idb.AddParameter("@RM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_Code", rec_Main.RM_Code);
         }
         if (string.IsNullOrEmpty(rec_Main.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", rec_Main.Module_Code);
         }
         if (string.IsNullOrEmpty(rec_Main.Module_Name))
         {
            idb.AddParameter("@Module_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Name", rec_Main.Module_Name);
         }
         if (string.IsNullOrEmpty(rec_Main.RM_Name))
         {
            idb.AddParameter("@RM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_Name", rec_Main.RM_Name);
         }
         if (string.IsNullOrEmpty(rec_Main.RM_RefCode))
         {
            idb.AddParameter("@RM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_RefCode", rec_Main.RM_RefCode);
         }
         if (string.IsNullOrEmpty(rec_Main.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", rec_Main.Creator);
         }
         if (rec_Main.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", rec_Main.CreateTime);
         }
         if (string.IsNullOrEmpty(rec_Main.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", rec_Main.VerifyStuff);
         }
         if (rec_Main.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", rec_Main.VerifyDate);
         }
         if (string.IsNullOrEmpty(rec_Main.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", rec_Main.VerifyStat);
         }
         if (rec_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", rec_Main.Stat);
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
      /// 添加单据主表      没有申请人，部门，时间 Rec_Main对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Rec_Main rec_Main)
      {
         string sql = "INSERT INTO Rec_Main (RM_Code,Module_Code,Module_Name,RM_Name,RM_RefCode,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStat,Stat) VALUES (@RM_Code,@Module_Code,@Module_Name,@RM_Name,@RM_RefCode,@Creator,@CreateTime,@VerifyStuff,@VerifyDate,@VerifyStat,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(rec_Main.RM_Code))
         {
            idb.AddParameter("@RM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_Code", rec_Main.RM_Code);
         }
         if (string.IsNullOrEmpty(rec_Main.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", rec_Main.Module_Code);
         }
         if (string.IsNullOrEmpty(rec_Main.Module_Name))
         {
            idb.AddParameter("@Module_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Name", rec_Main.Module_Name);
         }
         if (string.IsNullOrEmpty(rec_Main.RM_Name))
         {
            idb.AddParameter("@RM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_Name", rec_Main.RM_Name);
         }
         if (string.IsNullOrEmpty(rec_Main.RM_RefCode))
         {
            idb.AddParameter("@RM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_RefCode", rec_Main.RM_RefCode);
         }
         if (string.IsNullOrEmpty(rec_Main.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", rec_Main.Creator);
         }
         if (rec_Main.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", rec_Main.CreateTime);
         }
         if (string.IsNullOrEmpty(rec_Main.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", rec_Main.VerifyStuff);
         }
         if (rec_Main.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", rec_Main.VerifyDate);
         }
         if (string.IsNullOrEmpty(rec_Main.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", rec_Main.VerifyStat);
         }
         if (rec_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", rec_Main.Stat);
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
      /// 更新单据主表      没有申请人，部门，时间 Rec_Main对象(即:一条记录
      /// </summary>
      public int Update(Rec_Main rec_Main)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Rec_Main       SET ");
            if(rec_Main.RM_Code_IsChanged){sbParameter.Append("RM_Code=@RM_Code, ");}
      if(rec_Main.Module_Code_IsChanged){sbParameter.Append("Module_Code=@Module_Code, ");}
      if(rec_Main.Module_Name_IsChanged){sbParameter.Append("Module_Name=@Module_Name, ");}
      if(rec_Main.RM_Name_IsChanged){sbParameter.Append("RM_Name=@RM_Name, ");}
      if(rec_Main.RM_RefCode_IsChanged){sbParameter.Append("RM_RefCode=@RM_RefCode, ");}
      if(rec_Main.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(rec_Main.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(rec_Main.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(rec_Main.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(rec_Main.VerifyStat_IsChanged){sbParameter.Append("VerifyStat=@VerifyStat, ");}
      if(rec_Main.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RM_ID=@RM_ID; " );
      string sql=sb.ToString();
         if(rec_Main.RM_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.RM_Code))
         {
            idb.AddParameter("@RM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_Code", rec_Main.RM_Code);
         }
          }
         if(rec_Main.Module_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", rec_Main.Module_Code);
         }
          }
         if(rec_Main.Module_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.Module_Name))
         {
            idb.AddParameter("@Module_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Name", rec_Main.Module_Name);
         }
          }
         if(rec_Main.RM_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.RM_Name))
         {
            idb.AddParameter("@RM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_Name", rec_Main.RM_Name);
         }
          }
         if(rec_Main.RM_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.RM_RefCode))
         {
            idb.AddParameter("@RM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RM_RefCode", rec_Main.RM_RefCode);
         }
          }
         if(rec_Main.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", rec_Main.Creator);
         }
          }
         if(rec_Main.CreateTime_IsChanged)
         {
         if (rec_Main.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", rec_Main.CreateTime);
         }
          }
         if(rec_Main.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", rec_Main.VerifyStuff);
         }
          }
         if(rec_Main.VerifyDate_IsChanged)
         {
         if (rec_Main.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", rec_Main.VerifyDate);
         }
          }
         if(rec_Main.VerifyStat_IsChanged)
         {
         if (string.IsNullOrEmpty(rec_Main.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", rec_Main.VerifyStat);
         }
          }
         if(rec_Main.Stat_IsChanged)
         {
         if (rec_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", rec_Main.Stat);
         }
          }

         idb.AddParameter("@RM_ID", rec_Main.RM_ID);

           
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
      /// 删除单据主表      没有申请人，部门，时间 Rec_Main对象(即:一条记录
      /// </summary>
      public int Delete(decimal rM_ID)
      {
         string sql = "DELETE Rec_Main WHERE 1=1  AND RM_ID=@RM_ID ";
         idb.AddParameter("@RM_ID", rM_ID);

           
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
      /// 获取指定的单据主表      没有申请人，部门，时间 Rec_Main对象(即:一条记录
      /// </summary>
      public Rec_Main GetByKey(decimal rM_ID)
      {
         Rec_Main rec_Main = new Rec_Main();
         string sql = "SELECT  RM_ID,RM_Code,Module_Code,Module_Name,RM_Name,RM_RefCode,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStat,Stat FROM Rec_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RM_ID=@RM_ID ";
         idb.AddParameter("@RM_ID", rM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RM_ID"] != DBNull.Value) rec_Main.RM_ID = Convert.ToDecimal(dr["RM_ID"]);
            if (dr["RM_Code"] != DBNull.Value) rec_Main.RM_Code = Convert.ToString(dr["RM_Code"]);
            if (dr["Module_Code"] != DBNull.Value) rec_Main.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Module_Name"] != DBNull.Value) rec_Main.Module_Name = Convert.ToString(dr["Module_Name"]);
            if (dr["RM_Name"] != DBNull.Value) rec_Main.RM_Name = Convert.ToString(dr["RM_Name"]);
            if (dr["RM_RefCode"] != DBNull.Value) rec_Main.RM_RefCode = Convert.ToString(dr["RM_RefCode"]);
            if (dr["Creator"] != DBNull.Value) rec_Main.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) rec_Main.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStuff"] != DBNull.Value) rec_Main.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) rec_Main.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStat"] != DBNull.Value) rec_Main.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["Stat"] != DBNull.Value) rec_Main.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return rec_Main;
      }
      /// <summary>
      /// 获取指定的单据主表      没有申请人，部门，时间 Rec_Main对象集合
      /// </summary>
      public List<Rec_Main> GetListByWhere(string strCondition)
      {
         List<Rec_Main> ret = new List<Rec_Main>();
         string sql = "SELECT  RM_ID,RM_Code,Module_Code,Module_Name,RM_Name,RM_RefCode,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStat,Stat FROM Rec_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Rec_Main rec_Main = new Rec_Main();
            if (dr["RM_ID"] != DBNull.Value) rec_Main.RM_ID = Convert.ToDecimal(dr["RM_ID"]);
            if (dr["RM_Code"] != DBNull.Value) rec_Main.RM_Code = Convert.ToString(dr["RM_Code"]);
            if (dr["Module_Code"] != DBNull.Value) rec_Main.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Module_Name"] != DBNull.Value) rec_Main.Module_Name = Convert.ToString(dr["Module_Name"]);
            if (dr["RM_Name"] != DBNull.Value) rec_Main.RM_Name = Convert.ToString(dr["RM_Name"]);
            if (dr["RM_RefCode"] != DBNull.Value) rec_Main.RM_RefCode = Convert.ToString(dr["RM_RefCode"]);
            if (dr["Creator"] != DBNull.Value) rec_Main.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) rec_Main.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStuff"] != DBNull.Value) rec_Main.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) rec_Main.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStat"] != DBNull.Value) rec_Main.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["Stat"] != DBNull.Value) rec_Main.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(rec_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的单据主表      没有申请人，部门，时间 Rec_Main对象(即:一条记录
      /// </summary>
      public List<Rec_Main> GetAll()
      {
         List<Rec_Main> ret = new List<Rec_Main>();
         string sql = "SELECT  RM_ID,RM_Code,Module_Code,Module_Name,RM_Name,RM_RefCode,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStat,Stat FROM Rec_Main where 1=1 AND ((Stat is null) or (Stat=0) ) order by RM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Rec_Main rec_Main = new Rec_Main();
            if (dr["RM_ID"] != DBNull.Value) rec_Main.RM_ID = Convert.ToDecimal(dr["RM_ID"]);
            if (dr["RM_Code"] != DBNull.Value) rec_Main.RM_Code = Convert.ToString(dr["RM_Code"]);
            if (dr["Module_Code"] != DBNull.Value) rec_Main.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Module_Name"] != DBNull.Value) rec_Main.Module_Name = Convert.ToString(dr["Module_Name"]);
            if (dr["RM_Name"] != DBNull.Value) rec_Main.RM_Name = Convert.ToString(dr["RM_Name"]);
            if (dr["RM_RefCode"] != DBNull.Value) rec_Main.RM_RefCode = Convert.ToString(dr["RM_RefCode"]);
            if (dr["Creator"] != DBNull.Value) rec_Main.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) rec_Main.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStuff"] != DBNull.Value) rec_Main.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) rec_Main.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStat"] != DBNull.Value) rec_Main.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["Stat"] != DBNull.Value) rec_Main.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(rec_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
