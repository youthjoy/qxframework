using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;

namespace QX.Comm
{
    /// <summary>
    /// 网络状况检查类
    /// </summary>
    public  class Net
    {

         private static bool IsConnectionSuccessful = false;
         private static Exception socketexception;
         private static ManualResetEvent TimeoutObject = new ManualResetEvent(false);

         public static bool CheckConn()
         {
            //return true;
            return ConnValidate(ConfigHelper.GetDBHost(), 1433, 500);
         }
 
         /// <summary>
         /// 验证连接指定主机的端口
         /// </summary>
         /// <param name="host">主机IP或名称</param>
         /// <param name="port">端口号</param>
         /// <param name="timeoutMSec">超时时长(毫秒)</param>
         /// <returns>bool</returns>
         public static bool ConnValidate(string host, int port, int timeoutMSec)
         {
                                      
             bool ret = false;

             //本地调试时跳过服务器检查
             if (!string.IsNullOrEmpty(host) && !Utils.Utils.IsIP(host))
             {
                 return true;
             }
 
             TimeoutObject.Reset();
             socketexception = null;
 
             TcpClient tcpclient = new TcpClient();
 
             tcpclient.BeginConnect(host, port, new AsyncCallback(CallBackMethod), tcpclient);
             if (TimeoutObject.WaitOne(timeoutMSec, false))
             {
                 if (IsConnectionSuccessful)
                 {
                     ret = true;
                     tcpclient.Client.Close();
                 }
                 else
                 {
                     //不用抛出异常，根据ret判断连接成功与否
                     //throw socketexception;
                 }
             }
             else
             {
                 //不用抛出异常，根据ret判断连接成功与否
                 //throw new TimeoutException("TimeOut Exception");
             }
 
             tcpclient.Close();
             return ret;
         }
 
         private static void CallBackMethod(IAsyncResult asyncresult)
         {
             try
             {
                 IsConnectionSuccessful = false;
                 TcpClient tcpclient = asyncresult.AsyncState as TcpClient;
 
                 if (tcpclient.Client != null)
                 {
                     tcpclient.EndConnect(asyncresult);
                     IsConnectionSuccessful = true;
                 }
             }
             catch (Exception ex)
             {
                 IsConnectionSuccessful = false;
                 socketexception = ex;
             }
             finally
             {
                 TimeoutObject.Set();
             }
         }
     }   

}