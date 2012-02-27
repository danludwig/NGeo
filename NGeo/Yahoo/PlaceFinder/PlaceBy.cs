using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NGeo.Yahoo.PlaceFinder
{
    public abstract class PlaceBy
    {
        private int _start;
        private int _count;
        private int _offset;
        private HashSet<Flag> _flags;
        private HashSet<GFlag> _gFlags;

        protected PlaceBy()
        {
            Flags = new HashSet<Flag>();
            GFlags = new HashSet<GFlag>();
            this.ApplyDefaultValues();
        }

        /// <summary>
        /// Required. The application ID. Grants authorization to use the web service.
        /// Though the Yahoo! docs indicate this is a required field, the service seems
        /// to work without an AppId as of 2011.11.20.
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// The language and country. A two-letter ISO-639 major language code and a two-letter ISO-3166-1 alpha-2 country code, 
        /// separated by either a hyphen or underscore. Default is en-US (English/US).
        /// </summary>
        [DefaultValue("en-US")]
        public string Locale { get; set; }

        /// <summary>
        /// Index of first result to return. Range is 0 to 99. Default is 0.
        /// </summary>
        [DefaultValue(0)]
        public int Start
        {
            get { return _start; }
            set
            {
                if (value < 0 || value > 99)
                    throw new ArgumentException("Start must be between 0 and 99 (inclusive).");
                _start = value;
            }
        }

        /// <summary>
        /// Number of results to return. Range is 1 to 100. Default is 10.
        /// </summary>
        [DefaultValue(10)]
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Count must be between 0 and 100 (inclusive).");
                _count = value;
            }
        }

        /// <summary>
        /// Location setback in meters, intended to approximate a building location offset 
        /// from the road center-line. Range is 0 to 100. Default is 15.
        /// </summary>
        [DefaultValue(15)]
        public int Offset
        {
            get { return _offset; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Offset must be between 0 and 100 (inclusive).");
                _offset = value;
            }
        }

        /// <summary>
        /// String of concatenated characters that specify the data returned. 
        /// The default value of this parameter is an empty string. The default return format is XML. 
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#flags-parameter">Flags Parameter</see>.
        /// </summary>
        internal HashSet<Flag> Flags
        {
            get { return _flags; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Flags cannot be null.");
                _flags = value;
            }
        }

        /// <summary>
        /// String of concatenated characters that specify the geocoding performed. 
        /// The default value of this parameter is an empty string. 
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#gflags-parameter">Gflags Parameter</see>.
        /// </summary>
        internal HashSet<GFlag> GFlags
        {
            get { return _gFlags; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "GFlags cannot be null.");
                _gFlags = value;
            }
        }

        /// <summary>
        /// Converts Flags into a string value for the 'flags' parameter of the Yahoo! PlaceFinder request URL.
        /// </summary>
        /// <returns>A string value for the 'flags' parameter of the Yahoo! PlaceFinder request URL.</returns>
        internal string GetFlagsAsString()
        {
            var flags = new StringBuilder();

            foreach (var flag in Flags)
                flags.Append(flag.GetEnumMemberAttribute().Value);

            return flags.ToString();
        }

        /// <summary>
        /// Converts GFlags into a string value for the 'gflags' parameter of the Yahoo! PlaceFinder request URL.
        /// </summary>
        /// <returns>A string value for the 'gflags' parameter of the Yahoo! PlaceFinder request URL.</returns>
        internal string GetGFlagsAsString()
        {
            var gFlags = new StringBuilder();

            foreach (var gFlag in GFlags)
                gFlags.Append(gFlag.GetEnumMemberAttribute().Value);

            return gFlags.ToString();
        }

    }
}
