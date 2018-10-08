using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Owner : Entity
    {
        public string Login { get; set; }
        public string NodeId { get; set; }
        public string AvatarUrl { get; set; }
        public string Name { get; set; }
        public string HtmlUrl { get; set; }
        public string Bio { get; set; }
        public string Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public int PublicRepos { get; set; }
        public bool? Hireable { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public int PublicGists { get; set; }
        public int? Collaborators { get; set; }
        public ICollection<Repositories> Repositories { get; set; }
    }





    
}
