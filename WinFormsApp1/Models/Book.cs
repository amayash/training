using System.Text.Json.Serialization;

namespace WinFormsApp1.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public int Year { get; set; }
        public int PageCount { get; set; }
        public Guid PublisherId { get; set; }
        [JsonIgnore]
        public virtual Publisher Publisher { get; set; } = null!;
    }
}
