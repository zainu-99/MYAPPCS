namespace MYAPPCS
{
    partial class FormUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.PanelButton = new System.Windows.Forms.Panel();
            this.MenuStripAction = new System.Windows.Forms.MenuStrip();
            this.ButtonAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxInputData = new System.Windows.Forms.GroupBox();
            this.ButtonUserAccess = new System.Windows.Forms.Button();
            this.ButtonUserGroup = new System.Windows.Forms.Button();
            this.PanelGender = new System.Windows.Forms.Panel();
            this.RadioButtonPemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.RadioButtonNonAktif = new System.Windows.Forms.RadioButton();
            this.RadioButtonAktif = new System.Windows.Forms.RadioButton();
            this.ButtonOpenGaleri = new System.Windows.Forms.Button();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.TextBoxNohp = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBoxUserId = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PanelDgv = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxEntries = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BindingNavigatorPaging = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSourcePaging = new System.Windows.Forms.BindingSource(this.components);
            this.PanelButton.SuspendLayout();
            this.MenuStripAction.SuspendLayout();
            this.GroupBoxInputData.SuspendLayout();
            this.PanelGender.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            this.PanelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorPaging)).BeginInit();
            this.BindingNavigatorPaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePaging)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.MenuStripAction);
            this.PanelButton.Location = new System.Drawing.Point(15, 234);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(396, 38);
            this.PanelButton.TabIndex = 36;
            // 
            // MenuStripAction
            // 
            this.MenuStripAction.BackColor = System.Drawing.Color.Transparent;
            this.MenuStripAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAdd,
            this.ButtonEdit,
            this.ButtonSave,
            this.ButtonDelete,
            this.ButtonRefresh});
            this.MenuStripAction.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAction.Name = "MenuStripAction";
            this.MenuStripAction.Size = new System.Drawing.Size(396, 42);
            this.MenuStripAction.TabIndex = 0;
            this.MenuStripAction.Text = "MenuStrip1";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Teal;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAdd.Image = global::MYAPPCS.Properties.Resources.add;
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Padding = new System.Windows.Forms.Padding(7);
            this.ButtonAdd.Size = new System.Drawing.Size(63, 34);
            this.ButtonAdd.Tag = "ButtonAdd";
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonEdit.Image = global::MYAPPCS.Properties.Resources.edit;
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Padding = new System.Windows.Forms.Padding(7);
            this.ButtonEdit.Size = new System.Drawing.Size(61, 34);
            this.ButtonEdit.Tag = "ButtonEdit";
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonSave.Image = global::MYAPPCS.Properties.Resources.save;
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Padding = new System.Windows.Forms.Padding(7);
            this.ButtonSave.Size = new System.Drawing.Size(66, 34);
            this.ButtonSave.Tag = "ButtonSave";
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDelete.Image = global::MYAPPCS.Properties.Resources.delete;
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Padding = new System.Windows.Forms.Padding(7);
            this.ButtonDelete.Size = new System.Drawing.Size(75, 34);
            this.ButtonDelete.Tag = "ButtonDelete";
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.Crimson;
            this.ButtonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonRefresh.Image = global::MYAPPCS.Properties.Resources.refresh;
            this.ButtonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Padding = new System.Windows.Forms.Padding(7);
            this.ButtonRefresh.Size = new System.Drawing.Size(80, 34);
            this.ButtonRefresh.Tag = "ButtonRefresh";
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // GroupBoxInputData
            // 
            this.GroupBoxInputData.Controls.Add(this.ButtonUserAccess);
            this.GroupBoxInputData.Controls.Add(this.ButtonUserGroup);
            this.GroupBoxInputData.Controls.Add(this.PanelGender);
            this.GroupBoxInputData.Controls.Add(this.PanelStatus);
            this.GroupBoxInputData.Controls.Add(this.ButtonOpenGaleri);
            this.GroupBoxInputData.Controls.Add(this.PictureBoxProfile);
            this.GroupBoxInputData.Controls.Add(this.TextBoxPassword);
            this.GroupBoxInputData.Controls.Add(this.Label12);
            this.GroupBoxInputData.Controls.Add(this.TextBoxNohp);
            this.GroupBoxInputData.Controls.Add(this.Label9);
            this.GroupBoxInputData.Controls.Add(this.Label8);
            this.GroupBoxInputData.Controls.Add(this.TextBoxAddress);
            this.GroupBoxInputData.Controls.Add(this.Label7);
            this.GroupBoxInputData.Controls.Add(this.Label6);
            this.GroupBoxInputData.Controls.Add(this.TextBoxName);
            this.GroupBoxInputData.Controls.Add(this.Label5);
            this.GroupBoxInputData.Controls.Add(this.TextBoxEmail);
            this.GroupBoxInputData.Controls.Add(this.Label4);
            this.GroupBoxInputData.Controls.Add(this.TextBoxUserId);
            this.GroupBoxInputData.Controls.Add(this.Label3);
            this.GroupBoxInputData.Enabled = false;
            this.GroupBoxInputData.Location = new System.Drawing.Point(15, 50);
            this.GroupBoxInputData.Name = "GroupBoxInputData";
            this.GroupBoxInputData.Size = new System.Drawing.Size(881, 154);
            this.GroupBoxInputData.TabIndex = 34;
            this.GroupBoxInputData.TabStop = false;
            this.GroupBoxInputData.Text = "Form Input Data";
            // 
            // ButtonUserAccess
            // 
            this.ButtonUserAccess.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonUserAccess.FlatAppearance.BorderSize = 0;
            this.ButtonUserAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUserAccess.ForeColor = System.Drawing.Color.White;
            this.ButtonUserAccess.Location = new System.Drawing.Point(750, 93);
            this.ButtonUserAccess.Name = "ButtonUserAccess";
            this.ButtonUserAccess.Size = new System.Drawing.Size(98, 29);
            this.ButtonUserAccess.TabIndex = 24;
            this.ButtonUserAccess.Text = "User Access";
            this.ButtonUserAccess.UseVisualStyleBackColor = false;
            this.ButtonUserAccess.Click += new System.EventHandler(this.ButtonUserAccess_Click);
            // 
            // ButtonUserGroup
            // 
            this.ButtonUserGroup.BackColor = System.Drawing.Color.DarkCyan;
            this.ButtonUserGroup.FlatAppearance.BorderSize = 0;
            this.ButtonUserGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUserGroup.ForeColor = System.Drawing.Color.White;
            this.ButtonUserGroup.Location = new System.Drawing.Point(750, 62);
            this.ButtonUserGroup.Name = "ButtonUserGroup";
            this.ButtonUserGroup.Size = new System.Drawing.Size(98, 29);
            this.ButtonUserGroup.TabIndex = 23;
            this.ButtonUserGroup.Text = "User Group";
            this.ButtonUserGroup.UseVisualStyleBackColor = false;
            this.ButtonUserGroup.Click += new System.EventHandler(this.ButtonUserGroup_Click);
            // 
            // PanelGender
            // 
            this.PanelGender.Controls.Add(this.RadioButtonPemale);
            this.PanelGender.Controls.Add(this.RadioButtonMale);
            this.PanelGender.Location = new System.Drawing.Point(403, 50);
            this.PanelGender.Name = "PanelGender";
            this.PanelGender.Size = new System.Drawing.Size(197, 23);
            this.PanelGender.TabIndex = 22;
            // 
            // RadioButtonPemale
            // 
            this.RadioButtonPemale.AutoSize = true;
            this.RadioButtonPemale.Location = new System.Drawing.Point(78, 3);
            this.RadioButtonPemale.Name = "RadioButtonPemale";
            this.RadioButtonPemale.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonPemale.TabIndex = 8;
            this.RadioButtonPemale.TabStop = true;
            this.RadioButtonPemale.Text = "Female";
            this.RadioButtonPemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(8, 3);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonMale.TabIndex = 7;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // PanelStatus
            // 
            this.PanelStatus.Controls.Add(this.RadioButtonNonAktif);
            this.PanelStatus.Controls.Add(this.RadioButtonAktif);
            this.PanelStatus.Location = new System.Drawing.Point(87, 83);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(197, 23);
            this.PanelStatus.TabIndex = 19;
            // 
            // RadioButtonNonAktif
            // 
            this.RadioButtonNonAktif.AutoSize = true;
            this.RadioButtonNonAktif.Location = new System.Drawing.Point(78, 3);
            this.RadioButtonNonAktif.Name = "RadioButtonNonAktif";
            this.RadioButtonNonAktif.Size = new System.Drawing.Size(69, 17);
            this.RadioButtonNonAktif.TabIndex = 4;
            this.RadioButtonNonAktif.TabStop = true;
            this.RadioButtonNonAktif.Text = "Non Aktif";
            this.RadioButtonNonAktif.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAktif
            // 
            this.RadioButtonAktif.AutoSize = true;
            this.RadioButtonAktif.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonAktif.Name = "RadioButtonAktif";
            this.RadioButtonAktif.Size = new System.Drawing.Size(46, 17);
            this.RadioButtonAktif.TabIndex = 3;
            this.RadioButtonAktif.TabStop = true;
            this.RadioButtonAktif.Text = "Aktif";
            this.RadioButtonAktif.UseVisualStyleBackColor = true;
            // 
            // ButtonOpenGaleri
            // 
            this.ButtonOpenGaleri.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonOpenGaleri.FlatAppearance.BorderSize = 0;
            this.ButtonOpenGaleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOpenGaleri.ForeColor = System.Drawing.Color.White;
            this.ButtonOpenGaleri.Location = new System.Drawing.Point(750, 31);
            this.ButtonOpenGaleri.Name = "ButtonOpenGaleri";
            this.ButtonOpenGaleri.Size = new System.Drawing.Size(98, 29);
            this.ButtonOpenGaleri.TabIndex = 18;
            this.ButtonOpenGaleri.Text = "Open Galeri";
            this.ButtonOpenGaleri.UseVisualStyleBackColor = false;
            this.ButtonOpenGaleri.Click += new System.EventHandler(this.ButtonOpenGaleri_Click);
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Image = global::MYAPPCS.Properties.Resources.user;
            this.PictureBoxProfile.Location = new System.Drawing.Point(606, 20);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(120, 120);
            this.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfile.TabIndex = 17;
            this.PictureBoxProfile.TabStop = false;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(403, 116);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(197, 27);
            this.TextBoxPassword.TabIndex = 10;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(325, 119);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(53, 13);
            this.Label12.TabIndex = 15;
            this.Label12.Text = "Password";
            // 
            // TextBoxNohp
            // 
            this.TextBoxNohp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNohp.Location = new System.Drawing.Point(403, 83);
            this.TextBoxNohp.Name = "TextBoxNohp";
            this.TextBoxNohp.Size = new System.Drawing.Size(197, 24);
            this.TextBoxNohp.TabIndex = 9;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(325, 86);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(39, 13);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "No HP";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(325, 54);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(42, 13);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "Gender";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(87, 116);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(197, 24);
            this.TextBoxAddress.TabIndex = 5;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(25, 120);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 13);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Address";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(25, 86);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(37, 13);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Status";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(87, 52);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(197, 24);
            this.TextBoxName.TabIndex = 2;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(25, 58);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Name";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.Location = new System.Drawing.Point(403, 19);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(197, 24);
            this.TextBoxEmail.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(325, 25);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Email";
            // 
            // TextBoxUserId
            // 
            this.TextBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserId.Location = new System.Drawing.Point(87, 21);
            this.TextBoxUserId.Name = "TextBoxUserId";
            this.TextBoxUserId.Size = new System.Drawing.Size(197, 24);
            this.TextBoxUserId.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(25, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "User Id";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(742, 7);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(176, 24);
            this.TextBoxSearch.TabIndex = 32;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Teal;
            this.Label1.Location = new System.Drawing.Point(11, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 20);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "Data User";
            // 
            // PanelDgv
            // 
            this.PanelDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDgv.Controls.Add(this.dgv);
            this.PanelDgv.Controls.Add(this.Panel1);
            this.PanelDgv.Controls.Add(this.BindingNavigatorPaging);
            this.PanelDgv.Location = new System.Drawing.Point(13, 279);
            this.PanelDgv.Name = "PanelDgv";
            this.PanelDgv.Size = new System.Drawing.Size(926, 300);
            this.PanelDgv.TabIndex = 37;
            // 
            // dgv
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.Location = new System.Drawing.Point(6, 71);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.RowTemplate.Height = 35;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(912, 226);
            this.dgv.TabIndex = 33;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.ComboBoxEntries);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.label13);
            this.Panel1.Controls.Add(this.TextBoxSearch);
            this.Panel1.Location = new System.Drawing.Point(0, 28);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(925, 37);
            this.Panel1.TabIndex = 32;
            // 
            // ComboBoxEntries
            // 
            this.ComboBoxEntries.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEntries.FormattingEnabled = true;
            this.ComboBoxEntries.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.ComboBoxEntries.Location = new System.Drawing.Point(45, 4);
            this.ComboBoxEntries.Name = "ComboBoxEntries";
            this.ComboBoxEntries.Size = new System.Drawing.Size(96, 28);
            this.ComboBoxEntries.TabIndex = 5;
            this.ComboBoxEntries.Text = "10";
            this.ComboBoxEntries.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEntries_SelectedIndexChanged);
            this.ComboBoxEntries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxEntries_KeyPress);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Teal;
            this.Label11.Location = new System.Drawing.Point(152, 9);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(42, 15);
            this.Label11.TabIndex = 4;
            this.Label11.Text = "Entries";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Teal;
            this.Label10.Location = new System.Drawing.Point(10, 10);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(36, 15);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "Show";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(698, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Search";
            // 
            // BindingNavigatorPaging
            // 
            this.BindingNavigatorPaging.AddNewItem = null;
            this.BindingNavigatorPaging.CountItem = this.BindingNavigatorCountItem;
            this.BindingNavigatorPaging.DeleteItem = null;
            this.BindingNavigatorPaging.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2});
            this.BindingNavigatorPaging.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorPaging.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.BindingNavigatorPaging.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.BindingNavigatorPaging.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.BindingNavigatorPaging.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.BindingNavigatorPaging.Name = "BindingNavigatorPaging";
            this.BindingNavigatorPaging.PositionItem = this.BindingNavigatorPositionItem;
            this.BindingNavigatorPaging.Size = new System.Drawing.Size(926, 25);
            this.BindingNavigatorPaging.TabIndex = 31;
            this.BindingNavigatorPaging.Text = "BindingNavigator1";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.BindingNavigatorCountItem.Text = "of {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingSourcePaging
            // 
            this.bindingSourcePaging.PositionChanged += new System.EventHandler(this.bindingSourcePaging_PositionChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 591);
            this.Controls.Add(this.PanelDgv);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.GroupBoxInputData);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.Tag = "User";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.PanelButton.ResumeLayout(false);
            this.PanelButton.PerformLayout();
            this.MenuStripAction.ResumeLayout(false);
            this.MenuStripAction.PerformLayout();
            this.GroupBoxInputData.ResumeLayout(false);
            this.GroupBoxInputData.PerformLayout();
            this.PanelGender.ResumeLayout(false);
            this.PanelGender.PerformLayout();
            this.PanelStatus.ResumeLayout(false);
            this.PanelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            this.PanelDgv.ResumeLayout(false);
            this.PanelDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorPaging)).EndInit();
            this.BindingNavigatorPaging.ResumeLayout(false);
            this.BindingNavigatorPaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePaging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelButton;
        internal System.Windows.Forms.MenuStrip MenuStripAction;
        internal System.Windows.Forms.ToolStripMenuItem ButtonAdd;
        internal System.Windows.Forms.ToolStripMenuItem ButtonEdit;
        internal System.Windows.Forms.ToolStripMenuItem ButtonSave;
        internal System.Windows.Forms.ToolStripMenuItem ButtonDelete;
        internal System.Windows.Forms.ToolStripMenuItem ButtonRefresh;
        internal System.Windows.Forms.GroupBox GroupBoxInputData;
        internal System.Windows.Forms.Panel PanelGender;
        internal System.Windows.Forms.RadioButton RadioButtonPemale;
        internal System.Windows.Forms.RadioButton RadioButtonMale;
        internal System.Windows.Forms.Panel PanelStatus;
        internal System.Windows.Forms.RadioButton RadioButtonNonAktif;
        internal System.Windows.Forms.RadioButton RadioButtonAktif;
        internal System.Windows.Forms.Button ButtonOpenGaleri;
        internal System.Windows.Forms.PictureBox PictureBoxProfile;
        internal System.Windows.Forms.TextBox TextBoxPassword;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox TextBoxNohp;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TextBoxAddress;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBoxName;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBoxEmail;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBoxUserId;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBoxSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ButtonUserAccess;
        internal System.Windows.Forms.Button ButtonUserGroup;
        internal System.Windows.Forms.Panel PanelDgv;
        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox ComboBoxEntries;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.BindingNavigator BindingNavigatorPaging;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSourcePaging;
    }
}