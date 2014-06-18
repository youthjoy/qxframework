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
   /// 固定资产使用记录
   /// </summary>
   [Serializable]
   public partial class ADOAssets_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加固定资产使用记录 Assets_Record对象(即:一条记录)
      /// </summary>
      public int Add(Assets_Record assets_Record)
      {
         string sql = "INSERT INTO Assets_Record (ARecord_Type,ARecord_Code,ARecord_ACode,ARecord_UserCode,ARecord_User,ARecord_UseDeptCode,ARecord_UseDept,ARecord_UseCompanyCode,ARecord_UseCompany,ARecord_Usage,ARecord_BeginDate,ARecord_EndDate,ARecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate,ARecord_IsReturn,ARecord_RDate,ARecord_ROwnerName,ARecord_RBak,ARecord_ROwnerCode,ARecord_AName,ARecord_ASpec) VALUES (@ARecord_Type,@ARecord_Code,@ARecord_ACode,@ARecord_UserCode,@ARecord_User,@ARecord_UseDeptCode,@ARecord_UseDept,@ARecord_UseCompanyCode,@ARecord_UseCompany,@ARecord_Usage,@ARecord_BeginDate,@ARecord_EndDate,@ARecord_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@ARecord_IsReturn,@ARecord_RDate,@ARecord_ROwnerName,@ARecord_RBak,@ARecord_ROwnerCode,@ARecord_AName,@ARecord_ASpec)";
         if (string.IsNullOrEmpty(assets_Record.ARecord_Type))
         {
            idb.AddParameter("@ARecord_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Type", assets_Record.ARecord_Type);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_Code))
         {
            idb.AddParameter("@ARecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Code", assets_Record.ARecord_Code);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ACode))
         {
            idb.AddParameter("@ARecord_ACode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ACode", assets_Record.ARecord_ACode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UserCode))
         {
            idb.AddParameter("@ARecord_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UserCode", assets_Record.ARecord_UserCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_User))
         {
            idb.AddParameter("@ARecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_User", assets_Record.ARecord_User);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseDeptCode))
         {
            idb.AddParameter("@ARecord_UseDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseDeptCode", assets_Record.ARecord_UseDeptCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseDept))
         {
            idb.AddParameter("@ARecord_UseDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseDept", assets_Record.ARecord_UseDept);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseCompanyCode))
         {
            idb.AddParameter("@ARecord_UseCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseCompanyCode", assets_Record.ARecord_UseCompanyCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseCompany))
         {
            idb.AddParameter("@ARecord_UseCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseCompany", assets_Record.ARecord_UseCompany);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_Usage))
         {
            idb.AddParameter("@ARecord_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Usage", assets_Record.ARecord_Usage);
         }
         if (assets_Record.ARecord_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_BeginDate", assets_Record.ARecord_BeginDate);
         }
         if (assets_Record.ARecord_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_EndDate", assets_Record.ARecord_EndDate);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_Remark))
         {
            idb.AddParameter("@ARecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Remark", assets_Record.ARecord_Remark);
         }
         if (assets_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", assets_Record.Stat);
         }
         if (assets_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", assets_Record.CreateDate);
         }
         if (assets_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", assets_Record.UpdateDate);
         }
         if (assets_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", assets_Record.DeleteDate);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_IsReturn))
         {
            idb.AddParameter("@ARecord_IsReturn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_IsReturn", assets_Record.ARecord_IsReturn);
         }
         if (assets_Record.ARecord_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_RDate", assets_Record.ARecord_RDate);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ROwnerName))
         {
            idb.AddParameter("@ARecord_ROwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ROwnerName", assets_Record.ARecord_ROwnerName);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_RBak))
         {
            idb.AddParameter("@ARecord_RBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_RBak", assets_Record.ARecord_RBak);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ROwnerCode))
         {
            idb.AddParameter("@ARecord_ROwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ROwnerCode", assets_Record.ARecord_ROwnerCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_AName))
         {
            idb.AddParameter("@ARecord_AName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_AName", assets_Record.ARecord_AName);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ASpec))
         {
            idb.AddParameter("@ARecord_ASpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ASpec", assets_Record.ARecord_ASpec);
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
      /// 添加固定资产使用记录 Assets_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Assets_Record assets_Record)
      {
         string sql = "INSERT INTO Assets_Record (ARecord_Type,ARecord_Code,ARecord_ACode,ARecord_UserCode,ARecord_User,ARecord_UseDeptCode,ARecord_UseDept,ARecord_UseCompanyCode,ARecord_UseCompany,ARecord_Usage,ARecord_BeginDate,ARecord_EndDate,ARecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate,ARecord_IsReturn,ARecord_RDate,ARecord_ROwnerName,ARecord_RBak,ARecord_ROwnerCode,ARecord_AName,ARecord_ASpec) VALUES (@ARecord_Type,@ARecord_Code,@ARecord_ACode,@ARecord_UserCode,@ARecord_User,@ARecord_UseDeptCode,@ARecord_UseDept,@ARecord_UseCompanyCode,@ARecord_UseCompany,@ARecord_Usage,@ARecord_BeginDate,@ARecord_EndDate,@ARecord_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@ARecord_IsReturn,@ARecord_RDate,@ARecord_ROwnerName,@ARecord_RBak,@ARecord_ROwnerCode,@ARecord_AName,@ARecord_ASpec);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(assets_Record.ARecord_Type))
         {
            idb.AddParameter("@ARecord_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Type", assets_Record.ARecord_Type);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_Code))
         {
            idb.AddParameter("@ARecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Code", assets_Record.ARecord_Code);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ACode))
         {
            idb.AddParameter("@ARecord_ACode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ACode", assets_Record.ARecord_ACode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UserCode))
         {
            idb.AddParameter("@ARecord_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UserCode", assets_Record.ARecord_UserCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_User))
         {
            idb.AddParameter("@ARecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_User", assets_Record.ARecord_User);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseDeptCode))
         {
            idb.AddParameter("@ARecord_UseDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseDeptCode", assets_Record.ARecord_UseDeptCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseDept))
         {
            idb.AddParameter("@ARecord_UseDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseDept", assets_Record.ARecord_UseDept);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseCompanyCode))
         {
            idb.AddParameter("@ARecord_UseCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseCompanyCode", assets_Record.ARecord_UseCompanyCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseCompany))
         {
            idb.AddParameter("@ARecord_UseCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseCompany", assets_Record.ARecord_UseCompany);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_Usage))
         {
            idb.AddParameter("@ARecord_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Usage", assets_Record.ARecord_Usage);
         }
         if (assets_Record.ARecord_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_BeginDate", assets_Record.ARecord_BeginDate);
         }
         if (assets_Record.ARecord_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_EndDate", assets_Record.ARecord_EndDate);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_Remark))
         {
            idb.AddParameter("@ARecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Remark", assets_Record.ARecord_Remark);
         }
         if (assets_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", assets_Record.Stat);
         }
         if (assets_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", assets_Record.CreateDate);
         }
         if (assets_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", assets_Record.UpdateDate);
         }
         if (assets_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", assets_Record.DeleteDate);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_IsReturn))
         {
            idb.AddParameter("@ARecord_IsReturn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_IsReturn", assets_Record.ARecord_IsReturn);
         }
         if (assets_Record.ARecord_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_RDate", assets_Record.ARecord_RDate);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ROwnerName))
         {
            idb.AddParameter("@ARecord_ROwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ROwnerName", assets_Record.ARecord_ROwnerName);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_RBak))
         {
            idb.AddParameter("@ARecord_RBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_RBak", assets_Record.ARecord_RBak);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ROwnerCode))
         {
            idb.AddParameter("@ARecord_ROwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ROwnerCode", assets_Record.ARecord_ROwnerCode);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_AName))
         {
            idb.AddParameter("@ARecord_AName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_AName", assets_Record.ARecord_AName);
         }
         if (string.IsNullOrEmpty(assets_Record.ARecord_ASpec))
         {
            idb.AddParameter("@ARecord_ASpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ASpec", assets_Record.ARecord_ASpec);
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
      /// 更新固定资产使用记录 Assets_Record对象(即:一条记录
      /// </summary>
      public int Update(Assets_Record assets_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Assets_Record       SET ");
            if(assets_Record.ARecord_Type_IsChanged){sbParameter.Append("ARecord_Type=@ARecord_Type, ");}
      if(assets_Record.ARecord_Code_IsChanged){sbParameter.Append("ARecord_Code=@ARecord_Code, ");}
      if(assets_Record.ARecord_ACode_IsChanged){sbParameter.Append("ARecord_ACode=@ARecord_ACode, ");}
      if(assets_Record.ARecord_UserCode_IsChanged){sbParameter.Append("ARecord_UserCode=@ARecord_UserCode, ");}
      if(assets_Record.ARecord_User_IsChanged){sbParameter.Append("ARecord_User=@ARecord_User, ");}
      if(assets_Record.ARecord_UseDeptCode_IsChanged){sbParameter.Append("ARecord_UseDeptCode=@ARecord_UseDeptCode, ");}
      if(assets_Record.ARecord_UseDept_IsChanged){sbParameter.Append("ARecord_UseDept=@ARecord_UseDept, ");}
      if(assets_Record.ARecord_UseCompanyCode_IsChanged){sbParameter.Append("ARecord_UseCompanyCode=@ARecord_UseCompanyCode, ");}
      if(assets_Record.ARecord_UseCompany_IsChanged){sbParameter.Append("ARecord_UseCompany=@ARecord_UseCompany, ");}
      if(assets_Record.ARecord_Usage_IsChanged){sbParameter.Append("ARecord_Usage=@ARecord_Usage, ");}
      if(assets_Record.ARecord_BeginDate_IsChanged){sbParameter.Append("ARecord_BeginDate=@ARecord_BeginDate, ");}
      if(assets_Record.ARecord_EndDate_IsChanged){sbParameter.Append("ARecord_EndDate=@ARecord_EndDate, ");}
      if(assets_Record.ARecord_Remark_IsChanged){sbParameter.Append("ARecord_Remark=@ARecord_Remark, ");}
      if(assets_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(assets_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(assets_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(assets_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(assets_Record.ARecord_IsReturn_IsChanged){sbParameter.Append("ARecord_IsReturn=@ARecord_IsReturn, ");}
      if(assets_Record.ARecord_RDate_IsChanged){sbParameter.Append("ARecord_RDate=@ARecord_RDate, ");}
      if(assets_Record.ARecord_ROwnerName_IsChanged){sbParameter.Append("ARecord_ROwnerName=@ARecord_ROwnerName, ");}
      if(assets_Record.ARecord_RBak_IsChanged){sbParameter.Append("ARecord_RBak=@ARecord_RBak, ");}
      if(assets_Record.ARecord_ROwnerCode_IsChanged){sbParameter.Append("ARecord_ROwnerCode=@ARecord_ROwnerCode, ");}
      if(assets_Record.ARecord_AName_IsChanged){sbParameter.Append("ARecord_AName=@ARecord_AName, ");}
      if(assets_Record.ARecord_ASpec_IsChanged){sbParameter.Append("ARecord_ASpec=@ARecord_ASpec ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and ARecord_ID=@ARecord_ID; " );
      string sql=sb.ToString();
         if(assets_Record.ARecord_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_Type))
         {
            idb.AddParameter("@ARecord_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Type", assets_Record.ARecord_Type);
         }
          }
         if(assets_Record.ARecord_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_Code))
         {
            idb.AddParameter("@ARecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Code", assets_Record.ARecord_Code);
         }
          }
         if(assets_Record.ARecord_ACode_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_ACode))
         {
            idb.AddParameter("@ARecord_ACode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ACode", assets_Record.ARecord_ACode);
         }
          }
         if(assets_Record.ARecord_UserCode_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_UserCode))
         {
            idb.AddParameter("@ARecord_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UserCode", assets_Record.ARecord_UserCode);
         }
          }
         if(assets_Record.ARecord_User_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_User))
         {
            idb.AddParameter("@ARecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_User", assets_Record.ARecord_User);
         }
          }
         if(assets_Record.ARecord_UseDeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseDeptCode))
         {
            idb.AddParameter("@ARecord_UseDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseDeptCode", assets_Record.ARecord_UseDeptCode);
         }
          }
         if(assets_Record.ARecord_UseDept_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseDept))
         {
            idb.AddParameter("@ARecord_UseDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseDept", assets_Record.ARecord_UseDept);
         }
          }
         if(assets_Record.ARecord_UseCompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseCompanyCode))
         {
            idb.AddParameter("@ARecord_UseCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseCompanyCode", assets_Record.ARecord_UseCompanyCode);
         }
          }
         if(assets_Record.ARecord_UseCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_UseCompany))
         {
            idb.AddParameter("@ARecord_UseCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_UseCompany", assets_Record.ARecord_UseCompany);
         }
          }
         if(assets_Record.ARecord_Usage_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_Usage))
         {
            idb.AddParameter("@ARecord_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Usage", assets_Record.ARecord_Usage);
         }
          }
         if(assets_Record.ARecord_BeginDate_IsChanged)
         {
         if (assets_Record.ARecord_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_BeginDate", assets_Record.ARecord_BeginDate);
         }
          }
         if(assets_Record.ARecord_EndDate_IsChanged)
         {
         if (assets_Record.ARecord_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_EndDate", assets_Record.ARecord_EndDate);
         }
          }
         if(assets_Record.ARecord_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_Remark))
         {
            idb.AddParameter("@ARecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_Remark", assets_Record.ARecord_Remark);
         }
          }
         if(assets_Record.Stat_IsChanged)
         {
         if (assets_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", assets_Record.Stat);
         }
          }
         if(assets_Record.CreateDate_IsChanged)
         {
         if (assets_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", assets_Record.CreateDate);
         }
          }
         if(assets_Record.UpdateDate_IsChanged)
         {
         if (assets_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", assets_Record.UpdateDate);
         }
          }
         if(assets_Record.DeleteDate_IsChanged)
         {
         if (assets_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", assets_Record.DeleteDate);
         }
          }
         if(assets_Record.ARecord_IsReturn_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_IsReturn))
         {
            idb.AddParameter("@ARecord_IsReturn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_IsReturn", assets_Record.ARecord_IsReturn);
         }
          }
         if(assets_Record.ARecord_RDate_IsChanged)
         {
         if (assets_Record.ARecord_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@ARecord_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_RDate", assets_Record.ARecord_RDate);
         }
          }
         if(assets_Record.ARecord_ROwnerName_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_ROwnerName))
         {
            idb.AddParameter("@ARecord_ROwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ROwnerName", assets_Record.ARecord_ROwnerName);
         }
          }
         if(assets_Record.ARecord_RBak_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_RBak))
         {
            idb.AddParameter("@ARecord_RBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_RBak", assets_Record.ARecord_RBak);
         }
          }
         if(assets_Record.ARecord_ROwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_ROwnerCode))
         {
            idb.AddParameter("@ARecord_ROwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ROwnerCode", assets_Record.ARecord_ROwnerCode);
         }
          }
         if(assets_Record.ARecord_AName_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_AName))
         {
            idb.AddParameter("@ARecord_AName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_AName", assets_Record.ARecord_AName);
         }
          }
         if(assets_Record.ARecord_ASpec_IsChanged)
         {
         if (string.IsNullOrEmpty(assets_Record.ARecord_ASpec))
         {
            idb.AddParameter("@ARecord_ASpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@ARecord_ASpec", assets_Record.ARecord_ASpec);
         }
          }

         idb.AddParameter("@ARecord_ID", assets_Record.ARecord_ID);

           
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
      /// 删除固定资产使用记录 Assets_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal aRecord_ID)
      {
         string sql = "DELETE Assets_Record WHERE 1=1  AND ARecord_ID=@ARecord_ID ";
         idb.AddParameter("@ARecord_ID", aRecord_ID);

           
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
      /// 获取指定的固定资产使用记录 Assets_Record对象(即:一条记录
      /// </summary>
      public Assets_Record GetByKey(decimal aRecord_ID)
      {
         Assets_Record assets_Record = new Assets_Record();
         string sql = "SELECT  ARecord_ID,ARecord_Type,ARecord_Code,ARecord_ACode,ARecord_UserCode,ARecord_User,ARecord_UseDeptCode,ARecord_UseDept,ARecord_UseCompanyCode,ARecord_UseCompany,ARecord_Usage,ARecord_BeginDate,ARecord_EndDate,ARecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate,ARecord_IsReturn,ARecord_RDate,ARecord_ROwnerName,ARecord_RBak,ARecord_ROwnerCode,ARecord_AName,ARecord_ASpec FROM Assets_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND ARecord_ID=@ARecord_ID ";
         idb.AddParameter("@ARecord_ID", aRecord_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["ARecord_ID"] != DBNull.Value) assets_Record.ARecord_ID = Convert.ToDecimal(dr["ARecord_ID"]);
            if (dr["ARecord_Type"] != DBNull.Value) assets_Record.ARecord_Type = Convert.ToString(dr["ARecord_Type"]);
            if (dr["ARecord_Code"] != DBNull.Value) assets_Record.ARecord_Code = Convert.ToString(dr["ARecord_Code"]);
            if (dr["ARecord_ACode"] != DBNull.Value) assets_Record.ARecord_ACode = Convert.ToString(dr["ARecord_ACode"]);
            if (dr["ARecord_UserCode"] != DBNull.Value) assets_Record.ARecord_UserCode = Convert.ToString(dr["ARecord_UserCode"]);
            if (dr["ARecord_User"] != DBNull.Value) assets_Record.ARecord_User = Convert.ToString(dr["ARecord_User"]);
            if (dr["ARecord_UseDeptCode"] != DBNull.Value) assets_Record.ARecord_UseDeptCode = Convert.ToString(dr["ARecord_UseDeptCode"]);
            if (dr["ARecord_UseDept"] != DBNull.Value) assets_Record.ARecord_UseDept = Convert.ToString(dr["ARecord_UseDept"]);
            if (dr["ARecord_UseCompanyCode"] != DBNull.Value) assets_Record.ARecord_UseCompanyCode = Convert.ToString(dr["ARecord_UseCompanyCode"]);
            if (dr["ARecord_UseCompany"] != DBNull.Value) assets_Record.ARecord_UseCompany = Convert.ToString(dr["ARecord_UseCompany"]);
            if (dr["ARecord_Usage"] != DBNull.Value) assets_Record.ARecord_Usage = Convert.ToString(dr["ARecord_Usage"]);
            if (dr["ARecord_BeginDate"] != DBNull.Value) assets_Record.ARecord_BeginDate = Convert.ToDateTime(dr["ARecord_BeginDate"]);
            if (dr["ARecord_EndDate"] != DBNull.Value) assets_Record.ARecord_EndDate = Convert.ToDateTime(dr["ARecord_EndDate"]);
            if (dr["ARecord_Remark"] != DBNull.Value) assets_Record.ARecord_Remark = Convert.ToString(dr["ARecord_Remark"]);
            if (dr["Stat"] != DBNull.Value) assets_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) assets_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) assets_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) assets_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["ARecord_IsReturn"] != DBNull.Value) assets_Record.ARecord_IsReturn = Convert.ToString(dr["ARecord_IsReturn"]);
            if (dr["ARecord_RDate"] != DBNull.Value) assets_Record.ARecord_RDate = Convert.ToDateTime(dr["ARecord_RDate"]);
            if (dr["ARecord_ROwnerName"] != DBNull.Value) assets_Record.ARecord_ROwnerName = Convert.ToString(dr["ARecord_ROwnerName"]);
            if (dr["ARecord_RBak"] != DBNull.Value) assets_Record.ARecord_RBak = Convert.ToString(dr["ARecord_RBak"]);
            if (dr["ARecord_ROwnerCode"] != DBNull.Value) assets_Record.ARecord_ROwnerCode = Convert.ToString(dr["ARecord_ROwnerCode"]);
            if (dr["ARecord_AName"] != DBNull.Value) assets_Record.ARecord_AName = Convert.ToString(dr["ARecord_AName"]);
            if (dr["ARecord_ASpec"] != DBNull.Value) assets_Record.ARecord_ASpec = Convert.ToString(dr["ARecord_ASpec"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return assets_Record;
      }
      /// <summary>
      /// 获取指定的固定资产使用记录 Assets_Record对象集合
      /// </summary>
      public List<Assets_Record> GetListByWhere(string strCondition)
      {
         List<Assets_Record> ret = new List<Assets_Record>();
         string sql = "SELECT  ARecord_ID,ARecord_Type,ARecord_Code,ARecord_ACode,ARecord_UserCode,ARecord_User,ARecord_UseDeptCode,ARecord_UseDept,ARecord_UseCompanyCode,ARecord_UseCompany,ARecord_Usage,ARecord_BeginDate,ARecord_EndDate,ARecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate,ARecord_IsReturn,ARecord_RDate,ARecord_ROwnerName,ARecord_RBak,ARecord_ROwnerCode,ARecord_AName,ARecord_ASpec FROM Assets_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Assets_Record assets_Record = new Assets_Record();
            if (dr["ARecord_ID"] != DBNull.Value) assets_Record.ARecord_ID = Convert.ToDecimal(dr["ARecord_ID"]);
            if (dr["ARecord_Type"] != DBNull.Value) assets_Record.ARecord_Type = Convert.ToString(dr["ARecord_Type"]);
            if (dr["ARecord_Code"] != DBNull.Value) assets_Record.ARecord_Code = Convert.ToString(dr["ARecord_Code"]);
            if (dr["ARecord_ACode"] != DBNull.Value) assets_Record.ARecord_ACode = Convert.ToString(dr["ARecord_ACode"]);
            if (dr["ARecord_UserCode"] != DBNull.Value) assets_Record.ARecord_UserCode = Convert.ToString(dr["ARecord_UserCode"]);
            if (dr["ARecord_User"] != DBNull.Value) assets_Record.ARecord_User = Convert.ToString(dr["ARecord_User"]);
            if (dr["ARecord_UseDeptCode"] != DBNull.Value) assets_Record.ARecord_UseDeptCode = Convert.ToString(dr["ARecord_UseDeptCode"]);
            if (dr["ARecord_UseDept"] != DBNull.Value) assets_Record.ARecord_UseDept = Convert.ToString(dr["ARecord_UseDept"]);
            if (dr["ARecord_UseCompanyCode"] != DBNull.Value) assets_Record.ARecord_UseCompanyCode = Convert.ToString(dr["ARecord_UseCompanyCode"]);
            if (dr["ARecord_UseCompany"] != DBNull.Value) assets_Record.ARecord_UseCompany = Convert.ToString(dr["ARecord_UseCompany"]);
            if (dr["ARecord_Usage"] != DBNull.Value) assets_Record.ARecord_Usage = Convert.ToString(dr["ARecord_Usage"]);
            if (dr["ARecord_BeginDate"] != DBNull.Value) assets_Record.ARecord_BeginDate = Convert.ToDateTime(dr["ARecord_BeginDate"]);
            if (dr["ARecord_EndDate"] != DBNull.Value) assets_Record.ARecord_EndDate = Convert.ToDateTime(dr["ARecord_EndDate"]);
            if (dr["ARecord_Remark"] != DBNull.Value) assets_Record.ARecord_Remark = Convert.ToString(dr["ARecord_Remark"]);
            if (dr["Stat"] != DBNull.Value) assets_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) assets_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) assets_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) assets_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["ARecord_IsReturn"] != DBNull.Value) assets_Record.ARecord_IsReturn = Convert.ToString(dr["ARecord_IsReturn"]);
            if (dr["ARecord_RDate"] != DBNull.Value) assets_Record.ARecord_RDate = Convert.ToDateTime(dr["ARecord_RDate"]);
            if (dr["ARecord_ROwnerName"] != DBNull.Value) assets_Record.ARecord_ROwnerName = Convert.ToString(dr["ARecord_ROwnerName"]);
            if (dr["ARecord_RBak"] != DBNull.Value) assets_Record.ARecord_RBak = Convert.ToString(dr["ARecord_RBak"]);
            if (dr["ARecord_ROwnerCode"] != DBNull.Value) assets_Record.ARecord_ROwnerCode = Convert.ToString(dr["ARecord_ROwnerCode"]);
            if (dr["ARecord_AName"] != DBNull.Value) assets_Record.ARecord_AName = Convert.ToString(dr["ARecord_AName"]);
            if (dr["ARecord_ASpec"] != DBNull.Value) assets_Record.ARecord_ASpec = Convert.ToString(dr["ARecord_ASpec"]);
            ret.Add(assets_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的固定资产使用记录 Assets_Record对象(即:一条记录
      /// </summary>
      public List<Assets_Record> GetAll()
      {
         List<Assets_Record> ret = new List<Assets_Record>();
         string sql = "SELECT  ARecord_ID,ARecord_Type,ARecord_Code,ARecord_ACode,ARecord_UserCode,ARecord_User,ARecord_UseDeptCode,ARecord_UseDept,ARecord_UseCompanyCode,ARecord_UseCompany,ARecord_Usage,ARecord_BeginDate,ARecord_EndDate,ARecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate,ARecord_IsReturn,ARecord_RDate,ARecord_ROwnerName,ARecord_RBak,ARecord_ROwnerCode,ARecord_AName,ARecord_ASpec FROM Assets_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by ARecord_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Assets_Record assets_Record = new Assets_Record();
            if (dr["ARecord_ID"] != DBNull.Value) assets_Record.ARecord_ID = Convert.ToDecimal(dr["ARecord_ID"]);
            if (dr["ARecord_Type"] != DBNull.Value) assets_Record.ARecord_Type = Convert.ToString(dr["ARecord_Type"]);
            if (dr["ARecord_Code"] != DBNull.Value) assets_Record.ARecord_Code = Convert.ToString(dr["ARecord_Code"]);
            if (dr["ARecord_ACode"] != DBNull.Value) assets_Record.ARecord_ACode = Convert.ToString(dr["ARecord_ACode"]);
            if (dr["ARecord_UserCode"] != DBNull.Value) assets_Record.ARecord_UserCode = Convert.ToString(dr["ARecord_UserCode"]);
            if (dr["ARecord_User"] != DBNull.Value) assets_Record.ARecord_User = Convert.ToString(dr["ARecord_User"]);
            if (dr["ARecord_UseDeptCode"] != DBNull.Value) assets_Record.ARecord_UseDeptCode = Convert.ToString(dr["ARecord_UseDeptCode"]);
            if (dr["ARecord_UseDept"] != DBNull.Value) assets_Record.ARecord_UseDept = Convert.ToString(dr["ARecord_UseDept"]);
            if (dr["ARecord_UseCompanyCode"] != DBNull.Value) assets_Record.ARecord_UseCompanyCode = Convert.ToString(dr["ARecord_UseCompanyCode"]);
            if (dr["ARecord_UseCompany"] != DBNull.Value) assets_Record.ARecord_UseCompany = Convert.ToString(dr["ARecord_UseCompany"]);
            if (dr["ARecord_Usage"] != DBNull.Value) assets_Record.ARecord_Usage = Convert.ToString(dr["ARecord_Usage"]);
            if (dr["ARecord_BeginDate"] != DBNull.Value) assets_Record.ARecord_BeginDate = Convert.ToDateTime(dr["ARecord_BeginDate"]);
            if (dr["ARecord_EndDate"] != DBNull.Value) assets_Record.ARecord_EndDate = Convert.ToDateTime(dr["ARecord_EndDate"]);
            if (dr["ARecord_Remark"] != DBNull.Value) assets_Record.ARecord_Remark = Convert.ToString(dr["ARecord_Remark"]);
            if (dr["Stat"] != DBNull.Value) assets_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) assets_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) assets_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) assets_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["ARecord_IsReturn"] != DBNull.Value) assets_Record.ARecord_IsReturn = Convert.ToString(dr["ARecord_IsReturn"]);
            if (dr["ARecord_RDate"] != DBNull.Value) assets_Record.ARecord_RDate = Convert.ToDateTime(dr["ARecord_RDate"]);
            if (dr["ARecord_ROwnerName"] != DBNull.Value) assets_Record.ARecord_ROwnerName = Convert.ToString(dr["ARecord_ROwnerName"]);
            if (dr["ARecord_RBak"] != DBNull.Value) assets_Record.ARecord_RBak = Convert.ToString(dr["ARecord_RBak"]);
            if (dr["ARecord_ROwnerCode"] != DBNull.Value) assets_Record.ARecord_ROwnerCode = Convert.ToString(dr["ARecord_ROwnerCode"]);
            if (dr["ARecord_AName"] != DBNull.Value) assets_Record.ARecord_AName = Convert.ToString(dr["ARecord_AName"]);
            if (dr["ARecord_ASpec"] != DBNull.Value) assets_Record.ARecord_ASpec = Convert.ToString(dr["ARecord_ASpec"]);
            ret.Add(assets_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
