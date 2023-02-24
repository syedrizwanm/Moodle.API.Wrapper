using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Comment : BaseController
	{

		public Comment() : base()
		{
		}

		public Comment(string token, string url) : base(token, url)
		{
		}

		public Task<CommentsModel> GetComments(CommentsInputModel commentsInputModel)
		{
			return Post<CommentsModel,CommentsInputModel>("core_comment_get_comments", commentsInputModel);
		}

		//Function Placeholder

	}
}