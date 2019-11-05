using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SaveDefinitionsInputModel : IModel 
	{
		public List<AreaInputModel> areas {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var areasIndex = 0; areasIndex<areas.Count;areasIndex++) 
			{
				var areasItem = areas[areasIndex];
				var areasItems = areasItem.ToKeyValuePairs("areas[" + areasIndex + "]");
				keyValuePairs.AddRange(areasItems);
			}

			return keyValuePairs;
		}

	}
}