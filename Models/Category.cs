using System.ComponentModel.DataAnnotations;

namespace Mission6_CalebE_3_11.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }    
    }
}
