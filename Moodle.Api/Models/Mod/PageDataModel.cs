using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class PageDataModel : IModel 
	{
		public List<Answer> answers {get;set;}
		public List<Contentfile> contentfiles {get;set;}
		public int displaymenu {get;set;}
		public List<Message> messages {get;set;}
		public int newpageid {get;set;}
		public string ongoingscore {get;set;}
		public Page page {get;set;}
		public string pagecontent {get;set;}
		public int progress {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var answersIndex = 0; answersIndex<answers.Count;answersIndex++) 
			{
				var answersItem = answers[answersIndex];
				var answersItems = answersItem.ToKeyValuePairs("answers[" + answersIndex + "]");
				keyValuePairs.AddRange(answersItems);
			}


			for(var contentfilesIndex = 0; contentfilesIndex<contentfiles.Count;contentfilesIndex++) 
			{
				var contentfilesItem = contentfiles[contentfilesIndex];
				var contentfilesItems = contentfilesItem.ToKeyValuePairs("contentfiles[" + contentfilesIndex + "]");
				keyValuePairs.AddRange(contentfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displaymenu",prefix),displaymenu.ToString()));

			for(var messagesIndex = 0; messagesIndex<messages.Count;messagesIndex++) 
			{
				var messagesItem = messages[messagesIndex];
				var messagesItems = messagesItem.ToKeyValuePairs("messages[" + messagesIndex + "]");
				keyValuePairs.AddRange(messagesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newpageid",prefix),newpageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ongoingscore",prefix),ongoingscore));
			var pageItems = page.ToKeyValuePairs("page");
			keyValuePairs.AddRange(pageItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pagecontent",prefix),pagecontent));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("progress",prefix),progress.ToString()));

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