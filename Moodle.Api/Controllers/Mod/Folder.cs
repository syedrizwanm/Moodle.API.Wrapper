using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Folder : BaseController
	{

		public Folder() : base()
		{
		}

		public Folder(string token, string url) : base(token, url)
		{
		}

		public Task<FoldersByCoursesModel> GetFoldersByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<FoldersByCoursesModel,DeleteCoursesInputModel>("mod_folder_get_folders_by_courses", deleteCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewFolder(ViewFolderInputModel viewFolderInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewFolderInputModel>("mod_folder_view_folder", viewFolderInputModel);
		}

		//Function Placeholder

	}
}