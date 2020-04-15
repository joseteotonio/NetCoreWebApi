using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using InterApi.Entities.Base;

namespace InterApi.Entities
{
    [DataContract]
    public class UserEntity : BaseModelEntity
    {
        public UserEntity()
        {
        }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; } = "";

        [Required]
        [Column(TypeName ="varchar(200)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "char(2)")]
        public string UF { get; set; }

        public UserEntity (string name, string email, string uf)
        {
            this.Name = name;
            this.Email = email;
            this.UF = uf;
        }
    }
}
