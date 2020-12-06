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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //SqlService.SetConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\db\\DatabaseLocal.mdf\";Integrated Security=True");
            TextBoxUserId.Text = MYAPPCS.Properties.Settings.Default.userid_remember;
            TextBoxPassword.Text = MYAPPCS.Properties.Settings.Default.passsword_remember;
            new FormSplashScreen().ShowDialog();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        void DoLogin()
        {
            var data =  SqlService.GetDataTable("select * from Users where userid ='" + Utilities.ReplaceQuot(TextBoxUserId.Text) + "' and status =1 and  password='" + Utilities.GetHashMD5(TextBoxPassword.Text) + "'");
            if (data.Rows.Count>0)
            {
                MYAPPCS.Properties.Settings.Default.id_user = data.Rows[0][0].ToString();
                MYAPPCS.Properties.Settings.Default.userid = data.Rows[0][1].ToString();
                MYAPPCS.Properties.Settings.Default.nama = data.Rows[0][2].ToString();
                LogApp.Login();
                this.Hide();
                var formMain = new FormMain();
                formMain.Show();
                formMain.formLogin = this;
            }
            else
                MessageBox.Show("Password Atau UserId Salah Atau Account Not Active");
            if (CheckBoxRemember.Checked)
            {
                MYAPPCS.Properties.Settings.Default.userid_remember=TextBoxUserId.Text;
                MYAPPCS.Properties.Settings.Default.passsword_remember=TextBoxPassword.Text;
            }
            MYAPPCS.Properties.Settings.Default.Save();

        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                DoLogin();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
