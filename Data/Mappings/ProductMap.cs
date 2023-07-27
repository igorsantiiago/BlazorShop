using BlazorShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorShop.Data.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("TEXT").HasMaxLength(150);
        builder.Property(x => x.Description).IsRequired().HasColumnName("Description").HasColumnType("TEXT");
        builder.Property(x => x.Price).IsRequired().HasColumnName("Price").HasColumnType("REAL");
        builder.Property(x => x.CategoryId).IsRequired().HasColumnName("CategoryId").HasColumnType("INTEGER");

        builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
