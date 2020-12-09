

namespace MYAPPCS
{
    partial class FormMain
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.PanelStatusBar = new System.Windows.Forms.Panel();
            this.LabelDate = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.LabelCounter = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelClock = new System.Windows.Forms.Label();
            this.PictureBoxSignal = new System.Windows.Forms.PictureBox();
            this.LabelSignal = new System.Windows.Forms.Label();
            this.ProgressBarLoad = new System.Windows.Forms.ProgressBar();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PanelTool = new System.Windows.Forms.Panel();
            this.btnNotif = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.PanelSideBar = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.MenuApp = new System.Windows.Forms.MenuStrip();
            this.PanelProfile = new System.Windows.Forms.Panel();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.LabelNama = new System.Windows.Forms.Label();
            this.ButtonSetting = new System.Windows.Forms.Button();
            this.LabelMenu = new System.Windows.Forms.Label();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.LabelUserId = new System.Windows.Forms.Label();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelRefresh = new System.Windows.Forms.Label();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).BeginInit();
            this.PanelStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignal)).BeginInit();
            this.PanelFooter.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.PanelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.PanelSideBar.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            this.PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.LightGray;
            this.PanelMain.Controls.Add(this.TabControlMain);
            this.PanelMain.Controls.Add(this.PanelStatusBar);
            this.PanelMain.Controls.Add(this.ProgressBarLoad);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(219, 42);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(19, 43, 19, 19);
            this.PanelMain.Size = new System.Drawing.Size(1143, 606);
            this.PanelMain.TabIndex = 7;
            // 
            // TabControlMain
            // 
            this.TabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.TabControlMain.Location = new System.Drawing.Point(17, 51);
            this.TabControlMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.Size = new System.Drawing.Size(1114, 549);
            this.TabControlMain.TabIndex = 11;
            this.TabControlMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControlMain_SelectedPageChanged);
            this.TabControlMain.CloseButtonClick += new System.EventHandler(this.TabControlMain_CloseButtonClick);
            // 
            // PanelStatusBar
            // 
            this.PanelStatusBar.Controls.Add(this.LabelDate);
            this.PanelStatusBar.Controls.Add(this.PictureBox3);
            this.PanelStatusBar.Controls.Add(this.LabelCounter);
            this.PanelStatusBar.Controls.Add(this.PictureBox2);
            this.PanelStatusBar.Controls.Add(this.PictureBox1);
            this.PanelStatusBar.Controls.Add(this.LabelClock);
            this.PanelStatusBar.Controls.Add(this.PictureBoxSignal);
            this.PanelStatusBar.Controls.Add(this.LabelSignal);
            this.PanelStatusBar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelStatusBar.Location = new System.Drawing.Point(18, 6);
            this.PanelStatusBar.Name = "PanelStatusBar";
            this.PanelStatusBar.Size = new System.Drawing.Size(231, 39);
            this.PanelStatusBar.TabIndex = 10;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LabelDate.Location = new System.Drawing.Point(154, 22);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(63, 13);
            this.LabelDate.TabIndex = 15;
            this.LabelDate.Text = "31/01/2019";
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::MYAPPCS.Properties.Resources.date;
            this.PictureBox3.Location = new System.Drawing.Point(175, 3);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(19, 19);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 14;
            this.PictureBox3.TabStop = false;
            // 
            // LabelCounter
            // 
            this.LabelCounter.AutoSize = true;
            this.LabelCounter.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelCounter.Location = new System.Drawing.Point(104, 22);
            this.LabelCounter.Name = "LabelCounter";
            this.LabelCounter.Size = new System.Drawing.Size(49, 13);
            this.LabelCounter.TabIndex = 13;
            this.LabelCounter.Text = "10:00:00";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::MYAPPCS.Properties.Resources.counter;
            this.PictureBox2.Location = new System.Drawing.Point(118, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(19, 19);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::MYAPPCS.Properties.Resources.clock;
            this.PictureBox1.Location = new System.Drawing.Point(65, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(19, 19);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 11;
            this.PictureBox1.TabStop = false;
            // 
            // LabelClock
            // 
            this.LabelClock.AutoSize = true;
            this.LabelClock.ForeColor = System.Drawing.Color.Red;
            this.LabelClock.Location = new System.Drawing.Point(49, 22);
            this.LabelClock.Name = "LabelClock";
            this.LabelClock.Size = new System.Drawing.Size(49, 13);
            this.LabelClock.TabIndex = 10;
            this.LabelClock.Text = "10:00:00";
            // 
            // PictureBoxSignal
            // 
            this.PictureBoxSignal.Image = global::MYAPPCS.Properties.Resources.signal_hight;
            this.PictureBoxSignal.Location = new System.Drawing.Point(13, 3);
            this.PictureBoxSignal.Name = "PictureBoxSignal";
            this.PictureBoxSignal.Size = new System.Drawing.Size(19, 19);
            this.PictureBoxSignal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSignal.TabIndex = 8;
            this.PictureBoxSignal.TabStop = false;
            // 
            // LabelSignal
            // 
            this.LabelSignal.AutoSize = true;
            this.LabelSignal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSignal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelSignal.Location = new System.Drawing.Point(4, 22);
            this.LabelSignal.Name = "LabelSignal";
            this.LabelSignal.Size = new System.Drawing.Size(39, 13);
            this.LabelSignal.TabIndex = 9;
            this.LabelSignal.Text = "Signal";
            // 
            // ProgressBarLoad
            // 
            this.ProgressBarLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarLoad.Location = new System.Drawing.Point(-1, 0);
            this.ProgressBarLoad.Name = "ProgressBarLoad";
            this.ProgressBarLoad.Size = new System.Drawing.Size(1145, 3);
            this.ProgressBarLoad.TabIndex = 7;
            this.ProgressBarLoad.Value = 100;
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.PanelFooter.Controls.Add(this.Label5);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(219, 648);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(1143, 40);
            this.PanelFooter.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(19, 15);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(349, 18);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Copyright © 2019 | Framework by www.deretcode.com";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.Controls.Add(this.PanelTool);
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.Controls.Add(this.btnMenu);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(219, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1143, 42);
            this.PanelHeader.TabIndex = 6;
            // 
            // PanelTool
            // 
            this.PanelTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTool.BackColor = System.Drawing.Color.Transparent;
            this.PanelTool.Controls.Add(this.btnNotif);
            this.PanelTool.Controls.Add(this.btnLogout);
            this.PanelTool.Location = new System.Drawing.Point(960, -3);
            this.PanelTool.Name = "PanelTool";
            this.PanelTool.Size = new System.Drawing.Size(183, 42);
            this.PanelTool.TabIndex = 0;
            // 
            // btnNotif
            // 
            this.btnNotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotif.BackColor = System.Drawing.Color.Transparent;
            this.btnNotif.FlatAppearance.BorderSize = 0;
            this.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotif.Image = global::MYAPPCS.Properties.Resources.notif;
            this.btnNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotif.Location = new System.Drawing.Point(0, 4);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Padding = new System.Windows.Forms.Padding(3);
            this.btnNotif.Size = new System.Drawing.Size(86, 42);
            this.btnNotif.TabIndex = 5;
            this.btnNotif.Text = "0";
            this.btnNotif.UseVisualStyleBackColor = false;
            this.btnNotif.Click += new System.EventHandler(this.btnNotif_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = global::MYAPPCS.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(86, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(3);
            this.btnLogout.Size = new System.Drawing.Size(97, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTitle.Location = new System.Drawing.Point(43, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(178, 23);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "MYAPP CORE SYSTEM";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = global::MYAPPCS.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(-1, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(11);
            this.btnMenu.Size = new System.Drawing.Size(38, 42);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // PanelSideBar
            // 
            this.PanelSideBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.PanelSideBar.Controls.Add(this.PanelMenu);
            this.PanelSideBar.Controls.Add(this.PanelProfile);
            this.PanelSideBar.Controls.Add(this.PanelTitle);
            this.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideBar.Location = new System.Drawing.Point(0, 0);
            this.PanelSideBar.Name = "PanelSideBar";
            this.PanelSideBar.Size = new System.Drawing.Size(219, 688);
            this.PanelSideBar.TabIndex = 4;
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.Teal;
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.PanelInfo);
            this.PanelMenu.Controls.Add(this.MenuApp);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelMenu.Location = new System.Drawing.Point(0, 204);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(219, 484);
            this.PanelMenu.TabIndex = 5;
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.LabelVersion);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfo.Location = new System.Drawing.Point(0, 444);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(219, 40);
            this.PanelInfo.TabIndex = 1;
            // 
            // LabelVersion
            // 
            this.LabelVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelVersion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.Color.White;
            this.LabelVersion.Location = new System.Drawing.Point(0, 0);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(219, 40);
            this.LabelVersion.TabIndex = 1;
            this.LabelVersion.Text = "Version: 1.0.0";
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuApp
            // 
            this.MenuApp.BackColor = System.Drawing.Color.Transparent;
            this.MenuApp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuApp.GripMargin = new System.Windows.Forms.Padding(19);
            this.MenuApp.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MenuApp.Location = new System.Drawing.Point(0, 0);
            this.MenuApp.Name = "MenuApp";
            this.MenuApp.Padding = new System.Windows.Forms.Padding(1);
            this.MenuApp.Size = new System.Drawing.Size(219, 204);
            this.MenuApp.TabIndex = 0;
            this.MenuApp.Text = "MenuStrip";
            // 
            // PanelProfile
            // 
            this.PanelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.PanelProfile.Controls.Add(this.ButtonConnect);
            this.PanelProfile.Controls.Add(this.ButtonHelp);
            this.PanelProfile.Controls.Add(this.LabelNama);
            this.PanelProfile.Controls.Add(this.ButtonSetting);
            this.PanelProfile.Controls.Add(this.LabelMenu);
            this.PanelProfile.Controls.Add(this.PictureBoxProfile);
            this.PanelProfile.Controls.Add(this.LabelUserId);
            this.PanelProfile.Controls.Add(this.ButtonRefresh);
            this.PanelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProfile.Location = new System.Drawing.Point(0, 42);
            this.PanelProfile.Name = "PanelProfile";
            this.PanelProfile.Size = new System.Drawing.Size(219, 162);
            this.PanelProfile.TabIndex = 5;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.FlatAppearance.BorderSize = 0;
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConnect.Image = global::MYAPPCS.Properties.Resources.connect;
            this.ButtonConnect.Location = new System.Drawing.Point(63, 126);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(39, 33);
            this.ButtonConnect.TabIndex = 6;
            this.ButtonConnect.UseVisualStyleBackColor = true;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.FlatAppearance.BorderSize = 0;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHelp.Image = global::MYAPPCS.Properties.Resources.help;
            this.ButtonHelp.Location = new System.Drawing.Point(6, 126);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(39, 33);
            this.ButtonHelp.TabIndex = 5;
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // LabelNama
            // 
            this.LabelNama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNama.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNama.ForeColor = System.Drawing.Color.White;
            this.LabelNama.Location = new System.Drawing.Point(3, 68);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(213, 16);
            this.LabelNama.TabIndex = 4;
            this.LabelNama.Text = "Zainudin";
            this.LabelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetting.FlatAppearance.BorderSize = 0;
            this.ButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetting.Image = global::MYAPPCS.Properties.Resources.setting;
            this.ButtonSetting.Location = new System.Drawing.Point(188, 129);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonSetting.Size = new System.Drawing.Size(25, 23);
            this.ButtonSetting.TabIndex = 2;
            this.ButtonSetting.UseVisualStyleBackColor = true;
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // LabelMenu
            // 
            this.LabelMenu.AutoSize = true;
            this.LabelMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMenu.ForeColor = System.Drawing.Color.White;
            this.LabelMenu.Location = new System.Drawing.Point(56, 103);
            this.LabelMenu.Name = "LabelMenu";
            this.LabelMenu.Size = new System.Drawing.Size(99, 24);
            this.LabelMenu.TabIndex = 1;
            this.LabelMenu.Text = "Menu App";
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBoxProfile.Image = global::MYAPPCS.Properties.Resources.user;
            this.PictureBoxProfile.Location = new System.Drawing.Point(74, 6);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(60, 59);
            this.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfile.TabIndex = 2;
            this.PictureBoxProfile.TabStop = false;
            // 
            // LabelUserId
            // 
            this.LabelUserId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelUserId.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserId.ForeColor = System.Drawing.Color.White;
            this.LabelUserId.Location = new System.Drawing.Point(3, 87);
            this.LabelUserId.Name = "LabelUserId";
            this.LabelUserId.Size = new System.Drawing.Size(213, 16);
            this.LabelUserId.TabIndex = 3;
            this.LabelUserId.Text = "Admin";
            this.LabelUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.FlatAppearance.BorderSize = 0;
            this.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefresh.Image = global::MYAPPCS.Properties.Resources.refresh1;
            this.ButtonRefresh.Location = new System.Drawing.Point(129, 126);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(39, 33);
            this.ButtonRefresh.TabIndex = 1;
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.PanelTitle.Controls.Add(this.LabelRefresh);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(219, 42);
            this.PanelTitle.TabIndex = 1;
            // 
            // LabelRefresh
            // 
            this.LabelRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRefresh.AutoSize = true;
            this.LabelRefresh.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelRefresh.Location = new System.Drawing.Point(48, 7);
            this.LabelRefresh.Name = "LabelRefresh";
            this.LabelRefresh.Size = new System.Drawing.Size(108, 24);
            this.LabelRefresh.TabIndex = 0;
            this.LabelRefresh.Text = "App System";
            this.LabelRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimerMain
            // 
            this.TimerMain.Enabled = true;
            this.TimerMain.Interval = 1000;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 688);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelSideBar);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).EndInit();
            this.PanelStatusBar.ResumeLayout(false);
            this.PanelStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignal)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            this.PanelFooter.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.PanelSideBar.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.PanelInfo.ResumeLayout(false);
            this.PanelProfile.ResumeLayout(false);
            this.PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelMain;
        internal System.Windows.Forms.Panel PanelStatusBar;
        internal System.Windows.Forms.Label LabelDate;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Label LabelCounter;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label LabelClock;
        internal System.Windows.Forms.PictureBox PictureBoxSignal;
        internal System.Windows.Forms.Label LabelSignal;
        internal System.Windows.Forms.ProgressBar ProgressBarLoad;
        internal System.Windows.Forms.Panel PanelFooter;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel PanelHeader;
        internal System.Windows.Forms.Panel PanelTool;
        internal System.Windows.Forms.Button btnNotif;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Label LabelTitle;
        internal System.Windows.Forms.PictureBox btnMenu;
        internal System.Windows.Forms.Panel PanelSideBar;
        internal System.Windows.Forms.Panel PanelMenu;
        internal System.Windows.Forms.Panel PanelInfo;
        internal System.Windows.Forms.Label LabelVersion;
        internal System.Windows.Forms.MenuStrip MenuApp;
        internal System.Windows.Forms.Panel PanelProfile;
        internal System.Windows.Forms.Label LabelNama;
        internal System.Windows.Forms.Label LabelMenu;
        internal System.Windows.Forms.PictureBox PictureBoxProfile;
        internal System.Windows.Forms.Label LabelUserId;
        internal System.Windows.Forms.Panel PanelTitle;
        internal System.Windows.Forms.Button ButtonSetting;
        internal System.Windows.Forms.Button ButtonRefresh;
        internal System.Windows.Forms.Label LabelRefresh;
        internal System.Windows.Forms.Timer TimerMain;
        internal System.Windows.Forms.Button ButtonConnect;
        internal System.Windows.Forms.Button ButtonHelp;
        public DevExpress.XtraTab.XtraTabControl TabControlMain;
    }
}

