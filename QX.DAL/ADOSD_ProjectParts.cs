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
   /// 工程部位
   /// </summary>
   [Serializable]
   public partial class ADOSD_ProjectParts
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加工程部位 SD_ProjectParts对象(即:一条记录)
      /// </summary>
      public int Add(SD_ProjectParts sD_ProjectParts)
      {
         string sql = "INSERT INTO SD_ProjectParts (SDPP_Code,SDPP_PCode,SDPP_Name,SDPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@SDPP_Code,@SDPP_PCode,@SDPP_Name,@SDPP_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Code))
         {
            idb.AddParameter("@SDPP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Code", sD_ProjectParts.SDPP_Code);
         }
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_PCode))
         {
            idb.AddParameter("@SDPP_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_PCode", sD_ProjectParts.SDPP_PCode);
         }
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Name))
         {
            idb.AddParameter("@SDPP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Name", sD_ProjectParts.SDPP_Name);
         }
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Bak))
         {
            idb.AddParameter("@SDPP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Bak", sD_ProjectParts.SDPP_Bak);
         }
         if (sD_ProjectParts.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ProjectParts.Stat);
         }
         if (sD_ProjectParts.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_ProjectParts.CreateDate);
         }
         if (sD_ProjectParts.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_ProjectParts.UpdateDate);
         }
         if (sD_ProjectParts.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_ProjectParts.DeleteDate);
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
      /// 添加工程部位 SD_ProjectParts对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_ProjectParts sD_ProjectParts)
      {
         string sql = "INSERT INTO SD_ProjectParts (SDPP_Code,SDPP_PCode,SDPP_Name,SDPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@SDPP_Code,@SDPP_PCode,@SDPP_Name,@SDPP_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Code))
         {
            idb.AddParameter("@SDPP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Code", sD_ProjectParts.SDPP_Code);
         }
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_PCode))
         {
            idb.AddParameter("@SDPP_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_PCode", sD_ProjectParts.SDPP_PCode);
         }
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Name))
         {
            idb.AddParameter("@SDPP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Name", sD_ProjectParts.SDPP_Name);
         }
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Bak))
         {
            idb.AddParameter("@SDPP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Bak", sD_ProjectParts.SDPP_Bak);
         }
         if (sD_ProjectParts.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ProjectParts.Stat);
         }
         if (sD_ProjectParts.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_ProjectParts.CreateDate);
         }
         if (sD_ProjectParts.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_ProjectParts.UpdateDate);
         }
         if (sD_ProjectParts.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_ProjectParts.DeleteDate);
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
      /// 更新工程部位 SD_ProjectParts对象(即:一条记录
      /// </summary>
      public int Update(SD_ProjectParts sD_ProjectParts)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_ProjectParts       SET ");
            if(sD_ProjectParts.SDPP_Code_IsChanged){sbParameter.Append("SDPP_Code=@SDPP_Code, ");}
      if(sD_ProjectParts.SDPP_PCode_IsChanged){sbParameter.Append("SDPP_PCode=@SDPP_PCode, ");}
      if(sD_ProjectParts.SDPP_Name_IsChanged){sbParameter.Append("SDPP_Name=@SDPP_Name, ");}
      if(sD_ProjectParts.SDPP_Bak_IsChanged){sbParameter.Append("SDPP_Bak=@SDPP_Bak, ");}
      if(sD_ProjectParts.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_ProjectParts.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_ProjectParts.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_ProjectParts.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDPP_ID=@SDPP_ID; " );
      string sql=sb.ToString();
         if(sD_ProjectParts.SDPP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Code))
         {
            idb.AddParameter("@SDPP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Code", sD_ProjectParts.SDPP_Code);
         }
          }
         if(sD_ProjectParts.SDPP_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_PCode))
         {
            idb.AddParameter("@SDPP_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_PCode", sD_ProjectParts.SDPP_PCode);
         }
          }
         if(sD_ProjectParts.SDPP_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Name))
         {
            idb.AddParameter("@SDPP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Name", sD_ProjectParts.SDPP_Name);
         }
          }
         if(sD_ProjectParts.SDPP_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ProjectParts.SDPP_Bak))
         {
            idb.AddParameter("@SDPP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPP_Bak", sD_ProjectParts.SDPP_Bak);
         }
          }
         if(sD_ProjectParts.Stat_IsChanged)
         {
         if (sD_ProjectParts.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ProjectParts.Stat);
         }
          }
         if(sD_ProjectParts.CreateDate_IsChanged)
         {
         if (sD_ProjectParts.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_ProjectParts.CreateDate);
         }
          }
         if(sD_ProjectParts.UpdateDate_IsChanged)
         {
         if (sD_ProjectParts.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_ProjectParts.UpdateDate);
         }
          }
         if(sD_ProjectParts.DeleteDate_IsChanged)
         {
         if (sD_ProjectParts.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_ProjectParts.DeleteDate);
         }
          }

         idb.AddParameter("@SDPP_ID", sD_ProjectParts.SDPP_ID);

           
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
      /// 删除工程部位 SD_ProjectParts对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDPP_ID)
      {
         string sql = "DELETE SD_ProjectParts WHERE 1=1  AND SDPP_ID=@SDPP_ID ";
         idb.AddParameter("@SDPP_ID", sDPP_ID);

           
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
      /// 获取指定的工程部位 SD_ProjectParts对象(即:一条记录
      /// </summary>
      public SD_ProjectParts GetByKey(decimal sDPP_ID)
      {
         SD_ProjectParts sD_ProjectParts = new SD_ProjectParts();
         string sql = "SELECT  SDPP_ID,SDPP_Code,SDPP_PCode,SDPP_Name,SDPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM SD_ProjectParts WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDPP_ID=@SDPP_ID ";
         idb.AddParameter("@SDPP_ID", sDPP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDPP_ID"] != DBNull.Value) sD_ProjectParts.SDPP_ID = Convert.ToDecimal(dr["SDPP_ID"]);
            if (dr["SDPP_Code"] != DBNull.Value) sD_ProjectParts.SDPP_Code = Convert.ToString(dr["SDPP_Code"]);
            if (dr["SDPP_PCode"] != DBNull.Value) sD_ProjectParts.SDPP_PCode = Convert.ToString(dr["SDPP_PCode"]);
            if (dr["SDPP_Name"] != DBNull.Value) sD_ProjectParts.SDPP_Name = Convert.ToString(dr["SDPP_Name"]);
            if (dr["SDPP_Bak"] != DBNull.Value) sD_ProjectParts.SDPP_Bak = Convert.ToString(dr["SDPP_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_ProjectParts.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_ProjectParts.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_ProjectParts.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_ProjectParts.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_ProjectParts;
      }
      /// <summary>
      /// 获取指定的工程部位 SD_ProjectParts对象集合
      /// </summary>
      public List<SD_ProjectParts> GetListByWhere(string strCondition)
      {
         List<SD_ProjectParts> ret = new List<SD_ProjectParts>();
         string sql = "SELECT  SDPP_ID,SDPP_Code,SDPP_PCode,SDPP_Name,SDPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM SD_ProjectParts WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_ProjectParts sD_ProjectParts = new SD_ProjectParts();
            if (dr["SDPP_ID"] != DBNull.Value) sD_ProjectParts.SDPP_ID = Convert.ToDecimal(dr["SDPP_ID"]);
            if (dr["SDPP_Code"] != DBNull.Value) sD_ProjectParts.SDPP_Code = Convert.ToString(dr["SDPP_Code"]);
            if (dr["SDPP_PCode"] != DBNull.Value) sD_ProjectParts.SDPP_PCode = Convert.ToString(dr["SDPP_PCode"]);
            if (dr["SDPP_Name"] != DBNull.Value) sD_ProjectParts.SDPP_Name = Convert.ToString(dr["SDPP_Name"]);
            if (dr["SDPP_Bak"] != DBNull.Value) sD_ProjectParts.SDPP_Bak = Convert.ToString(dr["SDPP_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_ProjectParts.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_ProjectParts.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_ProjectParts.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_ProjectParts.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sD_ProjectParts);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的工程部位 SD_ProjectParts对象(即:一条记录
      /// </summary>
      public List<SD_ProjectParts> GetAll()
      {
         List<SD_ProjectParts> ret = new List<SD_ProjectParts>();
         string sql = "SELECT  SDPP_ID,SDPP_Code,SDPP_PCode,SDPP_Name,SDPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM SD_ProjectParts where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDPP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_ProjectParts sD_ProjectParts = new SD_ProjectParts();
            if (dr["SDPP_ID"] != DBNull.Value) sD_ProjectParts.SDPP_ID = Convert.ToDecimal(dr["SDPP_ID"]);
            if (dr["SDPP_Code"] != DBNull.Value) sD_ProjectParts.SDPP_Code = Convert.ToString(dr["SDPP_Code"]);
            if (dr["SDPP_PCode"] != DBNull.Value) sD_ProjectParts.SDPP_PCode = Convert.ToString(dr["SDPP_PCode"]);
            if (dr["SDPP_Name"] != DBNull.Value) sD_ProjectParts.SDPP_Name = Convert.ToString(dr["SDPP_Name"]);
            if (dr["SDPP_Bak"] != DBNull.Value) sD_ProjectParts.SDPP_Bak = Convert.ToString(dr["SDPP_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_ProjectParts.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_ProjectParts.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_ProjectParts.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_ProjectParts.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sD_ProjectParts);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
