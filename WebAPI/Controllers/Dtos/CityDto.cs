using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class CityDto
    {
        [Key]
        public int Id { get; set; }


        [Required (ErrorMessage ="Name is Mandatory Field")]
        [StringLength(50 , MinimumLength =6)]
        [RegularExpression(".*[a-zA-Z]+.*" ,ErrorMessage ="Only Numerics are not allowed" )] //. means can have any value *all type of a-z toA-Z with another value also 
        public string? Name { get; set; }


        [Required]
        public string? Country { get; set; }
    }
}
