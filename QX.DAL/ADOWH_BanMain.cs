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
   /// 盘点管理
   /// </summary>
   [Serializable]
   public partial class ADOWH_BanMain
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加盘点管理 WH_BanMain对象(即:一条记录)
      /// </summary>
      public int Add(WH_BanMain wH_BanMain)
      {
         string sql = "INSERT INTO WH_BanMain (WHBM_Code,WHBM_Name,WHBM_WCode,WHBM_WName,WHBM_Company,WHBM_CompanyCode,WHBM_PDate,WHBM_RDate,WHBM_WOwner,WHBM_FOwner,WHBM_OOwner,WHBM_BType,WHBM_iBanCopy,WHBM_IsInput,WHBM_IsBanced,WHBM_IsDonw,WHBM_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WHBM_Code,@WHBM_Name,@WHBM_WCode,@WHBM_WName,@WHBM_Company,@WHBM_CompanyCode,@WHBM_PDate,@WHBM_RDate,@WHBM_WOwner,@WHBM_FOwner,@WHBM_OOwner,@WHBM_BType,@WHBM_iBanCopy,@WHBM_IsInput,@WHBM_IsBanced,@WHBM_IsDonw,@WHBM_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Code))
         {
            idb.AddParameter("@WHBM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Code", wH_BanMain.WHBM_Code);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Name))
         {
            idb.AddParameter("@WHBM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Name", wH_BanMain.WHBM_Name);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WCode))
         {
            idb.AddParameter("@WHBM_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WCode", wH_BanMain.WHBM_WCode);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WName))
         {
            idb.AddParameter("@WHBM_WName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WName", wH_BanMain.WHBM_WName);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Company))
         {
            idb.AddParameter("@WHBM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Company", wH_BanMain.WHBM_Company);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_CompanyCode))
         {
            idb.AddParameter("@WHBM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_CompanyCode", wH_BanMain.WHBM_CompanyCode);
         }
         if (wH_BanMain.WHBM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHBM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_PDate", wH_BanMain.WHBM_PDate);
         }
         if (wH_BanMain.WHBM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHBM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_RDate", wH_BanMain.WHBM_RDate);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WOwner))
         {
            idb.AddParameter("@WHBM_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WOwner", wH_BanMain.WHBM_WOwner);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_FOwner))
         {
            idb.AddParameter("@WHBM_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_FOwner", wH_BanMain.WHBM_FOwner);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_OOwner))
         {
            idb.AddParameter("@WHBM_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_OOwner", wH_BanMain.WHBM_OOwner);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_BType))
         {
            idb.AddParameter("@WHBM_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_BType", wH_BanMain.WHBM_BType);
         }
         if (wH_BanMain.WHBM_iBanCopy == 0)
         {
            idb.AddParameter("@WHBM_iBanCopy", 0);
         }
         else
         {
            idb.AddParameter("@WHBM_iBanCopy", wH_BanMain.WHBM_iBanCopy);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsInput))
         {
            idb.AddParameter("@WHBM_IsInput", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsInput", wH_BanMain.WHBM_IsInput);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsBanced))
         {
            idb.AddParameter("@WHBM_IsBanced", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsBanced", wH_BanMain.WHBM_IsBanced);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsDonw))
         {
            idb.AddParameter("@WHBM_IsDonw", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsDonw", wH_BanMain.WHBM_IsDonw);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Remark))
         {
            idb.AddParameter("@WHBM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Remark", wH_BanMain.WHBM_Remark);
         }
         if (wH_BanMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanMain.Stat);
         }
         if (wH_BanMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanMain.CreateDate);
         }
         if (wH_BanMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanMain.UpdateDate);
         }
         if (wH_BanMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanMain.DeleteDate);
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
      /// 添加盘点管理 WH_BanMain对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_BanMain wH_BanMain)
      {
         string sql = "INSERT INTO WH_BanMain (WHBM_Code,WHBM_Name,WHBM_WCode,WHBM_WName,WHBM_Company,WHBM_CompanyCode,WHBM_PDate,WHBM_RDate,WHBM_WOwner,WHBM_FOwner,WHBM_OOwner,WHBM_BType,WHBM_iBanCopy,WHBM_IsInput,WHBM_IsBanced,WHBM_IsDonw,WHBM_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WHBM_Code,@WHBM_Name,@WHBM_WCode,@WHBM_WName,@WHBM_Company,@WHBM_CompanyCode,@WHBM_PDate,@WHBM_RDate,@WHBM_WOwner,@WHBM_FOwner,@WHBM_OOwner,@WHBM_BType,@WHBM_iBanCopy,@WHBM_IsInput,@WHBM_IsBanced,@WHBM_IsDonw,@WHBM_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Code))
         {
            idb.AddParameter("@WHBM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Code", wH_BanMain.WHBM_Code);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Name))
         {
            idb.AddParameter("@WHBM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Name", wH_BanMain.WHBM_Name);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WCode))
         {
            idb.AddParameter("@WHBM_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WCode", wH_BanMain.WHBM_WCode);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WName))
         {
            idb.AddParameter("@WHBM_WName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WName", wH_BanMain.WHBM_WName);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Company))
         {
            idb.AddParameter("@WHBM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Company", wH_BanMain.WHBM_Company);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_CompanyCode))
         {
            idb.AddParameter("@WHBM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_CompanyCode", wH_BanMain.WHBM_CompanyCode);
         }
         if (wH_BanMain.WHBM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHBM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_PDate", wH_BanMain.WHBM_PDate);
         }
         if (wH_BanMain.WHBM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHBM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_RDate", wH_BanMain.WHBM_RDate);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WOwner))
         {
            idb.AddParameter("@WHBM_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WOwner", wH_BanMain.WHBM_WOwner);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_FOwner))
         {
            idb.AddParameter("@WHBM_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_FOwner", wH_BanMain.WHBM_FOwner);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_OOwner))
         {
            idb.AddParameter("@WHBM_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_OOwner", wH_BanMain.WHBM_OOwner);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_BType))
         {
            idb.AddParameter("@WHBM_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_BType", wH_BanMain.WHBM_BType);
         }
         if (wH_BanMain.WHBM_iBanCopy == 0)
         {
            idb.AddParameter("@WHBM_iBanCopy", 0);
         }
         else
         {
            idb.AddParameter("@WHBM_iBanCopy", wH_BanMain.WHBM_iBanCopy);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsInput))
         {
            idb.AddParameter("@WHBM_IsInput", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsInput", wH_BanMain.WHBM_IsInput);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsBanced))
         {
            idb.AddParameter("@WHBM_IsBanced", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsBanced", wH_BanMain.WHBM_IsBanced);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsDonw))
         {
            idb.AddParameter("@WHBM_IsDonw", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsDonw", wH_BanMain.WHBM_IsDonw);
         }
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Remark))
         {
            idb.AddParameter("@WHBM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Remark", wH_BanMain.WHBM_Remark);
         }
         if (wH_BanMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanMain.Stat);
         }
         if (wH_BanMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanMain.CreateDate);
         }
         if (wH_BanMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanMain.UpdateDate);
         }
         if (wH_BanMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanMain.DeleteDate);
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
      /// 更新盘点管理 WH_BanMain对象(即:一条记录
      /// </summary>
      public int Update(WH_BanMain wH_BanMain)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_BanMain       SET ");
            if(wH_BanMain.WHBM_Code_IsChanged){sbParameter.Append("WHBM_Code=@WHBM_Code, ");}
      if(wH_BanMain.WHBM_Name_IsChanged){sbParameter.Append("WHBM_Name=@WHBM_Name, ");}
      if(wH_BanMain.WHBM_WCode_IsChanged){sbParameter.Append("WHBM_WCode=@WHBM_WCode, ");}
      if(wH_BanMain.WHBM_WName_IsChanged){sbParameter.Append("WHBM_WName=@WHBM_WName, ");}
      if(wH_BanMain.WHBM_Company_IsChanged){sbParameter.Append("WHBM_Company=@WHBM_Company, ");}
      if(wH_BanMain.WHBM_CompanyCode_IsChanged){sbParameter.Append("WHBM_CompanyCode=@WHBM_CompanyCode, ");}
      if(wH_BanMain.WHBM_PDate_IsChanged){sbParameter.Append("WHBM_PDate=@WHBM_PDate, ");}
      if(wH_BanMain.WHBM_RDate_IsChanged){sbParameter.Append("WHBM_RDate=@WHBM_RDate, ");}
      if(wH_BanMain.WHBM_WOwner_IsChanged){sbParameter.Append("WHBM_WOwner=@WHBM_WOwner, ");}
      if(wH_BanMain.WHBM_FOwner_IsChanged){sbParameter.Append("WHBM_FOwner=@WHBM_FOwner, ");}
      if(wH_BanMain.WHBM_OOwner_IsChanged){sbParameter.Append("WHBM_OOwner=@WHBM_OOwner, ");}
      if(wH_BanMain.WHBM_BType_IsChanged){sbParameter.Append("WHBM_BType=@WHBM_BType, ");}
      if(wH_BanMain.WHBM_iBanCopy_IsChanged){sbParameter.Append("WHBM_iBanCopy=@WHBM_iBanCopy, ");}
      if(wH_BanMain.WHBM_IsInput_IsChanged){sbParameter.Append("WHBM_IsInput=@WHBM_IsInput, ");}
      if(wH_BanMain.WHBM_IsBanced_IsChanged){sbParameter.Append("WHBM_IsBanced=@WHBM_IsBanced, ");}
      if(wH_BanMain.WHBM_IsDonw_IsChanged){sbParameter.Append("WHBM_IsDonw=@WHBM_IsDonw, ");}
      if(wH_BanMain.WHBM_Remark_IsChanged){sbParameter.Append("WHBM_Remark=@WHBM_Remark, ");}
      if(wH_BanMain.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_BanMain.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_BanMain.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_BanMain.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHBM_ID=@WHBM_ID; " );
      string sql=sb.ToString();
         if(wH_BanMain.WHBM_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Code))
         {
            idb.AddParameter("@WHBM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Code", wH_BanMain.WHBM_Code);
         }
          }
         if(wH_BanMain.WHBM_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Name))
         {
            idb.AddParameter("@WHBM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Name", wH_BanMain.WHBM_Name);
         }
          }
         if(wH_BanMain.WHBM_WCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WCode))
         {
            idb.AddParameter("@WHBM_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WCode", wH_BanMain.WHBM_WCode);
         }
          }
         if(wH_BanMain.WHBM_WName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WName))
         {
            idb.AddParameter("@WHBM_WName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WName", wH_BanMain.WHBM_WName);
         }
          }
         if(wH_BanMain.WHBM_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Company))
         {
            idb.AddParameter("@WHBM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Company", wH_BanMain.WHBM_Company);
         }
          }
         if(wH_BanMain.WHBM_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_CompanyCode))
         {
            idb.AddParameter("@WHBM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_CompanyCode", wH_BanMain.WHBM_CompanyCode);
         }
          }
         if(wH_BanMain.WHBM_PDate_IsChanged)
         {
         if (wH_BanMain.WHBM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHBM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_PDate", wH_BanMain.WHBM_PDate);
         }
          }
         if(wH_BanMain.WHBM_RDate_IsChanged)
         {
         if (wH_BanMain.WHBM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHBM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_RDate", wH_BanMain.WHBM_RDate);
         }
          }
         if(wH_BanMain.WHBM_WOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_WOwner))
         {
            idb.AddParameter("@WHBM_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_WOwner", wH_BanMain.WHBM_WOwner);
         }
          }
         if(wH_BanMain.WHBM_FOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_FOwner))
         {
            idb.AddParameter("@WHBM_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_FOwner", wH_BanMain.WHBM_FOwner);
         }
          }
         if(wH_BanMain.WHBM_OOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_OOwner))
         {
            idb.AddParameter("@WHBM_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_OOwner", wH_BanMain.WHBM_OOwner);
         }
          }
         if(wH_BanMain.WHBM_BType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_BType))
         {
            idb.AddParameter("@WHBM_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_BType", wH_BanMain.WHBM_BType);
         }
          }
         if(wH_BanMain.WHBM_iBanCopy_IsChanged)
         {
         if (wH_BanMain.WHBM_iBanCopy == 0)
         {
            idb.AddParameter("@WHBM_iBanCopy", 0);
         }
         else
         {
            idb.AddParameter("@WHBM_iBanCopy", wH_BanMain.WHBM_iBanCopy);
         }
          }
         if(wH_BanMain.WHBM_IsInput_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsInput))
         {
            idb.AddParameter("@WHBM_IsInput", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsInput", wH_BanMain.WHBM_IsInput);
         }
          }
         if(wH_BanMain.WHBM_IsBanced_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsBanced))
         {
            idb.AddParameter("@WHBM_IsBanced", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsBanced", wH_BanMain.WHBM_IsBanced);
         }
          }
         if(wH_BanMain.WHBM_IsDonw_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_IsDonw))
         {
            idb.AddParameter("@WHBM_IsDonw", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_IsDonw", wH_BanMain.WHBM_IsDonw);
         }
          }
         if(wH_BanMain.WHBM_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanMain.WHBM_Remark))
         {
            idb.AddParameter("@WHBM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBM_Remark", wH_BanMain.WHBM_Remark);
         }
          }
         if(wH_BanMain.Stat_IsChanged)
         {
         if (wH_BanMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanMain.Stat);
         }
          }
         if(wH_BanMain.CreateDate_IsChanged)
         {
         if (wH_BanMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanMain.CreateDate);
         }
          }
         if(wH_BanMain.UpdateDate_IsChanged)
         {
         if (wH_BanMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanMain.UpdateDate);
         }
          }
         if(wH_BanMain.DeleteDate_IsChanged)
         {
         if (wH_BanMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanMain.DeleteDate);
         }
          }

         idb.AddParameter("@WHBM_ID", wH_BanMain.WHBM_ID);

           
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
      /// 删除盘点管理 WH_BanMain对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHBM_ID)
      {
         string sql = "DELETE WH_BanMain WHERE 1=1  AND WHBM_ID=@WHBM_ID ";
         idb.AddParameter("@WHBM_ID", wHBM_ID);

           
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
      /// 获取指定的盘点管理 WH_BanMain对象(即:一条记录
      /// </summary>
      public WH_BanMain GetByKey(decimal wHBM_ID)
      {
         WH_BanMain wH_BanMain = new WH_BanMain();
         string sql = "SELECT  WHBM_ID,WHBM_Code,WHBM_Name,WHBM_WCode,WHBM_WName,WHBM_Company,WHBM_CompanyCode,WHBM_PDate,WHBM_RDate,WHBM_WOwner,WHBM_FOwner,WHBM_OOwner,WHBM_BType,WHBM_iBanCopy,WHBM_IsInput,WHBM_IsBanced,WHBM_IsDonw,WHBM_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_BanMain WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHBM_ID=@WHBM_ID ";
         idb.AddParameter("@WHBM_ID", wHBM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHBM_ID"] != DBNull.Value) wH_BanMain.WHBM_ID = Convert.ToDecimal(dr["WHBM_ID"]);
            if (dr["WHBM_Code"] != DBNull.Value) wH_BanMain.WHBM_Code = Convert.ToString(dr["WHBM_Code"]);
            if (dr["WHBM_Name"] != DBNull.Value) wH_BanMain.WHBM_Name = Convert.ToString(dr["WHBM_Name"]);
            if (dr["WHBM_WCode"] != DBNull.Value) wH_BanMain.WHBM_WCode = Convert.ToString(dr["WHBM_WCode"]);
            if (dr["WHBM_WName"] != DBNull.Value) wH_BanMain.WHBM_WName = Convert.ToString(dr["WHBM_WName"]);
            if (dr["WHBM_Company"] != DBNull.Value) wH_BanMain.WHBM_Company = Convert.ToString(dr["WHBM_Company"]);
            if (dr["WHBM_CompanyCode"] != DBNull.Value) wH_BanMain.WHBM_CompanyCode = Convert.ToString(dr["WHBM_CompanyCode"]);
            if (dr["WHBM_PDate"] != DBNull.Value) wH_BanMain.WHBM_PDate = Convert.ToDateTime(dr["WHBM_PDate"]);
            if (dr["WHBM_RDate"] != DBNull.Value) wH_BanMain.WHBM_RDate = Convert.ToDateTime(dr["WHBM_RDate"]);
            if (dr["WHBM_WOwner"] != DBNull.Value) wH_BanMain.WHBM_WOwner = Convert.ToString(dr["WHBM_WOwner"]);
            if (dr["WHBM_FOwner"] != DBNull.Value) wH_BanMain.WHBM_FOwner = Convert.ToString(dr["WHBM_FOwner"]);
            if (dr["WHBM_OOwner"] != DBNull.Value) wH_BanMain.WHBM_OOwner = Convert.ToString(dr["WHBM_OOwner"]);
            if (dr["WHBM_BType"] != DBNull.Value) wH_BanMain.WHBM_BType = Convert.ToString(dr["WHBM_BType"]);
            if (dr["WHBM_iBanCopy"] != DBNull.Value) wH_BanMain.WHBM_iBanCopy = Convert.ToInt32(dr["WHBM_iBanCopy"]);
            if (dr["WHBM_IsInput"] != DBNull.Value) wH_BanMain.WHBM_IsInput = Convert.ToString(dr["WHBM_IsInput"]);
            if (dr["WHBM_IsBanced"] != DBNull.Value) wH_BanMain.WHBM_IsBanced = Convert.ToString(dr["WHBM_IsBanced"]);
            if (dr["WHBM_IsDonw"] != DBNull.Value) wH_BanMain.WHBM_IsDonw = Convert.ToString(dr["WHBM_IsDonw"]);
            if (dr["WHBM_Remark"] != DBNull.Value) wH_BanMain.WHBM_Remark = Convert.ToString(dr["WHBM_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_BanMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_BanMain;
      }
      /// <summary>
      /// 获取指定的盘点管理 WH_BanMain对象集合
      /// </summary>
      public List<WH_BanMain> GetListByWhere(string strCondition)
      {
         List<WH_BanMain> ret = new List<WH_BanMain>();
         string sql = "SELECT  WHBM_ID,WHBM_Code,WHBM_Name,WHBM_WCode,WHBM_WName,WHBM_Company,WHBM_CompanyCode,WHBM_PDate,WHBM_RDate,WHBM_WOwner,WHBM_FOwner,WHBM_OOwner,WHBM_BType,WHBM_iBanCopy,WHBM_IsInput,WHBM_IsBanced,WHBM_IsDonw,WHBM_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_BanMain WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_BanMain wH_BanMain = new WH_BanMain();
            if (dr["WHBM_ID"] != DBNull.Value) wH_BanMain.WHBM_ID = Convert.ToDecimal(dr["WHBM_ID"]);
            if (dr["WHBM_Code"] != DBNull.Value) wH_BanMain.WHBM_Code = Convert.ToString(dr["WHBM_Code"]);
            if (dr["WHBM_Name"] != DBNull.Value) wH_BanMain.WHBM_Name = Convert.ToString(dr["WHBM_Name"]);
            if (dr["WHBM_WCode"] != DBNull.Value) wH_BanMain.WHBM_WCode = Convert.ToString(dr["WHBM_WCode"]);
            if (dr["WHBM_WName"] != DBNull.Value) wH_BanMain.WHBM_WName = Convert.ToString(dr["WHBM_WName"]);
            if (dr["WHBM_Company"] != DBNull.Value) wH_BanMain.WHBM_Company = Convert.ToString(dr["WHBM_Company"]);
            if (dr["WHBM_CompanyCode"] != DBNull.Value) wH_BanMain.WHBM_CompanyCode = Convert.ToString(dr["WHBM_CompanyCode"]);
            if (dr["WHBM_PDate"] != DBNull.Value) wH_BanMain.WHBM_PDate = Convert.ToDateTime(dr["WHBM_PDate"]);
            if (dr["WHBM_RDate"] != DBNull.Value) wH_BanMain.WHBM_RDate = Convert.ToDateTime(dr["WHBM_RDate"]);
            if (dr["WHBM_WOwner"] != DBNull.Value) wH_BanMain.WHBM_WOwner = Convert.ToString(dr["WHBM_WOwner"]);
            if (dr["WHBM_FOwner"] != DBNull.Value) wH_BanMain.WHBM_FOwner = Convert.ToString(dr["WHBM_FOwner"]);
            if (dr["WHBM_OOwner"] != DBNull.Value) wH_BanMain.WHBM_OOwner = Convert.ToString(dr["WHBM_OOwner"]);
            if (dr["WHBM_BType"] != DBNull.Value) wH_BanMain.WHBM_BType = Convert.ToString(dr["WHBM_BType"]);
            if (dr["WHBM_iBanCopy"] != DBNull.Value) wH_BanMain.WHBM_iBanCopy = Convert.ToInt32(dr["WHBM_iBanCopy"]);
            if (dr["WHBM_IsInput"] != DBNull.Value) wH_BanMain.WHBM_IsInput = Convert.ToString(dr["WHBM_IsInput"]);
            if (dr["WHBM_IsBanced"] != DBNull.Value) wH_BanMain.WHBM_IsBanced = Convert.ToString(dr["WHBM_IsBanced"]);
            if (dr["WHBM_IsDonw"] != DBNull.Value) wH_BanMain.WHBM_IsDonw = Convert.ToString(dr["WHBM_IsDonw"]);
            if (dr["WHBM_Remark"] != DBNull.Value) wH_BanMain.WHBM_Remark = Convert.ToString(dr["WHBM_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_BanMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_BanMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的盘点管理 WH_BanMain对象(即:一条记录
      /// </summary>
      public List<WH_BanMain> GetAll()
      {
         List<WH_BanMain> ret = new List<WH_BanMain>();
         string sql = "SELECT  WHBM_ID,WHBM_Code,WHBM_Name,WHBM_WCode,WHBM_WName,WHBM_Company,WHBM_CompanyCode,WHBM_PDate,WHBM_RDate,WHBM_WOwner,WHBM_FOwner,WHBM_OOwner,WHBM_BType,WHBM_iBanCopy,WHBM_IsInput,WHBM_IsBanced,WHBM_IsDonw,WHBM_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_BanMain where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHBM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_BanMain wH_BanMain = new WH_BanMain();
            if (dr["WHBM_ID"] != DBNull.Value) wH_BanMain.WHBM_ID = Convert.ToDecimal(dr["WHBM_ID"]);
            if (dr["WHBM_Code"] != DBNull.Value) wH_BanMain.WHBM_Code = Convert.ToString(dr["WHBM_Code"]);
            if (dr["WHBM_Name"] != DBNull.Value) wH_BanMain.WHBM_Name = Convert.ToString(dr["WHBM_Name"]);
            if (dr["WHBM_WCode"] != DBNull.Value) wH_BanMain.WHBM_WCode = Convert.ToString(dr["WHBM_WCode"]);
            if (dr["WHBM_WName"] != DBNull.Value) wH_BanMain.WHBM_WName = Convert.ToString(dr["WHBM_WName"]);
            if (dr["WHBM_Company"] != DBNull.Value) wH_BanMain.WHBM_Company = Convert.ToString(dr["WHBM_Company"]);
            if (dr["WHBM_CompanyCode"] != DBNull.Value) wH_BanMain.WHBM_CompanyCode = Convert.ToString(dr["WHBM_CompanyCode"]);
            if (dr["WHBM_PDate"] != DBNull.Value) wH_BanMain.WHBM_PDate = Convert.ToDateTime(dr["WHBM_PDate"]);
            if (dr["WHBM_RDate"] != DBNull.Value) wH_BanMain.WHBM_RDate = Convert.ToDateTime(dr["WHBM_RDate"]);
            if (dr["WHBM_WOwner"] != DBNull.Value) wH_BanMain.WHBM_WOwner = Convert.ToString(dr["WHBM_WOwner"]);
            if (dr["WHBM_FOwner"] != DBNull.Value) wH_BanMain.WHBM_FOwner = Convert.ToString(dr["WHBM_FOwner"]);
            if (dr["WHBM_OOwner"] != DBNull.Value) wH_BanMain.WHBM_OOwner = Convert.ToString(dr["WHBM_OOwner"]);
            if (dr["WHBM_BType"] != DBNull.Value) wH_BanMain.WHBM_BType = Convert.ToString(dr["WHBM_BType"]);
            if (dr["WHBM_iBanCopy"] != DBNull.Value) wH_BanMain.WHBM_iBanCopy = Convert.ToInt32(dr["WHBM_iBanCopy"]);
            if (dr["WHBM_IsInput"] != DBNull.Value) wH_BanMain.WHBM_IsInput = Convert.ToString(dr["WHBM_IsInput"]);
            if (dr["WHBM_IsBanced"] != DBNull.Value) wH_BanMain.WHBM_IsBanced = Convert.ToString(dr["WHBM_IsBanced"]);
            if (dr["WHBM_IsDonw"] != DBNull.Value) wH_BanMain.WHBM_IsDonw = Convert.ToString(dr["WHBM_IsDonw"]);
            if (dr["WHBM_Remark"] != DBNull.Value) wH_BanMain.WHBM_Remark = Convert.ToString(dr["WHBM_Remark"]);
            if (dr["Stat"] != DBNull.Value) wH_BanMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_BanMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
