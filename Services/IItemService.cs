using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PTHCommunity.Models;

namespace PTHCommunity.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetItemsListAsync();
    }
}
