// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Microsoft.AspNetCore.Http
{
    public static class HttpRequestExtensions
    {
        public static IDeviceFactory Device(this HttpRequest request)
        {
            var service = new UserAgentService(request.HttpContext);
            var resolver = new DeviceResolver(service);
            return resolver.Device;
        }
    }
}
