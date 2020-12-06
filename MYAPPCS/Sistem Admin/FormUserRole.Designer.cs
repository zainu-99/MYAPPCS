namespace MYAPPCS
{
    partial class FormUserRole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CheckBoxAllDelete = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllEdit = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllAdd = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllView = new System.Windows.Forms.CheckBox();
            this.GroupBoxGroupLevel = new System.Windows.Forms.GroupBox();
            this.ComboBoxGroupLevel = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBoxInputData = new System.Windows.Forms.GroupBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBoxGroupLevel.SuspendLayout();
            this.GroupBoxInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxAllDelete
            // 
            this.CheckBoxAllDelete.AutoSize = true;
            this.CheckBoxAllDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAllDelete.Location = new System.Drawing.Point(259, 133);
            this.CheckBoxAllDelete.Name = "CheckBoxAllDelete";
            this.CheckBoxAllDelete.Size = new System.Drawing.Size(88, 19);
            this.CheckBoxAllDelete.TabIndex = 49;
            this.CheckBoxAllDelete.Text = "All Delete";
            this.CheckBoxAllDelete.UseVisualStyleBackColor = true;
            this.CheckBoxAllDelete.Click += new System.EventHandler(this.CheckBoxAllDelete_Click);
            // 
            // CheckBoxAllEdit
            // 
            this.CheckBoxAllEdit.AutoSize = true;
            this.CheckBoxAllEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAllEdit.Location = new System.Drawing.Point(181, 133);
            this.CheckBoxAllEdit.Name = "CheckBoxAllEdit";
            this.CheckBoxAllEdit.Size = new System.Drawing.Size(71, 19);
            this.CheckBoxAllEdit.TabIndex = 48;
            this.CheckBoxAllEdit.Text = "All Edit";
            this.CheckBoxAllEdit.UseVisualStyleBackColor = true;
            this.CheckBoxAllEdit.Click += new System.EventHandler(this.CheckBoxAllEdit_Click);
            // 
            // CheckBoxAllAdd
            // 
            this.CheckBoxAllAdd.AutoSize = true;
            this.CheckBoxAllAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAllAdd.Location = new System.Drawing.Point(103, 133);
            this.CheckBoxAllAdd.Name = "CheckBoxAllAdd";
            this.CheckBoxAllAdd.Size = new System.Drawing.Size(70, 19);
            this.CheckBoxAllAdd.TabIndex = 47;
            this.CheckBoxAllAdd.Text = "All Add";
            this.CheckBoxAllAdd.UseVisualStyleBackColor = true;
            this.CheckBoxAllAdd.Click += new System.EventHandler(this.CheckBoxAllAdd_Click);
            // 
            // CheckBoxAllView
            // 
            this.CheckBoxAllView.AutoSize = true;
            this.CheckBoxAllView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAllView.Location = new System.Drawing.Point(20, 133);
            this.CheckBoxAllView.Name = "CheckBoxAllView";
            this.CheckBoxAllView.Size = new System.Drawing.Size(76, 19);
            this.CheckBoxAllView.TabIndex = 46;
            this.CheckBoxAllView.Text = "All View";
            this.CheckBoxAllView.UseVisualStyleBackColor = true;
            this.CheckBoxAllView.Click += new System.EventHandler(this.CheckBoxAllView_Click);
            // 
            // GroupBoxGroupLevel
            // 
            this.GroupBoxGroupLevel.Controls.Add(this.ComboBoxGroupLevel);
            this.GroupBoxGroupLevel.Controls.Add(this.Label4);
            this.GroupBoxGroupLevel.Location = new System.Drawing.Point(322, 64);
            this.GroupBoxGroupLevel.Name = "GroupBoxGroupLevel";
            this.GroupBoxGroupLevel.Size = new System.Drawing.Size(311, 54);
            this.GroupBoxGroupLevel.TabIndex = 44;
            this.GroupBoxGroupLevel.TabStop = false;
            this.GroupBoxGroupLevel.Text = "Data Group Level";
            // 
            // ComboBoxGroupLevel
            // 
            this.ComboBoxGroupLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxGroupLevel.FormattingEnabled = true;
            this.ComboBoxGroupLevel.Location = new System.Drawing.Point(91, 16);
            this.ComboBoxGroupLevel.Name = "ComboBoxGroupLevel";
            this.ComboBoxGroupLevel.Size = new System.Drawing.Size(205, 26);
            this.ComboBoxGroupLevel.TabIndex = 6;
            this.ComboBoxGroupLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroupLevel_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(20, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Group Level";
            // 
            // GroupBoxInputData
            // 
            this.GroupBoxInputData.Controls.Add(this.TextBoxUser);
            this.GroupBoxInputData.Controls.Add(this.Label5);
            this.GroupBoxInputData.Location = new System.Drawing.Point(20, 64);
            this.GroupBoxInputData.Name = "GroupBoxInputData";
            this.GroupBoxInputData.Size = new System.Drawing.Size(296, 54);
            this.GroupBoxInputData.TabIndex = 43;
            this.GroupBoxInputData.TabStop = false;
            this.GroupBoxInputData.Text = "Data User";
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.Location = new System.Drawing.Point(55, 16);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.ReadOnly = true;
            this.TextBoxUser.Size = new System.Drawing.Size(235, 24);
            this.TextBoxUser.TabIndex = 7;
            this.TextBoxUser.Tag = "0";
            this.TextBoxUser.Click += new System.EventHandler(this.TextBoxUser_Click);
            this.TextBoxUser.TextChanged += new System.EventHandler(this.TextBoxUser_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(20, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "User";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Role,
            this.Remark,
            this.View,
            this.AllowAdd,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Location = new System.Drawing.Point(20, 156);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.RowTemplate.Height = 35;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1032, 307);
            this.dgv.TabIndex = 40;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Teal;
            this.Label2.Location = new System.Drawing.Point(849, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 42;
            this.Label2.Text = "Search";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(852, 83);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(200, 24);
            this.TextBoxSearch.TabIndex = 41;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Teal;
            this.Label1.Location = new System.Drawing.Point(16, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 20);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Data Role";
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.Color.Teal;
            this.ButtonFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonFilter.FlatAppearance.BorderSize = 0;
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFilter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonFilter.Image = global::MYAPPCS.Properties.Resources.filter;
            this.ButtonFilter.Location = new System.Drawing.Point(639, 70);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(47, 47);
            this.ButtonFilter.TabIndex = 45;
            this.ButtonFilter.UseVisualStyleBackColor = false;
            this.ButtonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowAdd
            // 
            this.AllowAdd.HeaderText = "Add";
            this.AllowAdd.Name = "AllowAdd";
            this.AllowAdd.ReadOnly = true;
            this.AllowAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 483);
            this.Controls.Add(this.CheckBoxAllDelete);
            this.Controls.Add(this.CheckBoxAllEdit);
            this.Controls.Add(this.CheckBoxAllAdd);
            this.Controls.Add(this.CheckBoxAllView);
            this.Controls.Add(this.ButtonFilter);
            this.Controls.Add(this.GroupBoxGroupLevel);
            this.Controls.Add(this.GroupBoxInputData);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Auth";
            this.Text = "FormUserRole";
            this.Load += new System.EventHandler(this.FormUserRole_Load);
            this.GroupBoxGroupLevel.ResumeLayout(false);
            this.GroupBoxGroupLevel.PerformLayout();
            this.GroupBoxInputData.ResumeLayout(false);
            this.GroupBoxInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox CheckBoxAllDelete;
        internal System.Windows.Forms.CheckBox CheckBoxAllEdit;
        internal System.Windows.Forms.CheckBox CheckBoxAllAdd;
        internal System.Windows.Forms.CheckBox CheckBoxAllView;
        internal System.Windows.Forms.Button ButtonFilter;
        internal System.Windows.Forms.GroupBox GroupBoxGroupLevel;
        internal System.Windows.Forms.ComboBox ComboBoxGroupLevel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBoxInputData;
        internal System.Windows.Forms.TextBox TextBoxUser;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxSearch;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewCheckBoxColumn View;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
    }
}