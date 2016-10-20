namespace ncsplitter
{
    partial class fAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAbout));
            this.picAppIcon = new System.Windows.Forms.PictureBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelDev = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelVK = new System.Windows.Forms.Label();
            this.linkEMail = new System.Windows.Forms.LinkLabel();
            this.linkVK = new System.Windows.Forms.LinkLabel();
            this.labelAddons = new System.Windows.Forms.Label();
            this.linkIcons = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picAppIcon
            // 
            this.picAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAppIcon.Image")));
            this.picAppIcon.InitialImage = null;
            this.picAppIcon.Location = new System.Drawing.Point(12, 12);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Size = new System.Drawing.Size(64, 64);
            this.picAppIcon.TabIndex = 0;
            this.picAppIcon.TabStop = false;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAppName.Location = new System.Drawing.Point(82, 12);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(101, 23);
            this.labelAppName.TabIndex = 1;
            this.labelAppName.Text = "ncsplitter";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(83, 35);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(124, 14);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Extract your CNC files";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.Location = new System.Drawing.Point(83, 62);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(55, 14);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Version: ";
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDev.Location = new System.Drawing.Point(12, 100);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(132, 14);
            this.labelDev.TabIndex = 4;
            this.labelDev.Text = "Developed by Edgeline";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEMail.Location = new System.Drawing.Point(12, 120);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(45, 14);
            this.labelEMail.TabIndex = 5;
            this.labelEMail.Text = "E-Mail: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(307, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelVK
            // 
            this.labelVK.AutoSize = true;
            this.labelVK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVK.Location = new System.Drawing.Point(12, 140);
            this.labelVK.Name = "labelVK";
            this.labelVK.Size = new System.Drawing.Size(26, 14);
            this.labelVK.TabIndex = 8;
            this.labelVK.Text = "VK:";
            // 
            // linkEMail
            // 
            this.linkEMail.AutoSize = true;
            this.linkEMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkEMail.Location = new System.Drawing.Point(63, 121);
            this.linkEMail.Name = "linkEMail";
            this.linkEMail.Size = new System.Drawing.Size(99, 14);
            this.linkEMail.TabIndex = 9;
            this.linkEMail.TabStop = true;
            this.linkEMail.Text = "edgeline@mail.ru";
            this.linkEMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEMail_LinkClicked);
            // 
            // linkVK
            // 
            this.linkVK.AutoSize = true;
            this.linkVK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkVK.Location = new System.Drawing.Point(63, 141);
            this.linkVK.Name = "linkVK";
            this.linkVK.Size = new System.Drawing.Size(135, 14);
            this.linkVK.TabIndex = 10;
            this.linkVK.TabStop = true;
            this.linkVK.Text = "http://vk.com/edgeline";
            this.linkVK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVK_LinkClicked);
            // 
            // labelAddons
            // 
            this.labelAddons.AutoSize = true;
            this.labelAddons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddons.Location = new System.Drawing.Point(12, 192);
            this.labelAddons.Name = "labelAddons";
            this.labelAddons.Size = new System.Drawing.Size(152, 14);
            this.labelAddons.TabIndex = 11;
            this.labelAddons.Text = "Quetto icons by Ampeross";
            // 
            // linkIcons
            // 
            this.linkIcons.AutoSize = true;
            this.linkIcons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkIcons.Location = new System.Drawing.Point(12, 212);
            this.linkIcons.Name = "linkIcons";
            this.linkIcons.Size = new System.Drawing.Size(187, 14);
            this.linkIcons.TabIndex = 12;
            this.linkIcons.TabStop = true;
            this.linkIcons.Text = "http://ampeross.deviantart.com/";
            this.linkIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIcons_LinkClicked);
            // 
            // fAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 275);
            this.Controls.Add(this.linkIcons);
            this.Controls.Add(this.labelAddons);
            this.Controls.Add(this.linkVK);
            this.Controls.Add(this.linkEMail);
            this.Controls.Add(this.labelVK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.picAppIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.fAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAppIcon;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelVK;
        private System.Windows.Forms.LinkLabel linkEMail;
        private System.Windows.Forms.LinkLabel linkVK;
        private System.Windows.Forms.Label labelAddons;
        private System.Windows.Forms.LinkLabel linkIcons;
    }
}