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
   /// 仓库信息
   /// </summary>
   [Serializable]
   public partial class ADOWH_Warehouse
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加仓库信息 WH_Warehouse对象(即:一条记录)
      /// </summary>
      public int Add(WH_Warehouse wH_Warehouse)
      {
         string sql = "INSERT INTO WH_Warehouse (Warehouse_Code,Warehouse_Name,Warehouse_No,Warehouse_Intro,Warehouse_Usage,Warehouse_Addr,Warehouse_PCode,Warehouse_Company,Warehouse_CompanyCode,Warehouse_Remark,Warehouse_Type,Stat,CreateDate,UpdateDate,DeleteDate,Warehouse_Root,Warehouse_RootName,Warehouse_UDEF1,Warehouse_UDEF2,Warehouse_UDEF3,Warehouse_UDEF4,Warehouse_UDEF5,Warehouse_UDEF6,Warehouse_UDEF7,Warehouse_UDEF8,Warehouse_UDEF9,Warehouse_UDEF10) VALUES (@Warehouse_Code,@Warehouse_Name,@Warehouse_No,@Warehouse_Intro,@Warehouse_Usage,@Warehouse_Addr,@Warehouse_PCode,@Warehouse_Company,@Warehouse_CompanyCode,@Warehouse_Remark,@Warehouse_Type,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Warehouse_Root,@Warehouse_RootName,@Warehouse_UDEF1,@Warehouse_UDEF2,@Warehouse_UDEF3,@Warehouse_UDEF4,@Warehouse_UDEF5,@Warehouse_UDEF6,@Warehouse_UDEF7,@Warehouse_UDEF8,@Warehouse_UDEF9,@Warehouse_UDEF10)";
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Code))
         {
            idb.AddParameter("@Warehouse_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Code", wH_Warehouse.Warehouse_Code);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Name))
         {
            idb.AddParameter("@Warehouse_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Name", wH_Warehouse.Warehouse_Name);
         }
         if (wH_Warehouse.Warehouse_No == 0)
         {
            idb.AddParameter("@Warehouse_No", 0);
         }
         else
         {
            idb.AddParameter("@Warehouse_No", wH_Warehouse.Warehouse_No);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Intro))
         {
            idb.AddParameter("@Warehouse_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Intro", wH_Warehouse.Warehouse_Intro);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Usage))
         {
            idb.AddParameter("@Warehouse_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Usage", wH_Warehouse.Warehouse_Usage);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Addr))
         {
            idb.AddParameter("@Warehouse_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Addr", wH_Warehouse.Warehouse_Addr);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_PCode))
         {
            idb.AddParameter("@Warehouse_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_PCode", wH_Warehouse.Warehouse_PCode);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Company))
         {
            idb.AddParameter("@Warehouse_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Company", wH_Warehouse.Warehouse_Company);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_CompanyCode))
         {
            idb.AddParameter("@Warehouse_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_CompanyCode", wH_Warehouse.Warehouse_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Remark))
         {
            idb.AddParameter("@Warehouse_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Remark", wH_Warehouse.Warehouse_Remark);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Type))
         {
            idb.AddParameter("@Warehouse_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Type", wH_Warehouse.Warehouse_Type);
         }
         if (wH_Warehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Warehouse.Stat);
         }
         if (wH_Warehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Warehouse.CreateDate);
         }
         if (wH_Warehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Warehouse.UpdateDate);
         }
         if (wH_Warehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Warehouse.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Root))
         {
            idb.AddParameter("@Warehouse_Root", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Root", wH_Warehouse.Warehouse_Root);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_RootName))
         {
            idb.AddParameter("@Warehouse_RootName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_RootName", wH_Warehouse.Warehouse_RootName);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF1))
         {
            idb.AddParameter("@Warehouse_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF1", wH_Warehouse.Warehouse_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF2))
         {
            idb.AddParameter("@Warehouse_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF2", wH_Warehouse.Warehouse_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF3))
         {
            idb.AddParameter("@Warehouse_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF3", wH_Warehouse.Warehouse_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF4))
         {
            idb.AddParameter("@Warehouse_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF4", wH_Warehouse.Warehouse_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF5))
         {
            idb.AddParameter("@Warehouse_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF5", wH_Warehouse.Warehouse_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF6))
         {
            idb.AddParameter("@Warehouse_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF6", wH_Warehouse.Warehouse_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF7))
         {
            idb.AddParameter("@Warehouse_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF7", wH_Warehouse.Warehouse_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF8))
         {
            idb.AddParameter("@Warehouse_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF8", wH_Warehouse.Warehouse_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF9))
         {
            idb.AddParameter("@Warehouse_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF9", wH_Warehouse.Warehouse_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF10))
         {
            idb.AddParameter("@Warehouse_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF10", wH_Warehouse.Warehouse_UDEF10);
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
      /// 添加仓库信息 WH_Warehouse对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Warehouse wH_Warehouse)
      {
         string sql = "INSERT INTO WH_Warehouse (Warehouse_Code,Warehouse_Name,Warehouse_No,Warehouse_Intro,Warehouse_Usage,Warehouse_Addr,Warehouse_PCode,Warehouse_Company,Warehouse_CompanyCode,Warehouse_Remark,Warehouse_Type,Stat,CreateDate,UpdateDate,DeleteDate,Warehouse_Root,Warehouse_RootName,Warehouse_UDEF1,Warehouse_UDEF2,Warehouse_UDEF3,Warehouse_UDEF4,Warehouse_UDEF5,Warehouse_UDEF6,Warehouse_UDEF7,Warehouse_UDEF8,Warehouse_UDEF9,Warehouse_UDEF10) VALUES (@Warehouse_Code,@Warehouse_Name,@Warehouse_No,@Warehouse_Intro,@Warehouse_Usage,@Warehouse_Addr,@Warehouse_PCode,@Warehouse_Company,@Warehouse_CompanyCode,@Warehouse_Remark,@Warehouse_Type,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Warehouse_Root,@Warehouse_RootName,@Warehouse_UDEF1,@Warehouse_UDEF2,@Warehouse_UDEF3,@Warehouse_UDEF4,@Warehouse_UDEF5,@Warehouse_UDEF6,@Warehouse_UDEF7,@Warehouse_UDEF8,@Warehouse_UDEF9,@Warehouse_UDEF10);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Code))
         {
            idb.AddParameter("@Warehouse_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Code", wH_Warehouse.Warehouse_Code);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Name))
         {
            idb.AddParameter("@Warehouse_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Name", wH_Warehouse.Warehouse_Name);
         }
         if (wH_Warehouse.Warehouse_No == 0)
         {
            idb.AddParameter("@Warehouse_No", 0);
         }
         else
         {
            idb.AddParameter("@Warehouse_No", wH_Warehouse.Warehouse_No);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Intro))
         {
            idb.AddParameter("@Warehouse_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Intro", wH_Warehouse.Warehouse_Intro);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Usage))
         {
            idb.AddParameter("@Warehouse_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Usage", wH_Warehouse.Warehouse_Usage);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Addr))
         {
            idb.AddParameter("@Warehouse_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Addr", wH_Warehouse.Warehouse_Addr);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_PCode))
         {
            idb.AddParameter("@Warehouse_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_PCode", wH_Warehouse.Warehouse_PCode);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Company))
         {
            idb.AddParameter("@Warehouse_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Company", wH_Warehouse.Warehouse_Company);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_CompanyCode))
         {
            idb.AddParameter("@Warehouse_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_CompanyCode", wH_Warehouse.Warehouse_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Remark))
         {
            idb.AddParameter("@Warehouse_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Remark", wH_Warehouse.Warehouse_Remark);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Type))
         {
            idb.AddParameter("@Warehouse_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Type", wH_Warehouse.Warehouse_Type);
         }
         if (wH_Warehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Warehouse.Stat);
         }
         if (wH_Warehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Warehouse.CreateDate);
         }
         if (wH_Warehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Warehouse.UpdateDate);
         }
         if (wH_Warehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Warehouse.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Root))
         {
            idb.AddParameter("@Warehouse_Root", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Root", wH_Warehouse.Warehouse_Root);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_RootName))
         {
            idb.AddParameter("@Warehouse_RootName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_RootName", wH_Warehouse.Warehouse_RootName);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF1))
         {
            idb.AddParameter("@Warehouse_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF1", wH_Warehouse.Warehouse_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF2))
         {
            idb.AddParameter("@Warehouse_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF2", wH_Warehouse.Warehouse_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF3))
         {
            idb.AddParameter("@Warehouse_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF3", wH_Warehouse.Warehouse_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF4))
         {
            idb.AddParameter("@Warehouse_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF4", wH_Warehouse.Warehouse_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF5))
         {
            idb.AddParameter("@Warehouse_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF5", wH_Warehouse.Warehouse_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF6))
         {
            idb.AddParameter("@Warehouse_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF6", wH_Warehouse.Warehouse_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF7))
         {
            idb.AddParameter("@Warehouse_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF7", wH_Warehouse.Warehouse_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF8))
         {
            idb.AddParameter("@Warehouse_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF8", wH_Warehouse.Warehouse_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF9))
         {
            idb.AddParameter("@Warehouse_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF9", wH_Warehouse.Warehouse_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF10))
         {
            idb.AddParameter("@Warehouse_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF10", wH_Warehouse.Warehouse_UDEF10);
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
      /// 更新仓库信息 WH_Warehouse对象(即:一条记录
      /// </summary>
      public int Update(WH_Warehouse wH_Warehouse)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Warehouse       SET ");
            if(wH_Warehouse.Warehouse_Code_IsChanged){sbParameter.Append("Warehouse_Code=@Warehouse_Code, ");}
      if(wH_Warehouse.Warehouse_Name_IsChanged){sbParameter.Append("Warehouse_Name=@Warehouse_Name, ");}
      if(wH_Warehouse.Warehouse_No_IsChanged){sbParameter.Append("Warehouse_No=@Warehouse_No, ");}
      if(wH_Warehouse.Warehouse_Intro_IsChanged){sbParameter.Append("Warehouse_Intro=@Warehouse_Intro, ");}
      if(wH_Warehouse.Warehouse_Usage_IsChanged){sbParameter.Append("Warehouse_Usage=@Warehouse_Usage, ");}
      if(wH_Warehouse.Warehouse_Addr_IsChanged){sbParameter.Append("Warehouse_Addr=@Warehouse_Addr, ");}
      if(wH_Warehouse.Warehouse_PCode_IsChanged){sbParameter.Append("Warehouse_PCode=@Warehouse_PCode, ");}
      if(wH_Warehouse.Warehouse_Company_IsChanged){sbParameter.Append("Warehouse_Company=@Warehouse_Company, ");}
      if(wH_Warehouse.Warehouse_CompanyCode_IsChanged){sbParameter.Append("Warehouse_CompanyCode=@Warehouse_CompanyCode, ");}
      if(wH_Warehouse.Warehouse_Remark_IsChanged){sbParameter.Append("Warehouse_Remark=@Warehouse_Remark, ");}
      if(wH_Warehouse.Warehouse_Type_IsChanged){sbParameter.Append("Warehouse_Type=@Warehouse_Type, ");}
      if(wH_Warehouse.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Warehouse.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Warehouse.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Warehouse.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Warehouse.Warehouse_Root_IsChanged){sbParameter.Append("Warehouse_Root=@Warehouse_Root, ");}
      if(wH_Warehouse.Warehouse_RootName_IsChanged){sbParameter.Append("Warehouse_RootName=@Warehouse_RootName, ");}
      if(wH_Warehouse.Warehouse_UDEF1_IsChanged){sbParameter.Append("Warehouse_UDEF1=@Warehouse_UDEF1, ");}
      if(wH_Warehouse.Warehouse_UDEF2_IsChanged){sbParameter.Append("Warehouse_UDEF2=@Warehouse_UDEF2, ");}
      if(wH_Warehouse.Warehouse_UDEF3_IsChanged){sbParameter.Append("Warehouse_UDEF3=@Warehouse_UDEF3, ");}
      if(wH_Warehouse.Warehouse_UDEF4_IsChanged){sbParameter.Append("Warehouse_UDEF4=@Warehouse_UDEF4, ");}
      if(wH_Warehouse.Warehouse_UDEF5_IsChanged){sbParameter.Append("Warehouse_UDEF5=@Warehouse_UDEF5, ");}
      if(wH_Warehouse.Warehouse_UDEF6_IsChanged){sbParameter.Append("Warehouse_UDEF6=@Warehouse_UDEF6, ");}
      if(wH_Warehouse.Warehouse_UDEF7_IsChanged){sbParameter.Append("Warehouse_UDEF7=@Warehouse_UDEF7, ");}
      if(wH_Warehouse.Warehouse_UDEF8_IsChanged){sbParameter.Append("Warehouse_UDEF8=@Warehouse_UDEF8, ");}
      if(wH_Warehouse.Warehouse_UDEF9_IsChanged){sbParameter.Append("Warehouse_UDEF9=@Warehouse_UDEF9, ");}
      if(wH_Warehouse.Warehouse_UDEF10_IsChanged){sbParameter.Append("Warehouse_UDEF10=@Warehouse_UDEF10 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Warehouse_ID=@Warehouse_ID; " );
      string sql=sb.ToString();
         if(wH_Warehouse.Warehouse_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Code))
         {
            idb.AddParameter("@Warehouse_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Code", wH_Warehouse.Warehouse_Code);
         }
          }
         if(wH_Warehouse.Warehouse_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Name))
         {
            idb.AddParameter("@Warehouse_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Name", wH_Warehouse.Warehouse_Name);
         }
          }
         if(wH_Warehouse.Warehouse_No_IsChanged)
         {
         if (wH_Warehouse.Warehouse_No == 0)
         {
            idb.AddParameter("@Warehouse_No", 0);
         }
         else
         {
            idb.AddParameter("@Warehouse_No", wH_Warehouse.Warehouse_No);
         }
          }
         if(wH_Warehouse.Warehouse_Intro_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Intro))
         {
            idb.AddParameter("@Warehouse_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Intro", wH_Warehouse.Warehouse_Intro);
         }
          }
         if(wH_Warehouse.Warehouse_Usage_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Usage))
         {
            idb.AddParameter("@Warehouse_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Usage", wH_Warehouse.Warehouse_Usage);
         }
          }
         if(wH_Warehouse.Warehouse_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Addr))
         {
            idb.AddParameter("@Warehouse_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Addr", wH_Warehouse.Warehouse_Addr);
         }
          }
         if(wH_Warehouse.Warehouse_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_PCode))
         {
            idb.AddParameter("@Warehouse_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_PCode", wH_Warehouse.Warehouse_PCode);
         }
          }
         if(wH_Warehouse.Warehouse_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Company))
         {
            idb.AddParameter("@Warehouse_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Company", wH_Warehouse.Warehouse_Company);
         }
          }
         if(wH_Warehouse.Warehouse_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_CompanyCode))
         {
            idb.AddParameter("@Warehouse_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_CompanyCode", wH_Warehouse.Warehouse_CompanyCode);
         }
          }
         if(wH_Warehouse.Warehouse_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Remark))
         {
            idb.AddParameter("@Warehouse_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Remark", wH_Warehouse.Warehouse_Remark);
         }
          }
         if(wH_Warehouse.Warehouse_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Type))
         {
            idb.AddParameter("@Warehouse_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Type", wH_Warehouse.Warehouse_Type);
         }
          }
         if(wH_Warehouse.Stat_IsChanged)
         {
         if (wH_Warehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Warehouse.Stat);
         }
          }
         if(wH_Warehouse.CreateDate_IsChanged)
         {
         if (wH_Warehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Warehouse.CreateDate);
         }
          }
         if(wH_Warehouse.UpdateDate_IsChanged)
         {
         if (wH_Warehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Warehouse.UpdateDate);
         }
          }
         if(wH_Warehouse.DeleteDate_IsChanged)
         {
         if (wH_Warehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Warehouse.DeleteDate);
         }
          }
         if(wH_Warehouse.Warehouse_Root_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_Root))
         {
            idb.AddParameter("@Warehouse_Root", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_Root", wH_Warehouse.Warehouse_Root);
         }
          }
         if(wH_Warehouse.Warehouse_RootName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_RootName))
         {
            idb.AddParameter("@Warehouse_RootName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_RootName", wH_Warehouse.Warehouse_RootName);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF1))
         {
            idb.AddParameter("@Warehouse_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF1", wH_Warehouse.Warehouse_UDEF1);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF2))
         {
            idb.AddParameter("@Warehouse_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF2", wH_Warehouse.Warehouse_UDEF2);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF3))
         {
            idb.AddParameter("@Warehouse_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF3", wH_Warehouse.Warehouse_UDEF3);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF4))
         {
            idb.AddParameter("@Warehouse_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF4", wH_Warehouse.Warehouse_UDEF4);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF5))
         {
            idb.AddParameter("@Warehouse_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF5", wH_Warehouse.Warehouse_UDEF5);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF6))
         {
            idb.AddParameter("@Warehouse_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF6", wH_Warehouse.Warehouse_UDEF6);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF7))
         {
            idb.AddParameter("@Warehouse_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF7", wH_Warehouse.Warehouse_UDEF7);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF8))
         {
            idb.AddParameter("@Warehouse_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF8", wH_Warehouse.Warehouse_UDEF8);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF9))
         {
            idb.AddParameter("@Warehouse_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF9", wH_Warehouse.Warehouse_UDEF9);
         }
          }
         if(wH_Warehouse.Warehouse_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Warehouse.Warehouse_UDEF10))
         {
            idb.AddParameter("@Warehouse_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Warehouse_UDEF10", wH_Warehouse.Warehouse_UDEF10);
         }
          }

         idb.AddParameter("@Warehouse_ID", wH_Warehouse.Warehouse_ID);

           
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
      /// 删除仓库信息 WH_Warehouse对象(即:一条记录
      /// </summary>
      public int Delete(decimal warehouse_ID)
      {
         string sql = "DELETE WH_Warehouse WHERE 1=1  AND Warehouse_ID=@Warehouse_ID ";
         idb.AddParameter("@Warehouse_ID", warehouse_ID);

           
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
      /// 获取指定的仓库信息 WH_Warehouse对象(即:一条记录
      /// </summary>
      public WH_Warehouse GetByKey(decimal warehouse_ID)
      {
         WH_Warehouse wH_Warehouse = new WH_Warehouse();
         string sql = "SELECT  Warehouse_ID,Warehouse_Code,Warehouse_Name,Warehouse_No,Warehouse_Intro,Warehouse_Usage,Warehouse_Addr,Warehouse_PCode,Warehouse_Company,Warehouse_CompanyCode,Warehouse_Remark,Warehouse_Type,Stat,CreateDate,UpdateDate,DeleteDate,Warehouse_Root,Warehouse_RootName,Warehouse_UDEF1,Warehouse_UDEF2,Warehouse_UDEF3,Warehouse_UDEF4,Warehouse_UDEF5,Warehouse_UDEF6,Warehouse_UDEF7,Warehouse_UDEF8,Warehouse_UDEF9,Warehouse_UDEF10 FROM WH_Warehouse WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Warehouse_ID=@Warehouse_ID ";
         idb.AddParameter("@Warehouse_ID", warehouse_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Warehouse_ID"] != DBNull.Value) wH_Warehouse.Warehouse_ID = Convert.ToDecimal(dr["Warehouse_ID"]);
            if (dr["Warehouse_Code"] != DBNull.Value) wH_Warehouse.Warehouse_Code = Convert.ToString(dr["Warehouse_Code"]);
            if (dr["Warehouse_Name"] != DBNull.Value) wH_Warehouse.Warehouse_Name = Convert.ToString(dr["Warehouse_Name"]);
            if (dr["Warehouse_No"] != DBNull.Value) wH_Warehouse.Warehouse_No = Convert.ToInt32(dr["Warehouse_No"]);
            if (dr["Warehouse_Intro"] != DBNull.Value) wH_Warehouse.Warehouse_Intro = Convert.ToString(dr["Warehouse_Intro"]);
            if (dr["Warehouse_Usage"] != DBNull.Value) wH_Warehouse.Warehouse_Usage = Convert.ToString(dr["Warehouse_Usage"]);
            if (dr["Warehouse_Addr"] != DBNull.Value) wH_Warehouse.Warehouse_Addr = Convert.ToString(dr["Warehouse_Addr"]);
            if (dr["Warehouse_PCode"] != DBNull.Value) wH_Warehouse.Warehouse_PCode = Convert.ToString(dr["Warehouse_PCode"]);
            if (dr["Warehouse_Company"] != DBNull.Value) wH_Warehouse.Warehouse_Company = Convert.ToString(dr["Warehouse_Company"]);
            if (dr["Warehouse_CompanyCode"] != DBNull.Value) wH_Warehouse.Warehouse_CompanyCode = Convert.ToString(dr["Warehouse_CompanyCode"]);
            if (dr["Warehouse_Remark"] != DBNull.Value) wH_Warehouse.Warehouse_Remark = Convert.ToString(dr["Warehouse_Remark"]);
            if (dr["Warehouse_Type"] != DBNull.Value) wH_Warehouse.Warehouse_Type = Convert.ToString(dr["Warehouse_Type"]);
            if (dr["Stat"] != DBNull.Value) wH_Warehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Warehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Warehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Warehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Warehouse_Root"] != DBNull.Value) wH_Warehouse.Warehouse_Root = Convert.ToString(dr["Warehouse_Root"]);
            if (dr["Warehouse_RootName"] != DBNull.Value) wH_Warehouse.Warehouse_RootName = Convert.ToString(dr["Warehouse_RootName"]);
            if (dr["Warehouse_UDEF1"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF1 = Convert.ToString(dr["Warehouse_UDEF1"]);
            if (dr["Warehouse_UDEF2"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF2 = Convert.ToString(dr["Warehouse_UDEF2"]);
            if (dr["Warehouse_UDEF3"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF3 = Convert.ToString(dr["Warehouse_UDEF3"]);
            if (dr["Warehouse_UDEF4"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF4 = Convert.ToString(dr["Warehouse_UDEF4"]);
            if (dr["Warehouse_UDEF5"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF5 = Convert.ToString(dr["Warehouse_UDEF5"]);
            if (dr["Warehouse_UDEF6"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF6 = Convert.ToString(dr["Warehouse_UDEF6"]);
            if (dr["Warehouse_UDEF7"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF7 = Convert.ToString(dr["Warehouse_UDEF7"]);
            if (dr["Warehouse_UDEF8"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF8 = Convert.ToString(dr["Warehouse_UDEF8"]);
            if (dr["Warehouse_UDEF9"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF9 = Convert.ToString(dr["Warehouse_UDEF9"]);
            if (dr["Warehouse_UDEF10"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF10 = Convert.ToString(dr["Warehouse_UDEF10"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Warehouse;
      }
      /// <summary>
      /// 获取指定的仓库信息 WH_Warehouse对象集合
      /// </summary>
      public List<WH_Warehouse> GetListByWhere(string strCondition)
      {
         List<WH_Warehouse> ret = new List<WH_Warehouse>();
         string sql = "SELECT  Warehouse_ID,Warehouse_Code,Warehouse_Name,Warehouse_No,Warehouse_Intro,Warehouse_Usage,Warehouse_Addr,Warehouse_PCode,Warehouse_Company,Warehouse_CompanyCode,Warehouse_Remark,Warehouse_Type,Stat,CreateDate,UpdateDate,DeleteDate,Warehouse_Root,Warehouse_RootName,Warehouse_UDEF1,Warehouse_UDEF2,Warehouse_UDEF3,Warehouse_UDEF4,Warehouse_UDEF5,Warehouse_UDEF6,Warehouse_UDEF7,Warehouse_UDEF8,Warehouse_UDEF9,Warehouse_UDEF10 FROM WH_Warehouse WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Warehouse wH_Warehouse = new WH_Warehouse();
            if (dr["Warehouse_ID"] != DBNull.Value) wH_Warehouse.Warehouse_ID = Convert.ToDecimal(dr["Warehouse_ID"]);
            if (dr["Warehouse_Code"] != DBNull.Value) wH_Warehouse.Warehouse_Code = Convert.ToString(dr["Warehouse_Code"]);
            if (dr["Warehouse_Name"] != DBNull.Value) wH_Warehouse.Warehouse_Name = Convert.ToString(dr["Warehouse_Name"]);
            if (dr["Warehouse_No"] != DBNull.Value) wH_Warehouse.Warehouse_No = Convert.ToInt32(dr["Warehouse_No"]);
            if (dr["Warehouse_Intro"] != DBNull.Value) wH_Warehouse.Warehouse_Intro = Convert.ToString(dr["Warehouse_Intro"]);
            if (dr["Warehouse_Usage"] != DBNull.Value) wH_Warehouse.Warehouse_Usage = Convert.ToString(dr["Warehouse_Usage"]);
            if (dr["Warehouse_Addr"] != DBNull.Value) wH_Warehouse.Warehouse_Addr = Convert.ToString(dr["Warehouse_Addr"]);
            if (dr["Warehouse_PCode"] != DBNull.Value) wH_Warehouse.Warehouse_PCode = Convert.ToString(dr["Warehouse_PCode"]);
            if (dr["Warehouse_Company"] != DBNull.Value) wH_Warehouse.Warehouse_Company = Convert.ToString(dr["Warehouse_Company"]);
            if (dr["Warehouse_CompanyCode"] != DBNull.Value) wH_Warehouse.Warehouse_CompanyCode = Convert.ToString(dr["Warehouse_CompanyCode"]);
            if (dr["Warehouse_Remark"] != DBNull.Value) wH_Warehouse.Warehouse_Remark = Convert.ToString(dr["Warehouse_Remark"]);
            if (dr["Warehouse_Type"] != DBNull.Value) wH_Warehouse.Warehouse_Type = Convert.ToString(dr["Warehouse_Type"]);
            if (dr["Stat"] != DBNull.Value) wH_Warehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Warehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Warehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Warehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Warehouse_Root"] != DBNull.Value) wH_Warehouse.Warehouse_Root = Convert.ToString(dr["Warehouse_Root"]);
            if (dr["Warehouse_RootName"] != DBNull.Value) wH_Warehouse.Warehouse_RootName = Convert.ToString(dr["Warehouse_RootName"]);
            if (dr["Warehouse_UDEF1"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF1 = Convert.ToString(dr["Warehouse_UDEF1"]);
            if (dr["Warehouse_UDEF2"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF2 = Convert.ToString(dr["Warehouse_UDEF2"]);
            if (dr["Warehouse_UDEF3"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF3 = Convert.ToString(dr["Warehouse_UDEF3"]);
            if (dr["Warehouse_UDEF4"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF4 = Convert.ToString(dr["Warehouse_UDEF4"]);
            if (dr["Warehouse_UDEF5"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF5 = Convert.ToString(dr["Warehouse_UDEF5"]);
            if (dr["Warehouse_UDEF6"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF6 = Convert.ToString(dr["Warehouse_UDEF6"]);
            if (dr["Warehouse_UDEF7"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF7 = Convert.ToString(dr["Warehouse_UDEF7"]);
            if (dr["Warehouse_UDEF8"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF8 = Convert.ToString(dr["Warehouse_UDEF8"]);
            if (dr["Warehouse_UDEF9"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF9 = Convert.ToString(dr["Warehouse_UDEF9"]);
            if (dr["Warehouse_UDEF10"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF10 = Convert.ToString(dr["Warehouse_UDEF10"]);
            ret.Add(wH_Warehouse);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的仓库信息 WH_Warehouse对象(即:一条记录
      /// </summary>
      public List<WH_Warehouse> GetAll()
      {
         List<WH_Warehouse> ret = new List<WH_Warehouse>();
         string sql = "SELECT  Warehouse_ID,Warehouse_Code,Warehouse_Name,Warehouse_No,Warehouse_Intro,Warehouse_Usage,Warehouse_Addr,Warehouse_PCode,Warehouse_Company,Warehouse_CompanyCode,Warehouse_Remark,Warehouse_Type,Stat,CreateDate,UpdateDate,DeleteDate,Warehouse_Root,Warehouse_RootName,Warehouse_UDEF1,Warehouse_UDEF2,Warehouse_UDEF3,Warehouse_UDEF4,Warehouse_UDEF5,Warehouse_UDEF6,Warehouse_UDEF7,Warehouse_UDEF8,Warehouse_UDEF9,Warehouse_UDEF10 FROM WH_Warehouse where 1=1 AND ((Stat is null) or (Stat=0) ) order by Warehouse_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Warehouse wH_Warehouse = new WH_Warehouse();
            if (dr["Warehouse_ID"] != DBNull.Value) wH_Warehouse.Warehouse_ID = Convert.ToDecimal(dr["Warehouse_ID"]);
            if (dr["Warehouse_Code"] != DBNull.Value) wH_Warehouse.Warehouse_Code = Convert.ToString(dr["Warehouse_Code"]);
            if (dr["Warehouse_Name"] != DBNull.Value) wH_Warehouse.Warehouse_Name = Convert.ToString(dr["Warehouse_Name"]);
            if (dr["Warehouse_No"] != DBNull.Value) wH_Warehouse.Warehouse_No = Convert.ToInt32(dr["Warehouse_No"]);
            if (dr["Warehouse_Intro"] != DBNull.Value) wH_Warehouse.Warehouse_Intro = Convert.ToString(dr["Warehouse_Intro"]);
            if (dr["Warehouse_Usage"] != DBNull.Value) wH_Warehouse.Warehouse_Usage = Convert.ToString(dr["Warehouse_Usage"]);
            if (dr["Warehouse_Addr"] != DBNull.Value) wH_Warehouse.Warehouse_Addr = Convert.ToString(dr["Warehouse_Addr"]);
            if (dr["Warehouse_PCode"] != DBNull.Value) wH_Warehouse.Warehouse_PCode = Convert.ToString(dr["Warehouse_PCode"]);
            if (dr["Warehouse_Company"] != DBNull.Value) wH_Warehouse.Warehouse_Company = Convert.ToString(dr["Warehouse_Company"]);
            if (dr["Warehouse_CompanyCode"] != DBNull.Value) wH_Warehouse.Warehouse_CompanyCode = Convert.ToString(dr["Warehouse_CompanyCode"]);
            if (dr["Warehouse_Remark"] != DBNull.Value) wH_Warehouse.Warehouse_Remark = Convert.ToString(dr["Warehouse_Remark"]);
            if (dr["Warehouse_Type"] != DBNull.Value) wH_Warehouse.Warehouse_Type = Convert.ToString(dr["Warehouse_Type"]);
            if (dr["Stat"] != DBNull.Value) wH_Warehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Warehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Warehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Warehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Warehouse_Root"] != DBNull.Value) wH_Warehouse.Warehouse_Root = Convert.ToString(dr["Warehouse_Root"]);
            if (dr["Warehouse_RootName"] != DBNull.Value) wH_Warehouse.Warehouse_RootName = Convert.ToString(dr["Warehouse_RootName"]);
            if (dr["Warehouse_UDEF1"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF1 = Convert.ToString(dr["Warehouse_UDEF1"]);
            if (dr["Warehouse_UDEF2"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF2 = Convert.ToString(dr["Warehouse_UDEF2"]);
            if (dr["Warehouse_UDEF3"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF3 = Convert.ToString(dr["Warehouse_UDEF3"]);
            if (dr["Warehouse_UDEF4"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF4 = Convert.ToString(dr["Warehouse_UDEF4"]);
            if (dr["Warehouse_UDEF5"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF5 = Convert.ToString(dr["Warehouse_UDEF5"]);
            if (dr["Warehouse_UDEF6"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF6 = Convert.ToString(dr["Warehouse_UDEF6"]);
            if (dr["Warehouse_UDEF7"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF7 = Convert.ToString(dr["Warehouse_UDEF7"]);
            if (dr["Warehouse_UDEF8"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF8 = Convert.ToString(dr["Warehouse_UDEF8"]);
            if (dr["Warehouse_UDEF9"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF9 = Convert.ToString(dr["Warehouse_UDEF9"]);
            if (dr["Warehouse_UDEF10"] != DBNull.Value) wH_Warehouse.Warehouse_UDEF10 = Convert.ToString(dr["Warehouse_UDEF10"]);
            ret.Add(wH_Warehouse);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
