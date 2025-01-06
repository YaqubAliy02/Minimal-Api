﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Minimal_Api.Data;

#nullable disable

namespace Minimal_Api.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20250106131024_InitMinimalApi")]
    partial class InitMinimalApi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Minimal_Api.Model.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1fc93f34-b33b-42c8-997f-e7658714090d"),
                            Description = "Book 1 Description",
                            Name = "Book 1"
                        },
                        new
                        {
                            Id = new Guid("db5d7fb1-f254-4a97-9e04-7a3403a6f3fe"),
                            Description = "Book 2 Description",
                            Name = "Book 2"
                        },
                        new
                        {
                            Id = new Guid("56d7ef59-0ace-43fc-a9bb-dd8aff6b33bb"),
                            Description = "Book 3 Description",
                            Name = "Book 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
