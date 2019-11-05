using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Feedback : IModel 
	{

		public Grade grade {get;set;}
		public int gradeddate {get;set;}
		public string gradefordisplay {get;set;}
		public List<Plugin> plugins {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var gradeItems = grade.ToKeyValuePairs("grade");
			keyValuePairs.AddRange(gradeItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradeddate",prefix),gradeddate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradefordisplay",prefix),gradefordisplay));

			for(var pluginsIndex = 0; pluginsIndex<plugins.Count;pluginsIndex++) 
			{
				var pluginsItem = plugins[pluginsIndex];
				var pluginsItems = pluginsItem.ToKeyValuePairs("plugins[" + pluginsIndex + "]");
				keyValuePairs.AddRange(pluginsItems);
			}

			return keyValuePairs;
		}

	}
}