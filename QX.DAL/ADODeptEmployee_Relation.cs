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
   public partial class ADODeptEmployee_Relation
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加DeptEmployee_Relation对象(即:一条记录)
      /// </summary>
      public int Add(DeptEmployee_Relation deptEmployee_Relation)
      {
         string sql = "INSERT INTO DeptEmployee_Relation (DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat) VALUES (@DE_Dept_Code,@DE_Empoyee_Code,@DE_Type,@Stat)";
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Dept_Code))
         {
            idb.AddParameter("@DE_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Dept_Code", deptEmployee_Relation.DE_Dept_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Empoyee_Code))
         {
            idb.AddParameter("@DE_Empoyee_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Empoyee_Code", deptEmployee_Relation.DE_Empoyee_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Type))
         {
            idb.AddParameter("@DE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Type", deptEmployee_Relation.DE_Type);
         }
         if (deptEmployee_Relation.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", deptEmployee_Relation.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加DeptEmployee_Relation对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(DeptEmployee_Relation deptEmployee_Relation)
      {
         string sql = "INSERT INTO DeptEmployee_Relation (DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat) VALUES (@DE_Dept_Code,@DE_Empoyee_Code,@DE_Type,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Dept_Code))
         {
            idb.AddParameter("@DE_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Dept_Code", deptEmployee_Relation.DE_Dept_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Empoyee_Code))
         {
            idb.AddParameter("@DE_Empoyee_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Empoyee_Code", deptEmployee_Relation.DE_Empoyee_Code);
         }
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Type))
         {
            idb.AddParameter("@DE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Type", deptEmployee_Relation.DE_Type);
         }
         if (deptEmployee_Relation.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", deptEmployee_Relation.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 更新DeptEmployee_Relation对象(即:一条记录
      /// </summary>
      public int Update(DeptEmployee_Relation deptEmployee_Relation)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       DeptEmployee_Relation       SET ");
            if(deptEmployee_Relation.DE_Dept_Code_IsChanged){sbParameter.Append("DE_Dept_Code=@DE_Dept_Code, ");}
      if(deptEmployee_Relation.DE_Empoyee_Code_IsChanged){sbParameter.Append("DE_Empoyee_Code=@DE_Empoyee_Code, ");}
      if(deptEmployee_Relation.DE_Type_IsChanged){sbParameter.Append("DE_Type=@DE_Type, ");}
      if(deptEmployee_Relation.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DE_ID=@DE_ID; " );
      string sql=sb.ToString();
         if(deptEmployee_Relation.DE_Dept_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Dept_Code))
         {
            idb.AddParameter("@DE_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Dept_Code", deptEmployee_Relation.DE_Dept_Code);
         }
          }
         if(deptEmployee_Relation.DE_Empoyee_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Empoyee_Code))
         {
            idb.AddParameter("@DE_Empoyee_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Empoyee_Code", deptEmployee_Relation.DE_Empoyee_Code);
         }
          }
         if(deptEmployee_Relation.DE_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(deptEmployee_Relation.DE_Type))
         {
            idb.AddParameter("@DE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DE_Type", deptEmployee_Relation.DE_Type);
         }
          }
         if(deptEmployee_Relation.Stat_IsChanged)
         {
         if (deptEmployee_Relation.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", deptEmployee_Relation.Stat);
         }
          }

         idb.AddParameter("@DE_ID", deptEmployee_Relation.DE_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除DeptEmployee_Relation对象(即:一条记录
      /// </summary>
      public int Delete(int dE_ID)
      {
         string sql = "DELETE DeptEmployee_Relation WHERE 1=1  AND DE_ID=@DE_ID ";
         idb.AddParameter("@DE_ID", dE_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的DeptEmployee_Relation对象(即:一条记录
      /// </summary>
      public DeptEmployee_Relation GetByKey(int dE_ID)
      {
         DeptEmployee_Relation deptEmployee_Relation = new DeptEmployee_Relation();
         string sql = "SELECT  DE_ID,DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat FROM DeptEmployee_Relation WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DE_ID=@DE_ID ";
         idb.AddParameter("@DE_ID", dE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DE_ID"] != DBNull.Value) deptEmployee_Relation.DE_ID = Convert.ToInt32(dr["DE_ID"]);
            if (dr["DE_Dept_Code"] != DBNull.Value) deptEmployee_Relation.DE_Dept_Code = Convert.ToString(dr["DE_Dept_Code"]);
            if (dr["DE_Empoyee_Code"] != DBNull.Value) deptEmployee_Relation.DE_Empoyee_Code = Convert.ToString(dr["DE_Empoyee_Code"]);
            if (dr["DE_Type"] != DBNull.Value) deptEmployee_Relation.DE_Type = Convert.ToString(dr["DE_Type"]);
            if (dr["Stat"] != DBNull.Value) deptEmployee_Relation.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return deptEmployee_Relation;
      }
      /// <summary>
      /// 获取指定的DeptEmployee_Relation对象集合
      /// </summary>
      public List<DeptEmployee_Relation> GetListByWhere(string strCondition)
      {
         List<DeptEmployee_Relation> ret = new List<DeptEmployee_Relation>();
         string sql = "SELECT  DE_ID,DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat FROM DeptEmployee_Relation WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            DeptEmployee_Relation deptEmployee_Relation = new DeptEmployee_Relation();
            if (dr["DE_ID"] != DBNull.Value) deptEmployee_Relation.DE_ID = Convert.ToInt32(dr["DE_ID"]);
            if (dr["DE_Dept_Code"] != DBNull.Value) deptEmployee_Relation.DE_Dept_Code = Convert.ToString(dr["DE_Dept_Code"]);
            if (dr["DE_Empoyee_Code"] != DBNull.Value) deptEmployee_Relation.DE_Empoyee_Code = Convert.ToString(dr["DE_Empoyee_Code"]);
            if (dr["DE_Type"] != DBNull.Value) deptEmployee_Relation.DE_Type = Convert.ToString(dr["DE_Type"]);
            if (dr["Stat"] != DBNull.Value) deptEmployee_Relation.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(deptEmployee_Relation);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的DeptEmployee_Relation对象(即:一条记录
      /// </summary>
      public List<DeptEmployee_Relation> GetAll()
      {
         List<DeptEmployee_Relation> ret = new List<DeptEmployee_Relation>();
         string sql = "SELECT  DE_ID,DE_Dept_Code,DE_Empoyee_Code,DE_Type,Stat FROM DeptEmployee_Relation where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            DeptEmployee_Relation deptEmployee_Relation = new DeptEmployee_Relation();
            if (dr["DE_ID"] != DBNull.Value) deptEmployee_Relation.DE_ID = Convert.ToInt32(dr["DE_ID"]);
            if (dr["DE_Dept_Code"] != DBNull.Value) deptEmployee_Relation.DE_Dept_Code = Convert.ToString(dr["DE_Dept_Code"]);
            if (dr["DE_Empoyee_Code"] != DBNull.Value) deptEmployee_Relation.DE_Empoyee_Code = Convert.ToString(dr["DE_Empoyee_Code"]);
            if (dr["DE_Type"] != DBNull.Value) deptEmployee_Relation.DE_Type = Convert.ToString(dr["DE_Type"]);
            if (dr["Stat"] != DBNull.Value) deptEmployee_Relation.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(deptEmployee_Relation);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
