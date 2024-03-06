using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgenziaSpedizioni.Models
{
    public class StatoSpedizione
    {
        [Key]
        public int IDStato { get; set; }

        [Required]
        [ForeignKey("Spedizione")]
        public int IDSpedizione { get; set; }

        [Required]
        [MaxLength(50)]
        public string StatoConsegna { get; set; }

        [MaxLength(255)]
        public string LuogoPacco { get; set; }

        [MaxLength(500)]
        public string Descrizione { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataOraAggiornamento { get; set; }

        public virtual Spedizione Spedizione { get; set; }
    }
}