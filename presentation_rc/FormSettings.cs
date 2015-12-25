using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace NozzhaPRC
{
    public partial class FormSettings : MaterialForm
    {
        /// <summary>
        /// Temporary holder for the <c>Properties.Settings.Default</c>
        /// just to minimaize the written code when using settings properties
        /// </summary>
        private Properties.Settings Settings;

        /// <summary>
        /// Holds a copy of the `autoBind` setting
        /// to compare it later with the current settings to detect if there are
        /// any changes
        /// </summary>
        private bool preAutoBind;

        /// <summary>
        /// Holds a copy of the `bindIP` setting
        /// to compare it later with the current settings to detect if there are
        /// any changes
        /// </summary>
        private string preBindIP;

        /// <summary>
        /// Holds a copy of the `bindPort` setting
        /// to compare it later with the current settings to detect if there are
        /// any changes
        /// </summary>
        private int preBindPort;

        public FormSettings()
        {
            InitializeComponent();
            //
            // Initialize Material Skin
            //
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            //
            // Store current settings value
            //

            // Temporary holder for the settings
            Settings = Properties.Settings.Default;

            // Save a copy of the settings
            preAutoBind = Settings.autoBind;
            preBindIP = Settings.bindIp;
            preBindPort = Settings.bindPort;
            //
            // Load Settings
            //
            autoBindCB.Checked = preAutoBind;
            bindIpTB.Enabled = !preAutoBind;
            bindIpTB.Text = preAutoBind ? "Not specified" : Settings.bindIp;
            bindPortTB.Text = "" + Settings.bindPort;
        }

        /// <summary>
        /// Detects if there are any changes in the settings
        /// </summary>
        /// <returns>true if there are any changes, false otherwise</returns>
        private bool AreSettingsChanged()
        {
            if (preAutoBind != Settings.autoBind)
                return true;
            else if (preBindIP != Settings.bindIp)
                return true;
            else if (preBindPort != Settings.bindPort)
                return true;
            else
                return false;
        }

        private void autoBindCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoBind = autoBindCB.Checked;
            Properties.Settings.Default.Save();

            bindIpTB.Enabled = !autoBindCB.Checked;
            bindIpTB.Text = bindIpTB.Enabled ? "" : "Not specified";
        }

        private void bindIpTB_KeyUp(object sender, KeyEventArgs e)
        {
            Properties.Settings.Default.bindIp = bindIpTB.Text;
            Properties.Settings.Default.Save();

            CheckForClose(e);
        }

        private void bindPortTB_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Properties.Settings.Default.bindPort = Convert.ToInt32(bindPortTB.Text);
                Properties.Settings.Default.Save();
            }
            catch { }

            CheckForClose(e);
        }

        /// <summary>
        /// Checks if the pressed key is an enter key
        /// and closes the window if yes
        /// </summary>
        /// <param name="e"></param>
        private void CheckForClose(KeyEventArgs e)
        {
            if (e.KeyData != Keys.Return)
                return;

            e.Handled = true;

            Close();
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AreSettingsChanged())
                this.DialogResult = DialogResult.Yes;
            else
                this.DialogResult = DialogResult.No;
        }
    }
}
