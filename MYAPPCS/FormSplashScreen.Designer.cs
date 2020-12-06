namespace MYAPPCS
{
    partial class FormSplashScreen
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
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBoxProgress = new System.Windows.Forms.PictureBox();
            this.PictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.timerProses = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Label3.Location = new System.Drawing.Point(59, 9);
            this.Label3.Margin = new System.Windows.Forms.Padding(0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(124, 20);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "MyApp FrameWork";
            // 
            // PictureBoxProgress
            // 
            this.PictureBoxProgress.BackColor = System.Drawing.Color.White;
            this.PictureBoxProgress.Image = global::MYAPPCS.Properties.Resources.loading_animation1;
            this.PictureBoxProgress.Location = new System.Drawing.Point(23, 207);
            this.PictureBoxProgress.Name = "PictureBoxProgress";
            this.PictureBoxProgress.Size = new System.Drawing.Size(193, 55);
            this.PictureBoxProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxProgress.TabIndex = 17;
            this.PictureBoxProgress.TabStop = false;
            // 
            // PictureBoxLoading
            // 
            this.PictureBoxLoading.Image = global::MYAPPCS.Properties.Resources.loading;
            this.PictureBoxLoading.Location = new System.Drawing.Point(40, 41);
            this.PictureBoxLoading.Name = "PictureBoxLoading";
            this.PictureBoxLoading.Size = new System.Drawing.Size(167, 160);
            this.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxLoading.TabIndex = 16;
            this.PictureBoxLoading.TabStop = false;
            // 
            // timerProses
            // 
            this.timerProses.Enabled = true;
            this.timerProses.Interval = 1000;
            this.timerProses.Tick += new System.EventHandler(this.timerProses_Tick);
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 280);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBoxProgress);
            this.Controls.Add(this.PictureBoxLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBoxProgress;
        internal System.Windows.Forms.PictureBox PictureBoxLoading;
        private System.Windows.Forms.Timer timerProses;
    }
}