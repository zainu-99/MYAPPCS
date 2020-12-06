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
    public partial class FormUserRole : Form
    {
        DataTable table;
        public FormUserRole()
        {
            InitializeComponent();
        }

        private void FormUserRole_Load(object sender, EventArgs e)
        {
            Reload();
        }

        void Reload()
        {
            ShowGroupLevel();
            showDataGridView("");
        }
        void ShowGroupLevel()
        {
            var query = "select a.id,concat(b.nama,' - ',a.remark) as info from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent";
            ComboBoxGroupLevel.DataSource = SqlService.GetDataTable(query);
            ComboBoxGroupLevel.ValueMember = "id";
            ComboBoxGroupLevel.DisplayMember = "info";
        }
        void showDataGridView(String txtSearch)
        {
            String query = "select a.*,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag + "' and allow_view= 1) is null,0,1) as allow_view,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag + "' and allow_add= 1) is null,0,1) as allow_add,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag + "' and allow_update= 1) is null,0,1) as allow_update,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag + "' and allow_delete= 1) is null,0,1) as allow_delete from Roles a left join (select * from UserRole where id_user=" + TextBoxUser.Tag + ") b on a.id = b.id_role left join Users c on b.id_user = c.id left join RoleGroupLevel d on a.id =d.id_role where d.id_group_level ='" + ComboBoxGroupLevel.SelectedValue + "' and (a.nama like '%" + txtSearch + "%' or a.remark like '%" + txtSearch + "%') order by a.remark,a.nama";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            table = SqlService.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                dgv.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                if (((int)row[3]) == 0 && CheckBoxAllView.Checked)
                {
                    CheckBoxAllView.Checked = false;
                }
                if (((int)row[4]) == 0 && CheckBoxAllAdd.Checked)
                {
                    CheckBoxAllAdd.Checked = false;
                }
                if (((int)row[5]) == 0 && CheckBoxAllEdit.Checked)
                {
                    CheckBoxAllEdit.Checked = false;
                }
                if (((int)row[6]) == 0 && CheckBoxAllDelete.Checked)
                {
                    CheckBoxAllDelete.Checked = false;
                }
            }
        }

        private void TextBoxUser_Click(object sender, EventArgs e)
        {
            var popupuser = new FormUserDataPopUp();
            popupuser.SetPassingTextBox(TextBoxUser);
            popupuser.ShowDialog();
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void ComboBoxGroupLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            showDataGridView("");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TextBoxUser.Text != "")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex != 0 && e.ColumnIndex != 1 && e.ColumnIndex != 2)
                    if ((int)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == 0)
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                    else
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                CheckedCheckBox(e.RowIndex);
                CheckBoxAllView.Checked = true;
                CheckBoxAllAdd.Checked = true;
                CheckBoxAllEdit.Checked = true;
                CheckBoxAllDelete.Checked = true;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (((int)row.Cells[3].Value) == 0 && CheckBoxAllView.Checked)
                    {
                        CheckBoxAllView.Checked = false;
                    }
                    if (((int)row.Cells[4].Value) == 0 && CheckBoxAllAdd.Checked)
                    {
                        CheckBoxAllAdd.Checked = false;
                    }
                    if (((int)row.Cells[5].Value) == 0 && CheckBoxAllEdit.Checked)
                    {
                        CheckBoxAllEdit.Checked = false;
                    }
                    if (((int)row.Cells[6].Value) == 0 && CheckBoxAllDelete.Checked)
                    {
                        CheckBoxAllDelete.Checked = false;
                    }
                }
            }
            else
                MessageBox.Show("Select User First");
        }
        void CheckedCheckBox(int e)
        {
            var check = SqlService.GetDataTable("select * from UserRole where id_user ='" + TextBoxUser.Tag.ToString() + "' and id_role='" + dgv.Rows[e].Cells[0].Value + "'");
            if (check.Rows.Count == 0)
                SqlService.ExecuteQuery("insert into UserRole (id_user,id_role,allow_view,allow_add,allow_update,allow_delete) values('" + TextBoxUser.Tag.ToString() + "','" + dgv.Rows[e].Cells[0].Value.ToString() + "','" + dgv.Rows[e].Cells[3].Value.ToString() + "','" + dgv.Rows[e].Cells[4].Value.ToString() + "','" + dgv.Rows[e].Cells[5].Value.ToString() + "','" + dgv.Rows[e].Cells[6].Value.ToString() + "')");
            else
                SqlService.ExecuteQuery("update UserRole set allow_view='" + dgv.Rows[e].Cells[3].Value + "', allow_add='" + dgv.Rows[e].Cells[4].Value + "',allow_update='" + dgv.Rows[e].Cells[5].Value + "',allow_delete='" + dgv.Rows[e].Cells[6].Value + "' where id_user='" + TextBoxUser.Tag + "' and id_role='" + dgv.Rows[e].Cells[0].Value + "'");
        }

        private void CheckBoxAllView_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text != "")
            {
                int ctr = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells[3].Value = CheckBoxAllView.Checked ? 1 : 0;
                    CheckedCheckBox(ctr);
                    ctr += 1;
                }
            }
            else
                MessageBox.Show("Select User First");
        }

        private void CheckBoxAllAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text != "")
            {
                int ctr = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells[3].Value = CheckBoxAllAdd.Checked ? 1 : 0;
                    CheckedCheckBox(ctr);
                    ctr += 1;
                }
            }
            else
                MessageBox.Show("Select User First");
        }

        private void CheckBoxAllEdit_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text != "")
            {
                int ctr = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells[3].Value = CheckBoxAllEdit.Checked ? 1 : 0;
                    CheckedCheckBox(ctr);
                    ctr += 1;
                }
            }
            else
                MessageBox.Show("Select User First");
        }

        private void CheckBoxAllDelete_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text != "")
            {
                int ctr = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells[3].Value = CheckBoxAllDelete.Checked ? 1 : 0;
                    CheckedCheckBox(ctr);
                    ctr += 1;
                }
            }
            else
                MessageBox.Show("Select User First");
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            showDataGridView(TextBoxSearch.Text);
        }
    }
}
