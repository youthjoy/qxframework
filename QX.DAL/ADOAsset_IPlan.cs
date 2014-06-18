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
   /// 固定资产检修计划细表
   /// </summary>
   [Serializable]
   public partial class ADOAsset_IPlan
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加固定资产检修计划细表 Asset_IPlan对象(即:一条记录)
      /// </summary>
      public int Add(Asset_IPlan asset_IPlan)
      {
         string sql = "INSERT INTO Asset_IPlan (AIP_Code,AIP_MCode,AIP_FCode,AIP_FName,AIP_PDate,AIP_UCompany,AIP_UDepartment,AIP_UOwner,AIP_PExecute,AIP_PDepartment,Stat,CreateDate,UpdateDate,DeleteDate,AIP_Status,AIP_Bak) VALUES (@AIP_Code,@AIP_MCode,@AIP_FCode,@AIP_FName,@AIP_PDate,@AIP_UCompany,@AIP_UDepartment,@AIP_UOwner,@AIP_PExecute,@AIP_PDepartment,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AIP_Status,@AIP_Bak)";
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Code))
         {
            idb.AddParameter("@AIP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Code", asset_IPlan.AIP_Code);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_MCode))
         {
            idb.AddParameter("@AIP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_MCode", asset_IPlan.AIP_MCode);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_FCode))
         {
            idb.AddParameter("@AIP_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_FCode", asset_IPlan.AIP_FCode);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_FName))
         {
            idb.AddParameter("@AIP_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_FName", asset_IPlan.AIP_FName);
         }
         if (asset_IPlan.AIP_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@AIP_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PDate", asset_IPlan.AIP_PDate);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UCompany))
         {
            idb.AddParameter("@AIP_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UCompany", asset_IPlan.AIP_UCompany);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UDepartment))
         {
            idb.AddParameter("@AIP_UDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UDepartment", asset_IPlan.AIP_UDepartment);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UOwner))
         {
            idb.AddParameter("@AIP_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UOwner", asset_IPlan.AIP_UOwner);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_PExecute))
         {
            idb.AddParameter("@AIP_PExecute", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PExecute", asset_IPlan.AIP_PExecute);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_PDepartment))
         {
            idb.AddParameter("@AIP_PDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PDepartment", asset_IPlan.AIP_PDepartment);
         }
         if (asset_IPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_IPlan.Stat);
         }
         if (asset_IPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_IPlan.CreateDate);
         }
         if (asset_IPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_IPlan.UpdateDate);
         }
         if (asset_IPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_IPlan.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Status))
         {
            idb.AddParameter("@AIP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Status", asset_IPlan.AIP_Status);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Bak))
         {
            idb.AddParameter("@AIP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Bak", asset_IPlan.AIP_Bak);
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
      /// 添加固定资产检修计划细表 Asset_IPlan对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Asset_IPlan asset_IPlan)
      {
         string sql = "INSERT INTO Asset_IPlan (AIP_Code,AIP_MCode,AIP_FCode,AIP_FName,AIP_PDate,AIP_UCompany,AIP_UDepartment,AIP_UOwner,AIP_PExecute,AIP_PDepartment,Stat,CreateDate,UpdateDate,DeleteDate,AIP_Status,AIP_Bak) VALUES (@AIP_Code,@AIP_MCode,@AIP_FCode,@AIP_FName,@AIP_PDate,@AIP_UCompany,@AIP_UDepartment,@AIP_UOwner,@AIP_PExecute,@AIP_PDepartment,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AIP_Status,@AIP_Bak);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Code))
         {
            idb.AddParameter("@AIP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Code", asset_IPlan.AIP_Code);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_MCode))
         {
            idb.AddParameter("@AIP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_MCode", asset_IPlan.AIP_MCode);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_FCode))
         {
            idb.AddParameter("@AIP_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_FCode", asset_IPlan.AIP_FCode);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_FName))
         {
            idb.AddParameter("@AIP_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_FName", asset_IPlan.AIP_FName);
         }
         if (asset_IPlan.AIP_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@AIP_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PDate", asset_IPlan.AIP_PDate);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UCompany))
         {
            idb.AddParameter("@AIP_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UCompany", asset_IPlan.AIP_UCompany);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UDepartment))
         {
            idb.AddParameter("@AIP_UDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UDepartment", asset_IPlan.AIP_UDepartment);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UOwner))
         {
            idb.AddParameter("@AIP_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UOwner", asset_IPlan.AIP_UOwner);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_PExecute))
         {
            idb.AddParameter("@AIP_PExecute", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PExecute", asset_IPlan.AIP_PExecute);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_PDepartment))
         {
            idb.AddParameter("@AIP_PDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PDepartment", asset_IPlan.AIP_PDepartment);
         }
         if (asset_IPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_IPlan.Stat);
         }
         if (asset_IPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_IPlan.CreateDate);
         }
         if (asset_IPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_IPlan.UpdateDate);
         }
         if (asset_IPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_IPlan.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Status))
         {
            idb.AddParameter("@AIP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Status", asset_IPlan.AIP_Status);
         }
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Bak))
         {
            idb.AddParameter("@AIP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Bak", asset_IPlan.AIP_Bak);
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
      /// 更新固定资产检修计划细表 Asset_IPlan对象(即:一条记录
      /// </summary>
      public int Update(Asset_IPlan asset_IPlan)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Asset_IPlan       SET ");
            if(asset_IPlan.AIP_Code_IsChanged){sbParameter.Append("AIP_Code=@AIP_Code, ");}
      if(asset_IPlan.AIP_MCode_IsChanged){sbParameter.Append("AIP_MCode=@AIP_MCode, ");}
      if(asset_IPlan.AIP_FCode_IsChanged){sbParameter.Append("AIP_FCode=@AIP_FCode, ");}
      if(asset_IPlan.AIP_FName_IsChanged){sbParameter.Append("AIP_FName=@AIP_FName, ");}
      if(asset_IPlan.AIP_PDate_IsChanged){sbParameter.Append("AIP_PDate=@AIP_PDate, ");}
      if(asset_IPlan.AIP_UCompany_IsChanged){sbParameter.Append("AIP_UCompany=@AIP_UCompany, ");}
      if(asset_IPlan.AIP_UDepartment_IsChanged){sbParameter.Append("AIP_UDepartment=@AIP_UDepartment, ");}
      if(asset_IPlan.AIP_UOwner_IsChanged){sbParameter.Append("AIP_UOwner=@AIP_UOwner, ");}
      if(asset_IPlan.AIP_PExecute_IsChanged){sbParameter.Append("AIP_PExecute=@AIP_PExecute, ");}
      if(asset_IPlan.AIP_PDepartment_IsChanged){sbParameter.Append("AIP_PDepartment=@AIP_PDepartment, ");}
      if(asset_IPlan.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(asset_IPlan.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(asset_IPlan.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(asset_IPlan.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(asset_IPlan.AIP_Status_IsChanged){sbParameter.Append("AIP_Status=@AIP_Status, ");}
      if(asset_IPlan.AIP_Bak_IsChanged){sbParameter.Append("AIP_Bak=@AIP_Bak ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AIP_ID=@AIP_ID; " );
      string sql=sb.ToString();
         if(asset_IPlan.AIP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Code))
         {
            idb.AddParameter("@AIP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Code", asset_IPlan.AIP_Code);
         }
          }
         if(asset_IPlan.AIP_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_MCode))
         {
            idb.AddParameter("@AIP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_MCode", asset_IPlan.AIP_MCode);
         }
          }
         if(asset_IPlan.AIP_FCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_FCode))
         {
            idb.AddParameter("@AIP_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_FCode", asset_IPlan.AIP_FCode);
         }
          }
         if(asset_IPlan.AIP_FName_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_FName))
         {
            idb.AddParameter("@AIP_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_FName", asset_IPlan.AIP_FName);
         }
          }
         if(asset_IPlan.AIP_PDate_IsChanged)
         {
         if (asset_IPlan.AIP_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@AIP_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PDate", asset_IPlan.AIP_PDate);
         }
          }
         if(asset_IPlan.AIP_UCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UCompany))
         {
            idb.AddParameter("@AIP_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UCompany", asset_IPlan.AIP_UCompany);
         }
          }
         if(asset_IPlan.AIP_UDepartment_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UDepartment))
         {
            idb.AddParameter("@AIP_UDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UDepartment", asset_IPlan.AIP_UDepartment);
         }
          }
         if(asset_IPlan.AIP_UOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_UOwner))
         {
            idb.AddParameter("@AIP_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_UOwner", asset_IPlan.AIP_UOwner);
         }
          }
         if(asset_IPlan.AIP_PExecute_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_PExecute))
         {
            idb.AddParameter("@AIP_PExecute", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PExecute", asset_IPlan.AIP_PExecute);
         }
          }
         if(asset_IPlan.AIP_PDepartment_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_PDepartment))
         {
            idb.AddParameter("@AIP_PDepartment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_PDepartment", asset_IPlan.AIP_PDepartment);
         }
          }
         if(asset_IPlan.Stat_IsChanged)
         {
         if (asset_IPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_IPlan.Stat);
         }
          }
         if(asset_IPlan.CreateDate_IsChanged)
         {
         if (asset_IPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_IPlan.CreateDate);
         }
          }
         if(asset_IPlan.UpdateDate_IsChanged)
         {
         if (asset_IPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_IPlan.UpdateDate);
         }
          }
         if(asset_IPlan.DeleteDate_IsChanged)
         {
         if (asset_IPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_IPlan.DeleteDate);
         }
          }
         if(asset_IPlan.AIP_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Status))
         {
            idb.AddParameter("@AIP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Status", asset_IPlan.AIP_Status);
         }
          }
         if(asset_IPlan.AIP_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_IPlan.AIP_Bak))
         {
            idb.AddParameter("@AIP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AIP_Bak", asset_IPlan.AIP_Bak);
         }
          }

         idb.AddParameter("@AIP_ID", asset_IPlan.AIP_ID);

           
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
      /// 删除固定资产检修计划细表 Asset_IPlan对象(即:一条记录
      /// </summary>
      public int Delete(decimal aIP_ID)
      {
         string sql = "DELETE Asset_IPlan WHERE 1=1  AND AIP_ID=@AIP_ID ";
         idb.AddParameter("@AIP_ID", aIP_ID);

           
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
      /// 获取指定的固定资产检修计划细表 Asset_IPlan对象(即:一条记录
      /// </summary>
      public Asset_IPlan GetByKey(decimal aIP_ID)
      {
         Asset_IPlan asset_IPlan = new Asset_IPlan();
         string sql = "SELECT  AIP_ID,AIP_Code,AIP_MCode,AIP_FCode,AIP_FName,AIP_PDate,AIP_UCompany,AIP_UDepartment,AIP_UOwner,AIP_PExecute,AIP_PDepartment,Stat,CreateDate,UpdateDate,DeleteDate,AIP_Status,AIP_Bak FROM Asset_IPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AIP_ID=@AIP_ID ";
         idb.AddParameter("@AIP_ID", aIP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AIP_ID"] != DBNull.Value) asset_IPlan.AIP_ID = Convert.ToDecimal(dr["AIP_ID"]);
            if (dr["AIP_Code"] != DBNull.Value) asset_IPlan.AIP_Code = Convert.ToString(dr["AIP_Code"]);
            if (dr["AIP_MCode"] != DBNull.Value) asset_IPlan.AIP_MCode = Convert.ToString(dr["AIP_MCode"]);
            if (dr["AIP_FCode"] != DBNull.Value) asset_IPlan.AIP_FCode = Convert.ToString(dr["AIP_FCode"]);
            if (dr["AIP_FName"] != DBNull.Value) asset_IPlan.AIP_FName = Convert.ToString(dr["AIP_FName"]);
            if (dr["AIP_PDate"] != DBNull.Value) asset_IPlan.AIP_PDate = Convert.ToDateTime(dr["AIP_PDate"]);
            if (dr["AIP_UCompany"] != DBNull.Value) asset_IPlan.AIP_UCompany = Convert.ToString(dr["AIP_UCompany"]);
            if (dr["AIP_UDepartment"] != DBNull.Value) asset_IPlan.AIP_UDepartment = Convert.ToString(dr["AIP_UDepartment"]);
            if (dr["AIP_UOwner"] != DBNull.Value) asset_IPlan.AIP_UOwner = Convert.ToString(dr["AIP_UOwner"]);
            if (dr["AIP_PExecute"] != DBNull.Value) asset_IPlan.AIP_PExecute = Convert.ToString(dr["AIP_PExecute"]);
            if (dr["AIP_PDepartment"] != DBNull.Value) asset_IPlan.AIP_PDepartment = Convert.ToString(dr["AIP_PDepartment"]);
            if (dr["Stat"] != DBNull.Value) asset_IPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_IPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_IPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_IPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AIP_Status"] != DBNull.Value) asset_IPlan.AIP_Status = Convert.ToString(dr["AIP_Status"]);
            if (dr["AIP_Bak"] != DBNull.Value) asset_IPlan.AIP_Bak = Convert.ToString(dr["AIP_Bak"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return asset_IPlan;
      }
      /// <summary>
      /// 获取指定的固定资产检修计划细表 Asset_IPlan对象集合
      /// </summary>
      public List<Asset_IPlan> GetListByWhere(string strCondition)
      {
         List<Asset_IPlan> ret = new List<Asset_IPlan>();
         string sql = "SELECT  AIP_ID,AIP_Code,AIP_MCode,AIP_FCode,AIP_FName,AIP_PDate,AIP_UCompany,AIP_UDepartment,AIP_UOwner,AIP_PExecute,AIP_PDepartment,Stat,CreateDate,UpdateDate,DeleteDate,AIP_Status,AIP_Bak FROM Asset_IPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Asset_IPlan asset_IPlan = new Asset_IPlan();
            if (dr["AIP_ID"] != DBNull.Value) asset_IPlan.AIP_ID = Convert.ToDecimal(dr["AIP_ID"]);
            if (dr["AIP_Code"] != DBNull.Value) asset_IPlan.AIP_Code = Convert.ToString(dr["AIP_Code"]);
            if (dr["AIP_MCode"] != DBNull.Value) asset_IPlan.AIP_MCode = Convert.ToString(dr["AIP_MCode"]);
            if (dr["AIP_FCode"] != DBNull.Value) asset_IPlan.AIP_FCode = Convert.ToString(dr["AIP_FCode"]);
            if (dr["AIP_FName"] != DBNull.Value) asset_IPlan.AIP_FName = Convert.ToString(dr["AIP_FName"]);
            if (dr["AIP_PDate"] != DBNull.Value) asset_IPlan.AIP_PDate = Convert.ToDateTime(dr["AIP_PDate"]);
            if (dr["AIP_UCompany"] != DBNull.Value) asset_IPlan.AIP_UCompany = Convert.ToString(dr["AIP_UCompany"]);
            if (dr["AIP_UDepartment"] != DBNull.Value) asset_IPlan.AIP_UDepartment = Convert.ToString(dr["AIP_UDepartment"]);
            if (dr["AIP_UOwner"] != DBNull.Value) asset_IPlan.AIP_UOwner = Convert.ToString(dr["AIP_UOwner"]);
            if (dr["AIP_PExecute"] != DBNull.Value) asset_IPlan.AIP_PExecute = Convert.ToString(dr["AIP_PExecute"]);
            if (dr["AIP_PDepartment"] != DBNull.Value) asset_IPlan.AIP_PDepartment = Convert.ToString(dr["AIP_PDepartment"]);
            if (dr["Stat"] != DBNull.Value) asset_IPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_IPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_IPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_IPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AIP_Status"] != DBNull.Value) asset_IPlan.AIP_Status = Convert.ToString(dr["AIP_Status"]);
            if (dr["AIP_Bak"] != DBNull.Value) asset_IPlan.AIP_Bak = Convert.ToString(dr["AIP_Bak"]);
            ret.Add(asset_IPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的固定资产检修计划细表 Asset_IPlan对象(即:一条记录
      /// </summary>
      public List<Asset_IPlan> GetAll()
      {
         List<Asset_IPlan> ret = new List<Asset_IPlan>();
         string sql = "SELECT  AIP_ID,AIP_Code,AIP_MCode,AIP_FCode,AIP_FName,AIP_PDate,AIP_UCompany,AIP_UDepartment,AIP_UOwner,AIP_PExecute,AIP_PDepartment,Stat,CreateDate,UpdateDate,DeleteDate,AIP_Status,AIP_Bak FROM Asset_IPlan where 1=1 AND ((Stat is null) or (Stat=0) ) order by AIP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Asset_IPlan asset_IPlan = new Asset_IPlan();
            if (dr["AIP_ID"] != DBNull.Value) asset_IPlan.AIP_ID = Convert.ToDecimal(dr["AIP_ID"]);
            if (dr["AIP_Code"] != DBNull.Value) asset_IPlan.AIP_Code = Convert.ToString(dr["AIP_Code"]);
            if (dr["AIP_MCode"] != DBNull.Value) asset_IPlan.AIP_MCode = Convert.ToString(dr["AIP_MCode"]);
            if (dr["AIP_FCode"] != DBNull.Value) asset_IPlan.AIP_FCode = Convert.ToString(dr["AIP_FCode"]);
            if (dr["AIP_FName"] != DBNull.Value) asset_IPlan.AIP_FName = Convert.ToString(dr["AIP_FName"]);
            if (dr["AIP_PDate"] != DBNull.Value) asset_IPlan.AIP_PDate = Convert.ToDateTime(dr["AIP_PDate"]);
            if (dr["AIP_UCompany"] != DBNull.Value) asset_IPlan.AIP_UCompany = Convert.ToString(dr["AIP_UCompany"]);
            if (dr["AIP_UDepartment"] != DBNull.Value) asset_IPlan.AIP_UDepartment = Convert.ToString(dr["AIP_UDepartment"]);
            if (dr["AIP_UOwner"] != DBNull.Value) asset_IPlan.AIP_UOwner = Convert.ToString(dr["AIP_UOwner"]);
            if (dr["AIP_PExecute"] != DBNull.Value) asset_IPlan.AIP_PExecute = Convert.ToString(dr["AIP_PExecute"]);
            if (dr["AIP_PDepartment"] != DBNull.Value) asset_IPlan.AIP_PDepartment = Convert.ToString(dr["AIP_PDepartment"]);
            if (dr["Stat"] != DBNull.Value) asset_IPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_IPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_IPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_IPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AIP_Status"] != DBNull.Value) asset_IPlan.AIP_Status = Convert.ToString(dr["AIP_Status"]);
            if (dr["AIP_Bak"] != DBNull.Value) asset_IPlan.AIP_Bak = Convert.ToString(dr["AIP_Bak"]);
            ret.Add(asset_IPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
