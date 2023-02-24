using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CategoriesModel : RequestStringGenerator, IModel
	{
		public int coursecount {get;set;}
		public int depth {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string name {get;set;}
		public int parent {get;set;}
		public string path {get;set;}
		public int sortorder {get;set;}
		public string theme {get;set;}
		public int timemodified {get;set;}
		public int visible {get;set;}
		public int visibleold {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string, string>>();
			 
			keyValuePairs.AddRange(DynamicKeyValuePairsOnlyNonList(prefix));
			 
			return keyValuePairs;
		}

	}
}