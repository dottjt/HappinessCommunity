using System;
using System.Collections.Generic;

namespace PTHCommunity.Models
{
    public class Tag
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string PostType { get; set; }

        public ICollection<Comment> Technologies { get; set; }        
    }
}
