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
   /// 供应商往来细表
   /// </summary>
   [Serializable]
   public partial class ADOPU_Detail
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加供应商往来细表 PU_Detail对象(即:一条记录)
      /// </summary>
      public int Add(PU_Detail pU_Detail)
      {
         string sql = "INSERT INTO PU_Detail (PUD_Code,PUD_MCode,PUD_MName,PUD_Spec,PUD_Unit,PUD_Price,PUD_Num,PUD_Bak,PUD_RType,PUD_RCode,PUD_RefWCode,PUD_RefWNo,PUD_RefWName,PUD_Tranfee,Stat,CreateDate,UpdateDate,DeleteDate,PUD_DNum,PUD_DStatus,PUD_RefWNoName,PUD_Udef1,PUD_Udef2,PUD_Udef3,PUD_Udef4,PUD_Udef5,PUD_Udef6,PUD_Udef7,PUD_Udef8,PUD_Udef9,PUD_Udef10,PUD_CCompany,PUD_CCompanyCode,PUD_Dept,PUD_DeptCode,PUD_RDate,PUD_SupCode,PUD_SupName,PUD_Num1,PUD_Num2,PUD_Num3,PUD_Num4,PUD_Num5,PUD_RevNum,PUD_UEqu,PUD_UsetType,PUD_RevCount) VALUES (@PUD_Code,@PUD_MCode,@PUD_MName,@PUD_Spec,@PUD_Unit,@PUD_Price,@PUD_Num,@PUD_Bak,@PUD_RType,@PUD_RCode,@PUD_RefWCode,@PUD_RefWNo,@PUD_RefWName,@PUD_Tranfee,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PUD_DNum,@PUD_DStatus,@PUD_RefWNoName,@PUD_Udef1,@PUD_Udef2,@PUD_Udef3,@PUD_Udef4,@PUD_Udef5,@PUD_Udef6,@PUD_Udef7,@PUD_Udef8,@PUD_Udef9,@PUD_Udef10,@PUD_CCompany,@PUD_CCompanyCode,@PUD_Dept,@PUD_DeptCode,@PUD_RDate,@PUD_SupCode,@PUD_SupName,@PUD_Num1,@PUD_Num2,@PUD_Num3,@PUD_Num4,@PUD_Num5,@PUD_RevNum,@PUD_UEqu,@PUD_UsetType,@PUD_RevCount)";
         if (string.IsNullOrEmpty(pU_Detail.PUD_Code))
         {
            idb.AddParameter("@PUD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Code", pU_Detail.PUD_Code);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_MCode))
         {
            idb.AddParameter("@PUD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_MCode", pU_Detail.PUD_MCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_MName))
         {
            idb.AddParameter("@PUD_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_MName", pU_Detail.PUD_MName);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Spec))
         {
            idb.AddParameter("@PUD_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Spec", pU_Detail.PUD_Spec);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Unit))
         {
            idb.AddParameter("@PUD_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Unit", pU_Detail.PUD_Unit);
         }
         if (pU_Detail.PUD_Price == 0)
         {
            idb.AddParameter("@PUD_Price", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Price", pU_Detail.PUD_Price);
         }
         if (pU_Detail.PUD_Num == 0)
         {
            idb.AddParameter("@PUD_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num", pU_Detail.PUD_Num);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Bak))
         {
            idb.AddParameter("@PUD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Bak", pU_Detail.PUD_Bak);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RType))
         {
            idb.AddParameter("@PUD_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RType", pU_Detail.PUD_RType);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RCode))
         {
            idb.AddParameter("@PUD_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RCode", pU_Detail.PUD_RCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWCode))
         {
            idb.AddParameter("@PUD_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWCode", pU_Detail.PUD_RefWCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWNo))
         {
            idb.AddParameter("@PUD_RefWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWNo", pU_Detail.PUD_RefWNo);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWName))
         {
            idb.AddParameter("@PUD_RefWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWName", pU_Detail.PUD_RefWName);
         }
         if (pU_Detail.PUD_Tranfee == 0)
         {
            idb.AddParameter("@PUD_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Tranfee", pU_Detail.PUD_Tranfee);
         }
         if (pU_Detail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Detail.Stat);
         }
         if (pU_Detail.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_Detail.CreateDate);
         }
         if (pU_Detail.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_Detail.UpdateDate);
         }
         if (pU_Detail.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_Detail.DeleteDate);
         }
         if (pU_Detail.PUD_DNum == 0)
         {
            idb.AddParameter("@PUD_DNum", 0);
         }
         else
         {
            idb.AddParameter("@PUD_DNum", pU_Detail.PUD_DNum);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_DStatus))
         {
            idb.AddParameter("@PUD_DStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_DStatus", pU_Detail.PUD_DStatus);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWNoName))
         {
            idb.AddParameter("@PUD_RefWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWNoName", pU_Detail.PUD_RefWNoName);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef1))
         {
            idb.AddParameter("@PUD_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef1", pU_Detail.PUD_Udef1);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef2))
         {
            idb.AddParameter("@PUD_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef2", pU_Detail.PUD_Udef2);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef3))
         {
            idb.AddParameter("@PUD_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef3", pU_Detail.PUD_Udef3);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef4))
         {
            idb.AddParameter("@PUD_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef4", pU_Detail.PUD_Udef4);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef5))
         {
            idb.AddParameter("@PUD_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef5", pU_Detail.PUD_Udef5);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef6))
         {
            idb.AddParameter("@PUD_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef6", pU_Detail.PUD_Udef6);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef7))
         {
            idb.AddParameter("@PUD_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef7", pU_Detail.PUD_Udef7);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef8))
         {
            idb.AddParameter("@PUD_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef8", pU_Detail.PUD_Udef8);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef9))
         {
            idb.AddParameter("@PUD_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef9", pU_Detail.PUD_Udef9);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef10))
         {
            idb.AddParameter("@PUD_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef10", pU_Detail.PUD_Udef10);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_CCompany))
         {
            idb.AddParameter("@PUD_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_CCompany", pU_Detail.PUD_CCompany);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_CCompanyCode))
         {
            idb.AddParameter("@PUD_CCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_CCompanyCode", pU_Detail.PUD_CCompanyCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Dept))
         {
            idb.AddParameter("@PUD_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Dept", pU_Detail.PUD_Dept);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_DeptCode))
         {
            idb.AddParameter("@PUD_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_DeptCode", pU_Detail.PUD_DeptCode);
         }
         if (pU_Detail.PUD_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUD_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RDate", pU_Detail.PUD_RDate);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_SupCode))
         {
            idb.AddParameter("@PUD_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_SupCode", pU_Detail.PUD_SupCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_SupName))
         {
            idb.AddParameter("@PUD_SupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_SupName", pU_Detail.PUD_SupName);
         }
         if (pU_Detail.PUD_Num1 == 0)
         {
            idb.AddParameter("@PUD_Num1", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num1", pU_Detail.PUD_Num1);
         }
         if (pU_Detail.PUD_Num2 == 0)
         {
            idb.AddParameter("@PUD_Num2", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num2", pU_Detail.PUD_Num2);
         }
         if (pU_Detail.PUD_Num3 == 0)
         {
            idb.AddParameter("@PUD_Num3", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num3", pU_Detail.PUD_Num3);
         }
         if (pU_Detail.PUD_Num4 == 0)
         {
            idb.AddParameter("@PUD_Num4", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num4", pU_Detail.PUD_Num4);
         }
         if (pU_Detail.PUD_Num5 == 0)
         {
            idb.AddParameter("@PUD_Num5", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num5", pU_Detail.PUD_Num5);
         }
         if (pU_Detail.PUD_RevNum == 0)
         {
            idb.AddParameter("@PUD_RevNum", 0);
         }
         else
         {
            idb.AddParameter("@PUD_RevNum", pU_Detail.PUD_RevNum);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_UEqu))
         {
            idb.AddParameter("@PUD_UEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_UEqu", pU_Detail.PUD_UEqu);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_UsetType))
         {
            idb.AddParameter("@PUD_UsetType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_UsetType", pU_Detail.PUD_UsetType);
         }
         if (pU_Detail.PUD_RevCount == 0)
         {
            idb.AddParameter("@PUD_RevCount", 0);
         }
         else
         {
            idb.AddParameter("@PUD_RevCount", pU_Detail.PUD_RevCount);
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
      /// 添加供应商往来细表 PU_Detail对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PU_Detail pU_Detail)
      {
         string sql = "INSERT INTO PU_Detail (PUD_Code,PUD_MCode,PUD_MName,PUD_Spec,PUD_Unit,PUD_Price,PUD_Num,PUD_Bak,PUD_RType,PUD_RCode,PUD_RefWCode,PUD_RefWNo,PUD_RefWName,PUD_Tranfee,Stat,CreateDate,UpdateDate,DeleteDate,PUD_DNum,PUD_DStatus,PUD_RefWNoName,PUD_Udef1,PUD_Udef2,PUD_Udef3,PUD_Udef4,PUD_Udef5,PUD_Udef6,PUD_Udef7,PUD_Udef8,PUD_Udef9,PUD_Udef10,PUD_CCompany,PUD_CCompanyCode,PUD_Dept,PUD_DeptCode,PUD_RDate,PUD_SupCode,PUD_SupName,PUD_Num1,PUD_Num2,PUD_Num3,PUD_Num4,PUD_Num5,PUD_RevNum,PUD_UEqu,PUD_UsetType,PUD_RevCount) VALUES (@PUD_Code,@PUD_MCode,@PUD_MName,@PUD_Spec,@PUD_Unit,@PUD_Price,@PUD_Num,@PUD_Bak,@PUD_RType,@PUD_RCode,@PUD_RefWCode,@PUD_RefWNo,@PUD_RefWName,@PUD_Tranfee,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PUD_DNum,@PUD_DStatus,@PUD_RefWNoName,@PUD_Udef1,@PUD_Udef2,@PUD_Udef3,@PUD_Udef4,@PUD_Udef5,@PUD_Udef6,@PUD_Udef7,@PUD_Udef8,@PUD_Udef9,@PUD_Udef10,@PUD_CCompany,@PUD_CCompanyCode,@PUD_Dept,@PUD_DeptCode,@PUD_RDate,@PUD_SupCode,@PUD_SupName,@PUD_Num1,@PUD_Num2,@PUD_Num3,@PUD_Num4,@PUD_Num5,@PUD_RevNum,@PUD_UEqu,@PUD_UsetType,@PUD_RevCount);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pU_Detail.PUD_Code))
         {
            idb.AddParameter("@PUD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Code", pU_Detail.PUD_Code);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_MCode))
         {
            idb.AddParameter("@PUD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_MCode", pU_Detail.PUD_MCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_MName))
         {
            idb.AddParameter("@PUD_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_MName", pU_Detail.PUD_MName);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Spec))
         {
            idb.AddParameter("@PUD_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Spec", pU_Detail.PUD_Spec);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Unit))
         {
            idb.AddParameter("@PUD_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Unit", pU_Detail.PUD_Unit);
         }
         if (pU_Detail.PUD_Price == 0)
         {
            idb.AddParameter("@PUD_Price", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Price", pU_Detail.PUD_Price);
         }
         if (pU_Detail.PUD_Num == 0)
         {
            idb.AddParameter("@PUD_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num", pU_Detail.PUD_Num);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Bak))
         {
            idb.AddParameter("@PUD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Bak", pU_Detail.PUD_Bak);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RType))
         {
            idb.AddParameter("@PUD_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RType", pU_Detail.PUD_RType);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RCode))
         {
            idb.AddParameter("@PUD_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RCode", pU_Detail.PUD_RCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWCode))
         {
            idb.AddParameter("@PUD_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWCode", pU_Detail.PUD_RefWCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWNo))
         {
            idb.AddParameter("@PUD_RefWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWNo", pU_Detail.PUD_RefWNo);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWName))
         {
            idb.AddParameter("@PUD_RefWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWName", pU_Detail.PUD_RefWName);
         }
         if (pU_Detail.PUD_Tranfee == 0)
         {
            idb.AddParameter("@PUD_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Tranfee", pU_Detail.PUD_Tranfee);
         }
         if (pU_Detail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Detail.Stat);
         }
         if (pU_Detail.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_Detail.CreateDate);
         }
         if (pU_Detail.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_Detail.UpdateDate);
         }
         if (pU_Detail.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_Detail.DeleteDate);
         }
         if (pU_Detail.PUD_DNum == 0)
         {
            idb.AddParameter("@PUD_DNum", 0);
         }
         else
         {
            idb.AddParameter("@PUD_DNum", pU_Detail.PUD_DNum);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_DStatus))
         {
            idb.AddParameter("@PUD_DStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_DStatus", pU_Detail.PUD_DStatus);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWNoName))
         {
            idb.AddParameter("@PUD_RefWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWNoName", pU_Detail.PUD_RefWNoName);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef1))
         {
            idb.AddParameter("@PUD_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef1", pU_Detail.PUD_Udef1);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef2))
         {
            idb.AddParameter("@PUD_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef2", pU_Detail.PUD_Udef2);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef3))
         {
            idb.AddParameter("@PUD_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef3", pU_Detail.PUD_Udef3);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef4))
         {
            idb.AddParameter("@PUD_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef4", pU_Detail.PUD_Udef4);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef5))
         {
            idb.AddParameter("@PUD_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef5", pU_Detail.PUD_Udef5);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef6))
         {
            idb.AddParameter("@PUD_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef6", pU_Detail.PUD_Udef6);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef7))
         {
            idb.AddParameter("@PUD_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef7", pU_Detail.PUD_Udef7);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef8))
         {
            idb.AddParameter("@PUD_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef8", pU_Detail.PUD_Udef8);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef9))
         {
            idb.AddParameter("@PUD_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef9", pU_Detail.PUD_Udef9);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef10))
         {
            idb.AddParameter("@PUD_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef10", pU_Detail.PUD_Udef10);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_CCompany))
         {
            idb.AddParameter("@PUD_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_CCompany", pU_Detail.PUD_CCompany);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_CCompanyCode))
         {
            idb.AddParameter("@PUD_CCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_CCompanyCode", pU_Detail.PUD_CCompanyCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_Dept))
         {
            idb.AddParameter("@PUD_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Dept", pU_Detail.PUD_Dept);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_DeptCode))
         {
            idb.AddParameter("@PUD_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_DeptCode", pU_Detail.PUD_DeptCode);
         }
         if (pU_Detail.PUD_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUD_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RDate", pU_Detail.PUD_RDate);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_SupCode))
         {
            idb.AddParameter("@PUD_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_SupCode", pU_Detail.PUD_SupCode);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_SupName))
         {
            idb.AddParameter("@PUD_SupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_SupName", pU_Detail.PUD_SupName);
         }
         if (pU_Detail.PUD_Num1 == 0)
         {
            idb.AddParameter("@PUD_Num1", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num1", pU_Detail.PUD_Num1);
         }
         if (pU_Detail.PUD_Num2 == 0)
         {
            idb.AddParameter("@PUD_Num2", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num2", pU_Detail.PUD_Num2);
         }
         if (pU_Detail.PUD_Num3 == 0)
         {
            idb.AddParameter("@PUD_Num3", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num3", pU_Detail.PUD_Num3);
         }
         if (pU_Detail.PUD_Num4 == 0)
         {
            idb.AddParameter("@PUD_Num4", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num4", pU_Detail.PUD_Num4);
         }
         if (pU_Detail.PUD_Num5 == 0)
         {
            idb.AddParameter("@PUD_Num5", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num5", pU_Detail.PUD_Num5);
         }
         if (pU_Detail.PUD_RevNum == 0)
         {
            idb.AddParameter("@PUD_RevNum", 0);
         }
         else
         {
            idb.AddParameter("@PUD_RevNum", pU_Detail.PUD_RevNum);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_UEqu))
         {
            idb.AddParameter("@PUD_UEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_UEqu", pU_Detail.PUD_UEqu);
         }
         if (string.IsNullOrEmpty(pU_Detail.PUD_UsetType))
         {
            idb.AddParameter("@PUD_UsetType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_UsetType", pU_Detail.PUD_UsetType);
         }
         if (pU_Detail.PUD_RevCount == 0)
         {
            idb.AddParameter("@PUD_RevCount", 0);
         }
         else
         {
            idb.AddParameter("@PUD_RevCount", pU_Detail.PUD_RevCount);
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
      /// 更新供应商往来细表 PU_Detail对象(即:一条记录
      /// </summary>
      public int Update(PU_Detail pU_Detail)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PU_Detail       SET ");
            if(pU_Detail.PUD_Code_IsChanged){sbParameter.Append("PUD_Code=@PUD_Code, ");}
      if(pU_Detail.PUD_MCode_IsChanged){sbParameter.Append("PUD_MCode=@PUD_MCode, ");}
      if(pU_Detail.PUD_MName_IsChanged){sbParameter.Append("PUD_MName=@PUD_MName, ");}
      if(pU_Detail.PUD_Spec_IsChanged){sbParameter.Append("PUD_Spec=@PUD_Spec, ");}
      if(pU_Detail.PUD_Unit_IsChanged){sbParameter.Append("PUD_Unit=@PUD_Unit, ");}
      if(pU_Detail.PUD_Price_IsChanged){sbParameter.Append("PUD_Price=@PUD_Price, ");}
      if(pU_Detail.PUD_Num_IsChanged){sbParameter.Append("PUD_Num=@PUD_Num, ");}
      if(pU_Detail.PUD_Bak_IsChanged){sbParameter.Append("PUD_Bak=@PUD_Bak, ");}
      if(pU_Detail.PUD_RType_IsChanged){sbParameter.Append("PUD_RType=@PUD_RType, ");}
      if(pU_Detail.PUD_RCode_IsChanged){sbParameter.Append("PUD_RCode=@PUD_RCode, ");}
      if(pU_Detail.PUD_RefWCode_IsChanged){sbParameter.Append("PUD_RefWCode=@PUD_RefWCode, ");}
      if(pU_Detail.PUD_RefWNo_IsChanged){sbParameter.Append("PUD_RefWNo=@PUD_RefWNo, ");}
      if(pU_Detail.PUD_RefWName_IsChanged){sbParameter.Append("PUD_RefWName=@PUD_RefWName, ");}
      if(pU_Detail.PUD_Tranfee_IsChanged){sbParameter.Append("PUD_Tranfee=@PUD_Tranfee, ");}
      if(pU_Detail.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pU_Detail.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pU_Detail.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pU_Detail.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pU_Detail.PUD_DNum_IsChanged){sbParameter.Append("PUD_DNum=@PUD_DNum, ");}
      if(pU_Detail.PUD_DStatus_IsChanged){sbParameter.Append("PUD_DStatus=@PUD_DStatus, ");}
      if(pU_Detail.PUD_RefWNoName_IsChanged){sbParameter.Append("PUD_RefWNoName=@PUD_RefWNoName, ");}
      if(pU_Detail.PUD_Udef1_IsChanged){sbParameter.Append("PUD_Udef1=@PUD_Udef1, ");}
      if(pU_Detail.PUD_Udef2_IsChanged){sbParameter.Append("PUD_Udef2=@PUD_Udef2, ");}
      if(pU_Detail.PUD_Udef3_IsChanged){sbParameter.Append("PUD_Udef3=@PUD_Udef3, ");}
      if(pU_Detail.PUD_Udef4_IsChanged){sbParameter.Append("PUD_Udef4=@PUD_Udef4, ");}
      if(pU_Detail.PUD_Udef5_IsChanged){sbParameter.Append("PUD_Udef5=@PUD_Udef5, ");}
      if(pU_Detail.PUD_Udef6_IsChanged){sbParameter.Append("PUD_Udef6=@PUD_Udef6, ");}
      if(pU_Detail.PUD_Udef7_IsChanged){sbParameter.Append("PUD_Udef7=@PUD_Udef7, ");}
      if(pU_Detail.PUD_Udef8_IsChanged){sbParameter.Append("PUD_Udef8=@PUD_Udef8, ");}
      if(pU_Detail.PUD_Udef9_IsChanged){sbParameter.Append("PUD_Udef9=@PUD_Udef9, ");}
      if(pU_Detail.PUD_Udef10_IsChanged){sbParameter.Append("PUD_Udef10=@PUD_Udef10, ");}
      if(pU_Detail.PUD_CCompany_IsChanged){sbParameter.Append("PUD_CCompany=@PUD_CCompany, ");}
      if(pU_Detail.PUD_CCompanyCode_IsChanged){sbParameter.Append("PUD_CCompanyCode=@PUD_CCompanyCode, ");}
      if(pU_Detail.PUD_Dept_IsChanged){sbParameter.Append("PUD_Dept=@PUD_Dept, ");}
      if(pU_Detail.PUD_DeptCode_IsChanged){sbParameter.Append("PUD_DeptCode=@PUD_DeptCode, ");}
      if(pU_Detail.PUD_RDate_IsChanged){sbParameter.Append("PUD_RDate=@PUD_RDate, ");}
      if(pU_Detail.PUD_SupCode_IsChanged){sbParameter.Append("PUD_SupCode=@PUD_SupCode, ");}
      if(pU_Detail.PUD_SupName_IsChanged){sbParameter.Append("PUD_SupName=@PUD_SupName, ");}
      if(pU_Detail.PUD_Num1_IsChanged){sbParameter.Append("PUD_Num1=@PUD_Num1, ");}
      if(pU_Detail.PUD_Num2_IsChanged){sbParameter.Append("PUD_Num2=@PUD_Num2, ");}
      if(pU_Detail.PUD_Num3_IsChanged){sbParameter.Append("PUD_Num3=@PUD_Num3, ");}
      if(pU_Detail.PUD_Num4_IsChanged){sbParameter.Append("PUD_Num4=@PUD_Num4, ");}
      if(pU_Detail.PUD_Num5_IsChanged){sbParameter.Append("PUD_Num5=@PUD_Num5, ");}
      if(pU_Detail.PUD_RevNum_IsChanged){sbParameter.Append("PUD_RevNum=@PUD_RevNum, ");}
      if(pU_Detail.PUD_UEqu_IsChanged){sbParameter.Append("PUD_UEqu=@PUD_UEqu, ");}
      if(pU_Detail.PUD_UsetType_IsChanged){sbParameter.Append("PUD_UsetType=@PUD_UsetType, ");}
      if(pU_Detail.PUD_RevCount_IsChanged){sbParameter.Append("PUD_RevCount=@PUD_RevCount ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PUD_ID=@PUD_ID; " );
      string sql=sb.ToString();
         if(pU_Detail.PUD_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Code))
         {
            idb.AddParameter("@PUD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Code", pU_Detail.PUD_Code);
         }
          }
         if(pU_Detail.PUD_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_MCode))
         {
            idb.AddParameter("@PUD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_MCode", pU_Detail.PUD_MCode);
         }
          }
         if(pU_Detail.PUD_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_MName))
         {
            idb.AddParameter("@PUD_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_MName", pU_Detail.PUD_MName);
         }
          }
         if(pU_Detail.PUD_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Spec))
         {
            idb.AddParameter("@PUD_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Spec", pU_Detail.PUD_Spec);
         }
          }
         if(pU_Detail.PUD_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Unit))
         {
            idb.AddParameter("@PUD_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Unit", pU_Detail.PUD_Unit);
         }
          }
         if(pU_Detail.PUD_Price_IsChanged)
         {
         if (pU_Detail.PUD_Price == 0)
         {
            idb.AddParameter("@PUD_Price", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Price", pU_Detail.PUD_Price);
         }
          }
         if(pU_Detail.PUD_Num_IsChanged)
         {
         if (pU_Detail.PUD_Num == 0)
         {
            idb.AddParameter("@PUD_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num", pU_Detail.PUD_Num);
         }
          }
         if(pU_Detail.PUD_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Bak))
         {
            idb.AddParameter("@PUD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Bak", pU_Detail.PUD_Bak);
         }
          }
         if(pU_Detail.PUD_RType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_RType))
         {
            idb.AddParameter("@PUD_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RType", pU_Detail.PUD_RType);
         }
          }
         if(pU_Detail.PUD_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_RCode))
         {
            idb.AddParameter("@PUD_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RCode", pU_Detail.PUD_RCode);
         }
          }
         if(pU_Detail.PUD_RefWCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWCode))
         {
            idb.AddParameter("@PUD_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWCode", pU_Detail.PUD_RefWCode);
         }
          }
         if(pU_Detail.PUD_RefWNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWNo))
         {
            idb.AddParameter("@PUD_RefWNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWNo", pU_Detail.PUD_RefWNo);
         }
          }
         if(pU_Detail.PUD_RefWName_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWName))
         {
            idb.AddParameter("@PUD_RefWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWName", pU_Detail.PUD_RefWName);
         }
          }
         if(pU_Detail.PUD_Tranfee_IsChanged)
         {
         if (pU_Detail.PUD_Tranfee == 0)
         {
            idb.AddParameter("@PUD_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Tranfee", pU_Detail.PUD_Tranfee);
         }
          }
         if(pU_Detail.Stat_IsChanged)
         {
         if (pU_Detail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Detail.Stat);
         }
          }
         if(pU_Detail.CreateDate_IsChanged)
         {
         if (pU_Detail.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_Detail.CreateDate);
         }
          }
         if(pU_Detail.UpdateDate_IsChanged)
         {
         if (pU_Detail.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_Detail.UpdateDate);
         }
          }
         if(pU_Detail.DeleteDate_IsChanged)
         {
         if (pU_Detail.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_Detail.DeleteDate);
         }
          }
         if(pU_Detail.PUD_DNum_IsChanged)
         {
         if (pU_Detail.PUD_DNum == 0)
         {
            idb.AddParameter("@PUD_DNum", 0);
         }
         else
         {
            idb.AddParameter("@PUD_DNum", pU_Detail.PUD_DNum);
         }
          }
         if(pU_Detail.PUD_DStatus_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_DStatus))
         {
            idb.AddParameter("@PUD_DStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_DStatus", pU_Detail.PUD_DStatus);
         }
          }
         if(pU_Detail.PUD_RefWNoName_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_RefWNoName))
         {
            idb.AddParameter("@PUD_RefWNoName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RefWNoName", pU_Detail.PUD_RefWNoName);
         }
          }
         if(pU_Detail.PUD_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef1))
         {
            idb.AddParameter("@PUD_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef1", pU_Detail.PUD_Udef1);
         }
          }
         if(pU_Detail.PUD_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef2))
         {
            idb.AddParameter("@PUD_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef2", pU_Detail.PUD_Udef2);
         }
          }
         if(pU_Detail.PUD_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef3))
         {
            idb.AddParameter("@PUD_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef3", pU_Detail.PUD_Udef3);
         }
          }
         if(pU_Detail.PUD_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef4))
         {
            idb.AddParameter("@PUD_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef4", pU_Detail.PUD_Udef4);
         }
          }
         if(pU_Detail.PUD_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef5))
         {
            idb.AddParameter("@PUD_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef5", pU_Detail.PUD_Udef5);
         }
          }
         if(pU_Detail.PUD_Udef6_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef6))
         {
            idb.AddParameter("@PUD_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef6", pU_Detail.PUD_Udef6);
         }
          }
         if(pU_Detail.PUD_Udef7_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef7))
         {
            idb.AddParameter("@PUD_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef7", pU_Detail.PUD_Udef7);
         }
          }
         if(pU_Detail.PUD_Udef8_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef8))
         {
            idb.AddParameter("@PUD_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef8", pU_Detail.PUD_Udef8);
         }
          }
         if(pU_Detail.PUD_Udef9_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef9))
         {
            idb.AddParameter("@PUD_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef9", pU_Detail.PUD_Udef9);
         }
          }
         if(pU_Detail.PUD_Udef10_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Udef10))
         {
            idb.AddParameter("@PUD_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Udef10", pU_Detail.PUD_Udef10);
         }
          }
         if(pU_Detail.PUD_CCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_CCompany))
         {
            idb.AddParameter("@PUD_CCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_CCompany", pU_Detail.PUD_CCompany);
         }
          }
         if(pU_Detail.PUD_CCompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_CCompanyCode))
         {
            idb.AddParameter("@PUD_CCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_CCompanyCode", pU_Detail.PUD_CCompanyCode);
         }
          }
         if(pU_Detail.PUD_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_Dept))
         {
            idb.AddParameter("@PUD_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_Dept", pU_Detail.PUD_Dept);
         }
          }
         if(pU_Detail.PUD_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_DeptCode))
         {
            idb.AddParameter("@PUD_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_DeptCode", pU_Detail.PUD_DeptCode);
         }
          }
         if(pU_Detail.PUD_RDate_IsChanged)
         {
         if (pU_Detail.PUD_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUD_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_RDate", pU_Detail.PUD_RDate);
         }
          }
         if(pU_Detail.PUD_SupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_SupCode))
         {
            idb.AddParameter("@PUD_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_SupCode", pU_Detail.PUD_SupCode);
         }
          }
         if(pU_Detail.PUD_SupName_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_SupName))
         {
            idb.AddParameter("@PUD_SupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_SupName", pU_Detail.PUD_SupName);
         }
          }
         if(pU_Detail.PUD_Num1_IsChanged)
         {
         if (pU_Detail.PUD_Num1 == 0)
         {
            idb.AddParameter("@PUD_Num1", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num1", pU_Detail.PUD_Num1);
         }
          }
         if(pU_Detail.PUD_Num2_IsChanged)
         {
         if (pU_Detail.PUD_Num2 == 0)
         {
            idb.AddParameter("@PUD_Num2", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num2", pU_Detail.PUD_Num2);
         }
          }
         if(pU_Detail.PUD_Num3_IsChanged)
         {
         if (pU_Detail.PUD_Num3 == 0)
         {
            idb.AddParameter("@PUD_Num3", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num3", pU_Detail.PUD_Num3);
         }
          }
         if(pU_Detail.PUD_Num4_IsChanged)
         {
         if (pU_Detail.PUD_Num4 == 0)
         {
            idb.AddParameter("@PUD_Num4", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num4", pU_Detail.PUD_Num4);
         }
          }
         if(pU_Detail.PUD_Num5_IsChanged)
         {
         if (pU_Detail.PUD_Num5 == 0)
         {
            idb.AddParameter("@PUD_Num5", 0);
         }
         else
         {
            idb.AddParameter("@PUD_Num5", pU_Detail.PUD_Num5);
         }
          }
         if(pU_Detail.PUD_RevNum_IsChanged)
         {
         if (pU_Detail.PUD_RevNum == 0)
         {
            idb.AddParameter("@PUD_RevNum", 0);
         }
         else
         {
            idb.AddParameter("@PUD_RevNum", pU_Detail.PUD_RevNum);
         }
          }
         if(pU_Detail.PUD_UEqu_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_UEqu))
         {
            idb.AddParameter("@PUD_UEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_UEqu", pU_Detail.PUD_UEqu);
         }
          }
         if(pU_Detail.PUD_UsetType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Detail.PUD_UsetType))
         {
            idb.AddParameter("@PUD_UsetType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUD_UsetType", pU_Detail.PUD_UsetType);
         }
          }
         if(pU_Detail.PUD_RevCount_IsChanged)
         {
         if (pU_Detail.PUD_RevCount == 0)
         {
            idb.AddParameter("@PUD_RevCount", 0);
         }
         else
         {
            idb.AddParameter("@PUD_RevCount", pU_Detail.PUD_RevCount);
         }
          }

         idb.AddParameter("@PUD_ID", pU_Detail.PUD_ID);

           
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
      /// 删除供应商往来细表 PU_Detail对象(即:一条记录
      /// </summary>
      public int Delete(decimal pUD_ID)
      {
         string sql = "DELETE PU_Detail WHERE 1=1  AND PUD_ID=@PUD_ID ";
         idb.AddParameter("@PUD_ID", pUD_ID);

           
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
      /// 获取指定的供应商往来细表 PU_Detail对象(即:一条记录
      /// </summary>
      public PU_Detail GetByKey(decimal pUD_ID)
      {
         PU_Detail pU_Detail = new PU_Detail();
         string sql = "SELECT  PUD_ID,PUD_Code,PUD_MCode,PUD_MName,PUD_Spec,PUD_Unit,PUD_Price,PUD_Num,PUD_Bak,PUD_RType,PUD_RCode,PUD_RefWCode,PUD_RefWNo,PUD_RefWName,PUD_Tranfee,Stat,CreateDate,UpdateDate,DeleteDate,PUD_DNum,PUD_DStatus,PUD_RefWNoName,PUD_Udef1,PUD_Udef2,PUD_Udef3,PUD_Udef4,PUD_Udef5,PUD_Udef6,PUD_Udef7,PUD_Udef8,PUD_Udef9,PUD_Udef10,PUD_CCompany,PUD_CCompanyCode,PUD_Dept,PUD_DeptCode,PUD_RDate,PUD_SupCode,PUD_SupName,PUD_Num1,PUD_Num2,PUD_Num3,PUD_Num4,PUD_Num5,PUD_RevNum,PUD_UEqu,PUD_UsetType,PUD_RevCount FROM PU_Detail WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PUD_ID=@PUD_ID ";
         idb.AddParameter("@PUD_ID", pUD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PUD_ID"] != DBNull.Value) pU_Detail.PUD_ID = Convert.ToDecimal(dr["PUD_ID"]);
            if (dr["PUD_Code"] != DBNull.Value) pU_Detail.PUD_Code = Convert.ToString(dr["PUD_Code"]);
            if (dr["PUD_MCode"] != DBNull.Value) pU_Detail.PUD_MCode = Convert.ToString(dr["PUD_MCode"]);
            if (dr["PUD_MName"] != DBNull.Value) pU_Detail.PUD_MName = Convert.ToString(dr["PUD_MName"]);
            if (dr["PUD_Spec"] != DBNull.Value) pU_Detail.PUD_Spec = Convert.ToString(dr["PUD_Spec"]);
            if (dr["PUD_Unit"] != DBNull.Value) pU_Detail.PUD_Unit = Convert.ToString(dr["PUD_Unit"]);
            if (dr["PUD_Price"] != DBNull.Value) pU_Detail.PUD_Price = Convert.ToDecimal(dr["PUD_Price"]);
            if (dr["PUD_Num"] != DBNull.Value) pU_Detail.PUD_Num = Convert.ToDecimal(dr["PUD_Num"]);
            if (dr["PUD_Bak"] != DBNull.Value) pU_Detail.PUD_Bak = Convert.ToString(dr["PUD_Bak"]);
            if (dr["PUD_RType"] != DBNull.Value) pU_Detail.PUD_RType = Convert.ToString(dr["PUD_RType"]);
            if (dr["PUD_RCode"] != DBNull.Value) pU_Detail.PUD_RCode = Convert.ToString(dr["PUD_RCode"]);
            if (dr["PUD_RefWCode"] != DBNull.Value) pU_Detail.PUD_RefWCode = Convert.ToString(dr["PUD_RefWCode"]);
            if (dr["PUD_RefWNo"] != DBNull.Value) pU_Detail.PUD_RefWNo = Convert.ToString(dr["PUD_RefWNo"]);
            if (dr["PUD_RefWName"] != DBNull.Value) pU_Detail.PUD_RefWName = Convert.ToString(dr["PUD_RefWName"]);
            if (dr["PUD_Tranfee"] != DBNull.Value) pU_Detail.PUD_Tranfee = Convert.ToDecimal(dr["PUD_Tranfee"]);
            if (dr["Stat"] != DBNull.Value) pU_Detail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_Detail.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_Detail.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_Detail.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PUD_DNum"] != DBNull.Value) pU_Detail.PUD_DNum = Convert.ToDecimal(dr["PUD_DNum"]);
            if (dr["PUD_DStatus"] != DBNull.Value) pU_Detail.PUD_DStatus = Convert.ToString(dr["PUD_DStatus"]);
            if (dr["PUD_RefWNoName"] != DBNull.Value) pU_Detail.PUD_RefWNoName = Convert.ToString(dr["PUD_RefWNoName"]);
            if (dr["PUD_Udef1"] != DBNull.Value) pU_Detail.PUD_Udef1 = Convert.ToString(dr["PUD_Udef1"]);
            if (dr["PUD_Udef2"] != DBNull.Value) pU_Detail.PUD_Udef2 = Convert.ToString(dr["PUD_Udef2"]);
            if (dr["PUD_Udef3"] != DBNull.Value) pU_Detail.PUD_Udef3 = Convert.ToString(dr["PUD_Udef3"]);
            if (dr["PUD_Udef4"] != DBNull.Value) pU_Detail.PUD_Udef4 = Convert.ToString(dr["PUD_Udef4"]);
            if (dr["PUD_Udef5"] != DBNull.Value) pU_Detail.PUD_Udef5 = Convert.ToString(dr["PUD_Udef5"]);
            if (dr["PUD_Udef6"] != DBNull.Value) pU_Detail.PUD_Udef6 = Convert.ToString(dr["PUD_Udef6"]);
            if (dr["PUD_Udef7"] != DBNull.Value) pU_Detail.PUD_Udef7 = Convert.ToString(dr["PUD_Udef7"]);
            if (dr["PUD_Udef8"] != DBNull.Value) pU_Detail.PUD_Udef8 = Convert.ToString(dr["PUD_Udef8"]);
            if (dr["PUD_Udef9"] != DBNull.Value) pU_Detail.PUD_Udef9 = Convert.ToString(dr["PUD_Udef9"]);
            if (dr["PUD_Udef10"] != DBNull.Value) pU_Detail.PUD_Udef10 = Convert.ToString(dr["PUD_Udef10"]);
            if (dr["PUD_CCompany"] != DBNull.Value) pU_Detail.PUD_CCompany = Convert.ToString(dr["PUD_CCompany"]);
            if (dr["PUD_CCompanyCode"] != DBNull.Value) pU_Detail.PUD_CCompanyCode = Convert.ToString(dr["PUD_CCompanyCode"]);
            if (dr["PUD_Dept"] != DBNull.Value) pU_Detail.PUD_Dept = Convert.ToString(dr["PUD_Dept"]);
            if (dr["PUD_DeptCode"] != DBNull.Value) pU_Detail.PUD_DeptCode = Convert.ToString(dr["PUD_DeptCode"]);
            if (dr["PUD_RDate"] != DBNull.Value) pU_Detail.PUD_RDate = Convert.ToDateTime(dr["PUD_RDate"]);
            if (dr["PUD_SupCode"] != DBNull.Value) pU_Detail.PUD_SupCode = Convert.ToString(dr["PUD_SupCode"]);
            if (dr["PUD_SupName"] != DBNull.Value) pU_Detail.PUD_SupName = Convert.ToString(dr["PUD_SupName"]);
            if (dr["PUD_Num1"] != DBNull.Value) pU_Detail.PUD_Num1 = Convert.ToDecimal(dr["PUD_Num1"]);
            if (dr["PUD_Num2"] != DBNull.Value) pU_Detail.PUD_Num2 = Convert.ToDecimal(dr["PUD_Num2"]);
            if (dr["PUD_Num3"] != DBNull.Value) pU_Detail.PUD_Num3 = Convert.ToDecimal(dr["PUD_Num3"]);
            if (dr["PUD_Num4"] != DBNull.Value) pU_Detail.PUD_Num4 = Convert.ToDecimal(dr["PUD_Num4"]);
            if (dr["PUD_Num5"] != DBNull.Value) pU_Detail.PUD_Num5 = Convert.ToDecimal(dr["PUD_Num5"]);
            if (dr["PUD_RevNum"] != DBNull.Value) pU_Detail.PUD_RevNum = Convert.ToDecimal(dr["PUD_RevNum"]);
            if (dr["PUD_UEqu"] != DBNull.Value) pU_Detail.PUD_UEqu = Convert.ToString(dr["PUD_UEqu"]);
            if (dr["PUD_UsetType"] != DBNull.Value) pU_Detail.PUD_UsetType = Convert.ToString(dr["PUD_UsetType"]);
            if (dr["PUD_RevCount"] != DBNull.Value) pU_Detail.PUD_RevCount = Convert.ToInt32(dr["PUD_RevCount"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pU_Detail;
      }
      /// <summary>
      /// 获取指定的供应商往来细表 PU_Detail对象集合
      /// </summary>
      public List<PU_Detail> GetListByWhere(string strCondition)
      {
         List<PU_Detail> ret = new List<PU_Detail>();
         string sql = "SELECT  PUD_ID,PUD_Code,PUD_MCode,PUD_MName,PUD_Spec,PUD_Unit,PUD_Price,PUD_Num,PUD_Bak,PUD_RType,PUD_RCode,PUD_RefWCode,PUD_RefWNo,PUD_RefWName,PUD_Tranfee,Stat,CreateDate,UpdateDate,DeleteDate,PUD_DNum,PUD_DStatus,PUD_RefWNoName,PUD_Udef1,PUD_Udef2,PUD_Udef3,PUD_Udef4,PUD_Udef5,PUD_Udef6,PUD_Udef7,PUD_Udef8,PUD_Udef9,PUD_Udef10,PUD_CCompany,PUD_CCompanyCode,PUD_Dept,PUD_DeptCode,PUD_RDate,PUD_SupCode,PUD_SupName,PUD_Num1,PUD_Num2,PUD_Num3,PUD_Num4,PUD_Num5,PUD_RevNum,PUD_UEqu,PUD_UsetType,PUD_RevCount FROM PU_Detail WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PU_Detail pU_Detail = new PU_Detail();
            if (dr["PUD_ID"] != DBNull.Value) pU_Detail.PUD_ID = Convert.ToDecimal(dr["PUD_ID"]);
            if (dr["PUD_Code"] != DBNull.Value) pU_Detail.PUD_Code = Convert.ToString(dr["PUD_Code"]);
            if (dr["PUD_MCode"] != DBNull.Value) pU_Detail.PUD_MCode = Convert.ToString(dr["PUD_MCode"]);
            if (dr["PUD_MName"] != DBNull.Value) pU_Detail.PUD_MName = Convert.ToString(dr["PUD_MName"]);
            if (dr["PUD_Spec"] != DBNull.Value) pU_Detail.PUD_Spec = Convert.ToString(dr["PUD_Spec"]);
            if (dr["PUD_Unit"] != DBNull.Value) pU_Detail.PUD_Unit = Convert.ToString(dr["PUD_Unit"]);
            if (dr["PUD_Price"] != DBNull.Value) pU_Detail.PUD_Price = Convert.ToDecimal(dr["PUD_Price"]);
            if (dr["PUD_Num"] != DBNull.Value) pU_Detail.PUD_Num = Convert.ToDecimal(dr["PUD_Num"]);
            if (dr["PUD_Bak"] != DBNull.Value) pU_Detail.PUD_Bak = Convert.ToString(dr["PUD_Bak"]);
            if (dr["PUD_RType"] != DBNull.Value) pU_Detail.PUD_RType = Convert.ToString(dr["PUD_RType"]);
            if (dr["PUD_RCode"] != DBNull.Value) pU_Detail.PUD_RCode = Convert.ToString(dr["PUD_RCode"]);
            if (dr["PUD_RefWCode"] != DBNull.Value) pU_Detail.PUD_RefWCode = Convert.ToString(dr["PUD_RefWCode"]);
            if (dr["PUD_RefWNo"] != DBNull.Value) pU_Detail.PUD_RefWNo = Convert.ToString(dr["PUD_RefWNo"]);
            if (dr["PUD_RefWName"] != DBNull.Value) pU_Detail.PUD_RefWName = Convert.ToString(dr["PUD_RefWName"]);
            if (dr["PUD_Tranfee"] != DBNull.Value) pU_Detail.PUD_Tranfee = Convert.ToDecimal(dr["PUD_Tranfee"]);
            if (dr["Stat"] != DBNull.Value) pU_Detail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_Detail.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_Detail.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_Detail.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PUD_DNum"] != DBNull.Value) pU_Detail.PUD_DNum = Convert.ToDecimal(dr["PUD_DNum"]);
            if (dr["PUD_DStatus"] != DBNull.Value) pU_Detail.PUD_DStatus = Convert.ToString(dr["PUD_DStatus"]);
            if (dr["PUD_RefWNoName"] != DBNull.Value) pU_Detail.PUD_RefWNoName = Convert.ToString(dr["PUD_RefWNoName"]);
            if (dr["PUD_Udef1"] != DBNull.Value) pU_Detail.PUD_Udef1 = Convert.ToString(dr["PUD_Udef1"]);
            if (dr["PUD_Udef2"] != DBNull.Value) pU_Detail.PUD_Udef2 = Convert.ToString(dr["PUD_Udef2"]);
            if (dr["PUD_Udef3"] != DBNull.Value) pU_Detail.PUD_Udef3 = Convert.ToString(dr["PUD_Udef3"]);
            if (dr["PUD_Udef4"] != DBNull.Value) pU_Detail.PUD_Udef4 = Convert.ToString(dr["PUD_Udef4"]);
            if (dr["PUD_Udef5"] != DBNull.Value) pU_Detail.PUD_Udef5 = Convert.ToString(dr["PUD_Udef5"]);
            if (dr["PUD_Udef6"] != DBNull.Value) pU_Detail.PUD_Udef6 = Convert.ToString(dr["PUD_Udef6"]);
            if (dr["PUD_Udef7"] != DBNull.Value) pU_Detail.PUD_Udef7 = Convert.ToString(dr["PUD_Udef7"]);
            if (dr["PUD_Udef8"] != DBNull.Value) pU_Detail.PUD_Udef8 = Convert.ToString(dr["PUD_Udef8"]);
            if (dr["PUD_Udef9"] != DBNull.Value) pU_Detail.PUD_Udef9 = Convert.ToString(dr["PUD_Udef9"]);
            if (dr["PUD_Udef10"] != DBNull.Value) pU_Detail.PUD_Udef10 = Convert.ToString(dr["PUD_Udef10"]);
            if (dr["PUD_CCompany"] != DBNull.Value) pU_Detail.PUD_CCompany = Convert.ToString(dr["PUD_CCompany"]);
            if (dr["PUD_CCompanyCode"] != DBNull.Value) pU_Detail.PUD_CCompanyCode = Convert.ToString(dr["PUD_CCompanyCode"]);
            if (dr["PUD_Dept"] != DBNull.Value) pU_Detail.PUD_Dept = Convert.ToString(dr["PUD_Dept"]);
            if (dr["PUD_DeptCode"] != DBNull.Value) pU_Detail.PUD_DeptCode = Convert.ToString(dr["PUD_DeptCode"]);
            if (dr["PUD_RDate"] != DBNull.Value) pU_Detail.PUD_RDate = Convert.ToDateTime(dr["PUD_RDate"]);
            if (dr["PUD_SupCode"] != DBNull.Value) pU_Detail.PUD_SupCode = Convert.ToString(dr["PUD_SupCode"]);
            if (dr["PUD_SupName"] != DBNull.Value) pU_Detail.PUD_SupName = Convert.ToString(dr["PUD_SupName"]);
            if (dr["PUD_Num1"] != DBNull.Value) pU_Detail.PUD_Num1 = Convert.ToDecimal(dr["PUD_Num1"]);
            if (dr["PUD_Num2"] != DBNull.Value) pU_Detail.PUD_Num2 = Convert.ToDecimal(dr["PUD_Num2"]);
            if (dr["PUD_Num3"] != DBNull.Value) pU_Detail.PUD_Num3 = Convert.ToDecimal(dr["PUD_Num3"]);
            if (dr["PUD_Num4"] != DBNull.Value) pU_Detail.PUD_Num4 = Convert.ToDecimal(dr["PUD_Num4"]);
            if (dr["PUD_Num5"] != DBNull.Value) pU_Detail.PUD_Num5 = Convert.ToDecimal(dr["PUD_Num5"]);
            if (dr["PUD_RevNum"] != DBNull.Value) pU_Detail.PUD_RevNum = Convert.ToDecimal(dr["PUD_RevNum"]);
            if (dr["PUD_UEqu"] != DBNull.Value) pU_Detail.PUD_UEqu = Convert.ToString(dr["PUD_UEqu"]);
            if (dr["PUD_UsetType"] != DBNull.Value) pU_Detail.PUD_UsetType = Convert.ToString(dr["PUD_UsetType"]);
            if (dr["PUD_RevCount"] != DBNull.Value) pU_Detail.PUD_RevCount = Convert.ToInt32(dr["PUD_RevCount"]);
            ret.Add(pU_Detail);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的供应商往来细表 PU_Detail对象(即:一条记录
      /// </summary>
      public List<PU_Detail> GetAll()
      {
         List<PU_Detail> ret = new List<PU_Detail>();
         string sql = "SELECT  PUD_ID,PUD_Code,PUD_MCode,PUD_MName,PUD_Spec,PUD_Unit,PUD_Price,PUD_Num,PUD_Bak,PUD_RType,PUD_RCode,PUD_RefWCode,PUD_RefWNo,PUD_RefWName,PUD_Tranfee,Stat,CreateDate,UpdateDate,DeleteDate,PUD_DNum,PUD_DStatus,PUD_RefWNoName,PUD_Udef1,PUD_Udef2,PUD_Udef3,PUD_Udef4,PUD_Udef5,PUD_Udef6,PUD_Udef7,PUD_Udef8,PUD_Udef9,PUD_Udef10,PUD_CCompany,PUD_CCompanyCode,PUD_Dept,PUD_DeptCode,PUD_RDate,PUD_SupCode,PUD_SupName,PUD_Num1,PUD_Num2,PUD_Num3,PUD_Num4,PUD_Num5,PUD_RevNum,PUD_UEqu,PUD_UsetType,PUD_RevCount FROM PU_Detail where 1=1 AND ((Stat is null) or (Stat=0) ) order by PUD_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PU_Detail pU_Detail = new PU_Detail();
            if (dr["PUD_ID"] != DBNull.Value) pU_Detail.PUD_ID = Convert.ToDecimal(dr["PUD_ID"]);
            if (dr["PUD_Code"] != DBNull.Value) pU_Detail.PUD_Code = Convert.ToString(dr["PUD_Code"]);
            if (dr["PUD_MCode"] != DBNull.Value) pU_Detail.PUD_MCode = Convert.ToString(dr["PUD_MCode"]);
            if (dr["PUD_MName"] != DBNull.Value) pU_Detail.PUD_MName = Convert.ToString(dr["PUD_MName"]);
            if (dr["PUD_Spec"] != DBNull.Value) pU_Detail.PUD_Spec = Convert.ToString(dr["PUD_Spec"]);
            if (dr["PUD_Unit"] != DBNull.Value) pU_Detail.PUD_Unit = Convert.ToString(dr["PUD_Unit"]);
            if (dr["PUD_Price"] != DBNull.Value) pU_Detail.PUD_Price = Convert.ToDecimal(dr["PUD_Price"]);
            if (dr["PUD_Num"] != DBNull.Value) pU_Detail.PUD_Num = Convert.ToDecimal(dr["PUD_Num"]);
            if (dr["PUD_Bak"] != DBNull.Value) pU_Detail.PUD_Bak = Convert.ToString(dr["PUD_Bak"]);
            if (dr["PUD_RType"] != DBNull.Value) pU_Detail.PUD_RType = Convert.ToString(dr["PUD_RType"]);
            if (dr["PUD_RCode"] != DBNull.Value) pU_Detail.PUD_RCode = Convert.ToString(dr["PUD_RCode"]);
            if (dr["PUD_RefWCode"] != DBNull.Value) pU_Detail.PUD_RefWCode = Convert.ToString(dr["PUD_RefWCode"]);
            if (dr["PUD_RefWNo"] != DBNull.Value) pU_Detail.PUD_RefWNo = Convert.ToString(dr["PUD_RefWNo"]);
            if (dr["PUD_RefWName"] != DBNull.Value) pU_Detail.PUD_RefWName = Convert.ToString(dr["PUD_RefWName"]);
            if (dr["PUD_Tranfee"] != DBNull.Value) pU_Detail.PUD_Tranfee = Convert.ToDecimal(dr["PUD_Tranfee"]);
            if (dr["Stat"] != DBNull.Value) pU_Detail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_Detail.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_Detail.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_Detail.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PUD_DNum"] != DBNull.Value) pU_Detail.PUD_DNum = Convert.ToDecimal(dr["PUD_DNum"]);
            if (dr["PUD_DStatus"] != DBNull.Value) pU_Detail.PUD_DStatus = Convert.ToString(dr["PUD_DStatus"]);
            if (dr["PUD_RefWNoName"] != DBNull.Value) pU_Detail.PUD_RefWNoName = Convert.ToString(dr["PUD_RefWNoName"]);
            if (dr["PUD_Udef1"] != DBNull.Value) pU_Detail.PUD_Udef1 = Convert.ToString(dr["PUD_Udef1"]);
            if (dr["PUD_Udef2"] != DBNull.Value) pU_Detail.PUD_Udef2 = Convert.ToString(dr["PUD_Udef2"]);
            if (dr["PUD_Udef3"] != DBNull.Value) pU_Detail.PUD_Udef3 = Convert.ToString(dr["PUD_Udef3"]);
            if (dr["PUD_Udef4"] != DBNull.Value) pU_Detail.PUD_Udef4 = Convert.ToString(dr["PUD_Udef4"]);
            if (dr["PUD_Udef5"] != DBNull.Value) pU_Detail.PUD_Udef5 = Convert.ToString(dr["PUD_Udef5"]);
            if (dr["PUD_Udef6"] != DBNull.Value) pU_Detail.PUD_Udef6 = Convert.ToString(dr["PUD_Udef6"]);
            if (dr["PUD_Udef7"] != DBNull.Value) pU_Detail.PUD_Udef7 = Convert.ToString(dr["PUD_Udef7"]);
            if (dr["PUD_Udef8"] != DBNull.Value) pU_Detail.PUD_Udef8 = Convert.ToString(dr["PUD_Udef8"]);
            if (dr["PUD_Udef9"] != DBNull.Value) pU_Detail.PUD_Udef9 = Convert.ToString(dr["PUD_Udef9"]);
            if (dr["PUD_Udef10"] != DBNull.Value) pU_Detail.PUD_Udef10 = Convert.ToString(dr["PUD_Udef10"]);
            if (dr["PUD_CCompany"] != DBNull.Value) pU_Detail.PUD_CCompany = Convert.ToString(dr["PUD_CCompany"]);
            if (dr["PUD_CCompanyCode"] != DBNull.Value) pU_Detail.PUD_CCompanyCode = Convert.ToString(dr["PUD_CCompanyCode"]);
            if (dr["PUD_Dept"] != DBNull.Value) pU_Detail.PUD_Dept = Convert.ToString(dr["PUD_Dept"]);
            if (dr["PUD_DeptCode"] != DBNull.Value) pU_Detail.PUD_DeptCode = Convert.ToString(dr["PUD_DeptCode"]);
            if (dr["PUD_RDate"] != DBNull.Value) pU_Detail.PUD_RDate = Convert.ToDateTime(dr["PUD_RDate"]);
            if (dr["PUD_SupCode"] != DBNull.Value) pU_Detail.PUD_SupCode = Convert.ToString(dr["PUD_SupCode"]);
            if (dr["PUD_SupName"] != DBNull.Value) pU_Detail.PUD_SupName = Convert.ToString(dr["PUD_SupName"]);
            if (dr["PUD_Num1"] != DBNull.Value) pU_Detail.PUD_Num1 = Convert.ToDecimal(dr["PUD_Num1"]);
            if (dr["PUD_Num2"] != DBNull.Value) pU_Detail.PUD_Num2 = Convert.ToDecimal(dr["PUD_Num2"]);
            if (dr["PUD_Num3"] != DBNull.Value) pU_Detail.PUD_Num3 = Convert.ToDecimal(dr["PUD_Num3"]);
            if (dr["PUD_Num4"] != DBNull.Value) pU_Detail.PUD_Num4 = Convert.ToDecimal(dr["PUD_Num4"]);
            if (dr["PUD_Num5"] != DBNull.Value) pU_Detail.PUD_Num5 = Convert.ToDecimal(dr["PUD_Num5"]);
            if (dr["PUD_RevNum"] != DBNull.Value) pU_Detail.PUD_RevNum = Convert.ToDecimal(dr["PUD_RevNum"]);
            if (dr["PUD_UEqu"] != DBNull.Value) pU_Detail.PUD_UEqu = Convert.ToString(dr["PUD_UEqu"]);
            if (dr["PUD_UsetType"] != DBNull.Value) pU_Detail.PUD_UsetType = Convert.ToString(dr["PUD_UsetType"]);
            if (dr["PUD_RevCount"] != DBNull.Value) pU_Detail.PUD_RevCount = Convert.ToInt32(dr["PUD_RevCount"]);
            ret.Add(pU_Detail);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
