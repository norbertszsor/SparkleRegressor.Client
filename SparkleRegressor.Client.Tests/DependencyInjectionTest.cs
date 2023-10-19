using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using SparkleRegressor.Client;
using SparkleRegressor.Client.Configuration;
using SparkleRegressor.Client.Abstraction.Interfaces;

namespace Src.Unit.Tests
{
    [TestClass]
    public class DependencyInjectionTest
    {
        [TestMethod]
        public void AddSparkleRegressorClient_WithConfiguration_ShouldConfigureServices()
        {
            var appSettings = new Dictionary<string, string>()
            {
                { $"{nameof(SrcSettings)}:{nameof(SrcSettings.BaseUrl)}", "https://localhost:5001" }
            };

            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(appSettings!)
                .Build();


            var services = new ServiceCollection();

            services.AddSparkleRegressorClient(configuration);

            var serviceProvider = services.BuildServiceProvider();

            var client = serviceProvider.GetService<ISparkleRegressorClient>();

            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void AddSparkleRegressorClient_WithSrcSettings_ShouldConfigureServices()
        {
            var srcSettings = new SrcSettings()
            {
                BaseUrl = "https://localhost:5001"
            };

            var services = new ServiceCollection();

            services.AddSparkleRegressorClient(srcSettings);

            var serviceProvider = services.BuildServiceProvider();

            var client = serviceProvider.GetService<ISparkleRegressorClient>();

            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void AddSparkleRegressorClient_WithSrcSettings_ShouldThrowArgumentNullException()
        {
            var services = new ServiceCollection();

            Assert.ThrowsException<ArgumentNullException>(() => services.AddSparkleRegressorClient((SrcSettings)null!));
        }
    }
}
