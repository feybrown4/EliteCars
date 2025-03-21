﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using elitecars_admin.Data;

#nullable disable

namespace elitecars_admin.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("elitecars_admin.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("elitecars_admin.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "car_id");

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("CarType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "car_type");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasAnnotation("Relational:JsonPropertyName", "created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "is_active");

                    b.Property<bool>("IsModify")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "is_modify");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarId", "AdminId", "InventoryId");

                    b.HasIndex("AdminId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("elitecars_admin.Models.CarMod", b =>
                {
                    b.Property<int>("CarModId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarModId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ModificationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarModId");

                    b.ToTable("CarMods");
                });

            modelBuilder.Entity("elitecars_admin.Models.CarOption", b =>
                {
                    b.Property<int>("CarOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarOptionId"));

                    b.Property<int?>("CarAdminId")
                        .HasColumnType("int");

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<int?>("CarInventoryId")
                        .HasColumnType("int");

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarOptionId");

                    b.HasIndex("CarId", "CarAdminId", "CarInventoryId");

                    b.ToTable("CarOptions");
                });

            modelBuilder.Entity("elitecars_admin.Models.CarOptionMod", b =>
                {
                    b.Property<int>("CarOptionModId")
                        .HasColumnType("int");

                    b.Property<int>("CarOptionId")
                        .HasColumnType("int");

                    b.Property<int>("CarModId")
                        .HasColumnType("int");

                    b.HasKey("CarOptionModId", "CarOptionId", "CarModId");

                    b.HasIndex("CarModId");

                    b.HasIndex("CarOptionId");

                    b.ToTable("CarOptionMods");
                });

            modelBuilder.Entity("elitecars_admin.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartId", "CarId", "CustomerId");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("elitecars_admin.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("elitecars_admin.Models.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("FavoriteId", "CarId", "CustomerId");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("elitecars_admin.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("elitecars_admin.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPickup")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("elitecars_admin.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderItemId", "OrderId", "CarId");

                    b.HasIndex("CarId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("elitecars_admin.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionId"));

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("elitecars_admin.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("elitecars_admin.Models.RolePermission", b =>
                {
                    b.Property<int>("RolePermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RolePermissionId", "RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("elitecars_admin.Models.Admin", b =>
                {
                    b.HasOne("elitecars_admin.Models.Role", "Role")
                        .WithMany("Admin")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("elitecars_admin.Models.Car", b =>
                {
                    b.HasOne("elitecars_admin.Models.Admin", "Admin")
                        .WithMany("Cars")
                        .HasForeignKey("AdminId")
                        .HasPrincipalKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("elitecars_admin.Models.Inventory", "Inventory")
                        .WithMany("Cars")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("elitecars_admin.Models.CarOption", b =>
                {
                    b.HasOne("elitecars_admin.Models.Car", null)
                        .WithMany("CarOptions")
                        .HasForeignKey("CarId", "CarAdminId", "CarInventoryId");
                });

            modelBuilder.Entity("elitecars_admin.Models.CarOptionMod", b =>
                {
                    b.HasOne("elitecars_admin.Models.CarMod", "CarMod")
                        .WithMany("CarOptionMods")
                        .HasForeignKey("CarModId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("elitecars_admin.Models.CarOption", "CarOption")
                        .WithMany("CarOptionMods")
                        .HasForeignKey("CarOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarMod");

                    b.Navigation("CarOption");
                });

            modelBuilder.Entity("elitecars_admin.Models.Cart", b =>
                {
                    b.HasOne("elitecars_admin.Models.Car", "Cars")
                        .WithMany("Carts")
                        .HasForeignKey("CarId")
                        .HasPrincipalKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("elitecars_admin.Models.Customer", "Customers")
                        .WithMany("Carts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cars");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("elitecars_admin.Models.Favorite", b =>
                {
                    b.HasOne("elitecars_admin.Models.Car", "Car")
                        .WithMany("Favorites")
                        .HasForeignKey("CarId")
                        .HasPrincipalKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("elitecars_admin.Models.Customer", "Customer")
                        .WithMany("Favorites")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("elitecars_admin.Models.Order", b =>
                {
                    b.HasOne("elitecars_admin.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("elitecars_admin.Models.OrderItem", b =>
                {
                    b.HasOne("elitecars_admin.Models.Car", "Car")
                        .WithMany("OrderItems")
                        .HasForeignKey("CarId")
                        .HasPrincipalKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("elitecars_admin.Models.Order", "Orders")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasPrincipalKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("elitecars_admin.Models.RolePermission", b =>
                {
                    b.HasOne("elitecars_admin.Models.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("elitecars_admin.Models.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("elitecars_admin.Models.Admin", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("elitecars_admin.Models.Car", b =>
                {
                    b.Navigation("CarOptions");

                    b.Navigation("Carts");

                    b.Navigation("Favorites");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("elitecars_admin.Models.CarMod", b =>
                {
                    b.Navigation("CarOptionMods");
                });

            modelBuilder.Entity("elitecars_admin.Models.CarOption", b =>
                {
                    b.Navigation("CarOptionMods");
                });

            modelBuilder.Entity("elitecars_admin.Models.Customer", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Favorites");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("elitecars_admin.Models.Inventory", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("elitecars_admin.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("elitecars_admin.Models.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("elitecars_admin.Models.Role", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("RolePermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
