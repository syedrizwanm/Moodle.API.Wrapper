using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ProcessPageModel : IModel 
	{

		public int attemptsremaining {get;set;}
		public int correctanswer {get;set;}
		public int displaymenu {get;set;}
		public string feedback {get;set;}
		public int inmediatejump {get;set;}
		public int isessayquestion {get;set;}
		public int maxattemptsreached {get;set;}
		public List<Message> messages {get;set;}
		public int newpageid {get;set;}
		public int noanswer {get;set;}
		public int nodefaultresponse {get;set;}
		public string ongoingscore {get;set;}
		public int progress {get;set;}
		public string response {get;set;}
		public int reviewmode {get;set;}
		public string studentanswer {get;set;}
		public string userresponse {get;set;}
		public List<Warning> warnings {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptsremaining",prefix),attemptsremaining.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("correctanswer",prefix),correctanswer.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displaymenu",prefix),displaymenu.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedback",prefix),feedback));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("inmediatejump",prefix),inmediatejump.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isessayquestion",prefix),isessayquestion.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxattemptsreached",prefix),maxattemptsreached.ToString()));

			for(var messagesIndex = 0; messagesIndex<messages.Count;messagesIndex++) 
			{
				var messagesItem = messages[messagesIndex];
				var messagesItems = messagesItem.ToKeyValuePairs("messages[" + messagesIndex + "]");
				keyValuePairs.AddRange(messagesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newpageid",prefix),newpageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("noanswer",prefix),noanswer.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("nodefaultresponse",prefix),nodefaultresponse.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ongoingscore",prefix),ongoingscore));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("progress",prefix),progress.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("response",prefix),response));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewmode",prefix),reviewmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("studentanswer",prefix),studentanswer));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userresponse",prefix),userresponse));

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