using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Moodle.Api.Models.Core
{
	public sealed class CoursInputModel : RequestStringGenerator, IModel
	{
		public string fullname { get; set; } 
		public string shortname { get; set; }
		public int categoryid { get; set; }
		public string idnumber { get; set; }
		public string summary { get; set; }
		public int summaryformat { get; set; } = 1;
		public string format { get; set; } = "topics";
		public int showgrades { get; set; } = 1;
		public int newsitems { get; set; } = 5;
		public int startdate { get; set; }
		public int enddate { get; set; }
		public int numsections { get; set; }
		public int maxbytes { get; set; } = 0;
		public int showreports { get; set; } = 0;
		public int visible { get; set; } = 1;
		public int hiddensections { get; set; }
		public int groupmode { get; set; } = 0;
		public int groupmodeforce { get; set; } = 0;
		public int defaultgroupingid { get; set; } = 0;
		public int enablecompletion { get; set; }
		public int completionnotify { get; set; }
		public string lang { get; set; }
		public string forcetheme { get; set; }
		public List<CourseformatoptionInputModel> courseformatoptions { get; set; }
		public List<Customfield> customfields { get; set; }










		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{

			var keyValuePairs = new List<KeyValuePair<string, string>>();



			keyValuePairs.AddRange(DynamicKeyValuePairsOnlyNonList(prefix));




			if (courseformatoptions!=null)
				for (var courseformatoptionsIndex = 0; courseformatoptionsIndex < courseformatoptions.Count; courseformatoptionsIndex++)
			{
				var courseformatoptionsItem = courseformatoptions[courseformatoptionsIndex];
				var courseformatoptionsItems = courseformatoptionsItem.ToKeyValuePairs("courseformatoptions[" + courseformatoptionsIndex + "]");
				keyValuePairs.AddRange(courseformatoptionsItems);
			}

			if (customfields != null)
				for (var customfieldsIndex = 0; customfieldsIndex < customfields.Count; customfieldsIndex++)
			{
				var customfieldsItem = customfields[customfieldsIndex];
				var customfieldsItems = customfieldsItem.ToKeyValuePairs("customfields[" + customfieldsIndex + "]");
				keyValuePairs.AddRange(customfieldsItems);
			}


			return keyValuePairs;
		}




	}
}