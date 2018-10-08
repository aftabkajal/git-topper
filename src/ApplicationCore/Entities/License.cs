using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class License : Entity
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string SpdxId { get; set; }
        public string Url { get; set; }
        public string NodeId { get; set; }

        public long RepositoriesId { get; set; }
        public Repositories Repositories { get; set; }
    }
}
