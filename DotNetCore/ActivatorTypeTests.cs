using System;
using Xunit;

namespace DotNetCore
{
    public sealed class ActivatorTypeTests
    {
        [Fact]
        public void ActivatorNotAbstractDotNetCore()
        {
            var activatorType = typeof(Activator);

            Assert.True(activatorType.IsClass);
            Assert.True(activatorType.IsSealed);
            Assert.True(activatorType.IsAbstract);
        }
    }
}