using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnect.Util
{
    public class CustomDateTimeConverter : DateTimeConverterBase
    {
        public CultureInfo CultureInfo { get; set; }
        public string DateTimeFormat { get; set; }

        public CustomDateTimeConverter()
        {
            CultureInfo = CultureInfo.GetCultureInfo("en-US");
            DateTimeFormat = "yyyy-MM-dd HH:mm:ss UTC";
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return DateTime.ParseExact(reader.Value.ToString(), DateTimeFormat, CultureInfo.CurrentCulture);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString(DateTimeFormat, CultureInfo));
        }
    }
}
