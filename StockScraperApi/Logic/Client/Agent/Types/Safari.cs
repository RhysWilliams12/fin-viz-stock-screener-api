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
    class Safari : Agent
    {
        public Safari(SystemType systemType) : base(systemType, new []{ "AppleWebKit/603.1.30","(KHTML, like Gecko)","Version/10.0","Mobile/14E304","Safari/602.1" })
        {
        }
    }
}
