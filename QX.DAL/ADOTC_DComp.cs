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
   /// 生产配比下达信息
   /// </summary>
   [Serializable]
   public partial class ADOTC_DComp
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产配比下达信息 TC_DComp对象(即:一条记录)
      /// </summary>
      public int Add(TC_DComp tC_DComp)
      {
         string sql = "INSERT INTO TC_DComp (TCD_Code,TCD_PCode,TCD_PLine,TCD_PPlan,TCD_Remark,TCD_UDef1,TCD_UDef2,TCD_UDef3,TCD_UDef4,TCD_UDef5,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCD_Code,@TCD_PCode,@TCD_PLine,@TCD_PPlan,@TCD_Remark,@TCD_UDef1,@TCD_UDef2,@TCD_UDef3,@TCD_UDef4,@TCD_UDef5,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_DComp.TCD_Code))
         {
            idb.AddParameter("@TCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_Code", tC_DComp.TCD_Code);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_PCode))
         {
            idb.AddParameter("@TCD_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PCode", tC_DComp.TCD_PCode);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_PLine))
         {
            idb.AddParameter("@TCD_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PLine", tC_DComp.TCD_PLine);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_PPlan))
         {
            idb.AddParameter("@TCD_PPlan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PPlan", tC_DComp.TCD_PPlan);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_Remark))
         {
            idb.AddParameter("@TCD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_Remark", tC_DComp.TCD_Remark);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef1))
         {
            idb.AddParameter("@TCD_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef1", tC_DComp.TCD_UDef1);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef2))
         {
            idb.AddParameter("@TCD_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef2", tC_DComp.TCD_UDef2);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef3))
         {
            idb.AddParameter("@TCD_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef3", tC_DComp.TCD_UDef3);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef4))
         {
            idb.AddParameter("@TCD_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef4", tC_DComp.TCD_UDef4);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef5))
         {
            idb.AddParameter("@TCD_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef5", tC_DComp.TCD_UDef5);
         }
         if (tC_DComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_DComp.Stat);
         }
         if (tC_DComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_DComp.CreateDate);
         }
         if (tC_DComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_DComp.UpdateDate);
         }
         if (tC_DComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_DComp.DeleteDate);
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
      /// 添加生产配比下达信息 TC_DComp对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_DComp tC_DComp)
      {
         string sql = "INSERT INTO TC_DComp (TCD_Code,TCD_PCode,TCD_PLine,TCD_PPlan,TCD_Remark,TCD_UDef1,TCD_UDef2,TCD_UDef3,TCD_UDef4,TCD_UDef5,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCD_Code,@TCD_PCode,@TCD_PLine,@TCD_PPlan,@TCD_Remark,@TCD_UDef1,@TCD_UDef2,@TCD_UDef3,@TCD_UDef4,@TCD_UDef5,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_DComp.TCD_Code))
         {
            idb.AddParameter("@TCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_Code", tC_DComp.TCD_Code);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_PCode))
         {
            idb.AddParameter("@TCD_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PCode", tC_DComp.TCD_PCode);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_PLine))
         {
            idb.AddParameter("@TCD_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PLine", tC_DComp.TCD_PLine);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_PPlan))
         {
            idb.AddParameter("@TCD_PPlan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PPlan", tC_DComp.TCD_PPlan);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_Remark))
         {
            idb.AddParameter("@TCD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_Remark", tC_DComp.TCD_Remark);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef1))
         {
            idb.AddParameter("@TCD_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef1", tC_DComp.TCD_UDef1);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef2))
         {
            idb.AddParameter("@TCD_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef2", tC_DComp.TCD_UDef2);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef3))
         {
            idb.AddParameter("@TCD_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef3", tC_DComp.TCD_UDef3);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef4))
         {
            idb.AddParameter("@TCD_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef4", tC_DComp.TCD_UDef4);
         }
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef5))
         {
            idb.AddParameter("@TCD_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef5", tC_DComp.TCD_UDef5);
         }
         if (tC_DComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_DComp.Stat);
         }
         if (tC_DComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_DComp.CreateDate);
         }
         if (tC_DComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_DComp.UpdateDate);
         }
         if (tC_DComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_DComp.DeleteDate);
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
      /// 更新生产配比下达信息 TC_DComp对象(即:一条记录
      /// </summary>
      public int Update(TC_DComp tC_DComp)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_DComp       SET ");
            if(tC_DComp.TCD_Code_IsChanged){sbParameter.Append("TCD_Code=@TCD_Code, ");}
      if(tC_DComp.TCD_PCode_IsChanged){sbParameter.Append("TCD_PCode=@TCD_PCode, ");}
      if(tC_DComp.TCD_PLine_IsChanged){sbParameter.Append("TCD_PLine=@TCD_PLine, ");}
      if(tC_DComp.TCD_PPlan_IsChanged){sbParameter.Append("TCD_PPlan=@TCD_PPlan, ");}
      if(tC_DComp.TCD_Remark_IsChanged){sbParameter.Append("TCD_Remark=@TCD_Remark, ");}
      if(tC_DComp.TCD_UDef1_IsChanged){sbParameter.Append("TCD_UDef1=@TCD_UDef1, ");}
      if(tC_DComp.TCD_UDef2_IsChanged){sbParameter.Append("TCD_UDef2=@TCD_UDef2, ");}
      if(tC_DComp.TCD_UDef3_IsChanged){sbParameter.Append("TCD_UDef3=@TCD_UDef3, ");}
      if(tC_DComp.TCD_UDef4_IsChanged){sbParameter.Append("TCD_UDef4=@TCD_UDef4, ");}
      if(tC_DComp.TCD_UDef5_IsChanged){sbParameter.Append("TCD_UDef5=@TCD_UDef5, ");}
      if(tC_DComp.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_DComp.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_DComp.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_DComp.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCD_ID=@TCD_ID; " );
      string sql=sb.ToString();
         if(tC_DComp.TCD_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_Code))
         {
            idb.AddParameter("@TCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_Code", tC_DComp.TCD_Code);
         }
          }
         if(tC_DComp.TCD_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_PCode))
         {
            idb.AddParameter("@TCD_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PCode", tC_DComp.TCD_PCode);
         }
          }
         if(tC_DComp.TCD_PLine_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_PLine))
         {
            idb.AddParameter("@TCD_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PLine", tC_DComp.TCD_PLine);
         }
          }
         if(tC_DComp.TCD_PPlan_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_PPlan))
         {
            idb.AddParameter("@TCD_PPlan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_PPlan", tC_DComp.TCD_PPlan);
         }
          }
         if(tC_DComp.TCD_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_Remark))
         {
            idb.AddParameter("@TCD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_Remark", tC_DComp.TCD_Remark);
         }
          }
         if(tC_DComp.TCD_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef1))
         {
            idb.AddParameter("@TCD_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef1", tC_DComp.TCD_UDef1);
         }
          }
         if(tC_DComp.TCD_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef2))
         {
            idb.AddParameter("@TCD_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef2", tC_DComp.TCD_UDef2);
         }
          }
         if(tC_DComp.TCD_UDef3_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef3))
         {
            idb.AddParameter("@TCD_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef3", tC_DComp.TCD_UDef3);
         }
          }
         if(tC_DComp.TCD_UDef4_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef4))
         {
            idb.AddParameter("@TCD_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef4", tC_DComp.TCD_UDef4);
         }
          }
         if(tC_DComp.TCD_UDef5_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_DComp.TCD_UDef5))
         {
            idb.AddParameter("@TCD_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCD_UDef5", tC_DComp.TCD_UDef5);
         }
          }
         if(tC_DComp.Stat_IsChanged)
         {
         if (tC_DComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_DComp.Stat);
         }
          }
         if(tC_DComp.CreateDate_IsChanged)
         {
         if (tC_DComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_DComp.CreateDate);
         }
          }
         if(tC_DComp.UpdateDate_IsChanged)
         {
         if (tC_DComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_DComp.UpdateDate);
         }
          }
         if(tC_DComp.DeleteDate_IsChanged)
         {
         if (tC_DComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_DComp.DeleteDate);
         }
          }

         idb.AddParameter("@TCD_ID", tC_DComp.TCD_ID);

           
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
      /// 删除生产配比下达信息 TC_DComp对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCD_ID)
      {
         string sql = "DELETE TC_DComp WHERE 1=1  AND TCD_ID=@TCD_ID ";
         idb.AddParameter("@TCD_ID", tCD_ID);

           
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
      /// 获取指定的生产配比下达信息 TC_DComp对象(即:一条记录
      /// </summary>
      public TC_DComp GetByKey(decimal tCD_ID)
      {
         TC_DComp tC_DComp = new TC_DComp();
         string sql = "SELECT  TCD_ID,TCD_Code,TCD_PCode,TCD_PLine,TCD_PPlan,TCD_Remark,TCD_UDef1,TCD_UDef2,TCD_UDef3,TCD_UDef4,TCD_UDef5,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_DComp WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCD_ID=@TCD_ID ";
         idb.AddParameter("@TCD_ID", tCD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCD_ID"] != DBNull.Value) tC_DComp.TCD_ID = Convert.ToDecimal(dr["TCD_ID"]);
            if (dr["TCD_Code"] != DBNull.Value) tC_DComp.TCD_Code = Convert.ToString(dr["TCD_Code"]);
            if (dr["TCD_PCode"] != DBNull.Value) tC_DComp.TCD_PCode = Convert.ToString(dr["TCD_PCode"]);
            if (dr["TCD_PLine"] != DBNull.Value) tC_DComp.TCD_PLine = Convert.ToString(dr["TCD_PLine"]);
            if (dr["TCD_PPlan"] != DBNull.Value) tC_DComp.TCD_PPlan = Convert.ToString(dr["TCD_PPlan"]);
            if (dr["TCD_Remark"] != DBNull.Value) tC_DComp.TCD_Remark = Convert.ToString(dr["TCD_Remark"]);
            if (dr["TCD_UDef1"] != DBNull.Value) tC_DComp.TCD_UDef1 = Convert.ToString(dr["TCD_UDef1"]);
            if (dr["TCD_UDef2"] != DBNull.Value) tC_DComp.TCD_UDef2 = Convert.ToString(dr["TCD_UDef2"]);
            if (dr["TCD_UDef3"] != DBNull.Value) tC_DComp.TCD_UDef3 = Convert.ToString(dr["TCD_UDef3"]);
            if (dr["TCD_UDef4"] != DBNull.Value) tC_DComp.TCD_UDef4 = Convert.ToString(dr["TCD_UDef4"]);
            if (dr["TCD_UDef5"] != DBNull.Value) tC_DComp.TCD_UDef5 = Convert.ToString(dr["TCD_UDef5"]);
            if (dr["Stat"] != DBNull.Value) tC_DComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_DComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_DComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_DComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_DComp;
      }
      /// <summary>
      /// 获取指定的生产配比下达信息 TC_DComp对象集合
      /// </summary>
      public List<TC_DComp> GetListByWhere(string strCondition)
      {
         List<TC_DComp> ret = new List<TC_DComp>();
         string sql = "SELECT  TCD_ID,TCD_Code,TCD_PCode,TCD_PLine,TCD_PPlan,TCD_Remark,TCD_UDef1,TCD_UDef2,TCD_UDef3,TCD_UDef4,TCD_UDef5,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_DComp WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_DComp tC_DComp = new TC_DComp();
            if (dr["TCD_ID"] != DBNull.Value) tC_DComp.TCD_ID = Convert.ToDecimal(dr["TCD_ID"]);
            if (dr["TCD_Code"] != DBNull.Value) tC_DComp.TCD_Code = Convert.ToString(dr["TCD_Code"]);
            if (dr["TCD_PCode"] != DBNull.Value) tC_DComp.TCD_PCode = Convert.ToString(dr["TCD_PCode"]);
            if (dr["TCD_PLine"] != DBNull.Value) tC_DComp.TCD_PLine = Convert.ToString(dr["TCD_PLine"]);
            if (dr["TCD_PPlan"] != DBNull.Value) tC_DComp.TCD_PPlan = Convert.ToString(dr["TCD_PPlan"]);
            if (dr["TCD_Remark"] != DBNull.Value) tC_DComp.TCD_Remark = Convert.ToString(dr["TCD_Remark"]);
            if (dr["TCD_UDef1"] != DBNull.Value) tC_DComp.TCD_UDef1 = Convert.ToString(dr["TCD_UDef1"]);
            if (dr["TCD_UDef2"] != DBNull.Value) tC_DComp.TCD_UDef2 = Convert.ToString(dr["TCD_UDef2"]);
            if (dr["TCD_UDef3"] != DBNull.Value) tC_DComp.TCD_UDef3 = Convert.ToString(dr["TCD_UDef3"]);
            if (dr["TCD_UDef4"] != DBNull.Value) tC_DComp.TCD_UDef4 = Convert.ToString(dr["TCD_UDef4"]);
            if (dr["TCD_UDef5"] != DBNull.Value) tC_DComp.TCD_UDef5 = Convert.ToString(dr["TCD_UDef5"]);
            if (dr["Stat"] != DBNull.Value) tC_DComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_DComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_DComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_DComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_DComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产配比下达信息 TC_DComp对象(即:一条记录
      /// </summary>
      public List<TC_DComp> GetAll()
      {
         List<TC_DComp> ret = new List<TC_DComp>();
         string sql = "SELECT  TCD_ID,TCD_Code,TCD_PCode,TCD_PLine,TCD_PPlan,TCD_Remark,TCD_UDef1,TCD_UDef2,TCD_UDef3,TCD_UDef4,TCD_UDef5,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_DComp where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCD_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_DComp tC_DComp = new TC_DComp();
            if (dr["TCD_ID"] != DBNull.Value) tC_DComp.TCD_ID = Convert.ToDecimal(dr["TCD_ID"]);
            if (dr["TCD_Code"] != DBNull.Value) tC_DComp.TCD_Code = Convert.ToString(dr["TCD_Code"]);
            if (dr["TCD_PCode"] != DBNull.Value) tC_DComp.TCD_PCode = Convert.ToString(dr["TCD_PCode"]);
            if (dr["TCD_PLine"] != DBNull.Value) tC_DComp.TCD_PLine = Convert.ToString(dr["TCD_PLine"]);
            if (dr["TCD_PPlan"] != DBNull.Value) tC_DComp.TCD_PPlan = Convert.ToString(dr["TCD_PPlan"]);
            if (dr["TCD_Remark"] != DBNull.Value) tC_DComp.TCD_Remark = Convert.ToString(dr["TCD_Remark"]);
            if (dr["TCD_UDef1"] != DBNull.Value) tC_DComp.TCD_UDef1 = Convert.ToString(dr["TCD_UDef1"]);
            if (dr["TCD_UDef2"] != DBNull.Value) tC_DComp.TCD_UDef2 = Convert.ToString(dr["TCD_UDef2"]);
            if (dr["TCD_UDef3"] != DBNull.Value) tC_DComp.TCD_UDef3 = Convert.ToString(dr["TCD_UDef3"]);
            if (dr["TCD_UDef4"] != DBNull.Value) tC_DComp.TCD_UDef4 = Convert.ToString(dr["TCD_UDef4"]);
            if (dr["TCD_UDef5"] != DBNull.Value) tC_DComp.TCD_UDef5 = Convert.ToString(dr["TCD_UDef5"]);
            if (dr["Stat"] != DBNull.Value) tC_DComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_DComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_DComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_DComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_DComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
