using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Course : BaseController
	{

		public Course() : base()
		{
		}

		public Course(string token, string url) : base(token, url)
		{
		}

		public Task<ChecksModel> CheckUpdates(ChecksInputModel checksInputModel)
		{
			return Post<ChecksModel,ChecksInputModel>("core_course_check_updates", checksInputModel);
		}

		public Task<ScaleValuesModel[]> CreateCategories(CategoriesInputModel categoriesInputModel)
		{
			return Post<ScaleValuesModel[],CategoriesInputModel>("core_course_create_categories", categoriesInputModel);
		}


		// Fixed - Working
		/// <summary>
		/// Using for create one or more categories.
		/// </summary>
		/// <param name="coursesInputModel"></param>
		/// <returns>Created Categories List</returns>
		public Task<CoursesModel[]> CreateCourses(CoursesInputModel coursesInputModel)
		{
			return Post<CoursesModel[],CoursesInputModel>("core_course_create_courses", coursesInputModel);
		}

		public Task DeleteCategories(DeleteCategoriesInputModel deleteCategoriesInputModel)
		{
			return Post<DeleteCategoriesInputModel>("core_course_delete_categories", deleteCategoriesInputModel);
		}

		public Task<CohortMembersModel> DeleteCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<CohortMembersModel,DeleteCoursesInputModel>("core_course_delete_courses", deleteCoursesInputModel);
		}

		public Task DeleteModules(DeleteModulesInputModel deleteModulesInputModel)
		{
			return Post<DeleteModulesInputModel>("core_course_delete_modules", deleteModulesInputModel);
		}

		public Task<DuplicateCourseModel> DuplicateCourse(DuplicateCourseInputModel duplicateCourseInputModel)
		{
			return Post<DuplicateCourseModel,DuplicateCourseInputModel>("core_course_duplicate_course", duplicateCourseInputModel);
		}

		public Task<string> EditModule(EditModuleInputModel editModuleInputModel)
		{
			return Post<string,EditModuleInputModel>("core_course_edit_module", editModuleInputModel);
		}

		public Task<string> EditSection(EditModuleInputModel editModuleInputModel)
		{
			return Post<string,EditModuleInputModel>("core_course_edit_section", editModuleInputModel);
		}

		public Task<ActivitiesOverviewModel> GetActivitiesOverview(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ActivitiesOverviewModel,DeleteCoursesInputModel>("core_course_get_activities_overview", deleteCoursesInputModel);
		}


		// Fixed - Working
		/// <summary>
		/// This Getting All Course Categories. -No paramater-
		/// </summary>
		/// <param name="getCategoriesInputModel"></param>
		/// <returns>CategoriesModel Series</returns>
		public Task<CategoriesModel[]> GetCategories(GetCategoriesInputModel getCategoriesInputModel)
		{
			return Post<CategoriesModel[],GetCategoriesInputModel>("core_course_get_categories", getCategoriesInputModel);
		}

		public Task<ContentsModel> GetContents(ContentsInputModel contentsInputModel)
		{
			return Post<ContentsModel,ContentsInputModel>("core_course_get_contents", contentsInputModel);
		}

		public Task<CourseModuleModel> GetCourseModule(CourseModuleInputModel courseModuleInputModel)
		{
			return Post<CourseModuleModel,CourseModuleInputModel>("core_course_get_course_module", courseModuleInputModel);
		}

		public Task<CourseModuleModel> GetCourseModuleByInstance(CourseModuleByInstanceInputModel courseModuleByInstanceInputModel)
		{
			return Post<CourseModuleModel,CourseModuleByInstanceInputModel>("core_course_get_course_module_by_instance", courseModuleByInstanceInputModel);
		}

		public Task<GetCourses> GetCourses(GetCoursesInputModel getCoursesInputModel)
		{
			return Post<GetCourses,GetCoursesInputModel>("core_course_get_courses", getCoursesInputModel);
		}

		public Task<CoursesByFieldModel> GetCoursesByField(CoursesByFieldInputModel coursesByFieldInputModel)
		{
			return Post<CoursesByFieldModel,CoursesByFieldInputModel>("core_course_get_courses_by_field", coursesByFieldInputModel);
		}

		public Task<string> GetModule(ModuleInputModel moduleInputModel)
		{
			return Post<string,ModuleInputModel>("core_course_get_module", moduleInputModel);
		}

		public Task<ChecksModel> GetUpdatesSince(sSinceInputModel sSinceInputModel)
		{
			return Post<ChecksModel,sSinceInputModel>("core_course_get_updates_since", sSinceInputModel);
		}

		public Task<UserAdministrationOptionsModel> GetUserAdministrationOptions(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<UserAdministrationOptionsModel,DeleteCoursesInputModel>("core_course_get_user_administration_options", deleteCoursesInputModel);
		}

		public Task<UserAdministrationOptionsModel> GetUserNavigationOptions(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<UserAdministrationOptionsModel,DeleteCoursesInputModel>("core_course_get_user_navigation_options", deleteCoursesInputModel);
		}

		public Task ImportCourse(ImportCourseInputModel importCourseInputModel)
		{
			return Post<ImportCourseInputModel>("core_course_import_course", importCourseInputModel);
		}

		public Task<SearchCoursesModel> SearchCourses(SearchCoursesInputModel searchCoursesInputModel)
		{
			return Post<SearchCoursesModel,SearchCoursesInputModel>("core_course_search_courses", searchCoursesInputModel);
		}

		public Task UpdateCategories(UpdateCategoriesInputModel updateCategoriesInputModel)
		{
			return Post<UpdateCategoriesInputModel>("core_course_update_categories", updateCategoriesInputModel);
		}

		public Task<UpdateCourses> UpdateCourses(UpdateCoursesInputModel updateCoursesInputModel)
		{
			return Post<UpdateCourses,UpdateCoursesInputModel>("core_course_update_courses", updateCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewCourse(ViewCourseInputModel viewCourseInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewCourseInputModel>("core_course_view_course", viewCourseInputModel);
		}

		//Function Placeholder

	}
}