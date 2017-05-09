using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
using Cn.Infocell.Util.FileUtil;

namespace ReaderPDM.Test
{
    public class OutResult
    {
        public static void produce()
        {
            string strFullName = "";
            Encoding fileEncoding = TxtFileEncoding.GetEncoding(strFullName, Encoding.GetEncoding("GB2312"));//取得这txt文件的编码
            StreamReader sr = new StreamReader(strFullName, fileEncoding);//用该编码创建StreamReader


            
        }
    }
}
