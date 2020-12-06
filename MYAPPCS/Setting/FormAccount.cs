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
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            var data = SqlService.GetDataTable("select id,userid,name,nohp,email,address,status,gender,created_at,avatar,avatar,password_noencrypt from users where id ='" + MYAPPCS.Properties.Settings.Default.id_user + "'").Rows[0];
            TextBoxUserId.Text = data[1].ToString();
            TextBoxName.Text = data[2].ToString();
            TextBoxNohp.Text = data[3].ToString();
            TextBoxEmail.Text = data[4].ToString();
            TextBoxAddress.Text = data[5].ToString();
            try
            {
                var bytes = data[9];
                var ms = new MemoryStream((byte[])bytes);
                PictureBoxProfile.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }
            if (data[6].ToString() == "1")
                RadioButtonAktif.Checked = true;
            else
                RadioButtonNonAktif.Checked = true;
            if (data[7].ToString() == "M")
                RadioButtonMale.Checked = true;
            else
                RadioButtonPemale.Checked = true;
        }

        private void ButtonOpenGaleri_Click(object sender, EventArgs e)
        {
            var Galeri = new OpenFileDialog();
            Galeri.Filter = "(*.JPG)|*.JPG";
            if (Galeri.ShowDialog() == DialogResult.OK)
                PictureBoxProfile.ImageLocation = Galeri.FileName;
        }

        private void ButtonUpdateBio_Click(object sender, EventArgs e)
        {
            String gender = "", status = "";
            if (!GroupBoxProfile.Enabled)
            {
                GroupBoxProfile.Enabled = true;
                ButtonUpdateBio.Text = "Save";
            }
            else
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

                command = SqlService.GetCommand("update users set userid='"+TextBoxUserId.Text+"',name='"+TextBoxName.Text+"',email='"+TextBoxEmail.Text+"', nohp='"+TextBoxNohp.Text+"',address = '"+TextBoxAddress.Text+"', avatar = @pic, gender = '"+gender+"', status = '"+status+"' where id = '"+ MYAPPCS.Properties.Settings.Default.id_user + "'");
                command.sqlCommand.Parameters.AddWithValue("@Pic", pic);
                command.sqlCommand.ExecuteNonQuery();
                command.sqlConnection.Close();
                GroupBoxProfile.Enabled = false;
                ButtonUpdateBio.Text = "Edit";
            }
        }

        private void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {
            if (SqlService.GetDataTable("select * from users where id ='" + MYAPPCS.Properties.Settings.Default.id_user + "' and password = '" + Utilities.GetHashMD5(TextBoxOldPassword.Text) + "'").Rows.Count == 0)
                MessageBox.Show("Old Password Wrong");
            else
            {
                if( TextBoxNewPassword.Text != TextBoxConfirmPasssword.Text)
                    MessageBox.Show("New Password and Confirm Password Not Match");
                else
                {
                    SqlService.ExecuteQuery("Update users set password_noencrypt='"+TextBoxNewPassword.Text+"', password='"+ Utilities.GetHashMD5(TextBoxNewPassword.Text)+"' where id = '"+ MYAPPCS.Properties.Settings.Default.id_user + "'");
                    MessageBox.Show("Change Password Success");
                    TextBoxConfirmPasssword.Clear();
                    TextBoxNewPassword.Clear();
                    TextBoxOldPassword.Clear();
                }
            }
            
        }
    }
}
