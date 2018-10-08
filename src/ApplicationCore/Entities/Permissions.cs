using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Permissions : Entity
    {
        public bool Admin { get; set; }
        public bool Push { get; set; }
        public bool Pull { get; set; }
        public long RepositoriesId { get; set; }
        public Repositories Repositories { get; set; }
    }
}
