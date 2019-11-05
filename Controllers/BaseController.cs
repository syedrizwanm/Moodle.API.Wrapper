using System;
using System.Net.Http;
using System.Threading.Tasks;
using Moodle.Api.Models;

namespace Moodle.Api.Controllers
{
    public class BaseController
    {
        private HttpClient moodleClient;
        private string _token;
        private Func<string, Task> WriteProgress;
        public BaseController()
        {

        }
        public BaseController(string token, string url)
        {
            SetupController(token, url);
        }

        public void SetupController(string token, string url)
        {
            moodleClient = new HttpClient();
            moodleClient.BaseAddress = new Uri(url + "/webservice/rest/");
            _token = token;
        }

        public void SetupController(string securityToken, string url, Func<string, Task> writeProgress)
        {
            SetupController(securityToken, url);
            WriteProgress = writeProgress;
        }

        protected TModel Post<TModel, TInputModel> (string functionName,TInputModel inputModel)
            where TInputModel:IModel
        {
            try
            {

                var inputPairs = inputModel.ToKeyValuePairs();
                var inputContent = new FormUrlEncodedContent(inputPairs); 
                var response = moodleClient.PostAsync("server.php?wstoken=" + _token + "&moodlewsrestformat=json&wsfunction=" + functionName,inputContent).Result;
                var responseText = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseText.Contains("\"exception\":"))
                    {
                        throw new InvalidOperationException(responseText);
                    }
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<TModel>(responseText);
                }
                else
                    throw new InvalidOperationException(responseText);
            }
            catch (Exception ex)
            {
                WriteProgress("~~~~~Error~~~~~\nFunction: " + functionName + "\n~~~~~Exception~~~~~\n" + ex.ToString().Replace("\\n","\n") + "\n~~~~~~~~~~~~~~~");
                return default(TModel);
            }
        }
        protected void Post<TInputModel>(string functionName, TInputModel inputModel)
            where TInputModel : IModel
        {
            try
            {
                var inputPairs = inputModel.ToKeyValuePairs();
                var inputContent = new FormUrlEncodedContent(inputPairs);
                var response = moodleClient.PostAsync("server.php?wstoken=" + _token + "&moodlewsrestformat=json&wsfunction=" + functionName, inputContent).Result;
                var responseText = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode != System.Net.HttpStatusCode.OK || responseText.Contains("\"exception\":"))
                    throw new InvalidOperationException(responseText);
            }
            catch (Exception ex)
            {
                WriteProgress("~~~~~Error~~~~~\nFunction: " + functionName + "\n~~~~~Exception~~~~~\n" + ex.ToString() + "\n~~~~~~~~~~~~~~~");
            }
        }
        protected TModel Post<TModel>(string functionName)
        {
            try
            {
                var response = moodleClient.PostAsync("&wsfunction=" + functionName, null).Result;
                var responseText = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (responseText.Contains("\"exception\":"))
                    {
                        throw new InvalidOperationException(responseText);
                    }
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<TModel>(responseText);
                }
                else
                    throw new InvalidOperationException(responseText);
            }
            catch (Exception ex)
            {
                WriteProgress("~~~~~Error~~~~~\nFunction: " + functionName + "\n~~~~~Exception~~~~~\n" + ex.ToString() + "\n~~~~~~~~~~~~~~~");
                return default(TModel);
            }
        }
     
    }
}
