using System.Collections.Generic;

namespace Moodle.Api.Models
{
    public interface IModel
    {
        List<KeyValuePair<string, string>> ToKeyValuePairs(string prefix = "");
    }
}
