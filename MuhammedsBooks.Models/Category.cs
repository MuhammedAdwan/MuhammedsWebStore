using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
//using System.Linq;
//using System.Threading.Tasks;

namespace MuhammedsBooks.Models
{
    class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
