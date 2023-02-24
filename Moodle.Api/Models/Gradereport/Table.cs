using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class Table : IModel 
	{

		public int courseid {get;set;}
		public int maxdepth {get;set;}
		public List<Tabledata> tabledata {get;set;}
		public string userfullname {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxdepth",prefix),maxdepth.ToString()));

			for(var tabledataIndex = 0; tabledataIndex<tabledata.Count;tabledataIndex++) 
			{
				var tabledataItem = tabledata[tabledataIndex];
				var tabledataItems = tabledataItem.ToKeyValuePairs("tabledata[" + tabledataIndex + "]");
				keyValuePairs.AddRange(tabledataItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userfullname",prefix),userfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}