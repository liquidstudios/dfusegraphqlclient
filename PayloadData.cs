using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class PayloadData
    {
        [JsonProperty("searchTransactionsForward")]
        public SearchTransactionsForward SearchTransactionsForward { get; set; }
        
        [JsonProperty("searchTransactionsBackward")]
        public SearchTransactionsForward SearchTransactionsBackward { get; set; }
    }

}
