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
   /// 合同工程信息
   /// </summary>
   [Serializable]
   public partial class ADOSD_Project
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加合同工程信息 SD_Project对象(即:一条记录)
      /// </summary>
      public int Add(SD_Project sD_Project)
      {
         string sql = "INSERT INTO SD_Project (SDI_Code,SDI_CCode,SDI_MCode,SDI_Name,SDI_Addr,SDI_Intro,SDI_Begin,SDI_End,SDI_Owner,SDI_Area,SDI_BCompany,SDI_BOwner,SDI_BContact,SDI_CCompany,SDI_CContact,SDI_OCompany,SDI_OOwner,SDI_OContact,SDI_PPeriod,SDI_PArea,SDI_PStructure,SDI_Bak,SDI_RPCode,SDI_PStatus,SDI_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDl_Field,SDl_Build,SDl_Laboratory,SDI_Company,SDI_CompanyCode) VALUES (@SDI_Code,@SDI_CCode,@SDI_MCode,@SDI_Name,@SDI_Addr,@SDI_Intro,@SDI_Begin,@SDI_End,@SDI_Owner,@SDI_Area,@SDI_BCompany,@SDI_BOwner,@SDI_BContact,@SDI_CCompany,@SDI_CContact,@SDI_OCompany,@SDI_OOwner,@SDI_OContact,@SDI_PPeriod,@SDI_PArea,@SDI_PStructure,@SDI_Bak,@SDI_RPCode,@SDI_PStatus,@SDI_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDl_Field,@SDl_Build,@SDl_Laboratory,@SDI_Company,@SDI_CompanyCode)";
         if (string.IsNullOrEmpty(sD_Project.SDI_Code))
         {
            idb.AddParameter("@SDI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Code", sD_Project.SDI_Code);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CCode))
         {
            idb.AddParameter("@SDI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CCode", sD_Project.SDI_CCode);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_MCode))
         {
            idb.AddParameter("@SDI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_MCode", sD_Project.SDI_MCode);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Name))
         {
            idb.AddParameter("@SDI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Name", sD_Project.SDI_Name);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Addr))
         {
            idb.AddParameter("@SDI_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Addr", sD_Project.SDI_Addr);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Intro))
         {
            idb.AddParameter("@SDI_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Intro", sD_Project.SDI_Intro);
         }
         if (sD_Project.SDI_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@SDI_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Begin", sD_Project.SDI_Begin);
         }
         if (sD_Project.SDI_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDI_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_End", sD_Project.SDI_End);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Owner))
         {
            idb.AddParameter("@SDI_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Owner", sD_Project.SDI_Owner);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Area))
         {
            idb.AddParameter("@SDI_Area", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Area", sD_Project.SDI_Area);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_BCompany))
         {
            idb.AddParameter("@SDI_BCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BCompany", sD_Project.SDI_BCompany);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_BOwner))
         {
            idb.AddParameter("@SDI_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BOwner", sD_Project.SDI_BOwner);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_BContact))
         {
            idb.AddParameter("@SDI_BContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BContact", sD_Project.SDI_BContact);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CCompany))
         {
            idb.AddParameter("@SDI_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CCompany", sD_Project.SDI_CCompany);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CContact))
         {
            idb.AddParameter("@SDI_CContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CContact", sD_Project.SDI_CContact);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_OCompany))
         {
            idb.AddParameter("@SDI_OCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OCompany", sD_Project.SDI_OCompany);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_OOwner))
         {
            idb.AddParameter("@SDI_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OOwner", sD_Project.SDI_OOwner);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_OContact))
         {
            idb.AddParameter("@SDI_OContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OContact", sD_Project.SDI_OContact);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PPeriod))
         {
            idb.AddParameter("@SDI_PPeriod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PPeriod", sD_Project.SDI_PPeriod);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PArea))
         {
            idb.AddParameter("@SDI_PArea", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PArea", sD_Project.SDI_PArea);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PStructure))
         {
            idb.AddParameter("@SDI_PStructure", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PStructure", sD_Project.SDI_PStructure);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Bak))
         {
            idb.AddParameter("@SDI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Bak", sD_Project.SDI_Bak);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_RPCode))
         {
            idb.AddParameter("@SDI_RPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_RPCode", sD_Project.SDI_RPCode);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PStatus))
         {
            idb.AddParameter("@SDI_PStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PStatus", sD_Project.SDI_PStatus);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_iType))
         {
            idb.AddParameter("@SDI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_iType", sD_Project.SDI_iType);
         }
         if (sD_Project.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Project.Stat);
         }
         if (sD_Project.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Project.CreateDate);
         }
         if (sD_Project.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Project.UpdateDate);
         }
         if (sD_Project.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Project.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Project.SDl_Field))
         {
            idb.AddParameter("@SDl_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Field", sD_Project.SDl_Field);
         }
         if (string.IsNullOrEmpty(sD_Project.SDl_Build))
         {
            idb.AddParameter("@SDl_Build", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Build", sD_Project.SDl_Build);
         }
         if (string.IsNullOrEmpty(sD_Project.SDl_Laboratory))
         {
            idb.AddParameter("@SDl_Laboratory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Laboratory", sD_Project.SDl_Laboratory);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Company))
         {
            idb.AddParameter("@SDI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Company", sD_Project.SDI_Company);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CompanyCode))
         {
            idb.AddParameter("@SDI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CompanyCode", sD_Project.SDI_CompanyCode);
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
      /// 添加合同工程信息 SD_Project对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Project sD_Project)
      {
         string sql = "INSERT INTO SD_Project (SDI_Code,SDI_CCode,SDI_MCode,SDI_Name,SDI_Addr,SDI_Intro,SDI_Begin,SDI_End,SDI_Owner,SDI_Area,SDI_BCompany,SDI_BOwner,SDI_BContact,SDI_CCompany,SDI_CContact,SDI_OCompany,SDI_OOwner,SDI_OContact,SDI_PPeriod,SDI_PArea,SDI_PStructure,SDI_Bak,SDI_RPCode,SDI_PStatus,SDI_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDl_Field,SDl_Build,SDl_Laboratory,SDI_Company,SDI_CompanyCode) VALUES (@SDI_Code,@SDI_CCode,@SDI_MCode,@SDI_Name,@SDI_Addr,@SDI_Intro,@SDI_Begin,@SDI_End,@SDI_Owner,@SDI_Area,@SDI_BCompany,@SDI_BOwner,@SDI_BContact,@SDI_CCompany,@SDI_CContact,@SDI_OCompany,@SDI_OOwner,@SDI_OContact,@SDI_PPeriod,@SDI_PArea,@SDI_PStructure,@SDI_Bak,@SDI_RPCode,@SDI_PStatus,@SDI_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@SDl_Field,@SDl_Build,@SDl_Laboratory,@SDI_Company,@SDI_CompanyCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Project.SDI_Code))
         {
            idb.AddParameter("@SDI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Code", sD_Project.SDI_Code);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CCode))
         {
            idb.AddParameter("@SDI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CCode", sD_Project.SDI_CCode);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_MCode))
         {
            idb.AddParameter("@SDI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_MCode", sD_Project.SDI_MCode);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Name))
         {
            idb.AddParameter("@SDI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Name", sD_Project.SDI_Name);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Addr))
         {
            idb.AddParameter("@SDI_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Addr", sD_Project.SDI_Addr);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Intro))
         {
            idb.AddParameter("@SDI_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Intro", sD_Project.SDI_Intro);
         }
         if (sD_Project.SDI_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@SDI_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Begin", sD_Project.SDI_Begin);
         }
         if (sD_Project.SDI_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDI_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_End", sD_Project.SDI_End);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Owner))
         {
            idb.AddParameter("@SDI_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Owner", sD_Project.SDI_Owner);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Area))
         {
            idb.AddParameter("@SDI_Area", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Area", sD_Project.SDI_Area);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_BCompany))
         {
            idb.AddParameter("@SDI_BCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BCompany", sD_Project.SDI_BCompany);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_BOwner))
         {
            idb.AddParameter("@SDI_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BOwner", sD_Project.SDI_BOwner);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_BContact))
         {
            idb.AddParameter("@SDI_BContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BContact", sD_Project.SDI_BContact);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CCompany))
         {
            idb.AddParameter("@SDI_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CCompany", sD_Project.SDI_CCompany);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CContact))
         {
            idb.AddParameter("@SDI_CContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CContact", sD_Project.SDI_CContact);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_OCompany))
         {
            idb.AddParameter("@SDI_OCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OCompany", sD_Project.SDI_OCompany);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_OOwner))
         {
            idb.AddParameter("@SDI_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OOwner", sD_Project.SDI_OOwner);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_OContact))
         {
            idb.AddParameter("@SDI_OContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OContact", sD_Project.SDI_OContact);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PPeriod))
         {
            idb.AddParameter("@SDI_PPeriod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PPeriod", sD_Project.SDI_PPeriod);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PArea))
         {
            idb.AddParameter("@SDI_PArea", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PArea", sD_Project.SDI_PArea);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PStructure))
         {
            idb.AddParameter("@SDI_PStructure", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PStructure", sD_Project.SDI_PStructure);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Bak))
         {
            idb.AddParameter("@SDI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Bak", sD_Project.SDI_Bak);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_RPCode))
         {
            idb.AddParameter("@SDI_RPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_RPCode", sD_Project.SDI_RPCode);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_PStatus))
         {
            idb.AddParameter("@SDI_PStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PStatus", sD_Project.SDI_PStatus);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_iType))
         {
            idb.AddParameter("@SDI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_iType", sD_Project.SDI_iType);
         }
         if (sD_Project.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Project.Stat);
         }
         if (sD_Project.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Project.CreateDate);
         }
         if (sD_Project.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Project.UpdateDate);
         }
         if (sD_Project.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Project.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Project.SDl_Field))
         {
            idb.AddParameter("@SDl_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Field", sD_Project.SDl_Field);
         }
         if (string.IsNullOrEmpty(sD_Project.SDl_Build))
         {
            idb.AddParameter("@SDl_Build", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Build", sD_Project.SDl_Build);
         }
         if (string.IsNullOrEmpty(sD_Project.SDl_Laboratory))
         {
            idb.AddParameter("@SDl_Laboratory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Laboratory", sD_Project.SDl_Laboratory);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_Company))
         {
            idb.AddParameter("@SDI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Company", sD_Project.SDI_Company);
         }
         if (string.IsNullOrEmpty(sD_Project.SDI_CompanyCode))
         {
            idb.AddParameter("@SDI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CompanyCode", sD_Project.SDI_CompanyCode);
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
      /// 更新合同工程信息 SD_Project对象(即:一条记录
      /// </summary>
      public int Update(SD_Project sD_Project)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Project       SET ");
            if(sD_Project.SDI_Code_IsChanged){sbParameter.Append("SDI_Code=@SDI_Code, ");}
      if(sD_Project.SDI_CCode_IsChanged){sbParameter.Append("SDI_CCode=@SDI_CCode, ");}
      if(sD_Project.SDI_MCode_IsChanged){sbParameter.Append("SDI_MCode=@SDI_MCode, ");}
      if(sD_Project.SDI_Name_IsChanged){sbParameter.Append("SDI_Name=@SDI_Name, ");}
      if(sD_Project.SDI_Addr_IsChanged){sbParameter.Append("SDI_Addr=@SDI_Addr, ");}
      if(sD_Project.SDI_Intro_IsChanged){sbParameter.Append("SDI_Intro=@SDI_Intro, ");}
      if(sD_Project.SDI_Begin_IsChanged){sbParameter.Append("SDI_Begin=@SDI_Begin, ");}
      if(sD_Project.SDI_End_IsChanged){sbParameter.Append("SDI_End=@SDI_End, ");}
      if(sD_Project.SDI_Owner_IsChanged){sbParameter.Append("SDI_Owner=@SDI_Owner, ");}
      if(sD_Project.SDI_Area_IsChanged){sbParameter.Append("SDI_Area=@SDI_Area, ");}
      if(sD_Project.SDI_BCompany_IsChanged){sbParameter.Append("SDI_BCompany=@SDI_BCompany, ");}
      if(sD_Project.SDI_BOwner_IsChanged){sbParameter.Append("SDI_BOwner=@SDI_BOwner, ");}
      if(sD_Project.SDI_BContact_IsChanged){sbParameter.Append("SDI_BContact=@SDI_BContact, ");}
      if(sD_Project.SDI_CCompany_IsChanged){sbParameter.Append("SDI_CCompany=@SDI_CCompany, ");}
      if(sD_Project.SDI_CContact_IsChanged){sbParameter.Append("SDI_CContact=@SDI_CContact, ");}
      if(sD_Project.SDI_OCompany_IsChanged){sbParameter.Append("SDI_OCompany=@SDI_OCompany, ");}
      if(sD_Project.SDI_OOwner_IsChanged){sbParameter.Append("SDI_OOwner=@SDI_OOwner, ");}
      if(sD_Project.SDI_OContact_IsChanged){sbParameter.Append("SDI_OContact=@SDI_OContact, ");}
      if(sD_Project.SDI_PPeriod_IsChanged){sbParameter.Append("SDI_PPeriod=@SDI_PPeriod, ");}
      if(sD_Project.SDI_PArea_IsChanged){sbParameter.Append("SDI_PArea=@SDI_PArea, ");}
      if(sD_Project.SDI_PStructure_IsChanged){sbParameter.Append("SDI_PStructure=@SDI_PStructure, ");}
      if(sD_Project.SDI_Bak_IsChanged){sbParameter.Append("SDI_Bak=@SDI_Bak, ");}
      if(sD_Project.SDI_RPCode_IsChanged){sbParameter.Append("SDI_RPCode=@SDI_RPCode, ");}
      if(sD_Project.SDI_PStatus_IsChanged){sbParameter.Append("SDI_PStatus=@SDI_PStatus, ");}
      if(sD_Project.SDI_iType_IsChanged){sbParameter.Append("SDI_iType=@SDI_iType, ");}
      if(sD_Project.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Project.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_Project.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_Project.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_Project.SDl_Field_IsChanged){sbParameter.Append("SDl_Field=@SDl_Field, ");}
      if(sD_Project.SDl_Build_IsChanged){sbParameter.Append("SDl_Build=@SDl_Build, ");}
      if(sD_Project.SDl_Laboratory_IsChanged){sbParameter.Append("SDl_Laboratory=@SDl_Laboratory, ");}
      if(sD_Project.SDI_Company_IsChanged){sbParameter.Append("SDI_Company=@SDI_Company, ");}
      if(sD_Project.SDI_CompanyCode_IsChanged){sbParameter.Append("SDI_CompanyCode=@SDI_CompanyCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDI_ID=@SDI_ID; " );
      string sql=sb.ToString();
         if(sD_Project.SDI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Code))
         {
            idb.AddParameter("@SDI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Code", sD_Project.SDI_Code);
         }
          }
         if(sD_Project.SDI_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_CCode))
         {
            idb.AddParameter("@SDI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CCode", sD_Project.SDI_CCode);
         }
          }
         if(sD_Project.SDI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_MCode))
         {
            idb.AddParameter("@SDI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_MCode", sD_Project.SDI_MCode);
         }
          }
         if(sD_Project.SDI_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Name))
         {
            idb.AddParameter("@SDI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Name", sD_Project.SDI_Name);
         }
          }
         if(sD_Project.SDI_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Addr))
         {
            idb.AddParameter("@SDI_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Addr", sD_Project.SDI_Addr);
         }
          }
         if(sD_Project.SDI_Intro_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Intro))
         {
            idb.AddParameter("@SDI_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Intro", sD_Project.SDI_Intro);
         }
          }
         if(sD_Project.SDI_Begin_IsChanged)
         {
         if (sD_Project.SDI_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@SDI_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Begin", sD_Project.SDI_Begin);
         }
          }
         if(sD_Project.SDI_End_IsChanged)
         {
         if (sD_Project.SDI_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDI_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_End", sD_Project.SDI_End);
         }
          }
         if(sD_Project.SDI_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Owner))
         {
            idb.AddParameter("@SDI_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Owner", sD_Project.SDI_Owner);
         }
          }
         if(sD_Project.SDI_Area_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Area))
         {
            idb.AddParameter("@SDI_Area", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Area", sD_Project.SDI_Area);
         }
          }
         if(sD_Project.SDI_BCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_BCompany))
         {
            idb.AddParameter("@SDI_BCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BCompany", sD_Project.SDI_BCompany);
         }
          }
         if(sD_Project.SDI_BOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_BOwner))
         {
            idb.AddParameter("@SDI_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BOwner", sD_Project.SDI_BOwner);
         }
          }
         if(sD_Project.SDI_BContact_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_BContact))
         {
            idb.AddParameter("@SDI_BContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_BContact", sD_Project.SDI_BContact);
         }
          }
         if(sD_Project.SDI_CCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_CCompany))
         {
            idb.AddParameter("@SDI_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CCompany", sD_Project.SDI_CCompany);
         }
          }
         if(sD_Project.SDI_CContact_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_CContact))
         {
            idb.AddParameter("@SDI_CContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CContact", sD_Project.SDI_CContact);
         }
          }
         if(sD_Project.SDI_OCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_OCompany))
         {
            idb.AddParameter("@SDI_OCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OCompany", sD_Project.SDI_OCompany);
         }
          }
         if(sD_Project.SDI_OOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_OOwner))
         {
            idb.AddParameter("@SDI_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OOwner", sD_Project.SDI_OOwner);
         }
          }
         if(sD_Project.SDI_OContact_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_OContact))
         {
            idb.AddParameter("@SDI_OContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_OContact", sD_Project.SDI_OContact);
         }
          }
         if(sD_Project.SDI_PPeriod_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_PPeriod))
         {
            idb.AddParameter("@SDI_PPeriod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PPeriod", sD_Project.SDI_PPeriod);
         }
          }
         if(sD_Project.SDI_PArea_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_PArea))
         {
            idb.AddParameter("@SDI_PArea", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PArea", sD_Project.SDI_PArea);
         }
          }
         if(sD_Project.SDI_PStructure_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_PStructure))
         {
            idb.AddParameter("@SDI_PStructure", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PStructure", sD_Project.SDI_PStructure);
         }
          }
         if(sD_Project.SDI_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Bak))
         {
            idb.AddParameter("@SDI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Bak", sD_Project.SDI_Bak);
         }
          }
         if(sD_Project.SDI_RPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_RPCode))
         {
            idb.AddParameter("@SDI_RPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_RPCode", sD_Project.SDI_RPCode);
         }
          }
         if(sD_Project.SDI_PStatus_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_PStatus))
         {
            idb.AddParameter("@SDI_PStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_PStatus", sD_Project.SDI_PStatus);
         }
          }
         if(sD_Project.SDI_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_iType))
         {
            idb.AddParameter("@SDI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_iType", sD_Project.SDI_iType);
         }
          }
         if(sD_Project.Stat_IsChanged)
         {
         if (sD_Project.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Project.Stat);
         }
          }
         if(sD_Project.CreateDate_IsChanged)
         {
         if (sD_Project.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Project.CreateDate);
         }
          }
         if(sD_Project.UpdateDate_IsChanged)
         {
         if (sD_Project.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Project.UpdateDate);
         }
          }
         if(sD_Project.DeleteDate_IsChanged)
         {
         if (sD_Project.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Project.DeleteDate);
         }
          }
         if(sD_Project.SDl_Field_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDl_Field))
         {
            idb.AddParameter("@SDl_Field", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Field", sD_Project.SDl_Field);
         }
          }
         if(sD_Project.SDl_Build_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDl_Build))
         {
            idb.AddParameter("@SDl_Build", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Build", sD_Project.SDl_Build);
         }
          }
         if(sD_Project.SDl_Laboratory_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDl_Laboratory))
         {
            idb.AddParameter("@SDl_Laboratory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDl_Laboratory", sD_Project.SDl_Laboratory);
         }
          }
         if(sD_Project.SDI_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_Company))
         {
            idb.AddParameter("@SDI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_Company", sD_Project.SDI_Company);
         }
          }
         if(sD_Project.SDI_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Project.SDI_CompanyCode))
         {
            idb.AddParameter("@SDI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDI_CompanyCode", sD_Project.SDI_CompanyCode);
         }
          }

         idb.AddParameter("@SDI_ID", sD_Project.SDI_ID);

           
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
      /// 删除合同工程信息 SD_Project对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDI_ID)
      {
         string sql = "DELETE SD_Project WHERE 1=1  AND SDI_ID=@SDI_ID ";
         idb.AddParameter("@SDI_ID", sDI_ID);

           
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
      /// 获取指定的合同工程信息 SD_Project对象(即:一条记录
      /// </summary>
      public SD_Project GetByKey(decimal sDI_ID)
      {
         SD_Project sD_Project = new SD_Project();
         string sql = "SELECT  SDI_ID,SDI_Code,SDI_CCode,SDI_MCode,SDI_Name,SDI_Addr,SDI_Intro,SDI_Begin,SDI_End,SDI_Owner,SDI_Area,SDI_BCompany,SDI_BOwner,SDI_BContact,SDI_CCompany,SDI_CContact,SDI_OCompany,SDI_OOwner,SDI_OContact,SDI_PPeriod,SDI_PArea,SDI_PStructure,SDI_Bak,SDI_RPCode,SDI_PStatus,SDI_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDl_Field,SDl_Build,SDl_Laboratory,SDI_Company,SDI_CompanyCode FROM SD_Project WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDI_ID=@SDI_ID ";
         idb.AddParameter("@SDI_ID", sDI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDI_ID"] != DBNull.Value) sD_Project.SDI_ID = Convert.ToDecimal(dr["SDI_ID"]);
            if (dr["SDI_Code"] != DBNull.Value) sD_Project.SDI_Code = Convert.ToString(dr["SDI_Code"]);
            if (dr["SDI_CCode"] != DBNull.Value) sD_Project.SDI_CCode = Convert.ToString(dr["SDI_CCode"]);
            if (dr["SDI_MCode"] != DBNull.Value) sD_Project.SDI_MCode = Convert.ToString(dr["SDI_MCode"]);
            if (dr["SDI_Name"] != DBNull.Value) sD_Project.SDI_Name = Convert.ToString(dr["SDI_Name"]);
            if (dr["SDI_Addr"] != DBNull.Value) sD_Project.SDI_Addr = Convert.ToString(dr["SDI_Addr"]);
            if (dr["SDI_Intro"] != DBNull.Value) sD_Project.SDI_Intro = Convert.ToString(dr["SDI_Intro"]);
            if (dr["SDI_Begin"] != DBNull.Value) sD_Project.SDI_Begin = Convert.ToDateTime(dr["SDI_Begin"]);
            if (dr["SDI_End"] != DBNull.Value) sD_Project.SDI_End = Convert.ToDateTime(dr["SDI_End"]);
            if (dr["SDI_Owner"] != DBNull.Value) sD_Project.SDI_Owner = Convert.ToString(dr["SDI_Owner"]);
            if (dr["SDI_Area"] != DBNull.Value) sD_Project.SDI_Area = Convert.ToString(dr["SDI_Area"]);
            if (dr["SDI_BCompany"] != DBNull.Value) sD_Project.SDI_BCompany = Convert.ToString(dr["SDI_BCompany"]);
            if (dr["SDI_BOwner"] != DBNull.Value) sD_Project.SDI_BOwner = Convert.ToString(dr["SDI_BOwner"]);
            if (dr["SDI_BContact"] != DBNull.Value) sD_Project.SDI_BContact = Convert.ToString(dr["SDI_BContact"]);
            if (dr["SDI_CCompany"] != DBNull.Value) sD_Project.SDI_CCompany = Convert.ToString(dr["SDI_CCompany"]);
            if (dr["SDI_CContact"] != DBNull.Value) sD_Project.SDI_CContact = Convert.ToString(dr["SDI_CContact"]);
            if (dr["SDI_OCompany"] != DBNull.Value) sD_Project.SDI_OCompany = Convert.ToString(dr["SDI_OCompany"]);
            if (dr["SDI_OOwner"] != DBNull.Value) sD_Project.SDI_OOwner = Convert.ToString(dr["SDI_OOwner"]);
            if (dr["SDI_OContact"] != DBNull.Value) sD_Project.SDI_OContact = Convert.ToString(dr["SDI_OContact"]);
            if (dr["SDI_PPeriod"] != DBNull.Value) sD_Project.SDI_PPeriod = Convert.ToString(dr["SDI_PPeriod"]);
            if (dr["SDI_PArea"] != DBNull.Value) sD_Project.SDI_PArea = Convert.ToString(dr["SDI_PArea"]);
            if (dr["SDI_PStructure"] != DBNull.Value) sD_Project.SDI_PStructure = Convert.ToString(dr["SDI_PStructure"]);
            if (dr["SDI_Bak"] != DBNull.Value) sD_Project.SDI_Bak = Convert.ToString(dr["SDI_Bak"]);
            if (dr["SDI_RPCode"] != DBNull.Value) sD_Project.SDI_RPCode = Convert.ToString(dr["SDI_RPCode"]);
            if (dr["SDI_PStatus"] != DBNull.Value) sD_Project.SDI_PStatus = Convert.ToString(dr["SDI_PStatus"]);
            if (dr["SDI_iType"] != DBNull.Value) sD_Project.SDI_iType = Convert.ToString(dr["SDI_iType"]);
            if (dr["Stat"] != DBNull.Value) sD_Project.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Project.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Project.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Project.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDl_Field"] != DBNull.Value) sD_Project.SDl_Field = Convert.ToString(dr["SDl_Field"]);
            if (dr["SDl_Build"] != DBNull.Value) sD_Project.SDl_Build = Convert.ToString(dr["SDl_Build"]);
            if (dr["SDl_Laboratory"] != DBNull.Value) sD_Project.SDl_Laboratory = Convert.ToString(dr["SDl_Laboratory"]);
            if (dr["SDI_Company"] != DBNull.Value) sD_Project.SDI_Company = Convert.ToString(dr["SDI_Company"]);
            if (dr["SDI_CompanyCode"] != DBNull.Value) sD_Project.SDI_CompanyCode = Convert.ToString(dr["SDI_CompanyCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Project;
      }
      /// <summary>
      /// 获取指定的合同工程信息 SD_Project对象集合
      /// </summary>
      public List<SD_Project> GetListByWhere(string strCondition)
      {
         List<SD_Project> ret = new List<SD_Project>();
         string sql = "SELECT  SDI_ID,SDI_Code,SDI_CCode,SDI_MCode,SDI_Name,SDI_Addr,SDI_Intro,SDI_Begin,SDI_End,SDI_Owner,SDI_Area,SDI_BCompany,SDI_BOwner,SDI_BContact,SDI_CCompany,SDI_CContact,SDI_OCompany,SDI_OOwner,SDI_OContact,SDI_PPeriod,SDI_PArea,SDI_PStructure,SDI_Bak,SDI_RPCode,SDI_PStatus,SDI_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDl_Field,SDl_Build,SDl_Laboratory,SDI_Company,SDI_CompanyCode FROM SD_Project WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Project sD_Project = new SD_Project();
            if (dr["SDI_ID"] != DBNull.Value) sD_Project.SDI_ID = Convert.ToDecimal(dr["SDI_ID"]);
            if (dr["SDI_Code"] != DBNull.Value) sD_Project.SDI_Code = Convert.ToString(dr["SDI_Code"]);
            if (dr["SDI_CCode"] != DBNull.Value) sD_Project.SDI_CCode = Convert.ToString(dr["SDI_CCode"]);
            if (dr["SDI_MCode"] != DBNull.Value) sD_Project.SDI_MCode = Convert.ToString(dr["SDI_MCode"]);
            if (dr["SDI_Name"] != DBNull.Value) sD_Project.SDI_Name = Convert.ToString(dr["SDI_Name"]);
            if (dr["SDI_Addr"] != DBNull.Value) sD_Project.SDI_Addr = Convert.ToString(dr["SDI_Addr"]);
            if (dr["SDI_Intro"] != DBNull.Value) sD_Project.SDI_Intro = Convert.ToString(dr["SDI_Intro"]);
            if (dr["SDI_Begin"] != DBNull.Value) sD_Project.SDI_Begin = Convert.ToDateTime(dr["SDI_Begin"]);
            if (dr["SDI_End"] != DBNull.Value) sD_Project.SDI_End = Convert.ToDateTime(dr["SDI_End"]);
            if (dr["SDI_Owner"] != DBNull.Value) sD_Project.SDI_Owner = Convert.ToString(dr["SDI_Owner"]);
            if (dr["SDI_Area"] != DBNull.Value) sD_Project.SDI_Area = Convert.ToString(dr["SDI_Area"]);
            if (dr["SDI_BCompany"] != DBNull.Value) sD_Project.SDI_BCompany = Convert.ToString(dr["SDI_BCompany"]);
            if (dr["SDI_BOwner"] != DBNull.Value) sD_Project.SDI_BOwner = Convert.ToString(dr["SDI_BOwner"]);
            if (dr["SDI_BContact"] != DBNull.Value) sD_Project.SDI_BContact = Convert.ToString(dr["SDI_BContact"]);
            if (dr["SDI_CCompany"] != DBNull.Value) sD_Project.SDI_CCompany = Convert.ToString(dr["SDI_CCompany"]);
            if (dr["SDI_CContact"] != DBNull.Value) sD_Project.SDI_CContact = Convert.ToString(dr["SDI_CContact"]);
            if (dr["SDI_OCompany"] != DBNull.Value) sD_Project.SDI_OCompany = Convert.ToString(dr["SDI_OCompany"]);
            if (dr["SDI_OOwner"] != DBNull.Value) sD_Project.SDI_OOwner = Convert.ToString(dr["SDI_OOwner"]);
            if (dr["SDI_OContact"] != DBNull.Value) sD_Project.SDI_OContact = Convert.ToString(dr["SDI_OContact"]);
            if (dr["SDI_PPeriod"] != DBNull.Value) sD_Project.SDI_PPeriod = Convert.ToString(dr["SDI_PPeriod"]);
            if (dr["SDI_PArea"] != DBNull.Value) sD_Project.SDI_PArea = Convert.ToString(dr["SDI_PArea"]);
            if (dr["SDI_PStructure"] != DBNull.Value) sD_Project.SDI_PStructure = Convert.ToString(dr["SDI_PStructure"]);
            if (dr["SDI_Bak"] != DBNull.Value) sD_Project.SDI_Bak = Convert.ToString(dr["SDI_Bak"]);
            if (dr["SDI_RPCode"] != DBNull.Value) sD_Project.SDI_RPCode = Convert.ToString(dr["SDI_RPCode"]);
            if (dr["SDI_PStatus"] != DBNull.Value) sD_Project.SDI_PStatus = Convert.ToString(dr["SDI_PStatus"]);
            if (dr["SDI_iType"] != DBNull.Value) sD_Project.SDI_iType = Convert.ToString(dr["SDI_iType"]);
            if (dr["Stat"] != DBNull.Value) sD_Project.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Project.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Project.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Project.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDl_Field"] != DBNull.Value) sD_Project.SDl_Field = Convert.ToString(dr["SDl_Field"]);
            if (dr["SDl_Build"] != DBNull.Value) sD_Project.SDl_Build = Convert.ToString(dr["SDl_Build"]);
            if (dr["SDl_Laboratory"] != DBNull.Value) sD_Project.SDl_Laboratory = Convert.ToString(dr["SDl_Laboratory"]);
            if (dr["SDI_Company"] != DBNull.Value) sD_Project.SDI_Company = Convert.ToString(dr["SDI_Company"]);
            if (dr["SDI_CompanyCode"] != DBNull.Value) sD_Project.SDI_CompanyCode = Convert.ToString(dr["SDI_CompanyCode"]);
            ret.Add(sD_Project);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的合同工程信息 SD_Project对象(即:一条记录
      /// </summary>
      public List<SD_Project> GetAll()
      {
         List<SD_Project> ret = new List<SD_Project>();
         string sql = "SELECT  SDI_ID,SDI_Code,SDI_CCode,SDI_MCode,SDI_Name,SDI_Addr,SDI_Intro,SDI_Begin,SDI_End,SDI_Owner,SDI_Area,SDI_BCompany,SDI_BOwner,SDI_BContact,SDI_CCompany,SDI_CContact,SDI_OCompany,SDI_OOwner,SDI_OContact,SDI_PPeriod,SDI_PArea,SDI_PStructure,SDI_Bak,SDI_RPCode,SDI_PStatus,SDI_iType,Stat,CreateDate,UpdateDate,DeleteDate,SDl_Field,SDl_Build,SDl_Laboratory,SDI_Company,SDI_CompanyCode FROM SD_Project where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Project sD_Project = new SD_Project();
            if (dr["SDI_ID"] != DBNull.Value) sD_Project.SDI_ID = Convert.ToDecimal(dr["SDI_ID"]);
            if (dr["SDI_Code"] != DBNull.Value) sD_Project.SDI_Code = Convert.ToString(dr["SDI_Code"]);
            if (dr["SDI_CCode"] != DBNull.Value) sD_Project.SDI_CCode = Convert.ToString(dr["SDI_CCode"]);
            if (dr["SDI_MCode"] != DBNull.Value) sD_Project.SDI_MCode = Convert.ToString(dr["SDI_MCode"]);
            if (dr["SDI_Name"] != DBNull.Value) sD_Project.SDI_Name = Convert.ToString(dr["SDI_Name"]);
            if (dr["SDI_Addr"] != DBNull.Value) sD_Project.SDI_Addr = Convert.ToString(dr["SDI_Addr"]);
            if (dr["SDI_Intro"] != DBNull.Value) sD_Project.SDI_Intro = Convert.ToString(dr["SDI_Intro"]);
            if (dr["SDI_Begin"] != DBNull.Value) sD_Project.SDI_Begin = Convert.ToDateTime(dr["SDI_Begin"]);
            if (dr["SDI_End"] != DBNull.Value) sD_Project.SDI_End = Convert.ToDateTime(dr["SDI_End"]);
            if (dr["SDI_Owner"] != DBNull.Value) sD_Project.SDI_Owner = Convert.ToString(dr["SDI_Owner"]);
            if (dr["SDI_Area"] != DBNull.Value) sD_Project.SDI_Area = Convert.ToString(dr["SDI_Area"]);
            if (dr["SDI_BCompany"] != DBNull.Value) sD_Project.SDI_BCompany = Convert.ToString(dr["SDI_BCompany"]);
            if (dr["SDI_BOwner"] != DBNull.Value) sD_Project.SDI_BOwner = Convert.ToString(dr["SDI_BOwner"]);
            if (dr["SDI_BContact"] != DBNull.Value) sD_Project.SDI_BContact = Convert.ToString(dr["SDI_BContact"]);
            if (dr["SDI_CCompany"] != DBNull.Value) sD_Project.SDI_CCompany = Convert.ToString(dr["SDI_CCompany"]);
            if (dr["SDI_CContact"] != DBNull.Value) sD_Project.SDI_CContact = Convert.ToString(dr["SDI_CContact"]);
            if (dr["SDI_OCompany"] != DBNull.Value) sD_Project.SDI_OCompany = Convert.ToString(dr["SDI_OCompany"]);
            if (dr["SDI_OOwner"] != DBNull.Value) sD_Project.SDI_OOwner = Convert.ToString(dr["SDI_OOwner"]);
            if (dr["SDI_OContact"] != DBNull.Value) sD_Project.SDI_OContact = Convert.ToString(dr["SDI_OContact"]);
            if (dr["SDI_PPeriod"] != DBNull.Value) sD_Project.SDI_PPeriod = Convert.ToString(dr["SDI_PPeriod"]);
            if (dr["SDI_PArea"] != DBNull.Value) sD_Project.SDI_PArea = Convert.ToString(dr["SDI_PArea"]);
            if (dr["SDI_PStructure"] != DBNull.Value) sD_Project.SDI_PStructure = Convert.ToString(dr["SDI_PStructure"]);
            if (dr["SDI_Bak"] != DBNull.Value) sD_Project.SDI_Bak = Convert.ToString(dr["SDI_Bak"]);
            if (dr["SDI_RPCode"] != DBNull.Value) sD_Project.SDI_RPCode = Convert.ToString(dr["SDI_RPCode"]);
            if (dr["SDI_PStatus"] != DBNull.Value) sD_Project.SDI_PStatus = Convert.ToString(dr["SDI_PStatus"]);
            if (dr["SDI_iType"] != DBNull.Value) sD_Project.SDI_iType = Convert.ToString(dr["SDI_iType"]);
            if (dr["Stat"] != DBNull.Value) sD_Project.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Project.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Project.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Project.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["SDl_Field"] != DBNull.Value) sD_Project.SDl_Field = Convert.ToString(dr["SDl_Field"]);
            if (dr["SDl_Build"] != DBNull.Value) sD_Project.SDl_Build = Convert.ToString(dr["SDl_Build"]);
            if (dr["SDl_Laboratory"] != DBNull.Value) sD_Project.SDl_Laboratory = Convert.ToString(dr["SDl_Laboratory"]);
            if (dr["SDI_Company"] != DBNull.Value) sD_Project.SDI_Company = Convert.ToString(dr["SDI_Company"]);
            if (dr["SDI_CompanyCode"] != DBNull.Value) sD_Project.SDI_CompanyCode = Convert.ToString(dr["SDI_CompanyCode"]);
            ret.Add(sD_Project);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
