using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeTareasUI.CustomEvents
{
    public class DeleteTaskEvent
    {
        public event EventHandler<string> DeleteTaskNotification;

        protected virtual void OnDeleteTaskNotification(string message)
        {
            DeleteTaskNotification?.Invoke(this, message);
        }

        public void SendDeleteTaskNotification(string messasge)
        {
            OnDeleteTaskNotification(messasge);
        }
    }
    
    
}
