using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class NewJson
    {
        [JsonProperty("object")]
        public object Object { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }

}
