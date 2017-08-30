using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class User
    {
        [Key]
        public string Name { get; set; }
    }
}