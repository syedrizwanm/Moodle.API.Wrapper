using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseCompetencySettingsInputModel : IModel 
	{
		public int courseid {get;set;}
		public SettingInputModel settings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			var settingsItems = settings.ToKeyValuePairs("settings");
			keyValuePairs.AddRange(settingsItems);
			return keyValuePairs;
		}

	}
}