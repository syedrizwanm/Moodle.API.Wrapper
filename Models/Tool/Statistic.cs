using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Statistic : IModel 
	{

		public int competencycount {get;set;}
		public int completedplancount {get;set;}
		public double completedplanpercentage {get;set;}
		public string completedplanpercentageformatted {get;set;}
		public List<Leastproficient> leastproficient {get;set;}
		public int leastproficientcount {get;set;}
		public int linkedcompetencycount {get;set;}
		public double linkedcompetencypercentage {get;set;}
		public string linkedcompetencypercentageformatted {get;set;}
		public int plancount {get;set;}
		public int proficientusercompetencyplancount {get;set;}
		public double proficientusercompetencyplanpercentage {get;set;}
		public string proficientusercompetencyplanpercentageformatted {get;set;}
		public int unlinkedcompetencycount {get;set;}
		public int usercompetencyplancount {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencycount",prefix),competencycount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completedplancount",prefix),completedplancount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completedplanpercentage",prefix),completedplanpercentage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completedplanpercentageformatted",prefix),completedplanpercentageformatted));

			for(var leastproficientIndex = 0; leastproficientIndex<leastproficient.Count;leastproficientIndex++) 
			{
				var leastproficientItem = leastproficient[leastproficientIndex];
				var leastproficientItems = leastproficientItem.ToKeyValuePairs("leastproficient[" + leastproficientIndex + "]");
				keyValuePairs.AddRange(leastproficientItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("leastproficientcount",prefix),leastproficientcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("linkedcompetencycount",prefix),linkedcompetencycount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("linkedcompetencypercentage",prefix),linkedcompetencypercentage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("linkedcompetencypercentageformatted",prefix),linkedcompetencypercentageformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("plancount",prefix),plancount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficientusercompetencyplancount",prefix),proficientusercompetencyplancount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficientusercompetencyplanpercentage",prefix),proficientusercompetencyplanpercentage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficientusercompetencyplanpercentageformatted",prefix),proficientusercompetencyplanpercentageformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("unlinkedcompetencycount",prefix),unlinkedcompetencycount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usercompetencyplancount",prefix),usercompetencyplancount.ToString()));
			return keyValuePairs;
		}

	}
}