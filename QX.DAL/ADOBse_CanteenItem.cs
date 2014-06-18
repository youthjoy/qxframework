using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOBse_CanteenItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_CanteenItem对象(即:一条记录)
      /// </summary>
      public int Add(Bse_CanteenItem bse_CanteenItem)
      {
         string sql = "INSERT INTO Bse_CanteenItem (CanteenItem_Code,CanteenItem_Name,CanteenItem_Type,CanteenItem_Address,CanteenItem_Contractor,CanteenItem_Charger,CanteenItem_ChargerContact,CanteenItem_Remark,Stat,CreateDate,UpdateDate,DeleteDate,CanteenItem_Company,CanteenItem_Department,CanteenItem_Start,CanteenItem_End) VALUES (@CanteenItem_Code,@CanteenItem_Name,@CanteenItem_Type,@CanteenItem_Address,@CanteenItem_Contractor,@CanteenItem_Charger,@CanteenItem_ChargerContact,@CanteenItem_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@CanteenItem_Company,@CanteenItem_Department,@CanteenItem_Start,@CanteenItem_End)";
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Code))
         {
            idb.AddParameter("@CanteenItem_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Code", bse_CanteenItem.CanteenItem_Code);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Name))
         {
            idb.AddParameter("@CanteenItem_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Name", bse_CanteenItem.CanteenItem_Name);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Type))
         {
            idb.AddParameter("@CanteenItem_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Type", bse_CanteenItem.CanteenItem_Type);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Address))
         {
            idb.AddParameter("@CanteenItem_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Address", bse_CanteenItem.CanteenItem_Address);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Contractor))
         {
            idb.AddParameter("@CanteenItem_Contractor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Contractor", bse_CanteenItem.CanteenItem_Contractor);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Charger))
         {
            idb.AddParameter("@CanteenItem_Charger", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Charger", bse_CanteenItem.CanteenItem_Charger);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_ChargerContact))
         {
            idb.AddParameter("@CanteenItem_ChargerContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_ChargerContact", bse_CanteenItem.CanteenItem_ChargerContact);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Remark))
         {
            idb.AddParameter("@CanteenItem_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Remark", bse_CanteenItem.CanteenItem_Remark);
         }
         if (bse_CanteenItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CanteenItem.Stat);
         }
         if (bse_CanteenItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_CanteenItem.CreateDate);
         }
         if (bse_CanteenItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_CanteenItem.UpdateDate);
         }
         if (bse_CanteenItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_CanteenItem.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Company))
         {
            idb.AddParameter("@CanteenItem_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Company", bse_CanteenItem.CanteenItem_Company);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Department))
         {
            idb.AddParameter("@CanteenItem_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Department", bse_CanteenItem.CanteenItem_Department);
         }
         if (bse_CanteenItem.CanteenItem_Start == DateTime.MinValue)
         {
            idb.AddParameter("@CanteenItem_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Start", bse_CanteenItem.CanteenItem_Start);
         }
         if (bse_CanteenItem.CanteenItem_End == DateTime.MinValue)
         {
            idb.AddParameter("@CanteenItem_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_End", bse_CanteenItem.CanteenItem_End);
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
      /// 添加Bse_CanteenItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_CanteenItem bse_CanteenItem)
      {
         string sql = "INSERT INTO Bse_CanteenItem (CanteenItem_Code,CanteenItem_Name,CanteenItem_Type,CanteenItem_Address,CanteenItem_Contractor,CanteenItem_Charger,CanteenItem_ChargerContact,CanteenItem_Remark,Stat,CreateDate,UpdateDate,DeleteDate,CanteenItem_Company,CanteenItem_Department,CanteenItem_Start,CanteenItem_End) VALUES (@CanteenItem_Code,@CanteenItem_Name,@CanteenItem_Type,@CanteenItem_Address,@CanteenItem_Contractor,@CanteenItem_Charger,@CanteenItem_ChargerContact,@CanteenItem_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@CanteenItem_Company,@CanteenItem_Department,@CanteenItem_Start,@CanteenItem_End);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Code))
         {
            idb.AddParameter("@CanteenItem_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Code", bse_CanteenItem.CanteenItem_Code);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Name))
         {
            idb.AddParameter("@CanteenItem_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Name", bse_CanteenItem.CanteenItem_Name);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Type))
         {
            idb.AddParameter("@CanteenItem_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Type", bse_CanteenItem.CanteenItem_Type);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Address))
         {
            idb.AddParameter("@CanteenItem_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Address", bse_CanteenItem.CanteenItem_Address);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Contractor))
         {
            idb.AddParameter("@CanteenItem_Contractor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Contractor", bse_CanteenItem.CanteenItem_Contractor);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Charger))
         {
            idb.AddParameter("@CanteenItem_Charger", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Charger", bse_CanteenItem.CanteenItem_Charger);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_ChargerContact))
         {
            idb.AddParameter("@CanteenItem_ChargerContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_ChargerContact", bse_CanteenItem.CanteenItem_ChargerContact);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Remark))
         {
            idb.AddParameter("@CanteenItem_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Remark", bse_CanteenItem.CanteenItem_Remark);
         }
         if (bse_CanteenItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CanteenItem.Stat);
         }
         if (bse_CanteenItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_CanteenItem.CreateDate);
         }
         if (bse_CanteenItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_CanteenItem.UpdateDate);
         }
         if (bse_CanteenItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_CanteenItem.DeleteDate);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Company))
         {
            idb.AddParameter("@CanteenItem_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Company", bse_CanteenItem.CanteenItem_Company);
         }
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Department))
         {
            idb.AddParameter("@CanteenItem_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Department", bse_CanteenItem.CanteenItem_Department);
         }
         if (bse_CanteenItem.CanteenItem_Start == DateTime.MinValue)
         {
            idb.AddParameter("@CanteenItem_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Start", bse_CanteenItem.CanteenItem_Start);
         }
         if (bse_CanteenItem.CanteenItem_End == DateTime.MinValue)
         {
            idb.AddParameter("@CanteenItem_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_End", bse_CanteenItem.CanteenItem_End);
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
      /// 更新Bse_CanteenItem对象(即:一条记录
      /// </summary>
      public int Update(Bse_CanteenItem bse_CanteenItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_CanteenItem       SET ");
            if(bse_CanteenItem.CanteenItem_Code_IsChanged){sbParameter.Append("CanteenItem_Code=@CanteenItem_Code, ");}
      if(bse_CanteenItem.CanteenItem_Name_IsChanged){sbParameter.Append("CanteenItem_Name=@CanteenItem_Name, ");}
      if(bse_CanteenItem.CanteenItem_Type_IsChanged){sbParameter.Append("CanteenItem_Type=@CanteenItem_Type, ");}
      if(bse_CanteenItem.CanteenItem_Address_IsChanged){sbParameter.Append("CanteenItem_Address=@CanteenItem_Address, ");}
      if(bse_CanteenItem.CanteenItem_Contractor_IsChanged){sbParameter.Append("CanteenItem_Contractor=@CanteenItem_Contractor, ");}
      if(bse_CanteenItem.CanteenItem_Charger_IsChanged){sbParameter.Append("CanteenItem_Charger=@CanteenItem_Charger, ");}
      if(bse_CanteenItem.CanteenItem_ChargerContact_IsChanged){sbParameter.Append("CanteenItem_ChargerContact=@CanteenItem_ChargerContact, ");}
      if(bse_CanteenItem.CanteenItem_Remark_IsChanged){sbParameter.Append("CanteenItem_Remark=@CanteenItem_Remark, ");}
      if(bse_CanteenItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_CanteenItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bse_CanteenItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bse_CanteenItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(bse_CanteenItem.CanteenItem_Company_IsChanged){sbParameter.Append("CanteenItem_Company=@CanteenItem_Company, ");}
      if(bse_CanteenItem.CanteenItem_Department_IsChanged){sbParameter.Append("CanteenItem_Department=@CanteenItem_Department, ");}
      if(bse_CanteenItem.CanteenItem_Start_IsChanged){sbParameter.Append("CanteenItem_Start=@CanteenItem_Start, ");}
      if(bse_CanteenItem.CanteenItem_End_IsChanged){sbParameter.Append("CanteenItem_End=@CanteenItem_End ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CanteenItem_ID=@CanteenItem_ID; " );
      string sql=sb.ToString();
         if(bse_CanteenItem.CanteenItem_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Code))
         {
            idb.AddParameter("@CanteenItem_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Code", bse_CanteenItem.CanteenItem_Code);
         }
          }
         if(bse_CanteenItem.CanteenItem_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Name))
         {
            idb.AddParameter("@CanteenItem_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Name", bse_CanteenItem.CanteenItem_Name);
         }
          }
         if(bse_CanteenItem.CanteenItem_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Type))
         {
            idb.AddParameter("@CanteenItem_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Type", bse_CanteenItem.CanteenItem_Type);
         }
          }
         if(bse_CanteenItem.CanteenItem_Address_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Address))
         {
            idb.AddParameter("@CanteenItem_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Address", bse_CanteenItem.CanteenItem_Address);
         }
          }
         if(bse_CanteenItem.CanteenItem_Contractor_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Contractor))
         {
            idb.AddParameter("@CanteenItem_Contractor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Contractor", bse_CanteenItem.CanteenItem_Contractor);
         }
          }
         if(bse_CanteenItem.CanteenItem_Charger_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Charger))
         {
            idb.AddParameter("@CanteenItem_Charger", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Charger", bse_CanteenItem.CanteenItem_Charger);
         }
          }
         if(bse_CanteenItem.CanteenItem_ChargerContact_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_ChargerContact))
         {
            idb.AddParameter("@CanteenItem_ChargerContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_ChargerContact", bse_CanteenItem.CanteenItem_ChargerContact);
         }
          }
         if(bse_CanteenItem.CanteenItem_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Remark))
         {
            idb.AddParameter("@CanteenItem_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Remark", bse_CanteenItem.CanteenItem_Remark);
         }
          }
         if(bse_CanteenItem.Stat_IsChanged)
         {
         if (bse_CanteenItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CanteenItem.Stat);
         }
          }
         if(bse_CanteenItem.CreateDate_IsChanged)
         {
         if (bse_CanteenItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_CanteenItem.CreateDate);
         }
          }
         if(bse_CanteenItem.UpdateDate_IsChanged)
         {
         if (bse_CanteenItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_CanteenItem.UpdateDate);
         }
          }
         if(bse_CanteenItem.DeleteDate_IsChanged)
         {
         if (bse_CanteenItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_CanteenItem.DeleteDate);
         }
          }
         if(bse_CanteenItem.CanteenItem_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Company))
         {
            idb.AddParameter("@CanteenItem_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Company", bse_CanteenItem.CanteenItem_Company);
         }
          }
         if(bse_CanteenItem.CanteenItem_Department_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CanteenItem.CanteenItem_Department))
         {
            idb.AddParameter("@CanteenItem_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Department", bse_CanteenItem.CanteenItem_Department);
         }
          }
         if(bse_CanteenItem.CanteenItem_Start_IsChanged)
         {
         if (bse_CanteenItem.CanteenItem_Start == DateTime.MinValue)
         {
            idb.AddParameter("@CanteenItem_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_Start", bse_CanteenItem.CanteenItem_Start);
         }
          }
         if(bse_CanteenItem.CanteenItem_End_IsChanged)
         {
         if (bse_CanteenItem.CanteenItem_End == DateTime.MinValue)
         {
            idb.AddParameter("@CanteenItem_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CanteenItem_End", bse_CanteenItem.CanteenItem_End);
         }
          }

         idb.AddParameter("@CanteenItem_ID", bse_CanteenItem.CanteenItem_ID);

           
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
      /// 删除Bse_CanteenItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal canteenItem_ID)
      {
         string sql = "DELETE Bse_CanteenItem WHERE 1=1  AND CanteenItem_ID=@CanteenItem_ID ";
         idb.AddParameter("@CanteenItem_ID", canteenItem_ID);

           
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
      /// 获取指定的Bse_CanteenItem对象(即:一条记录
      /// </summary>
      public Bse_CanteenItem GetByKey(decimal canteenItem_ID)
      {
         Bse_CanteenItem bse_CanteenItem = new Bse_CanteenItem();
         string sql = "SELECT  CanteenItem_ID,CanteenItem_Code,CanteenItem_Name,CanteenItem_Type,CanteenItem_Address,CanteenItem_Contractor,CanteenItem_Charger,CanteenItem_ChargerContact,CanteenItem_Remark,Stat,CreateDate,UpdateDate,DeleteDate,CanteenItem_Company,CanteenItem_Department,CanteenItem_Start,CanteenItem_End FROM Bse_CanteenItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CanteenItem_ID=@CanteenItem_ID ";
         idb.AddParameter("@CanteenItem_ID", canteenItem_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CanteenItem_ID"] != DBNull.Value) bse_CanteenItem.CanteenItem_ID = Convert.ToDecimal(dr["CanteenItem_ID"]);
            if (dr["CanteenItem_Code"] != DBNull.Value) bse_CanteenItem.CanteenItem_Code = Convert.ToString(dr["CanteenItem_Code"]);
            if (dr["CanteenItem_Name"] != DBNull.Value) bse_CanteenItem.CanteenItem_Name = Convert.ToString(dr["CanteenItem_Name"]);
            if (dr["CanteenItem_Type"] != DBNull.Value) bse_CanteenItem.CanteenItem_Type = Convert.ToString(dr["CanteenItem_Type"]);
            if (dr["CanteenItem_Address"] != DBNull.Value) bse_CanteenItem.CanteenItem_Address = Convert.ToString(dr["CanteenItem_Address"]);
            if (dr["CanteenItem_Contractor"] != DBNull.Value) bse_CanteenItem.CanteenItem_Contractor = Convert.ToString(dr["CanteenItem_Contractor"]);
            if (dr["CanteenItem_Charger"] != DBNull.Value) bse_CanteenItem.CanteenItem_Charger = Convert.ToString(dr["CanteenItem_Charger"]);
            if (dr["CanteenItem_ChargerContact"] != DBNull.Value) bse_CanteenItem.CanteenItem_ChargerContact = Convert.ToString(dr["CanteenItem_ChargerContact"]);
            if (dr["CanteenItem_Remark"] != DBNull.Value) bse_CanteenItem.CanteenItem_Remark = Convert.ToString(dr["CanteenItem_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_CanteenItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_CanteenItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_CanteenItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_CanteenItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CanteenItem_Company"] != DBNull.Value) bse_CanteenItem.CanteenItem_Company = Convert.ToString(dr["CanteenItem_Company"]);
            if (dr["CanteenItem_Department"] != DBNull.Value) bse_CanteenItem.CanteenItem_Department = Convert.ToString(dr["CanteenItem_Department"]);
            if (dr["CanteenItem_Start"] != DBNull.Value) bse_CanteenItem.CanteenItem_Start = Convert.ToDateTime(dr["CanteenItem_Start"]);
            if (dr["CanteenItem_End"] != DBNull.Value) bse_CanteenItem.CanteenItem_End = Convert.ToDateTime(dr["CanteenItem_End"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_CanteenItem;
      }
      /// <summary>
      /// 获取指定的Bse_CanteenItem对象集合
      /// </summary>
      public List<Bse_CanteenItem> GetListByWhere(string strCondition)
      {
         List<Bse_CanteenItem> ret = new List<Bse_CanteenItem>();
         string sql = "SELECT  CanteenItem_ID,CanteenItem_Code,CanteenItem_Name,CanteenItem_Type,CanteenItem_Address,CanteenItem_Contractor,CanteenItem_Charger,CanteenItem_ChargerContact,CanteenItem_Remark,Stat,CreateDate,UpdateDate,DeleteDate,CanteenItem_Company,CanteenItem_Department,CanteenItem_Start,CanteenItem_End FROM Bse_CanteenItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_CanteenItem bse_CanteenItem = new Bse_CanteenItem();
            if (dr["CanteenItem_ID"] != DBNull.Value) bse_CanteenItem.CanteenItem_ID = Convert.ToDecimal(dr["CanteenItem_ID"]);
            if (dr["CanteenItem_Code"] != DBNull.Value) bse_CanteenItem.CanteenItem_Code = Convert.ToString(dr["CanteenItem_Code"]);
            if (dr["CanteenItem_Name"] != DBNull.Value) bse_CanteenItem.CanteenItem_Name = Convert.ToString(dr["CanteenItem_Name"]);
            if (dr["CanteenItem_Type"] != DBNull.Value) bse_CanteenItem.CanteenItem_Type = Convert.ToString(dr["CanteenItem_Type"]);
            if (dr["CanteenItem_Address"] != DBNull.Value) bse_CanteenItem.CanteenItem_Address = Convert.ToString(dr["CanteenItem_Address"]);
            if (dr["CanteenItem_Contractor"] != DBNull.Value) bse_CanteenItem.CanteenItem_Contractor = Convert.ToString(dr["CanteenItem_Contractor"]);
            if (dr["CanteenItem_Charger"] != DBNull.Value) bse_CanteenItem.CanteenItem_Charger = Convert.ToString(dr["CanteenItem_Charger"]);
            if (dr["CanteenItem_ChargerContact"] != DBNull.Value) bse_CanteenItem.CanteenItem_ChargerContact = Convert.ToString(dr["CanteenItem_ChargerContact"]);
            if (dr["CanteenItem_Remark"] != DBNull.Value) bse_CanteenItem.CanteenItem_Remark = Convert.ToString(dr["CanteenItem_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_CanteenItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_CanteenItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_CanteenItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_CanteenItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CanteenItem_Company"] != DBNull.Value) bse_CanteenItem.CanteenItem_Company = Convert.ToString(dr["CanteenItem_Company"]);
            if (dr["CanteenItem_Department"] != DBNull.Value) bse_CanteenItem.CanteenItem_Department = Convert.ToString(dr["CanteenItem_Department"]);
            if (dr["CanteenItem_Start"] != DBNull.Value) bse_CanteenItem.CanteenItem_Start = Convert.ToDateTime(dr["CanteenItem_Start"]);
            if (dr["CanteenItem_End"] != DBNull.Value) bse_CanteenItem.CanteenItem_End = Convert.ToDateTime(dr["CanteenItem_End"]);
            ret.Add(bse_CanteenItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_CanteenItem对象(即:一条记录
      /// </summary>
      public List<Bse_CanteenItem> GetAll()
      {
         List<Bse_CanteenItem> ret = new List<Bse_CanteenItem>();
         string sql = "SELECT  CanteenItem_ID,CanteenItem_Code,CanteenItem_Name,CanteenItem_Type,CanteenItem_Address,CanteenItem_Contractor,CanteenItem_Charger,CanteenItem_ChargerContact,CanteenItem_Remark,Stat,CreateDate,UpdateDate,DeleteDate,CanteenItem_Company,CanteenItem_Department,CanteenItem_Start,CanteenItem_End FROM Bse_CanteenItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by CanteenItem_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_CanteenItem bse_CanteenItem = new Bse_CanteenItem();
            if (dr["CanteenItem_ID"] != DBNull.Value) bse_CanteenItem.CanteenItem_ID = Convert.ToDecimal(dr["CanteenItem_ID"]);
            if (dr["CanteenItem_Code"] != DBNull.Value) bse_CanteenItem.CanteenItem_Code = Convert.ToString(dr["CanteenItem_Code"]);
            if (dr["CanteenItem_Name"] != DBNull.Value) bse_CanteenItem.CanteenItem_Name = Convert.ToString(dr["CanteenItem_Name"]);
            if (dr["CanteenItem_Type"] != DBNull.Value) bse_CanteenItem.CanteenItem_Type = Convert.ToString(dr["CanteenItem_Type"]);
            if (dr["CanteenItem_Address"] != DBNull.Value) bse_CanteenItem.CanteenItem_Address = Convert.ToString(dr["CanteenItem_Address"]);
            if (dr["CanteenItem_Contractor"] != DBNull.Value) bse_CanteenItem.CanteenItem_Contractor = Convert.ToString(dr["CanteenItem_Contractor"]);
            if (dr["CanteenItem_Charger"] != DBNull.Value) bse_CanteenItem.CanteenItem_Charger = Convert.ToString(dr["CanteenItem_Charger"]);
            if (dr["CanteenItem_ChargerContact"] != DBNull.Value) bse_CanteenItem.CanteenItem_ChargerContact = Convert.ToString(dr["CanteenItem_ChargerContact"]);
            if (dr["CanteenItem_Remark"] != DBNull.Value) bse_CanteenItem.CanteenItem_Remark = Convert.ToString(dr["CanteenItem_Remark"]);
            if (dr["Stat"] != DBNull.Value) bse_CanteenItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) bse_CanteenItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_CanteenItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_CanteenItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CanteenItem_Company"] != DBNull.Value) bse_CanteenItem.CanteenItem_Company = Convert.ToString(dr["CanteenItem_Company"]);
            if (dr["CanteenItem_Department"] != DBNull.Value) bse_CanteenItem.CanteenItem_Department = Convert.ToString(dr["CanteenItem_Department"]);
            if (dr["CanteenItem_Start"] != DBNull.Value) bse_CanteenItem.CanteenItem_Start = Convert.ToDateTime(dr["CanteenItem_Start"]);
            if (dr["CanteenItem_End"] != DBNull.Value) bse_CanteenItem.CanteenItem_End = Convert.ToDateTime(dr["CanteenItem_End"]);
            ret.Add(bse_CanteenItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
