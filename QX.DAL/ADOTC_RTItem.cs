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
   public partial class ADOTC_RTItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加TC_RTItem对象(即:一条记录)
      /// </summary>
      public int Add(TC_RTItem tC_RTItem)
      {
         string sql = "INSERT INTO TC_RTItem (TCRTI_Code,TCRTI_TCode,TCRTI_PCode,TCRTI_Name,TCRTI_Max,TCRTI_Min,TCRTI_Standard,TCRTI_RefVal,TCRTI_TypeName,TCRTI_Type,TCRTI_DictKey,TCRTI_Stat,TCRTI_Order,TCRTI_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCRTI_Code,@TCRTI_TCode,@TCRTI_PCode,@TCRTI_Name,@TCRTI_Max,@TCRTI_Min,@TCRTI_Standard,@TCRTI_RefVal,@TCRTI_TypeName,@TCRTI_Type,@TCRTI_DictKey,@TCRTI_Stat,@TCRTI_Order,@TCRTI_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Code))
         {
            idb.AddParameter("@TCRTI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Code", tC_RTItem.TCRTI_Code);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_TCode))
         {
            idb.AddParameter("@TCRTI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_TCode", tC_RTItem.TCRTI_TCode);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_PCode))
         {
            idb.AddParameter("@TCRTI_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_PCode", tC_RTItem.TCRTI_PCode);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Name))
         {
            idb.AddParameter("@TCRTI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Name", tC_RTItem.TCRTI_Name);
         }
         if (tC_RTItem.TCRTI_Max == 0)
         {
            idb.AddParameter("@TCRTI_Max", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Max", tC_RTItem.TCRTI_Max);
         }
         if (tC_RTItem.TCRTI_Min == 0)
         {
            idb.AddParameter("@TCRTI_Min", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Min", tC_RTItem.TCRTI_Min);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Standard))
         {
            idb.AddParameter("@TCRTI_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Standard", tC_RTItem.TCRTI_Standard);
         }
         if (tC_RTItem.TCRTI_RefVal == 0)
         {
            idb.AddParameter("@TCRTI_RefVal", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_RefVal", tC_RTItem.TCRTI_RefVal);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_TypeName))
         {
            idb.AddParameter("@TCRTI_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_TypeName", tC_RTItem.TCRTI_TypeName);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Type))
         {
            idb.AddParameter("@TCRTI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Type", tC_RTItem.TCRTI_Type);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_DictKey))
         {
            idb.AddParameter("@TCRTI_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_DictKey", tC_RTItem.TCRTI_DictKey);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Stat))
         {
            idb.AddParameter("@TCRTI_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Stat", tC_RTItem.TCRTI_Stat);
         }
         if (tC_RTItem.TCRTI_Order == 0)
         {
            idb.AddParameter("@TCRTI_Order", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Order", tC_RTItem.TCRTI_Order);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Remark))
         {
            idb.AddParameter("@TCRTI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Remark", tC_RTItem.TCRTI_Remark);
         }
         if (tC_RTItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RTItem.Stat);
         }
         if (tC_RTItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RTItem.CreateDate);
         }
         if (tC_RTItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RTItem.UpdateDate);
         }
         if (tC_RTItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RTItem.DeleteDate);
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
      /// 添加TC_RTItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_RTItem tC_RTItem)
      {
         string sql = "INSERT INTO TC_RTItem (TCRTI_Code,TCRTI_TCode,TCRTI_PCode,TCRTI_Name,TCRTI_Max,TCRTI_Min,TCRTI_Standard,TCRTI_RefVal,TCRTI_TypeName,TCRTI_Type,TCRTI_DictKey,TCRTI_Stat,TCRTI_Order,TCRTI_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCRTI_Code,@TCRTI_TCode,@TCRTI_PCode,@TCRTI_Name,@TCRTI_Max,@TCRTI_Min,@TCRTI_Standard,@TCRTI_RefVal,@TCRTI_TypeName,@TCRTI_Type,@TCRTI_DictKey,@TCRTI_Stat,@TCRTI_Order,@TCRTI_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Code))
         {
            idb.AddParameter("@TCRTI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Code", tC_RTItem.TCRTI_Code);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_TCode))
         {
            idb.AddParameter("@TCRTI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_TCode", tC_RTItem.TCRTI_TCode);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_PCode))
         {
            idb.AddParameter("@TCRTI_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_PCode", tC_RTItem.TCRTI_PCode);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Name))
         {
            idb.AddParameter("@TCRTI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Name", tC_RTItem.TCRTI_Name);
         }
         if (tC_RTItem.TCRTI_Max == 0)
         {
            idb.AddParameter("@TCRTI_Max", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Max", tC_RTItem.TCRTI_Max);
         }
         if (tC_RTItem.TCRTI_Min == 0)
         {
            idb.AddParameter("@TCRTI_Min", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Min", tC_RTItem.TCRTI_Min);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Standard))
         {
            idb.AddParameter("@TCRTI_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Standard", tC_RTItem.TCRTI_Standard);
         }
         if (tC_RTItem.TCRTI_RefVal == 0)
         {
            idb.AddParameter("@TCRTI_RefVal", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_RefVal", tC_RTItem.TCRTI_RefVal);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_TypeName))
         {
            idb.AddParameter("@TCRTI_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_TypeName", tC_RTItem.TCRTI_TypeName);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Type))
         {
            idb.AddParameter("@TCRTI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Type", tC_RTItem.TCRTI_Type);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_DictKey))
         {
            idb.AddParameter("@TCRTI_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_DictKey", tC_RTItem.TCRTI_DictKey);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Stat))
         {
            idb.AddParameter("@TCRTI_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Stat", tC_RTItem.TCRTI_Stat);
         }
         if (tC_RTItem.TCRTI_Order == 0)
         {
            idb.AddParameter("@TCRTI_Order", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Order", tC_RTItem.TCRTI_Order);
         }
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Remark))
         {
            idb.AddParameter("@TCRTI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Remark", tC_RTItem.TCRTI_Remark);
         }
         if (tC_RTItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RTItem.Stat);
         }
         if (tC_RTItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RTItem.CreateDate);
         }
         if (tC_RTItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RTItem.UpdateDate);
         }
         if (tC_RTItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RTItem.DeleteDate);
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
      /// 更新TC_RTItem对象(即:一条记录
      /// </summary>
      public int Update(TC_RTItem tC_RTItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_RTItem       SET ");
            if(tC_RTItem.TCRTI_Code_IsChanged){sbParameter.Append("TCRTI_Code=@TCRTI_Code, ");}
      if(tC_RTItem.TCRTI_TCode_IsChanged){sbParameter.Append("TCRTI_TCode=@TCRTI_TCode, ");}
      if(tC_RTItem.TCRTI_PCode_IsChanged){sbParameter.Append("TCRTI_PCode=@TCRTI_PCode, ");}
      if(tC_RTItem.TCRTI_Name_IsChanged){sbParameter.Append("TCRTI_Name=@TCRTI_Name, ");}
      if(tC_RTItem.TCRTI_Max_IsChanged){sbParameter.Append("TCRTI_Max=@TCRTI_Max, ");}
      if(tC_RTItem.TCRTI_Min_IsChanged){sbParameter.Append("TCRTI_Min=@TCRTI_Min, ");}
      if(tC_RTItem.TCRTI_Standard_IsChanged){sbParameter.Append("TCRTI_Standard=@TCRTI_Standard, ");}
      if(tC_RTItem.TCRTI_RefVal_IsChanged){sbParameter.Append("TCRTI_RefVal=@TCRTI_RefVal, ");}
      if(tC_RTItem.TCRTI_TypeName_IsChanged){sbParameter.Append("TCRTI_TypeName=@TCRTI_TypeName, ");}
      if(tC_RTItem.TCRTI_Type_IsChanged){sbParameter.Append("TCRTI_Type=@TCRTI_Type, ");}
      if(tC_RTItem.TCRTI_DictKey_IsChanged){sbParameter.Append("TCRTI_DictKey=@TCRTI_DictKey, ");}
      if(tC_RTItem.TCRTI_Stat_IsChanged){sbParameter.Append("TCRTI_Stat=@TCRTI_Stat, ");}
      if(tC_RTItem.TCRTI_Order_IsChanged){sbParameter.Append("TCRTI_Order=@TCRTI_Order, ");}
      if(tC_RTItem.TCRTI_Remark_IsChanged){sbParameter.Append("TCRTI_Remark=@TCRTI_Remark, ");}
      if(tC_RTItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_RTItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_RTItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_RTItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCRTI_ID=@TCRTI_ID; " );
      string sql=sb.ToString();
         if(tC_RTItem.TCRTI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Code))
         {
            idb.AddParameter("@TCRTI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Code", tC_RTItem.TCRTI_Code);
         }
          }
         if(tC_RTItem.TCRTI_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_TCode))
         {
            idb.AddParameter("@TCRTI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_TCode", tC_RTItem.TCRTI_TCode);
         }
          }
         if(tC_RTItem.TCRTI_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_PCode))
         {
            idb.AddParameter("@TCRTI_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_PCode", tC_RTItem.TCRTI_PCode);
         }
          }
         if(tC_RTItem.TCRTI_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Name))
         {
            idb.AddParameter("@TCRTI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Name", tC_RTItem.TCRTI_Name);
         }
          }
         if(tC_RTItem.TCRTI_Max_IsChanged)
         {
         if (tC_RTItem.TCRTI_Max == 0)
         {
            idb.AddParameter("@TCRTI_Max", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Max", tC_RTItem.TCRTI_Max);
         }
          }
         if(tC_RTItem.TCRTI_Min_IsChanged)
         {
         if (tC_RTItem.TCRTI_Min == 0)
         {
            idb.AddParameter("@TCRTI_Min", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Min", tC_RTItem.TCRTI_Min);
         }
          }
         if(tC_RTItem.TCRTI_Standard_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Standard))
         {
            idb.AddParameter("@TCRTI_Standard", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Standard", tC_RTItem.TCRTI_Standard);
         }
          }
         if(tC_RTItem.TCRTI_RefVal_IsChanged)
         {
         if (tC_RTItem.TCRTI_RefVal == 0)
         {
            idb.AddParameter("@TCRTI_RefVal", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_RefVal", tC_RTItem.TCRTI_RefVal);
         }
          }
         if(tC_RTItem.TCRTI_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_TypeName))
         {
            idb.AddParameter("@TCRTI_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_TypeName", tC_RTItem.TCRTI_TypeName);
         }
          }
         if(tC_RTItem.TCRTI_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Type))
         {
            idb.AddParameter("@TCRTI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Type", tC_RTItem.TCRTI_Type);
         }
          }
         if(tC_RTItem.TCRTI_DictKey_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_DictKey))
         {
            idb.AddParameter("@TCRTI_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_DictKey", tC_RTItem.TCRTI_DictKey);
         }
          }
         if(tC_RTItem.TCRTI_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Stat))
         {
            idb.AddParameter("@TCRTI_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Stat", tC_RTItem.TCRTI_Stat);
         }
          }
         if(tC_RTItem.TCRTI_Order_IsChanged)
         {
         if (tC_RTItem.TCRTI_Order == 0)
         {
            idb.AddParameter("@TCRTI_Order", 0);
         }
         else
         {
            idb.AddParameter("@TCRTI_Order", tC_RTItem.TCRTI_Order);
         }
          }
         if(tC_RTItem.TCRTI_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_RTItem.TCRTI_Remark))
         {
            idb.AddParameter("@TCRTI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCRTI_Remark", tC_RTItem.TCRTI_Remark);
         }
          }
         if(tC_RTItem.Stat_IsChanged)
         {
         if (tC_RTItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_RTItem.Stat);
         }
          }
         if(tC_RTItem.CreateDate_IsChanged)
         {
         if (tC_RTItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_RTItem.CreateDate);
         }
          }
         if(tC_RTItem.UpdateDate_IsChanged)
         {
         if (tC_RTItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_RTItem.UpdateDate);
         }
          }
         if(tC_RTItem.DeleteDate_IsChanged)
         {
         if (tC_RTItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_RTItem.DeleteDate);
         }
          }

         idb.AddParameter("@TCRTI_ID", tC_RTItem.TCRTI_ID);

           
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
      /// 删除TC_RTItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCRTI_ID)
      {
         string sql = "DELETE TC_RTItem WHERE 1=1  AND TCRTI_ID=@TCRTI_ID ";
         idb.AddParameter("@TCRTI_ID", tCRTI_ID);

           
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
      /// 获取指定的TC_RTItem对象(即:一条记录
      /// </summary>
      public TC_RTItem GetByKey(decimal tCRTI_ID)
      {
         TC_RTItem tC_RTItem = new TC_RTItem();
         string sql = "SELECT  TCRTI_ID,TCRTI_Code,TCRTI_TCode,TCRTI_PCode,TCRTI_Name,TCRTI_Max,TCRTI_Min,TCRTI_Standard,TCRTI_RefVal,TCRTI_TypeName,TCRTI_Type,TCRTI_DictKey,TCRTI_Stat,TCRTI_Order,TCRTI_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RTItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCRTI_ID=@TCRTI_ID ";
         idb.AddParameter("@TCRTI_ID", tCRTI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCRTI_ID"] != DBNull.Value) tC_RTItem.TCRTI_ID = Convert.ToDecimal(dr["TCRTI_ID"]);
            if (dr["TCRTI_Code"] != DBNull.Value) tC_RTItem.TCRTI_Code = Convert.ToString(dr["TCRTI_Code"]);
            if (dr["TCRTI_TCode"] != DBNull.Value) tC_RTItem.TCRTI_TCode = Convert.ToString(dr["TCRTI_TCode"]);
            if (dr["TCRTI_PCode"] != DBNull.Value) tC_RTItem.TCRTI_PCode = Convert.ToString(dr["TCRTI_PCode"]);
            if (dr["TCRTI_Name"] != DBNull.Value) tC_RTItem.TCRTI_Name = Convert.ToString(dr["TCRTI_Name"]);
            if (dr["TCRTI_Max"] != DBNull.Value) tC_RTItem.TCRTI_Max = Convert.ToDecimal(dr["TCRTI_Max"]);
            if (dr["TCRTI_Min"] != DBNull.Value) tC_RTItem.TCRTI_Min = Convert.ToDecimal(dr["TCRTI_Min"]);
            if (dr["TCRTI_Standard"] != DBNull.Value) tC_RTItem.TCRTI_Standard = Convert.ToString(dr["TCRTI_Standard"]);
            if (dr["TCRTI_RefVal"] != DBNull.Value) tC_RTItem.TCRTI_RefVal = Convert.ToDecimal(dr["TCRTI_RefVal"]);
            if (dr["TCRTI_TypeName"] != DBNull.Value) tC_RTItem.TCRTI_TypeName = Convert.ToString(dr["TCRTI_TypeName"]);
            if (dr["TCRTI_Type"] != DBNull.Value) tC_RTItem.TCRTI_Type = Convert.ToString(dr["TCRTI_Type"]);
            if (dr["TCRTI_DictKey"] != DBNull.Value) tC_RTItem.TCRTI_DictKey = Convert.ToString(dr["TCRTI_DictKey"]);
            if (dr["TCRTI_Stat"] != DBNull.Value) tC_RTItem.TCRTI_Stat = Convert.ToString(dr["TCRTI_Stat"]);
            if (dr["TCRTI_Order"] != DBNull.Value) tC_RTItem.TCRTI_Order = Convert.ToInt32(dr["TCRTI_Order"]);
            if (dr["TCRTI_Remark"] != DBNull.Value) tC_RTItem.TCRTI_Remark = Convert.ToString(dr["TCRTI_Remark"]);
            if (dr["Stat"] != DBNull.Value) tC_RTItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RTItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RTItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RTItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_RTItem;
      }
      /// <summary>
      /// 获取指定的TC_RTItem对象集合
      /// </summary>
      public List<TC_RTItem> GetListByWhere(string strCondition)
      {
         List<TC_RTItem> ret = new List<TC_RTItem>();
         string sql = "SELECT  TCRTI_ID,TCRTI_Code,TCRTI_TCode,TCRTI_PCode,TCRTI_Name,TCRTI_Max,TCRTI_Min,TCRTI_Standard,TCRTI_RefVal,TCRTI_TypeName,TCRTI_Type,TCRTI_DictKey,TCRTI_Stat,TCRTI_Order,TCRTI_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RTItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_RTItem tC_RTItem = new TC_RTItem();
            if (dr["TCRTI_ID"] != DBNull.Value) tC_RTItem.TCRTI_ID = Convert.ToDecimal(dr["TCRTI_ID"]);
            if (dr["TCRTI_Code"] != DBNull.Value) tC_RTItem.TCRTI_Code = Convert.ToString(dr["TCRTI_Code"]);
            if (dr["TCRTI_TCode"] != DBNull.Value) tC_RTItem.TCRTI_TCode = Convert.ToString(dr["TCRTI_TCode"]);
            if (dr["TCRTI_PCode"] != DBNull.Value) tC_RTItem.TCRTI_PCode = Convert.ToString(dr["TCRTI_PCode"]);
            if (dr["TCRTI_Name"] != DBNull.Value) tC_RTItem.TCRTI_Name = Convert.ToString(dr["TCRTI_Name"]);
            if (dr["TCRTI_Max"] != DBNull.Value) tC_RTItem.TCRTI_Max = Convert.ToDecimal(dr["TCRTI_Max"]);
            if (dr["TCRTI_Min"] != DBNull.Value) tC_RTItem.TCRTI_Min = Convert.ToDecimal(dr["TCRTI_Min"]);
            if (dr["TCRTI_Standard"] != DBNull.Value) tC_RTItem.TCRTI_Standard = Convert.ToString(dr["TCRTI_Standard"]);
            if (dr["TCRTI_RefVal"] != DBNull.Value) tC_RTItem.TCRTI_RefVal = Convert.ToDecimal(dr["TCRTI_RefVal"]);
            if (dr["TCRTI_TypeName"] != DBNull.Value) tC_RTItem.TCRTI_TypeName = Convert.ToString(dr["TCRTI_TypeName"]);
            if (dr["TCRTI_Type"] != DBNull.Value) tC_RTItem.TCRTI_Type = Convert.ToString(dr["TCRTI_Type"]);
            if (dr["TCRTI_DictKey"] != DBNull.Value) tC_RTItem.TCRTI_DictKey = Convert.ToString(dr["TCRTI_DictKey"]);
            if (dr["TCRTI_Stat"] != DBNull.Value) tC_RTItem.TCRTI_Stat = Convert.ToString(dr["TCRTI_Stat"]);
            if (dr["TCRTI_Order"] != DBNull.Value) tC_RTItem.TCRTI_Order = Convert.ToInt32(dr["TCRTI_Order"]);
            if (dr["TCRTI_Remark"] != DBNull.Value) tC_RTItem.TCRTI_Remark = Convert.ToString(dr["TCRTI_Remark"]);
            if (dr["Stat"] != DBNull.Value) tC_RTItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RTItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RTItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RTItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RTItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的TC_RTItem对象(即:一条记录
      /// </summary>
      public List<TC_RTItem> GetAll()
      {
         List<TC_RTItem> ret = new List<TC_RTItem>();
         string sql = "SELECT  TCRTI_ID,TCRTI_Code,TCRTI_TCode,TCRTI_PCode,TCRTI_Name,TCRTI_Max,TCRTI_Min,TCRTI_Standard,TCRTI_RefVal,TCRTI_TypeName,TCRTI_Type,TCRTI_DictKey,TCRTI_Stat,TCRTI_Order,TCRTI_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_RTItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCRTI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_RTItem tC_RTItem = new TC_RTItem();
            if (dr["TCRTI_ID"] != DBNull.Value) tC_RTItem.TCRTI_ID = Convert.ToDecimal(dr["TCRTI_ID"]);
            if (dr["TCRTI_Code"] != DBNull.Value) tC_RTItem.TCRTI_Code = Convert.ToString(dr["TCRTI_Code"]);
            if (dr["TCRTI_TCode"] != DBNull.Value) tC_RTItem.TCRTI_TCode = Convert.ToString(dr["TCRTI_TCode"]);
            if (dr["TCRTI_PCode"] != DBNull.Value) tC_RTItem.TCRTI_PCode = Convert.ToString(dr["TCRTI_PCode"]);
            if (dr["TCRTI_Name"] != DBNull.Value) tC_RTItem.TCRTI_Name = Convert.ToString(dr["TCRTI_Name"]);
            if (dr["TCRTI_Max"] != DBNull.Value) tC_RTItem.TCRTI_Max = Convert.ToDecimal(dr["TCRTI_Max"]);
            if (dr["TCRTI_Min"] != DBNull.Value) tC_RTItem.TCRTI_Min = Convert.ToDecimal(dr["TCRTI_Min"]);
            if (dr["TCRTI_Standard"] != DBNull.Value) tC_RTItem.TCRTI_Standard = Convert.ToString(dr["TCRTI_Standard"]);
            if (dr["TCRTI_RefVal"] != DBNull.Value) tC_RTItem.TCRTI_RefVal = Convert.ToDecimal(dr["TCRTI_RefVal"]);
            if (dr["TCRTI_TypeName"] != DBNull.Value) tC_RTItem.TCRTI_TypeName = Convert.ToString(dr["TCRTI_TypeName"]);
            if (dr["TCRTI_Type"] != DBNull.Value) tC_RTItem.TCRTI_Type = Convert.ToString(dr["TCRTI_Type"]);
            if (dr["TCRTI_DictKey"] != DBNull.Value) tC_RTItem.TCRTI_DictKey = Convert.ToString(dr["TCRTI_DictKey"]);
            if (dr["TCRTI_Stat"] != DBNull.Value) tC_RTItem.TCRTI_Stat = Convert.ToString(dr["TCRTI_Stat"]);
            if (dr["TCRTI_Order"] != DBNull.Value) tC_RTItem.TCRTI_Order = Convert.ToInt32(dr["TCRTI_Order"]);
            if (dr["TCRTI_Remark"] != DBNull.Value) tC_RTItem.TCRTI_Remark = Convert.ToString(dr["TCRTI_Remark"]);
            if (dr["Stat"] != DBNull.Value) tC_RTItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_RTItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_RTItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_RTItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_RTItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
