﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradingApp.Infrastructure.Persistence;

namespace TradingApp.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(TradingAppDbContext))]
    partial class TradingAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("TradingApp.Infrastructure.Data.Model.PortfolioStock", b =>
                {
                    b.Property<int>("PortfolioStockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("datetime");

                    b.Property<int>("BuyPrice")
                        .HasColumnType("int");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.HasKey("PortfolioStockId");

                    b.HasIndex("StockId");

                    b.ToTable("PortfolioStocks");
                });

            modelBuilder.Entity("TradingApp.Infrastructure.Data.Model.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Ticket")
                        .HasColumnType("text");

                    b.HasKey("StockId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("TradingApp.Infrastructure.Data.Model.PortfolioStock", b =>
                {
                    b.HasOne("TradingApp.Infrastructure.Data.Model.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });
#pragma warning restore 612, 618
        }
    }
}