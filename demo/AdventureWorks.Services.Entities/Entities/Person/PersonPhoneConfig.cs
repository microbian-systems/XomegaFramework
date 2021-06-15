//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class PersonPhoneConfig : IEntityTypeConfiguration<PersonPhone>
    {
        public void Configure(EntityTypeBuilder<PersonPhone> c)
        {
            c.ToTable("PersonPhone", "Person")
             .HasKey(e => new { e.BusinessEntityId, e.PhoneNumber, e.PhoneNumberTypeId });

            // configure relationships

            c.HasOne(e => e.BusinessEntityObject)
             .WithMany()
             .HasForeignKey(e => e.BusinessEntityId);

            c.HasOne(e => e.PhoneNumberTypeObject)
             .WithMany()
             .HasForeignKey(e => e.PhoneNumberTypeId);

            // configure properties
          
            c.Property(e => e.BusinessEntityId)
             .HasColumnName("BusinessEntityID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.PhoneNumber)
             .HasColumnName("PhoneNumber")
             .HasColumnType("nvarchar")
             .HasMaxLength(25)
             .IsUnicode()
             .IsRequired();

            c.Property(e => e.PhoneNumberTypeId)
             .HasColumnName("PhoneNumberTypeID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.ModifiedDate)
             .HasColumnName("ModifiedDate")
             .HasColumnType("datetime")
             .IsRequired();

        }
    }
}