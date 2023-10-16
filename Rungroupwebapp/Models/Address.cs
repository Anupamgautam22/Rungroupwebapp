using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Rungroupwebapp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Street { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }


    }
}
