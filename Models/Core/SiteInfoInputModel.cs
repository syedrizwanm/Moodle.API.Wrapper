using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SiteInfoInputModel : IModel 
	{
		public List<string> serviceshortnames {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var serviceshortnamesIndex = 0; serviceshortnamesIndex<serviceshortnames.Count;serviceshortnamesIndex++) 
			{
				var serviceshortnamesItem = serviceshortnames[serviceshortnamesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("serviceshortnames[" + serviceshortnamesIndex + "]",prefix), serviceshortnamesItem));
			}

			return keyValuePairs;
		}

	}
}