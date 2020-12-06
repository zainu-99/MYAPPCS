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
        public FormRoleGroup()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRoleGroup_Load(object sender, EventArgs e)
        {
            Reload();
        }

        void Reload()
        {
            ShowGroupLevel();
            dgv.Rows.Clear();
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
            String query = "select a.*,iif((select id from RoleGroupLevel where id_role=a.id and id_group_level=" + ComboBoxGroupLevel.SelectedValue.ToString() + ") is null,0,1) as IsJoin from roles a order by a.remark,a.nama";
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
                dgv.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void ComboBoxGroupLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (table != null)
                {
                dgv.Rows.Clear();
                showDataGridView("");
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                if ((int)dgv.Rows[e.RowIndex].Cells[3].Value == 0)
                {
                    SqlService.ExecuteQuery("insert into RoleGroupLevel (id_group_level,id_role) values('" + ComboBoxGroupLevel.SelectedValue + "','" + dgv.Rows[e.RowIndex].Cells[0].Value + "')");
                    dgv.Rows[e.RowIndex].Cells[3].Value = 1;
                }
                else
                {
                    SqlService.ExecuteQuery("delete from RoleGroupLevel where id_group_level = '" + ComboBoxGroupLevel.SelectedValue + "' and id_role = '" + dgv.Rows[e.RowIndex].Cells[0].Value + "'");
                    dgv.Rows[e.RowIndex].Cells[3].Value = 0;
                }
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            showDataGridView(TextBoxSearch.Text);
        }
    }
}
