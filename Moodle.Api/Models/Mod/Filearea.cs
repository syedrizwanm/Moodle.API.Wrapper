using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Filearea : IModel 
	{

		public string area {get;set;}
		public List<File> files {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("area",prefix),area));

			for(var filesIndex = 0; filesIndex<files.Count;filesIndex++) 
			{
				var filesItem = files[filesIndex];
				var filesItems = filesItem.ToKeyValuePairs("files[" + filesIndex + "]");
				keyValuePairs.AddRange(filesItems);
			}

			return keyValuePairs;
		}

	}
}