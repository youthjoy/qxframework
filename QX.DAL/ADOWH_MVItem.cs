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
   /// 物料库存移动信息（出入库，请购单）
   /// </summary>
   [Serializable]
   public partial class ADOWH_MVItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加物料库存移动信息（出入库，请购单） WH_MVItem对象(即:一条记录)
      /// </summary>
      public int Add(WH_MVItem wH_MVItem)
      {
         string sql = "INSERT INTO WH_MVItem (MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,MVI_CostStuff,MVI_CostStuffCode,MVI_CostDept,MVI_CostDeptCode,MVI_CostEqu,MVI_CostDate,Stat,WHI_ID) VALUES (@MVI_Code,@MVI_RCode,@MVI_Type,@MVI_MCode,@MVI_Spec,@MVI_Sup,@MVI_Num,@MVI_Unit,@MVI_MDPrice,@MVI_CostStuff,@MVI_CostStuffCode,@MVI_CostDept,@MVI_CostDeptCode,@MVI_CostEqu,@MVI_CostDate,@Stat,@WHI_ID)";
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Code))
         {
            idb.AddParameter("@MVI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Code", wH_MVItem.MVI_Code);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_RCode))
         {
            idb.AddParameter("@MVI_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_RCode", wH_MVItem.MVI_RCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Type))
         {
            idb.AddParameter("@MVI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Type", wH_MVItem.MVI_Type);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_MCode))
         {
            idb.AddParameter("@MVI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_MCode", wH_MVItem.MVI_MCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Spec))
         {
            idb.AddParameter("@MVI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Spec", wH_MVItem.MVI_Spec);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Sup))
         {
            idb.AddParameter("@MVI_Sup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Sup", wH_MVItem.MVI_Sup);
         }
         if (wH_MVItem.MVI_Num == 0)
         {
            idb.AddParameter("@MVI_Num", 0);
         }
         else
         {
            idb.AddParameter("@MVI_Num", wH_MVItem.MVI_Num);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Unit))
         {
            idb.AddParameter("@MVI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Unit", wH_MVItem.MVI_Unit);
         }
         if (wH_MVItem.MVI_MDPrice == 0)
         {
            idb.AddParameter("@MVI_MDPrice", 0);
         }
         else
         {
            idb.AddParameter("@MVI_MDPrice", wH_MVItem.MVI_MDPrice);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostStuff))
         {
            idb.AddParameter("@MVI_CostStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostStuff", wH_MVItem.MVI_CostStuff);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostStuffCode))
         {
            idb.AddParameter("@MVI_CostStuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostStuffCode", wH_MVItem.MVI_CostStuffCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostDept))
         {
            idb.AddParameter("@MVI_CostDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDept", wH_MVItem.MVI_CostDept);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostDeptCode))
         {
            idb.AddParameter("@MVI_CostDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDeptCode", wH_MVItem.MVI_CostDeptCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostEqu))
         {
            idb.AddParameter("@MVI_CostEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostEqu", wH_MVItem.MVI_CostEqu);
         }
         if (wH_MVItem.MVI_CostDate == DateTime.MinValue)
         {
            idb.AddParameter("@MVI_CostDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDate", wH_MVItem.MVI_CostDate);
         }
         if (wH_MVItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_MVItem.Stat);
         }
         if (string.IsNullOrEmpty(wH_MVItem.WHI_ID))
         {
            idb.AddParameter("@WHI_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_ID", wH_MVItem.WHI_ID);
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
      /// 添加物料库存移动信息（出入库，请购单） WH_MVItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_MVItem wH_MVItem)
      {
         string sql = "INSERT INTO WH_MVItem (MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,MVI_CostStuff,MVI_CostStuffCode,MVI_CostDept,MVI_CostDeptCode,MVI_CostEqu,MVI_CostDate,Stat,WHI_ID) VALUES (@MVI_Code,@MVI_RCode,@MVI_Type,@MVI_MCode,@MVI_Spec,@MVI_Sup,@MVI_Num,@MVI_Unit,@MVI_MDPrice,@MVI_CostStuff,@MVI_CostStuffCode,@MVI_CostDept,@MVI_CostDeptCode,@MVI_CostEqu,@MVI_CostDate,@Stat,@WHI_ID);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Code))
         {
            idb.AddParameter("@MVI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Code", wH_MVItem.MVI_Code);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_RCode))
         {
            idb.AddParameter("@MVI_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_RCode", wH_MVItem.MVI_RCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Type))
         {
            idb.AddParameter("@MVI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Type", wH_MVItem.MVI_Type);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_MCode))
         {
            idb.AddParameter("@MVI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_MCode", wH_MVItem.MVI_MCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Spec))
         {
            idb.AddParameter("@MVI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Spec", wH_MVItem.MVI_Spec);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Sup))
         {
            idb.AddParameter("@MVI_Sup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Sup", wH_MVItem.MVI_Sup);
         }
         if (wH_MVItem.MVI_Num == 0)
         {
            idb.AddParameter("@MVI_Num", 0);
         }
         else
         {
            idb.AddParameter("@MVI_Num", wH_MVItem.MVI_Num);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Unit))
         {
            idb.AddParameter("@MVI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Unit", wH_MVItem.MVI_Unit);
         }
         if (wH_MVItem.MVI_MDPrice == 0)
         {
            idb.AddParameter("@MVI_MDPrice", 0);
         }
         else
         {
            idb.AddParameter("@MVI_MDPrice", wH_MVItem.MVI_MDPrice);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostStuff))
         {
            idb.AddParameter("@MVI_CostStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostStuff", wH_MVItem.MVI_CostStuff);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostStuffCode))
         {
            idb.AddParameter("@MVI_CostStuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostStuffCode", wH_MVItem.MVI_CostStuffCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostDept))
         {
            idb.AddParameter("@MVI_CostDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDept", wH_MVItem.MVI_CostDept);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostDeptCode))
         {
            idb.AddParameter("@MVI_CostDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDeptCode", wH_MVItem.MVI_CostDeptCode);
         }
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostEqu))
         {
            idb.AddParameter("@MVI_CostEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostEqu", wH_MVItem.MVI_CostEqu);
         }
         if (wH_MVItem.MVI_CostDate == DateTime.MinValue)
         {
            idb.AddParameter("@MVI_CostDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDate", wH_MVItem.MVI_CostDate);
         }
         if (wH_MVItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_MVItem.Stat);
         }
         if (string.IsNullOrEmpty(wH_MVItem.WHI_ID))
         {
            idb.AddParameter("@WHI_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_ID", wH_MVItem.WHI_ID);
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
      /// 更新物料库存移动信息（出入库，请购单） WH_MVItem对象(即:一条记录
      /// </summary>
      public int Update(WH_MVItem wH_MVItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_MVItem       SET ");
            if(wH_MVItem.MVI_Code_IsChanged){sbParameter.Append("MVI_Code=@MVI_Code, ");}
      if(wH_MVItem.MVI_RCode_IsChanged){sbParameter.Append("MVI_RCode=@MVI_RCode, ");}
      if(wH_MVItem.MVI_Type_IsChanged){sbParameter.Append("MVI_Type=@MVI_Type, ");}
      if(wH_MVItem.MVI_MCode_IsChanged){sbParameter.Append("MVI_MCode=@MVI_MCode, ");}
      if(wH_MVItem.MVI_Spec_IsChanged){sbParameter.Append("MVI_Spec=@MVI_Spec, ");}
      if(wH_MVItem.MVI_Sup_IsChanged){sbParameter.Append("MVI_Sup=@MVI_Sup, ");}
      if(wH_MVItem.MVI_Num_IsChanged){sbParameter.Append("MVI_Num=@MVI_Num, ");}
      if(wH_MVItem.MVI_Unit_IsChanged){sbParameter.Append("MVI_Unit=@MVI_Unit, ");}
      if(wH_MVItem.MVI_MDPrice_IsChanged){sbParameter.Append("MVI_MDPrice=@MVI_MDPrice, ");}
      if(wH_MVItem.MVI_CostStuff_IsChanged){sbParameter.Append("MVI_CostStuff=@MVI_CostStuff, ");}
      if(wH_MVItem.MVI_CostStuffCode_IsChanged){sbParameter.Append("MVI_CostStuffCode=@MVI_CostStuffCode, ");}
      if(wH_MVItem.MVI_CostDept_IsChanged){sbParameter.Append("MVI_CostDept=@MVI_CostDept, ");}
      if(wH_MVItem.MVI_CostDeptCode_IsChanged){sbParameter.Append("MVI_CostDeptCode=@MVI_CostDeptCode, ");}
      if(wH_MVItem.MVI_CostEqu_IsChanged){sbParameter.Append("MVI_CostEqu=@MVI_CostEqu, ");}
      if(wH_MVItem.MVI_CostDate_IsChanged){sbParameter.Append("MVI_CostDate=@MVI_CostDate, ");}
      if(wH_MVItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_MVItem.WHI_ID_IsChanged){sbParameter.Append("WHI_ID=@WHI_ID ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MVI_ID=@MVI_ID; " );
      string sql=sb.ToString();
         if(wH_MVItem.MVI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Code))
         {
            idb.AddParameter("@MVI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Code", wH_MVItem.MVI_Code);
         }
          }
         if(wH_MVItem.MVI_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_RCode))
         {
            idb.AddParameter("@MVI_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_RCode", wH_MVItem.MVI_RCode);
         }
          }
         if(wH_MVItem.MVI_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Type))
         {
            idb.AddParameter("@MVI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Type", wH_MVItem.MVI_Type);
         }
          }
         if(wH_MVItem.MVI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_MCode))
         {
            idb.AddParameter("@MVI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_MCode", wH_MVItem.MVI_MCode);
         }
          }
         if(wH_MVItem.MVI_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Spec))
         {
            idb.AddParameter("@MVI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Spec", wH_MVItem.MVI_Spec);
         }
          }
         if(wH_MVItem.MVI_Sup_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Sup))
         {
            idb.AddParameter("@MVI_Sup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Sup", wH_MVItem.MVI_Sup);
         }
          }
         if(wH_MVItem.MVI_Num_IsChanged)
         {
         if (wH_MVItem.MVI_Num == 0)
         {
            idb.AddParameter("@MVI_Num", 0);
         }
         else
         {
            idb.AddParameter("@MVI_Num", wH_MVItem.MVI_Num);
         }
          }
         if(wH_MVItem.MVI_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_Unit))
         {
            idb.AddParameter("@MVI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_Unit", wH_MVItem.MVI_Unit);
         }
          }
         if(wH_MVItem.MVI_MDPrice_IsChanged)
         {
         if (wH_MVItem.MVI_MDPrice == 0)
         {
            idb.AddParameter("@MVI_MDPrice", 0);
         }
         else
         {
            idb.AddParameter("@MVI_MDPrice", wH_MVItem.MVI_MDPrice);
         }
          }
         if(wH_MVItem.MVI_CostStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostStuff))
         {
            idb.AddParameter("@MVI_CostStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostStuff", wH_MVItem.MVI_CostStuff);
         }
          }
         if(wH_MVItem.MVI_CostStuffCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostStuffCode))
         {
            idb.AddParameter("@MVI_CostStuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostStuffCode", wH_MVItem.MVI_CostStuffCode);
         }
          }
         if(wH_MVItem.MVI_CostDept_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostDept))
         {
            idb.AddParameter("@MVI_CostDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDept", wH_MVItem.MVI_CostDept);
         }
          }
         if(wH_MVItem.MVI_CostDeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostDeptCode))
         {
            idb.AddParameter("@MVI_CostDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDeptCode", wH_MVItem.MVI_CostDeptCode);
         }
          }
         if(wH_MVItem.MVI_CostEqu_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.MVI_CostEqu))
         {
            idb.AddParameter("@MVI_CostEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostEqu", wH_MVItem.MVI_CostEqu);
         }
          }
         if(wH_MVItem.MVI_CostDate_IsChanged)
         {
         if (wH_MVItem.MVI_CostDate == DateTime.MinValue)
         {
            idb.AddParameter("@MVI_CostDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MVI_CostDate", wH_MVItem.MVI_CostDate);
         }
          }
         if(wH_MVItem.Stat_IsChanged)
         {
         if (wH_MVItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_MVItem.Stat);
         }
          }
         if(wH_MVItem.WHI_ID_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_MVItem.WHI_ID))
         {
            idb.AddParameter("@WHI_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_ID", wH_MVItem.WHI_ID);
         }
          }

         idb.AddParameter("@MVI_ID", wH_MVItem.MVI_ID);

           
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
      /// 删除物料库存移动信息（出入库，请购单） WH_MVItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal mVI_ID)
      {
         string sql = "DELETE WH_MVItem WHERE 1=1  AND MVI_ID=@MVI_ID ";
         idb.AddParameter("@MVI_ID", mVI_ID);

           
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
      /// 获取指定的物料库存移动信息（出入库，请购单） WH_MVItem对象(即:一条记录
      /// </summary>
      public WH_MVItem GetByKey(decimal mVI_ID)
      {
         WH_MVItem wH_MVItem = new WH_MVItem();
         string sql = "SELECT  MVI_ID,MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,MVI_CostStuff,MVI_CostStuffCode,MVI_CostDept,MVI_CostDeptCode,MVI_CostEqu,MVI_CostDate,Stat,WHI_ID FROM WH_MVItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MVI_ID=@MVI_ID ";
         idb.AddParameter("@MVI_ID", mVI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MVI_ID"] != DBNull.Value) wH_MVItem.MVI_ID = Convert.ToDecimal(dr["MVI_ID"]);
            if (dr["MVI_Code"] != DBNull.Value) wH_MVItem.MVI_Code = Convert.ToString(dr["MVI_Code"]);
            if (dr["MVI_RCode"] != DBNull.Value) wH_MVItem.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
            if (dr["MVI_Type"] != DBNull.Value) wH_MVItem.MVI_Type = Convert.ToString(dr["MVI_Type"]);
            if (dr["MVI_MCode"] != DBNull.Value) wH_MVItem.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
            if (dr["MVI_Spec"] != DBNull.Value) wH_MVItem.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
            if (dr["MVI_Sup"] != DBNull.Value) wH_MVItem.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
            if (dr["MVI_Num"] != DBNull.Value) wH_MVItem.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
            if (dr["MVI_Unit"] != DBNull.Value) wH_MVItem.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
            if (dr["MVI_MDPrice"] != DBNull.Value) wH_MVItem.MVI_MDPrice = Convert.ToDecimal(dr["MVI_MDPrice"]);
            if (dr["MVI_CostStuff"] != DBNull.Value) wH_MVItem.MVI_CostStuff = Convert.ToString(dr["MVI_CostStuff"]);
            if (dr["MVI_CostStuffCode"] != DBNull.Value) wH_MVItem.MVI_CostStuffCode = Convert.ToString(dr["MVI_CostStuffCode"]);
            if (dr["MVI_CostDept"] != DBNull.Value) wH_MVItem.MVI_CostDept = Convert.ToString(dr["MVI_CostDept"]);
            if (dr["MVI_CostDeptCode"] != DBNull.Value) wH_MVItem.MVI_CostDeptCode = Convert.ToString(dr["MVI_CostDeptCode"]);
            if (dr["MVI_CostEqu"] != DBNull.Value) wH_MVItem.MVI_CostEqu = Convert.ToString(dr["MVI_CostEqu"]);
            if (dr["MVI_CostDate"] != DBNull.Value) wH_MVItem.MVI_CostDate = Convert.ToDateTime(dr["MVI_CostDate"]);
            if (dr["Stat"] != DBNull.Value) wH_MVItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHI_ID"] != DBNull.Value) wH_MVItem.WHI_ID = Convert.ToString(dr["WHI_ID"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_MVItem;
      }
      /// <summary>
      /// 获取指定的物料库存移动信息（出入库，请购单） WH_MVItem对象集合
      /// </summary>
      public List<WH_MVItem> GetListByWhere(string strCondition)
      {
         List<WH_MVItem> ret = new List<WH_MVItem>();
         string sql = "SELECT  MVI_ID,MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,MVI_CostStuff,MVI_CostStuffCode,MVI_CostDept,MVI_CostDeptCode,MVI_CostEqu,MVI_CostDate,Stat,WHI_ID FROM WH_MVItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_MVItem wH_MVItem = new WH_MVItem();
            if (dr["MVI_ID"] != DBNull.Value) wH_MVItem.MVI_ID = Convert.ToDecimal(dr["MVI_ID"]);
            if (dr["MVI_Code"] != DBNull.Value) wH_MVItem.MVI_Code = Convert.ToString(dr["MVI_Code"]);
            if (dr["MVI_RCode"] != DBNull.Value) wH_MVItem.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
            if (dr["MVI_Type"] != DBNull.Value) wH_MVItem.MVI_Type = Convert.ToString(dr["MVI_Type"]);
            if (dr["MVI_MCode"] != DBNull.Value) wH_MVItem.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
            if (dr["MVI_Spec"] != DBNull.Value) wH_MVItem.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
            if (dr["MVI_Sup"] != DBNull.Value) wH_MVItem.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
            if (dr["MVI_Num"] != DBNull.Value) wH_MVItem.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
            if (dr["MVI_Unit"] != DBNull.Value) wH_MVItem.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
            if (dr["MVI_MDPrice"] != DBNull.Value) wH_MVItem.MVI_MDPrice = Convert.ToDecimal(dr["MVI_MDPrice"]);
            if (dr["MVI_CostStuff"] != DBNull.Value) wH_MVItem.MVI_CostStuff = Convert.ToString(dr["MVI_CostStuff"]);
            if (dr["MVI_CostStuffCode"] != DBNull.Value) wH_MVItem.MVI_CostStuffCode = Convert.ToString(dr["MVI_CostStuffCode"]);
            if (dr["MVI_CostDept"] != DBNull.Value) wH_MVItem.MVI_CostDept = Convert.ToString(dr["MVI_CostDept"]);
            if (dr["MVI_CostDeptCode"] != DBNull.Value) wH_MVItem.MVI_CostDeptCode = Convert.ToString(dr["MVI_CostDeptCode"]);
            if (dr["MVI_CostEqu"] != DBNull.Value) wH_MVItem.MVI_CostEqu = Convert.ToString(dr["MVI_CostEqu"]);
            if (dr["MVI_CostDate"] != DBNull.Value) wH_MVItem.MVI_CostDate = Convert.ToDateTime(dr["MVI_CostDate"]);
            if (dr["Stat"] != DBNull.Value) wH_MVItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHI_ID"] != DBNull.Value) wH_MVItem.WHI_ID = Convert.ToString(dr["WHI_ID"]);
            ret.Add(wH_MVItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的物料库存移动信息（出入库，请购单） WH_MVItem对象(即:一条记录
      /// </summary>
      public List<WH_MVItem> GetAll()
      {
         List<WH_MVItem> ret = new List<WH_MVItem>();
         string sql = "SELECT  MVI_ID,MVI_Code,MVI_RCode,MVI_Type,MVI_MCode,MVI_Spec,MVI_Sup,MVI_Num,MVI_Unit,MVI_MDPrice,MVI_CostStuff,MVI_CostStuffCode,MVI_CostDept,MVI_CostDeptCode,MVI_CostEqu,MVI_CostDate,Stat,WHI_ID FROM WH_MVItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by MVI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_MVItem wH_MVItem = new WH_MVItem();
            if (dr["MVI_ID"] != DBNull.Value) wH_MVItem.MVI_ID = Convert.ToDecimal(dr["MVI_ID"]);
            if (dr["MVI_Code"] != DBNull.Value) wH_MVItem.MVI_Code = Convert.ToString(dr["MVI_Code"]);
            if (dr["MVI_RCode"] != DBNull.Value) wH_MVItem.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
            if (dr["MVI_Type"] != DBNull.Value) wH_MVItem.MVI_Type = Convert.ToString(dr["MVI_Type"]);
            if (dr["MVI_MCode"] != DBNull.Value) wH_MVItem.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
            if (dr["MVI_Spec"] != DBNull.Value) wH_MVItem.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
            if (dr["MVI_Sup"] != DBNull.Value) wH_MVItem.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
            if (dr["MVI_Num"] != DBNull.Value) wH_MVItem.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
            if (dr["MVI_Unit"] != DBNull.Value) wH_MVItem.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
            if (dr["MVI_MDPrice"] != DBNull.Value) wH_MVItem.MVI_MDPrice = Convert.ToDecimal(dr["MVI_MDPrice"]);
            if (dr["MVI_CostStuff"] != DBNull.Value) wH_MVItem.MVI_CostStuff = Convert.ToString(dr["MVI_CostStuff"]);
            if (dr["MVI_CostStuffCode"] != DBNull.Value) wH_MVItem.MVI_CostStuffCode = Convert.ToString(dr["MVI_CostStuffCode"]);
            if (dr["MVI_CostDept"] != DBNull.Value) wH_MVItem.MVI_CostDept = Convert.ToString(dr["MVI_CostDept"]);
            if (dr["MVI_CostDeptCode"] != DBNull.Value) wH_MVItem.MVI_CostDeptCode = Convert.ToString(dr["MVI_CostDeptCode"]);
            if (dr["MVI_CostEqu"] != DBNull.Value) wH_MVItem.MVI_CostEqu = Convert.ToString(dr["MVI_CostEqu"]);
            if (dr["MVI_CostDate"] != DBNull.Value) wH_MVItem.MVI_CostDate = Convert.ToDateTime(dr["MVI_CostDate"]);
            if (dr["Stat"] != DBNull.Value) wH_MVItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WHI_ID"] != DBNull.Value) wH_MVItem.WHI_ID = Convert.ToString(dr["WHI_ID"]);
            ret.Add(wH_MVItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
