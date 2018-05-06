﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    public class Klient
    {
        [Key]
        [Range(1000000, 9999999)]
        public int KlientID { get; set; }

        [Required]
        [MaxLength(20), MinLength(2)]
        public string Imie { get; set; }

        [Required]
        [MaxLength(20), MinLength(2)]
        public string Nazwisko { get; set; }

        [Required]
        //poźniej można wrzucić weryfikację poprawności 
        //- czy jest poprawny oraz czy osoba ma ukończone 18 lat
        [Range(1900010100000, 200010100000)]
        public int PESEL { get; set; }


        public virtual List<Telefon> NumeryTelefonow { get; set; }
        public List<Adres> Adresy { get; set; }
    }
}
