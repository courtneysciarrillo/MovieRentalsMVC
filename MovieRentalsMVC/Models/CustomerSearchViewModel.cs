using System.Collections.Generic;
using System.ComponentModel;

namespace MovieRentalsMVC.Models
{
    public class CustomerSearchViewModel
    {
        [DisplayName("Search")]
        public string SearchText { get; set; }
        public List<Customer> Results { get; set; }
    }
}