namespace MYAPPCS
{
    partial class FormChatting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelSentTo = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DataGridViewUser = new System.Windows.Forms.DataGridView();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextBoxSendMessage = new System.Windows.Forms.TextBox();
            this.RichTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSentTo
            // 
            this.LabelSentTo.AutoSize = true;
            this.LabelSentTo.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSentTo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LabelSentTo.Location = new System.Drawing.Point(261, 47);
            this.LabelSentTo.Name = "LabelSentTo";
            this.LabelSentTo.Size = new System.Drawing.Size(130, 20);
            this.LabelSentTo.TabIndex = 55;
            this.LabelSentTo.Text = "Send Message To :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Teal;
            this.Label2.Location = new System.Drawing.Point(212, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 15);
            this.Label2.TabIndex = 54;
            this.Label2.Text = "Search";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(24, 37);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(231, 27);
            this.TextBoxSearch.TabIndex = 53;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridViewUser.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewUser.Location = new System.Drawing.Point(21, 70);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.ReadOnly = true;
            this.DataGridViewUser.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUser.RowTemplate.Height = 33;
            this.DataGridViewUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUser.Size = new System.Drawing.Size(234, 458);
            this.DataGridViewUser.TabIndex = 52;
            this.DataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUser_CellClick);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSend.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonSend.FlatAppearance.BorderSize = 0;
            this.ButtonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSend.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSend.ForeColor = System.Drawing.Color.White;
            this.ButtonSend.Location = new System.Drawing.Point(777, 482);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(135, 46);
            this.ButtonSend.TabIndex = 51;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = false;
            // 
            // TextBoxSendMessage
            // 
            this.TextBoxSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSendMessage.Location = new System.Drawing.Point(261, 482);
            this.TextBoxSendMessage.Multiline = true;
            this.TextBoxSendMessage.Name = "TextBoxSendMessage";
            this.TextBoxSendMessage.Size = new System.Drawing.Size(507, 46);
            this.TextBoxSendMessage.TabIndex = 50;
            // 
            // RichTextBoxChat
            // 
            this.RichTextBoxChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RichTextBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxChat.Location = new System.Drawing.Point(261, 70);
            this.RichTextBoxChat.Name = "RichTextBoxChat";
            this.RichTextBoxChat.ReadOnly = true;
            this.RichTextBoxChat.Size = new System.Drawing.Size(651, 392);
            this.RichTextBoxChat.TabIndex = 49;
            this.RichTextBoxChat.Text = "";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Teal;
            this.Label1.Location = new System.Drawing.Point(16, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 23);
            this.Label1.TabIndex = 48;
            this.Label1.Tag = "Chatting";
            this.Label1.Text = "Chatting";
            // 
            // FormChatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 538);
            this.Controls.Add(this.LabelSentTo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.DataGridViewUser);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.TextBoxSendMessage);
            this.Controls.Add(this.RichTextBoxChat);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChatting";
            this.Tag = "Chatting";
            this.Text = "FormChatting";
            this.Load += new System.EventHandler(this.FormChatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelSentTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxSearch;
        internal System.Windows.Forms.DataGridView DataGridViewUser;
        internal System.Windows.Forms.Button ButtonSend;
        internal System.Windows.Forms.TextBox TextBoxSendMessage;
        internal System.Windows.Forms.RichTextBox RichTextBoxChat;
        internal System.Windows.Forms.Label Label1;
    }
}