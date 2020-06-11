using Xunit;

namespace StockScreenerApi.UnitTest
{
    public class JsonStringBuilderUnitTest
    {
        [Fact]
        public void AppendToJsonString_ShouldAppendJsonProperty()
        {
            var jsonStringBuilder = UnitTestHelper.GenerateJsonStringBuilder();
            jsonStringBuilder.AppendToJsonString("prop1","1");

            Assert.Equal("{\"prop1\":\"1\"}", jsonStringBuilder.GetJsonString());
        }

        [Fact]
        public void AppendToJsonString_ShouldAppendMultipleJsonProperties()
        {
            var jsonStringBuilder = UnitTestHelper.GenerateJsonStringBuilder();
            jsonStringBuilder.AppendToJsonString("prop1","1");
            jsonStringBuilder.AppendToJsonString("prop2","2");

            Assert.Equal("{\"prop1\":\"1\",\n\"prop2\":\"2\"}", jsonStringBuilder.GetJsonString());
        }

        [Fact]
        public void GetJsonString_ShouldNotBeEmpty()
        {
            var jsonStringBuilder = UnitTestHelper.GenerateJsonStringBuilder();
            Assert.NotEqual("", jsonStringBuilder.GetJsonString());
        }

        [Fact]
        public void GetJsonString_SerializeFinVizItem()
        {
            var jsonStringBuilder = UnitTestHelper.GenerateJsonStringBuilder();
            var finVizItem = UnitTestHelper.GetFinVizItem("TSLA");
            var expectedValue = "{\"Id\":\"TSLA\",\n\"AverageTrueRange\":\"38.75\",\n\"AverageVolume\":\"16.45M\",\n\"Beta\":\"1.17\",\n\"BookPerShare\":\"50.13\",\n\"CashPerShare\":\"44.66\",\n\"Change\":\"-0.97%\",\n\"CurrentRatio\":\"1.20\",\n\"DebtToEquity\":\"1.52\",\n\"Dividend\":\"-\",\n\"DividendRatio\":\"-\",\n\"EarningsDate\":\"Apr 29 AMC\",\n\"EarningsPerShare\":\"-0.87\",\n\"EarningsPerShareNextYear\":\"11.50\",\n\"EarningsPerShareNextQuarter\":\"-1.45\",\n\"EarningsPerShareLongTerm\":\"-\",\n\"EarningsPerShareHistory\":\"-15.60%\",\n\"EarningsPerShareThisYear\":\"14.90%\",\n\"Employees\":\"48016\",\n\"GrossMargin\":\"18.20%\",\n\"HalfYearPerformance\":\"180.05%\",\n\"Income\":\"-144.30M\",\n\"Index\":\"-\",\n\"InsiderOwnership\":\"20.51%\",\n\"InsiderTransfers\":\"-5.41%\",\n\"InstitutionalOwnership\":\"50.80%\",\n\"InstitutionalTransactions\":\"-0.24%\",\n\"MarketCapitalization\":\"170.19B\",\n\"MonthPerformance\":\"14.80%\",\n\"OperatingMargin\":\"2.80%\",\n\"Optionable\":\"Yes\",\n\"Payout\":\"-\",\n\"Price\":\"940.67\",\n\"PreviousClose\":\"949.92\",\n\"PriceToBook\":\"18.76\",\n\"PriceEarningsForward\":\"81.80\",\n\"PriceEarningsRatio\":\"-\",\n\"PriceEarningsGrowth\":\"-\",\n\"PriceToSales\":\"6.54\",\n\"PriceToCashPerShare\":\"21.06\",\n\"PriceToFreeCashFlow\":\"68.10\",\n\"ProfitMargin\":\"-0.60%\",\n\"QuarterPerformance\":\"45.77%\",\n\"QuarterlyEarningsGrowth\":\"102.00%\",\n\"QuarterlyRevenueGrowth\":\"31.80%\",\n\"QuickRatio\":\"0.90\",\n\"Recommendation\":\"3.10\",\n\"RelativeStrengthIndex\":\"71.27\",\n\"RelativeVolume\":\"0.68\",\n\"ReturnOnAssets\":\"-0.40%\",\n\"ReturnOnEquity\":\"-2.10%\",\n\"ReturnOnInvestment\":\"-0.90%\",\n\"Sales\":\"26.02B\",\n\"SalesHistory\":\"50.40%\",\n\"SharesOutstanding\":\"183.00M\",\n\"SharesFloat\":\"147.35M\",\n\"Shortable\":\"Yes\",\n\"ShortInterestRate\":\"11.03%\",\n\"ShortInterestRatio\":\"0.99\",\n\"Sma20\":\"12.40%\",\n\"Sma50\":\"27.71%\",\n\"Sma200\":\"86.39%\",\n\"TargetPrice\":\"626.30\",\n\"Volatility\":\"3.30% 3.82%\",\n\"Volume\":\"11,388,154\",\n\"WeekPerformance\":\"6.71%\",\n\"YearHigh\":\"-2.92%\",\n\"YearLow\":\"353.31%\",\n\"YearPerformance\":\"341.88%\",\n\"YearRange\":\"207.51 - 968.99\",\n\"YearToDatePerformance\":\"124.86%\"}";
            
            foreach (var finVizProperty in UnitTestHelper.GetFinVizProperties("TSLA"))
            {
                jsonStringBuilder.AppendToJsonString(finVizProperty.Name,finVizProperty.GetValue(finVizItem)?.ToString());
            }
            var resultString = jsonStringBuilder.GetJsonString();
            Assert.Equal(expectedValue, resultString);
        }
    }
}
