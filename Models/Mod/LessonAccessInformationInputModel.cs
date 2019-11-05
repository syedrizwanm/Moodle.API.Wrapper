using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class LessonAccessInformationInputModel : IModel 
	{
		public int lessonid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessonid",prefix),lessonid.ToString()));
			return keyValuePairs;
		}

	}
}