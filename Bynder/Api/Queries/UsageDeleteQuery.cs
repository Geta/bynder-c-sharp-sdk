// Copyright (c) Bynder. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

using System;

namespace Bynder.Api.Queries
{
    public class UsageDeleteQuery
    {
        public UsageDeleteQuery(string integrationId, string assetId)
        {
            IntegrationId = integrationId;
            AssetId = assetId;
        }

        [APIField("integration_id")]
        public string IntegrationId { get; }

        [APIField("asset_id")]
        public string AssetId { get; }

        [APIField("uri")]
        public Uri Uri { get; set; }
    }
}
