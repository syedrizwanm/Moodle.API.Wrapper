using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DefinitionInputModel : IModel 
	{

		public int copiedfromid {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public GuideInputModel guide {get;set;}
		public int id {get;set;}
		public string method {get;set;}
		public string name {get;set;}
		public RubricInputModel rubric {get;set;}
		public int status {get;set;}
		public int timecopied {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int usercreated {get;set;}
		public int usermodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("copiedfromid",prefix),copiedfromid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			var guideItems = guide.ToKeyValuePairs("guide");
			keyValuePairs.AddRange(guideItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("method",prefix),method));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			var rubricItems = rubric.ToKeyValuePairs("rubric");
			keyValuePairs.AddRange(rubricItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecopied",prefix),timecopied.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usercreated",prefix),usercreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}