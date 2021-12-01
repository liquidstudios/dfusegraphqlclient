using Newtonsoft.Json;

public partial class DfuseGraphQlClient
{
    public class GraphQlQuery
    {
        [JsonProperty("query")]
        public string Query;
    }
}