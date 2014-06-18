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
   /// 客户结算单
   /// </summary>
   [Serializable]
   public partial class ADOSD_Banlance
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加客户结算单 SD_Banlance对象(即:一条记录)
      /// </summary>
      public int Add(SD_Banlance sD_Banlance)
      {
         string sql = "INSERT INTO SD_Banlance (SDB_Code,SDB_CCode,SDB_CName,SDB_Date,SDB_COwner,SDB_CManager,SDB_SOwner,SDB_SManager,SDBI_Bak,SDB_Period,SDB_Last,SDB_Current,SDB_CurRecevie,SDB_Left,SDB_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDB_Status,SDB_Attach,SDB_broom) VALUES (@SDB_Code,@SDB_CCode,@SDB_CName,@SDB_Date,@SDB_COwner,@SDB_CManager,@SDB_SOwner,@SDB_SManager,@SDBI_Bak,@SDB_Period,@SDB_Last,@SDB_Current,@SDB_CurRecevie,@SDB_Left,@SDB_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDB_Status,@SDB_Attach,@SDB_broom)";
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Code))
         {
            idb.AddParameter("@SDB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Code", sD_Banlance.SDB_Code);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CCode))
         {
            idb.AddParameter("@SDB_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CCode", sD_Banlance.SDB_CCode);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CName))
         {
            idb.AddParameter("@SDB_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CName", sD_Banlance.SDB_CName);
         }
         if (sD_Banlance.SDB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Date", sD_Banlance.SDB_Date);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_COwner))
         {
            idb.AddParameter("@SDB_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_COwner", sD_Banlance.SDB_COwner);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CManager))
         {
            idb.AddParameter("@SDB_CManager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CManager", sD_Banlance.SDB_CManager);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_SOwner))
         {
            idb.AddParameter("@SDB_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_SOwner", sD_Banlance.SDB_SOwner);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_SManager))
         {
            idb.AddParameter("@SDB_SManager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_SManager", sD_Banlance.SDB_SManager);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDBI_Bak))
         {
            idb.AddParameter("@SDBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Bak", sD_Banlance.SDBI_Bak);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Period))
         {
            idb.AddParameter("@SDB_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Period", sD_Banlance.SDB_Period);
         }
         if (sD_Banlance.SDB_Last == 0)
         {
            idb.AddParameter("@SDB_Last", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Last", sD_Banlance.SDB_Last);
         }
         if (sD_Banlance.SDB_Current == 0)
         {
            idb.AddParameter("@SDB_Current", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Current", sD_Banlance.SDB_Current);
         }
         if (sD_Banlance.SDB_CurRecevie == 0)
         {
            idb.AddParameter("@SDB_CurRecevie", 0);
         }
         else
         {
            idb.AddParameter("@SDB_CurRecevie", sD_Banlance.SDB_CurRecevie);
         }
         if (sD_Banlance.SDB_Left == 0)
         {
            idb.AddParameter("@SDB_Left", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Left", sD_Banlance.SDB_Left);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_iType))
         {
            idb.AddParameter("@SDB_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_iType", sD_Banlance.SDB_iType);
         }
         if (sD_Banlance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Banlance.Stat);
         }
         if (sD_Banlance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Banlance.CreateDate);
         }
         if (sD_Banlance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Banlance.UpdateDate);
         }
         if (sD_Banlance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Banlance.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Status))
         {
            idb.AddParameter("@SDB_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Status", sD_Banlance.SDB_Status);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Attach))
         {
            idb.AddParameter("@SDB_Attach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Attach", sD_Banlance.SDB_Attach);
         }
         if (sD_Banlance.SDB_broom == 0)
         {
            idb.AddParameter("@SDB_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDB_broom", sD_Banlance.SDB_broom);
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
      /// 添加客户结算单 SD_Banlance对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Banlance sD_Banlance)
      {
         string sql = "INSERT INTO SD_Banlance (SDB_Code,SDB_CCode,SDB_CName,SDB_Date,SDB_COwner,SDB_CManager,SDB_SOwner,SDB_SManager,SDBI_Bak,SDB_Period,SDB_Last,SDB_Current,SDB_CurRecevie,SDB_Left,SDB_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDB_Status,SDB_Attach,SDB_broom) VALUES (@SDB_Code,@SDB_CCode,@SDB_CName,@SDB_Date,@SDB_COwner,@SDB_CManager,@SDB_SOwner,@SDB_SManager,@SDBI_Bak,@SDB_Period,@SDB_Last,@SDB_Current,@SDB_CurRecevie,@SDB_Left,@SDB_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDB_Status,@SDB_Attach,@SDB_broom);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Code))
         {
            idb.AddParameter("@SDB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Code", sD_Banlance.SDB_Code);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CCode))
         {
            idb.AddParameter("@SDB_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CCode", sD_Banlance.SDB_CCode);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CName))
         {
            idb.AddParameter("@SDB_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CName", sD_Banlance.SDB_CName);
         }
         if (sD_Banlance.SDB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Date", sD_Banlance.SDB_Date);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_COwner))
         {
            idb.AddParameter("@SDB_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_COwner", sD_Banlance.SDB_COwner);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CManager))
         {
            idb.AddParameter("@SDB_CManager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CManager", sD_Banlance.SDB_CManager);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_SOwner))
         {
            idb.AddParameter("@SDB_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_SOwner", sD_Banlance.SDB_SOwner);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_SManager))
         {
            idb.AddParameter("@SDB_SManager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_SManager", sD_Banlance.SDB_SManager);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDBI_Bak))
         {
            idb.AddParameter("@SDBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Bak", sD_Banlance.SDBI_Bak);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Period))
         {
            idb.AddParameter("@SDB_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Period", sD_Banlance.SDB_Period);
         }
         if (sD_Banlance.SDB_Last == 0)
         {
            idb.AddParameter("@SDB_Last", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Last", sD_Banlance.SDB_Last);
         }
         if (sD_Banlance.SDB_Current == 0)
         {
            idb.AddParameter("@SDB_Current", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Current", sD_Banlance.SDB_Current);
         }
         if (sD_Banlance.SDB_CurRecevie == 0)
         {
            idb.AddParameter("@SDB_CurRecevie", 0);
         }
         else
         {
            idb.AddParameter("@SDB_CurRecevie", sD_Banlance.SDB_CurRecevie);
         }
         if (sD_Banlance.SDB_Left == 0)
         {
            idb.AddParameter("@SDB_Left", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Left", sD_Banlance.SDB_Left);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_iType))
         {
            idb.AddParameter("@SDB_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_iType", sD_Banlance.SDB_iType);
         }
         if (sD_Banlance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Banlance.Stat);
         }
         if (sD_Banlance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Banlance.CreateDate);
         }
         if (sD_Banlance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Banlance.UpdateDate);
         }
         if (sD_Banlance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Banlance.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Status))
         {
            idb.AddParameter("@SDB_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Status", sD_Banlance.SDB_Status);
         }
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Attach))
         {
            idb.AddParameter("@SDB_Attach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Attach", sD_Banlance.SDB_Attach);
         }
         if (sD_Banlance.SDB_broom == 0)
         {
            idb.AddParameter("@SDB_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDB_broom", sD_Banlance.SDB_broom);
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
      /// 更新客户结算单 SD_Banlance对象(即:一条记录
      /// </summary>
      public int Update(SD_Banlance sD_Banlance)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Banlance       SET ");
            if(sD_Banlance.SDB_Code_IsChanged){sbParameter.Append("SDB_Code=@SDB_Code, ");}
      if(sD_Banlance.SDB_CCode_IsChanged){sbParameter.Append("SDB_CCode=@SDB_CCode, ");}
      if(sD_Banlance.SDB_CName_IsChanged){sbParameter.Append("SDB_CName=@SDB_CName, ");}
      if(sD_Banlance.SDB_Date_IsChanged){sbParameter.Append("SDB_Date=@SDB_Date, ");}
      if(sD_Banlance.SDB_COwner_IsChanged){sbParameter.Append("SDB_COwner=@SDB_COwner, ");}
      if(sD_Banlance.SDB_CManager_IsChanged){sbParameter.Append("SDB_CManager=@SDB_CManager, ");}
      if(sD_Banlance.SDB_SOwner_IsChanged){sbParameter.Append("SDB_SOwner=@SDB_SOwner, ");}
      if(sD_Banlance.SDB_SManager_IsChanged){sbParameter.Append("SDB_SManager=@SDB_SManager, ");}
      if(sD_Banlance.SDBI_Bak_IsChanged){sbParameter.Append("SDBI_Bak=@SDBI_Bak, ");}
      if(sD_Banlance.SDB_Period_IsChanged){sbParameter.Append("SDB_Period=@SDB_Period, ");}
      if(sD_Banlance.SDB_Last_IsChanged){sbParameter.Append("SDB_Last=@SDB_Last, ");}
      if(sD_Banlance.SDB_Current_IsChanged){sbParameter.Append("SDB_Current=@SDB_Current, ");}
      if(sD_Banlance.SDB_CurRecevie_IsChanged){sbParameter.Append("SDB_CurRecevie=@SDB_CurRecevie, ");}
      if(sD_Banlance.SDB_Left_IsChanged){sbParameter.Append("SDB_Left=@SDB_Left, ");}
      if(sD_Banlance.SDB_iType_IsChanged){sbParameter.Append("SDB_iType=@SDB_iType, ");}
      if(sD_Banlance.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Banlance.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_Banlance.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_Banlance.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_Banlance.SDB_Status_IsChanged){sbParameter.Append("SDB_Status=@SDB_Status, ");}
      if(sD_Banlance.SDB_Attach_IsChanged){sbParameter.Append("SDB_Attach=@SDB_Attach, ");}
      if(sD_Banlance.SDB_broom_IsChanged){sbParameter.Append("SDB_broom=@SDB_broom ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDB_ID=@SDB_ID; " );
      string sql=sb.ToString();
         if(sD_Banlance.SDB_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Code))
         {
            idb.AddParameter("@SDB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Code", sD_Banlance.SDB_Code);
         }
          }
         if(sD_Banlance.SDB_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CCode))
         {
            idb.AddParameter("@SDB_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CCode", sD_Banlance.SDB_CCode);
         }
          }
         if(sD_Banlance.SDB_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CName))
         {
            idb.AddParameter("@SDB_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CName", sD_Banlance.SDB_CName);
         }
          }
         if(sD_Banlance.SDB_Date_IsChanged)
         {
         if (sD_Banlance.SDB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Date", sD_Banlance.SDB_Date);
         }
          }
         if(sD_Banlance.SDB_COwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_COwner))
         {
            idb.AddParameter("@SDB_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_COwner", sD_Banlance.SDB_COwner);
         }
          }
         if(sD_Banlance.SDB_CManager_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_CManager))
         {
            idb.AddParameter("@SDB_CManager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_CManager", sD_Banlance.SDB_CManager);
         }
          }
         if(sD_Banlance.SDB_SOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_SOwner))
         {
            idb.AddParameter("@SDB_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_SOwner", sD_Banlance.SDB_SOwner);
         }
          }
         if(sD_Banlance.SDB_SManager_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_SManager))
         {
            idb.AddParameter("@SDB_SManager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_SManager", sD_Banlance.SDB_SManager);
         }
          }
         if(sD_Banlance.SDBI_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDBI_Bak))
         {
            idb.AddParameter("@SDBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Bak", sD_Banlance.SDBI_Bak);
         }
          }
         if(sD_Banlance.SDB_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Period))
         {
            idb.AddParameter("@SDB_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Period", sD_Banlance.SDB_Period);
         }
          }
         if(sD_Banlance.SDB_Last_IsChanged)
         {
         if (sD_Banlance.SDB_Last == 0)
         {
            idb.AddParameter("@SDB_Last", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Last", sD_Banlance.SDB_Last);
         }
          }
         if(sD_Banlance.SDB_Current_IsChanged)
         {
         if (sD_Banlance.SDB_Current == 0)
         {
            idb.AddParameter("@SDB_Current", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Current", sD_Banlance.SDB_Current);
         }
          }
         if(sD_Banlance.SDB_CurRecevie_IsChanged)
         {
         if (sD_Banlance.SDB_CurRecevie == 0)
         {
            idb.AddParameter("@SDB_CurRecevie", 0);
         }
         else
         {
            idb.AddParameter("@SDB_CurRecevie", sD_Banlance.SDB_CurRecevie);
         }
          }
         if(sD_Banlance.SDB_Left_IsChanged)
         {
         if (sD_Banlance.SDB_Left == 0)
         {
            idb.AddParameter("@SDB_Left", 0);
         }
         else
         {
            idb.AddParameter("@SDB_Left", sD_Banlance.SDB_Left);
         }
          }
         if(sD_Banlance.SDB_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_iType))
         {
            idb.AddParameter("@SDB_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_iType", sD_Banlance.SDB_iType);
         }
          }
         if(sD_Banlance.Stat_IsChanged)
         {
         if (sD_Banlance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Banlance.Stat);
         }
          }
         if(sD_Banlance.CreateDate_IsChanged)
         {
         if (sD_Banlance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Banlance.CreateDate);
         }
          }
         if(sD_Banlance.UpdateDate_IsChanged)
         {
         if (sD_Banlance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Banlance.UpdateDate);
         }
          }
         if(sD_Banlance.DeleteDate_IsChanged)
         {
         if (sD_Banlance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Banlance.DeleteDate);
         }
          }
         if(sD_Banlance.SDB_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Status))
         {
            idb.AddParameter("@SDB_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Status", sD_Banlance.SDB_Status);
         }
          }
         if(sD_Banlance.SDB_Attach_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Banlance.SDB_Attach))
         {
            idb.AddParameter("@SDB_Attach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDB_Attach", sD_Banlance.SDB_Attach);
         }
          }
         if(sD_Banlance.SDB_broom_IsChanged)
         {
         if (sD_Banlance.SDB_broom == 0)
         {
            idb.AddParameter("@SDB_broom", 0);
         }
         else
         {
            idb.AddParameter("@SDB_broom", sD_Banlance.SDB_broom);
         }
          }

         idb.AddParameter("@SDB_ID", sD_Banlance.SDB_ID);

           
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
      /// 删除客户结算单 SD_Banlance对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDB_ID)
      {
         string sql = "DELETE SD_Banlance WHERE 1=1  AND SDB_ID=@SDB_ID ";
         idb.AddParameter("@SDB_ID", sDB_ID);

           
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
      /// 获取指定的客户结算单 SD_Banlance对象(即:一条记录
      /// </summary>
      public SD_Banlance GetByKey(decimal sDB_ID)
      {
         SD_Banlance sD_Banlance = new SD_Banlance();
         string sql = "SELECT  SDB_ID,SDB_Code,SDB_CCode,SDB_CName,SDB_Date,SDB_COwner,SDB_CManager,SDB_SOwner,SDB_SManager,SDBI_Bak,SDB_Period,SDB_Last,SDB_Current,SDB_CurRecevie,SDB_Left,SDB_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDB_Status,SDB_Attach,SDB_broom FROM SD_Banlance WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDB_ID=@SDB_ID ";
         idb.AddParameter("@SDB_ID", sDB_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDB_ID"] != DBNull.Value) sD_Banlance.SDB_ID = Convert.ToDecimal(dr["SDB_ID"]);
            if (dr["SDB_Code"] != DBNull.Value) sD_Banlance.SDB_Code = Convert.ToString(dr["SDB_Code"]);
            if (dr["SDB_CCode"] != DBNull.Value) sD_Banlance.SDB_CCode = Convert.ToString(dr["SDB_CCode"]);
            if (dr["SDB_CName"] != DBNull.Value) sD_Banlance.SDB_CName = Convert.ToString(dr["SDB_CName"]);
            if (dr["SDB_Date"] != DBNull.Value) sD_Banlance.SDB_Date = Convert.ToDateTime(dr["SDB_Date"]);
            if (dr["SDB_COwner"] != DBNull.Value) sD_Banlance.SDB_COwner = Convert.ToString(dr["SDB_COwner"]);
            if (dr["SDB_CManager"] != DBNull.Value) sD_Banlance.SDB_CManager = Convert.ToString(dr["SDB_CManager"]);
            if (dr["SDB_SOwner"] != DBNull.Value) sD_Banlance.SDB_SOwner = Convert.ToString(dr["SDB_SOwner"]);
            if (dr["SDB_SManager"] != DBNull.Value) sD_Banlance.SDB_SManager = Convert.ToString(dr["SDB_SManager"]);
            if (dr["SDBI_Bak"] != DBNull.Value) sD_Banlance.SDBI_Bak = Convert.ToString(dr["SDBI_Bak"]);
            if (dr["SDB_Period"] != DBNull.Value) sD_Banlance.SDB_Period = Convert.ToString(dr["SDB_Period"]);
            if (dr["SDB_Last"] != DBNull.Value) sD_Banlance.SDB_Last = Convert.ToDecimal(dr["SDB_Last"]);
            if (dr["SDB_Current"] != DBNull.Value) sD_Banlance.SDB_Current = Convert.ToDecimal(dr["SDB_Current"]);
            if (dr["SDB_CurRecevie"] != DBNull.Value) sD_Banlance.SDB_CurRecevie = Convert.ToDecimal(dr["SDB_CurRecevie"]);
            if (dr["SDB_Left"] != DBNull.Value) sD_Banlance.SDB_Left = Convert.ToDecimal(dr["SDB_Left"]);
            if (dr["SDB_iType"] != DBNull.Value) sD_Banlance.SDB_iType = Convert.ToString(dr["SDB_iType"]);
            if (dr["Stat"] != DBNull.Value) sD_Banlance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Banlance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Banlance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Banlance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDB_Status"] != DBNull.Value) sD_Banlance.SDB_Status = Convert.ToString(dr["SDB_Status"]);
            if (dr["SDB_Attach"] != DBNull.Value) sD_Banlance.SDB_Attach = Convert.ToString(dr["SDB_Attach"]);
            if (dr["SDB_broom"] != DBNull.Value) sD_Banlance.SDB_broom = Convert.ToDecimal(dr["SDB_broom"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Banlance;
      }
      /// <summary>
      /// 获取指定的客户结算单 SD_Banlance对象集合
      /// </summary>
      public List<SD_Banlance> GetListByWhere(string strCondition)
      {
         List<SD_Banlance> ret = new List<SD_Banlance>();
         string sql = "SELECT  SDB_ID,SDB_Code,SDB_CCode,SDB_CName,SDB_Date,SDB_COwner,SDB_CManager,SDB_SOwner,SDB_SManager,SDBI_Bak,SDB_Period,SDB_Last,SDB_Current,SDB_CurRecevie,SDB_Left,SDB_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDB_Status,SDB_Attach,SDB_broom FROM SD_Banlance WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Banlance sD_Banlance = new SD_Banlance();
            if (dr["SDB_ID"] != DBNull.Value) sD_Banlance.SDB_ID = Convert.ToDecimal(dr["SDB_ID"]);
            if (dr["SDB_Code"] != DBNull.Value) sD_Banlance.SDB_Code = Convert.ToString(dr["SDB_Code"]);
            if (dr["SDB_CCode"] != DBNull.Value) sD_Banlance.SDB_CCode = Convert.ToString(dr["SDB_CCode"]);
            if (dr["SDB_CName"] != DBNull.Value) sD_Banlance.SDB_CName = Convert.ToString(dr["SDB_CName"]);
            if (dr["SDB_Date"] != DBNull.Value) sD_Banlance.SDB_Date = Convert.ToDateTime(dr["SDB_Date"]);
            if (dr["SDB_COwner"] != DBNull.Value) sD_Banlance.SDB_COwner = Convert.ToString(dr["SDB_COwner"]);
            if (dr["SDB_CManager"] != DBNull.Value) sD_Banlance.SDB_CManager = Convert.ToString(dr["SDB_CManager"]);
            if (dr["SDB_SOwner"] != DBNull.Value) sD_Banlance.SDB_SOwner = Convert.ToString(dr["SDB_SOwner"]);
            if (dr["SDB_SManager"] != DBNull.Value) sD_Banlance.SDB_SManager = Convert.ToString(dr["SDB_SManager"]);
            if (dr["SDBI_Bak"] != DBNull.Value) sD_Banlance.SDBI_Bak = Convert.ToString(dr["SDBI_Bak"]);
            if (dr["SDB_Period"] != DBNull.Value) sD_Banlance.SDB_Period = Convert.ToString(dr["SDB_Period"]);
            if (dr["SDB_Last"] != DBNull.Value) sD_Banlance.SDB_Last = Convert.ToDecimal(dr["SDB_Last"]);
            if (dr["SDB_Current"] != DBNull.Value) sD_Banlance.SDB_Current = Convert.ToDecimal(dr["SDB_Current"]);
            if (dr["SDB_CurRecevie"] != DBNull.Value) sD_Banlance.SDB_CurRecevie = Convert.ToDecimal(dr["SDB_CurRecevie"]);
            if (dr["SDB_Left"] != DBNull.Value) sD_Banlance.SDB_Left = Convert.ToDecimal(dr["SDB_Left"]);
            if (dr["SDB_iType"] != DBNull.Value) sD_Banlance.SDB_iType = Convert.ToString(dr["SDB_iType"]);
            if (dr["Stat"] != DBNull.Value) sD_Banlance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Banlance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Banlance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Banlance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDB_Status"] != DBNull.Value) sD_Banlance.SDB_Status = Convert.ToString(dr["SDB_Status"]);
            if (dr["SDB_Attach"] != DBNull.Value) sD_Banlance.SDB_Attach = Convert.ToString(dr["SDB_Attach"]);
            if (dr["SDB_broom"] != DBNull.Value) sD_Banlance.SDB_broom = Convert.ToDecimal(dr["SDB_broom"]);
            ret.Add(sD_Banlance);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的客户结算单 SD_Banlance对象(即:一条记录
      /// </summary>
      public List<SD_Banlance> GetAll()
      {
         List<SD_Banlance> ret = new List<SD_Banlance>();
         string sql = "SELECT  SDB_ID,SDB_Code,SDB_CCode,SDB_CName,SDB_Date,SDB_COwner,SDB_CManager,SDB_SOwner,SDB_SManager,SDBI_Bak,SDB_Period,SDB_Last,SDB_Current,SDB_CurRecevie,SDB_Left,SDB_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDB_Status,SDB_Attach,SDB_broom FROM SD_Banlance where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDB_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Banlance sD_Banlance = new SD_Banlance();
            if (dr["SDB_ID"] != DBNull.Value) sD_Banlance.SDB_ID = Convert.ToDecimal(dr["SDB_ID"]);
            if (dr["SDB_Code"] != DBNull.Value) sD_Banlance.SDB_Code = Convert.ToString(dr["SDB_Code"]);
            if (dr["SDB_CCode"] != DBNull.Value) sD_Banlance.SDB_CCode = Convert.ToString(dr["SDB_CCode"]);
            if (dr["SDB_CName"] != DBNull.Value) sD_Banlance.SDB_CName = Convert.ToString(dr["SDB_CName"]);
            if (dr["SDB_Date"] != DBNull.Value) sD_Banlance.SDB_Date = Convert.ToDateTime(dr["SDB_Date"]);
            if (dr["SDB_COwner"] != DBNull.Value) sD_Banlance.SDB_COwner = Convert.ToString(dr["SDB_COwner"]);
            if (dr["SDB_CManager"] != DBNull.Value) sD_Banlance.SDB_CManager = Convert.ToString(dr["SDB_CManager"]);
            if (dr["SDB_SOwner"] != DBNull.Value) sD_Banlance.SDB_SOwner = Convert.ToString(dr["SDB_SOwner"]);
            if (dr["SDB_SManager"] != DBNull.Value) sD_Banlance.SDB_SManager = Convert.ToString(dr["SDB_SManager"]);
            if (dr["SDBI_Bak"] != DBNull.Value) sD_Banlance.SDBI_Bak = Convert.ToString(dr["SDBI_Bak"]);
            if (dr["SDB_Period"] != DBNull.Value) sD_Banlance.SDB_Period = Convert.ToString(dr["SDB_Period"]);
            if (dr["SDB_Last"] != DBNull.Value) sD_Banlance.SDB_Last = Convert.ToDecimal(dr["SDB_Last"]);
            if (dr["SDB_Current"] != DBNull.Value) sD_Banlance.SDB_Current = Convert.ToDecimal(dr["SDB_Current"]);
            if (dr["SDB_CurRecevie"] != DBNull.Value) sD_Banlance.SDB_CurRecevie = Convert.ToDecimal(dr["SDB_CurRecevie"]);
            if (dr["SDB_Left"] != DBNull.Value) sD_Banlance.SDB_Left = Convert.ToDecimal(dr["SDB_Left"]);
            if (dr["SDB_iType"] != DBNull.Value) sD_Banlance.SDB_iType = Convert.ToString(dr["SDB_iType"]);
            if (dr["Stat"] != DBNull.Value) sD_Banlance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Banlance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Banlance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Banlance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDB_Status"] != DBNull.Value) sD_Banlance.SDB_Status = Convert.ToString(dr["SDB_Status"]);
            if (dr["SDB_Attach"] != DBNull.Value) sD_Banlance.SDB_Attach = Convert.ToString(dr["SDB_Attach"]);
            if (dr["SDB_broom"] != DBNull.Value) sD_Banlance.SDB_broom = Convert.ToDecimal(dr["SDB_broom"]);
            ret.Add(sD_Banlance);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
