using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Discussion : IModel 
	{

		public string attachment {get;set;}
		public List<Attachment> attachments {get;set;}
		public int canreply {get;set;}
		public int created {get;set;}
		public int discussion {get;set;}
		public int groupid {get;set;}
		public int id {get;set;}
		public int locked {get;set;}
		public int mailed {get;set;}
		public int mailnow {get;set;}
		public string message {get;set;}
		public int messageformat {get;set;}
		public List<Messageinlinefile> messageinlinefiles {get;set;}
		public int messagetrust {get;set;}
		public int modified {get;set;}
		public string name {get;set;}
		public string numreplies {get;set;}
		public int numunread {get;set;}
		public int parent {get;set;}
		public int pinned {get;set;}
		public string subject {get;set;}
		public int timeend {get;set;}
		public int timemodified {get;set;}
		public int timestart {get;set;}
		public int totalscore {get;set;}
		public string userfullname {get;set;}
		public int userid {get;set;}
		public int usermodified {get;set;}
		public string usermodifiedfullname {get;set;}
		public string usermodifiedpictureurl {get;set;}
		public string userpictureurl {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attachment",prefix),attachment));

			for(var attachmentsIndex = 0; attachmentsIndex<attachments.Count;attachmentsIndex++) 
			{
				var attachmentsItem = attachments[attachmentsIndex];
				var attachmentsItems = attachmentsItem.ToKeyValuePairs("attachments[" + attachmentsIndex + "]");
				keyValuePairs.AddRange(attachmentsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canreply",prefix),canreply.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("created",prefix),created.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("discussion",prefix),discussion.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("locked",prefix),locked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mailed",prefix),mailed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mailnow",prefix),mailnow.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("messageformat",prefix),messageformat.ToString()));

			for(var messageinlinefilesIndex = 0; messageinlinefilesIndex<messageinlinefiles.Count;messageinlinefilesIndex++) 
			{
				var messageinlinefilesItem = messageinlinefiles[messageinlinefilesIndex];
				var messageinlinefilesItems = messageinlinefilesItem.ToKeyValuePairs("messageinlinefiles[" + messageinlinefilesIndex + "]");
				keyValuePairs.AddRange(messageinlinefilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("messagetrust",prefix),messagetrust.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modified",prefix),modified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numreplies",prefix),numreplies));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numunread",prefix),numunread.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("parent",prefix),parent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pinned",prefix),pinned.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subject",prefix),subject));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeend",prefix),timeend.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timestart",prefix),timestart.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("totalscore",prefix),totalscore.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userfullname",prefix),userfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodifiedfullname",prefix),usermodifiedfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodifiedpictureurl",prefix),usermodifiedpictureurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userpictureurl",prefix),userpictureurl));
			return keyValuePairs;
		}

	}
}