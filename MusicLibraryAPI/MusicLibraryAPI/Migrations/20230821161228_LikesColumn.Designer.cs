﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicLibraryAPI.Data;

#nullable disable

namespace MusicLibraryAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230821161228_LikesColumn")]
    partial class LikesColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MusicLibraryAPI.Models.MusicLibrary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MusicLibraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "Dark Lane Demo Tapes",
                            Artist = "Drake",
                            Genre = "Hip-Hop",
                            Likes = 0,
                            ReleaseDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Chicago Freestyle"
                        },
                        new
                        {
                            Id = 2,
                            Album = "Dark Lane Demo Tapes",
                            Artist = "Drake",
                            Genre = "Hip-Hop",
                            Likes = 0,
                            ReleaseDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Time Flies"
                        },
                        new
                        {
                            Id = 3,
                            Album = "If You're Reading This It's Too Late",
                            Artist = "Drake",
                            Genre = "Hip-Hop",
                            Likes = 0,
                            ReleaseDate = new DateTime(2015, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Madonna"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Adjustments - Single",
                            Artist = "Mad Keys",
                            Genre = "Hip-Hop",
                            Likes = 0,
                            ReleaseDate = new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Adjustments"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
