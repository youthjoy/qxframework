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
   /// 档案基本信息
   /// </summary>
   [Serializable]
   public partial class ADODocument_Manage
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加档案基本信息 Document_Manage对象(即:一条记录)
      /// </summary>
      public int Add(Document_Manage document_Manage)
      {
         string sql = "INSERT INTO Document_Manage (DM_Code,DM_Name,DM_iType,DM_Category,DM_FileNumber,DM_Num,DM_InNum,DM_AttachCompany,DM_AttachDept,DM_Type,DM_Issuer,DM_Operator,DM_Date,DM_ConversionDate,DM_PageNum,DM_SecretLevel,DM_Remark,DM_Content,DM_HoldingDept,DM_HoldingPerson,DM_Position,DM_Stat,DM_IsIssued,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@DM_Code,@DM_Name,@DM_iType,@DM_Category,@DM_FileNumber,@DM_Num,@DM_InNum,@DM_AttachCompany,@DM_AttachDept,@DM_Type,@DM_Issuer,@DM_Operator,@DM_Date,@DM_ConversionDate,@DM_PageNum,@DM_SecretLevel,@DM_Remark,@DM_Content,@DM_HoldingDept,@DM_HoldingPerson,@DM_Position,@DM_Stat,@DM_IsIssued,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(document_Manage.DM_Code))
         {
            idb.AddParameter("@DM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Code", document_Manage.DM_Code);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Name))
         {
            idb.AddParameter("@DM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Name", document_Manage.DM_Name);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_iType))
         {
            idb.AddParameter("@DM_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_iType", document_Manage.DM_iType);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Category))
         {
            idb.AddParameter("@DM_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Category", document_Manage.DM_Category);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_FileNumber))
         {
            idb.AddParameter("@DM_FileNumber", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_FileNumber", document_Manage.DM_FileNumber);
         }
         if (document_Manage.DM_Num == 0)
         {
            idb.AddParameter("@DM_Num", 0);
         }
         else
         {
            idb.AddParameter("@DM_Num", document_Manage.DM_Num);
         }
         if (document_Manage.DM_InNum == 0)
         {
            idb.AddParameter("@DM_InNum", 0);
         }
         else
         {
            idb.AddParameter("@DM_InNum", document_Manage.DM_InNum);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_AttachCompany))
         {
            idb.AddParameter("@DM_AttachCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_AttachCompany", document_Manage.DM_AttachCompany);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_AttachDept))
         {
            idb.AddParameter("@DM_AttachDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_AttachDept", document_Manage.DM_AttachDept);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Type))
         {
            idb.AddParameter("@DM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Type", document_Manage.DM_Type);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Issuer))
         {
            idb.AddParameter("@DM_Issuer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Issuer", document_Manage.DM_Issuer);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Operator))
         {
            idb.AddParameter("@DM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Operator", document_Manage.DM_Operator);
         }
         if (document_Manage.DM_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DM_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Date", document_Manage.DM_Date);
         }
         if (document_Manage.DM_ConversionDate == DateTime.MinValue)
         {
            idb.AddParameter("@DM_ConversionDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_ConversionDate", document_Manage.DM_ConversionDate);
         }
         if (document_Manage.DM_PageNum == 0)
         {
            idb.AddParameter("@DM_PageNum", 0);
         }
         else
         {
            idb.AddParameter("@DM_PageNum", document_Manage.DM_PageNum);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_SecretLevel))
         {
            idb.AddParameter("@DM_SecretLevel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_SecretLevel", document_Manage.DM_SecretLevel);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Remark))
         {
            idb.AddParameter("@DM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Remark", document_Manage.DM_Remark);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Content))
         {
            idb.AddParameter("@DM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Content", document_Manage.DM_Content);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_HoldingDept))
         {
            idb.AddParameter("@DM_HoldingDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_HoldingDept", document_Manage.DM_HoldingDept);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_HoldingPerson))
         {
            idb.AddParameter("@DM_HoldingPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_HoldingPerson", document_Manage.DM_HoldingPerson);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Position))
         {
            idb.AddParameter("@DM_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Position", document_Manage.DM_Position);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Stat))
         {
            idb.AddParameter("@DM_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Stat", document_Manage.DM_Stat);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_IsIssued))
         {
            idb.AddParameter("@DM_IsIssued", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_IsIssued", document_Manage.DM_IsIssued);
         }
         if (document_Manage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Manage.Stat);
         }
         if (document_Manage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Manage.CreateDate);
         }
         if (document_Manage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Manage.UpdateDate);
         }
         if (document_Manage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Manage.DeleteDate);
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
      /// 添加档案基本信息 Document_Manage对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Document_Manage document_Manage)
      {
         string sql = "INSERT INTO Document_Manage (DM_Code,DM_Name,DM_iType,DM_Category,DM_FileNumber,DM_Num,DM_InNum,DM_AttachCompany,DM_AttachDept,DM_Type,DM_Issuer,DM_Operator,DM_Date,DM_ConversionDate,DM_PageNum,DM_SecretLevel,DM_Remark,DM_Content,DM_HoldingDept,DM_HoldingPerson,DM_Position,DM_Stat,DM_IsIssued,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@DM_Code,@DM_Name,@DM_iType,@DM_Category,@DM_FileNumber,@DM_Num,@DM_InNum,@DM_AttachCompany,@DM_AttachDept,@DM_Type,@DM_Issuer,@DM_Operator,@DM_Date,@DM_ConversionDate,@DM_PageNum,@DM_SecretLevel,@DM_Remark,@DM_Content,@DM_HoldingDept,@DM_HoldingPerson,@DM_Position,@DM_Stat,@DM_IsIssued,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(document_Manage.DM_Code))
         {
            idb.AddParameter("@DM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Code", document_Manage.DM_Code);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Name))
         {
            idb.AddParameter("@DM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Name", document_Manage.DM_Name);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_iType))
         {
            idb.AddParameter("@DM_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_iType", document_Manage.DM_iType);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Category))
         {
            idb.AddParameter("@DM_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Category", document_Manage.DM_Category);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_FileNumber))
         {
            idb.AddParameter("@DM_FileNumber", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_FileNumber", document_Manage.DM_FileNumber);
         }
         if (document_Manage.DM_Num == 0)
         {
            idb.AddParameter("@DM_Num", 0);
         }
         else
         {
            idb.AddParameter("@DM_Num", document_Manage.DM_Num);
         }
         if (document_Manage.DM_InNum == 0)
         {
            idb.AddParameter("@DM_InNum", 0);
         }
         else
         {
            idb.AddParameter("@DM_InNum", document_Manage.DM_InNum);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_AttachCompany))
         {
            idb.AddParameter("@DM_AttachCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_AttachCompany", document_Manage.DM_AttachCompany);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_AttachDept))
         {
            idb.AddParameter("@DM_AttachDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_AttachDept", document_Manage.DM_AttachDept);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Type))
         {
            idb.AddParameter("@DM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Type", document_Manage.DM_Type);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Issuer))
         {
            idb.AddParameter("@DM_Issuer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Issuer", document_Manage.DM_Issuer);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Operator))
         {
            idb.AddParameter("@DM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Operator", document_Manage.DM_Operator);
         }
         if (document_Manage.DM_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DM_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Date", document_Manage.DM_Date);
         }
         if (document_Manage.DM_ConversionDate == DateTime.MinValue)
         {
            idb.AddParameter("@DM_ConversionDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_ConversionDate", document_Manage.DM_ConversionDate);
         }
         if (document_Manage.DM_PageNum == 0)
         {
            idb.AddParameter("@DM_PageNum", 0);
         }
         else
         {
            idb.AddParameter("@DM_PageNum", document_Manage.DM_PageNum);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_SecretLevel))
         {
            idb.AddParameter("@DM_SecretLevel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_SecretLevel", document_Manage.DM_SecretLevel);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Remark))
         {
            idb.AddParameter("@DM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Remark", document_Manage.DM_Remark);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Content))
         {
            idb.AddParameter("@DM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Content", document_Manage.DM_Content);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_HoldingDept))
         {
            idb.AddParameter("@DM_HoldingDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_HoldingDept", document_Manage.DM_HoldingDept);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_HoldingPerson))
         {
            idb.AddParameter("@DM_HoldingPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_HoldingPerson", document_Manage.DM_HoldingPerson);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Position))
         {
            idb.AddParameter("@DM_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Position", document_Manage.DM_Position);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_Stat))
         {
            idb.AddParameter("@DM_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Stat", document_Manage.DM_Stat);
         }
         if (string.IsNullOrEmpty(document_Manage.DM_IsIssued))
         {
            idb.AddParameter("@DM_IsIssued", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_IsIssued", document_Manage.DM_IsIssued);
         }
         if (document_Manage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Manage.Stat);
         }
         if (document_Manage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Manage.CreateDate);
         }
         if (document_Manage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Manage.UpdateDate);
         }
         if (document_Manage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Manage.DeleteDate);
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
      /// 更新档案基本信息 Document_Manage对象(即:一条记录
      /// </summary>
      public int Update(Document_Manage document_Manage)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Document_Manage       SET ");
            if(document_Manage.DM_Code_IsChanged){sbParameter.Append("DM_Code=@DM_Code, ");}
      if(document_Manage.DM_Name_IsChanged){sbParameter.Append("DM_Name=@DM_Name, ");}
      if(document_Manage.DM_iType_IsChanged){sbParameter.Append("DM_iType=@DM_iType, ");}
      if(document_Manage.DM_Category_IsChanged){sbParameter.Append("DM_Category=@DM_Category, ");}
      if(document_Manage.DM_FileNumber_IsChanged){sbParameter.Append("DM_FileNumber=@DM_FileNumber, ");}
      if(document_Manage.DM_Num_IsChanged){sbParameter.Append("DM_Num=@DM_Num, ");}
      if(document_Manage.DM_InNum_IsChanged){sbParameter.Append("DM_InNum=@DM_InNum, ");}
      if(document_Manage.DM_AttachCompany_IsChanged){sbParameter.Append("DM_AttachCompany=@DM_AttachCompany, ");}
      if(document_Manage.DM_AttachDept_IsChanged){sbParameter.Append("DM_AttachDept=@DM_AttachDept, ");}
      if(document_Manage.DM_Type_IsChanged){sbParameter.Append("DM_Type=@DM_Type, ");}
      if(document_Manage.DM_Issuer_IsChanged){sbParameter.Append("DM_Issuer=@DM_Issuer, ");}
      if(document_Manage.DM_Operator_IsChanged){sbParameter.Append("DM_Operator=@DM_Operator, ");}
      if(document_Manage.DM_Date_IsChanged){sbParameter.Append("DM_Date=@DM_Date, ");}
      if(document_Manage.DM_ConversionDate_IsChanged){sbParameter.Append("DM_ConversionDate=@DM_ConversionDate, ");}
      if(document_Manage.DM_PageNum_IsChanged){sbParameter.Append("DM_PageNum=@DM_PageNum, ");}
      if(document_Manage.DM_SecretLevel_IsChanged){sbParameter.Append("DM_SecretLevel=@DM_SecretLevel, ");}
      if(document_Manage.DM_Remark_IsChanged){sbParameter.Append("DM_Remark=@DM_Remark, ");}
      if(document_Manage.DM_Content_IsChanged){sbParameter.Append("DM_Content=@DM_Content, ");}
      if(document_Manage.DM_HoldingDept_IsChanged){sbParameter.Append("DM_HoldingDept=@DM_HoldingDept, ");}
      if(document_Manage.DM_HoldingPerson_IsChanged){sbParameter.Append("DM_HoldingPerson=@DM_HoldingPerson, ");}
      if(document_Manage.DM_Position_IsChanged){sbParameter.Append("DM_Position=@DM_Position, ");}
      if(document_Manage.DM_Stat_IsChanged){sbParameter.Append("DM_Stat=@DM_Stat, ");}
      if(document_Manage.DM_IsIssued_IsChanged){sbParameter.Append("DM_IsIssued=@DM_IsIssued, ");}
      if(document_Manage.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(document_Manage.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(document_Manage.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(document_Manage.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DM_ID=@DM_ID; " );
      string sql=sb.ToString();
         if(document_Manage.DM_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Code))
         {
            idb.AddParameter("@DM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Code", document_Manage.DM_Code);
         }
          }
         if(document_Manage.DM_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Name))
         {
            idb.AddParameter("@DM_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Name", document_Manage.DM_Name);
         }
          }
         if(document_Manage.DM_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_iType))
         {
            idb.AddParameter("@DM_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_iType", document_Manage.DM_iType);
         }
          }
         if(document_Manage.DM_Category_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Category))
         {
            idb.AddParameter("@DM_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Category", document_Manage.DM_Category);
         }
          }
         if(document_Manage.DM_FileNumber_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_FileNumber))
         {
            idb.AddParameter("@DM_FileNumber", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_FileNumber", document_Manage.DM_FileNumber);
         }
          }
         if(document_Manage.DM_Num_IsChanged)
         {
         if (document_Manage.DM_Num == 0)
         {
            idb.AddParameter("@DM_Num", 0);
         }
         else
         {
            idb.AddParameter("@DM_Num", document_Manage.DM_Num);
         }
          }
         if(document_Manage.DM_InNum_IsChanged)
         {
         if (document_Manage.DM_InNum == 0)
         {
            idb.AddParameter("@DM_InNum", 0);
         }
         else
         {
            idb.AddParameter("@DM_InNum", document_Manage.DM_InNum);
         }
          }
         if(document_Manage.DM_AttachCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_AttachCompany))
         {
            idb.AddParameter("@DM_AttachCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_AttachCompany", document_Manage.DM_AttachCompany);
         }
          }
         if(document_Manage.DM_AttachDept_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_AttachDept))
         {
            idb.AddParameter("@DM_AttachDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_AttachDept", document_Manage.DM_AttachDept);
         }
          }
         if(document_Manage.DM_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Type))
         {
            idb.AddParameter("@DM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Type", document_Manage.DM_Type);
         }
          }
         if(document_Manage.DM_Issuer_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Issuer))
         {
            idb.AddParameter("@DM_Issuer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Issuer", document_Manage.DM_Issuer);
         }
          }
         if(document_Manage.DM_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Operator))
         {
            idb.AddParameter("@DM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Operator", document_Manage.DM_Operator);
         }
          }
         if(document_Manage.DM_Date_IsChanged)
         {
         if (document_Manage.DM_Date == DateTime.MinValue)
         {
            idb.AddParameter("@DM_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Date", document_Manage.DM_Date);
         }
          }
         if(document_Manage.DM_ConversionDate_IsChanged)
         {
         if (document_Manage.DM_ConversionDate == DateTime.MinValue)
         {
            idb.AddParameter("@DM_ConversionDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_ConversionDate", document_Manage.DM_ConversionDate);
         }
          }
         if(document_Manage.DM_PageNum_IsChanged)
         {
         if (document_Manage.DM_PageNum == 0)
         {
            idb.AddParameter("@DM_PageNum", 0);
         }
         else
         {
            idb.AddParameter("@DM_PageNum", document_Manage.DM_PageNum);
         }
          }
         if(document_Manage.DM_SecretLevel_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_SecretLevel))
         {
            idb.AddParameter("@DM_SecretLevel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_SecretLevel", document_Manage.DM_SecretLevel);
         }
          }
         if(document_Manage.DM_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Remark))
         {
            idb.AddParameter("@DM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Remark", document_Manage.DM_Remark);
         }
          }
         if(document_Manage.DM_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Content))
         {
            idb.AddParameter("@DM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Content", document_Manage.DM_Content);
         }
          }
         if(document_Manage.DM_HoldingDept_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_HoldingDept))
         {
            idb.AddParameter("@DM_HoldingDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_HoldingDept", document_Manage.DM_HoldingDept);
         }
          }
         if(document_Manage.DM_HoldingPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_HoldingPerson))
         {
            idb.AddParameter("@DM_HoldingPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_HoldingPerson", document_Manage.DM_HoldingPerson);
         }
          }
         if(document_Manage.DM_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Position))
         {
            idb.AddParameter("@DM_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Position", document_Manage.DM_Position);
         }
          }
         if(document_Manage.DM_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_Stat))
         {
            idb.AddParameter("@DM_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_Stat", document_Manage.DM_Stat);
         }
          }
         if(document_Manage.DM_IsIssued_IsChanged)
         {
         if (string.IsNullOrEmpty(document_Manage.DM_IsIssued))
         {
            idb.AddParameter("@DM_IsIssued", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DM_IsIssued", document_Manage.DM_IsIssued);
         }
          }
         if(document_Manage.Stat_IsChanged)
         {
         if (document_Manage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", document_Manage.Stat);
         }
          }
         if(document_Manage.CreateDate_IsChanged)
         {
         if (document_Manage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", document_Manage.CreateDate);
         }
          }
         if(document_Manage.UpdateDate_IsChanged)
         {
         if (document_Manage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", document_Manage.UpdateDate);
         }
          }
         if(document_Manage.DeleteDate_IsChanged)
         {
         if (document_Manage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", document_Manage.DeleteDate);
         }
          }

         idb.AddParameter("@DM_ID", document_Manage.DM_ID);

           
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
      /// 删除档案基本信息 Document_Manage对象(即:一条记录
      /// </summary>
      public int Delete(decimal dM_ID)
      {
         string sql = "DELETE Document_Manage WHERE 1=1  AND DM_ID=@DM_ID ";
         idb.AddParameter("@DM_ID", dM_ID);

           
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
      /// 获取指定的档案基本信息 Document_Manage对象(即:一条记录
      /// </summary>
      public Document_Manage GetByKey(decimal dM_ID)
      {
         Document_Manage document_Manage = new Document_Manage();
         string sql = "SELECT  DM_ID,DM_Code,DM_Name,DM_iType,DM_Category,DM_FileNumber,DM_Num,DM_InNum,DM_AttachCompany,DM_AttachDept,DM_Type,DM_Issuer,DM_Operator,DM_Date,DM_ConversionDate,DM_PageNum,DM_SecretLevel,DM_Remark,DM_Content,DM_HoldingDept,DM_HoldingPerson,DM_Position,DM_Stat,DM_IsIssued,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Manage WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND DM_ID=@DM_ID ";
         idb.AddParameter("@DM_ID", dM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["DM_ID"] != DBNull.Value) document_Manage.DM_ID = Convert.ToDecimal(dr["DM_ID"]);
            if (dr["DM_Code"] != DBNull.Value) document_Manage.DM_Code = Convert.ToString(dr["DM_Code"]);
            if (dr["DM_Name"] != DBNull.Value) document_Manage.DM_Name = Convert.ToString(dr["DM_Name"]);
            if (dr["DM_iType"] != DBNull.Value) document_Manage.DM_iType = Convert.ToString(dr["DM_iType"]);
            if (dr["DM_Category"] != DBNull.Value) document_Manage.DM_Category = Convert.ToString(dr["DM_Category"]);
            if (dr["DM_FileNumber"] != DBNull.Value) document_Manage.DM_FileNumber = Convert.ToString(dr["DM_FileNumber"]);
            if (dr["DM_Num"] != DBNull.Value) document_Manage.DM_Num = Convert.ToInt32(dr["DM_Num"]);
            if (dr["DM_InNum"] != DBNull.Value) document_Manage.DM_InNum = Convert.ToInt32(dr["DM_InNum"]);
            if (dr["DM_AttachCompany"] != DBNull.Value) document_Manage.DM_AttachCompany = Convert.ToString(dr["DM_AttachCompany"]);
            if (dr["DM_AttachDept"] != DBNull.Value) document_Manage.DM_AttachDept = Convert.ToString(dr["DM_AttachDept"]);
            if (dr["DM_Type"] != DBNull.Value) document_Manage.DM_Type = Convert.ToString(dr["DM_Type"]);
            if (dr["DM_Issuer"] != DBNull.Value) document_Manage.DM_Issuer = Convert.ToString(dr["DM_Issuer"]);
            if (dr["DM_Operator"] != DBNull.Value) document_Manage.DM_Operator = Convert.ToString(dr["DM_Operator"]);
            if (dr["DM_Date"] != DBNull.Value) document_Manage.DM_Date = Convert.ToDateTime(dr["DM_Date"]);
            if (dr["DM_ConversionDate"] != DBNull.Value) document_Manage.DM_ConversionDate = Convert.ToDateTime(dr["DM_ConversionDate"]);
            if (dr["DM_PageNum"] != DBNull.Value) document_Manage.DM_PageNum = Convert.ToInt32(dr["DM_PageNum"]);
            if (dr["DM_SecretLevel"] != DBNull.Value) document_Manage.DM_SecretLevel = Convert.ToString(dr["DM_SecretLevel"]);
            if (dr["DM_Remark"] != DBNull.Value) document_Manage.DM_Remark = Convert.ToString(dr["DM_Remark"]);
            if (dr["DM_Content"] != DBNull.Value) document_Manage.DM_Content = Convert.ToString(dr["DM_Content"]);
            if (dr["DM_HoldingDept"] != DBNull.Value) document_Manage.DM_HoldingDept = Convert.ToString(dr["DM_HoldingDept"]);
            if (dr["DM_HoldingPerson"] != DBNull.Value) document_Manage.DM_HoldingPerson = Convert.ToString(dr["DM_HoldingPerson"]);
            if (dr["DM_Position"] != DBNull.Value) document_Manage.DM_Position = Convert.ToString(dr["DM_Position"]);
            if (dr["DM_Stat"] != DBNull.Value) document_Manage.DM_Stat = Convert.ToString(dr["DM_Stat"]);
            if (dr["DM_IsIssued"] != DBNull.Value) document_Manage.DM_IsIssued = Convert.ToString(dr["DM_IsIssued"]);
            if (dr["Stat"] != DBNull.Value) document_Manage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Manage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Manage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Manage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return document_Manage;
      }
      /// <summary>
      /// 获取指定的档案基本信息 Document_Manage对象集合
      /// </summary>
      public List<Document_Manage> GetListByWhere(string strCondition)
      {
         List<Document_Manage> ret = new List<Document_Manage>();
         string sql = "SELECT  DM_ID,DM_Code,DM_Name,DM_iType,DM_Category,DM_FileNumber,DM_Num,DM_InNum,DM_AttachCompany,DM_AttachDept,DM_Type,DM_Issuer,DM_Operator,DM_Date,DM_ConversionDate,DM_PageNum,DM_SecretLevel,DM_Remark,DM_Content,DM_HoldingDept,DM_HoldingPerson,DM_Position,DM_Stat,DM_IsIssued,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Manage WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Document_Manage document_Manage = new Document_Manage();
            if (dr["DM_ID"] != DBNull.Value) document_Manage.DM_ID = Convert.ToDecimal(dr["DM_ID"]);
            if (dr["DM_Code"] != DBNull.Value) document_Manage.DM_Code = Convert.ToString(dr["DM_Code"]);
            if (dr["DM_Name"] != DBNull.Value) document_Manage.DM_Name = Convert.ToString(dr["DM_Name"]);
            if (dr["DM_iType"] != DBNull.Value) document_Manage.DM_iType = Convert.ToString(dr["DM_iType"]);
            if (dr["DM_Category"] != DBNull.Value) document_Manage.DM_Category = Convert.ToString(dr["DM_Category"]);
            if (dr["DM_FileNumber"] != DBNull.Value) document_Manage.DM_FileNumber = Convert.ToString(dr["DM_FileNumber"]);
            if (dr["DM_Num"] != DBNull.Value) document_Manage.DM_Num = Convert.ToInt32(dr["DM_Num"]);
            if (dr["DM_InNum"] != DBNull.Value) document_Manage.DM_InNum = Convert.ToInt32(dr["DM_InNum"]);
            if (dr["DM_AttachCompany"] != DBNull.Value) document_Manage.DM_AttachCompany = Convert.ToString(dr["DM_AttachCompany"]);
            if (dr["DM_AttachDept"] != DBNull.Value) document_Manage.DM_AttachDept = Convert.ToString(dr["DM_AttachDept"]);
            if (dr["DM_Type"] != DBNull.Value) document_Manage.DM_Type = Convert.ToString(dr["DM_Type"]);
            if (dr["DM_Issuer"] != DBNull.Value) document_Manage.DM_Issuer = Convert.ToString(dr["DM_Issuer"]);
            if (dr["DM_Operator"] != DBNull.Value) document_Manage.DM_Operator = Convert.ToString(dr["DM_Operator"]);
            if (dr["DM_Date"] != DBNull.Value) document_Manage.DM_Date = Convert.ToDateTime(dr["DM_Date"]);
            if (dr["DM_ConversionDate"] != DBNull.Value) document_Manage.DM_ConversionDate = Convert.ToDateTime(dr["DM_ConversionDate"]);
            if (dr["DM_PageNum"] != DBNull.Value) document_Manage.DM_PageNum = Convert.ToInt32(dr["DM_PageNum"]);
            if (dr["DM_SecretLevel"] != DBNull.Value) document_Manage.DM_SecretLevel = Convert.ToString(dr["DM_SecretLevel"]);
            if (dr["DM_Remark"] != DBNull.Value) document_Manage.DM_Remark = Convert.ToString(dr["DM_Remark"]);
            if (dr["DM_Content"] != DBNull.Value) document_Manage.DM_Content = Convert.ToString(dr["DM_Content"]);
            if (dr["DM_HoldingDept"] != DBNull.Value) document_Manage.DM_HoldingDept = Convert.ToString(dr["DM_HoldingDept"]);
            if (dr["DM_HoldingPerson"] != DBNull.Value) document_Manage.DM_HoldingPerson = Convert.ToString(dr["DM_HoldingPerson"]);
            if (dr["DM_Position"] != DBNull.Value) document_Manage.DM_Position = Convert.ToString(dr["DM_Position"]);
            if (dr["DM_Stat"] != DBNull.Value) document_Manage.DM_Stat = Convert.ToString(dr["DM_Stat"]);
            if (dr["DM_IsIssued"] != DBNull.Value) document_Manage.DM_IsIssued = Convert.ToString(dr["DM_IsIssued"]);
            if (dr["Stat"] != DBNull.Value) document_Manage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Manage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Manage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Manage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_Manage);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的档案基本信息 Document_Manage对象(即:一条记录
      /// </summary>
      public List<Document_Manage> GetAll()
      {
         List<Document_Manage> ret = new List<Document_Manage>();
         string sql = "SELECT  DM_ID,DM_Code,DM_Name,DM_iType,DM_Category,DM_FileNumber,DM_Num,DM_InNum,DM_AttachCompany,DM_AttachDept,DM_Type,DM_Issuer,DM_Operator,DM_Date,DM_ConversionDate,DM_PageNum,DM_SecretLevel,DM_Remark,DM_Content,DM_HoldingDept,DM_HoldingPerson,DM_Position,DM_Stat,DM_IsIssued,Stat,CreateDate,UpdateDate,DeleteDate FROM Document_Manage where 1=1 AND ((Stat is null) or (Stat=0) ) order by DM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Document_Manage document_Manage = new Document_Manage();
            if (dr["DM_ID"] != DBNull.Value) document_Manage.DM_ID = Convert.ToDecimal(dr["DM_ID"]);
            if (dr["DM_Code"] != DBNull.Value) document_Manage.DM_Code = Convert.ToString(dr["DM_Code"]);
            if (dr["DM_Name"] != DBNull.Value) document_Manage.DM_Name = Convert.ToString(dr["DM_Name"]);
            if (dr["DM_iType"] != DBNull.Value) document_Manage.DM_iType = Convert.ToString(dr["DM_iType"]);
            if (dr["DM_Category"] != DBNull.Value) document_Manage.DM_Category = Convert.ToString(dr["DM_Category"]);
            if (dr["DM_FileNumber"] != DBNull.Value) document_Manage.DM_FileNumber = Convert.ToString(dr["DM_FileNumber"]);
            if (dr["DM_Num"] != DBNull.Value) document_Manage.DM_Num = Convert.ToInt32(dr["DM_Num"]);
            if (dr["DM_InNum"] != DBNull.Value) document_Manage.DM_InNum = Convert.ToInt32(dr["DM_InNum"]);
            if (dr["DM_AttachCompany"] != DBNull.Value) document_Manage.DM_AttachCompany = Convert.ToString(dr["DM_AttachCompany"]);
            if (dr["DM_AttachDept"] != DBNull.Value) document_Manage.DM_AttachDept = Convert.ToString(dr["DM_AttachDept"]);
            if (dr["DM_Type"] != DBNull.Value) document_Manage.DM_Type = Convert.ToString(dr["DM_Type"]);
            if (dr["DM_Issuer"] != DBNull.Value) document_Manage.DM_Issuer = Convert.ToString(dr["DM_Issuer"]);
            if (dr["DM_Operator"] != DBNull.Value) document_Manage.DM_Operator = Convert.ToString(dr["DM_Operator"]);
            if (dr["DM_Date"] != DBNull.Value) document_Manage.DM_Date = Convert.ToDateTime(dr["DM_Date"]);
            if (dr["DM_ConversionDate"] != DBNull.Value) document_Manage.DM_ConversionDate = Convert.ToDateTime(dr["DM_ConversionDate"]);
            if (dr["DM_PageNum"] != DBNull.Value) document_Manage.DM_PageNum = Convert.ToInt32(dr["DM_PageNum"]);
            if (dr["DM_SecretLevel"] != DBNull.Value) document_Manage.DM_SecretLevel = Convert.ToString(dr["DM_SecretLevel"]);
            if (dr["DM_Remark"] != DBNull.Value) document_Manage.DM_Remark = Convert.ToString(dr["DM_Remark"]);
            if (dr["DM_Content"] != DBNull.Value) document_Manage.DM_Content = Convert.ToString(dr["DM_Content"]);
            if (dr["DM_HoldingDept"] != DBNull.Value) document_Manage.DM_HoldingDept = Convert.ToString(dr["DM_HoldingDept"]);
            if (dr["DM_HoldingPerson"] != DBNull.Value) document_Manage.DM_HoldingPerson = Convert.ToString(dr["DM_HoldingPerson"]);
            if (dr["DM_Position"] != DBNull.Value) document_Manage.DM_Position = Convert.ToString(dr["DM_Position"]);
            if (dr["DM_Stat"] != DBNull.Value) document_Manage.DM_Stat = Convert.ToString(dr["DM_Stat"]);
            if (dr["DM_IsIssued"] != DBNull.Value) document_Manage.DM_IsIssued = Convert.ToString(dr["DM_IsIssued"]);
            if (dr["Stat"] != DBNull.Value) document_Manage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) document_Manage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) document_Manage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) document_Manage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(document_Manage);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
