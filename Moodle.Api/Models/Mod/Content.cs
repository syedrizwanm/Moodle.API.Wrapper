using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Content : IModel 
	{

		public string content {get;set;}
		public string content1 {get;set;}
		public string content2 {get;set;}
		public int content3 {get;set;}
		public int content4 {get;set;}
		public int fieldid {get;set;}
		public List<File> files {get;set;}
		public int id {get;set;}
		public int recordid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content1",prefix),content1));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content2",prefix),content2));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content3",prefix),content3.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content4",prefix),content4.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fieldid",prefix),fieldid.ToString()));

			for(var filesIndex = 0; filesIndex<files.Count;filesIndex++) 
			{
				var filesItem = files[filesIndex];
				var filesItems = filesItem.ToKeyValuePairs("files[" + filesIndex + "]");
				keyValuePairs.AddRange(filesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recordid",prefix),recordid.ToString()));
			return keyValuePairs;
		}

	}
}