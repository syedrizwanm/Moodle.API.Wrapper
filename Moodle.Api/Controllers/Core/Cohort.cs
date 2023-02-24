using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Cohort : BaseController
	{

		public Cohort() : base()
		{
		}

		public Cohort(string token, string url) : base(token, url)
		{
		}

		public Task<CohortMembersModel> AddCohortMembers(CohortMembersInputModel cohortMembersInputModel)
		{
			return Post<CohortMembersModel,CohortMembersInputModel>("core_cohort_add_cohort_members", cohortMembersInputModel);
		}

		public Task<CohortsModel> CreateCohorts(CohortsInputModel cohortsInputModel)
		{
			return Post<CohortsModel,CohortsInputModel>("core_cohort_create_cohorts", cohortsInputModel);
		}

		public Task DeleteCohortMembers(DeleteCohortMembersInputModel deleteCohortMembersInputModel)
		{
			return Post<DeleteCohortMembersInputModel>("core_cohort_delete_cohort_members", deleteCohortMembersInputModel);
		}

		public Task DeleteCohorts(DeleteCohortsInputModel deleteCohortsInputModel)
		{
			return Post<DeleteCohortsInputModel>("core_cohort_delete_cohorts", deleteCohortsInputModel);
		}

		public Task<GetCohortMembers> GetCohortMembers(DeleteCohortsInputModel deleteCohortsInputModel)
		{
			return Post<GetCohortMembers,DeleteCohortsInputModel>("core_cohort_get_cohort_members", deleteCohortsInputModel);
		}

		public Task<CohortsModel> GetCohorts(DeleteCohortsInputModel deleteCohortsInputModel)
		{
			return Post<CohortsModel,DeleteCohortsInputModel>("core_cohort_get_cohorts", deleteCohortsInputModel);
		}

		public Task UpdateCohorts(CohortsInputModel cohortsInputModel)
		{
			return Post<CohortsInputModel>("core_cohort_update_cohorts", cohortsInputModel);
		}

		//Function Placeholder

	}
}