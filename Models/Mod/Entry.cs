using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Entry : IModel 
	{

		public int approved {get;set;}
		public int attachment {get;set;}
		public List<Attachment> attachments {get;set;}
		public int casesensitive {get;set;}
		public string concept {get;set;}
		public string definition {get;set;}
		public int definitionformat {get;set;}
		public List<Definitioninlinefile> definitioninlinefiles {get;set;}
		public int definitiontrust {get;set;}
		public int fullmatch {get;set;}
		public int glossaryid {get;set;}
		public int id {get;set;}
		public int sourceglossaryid {get;set;}
		public int teacherentry {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int usedynalink {get;set;}
		public string userfullname {get;set;}
		public int userid {get;set;}
		public string userpictureurl {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("approved",prefix),approved.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attachment",prefix),attachment.ToString()));

			for(var attachmentsIndex = 0; attachmentsIndex<attachments.Count;attachmentsIndex++) 
			{
				var attachmentsItem = attachments[attachmentsIndex];
				var attachmentsItems = attachmentsItem.ToKeyValuePairs("attachments[" + attachmentsIndex + "]");
				keyValuePairs.AddRange(attachmentsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("casesensitive",prefix),casesensitive.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("concept",prefix),concept));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("definition",prefix),definition));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("definitionformat",prefix),definitionformat.ToString()));

			for(var definitioninlinefilesIndex = 0; definitioninlinefilesIndex<definitioninlinefiles.Count;definitioninlinefilesIndex++) 
			{
				var definitioninlinefilesItem = definitioninlinefiles[definitioninlinefilesIndex];
				var definitioninlinefilesItems = definitioninlinefilesItem.ToKeyValuePairs("definitioninlinefiles[" + definitioninlinefilesIndex + "]");
				keyValuePairs.AddRange(definitioninlinefilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("definitiontrust",prefix),definitiontrust.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullmatch",prefix),fullmatch.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("glossaryid",prefix),glossaryid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sourceglossaryid",prefix),sourceglossaryid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("teacherentry",prefix),teacherentry.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usedynalink",prefix),usedynalink.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userfullname",prefix),userfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userpictureurl",prefix),userpictureurl));
			return keyValuePairs;
		}

	}
}