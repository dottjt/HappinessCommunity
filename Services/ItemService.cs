// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using PTHCommunity.Models;

// namespace PTHCommunity.Services
// {
//   public class ItemService : IItemService
//   {
//     public Task<IEnumerable<Item>> GetItemsListAsync()
//     {
//       IEnumerable<Item> problems = new[]
//       {
//         new Item
//         {
//           Id = Guid.NewGuid(),
//           Name = "Cake Face",
//           DisplayName = "Cake Face",
//           Description = "Cake Face",
//           PostType = "progress",
//           Comments = new List<Comment>(),
//           Tags = new List<Tag>()
//         }
//       };
//     }

//   } 
// }