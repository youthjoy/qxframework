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
   /// 物料主数据
   /// </summary>
   [Serializable]
   public partial class ADOWH_Material
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加物料主数据 WH_Material对象(即:一条记录)
      /// </summary>
      public int Add(WH_Material wH_Material)
      {
         string sql = "INSERT INTO WH_Material (MD_MCode,MD_Name,MD_Spec,MD_Barcode,MD_Group,MD_Group_Temp,MD_iType,MD_PriceList,MD_Unit,MD_Num,MD_LNum,MD_TNum,MD_Factory,MD_Units,MD_Bak,MD_DWName,MD_DWCode,Stat,CreateDate,UpdateDate,DeleteDate,MD_UDEF1,MD_UDEF2,MD_UDEF3,MD_UDEF4,MD_UDEF5,MD_TechCode) VALUES (@MD_MCode,@MD_Name,@MD_Spec,@MD_Barcode,@MD_Group,@MD_Group_Temp,@MD_iType,@MD_PriceList,@MD_Unit,@MD_Num,@MD_LNum,@MD_TNum,@MD_Factory,@MD_Units,@MD_Bak,@MD_DWName,@MD_DWCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@MD_UDEF1,@MD_UDEF2,@MD_UDEF3,@MD_UDEF4,@MD_UDEF5,@MD_TechCode)";
         if (string.IsNullOrEmpty(wH_Material.MD_MCode))
         {
            idb.AddParameter("@MD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_MCode", wH_Material.MD_MCode);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Name))
         {
            idb.AddParameter("@MD_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Name", wH_Material.MD_Name);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Spec))
         {
            idb.AddParameter("@MD_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Spec", wH_Material.MD_Spec);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Barcode))
         {
            idb.AddParameter("@MD_Barcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Barcode", wH_Material.MD_Barcode);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Group))
         {
            idb.AddParameter("@MD_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Group", wH_Material.MD_Group);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Group_Temp))
         {
            idb.AddParameter("@MD_Group_Temp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Group_Temp", wH_Material.MD_Group_Temp);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_iType))
         {
            idb.AddParameter("@MD_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_iType", wH_Material.MD_iType);
         }
         if (wH_Material.MD_PriceList == 0)
         {
            idb.AddParameter("@MD_PriceList", 0);
         }
         else
         {
            idb.AddParameter("@MD_PriceList", wH_Material.MD_PriceList);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Unit))
         {
            idb.AddParameter("@MD_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Unit", wH_Material.MD_Unit);
         }
         if (wH_Material.MD_Num == 0)
         {
            idb.AddParameter("@MD_Num", 0);
         }
         else
         {
            idb.AddParameter("@MD_Num", wH_Material.MD_Num);
         }
         if (wH_Material.MD_LNum == 0)
         {
            idb.AddParameter("@MD_LNum", 0);
         }
         else
         {
            idb.AddParameter("@MD_LNum", wH_Material.MD_LNum);
         }
         if (wH_Material.MD_TNum == 0)
         {
            idb.AddParameter("@MD_TNum", 0);
         }
         else
         {
            idb.AddParameter("@MD_TNum", wH_Material.MD_TNum);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Factory))
         {
            idb.AddParameter("@MD_Factory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Factory", wH_Material.MD_Factory);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Units))
         {
            idb.AddParameter("@MD_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Units", wH_Material.MD_Units);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Bak))
         {
            idb.AddParameter("@MD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Bak", wH_Material.MD_Bak);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_DWName))
         {
            idb.AddParameter("@MD_DWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWName", wH_Material.MD_DWName);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_DWCode))
         {
            idb.AddParameter("@MD_DWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWCode", wH_Material.MD_DWCode);
         }
         if (wH_Material.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Material.Stat);
         }
         if (wH_Material.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Material.CreateDate);
         }
         if (wH_Material.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Material.UpdateDate);
         }
         if (wH_Material.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Material.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF1))
         {
            idb.AddParameter("@MD_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF1", wH_Material.MD_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF2))
         {
            idb.AddParameter("@MD_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF2", wH_Material.MD_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF3))
         {
            idb.AddParameter("@MD_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF3", wH_Material.MD_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF4))
         {
            idb.AddParameter("@MD_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF4", wH_Material.MD_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF5))
         {
            idb.AddParameter("@MD_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF5", wH_Material.MD_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_TechCode))
         {
            idb.AddParameter("@MD_TechCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_TechCode", wH_Material.MD_TechCode);
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
      /// 添加物料主数据 WH_Material对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Material wH_Material)
      {
         string sql = "INSERT INTO WH_Material (MD_MCode,MD_Name,MD_Spec,MD_Barcode,MD_Group,MD_Group_Temp,MD_iType,MD_PriceList,MD_Unit,MD_Num,MD_LNum,MD_TNum,MD_Factory,MD_Units,MD_Bak,MD_DWName,MD_DWCode,Stat,CreateDate,UpdateDate,DeleteDate,MD_UDEF1,MD_UDEF2,MD_UDEF3,MD_UDEF4,MD_UDEF5,MD_TechCode) VALUES (@MD_MCode,@MD_Name,@MD_Spec,@MD_Barcode,@MD_Group,@MD_Group_Temp,@MD_iType,@MD_PriceList,@MD_Unit,@MD_Num,@MD_LNum,@MD_TNum,@MD_Factory,@MD_Units,@MD_Bak,@MD_DWName,@MD_DWCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@MD_UDEF1,@MD_UDEF2,@MD_UDEF3,@MD_UDEF4,@MD_UDEF5,@MD_TechCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Material.MD_MCode))
         {
            idb.AddParameter("@MD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_MCode", wH_Material.MD_MCode);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Name))
         {
            idb.AddParameter("@MD_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Name", wH_Material.MD_Name);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Spec))
         {
            idb.AddParameter("@MD_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Spec", wH_Material.MD_Spec);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Barcode))
         {
            idb.AddParameter("@MD_Barcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Barcode", wH_Material.MD_Barcode);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Group))
         {
            idb.AddParameter("@MD_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Group", wH_Material.MD_Group);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Group_Temp))
         {
            idb.AddParameter("@MD_Group_Temp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Group_Temp", wH_Material.MD_Group_Temp);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_iType))
         {
            idb.AddParameter("@MD_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_iType", wH_Material.MD_iType);
         }
         if (wH_Material.MD_PriceList == 0)
         {
            idb.AddParameter("@MD_PriceList", 0);
         }
         else
         {
            idb.AddParameter("@MD_PriceList", wH_Material.MD_PriceList);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Unit))
         {
            idb.AddParameter("@MD_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Unit", wH_Material.MD_Unit);
         }
         if (wH_Material.MD_Num == 0)
         {
            idb.AddParameter("@MD_Num", 0);
         }
         else
         {
            idb.AddParameter("@MD_Num", wH_Material.MD_Num);
         }
         if (wH_Material.MD_LNum == 0)
         {
            idb.AddParameter("@MD_LNum", 0);
         }
         else
         {
            idb.AddParameter("@MD_LNum", wH_Material.MD_LNum);
         }
         if (wH_Material.MD_TNum == 0)
         {
            idb.AddParameter("@MD_TNum", 0);
         }
         else
         {
            idb.AddParameter("@MD_TNum", wH_Material.MD_TNum);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Factory))
         {
            idb.AddParameter("@MD_Factory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Factory", wH_Material.MD_Factory);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Units))
         {
            idb.AddParameter("@MD_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Units", wH_Material.MD_Units);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_Bak))
         {
            idb.AddParameter("@MD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Bak", wH_Material.MD_Bak);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_DWName))
         {
            idb.AddParameter("@MD_DWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWName", wH_Material.MD_DWName);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_DWCode))
         {
            idb.AddParameter("@MD_DWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWCode", wH_Material.MD_DWCode);
         }
         if (wH_Material.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Material.Stat);
         }
         if (wH_Material.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Material.CreateDate);
         }
         if (wH_Material.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Material.UpdateDate);
         }
         if (wH_Material.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Material.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF1))
         {
            idb.AddParameter("@MD_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF1", wH_Material.MD_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF2))
         {
            idb.AddParameter("@MD_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF2", wH_Material.MD_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF3))
         {
            idb.AddParameter("@MD_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF3", wH_Material.MD_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF4))
         {
            idb.AddParameter("@MD_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF4", wH_Material.MD_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF5))
         {
            idb.AddParameter("@MD_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF5", wH_Material.MD_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Material.MD_TechCode))
         {
            idb.AddParameter("@MD_TechCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_TechCode", wH_Material.MD_TechCode);
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
      /// 更新物料主数据 WH_Material对象(即:一条记录
      /// </summary>
      public int Update(WH_Material wH_Material)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Material       SET ");
            if(wH_Material.MD_MCode_IsChanged){sbParameter.Append("MD_MCode=@MD_MCode, ");}
      if(wH_Material.MD_Name_IsChanged){sbParameter.Append("MD_Name=@MD_Name, ");}
      if(wH_Material.MD_Spec_IsChanged){sbParameter.Append("MD_Spec=@MD_Spec, ");}
      if(wH_Material.MD_Barcode_IsChanged){sbParameter.Append("MD_Barcode=@MD_Barcode, ");}
      if(wH_Material.MD_Group_IsChanged){sbParameter.Append("MD_Group=@MD_Group, ");}
      if(wH_Material.MD_Group_Temp_IsChanged){sbParameter.Append("MD_Group_Temp=@MD_Group_Temp, ");}
      if(wH_Material.MD_iType_IsChanged){sbParameter.Append("MD_iType=@MD_iType, ");}
      if(wH_Material.MD_PriceList_IsChanged){sbParameter.Append("MD_PriceList=@MD_PriceList, ");}
      if(wH_Material.MD_Unit_IsChanged){sbParameter.Append("MD_Unit=@MD_Unit, ");}
      if(wH_Material.MD_Num_IsChanged){sbParameter.Append("MD_Num=@MD_Num, ");}
      if(wH_Material.MD_LNum_IsChanged){sbParameter.Append("MD_LNum=@MD_LNum, ");}
      if(wH_Material.MD_TNum_IsChanged){sbParameter.Append("MD_TNum=@MD_TNum, ");}
      if(wH_Material.MD_Factory_IsChanged){sbParameter.Append("MD_Factory=@MD_Factory, ");}
      if(wH_Material.MD_Units_IsChanged){sbParameter.Append("MD_Units=@MD_Units, ");}
      if(wH_Material.MD_Bak_IsChanged){sbParameter.Append("MD_Bak=@MD_Bak, ");}
      if(wH_Material.MD_DWName_IsChanged){sbParameter.Append("MD_DWName=@MD_DWName, ");}
      if(wH_Material.MD_DWCode_IsChanged){sbParameter.Append("MD_DWCode=@MD_DWCode, ");}
      if(wH_Material.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Material.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Material.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Material.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Material.MD_UDEF1_IsChanged){sbParameter.Append("MD_UDEF1=@MD_UDEF1, ");}
      if(wH_Material.MD_UDEF2_IsChanged){sbParameter.Append("MD_UDEF2=@MD_UDEF2, ");}
      if(wH_Material.MD_UDEF3_IsChanged){sbParameter.Append("MD_UDEF3=@MD_UDEF3, ");}
      if(wH_Material.MD_UDEF4_IsChanged){sbParameter.Append("MD_UDEF4=@MD_UDEF4, ");}
      if(wH_Material.MD_UDEF5_IsChanged){sbParameter.Append("MD_UDEF5=@MD_UDEF5, ");}
      if(wH_Material.MD_TechCode_IsChanged){sbParameter.Append("MD_TechCode=@MD_TechCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MD_ID=@MD_ID; " );
      string sql=sb.ToString();
         if(wH_Material.MD_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_MCode))
         {
            idb.AddParameter("@MD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_MCode", wH_Material.MD_MCode);
         }
          }
         if(wH_Material.MD_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Name))
         {
            idb.AddParameter("@MD_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Name", wH_Material.MD_Name);
         }
          }
         if(wH_Material.MD_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Spec))
         {
            idb.AddParameter("@MD_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Spec", wH_Material.MD_Spec);
         }
          }
         if(wH_Material.MD_Barcode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Barcode))
         {
            idb.AddParameter("@MD_Barcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Barcode", wH_Material.MD_Barcode);
         }
          }
         if(wH_Material.MD_Group_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Group))
         {
            idb.AddParameter("@MD_Group", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Group", wH_Material.MD_Group);
         }
          }
         if(wH_Material.MD_Group_Temp_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Group_Temp))
         {
            idb.AddParameter("@MD_Group_Temp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Group_Temp", wH_Material.MD_Group_Temp);
         }
          }
         if(wH_Material.MD_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_iType))
         {
            idb.AddParameter("@MD_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_iType", wH_Material.MD_iType);
         }
          }
         if(wH_Material.MD_PriceList_IsChanged)
         {
         if (wH_Material.MD_PriceList == 0)
         {
            idb.AddParameter("@MD_PriceList", 0);
         }
         else
         {
            idb.AddParameter("@MD_PriceList", wH_Material.MD_PriceList);
         }
          }
         if(wH_Material.MD_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Unit))
         {
            idb.AddParameter("@MD_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Unit", wH_Material.MD_Unit);
         }
          }
         if(wH_Material.MD_Num_IsChanged)
         {
         if (wH_Material.MD_Num == 0)
         {
            idb.AddParameter("@MD_Num", 0);
         }
         else
         {
            idb.AddParameter("@MD_Num", wH_Material.MD_Num);
         }
          }
         if(wH_Material.MD_LNum_IsChanged)
         {
         if (wH_Material.MD_LNum == 0)
         {
            idb.AddParameter("@MD_LNum", 0);
         }
         else
         {
            idb.AddParameter("@MD_LNum", wH_Material.MD_LNum);
         }
          }
         if(wH_Material.MD_TNum_IsChanged)
         {
         if (wH_Material.MD_TNum == 0)
         {
            idb.AddParameter("@MD_TNum", 0);
         }
         else
         {
            idb.AddParameter("@MD_TNum", wH_Material.MD_TNum);
         }
          }
         if(wH_Material.MD_Factory_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Factory))
         {
            idb.AddParameter("@MD_Factory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Factory", wH_Material.MD_Factory);
         }
          }
         if(wH_Material.MD_Units_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Units))
         {
            idb.AddParameter("@MD_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Units", wH_Material.MD_Units);
         }
          }
         if(wH_Material.MD_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_Bak))
         {
            idb.AddParameter("@MD_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_Bak", wH_Material.MD_Bak);
         }
          }
         if(wH_Material.MD_DWName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_DWName))
         {
            idb.AddParameter("@MD_DWName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWName", wH_Material.MD_DWName);
         }
          }
         if(wH_Material.MD_DWCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_DWCode))
         {
            idb.AddParameter("@MD_DWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_DWCode", wH_Material.MD_DWCode);
         }
          }
         if(wH_Material.Stat_IsChanged)
         {
         if (wH_Material.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Material.Stat);
         }
          }
         if(wH_Material.CreateDate_IsChanged)
         {
         if (wH_Material.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Material.CreateDate);
         }
          }
         if(wH_Material.UpdateDate_IsChanged)
         {
         if (wH_Material.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Material.UpdateDate);
         }
          }
         if(wH_Material.DeleteDate_IsChanged)
         {
         if (wH_Material.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Material.DeleteDate);
         }
          }
         if(wH_Material.MD_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF1))
         {
            idb.AddParameter("@MD_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF1", wH_Material.MD_UDEF1);
         }
          }
         if(wH_Material.MD_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF2))
         {
            idb.AddParameter("@MD_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF2", wH_Material.MD_UDEF2);
         }
          }
         if(wH_Material.MD_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF3))
         {
            idb.AddParameter("@MD_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF3", wH_Material.MD_UDEF3);
         }
          }
         if(wH_Material.MD_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF4))
         {
            idb.AddParameter("@MD_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF4", wH_Material.MD_UDEF4);
         }
          }
         if(wH_Material.MD_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_UDEF5))
         {
            idb.AddParameter("@MD_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_UDEF5", wH_Material.MD_UDEF5);
         }
          }
         if(wH_Material.MD_TechCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Material.MD_TechCode))
         {
            idb.AddParameter("@MD_TechCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MD_TechCode", wH_Material.MD_TechCode);
         }
          }

         idb.AddParameter("@MD_ID", wH_Material.MD_ID);

           
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
      /// 删除物料主数据 WH_Material对象(即:一条记录
      /// </summary>
      public int Delete(decimal mD_ID)
      {
         string sql = "DELETE WH_Material WHERE 1=1  AND MD_ID=@MD_ID ";
         idb.AddParameter("@MD_ID", mD_ID);

           
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
      /// 获取指定的物料主数据 WH_Material对象(即:一条记录
      /// </summary>
      public WH_Material GetByKey(decimal mD_ID)
      {
         WH_Material wH_Material = new WH_Material();
         string sql = "SELECT  MD_ID,MD_MCode,MD_Name,MD_Spec,MD_Barcode,MD_Group,MD_Group_Temp,MD_iType,MD_PriceList,MD_Unit,MD_Num,MD_LNum,MD_TNum,MD_Factory,MD_Units,MD_Bak,MD_DWName,MD_DWCode,Stat,CreateDate,UpdateDate,DeleteDate,MD_UDEF1,MD_UDEF2,MD_UDEF3,MD_UDEF4,MD_UDEF5,MD_TechCode FROM WH_Material WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MD_ID=@MD_ID ";
         idb.AddParameter("@MD_ID", mD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MD_ID"] != DBNull.Value) wH_Material.MD_ID = Convert.ToDecimal(dr["MD_ID"]);
            if (dr["MD_MCode"] != DBNull.Value) wH_Material.MD_MCode = Convert.ToString(dr["MD_MCode"]);
            if (dr["MD_Name"] != DBNull.Value) wH_Material.MD_Name = Convert.ToString(dr["MD_Name"]);
            if (dr["MD_Spec"] != DBNull.Value) wH_Material.MD_Spec = Convert.ToString(dr["MD_Spec"]);
            if (dr["MD_Barcode"] != DBNull.Value) wH_Material.MD_Barcode = Convert.ToString(dr["MD_Barcode"]);
            if (dr["MD_Group"] != DBNull.Value) wH_Material.MD_Group = Convert.ToString(dr["MD_Group"]);
            if (dr["MD_Group_Temp"] != DBNull.Value) wH_Material.MD_Group_Temp = Convert.ToString(dr["MD_Group_Temp"]);
            if (dr["MD_iType"] != DBNull.Value) wH_Material.MD_iType = Convert.ToString(dr["MD_iType"]);
            if (dr["MD_PriceList"] != DBNull.Value) wH_Material.MD_PriceList = Convert.ToDecimal(dr["MD_PriceList"]);
            if (dr["MD_Unit"] != DBNull.Value) wH_Material.MD_Unit = Convert.ToString(dr["MD_Unit"]);
            if (dr["MD_Num"] != DBNull.Value) wH_Material.MD_Num = Convert.ToDecimal(dr["MD_Num"]);
            if (dr["MD_LNum"] != DBNull.Value) wH_Material.MD_LNum = Convert.ToDecimal(dr["MD_LNum"]);
            if (dr["MD_TNum"] != DBNull.Value) wH_Material.MD_TNum = Convert.ToDecimal(dr["MD_TNum"]);
            if (dr["MD_Factory"] != DBNull.Value) wH_Material.MD_Factory = Convert.ToString(dr["MD_Factory"]);
            if (dr["MD_Units"] != DBNull.Value) wH_Material.MD_Units = Convert.ToString(dr["MD_Units"]);
            if (dr["MD_Bak"] != DBNull.Value) wH_Material.MD_Bak = Convert.ToString(dr["MD_Bak"]);
            if (dr["MD_DWName"] != DBNull.Value) wH_Material.MD_DWName = Convert.ToString(dr["MD_DWName"]);
            if (dr["MD_DWCode"] != DBNull.Value) wH_Material.MD_DWCode = Convert.ToString(dr["MD_DWCode"]);
            if (dr["Stat"] != DBNull.Value) wH_Material.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Material.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Material.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Material.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MD_UDEF1"] != DBNull.Value) wH_Material.MD_UDEF1 = Convert.ToString(dr["MD_UDEF1"]);
            if (dr["MD_UDEF2"] != DBNull.Value) wH_Material.MD_UDEF2 = Convert.ToString(dr["MD_UDEF2"]);
            if (dr["MD_UDEF3"] != DBNull.Value) wH_Material.MD_UDEF3 = Convert.ToString(dr["MD_UDEF3"]);
            if (dr["MD_UDEF4"] != DBNull.Value) wH_Material.MD_UDEF4 = Convert.ToString(dr["MD_UDEF4"]);
            if (dr["MD_UDEF5"] != DBNull.Value) wH_Material.MD_UDEF5 = Convert.ToString(dr["MD_UDEF5"]);
            if (dr["MD_TechCode"] != DBNull.Value) wH_Material.MD_TechCode = Convert.ToString(dr["MD_TechCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Material;
      }
      /// <summary>
      /// 获取指定的物料主数据 WH_Material对象集合
      /// </summary>
      public List<WH_Material> GetListByWhere(string strCondition)
      {
         List<WH_Material> ret = new List<WH_Material>();
         string sql = "SELECT  MD_ID,MD_MCode,MD_Name,MD_Spec,MD_Barcode,MD_Group,MD_Group_Temp,MD_iType,MD_PriceList,MD_Unit,MD_Num,MD_LNum,MD_TNum,MD_Factory,MD_Units,MD_Bak,MD_DWName,MD_DWCode,Stat,CreateDate,UpdateDate,DeleteDate,MD_UDEF1,MD_UDEF2,MD_UDEF3,MD_UDEF4,MD_UDEF5,MD_TechCode FROM WH_Material WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Material wH_Material = new WH_Material();
            if (dr["MD_ID"] != DBNull.Value) wH_Material.MD_ID = Convert.ToDecimal(dr["MD_ID"]);
            if (dr["MD_MCode"] != DBNull.Value) wH_Material.MD_MCode = Convert.ToString(dr["MD_MCode"]);
            if (dr["MD_Name"] != DBNull.Value) wH_Material.MD_Name = Convert.ToString(dr["MD_Name"]);
            if (dr["MD_Spec"] != DBNull.Value) wH_Material.MD_Spec = Convert.ToString(dr["MD_Spec"]);
            if (dr["MD_Barcode"] != DBNull.Value) wH_Material.MD_Barcode = Convert.ToString(dr["MD_Barcode"]);
            if (dr["MD_Group"] != DBNull.Value) wH_Material.MD_Group = Convert.ToString(dr["MD_Group"]);
            if (dr["MD_Group_Temp"] != DBNull.Value) wH_Material.MD_Group_Temp = Convert.ToString(dr["MD_Group_Temp"]);
            if (dr["MD_iType"] != DBNull.Value) wH_Material.MD_iType = Convert.ToString(dr["MD_iType"]);
            if (dr["MD_PriceList"] != DBNull.Value) wH_Material.MD_PriceList = Convert.ToDecimal(dr["MD_PriceList"]);
            if (dr["MD_Unit"] != DBNull.Value) wH_Material.MD_Unit = Convert.ToString(dr["MD_Unit"]);
            if (dr["MD_Num"] != DBNull.Value) wH_Material.MD_Num = Convert.ToDecimal(dr["MD_Num"]);
            if (dr["MD_LNum"] != DBNull.Value) wH_Material.MD_LNum = Convert.ToDecimal(dr["MD_LNum"]);
            if (dr["MD_TNum"] != DBNull.Value) wH_Material.MD_TNum = Convert.ToDecimal(dr["MD_TNum"]);
            if (dr["MD_Factory"] != DBNull.Value) wH_Material.MD_Factory = Convert.ToString(dr["MD_Factory"]);
            if (dr["MD_Units"] != DBNull.Value) wH_Material.MD_Units = Convert.ToString(dr["MD_Units"]);
            if (dr["MD_Bak"] != DBNull.Value) wH_Material.MD_Bak = Convert.ToString(dr["MD_Bak"]);
            if (dr["MD_DWName"] != DBNull.Value) wH_Material.MD_DWName = Convert.ToString(dr["MD_DWName"]);
            if (dr["MD_DWCode"] != DBNull.Value) wH_Material.MD_DWCode = Convert.ToString(dr["MD_DWCode"]);
            if (dr["Stat"] != DBNull.Value) wH_Material.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Material.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Material.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Material.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MD_UDEF1"] != DBNull.Value) wH_Material.MD_UDEF1 = Convert.ToString(dr["MD_UDEF1"]);
            if (dr["MD_UDEF2"] != DBNull.Value) wH_Material.MD_UDEF2 = Convert.ToString(dr["MD_UDEF2"]);
            if (dr["MD_UDEF3"] != DBNull.Value) wH_Material.MD_UDEF3 = Convert.ToString(dr["MD_UDEF3"]);
            if (dr["MD_UDEF4"] != DBNull.Value) wH_Material.MD_UDEF4 = Convert.ToString(dr["MD_UDEF4"]);
            if (dr["MD_UDEF5"] != DBNull.Value) wH_Material.MD_UDEF5 = Convert.ToString(dr["MD_UDEF5"]);
            if (dr["MD_TechCode"] != DBNull.Value) wH_Material.MD_TechCode = Convert.ToString(dr["MD_TechCode"]);
            ret.Add(wH_Material);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的物料主数据 WH_Material对象(即:一条记录
      /// </summary>
      public List<WH_Material> GetAll()
      {
         List<WH_Material> ret = new List<WH_Material>();
         string sql = "SELECT  MD_ID,MD_MCode,MD_Name,MD_Spec,MD_Barcode,MD_Group,MD_Group_Temp,MD_iType,MD_PriceList,MD_Unit,MD_Num,MD_LNum,MD_TNum,MD_Factory,MD_Units,MD_Bak,MD_DWName,MD_DWCode,Stat,CreateDate,UpdateDate,DeleteDate,MD_UDEF1,MD_UDEF2,MD_UDEF3,MD_UDEF4,MD_UDEF5,MD_TechCode FROM WH_Material where 1=1 AND ((Stat is null) or (Stat=0) ) order by MD_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Material wH_Material = new WH_Material();
            if (dr["MD_ID"] != DBNull.Value) wH_Material.MD_ID = Convert.ToDecimal(dr["MD_ID"]);
            if (dr["MD_MCode"] != DBNull.Value) wH_Material.MD_MCode = Convert.ToString(dr["MD_MCode"]);
            if (dr["MD_Name"] != DBNull.Value) wH_Material.MD_Name = Convert.ToString(dr["MD_Name"]);
            if (dr["MD_Spec"] != DBNull.Value) wH_Material.MD_Spec = Convert.ToString(dr["MD_Spec"]);
            if (dr["MD_Barcode"] != DBNull.Value) wH_Material.MD_Barcode = Convert.ToString(dr["MD_Barcode"]);
            if (dr["MD_Group"] != DBNull.Value) wH_Material.MD_Group = Convert.ToString(dr["MD_Group"]);
            if (dr["MD_Group_Temp"] != DBNull.Value) wH_Material.MD_Group_Temp = Convert.ToString(dr["MD_Group_Temp"]);
            if (dr["MD_iType"] != DBNull.Value) wH_Material.MD_iType = Convert.ToString(dr["MD_iType"]);
            if (dr["MD_PriceList"] != DBNull.Value) wH_Material.MD_PriceList = Convert.ToDecimal(dr["MD_PriceList"]);
            if (dr["MD_Unit"] != DBNull.Value) wH_Material.MD_Unit = Convert.ToString(dr["MD_Unit"]);
            if (dr["MD_Num"] != DBNull.Value) wH_Material.MD_Num = Convert.ToDecimal(dr["MD_Num"]);
            if (dr["MD_LNum"] != DBNull.Value) wH_Material.MD_LNum = Convert.ToDecimal(dr["MD_LNum"]);
            if (dr["MD_TNum"] != DBNull.Value) wH_Material.MD_TNum = Convert.ToDecimal(dr["MD_TNum"]);
            if (dr["MD_Factory"] != DBNull.Value) wH_Material.MD_Factory = Convert.ToString(dr["MD_Factory"]);
            if (dr["MD_Units"] != DBNull.Value) wH_Material.MD_Units = Convert.ToString(dr["MD_Units"]);
            if (dr["MD_Bak"] != DBNull.Value) wH_Material.MD_Bak = Convert.ToString(dr["MD_Bak"]);
            if (dr["MD_DWName"] != DBNull.Value) wH_Material.MD_DWName = Convert.ToString(dr["MD_DWName"]);
            if (dr["MD_DWCode"] != DBNull.Value) wH_Material.MD_DWCode = Convert.ToString(dr["MD_DWCode"]);
            if (dr["Stat"] != DBNull.Value) wH_Material.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Material.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Material.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Material.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["MD_UDEF1"] != DBNull.Value) wH_Material.MD_UDEF1 = Convert.ToString(dr["MD_UDEF1"]);
            if (dr["MD_UDEF2"] != DBNull.Value) wH_Material.MD_UDEF2 = Convert.ToString(dr["MD_UDEF2"]);
            if (dr["MD_UDEF3"] != DBNull.Value) wH_Material.MD_UDEF3 = Convert.ToString(dr["MD_UDEF3"]);
            if (dr["MD_UDEF4"] != DBNull.Value) wH_Material.MD_UDEF4 = Convert.ToString(dr["MD_UDEF4"]);
            if (dr["MD_UDEF5"] != DBNull.Value) wH_Material.MD_UDEF5 = Convert.ToString(dr["MD_UDEF5"]);
            if (dr["MD_TechCode"] != DBNull.Value) wH_Material.MD_TechCode = Convert.ToString(dr["MD_TechCode"]);
            ret.Add(wH_Material);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
