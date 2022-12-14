using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HappyMenu.Entities
{
    [Table("Dish")]
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("Description")]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedTime { get; set; }

        [Required]
        public DateTime UpdatedTime { get; set; }

        [Required]
        public string Recipe { get; set; }


        public virtual List<Picture> PictureList { get; set; }
        public virtual List<DishIngredientRelationship> DishIngredientRelationshipList { get; set; }

    }
}
