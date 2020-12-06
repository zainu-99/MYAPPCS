namespace MYAPPCS
{
    partial class FormErrorReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.GroupBoxFilter = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ComboBoxLimit = new System.Windows.Forms.ComboBox();
            this.DateTimePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.DateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.GroupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.Location = new System.Drawing.Point(14, 89);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 33;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(990, 462);
            this.dgv.TabIndex = 9;
            // 
            // GroupBoxFilter
            // 
            this.GroupBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilter.Controls.Add(this.Label4);
            this.GroupBoxFilter.Controls.Add(this.TextBoxSearch);
            this.GroupBoxFilter.Controls.Add(this.Label3);
            this.GroupBoxFilter.Controls.Add(this.ComboBoxLimit);
            this.GroupBoxFilter.Controls.Add(this.DateTimePickerUntil);
            this.GroupBoxFilter.Controls.Add(this.ButtonFilter);
            this.GroupBoxFilter.Controls.Add(this.Label1);
            this.GroupBoxFilter.Controls.Add(this.Label2);
            this.GroupBoxFilter.Controls.Add(this.DateTimePickerStart);
            this.GroupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxFilter.Location = new System.Drawing.Point(14, 10);
            this.GroupBoxFilter.Name = "GroupBoxFilter";
            this.GroupBoxFilter.Size = new System.Drawing.Size(990, 58);
            this.GroupBoxFilter.TabIndex = 10;
            this.GroupBoxFilter.TabStop = false;
            this.GroupBoxFilter.Text = "Filter";
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Teal;
            this.Label4.Location = new System.Drawing.Point(832, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 15);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Search";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(835, 28);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(149, 24);
            this.TextBoxSearch.TabIndex = 10;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(520, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 15);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Limit";
            // 
            // ComboBoxLimit
            // 
            this.ComboBoxLimit.FormattingEnabled = true;
            this.ComboBoxLimit.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "250",
            "500",
            "1000",
            "5000"});
            this.ComboBoxLimit.Location = new System.Drawing.Point(558, 20);
            this.ComboBoxLimit.Name = "ComboBoxLimit";
            this.ComboBoxLimit.Size = new System.Drawing.Size(78, 23);
            this.ComboBoxLimit.TabIndex = 8;
            this.ComboBoxLimit.Text = "100";
            // 
            // DateTimePickerUntil
            // 
            this.DateTimePickerUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerUntil.Location = new System.Drawing.Point(296, 20);
            this.DateTimePickerUntil.Name = "DateTimePickerUntil";
            this.DateTimePickerUntil.Size = new System.Drawing.Size(220, 21);
            this.DateTimePickerUntil.TabIndex = 4;
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonFilter.FlatAppearance.BorderSize = 0;
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonFilter.Location = new System.Drawing.Point(642, 17);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(87, 27);
            this.ButtonFilter.TabIndex = 5;
            this.ButtonFilter.Text = "Filter";
            this.ButtonFilter.UseVisualStyleBackColor = false;
            this.ButtonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 15);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Start";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(263, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Until";
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerStart.Location = new System.Drawing.Point(39, 20);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.Size = new System.Drawing.Size(220, 21);
            this.DateTimePickerStart.TabIndex = 3;
            // 
            // FormErrorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 560);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.GroupBoxFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormErrorReport";
            this.Tag = "Error Report";
            this.Text = "FormErrorReport";
            this.Load += new System.EventHandler(this.FormErrorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.GroupBoxFilter.ResumeLayout(false);
            this.GroupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.GroupBox GroupBoxFilter;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBoxSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox ComboBoxLimit;
        internal System.Windows.Forms.DateTimePicker DateTimePickerUntil;
        internal System.Windows.Forms.Button ButtonFilter;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker DateTimePickerStart;
    }
}