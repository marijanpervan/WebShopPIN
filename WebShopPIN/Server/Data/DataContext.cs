using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebShopPIN.Shared;

namespace WebShopPIN.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Batman" },
                new ProductType { Id = 2, Name = "Root Beer" },
                new ProductType { Id = 3, Name = "Pepsi" },
                new ProductType { Id = 4, Name = "Stainless steel" },
                new ProductType { Id = 5, Name = "White dial" },
                new ProductType { Id = 6, Name = "Black ceramic" },
                new ProductType { Id = 7, Name = "Blue dial" },
                new ProductType { Id = 8, Name = "Black dial" },
                new ProductType { Id = 9, Name = "Smoked grey dial" },
                new ProductType { Id = 10, Name = "Silver dial" },
                new ProductType { Id = 11, Name = "Brown leather" },
                new ProductType { Id = 12, Name = "Green dial" },
                new ProductType { Id = 13, Name = "Rose gold" }
                );


            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Rolex",
                    Url = "rolex"
                }, 
                new Brand
                {
                    Id = 2,
                    Name = "Audemars Piguet",
                    Url = "audemars"
                }, 
                new Brand
                {
                    Id = 3,
                    Name = "Patek Philippe",
                    Url = "patek"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                            new Product
                            {
                                Id = 1,
                                Title = "Rolex GMT Master II",
                                Description = "The Rolex Oyster Perpetual Date GMT Master is part of the Rolex Professional Watch Collection. Designed in collaboration with the now defunct Pan American Airways of the United States for use by their pilots and navigators, it was launched in 1954.",
                                ImageUrl = "https://sep.yimg.com/ay/movadobaby/rolex-oyster-perpetual-gmt-master-ii-116710-120.jpg",
                                BrandId = 1
                            },
                             new Product
                             {
                                 Id = 2,
                                 Title = "Rolex Daytona Cosmograph",
                                 Description = "Rolex introduced the “Cosmograph Daytona” in 1963, ten years after introducing their first Oyster-case chronograph model. The watch featured the Cosmograph name on the dial, and Rolex chose to connect it with auto racing due to the tachymeter printed on the bezel. This was a distinct departure from previous Rolex chronographs, which located any such markings under the crystal, and became the signature feature of the Cosmograph model.",
                                 ImageUrl = "https://www.uhren-wiki.com/images/Rolex_Oyster_Perpetual_Cosmograph_Daytona.jpg",
                                 BrandId = 1
                             },
                             new Product
                             {
                                 Id = 3,
                                 Title = "Rolex Submariner",
                                 Description = "The Rolex Oyster Perpetual Submariner is a line of sports watches designed for diving and manufactured by Rolex, resistant to water and corrosion. The first Submariner was introduced to the public in 1954 at the Basel Watch Fair. It was the first watch to be waterproof up to 100m. The Rolex Submariner is considered 'a classic among wristwatches' manufactured by one of the most widely recognized luxury brands in the world. Due to its huge popularity, there are many homage watches by well-established watchmakers, as well as illegal counterfeits. The Rolex Submariner is part of Rolex's Oyster Perpetual line.",
                                 ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cd/Rolex-Submariner.jpg",
                                 BrandId = 1
                             },
                             new Product
                             {
                                 Id = 4,
                                 Title = "Audemars Piguet Royal Oak",
                                 Description = "The \"Royal Oak\" (named after a famous sailing ship of the British fleet) contributed significantly to the success and awareness of the Audemars Piguet brand and, like the Oyster models from Rolex, can now be counted among the product icons of modern times.",
                                 ImageUrl = "https://www.uhren-wiki.com/images/Audemars_Piguet_Royal_Oak_Chronograph_Tourbillon.jpg",
                                 BrandId = 2
                             },
                             new Product
                             {
                                 Id = 5,
                                 Title = "Audemars Piguet Code 11.59",
                                 Description = "Launched in 2019, Code 11.59 by Audemars Piguet writes a new page in the Manufacture’s history. The contemporary evolution of a classic round watch, it presents a multifaceted and curved architecture with more details than meet the eyes.",
                                 ImageUrl = "https://cdn2.chrono24.com/images/uhren/23580782-szpxfk8cnofx7bgmkoa13808-ExtraLarge.jpg",
                                 BrandId = 2
                             },
                             new Product
                             {
                                 Id = 6,
                                 Title = "Audemars Piguet Jules Audemars",
                                 Description = "Named after one of its founders, the Jules Audemars collection takes cues from more traditional Audemars Piguet designs. In 1875, Jules Audemars created about 20 very complex movements, which he later used as collateral when he and Edward Piguet founded Audemars Piguet & Cie in 1881. These movements marked the beginning of Audemars Piguet. All watches in this collection have a circular shape, some of which also feature complications such as tourbillon, minute repeater, and perpetual calendar.",
                                 ImageUrl = "https://www.luxuriousmagazine.com/wp-content/uploads/2011/09/audemars-onlywatch2011-1.jpg",
                                 BrandId = 2
                             },

                             new Product
                             {
                                 Id = 7,
                                 Title = "Patek Philippe Nautilus",
                                 Description = "The Patek Philippe Nautilus is an iconic luxury sports watch that has become a symbol of style and status among watch enthusiasts. Designed by the legendary watch designer Gérald Genta in the 1970s, the Nautilus has a distinctive shape that resembles a porthole on a ship, with a rounded octagonal bezel and integrated bracelet.",
                                 ImageUrl = "https://static.patek.com/images/articles/face_white/350/5740_1G_001_1.jpg",
                                 BrandId = 3
                             },
                             new Product
                             {
                                 Id = 8,
                                 Title = "Patek Philippe Calatrava",
                                 Description = "The Calatrava is the quintessential dress watch, with a timeless, classic design that has remained largely unchanged since its introduction in 1932. The watch features a round case, simple but elegant dial with a small seconds sub-dial, and thin, tapered hour markers. The Calatrava is available in a range of materials, from stainless steel to precious metals such as gold and platinum, and with a variety of dial colors and textures. The watch is hand-wound and has a relatively slim profile, making it an ideal choice for dressier occasions.",
                                 ImageUrl = "https://www.swissluxury.com/product_images/5196G_001.jpg",
                                 BrandId = 3
                             },
                             new Product
                             {
                                 Id = 9,
                                 Title = "Patek Philippe Aquanaut",
                                 Description = "The Aquanaut is a sportier and more contemporary alternative to the Nautilus, featuring a distinctive rounded octagonal case and an integrated rubber strap. The watch has a bold and modern design, with a range of dial colors, including black, blue, and brown, and luminescent hands and hour markers for enhanced legibility in low-light conditions. The Aquanaut is water-resistant to 120 meters and is equipped with a self-winding movement with a power reserve of up to 45 hours.",
                                 ImageUrl = "https://www.jewelsintime.com/wp-content/uploads/2022/12/jit_221222-071407_1853228860.jpg",
                                 BrandId = 3
                             }

                );
                modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId=1,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 4,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 5,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 6,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 12,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 7,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 4,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 13,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 7,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 8,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 7,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 8,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 9,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 7,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 10,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 13,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 10,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 7,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 5,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 11,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 7,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 10,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 8,
                    Price = 999m,
                    OriginalPrice = 1999m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 7,
                    Price = 999m,
                    OriginalPrice = 1099m
                }
                );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
