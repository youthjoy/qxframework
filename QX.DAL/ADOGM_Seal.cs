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
   /// 印章基本信息
   /// </summary>
   [Serializable]
   public partial class ADOGM_Seal
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加印章基本信息 GM_Seal对象(即:一条记录)
      /// </summary>
      public int Add(GM_Seal gM_Seal)
      {
         string sql = "INSERT INTO GM_Seal (GMSE_Code,GMSE_Name,GMSE_CompanyCode,GMSE_DeptCode,GMSE_Intro,GMSE_iType,GMSE_Bak,GMSE_Owner,GMSE_Tel,GMSE_Cat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@GMSE_Code,@GMSE_Name,@GMSE_CompanyCode,@GMSE_DeptCode,@GMSE_Intro,@GMSE_iType,@GMSE_Bak,@GMSE_Owner,@GMSE_Tel,@GMSE_Cat,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Code))
         {
            idb.AddParameter("@GMSE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Code", gM_Seal.GMSE_Code);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Name))
         {
            idb.AddParameter("@GMSE_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Name", gM_Seal.GMSE_Name);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_CompanyCode))
         {
            idb.AddParameter("@GMSE_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_CompanyCode", gM_Seal.GMSE_CompanyCode);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_DeptCode))
         {
            idb.AddParameter("@GMSE_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_DeptCode", gM_Seal.GMSE_DeptCode);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Intro))
         {
            idb.AddParameter("@GMSE_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Intro", gM_Seal.GMSE_Intro);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_iType))
         {
            idb.AddParameter("@GMSE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_iType", gM_Seal.GMSE_iType);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Bak))
         {
            idb.AddParameter("@GMSE_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Bak", gM_Seal.GMSE_Bak);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Owner))
         {
            idb.AddParameter("@GMSE_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Owner", gM_Seal.GMSE_Owner);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Tel))
         {
            idb.AddParameter("@GMSE_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Tel", gM_Seal.GMSE_Tel);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Cat))
         {
            idb.AddParameter("@GMSE_Cat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Cat", gM_Seal.GMSE_Cat);
         }
         if (gM_Seal.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gM_Seal.Stat);
         }
         if (gM_Seal.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", gM_Seal.CreateDate);
         }
         if (gM_Seal.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", gM_Seal.UpdateDate);
         }
         if (gM_Seal.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", gM_Seal.DeleteDate);
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
      /// 添加印章基本信息 GM_Seal对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(GM_Seal gM_Seal)
      {
         string sql = "INSERT INTO GM_Seal (GMSE_Code,GMSE_Name,GMSE_CompanyCode,GMSE_DeptCode,GMSE_Intro,GMSE_iType,GMSE_Bak,GMSE_Owner,GMSE_Tel,GMSE_Cat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@GMSE_Code,@GMSE_Name,@GMSE_CompanyCode,@GMSE_DeptCode,@GMSE_Intro,@GMSE_iType,@GMSE_Bak,@GMSE_Owner,@GMSE_Tel,@GMSE_Cat,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Code))
         {
            idb.AddParameter("@GMSE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Code", gM_Seal.GMSE_Code);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Name))
         {
            idb.AddParameter("@GMSE_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Name", gM_Seal.GMSE_Name);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_CompanyCode))
         {
            idb.AddParameter("@GMSE_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_CompanyCode", gM_Seal.GMSE_CompanyCode);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_DeptCode))
         {
            idb.AddParameter("@GMSE_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_DeptCode", gM_Seal.GMSE_DeptCode);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Intro))
         {
            idb.AddParameter("@GMSE_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Intro", gM_Seal.GMSE_Intro);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_iType))
         {
            idb.AddParameter("@GMSE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_iType", gM_Seal.GMSE_iType);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Bak))
         {
            idb.AddParameter("@GMSE_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Bak", gM_Seal.GMSE_Bak);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Owner))
         {
            idb.AddParameter("@GMSE_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Owner", gM_Seal.GMSE_Owner);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Tel))
         {
            idb.AddParameter("@GMSE_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Tel", gM_Seal.GMSE_Tel);
         }
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Cat))
         {
            idb.AddParameter("@GMSE_Cat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Cat", gM_Seal.GMSE_Cat);
         }
         if (gM_Seal.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gM_Seal.Stat);
         }
         if (gM_Seal.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", gM_Seal.CreateDate);
         }
         if (gM_Seal.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", gM_Seal.UpdateDate);
         }
         if (gM_Seal.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", gM_Seal.DeleteDate);
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
      /// 更新印章基本信息 GM_Seal对象(即:一条记录
      /// </summary>
      public int Update(GM_Seal gM_Seal)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       GM_Seal       SET ");
            if(gM_Seal.GMSE_Code_IsChanged){sbParameter.Append("GMSE_Code=@GMSE_Code, ");}
      if(gM_Seal.GMSE_Name_IsChanged){sbParameter.Append("GMSE_Name=@GMSE_Name, ");}
      if(gM_Seal.GMSE_CompanyCode_IsChanged){sbParameter.Append("GMSE_CompanyCode=@GMSE_CompanyCode, ");}
      if(gM_Seal.GMSE_DeptCode_IsChanged){sbParameter.Append("GMSE_DeptCode=@GMSE_DeptCode, ");}
      if(gM_Seal.GMSE_Intro_IsChanged){sbParameter.Append("GMSE_Intro=@GMSE_Intro, ");}
      if(gM_Seal.GMSE_iType_IsChanged){sbParameter.Append("GMSE_iType=@GMSE_iType, ");}
      if(gM_Seal.GMSE_Bak_IsChanged){sbParameter.Append("GMSE_Bak=@GMSE_Bak, ");}
      if(gM_Seal.GMSE_Owner_IsChanged){sbParameter.Append("GMSE_Owner=@GMSE_Owner, ");}
      if(gM_Seal.GMSE_Tel_IsChanged){sbParameter.Append("GMSE_Tel=@GMSE_Tel, ");}
      if(gM_Seal.GMSE_Cat_IsChanged){sbParameter.Append("GMSE_Cat=@GMSE_Cat, ");}
      if(gM_Seal.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(gM_Seal.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(gM_Seal.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(gM_Seal.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and GMSE_ID=@GMSE_ID; " );
      string sql=sb.ToString();
         if(gM_Seal.GMSE_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Code))
         {
            idb.AddParameter("@GMSE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Code", gM_Seal.GMSE_Code);
         }
          }
         if(gM_Seal.GMSE_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Name))
         {
            idb.AddParameter("@GMSE_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Name", gM_Seal.GMSE_Name);
         }
          }
         if(gM_Seal.GMSE_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_CompanyCode))
         {
            idb.AddParameter("@GMSE_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_CompanyCode", gM_Seal.GMSE_CompanyCode);
         }
          }
         if(gM_Seal.GMSE_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_DeptCode))
         {
            idb.AddParameter("@GMSE_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_DeptCode", gM_Seal.GMSE_DeptCode);
         }
          }
         if(gM_Seal.GMSE_Intro_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Intro))
         {
            idb.AddParameter("@GMSE_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Intro", gM_Seal.GMSE_Intro);
         }
          }
         if(gM_Seal.GMSE_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_iType))
         {
            idb.AddParameter("@GMSE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_iType", gM_Seal.GMSE_iType);
         }
          }
         if(gM_Seal.GMSE_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Bak))
         {
            idb.AddParameter("@GMSE_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Bak", gM_Seal.GMSE_Bak);
         }
          }
         if(gM_Seal.GMSE_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Owner))
         {
            idb.AddParameter("@GMSE_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Owner", gM_Seal.GMSE_Owner);
         }
          }
         if(gM_Seal.GMSE_Tel_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Tel))
         {
            idb.AddParameter("@GMSE_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Tel", gM_Seal.GMSE_Tel);
         }
          }
         if(gM_Seal.GMSE_Cat_IsChanged)
         {
         if (string.IsNullOrEmpty(gM_Seal.GMSE_Cat))
         {
            idb.AddParameter("@GMSE_Cat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GMSE_Cat", gM_Seal.GMSE_Cat);
         }
          }
         if(gM_Seal.Stat_IsChanged)
         {
         if (gM_Seal.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", gM_Seal.Stat);
         }
          }
         if(gM_Seal.CreateDate_IsChanged)
         {
         if (gM_Seal.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", gM_Seal.CreateDate);
         }
          }
         if(gM_Seal.UpdateDate_IsChanged)
         {
         if (gM_Seal.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", gM_Seal.UpdateDate);
         }
          }
         if(gM_Seal.DeleteDate_IsChanged)
         {
         if (gM_Seal.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", gM_Seal.DeleteDate);
         }
          }

         idb.AddParameter("@GMSE_ID", gM_Seal.GMSE_ID);

           
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
      /// 删除印章基本信息 GM_Seal对象(即:一条记录
      /// </summary>
      public int Delete(decimal gMSE_ID)
      {
         string sql = "DELETE GM_Seal WHERE 1=1  AND GMSE_ID=@GMSE_ID ";
         idb.AddParameter("@GMSE_ID", gMSE_ID);

           
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
      /// 获取指定的印章基本信息 GM_Seal对象(即:一条记录
      /// </summary>
      public GM_Seal GetByKey(decimal gMSE_ID)
      {
         GM_Seal gM_Seal = new GM_Seal();
         string sql = "SELECT  GMSE_ID,GMSE_Code,GMSE_Name,GMSE_CompanyCode,GMSE_DeptCode,GMSE_Intro,GMSE_iType,GMSE_Bak,GMSE_Owner,GMSE_Tel,GMSE_Cat,Stat,CreateDate,UpdateDate,DeleteDate FROM GM_Seal WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND GMSE_ID=@GMSE_ID ";
         idb.AddParameter("@GMSE_ID", gMSE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["GMSE_ID"] != DBNull.Value) gM_Seal.GMSE_ID = Convert.ToDecimal(dr["GMSE_ID"]);
            if (dr["GMSE_Code"] != DBNull.Value) gM_Seal.GMSE_Code = Convert.ToString(dr["GMSE_Code"]);
            if (dr["GMSE_Name"] != DBNull.Value) gM_Seal.GMSE_Name = Convert.ToString(dr["GMSE_Name"]);
            if (dr["GMSE_CompanyCode"] != DBNull.Value) gM_Seal.GMSE_CompanyCode = Convert.ToString(dr["GMSE_CompanyCode"]);
            if (dr["GMSE_DeptCode"] != DBNull.Value) gM_Seal.GMSE_DeptCode = Convert.ToString(dr["GMSE_DeptCode"]);
            if (dr["GMSE_Intro"] != DBNull.Value) gM_Seal.GMSE_Intro = Convert.ToString(dr["GMSE_Intro"]);
            if (dr["GMSE_iType"] != DBNull.Value) gM_Seal.GMSE_iType = Convert.ToString(dr["GMSE_iType"]);
            if (dr["GMSE_Bak"] != DBNull.Value) gM_Seal.GMSE_Bak = Convert.ToString(dr["GMSE_Bak"]);
            if (dr["GMSE_Owner"] != DBNull.Value) gM_Seal.GMSE_Owner = Convert.ToString(dr["GMSE_Owner"]);
            if (dr["GMSE_Tel"] != DBNull.Value) gM_Seal.GMSE_Tel = Convert.ToString(dr["GMSE_Tel"]);
            if (dr["GMSE_Cat"] != DBNull.Value) gM_Seal.GMSE_Cat = Convert.ToString(dr["GMSE_Cat"]);
            if (dr["Stat"] != DBNull.Value) gM_Seal.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) gM_Seal.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) gM_Seal.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) gM_Seal.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return gM_Seal;
      }
      /// <summary>
      /// 获取指定的印章基本信息 GM_Seal对象集合
      /// </summary>
      public List<GM_Seal> GetListByWhere(string strCondition)
      {
         List<GM_Seal> ret = new List<GM_Seal>();
         string sql = "SELECT  GMSE_ID,GMSE_Code,GMSE_Name,GMSE_CompanyCode,GMSE_DeptCode,GMSE_Intro,GMSE_iType,GMSE_Bak,GMSE_Owner,GMSE_Tel,GMSE_Cat,Stat,CreateDate,UpdateDate,DeleteDate FROM GM_Seal WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            GM_Seal gM_Seal = new GM_Seal();
            if (dr["GMSE_ID"] != DBNull.Value) gM_Seal.GMSE_ID = Convert.ToDecimal(dr["GMSE_ID"]);
            if (dr["GMSE_Code"] != DBNull.Value) gM_Seal.GMSE_Code = Convert.ToString(dr["GMSE_Code"]);
            if (dr["GMSE_Name"] != DBNull.Value) gM_Seal.GMSE_Name = Convert.ToString(dr["GMSE_Name"]);
            if (dr["GMSE_CompanyCode"] != DBNull.Value) gM_Seal.GMSE_CompanyCode = Convert.ToString(dr["GMSE_CompanyCode"]);
            if (dr["GMSE_DeptCode"] != DBNull.Value) gM_Seal.GMSE_DeptCode = Convert.ToString(dr["GMSE_DeptCode"]);
            if (dr["GMSE_Intro"] != DBNull.Value) gM_Seal.GMSE_Intro = Convert.ToString(dr["GMSE_Intro"]);
            if (dr["GMSE_iType"] != DBNull.Value) gM_Seal.GMSE_iType = Convert.ToString(dr["GMSE_iType"]);
            if (dr["GMSE_Bak"] != DBNull.Value) gM_Seal.GMSE_Bak = Convert.ToString(dr["GMSE_Bak"]);
            if (dr["GMSE_Owner"] != DBNull.Value) gM_Seal.GMSE_Owner = Convert.ToString(dr["GMSE_Owner"]);
            if (dr["GMSE_Tel"] != DBNull.Value) gM_Seal.GMSE_Tel = Convert.ToString(dr["GMSE_Tel"]);
            if (dr["GMSE_Cat"] != DBNull.Value) gM_Seal.GMSE_Cat = Convert.ToString(dr["GMSE_Cat"]);
            if (dr["Stat"] != DBNull.Value) gM_Seal.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) gM_Seal.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) gM_Seal.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) gM_Seal.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(gM_Seal);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的印章基本信息 GM_Seal对象(即:一条记录
      /// </summary>
      public List<GM_Seal> GetAll()
      {
         List<GM_Seal> ret = new List<GM_Seal>();
         string sql = "SELECT  GMSE_ID,GMSE_Code,GMSE_Name,GMSE_CompanyCode,GMSE_DeptCode,GMSE_Intro,GMSE_iType,GMSE_Bak,GMSE_Owner,GMSE_Tel,GMSE_Cat,Stat,CreateDate,UpdateDate,DeleteDate FROM GM_Seal where 1=1 AND ((Stat is null) or (Stat=0) ) order by GMSE_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            GM_Seal gM_Seal = new GM_Seal();
            if (dr["GMSE_ID"] != DBNull.Value) gM_Seal.GMSE_ID = Convert.ToDecimal(dr["GMSE_ID"]);
            if (dr["GMSE_Code"] != DBNull.Value) gM_Seal.GMSE_Code = Convert.ToString(dr["GMSE_Code"]);
            if (dr["GMSE_Name"] != DBNull.Value) gM_Seal.GMSE_Name = Convert.ToString(dr["GMSE_Name"]);
            if (dr["GMSE_CompanyCode"] != DBNull.Value) gM_Seal.GMSE_CompanyCode = Convert.ToString(dr["GMSE_CompanyCode"]);
            if (dr["GMSE_DeptCode"] != DBNull.Value) gM_Seal.GMSE_DeptCode = Convert.ToString(dr["GMSE_DeptCode"]);
            if (dr["GMSE_Intro"] != DBNull.Value) gM_Seal.GMSE_Intro = Convert.ToString(dr["GMSE_Intro"]);
            if (dr["GMSE_iType"] != DBNull.Value) gM_Seal.GMSE_iType = Convert.ToString(dr["GMSE_iType"]);
            if (dr["GMSE_Bak"] != DBNull.Value) gM_Seal.GMSE_Bak = Convert.ToString(dr["GMSE_Bak"]);
            if (dr["GMSE_Owner"] != DBNull.Value) gM_Seal.GMSE_Owner = Convert.ToString(dr["GMSE_Owner"]);
            if (dr["GMSE_Tel"] != DBNull.Value) gM_Seal.GMSE_Tel = Convert.ToString(dr["GMSE_Tel"]);
            if (dr["GMSE_Cat"] != DBNull.Value) gM_Seal.GMSE_Cat = Convert.ToString(dr["GMSE_Cat"]);
            if (dr["Stat"] != DBNull.Value) gM_Seal.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) gM_Seal.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) gM_Seal.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) gM_Seal.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(gM_Seal);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
