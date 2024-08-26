using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeTareasUI.CustomEvents
{
    public  class InvalidLoginErrorHandler
    {
        public event EventHandler<String> InvalidLoginNotification;

        protected virtual void OnInvalidLoginNotification(String message)
        {
            InvalidLoginNotification?.Invoke(this, message);
        }

        public void SendInvalidLoginNotification(String message)
        {
            OnInvalidLoginNotification(message);
        }
    }
}
