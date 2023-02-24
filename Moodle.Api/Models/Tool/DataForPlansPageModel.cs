using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForPlansPageModel : IModel 
	{
		public int canmanageuserplans {get;set;}
		public int canreaduserevidence {get;set;}
		public List<string> navigation {get;set;}
		public List<Plan> plans {get;set;}
		public string pluginbaseurl {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanageuserplans",prefix),canmanageuserplans.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canreaduserevidence",prefix),canreaduserevidence.ToString()));

			for(var navigationIndex = 0; navigationIndex<navigation.Count;navigationIndex++) 
			{
				var navigationItem = navigation[navigationIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("navigation[" + navigationIndex + "]",prefix), navigationItem));
			}


			for(var plansIndex = 0; plansIndex<plans.Count;plansIndex++) 
			{
				var plansItem = plans[plansIndex];
				var plansItems = plansItem.ToKeyValuePairs("plans[" + plansIndex + "]");
				keyValuePairs.AddRange(plansItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}