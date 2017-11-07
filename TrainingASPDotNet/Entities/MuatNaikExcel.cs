namespace TrainingASPDotNet.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MuatNaikExcel")]
    public partial class MuatNaikExcel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MuatNaikExcel()
        {
            PencapaianProgramExcels = new HashSet<PencapaianProgramExcel>();
        }

        public int Id { get; set; }

        [StringLength(500)]
        public string NamaAsal { get; set; }

        [StringLength(500)]
        public string NamaBaru { get; set; }

        public DateTime? TarikhMuatNaik { get; set; }

        [StringLength(500)]
        public string Lokasi { get; set; }

        public DateTime? TarikhDiimpot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PencapaianProgramExcel> PencapaianProgramExcels { get; set; }
    }
}
