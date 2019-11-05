using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Book : BaseController
	{

		public Book() : base()
		{
		}

		public Book(string token, string url) : base(token, url)
		{
		}

		public Task<BooksByCoursesModel> GetBooksByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<BooksByCoursesModel,DeleteCoursesInputModel>("mod_book_get_books_by_courses", deleteCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewBook(ViewBookInputModel viewBookInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewBookInputModel>("mod_book_view_book", viewBookInputModel);
		}

		//Function Placeholder

	}
}