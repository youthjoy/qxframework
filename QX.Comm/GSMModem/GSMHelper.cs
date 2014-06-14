using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using QX.IMessage;
namespace QX.Common
{
    public class GSMHelper
    {
        TcpChannel tcp = null;

        public GSMHelper()
        {
            tcp = new TcpChannel();
            ChannelServices.RegisterChannel(tcp, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mobile">发送号码</param>
        /// <param name="content">发送内容</param>
        public static void SendMessage(string mobile, string content)
        {
            try
            {

                //TcpChannel tcp = new TcpChannel();

                string url = System.Configuration.ConfigurationSettings.AppSettings["MessageHost"];
                MessageHelper obj1 = (MessageHelper)Activator.GetObject(
                typeof(MessageHelper),
                url);

                if (obj1 == null)
                {

                    //Alert.Show(
                    //   "连接TCP服务器失败");
                }

                obj1.SendMsg(mobile, content);
            }
            catch (Exception e)
            { 
                
            }
        }
    }
}
