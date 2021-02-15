using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeShop1.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Классические торты" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Чизкейки" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Бисквитные торты" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Классический Пражский торт, вкус которого знаком нам с детства. Бисквитные коржи пропитаны маслянистым кремом и покрытые шоколадной помадкой.", "~\\Images\\praga.jpg", "~\\Images\\praga.jpg", true, false, "Пражский", 320m },
                    { 2, 1, "Тонкая бисквитная основа, бисквитные палочки, пропитанные кофейным ликером, залитые кофейным кремом на основе сливок и белого шоколада с добавлением ликера. Изысканный торт.", "~\\Images\\tiramisu2.jpg", "~\\Images\\tiramisu2.jpg", true, false, "Тирамису", 250m },
                    { 3, 1, "Медовые коржи прослоены заварным кремом на основе сгущенного молока.", "~\\Images\\medovik1.jpg", "~\\Images\\medovik1.jpg", true, false, "Медовик", 180m },
                    { 4, 2, "Чизкейк три шоколада - изумительный десерт, который с лихвой оправдывает все Ваши ожидания. ", "~\\Images\\3сhoсo.png", "~\\Images\\3сhoсo.png", true, false, "Три шоколада", 200m },
                    { 5, 2, "Какая здесь вкусная и хрустящая карамельно-фисташковая основа! Просто объедение!  ", "~\\Images\\fistashkoviy.png", "~\\Images\\fistashkoviy.png", true, false, "Фисташковый чизкейк ", 180m },
                    { 6, 2, "Классический чизкейк, который представляет собой нежное сочетание сливочного крем-сыра и основы из песочного печенья.", "~\\Images\\newYork.png", "~\\Images\\newYork.png", true, false, "Чизкейк Нью-Йорк ", 480m },
                    { 7, 3, "Манговое блаженство, в нежном бисквитном торте, покрытым глазурью.", "~\\Images\\mango.png", "~\\Images\\mango.png", true, false, "Манго", 510m },
                    { 8, 3, "Шоколадный бисквит, пропитанный вишнево-ликерным сиропом, обеспечивает торту насыщенный вкус, а шоколадный крем с добавлением вишни, настоянной на ликере и роме, делает торт нежным и пикантным. ", "~\\Images\\pyanayaVishniya.png", "~\\Images\\pyanayaVishniya.png", true, false, "Пьяная Вишня", 580m },
                    { 9, 3, "Шоколадный бисквит, клубнично-сливочный крем, кусочки свежей клубники.", "~\\Images\\klubnichniy.png", "~\\Images\\pklubnichniy.png", true, false, "Клубничный бисквит", 360m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
