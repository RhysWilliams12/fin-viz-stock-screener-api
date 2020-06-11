using System.Reflection;
using StockScreenerApi.Logic;
using StockScreenerApi.Models;

namespace StockScreenerApi.UnitTest
{
    class UnitTestHelper
    {

        private static readonly FinVizItem FirstFinVizItem = new FinVizItem()
        {
            Id = "TSLA",
            AverageTrueRange = "38.75",
            AverageVolume = "16.45M",
            Beta = "1.17",
            BookPerShare = "50.13",
            CashPerShare = "44.66",
            Change = "-0.97%",
            CurrentRatio = "1.20",
            DebtToEquity = "1.52",
            Dividend = "-",
            DividendRatio = "-",
            EarningsDate = "Apr 29 AMC",
            EarningsPerShare = "-0.87",
            EarningsPerShareHistory = "-15.60%",
            EarningsPerShareLongTerm = "-",
            EarningsPerShareNextQuarter = "-1.45",
            EarningsPerShareNextYear = "11.50",
            EarningsPerShareThisYear = "14.90%",
            Employees = "48016",
            GrossMargin = "18.20%",
            HalfYearPerformance = "180.05%",
            Income = "-144.30M",
            Index = "-",
            InsiderOwnership = "20.51%",
            InsiderTransfers = "-5.41%",
            InstitutionalOwnership = "50.80%",
            InstitutionalTransactions = "-0.24%",
            MarketCapitalization = "170.19B",
            MonthPerformance = "14.80%",
            OperatingMargin = "2.80%",
            Optionable = "Yes",
            PriceEarningsForward = "81.80",
            Payout = "-",
            PreviousClose = "949.92",
            Price = "940.67",
            PriceEarningsGrowth = "-",
            PriceEarningsRatio = "-",
            PriceToBook = "18.76",
            PriceToCashPerShare = "21.06",
            PriceToFreeCashFlow = "68.10",
            PriceToSales = "6.54",
            ProfitMargin = "-0.60%",
            QuarterPerformance = "45.77%",
            QuarterlyEarningsGrowth = "102.00%",
            QuarterlyRevenueGrowth = "31.80%",
            QuickRatio = "0.90",
            Recommendation = "3.10",
            RelativeStrengthIndex = "71.27",
            RelativeVolume = "0.68",
            ReturnOnAssets = "-0.40%",
            ReturnOnEquity = "-2.10%",
            ReturnOnInvestment = "-0.90%",
            ShortInterestRate = "11.03%",
            Sales = "26.02B",
            SalesHistory = "50.40%",
            SharesFloat = "147.35M",
            SharesOutstanding = "183.00M",
            ShortInterestRatio = "0.99",
            Shortable = "Yes",
            Sma20 = "12.40%",
            Sma200 = "86.39%",
            Sma50 = "27.71%",
            TargetPrice = "626.30",
            Volatility = "3.30% 3.82%",
            Volume = "11,388,154",
            WeekPerformance = "6.71%",
            YearHigh = "-2.92%",
            YearLow = "353.31%",
            YearPerformance = "341.88%",
            YearRange = "207.51 - 968.99",
            YearToDatePerformance = "124.86%"
        };

        private static readonly FinVizItem SecondFinVizItem = new FinVizItem()
        {
            Id = "AAPL",
            AverageTrueRange = "38.75",
            AverageVolume = "16.45M",
            Beta = "1.17",
            BookPerShare = "50.13",
            CashPerShare = "44.66",
            Change = "-0.97%",
            CurrentRatio = "1.20",
            DebtToEquity = "1.52",
            Dividend = "-",
            DividendRatio = "-",
            EarningsDate = "Apr 29 AMC",
            EarningsPerShare = "-0.87",
            EarningsPerShareHistory = "-15.60%",
            EarningsPerShareLongTerm = "-",
            EarningsPerShareNextQuarter = "-1.45",
            EarningsPerShareNextYear = "11.50",
            EarningsPerShareThisYear = "14.90%",
            Employees = "48016",
            GrossMargin = "18.20%",
            HalfYearPerformance = "180.05%",
            Income = "-144.30M",
            Index = "-",
            InsiderOwnership = "20.51%",
            InsiderTransfers = "-5.41%",
            InstitutionalOwnership = "50.80%",
            InstitutionalTransactions = "-0.24%",
            MarketCapitalization = "170.19B",
            MonthPerformance = "14.80%",
            OperatingMargin = "2.80%",
            Optionable = "Yes",
            PriceEarningsForward = "81.80",
            Payout = "-",
            PreviousClose = "949.92",
            Price = "940.67",
            PriceEarningsGrowth = "-",
            PriceEarningsRatio = "-",
            PriceToBook = "18.76",
            PriceToCashPerShare = "21.06",
            PriceToFreeCashFlow = "68.10",
            PriceToSales = "6.54",
            ProfitMargin = "-0.60%",
            QuarterPerformance = "45.77%",
            QuarterlyEarningsGrowth = "102.00%",
            QuarterlyRevenueGrowth = "31.80%",
            QuickRatio = "0.90",
            Recommendation = "3.10",
            RelativeStrengthIndex = "71.27",
            RelativeVolume = "0.68",
            ReturnOnAssets = "-0.40%",
            ReturnOnEquity = "-2.10%",
            ReturnOnInvestment = "-0.90%",
            ShortInterestRate = "11.03%",
            Sales = "26.02B",
            SalesHistory = "50.40%",
            SharesFloat = "147.35M",
            SharesOutstanding = "183.00M",
            ShortInterestRatio = "0.99",
            Shortable = "Yes",
            Sma20 = "12.40%",
            Sma200 = "86.39%",
            Sma50 = "27.71%",
            TargetPrice = "626.30",
            Volatility = "3.30% 3.82%",
            Volume = "11,388,154",
            WeekPerformance = "6.71%",
            YearHigh = "-2.92%",
            YearLow = "353.31%",
            YearPerformance = "341.88%",
            YearRange = "207.51 - 968.99",
            YearToDatePerformance = "124.86%"
        };

        public static StockScreener GenerateScreener()
        {
            return new StockScreener("TSLA");
        }

        public static JsonStringBuilder GenerateJsonStringBuilder()
        {
            return new JsonStringBuilder();
        }

        public static PropertyInfo[] GetFinVizProperties(string symbol)
        {
            return GetFinVizItem(symbol).GetType().GetProperties();
        }

        public static FinVizItem GetFinVizItem(string symbol)
        {
            switch (symbol)
            {
                case "TSLA":
                    return FirstFinVizItem;
                case "AAPL":
                    return SecondFinVizItem;
                default:
                    return null;
            }
        }
    }
}
