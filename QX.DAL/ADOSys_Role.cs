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
   public partial class ADOSys_Role
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_Role对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Role sys_Role)
      {
         string sql = "INSERT INTO Sys_Role (SRole_Code,SRole_Name,SRole_Type,SRole_iType,SRole_Stat,SRole_UCode,Stat) VALUES (@SRole_Code,@SRole_Name,@SRole_Type,@SRole_iType,@SRole_Stat,@SRole_UCode,@Stat)";
         if (string.IsNullOrEmpty(sys_Role.SRole_Code))
         {
            idb.AddParameter("@SRole_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Code", sys_Role.SRole_Code);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_Name))
         {
            idb.AddParameter("@SRole_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Name", sys_Role.SRole_Name);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_Type))
         {
            idb.AddParameter("@SRole_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Type", sys_Role.SRole_Type);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_iType))
         {
            idb.AddParameter("@SRole_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_iType", sys_Role.SRole_iType);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_Stat))
         {
            idb.AddParameter("@SRole_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Stat", sys_Role.SRole_Stat);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_UCode))
         {
            idb.AddParameter("@SRole_UCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_UCode", sys_Role.SRole_UCode);
         }
         if (sys_Role.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Role.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_Role对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Role sys_Role)
      {
         string sql = "INSERT INTO Sys_Role (SRole_Code,SRole_Name,SRole_Type,SRole_iType,SRole_Stat,SRole_UCode,Stat) VALUES (@SRole_Code,@SRole_Name,@SRole_Type,@SRole_iType,@SRole_Stat,@SRole_UCode,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Role.SRole_Code))
         {
            idb.AddParameter("@SRole_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Code", sys_Role.SRole_Code);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_Name))
         {
            idb.AddParameter("@SRole_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Name", sys_Role.SRole_Name);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_Type))
         {
            idb.AddParameter("@SRole_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Type", sys_Role.SRole_Type);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_iType))
         {
            idb.AddParameter("@SRole_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_iType", sys_Role.SRole_iType);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_Stat))
         {
            idb.AddParameter("@SRole_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Stat", sys_Role.SRole_Stat);
         }
         if (string.IsNullOrEmpty(sys_Role.SRole_UCode))
         {
            idb.AddParameter("@SRole_UCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_UCode", sys_Role.SRole_UCode);
         }
         if (sys_Role.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Role.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_Role对象(即:一条记录
      /// </summary>
      public int Update(Sys_Role sys_Role)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Role       SET ");
            if(sys_Role.SRole_Code_IsChanged){sbParameter.Append("SRole_Code=@SRole_Code, ");}
      if(sys_Role.SRole_Name_IsChanged){sbParameter.Append("SRole_Name=@SRole_Name, ");}
      if(sys_Role.SRole_Type_IsChanged){sbParameter.Append("SRole_Type=@SRole_Type, ");}
      if(sys_Role.SRole_iType_IsChanged){sbParameter.Append("SRole_iType=@SRole_iType, ");}
      if(sys_Role.SRole_Stat_IsChanged){sbParameter.Append("SRole_Stat=@SRole_Stat, ");}
      if(sys_Role.SRole_UCode_IsChanged){sbParameter.Append("SRole_UCode=@SRole_UCode, ");}
      if(sys_Role.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SRole_ID=@SRole_ID; " );
      string sql=sb.ToString();
         if(sys_Role.SRole_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Role.SRole_Code))
         {
            idb.AddParameter("@SRole_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Code", sys_Role.SRole_Code);
         }
          }
         if(sys_Role.SRole_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Role.SRole_Name))
         {
            idb.AddParameter("@SRole_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Name", sys_Role.SRole_Name);
         }
          }
         if(sys_Role.SRole_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Role.SRole_Type))
         {
            idb.AddParameter("@SRole_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Type", sys_Role.SRole_Type);
         }
          }
         if(sys_Role.SRole_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Role.SRole_iType))
         {
            idb.AddParameter("@SRole_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_iType", sys_Role.SRole_iType);
         }
          }
         if(sys_Role.SRole_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Role.SRole_Stat))
         {
            idb.AddParameter("@SRole_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_Stat", sys_Role.SRole_Stat);
         }
          }
         if(sys_Role.SRole_UCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Role.SRole_UCode))
         {
            idb.AddParameter("@SRole_UCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SRole_UCode", sys_Role.SRole_UCode);
         }
          }
         if(sys_Role.Stat_IsChanged)
         {
         if (sys_Role.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Role.Stat);
         }
          }

         idb.AddParameter("@SRole_ID", sys_Role.SRole_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_Role对象(即:一条记录
      /// </summary>
      public int Delete(decimal sRole_ID)
      {
         string sql = "DELETE Sys_Role WHERE 1=1  AND SRole_ID=@SRole_ID ";
         idb.AddParameter("@SRole_ID", sRole_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_Role对象(即:一条记录
      /// </summary>
      public Sys_Role GetByKey(decimal sRole_ID)
      {
         Sys_Role sys_Role = new Sys_Role();
         string sql = "SELECT  SRole_ID,SRole_Code,SRole_Name,SRole_Type,SRole_iType,SRole_Stat,SRole_UCode,Stat FROM Sys_Role WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SRole_ID=@SRole_ID ";
         idb.AddParameter("@SRole_ID", sRole_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SRole_ID"] != DBNull.Value) sys_Role.SRole_ID = Convert.ToDecimal(dr["SRole_ID"]);
            if (dr["SRole_Code"] != DBNull.Value) sys_Role.SRole_Code = Convert.ToString(dr["SRole_Code"]);
            if (dr["SRole_Name"] != DBNull.Value) sys_Role.SRole_Name = Convert.ToString(dr["SRole_Name"]);
            if (dr["SRole_Type"] != DBNull.Value) sys_Role.SRole_Type = Convert.ToString(dr["SRole_Type"]);
            if (dr["SRole_iType"] != DBNull.Value) sys_Role.SRole_iType = Convert.ToString(dr["SRole_iType"]);
            if (dr["SRole_Stat"] != DBNull.Value) sys_Role.SRole_Stat = Convert.ToString(dr["SRole_Stat"]);
            if (dr["SRole_UCode"] != DBNull.Value) sys_Role.SRole_UCode = Convert.ToString(dr["SRole_UCode"]);
            if (dr["Stat"] != DBNull.Value) sys_Role.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Role;
      }
      /// <summary>
      /// 获取指定的Sys_Role对象集合
      /// </summary>
      public List<Sys_Role> GetListByWhere(string strCondition)
      {
         List<Sys_Role> ret = new List<Sys_Role>();
         string sql = "SELECT  SRole_ID,SRole_Code,SRole_Name,SRole_Type,SRole_iType,SRole_Stat,SRole_UCode,Stat FROM Sys_Role WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Role sys_Role = new Sys_Role();
            if (dr["SRole_ID"] != DBNull.Value) sys_Role.SRole_ID = Convert.ToDecimal(dr["SRole_ID"]);
            if (dr["SRole_Code"] != DBNull.Value) sys_Role.SRole_Code = Convert.ToString(dr["SRole_Code"]);
            if (dr["SRole_Name"] != DBNull.Value) sys_Role.SRole_Name = Convert.ToString(dr["SRole_Name"]);
            if (dr["SRole_Type"] != DBNull.Value) sys_Role.SRole_Type = Convert.ToString(dr["SRole_Type"]);
            if (dr["SRole_iType"] != DBNull.Value) sys_Role.SRole_iType = Convert.ToString(dr["SRole_iType"]);
            if (dr["SRole_Stat"] != DBNull.Value) sys_Role.SRole_Stat = Convert.ToString(dr["SRole_Stat"]);
            if (dr["SRole_UCode"] != DBNull.Value) sys_Role.SRole_UCode = Convert.ToString(dr["SRole_UCode"]);
            if (dr["Stat"] != DBNull.Value) sys_Role.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Role);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_Role对象(即:一条记录
      /// </summary>
      public List<Sys_Role> GetAll()
      {
         List<Sys_Role> ret = new List<Sys_Role>();
         string sql = "SELECT  SRole_ID,SRole_Code,SRole_Name,SRole_Type,SRole_iType,SRole_Stat,SRole_UCode,Stat FROM Sys_Role where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Role sys_Role = new Sys_Role();
            if (dr["SRole_ID"] != DBNull.Value) sys_Role.SRole_ID = Convert.ToDecimal(dr["SRole_ID"]);
            if (dr["SRole_Code"] != DBNull.Value) sys_Role.SRole_Code = Convert.ToString(dr["SRole_Code"]);
            if (dr["SRole_Name"] != DBNull.Value) sys_Role.SRole_Name = Convert.ToString(dr["SRole_Name"]);
            if (dr["SRole_Type"] != DBNull.Value) sys_Role.SRole_Type = Convert.ToString(dr["SRole_Type"]);
            if (dr["SRole_iType"] != DBNull.Value) sys_Role.SRole_iType = Convert.ToString(dr["SRole_iType"]);
            if (dr["SRole_Stat"] != DBNull.Value) sys_Role.SRole_Stat = Convert.ToString(dr["SRole_Stat"]);
            if (dr["SRole_UCode"] != DBNull.Value) sys_Role.SRole_UCode = Convert.ToString(dr["SRole_UCode"]);
            if (dr["Stat"] != DBNull.Value) sys_Role.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Role);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
