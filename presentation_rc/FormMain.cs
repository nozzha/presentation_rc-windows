using MaterialSkin;
using MaterialSkin.Controls;
using NozzhaPRC.Core;
using NozzhaPRC.Interfaces;
using NozzhaPRC.Servers;
using NozzhaPRC.Statuses;
using System;
using System.Net;
using System.Windows.Forms;

namespace NozzhaPRC
{
    public partial class FormMain : MaterialForm,
        OnServerStatusChangedListener, OnClientStatusChangedListener, OnCommandReceivedListener
    {
        protected NetworkServer networkServer = new NetworkServer();

        public FormMain()
        {
            InitializeComponent();
            //
            // Initialize Material Theme
            //
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(
                Primary.Red800,
                Primary.Red900,
                Primary.Red500,
                Accent.Blue100,
                TextShade.WHITE
                );
            //
            // Initialize Status labels
            //
            serverStatusLabel.Font = SkinManager.ROBOTO_REGULAR_11;
            deviceStatusLabel.Font = SkinManager.ROBOTO_REGULAR_11;
            serverStatusLabel.ForeColor = NColor.Red;
            deviceStatusLabel.ForeColor = NColor.Red;
            //
            // Settings servers listeners
            //

            // TODO: remove/comment this line when in production
            // networkServer.DebugMode = true;
            networkServer.ServerStatusListener = this;
            networkServer.ClientStatusListener = this;
            networkServer.CommandReceivedListener = this;
            //
            // Auto Connect
            //
            ConnectViaWifi();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (networkServer.Running)
            {
                // Unregister listeners to avoid updating UI after closing the form

                networkServer.ServerStatusListener = null;
                networkServer.ClientStatusListener = null;
                networkServer.CommandReceivedListener = null;
                networkServer.Stop();
            }
        }

        private void bluetoothRB_CheckedChanged(object sender, EventArgs e)
        {
            // Stop running servers before starting any one else
            if (networkServer.Running)
                networkServer.Stop();

            // Start a server according to the chosen one

            if (bluetoothRB.Checked)
                ConnectViaBluetooth();
            else
                ConnectViaWifi();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings();
            DialogResult dialogResult = settingsForm.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                // If the `dialogResult` equals the `DialogResult.Yes`
                // that means that the settings have changed and the servers
                // need to be restarted inorder to apply them

                // calling the same method that listens to the `bluetoothRB`
                // checked state change, as it stops the running server
                // and starts the chosen server
                bluetoothRB_CheckedChanged(null, null);
            }
        }

        /// <summary>
        /// Starts the <c>NetworkServer</c>
        /// </summary>
        protected void ConnectViaWifi()
        {
            // Holds a copy of the settings pointer
            Properties.Settings settings = Properties.Settings.Default;

            IPAddress ipAddress = null;

            if (settings.autoBind)
                ipAddress = Util.getWiFiLocalIP();
            else
                IPAddress.TryParse(settings.bindIp, out ipAddress);

            //
            // Apply server settings
            //
            networkServer.IPAddress = ipAddress;
            networkServer.Port = settings.bindPort;

            //
            // Update UI
            //
            IPAddressLabel.Text = ipAddress == null ? "-" : ipAddress.ToString();
            PortLabel.Text = "" + networkServer.Port;

            // Start the server
            networkServer.Start();
        }

        /// <summary>
        /// Starts the `BluetoothServer`
        /// Note: not implemented yet
        /// </summary>
        protected void ConnectViaBluetooth()
        {
            // TODO: implement bluetooth server
        }

        public void OnServerStatusChanged(Server server, ServerStatus status)
        {
            if (InvokeRequired)
            {
                // if called from another thread than the ui thread
                // invoke this method again from this ui thread
                Invoke(new Action<Server, ServerStatus>(OnServerStatusChanged), server, status);
                return;
            }

            if (status == ServerStatus.Connecting || status == ServerStatus.Disconnecting)
            {
                // wifiRB.Enabled = bluetoothRB.Enabled = false;
                wifiRB.Enabled = false;
                serverStatusLabel.ForeColor = NColor.Orange;
                serverStatusLabel.Text = status == ServerStatus.Connecting ? "Connecting ..." : "Disconnecting ...";
            }
            else
            {
                // wifiRB.Enabled = bluetoothRB.Enabled = true;
                wifiRB.Enabled = true;

                //
                // Update the serverStatus on the UI
                //

                if (status == ServerStatus.Connected)
                {
                    serverStatusLabel.ForeColor = NColor.Green;
                    serverStatusLabel.Text = "Connected";
                }
                else if (status == ServerStatus.Failed)
                {
                    serverStatusLabel.ForeColor = NColor.Red;
                    serverStatusLabel.Text = "Failed to start";
                }
                else if (status == ServerStatus.NotConnected)
                {
                    serverStatusLabel.ForeColor = NColor.Red;
                    serverStatusLabel.Text = "Not connected";
                }
            }
        }

        public void OnClientStatusChanged(ClientStatus status, ClientInfo info)
        {
            if (InvokeRequired)
            {
                // if called from another thread than the ui thread
                // invoke this method again from this ui thread
                Invoke(new Action<ClientStatus, ClientInfo>(OnClientStatusChanged), status, info);
                return;
            }

            //
            // Update the clientStatus on the UI
            //

            if (status == ClientStatus.NotConnected)
            {
                deviceStatusLabel.ForeColor = NColor.Red;
                deviceStatusLabel.Text = "Not connected";
            }
            else if (status == ClientStatus.Waiting)
            {
                deviceStatusLabel.ForeColor = NColor.Orange;
                deviceStatusLabel.Text = "Waiting ...";
            }
            else if (status == ClientStatus.Connected)
            {
                deviceStatusLabel.ForeColor = NColor.Green;
                deviceStatusLabel.Text = "Connected";
            }
        }

        public void OnCommandReceived(Command command)
        {
            if (command == Command.NextSlide)
                // Simulate the `Down Arrow` button of the keyboard
                // to move to the next slide
                SendKeys.SendWait("{DOWN}");
            else if (command == Command.PreviousSlide)
                // Simulate the `Up Arrow` button of the keyboard
                // to move to the previous slide
                SendKeys.SendWait("{UP}");
        }


        private void aboutBtn_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.ShowDialog();
        }

        private void androidAppBtn_Click(object sender, EventArgs e)
        {
            FormTutorial tutorialForm = new FormTutorial();
            tutorialForm.ShowDialogOnSlide(1);
        }
    }
}
