using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DataForMessageareaContactsModel : IModel 
	{
		public List<Contact> contacts {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var contactsIndex = 0; contactsIndex<contacts.Count;contactsIndex++) 
			{
				var contactsItem = contacts[contactsIndex];
				var contactsItems = contactsItem.ToKeyValuePairs("contacts[" + contactsIndex + "]");
				keyValuePairs.AddRange(contactsItems);
			}

			return keyValuePairs;
		}

	}
}