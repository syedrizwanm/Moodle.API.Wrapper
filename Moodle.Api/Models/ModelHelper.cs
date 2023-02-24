namespace Moodle.Api.Models
{
    public class ModelHelper
    {
        public static string GetPrefixedName(string propertyName, string prefix)
        {
            var prefixedName = propertyName;

            if (!string.IsNullOrEmpty(prefix))
            {
                prefixedName = $"{prefix}[{propertyName}]";
            }

            return prefixedName;
        }
    }
}
