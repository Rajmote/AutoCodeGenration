using OpenApiIntegrationLibrary;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Windows.Forms;

namespace AutoCodeGenerationUI
{
    public partial class AutoCodeGeneration : Form
    {
        OpenApiIntegration openApiIntegration;

        FolderBrowserDialog fbdSoureceFd;
        FolderBrowserDialog fbdDestinationFd;

        public List<FileInformation> selectedFilesList;
        public List<FileInformation> ignoredFilesList;

        public string selectedOperation;
        public string selectedExtention;

        public AutoCodeGeneration()
        {
            InitializeComponent();
            cbOperations_DataBind();
            cbExtentions_DataBind();
            selectedFilesList = new List<FileInformation>();
            ignoredFilesList = new List<FileInformation>();
            picLoader.Visible = false;
            cbExtentions.Enabled = false;
            btnSourceFD.Enabled = false;
            btnDestinationFD.Enabled = false;
            lbSelectedFiles.Enabled = false;
            lbIgnoredFiles.Enabled = false;
            btnMoveToIgnore.Enabled = false;
            btnMoveToSelect.Enabled = false;
            btnReset.Enabled = false;
            btnPerformOperation.Enabled = false;

        }

        private void Bind_ListBox()
        {
            lbSelectedFiles.DataSource = null;
            lbIgnoredFiles.DataSource = null;

            lbSelectedFiles.DisplayMember = "FileName";
            lbIgnoredFiles.DisplayMember = "FileName";

            lbSelectedFiles.DataSource = selectedFilesList;
            lbIgnoredFiles.DataSource = ignoredFilesList;

        }

        private void cbOperations_DataBind()
        {
            cbOperations.DataSource = Utility.GetOperations();
        }

        private void cbExtentions_DataBind()
        {
            cbExtentions.DataSource = Utility.GetAllowedFileExtentions();
        }

        private void cbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOperation = (string)cbOperations.SelectedItem;
            if(selectedOperation.Trim() != "--- Select Operation ---") 
            {
                cbExtentions.Enabled = true;
            }
            else
            {
                picLoader.Visible = false;
                cbExtentions.Enabled = false;
                btnSourceFD.Enabled = false;
                btnDestinationFD.Enabled = false;
                lbSelectedFiles.Enabled = false;
                lbIgnoredFiles.Enabled = false;
                btnMoveToIgnore.Enabled = false;
                btnMoveToSelect.Enabled = false;
                btnReset.Enabled = false;
                btnPerformOperation.Enabled = false;
            }
           
        }

        private void cbExtentions_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedExtention = (string)cbExtentions.SelectedItem;
            if (selectedExtention.Trim() != "--- Select Extention ---")
            {
                btnSourceFD.Enabled = true;
            }
            else
            {
                picLoader.Visible = false;
                btnSourceFD.Enabled = false;
                btnDestinationFD.Enabled = false;
                lbSelectedFiles.Enabled = false;
                lbIgnoredFiles.Enabled = false;
                btnMoveToIgnore.Enabled = false;
                btnMoveToSelect.Enabled = false;
                btnReset.Enabled = false;
                btnPerformOperation.Enabled = false;
            }
        }

        private void btnSourceFD_Click(object sender, EventArgs e)
        {
            fbdSoureceFd = new FolderBrowserDialog();
            if (fbdSoureceFd.ShowDialog() == DialogResult.OK)
            {
                lblSourceFDPath.Text = "Source => " + fbdSoureceFd.SelectedPath;
                lblSourceFDPath.ForeColor = Color.DarkGreen;
                var filesList = new List<string>();

                if (selectedExtention.Trim() == "All")
                {
                    filesList = Directory.GetFiles(fbdSoureceFd.SelectedPath).Where(file => Utility.GetAllowedFileExtentions().Any(file.ToLower().EndsWith)).ToList();

                }
                else
                {
                    filesList = Directory.GetFiles(fbdSoureceFd.SelectedPath).Where(s => s.EndsWith(selectedExtention.Trim())).ToList();
                }

                foreach (string f in filesList)
                {
                    var fileItem = new FileInformation { FileName = Path.GetFileName(f), FilePath = Path.GetFullPath(f) };
                    selectedFilesList.Add(fileItem);
                }

                if (selectedFilesList.Count > 0)
                {
                    Bind_ListBox();
                    btnDestinationFD.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The selected Source folder dose not contain the desired extention file.");
                }
            }
        }

        private void btnDestinationFD_Click(object sender, EventArgs e)
        {
            fbdDestinationFd = new FolderBrowserDialog();
            if (fbdDestinationFd.ShowDialog() == DialogResult.OK)
            {
                lblDestinationFDPath.Text = "Destination => " + fbdDestinationFd.SelectedPath;
                lblDestinationFDPath.ForeColor = Color.DarkGreen;
            }
            btnMoveToIgnore.Enabled = true;
            btnMoveToSelect.Enabled = true; 
            lbIgnoredFiles.Enabled = true;
            lbSelectedFiles.Enabled = true;
            btnReset.Enabled = true;
            btnPerformOperation.Enabled = true;
        }

        private void btnMoveToIgnore_Click(object sender, EventArgs e)
        {
            foreach (var selecteditem in lbSelectedFiles.SelectedItems)
            {
                ignoredFilesList.Add((FileInformation)selecteditem);
                selectedFilesList.Remove((FileInformation)selecteditem);
            }

            Bind_ListBox();
        }

        private void btnMoveToSelect_Click(object sender, EventArgs e)
        {
            foreach (var selecteditem in lbIgnoredFiles.SelectedItems)
            {
                selectedFilesList.Add((FileInformation)selecteditem);
                ignoredFilesList.Remove((FileInformation)selecteditem);
            }
            Bind_ListBox();
        }

        private async void btnPerformOperation_ClickAsync(object sender, EventArgs e)  
        {
            SetLoading(true);

            openApiIntegration = new OpenApiIntegration();
            var result = await openApiIntegration.PerformOperation(selectedFilesList, selectedOperation.Trim(), fbdDestinationFd.SelectedPath);

            SetLoading(false);

            if (result==true)
            {
                MessageBox.Show("The process has completed please check your newly generated files in selected destination folder.");
            }

            selectedFilesList = new List<FileInformation>();
            ignoredFilesList = new List<FileInformation>();
            picLoader.Visible = false;
            cbExtentions.Enabled = false;
            btnSourceFD.Enabled = false;
            btnDestinationFD.Enabled = false;
            lbSelectedFiles.Enabled = false;
            lbIgnoredFiles.Enabled = false;
            btnMoveToIgnore.Enabled = false;
            btnMoveToSelect.Enabled = false;  
            btnPerformOperation.Enabled = false;
            btnReset.Enabled = true;

        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = true;
                    this.Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = false;
                    this.Cursor = Cursors.Default;
                });
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbOperations_DataBind();
            cbExtentions_DataBind();
            selectedFilesList = new List<FileInformation>();
            ignoredFilesList = new List<FileInformation>();
            picLoader.Visible = false;
            cbExtentions.Enabled = false;
            btnSourceFD.Enabled = false;
            btnDestinationFD.Enabled = false;
            lbSelectedFiles.Enabled = false;
            lbIgnoredFiles.Enabled = false;
            btnMoveToIgnore.Enabled = false;
            btnMoveToSelect.Enabled = false;
            btnReset.Enabled = false;
            btnPerformOperation.Enabled = false;
            lblSourceFDPath.Text = "Please select source folder path";
            lblDestinationFDPath.Text = "Please select destination folder path";
        }

        
    }


}