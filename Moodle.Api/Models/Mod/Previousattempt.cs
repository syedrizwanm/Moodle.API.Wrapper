using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Previousattempt : IModel 
	{

		public int attemptnumber {get;set;}
		public List<Feedbackplugin> feedbackplugins {get;set;}
		public Grade grade {get;set;}
		public Submission submission {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptnumber",prefix),attemptnumber.ToString()));

			for(var feedbackpluginsIndex = 0; feedbackpluginsIndex<feedbackplugins.Count;feedbackpluginsIndex++) 
			{
				var feedbackpluginsItem = feedbackplugins[feedbackpluginsIndex];
				var feedbackpluginsItems = feedbackpluginsItem.ToKeyValuePairs("feedbackplugins[" + feedbackpluginsIndex + "]");
				keyValuePairs.AddRange(feedbackpluginsItems);
			}

			var gradeItems = grade.ToKeyValuePairs("grade");
			keyValuePairs.AddRange(gradeItems);
			var submissionItems = submission.ToKeyValuePairs("submission");
			keyValuePairs.AddRange(submissionItems);
			return keyValuePairs;
		}

	}
}