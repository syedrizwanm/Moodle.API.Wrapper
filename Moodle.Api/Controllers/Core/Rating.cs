using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Rating : BaseController
	{

		public Rating() : base()
		{
		}

		public Rating(string token, string url) : base(token, url)
		{
		}

		public Task<RatingModel> AddRating(RatingInputModel ratingInputModel)
		{
			return Post<RatingModel,RatingInputModel>("core_rating_add_rating", ratingInputModel);
		}

		public Task<ItemRatingsModel> GetItemRatings(ItemRatingsInputModel itemRatingsInputModel)
		{
			return Post<ItemRatingsModel,ItemRatingsInputModel>("core_rating_get_item_ratings", itemRatingsInputModel);
		}

		//Function Placeholder

	}
}