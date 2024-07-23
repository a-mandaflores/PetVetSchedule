using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetVetApi.Model
{
    [Table("Pet")]
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("Race")]
        public string Race { get; set; }
    }
}
