using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgenziaSpedizioni.Models
{
    public class Utente
    {
        [Key]
        public int IDUtente { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(255)]
        public string Password { get; set; }

        [Required]
        public bool Azienda { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(255)]
        public string Cognome { get; set; }

        [MaxLength(16)]
        public string CodiceFiscale { get; set; }

        [MaxLength(11)]
        public string PartitaIVA { get; set; }

        public bool Admin { get; set; }
    }
}