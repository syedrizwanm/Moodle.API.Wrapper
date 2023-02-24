using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Grading : BaseController
	{

		public Grading() : base()
		{
		}

		public Grading(string token, string url) : base(token, url)
		{
		}

		public Task<DefinitionsModel> GetDefinitions(DefinitionsInputModel definitionsInputModel)
		{
			return Post<DefinitionsModel,DefinitionsInputModel>("core_grading_get_definitions", definitionsInputModel);
		}

		public Task<GradingformInstancesModel> GetGradingformInstances(GradingformInstancesInputModel gradingformInstancesInputModel)
		{
			return Post<GradingformInstancesModel,GradingformInstancesInputModel>("core_grading_get_gradingform_instances", gradingformInstancesInputModel);
		}

		public Task SaveDefinitions(SaveDefinitionsInputModel saveDefinitionsInputModel)
		{
			return Post<SaveDefinitionsInputModel>("core_grading_save_definitions", saveDefinitionsInputModel);
		}

		//Function Placeholder

	}
}