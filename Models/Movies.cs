using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvC5Course.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RentalsDate { get; set; }
        public List<Customer> Customers { get; set; }
    }
}