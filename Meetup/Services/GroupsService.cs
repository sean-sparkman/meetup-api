using Meetup.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetup.Services
{
    public class GroupsService
        : BaseService, IGroupsService
    {
        public GroupsService()
            : base("api.meetup.com") { }

        public List<Group> SearchByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Group> SearchByTopic(string topic)
        {
            throw new NotImplementedException();
        }

        public List<Group> SearchByZip(string zipCode)
        {
            throw new NotImplementedException();
        }

        public List<Group> SearchByLocation(decimal latitude, decimal longitude)
        {
            throw new NotImplementedException();
        }

        public async Task<Group> Get(string urlname)
        {
            var url = GenerateUrl(new List<string>() { "2", "groups" });

            url += "?&sign=true&photo-host=public&page=1&group_urlname=" + urlname;

            var response = await HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Group>>(json).First();
            }

            throw new NotImplementedException();
        }
    }
}
