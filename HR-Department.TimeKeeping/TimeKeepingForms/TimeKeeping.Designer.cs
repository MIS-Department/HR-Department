using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HR_Department.TimeKeeping.TimeKeepingForms
{
    partial class TimeKeepingMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctErrorMessage = new System.Windows.Forms.PictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblBreakIn = new System.Windows.Forms.Label();
            this.lblBreakOut = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.tmrDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.tmrBlinkedTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrorMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblNameCompany);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 146);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HR_Department.TimeKeeping.Properties.Resources.Logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(51, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblNameCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameCompany.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.Location = new System.Drawing.Point(0, 0);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(1350, 146);
            this.lblNameCompany.TabIndex = 0;
            this.lblNameCompany.Text = "Daily Time Record";
            this.lblNameCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 146);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblDate);
            this.splitContainer1.Panel2.Controls.Add(this.lblTime);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetails);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 548);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctErrorMessage);
            this.groupBox1.Controls.Add(this.lblErrorMessage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEmployeeNumber);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.lblEmployeePosition);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 544);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pctErrorMessage
            // 
            this.pctErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.pctErrorMessage.Image = global::HR_Department.TimeKeeping.Properties.Resources.Information;
            this.pctErrorMessage.Location = new System.Drawing.Point(78, 259);
            this.pctErrorMessage.Name = "pctErrorMessage";
            this.pctErrorMessage.Size = new System.Drawing.Size(57, 49);
            this.pctErrorMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctErrorMessage.TabIndex = 7;
            this.pctErrorMessage.TabStop = false;
            this.pctErrorMessage.Visible = false;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 263);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(600, 47);
            this.lblErrorMessage.TabIndex = 6;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(389, 39);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(211, 50);
            this.lblEmployeeNumber.TabIndex = 4;
            this.lblEmployeeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(96, 218);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(398, 38);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePosition.Location = new System.Drawing.Point(199, 152);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(401, 41);
            this.lblEmployeePosition.TabIndex = 3;
            this.lblEmployeePosition.Text = "Employee Position";
            this.lblEmployeePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(199, 100);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(401, 41);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Employee Name";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::HR_Department.TimeKeeping.Properties.Resources.Default;
            this.pictureBox1.Location = new System.Drawing.Point(10, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblTimeOut);
            this.groupBox3.Controls.Add(this.lblBreakIn);
            this.groupBox3.Controls.Add(this.lblBreakOut);
            this.groupBox3.Controls.Add(this.lblTimeIn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 226);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.ForeColor = System.Drawing.Color.Black;
            this.lblTimeOut.Location = new System.Drawing.Point(15, 119);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(270, 100);
            this.lblTimeOut.TabIndex = 3;
            this.lblTimeOut.Text = "Time Out";
            this.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreakIn
            // 
            this.lblBreakIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBreakIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBreakIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakIn.ForeColor = System.Drawing.Color.Black;
            this.lblBreakIn.Location = new System.Drawing.Point(305, 16);
            this.lblBreakIn.Name = "lblBreakIn";
            this.lblBreakIn.Size = new System.Drawing.Size(270, 100);
            this.lblBreakIn.TabIndex = 2;
            this.lblBreakIn.Text = "Break In";
            this.lblBreakIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreakOut
            // 
            this.lblBreakOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBreakOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBreakOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakOut.ForeColor = System.Drawing.Color.Black;
            this.lblBreakOut.Location = new System.Drawing.Point(305, 119);
            this.lblBreakOut.Name = "lblBreakOut";
            this.lblBreakOut.Size = new System.Drawing.Size(270, 100);
            this.lblBreakOut.TabIndex = 1;
            this.lblBreakOut.Text = "Break Out";
            this.lblBreakOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.ForeColor = System.Drawing.Color.Black;
            this.lblTimeIn.Location = new System.Drawing.Point(15, 16);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(270, 100);
            this.lblTimeIn.TabIndex = 0;
            this.lblTimeIn.Text = "Time In";
            this.lblTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 157);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(730, 63);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(0, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(730, 79);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time and Date";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetails.Location = new System.Drawing.Point(0, 241);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(736, 307);
            this.dgvDetails.TabIndex = 0;
            // 
            // tmrDateAndTime
            // 
            this.tmrDateAndTime.Enabled = true;
            this.tmrDateAndTime.Interval = 1000;
            this.tmrDateAndTime.Tick += new System.EventHandler(this.tmrDateAndTime_Tick);
            // 
            // tmrBlinkedTimer
            // 
            this.tmrBlinkedTimer.Enabled = true;
            this.tmrBlinkedTimer.Interval = 500;
            this.tmrBlinkedTimer.Tick += new System.EventHandler(this.tmrBlinkedTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 35);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "© 2016 O&&G Leather Manufacturing Corp. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeKeepingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeKeepingMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeKeeping";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrorMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameCompany;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private DataGridView dgvDetails;
        private GroupBox groupBox1;
        private Label lblEmployeePosition;
        private Label lblEmployeeName;
        private GroupBox groupBox3;
        private Label lblTime;
        private TextBox txtBarcode;
        private Label lblTimeIn;
        private Label lblDate;
        private Timer tmrDateAndTime;
        private Timer tmrBlinkedTimer;
        private PictureBox pictureBox2;
        private Label lblTimeOut;
        private Label lblBreakIn;
        private Label lblBreakOut;
        private Label lblEmployeeNumber;
        private Label label1;
        private Label lblErrorMessage;
        private Panel panel2;
        private PictureBox pctErrorMessage;
        private Label label2;
    }
}