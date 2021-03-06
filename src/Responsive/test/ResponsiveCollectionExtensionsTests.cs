// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace Wangkanai.Responsive.Test
{
    public class ResponsiveCollectionExtensionsTests
    {
        [Fact]
        public void AddResponsive_Services()
        {
            var service = new ServiceCollection();
            var expected = service.Count + 16;
            var builder = service.AddResponsive();

            Assert.Equal(expected, builder.Services.Count);
            Assert.Same(service, builder.Services);
        }

        [Fact]
        public void AddResponsive_Null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(CreateResponsiveNullService);
        }

        [Fact]
        public void AddResponsive_Option_Builder_Service()
        {
            var service = new ServiceCollection();
            var expected = service.Count + 16;
            var builder = service.AddResponsive(options =>
            {
                options.View.DefaultTablet = Detection.Device.Desktop;
            });

            Assert.Equal(expected, builder.Services.Count);
            Assert.Same(service, builder.Services);
        }

        [Fact]
        public void AddResponsive_Options_Null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(CreateResponsiveNullService);
        }

        private Func<object> CreateResponsiveNullService = () => ((IServiceCollection)null).AddResponsive();
    }
}
