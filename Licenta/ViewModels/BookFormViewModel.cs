using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using Licenta.Models;

namespace Licenta.ViewModels
{
    public class BookFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Number in Stock")]
        [Range(1, 200)]
        [Required]
        public byte? NumberInStock { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Book" : "New Book";
            }
        }
        public BookFormViewModel()
        {
            Id = 0;
        }

        public BookFormViewModel(Book book)
        {
            Id = book.Id;
            Name = book.Title;
            ReleaseDate = book.Releasedate;
            NumberInStock = book.NumberInStock;
            GenreId = book.GenreId;
        }
    }
}