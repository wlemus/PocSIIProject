using PocSII.DteComunicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteComunicaciones {
    /// <summary>
    /// PublisherNotification es la clase que se encarga de enviar notificaciones a los suscriptores.
    /// </summary>
    /// <remarks>
    /// Esta clase implementa el patrón de diseño Publisher-Subscriber, donde los suscriptores pueden registrarse para recibir notificaciones.
    /// </remarks>
    public class PublisherNotification 
    {
        public event Action<Notification> OnNotification;
        public void SendMessage(Notification mensaje) {
        
            OnNotification?.Invoke(mensaje); 
        }

    }
}
