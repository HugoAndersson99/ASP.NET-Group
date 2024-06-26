﻿// <auto-generated />
using ASP.Net_GruppUPG.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.Net_GruppUPG.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240425085247_CreateMovieTable")]
    partial class CreateMovieTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ASP.Net_GruppUPG.Objects.MediaUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MediaUser");
                });

            modelBuilder.Entity("ASP.Net_GruppUPG.Objects.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("LengthMin")
                        .HasColumnType("int");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("MovieId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("ASP.Net_GruppUPG.Objects.Serie", b =>
                {
                    b.Property<int>("SerieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SerieId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Episodes")
                        .HasColumnType("int");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<int>("Seasons")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("SerieId");

                    b.ToTable("Serie");
                });
#pragma warning restore 612, 618
        }
    }
}
