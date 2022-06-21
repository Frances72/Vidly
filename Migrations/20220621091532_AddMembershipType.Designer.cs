﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Vidly.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20220621091532_AddMembershipType")]
    partial class AddMembershipType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSubscribedToNewsletter")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("MembershipTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MembershipTypeId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("iD");

                    b.HasIndex("MembershipTypeId1");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Vidly.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("DurationInMonths")
                        .HasColumnType("INTEGER");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MembershipType");
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.HasOne("Vidly.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");
                });
#pragma warning restore 612, 618
        }
    }
}
