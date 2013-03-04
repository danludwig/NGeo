//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Runtime.Serialization;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Should;

//namespace NGeo.Yahoo.PlaceFinder
//{
//    [TestClass]
//    public class ResultsTests
//    {
//        [TestMethod]
//        public void Yahoo_PlaceFinder_ResultSet_ShouldBePublic()
//        {
//            var model = new ResultSet();
//            model.ShouldNotBeNull();
//        }

//        [TestMethod]
//        public void Yahoo_PlaceFinder_ResultSet_ShouldImplementGenericIEnumerable()
//        {
//            var model = new ResultSet
//            {
//                ResultsList = new List<Result>
//                {
//                    new Result(), new Result(), new Result(),
//                },
//            };


//            model.ShouldImplement(typeof(IEnumerable<Result>));
//            model.GetEnumerator().ShouldNotBeNull();
//            ((IEnumerable)model).GetEnumerator().ShouldNotBeNull();
//            foreach (var item in model)
//            {
//                item.ShouldNotBeNull();
//            }
//        }

//        [TestMethod]
//        public void Yahoo_PlaceFinder_ResultSet_ShouldOverrideToString()
//        {
//            var it = new ResultSet
//            {
//                Locale = "locale",
//                ErrorMessage = "error message",
//                ResultsList = new List<Result>
//                {
//                    new Result(), new Result(), new Result()
//                },
//                Found = 10,
//            };

//            it.ShouldNotBeNull();
//            it.ToString().ShouldEqual("locale, error message: 3 of 10");
//        }

//        [TestMethod]
//        public void Yahoo_PlaceFinder_ResultSet_ShouldSetAlternateNamesReadOnlyCollection()
//        {
//            var it = new ResultSet
//            {
//                ResultsList = new List<Result>
//                {
//                    new Result { Name = "name 1" },
//                    new Result { Name = "name 2" },
//                    new Result { Name = "name 3" },
//                }
//            };

//            it.ShouldNotBeNull();
//            it.ResultsList.ShouldNotBeNull();
//            it.ResultsList.Count.ShouldEqual(3);
//            it.Results.ShouldNotBeNull();
//            it.Results.Count.ShouldEqual(it.ResultsList.Count);
//            for (var i = 0; i < it.Results.Count; i++)
//                it.Results[i].Name.ShouldEqual(it.ResultsList[i].Name);
//        }

//        [TestMethod]
//        public void Yahoo_PlaceFinder_ResultSet_ShouldHaveDataContractAttribute()
//        {
//            Attribute.IsDefined(typeof(ResultSet), typeof(DataContractAttribute))
//                .ShouldBeTrue();
//        }

//        [TestMethod]
//        public void Yahoo_PlaceFinder_StringProperties_ShouldHaveDataContractAttribute()
//        {
//            var properties = new Dictionary<string, Expression<Func<ResultSet, string>>>
//            {
//                { "ErrorMessage", p => p.ErrorMessage },
//                { "Locale", p => p.Locale },
//            };

//            properties.ShouldHaveDataMemberAttributes();
//        }

//        [TestMethod]
//        public void Yahoo_PlaceFinder_ResultSet_IntProperties_ShouldHaveDataContractAttribute()
//        {
//            var properties = new Dictionary<string, Expression<Func<ResultSet, int>>>
//            {
//                { "Error", p => p.ErrorCode },
//                { "Found", p => p.Found },
//                { "Quality", p => p.Quality },
//            };

//            properties.ShouldHaveDataMemberAttributes();
//        }

//        [TestMethod]
//        public void Yahoo_PlaceFinder_ResultSet_Items_ShouldHaveDataContractAttribute()
//        {
//            var properties = new Dictionary<string, Expression<Func<ResultSet, List<Result>>>>
//            {
//                { "Results", p => p.ResultsList },
//            };

//            properties.ShouldHaveDataMemberAttributes();
//        }

//    }
//}
