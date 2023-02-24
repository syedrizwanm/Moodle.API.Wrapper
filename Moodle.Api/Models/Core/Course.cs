using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Course : IModel 
	{

		public int categoryid {get;set;}
		public string categoryname {get;set;}
		public List<Contact> contacts {get;set;}
		public string displayname {get;set;}
		public List<string> enrollmentmethods {get;set;}
		public string fullname {get;set;}
		public int id {get;set;}
		public List<Overviewfile> overviewfiles {get;set;}
		public string shortname {get;set;}
		public int sortorder {get;set;}
		public string summary {get;set;}
		public List<Summaryfile> summaryfiles {get;set;}
		public int summaryformat {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("categoryid",prefix),categoryid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("categoryname",prefix),categoryname));

			for(var contactsIndex = 0; contactsIndex<contacts.Count;contactsIndex++) 
			{
				var contactsItem = contacts[contactsIndex];
				var contactsItems = contactsItem.ToKeyValuePairs("contacts[" + contactsIndex + "]");
				keyValuePairs.AddRange(contactsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayname",prefix),displayname));

			for(var enrollmentmethodsIndex = 0; enrollmentmethodsIndex<enrollmentmethods.Count;enrollmentmethodsIndex++) 
			{
				var enrollmentmethodsItem = enrollmentmethods[enrollmentmethodsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enrollmentmethods[" + enrollmentmethodsIndex + "]",prefix), enrollmentmethodsItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));

			for(var overviewfilesIndex = 0; overviewfilesIndex<overviewfiles.Count;overviewfilesIndex++) 
			{
				var overviewfilesItem = overviewfiles[overviewfilesIndex];
				var overviewfilesItems = overviewfilesItem.ToKeyValuePairs("overviewfiles[" + overviewfilesIndex + "]");
				keyValuePairs.AddRange(overviewfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortorder",prefix),sortorder.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summary",prefix),summary));

			for(var summaryfilesIndex = 0; summaryfilesIndex<summaryfiles.Count;summaryfilesIndex++) 
			{
				var summaryfilesItem = summaryfiles[summaryfilesIndex];
				var summaryfilesItems = summaryfilesItem.ToKeyValuePairs("summaryfiles[" + summaryfilesIndex + "]");
				keyValuePairs.AddRange(summaryfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summaryformat",prefix),summaryformat.ToString()));
			return keyValuePairs;
		}

	}
}