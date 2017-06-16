using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Book : BaseController
	{

		public Book() : base()
		{
		}

		public Book(string token, string url) : base(token, url)
		{
		}

		public BooksByCoursesModel GetBooksByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<BooksByCoursesModel,DeleteCoursesInputModel>("mod_book_get_books_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewBook(ViewBookInputModel viewBookInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewBookInputModel>("mod_book_view_book", viewBookInputModel);
		}

		//Function Placeholder

	}
}