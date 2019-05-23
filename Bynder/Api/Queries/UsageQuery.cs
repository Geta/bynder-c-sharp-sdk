// Copyright (c) Bynder. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

namespace Bynder.Api.Queries
{
    public class UsageQuery
    {
        public UsageQuery(string assetId)
        {
            AssetId = assetId;
        }

        [APIField("asset_id")]
        public string AssetId { get; }
    }
}
