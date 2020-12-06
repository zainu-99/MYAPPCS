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
    public partial class FormUserDataPopUp : Form
    {
        private TextBox tb;
        public FormUserDataPopUp()
        {
            InitializeComponent();
        }

        private void FormUserDataPopUp_Load(object sender, EventArgs e)
        {
            ShowDataGridView("");
        }
        void ShowDataGridView(String txtSearch)
        {
            String query = "select id,userid,name,nohp,email,address,status,gender from users where name like '%" + txtSearch + "%' order by name asc";
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
        public void SetPassingTextBox(TextBox tb)
        {
            this.tb = tb;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDataGridView(TextBoxSearch.Text);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb.Tag = dgv.CurrentRow.Cells[0].Value;
            tb.Text = dgv.CurrentRow.Cells[1].Value.ToString() + " - " + dgv.CurrentRow.Cells[2].Value.ToString();
            Close();
        }
    }
}
