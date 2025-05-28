using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public partial class QuizletLiteContext : DbContext
{
    public QuizletLiteContext()
    {
    }

    public QuizletLiteContext(DbContextOptions<QuizletLiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionType> QuestionTypes { get; set; }

    public virtual DbSet<Quiz> Quizzes { get; set; }

    public virtual DbSet<QuizResult> QuizResults { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SelectedAnswer> SelectedAnswers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Answer__3214EC070FDE57A4");

            entity.ToTable("Answer");

            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Question).WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__Answer__Question__45F365D3");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3214EC070F4181C1");

            entity.ToTable("Question");

            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.QuestionType).WithMany(p => p.Questions)
                .HasForeignKey(d => d.QuestionTypeId)
                .HasConstraintName("FK__Question__Questi__4316F928");

            entity.HasOne(d => d.Quiz).WithMany(p => p.Questions)
                .HasForeignKey(d => d.QuizId)
                .HasConstraintName("FK__Question__QuizId__4222D4EF");
        });

        modelBuilder.Entity<QuestionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3214EC07A59E4B0E");

            entity.ToTable("QuestionType");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Quiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quiz__3214EC076ED21158");

            entity.ToTable("Quiz");

            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue((short)0);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Quizzes)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Quiz__CreatedBy__3C69FB99");
        });

        modelBuilder.Entity<QuizResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuizResu__3214EC07132C7DB4");

            entity.ToTable("QuizResult");

            entity.HasOne(d => d.Quiz).WithMany(p => p.QuizResults)
                .HasForeignKey(d => d.QuizId)
                .HasConstraintName("FK__QuizResul__QuizI__49C3F6B7");

            entity.HasOne(d => d.User).WithMany(p => p.QuizResults)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__QuizResul__UserI__48CFD27E");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC0736FCB68F");

            entity.ToTable("Role");

            entity.Property(e => e.Role1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Role");
        });

        modelBuilder.Entity<SelectedAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Selected__3214EC07B5161FE6");

            entity.ToTable("SelectedAnswer");

            entity.HasOne(d => d.Answer).WithMany(p => p.SelectedAnswers)
                .HasForeignKey(d => d.AnswerId)
                .HasConstraintName("FK__SelectedA__Answe__4E88ABD4");

            entity.HasOne(d => d.Question).WithMany(p => p.SelectedAnswers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__SelectedA__Quest__4D94879B");

            entity.HasOne(d => d.QuizResult).WithMany(p => p.SelectedAnswers)
                .HasForeignKey(d => d.QuizResultId)
                .HasConstraintName("FK__SelectedA__QuizR__4CA06362");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC0788CB7CA8");

            entity.ToTable("User");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(26)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__User__RoleId__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
