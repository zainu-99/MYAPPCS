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
    public partial class FormGroupLevel : Form
    {
        String id_group_level = "-1";
        DataTable dt = new DataTable();
        int ctr = 0;
        public FormGroupLevel()
        {
            InitializeComponent();
        }

        private void FormGroupLevel_Load(object sender, EventArgs e)
        {
            Reload();
        }

        void ShowGroup()
        {
            var query = "select id,concat(name,' - ',remark) as info from Groups";
            ComboBoxGroup.DataSource = SqlService.GetDataTable(query);
            ComboBoxGroup.ValueMember = "id";
            ComboBoxGroup.DisplayMember = "info";
        }
        void ShowGroupLevel()
        {
            var query = "select '' as id,'No Parent' as info union all select a.id,concat(b.name,' - ',a.remark) as info from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent  where a.ID <> " + id_group_level + " and (a.id_parent is null or a.id_parent <> " + id_group_level + ")";
            ComboBoxParentGroup.DataSource = SqlService.GetDataTable(query);
            ComboBoxParentGroup.ValueMember = "id";
            ComboBoxParentGroup.DisplayMember = "info";
        }
        void ShowDataGridView(String txtSearch)
        {
            String query = "select a.id,b.name,a.remark,concat(d.name,' - ',c.remark) as parent,a.id_group,a.id_parent,'Role Group' as RoleGrouop from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent left join Groups as d on c.id_group=d.id where a.remark like '%" + txtSearch + "%' order by b.name";
            dt = SqlService.GetDataTable(query);
            dgv.Rows.Clear();
            GetGroupLevel(dt, "id_parent is Null", "");
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        void GetGroupLevel(DataTable DT, String filter, String levelTag)
        {
            foreach (DataRow dtrow in DT.Select(filter))
            {
                AddToDgv(dtrow, levelTag + "➧ ");
                GetGroupLevel(DT, "id_parent = " + dtrow[0], levelTag + "     ");
            }
        }

        void AddToDgv(DataRow dr, String levelTag)
        {
            dgv.Rows.Add(dr[0], levelTag + dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
        }

        void Reload()
        {
            ShowGroup();
            ShowGroupLevel();
            GroupBoxInputData.Enabled = false;
            ShowDataGridView("");
            TextBoxRemark.Text = "";
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            GroupBoxInputData.Enabled = true;
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!ButtonEdit.Enabled)
            {
                if (ComboBoxParentGroup.Text != "No Parent")
                    SqlService.ExecuteQuery("insert into GroupLevel (id_group,id_parent,remark) values('" + Utilities.ReplaceQuot(ComboBoxGroup.SelectedValue.ToString().ToString()) + "','" + Utilities.ReplaceQuot(ComboBoxParentGroup.SelectedValue.ToString().ToString()) + "','" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "')");
                else
                    SqlService.ExecuteQuery("insert into GroupLevel (id_group,remark) values('" + Utilities.ReplaceQuot(ComboBoxGroup.SelectedValue.ToString().ToString()) + "','" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "')");
            }
            else
            {
                if (ComboBoxParentGroup.Text != "No Parent")
                    SqlService.ExecuteQuery("update GroupLevel set id_group='" + Utilities.ReplaceQuot(ComboBoxGroup.SelectedValue.ToString()) + "',id_parent='" + Utilities.ReplaceQuot(ComboBoxParentGroup.SelectedValue.ToString()) + "',remark ='" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "' where id = '" + id_group_level + "'");
                else
                    SqlService.ExecuteQuery("update GroupLevel set id_group='" + Utilities.ReplaceQuot(ComboBoxGroup.SelectedValue.ToString()) + "',id_parent=null,remark ='" + Utilities.ReplaceQuot(TextBoxRemark.Text) + "' where id = '" + id_group_level + "'");
            }
            Reload();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var query = "delete from GroupLevel where id ='" + id_group_level + "'";
                SqlService.ExecuteQuery(query);
                LogApp.Delete("users", DgvRowToString.Generate(dgv, dgv.CurrentRow.Index), "");
                Reload();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxInputData.Enabled = false;
            id_group_level = dgv.CurrentRow.Cells[0].Value.ToString();
            TextBoxRemark.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            ComboBoxGroup.SelectedValue = dgv.CurrentRow.Cells[4].Value.ToString();
            ShowGroupLevel();
            if (dgv.CurrentRow.Cells[5].Value.ToString() == "")
                ComboBoxParentGroup.Text = "No Parent";
            else
                ComboBoxParentGroup.SelectedValue = dgv.CurrentRow.Cells[5].Value;
            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonSave.Enabled = true;
            if((e.ColumnIndex == dgv.Columns["RoleGroup"].Index) )
            {
                var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
                formMain.ShowFormToTabPage(new FormRoleGroup());
                var formRoleGroup = (formMain.GetFormInTabControl("FormRoleGroup") as FormRoleGroup);
                formRoleGroup.textBoxGroupLevel.Text = dt.Rows[dgv.CurrentRow.Index].ItemArray[1].ToString();
                formRoleGroup.textBoxGroupLevel.Text += "-" + dgv.CurrentRow.Cells[2].Value.ToString();
                formRoleGroup.textBoxGroupLevel.Tag = dgv.CurrentRow.Cells[0].Value;
            }
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                for (int i = ctr; i < dgv.Rows.Count - 1; i++)
                {
                    ctr = i + 1;
                    if (dgv.Rows[i].Cells["Group"].Value.ToString().ToLower().Contains(TextBoxSearch.Text) || dgv.Rows[i].Cells["Remark"].Value.ToString().ToLower().Contains(TextBoxSearch.Text) || dgv.Rows[i].Cells["Parent"].Value.ToString().ToLower().Contains(TextBoxSearch.Text))
                    {
                        dgv.Rows[i].Selected = true;
                        dgv.FirstDisplayedScrollingRowIndex = i;
                        return;
                    }
                }
                ctr = 0;
            }
        }
    }
}
