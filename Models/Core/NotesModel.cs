using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class NotesModel : IModel 
	{

		public List<Note> notes {get;set;}
		public List<Warning> warnings {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var notesIndex = 0; notesIndex<notes.Count;notesIndex++) 
			{
				var notesItem = notes[notesIndex];
				var notesItems = notesItem.ToKeyValuePairs("notes[" + notesIndex + "]");
				keyValuePairs.AddRange(notesItems);
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