using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolLaunchDataModel : IModel 
	{
		public string endpoint {get;set;}
		public List<Parameter> parameters {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("endpoint",prefix),endpoint));

			for(var parametersIndex = 0; parametersIndex<parameters.Count;parametersIndex++) 
			{
				var parametersItem = parameters[parametersIndex];
				var parametersItems = parametersItem.ToKeyValuePairs("parameters[" + parametersIndex + "]");
				keyValuePairs.AddRange(parametersItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}