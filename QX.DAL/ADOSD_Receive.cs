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
   /// 收款
   /// </summary>
   [Serializable]
   public partial class ADOSD_Receive
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加收款 SD_Receive对象(即:一条记录)
      /// </summary>
      public int Add(SD_Receive sD_Receive)
      {
         string sql = "INSERT INTO SD_Receive (SDPR_Code,SDPR_CCode,SDPR_CName,SDPR_Date,SDPR_SOwner,SDPR_Type,SDPR_Sum,SDPR_RefType,SDPR_RefCode,SDPR_FOwner,SDPR_FDate,SDPR_iType,SDPR_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDPR_Done,SDPR_LeftDone,SDPR_CompanyCode,SDPR_Company,SDPR_broom) VALUES (@SDPR_Code,@SDPR_CCode,@SDPR_CName,@SDPR_Date,@SDPR_SOwner,@SDPR_Type,@SDPR_Sum,@SDPR_RefType,@SDPR_RefCode,@SDPR_FOwner,@SDPR_FDate,@SDPR_iType,@SDPR_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDPR_Done,@SDPR_LeftDone,@SDPR_CompanyCode,@SDPR_Company,@SDPR_broom)";
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Code))
         {
            idb.AddParameter("@SDPR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Code", sD_Receive.SDPR_Code);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CCode))
         {
            idb.AddParameter("@SDPR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CCode", sD_Receive.SDPR_CCode);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CName))
         {
            idb.AddParameter("@SDPR_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CName", sD_Receive.SDPR_CName);
         }
         if (sD_Receive.SDPR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDPR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Date", sD_Receive.SDPR_Date);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_SOwner))
         {
            idb.AddParameter("@SDPR_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_SOwner", sD_Receive.SDPR_SOwner);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Type))
         {
            idb.AddParameter("@SDPR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Type", sD_Receive.SDPR_Type);
         }
         if (sD_Receive.SDPR_Sum == 0)
         {
            idb.AddParameter("@SDPR_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_Sum", sD_Receive.SDPR_Sum);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_RefType))
         {
            idb.AddParameter("@SDPR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_RefType", sD_Receive.SDPR_RefType);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_RefCode))
         {
            idb.AddParameter("@SDPR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_RefCode", sD_Receive.SDPR_RefCode);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_FOwner))
         {
            idb.AddParameter("@SDPR_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_FOwner", sD_Receive.SDPR_FOwner);
         }
         if (sD_Receive.SDPR_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@SDPR_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_FDate", sD_Receive.SDPR_FDate);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_iType))
         {
            idb.AddParameter("@SDPR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_iType", sD_Receive.SDPR_iType);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Bak))
         {
            idb.AddParameter("@SDPR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Bak", sD_Receive.SDPR_Bak);
         }
         if (sD_Receive.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Receive.Stat);
         }
         if (sD_Receive.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Receive.CreateDate);
         }
         if (sD_Receive.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Receive.UpdateDate);
         }
         if (sD_Receive.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Receive.DeleteDate);
         }
         if (sD_Receive.SDPR_Done == 0)
         {
            idb.AddParameter("@SDPR_Done", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_Done", sD_Receive.SDPR_Done);
         }
         if (sD_Receive.SDPR_LeftDone == 0)
         {
            idb.AddParameter("@SDPR_LeftDone", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_LeftDone", sD_Receive.SDPR_LeftDone);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CompanyCode))
         {
            idb.AddParameter("@SDPR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CompanyCode", sD_Receive.SDPR_CompanyCode);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Company))
         {
            idb.AddParameter("@SDPR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Company", sD_Receive.SDPR_Company);
         }
         if (sD_Receive.SDPR_broom == 0)
         {
            idb.AddParameter("@SDPR_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_broom", sD_Receive.SDPR_broom);
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
      /// 添加收款 SD_Receive对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Receive sD_Receive)
      {
         string sql = "INSERT INTO SD_Receive (SDPR_Code,SDPR_CCode,SDPR_CName,SDPR_Date,SDPR_SOwner,SDPR_Type,SDPR_Sum,SDPR_RefType,SDPR_RefCode,SDPR_FOwner,SDPR_FDate,SDPR_iType,SDPR_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDPR_Done,SDPR_LeftDone,SDPR_CompanyCode,SDPR_Company,SDPR_broom) VALUES (@SDPR_Code,@SDPR_CCode,@SDPR_CName,@SDPR_Date,@SDPR_SOwner,@SDPR_Type,@SDPR_Sum,@SDPR_RefType,@SDPR_RefCode,@SDPR_FOwner,@SDPR_FDate,@SDPR_iType,@SDPR_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDPR_Done,@SDPR_LeftDone,@SDPR_CompanyCode,@SDPR_Company,@SDPR_broom);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Code))
         {
            idb.AddParameter("@SDPR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Code", sD_Receive.SDPR_Code);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CCode))
         {
            idb.AddParameter("@SDPR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CCode", sD_Receive.SDPR_CCode);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CName))
         {
            idb.AddParameter("@SDPR_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CName", sD_Receive.SDPR_CName);
         }
         if (sD_Receive.SDPR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDPR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Date", sD_Receive.SDPR_Date);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_SOwner))
         {
            idb.AddParameter("@SDPR_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_SOwner", sD_Receive.SDPR_SOwner);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Type))
         {
            idb.AddParameter("@SDPR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Type", sD_Receive.SDPR_Type);
         }
         if (sD_Receive.SDPR_Sum == 0)
         {
            idb.AddParameter("@SDPR_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_Sum", sD_Receive.SDPR_Sum);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_RefType))
         {
            idb.AddParameter("@SDPR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_RefType", sD_Receive.SDPR_RefType);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_RefCode))
         {
            idb.AddParameter("@SDPR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_RefCode", sD_Receive.SDPR_RefCode);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_FOwner))
         {
            idb.AddParameter("@SDPR_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_FOwner", sD_Receive.SDPR_FOwner);
         }
         if (sD_Receive.SDPR_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@SDPR_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_FDate", sD_Receive.SDPR_FDate);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_iType))
         {
            idb.AddParameter("@SDPR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_iType", sD_Receive.SDPR_iType);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Bak))
         {
            idb.AddParameter("@SDPR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Bak", sD_Receive.SDPR_Bak);
         }
         if (sD_Receive.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Receive.Stat);
         }
         if (sD_Receive.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Receive.CreateDate);
         }
         if (sD_Receive.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Receive.UpdateDate);
         }
         if (sD_Receive.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Receive.DeleteDate);
         }
         if (sD_Receive.SDPR_Done == 0)
         {
            idb.AddParameter("@SDPR_Done", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_Done", sD_Receive.SDPR_Done);
         }
         if (sD_Receive.SDPR_LeftDone == 0)
         {
            idb.AddParameter("@SDPR_LeftDone", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_LeftDone", sD_Receive.SDPR_LeftDone);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CompanyCode))
         {
            idb.AddParameter("@SDPR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CompanyCode", sD_Receive.SDPR_CompanyCode);
         }
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Company))
         {
            idb.AddParameter("@SDPR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Company", sD_Receive.SDPR_Company);
         }
         if (sD_Receive.SDPR_broom == 0)
         {
            idb.AddParameter("@SDPR_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_broom", sD_Receive.SDPR_broom);
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
      /// 更新收款 SD_Receive对象(即:一条记录
      /// </summary>
      public int Update(SD_Receive sD_Receive)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Receive       SET ");
            if(sD_Receive.SDPR_Code_IsChanged){sbParameter.Append("SDPR_Code=@SDPR_Code, ");}
      if(sD_Receive.SDPR_CCode_IsChanged){sbParameter.Append("SDPR_CCode=@SDPR_CCode, ");}
      if(sD_Receive.SDPR_CName_IsChanged){sbParameter.Append("SDPR_CName=@SDPR_CName, ");}
      if(sD_Receive.SDPR_Date_IsChanged){sbParameter.Append("SDPR_Date=@SDPR_Date, ");}
      if(sD_Receive.SDPR_SOwner_IsChanged){sbParameter.Append("SDPR_SOwner=@SDPR_SOwner, ");}
      if(sD_Receive.SDPR_Type_IsChanged){sbParameter.Append("SDPR_Type=@SDPR_Type, ");}
      if(sD_Receive.SDPR_Sum_IsChanged){sbParameter.Append("SDPR_Sum=@SDPR_Sum, ");}
      if(sD_Receive.SDPR_RefType_IsChanged){sbParameter.Append("SDPR_RefType=@SDPR_RefType, ");}
      if(sD_Receive.SDPR_RefCode_IsChanged){sbParameter.Append("SDPR_RefCode=@SDPR_RefCode, ");}
      if(sD_Receive.SDPR_FOwner_IsChanged){sbParameter.Append("SDPR_FOwner=@SDPR_FOwner, ");}
      if(sD_Receive.SDPR_FDate_IsChanged){sbParameter.Append("SDPR_FDate=@SDPR_FDate, ");}
      if(sD_Receive.SDPR_iType_IsChanged){sbParameter.Append("SDPR_iType=@SDPR_iType, ");}
      if(sD_Receive.SDPR_Bak_IsChanged){sbParameter.Append("SDPR_Bak=@SDPR_Bak, ");}
      if(sD_Receive.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Receive.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_Receive.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_Receive.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_Receive.SDPR_Done_IsChanged){sbParameter.Append("SDPR_Done=@SDPR_Done, ");}
      if(sD_Receive.SDPR_LeftDone_IsChanged){sbParameter.Append("SDPR_LeftDone=@SDPR_LeftDone, ");}
      if(sD_Receive.SDPR_CompanyCode_IsChanged){sbParameter.Append("SDPR_CompanyCode=@SDPR_CompanyCode, ");}
      if(sD_Receive.SDPR_Company_IsChanged){sbParameter.Append("SDPR_Company=@SDPR_Company, ");}
      if(sD_Receive.SDPR_broom_IsChanged){sbParameter.Append("SDPR_broom=@SDPR_broom ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDPR_ID=@SDPR_ID; " );
      string sql=sb.ToString();
         if(sD_Receive.SDPR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Code))
         {
            idb.AddParameter("@SDPR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Code", sD_Receive.SDPR_Code);
         }
          }
         if(sD_Receive.SDPR_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CCode))
         {
            idb.AddParameter("@SDPR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CCode", sD_Receive.SDPR_CCode);
         }
          }
         if(sD_Receive.SDPR_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CName))
         {
            idb.AddParameter("@SDPR_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CName", sD_Receive.SDPR_CName);
         }
          }
         if(sD_Receive.SDPR_Date_IsChanged)
         {
         if (sD_Receive.SDPR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDPR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Date", sD_Receive.SDPR_Date);
         }
          }
         if(sD_Receive.SDPR_SOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_SOwner))
         {
            idb.AddParameter("@SDPR_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_SOwner", sD_Receive.SDPR_SOwner);
         }
          }
         if(sD_Receive.SDPR_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Type))
         {
            idb.AddParameter("@SDPR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Type", sD_Receive.SDPR_Type);
         }
          }
         if(sD_Receive.SDPR_Sum_IsChanged)
         {
         if (sD_Receive.SDPR_Sum == 0)
         {
            idb.AddParameter("@SDPR_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_Sum", sD_Receive.SDPR_Sum);
         }
          }
         if(sD_Receive.SDPR_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_RefType))
         {
            idb.AddParameter("@SDPR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_RefType", sD_Receive.SDPR_RefType);
         }
          }
         if(sD_Receive.SDPR_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_RefCode))
         {
            idb.AddParameter("@SDPR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_RefCode", sD_Receive.SDPR_RefCode);
         }
          }
         if(sD_Receive.SDPR_FOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_FOwner))
         {
            idb.AddParameter("@SDPR_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_FOwner", sD_Receive.SDPR_FOwner);
         }
          }
         if(sD_Receive.SDPR_FDate_IsChanged)
         {
         if (sD_Receive.SDPR_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@SDPR_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_FDate", sD_Receive.SDPR_FDate);
         }
          }
         if(sD_Receive.SDPR_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_iType))
         {
            idb.AddParameter("@SDPR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_iType", sD_Receive.SDPR_iType);
         }
          }
         if(sD_Receive.SDPR_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Bak))
         {
            idb.AddParameter("@SDPR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Bak", sD_Receive.SDPR_Bak);
         }
          }
         if(sD_Receive.Stat_IsChanged)
         {
         if (sD_Receive.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Receive.Stat);
         }
          }
         if(sD_Receive.CreateDate_IsChanged)
         {
         if (sD_Receive.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Receive.CreateDate);
         }
          }
         if(sD_Receive.UpdateDate_IsChanged)
         {
         if (sD_Receive.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Receive.UpdateDate);
         }
          }
         if(sD_Receive.DeleteDate_IsChanged)
         {
         if (sD_Receive.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Receive.DeleteDate);
         }
          }
         if(sD_Receive.SDPR_Done_IsChanged)
         {
         if (sD_Receive.SDPR_Done == 0)
         {
            idb.AddParameter("@SDPR_Done", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_Done", sD_Receive.SDPR_Done);
         }
          }
         if(sD_Receive.SDPR_LeftDone_IsChanged)
         {
         if (sD_Receive.SDPR_LeftDone == 0)
         {
            idb.AddParameter("@SDPR_LeftDone", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_LeftDone", sD_Receive.SDPR_LeftDone);
         }
          }
         if(sD_Receive.SDPR_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_CompanyCode))
         {
            idb.AddParameter("@SDPR_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_CompanyCode", sD_Receive.SDPR_CompanyCode);
         }
          }
         if(sD_Receive.SDPR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Receive.SDPR_Company))
         {
            idb.AddParameter("@SDPR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDPR_Company", sD_Receive.SDPR_Company);
         }
          }
         if(sD_Receive.SDPR_broom_IsChanged)
         {
         if (sD_Receive.SDPR_broom == 0)
         {
            idb.AddParameter("@SDPR_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDPR_broom", sD_Receive.SDPR_broom);
         }
          }

         idb.AddParameter("@SDPR_ID", sD_Receive.SDPR_ID);

           
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
      /// 删除收款 SD_Receive对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDPR_ID)
      {
         string sql = "DELETE SD_Receive WHERE 1=1  AND SDPR_ID=@SDPR_ID ";
         idb.AddParameter("@SDPR_ID", sDPR_ID);

           
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
      /// 获取指定的收款 SD_Receive对象(即:一条记录
      /// </summary>
      public SD_Receive GetByKey(decimal sDPR_ID)
      {
         SD_Receive sD_Receive = new SD_Receive();
         string sql = "SELECT  SDPR_ID,SDPR_Code,SDPR_CCode,SDPR_CName,SDPR_Date,SDPR_SOwner,SDPR_Type,SDPR_Sum,SDPR_RefType,SDPR_RefCode,SDPR_FOwner,SDPR_FDate,SDPR_iType,SDPR_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDPR_Done,SDPR_LeftDone,SDPR_CompanyCode,SDPR_Company,SDPR_broom FROM SD_Receive WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDPR_ID=@SDPR_ID ";
         idb.AddParameter("@SDPR_ID", sDPR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDPR_ID"] != DBNull.Value) sD_Receive.SDPR_ID = Convert.ToDecimal(dr["SDPR_ID"]);
            if (dr["SDPR_Code"] != DBNull.Value) sD_Receive.SDPR_Code = Convert.ToString(dr["SDPR_Code"]);
            if (dr["SDPR_CCode"] != DBNull.Value) sD_Receive.SDPR_CCode = Convert.ToString(dr["SDPR_CCode"]);
            if (dr["SDPR_CName"] != DBNull.Value) sD_Receive.SDPR_CName = Convert.ToString(dr["SDPR_CName"]);
            if (dr["SDPR_Date"] != DBNull.Value) sD_Receive.SDPR_Date = Convert.ToDateTime(dr["SDPR_Date"]);
            if (dr["SDPR_SOwner"] != DBNull.Value) sD_Receive.SDPR_SOwner = Convert.ToString(dr["SDPR_SOwner"]);
            if (dr["SDPR_Type"] != DBNull.Value) sD_Receive.SDPR_Type = Convert.ToString(dr["SDPR_Type"]);
            if (dr["SDPR_Sum"] != DBNull.Value) sD_Receive.SDPR_Sum = Convert.ToDecimal(dr["SDPR_Sum"]);
            if (dr["SDPR_RefType"] != DBNull.Value) sD_Receive.SDPR_RefType = Convert.ToString(dr["SDPR_RefType"]);
            if (dr["SDPR_RefCode"] != DBNull.Value) sD_Receive.SDPR_RefCode = Convert.ToString(dr["SDPR_RefCode"]);
            if (dr["SDPR_FOwner"] != DBNull.Value) sD_Receive.SDPR_FOwner = Convert.ToString(dr["SDPR_FOwner"]);
            if (dr["SDPR_FDate"] != DBNull.Value) sD_Receive.SDPR_FDate = Convert.ToDateTime(dr["SDPR_FDate"]);
            if (dr["SDPR_iType"] != DBNull.Value) sD_Receive.SDPR_iType = Convert.ToString(dr["SDPR_iType"]);
            if (dr["SDPR_Bak"] != DBNull.Value) sD_Receive.SDPR_Bak = Convert.ToString(dr["SDPR_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_Receive.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Receive.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Receive.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Receive.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDPR_Done"] != DBNull.Value) sD_Receive.SDPR_Done = Convert.ToDecimal(dr["SDPR_Done"]);
            if (dr["SDPR_LeftDone"] != DBNull.Value) sD_Receive.SDPR_LeftDone = Convert.ToDecimal(dr["SDPR_LeftDone"]);
            if (dr["SDPR_CompanyCode"] != DBNull.Value) sD_Receive.SDPR_CompanyCode = Convert.ToString(dr["SDPR_CompanyCode"]);
            if (dr["SDPR_Company"] != DBNull.Value) sD_Receive.SDPR_Company = Convert.ToString(dr["SDPR_Company"]);
            if (dr["SDPR_broom"] != DBNull.Value) sD_Receive.SDPR_broom = Convert.ToDecimal(dr["SDPR_broom"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Receive;
      }
      /// <summary>
      /// 获取指定的收款 SD_Receive对象集合
      /// </summary>
      public List<SD_Receive> GetListByWhere(string strCondition)
      {
         List<SD_Receive> ret = new List<SD_Receive>();
         string sql = "SELECT  SDPR_ID,SDPR_Code,SDPR_CCode,SDPR_CName,SDPR_Date,SDPR_SOwner,SDPR_Type,SDPR_Sum,SDPR_RefType,SDPR_RefCode,SDPR_FOwner,SDPR_FDate,SDPR_iType,SDPR_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDPR_Done,SDPR_LeftDone,SDPR_CompanyCode,SDPR_Company,SDPR_broom FROM SD_Receive WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Receive sD_Receive = new SD_Receive();
            if (dr["SDPR_ID"] != DBNull.Value) sD_Receive.SDPR_ID = Convert.ToDecimal(dr["SDPR_ID"]);
            if (dr["SDPR_Code"] != DBNull.Value) sD_Receive.SDPR_Code = Convert.ToString(dr["SDPR_Code"]);
            if (dr["SDPR_CCode"] != DBNull.Value) sD_Receive.SDPR_CCode = Convert.ToString(dr["SDPR_CCode"]);
            if (dr["SDPR_CName"] != DBNull.Value) sD_Receive.SDPR_CName = Convert.ToString(dr["SDPR_CName"]);
            if (dr["SDPR_Date"] != DBNull.Value) sD_Receive.SDPR_Date = Convert.ToDateTime(dr["SDPR_Date"]);
            if (dr["SDPR_SOwner"] != DBNull.Value) sD_Receive.SDPR_SOwner = Convert.ToString(dr["SDPR_SOwner"]);
            if (dr["SDPR_Type"] != DBNull.Value) sD_Receive.SDPR_Type = Convert.ToString(dr["SDPR_Type"]);
            if (dr["SDPR_Sum"] != DBNull.Value) sD_Receive.SDPR_Sum = Convert.ToDecimal(dr["SDPR_Sum"]);
            if (dr["SDPR_RefType"] != DBNull.Value) sD_Receive.SDPR_RefType = Convert.ToString(dr["SDPR_RefType"]);
            if (dr["SDPR_RefCode"] != DBNull.Value) sD_Receive.SDPR_RefCode = Convert.ToString(dr["SDPR_RefCode"]);
            if (dr["SDPR_FOwner"] != DBNull.Value) sD_Receive.SDPR_FOwner = Convert.ToString(dr["SDPR_FOwner"]);
            if (dr["SDPR_FDate"] != DBNull.Value) sD_Receive.SDPR_FDate = Convert.ToDateTime(dr["SDPR_FDate"]);
            if (dr["SDPR_iType"] != DBNull.Value) sD_Receive.SDPR_iType = Convert.ToString(dr["SDPR_iType"]);
            if (dr["SDPR_Bak"] != DBNull.Value) sD_Receive.SDPR_Bak = Convert.ToString(dr["SDPR_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_Receive.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Receive.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Receive.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Receive.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDPR_Done"] != DBNull.Value) sD_Receive.SDPR_Done = Convert.ToDecimal(dr["SDPR_Done"]);
            if (dr["SDPR_LeftDone"] != DBNull.Value) sD_Receive.SDPR_LeftDone = Convert.ToDecimal(dr["SDPR_LeftDone"]);
            if (dr["SDPR_CompanyCode"] != DBNull.Value) sD_Receive.SDPR_CompanyCode = Convert.ToString(dr["SDPR_CompanyCode"]);
            if (dr["SDPR_Company"] != DBNull.Value) sD_Receive.SDPR_Company = Convert.ToString(dr["SDPR_Company"]);
            if (dr["SDPR_broom"] != DBNull.Value) sD_Receive.SDPR_broom = Convert.ToDecimal(dr["SDPR_broom"]);
            ret.Add(sD_Receive);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的收款 SD_Receive对象(即:一条记录
      /// </summary>
      public List<SD_Receive> GetAll()
      {
         List<SD_Receive> ret = new List<SD_Receive>();
         string sql = "SELECT  SDPR_ID,SDPR_Code,SDPR_CCode,SDPR_CName,SDPR_Date,SDPR_SOwner,SDPR_Type,SDPR_Sum,SDPR_RefType,SDPR_RefCode,SDPR_FOwner,SDPR_FDate,SDPR_iType,SDPR_Bak,Stat,CreateDate,UpdateDate,DeleteDate,SDPR_Done,SDPR_LeftDone,SDPR_CompanyCode,SDPR_Company,SDPR_broom FROM SD_Receive where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDPR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Receive sD_Receive = new SD_Receive();
            if (dr["SDPR_ID"] != DBNull.Value) sD_Receive.SDPR_ID = Convert.ToDecimal(dr["SDPR_ID"]);
            if (dr["SDPR_Code"] != DBNull.Value) sD_Receive.SDPR_Code = Convert.ToString(dr["SDPR_Code"]);
            if (dr["SDPR_CCode"] != DBNull.Value) sD_Receive.SDPR_CCode = Convert.ToString(dr["SDPR_CCode"]);
            if (dr["SDPR_CName"] != DBNull.Value) sD_Receive.SDPR_CName = Convert.ToString(dr["SDPR_CName"]);
            if (dr["SDPR_Date"] != DBNull.Value) sD_Receive.SDPR_Date = Convert.ToDateTime(dr["SDPR_Date"]);
            if (dr["SDPR_SOwner"] != DBNull.Value) sD_Receive.SDPR_SOwner = Convert.ToString(dr["SDPR_SOwner"]);
            if (dr["SDPR_Type"] != DBNull.Value) sD_Receive.SDPR_Type = Convert.ToString(dr["SDPR_Type"]);
            if (dr["SDPR_Sum"] != DBNull.Value) sD_Receive.SDPR_Sum = Convert.ToDecimal(dr["SDPR_Sum"]);
            if (dr["SDPR_RefType"] != DBNull.Value) sD_Receive.SDPR_RefType = Convert.ToString(dr["SDPR_RefType"]);
            if (dr["SDPR_RefCode"] != DBNull.Value) sD_Receive.SDPR_RefCode = Convert.ToString(dr["SDPR_RefCode"]);
            if (dr["SDPR_FOwner"] != DBNull.Value) sD_Receive.SDPR_FOwner = Convert.ToString(dr["SDPR_FOwner"]);
            if (dr["SDPR_FDate"] != DBNull.Value) sD_Receive.SDPR_FDate = Convert.ToDateTime(dr["SDPR_FDate"]);
            if (dr["SDPR_iType"] != DBNull.Value) sD_Receive.SDPR_iType = Convert.ToString(dr["SDPR_iType"]);
            if (dr["SDPR_Bak"] != DBNull.Value) sD_Receive.SDPR_Bak = Convert.ToString(dr["SDPR_Bak"]);
            if (dr["Stat"] != DBNull.Value) sD_Receive.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Receive.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Receive.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Receive.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDPR_Done"] != DBNull.Value) sD_Receive.SDPR_Done = Convert.ToDecimal(dr["SDPR_Done"]);
            if (dr["SDPR_LeftDone"] != DBNull.Value) sD_Receive.SDPR_LeftDone = Convert.ToDecimal(dr["SDPR_LeftDone"]);
            if (dr["SDPR_CompanyCode"] != DBNull.Value) sD_Receive.SDPR_CompanyCode = Convert.ToString(dr["SDPR_CompanyCode"]);
            if (dr["SDPR_Company"] != DBNull.Value) sD_Receive.SDPR_Company = Convert.ToString(dr["SDPR_Company"]);
            if (dr["SDPR_broom"] != DBNull.Value) sD_Receive.SDPR_broom = Convert.ToDecimal(dr["SDPR_broom"]);
            ret.Add(sD_Receive);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
