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
    public partial class FormGroup : Form
    {
        String id_group = "";
        public FormGroup()
        {
            InitializeComponent();
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            Reload();
        }
        void Reload()
        {
            GroupBoxInputData.Enabled = false;
            ShowDataGridView("");
            TextBoxGroup.Text = "";
            TextBoxRemark.Text = "";
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = false;
            id_group = "";
        }
        void ShowDataGridView(String txtSearch)
        {
            String query = "select * from Groups where name like '%" + txtSearch + "%' order by name asc";
            dgv.DataSource = SqlService.GetDataTable(query);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["created_at"].Visible = false;
            dgv.Columns["updated_at"].Visible = false;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["name"].HeaderText = "Name";
            dgv.Columns["remark"].HeaderText = "Remark";
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
            TextBoxGroup.Text = "";
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
                var query = "delete from groups where id = '" + id_group + "'";
                SqlService.ExecuteQuery(query);
                LogApp.Delete("users", DgvRowToString.Generate(dgv, dgv.CurrentRow.Index), "");
                Reload();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!ButtonEdit.Enabled)
                SqlService.ExecuteQuery("insert into Groups (name,remark,created_at)values('" + Utilities.ReplaceQuot(TextBoxGroup.Text) + "','" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')");
            else
                SqlService.ExecuteQuery("update groups set name='" + Utilities.ReplaceQuot(TextBoxGroup.Text) + "',remark='" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "',updated_at ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' where id = '" + id_group + "'");
            Reload();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxInputData.Enabled = false;
            id_group = dgv.CurrentRow.Cells[0].Value.ToString();
            TextBoxGroup.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            TextBoxRemark.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonSave.Enabled = true;
        }

        private void ButtonGroupLevel_Click(object sender, EventArgs e)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            formMain.ShowFormToTabPage(new FormGroupLevel());
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDataGridView(TextBoxSearch.Text);
        }
    }
}
