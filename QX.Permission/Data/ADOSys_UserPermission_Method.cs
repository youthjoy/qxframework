using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Permission.Model;
using QX.DataAcess;

namespace QX.Permission.DAL
{
   [Serializable]
   public partial class ADOSys_UserPermission_Method
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_UserPermission_Method对象(即:一条记录)
      /// </summary>
      public int Add(Sys_UserPermission_Method sys_UserPermission_Method)
      {
         string sql = "INSERT INTO Sys_UserPermission_Method (FP_Code,FP_FunCode,FP_Method,FP_Udef1,FP_Udef2,FP_Udef3,Stat) VALUES (@FP_Code,@FP_FunCode,@FP_Method,@FP_Udef1,@FP_Udef2,@FP_Udef3,@Stat)";
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Code))
         {
            idb.AddParameter("@FP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Code", sys_UserPermission_Method.FP_Code);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_FunCode))
         {
            idb.AddParameter("@FP_FunCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_FunCode", sys_UserPermission_Method.FP_FunCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Method))
         {
            idb.AddParameter("@FP_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Method", sys_UserPermission_Method.FP_Method);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef1))
         {
            idb.AddParameter("@FP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef1", sys_UserPermission_Method.FP_Udef1);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef2))
         {
            idb.AddParameter("@FP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef2", sys_UserPermission_Method.FP_Udef2);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef3))
         {
            idb.AddParameter("@FP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef3", sys_UserPermission_Method.FP_Udef3);
         }
         if (sys_UserPermission_Method.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_UserPermission_Method.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_UserPermission_Method对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_UserPermission_Method sys_UserPermission_Method)
      {
         string sql = "INSERT INTO Sys_UserPermission_Method (FP_Code,FP_FunCode,FP_Method,FP_Udef1,FP_Udef2,FP_Udef3,Stat) VALUES (@FP_Code,@FP_FunCode,@FP_Method,@FP_Udef1,@FP_Udef2,@FP_Udef3,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Code))
         {
            idb.AddParameter("@FP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Code", sys_UserPermission_Method.FP_Code);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_FunCode))
         {
            idb.AddParameter("@FP_FunCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_FunCode", sys_UserPermission_Method.FP_FunCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Method))
         {
            idb.AddParameter("@FP_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Method", sys_UserPermission_Method.FP_Method);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef1))
         {
            idb.AddParameter("@FP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef1", sys_UserPermission_Method.FP_Udef1);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef2))
         {
            idb.AddParameter("@FP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef2", sys_UserPermission_Method.FP_Udef2);
         }
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef3))
         {
            idb.AddParameter("@FP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef3", sys_UserPermission_Method.FP_Udef3);
         }
         if (sys_UserPermission_Method.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_UserPermission_Method.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_UserPermission_Method对象(即:一条记录
      /// </summary>
      public int Update(Sys_UserPermission_Method sys_UserPermission_Method)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_UserPermission_Method       SET ");
            if(sys_UserPermission_Method.FP_Code_IsChanged){sbParameter.Append("FP_Code=@FP_Code, ");}
      if(sys_UserPermission_Method.FP_FunCode_IsChanged){sbParameter.Append("FP_FunCode=@FP_FunCode, ");}
      if(sys_UserPermission_Method.FP_Method_IsChanged){sbParameter.Append("FP_Method=@FP_Method, ");}
      if(sys_UserPermission_Method.FP_Udef1_IsChanged){sbParameter.Append("FP_Udef1=@FP_Udef1, ");}
      if(sys_UserPermission_Method.FP_Udef2_IsChanged){sbParameter.Append("FP_Udef2=@FP_Udef2, ");}
      if(sys_UserPermission_Method.FP_Udef3_IsChanged){sbParameter.Append("FP_Udef3=@FP_Udef3, ");}
      if(sys_UserPermission_Method.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FP_ID=@FP_ID; " );
      string sql=sb.ToString();
         if(sys_UserPermission_Method.FP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Code))
         {
            idb.AddParameter("@FP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Code", sys_UserPermission_Method.FP_Code);
         }
          }
         if(sys_UserPermission_Method.FP_FunCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_FunCode))
         {
            idb.AddParameter("@FP_FunCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_FunCode", sys_UserPermission_Method.FP_FunCode);
         }
          }
         if(sys_UserPermission_Method.FP_Method_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Method))
         {
            idb.AddParameter("@FP_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Method", sys_UserPermission_Method.FP_Method);
         }
          }
         if(sys_UserPermission_Method.FP_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef1))
         {
            idb.AddParameter("@FP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef1", sys_UserPermission_Method.FP_Udef1);
         }
          }
         if(sys_UserPermission_Method.FP_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef2))
         {
            idb.AddParameter("@FP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef2", sys_UserPermission_Method.FP_Udef2);
         }
          }
         if(sys_UserPermission_Method.FP_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission_Method.FP_Udef3))
         {
            idb.AddParameter("@FP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Udef3", sys_UserPermission_Method.FP_Udef3);
         }
          }
         if(sys_UserPermission_Method.Stat_IsChanged)
         {
         if (sys_UserPermission_Method.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_UserPermission_Method.Stat);
         }
          }

         idb.AddParameter("@FP_ID", sys_UserPermission_Method.FP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_UserPermission_Method对象(即:一条记录
      /// </summary>
      public int Delete(decimal fP_ID)
      {
         string sql = "DELETE Sys_UserPermission_Method WHERE 1=1  AND FP_ID=@FP_ID ";
         idb.AddParameter("@FP_ID", fP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_UserPermission_Method对象(即:一条记录
      /// </summary>
      public Sys_UserPermission_Method GetByKey(decimal fP_ID)
      {
         Sys_UserPermission_Method sys_UserPermission_Method = new Sys_UserPermission_Method();
         string sql = "SELECT  FP_ID,FP_Code,FP_FunCode,FP_Method,FP_Udef1,FP_Udef2,FP_Udef3,Stat FROM Sys_UserPermission_Method WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FP_ID=@FP_ID ";
         idb.AddParameter("@FP_ID", fP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FP_ID"] != DBNull.Value) sys_UserPermission_Method.FP_ID = Convert.ToDecimal(dr["FP_ID"]);
            if (dr["FP_Code"] != DBNull.Value) sys_UserPermission_Method.FP_Code = Convert.ToString(dr["FP_Code"]);
            if (dr["FP_FunCode"] != DBNull.Value) sys_UserPermission_Method.FP_FunCode = Convert.ToString(dr["FP_FunCode"]);
            if (dr["FP_Method"] != DBNull.Value) sys_UserPermission_Method.FP_Method = Convert.ToString(dr["FP_Method"]);
            if (dr["FP_Udef1"] != DBNull.Value) sys_UserPermission_Method.FP_Udef1 = Convert.ToString(dr["FP_Udef1"]);
            if (dr["FP_Udef2"] != DBNull.Value) sys_UserPermission_Method.FP_Udef2 = Convert.ToString(dr["FP_Udef2"]);
            if (dr["FP_Udef3"] != DBNull.Value) sys_UserPermission_Method.FP_Udef3 = Convert.ToString(dr["FP_Udef3"]);
            if (dr["Stat"] != DBNull.Value) sys_UserPermission_Method.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_UserPermission_Method;
      }
      /// <summary>
      /// 获取指定的Sys_UserPermission_Method对象集合
      /// </summary>
      public List<Sys_UserPermission_Method> GetListByWhere(string strCondition)
      {
         List<Sys_UserPermission_Method> ret = new List<Sys_UserPermission_Method>();
         string sql = "SELECT  FP_ID,FP_Code,FP_FunCode,FP_Method,FP_Udef1,FP_Udef2,FP_Udef3,Stat FROM Sys_UserPermission_Method WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY FP_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_UserPermission_Method sys_UserPermission_Method = new Sys_UserPermission_Method();
            if (dr["FP_ID"] != DBNull.Value) sys_UserPermission_Method.FP_ID = Convert.ToDecimal(dr["FP_ID"]);
            if (dr["FP_Code"] != DBNull.Value) sys_UserPermission_Method.FP_Code = Convert.ToString(dr["FP_Code"]);
            if (dr["FP_FunCode"] != DBNull.Value) sys_UserPermission_Method.FP_FunCode = Convert.ToString(dr["FP_FunCode"]);
            if (dr["FP_Method"] != DBNull.Value) sys_UserPermission_Method.FP_Method = Convert.ToString(dr["FP_Method"]);
            if (dr["FP_Udef1"] != DBNull.Value) sys_UserPermission_Method.FP_Udef1 = Convert.ToString(dr["FP_Udef1"]);
            if (dr["FP_Udef2"] != DBNull.Value) sys_UserPermission_Method.FP_Udef2 = Convert.ToString(dr["FP_Udef2"]);
            if (dr["FP_Udef3"] != DBNull.Value) sys_UserPermission_Method.FP_Udef3 = Convert.ToString(dr["FP_Udef3"]);
            if (dr["Stat"] != DBNull.Value) sys_UserPermission_Method.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_UserPermission_Method);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_UserPermission_Method对象(即:一条记录
      /// </summary>
      public List<Sys_UserPermission_Method> GetAll()
      {
         List<Sys_UserPermission_Method> ret = new List<Sys_UserPermission_Method>();
         string sql = "SELECT  FP_ID,FP_Code,FP_FunCode,FP_Method,FP_Udef1,FP_Udef2,FP_Udef3,Stat FROM Sys_UserPermission_Method where 1=1 AND ((Stat is null) or (Stat=0) ) order by FP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_UserPermission_Method sys_UserPermission_Method = new Sys_UserPermission_Method();
            if (dr["FP_ID"] != DBNull.Value) sys_UserPermission_Method.FP_ID = Convert.ToDecimal(dr["FP_ID"]);
            if (dr["FP_Code"] != DBNull.Value) sys_UserPermission_Method.FP_Code = Convert.ToString(dr["FP_Code"]);
            if (dr["FP_FunCode"] != DBNull.Value) sys_UserPermission_Method.FP_FunCode = Convert.ToString(dr["FP_FunCode"]);
            if (dr["FP_Method"] != DBNull.Value) sys_UserPermission_Method.FP_Method = Convert.ToString(dr["FP_Method"]);
            if (dr["FP_Udef1"] != DBNull.Value) sys_UserPermission_Method.FP_Udef1 = Convert.ToString(dr["FP_Udef1"]);
            if (dr["FP_Udef2"] != DBNull.Value) sys_UserPermission_Method.FP_Udef2 = Convert.ToString(dr["FP_Udef2"]);
            if (dr["FP_Udef3"] != DBNull.Value) sys_UserPermission_Method.FP_Udef3 = Convert.ToString(dr["FP_Udef3"]);
            if (dr["Stat"] != DBNull.Value) sys_UserPermission_Method.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_UserPermission_Method);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
