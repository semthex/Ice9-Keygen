
namespace Ice9_Keygen
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBorder.Controls.Add(this.lblErrorMsg);
            this.pnlBorder.Controls.Add(this.lblError);
            this.pnlBorder.Controls.Add(this.btnOK);
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(301, 161);
            this.pnlBorder.TabIndex = 1;
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown);
            this.pnlBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseMove);
            this.pnlBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseUp);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(23, 67);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(244, 19);
            this.lblErrorMsg.TabIndex = 6;
            this.lblErrorMsg.Text = "Name must be at least 4 characters.";
            this.lblErrorMsg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblErrorMsg_MouseDown);
            this.lblErrorMsg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblErrorMsg_MouseMove);
            this.lblErrorMsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblErrorMsg_MouseUp);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(21, 19);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(75, 36);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error";
            this.lblError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblError_MouseDown);
            this.lblError.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblError_MouseMove);
            this.lblError.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblError_MouseUp);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(96, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.pnlBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnOK;
    }
}