using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Licenta.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter book's title.")]
        [StringLength(255)]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name ="Release Date")]
        public DateTime Releasedate { get; set; }
        [Display(Name ="Number in Stock")]
        [Range(1,200)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }


    }
}