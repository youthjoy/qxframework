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
   /// 房屋租赁列表
   /// </summary>
   [Serializable]
   public partial class ADOHouse_Rental
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加房屋租赁列表 House_Rental对象(即:一条记录)
      /// </summary>
      public int Add(House_Rental house_Rental)
      {
         string sql = "INSERT INTO House_Rental (HRental_Code,HRental_FileName,HRental_Rentor,HRental_Cost,HRental_Unit,HRental_BeginDate,HRental_EndDate,HRental_PayType,HRental_HouseName,HRental_HAddress,HRental_HType,HRental_HUsageType,HRental_NextPayDate,HRental_YearCost,HRental_Pay,HRental_Company,HRental_Dept,Stat,HRental_Remark,CreateDate,UpdateDate,DeleteDate) VALUES (@HRental_Code,@HRental_FileName,@HRental_Rentor,@HRental_Cost,@HRental_Unit,@HRental_BeginDate,@HRental_EndDate,@HRental_PayType,@HRental_HouseName,@HRental_HAddress,@HRental_HType,@HRental_HUsageType,@HRental_NextPayDate,@HRental_YearCost,@HRental_Pay,@HRental_Company,@HRental_Dept,@Stat,@HRental_Remark,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(house_Rental.HRental_Code))
         {
            idb.AddParameter("@HRental_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Code", house_Rental.HRental_Code);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_FileName))
         {
            idb.AddParameter("@HRental_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_FileName", house_Rental.HRental_FileName);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Rentor))
         {
            idb.AddParameter("@HRental_Rentor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Rentor", house_Rental.HRental_Rentor);
         }
         if (house_Rental.HRental_Cost == 0)
         {
            idb.AddParameter("@HRental_Cost", 0);
         }
         else
         {
            idb.AddParameter("@HRental_Cost", house_Rental.HRental_Cost);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Unit))
         {
            idb.AddParameter("@HRental_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Unit", house_Rental.HRental_Unit);
         }
         if (house_Rental.HRental_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_BeginDate", house_Rental.HRental_BeginDate);
         }
         if (house_Rental.HRental_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_EndDate", house_Rental.HRental_EndDate);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_PayType))
         {
            idb.AddParameter("@HRental_PayType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_PayType", house_Rental.HRental_PayType);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HouseName))
         {
            idb.AddParameter("@HRental_HouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HouseName", house_Rental.HRental_HouseName);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HAddress))
         {
            idb.AddParameter("@HRental_HAddress", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HAddress", house_Rental.HRental_HAddress);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HType))
         {
            idb.AddParameter("@HRental_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HType", house_Rental.HRental_HType);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HUsageType))
         {
            idb.AddParameter("@HRental_HUsageType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HUsageType", house_Rental.HRental_HUsageType);
         }
         if (house_Rental.HRental_NextPayDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_NextPayDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_NextPayDate", house_Rental.HRental_NextPayDate);
         }
         if (house_Rental.HRental_YearCost == 0)
         {
            idb.AddParameter("@HRental_YearCost", 0);
         }
         else
         {
            idb.AddParameter("@HRental_YearCost", house_Rental.HRental_YearCost);
         }
         if (house_Rental.HRental_Pay == 0)
         {
            idb.AddParameter("@HRental_Pay", 0);
         }
         else
         {
            idb.AddParameter("@HRental_Pay", house_Rental.HRental_Pay);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Company))
         {
            idb.AddParameter("@HRental_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Company", house_Rental.HRental_Company);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Dept))
         {
            idb.AddParameter("@HRental_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Dept", house_Rental.HRental_Dept);
         }
         if (house_Rental.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Rental.Stat);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Remark))
         {
            idb.AddParameter("@HRental_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Remark", house_Rental.HRental_Remark);
         }
         if (house_Rental.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Rental.CreateDate);
         }
         if (house_Rental.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Rental.UpdateDate);
         }
         if (house_Rental.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Rental.DeleteDate);
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
      /// 添加房屋租赁列表 House_Rental对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(House_Rental house_Rental)
      {
         string sql = "INSERT INTO House_Rental (HRental_Code,HRental_FileName,HRental_Rentor,HRental_Cost,HRental_Unit,HRental_BeginDate,HRental_EndDate,HRental_PayType,HRental_HouseName,HRental_HAddress,HRental_HType,HRental_HUsageType,HRental_NextPayDate,HRental_YearCost,HRental_Pay,HRental_Company,HRental_Dept,Stat,HRental_Remark,CreateDate,UpdateDate,DeleteDate) VALUES (@HRental_Code,@HRental_FileName,@HRental_Rentor,@HRental_Cost,@HRental_Unit,@HRental_BeginDate,@HRental_EndDate,@HRental_PayType,@HRental_HouseName,@HRental_HAddress,@HRental_HType,@HRental_HUsageType,@HRental_NextPayDate,@HRental_YearCost,@HRental_Pay,@HRental_Company,@HRental_Dept,@Stat,@HRental_Remark,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(house_Rental.HRental_Code))
         {
            idb.AddParameter("@HRental_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Code", house_Rental.HRental_Code);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_FileName))
         {
            idb.AddParameter("@HRental_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_FileName", house_Rental.HRental_FileName);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Rentor))
         {
            idb.AddParameter("@HRental_Rentor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Rentor", house_Rental.HRental_Rentor);
         }
         if (house_Rental.HRental_Cost == 0)
         {
            idb.AddParameter("@HRental_Cost", 0);
         }
         else
         {
            idb.AddParameter("@HRental_Cost", house_Rental.HRental_Cost);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Unit))
         {
            idb.AddParameter("@HRental_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Unit", house_Rental.HRental_Unit);
         }
         if (house_Rental.HRental_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_BeginDate", house_Rental.HRental_BeginDate);
         }
         if (house_Rental.HRental_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_EndDate", house_Rental.HRental_EndDate);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_PayType))
         {
            idb.AddParameter("@HRental_PayType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_PayType", house_Rental.HRental_PayType);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HouseName))
         {
            idb.AddParameter("@HRental_HouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HouseName", house_Rental.HRental_HouseName);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HAddress))
         {
            idb.AddParameter("@HRental_HAddress", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HAddress", house_Rental.HRental_HAddress);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HType))
         {
            idb.AddParameter("@HRental_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HType", house_Rental.HRental_HType);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_HUsageType))
         {
            idb.AddParameter("@HRental_HUsageType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HUsageType", house_Rental.HRental_HUsageType);
         }
         if (house_Rental.HRental_NextPayDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_NextPayDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_NextPayDate", house_Rental.HRental_NextPayDate);
         }
         if (house_Rental.HRental_YearCost == 0)
         {
            idb.AddParameter("@HRental_YearCost", 0);
         }
         else
         {
            idb.AddParameter("@HRental_YearCost", house_Rental.HRental_YearCost);
         }
         if (house_Rental.HRental_Pay == 0)
         {
            idb.AddParameter("@HRental_Pay", 0);
         }
         else
         {
            idb.AddParameter("@HRental_Pay", house_Rental.HRental_Pay);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Company))
         {
            idb.AddParameter("@HRental_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Company", house_Rental.HRental_Company);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Dept))
         {
            idb.AddParameter("@HRental_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Dept", house_Rental.HRental_Dept);
         }
         if (house_Rental.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Rental.Stat);
         }
         if (string.IsNullOrEmpty(house_Rental.HRental_Remark))
         {
            idb.AddParameter("@HRental_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Remark", house_Rental.HRental_Remark);
         }
         if (house_Rental.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Rental.CreateDate);
         }
         if (house_Rental.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Rental.UpdateDate);
         }
         if (house_Rental.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Rental.DeleteDate);
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
      /// 更新房屋租赁列表 House_Rental对象(即:一条记录
      /// </summary>
      public int Update(House_Rental house_Rental)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       House_Rental       SET ");
            if(house_Rental.HRental_Code_IsChanged){sbParameter.Append("HRental_Code=@HRental_Code, ");}
      if(house_Rental.HRental_FileName_IsChanged){sbParameter.Append("HRental_FileName=@HRental_FileName, ");}
      if(house_Rental.HRental_Rentor_IsChanged){sbParameter.Append("HRental_Rentor=@HRental_Rentor, ");}
      if(house_Rental.HRental_Cost_IsChanged){sbParameter.Append("HRental_Cost=@HRental_Cost, ");}
      if(house_Rental.HRental_Unit_IsChanged){sbParameter.Append("HRental_Unit=@HRental_Unit, ");}
      if(house_Rental.HRental_BeginDate_IsChanged){sbParameter.Append("HRental_BeginDate=@HRental_BeginDate, ");}
      if(house_Rental.HRental_EndDate_IsChanged){sbParameter.Append("HRental_EndDate=@HRental_EndDate, ");}
      if(house_Rental.HRental_PayType_IsChanged){sbParameter.Append("HRental_PayType=@HRental_PayType, ");}
      if(house_Rental.HRental_HouseName_IsChanged){sbParameter.Append("HRental_HouseName=@HRental_HouseName, ");}
      if(house_Rental.HRental_HAddress_IsChanged){sbParameter.Append("HRental_HAddress=@HRental_HAddress, ");}
      if(house_Rental.HRental_HType_IsChanged){sbParameter.Append("HRental_HType=@HRental_HType, ");}
      if(house_Rental.HRental_HUsageType_IsChanged){sbParameter.Append("HRental_HUsageType=@HRental_HUsageType, ");}
      if(house_Rental.HRental_NextPayDate_IsChanged){sbParameter.Append("HRental_NextPayDate=@HRental_NextPayDate, ");}
      if(house_Rental.HRental_YearCost_IsChanged){sbParameter.Append("HRental_YearCost=@HRental_YearCost, ");}
      if(house_Rental.HRental_Pay_IsChanged){sbParameter.Append("HRental_Pay=@HRental_Pay, ");}
      if(house_Rental.HRental_Company_IsChanged){sbParameter.Append("HRental_Company=@HRental_Company, ");}
      if(house_Rental.HRental_Dept_IsChanged){sbParameter.Append("HRental_Dept=@HRental_Dept, ");}
      if(house_Rental.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(house_Rental.HRental_Remark_IsChanged){sbParameter.Append("HRental_Remark=@HRental_Remark, ");}
      if(house_Rental.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(house_Rental.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(house_Rental.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and HRental_ID=@HRental_ID; " );
      string sql=sb.ToString();
         if(house_Rental.HRental_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_Code))
         {
            idb.AddParameter("@HRental_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Code", house_Rental.HRental_Code);
         }
          }
         if(house_Rental.HRental_FileName_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_FileName))
         {
            idb.AddParameter("@HRental_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_FileName", house_Rental.HRental_FileName);
         }
          }
         if(house_Rental.HRental_Rentor_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_Rentor))
         {
            idb.AddParameter("@HRental_Rentor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Rentor", house_Rental.HRental_Rentor);
         }
          }
         if(house_Rental.HRental_Cost_IsChanged)
         {
         if (house_Rental.HRental_Cost == 0)
         {
            idb.AddParameter("@HRental_Cost", 0);
         }
         else
         {
            idb.AddParameter("@HRental_Cost", house_Rental.HRental_Cost);
         }
          }
         if(house_Rental.HRental_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_Unit))
         {
            idb.AddParameter("@HRental_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Unit", house_Rental.HRental_Unit);
         }
          }
         if(house_Rental.HRental_BeginDate_IsChanged)
         {
         if (house_Rental.HRental_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_BeginDate", house_Rental.HRental_BeginDate);
         }
          }
         if(house_Rental.HRental_EndDate_IsChanged)
         {
         if (house_Rental.HRental_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_EndDate", house_Rental.HRental_EndDate);
         }
          }
         if(house_Rental.HRental_PayType_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_PayType))
         {
            idb.AddParameter("@HRental_PayType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_PayType", house_Rental.HRental_PayType);
         }
          }
         if(house_Rental.HRental_HouseName_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_HouseName))
         {
            idb.AddParameter("@HRental_HouseName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HouseName", house_Rental.HRental_HouseName);
         }
          }
         if(house_Rental.HRental_HAddress_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_HAddress))
         {
            idb.AddParameter("@HRental_HAddress", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HAddress", house_Rental.HRental_HAddress);
         }
          }
         if(house_Rental.HRental_HType_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_HType))
         {
            idb.AddParameter("@HRental_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HType", house_Rental.HRental_HType);
         }
          }
         if(house_Rental.HRental_HUsageType_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_HUsageType))
         {
            idb.AddParameter("@HRental_HUsageType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_HUsageType", house_Rental.HRental_HUsageType);
         }
          }
         if(house_Rental.HRental_NextPayDate_IsChanged)
         {
         if (house_Rental.HRental_NextPayDate == DateTime.MinValue)
         {
            idb.AddParameter("@HRental_NextPayDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_NextPayDate", house_Rental.HRental_NextPayDate);
         }
          }
         if(house_Rental.HRental_YearCost_IsChanged)
         {
         if (house_Rental.HRental_YearCost == 0)
         {
            idb.AddParameter("@HRental_YearCost", 0);
         }
         else
         {
            idb.AddParameter("@HRental_YearCost", house_Rental.HRental_YearCost);
         }
          }
         if(house_Rental.HRental_Pay_IsChanged)
         {
         if (house_Rental.HRental_Pay == 0)
         {
            idb.AddParameter("@HRental_Pay", 0);
         }
         else
         {
            idb.AddParameter("@HRental_Pay", house_Rental.HRental_Pay);
         }
          }
         if(house_Rental.HRental_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_Company))
         {
            idb.AddParameter("@HRental_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Company", house_Rental.HRental_Company);
         }
          }
         if(house_Rental.HRental_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_Dept))
         {
            idb.AddParameter("@HRental_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Dept", house_Rental.HRental_Dept);
         }
          }
         if(house_Rental.Stat_IsChanged)
         {
         if (house_Rental.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Rental.Stat);
         }
          }
         if(house_Rental.HRental_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Rental.HRental_Remark))
         {
            idb.AddParameter("@HRental_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Remark", house_Rental.HRental_Remark);
         }
          }
         if(house_Rental.CreateDate_IsChanged)
         {
         if (house_Rental.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Rental.CreateDate);
         }
          }
         if(house_Rental.UpdateDate_IsChanged)
         {
         if (house_Rental.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Rental.UpdateDate);
         }
          }
         if(house_Rental.DeleteDate_IsChanged)
         {
         if (house_Rental.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Rental.DeleteDate);
         }
          }

         idb.AddParameter("@HRental_ID", house_Rental.HRental_ID);

           
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
      /// 删除房屋租赁列表 House_Rental对象(即:一条记录
      /// </summary>
      public int Delete(decimal hRental_ID)
      {
         string sql = "DELETE House_Rental WHERE 1=1  AND HRental_ID=@HRental_ID ";
         idb.AddParameter("@HRental_ID", hRental_ID);

           
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
      /// 获取指定的房屋租赁列表 House_Rental对象(即:一条记录
      /// </summary>
      public House_Rental GetByKey(decimal hRental_ID)
      {
         House_Rental house_Rental = new House_Rental();
         string sql = "SELECT  HRental_ID,HRental_Code,HRental_FileName,HRental_Rentor,HRental_Cost,HRental_Unit,HRental_BeginDate,HRental_EndDate,HRental_PayType,HRental_HouseName,HRental_HAddress,HRental_HType,HRental_HUsageType,HRental_NextPayDate,HRental_YearCost,HRental_Pay,HRental_Company,HRental_Dept,Stat,HRental_Remark,CreateDate,UpdateDate,DeleteDate FROM House_Rental WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND HRental_ID=@HRental_ID ";
         idb.AddParameter("@HRental_ID", hRental_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["HRental_ID"] != DBNull.Value) house_Rental.HRental_ID = Convert.ToDecimal(dr["HRental_ID"]);
            if (dr["HRental_Code"] != DBNull.Value) house_Rental.HRental_Code = Convert.ToString(dr["HRental_Code"]);
            if (dr["HRental_FileName"] != DBNull.Value) house_Rental.HRental_FileName = Convert.ToString(dr["HRental_FileName"]);
            if (dr["HRental_Rentor"] != DBNull.Value) house_Rental.HRental_Rentor = Convert.ToString(dr["HRental_Rentor"]);
            if (dr["HRental_Cost"] != DBNull.Value) house_Rental.HRental_Cost = Convert.ToDecimal(dr["HRental_Cost"]);
            if (dr["HRental_Unit"] != DBNull.Value) house_Rental.HRental_Unit = Convert.ToString(dr["HRental_Unit"]);
            if (dr["HRental_BeginDate"] != DBNull.Value) house_Rental.HRental_BeginDate = Convert.ToDateTime(dr["HRental_BeginDate"]);
            if (dr["HRental_EndDate"] != DBNull.Value) house_Rental.HRental_EndDate = Convert.ToDateTime(dr["HRental_EndDate"]);
            if (dr["HRental_PayType"] != DBNull.Value) house_Rental.HRental_PayType = Convert.ToString(dr["HRental_PayType"]);
            if (dr["HRental_HouseName"] != DBNull.Value) house_Rental.HRental_HouseName = Convert.ToString(dr["HRental_HouseName"]);
            if (dr["HRental_HAddress"] != DBNull.Value) house_Rental.HRental_HAddress = Convert.ToString(dr["HRental_HAddress"]);
            if (dr["HRental_HType"] != DBNull.Value) house_Rental.HRental_HType = Convert.ToString(dr["HRental_HType"]);
            if (dr["HRental_HUsageType"] != DBNull.Value) house_Rental.HRental_HUsageType = Convert.ToString(dr["HRental_HUsageType"]);
            if (dr["HRental_NextPayDate"] != DBNull.Value) house_Rental.HRental_NextPayDate = Convert.ToDateTime(dr["HRental_NextPayDate"]);
            if (dr["HRental_YearCost"] != DBNull.Value) house_Rental.HRental_YearCost = Convert.ToDecimal(dr["HRental_YearCost"]);
            if (dr["HRental_Pay"] != DBNull.Value) house_Rental.HRental_Pay = Convert.ToDecimal(dr["HRental_Pay"]);
            if (dr["HRental_Company"] != DBNull.Value) house_Rental.HRental_Company = Convert.ToString(dr["HRental_Company"]);
            if (dr["HRental_Dept"] != DBNull.Value) house_Rental.HRental_Dept = Convert.ToString(dr["HRental_Dept"]);
            if (dr["Stat"] != DBNull.Value) house_Rental.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["HRental_Remark"] != DBNull.Value) house_Rental.HRental_Remark = Convert.ToString(dr["HRental_Remark"]);
            if (dr["CreateDate"] != DBNull.Value) house_Rental.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Rental.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Rental.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return house_Rental;
      }
      /// <summary>
      /// 获取指定的房屋租赁列表 House_Rental对象集合
      /// </summary>
      public List<House_Rental> GetListByWhere(string strCondition)
      {
         List<House_Rental> ret = new List<House_Rental>();
         string sql = "SELECT  HRental_ID,HRental_Code,HRental_FileName,HRental_Rentor,HRental_Cost,HRental_Unit,HRental_BeginDate,HRental_EndDate,HRental_PayType,HRental_HouseName,HRental_HAddress,HRental_HType,HRental_HUsageType,HRental_NextPayDate,HRental_YearCost,HRental_Pay,HRental_Company,HRental_Dept,Stat,HRental_Remark,CreateDate,UpdateDate,DeleteDate FROM House_Rental WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            House_Rental house_Rental = new House_Rental();
            if (dr["HRental_ID"] != DBNull.Value) house_Rental.HRental_ID = Convert.ToDecimal(dr["HRental_ID"]);
            if (dr["HRental_Code"] != DBNull.Value) house_Rental.HRental_Code = Convert.ToString(dr["HRental_Code"]);
            if (dr["HRental_FileName"] != DBNull.Value) house_Rental.HRental_FileName = Convert.ToString(dr["HRental_FileName"]);
            if (dr["HRental_Rentor"] != DBNull.Value) house_Rental.HRental_Rentor = Convert.ToString(dr["HRental_Rentor"]);
            if (dr["HRental_Cost"] != DBNull.Value) house_Rental.HRental_Cost = Convert.ToDecimal(dr["HRental_Cost"]);
            if (dr["HRental_Unit"] != DBNull.Value) house_Rental.HRental_Unit = Convert.ToString(dr["HRental_Unit"]);
            if (dr["HRental_BeginDate"] != DBNull.Value) house_Rental.HRental_BeginDate = Convert.ToDateTime(dr["HRental_BeginDate"]);
            if (dr["HRental_EndDate"] != DBNull.Value) house_Rental.HRental_EndDate = Convert.ToDateTime(dr["HRental_EndDate"]);
            if (dr["HRental_PayType"] != DBNull.Value) house_Rental.HRental_PayType = Convert.ToString(dr["HRental_PayType"]);
            if (dr["HRental_HouseName"] != DBNull.Value) house_Rental.HRental_HouseName = Convert.ToString(dr["HRental_HouseName"]);
            if (dr["HRental_HAddress"] != DBNull.Value) house_Rental.HRental_HAddress = Convert.ToString(dr["HRental_HAddress"]);
            if (dr["HRental_HType"] != DBNull.Value) house_Rental.HRental_HType = Convert.ToString(dr["HRental_HType"]);
            if (dr["HRental_HUsageType"] != DBNull.Value) house_Rental.HRental_HUsageType = Convert.ToString(dr["HRental_HUsageType"]);
            if (dr["HRental_NextPayDate"] != DBNull.Value) house_Rental.HRental_NextPayDate = Convert.ToDateTime(dr["HRental_NextPayDate"]);
            if (dr["HRental_YearCost"] != DBNull.Value) house_Rental.HRental_YearCost = Convert.ToDecimal(dr["HRental_YearCost"]);
            if (dr["HRental_Pay"] != DBNull.Value) house_Rental.HRental_Pay = Convert.ToDecimal(dr["HRental_Pay"]);
            if (dr["HRental_Company"] != DBNull.Value) house_Rental.HRental_Company = Convert.ToString(dr["HRental_Company"]);
            if (dr["HRental_Dept"] != DBNull.Value) house_Rental.HRental_Dept = Convert.ToString(dr["HRental_Dept"]);
            if (dr["Stat"] != DBNull.Value) house_Rental.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["HRental_Remark"] != DBNull.Value) house_Rental.HRental_Remark = Convert.ToString(dr["HRental_Remark"]);
            if (dr["CreateDate"] != DBNull.Value) house_Rental.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Rental.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Rental.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(house_Rental);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的房屋租赁列表 House_Rental对象(即:一条记录
      /// </summary>
      public List<House_Rental> GetAll()
      {
         List<House_Rental> ret = new List<House_Rental>();
         string sql = "SELECT  HRental_ID,HRental_Code,HRental_FileName,HRental_Rentor,HRental_Cost,HRental_Unit,HRental_BeginDate,HRental_EndDate,HRental_PayType,HRental_HouseName,HRental_HAddress,HRental_HType,HRental_HUsageType,HRental_NextPayDate,HRental_YearCost,HRental_Pay,HRental_Company,HRental_Dept,Stat,HRental_Remark,CreateDate,UpdateDate,DeleteDate FROM House_Rental where 1=1 AND ((Stat is null) or (Stat=0) ) order by HRental_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            House_Rental house_Rental = new House_Rental();
            if (dr["HRental_ID"] != DBNull.Value) house_Rental.HRental_ID = Convert.ToDecimal(dr["HRental_ID"]);
            if (dr["HRental_Code"] != DBNull.Value) house_Rental.HRental_Code = Convert.ToString(dr["HRental_Code"]);
            if (dr["HRental_FileName"] != DBNull.Value) house_Rental.HRental_FileName = Convert.ToString(dr["HRental_FileName"]);
            if (dr["HRental_Rentor"] != DBNull.Value) house_Rental.HRental_Rentor = Convert.ToString(dr["HRental_Rentor"]);
            if (dr["HRental_Cost"] != DBNull.Value) house_Rental.HRental_Cost = Convert.ToDecimal(dr["HRental_Cost"]);
            if (dr["HRental_Unit"] != DBNull.Value) house_Rental.HRental_Unit = Convert.ToString(dr["HRental_Unit"]);
            if (dr["HRental_BeginDate"] != DBNull.Value) house_Rental.HRental_BeginDate = Convert.ToDateTime(dr["HRental_BeginDate"]);
            if (dr["HRental_EndDate"] != DBNull.Value) house_Rental.HRental_EndDate = Convert.ToDateTime(dr["HRental_EndDate"]);
            if (dr["HRental_PayType"] != DBNull.Value) house_Rental.HRental_PayType = Convert.ToString(dr["HRental_PayType"]);
            if (dr["HRental_HouseName"] != DBNull.Value) house_Rental.HRental_HouseName = Convert.ToString(dr["HRental_HouseName"]);
            if (dr["HRental_HAddress"] != DBNull.Value) house_Rental.HRental_HAddress = Convert.ToString(dr["HRental_HAddress"]);
            if (dr["HRental_HType"] != DBNull.Value) house_Rental.HRental_HType = Convert.ToString(dr["HRental_HType"]);
            if (dr["HRental_HUsageType"] != DBNull.Value) house_Rental.HRental_HUsageType = Convert.ToString(dr["HRental_HUsageType"]);
            if (dr["HRental_NextPayDate"] != DBNull.Value) house_Rental.HRental_NextPayDate = Convert.ToDateTime(dr["HRental_NextPayDate"]);
            if (dr["HRental_YearCost"] != DBNull.Value) house_Rental.HRental_YearCost = Convert.ToDecimal(dr["HRental_YearCost"]);
            if (dr["HRental_Pay"] != DBNull.Value) house_Rental.HRental_Pay = Convert.ToDecimal(dr["HRental_Pay"]);
            if (dr["HRental_Company"] != DBNull.Value) house_Rental.HRental_Company = Convert.ToString(dr["HRental_Company"]);
            if (dr["HRental_Dept"] != DBNull.Value) house_Rental.HRental_Dept = Convert.ToString(dr["HRental_Dept"]);
            if (dr["Stat"] != DBNull.Value) house_Rental.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["HRental_Remark"] != DBNull.Value) house_Rental.HRental_Remark = Convert.ToString(dr["HRental_Remark"]);
            if (dr["CreateDate"] != DBNull.Value) house_Rental.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Rental.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Rental.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(house_Rental);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
