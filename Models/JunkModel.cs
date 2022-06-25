using System;
using System.ComponentModel. DataAnnotations;
using System.ComponentModel. DataAnnotations.Schema;

namespace Vidly.Models
{
    public class JunkModel
    {
        [Key]
        public int iD { get; set; }
        public string  JunkName { get; set; }
        public bool testBool { get; set; }
    }

}