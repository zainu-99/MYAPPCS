namespace MYAPPCS
{
    partial class FormUI
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
            this.GroupBoxSetDesign = new System.Windows.Forms.GroupBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonSetUp = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBoxColor = new System.Windows.Forms.ComboBox();
            this.ComboBoxVarDesignName = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBoxSetDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSetDesign
            // 
            this.GroupBoxSetDesign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBoxSetDesign.Controls.Add(this.ButtonReset);
            this.GroupBoxSetDesign.Controls.Add(this.ButtonSetUp);
            this.GroupBoxSetDesign.Controls.Add(this.Label2);
            this.GroupBoxSetDesign.Controls.Add(this.ComboBoxColor);
            this.GroupBoxSetDesign.Controls.Add(this.ComboBoxVarDesignName);
            this.GroupBoxSetDesign.Controls.Add(this.Label3);
            this.GroupBoxSetDesign.Location = new System.Drawing.Point(221, 250);
            this.GroupBoxSetDesign.Name = "GroupBoxSetDesign";
            this.GroupBoxSetDesign.Size = new System.Drawing.Size(818, 135);
            this.GroupBoxSetDesign.TabIndex = 38;
            this.GroupBoxSetDesign.TabStop = false;
            this.GroupBoxSetDesign.Text = "Set Design";
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.Color.Orange;
            this.ButtonReset.FlatAppearance.BorderSize = 0;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.ForeColor = System.Drawing.Color.White;
            this.ButtonReset.Location = new System.Drawing.Point(682, 53);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(112, 38);
            this.ButtonReset.TabIndex = 37;
            this.ButtonReset.Text = "Reset Default";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonSetUp
            // 
            this.ButtonSetUp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonSetUp.FlatAppearance.BorderSize = 0;
            this.ButtonSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetUp.ForeColor = System.Drawing.Color.White;
            this.ButtonSetUp.Location = new System.Drawing.Point(592, 53);
            this.ButtonSetUp.Name = "ButtonSetUp";
            this.ButtonSetUp.Size = new System.Drawing.Size(75, 38);
            this.ButtonSetUp.TabIndex = 36;
            this.ButtonSetUp.Text = "Set Up";
            this.ButtonSetUp.UseVisualStyleBackColor = false;
            this.ButtonSetUp.Click += new System.EventHandler(this.ButtonSetUp_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(17, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(115, 13);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Variable Design Name ";
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxColor.FormattingEnabled = true;
            this.ComboBoxColor.Location = new System.Drawing.Point(329, 59);
            this.ComboBoxColor.Name = "ComboBoxColor";
            this.ComboBoxColor.Size = new System.Drawing.Size(237, 28);
            this.ComboBoxColor.TabIndex = 35;
            this.ComboBoxColor.Text = "--Selected--";
            this.ComboBoxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxColor_DrawItem);
            // 
            // ComboBoxVarDesignName
            // 
            this.ComboBoxVarDesignName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxVarDesignName.FormattingEnabled = true;
            this.ComboBoxVarDesignName.Location = new System.Drawing.Point(21, 59);
            this.ComboBoxVarDesignName.Name = "ComboBoxVarDesignName";
            this.ComboBoxVarDesignName.Size = new System.Drawing.Size(260, 28);
            this.ComboBoxVarDesignName.TabIndex = 33;
            this.ComboBoxVarDesignName.Text = "--Selected--";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(325, 36);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(31, 13);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "Color";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Teal;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 23);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "UI Design";
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 679);
            this.Controls.Add(this.GroupBoxSetDesign);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUI";
            this.Tag = "UI";
            this.Text = "FormUI";
            this.Load += new System.EventHandler(this.FormUI_Load);
            this.GroupBoxSetDesign.ResumeLayout(false);
            this.GroupBoxSetDesign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBoxSetDesign;
        internal System.Windows.Forms.Button ButtonReset;
        internal System.Windows.Forms.Button ButtonSetUp;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox ComboBoxColor;
        internal System.Windows.Forms.ComboBox ComboBoxVarDesignName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
    }
}