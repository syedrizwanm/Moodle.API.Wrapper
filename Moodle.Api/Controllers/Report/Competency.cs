using System.Threading.Tasks;
using Moodle.Api.Models.Report;

namespace Moodle.Api.Controllers.Report
{
	public sealed class Competency : BaseController
	{

		public Competency() : base()
		{
		}

		public Competency(string token, string url) : base(token, url)
		{
		}

		public Task<DataForReportModel> DataForReport(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<DataForReportModel,ActivitiesCompletionStatusInputModel>("report_competency_data_for_report", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}