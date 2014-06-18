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
   public partial class ADOTC_RTemplate
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加TC_RTemplate对象(即:一条记录)
      /// </summary>
      public int Add(TC_RTemplate tC_RTemplate)
      {
         string sql = "INSERT INTO TC_RTemplate (TCRT_Code,TCRT_Name,TCRT_Type,TCRT_Stat,TCRT_iType,TCRT_Operator,TCRT_OpDate,TCRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCRT_Code,@TCRT_Name,@TCRT_Type,@TCRT_Stat,@TCRT_iType,@TCRT_Operator,@TCRT_OpDate,@TCRT_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Code))
         {
            idb.AddParameter("@TCRT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Code", tC_RTemplate.TCRT_Code);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Name))
         {
            idb.AddParameter("@TCRT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Name", tC_RTemplate.TCRT_Name);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Type))
         {
            idb.AddParameter("@TCRT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Type", tC_RTemplate.TCRT_Type);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Stat))
         {
            idb.AddParameter("@TCRT_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Stat", tC_RTemplate.TCRT_Stat);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_iType))
         {
            idb.AddParameter("@TCRT_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_iType", tC_RTemplate.TCRT_iType);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Operator))
         {
            idb.AddParameter("@TCRT_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Operator", tC_RTemplate.TCRT_Operator);
         }
         if (tC_RTemplate.TCRT_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRT_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_OpDate", tC_RTemplate.TCRT_OpDate);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Remark))
         {
            idb.AddParameter("@TCRT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Remark", tC_RTemplate.TCRT_Remark);
         }
         if (tC_RTemplate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RTemplate.Stat);
         }
         if (tC_RTemplate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RTemplate.CreateDate);
         }
         if (tC_RTemplate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RTemplate.UpdateDate);
         }
         if (tC_RTemplate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RTemplate.DeleteDate);
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
      /// 添加TC_RTemplate对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_RTemplate tC_RTemplate)
      {
         string sql = "INSERT INTO TC_RTemplate (TCRT_Code,TCRT_Name,TCRT_Type,TCRT_Stat,TCRT_iType,TCRT_Operator,TCRT_OpDate,TCRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCRT_Code,@TCRT_Name,@TCRT_Type,@TCRT_Stat,@TCRT_iType,@TCRT_Operator,@TCRT_OpDate,@TCRT_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Code))
         {
            idb.AddParameter("@TCRT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Code", tC_RTemplate.TCRT_Code);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Name))
         {
            idb.AddParameter("@TCRT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Name", tC_RTemplate.TCRT_Name);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Type))
         {
            idb.AddParameter("@TCRT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Type", tC_RTemplate.TCRT_Type);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Stat))
         {
            idb.AddParameter("@TCRT_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Stat", tC_RTemplate.TCRT_Stat);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_iType))
         {
            idb.AddParameter("@TCRT_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_iType", tC_RTemplate.TCRT_iType);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Operator))
         {
            idb.AddParameter("@TCRT_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Operator", tC_RTemplate.TCRT_Operator);
         }
         if (tC_RTemplate.TCRT_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRT_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_OpDate", tC_RTemplate.TCRT_OpDate);
         }
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Remark))
         {
            idb.AddParameter("@TCRT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Remark", tC_RTemplate.TCRT_Remark);
         }
         if (tC_RTemplate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RTemplate.Stat);
         }
         if (tC_RTemplate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RTemplate.CreateDate);
         }
         if (tC_RTemplate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RTemplate.UpdateDate);
         }
         if (tC_RTemplate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RTemplate.DeleteDate);
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
      /// 更新TC_RTemplate对象(即:一条记录
      /// </summary>
      public int Update(TC_RTemplate tC_RTemplate)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_RTemplate       SET ");
            if(tC_RTemplate.TCRT_Code_IsChanged){sbParameter.Append("TCRT_Code=@TCRT_Code, ");}
      if(tC_RTemplate.TCRT_Name_IsChanged){sbParameter.Append("TCRT_Name=@TCRT_Name, ");}
      if(tC_RTemplate.TCRT_Type_IsChanged){sbParameter.Append("TCRT_Type=@TCRT_Type, ");}
      if(tC_RTemplate.TCRT_Stat_IsChanged){sbParameter.Append("TCRT_Stat=@TCRT_Stat, ");}
      if(tC_RTemplate.TCRT_iType_IsChanged){sbParameter.Append("TCRT_iType=@TCRT_iType, ");}
      if(tC_RTemplate.TCRT_Operator_IsChanged){sbParameter.Append("TCRT_Operator=@TCRT_Operator, ");}
      if(tC_RTemplate.TCRT_OpDate_IsChanged){sbParameter.Append("TCRT_OpDate=@TCRT_OpDate, ");}
      if(tC_RTemplate.TCRT_Remark_IsChanged){sbParameter.Append("TCRT_Remark=@TCRT_Remark, ");}
      if(tC_RTemplate.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_RTemplate.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_RTemplate.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_RTemplate.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCRT_ID=@TCRT_ID; " );
      string sql=sb.ToString();
         if(tC_RTemplate.TCRT_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Code))
         {
            idb.AddParameter("@TCRT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Code", tC_RTemplate.TCRT_Code);
         }
          }
         if(tC_RTemplate.TCRT_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Name))
         {
            idb.AddParameter("@TCRT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Name", tC_RTemplate.TCRT_Name);
         }
          }
         if(tC_RTemplate.TCRT_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Type))
         {
            idb.AddParameter("@TCRT_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Type", tC_RTemplate.TCRT_Type);
         }
          }
         if(tC_RTemplate.TCRT_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Stat))
         {
            idb.AddParameter("@TCRT_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Stat", tC_RTemplate.TCRT_Stat);
         }
          }
         if(tC_RTemplate.TCRT_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_iType))
         {
            idb.AddParameter("@TCRT_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_iType", tC_RTemplate.TCRT_iType);
         }
          }
         if(tC_RTemplate.TCRT_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Operator))
         {
            idb.AddParameter("@TCRT_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Operator", tC_RTemplate.TCRT_Operator);
         }
          }
         if(tC_RTemplate.TCRT_OpDate_IsChanged)
         {
         if (tC_RTemplate.TCRT_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRT_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_OpDate", tC_RTemplate.TCRT_OpDate);
         }
          }
         if(tC_RTemplate.TCRT_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTemplate.TCRT_Remark))
         {
            idb.AddParameter("@TCRT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRT_Remark", tC_RTemplate.TCRT_Remark);
         }
          }
         if(tC_RTemplate.Stat_IsChanged)
         {
         if (tC_RTemplate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RTemplate.Stat);
         }
          }
         if(tC_RTemplate.CreateDate_IsChanged)
         {
         if (tC_RTemplate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RTemplate.CreateDate);
         }
          }
         if(tC_RTemplate.UpdateDate_IsChanged)
         {
         if (tC_RTemplate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RTemplate.UpdateDate);
         }
          }
         if(tC_RTemplate.DeleteDate_IsChanged)
         {
         if (tC_RTemplate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RTemplate.DeleteDate);
         }
          }

         idb.AddParameter("@TCRT_ID", tC_RTemplate.TCRT_ID);

           
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
      /// 删除TC_RTemplate对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCRT_ID)
      {
         string sql = "DELETE TC_RTemplate WHERE 1=1  AND TCRT_ID=@TCRT_ID ";
         idb.AddParameter("@TCRT_ID", tCRT_ID);

           
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
      /// 获取指定的TC_RTemplate对象(即:一条记录
      /// </summary>
      public TC_RTemplate GetByKey(decimal tCRT_ID)
      {
         TC_RTemplate tC_RTemplate = new TC_RTemplate();
         string sql = "SELECT  TCRT_ID,TCRT_Code,TCRT_Name,TCRT_Type,TCRT_Stat,TCRT_iType,TCRT_Operator,TCRT_OpDate,TCRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RTemplate WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCRT_ID=@TCRT_ID ";
         idb.AddParameter("@TCRT_ID", tCRT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCRT_ID"] != DBNull.Value) tC_RTemplate.TCRT_ID = Convert.ToDecimal(dr["TCRT_ID"]);
            if (dr["TCRT_Code"] != DBNull.Value) tC_RTemplate.TCRT_Code = Convert.ToString(dr["TCRT_Code"]);
            if (dr["TCRT_Name"] != DBNull.Value) tC_RTemplate.TCRT_Name = Convert.ToString(dr["TCRT_Name"]);
            if (dr["TCRT_Type"] != DBNull.Value) tC_RTemplate.TCRT_Type = Convert.ToString(dr["TCRT_Type"]);
            if (dr["TCRT_Stat"] != DBNull.Value) tC_RTemplate.TCRT_Stat = Convert.ToString(dr["TCRT_Stat"]);
            if (dr["TCRT_iType"] != DBNull.Value) tC_RTemplate.TCRT_iType = Convert.ToString(dr["TCRT_iType"]);
            if (dr["TCRT_Operator"] != DBNull.Value) tC_RTemplate.TCRT_Operator = Convert.ToString(dr["TCRT_Operator"]);
            if (dr["TCRT_OpDate"] != DBNull.Value) tC_RTemplate.TCRT_OpDate = Convert.ToDateTime(dr["TCRT_OpDate"]);
            if (dr["TCRT_Remark"] != DBNull.Value) tC_RTemplate.TCRT_Remark = Convert.ToString(dr["TCRT_Remark"]);
            if (dr["Stat"] != DBNull.Value) tC_RTemplate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RTemplate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RTemplate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RTemplate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_RTemplate;
      }
      /// <summary>
      /// 获取指定的TC_RTemplate对象集合
      /// </summary>
      public List<TC_RTemplate> GetListByWhere(string strCondition)
      {
         List<TC_RTemplate> ret = new List<TC_RTemplate>();
         string sql = "SELECT  TCRT_ID,TCRT_Code,TCRT_Name,TCRT_Type,TCRT_Stat,TCRT_iType,TCRT_Operator,TCRT_OpDate,TCRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RTemplate WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_RTemplate tC_RTemplate = new TC_RTemplate();
            if (dr["TCRT_ID"] != DBNull.Value) tC_RTemplate.TCRT_ID = Convert.ToDecimal(dr["TCRT_ID"]);
            if (dr["TCRT_Code"] != DBNull.Value) tC_RTemplate.TCRT_Code = Convert.ToString(dr["TCRT_Code"]);
            if (dr["TCRT_Name"] != DBNull.Value) tC_RTemplate.TCRT_Name = Convert.ToString(dr["TCRT_Name"]);
            if (dr["TCRT_Type"] != DBNull.Value) tC_RTemplate.TCRT_Type = Convert.ToString(dr["TCRT_Type"]);
            if (dr["TCRT_Stat"] != DBNull.Value) tC_RTemplate.TCRT_Stat = Convert.ToString(dr["TCRT_Stat"]);
            if (dr["TCRT_iType"] != DBNull.Value) tC_RTemplate.TCRT_iType = Convert.ToString(dr["TCRT_iType"]);
            if (dr["TCRT_Operator"] != DBNull.Value) tC_RTemplate.TCRT_Operator = Convert.ToString(dr["TCRT_Operator"]);
            if (dr["TCRT_OpDate"] != DBNull.Value) tC_RTemplate.TCRT_OpDate = Convert.ToDateTime(dr["TCRT_OpDate"]);
            if (dr["TCRT_Remark"] != DBNull.Value) tC_RTemplate.TCRT_Remark = Convert.ToString(dr["TCRT_Remark"]);
            if (dr["Stat"] != DBNull.Value) tC_RTemplate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RTemplate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RTemplate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RTemplate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RTemplate);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的TC_RTemplate对象(即:一条记录
      /// </summary>
      public List<TC_RTemplate> GetAll()
      {
         List<TC_RTemplate> ret = new List<TC_RTemplate>();
         string sql = "SELECT  TCRT_ID,TCRT_Code,TCRT_Name,TCRT_Type,TCRT_Stat,TCRT_iType,TCRT_Operator,TCRT_OpDate,TCRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RTemplate where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCRT_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_RTemplate tC_RTemplate = new TC_RTemplate();
            if (dr["TCRT_ID"] != DBNull.Value) tC_RTemplate.TCRT_ID = Convert.ToDecimal(dr["TCRT_ID"]);
            if (dr["TCRT_Code"] != DBNull.Value) tC_RTemplate.TCRT_Code = Convert.ToString(dr["TCRT_Code"]);
            if (dr["TCRT_Name"] != DBNull.Value) tC_RTemplate.TCRT_Name = Convert.ToString(dr["TCRT_Name"]);
            if (dr["TCRT_Type"] != DBNull.Value) tC_RTemplate.TCRT_Type = Convert.ToString(dr["TCRT_Type"]);
            if (dr["TCRT_Stat"] != DBNull.Value) tC_RTemplate.TCRT_Stat = Convert.ToString(dr["TCRT_Stat"]);
            if (dr["TCRT_iType"] != DBNull.Value) tC_RTemplate.TCRT_iType = Convert.ToString(dr["TCRT_iType"]);
            if (dr["TCRT_Operator"] != DBNull.Value) tC_RTemplate.TCRT_Operator = Convert.ToString(dr["TCRT_Operator"]);
            if (dr["TCRT_OpDate"] != DBNull.Value) tC_RTemplate.TCRT_OpDate = Convert.ToDateTime(dr["TCRT_OpDate"]);
            if (dr["TCRT_Remark"] != DBNull.Value) tC_RTemplate.TCRT_Remark = Convert.ToString(dr["TCRT_Remark"]);
            if (dr["Stat"] != DBNull.Value) tC_RTemplate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RTemplate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RTemplate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RTemplate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RTemplate);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
