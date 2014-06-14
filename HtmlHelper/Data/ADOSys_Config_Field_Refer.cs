using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.HtmlHelperLib.Model;
using QX.DataAcess;

namespace QX.HtmlHelperLib.DAL
{
   /// <summary>
   /// 通用参考明细
   /// </summary>
   [Serializable]
   public partial class ADOSys_Config_Field_Refer
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加通用参考明细 Sys_Config_Field_Refer对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Config_Field_Refer sys_Config_Field_Refer)
      {
         string sql = "INSERT INTO Sys_Config_Field_Refer (D_ModuleName,D_NameSpace,D_Index,D_Name,D_Order,D_DictKey,D_Hidden,Stat) VALUES (@D_ModuleName,@D_NameSpace,@D_Index,@D_Name,@D_Order,@D_DictKey,@D_Hidden,@Stat)";
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_ModuleName))
         {
            idb.AddParameter("@D_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_ModuleName", sys_Config_Field_Refer.D_ModuleName);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_NameSpace))
         {
            idb.AddParameter("@D_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_NameSpace", sys_Config_Field_Refer.D_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Index))
         {
            idb.AddParameter("@D_Index", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Index", sys_Config_Field_Refer.D_Index);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Name))
         {
            idb.AddParameter("@D_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Name", sys_Config_Field_Refer.D_Name);
         }
         if (sys_Config_Field_Refer.D_Order == 0)
         {
            idb.AddParameter("@D_Order", 0);
         }
         else
         {
            idb.AddParameter("@D_Order", sys_Config_Field_Refer.D_Order);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_DictKey))
         {
            idb.AddParameter("@D_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DictKey", sys_Config_Field_Refer.D_DictKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Hidden))
         {
            idb.AddParameter("@D_Hidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Hidden", sys_Config_Field_Refer.D_Hidden);
         }
         if (sys_Config_Field_Refer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Field_Refer.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加通用参考明细 Sys_Config_Field_Refer对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Config_Field_Refer sys_Config_Field_Refer)
      {
         string sql = "INSERT INTO Sys_Config_Field_Refer (D_ModuleName,D_NameSpace,D_Index,D_Name,D_Order,D_DictKey,D_Hidden,Stat) VALUES (@D_ModuleName,@D_NameSpace,@D_Index,@D_Name,@D_Order,@D_DictKey,@D_Hidden,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_ModuleName))
         {
            idb.AddParameter("@D_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_ModuleName", sys_Config_Field_Refer.D_ModuleName);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_NameSpace))
         {
            idb.AddParameter("@D_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_NameSpace", sys_Config_Field_Refer.D_NameSpace);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Index))
         {
            idb.AddParameter("@D_Index", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Index", sys_Config_Field_Refer.D_Index);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Name))
         {
            idb.AddParameter("@D_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Name", sys_Config_Field_Refer.D_Name);
         }
         if (sys_Config_Field_Refer.D_Order == 0)
         {
            idb.AddParameter("@D_Order", 0);
         }
         else
         {
            idb.AddParameter("@D_Order", sys_Config_Field_Refer.D_Order);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_DictKey))
         {
            idb.AddParameter("@D_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DictKey", sys_Config_Field_Refer.D_DictKey);
         }
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Hidden))
         {
            idb.AddParameter("@D_Hidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Hidden", sys_Config_Field_Refer.D_Hidden);
         }
         if (sys_Config_Field_Refer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Field_Refer.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新通用参考明细 Sys_Config_Field_Refer对象(即:一条记录
      /// </summary>
      public int Update(Sys_Config_Field_Refer sys_Config_Field_Refer)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Config_Field_Refer       SET ");
            if(sys_Config_Field_Refer.D_ModuleName_IsChanged){sbParameter.Append("D_ModuleName=@D_ModuleName, ");}
      if(sys_Config_Field_Refer.D_NameSpace_IsChanged){sbParameter.Append("D_NameSpace=@D_NameSpace, ");}
      if(sys_Config_Field_Refer.D_Index_IsChanged){sbParameter.Append("D_Index=@D_Index, ");}
      if(sys_Config_Field_Refer.D_Name_IsChanged){sbParameter.Append("D_Name=@D_Name, ");}
      if(sys_Config_Field_Refer.D_Order_IsChanged){sbParameter.Append("D_Order=@D_Order, ");}
      if(sys_Config_Field_Refer.D_DictKey_IsChanged){sbParameter.Append("D_DictKey=@D_DictKey, ");}
      if(sys_Config_Field_Refer.D_Hidden_IsChanged){sbParameter.Append("D_Hidden=@D_Hidden, ");}
      if(sys_Config_Field_Refer.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and D_ID=@D_ID; " );
      string sql=sb.ToString();
         if(sys_Config_Field_Refer.D_ModuleName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_ModuleName))
         {
            idb.AddParameter("@D_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_ModuleName", sys_Config_Field_Refer.D_ModuleName);
         }
          }
         if(sys_Config_Field_Refer.D_NameSpace_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_NameSpace))
         {
            idb.AddParameter("@D_NameSpace", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_NameSpace", sys_Config_Field_Refer.D_NameSpace);
         }
          }
         if(sys_Config_Field_Refer.D_Index_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Index))
         {
            idb.AddParameter("@D_Index", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Index", sys_Config_Field_Refer.D_Index);
         }
          }
         if(sys_Config_Field_Refer.D_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Name))
         {
            idb.AddParameter("@D_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Name", sys_Config_Field_Refer.D_Name);
         }
          }
         if(sys_Config_Field_Refer.D_Order_IsChanged)
         {
         if (sys_Config_Field_Refer.D_Order == 0)
         {
            idb.AddParameter("@D_Order", 0);
         }
         else
         {
            idb.AddParameter("@D_Order", sys_Config_Field_Refer.D_Order);
         }
          }
         if(sys_Config_Field_Refer.D_DictKey_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_DictKey))
         {
            idb.AddParameter("@D_DictKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_DictKey", sys_Config_Field_Refer.D_DictKey);
         }
          }
         if(sys_Config_Field_Refer.D_Hidden_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Config_Field_Refer.D_Hidden))
         {
            idb.AddParameter("@D_Hidden", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@D_Hidden", sys_Config_Field_Refer.D_Hidden);
         }
          }
         if(sys_Config_Field_Refer.Stat_IsChanged)
         {
         if (sys_Config_Field_Refer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Config_Field_Refer.Stat);
         }
          }

         idb.AddParameter("@D_ID", sys_Config_Field_Refer.D_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除通用参考明细 Sys_Config_Field_Refer对象(即:一条记录
      /// </summary>
      public int Delete(decimal d_ID)
      {
         string sql = "DELETE Sys_Config_Field_Refer WHERE 1=1  AND D_ID=@D_ID ";
         idb.AddParameter("@D_ID", d_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的通用参考明细 Sys_Config_Field_Refer对象(即:一条记录
      /// </summary>
      public Sys_Config_Field_Refer GetByKey(decimal d_ID)
      {
         Sys_Config_Field_Refer sys_Config_Field_Refer = new Sys_Config_Field_Refer();
         string sql = "SELECT  D_ID,D_ModuleName,D_NameSpace,D_Index,D_Name,D_Order,D_DictKey,D_Hidden,Stat FROM Sys_Config_Field_Refer WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND D_ID=@D_ID ";
         idb.AddParameter("@D_ID", d_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["D_ID"] != DBNull.Value) sys_Config_Field_Refer.D_ID = Convert.ToDecimal(dr["D_ID"]);
            if (dr["D_ModuleName"] != DBNull.Value) sys_Config_Field_Refer.D_ModuleName = Convert.ToString(dr["D_ModuleName"]);
            if (dr["D_NameSpace"] != DBNull.Value) sys_Config_Field_Refer.D_NameSpace = Convert.ToString(dr["D_NameSpace"]);
            if (dr["D_Index"] != DBNull.Value) sys_Config_Field_Refer.D_Index = Convert.ToString(dr["D_Index"]);
            if (dr["D_Name"] != DBNull.Value) sys_Config_Field_Refer.D_Name = Convert.ToString(dr["D_Name"]);
            if (dr["D_Order"] != DBNull.Value) sys_Config_Field_Refer.D_Order = Convert.ToInt32(dr["D_Order"]);
            if (dr["D_DictKey"] != DBNull.Value) sys_Config_Field_Refer.D_DictKey = Convert.ToString(dr["D_DictKey"]);
            if (dr["D_Hidden"] != DBNull.Value) sys_Config_Field_Refer.D_Hidden = Convert.ToString(dr["D_Hidden"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Field_Refer.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Config_Field_Refer;
      }
      /// <summary>
      /// 获取指定的通用参考明细 Sys_Config_Field_Refer对象集合
      /// </summary>
      public List<Sys_Config_Field_Refer> GetListByWhere(string strCondition)
      {
         List<Sys_Config_Field_Refer> ret = new List<Sys_Config_Field_Refer>();
         string sql = "SELECT  D_ID,D_ModuleName,D_NameSpace,D_Index,D_Name,D_Order,D_DictKey,D_Hidden,Stat FROM Sys_Config_Field_Refer WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Config_Field_Refer sys_Config_Field_Refer = new Sys_Config_Field_Refer();
            if (dr["D_ID"] != DBNull.Value) sys_Config_Field_Refer.D_ID = Convert.ToDecimal(dr["D_ID"]);
            if (dr["D_ModuleName"] != DBNull.Value) sys_Config_Field_Refer.D_ModuleName = Convert.ToString(dr["D_ModuleName"]);
            if (dr["D_NameSpace"] != DBNull.Value) sys_Config_Field_Refer.D_NameSpace = Convert.ToString(dr["D_NameSpace"]);
            if (dr["D_Index"] != DBNull.Value) sys_Config_Field_Refer.D_Index = Convert.ToString(dr["D_Index"]);
            if (dr["D_Name"] != DBNull.Value) sys_Config_Field_Refer.D_Name = Convert.ToString(dr["D_Name"]);
            if (dr["D_Order"] != DBNull.Value) sys_Config_Field_Refer.D_Order = Convert.ToInt32(dr["D_Order"]);
            if (dr["D_DictKey"] != DBNull.Value) sys_Config_Field_Refer.D_DictKey = Convert.ToString(dr["D_DictKey"]);
            if (dr["D_Hidden"] != DBNull.Value) sys_Config_Field_Refer.D_Hidden = Convert.ToString(dr["D_Hidden"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Field_Refer.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Config_Field_Refer);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的通用参考明细 Sys_Config_Field_Refer对象(即:一条记录
      /// </summary>
      public List<Sys_Config_Field_Refer> GetAll()
      {
         List<Sys_Config_Field_Refer> ret = new List<Sys_Config_Field_Refer>();
         string sql = "SELECT  D_ID,D_ModuleName,D_NameSpace,D_Index,D_Name,D_Order,D_DictKey,D_Hidden,Stat FROM Sys_Config_Field_Refer where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Config_Field_Refer sys_Config_Field_Refer = new Sys_Config_Field_Refer();
            if (dr["D_ID"] != DBNull.Value) sys_Config_Field_Refer.D_ID = Convert.ToDecimal(dr["D_ID"]);
            if (dr["D_ModuleName"] != DBNull.Value) sys_Config_Field_Refer.D_ModuleName = Convert.ToString(dr["D_ModuleName"]);
            if (dr["D_NameSpace"] != DBNull.Value) sys_Config_Field_Refer.D_NameSpace = Convert.ToString(dr["D_NameSpace"]);
            if (dr["D_Index"] != DBNull.Value) sys_Config_Field_Refer.D_Index = Convert.ToString(dr["D_Index"]);
            if (dr["D_Name"] != DBNull.Value) sys_Config_Field_Refer.D_Name = Convert.ToString(dr["D_Name"]);
            if (dr["D_Order"] != DBNull.Value) sys_Config_Field_Refer.D_Order = Convert.ToInt32(dr["D_Order"]);
            if (dr["D_DictKey"] != DBNull.Value) sys_Config_Field_Refer.D_DictKey = Convert.ToString(dr["D_DictKey"]);
            if (dr["D_Hidden"] != DBNull.Value) sys_Config_Field_Refer.D_Hidden = Convert.ToString(dr["D_Hidden"]);
            if (dr["Stat"] != DBNull.Value) sys_Config_Field_Refer.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Config_Field_Refer);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
