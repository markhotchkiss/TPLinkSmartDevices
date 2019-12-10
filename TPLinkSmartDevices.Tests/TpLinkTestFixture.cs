using System.Threading.Tasks;
using NUnit.Framework;

namespace TPLinkSmartDevices.Tests
{
    [TestFixture]
    public class TpLinkTestFixture
    {
        [Test]
        public async Task DiscoverDevices()
        {
            var tpLinkDiscovery = new TPLinkSmartDevices.TPLinkDiscovery();

            var devices = await tpLinkDiscovery.Discover(9999, 10000);

            Assert.GreaterOrEqual(devices.Count, 1);
        }
    }
}
