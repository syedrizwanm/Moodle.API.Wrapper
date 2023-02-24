using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class PluginsSupportingMobileModel : IModel 
	{
		public List<Plugin> plugins {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var pluginsIndex = 0; pluginsIndex<plugins.Count;pluginsIndex++) 
			{
				var pluginsItem = plugins[pluginsIndex];
				var pluginsItems = pluginsItem.ToKeyValuePairs("plugins[" + pluginsIndex + "]");
				keyValuePairs.AddRange(pluginsItems);
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