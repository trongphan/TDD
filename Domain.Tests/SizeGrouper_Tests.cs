using System.Collections.Generic;
using Xunit;

namespace Domain.Tests
{
    public class SizeGrouper_Tests
    {
        [Fact]
        public void ListOf4Site_SizeGrouperIs2_ShouldGroupInto2Groups()
        {
            List<Site> sites = CreateSiteListOfSize(4);
            var sizeGrouper = new SizeGrouper(2);

            var groupedSites = sizeGrouper.Group(sites);

            Assert.Equal(2, groupedSites.Count);            
        }

        [Fact]
        public void ListOf5Site_SizeGrouperIs2_ShouldGroupInto3Groups()
        {
            List<Site> sites = CreateSiteListOfSize(5);
            var sizeGrouper = new SizeGrouper(2);

            var groupedSites = sizeGrouper.Group(sites);

            Assert.Equal(3, groupedSites.Count);
        }

        private static List<Site> CreateSiteListOfSize(int size)
        {
            var results = new List<Site>();
            for (int i = 0; i < size; i++)
            {
                results.Add(Site.Create($"Site {i + 1}"));
            }

            return results;
        }
    }
}
