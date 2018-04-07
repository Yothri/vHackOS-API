using System;
using Newtonsoft.Json;

namespace vHackOS.Converters
{
    public class StringToBoolConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value;

            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return false;

            if (value.Equals("1"))
                return true;

            return false;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}