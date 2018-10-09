using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    /// <summary>
    /// Root Object
    /// </summary>
   public class Repositories : Entity
    {
        public string NodeId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool IsPrivate { get; set; }

        public long OwnerId { get; set; }
        public Owner Owner { get; set; }
        public string HtmlUrl { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string GitUrl { get; set; }
        public int StargazersCount { get; set; }
        public string Language { get; set; }
        public int ForksCount { get; set; }
        public int OpenIssuesCount { get; set; }
        public string LicenseName { get; set; }
        public string DefaultBranch { get; set; }
    }
}
