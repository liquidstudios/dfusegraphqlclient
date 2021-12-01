using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class MatchingAction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("authorization")]
        public Authorization[] Authorization { get; set; }

        [JsonProperty("dbOps")]
        public DbOp[] DbOps { get; set; }

        [JsonProperty("json")]
        public object Json { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }
    }

}
