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
    public partial class FormUserGroup : Form
    {
        public FormUserGroup()
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
            String query = "select a.id,CONCAT(d.name,' - ',a.remark) as [group],CONCAT(f.name,' - ',e.remark)as parent,a.remark,a.id_parent,IIF((select id_user from UserGroupLevel where id_user ='" + TextBoxUser.Tag + "' and id_group_level = b.id_group_level) is null,0,1) as IsJoin from GroupLevel a left join (select * from UserGroupLevel where id_user='" + TextBoxUser.Tag + "') b on a.id = b.id_group_level left join  Groups as d on a.id_group = d.id left join GroupLevel as e on a.id_parent =e.id left join Groups as f on e.id_group = f.id";
            var dt = SqlService.GetDataTable(query);
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
            dgv.Rows.Add(dr[0], levelTag + dr[1], dr[2], dr[3], dr[5]);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TextBoxUser.Tag != null)
            {
                if (e.ColumnIndex == dgv.Columns["Join"].Index)                   
                    if ((int)dgv.Rows[e.RowIndex].Cells["Join"].Value==0)
                    {
                        SqlService.ExecuteQuery("insert into UserGroupLevel (id_user,id_group_level) values('" + TextBoxUser.Tag.ToString() + "','" + dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + "')");
                        dgv.Rows[e.RowIndex].Cells["Join"].Value = 1;
                    }
                    else
                    {
                        SqlService.ExecuteQuery("delete from UserGroupLevel where id_user = '" + TextBoxUser.Tag + "' and id_group_level = '" + dgv.Rows[e.RowIndex].Cells[0].Value + "'");
                        dgv.Rows[e.RowIndex].Cells["Join"].Value = 0;

                    }
            }
            else
                MessageBox.Show("Please Select User");
        }
    }
}
