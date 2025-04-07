using System.Reflection;
using System.Xml.Serialization;


namespace PocSII.DteBusinessRules.Common {
    public static class EnumExtensions {
        public static string GetXmlEnumValue<T>(this T enumValue) where T : Enum {
            var type = typeof(T);
            var name = Enum.GetName(type, enumValue);
            if (name == null) return null;

            var field = type.GetField(name);
            var attr = field.GetCustomAttribute<XmlEnumAttribute>();
            return attr?.Name ?? name;
        }

    }

}