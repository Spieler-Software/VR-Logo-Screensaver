namespace Screensaver
{
    partial class ScreenSaverForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSaverForm));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCustomText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Liberation Sans", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.lblTime.Location = new System.Drawing.Point(30, 391);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(270, 96);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Liberation Sans", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.lblDate.Location = new System.Drawing.Point(35, 502);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(173, 63);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // lblCustomText
            // 
            this.lblCustomText.AutoSize = true;
            this.lblCustomText.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomText.Font = new System.Drawing.Font("Liberation Sans", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.lblCustomText.Location = new System.Drawing.Point(30, 133);
            this.lblCustomText.Name = "lblCustomText";
            this.lblCustomText.Size = new System.Drawing.Size(299, 107);
            this.lblCustomText.TabIndex = 2;
            this.lblCustomText.Text = "label1";
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.lblCustomText);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.Label lblCustomText;
    }
}

