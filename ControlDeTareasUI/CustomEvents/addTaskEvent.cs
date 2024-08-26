using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary;

namespace ControlDeTareasUI.CustomEvents
{
    public class AddTaskEventCompleted
    {
        public event EventHandler<string> TaskAddCompleted;

        protected virtual void OnTaskAddCompleted(string message)
        {
            TaskAddCompleted?.Invoke(this, message);
        }

        public void SendTaskAddNotification(string message)
        {
            OnTaskAddCompleted(message);
        }

    }
}
