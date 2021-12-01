using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DfuseGraphQl
{
    public partial class DfuseGraphQlResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
