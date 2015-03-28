using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetup.Interfaces
{
    public interface IGroupsService
    {
        List<Group> SearchByCategory(int categoryId);
        List<Group> SearchByTopic(string topic);
        List<Group> SearchByZip(string zipCode);
        List<Group> SearchByLocation(decimal latitude, decimal longitude);
        Task<Group> Get(string urlname);
    }
}
