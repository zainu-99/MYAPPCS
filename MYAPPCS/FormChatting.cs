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
    public partial class FormChatting : Form
    {
        public FormChatting()
        {
            InitializeComponent();
        }

        private void FormChatting_Load(object sender, EventArgs e)
        {
            ShowDataGridView("");
        }
        void ShowDataGridView(String txtSearch)
        {
            String query = "select id,userid,nama,nohp,email,alamat,status,gender from users where nama like '%" + txtSearch + "%' and status=1 order by nama asc";
            DataGridViewUser.DataSource = SqlService.GetDataTable(query);
            DataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewUser.RowHeadersVisible = false;
            DataGridViewUser.AllowUserToAddRows = false;
            DataGridViewUser.BorderStyle = BorderStyle.None;
            DataGridViewUser.EnableHeadersVisualStyles = false;
            DataGridViewUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewUser.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253);
            DataGridViewUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewUser.Columns[0].Visible = false;
            DataGridViewUser.Columns[1].HeaderCell.Value = "User Id";
            DataGridViewUser.Columns[2].HeaderCell.Value = "Nama";
            DataGridViewUser.Columns[3].Visible = false;
            DataGridViewUser.Columns[4].Visible = false;
            DataGridViewUser.Columns[5].Visible = false;
            DataGridViewUser.Columns[6].Visible = false;
            DataGridViewUser.Columns[7].Visible = false;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDataGridView(TextBoxSearch.Text);
        }

        private void DataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelSentTo.Text = "Send Message To : " + DataGridViewUser.CurrentRow.Cells[1].Value.ToString() + "-" + DataGridViewUser.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
