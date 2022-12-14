namespace HappyMenu.Entities
{
    public class Ingredient
    {

        public int IngredientId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // [ Main | Seasoning ]
        public int PictureId { get; set; }

        public string PhotoPath { get; set; }

        public virtual List<DishIngredientRelationship> DishIngredientRelationshipList { get; set; }

    }
}
