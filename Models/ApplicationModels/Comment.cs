using System;
using System.Collections.Generic;

namespace PTHCommunity.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string PostType { get; set; }

        public ICollection<SubComment> SubComments { get; set; }
    }
}
