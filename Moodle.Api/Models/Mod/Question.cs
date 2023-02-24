using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Question : IModel 
	{

		public int id {get;set;}
		public string intro {get;set;}
		public string multi {get;set;}
		public string options {get;set;}
		public int parent {get;set;}
		public string shorttext {get;set;}
		public string text {get;set;}
		public int type {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("multi",prefix),multi));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("options",prefix),options));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("parent",prefix),parent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shorttext",prefix),shorttext));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type.ToString()));
			return keyValuePairs;
		}

	}
}