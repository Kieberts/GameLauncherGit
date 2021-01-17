namespace GameLauncher
{
    partial class FrmPin
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.lblErrorNumber = new System.Windows.Forms.Label();
            this.lblErrorTrys = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxPin4 = new System.Windows.Forms.TextBox();
            this.tbxPin3 = new System.Windows.Forms.TextBox();
            this.tbxPin2 = new System.Windows.Forms.TextBox();
            this.tbxPin1 = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Info;
            this.pnlHeader.Controls.Add(this.lblText);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(277, 52);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(40, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(185, 29);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Enter Admin Pin";
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.lblErrorNumber);
            this.pnlAll.Controls.Add(this.lblErrorTrys);
            this.pnlAll.Controls.Add(this.btnCancel);
            this.pnlAll.Controls.Add(this.tbxPin4);
            this.pnlAll.Controls.Add(this.tbxPin3);
            this.pnlAll.Controls.Add(this.tbxPin2);
            this.pnlAll.Controls.Add(this.tbxPin1);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAll.Location = new System.Drawing.Point(0, 52);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(277, 171);
            this.pnlAll.TabIndex = 1;
            // 
            // lblErrorNumber
            // 
            this.lblErrorNumber.AutoSize = true;
            this.lblErrorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNumber.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNumber.Location = new System.Drawing.Point(57, 88);
            this.lblErrorNumber.Name = "lblErrorNumber";
            this.lblErrorNumber.Size = new System.Drawing.Size(157, 16);
            this.lblErrorNumber.TabIndex = 5;
            this.lblErrorNumber.Text = "You have 3 more tries left";
            this.lblErrorNumber.Visible = false;
            // 
            // lblErrorTrys
            // 
            this.lblErrorTrys.AutoSize = true;
            this.lblErrorTrys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTrys.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTrys.Location = new System.Drawing.Point(57, 112);
            this.lblErrorTrys.Name = "lblErrorTrys";
            this.lblErrorTrys.Size = new System.Drawing.Size(157, 16);
            this.lblErrorTrys.TabIndex = 4;
            this.lblErrorTrys.Text = "You have 3 more tries left";
            this.lblErrorTrys.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(61, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 24);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxPin4
            // 
            this.tbxPin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPin4.Location = new System.Drawing.Point(196, 23);
            this.tbxPin4.MaxLength = 1;
            this.tbxPin4.Name = "tbxPin4";
            this.tbxPin4.Size = new System.Drawing.Size(50, 62);
            this.tbxPin4.TabIndex = 2;
            this.tbxPin4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPin4.TextChanged += new System.EventHandler(this.tbxPin4_TextChanged);
            this.tbxPin4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPin4_KeyUp);
            // 
            // tbxPin3
            // 
            this.tbxPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPin3.Location = new System.Drawing.Point(140, 23);
            this.tbxPin3.MaxLength = 1;
            this.tbxPin3.Name = "tbxPin3";
            this.tbxPin3.Size = new System.Drawing.Size(50, 62);
            this.tbxPin3.TabIndex = 2;
            this.tbxPin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPin3.TextChanged += new System.EventHandler(this.tbxPin3_TextChanged);
            this.tbxPin3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPin3_KeyUp);
            // 
            // tbxPin2
            // 
            this.tbxPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPin2.Location = new System.Drawing.Point(84, 23);
            this.tbxPin2.MaxLength = 1;
            this.tbxPin2.Name = "tbxPin2";
            this.tbxPin2.Size = new System.Drawing.Size(50, 62);
            this.tbxPin2.TabIndex = 1;
            this.tbxPin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPin2.TextChanged += new System.EventHandler(this.tbxPin2_TextChanged);
            this.tbxPin2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPin2_KeyUp);
            // 
            // tbxPin1
            // 
            this.tbxPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPin1.Location = new System.Drawing.Point(28, 23);
            this.tbxPin1.MaxLength = 1;
            this.tbxPin1.Name = "tbxPin1";
            this.tbxPin1.Size = new System.Drawing.Size(50, 62);
            this.tbxPin1.TabIndex = 0;
            this.tbxPin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPin1.TextChanged += new System.EventHandler(this.tbxPin1_TextChanged);
            // 
            // FrmPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 223);
            this.Controls.Add(this.pnlAll);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPin";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAll.ResumeLayout(false);
            this.pnlAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Label lblErrorTrys;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxPin4;
        private System.Windows.Forms.TextBox tbxPin3;
        private System.Windows.Forms.TextBox tbxPin2;
        private System.Windows.Forms.TextBox tbxPin1;
        private System.Windows.Forms.Label lblErrorNumber;
    }
}