using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iD { get; set; }

        [Required(ErrorMessage = "{0} Is required")]
        [StringLength(20)]
        public string Name { get; set; }
    }
}