namespace Georza_Daniel_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public Category Category { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
