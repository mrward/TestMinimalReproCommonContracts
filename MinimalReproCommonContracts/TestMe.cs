using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MinimalReproCommonContracts
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TestMe
    {
        /// <summary>
        /// Unknown.
        /// </summary>
        Unknown = 0,
    }
}