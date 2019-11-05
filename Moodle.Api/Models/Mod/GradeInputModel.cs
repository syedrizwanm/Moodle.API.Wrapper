using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class GradeInputModel : IModel 
	{

		public int addattempt {get;set;}
		public AdvancedgradingdataInputModel advancedgradingdata {get;set;}
		public int attemptnumber {get;set;}
		public double grade {get;set;}
		public PlugindataInputModel plugindata {get;set;}
		public int userid {get;set;}
		public string workflowstate {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("addattempt",prefix),addattempt.ToString()));
			var advancedgradingdataItems = advancedgradingdata.ToKeyValuePairs("advancedgradingdata");
			keyValuePairs.AddRange(advancedgradingdataItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptnumber",prefix),attemptnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			var plugindataItems = plugindata.ToKeyValuePairs("plugindata");
			keyValuePairs.AddRange(plugindataItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("workflowstate",prefix),workflowstate));
			return keyValuePairs;
		}

	}
}