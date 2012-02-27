using Microsoft.VisualStudio.TestTools.UnitTesting;
using NGeo.Yahoo.PlaceFinder;
using Should;
using System;

namespace NGeo
{
    [TestClass]
    public class ExtensionMethodTests
    {
        [TestMethod]
        public void ExtensionMethod_GetEnumMemberAttribute_ShouldReturnNull_WhenEnumHasNoMemberAttribute()
        {
            var attribute = QualityCategory.Area.GetEnumMemberAttribute();
            attribute.ShouldBeNull();
        }

        [TestMethod]
        public void ExtensionMethod_ApplyDefaultValues_ShouldApplyDefaultValueAttributes()
        {
            var request = new PlaceByFreeformText("test");
            request.ApplyDefaultValues();
            request.Locale.ShouldEqual("en-US");
            request.Start.ShouldEqual(0);
            request.Count.ShouldEqual(10);
            request.Offset.ShouldEqual(15);
        }

        [TestMethod]
        public void ExtensionMethod_ToNullIfEmptyOrWhiteSpace_ShouldReturnNull_WhenInputIsNull()
        {
            var string1 = (DateTime.Now.Year > 2010) ? null : string.Empty;
            var string2 = string1.ToNullIfEmptyOrWhiteSpace();
            string2.ShouldBeNull();
        }

        [TestMethod]
        public void ExtensionMethod_ToNullIfEmptyOrWhiteSpace_ShouldReturnNull_WhenInputIsEmpty()
        {
            var string1 = (DateTime.Now.Year > 2010) ? string.Empty : null;
            var string2 = string1.ToNullIfEmptyOrWhiteSpace();
            string2.ShouldBeNull();
        }

        [TestMethod]
        public void ExtensionMethod_ToNullIfEmptyOrWhiteSpace_ShouldReturnNull_WhenInputIsWhiteSpace()
        {
            var string1 = (DateTime.Now.Year > 2010) ? "   " : null;
            var string2 = string1.ToNullIfEmptyOrWhiteSpace();
            string2.ShouldBeNull();
        }

    }
}
