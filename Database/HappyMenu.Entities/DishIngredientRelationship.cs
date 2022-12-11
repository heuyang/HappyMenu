namespace HappyMenu.Entities
{
    public class DishIngredientRelationship
    {

        public int DishId { get; set; }
        public int IngredientId { get; set; }

        public int DisplayOrder { get; set; }
        public string Amount { get; set; } // 2x, 5g, 100ml, etc
        public string Note { get; set; }

        public Dish Dish { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
