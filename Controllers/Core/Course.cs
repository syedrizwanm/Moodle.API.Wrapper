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

		public ChecksModel CheckUpdates(ChecksInputModel checksInputModel)
		{
			return Post<ChecksModel,ChecksInputModel>("core_course_check_updates", checksInputModel);
		}

		public ScaleValuesModel CreateCategories(CategoriesInputModel categoriesInputModel)
		{
			return Post<ScaleValuesModel,CategoriesInputModel>("core_course_create_categories", categoriesInputModel);
		}

		public CoursesModel CreateCourses(CoursesInputModel coursesInputModel)
		{
			return Post<CoursesModel,CoursesInputModel>("core_course_create_courses", coursesInputModel);
		}

		public void DeleteCategories(DeleteCategoriesInputModel deleteCategoriesInputModel)
		{
			Post<DeleteCategoriesInputModel>("core_course_delete_categories", deleteCategoriesInputModel);
		}

		public CohortMembersModel DeleteCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<CohortMembersModel,DeleteCoursesInputModel>("core_course_delete_courses", deleteCoursesInputModel);
		}

		public void DeleteModules(DeleteModulesInputModel deleteModulesInputModel)
		{
			Post<DeleteModulesInputModel>("core_course_delete_modules", deleteModulesInputModel);
		}

		public DuplicateCourseModel DuplicateCourse(DuplicateCourseInputModel duplicateCourseInputModel)
		{
			return Post<DuplicateCourseModel,DuplicateCourseInputModel>("core_course_duplicate_course", duplicateCourseInputModel);
		}

		public string EditModule(EditModuleInputModel editModuleInputModel)
		{
			return Post<string,EditModuleInputModel>("core_course_edit_module", editModuleInputModel);
		}

		public string EditSection(EditModuleInputModel editModuleInputModel)
		{
			return Post<string,EditModuleInputModel>("core_course_edit_section", editModuleInputModel);
		}

		public ActivitiesOverviewModel GetActivitiesOverview(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ActivitiesOverviewModel,DeleteCoursesInputModel>("core_course_get_activities_overview", deleteCoursesInputModel);
		}

		public CategoriesModel GetCategories(GetCategoriesInputModel getCategoriesInputModel)
		{
			return Post<CategoriesModel,GetCategoriesInputModel>("core_course_get_categories", getCategoriesInputModel);
		}

		public ContentsModel GetContents(ContentsInputModel contentsInputModel)
		{
			return Post<ContentsModel,ContentsInputModel>("core_course_get_contents", contentsInputModel);
		}

		public CourseModuleModel GetCourseModule(CourseModuleInputModel courseModuleInputModel)
		{
			return Post<CourseModuleModel,CourseModuleInputModel>("core_course_get_course_module", courseModuleInputModel);
		}

		public CourseModuleModel GetCourseModuleByInstance(CourseModuleByInstanceInputModel courseModuleByInstanceInputModel)
		{
			return Post<CourseModuleModel,CourseModuleByInstanceInputModel>("core_course_get_course_module_by_instance", courseModuleByInstanceInputModel);
		}

		public GetCourses GetCourses(GetCoursesInputModel getCoursesInputModel)
		{
			return Post<GetCourses,GetCoursesInputModel>("core_course_get_courses", getCoursesInputModel);
		}

		public CoursesByFieldModel GetCoursesByField(CoursesByFieldInputModel coursesByFieldInputModel)
		{
			return Post<CoursesByFieldModel,CoursesByFieldInputModel>("core_course_get_courses_by_field", coursesByFieldInputModel);
		}

		public string GetModule(ModuleInputModel moduleInputModel)
		{
			return Post<string,ModuleInputModel>("core_course_get_module", moduleInputModel);
		}

		public ChecksModel GetUpdatesSince(sSinceInputModel sSinceInputModel)
		{
			return Post<ChecksModel,sSinceInputModel>("core_course_get_updates_since", sSinceInputModel);
		}

		public UserAdministrationOptionsModel GetUserAdministrationOptions(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<UserAdministrationOptionsModel,DeleteCoursesInputModel>("core_course_get_user_administration_options", deleteCoursesInputModel);
		}

		public UserAdministrationOptionsModel GetUserNavigationOptions(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<UserAdministrationOptionsModel,DeleteCoursesInputModel>("core_course_get_user_navigation_options", deleteCoursesInputModel);
		}

		public void ImportCourse(ImportCourseInputModel importCourseInputModel)
		{
			Post<ImportCourseInputModel>("core_course_import_course", importCourseInputModel);
		}

		public SearchCoursesModel SearchCourses(SearchCoursesInputModel searchCoursesInputModel)
		{
			return Post<SearchCoursesModel,SearchCoursesInputModel>("core_course_search_courses", searchCoursesInputModel);
		}

		public void UpdateCategories(UpdateCategoriesInputModel updateCategoriesInputModel)
		{
			Post<UpdateCategoriesInputModel>("core_course_update_categories", updateCategoriesInputModel);
		}

		public UpdateCourses UpdateCourses(UpdateCoursesInputModel updateCoursesInputModel)
		{
			return Post<UpdateCourses,UpdateCoursesInputModel>("core_course_update_courses", updateCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewCourse(ViewCourseInputModel viewCourseInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewCourseInputModel>("core_course_view_course", viewCourseInputModel);
		}

		//Function Placeholder

	}
}