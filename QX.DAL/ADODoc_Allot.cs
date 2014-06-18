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
   public partial class ADODoc_Allot
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Doc_Allot对象(即:一条记录)
      /// </summary>
      public int Add(Doc_Allot doc_Allot)
      {
         string sql = "INSERT INTO Doc_Allot (DA_Code,DA_DocCode,DA_IsHandle,DA_Date,DA_Opinion,DA_Allot,DA_Account,DA_Type,DA_iType,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@DA_Code,@DA_DocCode,@DA_IsHandle,@DA_Date,@DA_Opinion,@DA_Allot,@DA_Account,@DA_Type,@DA_iType,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(doc_Allot.DA_Code))
         {
            idb.AddParameter("@DA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Code", doc_Allot.DA_Code);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_DocCode))
         {
            idb.AddParameter("@DA_DocCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_DocCode", doc_Allot.DA_DocCode);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_IsHandle))
         {
            idb.AddParameter("@DA_IsHandle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_IsHandle", doc_Allot.DA_IsHandle);
         }
         if (doc_Allot.DA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Date", doc_Allot.DA_Date);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Opinion))
         {
            idb.AddParameter("@DA_Opinion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Opinion", doc_Allot.DA_Opinion);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Allot))
         {
            idb.AddParameter("@DA_Allot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Allot", doc_Allot.DA_Allot);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Account))
         {
            idb.AddParameter("@DA_Account", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Account", doc_Allot.DA_Account);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Type))
         {
            idb.AddParameter("@DA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Type", doc_Allot.DA_Type);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_iType))
         {
            idb.AddParameter("@DA_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_iType", doc_Allot.DA_iType);
         }
         if (doc_Allot.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Allot.Stat);
         }
         if (doc_Allot.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Allot.CreateTime);
         }
         if (doc_Allot.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Allot.UpdateTime);
         }
         if (doc_Allot.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Allot.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Doc_Allot对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Doc_Allot doc_Allot)
      {
         string sql = "INSERT INTO Doc_Allot (DA_Code,DA_DocCode,DA_IsHandle,DA_Date,DA_Opinion,DA_Allot,DA_Account,DA_Type,DA_iType,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@DA_Code,@DA_DocCode,@DA_IsHandle,@DA_Date,@DA_Opinion,@DA_Allot,@DA_Account,@DA_Type,@DA_iType,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(doc_Allot.DA_Code))
         {
            idb.AddParameter("@DA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Code", doc_Allot.DA_Code);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_DocCode))
         {
            idb.AddParameter("@DA_DocCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_DocCode", doc_Allot.DA_DocCode);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_IsHandle))
         {
            idb.AddParameter("@DA_IsHandle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_IsHandle", doc_Allot.DA_IsHandle);
         }
         if (doc_Allot.DA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Date", doc_Allot.DA_Date);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Opinion))
         {
            idb.AddParameter("@DA_Opinion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Opinion", doc_Allot.DA_Opinion);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Allot))
         {
            idb.AddParameter("@DA_Allot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Allot", doc_Allot.DA_Allot);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Account))
         {
            idb.AddParameter("@DA_Account", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Account", doc_Allot.DA_Account);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_Type))
         {
            idb.AddParameter("@DA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Type", doc_Allot.DA_Type);
         }
         if (string.IsNullOrEmpty(doc_Allot.DA_iType))
         {
            idb.AddParameter("@DA_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_iType", doc_Allot.DA_iType);
         }
         if (doc_Allot.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Allot.Stat);
         }
         if (doc_Allot.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Allot.CreateTime);
         }
         if (doc_Allot.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Allot.UpdateTime);
         }
         if (doc_Allot.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Allot.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Doc_Allot对象(即:一条记录
      /// </summary>
      public int Update(Doc_Allot doc_Allot)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Doc_Allot       SET ");
            if(doc_Allot.DA_Code_IsChanged){sbParameter.Append("DA_Code=@DA_Code, ");}
      if(doc_Allot.DA_DocCode_IsChanged){sbParameter.Append("DA_DocCode=@DA_DocCode, ");}
      if(doc_Allot.DA_IsHandle_IsChanged){sbParameter.Append("DA_IsHandle=@DA_IsHandle, ");}
      if(doc_Allot.DA_Date_IsChanged){sbParameter.Append("DA_Date=@DA_Date, ");}
      if(doc_Allot.DA_Opinion_IsChanged){sbParameter.Append("DA_Opinion=@DA_Opinion, ");}
      if(doc_Allot.DA_Allot_IsChanged){sbParameter.Append("DA_Allot=@DA_Allot, ");}
      if(doc_Allot.DA_Account_IsChanged){sbParameter.Append("DA_Account=@DA_Account, ");}
      if(doc_Allot.DA_Type_IsChanged){sbParameter.Append("DA_Type=@DA_Type, ");}
      if(doc_Allot.DA_iType_IsChanged){sbParameter.Append("DA_iType=@DA_iType, ");}
      if(doc_Allot.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(doc_Allot.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(doc_Allot.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(doc_Allot.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DA_ID=@DA_ID; " );
      string sql=sb.ToString();
         if(doc_Allot.DA_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_Code))
         {
            idb.AddParameter("@DA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Code", doc_Allot.DA_Code);
         }
          }
         if(doc_Allot.DA_DocCode_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_DocCode))
         {
            idb.AddParameter("@DA_DocCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_DocCode", doc_Allot.DA_DocCode);
         }
          }
         if(doc_Allot.DA_IsHandle_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_IsHandle))
         {
            idb.AddParameter("@DA_IsHandle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_IsHandle", doc_Allot.DA_IsHandle);
         }
          }
         if(doc_Allot.DA_Date_IsChanged)
         {
         if (doc_Allot.DA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Date", doc_Allot.DA_Date);
         }
          }
         if(doc_Allot.DA_Opinion_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_Opinion))
         {
            idb.AddParameter("@DA_Opinion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Opinion", doc_Allot.DA_Opinion);
         }
          }
         if(doc_Allot.DA_Allot_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_Allot))
         {
            idb.AddParameter("@DA_Allot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Allot", doc_Allot.DA_Allot);
         }
          }
         if(doc_Allot.DA_Account_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_Account))
         {
            idb.AddParameter("@DA_Account", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Account", doc_Allot.DA_Account);
         }
          }
         if(doc_Allot.DA_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_Type))
         {
            idb.AddParameter("@DA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_Type", doc_Allot.DA_Type);
         }
          }
         if(doc_Allot.DA_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Allot.DA_iType))
         {
            idb.AddParameter("@DA_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DA_iType", doc_Allot.DA_iType);
         }
          }
         if(doc_Allot.Stat_IsChanged)
         {
         if (doc_Allot.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Allot.Stat);
         }
          }
         if(doc_Allot.CreateTime_IsChanged)
         {
         if (doc_Allot.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Allot.CreateTime);
         }
          }
         if(doc_Allot.UpdateTime_IsChanged)
         {
         if (doc_Allot.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Allot.UpdateTime);
         }
          }
         if(doc_Allot.DeleteTime_IsChanged)
         {
         if (doc_Allot.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Allot.DeleteTime);
         }
          }

         idb.AddParameter("@DA_ID", doc_Allot.DA_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Doc_Allot对象(即:一条记录
      /// </summary>
      public int Delete(decimal dA_ID)
      {
         string sql = "DELETE Doc_Allot WHERE 1=1  AND DA_ID=@DA_ID ";
         idb.AddParameter("@DA_ID", dA_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Doc_Allot对象(即:一条记录
      /// </summary>
      public Doc_Allot GetByKey(decimal dA_ID)
      {
         Doc_Allot doc_Allot = new Doc_Allot();
         string sql = "SELECT  DA_ID,DA_Code,DA_DocCode,DA_IsHandle,DA_Date,DA_Opinion,DA_Allot,DA_Account,DA_Type,DA_iType,Stat,CreateTime,UpdateTime,DeleteTime FROM Doc_Allot WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DA_ID=@DA_ID ";
         idb.AddParameter("@DA_ID", dA_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DA_ID"] != DBNull.Value) doc_Allot.DA_ID = Convert.ToDecimal(dr["DA_ID"]);
            if (dr["DA_Code"] != DBNull.Value) doc_Allot.DA_Code = Convert.ToString(dr["DA_Code"]);
            if (dr["DA_DocCode"] != DBNull.Value) doc_Allot.DA_DocCode = Convert.ToString(dr["DA_DocCode"]);
            if (dr["DA_IsHandle"] != DBNull.Value) doc_Allot.DA_IsHandle = Convert.ToString(dr["DA_IsHandle"]);
            if (dr["DA_Date"] != DBNull.Value) doc_Allot.DA_Date = Convert.ToDateTime(dr["DA_Date"]);
            if (dr["DA_Opinion"] != DBNull.Value) doc_Allot.DA_Opinion = Convert.ToString(dr["DA_Opinion"]);
            if (dr["DA_Allot"] != DBNull.Value) doc_Allot.DA_Allot = Convert.ToString(dr["DA_Allot"]);
            if (dr["DA_Account"] != DBNull.Value) doc_Allot.DA_Account = Convert.ToString(dr["DA_Account"]);
            if (dr["DA_Type"] != DBNull.Value) doc_Allot.DA_Type = Convert.ToString(dr["DA_Type"]);
            if (dr["DA_iType"] != DBNull.Value) doc_Allot.DA_iType = Convert.ToString(dr["DA_iType"]);
            if (dr["Stat"] != DBNull.Value) doc_Allot.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Allot.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Allot.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Allot.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return doc_Allot;
      }
      /// <summary>
      /// 获取指定的Doc_Allot对象集合
      /// </summary>
      public List<Doc_Allot> GetListByWhere(string strCondition)
      {
         List<Doc_Allot> ret = new List<Doc_Allot>();
         string sql = "SELECT  DA_ID,DA_Code,DA_DocCode,DA_IsHandle,DA_Date,DA_Opinion,DA_Allot,DA_Account,DA_Type,DA_iType,Stat,CreateTime,UpdateTime,DeleteTime FROM Doc_Allot WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY DA_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Doc_Allot doc_Allot = new Doc_Allot();
            if (dr["DA_ID"] != DBNull.Value) doc_Allot.DA_ID = Convert.ToDecimal(dr["DA_ID"]);
            if (dr["DA_Code"] != DBNull.Value) doc_Allot.DA_Code = Convert.ToString(dr["DA_Code"]);
            if (dr["DA_DocCode"] != DBNull.Value) doc_Allot.DA_DocCode = Convert.ToString(dr["DA_DocCode"]);
            if (dr["DA_IsHandle"] != DBNull.Value) doc_Allot.DA_IsHandle = Convert.ToString(dr["DA_IsHandle"]);
            if (dr["DA_Date"] != DBNull.Value) doc_Allot.DA_Date = Convert.ToDateTime(dr["DA_Date"]);
            if (dr["DA_Opinion"] != DBNull.Value) doc_Allot.DA_Opinion = Convert.ToString(dr["DA_Opinion"]);
            if (dr["DA_Allot"] != DBNull.Value) doc_Allot.DA_Allot = Convert.ToString(dr["DA_Allot"]);
            if (dr["DA_Account"] != DBNull.Value) doc_Allot.DA_Account = Convert.ToString(dr["DA_Account"]);
            if (dr["DA_Type"] != DBNull.Value) doc_Allot.DA_Type = Convert.ToString(dr["DA_Type"]);
            if (dr["DA_iType"] != DBNull.Value) doc_Allot.DA_iType = Convert.ToString(dr["DA_iType"]);
            if (dr["Stat"] != DBNull.Value) doc_Allot.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Allot.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Allot.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Allot.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(doc_Allot);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Doc_Allot对象(即:一条记录
      /// </summary>
      public List<Doc_Allot> GetAll()
      {
         List<Doc_Allot> ret = new List<Doc_Allot>();
         string sql = "SELECT  DA_ID,DA_Code,DA_DocCode,DA_IsHandle,DA_Date,DA_Opinion,DA_Allot,DA_Account,DA_Type,DA_iType,Stat,CreateTime,UpdateTime,DeleteTime FROM Doc_Allot where 1=1 AND ((Stat is null) or (Stat=0) ) order by DA_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Doc_Allot doc_Allot = new Doc_Allot();
            if (dr["DA_ID"] != DBNull.Value) doc_Allot.DA_ID = Convert.ToDecimal(dr["DA_ID"]);
            if (dr["DA_Code"] != DBNull.Value) doc_Allot.DA_Code = Convert.ToString(dr["DA_Code"]);
            if (dr["DA_DocCode"] != DBNull.Value) doc_Allot.DA_DocCode = Convert.ToString(dr["DA_DocCode"]);
            if (dr["DA_IsHandle"] != DBNull.Value) doc_Allot.DA_IsHandle = Convert.ToString(dr["DA_IsHandle"]);
            if (dr["DA_Date"] != DBNull.Value) doc_Allot.DA_Date = Convert.ToDateTime(dr["DA_Date"]);
            if (dr["DA_Opinion"] != DBNull.Value) doc_Allot.DA_Opinion = Convert.ToString(dr["DA_Opinion"]);
            if (dr["DA_Allot"] != DBNull.Value) doc_Allot.DA_Allot = Convert.ToString(dr["DA_Allot"]);
            if (dr["DA_Account"] != DBNull.Value) doc_Allot.DA_Account = Convert.ToString(dr["DA_Account"]);
            if (dr["DA_Type"] != DBNull.Value) doc_Allot.DA_Type = Convert.ToString(dr["DA_Type"]);
            if (dr["DA_iType"] != DBNull.Value) doc_Allot.DA_iType = Convert.ToString(dr["DA_iType"]);
            if (dr["Stat"] != DBNull.Value) doc_Allot.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Allot.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Allot.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Allot.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(doc_Allot);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
