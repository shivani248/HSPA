using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebAPI.Model
{
    [Table("Photos")]
    public class Photo : BaseEntity
    {
        [Required]
        public string PublicId { get; set; }

        public required string ImageUrl { get; set; }
        public bool IsPrimary { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}