namespace SourceCompare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuMainWindow = new System.Windows.Forms.MenuStrip();
            this.setFolder1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFolder2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbComparison = new System.Windows.Forms.ToolStripComboBox();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbShowSame = new System.Windows.Forms.ToolStripComboBox();
            this.cmbShowOnly1 = new System.Windows.Forms.ToolStripComboBox();
            this.cmbShowOnly2 = new System.Windows.Forms.ToolStripComboBox();
            this.cmbShowDifferent = new System.Windows.Forms.ToolStripComboBox();
            this.resultActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSameFrom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSameFrom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder1 = new System.Windows.Forms.TextBox();
            this.txtFolder2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.GridPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridComparison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridModified1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridModified2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuMainWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMainWindow
            // 
            this.menuMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFolder1ToolStripMenuItem,
            this.setFolder2ToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.cmbComparison,
            this.compareToolStripMenuItem,
            this.showResultsToolStripMenuItem,
            this.resultActionsToolStripMenuItem});
            this.menuMainWindow.Location = new System.Drawing.Point(0, 0);
            this.menuMainWindow.Name = "menuMainWindow";
            this.menuMainWindow.Size = new System.Drawing.Size(844, 27);
            this.menuMainWindow.TabIndex = 0;
            this.menuMainWindow.Text = "menuStrip1";
            // 
            // setFolder1ToolStripMenuItem
            // 
            this.setFolder1ToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.pencil;
            this.setFolder1ToolStripMenuItem.Name = "setFolder1ToolStripMenuItem";
            this.setFolder1ToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.setFolder1ToolStripMenuItem.Text = "Set Folder &1";
            this.setFolder1ToolStripMenuItem.Click += new System.EventHandler(this.setFolder1ToolStripMenuItem_Click);
            // 
            // setFolder2ToolStripMenuItem
            // 
            this.setFolder2ToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.pencil;
            this.setFolder2ToolStripMenuItem.Name = "setFolder2ToolStripMenuItem";
            this.setFolder2ToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.setFolder2ToolStripMenuItem.Text = "Set Folder &2";
            this.setFolder2ToolStripMenuItem.Click += new System.EventHandler(this.setFolder2ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.door_in;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmbComparison
            // 
            this.cmbComparison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComparison.Items.AddRange(new object[] {
            "File Contents",
            "File Timestamp"});
            this.cmbComparison.Name = "cmbComparison";
            this.cmbComparison.Size = new System.Drawing.Size(121, 23);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.page_copy;
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.compareToolStripMenuItem.Text = "&Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // showResultsToolStripMenuItem
            // 
            this.showResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbShowSame,
            this.cmbShowOnly1,
            this.cmbShowOnly2,
            this.cmbShowDifferent});
            this.showResultsToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.script_gear;
            this.showResultsToolStripMenuItem.Name = "showResultsToolStripMenuItem";
            this.showResultsToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.showResultsToolStripMenuItem.Text = "Show Results";
            // 
            // cmbShowSame
            // 
            this.cmbShowSame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowSame.Items.AddRange(new object[] {
            "Show Same",
            "Hide Same"});
            this.cmbShowSame.Name = "cmbShowSame";
            this.cmbShowSame.Size = new System.Drawing.Size(121, 23);
            this.cmbShowSame.SelectedIndexChanged += new System.EventHandler(this.cmbShowSame_SelectedIndexChanged_1);
            // 
            // cmbShowOnly1
            // 
            this.cmbShowOnly1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowOnly1.Items.AddRange(new object[] {
            "Show Only 1",
            "Hide Only 1"});
            this.cmbShowOnly1.Name = "cmbShowOnly1";
            this.cmbShowOnly1.Size = new System.Drawing.Size(121, 23);
            this.cmbShowOnly1.SelectedIndexChanged += new System.EventHandler(this.cmbShowOnly1_SelectedIndexChanged);
            // 
            // cmbShowOnly2
            // 
            this.cmbShowOnly2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowOnly2.Items.AddRange(new object[] {
            "Show Only 2",
            "Hide Only 2"});
            this.cmbShowOnly2.Name = "cmbShowOnly2";
            this.cmbShowOnly2.Size = new System.Drawing.Size(121, 23);
            this.cmbShowOnly2.SelectedIndexChanged += new System.EventHandler(this.cmbShowOnly2_SelectedIndexChanged);
            // 
            // cmbShowDifferent
            // 
            this.cmbShowDifferent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowDifferent.Items.AddRange(new object[] {
            "Show Different",
            "Hide Different"});
            this.cmbShowDifferent.Name = "cmbShowDifferent";
            this.cmbShowDifferent.Size = new System.Drawing.Size(121, 23);
            this.cmbShowDifferent.SelectedIndexChanged += new System.EventHandler(this.cmbShowDifferent_SelectedIndexChanged);
            // 
            // resultActionsToolStripMenuItem
            // 
            this.resultActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSameFrom1ToolStripMenuItem,
            this.deleteSameFrom2ToolStripMenuItem});
            this.resultActionsToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.script_go;
            this.resultActionsToolStripMenuItem.Name = "resultActionsToolStripMenuItem";
            this.resultActionsToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.resultActionsToolStripMenuItem.Text = "Result Actions";
            // 
            // deleteSameFrom1ToolStripMenuItem
            // 
            this.deleteSameFrom1ToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.script_delete;
            this.deleteSameFrom1ToolStripMenuItem.Name = "deleteSameFrom1ToolStripMenuItem";
            this.deleteSameFrom1ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteSameFrom1ToolStripMenuItem.Text = "Delete Same from 1";
            this.deleteSameFrom1ToolStripMenuItem.Click += new System.EventHandler(this.deleteSameFrom1ToolStripMenuItem_Click);
            // 
            // deleteSameFrom2ToolStripMenuItem
            // 
            this.deleteSameFrom2ToolStripMenuItem.Image = global::SourceCompare.Properties.Resources.script_delete;
            this.deleteSameFrom2ToolStripMenuItem.Name = "deleteSameFrom2ToolStripMenuItem";
            this.deleteSameFrom2ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteSameFrom2ToolStripMenuItem.Text = "Delete Same from 2";
            this.deleteSameFrom2ToolStripMenuItem.Click += new System.EventHandler(this.deleteSameFrom2ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder 1";
            // 
            // txtFolder1
            // 
            this.txtFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder1.Location = new System.Drawing.Point(63, 27);
            this.txtFolder1.Name = "txtFolder1";
            this.txtFolder1.Size = new System.Drawing.Size(769, 20);
            this.txtFolder1.TabIndex = 2;
            // 
            // txtFolder2
            // 
            this.txtFolder2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder2.Location = new System.Drawing.Point(63, 53);
            this.txtFolder2.Name = "txtFolder2";
            this.txtFolder2.Size = new System.Drawing.Size(769, 20);
            this.txtFolder2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder 2";
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.AllowUserToResizeRows = false;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.BackgroundColor = System.Drawing.Color.White;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridPath,
            this.GridComparison,
            this.GridModified1,
            this.GridModified2});
            this.gridResults.Location = new System.Drawing.Point(15, 98);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.RowHeadersVisible = false;
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridResults.Size = new System.Drawing.Size(817, 384);
            this.gridResults.TabIndex = 5;
            this.gridResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResults_CellDoubleClick);
            // 
            // GridPath
            // 
            this.GridPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GridPath.HeaderText = "Path";
            this.GridPath.Name = "GridPath";
            this.GridPath.ReadOnly = true;
            // 
            // GridComparison
            // 
            this.GridComparison.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GridComparison.HeaderText = "Comparison";
            this.GridComparison.Name = "GridComparison";
            this.GridComparison.ReadOnly = true;
            // 
            // GridModified1
            // 
            this.GridModified1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GridModified1.HeaderText = "Modified 1";
            this.GridModified1.Name = "GridModified1";
            this.GridModified1.ReadOnly = true;
            this.GridModified1.Width = 120;
            // 
            // GridModified2
            // 
            this.GridModified2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GridModified2.HeaderText = "Modified 2";
            this.GridModified2.Name = "GridModified2";
            this.GridModified2.ReadOnly = true;
            this.GridModified2.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Results";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(15, 488);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(817, 22);
            this.progressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 522);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.txtFolder2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFolder1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuMainWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMainWindow;
            this.Name = "Form1";
            this.Text = "Source Compare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuMainWindow.ResumeLayout(false);
            this.menuMainWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainWindow;
        private System.Windows.Forms.ToolStripMenuItem setFolder1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFolder2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder1;
        private System.Windows.Forms.TextBox txtFolder2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridComparison;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridModified1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridModified2;
        private System.Windows.Forms.ToolStripMenuItem resultActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSameFrom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSameFrom2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbShowSame;
        private System.Windows.Forms.ToolStripComboBox cmbShowOnly1;
        private System.Windows.Forms.ToolStripComboBox cmbShowOnly2;
        private System.Windows.Forms.ToolStripComboBox cmbShowDifferent;
        private System.Windows.Forms.ToolStripComboBox cmbComparison;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

