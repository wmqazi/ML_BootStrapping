using System;
using System.Collections.Generic;
using System.Text;

namespace Qazi.Common
{
    public class WorkerProgressEventArg : EventArgs
    {
        public float ProgressPercentage;
        public string UserState;
        public object AssociatedData;
    }
    public delegate void WorkerProgressUpdateEventHandler(object sender, WorkerProgressEventArg e);


    public class WorkerStartedEventArg : EventArgs
    {
        public string UserState;
    }
    public delegate void WorkerStartedEventHandler(object sender);
    public delegate void WorkerStartedWithStatusUpdateEventHandler(object sender, WorkerStartedEventArg e);


    public class WorkerCompletedEventArg : EventArgs
    {
        public string UserStateMessage;
        public object Result;
    }
    public delegate void WorkerCompletedEventHandler(object sender, WorkerCompletedEventArg e);
}
