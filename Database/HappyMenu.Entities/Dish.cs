using System;
using System.Collections.Generic;

namespace HappyMenu.Entities
{
    public class Dish
    {

        public int DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set;}
        public string Recipe {  get; set; }
        

        public List<Picture> PictureList {  get; set; }
        public List<DishIngredientRelationship> DishIngredientRelationshipList { get; set; }

    }
}
