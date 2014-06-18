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
   /// 联系人信息
   /// </summary>
   [Serializable]
   public partial class ADOBse_Contacts
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加联系人信息 Bse_Contacts对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Contacts bse_Contacts)
      {
         string sql = "INSERT INTO Bse_Contacts (Module_Code,Record_ID,BContact_Name,BContact_Tel1,BContact_Tel2,BContact_Fax,BContact_Addr,BContact_Email,BContact_Duty,BContact_Gender,BContact_Career,BContact_Birth,BContact_From,BContact_IsDefault,CreateDate,Creator,BContact_Bak1,BContact_Bak2,Stat,BContact_Code,UpdateDate,DeleteDate) VALUES (@Module_Code,@Record_ID,@BContact_Name,@BContact_Tel1,@BContact_Tel2,@BContact_Fax,@BContact_Addr,@BContact_Email,@BContact_Duty,@BContact_Gender,@BContact_Career,@BContact_Birth,@BContact_From,@BContact_IsDefault,@CreateDate,@Creator,@BContact_Bak1,@BContact_Bak2,@Stat,@BContact_Code,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(bse_Contacts.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Contacts.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Contacts.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Contacts.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Name))
         {
            idb.AddParameter("@BContact_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Name", bse_Contacts.BContact_Name);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Tel1))
         {
            idb.AddParameter("@BContact_Tel1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Tel1", bse_Contacts.BContact_Tel1);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Tel2))
         {
            idb.AddParameter("@BContact_Tel2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Tel2", bse_Contacts.BContact_Tel2);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Fax))
         {
            idb.AddParameter("@BContact_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Fax", bse_Contacts.BContact_Fax);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Addr))
         {
            idb.AddParameter("@BContact_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Addr", bse_Contacts.BContact_Addr);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Email))
         {
            idb.AddParameter("@BContact_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Email", bse_Contacts.BContact_Email);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Duty))
         {
            idb.AddParameter("@BContact_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Duty", bse_Contacts.BContact_Duty);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Gender))
         {
            idb.AddParameter("@BContact_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Gender", bse_Contacts.BContact_Gender);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Career))
         {
            idb.AddParameter("@BContact_Career", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Career", bse_Contacts.BContact_Career);
         }
         if (bse_Contacts.BContact_Birth == DateTime.MinValue)
         {
            idb.AddParameter("@BContact_Birth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Birth", bse_Contacts.BContact_Birth);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_From))
         {
            idb.AddParameter("@BContact_From", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_From", bse_Contacts.BContact_From);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_IsDefault))
         {
            idb.AddParameter("@BContact_IsDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_IsDefault", bse_Contacts.BContact_IsDefault);
         }
         if (bse_Contacts.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Contacts.CreateDate);
         }
         if (string.IsNullOrEmpty(bse_Contacts.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", bse_Contacts.Creator);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Bak1))
         {
            idb.AddParameter("@BContact_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Bak1", bse_Contacts.BContact_Bak1);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Bak2))
         {
            idb.AddParameter("@BContact_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Bak2", bse_Contacts.BContact_Bak2);
         }
         if (bse_Contacts.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Contacts.Stat);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Code))
         {
            idb.AddParameter("@BContact_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Code", bse_Contacts.BContact_Code);
         }
         if (bse_Contacts.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Contacts.UpdateDate);
         }
         if (bse_Contacts.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Contacts.DeleteDate);
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
      /// 添加联系人信息 Bse_Contacts对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Contacts bse_Contacts)
      {
         string sql = "INSERT INTO Bse_Contacts (Module_Code,Record_ID,BContact_Name,BContact_Tel1,BContact_Tel2,BContact_Fax,BContact_Addr,BContact_Email,BContact_Duty,BContact_Gender,BContact_Career,BContact_Birth,BContact_From,BContact_IsDefault,CreateDate,Creator,BContact_Bak1,BContact_Bak2,Stat,BContact_Code,UpdateDate,DeleteDate) VALUES (@Module_Code,@Record_ID,@BContact_Name,@BContact_Tel1,@BContact_Tel2,@BContact_Fax,@BContact_Addr,@BContact_Email,@BContact_Duty,@BContact_Gender,@BContact_Career,@BContact_Birth,@BContact_From,@BContact_IsDefault,@CreateDate,@Creator,@BContact_Bak1,@BContact_Bak2,@Stat,@BContact_Code,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Contacts.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Contacts.Module_Code);
         }
         if (string.IsNullOrEmpty(bse_Contacts.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Contacts.Record_ID);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Name))
         {
            idb.AddParameter("@BContact_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Name", bse_Contacts.BContact_Name);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Tel1))
         {
            idb.AddParameter("@BContact_Tel1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Tel1", bse_Contacts.BContact_Tel1);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Tel2))
         {
            idb.AddParameter("@BContact_Tel2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Tel2", bse_Contacts.BContact_Tel2);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Fax))
         {
            idb.AddParameter("@BContact_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Fax", bse_Contacts.BContact_Fax);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Addr))
         {
            idb.AddParameter("@BContact_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Addr", bse_Contacts.BContact_Addr);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Email))
         {
            idb.AddParameter("@BContact_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Email", bse_Contacts.BContact_Email);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Duty))
         {
            idb.AddParameter("@BContact_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Duty", bse_Contacts.BContact_Duty);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Gender))
         {
            idb.AddParameter("@BContact_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Gender", bse_Contacts.BContact_Gender);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Career))
         {
            idb.AddParameter("@BContact_Career", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Career", bse_Contacts.BContact_Career);
         }
         if (bse_Contacts.BContact_Birth == DateTime.MinValue)
         {
            idb.AddParameter("@BContact_Birth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Birth", bse_Contacts.BContact_Birth);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_From))
         {
            idb.AddParameter("@BContact_From", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_From", bse_Contacts.BContact_From);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_IsDefault))
         {
            idb.AddParameter("@BContact_IsDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_IsDefault", bse_Contacts.BContact_IsDefault);
         }
         if (bse_Contacts.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Contacts.CreateDate);
         }
         if (string.IsNullOrEmpty(bse_Contacts.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", bse_Contacts.Creator);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Bak1))
         {
            idb.AddParameter("@BContact_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Bak1", bse_Contacts.BContact_Bak1);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Bak2))
         {
            idb.AddParameter("@BContact_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Bak2", bse_Contacts.BContact_Bak2);
         }
         if (bse_Contacts.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Contacts.Stat);
         }
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Code))
         {
            idb.AddParameter("@BContact_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Code", bse_Contacts.BContact_Code);
         }
         if (bse_Contacts.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Contacts.UpdateDate);
         }
         if (bse_Contacts.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Contacts.DeleteDate);
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
      /// 更新联系人信息 Bse_Contacts对象(即:一条记录
      /// </summary>
      public int Update(Bse_Contacts bse_Contacts)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Contacts       SET ");
            if(bse_Contacts.Module_Code_IsChanged){sbParameter.Append("Module_Code=@Module_Code, ");}
      if(bse_Contacts.Record_ID_IsChanged){sbParameter.Append("Record_ID=@Record_ID, ");}
      if(bse_Contacts.BContact_Name_IsChanged){sbParameter.Append("BContact_Name=@BContact_Name, ");}
      if(bse_Contacts.BContact_Tel1_IsChanged){sbParameter.Append("BContact_Tel1=@BContact_Tel1, ");}
      if(bse_Contacts.BContact_Tel2_IsChanged){sbParameter.Append("BContact_Tel2=@BContact_Tel2, ");}
      if(bse_Contacts.BContact_Fax_IsChanged){sbParameter.Append("BContact_Fax=@BContact_Fax, ");}
      if(bse_Contacts.BContact_Addr_IsChanged){sbParameter.Append("BContact_Addr=@BContact_Addr, ");}
      if(bse_Contacts.BContact_Email_IsChanged){sbParameter.Append("BContact_Email=@BContact_Email, ");}
      if(bse_Contacts.BContact_Duty_IsChanged){sbParameter.Append("BContact_Duty=@BContact_Duty, ");}
      if(bse_Contacts.BContact_Gender_IsChanged){sbParameter.Append("BContact_Gender=@BContact_Gender, ");}
      if(bse_Contacts.BContact_Career_IsChanged){sbParameter.Append("BContact_Career=@BContact_Career, ");}
      if(bse_Contacts.BContact_Birth_IsChanged){sbParameter.Append("BContact_Birth=@BContact_Birth, ");}
      if(bse_Contacts.BContact_From_IsChanged){sbParameter.Append("BContact_From=@BContact_From, ");}
      if(bse_Contacts.BContact_IsDefault_IsChanged){sbParameter.Append("BContact_IsDefault=@BContact_IsDefault, ");}
      if(bse_Contacts.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(bse_Contacts.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(bse_Contacts.BContact_Bak1_IsChanged){sbParameter.Append("BContact_Bak1=@BContact_Bak1, ");}
      if(bse_Contacts.BContact_Bak2_IsChanged){sbParameter.Append("BContact_Bak2=@BContact_Bak2, ");}
      if(bse_Contacts.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Contacts.BContact_Code_IsChanged){sbParameter.Append("BContact_Code=@BContact_Code, ");}
      if(bse_Contacts.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(bse_Contacts.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and BContact_ID=@BContact_ID; " );
      string sql=sb.ToString();
         if(bse_Contacts.Module_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", bse_Contacts.Module_Code);
         }
          }
         if(bse_Contacts.Record_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", bse_Contacts.Record_ID);
         }
          }
         if(bse_Contacts.BContact_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Name))
         {
            idb.AddParameter("@BContact_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Name", bse_Contacts.BContact_Name);
         }
          }
         if(bse_Contacts.BContact_Tel1_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Tel1))
         {
            idb.AddParameter("@BContact_Tel1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Tel1", bse_Contacts.BContact_Tel1);
         }
          }
         if(bse_Contacts.BContact_Tel2_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Tel2))
         {
            idb.AddParameter("@BContact_Tel2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Tel2", bse_Contacts.BContact_Tel2);
         }
          }
         if(bse_Contacts.BContact_Fax_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Fax))
         {
            idb.AddParameter("@BContact_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Fax", bse_Contacts.BContact_Fax);
         }
          }
         if(bse_Contacts.BContact_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Addr))
         {
            idb.AddParameter("@BContact_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Addr", bse_Contacts.BContact_Addr);
         }
          }
         if(bse_Contacts.BContact_Email_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Email))
         {
            idb.AddParameter("@BContact_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Email", bse_Contacts.BContact_Email);
         }
          }
         if(bse_Contacts.BContact_Duty_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Duty))
         {
            idb.AddParameter("@BContact_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Duty", bse_Contacts.BContact_Duty);
         }
          }
         if(bse_Contacts.BContact_Gender_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Gender))
         {
            idb.AddParameter("@BContact_Gender", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Gender", bse_Contacts.BContact_Gender);
         }
          }
         if(bse_Contacts.BContact_Career_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Career))
         {
            idb.AddParameter("@BContact_Career", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Career", bse_Contacts.BContact_Career);
         }
          }
         if(bse_Contacts.BContact_Birth_IsChanged)
         {
         if (bse_Contacts.BContact_Birth == DateTime.MinValue)
         {
            idb.AddParameter("@BContact_Birth", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Birth", bse_Contacts.BContact_Birth);
         }
          }
         if(bse_Contacts.BContact_From_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_From))
         {
            idb.AddParameter("@BContact_From", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_From", bse_Contacts.BContact_From);
         }
          }
         if(bse_Contacts.BContact_IsDefault_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_IsDefault))
         {
            idb.AddParameter("@BContact_IsDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_IsDefault", bse_Contacts.BContact_IsDefault);
         }
          }
         if(bse_Contacts.CreateDate_IsChanged)
         {
         if (bse_Contacts.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", bse_Contacts.CreateDate);
         }
          }
         if(bse_Contacts.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", bse_Contacts.Creator);
         }
          }
         if(bse_Contacts.BContact_Bak1_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Bak1))
         {
            idb.AddParameter("@BContact_Bak1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Bak1", bse_Contacts.BContact_Bak1);
         }
          }
         if(bse_Contacts.BContact_Bak2_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Bak2))
         {
            idb.AddParameter("@BContact_Bak2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Bak2", bse_Contacts.BContact_Bak2);
         }
          }
         if(bse_Contacts.Stat_IsChanged)
         {
         if (bse_Contacts.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Contacts.Stat);
         }
          }
         if(bse_Contacts.BContact_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Contacts.BContact_Code))
         {
            idb.AddParameter("@BContact_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BContact_Code", bse_Contacts.BContact_Code);
         }
          }
         if(bse_Contacts.UpdateDate_IsChanged)
         {
         if (bse_Contacts.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", bse_Contacts.UpdateDate);
         }
          }
         if(bse_Contacts.DeleteDate_IsChanged)
         {
         if (bse_Contacts.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", bse_Contacts.DeleteDate);
         }
          }

         idb.AddParameter("@BContact_ID", bse_Contacts.BContact_ID);

           
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
      /// 删除联系人信息 Bse_Contacts对象(即:一条记录
      /// </summary>
      public int Delete(decimal bContact_ID)
      {
         string sql = "DELETE Bse_Contacts WHERE 1=1  AND BContact_ID=@BContact_ID ";
         idb.AddParameter("@BContact_ID", bContact_ID);

           
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
      /// 获取指定的联系人信息 Bse_Contacts对象(即:一条记录
      /// </summary>
      public Bse_Contacts GetByKey(decimal bContact_ID)
      {
         Bse_Contacts bse_Contacts = new Bse_Contacts();
         string sql = "SELECT  BContact_ID,Module_Code,Record_ID,BContact_Name,BContact_Tel1,BContact_Tel2,BContact_Fax,BContact_Addr,BContact_Email,BContact_Duty,BContact_Gender,BContact_Career,BContact_Birth,BContact_From,BContact_IsDefault,CreateDate,Creator,BContact_Bak1,BContact_Bak2,Stat,BContact_Code,UpdateDate,DeleteDate FROM Bse_Contacts WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND BContact_ID=@BContact_ID ";
         idb.AddParameter("@BContact_ID", bContact_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["BContact_ID"] != DBNull.Value) bse_Contacts.BContact_ID = Convert.ToDecimal(dr["BContact_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Contacts.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Contacts.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["BContact_Name"] != DBNull.Value) bse_Contacts.BContact_Name = Convert.ToString(dr["BContact_Name"]);
            if (dr["BContact_Tel1"] != DBNull.Value) bse_Contacts.BContact_Tel1 = Convert.ToString(dr["BContact_Tel1"]);
            if (dr["BContact_Tel2"] != DBNull.Value) bse_Contacts.BContact_Tel2 = Convert.ToString(dr["BContact_Tel2"]);
            if (dr["BContact_Fax"] != DBNull.Value) bse_Contacts.BContact_Fax = Convert.ToString(dr["BContact_Fax"]);
            if (dr["BContact_Addr"] != DBNull.Value) bse_Contacts.BContact_Addr = Convert.ToString(dr["BContact_Addr"]);
            if (dr["BContact_Email"] != DBNull.Value) bse_Contacts.BContact_Email = Convert.ToString(dr["BContact_Email"]);
            if (dr["BContact_Duty"] != DBNull.Value) bse_Contacts.BContact_Duty = Convert.ToString(dr["BContact_Duty"]);
            if (dr["BContact_Gender"] != DBNull.Value) bse_Contacts.BContact_Gender = Convert.ToString(dr["BContact_Gender"]);
            if (dr["BContact_Career"] != DBNull.Value) bse_Contacts.BContact_Career = Convert.ToString(dr["BContact_Career"]);
            if (dr["BContact_Birth"] != DBNull.Value) bse_Contacts.BContact_Birth = Convert.ToDateTime(dr["BContact_Birth"]);
            if (dr["BContact_From"] != DBNull.Value) bse_Contacts.BContact_From = Convert.ToString(dr["BContact_From"]);
            if (dr["BContact_IsDefault"] != DBNull.Value) bse_Contacts.BContact_IsDefault = Convert.ToString(dr["BContact_IsDefault"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Contacts.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["Creator"] != DBNull.Value) bse_Contacts.Creator = Convert.ToString(dr["Creator"]);
            if (dr["BContact_Bak1"] != DBNull.Value) bse_Contacts.BContact_Bak1 = Convert.ToString(dr["BContact_Bak1"]);
            if (dr["BContact_Bak2"] != DBNull.Value) bse_Contacts.BContact_Bak2 = Convert.ToString(dr["BContact_Bak2"]);
            if (dr["Stat"] != DBNull.Value) bse_Contacts.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["BContact_Code"] != DBNull.Value) bse_Contacts.BContact_Code = Convert.ToString(dr["BContact_Code"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Contacts.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Contacts.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Contacts;
      }
      /// <summary>
      /// 获取指定的联系人信息 Bse_Contacts对象集合
      /// </summary>
      public List<Bse_Contacts> GetListByWhere(string strCondition)
      {
         List<Bse_Contacts> ret = new List<Bse_Contacts>();
         string sql = "SELECT  BContact_ID,Module_Code,Record_ID,BContact_Name,BContact_Tel1,BContact_Tel2,BContact_Fax,BContact_Addr,BContact_Email,BContact_Duty,BContact_Gender,BContact_Career,BContact_Birth,BContact_From,BContact_IsDefault,CreateDate,Creator,BContact_Bak1,BContact_Bak2,Stat,BContact_Code,UpdateDate,DeleteDate FROM Bse_Contacts WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Contacts bse_Contacts = new Bse_Contacts();
            if (dr["BContact_ID"] != DBNull.Value) bse_Contacts.BContact_ID = Convert.ToDecimal(dr["BContact_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Contacts.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Contacts.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["BContact_Name"] != DBNull.Value) bse_Contacts.BContact_Name = Convert.ToString(dr["BContact_Name"]);
            if (dr["BContact_Tel1"] != DBNull.Value) bse_Contacts.BContact_Tel1 = Convert.ToString(dr["BContact_Tel1"]);
            if (dr["BContact_Tel2"] != DBNull.Value) bse_Contacts.BContact_Tel2 = Convert.ToString(dr["BContact_Tel2"]);
            if (dr["BContact_Fax"] != DBNull.Value) bse_Contacts.BContact_Fax = Convert.ToString(dr["BContact_Fax"]);
            if (dr["BContact_Addr"] != DBNull.Value) bse_Contacts.BContact_Addr = Convert.ToString(dr["BContact_Addr"]);
            if (dr["BContact_Email"] != DBNull.Value) bse_Contacts.BContact_Email = Convert.ToString(dr["BContact_Email"]);
            if (dr["BContact_Duty"] != DBNull.Value) bse_Contacts.BContact_Duty = Convert.ToString(dr["BContact_Duty"]);
            if (dr["BContact_Gender"] != DBNull.Value) bse_Contacts.BContact_Gender = Convert.ToString(dr["BContact_Gender"]);
            if (dr["BContact_Career"] != DBNull.Value) bse_Contacts.BContact_Career = Convert.ToString(dr["BContact_Career"]);
            if (dr["BContact_Birth"] != DBNull.Value) bse_Contacts.BContact_Birth = Convert.ToDateTime(dr["BContact_Birth"]);
            if (dr["BContact_From"] != DBNull.Value) bse_Contacts.BContact_From = Convert.ToString(dr["BContact_From"]);
            if (dr["BContact_IsDefault"] != DBNull.Value) bse_Contacts.BContact_IsDefault = Convert.ToString(dr["BContact_IsDefault"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Contacts.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["Creator"] != DBNull.Value) bse_Contacts.Creator = Convert.ToString(dr["Creator"]);
            if (dr["BContact_Bak1"] != DBNull.Value) bse_Contacts.BContact_Bak1 = Convert.ToString(dr["BContact_Bak1"]);
            if (dr["BContact_Bak2"] != DBNull.Value) bse_Contacts.BContact_Bak2 = Convert.ToString(dr["BContact_Bak2"]);
            if (dr["Stat"] != DBNull.Value) bse_Contacts.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["BContact_Code"] != DBNull.Value) bse_Contacts.BContact_Code = Convert.ToString(dr["BContact_Code"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Contacts.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Contacts.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bse_Contacts);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的联系人信息 Bse_Contacts对象(即:一条记录
      /// </summary>
      public List<Bse_Contacts> GetAll()
      {
         List<Bse_Contacts> ret = new List<Bse_Contacts>();
         string sql = "SELECT  BContact_ID,Module_Code,Record_ID,BContact_Name,BContact_Tel1,BContact_Tel2,BContact_Fax,BContact_Addr,BContact_Email,BContact_Duty,BContact_Gender,BContact_Career,BContact_Birth,BContact_From,BContact_IsDefault,CreateDate,Creator,BContact_Bak1,BContact_Bak2,Stat,BContact_Code,UpdateDate,DeleteDate FROM Bse_Contacts where 1=1 AND ((Stat is null) or (Stat=0) ) order by BContact_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Contacts bse_Contacts = new Bse_Contacts();
            if (dr["BContact_ID"] != DBNull.Value) bse_Contacts.BContact_ID = Convert.ToDecimal(dr["BContact_ID"]);
            if (dr["Module_Code"] != DBNull.Value) bse_Contacts.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) bse_Contacts.Record_ID = Convert.ToString(dr["Record_ID"]);
            if (dr["BContact_Name"] != DBNull.Value) bse_Contacts.BContact_Name = Convert.ToString(dr["BContact_Name"]);
            if (dr["BContact_Tel1"] != DBNull.Value) bse_Contacts.BContact_Tel1 = Convert.ToString(dr["BContact_Tel1"]);
            if (dr["BContact_Tel2"] != DBNull.Value) bse_Contacts.BContact_Tel2 = Convert.ToString(dr["BContact_Tel2"]);
            if (dr["BContact_Fax"] != DBNull.Value) bse_Contacts.BContact_Fax = Convert.ToString(dr["BContact_Fax"]);
            if (dr["BContact_Addr"] != DBNull.Value) bse_Contacts.BContact_Addr = Convert.ToString(dr["BContact_Addr"]);
            if (dr["BContact_Email"] != DBNull.Value) bse_Contacts.BContact_Email = Convert.ToString(dr["BContact_Email"]);
            if (dr["BContact_Duty"] != DBNull.Value) bse_Contacts.BContact_Duty = Convert.ToString(dr["BContact_Duty"]);
            if (dr["BContact_Gender"] != DBNull.Value) bse_Contacts.BContact_Gender = Convert.ToString(dr["BContact_Gender"]);
            if (dr["BContact_Career"] != DBNull.Value) bse_Contacts.BContact_Career = Convert.ToString(dr["BContact_Career"]);
            if (dr["BContact_Birth"] != DBNull.Value) bse_Contacts.BContact_Birth = Convert.ToDateTime(dr["BContact_Birth"]);
            if (dr["BContact_From"] != DBNull.Value) bse_Contacts.BContact_From = Convert.ToString(dr["BContact_From"]);
            if (dr["BContact_IsDefault"] != DBNull.Value) bse_Contacts.BContact_IsDefault = Convert.ToString(dr["BContact_IsDefault"]);
            if (dr["CreateDate"] != DBNull.Value) bse_Contacts.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["Creator"] != DBNull.Value) bse_Contacts.Creator = Convert.ToString(dr["Creator"]);
            if (dr["BContact_Bak1"] != DBNull.Value) bse_Contacts.BContact_Bak1 = Convert.ToString(dr["BContact_Bak1"]);
            if (dr["BContact_Bak2"] != DBNull.Value) bse_Contacts.BContact_Bak2 = Convert.ToString(dr["BContact_Bak2"]);
            if (dr["Stat"] != DBNull.Value) bse_Contacts.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["BContact_Code"] != DBNull.Value) bse_Contacts.BContact_Code = Convert.ToString(dr["BContact_Code"]);
            if (dr["UpdateDate"] != DBNull.Value) bse_Contacts.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) bse_Contacts.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(bse_Contacts);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
