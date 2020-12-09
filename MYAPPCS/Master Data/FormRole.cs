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
            ShowNavPageData();
            TextBoxRole.Text = "";
            TextBoxRemark.Text = "";
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = false;
            id_role = "";
            CheckBoxView.Checked = false;
            CheckBoxAdd.Checked = false;
            CheckBoxEdit.Checked = false;
            CheckBoxDelete.Checked = false;
        }
        void ShowDataGridView()
        {
            String query = "select * from Roles where name like '%" + TextBoxSearch.Text + "%' order by remark asc OFFSET " + bindingSourcePaging.Position * Int32.Parse(ComboBoxEntries.Text) + " ROWS FETCH NEXT " + ComboBoxEntries.Text + " ROWS ONLY;";
            dgv.DataSource = SqlService.GetDataTable(query);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["name"].HeaderText = "Name";
            dgv.Columns["remark"].HeaderText = "Remark";
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
            {
                if (SqlService.ExecuteQuery("insert into Roles (name,remark,AccessView,AccessAdd,AccessEdit,AccessDelete,AccessPrint,AccessCustom)values('" + Utilities.ReplaceQuot(TextBoxRole.Text) + "','" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "','" + CheckBoxView.Checked + "','" + CheckBoxAdd.Checked + "','" + CheckBoxEdit.Checked + "','" + CheckBoxDelete.Checked + "')").Success)
                {
                    MessageBox.Show("Role Name Must Be Unique");
                }
            }
            else
                SqlService.ExecuteQuery("update Roles set name='" + Utilities.ReplaceQuot(TextBoxRole.Text) + "',remark='" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "',AccessView = '" + CheckBoxView.Checked + "',AccessAdd = '" + CheckBoxAdd.Checked + "',AccessEdit = '" + CheckBoxEdit.Checked + "',AccessDelete = '" + CheckBoxDelete.Checked + "',AccessPrint = '" + CheckBoxPrint.Checked + "',AccessCustom = '" + CheckBoxCustom.Checked + "' where id = '" + id_role + "'");
            Reload();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxInputData.Enabled = false;
            id_role = dgv.CurrentRow.Cells[0].Value.ToString();
            TextBoxRole.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            TextBoxRemark.Text = dgv.CurrentRow.Cells[2].Value.ToString();

            CheckBoxView.Checked = (DBNull.Value.Equals(dgv.CurrentRow.Cells["AccessView"].Value) ? false : (bool)dgv.CurrentRow.Cells["AccessView"].Value);
            CheckBoxAdd.Checked = (DBNull.Value.Equals(dgv.CurrentRow.Cells["AccessAdd"].Value) ? false : (bool)dgv.CurrentRow.Cells["AccessAdd"].Value);
            CheckBoxEdit.Checked = (DBNull.Value.Equals(dgv.CurrentRow.Cells["AccessEdit"].Value) ? false : (bool)dgv.CurrentRow.Cells["AccessEdit"].Value);
            CheckBoxDelete.Checked = (DBNull.Value.Equals(dgv.CurrentRow.Cells["AccessDelete"].Value) ? false : (bool)dgv.CurrentRow.Cells["AccessDelete"].Value);
            CheckBoxPrint.Checked = (DBNull.Value.Equals(dgv.CurrentRow.Cells["AccessPrint"].Value) ? false : (bool)dgv.CurrentRow.Cells["AccessPrint"].Value);
            CheckBoxCustom.Checked = (DBNull.Value.Equals(dgv.CurrentRow.Cells["AccessCustom"].Value) ? false : (bool)dgv.CurrentRow.Cells["AccessCustom"].Value);

            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonSave.Enabled = true;
        }

        private void ButtonRoleGroup_Click(object sender, EventArgs e)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            formMain.ShowFormToTabPage(new FormRoleGroup());
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowNavPageData();
        }

        private void ComboBoxEntries_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void ShowNavPageData()
        {
            dgv.DataSource = null;
            var query = "select count(id) from Roles where name like '%" + TextBoxSearch.Text + "%'";
            var datatabel = SqlService.GetDataTable(query);
            var dtable = new DataTable();
            var dc = new DataColumn();
            dc.ColumnName = "Paging";
            dc.DataType = typeof(string);
            dtable.Columns.Add(dc);
            var count = Math.Ceiling((Double.Parse(datatabel.Rows[0].ItemArray[0].ToString()) / Int32.Parse(ComboBoxEntries.Text)));
            for (int i = 0; i < count; i++)
            {
                DataRow dr = dtable.NewRow();
                dr[0] = 1;
                dtable.Rows.Add(dr);
            }
            bindingSourcePaging.DataSource = dtable;
            BindingNavigatorPaging.BindingSource = bindingSourcePaging;
        if(bindingSourcePaging.Position >= 0 )
            {
                ShowDataGridView();
            }
        }

        private void bindingSourcePaging_PositionChanged(object sender, EventArgs e)
        {
            if (bindingSourcePaging.Count > 0 )
            {
                ShowDataGridView();
            }
        }

        private void ComboBoxEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNavPageData();
        }
    }
}
