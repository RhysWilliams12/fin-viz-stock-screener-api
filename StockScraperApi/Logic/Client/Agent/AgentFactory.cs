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
using StockScreenerApi.Logic.Client.Agent.Types;
using StockScreenerApi.Logic.Client.System;

namespace StockScreenerApi.Logic.Client.Agent
{
    public class AgentFactory
    {
        public Agent CreateAgent(AgentType agentType, SystemType systemType)
        {
            return agentType switch
            {
                AgentType.Chrome => new Chrome(systemType),
                AgentType.Firefox => new Firefox(systemType),
                AgentType.Safari => new Safari(systemType),
                _ => throw new ArgumentOutOfRangeException(nameof(agentType), agentType, null)
            };
        }
    }
}
