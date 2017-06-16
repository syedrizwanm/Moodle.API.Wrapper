using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Wiki : BaseController
	{

		public Wiki() : base()
		{
		}

		public Wiki(string token, string url) : base(token, url)
		{
		}

		public EditPageModel EditPage(EditPageInputModel editPageInputModel)
		{
			return Post<EditPageModel,EditPageInputModel>("mod_wiki_edit_page", editPageInputModel);
		}

		public PageContentsModel GetPageContents(ViewPageInputModel viewPageInputModel)
		{
			return Post<PageContentsModel,ViewPageInputModel>("mod_wiki_get_page_contents", viewPageInputModel);
		}

		public PageForEditingModel GetPageForEditing(PageForEditingInputModel pageForEditingInputModel)
		{
			return Post<PageForEditingModel,PageForEditingInputModel>("mod_wiki_get_page_for_editing", pageForEditingInputModel);
		}

		public SubwikiFilesModel GetSubwikiFiles(SubwikiFilesInputModel subwikiFilesInputModel)
		{
			return Post<SubwikiFilesModel,SubwikiFilesInputModel>("mod_wiki_get_subwiki_files", subwikiFilesInputModel);
		}

		public SubwikiPagesModel GetSubwikiPages(SubwikiPagesInputModel subwikiPagesInputModel)
		{
			return Post<SubwikiPagesModel,SubwikiPagesInputModel>("mod_wiki_get_subwiki_pages", subwikiPagesInputModel);
		}

		public SubwikisModel GetSubwikis(SubwikisInputModel subwikisInputModel)
		{
			return Post<SubwikisModel,SubwikisInputModel>("mod_wiki_get_subwikis", subwikisInputModel);
		}

		public WikisByCoursesModel GetWikisByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<WikisByCoursesModel,DeleteCoursesInputModel>("mod_wiki_get_wikis_by_courses", deleteCoursesInputModel);
		}

		public EditPageModel NewPage(NewPageInputModel newPageInputModel)
		{
			return Post<EditPageModel,NewPageInputModel>("mod_wiki_new_page", newPageInputModel);
		}

		public MarkCourseSelfCompletedModel ViewPage(ViewPageInputModel viewPageInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewPageInputModel>("mod_wiki_view_page", viewPageInputModel);
		}

		public MarkCourseSelfCompletedModel ViewWiki(SubwikisInputModel subwikisInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,SubwikisInputModel>("mod_wiki_view_wiki", subwikisInputModel);
		}

		//Function Placeholder

	}
}