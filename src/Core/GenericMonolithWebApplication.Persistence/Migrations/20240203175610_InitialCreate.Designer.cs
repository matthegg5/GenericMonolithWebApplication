﻿// <auto-generated />
using System;
using GenericMonolithWebApplication.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenericMonolithWebApplication.Persistence.Migrations
{
    [DbContext(typeof(GenericDbContext))]
    [Migration("20240203175610_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GenericMonolithWebApplication.Domain.Entities.Part", b =>
                {
                    b.Property<Guid>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PartDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PartNum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PartId");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            PartId = new Guid("31ae5210-236f-4e65-ac59-b6b16e204c9e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PartDescription = "MATT-NEW-PART",
                            PartNum = "MATT-NEW-PART"
                        });
                });

            modelBuilder.Entity("GenericMonolithWebApplication.Domain.Entities.PartRevision", b =>
                {
                    b.Property<Guid>("PartRevisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("PartId")
                        .HasColumnType("char(36)");

                    b.Property<string>("RevisionNum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PartRevisionId");

                    b.ToTable("PartRevisions");
                });
#pragma warning restore 612, 618
        }
    }
}