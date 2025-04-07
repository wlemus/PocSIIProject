using PocSII.DteBusinessRules.Common;
using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace PocSII.DteProcessor.Common
{


    public static class XmlValidator {
        public static Result<bool> ValidateXml(string xmlContent ) {
            bool isValid = true;
            var errors = new StringWriter();
            try {

          
            string xsdPath = Path.Combine(AppContext.BaseDirectory, "XSD", "EnvioDTE_v10.xsd");

                string xsdDTE = Path.Combine(AppContext.BaseDirectory, "XSD", "DTE_v10.xsd");

            //    string xsdPathSignature = Path.Combine(AppContext.BaseDirectory, "XSD", "xmldsignature_v10.xsd");
                string xsdPathSiiTypes = Path.Combine(AppContext.BaseDirectory, "XSD", "SiiTypes_v10.xsd");

                var settings = new XmlReaderSettings();
            var schemas = new XmlSchemaSet();
            schemas.Add(null, xsdPath); 
        //    schemas.Add(null, xsdPathSignature); 
            schemas.Add(null, xsdDTE);
            schemas.Add(null, xsdPathSiiTypes);

                settings.Schemas = schemas;
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

            settings.ValidationEventHandler += (sender, args) =>
            {
                isValid = false;
                errors.WriteLine($"{args.Severity}: {args.Message}");
            };

            using var reader = XmlReader.Create(new StringReader(xmlContent), settings);
            try {
                while (reader.Read()) { }
            } catch (XmlException ex) {
                isValid = false;
                errors.WriteLine($"XmlException: {ex.Message}");
            }

                if (isValid)
                    return Result<bool>.Success(true);
                else
                    throw new Exception(errors.ToString());

            } catch (Exception ex) {

                return Result<bool>.Failure($"La validación del XSD ha fallado: {ex.Message}");
            }
           
        }
    }

}
