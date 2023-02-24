using System.Threading.Tasks;
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

		public Task<MarkCourseSelfCompletedModel> DeleteChoiceResponses(DeleteChoiceResponsesInputModel deleteChoiceResponsesInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,DeleteChoiceResponsesInputModel>("mod_choice_delete_choice_responses", deleteChoiceResponsesInputModel);
		}

		public Task<ChoiceOptionsModel> GetChoiceOptions(ChoiceOptionsInputModel choiceOptionsInputModel)
		{
			return Post<ChoiceOptionsModel,ChoiceOptionsInputModel>("mod_choice_get_choice_options", choiceOptionsInputModel);
		}

		public Task<ChoiceResultsModel> GetChoiceResults(ChoiceOptionsInputModel choiceOptionsInputModel)
		{
			return Post<ChoiceResultsModel,ChoiceOptionsInputModel>("mod_choice_get_choice_results", choiceOptionsInputModel);
		}

		public Task<ChoicesByCoursesModel> GetChoicesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ChoicesByCoursesModel,DeleteCoursesInputModel>("mod_choice_get_choices_by_courses", deleteCoursesInputModel);
		}

		public Task<SubmitChoiceResponseModel> SubmitChoiceResponse(DeleteChoiceResponsesInputModel deleteChoiceResponsesInputModel)
		{
			return Post<SubmitChoiceResponseModel,DeleteChoiceResponsesInputModel>("mod_choice_submit_choice_response", deleteChoiceResponsesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewChoice(ChoiceOptionsInputModel choiceOptionsInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ChoiceOptionsInputModel>("mod_choice_view_choice", choiceOptionsInputModel);
		}

		//Function Placeholder

	}
}