using MaterialSkin;
using MaterialSkin.Controls;
using NozzhaPRC.Core;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace NozzhaPRC
{
    public partial class FormAbout : MaterialForm
    {
        public FormAbout()
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
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            // Display the application version
            versionLabel.Text += BuildVars.APP_VER;
        }

        /// <summary>
        /// Listen to clicks from `LinkLabel` controls,
        /// and opens them on the default browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenLink(object sender, EventArgs e)
        {
            // Links are stored in the `Tag` property
            LinkLabel linkLabel = sender as LinkLabel;
            string link = linkLabel.Tag.ToString();

            Process.Start(link);
        }

        private void openTutorialBtn_Click(object sender, EventArgs e)
        {
            FormTutorial tutorialForm = new FormTutorial();
            tutorialForm.ShowDialogOnSlide(0);
        }

        /// <summary>
        /// Listens to `Check for updates` Label,
        /// and check for a new version for the application through internet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkForUpdatesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateCheckerStatus("Checking for updates ...");

            Thread thrd = new Thread(() =>
            {
                int latest_api = -1;
                WebRequest webRequest = WebRequest.Create(BuildVars.APP_VERSION_URL);

                try
                {
                    using (WebResponse response = webRequest.GetResponse())
                    using (Stream content = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(content))
                    {
                        // Read response
                        // Response should be a number that repersents the latest api version of the application
                        string strVer = reader.ReadToEnd();

                        latest_api = int.Parse(strVer);
                    }
                }
                catch { }

                Func<int> updateUI = delegate()
                {
                    if (latest_api < 1)
                    {
                        // Faild to connect to the update server,
                        // or error parsing the response
                        updateCheckerStatus("Failed to check for updates!", true, false, false);
                    }
                    else if (latest_api > BuildVars.APP_API)
                    {
                        // A new version is available
                        updateCheckerStatus("A new version of Nozzha PRC is now available!", true, true, false);
                        checkerStatusLabel.ForeColor = NColor.Green;
                        manualUpdateLabel.Visible = true;
                        manualUpdateNoticeLabel.ForeColor = NColor.Red;
                        manualUpdateNoticeLabel.Visible = true;
                    }
                    else
                    {
                        // App is up-to-date
                        updateCheckerStatus("Nozzha PRC is up-to-date!", true, true, false);
                        checkerStatusLabel.ForeColor = NColor.Green;
                    }
                    return 0;
                };

                //
                Invoke(updateUI);
            });
            thrd.Name = "Update Checker";
            thrd.Start();
        }

        /// <summary>
        /// Updates the labels that indicates the checking for update status
        /// </summary>
        /// <param name="text"></param>
        /// <param name="visible"></param>
        /// <param name="status"></param>
        /// <param name="showIndicator"></param>
        private void updateCheckerStatus(string text, bool visible = true, bool status = true, bool showIndicator = true)
        {
            checkerStatusLabel.Text = text;

            checkerStatusLabel.Visible = visible;
            progressIndicator.Visible = visible && showIndicator;
            checkForUpdatesLabel.Visible = !visible;

            checkerStatusLabel.ForeColor = status ? NColor.Black : NColor.Red;
        }
    }
}
