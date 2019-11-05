using Moodle.Api.Models.Tool;

namespace Moodle.Api.Controllers.Tool
{
	public sealed class Usertours : BaseController
	{

		public Usertours() : base()
		{
		}

		public Usertours(string token, string url) : base(token, url)
		{
		}

		public CompleteTourModel CompleteTour(CompleteTourInputModel completeTourInputModel)
		{
			return Post<CompleteTourModel,CompleteTourInputModel>("tool_usertours_complete_tour", completeTourInputModel);
		}

		public FetchAndStartTourModel FetchAndStartTour(FetchAndStartTourInputModel fetchAndStartTourInputModel)
		{
			return Post<FetchAndStartTourModel,FetchAndStartTourInputModel>("tool_usertours_fetch_and_start_tour", fetchAndStartTourInputModel);
		}

		public ResetTourModel ResetTour(FetchAndStartTourInputModel fetchAndStartTourInputModel)
		{
			return Post<ResetTourModel,FetchAndStartTourInputModel>("tool_usertours_reset_tour", fetchAndStartTourInputModel);
		}

		public CompleteTourModel StepShown(CompleteTourInputModel completeTourInputModel)
		{
			return Post<CompleteTourModel,CompleteTourInputModel>("tool_usertours_step_shown", completeTourInputModel);
		}

		//Function Placeholder

	}
}