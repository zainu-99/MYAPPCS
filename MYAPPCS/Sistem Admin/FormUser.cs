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
    public partial class FormUser : Form
    {

        String  gender = "", status = "", id_user = "";
        BindingSource bs = new BindingSource();
        public FormUser()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            GroupBoxInputData.Enabled = true;
            TextBoxUserId.Text = "";
            TextBoxName.Text = "";
            TextBoxNohp.Text = "";
            TextBoxEmail.Text = "";
            TextBoxAddress.Text = "";
            TextBoxPassword.Text = "";
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
                var query = "delete from users where id = '" + id_user + "'";
                SqlService.ExecuteQuery(query);
                LogApp.Delete("users", DgvRowToString.Generate(dgv, dgv.CurrentRow.Index), "");
                Reload();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ModSqlCommand command;
            if (RadioButtonAktif.Checked)
                status = "1";
            else
                status = "0";

            if (RadioButtonMale.Checked)
                gender = "M";
            else
                gender = "P";
            var stream = new MemoryStream();
            PictureBoxProfile.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            var pic = stream.ToArray();

            if (!ButtonEdit.Enabled)
            {
                command = SqlService.GetCommand("insert into users (userid,name,email,nohp,address,avatar,gender,status,password,password_noencrypt,token)values('" + Utilities.ReplaceQuot(TextBoxUserId.Text) + "', '" + Utilities.ReplaceQuot(TextBoxName.Text) + "', '" + Utilities.ReplaceQuot(TextBoxEmail.Text) + "', '" + Utilities.ReplaceQuot(TextBoxNohp.Text) + "', '" + Utilities.ReplaceQuot(TextBoxAddress.Text) + "', @Pic, '" + gender + "', '" + status + "', '" + Utilities.GetHashMD5(TextBoxPassword.Text) + "', '" + Utilities.ReplaceQuot(TextBoxPassword.Text) + "', '-')");
                command.sqlCommand.Parameters.AddWithValue("@Pic", pic);
                command.sqlCommand.ExecuteNonQuery();
                command.sqlConnection.Close();
                Reload();
                //Fungsi Mengambil data terbaru
                var indexRow = Convert.ToInt32(SqlService.GetDataTable("select top 1 id,name,ROW_NUMBER() OVER(ORDER BY name) as idx from users order by id desc").Rows[0][2]) - 1;
                LogApp.Insert("users", DgvRowToString.Generate(dgv, indexRow), "");
            }
            else
            {
                command = SqlService.GetCommand("update users set userid='" + Utilities.ReplaceQuot(TextBoxUserId.Text) + "',name='" + Utilities.ReplaceQuot(TextBoxName.Text) + "',email='" + Utilities.ReplaceQuot(TextBoxEmail.Text) + "', nohp='" + Utilities.ReplaceQuot(TextBoxNohp.Text) + "', address = '" + Utilities.ReplaceQuot(TextBoxAddress.Text) + "', avatar = @Pic, gender = '" + gender + "', status = '" + status + "', password_noencrypt = '" + Utilities.ReplaceQuot(TextBoxPassword.Text) + "', password = '" + Utilities.GetHashMD5(TextBoxPassword.Text) + "' where id = '" + id_user + "'");
                command.sqlCommand.Parameters.AddWithValue("@Pic", pic);
                LogApp.Update("users", DgvRowToString.Generate(dgv, dgv.CurrentRow.Index), "-", "");
                command.sqlCommand.ExecuteNonQuery();
                command.sqlConnection.Close();
                Reload();
            }
        }

        private void ButtonOpenGaleri_Click(object sender, EventArgs e)
        {
            var Galeri = new OpenFileDialog();
            Galeri.Filter = "(*.JPG)|*.JPG";
            if (Galeri.ShowDialog() == DialogResult.OK)
                PictureBoxProfile.ImageLocation = Galeri.FileName;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxInputData.Enabled = false;
            id_user = dgv.CurrentRow.Cells[0].Value.ToString();
            TextBoxUserId.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            TextBoxName.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            TextBoxNohp.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            TextBoxEmail.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            TextBoxAddress.Visible = false;

            try
            {
                var bytes = SqlService.GetDataTable("select avatar from users where id =" + id_user).Rows[0][0];
                var ms = new MemoryStream((byte[])bytes);
                PictureBoxProfile.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }
            TextBoxPassword.Text = dgv.CurrentRow.Cells[8].Value.ToString();
            if (dgv.CurrentRow.Cells[6].Value.ToString() == "1")
                RadioButtonAktif.Checked = true;
            else
                RadioButtonNonAktif.Checked = true;
            if (dgv.CurrentRow.Cells[7].Value.ToString() == "M")
                RadioButtonMale.Checked = true;
            else
                RadioButtonPemale.Checked = true;
            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonSave.Enabled = true;
        }


        private void FormUser_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowNavPageData();
        }

        private void ComboBoxEntries_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        void Reload()
        {
            GroupBoxInputData.Enabled = false;
            ShowNavPageData();
            TextBoxUserId.Text = "";
            TextBoxName.Text = "";
            TextBoxNohp.Text = "";
            TextBoxEmail.Text = "";
            TextBoxAddress.Text = "";
            TextBoxPassword.Text = "";
            TextBoxPassword.Visible = true;
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = false;
            gender = "";
            status = "";
            id_user = "";
        }

        private void ComboBoxEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNavPageData();
        }

        private void bindingSourcePaging_PositionChanged(object sender, EventArgs e)
        {
            ShowNavPageData();
        }

        private void ButtonUserGroup_Click(object sender, EventArgs e)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            formMain.ShowFormToTabPage(new FormUserGroup());
            var formRoleGroup = (formMain.GetFormInTabControl("FormUserGroup") as FormUserGroup);
            formRoleGroup.TextBoxUser.Text = dgv.CurrentRow.Cells["userid"].Value.ToString();
            formRoleGroup.TextBoxUser.Text += "-" + dgv.CurrentRow.Cells["name"].Value.ToString();
            formRoleGroup.TextBoxUser.Tag = dgv.CurrentRow.Cells[0].Value;
        }

        private void ButtonUserAccess_Click(object sender, EventArgs e)
        {
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            formMain.ShowFormToTabPage(new FormUserRole());
            var formRoleGroup = (formMain.GetFormInTabControl("FormUserRole") as FormUserRole);
            formRoleGroup.TextBoxUser.Text = dgv.CurrentRow.Cells["userid"].Value.ToString();
            formRoleGroup.TextBoxUser.Text += "-" + dgv.CurrentRow.Cells["name"].Value.ToString();
            formRoleGroup.TextBoxUser.Tag = dgv.CurrentRow.Cells[0].Value;
        }

        void ShowNavPageData()
        {
            dgv.DataSource = null;
            var query = "select count(id) from Users where name like '%" + TextBoxSearch.Text + "%'";
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
            if (bindingSourcePaging.Position >= 0)
            {
                ShowDataGridView();
            }
        }
        void ShowDataGridView()
        {
            String query = "select id,userid,name,nohp,email,address,status,gender,password_noencrypt from users where name like '%" + TextBoxSearch.Text + "%' order by name asc OFFSET " + bindingSourcePaging.Position * Int32.Parse(ComboBoxEntries.Text) + " ROWS FETCH NEXT " + ComboBoxEntries.Text + " ROWS ONLY;";
            dgv.DataSource = SqlService.GetDataTable(query);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["password_noencrypt"].Visible = false;
            dgv.Columns["userid"].HeaderText = "UserID";
            dgv.Columns["name"].HeaderText = "Name";
            dgv.Columns["nohp"].HeaderText = "Phone";
            dgv.Columns["email"].HeaderText = "Email";
            dgv.Columns["address"].HeaderText = "Address";
            dgv.Columns["status"].HeaderText = "Status";
            dgv.Columns["gender"].HeaderText = "Gender";
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }
    }
}
