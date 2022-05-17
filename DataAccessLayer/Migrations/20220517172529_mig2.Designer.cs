﻿// <auto-generated />
using System;
using DataAccessLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220517172529_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concreate.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AboutID"));

                    b.Property<string>("AboutDetails1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutDetails2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutImage1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutImage2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AboutMapLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("boolean");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BlogID"));

                    b.Property<string>("BlogContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("BlogThumbnailImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BlogTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryID")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BlogID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("boolean");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CommentID"));

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("CommentTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CommentUsername")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CommentID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ContactID"));

                    b.Property<string>("CantactMail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ContactMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("ContactSubject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactUsername")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Writer", b =>
                {
                    b.Property<int>("WriterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WriterID"));

                    b.Property<string>("WriterAbaout")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterMail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WriterPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("WriterStatus")
                        .HasColumnType("boolean");

                    b.HasKey("WriterID");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concreate.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concreate.Category", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
