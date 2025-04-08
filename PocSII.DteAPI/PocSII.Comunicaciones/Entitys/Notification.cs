
using System.Runtime.Serialization;


namespace PocSII.DteComunicaciones {
    public partial class Notification
    {
           public int IdNotificacion { get; set; } = default;

       
        public IList<string> Destinatarios { get; set; }

         public required string Asunto { get; set; }

        public required string Contenido { get; set; }

       
        public  string FechaEnvio { get; set; }

       
          public eEstadoNotificacion Estado { get; set; }


        public string IdMensaje { get; set; } = string.Empty;
    }
    public enum eEstadoNotificacion {

        /// <summary>
        /// Enum ENTREGADOEnum for ENTREGADO
        /// </summary>
        [EnumMember(Value = "ENTREGADO")]
        ENTREGADOEnum = 1,

        /// <summary>
        /// Enum FALLIDOEnum for FALLIDO
        /// </summary>
        [EnumMember(Value = "FALLIDO")]
        FALLIDOEnum = 2,

        /// <summary>
        /// Enum PENDIENTEEnum for PENDIENTE
        /// </summary>
        [EnumMember(Value = "PENDIENTE")]
        PENDIENTEEnum = 3,

        [EnumMember(Value = "ENTREGADO_SPAM")]
        ENTREGADO_SPAMEnum = 4
    }

}
