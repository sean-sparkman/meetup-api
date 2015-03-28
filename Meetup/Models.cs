using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetup
{
    public class Organizer
    {
        public string name { get; set; }
        public int member_id { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortname { get; set; }
    }

    public class Topic
    {
        public int id { get; set; }
        public string urlkey { get; set; }
        public string name { get; set; }
    }

    public class GroupPhoto
    {
        public string photo_link { get; set; }
        public string highres_link { get; set; }
        public string thumb_link { get; set; }
        public int photo_id { get; set; }
    }

    public class Group
    {
        public double lon { get; set; }
        public string visibility { get; set; }
        public Organizer organizer { get; set; }
        public string link { get; set; }
        public string state { get; set; }
        public string join_mode { get; set; }
        public string who { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public int utc_offset { get; set; }
        public int id { get; set; }
        public Category category { get; set; }
        public List<Topic> topics { get; set; }
        public string timezone { get; set; }
        public GroupPhoto group_photo { get; set; }
        public long created { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public double rating { get; set; }
        public string urlname { get; set; }
        public double lat { get; set; }
        public int members { get; set; }
    }

    public class Meta
    {
        public string lon { get; set; }
        public int count { get; set; }
        public string signed_url { get; set; }
        public string link { get; set; }
        public string next { get; set; }
        public int total_count { get; set; }
        public string url { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public long updated { get; set; }
        public string description { get; set; }
        public string method { get; set; }
        public string lat { get; set; }
    }

    public class Events
    {
        public List<Event> results { get; set; }
        public Meta meta { get; set; }
    }

    public class Venue
    {
        public int id { get; set; }
        public string zip { get; set; }
        public double lon { get; set; }
        public bool repinned { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public double lat { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }

    public class Rating
    {
        public int count { get; set; }
        public double average { get; set; }
    }

    public class EventGroup
    {
        public int id { get; set; }
        public object created { get; set; }
        public double group_lat { get; set; }
        public string name { get; set; }
        public double group_lon { get; set; }
        public string join_mode { get; set; }
        public string urlname { get; set; }
        public string who { get; set; }
    }

    public class Event
    {
        public string status { get; set; }
        public string visibility { get; set; }
        public int maybe_rsvp_count { get; set; }
        public Venue venue { get; set; }
        public string id { get; set; }
        public int utc_offset { get; set; }
        public object time { get; set; }
        public int waitlist_count { get; set; }
        public bool announced { get; set; }
        public object updated { get; set; }
        public int yes_rsvp_count { get; set; }
        public object created { get; set; }
        public string event_url { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public int headcount { get; set; }
        public Rating rating { get; set; }
        public Group group { get; set; }
    }
}
