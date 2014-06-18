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
   /// 宾馆招待
   /// </summary>
   [Serializable]
   public partial class ADOHotelReception_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加宾馆招待 HotelReception_Record对象(即:一条记录)
      /// </summary>
      public int Add(HotelReception_Record hotelReception_Record)
      {
         string sql = "INSERT INTO HotelReception_Record (HRR_Code,HRR_Level,HRR_Date,HRR_HotelName,HRR_ObjectCompany,HRR_Persons,HRR_Num,HRR_Days,HRR_Money,HRR_Reason,HRR_Operator,HRR_Handler,HRR_HandleDate,HRR_Company,HRR_Dept,HRR_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HRR_Code,@HRR_Level,@HRR_Date,@HRR_HotelName,@HRR_ObjectCompany,@HRR_Persons,@HRR_Num,@HRR_Days,@HRR_Money,@HRR_Reason,@HRR_Operator,@HRR_Handler,@HRR_HandleDate,@HRR_Company,@HRR_Dept,@HRR_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Code))
         {
            idb.AddParameter("@HRR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Code", hotelReception_Record.HRR_Code);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Level))
         {
            idb.AddParameter("@HRR_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Level", hotelReception_Record.HRR_Level);
         }
         if (hotelReception_Record.HRR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Date", hotelReception_Record.HRR_Date);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_HotelName))
         {
            idb.AddParameter("@HRR_HotelName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_HotelName", hotelReception_Record.HRR_HotelName);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_ObjectCompany))
         {
            idb.AddParameter("@HRR_ObjectCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_ObjectCompany", hotelReception_Record.HRR_ObjectCompany);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Persons))
         {
            idb.AddParameter("@HRR_Persons", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Persons", hotelReception_Record.HRR_Persons);
         }
         if (hotelReception_Record.HRR_Num == 0)
         {
            idb.AddParameter("@HRR_Num", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Num", hotelReception_Record.HRR_Num);
         }
         if (hotelReception_Record.HRR_Days == 0)
         {
            idb.AddParameter("@HRR_Days", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Days", hotelReception_Record.HRR_Days);
         }
         if (hotelReception_Record.HRR_Money == 0)
         {
            idb.AddParameter("@HRR_Money", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Money", hotelReception_Record.HRR_Money);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Reason))
         {
            idb.AddParameter("@HRR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Reason", hotelReception_Record.HRR_Reason);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Operator))
         {
            idb.AddParameter("@HRR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Operator", hotelReception_Record.HRR_Operator);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Handler))
         {
            idb.AddParameter("@HRR_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Handler", hotelReception_Record.HRR_Handler);
         }
         if (hotelReception_Record.HRR_HandleDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRR_HandleDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_HandleDate", hotelReception_Record.HRR_HandleDate);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Company))
         {
            idb.AddParameter("@HRR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Company", hotelReception_Record.HRR_Company);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Dept))
         {
            idb.AddParameter("@HRR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Dept", hotelReception_Record.HRR_Dept);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Stat))
         {
            idb.AddParameter("@HRR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Stat", hotelReception_Record.HRR_Stat);
         }
         if (hotelReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hotelReception_Record.Stat);
         }
         if (hotelReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hotelReception_Record.CreateDate);
         }
         if (hotelReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hotelReception_Record.UpdateDate);
         }
         if (hotelReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hotelReception_Record.DeleteDate);
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
      /// 添加宾馆招待 HotelReception_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HotelReception_Record hotelReception_Record)
      {
         string sql = "INSERT INTO HotelReception_Record (HRR_Code,HRR_Level,HRR_Date,HRR_HotelName,HRR_ObjectCompany,HRR_Persons,HRR_Num,HRR_Days,HRR_Money,HRR_Reason,HRR_Operator,HRR_Handler,HRR_HandleDate,HRR_Company,HRR_Dept,HRR_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HRR_Code,@HRR_Level,@HRR_Date,@HRR_HotelName,@HRR_ObjectCompany,@HRR_Persons,@HRR_Num,@HRR_Days,@HRR_Money,@HRR_Reason,@HRR_Operator,@HRR_Handler,@HRR_HandleDate,@HRR_Company,@HRR_Dept,@HRR_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Code))
         {
            idb.AddParameter("@HRR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Code", hotelReception_Record.HRR_Code);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Level))
         {
            idb.AddParameter("@HRR_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Level", hotelReception_Record.HRR_Level);
         }
         if (hotelReception_Record.HRR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Date", hotelReception_Record.HRR_Date);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_HotelName))
         {
            idb.AddParameter("@HRR_HotelName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_HotelName", hotelReception_Record.HRR_HotelName);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_ObjectCompany))
         {
            idb.AddParameter("@HRR_ObjectCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_ObjectCompany", hotelReception_Record.HRR_ObjectCompany);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Persons))
         {
            idb.AddParameter("@HRR_Persons", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Persons", hotelReception_Record.HRR_Persons);
         }
         if (hotelReception_Record.HRR_Num == 0)
         {
            idb.AddParameter("@HRR_Num", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Num", hotelReception_Record.HRR_Num);
         }
         if (hotelReception_Record.HRR_Days == 0)
         {
            idb.AddParameter("@HRR_Days", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Days", hotelReception_Record.HRR_Days);
         }
         if (hotelReception_Record.HRR_Money == 0)
         {
            idb.AddParameter("@HRR_Money", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Money", hotelReception_Record.HRR_Money);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Reason))
         {
            idb.AddParameter("@HRR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Reason", hotelReception_Record.HRR_Reason);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Operator))
         {
            idb.AddParameter("@HRR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Operator", hotelReception_Record.HRR_Operator);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Handler))
         {
            idb.AddParameter("@HRR_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Handler", hotelReception_Record.HRR_Handler);
         }
         if (hotelReception_Record.HRR_HandleDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRR_HandleDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_HandleDate", hotelReception_Record.HRR_HandleDate);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Company))
         {
            idb.AddParameter("@HRR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Company", hotelReception_Record.HRR_Company);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Dept))
         {
            idb.AddParameter("@HRR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Dept", hotelReception_Record.HRR_Dept);
         }
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Stat))
         {
            idb.AddParameter("@HRR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Stat", hotelReception_Record.HRR_Stat);
         }
         if (hotelReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hotelReception_Record.Stat);
         }
         if (hotelReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hotelReception_Record.CreateDate);
         }
         if (hotelReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hotelReception_Record.UpdateDate);
         }
         if (hotelReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hotelReception_Record.DeleteDate);
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
      /// 更新宾馆招待 HotelReception_Record对象(即:一条记录
      /// </summary>
      public int Update(HotelReception_Record hotelReception_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HotelReception_Record       SET ");
            if(hotelReception_Record.HRR_Code_IsChanged){sbParameter.Append("HRR_Code=@HRR_Code, ");}
      if(hotelReception_Record.HRR_Level_IsChanged){sbParameter.Append("HRR_Level=@HRR_Level, ");}
      if(hotelReception_Record.HRR_Date_IsChanged){sbParameter.Append("HRR_Date=@HRR_Date, ");}
      if(hotelReception_Record.HRR_HotelName_IsChanged){sbParameter.Append("HRR_HotelName=@HRR_HotelName, ");}
      if(hotelReception_Record.HRR_ObjectCompany_IsChanged){sbParameter.Append("HRR_ObjectCompany=@HRR_ObjectCompany, ");}
      if(hotelReception_Record.HRR_Persons_IsChanged){sbParameter.Append("HRR_Persons=@HRR_Persons, ");}
      if(hotelReception_Record.HRR_Num_IsChanged){sbParameter.Append("HRR_Num=@HRR_Num, ");}
      if(hotelReception_Record.HRR_Days_IsChanged){sbParameter.Append("HRR_Days=@HRR_Days, ");}
      if(hotelReception_Record.HRR_Money_IsChanged){sbParameter.Append("HRR_Money=@HRR_Money, ");}
      if(hotelReception_Record.HRR_Reason_IsChanged){sbParameter.Append("HRR_Reason=@HRR_Reason, ");}
      if(hotelReception_Record.HRR_Operator_IsChanged){sbParameter.Append("HRR_Operator=@HRR_Operator, ");}
      if(hotelReception_Record.HRR_Handler_IsChanged){sbParameter.Append("HRR_Handler=@HRR_Handler, ");}
      if(hotelReception_Record.HRR_HandleDate_IsChanged){sbParameter.Append("HRR_HandleDate=@HRR_HandleDate, ");}
      if(hotelReception_Record.HRR_Company_IsChanged){sbParameter.Append("HRR_Company=@HRR_Company, ");}
      if(hotelReception_Record.HRR_Dept_IsChanged){sbParameter.Append("HRR_Dept=@HRR_Dept, ");}
      if(hotelReception_Record.HRR_Stat_IsChanged){sbParameter.Append("HRR_Stat=@HRR_Stat, ");}
      if(hotelReception_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hotelReception_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hotelReception_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hotelReception_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and HRR_ID=@HRR_ID; " );
      string sql=sb.ToString();
         if(hotelReception_Record.HRR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Code))
         {
            idb.AddParameter("@HRR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Code", hotelReception_Record.HRR_Code);
         }
          }
         if(hotelReception_Record.HRR_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Level))
         {
            idb.AddParameter("@HRR_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Level", hotelReception_Record.HRR_Level);
         }
          }
         if(hotelReception_Record.HRR_Date_IsChanged)
         {
         if (hotelReception_Record.HRR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Date", hotelReception_Record.HRR_Date);
         }
          }
         if(hotelReception_Record.HRR_HotelName_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_HotelName))
         {
            idb.AddParameter("@HRR_HotelName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_HotelName", hotelReception_Record.HRR_HotelName);
         }
          }
         if(hotelReception_Record.HRR_ObjectCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_ObjectCompany))
         {
            idb.AddParameter("@HRR_ObjectCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_ObjectCompany", hotelReception_Record.HRR_ObjectCompany);
         }
          }
         if(hotelReception_Record.HRR_Persons_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Persons))
         {
            idb.AddParameter("@HRR_Persons", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Persons", hotelReception_Record.HRR_Persons);
         }
          }
         if(hotelReception_Record.HRR_Num_IsChanged)
         {
         if (hotelReception_Record.HRR_Num == 0)
         {
            idb.AddParameter("@HRR_Num", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Num", hotelReception_Record.HRR_Num);
         }
          }
         if(hotelReception_Record.HRR_Days_IsChanged)
         {
         if (hotelReception_Record.HRR_Days == 0)
         {
            idb.AddParameter("@HRR_Days", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Days", hotelReception_Record.HRR_Days);
         }
          }
         if(hotelReception_Record.HRR_Money_IsChanged)
         {
         if (hotelReception_Record.HRR_Money == 0)
         {
            idb.AddParameter("@HRR_Money", 0);
         }
         else
         {
            idb.AddParameter("@HRR_Money", hotelReception_Record.HRR_Money);
         }
          }
         if(hotelReception_Record.HRR_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Reason))
         {
            idb.AddParameter("@HRR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Reason", hotelReception_Record.HRR_Reason);
         }
          }
         if(hotelReception_Record.HRR_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Operator))
         {
            idb.AddParameter("@HRR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Operator", hotelReception_Record.HRR_Operator);
         }
          }
         if(hotelReception_Record.HRR_Handler_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Handler))
         {
            idb.AddParameter("@HRR_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Handler", hotelReception_Record.HRR_Handler);
         }
          }
         if(hotelReception_Record.HRR_HandleDate_IsChanged)
         {
         if (hotelReception_Record.HRR_HandleDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRR_HandleDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_HandleDate", hotelReception_Record.HRR_HandleDate);
         }
          }
         if(hotelReception_Record.HRR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Company))
         {
            idb.AddParameter("@HRR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Company", hotelReception_Record.HRR_Company);
         }
          }
         if(hotelReception_Record.HRR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Dept))
         {
            idb.AddParameter("@HRR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Dept", hotelReception_Record.HRR_Dept);
         }
          }
         if(hotelReception_Record.HRR_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(hotelReception_Record.HRR_Stat))
         {
            idb.AddParameter("@HRR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRR_Stat", hotelReception_Record.HRR_Stat);
         }
          }
         if(hotelReception_Record.Stat_IsChanged)
         {
         if (hotelReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hotelReception_Record.Stat);
         }
          }
         if(hotelReception_Record.CreateDate_IsChanged)
         {
         if (hotelReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hotelReception_Record.CreateDate);
         }
          }
         if(hotelReception_Record.UpdateDate_IsChanged)
         {
         if (hotelReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hotelReception_Record.UpdateDate);
         }
          }
         if(hotelReception_Record.DeleteDate_IsChanged)
         {
         if (hotelReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hotelReception_Record.DeleteDate);
         }
          }

         idb.AddParameter("@HRR_ID", hotelReception_Record.HRR_ID);

           
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
      /// 删除宾馆招待 HotelReception_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal hRR_ID)
      {
         string sql = "DELETE HotelReception_Record WHERE 1=1  AND HRR_ID=@HRR_ID ";
         idb.AddParameter("@HRR_ID", hRR_ID);

           
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
      /// 获取指定的宾馆招待 HotelReception_Record对象(即:一条记录
      /// </summary>
      public HotelReception_Record GetByKey(decimal hRR_ID)
      {
         HotelReception_Record hotelReception_Record = new HotelReception_Record();
         string sql = "SELECT  HRR_ID,HRR_Code,HRR_Level,HRR_Date,HRR_HotelName,HRR_ObjectCompany,HRR_Persons,HRR_Num,HRR_Days,HRR_Money,HRR_Reason,HRR_Operator,HRR_Handler,HRR_HandleDate,HRR_Company,HRR_Dept,HRR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM HotelReception_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND HRR_ID=@HRR_ID ";
         idb.AddParameter("@HRR_ID", hRR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["HRR_ID"] != DBNull.Value) hotelReception_Record.HRR_ID = Convert.ToDecimal(dr["HRR_ID"]);
            if (dr["HRR_Code"] != DBNull.Value) hotelReception_Record.HRR_Code = Convert.ToString(dr["HRR_Code"]);
            if (dr["HRR_Level"] != DBNull.Value) hotelReception_Record.HRR_Level = Convert.ToString(dr["HRR_Level"]);
            if (dr["HRR_Date"] != DBNull.Value) hotelReception_Record.HRR_Date = Convert.ToDateTime(dr["HRR_Date"]);
            if (dr["HRR_HotelName"] != DBNull.Value) hotelReception_Record.HRR_HotelName = Convert.ToString(dr["HRR_HotelName"]);
            if (dr["HRR_ObjectCompany"] != DBNull.Value) hotelReception_Record.HRR_ObjectCompany = Convert.ToString(dr["HRR_ObjectCompany"]);
            if (dr["HRR_Persons"] != DBNull.Value) hotelReception_Record.HRR_Persons = Convert.ToString(dr["HRR_Persons"]);
            if (dr["HRR_Num"] != DBNull.Value) hotelReception_Record.HRR_Num = Convert.ToInt32(dr["HRR_Num"]);
            if (dr["HRR_Days"] != DBNull.Value) hotelReception_Record.HRR_Days = Convert.ToInt32(dr["HRR_Days"]);
            if (dr["HRR_Money"] != DBNull.Value) hotelReception_Record.HRR_Money = Convert.ToDecimal(dr["HRR_Money"]);
            if (dr["HRR_Reason"] != DBNull.Value) hotelReception_Record.HRR_Reason = Convert.ToString(dr["HRR_Reason"]);
            if (dr["HRR_Operator"] != DBNull.Value) hotelReception_Record.HRR_Operator = Convert.ToString(dr["HRR_Operator"]);
            if (dr["HRR_Handler"] != DBNull.Value) hotelReception_Record.HRR_Handler = Convert.ToString(dr["HRR_Handler"]);
            if (dr["HRR_HandleDate"] != DBNull.Value) hotelReception_Record.HRR_HandleDate = Convert.ToDateTime(dr["HRR_HandleDate"]);
            if (dr["HRR_Company"] != DBNull.Value) hotelReception_Record.HRR_Company = Convert.ToString(dr["HRR_Company"]);
            if (dr["HRR_Dept"] != DBNull.Value) hotelReception_Record.HRR_Dept = Convert.ToString(dr["HRR_Dept"]);
            if (dr["HRR_Stat"] != DBNull.Value) hotelReception_Record.HRR_Stat = Convert.ToString(dr["HRR_Stat"]);
            if (dr["Stat"] != DBNull.Value) hotelReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hotelReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hotelReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hotelReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hotelReception_Record;
      }
      /// <summary>
      /// 获取指定的宾馆招待 HotelReception_Record对象集合
      /// </summary>
      public List<HotelReception_Record> GetListByWhere(string strCondition)
      {
         List<HotelReception_Record> ret = new List<HotelReception_Record>();
         string sql = "SELECT  HRR_ID,HRR_Code,HRR_Level,HRR_Date,HRR_HotelName,HRR_ObjectCompany,HRR_Persons,HRR_Num,HRR_Days,HRR_Money,HRR_Reason,HRR_Operator,HRR_Handler,HRR_HandleDate,HRR_Company,HRR_Dept,HRR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM HotelReception_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            HotelReception_Record hotelReception_Record = new HotelReception_Record();
            if (dr["HRR_ID"] != DBNull.Value) hotelReception_Record.HRR_ID = Convert.ToDecimal(dr["HRR_ID"]);
            if (dr["HRR_Code"] != DBNull.Value) hotelReception_Record.HRR_Code = Convert.ToString(dr["HRR_Code"]);
            if (dr["HRR_Level"] != DBNull.Value) hotelReception_Record.HRR_Level = Convert.ToString(dr["HRR_Level"]);
            if (dr["HRR_Date"] != DBNull.Value) hotelReception_Record.HRR_Date = Convert.ToDateTime(dr["HRR_Date"]);
            if (dr["HRR_HotelName"] != DBNull.Value) hotelReception_Record.HRR_HotelName = Convert.ToString(dr["HRR_HotelName"]);
            if (dr["HRR_ObjectCompany"] != DBNull.Value) hotelReception_Record.HRR_ObjectCompany = Convert.ToString(dr["HRR_ObjectCompany"]);
            if (dr["HRR_Persons"] != DBNull.Value) hotelReception_Record.HRR_Persons = Convert.ToString(dr["HRR_Persons"]);
            if (dr["HRR_Num"] != DBNull.Value) hotelReception_Record.HRR_Num = Convert.ToInt32(dr["HRR_Num"]);
            if (dr["HRR_Days"] != DBNull.Value) hotelReception_Record.HRR_Days = Convert.ToInt32(dr["HRR_Days"]);
            if (dr["HRR_Money"] != DBNull.Value) hotelReception_Record.HRR_Money = Convert.ToDecimal(dr["HRR_Money"]);
            if (dr["HRR_Reason"] != DBNull.Value) hotelReception_Record.HRR_Reason = Convert.ToString(dr["HRR_Reason"]);
            if (dr["HRR_Operator"] != DBNull.Value) hotelReception_Record.HRR_Operator = Convert.ToString(dr["HRR_Operator"]);
            if (dr["HRR_Handler"] != DBNull.Value) hotelReception_Record.HRR_Handler = Convert.ToString(dr["HRR_Handler"]);
            if (dr["HRR_HandleDate"] != DBNull.Value) hotelReception_Record.HRR_HandleDate = Convert.ToDateTime(dr["HRR_HandleDate"]);
            if (dr["HRR_Company"] != DBNull.Value) hotelReception_Record.HRR_Company = Convert.ToString(dr["HRR_Company"]);
            if (dr["HRR_Dept"] != DBNull.Value) hotelReception_Record.HRR_Dept = Convert.ToString(dr["HRR_Dept"]);
            if (dr["HRR_Stat"] != DBNull.Value) hotelReception_Record.HRR_Stat = Convert.ToString(dr["HRR_Stat"]);
            if (dr["Stat"] != DBNull.Value) hotelReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hotelReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hotelReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hotelReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hotelReception_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的宾馆招待 HotelReception_Record对象(即:一条记录
      /// </summary>
      public List<HotelReception_Record> GetAll()
      {
         List<HotelReception_Record> ret = new List<HotelReception_Record>();
         string sql = "SELECT  HRR_ID,HRR_Code,HRR_Level,HRR_Date,HRR_HotelName,HRR_ObjectCompany,HRR_Persons,HRR_Num,HRR_Days,HRR_Money,HRR_Reason,HRR_Operator,HRR_Handler,HRR_HandleDate,HRR_Company,HRR_Dept,HRR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM HotelReception_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by HRR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HotelReception_Record hotelReception_Record = new HotelReception_Record();
            if (dr["HRR_ID"] != DBNull.Value) hotelReception_Record.HRR_ID = Convert.ToDecimal(dr["HRR_ID"]);
            if (dr["HRR_Code"] != DBNull.Value) hotelReception_Record.HRR_Code = Convert.ToString(dr["HRR_Code"]);
            if (dr["HRR_Level"] != DBNull.Value) hotelReception_Record.HRR_Level = Convert.ToString(dr["HRR_Level"]);
            if (dr["HRR_Date"] != DBNull.Value) hotelReception_Record.HRR_Date = Convert.ToDateTime(dr["HRR_Date"]);
            if (dr["HRR_HotelName"] != DBNull.Value) hotelReception_Record.HRR_HotelName = Convert.ToString(dr["HRR_HotelName"]);
            if (dr["HRR_ObjectCompany"] != DBNull.Value) hotelReception_Record.HRR_ObjectCompany = Convert.ToString(dr["HRR_ObjectCompany"]);
            if (dr["HRR_Persons"] != DBNull.Value) hotelReception_Record.HRR_Persons = Convert.ToString(dr["HRR_Persons"]);
            if (dr["HRR_Num"] != DBNull.Value) hotelReception_Record.HRR_Num = Convert.ToInt32(dr["HRR_Num"]);
            if (dr["HRR_Days"] != DBNull.Value) hotelReception_Record.HRR_Days = Convert.ToInt32(dr["HRR_Days"]);
            if (dr["HRR_Money"] != DBNull.Value) hotelReception_Record.HRR_Money = Convert.ToDecimal(dr["HRR_Money"]);
            if (dr["HRR_Reason"] != DBNull.Value) hotelReception_Record.HRR_Reason = Convert.ToString(dr["HRR_Reason"]);
            if (dr["HRR_Operator"] != DBNull.Value) hotelReception_Record.HRR_Operator = Convert.ToString(dr["HRR_Operator"]);
            if (dr["HRR_Handler"] != DBNull.Value) hotelReception_Record.HRR_Handler = Convert.ToString(dr["HRR_Handler"]);
            if (dr["HRR_HandleDate"] != DBNull.Value) hotelReception_Record.HRR_HandleDate = Convert.ToDateTime(dr["HRR_HandleDate"]);
            if (dr["HRR_Company"] != DBNull.Value) hotelReception_Record.HRR_Company = Convert.ToString(dr["HRR_Company"]);
            if (dr["HRR_Dept"] != DBNull.Value) hotelReception_Record.HRR_Dept = Convert.ToString(dr["HRR_Dept"]);
            if (dr["HRR_Stat"] != DBNull.Value) hotelReception_Record.HRR_Stat = Convert.ToString(dr["HRR_Stat"]);
            if (dr["Stat"] != DBNull.Value) hotelReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hotelReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hotelReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hotelReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hotelReception_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
