using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class User: BaseEntity
    {


        
        [Column("Name")]
        public required string UserName { get; set; }
        public required byte[] Password { get; set; }

        public  byte[] PasswordKey { get; set; }
    }
}
