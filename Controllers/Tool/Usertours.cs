using System.Threading.Tasks;
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

		public Task<CompleteTourModel> CompleteTour(CompleteTourInputModel completeTourInputModel)
		{
			return Post<CompleteTourModel,CompleteTourInputModel>("tool_usertours_complete_tour", completeTourInputModel);
		}

		public Task<FetchAndStartTourModel> FetchAndStartTour(FetchAndStartTourInputModel fetchAndStartTourInputModel)
		{
			return Post<FetchAndStartTourModel,FetchAndStartTourInputModel>("tool_usertours_fetch_and_start_tour", fetchAndStartTourInputModel);
		}

		public Task<ResetTourModel> ResetTour(FetchAndStartTourInputModel fetchAndStartTourInputModel)
		{
			return Post<ResetTourModel,FetchAndStartTourInputModel>("tool_usertours_reset_tour", fetchAndStartTourInputModel);
		}

		public Task<CompleteTourModel> StepShown(CompleteTourInputModel completeTourInputModel)
		{
			return Post<CompleteTourModel,CompleteTourInputModel>("tool_usertours_step_shown", completeTourInputModel);
		}

		//Function Placeholder

	}
}