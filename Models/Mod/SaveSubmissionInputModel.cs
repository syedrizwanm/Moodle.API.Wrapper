using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class SaveSubmissionInputModel : IModel 
	{
		public int assignmentid {get;set;}
		public PlugindataInputModel plugindata {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentid",prefix),assignmentid.ToString()));
			var plugindataItems = plugindata.ToKeyValuePairs("plugindata");
			keyValuePairs.AddRange(plugindataItems);
			return keyValuePairs;
		}

	}
}