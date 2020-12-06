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
    public partial class FormRole : Form
    {
        String id_role = "";
        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            Reload();
        }
        void Reload()
        {
            GroupBoxInputData.Enabled = false;
            ShowDataGridView("");
            TextBoxRole.Text = "";
            TextBoxRemark.Text = "";
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = false;
            id_role = "";
        }
        void ShowDataGridView(String txtSearch)
        {
            String query = "select * from Roles where name like '%" + txtSearch + "%' order by address,name asc";
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            GroupBoxInputData.Enabled = true;
            TextBoxRole.Text = "";
            TextBoxRemark.Text = "";
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = true;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            GroupBoxInputData.Enabled = true;
            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = true;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var query = "delete from Roles where id = '" + id_role + "'";
                SqlService.ExecuteQuery(query);
                LogApp.Delete("users", DgvRowToString.Generate(dgv, dgv.CurrentRow.Index), "");
                Reload();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!ButtonEdit.Enabled)
                SqlService.ExecuteQuery("insert into Roles (name,address)values('" + Utilities.ReplaceQuot(TextBoxRole.Text) + "','" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "')");
            else
                SqlService.ExecuteQuery("update Roles set name='" + Utilities.ReplaceQuot(TextBoxRole.Text) + "',address='" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "' where id = '" + id_role + "'");
            Reload();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxInputData.Enabled = false;
            id_role = dgv.CurrentRow.Cells[0].Value.ToString();
            TextBoxRole.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            TextBoxRemark.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonSave.Enabled = true;
        }

        private void ButtonRoleGroup_Click(object sender, EventArgs e)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            formMain.ShowFormToPanel(new FormRoleGroup());
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDataGridView(TextBoxSearch.Text);
        }
    }
}
