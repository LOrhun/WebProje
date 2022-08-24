﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebProje.Data;

#nullable disable

namespace WebProje.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220824041919_dbchangedagain")]
    partial class dbchangedagain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebProje.Models.Brand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("WebProje.Models.Catagory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Catagory");
                });

            modelBuilder.Entity("WebProje.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Brand")
                        .HasColumnType("integer");

                    b.Property<int?>("Catagory")
                        .HasColumnType("integer");

                    b.Property<bool>("availability")
                        .HasColumnType("boolean");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<bool>("sale")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.HasIndex("Brand");

                    b.HasIndex("Catagory");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebProje.Models.Product", b =>
                {
                    b.HasOne("WebProje.Models.Brand", "brand")
                        .WithMany()
                        .HasForeignKey("Brand");

                    b.HasOne("WebProje.Models.Catagory", "catagory")
                        .WithMany()
                        .HasForeignKey("Catagory");

                    b.Navigation("brand");

                    b.Navigation("catagory");
                });
#pragma warning restore 612, 618
        }
    }
}
