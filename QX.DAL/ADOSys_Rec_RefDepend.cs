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
   /// 单据参考依赖关系
   /// </summary>
   [Serializable]
   public partial class ADOSys_Rec_RefDepend
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加单据参考依赖关系 Sys_Rec_RefDepend对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Rec_RefDepend sys_Rec_RefDepend)
      {
         string sql = "INSERT INTO Sys_Rec_RefDepend (RefDepend_Code,RefDepend_Type,RefDepend_Object,RefDepend_ObjectName,RefDepend_ShowMain,RefDepend_ShowOther,RefDepend_ShowName,RefDepend_UDEF1,RefDepend_UDEF2,RefDepend_UDEF3,RefDepend_UDEF4,RefDepend_UDEF5,Stat,RefDepend_UDEF6,RefDepend_UDEF7,RefDepend_UDEF8,RefDepend_UDEF9,RefDepend_UDEF10,RefDepend_ConfFlag,RefDepend_UDEF11,RefDepend_UDEF12,RefDepend_UDEF13,RefDepend_UDEF14,RefDepend_UDEF15,RefDepend_UDEF16,RefDepend_UDEF17,RefDepend_UDEF18,RefDepend_UDEF19,RefDepend_UDEF20) VALUES (@RefDepend_Code,@RefDepend_Type,@RefDepend_Object,@RefDepend_ObjectName,@RefDepend_ShowMain,@RefDepend_ShowOther,@RefDepend_ShowName,@RefDepend_UDEF1,@RefDepend_UDEF2,@RefDepend_UDEF3,@RefDepend_UDEF4,@RefDepend_UDEF5,@Stat,@RefDepend_UDEF6,@RefDepend_UDEF7,@RefDepend_UDEF8,@RefDepend_UDEF9,@RefDepend_UDEF10,@RefDepend_ConfFlag,@RefDepend_UDEF11,@RefDepend_UDEF12,@RefDepend_UDEF13,@RefDepend_UDEF14,@RefDepend_UDEF15,@RefDepend_UDEF16,@RefDepend_UDEF17,@RefDepend_UDEF18,@RefDepend_UDEF19,@RefDepend_UDEF20)";
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Code))
         {
            idb.AddParameter("@RefDepend_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Code", sys_Rec_RefDepend.RefDepend_Code);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Type))
         {
            idb.AddParameter("@RefDepend_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Type", sys_Rec_RefDepend.RefDepend_Type);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Object))
         {
            idb.AddParameter("@RefDepend_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Object", sys_Rec_RefDepend.RefDepend_Object);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ObjectName))
         {
            idb.AddParameter("@RefDepend_ObjectName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ObjectName", sys_Rec_RefDepend.RefDepend_ObjectName);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowMain))
         {
            idb.AddParameter("@RefDepend_ShowMain", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowMain", sys_Rec_RefDepend.RefDepend_ShowMain);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowOther))
         {
            idb.AddParameter("@RefDepend_ShowOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowOther", sys_Rec_RefDepend.RefDepend_ShowOther);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowName))
         {
            idb.AddParameter("@RefDepend_ShowName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowName", sys_Rec_RefDepend.RefDepend_ShowName);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF1))
         {
            idb.AddParameter("@RefDepend_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF1", sys_Rec_RefDepend.RefDepend_UDEF1);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF2))
         {
            idb.AddParameter("@RefDepend_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF2", sys_Rec_RefDepend.RefDepend_UDEF2);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF3))
         {
            idb.AddParameter("@RefDepend_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF3", sys_Rec_RefDepend.RefDepend_UDEF3);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF4))
         {
            idb.AddParameter("@RefDepend_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF4", sys_Rec_RefDepend.RefDepend_UDEF4);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF5))
         {
            idb.AddParameter("@RefDepend_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF5", sys_Rec_RefDepend.RefDepend_UDEF5);
         }
         if (sys_Rec_RefDepend.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Rec_RefDepend.Stat);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF6))
         {
            idb.AddParameter("@RefDepend_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF6", sys_Rec_RefDepend.RefDepend_UDEF6);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF7))
         {
            idb.AddParameter("@RefDepend_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF7", sys_Rec_RefDepend.RefDepend_UDEF7);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF8))
         {
            idb.AddParameter("@RefDepend_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF8", sys_Rec_RefDepend.RefDepend_UDEF8);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF9))
         {
            idb.AddParameter("@RefDepend_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF9", sys_Rec_RefDepend.RefDepend_UDEF9);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF10))
         {
            idb.AddParameter("@RefDepend_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF10", sys_Rec_RefDepend.RefDepend_UDEF10);
         }
         if (sys_Rec_RefDepend.RefDepend_ConfFlag == 0)
         {
            idb.AddParameter("@RefDepend_ConfFlag", 0);
         }
         else
         {
            idb.AddParameter("@RefDepend_ConfFlag", sys_Rec_RefDepend.RefDepend_ConfFlag);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF11))
         {
            idb.AddParameter("@RefDepend_UDEF11", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF11", sys_Rec_RefDepend.RefDepend_UDEF11);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF12))
         {
            idb.AddParameter("@RefDepend_UDEF12", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF12", sys_Rec_RefDepend.RefDepend_UDEF12);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF13))
         {
            idb.AddParameter("@RefDepend_UDEF13", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF13", sys_Rec_RefDepend.RefDepend_UDEF13);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF14))
         {
            idb.AddParameter("@RefDepend_UDEF14", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF14", sys_Rec_RefDepend.RefDepend_UDEF14);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF15))
         {
            idb.AddParameter("@RefDepend_UDEF15", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF15", sys_Rec_RefDepend.RefDepend_UDEF15);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF16))
         {
            idb.AddParameter("@RefDepend_UDEF16", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF16", sys_Rec_RefDepend.RefDepend_UDEF16);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF17))
         {
            idb.AddParameter("@RefDepend_UDEF17", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF17", sys_Rec_RefDepend.RefDepend_UDEF17);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF18))
         {
            idb.AddParameter("@RefDepend_UDEF18", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF18", sys_Rec_RefDepend.RefDepend_UDEF18);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF19))
         {
            idb.AddParameter("@RefDepend_UDEF19", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF19", sys_Rec_RefDepend.RefDepend_UDEF19);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF20))
         {
            idb.AddParameter("@RefDepend_UDEF20", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF20", sys_Rec_RefDepend.RefDepend_UDEF20);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加单据参考依赖关系 Sys_Rec_RefDepend对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Rec_RefDepend sys_Rec_RefDepend)
      {
         string sql = "INSERT INTO Sys_Rec_RefDepend (RefDepend_Code,RefDepend_Type,RefDepend_Object,RefDepend_ObjectName,RefDepend_ShowMain,RefDepend_ShowOther,RefDepend_ShowName,RefDepend_UDEF1,RefDepend_UDEF2,RefDepend_UDEF3,RefDepend_UDEF4,RefDepend_UDEF5,Stat,RefDepend_UDEF6,RefDepend_UDEF7,RefDepend_UDEF8,RefDepend_UDEF9,RefDepend_UDEF10,RefDepend_ConfFlag,RefDepend_UDEF11,RefDepend_UDEF12,RefDepend_UDEF13,RefDepend_UDEF14,RefDepend_UDEF15,RefDepend_UDEF16,RefDepend_UDEF17,RefDepend_UDEF18,RefDepend_UDEF19,RefDepend_UDEF20) VALUES (@RefDepend_Code,@RefDepend_Type,@RefDepend_Object,@RefDepend_ObjectName,@RefDepend_ShowMain,@RefDepend_ShowOther,@RefDepend_ShowName,@RefDepend_UDEF1,@RefDepend_UDEF2,@RefDepend_UDEF3,@RefDepend_UDEF4,@RefDepend_UDEF5,@Stat,@RefDepend_UDEF6,@RefDepend_UDEF7,@RefDepend_UDEF8,@RefDepend_UDEF9,@RefDepend_UDEF10,@RefDepend_ConfFlag,@RefDepend_UDEF11,@RefDepend_UDEF12,@RefDepend_UDEF13,@RefDepend_UDEF14,@RefDepend_UDEF15,@RefDepend_UDEF16,@RefDepend_UDEF17,@RefDepend_UDEF18,@RefDepend_UDEF19,@RefDepend_UDEF20);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Code))
         {
            idb.AddParameter("@RefDepend_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Code", sys_Rec_RefDepend.RefDepend_Code);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Type))
         {
            idb.AddParameter("@RefDepend_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Type", sys_Rec_RefDepend.RefDepend_Type);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Object))
         {
            idb.AddParameter("@RefDepend_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Object", sys_Rec_RefDepend.RefDepend_Object);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ObjectName))
         {
            idb.AddParameter("@RefDepend_ObjectName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ObjectName", sys_Rec_RefDepend.RefDepend_ObjectName);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowMain))
         {
            idb.AddParameter("@RefDepend_ShowMain", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowMain", sys_Rec_RefDepend.RefDepend_ShowMain);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowOther))
         {
            idb.AddParameter("@RefDepend_ShowOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowOther", sys_Rec_RefDepend.RefDepend_ShowOther);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowName))
         {
            idb.AddParameter("@RefDepend_ShowName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowName", sys_Rec_RefDepend.RefDepend_ShowName);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF1))
         {
            idb.AddParameter("@RefDepend_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF1", sys_Rec_RefDepend.RefDepend_UDEF1);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF2))
         {
            idb.AddParameter("@RefDepend_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF2", sys_Rec_RefDepend.RefDepend_UDEF2);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF3))
         {
            idb.AddParameter("@RefDepend_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF3", sys_Rec_RefDepend.RefDepend_UDEF3);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF4))
         {
            idb.AddParameter("@RefDepend_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF4", sys_Rec_RefDepend.RefDepend_UDEF4);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF5))
         {
            idb.AddParameter("@RefDepend_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF5", sys_Rec_RefDepend.RefDepend_UDEF5);
         }
         if (sys_Rec_RefDepend.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Rec_RefDepend.Stat);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF6))
         {
            idb.AddParameter("@RefDepend_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF6", sys_Rec_RefDepend.RefDepend_UDEF6);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF7))
         {
            idb.AddParameter("@RefDepend_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF7", sys_Rec_RefDepend.RefDepend_UDEF7);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF8))
         {
            idb.AddParameter("@RefDepend_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF8", sys_Rec_RefDepend.RefDepend_UDEF8);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF9))
         {
            idb.AddParameter("@RefDepend_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF9", sys_Rec_RefDepend.RefDepend_UDEF9);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF10))
         {
            idb.AddParameter("@RefDepend_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF10", sys_Rec_RefDepend.RefDepend_UDEF10);
         }
         if (sys_Rec_RefDepend.RefDepend_ConfFlag == 0)
         {
            idb.AddParameter("@RefDepend_ConfFlag", 0);
         }
         else
         {
            idb.AddParameter("@RefDepend_ConfFlag", sys_Rec_RefDepend.RefDepend_ConfFlag);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF11))
         {
            idb.AddParameter("@RefDepend_UDEF11", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF11", sys_Rec_RefDepend.RefDepend_UDEF11);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF12))
         {
            idb.AddParameter("@RefDepend_UDEF12", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF12", sys_Rec_RefDepend.RefDepend_UDEF12);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF13))
         {
            idb.AddParameter("@RefDepend_UDEF13", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF13", sys_Rec_RefDepend.RefDepend_UDEF13);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF14))
         {
            idb.AddParameter("@RefDepend_UDEF14", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF14", sys_Rec_RefDepend.RefDepend_UDEF14);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF15))
         {
            idb.AddParameter("@RefDepend_UDEF15", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF15", sys_Rec_RefDepend.RefDepend_UDEF15);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF16))
         {
            idb.AddParameter("@RefDepend_UDEF16", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF16", sys_Rec_RefDepend.RefDepend_UDEF16);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF17))
         {
            idb.AddParameter("@RefDepend_UDEF17", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF17", sys_Rec_RefDepend.RefDepend_UDEF17);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF18))
         {
            idb.AddParameter("@RefDepend_UDEF18", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF18", sys_Rec_RefDepend.RefDepend_UDEF18);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF19))
         {
            idb.AddParameter("@RefDepend_UDEF19", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF19", sys_Rec_RefDepend.RefDepend_UDEF19);
         }
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF20))
         {
            idb.AddParameter("@RefDepend_UDEF20", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF20", sys_Rec_RefDepend.RefDepend_UDEF20);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新单据参考依赖关系 Sys_Rec_RefDepend对象(即:一条记录
      /// </summary>
      public int Update(Sys_Rec_RefDepend sys_Rec_RefDepend)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Rec_RefDepend       SET ");
            if(sys_Rec_RefDepend.RefDepend_Code_IsChanged){sbParameter.Append("RefDepend_Code=@RefDepend_Code, ");}
      if(sys_Rec_RefDepend.RefDepend_Type_IsChanged){sbParameter.Append("RefDepend_Type=@RefDepend_Type, ");}
      if(sys_Rec_RefDepend.RefDepend_Object_IsChanged){sbParameter.Append("RefDepend_Object=@RefDepend_Object, ");}
      if(sys_Rec_RefDepend.RefDepend_ObjectName_IsChanged){sbParameter.Append("RefDepend_ObjectName=@RefDepend_ObjectName, ");}
      if(sys_Rec_RefDepend.RefDepend_ShowMain_IsChanged){sbParameter.Append("RefDepend_ShowMain=@RefDepend_ShowMain, ");}
      if(sys_Rec_RefDepend.RefDepend_ShowOther_IsChanged){sbParameter.Append("RefDepend_ShowOther=@RefDepend_ShowOther, ");}
      if(sys_Rec_RefDepend.RefDepend_ShowName_IsChanged){sbParameter.Append("RefDepend_ShowName=@RefDepend_ShowName, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF1_IsChanged){sbParameter.Append("RefDepend_UDEF1=@RefDepend_UDEF1, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF2_IsChanged){sbParameter.Append("RefDepend_UDEF2=@RefDepend_UDEF2, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF3_IsChanged){sbParameter.Append("RefDepend_UDEF3=@RefDepend_UDEF3, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF4_IsChanged){sbParameter.Append("RefDepend_UDEF4=@RefDepend_UDEF4, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF5_IsChanged){sbParameter.Append("RefDepend_UDEF5=@RefDepend_UDEF5, ");}
      if(sys_Rec_RefDepend.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF6_IsChanged){sbParameter.Append("RefDepend_UDEF6=@RefDepend_UDEF6, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF7_IsChanged){sbParameter.Append("RefDepend_UDEF7=@RefDepend_UDEF7, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF8_IsChanged){sbParameter.Append("RefDepend_UDEF8=@RefDepend_UDEF8, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF9_IsChanged){sbParameter.Append("RefDepend_UDEF9=@RefDepend_UDEF9, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF10_IsChanged){sbParameter.Append("RefDepend_UDEF10=@RefDepend_UDEF10, ");}
      if(sys_Rec_RefDepend.RefDepend_ConfFlag_IsChanged){sbParameter.Append("RefDepend_ConfFlag=@RefDepend_ConfFlag, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF11_IsChanged){sbParameter.Append("RefDepend_UDEF11=@RefDepend_UDEF11, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF12_IsChanged){sbParameter.Append("RefDepend_UDEF12=@RefDepend_UDEF12, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF13_IsChanged){sbParameter.Append("RefDepend_UDEF13=@RefDepend_UDEF13, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF14_IsChanged){sbParameter.Append("RefDepend_UDEF14=@RefDepend_UDEF14, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF15_IsChanged){sbParameter.Append("RefDepend_UDEF15=@RefDepend_UDEF15, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF16_IsChanged){sbParameter.Append("RefDepend_UDEF16=@RefDepend_UDEF16, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF17_IsChanged){sbParameter.Append("RefDepend_UDEF17=@RefDepend_UDEF17, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF18_IsChanged){sbParameter.Append("RefDepend_UDEF18=@RefDepend_UDEF18, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF19_IsChanged){sbParameter.Append("RefDepend_UDEF19=@RefDepend_UDEF19, ");}
      if(sys_Rec_RefDepend.RefDepend_UDEF20_IsChanged){sbParameter.Append("RefDepend_UDEF20=@RefDepend_UDEF20 ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RefDepend_ID=@RefDepend_ID; " );
      string sql=sb.ToString();
         if(sys_Rec_RefDepend.RefDepend_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Code))
         {
            idb.AddParameter("@RefDepend_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Code", sys_Rec_RefDepend.RefDepend_Code);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Type))
         {
            idb.AddParameter("@RefDepend_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Type", sys_Rec_RefDepend.RefDepend_Type);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_Object_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_Object))
         {
            idb.AddParameter("@RefDepend_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_Object", sys_Rec_RefDepend.RefDepend_Object);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_ObjectName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ObjectName))
         {
            idb.AddParameter("@RefDepend_ObjectName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ObjectName", sys_Rec_RefDepend.RefDepend_ObjectName);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_ShowMain_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowMain))
         {
            idb.AddParameter("@RefDepend_ShowMain", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowMain", sys_Rec_RefDepend.RefDepend_ShowMain);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_ShowOther_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowOther))
         {
            idb.AddParameter("@RefDepend_ShowOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowOther", sys_Rec_RefDepend.RefDepend_ShowOther);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_ShowName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_ShowName))
         {
            idb.AddParameter("@RefDepend_ShowName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_ShowName", sys_Rec_RefDepend.RefDepend_ShowName);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF1))
         {
            idb.AddParameter("@RefDepend_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF1", sys_Rec_RefDepend.RefDepend_UDEF1);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF2))
         {
            idb.AddParameter("@RefDepend_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF2", sys_Rec_RefDepend.RefDepend_UDEF2);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF3))
         {
            idb.AddParameter("@RefDepend_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF3", sys_Rec_RefDepend.RefDepend_UDEF3);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF4))
         {
            idb.AddParameter("@RefDepend_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF4", sys_Rec_RefDepend.RefDepend_UDEF4);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF5))
         {
            idb.AddParameter("@RefDepend_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF5", sys_Rec_RefDepend.RefDepend_UDEF5);
         }
          }
         if(sys_Rec_RefDepend.Stat_IsChanged)
         {
         if (sys_Rec_RefDepend.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Rec_RefDepend.Stat);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF6))
         {
            idb.AddParameter("@RefDepend_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF6", sys_Rec_RefDepend.RefDepend_UDEF6);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF7))
         {
            idb.AddParameter("@RefDepend_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF7", sys_Rec_RefDepend.RefDepend_UDEF7);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF8))
         {
            idb.AddParameter("@RefDepend_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF8", sys_Rec_RefDepend.RefDepend_UDEF8);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF9))
         {
            idb.AddParameter("@RefDepend_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF9", sys_Rec_RefDepend.RefDepend_UDEF9);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF10))
         {
            idb.AddParameter("@RefDepend_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF10", sys_Rec_RefDepend.RefDepend_UDEF10);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_ConfFlag_IsChanged)
         {
         if (sys_Rec_RefDepend.RefDepend_ConfFlag == 0)
         {
            idb.AddParameter("@RefDepend_ConfFlag", 0);
         }
         else
         {
            idb.AddParameter("@RefDepend_ConfFlag", sys_Rec_RefDepend.RefDepend_ConfFlag);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF11_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF11))
         {
            idb.AddParameter("@RefDepend_UDEF11", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF11", sys_Rec_RefDepend.RefDepend_UDEF11);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF12_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF12))
         {
            idb.AddParameter("@RefDepend_UDEF12", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF12", sys_Rec_RefDepend.RefDepend_UDEF12);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF13_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF13))
         {
            idb.AddParameter("@RefDepend_UDEF13", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF13", sys_Rec_RefDepend.RefDepend_UDEF13);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF14_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF14))
         {
            idb.AddParameter("@RefDepend_UDEF14", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF14", sys_Rec_RefDepend.RefDepend_UDEF14);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF15_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF15))
         {
            idb.AddParameter("@RefDepend_UDEF15", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF15", sys_Rec_RefDepend.RefDepend_UDEF15);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF16_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF16))
         {
            idb.AddParameter("@RefDepend_UDEF16", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF16", sys_Rec_RefDepend.RefDepend_UDEF16);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF17_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF17))
         {
            idb.AddParameter("@RefDepend_UDEF17", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF17", sys_Rec_RefDepend.RefDepend_UDEF17);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF18_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF18))
         {
            idb.AddParameter("@RefDepend_UDEF18", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF18", sys_Rec_RefDepend.RefDepend_UDEF18);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF19_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF19))
         {
            idb.AddParameter("@RefDepend_UDEF19", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF19", sys_Rec_RefDepend.RefDepend_UDEF19);
         }
          }
         if(sys_Rec_RefDepend.RefDepend_UDEF20_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Rec_RefDepend.RefDepend_UDEF20))
         {
            idb.AddParameter("@RefDepend_UDEF20", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RefDepend_UDEF20", sys_Rec_RefDepend.RefDepend_UDEF20);
         }
          }

         idb.AddParameter("@RefDepend_ID", sys_Rec_RefDepend.RefDepend_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除单据参考依赖关系 Sys_Rec_RefDepend对象(即:一条记录
      /// </summary>
      public int Delete(decimal refDepend_ID)
      {
         string sql = "DELETE Sys_Rec_RefDepend WHERE 1=1  AND RefDepend_ID=@RefDepend_ID ";
         idb.AddParameter("@RefDepend_ID", refDepend_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的单据参考依赖关系 Sys_Rec_RefDepend对象(即:一条记录
      /// </summary>
      public Sys_Rec_RefDepend GetByKey(decimal refDepend_ID)
      {
         Sys_Rec_RefDepend sys_Rec_RefDepend = new Sys_Rec_RefDepend();
         string sql = "SELECT  RefDepend_ID,RefDepend_Code,RefDepend_Type,RefDepend_Object,RefDepend_ObjectName,RefDepend_ShowMain,RefDepend_ShowOther,RefDepend_ShowName,RefDepend_UDEF1,RefDepend_UDEF2,RefDepend_UDEF3,RefDepend_UDEF4,RefDepend_UDEF5,Stat,RefDepend_UDEF6,RefDepend_UDEF7,RefDepend_UDEF8,RefDepend_UDEF9,RefDepend_UDEF10,RefDepend_ConfFlag,RefDepend_UDEF11,RefDepend_UDEF12,RefDepend_UDEF13,RefDepend_UDEF14,RefDepend_UDEF15,RefDepend_UDEF16,RefDepend_UDEF17,RefDepend_UDEF18,RefDepend_UDEF19,RefDepend_UDEF20 FROM Sys_Rec_RefDepend WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RefDepend_ID=@RefDepend_ID ";
         idb.AddParameter("@RefDepend_ID", refDepend_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RefDepend_ID"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ID = Convert.ToDecimal(dr["RefDepend_ID"]);
            if (dr["RefDepend_Code"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Code = Convert.ToString(dr["RefDepend_Code"]);
            if (dr["RefDepend_Type"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Type = Convert.ToString(dr["RefDepend_Type"]);
            if (dr["RefDepend_Object"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Object = Convert.ToString(dr["RefDepend_Object"]);
            if (dr["RefDepend_ObjectName"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ObjectName = Convert.ToString(dr["RefDepend_ObjectName"]);
            if (dr["RefDepend_ShowMain"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowMain = Convert.ToString(dr["RefDepend_ShowMain"]);
            if (dr["RefDepend_ShowOther"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowOther = Convert.ToString(dr["RefDepend_ShowOther"]);
            if (dr["RefDepend_ShowName"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowName = Convert.ToString(dr["RefDepend_ShowName"]);
            if (dr["RefDepend_UDEF1"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF1 = Convert.ToString(dr["RefDepend_UDEF1"]);
            if (dr["RefDepend_UDEF2"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF2 = Convert.ToString(dr["RefDepend_UDEF2"]);
            if (dr["RefDepend_UDEF3"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF3 = Convert.ToString(dr["RefDepend_UDEF3"]);
            if (dr["RefDepend_UDEF4"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF4 = Convert.ToString(dr["RefDepend_UDEF4"]);
            if (dr["RefDepend_UDEF5"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF5 = Convert.ToString(dr["RefDepend_UDEF5"]);
            if (dr["Stat"] != DBNull.Value) sys_Rec_RefDepend.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RefDepend_UDEF6"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF6 = Convert.ToString(dr["RefDepend_UDEF6"]);
            if (dr["RefDepend_UDEF7"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF7 = Convert.ToString(dr["RefDepend_UDEF7"]);
            if (dr["RefDepend_UDEF8"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF8 = Convert.ToString(dr["RefDepend_UDEF8"]);
            if (dr["RefDepend_UDEF9"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF9 = Convert.ToString(dr["RefDepend_UDEF9"]);
            if (dr["RefDepend_UDEF10"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF10 = Convert.ToString(dr["RefDepend_UDEF10"]);
            if (dr["RefDepend_ConfFlag"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ConfFlag = Convert.ToInt32(dr["RefDepend_ConfFlag"]);
            if (dr["RefDepend_UDEF11"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF11 = Convert.ToString(dr["RefDepend_UDEF11"]);
            if (dr["RefDepend_UDEF12"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF12 = Convert.ToString(dr["RefDepend_UDEF12"]);
            if (dr["RefDepend_UDEF13"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF13 = Convert.ToString(dr["RefDepend_UDEF13"]);
            if (dr["RefDepend_UDEF14"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF14 = Convert.ToString(dr["RefDepend_UDEF14"]);
            if (dr["RefDepend_UDEF15"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF15 = Convert.ToString(dr["RefDepend_UDEF15"]);
            if (dr["RefDepend_UDEF16"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF16 = Convert.ToString(dr["RefDepend_UDEF16"]);
            if (dr["RefDepend_UDEF17"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF17 = Convert.ToString(dr["RefDepend_UDEF17"]);
            if (dr["RefDepend_UDEF18"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF18 = Convert.ToString(dr["RefDepend_UDEF18"]);
            if (dr["RefDepend_UDEF19"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF19 = Convert.ToString(dr["RefDepend_UDEF19"]);
            if (dr["RefDepend_UDEF20"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF20 = Convert.ToString(dr["RefDepend_UDEF20"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Rec_RefDepend;
      }
      /// <summary>
      /// 获取指定的单据参考依赖关系 Sys_Rec_RefDepend对象集合
      /// </summary>
      public List<Sys_Rec_RefDepend> GetListByWhere(string strCondition)
      {
         List<Sys_Rec_RefDepend> ret = new List<Sys_Rec_RefDepend>();
         string sql = "SELECT  RefDepend_ID,RefDepend_Code,RefDepend_Type,RefDepend_Object,RefDepend_ObjectName,RefDepend_ShowMain,RefDepend_ShowOther,RefDepend_ShowName,RefDepend_UDEF1,RefDepend_UDEF2,RefDepend_UDEF3,RefDepend_UDEF4,RefDepend_UDEF5,Stat,RefDepend_UDEF6,RefDepend_UDEF7,RefDepend_UDEF8,RefDepend_UDEF9,RefDepend_UDEF10,RefDepend_ConfFlag,RefDepend_UDEF11,RefDepend_UDEF12,RefDepend_UDEF13,RefDepend_UDEF14,RefDepend_UDEF15,RefDepend_UDEF16,RefDepend_UDEF17,RefDepend_UDEF18,RefDepend_UDEF19,RefDepend_UDEF20 FROM Sys_Rec_RefDepend WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY RefDepend_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Rec_RefDepend sys_Rec_RefDepend = new Sys_Rec_RefDepend();
            if (dr["RefDepend_ID"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ID = Convert.ToDecimal(dr["RefDepend_ID"]);
            if (dr["RefDepend_Code"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Code = Convert.ToString(dr["RefDepend_Code"]);
            if (dr["RefDepend_Type"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Type = Convert.ToString(dr["RefDepend_Type"]);
            if (dr["RefDepend_Object"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Object = Convert.ToString(dr["RefDepend_Object"]);
            if (dr["RefDepend_ObjectName"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ObjectName = Convert.ToString(dr["RefDepend_ObjectName"]);
            if (dr["RefDepend_ShowMain"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowMain = Convert.ToString(dr["RefDepend_ShowMain"]);
            if (dr["RefDepend_ShowOther"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowOther = Convert.ToString(dr["RefDepend_ShowOther"]);
            if (dr["RefDepend_ShowName"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowName = Convert.ToString(dr["RefDepend_ShowName"]);
            if (dr["RefDepend_UDEF1"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF1 = Convert.ToString(dr["RefDepend_UDEF1"]);
            if (dr["RefDepend_UDEF2"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF2 = Convert.ToString(dr["RefDepend_UDEF2"]);
            if (dr["RefDepend_UDEF3"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF3 = Convert.ToString(dr["RefDepend_UDEF3"]);
            if (dr["RefDepend_UDEF4"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF4 = Convert.ToString(dr["RefDepend_UDEF4"]);
            if (dr["RefDepend_UDEF5"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF5 = Convert.ToString(dr["RefDepend_UDEF5"]);
            if (dr["Stat"] != DBNull.Value) sys_Rec_RefDepend.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RefDepend_UDEF6"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF6 = Convert.ToString(dr["RefDepend_UDEF6"]);
            if (dr["RefDepend_UDEF7"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF7 = Convert.ToString(dr["RefDepend_UDEF7"]);
            if (dr["RefDepend_UDEF8"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF8 = Convert.ToString(dr["RefDepend_UDEF8"]);
            if (dr["RefDepend_UDEF9"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF9 = Convert.ToString(dr["RefDepend_UDEF9"]);
            if (dr["RefDepend_UDEF10"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF10 = Convert.ToString(dr["RefDepend_UDEF10"]);
            if (dr["RefDepend_ConfFlag"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ConfFlag = Convert.ToInt32(dr["RefDepend_ConfFlag"]);
            if (dr["RefDepend_UDEF11"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF11 = Convert.ToString(dr["RefDepend_UDEF11"]);
            if (dr["RefDepend_UDEF12"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF12 = Convert.ToString(dr["RefDepend_UDEF12"]);
            if (dr["RefDepend_UDEF13"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF13 = Convert.ToString(dr["RefDepend_UDEF13"]);
            if (dr["RefDepend_UDEF14"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF14 = Convert.ToString(dr["RefDepend_UDEF14"]);
            if (dr["RefDepend_UDEF15"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF15 = Convert.ToString(dr["RefDepend_UDEF15"]);
            if (dr["RefDepend_UDEF16"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF16 = Convert.ToString(dr["RefDepend_UDEF16"]);
            if (dr["RefDepend_UDEF17"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF17 = Convert.ToString(dr["RefDepend_UDEF17"]);
            if (dr["RefDepend_UDEF18"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF18 = Convert.ToString(dr["RefDepend_UDEF18"]);
            if (dr["RefDepend_UDEF19"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF19 = Convert.ToString(dr["RefDepend_UDEF19"]);
            if (dr["RefDepend_UDEF20"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF20 = Convert.ToString(dr["RefDepend_UDEF20"]);
            ret.Add(sys_Rec_RefDepend);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的单据参考依赖关系 Sys_Rec_RefDepend对象(即:一条记录
      /// </summary>
      public List<Sys_Rec_RefDepend> GetAll()
      {
         List<Sys_Rec_RefDepend> ret = new List<Sys_Rec_RefDepend>();
         string sql = "SELECT  RefDepend_ID,RefDepend_Code,RefDepend_Type,RefDepend_Object,RefDepend_ObjectName,RefDepend_ShowMain,RefDepend_ShowOther,RefDepend_ShowName,RefDepend_UDEF1,RefDepend_UDEF2,RefDepend_UDEF3,RefDepend_UDEF4,RefDepend_UDEF5,Stat,RefDepend_UDEF6,RefDepend_UDEF7,RefDepend_UDEF8,RefDepend_UDEF9,RefDepend_UDEF10,RefDepend_ConfFlag,RefDepend_UDEF11,RefDepend_UDEF12,RefDepend_UDEF13,RefDepend_UDEF14,RefDepend_UDEF15,RefDepend_UDEF16,RefDepend_UDEF17,RefDepend_UDEF18,RefDepend_UDEF19,RefDepend_UDEF20 FROM Sys_Rec_RefDepend where 1=1 AND ((Stat is null) or (Stat=0) ) order by RefDepend_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Rec_RefDepend sys_Rec_RefDepend = new Sys_Rec_RefDepend();
            if (dr["RefDepend_ID"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ID = Convert.ToDecimal(dr["RefDepend_ID"]);
            if (dr["RefDepend_Code"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Code = Convert.ToString(dr["RefDepend_Code"]);
            if (dr["RefDepend_Type"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Type = Convert.ToString(dr["RefDepend_Type"]);
            if (dr["RefDepend_Object"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_Object = Convert.ToString(dr["RefDepend_Object"]);
            if (dr["RefDepend_ObjectName"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ObjectName = Convert.ToString(dr["RefDepend_ObjectName"]);
            if (dr["RefDepend_ShowMain"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowMain = Convert.ToString(dr["RefDepend_ShowMain"]);
            if (dr["RefDepend_ShowOther"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowOther = Convert.ToString(dr["RefDepend_ShowOther"]);
            if (dr["RefDepend_ShowName"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ShowName = Convert.ToString(dr["RefDepend_ShowName"]);
            if (dr["RefDepend_UDEF1"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF1 = Convert.ToString(dr["RefDepend_UDEF1"]);
            if (dr["RefDepend_UDEF2"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF2 = Convert.ToString(dr["RefDepend_UDEF2"]);
            if (dr["RefDepend_UDEF3"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF3 = Convert.ToString(dr["RefDepend_UDEF3"]);
            if (dr["RefDepend_UDEF4"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF4 = Convert.ToString(dr["RefDepend_UDEF4"]);
            if (dr["RefDepend_UDEF5"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF5 = Convert.ToString(dr["RefDepend_UDEF5"]);
            if (dr["Stat"] != DBNull.Value) sys_Rec_RefDepend.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RefDepend_UDEF6"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF6 = Convert.ToString(dr["RefDepend_UDEF6"]);
            if (dr["RefDepend_UDEF7"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF7 = Convert.ToString(dr["RefDepend_UDEF7"]);
            if (dr["RefDepend_UDEF8"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF8 = Convert.ToString(dr["RefDepend_UDEF8"]);
            if (dr["RefDepend_UDEF9"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF9 = Convert.ToString(dr["RefDepend_UDEF9"]);
            if (dr["RefDepend_UDEF10"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF10 = Convert.ToString(dr["RefDepend_UDEF10"]);
            if (dr["RefDepend_ConfFlag"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_ConfFlag = Convert.ToInt32(dr["RefDepend_ConfFlag"]);
            if (dr["RefDepend_UDEF11"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF11 = Convert.ToString(dr["RefDepend_UDEF11"]);
            if (dr["RefDepend_UDEF12"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF12 = Convert.ToString(dr["RefDepend_UDEF12"]);
            if (dr["RefDepend_UDEF13"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF13 = Convert.ToString(dr["RefDepend_UDEF13"]);
            if (dr["RefDepend_UDEF14"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF14 = Convert.ToString(dr["RefDepend_UDEF14"]);
            if (dr["RefDepend_UDEF15"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF15 = Convert.ToString(dr["RefDepend_UDEF15"]);
            if (dr["RefDepend_UDEF16"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF16 = Convert.ToString(dr["RefDepend_UDEF16"]);
            if (dr["RefDepend_UDEF17"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF17 = Convert.ToString(dr["RefDepend_UDEF17"]);
            if (dr["RefDepend_UDEF18"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF18 = Convert.ToString(dr["RefDepend_UDEF18"]);
            if (dr["RefDepend_UDEF19"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF19 = Convert.ToString(dr["RefDepend_UDEF19"]);
            if (dr["RefDepend_UDEF20"] != DBNull.Value) sys_Rec_RefDepend.RefDepend_UDEF20 = Convert.ToString(dr["RefDepend_UDEF20"]);
            ret.Add(sys_Rec_RefDepend);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
