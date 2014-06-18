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
   /// 物料出库细表
   /// </summary>
   [Serializable]
   public partial class ADOWH_IOItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加物料出库细表 WH_IOItem对象(即:一条记录)
      /// </summary>
      public int Add(WH_IOItem wH_IOItem)
      {
         string sql = "INSERT INTO WH_IOItem (WHIOI_Code,WHIOI_MainCode,WHIOI_MCode,WHIOI_MName,WHIOI_MSpec,WHIOI_MUnit,WHIOI_MNum,WHIOI_MPrice,WHIOI_Company,WHIOI_Department,WHIOI_UType,WHIOI_UOwner,WHIOI_UOwnerCode,WHIOI_Date,Stat,CreateDate,UpdateDate,DeleteDate,WHIOM_Code,WHIOI_RefWName,WHIOI_RefWCode,WHIOI_RefWNo,WHIOI_RefWNoName,WHIOI_Udef1,WHIOI_Udef2,WHIOI_Udef3,WHIOI_Udef4,WHIOI_Udef5,WHIOI_CCompany,WHIOI_CCompanyCode,WHIOI_CDept,WHIOI_CDeptCode,WHIOI_UDEF6,WHIOI_UDEF7,WHIOI_UDEF8,WHIOI_UDEF9,WHIOI_UDEF10,WHIOI_Num1,WHIOI_Num2,WHIOI_Num3,WHIOI_Num4,WHIOI_Num5) VALUES (@WHIOI_Code,@WHIOI_MainCode,@WHIOI_MCode,@WHIOI_MName,@WHIOI_MSpec,@WHIOI_MUnit,@WHIOI_MNum,@WHIOI_MPrice,@WHIOI_Company,@WHIOI_Department,@WHIOI_UType,@WHIOI_UOwner,@WHIOI_UOwnerCode,@WHIOI_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHIOM_Code,@WHIOI_RefWName,@WHIOI_RefWCode,@WHIOI_RefWNo,@WHIOI_RefWNoName,@WHIOI_Udef1,@WHIOI_Udef2,@WHIOI_Udef3,@WHIOI_Udef4,@WHIOI_Udef5,@WHIOI_CCompany,@WHIOI_CCompanyCode,@WHIOI_CDept,@WHIOI_CDeptCode,@WHIOI_UDEF6,@WHIOI_UDEF7,@WHIOI_UDEF8,@WHIOI_UDEF9,@WHIOI_UDEF10,@WHIOI_Num1,@WHIOI_Num2,@WHIOI_Num3,@WHIOI_Num4,@WHIOI_Num5)";
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Code))
         {
            idb.AddParameter("@WHIOI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Code", wH_IOItem.WHIOI_Code);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MainCode))
         {
            idb.AddParameter("@WHIOI_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MainCode", wH_IOItem.WHIOI_MainCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MCode))
         {
            idb.AddParameter("@WHIOI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MCode", wH_IOItem.WHIOI_MCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MName))
         {
            idb.AddParameter("@WHIOI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MName", wH_IOItem.WHIOI_MName);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MSpec))
         {
            idb.AddParameter("@WHIOI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MSpec", wH_IOItem.WHIOI_MSpec);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MUnit))
         {
            idb.AddParameter("@WHIOI_MUnit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MUnit", wH_IOItem.WHIOI_MUnit);
         }
         if (wH_IOItem.WHIOI_MNum == 0)
         {
            idb.AddParameter("@WHIOI_MNum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_MNum", wH_IOItem.WHIOI_MNum);
         }
         if (wH_IOItem.WHIOI_MPrice == 0)
         {
            idb.AddParameter("@WHIOI_MPrice", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_MPrice", wH_IOItem.WHIOI_MPrice);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Company))
         {
            idb.AddParameter("@WHIOI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Company", wH_IOItem.WHIOI_Company);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Department))
         {
            idb.AddParameter("@WHIOI_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Department", wH_IOItem.WHIOI_Department);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UType))
         {
            idb.AddParameter("@WHIOI_UType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UType", wH_IOItem.WHIOI_UType);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UOwner))
         {
            idb.AddParameter("@WHIOI_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UOwner", wH_IOItem.WHIOI_UOwner);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UOwnerCode))
         {
            idb.AddParameter("@WHIOI_UOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UOwnerCode", wH_IOItem.WHIOI_UOwnerCode);
         }
         if (wH_IOItem.WHIOI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Date", wH_IOItem.WHIOI_Date);
         }
         if (wH_IOItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_IOItem.Stat);
         }
         if (wH_IOItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_IOItem.CreateDate);
         }
         if (wH_IOItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_IOItem.UpdateDate);
         }
         if (wH_IOItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_IOItem.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOM_Code))
         {
            idb.AddParameter("@WHIOM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Code", wH_IOItem.WHIOM_Code);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWName))
         {
            idb.AddParameter("@WHIOI_RefWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWName", wH_IOItem.WHIOI_RefWName);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWCode))
         {
            idb.AddParameter("@WHIOI_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWCode", wH_IOItem.WHIOI_RefWCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWNo))
         {
            idb.AddParameter("@WHIOI_RefWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWNo", wH_IOItem.WHIOI_RefWNo);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWNoName))
         {
            idb.AddParameter("@WHIOI_RefWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWNoName", wH_IOItem.WHIOI_RefWNoName);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef1))
         {
            idb.AddParameter("@WHIOI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef1", wH_IOItem.WHIOI_Udef1);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef2))
         {
            idb.AddParameter("@WHIOI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef2", wH_IOItem.WHIOI_Udef2);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef3))
         {
            idb.AddParameter("@WHIOI_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef3", wH_IOItem.WHIOI_Udef3);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef4))
         {
            idb.AddParameter("@WHIOI_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef4", wH_IOItem.WHIOI_Udef4);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef5))
         {
            idb.AddParameter("@WHIOI_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef5", wH_IOItem.WHIOI_Udef5);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CCompany))
         {
            idb.AddParameter("@WHIOI_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CCompany", wH_IOItem.WHIOI_CCompany);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CCompanyCode))
         {
            idb.AddParameter("@WHIOI_CCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CCompanyCode", wH_IOItem.WHIOI_CCompanyCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CDept))
         {
            idb.AddParameter("@WHIOI_CDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CDept", wH_IOItem.WHIOI_CDept);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CDeptCode))
         {
            idb.AddParameter("@WHIOI_CDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CDeptCode", wH_IOItem.WHIOI_CDeptCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF6))
         {
            idb.AddParameter("@WHIOI_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF6", wH_IOItem.WHIOI_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF7))
         {
            idb.AddParameter("@WHIOI_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF7", wH_IOItem.WHIOI_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF8))
         {
            idb.AddParameter("@WHIOI_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF8", wH_IOItem.WHIOI_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF9))
         {
            idb.AddParameter("@WHIOI_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF9", wH_IOItem.WHIOI_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF10))
         {
            idb.AddParameter("@WHIOI_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF10", wH_IOItem.WHIOI_UDEF10);
         }
         if (wH_IOItem.WHIOI_Num1 == 0)
         {
            idb.AddParameter("@WHIOI_Num1", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num1", wH_IOItem.WHIOI_Num1);
         }
         if (wH_IOItem.WHIOI_Num2 == 0)
         {
            idb.AddParameter("@WHIOI_Num2", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num2", wH_IOItem.WHIOI_Num2);
         }
         if (wH_IOItem.WHIOI_Num3 == 0)
         {
            idb.AddParameter("@WHIOI_Num3", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num3", wH_IOItem.WHIOI_Num3);
         }
         if (wH_IOItem.WHIOI_Num4 == 0)
         {
            idb.AddParameter("@WHIOI_Num4", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num4", wH_IOItem.WHIOI_Num4);
         }
         if (wH_IOItem.WHIOI_Num5 == 0)
         {
            idb.AddParameter("@WHIOI_Num5", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num5", wH_IOItem.WHIOI_Num5);
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
      /// 添加物料出库细表 WH_IOItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_IOItem wH_IOItem)
      {
         string sql = "INSERT INTO WH_IOItem (WHIOI_Code,WHIOI_MainCode,WHIOI_MCode,WHIOI_MName,WHIOI_MSpec,WHIOI_MUnit,WHIOI_MNum,WHIOI_MPrice,WHIOI_Company,WHIOI_Department,WHIOI_UType,WHIOI_UOwner,WHIOI_UOwnerCode,WHIOI_Date,Stat,CreateDate,UpdateDate,DeleteDate,WHIOM_Code,WHIOI_RefWName,WHIOI_RefWCode,WHIOI_RefWNo,WHIOI_RefWNoName,WHIOI_Udef1,WHIOI_Udef2,WHIOI_Udef3,WHIOI_Udef4,WHIOI_Udef5,WHIOI_CCompany,WHIOI_CCompanyCode,WHIOI_CDept,WHIOI_CDeptCode,WHIOI_UDEF6,WHIOI_UDEF7,WHIOI_UDEF8,WHIOI_UDEF9,WHIOI_UDEF10,WHIOI_Num1,WHIOI_Num2,WHIOI_Num3,WHIOI_Num4,WHIOI_Num5) VALUES (@WHIOI_Code,@WHIOI_MainCode,@WHIOI_MCode,@WHIOI_MName,@WHIOI_MSpec,@WHIOI_MUnit,@WHIOI_MNum,@WHIOI_MPrice,@WHIOI_Company,@WHIOI_Department,@WHIOI_UType,@WHIOI_UOwner,@WHIOI_UOwnerCode,@WHIOI_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHIOM_Code,@WHIOI_RefWName,@WHIOI_RefWCode,@WHIOI_RefWNo,@WHIOI_RefWNoName,@WHIOI_Udef1,@WHIOI_Udef2,@WHIOI_Udef3,@WHIOI_Udef4,@WHIOI_Udef5,@WHIOI_CCompany,@WHIOI_CCompanyCode,@WHIOI_CDept,@WHIOI_CDeptCode,@WHIOI_UDEF6,@WHIOI_UDEF7,@WHIOI_UDEF8,@WHIOI_UDEF9,@WHIOI_UDEF10,@WHIOI_Num1,@WHIOI_Num2,@WHIOI_Num3,@WHIOI_Num4,@WHIOI_Num5);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Code))
         {
            idb.AddParameter("@WHIOI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Code", wH_IOItem.WHIOI_Code);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MainCode))
         {
            idb.AddParameter("@WHIOI_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MainCode", wH_IOItem.WHIOI_MainCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MCode))
         {
            idb.AddParameter("@WHIOI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MCode", wH_IOItem.WHIOI_MCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MName))
         {
            idb.AddParameter("@WHIOI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MName", wH_IOItem.WHIOI_MName);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MSpec))
         {
            idb.AddParameter("@WHIOI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MSpec", wH_IOItem.WHIOI_MSpec);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MUnit))
         {
            idb.AddParameter("@WHIOI_MUnit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MUnit", wH_IOItem.WHIOI_MUnit);
         }
         if (wH_IOItem.WHIOI_MNum == 0)
         {
            idb.AddParameter("@WHIOI_MNum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_MNum", wH_IOItem.WHIOI_MNum);
         }
         if (wH_IOItem.WHIOI_MPrice == 0)
         {
            idb.AddParameter("@WHIOI_MPrice", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_MPrice", wH_IOItem.WHIOI_MPrice);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Company))
         {
            idb.AddParameter("@WHIOI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Company", wH_IOItem.WHIOI_Company);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Department))
         {
            idb.AddParameter("@WHIOI_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Department", wH_IOItem.WHIOI_Department);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UType))
         {
            idb.AddParameter("@WHIOI_UType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UType", wH_IOItem.WHIOI_UType);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UOwner))
         {
            idb.AddParameter("@WHIOI_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UOwner", wH_IOItem.WHIOI_UOwner);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UOwnerCode))
         {
            idb.AddParameter("@WHIOI_UOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UOwnerCode", wH_IOItem.WHIOI_UOwnerCode);
         }
         if (wH_IOItem.WHIOI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Date", wH_IOItem.WHIOI_Date);
         }
         if (wH_IOItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_IOItem.Stat);
         }
         if (wH_IOItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_IOItem.CreateDate);
         }
         if (wH_IOItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_IOItem.UpdateDate);
         }
         if (wH_IOItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_IOItem.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOM_Code))
         {
            idb.AddParameter("@WHIOM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Code", wH_IOItem.WHIOM_Code);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWName))
         {
            idb.AddParameter("@WHIOI_RefWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWName", wH_IOItem.WHIOI_RefWName);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWCode))
         {
            idb.AddParameter("@WHIOI_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWCode", wH_IOItem.WHIOI_RefWCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWNo))
         {
            idb.AddParameter("@WHIOI_RefWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWNo", wH_IOItem.WHIOI_RefWNo);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWNoName))
         {
            idb.AddParameter("@WHIOI_RefWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWNoName", wH_IOItem.WHIOI_RefWNoName);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef1))
         {
            idb.AddParameter("@WHIOI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef1", wH_IOItem.WHIOI_Udef1);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef2))
         {
            idb.AddParameter("@WHIOI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef2", wH_IOItem.WHIOI_Udef2);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef3))
         {
            idb.AddParameter("@WHIOI_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef3", wH_IOItem.WHIOI_Udef3);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef4))
         {
            idb.AddParameter("@WHIOI_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef4", wH_IOItem.WHIOI_Udef4);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef5))
         {
            idb.AddParameter("@WHIOI_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef5", wH_IOItem.WHIOI_Udef5);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CCompany))
         {
            idb.AddParameter("@WHIOI_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CCompany", wH_IOItem.WHIOI_CCompany);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CCompanyCode))
         {
            idb.AddParameter("@WHIOI_CCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CCompanyCode", wH_IOItem.WHIOI_CCompanyCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CDept))
         {
            idb.AddParameter("@WHIOI_CDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CDept", wH_IOItem.WHIOI_CDept);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CDeptCode))
         {
            idb.AddParameter("@WHIOI_CDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CDeptCode", wH_IOItem.WHIOI_CDeptCode);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF6))
         {
            idb.AddParameter("@WHIOI_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF6", wH_IOItem.WHIOI_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF7))
         {
            idb.AddParameter("@WHIOI_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF7", wH_IOItem.WHIOI_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF8))
         {
            idb.AddParameter("@WHIOI_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF8", wH_IOItem.WHIOI_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF9))
         {
            idb.AddParameter("@WHIOI_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF9", wH_IOItem.WHIOI_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF10))
         {
            idb.AddParameter("@WHIOI_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF10", wH_IOItem.WHIOI_UDEF10);
         }
         if (wH_IOItem.WHIOI_Num1 == 0)
         {
            idb.AddParameter("@WHIOI_Num1", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num1", wH_IOItem.WHIOI_Num1);
         }
         if (wH_IOItem.WHIOI_Num2 == 0)
         {
            idb.AddParameter("@WHIOI_Num2", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num2", wH_IOItem.WHIOI_Num2);
         }
         if (wH_IOItem.WHIOI_Num3 == 0)
         {
            idb.AddParameter("@WHIOI_Num3", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num3", wH_IOItem.WHIOI_Num3);
         }
         if (wH_IOItem.WHIOI_Num4 == 0)
         {
            idb.AddParameter("@WHIOI_Num4", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num4", wH_IOItem.WHIOI_Num4);
         }
         if (wH_IOItem.WHIOI_Num5 == 0)
         {
            idb.AddParameter("@WHIOI_Num5", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num5", wH_IOItem.WHIOI_Num5);
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
      /// 更新物料出库细表 WH_IOItem对象(即:一条记录
      /// </summary>
      public int Update(WH_IOItem wH_IOItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_IOItem       SET ");
            if(wH_IOItem.WHIOI_Code_IsChanged){sbParameter.Append("WHIOI_Code=@WHIOI_Code, ");}
      if(wH_IOItem.WHIOI_MainCode_IsChanged){sbParameter.Append("WHIOI_MainCode=@WHIOI_MainCode, ");}
      if(wH_IOItem.WHIOI_MCode_IsChanged){sbParameter.Append("WHIOI_MCode=@WHIOI_MCode, ");}
      if(wH_IOItem.WHIOI_MName_IsChanged){sbParameter.Append("WHIOI_MName=@WHIOI_MName, ");}
      if(wH_IOItem.WHIOI_MSpec_IsChanged){sbParameter.Append("WHIOI_MSpec=@WHIOI_MSpec, ");}
      if(wH_IOItem.WHIOI_MUnit_IsChanged){sbParameter.Append("WHIOI_MUnit=@WHIOI_MUnit, ");}
      if(wH_IOItem.WHIOI_MNum_IsChanged){sbParameter.Append("WHIOI_MNum=@WHIOI_MNum, ");}
      if(wH_IOItem.WHIOI_MPrice_IsChanged){sbParameter.Append("WHIOI_MPrice=@WHIOI_MPrice, ");}
      if(wH_IOItem.WHIOI_Company_IsChanged){sbParameter.Append("WHIOI_Company=@WHIOI_Company, ");}
      if(wH_IOItem.WHIOI_Department_IsChanged){sbParameter.Append("WHIOI_Department=@WHIOI_Department, ");}
      if(wH_IOItem.WHIOI_UType_IsChanged){sbParameter.Append("WHIOI_UType=@WHIOI_UType, ");}
      if(wH_IOItem.WHIOI_UOwner_IsChanged){sbParameter.Append("WHIOI_UOwner=@WHIOI_UOwner, ");}
      if(wH_IOItem.WHIOI_UOwnerCode_IsChanged){sbParameter.Append("WHIOI_UOwnerCode=@WHIOI_UOwnerCode, ");}
      if(wH_IOItem.WHIOI_Date_IsChanged){sbParameter.Append("WHIOI_Date=@WHIOI_Date, ");}
      if(wH_IOItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_IOItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_IOItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_IOItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_IOItem.WHIOM_Code_IsChanged){sbParameter.Append("WHIOM_Code=@WHIOM_Code, ");}
      if(wH_IOItem.WHIOI_RefWName_IsChanged){sbParameter.Append("WHIOI_RefWName=@WHIOI_RefWName, ");}
      if(wH_IOItem.WHIOI_RefWCode_IsChanged){sbParameter.Append("WHIOI_RefWCode=@WHIOI_RefWCode, ");}
      if(wH_IOItem.WHIOI_RefWNo_IsChanged){sbParameter.Append("WHIOI_RefWNo=@WHIOI_RefWNo, ");}
      if(wH_IOItem.WHIOI_RefWNoName_IsChanged){sbParameter.Append("WHIOI_RefWNoName=@WHIOI_RefWNoName, ");}
      if(wH_IOItem.WHIOI_Udef1_IsChanged){sbParameter.Append("WHIOI_Udef1=@WHIOI_Udef1, ");}
      if(wH_IOItem.WHIOI_Udef2_IsChanged){sbParameter.Append("WHIOI_Udef2=@WHIOI_Udef2, ");}
      if(wH_IOItem.WHIOI_Udef3_IsChanged){sbParameter.Append("WHIOI_Udef3=@WHIOI_Udef3, ");}
      if(wH_IOItem.WHIOI_Udef4_IsChanged){sbParameter.Append("WHIOI_Udef4=@WHIOI_Udef4, ");}
      if(wH_IOItem.WHIOI_Udef5_IsChanged){sbParameter.Append("WHIOI_Udef5=@WHIOI_Udef5, ");}
      if(wH_IOItem.WHIOI_CCompany_IsChanged){sbParameter.Append("WHIOI_CCompany=@WHIOI_CCompany, ");}
      if(wH_IOItem.WHIOI_CCompanyCode_IsChanged){sbParameter.Append("WHIOI_CCompanyCode=@WHIOI_CCompanyCode, ");}
      if(wH_IOItem.WHIOI_CDept_IsChanged){sbParameter.Append("WHIOI_CDept=@WHIOI_CDept, ");}
      if(wH_IOItem.WHIOI_CDeptCode_IsChanged){sbParameter.Append("WHIOI_CDeptCode=@WHIOI_CDeptCode, ");}
      if(wH_IOItem.WHIOI_UDEF6_IsChanged){sbParameter.Append("WHIOI_UDEF6=@WHIOI_UDEF6, ");}
      if(wH_IOItem.WHIOI_UDEF7_IsChanged){sbParameter.Append("WHIOI_UDEF7=@WHIOI_UDEF7, ");}
      if(wH_IOItem.WHIOI_UDEF8_IsChanged){sbParameter.Append("WHIOI_UDEF8=@WHIOI_UDEF8, ");}
      if(wH_IOItem.WHIOI_UDEF9_IsChanged){sbParameter.Append("WHIOI_UDEF9=@WHIOI_UDEF9, ");}
      if(wH_IOItem.WHIOI_UDEF10_IsChanged){sbParameter.Append("WHIOI_UDEF10=@WHIOI_UDEF10, ");}
      if(wH_IOItem.WHIOI_Num1_IsChanged){sbParameter.Append("WHIOI_Num1=@WHIOI_Num1, ");}
      if(wH_IOItem.WHIOI_Num2_IsChanged){sbParameter.Append("WHIOI_Num2=@WHIOI_Num2, ");}
      if(wH_IOItem.WHIOI_Num3_IsChanged){sbParameter.Append("WHIOI_Num3=@WHIOI_Num3, ");}
      if(wH_IOItem.WHIOI_Num4_IsChanged){sbParameter.Append("WHIOI_Num4=@WHIOI_Num4, ");}
      if(wH_IOItem.WHIOI_Num5_IsChanged){sbParameter.Append("WHIOI_Num5=@WHIOI_Num5 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHIOI_ID=@WHIOI_ID; " );
      string sql=sb.ToString();
         if(wH_IOItem.WHIOI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Code))
         {
            idb.AddParameter("@WHIOI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Code", wH_IOItem.WHIOI_Code);
         }
          }
         if(wH_IOItem.WHIOI_MainCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MainCode))
         {
            idb.AddParameter("@WHIOI_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MainCode", wH_IOItem.WHIOI_MainCode);
         }
          }
         if(wH_IOItem.WHIOI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MCode))
         {
            idb.AddParameter("@WHIOI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MCode", wH_IOItem.WHIOI_MCode);
         }
          }
         if(wH_IOItem.WHIOI_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MName))
         {
            idb.AddParameter("@WHIOI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MName", wH_IOItem.WHIOI_MName);
         }
          }
         if(wH_IOItem.WHIOI_MSpec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MSpec))
         {
            idb.AddParameter("@WHIOI_MSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MSpec", wH_IOItem.WHIOI_MSpec);
         }
          }
         if(wH_IOItem.WHIOI_MUnit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_MUnit))
         {
            idb.AddParameter("@WHIOI_MUnit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_MUnit", wH_IOItem.WHIOI_MUnit);
         }
          }
         if(wH_IOItem.WHIOI_MNum_IsChanged)
         {
         if (wH_IOItem.WHIOI_MNum == 0)
         {
            idb.AddParameter("@WHIOI_MNum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_MNum", wH_IOItem.WHIOI_MNum);
         }
          }
         if(wH_IOItem.WHIOI_MPrice_IsChanged)
         {
         if (wH_IOItem.WHIOI_MPrice == 0)
         {
            idb.AddParameter("@WHIOI_MPrice", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_MPrice", wH_IOItem.WHIOI_MPrice);
         }
          }
         if(wH_IOItem.WHIOI_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Company))
         {
            idb.AddParameter("@WHIOI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Company", wH_IOItem.WHIOI_Company);
         }
          }
         if(wH_IOItem.WHIOI_Department_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Department))
         {
            idb.AddParameter("@WHIOI_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Department", wH_IOItem.WHIOI_Department);
         }
          }
         if(wH_IOItem.WHIOI_UType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UType))
         {
            idb.AddParameter("@WHIOI_UType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UType", wH_IOItem.WHIOI_UType);
         }
          }
         if(wH_IOItem.WHIOI_UOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UOwner))
         {
            idb.AddParameter("@WHIOI_UOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UOwner", wH_IOItem.WHIOI_UOwner);
         }
          }
         if(wH_IOItem.WHIOI_UOwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UOwnerCode))
         {
            idb.AddParameter("@WHIOI_UOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UOwnerCode", wH_IOItem.WHIOI_UOwnerCode);
         }
          }
         if(wH_IOItem.WHIOI_Date_IsChanged)
         {
         if (wH_IOItem.WHIOI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Date", wH_IOItem.WHIOI_Date);
         }
          }
         if(wH_IOItem.Stat_IsChanged)
         {
         if (wH_IOItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_IOItem.Stat);
         }
          }
         if(wH_IOItem.CreateDate_IsChanged)
         {
         if (wH_IOItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_IOItem.CreateDate);
         }
          }
         if(wH_IOItem.UpdateDate_IsChanged)
         {
         if (wH_IOItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_IOItem.UpdateDate);
         }
          }
         if(wH_IOItem.DeleteDate_IsChanged)
         {
         if (wH_IOItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_IOItem.DeleteDate);
         }
          }
         if(wH_IOItem.WHIOM_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOM_Code))
         {
            idb.AddParameter("@WHIOM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Code", wH_IOItem.WHIOM_Code);
         }
          }
         if(wH_IOItem.WHIOI_RefWName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWName))
         {
            idb.AddParameter("@WHIOI_RefWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWName", wH_IOItem.WHIOI_RefWName);
         }
          }
         if(wH_IOItem.WHIOI_RefWCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWCode))
         {
            idb.AddParameter("@WHIOI_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWCode", wH_IOItem.WHIOI_RefWCode);
         }
          }
         if(wH_IOItem.WHIOI_RefWNo_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWNo))
         {
            idb.AddParameter("@WHIOI_RefWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWNo", wH_IOItem.WHIOI_RefWNo);
         }
          }
         if(wH_IOItem.WHIOI_RefWNoName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_RefWNoName))
         {
            idb.AddParameter("@WHIOI_RefWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_RefWNoName", wH_IOItem.WHIOI_RefWNoName);
         }
          }
         if(wH_IOItem.WHIOI_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef1))
         {
            idb.AddParameter("@WHIOI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef1", wH_IOItem.WHIOI_Udef1);
         }
          }
         if(wH_IOItem.WHIOI_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef2))
         {
            idb.AddParameter("@WHIOI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef2", wH_IOItem.WHIOI_Udef2);
         }
          }
         if(wH_IOItem.WHIOI_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef3))
         {
            idb.AddParameter("@WHIOI_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef3", wH_IOItem.WHIOI_Udef3);
         }
          }
         if(wH_IOItem.WHIOI_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef4))
         {
            idb.AddParameter("@WHIOI_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef4", wH_IOItem.WHIOI_Udef4);
         }
          }
         if(wH_IOItem.WHIOI_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_Udef5))
         {
            idb.AddParameter("@WHIOI_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_Udef5", wH_IOItem.WHIOI_Udef5);
         }
          }
         if(wH_IOItem.WHIOI_CCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CCompany))
         {
            idb.AddParameter("@WHIOI_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CCompany", wH_IOItem.WHIOI_CCompany);
         }
          }
         if(wH_IOItem.WHIOI_CCompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CCompanyCode))
         {
            idb.AddParameter("@WHIOI_CCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CCompanyCode", wH_IOItem.WHIOI_CCompanyCode);
         }
          }
         if(wH_IOItem.WHIOI_CDept_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CDept))
         {
            idb.AddParameter("@WHIOI_CDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CDept", wH_IOItem.WHIOI_CDept);
         }
          }
         if(wH_IOItem.WHIOI_CDeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_CDeptCode))
         {
            idb.AddParameter("@WHIOI_CDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_CDeptCode", wH_IOItem.WHIOI_CDeptCode);
         }
          }
         if(wH_IOItem.WHIOI_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF6))
         {
            idb.AddParameter("@WHIOI_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF6", wH_IOItem.WHIOI_UDEF6);
         }
          }
         if(wH_IOItem.WHIOI_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF7))
         {
            idb.AddParameter("@WHIOI_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF7", wH_IOItem.WHIOI_UDEF7);
         }
          }
         if(wH_IOItem.WHIOI_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF8))
         {
            idb.AddParameter("@WHIOI_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF8", wH_IOItem.WHIOI_UDEF8);
         }
          }
         if(wH_IOItem.WHIOI_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF9))
         {
            idb.AddParameter("@WHIOI_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF9", wH_IOItem.WHIOI_UDEF9);
         }
          }
         if(wH_IOItem.WHIOI_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOItem.WHIOI_UDEF10))
         {
            idb.AddParameter("@WHIOI_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOI_UDEF10", wH_IOItem.WHIOI_UDEF10);
         }
          }
         if(wH_IOItem.WHIOI_Num1_IsChanged)
         {
         if (wH_IOItem.WHIOI_Num1 == 0)
         {
            idb.AddParameter("@WHIOI_Num1", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num1", wH_IOItem.WHIOI_Num1);
         }
          }
         if(wH_IOItem.WHIOI_Num2_IsChanged)
         {
         if (wH_IOItem.WHIOI_Num2 == 0)
         {
            idb.AddParameter("@WHIOI_Num2", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num2", wH_IOItem.WHIOI_Num2);
         }
          }
         if(wH_IOItem.WHIOI_Num3_IsChanged)
         {
         if (wH_IOItem.WHIOI_Num3 == 0)
         {
            idb.AddParameter("@WHIOI_Num3", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num3", wH_IOItem.WHIOI_Num3);
         }
          }
         if(wH_IOItem.WHIOI_Num4_IsChanged)
         {
         if (wH_IOItem.WHIOI_Num4 == 0)
         {
            idb.AddParameter("@WHIOI_Num4", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num4", wH_IOItem.WHIOI_Num4);
         }
          }
         if(wH_IOItem.WHIOI_Num5_IsChanged)
         {
         if (wH_IOItem.WHIOI_Num5 == 0)
         {
            idb.AddParameter("@WHIOI_Num5", 0);
         }
         else
         {
            idb.AddParameter("@WHIOI_Num5", wH_IOItem.WHIOI_Num5);
         }
          }

         idb.AddParameter("@WHIOI_ID", wH_IOItem.WHIOI_ID);

           
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
      /// 删除物料出库细表 WH_IOItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHIOI_ID)
      {
         string sql = "DELETE WH_IOItem WHERE 1=1  AND WHIOI_ID=@WHIOI_ID ";
         idb.AddParameter("@WHIOI_ID", wHIOI_ID);

           
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
      /// 获取指定的物料出库细表 WH_IOItem对象(即:一条记录
      /// </summary>
      public WH_IOItem GetByKey(decimal wHIOI_ID)
      {
         WH_IOItem wH_IOItem = new WH_IOItem();
         string sql = "SELECT  WHIOI_ID,WHIOI_Code,WHIOI_MainCode,WHIOI_MCode,WHIOI_MName,WHIOI_MSpec,WHIOI_MUnit,WHIOI_MNum,WHIOI_MPrice,WHIOI_Company,WHIOI_Department,WHIOI_UType,WHIOI_UOwner,WHIOI_UOwnerCode,WHIOI_Date,Stat,CreateDate,UpdateDate,DeleteDate,WHIOM_Code,WHIOI_RefWName,WHIOI_RefWCode,WHIOI_RefWNo,WHIOI_RefWNoName,WHIOI_Udef1,WHIOI_Udef2,WHIOI_Udef3,WHIOI_Udef4,WHIOI_Udef5,WHIOI_CCompany,WHIOI_CCompanyCode,WHIOI_CDept,WHIOI_CDeptCode,WHIOI_UDEF6,WHIOI_UDEF7,WHIOI_UDEF8,WHIOI_UDEF9,WHIOI_UDEF10,WHIOI_Num1,WHIOI_Num2,WHIOI_Num3,WHIOI_Num4,WHIOI_Num5 FROM WH_IOItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHIOI_ID=@WHIOI_ID ";
         idb.AddParameter("@WHIOI_ID", wHIOI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHIOI_ID"] != DBNull.Value) wH_IOItem.WHIOI_ID = Convert.ToDecimal(dr["WHIOI_ID"]);
            if (dr["WHIOI_Code"] != DBNull.Value) wH_IOItem.WHIOI_Code = Convert.ToString(dr["WHIOI_Code"]);
            if (dr["WHIOI_MainCode"] != DBNull.Value) wH_IOItem.WHIOI_MainCode = Convert.ToString(dr["WHIOI_MainCode"]);
            if (dr["WHIOI_MCode"] != DBNull.Value) wH_IOItem.WHIOI_MCode = Convert.ToString(dr["WHIOI_MCode"]);
            if (dr["WHIOI_MName"] != DBNull.Value) wH_IOItem.WHIOI_MName = Convert.ToString(dr["WHIOI_MName"]);
            if (dr["WHIOI_MSpec"] != DBNull.Value) wH_IOItem.WHIOI_MSpec = Convert.ToString(dr["WHIOI_MSpec"]);
            if (dr["WHIOI_MUnit"] != DBNull.Value) wH_IOItem.WHIOI_MUnit = Convert.ToString(dr["WHIOI_MUnit"]);
            if (dr["WHIOI_MNum"] != DBNull.Value) wH_IOItem.WHIOI_MNum = Convert.ToDecimal(dr["WHIOI_MNum"]);
            if (dr["WHIOI_MPrice"] != DBNull.Value) wH_IOItem.WHIOI_MPrice = Convert.ToDecimal(dr["WHIOI_MPrice"]);
            if (dr["WHIOI_Company"] != DBNull.Value) wH_IOItem.WHIOI_Company = Convert.ToString(dr["WHIOI_Company"]);
            if (dr["WHIOI_Department"] != DBNull.Value) wH_IOItem.WHIOI_Department = Convert.ToString(dr["WHIOI_Department"]);
            if (dr["WHIOI_UType"] != DBNull.Value) wH_IOItem.WHIOI_UType = Convert.ToString(dr["WHIOI_UType"]);
            if (dr["WHIOI_UOwner"] != DBNull.Value) wH_IOItem.WHIOI_UOwner = Convert.ToString(dr["WHIOI_UOwner"]);
            if (dr["WHIOI_UOwnerCode"] != DBNull.Value) wH_IOItem.WHIOI_UOwnerCode = Convert.ToString(dr["WHIOI_UOwnerCode"]);
            if (dr["WHIOI_Date"] != DBNull.Value) wH_IOItem.WHIOI_Date = Convert.ToDateTime(dr["WHIOI_Date"]);
            if (dr["Stat"] != DBNull.Value) wH_IOItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_IOItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_IOItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_IOItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHIOM_Code"] != DBNull.Value) wH_IOItem.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
            if (dr["WHIOI_RefWName"] != DBNull.Value) wH_IOItem.WHIOI_RefWName = Convert.ToString(dr["WHIOI_RefWName"]);
            if (dr["WHIOI_RefWCode"] != DBNull.Value) wH_IOItem.WHIOI_RefWCode = Convert.ToString(dr["WHIOI_RefWCode"]);
            if (dr["WHIOI_RefWNo"] != DBNull.Value) wH_IOItem.WHIOI_RefWNo = Convert.ToString(dr["WHIOI_RefWNo"]);
            if (dr["WHIOI_RefWNoName"] != DBNull.Value) wH_IOItem.WHIOI_RefWNoName = Convert.ToString(dr["WHIOI_RefWNoName"]);
            if (dr["WHIOI_Udef1"] != DBNull.Value) wH_IOItem.WHIOI_Udef1 = Convert.ToString(dr["WHIOI_Udef1"]);
            if (dr["WHIOI_Udef2"] != DBNull.Value) wH_IOItem.WHIOI_Udef2 = Convert.ToString(dr["WHIOI_Udef2"]);
            if (dr["WHIOI_Udef3"] != DBNull.Value) wH_IOItem.WHIOI_Udef3 = Convert.ToString(dr["WHIOI_Udef3"]);
            if (dr["WHIOI_Udef4"] != DBNull.Value) wH_IOItem.WHIOI_Udef4 = Convert.ToString(dr["WHIOI_Udef4"]);
            if (dr["WHIOI_Udef5"] != DBNull.Value) wH_IOItem.WHIOI_Udef5 = Convert.ToString(dr["WHIOI_Udef5"]);
            if (dr["WHIOI_CCompany"] != DBNull.Value) wH_IOItem.WHIOI_CCompany = Convert.ToString(dr["WHIOI_CCompany"]);
            if (dr["WHIOI_CCompanyCode"] != DBNull.Value) wH_IOItem.WHIOI_CCompanyCode = Convert.ToString(dr["WHIOI_CCompanyCode"]);
            if (dr["WHIOI_CDept"] != DBNull.Value) wH_IOItem.WHIOI_CDept = Convert.ToString(dr["WHIOI_CDept"]);
            if (dr["WHIOI_CDeptCode"] != DBNull.Value) wH_IOItem.WHIOI_CDeptCode = Convert.ToString(dr["WHIOI_CDeptCode"]);
            if (dr["WHIOI_UDEF6"] != DBNull.Value) wH_IOItem.WHIOI_UDEF6 = Convert.ToString(dr["WHIOI_UDEF6"]);
            if (dr["WHIOI_UDEF7"] != DBNull.Value) wH_IOItem.WHIOI_UDEF7 = Convert.ToString(dr["WHIOI_UDEF7"]);
            if (dr["WHIOI_UDEF8"] != DBNull.Value) wH_IOItem.WHIOI_UDEF8 = Convert.ToString(dr["WHIOI_UDEF8"]);
            if (dr["WHIOI_UDEF9"] != DBNull.Value) wH_IOItem.WHIOI_UDEF9 = Convert.ToString(dr["WHIOI_UDEF9"]);
            if (dr["WHIOI_UDEF10"] != DBNull.Value) wH_IOItem.WHIOI_UDEF10 = Convert.ToString(dr["WHIOI_UDEF10"]);
            if (dr["WHIOI_Num1"] != DBNull.Value) wH_IOItem.WHIOI_Num1 = Convert.ToDecimal(dr["WHIOI_Num1"]);
            if (dr["WHIOI_Num2"] != DBNull.Value) wH_IOItem.WHIOI_Num2 = Convert.ToDecimal(dr["WHIOI_Num2"]);
            if (dr["WHIOI_Num3"] != DBNull.Value) wH_IOItem.WHIOI_Num3 = Convert.ToDecimal(dr["WHIOI_Num3"]);
            if (dr["WHIOI_Num4"] != DBNull.Value) wH_IOItem.WHIOI_Num4 = Convert.ToDecimal(dr["WHIOI_Num4"]);
            if (dr["WHIOI_Num5"] != DBNull.Value) wH_IOItem.WHIOI_Num5 = Convert.ToDecimal(dr["WHIOI_Num5"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_IOItem;
      }
      /// <summary>
      /// 获取指定的物料出库细表 WH_IOItem对象集合
      /// </summary>
      public List<WH_IOItem> GetListByWhere(string strCondition)
      {
         List<WH_IOItem> ret = new List<WH_IOItem>();
         string sql = "SELECT  WHIOI_ID,WHIOI_Code,WHIOI_MainCode,WHIOI_MCode,WHIOI_MName,WHIOI_MSpec,WHIOI_MUnit,WHIOI_MNum,WHIOI_MPrice,WHIOI_Company,WHIOI_Department,WHIOI_UType,WHIOI_UOwner,WHIOI_UOwnerCode,WHIOI_Date,Stat,CreateDate,UpdateDate,DeleteDate,WHIOM_Code,WHIOI_RefWName,WHIOI_RefWCode,WHIOI_RefWNo,WHIOI_RefWNoName,WHIOI_Udef1,WHIOI_Udef2,WHIOI_Udef3,WHIOI_Udef4,WHIOI_Udef5,WHIOI_CCompany,WHIOI_CCompanyCode,WHIOI_CDept,WHIOI_CDeptCode,WHIOI_UDEF6,WHIOI_UDEF7,WHIOI_UDEF8,WHIOI_UDEF9,WHIOI_UDEF10,WHIOI_Num1,WHIOI_Num2,WHIOI_Num3,WHIOI_Num4,WHIOI_Num5 FROM WH_IOItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_IOItem wH_IOItem = new WH_IOItem();
            if (dr["WHIOI_ID"] != DBNull.Value) wH_IOItem.WHIOI_ID = Convert.ToDecimal(dr["WHIOI_ID"]);
            if (dr["WHIOI_Code"] != DBNull.Value) wH_IOItem.WHIOI_Code = Convert.ToString(dr["WHIOI_Code"]);
            if (dr["WHIOI_MainCode"] != DBNull.Value) wH_IOItem.WHIOI_MainCode = Convert.ToString(dr["WHIOI_MainCode"]);
            if (dr["WHIOI_MCode"] != DBNull.Value) wH_IOItem.WHIOI_MCode = Convert.ToString(dr["WHIOI_MCode"]);
            if (dr["WHIOI_MName"] != DBNull.Value) wH_IOItem.WHIOI_MName = Convert.ToString(dr["WHIOI_MName"]);
            if (dr["WHIOI_MSpec"] != DBNull.Value) wH_IOItem.WHIOI_MSpec = Convert.ToString(dr["WHIOI_MSpec"]);
            if (dr["WHIOI_MUnit"] != DBNull.Value) wH_IOItem.WHIOI_MUnit = Convert.ToString(dr["WHIOI_MUnit"]);
            if (dr["WHIOI_MNum"] != DBNull.Value) wH_IOItem.WHIOI_MNum = Convert.ToDecimal(dr["WHIOI_MNum"]);
            if (dr["WHIOI_MPrice"] != DBNull.Value) wH_IOItem.WHIOI_MPrice = Convert.ToDecimal(dr["WHIOI_MPrice"]);
            if (dr["WHIOI_Company"] != DBNull.Value) wH_IOItem.WHIOI_Company = Convert.ToString(dr["WHIOI_Company"]);
            if (dr["WHIOI_Department"] != DBNull.Value) wH_IOItem.WHIOI_Department = Convert.ToString(dr["WHIOI_Department"]);
            if (dr["WHIOI_UType"] != DBNull.Value) wH_IOItem.WHIOI_UType = Convert.ToString(dr["WHIOI_UType"]);
            if (dr["WHIOI_UOwner"] != DBNull.Value) wH_IOItem.WHIOI_UOwner = Convert.ToString(dr["WHIOI_UOwner"]);
            if (dr["WHIOI_UOwnerCode"] != DBNull.Value) wH_IOItem.WHIOI_UOwnerCode = Convert.ToString(dr["WHIOI_UOwnerCode"]);
            if (dr["WHIOI_Date"] != DBNull.Value) wH_IOItem.WHIOI_Date = Convert.ToDateTime(dr["WHIOI_Date"]);
            if (dr["Stat"] != DBNull.Value) wH_IOItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_IOItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_IOItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_IOItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHIOM_Code"] != DBNull.Value) wH_IOItem.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
            if (dr["WHIOI_RefWName"] != DBNull.Value) wH_IOItem.WHIOI_RefWName = Convert.ToString(dr["WHIOI_RefWName"]);
            if (dr["WHIOI_RefWCode"] != DBNull.Value) wH_IOItem.WHIOI_RefWCode = Convert.ToString(dr["WHIOI_RefWCode"]);
            if (dr["WHIOI_RefWNo"] != DBNull.Value) wH_IOItem.WHIOI_RefWNo = Convert.ToString(dr["WHIOI_RefWNo"]);
            if (dr["WHIOI_RefWNoName"] != DBNull.Value) wH_IOItem.WHIOI_RefWNoName = Convert.ToString(dr["WHIOI_RefWNoName"]);
            if (dr["WHIOI_Udef1"] != DBNull.Value) wH_IOItem.WHIOI_Udef1 = Convert.ToString(dr["WHIOI_Udef1"]);
            if (dr["WHIOI_Udef2"] != DBNull.Value) wH_IOItem.WHIOI_Udef2 = Convert.ToString(dr["WHIOI_Udef2"]);
            if (dr["WHIOI_Udef3"] != DBNull.Value) wH_IOItem.WHIOI_Udef3 = Convert.ToString(dr["WHIOI_Udef3"]);
            if (dr["WHIOI_Udef4"] != DBNull.Value) wH_IOItem.WHIOI_Udef4 = Convert.ToString(dr["WHIOI_Udef4"]);
            if (dr["WHIOI_Udef5"] != DBNull.Value) wH_IOItem.WHIOI_Udef5 = Convert.ToString(dr["WHIOI_Udef5"]);
            if (dr["WHIOI_CCompany"] != DBNull.Value) wH_IOItem.WHIOI_CCompany = Convert.ToString(dr["WHIOI_CCompany"]);
            if (dr["WHIOI_CCompanyCode"] != DBNull.Value) wH_IOItem.WHIOI_CCompanyCode = Convert.ToString(dr["WHIOI_CCompanyCode"]);
            if (dr["WHIOI_CDept"] != DBNull.Value) wH_IOItem.WHIOI_CDept = Convert.ToString(dr["WHIOI_CDept"]);
            if (dr["WHIOI_CDeptCode"] != DBNull.Value) wH_IOItem.WHIOI_CDeptCode = Convert.ToString(dr["WHIOI_CDeptCode"]);
            if (dr["WHIOI_UDEF6"] != DBNull.Value) wH_IOItem.WHIOI_UDEF6 = Convert.ToString(dr["WHIOI_UDEF6"]);
            if (dr["WHIOI_UDEF7"] != DBNull.Value) wH_IOItem.WHIOI_UDEF7 = Convert.ToString(dr["WHIOI_UDEF7"]);
            if (dr["WHIOI_UDEF8"] != DBNull.Value) wH_IOItem.WHIOI_UDEF8 = Convert.ToString(dr["WHIOI_UDEF8"]);
            if (dr["WHIOI_UDEF9"] != DBNull.Value) wH_IOItem.WHIOI_UDEF9 = Convert.ToString(dr["WHIOI_UDEF9"]);
            if (dr["WHIOI_UDEF10"] != DBNull.Value) wH_IOItem.WHIOI_UDEF10 = Convert.ToString(dr["WHIOI_UDEF10"]);
            if (dr["WHIOI_Num1"] != DBNull.Value) wH_IOItem.WHIOI_Num1 = Convert.ToDecimal(dr["WHIOI_Num1"]);
            if (dr["WHIOI_Num2"] != DBNull.Value) wH_IOItem.WHIOI_Num2 = Convert.ToDecimal(dr["WHIOI_Num2"]);
            if (dr["WHIOI_Num3"] != DBNull.Value) wH_IOItem.WHIOI_Num3 = Convert.ToDecimal(dr["WHIOI_Num3"]);
            if (dr["WHIOI_Num4"] != DBNull.Value) wH_IOItem.WHIOI_Num4 = Convert.ToDecimal(dr["WHIOI_Num4"]);
            if (dr["WHIOI_Num5"] != DBNull.Value) wH_IOItem.WHIOI_Num5 = Convert.ToDecimal(dr["WHIOI_Num5"]);
            ret.Add(wH_IOItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的物料出库细表 WH_IOItem对象(即:一条记录
      /// </summary>
      public List<WH_IOItem> GetAll()
      {
         List<WH_IOItem> ret = new List<WH_IOItem>();
         string sql = "SELECT  WHIOI_ID,WHIOI_Code,WHIOI_MainCode,WHIOI_MCode,WHIOI_MName,WHIOI_MSpec,WHIOI_MUnit,WHIOI_MNum,WHIOI_MPrice,WHIOI_Company,WHIOI_Department,WHIOI_UType,WHIOI_UOwner,WHIOI_UOwnerCode,WHIOI_Date,Stat,CreateDate,UpdateDate,DeleteDate,WHIOM_Code,WHIOI_RefWName,WHIOI_RefWCode,WHIOI_RefWNo,WHIOI_RefWNoName,WHIOI_Udef1,WHIOI_Udef2,WHIOI_Udef3,WHIOI_Udef4,WHIOI_Udef5,WHIOI_CCompany,WHIOI_CCompanyCode,WHIOI_CDept,WHIOI_CDeptCode,WHIOI_UDEF6,WHIOI_UDEF7,WHIOI_UDEF8,WHIOI_UDEF9,WHIOI_UDEF10,WHIOI_Num1,WHIOI_Num2,WHIOI_Num3,WHIOI_Num4,WHIOI_Num5 FROM WH_IOItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHIOI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_IOItem wH_IOItem = new WH_IOItem();
            if (dr["WHIOI_ID"] != DBNull.Value) wH_IOItem.WHIOI_ID = Convert.ToDecimal(dr["WHIOI_ID"]);
            if (dr["WHIOI_Code"] != DBNull.Value) wH_IOItem.WHIOI_Code = Convert.ToString(dr["WHIOI_Code"]);
            if (dr["WHIOI_MainCode"] != DBNull.Value) wH_IOItem.WHIOI_MainCode = Convert.ToString(dr["WHIOI_MainCode"]);
            if (dr["WHIOI_MCode"] != DBNull.Value) wH_IOItem.WHIOI_MCode = Convert.ToString(dr["WHIOI_MCode"]);
            if (dr["WHIOI_MName"] != DBNull.Value) wH_IOItem.WHIOI_MName = Convert.ToString(dr["WHIOI_MName"]);
            if (dr["WHIOI_MSpec"] != DBNull.Value) wH_IOItem.WHIOI_MSpec = Convert.ToString(dr["WHIOI_MSpec"]);
            if (dr["WHIOI_MUnit"] != DBNull.Value) wH_IOItem.WHIOI_MUnit = Convert.ToString(dr["WHIOI_MUnit"]);
            if (dr["WHIOI_MNum"] != DBNull.Value) wH_IOItem.WHIOI_MNum = Convert.ToDecimal(dr["WHIOI_MNum"]);
            if (dr["WHIOI_MPrice"] != DBNull.Value) wH_IOItem.WHIOI_MPrice = Convert.ToDecimal(dr["WHIOI_MPrice"]);
            if (dr["WHIOI_Company"] != DBNull.Value) wH_IOItem.WHIOI_Company = Convert.ToString(dr["WHIOI_Company"]);
            if (dr["WHIOI_Department"] != DBNull.Value) wH_IOItem.WHIOI_Department = Convert.ToString(dr["WHIOI_Department"]);
            if (dr["WHIOI_UType"] != DBNull.Value) wH_IOItem.WHIOI_UType = Convert.ToString(dr["WHIOI_UType"]);
            if (dr["WHIOI_UOwner"] != DBNull.Value) wH_IOItem.WHIOI_UOwner = Convert.ToString(dr["WHIOI_UOwner"]);
            if (dr["WHIOI_UOwnerCode"] != DBNull.Value) wH_IOItem.WHIOI_UOwnerCode = Convert.ToString(dr["WHIOI_UOwnerCode"]);
            if (dr["WHIOI_Date"] != DBNull.Value) wH_IOItem.WHIOI_Date = Convert.ToDateTime(dr["WHIOI_Date"]);
            if (dr["Stat"] != DBNull.Value) wH_IOItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_IOItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_IOItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_IOItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHIOM_Code"] != DBNull.Value) wH_IOItem.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
            if (dr["WHIOI_RefWName"] != DBNull.Value) wH_IOItem.WHIOI_RefWName = Convert.ToString(dr["WHIOI_RefWName"]);
            if (dr["WHIOI_RefWCode"] != DBNull.Value) wH_IOItem.WHIOI_RefWCode = Convert.ToString(dr["WHIOI_RefWCode"]);
            if (dr["WHIOI_RefWNo"] != DBNull.Value) wH_IOItem.WHIOI_RefWNo = Convert.ToString(dr["WHIOI_RefWNo"]);
            if (dr["WHIOI_RefWNoName"] != DBNull.Value) wH_IOItem.WHIOI_RefWNoName = Convert.ToString(dr["WHIOI_RefWNoName"]);
            if (dr["WHIOI_Udef1"] != DBNull.Value) wH_IOItem.WHIOI_Udef1 = Convert.ToString(dr["WHIOI_Udef1"]);
            if (dr["WHIOI_Udef2"] != DBNull.Value) wH_IOItem.WHIOI_Udef2 = Convert.ToString(dr["WHIOI_Udef2"]);
            if (dr["WHIOI_Udef3"] != DBNull.Value) wH_IOItem.WHIOI_Udef3 = Convert.ToString(dr["WHIOI_Udef3"]);
            if (dr["WHIOI_Udef4"] != DBNull.Value) wH_IOItem.WHIOI_Udef4 = Convert.ToString(dr["WHIOI_Udef4"]);
            if (dr["WHIOI_Udef5"] != DBNull.Value) wH_IOItem.WHIOI_Udef5 = Convert.ToString(dr["WHIOI_Udef5"]);
            if (dr["WHIOI_CCompany"] != DBNull.Value) wH_IOItem.WHIOI_CCompany = Convert.ToString(dr["WHIOI_CCompany"]);
            if (dr["WHIOI_CCompanyCode"] != DBNull.Value) wH_IOItem.WHIOI_CCompanyCode = Convert.ToString(dr["WHIOI_CCompanyCode"]);
            if (dr["WHIOI_CDept"] != DBNull.Value) wH_IOItem.WHIOI_CDept = Convert.ToString(dr["WHIOI_CDept"]);
            if (dr["WHIOI_CDeptCode"] != DBNull.Value) wH_IOItem.WHIOI_CDeptCode = Convert.ToString(dr["WHIOI_CDeptCode"]);
            if (dr["WHIOI_UDEF6"] != DBNull.Value) wH_IOItem.WHIOI_UDEF6 = Convert.ToString(dr["WHIOI_UDEF6"]);
            if (dr["WHIOI_UDEF7"] != DBNull.Value) wH_IOItem.WHIOI_UDEF7 = Convert.ToString(dr["WHIOI_UDEF7"]);
            if (dr["WHIOI_UDEF8"] != DBNull.Value) wH_IOItem.WHIOI_UDEF8 = Convert.ToString(dr["WHIOI_UDEF8"]);
            if (dr["WHIOI_UDEF9"] != DBNull.Value) wH_IOItem.WHIOI_UDEF9 = Convert.ToString(dr["WHIOI_UDEF9"]);
            if (dr["WHIOI_UDEF10"] != DBNull.Value) wH_IOItem.WHIOI_UDEF10 = Convert.ToString(dr["WHIOI_UDEF10"]);
            if (dr["WHIOI_Num1"] != DBNull.Value) wH_IOItem.WHIOI_Num1 = Convert.ToDecimal(dr["WHIOI_Num1"]);
            if (dr["WHIOI_Num2"] != DBNull.Value) wH_IOItem.WHIOI_Num2 = Convert.ToDecimal(dr["WHIOI_Num2"]);
            if (dr["WHIOI_Num3"] != DBNull.Value) wH_IOItem.WHIOI_Num3 = Convert.ToDecimal(dr["WHIOI_Num3"]);
            if (dr["WHIOI_Num4"] != DBNull.Value) wH_IOItem.WHIOI_Num4 = Convert.ToDecimal(dr["WHIOI_Num4"]);
            if (dr["WHIOI_Num5"] != DBNull.Value) wH_IOItem.WHIOI_Num5 = Convert.ToDecimal(dr["WHIOI_Num5"]);
            ret.Add(wH_IOItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
