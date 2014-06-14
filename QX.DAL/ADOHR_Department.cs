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
   /// 部门信息
   /// </summary>
   [Serializable]
   public partial class ADOHR_Department
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加部门信息 HR_Department对象(即:一条记录)
      /// </summary>
      public int Add(HR_Department hR_Department)
      {
         string sql = "INSERT INTO HR_Department (Dept_Code,Dept_Name,Dept_Addr,Dept_Tel,Dept_Manager,Stat,CreateTime,Creator,Dept_PCode,CreateDate,UpdateDate,DeleteDate,Dept_Udef1,Dept_Udef2,Dept_Udef3,Dept_Udef5,Dept_Udef6,Dept_Udef7,Dept_Udef8,Dept_Udef9,Dept_Udef10) VALUES (@Dept_Code,@Dept_Name,@Dept_Addr,@Dept_Tel,@Dept_Manager,@Stat,@CreateTime,@Creator,@Dept_PCode,@CreateDate,@UpdateDate,@DeleteDate,@Dept_Udef1,@Dept_Udef2,@Dept_Udef3,@Dept_Udef5,@Dept_Udef6,@Dept_Udef7,@Dept_Udef8,@Dept_Udef9,@Dept_Udef10)";
         if (string.IsNullOrEmpty(hR_Department.Dept_Code))
         {
            idb.AddParameter("@Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Code", hR_Department.Dept_Code);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Name))
         {
            idb.AddParameter("@Dept_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Name", hR_Department.Dept_Name);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Addr))
         {
            idb.AddParameter("@Dept_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Addr", hR_Department.Dept_Addr);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Tel))
         {
            idb.AddParameter("@Dept_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Tel", hR_Department.Dept_Tel);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Manager))
         {
            idb.AddParameter("@Dept_Manager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Manager", hR_Department.Dept_Manager);
         }
         if (hR_Department.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Department.Stat);
         }
         if (hR_Department.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_Department.CreateTime);
         }
         if (string.IsNullOrEmpty(hR_Department.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_Department.Creator);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_PCode))
         {
            idb.AddParameter("@Dept_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_PCode", hR_Department.Dept_PCode);
         }
         if (hR_Department.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Department.CreateDate);
         }
         if (hR_Department.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Department.UpdateDate);
         }
         if (hR_Department.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Department.DeleteDate);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef1))
         {
            idb.AddParameter("@Dept_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef1", hR_Department.Dept_Udef1);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef2))
         {
            idb.AddParameter("@Dept_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef2", hR_Department.Dept_Udef2);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef3))
         {
            idb.AddParameter("@Dept_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef3", hR_Department.Dept_Udef3);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef5))
         {
            idb.AddParameter("@Dept_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef5", hR_Department.Dept_Udef5);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef6))
         {
            idb.AddParameter("@Dept_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef6", hR_Department.Dept_Udef6);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef7))
         {
            idb.AddParameter("@Dept_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef7", hR_Department.Dept_Udef7);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef8))
         {
            idb.AddParameter("@Dept_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef8", hR_Department.Dept_Udef8);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef9))
         {
            idb.AddParameter("@Dept_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef9", hR_Department.Dept_Udef9);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef10))
         {
            idb.AddParameter("@Dept_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef10", hR_Department.Dept_Udef10);
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
      /// 添加部门信息 HR_Department对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_Department hR_Department)
      {
         string sql = "INSERT INTO HR_Department (Dept_Code,Dept_Name,Dept_Addr,Dept_Tel,Dept_Manager,Stat,CreateTime,Creator,Dept_PCode,CreateDate,UpdateDate,DeleteDate,Dept_Udef1,Dept_Udef2,Dept_Udef3,Dept_Udef5,Dept_Udef6,Dept_Udef7,Dept_Udef8,Dept_Udef9,Dept_Udef10) VALUES (@Dept_Code,@Dept_Name,@Dept_Addr,@Dept_Tel,@Dept_Manager,@Stat,@CreateTime,@Creator,@Dept_PCode,@CreateDate,@UpdateDate,@DeleteDate,@Dept_Udef1,@Dept_Udef2,@Dept_Udef3,@Dept_Udef5,@Dept_Udef6,@Dept_Udef7,@Dept_Udef8,@Dept_Udef9,@Dept_Udef10);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_Department.Dept_Code))
         {
            idb.AddParameter("@Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Code", hR_Department.Dept_Code);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Name))
         {
            idb.AddParameter("@Dept_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Name", hR_Department.Dept_Name);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Addr))
         {
            idb.AddParameter("@Dept_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Addr", hR_Department.Dept_Addr);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Tel))
         {
            idb.AddParameter("@Dept_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Tel", hR_Department.Dept_Tel);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Manager))
         {
            idb.AddParameter("@Dept_Manager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Manager", hR_Department.Dept_Manager);
         }
         if (hR_Department.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Department.Stat);
         }
         if (hR_Department.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_Department.CreateTime);
         }
         if (string.IsNullOrEmpty(hR_Department.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_Department.Creator);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_PCode))
         {
            idb.AddParameter("@Dept_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_PCode", hR_Department.Dept_PCode);
         }
         if (hR_Department.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Department.CreateDate);
         }
         if (hR_Department.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Department.UpdateDate);
         }
         if (hR_Department.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Department.DeleteDate);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef1))
         {
            idb.AddParameter("@Dept_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef1", hR_Department.Dept_Udef1);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef2))
         {
            idb.AddParameter("@Dept_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef2", hR_Department.Dept_Udef2);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef3))
         {
            idb.AddParameter("@Dept_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef3", hR_Department.Dept_Udef3);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef5))
         {
            idb.AddParameter("@Dept_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef5", hR_Department.Dept_Udef5);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef6))
         {
            idb.AddParameter("@Dept_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef6", hR_Department.Dept_Udef6);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef7))
         {
            idb.AddParameter("@Dept_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef7", hR_Department.Dept_Udef7);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef8))
         {
            idb.AddParameter("@Dept_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef8", hR_Department.Dept_Udef8);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef9))
         {
            idb.AddParameter("@Dept_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef9", hR_Department.Dept_Udef9);
         }
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef10))
         {
            idb.AddParameter("@Dept_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef10", hR_Department.Dept_Udef10);
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
      /// 更新部门信息 HR_Department对象(即:一条记录
      /// </summary>
      public int Update(HR_Department hR_Department)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_Department       SET ");
            if(hR_Department.Dept_Code_IsChanged){sbParameter.Append("Dept_Code=@Dept_Code, ");}
      if(hR_Department.Dept_Name_IsChanged){sbParameter.Append("Dept_Name=@Dept_Name, ");}
      if(hR_Department.Dept_Addr_IsChanged){sbParameter.Append("Dept_Addr=@Dept_Addr, ");}
      if(hR_Department.Dept_Tel_IsChanged){sbParameter.Append("Dept_Tel=@Dept_Tel, ");}
      if(hR_Department.Dept_Manager_IsChanged){sbParameter.Append("Dept_Manager=@Dept_Manager, ");}
      if(hR_Department.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_Department.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(hR_Department.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(hR_Department.Dept_PCode_IsChanged){sbParameter.Append("Dept_PCode=@Dept_PCode, ");}
      if(hR_Department.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_Department.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hR_Department.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(hR_Department.Dept_Udef1_IsChanged){sbParameter.Append("Dept_Udef1=@Dept_Udef1, ");}
      if(hR_Department.Dept_Udef2_IsChanged){sbParameter.Append("Dept_Udef2=@Dept_Udef2, ");}
      if(hR_Department.Dept_Udef3_IsChanged){sbParameter.Append("Dept_Udef3=@Dept_Udef3, ");}
      if(hR_Department.Dept_Udef5_IsChanged){sbParameter.Append("Dept_Udef5=@Dept_Udef5, ");}
      if(hR_Department.Dept_Udef6_IsChanged){sbParameter.Append("Dept_Udef6=@Dept_Udef6, ");}
      if(hR_Department.Dept_Udef7_IsChanged){sbParameter.Append("Dept_Udef7=@Dept_Udef7, ");}
      if(hR_Department.Dept_Udef8_IsChanged){sbParameter.Append("Dept_Udef8=@Dept_Udef8, ");}
      if(hR_Department.Dept_Udef9_IsChanged){sbParameter.Append("Dept_Udef9=@Dept_Udef9, ");}
      if(hR_Department.Dept_Udef10_IsChanged){sbParameter.Append("Dept_Udef10=@Dept_Udef10 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Dept_ID=@Dept_ID; " );
      string sql=sb.ToString();
         if(hR_Department.Dept_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Code))
         {
            idb.AddParameter("@Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Code", hR_Department.Dept_Code);
         }
          }
         if(hR_Department.Dept_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Name))
         {
            idb.AddParameter("@Dept_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Name", hR_Department.Dept_Name);
         }
          }
         if(hR_Department.Dept_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Addr))
         {
            idb.AddParameter("@Dept_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Addr", hR_Department.Dept_Addr);
         }
          }
         if(hR_Department.Dept_Tel_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Tel))
         {
            idb.AddParameter("@Dept_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Tel", hR_Department.Dept_Tel);
         }
          }
         if(hR_Department.Dept_Manager_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Manager))
         {
            idb.AddParameter("@Dept_Manager", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Manager", hR_Department.Dept_Manager);
         }
          }
         if(hR_Department.Stat_IsChanged)
         {
         if (hR_Department.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_Department.Stat);
         }
          }
         if(hR_Department.CreateTime_IsChanged)
         {
         if (hR_Department.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_Department.CreateTime);
         }
          }
         if(hR_Department.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_Department.Creator);
         }
          }
         if(hR_Department.Dept_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_PCode))
         {
            idb.AddParameter("@Dept_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_PCode", hR_Department.Dept_PCode);
         }
          }
         if(hR_Department.CreateDate_IsChanged)
         {
         if (hR_Department.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_Department.CreateDate);
         }
          }
         if(hR_Department.UpdateDate_IsChanged)
         {
         if (hR_Department.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_Department.UpdateDate);
         }
          }
         if(hR_Department.DeleteDate_IsChanged)
         {
         if (hR_Department.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_Department.DeleteDate);
         }
          }
         if(hR_Department.Dept_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef1))
         {
            idb.AddParameter("@Dept_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef1", hR_Department.Dept_Udef1);
         }
          }
         if(hR_Department.Dept_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef2))
         {
            idb.AddParameter("@Dept_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef2", hR_Department.Dept_Udef2);
         }
          }
         if(hR_Department.Dept_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef3))
         {
            idb.AddParameter("@Dept_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef3", hR_Department.Dept_Udef3);
         }
          }
         if(hR_Department.Dept_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef5))
         {
            idb.AddParameter("@Dept_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef5", hR_Department.Dept_Udef5);
         }
          }
         if(hR_Department.Dept_Udef6_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef6))
         {
            idb.AddParameter("@Dept_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef6", hR_Department.Dept_Udef6);
         }
          }
         if(hR_Department.Dept_Udef7_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef7))
         {
            idb.AddParameter("@Dept_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef7", hR_Department.Dept_Udef7);
         }
          }
         if(hR_Department.Dept_Udef8_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef8))
         {
            idb.AddParameter("@Dept_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef8", hR_Department.Dept_Udef8);
         }
          }
         if(hR_Department.Dept_Udef9_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef9))
         {
            idb.AddParameter("@Dept_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef9", hR_Department.Dept_Udef9);
         }
          }
         if(hR_Department.Dept_Udef10_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_Department.Dept_Udef10))
         {
            idb.AddParameter("@Dept_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Dept_Udef10", hR_Department.Dept_Udef10);
         }
          }

         idb.AddParameter("@Dept_ID", hR_Department.Dept_ID);

           
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
      /// 删除部门信息 HR_Department对象(即:一条记录
      /// </summary>
      public int Delete(decimal dept_ID)
      {
         string sql = "DELETE HR_Department WHERE 1=1  AND Dept_ID=@Dept_ID ";
         idb.AddParameter("@Dept_ID", dept_ID);

           
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
      /// 获取指定的部门信息 HR_Department对象(即:一条记录
      /// </summary>
      public HR_Department GetByKey(decimal dept_ID)
      {
         HR_Department hR_Department = new HR_Department();
         string sql = "SELECT  Dept_ID,Dept_Code,Dept_Name,Dept_Addr,Dept_Tel,Dept_Manager,Stat,CreateTime,Creator,Dept_PCode,CreateDate,UpdateDate,DeleteDate,Dept_Udef1,Dept_Udef2,Dept_Udef3,Dept_Udef5,Dept_Udef6,Dept_Udef7,Dept_Udef8,Dept_Udef9,Dept_Udef10 FROM HR_Department WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Dept_ID=@Dept_ID ";
         idb.AddParameter("@Dept_ID", dept_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Dept_ID"] != DBNull.Value) hR_Department.Dept_ID = Convert.ToDecimal(dr["Dept_ID"]);
            if (dr["Dept_Code"] != DBNull.Value) hR_Department.Dept_Code = Convert.ToString(dr["Dept_Code"]);
            if (dr["Dept_Name"] != DBNull.Value) hR_Department.Dept_Name = Convert.ToString(dr["Dept_Name"]);
            if (dr["Dept_Addr"] != DBNull.Value) hR_Department.Dept_Addr = Convert.ToString(dr["Dept_Addr"]);
            if (dr["Dept_Tel"] != DBNull.Value) hR_Department.Dept_Tel = Convert.ToString(dr["Dept_Tel"]);
            if (dr["Dept_Manager"] != DBNull.Value) hR_Department.Dept_Manager = Convert.ToString(dr["Dept_Manager"]);
            if (dr["Stat"] != DBNull.Value) hR_Department.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) hR_Department.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["Creator"] != DBNull.Value) hR_Department.Creator = Convert.ToString(dr["Creator"]);
            if (dr["Dept_PCode"] != DBNull.Value) hR_Department.Dept_PCode = Convert.ToString(dr["Dept_PCode"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Department.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Department.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Department.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Dept_Udef1"] != DBNull.Value) hR_Department.Dept_Udef1 = Convert.ToString(dr["Dept_Udef1"]);
            if (dr["Dept_Udef2"] != DBNull.Value) hR_Department.Dept_Udef2 = Convert.ToString(dr["Dept_Udef2"]);
            if (dr["Dept_Udef3"] != DBNull.Value) hR_Department.Dept_Udef3 = Convert.ToString(dr["Dept_Udef3"]);
            if (dr["Dept_Udef5"] != DBNull.Value) hR_Department.Dept_Udef5 = Convert.ToString(dr["Dept_Udef5"]);
            if (dr["Dept_Udef6"] != DBNull.Value) hR_Department.Dept_Udef6 = Convert.ToString(dr["Dept_Udef6"]);
            if (dr["Dept_Udef7"] != DBNull.Value) hR_Department.Dept_Udef7 = Convert.ToString(dr["Dept_Udef7"]);
            if (dr["Dept_Udef8"] != DBNull.Value) hR_Department.Dept_Udef8 = Convert.ToString(dr["Dept_Udef8"]);
            if (dr["Dept_Udef9"] != DBNull.Value) hR_Department.Dept_Udef9 = Convert.ToString(dr["Dept_Udef9"]);
            if (dr["Dept_Udef10"] != DBNull.Value) hR_Department.Dept_Udef10 = Convert.ToString(dr["Dept_Udef10"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_Department;
      }
      /// <summary>
      /// 获取指定的部门信息 HR_Department对象集合
      /// </summary>
      public List<HR_Department> GetListByWhere(string strCondition)
      {
         List<HR_Department> ret = new List<HR_Department>();
         string sql = "SELECT  Dept_ID,Dept_Code,Dept_Name,Dept_Addr,Dept_Tel,Dept_Manager,Stat,CreateTime,Creator,Dept_PCode,CreateDate,UpdateDate,DeleteDate,Dept_Udef1,Dept_Udef2,Dept_Udef3,Dept_Udef5,Dept_Udef6,Dept_Udef7,Dept_Udef8,Dept_Udef9,Dept_Udef10 FROM HR_Department WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            HR_Department hR_Department = new HR_Department();
            if (dr["Dept_ID"] != DBNull.Value) hR_Department.Dept_ID = Convert.ToDecimal(dr["Dept_ID"]);
            if (dr["Dept_Code"] != DBNull.Value) hR_Department.Dept_Code = Convert.ToString(dr["Dept_Code"]);
            if (dr["Dept_Name"] != DBNull.Value) hR_Department.Dept_Name = Convert.ToString(dr["Dept_Name"]);
            if (dr["Dept_Addr"] != DBNull.Value) hR_Department.Dept_Addr = Convert.ToString(dr["Dept_Addr"]);
            if (dr["Dept_Tel"] != DBNull.Value) hR_Department.Dept_Tel = Convert.ToString(dr["Dept_Tel"]);
            if (dr["Dept_Manager"] != DBNull.Value) hR_Department.Dept_Manager = Convert.ToString(dr["Dept_Manager"]);
            if (dr["Stat"] != DBNull.Value) hR_Department.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) hR_Department.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["Creator"] != DBNull.Value) hR_Department.Creator = Convert.ToString(dr["Creator"]);
            if (dr["Dept_PCode"] != DBNull.Value) hR_Department.Dept_PCode = Convert.ToString(dr["Dept_PCode"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Department.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Department.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Department.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Dept_Udef1"] != DBNull.Value) hR_Department.Dept_Udef1 = Convert.ToString(dr["Dept_Udef1"]);
            if (dr["Dept_Udef2"] != DBNull.Value) hR_Department.Dept_Udef2 = Convert.ToString(dr["Dept_Udef2"]);
            if (dr["Dept_Udef3"] != DBNull.Value) hR_Department.Dept_Udef3 = Convert.ToString(dr["Dept_Udef3"]);
            if (dr["Dept_Udef5"] != DBNull.Value) hR_Department.Dept_Udef5 = Convert.ToString(dr["Dept_Udef5"]);
            if (dr["Dept_Udef6"] != DBNull.Value) hR_Department.Dept_Udef6 = Convert.ToString(dr["Dept_Udef6"]);
            if (dr["Dept_Udef7"] != DBNull.Value) hR_Department.Dept_Udef7 = Convert.ToString(dr["Dept_Udef7"]);
            if (dr["Dept_Udef8"] != DBNull.Value) hR_Department.Dept_Udef8 = Convert.ToString(dr["Dept_Udef8"]);
            if (dr["Dept_Udef9"] != DBNull.Value) hR_Department.Dept_Udef9 = Convert.ToString(dr["Dept_Udef9"]);
            if (dr["Dept_Udef10"] != DBNull.Value) hR_Department.Dept_Udef10 = Convert.ToString(dr["Dept_Udef10"]);
            ret.Add(hR_Department);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的部门信息 HR_Department对象(即:一条记录
      /// </summary>
      public List<HR_Department> GetAll()
      {
         List<HR_Department> ret = new List<HR_Department>();
         string sql = "SELECT  Dept_ID,Dept_Code,Dept_Name,Dept_Addr,Dept_Tel,Dept_Manager,Stat,CreateTime,Creator,Dept_PCode,CreateDate,UpdateDate,DeleteDate,Dept_Udef1,Dept_Udef2,Dept_Udef3,Dept_Udef5,Dept_Udef6,Dept_Udef7,Dept_Udef8,Dept_Udef9,Dept_Udef10 FROM HR_Department where 1=1 AND ((Stat is null) or (Stat=0) ) order by Dept_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_Department hR_Department = new HR_Department();
            if (dr["Dept_ID"] != DBNull.Value) hR_Department.Dept_ID = Convert.ToDecimal(dr["Dept_ID"]);
            if (dr["Dept_Code"] != DBNull.Value) hR_Department.Dept_Code = Convert.ToString(dr["Dept_Code"]);
            if (dr["Dept_Name"] != DBNull.Value) hR_Department.Dept_Name = Convert.ToString(dr["Dept_Name"]);
            if (dr["Dept_Addr"] != DBNull.Value) hR_Department.Dept_Addr = Convert.ToString(dr["Dept_Addr"]);
            if (dr["Dept_Tel"] != DBNull.Value) hR_Department.Dept_Tel = Convert.ToString(dr["Dept_Tel"]);
            if (dr["Dept_Manager"] != DBNull.Value) hR_Department.Dept_Manager = Convert.ToString(dr["Dept_Manager"]);
            if (dr["Stat"] != DBNull.Value) hR_Department.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) hR_Department.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["Creator"] != DBNull.Value) hR_Department.Creator = Convert.ToString(dr["Creator"]);
            if (dr["Dept_PCode"] != DBNull.Value) hR_Department.Dept_PCode = Convert.ToString(dr["Dept_PCode"]);
            if (dr["CreateDate"] != DBNull.Value) hR_Department.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_Department.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_Department.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Dept_Udef1"] != DBNull.Value) hR_Department.Dept_Udef1 = Convert.ToString(dr["Dept_Udef1"]);
            if (dr["Dept_Udef2"] != DBNull.Value) hR_Department.Dept_Udef2 = Convert.ToString(dr["Dept_Udef2"]);
            if (dr["Dept_Udef3"] != DBNull.Value) hR_Department.Dept_Udef3 = Convert.ToString(dr["Dept_Udef3"]);
            if (dr["Dept_Udef5"] != DBNull.Value) hR_Department.Dept_Udef5 = Convert.ToString(dr["Dept_Udef5"]);
            if (dr["Dept_Udef6"] != DBNull.Value) hR_Department.Dept_Udef6 = Convert.ToString(dr["Dept_Udef6"]);
            if (dr["Dept_Udef7"] != DBNull.Value) hR_Department.Dept_Udef7 = Convert.ToString(dr["Dept_Udef7"]);
            if (dr["Dept_Udef8"] != DBNull.Value) hR_Department.Dept_Udef8 = Convert.ToString(dr["Dept_Udef8"]);
            if (dr["Dept_Udef9"] != DBNull.Value) hR_Department.Dept_Udef9 = Convert.ToString(dr["Dept_Udef9"]);
            if (dr["Dept_Udef10"] != DBNull.Value) hR_Department.Dept_Udef10 = Convert.ToString(dr["Dept_Udef10"]);
            ret.Add(hR_Department);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
