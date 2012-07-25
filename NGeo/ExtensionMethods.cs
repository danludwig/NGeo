using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace NGeo
{
    internal static class ExtensionMethods
    {
        internal static EnumMemberAttribute GetEnumMemberAttribute(this Enum value)
        {
            var type = value.GetType();
            // ReSharper disable SpecifyACultureInStringConversionExplicitly
            var fieldInfo = type.GetField(value.ToString());
            // ReSharper restore SpecifyACultureInStringConversionExplicitly
            var attributes = fieldInfo.GetCustomAttributes(
                typeof(EnumMemberAttribute), false) as EnumMemberAttribute[];
            return (attributes != null && attributes.Length > 0) ? attributes[0] : null;
        }

        internal static void ApplyDefaultValues(this object value)
        {
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(value))
            {
                var attr = prop.Attributes[typeof(DefaultValueAttribute)] as DefaultValueAttribute;
                if (attr != null)
                    prop.SetValue(value, attr.Value);
            }
        }

        internal static string ToNullIfEmptyOrWhiteSpace(this string mayBeEmptyOrWhiteSpace)
        {
            return (!string.IsNullOrWhiteSpace(mayBeEmptyOrWhiteSpace)) ? mayBeEmptyOrWhiteSpace : null;
        }

    }
}
