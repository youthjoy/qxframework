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
   /// 车辆保险记录
   /// </summary>
   [Serializable]
   public partial class ADOVehicles_Insurance
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加车辆保险记录 Vehicles_Insurance对象(即:一条记录)
      /// </summary>
      public int Add(Vehicles_Insurance vehicles_Insurance)
      {
         string sql = "INSERT INTO Vehicles_Insurance (VInsurance_Code,VInsurance_VehiclesNo,VInsurance_Item,VInsurance_Cost,VInsurance_Amount,VInsurance_Operator,VInsurance_BeginDate,VInsurance_EndDate,VInsurance_DueDate,VInsurance_InsuranceCompany,VInsurance_Company,VInsurance_Dept,VInsurance_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VInsurance_itype) VALUES (@VInsurance_Code,@VInsurance_VehiclesNo,@VInsurance_Item,@VInsurance_Cost,@VInsurance_Amount,@VInsurance_Operator,@VInsurance_BeginDate,@VInsurance_EndDate,@VInsurance_DueDate,@VInsurance_InsuranceCompany,@VInsurance_Company,@VInsurance_Dept,@VInsurance_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VInsurance_itype)";
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Code))
         {
            idb.AddParameter("@VInsurance_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Code", vehicles_Insurance.VInsurance_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_VehiclesNo))
         {
            idb.AddParameter("@VInsurance_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_VehiclesNo", vehicles_Insurance.VInsurance_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Item))
         {
            idb.AddParameter("@VInsurance_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Item", vehicles_Insurance.VInsurance_Item);
         }
         if (vehicles_Insurance.VInsurance_Cost == 0)
         {
            idb.AddParameter("@VInsurance_Cost", 0);
         }
         else
         {
            idb.AddParameter("@VInsurance_Cost", vehicles_Insurance.VInsurance_Cost);
         }
         if (vehicles_Insurance.VInsurance_Amount == 0)
         {
            idb.AddParameter("@VInsurance_Amount", 0);
         }
         else
         {
            idb.AddParameter("@VInsurance_Amount", vehicles_Insurance.VInsurance_Amount);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Operator))
         {
            idb.AddParameter("@VInsurance_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Operator", vehicles_Insurance.VInsurance_Operator);
         }
         if (vehicles_Insurance.VInsurance_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_BeginDate", vehicles_Insurance.VInsurance_BeginDate);
         }
         if (vehicles_Insurance.VInsurance_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_EndDate", vehicles_Insurance.VInsurance_EndDate);
         }
         if (vehicles_Insurance.VInsurance_DueDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_DueDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_DueDate", vehicles_Insurance.VInsurance_DueDate);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_InsuranceCompany))
         {
            idb.AddParameter("@VInsurance_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_InsuranceCompany", vehicles_Insurance.VInsurance_InsuranceCompany);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Company))
         {
            idb.AddParameter("@VInsurance_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Company", vehicles_Insurance.VInsurance_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Dept))
         {
            idb.AddParameter("@VInsurance_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Dept", vehicles_Insurance.VInsurance_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Remark))
         {
            idb.AddParameter("@VInsurance_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Remark", vehicles_Insurance.VInsurance_Remark);
         }
         if (vehicles_Insurance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Insurance.Stat);
         }
         if (vehicles_Insurance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Insurance.CreateDate);
         }
         if (vehicles_Insurance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Insurance.UpdateDate);
         }
         if (vehicles_Insurance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Insurance.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_itype))
         {
            idb.AddParameter("@VInsurance_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_itype", vehicles_Insurance.VInsurance_itype);
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
      /// 添加车辆保险记录 Vehicles_Insurance对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Vehicles_Insurance vehicles_Insurance)
      {
         string sql = "INSERT INTO Vehicles_Insurance (VInsurance_Code,VInsurance_VehiclesNo,VInsurance_Item,VInsurance_Cost,VInsurance_Amount,VInsurance_Operator,VInsurance_BeginDate,VInsurance_EndDate,VInsurance_DueDate,VInsurance_InsuranceCompany,VInsurance_Company,VInsurance_Dept,VInsurance_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VInsurance_itype) VALUES (@VInsurance_Code,@VInsurance_VehiclesNo,@VInsurance_Item,@VInsurance_Cost,@VInsurance_Amount,@VInsurance_Operator,@VInsurance_BeginDate,@VInsurance_EndDate,@VInsurance_DueDate,@VInsurance_InsuranceCompany,@VInsurance_Company,@VInsurance_Dept,@VInsurance_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@VInsurance_itype);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Code))
         {
            idb.AddParameter("@VInsurance_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Code", vehicles_Insurance.VInsurance_Code);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_VehiclesNo))
         {
            idb.AddParameter("@VInsurance_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_VehiclesNo", vehicles_Insurance.VInsurance_VehiclesNo);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Item))
         {
            idb.AddParameter("@VInsurance_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Item", vehicles_Insurance.VInsurance_Item);
         }
         if (vehicles_Insurance.VInsurance_Cost == 0)
         {
            idb.AddParameter("@VInsurance_Cost", 0);
         }
         else
         {
            idb.AddParameter("@VInsurance_Cost", vehicles_Insurance.VInsurance_Cost);
         }
         if (vehicles_Insurance.VInsurance_Amount == 0)
         {
            idb.AddParameter("@VInsurance_Amount", 0);
         }
         else
         {
            idb.AddParameter("@VInsurance_Amount", vehicles_Insurance.VInsurance_Amount);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Operator))
         {
            idb.AddParameter("@VInsurance_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Operator", vehicles_Insurance.VInsurance_Operator);
         }
         if (vehicles_Insurance.VInsurance_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_BeginDate", vehicles_Insurance.VInsurance_BeginDate);
         }
         if (vehicles_Insurance.VInsurance_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_EndDate", vehicles_Insurance.VInsurance_EndDate);
         }
         if (vehicles_Insurance.VInsurance_DueDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_DueDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_DueDate", vehicles_Insurance.VInsurance_DueDate);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_InsuranceCompany))
         {
            idb.AddParameter("@VInsurance_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_InsuranceCompany", vehicles_Insurance.VInsurance_InsuranceCompany);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Company))
         {
            idb.AddParameter("@VInsurance_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Company", vehicles_Insurance.VInsurance_Company);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Dept))
         {
            idb.AddParameter("@VInsurance_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Dept", vehicles_Insurance.VInsurance_Dept);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Remark))
         {
            idb.AddParameter("@VInsurance_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Remark", vehicles_Insurance.VInsurance_Remark);
         }
         if (vehicles_Insurance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Insurance.Stat);
         }
         if (vehicles_Insurance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Insurance.CreateDate);
         }
         if (vehicles_Insurance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Insurance.UpdateDate);
         }
         if (vehicles_Insurance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Insurance.DeleteDate);
         }
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_itype))
         {
            idb.AddParameter("@VInsurance_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_itype", vehicles_Insurance.VInsurance_itype);
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
      /// 更新车辆保险记录 Vehicles_Insurance对象(即:一条记录
      /// </summary>
      public int Update(Vehicles_Insurance vehicles_Insurance)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Vehicles_Insurance       SET ");
            if(vehicles_Insurance.VInsurance_Code_IsChanged){sbParameter.Append("VInsurance_Code=@VInsurance_Code, ");}
      if(vehicles_Insurance.VInsurance_VehiclesNo_IsChanged){sbParameter.Append("VInsurance_VehiclesNo=@VInsurance_VehiclesNo, ");}
      if(vehicles_Insurance.VInsurance_Item_IsChanged){sbParameter.Append("VInsurance_Item=@VInsurance_Item, ");}
      if(vehicles_Insurance.VInsurance_Cost_IsChanged){sbParameter.Append("VInsurance_Cost=@VInsurance_Cost, ");}
      if(vehicles_Insurance.VInsurance_Amount_IsChanged){sbParameter.Append("VInsurance_Amount=@VInsurance_Amount, ");}
      if(vehicles_Insurance.VInsurance_Operator_IsChanged){sbParameter.Append("VInsurance_Operator=@VInsurance_Operator, ");}
      if(vehicles_Insurance.VInsurance_BeginDate_IsChanged){sbParameter.Append("VInsurance_BeginDate=@VInsurance_BeginDate, ");}
      if(vehicles_Insurance.VInsurance_EndDate_IsChanged){sbParameter.Append("VInsurance_EndDate=@VInsurance_EndDate, ");}
      if(vehicles_Insurance.VInsurance_DueDate_IsChanged){sbParameter.Append("VInsurance_DueDate=@VInsurance_DueDate, ");}
      if(vehicles_Insurance.VInsurance_InsuranceCompany_IsChanged){sbParameter.Append("VInsurance_InsuranceCompany=@VInsurance_InsuranceCompany, ");}
      if(vehicles_Insurance.VInsurance_Company_IsChanged){sbParameter.Append("VInsurance_Company=@VInsurance_Company, ");}
      if(vehicles_Insurance.VInsurance_Dept_IsChanged){sbParameter.Append("VInsurance_Dept=@VInsurance_Dept, ");}
      if(vehicles_Insurance.VInsurance_Remark_IsChanged){sbParameter.Append("VInsurance_Remark=@VInsurance_Remark, ");}
      if(vehicles_Insurance.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(vehicles_Insurance.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(vehicles_Insurance.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(vehicles_Insurance.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(vehicles_Insurance.VInsurance_itype_IsChanged){sbParameter.Append("VInsurance_itype=@VInsurance_itype ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and VInsurance_ID=@VInsurance_ID; " );
      string sql=sb.ToString();
         if(vehicles_Insurance.VInsurance_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Code))
         {
            idb.AddParameter("@VInsurance_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Code", vehicles_Insurance.VInsurance_Code);
         }
          }
         if(vehicles_Insurance.VInsurance_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_VehiclesNo))
         {
            idb.AddParameter("@VInsurance_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_VehiclesNo", vehicles_Insurance.VInsurance_VehiclesNo);
         }
          }
         if(vehicles_Insurance.VInsurance_Item_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Item))
         {
            idb.AddParameter("@VInsurance_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Item", vehicles_Insurance.VInsurance_Item);
         }
          }
         if(vehicles_Insurance.VInsurance_Cost_IsChanged)
         {
         if (vehicles_Insurance.VInsurance_Cost == 0)
         {
            idb.AddParameter("@VInsurance_Cost", 0);
         }
         else
         {
            idb.AddParameter("@VInsurance_Cost", vehicles_Insurance.VInsurance_Cost);
         }
          }
         if(vehicles_Insurance.VInsurance_Amount_IsChanged)
         {
         if (vehicles_Insurance.VInsurance_Amount == 0)
         {
            idb.AddParameter("@VInsurance_Amount", 0);
         }
         else
         {
            idb.AddParameter("@VInsurance_Amount", vehicles_Insurance.VInsurance_Amount);
         }
          }
         if(vehicles_Insurance.VInsurance_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Operator))
         {
            idb.AddParameter("@VInsurance_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Operator", vehicles_Insurance.VInsurance_Operator);
         }
          }
         if(vehicles_Insurance.VInsurance_BeginDate_IsChanged)
         {
         if (vehicles_Insurance.VInsurance_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_BeginDate", vehicles_Insurance.VInsurance_BeginDate);
         }
          }
         if(vehicles_Insurance.VInsurance_EndDate_IsChanged)
         {
         if (vehicles_Insurance.VInsurance_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_EndDate", vehicles_Insurance.VInsurance_EndDate);
         }
          }
         if(vehicles_Insurance.VInsurance_DueDate_IsChanged)
         {
         if (vehicles_Insurance.VInsurance_DueDate == DateTime.MinValue)
         {
            idb.AddParameter("@VInsurance_DueDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_DueDate", vehicles_Insurance.VInsurance_DueDate);
         }
          }
         if(vehicles_Insurance.VInsurance_InsuranceCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_InsuranceCompany))
         {
            idb.AddParameter("@VInsurance_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_InsuranceCompany", vehicles_Insurance.VInsurance_InsuranceCompany);
         }
          }
         if(vehicles_Insurance.VInsurance_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Company))
         {
            idb.AddParameter("@VInsurance_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Company", vehicles_Insurance.VInsurance_Company);
         }
          }
         if(vehicles_Insurance.VInsurance_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Dept))
         {
            idb.AddParameter("@VInsurance_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Dept", vehicles_Insurance.VInsurance_Dept);
         }
          }
         if(vehicles_Insurance.VInsurance_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_Remark))
         {
            idb.AddParameter("@VInsurance_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_Remark", vehicles_Insurance.VInsurance_Remark);
         }
          }
         if(vehicles_Insurance.Stat_IsChanged)
         {
         if (vehicles_Insurance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", vehicles_Insurance.Stat);
         }
          }
         if(vehicles_Insurance.CreateDate_IsChanged)
         {
         if (vehicles_Insurance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", vehicles_Insurance.CreateDate);
         }
          }
         if(vehicles_Insurance.UpdateDate_IsChanged)
         {
         if (vehicles_Insurance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", vehicles_Insurance.UpdateDate);
         }
          }
         if(vehicles_Insurance.DeleteDate_IsChanged)
         {
         if (vehicles_Insurance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", vehicles_Insurance.DeleteDate);
         }
          }
         if(vehicles_Insurance.VInsurance_itype_IsChanged)
         {
         if (string.IsNullOrEmpty(vehicles_Insurance.VInsurance_itype))
         {
            idb.AddParameter("@VInsurance_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VInsurance_itype", vehicles_Insurance.VInsurance_itype);
         }
          }

         idb.AddParameter("@VInsurance_ID", vehicles_Insurance.VInsurance_ID);

           
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
      /// 删除车辆保险记录 Vehicles_Insurance对象(即:一条记录
      /// </summary>
      public int Delete(decimal vInsurance_ID)
      {
         string sql = "DELETE Vehicles_Insurance WHERE 1=1  AND VInsurance_ID=@VInsurance_ID ";
         idb.AddParameter("@VInsurance_ID", vInsurance_ID);

           
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
      /// 获取指定的车辆保险记录 Vehicles_Insurance对象(即:一条记录
      /// </summary>
      public Vehicles_Insurance GetByKey(decimal vInsurance_ID)
      {
         Vehicles_Insurance vehicles_Insurance = new Vehicles_Insurance();
         string sql = "SELECT  VInsurance_ID,VInsurance_Code,VInsurance_VehiclesNo,VInsurance_Item,VInsurance_Cost,VInsurance_Amount,VInsurance_Operator,VInsurance_BeginDate,VInsurance_EndDate,VInsurance_DueDate,VInsurance_InsuranceCompany,VInsurance_Company,VInsurance_Dept,VInsurance_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VInsurance_itype FROM Vehicles_Insurance WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND VInsurance_ID=@VInsurance_ID ";
         idb.AddParameter("@VInsurance_ID", vInsurance_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["VInsurance_ID"] != DBNull.Value) vehicles_Insurance.VInsurance_ID = Convert.ToDecimal(dr["VInsurance_ID"]);
            if (dr["VInsurance_Code"] != DBNull.Value) vehicles_Insurance.VInsurance_Code = Convert.ToString(dr["VInsurance_Code"]);
            if (dr["VInsurance_VehiclesNo"] != DBNull.Value) vehicles_Insurance.VInsurance_VehiclesNo = Convert.ToString(dr["VInsurance_VehiclesNo"]);
            if (dr["VInsurance_Item"] != DBNull.Value) vehicles_Insurance.VInsurance_Item = Convert.ToString(dr["VInsurance_Item"]);
            if (dr["VInsurance_Cost"] != DBNull.Value) vehicles_Insurance.VInsurance_Cost = Convert.ToDecimal(dr["VInsurance_Cost"]);
            if (dr["VInsurance_Amount"] != DBNull.Value) vehicles_Insurance.VInsurance_Amount = Convert.ToDecimal(dr["VInsurance_Amount"]);
            if (dr["VInsurance_Operator"] != DBNull.Value) vehicles_Insurance.VInsurance_Operator = Convert.ToString(dr["VInsurance_Operator"]);
            if (dr["VInsurance_BeginDate"] != DBNull.Value) vehicles_Insurance.VInsurance_BeginDate = Convert.ToDateTime(dr["VInsurance_BeginDate"]);
            if (dr["VInsurance_EndDate"] != DBNull.Value) vehicles_Insurance.VInsurance_EndDate = Convert.ToDateTime(dr["VInsurance_EndDate"]);
            if (dr["VInsurance_DueDate"] != DBNull.Value) vehicles_Insurance.VInsurance_DueDate = Convert.ToDateTime(dr["VInsurance_DueDate"]);
            if (dr["VInsurance_InsuranceCompany"] != DBNull.Value) vehicles_Insurance.VInsurance_InsuranceCompany = Convert.ToString(dr["VInsurance_InsuranceCompany"]);
            if (dr["VInsurance_Company"] != DBNull.Value) vehicles_Insurance.VInsurance_Company = Convert.ToString(dr["VInsurance_Company"]);
            if (dr["VInsurance_Dept"] != DBNull.Value) vehicles_Insurance.VInsurance_Dept = Convert.ToString(dr["VInsurance_Dept"]);
            if (dr["VInsurance_Remark"] != DBNull.Value) vehicles_Insurance.VInsurance_Remark = Convert.ToString(dr["VInsurance_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Insurance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Insurance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Insurance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Insurance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VInsurance_itype"] != DBNull.Value) vehicles_Insurance.VInsurance_itype = Convert.ToString(dr["VInsurance_itype"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return vehicles_Insurance;
      }
      /// <summary>
      /// 获取指定的车辆保险记录 Vehicles_Insurance对象集合
      /// </summary>
      public List<Vehicles_Insurance> GetListByWhere(string strCondition)
      {
         List<Vehicles_Insurance> ret = new List<Vehicles_Insurance>();
         string sql = "SELECT  VInsurance_ID,VInsurance_Code,VInsurance_VehiclesNo,VInsurance_Item,VInsurance_Cost,VInsurance_Amount,VInsurance_Operator,VInsurance_BeginDate,VInsurance_EndDate,VInsurance_DueDate,VInsurance_InsuranceCompany,VInsurance_Company,VInsurance_Dept,VInsurance_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VInsurance_itype FROM Vehicles_Insurance WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Vehicles_Insurance vehicles_Insurance = new Vehicles_Insurance();
            if (dr["VInsurance_ID"] != DBNull.Value) vehicles_Insurance.VInsurance_ID = Convert.ToDecimal(dr["VInsurance_ID"]);
            if (dr["VInsurance_Code"] != DBNull.Value) vehicles_Insurance.VInsurance_Code = Convert.ToString(dr["VInsurance_Code"]);
            if (dr["VInsurance_VehiclesNo"] != DBNull.Value) vehicles_Insurance.VInsurance_VehiclesNo = Convert.ToString(dr["VInsurance_VehiclesNo"]);
            if (dr["VInsurance_Item"] != DBNull.Value) vehicles_Insurance.VInsurance_Item = Convert.ToString(dr["VInsurance_Item"]);
            if (dr["VInsurance_Cost"] != DBNull.Value) vehicles_Insurance.VInsurance_Cost = Convert.ToDecimal(dr["VInsurance_Cost"]);
            if (dr["VInsurance_Amount"] != DBNull.Value) vehicles_Insurance.VInsurance_Amount = Convert.ToDecimal(dr["VInsurance_Amount"]);
            if (dr["VInsurance_Operator"] != DBNull.Value) vehicles_Insurance.VInsurance_Operator = Convert.ToString(dr["VInsurance_Operator"]);
            if (dr["VInsurance_BeginDate"] != DBNull.Value) vehicles_Insurance.VInsurance_BeginDate = Convert.ToDateTime(dr["VInsurance_BeginDate"]);
            if (dr["VInsurance_EndDate"] != DBNull.Value) vehicles_Insurance.VInsurance_EndDate = Convert.ToDateTime(dr["VInsurance_EndDate"]);
            if (dr["VInsurance_DueDate"] != DBNull.Value) vehicles_Insurance.VInsurance_DueDate = Convert.ToDateTime(dr["VInsurance_DueDate"]);
            if (dr["VInsurance_InsuranceCompany"] != DBNull.Value) vehicles_Insurance.VInsurance_InsuranceCompany = Convert.ToString(dr["VInsurance_InsuranceCompany"]);
            if (dr["VInsurance_Company"] != DBNull.Value) vehicles_Insurance.VInsurance_Company = Convert.ToString(dr["VInsurance_Company"]);
            if (dr["VInsurance_Dept"] != DBNull.Value) vehicles_Insurance.VInsurance_Dept = Convert.ToString(dr["VInsurance_Dept"]);
            if (dr["VInsurance_Remark"] != DBNull.Value) vehicles_Insurance.VInsurance_Remark = Convert.ToString(dr["VInsurance_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Insurance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Insurance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Insurance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Insurance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VInsurance_itype"] != DBNull.Value) vehicles_Insurance.VInsurance_itype = Convert.ToString(dr["VInsurance_itype"]);
            ret.Add(vehicles_Insurance);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的车辆保险记录 Vehicles_Insurance对象(即:一条记录
      /// </summary>
      public List<Vehicles_Insurance> GetAll()
      {
         List<Vehicles_Insurance> ret = new List<Vehicles_Insurance>();
         string sql = "SELECT  VInsurance_ID,VInsurance_Code,VInsurance_VehiclesNo,VInsurance_Item,VInsurance_Cost,VInsurance_Amount,VInsurance_Operator,VInsurance_BeginDate,VInsurance_EndDate,VInsurance_DueDate,VInsurance_InsuranceCompany,VInsurance_Company,VInsurance_Dept,VInsurance_Remark,Stat,CreateDate,UpdateDate,DeleteDate,VInsurance_itype FROM Vehicles_Insurance where 1=1 AND ((Stat is null) or (Stat=0) ) order by VInsurance_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Vehicles_Insurance vehicles_Insurance = new Vehicles_Insurance();
            if (dr["VInsurance_ID"] != DBNull.Value) vehicles_Insurance.VInsurance_ID = Convert.ToDecimal(dr["VInsurance_ID"]);
            if (dr["VInsurance_Code"] != DBNull.Value) vehicles_Insurance.VInsurance_Code = Convert.ToString(dr["VInsurance_Code"]);
            if (dr["VInsurance_VehiclesNo"] != DBNull.Value) vehicles_Insurance.VInsurance_VehiclesNo = Convert.ToString(dr["VInsurance_VehiclesNo"]);
            if (dr["VInsurance_Item"] != DBNull.Value) vehicles_Insurance.VInsurance_Item = Convert.ToString(dr["VInsurance_Item"]);
            if (dr["VInsurance_Cost"] != DBNull.Value) vehicles_Insurance.VInsurance_Cost = Convert.ToDecimal(dr["VInsurance_Cost"]);
            if (dr["VInsurance_Amount"] != DBNull.Value) vehicles_Insurance.VInsurance_Amount = Convert.ToDecimal(dr["VInsurance_Amount"]);
            if (dr["VInsurance_Operator"] != DBNull.Value) vehicles_Insurance.VInsurance_Operator = Convert.ToString(dr["VInsurance_Operator"]);
            if (dr["VInsurance_BeginDate"] != DBNull.Value) vehicles_Insurance.VInsurance_BeginDate = Convert.ToDateTime(dr["VInsurance_BeginDate"]);
            if (dr["VInsurance_EndDate"] != DBNull.Value) vehicles_Insurance.VInsurance_EndDate = Convert.ToDateTime(dr["VInsurance_EndDate"]);
            if (dr["VInsurance_DueDate"] != DBNull.Value) vehicles_Insurance.VInsurance_DueDate = Convert.ToDateTime(dr["VInsurance_DueDate"]);
            if (dr["VInsurance_InsuranceCompany"] != DBNull.Value) vehicles_Insurance.VInsurance_InsuranceCompany = Convert.ToString(dr["VInsurance_InsuranceCompany"]);
            if (dr["VInsurance_Company"] != DBNull.Value) vehicles_Insurance.VInsurance_Company = Convert.ToString(dr["VInsurance_Company"]);
            if (dr["VInsurance_Dept"] != DBNull.Value) vehicles_Insurance.VInsurance_Dept = Convert.ToString(dr["VInsurance_Dept"]);
            if (dr["VInsurance_Remark"] != DBNull.Value) vehicles_Insurance.VInsurance_Remark = Convert.ToString(dr["VInsurance_Remark"]);
            if (dr["Stat"] != DBNull.Value) vehicles_Insurance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) vehicles_Insurance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) vehicles_Insurance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) vehicles_Insurance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["VInsurance_itype"] != DBNull.Value) vehicles_Insurance.VInsurance_itype = Convert.ToString(dr["VInsurance_itype"]);
            ret.Add(vehicles_Insurance);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
