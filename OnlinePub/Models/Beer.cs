using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace OnlinePub.Models
{
    public class Beer : Entity
    {
        public string Name { get; set; }
        public double Volume { get; set; }
        public double BeerCost { get; set; }
    }
}
