namespace MYAPPCS
{
    partial class FormLogin
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
            this.Label1 = new System.Windows.Forms.Label();
            this.CheckBoxRemember = new System.Windows.Forms.CheckBox();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelUserId = new System.Windows.Forms.Panel();
            this.TextBoxUserId = new System.Windows.Forms.TextBox();
            this.LabelUserId = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelPassword.SuspendLayout();
            this.PanelUserId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(110, 293);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(175, 15);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Created By zainu.developer@gmail.com";
            // 
            // CheckBoxRemember
            // 
            this.CheckBoxRemember.AutoSize = true;
            this.CheckBoxRemember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxRemember.ForeColor = System.Drawing.Color.DimGray;
            this.CheckBoxRemember.Location = new System.Drawing.Point(31, 218);
            this.CheckBoxRemember.Name = "CheckBoxRemember";
            this.CheckBoxRemember.Size = new System.Drawing.Size(137, 19);
            this.CheckBoxRemember.TabIndex = 27;
            this.CheckBoxRemember.Text = "Remember Password";
            this.CheckBoxRemember.UseVisualStyleBackColor = true;
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelPassword.Controls.Add(this.PictureBox2);
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Location = new System.Drawing.Point(31, 154);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(332, 39);
            this.PanelPassword.TabIndex = 26;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxPassword.Location = new System.Drawing.Point(37, 7);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(249, 26);
            this.TextBoxPassword.TabIndex = 10;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // PanelUserId
            // 
            this.PanelUserId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelUserId.Controls.Add(this.PictureBox1);
            this.PanelUserId.Controls.Add(this.TextBoxUserId);
            this.PanelUserId.Location = new System.Drawing.Point(32, 94);
            this.PanelUserId.Name = "PanelUserId";
            this.PanelUserId.Size = new System.Drawing.Size(332, 39);
            this.PanelUserId.TabIndex = 25;
            // 
            // TextBoxUserId
            // 
            this.TextBoxUserId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUserId.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserId.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TextBoxUserId.Location = new System.Drawing.Point(37, 8);
            this.TextBoxUserId.Name = "TextBoxUserId";
            this.TextBoxUserId.Size = new System.Drawing.Size(250, 25);
            this.TextBoxUserId.TabIndex = 9;
            this.TextBoxUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelUserId
            // 
            this.LabelUserId.AutoSize = true;
            this.LabelUserId.BackColor = System.Drawing.Color.Transparent;
            this.LabelUserId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserId.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LabelUserId.Location = new System.Drawing.Point(28, 76);
            this.LabelUserId.Name = "LabelUserId";
            this.LabelUserId.Size = new System.Drawing.Size(43, 15);
            this.LabelUserId.TabIndex = 22;
            this.LabelUserId.Text = "User Id";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LabelPassword.Location = new System.Drawing.Point(29, 136);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(57, 15);
            this.LabelPassword.TabIndex = 21;
            this.LabelPassword.Text = "Password";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label5.Location = new System.Drawing.Point(43, 3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(95, 32);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Sign In";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonLogin.Location = new System.Drawing.Point(203, 208);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(161, 35);
            this.ButtonLogin.TabIndex = 23;
            this.ButtonLogin.Text = "Sign In";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Image = global::MYAPPCS.Properties.Resources.close;
            this.ButtonClose.Location = new System.Drawing.Point(1, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 28;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox2.Image = global::MYAPPCS.Properties.Resources.key;
            this.PictureBox2.Location = new System.Drawing.Point(294, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Padding = new System.Windows.Forms.Padding(7);
            this.PictureBox2.Size = new System.Drawing.Size(38, 39);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 11;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox1.Image = global::MYAPPCS.Properties.Resources.username;
            this.PictureBox1.Location = new System.Drawing.Point(294, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Padding = new System.Windows.Forms.Padding(7);
            this.PictureBox1.Size = new System.Drawing.Size(38, 39);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 317);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.CheckBoxRemember);
            this.Controls.Add(this.PanelPassword);
            this.Controls.Add(this.PanelUserId);
            this.Controls.Add(this.LabelUserId);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ButtonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.PanelUserId.ResumeLayout(false);
            this.PanelUserId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ButtonClose;
        internal System.Windows.Forms.CheckBox CheckBoxRemember;
        internal System.Windows.Forms.Panel PanelPassword;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.TextBox TextBoxPassword;
        internal System.Windows.Forms.Panel PanelUserId;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox TextBoxUserId;
        internal System.Windows.Forms.Label LabelUserId;
        internal System.Windows.Forms.Label LabelPassword;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button ButtonLogin;
    }
}