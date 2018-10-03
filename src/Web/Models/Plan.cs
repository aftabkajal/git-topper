using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Plan
    {
        public string Name { get; set; }
        public int Space { get; set; }
        public int Collaborators { get; set; }
        public int PrivateRepos { get; set; }
    }
}
