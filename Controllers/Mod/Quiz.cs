using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Quiz : BaseController
	{

		public Quiz() : base()
		{
		}

		public Quiz(string token, string url) : base(token, url)
		{
		}

		public AttemptAccessInformationModel GetAttemptAccessInformation(AttemptAccessInformationInputModel attemptAccessInformationInputModel)
		{
			return Post<AttemptAccessInformationModel,AttemptAccessInformationInputModel>("mod_quiz_get_attempt_access_information", attemptAccessInformationInputModel);
		}

		public AttemptDataModel GetAttemptData(AttemptDataInputModel attemptDataInputModel)
		{
			return Post<AttemptDataModel,AttemptDataInputModel>("mod_quiz_get_attempt_data", attemptDataInputModel);
		}

		public AttemptReviewModel GetAttemptReview(AttemptReviewInputModel attemptReviewInputModel)
		{
			return Post<AttemptReviewModel,AttemptReviewInputModel>("mod_quiz_get_attempt_review", attemptReviewInputModel);
		}

		public AttemptSummaryModel GetAttemptSummary(AttemptSummaryInputModel attemptSummaryInputModel)
		{
			return Post<AttemptSummaryModel,AttemptSummaryInputModel>("mod_quiz_get_attempt_summary", attemptSummaryInputModel);
		}

		public CombinedReviewOptionsModel GetCombinedReviewOptions(CombinedReviewOptionsInputModel combinedReviewOptionsInputModel)
		{
			return Post<CombinedReviewOptionsModel,CombinedReviewOptionsInputModel>("mod_quiz_get_combined_review_options", combinedReviewOptionsInputModel);
		}

		public QuizAccessInformationModel GetQuizAccessInformation(QuizAccessInformationInputModel quizAccessInformationInputModel)
		{
			return Post<QuizAccessInformationModel,QuizAccessInformationInputModel>("mod_quiz_get_quiz_access_information", quizAccessInformationInputModel);
		}

		public QuizFeedbackForGradeModel GetQuizFeedbackForGrade(QuizFeedbackForGradeInputModel quizFeedbackForGradeInputModel)
		{
			return Post<QuizFeedbackForGradeModel,QuizFeedbackForGradeInputModel>("mod_quiz_get_quiz_feedback_for_grade", quizFeedbackForGradeInputModel);
		}

		public QuizRequiredQtypesModel GetQuizRequiredQtypes(QuizAccessInformationInputModel quizAccessInformationInputModel)
		{
			return Post<QuizRequiredQtypesModel,QuizAccessInformationInputModel>("mod_quiz_get_quiz_required_qtypes", quizAccessInformationInputModel);
		}

		public QuizzesByCoursesModel GetQuizzesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<QuizzesByCoursesModel,DeleteCoursesInputModel>("mod_quiz_get_quizzes_by_courses", deleteCoursesInputModel);
		}

		public UserAttemptsModel GetUserAttempts(UserAttemptsInputModel userAttemptsInputModel)
		{
			return Post<UserAttemptsModel,UserAttemptsInputModel>("mod_quiz_get_user_attempts", userAttemptsInputModel);
		}

		public UserBestGradeModel GetUserBestGrade(CombinedReviewOptionsInputModel combinedReviewOptionsInputModel)
		{
			return Post<UserBestGradeModel,CombinedReviewOptionsInputModel>("mod_quiz_get_user_best_grade", combinedReviewOptionsInputModel);
		}

		public ProcessAttemptModel ProcessAttempt(ProcessAttemptInputModel processAttemptInputModel)
		{
			return Post<ProcessAttemptModel,ProcessAttemptInputModel>("mod_quiz_process_attempt", processAttemptInputModel);
		}

		public MarkCourseSelfCompletedModel SaveAttempt(SaveAttemptInputModel saveAttemptInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,SaveAttemptInputModel>("mod_quiz_save_attempt", saveAttemptInputModel);
		}

		public StartAttemptModel StartAttempt(StartAttemptInputModel startAttemptInputModel)
		{
			return Post<StartAttemptModel,StartAttemptInputModel>("mod_quiz_start_attempt", startAttemptInputModel);
		}

		public MarkCourseSelfCompletedModel ViewAttempt(AttemptDataInputModel attemptDataInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,AttemptDataInputModel>("mod_quiz_view_attempt", attemptDataInputModel);
		}

		public MarkCourseSelfCompletedModel ViewAttemptReview(ViewAttemptReviewInputModel viewAttemptReviewInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewAttemptReviewInputModel>("mod_quiz_view_attempt_review", viewAttemptReviewInputModel);
		}

		public MarkCourseSelfCompletedModel ViewAttemptSummary(AttemptSummaryInputModel attemptSummaryInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,AttemptSummaryInputModel>("mod_quiz_view_attempt_summary", attemptSummaryInputModel);
		}

		public MarkCourseSelfCompletedModel ViewQuiz(QuizAccessInformationInputModel quizAccessInformationInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,QuizAccessInformationInputModel>("mod_quiz_view_quiz", quizAccessInformationInputModel);
		}

		//Function Placeholder

	}
}