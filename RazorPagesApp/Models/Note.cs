
using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Models
{
    public class Note
    {
        public int Id { get; set; } //same as ID 
        public string title { get; set; } = String.Empty; 
        public string description { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public string importance { get; set; } = String.Empty;
     



    }
}
