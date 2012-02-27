using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_Admin_ShouldBePublic()
        {
            var model = new Admin
            {
                Code = "code",
                Name = "name",
                Type = "type",
            };

            model.ShouldNotBeNull();
            model.Code.ShouldNotBeNull();
            model.Name.ShouldNotBeNull();
            model.Type.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Admin_ShouldOverrideToString()
        {
            var model = new Admin { Name = "name" };
            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Name);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Admin_Properties_ShouldBeConvertedToNull_WhenEmptyOrWhiteSpace()
        {
            var model = new Admin
            {
                Name = null,
                Type = string.Empty,
                Code = "   ",
            };

            model.ShouldNotBeNull();
            model.Name.ShouldBeNull();
            model.Type.ShouldBeNull();
            model.Code.ShouldBeNull();
        }

    }
}
