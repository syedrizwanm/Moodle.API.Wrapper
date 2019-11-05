using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ForumsByCoursesModel : IModel 
	{
		public int assessed {get;set;}
		public int assesstimefinish {get;set;}
		public int assesstimestart {get;set;}
		public int blockafter {get;set;}
		public int blockperiod {get;set;}
		public int cancreatediscussions {get;set;}
		public int cmid {get;set;}
		public int completiondiscussions {get;set;}
		public int completionposts {get;set;}
		public int completionreplies {get;set;}
		public int course {get;set;}
		public int forcesubscribe {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public int istracked {get;set;}
		public int lockdiscussionafter {get;set;}
		public int maxattachments {get;set;}
		public int maxbytes {get;set;}
		public string name {get;set;}
		public int numdiscussions {get;set;}
		public int rssarticles {get;set;}
		public int rsstype {get;set;}
		public int scale {get;set;}
		public int timemodified {get;set;}
		public int trackingtype {get;set;}
		public string type {get;set;}
		public int unreadpostscount {get;set;}
		public int warnafter {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assessed",prefix),assessed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assesstimefinish",prefix),assesstimefinish.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assesstimestart",prefix),assesstimestart.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("blockafter",prefix),blockafter.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("blockperiod",prefix),blockperiod.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cancreatediscussions",prefix),cancreatediscussions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cmid",prefix),cmid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completiondiscussions",prefix),completiondiscussions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionposts",prefix),completionposts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionreplies",prefix),completionreplies.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forcesubscribe",prefix),forcesubscribe.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("istracked",prefix),istracked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lockdiscussionafter",prefix),lockdiscussionafter.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxattachments",prefix),maxattachments.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxbytes",prefix),maxbytes.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numdiscussions",prefix),numdiscussions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rssarticles",prefix),rssarticles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rsstype",prefix),rsstype.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scale",prefix),scale.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("trackingtype",prefix),trackingtype.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("unreadpostscount",prefix),unreadpostscount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("warnafter",prefix),warnafter.ToString()));
			return keyValuePairs;
		}

	}
}