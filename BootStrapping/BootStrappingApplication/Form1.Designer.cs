namespace BootStrappingApplication
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridSource = new System.Windows.Forms.DataGridView();
            this.lblSourceRecordCount = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridTraining = new System.Windows.Forms.DataGridView();
            this.lblTrainingRecordCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridValidaton = new System.Windows.Forms.DataGridView();
            this.lblValidationRecordCount = new System.Windows.Forms.Label();
            this.saveTrainingDataTable = new System.Windows.Forms.SaveFileDialog();
            this.bootStrappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSourceDataTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTrainingDataTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveValidationDataTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveValidationData = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSource)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValidaton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar,
            this.lblStatus,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(150, 16);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(732, 428);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridSource);
            this.groupBox1.Controls.Add(this.lblSourceRecordCount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source DataTable";
            // 
            // gridSource
            // 
            this.gridSource.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSource.Location = new System.Drawing.Point(3, 16);
            this.gridSource.Name = "gridSource";
            this.gridSource.Size = new System.Drawing.Size(726, 124);
            this.gridSource.TabIndex = 5;
            // 
            // lblSourceRecordCount
            // 
            this.lblSourceRecordCount.AutoSize = true;
            this.lblSourceRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSourceRecordCount.ForeColor = System.Drawing.Color.Navy;
            this.lblSourceRecordCount.Location = new System.Drawing.Point(3, 140);
            this.lblSourceRecordCount.Name = "lblSourceRecordCount";
            this.lblSourceRecordCount.Size = new System.Drawing.Size(0, 13);
            this.lblSourceRecordCount.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(732, 268);
            this.splitContainer2.SplitterDistance = 124;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridTraining);
            this.groupBox2.Controls.Add(this.lblTrainingRecordCount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 124);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Training DataTable";
            // 
            // gridTraining
            // 
            this.gridTraining.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTraining.Location = new System.Drawing.Point(3, 16);
            this.gridTraining.Name = "gridTraining";
            this.gridTraining.Size = new System.Drawing.Size(726, 92);
            this.gridTraining.TabIndex = 7;
            // 
            // lblTrainingRecordCount
            // 
            this.lblTrainingRecordCount.AutoSize = true;
            this.lblTrainingRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrainingRecordCount.ForeColor = System.Drawing.Color.Navy;
            this.lblTrainingRecordCount.Location = new System.Drawing.Point(3, 108);
            this.lblTrainingRecordCount.Name = "lblTrainingRecordCount";
            this.lblTrainingRecordCount.Size = new System.Drawing.Size(0, 13);
            this.lblTrainingRecordCount.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridValidaton);
            this.groupBox3.Controls.Add(this.lblValidationRecordCount);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 140);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Validation DataSet";
            // 
            // gridValidaton
            // 
            this.gridValidaton.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridValidaton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridValidaton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridValidaton.Location = new System.Drawing.Point(3, 16);
            this.gridValidaton.Name = "gridValidaton";
            this.gridValidaton.Size = new System.Drawing.Size(726, 108);
            this.gridValidaton.TabIndex = 7;
            // 
            // lblValidationRecordCount
            // 
            this.lblValidationRecordCount.AutoSize = true;
            this.lblValidationRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblValidationRecordCount.ForeColor = System.Drawing.Color.Navy;
            this.lblValidationRecordCount.Location = new System.Drawing.Point(3, 124);
            this.lblValidationRecordCount.Name = "lblValidationRecordCount";
            this.lblValidationRecordCount.Size = new System.Drawing.Size(0, 13);
            this.lblValidationRecordCount.TabIndex = 6;
            this.lblValidationRecordCount.Click += new System.EventHandler(this.lblValidationRecordCount_Click);
            // 
            // saveTrainingDataTable
            // 
            this.saveTrainingDataTable.Filter = "XML File|*.XML";
            this.saveTrainingDataTable.FileOk += new System.ComponentModel.CancelEventHandler(this.saveTrainingDataTable_FileOk);
            // 
            // bootStrappingToolStripMenuItem
            // 
            this.bootStrappingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
            this.bootStrappingToolStripMenuItem.Name = "bootStrappingToolStripMenuItem";
            this.bootStrappingToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.bootStrappingToolStripMenuItem.Text = "Boot Strapping";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bootStrappingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importSourceDataTableToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveTrainingDataTableToolStripMenuItem,
            this.saveValidationDataTableToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importSourceDataTableToolStripMenuItem
            // 
            this.importSourceDataTableToolStripMenuItem.Name = "importSourceDataTableToolStripMenuItem";
            this.importSourceDataTableToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.importSourceDataTableToolStripMenuItem.Text = "Import Source DataTable";
            this.importSourceDataTableToolStripMenuItem.Click += new System.EventHandler(this.importSourceDataTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // saveTrainingDataTableToolStripMenuItem
            // 
            this.saveTrainingDataTableToolStripMenuItem.Name = "saveTrainingDataTableToolStripMenuItem";
            this.saveTrainingDataTableToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.saveTrainingDataTableToolStripMenuItem.Text = "Save Training DataTable";
            this.saveTrainingDataTableToolStripMenuItem.Click += new System.EventHandler(this.saveTrainingDataTableToolStripMenuItem_Click);
            // 
            // saveValidationDataTableToolStripMenuItem
            // 
            this.saveValidationDataTableToolStripMenuItem.Name = "saveValidationDataTableToolStripMenuItem";
            this.saveValidationDataTableToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.saveValidationDataTableToolStripMenuItem.Text = "Save Validation DataTable";
            this.saveValidationDataTableToolStripMenuItem.Click += new System.EventHandler(this.saveValidationDataTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML File|*.XML";
            // 
            // saveValidationData
            // 
            this.saveValidationData.Filter = "XML File|*.XML";
            this.saveValidationData.FileOk += new System.ComponentModel.CancelEventHandler(this.saveValidationData_FileOk);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(502, 17);
            this.toolStripStatusLabel1.Text = "(C) Wajahat M. Qazi @ CIRL, Department of Computer Science, GC University Lahore," +
                " Pakistan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "BootStrapping [(C) Wajahat M. Qazi @ CIRL, Department of Computer Science, GC Uni" +
                "versity Lahore, Pakistan]";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValidaton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveTrainingDataTable;
        private System.Windows.Forms.ToolStripMenuItem bootStrappingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSourceDataTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveTrainingDataTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveValidationDataTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView gridSource;
        private System.Windows.Forms.Label lblSourceRecordCount;
        private System.Windows.Forms.DataGridView gridTraining;
        private System.Windows.Forms.Label lblTrainingRecordCount;
        private System.Windows.Forms.DataGridView gridValidaton;
        private System.Windows.Forms.Label lblValidationRecordCount;
        private System.Windows.Forms.SaveFileDialog saveValidationData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}

