using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Lesson : IModel 
	{

		public int activitylink {get;set;}
		public int allowofflineattempts {get;set;}
		public int available {get;set;}
		public string bgcolor {get;set;}
		public int completionendreached {get;set;}
		public int completiontimespent {get;set;}
		public string conditions {get;set;}
		public int course {get;set;}
		public int coursemodule {get;set;}
		public int custom {get;set;}
		public int deadline {get;set;}
		public int dependency {get;set;}
		public int displayleft {get;set;}
		public int displayleftif {get;set;}
		public int feedback {get;set;}
		public int grade {get;set;}
		public int height {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public int maxanswers {get;set;}
		public int maxattempts {get;set;}
		public int maxpages {get;set;}
		public int mediaclose {get;set;}
		public string mediafile {get;set;}
		public List<Mediafile> mediafiles {get;set;}
		public int mediaheight {get;set;}
		public int mediawidth {get;set;}
		public int minquestions {get;set;}
		public int modattempts {get;set;}
		public string name {get;set;}
		public int nextpagedefault {get;set;}
		public int ongoing {get;set;}
		public string password {get;set;}
		public int practice {get;set;}
		public int progressbar {get;set;}
		public int retake {get;set;}
		public int review {get;set;}
		public int slideshow {get;set;}
		public int timelimit {get;set;}
		public int timemodified {get;set;}
		public int usemaxgrade {get;set;}
		public int usepassword {get;set;}
		public int width {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("activitylink",prefix),activitylink.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowofflineattempts",prefix),allowofflineattempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("available",prefix),available.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("bgcolor",prefix),bgcolor));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionendreached",prefix),completionendreached.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completiontimespent",prefix),completiontimespent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("conditions",prefix),conditions));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("custom",prefix),custom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("deadline",prefix),deadline.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dependency",prefix),dependency.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayleft",prefix),displayleft.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayleftif",prefix),displayleftif.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedback",prefix),feedback.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("height",prefix),height.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxanswers",prefix),maxanswers.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxattempts",prefix),maxattempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxpages",prefix),maxpages.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mediaclose",prefix),mediaclose.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mediafile",prefix),mediafile));

			for(var mediafilesIndex = 0; mediafilesIndex<mediafiles.Count;mediafilesIndex++) 
			{
				var mediafilesItem = mediafiles[mediafilesIndex];
				var mediafilesItems = mediafilesItem.ToKeyValuePairs("mediafiles[" + mediafilesIndex + "]");
				keyValuePairs.AddRange(mediafilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mediaheight",prefix),mediaheight.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mediawidth",prefix),mediawidth.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("minquestions",prefix),minquestions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modattempts",prefix),modattempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("nextpagedefault",prefix),nextpagedefault.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ongoing",prefix),ongoing.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("password",prefix),password));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("practice",prefix),practice.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("progressbar",prefix),progressbar.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("retake",prefix),retake.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("review",prefix),review.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("slideshow",prefix),slideshow.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timelimit",prefix),timelimit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usemaxgrade",prefix),usemaxgrade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usepassword",prefix),usepassword.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("width",prefix),width.ToString()));
			return keyValuePairs;
		}

	}
}