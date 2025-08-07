using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cupcakes.Models;
using System.Linq;


namespace Cupcakes.Repositories
{
    public interface ICupcakeRepositorio
    {
         IEnumerable<Cupcake> GetCupcakes();
         Cupcake GetCupcakeById(int id);
         void CreateCupcake(Cupcake cupcake);
         void DeleteCupcake(int id);
         void SaveChanges();
         IQueryable<Bakery> PopulateBakeriesDropDownList();
    }
}
