using System;
using Xunit;

namespace Domain.Tests
{
    public class Site_Tests
    {
        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenNamesIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => { Site.Create(null); });
        }
    }
}
