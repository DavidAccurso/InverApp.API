// <auto-generated />
using System;
using InversiApp.API.Repository.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InversiApp.API.Migrations
{
    [DbContext(typeof(InvestmentsContext))]
    partial class InvestmentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InversiApp.API.Models.Investment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("ArsUsdRate")
                        .HasColumnType("float");

                    b.Property<string>("Asset")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BuyPriceArs")
                        .HasColumnType("float");

                    b.Property<double>("BuyPriceUsd")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Dividends")
                        .HasColumnType("float");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<double>("Expenses")
                        .HasColumnType("float");

                    b.Property<double>("Nominals")
                        .HasColumnType("float");

                    b.Property<double?>("Rate")
                        .HasColumnType("float");

                    b.Property<double>("UnitValue")
                        .HasColumnType("float");

                    b.Property<int>("investmentType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Investments");
                });
#pragma warning restore 612, 618
        }
    }
}
