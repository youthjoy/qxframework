using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace QX.Comm
{
    public class FileUpload
    {
         /// <summary>
         /// 
         /// </summary>
         /// <param name="qqfile">文件名称</param>
         /// <param name="path">文件存储路径</param>
         /// <param name="current">web请求上下文</param>
         /// <returns></returns>
        public static string UploadFile(string qqfile,string path,HttpContext current)
        {
            #region 文件上传
            bool flag = true;
           // var path = Server.MapPath("~/Upload");
            var file = string.Empty;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {
                var stream = current.Request.InputStream;
                if (String.IsNullOrEmpty(current.Request["qqfile"]))
                {
                    // IE
                    System.Web.HttpPostedFile postedFile = current.Request.Files[0];
                    stream = postedFile.InputStream;
                    file = Path.Combine(path, System.IO.Path.GetFileName(current.Request.Files[0].FileName));
                }
                else
                {
                    //Webkit, Mozilla
                    file = Path.Combine(path, qqfile);
                }

                var buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                System.IO.File.WriteAllBytes(file, buffer);
            }
            catch (Exception ex)
            {
                flag = false;
                file = string.Empty;   
            }

            return file;


         #endregion
        }
    }
}
