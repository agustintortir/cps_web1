using System;
using System.Collections.Generic;
using System.Text;
using ShirtStoreWebsite.Models;
using ShirtStoreWebsite.Services;

namespace ShirtStoreWebsite.Tests.FakeRepositories
{

    internal class FakeShirtRepository : IShirtRepository
    {
        IEnumerable<Shirt> GetShirts()
        {
            return new List<Shirt>()
            {
                new Shirt {Color = ShirtColor.Black, Size = ShirtSize.S, Price = 11F },
                new Shirt {Color = ShirtColor.Gray, Size = ShirtSize.M, Price = 12F },
                new Shirt {Color = ShirtColor.Black, Size = ShirtSize.L, Price = 13F }

            };
        }

        public bool AddShirt(Shirt shirt)
        {
            return true;
        }

        public bool RemoveShirt(int id)
        {
            return true;
        }

        IEnumerable<Shirt> IShirtRepository.GetShirts()
        {
            throw new NotImplementedException();
        }
    }
}