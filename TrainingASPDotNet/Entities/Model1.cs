namespace TrainingASPDotNet.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Database")
        {
        }

        public virtual DbSet<MuatNaikExcel> MuatNaikExcels { get; set; }
        public virtual DbSet<PencapaianProgram> PencapaianPrograms { get; set; }
        public virtual DbSet<PencapaianProgramExcel> PencapaianProgramExcels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.NamaAsal)
                .IsUnicode(false);

            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.NamaBaru)
                .IsUnicode(false);

            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.Lokasi)
                .IsUnicode(false);

            modelBuilder.Entity<MuatNaikExcel>()
                .HasMany(e => e.PencapaianProgramExcels)
                .WithOptional(e => e.MuatNaikExcel)
                .HasForeignKey(e => e.IdMuatNaikExcel);

            modelBuilder.Entity<PencapaianProgram>()
                .Property(e => e.KodProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgram>()
                .Property(e => e.JenisKemasukan)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.KodProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.TarikhProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.BilanganHari)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.Lulus)
                .IsUnicode(false);

            modelBuilder.Entity<PencapaianProgramExcel>()
                .Property(e => e.Ralat)
                .IsUnicode(false);
        }
    }
}
