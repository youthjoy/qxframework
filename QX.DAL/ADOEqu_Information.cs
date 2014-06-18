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
   /// 设备信息
   /// </summary>
   [Serializable]
   public partial class ADOEqu_Information
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加设备信息 Equ_Information对象(即:一条记录)
      /// </summary>
      public int Add(Equ_Information equ_Information)
      {
         string sql = "INSERT INTO Equ_Information (EquInfo_SupCode,EquInfo_Code,EquInfo_Name,EquInfo_ICode,EquInfo_TCode,EquInfo_Spec,EquInfo_Manu,EquInfo_DeptCode,EquInfo_DeptName,EquInfo_PartInfo,EquInfo_TechInfo,EquInfo_TechVar,EquInfo_Addr,EquInfo_Type,EquInfo_CCode,EquInfo_Cost,EquInfo_IsFix,Stat) VALUES (@EquInfo_SupCode,@EquInfo_Code,@EquInfo_Name,@EquInfo_ICode,@EquInfo_TCode,@EquInfo_Spec,@EquInfo_Manu,@EquInfo_DeptCode,@EquInfo_DeptName,@EquInfo_PartInfo,@EquInfo_TechInfo,@EquInfo_TechVar,@EquInfo_Addr,@EquInfo_Type,@EquInfo_CCode,@EquInfo_Cost,@EquInfo_IsFix,@Stat)";
         if (string.IsNullOrEmpty(equ_Information.EquInfo_SupCode))
         {
            idb.AddParameter("@EquInfo_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_SupCode", equ_Information.EquInfo_SupCode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Code))
         {
            idb.AddParameter("@EquInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Code", equ_Information.EquInfo_Code);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Name))
         {
            idb.AddParameter("@EquInfo_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Name", equ_Information.EquInfo_Name);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_ICode))
         {
            idb.AddParameter("@EquInfo_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_ICode", equ_Information.EquInfo_ICode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TCode))
         {
            idb.AddParameter("@EquInfo_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TCode", equ_Information.EquInfo_TCode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Spec))
         {
            idb.AddParameter("@EquInfo_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Spec", equ_Information.EquInfo_Spec);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Manu))
         {
            idb.AddParameter("@EquInfo_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Manu", equ_Information.EquInfo_Manu);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_DeptCode))
         {
            idb.AddParameter("@EquInfo_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_DeptCode", equ_Information.EquInfo_DeptCode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_DeptName))
         {
            idb.AddParameter("@EquInfo_DeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_DeptName", equ_Information.EquInfo_DeptName);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_PartInfo))
         {
            idb.AddParameter("@EquInfo_PartInfo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_PartInfo", equ_Information.EquInfo_PartInfo);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TechInfo))
         {
            idb.AddParameter("@EquInfo_TechInfo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TechInfo", equ_Information.EquInfo_TechInfo);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TechVar))
         {
            idb.AddParameter("@EquInfo_TechVar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TechVar", equ_Information.EquInfo_TechVar);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Addr))
         {
            idb.AddParameter("@EquInfo_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Addr", equ_Information.EquInfo_Addr);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Type))
         {
            idb.AddParameter("@EquInfo_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Type", equ_Information.EquInfo_Type);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_CCode))
         {
            idb.AddParameter("@EquInfo_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_CCode", equ_Information.EquInfo_CCode);
         }
         if (equ_Information.EquInfo_Cost == 0)
         {
            idb.AddParameter("@EquInfo_Cost", 0);
         }
         else
         {
            idb.AddParameter("@EquInfo_Cost", equ_Information.EquInfo_Cost);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_IsFix))
         {
            idb.AddParameter("@EquInfo_IsFix", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_IsFix", equ_Information.EquInfo_IsFix);
         }
         if (equ_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_Information.Stat);
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
      /// 添加设备信息 Equ_Information对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Equ_Information equ_Information)
      {
         string sql = "INSERT INTO Equ_Information (EquInfo_SupCode,EquInfo_Code,EquInfo_Name,EquInfo_ICode,EquInfo_TCode,EquInfo_Spec,EquInfo_Manu,EquInfo_DeptCode,EquInfo_DeptName,EquInfo_PartInfo,EquInfo_TechInfo,EquInfo_TechVar,EquInfo_Addr,EquInfo_Type,EquInfo_CCode,EquInfo_Cost,EquInfo_IsFix,Stat) VALUES (@EquInfo_SupCode,@EquInfo_Code,@EquInfo_Name,@EquInfo_ICode,@EquInfo_TCode,@EquInfo_Spec,@EquInfo_Manu,@EquInfo_DeptCode,@EquInfo_DeptName,@EquInfo_PartInfo,@EquInfo_TechInfo,@EquInfo_TechVar,@EquInfo_Addr,@EquInfo_Type,@EquInfo_CCode,@EquInfo_Cost,@EquInfo_IsFix,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(equ_Information.EquInfo_SupCode))
         {
            idb.AddParameter("@EquInfo_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_SupCode", equ_Information.EquInfo_SupCode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Code))
         {
            idb.AddParameter("@EquInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Code", equ_Information.EquInfo_Code);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Name))
         {
            idb.AddParameter("@EquInfo_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Name", equ_Information.EquInfo_Name);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_ICode))
         {
            idb.AddParameter("@EquInfo_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_ICode", equ_Information.EquInfo_ICode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TCode))
         {
            idb.AddParameter("@EquInfo_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TCode", equ_Information.EquInfo_TCode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Spec))
         {
            idb.AddParameter("@EquInfo_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Spec", equ_Information.EquInfo_Spec);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Manu))
         {
            idb.AddParameter("@EquInfo_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Manu", equ_Information.EquInfo_Manu);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_DeptCode))
         {
            idb.AddParameter("@EquInfo_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_DeptCode", equ_Information.EquInfo_DeptCode);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_DeptName))
         {
            idb.AddParameter("@EquInfo_DeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_DeptName", equ_Information.EquInfo_DeptName);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_PartInfo))
         {
            idb.AddParameter("@EquInfo_PartInfo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_PartInfo", equ_Information.EquInfo_PartInfo);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TechInfo))
         {
            idb.AddParameter("@EquInfo_TechInfo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TechInfo", equ_Information.EquInfo_TechInfo);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TechVar))
         {
            idb.AddParameter("@EquInfo_TechVar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TechVar", equ_Information.EquInfo_TechVar);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Addr))
         {
            idb.AddParameter("@EquInfo_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Addr", equ_Information.EquInfo_Addr);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Type))
         {
            idb.AddParameter("@EquInfo_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Type", equ_Information.EquInfo_Type);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_CCode))
         {
            idb.AddParameter("@EquInfo_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_CCode", equ_Information.EquInfo_CCode);
         }
         if (equ_Information.EquInfo_Cost == 0)
         {
            idb.AddParameter("@EquInfo_Cost", 0);
         }
         else
         {
            idb.AddParameter("@EquInfo_Cost", equ_Information.EquInfo_Cost);
         }
         if (string.IsNullOrEmpty(equ_Information.EquInfo_IsFix))
         {
            idb.AddParameter("@EquInfo_IsFix", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_IsFix", equ_Information.EquInfo_IsFix);
         }
         if (equ_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_Information.Stat);
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
      /// 更新设备信息 Equ_Information对象(即:一条记录
      /// </summary>
      public int Update(Equ_Information equ_Information)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Equ_Information       SET ");
            if(equ_Information.EquInfo_SupCode_IsChanged){sbParameter.Append("EquInfo_SupCode=@EquInfo_SupCode, ");}
      if(equ_Information.EquInfo_Code_IsChanged){sbParameter.Append("EquInfo_Code=@EquInfo_Code, ");}
      if(equ_Information.EquInfo_Name_IsChanged){sbParameter.Append("EquInfo_Name=@EquInfo_Name, ");}
      if(equ_Information.EquInfo_ICode_IsChanged){sbParameter.Append("EquInfo_ICode=@EquInfo_ICode, ");}
      if(equ_Information.EquInfo_TCode_IsChanged){sbParameter.Append("EquInfo_TCode=@EquInfo_TCode, ");}
      if(equ_Information.EquInfo_Spec_IsChanged){sbParameter.Append("EquInfo_Spec=@EquInfo_Spec, ");}
      if(equ_Information.EquInfo_Manu_IsChanged){sbParameter.Append("EquInfo_Manu=@EquInfo_Manu, ");}
      if(equ_Information.EquInfo_DeptCode_IsChanged){sbParameter.Append("EquInfo_DeptCode=@EquInfo_DeptCode, ");}
      if(equ_Information.EquInfo_DeptName_IsChanged){sbParameter.Append("EquInfo_DeptName=@EquInfo_DeptName, ");}
      if(equ_Information.EquInfo_PartInfo_IsChanged){sbParameter.Append("EquInfo_PartInfo=@EquInfo_PartInfo, ");}
      if(equ_Information.EquInfo_TechInfo_IsChanged){sbParameter.Append("EquInfo_TechInfo=@EquInfo_TechInfo, ");}
      if(equ_Information.EquInfo_TechVar_IsChanged){sbParameter.Append("EquInfo_TechVar=@EquInfo_TechVar, ");}
      if(equ_Information.EquInfo_Addr_IsChanged){sbParameter.Append("EquInfo_Addr=@EquInfo_Addr, ");}
      if(equ_Information.EquInfo_Type_IsChanged){sbParameter.Append("EquInfo_Type=@EquInfo_Type, ");}
      if(equ_Information.EquInfo_CCode_IsChanged){sbParameter.Append("EquInfo_CCode=@EquInfo_CCode, ");}
      if(equ_Information.EquInfo_Cost_IsChanged){sbParameter.Append("EquInfo_Cost=@EquInfo_Cost, ");}
      if(equ_Information.EquInfo_IsFix_IsChanged){sbParameter.Append("EquInfo_IsFix=@EquInfo_IsFix, ");}
      if(equ_Information.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EquInfo_ID=@EquInfo_ID; " );
      string sql=sb.ToString();
         if(equ_Information.EquInfo_SupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_SupCode))
         {
            idb.AddParameter("@EquInfo_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_SupCode", equ_Information.EquInfo_SupCode);
         }
          }
         if(equ_Information.EquInfo_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Code))
         {
            idb.AddParameter("@EquInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Code", equ_Information.EquInfo_Code);
         }
          }
         if(equ_Information.EquInfo_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Name))
         {
            idb.AddParameter("@EquInfo_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Name", equ_Information.EquInfo_Name);
         }
          }
         if(equ_Information.EquInfo_ICode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_ICode))
         {
            idb.AddParameter("@EquInfo_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_ICode", equ_Information.EquInfo_ICode);
         }
          }
         if(equ_Information.EquInfo_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TCode))
         {
            idb.AddParameter("@EquInfo_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TCode", equ_Information.EquInfo_TCode);
         }
          }
         if(equ_Information.EquInfo_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Spec))
         {
            idb.AddParameter("@EquInfo_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Spec", equ_Information.EquInfo_Spec);
         }
          }
         if(equ_Information.EquInfo_Manu_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Manu))
         {
            idb.AddParameter("@EquInfo_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Manu", equ_Information.EquInfo_Manu);
         }
          }
         if(equ_Information.EquInfo_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_DeptCode))
         {
            idb.AddParameter("@EquInfo_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_DeptCode", equ_Information.EquInfo_DeptCode);
         }
          }
         if(equ_Information.EquInfo_DeptName_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_DeptName))
         {
            idb.AddParameter("@EquInfo_DeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_DeptName", equ_Information.EquInfo_DeptName);
         }
          }
         if(equ_Information.EquInfo_PartInfo_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_PartInfo))
         {
            idb.AddParameter("@EquInfo_PartInfo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_PartInfo", equ_Information.EquInfo_PartInfo);
         }
          }
         if(equ_Information.EquInfo_TechInfo_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TechInfo))
         {
            idb.AddParameter("@EquInfo_TechInfo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TechInfo", equ_Information.EquInfo_TechInfo);
         }
          }
         if(equ_Information.EquInfo_TechVar_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_TechVar))
         {
            idb.AddParameter("@EquInfo_TechVar", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_TechVar", equ_Information.EquInfo_TechVar);
         }
          }
         if(equ_Information.EquInfo_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Addr))
         {
            idb.AddParameter("@EquInfo_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Addr", equ_Information.EquInfo_Addr);
         }
          }
         if(equ_Information.EquInfo_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_Type))
         {
            idb.AddParameter("@EquInfo_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_Type", equ_Information.EquInfo_Type);
         }
          }
         if(equ_Information.EquInfo_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_CCode))
         {
            idb.AddParameter("@EquInfo_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_CCode", equ_Information.EquInfo_CCode);
         }
          }
         if(equ_Information.EquInfo_Cost_IsChanged)
         {
         if (equ_Information.EquInfo_Cost == 0)
         {
            idb.AddParameter("@EquInfo_Cost", 0);
         }
         else
         {
            idb.AddParameter("@EquInfo_Cost", equ_Information.EquInfo_Cost);
         }
          }
         if(equ_Information.EquInfo_IsFix_IsChanged)
         {
         if (string.IsNullOrEmpty(equ_Information.EquInfo_IsFix))
         {
            idb.AddParameter("@EquInfo_IsFix", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EquInfo_IsFix", equ_Information.EquInfo_IsFix);
         }
          }
         if(equ_Information.Stat_IsChanged)
         {
         if (equ_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", equ_Information.Stat);
         }
          }

         idb.AddParameter("@EquInfo_ID", equ_Information.EquInfo_ID);

           
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
      /// 删除设备信息 Equ_Information对象(即:一条记录
      /// </summary>
      public int Delete(decimal equInfo_ID)
      {
         string sql = "DELETE Equ_Information WHERE 1=1  AND EquInfo_ID=@EquInfo_ID ";
         idb.AddParameter("@EquInfo_ID", equInfo_ID);

           
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
      /// 获取指定的设备信息 Equ_Information对象(即:一条记录
      /// </summary>
      public Equ_Information GetByKey(decimal equInfo_ID)
      {
         Equ_Information equ_Information = new Equ_Information();
         string sql = "SELECT  EquInfo_ID,EquInfo_SupCode,EquInfo_Code,EquInfo_Name,EquInfo_ICode,EquInfo_TCode,EquInfo_Spec,EquInfo_Manu,EquInfo_DeptCode,EquInfo_DeptName,EquInfo_PartInfo,EquInfo_TechInfo,EquInfo_TechVar,EquInfo_Addr,EquInfo_Type,EquInfo_CCode,EquInfo_Cost,EquInfo_IsFix,Stat FROM Equ_Information WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EquInfo_ID=@EquInfo_ID ";
         idb.AddParameter("@EquInfo_ID", equInfo_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EquInfo_ID"] != DBNull.Value) equ_Information.EquInfo_ID = Convert.ToDecimal(dr["EquInfo_ID"]);
            if (dr["EquInfo_SupCode"] != DBNull.Value) equ_Information.EquInfo_SupCode = Convert.ToString(dr["EquInfo_SupCode"]);
            if (dr["EquInfo_Code"] != DBNull.Value) equ_Information.EquInfo_Code = Convert.ToString(dr["EquInfo_Code"]);
            if (dr["EquInfo_Name"] != DBNull.Value) equ_Information.EquInfo_Name = Convert.ToString(dr["EquInfo_Name"]);
            if (dr["EquInfo_ICode"] != DBNull.Value) equ_Information.EquInfo_ICode = Convert.ToString(dr["EquInfo_ICode"]);
            if (dr["EquInfo_TCode"] != DBNull.Value) equ_Information.EquInfo_TCode = Convert.ToString(dr["EquInfo_TCode"]);
            if (dr["EquInfo_Spec"] != DBNull.Value) equ_Information.EquInfo_Spec = Convert.ToString(dr["EquInfo_Spec"]);
            if (dr["EquInfo_Manu"] != DBNull.Value) equ_Information.EquInfo_Manu = Convert.ToString(dr["EquInfo_Manu"]);
            if (dr["EquInfo_DeptCode"] != DBNull.Value) equ_Information.EquInfo_DeptCode = Convert.ToString(dr["EquInfo_DeptCode"]);
            if (dr["EquInfo_DeptName"] != DBNull.Value) equ_Information.EquInfo_DeptName = Convert.ToString(dr["EquInfo_DeptName"]);
            if (dr["EquInfo_PartInfo"] != DBNull.Value) equ_Information.EquInfo_PartInfo = Convert.ToString(dr["EquInfo_PartInfo"]);
            if (dr["EquInfo_TechInfo"] != DBNull.Value) equ_Information.EquInfo_TechInfo = Convert.ToString(dr["EquInfo_TechInfo"]);
            if (dr["EquInfo_TechVar"] != DBNull.Value) equ_Information.EquInfo_TechVar = Convert.ToString(dr["EquInfo_TechVar"]);
            if (dr["EquInfo_Addr"] != DBNull.Value) equ_Information.EquInfo_Addr = Convert.ToString(dr["EquInfo_Addr"]);
            if (dr["EquInfo_Type"] != DBNull.Value) equ_Information.EquInfo_Type = Convert.ToString(dr["EquInfo_Type"]);
            if (dr["EquInfo_CCode"] != DBNull.Value) equ_Information.EquInfo_CCode = Convert.ToString(dr["EquInfo_CCode"]);
            if (dr["EquInfo_Cost"] != DBNull.Value) equ_Information.EquInfo_Cost = Convert.ToDouble(dr["EquInfo_Cost"]);
            if (dr["EquInfo_IsFix"] != DBNull.Value) equ_Information.EquInfo_IsFix = Convert.ToString(dr["EquInfo_IsFix"]);
            if (dr["Stat"] != DBNull.Value) equ_Information.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return equ_Information;
      }
      /// <summary>
      /// 获取指定的设备信息 Equ_Information对象集合
      /// </summary>
      public List<Equ_Information> GetListByWhere(string strCondition)
      {
         List<Equ_Information> ret = new List<Equ_Information>();
         string sql = "SELECT  EquInfo_ID,EquInfo_SupCode,EquInfo_Code,EquInfo_Name,EquInfo_ICode,EquInfo_TCode,EquInfo_Spec,EquInfo_Manu,EquInfo_DeptCode,EquInfo_DeptName,EquInfo_PartInfo,EquInfo_TechInfo,EquInfo_TechVar,EquInfo_Addr,EquInfo_Type,EquInfo_CCode,EquInfo_Cost,EquInfo_IsFix,Stat FROM Equ_Information WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Equ_Information equ_Information = new Equ_Information();
            if (dr["EquInfo_ID"] != DBNull.Value) equ_Information.EquInfo_ID = Convert.ToDecimal(dr["EquInfo_ID"]);
            if (dr["EquInfo_SupCode"] != DBNull.Value) equ_Information.EquInfo_SupCode = Convert.ToString(dr["EquInfo_SupCode"]);
            if (dr["EquInfo_Code"] != DBNull.Value) equ_Information.EquInfo_Code = Convert.ToString(dr["EquInfo_Code"]);
            if (dr["EquInfo_Name"] != DBNull.Value) equ_Information.EquInfo_Name = Convert.ToString(dr["EquInfo_Name"]);
            if (dr["EquInfo_ICode"] != DBNull.Value) equ_Information.EquInfo_ICode = Convert.ToString(dr["EquInfo_ICode"]);
            if (dr["EquInfo_TCode"] != DBNull.Value) equ_Information.EquInfo_TCode = Convert.ToString(dr["EquInfo_TCode"]);
            if (dr["EquInfo_Spec"] != DBNull.Value) equ_Information.EquInfo_Spec = Convert.ToString(dr["EquInfo_Spec"]);
            if (dr["EquInfo_Manu"] != DBNull.Value) equ_Information.EquInfo_Manu = Convert.ToString(dr["EquInfo_Manu"]);
            if (dr["EquInfo_DeptCode"] != DBNull.Value) equ_Information.EquInfo_DeptCode = Convert.ToString(dr["EquInfo_DeptCode"]);
            if (dr["EquInfo_DeptName"] != DBNull.Value) equ_Information.EquInfo_DeptName = Convert.ToString(dr["EquInfo_DeptName"]);
            if (dr["EquInfo_PartInfo"] != DBNull.Value) equ_Information.EquInfo_PartInfo = Convert.ToString(dr["EquInfo_PartInfo"]);
            if (dr["EquInfo_TechInfo"] != DBNull.Value) equ_Information.EquInfo_TechInfo = Convert.ToString(dr["EquInfo_TechInfo"]);
            if (dr["EquInfo_TechVar"] != DBNull.Value) equ_Information.EquInfo_TechVar = Convert.ToString(dr["EquInfo_TechVar"]);
            if (dr["EquInfo_Addr"] != DBNull.Value) equ_Information.EquInfo_Addr = Convert.ToString(dr["EquInfo_Addr"]);
            if (dr["EquInfo_Type"] != DBNull.Value) equ_Information.EquInfo_Type = Convert.ToString(dr["EquInfo_Type"]);
            if (dr["EquInfo_CCode"] != DBNull.Value) equ_Information.EquInfo_CCode = Convert.ToString(dr["EquInfo_CCode"]);
            if (dr["EquInfo_Cost"] != DBNull.Value) equ_Information.EquInfo_Cost = Convert.ToDouble(dr["EquInfo_Cost"]);
            if (dr["EquInfo_IsFix"] != DBNull.Value) equ_Information.EquInfo_IsFix = Convert.ToString(dr["EquInfo_IsFix"]);
            if (dr["Stat"] != DBNull.Value) equ_Information.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(equ_Information);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的设备信息 Equ_Information对象(即:一条记录
      /// </summary>
      public List<Equ_Information> GetAll()
      {
         List<Equ_Information> ret = new List<Equ_Information>();
         string sql = "SELECT  EquInfo_ID,EquInfo_SupCode,EquInfo_Code,EquInfo_Name,EquInfo_ICode,EquInfo_TCode,EquInfo_Spec,EquInfo_Manu,EquInfo_DeptCode,EquInfo_DeptName,EquInfo_PartInfo,EquInfo_TechInfo,EquInfo_TechVar,EquInfo_Addr,EquInfo_Type,EquInfo_CCode,EquInfo_Cost,EquInfo_IsFix,Stat FROM Equ_Information where 1=1 AND ((Stat is null) or (Stat=0) ) order by EquInfo_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Equ_Information equ_Information = new Equ_Information();
            if (dr["EquInfo_ID"] != DBNull.Value) equ_Information.EquInfo_ID = Convert.ToDecimal(dr["EquInfo_ID"]);
            if (dr["EquInfo_SupCode"] != DBNull.Value) equ_Information.EquInfo_SupCode = Convert.ToString(dr["EquInfo_SupCode"]);
            if (dr["EquInfo_Code"] != DBNull.Value) equ_Information.EquInfo_Code = Convert.ToString(dr["EquInfo_Code"]);
            if (dr["EquInfo_Name"] != DBNull.Value) equ_Information.EquInfo_Name = Convert.ToString(dr["EquInfo_Name"]);
            if (dr["EquInfo_ICode"] != DBNull.Value) equ_Information.EquInfo_ICode = Convert.ToString(dr["EquInfo_ICode"]);
            if (dr["EquInfo_TCode"] != DBNull.Value) equ_Information.EquInfo_TCode = Convert.ToString(dr["EquInfo_TCode"]);
            if (dr["EquInfo_Spec"] != DBNull.Value) equ_Information.EquInfo_Spec = Convert.ToString(dr["EquInfo_Spec"]);
            if (dr["EquInfo_Manu"] != DBNull.Value) equ_Information.EquInfo_Manu = Convert.ToString(dr["EquInfo_Manu"]);
            if (dr["EquInfo_DeptCode"] != DBNull.Value) equ_Information.EquInfo_DeptCode = Convert.ToString(dr["EquInfo_DeptCode"]);
            if (dr["EquInfo_DeptName"] != DBNull.Value) equ_Information.EquInfo_DeptName = Convert.ToString(dr["EquInfo_DeptName"]);
            if (dr["EquInfo_PartInfo"] != DBNull.Value) equ_Information.EquInfo_PartInfo = Convert.ToString(dr["EquInfo_PartInfo"]);
            if (dr["EquInfo_TechInfo"] != DBNull.Value) equ_Information.EquInfo_TechInfo = Convert.ToString(dr["EquInfo_TechInfo"]);
            if (dr["EquInfo_TechVar"] != DBNull.Value) equ_Information.EquInfo_TechVar = Convert.ToString(dr["EquInfo_TechVar"]);
            if (dr["EquInfo_Addr"] != DBNull.Value) equ_Information.EquInfo_Addr = Convert.ToString(dr["EquInfo_Addr"]);
            if (dr["EquInfo_Type"] != DBNull.Value) equ_Information.EquInfo_Type = Convert.ToString(dr["EquInfo_Type"]);
            if (dr["EquInfo_CCode"] != DBNull.Value) equ_Information.EquInfo_CCode = Convert.ToString(dr["EquInfo_CCode"]);
            if (dr["EquInfo_Cost"] != DBNull.Value) equ_Information.EquInfo_Cost = Convert.ToDouble(dr["EquInfo_Cost"]);
            if (dr["EquInfo_IsFix"] != DBNull.Value) equ_Information.EquInfo_IsFix = Convert.ToString(dr["EquInfo_IsFix"]);
            if (dr["Stat"] != DBNull.Value) equ_Information.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(equ_Information);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
