using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AdvancedgradingdataInputModel : IModel 
	{

		public GuideInputModel guide {get;set;}
		public RubricInputModel rubric {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var guideItems = guide.ToKeyValuePairs("guide");
			keyValuePairs.AddRange(guideItems);
			var rubricItems = rubric.ToKeyValuePairs("rubric");
			keyValuePairs.AddRange(rubricItems);
			return keyValuePairs;
		}

	}
}