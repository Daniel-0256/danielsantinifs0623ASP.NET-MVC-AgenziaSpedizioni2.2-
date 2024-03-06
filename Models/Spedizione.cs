using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgenziaSpedizioni.Models
{
    public class Spedizione
    {
        [Key]
        public int IDSpedizione { get; set; }

        [Required]
        [ForeignKey("Utente")]
        public int IDUtente { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataSpedizione { get; set; }

        [Required]
        public double Peso { get; set; }

        [Required]
        [MaxLength(255)]
        public string CittaDestinataria { get; set; }

        [Required]
        [MaxLength(255)]
        public string IndirizzoDestinatario { get; set; }

        [Required]
        [MaxLength(255)]
        public string NomeDestinatario { get; set; }

        [Required]
        public double CostoSpedizione { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataConsegnaPrevista { get; set; }

        public virtual Utente Utente { get; set; }
    }
}