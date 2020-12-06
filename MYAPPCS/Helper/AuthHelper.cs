using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAPPCS.Helper
{
    class AuthHelper
    {
        static DataTable GetAuthUser = new DataTable();

        public static void GetUserAuth()
        {
            GetAuthUser = SqlService.GetDataTable("select b.name,allow_view,allow_add,allow_update,allow_delete,allow_print,allow_custom_access from UserRole a left join Roles b on a.id_role = b.id where a.id_user=" + MYAPPCS.Properties.Settings.Default.id_user);
        }

        public static Boolean GetAutUserView(String RoleName)
        {
            if(GetAuthUser.Select(" name = '" + RoleName + "' and allow_view=1 ").Count() > 0)
                return true;
            else
                return false;
        }

        public static Boolean GetAutUserAdd(String RoleName)
        {
            if (GetAuthUser.Select("name = '" + RoleName + "' and allow_add=1").Count() > 0)
                return true;
            else
                return false;
        }

        public static Boolean GetAutUserEdit(String RoleName)
        {
            if (GetAuthUser.Select("name = '" + RoleName + "' and allow_update=1").Count() > 0)
                return true;
            else
                return false;
        }

        public static Boolean GetAutUserDelete(String RoleName)
        {
            if (GetAuthUser.Select("name = '" + RoleName + "' and allow_delete=1").Count() > 0)
                return true;
            else
                return false;
        }


    }
}
