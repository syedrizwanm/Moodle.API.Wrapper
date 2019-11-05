using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class FoldersByCoursesModel : IModel 
	{
		public List<Folder> folders {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var foldersIndex = 0; foldersIndex<folders.Count;foldersIndex++) 
			{
				var foldersItem = folders[foldersIndex];
				var foldersItems = foldersItem.ToKeyValuePairs("folders[" + foldersIndex + "]");
				keyValuePairs.AddRange(foldersItems);
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