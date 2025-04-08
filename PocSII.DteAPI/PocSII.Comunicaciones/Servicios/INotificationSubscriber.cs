using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteComunicaciones.Servicios
{
    public interface INotificationSubscriber {
        void Suscribe(PublisherNotification publisher);


        void Unsubscribe(PublisherNotification publisher);


        void OnNotification(Notification mensaje);
    }
        
}
