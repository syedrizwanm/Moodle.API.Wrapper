using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class NotesInputModel : IModel 
	{
		public List<NoteInputModel> notes {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var notesIndex = 0; notesIndex<notes.Count;notesIndex++) 
			{
				var notesItem = notes[notesIndex];
				var notesItems = notesItem.ToKeyValuePairs("notes[" + notesIndex + "]");
				keyValuePairs.AddRange(notesItems);
			}

			return keyValuePairs;
		}

	}
}