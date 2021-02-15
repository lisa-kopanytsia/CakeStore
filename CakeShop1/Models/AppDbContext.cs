using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Классические торты" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Чизкейки" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Бисквитные торты" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Пражский",
                Price = 320M,
                Description = "Классический Пражский торт, вкус которого знаком нам с детства. Бисквитные коржи пропитаны маслянистым кремом и покрытые шоколадной помадкой.",
                CategoryId = 1,
                ImageUrl = "\\Images\\praga.jpg",
                ImageThumbnailUrl = "\\Images\\praga.jpg",
                IsInStock=true,
                IsOnSale=false
            }) ;
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Тирамису",
                Price = 250M,
                Description = "Тонкая бисквитная основа, бисквитные палочки, пропитанные кофейным ликером, залитые кофейным кремом на основе сливок и белого шоколада с добавлением ликера. Изысканный торт.",
                CategoryId = 1,
                ImageUrl = "\\Images\\tiramisu2.jpg",
                ImageThumbnailUrl = "\\Images\\tiramisu2.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Медовик",
                Price = 180M,
                Description = "Медовые коржи прослоены заварным кремом на основе сгущенного молока.",
                CategoryId = 1,
                ImageUrl = "\\Images\\medovik1.jpg",
                ImageThumbnailUrl = "\\Images\\medovik1.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Три шоколада",
                Price = 200M,
                Description = "Чизкейк три шоколада - изумительный десерт, который с лихвой оправдывает все Ваши ожидания. ",
                CategoryId = 2,
                ImageUrl = "\\Images\\3сhoсo.jpg",
                ImageThumbnailUrl = "\\Images\\3сhoсo.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Фисташковый чизкейк ",
                Price = 180M,
                Description = "Какая здесь вкусная и хрустящая карамельно-фисташковая основа! Просто объедение!  ",
                CategoryId = 2,
                ImageUrl = "\\Images\\fistashkoviy.jpg",
                ImageThumbnailUrl = "\\Images\\fistashkoviy.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Чизкейк Нью-Йорк ",
                Price = 480M,
                Description = "Классический чизкейк, который представляет собой нежное сочетание сливочного крем-сыра и основы из песочного печенья.",
                CategoryId = 2,
                ImageUrl = "\\Images\\newYork.jpg",
                ImageThumbnailUrl = "\\Images\\newYork.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Манго",
                Price = 510M,
                Description = "Манговое блаженство, в нежном бисквитном торте, покрытым глазурью.",
                CategoryId = 3,
                ImageUrl = "\\Images\\mango.jpg",
                ImageThumbnailUrl = "\\Images\\mango.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Пьяная Вишня",
                Price = 580M,
                Description = "Шоколадный бисквит, пропитанный вишнево-ликерным сиропом, обеспечивает торту насыщенный вкус, а шоколадный крем с добавлением вишни, настоянной на ликере и роме, делает торт нежным и пикантным. ",
                CategoryId = 3,
                ImageUrl = "\\Images\\pyanayaVishniya.jpg",
                ImageThumbnailUrl = "\\Images\\pyanayaVishniya.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Клубничный бисквит",
                Price = 360M,
                Description = "Шоколадный бисквит, клубнично-сливочный крем, кусочки свежей клубники.",
                CategoryId = 3,
                ImageUrl = "\\Images\\pklubnichniy.jpg",
                ImageThumbnailUrl = "\\Images\\klubnichniy.jpg",
                IsInStock = true,
                IsOnSale = false
            });


        }
    }
}
