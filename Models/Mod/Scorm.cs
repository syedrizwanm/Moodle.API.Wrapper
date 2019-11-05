using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Scorm : IModel 
	{

		public int auto {get;set;}
		public int autocommit {get;set;}
		public int completionscorerequired {get;set;}
		public int completionstatusallscos {get;set;}
		public int completionstatusrequired {get;set;}
		public int course {get;set;}
		public int coursemodule {get;set;}
		public int displayactivityname {get;set;}
		public int displayattemptstatus {get;set;}
		public int displaycoursestructure {get;set;}
		public int forcecompleted {get;set;}
		public int forcenewattempt {get;set;}
		public int grademethod {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public int height {get;set;}
		public int hidebrowse {get;set;}
		public int hidetoc {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public int lastattemptlock {get;set;}
		public int launch {get;set;}
		public int maxattempt {get;set;}
		public int maxgrade {get;set;}
		public string md5hash {get;set;}
		public string name {get;set;}
		public int nav {get;set;}
		public int navpositionleft {get;set;}
		public int navpositiontop {get;set;}
		public string options {get;set;}
		public int packagesize {get;set;}
		public string packageurl {get;set;}
		public int popup {get;set;}
		public int protectpackagedownloads {get;set;}
		public string reference {get;set;}
		public int revision {get;set;}
		public string scormtype {get;set;}
		public int section {get;set;}
		public string sha1hash {get;set;}
		public int skipview {get;set;}
		public int timeclose {get;set;}
		public int timemodified {get;set;}
		public int timeopen {get;set;}
		public int updatefreq {get;set;}
		public string version {get;set;}
		public int visible {get;set;}
		public int whatgrade {get;set;}
		public int width {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("auto",prefix),auto.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("autocommit",prefix),autocommit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionscorerequired",prefix),completionscorerequired.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionstatusallscos",prefix),completionstatusallscos.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionstatusrequired",prefix),completionstatusrequired.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayactivityname",prefix),displayactivityname.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayattemptstatus",prefix),displayattemptstatus.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displaycoursestructure",prefix),displaycoursestructure.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forcecompleted",prefix),forcecompleted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forcenewattempt",prefix),forcenewattempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grademethod",prefix),grademethod.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupingid",prefix),groupingid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmode",prefix),groupmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("height",prefix),height.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hidebrowse",prefix),hidebrowse.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hidetoc",prefix),hidetoc.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastattemptlock",prefix),lastattemptlock.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("launch",prefix),launch.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxattempt",prefix),maxattempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxgrade",prefix),maxgrade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("md5hash",prefix),md5hash));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("nav",prefix),nav.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("navpositionleft",prefix),navpositionleft.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("navpositiontop",prefix),navpositiontop.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("options",prefix),options));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("packagesize",prefix),packagesize.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("packageurl",prefix),packageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("popup",prefix),popup.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("protectpackagedownloads",prefix),protectpackagedownloads.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reference",prefix),reference));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("revision",prefix),revision.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scormtype",prefix),scormtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sha1hash",prefix),sha1hash));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("skipview",prefix),skipview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeclose",prefix),timeclose.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeopen",prefix),timeopen.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("updatefreq",prefix),updatefreq.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("version",prefix),version));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("whatgrade",prefix),whatgrade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("width",prefix),width.ToString()));
			return keyValuePairs;
		}

	}
}