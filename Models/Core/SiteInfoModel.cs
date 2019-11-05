using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SiteInfoModel : IModel 
	{
		public List<Advancedfeature> advancedfeatures {get;set;}
		public int downloadfiles {get;set;}
		public string firstname {get;set;}
		public string fullname {get;set;}
		public List<Function> functions {get;set;}
		public string lang {get;set;}
		public string lastname {get;set;}
		public string mobilecssurl {get;set;}
		public string release {get;set;}
		public int siteid {get;set;}
		public string sitename {get;set;}
		public string siteurl {get;set;}
		public int uploadfiles {get;set;}
		public int usercanmanageownfiles {get;set;}
		public int userhomepage {get;set;}
		public int userid {get;set;}
		public int usermaxuploadfilesize {get;set;}
		public string username {get;set;}
		public string userpictureurl {get;set;}
		public int userquota {get;set;}
		public string version {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var advancedfeaturesIndex = 0; advancedfeaturesIndex<advancedfeatures.Count;advancedfeaturesIndex++) 
			{
				var advancedfeaturesItem = advancedfeatures[advancedfeaturesIndex];
				var advancedfeaturesItems = advancedfeaturesItem.ToKeyValuePairs("advancedfeatures[" + advancedfeaturesIndex + "]");
				keyValuePairs.AddRange(advancedfeaturesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("downloadfiles",prefix),downloadfiles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstname",prefix),firstname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));

			for(var functionsIndex = 0; functionsIndex<functions.Count;functionsIndex++) 
			{
				var functionsItem = functions[functionsIndex];
				var functionsItems = functionsItem.ToKeyValuePairs("functions[" + functionsIndex + "]");
				keyValuePairs.AddRange(functionsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lang",prefix),lang));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastname",prefix),lastname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mobilecssurl",prefix),mobilecssurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("release",prefix),release));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("siteid",prefix),siteid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sitename",prefix),sitename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("siteurl",prefix),siteurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uploadfiles",prefix),uploadfiles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usercanmanageownfiles",prefix),usercanmanageownfiles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userhomepage",prefix),userhomepage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermaxuploadfilesize",prefix),usermaxuploadfilesize.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("username",prefix),username));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userpictureurl",prefix),userpictureurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userquota",prefix),userquota.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("version",prefix),version));
			return keyValuePairs;
		}

	}
}