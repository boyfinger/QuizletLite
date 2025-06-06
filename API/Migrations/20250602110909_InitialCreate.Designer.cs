﻿// <auto-generated />
using System;
using API.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(QuizletLiteContext))]
    [Migration("20250602110909_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Paris",
                            IsCorrect = true,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "London",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Mars",
                            IsCorrect = true,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            Content = "Venus",
                            IsCorrect = true,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "Pluto",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "George Washington",
                            IsCorrect = true,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "Thomas Jefferson",
                            IsCorrect = false,
                            QuestionId = 3
                        });
                });

            modelBuilder.Entity("API.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("int");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTypeId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "What is the capital of France?",
                            QuestionTypeId = 1,
                            QuizId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Which planets are part of the solar system?",
                            QuestionTypeId = 2,
                            QuizId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "Who was the first President of the United States?",
                            QuestionTypeId = 1,
                            QuizId = 3
                        });
                });

            modelBuilder.Entity("API.Models.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Single Choice"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Multiple Choice"
                        });
                });

            modelBuilder.Entity("API.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByNavigationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByNavigationId");

                    b.ToTable("Quizzes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 2,
                            CreatedOn = new DateTime(2025, 6, 2, 18, 9, 9, 450, DateTimeKind.Local).AddTicks(822),
                            IsActive = true,
                            Name = "General Knowledge Quiz"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = 2,
                            CreatedOn = new DateTime(2025, 6, 2, 18, 9, 9, 450, DateTimeKind.Local).AddTicks(832),
                            IsActive = true,
                            Name = "Science Trivia"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = 3,
                            CreatedOn = new DateTime(2025, 6, 2, 18, 9, 9, 450, DateTimeKind.Local).AddTicks(833),
                            IsActive = true,
                            Name = "History Challenge"
                        });
                });

            modelBuilder.Entity("API.Models.QuizResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.HasIndex("UserId");

                    b.ToTable("QuizResults");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Role1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Role1 = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Role1 = "User"
                        });
                });

            modelBuilder.Entity("API.Models.SelectedAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("QuizResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("QuizResultId");

                    b.ToTable("SelectedAnswers");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@email.com",
                            Password = "123",
                            RoleId = 1,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user1@email.com",
                            Password = "123",
                            RoleId = 2,
                            Username = "user1"
                        },
                        new
                        {
                            Id = 3,
                            Email = "user2@email.com",
                            Password = "123",
                            RoleId = 2,
                            Username = "user2"
                        });
                });

            modelBuilder.Entity("API.Models.Answer", b =>
                {
                    b.HasOne("API.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("API.Models.Question", b =>
                {
                    b.HasOne("API.Models.QuestionType", "QuestionType")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionType");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("API.Models.Quiz", b =>
                {
                    b.HasOne("API.Models.User", "CreatedByNavigation")
                        .WithMany("Quizzes")
                        .HasForeignKey("CreatedByNavigationId");

                    b.Navigation("CreatedByNavigation");
                });

            modelBuilder.Entity("API.Models.QuizResult", b =>
                {
                    b.HasOne("API.Models.Quiz", "Quiz")
                        .WithMany("QuizResults")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.User", "User")
                        .WithMany("QuizResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API.Models.SelectedAnswer", b =>
                {
                    b.HasOne("API.Models.Answer", "Answer")
                        .WithMany("SelectedAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Models.Question", "Question")
                        .WithMany("SelectedAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Models.QuizResult", "QuizResult")
                        .WithMany("SelectedAnswers")
                        .HasForeignKey("QuizResultId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");

                    b.Navigation("QuizResult");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.HasOne("API.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API.Models.Answer", b =>
                {
                    b.Navigation("SelectedAnswers");
                });

            modelBuilder.Entity("API.Models.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("SelectedAnswers");
                });

            modelBuilder.Entity("API.Models.QuestionType", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("API.Models.Quiz", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("QuizResults");
                });

            modelBuilder.Entity("API.Models.QuizResult", b =>
                {
                    b.Navigation("SelectedAnswers");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Navigation("QuizResults");

                    b.Navigation("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
