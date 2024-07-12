﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240527060917_canitryitt")]
    partial class canitryitt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Activity", b =>
                {
                    b.Property<int>("ActivityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityID"));

                    b.Property<int>("ActivityCapacity")
                        .HasColumnType("int");

                    b.Property<string>("ActivityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ActivityIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FounderID")
                        .HasColumnType("int");

                    b.HasKey("ActivityID");

                    b.HasIndex("FounderID");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ActivityUser", b =>
                {
                    b.Property<int>("ActivityID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ActivityID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("ActivityUsers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerId"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Day", b =>
                {
                    b.Property<int>("DayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayID"));

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeekID")
                        .HasColumnType("int");

                    b.HasKey("DayID");

                    b.HasIndex("WeekID");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Exercise", b =>
                {
                    b.Property<int>("ExerciseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseID"));

                    b.Property<int>("ExerciseCategory")
                        .HasColumnType("int");

                    b.Property<string>("ExerciseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ExerciseIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ExerciseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseID");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ExerciseExerciseProgram", b =>
                {
                    b.Property<int>("ExerciseExerciseProgramID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseExerciseProgramID"));

                    b.Property<int>("ExerciseID")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseProgramId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseExerciseProgramID");

                    b.HasIndex("ExerciseID");

                    b.HasIndex("ExerciseProgramId");

                    b.ToTable("ExerciseExercisePrograms");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ExerciseProgram", b =>
                {
                    b.Property<int>("ExerciseProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseProgramId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseProgramId");

                    b.ToTable("ExercisePrograms");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodID"));

                    b.Property<int>("FoodCalory")
                        .HasColumnType("int");

                    b.Property<int>("FoodCarb")
                        .HasColumnType("int");

                    b.Property<string>("FoodDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodFat")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodProtein")
                        .HasColumnType("int");

                    b.HasKey("FoodID");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Manager", b =>
                {
                    b.Property<int>("ManagerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerID"));

                    b.Property<string>("ManagerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Meal", b =>
                {
                    b.Property<int>("MealID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealID"));

                    b.Property<int>("MealCalory")
                        .HasColumnType("int");

                    b.Property<int>("MealCarb")
                        .HasColumnType("int");

                    b.Property<string>("MealDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MealFat")
                        .HasColumnType("int");

                    b.Property<string>("MealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MealProtein")
                        .HasColumnType("int");

                    b.HasKey("MealID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MealPlan", b =>
                {
                    b.Property<int>("MealPlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealPlanID"));

                    b.Property<string>("MealPlanDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealPlanImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealPlanName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MealPlanID");

                    b.ToTable("MealPlans");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserHeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserWeight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UserExerciseProgram", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseProgramId")
                        .HasColumnType("int");

                    b.HasKey("UserID", "ExerciseProgramId");

                    b.HasIndex("ExerciseProgramId");

                    b.ToTable("UserExercisePrograms");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Week", b =>
                {
                    b.Property<int>("WeekID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeekID"));

                    b.Property<int>("ExerciseProgramId")
                        .HasColumnType("int");

                    b.Property<int>("WeekCategories")
                        .HasColumnType("int");

                    b.Property<string>("WeekDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeekName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeekPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeekID");

                    b.HasIndex("ExerciseProgramId");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Activity", b =>
                {
                    b.HasOne("EntityLayer.Concrete.User", "Founder")
                        .WithMany()
                        .HasForeignKey("FounderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Founder");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ActivityUser", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Activity", "Activity")
                        .WithMany("ActivityUsers")
                        .HasForeignKey("ActivityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("ActivityUsers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Answer", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Day", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Week", "Week")
                        .WithMany("Days")
                        .HasForeignKey("WeekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Week");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ExerciseExerciseProgram", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Exercise", "Exercise")
                        .WithMany("ExerciseExercisePrograms")
                        .HasForeignKey("ExerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.ExerciseProgram", "ExerciseProgram")
                        .WithMany("ExerciseExercisePrograms")
                        .HasForeignKey("ExerciseProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("ExerciseProgram");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Department", "Department")
                        .WithMany("User")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UserExerciseProgram", b =>
                {
                    b.HasOne("EntityLayer.Concrete.ExerciseProgram", "ExerciseProgram")
                        .WithMany("UserExercisePrograms")
                        .HasForeignKey("ExerciseProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("UserExercisePrograms")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseProgram");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Week", b =>
                {
                    b.HasOne("EntityLayer.Concrete.ExerciseProgram", "ExerciseProgram")
                        .WithMany("Weeks")
                        .HasForeignKey("ExerciseProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseProgram");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Activity", b =>
                {
                    b.Navigation("ActivityUsers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Department", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Exercise", b =>
                {
                    b.Navigation("ExerciseExercisePrograms");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ExerciseProgram", b =>
                {
                    b.Navigation("ExerciseExercisePrograms");

                    b.Navigation("UserExercisePrograms");

                    b.Navigation("Weeks");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Navigation("ActivityUsers");

                    b.Navigation("UserExercisePrograms");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Week", b =>
                {
                    b.Navigation("Days");
                });
#pragma warning restore 612, 618
        }
    }
}
