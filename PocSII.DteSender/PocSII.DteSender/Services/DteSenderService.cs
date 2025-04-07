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

        public async Task<Result<DTEResponseReception>> SendDteXmlAsync(string xmlContent, string endpointUrl) {
            try {
                //var content = new StringContent(xmlContent, Encoding.GetEncoding("ISO-8859-1"), "application/xml");

                //var response = await _httpClient.PostAsync(endpointUrl, content);

                //if (!response.IsSuccessStatusCode) {
                //    var error = await response.Content.ReadAsStringAsync();
                //    return Result<string>.Failure($"Error al enviar XML. Código: {response.StatusCode}, Detalle: {error}");
                //}

                //  var result = await response.Content.ReadAsStringAsync();

                //serializer = new XmlSerializer(typeof(RecepcionDTE));
                //using var reader = new StringReader(xmlString);
                //var result = (RecepcionDTE)serializer.Deserialize(reader);
                var result = new DTEResponseReception {
                    RutSender = "97975000-5",
                    RutCompany = "60803000-K",
                    File = "ENVFIN_100_sign.xml",
                    Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Status = 0,
                    TrackId = 39
                  };
                return Result<DTEResponseReception>.Success(result);

            } catch (Exception ex) {
                return Result<DTEResponseReception>.Failure($"Excepción al enviar XML: {ex.Message}");
            }
        }
    }
}
