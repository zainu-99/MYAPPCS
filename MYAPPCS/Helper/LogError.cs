using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS.Helper
{
    class LogError
    {
        public static void Write(String strError)
        {
            String sPath = "";
        if( ! Directory.Exists(Application.ExecutablePath + "\\LogError") )
                {
                Directory.CreateDirectory(Application.ExecutablePath + "\\LogError");
            }
            sPath = Application.ExecutablePath + "\\LogError" + DateTime.Now.ToString("yyyyMMdd") + "LogError.txt";
            File.AppendAllText(sPath, DateTime.Now.ToString("yyyyMMdd") + "   " + strError + " - " + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + "-" + "" + "-" + MYAPPCS.Properties.Settings.Default.id_user + " " + System.Environment.NewLine);
        }
        public static void Insert(String action, String messageError, String Note)
        {
            SqlService.ExecuteQuery("insert into ErrorReport ([Action],MsgError,[Datetime],Note,UserID) values('" + action + "','" + Utilities.ReplaceQuot(messageError) + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + " - " + "" + " - " + Note + "','" + MYAPPCS.Properties.Settings.Default.id_user + "')");
        }
    }
}
