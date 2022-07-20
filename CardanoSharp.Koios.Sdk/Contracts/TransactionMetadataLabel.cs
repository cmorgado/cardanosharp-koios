using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class TransactionMetadataLabel
    {
        [DataMember]
        [JsonPropertyName("metalabel")]
        public string? MetaLabel { get; set; }
    }
}