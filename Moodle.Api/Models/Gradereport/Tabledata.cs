using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class Tabledata : IModel 
	{

		public Average average {get;set;}
		public Contributiontocoursetotal contributiontocoursetotal {get;set;}
		public Feedback feedback {get;set;}
		public Grade grade {get;set;}
		public Itemname itemname {get;set;}
		public Leader leader {get;set;}
		public Lettergrade lettergrade {get;set;}
		public Percentage percentage {get;set;}
		public Range range {get;set;}
		public Rank rank {get;set;}
		public Weight weight {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var averageItems = average.ToKeyValuePairs("average");
			keyValuePairs.AddRange(averageItems);
			var contributiontocoursetotalItems = contributiontocoursetotal.ToKeyValuePairs("contributiontocoursetotal");
			keyValuePairs.AddRange(contributiontocoursetotalItems);
			var feedbackItems = feedback.ToKeyValuePairs("feedback");
			keyValuePairs.AddRange(feedbackItems);
			var gradeItems = grade.ToKeyValuePairs("grade");
			keyValuePairs.AddRange(gradeItems);
			var itemnameItems = itemname.ToKeyValuePairs("itemname");
			keyValuePairs.AddRange(itemnameItems);
			var leaderItems = leader.ToKeyValuePairs("leader");
			keyValuePairs.AddRange(leaderItems);
			var lettergradeItems = lettergrade.ToKeyValuePairs("lettergrade");
			keyValuePairs.AddRange(lettergradeItems);
			var percentageItems = percentage.ToKeyValuePairs("percentage");
			keyValuePairs.AddRange(percentageItems);
			var rangeItems = range.ToKeyValuePairs("range");
			keyValuePairs.AddRange(rangeItems);
			var rankItems = rank.ToKeyValuePairs("rank");
			keyValuePairs.AddRange(rankItems);
			var weightItems = weight.ToKeyValuePairs("weight");
			keyValuePairs.AddRange(weightItems);
			return keyValuePairs;
		}

	}
}