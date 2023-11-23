using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Laboratorium_4___App.Models
{
     static public class EnumExtensions
     {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}
