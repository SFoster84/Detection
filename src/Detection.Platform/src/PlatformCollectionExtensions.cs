// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class PlatformCollectionExtensions
    {
        public static IDetectionCoreBuilder AddPlatform(
            this IDetectionCoreBuilder builder)
        {
            builder.Services.AddTransient<IPlatformResolver, PlatformResolver>();

            return builder;
        }
    }
}
