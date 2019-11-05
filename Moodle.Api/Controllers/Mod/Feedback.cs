using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Feedback : BaseController
	{

		public Feedback() : base()
		{
		}

		public Feedback(string token, string url) : base(token, url)
		{
		}

		public Task<AnalysisModel> GetAnalysis(AnalysisInputModel analysisInputModel)
		{
			return Post<AnalysisModel,AnalysisInputModel>("mod_feedback_get_analysis", analysisInputModel);
		}

		public Task<CurrentCompletedTmpModel> GetCurrentCompletedTmp(CurrentCompletedTmpInputModel currentCompletedTmpInputModel)
		{
			return Post<CurrentCompletedTmpModel,CurrentCompletedTmpInputModel>("mod_feedback_get_current_completed_tmp", currentCompletedTmpInputModel);
		}

		public Task<FeedbackAccessInformationModel> GetFeedbackAccessInformation(CurrentCompletedTmpInputModel currentCompletedTmpInputModel)
		{
			return Post<FeedbackAccessInformationModel,CurrentCompletedTmpInputModel>("mod_feedback_get_feedback_access_information", currentCompletedTmpInputModel);
		}

		public Task<FeedbacksByCoursesModel> GetFeedbacksByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<FeedbacksByCoursesModel,DeleteCoursesInputModel>("mod_feedback_get_feedbacks_by_courses", deleteCoursesInputModel);
		}

		public Task<FinishedResponsesModel> GetFinishedResponses(CurrentCompletedTmpInputModel currentCompletedTmpInputModel)
		{
			return Post<FinishedResponsesModel,CurrentCompletedTmpInputModel>("mod_feedback_get_finished_responses", currentCompletedTmpInputModel);
		}

		public Task<ItemsModel> GetItems(CurrentCompletedTmpInputModel currentCompletedTmpInputModel)
		{
			return Post<ItemsModel,CurrentCompletedTmpInputModel>("mod_feedback_get_items", currentCompletedTmpInputModel);
		}

		public Task<LastCompletedModel> GetLastCompleted(CurrentCompletedTmpInputModel currentCompletedTmpInputModel)
		{
			return Post<LastCompletedModel,CurrentCompletedTmpInputModel>("mod_feedback_get_last_completed", currentCompletedTmpInputModel);
		}

		public Task<NonRespondentsModel> GetNonRespondents(NonRespondentsInputModel nonRespondentsInputModel)
		{
			return Post<NonRespondentsModel,NonRespondentsInputModel>("mod_feedback_get_non_respondents", nonRespondentsInputModel);
		}

		public Task<PageItemsModel> GetPageItems(PageItemsInputModel pageItemsInputModel)
		{
			return Post<PageItemsModel,PageItemsInputModel>("mod_feedback_get_page_items", pageItemsInputModel);
		}

		public Task<ResponsesAnalysisModel> GetResponsesAnalysis(ResponsesAnalysisInputModel responsesAnalysisInputModel)
		{
			return Post<ResponsesAnalysisModel,ResponsesAnalysisInputModel>("mod_feedback_get_responses_analysis", responsesAnalysisInputModel);
		}

		public Task<FinishedResponsesModel> GetUnfinishedResponses(CurrentCompletedTmpInputModel currentCompletedTmpInputModel)
		{
			return Post<FinishedResponsesModel,CurrentCompletedTmpInputModel>("mod_feedback_get_unfinished_responses", currentCompletedTmpInputModel);
		}

		public Task<LaunchFeedbackModel> LaunchFeedback(CurrentCompletedTmpInputModel currentCompletedTmpInputModel)
		{
			return Post<LaunchFeedbackModel,CurrentCompletedTmpInputModel>("mod_feedback_launch_feedback", currentCompletedTmpInputModel);
		}

		public Task<ProcessPageModel> ProcessPage(ProcessPageInputModel processPageInputModel)
		{
			return Post<ProcessPageModel,ProcessPageInputModel>("mod_feedback_process_page", processPageInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewFeedback(ViewFeedbackInputModel viewFeedbackInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewFeedbackInputModel>("mod_feedback_view_feedback", viewFeedbackInputModel);
		}

		//Function Placeholder

	}
}