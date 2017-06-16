using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Glossary : BaseController
	{

		public Glossary() : base()
		{
		}

		public Glossary(string token, string url) : base(token, url)
		{
		}

		public AddEntry AddEntry(AddEntryInputModel addEntryInputModel)
		{
			return Post<AddEntry,AddEntryInputModel>("mod_glossary_add_entry", addEntryInputModel);
		}

		public AuthorsModel GetAuthors(AuthorsInputModel authorsInputModel)
		{
			return Post<AuthorsModel,AuthorsInputModel>("mod_glossary_get_authors", authorsInputModel);
		}

		public CategoriesModel GetCategories(CategoriesInputModel categoriesInputModel)
		{
			return Post<CategoriesModel,CategoriesInputModel>("mod_glossary_get_categories", categoriesInputModel);
		}

		public EntriesByAuthorModel GetEntriesByAuthor(EntriesByAuthorInputModel entriesByAuthorInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByAuthorInputModel>("mod_glossary_get_entries_by_author", entriesByAuthorInputModel);
		}

		public EntriesByAuthorModel GetEntriesByAuthorId(EntriesByAuthorIdInputModel entriesByAuthorIdInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByAuthorIdInputModel>("mod_glossary_get_entries_by_author_id", entriesByAuthorIdInputModel);
		}

		public EntriesByCategoryModel GetEntriesByCategory(EntriesByCategoryInputModel entriesByCategoryInputModel)
		{
			return Post<EntriesByCategoryModel,EntriesByCategoryInputModel>("mod_glossary_get_entries_by_category", entriesByCategoryInputModel);
		}

		public EntriesByAuthorModel GetEntriesByDate(EntriesByDateInputModel entriesByDateInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByDateInputModel>("mod_glossary_get_entries_by_date", entriesByDateInputModel);
		}

		public EntriesByAuthorModel GetEntriesByLetter(EntriesByLetterInputModel entriesByLetterInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByLetterInputModel>("mod_glossary_get_entries_by_letter", entriesByLetterInputModel);
		}

		public EntriesByAuthorModel GetEntriesBySearch(EntriesBySearchInputModel entriesBySearchInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesBySearchInputModel>("mod_glossary_get_entries_by_search", entriesBySearchInputModel);
		}

		public EntriesByAuthorModel GetEntriesByTerm(EntriesByTermInputModel entriesByTermInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesByTermInputModel>("mod_glossary_get_entries_by_term", entriesByTermInputModel);
		}

		public EntriesByAuthorModel GetEntriesToApprove(EntriesToApproveInputModel entriesToApproveInputModel)
		{
			return Post<EntriesByAuthorModel,EntriesToApproveInputModel>("mod_glossary_get_entries_to_approve", entriesToApproveInputModel);
		}

		public EntryByIdModel GetEntryById(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<EntryByIdModel,ApprovePlanInputModel>("mod_glossary_get_entry_by_id", approvePlanInputModel);
		}

		public GlossariesByCoursesModel GetGlossariesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<GlossariesByCoursesModel,DeleteCoursesInputModel>("mod_glossary_get_glossaries_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewEntry(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ApprovePlanInputModel>("mod_glossary_view_entry", approvePlanInputModel);
		}

		public MarkCourseSelfCompletedModel ViewGlossary(ViewGlossaryInputModel viewGlossaryInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewGlossaryInputModel>("mod_glossary_view_glossary", viewGlossaryInputModel);
		}

		//Function Placeholder

	}
}