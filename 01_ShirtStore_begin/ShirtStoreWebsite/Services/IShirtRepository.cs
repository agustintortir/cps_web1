using System;
using System.Collections.Generic;
using System.Linq;
using ShirtStoreWebsite.Models;
using System.Threading.Tasks;

namespace ShirtStoreWebsite.Services
{
    public interface IShirtRepository
    {
        IEnumerable<Shirt> GetShirts();
        bool AddShirt(Shirt shirt);
        bool RemoveShirt(int id);
    }
}
