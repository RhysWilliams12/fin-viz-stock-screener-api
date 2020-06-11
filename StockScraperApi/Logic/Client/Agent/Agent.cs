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

using System.Collections.Generic;
using System.Linq;
using StockScreenerApi.Logic.Client.System;

namespace StockScreenerApi.Logic.Client.Agent
{
    public abstract class Agent
    {
        protected readonly List<string> AgentCommentsList;
        protected readonly SystemDescription SystemDescription;

        protected Agent(SystemType systemType, IEnumerable<string> agentComments, string revision = "")
        {
            AgentCommentsList = agentComments.ToList();
            var systemFactory = new SystemFactory();
            SystemDescription = systemFactory.CreateSystem(systemType,revision);
        }

        public override string ToString()
        {
            return AgentCommentsList.Aggregate($"Mozilla/5.0 {SystemDescription}",(acc,comment)=>$"{acc} {comment}");
        }
    }
}
