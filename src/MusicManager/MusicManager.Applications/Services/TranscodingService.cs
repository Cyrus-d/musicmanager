﻿using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using System.Waf.Foundation;
using System.Windows.Input;

namespace Waf.MusicManager.Applications.Services
{
    [Export(typeof(ITranscodingService)), Export]
    internal class TranscodingService : Model, ITranscodingService
    {
        private ICommand convertToMp3AllCommand;
        private ICommand convertToMp3SelectedCommand;
        private ICommand cancelAllCommand;
        private ICommand cancelSelectedCommand;


        public ICommand ConvertToMp3AllCommand
        {
            get { return convertToMp3AllCommand; }
            set { SetProperty(ref convertToMp3AllCommand, value); }
        }

        public ICommand ConvertToMp3SelectedCommand
        {
            get { return convertToMp3SelectedCommand; }
            set { SetProperty(ref convertToMp3SelectedCommand, value); }
        }

        public ICommand CancelAllCommand
        {
            get { return cancelAllCommand; }
            set { SetProperty(ref cancelAllCommand, value); }
        }

        public ICommand CancelSelectedCommand
        {
            get { return cancelSelectedCommand; }
            set { SetProperty(ref cancelSelectedCommand, value); }
        }


        public event EventHandler<TranscodingTaskEventArgs> TranscodingTaskCreated;


        public void RaiseTranscodingTaskCreated(string fileName, Task transcodingTask)
        {
            OnTranscodingTaskCreated(new TranscodingTaskEventArgs(fileName, transcodingTask));
        }

        protected virtual void OnTranscodingTaskCreated(TranscodingTaskEventArgs e)
        {
            if (TranscodingTaskCreated != null) { TranscodingTaskCreated(this, e); }
        }
    }
}
