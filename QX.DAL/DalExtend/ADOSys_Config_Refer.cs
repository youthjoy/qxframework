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
   /// 通用参考主表
   /// </summary>
   [Serializable]
   public partial class ADOSys_Config_Refer
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加通用参考主表 Sys_Config_Refer对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Config_Refer sys_Config_Refer)
      {
         string sql = "INSERT INTO Sys_Config_Refer (R_ModuleName,R_NameSpace,R_Title,R_Width,R_Height,Stat,R_TableName,R_FilterSql,R_SQL) VALUES (@R_ModuleName,@R_NameSpace,@R_Title,@R_Width,@R_Height,@Stat,@R_TableName,@R_FilterSql,@R_SQL)";
         if (string.IsNullOrEmpty(sys_Config_Refer.R_ModuleName))
         {
            idb.AddParameter("@R_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_ModuleName", sys_Config_Refer.R_ModuleName);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_NameSpace))
         {
            idb.AddParameter("@R_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_NameSpace", sys_Config_Refer.R_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_Title))
         {
            idb.AddParameter("@R_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_Title", sys_Config_Refer.R_Title);
         }
         if (sys_Config_Refer.R_Width == 0)
         {
            idb.AddParameter("@R_Width", 0);
         }
         else
         {
            idb.AddParameter("@R_Width", sys_Config_Refer.R_Width);
         }
         if (sys_Config_Refer.R_Height == 0)
         {
            idb.AddParameter("@R_Height", 0);
         }
         else
         {
            idb.AddParameter("@R_Height", sys_Config_Refer.R_Height);
         }
         if (sys_Config_Refer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Refer.Stat);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_TableName))
         {
            idb.AddParameter("@R_TableName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_TableName", sys_Config_Refer.R_TableName);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_FilterSql))
         {
            idb.AddParameter("@R_FilterSql", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_FilterSql", sys_Config_Refer.R_FilterSql);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_SQL))
         {
            idb.AddParameter("@R_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_SQL", sys_Config_Refer.R_SQL);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加通用参考主表 Sys_Config_Refer对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Config_Refer sys_Config_Refer)
      {
         string sql = "INSERT INTO Sys_Config_Refer (R_ModuleName,R_NameSpace,R_Title,R_Width,R_Height,Stat,R_TableName,R_FilterSql,R_SQL) VALUES (@R_ModuleName,@R_NameSpace,@R_Title,@R_Width,@R_Height,@Stat,@R_TableName,@R_FilterSql,@R_SQL);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Config_Refer.R_ModuleName))
         {
            idb.AddParameter("@R_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_ModuleName", sys_Config_Refer.R_ModuleName);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_NameSpace))
         {
            idb.AddParameter("@R_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_NameSpace", sys_Config_Refer.R_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_Title))
         {
            idb.AddParameter("@R_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_Title", sys_Config_Refer.R_Title);
         }
         if (sys_Config_Refer.R_Width == 0)
         {
            idb.AddParameter("@R_Width", 0);
         }
         else
         {
            idb.AddParameter("@R_Width", sys_Config_Refer.R_Width);
         }
         if (sys_Config_Refer.R_Height == 0)
         {
            idb.AddParameter("@R_Height", 0);
         }
         else
         {
            idb.AddParameter("@R_Height", sys_Config_Refer.R_Height);
         }
         if (sys_Config_Refer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Refer.Stat);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_TableName))
         {
            idb.AddParameter("@R_TableName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_TableName", sys_Config_Refer.R_TableName);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_FilterSql))
         {
            idb.AddParameter("@R_FilterSql", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_FilterSql", sys_Config_Refer.R_FilterSql);
         }
         if (string.IsNullOrEmpty(sys_Config_Refer.R_SQL))
         {
            idb.AddParameter("@R_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_SQL", sys_Config_Refer.R_SQL);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新通用参考主表 Sys_Config_Refer对象(即:一条记录
      /// </summary>
      public int Update(Sys_Config_Refer sys_Config_Refer)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Config_Refer       SET ");
            if(sys_Config_Refer.R_ModuleName_IsChanged){sbParameter.Append("R_ModuleName=@R_ModuleName, ");}
      if(sys_Config_Refer.R_NameSpace_IsChanged){sbParameter.Append("R_NameSpace=@R_NameSpace, ");}
      if(sys_Config_Refer.R_Title_IsChanged){sbParameter.Append("R_Title=@R_Title, ");}
      if(sys_Config_Refer.R_Width_IsChanged){sbParameter.Append("R_Width=@R_Width, ");}
      if(sys_Config_Refer.R_Height_IsChanged){sbParameter.Append("R_Height=@R_Height, ");}
      if(sys_Config_Refer.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_Config_Refer.R_TableName_IsChanged){sbParameter.Append("R_TableName=@R_TableName, ");}
      if(sys_Config_Refer.R_FilterSql_IsChanged){sbParameter.Append("R_FilterSql=@R_FilterSql, ");}
      if(sys_Config_Refer.R_SQL_IsChanged){sbParameter.Append("R_SQL=@R_SQL ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and R_ID=@R_ID; " );
      string sql=sb.ToString();
         if(sys_Config_Refer.R_ModuleName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Refer.R_ModuleName))
         {
            idb.AddParameter("@R_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_ModuleName", sys_Config_Refer.R_ModuleName);
         }
          }
         if(sys_Config_Refer.R_NameSpace_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Refer.R_NameSpace))
         {
            idb.AddParameter("@R_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_NameSpace", sys_Config_Refer.R_NameSpace);
         }
          }
         if(sys_Config_Refer.R_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Refer.R_Title))
         {
            idb.AddParameter("@R_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_Title", sys_Config_Refer.R_Title);
         }
          }
         if(sys_Config_Refer.R_Width_IsChanged)
         {
         if (sys_Config_Refer.R_Width == 0)
         {
            idb.AddParameter("@R_Width", 0);
         }
         else
         {
            idb.AddParameter("@R_Width", sys_Config_Refer.R_Width);
         }
          }
         if(sys_Config_Refer.R_Height_IsChanged)
         {
         if (sys_Config_Refer.R_Height == 0)
         {
            idb.AddParameter("@R_Height", 0);
         }
         else
         {
            idb.AddParameter("@R_Height", sys_Config_Refer.R_Height);
         }
          }
         if(sys_Config_Refer.Stat_IsChanged)
         {
         if (sys_Config_Refer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Refer.Stat);
         }
          }
         if(sys_Config_Refer.R_TableName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Refer.R_TableName))
         {
            idb.AddParameter("@R_TableName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_TableName", sys_Config_Refer.R_TableName);
         }
          }
         if(sys_Config_Refer.R_FilterSql_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Refer.R_FilterSql))
         {
            idb.AddParameter("@R_FilterSql", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_FilterSql", sys_Config_Refer.R_FilterSql);
         }
          }
         if(sys_Config_Refer.R_SQL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Refer.R_SQL))
         {
            idb.AddParameter("@R_SQL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@R_SQL", sys_Config_Refer.R_SQL);
         }
          }

         idb.AddParameter("@R_ID", sys_Config_Refer.R_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除通用参考主表 Sys_Config_Refer对象(即:一条记录
      /// </summary>
      public int Delete(decimal r_ID)
      {
         string sql = "DELETE Sys_Config_Refer WHERE 1=1  AND R_ID=@R_ID ";
         idb.AddParameter("@R_ID", r_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的通用参考主表 Sys_Config_Refer对象(即:一条记录
      /// </summary>
      public Sys_Config_Refer GetByKey(decimal r_ID)
      {
         Sys_Config_Refer sys_Config_Refer = new Sys_Config_Refer();
         string sql = "SELECT  R_ID,R_ModuleName,R_NameSpace,R_Title,R_Width,R_Height,Stat,R_TableName,R_FilterSql,R_SQL FROM Sys_Config_Refer WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND R_ID=@R_ID ";
         idb.AddParameter("@R_ID", r_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["R_ID"] != DBNull.Value) sys_Config_Refer.R_ID = Convert.ToDecimal(dr["R_ID"]);
            if (dr["R_ModuleName"] != DBNull.Value) sys_Config_Refer.R_ModuleName = Convert.ToString(dr["R_ModuleName"]);
            if (dr["R_NameSpace"] != DBNull.Value) sys_Config_Refer.R_NameSpace = Convert.ToString(dr["R_NameSpace"]);
            if (dr["R_Title"] != DBNull.Value) sys_Config_Refer.R_Title = Convert.ToString(dr["R_Title"]);
            if (dr["R_Width"] != DBNull.Value) sys_Config_Refer.R_Width = Convert.ToInt32(dr["R_Width"]);
            if (dr["R_Height"] != DBNull.Value) sys_Config_Refer.R_Height = Convert.ToInt32(dr["R_Height"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Refer.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["R_TableName"] != DBNull.Value) sys_Config_Refer.R_TableName = Convert.ToString(dr["R_TableName"]);
            if (dr["R_FilterSql"] != DBNull.Value) sys_Config_Refer.R_FilterSql = Convert.ToString(dr["R_FilterSql"]);
            if (dr["R_SQL"] != DBNull.Value) sys_Config_Refer.R_SQL = Convert.ToString(dr["R_SQL"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Config_Refer;
      }
      /// <summary>
      /// 获取指定的通用参考主表 Sys_Config_Refer对象集合
      /// </summary>
      public List<Sys_Config_Refer> GetListByWhere(string strCondition)
      {
         List<Sys_Config_Refer> ret = new List<Sys_Config_Refer>();
         string sql = "SELECT  R_ID,R_ModuleName,R_NameSpace,R_Title,R_Width,R_Height,Stat,R_TableName,R_FilterSql,R_SQL FROM Sys_Config_Refer WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Config_Refer sys_Config_Refer = new Sys_Config_Refer();
            if (dr["R_ID"] != DBNull.Value) sys_Config_Refer.R_ID = Convert.ToDecimal(dr["R_ID"]);
            if (dr["R_ModuleName"] != DBNull.Value) sys_Config_Refer.R_ModuleName = Convert.ToString(dr["R_ModuleName"]);
            if (dr["R_NameSpace"] != DBNull.Value) sys_Config_Refer.R_NameSpace = Convert.ToString(dr["R_NameSpace"]);
            if (dr["R_Title"] != DBNull.Value) sys_Config_Refer.R_Title = Convert.ToString(dr["R_Title"]);
            if (dr["R_Width"] != DBNull.Value) sys_Config_Refer.R_Width = Convert.ToInt32(dr["R_Width"]);
            if (dr["R_Height"] != DBNull.Value) sys_Config_Refer.R_Height = Convert.ToInt32(dr["R_Height"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Refer.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["R_TableName"] != DBNull.Value) sys_Config_Refer.R_TableName = Convert.ToString(dr["R_TableName"]);
            if (dr["R_FilterSql"] != DBNull.Value) sys_Config_Refer.R_FilterSql = Convert.ToString(dr["R_FilterSql"]);
            if (dr["R_SQL"] != DBNull.Value) sys_Config_Refer.R_SQL = Convert.ToString(dr["R_SQL"]);
            ret.Add(sys_Config_Refer);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的通用参考主表 Sys_Config_Refer对象(即:一条记录
      /// </summary>
      public List<Sys_Config_Refer> GetAll()
      {
         List<Sys_Config_Refer> ret = new List<Sys_Config_Refer>();
         string sql = "SELECT  R_ID,R_ModuleName,R_NameSpace,R_Title,R_Width,R_Height,Stat,R_TableName,R_FilterSql,R_SQL FROM Sys_Config_Refer where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_Refer sys_Config_Refer = new Sys_Config_Refer();
            if (dr["R_ID"] != DBNull.Value) sys_Config_Refer.R_ID = Convert.ToDecimal(dr["R_ID"]);
            if (dr["R_ModuleName"] != DBNull.Value) sys_Config_Refer.R_ModuleName = Convert.ToString(dr["R_ModuleName"]);
            if (dr["R_NameSpace"] != DBNull.Value) sys_Config_Refer.R_NameSpace = Convert.ToString(dr["R_NameSpace"]);
            if (dr["R_Title"] != DBNull.Value) sys_Config_Refer.R_Title = Convert.ToString(dr["R_Title"]);
            if (dr["R_Width"] != DBNull.Value) sys_Config_Refer.R_Width = Convert.ToInt32(dr["R_Width"]);
            if (dr["R_Height"] != DBNull.Value) sys_Config_Refer.R_Height = Convert.ToInt32(dr["R_Height"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Refer.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["R_TableName"] != DBNull.Value) sys_Config_Refer.R_TableName = Convert.ToString(dr["R_TableName"]);
            if (dr["R_FilterSql"] != DBNull.Value) sys_Config_Refer.R_FilterSql = Convert.ToString(dr["R_FilterSql"]);
            if (dr["R_SQL"] != DBNull.Value) sys_Config_Refer.R_SQL = Convert.ToString(dr["R_SQL"]);
            ret.Add(sys_Config_Refer);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
