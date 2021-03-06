// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    using System.Reflection;

    /// <summary>
    /// Defines values for EncryptedConnection.
    /// </summary>
    public sealed class EncryptedConnectionConverter : JsonConverter
    {

        /// <summary>
        /// Returns if objectType can be converted to EncryptedConnection by
        /// the converter.
        /// </summary>
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(EncryptedConnection).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        /// <summary>
        /// Overrides ReadJson and converts token to EncryptedConnection.
        /// </summary>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
            {
                return null;
            }
            return (EncryptedConnection)serializer.Deserialize<string>(reader);
        }

        /// <summary>
        /// Overriding WriteJson for EncryptedConnection for serialization.
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

    }
}
