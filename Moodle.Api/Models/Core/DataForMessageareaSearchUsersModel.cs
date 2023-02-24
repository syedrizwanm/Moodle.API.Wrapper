using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DataForMessageareaSearchUsersModel : IModel 
	{
		public List<Contact> contacts {get;set;}
		public List<Course> courses {get;set;}
		public List<Noncontact> noncontacts {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var contactsIndex = 0; contactsIndex<contacts.Count;contactsIndex++) 
			{
				var contactsItem = contacts[contactsIndex];
				var contactsItems = contactsItem.ToKeyValuePairs("contacts[" + contactsIndex + "]");
				keyValuePairs.AddRange(contactsItems);
			}


			for(var coursesIndex = 0; coursesIndex<courses.Count;coursesIndex++) 
			{
				var coursesItem = courses[coursesIndex];
				var coursesItems = coursesItem.ToKeyValuePairs("courses[" + coursesIndex + "]");
				keyValuePairs.AddRange(coursesItems);
			}


			for(var noncontactsIndex = 0; noncontactsIndex<noncontacts.Count;noncontactsIndex++) 
			{
				var noncontactsItem = noncontacts[noncontactsIndex];
				var noncontactsItems = noncontactsItem.ToKeyValuePairs("noncontacts[" + noncontactsIndex + "]");
				keyValuePairs.AddRange(noncontactsItems);
			}

			return keyValuePairs;
		}

	}
}