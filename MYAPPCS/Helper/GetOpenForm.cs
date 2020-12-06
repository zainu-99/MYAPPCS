using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS.Helper
{
    class GetOpenForm
    {
        public static Form GetForm(string formName)
        {
            var frm = new Form();
            foreach(Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    frm = form;
                    break;
                }
            }
            return frm;
        }
    }
}
