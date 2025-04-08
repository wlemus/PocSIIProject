using PocSII.DteComunicaciones;
using PocSII.DteComunicaciones.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesTest.PubSub
{
    /// <summary>
    /// SubscriptorEmailNotification es la clase que se encarga de enviar notificaciones por correo electrónico a los suscriptores.
    /// </summary>
    public class SubscriptorEmailNotification  {
        private string _name;
        public SubscriptorEmailNotification(string name) {
            _name = name;

        }

       public void Suscribe(PublisherNotification publisher) {
            publisher.OnNotification += OnNotification;
        }
        public void Unsubscribe(PublisherNotification publisher) {
            publisher.OnNotification -= OnNotification;
        }
        private void OnNotification(Notification mensaje) {
            var not = new NotificationServices();
            not.SendEmailNotification(mensaje);
            Console.WriteLine($"El suscriptor {_name} ha recibido el mensaje: {mensaje}");
        }

    }
}
