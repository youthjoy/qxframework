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
   /// 审核模板
   /// </summary>
   [Serializable]
   public partial class ADOVerify_Template
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加审核模板 Verify_Template对象(即:一条记录)
      /// </summary>
      public int Add(Verify_Template verify_Template)
      {
         string sql = "INSERT INTO Verify_Template (VT_Key,VT_No,VerifyNode_Code4,VerifyNode_Name3,Flag) VALUES (@VT_Key,@VT_No,@VerifyNode_Code4,@VerifyNode_Name3,@Flag)";
         if (string.IsNullOrEmpty(verify_Template.VT_Key))
         {
            idb.AddParameter("@VT_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VT_Key", verify_Template.VT_Key);
         }
         if (string.IsNullOrEmpty(verify_Template.VT_No))
         {
            idb.AddParameter("@VT_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VT_No", verify_Template.VT_No);
         }
         if (string.IsNullOrEmpty(verify_Template.VerifyNode_Code4))
         {
            idb.AddParameter("@VerifyNode_Code4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNode_Code4", verify_Template.VerifyNode_Code4);
         }
         if (string.IsNullOrEmpty(verify_Template.VerifyNode_Name3))
         {
            idb.AddParameter("@VerifyNode_Name3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNode_Name3", verify_Template.VerifyNode_Name3);
         }
         if (verify_Template.Flag == 0)
         {
            idb.AddParameter("@Flag", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Flag", verify_Template.Flag);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加审核模板 Verify_Template对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Verify_Template verify_Template)
      {
         string sql = "INSERT INTO Verify_Template (VT_Key,VT_No,VerifyNode_Code4,VerifyNode_Name3,Flag) VALUES (@VT_Key,@VT_No,@VerifyNode_Code4,@VerifyNode_Name3,@Flag);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(verify_Template.VT_Key))
         {
            idb.AddParameter("@VT_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VT_Key", verify_Template.VT_Key);
         }
         if (string.IsNullOrEmpty(verify_Template.VT_No))
         {
            idb.AddParameter("@VT_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VT_No", verify_Template.VT_No);
         }
         if (string.IsNullOrEmpty(verify_Template.VerifyNode_Code4))
         {
            idb.AddParameter("@VerifyNode_Code4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNode_Code4", verify_Template.VerifyNode_Code4);
         }
         if (string.IsNullOrEmpty(verify_Template.VerifyNode_Name3))
         {
            idb.AddParameter("@VerifyNode_Name3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNode_Name3", verify_Template.VerifyNode_Name3);
         }
         if (verify_Template.Flag == 0)
         {
            idb.AddParameter("@Flag", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Flag", verify_Template.Flag);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 更新审核模板 Verify_Template对象(即:一条记录
      /// </summary>
      public int Update(Verify_Template verify_Template)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Verify_Template       SET ");
            if(verify_Template.VT_Key_IsChanged){sbParameter.Append("VT_Key=@VT_Key, ");}
      if(verify_Template.VT_No_IsChanged){sbParameter.Append("VT_No=@VT_No, ");}
      if(verify_Template.VerifyNode_Code4_IsChanged){sbParameter.Append("VerifyNode_Code4=@VerifyNode_Code4, ");}
      if(verify_Template.VerifyNode_Name3_IsChanged){sbParameter.Append("VerifyNode_Name3=@VerifyNode_Name3, ");}
      if(verify_Template.Flag_IsChanged){sbParameter.Append("Flag=@Flag ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and VT_ID=@VT_ID; " );
      string sql=sb.ToString();
         if(verify_Template.VT_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(verify_Template.VT_Key))
         {
            idb.AddParameter("@VT_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VT_Key", verify_Template.VT_Key);
         }
          }
         if(verify_Template.VT_No_IsChanged)
         {
         if (string.IsNullOrEmpty(verify_Template.VT_No))
         {
            idb.AddParameter("@VT_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VT_No", verify_Template.VT_No);
         }
          }
         if(verify_Template.VerifyNode_Code4_IsChanged)
         {
         if (string.IsNullOrEmpty(verify_Template.VerifyNode_Code4))
         {
            idb.AddParameter("@VerifyNode_Code4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNode_Code4", verify_Template.VerifyNode_Code4);
         }
          }
         if(verify_Template.VerifyNode_Name3_IsChanged)
         {
         if (string.IsNullOrEmpty(verify_Template.VerifyNode_Name3))
         {
            idb.AddParameter("@VerifyNode_Name3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNode_Name3", verify_Template.VerifyNode_Name3);
         }
          }
         if(verify_Template.Flag_IsChanged)
         {
         if (verify_Template.Flag == 0)
         {
            idb.AddParameter("@Flag", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Flag", verify_Template.Flag);
         }
          }

         idb.AddParameter("@VT_ID", verify_Template.VT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除审核模板 Verify_Template对象(即:一条记录
      /// </summary>
      public int Delete(int vT_ID)
      {
         string sql = "DELETE Verify_Template WHERE 1=1  AND VT_ID=@VT_ID ";
         idb.AddParameter("@VT_ID", vT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的审核模板 Verify_Template对象(即:一条记录
      /// </summary>
      public Verify_Template GetByKey(int vT_ID)
      {
         Verify_Template verify_Template = new Verify_Template();
         string sql = "SELECT  VT_ID,VT_Key,VT_No,VerifyNode_Code4,VerifyNode_Name3,Flag FROM Verify_Template WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND VT_ID=@VT_ID ";
         idb.AddParameter("@VT_ID", vT_ID);

         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["VT_ID"] != DBNull.Value) verify_Template.VT_ID = Convert.ToInt32(dr["VT_ID"]);
            if (dr["VT_Key"] != DBNull.Value) verify_Template.VT_Key = Convert.ToString(dr["VT_Key"]);
            if (dr["VT_No"] != DBNull.Value) verify_Template.VT_No = Convert.ToString(dr["VT_No"]);
            if (dr["VerifyNode_Code4"] != DBNull.Value) verify_Template.VerifyNode_Code4 = Convert.ToString(dr["VerifyNode_Code4"]);
            if (dr["VerifyNode_Name3"] != DBNull.Value) verify_Template.VerifyNode_Name3 = Convert.ToString(dr["VerifyNode_Name3"]);
            if (dr["Flag"] != DBNull.Value) verify_Template.Flag = Convert.ToInt32(dr["Flag"]);
         }
          dr.Close(); 
         return verify_Template;
      }
      /// <summary>
      /// 获取指定的审核模板 Verify_Template对象集合
      /// </summary>
      public List<Verify_Template> GetListByWhere(string strCondition)
      {
         List<Verify_Template> ret = new List<Verify_Template>();
         string sql = "SELECT  VT_ID,VT_Key,VT_No,VerifyNode_Code4,VerifyNode_Name3,Flag FROM Verify_Template WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Verify_Template verify_Template = new Verify_Template();
            if (dr["VT_ID"] != DBNull.Value) verify_Template.VT_ID = Convert.ToInt32(dr["VT_ID"]);
            if (dr["VT_Key"] != DBNull.Value) verify_Template.VT_Key = Convert.ToString(dr["VT_Key"]);
            if (dr["VT_No"] != DBNull.Value) verify_Template.VT_No = Convert.ToString(dr["VT_No"]);
            if (dr["VerifyNode_Code4"] != DBNull.Value) verify_Template.VerifyNode_Code4 = Convert.ToString(dr["VerifyNode_Code4"]);
            if (dr["VerifyNode_Name3"] != DBNull.Value) verify_Template.VerifyNode_Name3 = Convert.ToString(dr["VerifyNode_Name3"]);
            if (dr["Flag"] != DBNull.Value) verify_Template.Flag = Convert.ToInt32(dr["Flag"]);
            ret.Add(verify_Template);
         }
          dr.Close(); 
         return ret;
      }
      /// <summary>
      /// 获取所有的审核模板 Verify_Template对象(即:一条记录
      /// </summary>
      public List<Verify_Template> GetAll()
      {
         List<Verify_Template> ret = new List<Verify_Template>();
         string sql = "SELECT  VT_ID,VT_Key,VT_No,VerifyNode_Code4,VerifyNode_Name3,Flag FROM Verify_Template where 1=1 AND ((Stat is null) or (Stat=0) ) ";
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Verify_Template verify_Template = new Verify_Template();
            if (dr["VT_ID"] != DBNull.Value) verify_Template.VT_ID = Convert.ToInt32(dr["VT_ID"]);
            if (dr["VT_Key"] != DBNull.Value) verify_Template.VT_Key = Convert.ToString(dr["VT_Key"]);
            if (dr["VT_No"] != DBNull.Value) verify_Template.VT_No = Convert.ToString(dr["VT_No"]);
            if (dr["VerifyNode_Code4"] != DBNull.Value) verify_Template.VerifyNode_Code4 = Convert.ToString(dr["VerifyNode_Code4"]);
            if (dr["VerifyNode_Name3"] != DBNull.Value) verify_Template.VerifyNode_Name3 = Convert.ToString(dr["VerifyNode_Name3"]);
            if (dr["Flag"] != DBNull.Value) verify_Template.Flag = Convert.ToInt32(dr["Flag"]);
            ret.Add(verify_Template);
         }
          dr.Close(); 
         return ret;
      }
   }
}
