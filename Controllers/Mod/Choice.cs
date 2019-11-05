using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Choice : BaseController
	{

		public Choice() : base()
		{
		}

		public Choice(string token, string url) : base(token, url)
		{
		}

		public MarkCourseSelfCompletedModel DeleteChoiceResponses(DeleteChoiceResponsesInputModel deleteChoiceResponsesInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,DeleteChoiceResponsesInputModel>("mod_choice_delete_choice_responses", deleteChoiceResponsesInputModel);
		}

		public ChoiceOptionsModel GetChoiceOptions(ChoiceOptionsInputModel choiceOptionsInputModel)
		{
			return Post<ChoiceOptionsModel,ChoiceOptionsInputModel>("mod_choice_get_choice_options", choiceOptionsInputModel);
		}

		public ChoiceResultsModel GetChoiceResults(ChoiceOptionsInputModel choiceOptionsInputModel)
		{
			return Post<ChoiceResultsModel,ChoiceOptionsInputModel>("mod_choice_get_choice_results", choiceOptionsInputModel);
		}

		public ChoicesByCoursesModel GetChoicesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ChoicesByCoursesModel,DeleteCoursesInputModel>("mod_choice_get_choices_by_courses", deleteCoursesInputModel);
		}

		public SubmitChoiceResponseModel SubmitChoiceResponse(DeleteChoiceResponsesInputModel deleteChoiceResponsesInputModel)
		{
			return Post<SubmitChoiceResponseModel,DeleteChoiceResponsesInputModel>("mod_choice_submit_choice_response", deleteChoiceResponsesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewChoice(ChoiceOptionsInputModel choiceOptionsInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ChoiceOptionsInputModel>("mod_choice_view_choice", choiceOptionsInputModel);
		}

		//Function Placeholder

	}
}