using System.ComponentModel.DataAnnotations;

namespace Georza_Daniel_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
