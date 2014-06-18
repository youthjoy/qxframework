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
   /// 水票/水领用记录
   /// </summary>
   [Serializable]
   public partial class ADOWaterRecipients_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加水票/水领用记录 WaterRecipients_Record对象(即:一条记录)
      /// </summary>
      public int Add(WaterRecipients_Record waterRecipients_Record)
      {
         string sql = "INSERT INTO WaterRecipients_Record (WR_Code,WR_Company,WR_Dept,WR_DutyPerson,WR_Count,WR_EmptyPosition,WR_Price,WR_Cost,WR_RecipientDate,WR_Abstract,WR_Remark,WR_IsReturn,WR_iType,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WR_Code,@WR_Company,@WR_Dept,@WR_DutyPerson,@WR_Count,@WR_EmptyPosition,@WR_Price,@WR_Cost,@WR_RecipientDate,@WR_Abstract,@WR_Remark,@WR_IsReturn,@WR_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Code))
         {
            idb.AddParameter("@WR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Code", waterRecipients_Record.WR_Code);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Company))
         {
            idb.AddParameter("@WR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Company", waterRecipients_Record.WR_Company);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Dept))
         {
            idb.AddParameter("@WR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Dept", waterRecipients_Record.WR_Dept);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_DutyPerson))
         {
            idb.AddParameter("@WR_DutyPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_DutyPerson", waterRecipients_Record.WR_DutyPerson);
         }
         if (waterRecipients_Record.WR_Count == 0)
         {
            idb.AddParameter("@WR_Count", 0);
         }
         else
         {
            idb.AddParameter("@WR_Count", waterRecipients_Record.WR_Count);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_EmptyPosition))
         {
            idb.AddParameter("@WR_EmptyPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_EmptyPosition", waterRecipients_Record.WR_EmptyPosition);
         }
         if (waterRecipients_Record.WR_Price == 0)
         {
            idb.AddParameter("@WR_Price", 0);
         }
         else
         {
            idb.AddParameter("@WR_Price", waterRecipients_Record.WR_Price);
         }
         if (waterRecipients_Record.WR_Cost == 0)
         {
            idb.AddParameter("@WR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@WR_Cost", waterRecipients_Record.WR_Cost);
         }
         if (waterRecipients_Record.WR_RecipientDate == DateTime.MinValue)
         {
            idb.AddParameter("@WR_RecipientDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_RecipientDate", waterRecipients_Record.WR_RecipientDate);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Abstract))
         {
            idb.AddParameter("@WR_Abstract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Abstract", waterRecipients_Record.WR_Abstract);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Remark))
         {
            idb.AddParameter("@WR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Remark", waterRecipients_Record.WR_Remark);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_IsReturn))
         {
            idb.AddParameter("@WR_IsReturn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_IsReturn", waterRecipients_Record.WR_IsReturn);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_iType))
         {
            idb.AddParameter("@WR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_iType", waterRecipients_Record.WR_iType);
         }
         if (waterRecipients_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", waterRecipients_Record.Stat);
         }
         if (waterRecipients_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", waterRecipients_Record.CreateDate);
         }
         if (waterRecipients_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", waterRecipients_Record.UpdateDate);
         }
         if (waterRecipients_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", waterRecipients_Record.DeleteDate);
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
      /// 添加水票/水领用记录 WaterRecipients_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WaterRecipients_Record waterRecipients_Record)
      {
         string sql = "INSERT INTO WaterRecipients_Record (WR_Code,WR_Company,WR_Dept,WR_DutyPerson,WR_Count,WR_EmptyPosition,WR_Price,WR_Cost,WR_RecipientDate,WR_Abstract,WR_Remark,WR_IsReturn,WR_iType,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WR_Code,@WR_Company,@WR_Dept,@WR_DutyPerson,@WR_Count,@WR_EmptyPosition,@WR_Price,@WR_Cost,@WR_RecipientDate,@WR_Abstract,@WR_Remark,@WR_IsReturn,@WR_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Code))
         {
            idb.AddParameter("@WR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Code", waterRecipients_Record.WR_Code);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Company))
         {
            idb.AddParameter("@WR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Company", waterRecipients_Record.WR_Company);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Dept))
         {
            idb.AddParameter("@WR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Dept", waterRecipients_Record.WR_Dept);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_DutyPerson))
         {
            idb.AddParameter("@WR_DutyPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_DutyPerson", waterRecipients_Record.WR_DutyPerson);
         }
         if (waterRecipients_Record.WR_Count == 0)
         {
            idb.AddParameter("@WR_Count", 0);
         }
         else
         {
            idb.AddParameter("@WR_Count", waterRecipients_Record.WR_Count);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_EmptyPosition))
         {
            idb.AddParameter("@WR_EmptyPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_EmptyPosition", waterRecipients_Record.WR_EmptyPosition);
         }
         if (waterRecipients_Record.WR_Price == 0)
         {
            idb.AddParameter("@WR_Price", 0);
         }
         else
         {
            idb.AddParameter("@WR_Price", waterRecipients_Record.WR_Price);
         }
         if (waterRecipients_Record.WR_Cost == 0)
         {
            idb.AddParameter("@WR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@WR_Cost", waterRecipients_Record.WR_Cost);
         }
         if (waterRecipients_Record.WR_RecipientDate == DateTime.MinValue)
         {
            idb.AddParameter("@WR_RecipientDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_RecipientDate", waterRecipients_Record.WR_RecipientDate);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Abstract))
         {
            idb.AddParameter("@WR_Abstract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Abstract", waterRecipients_Record.WR_Abstract);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Remark))
         {
            idb.AddParameter("@WR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Remark", waterRecipients_Record.WR_Remark);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_IsReturn))
         {
            idb.AddParameter("@WR_IsReturn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_IsReturn", waterRecipients_Record.WR_IsReturn);
         }
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_iType))
         {
            idb.AddParameter("@WR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_iType", waterRecipients_Record.WR_iType);
         }
         if (waterRecipients_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", waterRecipients_Record.Stat);
         }
         if (waterRecipients_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", waterRecipients_Record.CreateDate);
         }
         if (waterRecipients_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", waterRecipients_Record.UpdateDate);
         }
         if (waterRecipients_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", waterRecipients_Record.DeleteDate);
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
      /// 更新水票/水领用记录 WaterRecipients_Record对象(即:一条记录
      /// </summary>
      public int Update(WaterRecipients_Record waterRecipients_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WaterRecipients_Record       SET ");
            if(waterRecipients_Record.WR_Code_IsChanged){sbParameter.Append("WR_Code=@WR_Code, ");}
      if(waterRecipients_Record.WR_Company_IsChanged){sbParameter.Append("WR_Company=@WR_Company, ");}
      if(waterRecipients_Record.WR_Dept_IsChanged){sbParameter.Append("WR_Dept=@WR_Dept, ");}
      if(waterRecipients_Record.WR_DutyPerson_IsChanged){sbParameter.Append("WR_DutyPerson=@WR_DutyPerson, ");}
      if(waterRecipients_Record.WR_Count_IsChanged){sbParameter.Append("WR_Count=@WR_Count, ");}
      if(waterRecipients_Record.WR_EmptyPosition_IsChanged){sbParameter.Append("WR_EmptyPosition=@WR_EmptyPosition, ");}
      if(waterRecipients_Record.WR_Price_IsChanged){sbParameter.Append("WR_Price=@WR_Price, ");}
      if(waterRecipients_Record.WR_Cost_IsChanged){sbParameter.Append("WR_Cost=@WR_Cost, ");}
      if(waterRecipients_Record.WR_RecipientDate_IsChanged){sbParameter.Append("WR_RecipientDate=@WR_RecipientDate, ");}
      if(waterRecipients_Record.WR_Abstract_IsChanged){sbParameter.Append("WR_Abstract=@WR_Abstract, ");}
      if(waterRecipients_Record.WR_Remark_IsChanged){sbParameter.Append("WR_Remark=@WR_Remark, ");}
      if(waterRecipients_Record.WR_IsReturn_IsChanged){sbParameter.Append("WR_IsReturn=@WR_IsReturn, ");}
      if(waterRecipients_Record.WR_iType_IsChanged){sbParameter.Append("WR_iType=@WR_iType, ");}
      if(waterRecipients_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(waterRecipients_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(waterRecipients_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(waterRecipients_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WR_ID=@WR_ID; " );
      string sql=sb.ToString();
         if(waterRecipients_Record.WR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Code))
         {
            idb.AddParameter("@WR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Code", waterRecipients_Record.WR_Code);
         }
          }
         if(waterRecipients_Record.WR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Company))
         {
            idb.AddParameter("@WR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Company", waterRecipients_Record.WR_Company);
         }
          }
         if(waterRecipients_Record.WR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Dept))
         {
            idb.AddParameter("@WR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Dept", waterRecipients_Record.WR_Dept);
         }
          }
         if(waterRecipients_Record.WR_DutyPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_DutyPerson))
         {
            idb.AddParameter("@WR_DutyPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_DutyPerson", waterRecipients_Record.WR_DutyPerson);
         }
          }
         if(waterRecipients_Record.WR_Count_IsChanged)
         {
         if (waterRecipients_Record.WR_Count == 0)
         {
            idb.AddParameter("@WR_Count", 0);
         }
         else
         {
            idb.AddParameter("@WR_Count", waterRecipients_Record.WR_Count);
         }
          }
         if(waterRecipients_Record.WR_EmptyPosition_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_EmptyPosition))
         {
            idb.AddParameter("@WR_EmptyPosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_EmptyPosition", waterRecipients_Record.WR_EmptyPosition);
         }
          }
         if(waterRecipients_Record.WR_Price_IsChanged)
         {
         if (waterRecipients_Record.WR_Price == 0)
         {
            idb.AddParameter("@WR_Price", 0);
         }
         else
         {
            idb.AddParameter("@WR_Price", waterRecipients_Record.WR_Price);
         }
          }
         if(waterRecipients_Record.WR_Cost_IsChanged)
         {
         if (waterRecipients_Record.WR_Cost == 0)
         {
            idb.AddParameter("@WR_Cost", 0);
         }
         else
         {
            idb.AddParameter("@WR_Cost", waterRecipients_Record.WR_Cost);
         }
          }
         if(waterRecipients_Record.WR_RecipientDate_IsChanged)
         {
         if (waterRecipients_Record.WR_RecipientDate == DateTime.MinValue)
         {
            idb.AddParameter("@WR_RecipientDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_RecipientDate", waterRecipients_Record.WR_RecipientDate);
         }
          }
         if(waterRecipients_Record.WR_Abstract_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Abstract))
         {
            idb.AddParameter("@WR_Abstract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Abstract", waterRecipients_Record.WR_Abstract);
         }
          }
         if(waterRecipients_Record.WR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_Remark))
         {
            idb.AddParameter("@WR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_Remark", waterRecipients_Record.WR_Remark);
         }
          }
         if(waterRecipients_Record.WR_IsReturn_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_IsReturn))
         {
            idb.AddParameter("@WR_IsReturn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_IsReturn", waterRecipients_Record.WR_IsReturn);
         }
          }
         if(waterRecipients_Record.WR_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(waterRecipients_Record.WR_iType))
         {
            idb.AddParameter("@WR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WR_iType", waterRecipients_Record.WR_iType);
         }
          }
         if(waterRecipients_Record.Stat_IsChanged)
         {
         if (waterRecipients_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", waterRecipients_Record.Stat);
         }
          }
         if(waterRecipients_Record.CreateDate_IsChanged)
         {
         if (waterRecipients_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", waterRecipients_Record.CreateDate);
         }
          }
         if(waterRecipients_Record.UpdateDate_IsChanged)
         {
         if (waterRecipients_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", waterRecipients_Record.UpdateDate);
         }
          }
         if(waterRecipients_Record.DeleteDate_IsChanged)
         {
         if (waterRecipients_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", waterRecipients_Record.DeleteDate);
         }
          }

         idb.AddParameter("@WR_ID", waterRecipients_Record.WR_ID);

           
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
      /// 删除水票/水领用记录 WaterRecipients_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal wR_ID)
      {
         string sql = "DELETE WaterRecipients_Record WHERE 1=1  AND WR_ID=@WR_ID ";
         idb.AddParameter("@WR_ID", wR_ID);

           
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
      /// 获取指定的水票/水领用记录 WaterRecipients_Record对象(即:一条记录
      /// </summary>
      public WaterRecipients_Record GetByKey(decimal wR_ID)
      {
         WaterRecipients_Record waterRecipients_Record = new WaterRecipients_Record();
         string sql = "SELECT  WR_ID,WR_Code,WR_Company,WR_Dept,WR_DutyPerson,WR_Count,WR_EmptyPosition,WR_Price,WR_Cost,WR_RecipientDate,WR_Abstract,WR_Remark,WR_IsReturn,WR_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM WaterRecipients_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WR_ID=@WR_ID ";
         idb.AddParameter("@WR_ID", wR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WR_ID"] != DBNull.Value) waterRecipients_Record.WR_ID = Convert.ToDecimal(dr["WR_ID"]);
            if (dr["WR_Code"] != DBNull.Value) waterRecipients_Record.WR_Code = Convert.ToString(dr["WR_Code"]);
            if (dr["WR_Company"] != DBNull.Value) waterRecipients_Record.WR_Company = Convert.ToString(dr["WR_Company"]);
            if (dr["WR_Dept"] != DBNull.Value) waterRecipients_Record.WR_Dept = Convert.ToString(dr["WR_Dept"]);
            if (dr["WR_DutyPerson"] != DBNull.Value) waterRecipients_Record.WR_DutyPerson = Convert.ToString(dr["WR_DutyPerson"]);
            if (dr["WR_Count"] != DBNull.Value) waterRecipients_Record.WR_Count = Convert.ToInt32(dr["WR_Count"]);
            if (dr["WR_EmptyPosition"] != DBNull.Value) waterRecipients_Record.WR_EmptyPosition = Convert.ToString(dr["WR_EmptyPosition"]);
            if (dr["WR_Price"] != DBNull.Value) waterRecipients_Record.WR_Price = Convert.ToDecimal(dr["WR_Price"]);
            if (dr["WR_Cost"] != DBNull.Value) waterRecipients_Record.WR_Cost = Convert.ToDecimal(dr["WR_Cost"]);
            if (dr["WR_RecipientDate"] != DBNull.Value) waterRecipients_Record.WR_RecipientDate = Convert.ToDateTime(dr["WR_RecipientDate"]);
            if (dr["WR_Abstract"] != DBNull.Value) waterRecipients_Record.WR_Abstract = Convert.ToString(dr["WR_Abstract"]);
            if (dr["WR_Remark"] != DBNull.Value) waterRecipients_Record.WR_Remark = Convert.ToString(dr["WR_Remark"]);
            if (dr["WR_IsReturn"] != DBNull.Value) waterRecipients_Record.WR_IsReturn = Convert.ToString(dr["WR_IsReturn"]);
            if (dr["WR_iType"] != DBNull.Value) waterRecipients_Record.WR_iType = Convert.ToString(dr["WR_iType"]);
            if (dr["Stat"] != DBNull.Value) waterRecipients_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) waterRecipients_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) waterRecipients_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) waterRecipients_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return waterRecipients_Record;
      }
      /// <summary>
      /// 获取指定的水票/水领用记录 WaterRecipients_Record对象集合
      /// </summary>
      public List<WaterRecipients_Record> GetListByWhere(string strCondition)
      {
         List<WaterRecipients_Record> ret = new List<WaterRecipients_Record>();
         string sql = "SELECT  WR_ID,WR_Code,WR_Company,WR_Dept,WR_DutyPerson,WR_Count,WR_EmptyPosition,WR_Price,WR_Cost,WR_RecipientDate,WR_Abstract,WR_Remark,WR_IsReturn,WR_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM WaterRecipients_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WaterRecipients_Record waterRecipients_Record = new WaterRecipients_Record();
            if (dr["WR_ID"] != DBNull.Value) waterRecipients_Record.WR_ID = Convert.ToDecimal(dr["WR_ID"]);
            if (dr["WR_Code"] != DBNull.Value) waterRecipients_Record.WR_Code = Convert.ToString(dr["WR_Code"]);
            if (dr["WR_Company"] != DBNull.Value) waterRecipients_Record.WR_Company = Convert.ToString(dr["WR_Company"]);
            if (dr["WR_Dept"] != DBNull.Value) waterRecipients_Record.WR_Dept = Convert.ToString(dr["WR_Dept"]);
            if (dr["WR_DutyPerson"] != DBNull.Value) waterRecipients_Record.WR_DutyPerson = Convert.ToString(dr["WR_DutyPerson"]);
            if (dr["WR_Count"] != DBNull.Value) waterRecipients_Record.WR_Count = Convert.ToInt32(dr["WR_Count"]);
            if (dr["WR_EmptyPosition"] != DBNull.Value) waterRecipients_Record.WR_EmptyPosition = Convert.ToString(dr["WR_EmptyPosition"]);
            if (dr["WR_Price"] != DBNull.Value) waterRecipients_Record.WR_Price = Convert.ToDecimal(dr["WR_Price"]);
            if (dr["WR_Cost"] != DBNull.Value) waterRecipients_Record.WR_Cost = Convert.ToDecimal(dr["WR_Cost"]);
            if (dr["WR_RecipientDate"] != DBNull.Value) waterRecipients_Record.WR_RecipientDate = Convert.ToDateTime(dr["WR_RecipientDate"]);
            if (dr["WR_Abstract"] != DBNull.Value) waterRecipients_Record.WR_Abstract = Convert.ToString(dr["WR_Abstract"]);
            if (dr["WR_Remark"] != DBNull.Value) waterRecipients_Record.WR_Remark = Convert.ToString(dr["WR_Remark"]);
            if (dr["WR_IsReturn"] != DBNull.Value) waterRecipients_Record.WR_IsReturn = Convert.ToString(dr["WR_IsReturn"]);
            if (dr["WR_iType"] != DBNull.Value) waterRecipients_Record.WR_iType = Convert.ToString(dr["WR_iType"]);
            if (dr["Stat"] != DBNull.Value) waterRecipients_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) waterRecipients_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) waterRecipients_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) waterRecipients_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(waterRecipients_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的水票/水领用记录 WaterRecipients_Record对象(即:一条记录
      /// </summary>
      public List<WaterRecipients_Record> GetAll()
      {
         List<WaterRecipients_Record> ret = new List<WaterRecipients_Record>();
         string sql = "SELECT  WR_ID,WR_Code,WR_Company,WR_Dept,WR_DutyPerson,WR_Count,WR_EmptyPosition,WR_Price,WR_Cost,WR_RecipientDate,WR_Abstract,WR_Remark,WR_IsReturn,WR_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM WaterRecipients_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by WR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WaterRecipients_Record waterRecipients_Record = new WaterRecipients_Record();
            if (dr["WR_ID"] != DBNull.Value) waterRecipients_Record.WR_ID = Convert.ToDecimal(dr["WR_ID"]);
            if (dr["WR_Code"] != DBNull.Value) waterRecipients_Record.WR_Code = Convert.ToString(dr["WR_Code"]);
            if (dr["WR_Company"] != DBNull.Value) waterRecipients_Record.WR_Company = Convert.ToString(dr["WR_Company"]);
            if (dr["WR_Dept"] != DBNull.Value) waterRecipients_Record.WR_Dept = Convert.ToString(dr["WR_Dept"]);
            if (dr["WR_DutyPerson"] != DBNull.Value) waterRecipients_Record.WR_DutyPerson = Convert.ToString(dr["WR_DutyPerson"]);
            if (dr["WR_Count"] != DBNull.Value) waterRecipients_Record.WR_Count = Convert.ToInt32(dr["WR_Count"]);
            if (dr["WR_EmptyPosition"] != DBNull.Value) waterRecipients_Record.WR_EmptyPosition = Convert.ToString(dr["WR_EmptyPosition"]);
            if (dr["WR_Price"] != DBNull.Value) waterRecipients_Record.WR_Price = Convert.ToDecimal(dr["WR_Price"]);
            if (dr["WR_Cost"] != DBNull.Value) waterRecipients_Record.WR_Cost = Convert.ToDecimal(dr["WR_Cost"]);
            if (dr["WR_RecipientDate"] != DBNull.Value) waterRecipients_Record.WR_RecipientDate = Convert.ToDateTime(dr["WR_RecipientDate"]);
            if (dr["WR_Abstract"] != DBNull.Value) waterRecipients_Record.WR_Abstract = Convert.ToString(dr["WR_Abstract"]);
            if (dr["WR_Remark"] != DBNull.Value) waterRecipients_Record.WR_Remark = Convert.ToString(dr["WR_Remark"]);
            if (dr["WR_IsReturn"] != DBNull.Value) waterRecipients_Record.WR_IsReturn = Convert.ToString(dr["WR_IsReturn"]);
            if (dr["WR_iType"] != DBNull.Value) waterRecipients_Record.WR_iType = Convert.ToString(dr["WR_iType"]);
            if (dr["Stat"] != DBNull.Value) waterRecipients_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) waterRecipients_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) waterRecipients_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) waterRecipients_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(waterRecipients_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
