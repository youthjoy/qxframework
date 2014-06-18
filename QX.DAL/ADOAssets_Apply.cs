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
   public partial class ADOAssets_Apply
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Assets_Apply对象(即:一条记录)
      /// </summary>
      public int Add(Assets_Apply assets_Apply)
      {
         string sql = "INSERT INTO Assets_Apply (AssetsApply_Code,AssetsApply_AppPerson,AssetsApply_AppDept,AssetsApply_AppName,AssetsApply_Parameter,AssetsApply_Description,AssetsApply_AppCount,AssetsApply_Type,AssetsApply_AppType,AssetsApply_Date,AssetsApply_AudistStat,AssetsApply_Stat,AssetsApply_Remark,Stat) VALUES (@AssetsApply_Code,@AssetsApply_AppPerson,@AssetsApply_AppDept,@AssetsApply_AppName,@AssetsApply_Parameter,@AssetsApply_Description,@AssetsApply_AppCount,@AssetsApply_Type,@AssetsApply_AppType,@AssetsApply_Date,@AssetsApply_AudistStat,@AssetsApply_Stat,@AssetsApply_Remark,@Stat)";
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Code))
         {
            idb.AddParameter("@AssetsApply_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Code", assets_Apply.AssetsApply_Code);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppPerson))
         {
            idb.AddParameter("@AssetsApply_AppPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppPerson", assets_Apply.AssetsApply_AppPerson);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppDept))
         {
            idb.AddParameter("@AssetsApply_AppDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppDept", assets_Apply.AssetsApply_AppDept);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppName))
         {
            idb.AddParameter("@AssetsApply_AppName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppName", assets_Apply.AssetsApply_AppName);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Parameter))
         {
            idb.AddParameter("@AssetsApply_Parameter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Parameter", assets_Apply.AssetsApply_Parameter);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Description))
         {
            idb.AddParameter("@AssetsApply_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Description", assets_Apply.AssetsApply_Description);
         }
         if (assets_Apply.AssetsApply_AppCount == 0)
         {
            idb.AddParameter("@AssetsApply_AppCount", 0);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppCount", assets_Apply.AssetsApply_AppCount);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Type))
         {
            idb.AddParameter("@AssetsApply_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Type", assets_Apply.AssetsApply_Type);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppType))
         {
            idb.AddParameter("@AssetsApply_AppType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppType", assets_Apply.AssetsApply_AppType);
         }
         if (assets_Apply.AssetsApply_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AssetsApply_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Date", assets_Apply.AssetsApply_Date);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AudistStat))
         {
            idb.AddParameter("@AssetsApply_AudistStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AudistStat", assets_Apply.AssetsApply_AudistStat);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Stat))
         {
            idb.AddParameter("@AssetsApply_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Stat", assets_Apply.AssetsApply_Stat);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Remark))
         {
            idb.AddParameter("@AssetsApply_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Remark", assets_Apply.AssetsApply_Remark);
         }
         if (assets_Apply.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", assets_Apply.Stat);
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
      /// 添加Assets_Apply对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Assets_Apply assets_Apply)
      {
         string sql = "INSERT INTO Assets_Apply (AssetsApply_Code,AssetsApply_AppPerson,AssetsApply_AppDept,AssetsApply_AppName,AssetsApply_Parameter,AssetsApply_Description,AssetsApply_AppCount,AssetsApply_Type,AssetsApply_AppType,AssetsApply_Date,AssetsApply_AudistStat,AssetsApply_Stat,AssetsApply_Remark,Stat) VALUES (@AssetsApply_Code,@AssetsApply_AppPerson,@AssetsApply_AppDept,@AssetsApply_AppName,@AssetsApply_Parameter,@AssetsApply_Description,@AssetsApply_AppCount,@AssetsApply_Type,@AssetsApply_AppType,@AssetsApply_Date,@AssetsApply_AudistStat,@AssetsApply_Stat,@AssetsApply_Remark,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Code))
         {
            idb.AddParameter("@AssetsApply_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Code", assets_Apply.AssetsApply_Code);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppPerson))
         {
            idb.AddParameter("@AssetsApply_AppPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppPerson", assets_Apply.AssetsApply_AppPerson);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppDept))
         {
            idb.AddParameter("@AssetsApply_AppDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppDept", assets_Apply.AssetsApply_AppDept);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppName))
         {
            idb.AddParameter("@AssetsApply_AppName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppName", assets_Apply.AssetsApply_AppName);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Parameter))
         {
            idb.AddParameter("@AssetsApply_Parameter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Parameter", assets_Apply.AssetsApply_Parameter);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Description))
         {
            idb.AddParameter("@AssetsApply_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Description", assets_Apply.AssetsApply_Description);
         }
         if (assets_Apply.AssetsApply_AppCount == 0)
         {
            idb.AddParameter("@AssetsApply_AppCount", 0);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppCount", assets_Apply.AssetsApply_AppCount);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Type))
         {
            idb.AddParameter("@AssetsApply_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Type", assets_Apply.AssetsApply_Type);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppType))
         {
            idb.AddParameter("@AssetsApply_AppType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppType", assets_Apply.AssetsApply_AppType);
         }
         if (assets_Apply.AssetsApply_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AssetsApply_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Date", assets_Apply.AssetsApply_Date);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AudistStat))
         {
            idb.AddParameter("@AssetsApply_AudistStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AudistStat", assets_Apply.AssetsApply_AudistStat);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Stat))
         {
            idb.AddParameter("@AssetsApply_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Stat", assets_Apply.AssetsApply_Stat);
         }
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Remark))
         {
            idb.AddParameter("@AssetsApply_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Remark", assets_Apply.AssetsApply_Remark);
         }
         if (assets_Apply.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", assets_Apply.Stat);
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
      /// 更新Assets_Apply对象(即:一条记录
      /// </summary>
      public int Update(Assets_Apply assets_Apply)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Assets_Apply       SET ");
            if(assets_Apply.AssetsApply_Code_IsChanged){sbParameter.Append("AssetsApply_Code=@AssetsApply_Code, ");}
      if(assets_Apply.AssetsApply_AppPerson_IsChanged){sbParameter.Append("AssetsApply_AppPerson=@AssetsApply_AppPerson, ");}
      if(assets_Apply.AssetsApply_AppDept_IsChanged){sbParameter.Append("AssetsApply_AppDept=@AssetsApply_AppDept, ");}
      if(assets_Apply.AssetsApply_AppName_IsChanged){sbParameter.Append("AssetsApply_AppName=@AssetsApply_AppName, ");}
      if(assets_Apply.AssetsApply_Parameter_IsChanged){sbParameter.Append("AssetsApply_Parameter=@AssetsApply_Parameter, ");}
      if(assets_Apply.AssetsApply_Description_IsChanged){sbParameter.Append("AssetsApply_Description=@AssetsApply_Description, ");}
      if(assets_Apply.AssetsApply_AppCount_IsChanged){sbParameter.Append("AssetsApply_AppCount=@AssetsApply_AppCount, ");}
      if(assets_Apply.AssetsApply_Type_IsChanged){sbParameter.Append("AssetsApply_Type=@AssetsApply_Type, ");}
      if(assets_Apply.AssetsApply_AppType_IsChanged){sbParameter.Append("AssetsApply_AppType=@AssetsApply_AppType, ");}
      if(assets_Apply.AssetsApply_Date_IsChanged){sbParameter.Append("AssetsApply_Date=@AssetsApply_Date, ");}
      if(assets_Apply.AssetsApply_AudistStat_IsChanged){sbParameter.Append("AssetsApply_AudistStat=@AssetsApply_AudistStat, ");}
      if(assets_Apply.AssetsApply_Stat_IsChanged){sbParameter.Append("AssetsApply_Stat=@AssetsApply_Stat, ");}
      if(assets_Apply.AssetsApply_Remark_IsChanged){sbParameter.Append("AssetsApply_Remark=@AssetsApply_Remark, ");}
      if(assets_Apply.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AssetsApply_ID=@AssetsApply_ID; " );
      string sql=sb.ToString();
         if(assets_Apply.AssetsApply_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Code))
         {
            idb.AddParameter("@AssetsApply_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Code", assets_Apply.AssetsApply_Code);
         }
          }
         if(assets_Apply.AssetsApply_AppPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppPerson))
         {
            idb.AddParameter("@AssetsApply_AppPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppPerson", assets_Apply.AssetsApply_AppPerson);
         }
          }
         if(assets_Apply.AssetsApply_AppDept_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppDept))
         {
            idb.AddParameter("@AssetsApply_AppDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppDept", assets_Apply.AssetsApply_AppDept);
         }
          }
         if(assets_Apply.AssetsApply_AppName_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppName))
         {
            idb.AddParameter("@AssetsApply_AppName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppName", assets_Apply.AssetsApply_AppName);
         }
          }
         if(assets_Apply.AssetsApply_Parameter_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Parameter))
         {
            idb.AddParameter("@AssetsApply_Parameter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Parameter", assets_Apply.AssetsApply_Parameter);
         }
          }
         if(assets_Apply.AssetsApply_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Description))
         {
            idb.AddParameter("@AssetsApply_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Description", assets_Apply.AssetsApply_Description);
         }
          }
         if(assets_Apply.AssetsApply_AppCount_IsChanged)
         {
         if (assets_Apply.AssetsApply_AppCount == 0)
         {
            idb.AddParameter("@AssetsApply_AppCount", 0);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppCount", assets_Apply.AssetsApply_AppCount);
         }
          }
         if(assets_Apply.AssetsApply_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Type))
         {
            idb.AddParameter("@AssetsApply_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Type", assets_Apply.AssetsApply_Type);
         }
          }
         if(assets_Apply.AssetsApply_AppType_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AppType))
         {
            idb.AddParameter("@AssetsApply_AppType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AppType", assets_Apply.AssetsApply_AppType);
         }
          }
         if(assets_Apply.AssetsApply_Date_IsChanged)
         {
         if (assets_Apply.AssetsApply_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AssetsApply_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Date", assets_Apply.AssetsApply_Date);
         }
          }
         if(assets_Apply.AssetsApply_AudistStat_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_AudistStat))
         {
            idb.AddParameter("@AssetsApply_AudistStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_AudistStat", assets_Apply.AssetsApply_AudistStat);
         }
          }
         if(assets_Apply.AssetsApply_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Stat))
         {
            idb.AddParameter("@AssetsApply_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Stat", assets_Apply.AssetsApply_Stat);
         }
          }
         if(assets_Apply.AssetsApply_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Apply.AssetsApply_Remark))
         {
            idb.AddParameter("@AssetsApply_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AssetsApply_Remark", assets_Apply.AssetsApply_Remark);
         }
          }
         if(assets_Apply.Stat_IsChanged)
         {
         if (assets_Apply.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", assets_Apply.Stat);
         }
          }

         idb.AddParameter("@AssetsApply_ID", assets_Apply.AssetsApply_ID);

           
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
      /// 删除Assets_Apply对象(即:一条记录
      /// </summary>
      public int Delete(decimal assetsApply_ID)
      {
         string sql = "DELETE Assets_Apply WHERE 1=1  AND AssetsApply_ID=@AssetsApply_ID ";
         idb.AddParameter("@AssetsApply_ID", assetsApply_ID);

           
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
      /// 获取指定的Assets_Apply对象(即:一条记录
      /// </summary>
      public Assets_Apply GetByKey(decimal assetsApply_ID)
      {
         Assets_Apply assets_Apply = new Assets_Apply();
         string sql = "SELECT  AssetsApply_ID,AssetsApply_Code,AssetsApply_AppPerson,AssetsApply_AppDept,AssetsApply_AppName,AssetsApply_Parameter,AssetsApply_Description,AssetsApply_AppCount,AssetsApply_Type,AssetsApply_AppType,AssetsApply_Date,AssetsApply_AudistStat,AssetsApply_Stat,AssetsApply_Remark,Stat FROM Assets_Apply WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AssetsApply_ID=@AssetsApply_ID ";
         idb.AddParameter("@AssetsApply_ID", assetsApply_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AssetsApply_ID"] != DBNull.Value) assets_Apply.AssetsApply_ID = Convert.ToDecimal(dr["AssetsApply_ID"]);
            if (dr["AssetsApply_Code"] != DBNull.Value) assets_Apply.AssetsApply_Code = Convert.ToString(dr["AssetsApply_Code"]);
            if (dr["AssetsApply_AppPerson"] != DBNull.Value) assets_Apply.AssetsApply_AppPerson = Convert.ToString(dr["AssetsApply_AppPerson"]);
            if (dr["AssetsApply_AppDept"] != DBNull.Value) assets_Apply.AssetsApply_AppDept = Convert.ToString(dr["AssetsApply_AppDept"]);
            if (dr["AssetsApply_AppName"] != DBNull.Value) assets_Apply.AssetsApply_AppName = Convert.ToString(dr["AssetsApply_AppName"]);
            if (dr["AssetsApply_Parameter"] != DBNull.Value) assets_Apply.AssetsApply_Parameter = Convert.ToString(dr["AssetsApply_Parameter"]);
            if (dr["AssetsApply_Description"] != DBNull.Value) assets_Apply.AssetsApply_Description = Convert.ToString(dr["AssetsApply_Description"]);
            if (dr["AssetsApply_AppCount"] != DBNull.Value) assets_Apply.AssetsApply_AppCount = Convert.ToInt32(dr["AssetsApply_AppCount"]);
            if (dr["AssetsApply_Type"] != DBNull.Value) assets_Apply.AssetsApply_Type = Convert.ToString(dr["AssetsApply_Type"]);
            if (dr["AssetsApply_AppType"] != DBNull.Value) assets_Apply.AssetsApply_AppType = Convert.ToString(dr["AssetsApply_AppType"]);
            if (dr["AssetsApply_Date"] != DBNull.Value) assets_Apply.AssetsApply_Date = Convert.ToDateTime(dr["AssetsApply_Date"]);
            if (dr["AssetsApply_AudistStat"] != DBNull.Value) assets_Apply.AssetsApply_AudistStat = Convert.ToString(dr["AssetsApply_AudistStat"]);
            if (dr["AssetsApply_Stat"] != DBNull.Value) assets_Apply.AssetsApply_Stat = Convert.ToString(dr["AssetsApply_Stat"]);
            if (dr["AssetsApply_Remark"] != DBNull.Value) assets_Apply.AssetsApply_Remark = Convert.ToString(dr["AssetsApply_Remark"]);
            if (dr["Stat"] != DBNull.Value) assets_Apply.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return assets_Apply;
      }
      /// <summary>
      /// 获取指定的Assets_Apply对象集合
      /// </summary>
      public List<Assets_Apply> GetListByWhere(string strCondition)
      {
         List<Assets_Apply> ret = new List<Assets_Apply>();
         string sql = "SELECT  AssetsApply_ID,AssetsApply_Code,AssetsApply_AppPerson,AssetsApply_AppDept,AssetsApply_AppName,AssetsApply_Parameter,AssetsApply_Description,AssetsApply_AppCount,AssetsApply_Type,AssetsApply_AppType,AssetsApply_Date,AssetsApply_AudistStat,AssetsApply_Stat,AssetsApply_Remark,Stat FROM Assets_Apply WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Assets_Apply assets_Apply = new Assets_Apply();
            if (dr["AssetsApply_ID"] != DBNull.Value) assets_Apply.AssetsApply_ID = Convert.ToDecimal(dr["AssetsApply_ID"]);
            if (dr["AssetsApply_Code"] != DBNull.Value) assets_Apply.AssetsApply_Code = Convert.ToString(dr["AssetsApply_Code"]);
            if (dr["AssetsApply_AppPerson"] != DBNull.Value) assets_Apply.AssetsApply_AppPerson = Convert.ToString(dr["AssetsApply_AppPerson"]);
            if (dr["AssetsApply_AppDept"] != DBNull.Value) assets_Apply.AssetsApply_AppDept = Convert.ToString(dr["AssetsApply_AppDept"]);
            if (dr["AssetsApply_AppName"] != DBNull.Value) assets_Apply.AssetsApply_AppName = Convert.ToString(dr["AssetsApply_AppName"]);
            if (dr["AssetsApply_Parameter"] != DBNull.Value) assets_Apply.AssetsApply_Parameter = Convert.ToString(dr["AssetsApply_Parameter"]);
            if (dr["AssetsApply_Description"] != DBNull.Value) assets_Apply.AssetsApply_Description = Convert.ToString(dr["AssetsApply_Description"]);
            if (dr["AssetsApply_AppCount"] != DBNull.Value) assets_Apply.AssetsApply_AppCount = Convert.ToInt32(dr["AssetsApply_AppCount"]);
            if (dr["AssetsApply_Type"] != DBNull.Value) assets_Apply.AssetsApply_Type = Convert.ToString(dr["AssetsApply_Type"]);
            if (dr["AssetsApply_AppType"] != DBNull.Value) assets_Apply.AssetsApply_AppType = Convert.ToString(dr["AssetsApply_AppType"]);
            if (dr["AssetsApply_Date"] != DBNull.Value) assets_Apply.AssetsApply_Date = Convert.ToDateTime(dr["AssetsApply_Date"]);
            if (dr["AssetsApply_AudistStat"] != DBNull.Value) assets_Apply.AssetsApply_AudistStat = Convert.ToString(dr["AssetsApply_AudistStat"]);
            if (dr["AssetsApply_Stat"] != DBNull.Value) assets_Apply.AssetsApply_Stat = Convert.ToString(dr["AssetsApply_Stat"]);
            if (dr["AssetsApply_Remark"] != DBNull.Value) assets_Apply.AssetsApply_Remark = Convert.ToString(dr["AssetsApply_Remark"]);
            if (dr["Stat"] != DBNull.Value) assets_Apply.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(assets_Apply);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Assets_Apply对象(即:一条记录
      /// </summary>
      public List<Assets_Apply> GetAll()
      {
         List<Assets_Apply> ret = new List<Assets_Apply>();
         string sql = "SELECT  AssetsApply_ID,AssetsApply_Code,AssetsApply_AppPerson,AssetsApply_AppDept,AssetsApply_AppName,AssetsApply_Parameter,AssetsApply_Description,AssetsApply_AppCount,AssetsApply_Type,AssetsApply_AppType,AssetsApply_Date,AssetsApply_AudistStat,AssetsApply_Stat,AssetsApply_Remark,Stat FROM Assets_Apply where 1=1 AND ((Stat is null) or (Stat=0) ) order by AssetsApply_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Assets_Apply assets_Apply = new Assets_Apply();
            if (dr["AssetsApply_ID"] != DBNull.Value) assets_Apply.AssetsApply_ID = Convert.ToDecimal(dr["AssetsApply_ID"]);
            if (dr["AssetsApply_Code"] != DBNull.Value) assets_Apply.AssetsApply_Code = Convert.ToString(dr["AssetsApply_Code"]);
            if (dr["AssetsApply_AppPerson"] != DBNull.Value) assets_Apply.AssetsApply_AppPerson = Convert.ToString(dr["AssetsApply_AppPerson"]);
            if (dr["AssetsApply_AppDept"] != DBNull.Value) assets_Apply.AssetsApply_AppDept = Convert.ToString(dr["AssetsApply_AppDept"]);
            if (dr["AssetsApply_AppName"] != DBNull.Value) assets_Apply.AssetsApply_AppName = Convert.ToString(dr["AssetsApply_AppName"]);
            if (dr["AssetsApply_Parameter"] != DBNull.Value) assets_Apply.AssetsApply_Parameter = Convert.ToString(dr["AssetsApply_Parameter"]);
            if (dr["AssetsApply_Description"] != DBNull.Value) assets_Apply.AssetsApply_Description = Convert.ToString(dr["AssetsApply_Description"]);
            if (dr["AssetsApply_AppCount"] != DBNull.Value) assets_Apply.AssetsApply_AppCount = Convert.ToInt32(dr["AssetsApply_AppCount"]);
            if (dr["AssetsApply_Type"] != DBNull.Value) assets_Apply.AssetsApply_Type = Convert.ToString(dr["AssetsApply_Type"]);
            if (dr["AssetsApply_AppType"] != DBNull.Value) assets_Apply.AssetsApply_AppType = Convert.ToString(dr["AssetsApply_AppType"]);
            if (dr["AssetsApply_Date"] != DBNull.Value) assets_Apply.AssetsApply_Date = Convert.ToDateTime(dr["AssetsApply_Date"]);
            if (dr["AssetsApply_AudistStat"] != DBNull.Value) assets_Apply.AssetsApply_AudistStat = Convert.ToString(dr["AssetsApply_AudistStat"]);
            if (dr["AssetsApply_Stat"] != DBNull.Value) assets_Apply.AssetsApply_Stat = Convert.ToString(dr["AssetsApply_Stat"]);
            if (dr["AssetsApply_Remark"] != DBNull.Value) assets_Apply.AssetsApply_Remark = Convert.ToString(dr["AssetsApply_Remark"]);
            if (dr["Stat"] != DBNull.Value) assets_Apply.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(assets_Apply);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
