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
   /// 物料盘存表
   /// </summary>
   [Serializable]
   public partial class ADOWH_CheckList
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加物料盘存表 WH_CheckList对象(即:一条记录)
      /// </summary>
      public int Add(WH_CheckList wH_CheckList)
      {
         string sql = "INSERT INTO WH_CheckList (CL_MCode,CL_MName,CL_MSpec,CL_Month,CL_Last,CL_In,CL_Out,CL_Current,CL_CIn,CL_Mid,CL_LOut,CL_Date,CL_Stuff1,CL_Stuff2,CL_Bak,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStep,VerifyStat,Stat) VALUES (@CL_MCode,@CL_MName,@CL_MSpec,@CL_Month,@CL_Last,@CL_In,@CL_Out,@CL_Current,@CL_CIn,@CL_Mid,@CL_LOut,@CL_Date,@CL_Stuff1,@CL_Stuff2,@CL_Bak,@Creator,@CreateTime,@VerifyStuff,@VerifyDate,@VerifyStep,@VerifyStat,@Stat)";
         if (string.IsNullOrEmpty(wH_CheckList.CL_MCode))
         {
            idb.AddParameter("@CL_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MCode", wH_CheckList.CL_MCode);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_MName))
         {
            idb.AddParameter("@CL_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MName", wH_CheckList.CL_MName);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_MSpec))
         {
            idb.AddParameter("@CL_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MSpec", wH_CheckList.CL_MSpec);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Month))
         {
            idb.AddParameter("@CL_Month", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Month", wH_CheckList.CL_Month);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Last))
         {
            idb.AddParameter("@CL_Last", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Last", wH_CheckList.CL_Last);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_In))
         {
            idb.AddParameter("@CL_In", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_In", wH_CheckList.CL_In);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Out))
         {
            idb.AddParameter("@CL_Out", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Out", wH_CheckList.CL_Out);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Current))
         {
            idb.AddParameter("@CL_Current", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Current", wH_CheckList.CL_Current);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_CIn))
         {
            idb.AddParameter("@CL_CIn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_CIn", wH_CheckList.CL_CIn);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Mid))
         {
            idb.AddParameter("@CL_Mid", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Mid", wH_CheckList.CL_Mid);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_LOut))
         {
            idb.AddParameter("@CL_LOut", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_LOut", wH_CheckList.CL_LOut);
         }
         if (wH_CheckList.CL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Date", wH_CheckList.CL_Date);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Stuff1))
         {
            idb.AddParameter("@CL_Stuff1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Stuff1", wH_CheckList.CL_Stuff1);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Stuff2))
         {
            idb.AddParameter("@CL_Stuff2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Stuff2", wH_CheckList.CL_Stuff2);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Bak))
         {
            idb.AddParameter("@CL_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Bak", wH_CheckList.CL_Bak);
         }
         if (string.IsNullOrEmpty(wH_CheckList.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", wH_CheckList.Creator);
         }
         if (wH_CheckList.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", wH_CheckList.CreateTime);
         }
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", wH_CheckList.VerifyStuff);
         }
         if (wH_CheckList.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", wH_CheckList.VerifyDate);
         }
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStep))
         {
            idb.AddParameter("@VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStep", wH_CheckList.VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", wH_CheckList.VerifyStat);
         }
         if (wH_CheckList.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CheckList.Stat);
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
      /// 添加物料盘存表 WH_CheckList对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_CheckList wH_CheckList)
      {
         string sql = "INSERT INTO WH_CheckList (CL_MCode,CL_MName,CL_MSpec,CL_Month,CL_Last,CL_In,CL_Out,CL_Current,CL_CIn,CL_Mid,CL_LOut,CL_Date,CL_Stuff1,CL_Stuff2,CL_Bak,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStep,VerifyStat,Stat) VALUES (@CL_MCode,@CL_MName,@CL_MSpec,@CL_Month,@CL_Last,@CL_In,@CL_Out,@CL_Current,@CL_CIn,@CL_Mid,@CL_LOut,@CL_Date,@CL_Stuff1,@CL_Stuff2,@CL_Bak,@Creator,@CreateTime,@VerifyStuff,@VerifyDate,@VerifyStep,@VerifyStat,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_CheckList.CL_MCode))
         {
            idb.AddParameter("@CL_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MCode", wH_CheckList.CL_MCode);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_MName))
         {
            idb.AddParameter("@CL_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MName", wH_CheckList.CL_MName);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_MSpec))
         {
            idb.AddParameter("@CL_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MSpec", wH_CheckList.CL_MSpec);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Month))
         {
            idb.AddParameter("@CL_Month", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Month", wH_CheckList.CL_Month);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Last))
         {
            idb.AddParameter("@CL_Last", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Last", wH_CheckList.CL_Last);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_In))
         {
            idb.AddParameter("@CL_In", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_In", wH_CheckList.CL_In);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Out))
         {
            idb.AddParameter("@CL_Out", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Out", wH_CheckList.CL_Out);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Current))
         {
            idb.AddParameter("@CL_Current", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Current", wH_CheckList.CL_Current);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_CIn))
         {
            idb.AddParameter("@CL_CIn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_CIn", wH_CheckList.CL_CIn);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Mid))
         {
            idb.AddParameter("@CL_Mid", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Mid", wH_CheckList.CL_Mid);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_LOut))
         {
            idb.AddParameter("@CL_LOut", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_LOut", wH_CheckList.CL_LOut);
         }
         if (wH_CheckList.CL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Date", wH_CheckList.CL_Date);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Stuff1))
         {
            idb.AddParameter("@CL_Stuff1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Stuff1", wH_CheckList.CL_Stuff1);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Stuff2))
         {
            idb.AddParameter("@CL_Stuff2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Stuff2", wH_CheckList.CL_Stuff2);
         }
         if (string.IsNullOrEmpty(wH_CheckList.CL_Bak))
         {
            idb.AddParameter("@CL_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Bak", wH_CheckList.CL_Bak);
         }
         if (string.IsNullOrEmpty(wH_CheckList.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", wH_CheckList.Creator);
         }
         if (wH_CheckList.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", wH_CheckList.CreateTime);
         }
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", wH_CheckList.VerifyStuff);
         }
         if (wH_CheckList.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", wH_CheckList.VerifyDate);
         }
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStep))
         {
            idb.AddParameter("@VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStep", wH_CheckList.VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", wH_CheckList.VerifyStat);
         }
         if (wH_CheckList.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CheckList.Stat);
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
      /// 更新物料盘存表 WH_CheckList对象(即:一条记录
      /// </summary>
      public int Update(WH_CheckList wH_CheckList)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_CheckList       SET ");
            if(wH_CheckList.CL_MCode_IsChanged){sbParameter.Append("CL_MCode=@CL_MCode, ");}
      if(wH_CheckList.CL_MName_IsChanged){sbParameter.Append("CL_MName=@CL_MName, ");}
      if(wH_CheckList.CL_MSpec_IsChanged){sbParameter.Append("CL_MSpec=@CL_MSpec, ");}
      if(wH_CheckList.CL_Month_IsChanged){sbParameter.Append("CL_Month=@CL_Month, ");}
      if(wH_CheckList.CL_Last_IsChanged){sbParameter.Append("CL_Last=@CL_Last, ");}
      if(wH_CheckList.CL_In_IsChanged){sbParameter.Append("CL_In=@CL_In, ");}
      if(wH_CheckList.CL_Out_IsChanged){sbParameter.Append("CL_Out=@CL_Out, ");}
      if(wH_CheckList.CL_Current_IsChanged){sbParameter.Append("CL_Current=@CL_Current, ");}
      if(wH_CheckList.CL_CIn_IsChanged){sbParameter.Append("CL_CIn=@CL_CIn, ");}
      if(wH_CheckList.CL_Mid_IsChanged){sbParameter.Append("CL_Mid=@CL_Mid, ");}
      if(wH_CheckList.CL_LOut_IsChanged){sbParameter.Append("CL_LOut=@CL_LOut, ");}
      if(wH_CheckList.CL_Date_IsChanged){sbParameter.Append("CL_Date=@CL_Date, ");}
      if(wH_CheckList.CL_Stuff1_IsChanged){sbParameter.Append("CL_Stuff1=@CL_Stuff1, ");}
      if(wH_CheckList.CL_Stuff2_IsChanged){sbParameter.Append("CL_Stuff2=@CL_Stuff2, ");}
      if(wH_CheckList.CL_Bak_IsChanged){sbParameter.Append("CL_Bak=@CL_Bak, ");}
      if(wH_CheckList.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(wH_CheckList.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(wH_CheckList.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(wH_CheckList.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(wH_CheckList.VerifyStep_IsChanged){sbParameter.Append("VerifyStep=@VerifyStep, ");}
      if(wH_CheckList.VerifyStat_IsChanged){sbParameter.Append("VerifyStat=@VerifyStat, ");}
      if(wH_CheckList.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CL_ID=@CL_ID; " );
      string sql=sb.ToString();
         if(wH_CheckList.CL_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_MCode))
         {
            idb.AddParameter("@CL_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MCode", wH_CheckList.CL_MCode);
         }
          }
         if(wH_CheckList.CL_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_MName))
         {
            idb.AddParameter("@CL_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MName", wH_CheckList.CL_MName);
         }
          }
         if(wH_CheckList.CL_MSpec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_MSpec))
         {
            idb.AddParameter("@CL_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_MSpec", wH_CheckList.CL_MSpec);
         }
          }
         if(wH_CheckList.CL_Month_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Month))
         {
            idb.AddParameter("@CL_Month", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Month", wH_CheckList.CL_Month);
         }
          }
         if(wH_CheckList.CL_Last_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Last))
         {
            idb.AddParameter("@CL_Last", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Last", wH_CheckList.CL_Last);
         }
          }
         if(wH_CheckList.CL_In_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_In))
         {
            idb.AddParameter("@CL_In", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_In", wH_CheckList.CL_In);
         }
          }
         if(wH_CheckList.CL_Out_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Out))
         {
            idb.AddParameter("@CL_Out", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Out", wH_CheckList.CL_Out);
         }
          }
         if(wH_CheckList.CL_Current_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Current))
         {
            idb.AddParameter("@CL_Current", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Current", wH_CheckList.CL_Current);
         }
          }
         if(wH_CheckList.CL_CIn_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_CIn))
         {
            idb.AddParameter("@CL_CIn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_CIn", wH_CheckList.CL_CIn);
         }
          }
         if(wH_CheckList.CL_Mid_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Mid))
         {
            idb.AddParameter("@CL_Mid", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Mid", wH_CheckList.CL_Mid);
         }
          }
         if(wH_CheckList.CL_LOut_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_LOut))
         {
            idb.AddParameter("@CL_LOut", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_LOut", wH_CheckList.CL_LOut);
         }
          }
         if(wH_CheckList.CL_Date_IsChanged)
         {
         if (wH_CheckList.CL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Date", wH_CheckList.CL_Date);
         }
          }
         if(wH_CheckList.CL_Stuff1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Stuff1))
         {
            idb.AddParameter("@CL_Stuff1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Stuff1", wH_CheckList.CL_Stuff1);
         }
          }
         if(wH_CheckList.CL_Stuff2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Stuff2))
         {
            idb.AddParameter("@CL_Stuff2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Stuff2", wH_CheckList.CL_Stuff2);
         }
          }
         if(wH_CheckList.CL_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.CL_Bak))
         {
            idb.AddParameter("@CL_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CL_Bak", wH_CheckList.CL_Bak);
         }
          }
         if(wH_CheckList.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", wH_CheckList.Creator);
         }
          }
         if(wH_CheckList.CreateTime_IsChanged)
         {
         if (wH_CheckList.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", wH_CheckList.CreateTime);
         }
          }
         if(wH_CheckList.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", wH_CheckList.VerifyStuff);
         }
          }
         if(wH_CheckList.VerifyDate_IsChanged)
         {
         if (wH_CheckList.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", wH_CheckList.VerifyDate);
         }
          }
         if(wH_CheckList.VerifyStep_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStep))
         {
            idb.AddParameter("@VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStep", wH_CheckList.VerifyStep);
         }
          }
         if(wH_CheckList.VerifyStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_CheckList.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", wH_CheckList.VerifyStat);
         }
          }
         if(wH_CheckList.Stat_IsChanged)
         {
         if (wH_CheckList.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_CheckList.Stat);
         }
          }

         idb.AddParameter("@CL_ID", wH_CheckList.CL_ID);

           
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
      /// 删除物料盘存表 WH_CheckList对象(即:一条记录
      /// </summary>
      public int Delete(decimal cL_ID)
      {
         string sql = "DELETE WH_CheckList WHERE 1=1  AND CL_ID=@CL_ID ";
         idb.AddParameter("@CL_ID", cL_ID);

           
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
      /// 获取指定的物料盘存表 WH_CheckList对象(即:一条记录
      /// </summary>
      public WH_CheckList GetByKey(decimal cL_ID)
      {
         WH_CheckList wH_CheckList = new WH_CheckList();
         string sql = "SELECT  CL_ID,CL_MCode,CL_MName,CL_MSpec,CL_Month,CL_Last,CL_In,CL_Out,CL_Current,CL_CIn,CL_Mid,CL_LOut,CL_Date,CL_Stuff1,CL_Stuff2,CL_Bak,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStep,VerifyStat,Stat FROM WH_CheckList WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CL_ID=@CL_ID ";
         idb.AddParameter("@CL_ID", cL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CL_ID"] != DBNull.Value) wH_CheckList.CL_ID = Convert.ToDecimal(dr["CL_ID"]);
            if (dr["CL_MCode"] != DBNull.Value) wH_CheckList.CL_MCode = Convert.ToString(dr["CL_MCode"]);
            if (dr["CL_MName"] != DBNull.Value) wH_CheckList.CL_MName = Convert.ToString(dr["CL_MName"]);
            if (dr["CL_MSpec"] != DBNull.Value) wH_CheckList.CL_MSpec = Convert.ToString(dr["CL_MSpec"]);
            if (dr["CL_Month"] != DBNull.Value) wH_CheckList.CL_Month = Convert.ToString(dr["CL_Month"]);
            if (dr["CL_Last"] != DBNull.Value) wH_CheckList.CL_Last = Convert.ToString(dr["CL_Last"]);
            if (dr["CL_In"] != DBNull.Value) wH_CheckList.CL_In = Convert.ToString(dr["CL_In"]);
            if (dr["CL_Out"] != DBNull.Value) wH_CheckList.CL_Out = Convert.ToString(dr["CL_Out"]);
            if (dr["CL_Current"] != DBNull.Value) wH_CheckList.CL_Current = Convert.ToString(dr["CL_Current"]);
            if (dr["CL_CIn"] != DBNull.Value) wH_CheckList.CL_CIn = Convert.ToString(dr["CL_CIn"]);
            if (dr["CL_Mid"] != DBNull.Value) wH_CheckList.CL_Mid = Convert.ToString(dr["CL_Mid"]);
            if (dr["CL_LOut"] != DBNull.Value) wH_CheckList.CL_LOut = Convert.ToString(dr["CL_LOut"]);
            if (dr["CL_Date"] != DBNull.Value) wH_CheckList.CL_Date = Convert.ToDateTime(dr["CL_Date"]);
            if (dr["CL_Stuff1"] != DBNull.Value) wH_CheckList.CL_Stuff1 = Convert.ToString(dr["CL_Stuff1"]);
            if (dr["CL_Stuff2"] != DBNull.Value) wH_CheckList.CL_Stuff2 = Convert.ToString(dr["CL_Stuff2"]);
            if (dr["CL_Bak"] != DBNull.Value) wH_CheckList.CL_Bak = Convert.ToString(dr["CL_Bak"]);
            if (dr["Creator"] != DBNull.Value) wH_CheckList.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) wH_CheckList.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStuff"] != DBNull.Value) wH_CheckList.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) wH_CheckList.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStep"] != DBNull.Value) wH_CheckList.VerifyStep = Convert.ToString(dr["VerifyStep"]);
            if (dr["VerifyStat"] != DBNull.Value) wH_CheckList.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["Stat"] != DBNull.Value) wH_CheckList.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_CheckList;
      }
      /// <summary>
      /// 获取指定的物料盘存表 WH_CheckList对象集合
      /// </summary>
      public List<WH_CheckList> GetListByWhere(string strCondition)
      {
         List<WH_CheckList> ret = new List<WH_CheckList>();
         string sql = "SELECT  CL_ID,CL_MCode,CL_MName,CL_MSpec,CL_Month,CL_Last,CL_In,CL_Out,CL_Current,CL_CIn,CL_Mid,CL_LOut,CL_Date,CL_Stuff1,CL_Stuff2,CL_Bak,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStep,VerifyStat,Stat FROM WH_CheckList WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_CheckList wH_CheckList = new WH_CheckList();
            if (dr["CL_ID"] != DBNull.Value) wH_CheckList.CL_ID = Convert.ToDecimal(dr["CL_ID"]);
            if (dr["CL_MCode"] != DBNull.Value) wH_CheckList.CL_MCode = Convert.ToString(dr["CL_MCode"]);
            if (dr["CL_MName"] != DBNull.Value) wH_CheckList.CL_MName = Convert.ToString(dr["CL_MName"]);
            if (dr["CL_MSpec"] != DBNull.Value) wH_CheckList.CL_MSpec = Convert.ToString(dr["CL_MSpec"]);
            if (dr["CL_Month"] != DBNull.Value) wH_CheckList.CL_Month = Convert.ToString(dr["CL_Month"]);
            if (dr["CL_Last"] != DBNull.Value) wH_CheckList.CL_Last = Convert.ToString(dr["CL_Last"]);
            if (dr["CL_In"] != DBNull.Value) wH_CheckList.CL_In = Convert.ToString(dr["CL_In"]);
            if (dr["CL_Out"] != DBNull.Value) wH_CheckList.CL_Out = Convert.ToString(dr["CL_Out"]);
            if (dr["CL_Current"] != DBNull.Value) wH_CheckList.CL_Current = Convert.ToString(dr["CL_Current"]);
            if (dr["CL_CIn"] != DBNull.Value) wH_CheckList.CL_CIn = Convert.ToString(dr["CL_CIn"]);
            if (dr["CL_Mid"] != DBNull.Value) wH_CheckList.CL_Mid = Convert.ToString(dr["CL_Mid"]);
            if (dr["CL_LOut"] != DBNull.Value) wH_CheckList.CL_LOut = Convert.ToString(dr["CL_LOut"]);
            if (dr["CL_Date"] != DBNull.Value) wH_CheckList.CL_Date = Convert.ToDateTime(dr["CL_Date"]);
            if (dr["CL_Stuff1"] != DBNull.Value) wH_CheckList.CL_Stuff1 = Convert.ToString(dr["CL_Stuff1"]);
            if (dr["CL_Stuff2"] != DBNull.Value) wH_CheckList.CL_Stuff2 = Convert.ToString(dr["CL_Stuff2"]);
            if (dr["CL_Bak"] != DBNull.Value) wH_CheckList.CL_Bak = Convert.ToString(dr["CL_Bak"]);
            if (dr["Creator"] != DBNull.Value) wH_CheckList.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) wH_CheckList.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStuff"] != DBNull.Value) wH_CheckList.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) wH_CheckList.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStep"] != DBNull.Value) wH_CheckList.VerifyStep = Convert.ToString(dr["VerifyStep"]);
            if (dr["VerifyStat"] != DBNull.Value) wH_CheckList.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["Stat"] != DBNull.Value) wH_CheckList.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(wH_CheckList);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的物料盘存表 WH_CheckList对象(即:一条记录
      /// </summary>
      public List<WH_CheckList> GetAll()
      {
         List<WH_CheckList> ret = new List<WH_CheckList>();
         string sql = "SELECT  CL_ID,CL_MCode,CL_MName,CL_MSpec,CL_Month,CL_Last,CL_In,CL_Out,CL_Current,CL_CIn,CL_Mid,CL_LOut,CL_Date,CL_Stuff1,CL_Stuff2,CL_Bak,Creator,CreateTime,VerifyStuff,VerifyDate,VerifyStep,VerifyStat,Stat FROM WH_CheckList where 1=1 AND ((Stat is null) or (Stat=0) ) order by CL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_CheckList wH_CheckList = new WH_CheckList();
            if (dr["CL_ID"] != DBNull.Value) wH_CheckList.CL_ID = Convert.ToDecimal(dr["CL_ID"]);
            if (dr["CL_MCode"] != DBNull.Value) wH_CheckList.CL_MCode = Convert.ToString(dr["CL_MCode"]);
            if (dr["CL_MName"] != DBNull.Value) wH_CheckList.CL_MName = Convert.ToString(dr["CL_MName"]);
            if (dr["CL_MSpec"] != DBNull.Value) wH_CheckList.CL_MSpec = Convert.ToString(dr["CL_MSpec"]);
            if (dr["CL_Month"] != DBNull.Value) wH_CheckList.CL_Month = Convert.ToString(dr["CL_Month"]);
            if (dr["CL_Last"] != DBNull.Value) wH_CheckList.CL_Last = Convert.ToString(dr["CL_Last"]);
            if (dr["CL_In"] != DBNull.Value) wH_CheckList.CL_In = Convert.ToString(dr["CL_In"]);
            if (dr["CL_Out"] != DBNull.Value) wH_CheckList.CL_Out = Convert.ToString(dr["CL_Out"]);
            if (dr["CL_Current"] != DBNull.Value) wH_CheckList.CL_Current = Convert.ToString(dr["CL_Current"]);
            if (dr["CL_CIn"] != DBNull.Value) wH_CheckList.CL_CIn = Convert.ToString(dr["CL_CIn"]);
            if (dr["CL_Mid"] != DBNull.Value) wH_CheckList.CL_Mid = Convert.ToString(dr["CL_Mid"]);
            if (dr["CL_LOut"] != DBNull.Value) wH_CheckList.CL_LOut = Convert.ToString(dr["CL_LOut"]);
            if (dr["CL_Date"] != DBNull.Value) wH_CheckList.CL_Date = Convert.ToDateTime(dr["CL_Date"]);
            if (dr["CL_Stuff1"] != DBNull.Value) wH_CheckList.CL_Stuff1 = Convert.ToString(dr["CL_Stuff1"]);
            if (dr["CL_Stuff2"] != DBNull.Value) wH_CheckList.CL_Stuff2 = Convert.ToString(dr["CL_Stuff2"]);
            if (dr["CL_Bak"] != DBNull.Value) wH_CheckList.CL_Bak = Convert.ToString(dr["CL_Bak"]);
            if (dr["Creator"] != DBNull.Value) wH_CheckList.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) wH_CheckList.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStuff"] != DBNull.Value) wH_CheckList.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyDate"] != DBNull.Value) wH_CheckList.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStep"] != DBNull.Value) wH_CheckList.VerifyStep = Convert.ToString(dr["VerifyStep"]);
            if (dr["VerifyStat"] != DBNull.Value) wH_CheckList.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["Stat"] != DBNull.Value) wH_CheckList.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(wH_CheckList);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
