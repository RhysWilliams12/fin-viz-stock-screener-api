using Microsoft.EntityFrameworkCore;
using StockScreenerApi.Models;

namespace StockScreenerApi.UnitTest.ControllerTests
{
    public abstract class ItemsControllerTest
    {
        protected DbContextOptions<FinVizContext> ContextOptions;

        protected ItemsControllerTest(DbContextOptions<FinVizContext> contextOptions)
        {
            ContextOptions = contextOptions;

            Seed();
        }

        private void Seed()
        {
            using var context = new FinVizContext(ContextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var one = UnitTestHelper.GetFinVizItem("TSLA");

            var two = UnitTestHelper.GetFinVizItem("AAPL");

            context.AddRange(one, two);

            context.SaveChanges();
        }
    }
}
