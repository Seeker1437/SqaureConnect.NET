using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SquareConnect.Util
{
    public static class Extensions
    {
        /// <exception cref="ArgumentException">EnumerationValue must be be type 'Enum'</exception>
        public static string GetDescription<T>(this T enumerationValue) where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be be type 'Enum'", nameof(enumerationValue));
            }

            var enumerationValueString = enumerationValue.ToString();

            MemberInfo[] memberInfos = type.GetMember(enumerationValueString);
            if (memberInfos.Length > 0)
            {
                object[] attributes = memberInfos[0].GetCustomAttributes(typeof(DisplayAttribute), false);

                if (attributes.Length > 0)
                {
                    return ((DisplayAttribute)attributes[0]).Description;
                }
            }

            return enumerationValueString;

        }
    }
}
