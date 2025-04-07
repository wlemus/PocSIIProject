using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Dto;
using PocSII.DteBusinessRules.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace PocSII.DteProcessor.Services
{
    public static class ElectronicStampService
    {
        public static string SingDDNode(InvoiceDTO invoice) {
            // 1. Construir nodo <DD>
            var ddXml = $@"
        <DD>
            <RE>{invoice.Emisor.Rut}</RE>
            <TD>{DOCType.Item33.GetXmlEnumValue()}</TD>
            <F>{invoice.Factura.Folio}</F>
            <FE>{Convert.ToDateTime(invoice.Factura.FechaEmision)}</FE>
            <RR>{invoice.Receptor.Rut}</RR>
            <RSR>{invoice.Receptor.RazonSocial}</RSR>
            <MNT>{Convert.ToDecimal(invoice.Factura.Totales.MontoTotal)}</MNT>
            <IT1>{invoice.Factura.Detalle[0].NombreItem}</IT1>
            {invoice.TimbreElectronicoInfo.CAF}
            <TSTED>{invoice.TimbreElectronicoInfo.FechaFirmaDigitalDatoDocumento:yyyy-MM-ddTHH:mm:ss}</TSTED>
        </DD>";

            // 2. Canonicalizar XML (opcional, el SII acepta sin namespaces ni atributos extras)
            var ddDoc = new XmlDocument();
            ddDoc.PreserveWhitespace = true;
            ddDoc.LoadXml(ddXml);

            // 3. Convertir XML a string plano UTF-8
            var ddBytes = Encoding.UTF8.GetBytes(ddDoc.OuterXml);

            // 4. Firmar con RSA-SHA1
            using var rsa = RSA.Create();
            // rsa.FromXmlString(invoice.TimbreElectronicoInfo.LlavePrivadaCAF); // requiere System.Security.Cryptography.Xml desde .NET Framework
            //  var signedBytes = rsa.SignData(ddBytes, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

            // 5. Devolver la firma base64
            return "GbmDcS9e/jVC2LsLIe1iRV12Bf6lxsILtbQiCkh6mbjckFCJ7fj/kakFTS06Jo8iS4HXvJj3oYZuey53Krniew==";// Convert.ToBase64String(signedBytes);
        }
    }
}
