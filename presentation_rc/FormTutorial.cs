using MaterialSkin;
using MaterialSkin.Controls;
using NozzhaPRC.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NozzhaPRC
{
    public partial class FormTutorial : MaterialForm
    {
        /// <summary>
        /// Used to detect whether the application is new and this is the first
        /// time to show the tutorial form for the user.
        /// If the user clicked the finish button and this was true, this form will be closed
        /// and will open the main form, otherwise this form will be closed and no further actions
        /// are done
        /// </summary>
        public bool isFirstTime = true;

        public FormTutorial()
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

        /// <summary>
        /// Shows this form at a specifc slide
        /// </summary>
        /// <param name="slideIndex">The index of the slide to be selected</param>
        public void ShowOnSlide(int slideIndex)
        {
            tabControl.SelectedIndex = slideIndex;

            // IF this method was called, it's diffently that this form is not
            // displaying for the first time for the user, so set it to false
            isFirstTime = false;

            Show();
        }

        /// <summary>
        /// Shows this form as a dialog at a specifc slide
        /// </summary>
        /// <param name="slideIndex">The index of the slide to be selected</param>
        public void ShowDialogOnSlide(int slideIndex)
        {
            tabControl.SelectedIndex = slideIndex;

            // IF this method was called, it's diffently that this form is not
            // displaying for the first time for the user, so set it to false
            isFirstTime = false;

            ShowDialog();
        }

        /// <summary>
        /// Opens the android application on Google Play Store
        /// when the user clicks on the Google Play Store badge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playStoreBtn_Click(object sender, EventArgs e)
        {
            Process.Start(BuildVars.PLAY_STORE_URL);
        }

        /// <summary>
        /// Moves to the next slide, when user clicks on the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveToNextSlide(object sender, EventArgs e)
        {
            // Move to the next slide
            // Note: this method is diffently should not be called when the current slide is the last slide
            tabControl.SelectedIndex++;
        }

        /// <summary>
        /// Closes this form and opens the MainForm if it is the first time to open the TutorialForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (!isFirstTime)
            {
                Close();
                return;
            }

            Properties.Settings.Default.currAppAPI = BuildVars.APP_API;
            Properties.Settings.Default.Save();

            // Closing this form using this way, because if it was opened for the first time,
            // the application will run the `FormTutorial` as the primary form.
            // Therefore, closing it using `Close()` will not allow the `FormMain` to open
            //
            // FIXME: should use an alternative way to show the tutorial form dialog

            Hide();
            FormMain mainForm = new FormMain();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
