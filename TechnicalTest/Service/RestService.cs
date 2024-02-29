using RestSharp;

namespace TechnicalTest.Service
{
    public class RestService
    {
        public RestResponse Get(string url)
        {            
            RestClient restClient = new RestClient(url);
            var request = new RestRequest("",Method.Get);
            var restResponse = restClient.Execute(request);           
            return restResponse;
        }

    }
}
