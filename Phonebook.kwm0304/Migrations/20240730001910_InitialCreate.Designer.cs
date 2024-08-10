﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phonebook.kwm0304.Data;

#nullable disable

namespace Phonebook.kwm0304.Migrations
{
    [DbContext(typeof(PhonebookContext))]
    [Migration("20240730001910_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Phonebook.kwm0304.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactPhoneInt")
                        .HasColumnType("int");

                    b.Property<string>("ContactPhoneStr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ContactId");

                    b.HasIndex("GroupName");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Phonebook.kwm0304.Models.ContactGroup", b =>
                {
                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupName");

                    b.ToTable("ContactGroups");
                });

            modelBuilder.Entity("Phonebook.kwm0304.Models.Contact", b =>
                {
                    b.HasOne("Phonebook.kwm0304.Models.ContactGroup", "Group")
                        .WithMany()
                        .HasForeignKey("GroupName");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
