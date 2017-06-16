using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.API.Wrapper.Models
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
