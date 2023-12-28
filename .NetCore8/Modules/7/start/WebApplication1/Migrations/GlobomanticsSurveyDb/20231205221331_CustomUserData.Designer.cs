﻿// <auto-generated />
using System;
using Globomantics.Survey.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Globomantics.Survey.Migrations.GlobomanticsSurveyDb
{
    [DbContext(typeof(GlobomanticsSurveyDbContext))]
    [Migration("20231205221331_CustomUserData")]
    partial class CustomUserData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Globomantics.Survey.Models.CustomerSurvey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("SurveyCompleteMessage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CustomerSurveys");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9900"),
                            SurveyCompleteMessage = "You completed the survey, THANKS!!!",
                            Title = "Staff Survey - Carved Rock"
                        });
                });

            modelBuilder.Entity("Globomantics.Survey.Models.CustomerSurveyResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CustomerSurveyResponses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e6e91a64-57a6-42fc-8898-c486d7375ed0"),
                            SurveyId = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9900")
                        },
                        new
                        {
                            Id = new Guid("de174fb5-3671-470f-b84d-c529971ddfd4"),
                            SurveyId = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9900")
                        });
                });

            modelBuilder.Entity("Globomantics.Survey.Models.SurveyAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SurveyResponseId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SurveyResponseId");

                    b.ToTable("SurveyAnswer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("465504e2-a5fc-4700-9d3e-0a5a0f027ccc"),
                            Answer = "Less than 1 year",
                            Question = "How long have you worked at Carved Rock?",
                            SurveyResponseId = new Guid("e6e91a64-57a6-42fc-8898-c486d7375ed0")
                        },
                        new
                        {
                            Id = new Guid("2afdf24e-f422-491e-9dfd-0e6c0dfdfa17"),
                            Answer = "Yes",
                            Question = "Do you enjoy working at Carved Rock?",
                            SurveyResponseId = new Guid("e6e91a64-57a6-42fc-8898-c486d7375ed0")
                        },
                        new
                        {
                            Id = new Guid("c257e3a4-4196-4ba8-9b51-26d7721cb1b6"),
                            Answer = "It's really cool here!",
                            Question = "Any comments on how you find working for Carved Rock?",
                            SurveyResponseId = new Guid("e6e91a64-57a6-42fc-8898-c486d7375ed0")
                        },
                        new
                        {
                            Id = new Guid("da611407-4e4c-4383-b5b6-40fef6a1ae05"),
                            Answer = "More than 5 years",
                            Question = "How long have you worked at Carved Rock?",
                            SurveyResponseId = new Guid("de174fb5-3671-470f-b84d-c529971ddfd4")
                        },
                        new
                        {
                            Id = new Guid("2d001c19-d3ed-4adb-ad9d-1c14361e8a09"),
                            Answer = "No",
                            Question = "Do you enjoy working at Carved Rock?",
                            SurveyResponseId = new Guid("de174fb5-3671-470f-b84d-c529971ddfd4")
                        },
                        new
                        {
                            Id = new Guid("6555b63d-fa18-4c21-9913-f19cb3484618"),
                            Answer = "My computer is really slow",
                            Question = "Any comments on how you find working for Carved Rock?",
                            SurveyResponseId = new Guid("de174fb5-3671-470f-b84d-c529971ddfd4")
                        });
                });

            modelBuilder.Entity("Globomantics.Survey.Models.SurveyQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PossibleAnswers")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("CustomerSurveyQuestions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9901"),
                            Answer = "",
                            PossibleAnswers = "Less than 1 year|1-5 years|More than 5 years",
                            Question = "How long have you worked at Carved Rock?",
                            SurveyId = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9900")
                        },
                        new
                        {
                            Id = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9902"),
                            Answer = "",
                            PossibleAnswers = "Yes|No|Sometimes",
                            Question = "Do you enjoy working at Carved Rock?",
                            SurveyId = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9900")
                        },
                        new
                        {
                            Id = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9903"),
                            Answer = "",
                            PossibleAnswers = "",
                            Question = "Any comments on how you find working for Carved Rock?",
                            SurveyId = new Guid("8f8afc29-228d-4508-9f7a-7d17c4ae9900")
                        });
                });

            modelBuilder.Entity("Globomantics.Survey.Models.SurveyAnswer", b =>
                {
                    b.HasOne("Globomantics.Survey.Models.CustomerSurveyResponse", "SurveyResponse")
                        .WithMany("Answers")
                        .HasForeignKey("SurveyResponseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SurveyResponse");
                });

            modelBuilder.Entity("Globomantics.Survey.Models.SurveyQuestion", b =>
                {
                    b.HasOne("Globomantics.Survey.Models.CustomerSurvey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Globomantics.Survey.Models.CustomerSurvey", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Globomantics.Survey.Models.CustomerSurveyResponse", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
