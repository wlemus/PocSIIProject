using PocSII.DteBusinessRules.Common;
using System.Text.Json.Serialization;

namespace PocSII.DteBusinessRules.Domain
{
   
    public abstract class ElectronicDocument
    {
        [JsonPropertyName("rut_emisor")]
        public string RutEmisor { get; set; }

        [JsonPropertyName("rut_receptor")]
       
        public string RutReceptor { get; set; }

        [JsonPropertyName("folio")]
        public string Folio { get; set; }
        [JsonPropertyName("forma_pago")]       
        public string? FormaPago { get; set; }

        [JsonPropertyName("fecha_emision")]
        public string FechaEmision { get; set; }

        [JsonPropertyName("totales")]
        public TotalsDocument Totales { get; set; }

        [JsonPropertyName("detalle")]
        public List<DetailDocument> Detalle { get; set; }

        public virtual Task<Result<List<string>>> IsInvalid() {
            throw new NotImplementedException();
        }

    }
    public class TotalsDocument {     
        [JsonPropertyName("monto_neto")]
        public string MontoNeto { get; set; }

        [JsonPropertyName("tasa_iva")]
        public string? TasaIVA { get; set; }

        [JsonPropertyName("iva")]
        public string IVA { get; set; }

        [JsonPropertyName("monto_total")]
        public string MontoTotal { get; set; }
    }
    public class DetailDocument {
      
        [JsonPropertyName("codigo_item")]
        public List<ItemCodeDetailDocument> CodigoItem { get; set; }

        [JsonPropertyName("nombre_item")]
        public string NombreItem { get; set; }

        [JsonPropertyName("descripcion_item")]
        public string DescripcionItem { get; set; }

        [JsonPropertyName("cantidad_item")]
        public string CantidadItem { get; set; }

        [JsonPropertyName("precio_item")]
        public string PrecioItem { get; set; }

        [JsonPropertyName("monto_item")]
        public string MontoItem { get; set; }
    }
    public class ItemCodeDetailDocument {
      
        [JsonPropertyName("tipo_codigo")]
        public string TipoCodigo { get; set; }

        [JsonPropertyName("valor_codigo")]
        public string ValorCodigo { get; set; }
    }
}
