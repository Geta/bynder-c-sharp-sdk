// Copyright (c) Bynder. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bynder.Models
{
    public class Usage
    {
        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        [JsonProperty("integration")]
        public Dictionary<string, string> Integration { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("additional")]
        public string Additional { get; set; }
    }
}
