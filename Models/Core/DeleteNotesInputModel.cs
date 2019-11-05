using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteNotesInputModel : IModel 
	{
		public List<int> notes {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var notesIndex = 0; notesIndex<notes.Count;notesIndex++) 
			{
				var notesItem = notes[notesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("notes[" + notesIndex + "]",prefix), notesItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}