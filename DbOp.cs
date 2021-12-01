using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class DbOp
    {
        [JsonProperty("oldJSON")]
        public OldJson OldJson { get; set; }

        [JsonProperty("newJSON")]
        public NewJson NewJson { get; set; }

        [JsonProperty("key")]
        public TableKey Key { get; set; }
    }

}
