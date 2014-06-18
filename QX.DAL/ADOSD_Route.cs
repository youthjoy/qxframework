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
   /// 路线规划明细
   /// </summary>
   [Serializable]
   public partial class ADOSD_Route
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加路线规划明细 SD_Route对象(即:一条记录)
      /// </summary>
      public int Add(SD_Route sD_Route)
      {
         string sql = "INSERT INTO SD_Route (SR_Code,SR_Longtitude,SR_Latitude,SR_UDEF_1,SR_UDEF_2,SR_UDEF_3,SR_UDEF_4,SR_UDEF_5,Stat) VALUES (@SR_Code,@SR_Longtitude,@SR_Latitude,@SR_UDEF_1,@SR_UDEF_2,@SR_UDEF_3,@SR_UDEF_4,@SR_UDEF_5,@Stat)";
         if (string.IsNullOrEmpty(sD_Route.SR_Code))
         {
            idb.AddParameter("@SR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_Code", sD_Route.SR_Code);
         }
         if (sD_Route.SR_Longtitude == 0)
         {
            idb.AddParameter("@SR_Longtitude", 0);
         }
         else
         {
            idb.AddParameter("@SR_Longtitude", sD_Route.SR_Longtitude);
         }
         if (sD_Route.SR_Latitude == 0)
         {
            idb.AddParameter("@SR_Latitude", 0);
         }
         else
         {
            idb.AddParameter("@SR_Latitude", sD_Route.SR_Latitude);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_1))
         {
            idb.AddParameter("@SR_UDEF_1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_1", sD_Route.SR_UDEF_1);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_2))
         {
            idb.AddParameter("@SR_UDEF_2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_2", sD_Route.SR_UDEF_2);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_3))
         {
            idb.AddParameter("@SR_UDEF_3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_3", sD_Route.SR_UDEF_3);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_4))
         {
            idb.AddParameter("@SR_UDEF_4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_4", sD_Route.SR_UDEF_4);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_5))
         {
            idb.AddParameter("@SR_UDEF_5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_5", sD_Route.SR_UDEF_5);
         }
         if (sD_Route.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Route.Stat);
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
      /// 添加路线规划明细 SD_Route对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Route sD_Route)
      {
         string sql = "INSERT INTO SD_Route (SR_Code,SR_Longtitude,SR_Latitude,SR_UDEF_1,SR_UDEF_2,SR_UDEF_3,SR_UDEF_4,SR_UDEF_5,Stat) VALUES (@SR_Code,@SR_Longtitude,@SR_Latitude,@SR_UDEF_1,@SR_UDEF_2,@SR_UDEF_3,@SR_UDEF_4,@SR_UDEF_5,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Route.SR_Code))
         {
            idb.AddParameter("@SR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_Code", sD_Route.SR_Code);
         }
         if (sD_Route.SR_Longtitude == 0)
         {
            idb.AddParameter("@SR_Longtitude", 0);
         }
         else
         {
            idb.AddParameter("@SR_Longtitude", sD_Route.SR_Longtitude);
         }
         if (sD_Route.SR_Latitude == 0)
         {
            idb.AddParameter("@SR_Latitude", 0);
         }
         else
         {
            idb.AddParameter("@SR_Latitude", sD_Route.SR_Latitude);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_1))
         {
            idb.AddParameter("@SR_UDEF_1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_1", sD_Route.SR_UDEF_1);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_2))
         {
            idb.AddParameter("@SR_UDEF_2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_2", sD_Route.SR_UDEF_2);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_3))
         {
            idb.AddParameter("@SR_UDEF_3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_3", sD_Route.SR_UDEF_3);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_4))
         {
            idb.AddParameter("@SR_UDEF_4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_4", sD_Route.SR_UDEF_4);
         }
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_5))
         {
            idb.AddParameter("@SR_UDEF_5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_5", sD_Route.SR_UDEF_5);
         }
         if (sD_Route.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Route.Stat);
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
      /// 更新路线规划明细 SD_Route对象(即:一条记录
      /// </summary>
      public int Update(SD_Route sD_Route)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Route       SET ");
            if(sD_Route.SR_Code_IsChanged){sbParameter.Append("SR_Code=@SR_Code, ");}
      if(sD_Route.SR_Longtitude_IsChanged){sbParameter.Append("SR_Longtitude=@SR_Longtitude, ");}
      if(sD_Route.SR_Latitude_IsChanged){sbParameter.Append("SR_Latitude=@SR_Latitude, ");}
      if(sD_Route.SR_UDEF_1_IsChanged){sbParameter.Append("SR_UDEF_1=@SR_UDEF_1, ");}
      if(sD_Route.SR_UDEF_2_IsChanged){sbParameter.Append("SR_UDEF_2=@SR_UDEF_2, ");}
      if(sD_Route.SR_UDEF_3_IsChanged){sbParameter.Append("SR_UDEF_3=@SR_UDEF_3, ");}
      if(sD_Route.SR_UDEF_4_IsChanged){sbParameter.Append("SR_UDEF_4=@SR_UDEF_4, ");}
      if(sD_Route.SR_UDEF_5_IsChanged){sbParameter.Append("SR_UDEF_5=@SR_UDEF_5, ");}
      if(sD_Route.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SR_ID=@SR_ID; " );
      string sql=sb.ToString();
         if(sD_Route.SR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Route.SR_Code))
         {
            idb.AddParameter("@SR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_Code", sD_Route.SR_Code);
         }
          }
         if(sD_Route.SR_Longtitude_IsChanged)
         {
         if (sD_Route.SR_Longtitude == 0)
         {
            idb.AddParameter("@SR_Longtitude", 0);
         }
         else
         {
            idb.AddParameter("@SR_Longtitude", sD_Route.SR_Longtitude);
         }
          }
         if(sD_Route.SR_Latitude_IsChanged)
         {
         if (sD_Route.SR_Latitude == 0)
         {
            idb.AddParameter("@SR_Latitude", 0);
         }
         else
         {
            idb.AddParameter("@SR_Latitude", sD_Route.SR_Latitude);
         }
          }
         if(sD_Route.SR_UDEF_1_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_1))
         {
            idb.AddParameter("@SR_UDEF_1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_1", sD_Route.SR_UDEF_1);
         }
          }
         if(sD_Route.SR_UDEF_2_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_2))
         {
            idb.AddParameter("@SR_UDEF_2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_2", sD_Route.SR_UDEF_2);
         }
          }
         if(sD_Route.SR_UDEF_3_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_3))
         {
            idb.AddParameter("@SR_UDEF_3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_3", sD_Route.SR_UDEF_3);
         }
          }
         if(sD_Route.SR_UDEF_4_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_4))
         {
            idb.AddParameter("@SR_UDEF_4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_4", sD_Route.SR_UDEF_4);
         }
          }
         if(sD_Route.SR_UDEF_5_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Route.SR_UDEF_5))
         {
            idb.AddParameter("@SR_UDEF_5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SR_UDEF_5", sD_Route.SR_UDEF_5);
         }
          }
         if(sD_Route.Stat_IsChanged)
         {
         if (sD_Route.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Route.Stat);
         }
          }

         idb.AddParameter("@SR_ID", sD_Route.SR_ID);

           
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
      /// 删除路线规划明细 SD_Route对象(即:一条记录
      /// </summary>
      public int Delete(decimal sR_ID)
      {
         string sql = "DELETE SD_Route WHERE 1=1  AND SR_ID=@SR_ID ";
         idb.AddParameter("@SR_ID", sR_ID);

           
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
      /// 获取指定的路线规划明细 SD_Route对象(即:一条记录
      /// </summary>
      public SD_Route GetByKey(decimal sR_ID)
      {
         SD_Route sD_Route = new SD_Route();
         string sql = "SELECT  SR_ID,SR_Code,SR_Longtitude,SR_Latitude,SR_UDEF_1,SR_UDEF_2,SR_UDEF_3,SR_UDEF_4,SR_UDEF_5,Stat FROM SD_Route WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SR_ID=@SR_ID ";
         idb.AddParameter("@SR_ID", sR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SR_ID"] != DBNull.Value) sD_Route.SR_ID = Convert.ToDecimal(dr["SR_ID"]);
            if (dr["SR_Code"] != DBNull.Value) sD_Route.SR_Code = Convert.ToString(dr["SR_Code"]);
            if (dr["SR_Longtitude"] != DBNull.Value) sD_Route.SR_Longtitude = Convert.ToDecimal(dr["SR_Longtitude"]);
            if (dr["SR_Latitude"] != DBNull.Value) sD_Route.SR_Latitude = Convert.ToDecimal(dr["SR_Latitude"]);
            if (dr["SR_UDEF_1"] != DBNull.Value) sD_Route.SR_UDEF_1 = Convert.ToString(dr["SR_UDEF_1"]);
            if (dr["SR_UDEF_2"] != DBNull.Value) sD_Route.SR_UDEF_2 = Convert.ToString(dr["SR_UDEF_2"]);
            if (dr["SR_UDEF_3"] != DBNull.Value) sD_Route.SR_UDEF_3 = Convert.ToString(dr["SR_UDEF_3"]);
            if (dr["SR_UDEF_4"] != DBNull.Value) sD_Route.SR_UDEF_4 = Convert.ToString(dr["SR_UDEF_4"]);
            if (dr["SR_UDEF_5"] != DBNull.Value) sD_Route.SR_UDEF_5 = Convert.ToString(dr["SR_UDEF_5"]);
            if (dr["Stat"] != DBNull.Value) sD_Route.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Route;
      }
      /// <summary>
      /// 获取指定的路线规划明细 SD_Route对象集合
      /// </summary>
      public List<SD_Route> GetListByWhere(string strCondition)
      {
         List<SD_Route> ret = new List<SD_Route>();
         string sql = "SELECT  SR_ID,SR_Code,SR_Longtitude,SR_Latitude,SR_UDEF_1,SR_UDEF_2,SR_UDEF_3,SR_UDEF_4,SR_UDEF_5,Stat FROM SD_Route WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Route sD_Route = new SD_Route();
            if (dr["SR_ID"] != DBNull.Value) sD_Route.SR_ID = Convert.ToDecimal(dr["SR_ID"]);
            if (dr["SR_Code"] != DBNull.Value) sD_Route.SR_Code = Convert.ToString(dr["SR_Code"]);
            if (dr["SR_Longtitude"] != DBNull.Value) sD_Route.SR_Longtitude = Convert.ToDecimal(dr["SR_Longtitude"]);
            if (dr["SR_Latitude"] != DBNull.Value) sD_Route.SR_Latitude = Convert.ToDecimal(dr["SR_Latitude"]);
            if (dr["SR_UDEF_1"] != DBNull.Value) sD_Route.SR_UDEF_1 = Convert.ToString(dr["SR_UDEF_1"]);
            if (dr["SR_UDEF_2"] != DBNull.Value) sD_Route.SR_UDEF_2 = Convert.ToString(dr["SR_UDEF_2"]);
            if (dr["SR_UDEF_3"] != DBNull.Value) sD_Route.SR_UDEF_3 = Convert.ToString(dr["SR_UDEF_3"]);
            if (dr["SR_UDEF_4"] != DBNull.Value) sD_Route.SR_UDEF_4 = Convert.ToString(dr["SR_UDEF_4"]);
            if (dr["SR_UDEF_5"] != DBNull.Value) sD_Route.SR_UDEF_5 = Convert.ToString(dr["SR_UDEF_5"]);
            if (dr["Stat"] != DBNull.Value) sD_Route.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sD_Route);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的路线规划明细 SD_Route对象(即:一条记录
      /// </summary>
      public List<SD_Route> GetAll()
      {
         List<SD_Route> ret = new List<SD_Route>();
         string sql = "SELECT  SR_ID,SR_Code,SR_Longtitude,SR_Latitude,SR_UDEF_1,SR_UDEF_2,SR_UDEF_3,SR_UDEF_4,SR_UDEF_5,Stat FROM SD_Route where 1=1 AND ((Stat is null) or (Stat=0) ) order by SR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Route sD_Route = new SD_Route();
            if (dr["SR_ID"] != DBNull.Value) sD_Route.SR_ID = Convert.ToDecimal(dr["SR_ID"]);
            if (dr["SR_Code"] != DBNull.Value) sD_Route.SR_Code = Convert.ToString(dr["SR_Code"]);
            if (dr["SR_Longtitude"] != DBNull.Value) sD_Route.SR_Longtitude = Convert.ToDecimal(dr["SR_Longtitude"]);
            if (dr["SR_Latitude"] != DBNull.Value) sD_Route.SR_Latitude = Convert.ToDecimal(dr["SR_Latitude"]);
            if (dr["SR_UDEF_1"] != DBNull.Value) sD_Route.SR_UDEF_1 = Convert.ToString(dr["SR_UDEF_1"]);
            if (dr["SR_UDEF_2"] != DBNull.Value) sD_Route.SR_UDEF_2 = Convert.ToString(dr["SR_UDEF_2"]);
            if (dr["SR_UDEF_3"] != DBNull.Value) sD_Route.SR_UDEF_3 = Convert.ToString(dr["SR_UDEF_3"]);
            if (dr["SR_UDEF_4"] != DBNull.Value) sD_Route.SR_UDEF_4 = Convert.ToString(dr["SR_UDEF_4"]);
            if (dr["SR_UDEF_5"] != DBNull.Value) sD_Route.SR_UDEF_5 = Convert.ToString(dr["SR_UDEF_5"]);
            if (dr["Stat"] != DBNull.Value) sD_Route.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sD_Route);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
