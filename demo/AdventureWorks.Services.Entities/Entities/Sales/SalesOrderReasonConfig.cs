//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class SalesOrderReasonConfig : IEntityTypeConfiguration<SalesOrderReason>
    {
        public void Configure(EntityTypeBuilder<SalesOrderReason> c)
        {
            c.ToTable("SalesOrderHeaderSalesReason", "Sales")
             .HasKey(e => new { e.SalesOrderId, e.SalesReasonId });

            // configure relationships

            c.HasOne(e => e.SalesOrderObject)
             .WithMany(p => p.ReasonObjectList)
             .HasForeignKey(e => e.SalesOrderId)
             .OnDelete(DeleteBehavior.Cascade);

            c.HasOne(e => e.SalesReasonObject)
             .WithMany()
             .HasForeignKey(e => e.SalesReasonId);

            // configure properties
          
            c.Property(e => e.SalesOrderId)
             .HasColumnName("SalesOrderID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.SalesReasonId)
             .HasColumnName("SalesReasonID")
             .HasColumnType("int")
             .IsRequired()
             .ValueGeneratedNever();

            c.Property(e => e.ModifiedDate)
             .HasColumnName("ModifiedDate")
             .HasColumnType("datetime")
             .IsRequired();

        }
    }
}