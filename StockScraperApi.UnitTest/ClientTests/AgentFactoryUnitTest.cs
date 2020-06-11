using StockScreenerApi.Logic.Client.Agent;
using StockScreenerApi.Logic.Client.System;
using Xunit;

namespace StockScreenerApi.UnitTest.ClientTests
{
    public class AgentFactoryUnitTest: ClientTest
    {

        [Fact]
        public void CreateAgent_ChromeLinuxGnu()
        {
            var expectedOutput = GenerateAgent(AgentType.Chrome,SystemType.Linux);
            Assert.Equal("Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36", expectedOutput);
        }

        [Fact]
        public void CreateAgent_ChromeLinuxUbuntu()
        {
            var expectedOutput = GenerateAgent(AgentType.Chrome, SystemType.Ubuntu);
            Assert.Equal("Mozilla/5.0 (X11;  Ubuntu; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36", expectedOutput);
        }

        [Fact]
        public void CreateAgent_ChromeOsx()
        {
            var expectedOutput = GenerateAgent(AgentType.Chrome, SystemType.MacOs);
            Assert.Equal("Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36", expectedOutput);
        }

        [Fact]
        public void CreateAgent_ChromeWindows()
        {
            var expectedOutput = GenerateAgent(AgentType.Chrome, SystemType.Windows);
            Assert.Equal("Mozilla/5.0 (Windows NT 10.0;  Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36", expectedOutput);
        }

        [Fact]
        public void CreateAgent_FirefoxLinux()
        {
            var expectedOutput = GenerateAgent(AgentType.Firefox, SystemType.Linux);
            Assert.Equal("Mozilla/5.0 (X11; Linux x86_64; rv:77.0) Gecko/20100101 Firefox/77.0", expectedOutput);
        }

        [Fact]
        public void CreateAgent_FirefoxUbuntu()
        {
            var expectedOutput = GenerateAgent(AgentType.Firefox, SystemType.Ubuntu);
            Assert.Equal("Mozilla/5.0 (X11;  Ubuntu; Linux x86_64; rv:77.0) Gecko/20100101 Firefox/77.0", expectedOutput);
        }

        [Fact]
        public void CreateAgent_FirefoxOsx()
        {
            var expectedOutput = GenerateAgent(AgentType.Firefox, SystemType.MacOs);
            Assert.Equal("Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:77.0) Gecko/20100101 Firefox/77.0", expectedOutput);
        }

        [Fact]
        public void CreateAgent_FirefoxWindows()
        {
            var expectedOutput = GenerateAgent(AgentType.Firefox, SystemType.Windows);
            Assert.Equal("Mozilla/5.0 (Windows NT 10.0;  Win64; x64; rv:77.0) Gecko/20100101 Firefox/77.0", expectedOutput);
        }

        [Fact]
        public void CreateAgent_SafariLinux()
        {
            var expectedOutput = GenerateAgent(AgentType.Safari, SystemType.Linux);
            Assert.Equal("Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1", expectedOutput);
        }

        [Fact]
        public void CreateAgent_SafariUbuntu()
        {
            var expectedOutput = GenerateAgent(AgentType.Safari, SystemType.Ubuntu);
            Assert.Equal("Mozilla/5.0 (X11;  Ubuntu; Linux x86_64) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1", expectedOutput);
        }

        [Fact]
        public void CreateAgent_SafariWindows()
        {
            var expectedOutput = GenerateAgent(AgentType.Safari, SystemType.Windows);
            Assert.Equal("Mozilla/5.0 (Windows NT 10.0;  Win64; x64) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1", expectedOutput);
        }

        [Fact]
        public void CreateAgent_SafariOsx()
        {
            var expectedOutput = GenerateAgent(AgentType.Safari, SystemType.MacOs);
            Assert.Equal("Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1", expectedOutput);
        }

    }
}
