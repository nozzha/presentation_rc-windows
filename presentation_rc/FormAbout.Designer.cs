namespace NozzhaPRC
{
    partial class FormAbout
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
            this.openTutorialBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkForUpdatesLabel = new System.Windows.Forms.LinkLabel();
            this.checkerStatusLabel = new System.Windows.Forms.Label();
            this.manualUpdateNoticeLabel = new System.Windows.Forms.Label();
            this.nozzhaWebsiteLabel = new System.Windows.Forms.LinkLabel();
            this.appPageLabel = new System.Windows.Forms.LinkLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.manualUpdateLabel = new System.Windows.Forms.LinkLabel();
            this.textView3 = new NozzhaPRC.Components.TextView();
            this.textView2 = new NozzhaPRC.Components.TextView();
            this.progressIndicator = new NozzhaPRC.Components.ProgressIndicator();
            this.versionLabel = new NozzhaPRC.Components.TextView();
            this.textView1 = new NozzhaPRC.Components.TextView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openTutorialBtn
            // 
            this.openTutorialBtn.AutoSize = true;
            this.openTutorialBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openTutorialBtn.Depth = 0;
            this.openTutorialBtn.Icon = null;
            this.openTutorialBtn.Location = new System.Drawing.Point(324, 372);
            this.openTutorialBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openTutorialBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openTutorialBtn.Name = "openTutorialBtn";
            this.openTutorialBtn.Primary = false;
            this.openTutorialBtn.Size = new System.Drawing.Size(116, 36);
            this.openTutorialBtn.TabIndex = 0;
            this.openTutorialBtn.Text = "Open Tutorial";
            this.openTutorialBtn.UseVisualStyleBackColor = true;
            this.openTutorialBtn.Click += new System.EventHandler(this.openTutorialBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NozzhaPRC.Properties.Resources.nozzha_logo;
            this.pictureBox2.Location = new System.Drawing.Point(288, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // checkForUpdatesLabel
            // 
            this.checkForUpdatesLabel.AutoSize = true;
            this.checkForUpdatesLabel.Location = new System.Drawing.Point(10, 132);
            this.checkForUpdatesLabel.Name = "checkForUpdatesLabel";
            this.checkForUpdatesLabel.Size = new System.Drawing.Size(94, 13);
            this.checkForUpdatesLabel.TabIndex = 6;
            this.checkForUpdatesLabel.TabStop = true;
            this.checkForUpdatesLabel.Text = "Check for updates";
            this.checkForUpdatesLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkForUpdatesLabel_LinkClicked);
            // 
            // checkerStatusLabel
            // 
            this.checkerStatusLabel.AutoSize = true;
            this.checkerStatusLabel.Location = new System.Drawing.Point(10, 132);
            this.checkerStatusLabel.Name = "checkerStatusLabel";
            this.checkerStatusLabel.Size = new System.Drawing.Size(120, 13);
            this.checkerStatusLabel.TabIndex = 9;
            this.checkerStatusLabel.Text = "Checking for updates ...";
            this.checkerStatusLabel.Visible = false;
            // 
            // manualUpdateNoticeLabel
            // 
            this.manualUpdateNoticeLabel.AutoSize = true;
            this.manualUpdateNoticeLabel.Location = new System.Drawing.Point(10, 151);
            this.manualUpdateNoticeLabel.Name = "manualUpdateNoticeLabel";
            this.manualUpdateNoticeLabel.Size = new System.Drawing.Size(97, 13);
            this.manualUpdateNoticeLabel.TabIndex = 10;
            this.manualUpdateNoticeLabel.Text = "Can\'t auto update -";
            this.manualUpdateNoticeLabel.Visible = false;
            // 
            // nozzhaWebsiteLabel
            // 
            this.nozzhaWebsiteLabel.AutoSize = true;
            this.nozzhaWebsiteLabel.Location = new System.Drawing.Point(285, 134);
            this.nozzhaWebsiteLabel.Name = "nozzhaWebsiteLabel";
            this.nozzhaWebsiteLabel.Size = new System.Drawing.Size(100, 13);
            this.nozzhaWebsiteLabel.TabIndex = 11;
            this.nozzhaWebsiteLabel.TabStop = true;
            this.nozzhaWebsiteLabel.Tag = "http://nozzha.com/";
            this.nozzhaWebsiteLabel.Text = "http://nozzha.com/";
            this.nozzhaWebsiteLabel.Click += new System.EventHandler(this.OpenLink);
            // 
            // appPageLabel
            // 
            this.appPageLabel.AutoSize = true;
            this.appPageLabel.Location = new System.Drawing.Point(285, 151);
            this.appPageLabel.Name = "appPageLabel";
            this.appPageLabel.Size = new System.Drawing.Size(107, 13);
            this.appPageLabel.TabIndex = 12;
            this.appPageLabel.TabStop = true;
            this.appPageLabel.Tag = "http://store.nozzha.com/apps/view/presentation_rc/";
            this.appPageLabel.Text = "Visit application page";
            this.appPageLabel.Click += new System.EventHandler(this.OpenLink);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(1, 190);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(450, 23);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 194);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(307, 18);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Many thanks to (Used open-source software)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://github.com/IgnaceMaes/MaterialSkin";
            this.linkLabel1.Text = "https://github.com/IgnaceMaes/MaterialSkin";
            this.linkLabel1.Click += new System.EventHandler(this.OpenLink);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "The MIT License (MIT)";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(10, 285);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(430, 2);
            this.materialDivider2.TabIndex = 19;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "The Code Project Open License (CPOL)";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(10, 320);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(346, 13);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "http://www.codeproject.com/Articles/30625/Circular-Progress-Indicator";
            this.linkLabel2.Text = "http://www.codeproject.com/Articles/30625/Circular-Progress-Indicator";
            this.linkLabel2.Click += new System.EventHandler(this.OpenLink);
            // 
            // manualUpdateLabel
            // 
            this.manualUpdateLabel.AutoSize = true;
            this.manualUpdateLabel.Location = new System.Drawing.Point(105, 151);
            this.manualUpdateLabel.Name = "manualUpdateLabel";
            this.manualUpdateLabel.Size = new System.Drawing.Size(86, 13);
            this.manualUpdateLabel.TabIndex = 23;
            this.manualUpdateLabel.TabStop = true;
            this.manualUpdateLabel.Tag = "http://store.nozzha.com/apps/view/presentation_rc/";
            this.manualUpdateLabel.Text = "Update manually";
            this.manualUpdateLabel.Visible = false;
            this.manualUpdateLabel.Click += new System.EventHandler(this.OpenLink);
            // 
            // textView3
            // 
            this.textView3.AutoSize = true;
            this.textView3.Depth = 0;
            this.textView3.Font = new System.Drawing.Font("Roboto", 13F);
            this.textView3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textView3.Location = new System.Drawing.Point(10, 292);
            this.textView3.MouseState = MaterialSkin.MouseState.HOVER;
            this.textView3.Name = "textView3";
            this.textView3.Size = new System.Drawing.Size(220, 23);
            this.textView3.TabIndex = 20;
            this.textView3.Text = "Circular Progress Indicator";
            // 
            // textView2
            // 
            this.textView2.AutoSize = true;
            this.textView2.Depth = 0;
            this.textView2.Font = new System.Drawing.Font("Roboto", 13F);
            this.textView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textView2.Location = new System.Drawing.Point(10, 220);
            this.textView2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textView2.Name = "textView2";
            this.textView2.Size = new System.Drawing.Size(216, 23);
            this.textView2.TabIndex = 15;
            this.textView2.Text = "IgnaceMaes/MaterialSkin";
            // 
            // progressIndicator
            // 
            this.progressIndicator.AutoStart = true;
            this.progressIndicator.Location = new System.Drawing.Point(136, 132);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.Percentage = 0F;
            this.progressIndicator.Size = new System.Drawing.Size(13, 13);
            this.progressIndicator.TabIndex = 8;
            this.progressIndicator.Visible = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Depth = 0;
            this.versionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionLabel.Location = new System.Drawing.Point(10, 108);
            this.versionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(76, 19);
            this.versionLabel.TabIndex = 5;
            this.versionLabel.Text = "Version: v";
            // 
            // textView1
            // 
            this.textView1.AutoSize = true;
            this.textView1.Depth = 0;
            this.textView1.Font = new System.Drawing.Font("Roboto", 20F);
            this.textView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textView1.Location = new System.Drawing.Point(10, 70);
            this.textView1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textView1.Name = "textView1";
            this.textView1.Size = new System.Drawing.Size(164, 33);
            this.textView1.TabIndex = 3;
            this.textView1.Text = "Nozzha PRC";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 423);
            this.Controls.Add(this.manualUpdateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.textView3);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textView2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.appPageLabel);
            this.Controls.Add(this.nozzhaWebsiteLabel);
            this.Controls.Add(this.manualUpdateNoticeLabel);
            this.Controls.Add(this.checkerStatusLabel);
            this.Controls.Add(this.progressIndicator);
            this.Controls.Add(this.checkForUpdatesLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.textView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.openTutorialBtn);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton openTutorialBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Components.TextView textView1;
        private Components.TextView versionLabel;
        private System.Windows.Forms.LinkLabel checkForUpdatesLabel;
        private Components.ProgressIndicator progressIndicator;
        private System.Windows.Forms.Label checkerStatusLabel;
        private System.Windows.Forms.Label manualUpdateNoticeLabel;
        private System.Windows.Forms.LinkLabel nozzhaWebsiteLabel;
        private System.Windows.Forms.LinkLabel appPageLabel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Components.TextView textView2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Components.TextView textView3;
        private System.Windows.Forms.LinkLabel manualUpdateLabel;
    }
}