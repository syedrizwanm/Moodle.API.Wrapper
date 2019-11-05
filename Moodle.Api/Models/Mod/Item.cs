using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Item : IModel 
	{

		public int dependitem {get;set;}
		public string dependvalue {get;set;}
		public int feedback {get;set;}
		public int hasvalue {get;set;}
		public int id {get;set;}
		public List<Itemfile> itemfiles {get;set;}
		public int itemnumber {get;set;}
		public string label {get;set;}
		public string name {get;set;}
		public string options {get;set;}
		public string otherdata {get;set;}
		public int position {get;set;}
		public string presentation {get;set;}
		public int required {get;set;}
		public int template {get;set;}
		public string typ {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dependitem",prefix),dependitem.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dependvalue",prefix),dependvalue));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedback",prefix),feedback.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hasvalue",prefix),hasvalue.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));

			for(var itemfilesIndex = 0; itemfilesIndex<itemfiles.Count;itemfilesIndex++) 
			{
				var itemfilesItem = itemfiles[itemfilesIndex];
				var itemfilesItems = itemfilesItem.ToKeyValuePairs("itemfiles[" + itemfilesIndex + "]");
				keyValuePairs.AddRange(itemfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemnumber",prefix),itemnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("label",prefix),label));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("options",prefix),options));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("otherdata",prefix),otherdata));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("position",prefix),position.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("presentation",prefix),presentation));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("required",prefix),required.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("template",prefix),template.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("typ",prefix),typ));
			return keyValuePairs;
		}

	}
}