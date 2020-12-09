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
        int ctr = 0;
        public FormUserRole()
        {
            InitializeComponent();
        }

        private void FormUserRole_Load(object sender, EventArgs e)
        {
            ShowGroupLevel();
        }

        void Reload()
        {
            ShowGroupLevel();
            showDataGridView("");
        }
        void ShowGroupLevel()
        {
            var query = "select a.id,concat(b.name,' - ',a.remark) as info from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent";
            ComboBoxGroupLevel.DataSource = SqlService.GetDataTable(query);
            ComboBoxGroupLevel.ValueMember = "id";
            ComboBoxGroupLevel.DisplayMember = "info";
        }
        void showDataGridView(String txtSearch)
        {
            String query = "select a.id,a.name,a.remark,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag.ToString() + "' and allow_view= 1) is null,0,1) as allow_view,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag.ToString() + "' and allow_add= 1) is null,0,1) as allow_add,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag.ToString() + "' and allow_update= 1) is null,0,1) as allow_update,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag.ToString() + "' and allow_delete= 1) is null,0,1) as allow_delete,iif((select id from UserRole where id_role = a.id and id_user = '" + TextBoxUser.Tag.ToString() + "' and allow_print= 1) is null,0,1) as allow_print,allow_custom_access,d.isView,d.isAdd,d.isEdit,d.isDelete,d.isPrint,d.isCustom from Roles a left join (select * from UserRole where id_user=" + TextBoxUser.Tag.ToString() + ") b on a.id = b.id_role left join Users c on b.id_user = c.id left join RoleGroupLevel d on a.id =d.id_role where d.id_group_level ='" + ComboBoxGroupLevel.SelectedValue + "' and 1 in (d.isView,d.isAdd,d.isEdit,d.isDelete,d.isPrint,d.isCustom) order by a.remark,a.name";
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
                dgv.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14]);    
            }

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
            if(ComboBoxGroupLevel.Items.Count>0)
            {
                dgv.Rows.Clear();
                showDataGridView("");
            }
            else
            {
                MessageBox.Show("Please Select Group Level");
            }
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
               
            }
            else
                MessageBox.Show("Select User First");
        }
        void CheckedCheckBox(int e)
        {
            var check = SqlService.GetDataTable("select * from UserRole where id_user ='" + TextBoxUser.Tag.ToString().ToString() + "' and id_role='" + dgv.Rows[e].Cells[0].Value + "'");
            if (check.Rows.Count == 0)
                SqlService.ExecuteQuery("insert into UserRole (id_user,id_role,allow_view,allow_add,allow_update,allow_delete,allow_print,allow_custom_access) values('" + TextBoxUser.Tag.ToString() + "','" + dgv.Rows[e].Cells[0].Value + "','" + dgv.Rows[e].Cells[3].Value + "','" + dgv.Rows[e].Cells[4].Value + "','" + dgv.Rows[e].Cells[5].Value + "','" + dgv.Rows[e].Cells[6].Value + "','" + dgv.Rows[e].Cells[7].Value + "','" + dgv.Rows[e].Cells[8].Value + "')");
            else
                SqlService.ExecuteQuery("update UserRole set allow_view='" + dgv.Rows[e].Cells[3].Value + "', allow_add='" + dgv.Rows[e].Cells[4].Value + "',allow_update='" + dgv.Rows[e].Cells[5].Value + "',allow_delete='" + dgv.Rows[e].Cells[6].Value + "',allow_print='" + dgv.Rows[e].Cells[7].Value + "',allow_custom_access='" + dgv.Rows[e].Cells[8].Value + "' where id_user='" + TextBoxUser.Tag + "' and id_role='" + dgv.Rows[e].Cells[0].Value + "'");
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            showDataGridView(TextBoxSearch.Text);
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                for (int i = ctr; i < dgv.Rows.Count - 1; i++)
                {
                    ctr = i + 1;
                    if (dgv.Rows[i].Cells["Role"].Value.ToString().ToLower().Contains(TextBoxSearch.Text) || dgv.Rows[i].Cells["Remark"].Value.ToString().ToLower().Contains(TextBoxSearch.Text))
                    {
                        dgv.Rows[i].Selected = true;
                        dgv.FirstDisplayedScrollingRowIndex = i;
                        return;
                    }
                }
                ctr = 0;
            }
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count == 0) return;
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Access")
                {
                    string colname = dgv.Columns[e.ColumnIndex].Name.Replace("Allow", "Access");
                    var accessColumn = dgv.Rows[e.RowIndex].Cells[colname].Value;
                    if (!(DBNull.Value.Equals(accessColumn) ? false : (bool)accessColumn))
                    {
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = "Disable";
                        e.Graphics.FillRectangle(new SolidBrush(e.CellStyle.BackColor), e.CellBounds);
                        e.PaintBackground(e.CellBounds, false);
                        e.Handled = true;
                    }
                    else
                    {
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = "Enable";
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
