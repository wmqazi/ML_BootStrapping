using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Qazi.Common;

namespace Qazi.MachineLearning.CrossValidation.BootStrapping
{
    public class BootStrapping
    {
        public event WorkerCompletedEventHandler SamplingCompleted;
        public event WorkerProgressUpdateEventHandler SamplingProgress;
        public event WorkerStartedEventHandler SamplingStarted;
        
        public WorkerProgressEventArg SamplingProgressEventArgs;

        private DataTable _SourceDataTable;
        private DataTable _TrainingDataTable;
        private DataTable _ValidationDataTable;
        private List<int> _SelectedItemIndexes;
        private Random rnd;

        private int index;
        private int total;
        private DataRow row;
        private int randomno;

        public BootStrapping()
        {
            _SelectedItemIndexes = new List<int>();
            SamplingProgressEventArgs = new WorkerProgressEventArg();
            ResetRandomizer();
        }

        public void ResetRandomizer()
        {
            if (rnd != null)
                rnd = null;
            rnd = new Random();
        }
        public void DoSampling(DataTable sourceDataTable)
        {
            ClearObjects();
            if (SamplingStarted != null)
                SamplingStarted(this);

            _SourceDataTable = sourceDataTable;
            _TrainingDataTable = new DataTable();
            _ValidationDataTable = new DataTable();
            _TrainingDataTable = _SourceDataTable.Clone();
            _ValidationDataTable = _SourceDataTable.Clone();

            total = _SourceDataTable.Rows.Count;
            SamplingProgressEventArgs.UserState = "Performing Bootstrapping";
            for (index = 1; index <= total; index++)
            {
                randomno = rnd.Next(total);
                //System.Windows.Forms.MessageBox.Show(randomno.ToString());
                _SelectedItemIndexes.Add(randomno);
                SamplingProgressEventArgs.ProgressPercentage = (((float)index / (float)total) * 100);
                if (SamplingProgress != null)
                    SamplingProgress(this, SamplingProgressEventArgs);
            }

            SamplingProgressEventArgs.UserState = "Importing Bootstrapped Data to Training and Validation DataTables";
            for (index = 0; index < total; index++)
            {
                row = _SourceDataTable.Rows[index];
                if (_SelectedItemIndexes.Contains(index) == true)
                    _TrainingDataTable.ImportRow(row);
                else
                    _ValidationDataTable.ImportRow(row);

                SamplingProgressEventArgs.ProgressPercentage = (((float)(index+1) / (float)total) * 100);
                if (SamplingProgress != null)
                    SamplingProgress(this, SamplingProgressEventArgs);
            }

            if (SamplingCompleted != null)
                SamplingCompleted(this, null);
        }

        private void ClearObjects()
        {
            if(_TrainingDataTable != null)
                if (_TrainingDataTable.Rows.Count > 0 )
                    _TrainingDataTable.Clear();
            if(_ValidationDataTable != null)
                if (_ValidationDataTable.Rows.Count > 0)
                    _ValidationDataTable.Clear();

            if(_SelectedItemIndexes != null)
                if (_SelectedItemIndexes.Count > 0)
                    _SelectedItemIndexes.Clear();
        }

        public DataTable ValidateDataTable
        {
            get {
                return _ValidationDataTable;
            }
        }

        public DataTable TrainingDataTable
        {
            get {
                return _TrainingDataTable;
            }
        }

    }
}
