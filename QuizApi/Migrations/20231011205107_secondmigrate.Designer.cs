﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApi.Context;

#nullable disable

namespace QuizApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231011205107_secondmigrate")]
    partial class secondmigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuizApi.Models.AppUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuizApi.Models.Categories", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("QuizApi.Models.Question", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<int>("quizid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("quizid");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizApi.Models.Quiz", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("SectionId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("QuizApi.Models.Response", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("isok")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("questionId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("questionId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("QuizApi.Models.Sections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("QuizApi.Models.Question", b =>
                {
                    b.HasOne("QuizApi.Models.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("quizid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("QuizApi.Models.Quiz", b =>
                {
                    b.HasOne("QuizApi.Models.Sections", "Section")
                        .WithMany("Quizzes")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("QuizApi.Models.Response", b =>
                {
                    b.HasOne("QuizApi.Models.Question", "Question")
                        .WithMany("Responses")
                        .HasForeignKey("questionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizApi.Models.Sections", b =>
                {
                    b.HasOne("QuizApi.Models.Categories", "Categorie")
                        .WithMany("Sections")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("QuizApi.Models.Categories", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("QuizApi.Models.Question", b =>
                {
                    b.Navigation("Responses");
                });

            modelBuilder.Entity("QuizApi.Models.Quiz", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("QuizApi.Models.Sections", b =>
                {
                    b.Navigation("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
