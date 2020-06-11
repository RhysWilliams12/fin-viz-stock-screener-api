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

using StockScreenerApi.Logic.Client.System;

namespace StockScreenerApi.Logic.Client.Agent.Types
{
    internal class Chrome: Agent
    {
        public Chrome(SystemType systemType) : base(systemType,new[]{"AppleWebKit/537.36","(KHTML, like Gecko)","Chrome/83.0.4103.97","Safari/537.36"})
        {
        }
    }
}
