using StockScreenerApi.Logic.Client.Agent;
using StockScreenerApi.Logic.Client.System;

namespace StockScreenerApi.UnitTest.ClientTests
{
    public abstract class ClientTest
    {
        protected string GenerateAgent(AgentType agentType, SystemType systemType)
        {
            var agentFactory = new AgentFactory();
            var agent = agentFactory.CreateAgent(agentType, systemType);
            return agent.ToString();
        }
    }
}
