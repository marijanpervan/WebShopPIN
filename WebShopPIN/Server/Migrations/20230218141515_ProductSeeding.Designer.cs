﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShopPIN.Server.Data;

#nullable disable

namespace WebShopPIN.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230218141515_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebShopPIN.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Rolex Oyster Perpetual Date GMT Master is part of the Rolex Professional Watch Collection. Designed in collaboration with the now defunct Pan American Airways of the United States for use by their pilots and navigators, it was launched in 1954.",
                            ImageUrl = "https://sep.yimg.com/ay/movadobaby/rolex-oyster-perpetual-gmt-master-ii-116710-120.jpg",
                            Price = 49.000m,
                            Title = "Rolex GMT Master II"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Rolex introduced the “Cosmograph Daytona” in 1963, ten years after introducing their first Oyster-case chronograph model. The watch featured the Cosmograph name on the dial, and Rolex chose to connect it with auto racing due to the tachymeter printed on the bezel. This was a distinct departure from previous Rolex chronographs, which located any such markings under the crystal, and became the signature feature of the Cosmograph model.",
                            ImageUrl = "https://www.uhren-wiki.com/images/Rolex_Oyster_Perpetual_Cosmograph_Daytona.jpg",
                            Price = 36.000m,
                            Title = "Rolex Daytona Cosmograph"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Rolex Oyster Perpetual Submariner is a line of sports watches designed for diving and manufactured by Rolex, resistant to water and corrosion. The first Submariner was introduced to the public in 1954 at the Basel Watch Fair. It was the first watch to be waterproof up to 100m. The Rolex Submariner is considered 'a classic among wristwatches' manufactured by one of the most widely recognized luxury brands in the world. Due to its huge popularity, there are many homage watches by well-established watchmakers, as well as illegal counterfeits. The Rolex Submariner is part of Rolex's Oyster Perpetual line.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cd/Rolex-Submariner.jpg",
                            Price = 22.000m,
                            Title = "Rolex Submariner"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
