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

using System;
using HtmlAgilityPack;
using Newtonsoft.Json;
using StockScreenerApi.Logic.Client.Agent;
using StockScreenerApi.Logic.Client.System;
using StockScreenerApi.Models;

namespace StockScreenerApi.Logic
{
    public class DataReceivedNotWellFormedException : Exception
    {
        public DataReceivedNotWellFormedException(string message) : base(message)
        {
        }
    }
    public class StockScreener
    {
        private const string DefaultUrl = "https://finviz.com/quote.ashx?t=";
        private const string DataTagXpath = "//*/table[@class=\"snapshot-table2\"]/tr/td[@class=\"snapshot-td2-cp\"]";
        private const string DataValueXpath = "//*/table[@class=\"snapshot-table2\"]/tr/td[@class=\"snapshot-td2\"]";

        private readonly string _symbol;
        private readonly JsonStringBuilder _jsonBuilder;

        private FinVizItem _finVizData;
        private HtmlNodeCollection _tags;
        private HtmlNodeCollection _values;

        public StockScreener(string symbol)
        {
            _symbol = symbol;
            _jsonBuilder = new JsonStringBuilder();
            _jsonBuilder.AppendToJsonString("Id",symbol);
        }
        
        public FinVizItem ScrapeWeb()
        {
            ReadTable();
            ReadRows();
            return _finVizData;
        }

        private void ReadTable()
        {
            var url = $"{DefaultUrl}{_symbol}";
            var web = new HtmlWeb
            {
                UserAgent = GenerateAgent()
            };

            // TODO: wait between requests
            var htmlDoc = web.Load(url);

            _tags = htmlDoc.DocumentNode.SelectNodes(DataTagXpath);
            _values = htmlDoc.DocumentNode.SelectNodes(DataValueXpath);
        }

        private string GenerateAgent()
        {
            var randAgent = GenerateRandomNumber(2);
            var randSystem = GenerateRandomNumber(3);

            var agentFactory = new AgentFactory();
            return agentFactory.CreateAgent((AgentType)randAgent, (SystemType)randSystem).ToString();
        }

        private int GenerateRandomNumber(int max)
        {
            var random = new Random();
            return random.Next(0, max);
        }

        private void ReadRows()
        {
            for (var i = 0; i < _values.Count; i++)
            {
                _jsonBuilder.AppendToJsonString(_tags[i].InnerText,_values[i].FirstChild.InnerText);
            }
            
            DeserializeJsonString();
        }

        private void DeserializeJsonString()
        {
            var jsonString = _jsonBuilder.GetJsonString();
            _finVizData = JsonConvert.DeserializeObject(jsonString,typeof(FinVizItem)) as FinVizItem;
        }

    }
}
