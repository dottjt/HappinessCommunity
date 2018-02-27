using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PTHCommunity.Models;

namespace PTHCommunity.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
    }
}
