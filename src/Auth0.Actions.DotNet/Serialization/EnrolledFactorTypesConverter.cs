using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.Serialization
{

    /// <summary>
    /// Custom JSON converter for <see cref="EnrolledFactorTypes"/> that falls back to
    /// <see cref="EnrolledFactorTypes.Unknown"/> for unrecognized values and logs a trace warning.
    /// </summary>
    public sealed class EnrolledFactorTypesConverter : JsonConverter<EnrolledFactorTypes>
    {

        #region Fields

        private static readonly JsonStringEnumConverter<EnrolledFactorTypes> InnerConverter = new();
        private static readonly JsonSerializerOptions ConverterOptions = CreateConverterOptions();

        #endregion

        #region Public Methods

        /// <inheritdoc />
        public override EnrolledFactorTypes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var value = reader.GetString();
                try
                {
                    var readerCopy = reader;
                    return JsonSerializer.Deserialize<EnrolledFactorTypes>(ref readerCopy, ConverterOptions);
                }
                catch (JsonException)
                {
                    Trace.TraceWarning("Auth0.Actions: Unrecognized EnrolledFactorType value '{0}'. Falling back to Unknown. Consider updating the Auth0.Actions package.", value);
                    return EnrolledFactorTypes.Unknown;
                }
            }

            throw new JsonException($"Unexpected token type '{reader.TokenType}' when reading EnrolledFactorTypes.");
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, EnrolledFactorTypes value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, ConverterOptions);
        }

        #endregion

        #region Private Methods

        private static JsonSerializerOptions CreateConverterOptions()
        {
            var opts = new JsonSerializerOptions();
            opts.Converters.Add(InnerConverter);
            return opts;
        }

        #endregion

    }

}
