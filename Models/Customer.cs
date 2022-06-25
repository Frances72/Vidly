using System;
using System.ComponentModel. DataAnnotations;
using System.ComponentModel. DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Customer
    {
        [Key]
        public int iD { get; set; }
        public string  Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
    }

}