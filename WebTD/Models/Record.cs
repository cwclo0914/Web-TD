using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login.Models
{
    public class Record
    {
        [Key, Column(Order = 0)]
        public string UserName { get; set; }
        [Key, Column(Order = 1)]
        public int StageNum { get; set; }
        public int Stars { get; set; }
    }
}