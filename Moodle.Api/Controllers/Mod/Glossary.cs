using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Glossary : BaseController
	{

		public Glossary() : base()
		{
		}

		public Glossary(string token, string url) : base(token, url)
		{
		}

		public Task<AddEntry> AddEntry(AddEntryInputModel addEntryInputModel)
		{
			return Post<AddEntry,AddEntryInputModel>("mod_glossary_add_entry", addEntryInputModel);
		}

		public Task<AuthorsModel> GetAuthors(AuthorsInputModel authorsInputModel)
		{
			return Post<AuthorsModel,AuthorsInputModel>("mod_glossary_get_authors", authorsInputModel);
		}

		public Task<CategoriesModel> GetCategories(CategoriesInputModel categoriesInputModel)
		{
			return Post<CategoriesModel,CategoriesInputModel>("mod_glossary_get_categories", categoriesInputModel);
		}

		public Task<EntriesByAuthorModel> GetEntriesByAuthor(EntriesByAuthorInputModel entriesByAuthorInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByAuthorInputModel>("mod_glossary_get_entries_by_author", entriesByAuthorInputModel);
		}

		public Task<EntriesByAuthorModel> GetEntriesByAuthorId(EntriesByAuthorIdInputModel entriesByAuthorIdInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByAuthorIdInputModel>("mod_glossary_get_entries_by_author_id", entriesByAuthorIdInputModel);
		}

		public Task<EntriesByCategoryModel> GetEntriesByCategory(EntriesByCategoryInputModel entriesByCategoryInputModel)
		{
			return Post<EntriesByCategoryModel,EntriesByCategoryInputModel>("mod_glossary_get_entries_by_category", entriesByCategoryInputModel);
		}

		public Task<EntriesByAuthorModel> GetEntriesByDate(EntriesByDateInputModel entriesByDateInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByDateInputModel>("mod_glossary_get_entries_by_date", entriesByDateInputModel);
		}

		public Task<EntriesByAuthorModel> GetEntriesByLetter(EntriesByLetterInputModel entriesByLetterInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByLetterInputModel>("mod_glossary_get_entries_by_letter", entriesByLetterInputModel);
		}

		public Task<EntriesByAuthorModel> GetEntriesBySearch(EntriesBySearchInputModel entriesBySearchInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesBySearchInputModel>("mod_glossary_get_entries_by_search", entriesBySearchInputModel);
		}

		public Task<EntriesByAuthorModel> GetEntriesByTerm(EntriesByTermInputModel entriesByTermInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByTermInputModel>("mod_glossary_get_entries_by_term", entriesByTermInputModel);
		}

		public Task<EntriesByAuthorModel> GetEntriesToApprove(EntriesToApproveInputModel entriesToApproveInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesToApproveInputModel>("mod_glossary_get_entries_to_approve", entriesToApproveInputModel);
		}

		public Task<EntryByIdModel> GetEntryById(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<EntryByIdModel,ApprovePlanInputModel>("mod_glossary_get_entry_by_id", approvePlanInputModel);
		}

		public Task<GlossariesByCoursesModel> GetGlossariesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<GlossariesByCoursesModel,DeleteCoursesInputModel>("mod_glossary_get_glossaries_by_courses", deleteCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewEntry(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ApprovePlanInputModel>("mod_glossary_view_entry", approvePlanInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewGlossary(ViewGlossaryInputModel viewGlossaryInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewGlossaryInputModel>("mod_glossary_view_glossary", viewGlossaryInputModel);
		}

		//Function Placeholder

	}
}