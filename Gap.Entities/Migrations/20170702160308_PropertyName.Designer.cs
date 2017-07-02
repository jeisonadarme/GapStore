using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Gap.Entities;

namespace Gap.Entities.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170702160308_PropertyName")]
    partial class PropertyName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gap.Entities.Articles.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.Property<int>("StoreId");

                    b.Property<int>("TotalInShelf");

                    b.Property<int>("TotalInVault");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Gap.Entities.Stores.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("Gap.Entities.Articles.Article", b =>
                {
                    b.HasOne("Gap.Entities.Stores.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
