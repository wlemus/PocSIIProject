

using System.Net.Mail;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace PocSII.DteComunicaciones {
    public class NotificationServices : INotificationService {
     //   private readonly SmtpSettings _smtpSettings;
        public bool SendEmailNotification(Notification notification) {
            try {                         
                    var smtpClient = new SmtpClient("live.smtp.mailtrap.io")  // Ejemplo: smtp.gmail.com
                    {
                        Port = 587, 
                        Credentials = new NetworkCredential("api", "dccf3d12d781fa4f29e08fe80e715962"),
                        EnableSsl = true
                    };

                    var mensaje = new MailMessage {
                        From = new MailAddress("hello@demomailtrap.co"),
                        Subject = notification.Asunto,
                        Body = notification.Contenido,
                        IsBodyHtml = false
                    };

                    mensaje.To.Add(notification.Destinatarios[0]);

                    smtpClient.Send(mensaje);
            } catch (Exception) {

              return false;
            }
            return true;    
                }   
        
    }

    public class SmtpSettings {
        public string Host { get; set; } = "";
        public int Port { get; set; }
        public string User { get; set; } = "";
        public string Password { get; set; } = "";
        public string From { get; set; } = "";
        public bool EnableSsl { get; set; }
    }
}
