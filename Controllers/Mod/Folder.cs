using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Folder : BaseController
	{

		public Folder() : base()
		{
		}

		public Folder(string token, string url) : base(token, url)
		{
		}

		public FoldersByCoursesModel GetFoldersByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<FoldersByCoursesModel,DeleteCoursesInputModel>("mod_folder_get_folders_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewFolder(ViewFolderInputModel viewFolderInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewFolderInputModel>("mod_folder_view_folder", viewFolderInputModel);
		}

		//Function Placeholder

	}
}