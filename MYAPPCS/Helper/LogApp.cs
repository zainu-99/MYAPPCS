using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAPPCS.Helper
{
    class LogApp
    {
        public static void Show(String TableName, String Note)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            SqlService.ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Select','" + Utilities.ReplaceQuot(TableName) + "','-','-','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + " - " + formMain.FormActive + " - " + Utilities.ReplaceQuot(Note) + "','" + MYAPPCS.Properties.Settings.Default.id_user + "')");
        }
        public static void Insert(String TableName, String Data, String Note)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            SqlService.ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Insert','" + Utilities.ReplaceQuot(TableName) + "','-','" + Utilities.ReplaceQuot(Data) + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + " - " + formMain.FormActive + " - " + Utilities.ReplaceQuot(Note) + "','" + MYAPPCS.Properties.Settings.Default.id_user + "')");
        }
        public static void Update(String TableName, String DataBefore, String DataAfter, String Note)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            SqlService.ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Update','" + Utilities.ReplaceQuot(TableName) + "','" + Utilities.ReplaceQuot(DataBefore) + "','" + Utilities.ReplaceQuot(DataAfter) + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + " - " + formMain.FormActive + " - " + Utilities.ReplaceQuot(Note) + "','" + MYAPPCS.Properties.Settings.Default.id_user + "')");
        }
        public static void Delete(String TableName, String data, String Note)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            SqlService.ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Delete','" + Utilities.ReplaceQuot(TableName) + "','" + Utilities.ReplaceQuot(data) + "','-','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + " - " + formMain.FormActive + " - " + Utilities.ReplaceQuot(Note) + "','" + MYAPPCS.Properties.Settings.Default.id_user + "')");
        }
        public static void Login()
        {
            SqlService.ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Login','-','-','-','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + "','" + MYAPPCS.Properties.Settings.Default.id_user + "')");
        }
        public static void Logout()
        {
            SqlService.ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Logout','-','-','-','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + GetComputerInfo.GetHostName() + ":" + GetComputerInfo.GetIPAddress() + "','" + MYAPPCS.Properties.Settings.Default.id_user + "')");
        }
    }
}
