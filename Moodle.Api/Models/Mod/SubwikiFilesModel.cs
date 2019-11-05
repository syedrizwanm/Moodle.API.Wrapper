using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubwikiFilesModel : IModel 
	{
		public List<File> files {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var filesIndex = 0; filesIndex<files.Count;filesIndex++) 
			{
				var filesItem = files[filesIndex];
				var filesItems = filesItem.ToKeyValuePairs("files[" + filesIndex + "]");
				keyValuePairs.AddRange(filesItems);
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