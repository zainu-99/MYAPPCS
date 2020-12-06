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
            var query = "select id,concat(nama,' - ',remark) as info from Groups";
            ComboBoxGroup.DataSource = SqlService.GetDataTable(query);
            ComboBoxGroup.ValueMember = "id";
            ComboBoxGroup.DisplayMember = "info";
        }
        void ShowGroupLevel()
        {
            var query = "select '' as id,'No Parent' as info union all select a.id,concat(b.nama,' - ',a.remark) as info from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent  where a.ID <> " + id_group_level + " and (a.id_parent is null or a.id_parent <> " + id_group_level + ")";
            ComboBoxParentGroup.DataSource = SqlService.GetDataTable(query);
            ComboBoxParentGroup.ValueMember = "id";
            ComboBoxParentGroup.DisplayMember = "info";
        }
        void ShowDataGridView(String txtSearch)
        {
            var dt = new DataTable();
            String query = "select a.id,b.nama,a.remark,concat(d.nama,' - ',c.remark) as parent,a.id_group,a.id_parent from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent left join Groups as d on c.id_group=d.id where a.remark like '%" + txtSearch + "%' order by b.nama";
            dt = SqlService.GetDataTable(query);
            dgv.Rows.Clear();
            GetGroupLevel(dt, " is Null", "");
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        void GetGroupLevel(DataTable DT, String idParent, String levelTag)
        {
            foreach (DataRow dtrow in DT.Select("id_parent  " + idParent))
            {
                AddToDgv(dtrow, levelTag + "* ");
                if (DT.Select("id_parent = " + dtrow[0]).Count() > 0)
                    GetGroupLevel(DT, "= " + dtrow[0], levelTag + "-----");
            }

        }

        void AddToDgv(DataRow dr, String levelTag)
        {
            dgv.Rows.Add(dr[0], levelTag + dr[1], dr[2], dr[3], dr[4], dr[5]);
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
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDataGridView(TextBoxSearch.Text);
        }
    }
}
