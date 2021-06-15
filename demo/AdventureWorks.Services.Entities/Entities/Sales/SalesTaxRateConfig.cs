//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class SalesTaxRateConfig : IEntityTypeConfiguration<SalesTaxRate>
    {
        public void Configure(EntityTypeBuilder<SalesTaxRate> c)
        {
            c.ToTable("SalesTaxRate", "Sales")
             .HasKey(e => e.SalesTaxRateId);

            // configure relationships

            c.HasOne(e => e.StateProvinceObject)
             .WithMany()
             .HasForeignKey(e => e.StateProvinceId);

            // configure properties
          
            c.Property(e => e.SalesTaxRateId)
             .HasColumnName("SalesTaxRateID")
             .HasColumnType("int")
             .IsRequired()
             .ValueGeneratedOnAdd();

            c.Property(e => e.StateProvinceId)
             .HasColumnName("StateProvinceID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.TaxType)
             .HasColumnName("TaxType")
             .HasColumnType("tinyint")
             .IsRequired();

            c.Property(e => e.TaxRate)
             .HasColumnName("TaxRate")
             .HasColumnType("smallmoney")
             .IsRequired();

            c.Property(e => e.Name)
             .HasColumnName("Name")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .IsUnicode()
             .IsRequired();

            c.Property(e => e.Rowguid)
             .HasColumnName("rowguid")
             .HasColumnType("uniqueidentifier")
             .IsRequired();

            c.Property(e => e.ModifiedDate)
             .HasColumnName("ModifiedDate")
             .HasColumnType("datetime")
             .IsRequired();

        }
    }
}