using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Licenta.Models.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime Releasedate { get; set; }
        [Range(1, 200)]
        public byte NumberInStock { get; set; }
    }
}