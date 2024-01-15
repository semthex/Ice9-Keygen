
namespace Ice9_Keygen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpBorder = new System.Windows.Forms.GroupBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.llbGitHub = new System.Windows.Forms.LinkLabel();
            this.picKeygenArt = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeygenArt)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBorder
            // 
            this.grpBorder.Controls.Add(this.chkMusic);
            this.grpBorder.Controls.Add(this.btnClose);
            this.grpBorder.Controls.Add(this.llbGitHub);
            this.grpBorder.Controls.Add(this.picKeygenArt);
            this.grpBorder.Controls.Add(this.pnlTitleBar);
            this.grpBorder.Controls.Add(this.txtName);
            this.grpBorder.Controls.Add(this.btnCopy);
            this.grpBorder.Controls.Add(this.txtSerial);
            this.grpBorder.Controls.Add(this.btnGenerate);
            this.grpBorder.Controls.Add(this.lblSerial);
            this.grpBorder.Controls.Add(this.lblName);
            this.grpBorder.Location = new System.Drawing.Point(0, -6);
            this.grpBorder.Name = "grpBorder";
            this.grpBorder.Size = new System.Drawing.Size(505, 320);
            this.grpBorder.TabIndex = 9;
            this.grpBorder.TabStop = false;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Checked = true;
            this.chkMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkMusic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chkMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMusic.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMusic.ForeColor = System.Drawing.Color.White;
            this.chkMusic.Location = new System.Drawing.Point(12, 291);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(57, 19);
            this.chkMusic.TabIndex = 16;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(465, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llbGitHub
            // 
            this.llbGitHub.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llbGitHub.AutoSize = true;
            this.llbGitHub.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbGitHub.LinkColor = System.Drawing.Color.White;
            this.llbGitHub.Location = new System.Drawing.Point(338, 295);
            this.llbGitHub.Name = "llbGitHub";
            this.llbGitHub.Size = new System.Drawing.Size(156, 15);
            this.llbGitHub.TabIndex = 14;
            this.llbGitHub.TabStop = true;
            this.llbGitHub.Text = "github.com/JulianOzelRose";
            this.llbGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGitHub_LinkClicked);
            // 
            // picKeygenArt
            // 
            this.picKeygenArt.Image = global::Ice9_Keygen.Properties.Resources.Keygen_Art;
            this.picKeygenArt.Location = new System.Drawing.Point(115, 64);
            this.picKeygenArt.Name = "picKeygenArt";
            this.picKeygenArt.Size = new System.Drawing.Size(298, 75);
            this.picKeygenArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKeygenArt.TabIndex = 13;
            this.picKeygenArt.TabStop = false;
            this.picKeygenArt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picKeygenArt_MouseDown);
            this.picKeygenArt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picKeygenArt_MouseMove);
            this.picKeygenArt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picKeygenArt_MouseUp);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitleBar.Controls.Add(this.txtTitle);
            this.pnlTitleBar.Location = new System.Drawing.Point(12, 20);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(447, 27);
            this.pnlTitleBar.TabIndex = 9;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.BackColor = System.Drawing.Color.Black;
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(3, -1);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(105, 23);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "Ice9 Keygen";
            this.txtTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseDown);
            this.txtTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseMove);
            this.txtTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseUp);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(115, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 27);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopy
            // 
            this.btnCopy.FlatAppearance.BorderSize = 2;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(281, 234);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(132, 37);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.Black;
            this.txtSerial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.ForeColor = System.Drawing.Color.White;
            this.txtSerial.Location = new System.Drawing.Point(115, 178);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(298, 27);
            this.txtSerial.TabIndex = 1;
            this.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatAppearance.BorderSize = 2;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(115, 234);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(132, 37);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.BackColor = System.Drawing.Color.Black;
            this.lblSerial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.ForeColor = System.Drawing.Color.White;
            this.lblSerial.Location = new System.Drawing.Point(54, 181);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(51, 19);
            this.lblSerial.TabIndex = 1;
            this.lblSerial.Text = "Serial:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(54, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(505, 313);
            this.Controls.Add(this.grpBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ice9 Keygen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBorder.ResumeLayout(false);
            this.grpBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeygenArt)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBorder;
        private System.Windows.Forms.LinkLabel llbGitHub;
        private System.Windows.Forms.PictureBox picKeygenArt;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkMusic;
    }
}

