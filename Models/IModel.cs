using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.API.Wrapper.Models
{
    public interface IModel
    {
        List<KeyValuePair<string, string>> ToKeyValuePairs(string prefix = "");
    }
}
