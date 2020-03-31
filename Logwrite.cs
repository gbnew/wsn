using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Core;
using log4net;

namespace WaterMeterSync
{
 

    public static class Logwrite
    {
        public static ILog logError = LogManager.GetLogger("ErrorLog");

        public static ILog logInfor = LogManager.GetLogger("InforLog");
        
        /// <summary>
        /// 记录错误日志
        /// </summary>
        public static void writeLog(string infor, Exception ex)
        {
            if (logError.IsErrorEnabled)
            {
                logError.Error(infor, ex);
            }
        }
        /// <summary>
        /// 记录普通日志
        /// </summary>
        public static void writeLog(string infor)
        {
            if (logInfor.IsInfoEnabled)
            {
                logInfor.Info(infor);
            }
        }
    }
}