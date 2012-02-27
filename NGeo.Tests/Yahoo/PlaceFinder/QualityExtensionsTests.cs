using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class QualityExtensionsTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_ResultSetQualityCategory_ShouldBeArea_WhenQualityIsLessThan70()
        {
            var model = new ResultSet
            {
                Quality = 69,
            };

            model.QualityCategory().ShouldEqual(QualityCategory.Area);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_ResultSetQualityCategory_ShouldBeLine_WhenQualityIsGreaterThan69AndLessThan80()
        {
            var model = new ResultSet
            {
                Quality = 79,
            };

            model.QualityCategory().ShouldEqual(QualityCategory.Line);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_ResultSetQualityCategory_ShouldBePoint_WhenQualityIsGreaterThan79()
        {
            var model = new ResultSet
            {
                Quality = 80,
            };

            model.QualityCategory().ShouldEqual(QualityCategory.Point);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_PlaceFinder_ResultSetQualityCategory_ShouldThrowException_WhenArgIsNull()
        {
            var model = (DateTime.Now.Year > 2010) ? null : new ResultSet();

            model.QualityCategory();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_ResultSetQualityDescription_ShouldMatchIntEquivalent()
        {
            var model = new ResultSet
            {
                Quality = 59,
            };

            model.QualityDescription().ShouldEqual(QualityDescription.PostalDistrictIgnoreStreet);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_PlaceFinder_ResultSetQualityDescription_ShouldThrowException_WhenArgIsNull()
        {
            var model = (DateTime.Now.Year > 2010) ? null : new ResultSet();

            model.QualityDescription();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_ResultQualityCategory_ShouldBeArea_WhenQualityIsLessThan70()
        {
            var model = new Result
            {
                Quality = 69,
            };

            model.QualityCategory().ShouldEqual(QualityCategory.Area);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_ResultQualityCategory_ShouldBeLine_WhenQualityIsGreaterThan69AndLessThan80()
        {
            var model = new Result
            {
                Quality = 79,
            };

            model.QualityCategory().ShouldEqual(QualityCategory.Line);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_ResultQualityCategory_ShouldBePoint_WhenQualityIsGreaterThan79()
        {
            var model = new Result
            {
                Quality = 80,
            };

            model.QualityCategory().ShouldEqual(QualityCategory.Point);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_PlaceFinder_ResultQualityCategory_ShouldThrowException_WhenArgIsNull()
        {
            var model = (DateTime.Now.Year > 2010) ? null : new Result();

            model.QualityCategory();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_ResultQualityDescription_ShouldMatchIntEquivalent()
        {
            var model = new Result
            {
                Quality = 49,
            };

            model.QualityDescription().ShouldEqual(QualityDescription.NeighborhoodLevel4IgnoreStreet);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_PlaceFinder_ResultQualityDescription_ShouldThrowException_WhenArgIsNull()
        {
            var model = (DateTime.Now.Year > 2010) ? null : new Result();

            model.QualityDescription();
        }

    }
}
