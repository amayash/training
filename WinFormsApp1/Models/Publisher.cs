using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Models
{
    public class Publisher
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        [ForeignKey("PublisherId")]
        public virtual List<Book> Books { get; set; } = [];
    }
}
