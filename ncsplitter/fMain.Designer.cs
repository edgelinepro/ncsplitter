namespace ncsplitter
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.labelSrc = new System.Windows.Forms.Label();
            this.textPathSrc = new System.Windows.Forms.TextBox();
            this.labelDst = new System.Windows.Forms.Label();
            this.textPathDst = new System.Windows.Forms.TextBox();
            this.btnSelectPathSrc = new System.Windows.Forms.Button();
            this.btnSelectPathDst = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSrc
            // 
            this.labelSrc.AutoSize = true;
            this.labelSrc.Location = new System.Drawing.Point(12, 15);
            this.labelSrc.Name = "labelSrc";
            this.labelSrc.Size = new System.Drawing.Size(63, 13);
            this.labelSrc.TabIndex = 0;
            this.labelSrc.Text = "Source File:";
            // 
            // textPathSrc
            // 
            this.textPathSrc.BackColor = System.Drawing.SystemColors.Window;
            this.textPathSrc.Location = new System.Drawing.Point(116, 12);
            this.textPathSrc.Name = "textPathSrc";
            this.textPathSrc.ReadOnly = true;
            this.textPathSrc.Size = new System.Drawing.Size(325, 21);
            this.textPathSrc.TabIndex = 1;
            this.textPathSrc.Click += new System.EventHandler(this.textPathSrc_Click);
            // 
            // labelDst
            // 
            this.labelDst.AutoSize = true;
            this.labelDst.Location = new System.Drawing.Point(12, 42);
            this.labelDst.Name = "labelDst";
            this.labelDst.Size = new System.Drawing.Size(98, 13);
            this.labelDst.TabIndex = 2;
            this.labelDst.Text = "Destination Folder:";
            // 
            // textPathDst
            // 
            this.textPathDst.BackColor = System.Drawing.SystemColors.Window;
            this.textPathDst.Location = new System.Drawing.Point(116, 39);
            this.textPathDst.Name = "textPathDst";
            this.textPathDst.ReadOnly = true;
            this.textPathDst.Size = new System.Drawing.Size(325, 21);
            this.textPathDst.TabIndex = 3;
            this.textPathDst.Click += new System.EventHandler(this.textPathDst_Click);
            // 
            // btnSelectPathSrc
            // 
            this.btnSelectPathSrc.Location = new System.Drawing.Point(447, 10);
            this.btnSelectPathSrc.Name = "btnSelectPathSrc";
            this.btnSelectPathSrc.Size = new System.Drawing.Size(33, 23);
            this.btnSelectPathSrc.TabIndex = 4;
            this.btnSelectPathSrc.Text = "...";
            this.btnSelectPathSrc.UseVisualStyleBackColor = true;
            this.btnSelectPathSrc.Click += new System.EventHandler(this.btnSelectPathSrc_Click);
            // 
            // btnSelectPathDst
            // 
            this.btnSelectPathDst.Location = new System.Drawing.Point(447, 37);
            this.btnSelectPathDst.Name = "btnSelectPathDst";
            this.btnSelectPathDst.Size = new System.Drawing.Size(33, 23);
            this.btnSelectPathDst.TabIndex = 5;
            this.btnSelectPathDst.Text = "...";
            this.btnSelectPathDst.UseVisualStyleBackColor = true;
            this.btnSelectPathDst.Click += new System.EventHandler(this.btnSelectPathDst_Click);
            // 
            // textLog
            // 
            this.textLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLog.Location = new System.Drawing.Point(15, 76);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(465, 206);
            this.textLog.TabIndex = 6;
            this.textLog.TextChanged += new System.EventHandler(this.textLog_TextChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(15, 288);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 7;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(96, 288);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(177, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 323);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.btnSelectPathDst);
            this.Controls.Add(this.btnSelectPathSrc);
            this.Controls.Add(this.textPathDst);
            this.Controls.Add(this.labelDst);
            this.Controls.Add(this.textPathSrc);
            this.Controls.Add(this.labelSrc);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ncsplitter";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSrc;
        private System.Windows.Forms.TextBox textPathSrc;
        private System.Windows.Forms.Label labelDst;
        private System.Windows.Forms.Button btnSelectPathSrc;
        private System.Windows.Forms.Button btnSelectPathDst;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox textPathDst;
    }
}

