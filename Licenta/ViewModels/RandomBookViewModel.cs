using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Licenta.Models;


namespace Licenta.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }
    }
}