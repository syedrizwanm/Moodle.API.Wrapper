using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Tag : BaseController
	{

		public Tag() : base()
		{
		}

		public Tag(string token, string url) : base(token, url)
		{
		}

		public TagindexModel GetTagindex(TagindexInputModel tagindexInputModel)
		{
			return Post<TagindexModel,TagindexInputModel>("core_tag_get_tagindex", tagindexInputModel);
		}

		public TagsModel GetTags(TagsInputModel tagsInputModel)
		{
			return Post<TagsModel,TagsInputModel>("core_tag_get_tags", tagsInputModel);
		}

		public CohortMembersModel UpdateTags(TagsInputModel tagsInputModel)
		{
			return Post<CohortMembersModel,TagsInputModel>("core_tag_update_tags", tagsInputModel);
		}

		//Function Placeholder

	}
}