namespace NozzhaPRC
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.wifiRB = new MaterialSkin.Controls.MaterialRadioButton();
            this.bluetoothRB = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.deviceStatusLabel = new System.Windows.Forms.Label();
            this.settingsBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // wifiRB
            // 
            this.wifiRB.AutoSize = true;
            this.wifiRB.Checked = true;
            this.wifiRB.Depth = 0;
            this.wifiRB.Font = new System.Drawing.Font("Roboto", 10F);
            this.wifiRB.Location = new System.Drawing.Point(10, 90);
            this.wifiRB.Margin = new System.Windows.Forms.Padding(0);
            this.wifiRB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.wifiRB.MouseState = MaterialSkin.MouseState.HOVER;
            this.wifiRB.Name = "wifiRB";
            this.wifiRB.Ripple = true;
            this.wifiRB.Size = new System.Drawing.Size(60, 30);
            this.wifiRB.TabIndex = 0;
            this.wifiRB.TabStop = true;
            this.wifiRB.Text = "Wi-Fi";
            this.wifiRB.UseVisualStyleBackColor = true;
            // 
            // bluetoothRB
            // 
            this.bluetoothRB.AutoSize = true;
            this.bluetoothRB.Depth = 0;
            this.bluetoothRB.Enabled = false;
            this.bluetoothRB.Font = new System.Drawing.Font("Roboto", 10F);
            this.bluetoothRB.Location = new System.Drawing.Point(160, 90);
            this.bluetoothRB.Margin = new System.Windows.Forms.Padding(0);
            this.bluetoothRB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bluetoothRB.MouseState = MaterialSkin.MouseState.HOVER;
            this.bluetoothRB.Name = "bluetoothRB";
            this.bluetoothRB.Ripple = true;
            this.bluetoothRB.Size = new System.Drawing.Size(89, 30);
            this.bluetoothRB.TabIndex = 2;
            this.bluetoothRB.Text = "Bluetooth";
            this.bluetoothRB.UseVisualStyleBackColor = true;
            this.bluetoothRB.CheckedChanged += new System.EventHandler(this.bluetoothRB_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Connect over";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 64);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(300, 23);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Visible = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 123);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(300, 23);
            this.materialDivider2.TabIndex = 4;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Server status";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.serverStatusLabel.Location = new System.Drawing.Point(15, 172);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(84, 18);
            this.serverStatusLabel.TabIndex = 6;
            this.serverStatusLabel.Text = "Not running";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(160, 149);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(100, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Device status";
            // 
            // deviceStatusLabel
            // 
            this.deviceStatusLabel.AutoSize = true;
            this.deviceStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.deviceStatusLabel.Location = new System.Drawing.Point(165, 172);
            this.deviceStatusLabel.Name = "deviceStatusLabel";
            this.deviceStatusLabel.Size = new System.Drawing.Size(105, 18);
            this.deviceStatusLabel.TabIndex = 8;
            this.deviceStatusLabel.Text = "Not connected";
            // 
            // settingsBtn
            // 
            this.settingsBtn.AutoSize = true;
            this.settingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsBtn.Depth = 0;
            this.settingsBtn.Location = new System.Drawing.Point(10, 300);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Primary = false;
            this.settingsBtn.Size = new System.Drawing.Size(76, 36);
            this.settingsBtn.TabIndex = 9;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(0, 200);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(300, 23);
            this.materialDivider3.TabIndex = 10;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(10, 226);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "IPAddress";
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.IPAddressLabel.Location = new System.Drawing.Point(15, 249);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(13, 18);
            this.IPAddressLabel.TabIndex = 12;
            this.IPAddressLabel.Text = "-";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PortLabel.Location = new System.Drawing.Point(165, 249);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(13, 18);
            this.PortLabel.TabIndex = 14;
            this.PortLabel.Text = "-";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(160, 226);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(37, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Port";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 347);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.IPAddressLabel);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.deviceStatusLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bluetoothRB);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.wifiRB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentation Remote Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton wifiRB;
        private MaterialSkin.Controls.MaterialRadioButton bluetoothRB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label serverStatusLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label deviceStatusLabel;
        private MaterialSkin.Controls.MaterialFlatButton settingsBtn;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Label PortLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;


    }
}

