using MaskShop.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MaskShop.DataAccess.Context
{
    public partial class MaskDirectoryContext: DbContext
    {
        public MaskDirectoryContext() { }

        public MaskDirectoryContext(DbContextOptions<MaskDirectoryContext> options)
        : base(options){}

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Mask> Mask { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
               //entity.Property(e => e.id).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
                

               entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.parentId);
            });

            modelBuilder.Entity<Mask>(entity =>
            {
                //entity.Property(e => e.id).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
                entity.Property(e => e.name).IsRequired();
                entity.Property(e => e.price).IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Mask)
                    .HasForeignKey(d => d.CategoryId);
            });

            this.OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
