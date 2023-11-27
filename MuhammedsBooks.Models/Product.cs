using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammedsBooks.Models
{

    public class Product
    {

        [Key]

        public int Id { get; set; }

        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]

        public string ISBN { get; set; }
        [Required]

        public string Author { get; set; }

        [Required]

        [Range(1, 10000)]

        public double ListPrice { get; set; }
        [Required]

        public string ImageUrl { get; set; }

        [Required]

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] // foreign key reference

        public Category Category { get; set; }

        [Required]

        public int CoverTypeId { get; set; } // foreign key reference

        [ForeignKey("CategoryId")]

        public CoverType CoverType { get; set; }
    }
}