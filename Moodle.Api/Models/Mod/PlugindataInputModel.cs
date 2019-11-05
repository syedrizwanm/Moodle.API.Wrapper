using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class PlugindataInputModel : IModel 
	{

		public int files_filemanager {get;set;}
		public Onlinetext_EditorInputModel onlinetext_editor {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("files_filemanager",prefix),files_filemanager.ToString()));
			var onlinetext_editorItems = onlinetext_editor.ToKeyValuePairs("onlinetext_editor");
			keyValuePairs.AddRange(onlinetext_editorItems);
			return keyValuePairs;
		}

	}
}