using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_Pub
{
    public class Publisher
    {
        public string PublisherName { get; set; }
        public Publisher(string publisherName)
        {
            PublisherName = publisherName;
        }

        //Ci saranno una serie di metodi Notify
        //Delegate
        public delegate void Notify(Publisher p, Notification n);
        //Quando ci sarà un evento si scatenerà un Notify
        //Evento
        public event Notify OnPublish;

        //Metodo che pubblica l'evento
        public void Publish()
        {
            if(OnPublish != null)
            {
                Notification notification = new Notification("New Notification from ", DateTime.Now);

                OnPublish(this, notification);
            }

        }
    }
}
