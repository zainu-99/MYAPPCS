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

    public partial class FormRoleGroup : Form
    {
        DataTable table;
        int ctr=0;
        public FormRoleGroup()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Reload()
        {
            dgv.Rows.Clear();
            showDataGridView("");
        }

        void showDataGridView(String txtSearch)
        {
            String query = "select a.id,a.name,a.remark,isView,isAdd,isEdit,isDelete,isPrint,isCustom,AccessView,AccessAdd,AccessEdit,AccessDelete,AccessPrint,AccessCustom from Roles a left join (select * from  RoleGroupLevel where id_group_level=" + textBoxGroupLevel.Tag.ToString() + ") b on a.id =b.id_role where name like '%" + txtSearch + "%' or remark like '%" + txtSearch + "%' order by a.remark,a.name";
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

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
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

        private void textBoxGroupLevel_TextChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count == 0) return;
                if(dgv.Columns[e.ColumnIndex].DataPropertyName == "Access")
                {
                    string colname = dgv.Columns[e.ColumnIndex].Name.Replace("Is", "Access");
                    var accessColumn = dgv.Rows[e.RowIndex].Cells[colname].Value;
                    if (!(DBNull.Value.Equals(accessColumn) ? false: (bool)accessColumn))
                    {
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                        e.Graphics.FillRectangle(new SolidBrush(e.CellStyle.BackColor), e.CellBounds);
                        e.PaintBackground(e.CellBounds, false);
                        e.Handled = true;
                    }
                    else
                    {
                        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dgvRow = dgv.Rows[e.RowIndex];
            var Exist = ((int)SqlService.GetDataTable("select count(id) from RoleGroupLevel where id_group_level = " + textBoxGroupLevel.Tag + " and id_role = " + dgvRow.Cells["ID"].Value).Rows[0].ItemArray[0] > 0);
            if(Exist)
            {
                SqlService.ExecuteQuery("update RoleGroupLevel set [isView] = '" + dgvRow.Cells["IsView"].Value + "' ,[isAdd] = '" + dgvRow.Cells["isAdd"].Value + "',[isEdit] = '" + dgvRow.Cells["isEdit"].Value + "',[isDelete] = '" + dgvRow.Cells["isDelete"].Value + "',[isPrint] = '" + dgvRow.Cells["isPrint"].Value + "',[isCustom] = '" + dgvRow.Cells["isCustom"].Value + "' where id_group_level = '" + textBoxGroupLevel.Tag.ToString() + "' and id_role = '" + dgvRow.Cells["ID"].Value + "'");
            }
            else
            {
                SqlService.ExecuteQuery("insert into RoleGroupLevel (id_group_level,id_role,[isView],[isAdd],[isEdit],[isDelete],[isPrint],[isCustom]) values('" + textBoxGroupLevel.Tag.ToString() + "','" + dgvRow.Cells["ID"].Value + "','" + dgvRow.Cells["IsView"].Value + "','" + dgvRow.Cells["IsView"].Value + "','" + dgvRow.Cells["IsAdd"].Value + "','" + dgvRow.Cells["IsEdit"].Value + "','" + dgvRow.Cells["IsDelete"].Value + "','" + dgvRow.Cells["IsCustom"].Value + "')");
            }
        }
    }
}
