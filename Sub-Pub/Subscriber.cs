using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_Pub
{
    public class Subscriber 
    {
        public string SubscriberName { get; set; }

        public Subscriber(string name)
        {
            SubscriberName = name;
        }
        
        //Metodi per creare ed annullare la notifica dell'evento

        public void Subscribe(Publisher p) 
        {
            //Mi registro alla notifica dell'evento
            //Creo un metodo all'interno del subscriber
            //che gestisce la ricezione della notifica

            //Iscrivimi all'evento OnPublish
            p.OnPublish += OnNotificationReceived;
        }
        public void UnSubscribe(Publisher p)
        {
            p.OnPublish -= OnNotificationReceived;
        }
        public void OnNotificationReceived(Publisher p, Notification n)
        {
            Console.WriteLine($"Ciao, {SubscriberName} " +
                $"Notifica ricevuta da {p.PublisherName}" +
                $" il giorno {n.NotificationData}\n{n.NotificationMessage}");
        }
    }
}
