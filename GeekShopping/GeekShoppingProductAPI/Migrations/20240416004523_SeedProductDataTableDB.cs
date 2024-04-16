using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShoppingProductAPI.Migrations
{
    public partial class SeedProductDataTableDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "CategoryName", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan. Etiam faucibus pharetra arcu et cursus. Aliquam porta pulvinar ante. Donec in ultrices nulla. Aliquam luctus volutpat dolor, maximus maximus nulla laoreet non. Ut pulvinar fermentum ipsum", "https://ae01.alicdn.com/kf/S13d07d1225ab4a87a870851780272e29a.jpg_640x640Q90.jpg_.webp", "Guts - Beserk - Action Figure", 70m },
                    { 2L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan. Etiam faucibus pharetra arcu et cursus.", "https://preview.redd.it/k4bw3e0hm7o71.jpg?width=1080&crop=smart&auto=webp&s=2ce430bc58d02b0705b747ab0b4661dbcb28c024", "Dark Knight - Final Fanatsy XIV Action Figure - Shadowbringers", 74.6m },
                    { 3L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://cdn.awsli.com.br/1029/1029045/produto/195648290/figure-059905_01-78d314f018.jpg", "Red - Pokémon - Action Figure", 46.9m },
                    { 4L, "Coffe Mug", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://images.tcdn.com.br/img/img_prod/650501/caneca_garoto_de_programa_6267_1_514e868e9ae68bafe7c0108b88e490fb.jpg", "Caneca - Garoto de Programa", 33.6m },
                    { 5L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://http2.mlstatic.com/D_NQ_NP_613219-MLU69935631223_062023-O.webp", "Best ghost pokémons - Pokémon - Action Figure", 66.6m },
                    { 6L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://down-br.img.susercontent.com/file/5e2e1d1fd71c8af12f27f4a226987494", "Shirohige - One Piece - Action Figure", 46.9m },
                    { 7L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://ae01.alicdn.com/kf/Hac356c576da546c8886439e6e02b7efby/Dark-Souls-Faraam-PVC-Figura-Artorias-O-Abysswalker-Cavaleiro-Negro-Avan-ado-Cavaleiro-Guerreiro-Collectible-Toy.jpg", "Artorias - Dark Souls - Action Figure", 120.9m },
                    { 8L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://lojaarenagames.com.br/wp-content/uploads/2022/08/Action_Figure_Saint_Seiya_Ikki_V2_Revival___Cloth_Myth_Ex_84402-1.jpg", "Ikki de Fênix - Cavaleiros do Zodíaco - Action Figure", 46.9m },
                    { 9L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/565bee29c0eceef0e0f0f88bae929287.webp", "T-Shirt - Já abriu o chamado?", 30.2m },
                    { 10L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/a7af8b5d4549363b447892493d866642.webp", "T-Shirt - Null dias sem bug em produção", 57.9m },
                    { 11L, "Action Figure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/0a8d91c21e81bc3c5fcc58267cb4074b.webp", "T-Shirt - Sem condições", 93m },
                    { 12L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/25da5ad4b22720198c1f07a8fef6e1b7.webp", "T-Shirt- Update sem where", 74.9m },
                    { 13L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.", "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/b105eab5dba8797567789a02d3be923c.webp", "T-Shirt Go Horse process", 46.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13L);
        }
    }
}
