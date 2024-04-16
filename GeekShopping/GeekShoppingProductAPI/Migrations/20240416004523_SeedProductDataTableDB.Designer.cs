﻿// <auto-generated />
using GeekShoppingProductAPI.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShoppingProductAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20240416004523_SeedProductDataTableDB")]
    partial class SeedProductDataTableDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShoppingProductAPI.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan. Etiam faucibus pharetra arcu et cursus. Aliquam porta pulvinar ante. Donec in ultrices nulla. Aliquam luctus volutpat dolor, maximus maximus nulla laoreet non. Ut pulvinar fermentum ipsum",
                            ImageUrl = "https://ae01.alicdn.com/kf/S13d07d1225ab4a87a870851780272e29a.jpg_640x640Q90.jpg_.webp",
                            Name = "Guts - Beserk - Action Figure",
                            Price = 70m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan. Etiam faucibus pharetra arcu et cursus.",
                            ImageUrl = "https://preview.redd.it/k4bw3e0hm7o71.jpg?width=1080&crop=smart&auto=webp&s=2ce430bc58d02b0705b747ab0b4661dbcb28c024",
                            Name = "Dark Knight - Final Fanatsy XIV Action Figure - Shadowbringers",
                            Price = 74.6m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://cdn.awsli.com.br/1029/1029045/produto/195648290/figure-059905_01-78d314f018.jpg",
                            Name = "Red - Pokémon - Action Figure",
                            Price = 46.9m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Coffe Mug",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://images.tcdn.com.br/img/img_prod/650501/caneca_garoto_de_programa_6267_1_514e868e9ae68bafe7c0108b88e490fb.jpg",
                            Name = "Caneca - Garoto de Programa",
                            Price = 33.6m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_613219-MLU69935631223_062023-O.webp",
                            Name = "Best ghost pokémons - Pokémon - Action Figure",
                            Price = 66.6m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://down-br.img.susercontent.com/file/5e2e1d1fd71c8af12f27f4a226987494",
                            Name = "Shirohige - One Piece - Action Figure",
                            Price = 46.9m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://ae01.alicdn.com/kf/Hac356c576da546c8886439e6e02b7efby/Dark-Souls-Faraam-PVC-Figura-Artorias-O-Abysswalker-Cavaleiro-Negro-Avan-ado-Cavaleiro-Guerreiro-Collectible-Toy.jpg",
                            Name = "Artorias - Dark Souls - Action Figure",
                            Price = 120.9m
                        },
                        new
                        {
                            Id = 8L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://lojaarenagames.com.br/wp-content/uploads/2022/08/Action_Figure_Saint_Seiya_Ikki_V2_Revival___Cloth_Myth_Ex_84402-1.jpg",
                            Name = "Ikki de Fênix - Cavaleiros do Zodíaco - Action Figure",
                            Price = 46.9m
                        },
                        new
                        {
                            Id = 9L,
                            CategoryName = "T-Shirt",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/565bee29c0eceef0e0f0f88bae929287.webp",
                            Name = "T-Shirt - Já abriu o chamado?",
                            Price = 30.2m
                        },
                        new
                        {
                            Id = 10L,
                            CategoryName = "T-Shirt",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/a7af8b5d4549363b447892493d866642.webp",
                            Name = "T-Shirt - Null dias sem bug em produção",
                            Price = 57.9m
                        },
                        new
                        {
                            Id = 11L,
                            CategoryName = "Action Figure",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/0a8d91c21e81bc3c5fcc58267cb4074b.webp",
                            Name = "T-Shirt - Sem condições",
                            Price = 93m
                        },
                        new
                        {
                            Id = 12L,
                            CategoryName = "T-Shirt",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/25da5ad4b22720198c1f07a8fef6e1b7.webp",
                            Name = "T-Shirt- Update sem where",
                            Price = 74.9m
                        },
                        new
                        {
                            Id = 13L,
                            CategoryName = "T-Shirt",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                            ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/b105eab5dba8797567789a02d3be923c.webp",
                            Name = "T-Shirt Go Horse process",
                            Price = 46.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
