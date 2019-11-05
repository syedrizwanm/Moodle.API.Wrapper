using System.Collections.Generic;

namespace Moodle.Api.Models.Enrol
{
	public sealed class UnenrolUsersInputModel : IModel 
	{
		public List<EnrolmentInputModel> enrolments {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var enrolmentsIndex = 0; enrolmentsIndex<enrolments.Count;enrolmentsIndex++) 
			{
				var enrolmentsItem = enrolments[enrolmentsIndex];
				var enrolmentsItems = enrolmentsItem.ToKeyValuePairs("enrolments[" + enrolmentsIndex + "]");
				keyValuePairs.AddRange(enrolmentsItems);
			}

			return keyValuePairs;
		}

	}
}