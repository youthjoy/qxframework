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
   public partial class ADODoc_Info
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Doc_Info对象(即:一条记录)
      /// </summary>
      public int Add(Doc_Info doc_Info)
      {
         string sql = "INSERT INTO Doc_Info (Doc_Code,Doc_Type,Doc_TypeName,Doc_No,Doc_IsBusyName,Doc_IsBusy,Doc_Level,Doc_LevelName,Doc_Title,Doc_Object,Doc_Cate,Doc_CateName,Doc_Creator,Doc_CreatorName,Doc_DpCode,Doc_DpName,Doc_MainTitle,Doc_CC,Doc_Content,Doc_Date,Doc_Num,Doc_Opinion,Doc_Stat,Doc_RefDoc,Stat,CreateTime,UpdateTime,DeleteTime,AuditStat,AuditCurAudit) VALUES (@Doc_Code,@Doc_Type,@Doc_TypeName,@Doc_No,@Doc_IsBusyName,@Doc_IsBusy,@Doc_Level,@Doc_LevelName,@Doc_Title,@Doc_Object,@Doc_Cate,@Doc_CateName,@Doc_Creator,@Doc_CreatorName,@Doc_DpCode,@Doc_DpName,@Doc_MainTitle,@Doc_CC,@Doc_Content,@Doc_Date,@Doc_Num,@Doc_Opinion,@Doc_Stat,@Doc_RefDoc,@Stat,@CreateTime,@UpdateTime,@DeleteTime,@AuditStat,@AuditCurAudit)";
         if (string.IsNullOrEmpty(doc_Info.Doc_Code))
         {
            idb.AddParameter("@Doc_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Code", doc_Info.Doc_Code);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Type))
         {
            idb.AddParameter("@Doc_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Type", doc_Info.Doc_Type);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_TypeName))
         {
            idb.AddParameter("@Doc_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_TypeName", doc_Info.Doc_TypeName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_No))
         {
            idb.AddParameter("@Doc_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_No", doc_Info.Doc_No);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_IsBusyName))
         {
            idb.AddParameter("@Doc_IsBusyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_IsBusyName", doc_Info.Doc_IsBusyName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_IsBusy))
         {
            idb.AddParameter("@Doc_IsBusy", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_IsBusy", doc_Info.Doc_IsBusy);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Level))
         {
            idb.AddParameter("@Doc_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Level", doc_Info.Doc_Level);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_LevelName))
         {
            idb.AddParameter("@Doc_LevelName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_LevelName", doc_Info.Doc_LevelName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Title))
         {
            idb.AddParameter("@Doc_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Title", doc_Info.Doc_Title);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Object))
         {
            idb.AddParameter("@Doc_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Object", doc_Info.Doc_Object);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Cate))
         {
            idb.AddParameter("@Doc_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Cate", doc_Info.Doc_Cate);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_CateName))
         {
            idb.AddParameter("@Doc_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CateName", doc_Info.Doc_CateName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Creator))
         {
            idb.AddParameter("@Doc_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Creator", doc_Info.Doc_Creator);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_CreatorName))
         {
            idb.AddParameter("@Doc_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CreatorName", doc_Info.Doc_CreatorName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_DpCode))
         {
            idb.AddParameter("@Doc_DpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_DpCode", doc_Info.Doc_DpCode);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_DpName))
         {
            idb.AddParameter("@Doc_DpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_DpName", doc_Info.Doc_DpName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_MainTitle))
         {
            idb.AddParameter("@Doc_MainTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_MainTitle", doc_Info.Doc_MainTitle);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_CC))
         {
            idb.AddParameter("@Doc_CC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CC", doc_Info.Doc_CC);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Content))
         {
            idb.AddParameter("@Doc_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Content", doc_Info.Doc_Content);
         }
         if (doc_Info.Doc_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Doc_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Date", doc_Info.Doc_Date);
         }
         if (doc_Info.Doc_Num == 0)
         {
            idb.AddParameter("@Doc_Num", 0);
         }
         else
         {
            idb.AddParameter("@Doc_Num", doc_Info.Doc_Num);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Opinion))
         {
            idb.AddParameter("@Doc_Opinion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Opinion", doc_Info.Doc_Opinion);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Stat))
         {
            idb.AddParameter("@Doc_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Stat", doc_Info.Doc_Stat);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_RefDoc))
         {
            idb.AddParameter("@Doc_RefDoc", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_RefDoc", doc_Info.Doc_RefDoc);
         }
         if (doc_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Info.Stat);
         }
         if (doc_Info.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Info.CreateTime);
         }
         if (doc_Info.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Info.UpdateTime);
         }
         if (doc_Info.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Info.DeleteTime);
         }
         if (string.IsNullOrEmpty(doc_Info.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", doc_Info.AuditStat);
         }
         if (string.IsNullOrEmpty(doc_Info.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", doc_Info.AuditCurAudit);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Doc_Info对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Doc_Info doc_Info)
      {
         string sql = "INSERT INTO Doc_Info (Doc_Code,Doc_Type,Doc_TypeName,Doc_No,Doc_IsBusyName,Doc_IsBusy,Doc_Level,Doc_LevelName,Doc_Title,Doc_Object,Doc_Cate,Doc_CateName,Doc_Creator,Doc_CreatorName,Doc_DpCode,Doc_DpName,Doc_MainTitle,Doc_CC,Doc_Content,Doc_Date,Doc_Num,Doc_Opinion,Doc_Stat,Doc_RefDoc,Stat,CreateTime,UpdateTime,DeleteTime,AuditStat,AuditCurAudit) VALUES (@Doc_Code,@Doc_Type,@Doc_TypeName,@Doc_No,@Doc_IsBusyName,@Doc_IsBusy,@Doc_Level,@Doc_LevelName,@Doc_Title,@Doc_Object,@Doc_Cate,@Doc_CateName,@Doc_Creator,@Doc_CreatorName,@Doc_DpCode,@Doc_DpName,@Doc_MainTitle,@Doc_CC,@Doc_Content,@Doc_Date,@Doc_Num,@Doc_Opinion,@Doc_Stat,@Doc_RefDoc,@Stat,@CreateTime,@UpdateTime,@DeleteTime,@AuditStat,@AuditCurAudit);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(doc_Info.Doc_Code))
         {
            idb.AddParameter("@Doc_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Code", doc_Info.Doc_Code);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Type))
         {
            idb.AddParameter("@Doc_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Type", doc_Info.Doc_Type);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_TypeName))
         {
            idb.AddParameter("@Doc_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_TypeName", doc_Info.Doc_TypeName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_No))
         {
            idb.AddParameter("@Doc_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_No", doc_Info.Doc_No);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_IsBusyName))
         {
            idb.AddParameter("@Doc_IsBusyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_IsBusyName", doc_Info.Doc_IsBusyName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_IsBusy))
         {
            idb.AddParameter("@Doc_IsBusy", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_IsBusy", doc_Info.Doc_IsBusy);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Level))
         {
            idb.AddParameter("@Doc_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Level", doc_Info.Doc_Level);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_LevelName))
         {
            idb.AddParameter("@Doc_LevelName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_LevelName", doc_Info.Doc_LevelName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Title))
         {
            idb.AddParameter("@Doc_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Title", doc_Info.Doc_Title);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Object))
         {
            idb.AddParameter("@Doc_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Object", doc_Info.Doc_Object);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Cate))
         {
            idb.AddParameter("@Doc_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Cate", doc_Info.Doc_Cate);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_CateName))
         {
            idb.AddParameter("@Doc_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CateName", doc_Info.Doc_CateName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Creator))
         {
            idb.AddParameter("@Doc_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Creator", doc_Info.Doc_Creator);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_CreatorName))
         {
            idb.AddParameter("@Doc_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CreatorName", doc_Info.Doc_CreatorName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_DpCode))
         {
            idb.AddParameter("@Doc_DpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_DpCode", doc_Info.Doc_DpCode);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_DpName))
         {
            idb.AddParameter("@Doc_DpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_DpName", doc_Info.Doc_DpName);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_MainTitle))
         {
            idb.AddParameter("@Doc_MainTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_MainTitle", doc_Info.Doc_MainTitle);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_CC))
         {
            idb.AddParameter("@Doc_CC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CC", doc_Info.Doc_CC);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Content))
         {
            idb.AddParameter("@Doc_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Content", doc_Info.Doc_Content);
         }
         if (doc_Info.Doc_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Doc_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Date", doc_Info.Doc_Date);
         }
         if (doc_Info.Doc_Num == 0)
         {
            idb.AddParameter("@Doc_Num", 0);
         }
         else
         {
            idb.AddParameter("@Doc_Num", doc_Info.Doc_Num);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Opinion))
         {
            idb.AddParameter("@Doc_Opinion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Opinion", doc_Info.Doc_Opinion);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_Stat))
         {
            idb.AddParameter("@Doc_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Stat", doc_Info.Doc_Stat);
         }
         if (string.IsNullOrEmpty(doc_Info.Doc_RefDoc))
         {
            idb.AddParameter("@Doc_RefDoc", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_RefDoc", doc_Info.Doc_RefDoc);
         }
         if (doc_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Info.Stat);
         }
         if (doc_Info.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Info.CreateTime);
         }
         if (doc_Info.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Info.UpdateTime);
         }
         if (doc_Info.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Info.DeleteTime);
         }
         if (string.IsNullOrEmpty(doc_Info.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", doc_Info.AuditStat);
         }
         if (string.IsNullOrEmpty(doc_Info.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", doc_Info.AuditCurAudit);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Doc_Info对象(即:一条记录
      /// </summary>
      public int Update(Doc_Info doc_Info)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Doc_Info       SET ");
            if(doc_Info.Doc_Code_IsChanged){sbParameter.Append("Doc_Code=@Doc_Code, ");}
      if(doc_Info.Doc_Type_IsChanged){sbParameter.Append("Doc_Type=@Doc_Type, ");}
      if(doc_Info.Doc_TypeName_IsChanged){sbParameter.Append("Doc_TypeName=@Doc_TypeName, ");}
      if(doc_Info.Doc_No_IsChanged){sbParameter.Append("Doc_No=@Doc_No, ");}
      if(doc_Info.Doc_IsBusyName_IsChanged){sbParameter.Append("Doc_IsBusyName=@Doc_IsBusyName, ");}
      if(doc_Info.Doc_IsBusy_IsChanged){sbParameter.Append("Doc_IsBusy=@Doc_IsBusy, ");}
      if(doc_Info.Doc_Level_IsChanged){sbParameter.Append("Doc_Level=@Doc_Level, ");}
      if(doc_Info.Doc_LevelName_IsChanged){sbParameter.Append("Doc_LevelName=@Doc_LevelName, ");}
      if(doc_Info.Doc_Title_IsChanged){sbParameter.Append("Doc_Title=@Doc_Title, ");}
      if(doc_Info.Doc_Object_IsChanged){sbParameter.Append("Doc_Object=@Doc_Object, ");}
      if(doc_Info.Doc_Cate_IsChanged){sbParameter.Append("Doc_Cate=@Doc_Cate, ");}
      if(doc_Info.Doc_CateName_IsChanged){sbParameter.Append("Doc_CateName=@Doc_CateName, ");}
      if(doc_Info.Doc_Creator_IsChanged){sbParameter.Append("Doc_Creator=@Doc_Creator, ");}
      if(doc_Info.Doc_CreatorName_IsChanged){sbParameter.Append("Doc_CreatorName=@Doc_CreatorName, ");}
      if(doc_Info.Doc_DpCode_IsChanged){sbParameter.Append("Doc_DpCode=@Doc_DpCode, ");}
      if(doc_Info.Doc_DpName_IsChanged){sbParameter.Append("Doc_DpName=@Doc_DpName, ");}
      if(doc_Info.Doc_MainTitle_IsChanged){sbParameter.Append("Doc_MainTitle=@Doc_MainTitle, ");}
      if(doc_Info.Doc_CC_IsChanged){sbParameter.Append("Doc_CC=@Doc_CC, ");}
      if(doc_Info.Doc_Content_IsChanged){sbParameter.Append("Doc_Content=@Doc_Content, ");}
      if(doc_Info.Doc_Date_IsChanged){sbParameter.Append("Doc_Date=@Doc_Date, ");}
      if(doc_Info.Doc_Num_IsChanged){sbParameter.Append("Doc_Num=@Doc_Num, ");}
      if(doc_Info.Doc_Opinion_IsChanged){sbParameter.Append("Doc_Opinion=@Doc_Opinion, ");}
      if(doc_Info.Doc_Stat_IsChanged){sbParameter.Append("Doc_Stat=@Doc_Stat, ");}
      if(doc_Info.Doc_RefDoc_IsChanged){sbParameter.Append("Doc_RefDoc=@Doc_RefDoc, ");}
      if(doc_Info.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(doc_Info.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(doc_Info.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(doc_Info.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime, ");}
      if(doc_Info.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(doc_Info.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Doc_ID=@Doc_ID; " );
      string sql=sb.ToString();
         if(doc_Info.Doc_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Code))
         {
            idb.AddParameter("@Doc_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Code", doc_Info.Doc_Code);
         }
          }
         if(doc_Info.Doc_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Type))
         {
            idb.AddParameter("@Doc_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Type", doc_Info.Doc_Type);
         }
          }
         if(doc_Info.Doc_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_TypeName))
         {
            idb.AddParameter("@Doc_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_TypeName", doc_Info.Doc_TypeName);
         }
          }
         if(doc_Info.Doc_No_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_No))
         {
            idb.AddParameter("@Doc_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_No", doc_Info.Doc_No);
         }
          }
         if(doc_Info.Doc_IsBusyName_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_IsBusyName))
         {
            idb.AddParameter("@Doc_IsBusyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_IsBusyName", doc_Info.Doc_IsBusyName);
         }
          }
         if(doc_Info.Doc_IsBusy_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_IsBusy))
         {
            idb.AddParameter("@Doc_IsBusy", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_IsBusy", doc_Info.Doc_IsBusy);
         }
          }
         if(doc_Info.Doc_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Level))
         {
            idb.AddParameter("@Doc_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Level", doc_Info.Doc_Level);
         }
          }
         if(doc_Info.Doc_LevelName_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_LevelName))
         {
            idb.AddParameter("@Doc_LevelName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_LevelName", doc_Info.Doc_LevelName);
         }
          }
         if(doc_Info.Doc_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Title))
         {
            idb.AddParameter("@Doc_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Title", doc_Info.Doc_Title);
         }
          }
         if(doc_Info.Doc_Object_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Object))
         {
            idb.AddParameter("@Doc_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Object", doc_Info.Doc_Object);
         }
          }
         if(doc_Info.Doc_Cate_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Cate))
         {
            idb.AddParameter("@Doc_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Cate", doc_Info.Doc_Cate);
         }
          }
         if(doc_Info.Doc_CateName_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_CateName))
         {
            idb.AddParameter("@Doc_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CateName", doc_Info.Doc_CateName);
         }
          }
         if(doc_Info.Doc_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Creator))
         {
            idb.AddParameter("@Doc_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Creator", doc_Info.Doc_Creator);
         }
          }
         if(doc_Info.Doc_CreatorName_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_CreatorName))
         {
            idb.AddParameter("@Doc_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CreatorName", doc_Info.Doc_CreatorName);
         }
          }
         if(doc_Info.Doc_DpCode_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_DpCode))
         {
            idb.AddParameter("@Doc_DpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_DpCode", doc_Info.Doc_DpCode);
         }
          }
         if(doc_Info.Doc_DpName_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_DpName))
         {
            idb.AddParameter("@Doc_DpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_DpName", doc_Info.Doc_DpName);
         }
          }
         if(doc_Info.Doc_MainTitle_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_MainTitle))
         {
            idb.AddParameter("@Doc_MainTitle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_MainTitle", doc_Info.Doc_MainTitle);
         }
          }
         if(doc_Info.Doc_CC_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_CC))
         {
            idb.AddParameter("@Doc_CC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_CC", doc_Info.Doc_CC);
         }
          }
         if(doc_Info.Doc_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Content))
         {
            idb.AddParameter("@Doc_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Content", doc_Info.Doc_Content);
         }
          }
         if(doc_Info.Doc_Date_IsChanged)
         {
         if (doc_Info.Doc_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Doc_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Date", doc_Info.Doc_Date);
         }
          }
         if(doc_Info.Doc_Num_IsChanged)
         {
         if (doc_Info.Doc_Num == 0)
         {
            idb.AddParameter("@Doc_Num", 0);
         }
         else
         {
            idb.AddParameter("@Doc_Num", doc_Info.Doc_Num);
         }
          }
         if(doc_Info.Doc_Opinion_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Opinion))
         {
            idb.AddParameter("@Doc_Opinion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Opinion", doc_Info.Doc_Opinion);
         }
          }
         if(doc_Info.Doc_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_Stat))
         {
            idb.AddParameter("@Doc_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_Stat", doc_Info.Doc_Stat);
         }
          }
         if(doc_Info.Doc_RefDoc_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.Doc_RefDoc))
         {
            idb.AddParameter("@Doc_RefDoc", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Doc_RefDoc", doc_Info.Doc_RefDoc);
         }
          }
         if(doc_Info.Stat_IsChanged)
         {
         if (doc_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", doc_Info.Stat);
         }
          }
         if(doc_Info.CreateTime_IsChanged)
         {
         if (doc_Info.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", doc_Info.CreateTime);
         }
          }
         if(doc_Info.UpdateTime_IsChanged)
         {
         if (doc_Info.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", doc_Info.UpdateTime);
         }
          }
         if(doc_Info.DeleteTime_IsChanged)
         {
         if (doc_Info.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", doc_Info.DeleteTime);
         }
          }
         if(doc_Info.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", doc_Info.AuditStat);
         }
          }
         if(doc_Info.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(doc_Info.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", doc_Info.AuditCurAudit);
         }
          }

         idb.AddParameter("@Doc_ID", doc_Info.Doc_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Doc_Info对象(即:一条记录
      /// </summary>
      public int Delete(decimal doc_ID)
      {
         string sql = "DELETE Doc_Info WHERE 1=1  AND Doc_ID=@Doc_ID ";
         idb.AddParameter("@Doc_ID", doc_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Doc_Info对象(即:一条记录
      /// </summary>
      public Doc_Info GetByKey(decimal doc_ID)
      {
         Doc_Info doc_Info = new Doc_Info();
         string sql = "SELECT  Doc_ID,Doc_Code,Doc_Type,Doc_TypeName,Doc_No,Doc_IsBusyName,Doc_IsBusy,Doc_Level,Doc_LevelName,Doc_Title,Doc_Object,Doc_Cate,Doc_CateName,Doc_Creator,Doc_CreatorName,Doc_DpCode,Doc_DpName,Doc_MainTitle,Doc_CC,Doc_Content,Doc_Date,Doc_Num,Doc_Opinion,Doc_Stat,Doc_RefDoc,Stat,CreateTime,UpdateTime,DeleteTime,AuditStat,AuditCurAudit FROM Doc_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Doc_ID=@Doc_ID ";
         idb.AddParameter("@Doc_ID", doc_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Doc_ID"] != DBNull.Value) doc_Info.Doc_ID = Convert.ToDecimal(dr["Doc_ID"]);
            if (dr["Doc_Code"] != DBNull.Value) doc_Info.Doc_Code = Convert.ToString(dr["Doc_Code"]);
            if (dr["Doc_Type"] != DBNull.Value) doc_Info.Doc_Type = Convert.ToString(dr["Doc_Type"]);
            if (dr["Doc_TypeName"] != DBNull.Value) doc_Info.Doc_TypeName = Convert.ToString(dr["Doc_TypeName"]);
            if (dr["Doc_No"] != DBNull.Value) doc_Info.Doc_No = Convert.ToString(dr["Doc_No"]);
            if (dr["Doc_IsBusyName"] != DBNull.Value) doc_Info.Doc_IsBusyName = Convert.ToString(dr["Doc_IsBusyName"]);
            if (dr["Doc_IsBusy"] != DBNull.Value) doc_Info.Doc_IsBusy = Convert.ToString(dr["Doc_IsBusy"]);
            if (dr["Doc_Level"] != DBNull.Value) doc_Info.Doc_Level = Convert.ToString(dr["Doc_Level"]);
            if (dr["Doc_LevelName"] != DBNull.Value) doc_Info.Doc_LevelName = Convert.ToString(dr["Doc_LevelName"]);
            if (dr["Doc_Title"] != DBNull.Value) doc_Info.Doc_Title = Convert.ToString(dr["Doc_Title"]);
            if (dr["Doc_Object"] != DBNull.Value) doc_Info.Doc_Object = Convert.ToString(dr["Doc_Object"]);
            if (dr["Doc_Cate"] != DBNull.Value) doc_Info.Doc_Cate = Convert.ToString(dr["Doc_Cate"]);
            if (dr["Doc_CateName"] != DBNull.Value) doc_Info.Doc_CateName = Convert.ToString(dr["Doc_CateName"]);
            if (dr["Doc_Creator"] != DBNull.Value) doc_Info.Doc_Creator = Convert.ToString(dr["Doc_Creator"]);
            if (dr["Doc_CreatorName"] != DBNull.Value) doc_Info.Doc_CreatorName = Convert.ToString(dr["Doc_CreatorName"]);
            if (dr["Doc_DpCode"] != DBNull.Value) doc_Info.Doc_DpCode = Convert.ToString(dr["Doc_DpCode"]);
            if (dr["Doc_DpName"] != DBNull.Value) doc_Info.Doc_DpName = Convert.ToString(dr["Doc_DpName"]);
            if (dr["Doc_MainTitle"] != DBNull.Value) doc_Info.Doc_MainTitle = Convert.ToString(dr["Doc_MainTitle"]);
            if (dr["Doc_CC"] != DBNull.Value) doc_Info.Doc_CC = Convert.ToString(dr["Doc_CC"]);
            if (dr["Doc_Content"] != DBNull.Value) doc_Info.Doc_Content = Convert.ToString(dr["Doc_Content"]);
            if (dr["Doc_Date"] != DBNull.Value) doc_Info.Doc_Date = Convert.ToDateTime(dr["Doc_Date"]);
            if (dr["Doc_Num"] != DBNull.Value) doc_Info.Doc_Num = Convert.ToInt32(dr["Doc_Num"]);
            if (dr["Doc_Opinion"] != DBNull.Value) doc_Info.Doc_Opinion = Convert.ToString(dr["Doc_Opinion"]);
            if (dr["Doc_Stat"] != DBNull.Value) doc_Info.Doc_Stat = Convert.ToString(dr["Doc_Stat"]);
            if (dr["Doc_RefDoc"] != DBNull.Value) doc_Info.Doc_RefDoc = Convert.ToString(dr["Doc_RefDoc"]);
            if (dr["Stat"] != DBNull.Value) doc_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Info.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Info.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Info.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["AuditStat"] != DBNull.Value) doc_Info.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) doc_Info.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return doc_Info;
      }
      /// <summary>
      /// 获取指定的Doc_Info对象集合
      /// </summary>
      public List<Doc_Info> GetListByWhere(string strCondition)
      {
         List<Doc_Info> ret = new List<Doc_Info>();
         string sql = "SELECT  Doc_ID,Doc_Code,Doc_Type,Doc_TypeName,Doc_No,Doc_IsBusyName,Doc_IsBusy,Doc_Level,Doc_LevelName,Doc_Title,Doc_Object,Doc_Cate,Doc_CateName,Doc_Creator,Doc_CreatorName,Doc_DpCode,Doc_DpName,Doc_MainTitle,Doc_CC,Doc_Content,Doc_Date,Doc_Num,Doc_Opinion,Doc_Stat,Doc_RefDoc,Stat,CreateTime,UpdateTime,DeleteTime,AuditStat,AuditCurAudit FROM Doc_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Doc_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Doc_Info doc_Info = new Doc_Info();
            if (dr["Doc_ID"] != DBNull.Value) doc_Info.Doc_ID = Convert.ToDecimal(dr["Doc_ID"]);
            if (dr["Doc_Code"] != DBNull.Value) doc_Info.Doc_Code = Convert.ToString(dr["Doc_Code"]);
            if (dr["Doc_Type"] != DBNull.Value) doc_Info.Doc_Type = Convert.ToString(dr["Doc_Type"]);
            if (dr["Doc_TypeName"] != DBNull.Value) doc_Info.Doc_TypeName = Convert.ToString(dr["Doc_TypeName"]);
            if (dr["Doc_No"] != DBNull.Value) doc_Info.Doc_No = Convert.ToString(dr["Doc_No"]);
            if (dr["Doc_IsBusyName"] != DBNull.Value) doc_Info.Doc_IsBusyName = Convert.ToString(dr["Doc_IsBusyName"]);
            if (dr["Doc_IsBusy"] != DBNull.Value) doc_Info.Doc_IsBusy = Convert.ToString(dr["Doc_IsBusy"]);
            if (dr["Doc_Level"] != DBNull.Value) doc_Info.Doc_Level = Convert.ToString(dr["Doc_Level"]);
            if (dr["Doc_LevelName"] != DBNull.Value) doc_Info.Doc_LevelName = Convert.ToString(dr["Doc_LevelName"]);
            if (dr["Doc_Title"] != DBNull.Value) doc_Info.Doc_Title = Convert.ToString(dr["Doc_Title"]);
            if (dr["Doc_Object"] != DBNull.Value) doc_Info.Doc_Object = Convert.ToString(dr["Doc_Object"]);
            if (dr["Doc_Cate"] != DBNull.Value) doc_Info.Doc_Cate = Convert.ToString(dr["Doc_Cate"]);
            if (dr["Doc_CateName"] != DBNull.Value) doc_Info.Doc_CateName = Convert.ToString(dr["Doc_CateName"]);
            if (dr["Doc_Creator"] != DBNull.Value) doc_Info.Doc_Creator = Convert.ToString(dr["Doc_Creator"]);
            if (dr["Doc_CreatorName"] != DBNull.Value) doc_Info.Doc_CreatorName = Convert.ToString(dr["Doc_CreatorName"]);
            if (dr["Doc_DpCode"] != DBNull.Value) doc_Info.Doc_DpCode = Convert.ToString(dr["Doc_DpCode"]);
            if (dr["Doc_DpName"] != DBNull.Value) doc_Info.Doc_DpName = Convert.ToString(dr["Doc_DpName"]);
            if (dr["Doc_MainTitle"] != DBNull.Value) doc_Info.Doc_MainTitle = Convert.ToString(dr["Doc_MainTitle"]);
            if (dr["Doc_CC"] != DBNull.Value) doc_Info.Doc_CC = Convert.ToString(dr["Doc_CC"]);
            if (dr["Doc_Content"] != DBNull.Value) doc_Info.Doc_Content = Convert.ToString(dr["Doc_Content"]);
            if (dr["Doc_Date"] != DBNull.Value) doc_Info.Doc_Date = Convert.ToDateTime(dr["Doc_Date"]);
            if (dr["Doc_Num"] != DBNull.Value) doc_Info.Doc_Num = Convert.ToInt32(dr["Doc_Num"]);
            if (dr["Doc_Opinion"] != DBNull.Value) doc_Info.Doc_Opinion = Convert.ToString(dr["Doc_Opinion"]);
            if (dr["Doc_Stat"] != DBNull.Value) doc_Info.Doc_Stat = Convert.ToString(dr["Doc_Stat"]);
            if (dr["Doc_RefDoc"] != DBNull.Value) doc_Info.Doc_RefDoc = Convert.ToString(dr["Doc_RefDoc"]);
            if (dr["Stat"] != DBNull.Value) doc_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Info.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Info.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Info.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["AuditStat"] != DBNull.Value) doc_Info.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) doc_Info.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(doc_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Doc_Info对象(即:一条记录
      /// </summary>
      public List<Doc_Info> GetAll()
      {
         List<Doc_Info> ret = new List<Doc_Info>();
         string sql = "SELECT  Doc_ID,Doc_Code,Doc_Type,Doc_TypeName,Doc_No,Doc_IsBusyName,Doc_IsBusy,Doc_Level,Doc_LevelName,Doc_Title,Doc_Object,Doc_Cate,Doc_CateName,Doc_Creator,Doc_CreatorName,Doc_DpCode,Doc_DpName,Doc_MainTitle,Doc_CC,Doc_Content,Doc_Date,Doc_Num,Doc_Opinion,Doc_Stat,Doc_RefDoc,Stat,CreateTime,UpdateTime,DeleteTime,AuditStat,AuditCurAudit FROM Doc_Info where 1=1 AND ((Stat is null) or (Stat=0) ) order by Doc_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Doc_Info doc_Info = new Doc_Info();
            if (dr["Doc_ID"] != DBNull.Value) doc_Info.Doc_ID = Convert.ToDecimal(dr["Doc_ID"]);
            if (dr["Doc_Code"] != DBNull.Value) doc_Info.Doc_Code = Convert.ToString(dr["Doc_Code"]);
            if (dr["Doc_Type"] != DBNull.Value) doc_Info.Doc_Type = Convert.ToString(dr["Doc_Type"]);
            if (dr["Doc_TypeName"] != DBNull.Value) doc_Info.Doc_TypeName = Convert.ToString(dr["Doc_TypeName"]);
            if (dr["Doc_No"] != DBNull.Value) doc_Info.Doc_No = Convert.ToString(dr["Doc_No"]);
            if (dr["Doc_IsBusyName"] != DBNull.Value) doc_Info.Doc_IsBusyName = Convert.ToString(dr["Doc_IsBusyName"]);
            if (dr["Doc_IsBusy"] != DBNull.Value) doc_Info.Doc_IsBusy = Convert.ToString(dr["Doc_IsBusy"]);
            if (dr["Doc_Level"] != DBNull.Value) doc_Info.Doc_Level = Convert.ToString(dr["Doc_Level"]);
            if (dr["Doc_LevelName"] != DBNull.Value) doc_Info.Doc_LevelName = Convert.ToString(dr["Doc_LevelName"]);
            if (dr["Doc_Title"] != DBNull.Value) doc_Info.Doc_Title = Convert.ToString(dr["Doc_Title"]);
            if (dr["Doc_Object"] != DBNull.Value) doc_Info.Doc_Object = Convert.ToString(dr["Doc_Object"]);
            if (dr["Doc_Cate"] != DBNull.Value) doc_Info.Doc_Cate = Convert.ToString(dr["Doc_Cate"]);
            if (dr["Doc_CateName"] != DBNull.Value) doc_Info.Doc_CateName = Convert.ToString(dr["Doc_CateName"]);
            if (dr["Doc_Creator"] != DBNull.Value) doc_Info.Doc_Creator = Convert.ToString(dr["Doc_Creator"]);
            if (dr["Doc_CreatorName"] != DBNull.Value) doc_Info.Doc_CreatorName = Convert.ToString(dr["Doc_CreatorName"]);
            if (dr["Doc_DpCode"] != DBNull.Value) doc_Info.Doc_DpCode = Convert.ToString(dr["Doc_DpCode"]);
            if (dr["Doc_DpName"] != DBNull.Value) doc_Info.Doc_DpName = Convert.ToString(dr["Doc_DpName"]);
            if (dr["Doc_MainTitle"] != DBNull.Value) doc_Info.Doc_MainTitle = Convert.ToString(dr["Doc_MainTitle"]);
            if (dr["Doc_CC"] != DBNull.Value) doc_Info.Doc_CC = Convert.ToString(dr["Doc_CC"]);
            if (dr["Doc_Content"] != DBNull.Value) doc_Info.Doc_Content = Convert.ToString(dr["Doc_Content"]);
            if (dr["Doc_Date"] != DBNull.Value) doc_Info.Doc_Date = Convert.ToDateTime(dr["Doc_Date"]);
            if (dr["Doc_Num"] != DBNull.Value) doc_Info.Doc_Num = Convert.ToInt32(dr["Doc_Num"]);
            if (dr["Doc_Opinion"] != DBNull.Value) doc_Info.Doc_Opinion = Convert.ToString(dr["Doc_Opinion"]);
            if (dr["Doc_Stat"] != DBNull.Value) doc_Info.Doc_Stat = Convert.ToString(dr["Doc_Stat"]);
            if (dr["Doc_RefDoc"] != DBNull.Value) doc_Info.Doc_RefDoc = Convert.ToString(dr["Doc_RefDoc"]);
            if (dr["Stat"] != DBNull.Value) doc_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) doc_Info.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) doc_Info.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) doc_Info.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["AuditStat"] != DBNull.Value) doc_Info.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) doc_Info.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(doc_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
