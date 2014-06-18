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
   /// 出差登记表
   /// </summary>
   [Serializable]
   public partial class ADOTravel_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加出差登记表 Travel_Record对象(即:一条记录)
      /// </summary>
      public int Add(Travel_Record travel_Record)
      {
         string sql = "INSERT INTO Travel_Record (TR_Company,TR_Dept,TR_UserName,TR_Reason,TR_Place,TR_BackDate,TR_EstimateCost,TR_Transport,TR_RegisterDate,TR_OrderDate,TR_TransportDate,TR_TransportNo,TR_BackPlace,TR_BeginDate,TR_Price,TR_Stat,TR_Remark,TR_CurrentStat,TR_AuditStat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TR_Company,@TR_Dept,@TR_UserName,@TR_Reason,@TR_Place,@TR_BackDate,@TR_EstimateCost,@TR_Transport,@TR_RegisterDate,@TR_OrderDate,@TR_TransportDate,@TR_TransportNo,@TR_BackPlace,@TR_BeginDate,@TR_Price,@TR_Stat,@TR_Remark,@TR_CurrentStat,@TR_AuditStat,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(travel_Record.TR_Company))
         {
            idb.AddParameter("@TR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Company", travel_Record.TR_Company);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Dept))
         {
            idb.AddParameter("@TR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Dept", travel_Record.TR_Dept);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_UserName))
         {
            idb.AddParameter("@TR_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_UserName", travel_Record.TR_UserName);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Reason))
         {
            idb.AddParameter("@TR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Reason", travel_Record.TR_Reason);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Place))
         {
            idb.AddParameter("@TR_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Place", travel_Record.TR_Place);
         }
         if (travel_Record.TR_BackDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_BackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BackDate", travel_Record.TR_BackDate);
         }
         if (travel_Record.TR_EstimateCost == 0)
         {
            idb.AddParameter("@TR_EstimateCost", 0);
         }
         else
         {
            idb.AddParameter("@TR_EstimateCost", travel_Record.TR_EstimateCost);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Transport))
         {
            idb.AddParameter("@TR_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Transport", travel_Record.TR_Transport);
         }
         if (travel_Record.TR_RegisterDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_RegisterDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_RegisterDate", travel_Record.TR_RegisterDate);
         }
         if (travel_Record.TR_OrderDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_OrderDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_OrderDate", travel_Record.TR_OrderDate);
         }
         if (travel_Record.TR_TransportDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_TransportDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_TransportDate", travel_Record.TR_TransportDate);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_TransportNo))
         {
            idb.AddParameter("@TR_TransportNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_TransportNo", travel_Record.TR_TransportNo);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_BackPlace))
         {
            idb.AddParameter("@TR_BackPlace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BackPlace", travel_Record.TR_BackPlace);
         }
         if (travel_Record.TR_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BeginDate", travel_Record.TR_BeginDate);
         }
         if (travel_Record.TR_Price == 0)
         {
            idb.AddParameter("@TR_Price", 0);
         }
         else
         {
            idb.AddParameter("@TR_Price", travel_Record.TR_Price);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Stat))
         {
            idb.AddParameter("@TR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Stat", travel_Record.TR_Stat);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Remark))
         {
            idb.AddParameter("@TR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Remark", travel_Record.TR_Remark);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_CurrentStat))
         {
            idb.AddParameter("@TR_CurrentStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_CurrentStat", travel_Record.TR_CurrentStat);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_AuditStat))
         {
            idb.AddParameter("@TR_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_AuditStat", travel_Record.TR_AuditStat);
         }
         if (travel_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", travel_Record.Stat);
         }
         if (travel_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", travel_Record.CreateDate);
         }
         if (travel_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", travel_Record.UpdateDate);
         }
         if (travel_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", travel_Record.DeleteDate);
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
      /// 添加出差登记表 Travel_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Travel_Record travel_Record)
      {
         string sql = "INSERT INTO Travel_Record (TR_Company,TR_Dept,TR_UserName,TR_Reason,TR_Place,TR_BackDate,TR_EstimateCost,TR_Transport,TR_RegisterDate,TR_OrderDate,TR_TransportDate,TR_TransportNo,TR_BackPlace,TR_BeginDate,TR_Price,TR_Stat,TR_Remark,TR_CurrentStat,TR_AuditStat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TR_Company,@TR_Dept,@TR_UserName,@TR_Reason,@TR_Place,@TR_BackDate,@TR_EstimateCost,@TR_Transport,@TR_RegisterDate,@TR_OrderDate,@TR_TransportDate,@TR_TransportNo,@TR_BackPlace,@TR_BeginDate,@TR_Price,@TR_Stat,@TR_Remark,@TR_CurrentStat,@TR_AuditStat,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(travel_Record.TR_Company))
         {
            idb.AddParameter("@TR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Company", travel_Record.TR_Company);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Dept))
         {
            idb.AddParameter("@TR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Dept", travel_Record.TR_Dept);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_UserName))
         {
            idb.AddParameter("@TR_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_UserName", travel_Record.TR_UserName);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Reason))
         {
            idb.AddParameter("@TR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Reason", travel_Record.TR_Reason);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Place))
         {
            idb.AddParameter("@TR_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Place", travel_Record.TR_Place);
         }
         if (travel_Record.TR_BackDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_BackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BackDate", travel_Record.TR_BackDate);
         }
         if (travel_Record.TR_EstimateCost == 0)
         {
            idb.AddParameter("@TR_EstimateCost", 0);
         }
         else
         {
            idb.AddParameter("@TR_EstimateCost", travel_Record.TR_EstimateCost);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Transport))
         {
            idb.AddParameter("@TR_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Transport", travel_Record.TR_Transport);
         }
         if (travel_Record.TR_RegisterDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_RegisterDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_RegisterDate", travel_Record.TR_RegisterDate);
         }
         if (travel_Record.TR_OrderDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_OrderDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_OrderDate", travel_Record.TR_OrderDate);
         }
         if (travel_Record.TR_TransportDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_TransportDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_TransportDate", travel_Record.TR_TransportDate);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_TransportNo))
         {
            idb.AddParameter("@TR_TransportNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_TransportNo", travel_Record.TR_TransportNo);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_BackPlace))
         {
            idb.AddParameter("@TR_BackPlace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BackPlace", travel_Record.TR_BackPlace);
         }
         if (travel_Record.TR_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BeginDate", travel_Record.TR_BeginDate);
         }
         if (travel_Record.TR_Price == 0)
         {
            idb.AddParameter("@TR_Price", 0);
         }
         else
         {
            idb.AddParameter("@TR_Price", travel_Record.TR_Price);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Stat))
         {
            idb.AddParameter("@TR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Stat", travel_Record.TR_Stat);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_Remark))
         {
            idb.AddParameter("@TR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Remark", travel_Record.TR_Remark);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_CurrentStat))
         {
            idb.AddParameter("@TR_CurrentStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_CurrentStat", travel_Record.TR_CurrentStat);
         }
         if (string.IsNullOrEmpty(travel_Record.TR_AuditStat))
         {
            idb.AddParameter("@TR_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_AuditStat", travel_Record.TR_AuditStat);
         }
         if (travel_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", travel_Record.Stat);
         }
         if (travel_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", travel_Record.CreateDate);
         }
         if (travel_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", travel_Record.UpdateDate);
         }
         if (travel_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", travel_Record.DeleteDate);
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
      /// 更新出差登记表 Travel_Record对象(即:一条记录
      /// </summary>
      public int Update(Travel_Record travel_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Travel_Record       SET ");
            if(travel_Record.TR_Company_IsChanged){sbParameter.Append("TR_Company=@TR_Company, ");}
      if(travel_Record.TR_Dept_IsChanged){sbParameter.Append("TR_Dept=@TR_Dept, ");}
      if(travel_Record.TR_UserName_IsChanged){sbParameter.Append("TR_UserName=@TR_UserName, ");}
      if(travel_Record.TR_Reason_IsChanged){sbParameter.Append("TR_Reason=@TR_Reason, ");}
      if(travel_Record.TR_Place_IsChanged){sbParameter.Append("TR_Place=@TR_Place, ");}
      if(travel_Record.TR_BackDate_IsChanged){sbParameter.Append("TR_BackDate=@TR_BackDate, ");}
      if(travel_Record.TR_EstimateCost_IsChanged){sbParameter.Append("TR_EstimateCost=@TR_EstimateCost, ");}
      if(travel_Record.TR_Transport_IsChanged){sbParameter.Append("TR_Transport=@TR_Transport, ");}
      if(travel_Record.TR_RegisterDate_IsChanged){sbParameter.Append("TR_RegisterDate=@TR_RegisterDate, ");}
      if(travel_Record.TR_OrderDate_IsChanged){sbParameter.Append("TR_OrderDate=@TR_OrderDate, ");}
      if(travel_Record.TR_TransportDate_IsChanged){sbParameter.Append("TR_TransportDate=@TR_TransportDate, ");}
      if(travel_Record.TR_TransportNo_IsChanged){sbParameter.Append("TR_TransportNo=@TR_TransportNo, ");}
      if(travel_Record.TR_BackPlace_IsChanged){sbParameter.Append("TR_BackPlace=@TR_BackPlace, ");}
      if(travel_Record.TR_BeginDate_IsChanged){sbParameter.Append("TR_BeginDate=@TR_BeginDate, ");}
      if(travel_Record.TR_Price_IsChanged){sbParameter.Append("TR_Price=@TR_Price, ");}
      if(travel_Record.TR_Stat_IsChanged){sbParameter.Append("TR_Stat=@TR_Stat, ");}
      if(travel_Record.TR_Remark_IsChanged){sbParameter.Append("TR_Remark=@TR_Remark, ");}
      if(travel_Record.TR_CurrentStat_IsChanged){sbParameter.Append("TR_CurrentStat=@TR_CurrentStat, ");}
      if(travel_Record.TR_AuditStat_IsChanged){sbParameter.Append("TR_AuditStat=@TR_AuditStat, ");}
      if(travel_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(travel_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(travel_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(travel_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TR_ID=@TR_ID; " );
      string sql=sb.ToString();
         if(travel_Record.TR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_Company))
         {
            idb.AddParameter("@TR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Company", travel_Record.TR_Company);
         }
          }
         if(travel_Record.TR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_Dept))
         {
            idb.AddParameter("@TR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Dept", travel_Record.TR_Dept);
         }
          }
         if(travel_Record.TR_UserName_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_UserName))
         {
            idb.AddParameter("@TR_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_UserName", travel_Record.TR_UserName);
         }
          }
         if(travel_Record.TR_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_Reason))
         {
            idb.AddParameter("@TR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Reason", travel_Record.TR_Reason);
         }
          }
         if(travel_Record.TR_Place_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_Place))
         {
            idb.AddParameter("@TR_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Place", travel_Record.TR_Place);
         }
          }
         if(travel_Record.TR_BackDate_IsChanged)
         {
         if (travel_Record.TR_BackDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_BackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BackDate", travel_Record.TR_BackDate);
         }
          }
         if(travel_Record.TR_EstimateCost_IsChanged)
         {
         if (travel_Record.TR_EstimateCost == 0)
         {
            idb.AddParameter("@TR_EstimateCost", 0);
         }
         else
         {
            idb.AddParameter("@TR_EstimateCost", travel_Record.TR_EstimateCost);
         }
          }
         if(travel_Record.TR_Transport_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_Transport))
         {
            idb.AddParameter("@TR_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Transport", travel_Record.TR_Transport);
         }
          }
         if(travel_Record.TR_RegisterDate_IsChanged)
         {
         if (travel_Record.TR_RegisterDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_RegisterDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_RegisterDate", travel_Record.TR_RegisterDate);
         }
          }
         if(travel_Record.TR_OrderDate_IsChanged)
         {
         if (travel_Record.TR_OrderDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_OrderDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_OrderDate", travel_Record.TR_OrderDate);
         }
          }
         if(travel_Record.TR_TransportDate_IsChanged)
         {
         if (travel_Record.TR_TransportDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_TransportDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_TransportDate", travel_Record.TR_TransportDate);
         }
          }
         if(travel_Record.TR_TransportNo_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_TransportNo))
         {
            idb.AddParameter("@TR_TransportNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_TransportNo", travel_Record.TR_TransportNo);
         }
          }
         if(travel_Record.TR_BackPlace_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_BackPlace))
         {
            idb.AddParameter("@TR_BackPlace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BackPlace", travel_Record.TR_BackPlace);
         }
          }
         if(travel_Record.TR_BeginDate_IsChanged)
         {
         if (travel_Record.TR_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@TR_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_BeginDate", travel_Record.TR_BeginDate);
         }
          }
         if(travel_Record.TR_Price_IsChanged)
         {
         if (travel_Record.TR_Price == 0)
         {
            idb.AddParameter("@TR_Price", 0);
         }
         else
         {
            idb.AddParameter("@TR_Price", travel_Record.TR_Price);
         }
          }
         if(travel_Record.TR_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_Stat))
         {
            idb.AddParameter("@TR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Stat", travel_Record.TR_Stat);
         }
          }
         if(travel_Record.TR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_Remark))
         {
            idb.AddParameter("@TR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_Remark", travel_Record.TR_Remark);
         }
          }
         if(travel_Record.TR_CurrentStat_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_CurrentStat))
         {
            idb.AddParameter("@TR_CurrentStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_CurrentStat", travel_Record.TR_CurrentStat);
         }
          }
         if(travel_Record.TR_AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(travel_Record.TR_AuditStat))
         {
            idb.AddParameter("@TR_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TR_AuditStat", travel_Record.TR_AuditStat);
         }
          }
         if(travel_Record.Stat_IsChanged)
         {
         if (travel_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", travel_Record.Stat);
         }
          }
         if(travel_Record.CreateDate_IsChanged)
         {
         if (travel_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", travel_Record.CreateDate);
         }
          }
         if(travel_Record.UpdateDate_IsChanged)
         {
         if (travel_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", travel_Record.UpdateDate);
         }
          }
         if(travel_Record.DeleteDate_IsChanged)
         {
         if (travel_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", travel_Record.DeleteDate);
         }
          }

         idb.AddParameter("@TR_ID", travel_Record.TR_ID);

           
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
      /// 删除出差登记表 Travel_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal tR_ID)
      {
         string sql = "DELETE Travel_Record WHERE 1=1  AND TR_ID=@TR_ID ";
         idb.AddParameter("@TR_ID", tR_ID);

           
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
      /// 获取指定的出差登记表 Travel_Record对象(即:一条记录
      /// </summary>
      public Travel_Record GetByKey(decimal tR_ID)
      {
         Travel_Record travel_Record = new Travel_Record();
         string sql = "SELECT  TR_ID,TR_Company,TR_Dept,TR_UserName,TR_Reason,TR_Place,TR_BackDate,TR_EstimateCost,TR_Transport,TR_RegisterDate,TR_OrderDate,TR_TransportDate,TR_TransportNo,TR_BackPlace,TR_BeginDate,TR_Price,TR_Stat,TR_Remark,TR_CurrentStat,TR_AuditStat,Stat,CreateDate,UpdateDate,DeleteDate FROM Travel_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TR_ID=@TR_ID ";
         idb.AddParameter("@TR_ID", tR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TR_ID"] != DBNull.Value) travel_Record.TR_ID = Convert.ToDecimal(dr["TR_ID"]);
            if (dr["TR_Company"] != DBNull.Value) travel_Record.TR_Company = Convert.ToString(dr["TR_Company"]);
            if (dr["TR_Dept"] != DBNull.Value) travel_Record.TR_Dept = Convert.ToString(dr["TR_Dept"]);
            if (dr["TR_UserName"] != DBNull.Value) travel_Record.TR_UserName = Convert.ToString(dr["TR_UserName"]);
            if (dr["TR_Reason"] != DBNull.Value) travel_Record.TR_Reason = Convert.ToString(dr["TR_Reason"]);
            if (dr["TR_Place"] != DBNull.Value) travel_Record.TR_Place = Convert.ToString(dr["TR_Place"]);
            if (dr["TR_BackDate"] != DBNull.Value) travel_Record.TR_BackDate = Convert.ToDateTime(dr["TR_BackDate"]);
            if (dr["TR_EstimateCost"] != DBNull.Value) travel_Record.TR_EstimateCost = Convert.ToDecimal(dr["TR_EstimateCost"]);
            if (dr["TR_Transport"] != DBNull.Value) travel_Record.TR_Transport = Convert.ToString(dr["TR_Transport"]);
            if (dr["TR_RegisterDate"] != DBNull.Value) travel_Record.TR_RegisterDate = Convert.ToDateTime(dr["TR_RegisterDate"]);
            if (dr["TR_OrderDate"] != DBNull.Value) travel_Record.TR_OrderDate = Convert.ToDateTime(dr["TR_OrderDate"]);
            if (dr["TR_TransportDate"] != DBNull.Value) travel_Record.TR_TransportDate = Convert.ToDateTime(dr["TR_TransportDate"]);
            if (dr["TR_TransportNo"] != DBNull.Value) travel_Record.TR_TransportNo = Convert.ToString(dr["TR_TransportNo"]);
            if (dr["TR_BackPlace"] != DBNull.Value) travel_Record.TR_BackPlace = Convert.ToString(dr["TR_BackPlace"]);
            if (dr["TR_BeginDate"] != DBNull.Value) travel_Record.TR_BeginDate = Convert.ToDateTime(dr["TR_BeginDate"]);
            if (dr["TR_Price"] != DBNull.Value) travel_Record.TR_Price = Convert.ToDecimal(dr["TR_Price"]);
            if (dr["TR_Stat"] != DBNull.Value) travel_Record.TR_Stat = Convert.ToString(dr["TR_Stat"]);
            if (dr["TR_Remark"] != DBNull.Value) travel_Record.TR_Remark = Convert.ToString(dr["TR_Remark"]);
            if (dr["TR_CurrentStat"] != DBNull.Value) travel_Record.TR_CurrentStat = Convert.ToString(dr["TR_CurrentStat"]);
            if (dr["TR_AuditStat"] != DBNull.Value) travel_Record.TR_AuditStat = Convert.ToString(dr["TR_AuditStat"]);
            if (dr["Stat"] != DBNull.Value) travel_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) travel_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) travel_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) travel_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return travel_Record;
      }
      /// <summary>
      /// 获取指定的出差登记表 Travel_Record对象集合
      /// </summary>
      public List<Travel_Record> GetListByWhere(string strCondition)
      {
         List<Travel_Record> ret = new List<Travel_Record>();
         string sql = "SELECT  TR_ID,TR_Company,TR_Dept,TR_UserName,TR_Reason,TR_Place,TR_BackDate,TR_EstimateCost,TR_Transport,TR_RegisterDate,TR_OrderDate,TR_TransportDate,TR_TransportNo,TR_BackPlace,TR_BeginDate,TR_Price,TR_Stat,TR_Remark,TR_CurrentStat,TR_AuditStat,Stat,CreateDate,UpdateDate,DeleteDate FROM Travel_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Travel_Record travel_Record = new Travel_Record();
            if (dr["TR_ID"] != DBNull.Value) travel_Record.TR_ID = Convert.ToDecimal(dr["TR_ID"]);
            if (dr["TR_Company"] != DBNull.Value) travel_Record.TR_Company = Convert.ToString(dr["TR_Company"]);
            if (dr["TR_Dept"] != DBNull.Value) travel_Record.TR_Dept = Convert.ToString(dr["TR_Dept"]);
            if (dr["TR_UserName"] != DBNull.Value) travel_Record.TR_UserName = Convert.ToString(dr["TR_UserName"]);
            if (dr["TR_Reason"] != DBNull.Value) travel_Record.TR_Reason = Convert.ToString(dr["TR_Reason"]);
            if (dr["TR_Place"] != DBNull.Value) travel_Record.TR_Place = Convert.ToString(dr["TR_Place"]);
            if (dr["TR_BackDate"] != DBNull.Value) travel_Record.TR_BackDate = Convert.ToDateTime(dr["TR_BackDate"]);
            if (dr["TR_EstimateCost"] != DBNull.Value) travel_Record.TR_EstimateCost = Convert.ToDecimal(dr["TR_EstimateCost"]);
            if (dr["TR_Transport"] != DBNull.Value) travel_Record.TR_Transport = Convert.ToString(dr["TR_Transport"]);
            if (dr["TR_RegisterDate"] != DBNull.Value) travel_Record.TR_RegisterDate = Convert.ToDateTime(dr["TR_RegisterDate"]);
            if (dr["TR_OrderDate"] != DBNull.Value) travel_Record.TR_OrderDate = Convert.ToDateTime(dr["TR_OrderDate"]);
            if (dr["TR_TransportDate"] != DBNull.Value) travel_Record.TR_TransportDate = Convert.ToDateTime(dr["TR_TransportDate"]);
            if (dr["TR_TransportNo"] != DBNull.Value) travel_Record.TR_TransportNo = Convert.ToString(dr["TR_TransportNo"]);
            if (dr["TR_BackPlace"] != DBNull.Value) travel_Record.TR_BackPlace = Convert.ToString(dr["TR_BackPlace"]);
            if (dr["TR_BeginDate"] != DBNull.Value) travel_Record.TR_BeginDate = Convert.ToDateTime(dr["TR_BeginDate"]);
            if (dr["TR_Price"] != DBNull.Value) travel_Record.TR_Price = Convert.ToDecimal(dr["TR_Price"]);
            if (dr["TR_Stat"] != DBNull.Value) travel_Record.TR_Stat = Convert.ToString(dr["TR_Stat"]);
            if (dr["TR_Remark"] != DBNull.Value) travel_Record.TR_Remark = Convert.ToString(dr["TR_Remark"]);
            if (dr["TR_CurrentStat"] != DBNull.Value) travel_Record.TR_CurrentStat = Convert.ToString(dr["TR_CurrentStat"]);
            if (dr["TR_AuditStat"] != DBNull.Value) travel_Record.TR_AuditStat = Convert.ToString(dr["TR_AuditStat"]);
            if (dr["Stat"] != DBNull.Value) travel_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) travel_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) travel_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) travel_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(travel_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的出差登记表 Travel_Record对象(即:一条记录
      /// </summary>
      public List<Travel_Record> GetAll()
      {
         List<Travel_Record> ret = new List<Travel_Record>();
         string sql = "SELECT  TR_ID,TR_Company,TR_Dept,TR_UserName,TR_Reason,TR_Place,TR_BackDate,TR_EstimateCost,TR_Transport,TR_RegisterDate,TR_OrderDate,TR_TransportDate,TR_TransportNo,TR_BackPlace,TR_BeginDate,TR_Price,TR_Stat,TR_Remark,TR_CurrentStat,TR_AuditStat,Stat,CreateDate,UpdateDate,DeleteDate FROM Travel_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by TR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Travel_Record travel_Record = new Travel_Record();
            if (dr["TR_ID"] != DBNull.Value) travel_Record.TR_ID = Convert.ToDecimal(dr["TR_ID"]);
            if (dr["TR_Company"] != DBNull.Value) travel_Record.TR_Company = Convert.ToString(dr["TR_Company"]);
            if (dr["TR_Dept"] != DBNull.Value) travel_Record.TR_Dept = Convert.ToString(dr["TR_Dept"]);
            if (dr["TR_UserName"] != DBNull.Value) travel_Record.TR_UserName = Convert.ToString(dr["TR_UserName"]);
            if (dr["TR_Reason"] != DBNull.Value) travel_Record.TR_Reason = Convert.ToString(dr["TR_Reason"]);
            if (dr["TR_Place"] != DBNull.Value) travel_Record.TR_Place = Convert.ToString(dr["TR_Place"]);
            if (dr["TR_BackDate"] != DBNull.Value) travel_Record.TR_BackDate = Convert.ToDateTime(dr["TR_BackDate"]);
            if (dr["TR_EstimateCost"] != DBNull.Value) travel_Record.TR_EstimateCost = Convert.ToDecimal(dr["TR_EstimateCost"]);
            if (dr["TR_Transport"] != DBNull.Value) travel_Record.TR_Transport = Convert.ToString(dr["TR_Transport"]);
            if (dr["TR_RegisterDate"] != DBNull.Value) travel_Record.TR_RegisterDate = Convert.ToDateTime(dr["TR_RegisterDate"]);
            if (dr["TR_OrderDate"] != DBNull.Value) travel_Record.TR_OrderDate = Convert.ToDateTime(dr["TR_OrderDate"]);
            if (dr["TR_TransportDate"] != DBNull.Value) travel_Record.TR_TransportDate = Convert.ToDateTime(dr["TR_TransportDate"]);
            if (dr["TR_TransportNo"] != DBNull.Value) travel_Record.TR_TransportNo = Convert.ToString(dr["TR_TransportNo"]);
            if (dr["TR_BackPlace"] != DBNull.Value) travel_Record.TR_BackPlace = Convert.ToString(dr["TR_BackPlace"]);
            if (dr["TR_BeginDate"] != DBNull.Value) travel_Record.TR_BeginDate = Convert.ToDateTime(dr["TR_BeginDate"]);
            if (dr["TR_Price"] != DBNull.Value) travel_Record.TR_Price = Convert.ToDecimal(dr["TR_Price"]);
            if (dr["TR_Stat"] != DBNull.Value) travel_Record.TR_Stat = Convert.ToString(dr["TR_Stat"]);
            if (dr["TR_Remark"] != DBNull.Value) travel_Record.TR_Remark = Convert.ToString(dr["TR_Remark"]);
            if (dr["TR_CurrentStat"] != DBNull.Value) travel_Record.TR_CurrentStat = Convert.ToString(dr["TR_CurrentStat"]);
            if (dr["TR_AuditStat"] != DBNull.Value) travel_Record.TR_AuditStat = Convert.ToString(dr["TR_AuditStat"]);
            if (dr["Stat"] != DBNull.Value) travel_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) travel_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) travel_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) travel_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(travel_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
