using MYAPPCS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS
{
    public partial class FormMenuApp : Form
    {

        String IdMenu = "0";
        int ctr = 0;
        public FormMenuApp()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Reload();
        }

        void Reload()
        {
            ShowCBTag();
            ShowParentMenu();
            ShowDataGridView("");
        }

        void ShowCBTag()
        {
            ComboBoxTag.DataSource = SqlService.GetDataTable("select * from Roles order by name asc");
            ComboBoxTag.ValueMember = "name";
            ComboBoxTag.DisplayMember = "name";
        }

        void ShowParentMenu()
        {
            ComboBoxParentMenu.DataSource = SqlService.GetDataTable("select NULL as ID,'-No Parent-' as MenuText union all select ID,MenuText from MenuApp where ID <> " + IdMenu + " and (IDParentMenu is Null or IDParentMenu <> " + IdMenu + ") order by MenuText asc");
            ComboBoxParentMenu.ValueMember = "ID";
            ComboBoxParentMenu.DisplayMember = "MenuText";
        }
        void ShowDataGridView(String txtSearch)
        {
            var dt = new DataTable();
            String query = "select a.ID,a.MenuTag,a.MenuText,a.FormName,iif(b.[MenuText] is null,'-No Parent-',b.[MenuText]) as Parent,a.IconMenu,a.OrderSort,a.IDParentMenu from MenuApp a left join MenuApp b on a.IDParentMenu =b.ID where a.MenuText like '%" + txtSearch + "%' order by a.OrderSort,a.MenuText Asc";
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
            dgv.Columns[0].HeaderCell.Value = "Menu";
            dgv.Columns[1].HeaderCell.Value = "Menu ID";
            dgv.Columns[1].Visible = false;
            dgv.Columns[2].HeaderCell.Value = "Role Name";
            dgv.Columns[3].HeaderCell.Value = "Menu Text";
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].HeaderCell.Value = "Open Form Name";
            dgv.Columns[5].HeaderCell.Value = "Parent";
            dgv.Columns[6].HeaderCell.Value = "Icon";
            dgv.Columns[6].Width = 35;
            dgv.Columns[7].HeaderCell.Value = "Order Sort";
            dgv.Columns[7].Width = 150;
        }

        void GetGroupLevel(DataTable dt, String idParent, String levelTag)
        {
            foreach (DataRow dtrow in dt.Select("IDParentMenu  " + idParent))
            {
                AddToDgv(dtrow, levelTag + "➧ ");
                if (dt.Select("IDParentMenu = " + dtrow[0]).Count() > 0)
                    GetGroupLevel(dt, "= " + dtrow[0], levelTag + "     ");
            }

        }

        void AddToDgv(DataRow dr, String levelTag)
        {
            dgv.Rows.Add(levelTag + dr[2], dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            GroupBoxInputData.Enabled = true;
            TextBoxOpenFormName.Text = "";
            TextBoxMenuText.Text = "";
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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var query = "delete from MenuApp where ID = '" + IdMenu + "'";
                SqlService.ExecuteQuery(query);
                Reload();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            PictureBoxIconMenu.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            var pic = stream.ToArray();
            ModSqlCommand command;
            String valcmb = "";
            if (ComboBoxParentMenu.Text == "-No Parent-")
                valcmb = "null";
            else
                valcmb = ComboBoxParentMenu.SelectedValue.ToString();
            if (!ButtonEdit.Enabled)
            {
                command = SqlService.GetCommand("insert into MenuApp (MenuTag,MenuText,FormName,IDParentMenu,IconMenu,OrderSort) values('" + Utilities.ReplaceQuot(ComboBoxTag.Text) + "','" + Utilities.ReplaceQuot(TextBoxMenuText.Text) + "','" + Utilities.ReplaceQuot(TextBoxOpenFormName.Text) + "'," + valcmb + ",@pic," + Utilities.ReplaceQuot(NumericUpDownOrderSort.Value.ToString()) + ")");
                command.sqlCommand.Parameters.AddWithValue("@Pic", pic);
            }
            else
            {
                command = SqlService.GetCommand("update MenuApp set MenuTag= '" + Utilities.ReplaceQuot(ComboBoxTag.Text) + "',MenuText='" + Utilities.ReplaceQuot(TextBoxMenuText.Text) + "',FormName='" + Utilities.ReplaceQuot(TextBoxOpenFormName.Text) + "',IDParentMenu=" + valcmb + ",IconMenu=@pic,OrderSort=" + Utilities.ReplaceQuot(NumericUpDownOrderSort.Value.ToString()) + " where ID = " + IdMenu);
                command.sqlCommand.Parameters.AddWithValue("@Pic", pic);
            }
            command.sqlCommand.ExecuteNonQuery();
            command.sqlConnection.Close();
            Reload();
        }

        private void PictureBoxIconMenu_Click(object sender, EventArgs e)
        {
            var Galeri = new OpenFileDialog();
            Galeri.Filter = "(*.JPG)|*.JPG";
            if (Galeri.ShowDialog() == DialogResult.OK)
                PictureBoxIconMenu.ImageLocation = Galeri.FileName;
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType() == typeof(DataGridViewImageCell))
            {
                ((DataGridViewImageCell)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void FormMenuApp_Shown(object sender, EventArgs e)
        {
            ShowDataGridView("");
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxInputData.Enabled = false;
            IdMenu = dgv.CurrentRow.Cells[1].Value.ToString();
            ComboBoxTag.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            TextBoxMenuText.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            TextBoxOpenFormName.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            ShowParentMenu();
            ComboBoxParentMenu.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            var bytes = dgv.CurrentRow.Cells[6].Value;
            var ms = new MemoryStream((byte[])bytes);
            PictureBoxIconMenu.Image = Image.FromStream(ms);
            NumericUpDownOrderSort.Value = (int)dgv.CurrentRow.Cells[7].Value;
            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonSave.Enabled = true;
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)13)
            {
                for(int i = ctr;i< dgv.Rows.Count-1;i++)
                {
                    ctr = i + 1;
                    if(dgv.Rows[i].Cells["MenuTag"].Value.ToString().ToLower().Contains(TextBoxSearch.Text) || dgv.Rows[i].Cells["MenuText"].Value.ToString().ToLower().Contains(TextBoxSearch.Text) || dgv.Rows[i].Cells["OpenForm"].Value.ToString().ToLower().Contains(TextBoxSearch.Text))
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
