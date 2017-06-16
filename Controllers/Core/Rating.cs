using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Rating : BaseController
	{

		public Rating() : base()
		{
		}

		public Rating(string token, string url) : base(token, url)
		{
		}

		public RatingModel AddRating(RatingInputModel ratingInputModel)
		{
			return Post<RatingModel,RatingInputModel>("core_rating_add_rating", ratingInputModel);
		}

		public ItemRatingsModel GetItemRatings(ItemRatingsInputModel itemRatingsInputModel)
		{
			return Post<ItemRatingsModel,ItemRatingsInputModel>("core_rating_get_item_ratings", itemRatingsInputModel);
		}

		//Function Placeholder

	}
}