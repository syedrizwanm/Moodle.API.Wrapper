using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteModulesInputModel : IModel 
	{
		public List<int> cmids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var cmidsIndex = 0; cmidsIndex<cmids.Count;cmidsIndex++) 
			{
				var cmidsItem = cmids[cmidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cmids[" + cmidsIndex + "]",prefix), cmidsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}