using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Quizze : IModel 
	{

		public int allowofflineattempts {get;set;}
		public int attemptonlast {get;set;}
		public int attempts {get;set;}
		public int autosaveperiod {get;set;}
		public string browsersecurity {get;set;}
		public int canredoquestions {get;set;}
		public int completionattemptsexhausted {get;set;}
		public int completionpass {get;set;}
		public int course {get;set;}
		public int coursemodule {get;set;}
		public int decimalpoints {get;set;}
		public int delay1 {get;set;}
		public int delay2 {get;set;}
		public int graceperiod {get;set;}
		public double grade {get;set;}
		public int grademethod {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public int hasfeedback {get;set;}
		public int hasquestions {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public string name {get;set;}
		public string navmethod {get;set;}
		public string overduehandling {get;set;}
		public string password {get;set;}
		public string preferredbehaviour {get;set;}
		public int questiondecimalpoints {get;set;}
		public int questionsperpage {get;set;}
		public int reviewattempt {get;set;}
		public int reviewcorrectness {get;set;}
		public int reviewgeneralfeedback {get;set;}
		public int reviewmarks {get;set;}
		public int reviewoverallfeedback {get;set;}
		public int reviewrightanswer {get;set;}
		public int reviewspecificfeedback {get;set;}
		public int section {get;set;}
		public int showblocks {get;set;}
		public int showuserpicture {get;set;}
		public int shuffleanswers {get;set;}
		public string subnet {get;set;}
		public double sumgrades {get;set;}
		public int timeclose {get;set;}
		public int timecreated {get;set;}
		public int timelimit {get;set;}
		public int timemodified {get;set;}
		public int timeopen {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowofflineattempts",prefix),allowofflineattempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptonlast",prefix),attemptonlast.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attempts",prefix),attempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("autosaveperiod",prefix),autosaveperiod.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("browsersecurity",prefix),browsersecurity));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canredoquestions",prefix),canredoquestions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionattemptsexhausted",prefix),completionattemptsexhausted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionpass",prefix),completionpass.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("decimalpoints",prefix),decimalpoints.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("delay1",prefix),delay1.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("delay2",prefix),delay2.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("graceperiod",prefix),graceperiod.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grademethod",prefix),grademethod.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupingid",prefix),groupingid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmode",prefix),groupmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hasfeedback",prefix),hasfeedback.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hasquestions",prefix),hasquestions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("navmethod",prefix),navmethod));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("overduehandling",prefix),overduehandling));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("password",prefix),password));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("preferredbehaviour",prefix),preferredbehaviour));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("questiondecimalpoints",prefix),questiondecimalpoints.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("questionsperpage",prefix),questionsperpage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewattempt",prefix),reviewattempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewcorrectness",prefix),reviewcorrectness.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewgeneralfeedback",prefix),reviewgeneralfeedback.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewmarks",prefix),reviewmarks.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewoverallfeedback",prefix),reviewoverallfeedback.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewrightanswer",prefix),reviewrightanswer.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewspecificfeedback",prefix),reviewspecificfeedback.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showblocks",prefix),showblocks.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showuserpicture",prefix),showuserpicture.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shuffleanswers",prefix),shuffleanswers.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subnet",prefix),subnet));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sumgrades",prefix),sumgrades.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeclose",prefix),timeclose.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timelimit",prefix),timelimit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeopen",prefix),timeopen.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}