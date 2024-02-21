using System.ComponentModel.DataAnnotations;

namespace Mission6_CalebE_3_11.Models
{
    public class Movies
    {
        [Key]
        public int MovieID { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title {  get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director {  get; set; }

        [Required]
        public string Rating { get; set; }  


        public bool Edited { get; set; }


        public string? Borrower { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }


    }
}
