using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Cohort : BaseController
	{

		public Cohort() : base()
		{
		}

		public Cohort(string token, string url) : base(token, url)
		{
		}

		public CohortMembersModel AddCohortMembers(CohortMembersInputModel cohortMembersInputModel)
		{
			return Post<CohortMembersModel,CohortMembersInputModel>("core_cohort_add_cohort_members", cohortMembersInputModel);
		}

		public CohortsModel CreateCohorts(CohortsInputModel cohortsInputModel)
		{
			return Post<CohortsModel,CohortsInputModel>("core_cohort_create_cohorts", cohortsInputModel);
		}

		public void DeleteCohortMembers(DeleteCohortMembersInputModel deleteCohortMembersInputModel)
		{
			Post<DeleteCohortMembersInputModel>("core_cohort_delete_cohort_members", deleteCohortMembersInputModel);
		}

		public void DeleteCohorts(DeleteCohortsInputModel deleteCohortsInputModel)
		{
			Post<DeleteCohortsInputModel>("core_cohort_delete_cohorts", deleteCohortsInputModel);
		}

		public GetCohortMembers GetCohortMembers(DeleteCohortsInputModel deleteCohortsInputModel)
		{
			return Post<GetCohortMembers,DeleteCohortsInputModel>("core_cohort_get_cohort_members", deleteCohortsInputModel);
		}

		public CohortsModel GetCohorts(DeleteCohortsInputModel deleteCohortsInputModel)
		{
			return Post<CohortsModel,DeleteCohortsInputModel>("core_cohort_get_cohorts", deleteCohortsInputModel);
		}

		public void UpdateCohorts(CohortsInputModel cohortsInputModel)
		{
			Post<CohortsInputModel>("core_cohort_update_cohorts", cohortsInputModel);
		}

		//Function Placeholder

	}
}