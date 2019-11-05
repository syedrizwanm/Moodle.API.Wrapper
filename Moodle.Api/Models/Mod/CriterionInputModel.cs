using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class CriterionInputModel : IModel 
	{

		public int criterionid {get;set;}
		public List<FillingInputModel> fillings {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("criterionid",prefix),criterionid.ToString()));

			for(var fillingsIndex = 0; fillingsIndex<fillings.Count;fillingsIndex++) 
			{
				var fillingsItem = fillings[fillingsIndex];
				var fillingsItems = fillingsItem.ToKeyValuePairs("fillings[" + fillingsIndex + "]");
				keyValuePairs.AddRange(fillingsItems);
			}

			return keyValuePairs;
		}

	}
}