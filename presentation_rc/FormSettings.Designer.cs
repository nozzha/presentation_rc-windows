namespace NozzhaPRC
{
    partial class FormSettings
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.autoBindCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.bindIpTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.bindPortTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
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
            this.materialDivider1.Size = new System.Drawing.Size(400, 23);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Visible = false;
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
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Wi-Fi settings";
            // 
            // autoBindCB
            // 
            this.autoBindCB.AutoSize = true;
            this.autoBindCB.Depth = 0;
            this.autoBindCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.autoBindCB.Location = new System.Drawing.Point(10, 90);
            this.autoBindCB.Margin = new System.Windows.Forms.Padding(0);
            this.autoBindCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.autoBindCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoBindCB.Name = "autoBindCB";
            this.autoBindCB.Ripple = true;
            this.autoBindCB.Size = new System.Drawing.Size(89, 30);
            this.autoBindCB.TabIndex = 4;
            this.autoBindCB.Text = "Auto bind";
            this.autoBindCB.UseVisualStyleBackColor = true;
            this.autoBindCB.CheckedChanged += new System.EventHandler(this.autoBindCB_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(114, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Bind IP Address";
            // 
            // bindIpTB
            // 
            this.bindIpTB.Depth = 0;
            this.bindIpTB.Enabled = false;
            this.bindIpTB.Hint = "";
            this.bindIpTB.Location = new System.Drawing.Point(10, 150);
            this.bindIpTB.MaxLength = 32767;
            this.bindIpTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.bindIpTB.Name = "bindIpTB";
            this.bindIpTB.PasswordChar = '\0';
            this.bindIpTB.SelectedText = "";
            this.bindIpTB.SelectionLength = 0;
            this.bindIpTB.SelectionStart = 0;
            this.bindIpTB.Size = new System.Drawing.Size(180, 23);
            this.bindIpTB.TabIndex = 6;
            this.bindIpTB.TabStop = false;
            this.bindIpTB.Text = "Not specified";
            this.bindIpTB.UseSystemPasswordChar = false;
            this.bindIpTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bindIpTB_KeyUp);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(210, 125);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Bind Port";
            // 
            // bindPortTB
            // 
            this.bindPortTB.Depth = 0;
            this.bindPortTB.Hint = "";
            this.bindPortTB.Location = new System.Drawing.Point(210, 150);
            this.bindPortTB.MaxLength = 32767;
            this.bindPortTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.bindPortTB.Name = "bindPortTB";
            this.bindPortTB.PasswordChar = '\0';
            this.bindPortTB.SelectedText = "";
            this.bindPortTB.SelectionLength = 0;
            this.bindPortTB.SelectionStart = 0;
            this.bindPortTB.Size = new System.Drawing.Size(180, 23);
            this.bindPortTB.TabIndex = 8;
            this.bindPortTB.TabStop = false;
            this.bindPortTB.Text = "3020";
            this.bindPortTB.UseSystemPasswordChar = false;
            this.bindPortTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bindPortTB_KeyUp);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.bindPortTB);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.bindIpTB);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.autoBindCB);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox autoBindCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField bindIpTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField bindPortTB;
    }
}