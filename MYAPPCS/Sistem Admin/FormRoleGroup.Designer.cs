namespace MYAPPCS
{
    partial class FormRoleGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBoxInputData = new System.Windows.Forms.GroupBox();
            this.textBoxGroupLevel = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsCustom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccessCustom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBoxInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxInputData
            // 
            this.GroupBoxInputData.Controls.Add(this.textBoxGroupLevel);
            this.GroupBoxInputData.Controls.Add(this.Label5);
            this.GroupBoxInputData.Location = new System.Drawing.Point(19, 67);
            this.GroupBoxInputData.Name = "GroupBoxInputData";
            this.GroupBoxInputData.Size = new System.Drawing.Size(660, 54);
            this.GroupBoxInputData.TabIndex = 46;
            this.GroupBoxInputData.TabStop = false;
            this.GroupBoxInputData.Text = "Data Group Level";
            // 
            // textBoxGroupLevel
            // 
            this.textBoxGroupLevel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupLevel.Location = new System.Drawing.Point(92, 13);
            this.textBoxGroupLevel.Name = "textBoxGroupLevel";
            this.textBoxGroupLevel.ReadOnly = true;
            this.textBoxGroupLevel.Size = new System.Drawing.Size(562, 31);
            this.textBoxGroupLevel.TabIndex = 5;
            this.textBoxGroupLevel.TextChanged += new System.EventHandler(this.textBoxGroupLevel_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(20, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Group Level";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Teal;
            this.Label2.Location = new System.Drawing.Point(848, 66);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Search";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(851, 86);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(200, 24);
            this.TextBoxSearch.TabIndex = 44;
            this.TextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Teal;
            this.Label1.Location = new System.Drawing.Point(50, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 20);
            this.Label1.TabIndex = 42;
            this.Label1.Text = "Data Role Group";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Teal;
            this.ButtonBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonBack.Image = global::MYAPPCS.Properties.Resources.back;
            this.ButtonBack.Location = new System.Drawing.Point(17, 16);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(27, 33);
            this.ButtonBack.TabIndex = 48;
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.Teal;
            this.ButtonRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonRefresh.FlatAppearance.BorderSize = 0;
            this.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonRefresh.Image = global::MYAPPCS.Properties.Resources.filter;
            this.ButtonRefresh.Location = new System.Drawing.Point(685, 72);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(47, 47);
            this.ButtonRefresh.TabIndex = 47;
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
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
            this.IsView,
            this.IsAdd,
            this.IsEdit,
            this.IsDelete,
            this.IsPrint,
            this.IsCustom,
            this.AccessView,
            this.AccessAdd,
            this.AccessEdit,
            this.AccessDelete,
            this.AccessPrint,
            this.AccessCustom});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(19, 139);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.RowTemplate.Height = 35;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1032, 412);
            this.dgv.TabIndex = 49;
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
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
            // IsView
            // 
            this.IsView.DataPropertyName = "Access";
            this.IsView.HeaderText = "Is View";
            this.IsView.Name = "IsView";
            // 
            // IsAdd
            // 
            this.IsAdd.DataPropertyName = "Access";
            this.IsAdd.HeaderText = "Is Add";
            this.IsAdd.Name = "IsAdd";
            // 
            // IsEdit
            // 
            this.IsEdit.DataPropertyName = "Access";
            this.IsEdit.HeaderText = "Is Edit";
            this.IsEdit.Name = "IsEdit";
            // 
            // IsDelete
            // 
            this.IsDelete.DataPropertyName = "Access";
            this.IsDelete.HeaderText = "Is Delete";
            this.IsDelete.Name = "IsDelete";
            // 
            // IsPrint
            // 
            this.IsPrint.DataPropertyName = "Access";
            this.IsPrint.HeaderText = "Is Print";
            this.IsPrint.Name = "IsPrint";
            // 
            // IsCustom
            // 
            this.IsCustom.DataPropertyName = "Access";
            this.IsCustom.HeaderText = "IsCustom";
            this.IsCustom.Name = "IsCustom";
            this.IsCustom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsCustom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.AccessEdit.Visible = false;
            // 
            // AccessDelete
            // 
            this.AccessDelete.HeaderText = "AccessDelete";
            this.AccessDelete.Name = "AccessDelete";
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
            // FormRoleGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 465);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.GroupBoxInputData);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoleGroup";
            this.Tag = "Role Group";
            this.Text = "FormRoleGroup";
            this.GroupBoxInputData.ResumeLayout(false);
            this.GroupBoxInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonBack;
        internal System.Windows.Forms.Button ButtonRefresh;
        internal System.Windows.Forms.GroupBox GroupBoxInputData;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxSearch;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.TextBox textBoxGroupLevel;
        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Role;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn IsView;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn IsAdd;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn IsEdit;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn IsDelete;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn IsPrint;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn IsCustom;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessView;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessAdd;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessEdit;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessDelete;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessPrint;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn AccessCustom;
    }
}