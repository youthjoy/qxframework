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
   ///    
   /// </summary>
   [Serializable]
   public partial class ADOBse_Area
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加    Bse_Area对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Area bse_Area)
      {
         string sql = "INSERT INTO Bse_Area (Area_Code,Area_Mark,Area_Name,Area_Addr,Area_PCode,Area_PName,SN_Bak,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Area_Code,@Area_Mark,@Area_Name,@Area_Addr,@Area_PCode,@Area_PName,@SN_Bak,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_Area.Area_Code))
         {
            idb.AddParameter("@Area_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Code", bse_Area.Area_Code);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_Mark))
         {
            idb.AddParameter("@Area_Mark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Mark", bse_Area.Area_Mark);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_Name))
         {
            idb.AddParameter("@Area_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Name", bse_Area.Area_Name);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_Addr))
         {
            idb.AddParameter("@Area_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Addr", bse_Area.Area_Addr);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_PCode))
         {
            idb.AddParameter("@Area_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_PCode", bse_Area.Area_PCode);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_PName))
         {
            idb.AddParameter("@Area_PName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_PName", bse_Area.Area_PName);
         }
         if (string.IsNullOrEmpty(bse_Area.SN_Bak))
         {
            idb.AddParameter("@SN_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Bak", bse_Area.SN_Bak);
         }
         if (bse_Area.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Area.Stat);
         }
         if (bse_Area.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Area.CreateTime);
         }
         if (bse_Area.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Area.UpdateTime);
         }
         if (bse_Area.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Area.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加    Bse_Area对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Area bse_Area)
      {
         string sql = "INSERT INTO Bse_Area (Area_Code,Area_Mark,Area_Name,Area_Addr,Area_PCode,Area_PName,SN_Bak,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Area_Code,@Area_Mark,@Area_Name,@Area_Addr,@Area_PCode,@Area_PName,@SN_Bak,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Area.Area_Code))
         {
            idb.AddParameter("@Area_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Code", bse_Area.Area_Code);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_Mark))
         {
            idb.AddParameter("@Area_Mark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Mark", bse_Area.Area_Mark);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_Name))
         {
            idb.AddParameter("@Area_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Name", bse_Area.Area_Name);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_Addr))
         {
            idb.AddParameter("@Area_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Addr", bse_Area.Area_Addr);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_PCode))
         {
            idb.AddParameter("@Area_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_PCode", bse_Area.Area_PCode);
         }
         if (string.IsNullOrEmpty(bse_Area.Area_PName))
         {
            idb.AddParameter("@Area_PName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_PName", bse_Area.Area_PName);
         }
         if (string.IsNullOrEmpty(bse_Area.SN_Bak))
         {
            idb.AddParameter("@SN_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Bak", bse_Area.SN_Bak);
         }
         if (bse_Area.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Area.Stat);
         }
         if (bse_Area.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Area.CreateTime);
         }
         if (bse_Area.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Area.UpdateTime);
         }
         if (bse_Area.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Area.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新    Bse_Area对象(即:一条记录
      /// </summary>
      public int Update(Bse_Area bse_Area)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Area       SET ");
            if(bse_Area.Area_Code_IsChanged){sbParameter.Append("Area_Code=@Area_Code, ");}
      if(bse_Area.Area_Mark_IsChanged){sbParameter.Append("Area_Mark=@Area_Mark, ");}
      if(bse_Area.Area_Name_IsChanged){sbParameter.Append("Area_Name=@Area_Name, ");}
      if(bse_Area.Area_Addr_IsChanged){sbParameter.Append("Area_Addr=@Area_Addr, ");}
      if(bse_Area.Area_PCode_IsChanged){sbParameter.Append("Area_PCode=@Area_PCode, ");}
      if(bse_Area.Area_PName_IsChanged){sbParameter.Append("Area_PName=@Area_PName, ");}
      if(bse_Area.SN_Bak_IsChanged){sbParameter.Append("SN_Bak=@SN_Bak, ");}
      if(bse_Area.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Area.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_Area.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_Area.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Area_ID=@Area_ID; " );
      string sql=sb.ToString();
         if(bse_Area.Area_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Area.Area_Code))
         {
            idb.AddParameter("@Area_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Code", bse_Area.Area_Code);
         }
          }
         if(bse_Area.Area_Mark_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Area.Area_Mark))
         {
            idb.AddParameter("@Area_Mark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Mark", bse_Area.Area_Mark);
         }
          }
         if(bse_Area.Area_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Area.Area_Name))
         {
            idb.AddParameter("@Area_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Name", bse_Area.Area_Name);
         }
          }
         if(bse_Area.Area_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Area.Area_Addr))
         {
            idb.AddParameter("@Area_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_Addr", bse_Area.Area_Addr);
         }
          }
         if(bse_Area.Area_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Area.Area_PCode))
         {
            idb.AddParameter("@Area_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_PCode", bse_Area.Area_PCode);
         }
          }
         if(bse_Area.Area_PName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Area.Area_PName))
         {
            idb.AddParameter("@Area_PName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Area_PName", bse_Area.Area_PName);
         }
          }
         if(bse_Area.SN_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Area.SN_Bak))
         {
            idb.AddParameter("@SN_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SN_Bak", bse_Area.SN_Bak);
         }
          }
         if(bse_Area.Stat_IsChanged)
         {
         if (bse_Area.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Area.Stat);
         }
          }
         if(bse_Area.CreateTime_IsChanged)
         {
         if (bse_Area.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Area.CreateTime);
         }
          }
         if(bse_Area.UpdateTime_IsChanged)
         {
         if (bse_Area.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Area.UpdateTime);
         }
          }
         if(bse_Area.DeleteTime_IsChanged)
         {
         if (bse_Area.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Area.DeleteTime);
         }
          }

         idb.AddParameter("@Area_ID", bse_Area.Area_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除    Bse_Area对象(即:一条记录
      /// </summary>
      public int Delete(decimal area_ID)
      {
         string sql = "DELETE Bse_Area WHERE 1=1  AND Area_ID=@Area_ID ";
         idb.AddParameter("@Area_ID", area_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的    Bse_Area对象(即:一条记录
      /// </summary>
      public Bse_Area GetByKey(decimal area_ID)
      {
         Bse_Area bse_Area = new Bse_Area();
         string sql = "SELECT  Area_ID,Area_Code,Area_Mark,Area_Name,Area_Addr,Area_PCode,Area_PName,SN_Bak,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Area WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Area_ID=@Area_ID ";
         idb.AddParameter("@Area_ID", area_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Area_ID"] != DBNull.Value) bse_Area.Area_ID = Convert.ToDecimal(dr["Area_ID"]);
            if (dr["Area_Code"] != DBNull.Value) bse_Area.Area_Code = Convert.ToString(dr["Area_Code"]);
            if (dr["Area_Mark"] != DBNull.Value) bse_Area.Area_Mark = Convert.ToString(dr["Area_Mark"]);
            if (dr["Area_Name"] != DBNull.Value) bse_Area.Area_Name = Convert.ToString(dr["Area_Name"]);
            if (dr["Area_Addr"] != DBNull.Value) bse_Area.Area_Addr = Convert.ToString(dr["Area_Addr"]);
            if (dr["Area_PCode"] != DBNull.Value) bse_Area.Area_PCode = Convert.ToString(dr["Area_PCode"]);
            if (dr["Area_PName"] != DBNull.Value) bse_Area.Area_PName = Convert.ToString(dr["Area_PName"]);
            if (dr["SN_Bak"] != DBNull.Value) bse_Area.SN_Bak = Convert.ToString(dr["SN_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_Area.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Area.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Area.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Area.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Area;
      }
      /// <summary>
      /// 获取指定的    Bse_Area对象集合
      /// </summary>
      public List<Bse_Area> GetListByWhere(string strCondition)
      {
         List<Bse_Area> ret = new List<Bse_Area>();
         string sql = "SELECT  Area_ID,Area_Code,Area_Mark,Area_Name,Area_Addr,Area_PCode,Area_PName,SN_Bak,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Area WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Area_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Area bse_Area = new Bse_Area();
            if (dr["Area_ID"] != DBNull.Value) bse_Area.Area_ID = Convert.ToDecimal(dr["Area_ID"]);
            if (dr["Area_Code"] != DBNull.Value) bse_Area.Area_Code = Convert.ToString(dr["Area_Code"]);
            if (dr["Area_Mark"] != DBNull.Value) bse_Area.Area_Mark = Convert.ToString(dr["Area_Mark"]);
            if (dr["Area_Name"] != DBNull.Value) bse_Area.Area_Name = Convert.ToString(dr["Area_Name"]);
            if (dr["Area_Addr"] != DBNull.Value) bse_Area.Area_Addr = Convert.ToString(dr["Area_Addr"]);
            if (dr["Area_PCode"] != DBNull.Value) bse_Area.Area_PCode = Convert.ToString(dr["Area_PCode"]);
            if (dr["Area_PName"] != DBNull.Value) bse_Area.Area_PName = Convert.ToString(dr["Area_PName"]);
            if (dr["SN_Bak"] != DBNull.Value) bse_Area.SN_Bak = Convert.ToString(dr["SN_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_Area.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Area.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Area.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Area.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Area);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的    Bse_Area对象(即:一条记录
      /// </summary>
      public List<Bse_Area> GetAll()
      {
         List<Bse_Area> ret = new List<Bse_Area>();
         string sql = "SELECT  Area_ID,Area_Code,Area_Mark,Area_Name,Area_Addr,Area_PCode,Area_PName,SN_Bak,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Area where 1=1 AND ((Stat is null) or (Stat=0) ) order by Area_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Area bse_Area = new Bse_Area();
            if (dr["Area_ID"] != DBNull.Value) bse_Area.Area_ID = Convert.ToDecimal(dr["Area_ID"]);
            if (dr["Area_Code"] != DBNull.Value) bse_Area.Area_Code = Convert.ToString(dr["Area_Code"]);
            if (dr["Area_Mark"] != DBNull.Value) bse_Area.Area_Mark = Convert.ToString(dr["Area_Mark"]);
            if (dr["Area_Name"] != DBNull.Value) bse_Area.Area_Name = Convert.ToString(dr["Area_Name"]);
            if (dr["Area_Addr"] != DBNull.Value) bse_Area.Area_Addr = Convert.ToString(dr["Area_Addr"]);
            if (dr["Area_PCode"] != DBNull.Value) bse_Area.Area_PCode = Convert.ToString(dr["Area_PCode"]);
            if (dr["Area_PName"] != DBNull.Value) bse_Area.Area_PName = Convert.ToString(dr["Area_PName"]);
            if (dr["SN_Bak"] != DBNull.Value) bse_Area.SN_Bak = Convert.ToString(dr["SN_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_Area.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Area.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Area.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Area.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Area);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
