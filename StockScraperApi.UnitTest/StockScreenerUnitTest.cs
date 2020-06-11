using StockScreenerApi.Logic;
using Xunit;

namespace StockScreenerApi.UnitTest
{
    public class StockScreenerUnitTest
    {
        [Fact]
        public void ScrapeWeb_ShouldReturnValidFinVizObject()
        {
            var expectedProperties = UnitTestHelper.GetFinVizProperties("TSLA");

            var stockScreener = UnitTestHelper.GenerateScreener();
            var finvizItem = stockScreener.ScrapeWeb();

            Assert.All(expectedProperties,(property)=>Assert.NotNull(finvizItem.GetType().GetProperty(property.Name)));
        }

        [Fact]
        public void DataReceivedNotWellFormedException_ShouldGiveMessage()
        {
            var exception = new DataReceivedNotWellFormedException("expected Message");

            Assert.ThrowsAsync<DataReceivedNotWellFormedException>(() => throw exception);
        }
    }
}
