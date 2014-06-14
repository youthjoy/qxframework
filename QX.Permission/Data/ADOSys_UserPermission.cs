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
   public partial class ADOSys_UserPermission
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_UserPermission对象(即:一条记录)
      /// </summary>
      public int Add(Sys_UserPermission sys_UserPermission)
      {
         string sql = "INSERT INTO Sys_UserPermission (PU_Code,PU_UserCode,PU_FunName,PU_FunCode,PU_FunPCode,PU_UDef1,PU_UDef2,PU_UDef3,PU_IsCheck,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PU_Code,@PU_UserCode,@PU_FunName,@PU_FunCode,@PU_FunPCode,@PU_UDef1,@PU_UDef2,@PU_UDef3,@PU_IsCheck,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(sys_UserPermission.PU_Code))
         {
            idb.AddParameter("@PU_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_Code", sys_UserPermission.PU_Code);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UserCode))
         {
            idb.AddParameter("@PU_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UserCode", sys_UserPermission.PU_UserCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunName))
         {
            idb.AddParameter("@PU_FunName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunName", sys_UserPermission.PU_FunName);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunCode))
         {
            idb.AddParameter("@PU_FunCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunCode", sys_UserPermission.PU_FunCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunPCode))
         {
            idb.AddParameter("@PU_FunPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunPCode", sys_UserPermission.PU_FunPCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef1))
         {
            idb.AddParameter("@PU_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef1", sys_UserPermission.PU_UDef1);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef2))
         {
            idb.AddParameter("@PU_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef2", sys_UserPermission.PU_UDef2);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef3))
         {
            idb.AddParameter("@PU_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef3", sys_UserPermission.PU_UDef3);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_IsCheck))
         {
            idb.AddParameter("@PU_IsCheck", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_IsCheck", sys_UserPermission.PU_IsCheck);
         }
         if (sys_UserPermission.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_UserPermission.Stat);
         }
         if (sys_UserPermission.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sys_UserPermission.CreateDate);
         }
         if (sys_UserPermission.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sys_UserPermission.UpdateDate);
         }
         if (sys_UserPermission.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sys_UserPermission.DeleteDate);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_UserPermission对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_UserPermission sys_UserPermission)
      {
         string sql = "INSERT INTO Sys_UserPermission (PU_Code,PU_UserCode,PU_FunName,PU_FunCode,PU_FunPCode,PU_UDef1,PU_UDef2,PU_UDef3,PU_IsCheck,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PU_Code,@PU_UserCode,@PU_FunName,@PU_FunCode,@PU_FunPCode,@PU_UDef1,@PU_UDef2,@PU_UDef3,@PU_IsCheck,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_UserPermission.PU_Code))
         {
            idb.AddParameter("@PU_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_Code", sys_UserPermission.PU_Code);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UserCode))
         {
            idb.AddParameter("@PU_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UserCode", sys_UserPermission.PU_UserCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunName))
         {
            idb.AddParameter("@PU_FunName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunName", sys_UserPermission.PU_FunName);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunCode))
         {
            idb.AddParameter("@PU_FunCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunCode", sys_UserPermission.PU_FunCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunPCode))
         {
            idb.AddParameter("@PU_FunPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunPCode", sys_UserPermission.PU_FunPCode);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef1))
         {
            idb.AddParameter("@PU_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef1", sys_UserPermission.PU_UDef1);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef2))
         {
            idb.AddParameter("@PU_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef2", sys_UserPermission.PU_UDef2);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef3))
         {
            idb.AddParameter("@PU_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef3", sys_UserPermission.PU_UDef3);
         }
         if (string.IsNullOrEmpty(sys_UserPermission.PU_IsCheck))
         {
            idb.AddParameter("@PU_IsCheck", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_IsCheck", sys_UserPermission.PU_IsCheck);
         }
         if (sys_UserPermission.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_UserPermission.Stat);
         }
         if (sys_UserPermission.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sys_UserPermission.CreateDate);
         }
         if (sys_UserPermission.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sys_UserPermission.UpdateDate);
         }
         if (sys_UserPermission.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sys_UserPermission.DeleteDate);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_UserPermission对象(即:一条记录
      /// </summary>
      public int Update(Sys_UserPermission sys_UserPermission)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_UserPermission       SET ");
            if(sys_UserPermission.PU_Code_IsChanged){sbParameter.Append("PU_Code=@PU_Code, ");}
      if(sys_UserPermission.PU_UserCode_IsChanged){sbParameter.Append("PU_UserCode=@PU_UserCode, ");}
      if(sys_UserPermission.PU_FunName_IsChanged){sbParameter.Append("PU_FunName=@PU_FunName, ");}
      if(sys_UserPermission.PU_FunCode_IsChanged){sbParameter.Append("PU_FunCode=@PU_FunCode, ");}
      if(sys_UserPermission.PU_FunPCode_IsChanged){sbParameter.Append("PU_FunPCode=@PU_FunPCode, ");}
      if(sys_UserPermission.PU_UDef1_IsChanged){sbParameter.Append("PU_UDef1=@PU_UDef1, ");}
      if(sys_UserPermission.PU_UDef2_IsChanged){sbParameter.Append("PU_UDef2=@PU_UDef2, ");}
      if(sys_UserPermission.PU_UDef3_IsChanged){sbParameter.Append("PU_UDef3=@PU_UDef3, ");}
      if(sys_UserPermission.PU_IsCheck_IsChanged){sbParameter.Append("PU_IsCheck=@PU_IsCheck, ");}
      if(sys_UserPermission.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_UserPermission.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sys_UserPermission.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sys_UserPermission.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PU_ID=@PU_ID; " );
      string sql=sb.ToString();
         if(sys_UserPermission.PU_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_Code))
         {
            idb.AddParameter("@PU_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_Code", sys_UserPermission.PU_Code);
         }
          }
         if(sys_UserPermission.PU_UserCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UserCode))
         {
            idb.AddParameter("@PU_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UserCode", sys_UserPermission.PU_UserCode);
         }
          }
         if(sys_UserPermission.PU_FunName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunName))
         {
            idb.AddParameter("@PU_FunName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunName", sys_UserPermission.PU_FunName);
         }
          }
         if(sys_UserPermission.PU_FunCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunCode))
         {
            idb.AddParameter("@PU_FunCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunCode", sys_UserPermission.PU_FunCode);
         }
          }
         if(sys_UserPermission.PU_FunPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_FunPCode))
         {
            idb.AddParameter("@PU_FunPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_FunPCode", sys_UserPermission.PU_FunPCode);
         }
          }
         if(sys_UserPermission.PU_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef1))
         {
            idb.AddParameter("@PU_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef1", sys_UserPermission.PU_UDef1);
         }
          }
         if(sys_UserPermission.PU_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef2))
         {
            idb.AddParameter("@PU_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef2", sys_UserPermission.PU_UDef2);
         }
          }
         if(sys_UserPermission.PU_UDef3_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_UDef3))
         {
            idb.AddParameter("@PU_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_UDef3", sys_UserPermission.PU_UDef3);
         }
          }
         if(sys_UserPermission.PU_IsCheck_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_UserPermission.PU_IsCheck))
         {
            idb.AddParameter("@PU_IsCheck", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PU_IsCheck", sys_UserPermission.PU_IsCheck);
         }
          }
         if(sys_UserPermission.Stat_IsChanged)
         {
         if (sys_UserPermission.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_UserPermission.Stat);
         }
          }
         if(sys_UserPermission.CreateDate_IsChanged)
         {
         if (sys_UserPermission.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sys_UserPermission.CreateDate);
         }
          }
         if(sys_UserPermission.UpdateDate_IsChanged)
         {
         if (sys_UserPermission.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sys_UserPermission.UpdateDate);
         }
          }
         if(sys_UserPermission.DeleteDate_IsChanged)
         {
         if (sys_UserPermission.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sys_UserPermission.DeleteDate);
         }
          }

         idb.AddParameter("@PU_ID", sys_UserPermission.PU_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_UserPermission对象(即:一条记录
      /// </summary>
      public int Delete(decimal pU_ID)
      {
         string sql = "DELETE Sys_UserPermission WHERE 1=1  AND PU_ID=@PU_ID ";
         idb.AddParameter("@PU_ID", pU_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_UserPermission对象(即:一条记录
      /// </summary>
      public Sys_UserPermission GetByKey(decimal pU_ID)
      {
         Sys_UserPermission sys_UserPermission = new Sys_UserPermission();
         string sql = "SELECT  PU_ID,PU_Code,PU_UserCode,PU_FunName,PU_FunCode,PU_FunPCode,PU_UDef1,PU_UDef2,PU_UDef3,PU_IsCheck,Stat,CreateDate,UpdateDate,DeleteDate FROM Sys_UserPermission WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PU_ID=@PU_ID ";
         idb.AddParameter("@PU_ID", pU_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PU_ID"] != DBNull.Value) sys_UserPermission.PU_ID = Convert.ToDecimal(dr["PU_ID"]);
            if (dr["PU_Code"] != DBNull.Value) sys_UserPermission.PU_Code = Convert.ToString(dr["PU_Code"]);
            if (dr["PU_UserCode"] != DBNull.Value) sys_UserPermission.PU_UserCode = Convert.ToString(dr["PU_UserCode"]);
            if (dr["PU_FunName"] != DBNull.Value) sys_UserPermission.PU_FunName = Convert.ToString(dr["PU_FunName"]);
            if (dr["PU_FunCode"] != DBNull.Value) sys_UserPermission.PU_FunCode = Convert.ToString(dr["PU_FunCode"]);
            if (dr["PU_FunPCode"] != DBNull.Value) sys_UserPermission.PU_FunPCode = Convert.ToString(dr["PU_FunPCode"]);
            if (dr["PU_UDef1"] != DBNull.Value) sys_UserPermission.PU_UDef1 = Convert.ToString(dr["PU_UDef1"]);
            if (dr["PU_UDef2"] != DBNull.Value) sys_UserPermission.PU_UDef2 = Convert.ToString(dr["PU_UDef2"]);
            if (dr["PU_UDef3"] != DBNull.Value) sys_UserPermission.PU_UDef3 = Convert.ToString(dr["PU_UDef3"]);
            if (dr["PU_IsCheck"] != DBNull.Value) sys_UserPermission.PU_IsCheck = Convert.ToString(dr["PU_IsCheck"]);
            if (dr["Stat"] != DBNull.Value) sys_UserPermission.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sys_UserPermission.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sys_UserPermission.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sys_UserPermission.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_UserPermission;
      }
      /// <summary>
      /// 获取指定的Sys_UserPermission对象集合
      /// </summary>
      public List<Sys_UserPermission> GetListByWhere(string strCondition)
      {
         List<Sys_UserPermission> ret = new List<Sys_UserPermission>();
         string sql = "SELECT  PU_ID,PU_Code,PU_UserCode,PU_FunName,PU_FunCode,PU_FunPCode,PU_UDef1,PU_UDef2,PU_UDef3,PU_IsCheck,Stat,CreateDate,UpdateDate,DeleteDate FROM Sys_UserPermission WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_UserPermission sys_UserPermission = new Sys_UserPermission();
            if (dr["PU_ID"] != DBNull.Value) sys_UserPermission.PU_ID = Convert.ToDecimal(dr["PU_ID"]);
            if (dr["PU_Code"] != DBNull.Value) sys_UserPermission.PU_Code = Convert.ToString(dr["PU_Code"]);
            if (dr["PU_UserCode"] != DBNull.Value) sys_UserPermission.PU_UserCode = Convert.ToString(dr["PU_UserCode"]);
            if (dr["PU_FunName"] != DBNull.Value) sys_UserPermission.PU_FunName = Convert.ToString(dr["PU_FunName"]);
            if (dr["PU_FunCode"] != DBNull.Value) sys_UserPermission.PU_FunCode = Convert.ToString(dr["PU_FunCode"]);
            if (dr["PU_FunPCode"] != DBNull.Value) sys_UserPermission.PU_FunPCode = Convert.ToString(dr["PU_FunPCode"]);
            if (dr["PU_UDef1"] != DBNull.Value) sys_UserPermission.PU_UDef1 = Convert.ToString(dr["PU_UDef1"]);
            if (dr["PU_UDef2"] != DBNull.Value) sys_UserPermission.PU_UDef2 = Convert.ToString(dr["PU_UDef2"]);
            if (dr["PU_UDef3"] != DBNull.Value) sys_UserPermission.PU_UDef3 = Convert.ToString(dr["PU_UDef3"]);
            if (dr["PU_IsCheck"] != DBNull.Value) sys_UserPermission.PU_IsCheck = Convert.ToString(dr["PU_IsCheck"]);
            if (dr["Stat"] != DBNull.Value) sys_UserPermission.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sys_UserPermission.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sys_UserPermission.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sys_UserPermission.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sys_UserPermission);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_UserPermission对象(即:一条记录
      /// </summary>
      public List<Sys_UserPermission> GetAll()
      {
         List<Sys_UserPermission> ret = new List<Sys_UserPermission>();
         string sql = "SELECT  PU_ID,PU_Code,PU_UserCode,PU_FunName,PU_FunCode,PU_FunPCode,PU_UDef1,PU_UDef2,PU_UDef3,PU_IsCheck,Stat,CreateDate,UpdateDate,DeleteDate FROM Sys_UserPermission where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_UserPermission sys_UserPermission = new Sys_UserPermission();
            if (dr["PU_ID"] != DBNull.Value) sys_UserPermission.PU_ID = Convert.ToDecimal(dr["PU_ID"]);
            if (dr["PU_Code"] != DBNull.Value) sys_UserPermission.PU_Code = Convert.ToString(dr["PU_Code"]);
            if (dr["PU_UserCode"] != DBNull.Value) sys_UserPermission.PU_UserCode = Convert.ToString(dr["PU_UserCode"]);
            if (dr["PU_FunName"] != DBNull.Value) sys_UserPermission.PU_FunName = Convert.ToString(dr["PU_FunName"]);
            if (dr["PU_FunCode"] != DBNull.Value) sys_UserPermission.PU_FunCode = Convert.ToString(dr["PU_FunCode"]);
            if (dr["PU_FunPCode"] != DBNull.Value) sys_UserPermission.PU_FunPCode = Convert.ToString(dr["PU_FunPCode"]);
            if (dr["PU_UDef1"] != DBNull.Value) sys_UserPermission.PU_UDef1 = Convert.ToString(dr["PU_UDef1"]);
            if (dr["PU_UDef2"] != DBNull.Value) sys_UserPermission.PU_UDef2 = Convert.ToString(dr["PU_UDef2"]);
            if (dr["PU_UDef3"] != DBNull.Value) sys_UserPermission.PU_UDef3 = Convert.ToString(dr["PU_UDef3"]);
            if (dr["PU_IsCheck"] != DBNull.Value) sys_UserPermission.PU_IsCheck = Convert.ToString(dr["PU_IsCheck"]);
            if (dr["Stat"] != DBNull.Value) sys_UserPermission.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sys_UserPermission.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sys_UserPermission.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sys_UserPermission.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(sys_UserPermission);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
