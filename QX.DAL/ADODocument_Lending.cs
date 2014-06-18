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
   /// 档案借阅记录
   /// </summary>
   [Serializable]
   public partial class ADODocument_Lending
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加档案借阅记录 Document_Lending对象(即:一条记录)
      /// </summary>
      public int Add(Document_Lending document_Lending)
      {
         string sql = "INSERT INTO Document_Lending (DL_Code,DL_DocumentCode,DL_DocumentName,DL_FileCode,DL_ISBN,DL_LendingType,DL_ReturnType,DL_LendingNum,DL_LendorCompany,DL_LendorDept,DL_Person,DL_LendingDate,DL_Operator,DL_LendingReason,DL_Authorizor,DL_ReturnNum,DL_ReturnDate,DL_ReturnOperator,DL_ReturnRemark,DL_Stat,DL_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@DL_Code,@DL_DocumentCode,@DL_DocumentName,@DL_FileCode,@DL_ISBN,@DL_LendingType,@DL_ReturnType,@DL_LendingNum,@DL_LendorCompany,@DL_LendorDept,@DL_Person,@DL_LendingDate,@DL_Operator,@DL_LendingReason,@DL_Authorizor,@DL_ReturnNum,@DL_ReturnDate,@DL_ReturnOperator,@DL_ReturnRemark,@DL_Stat,@DL_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(document_Lending.DL_Code))
         {
            idb.AddParameter("@DL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Code", document_Lending.DL_Code);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_DocumentCode))
         {
            idb.AddParameter("@DL_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_DocumentCode", document_Lending.DL_DocumentCode);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_DocumentName))
         {
            idb.AddParameter("@DL_DocumentName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_DocumentName", document_Lending.DL_DocumentName);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_FileCode))
         {
            idb.AddParameter("@DL_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_FileCode", document_Lending.DL_FileCode);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ISBN))
         {
            idb.AddParameter("@DL_ISBN", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ISBN", document_Lending.DL_ISBN);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendingType))
         {
            idb.AddParameter("@DL_LendingType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingType", document_Lending.DL_LendingType);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnType))
         {
            idb.AddParameter("@DL_ReturnType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnType", document_Lending.DL_ReturnType);
         }
         if (document_Lending.DL_LendingNum == 0)
         {
            idb.AddParameter("@DL_LendingNum", 0);
         }
         else
         {
            idb.AddParameter("@DL_LendingNum", document_Lending.DL_LendingNum);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendorCompany))
         {
            idb.AddParameter("@DL_LendorCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendorCompany", document_Lending.DL_LendorCompany);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendorDept))
         {
            idb.AddParameter("@DL_LendorDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendorDept", document_Lending.DL_LendorDept);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Person))
         {
            idb.AddParameter("@DL_Person", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Person", document_Lending.DL_Person);
         }
         if (document_Lending.DL_LendingDate == DateTime.MinValue)
         {
            idb.AddParameter("@DL_LendingDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingDate", document_Lending.DL_LendingDate);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Operator))
         {
            idb.AddParameter("@DL_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Operator", document_Lending.DL_Operator);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendingReason))
         {
            idb.AddParameter("@DL_LendingReason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingReason", document_Lending.DL_LendingReason);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Authorizor))
         {
            idb.AddParameter("@DL_Authorizor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Authorizor", document_Lending.DL_Authorizor);
         }
         if (document_Lending.DL_ReturnNum == 0)
         {
            idb.AddParameter("@DL_ReturnNum", 0);
         }
         else
         {
            idb.AddParameter("@DL_ReturnNum", document_Lending.DL_ReturnNum);
         }
         if (document_Lending.DL_ReturnDate == DateTime.MinValue)
         {
            idb.AddParameter("@DL_ReturnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnDate", document_Lending.DL_ReturnDate);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnOperator))
         {
            idb.AddParameter("@DL_ReturnOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnOperator", document_Lending.DL_ReturnOperator);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnRemark))
         {
            idb.AddParameter("@DL_ReturnRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnRemark", document_Lending.DL_ReturnRemark);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Stat))
         {
            idb.AddParameter("@DL_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Stat", document_Lending.DL_Stat);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Remark))
         {
            idb.AddParameter("@DL_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Remark", document_Lending.DL_Remark);
         }
         if (document_Lending.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Lending.Stat);
         }
         if (document_Lending.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Lending.CreateDate);
         }
         if (document_Lending.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Lending.UpdateDate);
         }
         if (document_Lending.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Lending.DeleteDate);
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
      /// 添加档案借阅记录 Document_Lending对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Document_Lending document_Lending)
      {
         string sql = "INSERT INTO Document_Lending (DL_Code,DL_DocumentCode,DL_DocumentName,DL_FileCode,DL_ISBN,DL_LendingType,DL_ReturnType,DL_LendingNum,DL_LendorCompany,DL_LendorDept,DL_Person,DL_LendingDate,DL_Operator,DL_LendingReason,DL_Authorizor,DL_ReturnNum,DL_ReturnDate,DL_ReturnOperator,DL_ReturnRemark,DL_Stat,DL_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@DL_Code,@DL_DocumentCode,@DL_DocumentName,@DL_FileCode,@DL_ISBN,@DL_LendingType,@DL_ReturnType,@DL_LendingNum,@DL_LendorCompany,@DL_LendorDept,@DL_Person,@DL_LendingDate,@DL_Operator,@DL_LendingReason,@DL_Authorizor,@DL_ReturnNum,@DL_ReturnDate,@DL_ReturnOperator,@DL_ReturnRemark,@DL_Stat,@DL_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(document_Lending.DL_Code))
         {
            idb.AddParameter("@DL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Code", document_Lending.DL_Code);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_DocumentCode))
         {
            idb.AddParameter("@DL_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_DocumentCode", document_Lending.DL_DocumentCode);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_DocumentName))
         {
            idb.AddParameter("@DL_DocumentName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_DocumentName", document_Lending.DL_DocumentName);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_FileCode))
         {
            idb.AddParameter("@DL_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_FileCode", document_Lending.DL_FileCode);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ISBN))
         {
            idb.AddParameter("@DL_ISBN", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ISBN", document_Lending.DL_ISBN);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendingType))
         {
            idb.AddParameter("@DL_LendingType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingType", document_Lending.DL_LendingType);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnType))
         {
            idb.AddParameter("@DL_ReturnType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnType", document_Lending.DL_ReturnType);
         }
         if (document_Lending.DL_LendingNum == 0)
         {
            idb.AddParameter("@DL_LendingNum", 0);
         }
         else
         {
            idb.AddParameter("@DL_LendingNum", document_Lending.DL_LendingNum);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendorCompany))
         {
            idb.AddParameter("@DL_LendorCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendorCompany", document_Lending.DL_LendorCompany);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendorDept))
         {
            idb.AddParameter("@DL_LendorDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendorDept", document_Lending.DL_LendorDept);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Person))
         {
            idb.AddParameter("@DL_Person", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Person", document_Lending.DL_Person);
         }
         if (document_Lending.DL_LendingDate == DateTime.MinValue)
         {
            idb.AddParameter("@DL_LendingDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingDate", document_Lending.DL_LendingDate);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Operator))
         {
            idb.AddParameter("@DL_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Operator", document_Lending.DL_Operator);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_LendingReason))
         {
            idb.AddParameter("@DL_LendingReason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingReason", document_Lending.DL_LendingReason);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Authorizor))
         {
            idb.AddParameter("@DL_Authorizor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Authorizor", document_Lending.DL_Authorizor);
         }
         if (document_Lending.DL_ReturnNum == 0)
         {
            idb.AddParameter("@DL_ReturnNum", 0);
         }
         else
         {
            idb.AddParameter("@DL_ReturnNum", document_Lending.DL_ReturnNum);
         }
         if (document_Lending.DL_ReturnDate == DateTime.MinValue)
         {
            idb.AddParameter("@DL_ReturnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnDate", document_Lending.DL_ReturnDate);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnOperator))
         {
            idb.AddParameter("@DL_ReturnOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnOperator", document_Lending.DL_ReturnOperator);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnRemark))
         {
            idb.AddParameter("@DL_ReturnRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnRemark", document_Lending.DL_ReturnRemark);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Stat))
         {
            idb.AddParameter("@DL_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Stat", document_Lending.DL_Stat);
         }
         if (string.IsNullOrEmpty(document_Lending.DL_Remark))
         {
            idb.AddParameter("@DL_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Remark", document_Lending.DL_Remark);
         }
         if (document_Lending.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Lending.Stat);
         }
         if (document_Lending.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Lending.CreateDate);
         }
         if (document_Lending.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Lending.UpdateDate);
         }
         if (document_Lending.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Lending.DeleteDate);
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
      /// 更新档案借阅记录 Document_Lending对象(即:一条记录
      /// </summary>
      public int Update(Document_Lending document_Lending)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Document_Lending       SET ");
            if(document_Lending.DL_Code_IsChanged){sbParameter.Append("DL_Code=@DL_Code, ");}
      if(document_Lending.DL_DocumentCode_IsChanged){sbParameter.Append("DL_DocumentCode=@DL_DocumentCode, ");}
      if(document_Lending.DL_DocumentName_IsChanged){sbParameter.Append("DL_DocumentName=@DL_DocumentName, ");}
      if(document_Lending.DL_FileCode_IsChanged){sbParameter.Append("DL_FileCode=@DL_FileCode, ");}
      if(document_Lending.DL_ISBN_IsChanged){sbParameter.Append("DL_ISBN=@DL_ISBN, ");}
      if(document_Lending.DL_LendingType_IsChanged){sbParameter.Append("DL_LendingType=@DL_LendingType, ");}
      if(document_Lending.DL_ReturnType_IsChanged){sbParameter.Append("DL_ReturnType=@DL_ReturnType, ");}
      if(document_Lending.DL_LendingNum_IsChanged){sbParameter.Append("DL_LendingNum=@DL_LendingNum, ");}
      if(document_Lending.DL_LendorCompany_IsChanged){sbParameter.Append("DL_LendorCompany=@DL_LendorCompany, ");}
      if(document_Lending.DL_LendorDept_IsChanged){sbParameter.Append("DL_LendorDept=@DL_LendorDept, ");}
      if(document_Lending.DL_Person_IsChanged){sbParameter.Append("DL_Person=@DL_Person, ");}
      if(document_Lending.DL_LendingDate_IsChanged){sbParameter.Append("DL_LendingDate=@DL_LendingDate, ");}
      if(document_Lending.DL_Operator_IsChanged){sbParameter.Append("DL_Operator=@DL_Operator, ");}
      if(document_Lending.DL_LendingReason_IsChanged){sbParameter.Append("DL_LendingReason=@DL_LendingReason, ");}
      if(document_Lending.DL_Authorizor_IsChanged){sbParameter.Append("DL_Authorizor=@DL_Authorizor, ");}
      if(document_Lending.DL_ReturnNum_IsChanged){sbParameter.Append("DL_ReturnNum=@DL_ReturnNum, ");}
      if(document_Lending.DL_ReturnDate_IsChanged){sbParameter.Append("DL_ReturnDate=@DL_ReturnDate, ");}
      if(document_Lending.DL_ReturnOperator_IsChanged){sbParameter.Append("DL_ReturnOperator=@DL_ReturnOperator, ");}
      if(document_Lending.DL_ReturnRemark_IsChanged){sbParameter.Append("DL_ReturnRemark=@DL_ReturnRemark, ");}
      if(document_Lending.DL_Stat_IsChanged){sbParameter.Append("DL_Stat=@DL_Stat, ");}
      if(document_Lending.DL_Remark_IsChanged){sbParameter.Append("DL_Remark=@DL_Remark, ");}
      if(document_Lending.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(document_Lending.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(document_Lending.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(document_Lending.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DL_ID=@DL_ID; " );
      string sql=sb.ToString();
         if(document_Lending.DL_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_Code))
         {
            idb.AddParameter("@DL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Code", document_Lending.DL_Code);
         }
          }
         if(document_Lending.DL_DocumentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_DocumentCode))
         {
            idb.AddParameter("@DL_DocumentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_DocumentCode", document_Lending.DL_DocumentCode);
         }
          }
         if(document_Lending.DL_DocumentName_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_DocumentName))
         {
            idb.AddParameter("@DL_DocumentName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_DocumentName", document_Lending.DL_DocumentName);
         }
          }
         if(document_Lending.DL_FileCode_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_FileCode))
         {
            idb.AddParameter("@DL_FileCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_FileCode", document_Lending.DL_FileCode);
         }
          }
         if(document_Lending.DL_ISBN_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_ISBN))
         {
            idb.AddParameter("@DL_ISBN", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ISBN", document_Lending.DL_ISBN);
         }
          }
         if(document_Lending.DL_LendingType_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_LendingType))
         {
            idb.AddParameter("@DL_LendingType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingType", document_Lending.DL_LendingType);
         }
          }
         if(document_Lending.DL_ReturnType_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnType))
         {
            idb.AddParameter("@DL_ReturnType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnType", document_Lending.DL_ReturnType);
         }
          }
         if(document_Lending.DL_LendingNum_IsChanged)
         {
         if (document_Lending.DL_LendingNum == 0)
         {
            idb.AddParameter("@DL_LendingNum", 0);
         }
         else
         {
            idb.AddParameter("@DL_LendingNum", document_Lending.DL_LendingNum);
         }
          }
         if(document_Lending.DL_LendorCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_LendorCompany))
         {
            idb.AddParameter("@DL_LendorCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendorCompany", document_Lending.DL_LendorCompany);
         }
          }
         if(document_Lending.DL_LendorDept_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_LendorDept))
         {
            idb.AddParameter("@DL_LendorDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendorDept", document_Lending.DL_LendorDept);
         }
          }
         if(document_Lending.DL_Person_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_Person))
         {
            idb.AddParameter("@DL_Person", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Person", document_Lending.DL_Person);
         }
          }
         if(document_Lending.DL_LendingDate_IsChanged)
         {
         if (document_Lending.DL_LendingDate == DateTime.MinValue)
         {
            idb.AddParameter("@DL_LendingDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingDate", document_Lending.DL_LendingDate);
         }
          }
         if(document_Lending.DL_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_Operator))
         {
            idb.AddParameter("@DL_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Operator", document_Lending.DL_Operator);
         }
          }
         if(document_Lending.DL_LendingReason_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_LendingReason))
         {
            idb.AddParameter("@DL_LendingReason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_LendingReason", document_Lending.DL_LendingReason);
         }
          }
         if(document_Lending.DL_Authorizor_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_Authorizor))
         {
            idb.AddParameter("@DL_Authorizor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Authorizor", document_Lending.DL_Authorizor);
         }
          }
         if(document_Lending.DL_ReturnNum_IsChanged)
         {
         if (document_Lending.DL_ReturnNum == 0)
         {
            idb.AddParameter("@DL_ReturnNum", 0);
         }
         else
         {
            idb.AddParameter("@DL_ReturnNum", document_Lending.DL_ReturnNum);
         }
          }
         if(document_Lending.DL_ReturnDate_IsChanged)
         {
         if (document_Lending.DL_ReturnDate == DateTime.MinValue)
         {
            idb.AddParameter("@DL_ReturnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnDate", document_Lending.DL_ReturnDate);
         }
          }
         if(document_Lending.DL_ReturnOperator_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnOperator))
         {
            idb.AddParameter("@DL_ReturnOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnOperator", document_Lending.DL_ReturnOperator);
         }
          }
         if(document_Lending.DL_ReturnRemark_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_ReturnRemark))
         {
            idb.AddParameter("@DL_ReturnRemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_ReturnRemark", document_Lending.DL_ReturnRemark);
         }
          }
         if(document_Lending.DL_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_Stat))
         {
            idb.AddParameter("@DL_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Stat", document_Lending.DL_Stat);
         }
          }
         if(document_Lending.DL_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Lending.DL_Remark))
         {
            idb.AddParameter("@DL_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DL_Remark", document_Lending.DL_Remark);
         }
          }
         if(document_Lending.Stat_IsChanged)
         {
         if (document_Lending.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Lending.Stat);
         }
          }
         if(document_Lending.CreateDate_IsChanged)
         {
         if (document_Lending.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Lending.CreateDate);
         }
          }
         if(document_Lending.UpdateDate_IsChanged)
         {
         if (document_Lending.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Lending.UpdateDate);
         }
          }
         if(document_Lending.DeleteDate_IsChanged)
         {
         if (document_Lending.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Lending.DeleteDate);
         }
          }

         idb.AddParameter("@DL_ID", document_Lending.DL_ID);

           
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
      /// 删除档案借阅记录 Document_Lending对象(即:一条记录
      /// </summary>
      public int Delete(decimal dL_ID)
      {
         string sql = "DELETE Document_Lending WHERE 1=1  AND DL_ID=@DL_ID ";
         idb.AddParameter("@DL_ID", dL_ID);

           
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
      /// 获取指定的档案借阅记录 Document_Lending对象(即:一条记录
      /// </summary>
      public Document_Lending GetByKey(decimal dL_ID)
      {
         Document_Lending document_Lending = new Document_Lending();
         string sql = "SELECT  DL_ID,DL_Code,DL_DocumentCode,DL_DocumentName,DL_FileCode,DL_ISBN,DL_LendingType,DL_ReturnType,DL_LendingNum,DL_LendorCompany,DL_LendorDept,DL_Person,DL_LendingDate,DL_Operator,DL_LendingReason,DL_Authorizor,DL_ReturnNum,DL_ReturnDate,DL_ReturnOperator,DL_ReturnRemark,DL_Stat,DL_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Lending WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DL_ID=@DL_ID ";
         idb.AddParameter("@DL_ID", dL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DL_ID"] != DBNull.Value) document_Lending.DL_ID = Convert.ToDecimal(dr["DL_ID"]);
            if (dr["DL_Code"] != DBNull.Value) document_Lending.DL_Code = Convert.ToString(dr["DL_Code"]);
            if (dr["DL_DocumentCode"] != DBNull.Value) document_Lending.DL_DocumentCode = Convert.ToString(dr["DL_DocumentCode"]);
            if (dr["DL_DocumentName"] != DBNull.Value) document_Lending.DL_DocumentName = Convert.ToString(dr["DL_DocumentName"]);
            if (dr["DL_FileCode"] != DBNull.Value) document_Lending.DL_FileCode = Convert.ToString(dr["DL_FileCode"]);
            if (dr["DL_ISBN"] != DBNull.Value) document_Lending.DL_ISBN = Convert.ToString(dr["DL_ISBN"]);
            if (dr["DL_LendingType"] != DBNull.Value) document_Lending.DL_LendingType = Convert.ToString(dr["DL_LendingType"]);
            if (dr["DL_ReturnType"] != DBNull.Value) document_Lending.DL_ReturnType = Convert.ToString(dr["DL_ReturnType"]);
            if (dr["DL_LendingNum"] != DBNull.Value) document_Lending.DL_LendingNum = Convert.ToInt32(dr["DL_LendingNum"]);
            if (dr["DL_LendorCompany"] != DBNull.Value) document_Lending.DL_LendorCompany = Convert.ToString(dr["DL_LendorCompany"]);
            if (dr["DL_LendorDept"] != DBNull.Value) document_Lending.DL_LendorDept = Convert.ToString(dr["DL_LendorDept"]);
            if (dr["DL_Person"] != DBNull.Value) document_Lending.DL_Person = Convert.ToString(dr["DL_Person"]);
            if (dr["DL_LendingDate"] != DBNull.Value) document_Lending.DL_LendingDate = Convert.ToDateTime(dr["DL_LendingDate"]);
            if (dr["DL_Operator"] != DBNull.Value) document_Lending.DL_Operator = Convert.ToString(dr["DL_Operator"]);
            if (dr["DL_LendingReason"] != DBNull.Value) document_Lending.DL_LendingReason = Convert.ToString(dr["DL_LendingReason"]);
            if (dr["DL_Authorizor"] != DBNull.Value) document_Lending.DL_Authorizor = Convert.ToString(dr["DL_Authorizor"]);
            if (dr["DL_ReturnNum"] != DBNull.Value) document_Lending.DL_ReturnNum = Convert.ToInt32(dr["DL_ReturnNum"]);
            if (dr["DL_ReturnDate"] != DBNull.Value) document_Lending.DL_ReturnDate = Convert.ToDateTime(dr["DL_ReturnDate"]);
            if (dr["DL_ReturnOperator"] != DBNull.Value) document_Lending.DL_ReturnOperator = Convert.ToString(dr["DL_ReturnOperator"]);
            if (dr["DL_ReturnRemark"] != DBNull.Value) document_Lending.DL_ReturnRemark = Convert.ToString(dr["DL_ReturnRemark"]);
            if (dr["DL_Stat"] != DBNull.Value) document_Lending.DL_Stat = Convert.ToString(dr["DL_Stat"]);
            if (dr["DL_Remark"] != DBNull.Value) document_Lending.DL_Remark = Convert.ToString(dr["DL_Remark"]);
            if (dr["Stat"] != DBNull.Value) document_Lending.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Lending.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Lending.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Lending.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return document_Lending;
      }
      /// <summary>
      /// 获取指定的档案借阅记录 Document_Lending对象集合
      /// </summary>
      public List<Document_Lending> GetListByWhere(string strCondition)
      {
         List<Document_Lending> ret = new List<Document_Lending>();
         string sql = "SELECT  DL_ID,DL_Code,DL_DocumentCode,DL_DocumentName,DL_FileCode,DL_ISBN,DL_LendingType,DL_ReturnType,DL_LendingNum,DL_LendorCompany,DL_LendorDept,DL_Person,DL_LendingDate,DL_Operator,DL_LendingReason,DL_Authorizor,DL_ReturnNum,DL_ReturnDate,DL_ReturnOperator,DL_ReturnRemark,DL_Stat,DL_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Lending WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Document_Lending document_Lending = new Document_Lending();
            if (dr["DL_ID"] != DBNull.Value) document_Lending.DL_ID = Convert.ToDecimal(dr["DL_ID"]);
            if (dr["DL_Code"] != DBNull.Value) document_Lending.DL_Code = Convert.ToString(dr["DL_Code"]);
            if (dr["DL_DocumentCode"] != DBNull.Value) document_Lending.DL_DocumentCode = Convert.ToString(dr["DL_DocumentCode"]);
            if (dr["DL_DocumentName"] != DBNull.Value) document_Lending.DL_DocumentName = Convert.ToString(dr["DL_DocumentName"]);
            if (dr["DL_FileCode"] != DBNull.Value) document_Lending.DL_FileCode = Convert.ToString(dr["DL_FileCode"]);
            if (dr["DL_ISBN"] != DBNull.Value) document_Lending.DL_ISBN = Convert.ToString(dr["DL_ISBN"]);
            if (dr["DL_LendingType"] != DBNull.Value) document_Lending.DL_LendingType = Convert.ToString(dr["DL_LendingType"]);
            if (dr["DL_ReturnType"] != DBNull.Value) document_Lending.DL_ReturnType = Convert.ToString(dr["DL_ReturnType"]);
            if (dr["DL_LendingNum"] != DBNull.Value) document_Lending.DL_LendingNum = Convert.ToInt32(dr["DL_LendingNum"]);
            if (dr["DL_LendorCompany"] != DBNull.Value) document_Lending.DL_LendorCompany = Convert.ToString(dr["DL_LendorCompany"]);
            if (dr["DL_LendorDept"] != DBNull.Value) document_Lending.DL_LendorDept = Convert.ToString(dr["DL_LendorDept"]);
            if (dr["DL_Person"] != DBNull.Value) document_Lending.DL_Person = Convert.ToString(dr["DL_Person"]);
            if (dr["DL_LendingDate"] != DBNull.Value) document_Lending.DL_LendingDate = Convert.ToDateTime(dr["DL_LendingDate"]);
            if (dr["DL_Operator"] != DBNull.Value) document_Lending.DL_Operator = Convert.ToString(dr["DL_Operator"]);
            if (dr["DL_LendingReason"] != DBNull.Value) document_Lending.DL_LendingReason = Convert.ToString(dr["DL_LendingReason"]);
            if (dr["DL_Authorizor"] != DBNull.Value) document_Lending.DL_Authorizor = Convert.ToString(dr["DL_Authorizor"]);
            if (dr["DL_ReturnNum"] != DBNull.Value) document_Lending.DL_ReturnNum = Convert.ToInt32(dr["DL_ReturnNum"]);
            if (dr["DL_ReturnDate"] != DBNull.Value) document_Lending.DL_ReturnDate = Convert.ToDateTime(dr["DL_ReturnDate"]);
            if (dr["DL_ReturnOperator"] != DBNull.Value) document_Lending.DL_ReturnOperator = Convert.ToString(dr["DL_ReturnOperator"]);
            if (dr["DL_ReturnRemark"] != DBNull.Value) document_Lending.DL_ReturnRemark = Convert.ToString(dr["DL_ReturnRemark"]);
            if (dr["DL_Stat"] != DBNull.Value) document_Lending.DL_Stat = Convert.ToString(dr["DL_Stat"]);
            if (dr["DL_Remark"] != DBNull.Value) document_Lending.DL_Remark = Convert.ToString(dr["DL_Remark"]);
            if (dr["Stat"] != DBNull.Value) document_Lending.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Lending.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Lending.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Lending.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_Lending);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的档案借阅记录 Document_Lending对象(即:一条记录
      /// </summary>
      public List<Document_Lending> GetAll()
      {
         List<Document_Lending> ret = new List<Document_Lending>();
         string sql = "SELECT  DL_ID,DL_Code,DL_DocumentCode,DL_DocumentName,DL_FileCode,DL_ISBN,DL_LendingType,DL_ReturnType,DL_LendingNum,DL_LendorCompany,DL_LendorDept,DL_Person,DL_LendingDate,DL_Operator,DL_LendingReason,DL_Authorizor,DL_ReturnNum,DL_ReturnDate,DL_ReturnOperator,DL_ReturnRemark,DL_Stat,DL_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Lending where 1=1 AND ((Stat is null) or (Stat=0) ) order by DL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Document_Lending document_Lending = new Document_Lending();
            if (dr["DL_ID"] != DBNull.Value) document_Lending.DL_ID = Convert.ToDecimal(dr["DL_ID"]);
            if (dr["DL_Code"] != DBNull.Value) document_Lending.DL_Code = Convert.ToString(dr["DL_Code"]);
            if (dr["DL_DocumentCode"] != DBNull.Value) document_Lending.DL_DocumentCode = Convert.ToString(dr["DL_DocumentCode"]);
            if (dr["DL_DocumentName"] != DBNull.Value) document_Lending.DL_DocumentName = Convert.ToString(dr["DL_DocumentName"]);
            if (dr["DL_FileCode"] != DBNull.Value) document_Lending.DL_FileCode = Convert.ToString(dr["DL_FileCode"]);
            if (dr["DL_ISBN"] != DBNull.Value) document_Lending.DL_ISBN = Convert.ToString(dr["DL_ISBN"]);
            if (dr["DL_LendingType"] != DBNull.Value) document_Lending.DL_LendingType = Convert.ToString(dr["DL_LendingType"]);
            if (dr["DL_ReturnType"] != DBNull.Value) document_Lending.DL_ReturnType = Convert.ToString(dr["DL_ReturnType"]);
            if (dr["DL_LendingNum"] != DBNull.Value) document_Lending.DL_LendingNum = Convert.ToInt32(dr["DL_LendingNum"]);
            if (dr["DL_LendorCompany"] != DBNull.Value) document_Lending.DL_LendorCompany = Convert.ToString(dr["DL_LendorCompany"]);
            if (dr["DL_LendorDept"] != DBNull.Value) document_Lending.DL_LendorDept = Convert.ToString(dr["DL_LendorDept"]);
            if (dr["DL_Person"] != DBNull.Value) document_Lending.DL_Person = Convert.ToString(dr["DL_Person"]);
            if (dr["DL_LendingDate"] != DBNull.Value) document_Lending.DL_LendingDate = Convert.ToDateTime(dr["DL_LendingDate"]);
            if (dr["DL_Operator"] != DBNull.Value) document_Lending.DL_Operator = Convert.ToString(dr["DL_Operator"]);
            if (dr["DL_LendingReason"] != DBNull.Value) document_Lending.DL_LendingReason = Convert.ToString(dr["DL_LendingReason"]);
            if (dr["DL_Authorizor"] != DBNull.Value) document_Lending.DL_Authorizor = Convert.ToString(dr["DL_Authorizor"]);
            if (dr["DL_ReturnNum"] != DBNull.Value) document_Lending.DL_ReturnNum = Convert.ToInt32(dr["DL_ReturnNum"]);
            if (dr["DL_ReturnDate"] != DBNull.Value) document_Lending.DL_ReturnDate = Convert.ToDateTime(dr["DL_ReturnDate"]);
            if (dr["DL_ReturnOperator"] != DBNull.Value) document_Lending.DL_ReturnOperator = Convert.ToString(dr["DL_ReturnOperator"]);
            if (dr["DL_ReturnRemark"] != DBNull.Value) document_Lending.DL_ReturnRemark = Convert.ToString(dr["DL_ReturnRemark"]);
            if (dr["DL_Stat"] != DBNull.Value) document_Lending.DL_Stat = Convert.ToString(dr["DL_Stat"]);
            if (dr["DL_Remark"] != DBNull.Value) document_Lending.DL_Remark = Convert.ToString(dr["DL_Remark"]);
            if (dr["Stat"] != DBNull.Value) document_Lending.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Lending.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Lending.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Lending.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_Lending);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
