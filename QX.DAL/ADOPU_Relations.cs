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
   public partial class ADOPU_Relations
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PU_Relations对象(即:一条记录)
      /// </summary>
      public int Add(PU_Relations pU_Relations)
      {
         string sql = "INSERT INTO PU_Relations (PUR_SRCode,PUR_SRTpe,PUR_RCode,PUR_RType,PUR_MCode,PUR_SNum,PUR_Num,PUR_Date,PUR_Owner,PUR_OwnerCode,PUR_Udef1,PUR_Udef2,PUR_Udef3,PUR_Udef4,PUR_Udef5,Stat) VALUES (@PUR_SRCode,@PUR_SRTpe,@PUR_RCode,@PUR_RType,@PUR_MCode,@PUR_SNum,@PUR_Num,@PUR_Date,@PUR_Owner,@PUR_OwnerCode,@PUR_Udef1,@PUR_Udef2,@PUR_Udef3,@PUR_Udef4,@PUR_Udef5,@Stat)";
         if (string.IsNullOrEmpty(pU_Relations.PUR_SRCode))
         {
            idb.AddParameter("@PUR_SRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_SRCode", pU_Relations.PUR_SRCode);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_SRTpe))
         {
            idb.AddParameter("@PUR_SRTpe", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_SRTpe", pU_Relations.PUR_SRTpe);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_RCode))
         {
            idb.AddParameter("@PUR_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_RCode", pU_Relations.PUR_RCode);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_RType))
         {
            idb.AddParameter("@PUR_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_RType", pU_Relations.PUR_RType);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_MCode))
         {
            idb.AddParameter("@PUR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_MCode", pU_Relations.PUR_MCode);
         }
         if (pU_Relations.PUR_SNum == 0)
         {
            idb.AddParameter("@PUR_SNum", 0);
         }
         else
         {
            idb.AddParameter("@PUR_SNum", pU_Relations.PUR_SNum);
         }
         if (pU_Relations.PUR_Num == 0)
         {
            idb.AddParameter("@PUR_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUR_Num", pU_Relations.PUR_Num);
         }
         if (pU_Relations.PUR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PUR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Date", pU_Relations.PUR_Date);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Owner))
         {
            idb.AddParameter("@PUR_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Owner", pU_Relations.PUR_Owner);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_OwnerCode))
         {
            idb.AddParameter("@PUR_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_OwnerCode", pU_Relations.PUR_OwnerCode);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef1))
         {
            idb.AddParameter("@PUR_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef1", pU_Relations.PUR_Udef1);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef2))
         {
            idb.AddParameter("@PUR_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef2", pU_Relations.PUR_Udef2);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef3))
         {
            idb.AddParameter("@PUR_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef3", pU_Relations.PUR_Udef3);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef4))
         {
            idb.AddParameter("@PUR_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef4", pU_Relations.PUR_Udef4);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef5))
         {
            idb.AddParameter("@PUR_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef5", pU_Relations.PUR_Udef5);
         }
         if (string.IsNullOrEmpty(pU_Relations.Stat))
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Relations.Stat);
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
      /// 添加PU_Relations对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PU_Relations pU_Relations)
      {
         string sql = "INSERT INTO PU_Relations (PUR_SRCode,PUR_SRTpe,PUR_RCode,PUR_RType,PUR_MCode,PUR_SNum,PUR_Num,PUR_Date,PUR_Owner,PUR_OwnerCode,PUR_Udef1,PUR_Udef2,PUR_Udef3,PUR_Udef4,PUR_Udef5,Stat) VALUES (@PUR_SRCode,@PUR_SRTpe,@PUR_RCode,@PUR_RType,@PUR_MCode,@PUR_SNum,@PUR_Num,@PUR_Date,@PUR_Owner,@PUR_OwnerCode,@PUR_Udef1,@PUR_Udef2,@PUR_Udef3,@PUR_Udef4,@PUR_Udef5,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pU_Relations.PUR_SRCode))
         {
            idb.AddParameter("@PUR_SRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_SRCode", pU_Relations.PUR_SRCode);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_SRTpe))
         {
            idb.AddParameter("@PUR_SRTpe", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_SRTpe", pU_Relations.PUR_SRTpe);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_RCode))
         {
            idb.AddParameter("@PUR_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_RCode", pU_Relations.PUR_RCode);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_RType))
         {
            idb.AddParameter("@PUR_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_RType", pU_Relations.PUR_RType);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_MCode))
         {
            idb.AddParameter("@PUR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_MCode", pU_Relations.PUR_MCode);
         }
         if (pU_Relations.PUR_SNum == 0)
         {
            idb.AddParameter("@PUR_SNum", 0);
         }
         else
         {
            idb.AddParameter("@PUR_SNum", pU_Relations.PUR_SNum);
         }
         if (pU_Relations.PUR_Num == 0)
         {
            idb.AddParameter("@PUR_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUR_Num", pU_Relations.PUR_Num);
         }
         if (pU_Relations.PUR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PUR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Date", pU_Relations.PUR_Date);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Owner))
         {
            idb.AddParameter("@PUR_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Owner", pU_Relations.PUR_Owner);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_OwnerCode))
         {
            idb.AddParameter("@PUR_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_OwnerCode", pU_Relations.PUR_OwnerCode);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef1))
         {
            idb.AddParameter("@PUR_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef1", pU_Relations.PUR_Udef1);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef2))
         {
            idb.AddParameter("@PUR_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef2", pU_Relations.PUR_Udef2);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef3))
         {
            idb.AddParameter("@PUR_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef3", pU_Relations.PUR_Udef3);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef4))
         {
            idb.AddParameter("@PUR_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef4", pU_Relations.PUR_Udef4);
         }
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef5))
         {
            idb.AddParameter("@PUR_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef5", pU_Relations.PUR_Udef5);
         }
         if (string.IsNullOrEmpty(pU_Relations.Stat))
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Relations.Stat);
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
      /// 更新PU_Relations对象(即:一条记录
      /// </summary>
      public int Update(PU_Relations pU_Relations)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PU_Relations       SET ");
            if(pU_Relations.PUR_SRCode_IsChanged){sbParameter.Append("PUR_SRCode=@PUR_SRCode, ");}
      if(pU_Relations.PUR_SRTpe_IsChanged){sbParameter.Append("PUR_SRTpe=@PUR_SRTpe, ");}
      if(pU_Relations.PUR_RCode_IsChanged){sbParameter.Append("PUR_RCode=@PUR_RCode, ");}
      if(pU_Relations.PUR_RType_IsChanged){sbParameter.Append("PUR_RType=@PUR_RType, ");}
      if(pU_Relations.PUR_MCode_IsChanged){sbParameter.Append("PUR_MCode=@PUR_MCode, ");}
      if(pU_Relations.PUR_SNum_IsChanged){sbParameter.Append("PUR_SNum=@PUR_SNum, ");}
      if(pU_Relations.PUR_Num_IsChanged){sbParameter.Append("PUR_Num=@PUR_Num, ");}
      if(pU_Relations.PUR_Date_IsChanged){sbParameter.Append("PUR_Date=@PUR_Date, ");}
      if(pU_Relations.PUR_Owner_IsChanged){sbParameter.Append("PUR_Owner=@PUR_Owner, ");}
      if(pU_Relations.PUR_OwnerCode_IsChanged){sbParameter.Append("PUR_OwnerCode=@PUR_OwnerCode, ");}
      if(pU_Relations.PUR_Udef1_IsChanged){sbParameter.Append("PUR_Udef1=@PUR_Udef1, ");}
      if(pU_Relations.PUR_Udef2_IsChanged){sbParameter.Append("PUR_Udef2=@PUR_Udef2, ");}
      if(pU_Relations.PUR_Udef3_IsChanged){sbParameter.Append("PUR_Udef3=@PUR_Udef3, ");}
      if(pU_Relations.PUR_Udef4_IsChanged){sbParameter.Append("PUR_Udef4=@PUR_Udef4, ");}
      if(pU_Relations.PUR_Udef5_IsChanged){sbParameter.Append("PUR_Udef5=@PUR_Udef5, ");}
      if(pU_Relations.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PUR_ID=@PUR_ID; " );
      string sql=sb.ToString();
         if(pU_Relations.PUR_SRCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_SRCode))
         {
            idb.AddParameter("@PUR_SRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_SRCode", pU_Relations.PUR_SRCode);
         }
          }
         if(pU_Relations.PUR_SRTpe_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_SRTpe))
         {
            idb.AddParameter("@PUR_SRTpe", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_SRTpe", pU_Relations.PUR_SRTpe);
         }
          }
         if(pU_Relations.PUR_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_RCode))
         {
            idb.AddParameter("@PUR_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_RCode", pU_Relations.PUR_RCode);
         }
          }
         if(pU_Relations.PUR_RType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_RType))
         {
            idb.AddParameter("@PUR_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_RType", pU_Relations.PUR_RType);
         }
          }
         if(pU_Relations.PUR_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_MCode))
         {
            idb.AddParameter("@PUR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_MCode", pU_Relations.PUR_MCode);
         }
          }
         if(pU_Relations.PUR_SNum_IsChanged)
         {
         if (pU_Relations.PUR_SNum == 0)
         {
            idb.AddParameter("@PUR_SNum", 0);
         }
         else
         {
            idb.AddParameter("@PUR_SNum", pU_Relations.PUR_SNum);
         }
          }
         if(pU_Relations.PUR_Num_IsChanged)
         {
         if (pU_Relations.PUR_Num == 0)
         {
            idb.AddParameter("@PUR_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUR_Num", pU_Relations.PUR_Num);
         }
          }
         if(pU_Relations.PUR_Date_IsChanged)
         {
         if (pU_Relations.PUR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PUR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Date", pU_Relations.PUR_Date);
         }
          }
         if(pU_Relations.PUR_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_Owner))
         {
            idb.AddParameter("@PUR_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Owner", pU_Relations.PUR_Owner);
         }
          }
         if(pU_Relations.PUR_OwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_OwnerCode))
         {
            idb.AddParameter("@PUR_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_OwnerCode", pU_Relations.PUR_OwnerCode);
         }
          }
         if(pU_Relations.PUR_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef1))
         {
            idb.AddParameter("@PUR_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef1", pU_Relations.PUR_Udef1);
         }
          }
         if(pU_Relations.PUR_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef2))
         {
            idb.AddParameter("@PUR_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef2", pU_Relations.PUR_Udef2);
         }
          }
         if(pU_Relations.PUR_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef3))
         {
            idb.AddParameter("@PUR_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef3", pU_Relations.PUR_Udef3);
         }
          }
         if(pU_Relations.PUR_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef4))
         {
            idb.AddParameter("@PUR_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef4", pU_Relations.PUR_Udef4);
         }
          }
         if(pU_Relations.PUR_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.PUR_Udef5))
         {
            idb.AddParameter("@PUR_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUR_Udef5", pU_Relations.PUR_Udef5);
         }
          }
         if(pU_Relations.Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Relations.Stat))
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Relations.Stat);
         }
          }

         idb.AddParameter("@PUR_ID", pU_Relations.PUR_ID);

           
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
      /// 删除PU_Relations对象(即:一条记录
      /// </summary>
      public int Delete(Int64 pUR_ID)
      {
         string sql = "DELETE PU_Relations WHERE 1=1  AND PUR_ID=@PUR_ID ";
         idb.AddParameter("@PUR_ID", pUR_ID);

           
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
      /// 获取指定的PU_Relations对象(即:一条记录
      /// </summary>
      public PU_Relations GetByKey(Int64 pUR_ID)
      {
         PU_Relations pU_Relations = new PU_Relations();
         string sql = "SELECT  PUR_ID,PUR_SRCode,PUR_SRTpe,PUR_RCode,PUR_RType,PUR_MCode,PUR_SNum,PUR_Num,PUR_Date,PUR_Owner,PUR_OwnerCode,PUR_Udef1,PUR_Udef2,PUR_Udef3,PUR_Udef4,PUR_Udef5,Stat FROM PU_Relations WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PUR_ID=@PUR_ID ";
         idb.AddParameter("@PUR_ID", pUR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PUR_ID"] != DBNull.Value) pU_Relations.PUR_ID = Convert.ToInt64(dr["PUR_ID"]);
            if (dr["PUR_SRCode"] != DBNull.Value) pU_Relations.PUR_SRCode = Convert.ToString(dr["PUR_SRCode"]);
            if (dr["PUR_SRTpe"] != DBNull.Value) pU_Relations.PUR_SRTpe = Convert.ToString(dr["PUR_SRTpe"]);
            if (dr["PUR_RCode"] != DBNull.Value) pU_Relations.PUR_RCode = Convert.ToString(dr["PUR_RCode"]);
            if (dr["PUR_RType"] != DBNull.Value) pU_Relations.PUR_RType = Convert.ToString(dr["PUR_RType"]);
            if (dr["PUR_MCode"] != DBNull.Value) pU_Relations.PUR_MCode = Convert.ToString(dr["PUR_MCode"]);
            if (dr["PUR_SNum"] != DBNull.Value) pU_Relations.PUR_SNum = Convert.ToDecimal(dr["PUR_SNum"]);
            if (dr["PUR_Num"] != DBNull.Value) pU_Relations.PUR_Num = Convert.ToDecimal(dr["PUR_Num"]);
            if (dr["PUR_Date"] != DBNull.Value) pU_Relations.PUR_Date = Convert.ToDateTime(dr["PUR_Date"]);
            if (dr["PUR_Owner"] != DBNull.Value) pU_Relations.PUR_Owner = Convert.ToString(dr["PUR_Owner"]);
            if (dr["PUR_OwnerCode"] != DBNull.Value) pU_Relations.PUR_OwnerCode = Convert.ToString(dr["PUR_OwnerCode"]);
            if (dr["PUR_Udef1"] != DBNull.Value) pU_Relations.PUR_Udef1 = Convert.ToString(dr["PUR_Udef1"]);
            if (dr["PUR_Udef2"] != DBNull.Value) pU_Relations.PUR_Udef2 = Convert.ToString(dr["PUR_Udef2"]);
            if (dr["PUR_Udef3"] != DBNull.Value) pU_Relations.PUR_Udef3 = Convert.ToString(dr["PUR_Udef3"]);
            if (dr["PUR_Udef4"] != DBNull.Value) pU_Relations.PUR_Udef4 = Convert.ToString(dr["PUR_Udef4"]);
            if (dr["PUR_Udef5"] != DBNull.Value) pU_Relations.PUR_Udef5 = Convert.ToString(dr["PUR_Udef5"]);
            if (dr["Stat"] != DBNull.Value) pU_Relations.Stat = Convert.ToString(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pU_Relations;
      }
      /// <summary>
      /// 获取指定的PU_Relations对象集合
      /// </summary>
      public List<PU_Relations> GetListByWhere(string strCondition)
      {
         List<PU_Relations> ret = new List<PU_Relations>();
         string sql = "SELECT  PUR_ID,PUR_SRCode,PUR_SRTpe,PUR_RCode,PUR_RType,PUR_MCode,PUR_SNum,PUR_Num,PUR_Date,PUR_Owner,PUR_OwnerCode,PUR_Udef1,PUR_Udef2,PUR_Udef3,PUR_Udef4,PUR_Udef5,Stat FROM PU_Relations WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PU_Relations pU_Relations = new PU_Relations();
            if (dr["PUR_ID"] != DBNull.Value) pU_Relations.PUR_ID = Convert.ToInt64(dr["PUR_ID"]);
            if (dr["PUR_SRCode"] != DBNull.Value) pU_Relations.PUR_SRCode = Convert.ToString(dr["PUR_SRCode"]);
            if (dr["PUR_SRTpe"] != DBNull.Value) pU_Relations.PUR_SRTpe = Convert.ToString(dr["PUR_SRTpe"]);
            if (dr["PUR_RCode"] != DBNull.Value) pU_Relations.PUR_RCode = Convert.ToString(dr["PUR_RCode"]);
            if (dr["PUR_RType"] != DBNull.Value) pU_Relations.PUR_RType = Convert.ToString(dr["PUR_RType"]);
            if (dr["PUR_MCode"] != DBNull.Value) pU_Relations.PUR_MCode = Convert.ToString(dr["PUR_MCode"]);
            if (dr["PUR_SNum"] != DBNull.Value) pU_Relations.PUR_SNum = Convert.ToDecimal(dr["PUR_SNum"]);
            if (dr["PUR_Num"] != DBNull.Value) pU_Relations.PUR_Num = Convert.ToDecimal(dr["PUR_Num"]);
            if (dr["PUR_Date"] != DBNull.Value) pU_Relations.PUR_Date = Convert.ToDateTime(dr["PUR_Date"]);
            if (dr["PUR_Owner"] != DBNull.Value) pU_Relations.PUR_Owner = Convert.ToString(dr["PUR_Owner"]);
            if (dr["PUR_OwnerCode"] != DBNull.Value) pU_Relations.PUR_OwnerCode = Convert.ToString(dr["PUR_OwnerCode"]);
            if (dr["PUR_Udef1"] != DBNull.Value) pU_Relations.PUR_Udef1 = Convert.ToString(dr["PUR_Udef1"]);
            if (dr["PUR_Udef2"] != DBNull.Value) pU_Relations.PUR_Udef2 = Convert.ToString(dr["PUR_Udef2"]);
            if (dr["PUR_Udef3"] != DBNull.Value) pU_Relations.PUR_Udef3 = Convert.ToString(dr["PUR_Udef3"]);
            if (dr["PUR_Udef4"] != DBNull.Value) pU_Relations.PUR_Udef4 = Convert.ToString(dr["PUR_Udef4"]);
            if (dr["PUR_Udef5"] != DBNull.Value) pU_Relations.PUR_Udef5 = Convert.ToString(dr["PUR_Udef5"]);
            if (dr["Stat"] != DBNull.Value) pU_Relations.Stat = Convert.ToString(dr["Stat"]);
            ret.Add(pU_Relations);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PU_Relations对象(即:一条记录
      /// </summary>
      public List<PU_Relations> GetAll()
      {
         List<PU_Relations> ret = new List<PU_Relations>();
         string sql = "SELECT  PUR_ID,PUR_SRCode,PUR_SRTpe,PUR_RCode,PUR_RType,PUR_MCode,PUR_SNum,PUR_Num,PUR_Date,PUR_Owner,PUR_OwnerCode,PUR_Udef1,PUR_Udef2,PUR_Udef3,PUR_Udef4,PUR_Udef5,Stat FROM PU_Relations where 1=1 AND ((Stat is null) or (Stat=0) ) order by PUR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PU_Relations pU_Relations = new PU_Relations();
            if (dr["PUR_ID"] != DBNull.Value) pU_Relations.PUR_ID = Convert.ToInt64(dr["PUR_ID"]);
            if (dr["PUR_SRCode"] != DBNull.Value) pU_Relations.PUR_SRCode = Convert.ToString(dr["PUR_SRCode"]);
            if (dr["PUR_SRTpe"] != DBNull.Value) pU_Relations.PUR_SRTpe = Convert.ToString(dr["PUR_SRTpe"]);
            if (dr["PUR_RCode"] != DBNull.Value) pU_Relations.PUR_RCode = Convert.ToString(dr["PUR_RCode"]);
            if (dr["PUR_RType"] != DBNull.Value) pU_Relations.PUR_RType = Convert.ToString(dr["PUR_RType"]);
            if (dr["PUR_MCode"] != DBNull.Value) pU_Relations.PUR_MCode = Convert.ToString(dr["PUR_MCode"]);
            if (dr["PUR_SNum"] != DBNull.Value) pU_Relations.PUR_SNum = Convert.ToDecimal(dr["PUR_SNum"]);
            if (dr["PUR_Num"] != DBNull.Value) pU_Relations.PUR_Num = Convert.ToDecimal(dr["PUR_Num"]);
            if (dr["PUR_Date"] != DBNull.Value) pU_Relations.PUR_Date = Convert.ToDateTime(dr["PUR_Date"]);
            if (dr["PUR_Owner"] != DBNull.Value) pU_Relations.PUR_Owner = Convert.ToString(dr["PUR_Owner"]);
            if (dr["PUR_OwnerCode"] != DBNull.Value) pU_Relations.PUR_OwnerCode = Convert.ToString(dr["PUR_OwnerCode"]);
            if (dr["PUR_Udef1"] != DBNull.Value) pU_Relations.PUR_Udef1 = Convert.ToString(dr["PUR_Udef1"]);
            if (dr["PUR_Udef2"] != DBNull.Value) pU_Relations.PUR_Udef2 = Convert.ToString(dr["PUR_Udef2"]);
            if (dr["PUR_Udef3"] != DBNull.Value) pU_Relations.PUR_Udef3 = Convert.ToString(dr["PUR_Udef3"]);
            if (dr["PUR_Udef4"] != DBNull.Value) pU_Relations.PUR_Udef4 = Convert.ToString(dr["PUR_Udef4"]);
            if (dr["PUR_Udef5"] != DBNull.Value) pU_Relations.PUR_Udef5 = Convert.ToString(dr["PUR_Udef5"]);
            if (dr["Stat"] != DBNull.Value) pU_Relations.Stat = Convert.ToString(dr["Stat"]);
            ret.Add(pU_Relations);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
