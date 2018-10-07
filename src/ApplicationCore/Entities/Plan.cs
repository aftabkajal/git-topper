using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Plan : Entity
    {
        public string Name { get; set; }
        public int Space { get; set; }
        public int Collaborators { get; set; }
        public int PrivateRepos { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
