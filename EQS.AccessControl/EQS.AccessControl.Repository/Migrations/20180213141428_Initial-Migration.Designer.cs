﻿// <auto-generated />
using EQS.AccessControl.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EQS.AccessControl.Repository.Migrations
{
    [DbContext(typeof(EntityFrameworkContext))]
    [Migration("20180213141428_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EQS.AccessControl.Domain.Entities.Credential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("PersonId");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("EQS.AccessControl.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CredentialId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("People");
                });

            modelBuilder.Entity("EQS.AccessControl.Domain.Entities.PersonRole", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<int>("RoleId");

                    b.HasKey("PersonId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("PersonRoles");
                });

            modelBuilder.Entity("EQS.AccessControl.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EQS.AccessControl.Domain.Entities.Person", b =>
                {
                    b.HasOne("EQS.AccessControl.Domain.Entities.Credential", "Credential")
                        .WithOne("Person")
                        .HasForeignKey("EQS.AccessControl.Domain.Entities.Person", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EQS.AccessControl.Domain.Entities.PersonRole", b =>
                {
                    b.HasOne("EQS.AccessControl.Domain.Entities.Person", "Person")
                        .WithMany("PersonRoles")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EQS.AccessControl.Domain.Entities.Role", "Roles")
                        .WithMany("PersonRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
