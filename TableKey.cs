using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class TableKey
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("table")]
        public string Table { get; set; }
    }

}
