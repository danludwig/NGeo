
using System;

namespace NGeo.Yahoo.PlaceFinder
{
    public static class QualityExtensions
    {
        //public static QualityCategory QualityCategory(this ResultSet resultSet)
        //{
        //    if (resultSet == null) throw new ArgumentNullException("resultSet");
        //    return CategoryFor(resultSet.Quality);
        //}

        public static QualityCategory QualityCategory(this Result result)
        {
            if (result == null) throw new ArgumentNullException("result");
            return CategoryFor(result.Quality);
        }

        private static QualityCategory CategoryFor(int quality)
        {
            if (quality < 70) return PlaceFinder.QualityCategory.Area;
            return quality < 80 ? PlaceFinder.QualityCategory.Line : PlaceFinder.QualityCategory.Point;
        }

        //public static QualityDescription QualityDescription(this ResultSet resultSet)
        //{
        //    if (resultSet == null) throw new ArgumentNullException("resultSet");
        //    return DescriptionFor(resultSet.Quality);
        //}

        public static QualityDescription QualityDescription(this Result result)
        {
            if (result == null) throw new ArgumentNullException("result");
            return DescriptionFor(result.Quality);
        }

        private static QualityDescription DescriptionFor(int quality)
        {
            var enumValue = (QualityDescription)quality;
            return enumValue;
        }

    }
}