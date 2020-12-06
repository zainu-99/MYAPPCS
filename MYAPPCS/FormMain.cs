using MYAPPCS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS
{
    public partial class FormMain : Form
    {
        public String FormActive = "FormMain";
        public FormLogin formLogin;
        public FormMain()
        {
            InitializeComponent();
            MenuApp.Renderer = new MyRender();
        }

        #region "<<Not For Change>>"
        private void FormMain_Load(object sender, EventArgs e)
        {
            Reload();
        }
        #region "REload"
        void Reload()
        {
            CreateMenuAccess();
            InitData();
            SetDesignUI();
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            LabelVersion.Text = "Version: " + fvi.FileVersion;
        }
        #endregion


        #region "toggle Menu"
        private void btnMenu_Click(object sender, EventArgs e)
        {
            PanelSideBar.Visible = !PanelSideBar.Visible;
        }
        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = PanelTitle.BackColor;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = PanelHeader.BackColor;
        }
        #endregion

        #region "emasukan form child ke panel"
        public void ShowFormToPanel(Form form)
        {
            ProgressBarLoad.Value = 0;
            if (PanelFormFill.Controls.Find(form.Name, true).Length == 0)
            {
                if (form.Tag != null)
                {
                    form.WindowState = FormWindowState.Normal;
                    form.TopLevel = false;
                    form.Resize += new EventHandler(FormChild_Resize);
                    form.Shown += new EventHandler(FormChild_Shown);
                    PanelFormFill.Controls.Add(form);
                    if (AuthHelper.GetAutUserView(form.Tag.ToString()) || form.Tag.ToString() == "Login")
                        form.Show();
                    else
                        MessageBox.Show("You Have No Access");
                }
                else
                    MessageBox.Show("Form Not Found");
            }
            else
                form = (Form)PanelFormFill.Controls.Find(form.Name, true)[0];
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            FormActive = form.Name;
            BringFomMinimizeToFront();
            ProgressBarLoad.Value = 100;
        }
        private void FormChild_Resize(object sender, EventArgs e)
        {
            LabelTitle.Text = ((Form)sender).Text;
            FormActive = ((Form)sender).Name;
            BringFomMinimizeToFront();
        }
        #endregion

        #region "ketika form child tampil"
        private void FormChild_Shown(object sender, EventArgs e)
        {
            if (((Form)sender).Controls.Find("PanelButton", true).Length > 0)
            {
                var panelButton = ((Form)sender).Controls.Find("PanelButton", true)[0];
                foreach (MenuStrip ctrl in panelButton.Controls)
                {
                    foreach (ToolStripMenuItem item in ctrl.Items)
                    {
                        if (item.Tag.ToString() == "ButtonAdd" && !AuthHelper.GetAutUserAdd(((Form)sender).Tag.ToString()))
                            item.Visible = false;
                        if (item.Tag.ToString() == "ButtonEdit" && !AuthHelper.GetAutUserEdit(((Form)sender).Tag.ToString()))
                            item.Visible = false;
                        if (item.Tag.ToString() == "ButtonDelete" && !AuthHelper.GetAutUserDelete(((Form)sender).Tag.ToString()))
                            item.Visible = false;

                        //Design Color
                        if (item.Tag.ToString() == "ButtonAdd")
                        {
                            item.BackColor = DesignColor.ButtonAdd;
                            item.ForeColor = DesignColor.ButtonText;
                        }
                        if (item.Tag.ToString() == "ButtonEdit")
                        {
                            item.BackColor = DesignColor.ButtonEdit;
                            item.ForeColor = DesignColor.ButtonText;
                        }
                        if (item.Tag.ToString() == "ButtonSave")
                        {
                            item.BackColor = DesignColor.ButtonSave;
                            item.ForeColor = DesignColor.ButtonText;
                        }
                        if (item.Tag.ToString() == "ButtonDelete")
                        {
                            item.BackColor = DesignColor.ButtonDelete;
                            item.ForeColor = DesignColor.ButtonText;
                        }
                        if (item.Tag.ToString() == "ButtonRefresh")
                        {
                            item.BackColor = DesignColor.ButtonRefresh;
                            item.ForeColor = DesignColor.ButtonText;
                        }
                    }
                }
            }
            if (((Form)sender).Controls.Find("dgv", true).Length > 0)
            {
                DataGridView dgv = (DataGridView)((Form)sender).Controls.Find("dgv", true)[0];
                dgv.AllowUserToAddRows = false;
                dgv.RowHeadersVisible = false;
                dgv.BorderStyle = BorderStyle.None;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = DesignColor.dgv_AlternatingRowsDefaultCellStyle;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                foreach(DataGridViewColumn dgvcol in dgv.Columns)
                {
                    dgvcol.HeaderCell.Value = dgvcol.HeaderCell.Value.ToString().Replace("_", " ");
                }
            }
        }
        #endregion
        #region "Init Account Data"
        void InitData()
        {
            var user = SqlService.GetDataTable("select userid,name,avatar from users where id ='" + MYAPPCS.Properties.Settings.Default.id_user + "'");
            LabelUserId.Text = user.Rows[0][0].ToString();
            LabelNama.Text = user.Rows[0][1].ToString();
            try
            {
                var bytes = user.Rows[0][2];
                var ms = new MemoryStream((byte[])bytes);
                PictureBoxProfile.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }

        }
        #endregion


        #region "Set Tampilan"
        public void SetDesignUI()
        {
            PanelHeader.BackColor = DesignColor.PanelHeader;
            btnNotif.BackColor = DesignColor.PanelHeader;
            btnLogout.BackColor = DesignColor.PanelHeader;
            PanelTitle.BackColor = DesignColor.PanelTitle;
            PanelProfile.BackColor = DesignColor.PanelProfile;
            PanelMenu.BackColor = DesignColor.PanelMenuBackground;
            PanelFooter.BackColor = DesignColor.PanelFooter;
            LabelVersion.BackColor = DesignColor.PanelFooter;
            PanelSparator.BackColor = DesignColor.PanelSparatorFormChild;
            LabelTitle.ForeColor = DesignColor.TextForeColor;
            LabelNama.ForeColor = DesignColor.TextForeColor;
            LabelUserId.ForeColor = DesignColor.TextForeColor;
            LabelMenu.ForeColor = DesignColor.TextForeColor;
            ButtonMinimize.BackColor = DesignColor.ButtonMinimizeFormChild;
            ButtonClose.BackColor = DesignColor.ButtonCloseFormChild;
        }
        #endregion


        #region "Membuat Menu Dan Menambakan Eventnya"
        void CreateMenuAccess()
        {
            MenuApp.Items.Clear();
            AuthHelper.GetUserAuth();
            var dsMenu = SqlService.GetDataTable("select * from MenuApp order by OrderSort,MenuText Asc");
            GetMenuLevel(dsMenu, " Is Null ", MenuApp);
        }

        void GetMenuLevel(DataTable dtMenu, String idParent, Object parent)
        {
            foreach (DataRow item in dtMenu.Select("IDParentMenu " + idParent))
            {
                if (AuthHelper.GetAutUserView(item[1].ToString()))
                {
                    var obj = CreateMenu(item, parent);
                    GetMenuLevel(dtMenu, " = " + item[0], obj);
                }
            }
        }
        ToolStripMenuItem CreateMenu(DataRow dr, Object parent)
        {
            var tsm = new ToolStripMenuItem();
            tsm.Name = dr[0].ToString();
            tsm.Tag = dr[1].ToString();
            tsm.Text = dr[2].ToString();
            tsm.Click += new EventHandler(ItemMenu_Click);
            if (dr[5].ToString() != "")
            {
                var ImgStream = new System.IO.MemoryStream((Byte[])dr[5]);
                tsm.Image = Image.FromStream(ImgStream);
            }
            if (parent.GetType() == typeof(MenuStrip))
                ((MenuStrip)parent).Items.Add(tsm);
            else
                ((ToolStripMenuItem)parent).DropDownItems.Add(tsm);
            return tsm;
        }

        private void ItemMenu_Click(object sender, EventArgs e)
        {
            var FormName = SqlService.GetDataTable("select FormName from MenuApp where ID =" + ((ToolStripItem)sender).Name).Rows[0][0].ToString();
            if (FormName != "")
            {
                var frm = new Form();
                frm = CreateObjectInstance(FormName);
                frm.Name = FormName;
                ShowFormToPanel(frm);
            }
        }
        private Form CreateObjectInstance(String objectName)
        {
            Form form;
            try
            {
                form = Activator.CreateInstance(Type.GetType("MYAPPCS." + objectName)) as Form;
            }
            catch (Exception)
            {
                form = new Form();
            }
            return form;
        }
        #endregion

        #region showup FOrmchild

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetOpenForm.GetForm("FormLogin").Show();
            LogApp.Logout();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            foreach (Control control in PanelFormFill.Controls)
            {
                if (control.Tag.ToString() != "NoForm")
                    if (control.Visible && ((Form)control).WindowState != FormWindowState.Minimized)
                    {
                        ((Form)control).Close();
                        break;
                    }
            }
            GetTopFormChild();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            foreach (Control control in PanelFormFill.Controls)
            {
                if (control.Tag.ToString() != "NoForm")
                    if (control.Visible && ((Form)control).WindowState != FormWindowState.Minimized)
                    {
                        ((Form)control).WindowState = FormWindowState.Minimized;
                        ((Form)control).BringToFront();
                        break;
                    }
            }
            GetTopFormChild();
        }

        #region "untuk mengetahui form child yang paling atas yang tampil"
        private void GetTopFormChild()
        {
            foreach (Control control in PanelFormFill.Controls)
            {
                if (control.Tag.ToString() != "NoForm")
                    if (control.Visible && ((Form)control).WindowState != FormWindowState.Minimized)
                    {
                        LabelTitle.Text = ((Form)control).Text;
                        FormActive = ((Form)control).Name;
                        break;
                    }
            }
        }
        #endregion
        #region "agar form child minimize ada di paling atas"
        private void BringFomMinimizeToFront()
        {
            foreach (Control control in PanelFormFill.Controls)
            {
                if (control.Tag.ToString() != "NoForm")
                    if (((Form)control).WindowState == FormWindowState.Minimized)
                    {
                        ((Form)control).BringToFront();
                    }
            }
        }
        #endregion
        #endregion

        #region "Timer"
        int counterSecond = 0;
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            LabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LabelClock.Text = DateTime.Now.ToString("hh:mm:ss");
            counterSecond = counterSecond + 1;
            LabelCounter.Text = ConvertSecondToHours(counterSecond);
            LabelSignal.Tag = SignalChecker("localhost");
            if ((long)LabelSignal.Tag == 999)
                PictureBoxSignal.Image = MYAPPCS.Properties.Resources.sgnal_no;
            else if ((long)LabelSignal.Tag < 1)
                PictureBoxSignal.Image = MYAPPCS.Properties.Resources.signal_hight;
            else if ((long)LabelSignal.Tag >= 1)
                PictureBoxSignal.Image = MYAPPCS.Properties.Resources.signal_low;
        }

        #region "ngeping"
        long SignalChecker(String ip)
        {
            try
            {
                var ping = new System.Net.NetworkInformation.Ping();
                return ping.Send(ip).RoundtripTime;
            }
            catch (Exception)
            {
                return 999;
            }
        }
        #endregion

        #region "funsi convert detik ke jam"
        private String ConvertSecondToHours(int second)
        {
            int Hrs;
            int Min;
            int Sec;
            Sec = second % 60;
            Min = ((second - Sec) / 60) % 60;
            Hrs = ((second - (Sec + (Min * 60))) / 3600);
            return Hrs.ToString("00") + ":" + Min.ToString("00") + ":" + Sec.ToString("00");
        }
        #endregion

        #endregion


        #region FormMain FUngsi
        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            ShowFormToPanel(new FormAccount());
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void btnNotif_Click(object sender, EventArgs e)
        {
            ShowFormToPanel(new FormChatting());
        }
        #endregion
    }

    #endregion

    #region "Membuat Custom Desain Menu Strip"
    public class MyRender : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {

            e.Item.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            e.Item.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            e.Item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            e.Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            e.Item.ForeColor = Color.White;
            var rc = new Rectangle(Point.Empty, e.Item.Size);
            var genap = (e.ToolStrip.Items.IndexOf(e.Item) % 2 == 0);
            var color = (e.Item.Selected) ? System.Drawing.Color.FromArgb(29, 56, 84) : (genap) ? Color.SteelBlue : Color.FromArgb(51, 133, 166);
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, rc);
            }

        }
    }
    #endregion
}
