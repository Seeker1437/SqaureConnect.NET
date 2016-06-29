using System.Reflection;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates the color of an item's label color in Square Register, in six-character hexadecimal format.
    /// </summary>
    /// <remarks>
    /// Colors other than those defined are not supported.
    /// </remarks>
    public static class ItemColor
    {
        /// <summary>
        /// A gray color.
        /// </summary>
        public const string Gray = "9da2a6";
        /// <summary>
        /// A lighter green color.
        /// </summary>
        public const string LightGreen = "4ab200";
        /// <summary>
        /// A darker green color.
        /// </summary>
        public const string DarkGreen = "0b8000";
        /// <summary>
        /// A lighter blue color.
        /// </summary>
        public const string LightBlue = "13b1bf";
        /// <summary>
        /// A darker blue color.
        /// </summary>
        public const string DarkBlue = "2952cc";
        /// <summary>
        /// A purple color.
        /// </summary>
        public const string Purple = "a82ee5";
        /// <summary>
        /// A lighter red color.
        /// </summary>
        public const string LightRed = "e5457a";
        /// <summary>
        /// A dark red color.
        /// </summary>
        public const string DarkRed = "b21212";
        /// <summary>
        /// A gold color.
        /// </summary>
        public const string Gold = "e5BF00";
        /// <summary>
        /// A brown color.
        /// </summary>
        public const string Brown = "593c00";

        /// <summary>
        /// Returns the name of the item color if it is defined
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetName(string value)
        {
            foreach (var field in typeof(ItemColor).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if ((string)field.GetValue(null) == value)
                    return field.Name;
            }

            return "?";
        }
    }
}
