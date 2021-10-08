using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace IS531_DonutsProject.Models
{
    public class DonutsContext : DbContext
    {
        public DonutsContext(DbContextOptions<DonutsContext> options) : base(options)
        {}

        public DbSet<Donut> Donuts { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=database-1-caroline.ctqvxzjxajyn.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Donuts;User Id=admin;Password=project1;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

//            modelBuilder.Entity<Donut>(entity =>
//            {
//                entity.Property(e => e.DonutId).ValueGeneratedNever();

//                entity.Property(e => e.Category)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DonutDescription)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("Donut_Description");

//                entity.Property(e => e.DonutName)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("Donut_name");

//                entity.Property(e => e.ImageUrl)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("image_url");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
