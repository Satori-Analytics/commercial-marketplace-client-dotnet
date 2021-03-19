// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Marketplace.Metering.Models
{
    public partial class UsageEventConflictResponse
    {
        internal static UsageEventConflictResponse DeserializeUsageEventConflictResponse(JsonElement element)
        {
            Optional<UsageEventConflictResponseAdditionalInfo> additionalInfo = default;
            Optional<string> message = default;
            Optional<string> code = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalInfo = UsageEventConflictResponseAdditionalInfo.DeserializeUsageEventConflictResponseAdditionalInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
            }
            return new UsageEventConflictResponse(additionalInfo.Value, message.Value, code.Value);
        }
    }
}