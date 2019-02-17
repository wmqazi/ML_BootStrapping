using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Qazi.MachineLearning.CrossValidation.BootStrapping;
using Qazi.GUI.CommonDialogs;
using Qazi.Common;
namespace BootStrappingApplication
{
    public partial class Form1 : Form
    {
        private DataTableSelectorWnd _DataTableSelectorWnd;
        private BootStrapping _BootStrapAgent;
        private DataTable _SourceDataTable;
        private DataTable _TrainingDataTable;
        private DataTable _ValidationDataTable;

        public Form1()
        {
            InitializeComponent();
            _BootStrapAgent = new BootStrapping();
            _BootStrapAgent.SamplingCompleted += new WorkerCompletedEventHandler(_BootStrapAgent_SamplingCompleted);
            _BootStrapAgent.SamplingProgress += new WorkerProgressUpdateEventHandler(_BootStrapAgent_SamplingProgress);
            _BootStrapAgent.SamplingStarted += new WorkerStartedEventHandler(_BootStrapAgent_SamplingStarted);
        }

        void _BootStrapAgent_SamplingStarted(object sender)
        {
            lblStatus.Text = "Bootstrapping Started...";            
        }

        void _BootStrapAgent_SamplingProgress(object sender, WorkerProgressEventArg e)
        {
            lblStatus.Text = e.UserState;
            progressbar.Value = (int)e.ProgressPercentage;
            Application.DoEvents();
            
        }

        void _BootStrapAgent_SamplingCompleted(object sender, WorkerCompletedEventArg e)
        {
            lblStatus.Text = "Bootstrapping Done...";

            _TrainingDataTable = _BootStrapAgent.TrainingDataTable;
            _ValidationDataTable  = _BootStrapAgent.ValidateDataTable;

            gridTraining.DataSource = _TrainingDataTable;
            gridValidaton.DataSource = _ValidationDataTable;
            lblTrainingRecordCount.Text = _BootStrapAgent.TrainingDataTable.Rows.Count.ToString();
            lblValidationRecordCount.Text = _BootStrapAgent.ValidateDataTable.Rows.Count.ToString();
        }

        private void importSourceDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            if (openFileDialog1.FileName != "")
            {
                DataSet ds = new DataSet();
                ds.ReadXml(openFileDialog1.FileName);
                _DataTableSelectorWnd = new DataTableSelectorWnd("Select Data Source Table", ds);
                _DataTableSelectorWnd.ShowDialog(this);
                _SourceDataTable = ds.Tables[_DataTableSelectorWnd.TableName];
                ds = null;

                gridSource.DataSource = _SourceDataTable;
                lblSourceRecordCount.Text = _SourceDataTable.Rows.Count.ToString();
            }
        }
     
        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BootStrapAgent.DoSampling(_SourceDataTable);
        }

        private void lblValidationRecordCount_Click(object sender, EventArgs e)
        {

        }

        private void saveTrainingDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTrainingDataTable.ShowDialog();
        }

        private void saveValidationDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveValidationData.ShowDialog();
        }

        private void saveTrainingDataTable_FileOk(object sender, CancelEventArgs e)
        {
            _TrainingDataTable.WriteXml(saveTrainingDataTable.FileName);
        }

        private void saveValidationData_FileOk(object sender, CancelEventArgs e)
        {
            _ValidationDataTable.WriteXml(saveValidationData.FileName);
        }
    }
}