using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Meetup.Services
{
    public class BaseService
    {
        private HttpClient _httpClient;
        public BaseService(string domain)
        {
            HttpClient = new HttpClient();
            Domain = domain;
        }

        protected string Domain { private get; set; }
        protected HttpClient HttpClient { get; private set; }

        protected string GenerateUrl(List<string> parts)
        {
            return string.Format("https://{0}/", Domain) + string.Join<string>("/", parts);
        }
    }
}
