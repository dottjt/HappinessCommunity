using System;
using System.Collections.Generic;

namespace PTHCommunity.Models {
    public class FakeItemRepository : IItemRepository {
        public IEnumerable<Item> Items => new List<Item> {
            new Item { 
              Id = Guid.NewGuid(),
              Name = "Cake Face",
              DisplayName = "Cake Face",
              Description = "Cake Face",
              PostType = "progress",
              Comments = new List<Comment>(),
              Tags = new List<Tag>()

            },
            new Item { 
              Id = Guid.NewGuid(),
              Name = "Cake Face",
              DisplayName = "Cake Face",
              Description = "Cake Face",
              PostType = "progress",
              Comments = new List<Comment>(),
              Tags = new List<Tag>()
            }
}; }
}