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
   /// 盘点物料列表
   /// </summary>
   [Serializable]
   public partial class ADOWH_BanItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加盘点物料列表 WH_BanItem对象(即:一条记录)
      /// </summary>
      public int Add(WH_BanItem wH_BanItem)
      {
         string sql = "INSERT INTO WH_BanItem (WHBI_Code,WHBI_BCode,WHBI_WCode,WHBI_WName,WHBI_WNo,WHBI_WNoName,WHBI_MCode,WHBI_MName,WHBI_MSpec,WHBI_MUnit,WHBI_RNum,WHBI_BNum,WHBI_MNum,WHBI_LNum,WHBI_Type,WHBI_RType,WHBI_Date,WHBI_Owner,WHBI_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WHBI_Code,@WHBI_BCode,@WHBI_WCode,@WHBI_WName,@WHBI_WNo,@WHBI_WNoName,@WHBI_MCode,@WHBI_MName,@WHBI_MSpec,@WHBI_MUnit,@WHBI_RNum,@WHBI_BNum,@WHBI_MNum,@WHBI_LNum,@WHBI_Type,@WHBI_RType,@WHBI_Date,@WHBI_Owner,@WHBI_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Code))
         {
            idb.AddParameter("@WHBI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Code", wH_BanItem.WHBI_Code);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_BCode))
         {
            idb.AddParameter("@WHBI_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_BCode", wH_BanItem.WHBI_BCode);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WCode))
         {
            idb.AddParameter("@WHBI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WCode", wH_BanItem.WHBI_WCode);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WName))
         {
            idb.AddParameter("@WHBI_WName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WName", wH_BanItem.WHBI_WName);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WNo))
         {
            idb.AddParameter("@WHBI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WNo", wH_BanItem.WHBI_WNo);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WNoName))
         {
            idb.AddParameter("@WHBI_WNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WNoName", wH_BanItem.WHBI_WNoName);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MCode))
         {
            idb.AddParameter("@WHBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MCode", wH_BanItem.WHBI_MCode);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MName))
         {
            idb.AddParameter("@WHBI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MName", wH_BanItem.WHBI_MName);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MSpec))
         {
            idb.AddParameter("@WHBI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MSpec", wH_BanItem.WHBI_MSpec);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MUnit))
         {
            idb.AddParameter("@WHBI_MUnit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MUnit", wH_BanItem.WHBI_MUnit);
         }
         if (wH_BanItem.WHBI_RNum == 0)
         {
            idb.AddParameter("@WHBI_RNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_RNum", wH_BanItem.WHBI_RNum);
         }
         if (wH_BanItem.WHBI_BNum == 0)
         {
            idb.AddParameter("@WHBI_BNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_BNum", wH_BanItem.WHBI_BNum);
         }
         if (wH_BanItem.WHBI_MNum == 0)
         {
            idb.AddParameter("@WHBI_MNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_MNum", wH_BanItem.WHBI_MNum);
         }
         if (wH_BanItem.WHBI_LNum == 0)
         {
            idb.AddParameter("@WHBI_LNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_LNum", wH_BanItem.WHBI_LNum);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Type))
         {
            idb.AddParameter("@WHBI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Type", wH_BanItem.WHBI_Type);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_RType))
         {
            idb.AddParameter("@WHBI_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_RType", wH_BanItem.WHBI_RType);
         }
         if (wH_BanItem.WHBI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHBI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Date", wH_BanItem.WHBI_Date);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Owner))
         {
            idb.AddParameter("@WHBI_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Owner", wH_BanItem.WHBI_Owner);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Bak))
         {
            idb.AddParameter("@WHBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Bak", wH_BanItem.WHBI_Bak);
         }
         if (wH_BanItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanItem.Stat);
         }
         if (wH_BanItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanItem.CreateDate);
         }
         if (wH_BanItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanItem.UpdateDate);
         }
         if (wH_BanItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanItem.DeleteDate);
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
      /// 添加盘点物料列表 WH_BanItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_BanItem wH_BanItem)
      {
         string sql = "INSERT INTO WH_BanItem (WHBI_Code,WHBI_BCode,WHBI_WCode,WHBI_WName,WHBI_WNo,WHBI_WNoName,WHBI_MCode,WHBI_MName,WHBI_MSpec,WHBI_MUnit,WHBI_RNum,WHBI_BNum,WHBI_MNum,WHBI_LNum,WHBI_Type,WHBI_RType,WHBI_Date,WHBI_Owner,WHBI_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@WHBI_Code,@WHBI_BCode,@WHBI_WCode,@WHBI_WName,@WHBI_WNo,@WHBI_WNoName,@WHBI_MCode,@WHBI_MName,@WHBI_MSpec,@WHBI_MUnit,@WHBI_RNum,@WHBI_BNum,@WHBI_MNum,@WHBI_LNum,@WHBI_Type,@WHBI_RType,@WHBI_Date,@WHBI_Owner,@WHBI_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Code))
         {
            idb.AddParameter("@WHBI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Code", wH_BanItem.WHBI_Code);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_BCode))
         {
            idb.AddParameter("@WHBI_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_BCode", wH_BanItem.WHBI_BCode);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WCode))
         {
            idb.AddParameter("@WHBI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WCode", wH_BanItem.WHBI_WCode);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WName))
         {
            idb.AddParameter("@WHBI_WName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WName", wH_BanItem.WHBI_WName);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WNo))
         {
            idb.AddParameter("@WHBI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WNo", wH_BanItem.WHBI_WNo);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WNoName))
         {
            idb.AddParameter("@WHBI_WNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WNoName", wH_BanItem.WHBI_WNoName);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MCode))
         {
            idb.AddParameter("@WHBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MCode", wH_BanItem.WHBI_MCode);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MName))
         {
            idb.AddParameter("@WHBI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MName", wH_BanItem.WHBI_MName);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MSpec))
         {
            idb.AddParameter("@WHBI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MSpec", wH_BanItem.WHBI_MSpec);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MUnit))
         {
            idb.AddParameter("@WHBI_MUnit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MUnit", wH_BanItem.WHBI_MUnit);
         }
         if (wH_BanItem.WHBI_RNum == 0)
         {
            idb.AddParameter("@WHBI_RNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_RNum", wH_BanItem.WHBI_RNum);
         }
         if (wH_BanItem.WHBI_BNum == 0)
         {
            idb.AddParameter("@WHBI_BNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_BNum", wH_BanItem.WHBI_BNum);
         }
         if (wH_BanItem.WHBI_MNum == 0)
         {
            idb.AddParameter("@WHBI_MNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_MNum", wH_BanItem.WHBI_MNum);
         }
         if (wH_BanItem.WHBI_LNum == 0)
         {
            idb.AddParameter("@WHBI_LNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_LNum", wH_BanItem.WHBI_LNum);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Type))
         {
            idb.AddParameter("@WHBI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Type", wH_BanItem.WHBI_Type);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_RType))
         {
            idb.AddParameter("@WHBI_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_RType", wH_BanItem.WHBI_RType);
         }
         if (wH_BanItem.WHBI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHBI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Date", wH_BanItem.WHBI_Date);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Owner))
         {
            idb.AddParameter("@WHBI_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Owner", wH_BanItem.WHBI_Owner);
         }
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Bak))
         {
            idb.AddParameter("@WHBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Bak", wH_BanItem.WHBI_Bak);
         }
         if (wH_BanItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanItem.Stat);
         }
         if (wH_BanItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanItem.CreateDate);
         }
         if (wH_BanItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanItem.UpdateDate);
         }
         if (wH_BanItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanItem.DeleteDate);
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
      /// 更新盘点物料列表 WH_BanItem对象(即:一条记录
      /// </summary>
      public int Update(WH_BanItem wH_BanItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_BanItem       SET ");
            if(wH_BanItem.WHBI_Code_IsChanged){sbParameter.Append("WHBI_Code=@WHBI_Code, ");}
      if(wH_BanItem.WHBI_BCode_IsChanged){sbParameter.Append("WHBI_BCode=@WHBI_BCode, ");}
      if(wH_BanItem.WHBI_WCode_IsChanged){sbParameter.Append("WHBI_WCode=@WHBI_WCode, ");}
      if(wH_BanItem.WHBI_WName_IsChanged){sbParameter.Append("WHBI_WName=@WHBI_WName, ");}
      if(wH_BanItem.WHBI_WNo_IsChanged){sbParameter.Append("WHBI_WNo=@WHBI_WNo, ");}
      if(wH_BanItem.WHBI_WNoName_IsChanged){sbParameter.Append("WHBI_WNoName=@WHBI_WNoName, ");}
      if(wH_BanItem.WHBI_MCode_IsChanged){sbParameter.Append("WHBI_MCode=@WHBI_MCode, ");}
      if(wH_BanItem.WHBI_MName_IsChanged){sbParameter.Append("WHBI_MName=@WHBI_MName, ");}
      if(wH_BanItem.WHBI_MSpec_IsChanged){sbParameter.Append("WHBI_MSpec=@WHBI_MSpec, ");}
      if(wH_BanItem.WHBI_MUnit_IsChanged){sbParameter.Append("WHBI_MUnit=@WHBI_MUnit, ");}
      if(wH_BanItem.WHBI_RNum_IsChanged){sbParameter.Append("WHBI_RNum=@WHBI_RNum, ");}
      if(wH_BanItem.WHBI_BNum_IsChanged){sbParameter.Append("WHBI_BNum=@WHBI_BNum, ");}
      if(wH_BanItem.WHBI_MNum_IsChanged){sbParameter.Append("WHBI_MNum=@WHBI_MNum, ");}
      if(wH_BanItem.WHBI_LNum_IsChanged){sbParameter.Append("WHBI_LNum=@WHBI_LNum, ");}
      if(wH_BanItem.WHBI_Type_IsChanged){sbParameter.Append("WHBI_Type=@WHBI_Type, ");}
      if(wH_BanItem.WHBI_RType_IsChanged){sbParameter.Append("WHBI_RType=@WHBI_RType, ");}
      if(wH_BanItem.WHBI_Date_IsChanged){sbParameter.Append("WHBI_Date=@WHBI_Date, ");}
      if(wH_BanItem.WHBI_Owner_IsChanged){sbParameter.Append("WHBI_Owner=@WHBI_Owner, ");}
      if(wH_BanItem.WHBI_Bak_IsChanged){sbParameter.Append("WHBI_Bak=@WHBI_Bak, ");}
      if(wH_BanItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_BanItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_BanItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_BanItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHBI_ID=@WHBI_ID; " );
      string sql=sb.ToString();
         if(wH_BanItem.WHBI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Code))
         {
            idb.AddParameter("@WHBI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Code", wH_BanItem.WHBI_Code);
         }
          }
         if(wH_BanItem.WHBI_BCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_BCode))
         {
            idb.AddParameter("@WHBI_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_BCode", wH_BanItem.WHBI_BCode);
         }
          }
         if(wH_BanItem.WHBI_WCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WCode))
         {
            idb.AddParameter("@WHBI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WCode", wH_BanItem.WHBI_WCode);
         }
          }
         if(wH_BanItem.WHBI_WName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WName))
         {
            idb.AddParameter("@WHBI_WName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WName", wH_BanItem.WHBI_WName);
         }
          }
         if(wH_BanItem.WHBI_WNo_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WNo))
         {
            idb.AddParameter("@WHBI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WNo", wH_BanItem.WHBI_WNo);
         }
          }
         if(wH_BanItem.WHBI_WNoName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_WNoName))
         {
            idb.AddParameter("@WHBI_WNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_WNoName", wH_BanItem.WHBI_WNoName);
         }
          }
         if(wH_BanItem.WHBI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MCode))
         {
            idb.AddParameter("@WHBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MCode", wH_BanItem.WHBI_MCode);
         }
          }
         if(wH_BanItem.WHBI_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MName))
         {
            idb.AddParameter("@WHBI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MName", wH_BanItem.WHBI_MName);
         }
          }
         if(wH_BanItem.WHBI_MSpec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MSpec))
         {
            idb.AddParameter("@WHBI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MSpec", wH_BanItem.WHBI_MSpec);
         }
          }
         if(wH_BanItem.WHBI_MUnit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_MUnit))
         {
            idb.AddParameter("@WHBI_MUnit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_MUnit", wH_BanItem.WHBI_MUnit);
         }
          }
         if(wH_BanItem.WHBI_RNum_IsChanged)
         {
         if (wH_BanItem.WHBI_RNum == 0)
         {
            idb.AddParameter("@WHBI_RNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_RNum", wH_BanItem.WHBI_RNum);
         }
          }
         if(wH_BanItem.WHBI_BNum_IsChanged)
         {
         if (wH_BanItem.WHBI_BNum == 0)
         {
            idb.AddParameter("@WHBI_BNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_BNum", wH_BanItem.WHBI_BNum);
         }
          }
         if(wH_BanItem.WHBI_MNum_IsChanged)
         {
         if (wH_BanItem.WHBI_MNum == 0)
         {
            idb.AddParameter("@WHBI_MNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_MNum", wH_BanItem.WHBI_MNum);
         }
          }
         if(wH_BanItem.WHBI_LNum_IsChanged)
         {
         if (wH_BanItem.WHBI_LNum == 0)
         {
            idb.AddParameter("@WHBI_LNum", 0);
         }
         else
         {
            idb.AddParameter("@WHBI_LNum", wH_BanItem.WHBI_LNum);
         }
          }
         if(wH_BanItem.WHBI_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Type))
         {
            idb.AddParameter("@WHBI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Type", wH_BanItem.WHBI_Type);
         }
          }
         if(wH_BanItem.WHBI_RType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_RType))
         {
            idb.AddParameter("@WHBI_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_RType", wH_BanItem.WHBI_RType);
         }
          }
         if(wH_BanItem.WHBI_Date_IsChanged)
         {
         if (wH_BanItem.WHBI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHBI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Date", wH_BanItem.WHBI_Date);
         }
          }
         if(wH_BanItem.WHBI_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Owner))
         {
            idb.AddParameter("@WHBI_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Owner", wH_BanItem.WHBI_Owner);
         }
          }
         if(wH_BanItem.WHBI_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_BanItem.WHBI_Bak))
         {
            idb.AddParameter("@WHBI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHBI_Bak", wH_BanItem.WHBI_Bak);
         }
          }
         if(wH_BanItem.Stat_IsChanged)
         {
         if (wH_BanItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_BanItem.Stat);
         }
          }
         if(wH_BanItem.CreateDate_IsChanged)
         {
         if (wH_BanItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_BanItem.CreateDate);
         }
          }
         if(wH_BanItem.UpdateDate_IsChanged)
         {
         if (wH_BanItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_BanItem.UpdateDate);
         }
          }
         if(wH_BanItem.DeleteDate_IsChanged)
         {
         if (wH_BanItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_BanItem.DeleteDate);
         }
          }

         idb.AddParameter("@WHBI_ID", wH_BanItem.WHBI_ID);

           
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
      /// 删除盘点物料列表 WH_BanItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHBI_ID)
      {
         string sql = "DELETE WH_BanItem WHERE 1=1  AND WHBI_ID=@WHBI_ID ";
         idb.AddParameter("@WHBI_ID", wHBI_ID);

           
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
      /// 获取指定的盘点物料列表 WH_BanItem对象(即:一条记录
      /// </summary>
      public WH_BanItem GetByKey(decimal wHBI_ID)
      {
         WH_BanItem wH_BanItem = new WH_BanItem();
         string sql = "SELECT  WHBI_ID,WHBI_Code,WHBI_BCode,WHBI_WCode,WHBI_WName,WHBI_WNo,WHBI_WNoName,WHBI_MCode,WHBI_MName,WHBI_MSpec,WHBI_MUnit,WHBI_RNum,WHBI_BNum,WHBI_MNum,WHBI_LNum,WHBI_Type,WHBI_RType,WHBI_Date,WHBI_Owner,WHBI_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_BanItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHBI_ID=@WHBI_ID ";
         idb.AddParameter("@WHBI_ID", wHBI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHBI_ID"] != DBNull.Value) wH_BanItem.WHBI_ID = Convert.ToDecimal(dr["WHBI_ID"]);
            if (dr["WHBI_Code"] != DBNull.Value) wH_BanItem.WHBI_Code = Convert.ToString(dr["WHBI_Code"]);
            if (dr["WHBI_BCode"] != DBNull.Value) wH_BanItem.WHBI_BCode = Convert.ToString(dr["WHBI_BCode"]);
            if (dr["WHBI_WCode"] != DBNull.Value) wH_BanItem.WHBI_WCode = Convert.ToString(dr["WHBI_WCode"]);
            if (dr["WHBI_WName"] != DBNull.Value) wH_BanItem.WHBI_WName = Convert.ToString(dr["WHBI_WName"]);
            if (dr["WHBI_WNo"] != DBNull.Value) wH_BanItem.WHBI_WNo = Convert.ToString(dr["WHBI_WNo"]);
            if (dr["WHBI_WNoName"] != DBNull.Value) wH_BanItem.WHBI_WNoName = Convert.ToString(dr["WHBI_WNoName"]);
            if (dr["WHBI_MCode"] != DBNull.Value) wH_BanItem.WHBI_MCode = Convert.ToString(dr["WHBI_MCode"]);
            if (dr["WHBI_MName"] != DBNull.Value) wH_BanItem.WHBI_MName = Convert.ToString(dr["WHBI_MName"]);
            if (dr["WHBI_MSpec"] != DBNull.Value) wH_BanItem.WHBI_MSpec = Convert.ToString(dr["WHBI_MSpec"]);
            if (dr["WHBI_MUnit"] != DBNull.Value) wH_BanItem.WHBI_MUnit = Convert.ToString(dr["WHBI_MUnit"]);
            if (dr["WHBI_RNum"] != DBNull.Value) wH_BanItem.WHBI_RNum = Convert.ToDecimal(dr["WHBI_RNum"]);
            if (dr["WHBI_BNum"] != DBNull.Value) wH_BanItem.WHBI_BNum = Convert.ToDecimal(dr["WHBI_BNum"]);
            if (dr["WHBI_MNum"] != DBNull.Value) wH_BanItem.WHBI_MNum = Convert.ToDecimal(dr["WHBI_MNum"]);
            if (dr["WHBI_LNum"] != DBNull.Value) wH_BanItem.WHBI_LNum = Convert.ToDecimal(dr["WHBI_LNum"]);
            if (dr["WHBI_Type"] != DBNull.Value) wH_BanItem.WHBI_Type = Convert.ToString(dr["WHBI_Type"]);
            if (dr["WHBI_RType"] != DBNull.Value) wH_BanItem.WHBI_RType = Convert.ToString(dr["WHBI_RType"]);
            if (dr["WHBI_Date"] != DBNull.Value) wH_BanItem.WHBI_Date = Convert.ToDateTime(dr["WHBI_Date"]);
            if (dr["WHBI_Owner"] != DBNull.Value) wH_BanItem.WHBI_Owner = Convert.ToString(dr["WHBI_Owner"]);
            if (dr["WHBI_Bak"] != DBNull.Value) wH_BanItem.WHBI_Bak = Convert.ToString(dr["WHBI_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_BanItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_BanItem;
      }
      /// <summary>
      /// 获取指定的盘点物料列表 WH_BanItem对象集合
      /// </summary>
      public List<WH_BanItem> GetListByWhere(string strCondition)
      {
         List<WH_BanItem> ret = new List<WH_BanItem>();
         string sql = "SELECT  WHBI_ID,WHBI_Code,WHBI_BCode,WHBI_WCode,WHBI_WName,WHBI_WNo,WHBI_WNoName,WHBI_MCode,WHBI_MName,WHBI_MSpec,WHBI_MUnit,WHBI_RNum,WHBI_BNum,WHBI_MNum,WHBI_LNum,WHBI_Type,WHBI_RType,WHBI_Date,WHBI_Owner,WHBI_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_BanItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_BanItem wH_BanItem = new WH_BanItem();
            if (dr["WHBI_ID"] != DBNull.Value) wH_BanItem.WHBI_ID = Convert.ToDecimal(dr["WHBI_ID"]);
            if (dr["WHBI_Code"] != DBNull.Value) wH_BanItem.WHBI_Code = Convert.ToString(dr["WHBI_Code"]);
            if (dr["WHBI_BCode"] != DBNull.Value) wH_BanItem.WHBI_BCode = Convert.ToString(dr["WHBI_BCode"]);
            if (dr["WHBI_WCode"] != DBNull.Value) wH_BanItem.WHBI_WCode = Convert.ToString(dr["WHBI_WCode"]);
            if (dr["WHBI_WName"] != DBNull.Value) wH_BanItem.WHBI_WName = Convert.ToString(dr["WHBI_WName"]);
            if (dr["WHBI_WNo"] != DBNull.Value) wH_BanItem.WHBI_WNo = Convert.ToString(dr["WHBI_WNo"]);
            if (dr["WHBI_WNoName"] != DBNull.Value) wH_BanItem.WHBI_WNoName = Convert.ToString(dr["WHBI_WNoName"]);
            if (dr["WHBI_MCode"] != DBNull.Value) wH_BanItem.WHBI_MCode = Convert.ToString(dr["WHBI_MCode"]);
            if (dr["WHBI_MName"] != DBNull.Value) wH_BanItem.WHBI_MName = Convert.ToString(dr["WHBI_MName"]);
            if (dr["WHBI_MSpec"] != DBNull.Value) wH_BanItem.WHBI_MSpec = Convert.ToString(dr["WHBI_MSpec"]);
            if (dr["WHBI_MUnit"] != DBNull.Value) wH_BanItem.WHBI_MUnit = Convert.ToString(dr["WHBI_MUnit"]);
            if (dr["WHBI_RNum"] != DBNull.Value) wH_BanItem.WHBI_RNum = Convert.ToDecimal(dr["WHBI_RNum"]);
            if (dr["WHBI_BNum"] != DBNull.Value) wH_BanItem.WHBI_BNum = Convert.ToDecimal(dr["WHBI_BNum"]);
            if (dr["WHBI_MNum"] != DBNull.Value) wH_BanItem.WHBI_MNum = Convert.ToDecimal(dr["WHBI_MNum"]);
            if (dr["WHBI_LNum"] != DBNull.Value) wH_BanItem.WHBI_LNum = Convert.ToDecimal(dr["WHBI_LNum"]);
            if (dr["WHBI_Type"] != DBNull.Value) wH_BanItem.WHBI_Type = Convert.ToString(dr["WHBI_Type"]);
            if (dr["WHBI_RType"] != DBNull.Value) wH_BanItem.WHBI_RType = Convert.ToString(dr["WHBI_RType"]);
            if (dr["WHBI_Date"] != DBNull.Value) wH_BanItem.WHBI_Date = Convert.ToDateTime(dr["WHBI_Date"]);
            if (dr["WHBI_Owner"] != DBNull.Value) wH_BanItem.WHBI_Owner = Convert.ToString(dr["WHBI_Owner"]);
            if (dr["WHBI_Bak"] != DBNull.Value) wH_BanItem.WHBI_Bak = Convert.ToString(dr["WHBI_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_BanItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_BanItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的盘点物料列表 WH_BanItem对象(即:一条记录
      /// </summary>
      public List<WH_BanItem> GetAll()
      {
         List<WH_BanItem> ret = new List<WH_BanItem>();
         string sql = "SELECT  WHBI_ID,WHBI_Code,WHBI_BCode,WHBI_WCode,WHBI_WName,WHBI_WNo,WHBI_WNoName,WHBI_MCode,WHBI_MName,WHBI_MSpec,WHBI_MUnit,WHBI_RNum,WHBI_BNum,WHBI_MNum,WHBI_LNum,WHBI_Type,WHBI_RType,WHBI_Date,WHBI_Owner,WHBI_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_BanItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHBI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_BanItem wH_BanItem = new WH_BanItem();
            if (dr["WHBI_ID"] != DBNull.Value) wH_BanItem.WHBI_ID = Convert.ToDecimal(dr["WHBI_ID"]);
            if (dr["WHBI_Code"] != DBNull.Value) wH_BanItem.WHBI_Code = Convert.ToString(dr["WHBI_Code"]);
            if (dr["WHBI_BCode"] != DBNull.Value) wH_BanItem.WHBI_BCode = Convert.ToString(dr["WHBI_BCode"]);
            if (dr["WHBI_WCode"] != DBNull.Value) wH_BanItem.WHBI_WCode = Convert.ToString(dr["WHBI_WCode"]);
            if (dr["WHBI_WName"] != DBNull.Value) wH_BanItem.WHBI_WName = Convert.ToString(dr["WHBI_WName"]);
            if (dr["WHBI_WNo"] != DBNull.Value) wH_BanItem.WHBI_WNo = Convert.ToString(dr["WHBI_WNo"]);
            if (dr["WHBI_WNoName"] != DBNull.Value) wH_BanItem.WHBI_WNoName = Convert.ToString(dr["WHBI_WNoName"]);
            if (dr["WHBI_MCode"] != DBNull.Value) wH_BanItem.WHBI_MCode = Convert.ToString(dr["WHBI_MCode"]);
            if (dr["WHBI_MName"] != DBNull.Value) wH_BanItem.WHBI_MName = Convert.ToString(dr["WHBI_MName"]);
            if (dr["WHBI_MSpec"] != DBNull.Value) wH_BanItem.WHBI_MSpec = Convert.ToString(dr["WHBI_MSpec"]);
            if (dr["WHBI_MUnit"] != DBNull.Value) wH_BanItem.WHBI_MUnit = Convert.ToString(dr["WHBI_MUnit"]);
            if (dr["WHBI_RNum"] != DBNull.Value) wH_BanItem.WHBI_RNum = Convert.ToDecimal(dr["WHBI_RNum"]);
            if (dr["WHBI_BNum"] != DBNull.Value) wH_BanItem.WHBI_BNum = Convert.ToDecimal(dr["WHBI_BNum"]);
            if (dr["WHBI_MNum"] != DBNull.Value) wH_BanItem.WHBI_MNum = Convert.ToDecimal(dr["WHBI_MNum"]);
            if (dr["WHBI_LNum"] != DBNull.Value) wH_BanItem.WHBI_LNum = Convert.ToDecimal(dr["WHBI_LNum"]);
            if (dr["WHBI_Type"] != DBNull.Value) wH_BanItem.WHBI_Type = Convert.ToString(dr["WHBI_Type"]);
            if (dr["WHBI_RType"] != DBNull.Value) wH_BanItem.WHBI_RType = Convert.ToString(dr["WHBI_RType"]);
            if (dr["WHBI_Date"] != DBNull.Value) wH_BanItem.WHBI_Date = Convert.ToDateTime(dr["WHBI_Date"]);
            if (dr["WHBI_Owner"] != DBNull.Value) wH_BanItem.WHBI_Owner = Convert.ToString(dr["WHBI_Owner"]);
            if (dr["WHBI_Bak"] != DBNull.Value) wH_BanItem.WHBI_Bak = Convert.ToString(dr["WHBI_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_BanItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_BanItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_BanItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_BanItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(wH_BanItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
