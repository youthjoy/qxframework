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
   /// 设备检修记录
   /// </summary>
   [Serializable]
   public partial class ADOEqu_MRecords
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加设备检修记录 Equ_MRecords对象(即:一条记录)
      /// </summary>
      public int Add(Equ_MRecords equ_MRecords)
      {
         string sql = "INSERT INTO Equ_MRecords (MR_ECode,MR_EName,MR_Start,MR_End,MR_FType,MR_Content,MR_MStuff,VerifyStuff,VerifyDate,MR_Bak,Creator,CreateTime,Stat,MR_MPCode,MR_Type) VALUES (@MR_ECode,@MR_EName,@MR_Start,@MR_End,@MR_FType,@MR_Content,@MR_MStuff,@VerifyStuff,@VerifyDate,@MR_Bak,@Creator,@CreateTime,@Stat,@MR_MPCode,@MR_Type)";
         if (string.IsNullOrEmpty(equ_MRecords.MR_ECode))
         {
            idb.AddParameter("@MR_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_ECode", equ_MRecords.MR_ECode);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_EName))
         {
            idb.AddParameter("@MR_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_EName", equ_MRecords.MR_EName);
         }
         if (equ_MRecords.MR_Start == DateTime.MinValue)
         {
            idb.AddParameter("@MR_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Start", equ_MRecords.MR_Start);
         }
         if (equ_MRecords.MR_End == DateTime.MinValue)
         {
            idb.AddParameter("@MR_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_End", equ_MRecords.MR_End);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_FType))
         {
            idb.AddParameter("@MR_FType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_FType", equ_MRecords.MR_FType);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_Content))
         {
            idb.AddParameter("@MR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Content", equ_MRecords.MR_Content);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_MStuff))
         {
            idb.AddParameter("@MR_MStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_MStuff", equ_MRecords.MR_MStuff);
         }
         if (string.IsNullOrEmpty(equ_MRecords.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", equ_MRecords.VerifyStuff);
         }
         if (equ_MRecords.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", equ_MRecords.VerifyDate);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_Bak))
         {
            idb.AddParameter("@MR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Bak", equ_MRecords.MR_Bak);
         }
         if (string.IsNullOrEmpty(equ_MRecords.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", equ_MRecords.Creator);
         }
         if (equ_MRecords.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", equ_MRecords.CreateTime);
         }
         if (equ_MRecords.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_MRecords.Stat);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_MPCode))
         {
            idb.AddParameter("@MR_MPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_MPCode", equ_MRecords.MR_MPCode);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_Type))
         {
            idb.AddParameter("@MR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Type", equ_MRecords.MR_Type);
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
      /// 添加设备检修记录 Equ_MRecords对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Equ_MRecords equ_MRecords)
      {
         string sql = "INSERT INTO Equ_MRecords (MR_ECode,MR_EName,MR_Start,MR_End,MR_FType,MR_Content,MR_MStuff,VerifyStuff,VerifyDate,MR_Bak,Creator,CreateTime,Stat,MR_MPCode,MR_Type) VALUES (@MR_ECode,@MR_EName,@MR_Start,@MR_End,@MR_FType,@MR_Content,@MR_MStuff,@VerifyStuff,@VerifyDate,@MR_Bak,@Creator,@CreateTime,@Stat,@MR_MPCode,@MR_Type);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(equ_MRecords.MR_ECode))
         {
            idb.AddParameter("@MR_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_ECode", equ_MRecords.MR_ECode);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_EName))
         {
            idb.AddParameter("@MR_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_EName", equ_MRecords.MR_EName);
         }
         if (equ_MRecords.MR_Start == DateTime.MinValue)
         {
            idb.AddParameter("@MR_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Start", equ_MRecords.MR_Start);
         }
         if (equ_MRecords.MR_End == DateTime.MinValue)
         {
            idb.AddParameter("@MR_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_End", equ_MRecords.MR_End);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_FType))
         {
            idb.AddParameter("@MR_FType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_FType", equ_MRecords.MR_FType);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_Content))
         {
            idb.AddParameter("@MR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Content", equ_MRecords.MR_Content);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_MStuff))
         {
            idb.AddParameter("@MR_MStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_MStuff", equ_MRecords.MR_MStuff);
         }
         if (string.IsNullOrEmpty(equ_MRecords.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", equ_MRecords.VerifyStuff);
         }
         if (equ_MRecords.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", equ_MRecords.VerifyDate);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_Bak))
         {
            idb.AddParameter("@MR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Bak", equ_MRecords.MR_Bak);
         }
         if (string.IsNullOrEmpty(equ_MRecords.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", equ_MRecords.Creator);
         }
         if (equ_MRecords.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", equ_MRecords.CreateTime);
         }
         if (equ_MRecords.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_MRecords.Stat);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_MPCode))
         {
            idb.AddParameter("@MR_MPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_MPCode", equ_MRecords.MR_MPCode);
         }
         if (string.IsNullOrEmpty(equ_MRecords.MR_Type))
         {
            idb.AddParameter("@MR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Type", equ_MRecords.MR_Type);
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
      /// 更新设备检修记录 Equ_MRecords对象(即:一条记录
      /// </summary>
      public int Update(Equ_MRecords equ_MRecords)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Equ_MRecords       SET ");
            if(equ_MRecords.MR_ECode_IsChanged){sbParameter.Append("MR_ECode=@MR_ECode, ");}
      if(equ_MRecords.MR_EName_IsChanged){sbParameter.Append("MR_EName=@MR_EName, ");}
      if(equ_MRecords.MR_Start_IsChanged){sbParameter.Append("MR_Start=@MR_Start, ");}
      if(equ_MRecords.MR_End_IsChanged){sbParameter.Append("MR_End=@MR_End, ");}
      if(equ_MRecords.MR_FType_IsChanged){sbParameter.Append("MR_FType=@MR_FType, ");}
      if(equ_MRecords.MR_Content_IsChanged){sbParameter.Append("MR_Content=@MR_Content, ");}
      if(equ_MRecords.MR_MStuff_IsChanged){sbParameter.Append("MR_MStuff=@MR_MStuff, ");}
      if(equ_MRecords.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(equ_MRecords.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(equ_MRecords.MR_Bak_IsChanged){sbParameter.Append("MR_Bak=@MR_Bak, ");}
      if(equ_MRecords.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(equ_MRecords.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(equ_MRecords.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(equ_MRecords.MR_MPCode_IsChanged){sbParameter.Append("MR_MPCode=@MR_MPCode, ");}
      if(equ_MRecords.MR_Type_IsChanged){sbParameter.Append("MR_Type=@MR_Type ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MR_ID=@MR_ID; " );
      string sql=sb.ToString();
         if(equ_MRecords.MR_ECode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_ECode))
         {
            idb.AddParameter("@MR_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_ECode", equ_MRecords.MR_ECode);
         }
          }
         if(equ_MRecords.MR_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_EName))
         {
            idb.AddParameter("@MR_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_EName", equ_MRecords.MR_EName);
         }
          }
         if(equ_MRecords.MR_Start_IsChanged)
         {
         if (equ_MRecords.MR_Start == DateTime.MinValue)
         {
            idb.AddParameter("@MR_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Start", equ_MRecords.MR_Start);
         }
          }
         if(equ_MRecords.MR_End_IsChanged)
         {
         if (equ_MRecords.MR_End == DateTime.MinValue)
         {
            idb.AddParameter("@MR_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_End", equ_MRecords.MR_End);
         }
          }
         if(equ_MRecords.MR_FType_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_FType))
         {
            idb.AddParameter("@MR_FType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_FType", equ_MRecords.MR_FType);
         }
          }
         if(equ_MRecords.MR_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_Content))
         {
            idb.AddParameter("@MR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Content", equ_MRecords.MR_Content);
         }
          }
         if(equ_MRecords.MR_MStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_MStuff))
         {
            idb.AddParameter("@MR_MStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_MStuff", equ_MRecords.MR_MStuff);
         }
          }
         if(equ_MRecords.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", equ_MRecords.VerifyStuff);
         }
          }
         if(equ_MRecords.VerifyDate_IsChanged)
         {
         if (equ_MRecords.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", equ_MRecords.VerifyDate);
         }
          }
         if(equ_MRecords.MR_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_Bak))
         {
            idb.AddParameter("@MR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Bak", equ_MRecords.MR_Bak);
         }
          }
         if(equ_MRecords.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", equ_MRecords.Creator);
         }
          }
         if(equ_MRecords.CreateTime_IsChanged)
         {
         if (equ_MRecords.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", equ_MRecords.CreateTime);
         }
          }
         if(equ_MRecords.Stat_IsChanged)
         {
         if (equ_MRecords.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_MRecords.Stat);
         }
          }
         if(equ_MRecords.MR_MPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_MPCode))
         {
            idb.AddParameter("@MR_MPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_MPCode", equ_MRecords.MR_MPCode);
         }
          }
         if(equ_MRecords.MR_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_MRecords.MR_Type))
         {
            idb.AddParameter("@MR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Type", equ_MRecords.MR_Type);
         }
          }

         idb.AddParameter("@MR_ID", equ_MRecords.MR_ID);

           
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
      /// 删除设备检修记录 Equ_MRecords对象(即:一条记录
      /// </summary>
      public int Delete(decimal mR_ID)
      {
         string sql = "DELETE Equ_MRecords WHERE 1=1  AND MR_ID=@MR_ID ";
         idb.AddParameter("@MR_ID", mR_ID);

           
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
      /// 获取指定的设备检修记录 Equ_MRecords对象(即:一条记录
      /// </summary>
      public Equ_MRecords GetByKey(decimal mR_ID)
      {
         Equ_MRecords equ_MRecords = new Equ_MRecords();
         string sql = "SELECT  MR_ID,MR_ECode,MR_EName,MR_Start,MR_End,MR_FType,MR_Content,MR_MStuff,VerifyStuff,VerifyDate,MR_Bak,Creator,CreateTime,Stat,MR_MPCode,MR_Type FROM Equ_MRecords WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MR_ID=@MR_ID ";
         idb.AddParameter("@MR_ID", mR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MR_ID"] != DBNull.Value) equ_MRecords.MR_ID = Convert.ToDecimal(dr["MR_ID"]);
            if (dr["MR_ECode"] != DBNull.Value) equ_MRecords.MR_ECode = Convert.ToString(dr["MR_ECode"]);
            if (dr["MR_EName"] != DBNull.Value) equ_MRecords.MR_EName = Convert.ToString(dr["MR_EName"]);
            if (dr["MR_Start"] != DBNull.Value) equ_MRecords.MR_Start = Convert.ToDateTime(dr["MR_Start"]);
            if (dr["MR_End"] != DBNull.Value) equ_MRecords.MR_End = Convert.ToDateTime(dr["MR_End"]);
            if (dr["MR_FType"] != DBNull.Value) equ_MRecords.MR_FType = Convert.ToString(dr["MR_FType"]);
            if (dr["MR_Content"] != DBNull.Value) equ_MRecords.MR_Content = Convert.ToString(dr["MR_Content"]);
            if (dr["MR_MStuff"] != DBNull.Value) equ_MRecords.MR_MStuff = Convert.ToString(dr["MR_MStuff"]);
            if (dr["VerifyStuff"] != DBNull.Value) equ_MRecords.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) equ_MRecords.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["MR_Bak"] != DBNull.Value) equ_MRecords.MR_Bak = Convert.ToString(dr["MR_Bak"]);
            if (dr["Creator"] != DBNull.Value) equ_MRecords.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) equ_MRecords.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["Stat"] != DBNull.Value) equ_MRecords.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MR_MPCode"] != DBNull.Value) equ_MRecords.MR_MPCode = Convert.ToString(dr["MR_MPCode"]);
            if (dr["MR_Type"] != DBNull.Value) equ_MRecords.MR_Type = Convert.ToString(dr["MR_Type"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return equ_MRecords;
      }
      /// <summary>
      /// 获取指定的设备检修记录 Equ_MRecords对象集合
      /// </summary>
      public List<Equ_MRecords> GetListByWhere(string strCondition)
      {
         List<Equ_MRecords> ret = new List<Equ_MRecords>();
         string sql = "SELECT  MR_ID,MR_ECode,MR_EName,MR_Start,MR_End,MR_FType,MR_Content,MR_MStuff,VerifyStuff,VerifyDate,MR_Bak,Creator,CreateTime,Stat,MR_MPCode,MR_Type FROM Equ_MRecords WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Equ_MRecords equ_MRecords = new Equ_MRecords();
            if (dr["MR_ID"] != DBNull.Value) equ_MRecords.MR_ID = Convert.ToDecimal(dr["MR_ID"]);
            if (dr["MR_ECode"] != DBNull.Value) equ_MRecords.MR_ECode = Convert.ToString(dr["MR_ECode"]);
            if (dr["MR_EName"] != DBNull.Value) equ_MRecords.MR_EName = Convert.ToString(dr["MR_EName"]);
            if (dr["MR_Start"] != DBNull.Value) equ_MRecords.MR_Start = Convert.ToDateTime(dr["MR_Start"]);
            if (dr["MR_End"] != DBNull.Value) equ_MRecords.MR_End = Convert.ToDateTime(dr["MR_End"]);
            if (dr["MR_FType"] != DBNull.Value) equ_MRecords.MR_FType = Convert.ToString(dr["MR_FType"]);
            if (dr["MR_Content"] != DBNull.Value) equ_MRecords.MR_Content = Convert.ToString(dr["MR_Content"]);
            if (dr["MR_MStuff"] != DBNull.Value) equ_MRecords.MR_MStuff = Convert.ToString(dr["MR_MStuff"]);
            if (dr["VerifyStuff"] != DBNull.Value) equ_MRecords.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) equ_MRecords.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["MR_Bak"] != DBNull.Value) equ_MRecords.MR_Bak = Convert.ToString(dr["MR_Bak"]);
            if (dr["Creator"] != DBNull.Value) equ_MRecords.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) equ_MRecords.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["Stat"] != DBNull.Value) equ_MRecords.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MR_MPCode"] != DBNull.Value) equ_MRecords.MR_MPCode = Convert.ToString(dr["MR_MPCode"]);
            if (dr["MR_Type"] != DBNull.Value) equ_MRecords.MR_Type = Convert.ToString(dr["MR_Type"]);
            ret.Add(equ_MRecords);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的设备检修记录 Equ_MRecords对象(即:一条记录
      /// </summary>
      public List<Equ_MRecords> GetAll()
      {
         List<Equ_MRecords> ret = new List<Equ_MRecords>();
         string sql = "SELECT  MR_ID,MR_ECode,MR_EName,MR_Start,MR_End,MR_FType,MR_Content,MR_MStuff,VerifyStuff,VerifyDate,MR_Bak,Creator,CreateTime,Stat,MR_MPCode,MR_Type FROM Equ_MRecords where 1=1 AND ((Stat is null) or (Stat=0) ) order by MR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Equ_MRecords equ_MRecords = new Equ_MRecords();
            if (dr["MR_ID"] != DBNull.Value) equ_MRecords.MR_ID = Convert.ToDecimal(dr["MR_ID"]);
            if (dr["MR_ECode"] != DBNull.Value) equ_MRecords.MR_ECode = Convert.ToString(dr["MR_ECode"]);
            if (dr["MR_EName"] != DBNull.Value) equ_MRecords.MR_EName = Convert.ToString(dr["MR_EName"]);
            if (dr["MR_Start"] != DBNull.Value) equ_MRecords.MR_Start = Convert.ToDateTime(dr["MR_Start"]);
            if (dr["MR_End"] != DBNull.Value) equ_MRecords.MR_End = Convert.ToDateTime(dr["MR_End"]);
            if (dr["MR_FType"] != DBNull.Value) equ_MRecords.MR_FType = Convert.ToString(dr["MR_FType"]);
            if (dr["MR_Content"] != DBNull.Value) equ_MRecords.MR_Content = Convert.ToString(dr["MR_Content"]);
            if (dr["MR_MStuff"] != DBNull.Value) equ_MRecords.MR_MStuff = Convert.ToString(dr["MR_MStuff"]);
            if (dr["VerifyStuff"] != DBNull.Value) equ_MRecords.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) equ_MRecords.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["MR_Bak"] != DBNull.Value) equ_MRecords.MR_Bak = Convert.ToString(dr["MR_Bak"]);
            if (dr["Creator"] != DBNull.Value) equ_MRecords.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) equ_MRecords.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["Stat"] != DBNull.Value) equ_MRecords.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MR_MPCode"] != DBNull.Value) equ_MRecords.MR_MPCode = Convert.ToString(dr["MR_MPCode"]);
            if (dr["MR_Type"] != DBNull.Value) equ_MRecords.MR_Type = Convert.ToString(dr["MR_Type"]);
            ret.Add(equ_MRecords);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
