using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Interfaces;
using PocSII.DteProcessor.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PocSII.DteProcessor.Services
{
   public class DteQueryService: IDteQueryService {
        private readonly HttpClient _httpClient;
        public DteQueryService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<Result<DTEResponseQuery>> GetDteAsync( string trackid,  string endpointUrl) {
            try {
                using var form = new MultipartFormDataContent();
                form.Add(new StringContent(trackid), "trackid");

                if (string.IsNullOrEmpty(endpointUrl))
                    endpointUrl = "http://localhost:8080/DTEWS/QueryEstDte";

                var response = await _httpClient.PostAsync(endpointUrl, form);

                if (!response.IsSuccessStatusCode) {
                    var error = await response.Content.ReadAsStringAsync();
                    return Result<DTEResponseQuery>.Failure(
                        $"Error al consultar el DTE. Código: {response.StatusCode}, Detalle: {error}");
                }

                var xml = await response.Content.ReadAsStringAsync();

                var serializer = new XmlSerializer(typeof(DTEResponseQuery));
                using var reader = new StringReader(xml);
                var parsed = (DTEResponseQuery)serializer.Deserialize(reader);

                if (parsed == null) {

                    parsed = new DTEResponseQuery {
                        Header = new RespuestaHeader {
                            CodigoError = 3,
                            Estado = "FAU",
                            Glosa= "DTE No Recibido",
                            GlosaError = "Documento No Recibido por el SII",
                            NumeroAtencion = "1234"                              

                        },
                    };
                }
                return Result<DTEResponseQuery>.Success(parsed);

            } catch (Exception ex) {
                
                return Result<DTEResponseQuery>.Failure($"Excepción al consultar el DTE en el SII: {ex.Message}");
            }
        }
    }
}
