﻿// <auto-generated />
using ComicsManager.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ComicsManager.Model.Migrations
{
    [DbContext(typeof(ComicsManagerContext))]
    partial class ComicsManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComicsManager.Model.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Photo");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("ComicsManager.Model.Models.Comic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Collection");

                    b.Property<Guid?>("CouvertureId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int?>("Cycle");

                    b.Property<Guid?>("DessinateurId");

                    b.Property<Guid?>("EditorId");

                    b.Property<Guid?>("FileId");

                    b.Property<Guid>("GenreId");

                    b.Property<string>("ISBN");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<int?>("Note");

                    b.Property<DateTime>("PublicationDate");

                    b.Property<Guid?>("ScenaristeId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CouvertureId");

                    b.HasIndex("DessinateurId");

                    b.HasIndex("EditorId");

                    b.HasIndex("FileId");

                    b.HasIndex("GenreId");

                    b.HasIndex("ScenaristeId");

                    b.ToTable("Comics");
                });

            modelBuilder.Entity("ComicsManager.Model.Models.Editor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Editors");
                });

            modelBuilder.Entity("ComicsManager.Model.Models.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<byte[]>("Path");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("ComicsManager.Model.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ComicsManager.Model.Models.Comic", b =>
                {
                    b.HasOne("ComicsManager.Model.Models.File", "Couverture")
                        .WithMany()
                        .HasForeignKey("CouvertureId");

                    b.HasOne("ComicsManager.Model.Models.Author", "Dessinateur")
                        .WithMany("Dessinateurs")
                        .HasForeignKey("DessinateurId");

                    b.HasOne("ComicsManager.Model.Models.Editor", "Editeur")
                        .WithMany()
                        .HasForeignKey("EditorId");

                    b.HasOne("ComicsManager.Model.Models.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId");

                    b.HasOne("ComicsManager.Model.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComicsManager.Model.Models.Author", "Scenariste")
                        .WithMany("Scenaristes")
                        .HasForeignKey("ScenaristeId");
                });
#pragma warning restore 612, 618
        }
    }
}
