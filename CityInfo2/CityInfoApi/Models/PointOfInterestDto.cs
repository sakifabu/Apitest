using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoApi
{
    public class PointOfInterestDto
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
    }
}
