using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class EntryModel : IModel 
	{

		public List<Fieldnotification> fieldnotifications {get;set;}
		public List<string> generalnotifications {get;set;}
		public int updated {get;set;}
		public List<Warning> warnings {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var fieldnotificationsIndex = 0; fieldnotificationsIndex<fieldnotifications.Count;fieldnotificationsIndex++) 
			{
				var fieldnotificationsItem = fieldnotifications[fieldnotificationsIndex];
				var fieldnotificationsItems = fieldnotificationsItem.ToKeyValuePairs("fieldnotifications[" + fieldnotificationsIndex + "]");
				keyValuePairs.AddRange(fieldnotificationsItems);
			}


			for(var generalnotificationsIndex = 0; generalnotificationsIndex<generalnotifications.Count;generalnotificationsIndex++) 
			{
				var generalnotificationsItem = generalnotifications[generalnotificationsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("generalnotifications[" + generalnotificationsIndex + "]",prefix), generalnotificationsItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("updated",prefix),updated.ToString()));

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