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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBoxGroupLevel = new System.Windows.Forms.GroupBox();
            this.ComboBoxGroupLevel = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBoxInputData = new System.Windows.Forms.GroupBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowCustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessCustom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.GroupBoxGroupLevel.SuspendLayout();
            this.GroupBoxInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.TextBoxUser.TextChanged += new System.EventHandler(this.TextBoxUser_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(20, 21);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "User";
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
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Role,
            this.Remark,
            this.AllowView,
            this.AllowAdd,
            this.AllowEdit,
            this.AllowDelete,
            this.AllowPrint,
            this.AllowCustom,
            this.AccessView,
            this.AccessAdd,
            this.AccessEdit,
            this.AccessDelete,
            this.AccessPrint,
            this.AccessCustom});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Location = new System.Drawing.Point(20, 171);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
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
            this.dgv.Size = new System.Drawing.Size(1032, 294);
            this.dgv.TabIndex = 50;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // ID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Role
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Role.DefaultCellStyle = dataGridViewCellStyle3;
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Remark
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Remark.DefaultCellStyle = dataGridViewCellStyle4;
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // AllowView
            // 
            this.AllowView.DataPropertyName = "Access";
            this.AllowView.HeaderText = "View";
            this.AllowView.Name = "AllowView";
            this.AllowView.ReadOnly = true;
            this.AllowView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowAdd
            // 
            this.AllowAdd.DataPropertyName = "Access";
            this.AllowAdd.HeaderText = "Add";
            this.AllowAdd.Name = "AllowAdd";
            this.AllowAdd.ReadOnly = true;
            this.AllowAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowEdit
            // 
            this.AllowEdit.DataPropertyName = "Access";
            this.AllowEdit.HeaderText = "Edit";
            this.AllowEdit.Name = "AllowEdit";
            this.AllowEdit.ReadOnly = true;
            this.AllowEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowDelete
            // 
            this.AllowDelete.DataPropertyName = "Access";
            this.AllowDelete.HeaderText = "Delete";
            this.AllowDelete.Name = "AllowDelete";
            this.AllowDelete.ReadOnly = true;
            this.AllowDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowPrint
            // 
            this.AllowPrint.DataPropertyName = "Access";
            this.AllowPrint.HeaderText = "Print";
            this.AllowPrint.Name = "AllowPrint";
            this.AllowPrint.ReadOnly = true;
            this.AllowPrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowCustom
            // 
            this.AllowCustom.DataPropertyName = "Access";
            this.AllowCustom.HeaderText = "Custom";
            this.AllowCustom.Name = "AllowCustom";
            this.AllowCustom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AccessView
            // 
            this.AccessView.HeaderText = "AccessView";
            this.AccessView.Name = "AccessView";
            this.AccessView.Visible = false;
            // 
            // AccessAdd
            // 
            this.AccessAdd.HeaderText = "AccessAdd";
            this.AccessAdd.Name = "AccessAdd";
            this.AccessAdd.Visible = false;
            // 
            // AccessEdit
            // 
            this.AccessEdit.HeaderText = "AccessEdit";
            this.AccessEdit.Name = "AccessEdit";
            this.AccessEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccessEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccessEdit.Visible = false;
            // 
            // AccessDelete
            // 
            this.AccessDelete.HeaderText = "AccessDelete";
            this.AccessDelete.Name = "AccessDelete";
            this.AccessDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccessDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccessDelete.Visible = false;
            // 
            // AccessPrint
            // 
            this.AccessPrint.HeaderText = "AccessPrint";
            this.AccessPrint.Name = "AccessPrint";
            this.AccessPrint.Visible = false;
            // 
            // AccessCustom
            // 
            this.AccessCustom.HeaderText = "AccessCustom";
            this.AccessCustom.Name = "AccessCustom";
            this.AccessCustom.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Teal;
            this.Label2.Location = new System.Drawing.Point(17, 122);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 52;
            this.Label2.Text = "Search";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(20, 141);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(195, 24);
            this.TextBoxSearch.TabIndex = 51;
            this.TextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            // 
            // FormUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 483);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ButtonFilter);
            this.Controls.Add(this.GroupBoxGroupLevel);
            this.Controls.Add(this.GroupBoxInputData);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "User Access";
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
        internal System.Windows.Forms.Button ButtonFilter;
        internal System.Windows.Forms.GroupBox GroupBoxGroupLevel;
        internal System.Windows.Forms.ComboBox ComboBoxGroupLevel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBoxInputData;
        internal System.Windows.Forms.TextBox TextBoxUser;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Role;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AllowView;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AllowAdd;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AllowEdit;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AllowDelete;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AllowPrint;
        internal System.Windows.Forms.DataGridViewTextBoxColumn AllowCustom;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessView;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessAdd;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessEdit;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessDelete;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessPrint;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessCustom;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxSearch;
    }
}