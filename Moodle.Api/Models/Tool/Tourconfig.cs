using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Tourconfig : IModel 
	{

		public string name {get;set;}
		public List<Step> steps {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));

			for(var stepsIndex = 0; stepsIndex<steps.Count;stepsIndex++) 
			{
				var stepsItem = steps[stepsIndex];
				var stepsItems = stepsItem.ToKeyValuePairs("steps[" + stepsIndex + "]");
				keyValuePairs.AddRange(stepsItems);
			}

			return keyValuePairs;
		}

	}
}