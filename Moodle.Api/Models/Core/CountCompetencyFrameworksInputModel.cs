using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CountCompetencyFrameworksInputModel : IModel 
	{
		public ContextInputModel context {get;set;}
		public string includes {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var contextItems = context.ToKeyValuePairs("context");
			keyValuePairs.AddRange(contextItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includes",prefix),includes));
			return keyValuePairs;
		}

	}
}