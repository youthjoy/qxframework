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
   /// 原料检测记录
   /// </summary>
   [Serializable]
   public partial class ADOTC_RRecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加原料检测记录 TC_RRecord对象(即:一条记录)
      /// </summary>
      public int Add(TC_RRecord tC_RRecord)
      {
         string sql = "INSERT INTO TC_RRecord (TCRR_ID,TCRR_Code,TCRR_SName,TCRR_SCode,TCRR_MCode,TCRR_MName,TCRR_GDate,TCRR_TDate,TCRR_Bak,TCRR_TOwner,TCRR_TConclusion,TCRR_TStatus,TCRR_RefType,TCRR_RefCode,TCRR_Lev,TCRR_Num,TCRR_SDate,TCRR_SOwner,TCRR_Base,TCRR_Equ,TCRR_TCCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCRR_ID,@TCRR_Code,@TCRR_SName,@TCRR_SCode,@TCRR_MCode,@TCRR_MName,@TCRR_GDate,@TCRR_TDate,@TCRR_Bak,@TCRR_TOwner,@TCRR_TConclusion,@TCRR_TStatus,@TCRR_RefType,@TCRR_RefCode,@TCRR_Lev,@TCRR_Num,@TCRR_SDate,@TCRR_SOwner,@TCRR_Base,@TCRR_Equ,@TCRR_TCCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_ID))
         {
            idb.AddParameter("@TCRR_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_ID", tC_RRecord.TCRR_ID);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Code))
         {
            idb.AddParameter("@TCRR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Code", tC_RRecord.TCRR_Code);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SName))
         {
            idb.AddParameter("@TCRR_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SName", tC_RRecord.TCRR_SName);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SCode))
         {
            idb.AddParameter("@TCRR_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SCode", tC_RRecord.TCRR_SCode);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_MCode))
         {
            idb.AddParameter("@TCRR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_MCode", tC_RRecord.TCRR_MCode);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_MName))
         {
            idb.AddParameter("@TCRR_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_MName", tC_RRecord.TCRR_MName);
         }
         if (tC_RRecord.TCRR_GDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_GDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_GDate", tC_RRecord.TCRR_GDate);
         }
         if (tC_RRecord.TCRR_TDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_TDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TDate", tC_RRecord.TCRR_TDate);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Bak))
         {
            idb.AddParameter("@TCRR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Bak", tC_RRecord.TCRR_Bak);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TOwner))
         {
            idb.AddParameter("@TCRR_TOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TOwner", tC_RRecord.TCRR_TOwner);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TConclusion))
         {
            idb.AddParameter("@TCRR_TConclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TConclusion", tC_RRecord.TCRR_TConclusion);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TStatus))
         {
            idb.AddParameter("@TCRR_TStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TStatus", tC_RRecord.TCRR_TStatus);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_RefType))
         {
            idb.AddParameter("@TCRR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_RefType", tC_RRecord.TCRR_RefType);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_RefCode))
         {
            idb.AddParameter("@TCRR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_RefCode", tC_RRecord.TCRR_RefCode);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Lev))
         {
            idb.AddParameter("@TCRR_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Lev", tC_RRecord.TCRR_Lev);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Num))
         {
            idb.AddParameter("@TCRR_Num", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Num", tC_RRecord.TCRR_Num);
         }
         if (tC_RRecord.TCRR_SDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_SDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SDate", tC_RRecord.TCRR_SDate);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SOwner))
         {
            idb.AddParameter("@TCRR_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SOwner", tC_RRecord.TCRR_SOwner);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Base))
         {
            idb.AddParameter("@TCRR_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Base", tC_RRecord.TCRR_Base);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Equ))
         {
            idb.AddParameter("@TCRR_Equ", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Equ", tC_RRecord.TCRR_Equ);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TCCode))
         {
            idb.AddParameter("@TCRR_TCCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TCCode", tC_RRecord.TCRR_TCCode);
         }
         if (tC_RRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RRecord.Stat);
         }
         if (tC_RRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RRecord.CreateDate);
         }
         if (tC_RRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RRecord.UpdateDate);
         }
         if (tC_RRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RRecord.DeleteDate);
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
      /// 添加原料检测记录 TC_RRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_RRecord tC_RRecord)
      {
         string sql = "INSERT INTO TC_RRecord (TCRR_ID,TCRR_Code,TCRR_SName,TCRR_SCode,TCRR_MCode,TCRR_MName,TCRR_GDate,TCRR_TDate,TCRR_Bak,TCRR_TOwner,TCRR_TConclusion,TCRR_TStatus,TCRR_RefType,TCRR_RefCode,TCRR_Lev,TCRR_Num,TCRR_SDate,TCRR_SOwner,TCRR_Base,TCRR_Equ,TCRR_TCCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCRR_ID,@TCRR_Code,@TCRR_SName,@TCRR_SCode,@TCRR_MCode,@TCRR_MName,@TCRR_GDate,@TCRR_TDate,@TCRR_Bak,@TCRR_TOwner,@TCRR_TConclusion,@TCRR_TStatus,@TCRR_RefType,@TCRR_RefCode,@TCRR_Lev,@TCRR_Num,@TCRR_SDate,@TCRR_SOwner,@TCRR_Base,@TCRR_Equ,@TCRR_TCCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_ID))
         {
            idb.AddParameter("@TCRR_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_ID", tC_RRecord.TCRR_ID);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Code))
         {
            idb.AddParameter("@TCRR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Code", tC_RRecord.TCRR_Code);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SName))
         {
            idb.AddParameter("@TCRR_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SName", tC_RRecord.TCRR_SName);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SCode))
         {
            idb.AddParameter("@TCRR_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SCode", tC_RRecord.TCRR_SCode);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_MCode))
         {
            idb.AddParameter("@TCRR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_MCode", tC_RRecord.TCRR_MCode);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_MName))
         {
            idb.AddParameter("@TCRR_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_MName", tC_RRecord.TCRR_MName);
         }
         if (tC_RRecord.TCRR_GDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_GDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_GDate", tC_RRecord.TCRR_GDate);
         }
         if (tC_RRecord.TCRR_TDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_TDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TDate", tC_RRecord.TCRR_TDate);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Bak))
         {
            idb.AddParameter("@TCRR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Bak", tC_RRecord.TCRR_Bak);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TOwner))
         {
            idb.AddParameter("@TCRR_TOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TOwner", tC_RRecord.TCRR_TOwner);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TConclusion))
         {
            idb.AddParameter("@TCRR_TConclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TConclusion", tC_RRecord.TCRR_TConclusion);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TStatus))
         {
            idb.AddParameter("@TCRR_TStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TStatus", tC_RRecord.TCRR_TStatus);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_RefType))
         {
            idb.AddParameter("@TCRR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_RefType", tC_RRecord.TCRR_RefType);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_RefCode))
         {
            idb.AddParameter("@TCRR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_RefCode", tC_RRecord.TCRR_RefCode);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Lev))
         {
            idb.AddParameter("@TCRR_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Lev", tC_RRecord.TCRR_Lev);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Num))
         {
            idb.AddParameter("@TCRR_Num", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Num", tC_RRecord.TCRR_Num);
         }
         if (tC_RRecord.TCRR_SDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_SDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SDate", tC_RRecord.TCRR_SDate);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SOwner))
         {
            idb.AddParameter("@TCRR_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SOwner", tC_RRecord.TCRR_SOwner);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Base))
         {
            idb.AddParameter("@TCRR_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Base", tC_RRecord.TCRR_Base);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Equ))
         {
            idb.AddParameter("@TCRR_Equ", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Equ", tC_RRecord.TCRR_Equ);
         }
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TCCode))
         {
            idb.AddParameter("@TCRR_TCCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TCCode", tC_RRecord.TCRR_TCCode);
         }
         if (tC_RRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RRecord.Stat);
         }
         if (tC_RRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RRecord.CreateDate);
         }
         if (tC_RRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RRecord.UpdateDate);
         }
         if (tC_RRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RRecord.DeleteDate);
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
      /// 更新原料检测记录 TC_RRecord对象(即:一条记录
      /// </summary>
      public int Update(TC_RRecord tC_RRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_RRecord       SET ");
            if(tC_RRecord.TCRR_ID_IsChanged){sbParameter.Append("TCRR_ID=@TCRR_ID, ");}
      if(tC_RRecord.TCRR_Code_IsChanged){sbParameter.Append("TCRR_Code=@TCRR_Code, ");}
      if(tC_RRecord.TCRR_SName_IsChanged){sbParameter.Append("TCRR_SName=@TCRR_SName, ");}
      if(tC_RRecord.TCRR_SCode_IsChanged){sbParameter.Append("TCRR_SCode=@TCRR_SCode, ");}
      if(tC_RRecord.TCRR_MCode_IsChanged){sbParameter.Append("TCRR_MCode=@TCRR_MCode, ");}
      if(tC_RRecord.TCRR_MName_IsChanged){sbParameter.Append("TCRR_MName=@TCRR_MName, ");}
      if(tC_RRecord.TCRR_GDate_IsChanged){sbParameter.Append("TCRR_GDate=@TCRR_GDate, ");}
      if(tC_RRecord.TCRR_TDate_IsChanged){sbParameter.Append("TCRR_TDate=@TCRR_TDate, ");}
      if(tC_RRecord.TCRR_Bak_IsChanged){sbParameter.Append("TCRR_Bak=@TCRR_Bak, ");}
      if(tC_RRecord.TCRR_TOwner_IsChanged){sbParameter.Append("TCRR_TOwner=@TCRR_TOwner, ");}
      if(tC_RRecord.TCRR_TConclusion_IsChanged){sbParameter.Append("TCRR_TConclusion=@TCRR_TConclusion, ");}
      if(tC_RRecord.TCRR_TStatus_IsChanged){sbParameter.Append("TCRR_TStatus=@TCRR_TStatus, ");}
      if(tC_RRecord.TCRR_RefType_IsChanged){sbParameter.Append("TCRR_RefType=@TCRR_RefType, ");}
      if(tC_RRecord.TCRR_RefCode_IsChanged){sbParameter.Append("TCRR_RefCode=@TCRR_RefCode, ");}
      if(tC_RRecord.TCRR_Lev_IsChanged){sbParameter.Append("TCRR_Lev=@TCRR_Lev, ");}
      if(tC_RRecord.TCRR_Num_IsChanged){sbParameter.Append("TCRR_Num=@TCRR_Num, ");}
      if(tC_RRecord.TCRR_SDate_IsChanged){sbParameter.Append("TCRR_SDate=@TCRR_SDate, ");}
      if(tC_RRecord.TCRR_SOwner_IsChanged){sbParameter.Append("TCRR_SOwner=@TCRR_SOwner, ");}
      if(tC_RRecord.TCRR_Base_IsChanged){sbParameter.Append("TCRR_Base=@TCRR_Base, ");}
      if(tC_RRecord.TCRR_Equ_IsChanged){sbParameter.Append("TCRR_Equ=@TCRR_Equ, ");}
      if(tC_RRecord.TCRR_TCCode_IsChanged){sbParameter.Append("TCRR_TCCode=@TCRR_TCCode, ");}
      if(tC_RRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_RRecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_RRecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_RRecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RMCheck_ID=@RMCheck_ID; " );
      string sql=sb.ToString();
         if(tC_RRecord.TCRR_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_ID))
         {
            idb.AddParameter("@TCRR_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_ID", tC_RRecord.TCRR_ID);
         }
          }
         if(tC_RRecord.TCRR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Code))
         {
            idb.AddParameter("@TCRR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Code", tC_RRecord.TCRR_Code);
         }
          }
         if(tC_RRecord.TCRR_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SName))
         {
            idb.AddParameter("@TCRR_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SName", tC_RRecord.TCRR_SName);
         }
          }
         if(tC_RRecord.TCRR_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SCode))
         {
            idb.AddParameter("@TCRR_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SCode", tC_RRecord.TCRR_SCode);
         }
          }
         if(tC_RRecord.TCRR_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_MCode))
         {
            idb.AddParameter("@TCRR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_MCode", tC_RRecord.TCRR_MCode);
         }
          }
         if(tC_RRecord.TCRR_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_MName))
         {
            idb.AddParameter("@TCRR_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_MName", tC_RRecord.TCRR_MName);
         }
          }
         if(tC_RRecord.TCRR_GDate_IsChanged)
         {
         if (tC_RRecord.TCRR_GDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_GDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_GDate", tC_RRecord.TCRR_GDate);
         }
          }
         if(tC_RRecord.TCRR_TDate_IsChanged)
         {
         if (tC_RRecord.TCRR_TDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_TDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TDate", tC_RRecord.TCRR_TDate);
         }
          }
         if(tC_RRecord.TCRR_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Bak))
         {
            idb.AddParameter("@TCRR_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Bak", tC_RRecord.TCRR_Bak);
         }
          }
         if(tC_RRecord.TCRR_TOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TOwner))
         {
            idb.AddParameter("@TCRR_TOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TOwner", tC_RRecord.TCRR_TOwner);
         }
          }
         if(tC_RRecord.TCRR_TConclusion_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TConclusion))
         {
            idb.AddParameter("@TCRR_TConclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TConclusion", tC_RRecord.TCRR_TConclusion);
         }
          }
         if(tC_RRecord.TCRR_TStatus_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TStatus))
         {
            idb.AddParameter("@TCRR_TStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TStatus", tC_RRecord.TCRR_TStatus);
         }
          }
         if(tC_RRecord.TCRR_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_RefType))
         {
            idb.AddParameter("@TCRR_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_RefType", tC_RRecord.TCRR_RefType);
         }
          }
         if(tC_RRecord.TCRR_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_RefCode))
         {
            idb.AddParameter("@TCRR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_RefCode", tC_RRecord.TCRR_RefCode);
         }
          }
         if(tC_RRecord.TCRR_Lev_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Lev))
         {
            idb.AddParameter("@TCRR_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Lev", tC_RRecord.TCRR_Lev);
         }
          }
         if(tC_RRecord.TCRR_Num_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Num))
         {
            idb.AddParameter("@TCRR_Num", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Num", tC_RRecord.TCRR_Num);
         }
          }
         if(tC_RRecord.TCRR_SDate_IsChanged)
         {
         if (tC_RRecord.TCRR_SDate == DateTime.MinValue)
         {
            idb.AddParameter("@TCRR_SDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SDate", tC_RRecord.TCRR_SDate);
         }
          }
         if(tC_RRecord.TCRR_SOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_SOwner))
         {
            idb.AddParameter("@TCRR_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_SOwner", tC_RRecord.TCRR_SOwner);
         }
          }
         if(tC_RRecord.TCRR_Base_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Base))
         {
            idb.AddParameter("@TCRR_Base", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Base", tC_RRecord.TCRR_Base);
         }
          }
         if(tC_RRecord.TCRR_Equ_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_Equ))
         {
            idb.AddParameter("@TCRR_Equ", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_Equ", tC_RRecord.TCRR_Equ);
         }
          }
         if(tC_RRecord.TCRR_TCCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RRecord.TCRR_TCCode))
         {
            idb.AddParameter("@TCRR_TCCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRR_TCCode", tC_RRecord.TCRR_TCCode);
         }
          }
         if(tC_RRecord.Stat_IsChanged)
         {
         if (tC_RRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RRecord.Stat);
         }
          }
         if(tC_RRecord.CreateDate_IsChanged)
         {
         if (tC_RRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RRecord.CreateDate);
         }
          }
         if(tC_RRecord.UpdateDate_IsChanged)
         {
         if (tC_RRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RRecord.UpdateDate);
         }
          }
         if(tC_RRecord.DeleteDate_IsChanged)
         {
         if (tC_RRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RRecord.DeleteDate);
         }
          }

         idb.AddParameter("@RMCheck_ID", tC_RRecord.RMCheck_ID);

           
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
      /// 删除原料检测记录 TC_RRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal rMCheck_ID)
      {
         string sql = "DELETE TC_RRecord WHERE 1=1  AND RMCheck_ID=@RMCheck_ID ";
         idb.AddParameter("@RMCheck_ID", rMCheck_ID);

           
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
      /// 获取指定的原料检测记录 TC_RRecord对象(即:一条记录
      /// </summary>
      public TC_RRecord GetByKey(decimal rMCheck_ID)
      {
         TC_RRecord tC_RRecord = new TC_RRecord();
         string sql = "SELECT  RMCheck_ID,TCRR_ID,TCRR_Code,TCRR_SName,TCRR_SCode,TCRR_MCode,TCRR_MName,TCRR_GDate,TCRR_TDate,TCRR_Bak,TCRR_TOwner,TCRR_TConclusion,TCRR_TStatus,TCRR_RefType,TCRR_RefCode,TCRR_Lev,TCRR_Num,TCRR_SDate,TCRR_SOwner,TCRR_Base,TCRR_Equ,TCRR_TCCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RMCheck_ID=@RMCheck_ID ";
         idb.AddParameter("@RMCheck_ID", rMCheck_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RMCheck_ID"] != DBNull.Value) tC_RRecord.RMCheck_ID = Convert.ToDecimal(dr["RMCheck_ID"]);
            if (dr["TCRR_ID"] != DBNull.Value) tC_RRecord.TCRR_ID = Convert.ToString(dr["TCRR_ID"]);
            if (dr["TCRR_Code"] != DBNull.Value) tC_RRecord.TCRR_Code = Convert.ToString(dr["TCRR_Code"]);
            if (dr["TCRR_SName"] != DBNull.Value) tC_RRecord.TCRR_SName = Convert.ToString(dr["TCRR_SName"]);
            if (dr["TCRR_SCode"] != DBNull.Value) tC_RRecord.TCRR_SCode = Convert.ToString(dr["TCRR_SCode"]);
            if (dr["TCRR_MCode"] != DBNull.Value) tC_RRecord.TCRR_MCode = Convert.ToString(dr["TCRR_MCode"]);
            if (dr["TCRR_MName"] != DBNull.Value) tC_RRecord.TCRR_MName = Convert.ToString(dr["TCRR_MName"]);
            if (dr["TCRR_GDate"] != DBNull.Value) tC_RRecord.TCRR_GDate = Convert.ToDateTime(dr["TCRR_GDate"]);
            if (dr["TCRR_TDate"] != DBNull.Value) tC_RRecord.TCRR_TDate = Convert.ToDateTime(dr["TCRR_TDate"]);
            if (dr["TCRR_Bak"] != DBNull.Value) tC_RRecord.TCRR_Bak = Convert.ToString(dr["TCRR_Bak"]);
            if (dr["TCRR_TOwner"] != DBNull.Value) tC_RRecord.TCRR_TOwner = Convert.ToString(dr["TCRR_TOwner"]);
            if (dr["TCRR_TConclusion"] != DBNull.Value) tC_RRecord.TCRR_TConclusion = Convert.ToString(dr["TCRR_TConclusion"]);
            if (dr["TCRR_TStatus"] != DBNull.Value) tC_RRecord.TCRR_TStatus = Convert.ToString(dr["TCRR_TStatus"]);
            if (dr["TCRR_RefType"] != DBNull.Value) tC_RRecord.TCRR_RefType = Convert.ToString(dr["TCRR_RefType"]);
            if (dr["TCRR_RefCode"] != DBNull.Value) tC_RRecord.TCRR_RefCode = Convert.ToString(dr["TCRR_RefCode"]);
            if (dr["TCRR_Lev"] != DBNull.Value) tC_RRecord.TCRR_Lev = Convert.ToString(dr["TCRR_Lev"]);
            if (dr["TCRR_Num"] != DBNull.Value) tC_RRecord.TCRR_Num = Convert.ToString(dr["TCRR_Num"]);
            if (dr["TCRR_SDate"] != DBNull.Value) tC_RRecord.TCRR_SDate = Convert.ToDateTime(dr["TCRR_SDate"]);
            if (dr["TCRR_SOwner"] != DBNull.Value) tC_RRecord.TCRR_SOwner = Convert.ToString(dr["TCRR_SOwner"]);
            if (dr["TCRR_Base"] != DBNull.Value) tC_RRecord.TCRR_Base = Convert.ToString(dr["TCRR_Base"]);
            if (dr["TCRR_Equ"] != DBNull.Value) tC_RRecord.TCRR_Equ = Convert.ToString(dr["TCRR_Equ"]);
            if (dr["TCRR_TCCode"] != DBNull.Value) tC_RRecord.TCRR_TCCode = Convert.ToString(dr["TCRR_TCCode"]);
            if (dr["Stat"] != DBNull.Value) tC_RRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_RRecord;
      }
      /// <summary>
      /// 获取指定的原料检测记录 TC_RRecord对象集合
      /// </summary>
      public List<TC_RRecord> GetListByWhere(string strCondition)
      {
         List<TC_RRecord> ret = new List<TC_RRecord>();
         string sql = "SELECT  RMCheck_ID,TCRR_ID,TCRR_Code,TCRR_SName,TCRR_SCode,TCRR_MCode,TCRR_MName,TCRR_GDate,TCRR_TDate,TCRR_Bak,TCRR_TOwner,TCRR_TConclusion,TCRR_TStatus,TCRR_RefType,TCRR_RefCode,TCRR_Lev,TCRR_Num,TCRR_SDate,TCRR_SOwner,TCRR_Base,TCRR_Equ,TCRR_TCCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_RRecord tC_RRecord = new TC_RRecord();
            if (dr["RMCheck_ID"] != DBNull.Value) tC_RRecord.RMCheck_ID = Convert.ToDecimal(dr["RMCheck_ID"]);
            if (dr["TCRR_ID"] != DBNull.Value) tC_RRecord.TCRR_ID = Convert.ToString(dr["TCRR_ID"]);
            if (dr["TCRR_Code"] != DBNull.Value) tC_RRecord.TCRR_Code = Convert.ToString(dr["TCRR_Code"]);
            if (dr["TCRR_SName"] != DBNull.Value) tC_RRecord.TCRR_SName = Convert.ToString(dr["TCRR_SName"]);
            if (dr["TCRR_SCode"] != DBNull.Value) tC_RRecord.TCRR_SCode = Convert.ToString(dr["TCRR_SCode"]);
            if (dr["TCRR_MCode"] != DBNull.Value) tC_RRecord.TCRR_MCode = Convert.ToString(dr["TCRR_MCode"]);
            if (dr["TCRR_MName"] != DBNull.Value) tC_RRecord.TCRR_MName = Convert.ToString(dr["TCRR_MName"]);
            if (dr["TCRR_GDate"] != DBNull.Value) tC_RRecord.TCRR_GDate = Convert.ToDateTime(dr["TCRR_GDate"]);
            if (dr["TCRR_TDate"] != DBNull.Value) tC_RRecord.TCRR_TDate = Convert.ToDateTime(dr["TCRR_TDate"]);
            if (dr["TCRR_Bak"] != DBNull.Value) tC_RRecord.TCRR_Bak = Convert.ToString(dr["TCRR_Bak"]);
            if (dr["TCRR_TOwner"] != DBNull.Value) tC_RRecord.TCRR_TOwner = Convert.ToString(dr["TCRR_TOwner"]);
            if (dr["TCRR_TConclusion"] != DBNull.Value) tC_RRecord.TCRR_TConclusion = Convert.ToString(dr["TCRR_TConclusion"]);
            if (dr["TCRR_TStatus"] != DBNull.Value) tC_RRecord.TCRR_TStatus = Convert.ToString(dr["TCRR_TStatus"]);
            if (dr["TCRR_RefType"] != DBNull.Value) tC_RRecord.TCRR_RefType = Convert.ToString(dr["TCRR_RefType"]);
            if (dr["TCRR_RefCode"] != DBNull.Value) tC_RRecord.TCRR_RefCode = Convert.ToString(dr["TCRR_RefCode"]);
            if (dr["TCRR_Lev"] != DBNull.Value) tC_RRecord.TCRR_Lev = Convert.ToString(dr["TCRR_Lev"]);
            if (dr["TCRR_Num"] != DBNull.Value) tC_RRecord.TCRR_Num = Convert.ToString(dr["TCRR_Num"]);
            if (dr["TCRR_SDate"] != DBNull.Value) tC_RRecord.TCRR_SDate = Convert.ToDateTime(dr["TCRR_SDate"]);
            if (dr["TCRR_SOwner"] != DBNull.Value) tC_RRecord.TCRR_SOwner = Convert.ToString(dr["TCRR_SOwner"]);
            if (dr["TCRR_Base"] != DBNull.Value) tC_RRecord.TCRR_Base = Convert.ToString(dr["TCRR_Base"]);
            if (dr["TCRR_Equ"] != DBNull.Value) tC_RRecord.TCRR_Equ = Convert.ToString(dr["TCRR_Equ"]);
            if (dr["TCRR_TCCode"] != DBNull.Value) tC_RRecord.TCRR_TCCode = Convert.ToString(dr["TCRR_TCCode"]);
            if (dr["Stat"] != DBNull.Value) tC_RRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的原料检测记录 TC_RRecord对象(即:一条记录
      /// </summary>
      public List<TC_RRecord> GetAll()
      {
         List<TC_RRecord> ret = new List<TC_RRecord>();
         string sql = "SELECT  RMCheck_ID,TCRR_ID,TCRR_Code,TCRR_SName,TCRR_SCode,TCRR_MCode,TCRR_MName,TCRR_GDate,TCRR_TDate,TCRR_Bak,TCRR_TOwner,TCRR_TConclusion,TCRR_TStatus,TCRR_RefType,TCRR_RefCode,TCRR_Lev,TCRR_Num,TCRR_SDate,TCRR_SOwner,TCRR_Base,TCRR_Equ,TCRR_TCCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RRecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by RMCheck_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_RRecord tC_RRecord = new TC_RRecord();
            if (dr["RMCheck_ID"] != DBNull.Value) tC_RRecord.RMCheck_ID = Convert.ToDecimal(dr["RMCheck_ID"]);
            if (dr["TCRR_ID"] != DBNull.Value) tC_RRecord.TCRR_ID = Convert.ToString(dr["TCRR_ID"]);
            if (dr["TCRR_Code"] != DBNull.Value) tC_RRecord.TCRR_Code = Convert.ToString(dr["TCRR_Code"]);
            if (dr["TCRR_SName"] != DBNull.Value) tC_RRecord.TCRR_SName = Convert.ToString(dr["TCRR_SName"]);
            if (dr["TCRR_SCode"] != DBNull.Value) tC_RRecord.TCRR_SCode = Convert.ToString(dr["TCRR_SCode"]);
            if (dr["TCRR_MCode"] != DBNull.Value) tC_RRecord.TCRR_MCode = Convert.ToString(dr["TCRR_MCode"]);
            if (dr["TCRR_MName"] != DBNull.Value) tC_RRecord.TCRR_MName = Convert.ToString(dr["TCRR_MName"]);
            if (dr["TCRR_GDate"] != DBNull.Value) tC_RRecord.TCRR_GDate = Convert.ToDateTime(dr["TCRR_GDate"]);
            if (dr["TCRR_TDate"] != DBNull.Value) tC_RRecord.TCRR_TDate = Convert.ToDateTime(dr["TCRR_TDate"]);
            if (dr["TCRR_Bak"] != DBNull.Value) tC_RRecord.TCRR_Bak = Convert.ToString(dr["TCRR_Bak"]);
            if (dr["TCRR_TOwner"] != DBNull.Value) tC_RRecord.TCRR_TOwner = Convert.ToString(dr["TCRR_TOwner"]);
            if (dr["TCRR_TConclusion"] != DBNull.Value) tC_RRecord.TCRR_TConclusion = Convert.ToString(dr["TCRR_TConclusion"]);
            if (dr["TCRR_TStatus"] != DBNull.Value) tC_RRecord.TCRR_TStatus = Convert.ToString(dr["TCRR_TStatus"]);
            if (dr["TCRR_RefType"] != DBNull.Value) tC_RRecord.TCRR_RefType = Convert.ToString(dr["TCRR_RefType"]);
            if (dr["TCRR_RefCode"] != DBNull.Value) tC_RRecord.TCRR_RefCode = Convert.ToString(dr["TCRR_RefCode"]);
            if (dr["TCRR_Lev"] != DBNull.Value) tC_RRecord.TCRR_Lev = Convert.ToString(dr["TCRR_Lev"]);
            if (dr["TCRR_Num"] != DBNull.Value) tC_RRecord.TCRR_Num = Convert.ToString(dr["TCRR_Num"]);
            if (dr["TCRR_SDate"] != DBNull.Value) tC_RRecord.TCRR_SDate = Convert.ToDateTime(dr["TCRR_SDate"]);
            if (dr["TCRR_SOwner"] != DBNull.Value) tC_RRecord.TCRR_SOwner = Convert.ToString(dr["TCRR_SOwner"]);
            if (dr["TCRR_Base"] != DBNull.Value) tC_RRecord.TCRR_Base = Convert.ToString(dr["TCRR_Base"]);
            if (dr["TCRR_Equ"] != DBNull.Value) tC_RRecord.TCRR_Equ = Convert.ToString(dr["TCRR_Equ"]);
            if (dr["TCRR_TCCode"] != DBNull.Value) tC_RRecord.TCRR_TCCode = Convert.ToString(dr["TCRR_TCCode"]);
            if (dr["Stat"] != DBNull.Value) tC_RRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
