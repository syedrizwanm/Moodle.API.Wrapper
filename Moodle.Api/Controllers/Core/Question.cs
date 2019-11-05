using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Question : BaseController
	{

		public Question() : base()
		{
		}

		public Question(string token, string url) : base(token, url)
		{
		}

		public Task<MarkCourseSelfCompletedModel> UpdateFlag(FlagInputModel flagInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,FlagInputModel>("core_question_update_flag", flagInputModel);
		}

		//Function Placeholder

	}
}