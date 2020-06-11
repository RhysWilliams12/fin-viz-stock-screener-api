using System.Linq;
using Microsoft.EntityFrameworkCore;
using StockScreenerApi.Controllers;
using StockScreenerApi.Models;
using Xunit;

namespace StockScreenerApi.UnitTest.ControllerTests
{
    public class FinVizItemsControllerTest : ItemsControllerTest
    {
        public FinVizItemsControllerTest()
            : base(
                new DbContextOptionsBuilder<FinVizContext>()
                    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true")
                    .Options)
        {
        }

        [Fact]
        public async void GetFinVizItems_ShouldHaveCorrectNumberOfItems()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var items = await controller.GetFinVizItems();
            var itemList = items.Value.ToList();
            Assert.Equal(2, itemList.Count);
        }

        [Fact]
        public async void GetFinVizItems_ShouldReturnAllItems()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var items = await controller.GetFinVizItems();
            var itemList = items.Value.ToList();

            Assert.Contains(itemList, (item) => "TSLA" == item.Id);
            Assert.Contains(itemList, (item) => "AAPL" == item.Id);
        }

        [Fact]
        public async void GetFinVizItem_ItemNotFound()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var item = await controller.GetFinVizItem("AMZN");

            Assert.Equal("AMZN", item.Value.Id);
        }

        [Fact]
        public async void GetFinVizItem_ShouldReturnSelectedItem()
        {

            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);


            var item = await controller.GetFinVizItem("TSLA");
            var properties = UnitTestHelper.GetFinVizProperties("TSLA");
            var stockScreener = new StockScreenerApi.Logic.StockScreener("TSLA");
            var expectedObject = stockScreener.ScrapeWeb();

            Assert.All(properties,(prop)=>Assert.Equal(prop.GetValue(expectedObject),prop.GetValue(item.Value)));
        }

        [Fact]
        public async void PutFinVizItem_ShouldUpdateItem()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var mockItem = UnitTestHelper.GetFinVizItem(("TSLA"));
            var item = await controller.PutFinVizItem("TSLA",mockItem);
            Assert.Equal("Microsoft.AspNetCore.Mvc.NoContentResult", item.ToString());
        }

        [Fact]
        public async void PutFinVizItem_ShouldNotUpdateMismatchIds()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var mockItem = UnitTestHelper.GetFinVizItem(("TSLA"));
            var item = await controller.PutFinVizItem("MSFT", mockItem);
            Assert.Equal("Microsoft.AspNetCore.Mvc.BadRequestResult", item.ToString());
        }

        [Fact]
        public async void PutFinVizItem_ShouldNotUpdateItemNotFound()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var item = await controller.PutFinVizItem("MSFT", new FinVizItem(){Id="MSFT"});
            Assert.Equal("Microsoft.AspNetCore.Mvc.NotFoundResult", item.ToString());
        }

        [Fact]
        public async void PostFinVizItem_ShouldCreateItem()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var stockScreener = new StockScreenerApi.Logic.StockScreener("MSFT");
            var expectedObject = stockScreener.ScrapeWeb();

            var item = await controller.PostFinVizItem(expectedObject);
            Assert.Equal("Microsoft.AspNetCore.Mvc.CreatedAtActionResult", item.Result.ToString());
        }

        [Fact]
        public async void PostFinVizItem_NotCreateItemConflict()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var item = await controller.PostFinVizItem(new FinVizItem() { Id = "TSLA" });
            Assert.Equal("Microsoft.AspNetCore.Mvc.ConflictResult", item.Result.ToString());
        }

        [Fact]
        public async void DeleteFinVizItem_ShouldDeleteItem()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var expectedItem = UnitTestHelper.GetFinVizItem("AAPL");

            var item = await controller.DeleteFinVizItem("AAPL");
            Assert.Equal(expectedItem.Id, item.Value.Id);
        }

        [Fact]
        public async void DeleteFinVizItem_NoDeleteItemNotFound()
        {
            await using var context = new FinVizContext(ContextOptions);
            var controller = new FinVizItemsController(context);

            var item = await controller.DeleteFinVizItem("AMZN");
            Assert.Equal("Microsoft.AspNetCore.Mvc.NotFoundResult", item.Result.ToString());
        }

    }
}
