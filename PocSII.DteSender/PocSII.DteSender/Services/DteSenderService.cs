using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Domain;
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
   public class DteSenderService
    {
        private readonly HttpClient _httpClient;
        public DteSenderService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<Result<DTEResponseReception>> SendDteXmlAsync( string folio, string xmlContent, string endpointUrl) {
            try {
                using var form = new MultipartFormDataContent();
                form.Add(new StringContent(folio), "folio");

                if (string.IsNullOrEmpty(endpointUrl))
                    endpointUrl = "http://localhost:8080/cgi_dte/UPL/DTEUpload";

                var response = await _httpClient.PostAsync(endpointUrl, form);

                if (!response.IsSuccessStatusCode) {
                    var error = await response.Content.ReadAsStringAsync();
                    return Result<DTEResponseReception>.Failure(
                        $"Error al enviar solicitud. Código: {response.StatusCode}, Detalle: {error}");
                }

                var xml = await response.Content.ReadAsStringAsync();

                var serializer = new XmlSerializer(typeof(DTEResponseReception));
                using var reader = new StringReader(xml);
                var parsed = (DTEResponseReception)serializer.Deserialize(reader);

                //var result = new DTEResponseReception {
                //    RutSender = "97975000-5",
                //    RutCompany = "60803000-K",
                //    File = "ENVFIN_100_sign.xml",
                //    Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                //    Status = 0,
                //    TrackId = 39
                //  };
                return Result<DTEResponseReception>.Success(parsed);

            } catch (Exception ex) {
                return Result<DTEResponseReception>.Failure($"Excepción al enviar XML: {ex.Message}");
            }
        }
    }
}
