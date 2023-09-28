using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CarCategoryId { get; set; }
        public CarCategory CarCategory { get; set; }
        public string ImageUrl { get; set; }
        public string GearType { get; set; }
        public int Km { get; set; }
        public byte PersonCount { get; set; }
        public int Year { get; set; }
        public bool Status { get; set; }
        public List<Price> Prices { get; set; }
        public int CarStatusId { get; set; }
        public CarStatus CarStatus { get; set; }

    }
}
