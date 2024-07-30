using System.ComponentModel.DataAnnotations;
using WebAPI.Model;

namespace WebAPI.Models
{
    public class FurnishingType : BaseEntity
    {
        [Required]
        public required string Name { get; set; }
    }
}