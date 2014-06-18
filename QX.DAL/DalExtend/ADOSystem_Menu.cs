using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using QX.DataAcess;

namespace QX.DAL
{
   public partial class ADOSystem_Menu
   {
       public List<System_Menu> GetAllShortcut()
       {           
           List<System_Menu> ret = new List<System_Menu>();
           string sql = "SELECT  Menu_ID,Menu_Code,Menu_Title,Menu_Location,Menu_PCode,Menu_Enable,Menu_Url,Menu_Order,Stat,Menu_Icon,Shortcut FROM System_Menu where 1=1 AND ((Stat is null) or (Stat=0) ) and (Shortcut!=0) ORDER BY Shortcut  ";
           SqlDataReader dr = null;
           try
           {
               dr = (SqlDataReader)idb.ReturnReader(sql);
               while (dr.Read())
               {
                   System_Menu system_Menu = new System_Menu();
                   if (dr["Menu_ID"] != DBNull.Value) system_Menu.Menu_ID = Convert.ToInt32(dr["Menu_ID"]);
                   if (dr["Menu_Code"] != DBNull.Value) system_Menu.Menu_Code = Convert.ToString(dr["Menu_Code"]);
                   if (dr["Menu_Title"] != DBNull.Value) system_Menu.Menu_Title = Convert.ToString(dr["Menu_Title"]);
                   if (dr["Menu_Location"] != DBNull.Value) system_Menu.Menu_Location = Convert.ToString(dr["Menu_Location"]);
                   if (dr["Menu_PCode"] != DBNull.Value) system_Menu.Menu_PCode = Convert.ToString(dr["Menu_PCode"]);
                   if (dr["Menu_Enable"] != DBNull.Value) system_Menu.Menu_Enable = Convert.ToString(dr["Menu_Enable"]);
                   if (dr["Menu_Url"] != DBNull.Value) system_Menu.Menu_Url = Convert.ToString(dr["Menu_Url"]);
                   if (dr["Menu_Order"] != DBNull.Value) system_Menu.Menu_Order = Convert.ToInt32(dr["Menu_Order"]);
                   if (dr["Stat"] != DBNull.Value) system_Menu.Stat = Convert.ToInt32(dr["Stat"]);
                   if (dr["Menu_Icon"] != DBNull.Value) system_Menu.Menu_Icon = Convert.ToString(dr["Menu_Icon"]);
                   if (dr["Shortcut"] != DBNull.Value) system_Menu.Shortcut = Convert.ToInt32(dr["Shortcut"]);
                   ret.Add(system_Menu);
               }
           }
           catch (System.Exception ex)
           {
               throw ex;
           }
           finally
           {
               dr.Close();
           }           
           
           return ret;
       }
       /// 上移
       /// </summary>
       /// <param name="id"></param>
       /// <param name="ln">LINENO</param>
       /// <param name="id1">类型/param>
       public static void sortUp(string id)
       {
           int id2 = 0;
           int ln2 = 0;
           string sql = " SELECT TOP 1 menu_id,Menu_Order FROM  system_menu WHERE Menu_Order<" + int.Parse(id.Split(',')[1]) + " AND Menu_Location='top' ORDER BY Menu_Order";
           
           SqlDataReader dr = null;
           try
           {              
              dr= DBOperator.GetInstance().ReturnReader(sql) as SqlDataReader;
              while (dr.Read())
              {
                  id2 = Convert.ToInt32(dr["menu_id"]);
                  ln2 = Convert.ToInt32(dr["Menu_Order"]);
              }
              if (!id2.Equals(0) || !ln2.Equals(0))
              {
                  string sql1 = "UPDATE system_menu SET [Menu_Order]=" + ln2 + " WHERE menu_id=" + int.Parse(id.Split(',')[0]);
                  string sql2 = "UPDATE system_menu SET [Menu_Order]=" + int.Parse(id.Split(',')[1]) + " WHERE menu_id=" + id2;
                  DBOperator.GetInstance().ExeCmd(sql1); DBOperator.GetInstance().ExeCmd(sql2);
              }
           }
           catch (System.Exception ex)
           {
               throw ex;
           }finally{
               dr.Close();
           }      

          
       }
       /// <summary>
       /// 下移
       /// </summary>
       /// <param name="id"></param>
       /// <param name="ln">LINENO</param>
       /// <param name="id1">类型/param>
       public static void sortDown(string id)
       {
           int id2 = 0;
           int ln2 = 0;
           string sql = " SELECT TOP 1 menu_id,Menu_Order FROM  system_menu WHERE Menu_Order>" + int.Parse(id.Split(',')[1]) + " AND Menu_Location='top' ORDER BY Menu_Order";
           SqlDataReader dr = null;
           try
           {
              dr= DBOperator.GetInstance().ReturnReader(sql) as SqlDataReader;
              while (dr.Read())
              {
                  id2 = Convert.ToInt32(dr["menu_id"]);
                  ln2 = Convert.ToInt32(dr["Menu_Order"]);
              }
              if (!id2.Equals(0) || !ln2.Equals(0))
              {
                  string sql1 = "UPDATE system_menu SET [Menu_Order]=" + ln2 + " WHERE menu_id=" + int.Parse(id.Split(',')[0]);
                  string sql2 = "UPDATE system_menu SET [Menu_Order]=" + int.Parse(id.Split(',')[1]) + " WHERE menu_id=" + id2;
                  DBOperator.GetInstance().ExeCmd(sql1); DBOperator.GetInstance().ExeCmd(sql2);
              }
           }
           catch (System.Exception ex)
           {
               throw ex;
           }
           finally
           {
               dr.Close();
           }
           
       }
    }
}
