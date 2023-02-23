namespace AutoCodeGenerationUI
{
    partial class AutoCodeGeneration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCodeGeneration));
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.cbExtentions = new System.Windows.Forms.ComboBox();
            this.btnSourceFD = new System.Windows.Forms.Button();
            this.btnDestinationFD = new System.Windows.Forms.Button();
            this.lblSourceFDPath = new System.Windows.Forms.Label();
            this.lblDestinationFDPath = new System.Windows.Forms.Label();
            this.lbSelectedFiles = new System.Windows.Forms.ListBox();
            this.lbIgnoredFiles = new System.Windows.Forms.ListBox();
            this.btnMoveToIgnore = new System.Windows.Forms.Button();
            this.btnMoveToSelect = new System.Windows.Forms.Button();
            this.btnPerformOperation = new System.Windows.Forms.Button();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSelectedFiles = new System.Windows.Forms.Label();
            this.lblIgnoredFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // cbOperations
            // 
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Location = new System.Drawing.Point(4, 4);
            this.cbOperations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(865, 23);
            this.cbOperations.TabIndex = 0;
            this.cbOperations.Text = "Select Operation";
            this.cbOperations.SelectedIndexChanged += new System.EventHandler(this.cbOperations_SelectedIndexChanged);
            // 
            // cbExtentions
            // 
            this.cbExtentions.FormattingEnabled = true;
            this.cbExtentions.Location = new System.Drawing.Point(4, 32);
            this.cbExtentions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbExtentions.Name = "cbExtentions";
            this.cbExtentions.Size = new System.Drawing.Size(865, 23);
            this.cbExtentions.TabIndex = 1;
            this.cbExtentions.Text = "Select File Extention";
            this.cbExtentions.SelectedIndexChanged += new System.EventHandler(this.cbExtentions_SelectedIndexChanged);
            // 
            // btnSourceFD
            // 
            this.btnSourceFD.Location = new System.Drawing.Point(4, 59);
            this.btnSourceFD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSourceFD.Name = "btnSourceFD";
            this.btnSourceFD.Size = new System.Drawing.Size(211, 22);
            this.btnSourceFD.TabIndex = 2;
            this.btnSourceFD.Text = "Click to select Source Folder";
            this.btnSourceFD.UseVisualStyleBackColor = true;
            this.btnSourceFD.Click += new System.EventHandler(this.btnSourceFD_Click);
            // 
            // btnDestinationFD
            // 
            this.btnDestinationFD.Location = new System.Drawing.Point(4, 85);
            this.btnDestinationFD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDestinationFD.Name = "btnDestinationFD";
            this.btnDestinationFD.Size = new System.Drawing.Size(213, 22);
            this.btnDestinationFD.TabIndex = 3;
            this.btnDestinationFD.Text = "Click to select destination folder";
            this.btnDestinationFD.UseVisualStyleBackColor = true;
            this.btnDestinationFD.Click += new System.EventHandler(this.btnDestinationFD_Click);
            // 
            // lblSourceFDPath
            // 
            this.lblSourceFDPath.AutoSize = true;
            this.lblSourceFDPath.Location = new System.Drawing.Point(221, 63);
            this.lblSourceFDPath.Name = "lblSourceFDPath";
            this.lblSourceFDPath.Size = new System.Drawing.Size(172, 15);
            this.lblSourceFDPath.TabIndex = 4;
            this.lblSourceFDPath.Text = "Please select source folder path";
            // 
            // lblDestinationFDPath
            // 
            this.lblDestinationFDPath.AutoSize = true;
            this.lblDestinationFDPath.Location = new System.Drawing.Point(223, 89);
            this.lblDestinationFDPath.Name = "lblDestinationFDPath";
            this.lblDestinationFDPath.Size = new System.Drawing.Size(196, 15);
            this.lblDestinationFDPath.TabIndex = 5;
            this.lblDestinationFDPath.Text = "Please select destination folder path";
            // 
            // lbSelectedFiles
            // 
            this.lbSelectedFiles.FormattingEnabled = true;
            this.lbSelectedFiles.ItemHeight = 15;
            this.lbSelectedFiles.Location = new System.Drawing.Point(4, 144);
            this.lbSelectedFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSelectedFiles.Name = "lbSelectedFiles";
            this.lbSelectedFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSelectedFiles.Size = new System.Drawing.Size(400, 484);
            this.lbSelectedFiles.TabIndex = 6;
            // 
            // lbIgnoredFiles
            // 
            this.lbIgnoredFiles.FormattingEnabled = true;
            this.lbIgnoredFiles.ItemHeight = 15;
            this.lbIgnoredFiles.Location = new System.Drawing.Point(471, 144);
            this.lbIgnoredFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbIgnoredFiles.Name = "lbIgnoredFiles";
            this.lbIgnoredFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbIgnoredFiles.Size = new System.Drawing.Size(398, 484);
            this.lbIgnoredFiles.TabIndex = 7;
            // 
            // btnMoveToIgnore
            // 
            this.btnMoveToIgnore.Location = new System.Drawing.Point(410, 273);
            this.btnMoveToIgnore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveToIgnore.Name = "btnMoveToIgnore";
            this.btnMoveToIgnore.Size = new System.Drawing.Size(56, 32);
            this.btnMoveToIgnore.TabIndex = 8;
            this.btnMoveToIgnore.Text = ">>";
            this.btnMoveToIgnore.UseVisualStyleBackColor = true;
            this.btnMoveToIgnore.Click += new System.EventHandler(this.btnMoveToIgnore_Click);
            // 
            // btnMoveToSelect
            // 
            this.btnMoveToSelect.Location = new System.Drawing.Point(410, 394);
            this.btnMoveToSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveToSelect.Name = "btnMoveToSelect";
            this.btnMoveToSelect.Size = new System.Drawing.Size(56, 32);
            this.btnMoveToSelect.TabIndex = 9;
            this.btnMoveToSelect.Text = "<<";
            this.btnMoveToSelect.UseVisualStyleBackColor = true;
            this.btnMoveToSelect.Click += new System.EventHandler(this.btnMoveToSelect_Click);
            // 
            // btnPerformOperation
            // 
            this.btnPerformOperation.Location = new System.Drawing.Point(471, 632);
            this.btnPerformOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPerformOperation.Name = "btnPerformOperation";
            this.btnPerformOperation.Size = new System.Drawing.Size(287, 44);
            this.btnPerformOperation.TabIndex = 10;
            this.btnPerformOperation.Text = "Click to perform operation";
            this.btnPerformOperation.UseVisualStyleBackColor = true;
            this.btnPerformOperation.Click += new System.EventHandler(this.btnPerformOperation_ClickAsync);
            // 
            // picLoader
            // 
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.Location = new System.Drawing.Point(252, 218);
            this.picLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(348, 269);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 11;
            this.picLoader.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(4, 633);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(283, 35);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSelectedFiles
            // 
            this.lblSelectedFiles.AutoSize = true;
            this.lblSelectedFiles.Location = new System.Drawing.Point(139, 123);
            this.lblSelectedFiles.Name = "lblSelectedFiles";
            this.lblSelectedFiles.Size = new System.Drawing.Size(98, 15);
            this.lblSelectedFiles.TabIndex = 13;
            this.lblSelectedFiles.Text = "Selected Files List";
            // 
            // lblIgnoredFiles
            // 
            this.lblIgnoredFiles.AutoSize = true;
            this.lblIgnoredFiles.Location = new System.Drawing.Point(635, 123);
            this.lblIgnoredFiles.Name = "lblIgnoredFiles";
            this.lblIgnoredFiles.Size = new System.Drawing.Size(95, 15);
            this.lblIgnoredFiles.TabIndex = 14;
            this.lblIgnoredFiles.Text = "Ignored Files List";
            // 
            // AutoCodeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 684);
            this.Controls.Add(this.lblIgnoredFiles);
            this.Controls.Add(this.lblSelectedFiles);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picLoader);
            this.Controls.Add(this.btnPerformOperation);
            this.Controls.Add(this.btnMoveToSelect);
            this.Controls.Add(this.btnMoveToIgnore);
            this.Controls.Add(this.lbIgnoredFiles);
            this.Controls.Add(this.lbSelectedFiles);
            this.Controls.Add(this.lblDestinationFDPath);
            this.Controls.Add(this.lblSourceFDPath);
            this.Controls.Add(this.btnDestinationFD);
            this.Controls.Add(this.btnSourceFD);
            this.Controls.Add(this.cbExtentions);
            this.Controls.Add(this.cbOperations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AutoCodeGeneration";
            this.Text = "Auto Code Generation";
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbOperations;
        private ComboBox cbExtentions;
        private Button btnSourceFD;
        private Button btnDestinationFD;
        private Label lblSourceFDPath;
        private Label lblDestinationFDPath;
        private ListBox lbSelectedFiles;
        private ListBox lbIgnoredFiles;
        private Button btnMoveToIgnore;
        private Button btnMoveToSelect;
        private Button btnPerformOperation;
        private PictureBox picLoader;
        private Button btnReset;
        private Label lblSelectedFiles;
        private Label lblIgnoredFiles;
    }
}