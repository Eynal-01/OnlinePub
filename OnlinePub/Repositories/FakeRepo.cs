using OnlinePub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePub.Repositories
{
    public class FakeRepo
    {
        public List<Beer> GetAll()
        {
            return new List<Beer>
            {
                new Beer{Id=1, Name="Corona", Volume=3.5m, BeerCost=20, ImagePath="/Images/corona.png"},
                new Beer{Id=2, Name="Heineken", Volume=2.0m, BeerCost=35, ImagePath="/Images/heineken.png"},
                new Beer{Id=3, Name="Budweiser", Volume=2.5m, BeerCost=40, ImagePath="/Images/budweiser.png"}
            };
        }
    }
}
