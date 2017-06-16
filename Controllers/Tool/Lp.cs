using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Tool;

namespace Moodle.API.Wrapper.Controllers.Tool
{
	public sealed class Lp : BaseController
	{

		public Lp() : base()
		{
		}

		public Lp(string token, string url) : base(token, url)
		{
		}

		public DataForCompetenciesManagePageModel DataForCompetenciesManagePage(DataForCompetenciesManagePageInputModel dataForCompetenciesManagePageInputModel)
		{
			return Post<DataForCompetenciesManagePageModel,DataForCompetenciesManagePageInputModel>("tool_lp_data_for_competencies_manage_page", dataForCompetenciesManagePageInputModel);
		}

		public DataForCompetencyFrameworksManagePageModel DataForCompetencyFrameworksManagePage(DataForCompetencyFrameworksManagePageInputModel dataForCompetencyFrameworksManagePageInputModel)
		{
			return Post<DataForCompetencyFrameworksManagePageModel,DataForCompetencyFrameworksManagePageInputModel>("tool_lp_data_for_competency_frameworks_manage_page", dataForCompetencyFrameworksManagePageInputModel);
		}

		public DataForCompetencySummaryModel DataForCompetencySummary(DataForCompetencySummaryInputModel dataForCompetencySummaryInputModel)
		{
			return Post<DataForCompetencySummaryModel,DataForCompetencySummaryInputModel>("tool_lp_data_for_competency_summary", dataForCompetencySummaryInputModel);
		}

		public DataForCourseCompetenciesPageModel DataForCourseCompetenciesPage(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<DataForCourseCompetenciesPageModel,CourseBlocksInputModel>("tool_lp_data_for_course_competencies_page", courseBlocksInputModel);
		}

		public DataForPlanPageModel DataForPlanPage(CompletePlanInputModel completePlanInputModel)
		{
			return Post<DataForPlanPageModel,CompletePlanInputModel>("tool_lp_data_for_plan_page", completePlanInputModel);
		}

		public DataForPlansPageModel DataForPlansPage(UserPlansInputModel userPlansInputModel)
		{
			return Post<DataForPlansPageModel,UserPlansInputModel>("tool_lp_data_for_plans_page", userPlansInputModel);
		}

		public DataForRelatedCompetenciesSectionModel DataForRelatedCompetenciesSection(DataForRelatedCompetenciesSectionInputModel dataForRelatedCompetenciesSectionInputModel)
		{
			return Post<DataForRelatedCompetenciesSectionModel,DataForRelatedCompetenciesSectionInputModel>("tool_lp_data_for_related_competencies_section", dataForRelatedCompetenciesSectionInputModel);
		}

		public DataForTemplateCompetenciesPageModel DataForTemplateCompetenciesPage(DataForTemplateCompetenciesPageInputModel dataForTemplateCompetenciesPageInputModel)
		{
			return Post<DataForTemplateCompetenciesPageModel,DataForTemplateCompetenciesPageInputModel>("tool_lp_data_for_template_competencies_page", dataForTemplateCompetenciesPageInputModel);
		}

		public DataForTemplatesManagePageModel DataForTemplatesManagePage(DataForCompetencyFrameworksManagePageInputModel dataForCompetencyFrameworksManagePageInputModel)
		{
			return Post<DataForTemplatesManagePageModel,DataForCompetencyFrameworksManagePageInputModel>("tool_lp_data_for_templates_manage_page", dataForCompetencyFrameworksManagePageInputModel);
		}

		public DataForUserCompetencySummaryModel DataForUserCompetencySummary(UserCompetencyCancelReviewRequestInputModel userCompetencyCancelReviewRequestInputModel)
		{
			return Post<DataForUserCompetencySummaryModel,UserCompetencyCancelReviewRequestInputModel>("tool_lp_data_for_user_competency_summary", userCompetencyCancelReviewRequestInputModel);
		}

		public DataForUserCompetencySummaryInCourseModel DataForUserCompetencySummaryInCourse(DataForUserCompetencySummaryInCourseInputModel dataForUserCompetencySummaryInCourseInputModel)
		{
			return Post<DataForUserCompetencySummaryInCourseModel,DataForUserCompetencySummaryInCourseInputModel>("tool_lp_data_for_user_competency_summary_in_course", dataForUserCompetencySummaryInCourseInputModel);
		}

		public DataForUserCompetencySummaryInPlanModel DataForUserCompetencySummaryInPlan(DataForUserCompetencySummaryInPlanInputModel dataForUserCompetencySummaryInPlanInputModel)
		{
			return Post<DataForUserCompetencySummaryInPlanModel,DataForUserCompetencySummaryInPlanInputModel>("tool_lp_data_for_user_competency_summary_in_plan", dataForUserCompetencySummaryInPlanInputModel);
		}

		public DataForUserEvidencePageModel DataForUserEvidenceListPage(UserPlansInputModel userPlansInputModel)
		{
			return Post<DataForUserEvidencePageModel,UserPlansInputModel>("tool_lp_data_for_user_evidence_list_page", userPlansInputModel);
		}

		public DataForUserEvidencePage DataForUserEvidencePage(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<DataForUserEvidencePage,ApprovePlanInputModel>("tool_lp_data_for_user_evidence_page", approvePlanInputModel);
		}

		public CoursesUsingCompetencyModel ListCoursesUsingCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<CoursesUsingCompetencyModel,ApprovePlanInputModel>("tool_lp_list_courses_using_competency", approvePlanInputModel);
		}

		public SearchCohortsModel SearchCohorts(SearchCohortsInputModel searchCohortsInputModel)
		{
			return Post<SearchCohortsModel,SearchCohortsInputModel>("tool_lp_search_cohorts", searchCohortsInputModel);
		}

		public SearchUsersModel SearchUsers(SearchUsersInputModel searchUsersInputModel)
		{
			return Post<SearchUsersModel,SearchUsersInputModel>("tool_lp_search_users", searchUsersInputModel);
		}

		//Function Placeholder

	}
}