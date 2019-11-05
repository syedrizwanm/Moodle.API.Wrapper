using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Survey : BaseController
	{

		public Survey() : base()
		{
		}

		public Survey(string token, string url) : base(token, url)
		{
		}

		public QuestionsModel GetQuestions(QuestionsInputModel questionsInputModel)
		{
			return Post<QuestionsModel,QuestionsInputModel>("mod_survey_get_questions", questionsInputModel);
		}

		public SurveysByCoursesModel GetSurveysByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<SurveysByCoursesModel,DeleteCoursesInputModel>("mod_survey_get_surveys_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel SubmitAnswers(SubmitAnswersInputModel submitAnswersInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,SubmitAnswersInputModel>("mod_survey_submit_answers", submitAnswersInputModel);
		}

		public MarkCourseSelfCompletedModel ViewSurvey(QuestionsInputModel questionsInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,QuestionsInputModel>("mod_survey_view_survey", questionsInputModel);
		}

		//Function Placeholder

	}
}