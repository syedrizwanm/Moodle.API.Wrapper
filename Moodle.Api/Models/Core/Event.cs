using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Event : IModel 
	{

		public Action action {get;set;}
		public Course course {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public string eventtype {get;set;}
		public int groupid {get;set;}
		public Icon icon {get;set;}
		public int id {get;set;}
		public int instance {get;set;}
		public string modulename {get;set;}
		public string name {get;set;}
		public int repeatid {get;set;}
		public int timeduration {get;set;}
		public int timemodified {get;set;}
		public int timesort {get;set;}
		public int timestart {get;set;}
		public string url {get;set;}
		public int userid {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var actionItems = action.ToKeyValuePairs("action");
			keyValuePairs.AddRange(actionItems);
			var courseItems = course.ToKeyValuePairs("course");
			keyValuePairs.AddRange(courseItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("eventtype",prefix),eventtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			var iconItems = icon.ToKeyValuePairs("icon");
			keyValuePairs.AddRange(iconItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instance",prefix),instance.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modulename",prefix),modulename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("repeatid",prefix),repeatid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeduration",prefix),timeduration.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timesort",prefix),timesort.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timestart",prefix),timestart.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}