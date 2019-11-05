using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Block : BaseController
	{

		public Block() : base()
		{
		}

		public Block(string token, string url) : base(token, url)
		{
		}

		public Task<CourseBlocksModel> GetCourseBlocks(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<CourseBlocksModel,CourseBlocksInputModel>("core_block_get_course_blocks", courseBlocksInputModel);
		}

		//Function Placeholder

	}
}