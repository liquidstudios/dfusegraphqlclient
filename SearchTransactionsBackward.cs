using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class SearchTransactionsBackward
    {
        [JsonProperty("undo")]
        public bool Undo { get; set; }

        [JsonProperty("trace")]
        public Trace Trace { get; set; }
    }

}
