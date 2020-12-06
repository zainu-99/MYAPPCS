namespace MYAPPCS
{
    partial class FormMenuApp
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.OrderSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.GroupBoxInputData = new System.Windows.Forms.GroupBox();
            this.NumericUpDownOrderSort = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboBoxTag = new System.Windows.Forms.ComboBox();
            this.ComboBoxParentMenu = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBoxOpenFormName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxMenuText = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.MenuStripAction = new System.Windows.Forms.MenuStrip();
            this.ButtonAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxIconMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.GroupBoxInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOrderSort)).BeginInit();
            this.PanelButton.SuspendLayout();
            this.MenuStripAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIconMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu,
            this.MenuID,
            this.MenuTag,
            this.MenuText,
            this.OpenForm,
            this.Parent,
            this.Icon,
            this.OrderSort});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(12, 249);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dgv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(9);
            this.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.RowTemplate.Height = 39;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1042, 235);
            this.dgv.TabIndex = 40;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            // 
            // MenuID
            // 
            this.MenuID.HeaderText = "MenuID";
            this.MenuID.Name = "MenuID";
            this.MenuID.ReadOnly = true;
            // 
            // MenuTag
            // 
            this.MenuTag.HeaderText = "MenuTag";
            this.MenuTag.Name = "MenuTag";
            this.MenuTag.ReadOnly = true;
            // 
            // MenuText
            // 
            this.MenuText.HeaderText = "MenuText";
            this.MenuText.Name = "MenuText";
            this.MenuText.ReadOnly = true;
            // 
            // OpenForm
            // 
            this.OpenForm.HeaderText = "OpenForm";
            this.OpenForm.Name = "OpenForm";
            this.OpenForm.ReadOnly = true;
            // 
            // Parent
            // 
            this.Parent.HeaderText = "Parent";
            this.Parent.Name = "Parent";
            this.Parent.ReadOnly = true;
            // 
            // Icon
            // 
            this.Icon.HeaderText = "Icon";
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            this.Icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OrderSort
            // 
            this.OrderSort.HeaderText = "OrderSort";
            this.OrderSort.Name = "OrderSort";
            this.OrderSort.ReadOnly = true;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Teal;
            this.Label7.Location = new System.Drawing.Point(864, 180);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 15);
            this.Label7.TabIndex = 39;
            this.Label7.Text = "Search";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(872, 197);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(176, 27);
            this.TextBoxSearch.TabIndex = 38;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // GroupBoxInputData
            // 
            this.GroupBoxInputData.Controls.Add(this.NumericUpDownOrderSort);
            this.GroupBoxInputData.Controls.Add(this.Label1);
            this.GroupBoxInputData.Controls.Add(this.ComboBoxTag);
            this.GroupBoxInputData.Controls.Add(this.ComboBoxParentMenu);
            this.GroupBoxInputData.Controls.Add(this.PictureBoxIconMenu);
            this.GroupBoxInputData.Controls.Add(this.Label6);
            this.GroupBoxInputData.Controls.Add(this.Label5);
            this.GroupBoxInputData.Controls.Add(this.TextBoxOpenFormName);
            this.GroupBoxInputData.Controls.Add(this.Label4);
            this.GroupBoxInputData.Controls.Add(this.Label2);
            this.GroupBoxInputData.Controls.Add(this.TextBoxMenuText);
            this.GroupBoxInputData.Controls.Add(this.Label3);
            this.GroupBoxInputData.Enabled = false;
            this.GroupBoxInputData.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxInputData.Name = "GroupBoxInputData";
            this.GroupBoxInputData.Size = new System.Drawing.Size(683, 168);
            this.GroupBoxInputData.TabIndex = 36;
            this.GroupBoxInputData.TabStop = false;
            this.GroupBoxInputData.Text = "Input Menu";
            // 
            // NumericUpDownOrderSort
            // 
            this.NumericUpDownOrderSort.Location = new System.Drawing.Point(486, 62);
            this.NumericUpDownOrderSort.Name = "NumericUpDownOrderSort";
            this.NumericUpDownOrderSort.Size = new System.Drawing.Size(191, 27);
            this.NumericUpDownOrderSort.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(379, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 20);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Order Sort";
            // 
            // ComboBoxTag
            // 
            this.ComboBoxTag.FormattingEnabled = true;
            this.ComboBoxTag.Location = new System.Drawing.Point(160, 29);
            this.ComboBoxTag.Name = "ComboBoxTag";
            this.ComboBoxTag.Size = new System.Drawing.Size(187, 28);
            this.ComboBoxTag.TabIndex = 13;
            // 
            // ComboBoxParentMenu
            // 
            this.ComboBoxParentMenu.FormattingEnabled = true;
            this.ComboBoxParentMenu.Location = new System.Drawing.Point(486, 29);
            this.ComboBoxParentMenu.Name = "ComboBoxParentMenu";
            this.ComboBoxParentMenu.Size = new System.Drawing.Size(191, 28);
            this.ComboBoxParentMenu.TabIndex = 12;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(379, 96);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 20);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Icon Menu";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(379, 29);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 20);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Parent Menu";
            // 
            // TextBoxOpenFormName
            // 
            this.TextBoxOpenFormName.Location = new System.Drawing.Point(160, 96);
            this.TextBoxOpenFormName.Name = "TextBoxOpenFormName";
            this.TextBoxOpenFormName.Size = new System.Drawing.Size(187, 27);
            this.TextBoxOpenFormName.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(28, 98);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(126, 20);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Open Form Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Role Name";
            // 
            // TextBoxMenuText
            // 
            this.TextBoxMenuText.Location = new System.Drawing.Point(160, 63);
            this.TextBoxMenuText.Name = "TextBoxMenuText";
            this.TextBoxMenuText.Size = new System.Drawing.Size(187, 27);
            this.TextBoxMenuText.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(28, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 20);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Menu Text";
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.MenuStripAction);
            this.PanelButton.Location = new System.Drawing.Point(12, 188);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(396, 39);
            this.PanelButton.TabIndex = 60;
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
            // PictureBoxIconMenu
            // 
            this.PictureBoxIconMenu.BackColor = System.Drawing.Color.Maroon;
            this.PictureBoxIconMenu.Image = global::MYAPPCS.Properties.Resources.iconmenu;
            this.PictureBoxIconMenu.Location = new System.Drawing.Point(486, 94);
            this.PictureBoxIconMenu.Name = "PictureBoxIconMenu";
            this.PictureBoxIconMenu.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxIconMenu.TabIndex = 11;
            this.PictureBoxIconMenu.TabStop = false;
            this.PictureBoxIconMenu.Click += new System.EventHandler(this.PictureBoxIconMenu_Click);
            // 
            // FormMenuApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 496);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.GroupBoxInputData);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenuApp";
            this.Tag = "Menu";
            this.Text = "FormMenuApp";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Shown += new System.EventHandler(this.FormMenuApp_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.GroupBoxInputData.ResumeLayout(false);
            this.GroupBoxInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOrderSort)).EndInit();
            this.PanelButton.ResumeLayout(false);
            this.PanelButton.PerformLayout();
            this.MenuStripAction.ResumeLayout(false);
            this.MenuStripAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIconMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        internal System.Windows.Forms.DataGridViewTextBoxColumn Menu;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        internal System.Windows.Forms.DataGridViewTextBoxColumn MenuID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MenuTag;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MenuText;
        internal System.Windows.Forms.DataGridViewTextBoxColumn OpenForm;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        internal System.Windows.Forms.DataGridViewTextBoxColumn Parent;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        internal System.Windows.Forms.DataGridViewImageColumn Icon;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        internal System.Windows.Forms.DataGridViewTextBoxColumn OrderSort;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TextBoxSearch;
        internal System.Windows.Forms.GroupBox GroupBoxInputData;
        internal System.Windows.Forms.NumericUpDown NumericUpDownOrderSort;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox ComboBoxTag;
        internal System.Windows.Forms.ComboBox ComboBoxParentMenu;
        internal System.Windows.Forms.PictureBox PictureBoxIconMenu;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBoxOpenFormName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxMenuText;
        internal System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Panel PanelButton;
        internal System.Windows.Forms.MenuStrip MenuStripAction;
        internal System.Windows.Forms.ToolStripMenuItem ButtonAdd;
        internal System.Windows.Forms.ToolStripMenuItem ButtonEdit;
        internal System.Windows.Forms.ToolStripMenuItem ButtonSave;
        internal System.Windows.Forms.ToolStripMenuItem ButtonDelete;
        internal System.Windows.Forms.ToolStripMenuItem ButtonRefresh;
    }
}