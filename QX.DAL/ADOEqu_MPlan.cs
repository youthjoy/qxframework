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
   /// 设备检修计划
   /// </summary>
   [Serializable]
   public partial class ADOEqu_MPlan
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加设备检修计划 Equ_MPlan对象(即:一条记录)
      /// </summary>
      public int Add(Equ_MPlan equ_MPlan)
      {
         string sql = "INSERT INTO Equ_MPlan (MP_Code,MP_Name,MP_Stuff,MP_Start,MP_End,VerifyStuff,VerifyStat,VerifyDate,Stat,MP_ECode,MP_EName) VALUES (@MP_Code,@MP_Name,@MP_Stuff,@MP_Start,@MP_End,@VerifyStuff,@VerifyStat,@VerifyDate,@Stat,@MP_ECode,@MP_EName)";
         if (string.IsNullOrEmpty(equ_MPlan.MP_Code))
         {
            idb.AddParameter("@MP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Code", equ_MPlan.MP_Code);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_Name))
         {
            idb.AddParameter("@MP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Name", equ_MPlan.MP_Name);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_Stuff))
         {
            idb.AddParameter("@MP_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Stuff", equ_MPlan.MP_Stuff);
         }
         if (equ_MPlan.MP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@MP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Start", equ_MPlan.MP_Start);
         }
         if (equ_MPlan.MP_End == DateTime.MinValue)
         {
            idb.AddParameter("@MP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_End", equ_MPlan.MP_End);
         }
         if (string.IsNullOrEmpty(equ_MPlan.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", equ_MPlan.VerifyStuff);
         }
         if (string.IsNullOrEmpty(equ_MPlan.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", equ_MPlan.VerifyStat);
         }
         if (equ_MPlan.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", equ_MPlan.VerifyDate);
         }
         if (equ_MPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_MPlan.Stat);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_ECode))
         {
            idb.AddParameter("@MP_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_ECode", equ_MPlan.MP_ECode);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_EName))
         {
            idb.AddParameter("@MP_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_EName", equ_MPlan.MP_EName);
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
      /// 添加设备检修计划 Equ_MPlan对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Equ_MPlan equ_MPlan)
      {
         string sql = "INSERT INTO Equ_MPlan (MP_Code,MP_Name,MP_Stuff,MP_Start,MP_End,VerifyStuff,VerifyStat,VerifyDate,Stat,MP_ECode,MP_EName) VALUES (@MP_Code,@MP_Name,@MP_Stuff,@MP_Start,@MP_End,@VerifyStuff,@VerifyStat,@VerifyDate,@Stat,@MP_ECode,@MP_EName);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(equ_MPlan.MP_Code))
         {
            idb.AddParameter("@MP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Code", equ_MPlan.MP_Code);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_Name))
         {
            idb.AddParameter("@MP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Name", equ_MPlan.MP_Name);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_Stuff))
         {
            idb.AddParameter("@MP_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Stuff", equ_MPlan.MP_Stuff);
         }
         if (equ_MPlan.MP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@MP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Start", equ_MPlan.MP_Start);
         }
         if (equ_MPlan.MP_End == DateTime.MinValue)
         {
            idb.AddParameter("@MP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_End", equ_MPlan.MP_End);
         }
         if (string.IsNullOrEmpty(equ_MPlan.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", equ_MPlan.VerifyStuff);
         }
         if (string.IsNullOrEmpty(equ_MPlan.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", equ_MPlan.VerifyStat);
         }
         if (equ_MPlan.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", equ_MPlan.VerifyDate);
         }
         if (equ_MPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_MPlan.Stat);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_ECode))
         {
            idb.AddParameter("@MP_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_ECode", equ_MPlan.MP_ECode);
         }
         if (string.IsNullOrEmpty(equ_MPlan.MP_EName))
         {
            idb.AddParameter("@MP_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_EName", equ_MPlan.MP_EName);
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
      /// 更新设备检修计划 Equ_MPlan对象(即:一条记录
      /// </summary>
      public int Update(Equ_MPlan equ_MPlan)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Equ_MPlan       SET ");
            if(equ_MPlan.MP_Code_IsChanged){sbParameter.Append("MP_Code=@MP_Code, ");}
      if(equ_MPlan.MP_Name_IsChanged){sbParameter.Append("MP_Name=@MP_Name, ");}
      if(equ_MPlan.MP_Stuff_IsChanged){sbParameter.Append("MP_Stuff=@MP_Stuff, ");}
      if(equ_MPlan.MP_Start_IsChanged){sbParameter.Append("MP_Start=@MP_Start, ");}
      if(equ_MPlan.MP_End_IsChanged){sbParameter.Append("MP_End=@MP_End, ");}
      if(equ_MPlan.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(equ_MPlan.VerifyStat_IsChanged){sbParameter.Append("VerifyStat=@VerifyStat, ");}
      if(equ_MPlan.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(equ_MPlan.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(equ_MPlan.MP_ECode_IsChanged){sbParameter.Append("MP_ECode=@MP_ECode, ");}
      if(equ_MPlan.MP_EName_IsChanged){sbParameter.Append("MP_EName=@MP_EName ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MP_ID=@MP_ID; " );
      string sql=sb.ToString();
         if(equ_MPlan.MP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MPlan.MP_Code))
         {
            idb.AddParameter("@MP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Code", equ_MPlan.MP_Code);
         }
          }
         if(equ_MPlan.MP_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MPlan.MP_Name))
         {
            idb.AddParameter("@MP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Name", equ_MPlan.MP_Name);
         }
          }
         if(equ_MPlan.MP_Stuff_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MPlan.MP_Stuff))
         {
            idb.AddParameter("@MP_Stuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Stuff", equ_MPlan.MP_Stuff);
         }
          }
         if(equ_MPlan.MP_Start_IsChanged)
         {
         if (equ_MPlan.MP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@MP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_Start", equ_MPlan.MP_Start);
         }
          }
         if(equ_MPlan.MP_End_IsChanged)
         {
         if (equ_MPlan.MP_End == DateTime.MinValue)
         {
            idb.AddParameter("@MP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_End", equ_MPlan.MP_End);
         }
          }
         if(equ_MPlan.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MPlan.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", equ_MPlan.VerifyStuff);
         }
          }
         if(equ_MPlan.VerifyStat_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MPlan.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", equ_MPlan.VerifyStat);
         }
          }
         if(equ_MPlan.VerifyDate_IsChanged)
         {
         if (equ_MPlan.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", equ_MPlan.VerifyDate);
         }
          }
         if(equ_MPlan.Stat_IsChanged)
         {
         if (equ_MPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_MPlan.Stat);
         }
          }
         if(equ_MPlan.MP_ECode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MPlan.MP_ECode))
         {
            idb.AddParameter("@MP_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_ECode", equ_MPlan.MP_ECode);
         }
          }
         if(equ_MPlan.MP_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MPlan.MP_EName))
         {
            idb.AddParameter("@MP_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MP_EName", equ_MPlan.MP_EName);
         }
          }

         idb.AddParameter("@MP_ID", equ_MPlan.MP_ID);

           
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
      /// 删除设备检修计划 Equ_MPlan对象(即:一条记录
      /// </summary>
      public int Delete(decimal mP_ID)
      {
         string sql = "DELETE Equ_MPlan WHERE 1=1  AND MP_ID=@MP_ID ";
         idb.AddParameter("@MP_ID", mP_ID);

           
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
      /// 获取指定的设备检修计划 Equ_MPlan对象(即:一条记录
      /// </summary>
      public Equ_MPlan GetByKey(decimal mP_ID)
      {
         Equ_MPlan equ_MPlan = new Equ_MPlan();
         string sql = "SELECT  MP_ID,MP_Code,MP_Name,MP_Stuff,MP_Start,MP_End,VerifyStuff,VerifyStat,VerifyDate,Stat,MP_ECode,MP_EName FROM Equ_MPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MP_ID=@MP_ID ";
         idb.AddParameter("@MP_ID", mP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MP_ID"] != DBNull.Value) equ_MPlan.MP_ID = Convert.ToDecimal(dr["MP_ID"]);
            if (dr["MP_Code"] != DBNull.Value) equ_MPlan.MP_Code = Convert.ToString(dr["MP_Code"]);
            if (dr["MP_Name"] != DBNull.Value) equ_MPlan.MP_Name = Convert.ToString(dr["MP_Name"]);
            if (dr["MP_Stuff"] != DBNull.Value) equ_MPlan.MP_Stuff = Convert.ToString(dr["MP_Stuff"]);
            if (dr["MP_Start"] != DBNull.Value) equ_MPlan.MP_Start = Convert.ToDateTime(dr["MP_Start"]);
            if (dr["MP_End"] != DBNull.Value) equ_MPlan.MP_End = Convert.ToDateTime(dr["MP_End"]);
            if (dr["VerifyStuff"] != DBNull.Value) equ_MPlan.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyStat"] != DBNull.Value) equ_MPlan.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) equ_MPlan.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) equ_MPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MP_ECode"] != DBNull.Value) equ_MPlan.MP_ECode = Convert.ToString(dr["MP_ECode"]);
            if (dr["MP_EName"] != DBNull.Value) equ_MPlan.MP_EName = Convert.ToString(dr["MP_EName"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return equ_MPlan;
      }
      /// <summary>
      /// 获取指定的设备检修计划 Equ_MPlan对象集合
      /// </summary>
      public List<Equ_MPlan> GetListByWhere(string strCondition)
      {
         List<Equ_MPlan> ret = new List<Equ_MPlan>();
         string sql = "SELECT  MP_ID,MP_Code,MP_Name,MP_Stuff,MP_Start,MP_End,VerifyStuff,VerifyStat,VerifyDate,Stat,MP_ECode,MP_EName FROM Equ_MPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Equ_MPlan equ_MPlan = new Equ_MPlan();
            if (dr["MP_ID"] != DBNull.Value) equ_MPlan.MP_ID = Convert.ToDecimal(dr["MP_ID"]);
            if (dr["MP_Code"] != DBNull.Value) equ_MPlan.MP_Code = Convert.ToString(dr["MP_Code"]);
            if (dr["MP_Name"] != DBNull.Value) equ_MPlan.MP_Name = Convert.ToString(dr["MP_Name"]);
            if (dr["MP_Stuff"] != DBNull.Value) equ_MPlan.MP_Stuff = Convert.ToString(dr["MP_Stuff"]);
            if (dr["MP_Start"] != DBNull.Value) equ_MPlan.MP_Start = Convert.ToDateTime(dr["MP_Start"]);
            if (dr["MP_End"] != DBNull.Value) equ_MPlan.MP_End = Convert.ToDateTime(dr["MP_End"]);
            if (dr["VerifyStuff"] != DBNull.Value) equ_MPlan.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyStat"] != DBNull.Value) equ_MPlan.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) equ_MPlan.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) equ_MPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MP_ECode"] != DBNull.Value) equ_MPlan.MP_ECode = Convert.ToString(dr["MP_ECode"]);
            if (dr["MP_EName"] != DBNull.Value) equ_MPlan.MP_EName = Convert.ToString(dr["MP_EName"]);
            ret.Add(equ_MPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的设备检修计划 Equ_MPlan对象(即:一条记录
      /// </summary>
      public List<Equ_MPlan> GetAll()
      {
         List<Equ_MPlan> ret = new List<Equ_MPlan>();
         string sql = "SELECT  MP_ID,MP_Code,MP_Name,MP_Stuff,MP_Start,MP_End,VerifyStuff,VerifyStat,VerifyDate,Stat,MP_ECode,MP_EName FROM Equ_MPlan where 1=1 AND ((Stat is null) or (Stat=0) ) order by MP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Equ_MPlan equ_MPlan = new Equ_MPlan();
            if (dr["MP_ID"] != DBNull.Value) equ_MPlan.MP_ID = Convert.ToDecimal(dr["MP_ID"]);
            if (dr["MP_Code"] != DBNull.Value) equ_MPlan.MP_Code = Convert.ToString(dr["MP_Code"]);
            if (dr["MP_Name"] != DBNull.Value) equ_MPlan.MP_Name = Convert.ToString(dr["MP_Name"]);
            if (dr["MP_Stuff"] != DBNull.Value) equ_MPlan.MP_Stuff = Convert.ToString(dr["MP_Stuff"]);
            if (dr["MP_Start"] != DBNull.Value) equ_MPlan.MP_Start = Convert.ToDateTime(dr["MP_Start"]);
            if (dr["MP_End"] != DBNull.Value) equ_MPlan.MP_End = Convert.ToDateTime(dr["MP_End"]);
            if (dr["VerifyStuff"] != DBNull.Value) equ_MPlan.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyStat"] != DBNull.Value) equ_MPlan.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) equ_MPlan.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["Stat"] != DBNull.Value) equ_MPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MP_ECode"] != DBNull.Value) equ_MPlan.MP_ECode = Convert.ToString(dr["MP_ECode"]);
            if (dr["MP_EName"] != DBNull.Value) equ_MPlan.MP_EName = Convert.ToString(dr["MP_EName"]);
            ret.Add(equ_MPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
