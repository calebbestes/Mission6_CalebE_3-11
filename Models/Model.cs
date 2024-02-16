using System.ComponentModel.DataAnnotations;

namespace Mission6_CalebE_3_11.Models
{
    public class Movies
    {
        [Key]
        public int MovieID { get; set; }

        public string Category { get; set; }

        public string Title {  get; set; }

        public int Year { get; set; }   

        public string Director {  get; set; }


        public string Rating { get; set; }  

        public bool Edited { get; set; }


        public string Borrower { get; set; }    


        public string Notes { get; set; }


    }
}
