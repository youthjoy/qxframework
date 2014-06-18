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
   /// 甲供记录
   /// </summary>
   [Serializable]
   public partial class ADOWHR_PartyARecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加甲供记录 WHR_PartyARecord对象(即:一条记录)
      /// </summary>
      public int Add(WHR_PartyARecord wHR_PartyARecord)
      {
         string sql = "INSERT INTO WHR_PartyARecord (WHR_Code,WHR_MCode,WHR_Name,WHR_CustCode,WHR_CCode,WHR_PCode,WHR_Spec,WHR_Group,WHR_GroupCode,WHR_iType,WHR_PriceList,WHR_Unit,WHR_Units,WHR_Factory,MD_DWCode,MD_Bak,Stat,CreateDate,UpdateDate,DeleteDate,Module_Code,Record_ID) VALUES (@WHR_Code,@WHR_MCode,@WHR_Name,@WHR_CustCode,@WHR_CCode,@WHR_PCode,@WHR_Spec,@WHR_Group,@WHR_GroupCode,@WHR_iType,@WHR_PriceList,@WHR_Unit,@WHR_Units,@WHR_Factory,@MD_DWCode,@MD_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Module_Code,@Record_ID)";
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Code))
         {
            idb.AddParameter("@WHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Code", wHR_PartyARecord.WHR_Code);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_MCode))
         {
            idb.AddParameter("@WHR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_MCode", wHR_PartyARecord.WHR_MCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Name))
         {
            idb.AddParameter("@WHR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Name", wHR_PartyARecord.WHR_Name);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_CustCode))
         {
            idb.AddParameter("@WHR_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_CustCode", wHR_PartyARecord.WHR_CustCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_CCode))
         {
            idb.AddParameter("@WHR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_CCode", wHR_PartyARecord.WHR_CCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_PCode))
         {
            idb.AddParameter("@WHR_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_PCode", wHR_PartyARecord.WHR_PCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Spec))
         {
            idb.AddParameter("@WHR_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Spec", wHR_PartyARecord.WHR_Spec);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Group))
         {
            idb.AddParameter("@WHR_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Group", wHR_PartyARecord.WHR_Group);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_GroupCode))
         {
            idb.AddParameter("@WHR_GroupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_GroupCode", wHR_PartyARecord.WHR_GroupCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_iType))
         {
            idb.AddParameter("@WHR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_iType", wHR_PartyARecord.WHR_iType);
         }
         if (wHR_PartyARecord.WHR_PriceList == 0)
         {
            idb.AddParameter("@WHR_PriceList", 0);
         }
         else
         {
            idb.AddParameter("@WHR_PriceList", wHR_PartyARecord.WHR_PriceList);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Unit))
         {
            idb.AddParameter("@WHR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Unit", wHR_PartyARecord.WHR_Unit);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Units))
         {
            idb.AddParameter("@WHR_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Units", wHR_PartyARecord.WHR_Units);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Factory))
         {
            idb.AddParameter("@WHR_Factory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Factory", wHR_PartyARecord.WHR_Factory);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.MD_DWCode))
         {
            idb.AddParameter("@MD_DWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWCode", wHR_PartyARecord.MD_DWCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.MD_Bak))
         {
            idb.AddParameter("@MD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Bak", wHR_PartyARecord.MD_Bak);
         }
         if (wHR_PartyARecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wHR_PartyARecord.Stat);
         }
         if (wHR_PartyARecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wHR_PartyARecord.CreateDate);
         }
         if (wHR_PartyARecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wHR_PartyARecord.UpdateDate);
         }
         if (wHR_PartyARecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wHR_PartyARecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", wHR_PartyARecord.Module_Code);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", wHR_PartyARecord.Record_ID);
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
      /// 添加甲供记录 WHR_PartyARecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WHR_PartyARecord wHR_PartyARecord)
      {
         string sql = "INSERT INTO WHR_PartyARecord (WHR_Code,WHR_MCode,WHR_Name,WHR_CustCode,WHR_CCode,WHR_PCode,WHR_Spec,WHR_Group,WHR_GroupCode,WHR_iType,WHR_PriceList,WHR_Unit,WHR_Units,WHR_Factory,MD_DWCode,MD_Bak,Stat,CreateDate,UpdateDate,DeleteDate,Module_Code,Record_ID) VALUES (@WHR_Code,@WHR_MCode,@WHR_Name,@WHR_CustCode,@WHR_CCode,@WHR_PCode,@WHR_Spec,@WHR_Group,@WHR_GroupCode,@WHR_iType,@WHR_PriceList,@WHR_Unit,@WHR_Units,@WHR_Factory,@MD_DWCode,@MD_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@Module_Code,@Record_ID);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Code))
         {
            idb.AddParameter("@WHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Code", wHR_PartyARecord.WHR_Code);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_MCode))
         {
            idb.AddParameter("@WHR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_MCode", wHR_PartyARecord.WHR_MCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Name))
         {
            idb.AddParameter("@WHR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Name", wHR_PartyARecord.WHR_Name);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_CustCode))
         {
            idb.AddParameter("@WHR_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_CustCode", wHR_PartyARecord.WHR_CustCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_CCode))
         {
            idb.AddParameter("@WHR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_CCode", wHR_PartyARecord.WHR_CCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_PCode))
         {
            idb.AddParameter("@WHR_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_PCode", wHR_PartyARecord.WHR_PCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Spec))
         {
            idb.AddParameter("@WHR_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Spec", wHR_PartyARecord.WHR_Spec);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Group))
         {
            idb.AddParameter("@WHR_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Group", wHR_PartyARecord.WHR_Group);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_GroupCode))
         {
            idb.AddParameter("@WHR_GroupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_GroupCode", wHR_PartyARecord.WHR_GroupCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_iType))
         {
            idb.AddParameter("@WHR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_iType", wHR_PartyARecord.WHR_iType);
         }
         if (wHR_PartyARecord.WHR_PriceList == 0)
         {
            idb.AddParameter("@WHR_PriceList", 0);
         }
         else
         {
            idb.AddParameter("@WHR_PriceList", wHR_PartyARecord.WHR_PriceList);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Unit))
         {
            idb.AddParameter("@WHR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Unit", wHR_PartyARecord.WHR_Unit);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Units))
         {
            idb.AddParameter("@WHR_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Units", wHR_PartyARecord.WHR_Units);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Factory))
         {
            idb.AddParameter("@WHR_Factory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Factory", wHR_PartyARecord.WHR_Factory);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.MD_DWCode))
         {
            idb.AddParameter("@MD_DWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWCode", wHR_PartyARecord.MD_DWCode);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.MD_Bak))
         {
            idb.AddParameter("@MD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Bak", wHR_PartyARecord.MD_Bak);
         }
         if (wHR_PartyARecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wHR_PartyARecord.Stat);
         }
         if (wHR_PartyARecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wHR_PartyARecord.CreateDate);
         }
         if (wHR_PartyARecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wHR_PartyARecord.UpdateDate);
         }
         if (wHR_PartyARecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wHR_PartyARecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", wHR_PartyARecord.Module_Code);
         }
         if (string.IsNullOrEmpty(wHR_PartyARecord.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", wHR_PartyARecord.Record_ID);
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
      /// 更新甲供记录 WHR_PartyARecord对象(即:一条记录
      /// </summary>
      public int Update(WHR_PartyARecord wHR_PartyARecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WHR_PartyARecord       SET ");
            if(wHR_PartyARecord.WHR_Code_IsChanged){sbParameter.Append("WHR_Code=@WHR_Code, ");}
      if(wHR_PartyARecord.WHR_MCode_IsChanged){sbParameter.Append("WHR_MCode=@WHR_MCode, ");}
      if(wHR_PartyARecord.WHR_Name_IsChanged){sbParameter.Append("WHR_Name=@WHR_Name, ");}
      if(wHR_PartyARecord.WHR_CustCode_IsChanged){sbParameter.Append("WHR_CustCode=@WHR_CustCode, ");}
      if(wHR_PartyARecord.WHR_CCode_IsChanged){sbParameter.Append("WHR_CCode=@WHR_CCode, ");}
      if(wHR_PartyARecord.WHR_PCode_IsChanged){sbParameter.Append("WHR_PCode=@WHR_PCode, ");}
      if(wHR_PartyARecord.WHR_Spec_IsChanged){sbParameter.Append("WHR_Spec=@WHR_Spec, ");}
      if(wHR_PartyARecord.WHR_Group_IsChanged){sbParameter.Append("WHR_Group=@WHR_Group, ");}
      if(wHR_PartyARecord.WHR_GroupCode_IsChanged){sbParameter.Append("WHR_GroupCode=@WHR_GroupCode, ");}
      if(wHR_PartyARecord.WHR_iType_IsChanged){sbParameter.Append("WHR_iType=@WHR_iType, ");}
      if(wHR_PartyARecord.WHR_PriceList_IsChanged){sbParameter.Append("WHR_PriceList=@WHR_PriceList, ");}
      if(wHR_PartyARecord.WHR_Unit_IsChanged){sbParameter.Append("WHR_Unit=@WHR_Unit, ");}
      if(wHR_PartyARecord.WHR_Units_IsChanged){sbParameter.Append("WHR_Units=@WHR_Units, ");}
      if(wHR_PartyARecord.WHR_Factory_IsChanged){sbParameter.Append("WHR_Factory=@WHR_Factory, ");}
      if(wHR_PartyARecord.MD_DWCode_IsChanged){sbParameter.Append("MD_DWCode=@MD_DWCode, ");}
      if(wHR_PartyARecord.MD_Bak_IsChanged){sbParameter.Append("MD_Bak=@MD_Bak, ");}
      if(wHR_PartyARecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wHR_PartyARecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wHR_PartyARecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wHR_PartyARecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wHR_PartyARecord.Module_Code_IsChanged){sbParameter.Append("Module_Code=@Module_Code, ");}
      if(wHR_PartyARecord.Record_ID_IsChanged){sbParameter.Append("Record_ID=@Record_ID ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHR_ID=@WHR_ID; " );
      string sql=sb.ToString();
         if(wHR_PartyARecord.WHR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Code))
         {
            idb.AddParameter("@WHR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Code", wHR_PartyARecord.WHR_Code);
         }
          }
         if(wHR_PartyARecord.WHR_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_MCode))
         {
            idb.AddParameter("@WHR_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_MCode", wHR_PartyARecord.WHR_MCode);
         }
          }
         if(wHR_PartyARecord.WHR_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Name))
         {
            idb.AddParameter("@WHR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Name", wHR_PartyARecord.WHR_Name);
         }
          }
         if(wHR_PartyARecord.WHR_CustCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_CustCode))
         {
            idb.AddParameter("@WHR_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_CustCode", wHR_PartyARecord.WHR_CustCode);
         }
          }
         if(wHR_PartyARecord.WHR_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_CCode))
         {
            idb.AddParameter("@WHR_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_CCode", wHR_PartyARecord.WHR_CCode);
         }
          }
         if(wHR_PartyARecord.WHR_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_PCode))
         {
            idb.AddParameter("@WHR_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_PCode", wHR_PartyARecord.WHR_PCode);
         }
          }
         if(wHR_PartyARecord.WHR_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Spec))
         {
            idb.AddParameter("@WHR_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Spec", wHR_PartyARecord.WHR_Spec);
         }
          }
         if(wHR_PartyARecord.WHR_Group_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Group))
         {
            idb.AddParameter("@WHR_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Group", wHR_PartyARecord.WHR_Group);
         }
          }
         if(wHR_PartyARecord.WHR_GroupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_GroupCode))
         {
            idb.AddParameter("@WHR_GroupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_GroupCode", wHR_PartyARecord.WHR_GroupCode);
         }
          }
         if(wHR_PartyARecord.WHR_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_iType))
         {
            idb.AddParameter("@WHR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_iType", wHR_PartyARecord.WHR_iType);
         }
          }
         if(wHR_PartyARecord.WHR_PriceList_IsChanged)
         {
         if (wHR_PartyARecord.WHR_PriceList == 0)
         {
            idb.AddParameter("@WHR_PriceList", 0);
         }
         else
         {
            idb.AddParameter("@WHR_PriceList", wHR_PartyARecord.WHR_PriceList);
         }
          }
         if(wHR_PartyARecord.WHR_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Unit))
         {
            idb.AddParameter("@WHR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Unit", wHR_PartyARecord.WHR_Unit);
         }
          }
         if(wHR_PartyARecord.WHR_Units_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Units))
         {
            idb.AddParameter("@WHR_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Units", wHR_PartyARecord.WHR_Units);
         }
          }
         if(wHR_PartyARecord.WHR_Factory_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.WHR_Factory))
         {
            idb.AddParameter("@WHR_Factory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHR_Factory", wHR_PartyARecord.WHR_Factory);
         }
          }
         if(wHR_PartyARecord.MD_DWCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.MD_DWCode))
         {
            idb.AddParameter("@MD_DWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWCode", wHR_PartyARecord.MD_DWCode);
         }
          }
         if(wHR_PartyARecord.MD_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.MD_Bak))
         {
            idb.AddParameter("@MD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Bak", wHR_PartyARecord.MD_Bak);
         }
          }
         if(wHR_PartyARecord.Stat_IsChanged)
         {
         if (wHR_PartyARecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wHR_PartyARecord.Stat);
         }
          }
         if(wHR_PartyARecord.CreateDate_IsChanged)
         {
         if (wHR_PartyARecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wHR_PartyARecord.CreateDate);
         }
          }
         if(wHR_PartyARecord.UpdateDate_IsChanged)
         {
         if (wHR_PartyARecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wHR_PartyARecord.UpdateDate);
         }
          }
         if(wHR_PartyARecord.DeleteDate_IsChanged)
         {
         if (wHR_PartyARecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wHR_PartyARecord.DeleteDate);
         }
          }
         if(wHR_PartyARecord.Module_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.Module_Code))
         {
            idb.AddParameter("@Module_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Module_Code", wHR_PartyARecord.Module_Code);
         }
          }
         if(wHR_PartyARecord.Record_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(wHR_PartyARecord.Record_ID))
         {
            idb.AddParameter("@Record_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Record_ID", wHR_PartyARecord.Record_ID);
         }
          }

         idb.AddParameter("@WHR_ID", wHR_PartyARecord.WHR_ID);

           
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
      /// 删除甲供记录 WHR_PartyARecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHR_ID)
      {
         string sql = "DELETE WHR_PartyARecord WHERE 1=1  AND WHR_ID=@WHR_ID ";
         idb.AddParameter("@WHR_ID", wHR_ID);

           
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
      /// 获取指定的甲供记录 WHR_PartyARecord对象(即:一条记录
      /// </summary>
      public WHR_PartyARecord GetByKey(decimal wHR_ID)
      {
         WHR_PartyARecord wHR_PartyARecord = new WHR_PartyARecord();
         string sql = "SELECT  WHR_ID,WHR_Code,WHR_MCode,WHR_Name,WHR_CustCode,WHR_CCode,WHR_PCode,WHR_Spec,WHR_Group,WHR_GroupCode,WHR_iType,WHR_PriceList,WHR_Unit,WHR_Units,WHR_Factory,MD_DWCode,MD_Bak,Stat,CreateDate,UpdateDate,DeleteDate,Module_Code,Record_ID FROM WHR_PartyARecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHR_ID=@WHR_ID ";
         idb.AddParameter("@WHR_ID", wHR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHR_ID"] != DBNull.Value) wHR_PartyARecord.WHR_ID = Convert.ToDecimal(dr["WHR_ID"]);
            if (dr["WHR_Code"] != DBNull.Value) wHR_PartyARecord.WHR_Code = Convert.ToString(dr["WHR_Code"]);
            if (dr["WHR_MCode"] != DBNull.Value) wHR_PartyARecord.WHR_MCode = Convert.ToString(dr["WHR_MCode"]);
            if (dr["WHR_Name"] != DBNull.Value) wHR_PartyARecord.WHR_Name = Convert.ToString(dr["WHR_Name"]);
            if (dr["WHR_CustCode"] != DBNull.Value) wHR_PartyARecord.WHR_CustCode = Convert.ToString(dr["WHR_CustCode"]);
            if (dr["WHR_CCode"] != DBNull.Value) wHR_PartyARecord.WHR_CCode = Convert.ToString(dr["WHR_CCode"]);
            if (dr["WHR_PCode"] != DBNull.Value) wHR_PartyARecord.WHR_PCode = Convert.ToString(dr["WHR_PCode"]);
            if (dr["WHR_Spec"] != DBNull.Value) wHR_PartyARecord.WHR_Spec = Convert.ToString(dr["WHR_Spec"]);
            if (dr["WHR_Group"] != DBNull.Value) wHR_PartyARecord.WHR_Group = Convert.ToString(dr["WHR_Group"]);
            if (dr["WHR_GroupCode"] != DBNull.Value) wHR_PartyARecord.WHR_GroupCode = Convert.ToString(dr["WHR_GroupCode"]);
            if (dr["WHR_iType"] != DBNull.Value) wHR_PartyARecord.WHR_iType = Convert.ToString(dr["WHR_iType"]);
            if (dr["WHR_PriceList"] != DBNull.Value) wHR_PartyARecord.WHR_PriceList = Convert.ToDecimal(dr["WHR_PriceList"]);
            if (dr["WHR_Unit"] != DBNull.Value) wHR_PartyARecord.WHR_Unit = Convert.ToString(dr["WHR_Unit"]);
            if (dr["WHR_Units"] != DBNull.Value) wHR_PartyARecord.WHR_Units = Convert.ToString(dr["WHR_Units"]);
            if (dr["WHR_Factory"] != DBNull.Value) wHR_PartyARecord.WHR_Factory = Convert.ToString(dr["WHR_Factory"]);
            if (dr["MD_DWCode"] != DBNull.Value) wHR_PartyARecord.MD_DWCode = Convert.ToString(dr["MD_DWCode"]);
            if (dr["MD_Bak"] != DBNull.Value) wHR_PartyARecord.MD_Bak = Convert.ToString(dr["MD_Bak"]);
            if (dr["Stat"] != DBNull.Value) wHR_PartyARecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wHR_PartyARecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wHR_PartyARecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wHR_PartyARecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Module_Code"] != DBNull.Value) wHR_PartyARecord.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) wHR_PartyARecord.Record_ID = Convert.ToString(dr["Record_ID"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wHR_PartyARecord;
      }
      /// <summary>
      /// 获取指定的甲供记录 WHR_PartyARecord对象集合
      /// </summary>
      public List<WHR_PartyARecord> GetListByWhere(string strCondition)
      {
         List<WHR_PartyARecord> ret = new List<WHR_PartyARecord>();
         string sql = "SELECT  WHR_ID,WHR_Code,WHR_MCode,WHR_Name,WHR_CustCode,WHR_CCode,WHR_PCode,WHR_Spec,WHR_Group,WHR_GroupCode,WHR_iType,WHR_PriceList,WHR_Unit,WHR_Units,WHR_Factory,MD_DWCode,MD_Bak,Stat,CreateDate,UpdateDate,DeleteDate,Module_Code,Record_ID FROM WHR_PartyARecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WHR_PartyARecord wHR_PartyARecord = new WHR_PartyARecord();
            if (dr["WHR_ID"] != DBNull.Value) wHR_PartyARecord.WHR_ID = Convert.ToDecimal(dr["WHR_ID"]);
            if (dr["WHR_Code"] != DBNull.Value) wHR_PartyARecord.WHR_Code = Convert.ToString(dr["WHR_Code"]);
            if (dr["WHR_MCode"] != DBNull.Value) wHR_PartyARecord.WHR_MCode = Convert.ToString(dr["WHR_MCode"]);
            if (dr["WHR_Name"] != DBNull.Value) wHR_PartyARecord.WHR_Name = Convert.ToString(dr["WHR_Name"]);
            if (dr["WHR_CustCode"] != DBNull.Value) wHR_PartyARecord.WHR_CustCode = Convert.ToString(dr["WHR_CustCode"]);
            if (dr["WHR_CCode"] != DBNull.Value) wHR_PartyARecord.WHR_CCode = Convert.ToString(dr["WHR_CCode"]);
            if (dr["WHR_PCode"] != DBNull.Value) wHR_PartyARecord.WHR_PCode = Convert.ToString(dr["WHR_PCode"]);
            if (dr["WHR_Spec"] != DBNull.Value) wHR_PartyARecord.WHR_Spec = Convert.ToString(dr["WHR_Spec"]);
            if (dr["WHR_Group"] != DBNull.Value) wHR_PartyARecord.WHR_Group = Convert.ToString(dr["WHR_Group"]);
            if (dr["WHR_GroupCode"] != DBNull.Value) wHR_PartyARecord.WHR_GroupCode = Convert.ToString(dr["WHR_GroupCode"]);
            if (dr["WHR_iType"] != DBNull.Value) wHR_PartyARecord.WHR_iType = Convert.ToString(dr["WHR_iType"]);
            if (dr["WHR_PriceList"] != DBNull.Value) wHR_PartyARecord.WHR_PriceList = Convert.ToDecimal(dr["WHR_PriceList"]);
            if (dr["WHR_Unit"] != DBNull.Value) wHR_PartyARecord.WHR_Unit = Convert.ToString(dr["WHR_Unit"]);
            if (dr["WHR_Units"] != DBNull.Value) wHR_PartyARecord.WHR_Units = Convert.ToString(dr["WHR_Units"]);
            if (dr["WHR_Factory"] != DBNull.Value) wHR_PartyARecord.WHR_Factory = Convert.ToString(dr["WHR_Factory"]);
            if (dr["MD_DWCode"] != DBNull.Value) wHR_PartyARecord.MD_DWCode = Convert.ToString(dr["MD_DWCode"]);
            if (dr["MD_Bak"] != DBNull.Value) wHR_PartyARecord.MD_Bak = Convert.ToString(dr["MD_Bak"]);
            if (dr["Stat"] != DBNull.Value) wHR_PartyARecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wHR_PartyARecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wHR_PartyARecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wHR_PartyARecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Module_Code"] != DBNull.Value) wHR_PartyARecord.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) wHR_PartyARecord.Record_ID = Convert.ToString(dr["Record_ID"]);
            ret.Add(wHR_PartyARecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的甲供记录 WHR_PartyARecord对象(即:一条记录
      /// </summary>
      public List<WHR_PartyARecord> GetAll()
      {
         List<WHR_PartyARecord> ret = new List<WHR_PartyARecord>();
         string sql = "SELECT  WHR_ID,WHR_Code,WHR_MCode,WHR_Name,WHR_CustCode,WHR_CCode,WHR_PCode,WHR_Spec,WHR_Group,WHR_GroupCode,WHR_iType,WHR_PriceList,WHR_Unit,WHR_Units,WHR_Factory,MD_DWCode,MD_Bak,Stat,CreateDate,UpdateDate,DeleteDate,Module_Code,Record_ID FROM WHR_PartyARecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WHR_PartyARecord wHR_PartyARecord = new WHR_PartyARecord();
            if (dr["WHR_ID"] != DBNull.Value) wHR_PartyARecord.WHR_ID = Convert.ToDecimal(dr["WHR_ID"]);
            if (dr["WHR_Code"] != DBNull.Value) wHR_PartyARecord.WHR_Code = Convert.ToString(dr["WHR_Code"]);
            if (dr["WHR_MCode"] != DBNull.Value) wHR_PartyARecord.WHR_MCode = Convert.ToString(dr["WHR_MCode"]);
            if (dr["WHR_Name"] != DBNull.Value) wHR_PartyARecord.WHR_Name = Convert.ToString(dr["WHR_Name"]);
            if (dr["WHR_CustCode"] != DBNull.Value) wHR_PartyARecord.WHR_CustCode = Convert.ToString(dr["WHR_CustCode"]);
            if (dr["WHR_CCode"] != DBNull.Value) wHR_PartyARecord.WHR_CCode = Convert.ToString(dr["WHR_CCode"]);
            if (dr["WHR_PCode"] != DBNull.Value) wHR_PartyARecord.WHR_PCode = Convert.ToString(dr["WHR_PCode"]);
            if (dr["WHR_Spec"] != DBNull.Value) wHR_PartyARecord.WHR_Spec = Convert.ToString(dr["WHR_Spec"]);
            if (dr["WHR_Group"] != DBNull.Value) wHR_PartyARecord.WHR_Group = Convert.ToString(dr["WHR_Group"]);
            if (dr["WHR_GroupCode"] != DBNull.Value) wHR_PartyARecord.WHR_GroupCode = Convert.ToString(dr["WHR_GroupCode"]);
            if (dr["WHR_iType"] != DBNull.Value) wHR_PartyARecord.WHR_iType = Convert.ToString(dr["WHR_iType"]);
            if (dr["WHR_PriceList"] != DBNull.Value) wHR_PartyARecord.WHR_PriceList = Convert.ToDecimal(dr["WHR_PriceList"]);
            if (dr["WHR_Unit"] != DBNull.Value) wHR_PartyARecord.WHR_Unit = Convert.ToString(dr["WHR_Unit"]);
            if (dr["WHR_Units"] != DBNull.Value) wHR_PartyARecord.WHR_Units = Convert.ToString(dr["WHR_Units"]);
            if (dr["WHR_Factory"] != DBNull.Value) wHR_PartyARecord.WHR_Factory = Convert.ToString(dr["WHR_Factory"]);
            if (dr["MD_DWCode"] != DBNull.Value) wHR_PartyARecord.MD_DWCode = Convert.ToString(dr["MD_DWCode"]);
            if (dr["MD_Bak"] != DBNull.Value) wHR_PartyARecord.MD_Bak = Convert.ToString(dr["MD_Bak"]);
            if (dr["Stat"] != DBNull.Value) wHR_PartyARecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wHR_PartyARecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wHR_PartyARecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wHR_PartyARecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Module_Code"] != DBNull.Value) wHR_PartyARecord.Module_Code = Convert.ToString(dr["Module_Code"]);
            if (dr["Record_ID"] != DBNull.Value) wHR_PartyARecord.Record_ID = Convert.ToString(dr["Record_ID"]);
            ret.Add(wHR_PartyARecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
