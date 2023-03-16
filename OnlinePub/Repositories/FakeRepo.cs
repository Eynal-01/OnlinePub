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
                new Beer{Id=1, Name="Corona", Volume=3.5, BeerCost=20},
                new Beer{Id=2, Name="Heineken", Volume=2.0, BeerCost=35},
                new Beer{Id=3, Name="Budweiser", Volume=2.5, BeerCost=40}
            };
        }
    }
}
