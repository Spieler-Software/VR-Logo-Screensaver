namespace Screensaver
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblCopyrightA = new System.Windows.Forms.Label();
            this.lblCopyrightB = new System.Windows.Forms.Label();
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.txtDisplayText = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCopyrightA
            // 
            this.lblCopyrightA.AutoSize = true;
            this.lblCopyrightA.Font = new System.Drawing.Font("Liberation Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrightA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.lblCopyrightA.Location = new System.Drawing.Point(65, 9);
            this.lblCopyrightA.Name = "lblCopyrightA";
            this.lblCopyrightA.Size = new System.Drawing.Size(258, 36);
            this.lblCopyrightA.TabIndex = 0;
            this.lblCopyrightA.Text = "VR Screen Saver";
            // 
            // lblCopyrightB
            // 
            this.lblCopyrightB.AutoSize = true;
            this.lblCopyrightB.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrightB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.lblCopyrightB.Location = new System.Drawing.Point(80, 45);
            this.lblCopyrightB.Name = "lblCopyrightB";
            this.lblCopyrightB.Size = new System.Drawing.Size(226, 17);
            this.lblCopyrightB.TabIndex = 1;
            this.lblCopyrightB.Text = "Marcel Jurtz - 25.01.2017 - v1.0";
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.AutoSize = true;
            this.lblDisplayText.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.lblDisplayText.Location = new System.Drawing.Point(12, 79);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(39, 17);
            this.lblDisplayText.TabIndex = 2;
            this.lblDisplayText.Text = "Text:";
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.txtDisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayText.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.txtDisplayText.Location = new System.Drawing.Point(83, 77);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(223, 19);
            this.txtDisplayText.TabIndex = 3;
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.cmdCancel.Location = new System.Drawing.Point(15, 123);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(148, 34);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Abbrechen";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.cmdSave.Location = new System.Drawing.Point(221, 123);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(148, 34);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(381, 169);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtDisplayText);
            this.Controls.Add(this.lblDisplayText);
            this.Controls.Add(this.lblCopyrightB);
            this.Controls.Add(this.lblCopyrightA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyrightA;
        private System.Windows.Forms.Label lblCopyrightB;
        private System.Windows.Forms.Label lblDisplayText;
        private System.Windows.Forms.TextBox txtDisplayText;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
    }
}