using MYAPPCS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            ShowDataGridView("");
        }
        void ShowDataGridView(String txtSearch)
        {
            String query = "select Top " + ComboBoxLimit.Text + " a.Id,a.Action,a.TableName,a.DataBefore,a.DataAfter,a.Datetime,a.Note,concat(b.userid,'-',b.nama) as [User] from LogApp a left join Users b on a.UserId =b.ID where (convert(date,[Datetime])>='" + DateTimePickerStart.Value.ToString("yyyy-MM-dd") + "' and convert(date,[Datetime]) <= '" + DateTimePickerUntil.Value.ToString("yyyy-MM-dd") + "') and (a.Action like '%" + txtSearch + "%' or a.TableName like '%" + txtSearch + "%' or a.DataBefore like '%" + txtSearch + "%' or a.DataAfter like '%" + txtSearch + "%' or a.Note like '%" + txtSearch + "%' or b.nama like '%" + txtSearch + "%' ) order by a.Id desc";
            dgv.DataSource = SqlService.GetDataTable(query);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDataGridView(TextBoxSearch.Text);
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            ShowDataGridView("");
        }
    }
}
