using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_Pub
{
    public class Notification
    {
        public string NotificationMessage { get; set; }
        public DateTime NotificationData { get; }

        public Notification(string messaggio, DateTime data)
        {
            NotificationMessage = messaggio;
            NotificationData = data;
        }

    }
}
