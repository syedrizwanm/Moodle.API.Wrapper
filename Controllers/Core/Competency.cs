using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Competency : BaseController
	{

		public Competency() : base()
		{
		}

		public Competency(string token, string url) : base(token, url)
		{
		}

		public Task<int> AddCompetencyToCourse(CompetencyToCourseInputModel competencyToCourseInputModel)
		{
			return Post<int,CompetencyToCourseInputModel>("core_competency_add_competency_to_course", competencyToCourseInputModel);
		}

		public Task<int> AddCompetencyToPlan(CompetencyToPlanInputModel competencyToPlanInputModel)
		{
			return Post<int,CompetencyToPlanInputModel>("core_competency_add_competency_to_plan", competencyToPlanInputModel);
		}

		public Task<int> AddCompetencyToTemplate(CompetencyToTemplateInputModel competencyToTemplateInputModel)
		{
			return Post<int,CompetencyToTemplateInputModel>("core_competency_add_competency_to_template", competencyToTemplateInputModel);
		}

		public Task<int> AddRelatedCompetency(RelatedCompetencyInputModel relatedCompetencyInputModel)
		{
			return Post<int,RelatedCompetencyInputModel>("core_competency_add_related_competency", relatedCompetencyInputModel);
		}

		public Task<int> ApprovePlan(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_approve_plan", approvePlanInputModel);
		}

		public Task<int> CompetencyFrameworkViewed(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_competency_framework_viewed", approvePlanInputModel);
		}

		public Task<int> CompetencyViewed(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_competency_viewed", approvePlanInputModel);
		}

		public Task<int> CompletePlan(CompletePlanInputModel completePlanInputModel)
		{
			return Post<int,CompletePlanInputModel>("core_competency_complete_plan", completePlanInputModel);
		}

		public Task<int> CountCompetencies(CountCompetenciesInputModel countCompetenciesInputModel)
		{
			return Post<int,CountCompetenciesInputModel>("core_competency_count_competencies", countCompetenciesInputModel);
		}

		public Task<int> CountCompetenciesInCourse(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_count_competencies_in_course", approvePlanInputModel);
		}

		public Task<int> CountCompetenciesInTemplate(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_count_competencies_in_template", approvePlanInputModel);
		}

		public Task<int> CountCompetencyFrameworks(CountCompetencyFrameworksInputModel countCompetencyFrameworksInputModel)
		{
			return Post<int,CountCompetencyFrameworksInputModel>("core_competency_count_competency_frameworks", countCompetencyFrameworksInputModel);
		}

		public Task<int> CountCoursesUsingCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_count_courses_using_competency", approvePlanInputModel);
		}

		public Task<int> CountTemplates(CountCompetencyFrameworksInputModel countCompetencyFrameworksInputModel)
		{
			return Post<int,CountCompetencyFrameworksInputModel>("core_competency_count_templates", countCompetencyFrameworksInputModel);
		}

		public Task<int> CountTemplatesUsingCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_count_templates_using_competency", approvePlanInputModel);
		}

		public Task<CompetencyModel> CreateCompetency(CompetencyInputModel competencyInputModel)
		{
			return Post<CompetencyModel,CompetencyInputModel>("core_competency_create_competency", competencyInputModel);
		}

		public Task<CompetencyFrameworkModel> CreateCompetencyFramework(CompetencyFrameworkInputModel competencyFrameworkInputModel)
		{
			return Post<CompetencyFrameworkModel,CompetencyFrameworkInputModel>("core_competency_create_competency_framework", competencyFrameworkInputModel);
		}

		public Task<PlanModel> CreatePlan(PlanInputModel planInputModel)
		{
			return Post<PlanModel,PlanInputModel>("core_competency_create_plan", planInputModel);
		}

		public Task<TemplateModel> CreateTemplate(TemplateInputModel templateInputModel)
		{
			return Post<TemplateModel,TemplateInputModel>("core_competency_create_template", templateInputModel);
		}

		public Task<UserEvidenceCompetencyModel> CreateUserEvidenceCompetency(UserEvidenceCompetencyInputModel userEvidenceCompetencyInputModel)
		{
			return Post<UserEvidenceCompetencyModel,UserEvidenceCompetencyInputModel>("core_competency_create_user_evidence_competency", userEvidenceCompetencyInputModel);
		}

		public Task<int> DeleteCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_delete_competency", approvePlanInputModel);
		}

		public Task<int> DeleteCompetencyFramework(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_delete_competency_framework", approvePlanInputModel);
		}

		public Task<int> DeleteEvidence(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_delete_evidence", approvePlanInputModel);
		}

		public Task<int> DeletePlan(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_delete_plan", approvePlanInputModel);
		}

		public Task<int> DeleteTemplate(DeleteTemplateInputModel deleteTemplateInputModel)
		{
			return Post<int,DeleteTemplateInputModel>("core_competency_delete_template", deleteTemplateInputModel);
		}

		public Task<int> DeleteUserEvidence(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_delete_user_evidence", approvePlanInputModel);
		}

		public Task<int> DeleteUserEvidenceCompetency(UserEvidenceCompetencyInputModel userEvidenceCompetencyInputModel)
		{
			return Post<int,UserEvidenceCompetencyInputModel>("core_competency_delete_user_evidence_competency", userEvidenceCompetencyInputModel);
		}

		public Task<CompetencyFrameworkModel> DuplicateCompetencyFramework(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<CompetencyFrameworkModel,ApprovePlanInputModel>("core_competency_duplicate_competency_framework", approvePlanInputModel);
		}

		public Task<TemplateModel> DuplicateTemplate(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<TemplateModel,ApprovePlanInputModel>("core_competency_duplicate_template", approvePlanInputModel);
		}

		public Task<ScaleValuesModel> GetScaleValues(ScaleValuesInputModel scaleValuesInputModel)
		{
			return Post<ScaleValuesModel,ScaleValuesInputModel>("core_competency_get_scale_values", scaleValuesInputModel);
		}

		public Task<GradeCompetencyModel> GradeCompetency(GradeCompetencyInputModel gradeCompetencyInputModel)
		{
			return Post<GradeCompetencyModel,GradeCompetencyInputModel>("core_competency_grade_competency", gradeCompetencyInputModel);
		}

		public Task<GradeCompetencyModel> GradeCompetencyInCourse(GradeCompetencyInCourseInputModel gradeCompetencyInCourseInputModel)
		{
			return Post<GradeCompetencyModel,GradeCompetencyInCourseInputModel>("core_competency_grade_competency_in_course", gradeCompetencyInCourseInputModel);
		}

		public Task<GradeCompetencyModel> GradeCompetencyInPlan(GradeCompetencyInPlanInputModel gradeCompetencyInPlanInputModel)
		{
			return Post<GradeCompetencyModel,GradeCompetencyInPlanInputModel>("core_competency_grade_competency_in_plan", gradeCompetencyInPlanInputModel);
		}

		public Task<CompetenciesModel> ListCompetencies(CompetenciesInputModel competenciesInputModel)
		{
			return Post<CompetenciesModel,CompetenciesInputModel>("core_competency_list_competencies", competenciesInputModel);
		}

		public Task<CompetenciesModel> ListCompetenciesInTemplate(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<CompetenciesModel,ApprovePlanInputModel>("core_competency_list_competencies_in_template", approvePlanInputModel);
		}

		public Task<CompetencyFrameworksModel> ListCompetencyFrameworks(CompetencyFrameworksInputModel competencyFrameworksInputModel)
		{
			return Post<CompetencyFrameworksModel,CompetencyFrameworksInputModel>("core_competency_list_competency_frameworks", competencyFrameworksInputModel);
		}

		public Task<CourseCompetenciesModel> ListCourseCompetencies(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<CourseCompetenciesModel,ApprovePlanInputModel>("core_competency_list_course_competencies", approvePlanInputModel);
		}

		public Task<PlanCompetenciesModel> ListPlanCompetencies(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<PlanCompetenciesModel,ApprovePlanInputModel>("core_competency_list_plan_competencies", approvePlanInputModel);
		}

		public Task<TemplatesModel> ListTemplates(TemplatesInputModel templatesInputModel)
		{
			return Post<TemplatesModel,TemplatesInputModel>("core_competency_list_templates", templatesInputModel);
		}

		public Task<TemplatesModel> ListTemplatesUsingCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<TemplatesModel,ApprovePlanInputModel>("core_competency_list_templates_using_competency", approvePlanInputModel);
		}

		public Task<UserPlansModel> ListUserPlans(UserPlansInputModel userPlansInputModel)
		{
			return Post<UserPlansModel,UserPlansInputModel>("core_competency_list_user_plans", userPlansInputModel);
		}

		public Task<int> MoveDownCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_move_down_competency", approvePlanInputModel);
		}

		public Task<int> MoveUpCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_move_up_competency", approvePlanInputModel);
		}

		public Task<int> PlanCancelReviewRequest(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_plan_cancel_review_request", approvePlanInputModel);
		}

		public Task<int> PlanRequestReview(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_plan_request_review", approvePlanInputModel);
		}

		public Task<int> PlanStartReview(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_plan_start_review", approvePlanInputModel);
		}

		public Task<int> PlanStopReview(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_plan_stop_review", approvePlanInputModel);
		}

		public Task<CompetencyModel> ReadCompetency(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<CompetencyModel,ApprovePlanInputModel>("core_competency_read_competency", approvePlanInputModel);
		}

		public Task<CompetencyFrameworkModel> ReadCompetencyFramework(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<CompetencyFrameworkModel,ApprovePlanInputModel>("core_competency_read_competency_framework", approvePlanInputModel);
		}

		public Task<PlanModel> ReadPlan(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<PlanModel,ApprovePlanInputModel>("core_competency_read_plan", approvePlanInputModel);
		}

		public Task<TemplateModel> ReadTemplate(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<TemplateModel,ApprovePlanInputModel>("core_competency_read_template", approvePlanInputModel);
		}

		public Task<ReadUserEvidenceModel> ReadUserEvidence(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<ReadUserEvidenceModel,ApprovePlanInputModel>("core_competency_read_user_evidence", approvePlanInputModel);
		}

		public Task<int> RemoveCompetencyFromCourse(CompetencyToCourseInputModel competencyToCourseInputModel)
		{
			return Post<int,CompetencyToCourseInputModel>("core_competency_remove_competency_from_course", competencyToCourseInputModel);
		}

		public Task<int> RemoveCompetencyFromPlan(CompetencyToPlanInputModel competencyToPlanInputModel)
		{
			return Post<int,CompetencyToPlanInputModel>("core_competency_remove_competency_from_plan", competencyToPlanInputModel);
		}

		public Task<int> RemoveCompetencyFromTemplate(CompetencyToTemplateInputModel competencyToTemplateInputModel)
		{
			return Post<int,CompetencyToTemplateInputModel>("core_competency_remove_competency_from_template", competencyToTemplateInputModel);
		}

		public Task<int> RemoveRelatedCompetency(RelatedCompetencyInputModel relatedCompetencyInputModel)
		{
			return Post<int,RelatedCompetencyInputModel>("core_competency_remove_related_competency", relatedCompetencyInputModel);
		}

		public Task<int> ReopenPlan(CompletePlanInputModel completePlanInputModel)
		{
			return Post<int,CompletePlanInputModel>("core_competency_reopen_plan", completePlanInputModel);
		}

		public Task<int> ReorderCourseCompetency(ReorderCourseCompetencyInputModel reorderCourseCompetencyInputModel)
		{
			return Post<int,ReorderCourseCompetencyInputModel>("core_competency_reorder_course_competency", reorderCourseCompetencyInputModel);
		}

		public Task<int> ReorderPlanCompetency(ReorderPlanCompetencyInputModel reorderPlanCompetencyInputModel)
		{
			return Post<int,ReorderPlanCompetencyInputModel>("core_competency_reorder_plan_competency", reorderPlanCompetencyInputModel);
		}

		public Task<int> ReorderTemplateCompetency(ReorderTemplateCompetencyInputModel reorderTemplateCompetencyInputModel)
		{
			return Post<int,ReorderTemplateCompetencyInputModel>("core_competency_reorder_template_competency", reorderTemplateCompetencyInputModel);
		}

		public Task<int> RequestReviewOfUserEvidenceLinkedCompetencies(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_request_review_of_user_evidence_linked_competencies", approvePlanInputModel);
		}

		public Task<CompetenciesModel> SearchCompetencies(SearchCompetenciesInputModel searchCompetenciesInputModel)
		{
			return Post<CompetenciesModel,SearchCompetenciesInputModel>("core_competency_search_competencies", searchCompetenciesInputModel);
		}

		public Task<int> SetCourseCompetencyRuleoutcome(SetCourseCompetencyRuleoutcomeInputModel setCourseCompetencyRuleoutcomeInputModel)
		{
			return Post<int,SetCourseCompetencyRuleoutcomeInputModel>("core_competency_set_course_competency_ruleoutcome", setCourseCompetencyRuleoutcomeInputModel);
		}

		public Task<int> SetParentCompetency(SetParentCompetencyInputModel setParentCompetencyInputModel)
		{
			return Post<int,SetParentCompetencyInputModel>("core_competency_set_parent_competency", setParentCompetencyInputModel);
		}

		public Task<int> TemplateHasRelatedData(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_template_has_related_data", approvePlanInputModel);
		}

		public Task<int> TemplateViewed(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_template_viewed", approvePlanInputModel);
		}

		public Task<int> UnapprovePlan(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<int,ApprovePlanInputModel>("core_competency_unapprove_plan", approvePlanInputModel);
		}

		public Task<int> UnlinkPlanFromTemplate(CompletePlanInputModel completePlanInputModel)
		{
			return Post<int,CompletePlanInputModel>("core_competency_unlink_plan_from_template", completePlanInputModel);
		}

		public Task<int> UpdateCompetency(CompetencyInputModel competencyInputModel)
		{
			return Post<int,CompetencyInputModel>("core_competency_update_competency", competencyInputModel);
		}

		public Task<int> UpdateCompetencyFramework(CompetencyFrameworkInputModel competencyFrameworkInputModel)
		{
			return Post<int,CompetencyFrameworkInputModel>("core_competency_update_competency_framework", competencyFrameworkInputModel);
		}

		public Task<int> UpdateCourseCompetencySettings(CourseCompetencySettingsInputModel courseCompetencySettingsInputModel)
		{
			return Post<int,CourseCompetencySettingsInputModel>("core_competency_update_course_competency_settings", courseCompetencySettingsInputModel);
		}

		public Task<PlanModel> UpdatePlan(PlanInputModel planInputModel)
		{
			return Post<PlanModel,PlanInputModel>("core_competency_update_plan", planInputModel);
		}

		public Task<int> UpdateTemplate(TemplateInputModel templateInputModel)
		{
			return Post<int,TemplateInputModel>("core_competency_update_template", templateInputModel);
		}

		public Task<int> UserCompetencyCancelReviewRequest(UserCompetencyCancelReviewRequestInputModel userCompetencyCancelReviewRequestInputModel)
		{
			return Post<int,UserCompetencyCancelReviewRequestInputModel>("core_competency_user_competency_cancel_review_request", userCompetencyCancelReviewRequestInputModel);
		}

		public Task<int> UserCompetencyPlanViewed(UserCompetencyPlanViewedInputModel userCompetencyPlanViewedInputModel)
		{
			return Post<int,UserCompetencyPlanViewedInputModel>("core_competency_user_competency_plan_viewed", userCompetencyPlanViewedInputModel);
		}

		public Task<int> UserCompetencyRequestReview(UserCompetencyCancelReviewRequestInputModel userCompetencyCancelReviewRequestInputModel)
		{
			return Post<int,UserCompetencyCancelReviewRequestInputModel>("core_competency_user_competency_request_review", userCompetencyCancelReviewRequestInputModel);
		}

		public Task<int> UserCompetencyStartReview(UserCompetencyCancelReviewRequestInputModel userCompetencyCancelReviewRequestInputModel)
		{
			return Post<int,UserCompetencyCancelReviewRequestInputModel>("core_competency_user_competency_start_review", userCompetencyCancelReviewRequestInputModel);
		}

		public Task<int> UserCompetencyStopReview(UserCompetencyCancelReviewRequestInputModel userCompetencyCancelReviewRequestInputModel)
		{
			return Post<int,UserCompetencyCancelReviewRequestInputModel>("core_competency_user_competency_stop_review", userCompetencyCancelReviewRequestInputModel);
		}

		public Task<int> UserCompetencyViewed(UserCompetencyViewedInputModel userCompetencyViewedInputModel)
		{
			return Post<int,UserCompetencyViewedInputModel>("core_competency_user_competency_viewed", userCompetencyViewedInputModel);
		}

		public Task<int> UserCompetencyViewedInCourse(UserCompetencyViewedInCourseInputModel userCompetencyViewedInCourseInputModel)
		{
			return Post<int,UserCompetencyViewedInCourseInputModel>("core_competency_user_competency_viewed_in_course", userCompetencyViewedInCourseInputModel);
		}

		public Task<int> UserCompetencyViewedInPlan(UserCompetencyPlanViewedInputModel userCompetencyPlanViewedInputModel)
		{
			return Post<int,UserCompetencyPlanViewedInputModel>("core_competency_user_competency_viewed_in_plan", userCompetencyPlanViewedInputModel);
		}

		//Function Placeholder

	}
}