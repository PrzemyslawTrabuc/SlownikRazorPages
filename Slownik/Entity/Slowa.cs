using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slownik.Entity
{
    public class Slowa
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "polski")]
        [StringLength(300, ErrorMessage = "Word should be 1 to 300 char in lenght")]
        public string Polski { get; set; }

        [Required]
        [Display(Name = "angielski")]
        [StringLength(300, ErrorMessage = "Word should be 1 to 300 char in lenght")]
        public string Angielski { get; set; }        
    }

    public class Ulubione
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "user_id")]
        public string user_id { get; set; }

        [Required]
        [Display(Name = "polski")]
        [StringLength(300, ErrorMessage = "Word should be 1 to 300 char in lenght")]
        public string Polski { get; set; }

        [Required]
        [Display(Name = "angielski")]
        [StringLength(300, ErrorMessage = "Word should be 1 to 300 char in lenght")]
        public string Angielski { get; set; }
    }
}
