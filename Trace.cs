using Newtonsoft.Json;

namespace DfuseGraphQl
{
    public partial class Trace
    {
        [JsonProperty("matchingActions")]
        public MatchingAction[] MatchingActions { get; set; }
    }

}
