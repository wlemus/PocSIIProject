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
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;

namespace PocSII.DteProcessor.Services {
    public static class ElectronicStampService {
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
 

public static string SignXmlFile(string xmlString,  RSA Key, byte[] Certificate) {
            // --------- FIRMADO X509 ----------------
            string xmlStringSigned;
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = false; // Ignora los espacios si quieres formatear
            doc.LoadXml(xmlString);
            SignedXml signedXml = new SignedXml(doc);  // creo el objto del documento como firmado?
            signedXml.SigningKey = Key;        // a este documento firmado le agrego la llave
            Reference reference = new Reference();      // creo una referencia para firmar
            reference.Uri = "";
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();  // Creo En sobre para el XML -> env
            reference.AddTransform(env);            //a esta referencia le agrego una transformación de tipo envelope
            signedXml.AddReference(reference);      // y ahora esta referencia se la asigno al documento firmado

            KeyInfo keyInfo = new KeyInfo();        // Ahora tengo que crear un objeto para firmar

            keyInfo.AddClause(new RSAKeyValue((RSA)Key)); //agrego la firma RSA

          //  X509Certificate MSCert = X509Certificate.CreateFromCertFile(Certificate);   // Descargamos el certificado
            X509Certificate2 MSCert = new X509Certificate2(Certificate);

            keyInfo.AddClause(new KeyInfoX509Data(MSCert));


            signedXml.KeyInfo = keyInfo;
            signedXml.ComputeSignature();
            XmlElement xmlDigitalSignatureRSA = signedXml.GetXml(); //elemento con la firma RSA y X509


            // Agrego al documento un hijo con las llaves
            doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignatureRSA, true));

           
            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = new XmlTextWriter(stringWriter)) {
                xmlTextWriter.Formatting = Formatting.Indented; // Opcional: para hacerlo más legible
                doc.WriteTo(xmlTextWriter);
                 xmlStringSigned = stringWriter.ToString();

            }
            return xmlStringSigned;
            //guardo el documento
            //XmlTextWriter xmltw = new XmlTextWriter(SignedFileName, new UTF8Encoding(false));
            //doc.WriteTo(xmltw);
            //xmltw.Close();
        }
    }
}