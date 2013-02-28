using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;

namespace NGeo
{
    [TestClass]
    public class ExtensionMethodTests
    {
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
