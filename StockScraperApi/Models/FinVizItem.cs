//StockScreenerApi - An API that searches for a stock data from the web
//Copyright(C) 2020  Rhys Williams

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.If not, see<https://www.gnu.org/licenses/>.

using Newtonsoft.Json;

namespace StockScreenerApi.Models
{
    public class FinVizItem
    {
        public string Id { get; set; }

        [JsonProperty("ATR")]
        public string AverageTrueRange { get; set; }

        [JsonProperty("Avg Volume")]
        public string AverageVolume { get; set; }

        [JsonProperty("Beta")]
        public string Beta { get; set; }

        [JsonProperty("Book/sh")]
        public string BookPerShare { get; set; }

        [JsonProperty("Cash/sh")]
        public string CashPerShare { get; set; }

        [JsonProperty("Change")]
        public string Change { get; set; }

        [JsonProperty("Current Ratio")]
        public string CurrentRatio { get; set; }

        [JsonProperty("Debt/Eq")]
        public string DebtToEquity { get; set; }

        [JsonProperty("Dividend")]
        public string Dividend { get; set; }

        [JsonProperty("Dividend %")]
        public string DividendRatio { get; set; }

        [JsonProperty("Earnings")]
        public string EarningsDate { get; set; }

        [JsonProperty("EPS (ttm)")]
        public string EarningsPerShare { get; set; }

        [JsonProperty("EPS next Y")]
        public string EarningsPerShareNextYear { get; set; }

        [JsonProperty("EPS next Q")]
        public string EarningsPerShareNextQuarter { get; set; }

        [JsonProperty("EPS next 5Y")]
        public string EarningsPerShareLongTerm { get; set; }

        [JsonProperty("EPS past 5Y")]
        public string EarningsPerShareHistory { get; set; }

        [JsonProperty("EPS this Y")]
        public string EarningsPerShareThisYear { get; set; }

        [JsonProperty("Employees")]
        public string Employees { get; set; }

        [JsonProperty("Gross Margin")]
        public string GrossMargin { get; set; }

        [JsonProperty("Perf Half Y")]
        public string HalfYearPerformance { get; set; }

        [JsonProperty("Income")]
        public string Income { get; set; }

        [JsonProperty("Index")]
        public string Index { get; set; }

        [JsonProperty("Insider Own")]
        public string InsiderOwnership { get; set; }

        [JsonProperty("Insider Trans")]
        public string InsiderTransfers { get; set; }

        [JsonProperty("Inst Own")]
        public string InstitutionalOwnership { get; set; }

        [JsonProperty("Inst Trans")]
        public string InstitutionalTransactions { get; set; }

        [JsonProperty("Market Cap")]
        public string MarketCapitalization { get; set; }

        [JsonProperty("Perf Month")]
        public string MonthPerformance { get; set; }

        [JsonProperty("Oper. Margin")]
        public string OperatingMargin { get; set; }

        [JsonProperty("Optionable")]
        public string Optionable { get; set; }

        [JsonProperty("Payout")]
        public string Payout { get; set; }

        [JsonProperty("Price")]
        public string Price { get; set; }

        [JsonProperty("Prev Close")]
        public string PreviousClose { get; set; }

        [JsonProperty("P/B")]
        public string PriceToBook { get; set; }

        [JsonProperty("Forward P/E")]
        public string PriceEarningsForward { get; set; }

        [JsonProperty("P/E")]
        public string PriceEarningsRatio { get; set; }

        [JsonProperty("PEG")]
        public string PriceEarningsGrowth { get; set; }

        [JsonProperty("P/S")]
        public string PriceToSales { get; set; }

        [JsonProperty("P/C")]
        public string PriceToCashPerShare { get; set; }

        [JsonProperty("P/FCF")]
        public string PriceToFreeCashFlow { get; set; }

        [JsonProperty("Profit Margin")]
        public string ProfitMargin { get; set; }

        [JsonProperty("Perf Quarter")]
        public string QuarterPerformance { get; set; }

        [JsonProperty("EPS Q/Q")]
        public string QuarterlyEarningsGrowth { get; set; }

        [JsonProperty("Sales Q/Q")]
        public string QuarterlyRevenueGrowth { get; set; }

        [JsonProperty("Quick Ratio")]
        public string QuickRatio { get; set; }

        [JsonProperty("Recom")]
        public string Recommendation { get; set; }

        [JsonProperty("RSI (14)")]
        public string RelativeStrengthIndex { get; set; }

        [JsonProperty("Rel Volume")]
        public string RelativeVolume { get; set; }

        [JsonProperty("ROA")]
        public string ReturnOnAssets { get; set; }

        [JsonProperty("ROE")]
        public string ReturnOnEquity { get; set; }

        [JsonProperty("ROI")]
        public string ReturnOnInvestment { get; set; }

        [JsonProperty("Sales")]
        public string Sales { get; set; }

        [JsonProperty("Sales past 5Y")]
        public string SalesHistory { get; set; }

        [JsonProperty("Shs Outstand")]
        public string SharesOutstanding { get; set; }

        [JsonProperty("Shs Float")]
        public string SharesFloat { get; set; }

        [JsonProperty("Shortable")]
        public string Shortable { get; set; }

        [JsonProperty("Short Float")]
        public string ShortInterestRate { get; set; }

        [JsonProperty("Short Ratio")]
        public string ShortInterestRatio { get; set; }

        [JsonProperty("SMA20")]
        public string Sma20 { get; set; }

        [JsonProperty("SMA50")]
        public string Sma50 { get; set; }

        [JsonProperty("SMA200")]
        public string Sma200 { get; set; }

        [JsonProperty("Target Price")]
        public string TargetPrice { get; set; }

        [JsonProperty("Volatility")]
        public string Volatility { get; set; }

        [JsonProperty("Volume")]
        public string Volume { get; set; }

        [JsonProperty("Perf Week")]
        public string WeekPerformance { get; set; }

        [JsonProperty("52W High")]
        public string YearHigh { get; set; }

        [JsonProperty("52W Low")]
        public string YearLow { get; set; }

        [JsonProperty("Perf Year")]
        public string YearPerformance { get; set; }

        [JsonProperty("52W Range")]
        public string YearRange { get; set; }

        [JsonProperty("Perf YTD")]
        public string YearToDatePerformance { get; set; }
    }
}
