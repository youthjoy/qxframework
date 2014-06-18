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
   /// 生产配合比信息
   /// </summary>
   [Serializable]
   public partial class ADOTC_PIComp
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产配合比信息 TC_PIComp对象(即:一条记录)
      /// </summary>
      public int Add(TC_PIComp tC_PIComp)
      {
         string sql = "INSERT INTO TC_PIComp (TCPI_Code,TCPI_PCode,TCPI_WCode,TCPI_WNo,TCPI_MCode,TCPI_MName,TCPI_STNum,TCPI_PCNum,TCPI_WatNum,TCPI_OneNum,TCPI_CCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCPI_Code,@TCPI_PCode,@TCPI_WCode,@TCPI_WNo,@TCPI_MCode,@TCPI_MName,@TCPI_STNum,@TCPI_PCNum,@TCPI_WatNum,@TCPI_OneNum,@TCPI_CCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_Code))
         {
            idb.AddParameter("@TCPI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_Code", tC_PIComp.TCPI_Code);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_PCode))
         {
            idb.AddParameter("@TCPI_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_PCode", tC_PIComp.TCPI_PCode);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_WCode))
         {
            idb.AddParameter("@TCPI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_WCode", tC_PIComp.TCPI_WCode);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_WNo))
         {
            idb.AddParameter("@TCPI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_WNo", tC_PIComp.TCPI_WNo);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_MCode))
         {
            idb.AddParameter("@TCPI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_MCode", tC_PIComp.TCPI_MCode);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_MName))
         {
            idb.AddParameter("@TCPI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_MName", tC_PIComp.TCPI_MName);
         }
         if (tC_PIComp.TCPI_STNum == 0)
         {
            idb.AddParameter("@TCPI_STNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_STNum", tC_PIComp.TCPI_STNum);
         }
         if (tC_PIComp.TCPI_PCNum == 0)
         {
            idb.AddParameter("@TCPI_PCNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_PCNum", tC_PIComp.TCPI_PCNum);
         }
         if (tC_PIComp.TCPI_WatNum == 0)
         {
            idb.AddParameter("@TCPI_WatNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_WatNum", tC_PIComp.TCPI_WatNum);
         }
         if (tC_PIComp.TCPI_OneNum == 0)
         {
            idb.AddParameter("@TCPI_OneNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_OneNum", tC_PIComp.TCPI_OneNum);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_CCode))
         {
            idb.AddParameter("@TCPI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_CCode", tC_PIComp.TCPI_CCode);
         }
         if (tC_PIComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_PIComp.Stat);
         }
         if (tC_PIComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_PIComp.CreateDate);
         }
         if (tC_PIComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_PIComp.UpdateDate);
         }
         if (tC_PIComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_PIComp.DeleteDate);
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
      /// 添加生产配合比信息 TC_PIComp对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_PIComp tC_PIComp)
      {
         string sql = "INSERT INTO TC_PIComp (TCPI_Code,TCPI_PCode,TCPI_WCode,TCPI_WNo,TCPI_MCode,TCPI_MName,TCPI_STNum,TCPI_PCNum,TCPI_WatNum,TCPI_OneNum,TCPI_CCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCPI_Code,@TCPI_PCode,@TCPI_WCode,@TCPI_WNo,@TCPI_MCode,@TCPI_MName,@TCPI_STNum,@TCPI_PCNum,@TCPI_WatNum,@TCPI_OneNum,@TCPI_CCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_Code))
         {
            idb.AddParameter("@TCPI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_Code", tC_PIComp.TCPI_Code);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_PCode))
         {
            idb.AddParameter("@TCPI_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_PCode", tC_PIComp.TCPI_PCode);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_WCode))
         {
            idb.AddParameter("@TCPI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_WCode", tC_PIComp.TCPI_WCode);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_WNo))
         {
            idb.AddParameter("@TCPI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_WNo", tC_PIComp.TCPI_WNo);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_MCode))
         {
            idb.AddParameter("@TCPI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_MCode", tC_PIComp.TCPI_MCode);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_MName))
         {
            idb.AddParameter("@TCPI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_MName", tC_PIComp.TCPI_MName);
         }
         if (tC_PIComp.TCPI_STNum == 0)
         {
            idb.AddParameter("@TCPI_STNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_STNum", tC_PIComp.TCPI_STNum);
         }
         if (tC_PIComp.TCPI_PCNum == 0)
         {
            idb.AddParameter("@TCPI_PCNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_PCNum", tC_PIComp.TCPI_PCNum);
         }
         if (tC_PIComp.TCPI_WatNum == 0)
         {
            idb.AddParameter("@TCPI_WatNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_WatNum", tC_PIComp.TCPI_WatNum);
         }
         if (tC_PIComp.TCPI_OneNum == 0)
         {
            idb.AddParameter("@TCPI_OneNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_OneNum", tC_PIComp.TCPI_OneNum);
         }
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_CCode))
         {
            idb.AddParameter("@TCPI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_CCode", tC_PIComp.TCPI_CCode);
         }
         if (tC_PIComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_PIComp.Stat);
         }
         if (tC_PIComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_PIComp.CreateDate);
         }
         if (tC_PIComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_PIComp.UpdateDate);
         }
         if (tC_PIComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_PIComp.DeleteDate);
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
      /// 更新生产配合比信息 TC_PIComp对象(即:一条记录
      /// </summary>
      public int Update(TC_PIComp tC_PIComp)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_PIComp       SET ");
            if(tC_PIComp.TCPI_Code_IsChanged){sbParameter.Append("TCPI_Code=@TCPI_Code, ");}
      if(tC_PIComp.TCPI_PCode_IsChanged){sbParameter.Append("TCPI_PCode=@TCPI_PCode, ");}
      if(tC_PIComp.TCPI_WCode_IsChanged){sbParameter.Append("TCPI_WCode=@TCPI_WCode, ");}
      if(tC_PIComp.TCPI_WNo_IsChanged){sbParameter.Append("TCPI_WNo=@TCPI_WNo, ");}
      if(tC_PIComp.TCPI_MCode_IsChanged){sbParameter.Append("TCPI_MCode=@TCPI_MCode, ");}
      if(tC_PIComp.TCPI_MName_IsChanged){sbParameter.Append("TCPI_MName=@TCPI_MName, ");}
      if(tC_PIComp.TCPI_STNum_IsChanged){sbParameter.Append("TCPI_STNum=@TCPI_STNum, ");}
      if(tC_PIComp.TCPI_PCNum_IsChanged){sbParameter.Append("TCPI_PCNum=@TCPI_PCNum, ");}
      if(tC_PIComp.TCPI_WatNum_IsChanged){sbParameter.Append("TCPI_WatNum=@TCPI_WatNum, ");}
      if(tC_PIComp.TCPI_OneNum_IsChanged){sbParameter.Append("TCPI_OneNum=@TCPI_OneNum, ");}
      if(tC_PIComp.TCPI_CCode_IsChanged){sbParameter.Append("TCPI_CCode=@TCPI_CCode, ");}
      if(tC_PIComp.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_PIComp.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_PIComp.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_PIComp.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCPI_ID=@TCPI_ID; " );
      string sql=sb.ToString();
         if(tC_PIComp.TCPI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_Code))
         {
            idb.AddParameter("@TCPI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_Code", tC_PIComp.TCPI_Code);
         }
          }
         if(tC_PIComp.TCPI_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_PCode))
         {
            idb.AddParameter("@TCPI_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_PCode", tC_PIComp.TCPI_PCode);
         }
          }
         if(tC_PIComp.TCPI_WCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_WCode))
         {
            idb.AddParameter("@TCPI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_WCode", tC_PIComp.TCPI_WCode);
         }
          }
         if(tC_PIComp.TCPI_WNo_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_WNo))
         {
            idb.AddParameter("@TCPI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_WNo", tC_PIComp.TCPI_WNo);
         }
          }
         if(tC_PIComp.TCPI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_MCode))
         {
            idb.AddParameter("@TCPI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_MCode", tC_PIComp.TCPI_MCode);
         }
          }
         if(tC_PIComp.TCPI_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_MName))
         {
            idb.AddParameter("@TCPI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_MName", tC_PIComp.TCPI_MName);
         }
          }
         if(tC_PIComp.TCPI_STNum_IsChanged)
         {
         if (tC_PIComp.TCPI_STNum == 0)
         {
            idb.AddParameter("@TCPI_STNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_STNum", tC_PIComp.TCPI_STNum);
         }
          }
         if(tC_PIComp.TCPI_PCNum_IsChanged)
         {
         if (tC_PIComp.TCPI_PCNum == 0)
         {
            idb.AddParameter("@TCPI_PCNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_PCNum", tC_PIComp.TCPI_PCNum);
         }
          }
         if(tC_PIComp.TCPI_WatNum_IsChanged)
         {
         if (tC_PIComp.TCPI_WatNum == 0)
         {
            idb.AddParameter("@TCPI_WatNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_WatNum", tC_PIComp.TCPI_WatNum);
         }
          }
         if(tC_PIComp.TCPI_OneNum_IsChanged)
         {
         if (tC_PIComp.TCPI_OneNum == 0)
         {
            idb.AddParameter("@TCPI_OneNum", 0);
         }
         else
         {
            idb.AddParameter("@TCPI_OneNum", tC_PIComp.TCPI_OneNum);
         }
          }
         if(tC_PIComp.TCPI_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PIComp.TCPI_CCode))
         {
            idb.AddParameter("@TCPI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPI_CCode", tC_PIComp.TCPI_CCode);
         }
          }
         if(tC_PIComp.Stat_IsChanged)
         {
         if (tC_PIComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_PIComp.Stat);
         }
          }
         if(tC_PIComp.CreateDate_IsChanged)
         {
         if (tC_PIComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_PIComp.CreateDate);
         }
          }
         if(tC_PIComp.UpdateDate_IsChanged)
         {
         if (tC_PIComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_PIComp.UpdateDate);
         }
          }
         if(tC_PIComp.DeleteDate_IsChanged)
         {
         if (tC_PIComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_PIComp.DeleteDate);
         }
          }

         idb.AddParameter("@TCPI_ID", tC_PIComp.TCPI_ID);

           
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
      /// 删除生产配合比信息 TC_PIComp对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCPI_ID)
      {
         string sql = "DELETE TC_PIComp WHERE 1=1  AND TCPI_ID=@TCPI_ID ";
         idb.AddParameter("@TCPI_ID", tCPI_ID);

           
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
      /// 获取指定的生产配合比信息 TC_PIComp对象(即:一条记录
      /// </summary>
      public TC_PIComp GetByKey(decimal tCPI_ID)
      {
         TC_PIComp tC_PIComp = new TC_PIComp();
         string sql = "SELECT  TCPI_ID,TCPI_Code,TCPI_PCode,TCPI_WCode,TCPI_WNo,TCPI_MCode,TCPI_MName,TCPI_STNum,TCPI_PCNum,TCPI_WatNum,TCPI_OneNum,TCPI_CCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_PIComp WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCPI_ID=@TCPI_ID ";
         idb.AddParameter("@TCPI_ID", tCPI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCPI_ID"] != DBNull.Value) tC_PIComp.TCPI_ID = Convert.ToDecimal(dr["TCPI_ID"]);
            if (dr["TCPI_Code"] != DBNull.Value) tC_PIComp.TCPI_Code = Convert.ToString(dr["TCPI_Code"]);
            if (dr["TCPI_PCode"] != DBNull.Value) tC_PIComp.TCPI_PCode = Convert.ToString(dr["TCPI_PCode"]);
            if (dr["TCPI_WCode"] != DBNull.Value) tC_PIComp.TCPI_WCode = Convert.ToString(dr["TCPI_WCode"]);
            if (dr["TCPI_WNo"] != DBNull.Value) tC_PIComp.TCPI_WNo = Convert.ToString(dr["TCPI_WNo"]);
            if (dr["TCPI_MCode"] != DBNull.Value) tC_PIComp.TCPI_MCode = Convert.ToString(dr["TCPI_MCode"]);
            if (dr["TCPI_MName"] != DBNull.Value) tC_PIComp.TCPI_MName = Convert.ToString(dr["TCPI_MName"]);
            if (dr["TCPI_STNum"] != DBNull.Value) tC_PIComp.TCPI_STNum = Convert.ToDecimal(dr["TCPI_STNum"]);
            if (dr["TCPI_PCNum"] != DBNull.Value) tC_PIComp.TCPI_PCNum = Convert.ToDecimal(dr["TCPI_PCNum"]);
            if (dr["TCPI_WatNum"] != DBNull.Value) tC_PIComp.TCPI_WatNum = Convert.ToDecimal(dr["TCPI_WatNum"]);
            if (dr["TCPI_OneNum"] != DBNull.Value) tC_PIComp.TCPI_OneNum = Convert.ToDecimal(dr["TCPI_OneNum"]);
            if (dr["TCPI_CCode"] != DBNull.Value) tC_PIComp.TCPI_CCode = Convert.ToString(dr["TCPI_CCode"]);
            if (dr["Stat"] != DBNull.Value) tC_PIComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_PIComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_PIComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_PIComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_PIComp;
      }
      /// <summary>
      /// 获取指定的生产配合比信息 TC_PIComp对象集合
      /// </summary>
      public List<TC_PIComp> GetListByWhere(string strCondition)
      {
         List<TC_PIComp> ret = new List<TC_PIComp>();
         string sql = "SELECT  TCPI_ID,TCPI_Code,TCPI_PCode,TCPI_WCode,TCPI_WNo,TCPI_MCode,TCPI_MName,TCPI_STNum,TCPI_PCNum,TCPI_WatNum,TCPI_OneNum,TCPI_CCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_PIComp WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_PIComp tC_PIComp = new TC_PIComp();
            if (dr["TCPI_ID"] != DBNull.Value) tC_PIComp.TCPI_ID = Convert.ToDecimal(dr["TCPI_ID"]);
            if (dr["TCPI_Code"] != DBNull.Value) tC_PIComp.TCPI_Code = Convert.ToString(dr["TCPI_Code"]);
            if (dr["TCPI_PCode"] != DBNull.Value) tC_PIComp.TCPI_PCode = Convert.ToString(dr["TCPI_PCode"]);
            if (dr["TCPI_WCode"] != DBNull.Value) tC_PIComp.TCPI_WCode = Convert.ToString(dr["TCPI_WCode"]);
            if (dr["TCPI_WNo"] != DBNull.Value) tC_PIComp.TCPI_WNo = Convert.ToString(dr["TCPI_WNo"]);
            if (dr["TCPI_MCode"] != DBNull.Value) tC_PIComp.TCPI_MCode = Convert.ToString(dr["TCPI_MCode"]);
            if (dr["TCPI_MName"] != DBNull.Value) tC_PIComp.TCPI_MName = Convert.ToString(dr["TCPI_MName"]);
            if (dr["TCPI_STNum"] != DBNull.Value) tC_PIComp.TCPI_STNum = Convert.ToDecimal(dr["TCPI_STNum"]);
            if (dr["TCPI_PCNum"] != DBNull.Value) tC_PIComp.TCPI_PCNum = Convert.ToDecimal(dr["TCPI_PCNum"]);
            if (dr["TCPI_WatNum"] != DBNull.Value) tC_PIComp.TCPI_WatNum = Convert.ToDecimal(dr["TCPI_WatNum"]);
            if (dr["TCPI_OneNum"] != DBNull.Value) tC_PIComp.TCPI_OneNum = Convert.ToDecimal(dr["TCPI_OneNum"]);
            if (dr["TCPI_CCode"] != DBNull.Value) tC_PIComp.TCPI_CCode = Convert.ToString(dr["TCPI_CCode"]);
            if (dr["Stat"] != DBNull.Value) tC_PIComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_PIComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_PIComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_PIComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_PIComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产配合比信息 TC_PIComp对象(即:一条记录
      /// </summary>
      public List<TC_PIComp> GetAll()
      {
         List<TC_PIComp> ret = new List<TC_PIComp>();
         string sql = "SELECT  TCPI_ID,TCPI_Code,TCPI_PCode,TCPI_WCode,TCPI_WNo,TCPI_MCode,TCPI_MName,TCPI_STNum,TCPI_PCNum,TCPI_WatNum,TCPI_OneNum,TCPI_CCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_PIComp where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCPI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_PIComp tC_PIComp = new TC_PIComp();
            if (dr["TCPI_ID"] != DBNull.Value) tC_PIComp.TCPI_ID = Convert.ToDecimal(dr["TCPI_ID"]);
            if (dr["TCPI_Code"] != DBNull.Value) tC_PIComp.TCPI_Code = Convert.ToString(dr["TCPI_Code"]);
            if (dr["TCPI_PCode"] != DBNull.Value) tC_PIComp.TCPI_PCode = Convert.ToString(dr["TCPI_PCode"]);
            if (dr["TCPI_WCode"] != DBNull.Value) tC_PIComp.TCPI_WCode = Convert.ToString(dr["TCPI_WCode"]);
            if (dr["TCPI_WNo"] != DBNull.Value) tC_PIComp.TCPI_WNo = Convert.ToString(dr["TCPI_WNo"]);
            if (dr["TCPI_MCode"] != DBNull.Value) tC_PIComp.TCPI_MCode = Convert.ToString(dr["TCPI_MCode"]);
            if (dr["TCPI_MName"] != DBNull.Value) tC_PIComp.TCPI_MName = Convert.ToString(dr["TCPI_MName"]);
            if (dr["TCPI_STNum"] != DBNull.Value) tC_PIComp.TCPI_STNum = Convert.ToDecimal(dr["TCPI_STNum"]);
            if (dr["TCPI_PCNum"] != DBNull.Value) tC_PIComp.TCPI_PCNum = Convert.ToDecimal(dr["TCPI_PCNum"]);
            if (dr["TCPI_WatNum"] != DBNull.Value) tC_PIComp.TCPI_WatNum = Convert.ToDecimal(dr["TCPI_WatNum"]);
            if (dr["TCPI_OneNum"] != DBNull.Value) tC_PIComp.TCPI_OneNum = Convert.ToDecimal(dr["TCPI_OneNum"]);
            if (dr["TCPI_CCode"] != DBNull.Value) tC_PIComp.TCPI_CCode = Convert.ToString(dr["TCPI_CCode"]);
            if (dr["Stat"] != DBNull.Value) tC_PIComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_PIComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_PIComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_PIComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_PIComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
