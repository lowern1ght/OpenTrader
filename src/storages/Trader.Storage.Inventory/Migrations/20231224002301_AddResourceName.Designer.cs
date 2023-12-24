﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Trader.Storage.Inventory;

#nullable disable

namespace Trader.Storage.Inventory.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20231224002301_AddResourceName")]
    partial class AddResourceName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Trader.Storage.Inventory.Models.Exchange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("base_url");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("resource_name");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_exchanges");

                    b.ToTable("exchanges", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5cdfe774-ec24-4d3f-8202-505c4cb8c848"),
                            BaseUrl = "www.deribit.com",
                            ResourceName = "deribit",
                            Title = "deribit"
                        },
                        new
                        {
                            Id = new Guid("8691dd34-b741-400a-8aec-4e4d99365953"),
                            BaseUrl = "test.deribit.com",
                            ResourceName = "deribit-test",
                            Title = "test.deribit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
