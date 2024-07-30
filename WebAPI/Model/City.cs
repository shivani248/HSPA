using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class City : BaseEntity
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        
    }
}
