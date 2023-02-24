using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Module : IModel 
	{

		public string availability {get;set;}
		public string availabilityinfo {get;set;}
		public List<Content> contents {get;set;}
		public string description {get;set;}
		public int id {get;set;}
		public int indent {get;set;}
		public int instance {get;set;}
		public string modicon {get;set;}
		public string modname {get;set;}
		public string modplural {get;set;}
		public string name {get;set;}
		public string url {get;set;}
		public int uservisible {get;set;}
		public int visible {get;set;}
		public int visibleoncoursepage {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("availability",prefix),availability));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("availabilityinfo",prefix),availabilityinfo));

			for(var contentsIndex = 0; contentsIndex<contents.Count;contentsIndex++) 
			{
				var contentsItem = contents[contentsIndex];
				var contentsItems = contentsItem.ToKeyValuePairs("contents[" + contentsIndex + "]");
				keyValuePairs.AddRange(contentsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("indent",prefix),indent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instance",prefix),instance.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modicon",prefix),modicon));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modname",prefix),modname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modplural",prefix),modplural));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uservisible",prefix),uservisible.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visibleoncoursepage",prefix),visibleoncoursepage.ToString()));
			return keyValuePairs;
		}

	}
}