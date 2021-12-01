using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class Authorization
    {
        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }
    }

}
