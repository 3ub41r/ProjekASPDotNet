namespace TrainingASPDotNet.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PencapaianProgramExcel")]
    public partial class PencapaianProgramExcel
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string KodProgram { get; set; }

        [StringLength(500)]
        public string TarikhProgram { get; set; }

        [StringLength(500)]
        public string BilanganHari { get; set; }

        [StringLength(500)]
        public string Lulus { get; set; }

        public int? IdMuatNaikExcel { get; set; }

        [StringLength(500)]
        public string Ralat { get; set; }

        public DateTime? TarikhDiimpot { get; set; }

        public virtual MuatNaikExcel MuatNaikExcel { get; set; }
    }
}
