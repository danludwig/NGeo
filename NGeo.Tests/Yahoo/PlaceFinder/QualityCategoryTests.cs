using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class QualityCategoryTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_QualityCategory_ShouldHave3Members()
        {
            ((int)QualityCategory.Area).ShouldEqual(0);
            ((int)QualityCategory.Line).ShouldEqual(70);
            ((int)QualityCategory.Point).ShouldEqual(80);
        }

    }
}
