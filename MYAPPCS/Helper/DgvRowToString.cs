using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS.Helper
{
    class DgvRowToString
    {
        public static String Generate(DataGridView dgv, int indexRow)
        {
            String result = "";
        foreach(DataGridViewCell cell in dgv.Rows[indexRow].Cells)
            if  (cell.GetType() != typeof(DataGridViewImageCell))
                result = result + dgv.Columns[cell.ColumnIndex].Name.ToString() + ":"  + cell.Value.ToString() + ";    ";
        return result;
        }
    }
}
