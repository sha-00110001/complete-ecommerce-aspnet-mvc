﻿// <auto-generated />
using System;
using E_commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_commerce.Migrations
{
    [DbContext(typeof(EcommerceCountext))]
    [Migration("20230831222016_deletefnamelname")]
    partial class deletefnamelname
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_commerce.Models.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AccCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("E_commerce.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("E_commerce.Models.OrderedProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BuyerID")
                        .HasColumnType("int");

                    b.Property<int?>("CardID")
                        .HasColumnType("int");

                    b.Property<int?>("productID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyerID");

                    b.HasIndex("CardID");

                    b.HasIndex("productID");

                    b.ToTable("OrderedProduct");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("M_F")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_commerce.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AccCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("E_commerce.Models.ShippingInfo", b =>
                {
                    b.Property<int>("ShippinginfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShippinginfoID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int?>("buyerID")
                        .HasColumnType("int");

                    b.HasKey("ShippinginfoID");

                    b.HasIndex("buyerID");

                    b.ToTable("ShippingInfo");
                });

            modelBuilder.Entity("E_commerce.Models.Card", b =>
                {
                    b.HasOne("E_commerce.Models.Buyer", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId");

                    b.Navigation("Buyer");
                });

            modelBuilder.Entity("E_commerce.Models.OrderedProduct", b =>
                {
                    b.HasOne("E_commerce.Models.Buyer", "Buyer")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("BuyerID");

                    b.HasOne("E_commerce.Models.Card", "Card")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("CardID");

                    b.HasOne("E_commerce.Models.Product", "Product")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("productID");

                    b.Navigation("Buyer");

                    b.Navigation("Card");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.HasOne("E_commerce.Models.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("E_commerce.Models.ShippingInfo", b =>
                {
                    b.HasOne("E_commerce.Models.Buyer", "buyer")
                        .WithMany("ShippingInfos")
                        .HasForeignKey("buyerID");

                    b.Navigation("buyer");
                });

            modelBuilder.Entity("E_commerce.Models.Buyer", b =>
                {
                    b.Navigation("OrderedProducts");

                    b.Navigation("ShippingInfos");
                });

            modelBuilder.Entity("E_commerce.Models.Card", b =>
                {
                    b.Navigation("OrderedProducts");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.Navigation("OrderedProducts");
                });

            modelBuilder.Entity("E_commerce.Models.Seller", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
