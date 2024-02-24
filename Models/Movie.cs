using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Mission6_CalebE_3_11.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string Title {  get; set; }

        [Required]
        public int Year { get; set; }

        public string? Director {  get; set; }

        public string? Rating { get; set; }

        [Required]
        public int Edited { get; set; }


        public string? LentTo { get; set; }

        [Required]
        public int CopiedToPlex { get; set; }

        public string? Notes { get; set; }


    }
}
