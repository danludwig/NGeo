using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public enum ResultStyle
    {
        [EnumMember(Value = "short")]
        Short = 0,

        [EnumMember(Value = "medium")]
        Medium = 1,

        [EnumMember(Value = "long")]
        Long = 2,

        [EnumMember(Value = "full")]
        Full = 3,
    }
}
