using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace QX.Comm
{
    public class FileHelper
    {
        public List<string> FileList { get; set; }

        /// <summary>
        /// 获取文件下所有文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="pattern">过滤条件(*.js)</param>
        public void GetFilesByDirectory(string path,string pattern)
        {
            List<string> arr = new List<string>();
            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                DirectoryInfo[] SubDirectories = directory.GetDirectories();
                FileInfo[] Files = directory.GetFiles(pattern);
                foreach (FileInfo item in Files)
                {
                    arr.Add(item.FullName);
                }
                if (FileList==null)
                {
                    FileList = new List<string>();                    
                }
                FileList.AddRange(arr);
                if (SubDirectories.Count() > 0)
                {
                    foreach (DirectoryInfo obj in SubDirectories)
                    {
                        GetFilesByDirectory(obj.FullName,pattern);
                    }
                }
            }           
        }
    }
}
