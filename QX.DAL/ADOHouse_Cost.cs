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
   /// 房屋租赁费用明细
   /// </summary>
   [Serializable]
   public partial class ADOHouse_Cost
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加房屋租赁费用明细 House_Cost对象(即:一条记录)
      /// </summary>
      public int Add(House_Cost house_Cost)
      {
         string sql = "INSERT INTO House_Cost (HCost_Code,HCost_HRentalCode,HCost_HousePosition,HCost_PayMonth,HCost_CostName,HCost_CostCode,HCost_Cost,HCost_Remark,HCost_User,HCost_UseType,HCost_BeginDate,HCost_EndDate,Stat,CreateDate,UpdateDate,DeleteDate,HCost_Company,HCost_Dept) VALUES (@HCost_Code,@HCost_HRentalCode,@HCost_HousePosition,@HCost_PayMonth,@HCost_CostName,@HCost_CostCode,@HCost_Cost,@HCost_Remark,@HCost_User,@HCost_UseType,@HCost_BeginDate,@HCost_EndDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@HCost_Company,@HCost_Dept)";
         if (string.IsNullOrEmpty(house_Cost.HCost_Code))
         {
            idb.AddParameter("@HCost_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Code", house_Cost.HCost_Code);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_HRentalCode))
         {
            idb.AddParameter("@HCost_HRentalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_HRentalCode", house_Cost.HCost_HRentalCode);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_HousePosition))
         {
            idb.AddParameter("@HCost_HousePosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_HousePosition", house_Cost.HCost_HousePosition);
         }
         if (house_Cost.HCost_PayMonth == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_PayMonth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_PayMonth", house_Cost.HCost_PayMonth);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_CostName))
         {
            idb.AddParameter("@HCost_CostName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_CostName", house_Cost.HCost_CostName);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_CostCode))
         {
            idb.AddParameter("@HCost_CostCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_CostCode", house_Cost.HCost_CostCode);
         }
         if (house_Cost.HCost_Cost == 0)
         {
            idb.AddParameter("@HCost_Cost", 0);
         }
         else
         {
            idb.AddParameter("@HCost_Cost", house_Cost.HCost_Cost);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_Remark))
         {
            idb.AddParameter("@HCost_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Remark", house_Cost.HCost_Remark);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_User))
         {
            idb.AddParameter("@HCost_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_User", house_Cost.HCost_User);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_UseType))
         {
            idb.AddParameter("@HCost_UseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_UseType", house_Cost.HCost_UseType);
         }
         if (house_Cost.HCost_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_BeginDate", house_Cost.HCost_BeginDate);
         }
         if (house_Cost.HCost_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_EndDate", house_Cost.HCost_EndDate);
         }
         if (house_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Cost.Stat);
         }
         if (house_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Cost.CreateDate);
         }
         if (house_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Cost.UpdateDate);
         }
         if (house_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Cost.DeleteDate);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_Company))
         {
            idb.AddParameter("@HCost_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Company", house_Cost.HCost_Company);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_Dept))
         {
            idb.AddParameter("@HCost_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Dept", house_Cost.HCost_Dept);
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
      /// 添加房屋租赁费用明细 House_Cost对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(House_Cost house_Cost)
      {
         string sql = "INSERT INTO House_Cost (HCost_Code,HCost_HRentalCode,HCost_HousePosition,HCost_PayMonth,HCost_CostName,HCost_CostCode,HCost_Cost,HCost_Remark,HCost_User,HCost_UseType,HCost_BeginDate,HCost_EndDate,Stat,CreateDate,UpdateDate,DeleteDate,HCost_Company,HCost_Dept) VALUES (@HCost_Code,@HCost_HRentalCode,@HCost_HousePosition,@HCost_PayMonth,@HCost_CostName,@HCost_CostCode,@HCost_Cost,@HCost_Remark,@HCost_User,@HCost_UseType,@HCost_BeginDate,@HCost_EndDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@HCost_Company,@HCost_Dept);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(house_Cost.HCost_Code))
         {
            idb.AddParameter("@HCost_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Code", house_Cost.HCost_Code);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_HRentalCode))
         {
            idb.AddParameter("@HCost_HRentalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_HRentalCode", house_Cost.HCost_HRentalCode);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_HousePosition))
         {
            idb.AddParameter("@HCost_HousePosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_HousePosition", house_Cost.HCost_HousePosition);
         }
         if (house_Cost.HCost_PayMonth == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_PayMonth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_PayMonth", house_Cost.HCost_PayMonth);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_CostName))
         {
            idb.AddParameter("@HCost_CostName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_CostName", house_Cost.HCost_CostName);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_CostCode))
         {
            idb.AddParameter("@HCost_CostCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_CostCode", house_Cost.HCost_CostCode);
         }
         if (house_Cost.HCost_Cost == 0)
         {
            idb.AddParameter("@HCost_Cost", 0);
         }
         else
         {
            idb.AddParameter("@HCost_Cost", house_Cost.HCost_Cost);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_Remark))
         {
            idb.AddParameter("@HCost_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Remark", house_Cost.HCost_Remark);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_User))
         {
            idb.AddParameter("@HCost_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_User", house_Cost.HCost_User);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_UseType))
         {
            idb.AddParameter("@HCost_UseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_UseType", house_Cost.HCost_UseType);
         }
         if (house_Cost.HCost_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_BeginDate", house_Cost.HCost_BeginDate);
         }
         if (house_Cost.HCost_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_EndDate", house_Cost.HCost_EndDate);
         }
         if (house_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Cost.Stat);
         }
         if (house_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Cost.CreateDate);
         }
         if (house_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Cost.UpdateDate);
         }
         if (house_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Cost.DeleteDate);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_Company))
         {
            idb.AddParameter("@HCost_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Company", house_Cost.HCost_Company);
         }
         if (string.IsNullOrEmpty(house_Cost.HCost_Dept))
         {
            idb.AddParameter("@HCost_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Dept", house_Cost.HCost_Dept);
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
      /// 更新房屋租赁费用明细 House_Cost对象(即:一条记录
      /// </summary>
      public int Update(House_Cost house_Cost)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       House_Cost       SET ");
            if(house_Cost.HCost_Code_IsChanged){sbParameter.Append("HCost_Code=@HCost_Code, ");}
      if(house_Cost.HCost_HRentalCode_IsChanged){sbParameter.Append("HCost_HRentalCode=@HCost_HRentalCode, ");}
      if(house_Cost.HCost_HousePosition_IsChanged){sbParameter.Append("HCost_HousePosition=@HCost_HousePosition, ");}
      if(house_Cost.HCost_PayMonth_IsChanged){sbParameter.Append("HCost_PayMonth=@HCost_PayMonth, ");}
      if(house_Cost.HCost_CostName_IsChanged){sbParameter.Append("HCost_CostName=@HCost_CostName, ");}
      if(house_Cost.HCost_CostCode_IsChanged){sbParameter.Append("HCost_CostCode=@HCost_CostCode, ");}
      if(house_Cost.HCost_Cost_IsChanged){sbParameter.Append("HCost_Cost=@HCost_Cost, ");}
      if(house_Cost.HCost_Remark_IsChanged){sbParameter.Append("HCost_Remark=@HCost_Remark, ");}
      if(house_Cost.HCost_User_IsChanged){sbParameter.Append("HCost_User=@HCost_User, ");}
      if(house_Cost.HCost_UseType_IsChanged){sbParameter.Append("HCost_UseType=@HCost_UseType, ");}
      if(house_Cost.HCost_BeginDate_IsChanged){sbParameter.Append("HCost_BeginDate=@HCost_BeginDate, ");}
      if(house_Cost.HCost_EndDate_IsChanged){sbParameter.Append("HCost_EndDate=@HCost_EndDate, ");}
      if(house_Cost.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(house_Cost.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(house_Cost.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(house_Cost.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(house_Cost.HCost_Company_IsChanged){sbParameter.Append("HCost_Company=@HCost_Company, ");}
      if(house_Cost.HCost_Dept_IsChanged){sbParameter.Append("HCost_Dept=@HCost_Dept ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and HCost_ID=@HCost_ID; " );
      string sql=sb.ToString();
         if(house_Cost.HCost_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_Code))
         {
            idb.AddParameter("@HCost_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Code", house_Cost.HCost_Code);
         }
          }
         if(house_Cost.HCost_HRentalCode_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_HRentalCode))
         {
            idb.AddParameter("@HCost_HRentalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_HRentalCode", house_Cost.HCost_HRentalCode);
         }
          }
         if(house_Cost.HCost_HousePosition_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_HousePosition))
         {
            idb.AddParameter("@HCost_HousePosition", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_HousePosition", house_Cost.HCost_HousePosition);
         }
          }
         if(house_Cost.HCost_PayMonth_IsChanged)
         {
         if (house_Cost.HCost_PayMonth == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_PayMonth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_PayMonth", house_Cost.HCost_PayMonth);
         }
          }
         if(house_Cost.HCost_CostName_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_CostName))
         {
            idb.AddParameter("@HCost_CostName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_CostName", house_Cost.HCost_CostName);
         }
          }
         if(house_Cost.HCost_CostCode_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_CostCode))
         {
            idb.AddParameter("@HCost_CostCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_CostCode", house_Cost.HCost_CostCode);
         }
          }
         if(house_Cost.HCost_Cost_IsChanged)
         {
         if (house_Cost.HCost_Cost == 0)
         {
            idb.AddParameter("@HCost_Cost", 0);
         }
         else
         {
            idb.AddParameter("@HCost_Cost", house_Cost.HCost_Cost);
         }
          }
         if(house_Cost.HCost_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_Remark))
         {
            idb.AddParameter("@HCost_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Remark", house_Cost.HCost_Remark);
         }
          }
         if(house_Cost.HCost_User_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_User))
         {
            idb.AddParameter("@HCost_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_User", house_Cost.HCost_User);
         }
          }
         if(house_Cost.HCost_UseType_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_UseType))
         {
            idb.AddParameter("@HCost_UseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_UseType", house_Cost.HCost_UseType);
         }
          }
         if(house_Cost.HCost_BeginDate_IsChanged)
         {
         if (house_Cost.HCost_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_BeginDate", house_Cost.HCost_BeginDate);
         }
          }
         if(house_Cost.HCost_EndDate_IsChanged)
         {
         if (house_Cost.HCost_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@HCost_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_EndDate", house_Cost.HCost_EndDate);
         }
          }
         if(house_Cost.Stat_IsChanged)
         {
         if (house_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", house_Cost.Stat);
         }
          }
         if(house_Cost.CreateDate_IsChanged)
         {
         if (house_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", house_Cost.CreateDate);
         }
          }
         if(house_Cost.UpdateDate_IsChanged)
         {
         if (house_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", house_Cost.UpdateDate);
         }
          }
         if(house_Cost.DeleteDate_IsChanged)
         {
         if (house_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", house_Cost.DeleteDate);
         }
          }
         if(house_Cost.HCost_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_Company))
         {
            idb.AddParameter("@HCost_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Company", house_Cost.HCost_Company);
         }
          }
         if(house_Cost.HCost_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(house_Cost.HCost_Dept))
         {
            idb.AddParameter("@HCost_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HCost_Dept", house_Cost.HCost_Dept);
         }
          }

         idb.AddParameter("@HCost_ID", house_Cost.HCost_ID);

           
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
      /// 删除房屋租赁费用明细 House_Cost对象(即:一条记录
      /// </summary>
      public int Delete(decimal hCost_ID)
      {
         string sql = "DELETE House_Cost WHERE 1=1  AND HCost_ID=@HCost_ID ";
         idb.AddParameter("@HCost_ID", hCost_ID);

           
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
      /// 获取指定的房屋租赁费用明细 House_Cost对象(即:一条记录
      /// </summary>
      public House_Cost GetByKey(decimal hCost_ID)
      {
         House_Cost house_Cost = new House_Cost();
         string sql = "SELECT  HCost_ID,HCost_Code,HCost_HRentalCode,HCost_HousePosition,HCost_PayMonth,HCost_CostName,HCost_CostCode,HCost_Cost,HCost_Remark,HCost_User,HCost_UseType,HCost_BeginDate,HCost_EndDate,Stat,CreateDate,UpdateDate,DeleteDate,HCost_Company,HCost_Dept FROM House_Cost WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND HCost_ID=@HCost_ID ";
         idb.AddParameter("@HCost_ID", hCost_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["HCost_ID"] != DBNull.Value) house_Cost.HCost_ID = Convert.ToDecimal(dr["HCost_ID"]);
            if (dr["HCost_Code"] != DBNull.Value) house_Cost.HCost_Code = Convert.ToString(dr["HCost_Code"]);
            if (dr["HCost_HRentalCode"] != DBNull.Value) house_Cost.HCost_HRentalCode = Convert.ToString(dr["HCost_HRentalCode"]);
            if (dr["HCost_HousePosition"] != DBNull.Value) house_Cost.HCost_HousePosition = Convert.ToString(dr["HCost_HousePosition"]);
            if (dr["HCost_PayMonth"] != DBNull.Value) house_Cost.HCost_PayMonth = Convert.ToDateTime(dr["HCost_PayMonth"]);
            if (dr["HCost_CostName"] != DBNull.Value) house_Cost.HCost_CostName = Convert.ToString(dr["HCost_CostName"]);
            if (dr["HCost_CostCode"] != DBNull.Value) house_Cost.HCost_CostCode = Convert.ToString(dr["HCost_CostCode"]);
            if (dr["HCost_Cost"] != DBNull.Value) house_Cost.HCost_Cost = Convert.ToDecimal(dr["HCost_Cost"]);
            if (dr["HCost_Remark"] != DBNull.Value) house_Cost.HCost_Remark = Convert.ToString(dr["HCost_Remark"]);
            if (dr["HCost_User"] != DBNull.Value) house_Cost.HCost_User = Convert.ToString(dr["HCost_User"]);
            if (dr["HCost_UseType"] != DBNull.Value) house_Cost.HCost_UseType = Convert.ToString(dr["HCost_UseType"]);
            if (dr["HCost_BeginDate"] != DBNull.Value) house_Cost.HCost_BeginDate = Convert.ToDateTime(dr["HCost_BeginDate"]);
            if (dr["HCost_EndDate"] != DBNull.Value) house_Cost.HCost_EndDate = Convert.ToDateTime(dr["HCost_EndDate"]);
            if (dr["Stat"] != DBNull.Value) house_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) house_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["HCost_Company"] != DBNull.Value) house_Cost.HCost_Company = Convert.ToString(dr["HCost_Company"]);
            if (dr["HCost_Dept"] != DBNull.Value) house_Cost.HCost_Dept = Convert.ToString(dr["HCost_Dept"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return house_Cost;
      }
      /// <summary>
      /// 获取指定的房屋租赁费用明细 House_Cost对象集合
      /// </summary>
      public List<House_Cost> GetListByWhere(string strCondition)
      {
         List<House_Cost> ret = new List<House_Cost>();
         string sql = "SELECT  HCost_ID,HCost_Code,HCost_HRentalCode,HCost_HousePosition,HCost_PayMonth,HCost_CostName,HCost_CostCode,HCost_Cost,HCost_Remark,HCost_User,HCost_UseType,HCost_BeginDate,HCost_EndDate,Stat,CreateDate,UpdateDate,DeleteDate,HCost_Company,HCost_Dept FROM House_Cost WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            House_Cost house_Cost = new House_Cost();
            if (dr["HCost_ID"] != DBNull.Value) house_Cost.HCost_ID = Convert.ToDecimal(dr["HCost_ID"]);
            if (dr["HCost_Code"] != DBNull.Value) house_Cost.HCost_Code = Convert.ToString(dr["HCost_Code"]);
            if (dr["HCost_HRentalCode"] != DBNull.Value) house_Cost.HCost_HRentalCode = Convert.ToString(dr["HCost_HRentalCode"]);
            if (dr["HCost_HousePosition"] != DBNull.Value) house_Cost.HCost_HousePosition = Convert.ToString(dr["HCost_HousePosition"]);
            if (dr["HCost_PayMonth"] != DBNull.Value) house_Cost.HCost_PayMonth = Convert.ToDateTime(dr["HCost_PayMonth"]);
            if (dr["HCost_CostName"] != DBNull.Value) house_Cost.HCost_CostName = Convert.ToString(dr["HCost_CostName"]);
            if (dr["HCost_CostCode"] != DBNull.Value) house_Cost.HCost_CostCode = Convert.ToString(dr["HCost_CostCode"]);
            if (dr["HCost_Cost"] != DBNull.Value) house_Cost.HCost_Cost = Convert.ToDecimal(dr["HCost_Cost"]);
            if (dr["HCost_Remark"] != DBNull.Value) house_Cost.HCost_Remark = Convert.ToString(dr["HCost_Remark"]);
            if (dr["HCost_User"] != DBNull.Value) house_Cost.HCost_User = Convert.ToString(dr["HCost_User"]);
            if (dr["HCost_UseType"] != DBNull.Value) house_Cost.HCost_UseType = Convert.ToString(dr["HCost_UseType"]);
            if (dr["HCost_BeginDate"] != DBNull.Value) house_Cost.HCost_BeginDate = Convert.ToDateTime(dr["HCost_BeginDate"]);
            if (dr["HCost_EndDate"] != DBNull.Value) house_Cost.HCost_EndDate = Convert.ToDateTime(dr["HCost_EndDate"]);
            if (dr["Stat"] != DBNull.Value) house_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) house_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["HCost_Company"] != DBNull.Value) house_Cost.HCost_Company = Convert.ToString(dr["HCost_Company"]);
            if (dr["HCost_Dept"] != DBNull.Value) house_Cost.HCost_Dept = Convert.ToString(dr["HCost_Dept"]);
            ret.Add(house_Cost);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的房屋租赁费用明细 House_Cost对象(即:一条记录
      /// </summary>
      public List<House_Cost> GetAll()
      {
         List<House_Cost> ret = new List<House_Cost>();
         string sql = "SELECT  HCost_ID,HCost_Code,HCost_HRentalCode,HCost_HousePosition,HCost_PayMonth,HCost_CostName,HCost_CostCode,HCost_Cost,HCost_Remark,HCost_User,HCost_UseType,HCost_BeginDate,HCost_EndDate,Stat,CreateDate,UpdateDate,DeleteDate,HCost_Company,HCost_Dept FROM House_Cost where 1=1 AND ((Stat is null) or (Stat=0) ) order by HCost_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            House_Cost house_Cost = new House_Cost();
            if (dr["HCost_ID"] != DBNull.Value) house_Cost.HCost_ID = Convert.ToDecimal(dr["HCost_ID"]);
            if (dr["HCost_Code"] != DBNull.Value) house_Cost.HCost_Code = Convert.ToString(dr["HCost_Code"]);
            if (dr["HCost_HRentalCode"] != DBNull.Value) house_Cost.HCost_HRentalCode = Convert.ToString(dr["HCost_HRentalCode"]);
            if (dr["HCost_HousePosition"] != DBNull.Value) house_Cost.HCost_HousePosition = Convert.ToString(dr["HCost_HousePosition"]);
            if (dr["HCost_PayMonth"] != DBNull.Value) house_Cost.HCost_PayMonth = Convert.ToDateTime(dr["HCost_PayMonth"]);
            if (dr["HCost_CostName"] != DBNull.Value) house_Cost.HCost_CostName = Convert.ToString(dr["HCost_CostName"]);
            if (dr["HCost_CostCode"] != DBNull.Value) house_Cost.HCost_CostCode = Convert.ToString(dr["HCost_CostCode"]);
            if (dr["HCost_Cost"] != DBNull.Value) house_Cost.HCost_Cost = Convert.ToDecimal(dr["HCost_Cost"]);
            if (dr["HCost_Remark"] != DBNull.Value) house_Cost.HCost_Remark = Convert.ToString(dr["HCost_Remark"]);
            if (dr["HCost_User"] != DBNull.Value) house_Cost.HCost_User = Convert.ToString(dr["HCost_User"]);
            if (dr["HCost_UseType"] != DBNull.Value) house_Cost.HCost_UseType = Convert.ToString(dr["HCost_UseType"]);
            if (dr["HCost_BeginDate"] != DBNull.Value) house_Cost.HCost_BeginDate = Convert.ToDateTime(dr["HCost_BeginDate"]);
            if (dr["HCost_EndDate"] != DBNull.Value) house_Cost.HCost_EndDate = Convert.ToDateTime(dr["HCost_EndDate"]);
            if (dr["Stat"] != DBNull.Value) house_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) house_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) house_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) house_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["HCost_Company"] != DBNull.Value) house_Cost.HCost_Company = Convert.ToString(dr["HCost_Company"]);
            if (dr["HCost_Dept"] != DBNull.Value) house_Cost.HCost_Dept = Convert.ToString(dr["HCost_Dept"]);
            ret.Add(house_Cost);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
