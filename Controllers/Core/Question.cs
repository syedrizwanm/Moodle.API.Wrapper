using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Question : BaseController
	{

		public Question() : base()
		{
		}

		public Question(string token, string url) : base(token, url)
		{
		}

		public MarkCourseSelfCompletedModel UpdateFlag(FlagInputModel flagInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,FlagInputModel>("core_question_update_flag", flagInputModel);
		}

		//Function Placeholder

	}
}