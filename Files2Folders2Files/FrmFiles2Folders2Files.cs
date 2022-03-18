using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files2Folders2Files
{
    /// <summary>
    /// FrmFiles2Folders2Files Form Class.
    /// </summary>
    public partial class FrmFiles2Folders2Files : Form
    {
        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmFiles2Folders2Files()
        {
            // Initialize the form.
            InitializeComponent();

            // Hide some tabs.
            tcMain.TabPages.Remove(tabHelp);
            tcMain.TabPages.Remove(tabLicense);

            // Update the title.
            UpdateTitle();

            // Load the GUI RichTextBoxes from resources.
            rtbHelp.Text = Properties.Resources.Files2Folders2Files_HELP;
            rtbLicense.Rtf = Properties.Resources.Files2Folders2Files_LICENSE;

            // Print the version.
            PrintVersion();

            // Perform the application startup tasks.
            bgwStartupTasks.RunWorkerAsync();
        }

        #endregion

        #region Public Accessors

        /// <summary>
        /// The app name.
        /// </summary>
        public static string AppName
        {
            get { return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductName; }
            private set { }
        }

        /// <summary>
        /// The app version.
        /// </summary>
        public static string AppVersion
        {
            get { return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductVersion; }
            private set { }
        }

        /// <summary>
        /// The app version.
        /// </summary>
        public static string AppCopyright
        {
            get { return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).LegalCopyright; }
            private set { }
        }

        /// <summary>
        /// The directory path.
        /// </summary>
        public string PathDir
        {
            get { return txtDirectoryPath.Text; }
            set { txtDirectoryPath.Text = value; }
        }

        /// <summary>
        /// Delete empty folders.
        /// </summary>
        public bool DeleteEmptyFolders
        {
            get { return chkDeleteEmptyFolders.Checked; }
            set { chkDeleteEmptyFolders.Checked = value; }
        }

        #endregion

        #region Startup Tasks

        /// <summary>
        /// Performs the startup tasks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_DoWork(object sender, DoWorkEventArgs e)
        {
            // Stub
        }

        /// <summary>
        /// StartupTasks Progress Changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Stub
        }

        /// <summary>
        /// StartupTasks RunWorker Completed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Print to screen
            OutputLine("Ready");
            OutputLine("");
        }

        #endregion

        #region GUI

        /// <summary>
        /// Sets the application title.
        /// </summary>
        /// <param name="strTitle"></param>
        private void UpdateTitle(string strTitle = "")
        {
            if (this.InvokeRequired && !this.IsDisposed)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    // Update the application title.
                    this.Text = AppName + " v" + AppVersion + strTitle;
                }));
            }
            else if (!this.IsDisposed)
            {
                // Update the application title.
                this.Text = AppName + " v" + AppVersion + strTitle;
            }
        }

        /// <summary>
        /// Updates the status message label.
        /// </summary>
        /// <param name="strMsg"></param>
        private void UpdateStatusMessageLabel(string strMsg)
        {
            if (this.InvokeRequired && !this.IsDisposed)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    // Update the progress status message label.
                    this.tsslStatus.Text = strMsg;
                }));
            }
            else if (!this.IsDisposed)
            {
                // Update the progress status message label.
                this.tsslStatus.Text = strMsg;
            }
        }

        /// <summary>
        /// Disables all the buttons and textboxes and checkboxes.
        /// </summary>
        private void DisableButtons()
        {
            // Disable the toolstrip buttons.
            tsbFiles2Folders.Enabled = false;
            tsbFolders2Files.Enabled = false;

            // Disable the menustrip buttons.
            tsmiFiles2Folders.Enabled = false;
            tsmiFolders2Files.Enabled = false;

            // Disable the textboxes.
            txtDirectoryPath.Enabled = false;

            // Disable the checkboxes.
            chkDeleteEmptyFolders.Enabled = false;
        }

        /// <summary>
        /// Enables all the buttons and textboxes and checkboxes.
        /// </summary>
        private void EnableButtons()
        {
            // Enable the toolstrip buttons.
            tsbFiles2Folders.Enabled = true;
            tsbFolders2Files.Enabled = true;

            // Disable the menustrip buttons.
            tsmiFiles2Folders.Enabled = true;
            tsmiFolders2Files.Enabled = true;

            // Enable the textboxes.
            txtDirectoryPath.Enabled = true;

            // Enable the checkboxes.
            chkDeleteEmptyFolders.Enabled = true;
        }

        #endregion

        #region GUI Other Events

        /// <summary>
		/// Checks things to make sure it is safe, before closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Files2Folders2Files_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwFiles2Folders.IsBusy == true || bgwFolders2Files.IsBusy == true)
            {
                if (MessageBox.Show("The builder is currently running. Exiting now may cause corrupt or incomplete files! Are you sure you want to exit now?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region GUI Click Events

        /// <summary>
        /// Builds files to folders.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Files2Folders_Click(object sender, EventArgs e)
        {
            // Select the Log tab.
            if (tcMain.TabPages.Contains(tabLog)) { tcMain.SelectTab(tabLog); }

            // Disable all buttons.
            DisableButtons();

            // Enable the Cancel Button.
            tsbCancel.Enabled = true;

            // Update the status message label.
            UpdateStatusMessageLabel("Building Files 2 Folders ...");

            // Build Files 2 Folders.
            bgwFiles2Folders.RunWorkerAsync();
        }

        /// <summary>
        /// Builds folders to files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Folders2Files_Click(object sender, EventArgs e)
        {
            // Select the Log tab.
            if (tcMain.TabPages.Contains(tabLog)) { tcMain.SelectTab(tabLog); }

            // Disable all buttons.
            DisableButtons();

            // Enable the Cancel Button.
            tsbCancel.Enabled = true;

            // Update the status message label.
            UpdateStatusMessageLabel("Building Folders 2 Files ...");

            // Build Folders 2 Files.
            bgwFolders2Files.RunWorkerAsync();
        }

        /// <summary>
        /// Cancels the build.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (bgwFiles2Folders.IsBusy == true || bgwFolders2Files.IsBusy == true)
            {
                // Print to screen
                OutputLine("Info: Cancellation pending after current operation ...");

                // Disable the cancel button.
                tsbCancel.Enabled = false;

                // Cancel the asynchronous operation.
                if (bgwFiles2Folders.IsBusy == true) { bgwFiles2Folders.CancelAsync(); }
                if (bgwFolders2Files.IsBusy == true) { bgwFolders2Files.CancelAsync(); }

                // Update the status message label.
                UpdateStatusMessageLabel("Cancellation Pending ...");
            }
        }

        /// <summary>
        /// Exits the WinForms app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Updates the directory path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirectoryPath_Click(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableButtons();

            // Create and initialize a FolderBrowserDialog for the directory path.
            FolderBrowserDialog fbdSelectDir = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Please enter a directory path: ",
                SelectedPath = (!String.IsNullOrEmpty(PathDir)) ? PathDir : "."
            };

            // Determine if the user selected OK from the FolderBrowserDialog.
            if (fbdSelectDir.ShowDialog() == DialogResult.OK)
            {
                // Set the variable.
                PathDir = fbdSelectDir.SelectedPath;
            }

            // Dispose of the FolderBrowserDialog.
            fbdSelectDir.Dispose();

            // Enable all buttons.
            EnableButtons();
        }

        /// <summary>
        /// Toggles the visibility of the log.
        /// </summary>
        private void ViewLog_Click(object sender, EventArgs e)
        {
            if (tsmiLog.Checked)
            {
                tsmiLog.Checked = false;
                tsmiLog.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabLog);
            }
            else
            {
                tsmiLog.Checked = true;
                tsmiLog.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabLog);
                tcMain.SelectTab(tabLog);
            }
        }

        /// <summary>
        /// Toggles the visibility of the options.
        /// </summary>
        private void ViewOptions_Click(object sender, EventArgs e)
        {
            if (tsmiOptions.Checked)
            {
                tsmiOptions.Checked = false;
                tsmiOptions.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabOptions);
            }
            else
            {
                tsmiOptions.Checked = true;
                tsmiOptions.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabOptions);
                tcMain.SelectTab(tabOptions);
            }
        }

        /// <summary>
        /// Toggles the visibility of the help.
        /// </summary>
        private void ViewHelp_Click(object sender, EventArgs e)
        {
            if (tsmiHelp.Checked)
            {
                tsmiHelp.Checked = false;
                tsmiHelp.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabHelp);
            }
            else
            {
                tsmiHelp.Checked = true;
                tsmiHelp.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabHelp);
                tcMain.SelectTab(tabHelp);
            }
        }

        /// <summary>
        /// Toggles the visibility of the license.
        /// </summary>
        private void ViewLicense_Click(object sender, EventArgs e)
        {
            if (tsmiLicense.Checked)
            {
                tsmiLicense.Checked = false;
                tsmiLicense.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabLicense);
            }
            else
            {
                tsmiLicense.Checked = true;
                tsmiLicense.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabLicense);
                tcMain.SelectTab(tabLicense);
            }
        }

        /// <summary>
        /// Toggles the visibility of the toolbar.
        /// </summary>
        private void ViewToolbar_Click(object sender, EventArgs e)
        {
            if (tsMain.Visible)
            {
                tsMain.Visible = false;
                tsmiToolbar.Checked = false;
                tsmiToolbar.CheckState = CheckState.Unchecked;
            }
            else
            {
                tsMain.Visible = true;
                tsmiToolbar.Checked = true;
                tsmiToolbar.CheckState = CheckState.Checked;
            }
        }

        #endregion

        #region Workers

        /// <summary>
        /// Moves all pf the files from a single directory into folders of matching names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Files2Folders_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!String.IsNullOrEmpty(PathDir))
            {
                // Build the list of files array.
                string[] arrPathsFiles = Directory.GetFiles(PathDir);
                int intTotal = arrPathsFiles.Length;
                int intTotalCompleted = 0;

                // Declarations
                BackgroundWorker worker = sender as BackgroundWorker;

                // Loop through the list of files array.
                foreach (string arrPathFile in arrPathsFiles)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }

                    // Create a new folder for the file.
                    Directory.CreateDirectory(Path.Combine(PathDir, Path.GetFileNameWithoutExtension(arrPathFile)));
                    OutputLine("Info: Creating folder (" + Path.Combine(PathDir, Path.GetFileNameWithoutExtension(arrPathFile)) + ")");

                    // Move the file into the folder.
                    File.Move(arrPathFile, Path.Combine(PathDir, Path.GetFileNameWithoutExtension(arrPathFile), Path.GetFileName(arrPathFile)));
                    OutputLine("Info: Moving file (" + Path.GetFullPath(arrPathFile) + ")");

                    // Step the overall progress bar.
                    intTotalCompleted++;
                    worker.ReportProgress(intTotalCompleted * 100 / intTotal);
                }
            }
            else
            {
                // Print to screen
                OutputLine("Info: No directory path was selected");
            }
        }

        /// <summary>
        /// Changes the progress of the Files 2 Folders background worker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Files2Folders_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the overall progress bar.
            tspbOverallProgress.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Completes the Files 2 Folders background worker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Files2Folders_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Print to screen
                OutputLine("Info: Files 2 Folders cancelled");
            }
            else if (e.Error != null)
            {
                // Print to screen
                OutputLine("Error: Files 2 Folders failed");
                OutputLine("Error: " + e.Error.Message);
            }
            else
            {
                // Print to screen
                OutputLine("Info: Files 2 Folders completed");
            }

            // Reset the overall progress bar.
            tspbOverallProgress.Value = 0;

            // Update the status message label.
            UpdateStatusMessageLabel("Ready");

            // Print to screen
            OutputLine("Info: Ready");
            OutputLine("");

            // Disable the cancel button.
            tsbCancel.Enabled = false;

            // Enable all buttons.
            EnableButtons();
        }

        /// <summary>
        /// Moves all of the files from all of the folders into a single directory.
        /// Optionally deletes all of the empty folders.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Folders2Files_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!String.IsNullOrEmpty(PathDir))
            {
                // Build the list of directories array.
                string[] arrPathsDirectories = Directory.GetDirectories(PathDir);
                int intTotal = arrPathsDirectories.Length;
                int intTotalCompleted = 0;

                // Declarations
                BackgroundWorker worker = sender as BackgroundWorker;

                // Loop through the list of directories array.
                foreach (string strPathDirectory in arrPathsDirectories)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }

                    // Build the list of files array.
                    var arrPathsFiles = Directory.EnumerateFiles(strPathDirectory);

                    // Loop through the list of files array.
                    foreach (string strPathFile in arrPathsFiles)
                    {
                        // Move the file into the directory.
                        OutputLine("Info: Moving file (" + Path.GetFullPath(strPathFile) + ")");
                        File.Move(strPathFile, Path.Combine(PathDir, Path.GetFileName(strPathFile)));
                    }

                    // Optionally delete the empty directory.
                    if (DeleteEmptyFolders == true && Directory.GetFileSystemEntries(strPathDirectory).Length == 0)
                    {
                        // Delete the empty directory.
                        OutputLine("Info: Deleting folder (" + Path.GetFullPath(strPathDirectory) + ")");
                        Directory.Delete(strPathDirectory);
                    }

                    // Step the overall progress bar.
                    intTotalCompleted++;
                    worker.ReportProgress(intTotalCompleted * 100 / intTotal);
                }
            }
            else
            {
                // Print to screen
                OutputLine("Info: No directory path was selected");

            }
        }

        /// <summary>
        /// Changes the progress of the Folders 2 Files background worker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Folders2Files_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the overall progress bar.
            tspbOverallProgress.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Completes the Folders 2 Files background worker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Folders2Files_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Print to screen
                OutputLine("Info: Folders 2 Files cancelled");
            }
            else if (e.Error != null)
            {
                // Print to screen
                OutputLine("Error: Folders 2 Files failed");
                OutputLine("Error: " + e.Error.Message);
            }
            else
            {
                // Print to screen
                OutputLine("Info: Folders 2 Files completed");
            }

            // Reset the overall progress bar.
            tspbOverallProgress.Value = 0;

            // Update the status message label.
            UpdateStatusMessageLabel("Ready");

            // Print to screen
            OutputLine("Info: Ready");
            OutputLine("");

            // Disable the cancel button.
            tsbCancel.Enabled = false;

            // Enable all buttons.
            EnableButtons();
        }

        #endregion

        #region Printers

        /// <summary>
        /// Prints the version and copyright notice texts.
        /// </summary>
        public void PrintVersion()
        {
            // Print to screen
            OutputLine("------------------------------------------------------------------------------");
            OutputLine(AppName + " v" + AppVersion);
            OutputLine(AppCopyright);
            OutputLine("------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Outputs a line of text.
        /// </summary>
        /// <param name="strMsg"></param>
        private void OutputLine(string strMsg)
        {
            if (this.InvokeRequired && !this.IsDisposed)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    // Add the line of text to the log.
                    this.rtbLog.AppendText(strMsg + Environment.NewLine);

                    // Scroll the log to the caret.
                    this.rtbLog.ScrollToCaret();
                }));
            }
            else if (!this.IsDisposed)
            {
                // Add the line of text to the log.
                this.rtbLog.AppendText(strMsg + Environment.NewLine);

                // Scroll the log to the caret.
                this.rtbLog.ScrollToCaret();
            }
        }

        #endregion
    }
}
