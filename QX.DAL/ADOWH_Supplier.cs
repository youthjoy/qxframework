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
   /// 供应商信息
   /// </summary>
   [Serializable]
   public partial class ADOWH_Supplier
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加供应商信息 WH_Supplier对象(即:一条记录)
      /// </summary>
      public int Add(WH_Supplier wH_Supplier)
      {
         string sql = "INSERT INTO WH_Supplier (WHS_CustCode,WHS_CustName,WHS_Group,WHS_Property,WHS_Aptitude,WHS_LegalPerson,WHS_ContactPerson,WHS_Telphone,WHS_MobilePhone,WHS_Fax,WHS_Email,WHS_Site,WHS_ZipCode,WHS_Introduction,WHS_iType,Stat,CreateDate,UpdateDate,DeleteDate,WHS_Capital,WHS_Levy,WHS_UName,WHS_Raddress,WHS_RBegin,WHS_End,WHS_Taxroar,WHS_Cdegree) VALUES (@WHS_CustCode,@WHS_CustName,@WHS_Group,@WHS_Property,@WHS_Aptitude,@WHS_LegalPerson,@WHS_ContactPerson,@WHS_Telphone,@WHS_MobilePhone,@WHS_Fax,@WHS_Email,@WHS_Site,@WHS_ZipCode,@WHS_Introduction,@WHS_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHS_Capital,@WHS_Levy,@WHS_UName,@WHS_Raddress,@WHS_RBegin,@WHS_End,@WHS_Taxroar,@WHS_Cdegree)";
         if (string.IsNullOrEmpty(wH_Supplier.WHS_CustCode))
         {
            idb.AddParameter("@WHS_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_CustCode", wH_Supplier.WHS_CustCode);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_CustName))
         {
            idb.AddParameter("@WHS_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_CustName", wH_Supplier.WHS_CustName);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Group))
         {
            idb.AddParameter("@WHS_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Group", wH_Supplier.WHS_Group);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Property))
         {
            idb.AddParameter("@WHS_Property", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Property", wH_Supplier.WHS_Property);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Aptitude))
         {
            idb.AddParameter("@WHS_Aptitude", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Aptitude", wH_Supplier.WHS_Aptitude);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_LegalPerson))
         {
            idb.AddParameter("@WHS_LegalPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_LegalPerson", wH_Supplier.WHS_LegalPerson);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_ContactPerson))
         {
            idb.AddParameter("@WHS_ContactPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_ContactPerson", wH_Supplier.WHS_ContactPerson);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Telphone))
         {
            idb.AddParameter("@WHS_Telphone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Telphone", wH_Supplier.WHS_Telphone);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_MobilePhone))
         {
            idb.AddParameter("@WHS_MobilePhone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_MobilePhone", wH_Supplier.WHS_MobilePhone);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Fax))
         {
            idb.AddParameter("@WHS_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Fax", wH_Supplier.WHS_Fax);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Email))
         {
            idb.AddParameter("@WHS_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Email", wH_Supplier.WHS_Email);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Site))
         {
            idb.AddParameter("@WHS_Site", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Site", wH_Supplier.WHS_Site);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_ZipCode))
         {
            idb.AddParameter("@WHS_ZipCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_ZipCode", wH_Supplier.WHS_ZipCode);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Introduction))
         {
            idb.AddParameter("@WHS_Introduction", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Introduction", wH_Supplier.WHS_Introduction);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_iType))
         {
            idb.AddParameter("@WHS_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_iType", wH_Supplier.WHS_iType);
         }
         if (wH_Supplier.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Supplier.Stat);
         }
         if (wH_Supplier.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Supplier.CreateDate);
         }
         if (wH_Supplier.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Supplier.UpdateDate);
         }
         if (wH_Supplier.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Supplier.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Capital))
         {
            idb.AddParameter("@WHS_Capital", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Capital", wH_Supplier.WHS_Capital);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Levy))
         {
            idb.AddParameter("@WHS_Levy", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Levy", wH_Supplier.WHS_Levy);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_UName))
         {
            idb.AddParameter("@WHS_UName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_UName", wH_Supplier.WHS_UName);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Raddress))
         {
            idb.AddParameter("@WHS_Raddress", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Raddress", wH_Supplier.WHS_Raddress);
         }
         if (wH_Supplier.WHS_RBegin == DateTime.MinValue)
         {
            idb.AddParameter("@WHS_RBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_RBegin", wH_Supplier.WHS_RBegin);
         }
         if (wH_Supplier.WHS_End == DateTime.MinValue)
         {
            idb.AddParameter("@WHS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_End", wH_Supplier.WHS_End);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Taxroar))
         {
            idb.AddParameter("@WHS_Taxroar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Taxroar", wH_Supplier.WHS_Taxroar);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Cdegree))
         {
            idb.AddParameter("@WHS_Cdegree", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Cdegree", wH_Supplier.WHS_Cdegree);
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
      /// 添加供应商信息 WH_Supplier对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Supplier wH_Supplier)
      {
         string sql = "INSERT INTO WH_Supplier (WHS_CustCode,WHS_CustName,WHS_Group,WHS_Property,WHS_Aptitude,WHS_LegalPerson,WHS_ContactPerson,WHS_Telphone,WHS_MobilePhone,WHS_Fax,WHS_Email,WHS_Site,WHS_ZipCode,WHS_Introduction,WHS_iType,Stat,CreateDate,UpdateDate,DeleteDate,WHS_Capital,WHS_Levy,WHS_UName,WHS_Raddress,WHS_RBegin,WHS_End,WHS_Taxroar,WHS_Cdegree) VALUES (@WHS_CustCode,@WHS_CustName,@WHS_Group,@WHS_Property,@WHS_Aptitude,@WHS_LegalPerson,@WHS_ContactPerson,@WHS_Telphone,@WHS_MobilePhone,@WHS_Fax,@WHS_Email,@WHS_Site,@WHS_ZipCode,@WHS_Introduction,@WHS_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHS_Capital,@WHS_Levy,@WHS_UName,@WHS_Raddress,@WHS_RBegin,@WHS_End,@WHS_Taxroar,@WHS_Cdegree);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Supplier.WHS_CustCode))
         {
            idb.AddParameter("@WHS_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_CustCode", wH_Supplier.WHS_CustCode);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_CustName))
         {
            idb.AddParameter("@WHS_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_CustName", wH_Supplier.WHS_CustName);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Group))
         {
            idb.AddParameter("@WHS_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Group", wH_Supplier.WHS_Group);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Property))
         {
            idb.AddParameter("@WHS_Property", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Property", wH_Supplier.WHS_Property);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Aptitude))
         {
            idb.AddParameter("@WHS_Aptitude", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Aptitude", wH_Supplier.WHS_Aptitude);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_LegalPerson))
         {
            idb.AddParameter("@WHS_LegalPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_LegalPerson", wH_Supplier.WHS_LegalPerson);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_ContactPerson))
         {
            idb.AddParameter("@WHS_ContactPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_ContactPerson", wH_Supplier.WHS_ContactPerson);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Telphone))
         {
            idb.AddParameter("@WHS_Telphone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Telphone", wH_Supplier.WHS_Telphone);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_MobilePhone))
         {
            idb.AddParameter("@WHS_MobilePhone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_MobilePhone", wH_Supplier.WHS_MobilePhone);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Fax))
         {
            idb.AddParameter("@WHS_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Fax", wH_Supplier.WHS_Fax);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Email))
         {
            idb.AddParameter("@WHS_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Email", wH_Supplier.WHS_Email);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Site))
         {
            idb.AddParameter("@WHS_Site", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Site", wH_Supplier.WHS_Site);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_ZipCode))
         {
            idb.AddParameter("@WHS_ZipCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_ZipCode", wH_Supplier.WHS_ZipCode);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Introduction))
         {
            idb.AddParameter("@WHS_Introduction", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Introduction", wH_Supplier.WHS_Introduction);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_iType))
         {
            idb.AddParameter("@WHS_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_iType", wH_Supplier.WHS_iType);
         }
         if (wH_Supplier.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Supplier.Stat);
         }
         if (wH_Supplier.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Supplier.CreateDate);
         }
         if (wH_Supplier.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Supplier.UpdateDate);
         }
         if (wH_Supplier.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Supplier.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Capital))
         {
            idb.AddParameter("@WHS_Capital", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Capital", wH_Supplier.WHS_Capital);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Levy))
         {
            idb.AddParameter("@WHS_Levy", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Levy", wH_Supplier.WHS_Levy);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_UName))
         {
            idb.AddParameter("@WHS_UName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_UName", wH_Supplier.WHS_UName);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Raddress))
         {
            idb.AddParameter("@WHS_Raddress", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Raddress", wH_Supplier.WHS_Raddress);
         }
         if (wH_Supplier.WHS_RBegin == DateTime.MinValue)
         {
            idb.AddParameter("@WHS_RBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_RBegin", wH_Supplier.WHS_RBegin);
         }
         if (wH_Supplier.WHS_End == DateTime.MinValue)
         {
            idb.AddParameter("@WHS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_End", wH_Supplier.WHS_End);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Taxroar))
         {
            idb.AddParameter("@WHS_Taxroar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Taxroar", wH_Supplier.WHS_Taxroar);
         }
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Cdegree))
         {
            idb.AddParameter("@WHS_Cdegree", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Cdegree", wH_Supplier.WHS_Cdegree);
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
      /// 更新供应商信息 WH_Supplier对象(即:一条记录
      /// </summary>
      public int Update(WH_Supplier wH_Supplier)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Supplier       SET ");
            if(wH_Supplier.WHS_CustCode_IsChanged){sbParameter.Append("WHS_CustCode=@WHS_CustCode, ");}
      if(wH_Supplier.WHS_CustName_IsChanged){sbParameter.Append("WHS_CustName=@WHS_CustName, ");}
      if(wH_Supplier.WHS_Group_IsChanged){sbParameter.Append("WHS_Group=@WHS_Group, ");}
      if(wH_Supplier.WHS_Property_IsChanged){sbParameter.Append("WHS_Property=@WHS_Property, ");}
      if(wH_Supplier.WHS_Aptitude_IsChanged){sbParameter.Append("WHS_Aptitude=@WHS_Aptitude, ");}
      if(wH_Supplier.WHS_LegalPerson_IsChanged){sbParameter.Append("WHS_LegalPerson=@WHS_LegalPerson, ");}
      if(wH_Supplier.WHS_ContactPerson_IsChanged){sbParameter.Append("WHS_ContactPerson=@WHS_ContactPerson, ");}
      if(wH_Supplier.WHS_Telphone_IsChanged){sbParameter.Append("WHS_Telphone=@WHS_Telphone, ");}
      if(wH_Supplier.WHS_MobilePhone_IsChanged){sbParameter.Append("WHS_MobilePhone=@WHS_MobilePhone, ");}
      if(wH_Supplier.WHS_Fax_IsChanged){sbParameter.Append("WHS_Fax=@WHS_Fax, ");}
      if(wH_Supplier.WHS_Email_IsChanged){sbParameter.Append("WHS_Email=@WHS_Email, ");}
      if(wH_Supplier.WHS_Site_IsChanged){sbParameter.Append("WHS_Site=@WHS_Site, ");}
      if(wH_Supplier.WHS_ZipCode_IsChanged){sbParameter.Append("WHS_ZipCode=@WHS_ZipCode, ");}
      if(wH_Supplier.WHS_Introduction_IsChanged){sbParameter.Append("WHS_Introduction=@WHS_Introduction, ");}
      if(wH_Supplier.WHS_iType_IsChanged){sbParameter.Append("WHS_iType=@WHS_iType, ");}
      if(wH_Supplier.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Supplier.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Supplier.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Supplier.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Supplier.WHS_Capital_IsChanged){sbParameter.Append("WHS_Capital=@WHS_Capital, ");}
      if(wH_Supplier.WHS_Levy_IsChanged){sbParameter.Append("WHS_Levy=@WHS_Levy, ");}
      if(wH_Supplier.WHS_UName_IsChanged){sbParameter.Append("WHS_UName=@WHS_UName, ");}
      if(wH_Supplier.WHS_Raddress_IsChanged){sbParameter.Append("WHS_Raddress=@WHS_Raddress, ");}
      if(wH_Supplier.WHS_RBegin_IsChanged){sbParameter.Append("WHS_RBegin=@WHS_RBegin, ");}
      if(wH_Supplier.WHS_End_IsChanged){sbParameter.Append("WHS_End=@WHS_End, ");}
      if(wH_Supplier.WHS_Taxroar_IsChanged){sbParameter.Append("WHS_Taxroar=@WHS_Taxroar, ");}
      if(wH_Supplier.WHS_Cdegree_IsChanged){sbParameter.Append("WHS_Cdegree=@WHS_Cdegree ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHS_IDS=@WHS_IDS; " );
      string sql=sb.ToString();
         if(wH_Supplier.WHS_CustCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_CustCode))
         {
            idb.AddParameter("@WHS_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_CustCode", wH_Supplier.WHS_CustCode);
         }
          }
         if(wH_Supplier.WHS_CustName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_CustName))
         {
            idb.AddParameter("@WHS_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_CustName", wH_Supplier.WHS_CustName);
         }
          }
         if(wH_Supplier.WHS_Group_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Group))
         {
            idb.AddParameter("@WHS_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Group", wH_Supplier.WHS_Group);
         }
          }
         if(wH_Supplier.WHS_Property_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Property))
         {
            idb.AddParameter("@WHS_Property", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Property", wH_Supplier.WHS_Property);
         }
          }
         if(wH_Supplier.WHS_Aptitude_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Aptitude))
         {
            idb.AddParameter("@WHS_Aptitude", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Aptitude", wH_Supplier.WHS_Aptitude);
         }
          }
         if(wH_Supplier.WHS_LegalPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_LegalPerson))
         {
            idb.AddParameter("@WHS_LegalPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_LegalPerson", wH_Supplier.WHS_LegalPerson);
         }
          }
         if(wH_Supplier.WHS_ContactPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_ContactPerson))
         {
            idb.AddParameter("@WHS_ContactPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_ContactPerson", wH_Supplier.WHS_ContactPerson);
         }
          }
         if(wH_Supplier.WHS_Telphone_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Telphone))
         {
            idb.AddParameter("@WHS_Telphone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Telphone", wH_Supplier.WHS_Telphone);
         }
          }
         if(wH_Supplier.WHS_MobilePhone_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_MobilePhone))
         {
            idb.AddParameter("@WHS_MobilePhone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_MobilePhone", wH_Supplier.WHS_MobilePhone);
         }
          }
         if(wH_Supplier.WHS_Fax_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Fax))
         {
            idb.AddParameter("@WHS_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Fax", wH_Supplier.WHS_Fax);
         }
          }
         if(wH_Supplier.WHS_Email_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Email))
         {
            idb.AddParameter("@WHS_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Email", wH_Supplier.WHS_Email);
         }
          }
         if(wH_Supplier.WHS_Site_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Site))
         {
            idb.AddParameter("@WHS_Site", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Site", wH_Supplier.WHS_Site);
         }
          }
         if(wH_Supplier.WHS_ZipCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_ZipCode))
         {
            idb.AddParameter("@WHS_ZipCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_ZipCode", wH_Supplier.WHS_ZipCode);
         }
          }
         if(wH_Supplier.WHS_Introduction_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Introduction))
         {
            idb.AddParameter("@WHS_Introduction", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Introduction", wH_Supplier.WHS_Introduction);
         }
          }
         if(wH_Supplier.WHS_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_iType))
         {
            idb.AddParameter("@WHS_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_iType", wH_Supplier.WHS_iType);
         }
          }
         if(wH_Supplier.Stat_IsChanged)
         {
         if (wH_Supplier.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Supplier.Stat);
         }
          }
         if(wH_Supplier.CreateDate_IsChanged)
         {
         if (wH_Supplier.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Supplier.CreateDate);
         }
          }
         if(wH_Supplier.UpdateDate_IsChanged)
         {
         if (wH_Supplier.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Supplier.UpdateDate);
         }
          }
         if(wH_Supplier.DeleteDate_IsChanged)
         {
         if (wH_Supplier.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Supplier.DeleteDate);
         }
          }
         if(wH_Supplier.WHS_Capital_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Capital))
         {
            idb.AddParameter("@WHS_Capital", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Capital", wH_Supplier.WHS_Capital);
         }
          }
         if(wH_Supplier.WHS_Levy_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Levy))
         {
            idb.AddParameter("@WHS_Levy", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Levy", wH_Supplier.WHS_Levy);
         }
          }
         if(wH_Supplier.WHS_UName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_UName))
         {
            idb.AddParameter("@WHS_UName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_UName", wH_Supplier.WHS_UName);
         }
          }
         if(wH_Supplier.WHS_Raddress_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Raddress))
         {
            idb.AddParameter("@WHS_Raddress", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Raddress", wH_Supplier.WHS_Raddress);
         }
          }
         if(wH_Supplier.WHS_RBegin_IsChanged)
         {
         if (wH_Supplier.WHS_RBegin == DateTime.MinValue)
         {
            idb.AddParameter("@WHS_RBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_RBegin", wH_Supplier.WHS_RBegin);
         }
          }
         if(wH_Supplier.WHS_End_IsChanged)
         {
         if (wH_Supplier.WHS_End == DateTime.MinValue)
         {
            idb.AddParameter("@WHS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_End", wH_Supplier.WHS_End);
         }
          }
         if(wH_Supplier.WHS_Taxroar_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Taxroar))
         {
            idb.AddParameter("@WHS_Taxroar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Taxroar", wH_Supplier.WHS_Taxroar);
         }
          }
         if(wH_Supplier.WHS_Cdegree_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Supplier.WHS_Cdegree))
         {
            idb.AddParameter("@WHS_Cdegree", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHS_Cdegree", wH_Supplier.WHS_Cdegree);
         }
          }

         idb.AddParameter("@WHS_IDS", wH_Supplier.WHS_IDS);

           
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
      /// 删除供应商信息 WH_Supplier对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHS_IDS)
      {
         string sql = "DELETE WH_Supplier WHERE 1=1  AND WHS_IDS=@WHS_IDS ";
         idb.AddParameter("@WHS_IDS", wHS_IDS);

           
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
      /// 获取指定的供应商信息 WH_Supplier对象(即:一条记录
      /// </summary>
      public WH_Supplier GetByKey(decimal wHS_IDS)
      {
         WH_Supplier wH_Supplier = new WH_Supplier();
         string sql = "SELECT  WHS_IDS,WHS_CustCode,WHS_CustName,WHS_Group,WHS_Property,WHS_Aptitude,WHS_LegalPerson,WHS_ContactPerson,WHS_Telphone,WHS_MobilePhone,WHS_Fax,WHS_Email,WHS_Site,WHS_ZipCode,WHS_Introduction,WHS_iType,Stat,CreateDate,UpdateDate,DeleteDate,WHS_Capital,WHS_Levy,WHS_UName,WHS_Raddress,WHS_RBegin,WHS_End,WHS_Taxroar,WHS_Cdegree FROM WH_Supplier WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHS_IDS=@WHS_IDS ";
         idb.AddParameter("@WHS_IDS", wHS_IDS);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHS_IDS"] != DBNull.Value) wH_Supplier.WHS_IDS = Convert.ToDecimal(dr["WHS_IDS"]);
            if (dr["WHS_CustCode"] != DBNull.Value) wH_Supplier.WHS_CustCode = Convert.ToString(dr["WHS_CustCode"]);
            if (dr["WHS_CustName"] != DBNull.Value) wH_Supplier.WHS_CustName = Convert.ToString(dr["WHS_CustName"]);
            if (dr["WHS_Group"] != DBNull.Value) wH_Supplier.WHS_Group = Convert.ToString(dr["WHS_Group"]);
            if (dr["WHS_Property"] != DBNull.Value) wH_Supplier.WHS_Property = Convert.ToString(dr["WHS_Property"]);
            if (dr["WHS_Aptitude"] != DBNull.Value) wH_Supplier.WHS_Aptitude = Convert.ToString(dr["WHS_Aptitude"]);
            if (dr["WHS_LegalPerson"] != DBNull.Value) wH_Supplier.WHS_LegalPerson = Convert.ToString(dr["WHS_LegalPerson"]);
            if (dr["WHS_ContactPerson"] != DBNull.Value) wH_Supplier.WHS_ContactPerson = Convert.ToString(dr["WHS_ContactPerson"]);
            if (dr["WHS_Telphone"] != DBNull.Value) wH_Supplier.WHS_Telphone = Convert.ToString(dr["WHS_Telphone"]);
            if (dr["WHS_MobilePhone"] != DBNull.Value) wH_Supplier.WHS_MobilePhone = Convert.ToString(dr["WHS_MobilePhone"]);
            if (dr["WHS_Fax"] != DBNull.Value) wH_Supplier.WHS_Fax = Convert.ToString(dr["WHS_Fax"]);
            if (dr["WHS_Email"] != DBNull.Value) wH_Supplier.WHS_Email = Convert.ToString(dr["WHS_Email"]);
            if (dr["WHS_Site"] != DBNull.Value) wH_Supplier.WHS_Site = Convert.ToString(dr["WHS_Site"]);
            if (dr["WHS_ZipCode"] != DBNull.Value) wH_Supplier.WHS_ZipCode = Convert.ToString(dr["WHS_ZipCode"]);
            if (dr["WHS_Introduction"] != DBNull.Value) wH_Supplier.WHS_Introduction = Convert.ToString(dr["WHS_Introduction"]);
            if (dr["WHS_iType"] != DBNull.Value) wH_Supplier.WHS_iType = Convert.ToString(dr["WHS_iType"]);
            if (dr["Stat"] != DBNull.Value) wH_Supplier.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Supplier.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Supplier.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Supplier.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHS_Capital"] != DBNull.Value) wH_Supplier.WHS_Capital = Convert.ToString(dr["WHS_Capital"]);
            if (dr["WHS_Levy"] != DBNull.Value) wH_Supplier.WHS_Levy = Convert.ToString(dr["WHS_Levy"]);
            if (dr["WHS_UName"] != DBNull.Value) wH_Supplier.WHS_UName = Convert.ToString(dr["WHS_UName"]);
            if (dr["WHS_Raddress"] != DBNull.Value) wH_Supplier.WHS_Raddress = Convert.ToString(dr["WHS_Raddress"]);
            if (dr["WHS_RBegin"] != DBNull.Value) wH_Supplier.WHS_RBegin = Convert.ToDateTime(dr["WHS_RBegin"]);
            if (dr["WHS_End"] != DBNull.Value) wH_Supplier.WHS_End = Convert.ToDateTime(dr["WHS_End"]);
            if (dr["WHS_Taxroar"] != DBNull.Value) wH_Supplier.WHS_Taxroar = Convert.ToString(dr["WHS_Taxroar"]);
            if (dr["WHS_Cdegree"] != DBNull.Value) wH_Supplier.WHS_Cdegree = Convert.ToString(dr["WHS_Cdegree"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Supplier;
      }
      /// <summary>
      /// 获取指定的供应商信息 WH_Supplier对象集合
      /// </summary>
      public List<WH_Supplier> GetListByWhere(string strCondition)
      {
         List<WH_Supplier> ret = new List<WH_Supplier>();
         string sql = "SELECT  WHS_IDS,WHS_CustCode,WHS_CustName,WHS_Group,WHS_Property,WHS_Aptitude,WHS_LegalPerson,WHS_ContactPerson,WHS_Telphone,WHS_MobilePhone,WHS_Fax,WHS_Email,WHS_Site,WHS_ZipCode,WHS_Introduction,WHS_iType,Stat,CreateDate,UpdateDate,DeleteDate,WHS_Capital,WHS_Levy,WHS_UName,WHS_Raddress,WHS_RBegin,WHS_End,WHS_Taxroar,WHS_Cdegree FROM WH_Supplier WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Supplier wH_Supplier = new WH_Supplier();
            if (dr["WHS_IDS"] != DBNull.Value) wH_Supplier.WHS_IDS = Convert.ToDecimal(dr["WHS_IDS"]);
            if (dr["WHS_CustCode"] != DBNull.Value) wH_Supplier.WHS_CustCode = Convert.ToString(dr["WHS_CustCode"]);
            if (dr["WHS_CustName"] != DBNull.Value) wH_Supplier.WHS_CustName = Convert.ToString(dr["WHS_CustName"]);
            if (dr["WHS_Group"] != DBNull.Value) wH_Supplier.WHS_Group = Convert.ToString(dr["WHS_Group"]);
            if (dr["WHS_Property"] != DBNull.Value) wH_Supplier.WHS_Property = Convert.ToString(dr["WHS_Property"]);
            if (dr["WHS_Aptitude"] != DBNull.Value) wH_Supplier.WHS_Aptitude = Convert.ToString(dr["WHS_Aptitude"]);
            if (dr["WHS_LegalPerson"] != DBNull.Value) wH_Supplier.WHS_LegalPerson = Convert.ToString(dr["WHS_LegalPerson"]);
            if (dr["WHS_ContactPerson"] != DBNull.Value) wH_Supplier.WHS_ContactPerson = Convert.ToString(dr["WHS_ContactPerson"]);
            if (dr["WHS_Telphone"] != DBNull.Value) wH_Supplier.WHS_Telphone = Convert.ToString(dr["WHS_Telphone"]);
            if (dr["WHS_MobilePhone"] != DBNull.Value) wH_Supplier.WHS_MobilePhone = Convert.ToString(dr["WHS_MobilePhone"]);
            if (dr["WHS_Fax"] != DBNull.Value) wH_Supplier.WHS_Fax = Convert.ToString(dr["WHS_Fax"]);
            if (dr["WHS_Email"] != DBNull.Value) wH_Supplier.WHS_Email = Convert.ToString(dr["WHS_Email"]);
            if (dr["WHS_Site"] != DBNull.Value) wH_Supplier.WHS_Site = Convert.ToString(dr["WHS_Site"]);
            if (dr["WHS_ZipCode"] != DBNull.Value) wH_Supplier.WHS_ZipCode = Convert.ToString(dr["WHS_ZipCode"]);
            if (dr["WHS_Introduction"] != DBNull.Value) wH_Supplier.WHS_Introduction = Convert.ToString(dr["WHS_Introduction"]);
            if (dr["WHS_iType"] != DBNull.Value) wH_Supplier.WHS_iType = Convert.ToString(dr["WHS_iType"]);
            if (dr["Stat"] != DBNull.Value) wH_Supplier.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Supplier.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Supplier.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Supplier.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHS_Capital"] != DBNull.Value) wH_Supplier.WHS_Capital = Convert.ToString(dr["WHS_Capital"]);
            if (dr["WHS_Levy"] != DBNull.Value) wH_Supplier.WHS_Levy = Convert.ToString(dr["WHS_Levy"]);
            if (dr["WHS_UName"] != DBNull.Value) wH_Supplier.WHS_UName = Convert.ToString(dr["WHS_UName"]);
            if (dr["WHS_Raddress"] != DBNull.Value) wH_Supplier.WHS_Raddress = Convert.ToString(dr["WHS_Raddress"]);
            if (dr["WHS_RBegin"] != DBNull.Value) wH_Supplier.WHS_RBegin = Convert.ToDateTime(dr["WHS_RBegin"]);
            if (dr["WHS_End"] != DBNull.Value) wH_Supplier.WHS_End = Convert.ToDateTime(dr["WHS_End"]);
            if (dr["WHS_Taxroar"] != DBNull.Value) wH_Supplier.WHS_Taxroar = Convert.ToString(dr["WHS_Taxroar"]);
            if (dr["WHS_Cdegree"] != DBNull.Value) wH_Supplier.WHS_Cdegree = Convert.ToString(dr["WHS_Cdegree"]);
            ret.Add(wH_Supplier);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的供应商信息 WH_Supplier对象(即:一条记录
      /// </summary>
      public List<WH_Supplier> GetAll()
      {
         List<WH_Supplier> ret = new List<WH_Supplier>();
         string sql = "SELECT  WHS_IDS,WHS_CustCode,WHS_CustName,WHS_Group,WHS_Property,WHS_Aptitude,WHS_LegalPerson,WHS_ContactPerson,WHS_Telphone,WHS_MobilePhone,WHS_Fax,WHS_Email,WHS_Site,WHS_ZipCode,WHS_Introduction,WHS_iType,Stat,CreateDate,UpdateDate,DeleteDate,WHS_Capital,WHS_Levy,WHS_UName,WHS_Raddress,WHS_RBegin,WHS_End,WHS_Taxroar,WHS_Cdegree FROM WH_Supplier where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHS_IDS desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Supplier wH_Supplier = new WH_Supplier();
            if (dr["WHS_IDS"] != DBNull.Value) wH_Supplier.WHS_IDS = Convert.ToDecimal(dr["WHS_IDS"]);
            if (dr["WHS_CustCode"] != DBNull.Value) wH_Supplier.WHS_CustCode = Convert.ToString(dr["WHS_CustCode"]);
            if (dr["WHS_CustName"] != DBNull.Value) wH_Supplier.WHS_CustName = Convert.ToString(dr["WHS_CustName"]);
            if (dr["WHS_Group"] != DBNull.Value) wH_Supplier.WHS_Group = Convert.ToString(dr["WHS_Group"]);
            if (dr["WHS_Property"] != DBNull.Value) wH_Supplier.WHS_Property = Convert.ToString(dr["WHS_Property"]);
            if (dr["WHS_Aptitude"] != DBNull.Value) wH_Supplier.WHS_Aptitude = Convert.ToString(dr["WHS_Aptitude"]);
            if (dr["WHS_LegalPerson"] != DBNull.Value) wH_Supplier.WHS_LegalPerson = Convert.ToString(dr["WHS_LegalPerson"]);
            if (dr["WHS_ContactPerson"] != DBNull.Value) wH_Supplier.WHS_ContactPerson = Convert.ToString(dr["WHS_ContactPerson"]);
            if (dr["WHS_Telphone"] != DBNull.Value) wH_Supplier.WHS_Telphone = Convert.ToString(dr["WHS_Telphone"]);
            if (dr["WHS_MobilePhone"] != DBNull.Value) wH_Supplier.WHS_MobilePhone = Convert.ToString(dr["WHS_MobilePhone"]);
            if (dr["WHS_Fax"] != DBNull.Value) wH_Supplier.WHS_Fax = Convert.ToString(dr["WHS_Fax"]);
            if (dr["WHS_Email"] != DBNull.Value) wH_Supplier.WHS_Email = Convert.ToString(dr["WHS_Email"]);
            if (dr["WHS_Site"] != DBNull.Value) wH_Supplier.WHS_Site = Convert.ToString(dr["WHS_Site"]);
            if (dr["WHS_ZipCode"] != DBNull.Value) wH_Supplier.WHS_ZipCode = Convert.ToString(dr["WHS_ZipCode"]);
            if (dr["WHS_Introduction"] != DBNull.Value) wH_Supplier.WHS_Introduction = Convert.ToString(dr["WHS_Introduction"]);
            if (dr["WHS_iType"] != DBNull.Value) wH_Supplier.WHS_iType = Convert.ToString(dr["WHS_iType"]);
            if (dr["Stat"] != DBNull.Value) wH_Supplier.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Supplier.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Supplier.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Supplier.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHS_Capital"] != DBNull.Value) wH_Supplier.WHS_Capital = Convert.ToString(dr["WHS_Capital"]);
            if (dr["WHS_Levy"] != DBNull.Value) wH_Supplier.WHS_Levy = Convert.ToString(dr["WHS_Levy"]);
            if (dr["WHS_UName"] != DBNull.Value) wH_Supplier.WHS_UName = Convert.ToString(dr["WHS_UName"]);
            if (dr["WHS_Raddress"] != DBNull.Value) wH_Supplier.WHS_Raddress = Convert.ToString(dr["WHS_Raddress"]);
            if (dr["WHS_RBegin"] != DBNull.Value) wH_Supplier.WHS_RBegin = Convert.ToDateTime(dr["WHS_RBegin"]);
            if (dr["WHS_End"] != DBNull.Value) wH_Supplier.WHS_End = Convert.ToDateTime(dr["WHS_End"]);
            if (dr["WHS_Taxroar"] != DBNull.Value) wH_Supplier.WHS_Taxroar = Convert.ToString(dr["WHS_Taxroar"]);
            if (dr["WHS_Cdegree"] != DBNull.Value) wH_Supplier.WHS_Cdegree = Convert.ToString(dr["WHS_Cdegree"]);
            ret.Add(wH_Supplier);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
