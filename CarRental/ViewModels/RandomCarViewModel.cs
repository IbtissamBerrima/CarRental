using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental.Models;

namespace CarRental.ViewModels
{
    public class RandomCarViewModel
    {
        public Caar car { get; set; }
        public List<Customer> customers { get; set; }
    }
}