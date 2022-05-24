using ProdActivity.Domain.Converters;
using System.ComponentModel;

namespace ProdActivity.Domain.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EngineeringActivityType
    {
        Design,
        Drafting
    }
}
