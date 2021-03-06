using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Grading : BaseController
	{

		public Grading() : base()
		{
		}

		public Grading(string token, string url) : base(token, url)
		{
		}

		public DefinitionsModel GetDefinitions(DefinitionsInputModel definitionsInputModel)
		{
			return Post<DefinitionsModel,DefinitionsInputModel>("core_grading_get_definitions", definitionsInputModel);
		}

		public GradingformInstancesModel GetGradingformInstances(GradingformInstancesInputModel gradingformInstancesInputModel)
		{
			return Post<GradingformInstancesModel,GradingformInstancesInputModel>("core_grading_get_gradingform_instances", gradingformInstancesInputModel);
		}

		public void SaveDefinitions(SaveDefinitionsInputModel saveDefinitionsInputModel)
		{
			Post<SaveDefinitionsInputModel>("core_grading_save_definitions", saveDefinitionsInputModel);
		}

		//Function Placeholder

	}
}