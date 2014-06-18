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
   /// 客户结算单明细
   /// </summary>
   [Serializable]
   public partial class ADOSD_BItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加客户结算单明细 SD_BItem对象(即:一条记录)
      /// </summary>
      public int Add(SD_BItem sD_BItem)
      {
         string sql = "INSERT INTO SD_BItem (SDBI_Code,SDBI_SCode,SDBI_Period,SDBI_CCode,SDBI_MType,SDBI_MCode,SDBI_Name,SDBI_Num,SDBI_Unit,SDBI_Price,SDBI_Sum,SDBI_Start,SDBI_End,SDBI_Bak,CreateDate,UpdateDate,DeleteDate,Stat,SDBI_Level,SDBI_Part,SDBI_Method,SDBI_Money,SDBI_AttachementCount) VALUES (@SDBI_Code,@SDBI_SCode,@SDBI_Period,@SDBI_CCode,@SDBI_MType,@SDBI_MCode,@SDBI_Name,@SDBI_Num,@SDBI_Unit,@SDBI_Price,@SDBI_Sum,@SDBI_Start,@SDBI_End,@SDBI_Bak,@CreateDate,@UpdateDate,@DeleteDate,@Stat,@SDBI_Level,@SDBI_Part,@SDBI_Method,@SDBI_Money,@SDBI_AttachementCount)";
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Code))
         {
            idb.AddParameter("@SDBI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Code", sD_BItem.SDBI_Code);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_SCode))
         {
            idb.AddParameter("@SDBI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_SCode", sD_BItem.SDBI_SCode);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Period))
         {
            idb.AddParameter("@SDBI_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Period", sD_BItem.SDBI_Period);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_CCode))
         {
            idb.AddParameter("@SDBI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_CCode", sD_BItem.SDBI_CCode);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_MType))
         {
            idb.AddParameter("@SDBI_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_MType", sD_BItem.SDBI_MType);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_MCode))
         {
            idb.AddParameter("@SDBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_MCode", sD_BItem.SDBI_MCode);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Name))
         {
            idb.AddParameter("@SDBI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Name", sD_BItem.SDBI_Name);
         }
         if (sD_BItem.SDBI_Num == 0)
         {
            idb.AddParameter("@SDBI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Num", sD_BItem.SDBI_Num);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Unit))
         {
            idb.AddParameter("@SDBI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Unit", sD_BItem.SDBI_Unit);
         }
         if (sD_BItem.SDBI_Price == 0)
         {
            idb.AddParameter("@SDBI_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Price", sD_BItem.SDBI_Price);
         }
         if (sD_BItem.SDBI_Sum == 0)
         {
            idb.AddParameter("@SDBI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Sum", sD_BItem.SDBI_Sum);
         }
         if (sD_BItem.SDBI_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDBI_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Start", sD_BItem.SDBI_Start);
         }
         if (sD_BItem.SDBI_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDBI_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_End", sD_BItem.SDBI_End);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Bak))
         {
            idb.AddParameter("@SDBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Bak", sD_BItem.SDBI_Bak);
         }
         if (sD_BItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_BItem.CreateDate);
         }
         if (sD_BItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_BItem.UpdateDate);
         }
         if (sD_BItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_BItem.DeleteDate);
         }
         if (sD_BItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_BItem.Stat);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Level))
         {
            idb.AddParameter("@SDBI_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Level", sD_BItem.SDBI_Level);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Part))
         {
            idb.AddParameter("@SDBI_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Part", sD_BItem.SDBI_Part);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Method))
         {
            idb.AddParameter("@SDBI_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Method", sD_BItem.SDBI_Method);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Money))
         {
            idb.AddParameter("@SDBI_Money", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Money", sD_BItem.SDBI_Money);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_AttachementCount))
         {
            idb.AddParameter("@SDBI_AttachementCount", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_AttachementCount", sD_BItem.SDBI_AttachementCount);
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
      /// 添加客户结算单明细 SD_BItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_BItem sD_BItem)
      {
         string sql = "INSERT INTO SD_BItem (SDBI_Code,SDBI_SCode,SDBI_Period,SDBI_CCode,SDBI_MType,SDBI_MCode,SDBI_Name,SDBI_Num,SDBI_Unit,SDBI_Price,SDBI_Sum,SDBI_Start,SDBI_End,SDBI_Bak,CreateDate,UpdateDate,DeleteDate,Stat,SDBI_Level,SDBI_Part,SDBI_Method,SDBI_Money,SDBI_AttachementCount) VALUES (@SDBI_Code,@SDBI_SCode,@SDBI_Period,@SDBI_CCode,@SDBI_MType,@SDBI_MCode,@SDBI_Name,@SDBI_Num,@SDBI_Unit,@SDBI_Price,@SDBI_Sum,@SDBI_Start,@SDBI_End,@SDBI_Bak,@CreateDate,@UpdateDate,@DeleteDate,@Stat,@SDBI_Level,@SDBI_Part,@SDBI_Method,@SDBI_Money,@SDBI_AttachementCount);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Code))
         {
            idb.AddParameter("@SDBI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Code", sD_BItem.SDBI_Code);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_SCode))
         {
            idb.AddParameter("@SDBI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_SCode", sD_BItem.SDBI_SCode);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Period))
         {
            idb.AddParameter("@SDBI_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Period", sD_BItem.SDBI_Period);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_CCode))
         {
            idb.AddParameter("@SDBI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_CCode", sD_BItem.SDBI_CCode);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_MType))
         {
            idb.AddParameter("@SDBI_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_MType", sD_BItem.SDBI_MType);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_MCode))
         {
            idb.AddParameter("@SDBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_MCode", sD_BItem.SDBI_MCode);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Name))
         {
            idb.AddParameter("@SDBI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Name", sD_BItem.SDBI_Name);
         }
         if (sD_BItem.SDBI_Num == 0)
         {
            idb.AddParameter("@SDBI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Num", sD_BItem.SDBI_Num);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Unit))
         {
            idb.AddParameter("@SDBI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Unit", sD_BItem.SDBI_Unit);
         }
         if (sD_BItem.SDBI_Price == 0)
         {
            idb.AddParameter("@SDBI_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Price", sD_BItem.SDBI_Price);
         }
         if (sD_BItem.SDBI_Sum == 0)
         {
            idb.AddParameter("@SDBI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Sum", sD_BItem.SDBI_Sum);
         }
         if (sD_BItem.SDBI_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDBI_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Start", sD_BItem.SDBI_Start);
         }
         if (sD_BItem.SDBI_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDBI_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_End", sD_BItem.SDBI_End);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Bak))
         {
            idb.AddParameter("@SDBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Bak", sD_BItem.SDBI_Bak);
         }
         if (sD_BItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_BItem.CreateDate);
         }
         if (sD_BItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_BItem.UpdateDate);
         }
         if (sD_BItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_BItem.DeleteDate);
         }
         if (sD_BItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_BItem.Stat);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Level))
         {
            idb.AddParameter("@SDBI_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Level", sD_BItem.SDBI_Level);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Part))
         {
            idb.AddParameter("@SDBI_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Part", sD_BItem.SDBI_Part);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Method))
         {
            idb.AddParameter("@SDBI_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Method", sD_BItem.SDBI_Method);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Money))
         {
            idb.AddParameter("@SDBI_Money", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Money", sD_BItem.SDBI_Money);
         }
         if (string.IsNullOrEmpty(sD_BItem.SDBI_AttachementCount))
         {
            idb.AddParameter("@SDBI_AttachementCount", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_AttachementCount", sD_BItem.SDBI_AttachementCount);
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
      /// 更新客户结算单明细 SD_BItem对象(即:一条记录
      /// </summary>
      public int Update(SD_BItem sD_BItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_BItem       SET ");
            if(sD_BItem.SDBI_Code_IsChanged){sbParameter.Append("SDBI_Code=@SDBI_Code, ");}
      if(sD_BItem.SDBI_SCode_IsChanged){sbParameter.Append("SDBI_SCode=@SDBI_SCode, ");}
      if(sD_BItem.SDBI_Period_IsChanged){sbParameter.Append("SDBI_Period=@SDBI_Period, ");}
      if(sD_BItem.SDBI_CCode_IsChanged){sbParameter.Append("SDBI_CCode=@SDBI_CCode, ");}
      if(sD_BItem.SDBI_MType_IsChanged){sbParameter.Append("SDBI_MType=@SDBI_MType, ");}
      if(sD_BItem.SDBI_MCode_IsChanged){sbParameter.Append("SDBI_MCode=@SDBI_MCode, ");}
      if(sD_BItem.SDBI_Name_IsChanged){sbParameter.Append("SDBI_Name=@SDBI_Name, ");}
      if(sD_BItem.SDBI_Num_IsChanged){sbParameter.Append("SDBI_Num=@SDBI_Num, ");}
      if(sD_BItem.SDBI_Unit_IsChanged){sbParameter.Append("SDBI_Unit=@SDBI_Unit, ");}
      if(sD_BItem.SDBI_Price_IsChanged){sbParameter.Append("SDBI_Price=@SDBI_Price, ");}
      if(sD_BItem.SDBI_Sum_IsChanged){sbParameter.Append("SDBI_Sum=@SDBI_Sum, ");}
      if(sD_BItem.SDBI_Start_IsChanged){sbParameter.Append("SDBI_Start=@SDBI_Start, ");}
      if(sD_BItem.SDBI_End_IsChanged){sbParameter.Append("SDBI_End=@SDBI_End, ");}
      if(sD_BItem.SDBI_Bak_IsChanged){sbParameter.Append("SDBI_Bak=@SDBI_Bak, ");}
      if(sD_BItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_BItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_BItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_BItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_BItem.SDBI_Level_IsChanged){sbParameter.Append("SDBI_Level=@SDBI_Level, ");}
      if(sD_BItem.SDBI_Part_IsChanged){sbParameter.Append("SDBI_Part=@SDBI_Part, ");}
      if(sD_BItem.SDBI_Method_IsChanged){sbParameter.Append("SDBI_Method=@SDBI_Method, ");}
      if(sD_BItem.SDBI_Money_IsChanged){sbParameter.Append("SDBI_Money=@SDBI_Money, ");}
      if(sD_BItem.SDBI_AttachementCount_IsChanged){sbParameter.Append("SDBI_AttachementCount=@SDBI_AttachementCount ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDBI_ID=@SDBI_ID; " );
      string sql=sb.ToString();
         if(sD_BItem.SDBI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Code))
         {
            idb.AddParameter("@SDBI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Code", sD_BItem.SDBI_Code);
         }
          }
         if(sD_BItem.SDBI_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_SCode))
         {
            idb.AddParameter("@SDBI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_SCode", sD_BItem.SDBI_SCode);
         }
          }
         if(sD_BItem.SDBI_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Period))
         {
            idb.AddParameter("@SDBI_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Period", sD_BItem.SDBI_Period);
         }
          }
         if(sD_BItem.SDBI_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_CCode))
         {
            idb.AddParameter("@SDBI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_CCode", sD_BItem.SDBI_CCode);
         }
          }
         if(sD_BItem.SDBI_MType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_MType))
         {
            idb.AddParameter("@SDBI_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_MType", sD_BItem.SDBI_MType);
         }
          }
         if(sD_BItem.SDBI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_MCode))
         {
            idb.AddParameter("@SDBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_MCode", sD_BItem.SDBI_MCode);
         }
          }
         if(sD_BItem.SDBI_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Name))
         {
            idb.AddParameter("@SDBI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Name", sD_BItem.SDBI_Name);
         }
          }
         if(sD_BItem.SDBI_Num_IsChanged)
         {
         if (sD_BItem.SDBI_Num == 0)
         {
            idb.AddParameter("@SDBI_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Num", sD_BItem.SDBI_Num);
         }
          }
         if(sD_BItem.SDBI_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Unit))
         {
            idb.AddParameter("@SDBI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Unit", sD_BItem.SDBI_Unit);
         }
          }
         if(sD_BItem.SDBI_Price_IsChanged)
         {
         if (sD_BItem.SDBI_Price == 0)
         {
            idb.AddParameter("@SDBI_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Price", sD_BItem.SDBI_Price);
         }
          }
         if(sD_BItem.SDBI_Sum_IsChanged)
         {
         if (sD_BItem.SDBI_Sum == 0)
         {
            idb.AddParameter("@SDBI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDBI_Sum", sD_BItem.SDBI_Sum);
         }
          }
         if(sD_BItem.SDBI_Start_IsChanged)
         {
         if (sD_BItem.SDBI_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDBI_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Start", sD_BItem.SDBI_Start);
         }
          }
         if(sD_BItem.SDBI_End_IsChanged)
         {
         if (sD_BItem.SDBI_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDBI_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_End", sD_BItem.SDBI_End);
         }
          }
         if(sD_BItem.SDBI_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Bak))
         {
            idb.AddParameter("@SDBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Bak", sD_BItem.SDBI_Bak);
         }
          }
         if(sD_BItem.CreateDate_IsChanged)
         {
         if (sD_BItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_BItem.CreateDate);
         }
          }
         if(sD_BItem.UpdateDate_IsChanged)
         {
         if (sD_BItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_BItem.UpdateDate);
         }
          }
         if(sD_BItem.DeleteDate_IsChanged)
         {
         if (sD_BItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_BItem.DeleteDate);
         }
          }
         if(sD_BItem.Stat_IsChanged)
         {
         if (sD_BItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_BItem.Stat);
         }
          }
         if(sD_BItem.SDBI_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Level))
         {
            idb.AddParameter("@SDBI_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Level", sD_BItem.SDBI_Level);
         }
          }
         if(sD_BItem.SDBI_Part_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Part))
         {
            idb.AddParameter("@SDBI_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Part", sD_BItem.SDBI_Part);
         }
          }
         if(sD_BItem.SDBI_Method_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Method))
         {
            idb.AddParameter("@SDBI_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Method", sD_BItem.SDBI_Method);
         }
          }
         if(sD_BItem.SDBI_Money_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_Money))
         {
            idb.AddParameter("@SDBI_Money", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_Money", sD_BItem.SDBI_Money);
         }
          }
         if(sD_BItem.SDBI_AttachementCount_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_BItem.SDBI_AttachementCount))
         {
            idb.AddParameter("@SDBI_AttachementCount", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDBI_AttachementCount", sD_BItem.SDBI_AttachementCount);
         }
          }

         idb.AddParameter("@SDBI_ID", sD_BItem.SDBI_ID);

           
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
      /// 删除客户结算单明细 SD_BItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDBI_ID)
      {
         string sql = "DELETE SD_BItem WHERE 1=1  AND SDBI_ID=@SDBI_ID ";
         idb.AddParameter("@SDBI_ID", sDBI_ID);

           
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
      /// 获取指定的客户结算单明细 SD_BItem对象(即:一条记录
      /// </summary>
      public SD_BItem GetByKey(decimal sDBI_ID)
      {
         SD_BItem sD_BItem = new SD_BItem();
         string sql = "SELECT  SDBI_ID,SDBI_Code,SDBI_SCode,SDBI_Period,SDBI_CCode,SDBI_MType,SDBI_MCode,SDBI_Name,SDBI_Num,SDBI_Unit,SDBI_Price,SDBI_Sum,SDBI_Start,SDBI_End,SDBI_Bak,CreateDate,UpdateDate,DeleteDate,Stat,SDBI_Level,SDBI_Part,SDBI_Method,SDBI_Money,SDBI_AttachementCount FROM SD_BItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDBI_ID=@SDBI_ID ";
         idb.AddParameter("@SDBI_ID", sDBI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDBI_ID"] != DBNull.Value) sD_BItem.SDBI_ID = Convert.ToDecimal(dr["SDBI_ID"]);
            if (dr["SDBI_Code"] != DBNull.Value) sD_BItem.SDBI_Code = Convert.ToString(dr["SDBI_Code"]);
            if (dr["SDBI_SCode"] != DBNull.Value) sD_BItem.SDBI_SCode = Convert.ToString(dr["SDBI_SCode"]);
            if (dr["SDBI_Period"] != DBNull.Value) sD_BItem.SDBI_Period = Convert.ToString(dr["SDBI_Period"]);
            if (dr["SDBI_CCode"] != DBNull.Value) sD_BItem.SDBI_CCode = Convert.ToString(dr["SDBI_CCode"]);
            if (dr["SDBI_MType"] != DBNull.Value) sD_BItem.SDBI_MType = Convert.ToString(dr["SDBI_MType"]);
            if (dr["SDBI_MCode"] != DBNull.Value) sD_BItem.SDBI_MCode = Convert.ToString(dr["SDBI_MCode"]);
            if (dr["SDBI_Name"] != DBNull.Value) sD_BItem.SDBI_Name = Convert.ToString(dr["SDBI_Name"]);
            if (dr["SDBI_Num"] != DBNull.Value) sD_BItem.SDBI_Num = Convert.ToDecimal(dr["SDBI_Num"]);
            if (dr["SDBI_Unit"] != DBNull.Value) sD_BItem.SDBI_Unit = Convert.ToString(dr["SDBI_Unit"]);
            if (dr["SDBI_Price"] != DBNull.Value) sD_BItem.SDBI_Price = Convert.ToDecimal(dr["SDBI_Price"]);
            if (dr["SDBI_Sum"] != DBNull.Value) sD_BItem.SDBI_Sum = Convert.ToDecimal(dr["SDBI_Sum"]);
            if (dr["SDBI_Start"] != DBNull.Value) sD_BItem.SDBI_Start = Convert.ToDateTime(dr["SDBI_Start"]);
            if (dr["SDBI_End"] != DBNull.Value) sD_BItem.SDBI_End = Convert.ToDateTime(dr["SDBI_End"]);
            if (dr["SDBI_Bak"] != DBNull.Value) sD_BItem.SDBI_Bak = Convert.ToString(dr["SDBI_Bak"]);
            if (dr["CreateDate"] != DBNull.Value) sD_BItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_BItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_BItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) sD_BItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDBI_Level"] != DBNull.Value) sD_BItem.SDBI_Level = Convert.ToString(dr["SDBI_Level"]);
            if (dr["SDBI_Part"] != DBNull.Value) sD_BItem.SDBI_Part = Convert.ToString(dr["SDBI_Part"]);
            if (dr["SDBI_Method"] != DBNull.Value) sD_BItem.SDBI_Method = Convert.ToString(dr["SDBI_Method"]);
            if (dr["SDBI_Money"] != DBNull.Value) sD_BItem.SDBI_Money = Convert.ToString(dr["SDBI_Money"]);
            if (dr["SDBI_AttachementCount"] != DBNull.Value) sD_BItem.SDBI_AttachementCount = Convert.ToString(dr["SDBI_AttachementCount"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_BItem;
      }
      /// <summary>
      /// 获取指定的客户结算单明细 SD_BItem对象集合
      /// </summary>
      public List<SD_BItem> GetListByWhere(string strCondition)
      {
         List<SD_BItem> ret = new List<SD_BItem>();
         string sql = "SELECT  SDBI_ID,SDBI_Code,SDBI_SCode,SDBI_Period,SDBI_CCode,SDBI_MType,SDBI_MCode,SDBI_Name,SDBI_Num,SDBI_Unit,SDBI_Price,SDBI_Sum,SDBI_Start,SDBI_End,SDBI_Bak,CreateDate,UpdateDate,DeleteDate,Stat,SDBI_Level,SDBI_Part,SDBI_Method,SDBI_Money,SDBI_AttachementCount FROM SD_BItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_BItem sD_BItem = new SD_BItem();
            if (dr["SDBI_ID"] != DBNull.Value) sD_BItem.SDBI_ID = Convert.ToDecimal(dr["SDBI_ID"]);
            if (dr["SDBI_Code"] != DBNull.Value) sD_BItem.SDBI_Code = Convert.ToString(dr["SDBI_Code"]);
            if (dr["SDBI_SCode"] != DBNull.Value) sD_BItem.SDBI_SCode = Convert.ToString(dr["SDBI_SCode"]);
            if (dr["SDBI_Period"] != DBNull.Value) sD_BItem.SDBI_Period = Convert.ToString(dr["SDBI_Period"]);
            if (dr["SDBI_CCode"] != DBNull.Value) sD_BItem.SDBI_CCode = Convert.ToString(dr["SDBI_CCode"]);
            if (dr["SDBI_MType"] != DBNull.Value) sD_BItem.SDBI_MType = Convert.ToString(dr["SDBI_MType"]);
            if (dr["SDBI_MCode"] != DBNull.Value) sD_BItem.SDBI_MCode = Convert.ToString(dr["SDBI_MCode"]);
            if (dr["SDBI_Name"] != DBNull.Value) sD_BItem.SDBI_Name = Convert.ToString(dr["SDBI_Name"]);
            if (dr["SDBI_Num"] != DBNull.Value) sD_BItem.SDBI_Num = Convert.ToDecimal(dr["SDBI_Num"]);
            if (dr["SDBI_Unit"] != DBNull.Value) sD_BItem.SDBI_Unit = Convert.ToString(dr["SDBI_Unit"]);
            if (dr["SDBI_Price"] != DBNull.Value) sD_BItem.SDBI_Price = Convert.ToDecimal(dr["SDBI_Price"]);
            if (dr["SDBI_Sum"] != DBNull.Value) sD_BItem.SDBI_Sum = Convert.ToDecimal(dr["SDBI_Sum"]);
            if (dr["SDBI_Start"] != DBNull.Value) sD_BItem.SDBI_Start = Convert.ToDateTime(dr["SDBI_Start"]);
            if (dr["SDBI_End"] != DBNull.Value) sD_BItem.SDBI_End = Convert.ToDateTime(dr["SDBI_End"]);
            if (dr["SDBI_Bak"] != DBNull.Value) sD_BItem.SDBI_Bak = Convert.ToString(dr["SDBI_Bak"]);
            if (dr["CreateDate"] != DBNull.Value) sD_BItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_BItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_BItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) sD_BItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDBI_Level"] != DBNull.Value) sD_BItem.SDBI_Level = Convert.ToString(dr["SDBI_Level"]);
            if (dr["SDBI_Part"] != DBNull.Value) sD_BItem.SDBI_Part = Convert.ToString(dr["SDBI_Part"]);
            if (dr["SDBI_Method"] != DBNull.Value) sD_BItem.SDBI_Method = Convert.ToString(dr["SDBI_Method"]);
            if (dr["SDBI_Money"] != DBNull.Value) sD_BItem.SDBI_Money = Convert.ToString(dr["SDBI_Money"]);
            if (dr["SDBI_AttachementCount"] != DBNull.Value) sD_BItem.SDBI_AttachementCount = Convert.ToString(dr["SDBI_AttachementCount"]);
            ret.Add(sD_BItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的客户结算单明细 SD_BItem对象(即:一条记录
      /// </summary>
      public List<SD_BItem> GetAll()
      {
         List<SD_BItem> ret = new List<SD_BItem>();
         string sql = "SELECT  SDBI_ID,SDBI_Code,SDBI_SCode,SDBI_Period,SDBI_CCode,SDBI_MType,SDBI_MCode,SDBI_Name,SDBI_Num,SDBI_Unit,SDBI_Price,SDBI_Sum,SDBI_Start,SDBI_End,SDBI_Bak,CreateDate,UpdateDate,DeleteDate,Stat,SDBI_Level,SDBI_Part,SDBI_Method,SDBI_Money,SDBI_AttachementCount FROM SD_BItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDBI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_BItem sD_BItem = new SD_BItem();
            if (dr["SDBI_ID"] != DBNull.Value) sD_BItem.SDBI_ID = Convert.ToDecimal(dr["SDBI_ID"]);
            if (dr["SDBI_Code"] != DBNull.Value) sD_BItem.SDBI_Code = Convert.ToString(dr["SDBI_Code"]);
            if (dr["SDBI_SCode"] != DBNull.Value) sD_BItem.SDBI_SCode = Convert.ToString(dr["SDBI_SCode"]);
            if (dr["SDBI_Period"] != DBNull.Value) sD_BItem.SDBI_Period = Convert.ToString(dr["SDBI_Period"]);
            if (dr["SDBI_CCode"] != DBNull.Value) sD_BItem.SDBI_CCode = Convert.ToString(dr["SDBI_CCode"]);
            if (dr["SDBI_MType"] != DBNull.Value) sD_BItem.SDBI_MType = Convert.ToString(dr["SDBI_MType"]);
            if (dr["SDBI_MCode"] != DBNull.Value) sD_BItem.SDBI_MCode = Convert.ToString(dr["SDBI_MCode"]);
            if (dr["SDBI_Name"] != DBNull.Value) sD_BItem.SDBI_Name = Convert.ToString(dr["SDBI_Name"]);
            if (dr["SDBI_Num"] != DBNull.Value) sD_BItem.SDBI_Num = Convert.ToDecimal(dr["SDBI_Num"]);
            if (dr["SDBI_Unit"] != DBNull.Value) sD_BItem.SDBI_Unit = Convert.ToString(dr["SDBI_Unit"]);
            if (dr["SDBI_Price"] != DBNull.Value) sD_BItem.SDBI_Price = Convert.ToDecimal(dr["SDBI_Price"]);
            if (dr["SDBI_Sum"] != DBNull.Value) sD_BItem.SDBI_Sum = Convert.ToDecimal(dr["SDBI_Sum"]);
            if (dr["SDBI_Start"] != DBNull.Value) sD_BItem.SDBI_Start = Convert.ToDateTime(dr["SDBI_Start"]);
            if (dr["SDBI_End"] != DBNull.Value) sD_BItem.SDBI_End = Convert.ToDateTime(dr["SDBI_End"]);
            if (dr["SDBI_Bak"] != DBNull.Value) sD_BItem.SDBI_Bak = Convert.ToString(dr["SDBI_Bak"]);
            if (dr["CreateDate"] != DBNull.Value) sD_BItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_BItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_BItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Stat"] != DBNull.Value) sD_BItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDBI_Level"] != DBNull.Value) sD_BItem.SDBI_Level = Convert.ToString(dr["SDBI_Level"]);
            if (dr["SDBI_Part"] != DBNull.Value) sD_BItem.SDBI_Part = Convert.ToString(dr["SDBI_Part"]);
            if (dr["SDBI_Method"] != DBNull.Value) sD_BItem.SDBI_Method = Convert.ToString(dr["SDBI_Method"]);
            if (dr["SDBI_Money"] != DBNull.Value) sD_BItem.SDBI_Money = Convert.ToString(dr["SDBI_Money"]);
            if (dr["SDBI_AttachementCount"] != DBNull.Value) sD_BItem.SDBI_AttachementCount = Convert.ToString(dr["SDBI_AttachementCount"]);
            ret.Add(sD_BItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
