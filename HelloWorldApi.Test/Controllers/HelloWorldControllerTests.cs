
namespace HelloWorldApi.Test.Controllers
{
    using System.Threading.Tasks;
    using HelloWorldApi.Controllers;
    using HelloWorldApi.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class HelloWorldControllerTests
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var configSvc = new Mock<IConfigService>();

            configSvc.Setup(p => p.Evn)
                .Returns("Test");

            var controller = new HelloWorldController(configSvc.Object);

            var getResult = controller.Get();

            var content = await getResult.Content.ReadAsStringAsync();

            Assert.IsTrue(string.IsNullOrEmpty(content), $"{this.GetType().Name} TestMethod1 Content Wrong");
        }
    }
}
