using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        public DateTime LastUpdateOn { get; set; } = DateTime.Now;
        public int LastUpdatedBy { get; set; }
    }
}
