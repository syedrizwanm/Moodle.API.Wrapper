using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Lti : IModel 
	{

		public int course {get;set;}
		public int coursemodule {get;set;}
		public int debuglaunch {get;set;}
		public int grade {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public string icon {get;set;}
		public int id {get;set;}
		public int instructorchoiceacceptgrades {get;set;}
		public int instructorchoiceallowroster {get;set;}
		public int instructorchoiceallowsetting {get;set;}
		public int instructorchoicesendemailaddr {get;set;}
		public string instructorchoicesendname {get;set;}
		public string instructorcustomparameters {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public int launchcontainer {get;set;}
		public string name {get;set;}
		public string password {get;set;}
		public string resourcekey {get;set;}
		public int section {get;set;}
		public string secureicon {get;set;}
		public string securetoolurl {get;set;}
		public string servicesalt {get;set;}
		public int showdescriptionlaunch {get;set;}
		public int showtitlelaunch {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public string toolurl {get;set;}
		public int typeid {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("debuglaunch",prefix),debuglaunch.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupingid",prefix),groupingid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmode",prefix),groupmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("icon",prefix),icon));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instructorchoiceacceptgrades",prefix),instructorchoiceacceptgrades.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instructorchoiceallowroster",prefix),instructorchoiceallowroster.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instructorchoiceallowsetting",prefix),instructorchoiceallowsetting.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instructorchoicesendemailaddr",prefix),instructorchoicesendemailaddr.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instructorchoicesendname",prefix),instructorchoicesendname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instructorcustomparameters",prefix),instructorcustomparameters));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("launchcontainer",prefix),launchcontainer.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("password",prefix),password));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("resourcekey",prefix),resourcekey));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("secureicon",prefix),secureicon));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("securetoolurl",prefix),securetoolurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("servicesalt",prefix),servicesalt));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showdescriptionlaunch",prefix),showdescriptionlaunch.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showtitlelaunch",prefix),showtitlelaunch.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("toolurl",prefix),toolurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("typeid",prefix),typeid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}