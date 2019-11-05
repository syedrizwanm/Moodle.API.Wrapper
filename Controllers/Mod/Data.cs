using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Data : BaseController
	{

		public Data() : base()
		{
		}

		public Data(string token, string url) : base(token, url)
		{
		}

		public EntryModel AddEntry(EntryInputModel entryInputModel)
		{
			return Post<EntryModel,EntryInputModel>("mod_data_add_entry", entryInputModel);
		}

		public MarkCourseSelfCompletedModel ApproveEntry(ApproveEntryInputModel approveEntryInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ApproveEntryInputModel>("mod_data_approve_entry", approveEntryInputModel);
		}

		public MarkCourseSelfCompletedModel DeleteEntry(DeleteEntryInputModel deleteEntryInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,DeleteEntryInputModel>("mod_data_delete_entry", deleteEntryInputModel);
		}

		public DataAccessInformationModel GetDataAccessInformation(DataAccessInformationInputModel dataAccessInformationInputModel)
		{
			return Post<DataAccessInformationModel,DataAccessInformationInputModel>("mod_data_get_data_access_information", dataAccessInformationInputModel);
		}

		public DatabasesByCoursesModel GetDatabasesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<DatabasesByCoursesModel,DeleteCoursesInputModel>("mod_data_get_databases_by_courses", deleteCoursesInputModel);
		}

		public EntriesModel GetEntries(EntriesInputModel entriesInputModel)
		{
			return Post<EntriesModel,EntriesInputModel>("mod_data_get_entries", entriesInputModel);
		}

		public GetEntry GetEntry(GetEntryInputModel getEntryInputModel)
		{
			return Post<GetEntry,GetEntryInputModel>("mod_data_get_entry", getEntryInputModel);
		}

		public FieldsModel GetFields(FieldsInputModel fieldsInputModel)
		{
			return Post<FieldsModel,FieldsInputModel>("mod_data_get_fields", fieldsInputModel);
		}

		public SearchEntriesModel SearchEntries(SearchEntriesInputModel searchEntriesInputModel)
		{
			return Post<SearchEntriesModel,SearchEntriesInputModel>("mod_data_search_entries", searchEntriesInputModel);
		}

		public UpdateEntry UpdateEntry(UpdateEntryInputModel updateEntryInputModel)
		{
			return Post<UpdateEntry,UpdateEntryInputModel>("mod_data_update_entry", updateEntryInputModel);
		}

		public MarkCourseSelfCompletedModel ViewDatabase(FieldsInputModel fieldsInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,FieldsInputModel>("mod_data_view_database", fieldsInputModel);
		}

		//Function Placeholder

	}
}