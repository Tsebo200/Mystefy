﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mystefy.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mystefy.Migrations
{
    [DbContext(typeof(MystefyDbContext))]
    [Migration("20250414172649_AddWasteLossRecordPackaging")]
    partial class AddWasteLossRecordPackaging
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Mystefy.Models.Batch", b =>
                {
                    b.Property<int>("BatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BatchID"));

                    b.Property<int>("BatchSize")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("BatchID");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("Mystefy.Models.BatchFinishedProduct", b =>
                {
                    b.Property<int>("BatchID")
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    b.Property<int>("ProductID")
                        .HasColumnType("integer")
                        .HasColumnOrder(1);

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("integer");

                    b.HasKey("BatchID", "ProductID");

                    b.HasIndex("ProductID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("BatchFinishedProducts");
                });

            modelBuilder.Entity("Mystefy.Models.BatchIngredients", b =>
                {
                    b.Property<int>("BatchID")
                        .HasColumnType("integer");

                    b.Property<int>("IngredientsID")
                        .HasColumnType("integer");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.HasKey("BatchID", "IngredientsID");

                    b.HasIndex("IngredientsID");

                    b.ToTable("BatchIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DeliveryID"));

                    b.Property<decimal>("DeliveryCost")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("DeliveryDateArrived")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeliveryDateOrdered")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SupplierID")
                        .HasColumnType("integer");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("integer");

                    b.HasKey("DeliveryID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Mystefy.Models.DeliveryIngredients", b =>
                {
                    b.Property<int>("DeliveryIngredientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DeliveryIngredientID"));

                    b.Property<DateTime>("DateOrdered")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeliveryID")
                        .HasColumnType("integer");

                    b.Property<decimal>("DeliveryIngredientCost")
                        .HasColumnType("numeric");

                    b.Property<int>("IngredientID")
                        .HasColumnType("integer");

                    b.Property<decimal>("QuantityDelivered")
                        .HasColumnType("numeric");

                    b.HasKey("DeliveryIngredientID");

                    b.HasIndex("DeliveryID");

                    b.HasIndex("IngredientID");

                    b.ToTable("DeliveryIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.FinishedProduct", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductID"));

                    b.Property<int>("FragranceID")
                        .HasColumnType("integer");

                    b.Property<int>("PackagingID")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("ProductID");

                    b.HasIndex("FragranceID");

                    b.HasIndex("PackagingID");

                    b.ToTable("FinishedProduct");
                });

            modelBuilder.Entity("Mystefy.Models.Fragrance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Volume")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Fragrances");
                });

            modelBuilder.Entity("Mystefy.Models.FragranceIngredient", b =>
                {
                    b.Property<int>("FragranceID")
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    b.Property<int>("IngredientsID")
                        .HasColumnType("integer")
                        .HasColumnOrder(1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.HasKey("FragranceID", "IngredientsID");

                    b.HasIndex("IngredientsID");

                    b.ToTable("FragranceIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Mystefy.Models.Packaging", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Packaging");
                });

            modelBuilder.Entity("Mystefy.Models.StockRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountRequested")
                        .HasColumnType("integer");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IngredientsId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockRequests");
                });

            modelBuilder.Entity("Mystefy.Models.StockRequestIngredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountRequested")
                        .HasColumnType("integer");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IngredientsId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockRequestIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.StockRequestPackagings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountRequested")
                        .HasColumnType("integer");

                    b.Property<int?>("IngredientsId")
                        .HasColumnType("integer");

                    b.Property<int>("PackagingId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IngredientsId");

                    b.HasIndex("PackagingId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockRequestPackagings");
                });

            modelBuilder.Entity("Mystefy.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SupplierID"));

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Mystefy.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Mystefy.Models.Warehouse", b =>
                {
                    b.Property<int>("WarehouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WarehouseID"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("WarehouseID");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Mystefy.Models.WarehouseIngredients", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("IngredientsId")
                        .HasColumnType("integer");

                    b.Property<int>("Volume")
                        .HasColumnType("integer");

                    b.HasKey("IngredientId");

                    b.HasIndex("IngredientsId");

                    b.ToTable("WarehouseIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.WarehouseStock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StockID"));

                    b.Property<int>("FragranceID")
                        .HasColumnType("integer");

                    b.Property<decimal>("Stock")
                        .HasColumnType("numeric");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("integer");

                    b.HasKey("StockID");

                    b.HasIndex("FragranceID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("WarehouseStocks");
                });

            modelBuilder.Entity("Mystefy.Models.WasteLossRecordIngredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfLoss")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("integer");

                    b.Property<int>("QuantityLoss")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IngredientsId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WasteLossRecordIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.WasteLossRecordPackaging", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfLoss")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PackagingId")
                        .HasColumnType("integer");

                    b.Property<int>("QuantityLoss")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PackagingId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WasteLossRecordPackaging");
                });

            modelBuilder.Entity("Mystefy.Models.BatchFinishedProduct", b =>
                {
                    b.HasOne("Mystefy.Models.Batch", "Batch")
                        .WithMany("BatchFinishedProducts")
                        .HasForeignKey("BatchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.FinishedProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batch");

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.BatchIngredients", b =>
                {
                    b.HasOne("Mystefy.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Ingredients", "Ingredients")
                        .WithMany()
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batch");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Mystefy.Models.Delivery", b =>
                {
                    b.HasOne("Mystefy.Models.Supplier", "Supplier")
                        .WithMany("Delivery")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.DeliveryIngredients", b =>
                {
                    b.HasOne("Mystefy.Models.Delivery", "Delivery")
                        .WithMany("DeliveryIngredients")
                        .HasForeignKey("DeliveryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Ingredients", "Ingredient")
                        .WithMany("DeliveryIngredients")
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Delivery");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Mystefy.Models.FinishedProduct", b =>
                {
                    b.HasOne("Mystefy.Models.Fragrance", "Fragrance")
                        .WithMany("FinishedProduct")
                        .HasForeignKey("FragranceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Packaging", "Packaging")
                        .WithMany("FinishedProduct")
                        .HasForeignKey("PackagingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fragrance");

                    b.Navigation("Packaging");
                });

            modelBuilder.Entity("Mystefy.Models.FragranceIngredient", b =>
                {
                    b.HasOne("Mystefy.Models.Fragrance", "Fragrance")
                        .WithMany("FragranceIngredients")
                        .HasForeignKey("FragranceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Ingredients", "Ingredients")
                        .WithMany("FragranceIngredients")
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fragrance");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Mystefy.Models.StockRequest", b =>
                {
                    b.HasOne("Mystefy.Models.Ingredients", "Ingredients")
                        .WithMany("StockRequests")
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.User", "User")
                        .WithMany("StockRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany("StockRequests")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredients");

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.StockRequestIngredients", b =>
                {
                    b.HasOne("Mystefy.Models.Ingredients", "Ingredients")
                        .WithMany("StockRequestIngredients")
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.User", "User")
                        .WithMany("StockRequestIngredients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany("StockRequestIngredients")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredients");

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.StockRequestPackagings", b =>
                {
                    b.HasOne("Mystefy.Models.Ingredients", null)
                        .WithMany("StockRequestPackagings")
                        .HasForeignKey("IngredientsId");

                    b.HasOne("Mystefy.Models.Packaging", "Packaging")
                        .WithMany("StockRequestPackagings")
                        .HasForeignKey("PackagingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.User", "User")
                        .WithMany("StockRequestPackagings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany("StockRequestPackagings")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Packaging");

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.WarehouseIngredients", b =>
                {
                    b.HasOne("Mystefy.Models.Ingredients", null)
                        .WithMany("WarehouseIngredients")
                        .HasForeignKey("IngredientsId");
                });

            modelBuilder.Entity("Mystefy.Models.WarehouseStock", b =>
                {
                    b.HasOne("Mystefy.Models.Fragrance", "Fragrance")
                        .WithMany("WarehouseStocks")
                        .HasForeignKey("FragranceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany("WarehouseStocks")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fragrance");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.WasteLossRecordIngredients", b =>
                {
                    b.HasOne("Mystefy.Models.Ingredients", "Ingredients")
                        .WithMany("WasteLossRecordIngredients")
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.User", "User")
                        .WithMany("WasteLossRecordIngredients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany("WasteLossRecordIngredients")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredients");

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.WasteLossRecordPackaging", b =>
                {
                    b.HasOne("Mystefy.Models.Packaging", "Packaging")
                        .WithMany("WasteLossRecordPackaging")
                        .HasForeignKey("PackagingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.User", "User")
                        .WithMany("WasteLossRecordPackaging")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mystefy.Models.Warehouse", "Warehouse")
                        .WithMany("WasteLossRecordPackaging")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Packaging");

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Mystefy.Models.Batch", b =>
                {
                    b.Navigation("BatchFinishedProducts");
                });

            modelBuilder.Entity("Mystefy.Models.Delivery", b =>
                {
                    b.Navigation("DeliveryIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.Fragrance", b =>
                {
                    b.Navigation("FinishedProduct");

                    b.Navigation("FragranceIngredients");

                    b.Navigation("WarehouseStocks");
                });

            modelBuilder.Entity("Mystefy.Models.Ingredients", b =>
                {
                    b.Navigation("DeliveryIngredients");

                    b.Navigation("FragranceIngredients");

                    b.Navigation("StockRequestIngredients");

                    b.Navigation("StockRequestPackagings");

                    b.Navigation("StockRequests");

                    b.Navigation("WarehouseIngredients");

                    b.Navigation("WasteLossRecordIngredients");
                });

            modelBuilder.Entity("Mystefy.Models.Packaging", b =>
                {
                    b.Navigation("FinishedProduct");

                    b.Navigation("StockRequestPackagings");

                    b.Navigation("WasteLossRecordPackaging");
                });

            modelBuilder.Entity("Mystefy.Models.Supplier", b =>
                {
                    b.Navigation("Delivery");
                });

            modelBuilder.Entity("Mystefy.Models.User", b =>
                {
                    b.Navigation("StockRequestIngredients");

                    b.Navigation("StockRequestPackagings");

                    b.Navigation("StockRequests");

                    b.Navigation("WasteLossRecordIngredients");

                    b.Navigation("WasteLossRecordPackaging");
                });

            modelBuilder.Entity("Mystefy.Models.Warehouse", b =>
                {
                    b.Navigation("StockRequestIngredients");

                    b.Navigation("StockRequestPackagings");

                    b.Navigation("StockRequests");

                    b.Navigation("WarehouseStocks");

                    b.Navigation("WasteLossRecordIngredients");

                    b.Navigation("WasteLossRecordPackaging");
                });
#pragma warning restore 612, 618
        }
    }
}
