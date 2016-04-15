namespace HR_Department.TimeKeeping.TimeKeepingForms
{
    partial class frmMessageError
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
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameMessageError = new System.Windows.Forms.Label();
            this.pctErrorMessage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Red;
            this.btnOk.Location = new System.Drawing.Point(159, 172);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(192, 62);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblNameMessageError);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 43);
            this.panel1.TabIndex = 1;
            // 
            // lblNameMessageError
            // 
            this.lblNameMessageError.AutoSize = true;
            this.lblNameMessageError.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMessageError.ForeColor = System.Drawing.Color.Red;
            this.lblNameMessageError.Location = new System.Drawing.Point(5, 7);
            this.lblNameMessageError.Name = "lblNameMessageError";
            this.lblNameMessageError.Size = new System.Drawing.Size(159, 29);
            this.lblNameMessageError.TabIndex = 2;
            this.lblNameMessageError.Text = "System Denied";
            // 
            // pctErrorMessage
            // 
            this.pctErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.pctErrorMessage.Image = global::HR_Department.TimeKeeping.Properties.Resources.Information;
            this.pctErrorMessage.Location = new System.Drawing.Point(46, 60);
            this.pctErrorMessage.Name = "pctErrorMessage";
            this.pctErrorMessage.Size = new System.Drawing.Size(107, 95);
            this.pctErrorMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctErrorMessage.TabIndex = 8;
            this.pctErrorMessage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 92);
            this.label1.TabIndex = 9;
            this.label1.Text = "You are suspended today.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMessageError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(533, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctErrorMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmMessageError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Denied";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrorMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameMessageError;
        private System.Windows.Forms.PictureBox pctErrorMessage;
        private System.Windows.Forms.Label label1;
    }
}