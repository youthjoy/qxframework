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
   public partial class ADOBse_StationMark
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_StationMark对象(即:一条记录)
      /// </summary>
      public int Add(Bse_StationMark bse_StationMark)
      {
         string sql = "INSERT INTO Bse_StationMark (Sta_Code,Sta_StationCode,Sta_Name,Sta_X,Sta_Y,Sta_Width,Sta_Height,Sta_Background,Sta_Color,Sta_Stat,Sta_Type,Sta_Bak,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Sta_Code,@Sta_StationCode,@Sta_Name,@Sta_X,@Sta_Y,@Sta_Width,@Sta_Height,@Sta_Background,@Sta_Color,@Sta_Stat,@Sta_Type,@Sta_Bak,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Code))
         {
            idb.AddParameter("@Sta_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Code", bse_StationMark.Sta_Code);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_StationCode))
         {
            idb.AddParameter("@Sta_StationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_StationCode", bse_StationMark.Sta_StationCode);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Name))
         {
            idb.AddParameter("@Sta_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Name", bse_StationMark.Sta_Name);
         }
         if (bse_StationMark.Sta_X == 0)
         {
            idb.AddParameter("@Sta_X", 0);
         }
         else
         {
            idb.AddParameter("@Sta_X", bse_StationMark.Sta_X);
         }
         if (bse_StationMark.Sta_Y == 0)
         {
            idb.AddParameter("@Sta_Y", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Y", bse_StationMark.Sta_Y);
         }
         if (bse_StationMark.Sta_Width == 0)
         {
            idb.AddParameter("@Sta_Width", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Width", bse_StationMark.Sta_Width);
         }
         if (bse_StationMark.Sta_Height == 0)
         {
            idb.AddParameter("@Sta_Height", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Height", bse_StationMark.Sta_Height);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Background))
         {
            idb.AddParameter("@Sta_Background", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Background", bse_StationMark.Sta_Background);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Color))
         {
            idb.AddParameter("@Sta_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Color", bse_StationMark.Sta_Color);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Stat))
         {
            idb.AddParameter("@Sta_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Stat", bse_StationMark.Sta_Stat);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Type))
         {
            idb.AddParameter("@Sta_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Type", bse_StationMark.Sta_Type);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Bak))
         {
            idb.AddParameter("@Sta_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Bak", bse_StationMark.Sta_Bak);
         }
         if (bse_StationMark.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_StationMark.Stat);
         }
         if (bse_StationMark.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_StationMark.CreateTime);
         }
         if (bse_StationMark.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_StationMark.UpdateTime);
         }
         if (bse_StationMark.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_StationMark.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_StationMark对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_StationMark bse_StationMark)
      {
         string sql = "INSERT INTO Bse_StationMark (Sta_Code,Sta_StationCode,Sta_Name,Sta_X,Sta_Y,Sta_Width,Sta_Height,Sta_Background,Sta_Color,Sta_Stat,Sta_Type,Sta_Bak,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Sta_Code,@Sta_StationCode,@Sta_Name,@Sta_X,@Sta_Y,@Sta_Width,@Sta_Height,@Sta_Background,@Sta_Color,@Sta_Stat,@Sta_Type,@Sta_Bak,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Code))
         {
            idb.AddParameter("@Sta_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Code", bse_StationMark.Sta_Code);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_StationCode))
         {
            idb.AddParameter("@Sta_StationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_StationCode", bse_StationMark.Sta_StationCode);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Name))
         {
            idb.AddParameter("@Sta_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Name", bse_StationMark.Sta_Name);
         }
         if (bse_StationMark.Sta_X == 0)
         {
            idb.AddParameter("@Sta_X", 0);
         }
         else
         {
            idb.AddParameter("@Sta_X", bse_StationMark.Sta_X);
         }
         if (bse_StationMark.Sta_Y == 0)
         {
            idb.AddParameter("@Sta_Y", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Y", bse_StationMark.Sta_Y);
         }
         if (bse_StationMark.Sta_Width == 0)
         {
            idb.AddParameter("@Sta_Width", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Width", bse_StationMark.Sta_Width);
         }
         if (bse_StationMark.Sta_Height == 0)
         {
            idb.AddParameter("@Sta_Height", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Height", bse_StationMark.Sta_Height);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Background))
         {
            idb.AddParameter("@Sta_Background", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Background", bse_StationMark.Sta_Background);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Color))
         {
            idb.AddParameter("@Sta_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Color", bse_StationMark.Sta_Color);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Stat))
         {
            idb.AddParameter("@Sta_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Stat", bse_StationMark.Sta_Stat);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Type))
         {
            idb.AddParameter("@Sta_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Type", bse_StationMark.Sta_Type);
         }
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Bak))
         {
            idb.AddParameter("@Sta_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Bak", bse_StationMark.Sta_Bak);
         }
         if (bse_StationMark.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_StationMark.Stat);
         }
         if (bse_StationMark.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_StationMark.CreateTime);
         }
         if (bse_StationMark.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_StationMark.UpdateTime);
         }
         if (bse_StationMark.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_StationMark.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_StationMark对象(即:一条记录
      /// </summary>
      public int Update(Bse_StationMark bse_StationMark)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_StationMark       SET ");
            if(bse_StationMark.Sta_Code_IsChanged){sbParameter.Append("Sta_Code=@Sta_Code, ");}
      if(bse_StationMark.Sta_StationCode_IsChanged){sbParameter.Append("Sta_StationCode=@Sta_StationCode, ");}
      if(bse_StationMark.Sta_Name_IsChanged){sbParameter.Append("Sta_Name=@Sta_Name, ");}
      if(bse_StationMark.Sta_X_IsChanged){sbParameter.Append("Sta_X=@Sta_X, ");}
      if(bse_StationMark.Sta_Y_IsChanged){sbParameter.Append("Sta_Y=@Sta_Y, ");}
      if(bse_StationMark.Sta_Width_IsChanged){sbParameter.Append("Sta_Width=@Sta_Width, ");}
      if(bse_StationMark.Sta_Height_IsChanged){sbParameter.Append("Sta_Height=@Sta_Height, ");}
      if(bse_StationMark.Sta_Background_IsChanged){sbParameter.Append("Sta_Background=@Sta_Background, ");}
      if(bse_StationMark.Sta_Color_IsChanged){sbParameter.Append("Sta_Color=@Sta_Color, ");}
      if(bse_StationMark.Sta_Stat_IsChanged){sbParameter.Append("Sta_Stat=@Sta_Stat, ");}
      if(bse_StationMark.Sta_Type_IsChanged){sbParameter.Append("Sta_Type=@Sta_Type, ");}
      if(bse_StationMark.Sta_Bak_IsChanged){sbParameter.Append("Sta_Bak=@Sta_Bak, ");}
      if(bse_StationMark.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_StationMark.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_StationMark.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_StationMark.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Sta_ID=@Sta_ID; " );
      string sql=sb.ToString();
         if(bse_StationMark.Sta_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Code))
         {
            idb.AddParameter("@Sta_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Code", bse_StationMark.Sta_Code);
         }
          }
         if(bse_StationMark.Sta_StationCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_StationCode))
         {
            idb.AddParameter("@Sta_StationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_StationCode", bse_StationMark.Sta_StationCode);
         }
          }
         if(bse_StationMark.Sta_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Name))
         {
            idb.AddParameter("@Sta_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Name", bse_StationMark.Sta_Name);
         }
          }
         if(bse_StationMark.Sta_X_IsChanged)
         {
         if (bse_StationMark.Sta_X == 0)
         {
            idb.AddParameter("@Sta_X", 0);
         }
         else
         {
            idb.AddParameter("@Sta_X", bse_StationMark.Sta_X);
         }
          }
         if(bse_StationMark.Sta_Y_IsChanged)
         {
         if (bse_StationMark.Sta_Y == 0)
         {
            idb.AddParameter("@Sta_Y", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Y", bse_StationMark.Sta_Y);
         }
          }
         if(bse_StationMark.Sta_Width_IsChanged)
         {
         if (bse_StationMark.Sta_Width == 0)
         {
            idb.AddParameter("@Sta_Width", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Width", bse_StationMark.Sta_Width);
         }
          }
         if(bse_StationMark.Sta_Height_IsChanged)
         {
         if (bse_StationMark.Sta_Height == 0)
         {
            idb.AddParameter("@Sta_Height", 0);
         }
         else
         {
            idb.AddParameter("@Sta_Height", bse_StationMark.Sta_Height);
         }
          }
         if(bse_StationMark.Sta_Background_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Background))
         {
            idb.AddParameter("@Sta_Background", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Background", bse_StationMark.Sta_Background);
         }
          }
         if(bse_StationMark.Sta_Color_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Color))
         {
            idb.AddParameter("@Sta_Color", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Color", bse_StationMark.Sta_Color);
         }
          }
         if(bse_StationMark.Sta_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Stat))
         {
            idb.AddParameter("@Sta_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Stat", bse_StationMark.Sta_Stat);
         }
          }
         if(bse_StationMark.Sta_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Type))
         {
            idb.AddParameter("@Sta_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Type", bse_StationMark.Sta_Type);
         }
          }
         if(bse_StationMark.Sta_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_StationMark.Sta_Bak))
         {
            idb.AddParameter("@Sta_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sta_Bak", bse_StationMark.Sta_Bak);
         }
          }
         if(bse_StationMark.Stat_IsChanged)
         {
         if (bse_StationMark.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_StationMark.Stat);
         }
          }
         if(bse_StationMark.CreateTime_IsChanged)
         {
         if (bse_StationMark.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_StationMark.CreateTime);
         }
          }
         if(bse_StationMark.UpdateTime_IsChanged)
         {
         if (bse_StationMark.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_StationMark.UpdateTime);
         }
          }
         if(bse_StationMark.DeleteTime_IsChanged)
         {
         if (bse_StationMark.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_StationMark.DeleteTime);
         }
          }

         idb.AddParameter("@Sta_ID", bse_StationMark.Sta_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_StationMark对象(即:一条记录
      /// </summary>
      public int Delete(decimal sta_ID)
      {
         string sql = "DELETE Bse_StationMark WHERE 1=1  AND Sta_ID=@Sta_ID ";
         idb.AddParameter("@Sta_ID", sta_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_StationMark对象(即:一条记录
      /// </summary>
      public Bse_StationMark GetByKey(decimal sta_ID)
      {
         Bse_StationMark bse_StationMark = new Bse_StationMark();
         string sql = "SELECT  Sta_ID,Sta_Code,Sta_StationCode,Sta_Name,Sta_X,Sta_Y,Sta_Width,Sta_Height,Sta_Background,Sta_Color,Sta_Stat,Sta_Type,Sta_Bak,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_StationMark WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Sta_ID=@Sta_ID ";
         idb.AddParameter("@Sta_ID", sta_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Sta_ID"] != DBNull.Value) bse_StationMark.Sta_ID = Convert.ToDecimal(dr["Sta_ID"]);
            if (dr["Sta_Code"] != DBNull.Value) bse_StationMark.Sta_Code = Convert.ToString(dr["Sta_Code"]);
            if (dr["Sta_StationCode"] != DBNull.Value) bse_StationMark.Sta_StationCode = Convert.ToString(dr["Sta_StationCode"]);
            if (dr["Sta_Name"] != DBNull.Value) bse_StationMark.Sta_Name = Convert.ToString(dr["Sta_Name"]);
            if (dr["Sta_X"] != DBNull.Value) bse_StationMark.Sta_X = Convert.ToDecimal(dr["Sta_X"]);
            if (dr["Sta_Y"] != DBNull.Value) bse_StationMark.Sta_Y = Convert.ToDecimal(dr["Sta_Y"]);
            if (dr["Sta_Width"] != DBNull.Value) bse_StationMark.Sta_Width = Convert.ToDecimal(dr["Sta_Width"]);
            if (dr["Sta_Height"] != DBNull.Value) bse_StationMark.Sta_Height = Convert.ToDecimal(dr["Sta_Height"]);
            if (dr["Sta_Background"] != DBNull.Value) bse_StationMark.Sta_Background = Convert.ToString(dr["Sta_Background"]);
            if (dr["Sta_Color"] != DBNull.Value) bse_StationMark.Sta_Color = Convert.ToString(dr["Sta_Color"]);
            if (dr["Sta_Stat"] != DBNull.Value) bse_StationMark.Sta_Stat = Convert.ToString(dr["Sta_Stat"]);
            if (dr["Sta_Type"] != DBNull.Value) bse_StationMark.Sta_Type = Convert.ToString(dr["Sta_Type"]);
            if (dr["Sta_Bak"] != DBNull.Value) bse_StationMark.Sta_Bak = Convert.ToString(dr["Sta_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_StationMark.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_StationMark.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_StationMark.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_StationMark.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_StationMark;
      }
      /// <summary>
      /// 获取指定的Bse_StationMark对象集合
      /// </summary>
      public List<Bse_StationMark> GetListByWhere(string strCondition)
      {
         List<Bse_StationMark> ret = new List<Bse_StationMark>();
         string sql = "SELECT  Sta_ID,Sta_Code,Sta_StationCode,Sta_Name,Sta_X,Sta_Y,Sta_Width,Sta_Height,Sta_Background,Sta_Color,Sta_Stat,Sta_Type,Sta_Bak,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_StationMark WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Sta_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_StationMark bse_StationMark = new Bse_StationMark();
            if (dr["Sta_ID"] != DBNull.Value) bse_StationMark.Sta_ID = Convert.ToDecimal(dr["Sta_ID"]);
            if (dr["Sta_Code"] != DBNull.Value) bse_StationMark.Sta_Code = Convert.ToString(dr["Sta_Code"]);
            if (dr["Sta_StationCode"] != DBNull.Value) bse_StationMark.Sta_StationCode = Convert.ToString(dr["Sta_StationCode"]);
            if (dr["Sta_Name"] != DBNull.Value) bse_StationMark.Sta_Name = Convert.ToString(dr["Sta_Name"]);
            if (dr["Sta_X"] != DBNull.Value) bse_StationMark.Sta_X = Convert.ToDecimal(dr["Sta_X"]);
            if (dr["Sta_Y"] != DBNull.Value) bse_StationMark.Sta_Y = Convert.ToDecimal(dr["Sta_Y"]);
            if (dr["Sta_Width"] != DBNull.Value) bse_StationMark.Sta_Width = Convert.ToDecimal(dr["Sta_Width"]);
            if (dr["Sta_Height"] != DBNull.Value) bse_StationMark.Sta_Height = Convert.ToDecimal(dr["Sta_Height"]);
            if (dr["Sta_Background"] != DBNull.Value) bse_StationMark.Sta_Background = Convert.ToString(dr["Sta_Background"]);
            if (dr["Sta_Color"] != DBNull.Value) bse_StationMark.Sta_Color = Convert.ToString(dr["Sta_Color"]);
            if (dr["Sta_Stat"] != DBNull.Value) bse_StationMark.Sta_Stat = Convert.ToString(dr["Sta_Stat"]);
            if (dr["Sta_Type"] != DBNull.Value) bse_StationMark.Sta_Type = Convert.ToString(dr["Sta_Type"]);
            if (dr["Sta_Bak"] != DBNull.Value) bse_StationMark.Sta_Bak = Convert.ToString(dr["Sta_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_StationMark.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_StationMark.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_StationMark.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_StationMark.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_StationMark);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_StationMark对象(即:一条记录
      /// </summary>
      public List<Bse_StationMark> GetAll()
      {
         List<Bse_StationMark> ret = new List<Bse_StationMark>();
         string sql = "SELECT  Sta_ID,Sta_Code,Sta_StationCode,Sta_Name,Sta_X,Sta_Y,Sta_Width,Sta_Height,Sta_Background,Sta_Color,Sta_Stat,Sta_Type,Sta_Bak,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_StationMark where 1=1 AND ((Stat is null) or (Stat=0) ) order by Sta_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_StationMark bse_StationMark = new Bse_StationMark();
            if (dr["Sta_ID"] != DBNull.Value) bse_StationMark.Sta_ID = Convert.ToDecimal(dr["Sta_ID"]);
            if (dr["Sta_Code"] != DBNull.Value) bse_StationMark.Sta_Code = Convert.ToString(dr["Sta_Code"]);
            if (dr["Sta_StationCode"] != DBNull.Value) bse_StationMark.Sta_StationCode = Convert.ToString(dr["Sta_StationCode"]);
            if (dr["Sta_Name"] != DBNull.Value) bse_StationMark.Sta_Name = Convert.ToString(dr["Sta_Name"]);
            if (dr["Sta_X"] != DBNull.Value) bse_StationMark.Sta_X = Convert.ToDecimal(dr["Sta_X"]);
            if (dr["Sta_Y"] != DBNull.Value) bse_StationMark.Sta_Y = Convert.ToDecimal(dr["Sta_Y"]);
            if (dr["Sta_Width"] != DBNull.Value) bse_StationMark.Sta_Width = Convert.ToDecimal(dr["Sta_Width"]);
            if (dr["Sta_Height"] != DBNull.Value) bse_StationMark.Sta_Height = Convert.ToDecimal(dr["Sta_Height"]);
            if (dr["Sta_Background"] != DBNull.Value) bse_StationMark.Sta_Background = Convert.ToString(dr["Sta_Background"]);
            if (dr["Sta_Color"] != DBNull.Value) bse_StationMark.Sta_Color = Convert.ToString(dr["Sta_Color"]);
            if (dr["Sta_Stat"] != DBNull.Value) bse_StationMark.Sta_Stat = Convert.ToString(dr["Sta_Stat"]);
            if (dr["Sta_Type"] != DBNull.Value) bse_StationMark.Sta_Type = Convert.ToString(dr["Sta_Type"]);
            if (dr["Sta_Bak"] != DBNull.Value) bse_StationMark.Sta_Bak = Convert.ToString(dr["Sta_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_StationMark.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_StationMark.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_StationMark.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_StationMark.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_StationMark);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
