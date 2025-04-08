using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;


namespace PocSII.DteProcessor.Common {
    public  class Utils
    {
        public static  byte[] GetEmbeddedResourceBytes(string fileName) {
            string resourceContent = string.Empty;
                       
                // Obtiene el assembly actual
                Assembly assembly = Assembly.GetCallingAssembly();
                string resourceName = $"{assembly.GetName().Name}.Resources.{fileName}";

                using (Stream? stream = assembly.GetManifestResourceStream(resourceName)) {
                    if (stream == null)
                        throw new FileNotFoundException($"El archivo {fileName} no se encontró en los recursos embebidos.");

                    using (MemoryStream memoryStream = new MemoryStream()) {
                        stream.CopyTo(memoryStream);
                        return memoryStream.ToArray();
                    }
                
            }
        }
     
    }


}
