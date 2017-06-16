using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Comment : BaseController
	{

		public Comment() : base()
		{
		}

		public Comment(string token, string url) : base(token, url)
		{
		}

		public CommentsModel GetComments(CommentsInputModel commentsInputModel)
		{
			return Post<CommentsModel,CommentsInputModel>("core_comment_get_comments", commentsInputModel);
		}

		//Function Placeholder

	}
}