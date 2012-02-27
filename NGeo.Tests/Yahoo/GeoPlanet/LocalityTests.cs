using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class LocalityTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_Locality_ShouldBePublic()
        {
            var model = new Locality
            {
                Name = "name",
                Type = "type",
            };

            model.ShouldNotBeNull();
            model.Name.ShouldNotBeNull();
            model.Type.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Locality_ShouldOverrideToString()
        {
            var model = new Locality { Name = "name" };
            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Name);
        }

    }
}
