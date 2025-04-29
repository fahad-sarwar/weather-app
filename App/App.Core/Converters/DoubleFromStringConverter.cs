using System.Text.Json;
using System.Text.Json.Serialization;

namespace App.Core.Converters
{
    public class DoubleFromStringConverter : JsonConverter<double>
    {
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String &&
                double.TryParse(reader.GetString(), out var value))
            {
                return value;
            }

            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDouble();
            }

            throw new JsonException($"Unable to convert to double from token type {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
