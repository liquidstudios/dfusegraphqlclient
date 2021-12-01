using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class Payload
    {
        [JsonProperty("data")]
        public PayloadData Data { get; set; }
    }

}
