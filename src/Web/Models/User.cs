using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    /// <summary>
    /// RootObject
    /// </summary>
    public class User
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string NodeId { get; set; }
        public string AvatarUrl { get; set; }
        public string GravatarId { get; set; }
        public string Url { get; set; }
        public string HtmlUrl { get; set; }
        public string FollowersUrl { get; set; }
        public string FollowingUrl { get; set; }
        public string GistsUrl { get; set; }
        public string StarredUrl { get; set; }
        public string SubscriptionsUrl { get; set; }
        public string OrganizationsUrl { get; set; }
        public string ReposUrl { get; set; }
        public string EventsUrl { get; set; }
        public string ReceivedEventsUrl { get; set; }
        public string Type { get; set; }
        public bool SiteAdmin { get; set; }
        public string Name { get; set; }
        public object Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public bool Hireable { get; set; }
        public string Bio { get; set; }
        public int PublicRepos { get; set; }
        public int PublicGists { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int PrivateGists { get; set; }
        public int TotalPrivateRepos { get; set; }
        public int OwnedPrivateRepos { get; set; }
        public int DiskUsage { get; set; }
        public int Collaborators { get; set; }
        public bool TwoFactorAuthentication { get; set; }
        public Plan Plan { get; set; }
    }
}
