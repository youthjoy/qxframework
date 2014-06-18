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
   /// 档案移交记录
   /// </summary>
   [Serializable]
   public partial class ADODocument_Movement
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加档案移交记录 Document_Movement对象(即:一条记录)
      /// </summary>
      public int Add(Document_Movement document_Movement)
      {
         string sql = "INSERT INTO Document_Movement (Mov_Code,Mov_DocumentCode,Mov_FileCode,Mov_FileName,Mov_GMOperator,Mov_GDOperator,Mov_Date,Mov_OldCompany,Mov_OldDept,Mov_OldResPerson,Mov_NewCompany,Mov_NewDept,Mov_NewCopier,Mov_Num,Mov_Superintendent,Mov_Operator,Mov_OperateDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Mov_Code,@Mov_DocumentCode,@Mov_FileCode,@Mov_FileName,@Mov_GMOperator,@Mov_GDOperator,@Mov_Date,@Mov_OldCompany,@Mov_OldDept,@Mov_OldResPerson,@Mov_NewCompany,@Mov_NewDept,@Mov_NewCopier,@Mov_Num,@Mov_Superintendent,@Mov_Operator,@Mov_OperateDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(document_Movement.Mov_Code))
         {
            idb.AddParameter("@Mov_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Code", document_Movement.Mov_Code);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_DocumentCode))
         {
            idb.AddParameter("@Mov_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_DocumentCode", document_Movement.Mov_DocumentCode);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_FileCode))
         {
            idb.AddParameter("@Mov_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_FileCode", document_Movement.Mov_FileCode);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_FileName))
         {
            idb.AddParameter("@Mov_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_FileName", document_Movement.Mov_FileName);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_GMOperator))
         {
            idb.AddParameter("@Mov_GMOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_GMOperator", document_Movement.Mov_GMOperator);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_GDOperator))
         {
            idb.AddParameter("@Mov_GDOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_GDOperator", document_Movement.Mov_GDOperator);
         }
         if (document_Movement.Mov_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Mov_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Date", document_Movement.Mov_Date);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_OldCompany))
         {
            idb.AddParameter("@Mov_OldCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldCompany", document_Movement.Mov_OldCompany);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_OldDept))
         {
            idb.AddParameter("@Mov_OldDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldDept", document_Movement.Mov_OldDept);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_OldResPerson))
         {
            idb.AddParameter("@Mov_OldResPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldResPerson", document_Movement.Mov_OldResPerson);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_NewCompany))
         {
            idb.AddParameter("@Mov_NewCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewCompany", document_Movement.Mov_NewCompany);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_NewDept))
         {
            idb.AddParameter("@Mov_NewDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewDept", document_Movement.Mov_NewDept);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_NewCopier))
         {
            idb.AddParameter("@Mov_NewCopier", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewCopier", document_Movement.Mov_NewCopier);
         }
         if (document_Movement.Mov_Num == 0)
         {
            idb.AddParameter("@Mov_Num", 0);
         }
         else
         {
            idb.AddParameter("@Mov_Num", document_Movement.Mov_Num);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_Superintendent))
         {
            idb.AddParameter("@Mov_Superintendent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Superintendent", document_Movement.Mov_Superintendent);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_Operator))
         {
            idb.AddParameter("@Mov_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Operator", document_Movement.Mov_Operator);
         }
         if (document_Movement.Mov_OperateDate == DateTime.MinValue)
         {
            idb.AddParameter("@Mov_OperateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OperateDate", document_Movement.Mov_OperateDate);
         }
         if (document_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Movement.Stat);
         }
         if (document_Movement.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Movement.CreateDate);
         }
         if (document_Movement.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Movement.UpdateDate);
         }
         if (document_Movement.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Movement.DeleteDate);
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
      /// 添加档案移交记录 Document_Movement对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Document_Movement document_Movement)
      {
         string sql = "INSERT INTO Document_Movement (Mov_Code,Mov_DocumentCode,Mov_FileCode,Mov_FileName,Mov_GMOperator,Mov_GDOperator,Mov_Date,Mov_OldCompany,Mov_OldDept,Mov_OldResPerson,Mov_NewCompany,Mov_NewDept,Mov_NewCopier,Mov_Num,Mov_Superintendent,Mov_Operator,Mov_OperateDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@Mov_Code,@Mov_DocumentCode,@Mov_FileCode,@Mov_FileName,@Mov_GMOperator,@Mov_GDOperator,@Mov_Date,@Mov_OldCompany,@Mov_OldDept,@Mov_OldResPerson,@Mov_NewCompany,@Mov_NewDept,@Mov_NewCopier,@Mov_Num,@Mov_Superintendent,@Mov_Operator,@Mov_OperateDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(document_Movement.Mov_Code))
         {
            idb.AddParameter("@Mov_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Code", document_Movement.Mov_Code);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_DocumentCode))
         {
            idb.AddParameter("@Mov_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_DocumentCode", document_Movement.Mov_DocumentCode);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_FileCode))
         {
            idb.AddParameter("@Mov_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_FileCode", document_Movement.Mov_FileCode);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_FileName))
         {
            idb.AddParameter("@Mov_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_FileName", document_Movement.Mov_FileName);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_GMOperator))
         {
            idb.AddParameter("@Mov_GMOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_GMOperator", document_Movement.Mov_GMOperator);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_GDOperator))
         {
            idb.AddParameter("@Mov_GDOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_GDOperator", document_Movement.Mov_GDOperator);
         }
         if (document_Movement.Mov_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Mov_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Date", document_Movement.Mov_Date);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_OldCompany))
         {
            idb.AddParameter("@Mov_OldCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldCompany", document_Movement.Mov_OldCompany);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_OldDept))
         {
            idb.AddParameter("@Mov_OldDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldDept", document_Movement.Mov_OldDept);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_OldResPerson))
         {
            idb.AddParameter("@Mov_OldResPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldResPerson", document_Movement.Mov_OldResPerson);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_NewCompany))
         {
            idb.AddParameter("@Mov_NewCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewCompany", document_Movement.Mov_NewCompany);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_NewDept))
         {
            idb.AddParameter("@Mov_NewDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewDept", document_Movement.Mov_NewDept);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_NewCopier))
         {
            idb.AddParameter("@Mov_NewCopier", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewCopier", document_Movement.Mov_NewCopier);
         }
         if (document_Movement.Mov_Num == 0)
         {
            idb.AddParameter("@Mov_Num", 0);
         }
         else
         {
            idb.AddParameter("@Mov_Num", document_Movement.Mov_Num);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_Superintendent))
         {
            idb.AddParameter("@Mov_Superintendent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Superintendent", document_Movement.Mov_Superintendent);
         }
         if (string.IsNullOrEmpty(document_Movement.Mov_Operator))
         {
            idb.AddParameter("@Mov_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Operator", document_Movement.Mov_Operator);
         }
         if (document_Movement.Mov_OperateDate == DateTime.MinValue)
         {
            idb.AddParameter("@Mov_OperateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OperateDate", document_Movement.Mov_OperateDate);
         }
         if (document_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Movement.Stat);
         }
         if (document_Movement.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Movement.CreateDate);
         }
         if (document_Movement.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Movement.UpdateDate);
         }
         if (document_Movement.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Movement.DeleteDate);
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
      /// 更新档案移交记录 Document_Movement对象(即:一条记录
      /// </summary>
      public int Update(Document_Movement document_Movement)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Document_Movement       SET ");
            if(document_Movement.Mov_Code_IsChanged){sbParameter.Append("Mov_Code=@Mov_Code, ");}
      if(document_Movement.Mov_DocumentCode_IsChanged){sbParameter.Append("Mov_DocumentCode=@Mov_DocumentCode, ");}
      if(document_Movement.Mov_FileCode_IsChanged){sbParameter.Append("Mov_FileCode=@Mov_FileCode, ");}
      if(document_Movement.Mov_FileName_IsChanged){sbParameter.Append("Mov_FileName=@Mov_FileName, ");}
      if(document_Movement.Mov_GMOperator_IsChanged){sbParameter.Append("Mov_GMOperator=@Mov_GMOperator, ");}
      if(document_Movement.Mov_GDOperator_IsChanged){sbParameter.Append("Mov_GDOperator=@Mov_GDOperator, ");}
      if(document_Movement.Mov_Date_IsChanged){sbParameter.Append("Mov_Date=@Mov_Date, ");}
      if(document_Movement.Mov_OldCompany_IsChanged){sbParameter.Append("Mov_OldCompany=@Mov_OldCompany, ");}
      if(document_Movement.Mov_OldDept_IsChanged){sbParameter.Append("Mov_OldDept=@Mov_OldDept, ");}
      if(document_Movement.Mov_OldResPerson_IsChanged){sbParameter.Append("Mov_OldResPerson=@Mov_OldResPerson, ");}
      if(document_Movement.Mov_NewCompany_IsChanged){sbParameter.Append("Mov_NewCompany=@Mov_NewCompany, ");}
      if(document_Movement.Mov_NewDept_IsChanged){sbParameter.Append("Mov_NewDept=@Mov_NewDept, ");}
      if(document_Movement.Mov_NewCopier_IsChanged){sbParameter.Append("Mov_NewCopier=@Mov_NewCopier, ");}
      if(document_Movement.Mov_Num_IsChanged){sbParameter.Append("Mov_Num=@Mov_Num, ");}
      if(document_Movement.Mov_Superintendent_IsChanged){sbParameter.Append("Mov_Superintendent=@Mov_Superintendent, ");}
      if(document_Movement.Mov_Operator_IsChanged){sbParameter.Append("Mov_Operator=@Mov_Operator, ");}
      if(document_Movement.Mov_OperateDate_IsChanged){sbParameter.Append("Mov_OperateDate=@Mov_OperateDate, ");}
      if(document_Movement.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(document_Movement.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(document_Movement.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(document_Movement.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Mov_ID=@Mov_ID; " );
      string sql=sb.ToString();
         if(document_Movement.Mov_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_Code))
         {
            idb.AddParameter("@Mov_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Code", document_Movement.Mov_Code);
         }
          }
         if(document_Movement.Mov_DocumentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_DocumentCode))
         {
            idb.AddParameter("@Mov_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_DocumentCode", document_Movement.Mov_DocumentCode);
         }
          }
         if(document_Movement.Mov_FileCode_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_FileCode))
         {
            idb.AddParameter("@Mov_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_FileCode", document_Movement.Mov_FileCode);
         }
          }
         if(document_Movement.Mov_FileName_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_FileName))
         {
            idb.AddParameter("@Mov_FileName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_FileName", document_Movement.Mov_FileName);
         }
          }
         if(document_Movement.Mov_GMOperator_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_GMOperator))
         {
            idb.AddParameter("@Mov_GMOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_GMOperator", document_Movement.Mov_GMOperator);
         }
          }
         if(document_Movement.Mov_GDOperator_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_GDOperator))
         {
            idb.AddParameter("@Mov_GDOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_GDOperator", document_Movement.Mov_GDOperator);
         }
          }
         if(document_Movement.Mov_Date_IsChanged)
         {
         if (document_Movement.Mov_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Mov_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Date", document_Movement.Mov_Date);
         }
          }
         if(document_Movement.Mov_OldCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_OldCompany))
         {
            idb.AddParameter("@Mov_OldCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldCompany", document_Movement.Mov_OldCompany);
         }
          }
         if(document_Movement.Mov_OldDept_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_OldDept))
         {
            idb.AddParameter("@Mov_OldDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldDept", document_Movement.Mov_OldDept);
         }
          }
         if(document_Movement.Mov_OldResPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_OldResPerson))
         {
            idb.AddParameter("@Mov_OldResPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OldResPerson", document_Movement.Mov_OldResPerson);
         }
          }
         if(document_Movement.Mov_NewCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_NewCompany))
         {
            idb.AddParameter("@Mov_NewCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewCompany", document_Movement.Mov_NewCompany);
         }
          }
         if(document_Movement.Mov_NewDept_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_NewDept))
         {
            idb.AddParameter("@Mov_NewDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewDept", document_Movement.Mov_NewDept);
         }
          }
         if(document_Movement.Mov_NewCopier_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_NewCopier))
         {
            idb.AddParameter("@Mov_NewCopier", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_NewCopier", document_Movement.Mov_NewCopier);
         }
          }
         if(document_Movement.Mov_Num_IsChanged)
         {
         if (document_Movement.Mov_Num == 0)
         {
            idb.AddParameter("@Mov_Num", 0);
         }
         else
         {
            idb.AddParameter("@Mov_Num", document_Movement.Mov_Num);
         }
          }
         if(document_Movement.Mov_Superintendent_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_Superintendent))
         {
            idb.AddParameter("@Mov_Superintendent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Superintendent", document_Movement.Mov_Superintendent);
         }
          }
         if(document_Movement.Mov_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Movement.Mov_Operator))
         {
            idb.AddParameter("@Mov_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_Operator", document_Movement.Mov_Operator);
         }
          }
         if(document_Movement.Mov_OperateDate_IsChanged)
         {
         if (document_Movement.Mov_OperateDate == DateTime.MinValue)
         {
            idb.AddParameter("@Mov_OperateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Mov_OperateDate", document_Movement.Mov_OperateDate);
         }
          }
         if(document_Movement.Stat_IsChanged)
         {
         if (document_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Movement.Stat);
         }
          }
         if(document_Movement.CreateDate_IsChanged)
         {
         if (document_Movement.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Movement.CreateDate);
         }
          }
         if(document_Movement.UpdateDate_IsChanged)
         {
         if (document_Movement.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Movement.UpdateDate);
         }
          }
         if(document_Movement.DeleteDate_IsChanged)
         {
         if (document_Movement.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Movement.DeleteDate);
         }
          }

         idb.AddParameter("@Mov_ID", document_Movement.Mov_ID);

           
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
      /// 删除档案移交记录 Document_Movement对象(即:一条记录
      /// </summary>
      public int Delete(decimal mov_ID)
      {
         string sql = "DELETE Document_Movement WHERE 1=1  AND Mov_ID=@Mov_ID ";
         idb.AddParameter("@Mov_ID", mov_ID);

           
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
      /// 获取指定的档案移交记录 Document_Movement对象(即:一条记录
      /// </summary>
      public Document_Movement GetByKey(decimal mov_ID)
      {
         Document_Movement document_Movement = new Document_Movement();
         string sql = "SELECT  Mov_ID,Mov_Code,Mov_DocumentCode,Mov_FileCode,Mov_FileName,Mov_GMOperator,Mov_GDOperator,Mov_Date,Mov_OldCompany,Mov_OldDept,Mov_OldResPerson,Mov_NewCompany,Mov_NewDept,Mov_NewCopier,Mov_Num,Mov_Superintendent,Mov_Operator,Mov_OperateDate,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Movement WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Mov_ID=@Mov_ID ";
         idb.AddParameter("@Mov_ID", mov_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Mov_ID"] != DBNull.Value) document_Movement.Mov_ID = Convert.ToDecimal(dr["Mov_ID"]);
            if (dr["Mov_Code"] != DBNull.Value) document_Movement.Mov_Code = Convert.ToString(dr["Mov_Code"]);
            if (dr["Mov_DocumentCode"] != DBNull.Value) document_Movement.Mov_DocumentCode = Convert.ToString(dr["Mov_DocumentCode"]);
            if (dr["Mov_FileCode"] != DBNull.Value) document_Movement.Mov_FileCode = Convert.ToString(dr["Mov_FileCode"]);
            if (dr["Mov_FileName"] != DBNull.Value) document_Movement.Mov_FileName = Convert.ToString(dr["Mov_FileName"]);
            if (dr["Mov_GMOperator"] != DBNull.Value) document_Movement.Mov_GMOperator = Convert.ToString(dr["Mov_GMOperator"]);
            if (dr["Mov_GDOperator"] != DBNull.Value) document_Movement.Mov_GDOperator = Convert.ToString(dr["Mov_GDOperator"]);
            if (dr["Mov_Date"] != DBNull.Value) document_Movement.Mov_Date = Convert.ToDateTime(dr["Mov_Date"]);
            if (dr["Mov_OldCompany"] != DBNull.Value) document_Movement.Mov_OldCompany = Convert.ToString(dr["Mov_OldCompany"]);
            if (dr["Mov_OldDept"] != DBNull.Value) document_Movement.Mov_OldDept = Convert.ToString(dr["Mov_OldDept"]);
            if (dr["Mov_OldResPerson"] != DBNull.Value) document_Movement.Mov_OldResPerson = Convert.ToString(dr["Mov_OldResPerson"]);
            if (dr["Mov_NewCompany"] != DBNull.Value) document_Movement.Mov_NewCompany = Convert.ToString(dr["Mov_NewCompany"]);
            if (dr["Mov_NewDept"] != DBNull.Value) document_Movement.Mov_NewDept = Convert.ToString(dr["Mov_NewDept"]);
            if (dr["Mov_NewCopier"] != DBNull.Value) document_Movement.Mov_NewCopier = Convert.ToString(dr["Mov_NewCopier"]);
            if (dr["Mov_Num"] != DBNull.Value) document_Movement.Mov_Num = Convert.ToInt32(dr["Mov_Num"]);
            if (dr["Mov_Superintendent"] != DBNull.Value) document_Movement.Mov_Superintendent = Convert.ToString(dr["Mov_Superintendent"]);
            if (dr["Mov_Operator"] != DBNull.Value) document_Movement.Mov_Operator = Convert.ToString(dr["Mov_Operator"]);
            if (dr["Mov_OperateDate"] != DBNull.Value) document_Movement.Mov_OperateDate = Convert.ToDateTime(dr["Mov_OperateDate"]);
            if (dr["Stat"] != DBNull.Value) document_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Movement.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Movement.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Movement.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return document_Movement;
      }
      /// <summary>
      /// 获取指定的档案移交记录 Document_Movement对象集合
      /// </summary>
      public List<Document_Movement> GetListByWhere(string strCondition)
      {
         List<Document_Movement> ret = new List<Document_Movement>();
         string sql = "SELECT  Mov_ID,Mov_Code,Mov_DocumentCode,Mov_FileCode,Mov_FileName,Mov_GMOperator,Mov_GDOperator,Mov_Date,Mov_OldCompany,Mov_OldDept,Mov_OldResPerson,Mov_NewCompany,Mov_NewDept,Mov_NewCopier,Mov_Num,Mov_Superintendent,Mov_Operator,Mov_OperateDate,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Movement WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Document_Movement document_Movement = new Document_Movement();
            if (dr["Mov_ID"] != DBNull.Value) document_Movement.Mov_ID = Convert.ToDecimal(dr["Mov_ID"]);
            if (dr["Mov_Code"] != DBNull.Value) document_Movement.Mov_Code = Convert.ToString(dr["Mov_Code"]);
            if (dr["Mov_DocumentCode"] != DBNull.Value) document_Movement.Mov_DocumentCode = Convert.ToString(dr["Mov_DocumentCode"]);
            if (dr["Mov_FileCode"] != DBNull.Value) document_Movement.Mov_FileCode = Convert.ToString(dr["Mov_FileCode"]);
            if (dr["Mov_FileName"] != DBNull.Value) document_Movement.Mov_FileName = Convert.ToString(dr["Mov_FileName"]);
            if (dr["Mov_GMOperator"] != DBNull.Value) document_Movement.Mov_GMOperator = Convert.ToString(dr["Mov_GMOperator"]);
            if (dr["Mov_GDOperator"] != DBNull.Value) document_Movement.Mov_GDOperator = Convert.ToString(dr["Mov_GDOperator"]);
            if (dr["Mov_Date"] != DBNull.Value) document_Movement.Mov_Date = Convert.ToDateTime(dr["Mov_Date"]);
            if (dr["Mov_OldCompany"] != DBNull.Value) document_Movement.Mov_OldCompany = Convert.ToString(dr["Mov_OldCompany"]);
            if (dr["Mov_OldDept"] != DBNull.Value) document_Movement.Mov_OldDept = Convert.ToString(dr["Mov_OldDept"]);
            if (dr["Mov_OldResPerson"] != DBNull.Value) document_Movement.Mov_OldResPerson = Convert.ToString(dr["Mov_OldResPerson"]);
            if (dr["Mov_NewCompany"] != DBNull.Value) document_Movement.Mov_NewCompany = Convert.ToString(dr["Mov_NewCompany"]);
            if (dr["Mov_NewDept"] != DBNull.Value) document_Movement.Mov_NewDept = Convert.ToString(dr["Mov_NewDept"]);
            if (dr["Mov_NewCopier"] != DBNull.Value) document_Movement.Mov_NewCopier = Convert.ToString(dr["Mov_NewCopier"]);
            if (dr["Mov_Num"] != DBNull.Value) document_Movement.Mov_Num = Convert.ToInt32(dr["Mov_Num"]);
            if (dr["Mov_Superintendent"] != DBNull.Value) document_Movement.Mov_Superintendent = Convert.ToString(dr["Mov_Superintendent"]);
            if (dr["Mov_Operator"] != DBNull.Value) document_Movement.Mov_Operator = Convert.ToString(dr["Mov_Operator"]);
            if (dr["Mov_OperateDate"] != DBNull.Value) document_Movement.Mov_OperateDate = Convert.ToDateTime(dr["Mov_OperateDate"]);
            if (dr["Stat"] != DBNull.Value) document_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Movement.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Movement.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Movement.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_Movement);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的档案移交记录 Document_Movement对象(即:一条记录
      /// </summary>
      public List<Document_Movement> GetAll()
      {
         List<Document_Movement> ret = new List<Document_Movement>();
         string sql = "SELECT  Mov_ID,Mov_Code,Mov_DocumentCode,Mov_FileCode,Mov_FileName,Mov_GMOperator,Mov_GDOperator,Mov_Date,Mov_OldCompany,Mov_OldDept,Mov_OldResPerson,Mov_NewCompany,Mov_NewDept,Mov_NewCopier,Mov_Num,Mov_Superintendent,Mov_Operator,Mov_OperateDate,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Movement where 1=1 AND ((Stat is null) or (Stat=0) ) order by Mov_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Document_Movement document_Movement = new Document_Movement();
            if (dr["Mov_ID"] != DBNull.Value) document_Movement.Mov_ID = Convert.ToDecimal(dr["Mov_ID"]);
            if (dr["Mov_Code"] != DBNull.Value) document_Movement.Mov_Code = Convert.ToString(dr["Mov_Code"]);
            if (dr["Mov_DocumentCode"] != DBNull.Value) document_Movement.Mov_DocumentCode = Convert.ToString(dr["Mov_DocumentCode"]);
            if (dr["Mov_FileCode"] != DBNull.Value) document_Movement.Mov_FileCode = Convert.ToString(dr["Mov_FileCode"]);
            if (dr["Mov_FileName"] != DBNull.Value) document_Movement.Mov_FileName = Convert.ToString(dr["Mov_FileName"]);
            if (dr["Mov_GMOperator"] != DBNull.Value) document_Movement.Mov_GMOperator = Convert.ToString(dr["Mov_GMOperator"]);
            if (dr["Mov_GDOperator"] != DBNull.Value) document_Movement.Mov_GDOperator = Convert.ToString(dr["Mov_GDOperator"]);
            if (dr["Mov_Date"] != DBNull.Value) document_Movement.Mov_Date = Convert.ToDateTime(dr["Mov_Date"]);
            if (dr["Mov_OldCompany"] != DBNull.Value) document_Movement.Mov_OldCompany = Convert.ToString(dr["Mov_OldCompany"]);
            if (dr["Mov_OldDept"] != DBNull.Value) document_Movement.Mov_OldDept = Convert.ToString(dr["Mov_OldDept"]);
            if (dr["Mov_OldResPerson"] != DBNull.Value) document_Movement.Mov_OldResPerson = Convert.ToString(dr["Mov_OldResPerson"]);
            if (dr["Mov_NewCompany"] != DBNull.Value) document_Movement.Mov_NewCompany = Convert.ToString(dr["Mov_NewCompany"]);
            if (dr["Mov_NewDept"] != DBNull.Value) document_Movement.Mov_NewDept = Convert.ToString(dr["Mov_NewDept"]);
            if (dr["Mov_NewCopier"] != DBNull.Value) document_Movement.Mov_NewCopier = Convert.ToString(dr["Mov_NewCopier"]);
            if (dr["Mov_Num"] != DBNull.Value) document_Movement.Mov_Num = Convert.ToInt32(dr["Mov_Num"]);
            if (dr["Mov_Superintendent"] != DBNull.Value) document_Movement.Mov_Superintendent = Convert.ToString(dr["Mov_Superintendent"]);
            if (dr["Mov_Operator"] != DBNull.Value) document_Movement.Mov_Operator = Convert.ToString(dr["Mov_Operator"]);
            if (dr["Mov_OperateDate"] != DBNull.Value) document_Movement.Mov_OperateDate = Convert.ToDateTime(dr["Mov_OperateDate"]);
            if (dr["Stat"] != DBNull.Value) document_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Movement.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Movement.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Movement.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_Movement);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
