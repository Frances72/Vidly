
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Junkmodel
    {
    [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ident { get; set; }

        [Required(ErrorMessage = "{0} Is required")]
        [StringLength(20)]
        public string JunkName { get; set; }
    }
}