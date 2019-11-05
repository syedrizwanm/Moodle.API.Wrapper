using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class EnrolledUsersWithCapabilityInputModel : IModel 
	{
		public List<CoursecapabilityInputModel> coursecapabilities {get;set;}
		public List<OptionInputModel> options {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var coursecapabilitiesIndex = 0; coursecapabilitiesIndex<coursecapabilities.Count;coursecapabilitiesIndex++) 
			{
				var coursecapabilitiesItem = coursecapabilities[coursecapabilitiesIndex];
				var coursecapabilitiesItems = coursecapabilitiesItem.ToKeyValuePairs("coursecapabilities[" + coursecapabilitiesIndex + "]");
				keyValuePairs.AddRange(coursecapabilitiesItems);
			}


			for(var optionsIndex = 0; optionsIndex<options.Count;optionsIndex++) 
			{
				var optionsItem = options[optionsIndex];
				var optionsItems = optionsItem.ToKeyValuePairs("options[" + optionsIndex + "]");
				keyValuePairs.AddRange(optionsItems);
			}

			return keyValuePairs;
		}

	}
}