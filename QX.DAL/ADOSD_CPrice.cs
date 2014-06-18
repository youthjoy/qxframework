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
   /// 销售合同价格
   /// </summary>
   [Serializable]
   public partial class ADOSD_CPrice
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加销售合同价格 SD_CPrice对象(即:一条记录)
      /// </summary>
      public int Add(SD_CPrice sD_CPrice)
      {
         string sql = "INSERT INTO SD_CPrice (SDP_Code,SDP_SCode,SDP_CCode,SDP_Category,SDP_ProName,SDP_ProCode,SDP_Start,SDP_End,SDP_Price,SDP_Remark,SDP_Unit,Stat,CreateDate,UpdateDate,DeleteDate,SDP_Level,SDP_UDEF1,SDP_UDEF2,SDP_UDEF3,SDP_UDEF4,SDP_UDEF5,SDP_UDEF6,SDP_UDEF7,SDP_UDEF8,SDP_UDEF9,SDP_UDEF10) VALUES (@SDP_Code,@SDP_SCode,@SDP_CCode,@SDP_Category,@SDP_ProName,@SDP_ProCode,@SDP_Start,@SDP_End,@SDP_Price,@SDP_Remark,@SDP_Unit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDP_Level,@SDP_UDEF1,@SDP_UDEF2,@SDP_UDEF3,@SDP_UDEF4,@SDP_UDEF5,@SDP_UDEF6,@SDP_UDEF7,@SDP_UDEF8,@SDP_UDEF9,@SDP_UDEF10)";
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Code))
         {
            idb.AddParameter("@SDP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Code", sD_CPrice.SDP_Code);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_SCode))
         {
            idb.AddParameter("@SDP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_SCode", sD_CPrice.SDP_SCode);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_CCode))
         {
            idb.AddParameter("@SDP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_CCode", sD_CPrice.SDP_CCode);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Category))
         {
            idb.AddParameter("@SDP_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Category", sD_CPrice.SDP_Category);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_ProName))
         {
            idb.AddParameter("@SDP_ProName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_ProName", sD_CPrice.SDP_ProName);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_ProCode))
         {
            idb.AddParameter("@SDP_ProCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_ProCode", sD_CPrice.SDP_ProCode);
         }
         if (sD_CPrice.SDP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Start", sD_CPrice.SDP_Start);
         }
         if (sD_CPrice.SDP_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_End", sD_CPrice.SDP_End);
         }
         if (sD_CPrice.SDP_Price == 0)
         {
            idb.AddParameter("@SDP_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDP_Price", sD_CPrice.SDP_Price);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Remark))
         {
            idb.AddParameter("@SDP_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Remark", sD_CPrice.SDP_Remark);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Unit))
         {
            idb.AddParameter("@SDP_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Unit", sD_CPrice.SDP_Unit);
         }
         if (sD_CPrice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CPrice.Stat);
         }
         if (sD_CPrice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_CPrice.CreateDate);
         }
         if (sD_CPrice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_CPrice.UpdateDate);
         }
         if (sD_CPrice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_CPrice.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Level))
         {
            idb.AddParameter("@SDP_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Level", sD_CPrice.SDP_Level);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF1))
         {
            idb.AddParameter("@SDP_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF1", sD_CPrice.SDP_UDEF1);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF2))
         {
            idb.AddParameter("@SDP_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF2", sD_CPrice.SDP_UDEF2);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF3))
         {
            idb.AddParameter("@SDP_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF3", sD_CPrice.SDP_UDEF3);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF4))
         {
            idb.AddParameter("@SDP_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF4", sD_CPrice.SDP_UDEF4);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF5))
         {
            idb.AddParameter("@SDP_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF5", sD_CPrice.SDP_UDEF5);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF6))
         {
            idb.AddParameter("@SDP_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF6", sD_CPrice.SDP_UDEF6);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF7))
         {
            idb.AddParameter("@SDP_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF7", sD_CPrice.SDP_UDEF7);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF8))
         {
            idb.AddParameter("@SDP_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF8", sD_CPrice.SDP_UDEF8);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF9))
         {
            idb.AddParameter("@SDP_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF9", sD_CPrice.SDP_UDEF9);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF10))
         {
            idb.AddParameter("@SDP_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF10", sD_CPrice.SDP_UDEF10);
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
      /// 添加销售合同价格 SD_CPrice对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_CPrice sD_CPrice)
      {
         string sql = "INSERT INTO SD_CPrice (SDP_Code,SDP_SCode,SDP_CCode,SDP_Category,SDP_ProName,SDP_ProCode,SDP_Start,SDP_End,SDP_Price,SDP_Remark,SDP_Unit,Stat,CreateDate,UpdateDate,DeleteDate,SDP_Level,SDP_UDEF1,SDP_UDEF2,SDP_UDEF3,SDP_UDEF4,SDP_UDEF5,SDP_UDEF6,SDP_UDEF7,SDP_UDEF8,SDP_UDEF9,SDP_UDEF10) VALUES (@SDP_Code,@SDP_SCode,@SDP_CCode,@SDP_Category,@SDP_ProName,@SDP_ProCode,@SDP_Start,@SDP_End,@SDP_Price,@SDP_Remark,@SDP_Unit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDP_Level,@SDP_UDEF1,@SDP_UDEF2,@SDP_UDEF3,@SDP_UDEF4,@SDP_UDEF5,@SDP_UDEF6,@SDP_UDEF7,@SDP_UDEF8,@SDP_UDEF9,@SDP_UDEF10);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Code))
         {
            idb.AddParameter("@SDP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Code", sD_CPrice.SDP_Code);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_SCode))
         {
            idb.AddParameter("@SDP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_SCode", sD_CPrice.SDP_SCode);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_CCode))
         {
            idb.AddParameter("@SDP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_CCode", sD_CPrice.SDP_CCode);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Category))
         {
            idb.AddParameter("@SDP_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Category", sD_CPrice.SDP_Category);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_ProName))
         {
            idb.AddParameter("@SDP_ProName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_ProName", sD_CPrice.SDP_ProName);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_ProCode))
         {
            idb.AddParameter("@SDP_ProCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_ProCode", sD_CPrice.SDP_ProCode);
         }
         if (sD_CPrice.SDP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Start", sD_CPrice.SDP_Start);
         }
         if (sD_CPrice.SDP_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_End", sD_CPrice.SDP_End);
         }
         if (sD_CPrice.SDP_Price == 0)
         {
            idb.AddParameter("@SDP_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDP_Price", sD_CPrice.SDP_Price);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Remark))
         {
            idb.AddParameter("@SDP_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Remark", sD_CPrice.SDP_Remark);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Unit))
         {
            idb.AddParameter("@SDP_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Unit", sD_CPrice.SDP_Unit);
         }
         if (sD_CPrice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CPrice.Stat);
         }
         if (sD_CPrice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_CPrice.CreateDate);
         }
         if (sD_CPrice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_CPrice.UpdateDate);
         }
         if (sD_CPrice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_CPrice.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Level))
         {
            idb.AddParameter("@SDP_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Level", sD_CPrice.SDP_Level);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF1))
         {
            idb.AddParameter("@SDP_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF1", sD_CPrice.SDP_UDEF1);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF2))
         {
            idb.AddParameter("@SDP_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF2", sD_CPrice.SDP_UDEF2);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF3))
         {
            idb.AddParameter("@SDP_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF3", sD_CPrice.SDP_UDEF3);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF4))
         {
            idb.AddParameter("@SDP_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF4", sD_CPrice.SDP_UDEF4);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF5))
         {
            idb.AddParameter("@SDP_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF5", sD_CPrice.SDP_UDEF5);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF6))
         {
            idb.AddParameter("@SDP_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF6", sD_CPrice.SDP_UDEF6);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF7))
         {
            idb.AddParameter("@SDP_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF7", sD_CPrice.SDP_UDEF7);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF8))
         {
            idb.AddParameter("@SDP_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF8", sD_CPrice.SDP_UDEF8);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF9))
         {
            idb.AddParameter("@SDP_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF9", sD_CPrice.SDP_UDEF9);
         }
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF10))
         {
            idb.AddParameter("@SDP_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF10", sD_CPrice.SDP_UDEF10);
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
      /// 更新销售合同价格 SD_CPrice对象(即:一条记录
      /// </summary>
      public int Update(SD_CPrice sD_CPrice)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_CPrice       SET ");
            if(sD_CPrice.SDP_Code_IsChanged){sbParameter.Append("SDP_Code=@SDP_Code, ");}
      if(sD_CPrice.SDP_SCode_IsChanged){sbParameter.Append("SDP_SCode=@SDP_SCode, ");}
      if(sD_CPrice.SDP_CCode_IsChanged){sbParameter.Append("SDP_CCode=@SDP_CCode, ");}
      if(sD_CPrice.SDP_Category_IsChanged){sbParameter.Append("SDP_Category=@SDP_Category, ");}
      if(sD_CPrice.SDP_ProName_IsChanged){sbParameter.Append("SDP_ProName=@SDP_ProName, ");}
      if(sD_CPrice.SDP_ProCode_IsChanged){sbParameter.Append("SDP_ProCode=@SDP_ProCode, ");}
      if(sD_CPrice.SDP_Start_IsChanged){sbParameter.Append("SDP_Start=@SDP_Start, ");}
      if(sD_CPrice.SDP_End_IsChanged){sbParameter.Append("SDP_End=@SDP_End, ");}
      if(sD_CPrice.SDP_Price_IsChanged){sbParameter.Append("SDP_Price=@SDP_Price, ");}
      if(sD_CPrice.SDP_Remark_IsChanged){sbParameter.Append("SDP_Remark=@SDP_Remark, ");}
      if(sD_CPrice.SDP_Unit_IsChanged){sbParameter.Append("SDP_Unit=@SDP_Unit, ");}
      if(sD_CPrice.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_CPrice.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_CPrice.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_CPrice.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_CPrice.SDP_Level_IsChanged){sbParameter.Append("SDP_Level=@SDP_Level, ");}
      if(sD_CPrice.SDP_UDEF1_IsChanged){sbParameter.Append("SDP_UDEF1=@SDP_UDEF1, ");}
      if(sD_CPrice.SDP_UDEF2_IsChanged){sbParameter.Append("SDP_UDEF2=@SDP_UDEF2, ");}
      if(sD_CPrice.SDP_UDEF3_IsChanged){sbParameter.Append("SDP_UDEF3=@SDP_UDEF3, ");}
      if(sD_CPrice.SDP_UDEF4_IsChanged){sbParameter.Append("SDP_UDEF4=@SDP_UDEF4, ");}
      if(sD_CPrice.SDP_UDEF5_IsChanged){sbParameter.Append("SDP_UDEF5=@SDP_UDEF5, ");}
      if(sD_CPrice.SDP_UDEF6_IsChanged){sbParameter.Append("SDP_UDEF6=@SDP_UDEF6, ");}
      if(sD_CPrice.SDP_UDEF7_IsChanged){sbParameter.Append("SDP_UDEF7=@SDP_UDEF7, ");}
      if(sD_CPrice.SDP_UDEF8_IsChanged){sbParameter.Append("SDP_UDEF8=@SDP_UDEF8, ");}
      if(sD_CPrice.SDP_UDEF9_IsChanged){sbParameter.Append("SDP_UDEF9=@SDP_UDEF9, ");}
      if(sD_CPrice.SDP_UDEF10_IsChanged){sbParameter.Append("SDP_UDEF10=@SDP_UDEF10 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDP_ID=@SDP_ID; " );
      string sql=sb.ToString();
         if(sD_CPrice.SDP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Code))
         {
            idb.AddParameter("@SDP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Code", sD_CPrice.SDP_Code);
         }
          }
         if(sD_CPrice.SDP_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_SCode))
         {
            idb.AddParameter("@SDP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_SCode", sD_CPrice.SDP_SCode);
         }
          }
         if(sD_CPrice.SDP_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_CCode))
         {
            idb.AddParameter("@SDP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_CCode", sD_CPrice.SDP_CCode);
         }
          }
         if(sD_CPrice.SDP_Category_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Category))
         {
            idb.AddParameter("@SDP_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Category", sD_CPrice.SDP_Category);
         }
          }
         if(sD_CPrice.SDP_ProName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_ProName))
         {
            idb.AddParameter("@SDP_ProName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_ProName", sD_CPrice.SDP_ProName);
         }
          }
         if(sD_CPrice.SDP_ProCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_ProCode))
         {
            idb.AddParameter("@SDP_ProCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_ProCode", sD_CPrice.SDP_ProCode);
         }
          }
         if(sD_CPrice.SDP_Start_IsChanged)
         {
         if (sD_CPrice.SDP_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDP_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Start", sD_CPrice.SDP_Start);
         }
          }
         if(sD_CPrice.SDP_End_IsChanged)
         {
         if (sD_CPrice.SDP_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDP_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_End", sD_CPrice.SDP_End);
         }
          }
         if(sD_CPrice.SDP_Price_IsChanged)
         {
         if (sD_CPrice.SDP_Price == 0)
         {
            idb.AddParameter("@SDP_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDP_Price", sD_CPrice.SDP_Price);
         }
          }
         if(sD_CPrice.SDP_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Remark))
         {
            idb.AddParameter("@SDP_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Remark", sD_CPrice.SDP_Remark);
         }
          }
         if(sD_CPrice.SDP_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Unit))
         {
            idb.AddParameter("@SDP_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Unit", sD_CPrice.SDP_Unit);
         }
          }
         if(sD_CPrice.Stat_IsChanged)
         {
         if (sD_CPrice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CPrice.Stat);
         }
          }
         if(sD_CPrice.CreateDate_IsChanged)
         {
         if (sD_CPrice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_CPrice.CreateDate);
         }
          }
         if(sD_CPrice.UpdateDate_IsChanged)
         {
         if (sD_CPrice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_CPrice.UpdateDate);
         }
          }
         if(sD_CPrice.DeleteDate_IsChanged)
         {
         if (sD_CPrice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_CPrice.DeleteDate);
         }
          }
         if(sD_CPrice.SDP_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_Level))
         {
            idb.AddParameter("@SDP_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_Level", sD_CPrice.SDP_Level);
         }
          }
         if(sD_CPrice.SDP_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF1))
         {
            idb.AddParameter("@SDP_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF1", sD_CPrice.SDP_UDEF1);
         }
          }
         if(sD_CPrice.SDP_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF2))
         {
            idb.AddParameter("@SDP_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF2", sD_CPrice.SDP_UDEF2);
         }
          }
         if(sD_CPrice.SDP_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF3))
         {
            idb.AddParameter("@SDP_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF3", sD_CPrice.SDP_UDEF3);
         }
          }
         if(sD_CPrice.SDP_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF4))
         {
            idb.AddParameter("@SDP_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF4", sD_CPrice.SDP_UDEF4);
         }
          }
         if(sD_CPrice.SDP_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF5))
         {
            idb.AddParameter("@SDP_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF5", sD_CPrice.SDP_UDEF5);
         }
          }
         if(sD_CPrice.SDP_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF6))
         {
            idb.AddParameter("@SDP_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF6", sD_CPrice.SDP_UDEF6);
         }
          }
         if(sD_CPrice.SDP_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF7))
         {
            idb.AddParameter("@SDP_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF7", sD_CPrice.SDP_UDEF7);
         }
          }
         if(sD_CPrice.SDP_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF8))
         {
            idb.AddParameter("@SDP_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF8", sD_CPrice.SDP_UDEF8);
         }
          }
         if(sD_CPrice.SDP_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF9))
         {
            idb.AddParameter("@SDP_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF9", sD_CPrice.SDP_UDEF9);
         }
          }
         if(sD_CPrice.SDP_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CPrice.SDP_UDEF10))
         {
            idb.AddParameter("@SDP_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDP_UDEF10", sD_CPrice.SDP_UDEF10);
         }
          }

         idb.AddParameter("@SDP_ID", sD_CPrice.SDP_ID);

           
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
      /// 删除销售合同价格 SD_CPrice对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDP_ID)
      {
         string sql = "DELETE SD_CPrice WHERE 1=1  AND SDP_ID=@SDP_ID ";
         idb.AddParameter("@SDP_ID", sDP_ID);

           
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
      /// 获取指定的销售合同价格 SD_CPrice对象(即:一条记录
      /// </summary>
      public SD_CPrice GetByKey(decimal sDP_ID)
      {
         SD_CPrice sD_CPrice = new SD_CPrice();
         string sql = "SELECT  SDP_ID,SDP_Code,SDP_SCode,SDP_CCode,SDP_Category,SDP_ProName,SDP_ProCode,SDP_Start,SDP_End,SDP_Price,SDP_Remark,SDP_Unit,Stat,CreateDate,UpdateDate,DeleteDate,SDP_Level,SDP_UDEF1,SDP_UDEF2,SDP_UDEF3,SDP_UDEF4,SDP_UDEF5,SDP_UDEF6,SDP_UDEF7,SDP_UDEF8,SDP_UDEF9,SDP_UDEF10 FROM SD_CPrice WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDP_ID=@SDP_ID ";
         idb.AddParameter("@SDP_ID", sDP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDP_ID"] != DBNull.Value) sD_CPrice.SDP_ID = Convert.ToDecimal(dr["SDP_ID"]);
            if (dr["SDP_Code"] != DBNull.Value) sD_CPrice.SDP_Code = Convert.ToString(dr["SDP_Code"]);
            if (dr["SDP_SCode"] != DBNull.Value) sD_CPrice.SDP_SCode = Convert.ToString(dr["SDP_SCode"]);
            if (dr["SDP_CCode"] != DBNull.Value) sD_CPrice.SDP_CCode = Convert.ToString(dr["SDP_CCode"]);
            if (dr["SDP_Category"] != DBNull.Value) sD_CPrice.SDP_Category = Convert.ToString(dr["SDP_Category"]);
            if (dr["SDP_ProName"] != DBNull.Value) sD_CPrice.SDP_ProName = Convert.ToString(dr["SDP_ProName"]);
            if (dr["SDP_ProCode"] != DBNull.Value) sD_CPrice.SDP_ProCode = Convert.ToString(dr["SDP_ProCode"]);
            if (dr["SDP_Start"] != DBNull.Value) sD_CPrice.SDP_Start = Convert.ToDateTime(dr["SDP_Start"]);
            if (dr["SDP_End"] != DBNull.Value) sD_CPrice.SDP_End = Convert.ToDateTime(dr["SDP_End"]);
            if (dr["SDP_Price"] != DBNull.Value) sD_CPrice.SDP_Price = Convert.ToDecimal(dr["SDP_Price"]);
            if (dr["SDP_Remark"] != DBNull.Value) sD_CPrice.SDP_Remark = Convert.ToString(dr["SDP_Remark"]);
            if (dr["SDP_Unit"] != DBNull.Value) sD_CPrice.SDP_Unit = Convert.ToString(dr["SDP_Unit"]);
            if (dr["Stat"] != DBNull.Value) sD_CPrice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_CPrice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_CPrice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_CPrice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDP_Level"] != DBNull.Value) sD_CPrice.SDP_Level = Convert.ToString(dr["SDP_Level"]);
            if (dr["SDP_UDEF1"] != DBNull.Value) sD_CPrice.SDP_UDEF1 = Convert.ToString(dr["SDP_UDEF1"]);
            if (dr["SDP_UDEF2"] != DBNull.Value) sD_CPrice.SDP_UDEF2 = Convert.ToString(dr["SDP_UDEF2"]);
            if (dr["SDP_UDEF3"] != DBNull.Value) sD_CPrice.SDP_UDEF3 = Convert.ToString(dr["SDP_UDEF3"]);
            if (dr["SDP_UDEF4"] != DBNull.Value) sD_CPrice.SDP_UDEF4 = Convert.ToString(dr["SDP_UDEF4"]);
            if (dr["SDP_UDEF5"] != DBNull.Value) sD_CPrice.SDP_UDEF5 = Convert.ToString(dr["SDP_UDEF5"]);
            if (dr["SDP_UDEF6"] != DBNull.Value) sD_CPrice.SDP_UDEF6 = Convert.ToString(dr["SDP_UDEF6"]);
            if (dr["SDP_UDEF7"] != DBNull.Value) sD_CPrice.SDP_UDEF7 = Convert.ToString(dr["SDP_UDEF7"]);
            if (dr["SDP_UDEF8"] != DBNull.Value) sD_CPrice.SDP_UDEF8 = Convert.ToString(dr["SDP_UDEF8"]);
            if (dr["SDP_UDEF9"] != DBNull.Value) sD_CPrice.SDP_UDEF9 = Convert.ToString(dr["SDP_UDEF9"]);
            if (dr["SDP_UDEF10"] != DBNull.Value) sD_CPrice.SDP_UDEF10 = Convert.ToString(dr["SDP_UDEF10"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_CPrice;
      }
      /// <summary>
      /// 获取指定的销售合同价格 SD_CPrice对象集合
      /// </summary>
      public List<SD_CPrice> GetListByWhere(string strCondition)
      {
         List<SD_CPrice> ret = new List<SD_CPrice>();
         string sql = "SELECT  SDP_ID,SDP_Code,SDP_SCode,SDP_CCode,SDP_Category,SDP_ProName,SDP_ProCode,SDP_Start,SDP_End,SDP_Price,SDP_Remark,SDP_Unit,Stat,CreateDate,UpdateDate,DeleteDate,SDP_Level,SDP_UDEF1,SDP_UDEF2,SDP_UDEF3,SDP_UDEF4,SDP_UDEF5,SDP_UDEF6,SDP_UDEF7,SDP_UDEF8,SDP_UDEF9,SDP_UDEF10 FROM SD_CPrice WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_CPrice sD_CPrice = new SD_CPrice();
            if (dr["SDP_ID"] != DBNull.Value) sD_CPrice.SDP_ID = Convert.ToDecimal(dr["SDP_ID"]);
            if (dr["SDP_Code"] != DBNull.Value) sD_CPrice.SDP_Code = Convert.ToString(dr["SDP_Code"]);
            if (dr["SDP_SCode"] != DBNull.Value) sD_CPrice.SDP_SCode = Convert.ToString(dr["SDP_SCode"]);
            if (dr["SDP_CCode"] != DBNull.Value) sD_CPrice.SDP_CCode = Convert.ToString(dr["SDP_CCode"]);
            if (dr["SDP_Category"] != DBNull.Value) sD_CPrice.SDP_Category = Convert.ToString(dr["SDP_Category"]);
            if (dr["SDP_ProName"] != DBNull.Value) sD_CPrice.SDP_ProName = Convert.ToString(dr["SDP_ProName"]);
            if (dr["SDP_ProCode"] != DBNull.Value) sD_CPrice.SDP_ProCode = Convert.ToString(dr["SDP_ProCode"]);
            if (dr["SDP_Start"] != DBNull.Value) sD_CPrice.SDP_Start = Convert.ToDateTime(dr["SDP_Start"]);
            if (dr["SDP_End"] != DBNull.Value) sD_CPrice.SDP_End = Convert.ToDateTime(dr["SDP_End"]);
            if (dr["SDP_Price"] != DBNull.Value) sD_CPrice.SDP_Price = Convert.ToDecimal(dr["SDP_Price"]);
            if (dr["SDP_Remark"] != DBNull.Value) sD_CPrice.SDP_Remark = Convert.ToString(dr["SDP_Remark"]);
            if (dr["SDP_Unit"] != DBNull.Value) sD_CPrice.SDP_Unit = Convert.ToString(dr["SDP_Unit"]);
            if (dr["Stat"] != DBNull.Value) sD_CPrice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_CPrice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_CPrice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_CPrice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDP_Level"] != DBNull.Value) sD_CPrice.SDP_Level = Convert.ToString(dr["SDP_Level"]);
            if (dr["SDP_UDEF1"] != DBNull.Value) sD_CPrice.SDP_UDEF1 = Convert.ToString(dr["SDP_UDEF1"]);
            if (dr["SDP_UDEF2"] != DBNull.Value) sD_CPrice.SDP_UDEF2 = Convert.ToString(dr["SDP_UDEF2"]);
            if (dr["SDP_UDEF3"] != DBNull.Value) sD_CPrice.SDP_UDEF3 = Convert.ToString(dr["SDP_UDEF3"]);
            if (dr["SDP_UDEF4"] != DBNull.Value) sD_CPrice.SDP_UDEF4 = Convert.ToString(dr["SDP_UDEF4"]);
            if (dr["SDP_UDEF5"] != DBNull.Value) sD_CPrice.SDP_UDEF5 = Convert.ToString(dr["SDP_UDEF5"]);
            if (dr["SDP_UDEF6"] != DBNull.Value) sD_CPrice.SDP_UDEF6 = Convert.ToString(dr["SDP_UDEF6"]);
            if (dr["SDP_UDEF7"] != DBNull.Value) sD_CPrice.SDP_UDEF7 = Convert.ToString(dr["SDP_UDEF7"]);
            if (dr["SDP_UDEF8"] != DBNull.Value) sD_CPrice.SDP_UDEF8 = Convert.ToString(dr["SDP_UDEF8"]);
            if (dr["SDP_UDEF9"] != DBNull.Value) sD_CPrice.SDP_UDEF9 = Convert.ToString(dr["SDP_UDEF9"]);
            if (dr["SDP_UDEF10"] != DBNull.Value) sD_CPrice.SDP_UDEF10 = Convert.ToString(dr["SDP_UDEF10"]);
            ret.Add(sD_CPrice);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的销售合同价格 SD_CPrice对象(即:一条记录
      /// </summary>
      public List<SD_CPrice> GetAll()
      {
         List<SD_CPrice> ret = new List<SD_CPrice>();
         string sql = "SELECT  SDP_ID,SDP_Code,SDP_SCode,SDP_CCode,SDP_Category,SDP_ProName,SDP_ProCode,SDP_Start,SDP_End,SDP_Price,SDP_Remark,SDP_Unit,Stat,CreateDate,UpdateDate,DeleteDate,SDP_Level,SDP_UDEF1,SDP_UDEF2,SDP_UDEF3,SDP_UDEF4,SDP_UDEF5,SDP_UDEF6,SDP_UDEF7,SDP_UDEF8,SDP_UDEF9,SDP_UDEF10 FROM SD_CPrice where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_CPrice sD_CPrice = new SD_CPrice();
            if (dr["SDP_ID"] != DBNull.Value) sD_CPrice.SDP_ID = Convert.ToDecimal(dr["SDP_ID"]);
            if (dr["SDP_Code"] != DBNull.Value) sD_CPrice.SDP_Code = Convert.ToString(dr["SDP_Code"]);
            if (dr["SDP_SCode"] != DBNull.Value) sD_CPrice.SDP_SCode = Convert.ToString(dr["SDP_SCode"]);
            if (dr["SDP_CCode"] != DBNull.Value) sD_CPrice.SDP_CCode = Convert.ToString(dr["SDP_CCode"]);
            if (dr["SDP_Category"] != DBNull.Value) sD_CPrice.SDP_Category = Convert.ToString(dr["SDP_Category"]);
            if (dr["SDP_ProName"] != DBNull.Value) sD_CPrice.SDP_ProName = Convert.ToString(dr["SDP_ProName"]);
            if (dr["SDP_ProCode"] != DBNull.Value) sD_CPrice.SDP_ProCode = Convert.ToString(dr["SDP_ProCode"]);
            if (dr["SDP_Start"] != DBNull.Value) sD_CPrice.SDP_Start = Convert.ToDateTime(dr["SDP_Start"]);
            if (dr["SDP_End"] != DBNull.Value) sD_CPrice.SDP_End = Convert.ToDateTime(dr["SDP_End"]);
            if (dr["SDP_Price"] != DBNull.Value) sD_CPrice.SDP_Price = Convert.ToDecimal(dr["SDP_Price"]);
            if (dr["SDP_Remark"] != DBNull.Value) sD_CPrice.SDP_Remark = Convert.ToString(dr["SDP_Remark"]);
            if (dr["SDP_Unit"] != DBNull.Value) sD_CPrice.SDP_Unit = Convert.ToString(dr["SDP_Unit"]);
            if (dr["Stat"] != DBNull.Value) sD_CPrice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_CPrice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_CPrice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_CPrice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDP_Level"] != DBNull.Value) sD_CPrice.SDP_Level = Convert.ToString(dr["SDP_Level"]);
            if (dr["SDP_UDEF1"] != DBNull.Value) sD_CPrice.SDP_UDEF1 = Convert.ToString(dr["SDP_UDEF1"]);
            if (dr["SDP_UDEF2"] != DBNull.Value) sD_CPrice.SDP_UDEF2 = Convert.ToString(dr["SDP_UDEF2"]);
            if (dr["SDP_UDEF3"] != DBNull.Value) sD_CPrice.SDP_UDEF3 = Convert.ToString(dr["SDP_UDEF3"]);
            if (dr["SDP_UDEF4"] != DBNull.Value) sD_CPrice.SDP_UDEF4 = Convert.ToString(dr["SDP_UDEF4"]);
            if (dr["SDP_UDEF5"] != DBNull.Value) sD_CPrice.SDP_UDEF5 = Convert.ToString(dr["SDP_UDEF5"]);
            if (dr["SDP_UDEF6"] != DBNull.Value) sD_CPrice.SDP_UDEF6 = Convert.ToString(dr["SDP_UDEF6"]);
            if (dr["SDP_UDEF7"] != DBNull.Value) sD_CPrice.SDP_UDEF7 = Convert.ToString(dr["SDP_UDEF7"]);
            if (dr["SDP_UDEF8"] != DBNull.Value) sD_CPrice.SDP_UDEF8 = Convert.ToString(dr["SDP_UDEF8"]);
            if (dr["SDP_UDEF9"] != DBNull.Value) sD_CPrice.SDP_UDEF9 = Convert.ToString(dr["SDP_UDEF9"]);
            if (dr["SDP_UDEF10"] != DBNull.Value) sD_CPrice.SDP_UDEF10 = Convert.ToString(dr["SDP_UDEF10"]);
            ret.Add(sD_CPrice);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
