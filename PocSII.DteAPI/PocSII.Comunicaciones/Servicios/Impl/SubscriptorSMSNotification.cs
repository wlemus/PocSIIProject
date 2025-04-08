using PocSII.DteComunicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesTest.PubSub
{
    /// <summary>
    /// SubscriptorSMSNotification es la clase que se encarga de enviar notificaciones por SMS a los suscriptores.
    /// </summary>
    public class SubscriptorSMSNotification {
        private string _name;
        public SubscriptorSMSNotification(string name) {
            _name = name;
        }

       public void Suscribe(PublisherNotification publisher) {
            publisher.OnNotification += OnNotification;
        }
        public void Unsubscribe(PublisherNotification publisher) {
            publisher.OnNotification -= OnNotification;
        }
        private void OnNotification(Notification mensaje) {          
            Console.WriteLine($"El suscriptor {_name} ha recibido el mensaje: {mensaje}");
        }
    }
}
