using HappyMenu.Entities;
using Microsoft.EntityFrameworkCore;

namespace HappyMenu.DatabaseContext
{
    public class HappyMenuDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=HappyMenu;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredientRelationship>()
                .HasOne<Dish>(rel => rel.Dish)
                .WithMany(d => d.DishIngredientRelationshipList)
                .HasForeignKey(rel => rel.DishId);

            modelBuilder.Entity<DishIngredientRelationship>()
                .HasOne<Ingredient>(rel => rel.Ingredient)
                .WithMany(i => i.DishIngredientRelationshipList)
                .HasForeignKey(rel => rel.IngredientId);

        }

        //entities
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishIngredientRelationship> DishIngredientRelationships { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<PlanItem> PlanItems { get; set; }

    }
}