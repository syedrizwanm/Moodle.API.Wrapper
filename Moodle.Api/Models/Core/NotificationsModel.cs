using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class NotificationsModel : IModel 
	{
		public string template {get;set;}
		public Variable variables {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("template",prefix),template));
			var variablesItems = variables.ToKeyValuePairs("variables");
			keyValuePairs.AddRange(variablesItems);
			return keyValuePairs;
		}

	}
}