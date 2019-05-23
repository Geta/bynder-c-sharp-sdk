// Copyright (c) Bynder. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

using System;

namespace Bynder.Api.Queries
{
    public class UsageCreateQuery
    {
        public UsageCreateQuery(string integrationId, string assetId)
        {
            IntegrationId = integrationId;
            AssetId = assetId;
        }

        [APIField("integration_id")]
        public string IntegrationId { get; set; }

        [APIField("asset_id")]
        public string AssetId { get; set; }

        [APIField("timestamp")]
        public DateTime Timestamp { get; set; }

        [APIField("uri")]
        public string Uri { get; set; }

        [APIField("additional")]
        public string Additional { get; set; }
    }
}
