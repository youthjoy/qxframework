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
   /// 试组信息
   /// </summary>
   [Serializable]
   public partial class ADOTC_Group
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加试组信息 TC_Group对象(即:一条记录)
      /// </summary>
      public int Add(TC_Group tC_Group)
      {
         string sql = "INSERT INTO TC_Group (TCG_Code,TCG_CCode,TCG_PRCode,TCG_PPCode,TCG_PDCode,TCG_Owner,TCG_Date,TCG_GType,TCG_iType,TCG_iNum,TCG_KWater,TCG_BType,TCG_YType,TCG_TCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCG_Code,@TCG_CCode,@TCG_PRCode,@TCG_PPCode,@TCG_PDCode,@TCG_Owner,@TCG_Date,@TCG_GType,@TCG_iType,@TCG_iNum,@TCG_KWater,@TCG_BType,@TCG_YType,@TCG_TCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(tC_Group.TCG_Code))
         {
            idb.AddParameter("@TCG_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Code", tC_Group.TCG_Code);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_CCode))
         {
            idb.AddParameter("@TCG_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_CCode", tC_Group.TCG_CCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_PRCode))
         {
            idb.AddParameter("@TCG_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PRCode", tC_Group.TCG_PRCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_PPCode))
         {
            idb.AddParameter("@TCG_PPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PPCode", tC_Group.TCG_PPCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_PDCode))
         {
            idb.AddParameter("@TCG_PDCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PDCode", tC_Group.TCG_PDCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_Owner))
         {
            idb.AddParameter("@TCG_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Owner", tC_Group.TCG_Owner);
         }
         if (tC_Group.TCG_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TCG_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Date", tC_Group.TCG_Date);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_GType))
         {
            idb.AddParameter("@TCG_GType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_GType", tC_Group.TCG_GType);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_iType))
         {
            idb.AddParameter("@TCG_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_iType", tC_Group.TCG_iType);
         }
         if (tC_Group.TCG_iNum == 0)
         {
            idb.AddParameter("@TCG_iNum", 0);
         }
         else
         {
            idb.AddParameter("@TCG_iNum", tC_Group.TCG_iNum);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_KWater))
         {
            idb.AddParameter("@TCG_KWater", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_KWater", tC_Group.TCG_KWater);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_BType))
         {
            idb.AddParameter("@TCG_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_BType", tC_Group.TCG_BType);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_YType))
         {
            idb.AddParameter("@TCG_YType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_YType", tC_Group.TCG_YType);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_TCode))
         {
            idb.AddParameter("@TCG_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_TCode", tC_Group.TCG_TCode);
         }
         if (tC_Group.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Group.Stat);
         }
         if (tC_Group.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Group.CreateDate);
         }
         if (tC_Group.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Group.UpdateDate);
         }
         if (tC_Group.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Group.DeleteDate);
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
      /// 添加试组信息 TC_Group对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_Group tC_Group)
      {
         string sql = "INSERT INTO TC_Group (TCG_Code,TCG_CCode,TCG_PRCode,TCG_PPCode,TCG_PDCode,TCG_Owner,TCG_Date,TCG_GType,TCG_iType,TCG_iNum,TCG_KWater,TCG_BType,TCG_YType,TCG_TCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TCG_Code,@TCG_CCode,@TCG_PRCode,@TCG_PPCode,@TCG_PDCode,@TCG_Owner,@TCG_Date,@TCG_GType,@TCG_iType,@TCG_iNum,@TCG_KWater,@TCG_BType,@TCG_YType,@TCG_TCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_Group.TCG_Code))
         {
            idb.AddParameter("@TCG_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Code", tC_Group.TCG_Code);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_CCode))
         {
            idb.AddParameter("@TCG_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_CCode", tC_Group.TCG_CCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_PRCode))
         {
            idb.AddParameter("@TCG_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PRCode", tC_Group.TCG_PRCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_PPCode))
         {
            idb.AddParameter("@TCG_PPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PPCode", tC_Group.TCG_PPCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_PDCode))
         {
            idb.AddParameter("@TCG_PDCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PDCode", tC_Group.TCG_PDCode);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_Owner))
         {
            idb.AddParameter("@TCG_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Owner", tC_Group.TCG_Owner);
         }
         if (tC_Group.TCG_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TCG_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Date", tC_Group.TCG_Date);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_GType))
         {
            idb.AddParameter("@TCG_GType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_GType", tC_Group.TCG_GType);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_iType))
         {
            idb.AddParameter("@TCG_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_iType", tC_Group.TCG_iType);
         }
         if (tC_Group.TCG_iNum == 0)
         {
            idb.AddParameter("@TCG_iNum", 0);
         }
         else
         {
            idb.AddParameter("@TCG_iNum", tC_Group.TCG_iNum);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_KWater))
         {
            idb.AddParameter("@TCG_KWater", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_KWater", tC_Group.TCG_KWater);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_BType))
         {
            idb.AddParameter("@TCG_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_BType", tC_Group.TCG_BType);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_YType))
         {
            idb.AddParameter("@TCG_YType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_YType", tC_Group.TCG_YType);
         }
         if (string.IsNullOrEmpty(tC_Group.TCG_TCode))
         {
            idb.AddParameter("@TCG_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_TCode", tC_Group.TCG_TCode);
         }
         if (tC_Group.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Group.Stat);
         }
         if (tC_Group.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Group.CreateDate);
         }
         if (tC_Group.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Group.UpdateDate);
         }
         if (tC_Group.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Group.DeleteDate);
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
      /// 更新试组信息 TC_Group对象(即:一条记录
      /// </summary>
      public int Update(TC_Group tC_Group)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_Group       SET ");
            if(tC_Group.TCG_Code_IsChanged){sbParameter.Append("TCG_Code=@TCG_Code, ");}
      if(tC_Group.TCG_CCode_IsChanged){sbParameter.Append("TCG_CCode=@TCG_CCode, ");}
      if(tC_Group.TCG_PRCode_IsChanged){sbParameter.Append("TCG_PRCode=@TCG_PRCode, ");}
      if(tC_Group.TCG_PPCode_IsChanged){sbParameter.Append("TCG_PPCode=@TCG_PPCode, ");}
      if(tC_Group.TCG_PDCode_IsChanged){sbParameter.Append("TCG_PDCode=@TCG_PDCode, ");}
      if(tC_Group.TCG_Owner_IsChanged){sbParameter.Append("TCG_Owner=@TCG_Owner, ");}
      if(tC_Group.TCG_Date_IsChanged){sbParameter.Append("TCG_Date=@TCG_Date, ");}
      if(tC_Group.TCG_GType_IsChanged){sbParameter.Append("TCG_GType=@TCG_GType, ");}
      if(tC_Group.TCG_iType_IsChanged){sbParameter.Append("TCG_iType=@TCG_iType, ");}
      if(tC_Group.TCG_iNum_IsChanged){sbParameter.Append("TCG_iNum=@TCG_iNum, ");}
      if(tC_Group.TCG_KWater_IsChanged){sbParameter.Append("TCG_KWater=@TCG_KWater, ");}
      if(tC_Group.TCG_BType_IsChanged){sbParameter.Append("TCG_BType=@TCG_BType, ");}
      if(tC_Group.TCG_YType_IsChanged){sbParameter.Append("TCG_YType=@TCG_YType, ");}
      if(tC_Group.TCG_TCode_IsChanged){sbParameter.Append("TCG_TCode=@TCG_TCode, ");}
      if(tC_Group.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_Group.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_Group.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_Group.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCG_ID=@TCG_ID; " );
      string sql=sb.ToString();
         if(tC_Group.TCG_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_Code))
         {
            idb.AddParameter("@TCG_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Code", tC_Group.TCG_Code);
         }
          }
         if(tC_Group.TCG_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_CCode))
         {
            idb.AddParameter("@TCG_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_CCode", tC_Group.TCG_CCode);
         }
          }
         if(tC_Group.TCG_PRCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_PRCode))
         {
            idb.AddParameter("@TCG_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PRCode", tC_Group.TCG_PRCode);
         }
          }
         if(tC_Group.TCG_PPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_PPCode))
         {
            idb.AddParameter("@TCG_PPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PPCode", tC_Group.TCG_PPCode);
         }
          }
         if(tC_Group.TCG_PDCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_PDCode))
         {
            idb.AddParameter("@TCG_PDCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_PDCode", tC_Group.TCG_PDCode);
         }
          }
         if(tC_Group.TCG_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_Owner))
         {
            idb.AddParameter("@TCG_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Owner", tC_Group.TCG_Owner);
         }
          }
         if(tC_Group.TCG_Date_IsChanged)
         {
         if (tC_Group.TCG_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TCG_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_Date", tC_Group.TCG_Date);
         }
          }
         if(tC_Group.TCG_GType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_GType))
         {
            idb.AddParameter("@TCG_GType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_GType", tC_Group.TCG_GType);
         }
          }
         if(tC_Group.TCG_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_iType))
         {
            idb.AddParameter("@TCG_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_iType", tC_Group.TCG_iType);
         }
          }
         if(tC_Group.TCG_iNum_IsChanged)
         {
         if (tC_Group.TCG_iNum == 0)
         {
            idb.AddParameter("@TCG_iNum", 0);
         }
         else
         {
            idb.AddParameter("@TCG_iNum", tC_Group.TCG_iNum);
         }
          }
         if(tC_Group.TCG_KWater_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_KWater))
         {
            idb.AddParameter("@TCG_KWater", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_KWater", tC_Group.TCG_KWater);
         }
          }
         if(tC_Group.TCG_BType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_BType))
         {
            idb.AddParameter("@TCG_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_BType", tC_Group.TCG_BType);
         }
          }
         if(tC_Group.TCG_YType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_YType))
         {
            idb.AddParameter("@TCG_YType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_YType", tC_Group.TCG_YType);
         }
          }
         if(tC_Group.TCG_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_Group.TCG_TCode))
         {
            idb.AddParameter("@TCG_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCG_TCode", tC_Group.TCG_TCode);
         }
          }
         if(tC_Group.Stat_IsChanged)
         {
         if (tC_Group.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_Group.Stat);
         }
          }
         if(tC_Group.CreateDate_IsChanged)
         {
         if (tC_Group.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_Group.CreateDate);
         }
          }
         if(tC_Group.UpdateDate_IsChanged)
         {
         if (tC_Group.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_Group.UpdateDate);
         }
          }
         if(tC_Group.DeleteDate_IsChanged)
         {
         if (tC_Group.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_Group.DeleteDate);
         }
          }

         idb.AddParameter("@TCG_ID", tC_Group.TCG_ID);

           
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
      /// 删除试组信息 TC_Group对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCG_ID)
      {
         string sql = "DELETE TC_Group WHERE 1=1  AND TCG_ID=@TCG_ID ";
         idb.AddParameter("@TCG_ID", tCG_ID);

           
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
      /// 获取指定的试组信息 TC_Group对象(即:一条记录
      /// </summary>
      public TC_Group GetByKey(decimal tCG_ID)
      {
         TC_Group tC_Group = new TC_Group();
         string sql = "SELECT  TCG_ID,TCG_Code,TCG_CCode,TCG_PRCode,TCG_PPCode,TCG_PDCode,TCG_Owner,TCG_Date,TCG_GType,TCG_iType,TCG_iNum,TCG_KWater,TCG_BType,TCG_YType,TCG_TCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Group WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCG_ID=@TCG_ID ";
         idb.AddParameter("@TCG_ID", tCG_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCG_ID"] != DBNull.Value) tC_Group.TCG_ID = Convert.ToDecimal(dr["TCG_ID"]);
            if (dr["TCG_Code"] != DBNull.Value) tC_Group.TCG_Code = Convert.ToString(dr["TCG_Code"]);
            if (dr["TCG_CCode"] != DBNull.Value) tC_Group.TCG_CCode = Convert.ToString(dr["TCG_CCode"]);
            if (dr["TCG_PRCode"] != DBNull.Value) tC_Group.TCG_PRCode = Convert.ToString(dr["TCG_PRCode"]);
            if (dr["TCG_PPCode"] != DBNull.Value) tC_Group.TCG_PPCode = Convert.ToString(dr["TCG_PPCode"]);
            if (dr["TCG_PDCode"] != DBNull.Value) tC_Group.TCG_PDCode = Convert.ToString(dr["TCG_PDCode"]);
            if (dr["TCG_Owner"] != DBNull.Value) tC_Group.TCG_Owner = Convert.ToString(dr["TCG_Owner"]);
            if (dr["TCG_Date"] != DBNull.Value) tC_Group.TCG_Date = Convert.ToDateTime(dr["TCG_Date"]);
            if (dr["TCG_GType"] != DBNull.Value) tC_Group.TCG_GType = Convert.ToString(dr["TCG_GType"]);
            if (dr["TCG_iType"] != DBNull.Value) tC_Group.TCG_iType = Convert.ToString(dr["TCG_iType"]);
            if (dr["TCG_iNum"] != DBNull.Value) tC_Group.TCG_iNum = Convert.ToInt32(dr["TCG_iNum"]);
            if (dr["TCG_KWater"] != DBNull.Value) tC_Group.TCG_KWater = Convert.ToString(dr["TCG_KWater"]);
            if (dr["TCG_BType"] != DBNull.Value) tC_Group.TCG_BType = Convert.ToString(dr["TCG_BType"]);
            if (dr["TCG_YType"] != DBNull.Value) tC_Group.TCG_YType = Convert.ToString(dr["TCG_YType"]);
            if (dr["TCG_TCode"] != DBNull.Value) tC_Group.TCG_TCode = Convert.ToString(dr["TCG_TCode"]);
            if (dr["Stat"] != DBNull.Value) tC_Group.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Group.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Group.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Group.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_Group;
      }
      /// <summary>
      /// 获取指定的试组信息 TC_Group对象集合
      /// </summary>
      public List<TC_Group> GetListByWhere(string strCondition)
      {
         List<TC_Group> ret = new List<TC_Group>();
         string sql = "SELECT  TCG_ID,TCG_Code,TCG_CCode,TCG_PRCode,TCG_PPCode,TCG_PDCode,TCG_Owner,TCG_Date,TCG_GType,TCG_iType,TCG_iNum,TCG_KWater,TCG_BType,TCG_YType,TCG_TCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Group WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_Group tC_Group = new TC_Group();
            if (dr["TCG_ID"] != DBNull.Value) tC_Group.TCG_ID = Convert.ToDecimal(dr["TCG_ID"]);
            if (dr["TCG_Code"] != DBNull.Value) tC_Group.TCG_Code = Convert.ToString(dr["TCG_Code"]);
            if (dr["TCG_CCode"] != DBNull.Value) tC_Group.TCG_CCode = Convert.ToString(dr["TCG_CCode"]);
            if (dr["TCG_PRCode"] != DBNull.Value) tC_Group.TCG_PRCode = Convert.ToString(dr["TCG_PRCode"]);
            if (dr["TCG_PPCode"] != DBNull.Value) tC_Group.TCG_PPCode = Convert.ToString(dr["TCG_PPCode"]);
            if (dr["TCG_PDCode"] != DBNull.Value) tC_Group.TCG_PDCode = Convert.ToString(dr["TCG_PDCode"]);
            if (dr["TCG_Owner"] != DBNull.Value) tC_Group.TCG_Owner = Convert.ToString(dr["TCG_Owner"]);
            if (dr["TCG_Date"] != DBNull.Value) tC_Group.TCG_Date = Convert.ToDateTime(dr["TCG_Date"]);
            if (dr["TCG_GType"] != DBNull.Value) tC_Group.TCG_GType = Convert.ToString(dr["TCG_GType"]);
            if (dr["TCG_iType"] != DBNull.Value) tC_Group.TCG_iType = Convert.ToString(dr["TCG_iType"]);
            if (dr["TCG_iNum"] != DBNull.Value) tC_Group.TCG_iNum = Convert.ToInt32(dr["TCG_iNum"]);
            if (dr["TCG_KWater"] != DBNull.Value) tC_Group.TCG_KWater = Convert.ToString(dr["TCG_KWater"]);
            if (dr["TCG_BType"] != DBNull.Value) tC_Group.TCG_BType = Convert.ToString(dr["TCG_BType"]);
            if (dr["TCG_YType"] != DBNull.Value) tC_Group.TCG_YType = Convert.ToString(dr["TCG_YType"]);
            if (dr["TCG_TCode"] != DBNull.Value) tC_Group.TCG_TCode = Convert.ToString(dr["TCG_TCode"]);
            if (dr["Stat"] != DBNull.Value) tC_Group.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Group.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Group.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Group.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_Group);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的试组信息 TC_Group对象(即:一条记录
      /// </summary>
      public List<TC_Group> GetAll()
      {
         List<TC_Group> ret = new List<TC_Group>();
         string sql = "SELECT  TCG_ID,TCG_Code,TCG_CCode,TCG_PRCode,TCG_PPCode,TCG_PDCode,TCG_Owner,TCG_Date,TCG_GType,TCG_iType,TCG_iNum,TCG_KWater,TCG_BType,TCG_YType,TCG_TCode,Stat,CreateDate,UpdateDate,DeleteDate FROM TC_Group where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCG_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_Group tC_Group = new TC_Group();
            if (dr["TCG_ID"] != DBNull.Value) tC_Group.TCG_ID = Convert.ToDecimal(dr["TCG_ID"]);
            if (dr["TCG_Code"] != DBNull.Value) tC_Group.TCG_Code = Convert.ToString(dr["TCG_Code"]);
            if (dr["TCG_CCode"] != DBNull.Value) tC_Group.TCG_CCode = Convert.ToString(dr["TCG_CCode"]);
            if (dr["TCG_PRCode"] != DBNull.Value) tC_Group.TCG_PRCode = Convert.ToString(dr["TCG_PRCode"]);
            if (dr["TCG_PPCode"] != DBNull.Value) tC_Group.TCG_PPCode = Convert.ToString(dr["TCG_PPCode"]);
            if (dr["TCG_PDCode"] != DBNull.Value) tC_Group.TCG_PDCode = Convert.ToString(dr["TCG_PDCode"]);
            if (dr["TCG_Owner"] != DBNull.Value) tC_Group.TCG_Owner = Convert.ToString(dr["TCG_Owner"]);
            if (dr["TCG_Date"] != DBNull.Value) tC_Group.TCG_Date = Convert.ToDateTime(dr["TCG_Date"]);
            if (dr["TCG_GType"] != DBNull.Value) tC_Group.TCG_GType = Convert.ToString(dr["TCG_GType"]);
            if (dr["TCG_iType"] != DBNull.Value) tC_Group.TCG_iType = Convert.ToString(dr["TCG_iType"]);
            if (dr["TCG_iNum"] != DBNull.Value) tC_Group.TCG_iNum = Convert.ToInt32(dr["TCG_iNum"]);
            if (dr["TCG_KWater"] != DBNull.Value) tC_Group.TCG_KWater = Convert.ToString(dr["TCG_KWater"]);
            if (dr["TCG_BType"] != DBNull.Value) tC_Group.TCG_BType = Convert.ToString(dr["TCG_BType"]);
            if (dr["TCG_YType"] != DBNull.Value) tC_Group.TCG_YType = Convert.ToString(dr["TCG_YType"]);
            if (dr["TCG_TCode"] != DBNull.Value) tC_Group.TCG_TCode = Convert.ToString(dr["TCG_TCode"]);
            if (dr["Stat"] != DBNull.Value) tC_Group.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_Group.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_Group.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_Group.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(tC_Group);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
