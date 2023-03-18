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
                new Beer{Id=1, BeerName="Corona Extra", Volume=4.0m, BeerCost=20.6m, ImagePath="/Images/coronaextra.png"},
                new Beer{Id=1, BeerName="Corona Light", Volume=2.0m, BeerCost=24.5m, ImagePath="/Images/coronalight.png"},
                new Beer{Id=2, BeerName="Heineken", Volume=2.0m, BeerCost=34.9m, ImagePath="/Images/heineken1.png"},
                new Beer{Id=3, BeerName="Budweiser", Volume=2.5m, BeerCost=40.3m, ImagePath="/Images/budweiser.png"},
                new Beer{Id=3, BeerName="Bud Light", Volume=3.5m, BeerCost=46.7m, ImagePath="/Images/budlight.png"},
                new Beer{Id=3, BeerName="Skol", Volume=2.0m, BeerCost=40.2m, ImagePath="/Images/skol.png"}
            };
        }
    }
}
