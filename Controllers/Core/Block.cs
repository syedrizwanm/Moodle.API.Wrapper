using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Block : BaseController
	{

		public Block() : base()
		{
		}

		public Block(string token, string url) : base(token, url)
		{
		}

		public CourseBlocksModel GetCourseBlocks(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<CourseBlocksModel,CourseBlocksInputModel>("core_block_get_course_blocks", courseBlocksInputModel);
		}

		//Function Placeholder

	}
}