using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Permission.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOSys_Function
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_Function对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Function sys_Function)
      {
         string sql = "INSERT INTO Sys_Function (Fun_RCode,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_iType,Fun_UDef1,Fun_UDef2,Fun_UDef3,Fun_UDef4,Fun_UDef5,Fun_UDef6,Fun_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Fun_RCode,@Fun_Code,@Fun_Name,@Fun_PCode,@Fun_Order,@Fun_iType,@Fun_UDef1,@Fun_UDef2,@Fun_UDef3,@Fun_UDef4,@Fun_UDef5,@Fun_UDef6,@Fun_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(sys_Function.Fun_RCode))
         {
            idb.AddParameter("@Fun_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_RCode", sys_Function.Fun_RCode);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Code))
         {
            idb.AddParameter("@Fun_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Code", sys_Function.Fun_Code);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Name))
         {
            idb.AddParameter("@Fun_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Name", sys_Function.Fun_Name);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_PCode))
         {
            idb.AddParameter("@Fun_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_PCode", sys_Function.Fun_PCode);
         }
         if (sys_Function.Fun_Order == 0)
         {
            idb.AddParameter("@Fun_Order", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Order", sys_Function.Fun_Order);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_iType))
         {
            idb.AddParameter("@Fun_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_iType", sys_Function.Fun_iType);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef1))
         {
            idb.AddParameter("@Fun_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef1", sys_Function.Fun_UDef1);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef2))
         {
            idb.AddParameter("@Fun_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef2", sys_Function.Fun_UDef2);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef3))
         {
            idb.AddParameter("@Fun_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef3", sys_Function.Fun_UDef3);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef4))
         {
            idb.AddParameter("@Fun_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef4", sys_Function.Fun_UDef4);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef5))
         {
            idb.AddParameter("@Fun_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef5", sys_Function.Fun_UDef5);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef6))
         {
            idb.AddParameter("@Fun_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef6", sys_Function.Fun_UDef6);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Stat))
         {
            idb.AddParameter("@Fun_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Stat", sys_Function.Fun_Stat);
         }
         if (sys_Function.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Function.Stat);
         }
         if (sys_Function.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sys_Function.CreateDate);
         }
         if (sys_Function.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sys_Function.UpdateDate);
         }
         if (sys_Function.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sys_Function.DeleteDate);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_Function对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Function sys_Function)
      {
         string sql = "INSERT INTO Sys_Function (Fun_RCode,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_iType,Fun_UDef1,Fun_UDef2,Fun_UDef3,Fun_UDef4,Fun_UDef5,Fun_UDef6,Fun_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Fun_RCode,@Fun_Code,@Fun_Name,@Fun_PCode,@Fun_Order,@Fun_iType,@Fun_UDef1,@Fun_UDef2,@Fun_UDef3,@Fun_UDef4,@Fun_UDef5,@Fun_UDef6,@Fun_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Function.Fun_RCode))
         {
            idb.AddParameter("@Fun_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_RCode", sys_Function.Fun_RCode);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Code))
         {
            idb.AddParameter("@Fun_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Code", sys_Function.Fun_Code);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Name))
         {
            idb.AddParameter("@Fun_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Name", sys_Function.Fun_Name);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_PCode))
         {
            idb.AddParameter("@Fun_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_PCode", sys_Function.Fun_PCode);
         }
         if (sys_Function.Fun_Order == 0)
         {
            idb.AddParameter("@Fun_Order", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Order", sys_Function.Fun_Order);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_iType))
         {
            idb.AddParameter("@Fun_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_iType", sys_Function.Fun_iType);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef1))
         {
            idb.AddParameter("@Fun_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef1", sys_Function.Fun_UDef1);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef2))
         {
            idb.AddParameter("@Fun_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef2", sys_Function.Fun_UDef2);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef3))
         {
            idb.AddParameter("@Fun_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef3", sys_Function.Fun_UDef3);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef4))
         {
            idb.AddParameter("@Fun_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef4", sys_Function.Fun_UDef4);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef5))
         {
            idb.AddParameter("@Fun_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef5", sys_Function.Fun_UDef5);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef6))
         {
            idb.AddParameter("@Fun_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef6", sys_Function.Fun_UDef6);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Stat))
         {
            idb.AddParameter("@Fun_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Stat", sys_Function.Fun_Stat);
         }
         if (sys_Function.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Function.Stat);
         }
         if (sys_Function.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sys_Function.CreateDate);
         }
         if (sys_Function.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sys_Function.UpdateDate);
         }
         if (sys_Function.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sys_Function.DeleteDate);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_Function对象(即:一条记录
      /// </summary>
      public int Update(Sys_Function sys_Function)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Function       SET ");
            if(sys_Function.Fun_RCode_IsChanged){sbParameter.Append("Fun_RCode=@Fun_RCode, ");}
      if(sys_Function.Fun_Code_IsChanged){sbParameter.Append("Fun_Code=@Fun_Code, ");}
      if(sys_Function.Fun_Name_IsChanged){sbParameter.Append("Fun_Name=@Fun_Name, ");}
      if(sys_Function.Fun_PCode_IsChanged){sbParameter.Append("Fun_PCode=@Fun_PCode, ");}
      if(sys_Function.Fun_Order_IsChanged){sbParameter.Append("Fun_Order=@Fun_Order, ");}
      if(sys_Function.Fun_iType_IsChanged){sbParameter.Append("Fun_iType=@Fun_iType, ");}
      if(sys_Function.Fun_UDef1_IsChanged){sbParameter.Append("Fun_UDef1=@Fun_UDef1, ");}
      if(sys_Function.Fun_UDef2_IsChanged){sbParameter.Append("Fun_UDef2=@Fun_UDef2, ");}
      if(sys_Function.Fun_UDef3_IsChanged){sbParameter.Append("Fun_UDef3=@Fun_UDef3, ");}
      if(sys_Function.Fun_UDef4_IsChanged){sbParameter.Append("Fun_UDef4=@Fun_UDef4, ");}
      if(sys_Function.Fun_UDef5_IsChanged){sbParameter.Append("Fun_UDef5=@Fun_UDef5, ");}
      if(sys_Function.Fun_UDef6_IsChanged){sbParameter.Append("Fun_UDef6=@Fun_UDef6, ");}
      if(sys_Function.Fun_Stat_IsChanged){sbParameter.Append("Fun_Stat=@Fun_Stat, ");}
      if(sys_Function.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_Function.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sys_Function.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sys_Function.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Fun_ID=@Fun_ID; " );
      string sql=sb.ToString();
         if(sys_Function.Fun_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_RCode))
         {
            idb.AddParameter("@Fun_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_RCode", sys_Function.Fun_RCode);
         }
          }
         if(sys_Function.Fun_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_Code))
         {
            idb.AddParameter("@Fun_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Code", sys_Function.Fun_Code);
         }
          }
         if(sys_Function.Fun_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_Name))
         {
            idb.AddParameter("@Fun_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Name", sys_Function.Fun_Name);
         }
          }
         if(sys_Function.Fun_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_PCode))
         {
            idb.AddParameter("@Fun_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_PCode", sys_Function.Fun_PCode);
         }
          }
         if(sys_Function.Fun_Order_IsChanged)
         {
         if (sys_Function.Fun_Order == 0)
         {
            idb.AddParameter("@Fun_Order", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Order", sys_Function.Fun_Order);
         }
          }
         if(sys_Function.Fun_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_iType))
         {
            idb.AddParameter("@Fun_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_iType", sys_Function.Fun_iType);
         }
          }
         if(sys_Function.Fun_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef1))
         {
            idb.AddParameter("@Fun_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef1", sys_Function.Fun_UDef1);
         }
          }
         if(sys_Function.Fun_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef2))
         {
            idb.AddParameter("@Fun_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef2", sys_Function.Fun_UDef2);
         }
          }
         if(sys_Function.Fun_UDef3_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef3))
         {
            idb.AddParameter("@Fun_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef3", sys_Function.Fun_UDef3);
         }
          }
         if(sys_Function.Fun_UDef4_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef4))
         {
            idb.AddParameter("@Fun_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef4", sys_Function.Fun_UDef4);
         }
          }
         if(sys_Function.Fun_UDef5_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef5))
         {
            idb.AddParameter("@Fun_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef5", sys_Function.Fun_UDef5);
         }
          }
         if(sys_Function.Fun_UDef6_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_UDef6))
         {
            idb.AddParameter("@Fun_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_UDef6", sys_Function.Fun_UDef6);
         }
          }
         if(sys_Function.Fun_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_Stat))
         {
            idb.AddParameter("@Fun_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Stat", sys_Function.Fun_Stat);
         }
          }
         if(sys_Function.Stat_IsChanged)
         {
         if (sys_Function.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Function.Stat);
         }
          }
         if(sys_Function.CreateDate_IsChanged)
         {
         if (sys_Function.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sys_Function.CreateDate);
         }
          }
         if(sys_Function.UpdateDate_IsChanged)
         {
         if (sys_Function.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sys_Function.UpdateDate);
         }
          }
         if(sys_Function.DeleteDate_IsChanged)
         {
         if (sys_Function.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sys_Function.DeleteDate);
         }
          }

         idb.AddParameter("@Fun_ID", sys_Function.Fun_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_Function对象(即:一条记录
      /// </summary>
      public int Delete(decimal fun_ID)
      {
         string sql = "DELETE Sys_Function WHERE 1=1  AND Fun_ID=@Fun_ID ";
         idb.AddParameter("@Fun_ID", fun_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_Function对象(即:一条记录
      /// </summary>
      public Sys_Function GetByKey(decimal fun_ID)
      {
         Sys_Function sys_Function = new Sys_Function();
         string sql = "SELECT  Fun_ID,Fun_RCode,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_iType,Fun_UDef1,Fun_UDef2,Fun_UDef3,Fun_UDef4,Fun_UDef5,Fun_UDef6,Fun_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM Sys_Function WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Fun_ID=@Fun_ID ";
         idb.AddParameter("@Fun_ID", fun_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Fun_ID"] != DBNull.Value) sys_Function.Fun_ID = Convert.ToDecimal(dr["Fun_ID"]);
            if (dr["Fun_RCode"] != DBNull.Value) sys_Function.Fun_RCode = Convert.ToString(dr["Fun_RCode"]);
            if (dr["Fun_Code"] != DBNull.Value) sys_Function.Fun_Code = Convert.ToString(dr["Fun_Code"]);
            if (dr["Fun_Name"] != DBNull.Value) sys_Function.Fun_Name = Convert.ToString(dr["Fun_Name"]);
            if (dr["Fun_PCode"] != DBNull.Value) sys_Function.Fun_PCode = Convert.ToString(dr["Fun_PCode"]);
            if (dr["Fun_Order"] != DBNull.Value) sys_Function.Fun_Order = Convert.ToInt32(dr["Fun_Order"]);
            if (dr["Fun_iType"] != DBNull.Value) sys_Function.Fun_iType = Convert.ToString(dr["Fun_iType"]);
            if (dr["Fun_UDef1"] != DBNull.Value) sys_Function.Fun_UDef1 = Convert.ToString(dr["Fun_UDef1"]);
            if (dr["Fun_UDef2"] != DBNull.Value) sys_Function.Fun_UDef2 = Convert.ToString(dr["Fun_UDef2"]);
            if (dr["Fun_UDef3"] != DBNull.Value) sys_Function.Fun_UDef3 = Convert.ToString(dr["Fun_UDef3"]);
            if (dr["Fun_UDef4"] != DBNull.Value) sys_Function.Fun_UDef4 = Convert.ToString(dr["Fun_UDef4"]);
            if (dr["Fun_UDef5"] != DBNull.Value) sys_Function.Fun_UDef5 = Convert.ToString(dr["Fun_UDef5"]);
            if (dr["Fun_UDef6"] != DBNull.Value) sys_Function.Fun_UDef6 = Convert.ToString(dr["Fun_UDef6"]);
            if (dr["Fun_Stat"] != DBNull.Value) sys_Function.Fun_Stat = Convert.ToString(dr["Fun_Stat"]);
            if (dr["Stat"] != DBNull.Value) sys_Function.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sys_Function.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sys_Function.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sys_Function.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Function;
      }
      /// <summary>
      /// 获取指定的Sys_Function对象集合
      /// </summary>
      public List<Sys_Function> GetListByWhere(string strCondition)
      {
         List<Sys_Function> ret = new List<Sys_Function>();
         string sql = "SELECT  Fun_ID,Fun_RCode,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_iType,Fun_UDef1,Fun_UDef2,Fun_UDef3,Fun_UDef4,Fun_UDef5,Fun_UDef6,Fun_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM Sys_Function WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Function sys_Function = new Sys_Function();
            if (dr["Fun_ID"] != DBNull.Value) sys_Function.Fun_ID = Convert.ToDecimal(dr["Fun_ID"]);
            if (dr["Fun_RCode"] != DBNull.Value) sys_Function.Fun_RCode = Convert.ToString(dr["Fun_RCode"]);
            if (dr["Fun_Code"] != DBNull.Value) sys_Function.Fun_Code = Convert.ToString(dr["Fun_Code"]);
            if (dr["Fun_Name"] != DBNull.Value) sys_Function.Fun_Name = Convert.ToString(dr["Fun_Name"]);
            if (dr["Fun_PCode"] != DBNull.Value) sys_Function.Fun_PCode = Convert.ToString(dr["Fun_PCode"]);
            if (dr["Fun_Order"] != DBNull.Value) sys_Function.Fun_Order = Convert.ToInt32(dr["Fun_Order"]);
            if (dr["Fun_iType"] != DBNull.Value) sys_Function.Fun_iType = Convert.ToString(dr["Fun_iType"]);
            if (dr["Fun_UDef1"] != DBNull.Value) sys_Function.Fun_UDef1 = Convert.ToString(dr["Fun_UDef1"]);
            if (dr["Fun_UDef2"] != DBNull.Value) sys_Function.Fun_UDef2 = Convert.ToString(dr["Fun_UDef2"]);
            if (dr["Fun_UDef3"] != DBNull.Value) sys_Function.Fun_UDef3 = Convert.ToString(dr["Fun_UDef3"]);
            if (dr["Fun_UDef4"] != DBNull.Value) sys_Function.Fun_UDef4 = Convert.ToString(dr["Fun_UDef4"]);
            if (dr["Fun_UDef5"] != DBNull.Value) sys_Function.Fun_UDef5 = Convert.ToString(dr["Fun_UDef5"]);
            if (dr["Fun_UDef6"] != DBNull.Value) sys_Function.Fun_UDef6 = Convert.ToString(dr["Fun_UDef6"]);
            if (dr["Fun_Stat"] != DBNull.Value) sys_Function.Fun_Stat = Convert.ToString(dr["Fun_Stat"]);
            if (dr["Stat"] != DBNull.Value) sys_Function.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sys_Function.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sys_Function.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sys_Function.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sys_Function);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_Function对象(即:一条记录
      /// </summary>
      public List<Sys_Function> GetAll()
      {
         List<Sys_Function> ret = new List<Sys_Function>();
         string sql = "SELECT  Fun_ID,Fun_RCode,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_iType,Fun_UDef1,Fun_UDef2,Fun_UDef3,Fun_UDef4,Fun_UDef5,Fun_UDef6,Fun_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM Sys_Function where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Function sys_Function = new Sys_Function();
            if (dr["Fun_ID"] != DBNull.Value) sys_Function.Fun_ID = Convert.ToDecimal(dr["Fun_ID"]);
            if (dr["Fun_RCode"] != DBNull.Value) sys_Function.Fun_RCode = Convert.ToString(dr["Fun_RCode"]);
            if (dr["Fun_Code"] != DBNull.Value) sys_Function.Fun_Code = Convert.ToString(dr["Fun_Code"]);
            if (dr["Fun_Name"] != DBNull.Value) sys_Function.Fun_Name = Convert.ToString(dr["Fun_Name"]);
            if (dr["Fun_PCode"] != DBNull.Value) sys_Function.Fun_PCode = Convert.ToString(dr["Fun_PCode"]);
            if (dr["Fun_Order"] != DBNull.Value) sys_Function.Fun_Order = Convert.ToInt32(dr["Fun_Order"]);
            if (dr["Fun_iType"] != DBNull.Value) sys_Function.Fun_iType = Convert.ToString(dr["Fun_iType"]);
            if (dr["Fun_UDef1"] != DBNull.Value) sys_Function.Fun_UDef1 = Convert.ToString(dr["Fun_UDef1"]);
            if (dr["Fun_UDef2"] != DBNull.Value) sys_Function.Fun_UDef2 = Convert.ToString(dr["Fun_UDef2"]);
            if (dr["Fun_UDef3"] != DBNull.Value) sys_Function.Fun_UDef3 = Convert.ToString(dr["Fun_UDef3"]);
            if (dr["Fun_UDef4"] != DBNull.Value) sys_Function.Fun_UDef4 = Convert.ToString(dr["Fun_UDef4"]);
            if (dr["Fun_UDef5"] != DBNull.Value) sys_Function.Fun_UDef5 = Convert.ToString(dr["Fun_UDef5"]);
            if (dr["Fun_UDef6"] != DBNull.Value) sys_Function.Fun_UDef6 = Convert.ToString(dr["Fun_UDef6"]);
            if (dr["Fun_Stat"] != DBNull.Value) sys_Function.Fun_Stat = Convert.ToString(dr["Fun_Stat"]);
            if (dr["Stat"] != DBNull.Value) sys_Function.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sys_Function.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sys_Function.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sys_Function.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sys_Function);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
