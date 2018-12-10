using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook
{
    [Table("PhoneContact")]
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
