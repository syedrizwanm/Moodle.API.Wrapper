using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Report;

namespace Moodle.API.Wrapper.Controllers.Report
{
	public sealed class Competency : BaseController
	{

		public Competency() : base()
		{
		}

		public Competency(string token, string url) : base(token, url)
		{
		}

		public DataForReportModel DataForReport(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<DataForReportModel,ActivitiesCompletionStatusInputModel>("report_competency_data_for_report", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}