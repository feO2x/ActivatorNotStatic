using System;
using Xunit;

namespace DotNet
{
    public sealed class ActivatorTypeTests
    {
        [Fact]
        public void ActivatorNotAbstractDotNet()
        {
            var activatorType = typeof(Activator);

            Assert.True(activatorType.IsClass);
            Assert.True(activatorType.IsSealed);
            Assert.True(activatorType.IsAbstract);
        }
    }
}